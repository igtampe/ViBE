Public Class ClipboardNotice

    Public Fadeout As Double

    Sub slowfade() Handles Me.Shown
        Opacity = 0.9
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub ReportProgresso() Handles BackgroundWorker1.ProgressChanged
        Opacity = Fadeout
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Threading.Thread.Sleep(250)

        For Fadeout = 0.9 To 0.01 Step -0.01
            BackgroundWorker1.ReportProgress(Fadeout * 100)
            Threading.Thread.Sleep(20)
        Next

    End Sub

    Private Sub Closeit() Handles BackgroundWorker1.RunWorkerCompleted
        Close()
    End Sub

End Class