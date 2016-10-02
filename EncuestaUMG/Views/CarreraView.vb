Public Class CarreraView
    Private Sub CarreraBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CarreraBindingNavigatorSaveItem.Click, CarreraBindingNavigatorSaveItem.Click, CarreraBindingNavigatorSaveItem.Click, CarreraBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarreraBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EncuestaUMGdbDataSet)

    End Sub

    Private Sub Carrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CarreraTableAdapter.Fill(Me.EncuestaUMGdbDataSet.Carrera)

    End Sub
End Class