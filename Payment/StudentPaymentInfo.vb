Imports CuoreUI.Controls

Public Class StudentPaymentInfo

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Task.Delay(1000)
        Me.Dispose()
    End Sub


    Private Sub StudentPaymentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check the enum value and show/hide the miscellaneous and tuition buttons accordingly
        If currentPaymentType = PaymentType.Miscellaneous Then
            btnMisc.Visible = True   ' Show the Miscellaneous button if Miscellaneous is selected
            CuiTabControl1.SelectedIndex = 0
            btnTuition.Visible = False ' Hide the Tuition Fee button
        ElseIf currentPaymentType = PaymentType.TuitionFee Then
            btnTuition.Visible = True ' Show the Tuition Fee button if TuitionFee is selected
            CuiTabControl1.SelectedIndex = 1
            btnMisc.Visible = False   ' Hide the Miscellaneous button
        End If


    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles btnMisc.Click
        RetrieveMiscs(studentId:=Payment.currentStudentId)
    End Sub

    Private Sub btnTuition_Click(sender As Object, e As EventArgs) Handles btnTuition.Click
        If IsStudentFullyPaid(currentStudentId) Then
            MsgBox("Student is already paid for the whole year!", vbInformation, "Fully Paid!")
        Else
            RetrieveTuitionInformation()
        End If

    End Sub

    Private Sub CuiTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CuiTabControl1.SelectedIndexChanged
        If CuiTabControl1.SelectedIndex = 0 Then
            RetrieveMiscsData()
            Dim res As Decimal = 0

            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                ' Ensure that the row is not a new row and that the amount cell contains a numeric value
                If Not DataGridView1.Rows(i).IsNewRow Then
                    Dim cellValue = DataGridView1.Rows(i).Cells(3).Value

                    ' Check if the cell value is numeric and not null or empty
                    If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                        Dim amount As Decimal = Convert.ToDecimal(cellValue)
                        res += amount ' Accumulate the sum of amounts
                    End If
                End If
            Next

            txtAmountPaid.Text = res.ToString("#,###.##") ' Format as needed
        Else
            RetrieveTuitions()
            Dim res As Decimal = 0

            For i As Integer = 0 To DataGridView2.Rows.Count - 1
                ' Ensure that the row is not a new row and that the amount cell contains a numeric value
                If Not DataGridView2.Rows(i).IsNewRow Then
                    Dim cellValue = DataGridView2.Rows(i).Cells(2).Value

                    ' Check if the cell value is numeric and not null or empty
                    If cellValue IsNot Nothing AndAlso IsNumeric(cellValue) Then
                        Dim amount As Decimal = Convert.ToDecimal(cellValue)
                        res += amount ' Accumulate the sum of amounts
                    End If
                End If
            Next

            txtTuitionAmountPaid.Text = res.ToString("#,###.##") ' Format as needed
        End If
    End Sub

End Class