Imports System.Data.OleDb

Public Class CursoADO
    Private Shared cursoADO As CursoADO
    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As CursoADO
        If cursoADO Is Nothing Then
            cursoADO = New CursoADO
        End If
        Return cursoADO
    End Function
    Public Function ListEntities() As List(Of Curso)
        Dim listaEntitties As List(Of Curso) = New List(Of Curso)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection
        Dim sbSql As String = "SELECT id, codigo, nombre FROM curso;"
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim curso = New Curso
                    curso.Id = reader.GetInt32(0)
                    curso.Codigo = reader.GetInt32(1)
                    curso.Nombre = reader.GetString(2)
                    listaEntitties.Add(curso)
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
