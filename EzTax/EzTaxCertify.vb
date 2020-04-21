Imports System.Drawing.Imaging
Imports System.IO

''' <summary>Form used to send and display an EzTax certification request</summary>
Public Class EzTaxCertify

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly Item As IncomeRegistryItem
    Private ReadOnly HasToReport As Boolean
    Private ServerMSG As String

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(Item As IncomeRegistryItem, Optional MustReport As Boolean = False)
        InitializeComponent()
        Me.Item = Item
        HasToReport = MustReport

        DetailsTXB.Text = Item.ToString

    End Sub

    Private Sub ThePreShow() Handles Me.Shown
        Size = MinimumSize
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub DrawTheCurtain() Handles OKButton.Click
        Close()
    End Sub

    Private Sub ShowBackstage() Handles DetailsButton.Click
        If Size = MinimumSize Then
            Size = MaximumSize
        Else
            Size = MinimumSize
        End If
    End Sub

    Private Sub PostShowPhoto() Handles CopyBTN.Click
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

    Private Sub ThatsAKeeper() Handles SaveBTN.Click
        Dim bmpScreenShot As Bitmap
        Dim gfxScreenshot As Graphics

        bmpScreenShot = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)

        gfxScreenshot = Graphics.FromImage(bmpScreenShot)
        gfxScreenshot.CopyFromScreen(Location.X, Location.Y, 0, 0, Size, CopyPixelOperation.SourceCopy)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png")

        Dim FD As SaveFileDialog = New SaveFileDialog() With {
            .Title = "Save As",
            .AddExtension = True,
            .AutoUpgradeEnabled = True,
            .CheckFileExists = False,
            .CheckPathExists = True,
            .DefaultExt = ".png",
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures,
            .OverwritePrompt = True,
            .SupportMultiDottedExtensions = False,
            .ValidateNames = True,
            .FileName = "Doot.png"
        }

        If FD.ShowDialog() = DialogResult.OK Then
            bmpScreenShot.Save(FD.FileName, ImageFormat.Png)
        Else
            'ok no
        End If

    End Sub

    '--------------------------------[Background Worker]--------------------------------

    Private Sub ExecuteThePlay(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ServerMSG = Certify(Item.Name & " HAS INCOME " & Item.TotalIncome.ToString("N0") & "p (" & Item.Apartment.Income & " + " & Item.Hotel.Income & " + " & Item.Business.Income & " + " & Item.MiscIncome & ")")
    End Sub

    Private Sub TakeABow() Handles BackgroundWorker1.RunWorkerCompleted

        Select Case ServerMSG
            Case "S"

                If HasToReport Then
                    TitleLBL.Text = "Item Certified!"
                    ReportLabel.Text = "Please send the copied screenshot to the SDC"

                Else
                    TitleLBL.Text = "Item Re-Certified!"
                    ReportLabel.Text = "You do not need to re-report this income"
                End If

                SubtitleLBL.Text = Item.Name & " Has a calculated income of " & Item.TotalIncome.ToString("N0") & "p"

                OKButton.Enabled = True
                DetailsButton.Enabled = True
                PictureBox1.Image = My.Resources.EzTaxApproved
                WaitForRender.RunWorkerAsync()

            Case "E"
                MsgBox("Something happened... I do not know what happened.", MsgBoxStyle.Critical, "Please Help")
                Close()
        End Select

    End Sub


    Private Sub WaitForIt(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WaitForRender.DoWork
        Threading.Thread.Sleep(50)
    End Sub

    Sub Alright() Handles WaitForRender.RunWorkerCompleted
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

    '--------------------------------[Window Moving Functions]--------------------------------

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