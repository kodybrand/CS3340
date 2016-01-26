Public Class FormClassShow

    Private Const MAX_BUTTON_COUNT As Integer = 4
    ' For event resize
    Private Const BUTTON_HEIGHT As Integer = 23
    Private Const BUTTON_WIDTH As Integer = 75
    Private Const MENU_HEIGHT As Integer = 24
    Private Const MARGIN_SIZE As Integer = 100
    Private _frmCreate As FormClassCreate

    Private _allButtons As New SortedList

    Private Sub FormClassShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Hide()
        FormClassCreate.Show()
    End Sub
End Class