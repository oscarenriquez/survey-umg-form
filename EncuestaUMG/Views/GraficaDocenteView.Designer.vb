<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraficaDocenteView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraficaDocenteView))
        Me.gpFiltrosGrafica = New System.Windows.Forms.GroupBox()
        Me.tableFiltros = New System.Windows.Forms.TableLayoutPanel()
        Me.dtGFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGJornada = New System.Windows.Forms.ComboBox()
        Me.cbGCarrera = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbRango = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.gpFiltrosGrafica.SuspendLayout()
        Me.tableFiltros.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpFiltrosGrafica
        '
        Me.gpFiltrosGrafica.Controls.Add(Me.btnExport)
        Me.gpFiltrosGrafica.Controls.Add(Me.tableFiltros)
        Me.gpFiltrosGrafica.Controls.Add(Me.btnGenerar)
        Me.gpFiltrosGrafica.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpFiltrosGrafica.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpFiltrosGrafica.Location = New System.Drawing.Point(0, 0)
        Me.gpFiltrosGrafica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpFiltrosGrafica.Name = "gpFiltrosGrafica"
        Me.gpFiltrosGrafica.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpFiltrosGrafica.Size = New System.Drawing.Size(784, 145)
        Me.gpFiltrosGrafica.TabIndex = 1
        Me.gpFiltrosGrafica.TabStop = False
        Me.gpFiltrosGrafica.Text = "Filtros"
        '
        'tableFiltros
        '
        Me.tableFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableFiltros.ColumnCount = 8
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableFiltros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tableFiltros.Controls.Add(Me.dtGFecha, 1, 0)
        Me.tableFiltros.Controls.Add(Me.Label2, 2, 0)
        Me.tableFiltros.Controls.Add(Me.cbGJornada, 5, 0)
        Me.tableFiltros.Controls.Add(Me.cbGCarrera, 3, 0)
        Me.tableFiltros.Controls.Add(Me.Label3, 4, 0)
        Me.tableFiltros.Controls.Add(Me.lbFecha, 0, 0)
        Me.tableFiltros.Controls.Add(Me.Label1, 6, 0)
        Me.tableFiltros.Controls.Add(Me.cbRango, 7, 0)
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
        Me.dtGFecha.Location = New System.Drawing.Point(80, 22)
        Me.dtGFecha.Name = "dtGFecha"
        Me.dtGFecha.Size = New System.Drawing.Size(109, 26)
        Me.dtGFecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(195, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 71)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carrera:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGJornada
        '
        Me.cbGJornada.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGJornada.FormattingEnabled = True
        Me.cbGJornada.Location = New System.Drawing.Point(464, 25)
        Me.cbGJornada.Name = "cbGJornada"
        Me.cbGJornada.Size = New System.Drawing.Size(109, 28)
        Me.cbGJornada.TabIndex = 2
        '
        'cbGCarrera
        '
        Me.cbGCarrera.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbGCarrera.FormattingEnabled = True
        Me.cbGCarrera.Location = New System.Drawing.Point(272, 25)
        Me.cbGCarrera.Name = "cbGCarrera"
        Me.cbGCarrera.Size = New System.Drawing.Size(109, 28)
        Me.cbGCarrera.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(387, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 71)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jornada:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbFecha
        '
        Me.lbFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbFecha.Location = New System.Drawing.Point(3, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(71, 71)
        Me.lbFecha.TabIndex = 0
        Me.lbFecha.Text = "Fecha:"
        Me.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(579, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 71)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rango:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbRango
        '
        Me.cbRango.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRango.FormattingEnabled = True
        Me.cbRango.Location = New System.Drawing.Point(656, 21)
        Me.cbRango.Name = "cbRango"
        Me.cbRango.Size = New System.Drawing.Size(113, 28)
        Me.cbRango.TabIndex = 3
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
        Me.btnGenerar.Location = New System.Drawing.Point(589, 108)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(189, 30)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea1.AxisY.Title = "Puntuación"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 152)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Promedio"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(772, 447)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "ChartDocente.jpg"
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
        Me.btnExport.Location = New System.Drawing.Point(6, 108)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(189, 30)
        Me.btnExport.TabIndex = 1
        Me.btnExport.Text = "Exportar"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'GraficaDocenteView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(784, 611)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.gpFiltrosGrafica)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GraficaDocenteView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grafica Docente"
        Me.gpFiltrosGrafica.ResumeLayout(False)
        Me.tableFiltros.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpFiltrosGrafica As GroupBox
    Friend WithEvents tableFiltros As TableLayoutPanel
    Friend WithEvents dtGFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cbGJornada As ComboBox
    Friend WithEvents cbGCarrera As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents cbRango As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnExport As Button
End Class
