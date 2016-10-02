Public Class DocenteView
    Private Sub DocenteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DocenteBindingNavigatorSaveItem.Click, DocenteBindingNavigatorSaveItem.Click, DocenteBindingNavigatorSaveItem.Click, DocenteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DocenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EncuestaUMGdbDataSet)

    End Sub

    Private Sub Docente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EncuestaUMGdbDataSet.Docente' table. You can move, or remove it, as needed.
        Me.DocenteTableAdapter.Fill(Me.EncuestaUMGdbDataSet.Docente)

    End Sub
End Class