<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGraficoPavitest
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGraficoPavitest))
        Me.grpLeituras = New System.Windows.Forms.GroupBox()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblPressao = New System.Windows.Forms.Label()
        Me.lblLegendaPressao = New System.Windows.Forms.Label()
        Me.lblCarga = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.pctZerarCarga = New System.Windows.Forms.PictureBox()
        Me.pctZerarPenetracao = New System.Windows.Forms.PictureBox()
        Me.lblPenetracao = New System.Windows.Forms.Label()
        Me.pctPiscar2 = New System.Windows.Forms.PictureBox()
        Me.pctPiscar1 = New System.Windows.Forms.PictureBox()
        Me.tlsBarra = New System.Windows.Forms.ToolStrip()
        Me.tlsIncrementar = New System.Windows.Forms.ToolStripButton()
        Me.tlsDecrementar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tlsFinalizar = New System.Windows.Forms.ToolStripButton()
        Me.tlsSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsRelatorio = New System.Windows.Forms.ToolStripButton()
        Me.tlsSair = New System.Windows.Forms.ToolStripButton()
        Me.lblSeparadorSetpoint = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaSepoint = New System.Windows.Forms.ToolStripLabel()
        Me.lblSetpointCarga = New System.Windows.Forms.ToolStripLabel()
        Me.lblSeparadorOutput = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaOutput = New System.Windows.Forms.ToolStripLabel()
        Me.lblOutputMotor = New System.Windows.Forms.ToolStripLabel()
        Me.lblSeparadorErroPID = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaErroPID = New System.Windows.Forms.ToolStripLabel()
        Me.lblErroPID = New System.Windows.Forms.ToolStripLabel()
        Me.lblSeparadorIntervalo1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaIntervalo1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblIncrementoMPa = New System.Windows.Forms.ToolStripLabel()
        Me.lblSeparadorIntervalo2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblLegendaIntervalo2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblIncrementokgf = New System.Windows.Forms.ToolStripLabel()
        Me.lblSeparadorReset = New System.Windows.Forms.ToolStripSeparator()
        Me.lblResetDisplay = New System.Windows.Forms.ToolStripLabel()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.EixosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Teste1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoX1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoY2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEixoY2GrandezaConvertida = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverEixoY2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizarEixosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNovaLinhaY1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLinhaTracejada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoverCurva = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotacionarGrafico = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetarEixosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscalaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAjusteEscalaAutomatico = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoX = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoXEscalaMin0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoXEscalaMinMenor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoTempoOrigemFixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoEixoTempoOrigemDinamica = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuTodosEixosManuais = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnsaiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIncrementar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDecrementar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuParar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEstabilizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinalizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparador = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRegressao = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRelatorio1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRelatorio2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAjustes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKP_Deslocamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtKP_Deslocamento = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEnviarKP_Deslocamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKP_Incremento = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtKP_Incremento = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEnviarKP_Incremento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBounce = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBounceBreak = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEnviarBounceBreak = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuErrorAdjust = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtErrorAdjust = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEnviarErrorAdjust = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSampleTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSampleTime = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEnviarSampleTime = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMinimoAjuste = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMinimoAjuste = New System.Windows.Forms.ToolStripTextBox()
        Me.btnEnviarMinimoAjuste = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMovimentacao = New System.Windows.Forms.GroupBox()
        Me.btnEstabilizar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.btnIncrementar = New System.Windows.Forms.Button()
        Me.lblAdvertencia = New System.Windows.Forms.Label()
        Me.btnDecrementar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.grpFinalizacao = New System.Windows.Forms.GroupBox()
        Me.tmrLeituras = New System.Windows.Forms.Timer(Me.components)
        Me.spPortaSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.lblMensagem = New System.Windows.Forms.Label()
        Me.grpCondicaoEnsaio = New System.Windows.Forms.GroupBox()
        Me.chkFinalizacaoAposPenetracao = New System.Windows.Forms.CheckBox()
        Me.chkIniciarGraficoAposCargaMinima = New System.Windows.Forms.CheckBox()
        Me.txtCargaMinimaLimite = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCondicoesEnsaio = New System.Windows.Forms.Button()
        Me.txtPenetracaoLimite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.btnEnviarVelocidade = New System.Windows.Forms.Button()
        Me.txtVelocidade = New System.Windows.Forms.TextBox()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.tmrReposicionar = New System.Windows.Forms.Timer(Me.components)
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.lblReposicionamento = New System.Windows.Forms.Label()
        Me.lblConexaoCelula = New System.Windows.Forms.Label()
        Me.lblSetpointDescendo = New System.Windows.Forms.Label()
        Me.lblSetpointSubindo = New System.Windows.Forms.Label()
        Me.lblThresholdDeslocamento = New System.Windows.Forms.Label()
        Me.lblThresholdCarga = New System.Windows.Forms.Label()
        Me.lblSobrecurso = New System.Windows.Forms.Label()
        Me.lblSobrecarga = New System.Windows.Forms.Label()
        Me.lblDescendo = New System.Windows.Forms.Label()
        Me.lblModoRemotoLocal = New System.Windows.Forms.Label()
        Me.lblPID = New System.Windows.Forms.Label()
        Me.lblSubindo = New System.Windows.Forms.Label()
        Me.lblEmergencia = New System.Windows.Forms.Label()
        Me.lblFimCurso = New System.Windows.Forms.Label()
        Me.grpVelocidadeEnsaio = New System.Windows.Forms.GroupBox()
        Me.rdbModoDeslocamento = New System.Windows.Forms.RadioButton()
        Me.rdbModoIncrementoCarga = New System.Windows.Forms.RadioButton()
        Me.lblUnidadeTaxaPrensa = New System.Windows.Forms.Label()
        Me.grbGrafico = New System.Windows.Forms.GroupBox()
        Me.WinChartViewer1 = New ChartDirector.WinChartViewer()
        Me.btnCalcularRegressão = New System.Windows.Forms.Button()
        Me.barStatus = New System.Windows.Forms.ProgressBar()
        Me.grpLeituras.SuspendLayout()
        CType(Me.pctZerarCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctZerarPenetracao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPiscar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPiscar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsBarra.SuspendLayout()
        Me.mnuMenu.SuspendLayout()
        Me.grpMovimentacao.SuspendLayout()
        Me.grpFinalizacao.SuspendLayout()
        Me.grpCondicaoEnsaio.SuspendLayout()
        Me.grpResultados.SuspendLayout()
        Me.grpStatus.SuspendLayout()
        Me.grpVelocidadeEnsaio.SuspendLayout()
        Me.grbGrafico.SuspendLayout()
        CType(Me.WinChartViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpLeituras
        '
        Me.grpLeituras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpLeituras.Controls.Add(Me.lblLabel3)
        Me.grpLeituras.Controls.Add(Me.lblPressao)
        Me.grpLeituras.Controls.Add(Me.lblLegendaPressao)
        Me.grpLeituras.Controls.Add(Me.lblCarga)
        Me.grpLeituras.Controls.Add(Me.lblLabel1)
        Me.grpLeituras.Controls.Add(Me.pctZerarCarga)
        Me.grpLeituras.Controls.Add(Me.pctZerarPenetracao)
        Me.grpLeituras.Controls.Add(Me.lblPenetracao)
        Me.grpLeituras.Controls.Add(Me.pctPiscar2)
        Me.grpLeituras.Controls.Add(Me.pctPiscar1)
        Me.grpLeituras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLeituras.ForeColor = System.Drawing.Color.Black
        Me.grpLeituras.Location = New System.Drawing.Point(758, 51)
        Me.grpLeituras.Name = "grpLeituras"
        Me.grpLeituras.Size = New System.Drawing.Size(242, 199)
        Me.grpLeituras.TabIndex = 137
        Me.grpLeituras.TabStop = False
        Me.grpLeituras.Text = "Leituras"
        '
        'lblLabel3
        '
        Me.lblLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel3.Location = New System.Drawing.Point(74, 133)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(87, 13)
        Me.lblLabel3.TabIndex = 4
        Me.lblLabel3.Text = "Penetração (mm)"
        '
        'lblPressao
        '
        Me.lblPressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPressao.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressao.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPressao.Location = New System.Drawing.Point(3, 101)
        Me.lblPressao.Name = "lblPressao"
        Me.lblPressao.Size = New System.Drawing.Size(236, 16)
        Me.lblPressao.TabIndex = 3
        Me.lblPressao.Text = "- - - -"
        Me.lblPressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLegendaPressao
        '
        Me.lblLegendaPressao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLegendaPressao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegendaPressao.Location = New System.Drawing.Point(6, 76)
        Me.lblLegendaPressao.Name = "lblLegendaPressao"
        Me.lblLegendaPressao.Size = New System.Drawing.Size(228, 13)
        Me.lblLegendaPressao.TabIndex = 2
        Me.lblLegendaPressao.Text = "Pressão (kgf/cm²)"
        Me.lblLegendaPressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCarga
        '
        Me.lblCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCarga.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarga.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCarga.Location = New System.Drawing.Point(3, 44)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(236, 16)
        Me.lblCarga.TabIndex = 1
        Me.lblCarga.Text = "- - - -"
        Me.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel1
        '
        Me.lblLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(90, 19)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(59, 13)
        Me.lblLabel1.TabIndex = 0
        Me.lblLabel1.Text = "Carga (kgf)"
        '
        'pctZerarCarga
        '
        Me.pctZerarCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctZerarCarga.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pctZerarCarga.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctZerarCarga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctZerarCarga.Image = CType(resources.GetObject("pctZerarCarga.Image"), System.Drawing.Image)
        Me.pctZerarCarga.Location = New System.Drawing.Point(170, 19)
        Me.pctZerarCarga.Name = "pctZerarCarga"
        Me.pctZerarCarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctZerarCarga.Size = New System.Drawing.Size(16, 16)
        Me.pctZerarCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctZerarCarga.TabIndex = 106
        Me.pctZerarCarga.TabStop = False
        '
        'pctZerarPenetracao
        '
        Me.pctZerarPenetracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctZerarPenetracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pctZerarPenetracao.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctZerarPenetracao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctZerarPenetracao.Image = CType(resources.GetObject("pctZerarPenetracao.Image"), System.Drawing.Image)
        Me.pctZerarPenetracao.Location = New System.Drawing.Point(170, 133)
        Me.pctZerarPenetracao.Name = "pctZerarPenetracao"
        Me.pctZerarPenetracao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctZerarPenetracao.Size = New System.Drawing.Size(16, 16)
        Me.pctZerarPenetracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctZerarPenetracao.TabIndex = 99
        Me.pctZerarPenetracao.TabStop = False
        '
        'lblPenetracao
        '
        Me.lblPenetracao.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPenetracao.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenetracao.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPenetracao.Location = New System.Drawing.Point(3, 158)
        Me.lblPenetracao.Name = "lblPenetracao"
        Me.lblPenetracao.Size = New System.Drawing.Size(236, 16)
        Me.lblPenetracao.TabIndex = 5
        Me.lblPenetracao.Text = "- - - -"
        Me.lblPenetracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctPiscar2
        '
        Me.pctPiscar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctPiscar2.BackColor = System.Drawing.Color.Transparent
        Me.pctPiscar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctPiscar2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctPiscar2.Image = CType(resources.GetObject("pctPiscar2.Image"), System.Drawing.Image)
        Me.pctPiscar2.Location = New System.Drawing.Point(16, 18)
        Me.pctPiscar2.Name = "pctPiscar2"
        Me.pctPiscar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctPiscar2.Size = New System.Drawing.Size(24, 24)
        Me.pctPiscar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctPiscar2.TabIndex = 228
        Me.pctPiscar2.TabStop = False
        '
        'pctPiscar1
        '
        Me.pctPiscar1.BackColor = System.Drawing.Color.Transparent
        Me.pctPiscar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctPiscar1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctPiscar1.Image = CType(resources.GetObject("pctPiscar1.Image"), System.Drawing.Image)
        Me.pctPiscar1.Location = New System.Drawing.Point(16, 18)
        Me.pctPiscar1.Name = "pctPiscar1"
        Me.pctPiscar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctPiscar1.Size = New System.Drawing.Size(24, 24)
        Me.pctPiscar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctPiscar1.TabIndex = 227
        Me.pctPiscar1.TabStop = False
        '
        'tlsBarra
        '
        Me.tlsBarra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsIncrementar, Me.tlsDecrementar, Me.ToolStripSeparator1, Me.tlsCancelar, Me.tlsFinalizar, Me.tlsSeparador1, Me.tlsRelatorio, Me.tlsSair, Me.lblSeparadorSetpoint, Me.lblLegendaSepoint, Me.lblSetpointCarga, Me.lblSeparadorOutput, Me.lblLegendaOutput, Me.lblOutputMotor, Me.lblSeparadorErroPID, Me.lblLegendaErroPID, Me.lblErroPID, Me.lblSeparadorIntervalo1, Me.lblLegendaIntervalo1, Me.lblIncrementoMPa, Me.lblSeparadorIntervalo2, Me.lblLegendaIntervalo2, Me.lblIncrementokgf, Me.lblSeparadorReset, Me.lblResetDisplay})
        Me.tlsBarra.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarra.Name = "tlsBarra"
        Me.tlsBarra.Size = New System.Drawing.Size(1006, 27)
        Me.tlsBarra.TabIndex = 136
        Me.tlsBarra.Text = "ToolStrip1"
        '
        'tlsIncrementar
        '
        Me.tlsIncrementar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsIncrementar.Image = CType(resources.GetObject("tlsIncrementar.Image"), System.Drawing.Image)
        Me.tlsIncrementar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsIncrementar.Name = "tlsIncrementar"
        Me.tlsIncrementar.Size = New System.Drawing.Size(24, 24)
        Me.tlsIncrementar.Text = "Incrementar"
        '
        'tlsDecrementar
        '
        Me.tlsDecrementar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsDecrementar.Image = CType(resources.GetObject("tlsDecrementar.Image"), System.Drawing.Image)
        Me.tlsDecrementar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsDecrementar.Name = "tlsDecrementar"
        Me.tlsDecrementar.Size = New System.Drawing.Size(24, 24)
        Me.tlsDecrementar.Text = "Decrementar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tlsCancelar
        '
        Me.tlsCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsCancelar.Image = CType(resources.GetObject("tlsCancelar.Image"), System.Drawing.Image)
        Me.tlsCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsCancelar.Name = "tlsCancelar"
        Me.tlsCancelar.Size = New System.Drawing.Size(24, 24)
        Me.tlsCancelar.Text = "Cancelar Ensaio"
        Me.tlsCancelar.ToolTipText = "Cancelar Ensaio"
        '
        'tlsFinalizar
        '
        Me.tlsFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsFinalizar.Image = CType(resources.GetObject("tlsFinalizar.Image"), System.Drawing.Image)
        Me.tlsFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsFinalizar.Name = "tlsFinalizar"
        Me.tlsFinalizar.Size = New System.Drawing.Size(24, 24)
        Me.tlsFinalizar.Text = "Finalizar Ensaio"
        '
        'tlsSeparador1
        '
        Me.tlsSeparador1.Name = "tlsSeparador1"
        Me.tlsSeparador1.Size = New System.Drawing.Size(6, 27)
        '
        'tlsRelatorio
        '
        Me.tlsRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsRelatorio.Image = CType(resources.GetObject("tlsRelatorio.Image"), System.Drawing.Image)
        Me.tlsRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsRelatorio.Name = "tlsRelatorio"
        Me.tlsRelatorio.Size = New System.Drawing.Size(24, 24)
        Me.tlsRelatorio.Text = "Gerar Relatório"
        '
        'tlsSair
        '
        Me.tlsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tlsSair.Image = CType(resources.GetObject("tlsSair.Image"), System.Drawing.Image)
        Me.tlsSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsSair.Name = "tlsSair"
        Me.tlsSair.Size = New System.Drawing.Size(24, 24)
        Me.tlsSair.Text = "Sair Ensaio"
        '
        'lblSeparadorSetpoint
        '
        Me.lblSeparadorSetpoint.Name = "lblSeparadorSetpoint"
        Me.lblSeparadorSetpoint.Size = New System.Drawing.Size(6, 27)
        '
        'lblLegendaSepoint
        '
        Me.lblLegendaSepoint.Name = "lblLegendaSepoint"
        Me.lblLegendaSepoint.Size = New System.Drawing.Size(54, 24)
        Me.lblLegendaSepoint.Text = "Setpoint:"
        '
        'lblSetpointCarga
        '
        Me.lblSetpointCarga.Name = "lblSetpointCarga"
        Me.lblSetpointCarga.Size = New System.Drawing.Size(27, 24)
        Me.lblSetpointCarga.Text = "----"
        '
        'lblSeparadorOutput
        '
        Me.lblSeparadorOutput.Name = "lblSeparadorOutput"
        Me.lblSeparadorOutput.Size = New System.Drawing.Size(6, 27)
        '
        'lblLegendaOutput
        '
        Me.lblLegendaOutput.Name = "lblLegendaOutput"
        Me.lblLegendaOutput.Size = New System.Drawing.Size(84, 24)
        Me.lblLegendaOutput.Text = "Output Motor:"
        '
        'lblOutputMotor
        '
        Me.lblOutputMotor.Name = "lblOutputMotor"
        Me.lblOutputMotor.Size = New System.Drawing.Size(27, 24)
        Me.lblOutputMotor.Text = "----"
        '
        'lblSeparadorErroPID
        '
        Me.lblSeparadorErroPID.Name = "lblSeparadorErroPID"
        Me.lblSeparadorErroPID.Size = New System.Drawing.Size(6, 27)
        '
        'lblLegendaErroPID
        '
        Me.lblLegendaErroPID.Name = "lblLegendaErroPID"
        Me.lblLegendaErroPID.Size = New System.Drawing.Size(52, 24)
        Me.lblLegendaErroPID.Text = "Erro PID:"
        '
        'lblErroPID
        '
        Me.lblErroPID.Name = "lblErroPID"
        Me.lblErroPID.Size = New System.Drawing.Size(27, 24)
        Me.lblErroPID.Text = "----"
        '
        'lblSeparadorIntervalo1
        '
        Me.lblSeparadorIntervalo1.Name = "lblSeparadorIntervalo1"
        Me.lblSeparadorIntervalo1.Size = New System.Drawing.Size(6, 27)
        '
        'lblLegendaIntervalo1
        '
        Me.lblLegendaIntervalo1.Name = "lblLegendaIntervalo1"
        Me.lblLegendaIntervalo1.Size = New System.Drawing.Size(91, 24)
        Me.lblLegendaIntervalo1.Text = "Intervalo (MPa):"
        '
        'lblIncrementoMPa
        '
        Me.lblIncrementoMPa.Name = "lblIncrementoMPa"
        Me.lblIncrementoMPa.Size = New System.Drawing.Size(27, 24)
        Me.lblIncrementoMPa.Text = "----"
        '
        'lblSeparadorIntervalo2
        '
        Me.lblSeparadorIntervalo2.Name = "lblSeparadorIntervalo2"
        Me.lblSeparadorIntervalo2.Size = New System.Drawing.Size(6, 27)
        '
        'lblLegendaIntervalo2
        '
        Me.lblLegendaIntervalo2.Name = "lblLegendaIntervalo2"
        Me.lblLegendaIntervalo2.Size = New System.Drawing.Size(84, 24)
        Me.lblLegendaIntervalo2.Text = "Intervalo (kgf):"
        '
        'lblIncrementokgf
        '
        Me.lblIncrementokgf.Name = "lblIncrementokgf"
        Me.lblIncrementokgf.Size = New System.Drawing.Size(27, 24)
        Me.lblIncrementokgf.Text = "----"
        '
        'lblSeparadorReset
        '
        Me.lblSeparadorReset.Name = "lblSeparadorReset"
        Me.lblSeparadorReset.Size = New System.Drawing.Size(6, 27)
        '
        'lblResetDisplay
        '
        Me.lblResetDisplay.IsLink = True
        Me.lblResetDisplay.LinkColor = System.Drawing.Color.Black
        Me.lblResetDisplay.Name = "lblResetDisplay"
        Me.lblResetDisplay.Size = New System.Drawing.Size(76, 24)
        Me.lblResetDisplay.Text = "Reset Display"
        Me.lblResetDisplay.ToolTipText = "Reset Display"
        Me.lblResetDisplay.Visible = False
        Me.lblResetDisplay.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'mnuMenu
        '
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EixosToolStripMenuItem, Me.EscalaToolStripMenuItem, Me.mnuEnsaiar, Me.mnuRelatorio1, Me.mnuAjustes})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuMenu.Size = New System.Drawing.Size(1006, 24)
        Me.mnuMenu.TabIndex = 135
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'EixosToolStripMenuItem
        '
        Me.EixosToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EixosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Teste1ToolStripMenuItem, Me.CustomizarEixosToolStripMenuItem})
        Me.EixosToolStripMenuItem.Name = "EixosToolStripMenuItem"
        Me.EixosToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.EixosToolStripMenuItem.Text = "Eixos"
        '
        'Teste1ToolStripMenuItem
        '
        Me.Teste1ToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Teste1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEixoX1, Me.mnuEixoY1, Me.mnuEixoY2})
        Me.Teste1ToolStripMenuItem.Name = "Teste1ToolStripMenuItem"
        Me.Teste1ToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.Teste1ToolStripMenuItem.Text = "Eixos De Leitura"
        '
        'mnuEixoX1
        '
        Me.mnuEixoX1.Name = "mnuEixoX1"
        Me.mnuEixoX1.Size = New System.Drawing.Size(111, 22)
        Me.mnuEixoX1.Text = "Eixo X"
        '
        'mnuEixoY1
        '
        Me.mnuEixoY1.Name = "mnuEixoY1"
        Me.mnuEixoY1.Size = New System.Drawing.Size(111, 22)
        Me.mnuEixoY1.Text = "Eixo Y1"
        '
        'mnuEixoY2
        '
        Me.mnuEixoY2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEixoY2GrandezaConvertida, Me.RemoverEixoY2ToolStripMenuItem})
        Me.mnuEixoY2.Name = "mnuEixoY2"
        Me.mnuEixoY2.Size = New System.Drawing.Size(111, 22)
        Me.mnuEixoY2.Text = "Eixo Y2"
        '
        'mnuEixoY2GrandezaConvertida
        '
        Me.mnuEixoY2GrandezaConvertida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuEixoY2GrandezaConvertida.Name = "mnuEixoY2GrandezaConvertida"
        Me.mnuEixoY2GrandezaConvertida.Size = New System.Drawing.Size(184, 22)
        Me.mnuEixoY2GrandezaConvertida.Text = "Grandeza Convertida"
        '
        'RemoverEixoY2ToolStripMenuItem
        '
        Me.RemoverEixoY2ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoverEixoY2ToolStripMenuItem.Name = "RemoverEixoY2ToolStripMenuItem"
        Me.RemoverEixoY2ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RemoverEixoY2ToolStripMenuItem.Text = "Remover Eixo Y2"
        '
        'CustomizarEixosToolStripMenuItem
        '
        Me.CustomizarEixosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNovaLinhaY1, Me.mnuLinhaTracejada, Me.mnuRemoverCurva, Me.RotacionarGrafico, Me.ResetarEixosToolStripMenuItem})
        Me.CustomizarEixosToolStripMenuItem.Name = "CustomizarEixosToolStripMenuItem"
        Me.CustomizarEixosToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CustomizarEixosToolStripMenuItem.Text = "Customizar Eixos"
        '
        'mnuNovaLinhaY1
        '
        Me.mnuNovaLinhaY1.Name = "mnuNovaLinhaY1"
        Me.mnuNovaLinhaY1.Size = New System.Drawing.Size(212, 22)
        Me.mnuNovaLinhaY1.Text = "Adicionar Curva Contínua"
        '
        'mnuLinhaTracejada
        '
        Me.mnuLinhaTracejada.Name = "mnuLinhaTracejada"
        Me.mnuLinhaTracejada.Size = New System.Drawing.Size(212, 22)
        Me.mnuLinhaTracejada.Text = "Adicionar Curva Tracejada"
        '
        'mnuRemoverCurva
        '
        Me.mnuRemoverCurva.Name = "mnuRemoverCurva"
        Me.mnuRemoverCurva.Size = New System.Drawing.Size(212, 22)
        Me.mnuRemoverCurva.Text = "Remover Curva"
        '
        'RotacionarGrafico
        '
        Me.RotacionarGrafico.Name = "RotacionarGrafico"
        Me.RotacionarGrafico.Size = New System.Drawing.Size(212, 22)
        Me.RotacionarGrafico.Text = "Rotacionar Gráfico"
        '
        'ResetarEixosToolStripMenuItem
        '
        Me.ResetarEixosToolStripMenuItem.Name = "ResetarEixosToolStripMenuItem"
        Me.ResetarEixosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ResetarEixosToolStripMenuItem.Text = "Resetar Eixos"
        Me.ResetarEixosToolStripMenuItem.Visible = False
        '
        'EscalaToolStripMenuItem
        '
        Me.EscalaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EscalaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAjusteEscalaAutomatico, Me.mnuAjusteEscalaManual})
        Me.EscalaToolStripMenuItem.Name = "EscalaToolStripMenuItem"
        Me.EscalaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
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
        Me.mnuAutoEixoX.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoXEscalaMin0, Me.mnuAutoEixoXEscalaMinMenor, Me.mnuAutoEixoTempoOrigemFixa, Me.mnuAutoEixoTempoOrigemDinamica})
        Me.mnuAutoEixoX.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoEixoX.Name = "mnuAutoEixoX"
        Me.mnuAutoEixoX.Size = New System.Drawing.Size(206, 22)
        Me.mnuAutoEixoX.Text = "Eixo X"
        '
        'mnuAutoEixoXEscalaMin0
        '
        Me.mnuAutoEixoXEscalaMin0.CheckOnClick = True
        Me.mnuAutoEixoXEscalaMin0.Name = "mnuAutoEixoXEscalaMin0"
        Me.mnuAutoEixoXEscalaMin0.Size = New System.Drawing.Size(269, 22)
        Me.mnuAutoEixoXEscalaMin0.Text = "Escala Mínima = 0"
        '
        'mnuAutoEixoXEscalaMinMenor
        '
        Me.mnuAutoEixoXEscalaMinMenor.CheckOnClick = True
        Me.mnuAutoEixoXEscalaMinMenor.Name = "mnuAutoEixoXEscalaMinMenor"
        Me.mnuAutoEixoXEscalaMinMenor.Size = New System.Drawing.Size(269, 22)
        Me.mnuAutoEixoXEscalaMinMenor.Text = "Escala Mínima = Menor Valor"
        '
        'mnuAutoEixoTempoOrigemFixa
        '
        Me.mnuAutoEixoTempoOrigemFixa.CheckOnClick = True
        Me.mnuAutoEixoTempoOrigemFixa.Name = "mnuAutoEixoTempoOrigemFixa"
        Me.mnuAutoEixoTempoOrigemFixa.Size = New System.Drawing.Size(269, 22)
        Me.mnuAutoEixoTempoOrigemFixa.Text = "Escala de Tempo = Origem Fixa"
        '
        'mnuAutoEixoTempoOrigemDinamica
        '
        Me.mnuAutoEixoTempoOrigemDinamica.CheckOnClick = True
        Me.mnuAutoEixoTempoOrigemDinamica.Name = "mnuAutoEixoTempoOrigemDinamica"
        Me.mnuAutoEixoTempoOrigemDinamica.Size = New System.Drawing.Size(269, 22)
        Me.mnuAutoEixoTempoOrigemDinamica.Text = "Escala de Tempo = Origem Dinâmica"
        '
        'mnuAutoEixoY1
        '
        Me.mnuAutoEixoY1.Checked = True
        Me.mnuAutoEixoY1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAutoEixoY1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoY1EscalaMin0, Me.mnuAutoEixoY1EscalaMinMenor})
        Me.mnuAutoEixoY1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoEixoY1.Name = "mnuAutoEixoY1"
        Me.mnuAutoEixoY1.Size = New System.Drawing.Size(206, 22)
        Me.mnuAutoEixoY1.Text = "Eixo Y1"
        '
        'mnuAutoEixoY1EscalaMin0
        '
        Me.mnuAutoEixoY1EscalaMin0.CheckOnClick = True
        Me.mnuAutoEixoY1EscalaMin0.Name = "mnuAutoEixoY1EscalaMin0"
        Me.mnuAutoEixoY1EscalaMin0.Size = New System.Drawing.Size(228, 22)
        Me.mnuAutoEixoY1EscalaMin0.Text = "Escala Mínima = 0"
        '
        'mnuAutoEixoY1EscalaMinMenor
        '
        Me.mnuAutoEixoY1EscalaMinMenor.CheckOnClick = True
        Me.mnuAutoEixoY1EscalaMinMenor.Name = "mnuAutoEixoY1EscalaMinMenor"
        Me.mnuAutoEixoY1EscalaMinMenor.Size = New System.Drawing.Size(228, 22)
        Me.mnuAutoEixoY1EscalaMinMenor.Text = "Escala Mínima = Menor Valor"
        '
        'mnuAutoEixoY2
        '
        Me.mnuAutoEixoY2.Checked = True
        Me.mnuAutoEixoY2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAutoEixoY2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoEixoY2EscalaMin0, Me.mnuAutoEixoY2EscalaMinMenor})
        Me.mnuAutoEixoY2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoEixoY2.Name = "mnuAutoEixoY2"
        Me.mnuAutoEixoY2.Size = New System.Drawing.Size(206, 22)
        Me.mnuAutoEixoY2.Text = "Eixo Y2"
        '
        'mnuAutoEixoY2EscalaMin0
        '
        Me.mnuAutoEixoY2EscalaMin0.CheckOnClick = True
        Me.mnuAutoEixoY2EscalaMin0.Name = "mnuAutoEixoY2EscalaMin0"
        Me.mnuAutoEixoY2EscalaMin0.Size = New System.Drawing.Size(228, 22)
        Me.mnuAutoEixoY2EscalaMin0.Text = "Escala Mínima = 0"
        '
        'mnuAutoEixoY2EscalaMinMenor
        '
        Me.mnuAutoEixoY2EscalaMinMenor.CheckOnClick = True
        Me.mnuAutoEixoY2EscalaMinMenor.Name = "mnuAutoEixoY2EscalaMinMenor"
        Me.mnuAutoEixoY2EscalaMinMenor.Size = New System.Drawing.Size(228, 22)
        Me.mnuAutoEixoY2EscalaMinMenor.Text = "Escala Mínima = Menor Valor"
        '
        'mnuAutoTodosEixos
        '
        Me.mnuAutoTodosEixos.CheckOnClick = True
        Me.mnuAutoTodosEixos.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAutoTodosEixos.Name = "mnuAutoTodosEixos"
        Me.mnuAutoTodosEixos.Size = New System.Drawing.Size(206, 22)
        Me.mnuAutoTodosEixos.Text = "Todos Eixos Automaticos"
        '
        'mnuAjusteEscalaManual
        '
        Me.mnuAjusteEscalaManual.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManualX, Me.mnuManualY1, Me.mnuManualY2, Me.mnuTodosEixosManuais})
        Me.mnuAjusteEscalaManual.Name = "mnuAjusteEscalaManual"
        Me.mnuAjusteEscalaManual.Size = New System.Drawing.Size(180, 22)
        Me.mnuAjusteEscalaManual.Text = "Ajuste Manual"
        '
        'mnuManualX
        '
        Me.mnuManualX.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblLegendaMinimoX, Me.txtMinimoX, Me.ToolStripSeparator6, Me.lblLegendaMaximoX, Me.txtMaximoX, Me.ToolStripSeparator7, Me.lblLegendaSubidivisaoX, Me.txtSubdivisaoX, Me.ToolStripSeparator8, Me.btnAplicarAjustesEscalaX})
        Me.mnuManualX.Name = "mnuManualX"
        Me.mnuManualX.Size = New System.Drawing.Size(183, 22)
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
        Me.mnuManualY1.Size = New System.Drawing.Size(183, 22)
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
        Me.mnuManualY2.Size = New System.Drawing.Size(183, 22)
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
        'mnuTodosEixosManuais
        '
        Me.mnuTodosEixosManuais.CheckOnClick = True
        Me.mnuTodosEixosManuais.Name = "mnuTodosEixosManuais"
        Me.mnuTodosEixosManuais.Size = New System.Drawing.Size(183, 22)
        Me.mnuTodosEixosManuais.Text = "Todos Eixos Manuais"
        '
        'mnuEnsaiar
        '
        Me.mnuEnsaiar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIncrementar, Me.mnuDecrementar, Me.mnuParar, Me.mnuEstabilizar, Me.mnuCancelar, Me.mnuFinalizar, Me.mnuSeparador, Me.mnuRegressao, Me.mnuSair})
        Me.mnuEnsaiar.Name = "mnuEnsaiar"
        Me.mnuEnsaiar.Size = New System.Drawing.Size(53, 20)
        Me.mnuEnsaiar.Text = "&Ensaio"
        '
        'mnuIncrementar
        '
        Me.mnuIncrementar.Image = CType(resources.GetObject("mnuIncrementar.Image"), System.Drawing.Image)
        Me.mnuIncrementar.Name = "mnuIncrementar"
        Me.mnuIncrementar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuIncrementar.Size = New System.Drawing.Size(175, 22)
        Me.mnuIncrementar.Text = "Incrementar"
        Me.mnuIncrementar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mnuDecrementar
        '
        Me.mnuDecrementar.Image = CType(resources.GetObject("mnuDecrementar.Image"), System.Drawing.Image)
        Me.mnuDecrementar.Name = "mnuDecrementar"
        Me.mnuDecrementar.Size = New System.Drawing.Size(175, 22)
        Me.mnuDecrementar.Text = "Decrementar"
        '
        'mnuParar
        '
        Me.mnuParar.Name = "mnuParar"
        Me.mnuParar.Size = New System.Drawing.Size(175, 22)
        Me.mnuParar.Text = "Parar"
        '
        'mnuEstabilizar
        '
        Me.mnuEstabilizar.Name = "mnuEstabilizar"
        Me.mnuEstabilizar.Size = New System.Drawing.Size(175, 22)
        Me.mnuEstabilizar.Text = "Estabilizar"
        '
        'mnuCancelar
        '
        Me.mnuCancelar.Image = CType(resources.GetObject("mnuCancelar.Image"), System.Drawing.Image)
        Me.mnuCancelar.Name = "mnuCancelar"
        Me.mnuCancelar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCancelar.Size = New System.Drawing.Size(175, 22)
        Me.mnuCancelar.Text = "Cancelar"
        '
        'mnuFinalizar
        '
        Me.mnuFinalizar.Image = CType(resources.GetObject("mnuFinalizar.Image"), System.Drawing.Image)
        Me.mnuFinalizar.Name = "mnuFinalizar"
        Me.mnuFinalizar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFinalizar.Size = New System.Drawing.Size(175, 22)
        Me.mnuFinalizar.Text = "Finalizar"
        '
        'mnuSeparador
        '
        Me.mnuSeparador.Name = "mnuSeparador"
        Me.mnuSeparador.Size = New System.Drawing.Size(172, 6)
        '
        'mnuRegressao
        '
        Me.mnuRegressao.Name = "mnuRegressao"
        Me.mnuRegressao.Size = New System.Drawing.Size(175, 22)
        Me.mnuRegressao.Text = "Regreesão Linear"
        '
        'mnuSair
        '
        Me.mnuSair.Image = CType(resources.GetObject("mnuSair.Image"), System.Drawing.Image)
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSair.Size = New System.Drawing.Size(175, 22)
        Me.mnuSair.Text = "Sair"
        '
        'mnuRelatorio1
        '
        Me.mnuRelatorio1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRelatorio2})
        Me.mnuRelatorio1.Name = "mnuRelatorio1"
        Me.mnuRelatorio1.Size = New System.Drawing.Size(66, 20)
        Me.mnuRelatorio1.Text = "Relatório"
        '
        'mnuRelatorio2
        '
        Me.mnuRelatorio2.Image = CType(resources.GetObject("mnuRelatorio2.Image"), System.Drawing.Image)
        Me.mnuRelatorio2.Name = "mnuRelatorio2"
        Me.mnuRelatorio2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRelatorio2.Size = New System.Drawing.Size(193, 22)
        Me.mnuRelatorio2.Text = "Gerar Relatório"
        '
        'mnuAjustes
        '
        Me.mnuAjustes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuKP_Deslocamento, Me.mnuKP_Incremento, Me.mnuBounce, Me.mnuErrorAdjust, Me.mnuSampleTime, Me.mnuMinimoAjuste})
        Me.mnuAjustes.Name = "mnuAjustes"
        Me.mnuAjustes.Size = New System.Drawing.Size(57, 20)
        Me.mnuAjustes.Text = "Ajustes"
        '
        'mnuKP_Deslocamento
        '
        Me.mnuKP_Deslocamento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtKP_Deslocamento, Me.btnEnviarKP_Deslocamento})
        Me.mnuKP_Deslocamento.Name = "mnuKP_Deslocamento"
        Me.mnuKP_Deslocamento.Size = New System.Drawing.Size(194, 22)
        Me.mnuKP_Deslocamento.Text = "KP (Deslocamento)"
        '
        'txtKP_Deslocamento
        '
        Me.txtKP_Deslocamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKP_Deslocamento.Name = "txtKP_Deslocamento"
        Me.txtKP_Deslocamento.Size = New System.Drawing.Size(100, 23)
        '
        'btnEnviarKP_Deslocamento
        '
        Me.btnEnviarKP_Deslocamento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEnviarKP_Deslocamento.Name = "btnEnviarKP_Deslocamento"
        Me.btnEnviarKP_Deslocamento.Size = New System.Drawing.Size(160, 22)
        Me.btnEnviarKP_Deslocamento.Text = "Enviar"
        Me.btnEnviarKP_Deslocamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'mnuKP_Incremento
        '
        Me.mnuKP_Incremento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtKP_Incremento, Me.btnEnviarKP_Incremento})
        Me.mnuKP_Incremento.Name = "mnuKP_Incremento"
        Me.mnuKP_Incremento.Size = New System.Drawing.Size(194, 22)
        Me.mnuKP_Incremento.Text = "KP (Incremento Carga)"
        '
        'txtKP_Incremento
        '
        Me.txtKP_Incremento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKP_Incremento.Name = "txtKP_Incremento"
        Me.txtKP_Incremento.Size = New System.Drawing.Size(100, 23)
        '
        'btnEnviarKP_Incremento
        '
        Me.btnEnviarKP_Incremento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEnviarKP_Incremento.Name = "btnEnviarKP_Incremento"
        Me.btnEnviarKP_Incremento.Size = New System.Drawing.Size(160, 22)
        Me.btnEnviarKP_Incremento.Text = "Enviar"
        Me.btnEnviarKP_Incremento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'mnuBounce
        '
        Me.mnuBounce.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtBounceBreak, Me.btnEnviarBounceBreak})
        Me.mnuBounce.Name = "mnuBounce"
        Me.mnuBounce.Size = New System.Drawing.Size(194, 22)
        Me.mnuBounce.Text = "Bounce Break"
        '
        'txtBounceBreak
        '
        Me.txtBounceBreak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBounceBreak.Name = "txtBounceBreak"
        Me.txtBounceBreak.Size = New System.Drawing.Size(100, 23)
        '
        'btnEnviarBounceBreak
        '
        Me.btnEnviarBounceBreak.Name = "btnEnviarBounceBreak"
        Me.btnEnviarBounceBreak.Size = New System.Drawing.Size(160, 22)
        Me.btnEnviarBounceBreak.Text = "Enviar"
        '
        'mnuErrorAdjust
        '
        Me.mnuErrorAdjust.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtErrorAdjust, Me.btnEnviarErrorAdjust})
        Me.mnuErrorAdjust.Name = "mnuErrorAdjust"
        Me.mnuErrorAdjust.Size = New System.Drawing.Size(194, 22)
        Me.mnuErrorAdjust.Text = "Error Adjust"
        '
        'txtErrorAdjust
        '
        Me.txtErrorAdjust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtErrorAdjust.Name = "txtErrorAdjust"
        Me.txtErrorAdjust.Size = New System.Drawing.Size(100, 23)
        '
        'btnEnviarErrorAdjust
        '
        Me.btnEnviarErrorAdjust.Name = "btnEnviarErrorAdjust"
        Me.btnEnviarErrorAdjust.Size = New System.Drawing.Size(160, 22)
        Me.btnEnviarErrorAdjust.Text = "Enviar"
        '
        'mnuSampleTime
        '
        Me.mnuSampleTime.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSampleTime, Me.btnEnviarSampleTime})
        Me.mnuSampleTime.Name = "mnuSampleTime"
        Me.mnuSampleTime.Size = New System.Drawing.Size(194, 22)
        Me.mnuSampleTime.Text = "Sample Time"
        '
        'txtSampleTime
        '
        Me.txtSampleTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSampleTime.Name = "txtSampleTime"
        Me.txtSampleTime.Size = New System.Drawing.Size(100, 23)
        '
        'btnEnviarSampleTime
        '
        Me.btnEnviarSampleTime.Name = "btnEnviarSampleTime"
        Me.btnEnviarSampleTime.Size = New System.Drawing.Size(160, 22)
        Me.btnEnviarSampleTime.Text = "Enviar"
        '
        'mnuMinimoAjuste
        '
        Me.mnuMinimoAjuste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtMinimoAjuste, Me.btnEnviarMinimoAjuste})
        Me.mnuMinimoAjuste.Name = "mnuMinimoAjuste"
        Me.mnuMinimoAjuste.Size = New System.Drawing.Size(194, 22)
        Me.mnuMinimoAjuste.Text = "Mínimo Ajuste"
        '
        'txtMinimoAjuste
        '
        Me.txtMinimoAjuste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinimoAjuste.Name = "txtMinimoAjuste"
        Me.txtMinimoAjuste.Size = New System.Drawing.Size(100, 23)
        '
        'btnEnviarMinimoAjuste
        '
        Me.btnEnviarMinimoAjuste.Name = "btnEnviarMinimoAjuste"
        Me.btnEnviarMinimoAjuste.Size = New System.Drawing.Size(160, 22)
        Me.btnEnviarMinimoAjuste.Text = "Enviar"
        '
        'grpMovimentacao
        '
        Me.grpMovimentacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpMovimentacao.Controls.Add(Me.btnEstabilizar)
        Me.grpMovimentacao.Controls.Add(Me.btnParar)
        Me.grpMovimentacao.Controls.Add(Me.btnIncrementar)
        Me.grpMovimentacao.Controls.Add(Me.lblAdvertencia)
        Me.grpMovimentacao.Controls.Add(Me.btnDecrementar)
        Me.grpMovimentacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMovimentacao.ForeColor = System.Drawing.Color.Black
        Me.grpMovimentacao.Location = New System.Drawing.Point(640, 450)
        Me.grpMovimentacao.Name = "grpMovimentacao"
        Me.grpMovimentacao.Size = New System.Drawing.Size(287, 119)
        Me.grpMovimentacao.TabIndex = 148
        Me.grpMovimentacao.TabStop = False
        Me.grpMovimentacao.Text = "Comandos de Movimentação"
        '
        'btnEstabilizar
        '
        Me.btnEstabilizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEstabilizar.FlatAppearance.BorderSize = 2
        Me.btnEstabilizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstabilizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEstabilizar.Location = New System.Drawing.Point(94, 71)
        Me.btnEstabilizar.Name = "btnEstabilizar"
        Me.btnEstabilizar.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.btnEstabilizar.Size = New System.Drawing.Size(98, 26)
        Me.btnEstabilizar.TabIndex = 143
        Me.btnEstabilizar.Text = "&Estabilizar Carga"
        Me.btnEstabilizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEstabilizar.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnParar.FlatAppearance.BorderSize = 2
        Me.btnParar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnParar.Location = New System.Drawing.Point(94, 40)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.btnParar.Size = New System.Drawing.Size(98, 26)
        Me.btnParar.TabIndex = 144
        Me.btnParar.Text = "Parar"
        Me.btnParar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'btnIncrementar
        '
        Me.btnIncrementar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIncrementar.FlatAppearance.BorderSize = 2
        Me.btnIncrementar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncrementar.Image = CType(resources.GetObject("btnIncrementar.Image"), System.Drawing.Image)
        Me.btnIncrementar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIncrementar.Location = New System.Drawing.Point(6, 40)
        Me.btnIncrementar.Name = "btnIncrementar"
        Me.btnIncrementar.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.btnIncrementar.Size = New System.Drawing.Size(83, 58)
        Me.btnIncrementar.TabIndex = 2
        Me.btnIncrementar.Text = "&Incrementar"
        Me.btnIncrementar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIncrementar.UseVisualStyleBackColor = True
        '
        'lblAdvertencia
        '
        Me.lblAdvertencia.AutoSize = True
        Me.lblAdvertencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvertencia.ForeColor = System.Drawing.Color.Firebrick
        Me.lblAdvertencia.Location = New System.Drawing.Point(9, 13)
        Me.lblAdvertencia.Name = "lblAdvertencia"
        Me.lblAdvertencia.Size = New System.Drawing.Size(65, 12)
        Me.lblAdvertencia.TabIndex = 3
        Me.lblAdvertencia.Text = "Advertência..."
        Me.lblAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAdvertencia.Visible = False
        '
        'btnDecrementar
        '
        Me.btnDecrementar.Enabled = False
        Me.btnDecrementar.FlatAppearance.BorderSize = 2
        Me.btnDecrementar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrementar.Image = CType(resources.GetObject("btnDecrementar.Image"), System.Drawing.Image)
        Me.btnDecrementar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDecrementar.Location = New System.Drawing.Point(198, 38)
        Me.btnDecrementar.Name = "btnDecrementar"
        Me.btnDecrementar.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.btnDecrementar.Size = New System.Drawing.Size(83, 58)
        Me.btnDecrementar.TabIndex = 138
        Me.btnDecrementar.Text = "&Decrementar"
        Me.btnDecrementar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDecrementar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizar.FlatAppearance.BorderSize = 2
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Image = CType(resources.GetObject("btnFinalizar.Image"), System.Drawing.Image)
        Me.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFinalizar.Location = New System.Drawing.Point(92, 40)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.btnFinalizar.Size = New System.Drawing.Size(83, 58)
        Me.btnFinalizar.TabIndex = 4
        Me.btnFinalizar.Text = "&Finalizar"
        Me.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(6, 40)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(0, 1, 0, 2)
        Me.btnCancelar.Size = New System.Drawing.Size(83, 58)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(918, 542)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnSair.Size = New System.Drawing.Size(86, 26)
        Me.btnSair.TabIndex = 147
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.Image = CType(resources.GetObject("btnRelatorio.Image"), System.Drawing.Image)
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRelatorio.Location = New System.Drawing.Point(918, 500)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnRelatorio.Size = New System.Drawing.Size(86, 26)
        Me.btnRelatorio.TabIndex = 145
        Me.btnRelatorio.Text = "&Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'grpFinalizacao
        '
        Me.grpFinalizacao.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpFinalizacao.Controls.Add(Me.btnFinalizar)
        Me.grpFinalizacao.Controls.Add(Me.btnCancelar)
        Me.grpFinalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFinalizacao.ForeColor = System.Drawing.Color.Black
        Me.grpFinalizacao.Location = New System.Drawing.Point(453, 450)
        Me.grpFinalizacao.Name = "grpFinalizacao"
        Me.grpFinalizacao.Size = New System.Drawing.Size(182, 119)
        Me.grpFinalizacao.TabIndex = 144
        Me.grpFinalizacao.TabStop = False
        Me.grpFinalizacao.Text = "Finalização"
        '
        'tmrLeituras
        '
        Me.tmrLeituras.Interval = 500
        '
        'spPortaSerial
        '
        Me.spPortaSerial.BaudRate = 115200
        Me.spPortaSerial.ReadTimeout = 200
        Me.spPortaSerial.RtsEnable = True
        Me.spPortaSerial.WriteTimeout = 200
        '
        'lblMensagem
        '
        Me.lblMensagem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensagem.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensagem.ForeColor = System.Drawing.Color.White
        Me.lblMensagem.Location = New System.Drawing.Point(6, 409)
        Me.lblMensagem.Name = "lblMensagem"
        Me.lblMensagem.Size = New System.Drawing.Size(994, 25)
        Me.lblMensagem.TabIndex = 149
        Me.lblMensagem.Text = "Mensagem"
        Me.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCondicaoEnsaio
        '
        Me.grpCondicaoEnsaio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCondicaoEnsaio.Controls.Add(Me.chkFinalizacaoAposPenetracao)
        Me.grpCondicaoEnsaio.Controls.Add(Me.chkIniciarGraficoAposCargaMinima)
        Me.grpCondicaoEnsaio.Controls.Add(Me.txtCargaMinimaLimite)
        Me.grpCondicaoEnsaio.Controls.Add(Me.Label6)
        Me.grpCondicaoEnsaio.Controls.Add(Me.btnCondicoesEnsaio)
        Me.grpCondicaoEnsaio.Controls.Add(Me.txtPenetracaoLimite)
        Me.grpCondicaoEnsaio.Controls.Add(Me.Label1)
        Me.grpCondicaoEnsaio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondicaoEnsaio.Location = New System.Drawing.Point(758, 257)
        Me.grpCondicaoEnsaio.Name = "grpCondicaoEnsaio"
        Me.grpCondicaoEnsaio.Size = New System.Drawing.Size(242, 131)
        Me.grpCondicaoEnsaio.TabIndex = 150
        Me.grpCondicaoEnsaio.TabStop = False
        Me.grpCondicaoEnsaio.Text = "Condições de Ensaio"
        '
        'chkFinalizacaoAposPenetracao
        '
        Me.chkFinalizacaoAposPenetracao.AutoSize = True
        Me.chkFinalizacaoAposPenetracao.Checked = True
        Me.chkFinalizacaoAposPenetracao.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFinalizacaoAposPenetracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFinalizacaoAposPenetracao.Location = New System.Drawing.Point(6, 58)
        Me.chkFinalizacaoAposPenetracao.Name = "chkFinalizacaoAposPenetracao"
        Me.chkFinalizacaoAposPenetracao.Size = New System.Drawing.Size(196, 17)
        Me.chkFinalizacaoAposPenetracao.TabIndex = 7
        Me.chkFinalizacaoAposPenetracao.Text = "Finalizar ensaio após penetração de"
        Me.chkFinalizacaoAposPenetracao.UseVisualStyleBackColor = True
        '
        'chkIniciarGraficoAposCargaMinima
        '
        Me.chkIniciarGraficoAposCargaMinima.AutoSize = True
        Me.chkIniciarGraficoAposCargaMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIniciarGraficoAposCargaMinima.Location = New System.Drawing.Point(6, 17)
        Me.chkIniciarGraficoAposCargaMinima.Name = "chkIniciarGraficoAposCargaMinima"
        Me.chkIniciarGraficoAposCargaMinima.Size = New System.Drawing.Size(203, 17)
        Me.chkIniciarGraficoAposCargaMinima.TabIndex = 7
        Me.chkIniciarGraficoAposCargaMinima.Text = "Iniciar gráfico e zerar as leituras após:"
        Me.chkIniciarGraficoAposCargaMinima.UseVisualStyleBackColor = True
        '
        'txtCargaMinimaLimite
        '
        Me.txtCargaMinimaLimite.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargaMinimaLimite.ForeColor = System.Drawing.Color.Blue
        Me.txtCargaMinimaLimite.Location = New System.Drawing.Point(86, 34)
        Me.txtCargaMinimaLimite.Name = "txtCargaMinimaLimite"
        Me.txtCargaMinimaLimite.Size = New System.Drawing.Size(69, 22)
        Me.txtCargaMinimaLimite.TabIndex = 6
        Me.txtCargaMinimaLimite.Text = "5"
        Me.txtCargaMinimaLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "(kgf)"
        '
        'btnCondicoesEnsaio
        '
        Me.btnCondicoesEnsaio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCondicoesEnsaio.Location = New System.Drawing.Point(81, 102)
        Me.btnCondicoesEnsaio.Name = "btnCondicoesEnsaio"
        Me.btnCondicoesEnsaio.Size = New System.Drawing.Size(80, 22)
        Me.btnCondicoesEnsaio.TabIndex = 3
        Me.btnCondicoesEnsaio.Text = "&Enviar"
        Me.btnCondicoesEnsaio.UseVisualStyleBackColor = True
        '
        'txtPenetracaoLimite
        '
        Me.txtPenetracaoLimite.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenetracaoLimite.ForeColor = System.Drawing.Color.Blue
        Me.txtPenetracaoLimite.Location = New System.Drawing.Point(86, 75)
        Me.txtPenetracaoLimite.Name = "txtPenetracaoLimite"
        Me.txtPenetracaoLimite.Size = New System.Drawing.Size(69, 22)
        Me.txtPenetracaoLimite.TabIndex = 2
        Me.txtPenetracaoLimite.Text = "12,70"
        Me.txtPenetracaoLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "(mm)"
        '
        'grpResultados
        '
        Me.grpResultados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.grpResultados.Location = New System.Drawing.Point(933, 450)
        Me.grpResultados.Name = "grpResultados"
        Me.grpResultados.Size = New System.Drawing.Size(326, 119)
        Me.grpResultados.TabIndex = 152
        Me.grpResultados.TabStop = False
        Me.grpResultados.Text = "Resultados"
        '
        'txtISC1
        '
        Me.txtISC1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtISC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtISC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISC1.Location = New System.Drawing.Point(259, 76)
        Me.txtISC1.Name = "txtISC1"
        Me.txtISC1.ReadOnly = True
        Me.txtISC1.Size = New System.Drawing.Size(64, 20)
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
        Me.Label14.Location = New System.Drawing.Point(3, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(68, 28)
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
        Me.txtPadrao1.Location = New System.Drawing.Point(196, 76)
        Me.txtPadrao1.Name = "txtPadrao1"
        Me.txtPadrao1.ReadOnly = True
        Me.txtPadrao1.Size = New System.Drawing.Size(64, 20)
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
        Me.txtFixo0.Location = New System.Drawing.Point(3, 57)
        Me.txtFixo0.Name = "txtFixo0"
        Me.txtFixo0.ReadOnly = True
        Me.txtFixo0.Size = New System.Drawing.Size(68, 20)
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
        Me.txtCorrigida1.Location = New System.Drawing.Point(133, 76)
        Me.txtCorrigida1.Name = "txtCorrigida1"
        Me.txtCorrigida1.ReadOnly = True
        Me.txtCorrigida1.Size = New System.Drawing.Size(64, 20)
        Me.txtCorrigida1.TabIndex = 357
        Me.txtCorrigida1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFixo1
        '
        Me.txtFixo1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFixo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFixo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFixo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixo1.Location = New System.Drawing.Point(3, 76)
        Me.txtFixo1.Name = "txtFixo1"
        Me.txtFixo1.ReadOnly = True
        Me.txtFixo1.Size = New System.Drawing.Size(68, 20)
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
        Me.txtISC0.Location = New System.Drawing.Point(259, 57)
        Me.txtISC0.Name = "txtISC0"
        Me.txtISC0.ReadOnly = True
        Me.txtISC0.Size = New System.Drawing.Size(64, 20)
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
        Me.Label4.Location = New System.Drawing.Point(70, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(64, 28)
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
        Me.txtPadrao0.Location = New System.Drawing.Point(196, 57)
        Me.txtPadrao0.Name = "txtPadrao0"
        Me.txtPadrao0.ReadOnly = True
        Me.txtPadrao0.Size = New System.Drawing.Size(64, 20)
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
        Me.Label22.Location = New System.Drawing.Point(133, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(64, 28)
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
        Me.txtCorrigida0.Location = New System.Drawing.Point(133, 57)
        Me.txtCorrigida0.Name = "txtCorrigida0"
        Me.txtCorrigida0.ReadOnly = True
        Me.txtCorrigida0.Size = New System.Drawing.Size(64, 20)
        Me.txtCorrigida0.TabIndex = 356
        Me.txtCorrigida0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(196, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(64, 28)
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
        Me.Label15.Location = New System.Drawing.Point(259, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(64, 28)
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
        Me.txtCalculada0.Location = New System.Drawing.Point(70, 57)
        Me.txtCalculada0.Name = "txtCalculada0"
        Me.txtCalculada0.ReadOnly = True
        Me.txtCalculada0.Size = New System.Drawing.Size(64, 20)
        Me.txtCalculada0.TabIndex = 366
        Me.txtCalculada0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCalculada1
        '
        Me.txtCalculada1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCalculada1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCalculada1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalculada1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalculada1.Location = New System.Drawing.Point(70, 76)
        Me.txtCalculada1.Name = "txtCalculada1"
        Me.txtCalculada1.ReadOnly = True
        Me.txtCalculada1.Size = New System.Drawing.Size(64, 20)
        Me.txtCalculada1.TabIndex = 367
        Me.txtCalculada1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnviarVelocidade
        '
        Me.btnEnviarVelocidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarVelocidade.Location = New System.Drawing.Point(110, 86)
        Me.btnEnviarVelocidade.Name = "btnEnviarVelocidade"
        Me.btnEnviarVelocidade.Size = New System.Drawing.Size(48, 22)
        Me.btnEnviarVelocidade.TabIndex = 6
        Me.btnEnviarVelocidade.Text = "&Enviar"
        Me.btnEnviarVelocidade.UseVisualStyleBackColor = True
        '
        'txtVelocidade
        '
        Me.txtVelocidade.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelocidade.ForeColor = System.Drawing.Color.Blue
        Me.txtVelocidade.Location = New System.Drawing.Point(34, 89)
        Me.txtVelocidade.Name = "txtVelocidade"
        Me.txtVelocidade.Size = New System.Drawing.Size(69, 22)
        Me.txtVelocidade.TabIndex = 5
        Me.txtVelocidade.Text = "1,27"
        Me.txtVelocidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlPanel
        '
        Me.pnlPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Location = New System.Drawing.Point(-4, 438)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(1105, 10)
        Me.pnlPanel.TabIndex = 156
        '
        'tmrReposicionar
        '
        Me.tmrReposicionar.Interval = 1000
        '
        'lblMsgErro
        '
        Me.lblMsgErro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMsgErro.BackColor = System.Drawing.Color.Red
        Me.lblMsgErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgErro.ForeColor = System.Drawing.Color.White
        Me.lblMsgErro.Location = New System.Drawing.Point(6, 409)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.Size = New System.Drawing.Size(994, 25)
        Me.lblMsgErro.TabIndex = 157
        Me.lblMsgErro.Text = "Erro"
        Me.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsgErro.Visible = False
        '
        'grpStatus
        '
        Me.grpStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpStatus.Controls.Add(Me.lblReposicionamento)
        Me.grpStatus.Controls.Add(Me.lblConexaoCelula)
        Me.grpStatus.Controls.Add(Me.lblSetpointDescendo)
        Me.grpStatus.Controls.Add(Me.lblSetpointSubindo)
        Me.grpStatus.Controls.Add(Me.lblThresholdDeslocamento)
        Me.grpStatus.Controls.Add(Me.lblThresholdCarga)
        Me.grpStatus.Controls.Add(Me.lblSobrecurso)
        Me.grpStatus.Controls.Add(Me.lblSobrecarga)
        Me.grpStatus.Controls.Add(Me.lblDescendo)
        Me.grpStatus.Controls.Add(Me.lblModoRemotoLocal)
        Me.grpStatus.Controls.Add(Me.lblPID)
        Me.grpStatus.Controls.Add(Me.lblSubindo)
        Me.grpStatus.Controls.Add(Me.lblEmergencia)
        Me.grpStatus.Controls.Add(Me.lblFimCurso)
        Me.grpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatus.ForeColor = System.Drawing.Color.Black
        Me.grpStatus.Location = New System.Drawing.Point(6, 450)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(242, 119)
        Me.grpStatus.TabIndex = 158
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Status"
        '
        'lblReposicionamento
        '
        Me.lblReposicionamento.AutoSize = True
        Me.lblReposicionamento.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReposicionamento.ForeColor = System.Drawing.Color.Gray
        Me.lblReposicionamento.Location = New System.Drawing.Point(130, 103)
        Me.lblReposicionamento.Name = "lblReposicionamento"
        Me.lblReposicionamento.Size = New System.Drawing.Size(90, 11)
        Me.lblReposicionamento.TabIndex = 200
        Me.lblReposicionamento.Text = "Reposicionamento"
        Me.lblReposicionamento.Visible = False
        '
        'lblConexaoCelula
        '
        Me.lblConexaoCelula.AutoSize = True
        Me.lblConexaoCelula.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexaoCelula.ForeColor = System.Drawing.Color.Gray
        Me.lblConexaoCelula.Location = New System.Drawing.Point(130, 89)
        Me.lblConexaoCelula.Name = "lblConexaoCelula"
        Me.lblConexaoCelula.Size = New System.Drawing.Size(107, 11)
        Me.lblConexaoCelula.TabIndex = 198
        Me.lblConexaoCelula.Text = "Conexão Célula Carga"
        Me.lblConexaoCelula.Visible = False
        '
        'lblSetpointDescendo
        '
        Me.lblSetpointDescendo.AutoSize = True
        Me.lblSetpointDescendo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetpointDescendo.ForeColor = System.Drawing.Color.Gray
        Me.lblSetpointDescendo.Location = New System.Drawing.Point(130, 44)
        Me.lblSetpointDescendo.Name = "lblSetpointDescendo"
        Me.lblSetpointDescendo.Size = New System.Drawing.Size(91, 11)
        Me.lblSetpointDescendo.TabIndex = 197
        Me.lblSetpointDescendo.Text = "Setpoint Descendo"
        '
        'lblSetpointSubindo
        '
        Me.lblSetpointSubindo.AutoSize = True
        Me.lblSetpointSubindo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetpointSubindo.ForeColor = System.Drawing.Color.Gray
        Me.lblSetpointSubindo.Location = New System.Drawing.Point(130, 30)
        Me.lblSetpointSubindo.Name = "lblSetpointSubindo"
        Me.lblSetpointSubindo.Size = New System.Drawing.Size(85, 11)
        Me.lblSetpointSubindo.TabIndex = 196
        Me.lblSetpointSubindo.Text = "Setpoint Subindo"
        '
        'lblThresholdDeslocamento
        '
        Me.lblThresholdDeslocamento.AutoSize = True
        Me.lblThresholdDeslocamento.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThresholdDeslocamento.ForeColor = System.Drawing.Color.Gray
        Me.lblThresholdDeslocamento.Location = New System.Drawing.Point(4, 103)
        Me.lblThresholdDeslocamento.Name = "lblThresholdDeslocamento"
        Me.lblThresholdDeslocamento.Size = New System.Drawing.Size(88, 11)
        Me.lblThresholdDeslocamento.TabIndex = 195
        Me.lblThresholdDeslocamento.Text = "Threshold Desloc."
        '
        'lblThresholdCarga
        '
        Me.lblThresholdCarga.AutoSize = True
        Me.lblThresholdCarga.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThresholdCarga.ForeColor = System.Drawing.Color.Gray
        Me.lblThresholdCarga.Location = New System.Drawing.Point(4, 89)
        Me.lblThresholdCarga.Name = "lblThresholdCarga"
        Me.lblThresholdCarga.Size = New System.Drawing.Size(81, 11)
        Me.lblThresholdCarga.TabIndex = 195
        Me.lblThresholdCarga.Text = "Threshold Carga"
        '
        'lblSobrecurso
        '
        Me.lblSobrecurso.AutoSize = True
        Me.lblSobrecurso.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrecurso.ForeColor = System.Drawing.Color.Gray
        Me.lblSobrecurso.Location = New System.Drawing.Point(4, 74)
        Me.lblSobrecurso.Name = "lblSobrecurso"
        Me.lblSobrecurso.Size = New System.Drawing.Size(58, 11)
        Me.lblSobrecurso.TabIndex = 195
        Me.lblSobrecurso.Text = "Sobrecurso"
        '
        'lblSobrecarga
        '
        Me.lblSobrecarga.AutoSize = True
        Me.lblSobrecarga.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSobrecarga.ForeColor = System.Drawing.Color.Gray
        Me.lblSobrecarga.Location = New System.Drawing.Point(4, 59)
        Me.lblSobrecarga.Name = "lblSobrecarga"
        Me.lblSobrecarga.Size = New System.Drawing.Size(57, 11)
        Me.lblSobrecarga.TabIndex = 194
        Me.lblSobrecarga.Text = "Sobrecarga"
        '
        'lblDescendo
        '
        Me.lblDescendo.AutoSize = True
        Me.lblDescendo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescendo.ForeColor = System.Drawing.Color.Gray
        Me.lblDescendo.Location = New System.Drawing.Point(130, 74)
        Me.lblDescendo.Name = "lblDescendo"
        Me.lblDescendo.Size = New System.Drawing.Size(84, 11)
        Me.lblDescendo.TabIndex = 151
        Me.lblDescendo.Text = "Prensa Descendo"
        '
        'lblModoRemotoLocal
        '
        Me.lblModoRemotoLocal.AutoSize = True
        Me.lblModoRemotoLocal.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModoRemotoLocal.ForeColor = System.Drawing.Color.Gray
        Me.lblModoRemotoLocal.Location = New System.Drawing.Point(4, 14)
        Me.lblModoRemotoLocal.Name = "lblModoRemotoLocal"
        Me.lblModoRemotoLocal.Size = New System.Drawing.Size(99, 11)
        Me.lblModoRemotoLocal.TabIndex = 150
        Me.lblModoRemotoLocal.Text = "Modo Manual (Local)"
        '
        'lblPID
        '
        Me.lblPID.AutoSize = True
        Me.lblPID.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPID.ForeColor = System.Drawing.Color.Gray
        Me.lblPID.Location = New System.Drawing.Point(130, 14)
        Me.lblPID.Name = "lblPID"
        Me.lblPID.Size = New System.Drawing.Size(70, 11)
        Me.lblPID.TabIndex = 149
        Me.lblPID.Text = "PID Desligado"
        '
        'lblSubindo
        '
        Me.lblSubindo.AutoSize = True
        Me.lblSubindo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubindo.ForeColor = System.Drawing.Color.Gray
        Me.lblSubindo.Location = New System.Drawing.Point(130, 59)
        Me.lblSubindo.Name = "lblSubindo"
        Me.lblSubindo.Size = New System.Drawing.Size(78, 11)
        Me.lblSubindo.TabIndex = 149
        Me.lblSubindo.Text = "Prensa Subindo"
        '
        'lblEmergencia
        '
        Me.lblEmergencia.AutoSize = True
        Me.lblEmergencia.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencia.ForeColor = System.Drawing.Color.Gray
        Me.lblEmergencia.Location = New System.Drawing.Point(4, 44)
        Me.lblEmergencia.Name = "lblEmergencia"
        Me.lblEmergencia.Size = New System.Drawing.Size(58, 11)
        Me.lblEmergencia.TabIndex = 147
        Me.lblEmergencia.Text = "Emergência"
        '
        'lblFimCurso
        '
        Me.lblFimCurso.AutoSize = True
        Me.lblFimCurso.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFimCurso.ForeColor = System.Drawing.Color.Gray
        Me.lblFimCurso.Location = New System.Drawing.Point(4, 30)
        Me.lblFimCurso.Name = "lblFimCurso"
        Me.lblFimCurso.Size = New System.Drawing.Size(67, 11)
        Me.lblFimCurso.TabIndex = 144
        Me.lblFimCurso.Text = "Fim de Curso"
        '
        'grpVelocidadeEnsaio
        '
        Me.grpVelocidadeEnsaio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpVelocidadeEnsaio.Controls.Add(Me.btnEnviarVelocidade)
        Me.grpVelocidadeEnsaio.Controls.Add(Me.rdbModoDeslocamento)
        Me.grpVelocidadeEnsaio.Controls.Add(Me.txtVelocidade)
        Me.grpVelocidadeEnsaio.Controls.Add(Me.rdbModoIncrementoCarga)
        Me.grpVelocidadeEnsaio.Controls.Add(Me.lblUnidadeTaxaPrensa)
        Me.grpVelocidadeEnsaio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpVelocidadeEnsaio.ForeColor = System.Drawing.Color.Black
        Me.grpVelocidadeEnsaio.Location = New System.Drawing.Point(254, 450)
        Me.grpVelocidadeEnsaio.Name = "grpVelocidadeEnsaio"
        Me.grpVelocidadeEnsaio.Size = New System.Drawing.Size(193, 119)
        Me.grpVelocidadeEnsaio.TabIndex = 159
        Me.grpVelocidadeEnsaio.TabStop = False
        Me.grpVelocidadeEnsaio.Text = "Velocidade de Ensaio"
        '
        'rdbModoDeslocamento
        '
        Me.rdbModoDeslocamento.AutoSize = True
        Me.rdbModoDeslocamento.Checked = True
        Me.rdbModoDeslocamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModoDeslocamento.Location = New System.Drawing.Point(5, 18)
        Me.rdbModoDeslocamento.Name = "rdbModoDeslocamento"
        Me.rdbModoDeslocamento.Size = New System.Drawing.Size(175, 17)
        Me.rdbModoDeslocamento.TabIndex = 21
        Me.rdbModoDeslocamento.TabStop = True
        Me.rdbModoDeslocamento.Text = "Deslocamento Prensa (mm/min)"
        Me.rdbModoDeslocamento.UseVisualStyleBackColor = True
        '
        'rdbModoIncrementoCarga
        '
        Me.rdbModoIncrementoCarga.AutoSize = True
        Me.rdbModoIncrementoCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModoIncrementoCarga.Location = New System.Drawing.Point(5, 40)
        Me.rdbModoIncrementoCarga.Name = "rdbModoIncrementoCarga"
        Me.rdbModoIncrementoCarga.Size = New System.Drawing.Size(158, 17)
        Me.rdbModoIncrementoCarga.TabIndex = 21
        Me.rdbModoIncrementoCarga.Text = "Incremento de Carga (kgf/s)"
        Me.rdbModoIncrementoCarga.UseVisualStyleBackColor = True
        '
        'lblUnidadeTaxaPrensa
        '
        Me.lblUnidadeTaxaPrensa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblUnidadeTaxaPrensa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidadeTaxaPrensa.Location = New System.Drawing.Point(43, 66)
        Me.lblUnidadeTaxaPrensa.Name = "lblUnidadeTaxaPrensa"
        Me.lblUnidadeTaxaPrensa.Size = New System.Drawing.Size(106, 20)
        Me.lblUnidadeTaxaPrensa.TabIndex = 20
        Me.lblUnidadeTaxaPrensa.Text = "Taxa (min/min)"
        Me.lblUnidadeTaxaPrensa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbGrafico
        '
        Me.grbGrafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbGrafico.Controls.Add(Me.WinChartViewer1)
        Me.grbGrafico.Location = New System.Drawing.Point(6, 51)
        Me.grbGrafico.Name = "grbGrafico"
        Me.grbGrafico.Size = New System.Drawing.Size(745, 354)
        Me.grbGrafico.TabIndex = 138
        Me.grbGrafico.TabStop = False
        '
        'WinChartViewer1
        '
        Me.WinChartViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WinChartViewer1.Location = New System.Drawing.Point(6, 12)
        Me.WinChartViewer1.Name = "WinChartViewer1"
        Me.WinChartViewer1.Size = New System.Drawing.Size(732, 335)
        Me.WinChartViewer1.TabIndex = 0
        Me.WinChartViewer1.TabStop = False
        '
        'btnCalcularRegressão
        '
        Me.btnCalcularRegressão.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularRegressão.Enabled = False
        Me.btnCalcularRegressão.Image = CType(resources.GetObject("btnCalcularRegressão.Image"), System.Drawing.Image)
        Me.btnCalcularRegressão.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcularRegressão.Location = New System.Drawing.Point(918, 458)
        Me.btnCalcularRegressão.Name = "btnCalcularRegressão"
        Me.btnCalcularRegressão.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.btnCalcularRegressão.Size = New System.Drawing.Size(86, 26)
        Me.btnCalcularRegressão.TabIndex = 326
        Me.btnCalcularRegressão.Text = "   Corrigir"
        Me.btnCalcularRegressão.UseVisualStyleBackColor = True
        '
        'barStatus
        '
        Me.barStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barStatus.Location = New System.Drawing.Point(6, 409)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(994, 25)
        Me.barStatus.Step = 1
        Me.barStatus.TabIndex = 327
        Me.barStatus.Visible = False
        '
        'frmGraficoPavitest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1006, 574)
        Me.Controls.Add(Me.grpMovimentacao)
        Me.Controls.Add(Me.grpResultados)
        Me.Controls.Add(Me.barStatus)
        Me.Controls.Add(Me.btnCalcularRegressão)
        Me.Controls.Add(Me.grpFinalizacao)
        Me.Controls.Add(Me.grpVelocidadeEnsaio)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.lblMsgErro)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.grpCondicaoEnsaio)
        Me.Controls.Add(Me.lblMensagem)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.grpLeituras)
        Me.Controls.Add(Me.tlsBarra)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(Me.mnuMenu)
        Me.Controls.Add(Me.grbGrafico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGraficoPavitest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pavitest Índice de Suporte Califórnia - Ensaio"
        Me.grpLeituras.ResumeLayout(False)
        Me.grpLeituras.PerformLayout()
        CType(Me.pctZerarCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctZerarPenetracao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPiscar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPiscar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsBarra.ResumeLayout(False)
        Me.tlsBarra.PerformLayout()
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.grpMovimentacao.ResumeLayout(False)
        Me.grpMovimentacao.PerformLayout()
        Me.grpFinalizacao.ResumeLayout(False)
        Me.grpCondicaoEnsaio.ResumeLayout(False)
        Me.grpCondicaoEnsaio.PerformLayout()
        Me.grpResultados.ResumeLayout(False)
        Me.grpResultados.PerformLayout()
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.grpVelocidadeEnsaio.ResumeLayout(False)
        Me.grpVelocidadeEnsaio.PerformLayout()
        Me.grbGrafico.ResumeLayout(False)
        CType(Me.WinChartViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLeituras As System.Windows.Forms.GroupBox
    Public WithEvents pctZerarCarga As System.Windows.Forms.PictureBox
    Friend WithEvents lblPenetracao As System.Windows.Forms.Label
    Friend WithEvents lblLabel3 As System.Windows.Forms.Label
    Friend WithEvents lblPressao As System.Windows.Forms.Label
    Friend WithEvents lblLegendaPressao As System.Windows.Forms.Label
    Friend WithEvents lblCarga As System.Windows.Forms.Label
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Public WithEvents pctZerarPenetracao As System.Windows.Forms.PictureBox
    Friend WithEvents tlsBarra As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsIncrementar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsDecrementar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsFinalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsRelatorio As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSair As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEnsaiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIncrementar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuParar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDecrementar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFinalizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelatorio1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRelatorio2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpMovimentacao As System.Windows.Forms.GroupBox
    Friend WithEvents btnIncrementar As System.Windows.Forms.Button
    Friend WithEvents lblAdvertencia As System.Windows.Forms.Label
    Friend WithEvents btnDecrementar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents grpFinalizacao As System.Windows.Forms.GroupBox
    Friend WithEvents tmrLeituras As System.Windows.Forms.Timer
    Friend WithEvents spPortaSerial As System.IO.Ports.SerialPort
    Friend WithEvents lblMensagem As System.Windows.Forms.Label
    Friend WithEvents grpCondicaoEnsaio As System.Windows.Forms.GroupBox
    Friend WithEvents btnCondicoesEnsaio As System.Windows.Forms.Button
    Friend WithEvents txtPenetracaoLimite As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpResultados As System.Windows.Forms.GroupBox
    Friend WithEvents txtISC1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPadrao1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCorrigida1 As System.Windows.Forms.TextBox
    Friend WithEvents txtISC0 As System.Windows.Forms.TextBox
    Friend WithEvents txtPadrao0 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCorrigida0 As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCalculada1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCalculada0 As System.Windows.Forms.TextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFixo1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFixo0 As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents pctPiscar1 As System.Windows.Forms.PictureBox
    Public WithEvents pctPiscar2 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuRegressao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCargaMinimaLimite As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnEnviarVelocidade As System.Windows.Forms.Button
    Friend WithEvents txtVelocidade As System.Windows.Forms.TextBox
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Public WithEvents tmrReposicionar As System.Windows.Forms.Timer
    Friend WithEvents lblMsgErro As Label
    Friend WithEvents mnuAjustes As ToolStripMenuItem
    Friend WithEvents mnuKP_Deslocamento As ToolStripMenuItem
    Friend WithEvents txtKP_Deslocamento As ToolStripTextBox
    Friend WithEvents btnEnviarKP_Deslocamento As ToolStripMenuItem
    Friend WithEvents mnuBounce As ToolStripMenuItem
    Friend WithEvents txtBounceBreak As ToolStripTextBox
    Friend WithEvents btnEnviarBounceBreak As ToolStripMenuItem
    Friend WithEvents mnuErrorAdjust As ToolStripMenuItem
    Friend WithEvents txtErrorAdjust As ToolStripTextBox
    Friend WithEvents btnEnviarErrorAdjust As ToolStripMenuItem
    Friend WithEvents mnuSampleTime As ToolStripMenuItem
    Friend WithEvents txtSampleTime As ToolStripTextBox
    Friend WithEvents btnEnviarSampleTime As ToolStripMenuItem
    Friend WithEvents mnuMinimoAjuste As ToolStripMenuItem
    Friend WithEvents txtMinimoAjuste As ToolStripTextBox
    Friend WithEvents btnEnviarMinimoAjuste As ToolStripMenuItem
    Friend WithEvents btnEstabilizar As Button
    Friend WithEvents btnParar As Button
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents lblReposicionamento As Label
    Friend WithEvents lblConexaoCelula As Label
    Friend WithEvents lblSetpointDescendo As Label
    Friend WithEvents lblSetpointSubindo As Label
    Friend WithEvents lblThresholdDeslocamento As Label
    Friend WithEvents lblThresholdCarga As Label
    Friend WithEvents lblSobrecurso As Label
    Friend WithEvents lblSobrecarga As Label
    Friend WithEvents lblDescendo As Label
    Friend WithEvents lblModoRemotoLocal As Label
    Friend WithEvents lblPID As Label
    Friend WithEvents lblSubindo As Label
    Friend WithEvents lblEmergencia As Label
    Friend WithEvents lblFimCurso As Label
    Friend WithEvents grpVelocidadeEnsaio As GroupBox
    Friend WithEvents rdbModoDeslocamento As RadioButton
    Friend WithEvents rdbModoIncrementoCarga As RadioButton
    Friend WithEvents lblUnidadeTaxaPrensa As Label
    Friend WithEvents lblSeparadorSetpoint As ToolStripSeparator
    Friend WithEvents lblLegendaSepoint As ToolStripLabel
    Friend WithEvents lblSetpointCarga As ToolStripLabel
    Friend WithEvents lblSeparadorOutput As ToolStripSeparator
    Friend WithEvents lblLegendaOutput As ToolStripLabel
    Friend WithEvents lblOutputMotor As ToolStripLabel
    Friend WithEvents lblSeparadorErroPID As ToolStripSeparator
    Friend WithEvents lblLegendaErroPID As ToolStripLabel
    Friend WithEvents lblErroPID As ToolStripLabel
    Friend WithEvents lblSeparadorIntervalo1 As ToolStripSeparator
    Friend WithEvents lblLegendaIntervalo1 As ToolStripLabel
    Friend WithEvents lblIncrementoMPa As ToolStripLabel
    Friend WithEvents lblSeparadorIntervalo2 As ToolStripSeparator
    Friend WithEvents lblLegendaIntervalo2 As ToolStripLabel
    Friend WithEvents lblIncrementokgf As ToolStripLabel
    Friend WithEvents lblSeparadorReset As ToolStripSeparator
    Friend WithEvents lblResetDisplay As ToolStripLabel
    Friend WithEvents grbGrafico As GroupBox
    Friend WithEvents chkIniciarGraficoAposCargaMinima As CheckBox
    Friend WithEvents chkFinalizacaoAposPenetracao As CheckBox
    Friend WithEvents mnuKP_Incremento As ToolStripMenuItem
    Friend WithEvents txtKP_Incremento As ToolStripTextBox
    Friend WithEvents btnEnviarKP_Incremento As ToolStripMenuItem
    Friend WithEvents btnCalcularRegressão As Button
    Friend WithEvents mnuEstabilizar As ToolStripMenuItem
    Friend WithEvents WinChartViewer1 As ChartDirector.WinChartViewer
    Friend WithEvents EixosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Teste1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEixoX1 As ToolStripMenuItem
    Friend WithEvents mnuEixoY1 As ToolStripMenuItem
    Friend WithEvents mnuEixoY2 As ToolStripMenuItem
    Friend WithEvents mnuEixoY2GrandezaConvertida As ToolStripMenuItem
    Friend WithEvents RemoverEixoY2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizarEixosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNovaLinhaY1 As ToolStripMenuItem
    Friend WithEvents mnuLinhaTracejada As ToolStripMenuItem
    Friend WithEvents mnuRemoverCurva As ToolStripMenuItem
    Friend WithEvents RotacionarGrafico As ToolStripMenuItem
    Friend WithEvents ResetarEixosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscalaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAjusteEscalaAutomatico As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoX As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoXEscalaMin0 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoXEscalaMinMenor As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoTempoOrigemFixa As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoTempoOrigemDinamica As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY1 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY1EscalaMin0 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY1EscalaMinMenor As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY2 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY2EscalaMin0 As ToolStripMenuItem
    Friend WithEvents mnuAutoEixoY2EscalaMinMenor As ToolStripMenuItem
    Friend WithEvents mnuAutoTodosEixos As ToolStripMenuItem
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
    Friend WithEvents mnuTodosEixosManuais As ToolStripMenuItem
    Friend WithEvents barStatus As ProgressBar
End Class
