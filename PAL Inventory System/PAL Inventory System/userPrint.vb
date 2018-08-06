Public Class userPrint
    Public SQL As New SQLControl

    Private Sub userPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadItems()
    End Sub

    Private Sub loadItems()
        dgv2.Columns.Clear()
        SQL.ExecQuery("SELECT item_id AS 'ID',item_description AS 'DESCRIPTION', item_paltag AS PALTAG, item_sn as SERIAL, item_acqdate AS ACQUISITION, item_remarks as REMARKS, item_timestamp AS 'TIMESTAMP' FROM item;")

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        checkCol.HeaderText = "Checkbox"
        checkCol.Name = "CheckCol"

        dgv2.Columns.Add(checkCol)
        dgv2.DataSource = SQL.DBDT
        dgv2.ReadOnly = False

        dgv2.Columns("checkCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("ID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("DESCRIPTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("SERIAL").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("ACQUISITION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("REMARKS").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("TIMESTAMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub

    Private Sub printBut_Click(sender As Object, e As EventArgs) Handles print.Click
        If dgv2.Rows.Count > 0 Then
            If dgv2.Rows(dgv2.CurrentRow.Index).Cells(0).Value = True Then

                For Each row As DataGridViewRow In dgv2.Rows
                    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CheckCol").Value)
                    If isSelected Then
                        printReports.Show()
                    End If
                Next
            Else
                MsgBox("Please select a row to print!")
            End If
        Else
            MsgBox("Data is Empty!")
        End If
       
    End Sub

    Private Sub cancelBut_Click(sender As Object, e As EventArgs) Handles cancelBut.Click
        Me.Hide()
        UserForm.Show()
        UserForm.LoadInven()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        dgv2.Columns.Clear()
        SQL.AddParam("@item", "%" & txtbxSearch.Text & "%")
        SQL.ExecQuery("SELECT log_action as 'ACTION', log_paltag AS 'PALTAG', log_userID as 'USER', log_timestamp as 'TIMESTAMP', log_loc as 'LOCATION', log_dept AS 'DEPARTMENT' FROM logs WHERE log_action LIKE @item OR log_paltag LIKE @item OR log_userID LIKE @item OR log_loc LIKE @item OR log_dept LIKE @item;")

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        checkCol.HeaderText = "Checkbox"
        checkCol.Name = "CheckCol"

        dgv2.Columns.Add(checkCol)
        dgv2.DataSource = SQL.DBDT
        dgv2.ReadOnly = False

        dgv2.Columns("checkCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("ACTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("USER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("TIMESTAMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("LOCATION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv2.Columns("DEPARTMENT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub
End Class