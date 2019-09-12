
Imports System.ComponentModel
Imports System.IO

Public Class EZTaxMain

    Public Income As Long
    Public IRTI As Long

    Public EI As Long
    Public TaxBracket As String
    Public Tax As Long
    Public Total As Long
    Public InitializationResult
    Public ID As String
    Public IWStatus As String
    Public Category As Integer
    Public Shared IncomeregistryArray() As IncomeRegistry
    Public Shared SearchIncomeArray() As IncomeRegistry

    Public UpdatedTotal As Long
    Public UpdatedTaxDue As Long
    Public UpdatedTaxBracket As String

    Public MoveWarning As Boolean

    Public SearchMode As Boolean



    Public Structure IncomeRegistry

        Public ItemName As String
        Public ItemIncome As Long
        Public RealItemLocation As Integer

    End Structure


    Private Sub AboutButton_click(sender As Object, e As EventArgs) Handles Aboutbutton.Click
        EZTaxWizard.ShowDialog()
        If EZTaxWizard.ItemName = "~CANCEL~" Then
            'uh do nothing
        Else
            ItemNameTXB.Text = EZTaxWizard.ItemName
            ItemIncomeTXB.Text = EZTaxWizard.ItemIncome
            AddItemButton_Click()
        End If

    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Me.Close()
    End Sub

    Private Sub AddItemButton_Click() Handles AddItemButton.Click

        If CheckForInput() = False Then
            MsgBox("Please specify appropriate inputs", MsgBoxStyle.Exclamation, "EzTax")
            Exit Sub
        End If

        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False

        Dim NewItemname As String = ItemNameTXB.Text
        Dim NewItemIncome As Long = ItemIncomeTXB.Text
        Dim NewItemIndex As Integer

        Try

            NewItemIndex = IncomeregistryArray.Count

        Catch

        End Try

        Debug.Write(NewItemIndex.ToString)

        ReDim Preserve IncomeregistryArray(NewItemIndex)
        IncomeregistryArray(NewItemIndex).ItemName = NewItemname
        IncomeregistryArray(NewItemIndex).ItemIncome = NewItemIncome

        TextBox2.Text = ""
        PopulateListview()

        ItemNameTXB.Text = ""
        ItemIncomeTXB.Text = ""

    End Sub

    Private Sub ModifyItemButton_Click(sender As Object, e As EventArgs) Handles ModifyItemButton.Click
        If CheckForInput() = False Then
            MsgBox("Please specify appropriate inputs", MsgBoxStyle.Exclamation, "EzTax")
            Exit Sub
        End If

        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False


        Dim NewItemname As String = ItemNameTXB.Text
        Dim NewItemIncome As Long = ItemIncomeTXB.Text
        Dim NewItemIndex As Integer

        Try
            NewItemIndex = ListView1.SelectedIndices(0)
        Catch
        End Try

        If SearchMode = True Then
            NewItemIndex = SearchIncomeArray(NewItemIndex + 1).RealItemLocation
        End If

        IncomeregistryArray(NewItemIndex).ItemName = NewItemname
        IncomeregistryArray(NewItemIndex).ItemIncome = NewItemIncome

        RePopulateListView()

        ItemNameTXB.Text = ""
        ItemIncomeTXB.Text = ""


    End Sub

    Private Sub RemoveItemButton_Click(sender As Object, e As EventArgs) Handles RemoveItemButton.Click
        If CheckForInput() = False Then
            MsgBox("Please specify appropriate inputs", MsgBoxStyle.Exclamation, "EzTax")
            Exit Sub
        End If

        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False


        Dim NewItemIndex As Integer

        Try
            NewItemIndex = ListView1.SelectedIndices(0)
        Catch
        End Try

        If SearchMode = True Then
            NewItemIndex = SearchIncomeArray(NewItemIndex + 1).RealItemLocation
        End If

        Dim I As Integer

        For I = NewItemIndex To IncomeregistryArray.Count - 2
            IncomeregistryArray(I) = IncomeregistryArray(I + 1)
        Next

        ReDim Preserve IncomeregistryArray(IncomeregistryArray.Count - 2)

        RePopulateListView()

        ItemNameTXB.Text = ""
        ItemIncomeTXB.Text = ""

    End Sub

    Private Sub EZTaxMain_Load(sender As Object, e As EventArgs) Handles Me.Shown
        EZTaxSplash.Show()
        SearchMode = False
        IncomeregistryArray = Nothing
        ID = VibeLogin.LogonID.Text
        Category = VibeMainScreen.Category
        MoveWarning = False
        InitialBW.RunWorkerAsync()
        ModifyItemButton.Enabled = False
        RemoveItemButton.Enabled = False


    End Sub

    Private Sub InitialBW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles InitialBW.DoWork

        Threading.Thread.Sleep(250)

        InitializationResult = 0

        'Try and access the IncomeRegistry


        IWStatus = "Opening File..."
        InitialBW.ReportProgress(1)


        Try

            If File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & ID & ".IncomeRegistry.csv") Then
                'Flag that we moved stuff
                MoveWarning = True

                'if the directory does not exist, make it
                If Not Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX") Then Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX")

                'move the coso
                File.Move(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\" & ID & ".IncomeRegistry.csv", My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & ID & ".IncomeRegistry.csv")
            End If
            'Open the file
            FileOpen(1, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & ID & ".IncomeRegistry.csv", OpenMode.Input)
        Catch EE As Exception
            Console.Write(EE.ToString)
            InitializationResult = 2
            GoTo LabelNoDownload
        End Try

        IWStatus = "Setting up Listview..."
        InitialBW.ReportProgress(2)

        Dim I As Integer = 0
        Dim RecordsAdded As Boolean
        Dim currentline() As String
        RecordsAdded = False

        While Not EOF(1)
            IWStatus = "Processing Record " & I
            InitialBW.ReportProgress(I)

            RecordsAdded = True

            ReDim Preserve IncomeregistryArray(I)

            currentline = LineInput(1).Split(",")
            IncomeregistryArray(I).ItemName = currentline(0)
            IncomeregistryArray(I).ItemIncome = currentline(1)


            I = I + 1
            Threading.Thread.Sleep(5)
        End While
        FileClose(1)

LabelNoDownload:

        'Retrieve Income
        Dim Servermsg As String
        Dim Incomes() As String

        IWStatus = "Retrieving Income " & I
        InitialBW.ReportProgress(I)


        Servermsg = ServerCommand.ServerCommand("EZTINF" & ID)
        If Servermsg = "E" Then
            MsgBox("There has been a serverside error. Please Contact CHOPO.", vbCritical, "EzTax cannot continue")
            Close()
        End If
        Incomes = Servermsg.Split(",")
        Income = Incomes(0)
        EI = Incomes(1)

        Total = Income + EI

        Tax = TaxCalc(Total, Category)
        TaxBracket = TaxBracketCalc(Total, Category)

    End Sub

    Private Sub InitialBW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles InitialBW.RunWorkerCompleted

        IncomeLabel.Text = Income.ToString("N0") & "p"
        UpdatedLabel.Text = "0p"
        EILabel.Text = EI.ToString("N0") & "p"
        TotalLabel.Text = Total.ToString("N0") & "p"
        TaxBracketLabel.Text = TaxBracket
        TaxDueLabel.Text = Tax.ToString("N0") & "p"

        If MoveWarning = True Then
            MsgBox("Your Income Registry file was successfully moved to the EzTAX Folder", MsgBoxStyle.Information, "EzTAX")
            MoveWarning = False
        End If


        Select Case InitializationResult

            Case 0

                Try

                    Dim AAAAAAAAAAAAAA As Integer = IncomeregistryArray.Count

                Catch

                    Exit Select

                End Try

                Call PopulateListview()


            Case 1

                MsgBox("It appears you no Income Registry file. A new one will be created when you add items", vbInformation, "No Income Registry File")

            Case 2

                MsgBox("It appears you no Income Registry file. A new one will be created when you add items", vbInformation, "No Income Registry File")

        End Select





        'Plop everything into the form


        EZTaxSplash.Close()

    End Sub

    Private Sub InitialBW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles InitialBW.ProgressChanged
        EZTaxSplash.StatusLabel.Text = IWStatus
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

        Dim Selectedindex As Integer

        Try
            Selectedindex = ListView1.SelectedIndices(0)
        Catch
            Exit Sub
        End Try

        Select Case SearchMode
            Case True
                Try
                    ItemNameTXB.Text = SearchIncomeArray(ListView1.SelectedIndices(0) + 1).ItemName
                    ItemIncomeTXB.Text = SearchIncomeArray(ListView1.SelectedIndices(0) + 1).ItemIncome
                Catch
                End Try
            Case False
                Try
                    ItemNameTXB.Text = IncomeregistryArray(ListView1.SelectedIndices(0)).ItemName
                    ItemIncomeTXB.Text = IncomeregistryArray(ListView1.SelectedIndices(0)).ItemIncome
                Catch
                End Try
        End Select

        ModifyItemButton.Enabled = True
        RemoveItemButton.Enabled = True
    End Sub


    Private Sub EZTaxMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Me.Size = (New Drawing.Size(525, 390))

        Dim X As Integer = 525
        Dim y As Integer = 390

        While Not X < 15

            X = X - 10
            If Not y < 15 Then y = y - 10
            Me.Size = (New Drawing.Size(X, y))
            Threading.Thread.Sleep(3)

        End While


    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click

        Dim Servermsg As String
        Servermsg = ServerCommand.ServerCommand("EZTUPD" & ID & (UpdatedTotal - EI))

        Select Case Servermsg
            Case "E"
                MsgBox("Could not update income", vbCritical, "EzTax")
            Case "S"
                MsgBox("Updated income succesfully", vbInformation, "EzTax")

                Income = IRTI
                Tax = UpdatedTaxDue
                TaxBracket = UpdatedTaxBracket
                Total = UpdatedTotal

                IncomeLabel.Text = Income.ToString("N0") & "p"
                TotalLabel.Text = Total.ToString("N0") & "p"
                TaxBracketLabel.Text = TaxBracket
                TaxDueLabel.Text = Tax.ToString("N0") & "p"
        End Select

    End Sub
    ''' <summary>
    ''' Populate the listview
    ''' </summary>
    ''' <param name="SearchItem"> find this item or items containing this </param>
    Sub PopulateListview(Optional ByVal SearchItem As String = "")


        Dim I As Integer
        Dim Hits As Integer
        IRTI = 0
        Hits = 0
        ListView1.Clear()
        ListView1.View = View.Details
        ListView1.Columns.Add("Name")
        ListView1.Columns.Item(0).Width = 340
        ListView1.Columns.Add("Income")
        ListView1.Columns.Item(1).Width = 150
        ListView1.MultiSelect = False
        ListView1.FullRowSelect = True
        ListView1.HideSelection = False

        FileOpen(2, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\EzTAX\" & ID & ".IncomeRegistry.csv", OpenMode.Output)

        For I = 0 To IncomeregistryArray.Count - 1

            Dim CLVI As ListViewItem
            EZTaxSplash.StatusLabel.Text = "Adding Record " & I & " out of " & IncomeregistryArray.Count - 1 & "To Listbox"

            If Not SearchItem = "" Then
                If IncomeregistryArray(I).ItemName.ToLower.Contains(SearchItem.ToLower) Then
                    CLVI = New ListViewItem With {
                .Text = IncomeregistryArray(I).ItemName
            }
                    CLVI.SubItems.Add(IncomeregistryArray(I).ItemIncome.ToString("N0") & "p")
                    ListView1.Items.Add(CLVI)
                    Hits = Hits + 1
                    HitsCounter(Hits)

                    ReDim Preserve SearchIncomeArray(Hits)
                    SearchIncomeArray(Hits).ItemName = IncomeregistryArray(I).ItemName
                    SearchIncomeArray(Hits).ItemIncome = IncomeregistryArray(I).ItemIncome
                    SearchIncomeArray(Hits).RealItemLocation = I


                End If
            Else
                CLVI = New ListViewItem With {
                .Text = IncomeregistryArray(I).ItemName
            }
                CLVI.SubItems.Add(IncomeregistryArray(I).ItemIncome.ToString("N0") & "p")
                ListView1.Items.Add(CLVI)
                Hits = Hits + 1
                HitsCounter(Hits)
            End If


            PrintLine(2, IncomeregistryArray(I).ItemName & "," & IncomeregistryArray(I).ItemIncome)

            IRTI = IRTI + IncomeregistryArray(I).ItemIncome

        Next

        FileClose(2)

        UpdatedLabel.Text = IRTI.ToString("N0") & "p"
        UpdatedTotal = IRTI + EI

        UpdatedTaxDue = TaxCalc(UpdatedTotal, Category)
        UpdatedTaxBracket = TaxBracketCalc(UpdatedTotal, Category)

        UpdatedTotalLabel.Text = UpdatedTotal.ToString("N0") & "p"
        UpdatedTaxBracketLabel.Text = UpdatedTaxBracket
        UpdatedTaxDueLabel.Text = UpdatedTaxDue.ToString("N0") & "p"
        If Hits = 0 Then HitsCounter(0)

    End Sub

    Sub HitsCounter(hits As Integer)
        If hits = 1 Then
            HitLabel.Text = "1 entry"
        Else
            HitLabel.Text = hits & " entries"
        End If
    End Sub

    Function CheckForInput() As Boolean

        CheckForInput = True

        If ItemIncomeTXB.Text.Trim(" ") = "" Then
            CheckForInput = False
        End If

        If ItemNameTXB.Text.Trim(" ") = "" Then
            CheckForInput = False
        End If

        Try

            Dim C As Long
            C = ItemIncomeTXB.Text

        Catch ex As Exception

            CheckForInput = False

        End Try


    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        RePopulateListView()
    End Sub

    Sub RePopulateListView()
        ItemIncomeTXB.Text = ""
        ItemNameTXB.Text = ""

        If Not TextBox2.Text = "" Then
            PopulateListview(TextBox2.Text)
            SearchMode = True
        Else
            PopulateListview()
            SearchMode = False
        End If
    End Sub

    Function TaxBracketCalc(Total As Long, Category As Integer) As String
        Dim Taxb As Single
        Select Case Category
            Case 0
                'Personal User
                Select Case Total
                    Case > 5000000
                        Taxb = 0.05
                        TaxBracketCalc = "Personal Taxed (5%)"
                        Exit Select
                    Case Else
                        TaxBracketCalc = "Untaxed (0%)"
                        Taxb = 0.00
                        Exit Select
                End Select
            Case 1

                Select Case Total

                    Case > 5000000
                        Taxb = 0.03
                        TaxBracketCalc = "Corporate Taxed (3%)"
                        Exit Select
                    Case Else
                        TaxBracketCalc = "Untaxed (0%)"
                        Taxb = 0.05
                        Exit Select
                End Select

        End Select

    End Function

    Function TaxCalc(Total As Long, Category As Integer) As Long
        Dim Taxb As Single
        Select Case Category
            Case 0
                'Personal User
                Select Case Total
                    Case > 5000000
                        Taxb = 0.05
                        Exit Select
                    Case Else
                        Taxb = 0.00
                        Exit Select
                End Select
                TaxCalc = Total * Taxb
            Case 1
                'Corporate User
                Select Case Total
                    Case > 5000000
                        Taxb = 0.03
                        Exit Select
                    Case Else
                        Taxb = 0
                        Exit Select
                End Select
                TaxCalc = (Total) * Taxb
        End Select
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
        EzTaxAbout.ShowDialog()
        Show()
    End Sub
End Class