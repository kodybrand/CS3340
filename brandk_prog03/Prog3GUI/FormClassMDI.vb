Imports UWPCS3340
Imports System.Windows.Forms

Public Class FormClassMDI

    Private _branchCount As Integer

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        lblDate.Text = System.DateTime.Now
        Try
            Dim f As FormClassBranch = New FormClassBranch
            f.MdiParent = Me
            _branchCount = _branchCount + 1
            f.BranchNo = _branchCount
            f.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub FormClassMDI_Load(sender As Object, e As EventArgs)
        lblDate.Text = System.DateTime.Now
        Dim f As FormClassHouse

        f = New FormClassHouse
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub FormClassMDI_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = System.DateTime.Now
    End Sub
End Class