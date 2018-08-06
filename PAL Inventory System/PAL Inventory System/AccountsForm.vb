Public Class AccountsForm
    Public SQL As New SQLControl

    Private Sub AccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadAcc()
    End Sub

    Public Sub loadAcc()
        dgv1.Columns.Clear()
        SQL.ExecQuery("SELECT user_fname AS NAME, user_type AS TYPE, user_idnum AS ID from pa_user")


        Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkCol.HeaderText = "CheckBox"
        checkCol.Name = "CheckCol"

        dgv1.Columns.Add(checkCol)
        dgv1.DataSource = SQL.DBDT
        dgv1.ReadOnly = False
    End Sub

    Private Sub addBut_Click(sender As Object, e As EventArgs) Handles addBut.Click
        Me.Hide()
        actMgt.Show()
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

    Private Sub delBut_Click(sender As Object, e As EventArgs) Handles delBut.Click
        If dgv1.Rows(dgv1.CurrentRow.Index).Cells(0).Value = True Then

            For Each row As DataGridViewRow In dgv1.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("CheckCol").Value)
                If isSelected Then
                    Dim ask As MsgBoxResult = MsgBox("Are you sure you want to delete this user?", MsgBoxStyle.YesNo)
                    If ask = MsgBoxResult.Yes Then
                        SQL.AddParam("@delID", row.Cells("ID").Value.ToString())
                        SQL.ExecQuery("DELETE FROM pa_user WHERE user_idnum=@delID;")

                        MsgBox("The Selected user has been successfully deleted!")
                        loadAcc()
                    End If
                End If
            Next
        Else
            MsgBox("Please select a row to edit or delete!")
        End If
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        AdminForm.Show()
    End Sub
End Class