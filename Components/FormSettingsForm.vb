Imports MySql.Data.MySqlClient

Public Class FormSettingsForm
    Private Sub FormSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tbTuition.Content = CInt(NewTuitionPayment.tuitionFee)
        PopulateSchoolYearRadioButtons(FlowLayoutPanel1)
        Task.Delay(1000)
        RetrieveAndDisplayActiveSchoolYear(FlowLayoutPanel1)
    End Sub

    ' Function to retrieve school years from the database and create radio buttons
    Sub PopulateSchoolYearRadioButtons(flowLayoutPanel As FlowLayoutPanel)
        Try
            ' Clear any existing controls in the FlowLayoutPanel
            flowLayoutPanel.Controls.Clear()

            cn.Open()
            Using cm As New MySqlCommand("SELECT id, schoolYear FROM school_year", cn)
                Using reader As MySqlDataReader = cm.ExecuteReader()
                    While reader.Read()
                        ' Create a new radio button for each school year
                        ' Customize the appearance of the radio button
                        Dim rb As New RadioButton With {
                            .Text = reader("schoolYear").ToString(),
                            .Tag = reader("id"), ' Store the associated ID in the Tag property
                            .ForeColor = Color.White,  ' Set the text color
                            .Font = New Font("Poppins", 10, FontStyle.Regular), ' Set the font, size, and style
                            .BackColor = Color.Transparent ' Set the background color
                            }

                        ' Add an event handler for when the radio button is checked
                        AddHandler rb.CheckedChanged, AddressOf RadioButton_CheckedChanged

                        ' Add the radio button to the FlowLayoutPanel
                        flowLayoutPanel.Controls.Add(rb)
                    End While
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox($"An error occurred: {ex.Message}", vbExclamation, "Error!")
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)
        ' Only perform the update when the radio button is checked
        If rb.Checked Then
            ' Retrieve the ID from the Tag property
            Dim schoolYearId As Integer = Convert.ToInt32(rb.Tag)

            ' Update the IsActive status in the database
            UpdateSchoolYearStatus(schoolYearId)

        End If
    End Sub


    '' Function to update the IsActive status in the database
    Private Async Sub UpdateSchoolYearStatus(activeSchoolYearId As Integer)
        Try
            cn.Open()

            ' Set all school years to inactive
            Using cm As New MySqlCommand("UPDATE school_year SET isActive = 0", cn)
                cm.ExecuteNonQuery()
            End Using
            Await Task.Delay(1000)
            ' Set the selected school year to active
            Using cm As New MySqlCommand("UPDATE school_year SET isActive = 1 WHERE id = @id", cn)
                cm.Parameters.AddWithValue("@id", activeSchoolYearId)
                cm.ExecuteNonQuery()
            End Using
            cn.Close()
            RetrieveCurrentSchoolYear()
        Catch ex As Exception
            ' MsgBox($"An error occurred while updating the school year status: {ex.Message}", vbExclamation, "Error!")
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    ' Function to retrieve and display the current active school year
    Sub RetrieveAndDisplayActiveSchoolYear(flowLayoutPanel As FlowLayoutPanel)
        Try
            cn.Open()
            ' Retrieve the active school year
            Using cm As New MySqlCommand("SELECT id, schoolYear FROM school_year WHERE isActive = 1 LIMIT 1", cn)
                Using reader As MySqlDataReader = cm.ExecuteReader()
                    If reader.Read() Then
                        ' Find the radio button corresponding to the active school year
                        syId = reader("id")
                        For Each ctrl As Control In flowLayoutPanel.Controls
                            If TypeOf ctrl Is RadioButton Then
                                Dim rb As RadioButton = DirectCast(ctrl, RadioButton)
                                ' If the text matches the active school year, mark it as checked
                                If rb.Text = reader("schoolYear").ToString() Then
                                    rb.Checked = True
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox($"An error occurred while retrieving the active school year: {ex.Message}", vbExclamation, "Error!")
            cn.Close()
        Finally
            ' Ensure the connection is closed properly
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class