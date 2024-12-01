Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class TuitionsReportViewer
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = $"{Application.StartupPath}\Reports\TuitionsReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = "SELECT t.id, t.studentId, s.name, s.classSectionId, ss.classSection, t.amountPaid, t.balance, t.paymentDate, t.schoolYearId,  sy.schoolYear, sy.IsActive " &
                      "FROM tuition t " &
                      "INNER JOIN students s ON t.studentId = s.id " &
                      "INNER JOIN school_year sy ON t.schoolYearId = sy.id " &
                      "INNER JOIN sections ss ON s.classSectionId = ss.id " &
                      "WHERE sy.IsActive = 1 AND DATE(t.paymentDate) BETWEEN @startDate AND @endDate"

            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.ToString("yyyy-MM-dd"))

            da.SelectCommand = cmd
            da.Fill(ds.Tables("TuitionsReport"))

            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("TuitionsReport"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical, "Error!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadReport()
    End Sub

    Private Sub ReportViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class