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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CuiButton1 = New CuoreUI.Controls.cuiButton()
        Me.txtStudentId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CuiPictureBox1 = New CuoreUI.Controls.cuiPictureBox()
        Me.CuiTextBox22 = New CuoreUI.Controls.cuiTextBox2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CuiDateTimePicker1 = New CuoreUI.Controls.cuiDateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CuiTextBox24 = New CuoreUI.Controls.cuiTextBox2()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CuiComboBox1 = New CuoreUI.Controls.cuiComboBox()
        Me.CuiComboBox2 = New CuoreUI.Controls.cuiComboBox()
        Me.CuiButton2 = New CuoreUI.Controls.cuiButton()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 34)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(399, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 26)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New Student"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CuiButton1)
        Me.Panel2.Controls.Add(Me.txtStudentId)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.CuiPictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(423, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 508)
        Me.Panel2.TabIndex = 1
        '
        'CuiButton1
        '
        Me.CuiButton1.CheckButton = False
        Me.CuiButton1.Checked = False
        Me.CuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.Content = "Generate QR Code"
        Me.CuiButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CuiButton1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton1.ForeColor = System.Drawing.Color.White
        Me.CuiButton1.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.CuiButton1.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton1.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Image = Nothing
        Me.CuiButton1.ImageAutoCenter = True
        Me.CuiButton1.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageTint = System.Drawing.Color.White
        Me.CuiButton1.Location = New System.Drawing.Point(66, 437)
        Me.CuiButton1.Name = "CuiButton1"
        Me.CuiButton1.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CuiButton1.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton1.OutlineThickness = 1.6!
        Me.CuiButton1.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.CuiButton1.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton1.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton1.Size = New System.Drawing.Size(354, 37)
        Me.CuiButton1.TabIndex = 3
        Me.CuiButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'txtStudentId
        '
        Me.txtStudentId.Font = New System.Drawing.Font("Poppins SemiBold", 15.25!, System.Drawing.FontStyle.Bold)
        Me.txtStudentId.ForeColor = System.Drawing.Color.White
        Me.txtStudentId.Location = New System.Drawing.Point(0, 395)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(486, 32)
        Me.txtStudentId.TabIndex = 5
        Me.txtStudentId.Text = "--"
        Me.txtStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(486, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STUDENT UNIQUE QR CODE FOR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CuiPictureBox1
        '
        Me.CuiPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CuiPictureBox1.Content = Nothing
        Me.CuiPictureBox1.CornerRadius = 8
        Me.CuiPictureBox1.ImageTint = System.Drawing.Color.White
        Me.CuiPictureBox1.Location = New System.Drawing.Point(114, 83)
        Me.CuiPictureBox1.Name = "CuiPictureBox1"
        Me.CuiPictureBox1.Size = New System.Drawing.Size(241, 248)
        Me.CuiPictureBox1.TabIndex = 0
        '
        'CuiTextBox22
        '
        Me.CuiTextBox22.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiTextBox22.BorderColor = System.Drawing.Color.White
        Me.CuiTextBox22.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiTextBox22.BorderSize = 1
        Me.CuiTextBox22.Content = ""
        Me.CuiTextBox22.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CuiTextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiTextBox22.ForeColor = System.Drawing.Color.White
        Me.CuiTextBox22.Location = New System.Drawing.Point(24, 148)
        Me.CuiTextBox22.Margin = New System.Windows.Forms.Padding(4)
        Me.CuiTextBox22.Multiline = False
        Me.CuiTextBox22.Name = "CuiTextBox22"
        Me.CuiTextBox22.Padding = New System.Windows.Forms.Padding(15, 11, 15, 0)
        Me.CuiTextBox22.PasswordChar = False
        Me.CuiTextBox22.PlaceholderColor = System.Drawing.Color.DimGray
        Me.CuiTextBox22.PlaceholderText = ""
        Me.CuiTextBox22.Rounding = 8
        Me.CuiTextBox22.Size = New System.Drawing.Size(354, 36)
        Me.CuiTextBox22.TabIndex = 3
        Me.CuiTextBox22.TextOffset = New System.Drawing.Size(0, 0)
        Me.CuiTextBox22.UnderlinedStyle = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Student Name"
        '
        'CuiDateTimePicker1
        '
        Me.CuiDateTimePicker1.ArrowColor = System.Drawing.Color.White
        Me.CuiDateTimePicker1.Background = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiDateTimePicker1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiDateTimePicker1.Location = New System.Drawing.Point(24, 216)
        Me.CuiDateTimePicker1.MaximumSize = New System.Drawing.Size(858, 21)
        Me.CuiDateTimePicker1.MinimumSize = New System.Drawing.Size(4, 21)
        Me.CuiDateTimePicker1.Name = "CuiDateTimePicker1"
        Me.CuiDateTimePicker1.Outline = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CuiDateTimePicker1.Rounding = New System.Windows.Forms.Padding(2)
        Me.CuiDateTimePicker1.Size = New System.Drawing.Size(354, 21)
        Me.CuiDateTimePicker1.TabIndex = 6
        Me.CuiDateTimePicker1.TextColor = System.Drawing.Color.White
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Age"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 26)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Address"
        '
        'CuiTextBox24
        '
        Me.CuiTextBox24.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiTextBox24.BorderColor = System.Drawing.Color.White
        Me.CuiTextBox24.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiTextBox24.BorderSize = 1
        Me.CuiTextBox24.Content = ""
        Me.CuiTextBox24.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CuiTextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiTextBox24.ForeColor = System.Drawing.Color.White
        Me.CuiTextBox24.Location = New System.Drawing.Point(24, 340)
        Me.CuiTextBox24.Margin = New System.Windows.Forms.Padding(4)
        Me.CuiTextBox24.Multiline = False
        Me.CuiTextBox24.Name = "CuiTextBox24"
        Me.CuiTextBox24.Padding = New System.Windows.Forms.Padding(15, 11, 15, 0)
        Me.CuiTextBox24.PasswordChar = False
        Me.CuiTextBox24.PlaceholderColor = System.Drawing.Color.DimGray
        Me.CuiTextBox24.PlaceholderText = ""
        Me.CuiTextBox24.Rounding = 8
        Me.CuiTextBox24.Size = New System.Drawing.Size(354, 36)
        Me.CuiTextBox24.TabIndex = 10
        Me.CuiTextBox24.TextOffset = New System.Drawing.Size(0, 0)
        Me.CuiTextBox24.UnderlinedStyle = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(24, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 26)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Section"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins SemiBold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(210, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 26)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Year"
        '
        'CuiComboBox1
        '
        Me.CuiComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox1.ButtonHoverBackground = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox1.ButtonHoverOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox1.ButtonNormalBackground = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox1.ButtonNormalOutline = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox1.ButtonPressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox1.ButtonPressedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox1.DropDownBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox1.DropDownOutlineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiComboBox1.ExpandArrowColor = System.Drawing.Color.White
        Me.CuiComboBox1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiComboBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.CuiComboBox1.Items = New String(-1) {}
        Me.CuiComboBox1.Location = New System.Drawing.Point(24, 406)
        Me.CuiComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CuiComboBox1.Name = "CuiComboBox1"
        Me.CuiComboBox1.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiComboBox1.OutlineThickness = 2.0!
        Me.CuiComboBox1.Rounding = 12
        Me.CuiComboBox1.Size = New System.Drawing.Size(179, 31)
        Me.CuiComboBox1.TabIndex = 18
        '
        'CuiComboBox2
        '
        Me.CuiComboBox2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox2.ButtonHoverBackground = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox2.ButtonHoverOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox2.ButtonNormalBackground = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox2.ButtonNormalOutline = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox2.ButtonPressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox2.ButtonPressedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiComboBox2.DropDownBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiComboBox2.DropDownOutlineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiComboBox2.ExpandArrowColor = System.Drawing.Color.White
        Me.CuiComboBox2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiComboBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.CuiComboBox2.Items = New String(-1) {}
        Me.CuiComboBox2.Location = New System.Drawing.Point(209, 406)
        Me.CuiComboBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CuiComboBox2.Name = "CuiComboBox2"
        Me.CuiComboBox2.OutlineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiComboBox2.OutlineThickness = 2.0!
        Me.CuiComboBox2.Rounding = 12
        Me.CuiComboBox2.Size = New System.Drawing.Size(169, 31)
        Me.CuiComboBox2.TabIndex = 19
        '
        'CuiButton2
        '
        Me.CuiButton2.CheckButton = False
        Me.CuiButton2.Checked = False
        Me.CuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.Content = "Save Student Information"
        Me.CuiButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CuiButton2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton2.ForeColor = System.Drawing.Color.White
        Me.CuiButton2.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.CuiButton2.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton2.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton2.Image = Nothing
        Me.CuiButton2.ImageAutoCenter = True
        Me.CuiButton2.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton2.ImageTint = System.Drawing.Color.White
        Me.CuiButton2.Location = New System.Drawing.Point(24, 447)
        Me.CuiButton2.Name = "CuiButton2"
        Me.CuiButton2.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CuiButton2.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton2.OutlineThickness = 1.6!
        Me.CuiButton2.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.CuiButton2.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton2.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton2.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton2.Size = New System.Drawing.Size(354, 37)
        Me.CuiButton2.TabIndex = 6
        Me.CuiButton2.TextOffset = New System.Drawing.Point(0, 0)
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 8
        Me.Guna2TextBox1.BorderThickness = 2
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(24, 83)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.MaxLength = 9
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(354, 36)
        Me.Guna2TextBox1.TabIndex = 6
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderRadius = 8
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.White
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2TextBox2.Enabled = False
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(24, 270)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.MaxLength = 9
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(354, 36)
        Me.Guna2TextBox2.TabIndex = 20
        '
        'NewStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 508)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.CuiButton2)
        Me.Controls.Add(Me.CuiComboBox2)
        Me.Controls.Add(Me.CuiComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CuiTextBox24)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CuiDateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CuiTextBox22)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewStudentForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CuiPictureBox1 As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiTextBox22 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CuiDateTimePicker1 As CuoreUI.Controls.cuiDateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CuiTextBox24 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CuiComboBox1 As CuoreUI.Controls.cuiComboBox
    Friend WithEvents CuiComboBox2 As CuoreUI.Controls.cuiComboBox
    Friend WithEvents txtStudentId As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CuiButton2 As CuoreUI.Controls.cuiButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
End Class
