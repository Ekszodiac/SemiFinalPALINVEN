Public Class actMgt
    Public SQL As New SQLControl

    Private Sub actMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadTypes()
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        AccountsForm.Show()
    End Sub

    Private Sub addAcc_Click(sender As Object, e As EventArgs) Handles addAcc.Click        
        idTxtBx.Enabled = True
        nameTxtBx.Enabled = True
        pwTxtBx.Enabled = True
        cmb1.Enabled = True
        addAcc.Visible = False
        saveBut.Visible = True
    End Sub

    Private Sub saveBut_Click(sender As Object, e As EventArgs) Handles saveBut.Click
        SQL.AddParam("@name", nameTxtBx.Text)
        SQL.AddParam("@id", idTxtBx.Text)
        SQL.AddParam("@password", pwTxtBx.Text)
        SQL.AddParam("@type", cmb1.SelectedValue)

        Dim stringz = cmb1.SelectedValue

        If nameTxtBx.Text = "" Or idTxtBx.Text = "" Or pwTxtBx.Text = "" Then
            MsgBox("Please enter user input")
        Else
            SQL.ExecQuery("INSERT INTO pa_user (user_fname, user_idnum, user_password, user_type) VALUES (@name, @id, @password, @type)")
            MsgBox("User added to the database!")
            Me.Hide()
            AccountsForm.Show()
            AccountsForm.loadAcc()
            idTxtBx.Enabled = False
            nameTxtBx.Enabled = False
            pwTxtBx.Enabled = False
            cmb1.Enabled = False
            addAcc.Visible = True
            saveBut.Visible = False
        End If
    End Sub

    Public Sub loadTypes()
        cmb1.Items.Clear()
        SQL.ExecQuery("SELECT * FROM user_type;")

        cmb1.DataSource = SQL.DBDT
        cmb1.DisplayMember = "utype_name"
        cmb1.ValueMember = "utype_id"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idTxtBx.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class