Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections

'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class ReaderWriter
'                 
'----------------------------------------------

Public MustInherit Class ReaderWriter

    Protected Shared FIFOQueue As New Queue
    Protected Shared _database As UWPCS3340.DatabaseClass
    Private Shared endProgram As New AutoResetEvent(False)
    Protected _thread As Threading.Thread
    Protected _passMsg As PassMessage
    Protected _mainForm As System.Windows.Forms.Form
    Protected _ReaderWriterEvent As New AutoResetEvent(False)
    Protected _rondomGenerator As New System.Random

    Public Delegate Sub PassMessage(ByVal theID As String,
                    ByVal theState As State,
                    ByVal theTotal As Integer)

    Public Shared WriteOnly Property TheDatabase() As UWPCS3340.DatabaseClass
        Set(value As UWPCS3340.DatabaseClass)
            ReaderWriter._database = value
        End Set
    End Property

    ' When a writer or a reader exits the database and no other readers/writers
    ' are in the database, the writer or reader wakes up the the first reader/writer
    ' in the waiting queue.
    ' If the queue is empty, sets endProgram to signalled (green), since it's
    ' possible that a thread is waiting for all readers/writers to finish the work.
    ' Mutual exclusion on the queue must be enforced.
    Protected Shared Sub WakeupNextWhenExiting()

    End Sub

    ' Waits for all readers and writers to finish the work in order to terminate
    ' the program.
    ' Mutual exclusion on the DataObj and the queue must be enforced.
    Public Shared Sub FinishReadWrite()
        ReaderWriter._database.LockDataObj()
        Monitor.Enter(ReaderWriter.FIFOQueue)
        If ((Not ReaderWriter._database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Or (ReaderWriter.FIFOQueue.Count > 0)) Then
            ReaderWriter.endProgram.Reset()
        Else
            ReaderWriter.endProgram.Set()
        End If
        Monitor.Exit(ReaderWriter.FIFOQueue)
        ReaderWriter._database.ReleaseDataObj()
        ReaderWriter.endProgram.WaitOne()
    End Sub

    Public WriteOnly Property DisplayMsg() As PassMessage
        Set(value As PassMessage)
            Me._passMsg = value
        End Set
    End Property

    Public WriteOnly Property MainForm() As System.Windows.Forms.Form
        Set(value As System.Windows.Forms.Form)
            Me._mainForm = value
        End Set
    End Property

    Public MustOverride ReadOnly Property ID() As String

    Public MustOverride ReadOnly Property type() As ReaderWriterType

    Public Sub SpinUp()
        Me._thread = New Thread(New ThreadStart(AddressOf run))
        Me._thread.Start()
    End Sub

    Public Sub WakeUp()
        Me._ReaderWriterEvent.Set()
    End Sub

    Protected Overridable Sub run()

    End Sub
    Public Sub New()
        Me._ReaderWriterEvent = New AutoResetEvent(False)
        _rondomGenerator = New Random
    End Sub

    Public Enum ReaderWriterType
        Reader
        Writer
    End Enum

    Public Enum State
        Waiting
        Working
        Finished
    End Enum

End Class
