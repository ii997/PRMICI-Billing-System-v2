Imports QRCoder
Imports System.Windows.Forms
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
Module StudentModule
    Private qrGenerator As QRCodeGenerator = New QRCodeGenerator
    Sub createQRCode(ByVal txtQRData)

        Try
            If String.IsNullOrEmpty(txtQRData) Then
                MsgBox("Textfield is cannot be empty!", vbExclamation, "Empty fields!")
                Return
            End If
            Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator
            Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(txtQRData, QRCodeGenerator.ECCLevel.L)
            Dim qrCode As QRCode = New QRCode(qrCodeData)
            Dim qrCodeImage As Bitmap = qrCode.GetGraphic(10)

            Dim pictureData = NewStudentForm.CuiPictureBox1
            pictureData.Content = qrCodeImage

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
            Return
        End Try

    End Sub

    Sub LoadCourses()
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM sections", cn)
            Using dr As MySqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    NewStudentForm.CuiComboBox1.AddItem(dr.Item("id").ToString & "-" & dr.Item("classSection").ToString)
                    'Else
                    '    MessageBox.Show($"Failed to load sections!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End While
            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub LoadYear()
        Try
            cn.Open()
            cm = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM years", cn)
            Using dr As MySqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    NewStudentForm.CuiComboBox2.AddItem(dr.Item("id").ToString & "-" & dr.Item("year").ToString & " year")
                    'Else
                    '    MessageBox.Show($"Failed to load years!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End While
            End Using
            cn.Close()
        Catch ex As Exception
            MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub SaveStudentInformation(ByVal studid, name, birthdate, age, address, sectionId, yearId, qrCode)
        Try
            cn.Open()
            cm = New MySqlCommand("INSERT INTO students (studentId,name,birthdate,age,address,classSectionId,yearId,qrCode)VALUES(
            @studid,@name,@bday,@age,@address,@classSectionId,@yearId,@qrCode)", cn)
            With cm
                .Parameters.AddWithValue("@studid", studid)
                .Parameters.AddWithValue("@name", name)
                .Parameters.AddWithValue("@bday", birthdate)
                .Parameters.AddWithValue("@age", age)
                .Parameters.AddWithValue("@address", address)
                .Parameters.AddWithValue("@classSectionId", sectionId)
                .Parameters.AddWithValue("@yearId", yearId)
                .Parameters.AddWithValue("@qrCode", qrCode)
                .ExecuteNonQuery()
            End With
            cn.Close()
            MsgBox("Student successfully added!", vbInformation, vbOK)
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub LoadStudents()
        StudentsList.DataGridView1.Rows.Clear()
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT s.id AS ID, s.studentID AS StudentID,s.name AS Name,s.birthdate AS BirthDate,s.age AS Age,s.address AS Address,
            s.classSectionId AS SectionId,  ss.classSection AS Section, s.yearId AS YearId, y.year AS Year FROM students s  INNER JOIN sections ss ON s.classSectionId = ss.id INNER JOIN years y ON s.yearId=y.id", cn)
            Using dr As MySqlDataReader = cm.ExecuteReader
                While dr.Read()
                    StudentsList.DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("StudentID"), dr.Item("Name"), dr.Item("BirthDate"), dr.Item("Age"), dr.Item("Address"), dr.Item("SectionId"), dr.Item("Section"), dr.Item("YearId"), dr.Item("Year"))
                End While
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox($"Error {ex.Message}", vbExclamation)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub RetrieveStudentInfo(ByVal studentId)
        Try
            cn.Open()
            ' Call the stored procedure
            Using cmd As New MySqlCommand("GetStudentDetails", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@student_id", studentId)

                ' Execute the stored procedure and read the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Assuming you're displaying the result in a ListBox or similar control
                            Dim result As String = String.Format("ID: {0}, Name: {1}, Section: {2}", reader("id"), reader("name"), reader("classSection"))
                            MsgBox(result, vbInformation)
                        End While
                    Else
                        MessageBox.Show("No student found with the given ID.")
                    End If
                End Using
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub


    Sub SearchStudentInfo(ByVal searchInput)
        ' Define the search parameters based on user input, or set to Nothing for NULL

        Try
            cn.Open()
            ' Call the stored procedure
            Using cmd As New MySqlCommand("SearchStudentDetails", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@searchInput", searchInput)



                ' Execute the stored procedure and read the result
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        StudentsList.DataGridView1.Rows.Clear()
                        While reader.Read()
                            StudentsList.DataGridView1.Rows.Add(reader("id"), reader("studentId"), reader("name"), reader("birthdate"), reader("age"), reader("address"), reader("classSectionId"), reader("classSection"), reader("yearId"), reader("year"))
                        End While
                    Else
                        MessageBox.Show("No student found with the given ID.")
                    End If
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

    Sub RetrieveQRCode(ByVal studentId, studentName)
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT qrCode FROM students WHERE id =@studentId", cn)
            cm.Parameters.AddWithValue("@studentId", studentId)
            ' Execute query and retrieve the image data
            Dim imageData As Byte() = CType(cm.ExecuteScalar(), Byte())

            ' Check if image data is found
            If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                ' Convert byte array to MemoryStream and then to an Image
                Using ms As New MemoryStream(imageData)
                    QRCodeViewer.CuiPictureBox1.Content = Image.FromStream(ms)
                End Using
                QRCodeViewer.txtStudentId.Text = studentName
                QRCodeViewer.ShowDialog()
            Else
                MessageBox.Show("No image found for the specified student ID.")
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Module