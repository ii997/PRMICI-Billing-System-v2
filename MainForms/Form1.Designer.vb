<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CuiButton1 = New CuoreUI.Controls.cuiButton()
        Me.CuiLabel1 = New CuoreUI.Controls.cuiLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CuiPictureBox1 = New CuoreUI.Controls.cuiPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(46, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 180)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRMICI Billing System with QR Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CuiButton1
        '
        Me.CuiButton1.CheckButton = False
        Me.CuiButton1.Checked = False
        Me.CuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.Content = "Login"
        Me.CuiButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CuiButton1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton1.ForeColor = System.Drawing.Color.White
        Me.CuiButton1.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.CuiButton1.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton1.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Image = Nothing
        Me.CuiButton1.ImageAutoCenter = True
        Me.CuiButton1.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageTint = System.Drawing.Color.White
        Me.CuiButton1.Location = New System.Drawing.Point(57, 432)
        Me.CuiButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CuiButton1.Name = "CuiButton1"
        Me.CuiButton1.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.CuiButton1.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton1.OutlineThickness = 1.6!
        Me.CuiButton1.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton1.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton1.Size = New System.Drawing.Size(450, 69)
        Me.CuiButton1.TabIndex = 3
        Me.CuiButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiLabel1
        '
        Me.CuiLabel1.Content = "Please\ enter\ your\ Username\ and\ Password"
        Me.CuiLabel1.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.CuiLabel1.ForeColor = System.Drawing.Color.White
        Me.CuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center
        Me.CuiLabel1.Location = New System.Drawing.Point(57, 182)
        Me.CuiLabel1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CuiLabel1.Name = "CuiLabel1"
        Me.CuiLabel1.Size = New System.Drawing.Size(450, 35)
        Me.CuiLabel1.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(57, 382)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(179, 35)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2TextBox1.BorderRadius = 8
        Me.Guna2TextBox1.BorderThickness = 2
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(57, 230)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Username"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(450, 65)
        Me.Guna2TextBox1.TabIndex = 7
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.White
        Me.Guna2TextBox2.BorderRadius = 8
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(57, 307)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Password"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(450, 65)
        Me.Guna2TextBox2.TabIndex = 8
        '
        'CuiPictureBox1
        '
        Me.CuiPictureBox1.Content = Global.PRMICI_Billing_System_v2.My.Resources.Resources._00b3a85f_2e29_42f7_a019_0ab5a33109b4_removebg_preview__1_1
        Me.CuiPictureBox1.CornerRadius = 8
        Me.CuiPictureBox1.ImageTint = System.Drawing.Color.White
        Me.CuiPictureBox1.Location = New System.Drawing.Point(51, 108)
        Me.CuiPictureBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.CuiPictureBox1.Name = "CuiPictureBox1"
        Me.CuiPictureBox1.Size = New System.Drawing.Size(350, 347)
        Me.CuiPictureBox1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CuiPictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(542, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 553)
        Me.Panel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CuiLabel1)
        Me.Controls.Add(Me.CuiButton1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiLabel1 As CuoreUI.Controls.cuiLabel
    Friend WithEvents CuiPictureBox1 As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
End Class
