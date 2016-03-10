Imports UWPCS3340
Imports System.Runtime.CompilerServices
Imports System.Threading


'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class FormClassThread
'                 
'----------------------------------------------

Public MustInherit Class Reader : Inherits ReaderWriter

    Public Overrides ReadOnly Property ID As String
        Get
            Return "Reader_KB" + Convert.ToSingle(Me._thread.GetHashCode)
        End Get
    End Property

    Public Overrides ReadOnly Property type As ReaderWriter.ReaderWriterType
        Get
            Return ReaderWriterType.Reader
        End Get
    End Property

    Protected Overrides Sub run()
        ReaderWriter._database.LockDataObj()
        Monitor.Enter(ReaderWriter.FIFOQueue)
        If (ReaderWriter.FIFOQueue.Count > 0 Or ReaderWriter._database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Writing) Then
            ReaderWriter.FIFOQueue.Enqueue(Me)
            Me._mainForm.Invoke(Me._passMsg, Me.ID, ReaderWriter.State.Waiting, -1000)
            Monitor.Exit(ReaderWriter.FIFOQueue)
            ReaderWriter._database.ReleaseDataObj()
            Me._ReaderWriterEvent.WaitOne()
            Me.WakeupNextReader()
        Else
            Monitor.Exit(ReaderWriter.FIFOQueue)
            ReaderWriter._database.ReleaseDataObj()
        End If
        ReaderWriter._database.LockDataObj()
        ReaderWriter._database.IncreaseReaderCount()
        ReaderWriter._database.ReleaseDataObj()
        Me._mainForm.Invoke(Me._passMsg, Me.ID, ReaderWriter.State.Working, ReaderWriter._database.TotalValue)
        Thread.Sleep(_rondomGenerator.Next(2000, 3000))
        Me._mainForm.Invoke(Me._passMsg, Me.ID, ReaderWriter.State.Finished, ReaderWriter._database.TotalValue)
        If (ReaderWriter._database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then
            ReaderWriter.WakeupNextWhenExiting()
        End If
        ReaderWriter._database.ReleaseDataObj()
    End Sub
    Protected Sub WakeupNextReader()

    End Sub




End Class
