''' <summary>ServerCommands for EzTax</summary>
Public Module EzTaxCommands

    'READY FOR AUTHVIBE

    ''' <summary>Get breakdown of the specified user</summary>
    Public Function Breakdown(User As User) As String
        'EZTBRK57174
        Return AuthenticatedCommand(User, "EZTBRK")
    End Function

    ''' <summary>Gets Income Info from the specified User</summary>
    Public Function TaxInfo(User As User) As String
        'EZTINF57174
        Return AuthenticatedCommand(User, "EZTINF")
    End Function

    ''' <summary>Update Income of someone </summary>
    Public Function UpdateIncome(User As User, TotalIncome As Long, NewpondIncome As Long, Urbiaincome As Long, ParadisusIncome As Long, LaertesIncome As Long, NOIncome As Long, SOincome As Long) As String
        'EZTUPD57174,0,0,0,0,0,0
        Return AuthenticatedCommand(User, "EZTUPD" & TotalIncome & "," & NewpondIncome & "," & Urbiaincome & "," & ParadisusIncome & "," & LaertesIncome & "," & NOIncome & "," & SOincome)
    End Function

    ''' <summary>Checks if the local tax file that holds tax definitions is out of date.</summary>
    Public Function TaxFileOutOfDate(LocalTaxID As Integer) As Boolean
        Dim ServerTaxID As Integer = RawCommand("IMEX,TAXVER")
        Return ServerTaxID > LocalTaxID
    End Function

End Module
