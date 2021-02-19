''' <summary> The Bank ServerCommand Set </summary>
Public Module BankCommands

    'READY FOR AUTHVIBE
    'BNKA57174GBANK

    ''' <summary>Closes the specified bank of the specified ID</summary>
    ''' <returns>S for Success, E For Error</returns>
    Public Function CloseBank(User As User, Bank As String)
        Return AuthenticatedCommand(User, String.Join(",", {"BNK", "C", Bank}))
    End Function

    ''' <summary>Opens an account on the specified bank for the specified ID</summary>
    ''' <returns>S for Success, E For Error</returns>
    Public Function OpenBank(User As User, Bank As String)
        Return AuthenticatedCommand(User, String.Join(",", {"BNK", "O", Bank}))
    End Function

    ''' <summary>Retrieves the Log of the specified ID in user on the specified bank</summary>
    ''' <returns>S for success, or E for Error. Log is ready for download if S is received</returns>
    Public Function BankLog(User As User, Bank As String)
        Return AuthenticatedCommand(User, String.Join(",", {"BNK", "L", Bank}))
    End Function

End Module
