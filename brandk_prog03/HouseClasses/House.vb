Imports UWPCS3340
'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program3
'              Class House
'       Abstract class for house
'----------------------------------------------
Imports System.Text.RegularExpressions

Public MustInherit Class House : Implements IDisposable

    Protected Shared AllHouses As List(Of House) = New List(Of House)

    Protected _TYPE As String
    Protected _ID As String
    Protected _MAX_ROOMS As Integer
    Protected _MIN_ROOMS As Integer
    Protected _MAX_GARAGES As Integer
    Protected _MIN_GARAGES As Integer
    Protected _BASE_PRICE As Integer
    Protected _EXTRA_ROOM As Integer
    Protected _EXTRA_GARAGE As Integer
    Protected _rooms As Integer
    Protected _garages As Integer
    Protected _price As Integer
    Private _aID As String
    Private disposedValue As Boolean

    ' Constructor
    Public Sub New(ByVal aID As String)
        Dim idL As Integer = aID.Length - 1
        Dim index As Integer = 0
        For Each House In AllHouses
            If House._ID = aID Then
                Throw New Exception("ID must be unique!")
            End If
        Next
        If Not aID.Length = 5 Then
            Throw New Exception("ID must have exactly five characters!")
        End If
        For index = 0 To 4
            Dim idChar = aID(index)
            If Not Char.IsLetterOrDigit(idChar) Then
                Throw New Exception("Each character of ID must be a digit or letter!")
            End If
        Next
        Me._ID = aID
        AllHouses.Add(Me)
    End Sub

    ' Sets the modifications of numbers have been updated.
    Public Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)
        Dim flag As Boolean = False
        Dim message As String = ""

        If numRooms < Me._MIN_ROOMS Or numRooms > Me._MAX_ROOMS Then
            message = "Invalid room selection"
            Err()
            flag = True
        End If
        If numGarages < Me._MIN_GARAGES Or numGarages > Me._MAX_GARAGES Then
            message = "Invalid garage selection"
            flag = True
        End If
        If flag = True Then
            Throw New Exception(message)
        End If
        Me._garages = numGarages
        Me._rooms = numRooms
        setPrice()
    End Sub

    Protected Overridable Sub setPrice()
        Dim tmp As Integer = Me._price
        Me._price = Me._BASE_PRICE + ((Me._rooms - Me._MIN_ROOMS) * Me._EXTRA_ROOM) _
            + ((Me._garages - Me._MIN_GARAGES) * Me._EXTRA_GARAGE)
        If tmp <> Me._price Then
            RaisePriceChangedEvent()
        End If
        RaiseEvent HouseListUpdatedEvent()
    End Sub

    ' Returns the house at the specified index.
    Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
        Get
            Return House.AllHouses(index)
        End Get
    End Property

    ' Returns house type
    Public ReadOnly Property Type As String
        Get
            Return Me._TYPE
        End Get
    End Property

    ' Returns house ID
    Public ReadOnly Property ID As String
        Get
            Return Me._ID
        End Get
    End Property

    ' Returns house Rooms
    Public ReadOnly Property Rooms As Integer
        Get
            Return Me._rooms
        End Get
    End Property

    ' Returns house Garages
    Public ReadOnly Property Garages As Integer
        Get
            Return Me._garages
        End Get
    End Property

    ' Returns house Price
    Public ReadOnly Property Price As Single
        Get
            Return Me._price
        End Get
    End Property

    ' Returns the total count of house objects to be built.
    Public Shared ReadOnly Property TotalCount As Integer
        Get
            Return AllHouses.Count
        End Get
    End Property

    ' Raised when the price of the house changes.
    Public Event PriceChanged()

    'allows subs to raise PriceChanged event
    Protected Sub RaisePriceChangedEvent()
        RaiseEvent PriceChanged()
    End Sub

    ' Raised when the price of the house chages.
    Public Shared Event HouseListUpdatedEvent()
    Protected Sub RaiseHouseListUpdateEvent()
        RaiseEvent HouseListUpdatedEvent()
    End Sub

    Private Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                AllHouses.Remove(Me)

                ' Raise event ListUpdated
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub


End Class
