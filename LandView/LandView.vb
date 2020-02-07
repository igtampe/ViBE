Imports System.ComponentModel
Imports System.IO

Public Class LandView

    Public Structure LandStructure
        Public ID As String
        Public Status As String
        Public Height As Integer
        Public Width As Integer
        Public Area As Integer
        Public Price As String
        Public Owner As String
        Public Comment As String
        Public PricePerBlock As String
    End Structure

    Public Structure AllPlots
        Public Industrial() As LandStructure
        Public UMSMain() As LandStructure
        Public Suburbia() As LandStructure
        Public Urbia() As LandStructure
        Public Paradisus() As LandStructure
        Public Domum() As LandStructure
        Public Laetres() As LandStructure
        Public Synergia() As LandStructure

    End Structure

    Public I As Integer = 0
    Public U As Integer = 0
    Public S As Integer = 0
    Public R As Integer = 0
    Public P As Integer = 0
    Public D As Integer = 0
    Public L As Integer = 0
    Public SY As Integer = 0
    Public status As String

    Public Plot As AllPlots



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Shown

        LandViewDownload.Show()
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False

        BackgroundWorker1.RunWorkerAsync()


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        PictureBox1.Image = My.Resources.Landview

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim N As Integer

        ComboBox2.Items.Clear()
        ComboBox2.Text = ""
        ComboBox2.Enabled = True

        Select Case ComboBox1.SelectedIndex
            Case 0 'industrial
                For N = 0 To I - 1
                    ComboBox2.Items.Add(Plot.Industrial(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "ib.png")
            Case 1 'ums main
                For N = 0 To U - 1
                    ComboBox2.Items.Add(Plot.UMSMain(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "ub.png")
            Case 2 'Suburbia
                For N = 0 To S - 1
                    ComboBox2.Items.Add(Plot.Suburbia(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "sb.png")
            Case 3 'urbia
                For N = 0 To R - 1
                    ComboBox2.Items.Add(Plot.Urbia(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "rb.png")
            Case 4 'paradisus
                For N = 0 To P - 1
                    ComboBox2.Items.Add(Plot.Paradisus(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "pb.png")
            Case 5 'domum
                For N = 0 To D - 1
                    ComboBox2.Items.Add(Plot.Domum(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "db.png")
            Case 6 'laetres
                For N = 0 To L - 1
                    ComboBox2.Items.Add(Plot.Laetres(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "lb.png")
            Case 7 'Synergia
                For N = 0 To SY - 1
                    ComboBox2.Items.Add(Plot.Synergia(N).ID)
                Next
                PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "sy.png")
        End Select

    End Sub

    Public Shared Function SafeImageFromFile(path As String) As Image
        Dim bytes = File.ReadAllBytes(path)
        Using ms As New MemoryStream(bytes)
            Dim img = Image.FromStream(ms)
            Return img
        End Using
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim N As Integer = ComboBox2.SelectedIndex

        Select Case ComboBox1.SelectedIndex
            Case 0 'industrial
                PlotLBL.Text = Plot.Industrial(N).ID
                StatusLBL.Text = Plot.Industrial(N).Status
                OwnerLBL.Text = Plot.Industrial(N).Owner
                SizeLBL.Text = Plot.Industrial(N).Width & " x " & Plot.Industrial(N).Height
                AreaLBL.Text = Plot.Industrial(N).Area & "m^2"
                CommentLBL.Text = Plot.Industrial(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Industrial(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Industrial(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


            Case 1 'ums main
                PlotLBL.Text = Plot.UMSMain(N).ID
                StatusLBL.Text = Plot.UMSMain(N).Status
                OwnerLBL.Text = Plot.UMSMain(N).Owner
                SizeLBL.Text = Plot.UMSMain(N).Width & " x " & Plot.UMSMain(N).Height
                AreaLBL.Text = Plot.UMSMain(N).Area & "m^2"
                CommentLBL.Text = Plot.UMSMain(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.UMSMain(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.UMSMain(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


            Case 2 'Suburbia
                PlotLBL.Text = Plot.Suburbia(N).ID
                StatusLBL.Text = Plot.Suburbia(N).Status
                OwnerLBL.Text = Plot.Suburbia(N).Owner
                SizeLBL.Text = Plot.Suburbia(N).Width & " x " & Plot.Suburbia(N).Height
                AreaLBL.Text = Plot.Suburbia(N).Area & "m^2"
                CommentLBL.Text = Plot.Suburbia(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Suburbia(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Suburbia(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


            Case 3 'urbia
                PlotLBL.Text = Plot.Urbia(N).ID
                StatusLBL.Text = Plot.Urbia(N).Status
                OwnerLBL.Text = Plot.Urbia(N).Owner
                SizeLBL.Text = Plot.Urbia(N).Width & " x " & Plot.Urbia(N).Height
                AreaLBL.Text = Plot.Urbia(N).Area & "m^2"
                CommentLBL.Text = Plot.Urbia(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Urbia(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Urbia(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


            Case 4 'paradisus
                PlotLBL.Text = Plot.Paradisus(N).ID
                StatusLBL.Text = Plot.Paradisus(N).Status
                OwnerLBL.Text = Plot.Paradisus(N).Owner
                SizeLBL.Text = Plot.Paradisus(N).Width & " x " & Plot.Paradisus(N).Height
                AreaLBL.Text = Plot.Paradisus(N).Area & "m^2"
                CommentLBL.Text = Plot.Paradisus(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Paradisus(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Paradisus(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


            Case 5 'domum
                PlotLBL.Text = Plot.Domum(N).ID
                StatusLBL.Text = Plot.Domum(N).Status
                OwnerLBL.Text = Plot.Domum(N).Owner
                SizeLBL.Text = Plot.Domum(N).Width & " x " & Plot.Domum(N).Height
                AreaLBL.Text = Plot.Domum(N).Area & "m^2"
                CommentLBL.Text = Plot.Domum(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Domum(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Domum(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


            Case 6 'laetres
                PlotLBL.Text = Plot.Laetres(N).ID
                StatusLBL.Text = Plot.Laetres(N).Status
                OwnerLBL.Text = Plot.Laetres(N).Owner
                SizeLBL.Text = Plot.Laetres(N).Width & " x " & Plot.Laetres(N).Height
                AreaLBL.Text = Plot.Laetres(N).Area & "m^2"
                CommentLBL.Text = Plot.Laetres(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Laetres(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Laetres(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select

            Case 7 'synergia
                PlotLBL.Text = Plot.Synergia(N).ID
                StatusLBL.Text = Plot.Synergia(N).Status
                OwnerLBL.Text = Plot.Synergia(N).Owner
                SizeLBL.Text = Plot.Synergia(N).Width & " x " & Plot.Synergia(N).Height
                AreaLBL.Text = Plot.Synergia(N).Area & "m^2"
                CommentLBL.Text = Plot.Synergia(N).Comment

                Select Case StatusLBL.Text
                    Case "For Sale"

                        PriceLBL.Text = CInt(Plot.Synergia(N).Price).ToString("N0") & "p"
                        PPBlockLBL.Text = CInt(Plot.Synergia(N).PricePerBlock).ToString("N0") & "p"

                    Case Else

                        PriceLBL.Text = "Ask 3rd Party"
                        PPBlockLBL.Text = "None Set"


                End Select


        End Select

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
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

    Public Shared Sub DownloadToTemp(filetodownload As String)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & filetodownload) Then File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & filetodownload)
        My.Computer.Network.DownloadFile("http://igtnet-w.ddns.net:100/PlotView/" & filetodownload, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & filetodownload)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        LandViewDownload.Label1.Text = "Downloading the most recent Land Data: " & e.ProgressPercentage & "%"
        LandViewDownload.Label2.Text = "Please Wait: " & status
        LandViewDownload.ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Dim currentline() As String
        I = 0
        U = 0
        S = 0
        R = 0
        P = 0
        D = 0
        L = 0
        SY = 0


        FileOpen(1, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "LandDatabase.csv", OpenMode.Input)
        While Not EOF(1)
            currentline = LineInput(1).Split(",")
            If currentline(0).StartsWith("I") Then
                ReDim Preserve Plot.Industrial(I)

                Plot.Industrial(I).ID = currentline(0)
                Plot.Industrial(I).Owner = currentline(1)
                Plot.Industrial(I).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Industrial(I).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Industrial(I).Status = "For Sale"
                    Case 2
                        Plot.Industrial(I).Status = "For Sale by a Third Party"
                End Select

                Plot.Industrial(I).Height = currentline(4)
                Plot.Industrial(I).Width = currentline(5)
                Plot.Industrial(I).PricePerBlock = currentline(6)
                Plot.Industrial(I).Price = currentline(7)

                Plot.Industrial(I).Area = Plot.Industrial(I).Width * Plot.Industrial(I).Height
                I += 1

            ElseIf currentline(0).StartsWith("U") Then
                ReDim Preserve Plot.UMSMain(U)


                Plot.UMSMain(U).ID = currentline(0)
                Plot.UMSMain(U).Owner = currentline(1)
                Plot.UMSMain(U).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.UMSMain(U).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.UMSMain(U).Status = "For Sale"
                    Case 2
                        Plot.UMSMain(U).Status = "For Sale by a Third Party"
                End Select

                Plot.UMSMain(U).Height = currentline(4)
                Plot.UMSMain(U).Width = currentline(5)
                Plot.UMSMain(U).PricePerBlock = currentline(6)
                Plot.UMSMain(U).Price = currentline(7)

                Plot.UMSMain(U).Area = Plot.UMSMain(U).Width * Plot.UMSMain(U).Height
                U += 1

            ElseIf currentline(0).StartsWith("S") Then
                ReDim Preserve Plot.Suburbia(S)


                Plot.Suburbia(S).ID = currentline(0)
                Plot.Suburbia(S).Owner = currentline(1)
                Plot.Suburbia(S).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Suburbia(S).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Suburbia(S).Status = "For Sale"
                    Case 2
                        Plot.Suburbia(S).Status = "For Sale by a Third Party"
                End Select

                Plot.Suburbia(S).Height = currentline(4)
                Plot.Suburbia(S).Width = currentline(5)
                Plot.Suburbia(S).PricePerBlock = currentline(6)
                Plot.Suburbia(S).Price = currentline(7)

                Plot.Suburbia(S).Area = Plot.Suburbia(S).Width * Plot.Suburbia(S).Height
                S += 1

            ElseIf currentline(0).StartsWith("R") Then
                ReDim Preserve Plot.Urbia(R)


                Plot.Urbia(R).ID = currentline(0)
                Plot.Urbia(R).Owner = currentline(1)
                Plot.Urbia(R).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Urbia(R).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Urbia(R).Status = "For Sale"
                    Case 2
                        Plot.Urbia(R).Status = "For Sale by a Third Party"
                End Select

                Plot.Urbia(R).Height = currentline(4)
                Plot.Urbia(R).Width = currentline(5)
                Plot.Urbia(R).PricePerBlock = currentline(6)
                Plot.Urbia(R).Price = currentline(7)

                Plot.Urbia(R).Area = Plot.Urbia(R).Width * Plot.Urbia(R).Height
                R += 1

            ElseIf currentline(0).StartsWith("P") Then
                ReDim Preserve Plot.Paradisus(P)


                Plot.Paradisus(P).ID = currentline(0)
                Plot.Paradisus(P).Owner = currentline(1)
                Plot.Paradisus(P).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Paradisus(P).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Paradisus(P).Status = "For Sale"
                    Case 2
                        Plot.Paradisus(P).Status = "For Sale by a Third Party"
                End Select

                Plot.Paradisus(P).Height = currentline(4)
                Plot.Paradisus(P).Width = currentline(5)
                Plot.Paradisus(P).PricePerBlock = currentline(6)
                Plot.Paradisus(P).Price = currentline(7)

                Plot.Paradisus(P).Area = Plot.Paradisus(P).Width * Plot.Paradisus(P).Height
                P += 1

            ElseIf currentline(0).StartsWith("D") Then
                ReDim Preserve Plot.Domum(D)


                Plot.Domum(D).ID = currentline(0)
                Plot.Domum(D).Owner = currentline(1)
                Plot.Domum(D).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Domum(D).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Domum(D).Status = "For Sale"
                    Case 2
                        Plot.Domum(D).Status = "For Sale by a Third Party"
                End Select

                Plot.Domum(D).Height = currentline(4)
                Plot.Domum(D).Width = currentline(5)
                Plot.Domum(D).PricePerBlock = currentline(6)
                Plot.Domum(D).Price = currentline(7)

                Plot.Domum(D).Area = Plot.Domum(D).Width * Plot.Domum(D).Height
                D += 1

            ElseIf currentline(0).StartsWith("L") Then
                ReDim Preserve Plot.Laetres(L)


                Plot.Laetres(L).ID = currentline(0)
                Plot.Laetres(L).Owner = currentline(1)
                Plot.Laetres(L).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Laetres(L).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Laetres(L).Status = "For Sale"
                    Case 2
                        Plot.Laetres(L).Status = "For Sale by a Third Party"
                End Select

                Plot.Laetres(L).Height = currentline(4)
                Plot.Laetres(L).Width = currentline(5)
                Plot.Laetres(L).PricePerBlock = currentline(6)
                Plot.Laetres(L).Price = currentline(7)

                Plot.Laetres(L).Area = Plot.Laetres(L).Width * Plot.Laetres(L).Height
                L += 1

            ElseIf currentline(0).StartsWith("Y") Then
                ReDim Preserve Plot.Synergia(SY)


                Plot.Synergia(SY).ID = currentline(0)
                Plot.Synergia(SY).Owner = currentline(1)
                Plot.Synergia(SY).Comment = currentline(2)

                Select Case currentline(3)
                    Case 0
                        Plot.Synergia(SY).Status = "Sold or Not For Sale"
                    Case 1
                        Plot.Synergia(SY).Status = "For Sale"
                    Case 2
                        Plot.Synergia(SY).Status = "For Sale by a Third Party"
                End Select

                Plot.Synergia(SY).Height = currentline(4)
                Plot.Synergia(SY).Width = currentline(5)
                Plot.Synergia(SY).PricePerBlock = currentline(6)
                Plot.Synergia(SY).Price = currentline(7)

                Plot.Synergia(SY).Area = Plot.Synergia(SY).Width * Plot.Synergia(SY).Height
                SY += 1
            End If

        End While

        FileClose(1)

        PictureBox1.Image = SafeImageFromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "mm.png")

        LandViewDownload.Close()
        ComboBox1.Enabled = True


    End Sub
End Class
