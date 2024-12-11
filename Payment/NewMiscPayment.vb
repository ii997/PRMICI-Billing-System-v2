Imports MySql.Data.MySqlClient
Public Class NewMiscPayment
    ' Define the structure at form level
    Dim miscId As Integer
    Private Structure MiscItem
        Public ID As Integer
        Public Misc As String
        Public Amount As Decimal
    End Structure
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Dispose()
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click

        CreateNewPayment(miscId:=miscId, studentId:=CInt(StudentPaymentInfo.txtId.Text), amount:=CInt(tbamount.Text), paymentDate:=Date.Now.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub NewMiscPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        StudentPaymentInfo.Show()
    End Sub

    Private Sub NewMiscPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = syId
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            ' Retrieve the selected DataRowView
            Dim selectedRow As DataRowView = TryCast(CType(sender, ComboBox).SelectedItem, DataRowView)

            If selectedRow IsNot Nothing Then
                ' Retrieve the dynamically calculated amount or balance
                Dim selectedAmount As Double = CDbl(selectedRow("amount"))
                miscId = CInt(selectedRow("id"))
                TextBox1.Text = selectedAmount.ToString("C2") ' Display the value in a TextBox (e.g., as currency)
            End If
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error")
        End Try
    End Sub


End Class