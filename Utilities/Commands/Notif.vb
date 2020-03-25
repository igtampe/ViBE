Imports VIBE__But_on_Visual_Studio_.ServerCommand

''' <summary>
''' Notifications Expansion
''' </summary>
Public Class Notif

    ''' <summary>
    ''' Read All Notifications
    ''' </summary>
    ''' <param name="NotifMSG"></param>
    ''' <returns></returns>
    Public Shared Function ReadNotifs(ID As String) As String
        'NOTIFREAD57174
        Return RawCommand("NOTIFREAD" & ID)
    End Function

    ''' <summary>
    ''' Clear All Notifications
    ''' </summary>
    ''' <param name="Notifuser"></param>
    ''' <returns></returns>
    Public Shared Function ClearNotifs(ID As String) As String
        'NOTIFCLEAR57174
        Return RawCommand("NOTIFCLEAR" + ID)
    End Function

    ''' <summary>
    ''' Remove a specified notification
    ''' </summary>
    ''' <param name="NotifMSG"></param>
    ''' <returns></returns>
    Public Shared Function RemoveNotif(ID As String, Index As Integer) As String
        'NOTIFREMO5717410
        Return RawCommand("NOTIFREMO" & ID & Index)
    End Function


End Class
