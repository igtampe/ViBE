Imports System.IO
Imports System.Net.Sockets

Public Class VibeRegister
    Public ServerMSG As String

    Private Sub CancelButtonReg_Click(sender As Object, e As EventArgs) Handles CancelButtonReg.Click, OKBTN.Click

        Close()

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If CheckForInput() = False Then
            MsgBox("Please specify appropriate inputs", MsgBoxStyle.Exclamation, "Registration Error")
            Exit Sub
        End If


        If CheckBox1.Checked = False Then
            MsgBox("Please accept the terms and conditions.", MsgBoxStyle.Exclamation, "Registration Errror")
            Exit Sub
        End If

        RefreshNotice.Show()
        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Function ServerCommand(ByVal ClientMSG As String) As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter

        ServerMSG = "E"

        If ClientMSG = "" Then
            ServerCommand = "E"
            Exit Function
        End If

        Try
            tc.Connect(“IGTNET-W.DDNS.NET”, 757)
            'tc.Connect(“127.0.0.1”, 757)
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
    Function CheckForInput() As Boolean

        CheckForInput = True

        If NameTXB.Text.Trim(" ") = "" Then
            CheckForInput = False
        End If

        If PINTXB.Text.Trim(" ") = "" Then
            CheckForInput = False
        End If

    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If CheckBox2.Checked Then
            ServerMSG = ServerCommand("REG" & PINTXB.Text & "," & NameTXB.Text & " (Corp.)")
        Else
            ServerMSG = ServerCommand("REG" & PINTXB.Text & "," & NameTXB.Text)
        End If
    End Sub

    Private Sub Donedoingthething() Handles BackgroundWorker1.RunWorkerCompleted
        If ServerMSG = "E" Then
            MsgBox("The server couldn't register you. Please try again later.")
            Exit Sub
        End If



        TC1.Visible = False
        TC2.Visible = False
        CheckBox1.Visible = False
        IDLabel.Visible = False
        PinLabel.Visible = False
        NameTXB.Visible = False
        PINTXB.Visible = False

        CongratsLBL1.Visible = True
        CongratsLBL2.Visible = True
        CongratsLBL3.Visible = True
        CongratsLBL4.Visible = True
        CongratsIDLBL.Visible = True
        CongratsIDLBL.Text = ServerMSG
        OKBTN.Visible = True
        CongratsLBL4.Text = "Welcome to the UMSWEB, " & NameTXB.Text & "!"

        Size = New Size(382, 354)
        RefreshNotice.Close()


    End Sub

    Private Sub Boing() Handles Me.Load

        TC1.Visible = True
        TC2.Visible = True
        CheckBox1.Visible = True
        IDLabel.Visible = True
        PinLabel.Visible = True
        NameTXB.Visible = True
        PINTXB.Visible = True

        CongratsLBL1.Visible = False
        CongratsLBL2.Visible = False
        CongratsLBL3.Visible = False
        CongratsLBL4.Visible = False
        CongratsIDLBL.Visible = False
        OKBTN.Visible = False

        Size = New Size(382, 454)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            MsgBox("WARNING: If this is later found out this isn't actually used for corporate dealings, you will be liable for FRAUD and you will be charged backtaxes for any income registered to this account. By ticking this box you acknowledge that you have been notified about this.", MsgBoxStyle.Exclamation, "Warning!")
        End If

    End Sub
End Class