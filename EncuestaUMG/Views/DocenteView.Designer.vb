<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocenteView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocenteView))
        Me.EncuestaUMGdbDataSet = New EncuestaUMG.EncuestaUMGdbDataSet()
        Me.DocenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DocenteTableAdapter = New EncuestaUMG.EncuestaUMGdbDataSetTableAdapters.DocenteTableAdapter()
        Me.TableAdapterManager = New EncuestaUMG.EncuestaUMGdbDataSetTableAdapters.TableAdapterManager()
        Me.DocenteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DocenteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DocenteDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.EncuestaUMGdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocenteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocenteBindingNavigator.SuspendLayout()
        CType(Me.DocenteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EncuestaUMGdbDataSet
        '
        Me.EncuestaUMGdbDataSet.DataSetName = "EncuestaUMGdbDataSet"
        Me.EncuestaUMGdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocenteBindingSource
        '
        Me.DocenteBindingSource.DataMember = "Docente"
        Me.DocenteBindingSource.DataSource = Me.EncuestaUMGdbDataSet
        '
        'DocenteTableAdapter
        '
        Me.DocenteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CarreraTableAdapter = Nothing
        Me.TableAdapterManager.CursoTableAdapter = Nothing
        Me.TableAdapterManager.DocenteTableAdapter = Me.DocenteTableAdapter
        Me.TableAdapterManager.EncuestaTableAdapter = Nothing
        Me.TableAdapterManager.JornadaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EncuestaUMG.EncuestaUMGdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DocenteBindingNavigator
        '
        Me.DocenteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DocenteBindingNavigator.BindingSource = Me.DocenteBindingSource
        Me.DocenteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DocenteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DocenteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DocenteBindingNavigatorSaveItem})
        Me.DocenteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DocenteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DocenteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DocenteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DocenteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DocenteBindingNavigator.Name = "DocenteBindingNavigator"
        Me.DocenteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DocenteBindingNavigator.Size = New System.Drawing.Size(386, 25)
        Me.DocenteBindingNavigator.TabIndex = 0
        Me.DocenteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DocenteBindingNavigatorSaveItem
        '
        Me.DocenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DocenteBindingNavigatorSaveItem.Image = CType(resources.GetObject("DocenteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DocenteBindingNavigatorSaveItem.Name = "DocenteBindingNavigatorSaveItem"
        Me.DocenteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DocenteBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DocenteDataGridView
        '
        Me.DocenteDataGridView.AutoGenerateColumns = False
        Me.DocenteDataGridView.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.DocenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocenteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn})
        Me.DocenteDataGridView.DataSource = Me.DocenteBindingSource
        Me.DocenteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocenteDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.DocenteDataGridView.Name = "DocenteDataGridView"
        Me.DocenteDataGridView.Size = New System.Drawing.Size(386, 276)
        Me.DocenteDataGridView.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'DocenteView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 301)
        Me.Controls.Add(Me.DocenteDataGridView)
        Me.Controls.Add(Me.DocenteBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DocenteView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Docente"
        CType(Me.EncuestaUMGdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocenteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocenteBindingNavigator.ResumeLayout(False)
        Me.DocenteBindingNavigator.PerformLayout()
        CType(Me.DocenteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EncuestaUMGdbDataSet As EncuestaUMGdbDataSet
    Friend WithEvents DocenteBindingSource As BindingSource
    Friend WithEvents DocenteTableAdapter As EncuestaUMGdbDataSetTableAdapters.DocenteTableAdapter
    Friend WithEvents TableAdapterManager As EncuestaUMGdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DocenteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DocenteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DocenteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
