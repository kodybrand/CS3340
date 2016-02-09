Public Class Chicago
    Inherits House

    Private Const HOUSE_TYPE As String = "Chicago"
    Private Const MAX_ROOMS As Integer = 4
    Private Const MIN_ROOMS As Integer = 3
    Private Const MAX_GARAGE As Integer = 3
    Private Const MIN_GARAGE As Integer = 2
    Private Const BASE_PRICE As Integer = 400000
    Private Const EXTRA_ROOM As Integer = 10000
    Private Const EXTRA_GARAGE As Integer = 5000
    Private rooms As Integer = MIN_ROOMS
    Private garages As Integer = MIN_GARAGE
    Private price As Integer = BASE_PRICE

    Public Sub New(ByVal aID As String)
        MyBase.New(aID)
    End Sub

    ' Need to override set price here
    Public Sub setPrice()

    End Sub


End Class
