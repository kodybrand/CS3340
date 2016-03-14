'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class FormClassThread
'                 
'----------------------------------------------

Imports UWPCS3340
Imports System.Windows.Forms
Imports System.Threading

Public Class ReaderWriterForm
    Private rw As ReaderWriter
    Private db As DatabaseClass
    Private dThread As Thread
    Private delegateVaribles As ReaderWriterForm.EnableButtons

    Private Sub btnReader_Click(sender As Object, e As EventArgs) Handles btnNewReader.Click
        rw = New Reader
        rw.DisplayMsg = New ReaderWriter.PassMessage(AddressOf delegateSub)
        rw.MainForm = Me
        Thread.Sleep(100)
        rw.SpinUp()
    End Sub

    Private Sub btnWriter_Click(sender As Object, e As EventArgs) Handles btnNewWriter.Click
        rw = New Writer
        rw.MainForm = Me
        rw.DisplayMsg = New ReaderWriter.PassMessage(AddressOf delegateSub)
        rw.SpinUp()
    End Sub

    Private Sub SubToEndableButtons()
        btnExit.Enabled = True
        btnNewReader.Enabled = True
        btnNewWriter.Enabled = True
    End Sub

    Private Sub WaitForAllReadersWritersTerminate()
        ReaderWriter.FinishReadWrite()
        If (MessageBox.Show("Do you want to exit?", "Program 5", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        Else
            Me.Invoke(delegateVaribles)
        End If
    End Sub


    Private Delegate Sub EnableButtons()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        dThread = New Thread(New ThreadStart(AddressOf WaitForAllReadersWritersTerminate))
        dThread.Start()
        btnExit.Enabled = False
        btnNewReader.Enabled = False
        btnNewWriter.Enabled = False
    End Sub

    Private Sub ReaderWriterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New DatabaseClass(1000)
        ReaderWriter.TheDatabase = db
        txtTotal.Text = "1000"
        delegateVaribles = New ReaderWriterForm.EnableButtons(AddressOf SubToEndableButtons)
    End Sub

    Private Sub delegateSub()

    End Sub

End Class