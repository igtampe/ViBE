Imports System.IO
Imports System.Net.Sockets

''' <summary>
''' ServerCommand is a utility that sends a command to the ViBE Server or an Equivalent to the ViBE Server
''' </summary>
Public Class ServerCommand

    Const IP As String = “Igtnet-w.ddns.net”
    Public SessionID As String = ""

    Public Shared Function RawCommand(ByVal ClientMSG As String, Optional IPOverride As String = "") As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String


        ServerMSG = "E"

        'Check if the ClientMSG is blank, and if it is return an error flag
        If String.IsNullOrEmpty(ClientMSG.Trim) Then
            Throw New Exception("It is vacio. Why did u send something vacio")
        End If

        Try
            If Not String.IsNullOrEmpty(IPOverride.Trim) Then
                tc.Connect(IPOverride, 757)
            Else
                tc.Connect(IP, 757)
            End If
        Catch
            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "ViBE Error")
            Return "NOCONNECT"
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
                Return "CRASH"
            End Try

            tc.Close()
            Return ServerMSG
        End If
        Return ServerMSG
    End Function
End Class
