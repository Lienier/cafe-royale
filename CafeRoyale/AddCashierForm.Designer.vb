<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCashierForm
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
        Label5 = New Label()
        Label6 = New Label()
        CheckBox1 = New CheckBox()
        Label7 = New Label()
        Label8 = New Label()
        AdminPnumtb = New TextBox()
        Button4 = New Button()
        AdminPemailTB = New TextBox()
        AddCashierTb = New TextBox()
        AdminPUserTb = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(33, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 18)
        Label5.TabIndex = 51
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(29, 238)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 18)
        Label6.TabIndex = 50
        Label6.Text = "Phone#"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(493, 194)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(58, 21)
        CheckBox1.TabIndex = 47
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(33, 197)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 18)
        Label7.TabIndex = 46
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(29, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 18)
        Label8.TabIndex = 45
        Label8.Text = "Username"
        ' 
        ' AdminPnumtb
        ' 
        AdminPnumtb.Location = New Point(115, 221)
        AdminPnumtb.Multiline = True
        AdminPnumtb.Name = "AdminPnumtb"
        AdminPnumtb.Size = New Size(372, 35)
        AdminPnumtb.TabIndex = 48
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(133, 331)
        Button4.Name = "Button4"
        Button4.Size = New Size(338, 51)
        Button4.TabIndex = 44
        Button4.Text = "Confirm"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' AdminPemailTB
        ' 
        AdminPemailTB.Location = New Point(115, 262)
        AdminPemailTB.Multiline = True
        AdminPemailTB.Name = "AdminPemailTB"
        AdminPemailTB.Size = New Size(372, 35)
        AdminPemailTB.TabIndex = 49
        ' 
        ' AddCashierTb
        ' 
        AddCashierTb.Location = New Point(115, 180)
        AddCashierTb.Multiline = True
        AddCashierTb.Name = "AddCashierTb"
        AddCashierTb.PasswordChar = "*"c
        AddCashierTb.Size = New Size(372, 35)
        AddCashierTb.TabIndex = 43
        ' 
        ' AdminPUserTb
        ' 
        AdminPUserTb.Location = New Point(115, 139)
        AdminPUserTb.Multiline = True
        AdminPUserTb.Name = "AdminPUserTb"
        AdminPUserTb.Size = New Size(372, 35)
        AdminPUserTb.TabIndex = 42
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(602, 73)
        Panel1.TabIndex = 52
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(151, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 32)
        Label3.TabIndex = 1
        Label3.Text = "Add Cashier"
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
        ' AddCashierForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(602, 450)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(CheckBox1)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(AdminPnumtb)
        Controls.Add(Button4)
        Controls.Add(AdminPemailTB)
        Controls.Add(AddCashierTb)
        Controls.Add(AdminPUserTb)
        Name = "AddCashierForm"
        Text = "AddCashierForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AdminPnumtb As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents AdminPemailTB As TextBox
    Friend WithEvents AddCashierTb As TextBox
    Friend WithEvents AdminPUserTb As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
