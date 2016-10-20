Imports System.Threading

Public Class Form1

    Private ctrl As MainController
    Friend cargando As LoadingView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ctrl = New MainController(Me)
    End Sub

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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GraficaCursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficaCursoToolStripMenuItem.Click
        Dim loginForm = New LoginForm
        Dim result = loginForm.ShowDialog(Me)
        If result = DialogResult.OK Then
            If (ctrl.ValidaCredenciales(loginForm.PasswordTextBox.Text)) Then
                Dim grafica As GraficaView = New GraficaView
                grafica.ShowDialog()
            Else
                ShowAlert("Credenciales Incorrectas")
            End If
        End If
    End Sub

    Private Sub GraficaDocenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraficaDocenteToolStripMenuItem.Click
        Dim loginForm = New LoginForm
        Dim result = loginForm.ShowDialog(Me)
        If result = DialogResult.OK Then
            If (ctrl.ValidaCredenciales(loginForm.PasswordTextBox.Text)) Then
                Dim graficaDocente As GraficaDocenteView = New GraficaDocenteView
                graficaDocente.ShowDialog()
            Else
                ShowAlert("Credenciales Incorrectas")
            End If
        End If
    End Sub

    Friend Sub ShowAlert(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Friend Sub ShowSuccess(message As String)
        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MenuImportarArchivo_Click(sender As Object, e As EventArgs) Handles MenuImportarArchivo.Click
        cargando = New LoadingView
        Dim loginForm = New LoginForm
        Dim result = LoginForm.ShowDialog(Me)
        If result = DialogResult.OK Then
            If (ctrl.ValidaCredenciales(loginForm.PasswordTextBox.Text)) Then
                OpenFileDialog1.ShowDialog()
                Dim thread As New Thread(New ThreadStart(AddressOf ImportandoData))
                thread.Start()

                AddHandler ctrl.Full, AddressOf cargando.ChangeValues

                cargando.ShowDialog(Me)
            Else
                ShowAlert("Credenciales Incorrectas")
            End If
            loginForm.Close()
        End If
    End Sub

    Private Sub ImportandoData()
        ctrl.ImportarData()
    End Sub
End Class
