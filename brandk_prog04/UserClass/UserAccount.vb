Imports System.Threading

Public Class UserAccount

    Protected Shared AllUsers As List(Of UserAccount) = New List(Of UserAccount)
    Private Const MIN_WORK_TIME As Integer = 3000
    Private Const MAX_WORK_TIME As Integer = 5000
    Private Const MIN_TRANSACTION As Integer = -100
    Private Const MAX_TRANSACTION As Integer = 100
    Private _thread As Thread
    Private _id As String
    ' Private _mainForm As 
    ' Private _state
    Private _randomGenerator As Random
    Private _workTime As Integer
    Private _transactionAmount As Integer
    Private _totalTransactionAmount
    ' Private _trans
    ' Private _report
    Private _userWait As ManualResetEventSlim




End Class
