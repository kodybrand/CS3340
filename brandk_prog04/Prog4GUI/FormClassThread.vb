Imports System.Threading
Imports UWPCS3340

Public Class FormClassThread

    Private balance As Integer
    Private transaction As Integer
    Private aUser As UserAccount

    Private Sub mmm()
        aUser = New UserAccount
        aUser.
    End Sub


    Private Sub FormClassThread_Load(sender As Object, e As EventArgs) Handles Me.Load
        balance = 1000
        transaction = 0
        txtTotalBalance.Text = FormatCurrency(balance)
        txtTotalTransacions.Text = FormatCurrency(transaction)
        ' doClear?

    End Sub
End Class