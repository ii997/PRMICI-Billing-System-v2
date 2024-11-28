Imports MySql.Data.MySqlClient
Public Class UpdateSectionYear
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dispose()
    End Sub

    Private Sub UpdateSectionYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveSections()
        RetrieveGrades()
    End Sub

    Private Sub RetrieveSections()
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT id, classSection FROM sections", cn)
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        Guna2ComboBox1.Items.Add(dr.Item("id") & "-" & dr.Item("classSection"))
                    End While
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub RetrieveGrades()
        Try
            cn.Open()
            Using cm As New MySqlCommand("SELECT id, year FROM years", cn)
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    While dr.Read()
                        Guna2ComboBox2.Items.Add(dr.Item("id") & "-" & dr.Item("year"))
                    End While
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub CuiButton2_Click(sender As Object, e As EventArgs) Handles CuiButton2.Click
        UpdateSectionGrade()
    End Sub


    Private Sub UpdateSectionGrade()
        Try
            If MsgBox("Are you sure you want to update this student section & year?", vbQuestion + vbYesNo) = vbYes Then

                cn.Open()
                Using cm As New MySqlCommand("UPDATE students SET classSectionId = @csId, yearId = @yrId WHERE id = @id", cn)
                    With cm
                        .Parameters.AddWithValue("@csId", Guna2ComboBox1.SelectedItem.Split("-"c)(0))
                        .Parameters.AddWithValue("@yrId", Guna2ComboBox2.SelectedItem.Split("-"c)(0))
                        .Parameters.AddWithValue("@id", CInt(txtId.Text))
                        .ExecuteNonQuery()
                    End With
                End Using
            Else
                Return
            End If
            cn.Close()
            MsgBox("Successfully update student section & year", vbInformation, "Success!")
            Task.Delay(2000)
            Me.Dispose()
            LoadStudents()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class