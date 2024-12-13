Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class StudentsList
    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        NewStudentForm.ShowDialog()
    End Sub

    Private Sub StudentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click
        SearchStudentInfo(searchInput:=tbSearch.Content.Trim())
    End Sub

    Private Sub ViewQRCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewQRCodeToolStripMenuItem.Click
        RetrieveQRCode(DataGridView1.CurrentRow.Cells(0).Value.ToString(), DataGridView1.CurrentRow.Cells(2).Value.ToString())
    End Sub

    Private Sub EditStudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentInformationToolStripMenuItem.Click
        StudentUpdateForm.Guna2TextBox1.Enabled = False
        StudentUpdateForm.RetrieveStudentdata(DataGridView1.CurrentRow.Cells(0).Value.ToString())
        StudentUpdateForm.ShowDialog()
    End Sub

    Private Sub StudentCourseYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentCourseYearToolStripMenuItem.Click
        UpdateSectionYear.txtId.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        UpdateSectionYear.ShowDialog()
    End Sub

    Private Sub CuiButton3_Click(sender As Object, e As EventArgs) Handles CuiButton3.Click
        QRCodeListViewer.ShowDialog()
    End Sub



    Private Sub MiscellaneousToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'LoadReport()
    End Sub

    Private Sub TuitionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '  LoadTuitionsSummary()
    End Sub

    Private Sub GenerateStudentPaymentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateStudentPaymentsToolStripMenuItem.Click
        StudentPaymentsReportViewer.ShowDialog()
    End Sub
End Class