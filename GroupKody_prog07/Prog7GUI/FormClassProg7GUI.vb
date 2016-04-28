Imports UWPCS3340

Public Class FormClassProg7GUI

    Private _employeeGridFrom As FormGridClass
    Private _productGridForm As FormGridClass
    Private _customerGridForm As FormGridClass
    Private _orderForm As FormOrderClass

    Private Sub FormClassProg7GUI_Load(sender As Object, e As EventArgs) Handles Me.Load

        DataClass.setUpTable()

        _employeeGridFrom = New FormGridClass
        _employeeGridFrom.Text = "Employees"
        _employeeGridFrom.MainForm = Me
        _employeeGridFrom.TheAdapter = DataClass.employeeAdapter
        _employeeGridFrom.TheTable = DataClass.employeeTbl

        _productGridForm = New FormGridClass
        _productGridForm.Text = "Products"
        _productGridForm.MainForm = Me
        _productGridForm.TheAdapter = DataClass.productAdapter
        _productGridForm.TheTable = DataClass.productTbl

        _customerGridForm = New FormGridClass
        _customerGridForm.Text = "Customers"
        _customerGridForm.MainForm = Me
        _customerGridForm.TheAdapter = DataClass.customerAdapter
        _customerGridForm.TheTable = DataClass.customerTbl

        _orderForm = New FormOrderClass
        _orderForm.MainForm = Me

    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        _employeeGridFrom.Show()
        _employeeGridFrom.BringToFront()
    End Sub

    Private Sub bntExit_Click(sender As Object, e As EventArgs) Handles bntExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        _customerGridForm.Show()
        _customerGridForm.BringToFront()
    End Sub

    Private Sub btnDB_Click(sender As Object, e As EventArgs) Handles btnDB.Click
        MessageBox.Show(DataClass.dbLocation)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Hide()
        _orderForm.Show()
        _orderForm.BringToFront()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Show()
        _productGridForm.Show()
        _productGridForm.BringToFront()
    End Sub
End Class