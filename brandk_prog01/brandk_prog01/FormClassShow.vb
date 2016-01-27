Public Class FormClassShow

    Private Const MAX_BUTTON_COUNT As Integer = 4
    Private xPos As Integer = 100
    ' For event resize
    Private Const BUTTON_HEIGHT As Integer = 23
    Private Const BUTTON_WIDTH As Integer = 75
    Private Const MENU_HEIGHT As Integer = 24
    Private Const MARGIN_SIZE As Integer = 100

    Private _allButtons As New SortedList

    Private _mainForm As FormClassCreate

    Public WriteOnly Property MainForm As Form
        Set(ByVal value As Form)
            _mainForm = value
        End Set
    End Property

    ' Private method
    Friend Sub addButton(ByVal theCaption As String, ByVal theKey As String)

        If Not _allButtons.ContainsKey(theKey) Then
            Dim aButton As Button
            ' Don't use Dim here!
            Static count As Integer

            ' Gets a new button object
            aButton = New Button

            count += 1

            ' Sets the button properties
            aButton.Text = theCaption
            aButton.Tag = theKey
            aButton.Location = New System.Drawing.Point(MARGIN_SIZE + xPos, 250)
            xPos += 100

            aButton.Name = "Button " & count

            ' Set the event handler for the object pointed by aButton
            ' Even the object is not pointed by aButton later
            AddHandler aButton.Click, AddressOf ButtonClick

            ' Puts the button on the form
            Me.Controls.Add(aButton)

            ' Adds the button to the sorted list

            _allButtons.Add(theKey, aButton)
        Else
            MessageBox.Show("Key Already Exists!")
        End If



    End Sub

    Friend Sub removeButton(ByVal theKey As String)
        Dim index As Integer
        index = _allButtons.IndexOfKey(theKey)

        If index = -1 Then
            MessageBox.Show("Key Does Not Exsist!")
        Else
            Dim aButton As Button

            aButton = _allButtons.GetByIndex(index)
            Me.Controls.Remove(aButton)
            _allButtons.RemoveAt(index)
        End If

    End Sub

    Private Sub ButtonClick(sender As Object, e As EventArgs) 'Handles aButton.Click
        Dim b As Button
        b = sender

        MessageBox.Show("My Caption : " & b.Text & Chr(Keys.LineFeed) & "My Key : " & b.Tag)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    Private Sub FormClassShow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

End Class