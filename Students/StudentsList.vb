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
        StudentUpdateForm.CuiTextBox21.Enabled = False
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

    Sub LoadReport()
        Dim rptDS As ReportDataSource
        StudentPaymentsReportViewer.ReportViewer1.RefreshReport()

        Try
            With StudentPaymentsReportViewer.ReportViewer1.LocalReport
                .ReportPath = "C:\Users\Marshmellow\source\repos\PRMICI Billing System v2\Reports\StudentSummary.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT        mp.id, m.misc, mp.studentId, s.name, s.address, s.classSectionId, sc.classSection, mp.amount, mp.paymentDate, mp.paymentStatus, mp.schoolYearId, y.year, sy.schoolYear AS s
FROM            misc_payments mp INNER JOIN
                         years y ON mp.schoolYearId = y.id INNER JOIN
                         students s ON mp.studentId = s.id INNER JOIN
                         sections sc ON s.classSectionId = sc.id INNER JOIN
                         miscellaneous m ON mp.miscId = m.id INNER JOIN
                         school_year sy ON mp.schoolYearId = sy.id WHERE mp.studentId ={DataGridView1.CurrentRow.Cells(0).Value} AND sy.isActive = 1"
            Dim cmd As New MySqlCommand(query, cn)
            da.SelectCommand = cmd
            da.Fill(ds.Tables("DataTable1"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
            StudentPaymentsReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDS)
            StudentPaymentsReportViewer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            StudentPaymentsReportViewer.ReportViewer1.ZoomMode = ZoomMode.Percent
            StudentPaymentsReportViewer.ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, "Error!")
        Finally
            StudentPaymentsReportViewer.ShowDialog()
        End Try
    End Sub

    Sub LoadTuitionsSummary()
        Dim rptDS As ReportDataSource
        StudentPaymentsReportViewer.ReportViewer1.RefreshReport()

        Try
            With StudentPaymentsReportViewer.ReportViewer1.LocalReport
                .ReportPath = "C:\Users\Marshmellow\source\repos\PRMICI Billing System v2\Reports\TuitionStudentSummary.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT        s.id, s.studentID, s.name, s.birthdate, s.age, s.address, s.classSectionId, s.yearId, s.qrCode, t.id AS Expr1, t.studentId AS Expr2, t.amountPaid, t.balance, t.paymentDate, t.schoolYearId
FROM            tuition t INNER JOIN
                         years y ON t.schoolYearId = y.id INNER JOIN
                         students s ON t.studentId = s.id INNER JOIN
                         sections sc ON s.classSectionId = sc.id INNER JOIN
                         school_year sy ON t.schoolYearId = sy.id WHERE t.studentId ={DataGridView1.CurrentRow.Cells(0).Value} AND sy.isActive = 1"
            Dim cmd As New MySqlCommand(query, cn)
            da.SelectCommand = cmd
            da.Fill(ds.Tables("DataTable2"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable2"))
            StudentPaymentsReportViewer.ReportViewer1.LocalReport.DataSources.Add(rptDS)
            StudentPaymentsReportViewer.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            StudentPaymentsReportViewer.ReportViewer1.ZoomMode = ZoomMode.Percent
            StudentPaymentsReportViewer.ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, "Error!")
        Finally
            StudentPaymentsReportViewer.ShowDialog()
        End Try
    End Sub

    Private Sub MiscellaneousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiscellaneousToolStripMenuItem.Click
        LoadReport()
    End Sub

    Private Sub TuitionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TuitionsToolStripMenuItem.Click
        LoadTuitionsSummary()
    End Sub
End Class