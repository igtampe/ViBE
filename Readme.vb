Public Class ReadmeWindow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Readme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Rtf = My.Resources.readme
    End Sub
End Class