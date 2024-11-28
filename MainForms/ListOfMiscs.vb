Imports MySql.Data.MySqlClient
Public Class ListOfMiscs


    Private Sub RetrieveMiscStudentsData()
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT mp.id, mp.studentId, s.name, ss.classSection, y.year, m.misc, mp.amount, mp.paymentStatus, mp.paymentDate FROM misc_payments mp INNER JOIN miscellaneous m ON mp.miscId = m.id INNER JOIN school_year sy ON mp.schoolYearId = sy.id JOIN students s ON mp.studentId = s.id JOIN sections ss ON s.classSectionId = ss.id JOIN years y ON s.yearId = y.id WHERE sy.isActive = 1 ORDER BY mp.id ASC;", cn)
                DataGridView1.Rows.Clear() ' Clear existing data
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("id"), dr("studentId"), dr("name"), dr("classSection"), dr("year"), dr("misc"), dr("amount"), dr("paymentDate"), dr("paymentStatus"))
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

    Private Sub ListOfMiscs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveMiscStudentsData()
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        currentPaymentType = PaymentType.Miscellaneous
        QRVerification.ShowDialog()
    End Sub

    Private Sub CuiButton3_Click(sender As Object, e As EventArgs) Handles CuiButton3.Click
        ReportViewer.ShowDialog()
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click
        FilterMiscsnData(tbSearch.Content.Trim())
    End Sub

    Private Sub FilterMiscsnData(ByVal searchInfo As String)
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT mp.id, mp.studentId, s.name, ss.classSection, y.year, m.misc, mp.amount, mp.paymentStatus, mp.paymentDate FROM misc_payments mp INNER JOIN miscellaneous m ON mp.miscId = m.id INNER JOIN school_year sy ON mp.schoolYearId = sy.id JOIN students s ON mp.studentId = s.id JOIN sections ss ON s.classSectionId = ss.id JOIN years y ON s.yearId = y.id WHERE sy.isActive = 1 AND s.name LIKE @searchInfo OR ss.classSection LIKE @searchInfo ", cn)
                cm.Parameters.AddWithValue("@searchInfo", "%" & searchInfo & "%")

                DataGridView1.Rows.Clear() ' Clear existing data

                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        DataGridView1.Rows.Add(dr("id"), dr("studentId"), dr("name"), dr("classSection"), dr("year"), dr("misc"), dr("amount"), dr("paymentDate"), dr("paymentStatus"))
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
End Class