Imports System.Drawing.Imaging
Imports VIBE__But_on_Visual_Studio_.EZTaxMain
Imports System.IO

Public Class EzTaxCertify
    Public ItemToCertify As IncomeRegistryItem
    Public ServerMSG
    Public ItemName As String
    Public ItemIncome As Long
    Public HasToReport As Boolean

    Private Sub ThePreShow(sender As Object, e As EventArgs) Handles Me.Shown
        Size = MinimumSize
        ItemName = ItemToCertify.Name
        ItemIncome = ItemToCertify.TotalIncome
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub DrawTheCurtain() Handles OKButton.Click
        Close()
    End Sub

    Private Sub ExecuteThePlay(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ServerMSG = ServerCommand.RawCommand("CERT" & ItemName & " HAS INCOME " & ItemIncome.ToString("N0") & "p (" & ItemToCertify.Apartment.Income & " + " & ItemToCertify.Hotel.Income & " + " & ItemToCertify.Business.Income & " + " & ItemToCertify.MiscIncome & ")")
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

                SubtitleLBL.Text = ItemName & " Has a calculated income of " & ItemIncome.ToString("N0") & "p"

                OKButton.Enabled = True
                DetailsButton.Enabled = True
                PictureBox1.Image = My.Resources.EzTaxApproved
                WaitForRender.RunWorkerAsync()

            Case "E"
                MsgBox("Something happened... I do not know what happened.", MsgBoxStyle.Critical, "Please Help")
                Close()
        End Select

    End Sub

    Private Sub PostShowPhoto() Handles Button1.Click
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

    Private Sub ThatsAKeeper() Handles Button2.Click
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

    Private Sub WaitForIt(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WaitForRender.DoWork
        Threading.Thread.Sleep(50)
    End Sub

    Sub Alright() Handles WaitForRender.RunWorkerCompleted
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        If Size = MinimumSize Then
            Size = MaximumSize
        Else
            Size = MinimumSize
        End If
    End Sub
End Class