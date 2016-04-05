Imports Microsoft.Win32

'----------------------------------------------
' Name: Kody Brand
' Date: 4/05/2016
' Description: Program6
'              Class FormAllClass
'                 The GUI Class for all records
'----------------------------------------------

Public Class FormAllClass



    Friend dbkey As Microsoft.Win32.RegistryKey

    Shared _frmIndividual As FormIndividualClass

    Friend dblocation As String
    Friend connString As String

    ' Hanles the save button
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)

    End Sub

    ' Loading event for the form
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

    ' Handles the exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Handles the reload button
    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Changes form to individual form
    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        Me.Hide()
        _frmIndividual.Show()
        _frmIndividual.BringToFront()
    End Sub

    ' Displays the db location
    Private Sub btnDBLocate_Click(sender As Object, e As EventArgs) Handles btnDBLocate.Click
        MessageBox.Show(Me.EmployeeTableAdapter.Connection.DataSource, "Program 6 Database Location")
    End Sub
End Class