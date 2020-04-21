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
        Me.RegisteredBanksGroupBox = New System.Windows.Forms.GroupBox()
        Me.KeyringButton = New System.Windows.Forms.Button()
        Me.RIVERLink = New System.Windows.Forms.LinkLabel()
        Me.ChangePinButton = New System.Windows.Forms.Button()
        Me.GBANKLink = New System.Windows.Forms.LinkLabel()
        Me.UMSNBLink = New System.Windows.Forms.LinkLabel()
        Me.LogOutButton = New System.Windows.Forms.Button()
        Me.NotifButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.BalancesGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalBLabel = New System.Windows.Forms.Label()
        Me.RIVERBLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBANKBLabel = New System.Windows.Forms.Label()
        Me.UMSNBBLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SendMoneyBTN = New System.Windows.Forms.Button()
        Me.TransferMoneyBTN = New System.Windows.Forms.Button()
        Me.RefreshBW = New System.ComponentModel.BackgroundWorker()
        Me.RefreshTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.EZTaxButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LNDViewBTN = New System.Windows.Forms.Button()
        Me.CheckBookBTN = New System.Windows.Forms.Button()
        Me.ContractusBTN = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SwitchUserBW = New System.ComponentModel.BackgroundWorker()
        Me.RegisteredBanksGroupBox.SuspendLayout()
        Me.BalancesGroupBox.SuspendLayout()
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
        'RegisteredBanksGroupBox
        '
        Me.RegisteredBanksGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.RegisteredBanksGroupBox.Controls.Add(Me.KeyringButton)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.RIVERLink)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.ChangePinButton)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.GBANKLink)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.UMSNBLink)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.LogOutButton)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.UMSNBCheck)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.GBANKCheck)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.NotifButton)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.AboutButton)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.RefreshButton)
        Me.RegisteredBanksGroupBox.Controls.Add(Me.RIVERCheck)
        Me.RegisteredBanksGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisteredBanksGroupBox.Location = New System.Drawing.Point(12, 43)
        Me.RegisteredBanksGroupBox.Name = "RegisteredBanksGroupBox"
        Me.RegisteredBanksGroupBox.Size = New System.Drawing.Size(475, 43)
        Me.RegisteredBanksGroupBox.TabIndex = 5
        Me.RegisteredBanksGroupBox.TabStop = False
        Me.RegisteredBanksGroupBox.Text = "Registered Banks"
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
        'ChangePinButton
        '
        Me.HelpProvider1.SetHelpKeyword(Me.ChangePinButton, "This button gives you 1,000p. Just kidding, it changes your PIN.")
        Me.ChangePinButton.Location = New System.Drawing.Point(396, 13)
        Me.ChangePinButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ChangePinButton.Name = "ChangePinButton"
        Me.HelpProvider1.SetShowHelp(Me.ChangePinButton, True)
        Me.ChangePinButton.Size = New System.Drawing.Size(23, 22)
        Me.ChangePinButton.TabIndex = 8
        Me.ChangePinButton.Text = "*"
        Me.RefreshTooltip.SetToolTip(Me.ChangePinButton, "Change your account pin")
        Me.ChangePinButton.UseVisualStyleBackColor = True
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
        'LogOutButton
        '
        Me.LogOutButton.Font = New System.Drawing.Font("Wingdings 2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HelpProvider1.SetHelpString(Me.LogOutButton, "This button logs you out of ViBE. If you had ViBE set to remember you, this will " &
        "stop it from remembering you.")
        Me.LogOutButton.Location = New System.Drawing.Point(446, 13)
        Me.LogOutButton.Margin = New System.Windows.Forms.Padding(1)
        Me.LogOutButton.Name = "LogOutButton"
        Me.HelpProvider1.SetShowHelp(Me.LogOutButton, True)
        Me.LogOutButton.Size = New System.Drawing.Size(23, 22)
        Me.LogOutButton.TabIndex = 9
        Me.LogOutButton.Text = "T"
        Me.RefreshTooltip.SetToolTip(Me.LogOutButton, "Log Out")
        Me.LogOutButton.UseVisualStyleBackColor = True
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
        'AboutButton
        '
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.AboutButton, "This will bring up the about page, from which you can open the Readme")
        Me.AboutButton.Location = New System.Drawing.Point(346, 13)
        Me.AboutButton.Margin = New System.Windows.Forms.Padding(1)
        Me.AboutButton.Name = "AboutButton"
        Me.HelpProvider1.SetShowHelp(Me.AboutButton, True)
        Me.AboutButton.Size = New System.Drawing.Size(23, 22)
        Me.AboutButton.TabIndex = 6
        Me.AboutButton.Text = "?"
        Me.RefreshTooltip.SetToolTip(Me.AboutButton, "About (And Help)")
        Me.AboutButton.UseVisualStyleBackColor = True
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
        'BalancesGroupBox
        '
        Me.BalancesGroupBox.Controls.Add(Me.TotalBLabel)
        Me.BalancesGroupBox.Controls.Add(Me.RIVERBLabel)
        Me.BalancesGroupBox.Controls.Add(Me.Label7)
        Me.BalancesGroupBox.Controls.Add(Me.GBANKBLabel)
        Me.BalancesGroupBox.Controls.Add(Me.UMSNBBLabel)
        Me.BalancesGroupBox.Controls.Add(Me.Label3)
        Me.BalancesGroupBox.Controls.Add(Me.Label2)
        Me.BalancesGroupBox.Controls.Add(Me.Label1)
        Me.HelpProvider1.SetHelpString(Me.BalancesGroupBox, "These are your current balances on the UMSWEB. If they're out of date, hit the RE" &
        "FRESH button")
        Me.BalancesGroupBox.Location = New System.Drawing.Point(12, 92)
        Me.BalancesGroupBox.Name = "BalancesGroupBox"
        Me.HelpProvider1.SetShowHelp(Me.BalancesGroupBox, True)
        Me.BalancesGroupBox.Size = New System.Drawing.Size(215, 89)
        Me.BalancesGroupBox.TabIndex = 6
        Me.BalancesGroupBox.TabStop = False
        Me.BalancesGroupBox.Text = "Balances"
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
        'SendMoneyBTN
        '
        Me.HelpProvider1.SetHelpKeyword(Me.SendMoneyBTN, "This button is here to help you send money to OTHER bank accounts.")
        Me.SendMoneyBTN.Location = New System.Drawing.Point(244, 111)
        Me.SendMoneyBTN.Name = "SendMoneyBTN"
        Me.HelpProvider1.SetShowHelp(Me.SendMoneyBTN, True)
        Me.SendMoneyBTN.Size = New System.Drawing.Size(75, 23)
        Me.SendMoneyBTN.TabIndex = 10
        Me.SendMoneyBTN.Text = "Send"
        Me.RefreshTooltip.SetToolTip(Me.SendMoneyBTN, "Send money to someone")
        Me.SendMoneyBTN.UseVisualStyleBackColor = True
        '
        'TransferMoneyBTN
        '
        Me.HelpProvider1.SetHelpKeyword(Me.TransferMoneyBTN, "This button is here to help you transfer your funds between your own bank account" &
        "s.")
        Me.TransferMoneyBTN.Location = New System.Drawing.Point(244, 140)
        Me.TransferMoneyBTN.Name = "TransferMoneyBTN"
        Me.HelpProvider1.SetShowHelp(Me.TransferMoneyBTN, True)
        Me.TransferMoneyBTN.Size = New System.Drawing.Size(75, 23)
        Me.TransferMoneyBTN.TabIndex = 11
        Me.TransferMoneyBTN.Text = "Transfer"
        Me.RefreshTooltip.SetToolTip(Me.TransferMoneyBTN, "Transfer money between your bank accounts")
        Me.TransferMoneyBTN.UseVisualStyleBackColor = True
        '
        'RefreshBW
        '
        '
        'EZTaxButton
        '
        Me.HelpProvider1.SetHelpKeyword(Me.EZTaxButton, "Launch EzTax which can help you report your income to the UMS Government")
        Me.EZTaxButton.Location = New System.Drawing.Point(325, 111)
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
        Me.LNDViewBTN.Location = New System.Drawing.Point(325, 140)
        Me.LNDViewBTN.Name = "LNDViewBTN"
        Me.LNDViewBTN.Size = New System.Drawing.Size(75, 23)
        Me.LNDViewBTN.TabIndex = 13
        Me.LNDViewBTN.Text = "LandView"
        Me.RefreshTooltip.SetToolTip(Me.LNDViewBTN, "Open LandView")
        Me.LNDViewBTN.UseVisualStyleBackColor = True
        '
        'CheckBookBTN
        '
        Me.CheckBookBTN.Location = New System.Drawing.Point(406, 111)
        Me.CheckBookBTN.Name = "CheckBookBTN"
        Me.CheckBookBTN.Size = New System.Drawing.Size(75, 23)
        Me.CheckBookBTN.TabIndex = 14
        Me.CheckBookBTN.Text = "Checkbook"
        Me.RefreshTooltip.SetToolTip(Me.CheckBookBTN, "Launch Checkbook 2000")
        Me.CheckBookBTN.UseVisualStyleBackColor = True
        '
        'ContractusBTN
        '
        Me.ContractusBTN.Location = New System.Drawing.Point(406, 140)
        Me.ContractusBTN.Name = "ContractusBTN"
        Me.ContractusBTN.Size = New System.Drawing.Size(75, 23)
        Me.ContractusBTN.TabIndex = 15
        Me.ContractusBTN.Text = "Contractus"
        Me.RefreshTooltip.SetToolTip(Me.ContractusBTN, "Launch Contractus Contract Manager")
        Me.ContractusBTN.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 54)
        Me.GroupBox3.TabIndex = 90
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "The Secret Box"
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
        Me.ClientSize = New System.Drawing.Size(504, 191)
        Me.Controls.Add(Me.ContractusBTN)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TransferMoneyBTN)
        Me.Controls.Add(Me.LNDViewBTN)
        Me.Controls.Add(Me.CheckBookBTN)
        Me.Controls.Add(Me.EZTaxButton)
        Me.Controls.Add(Me.SendMoneyBTN)
        Me.Controls.Add(Me.BalancesGroupBox)
        Me.Controls.Add(Me.RegisteredBanksGroupBox)
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
        Me.RegisteredBanksGroupBox.ResumeLayout(False)
        Me.RegisteredBanksGroupBox.PerformLayout()
        Me.BalancesGroupBox.ResumeLayout(False)
        Me.BalancesGroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents UMSNBCheck As CheckBox
    Friend WithEvents GBANKCheck As CheckBox
    Friend WithEvents RIVERCheck As CheckBox
    Friend WithEvents RegisteredBanksGroupBox As GroupBox
    Friend WithEvents BalancesGroupBox As GroupBox
    Friend WithEvents TotalBLabel As Label
    Friend WithEvents RIVERBLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SendMoneyBTN As Button
    Friend WithEvents TransferMoneyBTN As Button
    Friend WithEvents ChangePinButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents RefreshBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents GBANKBLabel As Label
    Friend WithEvents UMSNBBLabel As Label
    Friend WithEvents RefreshTooltip As ToolTip
    Friend WithEvents EZTaxButton As Button
    Friend WithEvents RIVERLink As LinkLabel
    Friend WithEvents GBANKLink As LinkLabel
    Friend WithEvents UMSNBLink As LinkLabel
    Friend WithEvents AboutButton As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NotifButton As Button
    Friend WithEvents LNDViewBTN As Button
    Friend WithEvents CheckBookBTN As Button
    Friend WithEvents ContractusBTN As Button
    Friend WithEvents KeyringButton As Button
    Friend WithEvents SwitchUserBW As System.ComponentModel.BackgroundWorker
End Class
