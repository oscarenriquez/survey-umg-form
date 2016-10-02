Imports EncuestaUMG

Public Class MainController

    Private encuestaADO As EncuestaADO

    Private view As Form1

    Public Sub New(form1 As Form1)
        encuestaADO = EncuestaADO.GetInstance
        Me.view = form1
    End Sub

    Public Sub GenerateReport()
        view.SaveFileDialog1.ShowDialog()
        ' If the file name is not an empty string open it for saving.
        If view.SaveFileDialog1.FileName <> "" Then
            Dim listaData As List(Of String) = encuestaADO.GetAllData

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(view.SaveFileDialog1.FileName, True)
            For Each linea In listaData
                file.WriteLine(linea)
            Next
            file.Close()
        End If
    End Sub
End Class
