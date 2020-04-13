Imports System.ComponentModel
Imports System.IO
Imports VIBE__But_on_Visual_Studio_.CoreCommands

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

    Public Shared VVer As Integer = 412

    Sub CheckforUpdates() Handles Me.Load
        Try
            If File.Exists(Application.UserAppDataPath & "\cv.txt") Then File.Delete(Application.UserAppDataPath & "\cv.txt")
            My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/ViBE.CV.txt", Application.UserAppDataPath & "\cv.txt")
            FileOpen(1, Application.UserAppDataPath & "\cv.txt", OpenMode.Input)
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
        If File.Exists(Application.UserAppDataPath & "\ViBE\Login.dat") Then
            FileOpen(1, Application.UserAppDataPath & "\ViBE\Login.dat", OpenMode.Input)
            Dim login() As String
            login = LineInput(1).Split(",")
            FileClose(1)

            LogonID.Text = login(0)
            LogonPIN.Text = login(1)
            AutoLogin = True
            RememberMeCheckbox.Checked = True
            Button1_Click()
        End If
    End Sub

    Sub ImWaiting(Value As Boolean)
        Enabled = Not (Value)
        UseWaitCursor = Value
    End Sub

    Sub Button1_Click() Handles Button1.Click
        Dim ID As String = LogonID.Text
        Dim PIN As String = LogonPIN.Text

        If ID = "ViBED" Then
            ServerCommandLine.Show()
            Exit Sub
        End If

        ImWaiting(True)

        If String.IsNullOrEmpty(ID.Trim) Then
            MsgBox("You must enter an ID", MsgBoxStyle.Critical, "ViBE Error")
            ImWaiting(False)
            Exit Sub
        End If

        If Not ID.Count = 5 Then
            MsgBox("That doesn't look like an ID. It must have 5 digits", MsgBoxStyle.Exclamation, "ViBE Error")
            ImWaiting(False)
            Exit Sub
        End If

        If String.IsNullOrEmpty(PIN.Trim) Then
            MsgBox("You must enter an PIN", MsgBoxStyle.Critical, "ViBE Error")
            ImWaiting(False)
            Exit Sub
        End If

        If Not PIN.Count = 4 Then
            MsgBox("That doesn't look like a Pin. It must have 4 digits", MsgBoxStyle.Exclamation, "ViBE Error")
            ImWaiting(False)
            Exit Sub
        End If

        RefreshNotice.Show()
        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        VibeRegister.ShowDialog()
    End Sub

    Private Sub DirectoryButton_Click(sender As Object, e As EventArgs) Handles DirectoryButton.Click
        DirWindow.ShowDialog()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        servermsg = CU(LogonID.Text, LogonPIN.Text)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Select Case servermsg
            Case 1
                RefreshNotice.Close()
                MsgBox("User not found", vbCritical, "ViBE Login error")
                Exit Select
            Case 2
                RefreshNotice.Close()
                MsgBox("Pin is Incorrect", vbCritical, "ViBE Login Error")
                Exit Select
            Case 3
                If RememberMeCheckbox.Checked = True Then
                    If Not Directory.Exists(Application.UserAppDataPath & "\ViBE") Then
                        Directory.CreateDirectory(Application.UserAppDataPath & "\ViBE")
                    End If

                    FileOpen(1, Application.UserAppDataPath & "\ViBE\Login.dat", OpenMode.Output)
                    PrintLine(1, LogonID.Text & "," & LogonPIN.Text)
                    FileClose(1)
                Else
                    If File.Exists(Application.UserAppDataPath & "\ViBE\Login.dat") Then
                        File.Delete(Application.UserAppDataPath & "\ViBE\Login.dat")
                    End If
                End If
                RefreshNotice.Close()

                ImWaiting(False)
                VibeMainScreen.Show()


        End Select
        ImWaiting(False)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        About.ShowDialog()
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

    Private Sub KeyringButton_Click(sender As Object, e As EventArgs) Handles KeyringButton.Click
        Me.Hide()
        Dim LogonKeyRingForm As New KeyringForm() With {
        .CurrentFormMode = 0
        }


        LogonKeyRingForm.ShowDialog()
        Me.Show()
        If LogonKeyRingForm.ReturnValue.CommitAction = True Then

            'Retrieve the data
            LogonID.Text = LogonKeyRingForm.ReturnValue.ID
            LogonPIN.Text = LogonKeyRingForm.ReturnValue.Pin
            RememberMeCheckbox.Checked = LogonKeyRingForm.ReturnValue.Remember

            LogonKeyRingForm.Dispose()
            Button1_Click()

        Else
            'do nothing really nose porque puse else
        End If
    End Sub
End Class