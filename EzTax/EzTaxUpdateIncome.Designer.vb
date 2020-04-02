<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EzTaxUpdateIncome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EzTaxUpdateIncome))
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleLBL = New System.Windows.Forms.Label()
        Me.SubtitleLBL = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.WaitForRender = New System.ComponentModel.BackgroundWorker()
        Me.BackupButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EzTaxTopLabel
        '
        Me.EzTaxTopLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.EzTaxTopLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EzTaxTopLabel.ForeColor = System.Drawing.Color.White
        Me.EzTaxTopLabel.Location = New System.Drawing.Point(0, 0)
        Me.EzTaxTopLabel.Name = "EzTaxTopLabel"
        Me.EzTaxTopLabel.Size = New System.Drawing.Size(397, 22)
        Me.EzTaxTopLabel.TabIndex = 14
        Me.EzTaxTopLabel.Text = "Income Update"
        Me.EzTaxTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Hourglass
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TitleLBL
        '
        Me.TitleLBL.AutoSize = True
        Me.TitleLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLBL.Location = New System.Drawing.Point(87, 29)
        Me.TitleLBL.Name = "TitleLBL"
        Me.TitleLBL.Size = New System.Drawing.Size(168, 24)
        Me.TitleLBL.TabIndex = 16
        Me.TitleLBL.Text = "Updating Income..."
        '
        'SubtitleLBL
        '
        Me.SubtitleLBL.Location = New System.Drawing.Point(88, 56)
        Me.SubtitleLBL.Name = "SubtitleLBL"
        Me.SubtitleLBL.Size = New System.Drawing.Size(214, 30)
        Me.SubtitleLBL.TabIndex = 17
        Me.SubtitleLBL.Text = "Please wait..."
        '
        'OKButton
        '
        Me.OKButton.Enabled = False
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKButton.Image = CType(resources.GetObject("OKButton.Image"), System.Drawing.Image)
        Me.OKButton.Location = New System.Drawing.Point(310, 32)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 13
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BackupButton
        '
        Me.BackupButton.Enabled = False
        Me.BackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackupButton.Image = CType(resources.GetObject("BackupButton.Image"), System.Drawing.Image)
        Me.BackupButton.Location = New System.Drawing.Point(310, 63)
        Me.BackupButton.Name = "BackupButton"
        Me.BackupButton.Size = New System.Drawing.Size(75, 23)
        Me.BackupButton.TabIndex = 18
        Me.BackupButton.Text = "Upload IRF"
        Me.BackupButton.UseVisualStyleBackColor = True
        '
        'EzTaxUpdateIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(397, 104)
        Me.Controls.Add(Me.BackupButton)
        Me.Controls.Add(Me.SubtitleLBL)
        Me.Controls.Add(Me.TitleLBL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.Controls.Add(Me.OKButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(397, 380)
        Me.MinimumSize = New System.Drawing.Size(397, 104)
        Me.Name = "EzTaxUpdateIncome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzTaxAbout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EzTaxTopLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLBL As Label
    Friend WithEvents SubtitleLBL As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents WaitForRender As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackupButton As Button
End Class
