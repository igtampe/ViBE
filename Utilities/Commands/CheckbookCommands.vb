''' <summary> Handles ServerCommands for Checkbook 2000</summary>
Public Module CheckbookCommands

    'READY FOR AUTHVIBE

    ''' <summary>Read All Checks from the specified user</summary>
    Public Function ReadChecks(User As User) As String
        'CHCKBKREAD
        Return AuthenticatedCommand(User, "CHCKBKREAD")
    End Function

    ''' <summary>Removes a Check</summary>
    Public Function RemoCheck(User As User, Index As Integer) As String
        'CHKBKREMO10
        Return AuthenticatedCommand(User, "CHCKBKREMO" & Index)
    End Function

    ''' <summary>Removes a Check</summary>
    Public Function ExecuteCheck(User As User, Index As Integer, bank As String) As String
        'CHKBKREMO10
        Return AuthenticatedCommand(User, "CHCKBKEXECUTE" & Index & "," & bank)
    End Function

    ''' <summary>Adds a Check</summary>
    Public Function AddCheck(USER As User, Destination As String, Type As Integer, Time As String, Name As String, Bank As String, Amount As Long, Subtype As Integer, Comment As String) As String
        Return AuthenticatedCommand(USER, "CHCKBKADD" & Destination & "~" & Type & "`" & Time & "`" & Name & "`" & Bank & "`" & Amount & "`::" & Subtype & "::" & Comment)
    End Function

End Module
