Imports MySql.Data.MySqlClient
Imports System.IO
Public Class FormMaintenance
    Private oldpass As String
    Private newpass As String = ""
    Private cnewpass As String = ""

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrEmpty(tboldpass.Text.Trim) Or String.IsNullOrEmpty(tbnewpass.Text.Trim) Or String.IsNullOrEmpty(tbcnewpass.Text.Trim) Then
            MsgBox("Cannot proceed cuz there is some empty fields!", vbCritical, "Hewhu!")
        Else
            If tbnewpass.Text.Trim().Equals(tbcnewpass.Text.Trim()) Then
                If tboldpass.Text.Trim().Equals(oldpass) Then
                    If MsgBox("Are you sure you want to update your password?", vbYesNo + vbQuestion) = vbYes Then
                        UpdateUserPassword(password:=tbnewpass.Text.Trim())
                    Else
                        Return
                    End If
                Else
                    MsgBox("Cannot proceed to saving data, check your information!", vbCritical, "Dumbo!")
                End If
            Else
                MsgBox("Does not matched!", vbCritical, "Dumbo!")
            End If
        End If

    End Sub



    Private Sub FormMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTuition()

        Try
            cn.Open()
            cm = New MySqlCommand($"SELECT password FROM users WHERE username = '{currentUser}' ", cn)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read()
                    oldpass = dr.Item("password")
                End While
                dr.Close()
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
            cn.Close()
        End Try
    End Sub

    Private Sub tboldpass_TextChanged(sender As Object, e As EventArgs) Handles tboldpass.TextChanged
        If tboldpass.Text.Equals(oldpass) Then
            Guna2HtmlLabel2.Text = "Matched"
            Guna2HtmlLabel2.ForeColor = Color.Green
        ElseIf String.IsNullOrEmpty(tboldpass.Text.Trim()) Then
            Guna2HtmlLabel2.Text = "Start Typing.."
            Guna2HtmlLabel2.ForeColor = Color.Red
        Else
            Guna2HtmlLabel2.Text = "Not Matched"
            Guna2HtmlLabel2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub tbcnewpass_TextChanged(sender As Object, e As EventArgs) Handles tbcnewpass.TextChanged
        If tbnewpass.Text.Trim().Equals(tbcnewpass.Text.Trim) Then
            Guna2HtmlLabel3.Text = "Matched"
            Guna2HtmlLabel3.ForeColor = Color.Green
        ElseIf String.IsNullOrEmpty(tbcnewpass.Text.Trim()) Then
            Guna2HtmlLabel3.Text = "Start Typing.."
            Guna2HtmlLabel3.ForeColor = Color.Red
        Else
            Guna2HtmlLabel3.Text = "Not Matched"
            Guna2HtmlLabel3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub tbnewpass_TextChanged(sender As Object, e As EventArgs) Handles tbnewpass.TextChanged
        If tbnewpass.Text.Trim().Equals(tbcnewpass.Text.Trim) Then
            Guna2HtmlLabel3.Text = "Matched"
            Guna2HtmlLabel3.ForeColor = Color.Green
        ElseIf String.IsNullOrEmpty(tbcnewpass.Text.Trim()) Then
            Guna2HtmlLabel3.Text = "Start Typing.."
            Guna2HtmlLabel3.ForeColor = Color.Red
        Else
            Guna2HtmlLabel3.Text = "Not Matched"
            Guna2HtmlLabel3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub UpdateUserPassword(ByVal password As String)
        Try
            cn.Open()
            Using cm As New MySqlCommand($"UPDATE users SET password = @password WHERE username = @username", cn)
                With cm
                    .Parameters.AddWithValue("@password", password)
                    .Parameters.AddWithValue("@username", currentUser)
                    .ExecuteNonQuery()
                End With
                MsgBox("Successfully updated users password! ", vbInformation, "Success!")
                cn.Close()
            End Using
            cn.Close()
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
            cn.Close()
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If String.IsNullOrEmpty(tbtuitionfee.Text.Trim) Then
            MsgBox("Tuition Fee data cannot be empty!", vbExclamation, "Empty Field!")
        Else
            Dim NewTuitionData As String = $"C:\Users\Marshmellow\source\repos\PRMICI Billing System v2\TuitionData.txt"
            If File.Exists(NewTuitionData) = True Then
                Dim objWriter As New StreamWriter(NewTuitionData, False)
                objWriter.WriteLine(tbtuitionfee.Text)
                objWriter.Close()
            End If
            MsgBox("Successfully updated tuition fee!", vbInformation, "Success!")
            LoadTuition()
        End If
    End Sub

    Private Sub FormMaintenance_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dispose()
        FormUpdateMiscellaneousFee.ShowDialog()

    End Sub
End Class