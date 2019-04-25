Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class SendMonet

    Public ID As String
    Public Username As String
    Public UMSNB As Boolean
    Public GBANK As Boolean
    Public RIVER As Boolean
    Public UMSNBBalance As Long
    Public GBANKBalance As Long
    Public RIVERBalance As Long

    Private Sub SendMonet_Load() Handles Me.Load

        'Clearing all fields
        UMSNBRButton.Checked = False
        GBANKRbutton.Checked = False
        RIVERRButton.Checked = False
        BalanceLabel.Text = "0p"
        AmountBox.Value = 0
        DestinationBox.Text = ""



        ID = VibeLogin.LogonID.Text

        UMSNBRButton.Enabled = VibeMainScreen.UMSNBCheck.Checked
        GBANKRbutton.Enabled = VibeMainScreen.GBANKCheck.Checked
        RIVERRButton.Enabled = VibeMainScreen.RIVERCheck.Checked

        UMSNBBalance = VibeMainScreen.UMSNBBLabel.Text.TrimEnd("p")
        GBANKBalance = VibeMainScreen.GBANKBLabel.Text.TrimEnd("p")
        RIVERBalance = VibeMainScreen.RIVERBLabel.Text.TrimEnd("p")



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles AmountBox.ValueChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    ''' <summary>
    ''' Sends the monet if it can.
    ''' </summary>
    ''' <param name="boop">Specifies if this has to be certified or not</param>
    Private Sub SendMonetPlsIBegYou(Optional boop As Boolean = False)


        Dim Destination As String
        Dim Amount As Long
        Dim fromBank As String
        Dim ServerMSG As String

        Amount = 0
        Destination = ""

        Amount = AmountBox.Value
        Destination = DestinationBox.Text

        If Destination.Count = 11 Then

            fromBank = "NO"
            If UMSNBRButton.Checked = True Then fromBank = "UMSNB"
            If GBANKRbutton.Checked = True Then fromBank = "GBANK"
            If RIVERRButton.Checked = True Then fromBank = "RIVER"
            If fromBank = "NO" Then

                MsgBox("Please select an origin", vbCritical, "Couldn't send money")

            Else
                'SM57174\UMSNB33118\UMSNB5000
                ServerMSG = ServerCommand("SM" & ID & "\" & fromBank & Destination & Amount)

                Select Case ServerMSG

                    Case "1"
                        MsgBox("Improperly Coded Vibing Request", vbInformation, "Transfer unsuccessful")

                    Case "E"
                        MsgBox("The Lemon tried to divert the funds, and we stopped him. Unfortunately, this means the transaction was unable to be completed. If this continues to happen please contact CHOPO.", vbInformation, "Transfer unsuccessful")

                    Case "S"
                        If boop = True Then
                            CertificationWindow.ShowDialog()
                            Close()
                        Else
                            MsgBox("Successfully ~vibed~ " & Amount & "p to " & Destination & ".", vbInformation, "Transfer Successful")
                            Close()
                        End If



                End Select

            End If

        Else

            If Destination.StartsWith("DP") Then
                fromBank = "NO"
                If UMSNBRButton.Checked = True Then fromBank = "UMSNB"
                If GBANKRbutton.Checked = True Then fromBank = "GBANK"
                If RIVERRButton.Checked = True Then fromBank = "RIVER"
                If fromBank = "NO" Then

                    MsgBox("Please select an origin", vbCritical, "Couldn't send money")

                Else
                    'SM57174\UMSNB33118\UMSNB5000
                    ServerMSG = ServerCommand("SM" & ID & "\" & fromBank & Destination & Amount)

                    Select Case ServerMSG

                        Case "1"
                            MsgBox("Improperly Coded Vibing Request", vbInformation, "Transfer unsuccessful")

                        Case "E"
                            MsgBox("The Lemon tried to divert the funds, and we stopped him. Unfortunately, this means the transaction was unable to be completed. If this continues to happen please contact CHOPO.", vbInformation, "Transfer unsuccessful")

                        Case "S"

                            If boop = True Then
                                CertificationWindow.ShowDialog()
                                Close()
                            Else
                                MsgBox("Successfully ~vibed~ " & Amount & "p to DiamondPay" & Destination & ".", vbInformation, "Transfer Successful")
                                Close()
                            End If


                    End Select

                End If
            Else

                MsgBox("Destination isn't formatted properly", vbCritical, "Couldn't send money")

            End If



        End If

    End Sub

    Private Sub Button2_Click() Handles Button2.Click

        SendMonetPlsIBegYou(False)

    End Sub

    Private Sub UMSNBRButton_CheckedChanged(sender As Object, e As EventArgs) Handles UMSNBRButton.CheckedChanged
        If UMSNBRButton.Checked = True Then
            BalanceLabel.Text = UMSNBBalance.ToString("N0") & "p"
            AmountBox.Maximum = UMSNBBalance
        End If
    End Sub

    Private Sub GBANKRbutton_CheckedChanged(sender As Object, e As EventArgs) Handles GBANKRbutton.CheckedChanged
        If GBANKRbutton.Checked = True Then
            BalanceLabel.Text = GBANKBalance.ToString("N0") & "p"
            AmountBox.Maximum = GBANKBalance
        End If
    End Sub

    Private Sub RIVERRButton_CheckedChanged(sender As Object, e As EventArgs) Handles RIVERRButton.CheckedChanged
        If RIVERRButton.Checked = True Then
            BalanceLabel.Text = RIVERBalance.ToString("N0") & "p"
            AmountBox.Maximum = RIVERBalance
        End If
    End Sub

    Function ServerCommand(ByVal ClientMSG As String) As String

        Dim tc As TcpClient = New TcpClient()
        Dim ns As NetworkStream
        Dim br As BinaryReader
        Dim bw As BinaryWriter
        Dim ServerMSG As String

        ServerMSG = "E"

        If ClientMSG = "" Then
            ServerCommand = "E"
            Exit Function
        End If

        Try
            tc.Connect(“igtnet-w.ddns.net”, 757)
            Exit Try

        Catch

            MsgBox("Unable to connect to the server.", MsgBoxStyle.Exclamation, "ViBE Error")
            VibeLogin.Show()
            Close()
            ServerCommand = "NOCONNECT"
            Exit Function

        End Try



        If tc.Connected = True Then
            ns = tc.GetStream
            br = New BinaryReader(ns)
            bw = New BinaryWriter(ns)

            bw.Write(ClientMSG)

            Try
                ServerMSG = br.ReadString()
            Catch
                MsgBox("Seems like the server might've crashed! Contact CHOPO!", MsgBoxStyle.Exclamation, "ViBE Error")
                VibeLogin.Show()
                Close()
                ServerCommand = "CRASH"
                Exit Function

            End Try


            tc.Close()

        End If



        ServerCommand = ServerMSG

    End Function

    Private Sub DirectoryButton_Click(sender As Object, e As EventArgs) Handles DirectoryButton.Click
        DirWindow.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendMonetPlsIBegYou(True)

    End Sub
End Class