Public MustInherit Class House

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
        _ID = aID
        AllHouses.Add(Me)
    End Sub

    Public Shared ReadOnly Property TotalCount()
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

    Private Sub setPrice()

    End Sub




    Public Event PriceChanged()



End Class
