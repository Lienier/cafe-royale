Imports System.Net
Imports MySql.Data.MySqlClient

Public Class MenuForm

    Dim connectionString As String = "Server=127.0.0.1;Database=croyal;User Id=root;Password=Ra200405;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CoffeeBaseFLP.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NonCofFLP.BringToFront()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MatchaFLP.BringToFront()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MilkTeaFLP.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UbeSeriesFLP.BringToFront()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SnacksFLP.BringToFront()
    End Sub

    Private Sub CoffeeBaseFLP_Paint(sender As Object, e As PaintEventArgs) Handles CoffeeBaseFLP.Paint


    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        connection.Open()


        Dim command As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price,id FROM Product WHERE Type = 'Coffee Based Drink'", connection)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        While reader.Read()
            Dim panel As Panel = New Panel()
            panel.Width = 210
            panel.Height = 260
            panel.BorderStyle = BorderStyle.FixedSingle


            Dim pictureBox As PictureBox = New PictureBox()
            pictureBox.Width = 180
            pictureBox.Height = 150
            pictureBox.Dock = DockStyle.Fill
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Tag = reader.Item("id")


            Dim imageData As Byte() = DirectCast(reader("Product_ImageData"), Byte())
            Using stream As New System.IO.MemoryStream(imageData)
                pictureBox.Image = Image.FromStream(stream)
            End Using

            Dim label As Label = New Label()
            label.Text = reader("Name").ToString()
            label.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label.Dock = DockStyle.Top
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Tag = reader.Item("id")

            Dim label2 As Label = New Label()
            label2.Text = "Price: ₱" & reader("Price").ToString()
            label2.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label2.Dock = DockStyle.Bottom
            label2.TextAlign = ContentAlignment.MiddleCenter
            label2.Tag = reader.Item("id")

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(label)
            panel.Controls.Add(label2)

            CoffeeBaseFLP.Controls.Add(panel)

            AddHandler pictureBox.Click, AddressOf label2_Click
            AddHandler label.Click, AddressOf label2_Click
            AddHandler label2.Click, AddressOf label2_Click

        End While

        reader.Close()
        connection.Close()

        connection.Open()


        Dim command1 As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price,id FROM Product WHERE Type = 'Milk Tea Series'", connection)
        Dim reader1 As MySqlDataReader = command1.ExecuteReader()

        While reader1.Read()
            Dim panel As Panel = New Panel()
            panel.Width = 210
            panel.Height = 260
            panel.BorderStyle = BorderStyle.FixedSingle


            Dim pictureBox As PictureBox = New PictureBox()
            pictureBox.Width = 180
            pictureBox.Height = 150
            pictureBox.Dock = DockStyle.Fill
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Tag = reader1.Item("id")


            Dim imageData As Byte() = DirectCast(reader1("Product_ImageData"), Byte())
            Using stream As New System.IO.MemoryStream(imageData)
                pictureBox.Image = Image.FromStream(stream)
            End Using

            Dim label As Label = New Label()
            label.Text = reader1("Name").ToString()
            label.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label.Dock = DockStyle.Top
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Tag = reader1.Item("id")

            Dim label2 As Label = New Label()
            label2.Text = "Price: ₱" & reader1("Price").ToString()
            label2.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label2.Dock = DockStyle.Bottom
            label2.TextAlign = ContentAlignment.MiddleCenter
            label2.Tag = reader1.Item("id")

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(label)
            panel.Controls.Add(label2)

            MilkTeaFLP.Controls.Add(panel)

            AddHandler pictureBox.Click, AddressOf label2_Click
            AddHandler label.Click, AddressOf label2_Click
            AddHandler label2.Click, AddressOf label2_Click

        End While

        reader.Close()
        connection.Close()

        connection.Open()
        Dim command2 As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price,id FROM Product WHERE Type = 'Non Coffee Drink'", connection)
        Dim reader2 As MySqlDataReader = command2.ExecuteReader()

        While reader2.Read()
            Dim panel As Panel = New Panel()
            panel.Width = 210
            panel.Height = 260
            panel.BorderStyle = BorderStyle.FixedSingle


            Dim pictureBox As PictureBox = New PictureBox()
            pictureBox.Width = 180
            pictureBox.Height = 150
            pictureBox.Dock = DockStyle.Fill
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom


            Dim imageData As Byte() = DirectCast(reader2("Product_ImageData"), Byte())
            Using stream As New System.IO.MemoryStream(imageData)
                pictureBox.Image = Image.FromStream(stream)
            End Using

            Dim label As Label = New Label()
            label.Text = reader2("Name").ToString()
            label.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label.Dock = DockStyle.Top
            label.TextAlign = ContentAlignment.MiddleCenter

            Dim label2 As Label = New Label()
            label2.Text = "Price: ₱" & reader2("Price").ToString()
            label2.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label2.Dock = DockStyle.Bottom
            label2.TextAlign = ContentAlignment.MiddleCenter

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(label)
            panel.Controls.Add(label2)

            NonCofFLP.Controls.Add(panel)



        End While

        reader2.Close()
        connection.Close()

        connection.Open()
        Dim command3 As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price,id FROM Product WHERE Type = 'Matcha Series'", connection)
        Dim reader3 As MySqlDataReader = command3.ExecuteReader()

        While reader3.Read()
            Dim panel As Panel = New Panel()
            panel.Width = 210
            panel.Height = 260
            panel.BorderStyle = BorderStyle.FixedSingle


            Dim pictureBox As PictureBox = New PictureBox()
            pictureBox.Width = 180
            pictureBox.Height = 150
            pictureBox.Dock = DockStyle.Fill
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom



            Dim imageData As Byte() = DirectCast(reader3("Product_ImageData"), Byte())
            Using stream As New System.IO.MemoryStream(imageData)
                pictureBox.Image = Image.FromStream(stream)
            End Using

            Dim label As Label = New Label()
            label.Text = reader3("Name").ToString()
            label.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label.Dock = DockStyle.Top
            label.TextAlign = ContentAlignment.MiddleCenter

            Dim label2 As Label = New Label()
            label2.Text = "Price: ₱" & reader3("Price").ToString()
            label2.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label2.Dock = DockStyle.Bottom
            label2.TextAlign = ContentAlignment.MiddleCenter

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(label)
            panel.Controls.Add(label2)

            MatchaFLP.Controls.Add(panel)



        End While

        reader3.Close()
        connection.Close()

        connection.Open()
        Dim command4 As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price,id FROM Product WHERE Type = 'Ube Series'", connection)
        Dim reader4 As MySqlDataReader = command4.ExecuteReader()

        While reader4.Read()
            Dim panel As Panel = New Panel()
            panel.Width = 210
            panel.Height = 260
            panel.BorderStyle = BorderStyle.FixedSingle


            Dim pictureBox As PictureBox = New PictureBox()
            pictureBox.Width = 180
            pictureBox.Height = 150
            pictureBox.Dock = DockStyle.Fill
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom


            Dim imageData As Byte() = DirectCast(reader4("Product_ImageData"), Byte())
            Using stream As New System.IO.MemoryStream(imageData)
                pictureBox.Image = Image.FromStream(stream)
            End Using

            Dim label As Label = New Label()
            label.Text = reader4("Name").ToString()
            label.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label.Dock = DockStyle.Top
            label.TextAlign = ContentAlignment.MiddleCenter

            Dim label2 As Label = New Label()
            label2.Text = "Price: ₱" & reader4("Price").ToString()
            label2.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label2.Dock = DockStyle.Bottom
            label2.TextAlign = ContentAlignment.MiddleCenter

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(label)
            panel.Controls.Add(label2)

            UbeSeriesFLP.Controls.Add(panel)



        End While

        reader4.Close()
        connection.Close()

        connection.Open()
        Dim command5 As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price,id FROM Product WHERE Type = 'Snacks'", connection)
        Dim reader5 As MySqlDataReader = command5.ExecuteReader()

        While reader5.Read()
            Dim panel As Panel = New Panel()
            panel.Width = 210
            panel.Height = 260
            panel.BorderStyle = BorderStyle.FixedSingle


            Dim pictureBox As PictureBox = New PictureBox()
            pictureBox.Width = 180
            pictureBox.Height = 150
            pictureBox.Dock = DockStyle.Fill
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom


            Dim imageData As Byte() = DirectCast(reader5("Product_ImageData"), Byte())
            Using stream As New System.IO.MemoryStream(imageData)
                pictureBox.Image = Image.FromStream(stream)
            End Using

            Dim label As Label = New Label()
            label.Text = reader5("Name").ToString()
            label.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label.Dock = DockStyle.Top
            label.TextAlign = ContentAlignment.MiddleCenter

            Dim label2 As Label = New Label()
            label2.Text = "Price: ₱" & reader5("Price").ToString()
            label2.Font = New Font("Segoe UI", 12, FontStyle.Bold Or FontStyle.Underline)
            label2.Dock = DockStyle.Bottom
            label2.TextAlign = ContentAlignment.MiddleCenter

            panel.Controls.Add(pictureBox)
            panel.Controls.Add(label)
            panel.Controls.Add(label2)

            SnacksFLP.Controls.Add(panel)



        End While

        reader5.Close()
        connection.Close()
    End Sub

    Public Sub label2_Click(sender As Object, e As EventArgs)
        Try
            connection.Open()
            Dim command As MySqlCommand = New MySqlCommand("SELECT Product_ImageData, Name, Price FROM Product WHERE id = '" & sender.tag.ToString & "'", connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read
                DataGridView1.Rows.Add(reader.Item("Name").ToString, Format(CDbl(reader.Item("Price").ToString), "#,##0.00"))
            End While
            quantityForm.Show()

            connection.Close()


        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    Public Sub PopulateDataGridView(ByVal value As String)

        DataGridView1.Rows.Add(value)

    End Sub



    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to Log Out", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then

        Else
            Me.Close()
            Form1.Show()
        End If


    End Sub
End Class