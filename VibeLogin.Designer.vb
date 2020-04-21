<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VibeLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VibeLogin))
        Me.LogonPIN = New System.Windows.Forms.TextBox()
        Me.LogonID = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.PinLabel = New System.Windows.Forms.Label()
        Me.DirectoryButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ViBELogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RememberMeCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.KeyringButton = New System.Windows.Forms.Button()
        CType(Me.ViBELogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogonPIN
        '
        Me.HelpProvider1.SetHelpKeyword(Me.LogonPIN, "This is the PIN input box. Type in your 4 digit PIN correspondant to the ID you'r" &
        "e using to sign in. IF you forgot it, contact CHOPO for a reset.")
        Me.LogonPIN.Location = New System.Drawing.Point(184, 43)
        Me.LogonPIN.MaxLength = 4
        Me.LogonPIN.Name = "LogonPIN"
        Me.LogonPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HelpProvider1.SetShowHelp(Me.LogonPIN, True)
        Me.LogonPIN.Size = New System.Drawing.Size(73, 20)
        Me.LogonPIN.TabIndex = 2
        '
        'LogonID
        '
        Me.HelpProvider1.SetHelpKeyword(Me.LogonID, resources.GetString("LogonID.HelpKeyword"))
        Me.LogonID.Location = New System.Drawing.Point(184, 14)
        Me.LogonID.MaxLength = 5
        Me.LogonID.Name = "LogonID"
        Me.HelpProvider1.SetShowHelp(Me.LogonID, True)
        Me.LogonID.Size = New System.Drawing.Size(73, 20)
        Me.LogonID.TabIndex = 1
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(160, 17)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 2
        Me.IDLabel.Text = "ID"
        '
        'PinLabel
        '
        Me.PinLabel.AutoSize = True
        Me.PinLabel.Location = New System.Drawing.Point(153, 46)
        Me.PinLabel.Name = "PinLabel"
        Me.PinLabel.Size = New System.Drawing.Size(25, 13)
        Me.PinLabel.TabIndex = 2
        Me.PinLabel.Text = "PIN"
        '
        'DirectoryButton
        '
        Me.DirectoryButton.Font = New System.Drawing.Font("Wingdings 2", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.HelpProvider1.SetHelpKeyword(Me.DirectoryButton, "This is the directory button. Click on it to open the UMSWEB Directory")
        Me.DirectoryButton.Location = New System.Drawing.Point(263, 12)
        Me.DirectoryButton.Name = "DirectoryButton"
        Me.HelpProvider1.SetShowHelp(Me.DirectoryButton, True)
        Me.DirectoryButton.Size = New System.Drawing.Size(29, 38)
        Me.DirectoryButton.TabIndex = 3
        Me.DirectoryButton.Text = ","
        Me.ToolTip1.SetToolTip(Me.DirectoryButton, "Open the UMSWEB Directory")
        Me.DirectoryButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(298, 41)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 23)
        Me.RegisterButton.TabIndex = 4
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ViBELogoPictureBox
        '
        Me.ViBELogoPictureBox.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.VIBE1
        Me.ViBELogoPictureBox.Location = New System.Drawing.Point(-12, 0)
        Me.ViBELogoPictureBox.Name = "ViBELogoPictureBox"
        Me.ViBELogoPictureBox.Size = New System.Drawing.Size(151, 105)
        Me.ViBELogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ViBELogoPictureBox.TabIndex = 0
        Me.ViBELogoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ViBELogoPictureBox, "About ViBE")
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(298, 12)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "Log In"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'RememberMeCheckbox
        '
        Me.RememberMeCheckbox.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.RememberMeCheckbox, "REMEMBER ME will remember you and automatically sign you in to ViBE. To stop reme" &
        "mbering, simply logout.")
        Me.RememberMeCheckbox.Location = New System.Drawing.Point(156, 75)
        Me.RememberMeCheckbox.Name = "RememberMeCheckbox"
        Me.HelpProvider1.SetShowHelp(Me.RememberMeCheckbox, True)
        Me.RememberMeCheckbox.Size = New System.Drawing.Size(15, 14)
        Me.RememberMeCheckbox.TabIndex = 5
        Me.RememberMeCheckbox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.Label1, "REMEMBER ME will remember you and automatically sign you in to ViBE. To stop reme" &
        "mbering, simply logout.")
        Me.Label1.Location = New System.Drawing.Point(181, 75)
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, True)
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Remember Me"
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(298, 70)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 4
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'KeyringButton
        '
        Me.KeyringButton.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.KeyringButton.Location = New System.Drawing.Point(263, 55)
        Me.KeyringButton.Name = "KeyringButton"
        Me.KeyringButton.Size = New System.Drawing.Size(29, 38)
        Me.KeyringButton.TabIndex = 3
        Me.KeyringButton.Text = ""
        Me.KeyringButton.UseVisualStyleBackColor = True
        '
        'VibeLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 101)
        Me.Controls.Add(Me.RememberMeCheckbox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.KeyringButton)
        Me.Controls.Add(Me.DirectoryButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PinLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.LogonID)
        Me.Controls.Add(Me.LogonPIN)
        Me.Controls.Add(Me.ViBELogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 190)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(377, 139)
        Me.Name = "VibeLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Economy Login"
        CType(Me.ViBELogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ViBELogoPictureBox As PictureBox
    Friend WithEvents LogonPIN As TextBox
    Friend WithEvents LogonID As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents PinLabel As Label
    Friend WithEvents DirectoryButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents LoginButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RememberMeCheckbox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QuitButton As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents KeyringButton As Button
End Class
