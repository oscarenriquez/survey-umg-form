Public Class EncuestaView

    Private ctrl As EncuestaController

    Private Sub EncuestaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctrl = New EncuestaController(Me)
        ctrl.FillComboBoxes()
        ctrl.FirstStep()
        Console.WriteLine(Me.pn1.TabIndex.ToString())

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ctrl.SecondStep()
    End Sub

    Private Sub btnContinuar1_Click(sender As Object, e As EventArgs) Handles btnContinuar1.Click
        ctrl.ThirdStep()
    End Sub

    Private Sub btnContinuar2_Click(sender As Object, e As EventArgs) Handles btnContinuar2.Click
        ctrl.FourthStep()
    End Sub

    Private Sub btnContinuar3_Click(sender As Object, e As EventArgs) Handles btnContinuar3.Click
        ctrl.FifthStep()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If MessageBox.Show("¿Esta seguro de guardar la encuesta?" & vbCr & "No podrá realizar ningún cambio después de ser Guardada.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            ctrl.SixthStep()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Friend Sub ShowIncompleteData()
        MessageBox.Show("¡Complete todos los campos antes de continuar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Friend Sub ShowIncompleteEncuesta()
        MessageBox.Show("¡Complete todos las preguntas antes de continuar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub cbDocente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbDocente.SelectionChangeCommitted
        ctrl.OnChangeComboBoxDocentes()
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        ctrl.FirstStep()
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        ctrl.BackSecondStep()
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        ctrl.BackThridStep()
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        ctrl.BackFouthStep()
    End Sub

    Private Sub FocusOutRadioButtonsLastStep(sender As Object, e As EventArgs) Handles pnLastStep4.Leave, pnLastStep3.Leave, pnLastStep2.Leave
        ctrl.RefreshTotal()
    End Sub

    Friend Sub ShowAlert(message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class