Imports System.ComponentModel
Imports System.IO
Imports VIBE__But_on_Visual_Studio_.Core

Public Class VibeMainScreen

    Public ServerMSG As String

    ''' <summary>
    ''' Currently Logged in ViBE Login ID
    ''' </summary>
    Public Shared ID As String
    Public LogoutExit As Boolean = False
    Public Category As Integer

    ''' <summary>
    ''' Currently Logged ViBE Username
    ''' </summary>
    Public Shared Username As String

    Public SwitchID As String
    Public SwitchPIN As String

    Private Sub LoadValuesFromTemp() Handles Me.Shown
        Me.BackgroundImage = Nothing
        NameLabel.Text = ""
        UMSNBBLabel.Text = ""
        GBANKBLabel.Text = ""
        RIVERBLabel.Text = ""
        TotalBLabel.Text = ""
        UMSNBCheck.Checked = False
        GBANKCheck.Checked = False
        RIVERCheck.Checked = False

        AllButtonsEnabled(False)
        ID = VibeLogin.LogonID.Text
        Me.Text = "Visual Basic Economy (Build ID:" & VibeLogin.VVer & ")"
        RefreshNotice.Show()
        Call RefreshBW.RunWorkerAsync()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If File.Exists(Application.UserAppDataPath & "\ViBE\Login.dat") Then
            File.Delete(Application.UserAppDataPath & "\ViBE\Login.dat")
        End If
        LogoutExit = True
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VibeChangePin.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TransferMonet.ShowDialog()
        RefreshButton_Click()
    End Sub

    Private Sub LaunchEzTax(Sender As Object, e As EventArgs) Handles EZTaxButton.Click
        EZTaxMain.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendMonet.ShowDialog()
        RefreshButton_Click()
    End Sub

    Private Sub ToQuitonQuit(sender As Object, e As EventArgs) Handles Me.Closing
        If LogoutExit = True Then
            VibeLogin.Show()
            VibeLogin.LogonID.Text = ""
            VibeLogin.LogonPIN.Text = ""
        Else
            VibeLogin.Close()
        End If

    End Sub

    Private Sub RefreshButton_Click() Handles RefreshButton.Click
        AllButtonsEnabled(False)
        RefreshNotice.Show()
        RefreshBW.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RefreshBW.DoWork
        ServerMSG = INFO(ID)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles RefreshBW.RunWorkerCompleted
        Dim TotalBalance As Long

        Dim UMSNB As Boolean
        Dim GBANK As Boolean
        Dim RIVER As Boolean
        Dim UMSNBBalance As Long
        Dim GBANKBalance As Long
        Dim RIVERBalance As Long
        Dim SplitValues() As String

        SplitValues = ServerMSG.Split(",")

        If SplitValues(0) = 1 Then UMSNB = True Else UMSNB = False
        UMSNBBalance = SplitValues(1)
        If SplitValues(2) = 1 Then GBANK = True Else GBANK = False
        GBANKBalance = SplitValues(3)
        If SplitValues(4) = 1 Then RIVER = True Else RIVER = False
        RIVERBalance = SplitValues(5)
        Username = SplitValues(6)

        If Username.EndsWith(" (Corp.)") Then
            Category = 1
            Me.BackgroundImage = My.Resources.Corporate
            Username = Username.Replace(" (Corp.)", "")
        ElseIf Username.EndsWith(" (Gov.)") Then
            Me.BackgroundImage = My.Resources.Government
            Category = 2
            Username = Username.Replace(" (Gov.)", "")
        Else
            Me.BackgroundImage = Nothing
            Category = 0
        End If

        UMSNBCheck.Checked = UMSNB
        GBANKCheck.Checked = GBANK
        RIVERCheck.Checked = RIVER

        UMSNBBLabel.Text = UMSNBBalance.ToString("N0") & "p"
        GBANKBLabel.Text = GBANKBalance.ToString("N0") & "p"
        RIVERBLabel.Text = RIVERBalance.ToString("N0") & "p"

        TotalBalance = UMSNBBalance + GBANKBalance + RIVERBalance
        TotalBLabel.Text = TotalBalance.ToString("N0") & "p"

        NameLabel.Text = Username & " (" & ID & ")"

        RefreshNotice.Close()

        AllButtonsEnabled(True)
        If Category = 2 Then EZTaxButton.Enabled = False

        NotifButton.Text = SplitValues(7)
        If SplitValues(7) > 9 Then
            NotifButton.Font = New Font("Microsoft Sans Serif", 6)
        Else
            NotifButton.Font = New Font("Microsoft Sans Serif", 8)
        End If

        If SplitValues(7) = 0 Then
            NotifButton.Enabled = False
        Else
            NotifButton.Enabled = True
        End If

        If Not File.Exists(Application.UserAppDataPath & "\ViBE\WhatsNew.temp") Then
            WhatsNew.Show()
            If Not Directory.Exists(Application.UserAppDataPath & "\ViBE") Then
                Directory.CreateDirectory(Application.UserAppDataPath & "\ViBE")
            End If
            File.Create(Application.UserAppDataPath & "\ViBE\WhatsNew.temp")
        End If

        Try
            VibeLogin.Hide()
        Catch
        End Try
    End Sub

    Private Sub UMSNBLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles UMSNBLink.LinkClicked
        'UMSNB
        BANKTXB.Text = "UMSNB"
        BankWindow.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Private Sub GBANKLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GBANKLink.LinkClicked
        'GBANK
        BANKTXB.Text = "GBANK"
        BankWindow.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Private Sub RIVERLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RIVERLink.LinkClicked
        'RIVER
        BANKTXB.Text = "RIVER"
        BankWindow.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        About.Show()
    End Sub

    Private Sub NotifButton_Click(sender As Object, e As EventArgs) Handles NotifButton.Click
        If NotifButton.Text = "0" Then
            MsgBox("There are no notifications, dummy!", vbInformation)
        Else
            NotificationsForm.ShowDialog()
            Call RefreshButton_Click()
        End If
    End Sub

    Private Sub LNDViewBTN_Click(sender As Object, e As EventArgs) Handles LNDViewBTN.Click
        LandView.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckbookMain.ShowDialog()
        Call RefreshButton_Click()
    End Sub

    Sub AllButtonsEnabled(Value As Boolean)

        RefreshButton.Enabled = Value
        Button1.Enabled = Value
        Button2.Enabled = Value
        Button3.Enabled = Value
        Button4.Enabled = Value
        Button5.Enabled = Value
        Button6.Enabled = Value
        EZTaxButton.Enabled = Value
        NotifButton.Enabled = Value
        LNDViewBTN.Enabled = Value
        RIVERLink.Enabled = Value
        UMSNBLink.Enabled = Value
        GBANKLink.Enabled = Value
        Button7.Enabled = Value
        KeyringButton.Enabled = Value

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ConMain.Show()
    End Sub

    Private Sub TakeScreenshot() Handles CaptureScreenshot.Click
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

    Private Sub SwitchUserKeyRing() Handles KeyringButton.Click
        Dim SwitchUserForm As New KeyringForm() With {
        .CurrentFormMode = 1
        }
        Me.Hide()
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
            Me.Show()
        End If

    End Sub

    Private Sub SwitchUserBW_DoWork(sender As Object, e As DoWorkEventArgs) Handles SwitchUserBW.DoWork
        ServerMSG = CU(SwitchID, SwitchPIN)
    End Sub

    Private Sub SwitchUserBW_Complete() Handles SwitchUserBW.RunWorkerCompleted
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
                ID = SwitchID
                VibeLogin.LogonID.Text = SwitchID
                VibeLogin.LogonPIN.Text = SwitchPIN
                SwitchPIN = ""
                Me.Show()
                LoadValuesFromTemp()
        End Select
    End Sub

End Class