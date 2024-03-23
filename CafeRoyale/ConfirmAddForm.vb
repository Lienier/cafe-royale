Imports MySql.Data.MySqlClient
Public Class ConfirmAddForm
    Dim conn As New MySqlConnection("Server=127.0.0.1;Database=croyal;User Id=root;Password=Ra200405;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim cmd As New MySqlCommand("select * From iadmin where  ipass=@ipass", conn)
        cmd.Parameters.AddWithValue("@ipass", CashierPassTb.Text.Trim)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            Me.Close()
            AddCashierForm.Show()

        Else
            MsgBox("Incorrect Username or Password")
        End If
        conn.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CashierPassTb.UseSystemPasswordChar = True
        Else
            CashierPassTb.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CashierPassTb_TextChanged(sender As Object, e As EventArgs) Handles CashierPassTb.TextChanged

    End Sub
End Class