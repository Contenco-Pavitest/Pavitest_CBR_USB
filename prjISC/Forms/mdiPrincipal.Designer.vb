<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuArquivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBancoDados1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBancoDados2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnsaiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadastrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUtilitarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogotipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPortaSerial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalibrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfigurar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuComunicar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLicença = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuInformacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsBarraFerramenta = New System.Windows.Forms.ToolStrip()
        Me.tsbBaseDados = New System.Windows.Forms.ToolStripButton()
        Me.tsbAmostras = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPainel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPortaSerial = New System.Windows.Forms.ToolStripButton()
        Me.tsbComunicar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCalibrar = New System.Windows.Forms.ToolStripButton()
        Me.tsbConfigurar = New System.Windows.Forms.ToolStripButton()
        Me.tsbLogotipo = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLicença = New System.Windows.Forms.ToolStripButton()
        Me.tssSeparador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSair = New System.Windows.Forms.ToolStripButton()
        Me.mnuMenu.SuspendLayout()
        Me.tlsBarraFerramenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArquivo, Me.mnuBancoDados1, Me.mnuEnsaiar, Me.mnuUtilitarios, Me.mnuHelp})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.mnuMenu.Size = New System.Drawing.Size(1086, 24)
        Me.mnuMenu.TabIndex = 8
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
        Me.mnuSair.Image = CType(resources.GetObject("mnuSair.Image"), System.Drawing.Image)
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(93, 22)
        Me.mnuSair.Text = "&Sair"
        '
        'mnuBancoDados1
        '
        Me.mnuBancoDados1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBancoDados2})
        Me.mnuBancoDados1.Name = "mnuBancoDados1"
        Me.mnuBancoDados1.Size = New System.Drawing.Size(95, 20)
        Me.mnuBancoDados1.Text = "&Base de Dados"
        '
        'mnuBancoDados2
        '
        Me.mnuBancoDados2.Image = CType(resources.GetObject("mnuBancoDados2.Image"), System.Drawing.Image)
        Me.mnuBancoDados2.Name = "mnuBancoDados2"
        Me.mnuBancoDados2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuBancoDados2.Size = New System.Drawing.Size(249, 22)
        Me.mnuBancoDados2.Text = "Selecionar Base de Dados"
        '
        'mnuEnsaiar
        '
        Me.mnuEnsaiar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastrar})
        Me.mnuEnsaiar.Name = "mnuEnsaiar"
        Me.mnuEnsaiar.Size = New System.Drawing.Size(58, 20)
        Me.mnuEnsaiar.Text = "Ensaios"
        '
        'mnuCadastrar
        '
        Me.mnuCadastrar.Image = CType(resources.GetObject("mnuCadastrar.Image"), System.Drawing.Image)
        Me.mnuCadastrar.Name = "mnuCadastrar"
        Me.mnuCadastrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuCadastrar.Size = New System.Drawing.Size(219, 22)
        Me.mnuCadastrar.Text = "Cadastrar Amostras"
        '
        'mnuUtilitarios
        '
        Me.mnuUtilitarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogotipo, Me.mnuPortaSerial, Me.mnuCalibrar, Me.mnuConfigurar, Me.mnuComunicar})
        Me.mnuUtilitarios.Name = "mnuUtilitarios"
        Me.mnuUtilitarios.Size = New System.Drawing.Size(69, 20)
        Me.mnuUtilitarios.Text = "Utilitários"
        '
        'mnuLogotipo
        '
        Me.mnuLogotipo.Image = CType(resources.GetObject("mnuLogotipo.Image"), System.Drawing.Image)
        Me.mnuLogotipo.Name = "mnuLogotipo"
        Me.mnuLogotipo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuLogotipo.Size = New System.Drawing.Size(273, 22)
        Me.mnuLogotipo.Text = "Alterar Logotipo"
        '
        'mnuPortaSerial
        '
        Me.mnuPortaSerial.Image = CType(resources.GetObject("mnuPortaSerial.Image"), System.Drawing.Image)
        Me.mnuPortaSerial.Name = "mnuPortaSerial"
        Me.mnuPortaSerial.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuPortaSerial.Size = New System.Drawing.Size(273, 22)
        Me.mnuPortaSerial.Text = "Alterar Porta de Comunicação"
        '
        'mnuCalibrar
        '
        Me.mnuCalibrar.Image = CType(resources.GetObject("mnuCalibrar.Image"), System.Drawing.Image)
        Me.mnuCalibrar.Name = "mnuCalibrar"
        Me.mnuCalibrar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuCalibrar.Size = New System.Drawing.Size(273, 22)
        Me.mnuCalibrar.Text = "Calibração"
        Me.mnuCalibrar.Visible = False
        '
        'mnuConfigurar
        '
        Me.mnuConfigurar.Image = CType(resources.GetObject("mnuConfigurar.Image"), System.Drawing.Image)
        Me.mnuConfigurar.Name = "mnuConfigurar"
        Me.mnuConfigurar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuConfigurar.Size = New System.Drawing.Size(273, 22)
        Me.mnuConfigurar.Text = "Configuração do Ensaio"
        '
        'mnuComunicar
        '
        Me.mnuComunicar.Image = CType(resources.GetObject("mnuComunicar.Image"), System.Drawing.Image)
        Me.mnuComunicar.Name = "mnuComunicar"
        Me.mnuComunicar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuComunicar.Size = New System.Drawing.Size(273, 22)
        Me.mnuComunicar.Text = "Testar Comunicação"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLicença, Me.mnuSeparador2, Me.mnuInformacao})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(24, 20)
        Me.mnuHelp.Text = "&?"
        '
        'mnuLicença
        '
        Me.mnuLicença.Image = CType(resources.GetObject("mnuLicença.Image"), System.Drawing.Image)
        Me.mnuLicença.Name = "mnuLicença"
        Me.mnuLicença.Size = New System.Drawing.Size(221, 22)
        Me.mnuLicença.Text = "Ativação Pavitest"
        '
        'mnuSeparador2
        '
        Me.mnuSeparador2.Name = "mnuSeparador2"
        Me.mnuSeparador2.Size = New System.Drawing.Size(218, 6)
        '
        'mnuInformacao
        '
        Me.mnuInformacao.Image = CType(resources.GetObject("mnuInformacao.Image"), System.Drawing.Image)
        Me.mnuInformacao.Name = "mnuInformacao"
        Me.mnuInformacao.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuInformacao.Size = New System.Drawing.Size(221, 22)
        Me.mnuInformacao.Text = "Informações Pavitest"
        '
        'tlsBarraFerramenta
        '
        Me.tlsBarraFerramenta.AutoSize = False
        Me.tlsBarraFerramenta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsBarraFerramenta.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tlsBarraFerramenta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBaseDados, Me.tsbAmostras, Me.tssSeparador1, Me.tsbPainel, Me.ToolStripSeparator1, Me.tsbPortaSerial, Me.tsbComunicar, Me.tsbCalibrar, Me.tsbConfigurar, Me.tsbLogotipo, Me.tssSeparador4, Me.tsbLicença, Me.tssSeparador2, Me.tsbSair})
        Me.tlsBarraFerramenta.Location = New System.Drawing.Point(0, 24)
        Me.tlsBarraFerramenta.Name = "tlsBarraFerramenta"
        Me.tlsBarraFerramenta.Size = New System.Drawing.Size(1086, 46)
        Me.tlsBarraFerramenta.TabIndex = 9
        '
        'tsbBaseDados
        '
        Me.tsbBaseDados.AutoSize = False
        Me.tsbBaseDados.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbBaseDados.Image = CType(resources.GetObject("tsbBaseDados.Image"), System.Drawing.Image)
        Me.tsbBaseDados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbBaseDados.Margin = New System.Windows.Forms.Padding(2, 1, 0, 2)
        Me.tsbBaseDados.Name = "tsbBaseDados"
        Me.tsbBaseDados.Size = New System.Drawing.Size(50, 45)
        Me.tsbBaseDados.Tag = ""
        Me.tsbBaseDados.Text = "B.D."
        Me.tsbBaseDados.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.tsbBaseDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbBaseDados.ToolTipText = "Base de Dados"
        '
        'tsbAmostras
        '
        Me.tsbAmostras.AutoSize = False
        Me.tsbAmostras.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbAmostras.Image = CType(resources.GetObject("tsbAmostras.Image"), System.Drawing.Image)
        Me.tsbAmostras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbAmostras.Margin = New System.Windows.Forms.Padding(1, 1, 0, 2)
        Me.tsbAmostras.Name = "tsbAmostras"
        Me.tsbAmostras.Size = New System.Drawing.Size(50, 45)
        Me.tsbAmostras.Tag = ""
        Me.tsbAmostras.Text = "Amostras"
        Me.tsbAmostras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbAmostras.ToolTipText = "Listagem das Amostras"
        '
        'tssSeparador1
        '
        Me.tssSeparador1.Name = "tssSeparador1"
        Me.tssSeparador1.Size = New System.Drawing.Size(6, 46)
        '
        'tsbPainel
        '
        Me.tsbPainel.AutoSize = False
        Me.tsbPainel.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPainel.Image = CType(resources.GetObject("tsbPainel.Image"), System.Drawing.Image)
        Me.tsbPainel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPainel.ImageTransparentColor = System.Drawing.Color.White
        Me.tsbPainel.Name = "tsbPainel"
        Me.tsbPainel.Size = New System.Drawing.Size(50, 45)
        Me.tsbPainel.Text = "Leitor"
        Me.tsbPainel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbPainel.ToolTipText = "Visualizador do Leitor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 46)
        '
        'tsbPortaSerial
        '
        Me.tsbPortaSerial.AutoSize = False
        Me.tsbPortaSerial.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbPortaSerial.Image = CType(resources.GetObject("tsbPortaSerial.Image"), System.Drawing.Image)
        Me.tsbPortaSerial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbPortaSerial.Name = "tsbPortaSerial"
        Me.tsbPortaSerial.Size = New System.Drawing.Size(50, 45)
        Me.tsbPortaSerial.Tag = ""
        Me.tsbPortaSerial.Text = "USB"
        Me.tsbPortaSerial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbPortaSerial.ToolTipText = "Selecionar Porta de Comunicação"
        '
        'tsbComunicar
        '
        Me.tsbComunicar.AutoSize = False
        Me.tsbComunicar.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbComunicar.Image = CType(resources.GetObject("tsbComunicar.Image"), System.Drawing.Image)
        Me.tsbComunicar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbComunicar.Name = "tsbComunicar"
        Me.tsbComunicar.Size = New System.Drawing.Size(50, 45)
        Me.tsbComunicar.Tag = ""
        Me.tsbComunicar.Text = "Conexão"
        Me.tsbComunicar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbComunicar.ToolTipText = "Teste de Comunicação"
        '
        'tsbCalibrar
        '
        Me.tsbCalibrar.AutoSize = False
        Me.tsbCalibrar.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbCalibrar.Image = CType(resources.GetObject("tsbCalibrar.Image"), System.Drawing.Image)
        Me.tsbCalibrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCalibrar.Name = "tsbCalibrar"
        Me.tsbCalibrar.Size = New System.Drawing.Size(50, 45)
        Me.tsbCalibrar.Tag = ""
        Me.tsbCalibrar.Text = "Calibrar"
        Me.tsbCalibrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbCalibrar.ToolTipText = "Calibração dos LVDT´s"
        '
        'tsbConfigurar
        '
        Me.tsbConfigurar.AutoSize = False
        Me.tsbConfigurar.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbConfigurar.Image = CType(resources.GetObject("tsbConfigurar.Image"), System.Drawing.Image)
        Me.tsbConfigurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbConfigurar.Name = "tsbConfigurar"
        Me.tsbConfigurar.Size = New System.Drawing.Size(50, 45)
        Me.tsbConfigurar.Tag = ""
        Me.tsbConfigurar.Text = "Config."
        Me.tsbConfigurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbConfigurar.ToolTipText = "Configuração do Ensaio"
        '
        'tsbLogotipo
        '
        Me.tsbLogotipo.AutoSize = False
        Me.tsbLogotipo.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbLogotipo.Image = CType(resources.GetObject("tsbLogotipo.Image"), System.Drawing.Image)
        Me.tsbLogotipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbLogotipo.Name = "tsbLogotipo"
        Me.tsbLogotipo.Size = New System.Drawing.Size(50, 45)
        Me.tsbLogotipo.Tag = ""
        Me.tsbLogotipo.Text = "Logotipo"
        Me.tsbLogotipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbLogotipo.ToolTipText = "Alterar Logotipo"
        '
        'tssSeparador4
        '
        Me.tssSeparador4.Name = "tssSeparador4"
        Me.tssSeparador4.Size = New System.Drawing.Size(6, 46)
        '
        'tsbLicença
        '
        Me.tsbLicença.AutoSize = False
        Me.tsbLicença.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbLicença.Image = CType(resources.GetObject("tsbLicença.Image"), System.Drawing.Image)
        Me.tsbLicença.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbLicença.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLicença.Name = "tsbLicença"
        Me.tsbLicença.Size = New System.Drawing.Size(50, 45)
        Me.tsbLicença.Text = "Licença"
        Me.tsbLicença.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbLicença.ToolTipText = "Licença Pavitest"
        '
        'tssSeparador2
        '
        Me.tssSeparador2.Name = "tssSeparador2"
        Me.tssSeparador2.Size = New System.Drawing.Size(6, 46)
        '
        'tsbSair
        '
        Me.tsbSair.AutoSize = False
        Me.tsbSair.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.tsbSair.Image = CType(resources.GetObject("tsbSair.Image"), System.Drawing.Image)
        Me.tsbSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbSair.Name = "tsbSair"
        Me.tsbSair.Size = New System.Drawing.Size(50, 45)
        Me.tsbSair.Tag = ""
        Me.tsbSair.Text = "Sair"
        Me.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbSair.ToolTipText = "Sair do Sistema"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1086, 676)
        Me.Controls.Add(Me.tlsBarraFerramenta)
        Me.Controls.Add(Me.mnuMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenu
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1089, 657)
        Me.Name = "mdiPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pavitest CBR (ISC) - 3.8B.BK.EF-00.04"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.tlsBarraFerramenta.ResumeLayout(False)
        Me.tlsBarraFerramenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuArquivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBancoDados1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBancoDados2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEnsaiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUtilitarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogotipo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPortaSerial As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalibrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConfigurar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuComunicar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLicença As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSeparador2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuInformacao As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents tlsBarraFerramenta As System.Windows.Forms.ToolStrip
    Public WithEvents tsbBaseDados As System.Windows.Forms.ToolStripButton
    Public WithEvents tsbAmostras As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsbPortaSerial As System.Windows.Forms.ToolStripButton
    Public WithEvents tsbComunicar As System.Windows.Forms.ToolStripButton
    Public WithEvents tsbCalibrar As System.Windows.Forms.ToolStripButton
    Public WithEvents tsbConfigurar As System.Windows.Forms.ToolStripButton
    Public WithEvents tsbLogotipo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbLicença As System.Windows.Forms.ToolStripButton
    Friend WithEvents tssSeparador2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsbSair As System.Windows.Forms.ToolStripButton
    Public WithEvents tsbPainel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
