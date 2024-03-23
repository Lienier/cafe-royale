<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmAddForm
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
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        Button1 = New Button()
        CashierPassTb = New TextBox()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(482, 204)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(58, 21)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(68, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 18)
        Label2.TabIndex = 14
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(136, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(262, 51)
        Button1.TabIndex = 13
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CashierPassTb
        ' 
        CashierPassTb.Location = New Point(68, 190)
        CashierPassTb.Multiline = True
        CashierPassTb.Name = "CashierPassTb"
        CashierPassTb.PasswordChar = "*"c
        CashierPassTb.Size = New Size(380, 35)
        CashierPassTb.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(571, 73)
        Panel1.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(151, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 32)
        Label3.TabIndex = 1
        Label3.Text = "Verification" & vbCrLf
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 32)
        Label1.TabIndex = 2
        Label1.Text = "Need Admin Password" & vbLf
        ' 
        ' ConfirmAddForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(571, 450)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(CashierPassTb)
        Name = "ConfirmAddForm"
        Text = "ConfirmAddForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CashierPassTb As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
