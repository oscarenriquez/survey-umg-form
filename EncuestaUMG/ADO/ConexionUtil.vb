Imports System.Data.OleDb

Module ConexionUtil
    Private connection As OleDbConnection
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\dbAccess\EncuestaUMGdb.accdb;Persist Security Info=False;"


    Public Function GetConnection() As OleDbConnection
        If connection Is Nothing Then
            connection = New OleDbConnection(connectionString)
        End If
        Return connection
    End Function

    Public Function CreateCommand(queryString As String, ByRef connection As OleDbConnection, parameters As List(Of OleDbParameter)) As Integer
        Try
            Dim command As New OleDbCommand(queryString, connection)

            For Each parameter In parameters
                command.Parameters.Add(parameter)
            Next
            Return command.ExecuteNonQuery
        Catch ex As Exception
            Throw New Exception("No fue posible realizar la transaccion, Msg: " & ex.Message)
        End Try
    End Function

    Public Function CreateCommandRead(queryString As String, ByRef connection As OleDbConnection, parameters As List(Of OleDbParameter)) As OleDbDataReader
        Try
            Dim command As New OleDbCommand(queryString, connection)

            For Each parameter In parameters
                command.Parameters.Add(parameter)
            Next
            Return command.ExecuteReader
        Catch ex As Exception
            Throw New Exception("No fue posible realizar la transaccion, Msg: " & ex.Message)
        End Try
    End Function

End Module
