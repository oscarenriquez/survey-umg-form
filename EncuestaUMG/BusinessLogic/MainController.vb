Imports EncuestaUMG
Imports System.Globalization
Public Class MainController

    Private encuestaADO As EncuestaADO
    Private Const PASSWORD_CONSULTA As String = "supervisor-umg"

    Public Event Full()

    Private view As Form1

    Public Sub New(form1 As Form1)
        encuestaADO = EncuestaADO.GetInstance
        Me.view = form1
    End Sub

    Function ValidaCredenciales(password As String) As Boolean
        Return PASSWORD_CONSULTA.Equals(password)
    End Function

    Public Sub GenerateReport()
        view.SaveFileDialog1.ShowDialog()
        ' If the file name is not an empty string open it for saving.
        If view.SaveFileDialog1.FileName <> "" Then
            Dim listaData As List(Of String) = encuestaADO.GetAllData

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(view.SaveFileDialog1.FileName, True)
            For Each linea In listaData
                file.WriteLine(linea)
            Next
            file.Close()
        End If
    End Sub

    Public Sub ImportarData()
        If view.OpenFileDialog1.FileName <> "" Then
            Dim file As System.IO.StreamReader
            Dim lista As List(Of Encuesta) = New List(Of Encuesta)
            Dim tamanio As Integer = 0, paso As Integer = 0, i As Integer = 0
            Try
                file = My.Computer.FileSystem.OpenTextFileReader(view.OpenFileDialog1.FileName)
                Dim line As String
                Do
                    line = file.ReadLine()
                    If line IsNot Nothing Then
                        Dim array() As String = line.Split("|")
                        Dim encuesta As Encuesta = New Encuesta

                        encuesta.IdCarrera = Convert.ToInt32(array(1))
                        encuesta.IdCurso = Convert.ToInt32(array(3))
                        encuesta.IdDocente = Convert.ToInt32(array(5))
                        encuesta.IdJornada = Convert.ToInt32(array(8))
                        encuesta.Pregunta = array(10)
                        encuesta.Codigo_resp = array(11)
                        encuesta.Puntos = Convert.ToInt32(array(12))
                        encuesta.Fecha = Date.ParseExact(array(13), "d/MM/yyyy H:mm:ss", New CultureInfo("es-ES"))
                        lista.Add(encuesta)
                    End If
                Loop Until line Is Nothing

                'Tamanio de la lista
                tamanio = lista.Count
                paso = tamanio / 100

                If paso = 0 Then
                    paso = 1
                End If

                'Se inicia a grabar la informacion
                For Each encuesta In lista
                    If Not encuestaADO.ExisteEncuesta(encuesta.IdCarrera, encuesta.IdJornada, encuesta.IdCurso, encuesta.IdDocente, encuesta.Fecha) Then
                        encuestaADO.CreateEntity(encuesta)
                    End If
                    i += 1
                    If paso <= i Then
                        RaiseEvent Full()
                        i = 0
                    End If
                Next
                view.cargando.Close()
                view.ShowSuccess("¡Información cargada Exitosamente!")
            Catch ex As IO.IOException
                Console.WriteLine(ex.StackTrace)
                Throw New Exception("Importando información: " & ex.Message)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
                Throw New Exception("Importando información: " & ex.Message)
            Finally
                If file IsNot Nothing Then
                    file.Close()
                    file = Nothing
                End If
            End Try
        End If
    End Sub
End Class
