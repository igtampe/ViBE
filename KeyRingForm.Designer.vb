<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyringForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyringForm))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddHeader = New System.Windows.Forms.Button()
        Me.AddToKeyRingButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ActionButton = New System.Windows.Forms.Button()
        Me.QuitBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccountNumberLabel = New System.Windows.Forms.Label()
        Me.MoveUpBTN = New System.Windows.Forms.Button()
        Me.MoveDownBTN = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 65)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(297, 200)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 218
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddHeader)
        Me.GroupBox1.Controls.Add(Me.AddToKeyRingButton)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.DeleteButton)
        Me.GroupBox1.Controls.Add(Me.ActionButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 74)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Actions"
        '
        'AddHeader
        '
        Me.AddHeader.Location = New System.Drawing.Point(244, 44)
        Me.AddHeader.Name = "AddHeader"
        Me.AddHeader.Size = New System.Drawing.Size(75, 23)
        Me.AddHeader.TabIndex = 4
        Me.AddHeader.Text = "Add Header"
        Me.AddHeader.UseVisualStyleBackColor = True
        '
        'AddToKeyRingButton
        '
        Me.AddToKeyRingButton.Location = New System.Drawing.Point(6, 44)
        Me.AddToKeyRingButton.Name = "AddToKeyRingButton"
        Me.AddToKeyRingButton.Size = New System.Drawing.Size(232, 23)
        Me.AddToKeyRingButton.TabIndex = 3
        Me.AddToKeyRingButton.Text = "Add the Current Account to the KeyRing"
        Me.AddToKeyRingButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(48, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Remember This Account"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(244, 19)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ActionButton
        '
        Me.ActionButton.Location = New System.Drawing.Point(6, 19)
        Me.ActionButton.Name = "ActionButton"
        Me.ActionButton.Size = New System.Drawing.Size(232, 23)
        Me.ActionButton.TabIndex = 0
        Me.ActionButton.Text = "Log in"
        Me.ActionButton.UseVisualStyleBackColor = True
        '
        'QuitBTN
        '
        Me.QuitBTN.Location = New System.Drawing.Point(256, 351)
        Me.QuitBTN.Name = "QuitBTN"
        Me.QuitBTN.Size = New System.Drawing.Size(75, 23)
        Me.QuitBTN.TabIndex = 2
        Me.QuitBTN.Text = "Quit"
        Me.QuitBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Wingdings", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 53)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ViBE KeyRing"
        '
        'AccountNumberLabel
        '
        Me.AccountNumberLabel.AutoSize = True
        Me.AccountNumberLabel.Location = New System.Drawing.Point(68, 38)
        Me.AccountNumberLabel.Name = "AccountNumberLabel"
        Me.AccountNumberLabel.Size = New System.Drawing.Size(0, 13)
        Me.AccountNumberLabel.TabIndex = 5
        '
        'MoveUpBTN
        '
        Me.MoveUpBTN.Font = New System.Drawing.Font("Wingdings 3", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MoveUpBTN.Location = New System.Drawing.Point(315, 65)
        Me.MoveUpBTN.Name = "MoveUpBTN"
        Me.MoveUpBTN.Size = New System.Drawing.Size(22, 82)
        Me.MoveUpBTN.TabIndex = 6
        Me.MoveUpBTN.Text = "h"
        Me.MoveUpBTN.UseVisualStyleBackColor = True
        '
        'MoveDownBTN
        '
        Me.MoveDownBTN.Font = New System.Drawing.Font("Wingdings 3", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.MoveDownBTN.Location = New System.Drawing.Point(315, 183)
        Me.MoveDownBTN.Name = "MoveDownBTN"
        Me.MoveDownBTN.Size = New System.Drawing.Size(22, 82)
        Me.MoveDownBTN.TabIndex = 7
        Me.MoveDownBTN.Text = "i"
        Me.MoveDownBTN.UseVisualStyleBackColor = True
        '
        'KeyringForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 386)
        Me.Controls.Add(Me.MoveDownBTN)
        Me.Controls.Add(Me.MoveUpBTN)
        Me.Controls.Add(Me.AccountNumberLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuitBTN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KeyringForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyRing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ActionButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents QuitBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AccountNumberLabel As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents AddToKeyRingButton As Button
    Friend WithEvents MoveUpBTN As Button
    Friend WithEvents MoveDownBTN As Button
    Friend WithEvents AddHeader As Button
End Class
