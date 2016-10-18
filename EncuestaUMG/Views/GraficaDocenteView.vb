Public Class GraficaDocenteView
    Private ctrl As GraficaDocenteController
    Private Sub GraficaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl = New GraficaDocenteController(Me)
        ctrl.FillComboBoxes()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        ctrl.GenerateGraph()
    End Sub

    Friend Sub ShowIncompleteData()
        MessageBox.Show("¡Complete todos los campos antes de continuar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Friend Sub ShowAlert(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        ctrl.ExportChartToImage()
    End Sub
End Class