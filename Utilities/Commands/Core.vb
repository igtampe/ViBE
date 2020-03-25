Imports VIBE__But_on_Visual_Studio_.ServerCommand

''' <summary>
''' Handles the Core Functions of the ViBE Server
''' </summary>
Public Class Core

    ''' <summary>
    ''' Checks A User's Credentials
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CU(ID As String, PIN As String) As String
        Return RawCommand("CU" + ID + PIN)
    End Function

    ''' <summary>
    ''' Sends Money Between Accounts
    ''' </summary>
    ''' <param name="SMCommand">Formatted as [ACCOUNT1][ACCOUNT2][AMOUNT]</param>
    ''' <returns></returns>
    Public Shared Function SM(Origin As String, Destination As String, Amount As Long) As String
        Return RawCommand("SM" & Origin & Destination & Amount)
    End Function

    ''' <summary>
    ''' Transfers money between owned bank accounts
    ''' </summary>
    ''' <param name="TMCommand">Formatted as [ID][OriginBank][DestinationBank][Amount]</param>
    ''' <returns></returns>
    Public Shared Function TM(ID As String, OriginBank As String, DestinationBank As String, Amount As Long) As String
        Return RawCommand("TM" & ID & OriginBank & DestinationBank & Amount)
    End Function

    ''' <summary>
    ''' Change Pin Request
    ''' </summary>
    ''' <param name="ChangePinCommand">[ID][NEWPIN]</param>
    ''' <returns></returns>
    Public Shared Function ChangePin(ID As String, NEWPIN As String) As String
        Return RawCommand("CP" + ID + NEWPIN)
    End Function

    ''' <summary>
    ''' Returns Information on a Specific User
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <returns></returns>
    Public Shared Function INFO(UserID As String)
        Return RawCommand("INFO" + UserID)
    End Function

    ''' <summary>
    ''' Returns a joined array with the directory
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function GetDirectory() As String
        Return RawCommand("DIR")
    End Function

    ''' <summary>
    ''' Registers a User
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function RegisterUser(Pin As String, Username As String, Corporate As Boolean) As String
        If Corporate Then
            Return RawCommand("REG" + Pin + "," + Username + " (Corp.)")
        End If
        Return RawCommand("REG" + Pin + "," + Username)
    End Function

    ''' <summary>
    ''' Certifies a Transaction
    ''' </summary>
    ''' <param name="Transaction"></param>
    ''' <returns></returns>
    Public Shared Function Certify(Transaction As String) As String
        Return RawCommand("CERT" + Transaction)
    End Function

End Class
