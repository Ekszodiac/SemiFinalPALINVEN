<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.signOutBut = New System.Windows.Forms.Button()
        Me.printBut = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.logBut = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.logBut)
        Me.Panel1.Controls.Add(Me.signOutBut)
        Me.Panel1.Controls.Add(Me.printBut)
        Me.Panel1.Controls.Add(Me.addBtn)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 100)
        Me.Panel1.TabIndex = 0
        '
        'signOutBut
        '
        Me.signOutBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signOutBut.BackColor = System.Drawing.SystemColors.Control
        Me.signOutBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signOutBut.Location = New System.Drawing.Point(603, 8)
        Me.signOutBut.Name = "signOutBut"
        Me.signOutBut.Size = New System.Drawing.Size(180, 85)
        Me.signOutBut.TabIndex = 7
        Me.signOutBut.Text = "SIGN OUT"
        Me.signOutBut.UseVisualStyleBackColor = False
        '
        'printBut
        '
        Me.printBut.BackColor = System.Drawing.SystemColors.Control
        Me.printBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBut.Location = New System.Drawing.Point(201, 6)
        Me.printBut.Name = "printBut"
        Me.printBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.printBut.Size = New System.Drawing.Size(180, 85)
        Me.printBut.TabIndex = 6
        Me.printBut.Text = "PRINT"
        Me.printBut.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.SystemColors.Control
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Location = New System.Drawing.Point(15, 8)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(180, 83)
        Me.addBtn.TabIndex = 4
        Me.addBtn.Text = "ADD "
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'dgv3
        '
        Me.dgv3.AllowUserToAddRows = False
        Me.dgv3.AllowUserToDeleteRows = False
        Me.dgv3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(13, 120)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.ReadOnly = True
        Me.dgv3.Size = New System.Drawing.Size(785, 325)
        Me.dgv3.TabIndex = 1
        '
        'logBut
        '
        Me.logBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logBut.BackColor = System.Drawing.SystemColors.Control
        Me.logBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logBut.Location = New System.Drawing.Point(417, 7)
        Me.logBut.Name = "logBut"
        Me.logBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.logBut.Size = New System.Drawing.Size(180, 85)
        Me.logBut.TabIndex = 8
        Me.logBut.Text = "LOGS"
        Me.logBut.UseVisualStyleBackColor = False
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 457)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents signOutBut As System.Windows.Forms.Button
    Friend WithEvents printBut As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents logBut As System.Windows.Forms.Button
End Class
