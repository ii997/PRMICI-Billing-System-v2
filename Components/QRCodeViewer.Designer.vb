<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRCodeViewer
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
        txtStudentId = New Label()
        Label2 = New Label()
        CuiPictureBox1 = New CuoreUI.Controls.cuiPictureBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Font = New Font("Poppins SemiBold", 15.25F, FontStyle.Bold)
        txtStudentId.ForeColor = Color.White
        txtStudentId.Location = New Point(54, 372)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(567, 37)
        txtStudentId.TabIndex = 8
        txtStudentId.Text = "--"
        txtStudentId.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Poppins SemiBold", 15.25F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(54, 331)
        Label2.Name = "Label2"
        Label2.Size = New Size(567, 37)
        Label2.TabIndex = 7
        Label2.Text = "STUDENT UNIQUE QR CODE FOR"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CuiPictureBox1
        ' 
        CuiPictureBox1.BackgroundImageLayout = ImageLayout.Center
        CuiPictureBox1.Content = Nothing
        CuiPictureBox1.CornerRadius = 8
        CuiPictureBox1.ImageTint = Color.White
        CuiPictureBox1.Location = New Point(206, 64)
        CuiPictureBox1.Margin = New Padding(4, 3, 4, 3)
        CuiPictureBox1.Name = "CuiPictureBox1"
        CuiPictureBox1.Size = New Size(259, 243)
        CuiPictureBox1.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.Cursor = Cursors.Hand
        Label1.Font = New Font("Poppins SemiBold", 12.25F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(632, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 34)
        Label1.TabIndex = 9
        Label1.Text = "X"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' QRCodeViewer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(41), CByte(232))
        ClientSize = New Size(674, 431)
        Controls.Add(Label1)
        Controls.Add(txtStudentId)
        Controls.Add(Label2)
        Controls.Add(CuiPictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "QRCodeViewer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "QRCodeViewer"
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtStudentId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CuiPictureBox1 As CuoreUI.Controls.cuiPictureBox
    Friend WithEvents Label1 As Label
End Class
