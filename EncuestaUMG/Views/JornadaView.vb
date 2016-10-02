Public Class JornadaView
    Private Sub JornadaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JornadaBindingNavigatorSaveItem.Click, JornadaBindingNavigatorSaveItem.Click, JornadaBindingNavigatorSaveItem.Click, JornadaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JornadaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EncuestaUMGdbDataSet)

    End Sub

    Private Sub Jornada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EncuestaUMGdbDataSet.Jornada' table. You can move, or remove it, as needed.
        Me.JornadaTableAdapter.Fill(Me.EncuestaUMGdbDataSet.Jornada)

    End Sub

End Class