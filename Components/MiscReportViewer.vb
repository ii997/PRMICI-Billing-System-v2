Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class ReportViewer

    Sub LoadReport()
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

            Dim query As String = "SELECT        mp.id, mp.studentId, s.name, ss.classSection, y.year, m.misc, m.amount AS misc_amount, mp.amount, mp.balance, mp.paymentDate, sy.schoolYear
FROM            misc_payments mp INNER JOIN
                         miscellaneous m ON mp.miscId = m.id INNER JOIN
                         school_year sy ON mp.schoolYearId = sy.id INNER JOIN
                         students s ON mp.studentId = s.id INNER JOIN
                         sections ss ON s.classSectionId = ss.id INNER JOIN
                         years y ON s.yearId = y.id
WHERE        (sy.isActive = 1)  
AND DATE(mp.paymentDate) BETWEEN @startDate AND @endDate AND m.misc LIKE @misc"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadReport()
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

End Class