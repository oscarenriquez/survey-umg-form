Imports System.Data.OleDb

Public Class DocenteADO
    Private Shared docenteADO As DocenteADO
    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As DocenteADO
        If docenteADO Is Nothing Then
            docenteADO = New DocenteADO
        End If
        Return docenteADO
    End Function

    Public Function ListEntities() As List(Of Docente)
        Dim listaEntitties As List(Of Docente) = New List(Of Docente)
        Dim connection As OleDbConnection = ConexionUtil.GetConnection
        Dim sbSql As String = "SELECT id, nombre, codigo FROM docente;"
        Dim parameters As List(Of OleDbParameter) = New List(Of OleDbParameter)

        Try
            connection.Open()
            Dim reader = ConexionUtil.CreateCommandRead(sbSql, connection, parameters)
            If reader.HasRows Then
                Do While reader.Read
                    Dim docente = New Docente
                    docente.Id = reader.GetInt32(0)
                    docente.Nombre = reader.GetString(1)
                    docente.Codigo = reader.GetInt32(2)
                    listaEntitties.Add(docente)
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
