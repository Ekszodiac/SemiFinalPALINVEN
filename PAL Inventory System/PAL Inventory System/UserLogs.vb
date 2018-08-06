Public Class UserLogs
    Public SQL As New SQLControl

    Private Sub UserLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadLogs()
    End Sub

    Public Sub LoadLogs()
        dgv3.Columns.Clear()
        SQL.ExecQuery("SELECT log_ID AS 'ID',log_action as 'ACTION', log_paltag AS 'PALTAG', log_desc AS 'DESCRIPTION', log_timestamp as 'TIMESTAMP', log_loc as 'LOCATION', log_dept AS 'DEPARTMENT' FROM logs")

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkCol.HeaderText = "CheckBox"
        checkCol.Name = "CheckCol"

        dgv3.Columns.Add(checkCol)
        dgv3.DataSource = SQL.DBDT
        dgv3.ReadOnly = False

        dgv3.Columns("checkCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("ID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("ACTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("TIMESTAMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("LOCATION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv3.Columns("DEPARTMENT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellContentClick
        If e.ColumnIndex = dgv3.Columns("CheckCol").Index Then
            DataGridViewCheckBoxColumn_Uncheck()
            Dim cell As DataGridViewCheckBoxCell = dgv3.Rows(e.RowIndex).Cells("CheckCol")
            cell.Value = cell.TrueValue
        End If
    End Sub

    Private Sub DataGridViewCheckBoxColumn_Uncheck()
        For Each row As DataGridViewRow In dgv3.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells("CheckCol")
            cell.Value = cell.FalseValue
        Next
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        UserForm.Show()
        UserForm.LoadInven()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        userAdd.Show()
    End Sub

    Private Sub editdelBut_Click(sender As Object, e As EventArgs)
        If dgv3.Rows(dgv3.CurrentRow.Index).Cells(0).Value = True Then

            For Each row As DataGridViewRow In dgv3.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CheckCol").Value)
                If isSelected Then
                    Dim ask As MsgBoxResult = MsgBox("Are you sure you want to delete this log?", MsgBoxStyle.YesNo)
                    If ask = MsgBoxResult.Yes Then
                        SQL.AddParam("@delID", row.Cells("ID").Value.ToString())
                        SQL.ExecQuery("DELETE FROM logs WHERE log_id=@delID;")

                        MsgBox("The Selected log has been successfully deleted!")
                        LoadLogs()
                    End If
                End If
            Next
        Else
            MsgBox("Please select a row to edit or delete!")
        End If
    End Sub
End Class