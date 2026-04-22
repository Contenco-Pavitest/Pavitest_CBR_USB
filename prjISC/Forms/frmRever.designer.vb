<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRever
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRever))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Teste1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoX1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverEixoY2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizarEixosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNovaLinhaY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCurvaTracejada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoverCurva = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRotacionarGrafico = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAjusteEscalaAutomatico = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoX = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoXEscalaMin0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoXEscalaMinMenor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoY1EscalaMin0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoY1EscalaMinMenor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoY2EscalaMin0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoY2EscalaMinMenor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoTodosEixos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAjusteEscalaManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManualX = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLegendaMinimoX = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMinimoX = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaMaximoX = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMaximoX = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaSubidivisaoX = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSubdivisaoX = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAplicarAjustesEscalaX = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManualY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLegendaMinimoY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMinimoY1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaMaximoY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMaximoY1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaSubidivisaoY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSubdivisaoY1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAplicarAjustesEscalaY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManualY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLegendaMinimoY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMinimoY2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaMaximoY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMaximoY2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaSubdivisaoY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSubdivisaoY2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAplicarAjustesEscalaY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCorrigir2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbGrafico = New System.Windows.Forms.GroupBox()
        Me.Grafico1 = New ChartDirector.WinChartViewer()
        Me.tlsBarra = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.tlsZoomOut = New System.Windows.Forms.ToolStripButton()
        Me.tlsZoomCancel = New System.Windows.Forms.ToolStripButton()
        Me.tlsCrossHair = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpGroup1 = New System.Windows.Forms.GroupBox()
        Me.lblInstrumentoConectado = New System.Windows.Forms.Label()
        Me.lblPenetracao = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblPressao = New System.Windows.Forms.Label()
        Me.lblLegendaPressao = New System.Windows.Forms.Label()
        Me.lblCarga = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.grpResultados = New System.Windows.Forms.GroupBox()
        Me.txtISC1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPadrao1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtFixo0 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCorrigida1 = New System.Windows.Forms.TextBox()
        Me.txtFixo1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtISC0 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPadrao0 = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCorrigida0 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCalculada0 = New System.Windows.Forms.TextBox()
        Me.txtCalculada1 = New System.Windows.Forms.TextBox()
        Me.btnCalcularRegressão = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grbGrafico.SuspendLayout()
        CType(Me.Grafico1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsBarra.SuspendLayout()
        Me.grpGroup1.SuspendLayout()
        Me.grpResultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TesteToolStripMenuItem, Me.EscalaToolStripMenuItem, Me.btnCorrigir2, Me.RelatórioToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(918, 24)
        Me.MenuStrip1.TabIndex = 198
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TesteToolStripMenuItem
        '
        Me.TesteToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TesteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Teste1ToolStripMenuItem, Me.CustomizarEixosToolStripMenuItem})
        Me.TesteToolStripMenuItem.Image = CType(resources.GetObject("TesteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TesteToolStripMenuItem.Name = "TesteToolStripMenuItem"
        Me.TesteToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.TesteToolStripMenuItem.Text = "Eixos"
        '
        'Teste1ToolStripMenuItem
        '
        Me.Teste1ToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Teste1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEixoX1, Me.mnuEixoY1, Me.mnuEixoY2})
        Me.Teste1ToolStripMenuItem.Name = "Teste1ToolStripMenuItem"
        Me.Teste1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Teste1ToolStripMenuItem.Text = "Eixos de Leitura"
        '
        'mnuEixoX1
        '
        Me.mnuEixoX1.Name = "mnuEixoX1"
        Me.mnuEixoX1.Size = New System.Drawing.Size(180, 22)
        Me.mnuEixoX1.Text = "Eixo X"
        '
        'mnuEixoY1
        '
        Me.mnuEixoY1.Name = "mnuEixoY1"
        Me.mnuEixoY1.Size = New System.Drawing.Size(180, 22)
        Me.mnuEixoY1.Text = "Eixo Y1"
        '
        'mnuEixoY2
        '
        Me.mnuEixoY2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoverEixoY2ToolStripMenuItem})
        Me.mnuEixoY2.Name = "mnuEixoY2"
        Me.mnuEixoY2.Size = New System.Drawing.Size(180, 22)
        Me.mnuEixoY2.Text = "Eixo Y2"
        '
        'RemoverEixoY2ToolStripMenuItem
        '
        Me.RemoverEixoY2ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoverEixoY2ToolStripMenuItem.Name = "RemoverEixoY2ToolStripMenuItem"
        Me.RemoverEixoY2ToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RemoverEixoY2ToolStripMenuItem.Text = "Remover Eixo Y2"
        '
        'CustomizarEixosToolStripMenuItem
        '
        Me.CustomizarEixosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNovaLinhaY1, Me.mnuCurvaTracejada, Me.mnuRemoverCurva, Me.mnuRotacionarGrafico})
        Me.CustomizarEixosToolStripMenuItem.Name = "CustomizarEixosToolStripMenuItem"
        Me.CustomizarEixosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CustomizarEixosToolStripMenuItem.Text = "Customizar Eixos"
        '
        'mnuNovaLinhaY1
        '
        Me.mnuNovaLinhaY1.Name = "mnuNovaLinhaY1"
        Me.mnuNovaLinhaY1.Size = New System.Drawing.Size(213, 22)
        Me.mnuNovaLinhaY1.Text = "Adicionar Curva Contínua"
        '
        'mnuCurvaTracejada
        '
        Me.mnuCurvaTracejada.Name = "mnuCurvaTracejada"
        Me.mnuCurvaTracejada.Size = New System.Drawing.Size(213, 22)
        Me.mnuCurvaTracejada.Text = "Adicionar Curva Tracejada"
        '
        'mnuRemoverCurva
        '
        Me.mnuRemoverCurva.Name = "mnuRemoverCurva"
        Me.mnuRemoverCurva.Size = New System.Drawing.Size(213, 22)
        Me.mnuRemoverCurva.Text = "Remover Curva"
        '
        'mnuRotacionarGrafico
        '
        Me.mnuRotacionarGrafico.Name = "mnuRotacionarGrafico"
        Me.mnuRotacionarGrafico.Size = New System.Drawing.Size(213, 22)
        Me.mnuRotacionarGrafico.Text = "Rotacionar Gráfico"
        '
        'EscalaToolStripMenuItem
        '
        Me.EscalaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EscalaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAjusteEscalaAutomatico, Me.mnuAjusteEscalaManual})
        Me.EscalaToolStripMenuItem.Image = CType(resources.GetObject("EscalaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EscalaToolStripMenuItem.Name = "EscalaToolStripMenuItem"
        Me.EscalaToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EscalaToolStripMenuItem.Text = "Escala"
        '
        'mnuAjusteEscalaAutomatico
        '
        Me.mnuAjusteEscalaAutomatico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoX, Me.mnuAutoEixoY1, Me.mnuAutoEixoY2, Me.mnuAutoTodosEixos})
        Me.mnuAjusteEscalaAutomatico.Name = "mnuAjusteEscalaAutomatico"
        Me.mnuAjusteEscalaAutomatico.Size = New System.Drawing.Size(173, 22)
        Me.mnuAjusteEscalaAutomatico.Text = "Ajuste Automático"
        '
        'mnuAutoEixoX
        '
        Me.mnuAutoEixoX.Checked = True
        Me.mnuAutoEixoX.CheckOnClick = True
        Me.mnuAutoEixoX.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAutoEixoX.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoXEscalaMin0, Me.mnuAutoEixoXEscalaMinMenor})
        Me.mnuAutoEixoX.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoEixoX.Name = "mnuAutoEixoX"
        Me.mnuAutoEixoX.Size = New System.Drawing.Size(205, 22)
        Me.mnuAutoEixoX.Text = "Eixo X"
        '
        'mnuAutoEixoXEscalaMin0
        '
        Me.mnuAutoEixoXEscalaMin0.CheckOnClick = True
        Me.mnuAutoEixoXEscalaMin0.Name = "mnuAutoEixoXEscalaMin0"
        Me.mnuAutoEixoXEscalaMin0.Size = New System.Drawing.Size(231, 22)
        Me.mnuAutoEixoXEscalaMin0.Text = "Escala Mínima = 0"
        '
        'mnuAutoEixoXEscalaMinMenor
        '
        Me.mnuAutoEixoXEscalaMinMenor.CheckOnClick = True
        Me.mnuAutoEixoXEscalaMinMenor.Name = "mnuAutoEixoXEscalaMinMenor"
        Me.mnuAutoEixoXEscalaMinMenor.Size = New System.Drawing.Size(231, 22)
        Me.mnuAutoEixoXEscalaMinMenor.Text = "Escala Mínima ≅ Menor Valor"
        '
        'mnuAutoEixoY1
        '
        Me.mnuAutoEixoY1.Checked = True
        Me.mnuAutoEixoY1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAutoEixoY1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoY1EscalaMin0, Me.mnuAutoEixoY1EscalaMinMenor})
        Me.mnuAutoEixoY1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoEixoY1.Name = "mnuAutoEixoY1"
        Me.mnuAutoEixoY1.Size = New System.Drawing.Size(205, 22)
        Me.mnuAutoEixoY1.Text = "Eixo Y1"
        '
        'mnuAutoEixoY1EscalaMin0
        '
        Me.mnuAutoEixoY1EscalaMin0.CheckOnClick = True
        Me.mnuAutoEixoY1EscalaMin0.Name = "mnuAutoEixoY1EscalaMin0"
        Me.mnuAutoEixoY1EscalaMin0.Size = New System.Drawing.Size(231, 22)
        Me.mnuAutoEixoY1EscalaMin0.Text = "Escala Mínima = 0"
        '
        'mnuAutoEixoY1EscalaMinMenor
        '
        Me.mnuAutoEixoY1EscalaMinMenor.CheckOnClick = True
        Me.mnuAutoEixoY1EscalaMinMenor.Name = "mnuAutoEixoY1EscalaMinMenor"
        Me.mnuAutoEixoY1EscalaMinMenor.Size = New System.Drawing.Size(231, 22)
        Me.mnuAutoEixoY1EscalaMinMenor.Text = "Escala Mínima ≅ Menor Valor"
        '
        'mnuAutoEixoY2
        '
        Me.mnuAutoEixoY2.Checked = True
        Me.mnuAutoEixoY2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAutoEixoY2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoY2EscalaMin0, Me.mnuAutoEixoY2EscalaMinMenor})
        Me.mnuAutoEixoY2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoEixoY2.Name = "mnuAutoEixoY2"
        Me.mnuAutoEixoY2.Size = New System.Drawing.Size(205, 22)
        Me.mnuAutoEixoY2.Text = "Eixo Y2"
        '
        'mnuAutoEixoY2EscalaMin0
        '
        Me.mnuAutoEixoY2EscalaMin0.CheckOnClick = True
        Me.mnuAutoEixoY2EscalaMin0.Name = "mnuAutoEixoY2EscalaMin0"
        Me.mnuAutoEixoY2EscalaMin0.Size = New System.Drawing.Size(231, 22)
        Me.mnuAutoEixoY2EscalaMin0.Text = "Escala Mínima = 0"
        '
        'mnuAutoEixoY2EscalaMinMenor
        '
        Me.mnuAutoEixoY2EscalaMinMenor.CheckOnClick = True
        Me.mnuAutoEixoY2EscalaMinMenor.Name = "mnuAutoEixoY2EscalaMinMenor"
        Me.mnuAutoEixoY2EscalaMinMenor.Size = New System.Drawing.Size(231, 22)
        Me.mnuAutoEixoY2EscalaMinMenor.Text = "Escala Mínima ≅ Menor Valor"
        '
        'mnuAutoTodosEixos
        '
        Me.mnuAutoTodosEixos.Name = "mnuAutoTodosEixos"
        Me.mnuAutoTodosEixos.Size = New System.Drawing.Size(205, 22)
        Me.mnuAutoTodosEixos.Text = "Todos eixos automáticos"
        '
        'mnuAjusteEscalaManual
        '
        Me.mnuAjusteEscalaManual.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManualX, Me.mnuManualY1, Me.mnuManualY2})
        Me.mnuAjusteEscalaManual.Name = "mnuAjusteEscalaManual"
        Me.mnuAjusteEscalaManual.Size = New System.Drawing.Size(173, 22)
        Me.mnuAjusteEscalaManual.Text = "Ajuste Manual"
        '
        'mnuManualX
        '
        Me.mnuManualX.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLegendaMinimoX, Me.txtMinimoX, Me.ToolStripSeparator6, Me.lblLegendaMaximoX, Me.txtMaximoX, Me.ToolStripSeparator7, Me.lblLegendaSubidivisaoX, Me.txtSubdivisaoX, Me.ToolStripSeparator8, Me.btnAplicarAjustesEscalaX})
        Me.mnuManualX.Name = "mnuManualX"
        Me.mnuManualX.Size = New System.Drawing.Size(111, 22)
        Me.mnuManualX.Text = "Eixo X"
        '
        'lblLegendaMinimoX
        '
        Me.lblLegendaMinimoX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblLegendaMinimoX.Enabled = False
        Me.lblLegendaMinimoX.Name = "lblLegendaMinimoX"
        Me.lblLegendaMinimoX.Size = New System.Drawing.Size(216, 22)
        Me.lblLegendaMinimoX.Text = "Insira o valor mínimo de X:"
        '
        'txtMinimoX
        '
        Me.txtMinimoX.Name = "txtMinimoX"
        Me.txtMinimoX.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(213, 6)
        '
        'lblLegendaMaximoX
        '
        Me.lblLegendaMaximoX.Enabled = False
        Me.lblLegendaMaximoX.Name = "lblLegendaMaximoX"
        Me.lblLegendaMaximoX.Size = New System.Drawing.Size(216, 22)
        Me.lblLegendaMaximoX.Text = "Insira o valor máximo de X:"
        '
        'txtMaximoX
        '
        Me.txtMaximoX.Name = "txtMaximoX"
        Me.txtMaximoX.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(213, 6)
        '
        'lblLegendaSubidivisaoX
        '
        Me.lblLegendaSubidivisaoX.Enabled = False
        Me.lblLegendaSubidivisaoX.Name = "lblLegendaSubidivisaoX"
        Me.lblLegendaSubidivisaoX.Size = New System.Drawing.Size(216, 22)
        Me.lblLegendaSubidivisaoX.Text = "Subdivisão de X:"
        '
        'txtSubdivisaoX
        '
        Me.txtSubdivisaoX.Name = "txtSubdivisaoX"
        Me.txtSubdivisaoX.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(213, 6)
        '
        'btnAplicarAjustesEscalaX
        '
        Me.btnAplicarAjustesEscalaX.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarAjustesEscalaX.Name = "btnAplicarAjustesEscalaX"
        Me.btnAplicarAjustesEscalaX.Size = New System.Drawing.Size(216, 22)
        Me.btnAplicarAjustesEscalaX.Text = "Aplicar Alterações"
        Me.btnAplicarAjustesEscalaX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuManualY1
        '
        Me.mnuManualY1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLegendaMinimoY1, Me.txtMinimoY1, Me.ToolStripSeparator12, Me.lblLegendaMaximoY1, Me.txtMaximoY1, Me.ToolStripSeparator13, Me.lblLegendaSubidivisaoY1, Me.txtSubdivisaoY1, Me.ToolStripSeparator14, Me.btnAplicarAjustesEscalaY1})
        Me.mnuManualY1.Name = "mnuManualY1"
        Me.mnuManualY1.Size = New System.Drawing.Size(111, 22)
        Me.mnuManualY1.Text = "Eixo Y1"
        '
        'lblLegendaMinimoY1
        '
        Me.lblLegendaMinimoY1.Enabled = False
        Me.lblLegendaMinimoY1.Name = "lblLegendaMinimoY1"
        Me.lblLegendaMinimoY1.Size = New System.Drawing.Size(222, 22)
        Me.lblLegendaMinimoY1.Text = "Insira o valor mínimo de Y1:"
        '
        'txtMinimoY1
        '
        Me.txtMinimoY1.Name = "txtMinimoY1"
        Me.txtMinimoY1.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(219, 6)
        '
        'lblLegendaMaximoY1
        '
        Me.lblLegendaMaximoY1.Enabled = False
        Me.lblLegendaMaximoY1.Name = "lblLegendaMaximoY1"
        Me.lblLegendaMaximoY1.Size = New System.Drawing.Size(222, 22)
        Me.lblLegendaMaximoY1.Text = "Insira o valor máximo de Y1:"
        '
        'txtMaximoY1
        '
        Me.txtMaximoY1.Name = "txtMaximoY1"
        Me.txtMaximoY1.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(219, 6)
        '
        'lblLegendaSubidivisaoY1
        '
        Me.lblLegendaSubidivisaoY1.Enabled = False
        Me.lblLegendaSubidivisaoY1.Name = "lblLegendaSubidivisaoY1"
        Me.lblLegendaSubidivisaoY1.Size = New System.Drawing.Size(222, 22)
        Me.lblLegendaSubidivisaoY1.Text = "Subdivisão de Y1:"
        '
        'txtSubdivisaoY1
        '
        Me.txtSubdivisaoY1.Name = "txtSubdivisaoY1"
        Me.txtSubdivisaoY1.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(219, 6)
        '
        'btnAplicarAjustesEscalaY1
        '
        Me.btnAplicarAjustesEscalaY1.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarAjustesEscalaY1.Name = "btnAplicarAjustesEscalaY1"
        Me.btnAplicarAjustesEscalaY1.Size = New System.Drawing.Size(222, 22)
        Me.btnAplicarAjustesEscalaY1.Text = "Aplicar Alterações"
        Me.btnAplicarAjustesEscalaY1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuManualY2
        '
        Me.mnuManualY2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLegendaMinimoY2, Me.txtMinimoY2, Me.ToolStripSeparator9, Me.lblLegendaMaximoY2, Me.txtMaximoY2, Me.ToolStripSeparator10, Me.lblLegendaSubdivisaoY2, Me.txtSubdivisaoY2, Me.ToolStripSeparator11, Me.btnAplicarAjustesEscalaY2})
        Me.mnuManualY2.Name = "mnuManualY2"
        Me.mnuManualY2.Size = New System.Drawing.Size(111, 22)
        Me.mnuManualY2.Text = "Eixo Y2"
        '
        'lblLegendaMinimoY2
        '
        Me.lblLegendaMinimoY2.Enabled = False
        Me.lblLegendaMinimoY2.Name = "lblLegendaMinimoY2"
        Me.lblLegendaMinimoY2.Size = New System.Drawing.Size(222, 22)
        Me.lblLegendaMinimoY2.Text = "Insira o valor mínimo de Y2:"
        '
        'txtMinimoY2
        '
        Me.txtMinimoY2.Name = "txtMinimoY2"
        Me.txtMinimoY2.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(219, 6)
        '
        'lblLegendaMaximoY2
        '
        Me.lblLegendaMaximoY2.Enabled = False
        Me.lblLegendaMaximoY2.Name = "lblLegendaMaximoY2"
        Me.lblLegendaMaximoY2.Size = New System.Drawing.Size(222, 22)
        Me.lblLegendaMaximoY2.Text = "Insira o valor máximo de Y2:"
        '
        'txtMaximoY2
        '
        Me.txtMaximoY2.Name = "txtMaximoY2"
        Me.txtMaximoY2.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(219, 6)
        '
        'lblLegendaSubdivisaoY2
        '
        Me.lblLegendaSubdivisaoY2.Enabled = False
        Me.lblLegendaSubdivisaoY2.Name = "lblLegendaSubdivisaoY2"
        Me.lblLegendaSubdivisaoY2.Size = New System.Drawing.Size(222, 22)
        Me.lblLegendaSubdivisaoY2.Text = "Subdivisão de Y2:"
        '
        'txtSubdivisaoY2
        '
        Me.txtSubdivisaoY2.Name = "txtSubdivisaoY2"
        Me.txtSubdivisaoY2.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(219, 6)
        '
        'btnAplicarAjustesEscalaY2
        '
        Me.btnAplicarAjustesEscalaY2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarAjustesEscalaY2.Name = "btnAplicarAjustesEscalaY2"
        Me.btnAplicarAjustesEscalaY2.Size = New System.Drawing.Size(222, 22)
        Me.btnAplicarAjustesEscalaY2.Text = "Aplicar Alterações"
        Me.btnAplicarAjustesEscalaY2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCorrigir2
        '
        Me.btnCorrigir2.Image = CType(resources.GetObject("btnCorrigir2.Image"), System.Drawing.Image)
        Me.btnCorrigir2.Name = "btnCorrigir2"
        Me.btnCorrigir2.Size = New System.Drawing.Size(75, 20)
        Me.btnCorrigir2.Text = "Corrigir"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.Image = CType(resources.GetObject("RelatórioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RelatórioToolStripMenuItem.Text = "Relatório"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'grbGrafico
        '
        Me.grbGrafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbGrafico.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grbGrafico.Controls.Add(Me.Grafico1)
        Me.grbGrafico.Location = New System.Drawing.Point(13, 52)
        Me.grbGrafico.Name = "grbGrafico"
        Me.grbGrafico.Size = New System.Drawing.Size(649, 344)
        Me.grbGrafico.TabIndex = 199
        Me.grbGrafico.TabStop = False
        '
        'Grafico1
        '
        Me.Grafico1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grafico1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grafico1.Location = New System.Drawing.Point(6, 10)
        Me.Grafico1.Name = "Grafico1"
        Me.Grafico1.Size = New System.Drawing.Size(637, 328)
        Me.Grafico1.TabIndex = 0
        Me.Grafico1.TabStop = False
        '
        'tlsBarra
        '
        Me.tlsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.tlsZoomIn, Me.tlsZoomOut, Me.tlsZoomCancel, Me.tlsCrossHair, Me.tlsSeparador1})
        Me.tlsBarra.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarra.Name = "tlsBarra"
        Me.tlsBarra.Size = New System.Drawing.Size(918, 25)
        Me.tlsBarra.TabIndex = 226
        Me.tlsBarra.Text = "ToolStrip1"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tlsZoomIn
        '
        Me.tlsZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsZoomIn.Image = CType(resources.GetObject("tlsZoomIn.Image"), System.Drawing.Image)
        Me.tlsZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsZoomIn.Name = "tlsZoomIn"
        Me.tlsZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.tlsZoomIn.Text = "Aumentar zoom"
        '
        'tlsZoomOut
        '
        Me.tlsZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsZoomOut.Image = CType(resources.GetObject("tlsZoomOut.Image"), System.Drawing.Image)
        Me.tlsZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsZoomOut.Name = "tlsZoomOut"
        Me.tlsZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.tlsZoomOut.Text = "Diminuir zoom"
        '
        'tlsZoomCancel
        '
        Me.tlsZoomCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsZoomCancel.Image = CType(resources.GetObject("tlsZoomCancel.Image"), System.Drawing.Image)
        Me.tlsZoomCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsZoomCancel.Name = "tlsZoomCancel"
        Me.tlsZoomCancel.Size = New System.Drawing.Size(23, 22)
        Me.tlsZoomCancel.Text = "Cancelar Zoom"
        '
        'tlsCrossHair
        '
        Me.tlsCrossHair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsCrossHair.Image = CType(resources.GetObject("tlsCrossHair.Image"), System.Drawing.Image)
        Me.tlsCrossHair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsCrossHair.Name = "tlsCrossHair"
        Me.tlsCrossHair.Size = New System.Drawing.Size(23, 22)
        Me.tlsCrossHair.Text = "CoordenadasOff"
        '
        'tlsSeparador1
        '
        Me.tlsSeparador1.Name = "tlsSeparador1"
        Me.tlsSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'grpGroup1
        '
        Me.grpGroup1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpGroup1.Controls.Add(Me.lblInstrumentoConectado)
        Me.grpGroup1.Controls.Add(Me.lblPenetracao)
        Me.grpGroup1.Controls.Add(Me.lblLabel3)
        Me.grpGroup1.Controls.Add(Me.lblPressao)
        Me.grpGroup1.Controls.Add(Me.lblLegendaPressao)
        Me.grpGroup1.Controls.Add(Me.lblCarga)
        Me.grpGroup1.Controls.Add(Me.lblLabel1)
        Me.grpGroup1.ForeColor = System.Drawing.Color.Black
        Me.grpGroup1.Location = New System.Drawing.Point(668, 52)
        Me.grpGroup1.Name = "grpGroup1"
        Me.grpGroup1.Size = New System.Drawing.Size(241, 344)
        Me.grpGroup1.TabIndex = 227
        Me.grpGroup1.TabStop = False
        '
        'lblInstrumentoConectado
        '
        Me.lblInstrumentoConectado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstrumentoConectado.Location = New System.Drawing.Point(22, 50)
        Me.lblInstrumentoConectado.Name = "lblInstrumentoConectado"
        Me.lblInstrumentoConectado.Size = New System.Drawing.Size(194, 12)
        Me.lblInstrumentoConectado.TabIndex = 162
        Me.lblInstrumentoConectado.Text = "(Instrumento)"
        Me.lblInstrumentoConectado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPenetracao
        '
        Me.lblPenetracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenetracao.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPenetracao.Location = New System.Drawing.Point(29, 195)
        Me.lblPenetracao.Name = "lblPenetracao"
        Me.lblPenetracao.Size = New System.Drawing.Size(187, 24)
        Me.lblPenetracao.TabIndex = 5
        Me.lblPenetracao.Text = "- - - -"
        Me.lblPenetracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(75, 168)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(87, 13)
        Me.lblLabel3.TabIndex = 4
        Me.lblLabel3.Text = "Penetração (mm)"
        '
        'lblPressao
        '
        Me.lblPressao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressao.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPressao.Location = New System.Drawing.Point(29, 135)
        Me.lblPressao.Name = "lblPressao"
        Me.lblPressao.Size = New System.Drawing.Size(187, 24)
        Me.lblPressao.TabIndex = 3
        Me.lblPressao.Text = "- - - -"
        Me.lblPressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLegendaPressao
        '
        Me.lblLegendaPressao.Location = New System.Drawing.Point(21, 106)
        Me.lblLegendaPressao.Name = "lblLegendaPressao"
        Me.lblLegendaPressao.Size = New System.Drawing.Size(200, 13)
        Me.lblLegendaPressao.TabIndex = 2
        Me.lblLegendaPressao.Text = "Pressão (kgf/cm²)"
        Me.lblLegendaPressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCarga
        '
        Me.lblCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarga.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCarga.Location = New System.Drawing.Point(29, 73)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(187, 24)
        Me.lblCarga.TabIndex = 1
        Me.lblCarga.Text = "- - - -"
        Me.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(90, 34)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(59, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "Carga (kgf)"
        '
        'grpResultados
        '
        Me.grpResultados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResultados.Controls.Add(Me.txtISC1)
        Me.grpResultados.Controls.Add(Me.Label14)
        Me.grpResultados.Controls.Add(Me.txtPadrao1)
        Me.grpResultados.Controls.Add(Me.txtFixo0)
        Me.grpResultados.Controls.Add(Me.txtCorrigida1)
        Me.grpResultados.Controls.Add(Me.txtFixo1)
        Me.grpResultados.Controls.Add(Me.txtISC0)
        Me.grpResultados.Controls.Add(Me.Label4)
        Me.grpResultados.Controls.Add(Me.txtPadrao0)
        Me.grpResultados.Controls.Add(Me.Label22)
        Me.grpResultados.Controls.Add(Me.txtCorrigida0)
        Me.grpResultados.Controls.Add(Me.Label23)
        Me.grpResultados.Controls.Add(Me.Label15)
        Me.grpResultados.Controls.Add(Me.txtCalculada0)
        Me.grpResultados.Controls.Add(Me.txtCalculada1)
        Me.grpResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResultados.ForeColor = System.Drawing.Color.Black
        Me.grpResultados.Location = New System.Drawing.Point(501, 427)
        Me.grpResultados.Name = "grpResultados"
        Me.grpResultados.Size = New System.Drawing.Size(318, 119)
        Me.grpResultados.TabIndex = 228
        Me.grpResultados.TabStop = False
        Me.grpResultados.Text = "Resultados"
        '
        'txtISC1
        '
        Me.txtISC1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtISC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtISC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISC1.Location = New System.Drawing.Point(248, 76)
        Me.txtISC1.Name = "txtISC1"
        Me.txtISC1.ReadOnly = True
        Me.txtISC1.Size = New System.Drawing.Size(60, 20)
        Me.txtISC1.TabIndex = 362
        Me.txtISC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(64, 28)
        Me.Label14.TabIndex = 352
        Me.Label14.Text = "Penetração" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(mm)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPadrao1
        '
        Me.txtPadrao1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPadrao1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPadrao1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPadrao1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPadrao1.Location = New System.Drawing.Point(189, 76)
        Me.txtPadrao1.Name = "txtPadrao1"
        Me.txtPadrao1.ReadOnly = True
        Me.txtPadrao1.Size = New System.Drawing.Size(60, 20)
        Me.txtPadrao1.TabIndex = 360
        Me.txtPadrao1.Text = "105,46"
        Me.txtPadrao1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFixo0
        '
        Me.txtFixo0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFixo0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFixo0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFixo0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixo0.Location = New System.Drawing.Point(8, 57)
        Me.txtFixo0.Name = "txtFixo0"
        Me.txtFixo0.ReadOnly = True
        Me.txtFixo0.Size = New System.Drawing.Size(64, 20)
        Me.txtFixo0.TabIndex = 354
        Me.txtFixo0.Text = "2,54"
        Me.txtFixo0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCorrigida1
        '
        Me.txtCorrigida1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorrigida1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCorrigida1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorrigida1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrigida1.Location = New System.Drawing.Point(130, 76)
        Me.txtCorrigida1.Name = "txtCorrigida1"
        Me.txtCorrigida1.ReadOnly = True
        Me.txtCorrigida1.Size = New System.Drawing.Size(60, 20)
        Me.txtCorrigida1.TabIndex = 357
        Me.txtCorrigida1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFixo1
        '
        Me.txtFixo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFixo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFixo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFixo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixo1.Location = New System.Drawing.Point(8, 76)
        Me.txtFixo1.Name = "txtFixo1"
        Me.txtFixo1.ReadOnly = True
        Me.txtFixo1.Size = New System.Drawing.Size(64, 20)
        Me.txtFixo1.TabIndex = 355
        Me.txtFixo1.Text = "5,08"
        Me.txtFixo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtISC0
        '
        Me.txtISC0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtISC0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtISC0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISC0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISC0.Location = New System.Drawing.Point(248, 57)
        Me.txtISC0.Name = "txtISC0"
        Me.txtISC0.ReadOnly = True
        Me.txtISC0.Size = New System.Drawing.Size(60, 20)
        Me.txtISC0.TabIndex = 361
        Me.txtISC0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(71, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(60, 28)
        Me.Label4.TabIndex = 363
        Me.Label4.Text = "Calculada (kgf/cm²)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPadrao0
        '
        Me.txtPadrao0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPadrao0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPadrao0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPadrao0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPadrao0.Location = New System.Drawing.Point(189, 57)
        Me.txtPadrao0.Name = "txtPadrao0"
        Me.txtPadrao0.ReadOnly = True
        Me.txtPadrao0.Size = New System.Drawing.Size(60, 20)
        Me.txtPadrao0.TabIndex = 359
        Me.txtPadrao0.Text = "70,31"
        Me.txtPadrao0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(130, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(60, 28)
        Me.Label22.TabIndex = 364
        Me.Label22.Text = "Corrigida (kgf/cm²)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCorrigida0
        '
        Me.txtCorrigida0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCorrigida0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCorrigida0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorrigida0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrigida0.Location = New System.Drawing.Point(130, 57)
        Me.txtCorrigida0.Name = "txtCorrigida0"
        Me.txtCorrigida0.ReadOnly = True
        Me.txtCorrigida0.Size = New System.Drawing.Size(60, 20)
        Me.txtCorrigida0.TabIndex = 356
        Me.txtCorrigida0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(189, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(60, 28)
        Me.Label23.TabIndex = 365
        Me.Label23.Text = "Padrão (kgf/cm²)"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(248, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(60, 28)
        Me.Label15.TabIndex = 358
        Me.Label15.Text = "ISC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(%)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCalculada0
        '
        Me.txtCalculada0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCalculada0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCalculada0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalculada0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalculada0.Location = New System.Drawing.Point(71, 57)
        Me.txtCalculada0.Name = "txtCalculada0"
        Me.txtCalculada0.ReadOnly = True
        Me.txtCalculada0.Size = New System.Drawing.Size(60, 20)
        Me.txtCalculada0.TabIndex = 366
        Me.txtCalculada0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCalculada1
        '
        Me.txtCalculada1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCalculada1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCalculada1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalculada1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalculada1.Location = New System.Drawing.Point(71, 76)
        Me.txtCalculada1.Name = "txtCalculada1"
        Me.txtCalculada1.ReadOnly = True
        Me.txtCalculada1.Size = New System.Drawing.Size(60, 20)
        Me.txtCalculada1.TabIndex = 367
        Me.txtCalculada1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcularRegressão
        '
        Me.btnCalcularRegressão.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularRegressão.Image = CType(resources.GetObject("btnCalcularRegressão.Image"), System.Drawing.Image)
        Me.btnCalcularRegressão.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularRegressão.Location = New System.Drawing.Point(822, 446)
        Me.btnCalcularRegressão.Name = "btnCalcularRegressão"
        Me.btnCalcularRegressão.Padding = New System.Windows.Forms.Padding(5, 0, 4, 0)
        Me.btnCalcularRegressão.Size = New System.Drawing.Size(81, 26)
        Me.btnCalcularRegressão.TabIndex = 327
        Me.btnCalcularRegressão.Text = "   Corrigir"
        Me.btnCalcularRegressão.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.Image = CType(resources.GetObject("btnRelatorio.Image"), System.Drawing.Image)
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorio.Location = New System.Drawing.Point(822, 478)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnRelatorio.Size = New System.Drawing.Size(81, 26)
        Me.btnRelatorio.TabIndex = 328
        Me.btnRelatorio.Text = "&Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(822, 510)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnSair.Size = New System.Drawing.Size(81, 26)
        Me.btnSair.TabIndex = 329
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblMsgErro
        '
        Me.lblMsgErro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMsgErro.BackColor = System.Drawing.Color.Red
        Me.lblMsgErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgErro.ForeColor = System.Drawing.Color.White
        Me.lblMsgErro.Location = New System.Drawing.Point(-423, 399)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.Size = New System.Drawing.Size(1370, 25)
        Me.lblMsgErro.TabIndex = 330
        Me.lblMsgErro.Text = "Erro"
        Me.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsgErro.Visible = False
        '
        'frmRever
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 549)
        Me.Controls.Add(Me.lblMsgErro)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(Me.btnCalcularRegressão)
        Me.Controls.Add(Me.grpResultados)
        Me.Controls.Add(Me.grpGroup1)
        Me.Controls.Add(Me.tlsBarra)
        Me.Controls.Add(Me.grbGrafico)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRever"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rever Ensaio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grbGrafico.ResumeLayout(False)
        CType(Me.Grafico1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsBarra.ResumeLayout(False)
        Me.tlsBarra.PerformLayout()
        Me.grpGroup1.ResumeLayout(False)
        Me.grpGroup1.PerformLayout()
        Me.grpResultados.ResumeLayout(False)
        Me.grpResultados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TesteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Teste1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEixoX1 As ToolStripMenuItem
    Friend WithEvents mnuEixoY1 As ToolStripMenuItem
    Friend WithEvents mnuEixoY2 As ToolStripMenuItem
    Friend WithEvents RemoverEixoY2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizarEixosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNovaLinhaY1 As ToolStripMenuItem

    Friend WithEvents EscalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAjusteEscalaAutomatico As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoX As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoXEscalaMin0 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoXEscalaMinMenor As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY1 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY1EscalaMin0 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY1EscalaMinMenor As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY2 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY2EscalaMin0 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY2EscalaMinMenor As ToolStripMenuItem
    Friend WithEvents mnuAjusteEscalaManual As ToolStripMenuItem
    Friend WithEvents mnuManualX As ToolStripMenuItem
    Friend WithEvents lblLegendaMinimoX As ToolStripMenuItem
    Friend WithEvents txtMinimoX As ToolStripTextBox
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents lblLegendaMaximoX As ToolStripMenuItem
    Friend WithEvents txtMaximoX As ToolStripTextBox
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents lblLegendaSubidivisaoX As ToolStripMenuItem
    Friend WithEvents txtSubdivisaoX As ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents btnAplicarAjustesEscalaX As ToolStripMenuItem
    Friend WithEvents mnuManualY1 As ToolStripMenuItem
    Friend WithEvents lblLegendaMinimoY1 As ToolStripMenuItem
    Friend WithEvents txtMinimoY1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents lblLegendaMaximoY1 As ToolStripMenuItem
    Friend WithEvents txtMaximoY1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents lblLegendaSubidivisaoY1 As ToolStripMenuItem
    Friend WithEvents txtSubdivisaoY1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents btnAplicarAjustesEscalaY1 As ToolStripMenuItem
    Friend WithEvents mnuManualY2 As ToolStripMenuItem
    Friend WithEvents lblLegendaMinimoY2 As ToolStripMenuItem
    Friend WithEvents txtMinimoY2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents lblLegendaMaximoY2 As ToolStripMenuItem
    Friend WithEvents txtMaximoY2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents lblLegendaSubdivisaoY2 As ToolStripMenuItem
    Friend WithEvents txtSubdivisaoY2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents btnAplicarAjustesEscalaY2 As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grbGrafico As GroupBox
    Friend WithEvents Grafico1 As ChartDirector.WinChartViewer
    Friend WithEvents tlsBarra As ToolStrip
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tlsZoomIn As ToolStripButton
    Friend WithEvents tlsZoomOut As ToolStripButton
    Friend WithEvents tlsZoomCancel As ToolStripButton
    Friend WithEvents tlsSeparador1 As ToolStripSeparator
    Friend WithEvents mnuAutoTodosEixos As ToolStripMenuItem
    Friend WithEvents tlsCrossHair As ToolStripButton
    Friend WithEvents grpGroup1 As GroupBox
    Friend WithEvents lblInstrumentoConectado As Label
    Friend WithEvents lblPressao As Label
    Friend WithEvents lblLegendaPressao As Label
    Friend WithEvents lblCarga As Label
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblPenetracao As Label
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents mnuCurvaTracejada As ToolStripMenuItem
    Friend WithEvents mnuRotacionarGrafico As ToolStripMenuItem
    Friend WithEvents mnuRemoverCurva As ToolStripMenuItem
    Friend WithEvents btnCorrigir2 As ToolStripMenuItem
    Friend WithEvents grpResultados As GroupBox
    Friend WithEvents txtISC1 As TextBox
    Public WithEvents Label14 As Label
    Friend WithEvents txtPadrao1 As MaskedTextBox
    Friend WithEvents txtFixo0 As MaskedTextBox
    Friend WithEvents txtCorrigida1 As TextBox
    Friend WithEvents txtFixo1 As MaskedTextBox
    Friend WithEvents txtISC0 As TextBox
    Public WithEvents Label4 As Label
    Friend WithEvents txtPadrao0 As MaskedTextBox
    Public WithEvents Label22 As Label
    Friend WithEvents txtCorrigida0 As TextBox
    Public WithEvents Label23 As Label
    Public WithEvents Label15 As Label
    Friend WithEvents txtCalculada0 As TextBox
    Friend WithEvents txtCalculada1 As TextBox
    Friend WithEvents btnCalcularRegressão As Button
    Friend WithEvents btnRelatorio As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents lblMsgErro As Label
End Class
