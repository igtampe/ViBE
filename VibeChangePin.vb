Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class VibeChangePin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ID As String
        Dim PIN As Integer
        PIN = NewPinTextBox.Text
        ID = VibeLogin.LogonID.Text
        Dim servermsg As String

        'Write the PIN

        servermsg = ServerCommand("CP" & ID & PIN)

        Select Case servermsg
            Case "1"

                MsgBox("Improperly Coded Change Pin Request", vbInformation, "Change Pin Notice")

            Case "2"

                MsgBox("Could not complete pin change", vbInformation, "Change Pin Notice")

            Case "S"

                MsgBox("Pin Changed Successfully", vbInformation, "Change Pin Notice")

                Close()
        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub

    Function ServerCommand(ByVal ClientMSG As String) As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String

        ServerMSG = "E"

        If ClientMSG = "" Then
            ServerCommand = "E"
            Exit Function
        End If

        Try
            tc.Connect(“igtnet-w.ddns.net”, 757)
            Exit Try

        Catch

            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "ViBE Error")
            VibeLogin.Show()
            Close()
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
                VibeLogin.Show()
                Close()
                ServerCommand = "CRASH"
                Exit Function

            End Try


            tc.Close()

        End If



        ServerCommand = ServerMSG

    End Function

End Class