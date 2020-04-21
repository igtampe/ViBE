Public Class User
    Public Enum UserCategory As Integer
        Normal = 0
        Corporate = 1
        Government = 2
    End Enum

    'ID info
    Public ReadOnly ID As String
    Public ReadOnly Username As String
    Public ReadOnly Category As UserCategory

    'User has banks
    Public ReadOnly UMSNB As Boolean
    Public ReadOnly GBANK As Boolean
    Public ReadOnly RIVER As Boolean

    'User Balances
    Public ReadOnly UMSNBBalance As Long
    Public ReadOnly GBANKBalance As Long
    Public ReadOnly RIVERBalance As Long
    Public ReadOnly TotalBalance As Long

    'Other
    Public ReadOnly Notifications As Integer

    ''' <summary>Parser used for ViBE's Main Screen</summary>
    '''<param name="SplitValues">The result of an INFO request from the server</param>
    Public Sub New(ID As String, SplitValues As String())

        Me.ID = ID

        UMSNB = SplitValues(0)
        GBANK = SplitValues(2)
        RIVER = SplitValues(4)
        UMSNBBalance = SplitValues(1)
        GBANKBalance = SplitValues(3)
        RIVERBalance = SplitValues(5)
        TotalBalance = UMSNBBalance + GBANKBalance + RIVERBalance
        Username = SplitValues(6)
        Notifications = SplitValues(7)

        'Find this user's category
        If Username.EndsWith(" (Corp.)") Then
            Category = UserCategory.Corporate
            Username = Username.Replace(" (Corp.)", "")
        ElseIf Username.EndsWith(" (Gov.)") Then
            Category = UserCategory.Government
            Username = Username.Replace(" (Gov.)", "")
        Else
            Category = UserCategory.Normal
        End If

    End Sub

    ''' <summary>Creates a new user with the specified information</summary>
    Public Sub New(ID As String, Username As String, Category As UserCategory, UMSNB As Boolean, GBANK As Boolean, RIVER As Boolean, UMSNBBalance As Long, GBANKBalance As Long, RIVERBalance As Long, Notifs As Integer)
        Me.ID = ID
        Me.Username = Username
        Me.Category = Category

        Me.UMSNB = UMSNB
        Me.GBANK = GBANK
        Me.RIVER = RIVER
        Me.UMSNBBalance = UMSNBBalance
        Me.GBANKBalance = GBANKBalance
        Me.RIVERBalance = RIVERBalance

        TotalBalance = UMSNBBalance + GBANKBalance + RIVERBalance
        Notifications = Notifs

    End Sub

    ''' <summary>Builds the user with information from the server. WILL PING THE SERVER!</summary>
    Public Sub New(ID As String)
        Me.New(ID, CoreCommands.UserInfo(ID).split(","))
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim OtherUser As User = TryCast(obj, User)
        If IsNothing(OtherUser) Then Return False
        Return OtherUser.ID = Me.ID
    End Function

    Public Overrides Function ToString() As String
        Return Username & " (" & ID & ")"
    End Function

End Class
