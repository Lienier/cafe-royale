﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        PictureBox1 = New PictureBox()
        CashierBttn = New Button()
        AdminBttn = New Button()
        Panel1 = New Panel()
        AdminPanel = New Panel()
        Button4 = New Button()
        Panel3 = New Panel()
        Label3 = New Label()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        AdminpassTb = New TextBox()
        AdminUserTb = New TextBox()
        CashierPanel = New Panel()
        Button3 = New Button()
        Panel5 = New Panel()
        Label4 = New Label()
        CheckBox2 = New CheckBox()
        Label5 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        CashierPassTb = New TextBox()
        CashierUserTb = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        AdminPanel.SuspendLayout()
        Panel3.SuspendLayout()
        CashierPanel.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.caferoyaleLOGO
        PictureBox1.Location = New Point(-129, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(732, 498)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' CashierBttn
        ' 
        CashierBttn.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CashierBttn.ForeColor = Color.Black
        CashierBttn.Location = New Point(107, 372)
        CashierBttn.Name = "CashierBttn"
        CashierBttn.Size = New Size(202, 71)
        CashierBttn.TabIndex = 4
        CashierBttn.Text = "Cashier"
        CashierBttn.UseVisualStyleBackColor = True
        ' 
        ' AdminBttn
        ' 
        AdminBttn.BackColor = Color.Black
        AdminBttn.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AdminBttn.ForeColor = SystemColors.Window
        AdminBttn.Location = New Point(107, 295)
        AdminBttn.Name = "AdminBttn"
        AdminBttn.Size = New Size(202, 71)
        AdminBttn.TabIndex = 3
        AdminBttn.Text = "Admin"
        AdminBttn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CashierBttn)
        Panel1.Controls.Add(AdminBttn)
        Panel1.Location = New Point(485, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(402, 498)
        Panel1.TabIndex = 5
        ' 
        ' AdminPanel
        ' 
        AdminPanel.Controls.Add(Button4)
        AdminPanel.Controls.Add(Panel3)
        AdminPanel.Controls.Add(CheckBox1)
        AdminPanel.Controls.Add(Label2)
        AdminPanel.Controls.Add(Label1)
        AdminPanel.Controls.Add(Button1)
        AdminPanel.Controls.Add(AdminpassTb)
        AdminPanel.Controls.Add(AdminUserTb)
        AdminPanel.Location = New Point(485, 0)
        AdminPanel.Name = "AdminPanel"
        AdminPanel.Size = New Size(402, 498)
        AdminPanel.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(148, 434)
        Button4.Name = "Button4"
        Button4.Size = New Size(161, 51)
        Button4.TabIndex = 14
        Button4.Text = "Cancel"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Top
        Panel3.ForeColor = Color.Black
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 76)
        Panel3.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(3, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 32)
        Label3.TabIndex = 1
        Label3.Text = "Admin Login"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.Black
        CheckBox1.Location = New Point(87, 333)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(58, 21)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(40, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 18)
        Label2.TabIndex = 11
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(40, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 18)
        Label1.TabIndex = 10
        Label1.Text = "Username"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(145, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(161, 51)
        Button1.TabIndex = 9
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' AdminpassTb
        ' 
        AdminpassTb.ForeColor = Color.Black
        AdminpassTb.Location = New Point(77, 283)
        AdminpassTb.Multiline = True
        AdminpassTb.Name = "AdminpassTb"
        AdminpassTb.PasswordChar = "*"c
        AdminpassTb.Size = New Size(297, 35)
        AdminpassTb.TabIndex = 8
        ' 
        ' AdminUserTb
        ' 
        AdminUserTb.ForeColor = Color.Black
        AdminUserTb.Location = New Point(77, 219)
        AdminUserTb.Multiline = True
        AdminUserTb.Name = "AdminUserTb"
        AdminUserTb.Size = New Size(297, 35)
        AdminUserTb.TabIndex = 7
        ' 
        ' CashierPanel
        ' 
        CashierPanel.Controls.Add(Button3)
        CashierPanel.Controls.Add(Panel5)
        CashierPanel.Controls.Add(CheckBox2)
        CashierPanel.Controls.Add(Label5)
        CashierPanel.Controls.Add(Label6)
        CashierPanel.Controls.Add(Button2)
        CashierPanel.Controls.Add(CashierPassTb)
        CashierPanel.Controls.Add(CashierUserTb)
        CashierPanel.Location = New Point(485, 0)
        CashierPanel.Name = "CashierPanel"
        CashierPanel.Size = New Size(402, 498)
        CashierPanel.TabIndex = 8
        ' 
        ' Button3
        ' 
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(145, 433)
        Button3.Name = "Button3"
        Button3.Size = New Size(161, 51)
        Button3.TabIndex = 14
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label4)
        Panel5.Dock = DockStyle.Top
        Panel5.ForeColor = Color.Black
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(402, 76)
        Panel5.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 32)
        Label4.TabIndex = 1
        Label4.Text = "Cashier Login"
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox2.ForeColor = Color.Black
        CheckBox2.Location = New Point(87, 333)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(58, 21)
        CheckBox2.TabIndex = 12
        CheckBox2.Text = "Show"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(40, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 18)
        Label5.TabIndex = 11
        Label5.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(40, 194)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 18)
        Label6.TabIndex = 10
        Label6.Text = "Username"
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(145, 376)
        Button2.Name = "Button2"
        Button2.Size = New Size(161, 51)
        Button2.TabIndex = 9
        Button2.Text = "Log In"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CashierPassTb
        ' 
        CashierPassTb.ForeColor = Color.Black
        CashierPassTb.Location = New Point(77, 283)
        CashierPassTb.Multiline = True
        CashierPassTb.Name = "CashierPassTb"
        CashierPassTb.PasswordChar = "*"c
        CashierPassTb.Size = New Size(297, 35)
        CashierPassTb.TabIndex = 8
        ' 
        ' CashierUserTb
        ' 
        CashierUserTb.ForeColor = Color.Black
        CashierUserTb.Location = New Point(77, 219)
        CashierUserTb.Multiline = True
        CashierUserTb.Name = "CashierUserTb"
        CashierUserTb.Size = New Size(297, 35)
        CashierUserTb.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PapayaWhip
        ClientSize = New Size(887, 497)
        Controls.Add(AdminPanel)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(CashierPanel)
        ForeColor = Color.White
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        AdminPanel.ResumeLayout(False)
        AdminPanel.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CashierPanel.ResumeLayout(False)
        CashierPanel.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CashierBttn As Button
    Friend WithEvents AdminBttn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents AdminpassTb As TextBox
    Friend WithEvents AdminUserTb As TextBox
    Friend WithEvents CashierPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CashierPassTb As TextBox
    Friend WithEvents CashierUserTb As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
