Public Class UserForm
    Public SQL As New SQLControl

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadInven()
    End Sub

    Public Sub LoadInven(Optional Query As String = "")
        dgv3.Columns.Clear()
        If Query = "" Then
            SQL.ExecQuery("SELECT item_id AS 'ID',item_description AS 'DESCRIPTION', item_paltag AS PALTAG, item_sn as SERIAL, item_acqdate AS ACQUISITION, item_remarks as REMARKS, item_timestamp AS 'TIMESTAMP' FROM item;")
        Else
            Sql.ExecQuery(Query)
        End If

        If Sql.HasException Then Exit Sub
        dgv3.DataSource = SQL.DBDT
        dgv3.Columns("ID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("DESCRIPTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("SERIAL").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("ACQUISITION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("REMARKS").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.ReadOnly = False
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        addUserInven.Show()
    End Sub


    Private Sub signOutBut_Click(sender As Object, e As EventArgs) Handles signOutBut.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to Sign Out?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub


    Private Sub printBut_Click(sender As Object, e As EventArgs) Handles printBut.Click
        Me.Hide()
        userPrint.Show()
    End Sub

    Private Sub logBut_Click(sender As Object, e As EventArgs) Handles logBut.Click
        Me.Hide()
        UserLogs.Show()
    End Sub
End Class