Public Class FormOrderClass

    Private _mainForm As Form
    Private _orderView As DataView
    Private _detailView As DataView
    Private orderBinding As BindingSource
    Private employeeBinding As BindingSource

    Public WriteOnly Property MainForm
        Set(value)
            _mainForm = value
        End Set
    End Property

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Hide()
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    Private Sub rdoAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAll.CheckedChanged
        If rdoAll.Checked Then
            txtName.Text = ""
            txtID.Text = ""
            btnPrevious.Enabled = False
            btnNext.Enabled = False
            _orderView.RowFilter = ""
        Else
            If rdoEmployee.Checked Then
                Return
            End If
            employeeBinding.Position = 0
            DoButtons()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        employeeBinding.MovePrevious()
        DoButtons()
    End Sub

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

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        employeeBinding.MoveNext()
        DoButtons()
    End Sub

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

    Private Sub dgvOrders_SelectionChanged(sender As Object, e As EventArgs) Handles dgvOrders.SelectionChanged
        If Not orderBinding.Position - 1 Then
            Dim Left = orderBinding.Current

        End If
    End Sub

    Private Sub FormOrderClass_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        rdoAll.Checked = True
    End Sub
End Class