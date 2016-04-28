Imports Microsoft.Win32

Public Class DataClass
    Public Shared myCon As New OleDb.OleDbConnection

    Public Shared dbkey As Microsoft.Win32.RegistryKey
    Public Shared dblocation As String

    ' Employee
    Public Shared employeeTbl As New System.Data.DataTable("Employee")
    Public Shared employeeCmd As New OleDb.OleDbCommand
    Public Shared employeeAdapter As New OleDb.OleDbDataAdapter
    Public Shared employeeBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Product
    Public Shared productTbl As New System.Data.DataTable("Product")
    Public Shared productCmd As New OleDb.OleDbCommand
    Public Shared productAdapter As New OleDb.OleDbDataAdapter
    Public Shared productBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Order
    Public Shared orderTbl As New System.Data.DataTable("Order")
    Public Shared orderCmd As New OleDb.OleDbCommand
    Public Shared orderAdapter As New OleDb.OleDbDataAdapter
    Public Shared orderBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' Customer
    Public Shared customerTbl As New System.Data.DataTable("Customers")
    Public Shared customerCmd As New OleDb.OleDbCommand
    Public Shared customerAdapter As New OleDb.OleDbDataAdapter
    Public Shared customerBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one

    ' OrderDetail
    Public Shared orderDetailTbl As New System.Data.DataTable("orderDetail")
    Public Shared orderDetailCmd As New OleDb.OleDbCommand
    Public Shared orderDetailAdapter As New OleDb.OleDbDataAdapter
    Public Shared orderDetailBuilder As OleDb.OleDbCommandBuilder  ' Not New for this one


    Public Shared Sub setUpTable()

        Try
            dbkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\UWPCS3340Prog7")
            dblocation = dbkey.GetValue("Software\UWPCS3340Prog7", "")
            myCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DataClass.dblocation

            ' Employee Table
            employeeCmd.Connection = DataClass.myCon
            employeeCmd.CommandType = CommandType.Text
            employeeCmd.CommandText = "Select * from employees"
            employeeAdapter.SelectCommand = DataClass.employeeCmd
            employeeBuilder = New OleDb.OleDbCommandBuilder(employeeAdapter)
            employeeAdapter.Fill(DataClass.employeeTbl)

            employeeBuilder = New OleDb.OleDbCommandBuilder(employeeAdapter)
            employeeAdapter.Fill(employeeTbl)

            ' Product Table
            productCmd.Connection = DataClass.myCon
            productCmd.CommandType = CommandType.Text
            productCmd.CommandText = "Select * from products"
            productAdapter.SelectCommand = DataClass.productCmd
            productBuilder = New OleDb.OleDbCommandBuilder(productAdapter)
            productAdapter.Fill(DataClass.productTbl)

            productBuilder = New OleDb.OleDbCommandBuilder(productAdapter)
            productAdapter.Fill(productTbl)

            ' Order Table
            orderCmd.Connection = DataClass.myCon
            orderCmd.CommandType = CommandType.Text
            orderCmd.CommandText = "Select * from orders"
            orderAdapter.SelectCommand = DataClass.orderCmd
            orderBuilder = New OleDb.OleDbCommandBuilder(orderAdapter)
            orderAdapter.Fill(DataClass.orderTbl)

            orderBuilder = New OleDb.OleDbCommandBuilder(orderAdapter)
            orderAdapter.Fill(orderTbl)

            ' Customer Table
            customerCmd.Connection = DataClass.myCon
            customerCmd.CommandType = CommandType.Text
            customerCmd.CommandText = "Select * from customers"
            customerAdapter.SelectCommand = DataClass.customerCmd
            customerBuilder = New OleDb.OleDbCommandBuilder(customerAdapter)
            customerAdapter.Fill(DataClass.customerTbl)

            customerBuilder = New OleDb.OleDbCommandBuilder(customerAdapter)
            customerAdapter.Fill(customerTbl)

            ' OrderDetail Table
            orderDetailCmd.Connection = DataClass.myCon
            orderDetailCmd.CommandType = CommandType.Text
            orderDetailCmd.CommandText = "Select * from orderDetails"
            orderDetailAdapter.SelectCommand = DataClass.orderDetailCmd
            orderDetailBuilder = New OleDb.OleDbCommandBuilder(orderDetailAdapter)
            orderDetailAdapter.Fill(DataClass.orderDetailTbl)

            orderDetailBuilder = New OleDb.OleDbCommandBuilder(orderDetailAdapter)
            orderDetailAdapter.Fill(orderDetailTbl)

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
