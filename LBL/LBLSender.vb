
''' <summary>Uses the LBL protocal to send a file to the server</summary>
Public Class LBLSender

    '--------------------------------[Variables]--------------------------------

    Private ReadOnly FileToSend As String
    Private CurrentPercentage As Double = 0
    Private CurrentHeader As String = "Initializing File Transfer"
    Private CurrentFooter As String = "Reading File "
    Private WebLocation As String = ""

    '--------------------------------[Initialization]--------------------------------

    Public Sub New(File As String)
        InitializeComponent()
        FileToSend = File
    End Sub

    Private Sub LBLSender_Load() Handles MyBase.Load
        setprogress(0)
        Quit.Enabled = False
        Text = "Sending file " & FileToSend
        Header.Text = "Initializing File Transfer"
        Footer.Text = "Reading File " & FileToSend
        LBLBackgroundSender.RunWorkerAsync()
    End Sub

    '--------------------------------[Main Background Worker]--------------------------------

    Private Sub LBLActualSender() Handles LBLBackgroundSender.DoWork

        'Open and read all the contents of the file. Add them to an arraylist
        FileOpen(1, FileToSend, OpenMode.Input)
        Dim AllLines As ArrayList = New ArrayList
        While Not EOF(1)
            AllLines.Add(LineInput(1))
        End While
        FileClose(1)

        'Initialize the transfer
        CurrentFooter = "Initializing LBL Transfer"
        LBLBackgroundSender.ReportProgress(0)
        Dim Sender As LBLClientTransfer = New LBLClientTransfer(FileToSend.Split("\")(FileToSend.Split("\").Count - 1))
        Dim X As Double = 0
        Dim MeasuringTimeCoso As Stopwatch = New Stopwatch()
        Dim TimeLeft As String = ""
        Dim SendMSG As String = ""

        'Send the coito
        CurrentHeader = "Uploading File"
        For Each Line As String In AllLines
            CurrentPercentage = X / AllLines.Count
            CurrentFooter = "Sending line " & X & " of " & AllLines.Count & ", " & Math.Floor(CurrentPercentage * 100) & "%" & TimeLeft

            LBLBackgroundSender.ReportProgress(X)

            MeasuringTimeCoso.Start()
            SendMSG = Sender.SendLine(Line)
            MeasuringTimeCoso.Stop()
            If SendMSG = "CLOSED" Then Close()
            TimeLeft = ", about " & CInt((MeasuringTimeCoso.ElapsedMilliseconds / 1000.0) * (AllLines.Count - X - 1)) & "s to go."
            MeasuringTimeCoso.Reset()
            X += 1
        Next

        'Close the cosito
        CurrentHeader = "Finalizing transfer"
        CurrentFooter = "Please wait..."
        CurrentPercentage = 1
        LBLBackgroundSender.ReportProgress(100)
        WebLocation = Sender.Close()
    End Sub

    Private Sub LBLReportProgress() Handles LBLBackgroundSender.ProgressChanged
        Header.Text = CurrentHeader
        Footer.Text = CurrentFooter
        setprogress(CurrentPercentage)
    End Sub

    Private Sub LBLDone() Handles LBLBackgroundSender.RunWorkerCompleted
        Header.Text = "File Transfer Complete!"
        Footer.Text = "You can close this window now."
        PictureBox1.Image = My.Resources.EzTaxApproved
        Quit.Enabled = True
    End Sub

    Private Sub setprogress(progress As Double)
        ProgressBar.Width = 500 * progress
    End Sub

    '--------------------------------[The one button]--------------------------------

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Close()
    End Sub

    '--------------------------------[Window Moving Functions]--------------------------------

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
            SetDesktopLocation(DX + MousePosition.X, DY + MousePosition.Y)
        End If
    End Sub

    Public Sub OktimeToStop() Handles EzTaxTopLabel.MouseUp
        WindowIsmoving = False
    End Sub
End Class