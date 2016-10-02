<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarrerasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JornadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraficaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WelcomeLbl = New System.Windows.Forms.Label()
        Me.btnResponder = New System.Windows.Forms.Button()
        Me.MessageLbl = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocentesToolStripMenuItem, Me.CarrerasToolStripMenuItem, Me.CursosToolStripMenuItem, Me.JornadaToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_share
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(8, 0, 4, 0)
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_supervisor_account
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'CarrerasToolStripMenuItem
        '
        Me.CarrerasToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_school
        Me.CarrerasToolStripMenuItem.Name = "CarrerasToolStripMenuItem"
        Me.CarrerasToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CarrerasToolStripMenuItem.Text = "Carreras"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_library_books
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'JornadaToolStripMenuItem
        '
        Me.JornadaToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_shop
        Me.JornadaToolStripMenuItem.Name = "JornadaToolStripMenuItem"
        Me.JornadaToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.JornadaToolStripMenuItem.Text = "Jornadas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraficaToolStripMenuItem, Me.ExportarArchivoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_card_membership
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'GraficaToolStripMenuItem
        '
        Me.GraficaToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_pie_chart_outlined
        Me.GraficaToolStripMenuItem.Name = "GraficaToolStripMenuItem"
        Me.GraficaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GraficaToolStripMenuItem.Text = "Grafica"
        '
        'ExportarArchivoToolStripMenuItem
        '
        Me.ExportarArchivoToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_insert_photo
        Me.ExportarArchivoToolStripMenuItem.Name = "ExportarArchivoToolStripMenuItem"
        Me.ExportarArchivoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExportarArchivoToolStripMenuItem.Text = "Exportar Archivo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_supervisor_account1
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.EncuestaUMG.My.Resources.Resources.ic_text_fields
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'WelcomeLbl
        '
        Me.WelcomeLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeLbl.AutoEllipsis = True
        Me.WelcomeLbl.Font = New System.Drawing.Font("Arial Narrow", 26.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLbl.ForeColor = System.Drawing.Color.White
        Me.WelcomeLbl.Location = New System.Drawing.Point(12, 70)
        Me.WelcomeLbl.Name = "WelcomeLbl"
        Me.WelcomeLbl.Size = New System.Drawing.Size(760, 79)
        Me.WelcomeLbl.TabIndex = 4
        Me.WelcomeLbl.Text = "Bienvenido a EncuestaUMG"
        Me.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnResponder
        '
        Me.btnResponder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResponder.FlatAppearance.BorderSize = 2
        Me.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResponder.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResponder.ForeColor = System.Drawing.Color.White
        Me.btnResponder.Location = New System.Drawing.Point(311, 495)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(144, 45)
        Me.btnResponder.TabIndex = 6
        Me.btnResponder.Text = "¡Responder!"
        Me.btnResponder.UseVisualStyleBackColor = True
        '
        'MessageLbl
        '
        Me.MessageLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageLbl.AutoEllipsis = True
        Me.MessageLbl.Font = New System.Drawing.Font("Arial Narrow", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLbl.ForeColor = System.Drawing.Color.White
        Me.MessageLbl.Location = New System.Drawing.Point(127, 195)
        Me.MessageLbl.Name = "MessageLbl"
        Me.MessageLbl.Size = New System.Drawing.Size(571, 93)
        Me.MessageLbl.TabIndex = 5
        Me.MessageLbl.Text = "En esta aplicación podrás evaluar a tus catedráticos de forma agil y eficiente, u" &
    "nicamente debes de ingresar tu numero de carnet y listo, responde la encuesta"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Reporte"
        Me.SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(784, 611)
        Me.Controls.Add(Me.WelcomeLbl)
        Me.Controls.Add(Me.btnResponder)
        Me.Controls.Add(Me.MessageLbl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 650)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EncuestaUMG"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarrerasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GraficaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JornadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WelcomeLbl As Label
    Friend WithEvents btnResponder As Button
    Friend WithEvents MessageLbl As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
