
Imports System.IO

Public Class NewStudentForm
    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        createQRCode(CuiTextBox21.Content.Trim)
        txtStudentId.Text = CuiTextBox22.Content.ToString
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Dispose()
    End Sub

    Private Sub NewStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadYear()
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click

        If CuiTextBox21.Content.Length < 9 Then
            MsgBox("School ID must be ", vbExclamation, "Error!")
            Return
        Else
            If MsgBox("Are you sure you want to add this student?", vbYesNo + vbQuestion, vbInformation) = vbYes Then

                ' Check if PictureBox has an image
                If CuiPictureBox1.Content Is Nothing Then
                    MsgBox("Error!, Unable to add student, Missing QR Code", vbExclamation, "QR Code Missing")
                    Return
                Else
                    Dim ms As New MemoryStream()
                    CuiPictureBox1.Content.Save(ms, System.Drawing.Imaging.ImageFormat.Png) ' or another format if needed
                    Dim imageBytes() As Byte = ms.ToArray()
                    ms.Close()

                    SaveStudentInformation(
                   studid:=CuiTextBox21.Content.Trim,
               name:=CuiTextBox22.Content.Trim,
               birthdate:=CuiDateTimePicker1.Value.Date.ToString("yyyy-MM-dd"),
           age:=CuiTextBox23.Content.Trim,
               address:=CuiTextBox24.Content.Trim,
               sectionId:=CuiComboBox1.SelectedItem.Split("-"c)(0),
               yearId:=CuiComboBox2.SelectedItem.Split("-"c)(0),
               qrCode:=imageBytes
           )
                    Task.Delay(2)
                    Me.Dispose()
                    LoadStudents()
                End If



            Else
                Return
            End If
        End If
    End Sub

    Private Sub CuiDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles CuiDateTimePicker1.ValueChanged
        Dim birthDate As Date = CuiDateTimePicker1.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Display the age
        CuiTextBox23.Content = age.ToString()
    End Sub
End Class