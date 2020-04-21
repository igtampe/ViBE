﻿Imports VIBE__But_on_Visual_Studio_.EZTaxMain

Public Class EzTaxUpdateIncome
    Public AllIncomeItems() As IncomeRegistryItem
    Public TotalIncome As Long
    Public ServerMSG

    Private Sub ThePreShow(sender As Object, e As EventArgs) Handles Me.Shown
        Size = MinimumSize
        OKButton.Enabled = False
        BackupButton.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub DrawTheCurtain() Handles OKButton.Click
        Close()
    End Sub

    Private Sub ExecuteThePlay(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'EZTax UPDATE Message:
        'ID,Total,NewpondIncome,UrbiaIncome,ParadisusIncome,LaertesIncome,NOIncome,SOIncome
        'EZTUPD57174,0,0,0,0,0,0asd
        Dim NewpondIncome As Long = 0
        Dim UrbiaIncome As Long = 0
        Dim ParadisusIncome As Long = 0
        Dim LaertesIncome As Long = 0
        Dim NOIncome As Long = 0
        Dim SOIncome As Long = 0

        Dim Send As Boolean = True

        'Newpond
        'Paradisus
        'Urbia
        'Laertes
        'South Osten
        'North Osten

        If IsNothing(AllIncomeItems) Then
            ServerMSG = "You have no income items"
            Send = False
            Exit Sub
        End If

        For Each Current As IncomeRegistryItem In AllIncomeItems
            TotalIncome += Current.TotalIncome
            Select Case Current.Location.ToUpper
                Case "NEWPOND"
                    NewpondIncome += Current.TotalIncome
                Case "URBIA"
                    UrbiaIncome += Current.TotalIncome
                Case "PARADISUS"
                    ParadisusIncome += Current.TotalIncome
                Case "LAERTES"
                    LaertesIncome += Current.TotalIncome
                Case "NORTH OSTEN"
                    NOIncome += Current.TotalIncome
                Case "SOUTH OSTEN"
                    SOIncome += Current.TotalIncome
                Case Else
                    ServerMSG = Current.Name & " does not have a valid location (" & Current.Location.ToUpper & ")"
                    Send = False
                    Exit Sub
            End Select
        Next

        If Send Then ServerMSG = EzTaxCommands.UpdateIncome(VibeMainScreen.CurrentUser.ID, TotalIncome, NewpondIncome, UrbiaIncome, ParadisusIncome, LaertesIncome, NOIncome, SOIncome)

    End Sub

    Private Sub TakeABow() Handles BackgroundWorker1.RunWorkerCompleted

        Select Case ServerMSG
            Case "S"
                TitleLBL.Text = "Income Updated!"
                SubtitleLBL.Text = "You Have a total income of " & TotalIncome.ToString("N0") & "p" & vbNewLine & "You can also now proceed to upload your IRF"

                BackupButton.Enabled = True
                OKButton.Enabled = True
                PictureBox1.Image = My.Resources.EzTaxApproved

            Case "E"
                MsgBox("Something happened... I do not know what happened.", MsgBoxStyle.Critical, "Please Help")
                Close()

            Case Else
                TitleLBL.Text = "Failed to Update Income"
                SubtitleLBL.Text = ServerMSG

                OKButton.Enabled = True
                PictureBox1.Image = My.Resources.EzTaxDenied

        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackupButton.Click
        Dim LBLBackupWindow As LBLSender = New LBLSender(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & EZTaxMain.ID & ".IncomeRegistry.csv")
        LBLBackupWindow.Show()
        Close()
    End Sub

    ''' <summary>
    ''' This has to do with moving the window
    ''' </summary>
    Public WindowIsmoving As Boolean
    Public DX As Integer
    Public DY As Integer

    Public Sub TimeToMove() Handles EzTaxTopLabel.MouseDown
        WindowIsmoving = True
        DX = Location.X - MousePosition.X
        DY = Location.Y - MousePosition.Y
    End Sub

    Private Sub ImMoving(sender As Object, e As MouseEventArgs) Handles EzTaxTopLabel.MouseMove
        If WindowIsmoving Then
            Me.SetDesktopLocation(DX + MousePosition.X, DY + MousePosition.Y)
        End If
    End Sub

    Public Sub OktimeToStop() Handles EzTaxTopLabel.MouseUp
        WindowIsmoving = False
    End Sub

End Class