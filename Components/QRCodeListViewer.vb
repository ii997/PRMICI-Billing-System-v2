Public Class QRCodeListViewer
    Private Sub QRCodeListViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.students' table. You can move, or remove it, as needed.
        Me.studentsTableAdapter.Fill(Me.DataSet2.students)
        'TODO: This line of code loads data into the 'DataSet1.StudentInfoQR' table. You can move, or remove it, as needed.

        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class