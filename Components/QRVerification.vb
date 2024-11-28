Public Class QRVerification

    Private Sub tbQRcode_TextChanged(sender As Object, e As EventArgs) Handles tbQRcode.TextChanged
        Try
            Dim studentIdText As String = tbQRcode.Text.Trim()

            ' Wait until the input length is exactly 9
            If studentIdText.Length = 9 Then
                ' Check if the input is numeric
                If IsNumeric(studentIdText) Then
                    ' Retrieve student payment info
                    RetrieveStudentPaymentInfo(studentId:=studentIdText)
                Else
                    MsgBox("Please enter a numeric 9-digit Student ID.", vbExclamation, "Invalid Input")
                    ' tbQRcode.Clear() ' Clear invalid input
                End If
            End If
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dispose()
    End Sub
End Class