<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferMonet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferMonet))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RIVERRButtonFROM = New System.Windows.Forms.RadioButton()
        Me.GBANKRbuttonFROM = New System.Windows.Forms.RadioButton()
        Me.UMSNBRButtonFROM = New System.Windows.Forms.RadioButton()
        Me.FromBalance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RIVERRButtonTO = New System.Windows.Forms.RadioButton()
        Me.GBANKRButtonTO = New System.Windows.Forms.RadioButton()
        Me.UMSNBRButtonTO = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TransferAmountBox = New System.Windows.Forms.NumericUpDown()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TransferAmountBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RIVERRButtonFROM)
        Me.GroupBox1.Controls.Add(Me.GBANKRbuttonFROM)
        Me.GroupBox1.Controls.Add(Me.UMSNBRButtonFROM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 49)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From"
        '
        'RIVERRButtonFROM
        '
        Me.RIVERRButtonFROM.AutoSize = True
        Me.RIVERRButtonFROM.Location = New System.Drawing.Point(144, 19)
        Me.RIVERRButtonFROM.Name = "RIVERRButtonFROM"
        Me.RIVERRButtonFROM.Size = New System.Drawing.Size(58, 17)
        Me.RIVERRButtonFROM.TabIndex = 0
        Me.RIVERRButtonFROM.Text = "RIVER"
        Me.RIVERRButtonFROM.UseVisualStyleBackColor = True
        '
        'GBANKRbuttonFROM
        '
        Me.GBANKRbuttonFROM.AutoSize = True
        Me.GBANKRbuttonFROM.Location = New System.Drawing.Point(76, 19)
        Me.GBANKRbuttonFROM.Name = "GBANKRbuttonFROM"
        Me.GBANKRbuttonFROM.Size = New System.Drawing.Size(62, 17)
        Me.GBANKRbuttonFROM.TabIndex = 0
        Me.GBANKRbuttonFROM.Text = "GBANK"
        Me.GBANKRbuttonFROM.UseVisualStyleBackColor = True
        '
        'UMSNBRButtonFROM
        '
        Me.UMSNBRButtonFROM.AutoSize = True
        Me.UMSNBRButtonFROM.Cursor = System.Windows.Forms.Cursors.Default
        Me.UMSNBRButtonFROM.Location = New System.Drawing.Point(6, 19)
        Me.UMSNBRButtonFROM.Name = "UMSNBRButtonFROM"
        Me.UMSNBRButtonFROM.Size = New System.Drawing.Size(64, 17)
        Me.UMSNBRButtonFROM.TabIndex = 0
        Me.UMSNBRButtonFROM.Text = "UMSNB"
        Me.UMSNBRButtonFROM.UseVisualStyleBackColor = True
        '
        'FromBalance
        '
        Me.FromBalance.AutoSize = True
        Me.FromBalance.Location = New System.Drawing.Point(83, 74)
        Me.FromBalance.Name = "FromBalance"
        Me.FromBalance.Size = New System.Drawing.Size(19, 13)
        Me.FromBalance.TabIndex = 4
        Me.FromBalance.Text = "0p"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Funds"
        '
        'ToBalance
        '
        Me.ToBalance.AutoSize = True
        Me.ToBalance.Location = New System.Drawing.Point(83, 161)
        Me.ToBalance.Name = "ToBalance"
        Me.ToBalance.Size = New System.Drawing.Size(19, 13)
        Me.ToBalance.TabIndex = 7
        Me.ToBalance.Text = "0p"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Funds"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RIVERRButtonTO)
        Me.GroupBox2.Controls.Add(Me.GBANKRButtonTO)
        Me.GroupBox2.Controls.Add(Me.UMSNBRButtonTO)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 49)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "To"
        '
        'RIVERRButtonTO
        '
        Me.RIVERRButtonTO.AutoSize = True
        Me.RIVERRButtonTO.Location = New System.Drawing.Point(144, 19)
        Me.RIVERRButtonTO.Name = "RIVERRButtonTO"
        Me.RIVERRButtonTO.Size = New System.Drawing.Size(58, 17)
        Me.RIVERRButtonTO.TabIndex = 0
        Me.RIVERRButtonTO.Text = "RIVER"
        Me.RIVERRButtonTO.UseVisualStyleBackColor = True
        '
        'GBANKRButtonTO
        '
        Me.GBANKRButtonTO.AutoSize = True
        Me.GBANKRButtonTO.Location = New System.Drawing.Point(76, 19)
        Me.GBANKRButtonTO.Name = "GBANKRButtonTO"
        Me.GBANKRButtonTO.Size = New System.Drawing.Size(62, 17)
        Me.GBANKRButtonTO.TabIndex = 0
        Me.GBANKRButtonTO.Text = "GBANK"
        Me.GBANKRButtonTO.UseVisualStyleBackColor = True
        '
        'UMSNBRButtonTO
        '
        Me.UMSNBRButtonTO.AutoSize = True
        Me.UMSNBRButtonTO.Cursor = System.Windows.Forms.Cursors.Default
        Me.UMSNBRButtonTO.Location = New System.Drawing.Point(6, 19)
        Me.UMSNBRButtonTO.Name = "UMSNBRButtonTO"
        Me.UMSNBRButtonTO.Size = New System.Drawing.Size(64, 17)
        Me.UMSNBRButtonTO.TabIndex = 0
        Me.UMSNBRButtonTO.Text = "UMSNB"
        Me.UMSNBRButtonTO.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Money"
        '
        'TransferAmountBox
        '
        Me.TransferAmountBox.Location = New System.Drawing.Point(86, 183)
        Me.TransferAmountBox.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.TransferAmountBox.Name = "TransferAmountBox"
        Me.TransferAmountBox.Size = New System.Drawing.Size(136, 20)
        Me.TransferAmountBox.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Send"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'TransferMonet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 264)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TransferAmountBox)
        Me.Controls.Add(Me.ToBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FromBalance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransferMonet"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Money"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TransferAmountBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RIVERRButtonFROM As RadioButton
    Friend WithEvents GBANKRbuttonFROM As RadioButton
    Friend WithEvents UMSNBRButtonFROM As RadioButton
    Friend WithEvents FromBalance As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RIVERRButtonTO As RadioButton
    Friend WithEvents GBANKRButtonTO As RadioButton
    Friend WithEvents UMSNBRButtonTO As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TransferAmountBox As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
