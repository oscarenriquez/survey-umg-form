Public Class LoadingView

    Friend Sub ChangeValues()
        If CargandoProgress.Value < 100 Then
            CargandoProgress.Value = CargandoProgress.Value + 1
            CargandoLabel.Text = "Cargando " & CargandoProgress.Value & " de 100 "
        End If
    End Sub

End Class