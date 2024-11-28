Imports MySql.Data.MySqlClient
Module globalVariables
    Public cn As MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As DataTable
    Public da As New MySqlDataAdapter
    Public currentSchoolYear As String = Date.UtcNow.ToString("yyyy")
    Public syId As Integer = 0
    Public currentUser As String

    Public Enum PaymentType
        TuitionFee
        Miscellaneous
    End Enum

    Public currentPaymentType As PaymentType
End Module
