'----------------------------------------------
' Name: Kody Brand
' Date: 2/05/2016
' Description: Program2
'              Class House
'       Abstract class for house
'----------------------------------------------
Imports System.Text.RegularExpressions

Public MustInherit Class House

    Private zero As Integer = 0

    Protected _type As String
    Protected _ID As String
    Protected _rooms As Integer
    Protected _garages As Integer
    Protected _price As Single
    Protected _maxRooms As Integer
    Protected _minRooms As Integer
    Protected _maxGarage As Integer
    Protected _minGarage As Integer
    Private _basePrice As Double
    Private _extraRoomPrice As Integer
    Private _extraGaragePrice As Integer

    'string formatting constants
    Private Const COL_1 As String = "{0,-5}", COL_2 = "{0,15}", COL_3 = "{0,12}"
    Private Const CURRENCY As String = "{0:c0}"

    Protected Shared AllHouses As List(Of House) = New List(Of House)

    ' Constructor
    Public Sub New(ByVal aID As String, ByVal type As String, ByVal roomPrice As Single, _
                   ByVal minRooms As Integer, ByVal maxRooms As Integer, ByVal garagePrice As Single, _
                   ByVal minGarages As Integer, ByVal maxGarages As Integer, basePrice As Single)
        If Not aID.Length = 5 Then
            Throw New Exception("ID must have exactly five characters!")
        Else
            If Not (Regex.IsMatch(aID, "[A-Za-z0-9]")) Then
                Throw New Exception("Each character of ID must be a digit or letter!")
            Else
                Dim tmphouse As House
                For index As Integer = 0 To AllHouses.Count - 1
                    If Not AllHouses.Count = 0 Then
                        If (aID = AllHouses(index)._ID) Then
                            tmphouse = HouseByIndex(index)
                            Throw New Exception("ID must be unique!")
                        End If
                    End If
                Next
                _ID = aID
                _type = type
                _basePrice = roomPrice
                _minRooms = minRooms
                _maxRooms = maxRooms
                _rooms = minRooms
                _extraGaragePrice = garagePrice
                _minGarage = minGarages
                _maxGarage = maxGarages
                _garages = minGarages
                _basePrice = basePrice
                _price = basePrice
                AllHouses.Add(Me)
            End If
        End If
    End Sub

    'Modifys the object when changed
    Public Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)
        Dim flag As Boolean = False
        Dim message As String = ""

        If (numRooms < _minRooms Or numRooms > _maxRooms) Then
            message = "Number of rooms is out of range!\r\n"
            flag = True
        End If

        If (numGarages < _minGarage Or numGarages > _maxGarage) Then
            message += "Number of garages is out of range!"
            flag = True
        End If
        If (flag) Then
            Throw New Exception(message)
        End If
        _rooms = numRooms
        _garages = numGarages
        setPrice()

    End Sub

    'Sets the price
    Overridable Sub setPrice()
        Dim newPrice As Integer

        newPrice = _basePrice + (_extraRoomPrice * (_rooms - _minRooms)) + (_extraGaragePrice * (_garages - _minGarage))
        If _price <> newPrice Then
            _price = newPrice
            RaisePriceChangedEvent()
        End If
    End Sub

    ' Returns the house at the specified index.
    Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
        Get
            Return AllHouses(index)
        End Get
    End Property


    ' -- ToString
    'returns formatted string representation of house
    Overrides Function toString() As String
        Return String.Format(COL_1, _ID) & String.Format(COL_2, _type) & _
            String.Format(COL_3, String.Format(CURRENCY, _price))
    End Function

    ' --- Gets

    Public Shared ReadOnly Property TotalCount() As Integer
        Get
            Return AllHouses.Count
        End Get
    End Property

    Public ReadOnly Property Type As String
        Get
            Return _type
        End Get
    End Property

    Public ReadOnly Property ID As String
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property Rooms As Integer
        Get
            Return _rooms
        End Get
    End Property

    Public ReadOnly Property Garages As Integer
        Get
            Return _garages
        End Get
    End Property

    Public ReadOnly Property Price As Single
        Get
            Return _price
        End Get
    End Property

    ' --- Events
    ' Raised when the price of the house chages
    Public Event PriceChanged()

    'allows subs to raise PriceChanged event
    Protected Sub RaisePriceChangedEvent()
        RaiseEvent PriceChanged()
    End Sub
End Class
