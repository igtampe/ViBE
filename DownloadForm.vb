Imports System.IO
Imports System.Net

Public Class DownloadForm
    Private Sub DownloadForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ProgressBar1.Style = ProgressBarStyle.Marquee
        If File.Exists(Application.UserAppDataPath & "\ViBE\WhatsNew.temp") Then File.Delete(Application.UserAppDataPath & "\ViBE\WhatsNew.temp")
        VibeLogin.Hide()

    End Sub

    Private Sub DownloadForm_Shown() Handles Me.Shown
        ProgressBar1.Style = ProgressBarStyle.Continuous
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf Client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf Client_DownloadCompleted
        client.DownloadFileAsync(New Uri("http://igtnet-w.ddns.net:100/vibe.exe"), "NewVibe.exe")


    End Sub

    Private Sub Client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        PercentageLabel.Text = Int32.Parse(Math.Truncate(percentage).ToString()) & "%"
    End Sub

    Private Sub Client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        'once its complete

        If File.Exists("NewVibe.exe") Then

        End If
        FileOpen(1, "UpdateVibe.bat", OpenMode.Output)

        PrintLine(1, "@echo off")
        PrintLine(1, "Taskkill /f /im ViBE.exe")
        PrintLine(1, "Taskkill /f /im ViBE.exe")
        PrintLine(1, "del ViBE.exe")
        PrintLine(1, "Ren NewVibe.exe ViBE.exe")
        PrintLine(1, "Start ViBE.exe")
        PrintLine(1, "start /b cmd /c del UpdateVibe.bat&exit /b")

        FileClose(1)
        Process.Start("UpdateVibe.bat")

    End Sub


End Class