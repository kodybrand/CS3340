Imports UWPCS3340
Imports System.Threading
Imports System.Runtime.CompilerServices

Public Class DatabaseClass
    Private _total As Integer
    Private ReaderCount As Integer
    Private WriterCount As Integer
    Private DataObject As Object

    ' Returns Reading when some readers are reading the database value,
    ' Writing when a writer is writing the database value,
    ' Empty otherwise.
    Public ReadOnly Property TheDatabaseStatus As DatabaseStatus
        Get
            If (ReaderCount > 0) Then
                Return DatabaseStatus.Reading
            End If
            If (WriterCount > 0) Then
                Return DatabaseStatus.Writing
            Else
                Return DatabaseStatus.Empty
            End If
        End Get
    End Property

    Public Sub New(ByVal total As Integer)
        Me.DataObject = RuntimeHelpers.GetObjectValue(New Object)
        Me._total = total
    End Sub

    ' Enter Monitor before exclusive access to ReaderCount and WriterCount.
    Public Sub LockDataObj()
        Monitor.Enter(RuntimeHelpers.GetObjectValue(Me.DataObject))
    End Sub

    ' Exit Monitor after exclusive access to ReaderCount and WriterCount.
    Public Sub ReleaseDataObj()
        Monitor.Exit(RuntimeHelpers.GetObjectValue(Me.DataObject))
    End Sub

    ' Gets and sets the data value
    Public Property TotalValue As Integer
        Get
            Return Me._total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property

    ' Increments the ReaderCount by one
    Public Sub IncreaseReaderCount()
        Me.ReaderCount = Me.ReaderCount + 1

    End Sub

    ' Decrements the ReaderCount by one.
    Public Sub DecreaseReaderCount()
        Me.ReaderCount = Me.ReaderCount - 1
    End Sub

    ' Increments the WriterCount by one.
    Public Sub IncreaseWriterCount()
        Me.WriterCount = Me.WriterCount + 1
    End Sub

    ' Decrements the WriterCount by one.
    Public Sub DecreaseWriterCount()
        Me.WriterCount = Me.WriterCount - 1

    End Sub

    Public Enum DatabaseStatus
        Reading
        Writing
        Empty
    End Enum

End Class
