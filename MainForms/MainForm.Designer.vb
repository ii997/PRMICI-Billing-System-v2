<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CuiButton3 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton5 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton8 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton7 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton4 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton6 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton2 = New CuoreUI.Controls.cuiButton()
        Me.CuiButton1 = New CuoreUI.Controls.cuiButton()
        Me.CuiPictureBox1 = New CuoreUI.Controls.cuiPictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CuiButton3)
        Me.Panel1.Controls.Add(Me.CuiButton5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.CuiButton6)
        Me.Panel1.Controls.Add(Me.CuiButton2)
        Me.Panel1.Controls.Add(Me.CuiButton1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 690)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.CuiButton8)
        Me.Panel4.Controls.Add(Me.CuiButton7)
        Me.Panel4.Controls.Add(Me.CuiButton4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 303)
        Me.Panel4.MaximumSize = New System.Drawing.Size(248, 156)
        Me.Panel4.MinimumSize = New System.Drawing.Size(248, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(248, 52)
        Me.Panel4.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CuiPictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 199)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(248, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(944, 690)
        Me.Panel3.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'Timer2
        '
        Me.Timer2.Interval = 5
        '
        'CuiButton3
        '
        Me.CuiButton3.CheckButton = False
        Me.CuiButton3.Checked = False
        Me.CuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton3.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton3.Content = "Settings"
        Me.CuiButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton3.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton3.ForeColor = System.Drawing.Color.Black
        Me.CuiButton3.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton3.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton3.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton3.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.settings
        Me.CuiButton3.ImageAutoCenter = False
        Me.CuiButton3.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton3.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton3.ImageTint = System.Drawing.Color.White
        Me.CuiButton3.Location = New System.Drawing.Point(0, 407)
        Me.CuiButton3.Name = "CuiButton3"
        Me.CuiButton3.NormalBackground = System.Drawing.Color.White
        Me.CuiButton3.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton3.OutlineThickness = 1.6!
        Me.CuiButton3.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton3.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton3.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton3.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton3.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton3.TabIndex = 8
        Me.CuiButton3.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton5
        '
        Me.CuiButton5.CheckButton = False
        Me.CuiButton5.Checked = False
        Me.CuiButton5.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton5.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton5.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton5.Content = "School Year"
        Me.CuiButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton5.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton5.ForeColor = System.Drawing.Color.Black
        Me.CuiButton5.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton5.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton5.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton5.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.icons8_school_96
        Me.CuiButton5.ImageAutoCenter = False
        Me.CuiButton5.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton5.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton5.ImageTint = System.Drawing.Color.White
        Me.CuiButton5.Location = New System.Drawing.Point(0, 355)
        Me.CuiButton5.Name = "CuiButton5"
        Me.CuiButton5.NormalBackground = System.Drawing.Color.White
        Me.CuiButton5.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton5.OutlineThickness = 1.6!
        Me.CuiButton5.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton5.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton5.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton5.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton5.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton5.TabIndex = 5
        Me.CuiButton5.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton8
        '
        Me.CuiButton8.CheckButton = False
        Me.CuiButton8.Checked = False
        Me.CuiButton8.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton8.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton8.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton8.Content = "Tuition"
        Me.CuiButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton8.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton8.ForeColor = System.Drawing.Color.Black
        Me.CuiButton8.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton8.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton8.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton8.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.fee_receipt
        Me.CuiButton8.ImageAutoCenter = False
        Me.CuiButton8.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton8.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton8.ImageTint = System.Drawing.Color.White
        Me.CuiButton8.Location = New System.Drawing.Point(0, 104)
        Me.CuiButton8.Name = "CuiButton8"
        Me.CuiButton8.NormalBackground = System.Drawing.Color.WhiteSmoke
        Me.CuiButton8.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton8.OutlineThickness = 1.6!
        Me.CuiButton8.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton8.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton8.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton8.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton8.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton8.TabIndex = 6
        Me.CuiButton8.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton7
        '
        Me.CuiButton7.CheckButton = False
        Me.CuiButton7.Checked = False
        Me.CuiButton7.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton7.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton7.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton7.Content = "Miscellaneous"
        Me.CuiButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton7.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton7.ForeColor = System.Drawing.Color.Black
        Me.CuiButton7.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton7.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton7.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton7.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.chart_simple_horizontal
        Me.CuiButton7.ImageAutoCenter = False
        Me.CuiButton7.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton7.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton7.ImageTint = System.Drawing.Color.White
        Me.CuiButton7.Location = New System.Drawing.Point(0, 52)
        Me.CuiButton7.Name = "CuiButton7"
        Me.CuiButton7.NormalBackground = System.Drawing.Color.WhiteSmoke
        Me.CuiButton7.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton7.OutlineThickness = 1.6!
        Me.CuiButton7.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton7.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton7.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton7.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton7.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton7.TabIndex = 5
        Me.CuiButton7.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton4
        '
        Me.CuiButton4.CheckButton = False
        Me.CuiButton4.Checked = False
        Me.CuiButton4.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton4.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton4.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton4.Content = "Payments"
        Me.CuiButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton4.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton4.ForeColor = System.Drawing.Color.Black
        Me.CuiButton4.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton4.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton4.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton4.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.hand_bill
        Me.CuiButton4.ImageAutoCenter = False
        Me.CuiButton4.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton4.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton4.ImageTint = System.Drawing.Color.White
        Me.CuiButton4.Location = New System.Drawing.Point(0, 0)
        Me.CuiButton4.Name = "CuiButton4"
        Me.CuiButton4.NormalBackground = System.Drawing.Color.White
        Me.CuiButton4.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton4.OutlineThickness = 1.6!
        Me.CuiButton4.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton4.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton4.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton4.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton4.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton4.TabIndex = 4
        Me.CuiButton4.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton6
        '
        Me.CuiButton6.CheckButton = False
        Me.CuiButton6.Checked = False
        Me.CuiButton6.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton6.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton6.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton6.Content = "Log-out"
        Me.CuiButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CuiButton6.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton6.ForeColor = System.Drawing.Color.Black
        Me.CuiButton6.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton6.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton6.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton6.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.power
        Me.CuiButton6.ImageAutoCenter = False
        Me.CuiButton6.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton6.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton6.ImageTint = System.Drawing.Color.White
        Me.CuiButton6.Location = New System.Drawing.Point(0, 638)
        Me.CuiButton6.Name = "CuiButton6"
        Me.CuiButton6.NormalBackground = System.Drawing.Color.White
        Me.CuiButton6.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton6.OutlineThickness = 1.6!
        Me.CuiButton6.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton6.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton6.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton6.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton6.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton6.TabIndex = 6
        Me.CuiButton6.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton2
        '
        Me.CuiButton2.CheckButton = False
        Me.CuiButton2.Checked = False
        Me.CuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton2.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton2.Content = "Students"
        Me.CuiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton2.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton2.ForeColor = System.Drawing.Color.Black
        Me.CuiButton2.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton2.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton2.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton2.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.users
        Me.CuiButton2.ImageAutoCenter = False
        Me.CuiButton2.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton2.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton2.ImageTint = System.Drawing.Color.White
        Me.CuiButton2.Location = New System.Drawing.Point(0, 251)
        Me.CuiButton2.Name = "CuiButton2"
        Me.CuiButton2.NormalBackground = System.Drawing.Color.White
        Me.CuiButton2.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton2.OutlineThickness = 1.6!
        Me.CuiButton2.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton2.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton2.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton2.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton2.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton2.TabIndex = 2
        Me.CuiButton2.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiButton1
        '
        Me.CuiButton1.CheckButton = False
        Me.CuiButton1.Checked = False
        Me.CuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton1.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.CuiButton1.Content = "Dashboard"
        Me.CuiButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CuiButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuiButton1.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.CuiButton1.ForeColor = System.Drawing.Color.Black
        Me.CuiButton1.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton1.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton1.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Image = Global.PRMICI_Billing_System_v2.My.Resources.Resources.dashboard
        Me.CuiButton1.ImageAutoCenter = False
        Me.CuiButton1.ImageExpand = New System.Drawing.Point(2, 2)
        Me.CuiButton1.ImageOffset = New System.Drawing.Point(20, 0)
        Me.CuiButton1.ImageTint = System.Drawing.Color.White
        Me.CuiButton1.Location = New System.Drawing.Point(0, 199)
        Me.CuiButton1.Name = "CuiButton1"
        Me.CuiButton1.NormalBackground = System.Drawing.Color.White
        Me.CuiButton1.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton1.OutlineThickness = 1.6!
        Me.CuiButton1.PressedBackground = System.Drawing.Color.Silver
        Me.CuiButton1.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton1.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Rounding = New System.Windows.Forms.Padding(0)
        Me.CuiButton1.Size = New System.Drawing.Size(248, 52)
        Me.CuiButton1.TabIndex = 1
        Me.CuiButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'CuiPictureBox1
        '
        Me.CuiPictureBox1.Content = Global.PRMICI_Billing_System_v2.My.Resources.Resources.image_removebg_preview_pzA2SrKPy_transformed
        Me.CuiPictureBox1.CornerRadius = 0
        Me.CuiPictureBox1.ImageTint = System.Drawing.Color.White
        Me.CuiPictureBox1.Location = New System.Drawing.Point(48, 28)
        Me.CuiPictureBox1.Name = "CuiPictureBox1"
        Me.CuiPictureBox1.Size = New System.Drawing.Size(146, 146)
        Me.CuiPictureBox1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1192, 690)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "PRMICI Billing System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CuiPictureBox1 As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CuiButton4 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiButton2 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiButton5 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiButton6 As CuoreUI.Controls.cuiButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CuiButton8 As CuoreUI.Controls.cuiButton
    Friend WithEvents CuiButton7 As CuoreUI.Controls.cuiButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents CuiButton3 As CuoreUI.Controls.cuiButton
End Class
