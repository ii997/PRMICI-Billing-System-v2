Imports MySql.Data.MySqlClient
Imports System.IO
Module globalVariables
    Public cn As MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public da As New MySqlDataAdapter
    Public currentSchoolYear As String = Date.UtcNow.ToString("yyyy")
    Public syId As Integer = 0
    Public currentUser As String
    Public tuitionFee As Integer
    Public Enum PaymentType
        TuitionFee
        Miscellaneous
    End Enum

    Public currentPaymentType As PaymentType

    Sub LoadTuition()
        Dim line As String
        Dim FilePath As String = $"C:\Users\Kyra Erika\Downloads\PRMICI Billing System v2\PRMICI Billing System v2\TuitionData.txt"
        ' Create new StreamReader instance with Using block.
        Using reader As New StreamReader(FilePath)
            ' Read one line from file
            line = reader.ReadLine
        End Using

        ' Write the line we read from "file.txt"
        tuitionFee = line
        FormMaintenance.Guna2HtmlLabel5.Text = $"Current Tuition Fee: {tuitionFee:N2}"
    End Sub

End Module
