Public Class Platteville
    Inherits House

    Private Const HOUSE_TYPE As String = "Platteville"
    Private Const MAX_ROOMS As Integer = 3
    Private Const MIN_ROOMS As Integer = 2
    Private Const MAX_GARAGE As Integer = 2
    Private Const MIN_GARAGE As Integer = 1
    Private Const BASE_PRICE As Integer = 200000
    Private Const EXTRA_ROOM As Integer = 8000
    Private Const EXTRA_GARAGE As Integer = 2500


    Public Sub New(ByVal aID As String)
        MyBase.New(aID, HOUSE_TYPE, EXTRA_ROOM, MIN_ROOMS, MAX_ROOMS, _
                   EXTRA_GARAGE, MIN_GARAGE, MAX_GARAGE, BASE_PRICE)
    End Sub

End Class
