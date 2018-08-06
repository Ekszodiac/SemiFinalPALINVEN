Imports System.Data.SqlClient

Public Class addInven
    Public SQL As New SQLControl

    Private Sub AddItem()
        SQL.AddParam("@paltag", ptTxtbx.Text)
        SQL.AddParam("@desc", descTxtbx.Text)
        SQL.AddParam("@sn", snTxtbx.Text)
        SQL.AddParam("@remarks", remTxtbx.Text)
        SQL.AddParam("@acq", acqBox.Value.Date)
        Dim timeStamp = DateTime.Now
        SQL.AddParam("@now", timeStamp)
        If SQL.HasException Then Exit Sub

        SQL.ExecQuery("INSERT INTO  item (item_paltag, item_description, item_sn, item_acqdate, item_remarks, item_timestamp) VALUES (@paltag, @desc, @sn, @acq, @remarks, @now);")
        MsgBox("Item added to the database!")
        Me.Hide()
        AdminForm.Show()
        AdminForm.LoadInven()
        If SQL.HasException Then Exit Sub
    End Sub

    'Private Sub loadDept()
    '    deptCmb.Items.Clear()
    '    SQL.ExecQuery("SELECT * FROM department;")
    '    SQL.DBDA.Fill(SQL.DBDT)
    '    deptCmb.ValueMember = "dept_name"
    '    deptCmb.DisplayMember = "dept_name"
    '    deptCmb.DataSource = SQL.DBDT
    'End Sub

    Private Sub addInven_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub addInvenBut_Click(sender As Object, e As EventArgs) Handles addInvenBut.Click
        AddItem()
        ptTxtbx.Text = ""
        descTxtbx.Text = ""
        snTxtbx.Text = ""
        remTxtbx.Text = ""        
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        AdminForm.Show()
        AdminForm.LoadInven()
    End Sub

End Class