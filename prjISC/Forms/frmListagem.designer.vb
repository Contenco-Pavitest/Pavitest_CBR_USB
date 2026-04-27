<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListagem
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListagem))
        Me.dtgGrid = New System.Windows.Forms.DataGridView()
        Me.IdAmostra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QteCPs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bdnSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.btnCP = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.tsbMoverFirst = New System.Windows.Forms.ToolStripButton()
        Me.tsbMoverPrevious = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPosition = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbCount = New System.Windows.Forms.ToolStripLabel()
        Me.tsbSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMoverNext = New System.Windows.Forms.ToolStripButton()
        Me.tsbMoverLast = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbFind = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbFindItem = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsbFindTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbFindNome = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbFindData = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbFindQteCP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbFindOperador = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbFindObra = New System.Windows.Forms.ToolStripMenuItem()
        Me.bdnNavegator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsbClean = New System.Windows.Forms.ToolStripButton()
        Me.tsbFindCliente = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dtgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdnSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPanel.SuspendLayout()
        CType(Me.bdnNavegator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnNavegator.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgGrid
        '
        Me.dtgGrid.AllowUserToAddRows = False
        Me.dtgGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue
        Me.dtgGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgGrid.AutoGenerateColumns = False
        Me.dtgGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dtgGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtgGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAmostra, Me.Nome, Me.Obra, Me.Cliente, Me.Operador, Me.Data, Me.QteCPs})
        Me.dtgGrid.DataSource = Me.bdnSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.dtgGrid.EnableHeadersVisualStyles = False
        Me.dtgGrid.GridColor = System.Drawing.Color.Gainsboro
        Me.dtgGrid.Location = New System.Drawing.Point(12, 46)
        Me.dtgGrid.Name = "dtgGrid"
        Me.dtgGrid.ReadOnly = True
        Me.dtgGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtgGrid.RowHeadersVisible = False
        Me.dtgGrid.RowHeadersWidth = 20
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dtgGrid.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dtgGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgGrid.Size = New System.Drawing.Size(991, 497)
        Me.dtgGrid.TabIndex = 52
        '
        'IdAmostra
        '
        Me.IdAmostra.DataPropertyName = "IdAmostra"
        Me.IdAmostra.HeaderText = "IdAmostra"
        Me.IdAmostra.MinimumWidth = 6
        Me.IdAmostra.Name = "IdAmostra"
        Me.IdAmostra.ReadOnly = True
        Me.IdAmostra.Visible = False
        '
        'Nome
        '
        Me.Nome.DataPropertyName = "Nome"
        Me.Nome.FillWeight = 130.0!
        Me.Nome.HeaderText = "Nome da Amostra"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Obra
        '
        Me.Obra.DataPropertyName = "Obra"
        Me.Obra.FillWeight = 130.0!
        Me.Obra.HeaderText = "Obra"
        Me.Obra.MinimumWidth = 6
        Me.Obra.Name = "Obra"
        Me.Obra.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Operador
        '
        Me.Operador.DataPropertyName = "Operador"
        Me.Operador.FillWeight = 70.0!
        Me.Operador.HeaderText = "Operador"
        Me.Operador.MinimumWidth = 6
        Me.Operador.Name = "Operador"
        Me.Operador.ReadOnly = True
        '
        'Data
        '
        Me.Data.DataPropertyName = "Data"
        Me.Data.FillWeight = 60.0!
        Me.Data.HeaderText = "Data Amostra"
        Me.Data.MinimumWidth = 6
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'QteCPs
        '
        Me.QteCPs.DataPropertyName = "QteCPs"
        Me.QteCPs.FillWeight = 70.0!
        Me.QteCPs.HeaderText = "Quantidade de CPs"
        Me.QteCPs.MinimumWidth = 6
        Me.QteCPs.Name = "QteCPs"
        Me.QteCPs.ReadOnly = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(922, 603)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnCP)
        Me.pnlPanel.Controls.Add(Me.btnApagar)
        Me.pnlPanel.Controls.Add(Me.btnRelatorio)
        Me.pnlPanel.Controls.Add(Me.btnEditar)
        Me.pnlPanel.Controls.Add(Me.btnNovo)
        Me.pnlPanel.Location = New System.Drawing.Point(0, 563)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(1016, 34)
        Me.pnlPanel.TabIndex = 88
        '
        'btnCP
        '
        Me.btnCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCP.Image = CType(resources.GetObject("btnCP.Image"), System.Drawing.Image)
        Me.btnCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCP.Location = New System.Drawing.Point(921, 3)
        Me.btnCP.Name = "btnCP"
        Me.btnCP.Padding = New System.Windows.Forms.Padding(6, 0, 12, 0)
        Me.btnCP.Size = New System.Drawing.Size(81, 26)
        Me.btnCP.TabIndex = 89
        Me.btnCP.Text = "C.P.´s"
        Me.btnCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCP.UseVisualStyleBackColor = True
        '
        'btnApagar
        '
        Me.btnApagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApagar.Image = CType(resources.GetObject("btnApagar.Image"), System.Drawing.Image)
        Me.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApagar.Location = New System.Drawing.Point(749, 3)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnApagar.Size = New System.Drawing.Size(81, 26)
        Me.btnApagar.TabIndex = 2
        Me.btnApagar.Text = "&Apagar"
        Me.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.Image = CType(resources.GetObject("btnRelatorio.Image"), System.Drawing.Image)
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorio.Location = New System.Drawing.Point(575, 3)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnRelatorio.Size = New System.Drawing.Size(81, 26)
        Me.btnRelatorio.TabIndex = 0
        Me.btnRelatorio.Text = "&Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(835, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Padding = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.btnEditar.Size = New System.Drawing.Size(81, 26)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Amostra"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(662, 3)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Padding = New System.Windows.Forms.Padding(8, 0, 12, 0)
        Me.btnNovo.Size = New System.Drawing.Size(81, 26)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'tsbMoverFirst
        '
        Me.tsbMoverFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverFirst.Image = CType(resources.GetObject("tsbMoverFirst.Image"), System.Drawing.Image)
        Me.tsbMoverFirst.Name = "tsbMoverFirst"
        Me.tsbMoverFirst.RightToLeftAutoMirrorImage = True
        Me.tsbMoverFirst.Size = New System.Drawing.Size(24, 24)
        Me.tsbMoverFirst.Text = "Move first"
        '
        'tsbMoverPrevious
        '
        Me.tsbMoverPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverPrevious.Image = CType(resources.GetObject("tsbMoverPrevious.Image"), System.Drawing.Image)
        Me.tsbMoverPrevious.Name = "tsbMoverPrevious"
        Me.tsbMoverPrevious.RightToLeftAutoMirrorImage = True
        Me.tsbMoverPrevious.Size = New System.Drawing.Size(24, 24)
        Me.tsbMoverPrevious.Text = "Move previous"
        '
        'tsbSeparator1
        '
        Me.tsbSeparator1.Name = "tsbSeparator1"
        Me.tsbSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbPosition
        '
        Me.tsbPosition.AccessibleName = "Position"
        Me.tsbPosition.AutoSize = False
        Me.tsbPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsbPosition.Name = "tsbPosition"
        Me.tsbPosition.Size = New System.Drawing.Size(50, 23)
        Me.tsbPosition.Text = "0"
        Me.tsbPosition.ToolTipText = "Current position"
        '
        'tsbCount
        '
        Me.tsbCount.Name = "tsbCount"
        Me.tsbCount.Size = New System.Drawing.Size(37, 24)
        Me.tsbCount.Text = "de {0}"
        Me.tsbCount.ToolTipText = "Total number of items"
        '
        'tsbSeparator2
        '
        Me.tsbSeparator2.Name = "tsbSeparator2"
        Me.tsbSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbMoverNext
        '
        Me.tsbMoverNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverNext.Image = CType(resources.GetObject("tsbMoverNext.Image"), System.Drawing.Image)
        Me.tsbMoverNext.Name = "tsbMoverNext"
        Me.tsbMoverNext.RightToLeftAutoMirrorImage = True
        Me.tsbMoverNext.Size = New System.Drawing.Size(24, 24)
        Me.tsbMoverNext.Text = "Move next"
        '
        'tsbMoverLast
        '
        Me.tsbMoverLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverLast.Image = CType(resources.GetObject("tsbMoverLast.Image"), System.Drawing.Image)
        Me.tsbMoverLast.Name = "tsbMoverLast"
        Me.tsbMoverLast.RightToLeftAutoMirrorImage = True
        Me.tsbMoverLast.Size = New System.Drawing.Size(24, 24)
        Me.tsbMoverLast.Text = "Move last"
        '
        'tsbSeparator3
        '
        Me.tsbSeparator3.Name = "tsbSeparator3"
        Me.tsbSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.RightToLeftAutoMirrorImage = True
        Me.tsbAdd.Size = New System.Drawing.Size(24, 24)
        Me.tsbAdd.Text = "Add new"
        '
        'tsbDelete
        '
        Me.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.RightToLeftAutoMirrorImage = True
        Me.tsbDelete.Size = New System.Drawing.Size(24, 24)
        Me.tsbDelete.Text = "Delete"
        '
        'tsbSeparator4
        '
        Me.tsbSeparator4.Name = "tsbSeparator4"
        Me.tsbSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'tsbFind
        '
        Me.tsbFind.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsbFind.Margin = New System.Windows.Forms.Padding(3, 0, 1, 0)
        Me.tsbFind.Name = "tsbFind"
        Me.tsbFind.Size = New System.Drawing.Size(100, 27)
        '
        'tsbFindItem
        '
        Me.tsbFindItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFindItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFindTodos, Me.tsbFindNome, Me.tsbFindObra, Me.tsbFindCliente, Me.tsbFindOperador, Me.tsbFindData, Me.tsbFindQteCP})
        Me.tsbFindItem.Image = CType(resources.GetObject("tsbFindItem.Image"), System.Drawing.Image)
        Me.tsbFindItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFindItem.Name = "tsbFindItem"
        Me.tsbFindItem.Size = New System.Drawing.Size(36, 24)
        Me.tsbFindItem.Text = "Find"
        '
        'tsbFindTodos
        '
        Me.tsbFindTodos.Name = "tsbFindTodos"
        Me.tsbFindTodos.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindTodos.Text = "Todos"
        '
        'tsbFindNome
        '
        Me.tsbFindNome.Name = "tsbFindNome"
        Me.tsbFindNome.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindNome.Text = "Nome da Amostra"
        '
        'tsbFindData
        '
        Me.tsbFindData.Name = "tsbFindData"
        Me.tsbFindData.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindData.Text = "Data da Amostra"
        '
        'tsbFindQteCP
        '
        Me.tsbFindQteCP.Name = "tsbFindQteCP"
        Me.tsbFindQteCP.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindQteCP.Text = "Qte de CP´s"
        '
        'tsbFindOperador
        '
        Me.tsbFindOperador.Name = "tsbFindOperador"
        Me.tsbFindOperador.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindOperador.Text = "Operador"
        '
        'tsbFindObra
        '
        Me.tsbFindObra.Name = "tsbFindObra"
        Me.tsbFindObra.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindObra.Text = "Obra"
        '
        'bdnNavegator
        '
        Me.bdnNavegator.AddNewItem = Nothing
        Me.bdnNavegator.BindingSource = Me.bdnSource
        Me.bdnNavegator.CountItem = Me.tsbCount
        Me.bdnNavegator.DeleteItem = Nothing
        Me.bdnNavegator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.bdnNavegator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbMoverFirst, Me.tsbMoverPrevious, Me.tsbSeparator1, Me.tsbPosition, Me.tsbCount, Me.tsbSeparator2, Me.tsbMoverNext, Me.tsbMoverLast, Me.tsbSeparator3, Me.tsbAdd, Me.tsbDelete, Me.tsbSeparator4, Me.tsbFind, Me.tsbFindItem, Me.tsbClean})
        Me.bdnNavegator.Location = New System.Drawing.Point(0, 0)
        Me.bdnNavegator.MoveFirstItem = Me.tsbMoverFirst
        Me.bdnNavegator.MoveLastItem = Me.tsbMoverLast
        Me.bdnNavegator.MoveNextItem = Me.tsbMoverNext
        Me.bdnNavegator.MovePreviousItem = Me.tsbMoverPrevious
        Me.bdnNavegator.Name = "bdnNavegator"
        Me.bdnNavegator.PositionItem = Me.tsbPosition
        Me.bdnNavegator.Size = New System.Drawing.Size(1015, 27)
        Me.bdnNavegator.TabIndex = 54
        '
        'tsbClean
        '
        Me.tsbClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbClean.Image = CType(resources.GetObject("tsbClean.Image"), System.Drawing.Image)
        Me.tsbClean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClean.Name = "tsbClean"
        Me.tsbClean.Size = New System.Drawing.Size(24, 24)
        Me.tsbClean.Text = "Limpar Pesquisa"
        Me.tsbClean.Visible = False
        '
        'tsbFindCliente
        '
        Me.tsbFindCliente.Name = "tsbFindCliente"
        Me.tsbFindCliente.Size = New System.Drawing.Size(180, 22)
        Me.tsbFindCliente.Text = "Cliente"
        '
        'frmListagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(1015, 634)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.bdnNavegator)
        Me.Controls.Add(Me.dtgGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListagem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amostras para ensaio"
        CType(Me.dtgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdnSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPanel.ResumeLayout(False)
        CType(Me.bdnNavegator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnNavegator.ResumeLayout(False)
        Me.bdnNavegator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents btnApagar As System.Windows.Forms.Button
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents tsbMoverFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMoverPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPosition As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbMoverNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMoverLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbFindItem As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsbFindNome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbFindData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbFindQteCP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bdnNavegator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bdnSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnCP As System.Windows.Forms.Button
    Friend WithEvents tsbFindTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbClean As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbFindOperador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbFindObra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdAmostra As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Obra As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Operador As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents QteCPs As DataGridViewTextBoxColumn
    Friend WithEvents tsbFindCliente As ToolStripMenuItem
End Class
