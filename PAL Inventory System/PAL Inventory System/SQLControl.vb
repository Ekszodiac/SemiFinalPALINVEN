Imports System.Data.SqlClient

Public Class SQLControl
    Private DBCon As New SqlConnection("Server=PALADMIN;Database=PAL_INVEN;Trusted_Connection=True")
    Private str As String = "Data Source=RVO;Initial Catalog=PAL_INVEN;Integrated Security=True"
    Public DBCmd As SqlCommand

    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    Public Params As New List(Of SqlParameter)

    Public RecordCount As Integer
    Public Exception As String

    Public Sub New()

    End Sub

    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        Exception = ""

        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()

            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)
            RecordCount = DBDA.Fill(DBDT)

        Catch ex As Exception
            Exception = "ExecQuery Error " & vbNewLine & ex.Message
        Finally
            'CLOSE CONNECTION
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
End Class
