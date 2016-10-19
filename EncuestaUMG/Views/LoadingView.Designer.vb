<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingView))
        Me.CargandoProgress = New System.Windows.Forms.ProgressBar()
        Me.CargandoLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'CargandoProgress
        '
        Me.CargandoProgress.Location = New System.Drawing.Point(12, 171)
        Me.CargandoProgress.Name = "CargandoProgress"
        Me.CargandoProgress.Size = New System.Drawing.Size(572, 23)
        Me.CargandoProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CargandoProgress.TabIndex = 1
        '
        'CargandoLabel
        '
        Me.CargandoLabel.AutoSize = True
        Me.CargandoLabel.Location = New System.Drawing.Point(12, 148)
        Me.CargandoLabel.Name = "CargandoLabel"
        Me.CargandoLabel.Size = New System.Drawing.Size(79, 20)
        Me.CargandoLabel.TabIndex = 2
        Me.CargandoLabel.Text = "Cargando..."
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.EncuestaUMG.My.Resources.Resources.mini
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 146)
        Me.Panel1.TabIndex = 0
        '
        'LoadingView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(596, 206)
        Me.Controls.Add(Me.CargandoLabel)
        Me.Controls.Add(Me.CargandoProgress)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargando"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CargandoProgress As ProgressBar
    Friend WithEvents CargandoLabel As Label
End Class
