﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Module DashboardModule
    Sub RetrieveTotalPayments()
        Try
            Dim totalPayments As Double = 0

            ' Open connection
            cn.Open()

            ' Query to get the sum of all payments for the given student
            Dim query As String = "SELECT IFNULL(SUM(amount), 0) FROM misc_payments INNER JOIN school_year sy ON misc_payments.schoolYearId = sy.id WHERE sy.isActive = 1;
"

            Using cm As New MySqlCommand(query, cn)

                ' Execute the query and get the sum of the payments
                Dim result As Object = cm.ExecuteScalar()

                ' If the result is not null, parse it to a double
                If result IsNot DBNull.Value Then
                    totalPayments = Convert.ToDouble(result)
                End If

                ' Display the result in the TextBox (assuming the TextBox name is txtTotalPayments)
                DashboardForm.txtMiscTotal.Text = totalPayments.ToString("N2") ' Formats as a number with 2 decimals
            End Using

        Catch ex As Exception
            ' Handle any errors that occur during the operation
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub RetrieveTotalStudents()
        Try
            Dim totalPayments As Double = 0

            ' Open connection
            cn.Open()

            ' Query to get the sum of all payments for the given student
            Dim query As String = "SELECT IFNULL(COUNT(id), 0) FROM students  "

            Using cm As New MySqlCommand(query, cn)

                ' Execute the query and get the sum of the payments
                Dim result As Object = cm.ExecuteScalar()

                ' If the result is not null, parse it to a double
                If result IsNot DBNull.Value Then
                    totalPayments = Convert.ToInt32(result)
                End If

                ' Display the result in the TextBox (assuming the TextBox name is txtTotalPayments)
                DashboardForm.txtSumStudents.Text = totalPayments.ToString()
            End Using

        Catch ex As Exception
            ' Handle any errors that occur during the operation
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub RetrieveTotalTuitions()
        Try
            Dim totalPayments As Double = 0

            ' Open connection
            cn.Open()

            ' Query to get the sum of all payments for the given student
            Dim query As String = "SELECT IFNULL(SUM(amountPaid), 0) FROM tuition INNER JOIN school_year sy ON tuition.schoolYearId = sy.id WHERE sy.isActive = 1"

            Using cm As New MySqlCommand(query, cn)

                ' Execute the query and get the sum of the payments
                Dim result As Object = cm.ExecuteScalar()

                ' If the result is not null, parse it to a double
                If result IsNot DBNull.Value Then
                    totalPayments = Convert.ToDouble(result)
                End If

                ' Display the result in the TextBox (assuming the TextBox name is txtTotalPayments)
                DashboardForm.txtTuitionTotal.Text = totalPayments.ToString("N2")
            End Using

        Catch ex As Exception
            ' Handle any errors that occur during the operation
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub LoadMiscsChart()
        Try
            cn.Open()

            ' SQL query to retrieve data
            Dim query As String = "
            SELECT m.id,mc.misc,m.studentId,SUM(m.amount) AS totalPaid,m.paymentDate, m.schoolYearId, sy.schoolYear FROM misc_payments m INNER JOIN miscellaneous mc ON m.miscId = mc.id INNER JOIN school_year sy ON m.schoolYearId = sy.id WHERE sy.isActive = 1 GROUP BY MONTH(m.paymentDate)"

            Using cm As New MySqlCommand(query, cn)
                Using dr As MySqlDataReader = cm.ExecuteReader()

                    ' Clear existing series
                    DashboardForm.Chart1.Series.Clear()

                    ' Create and configure the new series
                    Dim series1 As New Series("Miscellaneous")
                    series1.ChartType = SeriesChartType.Pie
                    series1.IsValueShownAsLabel = True
                    series1.Font = New Drawing.Font("Poppins", 10, FontStyle.Regular)

                    ' Check if there is data to load
                    If dr.HasRows Then
                        While dr.Read()
                            ' Format date to include the full month name and day (e.g., "December 1")
                            Dim formattedDate As String = CDate(dr("paymentDate")).ToString("MMMM")
                            Dim sales As Decimal = Convert.ToDecimal(dr("totalPaid")) ' Convert totalPaid to Decimal

                            ' Add point to series
                            Dim pointIndex As Integer = series1.Points.AddXY(formattedDate, sales)

                            ' Format the label for the added point
                            series1.Points(pointIndex).Label = $"{formattedDate}: {sales.ToString("#,##0")}"
                        End While
                    Else
                        MsgBox("No data available for the current school year.", vbInformation, "No Data")
                    End If

                    ' Add the series to the chart
                    DashboardForm.Chart1.Series.Add(series1)

                    ' Add a title to the chart (avoid duplicates)
                    If DashboardForm.Chart1.Titles.Count = 0 Then
                        DashboardForm.Chart1.Titles.Add("Miscellaneous Chart Data")
                    End If

                    ' Set chart background color
                    DashboardForm.Chart1.BackColor = Drawing.Color.AliceBlue
                End Using
            End Using

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbExclamation, "Error!")
        End Try
    End Sub


    'Sub LoadMiscsChart()
    '    Try
    '        cn.Open()
    '        Using cm As New MySqlCommand("", cn)
    '            Using dr As MySqlDataReader = cm.ExecuteReader()

    '                ' Clear existing series
    '                DashboardForm.Chart1.Series.Clear()

    '                ' Add a new series
    '                Dim series1 As New Series("Miscellaneous")
    '                series1.ChartType = SeriesChartType.Pie ' Change to desired chart type
    '                series1.IsValueShownAsLabel = True
    '                series1.Font = New Drawing.Font("Poppins", 10, FontStyle.Regular)

    '                ' Populate the series with data from the database
    '                While dr.Read()
    '                    Dim month As String = CDate(dr("paymentDate")).ToString("MMMM")
    '                    Dim sales As Integer = Convert.ToInt32(dr("totalPaid"))
    '                    series1.Points.AddXY(month, sales)
    '                End While


    '                ' Add the series to the chart
    '                DashboardForm.Chart1.Series.Add(series1)
    '                DashboardForm.Chart1.Titles.Add("Miscs Chart Data")

    '                DashboardForm.Chart1.BackColor = Drawing.Color.AliceBlue

    '            End Using
    '        End Using
    '        cn.Close()
    '    Catch ex As Exception
    '        cn.Close()
    '        MsgBox(ex.Message, vbExclamation, "Error!")
    '    Finally
    '        cn.Close()
    '    End Try
    'End Sub

    Sub LoadTuitionsChart()
        Try
            cn.Open()

            ' SQL query to retrieve data
            Dim query As String = "
            SELECT 
                t.id, 
                t.studentId, 
                SUM(t.amountPaid) AS totalPaid, 
                t.paymentDate 
            FROM tuition t 
            INNER JOIN school_year sy ON t.schoolYearId = sy.id 
            WHERE sy.isActive = 1 
            GROUP BY MONTH(t.paymentDate);"

            Using cm As New MySqlCommand(query, cn)
                Using dr As MySqlDataReader = cm.ExecuteReader()

                    ' Clear existing series
                    DashboardForm.Chart2.Series.Clear()

                    ' Create and configure the new series
                    Dim series1 As New Series("Tuitions")
                    series1.ChartType = SeriesChartType.Pie
                    series1.IsValueShownAsLabel = True
                    series1.Font = New Drawing.Font("Poppins", 10, FontStyle.Regular)

                    ' Check if there is data to load
                    If dr.HasRows Then
                        While dr.Read()
                            ' Format date to include the full month name and day (e.g., "December 1")
                            Dim formattedDate As String = CDate(dr("paymentDate")).ToString("MMMM")
                            Dim sales As Decimal = Convert.ToDecimal(dr("totalPaid")) ' Convert totalPaid to Decimal

                            ' Add point to series
                            Dim pointIndex As Integer = series1.Points.AddXY(formattedDate, sales)

                            ' Format the label for the added point
                            series1.Points(pointIndex).Label = $"{formattedDate}: {sales.ToString("#,##0")}"
                        End While
                    Else
                        MsgBox("No data available for the current school year.", vbInformation, "No Data")
                    End If

                    ' Add the series to the chart
                    DashboardForm.Chart2.Series.Add(series1)

                    ' Add a title to the chart (avoid duplicates)
                    If DashboardForm.Chart2.Titles.Count = 0 Then
                        DashboardForm.Chart2.Titles.Add("Tuitions Chart Data")
                    End If

                    ' Set chart background color
                    DashboardForm.Chart2.BackColor = Drawing.Color.AliceBlue
                End Using
            End Using

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbExclamation, "Error!")
        End Try
    End Sub




    Sub RetrieveCurrentSchoolYear()

        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT id,schoolYear FROM school_year WHERE isActive = 1 LIMIT 1", cn)
                Using reader As MySqlDataReader = cm.ExecuteReader()
                    ' Check if there is any row returned
                    If reader.Read() Then
                        ' Retrieve the schoolYear value from the reader
                        currentSchoolYear = reader("schoolYear").ToString()
                        syId = reader("id")
                    Else
                        currentSchoolYear = "No Active School Year"
                    End If
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            ' Handle any errors that occur during the operation
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

End Module
