''' <summary>Holds the ViBE Certification Window. When shown, it'll certify the transaction it was created with.</summary>
Public Class CertificationWindow

    '--------------------------------[Variables]--------------------------------
    Public Servermsg As String
    Public Certify As String

    '--------------------------------[Initialization]--------------------------------

    ''' <summary> Creates a new Certification Window </summary>
    ''' <param name="BankImage">The image u want to display on top</param>
    ''' <param name="Transaction">The transaction u want to certify</param>
    Public Sub New(BankImage As Image, Transaction As String)
        InitializeComponent()

        'Setting a few things
        AnimatedPictureBox.Image = My.Resources.VibeLoad
        Label1.Text = "Certifying..."
        Label2.Text = "Your payment is being certified..."

        ClickOKtoOK.Visible = False

        'Set the text:
        Certify = Transaction
        Label3.Visible = False
        Label3.Text = Certify

        'Set the image
        BankPictureBox.Image = BankImage

    End Sub

    Private Sub StartUp() Handles Me.Shown
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    '--------------------------------[The One Button]--------------------------------

    ''' <summary>Click OK to OK</summary>
    Private Sub ClickOKtoOK_Click() Handles ClickOKtoOK.Click
        Close()
    End Sub

    '--------------------------------[Background Workers]--------------------------------

    ''' <summary>Sends out the certification call</summary>
    Private Sub CertifyWorker() Handles BackgroundWorker1.DoWork
        Servermsg = CoreCommands.Certify(Certify)
    End Sub

    ''' <summary>Process the return from the server</summary>
    Private Sub Woopdiedooitsdone() Handles BackgroundWorker1.RunWorkerCompleted

        Select Case Servermsg
            Case "S"
                'Payment completed successfully
                Label1.Text = "Your payment was certified"
                Label2.Text = "Your payment was successfully certified:"
                Label3.Visible = True
                ClickOKtoOK.Visible = True
                AnimatedPictureBox.Image = My.Resources.p

                WaitForRender.RunWorkerAsync()

            Case Else
                'woopsie no
                MsgBox("The Lemon tried to certify a transaction at the same time you did, so we had to stop the certification system. Don't worry, it should work now, but if it doesn't please contact CHOPO.", MsgBoxStyle.Critical, "Please Help")
                Close()
        End Select

    End Sub

    ''' <summary>Wait for the thing to finish rendering after the changes</summary>
    Private Sub WaitForRender_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WaitForRender.DoWork
        Threading.Thread.Sleep(50)
    End Sub

    ''' <summary>Take a screenshot and save it to the clipboard, so that a user can show their certification easily</summary>
    Private Sub OKTakeTheScreenshotpls() Handles WaitForRender.RunWorkerCompleted
        ScreenCamera.TakeScreenshot(Width, Height, Location.X, Location.Y, Size)
    End Sub

End Class