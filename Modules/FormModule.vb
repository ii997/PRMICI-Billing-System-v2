Imports MySql.Data.MySqlClient
Module FormModule

    Sub loginUser(ByVal username As String, password As String)
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM users WHERE username LIKE @user AND password LIKE @password", cn)
            cm.Parameters.AddWithValue("user", username)
            cm.Parameters.AddWithValue("password", password)

            Using dr As MySqlDataReader = cm.ExecuteReader()
                If dr.Read() Then
                    MessageBox.Show("Successfully logged-in!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearField()
                    Form1.Hide()
                    Task.Delay(1000)
                    MainForm.Show()
                Else
                    MessageBox.Show("Login failed incorrect username or password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ClearField()
                End If

            End Using
            cn.Close()
            RetrieveCurrentSchoolYear()
        Catch ex As Exception
            MessageBox.Show("Login Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Sub ClearField()
        Form1.Guna2TextBox1.Clear()
        Form1.Guna2TextBox2.Clear()
    End Sub

End Module
