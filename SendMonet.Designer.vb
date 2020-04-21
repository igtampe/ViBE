<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SendMonet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendMonet))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RIVERRButton = New System.Windows.Forms.RadioButton()
        Me.GBANKRbutton = New System.Windows.Forms.RadioButton()
        Me.UMSNBRButton = New System.Windows.Forms.RadioButton()
        Me.AmountBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DestinationBox = New System.Windows.Forms.TextBox()
        Me.CancelBTN = New System.Windows.Forms.Button()
        Me.SendWOCertBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DirectoryButton = New System.Windows.Forms.Button()
        Me.SendWCertBTN = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AmountBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RIVERRButton)
        Me.GroupBox1.Controls.Add(Me.GBANKRbutton)
        Me.GroupBox1.Controls.Add(Me.UMSNBRButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 49)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bank"
        '
        'RIVERRButton
        '
        Me.RIVERRButton.AutoSize = True
        Me.RIVERRButton.Location = New System.Drawing.Point(144, 19)
        Me.RIVERRButton.Name = "RIVERRButton"
        Me.RIVERRButton.Size = New System.Drawing.Size(58, 17)
        Me.RIVERRButton.TabIndex = 0
        Me.RIVERRButton.Text = "RIVER"
        Me.RIVERRButton.UseVisualStyleBackColor = True
        '
        'GBANKRbutton
        '
        Me.GBANKRbutton.AutoSize = True
        Me.GBANKRbutton.Location = New System.Drawing.Point(76, 19)
        Me.GBANKRbutton.Name = "GBANKRbutton"
        Me.GBANKRbutton.Size = New System.Drawing.Size(62, 17)
        Me.GBANKRbutton.TabIndex = 0
        Me.GBANKRbutton.Text = "GBANK"
        Me.GBANKRbutton.UseVisualStyleBackColor = True
        '
        'UMSNBRButton
        '
        Me.UMSNBRButton.AutoSize = True
        Me.UMSNBRButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.UMSNBRButton.Location = New System.Drawing.Point(6, 19)
        Me.UMSNBRButton.Name = "UMSNBRButton"
        Me.UMSNBRButton.Size = New System.Drawing.Size(64, 17)
        Me.UMSNBRButton.TabIndex = 0
        Me.UMSNBRButton.Text = "UMSNB"
        Me.UMSNBRButton.UseVisualStyleBackColor = True
        '
        'AmountBox
        '
        Me.AmountBox.Location = New System.Drawing.Point(78, 104)
        Me.AmountBox.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.AmountBox.Name = "AmountBox"
        Me.AmountBox.Size = New System.Drawing.Size(144, 20)
        Me.AmountBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Money"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Funds"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(75, 77)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(19, 13)
        Me.BalanceLabel.TabIndex = 3
        Me.BalanceLabel.Text = "0p"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Destination"
        '
        'DestinationBox
        '
        Me.DestinationBox.Location = New System.Drawing.Point(78, 133)
        Me.DestinationBox.Name = "DestinationBox"
        Me.DestinationBox.Size = New System.Drawing.Size(136, 20)
        Me.DestinationBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DestinationBox, "Remember the format is ID\BANK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For instance: 57174\UMSNB")
        '
        'CancelBTN
        '
        Me.CancelBTN.Location = New System.Drawing.Point(120, 198)
        Me.CancelBTN.Name = "CancelBTN"
        Me.CancelBTN.Size = New System.Drawing.Size(102, 23)
        Me.CancelBTN.TabIndex = 6
        Me.CancelBTN.Text = "Cancel"
        Me.CancelBTN.UseVisualStyleBackColor = True
        '
        'SendWOCertBTN
        '
        Me.SendWOCertBTN.Location = New System.Drawing.Point(12, 198)
        Me.SendWOCertBTN.Name = "SendWOCertBTN"
        Me.SendWOCertBTN.Size = New System.Drawing.Size(102, 23)
        Me.SendWOCertBTN.TabIndex = 6
        Me.SendWOCertBTN.Text = "Send"
        Me.SendWOCertBTN.UseVisualStyleBackColor = True
        '
        'DirectoryButton
        '
        Me.DirectoryButton.Font = New System.Drawing.Font("Wingdings 2", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.DirectoryButton.Location = New System.Drawing.Point(202, 133)
        Me.DirectoryButton.Name = "DirectoryButton"
        Me.DirectoryButton.Size = New System.Drawing.Size(20, 19)
        Me.DirectoryButton.TabIndex = 7
        Me.DirectoryButton.Text = ","
        Me.DirectoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DirectoryButton.UseVisualStyleBackColor = True
        '
        'SendWCertBTN
        '
        Me.SendWCertBTN.Location = New System.Drawing.Point(12, 169)
        Me.SendWCertBTN.Name = "SendWCertBTN"
        Me.SendWCertBTN.Size = New System.Drawing.Size(210, 23)
        Me.SendWCertBTN.TabIndex = 6
        Me.SendWCertBTN.Text = "Send with certification"
        Me.SendWCertBTN.UseVisualStyleBackColor = True
        '
        'SendMonet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 233)
        Me.Controls.Add(Me.DirectoryButton)
        Me.Controls.Add(Me.SendWCertBTN)
        Me.Controls.Add(Me.SendWOCertBTN)
        Me.Controls.Add(Me.CancelBTN)
        Me.Controls.Add(Me.DestinationBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BalanceLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AmountBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SendMonet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Money"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AmountBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RIVERRButton As RadioButton
    Friend WithEvents GBANKRbutton As RadioButton
    Friend WithEvents UMSNBRButton As RadioButton
    Friend WithEvents AmountBox As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DestinationBox As TextBox
    Friend WithEvents CancelBTN As Button
    Friend WithEvents SendWOCertBTN As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DirectoryButton As Button
    Friend WithEvents SendWCertBTN As Button
End Class
