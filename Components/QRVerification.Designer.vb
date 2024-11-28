<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRVerification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QRVerification))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        tbQRcode = New TextBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(82, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(285, 247)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Poppins SemiBold", 16.75F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 289)
        Label1.Name = "Label1"
        Label1.Size = New Size(427, 37)
        Label1.TabIndex = 2
        Label1.Text = "SCAN STUDENT QR CODE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbQRcode
        ' 
        tbQRcode.Location = New Point(82, 249)
        tbQRcode.Name = "tbQRcode"
        tbQRcode.Size = New Size(285, 23)
        tbQRcode.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(423, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 22)
        Label3.TabIndex = 5
        Label3.Text = "x"
        ' 
        ' QRVerification
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        ClientSize = New Size(451, 339)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(tbQRcode)
        FormBorderStyle = FormBorderStyle.None
        Name = "QRVerification"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student QR Verification"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbQRcode As TextBox
    Friend WithEvents Label3 As Label
End Class
