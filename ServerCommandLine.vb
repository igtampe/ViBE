Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class ServerCommandLine

    Public log As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String
        Dim clientmsg As String

        clientmsg = TextBox2.Text

        If clientmsg = "" Then Exit Sub

        Try
            tc.Connect(“127.0.0.1”, 757)
            Exit Try

        Catch

            MsgBox("Unable to Connect to the server", MsgBoxStyle.Exclamation, "ClientTEst")

        End Try



        If tc.Connected = True Then
            ns = tc.GetStream
            br = New BinaryReader(ns)
            bw = New BinaryWriter(ns)

            log = log & "[CLIENT] " & clientmsg & Environment.NewLine
            TextBox1.Text = log

            bw.Write(clientmsg)

            Try
                ServerMSG = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "ViBE Error")
                Exit Sub

            End Try

            log = log & "[SERVER] " & ServerMSG & Environment.NewLine
            TextBox1.Text = log


            tc.Close()

        End If


    End Sub


End Class