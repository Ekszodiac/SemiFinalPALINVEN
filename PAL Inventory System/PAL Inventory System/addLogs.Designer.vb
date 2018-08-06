<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addLogs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBxAction = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDesc = New System.Windows.Forms.TextBox()
        Me.cmbPT = New System.Windows.Forms.ComboBox()
        Me.cmbLoc = New System.Windows.Forms.ComboBox()
        Me.cmbDep = New System.Windows.Forms.ComboBox()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.addLog = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Action"
        '
        'txtBxAction
        '
        Me.txtBxAction.Location = New System.Drawing.Point(86, 5)
        Me.txtBxAction.Name = "txtBxAction"
        Me.txtBxAction.Size = New System.Drawing.Size(191, 20)
        Me.txtBxAction.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PAL Tag"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Location"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Department"
        '
        'cmbDesc
        '
        Me.cmbDesc.Location = New System.Drawing.Point(86, 67)
        Me.cmbDesc.Name = "cmbDesc"
        Me.cmbDesc.Size = New System.Drawing.Size(191, 20)
        Me.cmbDesc.TabIndex = 8
        '
        'cmbPT
        '
        Me.cmbPT.FormattingEnabled = True
        Me.cmbPT.Location = New System.Drawing.Point(86, 33)
        Me.cmbPT.Name = "cmbPT"
        Me.cmbPT.Size = New System.Drawing.Size(191, 21)
        Me.cmbPT.TabIndex = 9
        '
        'cmbLoc
        '
        Me.cmbLoc.FormattingEnabled = True
        Me.cmbLoc.Location = New System.Drawing.Point(86, 93)
        Me.cmbLoc.Name = "cmbLoc"
        Me.cmbLoc.Size = New System.Drawing.Size(191, 21)
        Me.cmbLoc.TabIndex = 11
        '
        'cmbDep
        '
        Me.cmbDep.FormattingEnabled = True
        Me.cmbDep.Location = New System.Drawing.Point(86, 125)
        Me.cmbDep.Name = "cmbDep"
        Me.cmbDep.Size = New System.Drawing.Size(191, 21)
        Me.cmbDep.TabIndex = 12
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(489, 368)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 13
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'addLog
        '
        Me.addLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addLog.Location = New System.Drawing.Point(408, 368)
        Me.addLog.Name = "addLog"
        Me.addLog.Size = New System.Drawing.Size(75, 23)
        Me.addLog.TabIndex = 14
        Me.addLog.Text = "Add"
        Me.addLog.UseVisualStyleBackColor = True
        '
        'addLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 403)
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
        Me.Name = "addLogs"
        Me.Text = "Add Logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBxAction As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmbPT As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDep As System.Windows.Forms.ComboBox
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents addLog As System.Windows.Forms.Button
End Class
