<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EzTaxCertify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EzTaxCertify))
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleLBL = New System.Windows.Forms.Label()
        Me.SubtitleLBL = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.CopyBTN = New System.Windows.Forms.Button()
        Me.DetailsTXB = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.WaitForRender = New System.ComponentModel.BackgroundWorker()
        Me.ReportLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.EzTaxTopLabel.Text = "Income Statement"
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
        Me.TitleLBL.Size = New System.Drawing.Size(127, 24)
        Me.TitleLBL.TabIndex = 16
        Me.TitleLBL.Text = "Certifying Item"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SaveBTN)
        Me.GroupBox1.Controls.Add(Me.CopyBTN)
        Me.GroupBox1.Controls.Add(Me.DetailsTXB)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 260)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'SaveBTN
        '
        Me.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveBTN.Image = CType(resources.GetObject("SaveBTN.Image"), System.Drawing.Image)
        Me.SaveBTN.Location = New System.Drawing.Point(292, 16)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(75, 23)
        Me.SaveBTN.TabIndex = 20
        Me.SaveBTN.Text = "Save"
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'CopyBTN
        '
        Me.CopyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CopyBTN.Image = CType(resources.GetObject("CopyBTN.Image"), System.Drawing.Image)
        Me.CopyBTN.Location = New System.Drawing.Point(292, 45)
        Me.CopyBTN.Name = "CopyBTN"
        Me.CopyBTN.Size = New System.Drawing.Size(75, 23)
        Me.CopyBTN.TabIndex = 19
        Me.CopyBTN.Text = "Copy"
        Me.CopyBTN.UseVisualStyleBackColor = True
        '
        'DetailsTXB
        '
        Me.DetailsTXB.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsTXB.Location = New System.Drawing.Point(6, 19)
        Me.DetailsTXB.Multiline = True
        Me.DetailsTXB.Name = "DetailsTXB"
        Me.DetailsTXB.ReadOnly = True
        Me.DetailsTXB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsTXB.Size = New System.Drawing.Size(280, 235)
        Me.DetailsTXB.TabIndex = 19
        '
        'BackgroundWorker1
        '
        '
        'DetailsButton
        '
        Me.DetailsButton.Enabled = False
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DetailsButton.Image = CType(resources.GetObject("DetailsButton.Image"), System.Drawing.Image)
        Me.DetailsButton.Location = New System.Drawing.Point(310, 66)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(75, 23)
        Me.DetailsButton.TabIndex = 13
        Me.DetailsButton.Text = "Details"
        Me.DetailsButton.UseVisualStyleBackColor = True
        '
        'WaitForRender
        '
        '
        'ReportLabel
        '
        Me.ReportLabel.AutoSize = True
        Me.ReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ReportLabel.Location = New System.Drawing.Point(89, 86)
        Me.ReportLabel.Name = "ReportLabel"
        Me.ReportLabel.Size = New System.Drawing.Size(0, 9)
        Me.ReportLabel.TabIndex = 19
        '
        'EzTaxCertify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(397, 380)
        Me.Controls.Add(Me.ReportLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SubtitleLBL)
        Me.Controls.Add(Me.TitleLBL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.DetailsButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(397, 380)
        Me.MinimumSize = New System.Drawing.Size(397, 104)
        Me.Name = "EzTaxCertify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzTaxAbout"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EzTaxTopLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleLBL As Label
    Friend WithEvents SubtitleLBL As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DetailsTXB As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DetailsButton As Button
    Friend WithEvents SaveBTN As Button
    Friend WithEvents CopyBTN As Button
    Friend WithEvents WaitForRender As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReportLabel As Label
End Class
