<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsList
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuiButton1 = New CuoreUI.Controls.cuiButton()
        Me.tbSearch = New CuoreUI.Controls.cuiTextBox2()
        Me.CuiButton2 = New CuoreUI.Controls.cuiButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditStudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentCourseYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewQRCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateStudentPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuitionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiscellaneousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuiButton3 = New CuoreUI.Controls.cuiButton()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Students List"
        '
        'CuiButton1
        '
        Me.CuiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CuiButton1.CheckButton = False
        Me.CuiButton1.Checked = False
        Me.CuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.Content = "New Student"
        Me.CuiButton1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton1.ForeColor = System.Drawing.Color.White
        Me.CuiButton1.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton1.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Image = Nothing
        Me.CuiButton1.ImageAutoCenter = True
        Me.CuiButton1.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton1.ImageTint = System.Drawing.Color.White
        Me.CuiButton1.Location = New System.Drawing.Point(10, 524)
        Me.CuiButton1.Name = "CuiButton1"
        Me.CuiButton1.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiButton1.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton1.OutlineThickness = 1.6!
        Me.CuiButton1.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton1.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton1.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton1.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton1.Size = New System.Drawing.Size(117, 29)
        Me.CuiButton1.TabIndex = 3
        Me.CuiButton1.TextOffset = New System.Drawing.Point(0, 0)
        '
        'tbSearch
        '
        Me.tbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.tbSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSearch.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.tbSearch.BorderSize = 1
        Me.tbSearch.Content = ""
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.ForeColor = System.Drawing.Color.Gray
        Me.tbSearch.Location = New System.Drawing.Point(134, 525)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.tbSearch.Multiline = False
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Padding = New System.Windows.Forms.Padding(20, 4, 20, 0)
        Me.tbSearch.PasswordChar = False
        Me.tbSearch.PlaceholderColor = System.Drawing.Color.White
        Me.tbSearch.PlaceholderText = "Search by Id, Name etc."
        Me.tbSearch.Rounding = 8
        Me.tbSearch.Size = New System.Drawing.Size(266, 29)
        Me.tbSearch.TabIndex = 4
        Me.tbSearch.TextOffset = New System.Drawing.Size(0, 0)
        Me.tbSearch.UnderlinedStyle = False
        '
        'CuiButton2
        '
        Me.CuiButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CuiButton2.CheckButton = False
        Me.CuiButton2.Checked = False
        Me.CuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.Content = "Search"
        Me.CuiButton2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton2.ForeColor = System.Drawing.Color.White
        Me.CuiButton2.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton2.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton2.Image = Nothing
        Me.CuiButton2.ImageAutoCenter = True
        Me.CuiButton2.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton2.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton2.ImageTint = System.Drawing.Color.White
        Me.CuiButton2.Location = New System.Drawing.Point(405, 525)
        Me.CuiButton2.Name = "CuiButton2"
        Me.CuiButton2.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiButton2.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton2.OutlineThickness = 1.6!
        Me.CuiButton2.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton2.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton2.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton2.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton2.Size = New System.Drawing.Size(99, 29)
        Me.CuiButton2.TabIndex = 5
        Me.CuiButton2.TextOffset = New System.Drawing.Point(0, 0)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditStudentToolStripMenuItem, Me.ViewStudentToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 104)
        '
        'EditStudentToolStripMenuItem
        '
        Me.EditStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditStudentInformationToolStripMenuItem, Me.StudentCourseYearToolStripMenuItem})
        Me.EditStudentToolStripMenuItem.Name = "EditStudentToolStripMenuItem"
        Me.EditStudentToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.EditStudentToolStripMenuItem.Text = "Update Student"
        '
        'EditStudentInformationToolStripMenuItem
        '
        Me.EditStudentInformationToolStripMenuItem.Name = "EditStudentInformationToolStripMenuItem"
        Me.EditStudentInformationToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.EditStudentInformationToolStripMenuItem.Text = "Student Information"
        '
        'StudentCourseYearToolStripMenuItem
        '
        Me.StudentCourseYearToolStripMenuItem.Name = "StudentCourseYearToolStripMenuItem"
        Me.StudentCourseYearToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.StudentCourseYearToolStripMenuItem.Text = "Section/Yea(Grade)r"
        '
        'ViewStudentToolStripMenuItem
        '
        Me.ViewStudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewQRCodeToolStripMenuItem})
        Me.ViewStudentToolStripMenuItem.Name = "ViewStudentToolStripMenuItem"
        Me.ViewStudentToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ViewStudentToolStripMenuItem.Text = "View Student"
        '
        'ViewQRCodeToolStripMenuItem
        '
        Me.ViewQRCodeToolStripMenuItem.Name = "ViewQRCodeToolStripMenuItem"
        Me.ViewQRCodeToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.ViewQRCodeToolStripMenuItem.Text = "View QR Code"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateStudentPaymentsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'GenerateStudentPaymentsToolStripMenuItem
        '
        Me.GenerateStudentPaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TuitionsToolStripMenuItem, Me.MiscellaneousToolStripMenuItem})
        Me.GenerateStudentPaymentsToolStripMenuItem.Name = "GenerateStudentPaymentsToolStripMenuItem"
        Me.GenerateStudentPaymentsToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.GenerateStudentPaymentsToolStripMenuItem.Text = "Generate Student Payments"
        '
        'TuitionsToolStripMenuItem
        '
        Me.TuitionsToolStripMenuItem.Name = "TuitionsToolStripMenuItem"
        Me.TuitionsToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.TuitionsToolStripMenuItem.Text = "Tuitions"
        '
        'MiscellaneousToolStripMenuItem
        '
        Me.MiscellaneousToolStripMenuItem.Name = "MiscellaneousToolStripMenuItem"
        Me.MiscellaneousToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.MiscellaneousToolStripMenuItem.Text = "Miscellaneous"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(10, 51)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 45
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(999, 468)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Student ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle2.Format = "D"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "Birth Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Age"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Address"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Section Id"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "Section"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Year Id"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Year"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'CuiButton3
        '
        Me.CuiButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CuiButton3.CheckButton = False
        Me.CuiButton3.Checked = False
        Me.CuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton3.CheckedImageTint = System.Drawing.Color.White
        Me.CuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton3.Content = "Generate QR Codes"
        Me.CuiButton3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuiButton3.ForeColor = System.Drawing.Color.White
        Me.CuiButton3.HoverBackground = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton3.HoveredImageTint = System.Drawing.Color.White
        Me.CuiButton3.HoverOutline = System.Drawing.Color.Empty
        Me.CuiButton3.Image = Nothing
        Me.CuiButton3.ImageAutoCenter = True
        Me.CuiButton3.ImageExpand = New System.Drawing.Point(0, 0)
        Me.CuiButton3.ImageOffset = New System.Drawing.Point(0, 0)
        Me.CuiButton3.ImageTint = System.Drawing.Color.White
        Me.CuiButton3.Location = New System.Drawing.Point(510, 525)
        Me.CuiButton3.Name = "CuiButton3"
        Me.CuiButton3.NormalBackground = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CuiButton3.NormalOutline = System.Drawing.Color.Empty
        Me.CuiButton3.OutlineThickness = 1.6!
        Me.CuiButton3.PressedBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CuiButton3.PressedImageTint = System.Drawing.Color.White
        Me.CuiButton3.PressedOutline = System.Drawing.Color.Empty
        Me.CuiButton3.Rounding = New System.Windows.Forms.Padding(8)
        Me.CuiButton3.Size = New System.Drawing.Size(171, 29)
        Me.CuiButton3.TabIndex = 7
        Me.CuiButton3.TextOffset = New System.Drawing.Point(0, 0)
        '
        'StudentsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 564)
        Me.Controls.Add(Me.CuiButton3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CuiButton2)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.CuiButton1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentsList"
        Me.Text = "StudentsList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CuiButton1 As CuoreUI.Controls.cuiButton
    Friend WithEvents tbSearch As CuoreUI.Controls.cuiTextBox2
    Friend WithEvents CuiButton2 As CuoreUI.Controls.cuiButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ViewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewQRCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents EditStudentInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentCourseYearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuiButton3 As CuoreUI.Controls.cuiButton
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateStudentPaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuitionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiscellaneousToolStripMenuItem As ToolStripMenuItem
End Class
