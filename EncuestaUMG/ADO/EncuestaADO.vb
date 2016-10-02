Imports System.Data.OleDb
Imports EncuestaUMG

Public Class EncuestaADO
    Private Shared encuestaADO As EncuestaADO
    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As EncuestaADO
        If encuestaADO Is Nothing Then
            encuestaADO = New EncuestaADO
        End If
        Return encuestaADO
    End Function

    Public Sub CreateEntity(entity As Encuesta)
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection()
        Dim sbSql As String
        sbSql = "INSERT INTO Encuesta (Id_carrera, Id_docente, Id_curso, Id_jornada, pregunta, codigo_resp, puntos, fecha) "
        sbSql &= " VALUES(@Id_carrera, @Id_docente, @Id_curso, @Id_jornada, @pregunta, @codigo_resp, @puntos, @fecha) "

        parameters.Add(New OleDbParameter("@Id_carrera", entity.IdCarrera))
        parameters.Add(New OleDbParameter("@Id_docente", entity.IdDocente))
        parameters.Add(New OleDbParameter("@Id_curso", entity.IdCurso))
        parameters.Add(New OleDbParameter("@Id_jornada", entity.IdJornada))
        parameters.Add(New OleDbParameter("@pregunta", entity.Pregunta))
        parameters.Add(New OleDbParameter("@codigo_resp", entity.Codigo_resp))
        parameters.Add(New OleDbParameter("@puntos", entity.Puntos))
        parameters.Add(New OleDbParameter("@fecha", entity.Fecha))

        Try
            connection.Open()
            Dim valRet = ConexionUtil.CreateCommand(sbSql, connection, parameters)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub

    Public Function GetAllData() As List(Of String)
        Dim result As List(Of String) = New List(Of String)
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection()
        Dim sbSql As String

        sbSql = " SELECT Encuesta.Id, Carrera.Nombre, Curso.Nombre, Docente.Codigo, Docente.Nombre, Jornada.Nombre, Encuesta.pregunta, Encuesta.codigo_resp, Encuesta.puntos, Encuesta.fecha "
        sbSql &= " FROM Jornada INNER JOIN (Docente INNER JOIN (Curso INNER JOIN (Carrera INNER JOIN Encuesta ON Carrera.Id = Encuesta.Id_carrera) ON Curso.Id = Encuesta.Id_curso) ON Docente.Id = Encuesta.Id_docente) ON Jornada.Id = Encuesta.Id_jornada; "

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim linea As String
                    linea = reader.GetInt32(0) & vbTab &
                            reader.GetString(1) & vbTab &
                            reader.GetString(2) & vbTab &
                            reader.GetInt32(3) & vbTab &
                            reader.GetString(4) & vbTab &
                            reader.GetString(5) & vbTab &
                            reader.GetString(6) & vbTab &
                            reader.GetString(7) & vbTab &
                            reader.GetInt32(8) & vbTab &
                            reader.GetDateTime(9)

                    result.Add(linea)
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try

        Return result
    End Function

    Public Function GetDataGrafica(Fecha As Date, Id_carrera As Integer, Id_jornada As Integer) As List(Of Dictionary(Of String, Object))
        Dim result As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection()
        Dim sbSql As String

        sbSql = " SELECT Curso.Nombre, Encuesta.codigo_resp, Count(*) "
        sbSql &= " FROM (Curso INNER JOIN Encuesta ON Curso.Id = Encuesta.Id_curso) "
        sbSql &= " WHERE DateValue(Encuesta.fecha) = DateValue(@Fecha) "
        sbSql &= "   AND Encuesta.Id_carrera = @Id_carrera "
        sbSql &= "   AND Encuesta.Id_jornada = @Id_jornada "
        sbSql &= " GROUP BY Curso.Nombre, Encuesta.codigo_resp "

        parameters.Add(New OleDbParameter("@Fecha", Fecha))
        parameters.Add(New OleDbParameter("@Id_carrera", Id_carrera))
        parameters.Add(New OleDbParameter("@Id_jornada", Id_jornada))

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim linea As Dictionary(Of String, Object) = New Dictionary(Of String, Object)

                    linea.Add("Nombre", reader.GetString(0))
                    linea.Add("Codigo", reader.GetString(1))
                    linea.Add("Cantidad", reader.GetInt32(2))

                    result.Add(linea)
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try

        Return result
    End Function

End Class
