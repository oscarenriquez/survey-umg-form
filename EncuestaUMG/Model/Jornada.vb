﻿Public Class Jornada
    Private m_Id As Integer
    Private m_Codigo As Char
    Private m_Nombre As String

    Public Property Id As Integer
        Get
            Return m_Id
        End Get
        Set(value As Integer)
            m_Id = value
        End Set
    End Property

    Public Property Codigo As Char
        Get
            Return m_Codigo
        End Get
        Set(value As Char)
            m_Codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return m_Nombre
        End Get
        Set(value As String)
            m_Nombre = value
        End Set
    End Property
End Class
