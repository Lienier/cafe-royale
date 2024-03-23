Imports MySql.Data.MySqlClient

Public Class AddCashierForm
    Dim conn As New MySqlConnection("Server=127.0.0.1;Database=croyal;User Id=root;Password=Ra200405;")
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn.Open()
        Dim cmd1 As New MySqlCommand("select name from employed", conn)
        Dim cmd2 As New MySqlCommand("Insert Into employed(username,upassword,phoneNUM,email) values (@name,@upassword,@phoneNUM,@email)", conn)
        cmd2.Parameters.AddWithValue("@name", AdminPUserTb.Text)
        cmd2.Parameters.AddWithValue("@upassword", AddCashierTb.Text)
        cmd2.Parameters.AddWithValue("@phoneNUM", AdminPnumtb.Text)
        cmd2.Parameters.AddWithValue("@email", AdminPemailTB.Text)
        If cmd2.ExecuteNonQuery() Then
            Me.Close()
            MessageBox.Show("Registration Complete!")
            AdminForm.Show()
        End If
        conn.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            AddCashierTb.UseSystemPasswordChar = True
        Else
            AddCashierTb.UseSystemPasswordChar = False
        End If
    End Sub
End Class