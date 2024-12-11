Imports MySql.Data.MySqlClient
Public Class ListOfTuitions
    Private Sub ListOfTuitions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveTuitionStudentsData()
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click
        FilterTuitionData(tbSearch.Content.Trim())
    End Sub

    Private Sub FilterTuitionData(ByVal searchInfo As String)
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
    AND (
        LOWER(s.name) LIKE LOWER(CONCAT('%', @searchInfo, '%'))
        OR LOWER(ss.classSection) LIKE LOWER(CONCAT('%', @searchInfo, '%'))
    )
ORDER BY 
    s.name ASC,
    t.paymentDate DESC", cn)
                cm.Parameters.AddWithValue("@searchInfo", searchInfo)

                DataGridView1.Rows.Clear() ' Clear existing data

                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("TuitionID"), dr("StudentName"), dr("YearLevel"), dr("Section"), dr("AmountPaid"), dr("RemainingBalance"), dr("PaymentDate"), dr("AcademicYear"), dr("PaymentStatus"))
                    End While
                End Using
            End Using

            ' Update record count display
            Dim recordCount As Integer = DataGridView1.Rows.Count
            Label2.Text = $"Showing {recordCount} {(If(recordCount <= 1, "record", "records"))}"

        Catch ex As MySqlException
            MsgBox("Database Error!: " & ex.Message, vbExclamation, "Error!")
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        LoadTuition()
        currentPaymentType = PaymentType.TuitionFee
        QRVerification.ShowDialog()
    End Sub

    Private Sub CuiButton3_Click(sender As Object, e As EventArgs) Handles CuiButton3.Click
        TuitionsReportViewer.ShowDialog()
    End Sub
End Class