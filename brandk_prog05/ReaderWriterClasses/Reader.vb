﻿Imports UWPCS3340
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Threading
Imports System.Diagnostics


'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class Reader
'                 The Reader Thread
'----------------------------------------------

Public Class Reader : Inherits ReaderWriter

    Public Overrides ReadOnly Property ID As String
        Get
            Return "Reader_KB" + Convert.ToString(Me._thread.GetHashCode)
        End Get
    End Property

    Public Overrides ReadOnly Property type As ReaderWriter.ReaderWriterType
        Get
            Return ReaderWriterType.Reader
        End Get
    End Property
    ' Running of the thread
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
        ReaderWriter._database.LockDataObj()
        ReaderWriter._database.DecreaseReaderCount()
        If (ReaderWriter._database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then
            ReaderWriter.WakeupNextWhenExiting()
        End If
        ReaderWriter._database.ReleaseDataObj()
    End Sub
    ' Wakes up the next reader
    Protected Sub WakeupNextReader()
        Monitor.Enter(ReaderWriter.FIFOQueue)
        If ((ReaderWriter.FIFOQueue.Count > 0 And RuntimeHelpers.GetObjectValue(ReaderWriter.FIFOQueue.Peek()).type = ReaderWriter.ReaderWriterType.Reader)) Then
            RuntimeHelpers.GetObjectValue(ReaderWriter.FIFOQueue.Dequeue())
        End If
        Monitor.Exit(ReaderWriter.FIFOQueue)
    End Sub

End Class
