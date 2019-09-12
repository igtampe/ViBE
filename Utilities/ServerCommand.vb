Imports System.IO
Imports System.Net.Sockets

Public Class ServerCommand

    Const IP As String = “Igtnet-w.ddns.net”

    Public Structure ServerReply
        Public Reply As String
        Public Success As Boolean
        Public Sub New(ServerSuccess As Boolean, Optional ServerReply As String = "")
            Reply = ServerReply
            Success = ServerSuccess
        End Sub
    End Structure

    Public Shared Function ServerCommand(ByVal ClientMSG As String, Optional IPOverride As String = "") As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String


        ServerMSG = "E"

        'Check if the ClientMSG is blank, and if it is return an error flag
        If ClientMSG = "" Then
            ServerCommand = "E"
            Exit Function
        End If

        Try
            If Not IPOverride = "" Then
                tc.Connect(IPOverride, 757)
            Else
                tc.Connect(IP, 757)
            End If
        Catch
            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "ViBE Error")
            ServerCommand = "NOCONNECT"
            Exit Function
        End Try

        If tc.Connected = True Then
            ns = tc.GetStream
            br = New BinaryReader(ns)
            bw = New BinaryWriter(ns)

            bw.Write(ClientMSG)

            Try
                ServerMSG = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "ViBE Error")
                ServerCommand = "CRASH"
                Exit Function
            End Try
            tc.Close()
            Return ServerMSG
        End If
        ServerCommand = ServerMSG
    End Function

    Public Shared Function ExtendedServerCommand(ByVal ClientMSG As String, Optional IPOverride As String = "") As ServerReply

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String


        ServerMSG = "E"

        'Check if the ClientMSG is blank, and if it is return an error flag
        If ClientMSG = "" Then
            ExtendedServerCommand = New ServerReply(False)
            Exit Function
        End If

        Try
            If Not IPOverride = "" Then
                tc.Connect(IPOverride, 757)
            Else
                tc.Connect(IP, 757)
            End If
        Catch
            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "ViBE Error")
            ExtendedServerCommand = New ServerReply(False)
            Exit Function

        End Try

        If tc.Connected = True Then
            ns = tc.GetStream
            br = New BinaryReader(ns)
            bw = New BinaryWriter(ns)

            bw.Write(ClientMSG)

            Try
                ServerMSG = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "ViBE Error")
                ExtendedServerCommand = New ServerReply(False)
                Exit Function
            End Try
            tc.Close()
            Return New ServerReply(True, ServerMSG)
        Else
            Return New ServerReply(False)
        End If
    End Function

End Class
