Public Class quantityForm

    ' Expose property to access TextBox value
    Public ReadOnly Property TextBoxValue As String
        Get
            Return TextBox1.Text
        End Get
    End Property


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create instances of Form1 and Form2
        Dim Mf As New MenuForm()
        Dim Qf As New quantityForm()
        Mf.DataGridView1.Rows.Add(TextBox1.Text)


    End Sub
End Class