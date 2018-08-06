<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addUserInven
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.acqBox = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.addInvenBut = New System.Windows.Forms.Button()
        Me.remTxtbx = New System.Windows.Forms.TextBox()
        Me.snTxtbx = New System.Windows.Forms.TextBox()
        Me.descTxtbx = New System.Windows.Forms.TextBox()
        Me.ptTxtbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.acqBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.closeBut)
        Me.Panel1.Controls.Add(Me.addInvenBut)
        Me.Panel1.Controls.Add(Me.remTxtbx)
        Me.Panel1.Controls.Add(Me.snTxtbx)
        Me.Panel1.Controls.Add(Me.descTxtbx)
        Me.Panel1.Controls.Add(Me.ptTxtbx)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 463)
        Me.Panel1.TabIndex = 1
        '
        'acqBox
        '
        Me.acqBox.Location = New System.Drawing.Point(183, 150)
        Me.acqBox.Name = "acqBox"
        Me.acqBox.Size = New System.Drawing.Size(200, 20)
        Me.acqBox.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Acquisition Date"
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(663, 437)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 13
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'addInvenBut
        '
        Me.addInvenBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addInvenBut.Location = New System.Drawing.Point(582, 437)
        Me.addInvenBut.Name = "addInvenBut"
        Me.addInvenBut.Size = New System.Drawing.Size(75, 23)
        Me.addInvenBut.TabIndex = 12
        Me.addInvenBut.Text = "Add"
        Me.addInvenBut.UseVisualStyleBackColor = True
        '
        'remTxtbx
        '
        Me.remTxtbx.Location = New System.Drawing.Point(183, 118)
        Me.remTxtbx.Name = "remTxtbx"
        Me.remTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.remTxtbx.TabIndex = 9
        '
        'snTxtbx
        '
        Me.snTxtbx.Location = New System.Drawing.Point(183, 82)
        Me.snTxtbx.Name = "snTxtbx"
        Me.snTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.snTxtbx.TabIndex = 8
        '
        'descTxtbx
        '
        Me.descTxtbx.Location = New System.Drawing.Point(183, 45)
        Me.descTxtbx.Name = "descTxtbx"
        Me.descTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.descTxtbx.TabIndex = 7
        '
        'ptTxtbx
        '
        Me.ptTxtbx.Location = New System.Drawing.Point(183, 8)
        Me.ptTxtbx.Name = "ptTxtbx"
        Me.ptTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.ptTxtbx.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serial Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAL Tag"
        '
        'addUserInven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addUserInven"
        Me.Text = "User Add Item"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents acqBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents addInvenBut As System.Windows.Forms.Button
    Friend WithEvents remTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents snTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents descTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ptTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
