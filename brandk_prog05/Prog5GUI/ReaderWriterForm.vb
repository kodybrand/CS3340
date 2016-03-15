'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class FormClassThread
'                 Handles the starting of processes
'----------------------------------------------

Imports UWPCS3340
Imports System.Windows.Forms
Imports System.Threading

Public Class ReaderWriterForm
    Private rw As ReaderWriter
    Private db As DatabaseClass
    Private dThread As Thread
    Private delegateVaribles As ReaderWriterForm.EnableButtons

    ' NEw reader actions
    Private Sub btnReader_Click(sender As Object, e As EventArgs) Handles btnNewReader.Click
        rw = New Reader
        rw.DisplayMsg = New ReaderWriter.PassMessage(AddressOf delegateSub)
        rw.MainForm = Me
        Thread.Sleep(100)
        rw.SpinUp()
    End Sub

    ' new Writer actions
    Private Sub btnWriter_Click(sender As Object, e As EventArgs) Handles btnNewWriter.Click
        rw = New Writer
        rw.MainForm = Me
        rw.DisplayMsg = New ReaderWriter.PassMessage(AddressOf delegateSub)
        rw.SpinUp()
    End Sub
    ' enable buttons
    Private Sub SubToEndableButtons()
        btnExit.Enabled = True
        btnNewReader.Enabled = True
        btnNewWriter.Enabled = True
    End Sub

    ' Wait for times to end
    Private Sub WaitForAllReadersWritersTerminate()
        ReaderWriter.FinishReadWrite()
        If (MessageBox.Show("Do you want to exit?", "Program 5", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        Else
            Me.Invoke(delegateVaribles)
        End If
    End Sub


    Private Delegate Sub EnableButtons()

    ' Button Exit actions
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        dThread = New Thread(New ThreadStart(AddressOf WaitForAllReadersWritersTerminate))
        dThread.Start()
        btnExit.Enabled = False
        btnNewReader.Enabled = False
        btnNewWriter.Enabled = False
    End Sub

    ' Loading form actions
    Private Sub ReaderWriterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New DatabaseClass(1000)
        ReaderWriter.TheDatabase = db
        txtTotal.Text = "1000"
        delegateVaribles = New ReaderWriterForm.EnableButtons(AddressOf SubToEndableButtons)
    End Sub

    ' Deleting the dub
    Private Sub delegateSub(ByVal id As String, ByVal state As ReaderWriter.State, ByVal total As Integer)
        If Not total = -1000 Then
            txtTotal.Text = total.ToString
        End If
        If (state = ReaderWriter.State.Waiting) Then
            lstWaiting.Items.Add(id)
        Else
            If (state = ReaderWriter.State.Working) Then
                Dim index1 As Integer = -1
                Dim num1 As Integer = 0
                Dim num2 As Integer = lstWaiting.Items.Count - 1
                Dim index2 As Integer = num1
                While (index2 <= num2)
                    If (lstWaiting.Items(index2).ToString.Contains(id)) Then
                        index1 = index2
                    End If
                    index2 = index2 + 1
                End While
                If (Not index1 = -1) Then
                    lstWaiting.Items.RemoveAt(index1)
                End If
                lstWorking.Items.Add(id)
                txtLog.Text = txtLog.Text + id.PadRight(11) + ": Start to work: Total is " + total.ToString + vbCrLf
            Else
                lstWorking.Items.RemoveAt(0)
                txtLog.Text = txtLog.Text + id.PadRight(11) + ": Finished work: Total is " + total.ToString + vbCrLf
            End If
            txtLog.SelectionStart = txtLog.TextLength
            txtLog.ScrollToCaret()
        End If
    End Sub

End Class