Imports VIBE__But_on_Visual_Studio_.ServerCommand
Public Class LBLClientTransfer
    Private ID As Integer

    ''' <summary>
    ''' Creates and starts an LBL Transfer with the specified filename
    ''' </summary>
    ''' <param name="Filename"></param>
    Public Sub New(Filename As String)
        Dim IDHolder As String = RawCommand("LBL:OPEN:" & Filename)
        If IDHolder = "E" Then
            Throw New LBLOpenError
        ElseIf IDHolder = "invalid Packet Sent" Then
            Throw New LBLNotSupportedException()
        End If
        ID = IDHolder
    End Sub

    Public Function SendLine(Line As String)
        Dim response As String = RawCommand("LBL:TRANSFER:" & ID & ":" & Line)
        If Not response = "OK" Then
            Do
                Dim QuestionReply As MsgBoxResult = MsgBox("I couldn't send the current line. Would you like me to try again?" & vbNewLine & vbNewLine & "Response from the server: " & response, MsgBoxStyle.AbortRetryIgnore + MsgBoxStyle.Question, "LBL Transfer")
                Select Case QuestionReply
                    Case MsgBoxResult.Abort
                        Close()
                        Return "CLOSED"
                    Case MsgBoxResult.Ignore
                        Return "OK"
                    Case MsgBoxResult.Retry
                        response = RawCommand("LBL:TRANSFER:" & ID & ":" & Line)
                End Select
            Loop While Not response = "OK"
        End If
        Return "OK"
    End Function

    Public Function Close() As String
        Dim response As String = RawCommand("LBL:CLOSE:" & ID)
        If response = "E" Then
            Throw New LBLCloseError()
        End If
        ID = Nothing
        Return response
    End Function



    'Internal exceptions:
    Public Class LBLNotSupportedException
        Inherits Exception
        Public Sub New()
            MyBase.New("LBL is not supported by the server")
        End Sub
    End Class

    Public Class LBLOpenError
        Inherits Exception
        Public Sub New()
            MyBase.New("LBL Could not open a file transfer now.")
        End Sub
    End Class

    Public Class LBLCloseError
        Inherits Exception
        Public Sub New()
            MyBase.New("LBL Could not close this file transfer. Perhaps something else already closed it?")
        End Sub
    End Class

End Class
