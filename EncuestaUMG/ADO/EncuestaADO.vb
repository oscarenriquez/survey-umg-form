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


    ''' <summary>
    ''' MethodSubprocess to create Encuesta row
    ''' </summary>
    ''' <param name="entity">Object that refers Encuesta Table</param>
    Public Sub CreateEntity(entity As Encuesta)
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection()
        Dim sbSql As String
        sbSql = "INSERT INTO Encuesta (Id_carrera, Id_docente, Id_curso, Id_jornada, pregunta, codigo_resp, puntos, fecha) "
        sbSql &= " VALUES(@Id_carrera, @Id_docente, @Id_curso, @Id_jornada, @pregunta, @codigo_resp, @puntos, @fecha) "

        Dim param1 = New OleDbParameter("@Id_carrera", OleDbType.Integer)
        Dim param2 = New OleDbParameter("@Id_docente", OleDbType.Integer)
        Dim param3 = New OleDbParameter("@Id_curso", OleDbType.Integer)
        Dim param4 = New OleDbParameter("@Id_jornada", OleDbType.Integer)
        Dim param5 = New OleDbParameter("@pregunta", OleDbType.BSTR)
        Dim param6 = New OleDbParameter("@codigo_resp", OleDbType.BSTR)
        Dim param7 = New OleDbParameter("@puntos", OleDbType.Integer)
        Dim param8 = New OleDbParameter("@fecha", OleDbType.Date)

        param1.Value = entity.IdCarrera
        param2.Value = entity.IdDocente
        param3.Value = entity.IdCurso
        param4.Value = entity.IdJornada
        param5.Value = entity.Pregunta
        param6.Value = entity.Codigo_resp
        param7.Value = entity.Puntos
        param8.Value = entity.Fecha

        parameters.Add(param1)
        parameters.Add(param2)
        parameters.Add(param3)
        parameters.Add(param4)
        parameters.Add(param5)
        parameters.Add(param6)
        parameters.Add(param7)
        parameters.Add(param8)

        Try
            connection.Open()
            Dim valRet = ConexionUtil.CreateCommand(sbSql, connection, parameters)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)
            Throw New Exception("Creando Encuesta: " & ex.Message)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try
    End Sub

    ''' <summary>
    ''' Function to get all data of Encuesta table
    ''' </summary>
    ''' <returns>List of string that refer all encuesta data</returns>
    Public Function GetAllData() As List(Of String)
        Dim result As List(Of String) = New List(Of String)
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection()
        Dim sbSql As String

        sbSql = " SELECT Encuesta.Id, Carrera.Id, Carrera.Nombre, Curso.Id, Curso.Nombre, 
                         Docente.Id, Docente.Codigo, Docente.Nombre, Jornada.Nombre, 
                         Encuesta.pregunta, Encuesta.codigo_resp, Encuesta.puntos, Encuesta.fecha "
        sbSql &= " FROM Jornada INNER JOIN (Docente 
                                INNER JOIN (Curso 
                                INNER JOIN (Carrera 
                                INNER JOIN Encuesta 
                                    ON Carrera.Id = Encuesta.Id_carrera) 
                                    ON Curso.Id = Encuesta.Id_curso) 
                                    ON Docente.Id = Encuesta.Id_docente) 
                                    ON Jornada.Id = Encuesta.Id_jornada; "

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim linea As String
                    linea = reader.GetInt32(0) & "|" & 'Encuesta.Id
                            reader.GetInt32(1) & "|" & 'Carrera.Id
                            reader.GetString(2) & "|" & 'Carrera.Nombre
                            reader.GetInt32(3) & "|" & 'Curso.Id
                            reader.GetString(4) & "|" & 'Curso.Nombre
                            reader.GetInt32(5) & "|" & 'Docente.Id
                            reader.GetInt32(6) & "|" & 'Docente.Codigo
                            reader.GetString(7) & "|" & 'Docente.Nombre
                            reader.GetInt32(8) & "|" & 'Jornada.Id
                            reader.GetString(9) & "|" & 'Jornada.Nombre
                            reader.GetString(10) & "|" & 'Encuesta.pregunta
                            reader.GetString(11) & "|" & 'Encuesta.codigo_resp
                            reader.GetInt32(12) & "|" & 'Encuesta.puntos
                            reader.GetDateTime(13) 'Encuesta.fecha

                    result.Add(linea)
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw New Exception("Creando Archivo de Informacion General, " & ex.Message)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Function to get graphic group by Curso
    ''' </summary>
    ''' <param name="Fecha"></param>
    ''' <param name="Id_carrera"></param>
    ''' <param name="Id_jornada"></param>
    ''' <returns>List of Dictionary</returns>
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
            Console.WriteLine(ex.StackTrace)
            Throw New Exception("Generando Grafica .... " & ex.Message)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try

        Return result
    End Function

    Public Function GetDataDocenteGrafica(Fecha As Date, Id_carrera As Integer, Id_jornada As Integer, MinValue As Integer, MaxValue As Integer) As List(Of Dictionary(Of String, Object))
        Dim result As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection()
        Dim sbSql As String

        sbSql = "SELECT x.Nombre, Avg(x.puntos), Count(*) FROM ("
        sbSql &= " SELECT Docente.Nombre, Encuesta.Id_carrera, Encuesta.Id_docente, Encuesta.Id_curso, Encuesta.Id_jornada, Sum(Encuesta.puntos) As puntos "
        sbSql &= " FROM (Docente INNER JOIN Encuesta ON Docente.Id = Encuesta.Id_docente) "
        sbSql &= " WHERE DateValue(Encuesta.fecha) = DateValue(@Fecha) "
        sbSql &= "   AND Encuesta.Id_carrera = @Id_carrera "
        sbSql &= "   AND Encuesta.Id_jornada = @Id_jornada "
        sbSql &= " GROUP BY Docente.Nombre, Encuesta.Id_carrera, Encuesta.Id_docente, Encuesta.Id_curso, Encuesta.Id_jornada "
        sbSql &= " ) As x "

        If (MinValue > 0 AndAlso MaxValue > 0) Then
            sbSql &= " WHERE Avg(x.puntos) BETWEEN @MinValue AND @MaxValue "
        End If

        sbSql &= "  GROUP BY x.Nombre "
        sbSql &= " ORDER BY Avg(x.puntos) DESC; "

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
                    linea.Add("Promedio", reader.GetDouble(1))
                    linea.Add("Cantidad", reader.GetInt32(2))

                    result.Add(linea)
                Loop
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw New Exception("Generando Grafica .... " & ex.Message)
        Finally
            If connection IsNot Nothing Then
                connection.Close()
            End If
        End Try

        Return result
    End Function

End Class
