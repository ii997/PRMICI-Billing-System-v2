Public Class NewTuitionPayment

    Private Sub NewTuitionPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        StudentPaymentInfo.Show()
    End Sub

    Private Sub NewTuitionPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTuitionFee.Text = tuitionFee
        txtMonth.Text = Date.Now.ToString("MMM") & " | " & Date.Now.ToString("yy")
        Label1.Text = syId
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click

        If HasActiveSchoolYear() Then
            If MsgBox($"Are you sure you want to add this new P{CuiTextBox21.Content.Trim()} payment?", vbQuestion + vbYesNo) = vbYes Then
                CreateNewTuitionPayment(Payment.currentStudentId, CInt(CuiTextBox21.Content), CInt(txtBalance.Text), Date.Now.ToString("yyyy-MM-dd"))
            Else
                Return
            End If
        Else
                MsgBox("Error: There is no current active school year set", vbExclamation, "Error!")
            Return
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dispose()
    End Sub
End Class