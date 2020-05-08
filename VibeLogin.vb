Imports System.IO

''' <summary>ViBE's main form</summary>
Public Class VibeLogin

    '--------------------------------[Variables]--------------------------------

    ''' <summary>Server's CurrentVersion</summary>
    Public CV As String

    ''' <summary>Return message from the server</summary>
    Public servermsg As String

    ''' <summary>Flag to indicate whether this window did an auto login</summary>
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

    ''' <summary>This copy of ViBE's version ID</summary>
    Public Shared VVer As Integer = 501

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>Attempts to check for updates by downloading the CV (CurrentVersion) file from the IGTNET Server</summary>
    Private Sub TimeToLoad() Handles Me.Load

        'Grab the 
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

    ''' <summary>Handles the showtime operations</summary>
    Private Sub TimeToShow() Handles Me.Shown

        'Compares Server's current version to this copy of ViBE's version.
        If CV > VVer Then DownloadForm.Show()
        If CV = -1 Then MsgBox("An error has occured while checking for updates. The server may be down. If it isn't, contact CHOPO.", MsgBoxStyle.Critical)

        AutoLogin = False

        'Check if we can autologin
        AttemptAutoLogin()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    ''' <summary>Shows the about page</summary>
    Private Sub ShowAbout() Handles ViBELogoPictureBox.Click
        About.ShowDialog()
    End Sub

    ''' <summary>Closes the form</summary>
    Private Sub ClosingTime() Handles QuitButton.Click
        Close()
    End Sub

    ''' <summary>Launches the KeyRing, and handles what to do after its shown</summary>
    Private Sub KeyringButton_Click() Handles KeyringButton.Click

        'Launch the keyring form
        Hide()
        Dim LogonKeyRingForm As New KeyringForm() With {.CurrentFormMode = 0}
        LogonKeyRingForm.ShowDialog()

        'If the keyring can commit, then
        Show()
        If LogonKeyRingForm.ReturnValue.CommitAction = True Then

            'Retrieve the data
            LogonID.Text = LogonKeyRingForm.ReturnValue.ID
            LogonPIN.Text = LogonKeyRingForm.ReturnValue.Pin
            RememberMeCheckbox.Checked = LogonKeyRingForm.ReturnValue.Remember

            'dispose the form
            LogonKeyRingForm.Dispose()

            'Login
            LoginTime()
        Else
            'Now I know what we can put here.
            LogonKeyRingForm.Dispose()
        End If

    End Sub

    ''' <summary>Launches registration</summary>
    Private Sub LaunchRegistration() Handles RegisterButton.Click
        Dim newRegWindow As VibeRegister = New VibeRegister()
        newRegWindow.ShowDialog()
    End Sub

    ''' <summary>Launches the directory</summary>
    Private Sub LaunchDirectory() Handles DirectoryButton.Click
        Dim LoginDirectory As DirWindow = New DirWindow(DirWindow.DirectoryMode.Login)
        LoginDirectory.ShowDialog()

        If LoginDirectory.Commit Then LogonID.Text = LoginDirectory.MyReturn

    End Sub

    '--------------------------------[Login Operations]--------------------------------

    ''' <summary>Attemps to automatically log in using saved credentials</summary>
    Private Sub AttemptAutoLogin()

        'Check for the local login file
        If File.Exists(Application.UserAppDataPath & "\ViBE\Login.dat") Then

            'Open the file and read it
            FileOpen(1, Application.UserAppDataPath & "\ViBE\Login.dat", OpenMode.Input)
            Dim login() As String = LineInput(1).Split(",")
            FileClose(1)

            'Set a few things then attempt to login
            LogonID.Text = login(0)
            LogonPIN.Text = login(1)
            AutoLogin = True
            RememberMeCheckbox.Checked = True
            LoginTime()
        End If
    End Sub

    ''' <summary>Checks if the ID and Pin combination is valid</summary>
    Private Function IsValidIDPIN(ID As String, Pin As String)
        If String.IsNullOrEmpty(ID.Trim) Then
            MsgBox("You must enter an ID", MsgBoxStyle.Critical, "ViBE Error")
            Return False
        End If

        If Not ID.Count = 5 Then
            MsgBox("That doesn't look like an ID. It must have 5 digits", MsgBoxStyle.Exclamation, "ViBE Error")
            Return False
        End If

        If String.IsNullOrEmpty(Pin.Trim) Then
            MsgBox("You must enter an PIN", MsgBoxStyle.Critical, "ViBE Error")
            Return False
        End If

        If Not Pin.Count = 4 Then
            MsgBox("That doesn't look like a Pin. It must have 4 digits", MsgBoxStyle.Exclamation, "ViBE Error")
            Return False
        End If

        Return True
    End Function

    ''' <summary>Saves a user's credentials to be used to automatically login later</summary>
    Private Sub SaveAutoLogin()
        'Make sure the directory we're saving to exists
        If Not Directory.Exists(Application.UserAppDataPath & "\ViBE") Then Directory.CreateDirectory(Application.UserAppDataPath & "\ViBE")

        'save the data
        FileOpen(1, Application.UserAppDataPath & "\ViBE\Login.dat", OpenMode.Output)
        PrintLine(1, LogonID.Text & "," & LogonPIN.Text)
        FileClose(1)
    End Sub

    ''' <summary>Handles a login attempt</summary>
    Sub LoginTime() Handles LoginButton.Click

        'Read the string
        Dim ID As String = LogonID.Text
        Dim PIN As String = LogonPIN.Text

        If isValidIDPIN(ID, PIN) Then
            ImWaiting(True)
            RefreshNotice.Show()
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    ''' <summary>Runs the CheckUser operation in the background</summary>
    Private Sub CheckUser() Handles BackgroundWorker1.DoWork
        servermsg = CU(LogonID.Text, LogonPIN.Text)
    End Sub

    ''' <summary>Analyzes the response from the server after it's asked to check the user</summary>
    Private Sub DoneCheckingUser() Handles BackgroundWorker1.RunWorkerCompleted

        'Clpose these cositas
        RefreshNotice.Close()
        ImWaiting(False)

        Select Case servermsg
            Case 1
                MsgBox("User not found", vbCritical, "ViBE Login error")
                Exit Select
            Case 2
                MsgBox("Pin is Incorrect", vbCritical, "ViBE Login Error")
                Exit Select
            Case 3

                'If the user wants us to remember
                If RememberMeCheckbox.Checked = True Then
                    'remember
                    SaveAutoLogin()
                Else
                    'otherwise forget
                    If File.Exists(Application.UserAppDataPath & "\ViBE\Login.dat") Then File.Delete(Application.UserAppDataPath & "\ViBE\Login.dat")
                End If

                'Time for the actual main show
                VibeMainScreen.Show()

        End Select
    End Sub

    '--------------------------------[Other]--------------------------------

    ''' <summary>Check if the user hit enter in the ID section</summary>
    Private Sub LogonID_KeyPress(sender As Object, e As KeyEventArgs) Handles LogonID.KeyDown
        If e.KeyCode = Keys.Enter Then LogonPIN.Select()
    End Sub

    ''' <summary>Check if the user hit enter in the Pin section</summary>
    Private Sub LogonPIN_KeyPress(sender As Object, e As KeyEventArgs) Handles LogonPIN.KeyDown
        If e.KeyCode = Keys.Enter Then LoginTime()
    End Sub

    ''' <summary>sets the form into a "waiting" state</summary>
    Private Sub ImWaiting(Value As Boolean)
        Enabled = Not (Value)
        UseWaitCursor = Value
    End Sub

End Class