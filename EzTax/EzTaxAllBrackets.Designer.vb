<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EzTaxAllBrackets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EzTaxAllBrackets))
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.MainTXB = New System.Windows.Forms.TextBox()
        Me.LocalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EzTaxTopLabel
        '
        Me.EzTaxTopLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.EzTaxTopLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EzTaxTopLabel.ForeColor = System.Drawing.Color.White
        Me.EzTaxTopLabel.Location = New System.Drawing.Point(0, 0)
        Me.EzTaxTopLabel.Name = "EzTaxTopLabel"
        Me.EzTaxTopLabel.Size = New System.Drawing.Size(431, 22)
        Me.EzTaxTopLabel.TabIndex = 15
        Me.EzTaxTopLabel.Text = "All Brackets"
        Me.EzTaxTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(407, 4)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 685)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(407, 4)
        Me.Label3.TabIndex = 20
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKBTN
        '
        Me.OKBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKBTN.Image = CType(resources.GetObject("OKBTN.Image"), System.Drawing.Image)
        Me.OKBTN.Location = New System.Drawing.Point(344, 692)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 22
        Me.OKBTN.Text = "Close"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'MainTXB
        '
        Me.MainTXB.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainTXB.Location = New System.Drawing.Point(12, 66)
        Me.MainTXB.Multiline = True
        Me.MainTXB.Name = "MainTXB"
        Me.MainTXB.ReadOnly = True
        Me.MainTXB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MainTXB.Size = New System.Drawing.Size(407, 616)
        Me.MainTXB.TabIndex = 24
        Me.MainTXB.Text = "-[NORTH OSTEN]----------------------------"
        '
        'LocalLabel
        '
        Me.LocalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalLabel.ForeColor = System.Drawing.Color.Black
        Me.LocalLabel.Location = New System.Drawing.Point(12, 33)
        Me.LocalLabel.Name = "LocalLabel"
        Me.LocalLabel.Size = New System.Drawing.Size(407, 22)
        Me.LocalLabel.TabIndex = 18
        Me.LocalLabel.Text = "Tax Calculator Information"
        Me.LocalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EzTaxAllBrackets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(431, 727)
        Me.Controls.Add(Me.MainTXB)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LocalLabel)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EzTaxAllBrackets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzTaxAllBrackets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EzTaxTopLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OKBTN As Button
    Friend WithEvents MainTXB As TextBox
    Friend WithEvents LocalLabel As Label
End Class
