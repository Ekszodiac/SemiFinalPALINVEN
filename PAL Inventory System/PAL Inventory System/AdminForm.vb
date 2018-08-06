Public Class AdminForm
    Public SQL As New SQLControl

    Public Sub LoadInven(Optional Query As String = "")
        dgv1.Columns.Clear()
        If Query = "" Then
            SQL.ExecQuery("SELECT item_id AS 'ID',item_description AS 'DESCRIPTION', item_paltag AS PALTAG, item_sn as SERIAL, item_acqdate AS ACQUISITION, item_remarks as REMARKS, item_timestamp AS 'TIMESTAMP' FROM item;")
        Else
            SQL.ExecQuery(Query)
        End If

        If SQL.HasException Then Exit Sub

        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkCol.HeaderText = "CheckBox"
        checkCol.Name = "CheckCol"

        dgv1.Columns.Add(checkCol)
        dgv1.DataSource = SQL.DBDT
        dgv1.Columns("CheckCol").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.Columns("ID").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.Columns("PALTAG").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.Columns("DESCRIPTION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.Columns("SERIAL").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.Columns("ACQUISITION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.Columns("REMARKS").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        dgv1.ReadOnly = False
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized 
        LoadInven()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        If e.ColumnIndex = dgv1.Columns("CheckCol").Index Then
            DataGridViewCheckBoxColumn_Uncheck()
            Dim cell As DataGridViewCheckBoxCell = dgv1.Rows(e.RowIndex).Cells("CheckCol")
            cell.Value = cell.TrueValue
        End If
    End Sub

    Private Sub DataGridViewCheckBoxColumn_Uncheck()
        For Each row As DataGridViewRow In dgv1.Rows
            Dim cell As DataGridViewCheckBoxCell = row.Cells("CheckCol")
            cell.Value = cell.FalseValue
        Next
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Me.Hide()
        addInven.Show()
    End Sub

    Private Sub editdelBut_Click(sender As Object, e As EventArgs) Handles editdelBut.Click
        If dgv1.Rows.Count > 0 Then
            If dgv1.Rows(dgv1.CurrentRow.Index).Cells(0).Value = True Then
                Me.Hide()
                EditDel.Show()

                For Each row As DataGridViewRow In dgv1.Rows
                    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CheckCol").Value)
                    If isSelected Then
                        EditDel.ptTxtbx.Text = row.Cells("PALTAG").Value.ToString()
                        EditDel.descTxtbx.Text = row.Cells("DESCRIPTION").Value.ToString()
                        EditDel.snTxtbx.Text = row.Cells("SERIAL").Value.ToString()
                        EditDel.remTxtbx.Text = row.Cells("REMARKS").Value.ToString()
                        EditDel.acqBox.Value = row.Cells("TIMESTAMP").Value
                    End If
                Next
            Else
                MsgBox("Please select a row to edit or delete!")
            End If
        Else
            MsgBox("Empty Data!")
        End If       
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
        printForm.Show()
    End Sub

    Private Sub logBtn_Click(sender As Object, e As EventArgs) Handles logBtn.Click
        Me.Hide()
        Logs.Show()
    End Sub

    Private Sub searchbut_Click(sender As Object, e As EventArgs) Handles searchbut.Click
        SQL.AddParam("@item", "%" & txtSearch.Text & "%")
        LoadInven("SELECT item_description AS 'DESCRIPTION', item_paltag AS PALTAG, item_sn as SERIAL, item_acqdate AS ACQUISITION, item_remarks as REMARKS, item_timestamp AS 'TIMESTAMP' FROM item WHERE item_description LIKE @item OR item_paltag LIKE @item OR item_sn LIKE @item OR item_remarks LIKE @item;")
    End Sub

    Private Sub actmgmtBut_Click(sender As Object, e As EventArgs) Handles actmgmtBut.Click
        Me.Hide()
        AccountsForm.Show()
    End Sub
End Class