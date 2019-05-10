Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Sockets


Public Class VibeLogin
    Public CV As String
    Public Shared servermsg
    Public Shared Username As String
    Public Shared UMSNB As Boolean
    Public Shared GBANK As Boolean
    Public Shared RIVER As Boolean
    Public Shared UMSNBBalance As Long
    Public Shared GBANKBalance As Long
    Public Shared RIVERBalance As Long
    Public AutoLogin As Boolean

    '================================================================================================'
    '██████╗ ███████╗███╗   ███╗███████╗███╗   ███╗██████╗ ███████╗██████╗     ████████╗ ██████╗     '
    '██╔══██╗██╔════╝████╗ ████║██╔════╝████╗ ████║██╔══██╗██╔════╝██╔══██╗    ╚══██╔══╝██╔═══██╗    '
    '██████╔╝█████╗  ██╔████╔██║█████╗  ██╔████╔██║██████╔╝█████╗  ██████╔╝       ██║   ██║   ██║    '
    '██╔══██╗██╔══╝  ██║╚██╔╝██║██╔══╝  ██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗       ██║   ██║   ██║    '
    '██║  ██║███████╗██║ ╚═╝ ██║███████╗██║ ╚═╝ ██║██████╔╝███████╗██║  ██║       ██║   ╚██████╔╝    '
    '╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝╚══════╝╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝       ╚═╝    ╚═════╝     '
    '                                                                                                '
    '██╗   ██╗██████╗ ██████╗  █████╗ ████████╗███████╗    ███╗   ███╗███████╗                       '
    '██║   ██║██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔════╝    ████╗ ████║██╔════╝                       '
    '██║   ██║██████╔╝██║  ██║███████║   ██║   █████╗      ██╔████╔██║█████╗                         '
    '██║   ██║██╔═══╝ ██║  ██║██╔══██║   ██║   ██╔══╝      ██║╚██╔╝██║██╔══╝                         '
    '╚██████╔╝██║     ██████╔╝██║  ██║   ██║   ███████╗    ██║ ╚═╝ ██║███████╗                       '
    ' ╚═════╝ ╚═╝     ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝    ╚═╝     ╚═╝╚══════╝                       '
    '================================================================================================'

    Public Shared VVer As Integer = 310


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles IDLabel.Click, PinLabel.Click, Label1.Click

    End Sub

    Sub CheckforUpdates() Handles Me.Load

        Try
            If File.Exists(System.Windows.Forms.Application.UserAppDataPath & "\cv.txt") Then File.Delete(System.Windows.Forms.Application.UserAppDataPath & "\cv.txt")
            My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/ViBE.CV.txt", System.Windows.Forms.Application.UserAppDataPath & "\cv.txt")
            FileOpen(1, System.Windows.Forms.Application.UserAppDataPath & "\cv.txt", OpenMode.Input)
            CV = LineInput(1)
            FileClose(1)
        Catch
            CV = -1
        End Try
    End Sub

    Sub AttemptAutoLogin() Handles Me.Shown


        Select Case CV
            Case > VVer
                DownloadForm.ShowDialog()

            Case < VVer
                If Not Directory.Exists("A:\DOWNLOADS") Then
                    MsgBox("Notify CHOPO! The CurrentVersion Text file is not updated!", MsgBoxStyle.Exclamation)
                End If
            Case VVer
                Exit Select
            Case -1
                MsgBox("An error has occured while checking for updates. The server may be down. If it isn't, contact CHOPO.", MsgBoxStyle.Critical)
        End Select



        AutoLogin = False
        If File.Exists(System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat") Then
            FileOpen(1, System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat", OpenMode.Input)
            Dim login() As String
            login = LineInput(1).Split(",")
            FileClose(1)

            LogonID.Text = login(0)
            LogonPIN.Text = login(1)
            AutoLogin = True
            CheckBox1.Checked = True
            Call Button1_Click()
            Exit Sub


        End If


    End Sub



    Sub Button1_Click() Handles Button1.Click
        Dim ID As String
        Dim PIN As String

        ID = LogonID.Text
        PIN = LogonPIN.Text

        If ID = "ViBED" Then

            ServerCommandLine.Show()
            Exit Sub

        End If

        IDLabel.Enabled = False
        PinLabel.Enabled = False
        LogonID.Enabled = False
        LogonPIN.Enabled = False
        DirectoryButton.Enabled = False
        Button2.Enabled = False
        Me.UseWaitCursor = True





        If ID = "" Then

            MsgBox("You must enter an ID", MsgBoxStyle.Critical, "ViBE Error")
            IDLabel.Enabled = True
            PinLabel.Enabled = True
            LogonID.Enabled = True
            LogonPIN.Enabled = True
            DirectoryButton.Enabled = True
            Button2.Enabled = True
            Me.UseWaitCursor = False

            Exit Sub

        End If

        If Not ID.Count = 5 Then

            MsgBox("That doesn't look like an ID. It must have 5 digits", MsgBoxStyle.Exclamation, "ViBE Error")
            IDLabel.Enabled = True
            PinLabel.Enabled = True
            LogonID.Enabled = True
            LogonPIN.Enabled = True
            DirectoryButton.Enabled = True
            Button2.Enabled = True
            Me.UseWaitCursor = False


            Exit Sub

        End If

        If PIN = "" Then

            MsgBox("You must enter an PIN", MsgBoxStyle.Critical, "ViBE Error")
            IDLabel.Enabled = True
            PinLabel.Enabled = True
            LogonID.Enabled = True
            LogonPIN.Enabled = True
            DirectoryButton.Enabled = True
            Button2.Enabled = True
            Me.UseWaitCursor = False


            Exit Sub

        End If

        If Not PIN.Count = 4 Then

            MsgBox("That doesn't look like a Pin. It must have 4 digits", MsgBoxStyle.Exclamation, "ViBE Error")
            IDLabel.Enabled = True
            PinLabel.Enabled = True
            LogonID.Enabled = True
            LogonPIN.Enabled = True
            DirectoryButton.Enabled = True
            Button2.Enabled = True
            Me.UseWaitCursor = False


            Exit Sub

        End If


        RefreshNotice.Show()
        Call BackgroundWorker1.RunWorkerAsync()



    End Sub


    Sub TheOldLoginCode()

        'This is the old code:


        'We need to look up the object in a list of files, and if it exists, check the pin.

        Dim ID As String
        Dim Pin As String
        Dim realpin As String

        ID = LogonID.Text
        Pin = LogonPIN.Text

        If Not System.IO.File.Exists("A:\Marsh\SSH\USERS\" & ID & "\pin.dll") Then
            MsgBox("User Not Found", vbCritical, "ViBE Error")

        Else
            FileOpen(1, "A:\MARSH\SSH\USERS\" & ID & "\pin.dll", OpenMode.Input)
            realpin = LineInput(1)
            FileClose(1)


            If Not realpin = Pin Then

                MsgBox("Incorrect PIN", vbCritical, "ViBE Error")

            Else


                VibeMainScreen.Show()

            End If

        End If


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        VibeRegister.ShowDialog()



        'Close()
    End Sub

    Private Sub DirectoryButton_Click(sender As Object, e As EventArgs) Handles DirectoryButton.Click

        DirWindow.ShowDialog()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        servermsg = ServerCommand("CU" & LogonID.Text & LogonPIN.Text)



    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted



        Select Case ServerMSG
            Case 1
                RefreshNotice.Close()
                MsgBox("User not found", vbCritical, "ViBE Login error")
                Exit Select
            Case 2
                RefreshNotice.Close()
                MsgBox("Pin is Incorrect", vbCritical, "ViBE Login Error")
                Exit Select

            Case 3



                If CheckBox1.Checked = True Then

                    If Not Directory.Exists(System.Windows.Forms.Application.UserAppDataPath & "\ViBE") Then
                        Directory.CreateDirectory(System.Windows.Forms.Application.UserAppDataPath & "\ViBE")
                    End If

                    FileOpen(1, System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat", OpenMode.Output)
                    PrintLine(1, LogonID.Text & "," & LogonPIN.Text)
                    FileClose(1)
                Else

                    If File.Exists(System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat") Then
                        File.Delete(System.Windows.Forms.Application.UserAppDataPath & "\ViBE\Login.dat")
                    End If


                End If

                    RefreshNotice.Close()

                Me.UseWaitCursor = False
                VibeMainScreen.Show()


        End Select



        IDLabel.Enabled = True
        PinLabel.Enabled = True
        LogonID.Enabled = True
        LogonPIN.Enabled = True
        DirectoryButton.Enabled = True
        Button2.Enabled = True
        Me.UseWaitCursor = False

    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        About.ShowDialog()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        About.ShowDialog()

    End Sub

    Function ServerCommand(ByVal ClientMSG As String) As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter


        servermsg = "E"

        If ClientMSG = "" Then
            ServerCommand = "E"
            Exit Function
        End If

        Try
            tc.Connect(“IGTNET-W.DDNS.NET”, 757)
            Exit Try

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
                servermsg = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "ViBE Error")
                    ServerCommand = "CRASH"
                Exit Function

            End Try


            tc.Close()

        End If

        ServerCommand = servermsg

    End Function

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub LogonID_KeyPress(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LogonID.KeyDown
        If e.KeyCode = Keys.Enter Then
            LogonPIN.Select()
        End If
    End Sub

    Private Sub LogonPIN_KeyPress(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles LogonPIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click()
        End If
    End Sub
End Class