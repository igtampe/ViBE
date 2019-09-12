<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VibeRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VibeRegister))
        Me.LoadingLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TC1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PinLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.NameTXB = New System.Windows.Forms.TextBox()
        Me.PINTXB = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButtonReg = New System.Windows.Forms.Button()
        Me.TC2 = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CongratsLBL1 = New System.Windows.Forms.Label()
        Me.CongratsLBL2 = New System.Windows.Forms.Label()
        Me.CongratsIDLBL = New System.Windows.Forms.Label()
        Me.CongratsLBL3 = New System.Windows.Forms.Label()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.CongratsLBL4 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingLabel
        '
        Me.LoadingLabel.AutoSize = True
        Me.LoadingLabel.Location = New System.Drawing.Point(107, 37)
        Me.LoadingLabel.Name = "LoadingLabel"
        Me.LoadingLabel.Size = New System.Drawing.Size(55, 13)
        Me.LoadingLabel.TabIndex = 5
        Me.LoadingLabel.Text = "Welcome!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UMSWEB Registration"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.UMSWEB
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'TC1
        '
        Me.TC1.BackColor = System.Drawing.Color.White
        Me.TC1.Location = New System.Drawing.Point(12, 71)
        Me.TC1.Multiline = True
        Me.TC1.Name = "TC1"
        Me.TC1.ReadOnly = True
        Me.TC1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TC1.Size = New System.Drawing.Size(342, 110)
        Me.TC1.TabIndex = 6
        Me.TC1.Text = resources.GetString("TC1.Text")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 307)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(305, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "I have read and agree to both of the Terms and Conditions."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PinLabel
        '
        Me.PinLabel.AutoSize = True
        Me.PinLabel.Location = New System.Drawing.Point(250, 356)
        Me.PinLabel.Name = "PinLabel"
        Me.PinLabel.Size = New System.Drawing.Size(25, 13)
        Me.PinLabel.TabIndex = 9
        Me.PinLabel.Text = "PIN"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(9, 356)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(35, 13)
        Me.IDLabel.TabIndex = 10
        Me.IDLabel.Text = "Name"
        '
        'NameTXB
        '
        Me.NameTXB.Location = New System.Drawing.Point(50, 353)
        Me.NameTXB.MaxLength = 50
        Me.NameTXB.Name = "NameTXB"
        Me.NameTXB.Size = New System.Drawing.Size(194, 20)
        Me.NameTXB.TabIndex = 8
        '
        'PINTXB
        '
        Me.PINTXB.Location = New System.Drawing.Point(281, 353)
        Me.PINTXB.MaxLength = 4
        Me.PINTXB.Name = "PINTXB"
        Me.PINTXB.Size = New System.Drawing.Size(73, 20)
        Me.PINTXB.TabIndex = 11
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(101, 379)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 12
        Me.OKButton.Text = "Register"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButtonReg
        '
        Me.CancelButtonReg.Location = New System.Drawing.Point(182, 379)
        Me.CancelButtonReg.Name = "CancelButtonReg"
        Me.CancelButtonReg.Size = New System.Drawing.Size(75, 23)
        Me.CancelButtonReg.TabIndex = 12
        Me.CancelButtonReg.Text = "Cancel"
        Me.CancelButtonReg.UseVisualStyleBackColor = True
        '
        'TC2
        '
        Me.TC2.BackColor = System.Drawing.Color.White
        Me.TC2.Location = New System.Drawing.Point(12, 187)
        Me.TC2.Multiline = True
        Me.TC2.Name = "TC2"
        Me.TC2.ReadOnly = True
        Me.TC2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TC2.Size = New System.Drawing.Size(342, 114)
        Me.TC2.TabIndex = 13
        Me.TC2.Text = resources.GetString("TC2.Text")
        '
        'BackgroundWorker1
        '
        '
        'CongratsLBL1
        '
        Me.CongratsLBL1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CongratsLBL1.Location = New System.Drawing.Point(12, 83)
        Me.CongratsLBL1.Name = "CongratsLBL1"
        Me.CongratsLBL1.Size = New System.Drawing.Size(342, 31)
        Me.CongratsLBL1.TabIndex = 14
        Me.CongratsLBL1.Text = "Congratulations!"
        Me.CongratsLBL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CongratsLBL1.Visible = False
        '
        'CongratsLBL2
        '
        Me.CongratsLBL2.Location = New System.Drawing.Point(12, 114)
        Me.CongratsLBL2.Name = "CongratsLBL2"
        Me.CongratsLBL2.Size = New System.Drawing.Size(342, 17)
        Me.CongratsLBL2.TabIndex = 15
        Me.CongratsLBL2.Text = "You're now registered on the UMSWEB"
        Me.CongratsLBL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CongratsLBL2.Visible = False
        '
        'CongratsIDLBL
        '
        Me.CongratsIDLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CongratsIDLBL.Location = New System.Drawing.Point(12, 131)
        Me.CongratsIDLBL.Name = "CongratsIDLBL"
        Me.CongratsIDLBL.Size = New System.Drawing.Size(342, 87)
        Me.CongratsIDLBL.TabIndex = 14
        Me.CongratsIDLBL.Text = "57174"
        Me.CongratsIDLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CongratsIDLBL.Visible = False
        '
        'CongratsLBL3
        '
        Me.CongratsLBL3.Location = New System.Drawing.Point(12, 218)
        Me.CongratsLBL3.Name = "CongratsLBL3"
        Me.CongratsLBL3.Size = New System.Drawing.Size(342, 31)
        Me.CongratsLBL3.TabIndex = 15
        Me.CongratsLBL3.Text = "This is your ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remember it as you will need it to sign in!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CongratsLBL3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CongratsLBL3.Visible = False
        '
        'OKBTN
        '
        Me.OKBTN.Location = New System.Drawing.Point(101, 284)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(156, 23)
        Me.OKBTN.TabIndex = 12
        Me.OKBTN.Text = "OK"
        Me.OKBTN.UseVisualStyleBackColor = True
        Me.OKBTN.Visible = False
        '
        'CongratsLBL4
        '
        Me.CongratsLBL4.Location = New System.Drawing.Point(12, 249)
        Me.CongratsLBL4.Name = "CongratsLBL4"
        Me.CongratsLBL4.Size = New System.Drawing.Size(342, 32)
        Me.CongratsLBL4.TabIndex = 15
        Me.CongratsLBL4.Text = "Welcome to the UMSWEB, (NAME)!"
        Me.CongratsLBL4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CongratsLBL4.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 330)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(155, 17)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "This is a corporate account"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'VibeRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 416)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.CongratsLBL4)
        Me.Controls.Add(Me.CongratsLBL3)
        Me.Controls.Add(Me.CongratsLBL2)
        Me.Controls.Add(Me.CongratsIDLBL)
        Me.Controls.Add(Me.CongratsLBL1)
        Me.Controls.Add(Me.TC2)
        Me.Controls.Add(Me.CancelButtonReg)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PinLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.NameTXB)
        Me.Controls.Add(Me.PINTXB)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TC1)
        Me.Controls.Add(Me.LoadingLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(382, 454)
        Me.MinimumSize = New System.Drawing.Size(382, 354)
        Me.Name = "VibeRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TC1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PinLabel As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents NameTXB As TextBox
    Friend WithEvents PINTXB As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButtonReg As Button
    Friend WithEvents TC2 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CongratsLBL1 As Label
    Friend WithEvents CongratsLBL2 As Label
    Friend WithEvents CongratsIDLBL As Label
    Friend WithEvents CongratsLBL3 As Label
    Friend WithEvents OKBTN As Button
    Friend WithEvents CongratsLBL4 As Label
    Friend WithEvents CheckBox2 As CheckBox
End Class
