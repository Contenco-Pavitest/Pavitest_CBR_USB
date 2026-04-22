<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalibracao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalibracao))
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.spPortaSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.btnOffSet = New System.Windows.Forms.Button()
        Me.barStatus = New System.Windows.Forms.ProgressBar()
        Me.btnSalvarCalibracao = New System.Windows.Forms.Button()
        Me.btnLigar = New System.Windows.Forms.Button()
        Me.grbPrincipal = New System.Windows.Forms.GroupBox()
        Me.grpLeituraAdicional = New System.Windows.Forms.GroupBox()
        Me.lblLeituraAdicional = New System.Windows.Forms.Label()
        Me.lblSituacaoEnsaio = New System.Windows.Forms.Label()
        Me.lblConexaoCelula = New System.Windows.Forms.Label()
        Me.lblStatusComandoEscrita = New System.Windows.Forms.Label()
        Me.lblPID = New System.Windows.Forms.Label()
        Me.lblStatusFaixaCarga = New System.Windows.Forms.Label()
        Me.lblStatusFaixaCurso = New System.Windows.Forms.Label()
        Me.lblStatusModoLocalRemoto = New System.Windows.Forms.Label()
        Me.lblSetpoint = New System.Windows.Forms.Label()
        Me.lblSubindoDescendo = New System.Windows.Forms.Label()
        Me.lblEmergencia = New System.Windows.Forms.Label()
        Me.lblFimCursoSuperior = New System.Windows.Forms.Label()
        Me.lblFimCursoInferior = New System.Windows.Forms.Label()
        Me.grpGroupSelecionado = New System.Windows.Forms.GroupBox()
        Me.btnVeloc_1 = New System.Windows.Forms.Button()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.btnDescer = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.txtVeloc_1 = New System.Windows.Forms.TextBox()
        Me.lblVeloc_1 = New System.Windows.Forms.Label()
        Me.lblVeloc_5 = New System.Windows.Forms.Label()
        Me.btnVeloc_2 = New System.Windows.Forms.Button()
        Me.lblVeloc_4 = New System.Windows.Forms.Label()
        Me.txtVeloc_2 = New System.Windows.Forms.TextBox()
        Me.lblVeloc_2 = New System.Windows.Forms.Label()
        Me.btnVeloc_3 = New System.Windows.Forms.Button()
        Me.txtVeloc_5 = New System.Windows.Forms.TextBox()
        Me.txtVeloc_3 = New System.Windows.Forms.TextBox()
        Me.btnVeloc_5 = New System.Windows.Forms.Button()
        Me.lblVeloc_3 = New System.Windows.Forms.Label()
        Me.txtVeloc_4 = New System.Windows.Forms.TextBox()
        Me.btnVeloc_4 = New System.Windows.Forms.Button()
        Me.grbAjusteCalibracao = New System.Windows.Forms.GroupBox()
        Me.lblLeitura = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLegendaLeitura = New System.Windows.Forms.Label()
        Me.lblLabel12 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.txtConst = New System.Windows.Forms.TextBox()
        Me.lblSensor = New System.Windows.Forms.Label()
        Me.txtOffSet = New System.Windows.Forms.TextBox()
        Me.grpOutputMotor = New System.Windows.Forms.GroupBox()
        Me.lblOutputMotor = New System.Windows.Forms.Label()
        Me.grpTaxa = New System.Windows.Forms.GroupBox()
        Me.txtTaxa = New System.Windows.Forms.TextBox()
        Me.btnEnviarTaxa = New System.Windows.Forms.Button()
        Me.grpOperacao = New System.Windows.Forms.GroupBox()
        Me.rdbModoDeslocamentoPID = New System.Windows.Forms.RadioButton()
        Me.rdbModoIncremento = New System.Windows.Forms.RadioButton()
        Me.rdbModoVelocidadePercentual = New System.Windows.Forms.RadioButton()
        Me.grpInstrumentos = New System.Windows.Forms.GroupBox()
        Me.rdbDeslocamento = New System.Windows.Forms.RadioButton()
        Me.rdbCarga = New System.Windows.Forms.RadioButton()
        Me.grpLocalRemoto = New System.Windows.Forms.GroupBox()
        Me.rdbRemoto = New System.Windows.Forms.RadioButton()
        Me.rdbLocal = New System.Windows.Forms.RadioButton()
        Me.tmrCalibracao = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLimparErros = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPanel.SuspendLayout()
        Me.grbPrincipal.SuspendLayout()
        Me.grpLeituraAdicional.SuspendLayout()
        Me.grpGroupSelecionado.SuspendLayout()
        Me.grbAjusteCalibracao.SuspendLayout()
        Me.grpOutputMotor.SuspendLayout()
        Me.grpTaxa.SuspendLayout()
        Me.grpOperacao.SuspendLayout()
        Me.grpInstrumentos.SuspendLayout()
        Me.grpLocalRemoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMsgErro
        '
        Me.lblMsgErro.BackColor = System.Drawing.Color.Red
        Me.lblMsgErro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMsgErro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgErro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMsgErro.Location = New System.Drawing.Point(16, 544)
        Me.lblMsgErro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMsgErro.Size = New System.Drawing.Size(565, 39)
        Me.lblMsgErro.TabIndex = 58
        Me.lblMsgErro.Text = "Erro"
        Me.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsgErro.Visible = False
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(589, 548)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(125, 32)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'spPortaSerial
        '
        Me.spPortaSerial.BaudRate = 115200
        Me.spPortaSerial.ReadTimeout = 200
        Me.spPortaSerial.RtsEnable = True
        Me.spPortaSerial.WriteTimeout = 200
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnOffSet)
        Me.pnlPanel.Controls.Add(Me.barStatus)
        Me.pnlPanel.Controls.Add(Me.btnSalvarCalibracao)
        Me.pnlPanel.Controls.Add(Me.btnLigar)
        Me.pnlPanel.Location = New System.Drawing.Point(9, 475)
        Me.pnlPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(677, 41)
        Me.pnlPanel.TabIndex = 129
        '
        'btnOffSet
        '
        Me.btnOffSet.Enabled = False
        Me.btnOffSet.Location = New System.Drawing.Point(415, 4)
        Me.btnOffSet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOffSet.Name = "btnOffSet"
        Me.btnOffSet.Size = New System.Drawing.Size(124, 32)
        Me.btnOffSet.TabIndex = 32
        Me.btnOffSet.Text = "Offset"
        Me.btnOffSet.UseVisualStyleBackColor = True
        '
        'barStatus
        '
        Me.barStatus.Location = New System.Drawing.Point(5, 4)
        Me.barStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(271, 32)
        Me.barStatus.Step = 1
        Me.barStatus.TabIndex = 31
        Me.barStatus.Visible = False
        '
        'btnSalvarCalibracao
        '
        Me.btnSalvarCalibracao.Enabled = False
        Me.btnSalvarCalibracao.Location = New System.Drawing.Point(284, 4)
        Me.btnSalvarCalibracao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvarCalibracao.Name = "btnSalvarCalibracao"
        Me.btnSalvarCalibracao.Size = New System.Drawing.Size(124, 32)
        Me.btnSalvarCalibracao.TabIndex = 30
        Me.btnSalvarCalibracao.Text = "Salvar Dados"
        Me.btnSalvarCalibracao.UseVisualStyleBackColor = True
        '
        'btnLigar
        '
        Me.btnLigar.Location = New System.Drawing.Point(545, 4)
        Me.btnLigar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLigar.Name = "btnLigar"
        Me.btnLigar.Size = New System.Drawing.Size(124, 32)
        Me.btnLigar.TabIndex = 29
        Me.btnLigar.Text = "Ligar >>"
        Me.btnLigar.UseVisualStyleBackColor = True
        '
        'grbPrincipal
        '
        Me.grbPrincipal.Controls.Add(Me.grpLeituraAdicional)
        Me.grbPrincipal.Controls.Add(Me.lblSituacaoEnsaio)
        Me.grbPrincipal.Controls.Add(Me.lblConexaoCelula)
        Me.grbPrincipal.Controls.Add(Me.lblStatusComandoEscrita)
        Me.grbPrincipal.Controls.Add(Me.lblPID)
        Me.grbPrincipal.Controls.Add(Me.lblStatusFaixaCarga)
        Me.grbPrincipal.Controls.Add(Me.lblStatusFaixaCurso)
        Me.grbPrincipal.Controls.Add(Me.lblStatusModoLocalRemoto)
        Me.grbPrincipal.Controls.Add(Me.lblSetpoint)
        Me.grbPrincipal.Controls.Add(Me.lblSubindoDescendo)
        Me.grbPrincipal.Controls.Add(Me.lblEmergencia)
        Me.grbPrincipal.Controls.Add(Me.lblFimCursoSuperior)
        Me.grbPrincipal.Controls.Add(Me.lblFimCursoInferior)
        Me.grbPrincipal.Controls.Add(Me.grpGroupSelecionado)
        Me.grbPrincipal.Controls.Add(Me.pnlPanel)
        Me.grbPrincipal.Controls.Add(Me.grbAjusteCalibracao)
        Me.grbPrincipal.Controls.Add(Me.grpOutputMotor)
        Me.grbPrincipal.Controls.Add(Me.grpTaxa)
        Me.grbPrincipal.Controls.Add(Me.grpOperacao)
        Me.grbPrincipal.Controls.Add(Me.grpInstrumentos)
        Me.grbPrincipal.Controls.Add(Me.grpLocalRemoto)
        Me.grbPrincipal.ForeColor = System.Drawing.Color.Black
        Me.grbPrincipal.Location = New System.Drawing.Point(16, 15)
        Me.grbPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbPrincipal.Name = "grbPrincipal"
        Me.grbPrincipal.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbPrincipal.Size = New System.Drawing.Size(696, 526)
        Me.grbPrincipal.TabIndex = 125
        Me.grbPrincipal.TabStop = False
        '
        'grpLeituraAdicional
        '
        Me.grpLeituraAdicional.Controls.Add(Me.lblLeituraAdicional)
        Me.grpLeituraAdicional.Enabled = False
        Me.grpLeituraAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLeituraAdicional.ForeColor = System.Drawing.Color.Black
        Me.grpLeituraAdicional.Location = New System.Drawing.Point(512, 197)
        Me.grpLeituraAdicional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLeituraAdicional.Name = "grpLeituraAdicional"
        Me.grpLeituraAdicional.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLeituraAdicional.Size = New System.Drawing.Size(175, 78)
        Me.grpLeituraAdicional.TabIndex = 150
        Me.grpLeituraAdicional.TabStop = False
        Me.grpLeituraAdicional.Text = "Deslocamento (mm)"
        '
        'lblLeituraAdicional
        '
        Me.lblLeituraAdicional.BackColor = System.Drawing.Color.Transparent
        Me.lblLeituraAdicional.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLeituraAdicional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeituraAdicional.ForeColor = System.Drawing.Color.Black
        Me.lblLeituraAdicional.Location = New System.Drawing.Point(17, 27)
        Me.lblLeituraAdicional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeituraAdicional.Name = "lblLeituraAdicional"
        Me.lblLeituraAdicional.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLeituraAdicional.Size = New System.Drawing.Size(127, 32)
        Me.lblLeituraAdicional.TabIndex = 75
        Me.lblLeituraAdicional.Text = " - - - -"
        Me.lblLeituraAdicional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSituacaoEnsaio
        '
        Me.lblSituacaoEnsaio.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSituacaoEnsaio.ForeColor = System.Drawing.Color.DarkGray
        Me.lblSituacaoEnsaio.Location = New System.Drawing.Point(475, 406)
        Me.lblSituacaoEnsaio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSituacaoEnsaio.Name = "lblSituacaoEnsaio"
        Me.lblSituacaoEnsaio.Size = New System.Drawing.Size(201, 14)
        Me.lblSituacaoEnsaio.TabIndex = 149
        Me.lblSituacaoEnsaio.Text = "Threshold"
        '
        'lblConexaoCelula
        '
        Me.lblConexaoCelula.AutoSize = True
        Me.lblConexaoCelula.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConexaoCelula.ForeColor = System.Drawing.Color.DarkGray
        Me.lblConexaoCelula.Location = New System.Drawing.Point(475, 453)
        Me.lblConexaoCelula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConexaoCelula.Name = "lblConexaoCelula"
        Me.lblConexaoCelula.Size = New System.Drawing.Size(42, 15)
        Me.lblConexaoCelula.TabIndex = 147
        Me.lblConexaoCelula.Text = "Célula"
        '
        'lblStatusComandoEscrita
        '
        Me.lblStatusComandoEscrita.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusComandoEscrita.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatusComandoEscrita.Location = New System.Drawing.Point(475, 430)
        Me.lblStatusComandoEscrita.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusComandoEscrita.Name = "lblStatusComandoEscrita"
        Me.lblStatusComandoEscrita.Size = New System.Drawing.Size(80, 14)
        Me.lblStatusComandoEscrita.TabIndex = 147
        Me.lblStatusComandoEscrita.Text = "Enviado"
        '
        'lblPID
        '
        Me.lblPID.AutoSize = True
        Me.lblPID.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPID.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPID.Location = New System.Drawing.Point(475, 383)
        Me.lblPID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPID.Name = "lblPID"
        Me.lblPID.Size = New System.Drawing.Size(77, 15)
        Me.lblPID.TabIndex = 145
        Me.lblPID.Text = "Controle PID"
        '
        'lblStatusFaixaCarga
        '
        Me.lblStatusFaixaCarga.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusFaixaCarga.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatusFaixaCarga.Location = New System.Drawing.Point(236, 406)
        Me.lblStatusFaixaCarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusFaixaCarga.Name = "lblStatusFaixaCarga"
        Me.lblStatusFaixaCarga.Size = New System.Drawing.Size(80, 14)
        Me.lblStatusFaixaCarga.TabIndex = 145
        Me.lblStatusFaixaCarga.Text = "Sobrecarga"
        '
        'lblStatusFaixaCurso
        '
        Me.lblStatusFaixaCurso.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusFaixaCurso.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatusFaixaCurso.Location = New System.Drawing.Point(236, 383)
        Me.lblStatusFaixaCurso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusFaixaCurso.Name = "lblStatusFaixaCurso"
        Me.lblStatusFaixaCurso.Size = New System.Drawing.Size(80, 14)
        Me.lblStatusFaixaCurso.TabIndex = 146
        Me.lblStatusFaixaCurso.Text = "Sobrecurso"
        '
        'lblStatusModoLocalRemoto
        '
        Me.lblStatusModoLocalRemoto.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusModoLocalRemoto.ForeColor = System.Drawing.Color.DarkGray
        Me.lblStatusModoLocalRemoto.Location = New System.Drawing.Point(20, 383)
        Me.lblStatusModoLocalRemoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatusModoLocalRemoto.Name = "lblStatusModoLocalRemoto"
        Me.lblStatusModoLocalRemoto.Size = New System.Drawing.Size(201, 14)
        Me.lblStatusModoLocalRemoto.TabIndex = 144
        Me.lblStatusModoLocalRemoto.Text = "Modo Local (Manual)"
        '
        'lblSetpoint
        '
        Me.lblSetpoint.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetpoint.ForeColor = System.Drawing.Color.DarkGray
        Me.lblSetpoint.Location = New System.Drawing.Point(236, 453)
        Me.lblSetpoint.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSetpoint.Name = "lblSetpoint"
        Me.lblSetpoint.Size = New System.Drawing.Size(201, 14)
        Me.lblSetpoint.TabIndex = 143
        Me.lblSetpoint.Text = "Setpoint"
        '
        'lblSubindoDescendo
        '
        Me.lblSubindoDescendo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubindoDescendo.ForeColor = System.Drawing.Color.DarkGray
        Me.lblSubindoDescendo.Location = New System.Drawing.Point(236, 430)
        Me.lblSubindoDescendo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubindoDescendo.Name = "lblSubindoDescendo"
        Me.lblSubindoDescendo.Size = New System.Drawing.Size(201, 14)
        Me.lblSubindoDescendo.TabIndex = 143
        Me.lblSubindoDescendo.Text = "Parado"
        '
        'lblEmergencia
        '
        Me.lblEmergencia.AutoSize = True
        Me.lblEmergencia.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmergencia.ForeColor = System.Drawing.Color.DarkGray
        Me.lblEmergencia.Location = New System.Drawing.Point(20, 453)
        Me.lblEmergencia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmergencia.Name = "lblEmergencia"
        Me.lblEmergencia.Size = New System.Drawing.Size(75, 15)
        Me.lblEmergencia.TabIndex = 142
        Me.lblEmergencia.Text = "Emergência"
        '
        'lblFimCursoSuperior
        '
        Me.lblFimCursoSuperior.AutoSize = True
        Me.lblFimCursoSuperior.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFimCursoSuperior.ForeColor = System.Drawing.Color.DarkGray
        Me.lblFimCursoSuperior.Location = New System.Drawing.Point(20, 430)
        Me.lblFimCursoSuperior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFimCursoSuperior.Name = "lblFimCursoSuperior"
        Me.lblFimCursoSuperior.Size = New System.Drawing.Size(133, 15)
        Me.lblFimCursoSuperior.TabIndex = 142
        Me.lblFimCursoSuperior.Text = "Fim de Curso Superior"
        '
        'lblFimCursoInferior
        '
        Me.lblFimCursoInferior.AutoSize = True
        Me.lblFimCursoInferior.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFimCursoInferior.ForeColor = System.Drawing.Color.DarkGray
        Me.lblFimCursoInferior.Location = New System.Drawing.Point(20, 406)
        Me.lblFimCursoInferior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFimCursoInferior.Name = "lblFimCursoInferior"
        Me.lblFimCursoInferior.Size = New System.Drawing.Size(125, 15)
        Me.lblFimCursoInferior.TabIndex = 142
        Me.lblFimCursoInferior.Text = "Fim de Curso Inferior"
        '
        'grpGroupSelecionado
        '
        Me.grpGroupSelecionado.Controls.Add(Me.btnVeloc_1)
        Me.grpGroupSelecionado.Controls.Add(Me.btnSubir)
        Me.grpGroupSelecionado.Controls.Add(Me.btnDescer)
        Me.grpGroupSelecionado.Controls.Add(Me.btnParar)
        Me.grpGroupSelecionado.Controls.Add(Me.txtVeloc_1)
        Me.grpGroupSelecionado.Controls.Add(Me.lblVeloc_1)
        Me.grpGroupSelecionado.Controls.Add(Me.lblVeloc_5)
        Me.grpGroupSelecionado.Controls.Add(Me.btnVeloc_2)
        Me.grpGroupSelecionado.Controls.Add(Me.lblVeloc_4)
        Me.grpGroupSelecionado.Controls.Add(Me.txtVeloc_2)
        Me.grpGroupSelecionado.Controls.Add(Me.lblVeloc_2)
        Me.grpGroupSelecionado.Controls.Add(Me.btnVeloc_3)
        Me.grpGroupSelecionado.Controls.Add(Me.txtVeloc_5)
        Me.grpGroupSelecionado.Controls.Add(Me.txtVeloc_3)
        Me.grpGroupSelecionado.Controls.Add(Me.btnVeloc_5)
        Me.grpGroupSelecionado.Controls.Add(Me.lblVeloc_3)
        Me.grpGroupSelecionado.Controls.Add(Me.txtVeloc_4)
        Me.grpGroupSelecionado.Controls.Add(Me.btnVeloc_4)
        Me.grpGroupSelecionado.Enabled = False
        Me.grpGroupSelecionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGroupSelecionado.ForeColor = System.Drawing.Color.Black
        Me.grpGroupSelecionado.Location = New System.Drawing.Point(197, 12)
        Me.grpGroupSelecionado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpGroupSelecionado.Name = "grpGroupSelecionado"
        Me.grpGroupSelecionado.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpGroupSelecionado.Size = New System.Drawing.Size(303, 262)
        Me.grpGroupSelecionado.TabIndex = 134
        Me.grpGroupSelecionado.TabStop = False
        '
        'btnVeloc_1
        '
        Me.btnVeloc_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeloc_1.Location = New System.Drawing.Point(8, 18)
        Me.btnVeloc_1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVeloc_1.Name = "btnVeloc_1"
        Me.btnVeloc_1.Size = New System.Drawing.Size(139, 28)
        Me.btnVeloc_1.TabIndex = 16
        Me.btnVeloc_1.Text = "1ª Velocidade"
        Me.btnVeloc_1.UseVisualStyleBackColor = True
        '
        'btnSubir
        '
        Me.btnSubir.FlatAppearance.BorderSize = 2
        Me.btnSubir.Image = CType(resources.GetObject("btnSubir.Image"), System.Drawing.Image)
        Me.btnSubir.Location = New System.Drawing.Point(11, 176)
        Me.btnSubir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(87, 74)
        Me.btnSubir.TabIndex = 22
        Me.btnSubir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSubir.UseVisualStyleBackColor = True
        '
        'btnDescer
        '
        Me.btnDescer.FlatAppearance.BorderSize = 2
        Me.btnDescer.Image = CType(resources.GetObject("btnDescer.Image"), System.Drawing.Image)
        Me.btnDescer.Location = New System.Drawing.Point(204, 176)
        Me.btnDescer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDescer.Name = "btnDescer"
        Me.btnDescer.Size = New System.Drawing.Size(87, 74)
        Me.btnDescer.TabIndex = 24
        Me.btnDescer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDescer.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.FlatAppearance.BorderSize = 2
        Me.btnParar.Image = CType(resources.GetObject("btnParar.Image"), System.Drawing.Image)
        Me.btnParar.Location = New System.Drawing.Point(105, 176)
        Me.btnParar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(91, 74)
        Me.btnParar.TabIndex = 23
        Me.btnParar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'txtVeloc_1
        '
        Me.txtVeloc_1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtVeloc_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeloc_1.Location = New System.Drawing.Point(155, 21)
        Me.txtVeloc_1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVeloc_1.Name = "txtVeloc_1"
        Me.txtVeloc_1.Size = New System.Drawing.Size(100, 23)
        Me.txtVeloc_1.TabIndex = 17
        Me.txtVeloc_1.Text = "100"
        Me.txtVeloc_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVeloc_1
        '
        Me.lblVeloc_1.AutoSize = True
        Me.lblVeloc_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeloc_1.Location = New System.Drawing.Point(260, 26)
        Me.lblVeloc_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVeloc_1.Name = "lblVeloc_1"
        Me.lblVeloc_1.Size = New System.Drawing.Size(20, 17)
        Me.lblVeloc_1.TabIndex = 16
        Me.lblVeloc_1.Text = "%"
        Me.lblVeloc_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVeloc_5
        '
        Me.lblVeloc_5.AutoSize = True
        Me.lblVeloc_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeloc_5.Location = New System.Drawing.Point(260, 148)
        Me.lblVeloc_5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVeloc_5.Name = "lblVeloc_5"
        Me.lblVeloc_5.Size = New System.Drawing.Size(20, 17)
        Me.lblVeloc_5.TabIndex = 116
        Me.lblVeloc_5.Text = "%"
        Me.lblVeloc_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnVeloc_2
        '
        Me.btnVeloc_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeloc_2.Location = New System.Drawing.Point(8, 48)
        Me.btnVeloc_2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVeloc_2.Name = "btnVeloc_2"
        Me.btnVeloc_2.Size = New System.Drawing.Size(139, 28)
        Me.btnVeloc_2.TabIndex = 18
        Me.btnVeloc_2.Text = "2ª Velocidade"
        Me.btnVeloc_2.UseVisualStyleBackColor = True
        '
        'lblVeloc_4
        '
        Me.lblVeloc_4.AutoSize = True
        Me.lblVeloc_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeloc_4.Location = New System.Drawing.Point(260, 116)
        Me.lblVeloc_4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVeloc_4.Name = "lblVeloc_4"
        Me.lblVeloc_4.Size = New System.Drawing.Size(20, 17)
        Me.lblVeloc_4.TabIndex = 115
        Me.lblVeloc_4.Text = "%"
        Me.lblVeloc_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVeloc_2
        '
        Me.txtVeloc_2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtVeloc_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeloc_2.Location = New System.Drawing.Point(155, 50)
        Me.txtVeloc_2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVeloc_2.Name = "txtVeloc_2"
        Me.txtVeloc_2.Size = New System.Drawing.Size(100, 23)
        Me.txtVeloc_2.TabIndex = 19
        Me.txtVeloc_2.Text = "70"
        Me.txtVeloc_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVeloc_2
        '
        Me.lblVeloc_2.AutoSize = True
        Me.lblVeloc_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeloc_2.Location = New System.Drawing.Point(260, 55)
        Me.lblVeloc_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVeloc_2.Name = "lblVeloc_2"
        Me.lblVeloc_2.Size = New System.Drawing.Size(20, 17)
        Me.lblVeloc_2.TabIndex = 19
        Me.lblVeloc_2.Text = "%"
        Me.lblVeloc_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnVeloc_3
        '
        Me.btnVeloc_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeloc_3.Location = New System.Drawing.Point(8, 79)
        Me.btnVeloc_3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVeloc_3.Name = "btnVeloc_3"
        Me.btnVeloc_3.Size = New System.Drawing.Size(139, 28)
        Me.btnVeloc_3.TabIndex = 20
        Me.btnVeloc_3.Text = "3ª Velocidade"
        Me.btnVeloc_3.UseVisualStyleBackColor = True
        '
        'txtVeloc_5
        '
        Me.txtVeloc_5.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtVeloc_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeloc_5.Location = New System.Drawing.Point(155, 143)
        Me.txtVeloc_5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVeloc_5.Name = "txtVeloc_5"
        Me.txtVeloc_5.Size = New System.Drawing.Size(100, 23)
        Me.txtVeloc_5.TabIndex = 114
        Me.txtVeloc_5.Text = "0.83"
        Me.txtVeloc_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVeloc_3
        '
        Me.txtVeloc_3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtVeloc_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeloc_3.Location = New System.Drawing.Point(155, 81)
        Me.txtVeloc_3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVeloc_3.Name = "txtVeloc_3"
        Me.txtVeloc_3.Size = New System.Drawing.Size(100, 23)
        Me.txtVeloc_3.TabIndex = 21
        Me.txtVeloc_3.Text = "30"
        Me.txtVeloc_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVeloc_5
        '
        Me.btnVeloc_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeloc_5.Location = New System.Drawing.Point(8, 140)
        Me.btnVeloc_5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVeloc_5.Name = "btnVeloc_5"
        Me.btnVeloc_5.Size = New System.Drawing.Size(139, 28)
        Me.btnVeloc_5.TabIndex = 113
        Me.btnVeloc_5.Text = "5ª Velocidade"
        Me.btnVeloc_5.UseVisualStyleBackColor = True
        '
        'lblVeloc_3
        '
        Me.lblVeloc_3.AutoSize = True
        Me.lblVeloc_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeloc_3.Location = New System.Drawing.Point(260, 86)
        Me.lblVeloc_3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVeloc_3.Name = "lblVeloc_3"
        Me.lblVeloc_3.Size = New System.Drawing.Size(20, 17)
        Me.lblVeloc_3.TabIndex = 110
        Me.lblVeloc_3.Text = "%"
        Me.lblVeloc_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVeloc_4
        '
        Me.txtVeloc_4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtVeloc_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVeloc_4.Location = New System.Drawing.Point(155, 112)
        Me.txtVeloc_4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVeloc_4.Name = "txtVeloc_4"
        Me.txtVeloc_4.Size = New System.Drawing.Size(100, 23)
        Me.txtVeloc_4.TabIndex = 112
        Me.txtVeloc_4.Text = "10"
        Me.txtVeloc_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVeloc_4
        '
        Me.btnVeloc_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeloc_4.Location = New System.Drawing.Point(8, 110)
        Me.btnVeloc_4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVeloc_4.Name = "btnVeloc_4"
        Me.btnVeloc_4.Size = New System.Drawing.Size(139, 28)
        Me.btnVeloc_4.TabIndex = 111
        Me.btnVeloc_4.Text = "4ª Velocidade"
        Me.btnVeloc_4.UseVisualStyleBackColor = True
        '
        'grbAjusteCalibracao
        '
        Me.grbAjusteCalibracao.Controls.Add(Me.lblLeitura)
        Me.grbAjusteCalibracao.Controls.Add(Me.lblLabel11)
        Me.grbAjusteCalibracao.Controls.Add(Me.lblLegendaLeitura)
        Me.grbAjusteCalibracao.Controls.Add(Me.lblLabel12)
        Me.grbAjusteCalibracao.Controls.Add(Me.lblLabel10)
        Me.grbAjusteCalibracao.Controls.Add(Me.txtConst)
        Me.grbAjusteCalibracao.Controls.Add(Me.lblSensor)
        Me.grbAjusteCalibracao.Controls.Add(Me.txtOffSet)
        Me.grbAjusteCalibracao.Enabled = False
        Me.grbAjusteCalibracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAjusteCalibracao.ForeColor = System.Drawing.Color.Black
        Me.grbAjusteCalibracao.Location = New System.Drawing.Point(13, 288)
        Me.grbAjusteCalibracao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbAjusteCalibracao.Name = "grbAjusteCalibracao"
        Me.grbAjusteCalibracao.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbAjusteCalibracao.Size = New System.Drawing.Size(673, 89)
        Me.grbAjusteCalibracao.TabIndex = 127
        Me.grbAjusteCalibracao.TabStop = False
        Me.grbAjusteCalibracao.Text = "Dados da Equação"
        '
        'lblLeitura
        '
        Me.lblLeitura.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblLeitura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLeitura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLeitura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeitura.ForeColor = System.Drawing.Color.Lime
        Me.lblLeitura.Location = New System.Drawing.Point(504, 49)
        Me.lblLeitura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeitura.Name = "lblLeitura"
        Me.lblLeitura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLeitura.Size = New System.Drawing.Size(153, 34)
        Me.lblLeitura.TabIndex = 74
        Me.lblLeitura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel11
        '
        Me.lblLabel11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblLabel11.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel11.Location = New System.Drawing.Point(179, 26)
        Me.lblLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel11.Size = New System.Drawing.Size(152, 22)
        Me.lblLabel11.TabIndex = 71
        Me.lblLabel11.Text = "Offset"
        Me.lblLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLegendaLeitura
        '
        Me.lblLegendaLeitura.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblLegendaLeitura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLegendaLeitura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegendaLeitura.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLegendaLeitura.Location = New System.Drawing.Point(504, 26)
        Me.lblLegendaLeitura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegendaLeitura.Name = "lblLegendaLeitura"
        Me.lblLegendaLeitura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLegendaLeitura.Size = New System.Drawing.Size(152, 22)
        Me.lblLegendaLeitura.TabIndex = 70
        Me.lblLegendaLeitura.Text = "Leitura"
        Me.lblLegendaLeitura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel12
        '
        Me.lblLabel12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblLabel12.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel12.Location = New System.Drawing.Point(341, 26)
        Me.lblLabel12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel12.Size = New System.Drawing.Size(152, 22)
        Me.lblLabel12.TabIndex = 70
        Me.lblLabel12.Text = "Constante"
        Me.lblLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLabel10
        '
        Me.lblLabel10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblLabel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel10.Location = New System.Drawing.Point(17, 26)
        Me.lblLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel10.Size = New System.Drawing.Size(151, 22)
        Me.lblLabel10.TabIndex = 73
        Me.lblLabel10.Text = "Sensor"
        Me.lblLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtConst
        '
        Me.txtConst.AcceptsReturn = True
        Me.txtConst.BackColor = System.Drawing.SystemColors.Window
        Me.txtConst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConst.Location = New System.Drawing.Point(341, 49)
        Me.txtConst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConst.MaxLength = 0
        Me.txtConst.Name = "txtConst"
        Me.txtConst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtConst.Size = New System.Drawing.Size(151, 34)
        Me.txtConst.TabIndex = 26
        Me.txtConst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSensor
        '
        Me.lblSensor.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblSensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSensor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSensor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensor.ForeColor = System.Drawing.Color.Lime
        Me.lblSensor.Location = New System.Drawing.Point(16, 49)
        Me.lblSensor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSensor.Name = "lblSensor"
        Me.lblSensor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSensor.Size = New System.Drawing.Size(153, 34)
        Me.lblSensor.TabIndex = 11
        Me.lblSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOffSet
        '
        Me.txtOffSet.AcceptsReturn = True
        Me.txtOffSet.BackColor = System.Drawing.SystemColors.Window
        Me.txtOffSet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOffSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffSet.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOffSet.Location = New System.Drawing.Point(179, 49)
        Me.txtOffSet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOffSet.MaxLength = 0
        Me.txtOffSet.Name = "txtOffSet"
        Me.txtOffSet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOffSet.Size = New System.Drawing.Size(151, 34)
        Me.txtOffSet.TabIndex = 25
        Me.txtOffSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpOutputMotor
        '
        Me.grpOutputMotor.Controls.Add(Me.lblOutputMotor)
        Me.grpOutputMotor.Enabled = False
        Me.grpOutputMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOutputMotor.ForeColor = System.Drawing.Color.Black
        Me.grpOutputMotor.Location = New System.Drawing.Point(512, 12)
        Me.grpOutputMotor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOutputMotor.Name = "grpOutputMotor"
        Me.grpOutputMotor.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOutputMotor.Size = New System.Drawing.Size(175, 78)
        Me.grpOutputMotor.TabIndex = 117
        Me.grpOutputMotor.TabStop = False
        Me.grpOutputMotor.Text = "Output Motor (Hz)"
        '
        'lblOutputMotor
        '
        Me.lblOutputMotor.BackColor = System.Drawing.Color.Transparent
        Me.lblOutputMotor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOutputMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputMotor.ForeColor = System.Drawing.Color.Black
        Me.lblOutputMotor.Location = New System.Drawing.Point(17, 26)
        Me.lblOutputMotor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputMotor.Name = "lblOutputMotor"
        Me.lblOutputMotor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOutputMotor.Size = New System.Drawing.Size(127, 32)
        Me.lblOutputMotor.TabIndex = 74
        Me.lblOutputMotor.Text = " - - - -"
        Me.lblOutputMotor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTaxa
        '
        Me.grpTaxa.Controls.Add(Me.txtTaxa)
        Me.grpTaxa.Controls.Add(Me.btnEnviarTaxa)
        Me.grpTaxa.Enabled = False
        Me.grpTaxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTaxa.ForeColor = System.Drawing.Color.Black
        Me.grpTaxa.Location = New System.Drawing.Point(512, 92)
        Me.grpTaxa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTaxa.Name = "grpTaxa"
        Me.grpTaxa.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTaxa.Size = New System.Drawing.Size(175, 102)
        Me.grpTaxa.TabIndex = 117
        Me.grpTaxa.TabStop = False
        Me.grpTaxa.Text = "Taxa (kgf/s)"
        Me.grpTaxa.Visible = False
        '
        'txtTaxa
        '
        Me.txtTaxa.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtTaxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxa.Location = New System.Drawing.Point(28, 23)
        Me.txtTaxa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTaxa.Name = "txtTaxa"
        Me.txtTaxa.Size = New System.Drawing.Size(100, 23)
        Me.txtTaxa.TabIndex = 114
        Me.txtTaxa.Text = "5,0"
        Me.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnviarTaxa
        '
        Me.btnEnviarTaxa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarTaxa.Location = New System.Drawing.Point(28, 57)
        Me.btnEnviarTaxa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnviarTaxa.Name = "btnEnviarTaxa"
        Me.btnEnviarTaxa.Size = New System.Drawing.Size(101, 28)
        Me.btnEnviarTaxa.TabIndex = 113
        Me.btnEnviarTaxa.Text = "Enviar"
        Me.btnEnviarTaxa.UseVisualStyleBackColor = True
        '
        'grpOperacao
        '
        Me.grpOperacao.Controls.Add(Me.rdbModoDeslocamentoPID)
        Me.grpOperacao.Controls.Add(Me.rdbModoIncremento)
        Me.grpOperacao.Controls.Add(Me.rdbModoVelocidadePercentual)
        Me.grpOperacao.Enabled = False
        Me.grpOperacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOperacao.ForeColor = System.Drawing.Color.Black
        Me.grpOperacao.Location = New System.Drawing.Point(8, 92)
        Me.grpOperacao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOperacao.Name = "grpOperacao"
        Me.grpOperacao.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpOperacao.Size = New System.Drawing.Size(179, 102)
        Me.grpOperacao.TabIndex = 117
        Me.grpOperacao.TabStop = False
        Me.grpOperacao.Text = "Modo "
        '
        'rdbModoDeslocamentoPID
        '
        Me.rdbModoDeslocamentoPID.AutoSize = True
        Me.rdbModoDeslocamentoPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModoDeslocamentoPID.Location = New System.Drawing.Point(9, 74)
        Me.rdbModoDeslocamentoPID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbModoDeslocamentoPID.Name = "rdbModoDeslocamentoPID"
        Me.rdbModoDeslocamentoPID.Size = New System.Drawing.Size(161, 21)
        Me.rdbModoDeslocamentoPID.TabIndex = 2
        Me.rdbModoDeslocamentoPID.Text = "Velocidade (mm/min)"
        Me.rdbModoDeslocamentoPID.UseVisualStyleBackColor = True
        '
        'rdbModoIncremento
        '
        Me.rdbModoIncremento.AutoSize = True
        Me.rdbModoIncremento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModoIncremento.Location = New System.Drawing.Point(9, 47)
        Me.rdbModoIncremento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbModoIncremento.Name = "rdbModoIncremento"
        Me.rdbModoIncremento.Size = New System.Drawing.Size(143, 21)
        Me.rdbModoIncremento.TabIndex = 2
        Me.rdbModoIncremento.Text = "Incremento (kgf/s)"
        Me.rdbModoIncremento.UseVisualStyleBackColor = True
        '
        'rdbModoVelocidadePercentual
        '
        Me.rdbModoVelocidadePercentual.AutoSize = True
        Me.rdbModoVelocidadePercentual.Checked = True
        Me.rdbModoVelocidadePercentual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbModoVelocidadePercentual.Location = New System.Drawing.Point(9, 21)
        Me.rdbModoVelocidadePercentual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbModoVelocidadePercentual.Name = "rdbModoVelocidadePercentual"
        Me.rdbModoVelocidadePercentual.Size = New System.Drawing.Size(125, 21)
        Me.rdbModoVelocidadePercentual.TabIndex = 1
        Me.rdbModoVelocidadePercentual.TabStop = True
        Me.rdbModoVelocidadePercentual.Text = "Velocidade (%)"
        Me.rdbModoVelocidadePercentual.UseVisualStyleBackColor = True
        '
        'grpInstrumentos
        '
        Me.grpInstrumentos.Controls.Add(Me.rdbDeslocamento)
        Me.grpInstrumentos.Controls.Add(Me.rdbCarga)
        Me.grpInstrumentos.Enabled = False
        Me.grpInstrumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInstrumentos.ForeColor = System.Drawing.Color.Black
        Me.grpInstrumentos.Location = New System.Drawing.Point(8, 197)
        Me.grpInstrumentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInstrumentos.Name = "grpInstrumentos"
        Me.grpInstrumentos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpInstrumentos.Size = New System.Drawing.Size(179, 78)
        Me.grpInstrumentos.TabIndex = 117
        Me.grpInstrumentos.TabStop = False
        Me.grpInstrumentos.Text = "Instrumento"
        '
        'rdbDeslocamento
        '
        Me.rdbDeslocamento.AutoSize = True
        Me.rdbDeslocamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDeslocamento.Location = New System.Drawing.Point(9, 47)
        Me.rdbDeslocamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbDeslocamento.Name = "rdbDeslocamento"
        Me.rdbDeslocamento.Size = New System.Drawing.Size(119, 21)
        Me.rdbDeslocamento.TabIndex = 2
        Me.rdbDeslocamento.Text = "Deslocamento"
        Me.rdbDeslocamento.UseVisualStyleBackColor = True
        '
        'rdbCarga
        '
        Me.rdbCarga.AutoSize = True
        Me.rdbCarga.Checked = True
        Me.rdbCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCarga.Location = New System.Drawing.Point(9, 21)
        Me.rdbCarga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbCarga.Name = "rdbCarga"
        Me.rdbCarga.Size = New System.Drawing.Size(67, 21)
        Me.rdbCarga.TabIndex = 1
        Me.rdbCarga.TabStop = True
        Me.rdbCarga.Text = "Carga"
        Me.rdbCarga.UseVisualStyleBackColor = True
        '
        'grpLocalRemoto
        '
        Me.grpLocalRemoto.Controls.Add(Me.rdbRemoto)
        Me.grpLocalRemoto.Controls.Add(Me.rdbLocal)
        Me.grpLocalRemoto.Enabled = False
        Me.grpLocalRemoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocalRemoto.ForeColor = System.Drawing.Color.Black
        Me.grpLocalRemoto.Location = New System.Drawing.Point(8, 12)
        Me.grpLocalRemoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLocalRemoto.Name = "grpLocalRemoto"
        Me.grpLocalRemoto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLocalRemoto.Size = New System.Drawing.Size(179, 78)
        Me.grpLocalRemoto.TabIndex = 13
        Me.grpLocalRemoto.TabStop = False
        Me.grpLocalRemoto.Text = "Habilitar Controle"
        '
        'rdbRemoto
        '
        Me.rdbRemoto.AutoSize = True
        Me.rdbRemoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRemoto.Location = New System.Drawing.Point(9, 47)
        Me.rdbRemoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbRemoto.Name = "rdbRemoto"
        Me.rdbRemoto.Size = New System.Drawing.Size(78, 21)
        Me.rdbRemoto.TabIndex = 15
        Me.rdbRemoto.Text = "Remoto"
        Me.rdbRemoto.UseVisualStyleBackColor = True
        '
        'rdbLocal
        '
        Me.rdbLocal.AutoSize = True
        Me.rdbLocal.Checked = True
        Me.rdbLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLocal.Location = New System.Drawing.Point(9, 21)
        Me.rdbLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbLocal.Name = "rdbLocal"
        Me.rdbLocal.Size = New System.Drawing.Size(63, 21)
        Me.rdbLocal.TabIndex = 14
        Me.rdbLocal.TabStop = True
        Me.rdbLocal.Text = "Local"
        Me.rdbLocal.UseVisualStyleBackColor = True
        '
        'tmrCalibracao
        '
        Me.tmrCalibracao.Interval = 500
        '
        'tmrLimparErros
        '
        Me.tmrLimparErros.Interval = 3000
        '
        'frmCalibracao
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(727, 592)
        Me.Controls.Add(Me.grbPrincipal)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblMsgErro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalibracao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calibração e Ajuste"
        Me.pnlPanel.ResumeLayout(False)
        Me.grbPrincipal.ResumeLayout(False)
        Me.grbPrincipal.PerformLayout()
        Me.grpLeituraAdicional.ResumeLayout(False)
        Me.grpGroupSelecionado.ResumeLayout(False)
        Me.grpGroupSelecionado.PerformLayout()
        Me.grbAjusteCalibracao.ResumeLayout(False)
        Me.grbAjusteCalibracao.PerformLayout()
        Me.grpOutputMotor.ResumeLayout(False)
        Me.grpTaxa.ResumeLayout(False)
        Me.grpTaxa.PerformLayout()
        Me.grpOperacao.ResumeLayout(False)
        Me.grpOperacao.PerformLayout()
        Me.grpInstrumentos.ResumeLayout(False)
        Me.grpInstrumentos.PerformLayout()
        Me.grpLocalRemoto.ResumeLayout(False)
        Me.grpLocalRemoto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblMsgErro As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents spPortaSerial As System.IO.Ports.SerialPort
    Friend WithEvents tmrCalibracao As System.Windows.Forms.Timer
    Friend WithEvents grbAjusteCalibracao As System.Windows.Forms.GroupBox
    Public WithEvents lblLabel11 As System.Windows.Forms.Label
    Public WithEvents lblLabel12 As System.Windows.Forms.Label
    Public WithEvents lblLabel10 As System.Windows.Forms.Label
    Public WithEvents txtConst As System.Windows.Forms.TextBox
    Public WithEvents lblSensor As System.Windows.Forms.Label
    Public WithEvents txtOffSet As System.Windows.Forms.TextBox
    Friend WithEvents grbPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents grpInstrumentos As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDeslocamento As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCarga As System.Windows.Forms.RadioButton
    Friend WithEvents lblVeloc_5 As System.Windows.Forms.Label
    Friend WithEvents lblVeloc_4 As System.Windows.Forms.Label
    Friend WithEvents txtVeloc_5 As System.Windows.Forms.TextBox
    Friend WithEvents btnVeloc_5 As System.Windows.Forms.Button
    Friend WithEvents txtVeloc_4 As System.Windows.Forms.TextBox
    Friend WithEvents btnVeloc_4 As System.Windows.Forms.Button
    Friend WithEvents lblVeloc_3 As System.Windows.Forms.Label
    Friend WithEvents txtVeloc_3 As System.Windows.Forms.TextBox
    Friend WithEvents btnVeloc_3 As System.Windows.Forms.Button
    Friend WithEvents lblVeloc_2 As System.Windows.Forms.Label
    Friend WithEvents txtVeloc_2 As System.Windows.Forms.TextBox
    Friend WithEvents btnVeloc_2 As System.Windows.Forms.Button
    Friend WithEvents lblVeloc_1 As System.Windows.Forms.Label
    Friend WithEvents txtVeloc_1 As System.Windows.Forms.TextBox
    Friend WithEvents btnVeloc_1 As System.Windows.Forms.Button
    Friend WithEvents grpLocalRemoto As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRemoto As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents btnParar As System.Windows.Forms.Button
    Friend WithEvents btnDescer As System.Windows.Forms.Button
    Friend WithEvents btnSubir As System.Windows.Forms.Button
    Public WithEvents lblLeitura As System.Windows.Forms.Label
    Public WithEvents lblLegendaLeitura As System.Windows.Forms.Label
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents barStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSalvarCalibracao As System.Windows.Forms.Button
    Friend WithEvents btnLigar As System.Windows.Forms.Button
    Friend WithEvents grpGroupSelecionado As System.Windows.Forms.GroupBox
    Friend WithEvents btnOffSet As System.Windows.Forms.Button
    Friend WithEvents lblStatusFaixaCarga As System.Windows.Forms.Label
    Friend WithEvents lblStatusFaixaCurso As System.Windows.Forms.Label
    Friend WithEvents lblStatusModoLocalRemoto As System.Windows.Forms.Label
    Friend WithEvents lblSubindoDescendo As System.Windows.Forms.Label
    Friend WithEvents lblFimCursoInferior As System.Windows.Forms.Label
    Friend WithEvents lblStatusComandoEscrita As System.Windows.Forms.Label
    Friend WithEvents lblSituacaoEnsaio As System.Windows.Forms.Label
    Friend WithEvents lblEmergencia As Label
    Friend WithEvents lblFimCursoSuperior As Label
    Friend WithEvents lblPID As Label
    Friend WithEvents lblSetpoint As Label
    Friend WithEvents tmrLimparErros As Timer
    Friend WithEvents grpTaxa As GroupBox
    Friend WithEvents txtTaxa As TextBox
    Friend WithEvents btnEnviarTaxa As Button
    Friend WithEvents grpOperacao As GroupBox
    Friend WithEvents rdbModoIncremento As RadioButton
    Friend WithEvents rdbModoVelocidadePercentual As RadioButton
    Friend WithEvents lblConexaoCelula As Label
    Friend WithEvents grpOutputMotor As GroupBox
    Public WithEvents lblOutputMotor As Label
    Friend WithEvents rdbModoDeslocamentoPID As RadioButton
    Friend WithEvents grpLeituraAdicional As GroupBox
    Public WithEvents lblLeituraAdicional As Label
End Class
