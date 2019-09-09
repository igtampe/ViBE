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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RememberMeCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.KeyringButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VIBE__But_on_Visual_Studio_.My.Resources.Resources.VIBE1
        Me.PictureBox1.Location = New System.Drawing.Point(-12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "About ViBE")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Log In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Quit"
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KeyringButton)
        Me.Controls.Add(Me.DirectoryButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PinLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.LogonID)
        Me.Controls.Add(Me.LogonPIN)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 190)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(377, 139)
        Me.Name = "VibeLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic Economy Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LogonPIN As TextBox
    Friend WithEvents LogonID As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents PinLabel As Label
    Friend WithEvents DirectoryButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RememberMeCheckbox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents KeyringButton As Button
End Class
