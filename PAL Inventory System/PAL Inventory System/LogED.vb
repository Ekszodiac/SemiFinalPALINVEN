Public Class LogED
    Public SQL As New SQLControl

    Private Sub LogED_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadDept()
        LoadItems()
        loadLoc()
        cmbLoc.SelectedValue = -1
        cmbDep.SelectedValue = -1
        cmbPT.SelectedValue = -1
    End Sub


    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles editBut.Click
        txtBxAction.Enabled = True
        cmbDep.Enabled = True
        cmbDesc.Enabled = True
        cmbLoc.Enabled = True
        cmbPT.Enabled = True
        editBut.Visible = False
        delLog.Enabled = False
        saveBut.Visible = True
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        Logs.Show()
        Logs.LoadLogs()
    End Sub

    Private Sub loadLoc()
        cmbLoc.Items.Clear()
        SQL.ExecQuery("SELECT * FROM location;")

        cmbLoc.DataSource = SQL.DBDT
        cmbLoc.DisplayMember = "location_name"
        cmbLoc.ValueMember = "location_name"
    End Sub

    Private Sub loadDept()
        cmbDep.Items.Clear()
        SQL.ExecQuery("SELECT * FROM department")

        cmbDep.DataSource = SQL.DBDT
        cmbDep.DisplayMember = "dept_name"
        cmbDep.ValueMember = "dept_name"
    End Sub

    Private Sub LoadItems()
        cmbPT.Items.Clear()
        SQL.ExecQuery("SELECT * FROM item")

        cmbPT.DataSource = SQL.DBDT
        cmbPT.DisplayMember = "item_paltag"
        cmbPT.ValueMember = "item_paltag"
    End Sub

    Private Sub saveBut_Click(sender As Object, e As EventArgs) Handles saveBut.Click
        SQL.AddParam("@logid", idBox.Text)
        SQL.AddParam("@action", txtBxAction.Text)
        SQL.AddParam("@paltag", cmbPT.SelectedValue)
        SQL.AddParam("@desc", cmbDesc.Text)
        SQL.AddParam("@loc", cmbLoc.SelectedText)
        SQL.AddParam("@dept", cmbDep.SelectedText)
        Dim timeStamp = DateTime.Now
        SQL.AddParam("@now", timeStamp)

        SQL.ExecQuery("UPDATE LOGS set log_action=@action, log_paltag=@paltag, log_desc=@desc, log_timestamp=@now, log_loc=@loc, log_dept=dept where log_id=@logid;")

        saveBut.Visible = False
        editBut.Visible = True

        txtBxAction.Enabled = False
        cmbPT.Enabled = False
        cmbDesc.Enabled = False
        cmbLoc.Enabled = False
        cmbDep.Enabled = False
        delLog.Enabled = True
    End Sub
End Class