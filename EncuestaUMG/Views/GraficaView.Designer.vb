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
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.cbGJornada = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbGCarrera = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtGFecha = New System.Windows.Forms.DateTimePicker()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.gpFiltrosGrafica.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpFiltrosGrafica
        '
        Me.gpFiltrosGrafica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpFiltrosGrafica.Controls.Add(Me.btnGenerar)
        Me.gpFiltrosGrafica.Controls.Add(Me.cbGJornada)
        Me.gpFiltrosGrafica.Controls.Add(Me.Label3)
        Me.gpFiltrosGrafica.Controls.Add(Me.cbGCarrera)
        Me.gpFiltrosGrafica.Controls.Add(Me.Label2)
        Me.gpFiltrosGrafica.Controls.Add(Me.dtGFecha)
        Me.gpFiltrosGrafica.Controls.Add(Me.lbFecha)
        Me.gpFiltrosGrafica.Location = New System.Drawing.Point(16, 13)
        Me.gpFiltrosGrafica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpFiltrosGrafica.Name = "gpFiltrosGrafica"
        Me.gpFiltrosGrafica.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gpFiltrosGrafica.Size = New System.Drawing.Size(752, 145)
        Me.gpFiltrosGrafica.TabIndex = 0
        Me.gpFiltrosGrafica.TabStop = False
        Me.gpFiltrosGrafica.Text = "Filtros"
        '
        'btnGenerar
        '
        Me.btnGenerar.AutoEllipsis = True
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGenerar.FlatAppearance.BorderSize = 2
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.ForeColor = System.Drawing.Color.White
        Me.btnGenerar.Location = New System.Drawing.Point(309, 100)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(170, 30)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'cbGJornada
        '
        Me.cbGJornada.FormattingEnabled = True
        Me.cbGJornada.Location = New System.Drawing.Point(561, 23)
        Me.cbGJornada.Name = "cbGJornada"
        Me.cbGJornada.Size = New System.Drawing.Size(174, 28)
        Me.cbGJornada.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jornada:"
        '
        'cbGCarrera
        '
        Me.cbGCarrera.FormattingEnabled = True
        Me.cbGCarrera.Location = New System.Drawing.Point(309, 23)
        Me.cbGCarrera.Name = "cbGCarrera"
        Me.cbGCarrera.Size = New System.Drawing.Size(170, 28)
        Me.cbGCarrera.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Carrera:"
        '
        'dtGFecha
        '
        Me.dtGFecha.Location = New System.Drawing.Point(71, 26)
        Me.dtGFecha.Name = "dtGFecha"
        Me.dtGFecha.Size = New System.Drawing.Size(169, 26)
        Me.dtGFecha.TabIndex = 0
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(15, 31)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(50, 20)
        Me.lbFecha.TabIndex = 0
        Me.lbFecha.Text = "Fecha:"
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
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
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
        Me.Chart1.Size = New System.Drawing.Size(756, 422)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Grafica"
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
        Me.gpFiltrosGrafica.PerformLayout()
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
End Class
