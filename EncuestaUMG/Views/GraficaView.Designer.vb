<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraficaView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraficaView))
        Me.gpFiltrosGrafica = New System.Windows.Forms.GroupBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.tableFiltros = New System.Windows.Forms.TableLayoutPanel()
        Me.dtGFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGJornada = New System.Windows.Forms.ComboBox()
        Me.cbGCarrera = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gpFiltrosGrafica.SuspendLayout()
        Me.tableFiltros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpFiltrosGrafica
        '
        Me.gpFiltrosGrafica.Controls.Add(Me.btnExport)
        Me.gpFiltrosGrafica.Controls.Add(Me.tableFiltros)
        Me.gpFiltrosGrafica.Controls.Add(Me.btnGenerar)
        Me.gpFiltrosGrafica.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpFiltrosGrafica.Location = New System.Drawing.Point(0, 0)
        Me.gpFiltrosGrafica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpFiltrosGrafica.Name = "gpFiltrosGrafica"
        Me.gpFiltrosGrafica.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpFiltrosGrafica.Size = New System.Drawing.Size(784, 145)
        Me.gpFiltrosGrafica.TabIndex = 0
        Me.gpFiltrosGrafica.TabStop = False
        Me.gpFiltrosGrafica.Text = "Filtros"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.LimeGreen
        Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExport.FlatAppearance.BorderSize = 2
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Image = Global.EncuestaUMG.My.Resources.Resources.ic_photo_library_white
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExport.Location = New System.Drawing.Point(12, 108)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(154, 30)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'tableFiltros
        '
        Me.tableFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableFiltros.ColumnCount = 6
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333!))
        Me.tableFiltros.Controls.Add(Me.dtGFecha, 1, 0)
        Me.tableFiltros.Controls.Add(Me.Label2, 2, 0)
        Me.tableFiltros.Controls.Add(Me.cbGJornada, 5, 0)
        Me.tableFiltros.Controls.Add(Me.cbGCarrera, 3, 0)
        Me.tableFiltros.Controls.Add(Me.Label3, 4, 0)
        Me.tableFiltros.Controls.Add(Me.lbFecha, 0, 0)
        Me.tableFiltros.Location = New System.Drawing.Point(6, 23)
        Me.tableFiltros.Name = "tableFiltros"
        Me.tableFiltros.RowCount = 1
        Me.tableFiltros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableFiltros.Size = New System.Drawing.Size(772, 71)
        Me.tableFiltros.TabIndex = 5
        '
        'dtGFecha
        '
        Me.dtGFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtGFecha.Location = New System.Drawing.Point(99, 22)
        Me.dtGFecha.Name = "dtGFecha"
        Me.dtGFecha.Size = New System.Drawing.Size(154, 26)
        Me.dtGFecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(259, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 71)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carrera:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGJornada
        '
        Me.cbGJornada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGJornada.FormattingEnabled = True
        Me.cbGJornada.Location = New System.Drawing.Point(611, 25)
        Me.cbGJornada.Name = "cbGJornada"
        Me.cbGJornada.Size = New System.Drawing.Size(158, 28)
        Me.cbGJornada.TabIndex = 2
        '
        'cbGCarrera
        '
        Me.cbGCarrera.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGCarrera.FormattingEnabled = True
        Me.cbGCarrera.Location = New System.Drawing.Point(355, 25)
        Me.cbGCarrera.Name = "cbGCarrera"
        Me.cbGCarrera.Size = New System.Drawing.Size(154, 28)
        Me.cbGCarrera.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(515, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 71)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jornada:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFecha
        '
        Me.lbFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbFecha.Location = New System.Drawing.Point(3, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(90, 71)
        Me.lbFecha.TabIndex = 0
        Me.lbFecha.Text = "Fecha:"
        Me.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.AutoEllipsis = True
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGenerar.FlatAppearance.BorderSize = 2
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Image = Global.EncuestaUMG.My.Resources.Resources.ic_pie_chart_outlined_white
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerar.Location = New System.Drawing.Point(617, 108)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(161, 30)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Location = New System.Drawing.Point(12, 177)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 422)
        Me.Panel1.TabIndex = 1
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "RESULTADOS"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, -13)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "RESULTADOS"
        Series1.Name = "EX"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "RESULTADOS"
        Series2.Name = "MB"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "RESULTADOS"
        Series3.Name = "B"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "RESULTADOS"
        Series4.Name = "NM"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(756, 435)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Grafica"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "ChartCurso.jpg"
        '
        'GraficaView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(784, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpFiltrosGrafica)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GraficaView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grafica"
        Me.gpFiltrosGrafica.ResumeLayout(False)
        Me.tableFiltros.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpFiltrosGrafica As GroupBox
    Friend WithEvents cbGJornada As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbGCarrera As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtGFecha As DateTimePicker
    Friend WithEvents lbFecha As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnGenerar As Button
    Friend WithEvents tableFiltros As TableLayoutPanel
    Friend WithEvents btnExport As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
