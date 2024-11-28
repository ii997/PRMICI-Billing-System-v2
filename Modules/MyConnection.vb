Imports MySql.Data.MySqlClient

Module MyConnection
    Function ConnectToDB() As Boolean
        Try
            cn = New MySqlConnection("server=localhost;user=root;password=;database=db.prmici_billing")
            cn.Open()
            cn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error!")
            Return False
        Finally
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Function
End Module
