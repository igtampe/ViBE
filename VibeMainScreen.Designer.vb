<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VibeMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VibeMainScreen))
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.UMSNBCheck = New System.Windows.Forms.CheckBox()
        Me.GBANKCheck = New System.Windows.Forms.CheckBox()
        Me.RIVERCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KeyringButton = New System.Windows.Forms.Button()
        Me.RIVERLink = New System.Windows.Forms.LinkLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GBANKLink = New System.Windows.Forms.LinkLabel()
        Me.UMSNBLink = New System.Windows.Forms.LinkLabel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NotifButton = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TotalBLabel = New System.Windows.Forms.Label()
        Me.RIVERBLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBANKBLabel = New System.Windows.Forms.Label()
        Me.UMSNBBLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RefreshBW = New System.ComponentModel.BackgroundWorker()
        Me.RefreshTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EZTaxButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LNDViewBTN = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BANKTXB = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CaptureScreenshot = New System.Windows.Forms.Button()
        Me.SwitchUserBW = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(12, 9)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(223, 32)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Igtampe (57174)"
        '
        'UMSNBCheck
        '
        Me.UMSNBCheck.AutoSize = True
        Me.UMSNBCheck.Enabled = False
        Me.UMSNBCheck.Location = New System.Drawing.Point(6, 19)
        Me.UMSNBCheck.Name = "UMSNBCheck"
        Me.UMSNBCheck.Size = New System.Drawing.Size(15, 14)
        Me.UMSNBCheck.TabIndex = 2
        Me.UMSNBCheck.UseVisualStyleBackColor = True
        '
        'GBANKCheck
        '
        Me.GBANKCheck.AutoSize = True
        Me.GBANKCheck.Enabled = False
        Me.GBANKCheck.Location = New System.Drawing.Point(132, 19)
        Me.GBANKCheck.Name = "GBANKCheck"
        Me.GBANKCheck.Size = New System.Drawing.Size(15, 14)
        Me.GBANKCheck.TabIndex = 3
        Me.GBANKCheck.UseVisualStyleBackColor = True
        '
        'RIVERCheck
        '
        Me.RIVERCheck.AutoSize = True
        Me.RIVERCheck.Enabled = False
        Me.RIVERCheck.Location = New System.Drawing.Point(200, 19)
        Me.RIVERCheck.Name = "RIVERCheck"
        Me.RIVERCheck.Size = New System.Drawing.Size(15, 14)
        Me.RIVERCheck.TabIndex = 4
        Me.RIVERCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.KeyringButton)
        Me.GroupBox1.Controls.Add(Me.RIVERLink)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.GBANKLink)
        Me.GroupBox1.Controls.Add(Me.UMSNBLink)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.UMSNBCheck)
        Me.GroupBox1.Controls.Add(Me.GBANKCheck)
        Me.GroupBox1.Controls.Add(Me.NotifButton)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.RIVERCheck)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 43)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registered Banks"
        '
        'KeyringButton
        '
        Me.KeyringButton.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HelpProvider1.SetHelpString(Me.KeyringButton, "This button will log you out and launch the KeyRing")
        Me.KeyringButton.Location = New System.Drawing.Point(421, 13)
        Me.KeyringButton.Margin = New System.Windows.Forms.Padding(1)
        Me.KeyringButton.Name = "KeyringButton"
        Me.HelpProvider1.SetShowHelp(Me.KeyringButton, True)
        Me.KeyringButton.Size = New System.Drawing.Size(23, 22)
        Me.KeyringButton.TabIndex = 91
        Me.KeyringButton.Text = ""
        Me.RefreshTooltip.SetToolTip(Me.KeyringButton, "KeyRing")
        Me.KeyringButton.UseVisualStyleBackColor = True
        '
        'RIVERLink
        '
        Me.RIVERLink.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.RIVERLink, "Click here to open your Riverside Bank logs, and maybe even certify a transaction" &
        ".")
        Me.RIVERLink.Location = New System.Drawing.Point(221, 19)
        Me.RIVERLink.Name = "RIVERLink"
        Me.HelpProvider1.SetShowHelp(Me.RIVERLink, True)
        Me.RIVERLink.Size = New System.Drawing.Size(79, 13)
        Me.RIVERLink.TabIndex = 11
        Me.RIVERLink.TabStop = True
        Me.RIVERLink.Text = "Riverside Bank"
        Me.RefreshTooltip.SetToolTip(Me.RIVERLink, "Access your Riverside Bank logs")
        '
        'Button3
        '
        Me.HelpProvider1.SetHelpKeyword(Me.Button3, "This button gives you 1,000p. Just kidding, it changes your PIN.")
        Me.Button3.Location = New System.Drawing.Point(396, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.HelpProvider1.SetShowHelp(Me.Button3, True)
        Me.Button3.Size = New System.Drawing.Size(23, 22)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "*"
        Me.RefreshTooltip.SetToolTip(Me.Button3, "Change your account pin")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GBANKLink
        '
        Me.GBANKLink.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.GBANKLink, "Click here to open your G-Bank logs, and maybe even certify a transaction.")
        Me.GBANKLink.Location = New System.Drawing.Point(153, 19)
        Me.GBANKLink.Name = "GBANKLink"
        Me.HelpProvider1.SetShowHelp(Me.GBANKLink, True)
        Me.GBANKLink.Size = New System.Drawing.Size(40, 13)
        Me.GBANKLink.TabIndex = 11
        Me.GBANKLink.TabStop = True
        Me.GBANKLink.Text = "GBank"
        Me.RefreshTooltip.SetToolTip(Me.GBANKLink, "Access your GBANK Logs")
        '
        'UMSNBLink
        '
        Me.UMSNBLink.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.UMSNBLink, "Click here to open your UMS National Bank logs, and maybe even certify a transact" &
        "ion.")
        Me.UMSNBLink.Location = New System.Drawing.Point(22, 19)
        Me.UMSNBLink.Name = "UMSNBLink"
        Me.HelpProvider1.SetShowHelp(Me.UMSNBLink, True)
        Me.UMSNBLink.Size = New System.Drawing.Size(101, 13)
        Me.UMSNBLink.TabIndex = 11
        Me.UMSNBLink.TabStop = True
        Me.UMSNBLink.Text = "UMS National Bank"
        Me.RefreshTooltip.SetToolTip(Me.UMSNBLink, "Access your UMS National Bank Logs")
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Wingdings 2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button4, "This button logs you out of ViBE. If you had ViBE set to remember you, this will " &
        "stop it from remembering you.")
        Me.Button4.Location = New System.Drawing.Point(446, 13)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Button4.Name = "Button4"
        Me.HelpProvider1.SetShowHelp(Me.Button4, True)
        Me.Button4.Size = New System.Drawing.Size(23, 22)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "T"
        Me.RefreshTooltip.SetToolTip(Me.Button4, "Log Out")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NotifButton
        '
        Me.NotifButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.NotifButton, "This button will bring up your notifications. A number will appear if you have an" &
        "y pending notifications")
        Me.NotifButton.Location = New System.Drawing.Point(321, 13)
        Me.NotifButton.Margin = New System.Windows.Forms.Padding(1)
        Me.NotifButton.Name = "NotifButton"
        Me.HelpProvider1.SetShowHelp(Me.NotifButton, True)
        Me.NotifButton.Size = New System.Drawing.Size(23, 22)
        Me.NotifButton.TabIndex = 5
        Me.NotifButton.Text = "0"
        Me.RefreshTooltip.SetToolTip(Me.NotifButton, "Notifications")
        Me.NotifButton.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button5, "This will bring up the about page, from which you can open the Readme")
        Me.Button5.Location = New System.Drawing.Point(346, 13)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.HelpProvider1.SetShowHelp(Me.Button5, True)
        Me.Button5.Size = New System.Drawing.Size(23, 22)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "?"
        Me.RefreshTooltip.SetToolTip(Me.Button5, "About (And Help)")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Wingdings 3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HelpProvider1.SetHelpString(Me.RefreshButton, "This is the refresh button. It'll contact the server and ask for the most recent " &
        "information.")
        Me.RefreshButton.Location = New System.Drawing.Point(371, 13)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(1)
        Me.RefreshButton.Name = "RefreshButton"
        Me.HelpProvider1.SetShowHelp(Me.RefreshButton, True)
        Me.RefreshButton.Size = New System.Drawing.Size(23, 22)
        Me.RefreshButton.TabIndex = 7
        Me.RefreshButton.Text = "P"
        Me.RefreshTooltip.SetToolTip(Me.RefreshButton, "Refresh information")
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TotalBLabel)
        Me.GroupBox2.Controls.Add(Me.RIVERBLabel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.GBANKBLabel)
        Me.GroupBox2.Controls.Add(Me.UMSNBBLabel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpString(Me.GroupBox2, "These are your current balances on the UMSWEB. If they're out of date, hit the RE" &
        "FRESH button")
        Me.GroupBox2.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.HelpProvider1.SetShowHelp(Me.GroupBox2, True)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 89)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Balances"
        '
        'TotalBLabel
        '
        Me.TotalBLabel.AutoSize = True
        Me.TotalBLabel.Location = New System.Drawing.Point(123, 68)
        Me.TotalBLabel.Name = "TotalBLabel"
        Me.TotalBLabel.Size = New System.Drawing.Size(0, 13)
        Me.TotalBLabel.TabIndex = 16
        '
        'RIVERBLabel
        '
        Me.RIVERBLabel.AutoSize = True
        Me.RIVERBLabel.Location = New System.Drawing.Point(123, 42)
        Me.RIVERBLabel.Name = "RIVERBLabel"
        Me.RIVERBLabel.Size = New System.Drawing.Size(0, 13)
        Me.RIVERBLabel.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Total"
        '
        'GBANKBLabel
        '
        Me.GBANKBLabel.AutoSize = True
        Me.GBANKBLabel.Location = New System.Drawing.Point(123, 29)
        Me.GBANKBLabel.Name = "GBANKBLabel"
        Me.GBANKBLabel.Size = New System.Drawing.Size(0, 13)
        Me.GBANKBLabel.TabIndex = 12
        '
        'UMSNBBLabel
        '
        Me.UMSNBBLabel.AutoSize = True
        Me.UMSNBBLabel.Location = New System.Drawing.Point(123, 16)
        Me.UMSNBBLabel.Name = "UMSNBBLabel"
        Me.UMSNBBLabel.Size = New System.Drawing.Size(0, 13)
        Me.UMSNBBLabel.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Riverside Bank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "GBank"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "UMS National Bank"
        '
        'Button1
        '
        Me.HelpProvider1.SetHelpKeyword(Me.Button1, "This button is here to help you send money to OTHER bank accounts.")
        Me.Button1.Location = New System.Drawing.Point(239, 111)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Send"
        Me.RefreshTooltip.SetToolTip(Me.Button1, "Send money to someone")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.HelpProvider1.SetHelpKeyword(Me.Button2, "This button is here to help you transfer your funds between your own bank account" &
        "s.")
        Me.Button2.Location = New System.Drawing.Point(239, 140)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Transfer"
        Me.RefreshTooltip.SetToolTip(Me.Button2, "Transfer money between your bank accounts")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RefreshBW
        '
        '
        'EZTaxButton
        '
        Me.HelpProvider1.SetHelpKeyword(Me.EZTaxButton, "Launch EzTax which can help you report your income to the UMS Government")
        Me.EZTaxButton.Location = New System.Drawing.Point(320, 111)
        Me.EZTaxButton.Name = "EZTaxButton"
        Me.HelpProvider1.SetShowHelp(Me.EZTaxButton, True)
        Me.EZTaxButton.Size = New System.Drawing.Size(75, 23)
        Me.EZTaxButton.TabIndex = 12
        Me.EZTaxButton.Text = "EzTax"
        Me.RefreshTooltip.SetToolTip(Me.EZTaxButton, "Launch EzTax 4.0")
        Me.EZTaxButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.Label4, "Hoo hoo ha ha hee hee Send CHOPO the code `24602060451` and you'll get 100,000 Pe" &
        "cunia if you're the first!")
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.HelpProvider1.SetShowHelp(Me.Label4, True)
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "The LEMON was here..."
        Me.RefreshTooltip.SetToolTip(Me.Label4, "Shhhhhh")
        '
        'LNDViewBTN
        '
        Me.LNDViewBTN.Location = New System.Drawing.Point(320, 140)
        Me.LNDViewBTN.Name = "LNDViewBTN"
        Me.LNDViewBTN.Size = New System.Drawing.Size(75, 23)
        Me.LNDViewBTN.TabIndex = 13
        Me.LNDViewBTN.Text = "LandView"
        Me.RefreshTooltip.SetToolTip(Me.LNDViewBTN, "Open LandView")
        Me.LNDViewBTN.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(401, 111)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Checkbook"
        Me.RefreshTooltip.SetToolTip(Me.Button6, "Launch Checkbook 2000")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(401, 140)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Contractus"
        Me.RefreshTooltip.SetToolTip(Me.Button7, "Launch Contractus Contract Manager")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BANKTXB
        '
        Me.BANKTXB.Location = New System.Drawing.Point(390, 27)
        Me.BANKTXB.Name = "BANKTXB"
        Me.BANKTXB.Size = New System.Drawing.Size(10, 20)
        Me.BANKTXB.TabIndex = 90
        Me.BANKTXB.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CaptureScreenshot)
        Me.GroupBox3.Controls.Add(Me.BANKTXB)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 54)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "The Secret Box"
        '
        'CaptureScreenshot
        '
        Me.CaptureScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CaptureScreenshot.Location = New System.Drawing.Point(241, 22)
        Me.CaptureScreenshot.Name = "CaptureScreenshot"
        Me.CaptureScreenshot.Size = New System.Drawing.Size(75, 23)
        Me.CaptureScreenshot.TabIndex = 14
        Me.CaptureScreenshot.Text = "Capture"
        Me.CaptureScreenshot.UseVisualStyleBackColor = False
        '
        'SwitchUserBW
        '
        '
        'VibeMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.Corporate
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(504, 192)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LNDViewBTN)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.EZTaxButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NameLabel)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 304)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 230)
        Me.Name = "VibeMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Economy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents UMSNBCheck As CheckBox
    Friend WithEvents GBANKCheck As CheckBox
    Friend WithEvents RIVERCheck As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TotalBLabel As Label
    Friend WithEvents RIVERBLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents RefreshBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents GBANKBLabel As Label
    Friend WithEvents UMSNBBLabel As Label
    Friend WithEvents RefreshTooltip As ToolTip
    Friend WithEvents EZTaxButton As Button
    Friend WithEvents RIVERLink As LinkLabel
    Friend WithEvents GBANKLink As LinkLabel
    Friend WithEvents UMSNBLink As LinkLabel
    Friend WithEvents BANKTXB As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NotifButton As Button
    Friend WithEvents LNDViewBTN As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents CaptureScreenshot As Button
    Friend WithEvents KeyringButton As Button
    Friend WithEvents SwitchUserBW As System.ComponentModel.BackgroundWorker
End Class
