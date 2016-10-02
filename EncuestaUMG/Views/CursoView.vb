Public Class CursoView
    Private Sub CursoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CursoBindingNavigatorSaveItem.Click, CursoBindingNavigatorSaveItem.Click, CursoBindingNavigatorSaveItem.Click, CursoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CursoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EncuestaUMGdbDataSet)

    End Sub

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EncuestaUMGdbDataSet.Curso' table. You can move, or remove it, as needed.
        Me.CursoTableAdapter.Fill(Me.EncuestaUMGdbDataSet.Curso)

    End Sub
End Class