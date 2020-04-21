Imports System.IO

''' <summary>The ViBE Main Screen</summary>
Public Class VibeMainScreen

    '--------------------------------[Variables]--------------------------------

    ''' <summary>Server Reply for cross communication after BackgroundWorker runs</summary>
    Public ServerMSG As String

    ''' <summary>The Currently Logged In user</summary>
    Public Shared CurrentUser As User

    ''' <summary>ID of the current user</summary>
    Private ID As String

    'Even though currentuser holds ID, this is neccessary for the backgroundworker, which doesn't have access to the vibe login window

    ''' <summary>Used for switching IDs with the keyring</summary>
    Private SwitchID As String
    Private SwitchPIN As String

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>Clears and loads the form</summary>
    Private Sub LoadingTime() Handles Me.Shown

        'I would instantiate this form, but there should only be one instance of this form, regardless of whatever happens, so no.

        'Clear the main window
        BackgroundImage = Nothing
        NameLabel.Text = ""
        UMSNBBLabel.Text = ""
        GBANKBLabel.Text = ""
        RIVERBLabel.Text = ""
        TotalBLabel.Text = ""
        UMSNBCheck.Checked = False
        GBANKCheck.Checked = False
        RIVERCheck.Checked = False
        Enabled = False

        'Set our title
        Text = "Visual Basic Economy (Build ID:" & VibeLogin.VVer & ")"

        'Save the ID for the backgroundworker
        ID = VibeLogin.LogonID.Text

        'Show the refreshnotice and get us this user's information
        RefreshNotice.Show()
        RefreshBW.RunWorkerAsync()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub LogoutTime() Handles LogOutButton.Click
        'Clear the local RememberMe file.
        If File.Exists(Application.UserAppDataPath & "\ViBE\Login.dat") Then File.Delete(Application.UserAppDataPath & "\ViBE\Login.dat")

        'Close while indicating we mean to logout
        Close(True)
    End Sub

    Private Sub ShowChangePin() Handles ChangePinButton.Click
        Dim ChangePinWindow As VibeChangePin = New VibeChangePin()
        ChangePinWindow.ShowDialog()
    End Sub

    Private Sub ShowSendMoney() Handles SendMoneyBTN.Click
        Dim NewSendMoneyWindow As SendMonet = New SendMonet(CurrentUser)
        NewSendMoneyWindow.Show()
    End Sub

    Private Sub ShowTransferMoney() Handles TransferMoneyBTN.Click
        Dim NewTransferMoneyWindow As TransferMonet = New TransferMonet(CurrentUser)
        NewTransferMoneyWindow.Show()
    End Sub

    Private Sub LaunchEzTax() Handles EZTaxButton.Click
        'EzTax is something we should instantiate
        Dim MyEzTax As EZTaxMain = New EZTaxMain(CurrentUser)
        MyEzTax.Show()
    End Sub

    ''' <summary>Initiates a refresh</summary>
    Public Sub RefreshMe() Handles RefreshButton.Click

        'Make sure we don't ask the form to refresh while it's already refreshing
        If Not Enabled Then Return

        Enabled = False
        RefreshNotice.Show()
        RefreshBW.RunWorkerAsync()
    End Sub

    Private Sub OpenUMSNBWindow() Handles UMSNBLink.LinkClicked
        Dim UMSNBBankWindow As New BankWindow(CurrentUser, "UMSNB")
        UMSNBBankWindow.Show()
    End Sub

    Private Sub OpenGBANKWindow() Handles GBANKLink.LinkClicked
        Dim UMSNBBankWindow As New BankWindow(CurrentUser, "GBANK")
        UMSNBBankWindow.Show()
    End Sub

    Private Sub OpenRIVERWindow() Handles RIVERLink.LinkClicked
        Dim UMSNBBankWindow As New BankWindow(CurrentUser, "RIVER")
        UMSNBBankWindow.Show()
    End Sub

    Private Sub ShowAbout() Handles AboutButton.Click
        About.Show()
    End Sub

    Private Sub ShowNotifs() Handles NotifButton.Click
        Dim MyNotifForm As NotificationsForm = New NotificationsForm(ID)
        MyNotifForm.ShowDialog()
    End Sub

    Private Sub ShowLandview() Handles LNDViewBTN.Click
        LandView.Show()
    End Sub

    Private Sub ShowCheckbook() Handles CheckBookBTN.Click
        Dim NewCheckbook As CheckbookMain = New CheckbookMain(CurrentUser)
        NewCheckbook.Show()
    End Sub

    Private Sub ShowContractus() Handles ContractusBTN.Click
        Dim NewContractus As ConMain = New ConMain(CurrentUser)
        NewContractus.Show()
    End Sub

    Private Sub SwitchUserKeyRing() Handles KeyringButton.Click

        'create and launch a keyringform.
        Dim SwitchUserForm As New KeyringForm() With {.CurrentFormMode = 1}
        Hide()
        SwitchUserForm.ShowDialog()

        If SwitchUserForm.ReturnValue.CommitAction = True Then
            'Retrieve the data
            SwitchID = SwitchUserForm.ReturnValue.ID
            SwitchPIN = SwitchUserForm.ReturnValue.Pin
            SwitchUserForm.Dispose()

            'Test the coso
            RefreshNotice.Show()
            SwitchUserBW.RunWorkerAsync()
        Else
            SwitchUserForm.Dispose()
            Show()
        End If

    End Sub

    '--------------------------------[Background Workers]--------------------------------

    ''' <summary>Gets user information</summary>
    Private Sub GetInfo() Handles RefreshBW.DoWork
        'update current user
        CurrentUser = Nothing

        Try
            CurrentUser = New User(ID)
        Catch ex As Exception
            Debug.Print(ex.StackTrace)
            MsgBox("Could not get user " & VibeLogin.LogonID.Text, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>Pareses the received information</summary>
    Private Sub ProcessInfo() Handles RefreshBW.RunWorkerCompleted

        'The form deactivates for some reason I'm not sure of, so this re-activates it.
        Activate()

        'If we couldn't get the user, logout
        If IsNothing(CurrentUser) Then Close(True)

        'Check for this user's category
        Select Case CurrentUser.Category
            Case User.UserCategory.Corporate
                BackgroundImage = My.Resources.Corporate
            Case User.UserCategory.Government
                BackgroundImage = My.Resources.Government
            Case User.UserCategory.Normal
                BackgroundImage = Nothing
        End Select

        'Populate the form
        UMSNBCheck.Checked = CurrentUser.UMSNB
        GBANKCheck.Checked = CurrentUser.GBANK
        RIVERCheck.Checked = CurrentUser.RIVER

        UMSNBBLabel.Text = CurrentUser.UMSNBBalance.ToString("N0") & "p"
        GBANKBLabel.Text = CurrentUser.GBANKBalance.ToString("N0") & "p"
        RIVERBLabel.Text = CurrentUser.RIVERBalance.ToString("N0") & "p"
        TotalBLabel.Text = CurrentUser.TotalBalance.ToString("N0") & "p"

        NameLabel.Text = CurrentUser.ToString

        'Enable the form
        RefreshNotice.Close()
        Enabled = True

        'Update the notification button
        NotifButton.Text = CurrentUser.Notifications
        NotifButton.Enabled = (CurrentUser.Notifications > 0)

        'Make sure the font fits
        If CurrentUser.Notifications > 9 Then
            NotifButton.Font = New Font("Microsoft Sans Serif", 6)
        Else
            NotifButton.Font = New Font("Microsoft Sans Serif", 8)
        End If

        'Check to make sure if we need to show WhatsNew
        If Not File.Exists(Application.UserAppDataPath & "\ViBE\WhatsNew.temp") Then

            WhatsNew.Show()

            'Make sure the folder exists, and then make the file that marks that we have, indeed, shown WhatsNew
            If Not Directory.Exists(Application.UserAppDataPath & "\ViBE") Then Directory.CreateDirectory(Application.UserAppDataPath & "\ViBE")
            File.Create(Application.UserAppDataPath & "\ViBE\WhatsNew.temp")
        End If

        'Hide the login window, if it's not already hidden.
        VibeLogin.Hide()
    End Sub

    ''' <summary>Verifies we can switch to the user specified by the keyring</summary>
    Private Sub VerifyNewKeyringUser() Handles SwitchUserBW.DoWork
        ServerMSG = CU(SwitchID, SwitchPIN)
    End Sub

    ''' <summary>Processes the return from the server</summary>
    Private Sub ProcessKeyRingUserResult() Handles SwitchUserBW.RunWorkerCompleted
        RefreshNotice.Close()
        Select Case ServerMSG
            Case 1
                RefreshNotice.Close()
                MsgBox("User not found" & vbNewLine & "How did you even add this account to the KeyRing?", vbCritical, "ViBE Login error")
                SwitchUserKeyRing()
                Exit Select
            Case 2
                RefreshNotice.Close()
                MsgBox("Pin is Incorrect." & vbNewLine & "Sign in manually, delete this account, and re-add it.", vbCritical, "ViBE Login Error")
                SwitchUserKeyRing()
                Exit Select

            Case 3
                VibeLogin.LogonID.Text = SwitchID
                VibeLogin.LogonPIN.Text = SwitchPIN
                ID = VibeLogin.LogonID.Text
                SwitchID = ""
                SwitchPIN = ""
                Show()
                LoadingTime()
        End Select
    End Sub

    '--------------------------------[Closing Up]--------------------------------

    ''' <summary>Handles the actual closing of the form (Like from the X)</summary>
    Public Shared Sub CloseUpShop() Handles Me.Closing
        'If the vibelogin window hasn't been reset, then its time to close up for good.
        If Not String.IsNullOrWhiteSpace(VibeLogin.LogonID.Text) Then VibeLogin.Close()
    End Sub

    ''' <summary>Overloads close for a little more precision</summary>
    ''' <param name="LogoutExit">Specify wether to close the form and show the ViBE login screen or not.</param>
    Public Overloads Sub Close(LogoutExit As Boolean)

        If LogoutExit Then
            'Reset the login form
            VibeLogin.Show()
            VibeLogin.LogonID.Text = ""
            VibeLogin.LogonPIN.Text = ""
        End If

        Close()
    End Sub


End Class