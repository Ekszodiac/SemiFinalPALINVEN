Imports System.IO

Public Class Form1
    Public SQL As New SQLControl

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(0, 31, 96)
        loginbut.BackColor = Color.FromArgb(255, 201, 7)
        loginbut.FlatAppearance.BorderSize = 1

    End Sub

    
    Private Sub loginbut_Click(sender As Object, e As EventArgs) Handles loginbut.Click
        SQL.AddParam("@id", idbox.Text)
        SQL.AddParam("@pw", pwbox.Text)
        Dim userid = idbox.Text
        Dim pw = pwbox.Text
        Dim dbusertype As String

        SQL.ExecQuery("SELECT * FROM pa_user WHERE user_idnum=@id AND user_password=@pw")

        If SQL.DBDT.Rows.Count() <= 0 Then
            MessageBox.Show("Username Or Password Are Invalid")
        Else

            Using connObj As New SqlClient.SqlConnection("Server=RVO;Database=PAL_INVEN;Trusted_Connection=True")
                Using cmdObj As New SqlClient.SqlCommand("SELECT * FROM pa_user WHERE user_idnum=" & userid & " AND user_password=" & pw & "", connObj)
                    connObj.Open()
                    Using readerObj As SqlClient.SqlDataReader = cmdObj.ExecuteReader
                        'This will loop through all returned records 
                        While readerObj.Read
                            dbusertype = readerObj("user_type").ToString
                            'handle returned value before next loop here
                        End While
                    End Using
                    connObj.Close()
                End Using
            End Using
            If dbusertype = "1" Then
                Me.Hide()
                AdminForm.Show()
            Else
                Me.Hide()
                UserForm.Show()
            End If
        End If
        idbox.Text = ""
        pwbox.Text = ""
    End Sub

    Private Sub exitBut_Click(sender As Object, e As EventArgs) Handles exitBut.Click
        Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idbox.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

End Class
