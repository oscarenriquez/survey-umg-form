Public Class GraficaView
    Private ctrl As GraficaController
    Private Sub GraficaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl = New GraficaController(Me)
        ctrl.FillComboBoxes()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        ctrl.GenerateGraph()
    End Sub

    Friend Sub ShowIncompleteData()
        MessageBox.Show("¡Complete todos los campos antes de continuar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class