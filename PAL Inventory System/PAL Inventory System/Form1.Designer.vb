<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.exitBut = New System.Windows.Forms.Button()
        Me.loginbut = New System.Windows.Forms.Button()
        Me.pwbox = New System.Windows.Forms.TextBox()
        Me.idbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ISDLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(790, 153)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.exitBut)
        Me.Panel1.Controls.Add(Me.loginbut)
        Me.Panel1.Controls.Add(Me.pwbox)
        Me.Panel1.Controls.Add(Me.idbox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(283, 324)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 131)
        Me.Panel1.TabIndex = 2
        '
        'exitBut
        '
        Me.exitBut.BackColor = System.Drawing.Color.Maroon
        Me.exitBut.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.exitBut.FlatAppearance.BorderSize = 0
        Me.exitBut.ForeColor = System.Drawing.Color.White
        Me.exitBut.Location = New System.Drawing.Point(17, 81)
        Me.exitBut.Name = "exitBut"
        Me.exitBut.Size = New System.Drawing.Size(132, 38)
        Me.exitBut.TabIndex = 10
        Me.exitBut.Text = "Exit"
        Me.exitBut.UseVisualStyleBackColor = False
        '
        'loginbut
        '
        Me.loginbut.BackColor = System.Drawing.Color.Khaki
        Me.loginbut.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.loginbut.FlatAppearance.BorderSize = 0
        Me.loginbut.Location = New System.Drawing.Point(180, 81)
        Me.loginbut.Name = "loginbut"
        Me.loginbut.Size = New System.Drawing.Size(132, 38)
        Me.loginbut.TabIndex = 9
        Me.loginbut.Text = "Login"
        Me.loginbut.UseVisualStyleBackColor = False
        '
        'pwbox
        '
        Me.pwbox.Location = New System.Drawing.Point(134, 38)
        Me.pwbox.Name = "pwbox"
        Me.pwbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwbox.Size = New System.Drawing.Size(197, 20)
        Me.pwbox.TabIndex = 8
        '
        'idbox
        '
        Me.idbox.Location = New System.Drawing.Point(134, 12)
        Me.idbox.Name = "idbox"
        Me.idbox.Size = New System.Drawing.Size(197, 20)
        Me.idbox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Number"
        '
        'ISDLabel
        '
        Me.ISDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ISDLabel.AutoSize = True
        Me.ISDLabel.Font = New System.Drawing.Font("Helvetica", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISDLabel.ForeColor = System.Drawing.Color.White
        Me.ISDLabel.Location = New System.Drawing.Point(50, 268)
        Me.ISDLabel.Name = "ISDLabel"
        Me.ISDLabel.Size = New System.Drawing.Size(780, 46)
        Me.ISDLabel.TabIndex = 3
        Me.ISDLabel.Text = "INFORMATION SYSTEMS DEPARTMENT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.ISDLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "PAL Inventory System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents loginbut As System.Windows.Forms.Button
    Friend WithEvents pwbox As System.Windows.Forms.TextBox
    Friend WithEvents idbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ISDLabel As System.Windows.Forms.Label
    Friend WithEvents exitBut As System.Windows.Forms.Button

End Class
