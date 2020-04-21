''' <summary>Verifies, and then updates the income of a user</summary>
Public Class EzTaxUpdateIncome
    Private ReadOnly AllIncomeItems() As IncomeRegistryItem
    Private ReadOnly UserID As String

    Private TotalIncome As Long
    Private ServerMSG As String

    Public Sub New(AllItems As IncomeRegistryItem(), UserID As String)
        InitializeComponent()
        AllIncomeItems = AllItems
        Me.UserID = UserID
    End Sub

    Private Sub ThePreShow() Handles Me.Shown
        Size = MinimumSize
        OKButton.Enabled = False
        BackupButton.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub DrawTheCurtain() Handles OKButton.Click
        Close()
    End Sub

    Private Sub ExecuteThePlay() Handles BackgroundWorker1.DoWork

        Dim NewpondIncome As Long = 0
        Dim UrbiaIncome As Long = 0
        Dim ParadisusIncome As Long = 0
        Dim LaertesIncome As Long = 0
        Dim NOIncome As Long = 0
        Dim SOIncome As Long = 0

        Dim Send As Boolean = True

        If IsNothing(AllIncomeItems) Then
            ServerMSG = "You have no income items"
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

        If Send Then ServerMSG = EzTaxCommands.UpdateIncome(UserID, TotalIncome, NewpondIncome, UrbiaIncome, ParadisusIncome, LaertesIncome, NOIncome, SOIncome)

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
        Dim LBLBackupWindow As LBLSender = New LBLSender(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & UserID & ".IncomeRegistry.csv")
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