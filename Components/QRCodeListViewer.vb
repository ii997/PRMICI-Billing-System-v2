Public Class QRCodeListViewer
    Private Sub QRCodeListViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.StudentInfoQR' table. You can move, or remove it, as needed.
        Me.StudentInfoQRTableAdapter.Fill(Me.DataSet1.StudentInfoQR)
        ReportViewer1.RefreshReport()
    End Sub
End Class