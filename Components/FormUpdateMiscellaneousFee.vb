Imports MySql.Data.MySqlClient
Public Class FormUpdateMiscellaneousFee
    Private Sub FormUpdateMiscellaneousFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMiscellaneousAmounts()
    End Sub

    Private Sub LoadMiscellaneousAmounts()
        Try
            ' Open the database connection
            cn.Open()

            ' Execute the query
            Using cm As New MySqlCommand("SELECT * FROM miscellaneous", cn)
                Using dr As MySqlDataReader = cm.ExecuteReader()
                    ' Clear existing controls (optional, if reloading data)
                    Me.Controls.Clear()

                    Dim yPosition As Integer = 40 ' Vertical position for controls

                    While dr.Read()
                        ' Create a new label for "id"
                        Dim lblId As New Label()
                        lblId.Text = dr("misc").ToString()
                        lblId.Location = New Point(10, yPosition)
                        lblId.AutoSize = True
                        lblId.Font = New Font("Poppins", 10, FontStyle.Regular) ' Example: Arial, 10pt, Bold
                        lblId.ForeColor = Color.White
                        Me.Controls.Add(lblId)

                        ' Create a new textbox for "amount"
                        Dim txtAmount As New TextBox()
                        txtAmount.Name = "txtAmount" & dr("id").ToString()
                        txtAmount.Text = dr("amount")
                        txtAmount.Location = New Point(220, yPosition)
                        txtAmount.Font = New Font("Poppins", 10, FontStyle.Regular)
                        txtAmount.Width = 125
                        Me.Controls.Add(txtAmount)

                        Dim btnUpdate As New Button
                        btnUpdate.Text = "Update Fees"
                        btnUpdate.Location = New Point(350, yPosition)
                        btnUpdate.Tag = dr("id")
                        AddHandler btnUpdate.Click, AddressOf UpdateSingleRow
                        Me.Controls.Add(btnUpdate)
                        ' Increment vertical position for the next set of controls
                        yPosition += 30
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            ' Close the database connection
            cn.Close()
        End Try
    End Sub

    Private Sub UpdateSingleRow(sender As Object, e As EventArgs)
        Try
            Dim btn As Button = CType(sender, Button)
            Dim id As Integer = CInt(btn.Tag)

            ' Find TextBox in the parent container of the button
            Dim txtAmount As TextBox = CType(btn.Parent.Controls.Find("txtAmount" & id, True).FirstOrDefault(), TextBox)

            If txtAmount Is Nothing Then
                MsgBox("TextBox control not found.", vbExclamation)
                Return
            End If

            If IsNumeric(txtAmount) Then
                MsgBox("Please enter a valid value for Amount.", vbExclamation)
                Return
            End If

            Dim amountValue As String = txtAmount.Text

            If String.IsNullOrWhiteSpace(amountValue) Then
                MsgBox("Please enter a valid value for Amount.", vbExclamation)
                Return
            End If

            Dim amount As Double
            If Not Double.TryParse(amountValue, amount) Then
                MsgBox("Amount must be numeric for ID: " & id, vbExclamation)
                Return
            End If

            cn.Open()
            Using cm As New MySqlCommand("UPDATE miscellaneous SET amount = @amount WHERE id = @id", cn)
                cm.Parameters.AddWithValue("@id", id)
                cm.Parameters.AddWithValue("@amount", amount)

                Dim rowsAffected As Integer = cm.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Miscellaneous fee updated successfully", vbInformation, "Fee Updated!")
                Else
                    MsgBox("No rows updated. Please check if the ID exists.", vbExclamation)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
        Finally
            cn.Close()
        End Try
    End Sub





End Class