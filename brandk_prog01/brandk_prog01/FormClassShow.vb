'----------------------------------------------
' Name: Kody Brand
' Date: 1/27/2016
' Description: Program1
'              Class FormClassShow. Handles the displaying of buttons, and the changing of
'               the font changing. Also changing between forms. 
'----------------------------------------------
Imports System.Windows.Forms

Public Class FormClassShow

    Private Const MAX_BUTTON_COUNT As Integer = 4
    Private Const BUTTON_HEIGHT As Integer = 23
    Private Const BUTTON_WIDTH As Integer = 75
    Private Const MENU_HEIGHT As Integer = 24
    Private Const MARGIN_SIZE As Integer = 100
    Private _allButtons As New SortedList
    Private _mainForm As FormClassCreate
    Private aButton As Button

    Public WriteOnly Property MainForm As Form
        Set(ByVal value As Form)
            _mainForm = value
        End Set
    End Property

    ' add the button to the button list
    Friend Sub addButton(ByVal theCaption As String, ByVal theKey As String)
        If theKey.Length = 0 Then
            MessageBox.Show("Must have key!")
        ElseIf _allButtons.Count = 4 Then
            MessageBox.Show("Only 4 buttons allowed!")
        ElseIf Not _allButtons.ContainsKey(theKey) Then
            aButton = New Button
            aButton.Text = theCaption
            aButton.Tag = theKey
            _allButtons.Add(theKey, aButton)
            AddHandler aButton.Click, AddressOf ButtonClick
            ArrangeButtons()
        Else
            MessageBox.Show("Key Already Exists!")
        End If

    End Sub

    ' removes button form button list
    Friend Sub removeButton(ByVal theKey As String)
        Dim index As Integer
        index = _allButtons.IndexOfKey(theKey)
        If _allButtons.Count = 0 Then
            MessageBox.Show("No buttons to delete!")
        ElseIf index = -1 Then
            MessageBox.Show("Key Does Not Exsist!")
        Else
            Dim aButton As Button

            aButton = _allButtons.GetByIndex(index)
            Me.Controls.Remove(aButton)
            _allButtons.RemoveAt(index)
        End If
        ArrangeButtons()

    End Sub

    ' Handles when the button is clicked.
    Private Sub ButtonClick(sender As Object, e As EventArgs) 'Handles aButton.Click
        Dim b As Button
        b = sender

        MessageBox.Show("My Caption : " & b.Text & Chr(Keys.LineFeed) & "My Key : " & b.Tag)

    End Sub

    ' handles when Exit is pressed
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Return to the main form form
    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    ' Disables alt + f4
    Private Sub FormClassShow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    ' Arranges all buttons on the form according to the requirements.
    Private Sub ArrangeButtons()
        Dim count As Integer
        Dim formSize As Integer
        Dim distance As Integer
        Dim temp As Integer
        Dim xPos As Integer = 100

        count = _allButtons.Count
        formSize = Me.ClientSize.Width - (MARGIN_SIZE * 2)
        distance = formSize / (count + 1)
        temp = count

        For value As Integer = 0 To count - 1 Step 1
            aButton = _allButtons.GetByIndex(value)
            aButton.Left = (xPos + distance - BUTTON_WIDTH / 2)
            distance += formSize / (count + 1)
            aButton.Top = (Me.ClientSize.Height - MENU_HEIGHT + BUTTON_HEIGHT) / 2
            Me.Controls.Add(aButton)
            setFont(aButton)
        Next
    End Sub

    ' Event for handling form resize
    Private Sub FormClassShow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ArrangeButtons()
    End Sub

    ' Changes the button fonts
    Private Sub ChangeFont(ByVal f As FontStyle, ByVal m As ToolStripMenuItem)
        For index As Integer = 0 To _allButtons.Count - 1 Step 1
            aButton = _allButtons.GetByIndex(index)
            aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor f)
        Next
    End Sub

    ' Sets the button font
    Private Sub setFont(ByVal b As Button)
        If menuBol.Checked Then
            b.Font = New Font(b.Font, b.Font.Style Or FontStyle.Bold)
        End If
        If menuIta.Checked Then
            b.Font = New Font(b.Font, b.Font.Style Or FontStyle.Italic)
        End If
        If menuUnd.Checked Then
            b.Font = New Font(b.Font, b.Font.Style Or FontStyle.Underline)
        End If
    End Sub

    ' Handles font Toggle
    Private Sub menuBol_Click(sender As Object, e As EventArgs) Handles menuBol.Click
        menuBol.Checked = Not menuBol.Checked
        ChangeFont(FontStyle.Bold, menuBol)
    End Sub

    ' Handles font Toggle
    Private Sub menuIta_Click(sender As Object, e As EventArgs) Handles menuIta.Click
        menuIta.Checked = Not menuIta.Checked
        ChangeFont(FontStyle.Italic, menuIta)
    End Sub

    ' Handles font Toggle
    Private Sub menuUnd_Click(sender As Object, e As EventArgs) Handles menuUnd.Click
        menuUnd.Checked = Not menuUnd.Checked
        ChangeFont(FontStyle.Underline, menuUnd)
    End Sub
End Class