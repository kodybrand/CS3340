Imports UWPCS3340
Imports System.Diagnostics
Imports System.Threading
'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class Writer
'                 
'----------------------------------------------

Public Class Writer : Inherits ReaderWriter

    Public Overrides ReadOnly Property ID As String
        Get
            Return "Writer_KB" + Convert.ToString(Me._thread.GetHashCode())
        End Get
    End Property

    Public Overrides ReadOnly Property type As ReaderWriter.ReaderWriterType
        Get
            Return ReaderWriterType.Writer
        End Get
    End Property

    Protected Overrides Sub run()
        ReaderWriter._database.LockDataObj()
        Monitor.Enter(ReaderWriter.FIFOQueue)
        If (ReaderWriter.FIFOQueue.Count > 0 Or (Not ReaderWriter._database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty)) Then
            ReaderWriter.FIFOQueue.Enqueue(Me)
            Me._mainForm.Invoke(Me._passMsg, Me.ID, ReaderWriter.State.Waiting, -1000)
            Monitor.Exit(ReaderWriter.FIFOQueue)
            ReaderWriter._database.ReleaseDataObj()
            Me._ReaderWriterEvent.WaitOne()
        Else
            Monitor.Exit(ReaderWriter.FIFOQueue)
            ReaderWriter._database.ReleaseDataObj()
        End If
        ReaderWriter._database.LockDataObj()
        ReaderWriter._database.IncreaseWriterCount()
        ReaderWriter._database.ReleaseDataObj()
        Me._mainForm.Invoke(Me._passMsg, Me.ID, ReaderWriter.State.Working, ReaderWriter._database.TotalValue)
        Thread.Sleep(Me._rondomGenerator.Next(3000, 4000))
        Dim num As Integer = Me._rondomGenerator.Next(-1, 10)
        ReaderWriter._database.TotalValue = (num + ReaderWriter._database.TotalValue)
        Me._mainForm.Invoke(Me._passMsg, Me.ID, ReaderWriter.State.Finished, ReaderWriter._database.TotalValue)
        ReaderWriter._database.LockDataObj()
        ReaderWriter._database.DecreaseWriterCount()
        ReaderWriter.WakeupNextWhenExiting()
        ReaderWriter._database.ReleaseDataObj()
    End Sub

End Class
