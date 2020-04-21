Public Class Contract

    Public ID As Integer
    Public Name As String
    Public FromName As String
    Public FromID As String
    Public TopBid As Long
    Public TopBidID As String
    Public TopBidName As String

    Public Sub New(ID As Integer, Name As String, FromID As String, FromName As String, TopBid As Long, TopBidID As String, TopBidName As String)
        Me.ID = ID
        Me.Name = Name
        Me.FromName = FromName
        Me.FromID = FromID
        Me.TopBid = TopBid
        Me.TopBidID = TopBidID
        Me.TopBidName = TopBidName
    End Sub

End Class
