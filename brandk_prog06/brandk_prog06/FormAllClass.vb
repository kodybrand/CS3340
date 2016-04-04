Imports Microsoft.Win32

Public Class FormAllClass



    Friend dbkey As Microsoft.Win32.RegistryKey

    Shared _frmIndividual As FormIndividualClass

    Friend dblocation As String
    Friend connString As String

    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)

    End Sub

    Private Sub FormAllClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _frmIndividual = New FormIndividualClass
        _frmIndividual._mainForm = Me

        Dim connected As Boolean = False

        While Not connected
            Try
                dbkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\UWPCS3340Prog6")
                dblocation = dbkey.GetValue("Software\UWPCS3340Prog6", "")
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dblocation

                EmployeeTableAdapter.Connection.ConnectionString = connString

                'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
                Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
                connected = True
                Me.BringToFront()
            Catch ex As Exception
                connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

                Dim openDB As New OpenFileDialog
                If openDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    dblocation = openDB.FileName
                    connString &= dblocation

                    dbkey.SetValue("Software\UWPCS3340Prog6", dblocation, RegistryValueKind.String)
                Else
                    Exit While
                End If
            End Try
        End While

        If Not connected Then
            MsgBox("No database selected!")
            Application.Exit()
        End If

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