Imports MySql.Data.MySqlClient
Public Class StudentUpdateForm
    Private Sub StudentUpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub RetrieveStudentdata(ByVal id As Integer)
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT * FROM students WHERE id = @id", cn)
                cm.Parameters.AddWithValue("@id", id)
                Using dr As MySqlDataReader = cm.ExecuteReader
                    While dr.Read()
                        CuiTextBox21.Content = dr.Item("studentId")
                        txtId.Text = dr.Item("id")
                        CuiTextBox22.Content = dr.Item("name")
                        CuiDateTimePicker1.Value = dr.Item("birthdate")
                        CuiTextBox23.Content = dr.Item("age")
                        CuiTextBox24.Content = dr.Item("address")
                    End While
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateStudentInformation(ByVal name As String, bdate As Date, address As String)
        Try
            If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                Using cm As New MySqlCommand("UPDATE students SET name =@name, birthdate=@bdate, address=@address WHERE id = @id", cn)
                    With cm
                        .Parameters.AddWithValue("@name", name)
                        .Parameters.AddWithValue("@bdate", bdate)
                        .Parameters.AddWithValue("@address", address)
                        .Parameters.AddWithValue("@id", CInt(txtId.Text))
                        .ExecuteNonQuery()
                    End With
                End Using
                cn.Close()
                MsgBox("Successfully updated student information!", vbInformation, "Success!")
                Dispose()
                LoadStudents()
            Else
                Return
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, vbCritical, "Database Error!")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dispose()
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click
        UpdateStudentInformation(CuiTextBox22.Content.Trim(), CuiDateTimePicker1.Value.Date, CuiTextBox24.Content.Trim())
    End Sub

    Private Sub CuiDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles CuiDateTimePicker1.ValueChanged
        Dim birthDate As Date = CuiDateTimePicker1.Value
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthDate.Year

        ' Display the age
        CuiTextBox23.Content = age.ToString()
    End Sub
End Class