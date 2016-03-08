'----------------------------------------------
' Name: Kody Brand
' Date: 3/3/2016
' Description: Program4
'              Class FormClassThread
'                 GUI for the program, handles the button actions and thread control
'----------------------------------------------
Imports System.Threading
Imports UWPCS3340

Public Class FormClassThread

    Private balance As Integer
    Private transaction As Integer
    Private aUser As UserAccount
    Private exitThread As Thread
    Private DoClear As FormClassThread.ClearListBox

   ' Handles when the thread is loaded.
    Private Sub FormClassThread_Load(sender As Object, e As EventArgs) Handles Me.Load
        balance = 1000
        transaction = 0
        txtTotalBalance.Text = FormatCurrency(balance)
        txtTotalTransacions.Text = FormatCurrency(transaction)
      DoClear = New FormClassThread.ClearListBox(AddressOf EnableButtons)

    End Sub

   ' What happens when the exit button is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        exitThread = New Thread(New ThreadStart(AddressOf EndProgram))
        exitThread.Start()
        btnNew.Enabled = False
        btnWait.Enabled = False
        btnContinue.Enabled = False
        btnTerminate.Enabled = False
        btnExit.Enabled = False
    End Sub

   ' What happens when the new button is clicked
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        aUser = New UserAccount
        aUser.MainForm = Me
        aUser.TheTransaction = New UserAccount.TransactionDelegate(AddressOf DoTransaction)
        aUser.TheReport = New UserAccount.PassMessageDelegate(AddressOf DoReport)
        aUser.SpinUp()
    End Sub

   ' Handles the transaction of the thread.
    Private Sub DoTransaction(ByVal id As String, ByVal amount As Integer, ByVal final As Boolean)
        If (final) Then
         Me.transaction = (Me.transaction + amount)
            txtTotalTransacions.Text = FormatCurrency(transaction)
            txtLog.Text = txtLog.Text + id + " : Total transaction - " + FormatCurrency(amount) + vbCrLf
        Else
            balance = (balance + amount)
            txtTotalBalance.Text = FormatCurrency(balance)
            txtLog.Text = txtLog.Text + id + " : " + FormatCurrency(amount) + vbCrLf
        End If
        txtLog.SelectionStart = txtLog.Text.Length
        txtLog.ScrollToCaret()
    End Sub

   ' Handles the report of the thread.
    Private Sub DoReport(ByVal id As String, ByVal state As UserAccount.UserState)
        Dim index1 As Integer = -1
        Dim num1 As Integer = 0
        Dim num2 As Integer = lstAllUsers.Items.Count - 1
        Dim index2 As Integer = num1
        While (index2 <= num2)
            If (lstAllUsers.Items(index2).ToString.Contains(id)) Then
                index1 = index2
                Exit While
            End If
            index2 = index2 + 1

        End While
        If index1 = -1 Then
            lstAllUsers.Items.Add(id + ": " + state.ToString)
            txtLog.Text = txtLog.Text + id + ": Start to work" + vbCrLf
            txtLog.SelectionStart = txtLog.Text.Length
            txtLog.ScrollToCaret()
        ElseIf (state = UserAccount.UserState.Terminated) Then
            lstAllUsers.Items.RemoveAt(index1)
        Else
            lstAllUsers.Items(index1) = (id + ": " + state.ToString)
        End If
    End Sub

   ' What happens when the terminate button is clicked
    Private Sub btnTerminate_Click(sender As Object, e As EventArgs) Handles btnTerminate.Click
        If (Not lstAllUsers.SelectedIndex <= -1) Then
            aUser = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex)
            aUser.SpinDown()
        End If
    End Sub

   ' What happens when the wait button is clicked
    Private Sub btnWait_Click(sender As Object, e As EventArgs) Handles btnWait.Click
        If (Not lstAllUsers.SelectedIndex <= -1) Then
            aUser = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex)
            aUser.UserWait()
        End If
    End Sub

   ' What happens when the continue button is clicked
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If (Not lstAllUsers.SelectedIndex <= -1) Then
            aUser = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex)
            aUser.UserContinue()
        End If
    End Sub

   ' Enables  all the buttons
   Private Sub EnableButtons()
      btnNew.Enabled = True
      btnWait.Enabled = True
      btnContinue.Enabled = True
      btnTerminate.Enabled = True
      btnExit.Enabled = True
   End Sub

   ' Process to end the program
    Private Sub EndProgram()
        UserAccount.TerminateAllUsers()
        If (MessageBox.Show("Do you want to exit?", "Program 4", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        Else
            Me.Invoke(DoClear)
        End If
    End Sub

    Private Delegate Sub ClearListBox()

End Class