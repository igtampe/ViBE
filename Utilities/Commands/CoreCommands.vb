''' <summary>Handles the Core Functions of the ViBE Server</summary>
Public Module CoreCommands

    'AUTHViBE READY

    ''' <summary>Checks A User's Credentials</summary>
    Public Function CU(ID As String, PIN As String) As String
        Return RawCommand("CU" + ID + PIN)
    End Function

    ''' <summary>Sends Money Between Accounts</summary>
    Public Function SM(User As User, OriginBank As String, Destination As String, Amount As Long) As String
        Return AuthenticatedCommand(User, "SM" & String.Join(",", {OriginBank, Destination, Amount}))
    End Function

    ''' <summary>Transfers money between owned bank accounts</summary>
    Public Function TM(User As User, OriginBank As String, DestinationBank As String, Amount As Long) As String
        Return AuthenticatedCommand(User, "SM" & String.Join(",", {OriginBank, User.ID & "\" & DestinationBank, Amount}))
    End Function

    ''' <summary>Change Pin Request</summary>
    Public Function ChangePin(User As User, NEWPIN As String) As String
        Return AuthenticatedCommand(User, "CP" & NEWPIN)
    End Function

    ''' <summary>Returns Information on a Specific User</summary>
    Public Function UserInfo(UserID As String)
        Return RawCommand("INFO" + UserID)
    End Function

    ''' <summary>Returns a joined array with the directory</summary>
    Public Function GetDirectory() As String
        Return RawCommand("DIR")
    End Function

    ''' <summary>Registers a User</summary>
    Public Function RegisterUser(Pin As String, Username As String, Corporate As Boolean) As String
        If Corporate Then
            Return RawCommand("REG" + Pin + "," + Username + " (Corp.)")
        End If
        Return RawCommand("REG" + Pin + "," + Username)
    End Function

    ''' <summary>Certifies a Transaction</summary>
    Public Function Certify(Transaction As String) As String
        Return RawCommand("CERT" + Transaction)
    End Function

End Module
