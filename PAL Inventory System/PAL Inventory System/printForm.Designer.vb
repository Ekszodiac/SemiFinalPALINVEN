<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printForm
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
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.cancelBut = New System.Windows.Forms.Button()
        Me.printBut = New System.Windows.Forms.Button()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.Button()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(13, 40)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.Size = New System.Drawing.Size(632, 316)
        Me.dgv2.TabIndex = 0
        '
        'cancelBut
        '
        Me.cancelBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBut.Location = New System.Drawing.Point(570, 386)
        Me.cancelBut.Name = "cancelBut"
        Me.cancelBut.Size = New System.Drawing.Size(75, 23)
        Me.cancelBut.TabIndex = 1
        Me.cancelBut.Text = "Cancel"
        Me.cancelBut.UseVisualStyleBackColor = True
        '
        'printBut
        '
        Me.printBut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printBut.Location = New System.Drawing.Point(489, 385)
        Me.printBut.Name = "printBut"
        Me.printBut.Size = New System.Drawing.Size(75, 23)
        Me.printBut.TabIndex = 2
        Me.printBut.Text = "Print"
        Me.printBut.UseVisualStyleBackColor = True
        '
        'txtbxSearch
        '
        Me.txtbxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbxSearch.Location = New System.Drawing.Point(464, 14)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtbxSearch.TabIndex = 3
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(570, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(75, 23)
        Me.txtSearch.TabIndex = 4
        Me.txtSearch.Text = "Search"
        Me.txtSearch.UseVisualStyleBackColor = True
        '
        'printForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 421)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.printBut)
        Me.Controls.Add(Me.cancelBut)
        Me.Controls.Add(Me.dgv2)
        Me.Name = "printForm"
        Me.Text = "Print"
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents cancelBut As System.Windows.Forms.Button
    Friend WithEvents printBut As System.Windows.Forms.Button
    Friend WithEvents txtbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.Button
End Class
