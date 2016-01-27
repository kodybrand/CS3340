'----------------------------------------------
' Name: Kody Brand
' Date: 1/27/2016
' Description: Program1
'              Class FormClassCreate, handles the funtions of creating and removing the
'               buttons. Also changing between forms.
'----------------------------------------------

Public Class FormClassCreate

    Private _frmShow As FormClassShow

    Public Sub New()
        InitializeComponent()

        _frmShow = New FormClassShow
        _frmShow.MainForm = Me
    End Sub

    ' Handles exit button
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    ' Handles change to show form
    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Hide()
        _frmShow.Show()
        _frmShow.BringToFront()
    End Sub

    ' Handles add button click
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        Dim theCaption As String
        Dim theKey As String

        theCaption = txtCaption.Text.Trim()
        theKey = txtKey.Text.Trim()

        _frmShow.addButton(theCaption, theKey)
    End Sub

    ' Handles remove button click
    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        _frmShow.removeButton(txtKey.Text)
    End Sub

    ' Diables ALT + f4
    Private Sub FormClassCreate_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    ' Handles key press events and limits what can be inputted
    Private Sub txtKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKey.KeyPress

        If txtKey.TextLength >= 6 Then
            e.Handled = True
            MessageBox.Show("Key can have at most 6 charactors!")
        End If

    End Sub

End Class