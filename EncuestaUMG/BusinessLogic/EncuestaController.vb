Public Class EncuestaController

    Private carreraADO As CarreraADO
    Private cursoADO As CursoADO
    Private docenteADO As DocenteADO
    Private encuestaADO As EncuestaADO
    Private jornadaADO As JornadaADO

    Private view As EncuestaView

    Private Id_carrera As Integer
    Private Id_curso As Integer
    Private Id_docente As Integer
    Private Id_jornada As Integer
    Private Fecha As Date

    Private Total_Puntos As Integer
    Private Total_Area1 As Integer
    Private Total_Area2 As Integer
    Private Total_Area3 As Integer
    Private Total_Area4 As Integer

    Private listaEncuesta As List(Of Encuesta)

    Sub New(ByRef view As EncuestaView)
        carreraADO = CarreraADO.GetInstance
        cursoADO = CursoADO.GetInstance
        docenteADO = DocenteADO.GetInstance
        encuestaADO = EncuestaADO.GetInstance
        jornadaADO = JornadaADO.GetInstance

        Total_puntos = 0
        listaEncuesta = New List(Of Encuesta)

        Me.view = view
    End Sub

    Public Sub FillComboBoxes()
        view.cbCarrera.DisplayMember = "Nombre"
        view.cbCurso.DisplayMember = "Nombre"
        view.cbDocente.DisplayMember = "Nombre"
        view.cbJornada.DisplayMember = "Nombre"
        Try
            'Llena Combo de Carreras
            Dim listaCarreras As List(Of Carrera) = carreraADO.ListEntities()
            For Each carrera In listaCarreras
                view.cbCarrera.Items.Add(carrera)
            Next

            'Llena Combo de Cursos
            Dim listaCursos As List(Of Curso) = cursoADO.ListEntities()
            For Each curso In listaCursos
                view.cbCurso.Items.Add(curso)
            Next

            'Llena Combo de Docentes
            Dim listaDocentes As List(Of Docente) = docenteADO.ListEntities()
            For Each docente In listaDocentes
                view.cbDocente.Items.Add(docente)
            Next

            'Llena Combo de Jornada
            Dim listaJornadas As List(Of Jornada) = jornadaADO.ListEntities()
            For Each jornada In listaJornadas
                view.cbJornada.Items.Add(jornada)
            Next
        Catch ex As Exception
            view.ShowAlert(ex.Message)
        End Try
    End Sub

    Public Sub OnChangeComboBoxDocentes()
        Dim docente As Docente = view.cbDocente.SelectedItem
        If docente IsNot Nothing Then
            view.lblCodigo.Text = docente.Codigo.ToString
        Else
            view.lblCodigo.Text = "____________________"
        End If
    End Sub

    Public Sub FirstStep()
        view.tabCtrlEncuesta.TabPages.Clear()
        view.tabCtrlEncuesta.TabPages.Add(view.TabPage5)
        view.cbDocente.Focus()
    End Sub

    Public Sub SecondStep()

        Dim valit As Boolean = True

        If view.cbCarrera.SelectedItem Is Nothing Then
            valit = False
        ElseIf view.cbCurso.SelectedItem Is Nothing Then
            valit = False
        ElseIf view.cbDocente.SelectedItem Is Nothing Then
            valit = False
        ElseIf view.cbJornada.SelectedItem Is Nothing Then
            valit = False
        End If

        If valit Then
            Dim carrera As Carrera = view.cbCarrera.SelectedItem
            Dim curso As Curso = view.cbCurso.SelectedItem
            Dim docente As Docente = view.cbDocente.SelectedItem
            Dim jornada As Jornada = view.cbJornada.SelectedItem

            Me.Fecha = view.dpFecha.Value
            Me.Id_carrera = carrera.Id
            Me.Id_curso = curso.Id
            Me.Id_docente = docente.Id
            Me.Id_jornada = jornada.Id

            view.tabCtrlEncuesta.TabPages.Clear()
            view.tabCtrlEncuesta.TabPages.Add(view.TabPage1)
            view.tabCtrlEncuesta.SelectedTab = view.TabPage1
            'Set focus panel1
            view.pn1.Focus()
        Else
            view.ShowIncompleteData()
        End If

    End Sub

    Public Sub ThirdStep()
        'Pregunta de la 1 a la 7
        Dim p1 = GetValRadioButton(view.rbEX1, view.rbMB1, view.rbB1, view.rbNM1)
        Dim p2 = GetValRadioButton(view.rbEX2, view.rbMB2, view.rbB2, view.rbNM2)
        Dim p3 = GetValRadioButton(view.rbEX3, view.rbMB3, view.rbB3, view.rbNM3)
        Dim p4 = GetValRadioButton(view.rbEX4, view.rbMB4, view.rbB4, view.rbNM4)
        Dim p5 = GetValRadioButton(view.rbEX5, view.rbMB5, view.rbB5, view.rbNM5)
        Dim p6 = GetValRadioButton(view.rbEX6, view.rbMB6, view.rbB6, view.rbNM6)
        Dim p7 = GetValRadioButton(view.rbEX7, view.rbMB7, view.rbB7, view.rbNM7)

        Dim q1 = view.lbPregunta1.Text
        Dim q2 = view.lbPregunta2.Text
        Dim q3 = view.lbPregunta3.Text
        Dim q4 = view.lbPregunta4.Text
        Dim q5 = view.lbPregunta5.Text
        Dim q6 = view.lbPregunta6.Text
        Dim q7 = view.lbPregunta7.Text

        If p1 > 0 AndAlso p2 > 0 AndAlso p3 > 0 AndAlso p4 > 0 AndAlso p5 > 0 AndAlso p6 > 0 AndAlso p7 > 0 Then
            Total_Area1 = p1 + p2 + p3 + p4 + p5 + p6 + p7

            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q1, p1, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q2, p2, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q3, p3, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q4, p4, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q5, p5, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q6, p6, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q7, p7, Fecha))

            view.tabCtrlEncuesta.TabPages.Clear()
            view.tabCtrlEncuesta.TabPages.Add(view.TabPage2)
            view.tabCtrlEncuesta.SelectedTab = view.TabPage2
            'Set focus panel 8
            view.pn8.Focus()
        Else
            view.ShowIncompleteEncuesta()
        End If
    End Sub

    Public Sub FourthStep()
        'Pregunta de la 8 a la 12
        Dim p8 = GetValRadioButton(view.rbEX8, view.rbMB8, view.rbB8, view.rbNM8)
        Dim p9 = GetValRadioButton(view.rbEX9, view.rbMB9, view.rbB9, view.rbNM9)
        Dim p10 = GetValRadioButton(view.rbEX10, view.rbMB10, view.rbB10, view.rbNM10)
        Dim p11 = GetValRadioButton(view.rbEX11, view.rbMB11, view.rbB11, view.rbNM11)
        Dim p12 = GetValRadioButton(view.rbEX12, view.rbMB12, view.rbB12, view.rbNM12)

        Dim q8 = view.lbPregunta8.Text
        Dim q9 = view.lbPregunta9.Text
        Dim q10 = view.lbPregunta10.Text
        Dim q11 = view.lbPregunta11.Text
        Dim q12 = view.lbPregunta12.Text

        If p8 > 0 AndAlso p9 > 0 AndAlso p10 > 0 AndAlso p11 > 0 AndAlso p12 > 0 Then
            Total_Area2 = p8 + p9 + p10 + p11 + p12

            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q8, p8, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q9, p9, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q10, p10, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q11, p11, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q12, p12, Fecha))

            view.tabCtrlEncuesta.TabPages.Clear()
            view.tabCtrlEncuesta.TabPages.Add(view.TabPage3)
            view.tabCtrlEncuesta.SelectedTab = view.TabPage3
            'Set focus panel 13
            view.pn13.Focus()
        Else
            view.ShowIncompleteEncuesta()
        End If
    End Sub

    Public Sub FifthStep()
        'Pregunta de la 13 a la 21
        Dim p13 = GetValRadioButton(view.rbEX13, view.rbMB13, view.rbB13, view.rbNM13)
        Dim p14 = GetValRadioButton(view.rbEX14, view.rbMB14, view.rbB14, view.rbNM14)
        Dim p15 = GetValRadioButton(view.rbEX15, view.rbMB15, view.rbB15, view.rbNM15)
        Dim p16 = GetValRadioButton(view.rbEX16, view.rbMB16, view.rbB16, view.rbNM16)
        Dim p17 = GetValRadioButton(view.rbEX17, view.rbMB17, view.rbB17, view.rbNM17)
        Dim p18 = GetValRadioButton(view.rbEX18, view.rbMB18, view.rbB18, view.rbNM18)
        Dim p19 = GetValRadioButton(view.rbEX19, view.rbMB19, view.rbB19, view.rbNM19)
        Dim p20 = GetValRadioButton(view.rbEX20, view.rbMB20, view.rbB20, view.rbNM20)
        Dim p21 = GetValRadioButton(view.rbEX21, view.rbMB21, view.rbB21, view.rbNM21)

        Dim q13 = view.lbPregunta13.Text
        Dim q14 = view.lbPregunta14.Text
        Dim q15 = view.lbPregunta15.Text
        Dim q16 = view.lbPregunta16.Text
        Dim q17 = view.lbPregunta17.Text
        Dim q18 = view.lbPregunta18.Text
        Dim q19 = view.lbPregunta19.Text
        Dim q20 = view.lbPregunta10.Text
        Dim q21 = view.lbPregunta21.Text


        If p13 > 0 AndAlso p14 > 0 AndAlso p15 > 0 AndAlso p16 > 0 AndAlso p17 > 0 AndAlso p18 > 0 AndAlso p19 > 0 AndAlso p20 > 0 AndAlso p21 > 0 Then
            Total_Area3 = p13 + p14 + p15 + p16 + p17 + p18 + p19 + p20 + p21
            Total_Puntos = Total_Area1 + Total_Area2 + Total_Area3 + Total_Area4
            view.lbTotal.Text = Total_Puntos.ToString

            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q13, p13, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q14, p14, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q15, p15, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q16, p16, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q17, p17, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q18, p18, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q19, p19, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q20, p20, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q21, p21, Fecha))

            view.tabCtrlEncuesta.TabPages.Clear()
            view.tabCtrlEncuesta.TabPages.Add(view.TabPage4)
            view.tabCtrlEncuesta.SelectedTab = view.TabPage4
            'Set focus panel 22
            view.pn22.Focus()
        Else
            view.ShowIncompleteEncuesta()
        End If
    End Sub


    Public Sub SixthStep()
        'Pregunta de la 22 a la 25
        Dim p22 = GetValRadioButton(view.rbEX22, view.rbMB22, view.rbB22, view.rbNM22)
        Dim p23 = GetValRadioButton(view.rbEX23, view.rbMB23, view.rbB23, view.rbNM23)
        Dim p24 = GetValRadioButton(view.rbEX24, view.rbMB24, view.rbB24, view.rbNM24)
        Dim p25 = GetValRadioButton(view.rbEX25, view.rbMB25, view.rbB25, view.rbNM25)

        Dim q22 = view.lbPregunta22.Text
        Dim q23 = view.lbPregunta23.Text
        Dim q24 = view.lbPregunta24.Text
        Dim q25 = view.lbPregunta25.Text

        If p22 > 0 AndAlso p23 > 0 AndAlso p24 > 0 AndAlso p25 > 0 Then
            Total_Area4 = p22 + p23 + p24 + p25
            Total_Puntos = Total_Area1 + Total_Area2 + Total_Area3 + Total_Area4
            view.lbTotal.Text = Total_Puntos.ToString

            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q22, p22, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q23, p23, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q24, p24, Fecha))
            listaEncuesta.Add(New Encuesta(Id_carrera, Id_docente, Id_curso, Id_jornada, q25, p25, Fecha))

            Try
                SaveAllEncuesta()
                view.Close()
                listaEncuesta.Clear()
                listaEncuesta = Nothing
            Catch ex As Exception
                view.ShowAlert(ex.Message)
            End Try

        Else
            view.ShowIncompleteEncuesta()
        End If
    End Sub

    Public Sub BackSecondStep()
        view.tabCtrlEncuesta.TabPages.Clear()
        view.tabCtrlEncuesta.TabPages.Add(view.TabPage1)
        view.tabCtrlEncuesta.SelectedTab = view.TabPage1
        view.pn1.Focus()
    End Sub

    Public Sub BackThridStep()
        view.tabCtrlEncuesta.TabPages.Clear()
        view.tabCtrlEncuesta.TabPages.Add(view.TabPage2)
        view.tabCtrlEncuesta.SelectedTab = view.TabPage2
        view.pn8.Focus()
    End Sub

    Public Sub BackFouthStep()
        view.tabCtrlEncuesta.TabPages.Clear()
        view.tabCtrlEncuesta.TabPages.Add(view.TabPage3)
        view.tabCtrlEncuesta.SelectedTab = view.TabPage3
        view.pn13.Focus()
    End Sub

    Public Sub RefreshTotal()
        Dim p22 = GetValRadioButton(view.rbEX22, view.rbMB22, view.rbB22, view.rbNM22)
        Dim p23 = GetValRadioButton(view.rbEX23, view.rbMB23, view.rbB23, view.rbNM23)
        Dim p24 = GetValRadioButton(view.rbEX24, view.rbMB24, view.rbB24, view.rbNM24)
        Dim p25 = GetValRadioButton(view.rbEX25, view.rbMB25, view.rbB25, view.rbNM25)
        Total_Area4 = p22 + p23 + p24 + p25
        Total_Puntos = Total_Area1 + Total_Area2 + Total_Area3 + Total_Area4
        view.lbTotal.Text = Total_Puntos.ToString
    End Sub

    Private Sub SaveAllEncuesta()
        listaEncuesta.ForEach(Sub(encuesta) encuestaADO.CreateEntity(encuesta))
    End Sub

    Private Function GetValRadioButton(rbEX As RadioButton, rbMB As RadioButton, rbB As RadioButton, rbNM As RadioButton) As Integer
        If rbEX.Checked Then
            Return 4
        ElseIf rbMB.Checked Then
            Return 3
        ElseIf rbB.Checked Then
            Return 2
        ElseIf rbNM.Checked Then
            Return 1
        Else
            Return 0
        End If
    End Function

End Class