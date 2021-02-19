''' <summary>Handles ServerCommands for Contractus</summary>
Public Module ContractusCommands

    'READY FOR AUTHVIBE

    ''' <summary>Returns all contracts</summary>
    Public Function ReadAllContracts(User As User) As String
        'CONREADALL
        Return AuthenticatedCommand(User, "CONREADALL")
    End Function

    ''' <summary>Returns a contract's details</summary>
    Public Function ConDetails(User As User, ContractID As Integer) As String
        'CONDETAILS#
        Return AuthenticatedCommand(User, "CONDETAILS" & ContractID)
    End Function

    ''' <summary>Returns a User's Contracts</summary>
    Public Function ReadUserContracts(User As User) As String
        'CONREADUSR
        Return AuthenticatedCommand(User, "CONREADUSR")
    End Function

    ''' <summary>Add Contract to all contracts</summary>
    Public Function AddContractToAll(User As User, ContractName As String, Description As String) As String
        'CONADDTOALL
        'Build The Building;Build the Building and make it real good boio pls help
        Return AuthenticatedCommand(User, "CONADDTOALL" + ContractName + ";" + Description)
    End Function

    ''' <summary>Adds a bid to a specified contract</summary>
    Public Function AddBid(User As User, ContractID As Integer, NewBid As Long) As String
        'CONADDBID
        'ContractID;NewBid
        ' 0           1      2        3
        Return AuthenticatedCommand(User, "CONADDBID" & ContractID & ";" & NewBid)
    End Function

    ''' <summary>Moves the contract</summary>
    Public Function MoveToUser(User As User, ContractID As Integer, UserID As String) As String
        'CONMOVETOUSER
        'ContractID;User
        ' 0           1
        Return AuthenticatedCommand(User, "CONMOVETOUSER" & ContractID & ";" + UserID)
    End Function

    ''' <summary>Removes a contract</summary>
    Public Function RemoveContract(User As User, ContractID As Integer) As String
        'CONREMOVE
        'ContractID;User
        ' 0           1
        Return AuthenticatedCommand(User, "CONREMOVE" & ContractID)
    End Function
End Module
