<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LBLSender
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBLBackgroundSender = New System.ComponentModel.BackgroundWorker()
        Me.Header = New System.Windows.Forms.Label()
        Me.Footer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.Label()
        Me.Quit = New System.Windows.Forms.Button()
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.FileOut
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LBLBackgroundSender
        '
        Me.LBLBackgroundSender.WorkerReportsProgress = True
        Me.LBLBackgroundSender.WorkerSupportsCancellation = True
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Location = New System.Drawing.Point(118, 40)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(503, 25)
        Me.Header.TabIndex = 3
        Me.Header.Text = "LBL-ing A:\Downloads\TTS.CSV"
        '
        'Footer
        '
        Me.Footer.Location = New System.Drawing.Point(118, 65)
        Me.Footer.Name = "Footer"
        Me.Footer.Size = New System.Drawing.Size(501, 13)
        Me.Footer.TabIndex = 4
        Me.Footer.Text = "Waiting For server"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(118, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 25)
        Me.Label1.TabIndex = 4
        '
        'ProgressBar
        '
        Me.ProgressBar.BackColor = System.Drawing.Color.MediumBlue
        Me.ProgressBar.Location = New System.Drawing.Point(118, 92)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(30, 25)
        Me.ProgressBar.TabIndex = 5
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.DarkBlue
        Me.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.ForeColor = System.Drawing.Color.White
        Me.Quit.Location = New System.Drawing.Point(598, 2)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(35, 19)
        Me.Quit.TabIndex = 9
        Me.Quit.Text = "X"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'EzTaxTopLabel
        '
        Me.EzTaxTopLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.EzTaxTopLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EzTaxTopLabel.ForeColor = System.Drawing.Color.White
        Me.EzTaxTopLabel.Location = New System.Drawing.Point(0, 0)
        Me.EzTaxTopLabel.Name = "EzTaxTopLabel"
        Me.EzTaxTopLabel.Size = New System.Drawing.Size(633, 22)
        Me.EzTaxTopLabel.TabIndex = 10
        Me.EzTaxTopLabel.Text = "LBL Transfer"
        Me.EzTaxTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(633, 140)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LBLSender"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LBL Sender"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLBackgroundSender As System.ComponentModel.BackgroundWorker
    Friend WithEvents Header As Label
    Friend WithEvents Footer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar As Label
    Friend WithEvents Quit As Button
    Friend WithEvents EzTaxTopLabel As Label
End Class
