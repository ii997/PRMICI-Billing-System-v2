<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTuitionPayment
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
        Me.txtTuitionFee = New System.Windows.Forms.Label()
        Me.CuiTextBox21 = New CuoreUI.Controls.cuiTextBox2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.Label()
        Me.CuiButton1 = New CuoreUI.Controls.cuiButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CuiPictureBox1 = New CuoreUI.Controls.cuiPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTuitionFee
        '
        Me.txtTuitionFee.AutoSize = True
        Me.txtTuitionFee.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtTuitionFee.ForeColor = System.Drawing.Color.White
        Me.txtTuitionFee.Location = New System.Drawing.Point(196, 52)
        Me.txtTuitionFee.Name = "txtTuitionFee"
        Me.txtTuitionFee.Size = New System.Drawing.Size(18, 23)
        Me.txtTuitionFee.TabIndex = 0
        Me.txtTuitionFee.Text = "0"
        '
        'CuiTextBox21
        '
        Me.CuiTextBox21.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CuiTextBox21.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CuiTextBox21.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiTextBox21.BorderSize = 1
        Me.CuiTextBox21.Content = ""
        Me.CuiTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CuiTextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiTextBox21.ForeColor = System.Drawing.Color.Gray
        Me.CuiTextBox21.Location = New System.Drawing.Point(41, 205)
        Me.CuiTextBox21.Margin = New System.Windows.Forms.Padding(4)
        Me.CuiTextBox21.Multiline = False
        Me.CuiTextBox21.Name = "CuiTextBox21"
        Me.CuiTextBox21.Padding = New System.Windows.Forms.Padding(15, 12, 15, 0)
        Me.CuiTextBox21.PasswordChar = False
        Me.CuiTextBox21.PlaceholderColor = System.Drawing.Color.DimGray
        Me.CuiTextBox21.PlaceholderText = ""
        Me.CuiTextBox21.Rounding = 8
        Me.CuiTextBox21.Size = New System.Drawing.Size(242, 39)
        Me.CuiTextBox21.TabIndex = 1
        Me.CuiTextBox21.TextOffset = New System.Drawing.Size(0, 0)
        Me.CuiTextBox21.UnderlinedStyle = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cash Tendered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.AutoSize = True
        Me.txtBalance.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtBalance.ForeColor = System.Drawing.Color.White
        Me.txtBalance.Location = New System.Drawing.Point(196, 128)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(18, 23)
        Me.txtBalance.TabIndex = 4
        Me.txtBalance.Text = "0"
        '
        'CuiButton1
        '
        Me.CuiButton1.CheckButton = False
        Me.CuiButton1.Checked = False
        Me.CuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.Content = "Save Payment Info"
        Me.CuiButton1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton1.ForeColor = System.Drawing.Color.White
        Me.CuiButton1.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.CuiButton1.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton1.HoverOutline = System.Drawing.Color.White
        Me.CuiButton1.Image = Nothing
        Me.CuiButton1.ImageAutoCenter = True
        Me.CuiButton1.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageTint = System.Drawing.Color.White
        Me.CuiButton1.Location = New System.Drawing.Point(41, 263)
        Me.CuiButton1.Name = "CuiButton1"
        Me.CuiButton1.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiButton1.NormalOutline = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CuiButton1.OutlineThickness = 1.6!
        Me.CuiButton1.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.CuiButton1.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton1.PressedOutline = System.Drawing.Color.White
        Me.CuiButton1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton1.Size = New System.Drawing.Size(242, 39)
        Me.CuiButton1.TabIndex = 5
        Me.CuiButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "New Tuition Payment"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(597, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "x"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(41, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Current Tuition Fee:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(41, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Current Month:"
        '
        'txtMonth
        '
        Me.txtMonth.AutoSize = True
        Me.txtMonth.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtMonth.ForeColor = System.Drawing.Color.White
        Me.txtMonth.Location = New System.Drawing.Point(196, 75)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(58, 23)
        Me.txtMonth.TabIndex = 11
        Me.txtMonth.Text = "MMMM"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.AutoSize = True
        Me.txtAmountPaid.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtAmountPaid.ForeColor = System.Drawing.Color.White
        Me.txtAmountPaid.Location = New System.Drawing.Point(196, 100)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(18, 23)
        Me.txtAmountPaid.TabIndex = 13
        Me.txtAmountPaid.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(41, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Recent Amount Paid:"
        '
        'CuiPictureBox1
        '
        Me.CuiPictureBox1.Content = Global.PRMICI_Billing_System_v2.My.Resources.Resources.image_removebg_preview_pzA2SrKPy_transformed
        Me.CuiPictureBox1.CornerRadius = 8
        Me.CuiPictureBox1.ImageTint = System.Drawing.Color.White
        Me.CuiPictureBox1.Location = New System.Drawing.Point(349, 52)
        Me.CuiPictureBox1.Name = "CuiPictureBox1"
        Me.CuiPictureBox1.Size = New System.Drawing.Size(220, 225)
        Me.CuiPictureBox1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(413, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "MMMM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(361, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Remaining Balance:"
        '
        'txtRemaining
        '
        Me.txtRemaining.AutoSize = True
        Me.txtRemaining.Font = New System.Drawing.Font("Poppins SemiBold", 9.25!, System.Drawing.FontStyle.Bold)
        Me.txtRemaining.ForeColor = System.Drawing.Color.White
        Me.txtRemaining.Location = New System.Drawing.Point(516, 133)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.Size = New System.Drawing.Size(18, 23)
        Me.txtRemaining.TabIndex = 16
        Me.txtRemaining.Text = "0"
        '
        'NewTuitionPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 328)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CuiButton1)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CuiTextBox21)
        Me.Controls.Add(Me.txtTuitionFee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CuiPictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRemaining)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewTuitionPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewTuitionPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTuitionFee As Label
    Friend WithEvents CuiTextBox21 As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBalance As Label
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMonth As Label
    Friend WithEvents txtAmountPaid As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CuiPictureBox1 As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemaining As Label
End Class
