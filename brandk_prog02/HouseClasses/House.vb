Imports System.Text.RegularExpressions

Public MustInherit Class House

    Private zero As Integer = 0


    Protected _type As String
    Protected _ID As String
    Protected _rooms As Integer
    Protected _garages As Integer
    Protected _price As Double
    Protected _maxRooms As Integer
    Protected _minRooms As Integer
    Protected _maxGarage As Integer
    Protected _minGarage As Integer
    Protected _basePrice As Double
    Protected _extraRoomPrice As Integer
    Protected _extraGaragePrice As Integer

    Protected Shared AllHouses As List(Of House) = New List(Of House)

    ' Constructor
    Public Sub New(ByVal aID As String)
        If Not aID.Length = 5 Then
            Throw New Exception("ID must have exactly five characters!")
        Else
            If Not (Regex.IsMatch(aID, "[A-Za-z0-9]")) Then
                Throw New Exception("Each character of ID must be a digit or letter!")
            Else
                For index As Integer = 0 To AllHouses.Count - 1
                    If Not AllHouses.Count = 0 Then
                        If (aID = AllHouses(index)._ID) Then

                            Throw New Exception("ID must be unique!")
                        End If
                    End If
                Next
                _ID = aID
                AllHouses.Add(Me)

            End If
        End If
    End Sub

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
        numRooms = _rooms
        numGarages = _garages

    End Sub

    ' Returns the house at the specified index.
    Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
        Get
            Return AllHouses(index)
        End Get
    End Property

    Private Sub setPrice()
        Dim num As Double = _price
        _price = (_basePrice + (_rooms - _minRooms * _extraRoomPrice) + (_garages - _minGarage * _extraGaragePrice))
        If Not num.Equals(_price) Then
            'Send Price Changed Message!
        End If

    End Sub




    Public Event PriceChanged()



End Class
