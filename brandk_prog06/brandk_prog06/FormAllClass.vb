Public Class FormAllClass



    Shared _frmIndividual As FormIndividualClass

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)

    End Sub

    Private Sub FormAllClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _frmIndividual = New FormIndividualClass
        _frmIndividual.MainForm = Me

        'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)

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

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        Me.Hide()
        _frmIndividual.Show()
        _frmIndividual.BringToFront()
    End Sub

    Private Sub btnDBLocate_Click(sender As Object, e As EventArgs) Handles btnDBLocate.Click
        MessageBox.Show(Me.EmployeeTableAdapter.Connection.DataSource, "Program 6 Database Location")
    End Sub
End Class