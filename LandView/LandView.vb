Imports System.IO

''' <summary>The LandView Land Viewing Form for viewing plots of land in a viewer of lands</summary>
Public Class LandView

    '--------------------------------[Variables]--------------------------------

    Public AllRegions As ArrayList

    ''' <summary>Used to report status with the backgroundworker</summary>
    Private status As String

    '--------------------------------[Initialization]--------------------------------

    Private Sub LoadingTime() Handles Me.Shown

        PictureBox1.Image = My.Resources.Landview

        LandViewDownload.Show()
        RegionComboBox.Enabled = False
        PlotComboBox.Enabled = False

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub OKAdiosito() Handles OKBTN.Click
        Close()
    End Sub

    Private Sub SelectedRegionChanged() Handles RegionComboBox.SelectedIndexChanged

        PlotComboBox.Items.Clear()
        PlotComboBox.Text = ""
        PlotComboBox.Enabled = True

        Dim CurrentRegion As Region = TryCast(AllRegions(RegionComboBox.SelectedIndex), Region)
        PictureBox1.Image = CurrentRegion.Picture

        For Each Plot As Plot In CurrentRegion.Plots
            PlotComboBox.Items.Add(Plot.ID)
        Next

    End Sub

    Private Sub PlotChanged() Handles PlotComboBox.SelectedIndexChanged

        Dim N As Integer = PlotComboBox.SelectedIndex

        Dim CurrentRegion As Region = TryCast(AllRegions(RegionComboBox.SelectedIndex), Region)
        Dim CurrentPlot As Plot = TryCast(CurrentRegion.Plots(PlotComboBox.SelectedIndex), Plot)

        PlotLBL.Text = CurrentPlot.ID
        StatusLBL.Text = CurrentPlot.Status
        OwnerLBL.Text = CurrentPlot.Owner
        SizeLBL.Text = CurrentPlot.Width & " x " & CurrentPlot.Height
        AreaLBL.Text = CurrentPlot.Area & "m^2"
        CommentLBL.Text = CurrentPlot.Comment

        Select Case StatusLBL.Text
            Case "For Sale"
                PriceLBL.Text = CInt(CurrentPlot.Price).ToString("N0") & "p"
                PPBlockLBL.Text = CInt(CurrentPlot.PricePerBlock).ToString("N0") & "p"
            Case Else
                PriceLBL.Text = "Ask 3rd Party"
                PPBlockLBL.Text = "None Set"
        End Select

    End Sub

    '--------------------------------[Background Worker]--------------------------------

    ''' <summary>Gets all plots from the server</summary>
    Private Sub GetAllPlots() Handles BackgroundWorker1.DoWork
        status = "Downloading Land Database"
        BackgroundWorker1.ReportProgress(0)

        DownloadToTemp("LandDatabase.csv")
        BackgroundWorker1.ReportProgress(10)

        status = "Downloading Domum Map"
        DownloadToTemp("db.png")
        BackgroundWorker1.ReportProgress(20)

        status = "Downloading Industrial Sector Map"
        DownloadToTemp("ib.png")
        BackgroundWorker1.ReportProgress(30)

        status = "Downloading Laetres Map"
        DownloadToTemp("lb.png")
        BackgroundWorker1.ReportProgress(40)

        status = "Downloading Overview Map"
        DownloadToTemp("mm.png")
        BackgroundWorker1.ReportProgress(50)

        status = "Downloading Paradisus Map"
        DownloadToTemp("pb.png")
        BackgroundWorker1.ReportProgress(60)

        status = "Downloading Urbia Map"
        DownloadToTemp("rb.png")
        BackgroundWorker1.ReportProgress(70)

        status = "Downloading Suburbia Map"
        DownloadToTemp("sb.png")
        BackgroundWorker1.ReportProgress(80)

        status = "Downloading Newpond Map"
        DownloadToTemp("ub.png")
        BackgroundWorker1.ReportProgress(90)

        status = "Downloading Synergia Map"
        DownloadToTemp("sy.png")
        BackgroundWorker1.ReportProgress(100)

    End Sub

    Private Sub UpdateProgress(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        LandViewDownload.Label1.Text = "Downloading the most recent Land Data: " & e.ProgressPercentage & "%"
        LandViewDownload.Label2.Text = "Please Wait: " & status
        LandViewDownload.ProgressBar1.Value = e.ProgressPercentage
    End Sub

    ''' <summary>Adds all plots</summary>
    Private Sub DoneGettingPlots() Handles BackgroundWorker1.RunWorkerCompleted

        FileOpen(1, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "LandDatabase.csv", OpenMode.Input)

        AllRegions = New ArrayList From {
          New Region("Industrial Sector", "I", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ib.png")),
          New Region("Newond", "U", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ub.png")),
          New Region("Suburbia", "S", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\sb.png")),
          New Region("Uburbia", "R", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\rb.png")),
          New Region("Paradisus", "P", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\pb.png")),
          New Region("Domum", "D", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\db.png")),
          New Region("Laertes", "L", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\lb.png")),
          New Region("Synergia", "Y", SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\sy.png"))
        }

        While Not EOF(1)
            Dim currentline As String() = LineInput(1).Split(",")

            'Set up plot info
            Dim ID As String = currentline(0)
            Dim Owner As String = currentline(1)
            Dim Comment As String = currentline(2)
            Dim Status As String

            Select Case currentline(3)
                Case 0
                    Status = "Sold or Not For Sale"
                Case 1
                    Status = "For Sale"
                Case 2
                    Status = "For Sale by a Third Party"
                Case Else
                    Status = "Unknown"
            End Select

            Dim Height As Integer = currentline(4)
            Dim Width As Integer = currentline(5)
            Dim PPB As String = currentline(6)
            Dim Price As String = currentline(7)

            Dim Area As Integer = Width * Height

            'create the plot
            Dim NewPlot As Plot = New Plot(ID, Status, Height, Width, Area, Price, Owner, PPB)


            For Each Region As Region In AllRegions
                If currentline(0).StartsWith(Region.Prefix) Then
                    Region.Plots.Add(NewPlot)
                    Exit For
                End If
            Next

        End While

        FileClose(1)

        PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "mm.png")

        LandViewDownload.Close()
        RegionComboBox.Enabled = True

    End Sub

    ''' <summary>Downloads the specified file from the plotview directory in the igtnet to the temporary directory</summary>
    Public Shared Sub DownloadToTemp(filetodownload As String)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & filetodownload) Then File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & filetodownload)
        My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/PlotView/" & filetodownload, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & filetodownload)
    End Sub

    ''' <summary>SafeImageFromFile loads an image safely, rather than wrecklessly</summary>
    Private Shared Function SafeImageFromFile(path As String) As Image

        'Get the bytes from a file
        Dim bytes = File.ReadAllBytes(path)

        'Using a new memory stream,
        Using ms As New MemoryStream(bytes)

            'Get the image from the stream.
            Dim img = Image.FromStream(ms)
            Return img

        End Using
    End Function


End Class
