Public Class userAdd
    Public SQL As New SQLControl

    Private Sub userAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadLoc()
        loadDept()
        LoadItems()
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

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        UserLogs.Show()
    End Sub

    Private Sub addLog_Click(sender As Object, e As EventArgs) Handles addLog.Click
        AddLogs()
    End Sub

    Private Sub AddLogs()
        SQL.AddParam("@action", txtBxAction.Text)
        SQL.AddParam("@paltag", cmbPT.SelectedValue)
        SQL.AddParam("@desc", cmbDesc.Text)
        SQL.AddParam("@loc", cmbLoc.SelectedValue)
        SQL.AddParam("@dept", cmbDep.SelectedValue)
        Dim timeStamp = DateTime.Now
        SQL.AddParam("@now", timeStamp)

        SQL.ExecQuery("INSERT INTO logs (log_action, log_paltag, log_desc, log_timestamp, log_loc, log_dept) VALUES (@action, @paltag, @desc, @now, @loc, @dept)")
        MsgBox("Item added to the database!")
        Me.Hide()
        UserLogs.Show()
        UserLogs.LoadLogs()
    End Sub
End Class