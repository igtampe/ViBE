Imports VIBE__But_on_Visual_Studio_.CoreCommands

''' <summary>The ViBE Registration Window</summary>
Public Class VibeRegister

    '--------------------------------[Variables]--------------------------------

    Public ServerMSG As String

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>Sets the form up to be presented</summary>
    Private Sub Boing() Handles Me.Load

        'These should be the default values, but I have to set them here since I like seeing them while designing.

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

    '--------------------------------[Buttons]--------------------------------

    Private Sub ClosingTime() Handles CancelButtonReg.Click, OKBTN.Click
        Close()
    End Sub

    Private Sub PreRegisterTime() Handles RegisterButton.Click

        If Not CheckForInput() Then
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

    ''' <summary>Shows a warning to people attempting to start a corporate UMSWEB account</summary>
    Private Sub ShowCorporateWarning() Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            MsgBox("WARNING: If this is later found out this isn't actually used for corporate dealings, you will be liable for FRAUD and you will be charged backtaxes for any income registered to this account. By ticking this box you acknowledge that you have been notified about this.", MsgBoxStyle.Exclamation, "Warning!")
        End If
    End Sub

    '--------------------------------[Background Workers]--------------------------------

    ''' <summary>Asks server to register the user</summary>
    Private Sub RegisterTime() Handles BackgroundWorker1.DoWork
        ServerMSG = RegisterUser(PINTXB.Text, NameTXB.Text, CheckBox2.Checked)
    End Sub

    ''' <summary>Parses the response, and displays the post-registratoin message</summary>
    Private Sub PostRegisterTime() Handles BackgroundWorker1.RunWorkerCompleted
        If ServerMSG = "E" Then
            MsgBox("The server couldn't register you. Please try again later.")
            Exit Sub
        End If

        'Sets things to be visible
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

    '--------------------------------[Other Functions]--------------------------------

    ''' <summary>Check user's inputted data</summary>
    ''' <returns>True if its acceptable, False if otherwise</returns>
    Private Function CheckForInput() As Boolean

        'Name checks
        If String.IsNullOrWhiteSpace(NameTXB.Text) Then
            Return False
        End If

        'Pin Checks
        If String.IsNullOrWhiteSpace(PINTXB.Text) Or Not PINTXB.Text.Count = 4 Then
            CheckForInput = False
        End If

        Return True
    End Function


End Class