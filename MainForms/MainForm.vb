Public Class MainForm
    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        With DashboardForm
            .TopLevel = False
            Panel3.Controls.Add(DashboardForm)
            .BringToFront()
            .Show()
        End With
        StudentsList.Dispose()
        FormSettingsForm.Dispose()
        ListOfTuitions.Dispose()
        ListOfMiscs.Dispose()
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click
        With StudentsList
            .TopLevel = False
            Panel3.Controls.Add(StudentsList)
            .BringToFront()
            .Show()
        End With
        DashboardForm.Dispose()
        FormSettingsForm.Dispose()
        ListOfTuitions.Dispose()
        ListOfMiscs.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel4.Height += 3
        If Panel4.Height = 156 Then
            Timer1.Stop()
        Else

        End If
    End Sub

    Private Sub CuiButton4_Click(sender As Object, e As EventArgs) Handles CuiButton4.Click
        If Panel4.Height = 156 Then
            Timer2.Start()

        Else
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel4.Height -= 3
        If Panel4.Height = 52 Then
            Timer2.Stop()
        Else

        End If
    End Sub


    Private Sub CuiButton7_Click(sender As Object, e As EventArgs) Handles CuiButton7.Click

        With ListOfMiscs
            .TopLevel = False
            Panel3.Controls.Add(ListOfMiscs)
            .BringToFront()
            .Show()
        End With
        StudentsList.Dispose()
        DashboardForm.Dispose()
        FormSettingsForm.Dispose()
        ListOfTuitions.Dispose()
    End Sub

    Private Sub CuiButton8_Click(sender As Object, e As EventArgs) Handles CuiButton8.Click

        With ListOfTuitions
            .TopLevel = False
            Panel3.Controls.Add(ListOfTuitions)
            .BringToFront()
            .Show()
        End With
        StudentsList.Dispose()
        DashboardForm.Dispose()
        FormSettingsForm.Dispose()
        ListOfMiscs.Dispose()
    End Sub

    Private Sub CuiButton5_Click(sender As Object, e As EventArgs) Handles CuiButton5.Click
        With FormSettingsForm
            .TopLevel = False
            Panel3.Controls.Add(FormSettingsForm)
            .BringToFront()
            .Show()
        End With
        StudentsList.Dispose()
        DashboardForm.Dispose()
        ListOfTuitions.Dispose()
        ListOfMiscs.Dispose()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' FormSettingsForm.RetrieveAndDisplayActiveSchoolYear(FormSettingsForm.FlowLayoutPanel1)

    End Sub

    Private Sub CuiButton10_Click(sender As Object, e As EventArgs)
        QRCodeListViewer.ShowDialog()
    End Sub

    Private Sub CuiButton6_Click(sender As Object, e As EventArgs) Handles CuiButton6.Click
        If MsgBox("Are you sure you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            cn.Close()
            MsgBox("Successfully logged out!", vbInformation, "Logged out!")
            Dispose()
            Form1.ShowDialog()


        End If
    End Sub

    Private Sub CuiButton3_Click(sender As Object, e As EventArgs) Handles CuiButton3.Click
        FormMaintenance.ShowDialog()
    End Sub
End Class