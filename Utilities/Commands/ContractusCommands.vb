''' <summary>Handles ServerCommands for Contractus</summary>
Public Module ContractusCommands

    ''' <summary>Returns all contracts</summary>
    Public Function ReadAllContracts() As String
        'CONREADALL
        Return RawCommand("CONREADALL")
    End Function

    ''' <summary>Returns a contract's details</summary>
    Public Function ConDetails(ContractID As Integer) As String
        'CONDETAILS#
        Return RawCommand("CONDETAILS" & ContractID)
    End Function

    ''' <summary>Returns a User's Contracts</summary>
    Public Function ReadUserContracts(UserID As String) As String
        'CONREADUSR57174
        Return RawCommand("CONREADUSR" + UserID)
    End Function

    ''' <summary>Add Contract to all contracts</summary>
    Public Function AddContractToAll(ContractName As String, UserID As String, Username As String, Description As String) As String
        'CONADDTOALL
        'Build The Building~57174~Igtampe;Build the Building and make it real good boio pls help
        Return RawCommand("CONADDTOALL" + ContractName + "~" + UserID + "~" + Username + ";" + Description)
    End Function

    ''' <summary>Adds a bid to a specified contract</summary>
    Public Function AddBid(ContractID As Integer, NewBid As Long, UserID As String, Username As String) As String
        'CONADDBID
        'ContractID;NewBid;UserID;UserName
        ' 0           1      2        3
        Return RawCommand("CONADDBID" & ContractID & ";" & NewBid & ";" & UserID & ";" & Username)
    End Function

    ''' <summary>Moves the contract</summary>
    Public Function MoveToUser(ContractID As Integer, UserID As String) As String
        'CONMOVETOUSER
        'ContractID;User
        ' 0           1
        Return RawCommand("CONMOVETOUSER" & ContractID & ";" + UserID)
    End Function

    ''' <summary>Removes a contract</summary>
    Public Function RemoveContract(ContractID As Integer, UserID As String) As String
        'CONREMOVE
        'ContractID;User
        ' 0           1
        Return RawCommand("CONREMOVE" & ContractID & ";" & UserID)
    End Function
End Module
