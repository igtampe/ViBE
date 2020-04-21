Imports System.IO
Imports System.Net

''' <summary>DownloadForm specifically designed to download a new ViBE Update</summary>
Public Class DownloadForm

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>Setsup the DownloadForm</summary>
    Private Sub LoadingTime() Handles Me.Load

        'Clear WhatsNew since we're updating
        If File.Exists(Application.UserAppDataPath & "\ViBE\WhatsNew.temp") Then File.Delete(Application.UserAppDataPath & "\ViBE\WhatsNew.temp")

        'Hide ViBE
        VibeLogin.Hide()

    End Sub

    ''' <summary>Sets up and starts the download</summary>
    Private Sub Showtime() Handles Me.Shown

        'Setup the progressbar
        ProgressBar1.Style = ProgressBarStyle.Continuous

        'Setup our client
        Dim client As WebClient = New WebClient

        'Add the handler for while we download, and when we're done
        AddHandler client.DownloadProgressChanged, AddressOf Client_ProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf Client_DownloadCompleted

        'Download the update, ~ asynchronously ~
        client.DownloadFileAsync(New Uri("http://igtnet-w.ddns.net:100/vibe.exe"), "NewVibe.exe")

    End Sub

    '--------------------------------[WebClient stuff]--------------------------------

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
            'make sure it exists, we don't want to suddenly try to update to a non-existent file.

            'Generate a small tiny batch file that'll kill ViBE twice (just in case)
            FileOpen(1, "UpdateVibe.bat", OpenMode.Output)

            PrintLine(1, "@echo off")
            PrintLine(1, "Taskkill /f /im ViBE.exe")
            PrintLine(1, "Taskkill /f /im ViBE.exe")

            'Delete ViBE
            PrintLine(1, "del ViBE.exe")

            'Rename our new copy to the old copy
            PrintLine(1, "Ren NewVibe.exe ViBE.exe")

            'And start ViBE again
            PrintLine(1, "Start ViBE.exe")

            'then start a tiny CMD window that will delete the update file.
            PrintLine(1, "start /b cmd /c del UpdateVibe.bat&exit /b")

            FileClose(1)

            'Start it, and that's it. This is the last line of code executed on a copy of ViBE before it is replaced with a new one.
            Process.Start("UpdateVibe.bat")
        End If

    End Sub


End Class