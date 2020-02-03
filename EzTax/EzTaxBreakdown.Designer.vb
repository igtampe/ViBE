<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EzTaxBreakdown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EzTaxBreakdown))
        Me.EzTaxTopLabel = New System.Windows.Forms.Label()
        Me.LocalTaxLBL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OKBTN = New System.Windows.Forms.Button()
        Me.LocalDetailsTXB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LocalLabel = New System.Windows.Forms.Label()
        Me.ServerDetailsTXB = New System.Windows.Forms.TextBox()
        Me.ServerTaxLBL = New System.Windows.Forms.Label()
        Me.ServerLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EzTaxTopLabel
        '
        Me.EzTaxTopLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.EzTaxTopLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EzTaxTopLabel.ForeColor = System.Drawing.Color.White
        Me.EzTaxTopLabel.Location = New System.Drawing.Point(0, 0)
        Me.EzTaxTopLabel.Name = "EzTaxTopLabel"
        Me.EzTaxTopLabel.Size = New System.Drawing.Size(598, 22)
        Me.EzTaxTopLabel.TabIndex = 15
        Me.EzTaxTopLabel.Text = "Income/Tax Breakdown"
        Me.EzTaxTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LocalTaxLBL
        '
        Me.LocalTaxLBL.BackColor = System.Drawing.Color.DarkGray
        Me.LocalTaxLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalTaxLBL.Location = New System.Drawing.Point(12, 55)
        Me.LocalTaxLBL.Name = "LocalTaxLBL"
        Me.LocalTaxLBL.Size = New System.Drawing.Size(280, 34)
        Me.LocalTaxLBL.TabIndex = 17
        Me.LocalTaxLBL.Text = "5,000,000,000,000p"
        Me.LocalTaxLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 4)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 4)
        Me.Label3.TabIndex = 20
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OKBTN
        '
        Me.OKBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OKBTN.Image = CType(resources.GetObject("OKBTN.Image"), System.Drawing.Image)
        Me.OKBTN.Location = New System.Drawing.Point(511, 432)
        Me.OKBTN.Name = "OKBTN"
        Me.OKBTN.Size = New System.Drawing.Size(75, 23)
        Me.OKBTN.TabIndex = 22
        Me.OKBTN.Text = "Close"
        Me.OKBTN.UseVisualStyleBackColor = True
        '
        'LocalDetailsTXB
        '
        Me.LocalDetailsTXB.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalDetailsTXB.Location = New System.Drawing.Point(12, 105)
        Me.LocalDetailsTXB.Multiline = True
        Me.LocalDetailsTXB.Name = "LocalDetailsTXB"
        Me.LocalDetailsTXB.ReadOnly = True
        Me.LocalDetailsTXB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LocalDetailsTXB.Size = New System.Drawing.Size(280, 304)
        Me.LocalDetailsTXB.TabIndex = 24
        Me.LocalDetailsTXB.Text = "-[NORTH OSTEN]----------------------------"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(4, 380)
        Me.Label1.TabIndex = 26
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LocalLabel
        '
        Me.LocalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalLabel.ForeColor = System.Drawing.Color.Black
        Me.LocalLabel.Location = New System.Drawing.Point(12, 33)
        Me.LocalLabel.Name = "LocalLabel"
        Me.LocalLabel.Size = New System.Drawing.Size(280, 22)
        Me.LocalLabel.TabIndex = 18
        Me.LocalLabel.Text = "Updated Tax"
        Me.LocalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ServerDetailsTXB
        '
        Me.ServerDetailsTXB.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerDetailsTXB.Location = New System.Drawing.Point(308, 103)
        Me.ServerDetailsTXB.Multiline = True
        Me.ServerDetailsTXB.Name = "ServerDetailsTXB"
        Me.ServerDetailsTXB.ReadOnly = True
        Me.ServerDetailsTXB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ServerDetailsTXB.Size = New System.Drawing.Size(280, 304)
        Me.ServerDetailsTXB.TabIndex = 27
        Me.ServerDetailsTXB.Text = "help   :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "me     :"
        '
        'ServerTaxLBL
        '
        Me.ServerTaxLBL.BackColor = System.Drawing.Color.DarkGray
        Me.ServerTaxLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerTaxLBL.Location = New System.Drawing.Point(306, 55)
        Me.ServerTaxLBL.Name = "ServerTaxLBL"
        Me.ServerTaxLBL.Size = New System.Drawing.Size(280, 34)
        Me.ServerTaxLBL.TabIndex = 28
        Me.ServerTaxLBL.Text = "5,000,000,000,000p"
        Me.ServerTaxLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ServerLabel
        '
        Me.ServerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerLabel.ForeColor = System.Drawing.Color.Black
        Me.ServerLabel.Location = New System.Drawing.Point(305, 33)
        Me.ServerLabel.Name = "ServerLabel"
        Me.ServerLabel.Size = New System.Drawing.Size(280, 22)
        Me.ServerLabel.TabIndex = 29
        Me.ServerLabel.Text = "Current Tax"
        Me.ServerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(280, 4)
        Me.Label6.TabIndex = 30
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(308, 415)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(280, 4)
        Me.Label7.TabIndex = 31
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EzTaxBreakdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(598, 467)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ServerLabel)
        Me.Controls.Add(Me.ServerTaxLBL)
        Me.Controls.Add(Me.ServerDetailsTXB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LocalDetailsTXB)
        Me.Controls.Add(Me.OKBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LocalLabel)
        Me.Controls.Add(Me.LocalTaxLBL)
        Me.Controls.Add(Me.EzTaxTopLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EzTaxBreakdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EzTaxBreakdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EzTaxTopLabel As Label
    Friend WithEvents LocalTaxLBL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OKBTN As Button
    Friend WithEvents LocalDetailsTXB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LocalLabel As Label
    Friend WithEvents ServerDetailsTXB As TextBox
    Friend WithEvents ServerTaxLBL As Label
    Friend WithEvents ServerLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
