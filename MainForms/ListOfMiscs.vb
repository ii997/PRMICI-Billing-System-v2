Imports MySql.Data.MySqlClient
Public Class ListOfMiscs


    ' Constants for column names to avoid magic strings
    Private Class MiscPaymentColumns
        Public Const ID As String = "id"
        Public Const StudentID As String = "studentId"
        Public Const StudentName As String = "name"
        Public Const ClassSection As String = "classSection"
        Public Const Year As String = "year"
        Public Const Misc As String = "misc"
        Public Const Amount As String = "amount"
        Public Const Balance As String = "balance"
        Public Const PaymentDate As String = "paymentDate"
    End Class

    Private Sub RetrieveMiscStudentsData()
        ' SQL Query with proper formatting and indexing hints
        Const SQL_QUERY As String = "
        SELECT 
            mp.id,
            mp.studentId,
            s.name,
            ss.classSection,
            y.year,
            m.misc,
            COALESCE(mp.amount, 0) as amount,
            COALESCE(mp.balance, 0) as balance,
            mp.paymentDate,
            CASE 
                WHEN mp.balance = 0 THEN 'Fully Paid'
                WHEN mp.balance > 0 AND mp.amount > 0 THEN 'Partially Paid'
                ELSE 'Unpaid'
            END AS PaymentStatus
        FROM misc_payments mp
            INNER JOIN miscellaneous m ON mp.miscId = m.id
            INNER JOIN school_year sy ON mp.schoolYearId = sy.id
            INNER JOIN students s ON mp.studentId = s.id
            INNER JOIN sections ss ON s.classSectionId = ss.id
            INNER JOIN years y ON s.yearId = y.id
        WHERE sy.isActive = 1
        ORDER BY mp.id ASC;"

        Try

            cn.Open()

            Using cm As New MySqlCommand(SQL_QUERY, cn)
                ' Set command timeout to handle large datasets
                cm.CommandTimeout = 60 ' 60 seconds timeout

                ' Clear existing data
                DataGridView1.SuspendLayout()
                DataGridView1.Rows.Clear()

                ' Read data efficiently
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    Dim rowData(9) As Object ' Pre-allocate array for better performance

                    While dr.Read()
                        ' Fill row data array
                        rowData(0) = dr(MiscPaymentColumns.ID)
                        rowData(1) = dr(MiscPaymentColumns.StudentID)
                        rowData(2) = dr(MiscPaymentColumns.StudentName)
                        rowData(3) = dr(MiscPaymentColumns.ClassSection)
                        rowData(4) = dr(MiscPaymentColumns.Year)
                        rowData(5) = dr(MiscPaymentColumns.Misc)
                        rowData(6) = dr(MiscPaymentColumns.Amount)
                        rowData(7) = dr(MiscPaymentColumns.Balance)
                        rowData(8) = dr(MiscPaymentColumns.PaymentDate)
                        rowData(9) = dr("PaymentStatus")
                        DataGridView1.Rows.Add(rowData)
                    End While
                End Using

                ' Resume layout and update display
                DataGridView1.ResumeLayout()

                ' Update record count with proper pluralization
                Dim recordCount As Integer = DataGridView1.Rows.Count
                Label2.Text = $"Showing {recordCount:N0} {If(recordCount = 1, "record", "records")}"
            End Using
        Catch ex As MySqlException
            MessageBox.Show(
            $"Database Error: {ex.Message}" & vbCrLf &
            $"Error Code: {ex.Number}",
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show(
            $"An unexpected error occurred: {ex.Message}",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Finally
            cn.Close()
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
        ' SQL Query with proper formatting and search functionality
        Const SQL_QUERY As String = "
        SELECT 
            mp.id,
            mp.studentId,
            s.name,
            ss.classSection,
            y.year,
            m.misc,
            COALESCE(mp.amount, 0) as amount,
            COALESCE(mp.balance, 0) as balance,
            mp.paymentDate,
            CASE 
                WHEN mp.balance = 0 THEN 'Fully Paid'
                WHEN mp.balance > 0 AND mp.amount > 0 THEN 'Partially Paid'
                ELSE 'Unpaid'
            END AS PaymentStatus
        FROM misc_payments mp
            INNER JOIN miscellaneous m ON mp.miscId = m.id
            INNER JOIN school_year sy ON mp.schoolYearId = sy.id
            INNER JOIN students s ON mp.studentId = s.id
            INNER JOIN sections ss ON s.classSectionId = ss.id
            INNER JOIN years y ON s.yearId = y.id
        WHERE sy.isActive = 1 
            AND (s.name LIKE @searchInfo OR ss.classSection LIKE @searchInfo)
        ORDER BY mp.id ASC;"

        Try
            cn.Open()
            Using cm As New MySqlCommand(SQL_QUERY, cn)
                ' Add parameter before executing the query
                cm.Parameters.AddWithValue("@searchInfo", "%" & searchInfo & "%")

                ' Clear existing data
                DataGridView1.SuspendLayout()
                DataGridView1.Rows.Clear()

                ' Read data efficiently
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    Dim rowData(9) As Object ' Pre-allocate array for better performance

                    While dr.Read()
                        ' Fill row data array
                        rowData(0) = dr(MiscPaymentColumns.ID)
                        rowData(1) = dr(MiscPaymentColumns.StudentID)
                        rowData(2) = dr(MiscPaymentColumns.StudentName)
                        rowData(3) = dr(MiscPaymentColumns.ClassSection)
                        rowData(4) = dr(MiscPaymentColumns.Year)
                        rowData(5) = dr(MiscPaymentColumns.Misc)
                        rowData(6) = dr(MiscPaymentColumns.Amount)
                        rowData(7) = dr(MiscPaymentColumns.Balance)
                        rowData(8) = dr(MiscPaymentColumns.PaymentDate)
                        rowData(9) = dr("PaymentStatus")

                        DataGridView1.Rows.Add(rowData)
                    End While
                End Using

                ' Resume layout and update display
                DataGridView1.ResumeLayout()

                ' Update record count with proper pluralization
                Dim recordCount As Integer = DataGridView1.Rows.Count
                Label2.Text = $"Showing {recordCount:N0} {If(recordCount = 1, "record", "records")}"
            End Using
        Catch ex As MySqlException
            MessageBox.Show(
            $"Database Error: {ex.Message}" & vbCrLf &
            $"Error Code: {ex.Number}",
            "Database Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show(
            $"An unexpected error occurred: {ex.Message}",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        Finally
            cn.Close()
        End Try
    End Sub
End Class