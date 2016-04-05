'----------------------------------------------
' Name: Kody Brand
' Date: 4/05/2016
' Description: Program6
'              Class FormIndividualClass
'                 The GUI Class for individual records
'----------------------------------------------

Public Class FormIndividualClass

    Friend _mainForm As FormAllClass

    ' Loading events for GUI
    Private Sub FormIndividualClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.EmployeeTableAdapter.Connection.ConnectionString = _mainForm.connString
            EmployeeTableAdapter.Fill(ActivityDataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Handles Exit click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Handles reload click
    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Handles return to all employees
    Private Sub btnAllEmployees_Click(sender As Object, e As EventArgs) Handles btnAllEmployees.Click
        Me.Hide()
        Me._mainForm.Show()
        Me._mainForm.BringToFront()
    End Sub

    ' handles the save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            EmployeeBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(ActivityDataSet)
            EnableButtons()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ' Handles add new button
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DisableButtons()
    End Sub

    ' Disables buttons
    Private Sub DisableButtons()
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        btnAllEmployees.Enabled = False
        btnExit.Enabled = False
        btnReload.Enabled = False
    End Sub

    ' Enable buttons
    Private Sub EnableButtons()
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        btnAllEmployees.Enabled = True
        btnExit.Enabled = True
        btnReload.Enabled = True
    End Sub

    ' Handles delete button
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        EnableButtons()

    End Sub
End Class