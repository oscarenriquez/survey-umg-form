Imports System.Data.OleDb
Imports EncuestaUMG

Public Class CarreraADO

    Private Shared carreraADO As CarreraADO
    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As CarreraADO
        If carreraADO Is Nothing Then
            carreraADO = New CarreraADO
        End If
        Return carreraADO
    End Function

    Public Function ListEntities() As List(Of Carrera)
        Dim listaEntitties As List(Of Carrera) = New List(Of Carrera)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection
        Dim sbSql As String = "SELECT id, codigo, nombre FROM carrera;"
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim carrera = New Carrera
                    carrera.Id = reader.GetInt32(0)
                    carrera.Codigo = reader.GetInt32(1)
                    carrera.Nombre = reader.GetString(2)
                    listaEntitties.Add(carrera)
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
