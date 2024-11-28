<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewMiscPayment
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CuiButton1 = New CuoreUI.Controls.cuiButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tbamount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "New Misc Payment"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Miscellaneous"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Amount"
        '
        'CuiButton1
        '
        Me.CuiButton1.CheckButton = False
        Me.CuiButton1.Checked = False
        Me.CuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.Content = "Save Payment"
        Me.CuiButton1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton1.ForeColor = System.Drawing.Color.White
        Me.CuiButton1.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.CuiButton1.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton1.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Image = Nothing
        Me.CuiButton1.ImageAutoCenter = True
        Me.CuiButton1.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageTint = System.Drawing.Color.White
        Me.CuiButton1.Location = New System.Drawing.Point(20, 193)
        Me.CuiButton1.Name = "CuiButton1"
        Me.CuiButton1.NormalBackground = System.Drawing.Color.Transparent
        Me.CuiButton1.NormalOutline = System.Drawing.Color.White
        Me.CuiButton1.OutlineThickness = 2.0!
        Me.CuiButton1.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.CuiButton1.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton1.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton1.Size = New System.Drawing.Size(273, 44)
        Me.CuiButton1.TabIndex = 32
        Me.CuiButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ComboBox1.DropDownHeight = 108
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(20, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(273, 31)
        Me.ComboBox1.TabIndex = 33
        '
        'tbamount
        '
        Me.tbamount.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbamount.Location = New System.Drawing.Point(20, 139)
        Me.tbamount.Name = "tbamount"
        Me.tbamount.Size = New System.Drawing.Size(273, 27)
        Me.tbamount.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(102, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 23)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "New Misc Payment"
        '
        'NewMiscPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 256)
        Me.Controls.Add(Me.tbamount)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CuiButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewMiscPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewMiscPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tbamount As TextBox
    Friend WithEvents Label5 As Label
End Class
