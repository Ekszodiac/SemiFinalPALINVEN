<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsForm
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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.closeBut = New System.Windows.Forms.Button()
        Me.delBut = New System.Windows.Forms.Button()
        Me.addBut = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.AllowDrop = True
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(13, 13)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(679, 380)
        Me.dgv1.TabIndex = 0
        '
        'closeBut
        '
        Me.closeBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBut.Location = New System.Drawing.Point(617, 420)
        Me.closeBut.Name = "closeBut"
        Me.closeBut.Size = New System.Drawing.Size(75, 23)
        Me.closeBut.TabIndex = 1
        Me.closeBut.Text = "Close"
        Me.closeBut.UseVisualStyleBackColor = True
        '
        'delBut
        '
        Me.delBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delBut.Location = New System.Drawing.Point(536, 419)
        Me.delBut.Name = "delBut"
        Me.delBut.Size = New System.Drawing.Size(75, 23)
        Me.delBut.TabIndex = 2
        Me.delBut.Text = "Delete"
        Me.delBut.UseVisualStyleBackColor = True
        '
        'addBut
        '
        Me.addBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addBut.Location = New System.Drawing.Point(455, 419)
        Me.addBut.Name = "addBut"
        Me.addBut.Size = New System.Drawing.Size(75, 23)
        Me.addBut.TabIndex = 3
        Me.addBut.Text = "Add"
        Me.addBut.UseVisualStyleBackColor = True
        '
        'AccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.addBut)
        Me.Controls.Add(Me.delBut)
        Me.Controls.Add(Me.closeBut)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "AccountsForm"
        Me.Text = "AccountsForm"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents closeBut As System.Windows.Forms.Button
    Friend WithEvents delBut As System.Windows.Forms.Button
    Friend WithEvents addBut As System.Windows.Forms.Button
End Class
