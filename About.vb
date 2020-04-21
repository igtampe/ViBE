''' <summary>Shows aboout page</summary>
Public Class About

    Private Sub LoadVer() Handles Me.Load
        VerLabel.Text = "Version " & VibeLogin.VVer & ", (C)2020 Igtampe, No Rights Reserved"
    End Sub

    Private Sub ClosingTime() Handles Button1.Click
        Close()
    End Sub

    Private Sub ShowReadme() Handles Button2.Click
        ReadmeWindow.Show()
    End Sub

    Private Sub ShowWhatsNew() Handles LinkLabel1.LinkClicked
        WhatsNew.Show()
    End Sub
End Class