Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class StudentPaymentsReportViewer
    Private Sub StudentPaymentsReportViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Please specify your report!", vbExclamation, "Error!")
            Return
        Else
            If ComboBox1.SelectedIndex = 0 Then
                LoadTuitionsSummary()
            ElseIf ComboBox1.SelectedIndex = 1 Then
                LoadReport()
            Else
                LoadUnpaidMisc()
            End If
        End If
    End Sub

    Sub LoadReport()
        Dim rptDS As ReportDataSource
        ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = $"{Application.StartupPath}\Reports\StudentSummary.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT        mp.id, mp.studentId, s.name, ss.classSection, y.year, m.misc, m.amount AS misc_amount, mp.amount, mp.balance, mp.paymentDate, sy.schoolYear
FROM            misc_payments mp INNER JOIN
                         miscellaneous m ON mp.miscId = m.id INNER JOIN
                         school_year sy ON mp.schoolYearId = sy.id INNER JOIN
                         students s ON mp.studentId = s.id INNER JOIN
                         sections ss ON s.classSectionId = ss.id INNER JOIN
                         years y ON s.yearId = y.id
WHERE  mp.studentId = @studentId AND mp.paymentDate BETWEEN @startDate AND @endDate AND sy.isActive = 1
"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@studentId", StudentsList.DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand = cmd
            da.Fill(ds.Tables("StudentMiscsSummary"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("StudentMiscsSummary"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, "Error!")
        End Try
    End Sub

    Sub LoadUnpaidMisc()
        Dim rptDS As ReportDataSource
        ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = $"{Application.StartupPath}\Reports\UnpaidMisc.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT 
    m.*,
    COALESCE(SUM(mp.amount), 0) AS totalPayments,
    (m.amount - COALESCE(SUM(mp.amount), 0)) AS balance
FROM 
    miscellaneous m
LEFT JOIN 
    misc_payments mp ON mp.miscId = m.id AND mp.studentId = @studentId
LEFT JOIN 
    school_year sy ON mp.schoolYearId = sy.id
WHERE 
    (sy.isActive = 1 OR sy.isActive IS NULL)
GROUP BY 
    m.id
"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@studentId", StudentsList.DataGridView1.CurrentRow.Cells(0).Value)
            da.SelectCommand = cmd
            da.Fill(ds.Tables("UnpaidMiscs"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("UnpaidMiscs"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, "Error!")
        End Try
    End Sub

    Sub LoadTuitionsSummary()
        Dim rptDS As ReportDataSource
        ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = $"{Application.StartupPath}\Reports\TuitionStudentSummary.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT        s.id, s.studentID, s.name, s.birthdate, s.age, s.address, s.classSectionId, s.yearId, s.qrCode, t.id AS Expr1, t.studentId AS Expr2, t.amountPaid, t.balance, t.paymentDate, t.schoolYearId
FROM            tuition t INNER JOIN
                         years y ON t.schoolYearId = y.id INNER JOIN
                         students s ON t.studentId = s.id INNER JOIN
                         sections sc ON s.classSectionId = sc.id INNER JOIN
                         school_year sy ON t.schoolYearId = sy.id WHERE t.studentId = @studentId AND t.paymentDate BETWEEN @startDate AND @endDate AND sy.isActive = 1"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@studentId", StudentsList.DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand = cmd
            da.Fill(ds.Tables("StudentTuitionsSummary"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("StudentTuitionsSummary"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, "Error!")
        End Try
    End Sub
End Class