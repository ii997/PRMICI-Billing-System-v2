Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class ReportViewer

    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = $"{Application.StartupPath}\Reports\MiscOverallReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = "SELECT 
    s.name, 
    ss.classSection, 
    y.year, 
    m.misc, 
    COUNT(mp.id) AS payment_count,
    SUM(m.amount) AS total_misc_amount,
    SUM(mp.amount) AS total_paid_amount,
    total_fees.total_fee_sum AS total_fee_sum, -- Total fee across all rows in the miscellaneous table
    total_fees.total_fee_sum - SUM(mp.amount) AS total_balance, -- Deduct total paid from total fee
    mp.paymentDate AS pDate,
    sy.schoolYear AS sYear
FROM 
    misc_payments mp
INNER JOIN 
    miscellaneous m ON mp.miscId = m.id 
INNER JOIN 
    school_year sy ON mp.schoolYearId = sy.id 
INNER JOIN 
    students s ON mp.studentId = s.id 
INNER JOIN 
    sections ss ON s.classSectionId = ss.id 
INNER JOIN 
    years y ON s.yearId = y.id
CROSS JOIN 
    (SELECT SUM(amount) AS total_fee_sum FROM miscellaneous) total_fees -- Calculate total fee once and make it available to all rows
WHERE 
    sy.isActive = 1
    AND mp.paymentDate BETWEEN @startDate AND @endDate
GROUP BY 
    s.name, 
          ss.classSection, 
          y.year
ORDER BY  s.name, m.misc"
            Dim cmd As New MySqlCommand(query, cn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Dim startMonth As Integer = DateTimePicker1.Value.Month
            Dim endMonth As Integer = DateTimePicker2.Value.Month

            ' Validate that the selected dates are within the same month
            If startMonth <> endMonth Then
                MsgBox("Invalid date range. Both dates must fall within the same month.", vbExclamation, "Range Error!")
                Return
            End If

            ' Proceed to load the report
            LoadReport()
        Else
            ' Load a filtered miscellaneous report
            LoadFilteredMiscReport()
        End If
    End Sub


    Private Sub ReportViewer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMiscs()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub loadMiscs()

        ' Define the query to retrieve data
        Dim query As String = "SELECT id, misc FROM miscellaneous"

        Try
            ' Open the connection
            cn.Open()

            ' Create a command to execute the query
            Using command As New MySqlCommand(query, cn)
                ' Execute the command and retrieve the data into a DataReader
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim table As New DataTable()
                    table.Load(reader)

                    ' Bind the ComboBox to the data
                    ComboBox1.DataSource = table
                    ComboBox1.ValueMember = "id"
                    ComboBox1.DisplayMember = "misc"
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions (e.g., log the error or show a message to the user)
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            cn.Close()
        End Try

    End Sub

    Sub LoadFilteredMiscReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = $"{Application.StartupPath}\Reports\MiscsReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2
            Dim da As New MySqlDataAdapter

            cn.Open()

            Dim query As String = "SELECT 
    m.misc, 
    SUM(mp.amount) AS total_payments, 
    SUM(mp.balance) AS total_balance, 
    COUNT(mp.id) AS payment_count, 
    MAX(sy.schoolYear) AS schoolYear, 
    MAX(y.year) AS year,
    MIN(mp.paymentDate) AS earliest_payment_date,
    MAX(mp.paymentDate) AS latest_payment_date
FROM 
    misc_payments mp 
INNER JOIN 
    miscellaneous m ON mp.miscId = m.id 
INNER JOIN 
    school_year sy ON mp.schoolYearId = sy.id 
INNER JOIN 
    students s ON mp.studentId = s.id 
INNER JOIN 
    sections ss ON s.classSectionId = ss.id 
INNER JOIN 
    years y ON s.yearId = y.id
WHERE 
    sy.isActive = 1  
    AND mp.paymentDate BETWEEN @startDate AND @endDate
    AND m.misc LIKE @misc
GROUP BY 
    m.misc"

            Dim cmd As New MySqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@misc", "%" & ComboBox1.Text & "%")
            cmd.Parameters.AddWithValue("@startDate", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@endDate", DateTimePicker2.Value.ToString("yyyy-MM-dd"))

            da.SelectCommand = cmd
            da.Fill(ds.Tables("MiscReport"))

            cn.Close()


            rptDS = New ReportDataSource("DataSet1", ds.Tables("MiscReport"))
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