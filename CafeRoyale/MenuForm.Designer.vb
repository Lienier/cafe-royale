<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Logout = New Button()
        Button6 = New Button()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        NonCoffeeFLP = New FlowLayoutPanel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CoffeeBaseFLP = New FlowLayoutPanel()
        NonCofFLP = New FlowLayoutPanel()
        MatchaFLP = New FlowLayoutPanel()
        UbeSeriesFLP = New FlowLayoutPanel()
        MilkTeaFLP = New FlowLayoutPanel()
        SnacksFLP = New FlowLayoutPanel()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1131, 73)
        Panel1.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Window
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(151, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 32)
        Label3.TabIndex = 1
        Label3.Text = "MENU" & vbCrLf
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Logout)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(FlowLayoutPanel3)
        Panel2.Controls.Add(NonCoffeeFLP)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 73)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(145, 544)
        Panel2.TabIndex = 14
        ' 
        ' Logout
        ' 
        Logout.Location = New Point(0, 465)
        Logout.Name = "Logout"
        Logout.Size = New Size(145, 51)
        Logout.TabIndex = 21
        Logout.Text = "Logout"
        Logout.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(0, 338)
        Button6.Name = "Button6"
        Button6.Size = New Size(145, 51)
        Button6.TabIndex = 20
        Button6.Text = "Snacks"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.PapayaWhip
        FlowLayoutPanel3.Location = New Point(145, 481)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(676, 467)
        FlowLayoutPanel3.TabIndex = 19
        ' 
        ' NonCoffeeFLP
        ' 
        NonCoffeeFLP.Location = New Point(145, 484)
        NonCoffeeFLP.Name = "NonCoffeeFLP"
        NonCoffeeFLP.Size = New Size(676, 467)
        NonCoffeeFLP.TabIndex = 17
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(0, 281)
        Button5.Name = "Button5"
        Button5.Size = New Size(145, 51)
        Button5.TabIndex = 4
        Button5.Text = "Milk Tea Series"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(0, 224)
        Button4.Name = "Button4"
        Button4.Size = New Size(145, 51)
        Button4.TabIndex = 3
        Button4.Text = "Ube Series"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(0, 167)
        Button3.Name = "Button3"
        Button3.Size = New Size(145, 51)
        Button3.TabIndex = 2
        Button3.Text = "Matcha Series"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(0, 110)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 51)
        Button2.TabIndex = 1
        Button2.Text = "Non Coffee Drink"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 53)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 51)
        Button1.TabIndex = 0
        Button1.Text = "Coffee Based Drinks"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CoffeeBaseFLP
        ' 
        CoffeeBaseFLP.BackColor = Color.PapayaWhip
        CoffeeBaseFLP.Location = New Point(145, 73)
        CoffeeBaseFLP.Name = "CoffeeBaseFLP"
        CoffeeBaseFLP.Size = New Size(676, 544)
        CoffeeBaseFLP.TabIndex = 16
        ' 
        ' NonCofFLP
        ' 
        NonCofFLP.BackColor = Color.PapayaWhip
        NonCofFLP.Location = New Point(145, 73)
        NonCofFLP.Name = "NonCofFLP"
        NonCofFLP.Size = New Size(676, 544)
        NonCofFLP.TabIndex = 17
        ' 
        ' MatchaFLP
        ' 
        MatchaFLP.BackColor = Color.PapayaWhip
        MatchaFLP.Location = New Point(145, 72)
        MatchaFLP.Name = "MatchaFLP"
        MatchaFLP.Size = New Size(676, 545)
        MatchaFLP.TabIndex = 18
        ' 
        ' UbeSeriesFLP
        ' 
        UbeSeriesFLP.BackColor = Color.PapayaWhip
        UbeSeriesFLP.Location = New Point(145, 74)
        UbeSeriesFLP.Name = "UbeSeriesFLP"
        UbeSeriesFLP.Size = New Size(676, 543)
        UbeSeriesFLP.TabIndex = 19
        ' 
        ' MilkTeaFLP
        ' 
        MilkTeaFLP.BackColor = Color.PapayaWhip
        MilkTeaFLP.Location = New Point(145, 74)
        MilkTeaFLP.Name = "MilkTeaFLP"
        MilkTeaFLP.Size = New Size(676, 543)
        MilkTeaFLP.TabIndex = 20
        ' 
        ' SnacksFLP
        ' 
        SnacksFLP.BackColor = Color.PapayaWhip
        SnacksFLP.Location = New Point(145, 73)
        SnacksFLP.Name = "SnacksFLP"
        SnacksFLP.Size = New Size(676, 544)
        SnacksFLP.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Linen
        Panel3.Controls.Add(DataGridView1)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(818, 73)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(313, 544)
        Panel3.TabIndex = 21
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BackgroundColor = Color.Linen
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Dock = DockStyle.Right
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(313, 544)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Price"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 58
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Quantity"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 78
        ' 
        ' MenuForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1131, 617)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(CoffeeBaseFLP)
        Controls.Add(MatchaFLP)
        Controls.Add(MilkTeaFLP)
        Controls.Add(UbeSeriesFLP)
        Controls.Add(SnacksFLP)
        Controls.Add(NonCofFLP)
        Name = "MenuForm"
        Text = "MenuForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CoffeeBaseFLP As FlowLayoutPanel
    Friend WithEvents NonCoffeeFLP As FlowLayoutPanel
    Friend WithEvents NonCofFLP As FlowLayoutPanel
    Friend WithEvents MatchaFLP As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents UbeSeriesFLP As FlowLayoutPanel
    Friend WithEvents MilkTeaFLP As FlowLayoutPanel
    Friend WithEvents Button6 As Button
    Friend WithEvents SnacksFLP As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Logout As Button
End Class
