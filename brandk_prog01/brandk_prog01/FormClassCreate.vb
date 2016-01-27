Public Class FormClassCreate

    Private _frmShow As FormClassShow

    Public Sub New()
        InitializeComponent()

        _frmShow = New FormClassShow
        _frmShow.MainForm = Me
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

    Private Sub FormClassCreate_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FormClassCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKey.KeyPress

        If txtKey.TextLength >= 6 Then
            e.Handled = True
            MessageBox.Show("Key can have at most 6 charactors!")
        End If

    End Sub

End Class