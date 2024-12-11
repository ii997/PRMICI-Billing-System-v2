Imports MySql.Data.MySqlClient
Module Payment
    Public currentStudentId As Integer

    Sub RetrieveStudentPaymentInfo(ByVal studentId As Integer)
        StudentPaymentInfo.DataGridView1.Rows.Clear()
        Try
            cn.Open()
            Dim query As String = "SELECT s.id, s.studentID, s.name, ss.id, ss.classSection, s.yearId, y.year, m.misc, mp.amount, mp.paymentDate FROM misc_payments mp
                              INNER JOIN miscellaneous m ON mp.miscId = m.id
                              RIGHT JOIN students s ON mp.studentId = s.id
                              INNER JOIN sections ss ON s.classSectionId = ss.id 
                              INNER JOIN years y ON s.yearId = y.id 
                              WHERE s.studentId = @studentId;"
            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@studentId", studentId)

                Using dr As MySqlDataReader = cm.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            ' Populate form fields
                            StudentPaymentInfo.txtName.Text = dr("name").ToString()
                            currentStudentId = Convert.ToInt32(dr("id"))
                            StudentPaymentInfo.txtCourseYear.Text = $"{dr("year")} | {dr("classSection")}"
                            StudentPaymentInfo.txtId.Text = dr("id").ToString()
                            StudentPaymentInfo.txtStudentId.Text = dr("studentID").ToString()
                        End While
                        ' Close QRVerification form and show StudentPaymentInfo form
                        QRVerification.Dispose()
                        Task.Delay(1000).Wait() ' Small delay if needed
                        StudentPaymentInfo.ShowDialog()
                    Else
                        ' Show message if no data found for the student ID
                        MsgBox("No data found for the student ID.", vbExclamation, "No Data")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Async Function LoadTotalAmountAsync(ByVal studentId As Integer) As Task
        Dim i As Decimal = 0
        Try
            cn.Open()
            ' Introduce a delay to simulate loading or waiting for some other async process.
            Await Task.Delay(100) ' 100 milliseconds delay, adjust as needed

            Using cm As New MySqlCommand("SELECT SUM(amount) FROM misc_payments WHERE studentId = @studentId;", cn)
                cm.Parameters.AddWithValue("@studentId", studentId)

                Dim result = cm.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    i = Convert.ToInt32(result)
                End If
            End Using
            cn.Close()
            StudentPaymentInfo.txtAmountPaid.Text = i.ToString("#,###.##")
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function

    Sub RetrieveMiscs(ByVal studentId)
        cn.Close()
        Try
            ' Clear previous items in the ComboBox
            NewMiscPayment.ComboBox1.Items.Clear()

            cn.Open()

            ' Updated SQL query
            Dim query As String = "
           SELECT 
    m.id, 
    m.misc, 
    CASE 
        WHEN mp.studentId = @studentId 
             AND COALESCE(mp.balance, 0) > 0 
             AND sy.isActive = 1 THEN mp.balance 
        WHEN mp.studentId = @studentId 
             AND COALESCE(mp.balance, 0) = 0 
             AND sy.isActive = 1 THEN 0
        ELSE m.amount 
    END AS amount 
FROM 
    miscellaneous m
LEFT JOIN 
    misc_payments mp ON m.id = mp.miscId
LEFT JOIN 
    school_year sy ON mp.schoolYearId = sy.id;






        "

            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@studentId", Payment.currentStudentId)
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dt As New DataTable()
                    dt.Load(dr)

                    ' Bind the ComboBox with the DataTable
                    With NewMiscPayment.ComboBox1
                        .DataSource = dt
                        .DisplayMember = "misc"   ' The name to show in the ComboBox
                        .ValueMember = "id"       ' The unique identifier for the selected item
                    End With
                End Using
            End Using

            cn.Close()
            StudentPaymentInfo.Hide()
            Task.Delay(1000)
            NewMiscPayment.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub RetrieveTuitions()
        cn.Close()
        Try
            StudentPaymentInfo.DataGridView2.Rows.Clear()
            cn.Open()
            ' SQL query to retrieve only items from miscellaneous that are not in misc_payments for the given studentId
            Dim query As String = "SELECT t.*, sy.schoolYear as schoolYear 
FROM tuition t
INNER JOIN school_year sy ON t.schoolYearId = sy.id 
WHERE t.studentId = @studentId
AND sy.isActive = 1
ORDER BY t.id ASC;"

            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@studentId", currentStudentId)
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    ' Read and add each item that has no matching record in misc_payments to the ComboBox
                    While dr.Read()
                        StudentPaymentInfo.DataGridView2.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(4))
                    End While
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Sub RetrieveMiscsData()
        cn.Close()
        Try
            StudentPaymentInfo.DataGridView1.Rows.Clear()
            cn.Open()
            ' SQL query to retrieve only items from miscellaneous that are not in misc_payments for the given studentId
            Dim query As String = "SELECT mp.id, mp.studentId,m.misc, mp.amount, mp.balance, mp.paymentDate FROM misc_payments mp INNER JOIN miscellaneous m ON mp.miscId = m.id INNER JOIN school_year sy ON mp.schoolYearId = sy.id WHERE studentId = @studentId AND sy.isActive = 1 ORDER BY mp.id ASC"

            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@studentId", currentStudentId)
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    ' Read and add each item that has no matching record in misc_payments to the ComboBox
                    While dr.Read()
                        StudentPaymentInfo.DataGridView1.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString, dr.Item(4), dr.Item(5))
                    End While
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Sub CreateNewPayment(ByVal miscId, studentId, amount, paymentDate)
        Try
            ' Validate input values
            If String.IsNullOrWhiteSpace(NewMiscPayment.TextBox1.Text) Then
                MsgBox("The balance field cannot be empty.", vbExclamation, "Validation Error")
                Exit Sub
            End If

            If Not IsNumeric(NewMiscPayment.TextBox1.Text) Then
                MsgBox("The balance must be a numeric value.", vbExclamation, "Validation Error")
                Exit Sub
            End If

            ' Retrieve the user's input from the TextBox for the initial value
            Dim initialAmount As Double = CDbl(NewMiscPayment.TextBox1.Text) ' Assuming TextBoxBalance is the TextBox containing the user's input

            ' Check if the balance is already zero
            If initialAmount <= 0 Then
                MsgBox("This item has already been paid in full.", vbInformation, "Payment Complete")
                Exit Sub
            End If

            If amount <= 0 Then
                MsgBox("The payment amount must be greater than zero.", vbExclamation, "Validation Error")
                Exit Sub
            End If

            ' Calculate the new balance
            Dim balance As Double = initialAmount - amount

            If balance < 0 Then
                MsgBox("The payment amount exceeds the available balance.", vbExclamation, "Validation Error")
                Exit Sub
            End If

            cn.Open()

            ' Insert query with balance
            Dim query As String = "INSERT INTO misc_payments (miscId, studentId, amount, paymentDate, schoolYearId, balance) 
                               VALUES (@miscId, @studentId, @amount, @paymentDate, @schoolYearId, @balance)"

            Using cm As New MySqlCommand(query, cn)
                With cm.Parameters
                    .AddWithValue("@miscId", miscId)
                    .AddWithValue("@studentId", studentId)
                    .AddWithValue("@amount", amount)
                    .AddWithValue("@paymentDate", paymentDate)
                    .AddWithValue("@schoolYearId", syId)
                    .AddWithValue("@balance", balance) ' Include the calculated balance
                End With
                cm.ExecuteNonQuery()
            End Using

            cn.Close()
            MsgBox("New Payment has been made. Remaining Balance: " & balance.ToString("C2"), vbInformation, "Payment Successful")
            NewMiscPayment.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Sub CreateNewTuitionPayment(ByVal studentId, amount, balance, paymentDate)
        Dim newBalance = balance - amount
        ' Check if the new balance is negative
        If newBalance < 0 Then
            MsgBox("Error: New balance cannot be negative.", vbExclamation, "Invalid Payment")
            Return
        End If
        Try
            cn.Open()
            Dim query As String = "INSERT INTO tuition (studentId,amountPaid,balance,paymentDate,schoolYearId)VALUES(@studentId,@amount,@balance,@paymentDate,@schoolYearId)"
            Using cm As New MySqlCommand(query, cn)
                With cm.Parameters
                    .AddWithValue("@studentId", studentId)
                    .AddWithValue("@amount", amount)
                    .AddWithValue("@balance", newBalance)
                    .AddWithValue("@paymentDate", paymentDate)
                    .AddWithValue("@schoolYearId", syId)
                End With
                cm.ExecuteNonQuery()
            End Using
            cn.Close()
            MsgBox("New Tuition Payment has been made", vbInformation, vbOK)
            NewTuitionPayment.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
            Return
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Sub RetrieveTuitionInformation()
        Try
            cn.Open()

            ' Query to retrieve the remaining balance for the latest inactive school year
            Dim queryInactive As String = "SELECT COALESCE(t.balance, 0) AS inactiveBalance " &
                                      "FROM tuition t " &
                                      "INNER JOIN school_year sy ON t.schoolYearId = sy.id " &
                                      "WHERE t.studentId = @studentId " &
                                      "AND sy.isActive = 0 " &
                                      "AND t.balance > 0 " &
                                      "ORDER BY t.id DESC " &
                                      "LIMIT 1;"

            ' Query to retrieve the latest active tuition record
            Dim queryActive As String = "SELECT COALESCE(t.amountPaid, 0) AS amountPaid, " &
                                    "COALESCE(t.balance, 0) AS activeBalance, " &
                                    "sy.schoolYear AS schoolYear " &
                                    "FROM tuition t " &
                                    "INNER JOIN school_year sy ON t.schoolYearId = sy.id " &
                                    "WHERE t.studentId = @studentId " &
                                    "AND sy.isActive = 1 " &
                                    "ORDER BY t.id DESC " &
                                    "LIMIT 1;"

            ' Fixed tuition amount if no previous balance exists in the active school year
            Dim fixedTuition As Decimal = tuitionFee
            Dim inactiveBalance As Decimal = 0
            Dim activeBalance As Decimal = 0
            Dim amountPaid As Decimal = 0
            Dim schoolYear As String = ""
            Dim totalBalance As Decimal

            ' Execute the inactive balance query
            Using cmInactive As New MySqlCommand(queryInactive, cn)
                cmInactive.Parameters.AddWithValue("@studentId", currentStudentId)
                Using reader As MySqlDataReader = cmInactive.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        inactiveBalance = Convert.ToDecimal(reader("inactiveBalance"))
                    End If
                End Using
            End Using

            ' Execute the active balance query
            Using cmActive As New MySqlCommand(queryActive, cn)
                cmActive.Parameters.AddWithValue("@studentId", currentStudentId)
                Using reader As MySqlDataReader = cmActive.ExecuteReader()
                    If reader.HasRows Then
                        ' If there is an active record, use its balance and amount paid
                        reader.Read()
                        activeBalance = Convert.ToDecimal(reader("activeBalance"))
                        amountPaid = Convert.ToDecimal(reader("amountPaid"))
                        schoolYear = reader("schoolYear").ToString()

                        ' Set total balance to the active balance without adding fixed tuition
                        totalBalance = activeBalance
                    Else
                        ' If no active record, use the fixed tuition amount plus inactive balance
                        totalBalance = inactiveBalance + fixedTuition
                    End If
                End Using
            End Using

            ' Set the fields with calculated values
            NewTuitionPayment.txtBalance.Text = totalBalance.ToString()
            NewTuitionPayment.txtAmountPaid.Text = amountPaid.ToString()
            NewTuitionPayment.txtRemaining.Text = inactiveBalance.ToString()
            ' Optionally display the school year if needed
            ' NewTuitionPayment.lblSchoolYear.Text = schoolYear

            cn.Close()
            StudentPaymentInfo.Hide()
            Task.Delay(1000)
            NewTuitionPayment.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Sub RetrieveTuitionStudentsData()
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT 
    t.id AS TuitionID,
    s.name AS StudentName,
    y.year AS YearLevel,
    ss.classSection AS Section,
    COALESCE(t.amountPaid, 0) AS AmountPaid,
    COALESCE(t.balance, 0) AS RemainingBalance,
    t.paymentDate AS PaymentDate,
    sy.schoolYear AS AcademicYear,
    CASE 
        WHEN t.balance = 0 THEN 'Fully Paid'
        WHEN t.balance > 0 AND t.amountPaid > 0 THEN 'Partially Paid'
        ELSE 'Unpaid'
    END AS PaymentStatus
FROM 
    tuition t
    INNER JOIN students s ON t.studentId = s.id
    INNER JOIN school_year sy ON t.schoolYearId = sy.id
    INNER JOIN sections ss ON s.classSectionId = ss.id
    INNER JOIN years y ON s.yearId = y.id
WHERE 
    sy.isActive = 1
ORDER BY 
    s.name ASC,
    t.paymentDate DESC", cn)
                ListOfTuitions.DataGridView1.Rows.Clear() ' Clear existing data
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        ListOfTuitions.DataGridView1.Rows.Add(dr("TuitionID"), dr("StudentName"), dr("YearLevel"), dr("Section"), dr("AmountPaid"), dr("RemainingBalance"), dr("PaymentDate"), dr("AcademicYear"), dr("PaymentStatus"))
                    End While
                End Using
                Dim recordCount As Integer = ListOfTuitions.DataGridView1.Rows.Count
                ListOfTuitions.Label2.Text = $"Showing {recordCount} {(If(recordCount <= 1, "record", "records"))}"
            End Using
        Catch ex As MySqlException
            MsgBox($"MySQL error: {ex.Message}", vbExclamation, "Database Error!")
        Catch ex As Exception
            MsgBox($"Unexpected error: {ex.Message}", vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Function HasActiveSchoolYear() As Boolean
        Try

            cn.Open()
            Using cm As New MySqlCommand("SELECT 1 FROM school_year WHERE isActive = 1", cn)
                Dim result As Integer = Convert.ToInt32(cm.ExecuteScalar())
                ' Return True if there's at least one active school year, False otherwise
                Return result > 0
            End Using
            cn.Close()
        Catch ex As Exception
            ' Handle any errors that occur during the operation
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
            Return False
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
    Function IsStudentFullyPaid(ByVal studentId As Integer) As Boolean
        Try
            cn.Open()
            ' Query to check if the student has any outstanding balance
            Dim query As String = "SELECT balance FROM tuition INNER JOIN school_year sy ON tuition.schoolYearId = sy.id WHERE studentId = @studentId AND sy.isActive = 1 ORDER BY tuition.id DESC LIMIT 1;"

            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@studentId", studentId)

                Dim result = cm.ExecuteScalar()
                If result IsNot Nothing AndAlso Convert.ToDouble(result) <= 0 Then
                    ' If balance is zero or less, the student is fully paid
                    Return True
                Else
                    ' If balance is greater than zero, the student is not fully paid
                    Return False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
            Return False
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
End Module
