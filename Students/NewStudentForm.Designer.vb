<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStudentForm
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
        Label8 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        CuiButton1 = New CuoreUI.Controls.cuiButton()
        txtStudentId = New Label()
        Label2 = New Label()
        CuiPictureBox1 = New CuoreUI.Controls.cuiPictureBox()
        CuiTextBox21 = New CuoreUI.Controls.cuiTextBox2()
        CuiTextBox22 = New CuoreUI.Controls.cuiTextBox2()
        Label3 = New Label()
        Label4 = New Label()
        CuiDateTimePicker1 = New CuoreUI.Controls.cuiDateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        CuiTextBox23 = New CuoreUI.Controls.cuiTextBox2()
        Label7 = New Label()
        CuiTextBox24 = New CuoreUI.Controls.cuiTextBox2()
        Label9 = New Label()
        Label10 = New Label()
        CuiComboBox1 = New CuoreUI.Controls.cuiComboBox()
        CuiComboBox2 = New CuoreUI.Controls.cuiComboBox()
        CuiButton2 = New CuoreUI.Controls.cuiButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(494, 40)
        Panel1.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(465, 7)
        Label8.Name = "Label8"
        Label8.Size = New Size(21, 26)
        Label8.TabIndex = 3
        Label8.Text = "x"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(5, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 26)
        Label1.TabIndex = 2
        Label1.Text = "Add New Student"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CuiButton1)
        Panel2.Controls.Add(txtStudentId)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(CuiPictureBox1)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(494, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(567, 563)
        Panel2.TabIndex = 1
        ' 
        ' CuiButton1
        ' 
        CuiButton1.CheckButton = False
        CuiButton1.Checked = False
        CuiButton1.CheckedBackground = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiButton1.CheckedImageTint = Color.White
        CuiButton1.CheckedOutline = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiButton1.Content = "Generate QR Code"
        CuiButton1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiButton1.ForeColor = Color.White
        CuiButton1.HoverBackground = Color.FromArgb(CByte(27), CByte(33), CByte(193))
        CuiButton1.HoveredImageTint = Color.White
        CuiButton1.HoverOutline = Color.Empty
        CuiButton1.Image = Nothing
        CuiButton1.ImageAutoCenter = True
        CuiButton1.ImageExpand = New Point(0, 0)
        CuiButton1.ImageOffset = New Point(0, 0)
        CuiButton1.ImageTint = Color.White
        CuiButton1.Location = New Point(77, 490)
        CuiButton1.Name = "CuiButton1"
        CuiButton1.NormalBackground = Color.FromArgb(CByte(11), CByte(13), CByte(78))
        CuiButton1.NormalOutline = Color.Empty
        CuiButton1.OutlineThickness = 1.6F
        CuiButton1.PressedBackground = Color.FromArgb(CByte(27), CByte(33), CByte(193))
        CuiButton1.PressedImageTint = Color.White
        CuiButton1.PressedOutline = Color.Empty
        CuiButton1.Rounding = New Padding(8)
        CuiButton1.Size = New Size(413, 43)
        CuiButton1.TabIndex = 3
        CuiButton1.TextOffset = New Point(0, 0)
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Font = New Font("Poppins SemiBold", 15.25F, FontStyle.Bold)
        txtStudentId.ForeColor = Color.White
        txtStudentId.Location = New Point(0, 441)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(567, 37)
        txtStudentId.TabIndex = 5
        txtStudentId.Text = "--"
        txtStudentId.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Poppins SemiBold", 15.25F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 400)
        Label2.Name = "Label2"
        Label2.Size = New Size(567, 37)
        Label2.TabIndex = 3
        Label2.Text = "STUDENT UNIQUE QR CODE FOR"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CuiPictureBox1
        ' 
        CuiPictureBox1.BackgroundImageLayout = ImageLayout.Center
        CuiPictureBox1.Content = Nothing
        CuiPictureBox1.CornerRadius = 8
        CuiPictureBox1.ImageTint = Color.White
        CuiPictureBox1.Location = New Point(153, 91)
        CuiPictureBox1.Margin = New Padding(4, 3, 4, 3)
        CuiPictureBox1.Name = "CuiPictureBox1"
        CuiPictureBox1.Size = New Size(281, 281)
        CuiPictureBox1.TabIndex = 0
        ' 
        ' CuiTextBox21
        ' 
        CuiTextBox21.BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiTextBox21.BorderColor = Color.White
        CuiTextBox21.BorderFocusColor = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiTextBox21.BorderSize = 1
        CuiTextBox21.Content = ""
        CuiTextBox21.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiTextBox21.ForeColor = Color.Gray
        CuiTextBox21.Location = New Point(28, 91)
        CuiTextBox21.Margin = New Padding(4)
        CuiTextBox21.Multiline = False
        CuiTextBox21.Name = "CuiTextBox21"
        CuiTextBox21.Padding = New Padding(15, 10, 15, 0)
        CuiTextBox21.PasswordChar = False
        CuiTextBox21.PlaceholderColor = Color.DimGray
        CuiTextBox21.PlaceholderText = ""
        CuiTextBox21.Rounding = 8
        CuiTextBox21.Size = New Size(413, 35)
        CuiTextBox21.TabIndex = 2
        CuiTextBox21.TextOffset = New Size(0, 0)
        CuiTextBox21.UnderlinedStyle = False
        ' 
        ' CuiTextBox22
        ' 
        CuiTextBox22.BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiTextBox22.BorderColor = Color.White
        CuiTextBox22.BorderFocusColor = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiTextBox22.BorderSize = 1
        CuiTextBox22.Content = ""
        CuiTextBox22.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiTextBox22.ForeColor = Color.Gray
        CuiTextBox22.Location = New Point(28, 160)
        CuiTextBox22.Margin = New Padding(4)
        CuiTextBox22.Multiline = False
        CuiTextBox22.Name = "CuiTextBox22"
        CuiTextBox22.Padding = New Padding(15, 10, 15, 0)
        CuiTextBox22.PasswordChar = False
        CuiTextBox22.PlaceholderColor = Color.DimGray
        CuiTextBox22.PlaceholderText = ""
        CuiTextBox22.Rounding = 8
        CuiTextBox22.Size = New Size(413, 35)
        CuiTextBox22.TabIndex = 3
        CuiTextBox22.TextOffset = New Size(0, 0)
        CuiTextBox22.UnderlinedStyle = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(28, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 26)
        Label3.TabIndex = 3
        Label3.Text = "Student ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(28, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 26)
        Label4.TabIndex = 5
        Label4.Text = "Student Name"
        ' 
        ' CuiDateTimePicker1
        ' 
        CuiDateTimePicker1.ArrowColor = Color.White
        CuiDateTimePicker1.Background = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiDateTimePicker1.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiDateTimePicker1.Location = New Point(28, 234)
        CuiDateTimePicker1.MaximumSize = New Size(1000, 21)
        CuiDateTimePicker1.MinimumSize = New Size(0, 21)
        CuiDateTimePicker1.Name = "CuiDateTimePicker1"
        CuiDateTimePicker1.Outline = Color.FromArgb(CByte(60), CByte(255), CByte(255), CByte(255))
        CuiDateTimePicker1.Rounding = New Padding(2)
        CuiDateTimePicker1.Size = New Size(413, 21)
        CuiDateTimePicker1.TabIndex = 6
        CuiDateTimePicker1.TextColor = Color.White
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(28, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 26)
        Label5.TabIndex = 7
        Label5.Text = "Date of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(28, 259)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 26)
        Label6.TabIndex = 9
        Label6.Text = "Age"
        ' 
        ' CuiTextBox23
        ' 
        CuiTextBox23.BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiTextBox23.BorderColor = Color.White
        CuiTextBox23.BorderFocusColor = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiTextBox23.BorderSize = 1
        CuiTextBox23.Content = ""
        CuiTextBox23.Enabled = False
        CuiTextBox23.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiTextBox23.ForeColor = Color.Gray
        CuiTextBox23.Location = New Point(28, 289)
        CuiTextBox23.Margin = New Padding(4)
        CuiTextBox23.Multiline = False
        CuiTextBox23.Name = "CuiTextBox23"
        CuiTextBox23.Padding = New Padding(15, 10, 15, 0)
        CuiTextBox23.PasswordChar = False
        CuiTextBox23.PlaceholderColor = Color.DimGray
        CuiTextBox23.PlaceholderText = ""
        CuiTextBox23.Rounding = 8
        CuiTextBox23.Size = New Size(413, 35)
        CuiTextBox23.TabIndex = 8
        CuiTextBox23.TextOffset = New Size(0, 0)
        CuiTextBox23.UnderlinedStyle = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(28, 332)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 26)
        Label7.TabIndex = 11
        Label7.Text = "Address"
        ' 
        ' CuiTextBox24
        ' 
        CuiTextBox24.BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiTextBox24.BorderColor = Color.White
        CuiTextBox24.BorderFocusColor = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiTextBox24.BorderSize = 1
        CuiTextBox24.Content = ""
        CuiTextBox24.Font = New Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiTextBox24.ForeColor = Color.Gray
        CuiTextBox24.Location = New Point(28, 362)
        CuiTextBox24.Margin = New Padding(4)
        CuiTextBox24.Multiline = False
        CuiTextBox24.Name = "CuiTextBox24"
        CuiTextBox24.Padding = New Padding(15, 10, 15, 0)
        CuiTextBox24.PasswordChar = False
        CuiTextBox24.PlaceholderColor = Color.DimGray
        CuiTextBox24.PlaceholderText = ""
        CuiTextBox24.Rounding = 8
        CuiTextBox24.Size = New Size(413, 35)
        CuiTextBox24.TabIndex = 10
        CuiTextBox24.TextOffset = New Size(0, 0)
        CuiTextBox24.UnderlinedStyle = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(28, 411)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 26)
        Label9.TabIndex = 15
        Label9.Text = "Course"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins SemiBold", 11.25F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(245, 412)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 26)
        Label10.TabIndex = 17
        Label10.Text = "Year"
        ' 
        ' CuiComboBox1
        ' 
        CuiComboBox1.BackgroundColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox1.ButtonHoverBackground = Color.FromArgb(CByte(200), CByte(255), CByte(106), CByte(0))
        CuiComboBox1.ButtonHoverOutline = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiComboBox1.ButtonNormalBackground = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox1.ButtonNormalOutline = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox1.ButtonPressedBackground = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiComboBox1.ButtonPressedOutline = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiComboBox1.DropDownBackgroundColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox1.DropDownOutlineColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CuiComboBox1.ExpandArrowColor = Color.White
        CuiComboBox1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiComboBox1.ForeColor = SystemColors.Control
        CuiComboBox1.Location = New Point(28, 441)
        CuiComboBox1.Margin = New Padding(4)
        CuiComboBox1.Name = "CuiComboBox1"
        CuiComboBox1.OutlineColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CuiComboBox1.OutlineThickness = 2F
        CuiComboBox1.Rounding = 12
        CuiComboBox1.Size = New Size(209, 35)
        CuiComboBox1.TabIndex = 18
        ' 
        ' CuiComboBox2
        ' 
        CuiComboBox2.BackgroundColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox2.ButtonHoverBackground = Color.FromArgb(CByte(200), CByte(255), CByte(106), CByte(0))
        CuiComboBox2.ButtonHoverOutline = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiComboBox2.ButtonNormalBackground = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox2.ButtonNormalOutline = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox2.ButtonPressedBackground = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiComboBox2.ButtonPressedOutline = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiComboBox2.DropDownBackgroundColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        CuiComboBox2.DropDownOutlineColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CuiComboBox2.ExpandArrowColor = Color.White
        CuiComboBox2.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiComboBox2.ForeColor = SystemColors.Control
        CuiComboBox2.Location = New Point(245, 441)
        CuiComboBox2.Margin = New Padding(4)
        CuiComboBox2.Name = "CuiComboBox2"
        CuiComboBox2.OutlineColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CuiComboBox2.OutlineThickness = 2F
        CuiComboBox2.Rounding = 12
        CuiComboBox2.Size = New Size(196, 35)
        CuiComboBox2.TabIndex = 19
        ' 
        ' CuiButton2
        ' 
        CuiButton2.CheckButton = False
        CuiButton2.Checked = False
        CuiButton2.CheckedBackground = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiButton2.CheckedImageTint = Color.White
        CuiButton2.CheckedOutline = Color.FromArgb(CByte(255), CByte(106), CByte(0))
        CuiButton2.Content = "Save Student Information"
        CuiButton2.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CuiButton2.ForeColor = Color.White
        CuiButton2.HoverBackground = Color.FromArgb(CByte(27), CByte(33), CByte(193))
        CuiButton2.HoveredImageTint = Color.White
        CuiButton2.HoverOutline = Color.Empty
        CuiButton2.Image = Nothing
        CuiButton2.ImageAutoCenter = True
        CuiButton2.ImageExpand = New Point(0, 0)
        CuiButton2.ImageOffset = New Point(0, 0)
        CuiButton2.ImageTint = Color.White
        CuiButton2.Location = New Point(28, 490)
        CuiButton2.Name = "CuiButton2"
        CuiButton2.NormalBackground = Color.FromArgb(CByte(11), CByte(13), CByte(78))
        CuiButton2.NormalOutline = Color.Empty
        CuiButton2.OutlineThickness = 1.6F
        CuiButton2.PressedBackground = Color.FromArgb(CByte(27), CByte(33), CByte(193))
        CuiButton2.PressedImageTint = Color.White
        CuiButton2.PressedOutline = Color.Empty
        CuiButton2.Rounding = New Padding(8)
        CuiButton2.Size = New Size(413, 43)
        CuiButton2.TabIndex = 6
        CuiButton2.TextOffset = New Point(0, 0)
        ' 
        ' NewStudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        ClientSize = New Size(1061, 563)
        Controls.Add(CuiButton2)
        Controls.Add(CuiComboBox2)
        Controls.Add(CuiComboBox1)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(CuiTextBox24)
        Controls.Add(Label6)
        Controls.Add(CuiTextBox23)
        Controls.Add(Label5)
        Controls.Add(CuiDateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(CuiTextBox22)
        Controls.Add(CuiTextBox21)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "NewStudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NewStudentForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CuiPictureBox1 As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents CuiTextBox21 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiTextBox22 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CuiDateTimePicker1 As CuoreUI.Controls.cuiDateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CuiTextBox23 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents Label7 As Label
    Friend WithEvents CuiTextBox24 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CuiComboBox1 As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiComboBox2 As CuoreUI.Controls.cuiComboBox
    Friend WithEvents txtStudentId As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CuiButton2 As CuoreUI.Controls.cuiButton
End Class
