Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class printReports
    Public SQL As SQLControl

    Private Sub printReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub showRep_Click_1(sender As Object, e As EventArgs) Handles showRep.Click
        Dim report As New PALInventory

        Dim dt As New DataTable

        With dt
            .Columns.Add("item_paltag")
            .Columns.Add("item_description")
            .Columns.Add("item_sn")
            .Columns.Add("item_acqdate")
            .Columns.Add("item_remarks")
            .Columns.Add("item_timestamp")
        End With

        If Application.OpenForms().OfType(Of printForm).Any Then
            For Each dr As DataGridViewRow In printForm.dgv2.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(dr.Cells("checkCol").Value)
                If isSelected Then
                    dt.Rows.Add(dr.Cells("PALTAG").Value, dr.Cells("DESCRIPTION").Value, dr.Cells("SERIAL").Value, dr.Cells("ACQUISITION").Value, dr.Cells("REMARKS").Value, dr.Cells("TIMESTAMP").Value)
                End If
            Next
        ElseIf Application.OpenForms().OfType(Of userPrint).Any Then
            For Each dr As DataGridViewRow In userPrint.dgv2.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(dr.Cells("checkCol").Value)
                If isSelected Then
                    dt.Rows.Add(dr.Cells("PALTAG").Value, dr.Cells("DESCRIPTION").Value, dr.Cells("SERIAL").Value, dr.Cells("ACQUISITION").Value, dr.Cells("REMARKS").Value, dr.Cells("TIMESTAMP").Value)
                End If
            Next
        End If



        Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptDoc = New PALItem
        rptDoc.SetDataSource(dt)
        crv1.ReportSource = rptDoc

    End Sub
End Class