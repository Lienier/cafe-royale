Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.OperatingSystem

Public Class AdminForm

    Dim connectionString As String = "Server=127.0.0.1;Database=croyal;User Id=root;Password=Ra200405;"

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConfirmAddForm.Show()
    End Sub





    Private Sub AddCashierbttn_Click(sender As Object, e As EventArgs) Handles AddCashierbttn.Click
        AddCashierPanel.BringToFront()
    End Sub


    Private Sub testbttn_Click(sender As Object, e As EventArgs) Handles addMenuPanel.Click
        testpanel.BringToFront()
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddCashierPanel.Show()

    End Sub

    Private Sub AddImagebttn_Click(sender As Object, e As EventArgs) Handles AddImagebttn.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"
        OpenFileDialog1.Title = "Select an Image File"
        OpenFileDialog1.Multiselect = False

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim selectedFilePath = OpenFileDialog1.FileName
            PictureBox2.Image = Image.FromFile(selectedFilePath)
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim typeValue As String = ComboBox1.SelectedItem.ToString()
        Dim image As Image = PictureBox2.Image
        If image IsNot Nothing Then
            Using memoryStream As New MemoryStream()
                image.Save(memoryStream, Imaging.ImageFormat.Png)
                Dim binaryData As Byte() = memoryStream.ToArray()
                Dim productName As String = ProductNameTb.Text
                Dim productPrice As Double
                If Double.TryParse(ProductPriceTb.Text, productPrice) Then
                    SaveToDatabase(typeValue, binaryData, productName, productPrice)
                Else
                    MessageBox.Show("Please enter a valid price.")
                End If
            End Using
        Else
            MessageBox.Show("No image in the PictureBox.")
        End If
    End Sub
    Private Sub SaveToDatabase(typeValue As String, binaryData As Byte(), name As String, price As Double)

        Dim query As String = "INSERT INTO product (Type, Product_ImageData, Name, Price) VALUES (@Type, @Product_ImageData, @Name, @Price)"


        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@Type", typeValue)
                command.Parameters.AddWithValue("@Product_ImageData", binaryData)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Price", price)
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Product data saved to the database.")
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to Log Out", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then

        Else
            Close()
            Form1.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub AddCashierPanel_Paint(sender As Object, e As PaintEventArgs) Handles AddCashierPanel.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub load_Data()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
End Class