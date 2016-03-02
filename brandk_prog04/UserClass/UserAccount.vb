Imports System.Threading
Imports System.Windows.Forms

Public Class UserAccount

    Protected Shared AllUsers As List(Of UserAccount) = New List(Of UserAccount)
    Private Shared _allTerminated As New ManualResetEvent(False)
    Private Const MIN_WORK_TIME As Integer = 3000
    Private Const MAX_WORK_TIME As Integer = 5000
    Private Const MIN_TRANSACTION As Integer = -100
    Private Const MAX_TRANSACTION As Integer = 100
    Private _thread As System.Threading.Thread
    Private _id As String
    Private _mainForm As System.Windows.Forms.Form
    Private _state As UserAccount.UserState
    Private _randomGenerator As System.Random
    Private _workTime As Integer
    Private _transactionAmount As Integer
    Private _totalTransactionAmount As Integer
    Private _trans As UserAccount.TransactionDelegate
    Private _report As UserAccount.PassMessageDelegate
    Private _userWait As New ManualResetEvent(False)

    ' To invoke delegates on a form.
    Public WriteOnly Property MainForm As System.Windows.Forms.Form
        Set(value As System.Windows.Forms.Form)
            _mainForm = value
        End Set
    End Property

    ' TransactionDelegate is a delegate.
    Public WriteOnly Property TheTransaction As TransactionDelegate
        Set(value As TransactionDelegate)
            Me._trans = value
        End Set
    End Property

    ' PassMessageDelegate is a delegate.
    Public WriteOnly Property TheReport As PassMessageDelegate
        Set(value As PassMessageDelegate)
            Me._report = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me._userWait = New ManualResetEvent(False)
        Me._thread = New Thread(New ThreadStart(AddressOf Me.run))
        Me._randomGenerator = New Random
        Me._totalTransactionAmount = 0
        Me._id = "KB" + Me._thread.GetHashCode.ToString
    End Sub

    ' To start a user thread.
    Public Sub SpinUp()
        Me._state = UserState.Working
        Me._thread.Start()
    End Sub

    ' To terminate the user.
    Public Sub SpinDown()
        Me._state = UserState.Terminated
        Me._userWait.Set()
    End Sub

    ' To suspend the user.
    ' Should have no effect if the user is in Waiting state.
    Public Sub UserWait()
        Me._state = UserState.Waiting
        Me._userWait.Reset()
    End Sub

    ' To wake up the user.
    ' Should have no effect if the user is in Working state.
    Public Sub UserContinue()
        Me._state = UserState.Working
        Me._userWait.Set()
    End Sub

    ' To terminate all user threads.
    Public Shared Sub TerminateAllUsers()
        If (UserAccount.AllUsers.Count <= 0) Then
            Return
        End If
        UserAccount._allTerminated.Reset()
        Dim index = UserAccount.AllUsers.Count - 1
        While (index >= 0)
            UserAccount.AllUsers(index).SpinDown()
            index += -1
        End While
        UserAccount._allTerminated.WaitOne()
    End Sub

    ' To get the UserAccount object at given index of list AllUsers.
    Public Shared Function GetUserByIndex(ByVal index As Integer) As UserAccount
        Return UserAccount.AllUsers(index)
    End Function

    Private Sub run()
        UserAccount.AllUsers.Add(Me)
        Me._mainForm.Invoke(Me._report, Me._id, Me._state)
        While (Not Me._state = UserAccount.UserState.Terminated)
            Me._workTime = Me._randomGenerator.Next(MIN_WORK_TIME, MAX_WORK_TIME)
            Thread.Sleep(Me._workTime)
            Me._transactionAmount = Me._randomGenerator.Next(MIN_TRANSACTION, MAX_TRANSACTION)
            Me._mainForm.Invoke(Me._trans, Me._id, Me._transactionAmount)
            If (Me._state = UserState.Waiting) Then
                Me._mainForm.Invoke(Me._report, Me._id, Me._state)
                Me._userWait.Reset()
                Me._userWait.WaitOne()
                If (Me._state = UserState.Working) Then
                    Me._mainForm.Invoke(Me._report, Me._id, Me._state)
                End If
            End If
        End While
        Me._mainForm.Invoke(Me._report, Me._id, Me._state)
        Me._mainForm.Invoke(Me._trans, Me._id, Me._totalTransactionAmount)
        UserAccount.AllUsers.Remove(Me)
        If (Not UserAccount.AllUsers.Count = 0) Then
            Return
        End If
        UserAccount._allTerminated.Set()
    End Sub

    Public Delegate Sub TransactionDelegate(ByVal ID As String, ByVal Amount As Integer, ByVal Final As Boolean)
    Public Delegate Sub PassMessageDelegate(ByVal ID As String, ByVal State As UserState)

    Public Enum UserState
        Working
        Waiting
        Terminated
    End Enum

End Class
