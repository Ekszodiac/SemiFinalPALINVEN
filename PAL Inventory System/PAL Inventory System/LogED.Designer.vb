<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogED
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
        Me.delLog = New System.Windows.Forms.Button()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.cmbPT = New System.Windows.Forms.ComboBox()
        Me.cmbDesc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBxAction = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.editBut = New System.Windows.Forms.Button()
        Me.saveBut = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'delLog
        '
        Me.delLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delLog.Location = New System.Drawing.Point(475, 394)
        Me.delLog.Name = "delLog"
        Me.delLog.Size = New System.Drawing.Size(75, 23)
        Me.delLog.TabIndex = 26
        Me.delLog.Text = "Delete"
        Me.delLog.UseVisualStyleBackColor = True
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(556, 394)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 25
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'cmbDep
        '
        Me.cmbDep.Enabled = False
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.Location = New System.Drawing.Point(81, 153)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(171, 21)
        Me.cmbDep.TabIndex = 24
        '
        'cmbLoc
        '
        Me.cmbLoc.Enabled = False
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(81, 121)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(171, 21)
        Me.cmbLoc.TabIndex = 23
        '
        'cmbPT
        '
        Me.cmbPT.Enabled = False
        Me.cmbPT.FormattingEnabled = True
        Me.cmbPT.Location = New System.Drawing.Point(81, 61)
        Me.cmbPT.Name = "cmbPT"
        Me.cmbPT.Size = New System.Drawing.Size(171, 21)
        Me.cmbPT.TabIndex = 22
        '
        'cmbDesc
        '
        Me.cmbDesc.Enabled = False
        Me.cmbDesc.Location = New System.Drawing.Point(81, 95)
        Me.cmbDesc.Name = "cmbDesc"
        Me.cmbDesc.Size = New System.Drawing.Size(171, 20)
        Me.cmbDesc.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PAL Tag"
        '
        'txtBxAction
        '
        Me.txtBxAction.Enabled = False
        Me.txtBxAction.Location = New System.Drawing.Point(81, 33)
        Me.txtBxAction.Name = "txtBxAction"
        Me.txtBxAction.Size = New System.Drawing.Size(171, 20)
        Me.txtBxAction.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Action"
        '
        'editBut
        '
        Me.editBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBut.Location = New System.Drawing.Point(394, 394)
        Me.editBut.Name = "editBut"
        Me.editBut.Size = New System.Drawing.Size(75, 23)
        Me.editBut.TabIndex = 27
        Me.editBut.Text = "Edit"
        Me.editBut.UseVisualStyleBackColor = True
        '
        'saveBut
        '
        Me.saveBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveBut.Location = New System.Drawing.Point(394, 394)
        Me.saveBut.Name = "saveBut"
        Me.saveBut.Size = New System.Drawing.Size(75, 23)
        Me.saveBut.TabIndex = 28
        Me.saveBut.Text = "Save"
        Me.saveBut.UseVisualStyleBackColor = True
        Me.saveBut.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ID"
        '
        'idBox
        '
        Me.idBox.Enabled = False
        Me.idBox.Location = New System.Drawing.Point(81, 5)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(171, 20)
        Me.idBox.TabIndex = 30
        '
        'LogED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.saveBut)
        Me.Controls.Add(Me.editBut)
        Me.Controls.Add(Me.delLog)
        Me.Controls.Add(Me.closeBut)
        Me.Controls.Add(Me.cmbDep)
        Me.Controls.Add(Me.cmbLoc)
        Me.Controls.Add(Me.cmbPT)
        Me.Controls.Add(Me.cmbDesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBxAction)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LogED"
        Me.Text = "Edit / Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents delLog As System.Windows.Forms.Button
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPT As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBxAction As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents editBut As System.Windows.Forms.Button
    Friend WithEvents saveBut As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents idBox As System.Windows.Forms.TextBox
End Class
