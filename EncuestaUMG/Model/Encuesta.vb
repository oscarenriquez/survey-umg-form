Public Class Encuesta
    Private m_Id As Integer
    Private m_IdCarrera As Integer
    Private m_IdDocente As Integer
    Private m_IdCurso As Integer
    Private m_IdJornada As Integer
    Private m_pregunta As String
    Private m_codigo_resp As String
    Private m_puntos As Integer
    Private m_Fecha As Date

    Public Sub New(m_IdCarrera As Integer,
                   m_IdDocente As Integer,
                   m_IdCurso As Integer,
                   m_IdJornada As Integer,
                   m_pregunta As String,
                   m_puntos As Integer,
                   m_Fecha As Date)

        Me.m_IdCarrera = m_IdCarrera
        Me.m_IdDocente = m_IdDocente
        Me.m_IdCurso = m_IdCurso
        Me.m_IdJornada = m_IdJornada
        Me.m_pregunta = m_pregunta
        Me.m_puntos = m_puntos
        Me.m_Fecha = m_Fecha

        If m_puntos.Equals(4) Then
            Me.m_codigo_resp = "EX"
        ElseIf m_puntos.Equals(3) Then
            Me.m_codigo_resp = "MB"
        ElseIf m_puntos.Equals(2) Then
            Me.m_codigo_resp = "B"
        ElseIf m_puntos.Equals(1) Then
            Me.m_codigo_resp = "NM"
        End If

    End Sub


    Public Property Id As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property

    Public Property IdCarrera As Integer
        Get
            Return m_IdCarrera
        End Get
        Set(value As Integer)
            m_IdCarrera = value
        End Set
    End Property

    Public Property IdDocente As Integer
        Get
            Return m_IdDocente
        End Get
        Set(value As Integer)
            m_IdDocente = value
        End Set
    End Property

    Public Property IdCurso As Integer
        Get
            Return m_IdCurso
        End Get
        Set(value As Integer)
            m_IdCurso = value
        End Set
    End Property

    Public Property IdJornada As Integer
        Get
            Return m_IdJornada
        End Get
        Set(value As Integer)
            m_IdJornada = value
        End Set
    End Property

    Public Property Pregunta As String
        Get
            Return m_pregunta
        End Get
        Set(value As String)
            m_pregunta = value
        End Set
    End Property

    Public Property Codigo_resp As String
        Get
            Return m_codigo_resp
        End Get
        Set(value As String)
            m_codigo_resp = value
        End Set
    End Property

    Public Property Puntos As Integer
        Get
            Return m_puntos
        End Get
        Set(value As Integer)
            m_puntos = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return m_Fecha
        End Get
        Set(value As Date)
            m_Fecha = value
        End Set
    End Property
End Class
