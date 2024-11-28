Public Class NewMiscPayment
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Dispose()
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        Dim miscId As String = ComboBox1.SelectedItem.Split("@"c)(0).Trim()
        CreateNewPayment(miscId:=miscId, studentId:=CInt(StudentPaymentInfo.txtId.Text), amount:=CInt(tbamount.Text), paymentDate:=Date.Now.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub NewMiscPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        StudentPaymentInfo.Show()
    End Sub

    Private Sub NewMiscPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = syId

    End Sub
End Class