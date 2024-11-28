Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DashboardModule.RetrieveTotalPayments()
        DashboardModule.RetrieveTotalStudents()
        DashboardModule.RetrieveTotalTuitions()
    End Sub
End Class