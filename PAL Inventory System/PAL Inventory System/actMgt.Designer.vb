<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actMgt
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
        Me.addAcc = New System.Windows.Forms.Button()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameTxtBx = New System.Windows.Forms.TextBox()
        Me.idTxtBx = New System.Windows.Forms.TextBox()
        Me.pwTxtBx = New System.Windows.Forms.TextBox()
        Me.saveBut = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'addAcc
        '
        Me.addAcc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addAcc.Location = New System.Drawing.Point(608, 408)
        Me.addAcc.Name = "addAcc"
        Me.addAcc.Size = New System.Drawing.Size(75, 23)
        Me.addAcc.TabIndex = 2
        Me.addAcc.Text = "Add Acount"
        Me.addAcc.UseVisualStyleBackColor = True
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(689, 408)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 4
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'nameTxtBx
        '
        Me.nameTxtBx.Enabled = False
        Me.nameTxtBx.Location = New System.Drawing.Point(123, 12)
        Me.nameTxtBx.Name = "nameTxtBx"
        Me.nameTxtBx.Size = New System.Drawing.Size(162, 20)
        Me.nameTxtBx.TabIndex = 8
        '
        'idTxtBx
        '
        Me.idTxtBx.Enabled = False
        Me.idTxtBx.Location = New System.Drawing.Point(123, 42)
        Me.idTxtBx.Name = "idTxtBx"
        Me.idTxtBx.Size = New System.Drawing.Size(162, 20)
        Me.idTxtBx.TabIndex = 9
        '
        'pwTxtBx
        '
        Me.pwTxtBx.Enabled = False
        Me.pwTxtBx.Location = New System.Drawing.Point(123, 102)
        Me.pwTxtBx.Name = "pwTxtBx"
        Me.pwTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwTxtBx.Size = New System.Drawing.Size(162, 20)
        Me.pwTxtBx.TabIndex = 10
        '
        'saveBut
        '
        Me.saveBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveBut.Location = New System.Drawing.Point(608, 408)
        Me.saveBut.Name = "saveBut"
        Me.saveBut.Size = New System.Drawing.Size(75, 23)
        Me.saveBut.TabIndex = 11
        Me.saveBut.Text = "Save "
        Me.saveBut.UseVisualStyleBackColor = True
        Me.saveBut.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "User Type"
        '
        'cmb1
        '
        Me.cmb1.Enabled = False
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(123, 73)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(162, 21)
        Me.cmb1.TabIndex = 13
        '
        'actMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.saveBut)
        Me.Controls.Add(Me.pwTxtBx)
        Me.Controls.Add(Me.idTxtBx)
        Me.Controls.Add(Me.nameTxtBx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeBut)
        Me.Controls.Add(Me.addAcc)
        Me.Name = "actMgt"
        Me.Text = "Account Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addAcc As System.Windows.Forms.Button
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nameTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents idTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents pwTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents saveBut As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
End Class
