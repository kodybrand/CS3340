Public Class FormIndividualClass

    Friend MainForm As FormAllClass

    Private Sub FormIndividualClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAllEmployees_Click(sender As Object, e As EventArgs) Handles btnAllEmployees.Click
        Me.Hide()
        Me.MainForm.Show()
        Me.MainForm.BringToFront()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            EmployeeBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(ActivityDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class