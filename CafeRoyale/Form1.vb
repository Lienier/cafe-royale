Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("Server=127.0.0.1;Database=croyal;User Id=root;Password=Ra200405;")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BringToFront()
    End Sub

    Private Sub AdminBttn_Click(sender As Object, e As EventArgs) Handles AdminBttn.Click
        AdminPanel.BringToFront()
    End Sub

    Private Sub CashierBttn_Click(sender As Object, e As EventArgs) Handles CashierBttn.Click
        CashierPanel.BringToFront()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            AdminpassTb.UseSystemPasswordChar = True
        Else
            AdminpassTb.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.BringToFront()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CashierPassTb.UseSystemPasswordChar = True
        Else
            CashierPassTb.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Open()
        Dim cmd As New MySqlCommand("select * From employed where username=@username AND upassword=@upassword", conn)
        cmd.Parameters.AddWithValue("username", CashierUserTb.Text.Trim)
        cmd.Parameters.AddWithValue("upassword", CashierPassTb.Text.Trim)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            Panel1.BringToFront()
            CashierPassTb.Clear()
            CashierUserTb.Clear()
            MenuForm.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password")
        End If

        conn.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to Exit", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim cmd As New MySqlCommand("select * From iadmin where name=@name AND ipass=@ipass", conn)
        cmd.Parameters.AddWithValue("@name", AdminUserTb.Text.Trim)
        cmd.Parameters.AddWithValue("@ipass", AdminpassTb.Text.Trim)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            Panel1.BringToFront()
            AdminpassTb.Clear()
            AdminUserTb.Clear()
            AdminForm.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password")
        End If

        conn.Close()
    End Sub
    Private Sub CashierPanel_Paint(sender As Object, e As PaintEventArgs) Handles CashierPanel.Paint

    End Sub
End Class