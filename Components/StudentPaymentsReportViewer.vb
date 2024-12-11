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

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT 
    mp.id, 
    mp.studentId, 
    s.name, 
    ss.classSection, 
    y.year, 
    m.misc, 
    m.amount AS misc_amount, 
    COALESCE(mp.amount, 0) AS amount, 
    COALESCE(mp.balance, 0) AS balance, 
    mp.paymentDate, 
    sy.schoolYear
FROM 
    misc_payments mp
LEFT JOIN 
    miscellaneous m ON mp.miscId = m.id
LEFT JOIN 
    school_year sy ON mp.schoolYearId = sy.id
LEFT JOIN 
    students s ON mp.studentId = s.id
LEFT JOIN 
    sections ss ON s.classSectionId = ss.id
LEFT JOIN 
    years y ON s.yearId = y.id
WHERE 
    mp.studentId = @studentId;
"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@studentId", StudentsList.DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand = cmd
            da.Fill(ds.Tables("DataTable1"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
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

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT 
    m.*, 
    COALESCE(SUM(mp.amount), 0) AS totalPayments
FROM 
    miscellaneous m
LEFT JOIN 
    misc_payments mp ON mp.miscId = m.id AND mp.studentId = @studentId  -- Filter for the specific student
LEFT JOIN 
    school_year sy ON mp.schoolYearId = sy.id
WHERE 
    (sy.isActive = 1 OR sy.isActive IS NULL)  -- Only active school years, or allow for NULL if applicable
GROUP BY 
    m.id;
"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@studentId", StudentsList.DataGridView1.CurrentRow.Cells(0).Value)
            da.SelectCommand = cmd
            da.Fill(ds.Tables("DataTable3"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable3"))
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

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = $"SELECT        s.id, s.studentID, s.name, s.birthdate, s.age, s.address, s.classSectionId, s.yearId, s.qrCode, t.id AS Expr1, t.studentId AS Expr2, t.amountPaid, t.balance, t.paymentDate, t.schoolYearId
FROM            tuition t INNER JOIN
                         years y ON t.schoolYearId = y.id INNER JOIN
                         students s ON t.studentId = s.id INNER JOIN
                         sections sc ON s.classSectionId = sc.id INNER JOIN
                         school_year sy ON t.schoolYearId = sy.id WHERE t.studentId ={StudentsList.DataGridView1.CurrentRow.Cells(0).Value} AND DATE(t.paymentDate) BETWEEN @startDate AND @endDate AND sy.isActive = 1"
            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand = cmd
            da.Fill(ds.Tables("DataTable2"))
            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataTable2"))
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