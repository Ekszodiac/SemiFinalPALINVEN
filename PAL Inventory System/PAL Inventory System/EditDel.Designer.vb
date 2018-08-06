<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDel
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
        Me.saveBut = New System.Windows.Forms.Button()
        Me.acqBox = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.remTxtbx = New System.Windows.Forms.TextBox()
        Me.snTxtbx = New System.Windows.Forms.TextBox()
        Me.descTxtbx = New System.Windows.Forms.TextBox()
        Me.ptTxtbx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.delInvenBut = New System.Windows.Forms.Button()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.editInvenBut = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.saveBut)
        Me.Panel1.Controls.Add(Me.acqBox)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.remTxtbx)
        Me.Panel1.Controls.Add(Me.snTxtbx)
        Me.Panel1.Controls.Add(Me.descTxtbx)
        Me.Panel1.Controls.Add(Me.ptTxtbx)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.delInvenBut)
        Me.Panel1.Controls.Add(Me.closeBut)
        Me.Panel1.Controls.Add(Me.editInvenBut)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 438)
        Me.Panel1.TabIndex = 1
        '
        'saveBut
        '
        Me.saveBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveBut.Location = New System.Drawing.Point(514, 412)
        Me.saveBut.Name = "saveBut"
        Me.saveBut.Size = New System.Drawing.Size(75, 23)
        Me.saveBut.TabIndex = 26
        Me.saveBut.Text = "Save"
        Me.saveBut.UseVisualStyleBackColor = True
        Me.saveBut.Visible = False
        '
        'acqBox
        '
        Me.acqBox.Enabled = False
        Me.acqBox.Location = New System.Drawing.Point(173, 144)
        Me.acqBox.Name = "acqBox"
        Me.acqBox.Size = New System.Drawing.Size(200, 20)
        Me.acqBox.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Acquisition Date"
        '
        'remTxtbx
        '
        Me.remTxtbx.Enabled = False
        Me.remTxtbx.Location = New System.Drawing.Point(173, 112)
        Me.remTxtbx.MaxLength = 300
        Me.remTxtbx.Name = "remTxtbx"
        Me.remTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.remTxtbx.TabIndex = 23
        '
        'snTxtbx
        '
        Me.snTxtbx.Enabled = False
        Me.snTxtbx.Location = New System.Drawing.Point(173, 76)
        Me.snTxtbx.MaxLength = 50
        Me.snTxtbx.Name = "snTxtbx"
        Me.snTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.snTxtbx.TabIndex = 22
        '
        'descTxtbx
        '
        Me.descTxtbx.Enabled = False
        Me.descTxtbx.Location = New System.Drawing.Point(173, 39)
        Me.descTxtbx.MaxLength = 300
        Me.descTxtbx.Name = "descTxtbx"
        Me.descTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.descTxtbx.TabIndex = 21
        '
        'ptTxtbx
        '
        Me.ptTxtbx.Enabled = False
        Me.ptTxtbx.Location = New System.Drawing.Point(173, 2)
        Me.ptTxtbx.MaxLength = 50
        Me.ptTxtbx.Name = "ptTxtbx"
        Me.ptTxtbx.Size = New System.Drawing.Size(200, 20)
        Me.ptTxtbx.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Serial Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PAL Tag"
        '
        'delInvenBut
        '
        Me.delInvenBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delInvenBut.Location = New System.Drawing.Point(595, 412)
        Me.delInvenBut.Name = "delInvenBut"
        Me.delInvenBut.Size = New System.Drawing.Size(75, 23)
        Me.delInvenBut.TabIndex = 14
        Me.delInvenBut.Text = "Delete"
        Me.delInvenBut.UseVisualStyleBackColor = True
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(676, 412)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 13
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'editInvenBut
        '
        Me.editInvenBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editInvenBut.Location = New System.Drawing.Point(514, 412)
        Me.editInvenBut.Name = "editInvenBut"
        Me.editInvenBut.Size = New System.Drawing.Size(75, 23)
        Me.editInvenBut.TabIndex = 12
        Me.editInvenBut.Text = "Edit"
        Me.editInvenBut.UseVisualStyleBackColor = True
        '
        'EditDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDel"
        Me.Text = "Edit and Delete"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents editInvenBut As System.Windows.Forms.Button
    Friend WithEvents delInvenBut As System.Windows.Forms.Button
    Friend WithEvents acqBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents remTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents snTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents descTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents ptTxtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents saveBut As System.Windows.Forms.Button
End Class
