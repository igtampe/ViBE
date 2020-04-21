''' <summary>Shows a notice that says we've copied something to the clipboard</summary>
Public Class QuickNotif

    '--------------------------------[Variables]--------------------------------

    Private Fadeout As Double

    Private ReadOnly InitialWait As Integer
    Private ReadOnly FadeOutStep As Integer
    Private ReadOnly InitialOpacity As Double

    '--------------------------------[Initialization]--------------------------------

    ''' <summary>
    ''' Creates a quicknotif window
    ''' </summary>
    ''' <param name="Message">Message of the quick notification</param>
    ''' <param name="InitialWait">Wait before fading out</param>
    ''' <param name="FadeOutStep">Wait between each 1% drop in opacity</param>
    ''' <param name="initialOpacity">Initial opacity of the window</param>
    Public Sub New(Message As String, Optional InitialWait As Integer = 250, Optional FadeOutStep As Integer = 20, Optional InitialOpacity As Double = 0.9)
        InitializeComponent()
        Me.InitialWait = InitialWait
        Me.FadeOutStep = FadeOutStep
        Me.InitialOpacity = InitialOpacity
        Label1.Text = Message
    End Sub

    Sub slowfade() Handles Me.Shown
        Opacity = InitialOpacity
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    '--------------------------------[f a d e]--------------------------------

    Private Sub ReportProgresso() Handles BackgroundWorker1.ProgressChanged
        Opacity = Fadeout
    End Sub

    Private Sub BackgroundWorker1_DoWork() Handles BackgroundWorker1.DoWork
        Threading.Thread.Sleep(InitialWait)

        For Fadeout = InitialOpacity To 0.01 Step -0.01
            BackgroundWorker1.ReportProgress(Fadeout * 100)
            Threading.Thread.Sleep(FadeOutStep)
        Next

    End Sub

    Private Sub Closeit() Handles BackgroundWorker1.RunWorkerCompleted
        Close()
    End Sub

End Class