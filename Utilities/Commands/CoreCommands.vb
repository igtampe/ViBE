''' <summary>Handles the Core Functions of the ViBE Server</summary>
Public Module CoreCommands

    ''' <summary>Checks A User's Credentials</summary>
    Public Function CU(ID As String, PIN As String) As String
        Return RawCommand("CU" + ID + PIN)
    End Function

    ''' <summary>Sends Money Between Accounts</summary>
    Public Function SM(Origin As String, Destination As String, Amount As Long) As String
        Return RawCommand("SM" & Origin & Destination & Amount)
    End Function

    ''' <summary>Transfers money between owned bank accounts</summary>
    Public Function TM(ID As String, OriginBank As String, DestinationBank As String, Amount As Long) As String
        Return RawCommand("TM" & ID & OriginBank & DestinationBank & Amount)
    End Function

    ''' <summary>Change Pin Request</summary>
    Public Function ChangePin(ID As String, NEWPIN As String) As String
        Return RawCommand("CP" + ID + NEWPIN)
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
