Imports System.IO

Public Class GraficaDocenteController
    Private carreraADO As CarreraADO
    Private cursoADO As CursoADO
    Private jornadaADO As JornadaADO
    Private encuestaADO As EncuestaADO

    Private view As GraficaDocenteView

    Private Id_carrera As Integer
    Private Id_jornada As Integer
    Private Fecha As Date

    Sub New(ByRef view As GraficaDocenteView)
        carreraADO = CarreraADO.GetInstance
        cursoADO = CursoADO.GetInstance
        encuestaADO = EncuestaADO.GetInstance
        jornadaADO = JornadaADO.GetInstance

        Me.view = view
    End Sub

    Public Sub FillComboBoxes()
        view.cbGCarrera.DisplayMember = "Nombre"
        view.cbGJornada.DisplayMember = "Nombre"
        view.cbRango.DisplayMember = "Display"

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

            'Llena Combo de Rango
            view.cbRango.Items.Add(New RangoModel(0, 0)) 'TODOS
            view.cbRango.Items.Add(New RangoModel(90, 100))
            view.cbRango.Items.Add(New RangoModel(80, 90))
            view.cbRango.Items.Add(New RangoModel(60, 80))
            view.cbRango.Items.Add(New RangoModel(1, 60))
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
        ElseIf view.cbRango Is Nothing Then
            valit = False
        End If

        If valit Then
            Dim carrera As Carrera = view.cbGCarrera.SelectedItem
            Dim jornada As Jornada = view.cbGJornada.SelectedItem
            Dim rango As RangoModel = view.cbRango.SelectedItem

            Me.Id_carrera = carrera.Id
            Me.Id_jornada = jornada.Id

            view.Chart1.Series("Promedio").IsVisibleInLegend = False
            view.Chart1.Series("Promedio").Points.Clear()

            Try
                Dim lista As List(Of Dictionary(Of String, Object)) = encuestaADO.GetDataDocenteGrafica(Me.Fecha, Me.Id_carrera, Me.Id_jornada, rango.LowValue, rango.HighValue)
                If lista.Count > 0 Then
                    For Each dictionary In lista
                        Dim Nombre As String = dictionary.Item("Nombre")
                        Dim Promedio As Double = dictionary.Item("Promedio")
                        Dim Cantidad As Integer = dictionary.Item("Cantidad")

                        view.Chart1.Series("Promedio").Points.AddXY(Nombre, Promedio)
                        Dim point As DataVisualization.Charting.DataPoint = view.Chart1.Series("Promedio").Points.Last
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

    Public Class RangoModel
        Private m_Display As String
        Private m_LowValue As Integer
        Private m_HighValue As Integer

        Sub New(ByRef m_LowValue As Integer, ByRef m_HighValue As Integer)
            Me.m_LowValue = m_LowValue
            Me.m_HighValue = m_HighValue
            If Me.m_LowValue > 0 AndAlso Me.m_HighValue > 0 Then
                Me.m_Display = " Entre " & m_LowValue & " y " & m_HighValue
            Else
                Me.m_Display = " TODOS "
            End If
        End Sub

        Public ReadOnly Property Display As String
            Get
                Return Me.m_Display
            End Get
        End Property

        Public Property LowValue As Integer
            Get
                Return Me.m_LowValue
            End Get
            Set(value As Integer)
                Me.m_LowValue = value
            End Set
        End Property

        Public Property HighValue As Integer
            Get
                Return Me.m_HighValue
            End Get
            Set(value As Integer)
                Me.m_HighValue = value
            End Set
        End Property

    End Class

End Class
