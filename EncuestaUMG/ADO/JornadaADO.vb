Imports System.Data.OleDb

Public Class JornadaADO
    Private Shared jornadaADO As JornadaADO
    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As JornadaADO
        If jornadaADO Is Nothing Then
            jornadaADO = New JornadaADO
        End If
        Return jornadaADO
    End Function

    Public Function ListEntities() As List(Of Jornada)
        Dim listaEntitties As List(Of Jornada) = New List(Of Jornada)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection
        Dim sbSql As String = "SELECT id, codigo, nombre FROM jornada;"
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim jornada = New Jornada
                    jornada.Id = reader.GetInt32(0)
                    jornada.Codigo = reader.GetString(1)
                    jornada.Nombre = reader.GetString(2)
                    listaEntitties.Add(jornada)
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        Finally
            If (connection IsNot Nothing) Then
                connection.Close()
            End If
        End Try
        Return listaEntitties
    End Function
End Class
