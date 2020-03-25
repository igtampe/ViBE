Imports VIBE__But_on_Visual_Studio_.ServerCommand

''' <summary>
''' EzTax Expansion
''' </summary>
Public Class EzTax
    Public Shared Function Breakdown(ID As String) As String
        'EZTBRK57174
        Return RawCommand("EZTBRK" + ID)
    End Function

    ''' <summary>
    ''' Gets Income Info from the specified User
    ''' </summary>
    ''' <param name="ID"></param>
    ''' <returns></returns>
    Public Shared Function Info(ID As String) As String
        'EZTINF57174
        Return RawCommand("EZTINF" + ID)
    End Function

    ''' <summary>
    ''' Update Income of someone
    ''' </summary>
    ''' <param name="EZTAXMSG"></param>
    ''' <returns></returns>
    Public Shared Function UpdateIncome(ID As String, TotalIncome As Long, NewpondIncome As Long, Urbiaincome As Long, ParadisusIncome As Long, LaertesIncome As Long, NOIncome As Long, SOincome As Long) As String
        'EZTUPD57174,0,0,0,0,0,0
        Return RawCommand("EZTUPD" & VibeMainScreen.ID & "," & TotalIncome & "," & NewpondIncome & "," & Urbiaincome & "," & ParadisusIncome & "," & LaertesIncome & "," & NOIncome & "," & SOincome)
    End Function
End Class
