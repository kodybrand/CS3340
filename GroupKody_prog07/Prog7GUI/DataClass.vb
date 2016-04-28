Imports Microsoft.Win32

'----------------------------------------------
' Name: GroupKody
' Date: 4/28/2016
' Description: Program7
'              Class DataClass: Handles all the setup of the tables.
'               
'----------------------------------------------

Public Class DataClass
    Public Shared myCon As New OleDb.OleDbConnection

    Public Shared dbkey As Microsoft.Win32.RegistryKey
    Public Shared dblocation As String

    ' Employee
    Public Shared employeeTbl As New System.Data.DataTable("Employees")
    Public Shared employeeCmd As New OleDb.OleDbCommand
    Public Shared employeeAdapter As New OleDb.OleDbDataAdapter
    Public Shared employeeBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Product
    Public Shared productTbl As New System.Data.DataTable("Products")
    Public Shared productCmd As New OleDb.OleDbCommand
    Public Shared productAdapter As New OleDb.OleDbDataAdapter
    Public Shared productBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Order
    Public Shared orderTbl As New System.Data.DataTable("Orders")
    Public Shared orderCmd As New OleDb.OleDbCommand
    Public Shared orderAdapter As New OleDb.OleDbDataAdapter
    Public Shared orderBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Customer
    Public Shared customerTbl As New System.Data.DataTable("Customers")
    Public Shared customerCmd As New OleDb.OleDbCommand
    Public Shared customerAdapter As New OleDb.OleDbDataAdapter
    Public Shared customerBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' OrderDetail
    Public Shared orderDetailTbl As New System.Data.DataTable("OrderDetails")
    Public Shared orderDetailCmd As New OleDb.OleDbCommand
    Public Shared orderDetailAdapter As New OleDb.OleDbDataAdapter
    Public Shared orderDetailBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Sets up all the tables
    Public Shared Sub setUpTable()

        Try
            dbkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\UWPCS3340Prog7")
            dblocation = dbkey.GetValue("Software\UWPCS3340Prog7", "")
            myCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataClass.dblocation

            ' Employee
            DataClass.employeeCmd.Connection = DataClass.myCon
            DataClass.employeeCmd.CommandType = CommandType.Text
            DataClass.employeeCmd.CommandText = "Select * from employees"
            DataClass.employeeAdapter.SelectCommand = DataClass.employeeCmd
            DataClass.employeeBuilder = New OleDb.OleDbCommandBuilder(DataClass.employeeAdapter)
            DataClass.employeeAdapter.Fill(DataClass.employeeTbl)

            ' Customer
            DataClass.customerCmd.Connection = DataClass.myCon
            DataClass.customerCmd.CommandType = CommandType.Text
            DataClass.customerCmd.CommandText = "Select * from customers"
            DataClass.customerAdapter.SelectCommand = DataClass.customerCmd
            DataClass.customerBuilder = New OleDb.OleDbCommandBuilder(DataClass.customerAdapter)
            DataClass.customerAdapter.Fill(DataClass.customerTbl)

            ' Product
            DataClass.productCmd.Connection = DataClass.myCon
            DataClass.productCmd.CommandType = CommandType.Text
            DataClass.productCmd.CommandText = "Select * from products"
            DataClass.productAdapter.SelectCommand = DataClass.productCmd
            DataClass.productBuilder = New OleDb.OleDbCommandBuilder(DataClass.productAdapter)
            DataClass.productAdapter.Fill(DataClass.productTbl)

            ' Order
            DataClass.orderCmd.Connection = DataClass.myCon
            DataClass.orderCmd.CommandType = CommandType.Text
            DataClass.orderCmd.CommandText = "Select * from Orders"
            DataClass.orderAdapter.SelectCommand = DataClass.orderCmd
            DataClass.orderBuilder = New OleDb.OleDbCommandBuilder(DataClass.orderAdapter)
            DataClass.orderAdapter.Fill(DataClass.orderTbl)

            ' Order Details
            DataClass.orderDetailCmd.Connection = DataClass.myCon
            DataClass.orderDetailCmd.CommandType = CommandType.Text
            DataClass.orderDetailCmd.CommandText = "Select * from orderDetails"
            DataClass.orderDetailAdapter.SelectCommand = DataClass.orderDetailCmd
            DataClass.orderDetailBuilder = New OleDb.OleDbCommandBuilder(DataClass.orderDetailAdapter)
            DataClass.orderDetailAdapter.Fill(DataClass.orderDetailTbl)
        Catch ex As Exception
            Dim openDB As New OpenFileDialog
            If openDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dblocation = openDB.FileName
                myCon.ConnectionString &= dblocation

                dbkey.SetValue("Software\UWPCS3340Prog7", dblocation, RegistryValueKind.String)
            End If
        End Try
    End Sub
End Class
