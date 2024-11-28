Imports MySql.Data.MySqlClient
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
                    DashboardForm.txtSY.Text = currentSchoolYear
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
