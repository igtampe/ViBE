''' <summary>ServerCommands for EzTax</summary>
Public Module EzTaxCommands

    ''' <summary>Get breakdown of the specified user</summary>
    Public Function Breakdown(ID As String) As String
        'EZTBRK57174
        Return RawCommand("EZTBRK" + ID)
    End Function

    ''' <summary>Gets Income Info from the specified User</summary>
    Public Function TaxInfo(ID As String) As String
        'EZTINF57174
        Return RawCommand("EZTINF" + ID)
    End Function

    ''' <summary>Update Income of someone </summary>
    Public Function UpdateIncome(ID As String, TotalIncome As Long, NewpondIncome As Long, Urbiaincome As Long, ParadisusIncome As Long, LaertesIncome As Long, NOIncome As Long, SOincome As Long) As String
        'EZTUPD57174,0,0,0,0,0,0
        Return RawCommand("EZTUPD" & ID & "," & TotalIncome & "," & NewpondIncome & "," & Urbiaincome & "," & ParadisusIncome & "," & LaertesIncome & "," & NOIncome & "," & SOincome)
    End Function

    ''' <summary>Checks if the local tax file that holds tax definitions is out of date.</summary>
    Public Function TaxFileOutOfDate(LocalTaxID As Integer) As Boolean
        Dim ServerTaxID As Integer = RawCommand("IMEX,TAXVER")
        Return ServerTaxID > LocalTaxID
    End Function

End Module
