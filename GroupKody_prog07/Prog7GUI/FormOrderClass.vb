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

End Class