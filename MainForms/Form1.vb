Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If ConnectToDB() = False Then
                Application.Exit()
            Else
                LoadTuition()
                Guna2TextBox2.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation)
            cn.Close()
        End Try
    End Sub

    Private Sub CuiButton1_Click(sender As Object, e As EventArgs) Handles CuiButton1.Click
        currentUser = Guna2TextBox1.Text.Trim()
        loginUser(username:=Guna2TextBox1.Text.ToString, password:=Guna2TextBox2.Text.ToString)
    End Sub

    Private Sub CuiTextBox22_KeyPress(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            loginUser(username:=Guna2TextBox1.Text.ToString, password:=Guna2TextBox2.Text.ToString)
        End If
    End Sub

    Private Sub CuiTextBox21_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            loginUser(username:=Guna2TextBox1.Text.ToString, password:=Guna2TextBox2.Text.ToString)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Guna2TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles Guna2TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            currentUser = Guna2TextBox1.Text.Trim()
            loginUser(username:=Guna2TextBox1.Text.ToString, password:=Guna2TextBox2.Text.ToString)
        End If
    End Sub
End Class
