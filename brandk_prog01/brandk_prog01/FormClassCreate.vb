Public Class FormClassCreate

    Private _frmShow As FormClassShow

    Public Sub New()
        InitializeComponent()

        _frmShow = New FormClassShow
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Hide()
        _frmShow.Show()
        _frmShow.BringToFront()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        Dim theCaption As String
        Dim theKey As String

        theCaption = txtCaption.Text.Trim()
        theKey = txtKey.Text.Trim()

        _frmShow.addButton(theCaption, theKey)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        _frmShow.removeButton(txtKey.Text)
    End Sub
End Class