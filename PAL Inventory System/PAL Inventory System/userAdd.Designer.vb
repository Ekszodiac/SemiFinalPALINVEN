<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userAdd
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
        Me.addLog = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'addLog
        '
        Me.addLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addLog.Location = New System.Drawing.Point(500, 416)
        Me.addLog.Name = "addLog"
        Me.addLog.Size = New System.Drawing.Size(75, 23)
        Me.addLog.TabIndex = 26
        Me.addLog.Text = "Add"
        Me.addLog.UseVisualStyleBackColor = True
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(581, 416)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 25
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'cmbDep
        '
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.Location = New System.Drawing.Point(85, 132)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(201, 21)
        Me.cmbDep.TabIndex = 24
        '
        'cmbLoc
        '
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(85, 100)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(201, 21)
        Me.cmbLoc.TabIndex = 23
        '
        'cmbPT
        '
        Me.cmbPT.FormattingEnabled = True
        Me.cmbPT.Location = New System.Drawing.Point(85, 40)
        Me.cmbPT.Name = "cmbPT"
        Me.cmbPT.Size = New System.Drawing.Size(201, 21)
        Me.cmbPT.TabIndex = 22
        '
        'cmbDesc
        '
        Me.cmbDesc.Location = New System.Drawing.Point(85, 74)
        Me.cmbDesc.Name = "cmbDesc"
        Me.cmbDesc.Size = New System.Drawing.Size(201, 20)
        Me.cmbDesc.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "PAL Tag"
        '
        'txtBxAction
        '
        Me.txtBxAction.Location = New System.Drawing.Point(85, 12)
        Me.txtBxAction.Name = "txtBxAction"
        Me.txtBxAction.Size = New System.Drawing.Size(201, 20)
        Me.txtBxAction.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Action"
        '
        'userAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.addLog)
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
        Me.Name = "userAdd"
        Me.Text = "User Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addLog As System.Windows.Forms.Button
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
End Class
