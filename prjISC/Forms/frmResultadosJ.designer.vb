<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultadosJ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultadosJ))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"lstView"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Info, Nothing)
        Me.grpGroup3 = New System.Windows.Forms.GroupBox()
        Me.chkLegenda = New System.Windows.Forms.CheckBox()
        Me.grpGroup1 = New System.Windows.Forms.GroupBox()
        Me.chkSelecionar = New System.Windows.Forms.CheckBox()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.lstView = New System.Windows.Forms.ListView()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuArquivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRever = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAtualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRelatorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExibir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRotacionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu45 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsBarraFerramenta = New System.Windows.Forms.ToolStrip()
        Me.tlsAtualizar = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsSair = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpGroupEscala = New System.Windows.Forms.GroupBox()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.strkBarraY = New System.Windows.Forms.TrackBar()
        Me.strkBarraX = New System.Windows.Forms.TrackBar()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabMassaSeca = New System.Windows.Forms.TabPage()
        Me.GraficoResultados1 = New ChartDirector.WinChartViewer()
        Me.tabExpansaoUmidade = New System.Windows.Forms.TabPage()
        Me.GraficoResultados2 = New ChartDirector.WinChartViewer()
        Me.tabIscUmidade = New System.Windows.Forms.TabPage()
        Me.GraficoResultados3 = New ChartDirector.WinChartViewer()
        Me.MultiplasListas = New System.Windows.Forms.TabPage()
        Me.graficoResultados4 = New ChartDirector.WinChartViewer()
        Me.grpGroup3.SuspendLayout()
        Me.grpGroup1.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        Me.tlsBarraFerramenta.SuspendLayout()
        Me.grpGroupEscala.SuspendLayout()
        CType(Me.strkBarraY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.strkBarraX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabMassaSeca.SuspendLayout()
        CType(Me.GraficoResultados1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabExpansaoUmidade.SuspendLayout()
        CType(Me.GraficoResultados2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabIscUmidade.SuspendLayout()
        CType(Me.GraficoResultados3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MultiplasListas.SuspendLayout()
        CType(Me.graficoResultados4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGroup3
        '
        Me.grpGroup3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGroup3.Controls.Add(Me.chkLegenda)
        Me.grpGroup3.ForeColor = System.Drawing.Color.Black
        Me.grpGroup3.Location = New System.Drawing.Point(828, 431)
        Me.grpGroup3.Name = "grpGroup3"
        Me.grpGroup3.Size = New System.Drawing.Size(212, 54)
        Me.grpGroup3.TabIndex = 15
        Me.grpGroup3.TabStop = False
        Me.grpGroup3.Text = "Legenda"
        '
        'chkLegenda
        '
        Me.chkLegenda.AutoSize = True
        Me.chkLegenda.Location = New System.Drawing.Point(31, 26)
        Me.chkLegenda.Name = "chkLegenda"
        Me.chkLegenda.Size = New System.Drawing.Size(158, 17)
        Me.chkLegenda.TabIndex = 2
        Me.chkLegenda.Text = "Mostrar Legenda do Gráfico"
        Me.chkLegenda.UseVisualStyleBackColor = True
        '
        'grpGroup1
        '
        Me.grpGroup1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGroup1.Controls.Add(Me.chkSelecionar)
        Me.grpGroup1.Controls.Add(Me.btnAtualizar)
        Me.grpGroup1.Controls.Add(Me.lstView)
        Me.grpGroup1.Controls.Add(Me.lblLabel1)
        Me.grpGroup1.ForeColor = System.Drawing.Color.Black
        Me.grpGroup1.Location = New System.Drawing.Point(828, 73)
        Me.grpGroup1.Name = "grpGroup1"
        Me.grpGroup1.Size = New System.Drawing.Size(212, 352)
        Me.grpGroup1.TabIndex = 17
        Me.grpGroup1.TabStop = False
        Me.grpGroup1.Text = "Listagem dos ensaios realizados"
        '
        'chkSelecionar
        '
        Me.chkSelecionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSelecionar.AutoSize = True
        Me.chkSelecionar.Location = New System.Drawing.Point(52, 290)
        Me.chkSelecionar.Name = "chkSelecionar"
        Me.chkSelecionar.Size = New System.Drawing.Size(100, 17)
        Me.chkSelecionar.TabIndex = 3
        Me.chkSelecionar.Text = "Selecionar tudo"
        Me.chkSelecionar.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Image = CType(resources.GetObject("btnAtualizar.Image"), System.Drawing.Image)
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizar.Location = New System.Drawing.Point(67, 313)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnAtualizar.Size = New System.Drawing.Size(81, 26)
        Me.btnAtualizar.TabIndex = 1
        Me.btnAtualizar.Text = "&Atualizar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lstView
        '
        Me.lstView.BackColor = System.Drawing.SystemColors.Info
        Me.lstView.CheckBoxes = True
        Me.lstView.ForeColor = System.Drawing.Color.MediumBlue
        Me.lstView.HideSelection = False
        ListViewItem1.Checked = True
        ListViewItem1.StateImageIndex = 1
        Me.lstView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lstView.Location = New System.Drawing.Point(24, 72)
        Me.lstView.Name = "lstView"
        Me.lstView.Size = New System.Drawing.Size(178, 212)
        Me.lstView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstView.TabIndex = 0
        Me.lstView.UseCompatibleStateImageBehavior = False
        Me.lstView.View = System.Windows.Forms.View.List
        '
        'lblLabel1
        '
        Me.lblLabel1.Location = New System.Drawing.Point(22, 18)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(182, 52)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "Selecionar os ensaios que deseja rever e clicar no comando 'Atualizar'."
        Me.lblLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArquivo, Me.mnuRever, Me.mnuExibir})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(1052, 24)
        Me.mnuMenu.TabIndex = 18
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuArquivo
        '
        Me.mnuArquivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSair})
        Me.mnuArquivo.Name = "mnuArquivo"
        Me.mnuArquivo.Size = New System.Drawing.Size(61, 20)
        Me.mnuArquivo.Text = "&Arquivo"
        '
        'mnuSair
        '
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSair.Size = New System.Drawing.Size(133, 22)
        Me.mnuSair.Text = "Sair"
        '
        'mnuRever
        '
        Me.mnuRever.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAtualizar, Me.mnuRelatorio})
        Me.mnuRever.Name = "mnuRever"
        Me.mnuRever.Size = New System.Drawing.Size(48, 20)
        Me.mnuRever.Text = "&Rever"
        '
        'mnuAtualizar
        '
        Me.mnuAtualizar.Name = "mnuAtualizar"
        Me.mnuAtualizar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuAtualizar.Size = New System.Drawing.Size(204, 22)
        Me.mnuAtualizar.Text = "Atualizar Revisão"
        '
        'mnuRelatorio
        '
        Me.mnuRelatorio.Name = "mnuRelatorio"
        Me.mnuRelatorio.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRelatorio.Size = New System.Drawing.Size(204, 22)
        Me.mnuRelatorio.Text = "Relatório"
        '
        'mnuExibir
        '
        Me.mnuExibir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRotacionar})
        Me.mnuExibir.Name = "mnuExibir"
        Me.mnuExibir.Size = New System.Drawing.Size(47, 20)
        Me.mnuExibir.Text = "&Exibir"
        '
        'mnuRotacionar
        '
        Me.mnuRotacionar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu0, Me.mnu15, Me.mnu30, Me.mnu45})
        Me.mnuRotacionar.Name = "mnuRotacionar"
        Me.mnuRotacionar.Size = New System.Drawing.Size(131, 22)
        Me.mnuRotacionar.Text = "Rotacionar"
        '
        'mnu0
        '
        Me.mnu0.Checked = True
        Me.mnu0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnu0.Name = "mnu0"
        Me.mnu0.Size = New System.Drawing.Size(91, 22)
        Me.mnu0.Text = "0°"
        '
        'mnu15
        '
        Me.mnu15.Name = "mnu15"
        Me.mnu15.Size = New System.Drawing.Size(91, 22)
        Me.mnu15.Text = "15°"
        '
        'mnu30
        '
        Me.mnu30.Name = "mnu30"
        Me.mnu30.Size = New System.Drawing.Size(91, 22)
        Me.mnu30.Text = "30°"
        '
        'mnu45
        '
        Me.mnu45.Name = "mnu45"
        Me.mnu45.Size = New System.Drawing.Size(91, 22)
        Me.mnu45.Text = "45°"
        '
        'tlsBarraFerramenta
        '
        Me.tlsBarraFerramenta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsAtualizar, Me.tlsSeparator1, Me.tlsImprimir, Me.tlsSeparator2, Me.tlsSair, Me.tlsSeparator3})
        Me.tlsBarraFerramenta.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarraFerramenta.Name = "tlsBarraFerramenta"
        Me.tlsBarraFerramenta.Size = New System.Drawing.Size(1052, 25)
        Me.tlsBarraFerramenta.TabIndex = 19
        Me.tlsBarraFerramenta.Text = "ToolStrip1"
        '
        'tlsAtualizar
        '
        Me.tlsAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsAtualizar.Image = CType(resources.GetObject("tlsAtualizar.Image"), System.Drawing.Image)
        Me.tlsAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsAtualizar.Name = "tlsAtualizar"
        Me.tlsAtualizar.Size = New System.Drawing.Size(23, 22)
        Me.tlsAtualizar.Text = "Atualizar Visualização"
        '
        'tlsSeparator1
        '
        Me.tlsSeparator1.Name = "tlsSeparator1"
        Me.tlsSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlsImprimir
        '
        Me.tlsImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsImprimir.Image = CType(resources.GetObject("tlsImprimir.Image"), System.Drawing.Image)
        Me.tlsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsImprimir.Name = "tlsImprimir"
        Me.tlsImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tlsImprimir.Text = "Imprimir Relatório"
        '
        'tlsSeparator2
        '
        Me.tlsSeparator2.Name = "tlsSeparator2"
        Me.tlsSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlsSair
        '
        Me.tlsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsSair.Image = CType(resources.GetObject("tlsSair.Image"), System.Drawing.Image)
        Me.tlsSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsSair.Name = "tlsSair"
        Me.tlsSair.Size = New System.Drawing.Size(23, 22)
        Me.tlsSair.Text = "Sair da janela"
        '
        'tlsSeparator3
        '
        Me.tlsSeparator3.Name = "tlsSeparator3"
        Me.tlsSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.Image = CType(resources.GetObject("btnRelatorio.Image"), System.Drawing.Image)
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorio.Location = New System.Drawing.Point(860, 3)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnRelatorio.Size = New System.Drawing.Size(81, 26)
        Me.btnRelatorio.TabIndex = 5
        Me.btnRelatorio.Text = "&Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(963, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpGroupEscala
        '
        Me.grpGroupEscala.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGroupEscala.Controls.Add(Me.lblLabel8)
        Me.grpGroupEscala.Controls.Add(Me.lblLabel7)
        Me.grpGroupEscala.Controls.Add(Me.strkBarraY)
        Me.grpGroupEscala.Controls.Add(Me.strkBarraX)
        Me.grpGroupEscala.ForeColor = System.Drawing.Color.Black
        Me.grpGroupEscala.Location = New System.Drawing.Point(828, 491)
        Me.grpGroupEscala.Name = "grpGroupEscala"
        Me.grpGroupEscala.Size = New System.Drawing.Size(212, 66)
        Me.grpGroupEscala.TabIndex = 128
        Me.grpGroupEscala.TabStop = False
        Me.grpGroupEscala.Text = "Escala"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.Location = New System.Drawing.Point(12, 39)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.Size = New System.Drawing.Size(49, 13)
        Me.lblLabel8.TabIndex = 3
        Me.lblLabel8.Text = "Escala Y"
        Me.lblLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.Location = New System.Drawing.Point(12, 19)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.Size = New System.Drawing.Size(49, 13)
        Me.lblLabel7.TabIndex = 2
        Me.lblLabel7.Text = "Escala X"
        Me.lblLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'strkBarraY
        '
        Me.strkBarraY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.strkBarraY.AutoSize = False
        Me.strkBarraY.LargeChange = 1
        Me.strkBarraY.Location = New System.Drawing.Point(67, 39)
        Me.strkBarraY.Maximum = 6
        Me.strkBarraY.Minimum = 1
        Me.strkBarraY.Name = "strkBarraY"
        Me.strkBarraY.Size = New System.Drawing.Size(134, 18)
        Me.strkBarraY.TabIndex = 7
        Me.strkBarraY.Value = 1
        '
        'strkBarraX
        '
        Me.strkBarraX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.strkBarraX.AutoSize = False
        Me.strkBarraX.LargeChange = 1
        Me.strkBarraX.Location = New System.Drawing.Point(67, 18)
        Me.strkBarraX.Maximum = 6
        Me.strkBarraX.Minimum = 1
        Me.strkBarraX.Name = "strkBarraX"
        Me.strkBarraX.Size = New System.Drawing.Size(134, 18)
        Me.strkBarraX.TabIndex = 4
        Me.strkBarraX.Value = 1
        '
        'pnlPanel
        '
        Me.pnlPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnRelatorio)
        Me.pnlPanel.Controls.Add(Me.btnOk)
        Me.pnlPanel.Location = New System.Drawing.Point(0, 647)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(1063, 35)
        Me.pnlPanel.TabIndex = 131
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabMassaSeca)
        Me.TabControl1.Controls.Add(Me.tabExpansaoUmidade)
        Me.TabControl1.Controls.Add(Me.tabIscUmidade)
        Me.TabControl1.Controls.Add(Me.MultiplasListas)
        Me.TabControl1.Location = New System.Drawing.Point(9, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(807, 589)
        Me.TabControl1.TabIndex = 132
        '
        'tabMassaSeca
        '
        Me.tabMassaSeca.Controls.Add(Me.GraficoResultados1)
        Me.tabMassaSeca.Location = New System.Drawing.Point(4, 22)
        Me.tabMassaSeca.Name = "tabMassaSeca"
        Me.tabMassaSeca.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMassaSeca.Size = New System.Drawing.Size(799, 563)
        Me.tabMassaSeca.TabIndex = 0
        Me.tabMassaSeca.Text = "Massa Seca x Umidade"
        Me.tabMassaSeca.UseVisualStyleBackColor = True
        '
        'GraficoResultados1
        '
        Me.GraficoResultados1.Location = New System.Drawing.Point(4, 4)
        Me.GraficoResultados1.Name = "GraficoResultados1"
        Me.GraficoResultados1.Size = New System.Drawing.Size(789, 553)
        Me.GraficoResultados1.TabIndex = 0
        Me.GraficoResultados1.TabStop = False
        '
        'tabExpansaoUmidade
        '
        Me.tabExpansaoUmidade.Controls.Add(Me.GraficoResultados2)
        Me.tabExpansaoUmidade.Location = New System.Drawing.Point(4, 22)
        Me.tabExpansaoUmidade.Name = "tabExpansaoUmidade"
        Me.tabExpansaoUmidade.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExpansaoUmidade.Size = New System.Drawing.Size(799, 563)
        Me.tabExpansaoUmidade.TabIndex = 1
        Me.tabExpansaoUmidade.Text = "Expansão x Umidade"
        Me.tabExpansaoUmidade.UseVisualStyleBackColor = True
        '
        'GraficoResultados2
        '
        Me.GraficoResultados2.Location = New System.Drawing.Point(4, 4)
        Me.GraficoResultados2.Name = "GraficoResultados2"
        Me.GraficoResultados2.Size = New System.Drawing.Size(789, 553)
        Me.GraficoResultados2.TabIndex = 0
        Me.GraficoResultados2.TabStop = False
        '
        'tabIscUmidade
        '
        Me.tabIscUmidade.Controls.Add(Me.GraficoResultados3)
        Me.tabIscUmidade.Location = New System.Drawing.Point(4, 22)
        Me.tabIscUmidade.Name = "tabIscUmidade"
        Me.tabIscUmidade.Padding = New System.Windows.Forms.Padding(3)
        Me.tabIscUmidade.Size = New System.Drawing.Size(799, 563)
        Me.tabIscUmidade.TabIndex = 2
        Me.tabIscUmidade.Text = "ISC x Umidade"
        Me.tabIscUmidade.UseVisualStyleBackColor = True
        '
        'GraficoResultados3
        '
        Me.GraficoResultados3.Location = New System.Drawing.Point(4, 4)
        Me.GraficoResultados3.Name = "GraficoResultados3"
        Me.GraficoResultados3.Size = New System.Drawing.Size(789, 556)
        Me.GraficoResultados3.TabIndex = 0
        Me.GraficoResultados3.TabStop = False
        '
        'MultiplasListas
        '
        Me.MultiplasListas.Controls.Add(Me.graficoResultados4)
        Me.MultiplasListas.Location = New System.Drawing.Point(4, 22)
        Me.MultiplasListas.Name = "MultiplasListas"
        Me.MultiplasListas.Size = New System.Drawing.Size(799, 563)
        Me.MultiplasListas.TabIndex = 3
        Me.MultiplasListas.Text = "Multiplas Linhas"
        Me.MultiplasListas.UseVisualStyleBackColor = True
        '
        'graficoResultados4
        '
        Me.graficoResultados4.Location = New System.Drawing.Point(3, 3)
        Me.graficoResultados4.Name = "graficoResultados4"
        Me.graficoResultados4.Size = New System.Drawing.Size(793, 557)
        Me.graficoResultados4.TabIndex = 0
        Me.graficoResultados4.TabStop = False
        '
        'frmResultadosJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1052, 694)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.grpGroupEscala)
        Me.Controls.Add(Me.tlsBarraFerramenta)
        Me.Controls.Add(Me.grpGroup1)
        Me.Controls.Add(Me.grpGroup3)
        Me.Controls.Add(Me.mnuMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResultadosJ"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpGroup3.ResumeLayout(False)
        Me.grpGroup3.PerformLayout()
        Me.grpGroup1.ResumeLayout(False)
        Me.grpGroup1.PerformLayout()
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.tlsBarraFerramenta.ResumeLayout(False)
        Me.tlsBarraFerramenta.PerformLayout()
        Me.grpGroupEscala.ResumeLayout(False)
        Me.grpGroupEscala.PerformLayout()
        CType(Me.strkBarraY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.strkBarraX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabMassaSeca.ResumeLayout(False)
        CType(Me.GraficoResultados1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabExpansaoUmidade.ResumeLayout(False)
        CType(Me.GraficoResultados2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabIscUmidade.ResumeLayout(False)
        CType(Me.GraficoResultados3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MultiplasListas.ResumeLayout(False)
        CType(Me.graficoResultados4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpGroup3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkLegenda As System.Windows.Forms.CheckBox
    Friend WithEvents grpGroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents lstView As System.Windows.Forms.ListView
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRever As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAtualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelatorio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExibir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRotacionar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu0 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu30 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu45 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsBarraFerramenta As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsAtualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpGroupEscala As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabel8 As System.Windows.Forms.Label
    Friend WithEvents lblLabel7 As System.Windows.Forms.Label
    Friend WithEvents strkBarraY As System.Windows.Forms.TrackBar
    Friend WithEvents strkBarraX As System.Windows.Forms.TrackBar
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents chkSelecionar As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabMassaSeca As System.Windows.Forms.TabPage
    Friend WithEvents tabExpansaoUmidade As System.Windows.Forms.TabPage
    Friend WithEvents tabIscUmidade As System.Windows.Forms.TabPage
    Friend WithEvents GraficoResultados1 As ChartDirector.WinChartViewer
    Friend WithEvents GraficoResultados2 As ChartDirector.WinChartViewer
    Friend WithEvents GraficoResultados3 As ChartDirector.WinChartViewer
    Friend WithEvents MultiplasListas As TabPage
    Friend WithEvents graficoResultados4 As ChartDirector.WinChartViewer
End Class
