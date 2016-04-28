Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class FormGridClass


    Private _mainForm As Form
    Private _theTable As DataTable
    Private _theAdapter As OleDbDataAdapter

    Public WriteOnly Property MainForm
        Set(value)
            _mainForm = value
        End Set
    End Property

    Public WriteOnly Property TheTable
        Set(value)
            _theTable = value
        End Set
    End Property

    Public WriteOnly Property TheAdapter
        Set(value)
            _theAdapter = value
        End Set
    End Property


    Private Sub FormGridClass_Load(sender As Object, e As EventArgs) Handles Me.Load
        TheBindingSource.DataSource = _theTable
        TheBindingNavigator.BindingSource = TheBindingSource
        TheDataGridView.DataSource = TheBindingSource
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        EnableButtons()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            _theTable.Clear()
            _theAdapter.Fill(_theTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            TheBindingSource.EndEdit()
            _theAdapter.Update(_theTable)
            EnableButtons()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        TheBindingNavigator.MoveFirstItem.Enabled = False
        TheBindingNavigator.MovePreviousItem.Enabled = False
        TheBindingNavigator.MoveNextItem.Enabled = False
        TheBindingNavigator.MoveLastItem.Enabled = False
        btnFirst.Enabled = False
        btnPrev.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnNew.Enabled = False
        btnReload.Enabled = False
        btnBack.Enabled = False
    End Sub

    Private Sub EnableButtons()
        TheBindingNavigator.MoveFirstItem = btnFirst
        TheBindingNavigator.MovePreviousItem = btnPrev
        TheBindingNavigator.MoveNextItem = btnNext
        TheBindingNavigator.MoveLastItem = btnLast
        btnNew.Enabled = True
        btnReload.Enabled = True
        btnBack.Enabled = True
        If TheBindingSource.Count <= 1 Then
            Return
        End If
        If (TheBindingSource.Position = 0) Then

            btnNext.Enabled = True
            btnLast.Enabled = True

        ElseIf (TheBindingSource.Position = (TheBindingSource.Count - 1)) Then

            btnFirst.Enabled = True
            btnPrev.Enabled = True

        Else
            btnNext.Enabled = True
            btnLast.Enabled = True
            btnFirst.Enabled = True
            btnPrev.Enabled = True
        End If
    End Sub
End Class