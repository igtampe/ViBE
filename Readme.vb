''' <summary>Holds the readme</summary>
Public Class ReadmeWindow
    Private Sub ClosingTime() Handles Button1.Click
        Close()
    End Sub

    Private Sub LoadReadme() Handles MyBase.Load
        RichTextBox1.Rtf = My.Resources.readme
    End Sub
End Class