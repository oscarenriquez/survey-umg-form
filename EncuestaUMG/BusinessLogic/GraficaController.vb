﻿Public Class GraficaController
    Private carreraADO As CarreraADO
    Private cursoADO As CursoADO
    Private jornadaADO As JornadaADO
    Private encuestaADO As EncuestaADO

    Private view As GraficaView

    Private Id_carrera As Integer
    Private Id_jornada As Integer
    Private Fecha As Date

    Sub New(ByRef view As GraficaView)
        carreraADO = CarreraADO.GetInstance
        cursoADO = CursoADO.GetInstance
        encuestaADO = EncuestaADO.GetInstance
        jornadaADO = JornadaADO.GetInstance

        Me.view = view
    End Sub

    Public Sub FillComboBoxes()
        view.cbGCarrera.DisplayMember = "Nombre"
        view.cbGJornada.DisplayMember = "Nombre"

        Try
            'Llena Combo de Carreras
            Dim listaCarreras As List(Of Carrera) = carreraADO.ListEntities()
            For Each carrera In listaCarreras
                view.cbGCarrera.Items.Add(carrera)
            Next

            'Llena Combo de Jornada
            Dim listaJornadas As List(Of Jornada) = jornadaADO.ListEntities()
            For Each jornada In listaJornadas
                view.cbGJornada.Items.Add(jornada)
            Next
        Catch ex As Exception
            view.ShowAlert(ex.Message)
        End Try
    End Sub

    Public Sub GenerateGraph()
        Dim valit As Boolean = True
        Fecha = view.dtGFecha.Value.Date

        If view.cbGCarrera.SelectedItem Is Nothing Then
            valit = False
        ElseIf view.cbGJornada.SelectedItem Is Nothing Then
            valit = False
        End If

        If valit Then
            Dim carrera As Carrera = view.cbGCarrera.SelectedItem
            Dim jornada As Jornada = view.cbGJornada.SelectedItem

            Me.Id_carrera = carrera.Id
            Me.Id_jornada = jornada.Id

            view.Chart1.Series("EX").Points.Clear()
            view.Chart1.Series("MB").Points.Clear()
            view.Chart1.Series("B").Points.Clear()
            view.Chart1.Series("NM").Points.Clear()

            Try
                Dim lista As List(Of Dictionary(Of String, Object)) = encuestaADO.GetDataGrafica(Me.Fecha, Me.Id_carrera, Me.Id_jornada)
                If lista.Count > 0 Then
                    For Each dictionary In lista
                        Dim Nombre As String = dictionary.Item("Nombre")
                        Dim Codigo As String = dictionary.Item("Codigo")
                        Dim Cantidad As Integer = dictionary.Item("Cantidad")

                        view.Chart1.Series(Codigo).Points.AddXY(Nombre, Cantidad)
                        Dim point As DataVisualization.Charting.DataPoint = view.Chart1.Series(Codigo).Points.Last
                        point.IsValueShownAsLabel = True
                        point.LabelBackColor = Color.AliceBlue
                        point.LabelBorderColor = Color.DarkBlue
                    Next
                Else
                    view.ShowAlert("¡No existe Información!")
                End If
            Catch ex As Exception
                view.ShowAlert(ex.Message)
            End Try
        Else
            view.ShowIncompleteData()
        End If
    End Sub

    Public Sub ExportChartToImage()
        view.SaveFileDialog1.ShowDialog()
        ' If the file name is not an empty string open it for saving.
        If view.SaveFileDialog1.FileName <> "" Then
            view.Chart1.SaveImage(view.SaveFileDialog1.FileName, DataVisualization.Charting.ChartImageFormat.Jpeg)
        End If
    End Sub

End Class
