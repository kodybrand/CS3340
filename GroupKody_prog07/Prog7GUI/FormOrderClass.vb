'----------------------------------------------
' Name: GroupKody
' Date: 4/28/2016
' Description: Program7
'              Class FormOrderClass : The form that handles the orders, can manage the orders from this
'                       window. 
'----------------------------------------------

Public Class FormOrderClass

    Private _mainForm As Form
    Private _orderView As DataView
    Private _detailView As DataView
    Private orderBinding As BindingSource
    Private employeeBinding As BindingSource

    ' Sets the MainFrom Property
    Public WriteOnly Property MainForm
        Set(value)
            _mainForm = value
        End Set
    End Property

    ' Handles the Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    ' Constructor for the form.
    Public Sub FormOrderClass()
        orderBinding = New BindingSource()
        employeeBinding = New BindingSource()
        InitializeComponent()
    End Sub

    ' Action when the checkbox is changed
    Private Sub rdoall_checkedchanged(sender As Object, e As EventArgs) Handles rdoAll.CheckedChanged
        If rdoAll.Checked Then
            txtName.Text = ""
            txtID.Text = ""
            btnPrevious.Enabled = False
            btnNext.Enabled = False
            _orderView.RowFilter = ""
        Else
            If rdoEmployee.Checked Then
                End
            End If
            employeeBinding.Position = 0
            DoButtons()
        End If
    End Sub

    ' Handles when the Previous button
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        employeeBinding.MovePrevious()
        DoButtons()
    End Sub

    ' Manages the button switches
    Private Sub DoButtons()
        txtID.DataBindings.Clear()
        txtName.DataBindings.Clear()
        If employeeBinding.Count > 1 Then
            btnPrevious.Enabled = True
            If employeeBinding.Position = 0 Then
                btnPrevious.Enabled = False

            ElseIf employeeBinding.Position = (employeeBinding.Count - 1) Then
                btnNext.Enabled = False
            End If
        Else
            btnPrevious.Enabled = False
            btnNext.Enabled = False
        End If
        txtID.DataBindings.Add("text", employeeBinding, "EmployeeID")
        txtName.DataBindings.Add("text", employeeBinding, "Name")
        _orderView.RowFilter = "Employee = '" + txtID.Text + "'"
    End Sub

    ' Handles the Next button click
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        employeeBinding.MoveNext()
        DoButtons()
    End Sub

    ' Handles the update order button
    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        Try
            Validate()
            dgvOrders.EndEdit()
            DataClass.orderAdapter.Update(DataClass.orderTbl)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dgvOrders.ShowCellErrors = False
        End Try
    End Sub

    ' Handles the update Details button
    Private Sub btnUpdateDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDetails.Click
        Try
            Validate()
            dgvDetails.EndEdit()
            DataClass.orderDetailAdapter.Update(DataClass.orderDetailTbl)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dgvDetails.ShowCellErrors = False
        End Try
    End Sub

    ' When the orderSelection is changed.
    'Private Sub dgvOrders_SelectionChanged(sender As Object, e As EventArgs)
    '    If Not orderBinding.Position - 1 Then
    '        Dim Left = orderBinding.Current

    '    End If
    'End Sub

    ' Handels when the form is loaded.
    Private Sub FormOrderClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _detailView = New DataView(DataClass.orderDetailTbl)
        dgvDetails.DataSource = _detailView
        dgvDetails.Columns(3).DefaultCellStyle.Format = "C2"
        dgvDetails.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetails.Columns(4).DefaultCellStyle.Format = "C2"
        dgvDetails.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        _orderView = New DataView(DataClass.orderTbl)
        orderBinding.DataSource = _orderView
        dgvOrders.DataSource = orderBinding
        employeeBinding.DataSource = DataClass.employeeTbl
    End Sub
End Class