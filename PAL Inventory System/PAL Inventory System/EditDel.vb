Public Class EditDel
    Public SQL As New SQLControl

    Private Sub EditDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        AdminForm.Hide()
    End Sub

    Private Sub closeBut_Click(sender As Object, e As EventArgs) Handles closeBut.Click
        Me.Hide()
        AdminForm.Show()
        AdminForm.LoadInven()
    End Sub

    Private Sub editInvenBut_Click(sender As Object, e As EventArgs) Handles editInvenBut.Click
        descTxtbx.Enabled = True
        remTxtbx.Enabled = True
        snTxtbx.Enabled = True
        acqBox.Enabled = True
        delInvenBut.Enabled = False
        saveBut.Visible = True
        editInvenBut.Visible = False
    End Sub


    Private Sub saveBut_Click(sender As Object, e As EventArgs) Handles saveBut.Click
        SQL.AddParam("@paltag", ptTxtbx.Text)
        SQL.AddParam("@desc", descTxtbx.Text)
        SQL.AddParam("@sn", snTxtbx.Text)
        SQL.AddParam("@remarks", remTxtbx.Text)
        SQL.AddParam("@acq", acqBox.Value.Date)

        SQL.ExecQuery("UPDATE ITEM set item_description=@desc, item_sn=@sn, item_remarks=@remarks, item_acqdate=@acq where item_paltag=@paltag;")

        saveBut.Visible = False
        editInvenBut.Visible = True

        descTxtbx.Enabled = False
        remTxtbx.Enabled = False
        snTxtbx.Enabled = False
        acqBox.Enabled = False
        delInvenBut.Enabled = True
    End Sub

    Private Sub delInvenBut_Click(sender As Object, e As EventArgs) Handles delInvenBut.Click
        Dim ask As MsgBoxResult = MsgBox("The Selected Item will be deleted! Are you sure you wish to continue?", MsgBoxStyle.YesNo, "Delete User?")
        If ask = MsgBoxResult.Yes Then
            SQL.AddParam("@sn", snTxtbx.Text)
            SQL.AddParam("@paltag", ptTxtbx.Text)
            SQL.ExecQuery("DELETE FROM item WHERE item_paltag=@paltag AND item_sn=@sn;")

            MsgBox("The Selected Item has been successfully deleted!")

            Me.Hide()
            AdminForm.Show()
            AdminForm.LoadInven()
        End If
    End Sub

End Class