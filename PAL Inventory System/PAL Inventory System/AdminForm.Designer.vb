<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.logBtn = New System.Windows.Forms.Button()
        Me.actmgmtBut = New System.Windows.Forms.Button()
        Me.signOutBut = New System.Windows.Forms.Button()
        Me.printBut = New System.Windows.Forms.Button()
        Me.editdelBut = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.searchbut = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.logBtn)
        Me.Panel1.Controls.Add(Me.actmgmtBut)
        Me.Panel1.Controls.Add(Me.signOutBut)
        Me.Panel1.Controls.Add(Me.printBut)
        Me.Panel1.Controls.Add(Me.editdelBut)
        Me.Panel1.Controls.Add(Me.addBtn)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 89)
        Me.Panel1.TabIndex = 0
        '
        'logBtn
        '
        Me.logBtn.BackColor = System.Drawing.SystemColors.Control
        Me.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logBtn.Location = New System.Drawing.Point(406, 3)
        Me.logBtn.Name = "logBtn"
        Me.logBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.logBtn.Size = New System.Drawing.Size(98, 83)
        Me.logBtn.TabIndex = 5
        Me.logBtn.Text = "LOGS"
        Me.logBtn.UseVisualStyleBackColor = False
        '
        'actmgmtBut
        '
        Me.actmgmtBut.BackColor = System.Drawing.SystemColors.Control
        Me.actmgmtBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.actmgmtBut.Location = New System.Drawing.Point(527, 3)
        Me.actmgmtBut.Name = "actmgmtBut"
        Me.actmgmtBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.actmgmtBut.Size = New System.Drawing.Size(98, 85)
        Me.actmgmtBut.TabIndex = 4
        Me.actmgmtBut.Text = "ACCOUNT MANAGEMENT"
        Me.actmgmtBut.UseVisualStyleBackColor = False
        '
        'signOutBut
        '
        Me.signOutBut.BackColor = System.Drawing.SystemColors.Control
        Me.signOutBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signOutBut.Location = New System.Drawing.Point(661, 3)
        Me.signOutBut.Name = "signOutBut"
        Me.signOutBut.Size = New System.Drawing.Size(98, 83)
        Me.signOutBut.TabIndex = 3
        Me.signOutBut.Text = "SIGN OUT"
        Me.signOutBut.UseVisualStyleBackColor = False
        '
        'printBut
        '
        Me.printBut.BackColor = System.Drawing.SystemColors.Control
        Me.printBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBut.Location = New System.Drawing.Point(275, 4)
        Me.printBut.Name = "printBut"
        Me.printBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.printBut.Size = New System.Drawing.Size(98, 85)
        Me.printBut.TabIndex = 2
        Me.printBut.Text = "PRINT"
        Me.printBut.UseVisualStyleBackColor = False
        '
        'editdelBut
        '
        Me.editdelBut.BackColor = System.Drawing.SystemColors.Control
        Me.editdelBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editdelBut.Location = New System.Drawing.Point(135, 3)
        Me.editdelBut.Name = "editdelBut"
        Me.editdelBut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.editdelBut.Size = New System.Drawing.Size(98, 85)
        Me.editdelBut.TabIndex = 1
        Me.editdelBut.Text = "EDIT/DELETE"
        Me.editdelBut.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.SystemColors.Control
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Location = New System.Drawing.Point(3, 4)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(98, 83)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "ADD "
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(13, 139)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(777, 264)
        Me.dgv1.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(605, 113)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 2
        '
        'searchbut
        '
        Me.searchbut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchbut.Location = New System.Drawing.Point(715, 111)
        Me.searchbut.Name = "searchbut"
        Me.searchbut.Size = New System.Drawing.Size(75, 23)
        Me.searchbut.TabIndex = 3
        Me.searchbut.Text = "Search"
        Me.searchbut.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.searchbut)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents signOutBut As System.Windows.Forms.Button
    Friend WithEvents printBut As System.Windows.Forms.Button
    Friend WithEvents editdelBut As System.Windows.Forms.Button
    Friend WithEvents actmgmtBut As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents logBtn As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents searchbut As System.Windows.Forms.Button
End Class
