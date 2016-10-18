Public Class Form1

    Private ctrl As MainController

    Private Sub DocentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocentesToolStripMenuItem.Click
        Dim docentes As DocenteView = New DocenteView
        docentes.ShowDialog()
    End Sub

    Private Sub CarrerasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarrerasToolStripMenuItem.Click
        Dim carreras As CarreraView = New CarreraView
        carreras.ShowDialog()
    End Sub

    Private Sub CursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem.Click
        Dim cursos As CursoView = New CursoView
        cursos.ShowDialog()
    End Sub

    Private Sub JornadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JornadaToolStripMenuItem.Click
        Dim jornadas As JornadaView = New JornadaView
        jornadas.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As AboutBox1 = New AboutBox1
        about.ShowDialog()
    End Sub

    Private Sub btnResponder_Click_1(sender As Object, e As EventArgs) Handles btnResponder.Click
        Dim encuesta As EncuestaView = New EncuestaView
        encuesta.ShowDialog()
    End Sub

    Private Sub ExportarArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarArchivoToolStripMenuItem.Click
        ctrl.GenerateReport()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl = New MainController(Me)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GraficaCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficaCursoToolStripMenuItem.Click
        Dim grafica As GraficaView = New GraficaView
        grafica.ShowDialog()
    End Sub

    Private Sub GraficaDocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficaDocenteToolStripMenuItem.Click
        Dim graficaDocente As GraficaDocenteView = New GraficaDocenteView
        graficaDocente.ShowDialog()
    End Sub
End Class
