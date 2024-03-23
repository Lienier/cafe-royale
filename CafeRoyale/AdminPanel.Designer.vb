<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        Panel3 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Button1 = New Button()
        addMenuPanel = New Button()
        AddCashierbttn = New Button()
        AddCashierPanel = New Panel()
        DataGridView1 = New DataGridView()
        testpanel = New Panel()
        Button3 = New Button()
        Label4 = New Label()
        ProductPriceTb = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ProductNameTb = New TextBox()
        Panel2 = New Panel()
        AddImagebttn = New Button()
        PictureBox2 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        AddCashierPanel.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        testpanel.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(213, 395)
        Button2.Name = "Button2"
        Button2.Size = New Size(411, 65)
        Button2.TabIndex = 1
        Button2.Text = "Add Cashier"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1099, 76)
        Panel3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(151, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 32)
        Label3.TabIndex = 1
        Label3.Text = "Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.caferoyaleLOGO
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(145, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(addMenuPanel)
        Panel1.Controls.Add(AddCashierbttn)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(145, 642)
        Panel1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 522)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 59)
        Button1.TabIndex = 12
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' addMenuPanel
        ' 
        addMenuPanel.Location = New Point(0, 130)
        addMenuPanel.Name = "addMenuPanel"
        addMenuPanel.Size = New Size(145, 59)
        addMenuPanel.TabIndex = 11
        addMenuPanel.Text = "Add Menu"
        addMenuPanel.UseVisualStyleBackColor = True
        ' 
        ' AddCashierbttn
        ' 
        AddCashierbttn.Location = New Point(0, 195)
        AddCashierbttn.Name = "AddCashierbttn"
        AddCashierbttn.Size = New Size(145, 59)
        AddCashierbttn.TabIndex = 0
        AddCashierbttn.Text = "Manage Cashier"
        AddCashierbttn.UseVisualStyleBackColor = True
        ' 
        ' AddCashierPanel
        ' 
        AddCashierPanel.BackColor = Color.PapayaWhip
        AddCashierPanel.Controls.Add(DataGridView1)
        AddCashierPanel.Controls.Add(Button2)
        AddCashierPanel.Location = New Point(164, 95)
        AddCashierPanel.Name = "AddCashierPanel"
        AddCashierPanel.Size = New Size(923, 561)
        AddCashierPanel.TabIndex = 9
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(72, 87)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(711, 242)
        DataGridView1.TabIndex = 2
        ' 
        ' testpanel
        ' 
        testpanel.BackColor = Color.PapayaWhip
        testpanel.Controls.Add(Button3)
        testpanel.Controls.Add(Label4)
        testpanel.Controls.Add(ProductPriceTb)
        testpanel.Controls.Add(Label2)
        testpanel.Controls.Add(Label1)
        testpanel.Controls.Add(ComboBox1)
        testpanel.Controls.Add(ProductNameTb)
        testpanel.Controls.Add(Panel2)
        testpanel.Location = New Point(164, 94)
        testpanel.Name = "testpanel"
        testpanel.Size = New Size(923, 558)
        testpanel.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(706, 347)
        Button3.Name = "Button3"
        Button3.Size = New Size(163, 49)
        Button3.TabIndex = 2
        Button3.Text = "Add Product"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(613, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 20)
        Label4.TabIndex = 6
        Label4.Text = "Product Price:"
        ' 
        ' ProductPriceTb
        ' 
        ProductPriceTb.Location = New Point(726, 266)
        ProductPriceTb.Name = "ProductPriceTb"
        ProductPriceTb.Size = New Size(171, 23)
        ProductPriceTb.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(613, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 20)
        Label2.TabIndex = 4
        Label2.Text = "Product Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(677, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 3
        Label1.Text = "Type:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Coffee Based Drink", "Non Coffee Drink", "Matcha Series", "Ube Series", "Milk Tea Series", "Snacks"})
        ComboBox1.Location = New Point(726, 169)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(156, 33)
        ComboBox1.TabIndex = 2
        ' 
        ' ProductNameTb
        ' 
        ProductNameTb.Location = New Point(726, 227)
        ProductNameTb.Name = "ProductNameTb"
        ProductNameTb.Size = New Size(171, 23)
        ProductNameTb.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(AddImagebttn)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(284, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(290, 413)
        Panel2.TabIndex = 0
        ' 
        ' AddImagebttn
        ' 
        AddImagebttn.Location = New Point(63, 248)
        AddImagebttn.Name = "AddImagebttn"
        AddImagebttn.Size = New Size(163, 49)
        AddImagebttn.TabIndex = 1
        AddImagebttn.Text = "Add Image"
        AddImagebttn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(22, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(241, 161)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(1099, 718)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(testpanel)
        Controls.Add(AddCashierPanel)
        Name = "AdminForm"
        Text = "AdminPanel"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        AddCashierPanel.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        testpanel.ResumeLayout(False)
        testpanel.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddCashierbttn As Button
    Friend WithEvents AddCashierPanel As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents addMenuPanel As Button
    Friend WithEvents testpanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddImagebttn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ProductNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductPriceTb As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
End Class
