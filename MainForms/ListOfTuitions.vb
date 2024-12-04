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
            Using cm As New MySqlCommand("SELECT t.id, s.name, y.year, ss.classSection, t.amountPaid, t.balance, t.paymentDate, sy.schoolYear, sy.isActive FROM tuition t JOIN students s ON t.studentId = s.id JOIN school_year sy ON t.schoolYearId = sy.id JOIN sections ss ON s.classSectionId = ss.id JOIN years y ON s.yearId = y.id WHERE s.name LIKE @searchInfo OR ss.classSection LIKE @searchInfo AND sy.isActive = 1", cn)
                cm.Parameters.AddWithValue("@searchInfo", "%" & searchInfo & "%")

                DataGridView1.Rows.Clear() ' Clear existing data

                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("id"), dr("name"), dr("year"), dr("classSection"), dr("amountPaid"), dr("balance"), dr("paymentDate"), dr("schoolYear"), dr("isActive"))
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