''' <summary> Notifications Expansion</summary>
Public Module NotifCommands

    'READY FOR AUTHVIBE

    ''' <summary>Read All Notifications</summary>
    Public Function ReadNotifs(User As User) As String
        'NOTIFREAD57174
        Return AuthenticatedCommand(User, "NOTIFREAD")
    End Function

    ''' <summary>Clear All Notifications of the given ID</summary>
    Public Function ClearNotifs(User As User) As String
        'NOTIFCLEAR57174
        Return AuthenticatedCommand(User, "NOTIFCLEAR")
    End Function

    ''' <summary>Remove a specified notification</summary>
    Public Function RemoveNotif(User As User, Index As Integer) As String
        'NOTIFREMO5717410
        Return AuthenticatedCommand(User, "NOTIFREMO" & Index)
    End Function


End Module
