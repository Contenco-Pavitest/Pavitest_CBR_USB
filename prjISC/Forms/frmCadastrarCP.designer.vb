<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastrarCP
#Region "Windows Form Designer generated code "

    ''Form overrides dispose to clean up the component list.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    '    If Disposing Then
    '        If Not components Is Nothing Then
    '            components.Dispose()
    '        End If
    '    End If
    '    MyBase.Dispose(Disposing)
    'End Sub

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

    Public WithEvents frmFrame2 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarCP))
        Me.frmFrame2 = New System.Windows.Forms.GroupBox()
        Me.bdnNavegator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.tsbCount = New System.Windows.Forms.ToolStripLabel()
        Me.tsbMoverFirst = New System.Windows.Forms.ToolStripButton()
        Me.tsbMoverPrevious = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPosition = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMoverNext = New System.Windows.Forms.ToolStripButton()
        Me.tsbMoverLast = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancel = New System.Windows.Forms.ToolStripButton()
        Me.tbcCP = New System.Windows.Forms.TabControl()
        Me.tbpCompactacao = New System.Windows.Forms.TabPage()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblUmidade = New System.Windows.Forms.Label()
        Me.lblSoloSeco = New System.Windows.Forms.Label()
        Me.lblAgua = New System.Windows.Forms.Label()
        Me.lblMassaSeca = New System.Windows.Forms.Label()
        Me.lblMassaUmida = New System.Windows.Forms.Label()
        Me.lblSoloUmido = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLabel18 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.lblLabel28 = New System.Windows.Forms.Label()
        Me.lblLabel26 = New System.Windows.Forms.Label()
        Me.lblLabel25 = New System.Windows.Forms.Label()
        Me.lblLabel23 = New System.Windows.Forms.Label()
        Me.lblLabel24 = New System.Windows.Forms.Label()
        Me.lblLabel27 = New System.Windows.Forms.Label()
        Me.lblLabel22 = New System.Windows.Forms.Label()
        Me.lblLabel20 = New System.Windows.Forms.Label()
        Me.lblLabel21 = New System.Windows.Forms.Label()
        Me.lblLabel19 = New System.Windows.Forms.Label()
        Me.lblLabel16 = New System.Windows.Forms.Label()
        Me.lblLabel14 = New System.Windows.Forms.Label()
        Me.lblLabel7 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblLabel15 = New System.Windows.Forms.Label()
        Me.lblLabel12 = New System.Windows.Forms.Label()
        Me.lblLabel11 = New System.Windows.Forms.Label()
        Me.lblLabel17 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtCapsula = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtUmidoTara = New System.Windows.Forms.TextBox()
        Me.txtSecoTara = New System.Windows.Forms.TextBox()
        Me.txtTara = New System.Windows.Forms.TextBox()
        Me.txtSoloCilindro = New System.Windows.Forms.TextBox()
        Me.cmbCilindro = New System.Windows.Forms.ComboBox()
        Me.txtEnsaioRealizado = New System.Windows.Forms.TextBox()
        Me.tbpExpansao = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLeitura4 = New System.Windows.Forms.TextBox()
        Me.txtLeitura3 = New System.Windows.Forms.TextBox()
        Me.txtLeitura2 = New System.Windows.Forms.TextBox()
        Me.txtLeitura1 = New System.Windows.Forms.TextBox()
        Me.txtLeitura0 = New System.Windows.Forms.TextBox()
        Me.mskHora4 = New System.Windows.Forms.MaskedTextBox()
        Me.mskHora3 = New System.Windows.Forms.MaskedTextBox()
        Me.mskHora2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskHora1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskHora0 = New System.Windows.Forms.MaskedTextBox()
        Me.mskData4 = New System.Windows.Forms.MaskedTextBox()
        Me.mskData3 = New System.Windows.Forms.MaskedTextBox()
        Me.mskData2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskData1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskData0 = New System.Windows.Forms.MaskedTextBox()
        Me.lblLeitura = New System.Windows.Forms.Label()
        Me.lblHoraEnsaio = New System.Windows.Forms.Label()
        Me.lblDataEnsaio = New System.Windows.Forms.Label()
        Me.lblAguaAbsorvida = New System.Windows.Forms.Label()
        Me.lblAlturaCP = New System.Windows.Forms.Label()
        Me.lblMoldeInicial = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtMoldeFinal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblExpansao = New System.Windows.Forms.Label()
        Me.lblDiferenca = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbpPenetracao = New System.Windows.Forms.TabPage()
        Me.txtCalculada1 = New System.Windows.Forms.TextBox()
        Me.txtCalculada0 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtISC2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtISC1 = New System.Windows.Forms.TextBox()
        Me.txtISC0 = New System.Windows.Forms.TextBox()
        Me.txtPadrao1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtPadrao0 = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCorrigida1 = New System.Windows.Forms.TextBox()
        Me.txtCorrigida0 = New System.Windows.Forms.TextBox()
        Me.txtPenetracao1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtPenetracao0 = New System.Windows.Forms.MaskedTextBox()
        Me.lblLegendaPressao = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.frmFrame1 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblTipoEnsaio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEnergia = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.btnRever = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnEnsaiar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.btnCilindro = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.bdnSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBuscarCilindro = New System.Windows.Forms.Button()
        Me.frmFrame2.SuspendLayout()
        CType(Me.bdnNavegator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnNavegator.SuspendLayout()
        Me.tbcCP.SuspendLayout()
        Me.tbpCompactacao.SuspendLayout()
        Me.tbpExpansao.SuspendLayout()
        Me.tbpPenetracao.SuspendLayout()
        Me.frmFrame1.SuspendLayout()
        Me.pnlPanel.SuspendLayout()
        CType(Me.bdnSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmFrame2
        '
        Me.frmFrame2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.frmFrame2.Controls.Add(Me.bdnNavegator)
        Me.frmFrame2.Controls.Add(Me.tbcCP)
        Me.frmFrame2.Controls.Add(Me.frmFrame1)
        Me.frmFrame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmFrame2.Location = New System.Drawing.Point(12, 7)
        Me.frmFrame2.Name = "frmFrame2"
        Me.frmFrame2.Padding = New System.Windows.Forms.Padding(0)
        Me.frmFrame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmFrame2.Size = New System.Drawing.Size(568, 454)
        Me.frmFrame2.TabIndex = 0
        Me.frmFrame2.TabStop = False
        '
        'bdnNavegator
        '
        Me.bdnNavegator.AddNewItem = Nothing
        Me.bdnNavegator.BackColor = System.Drawing.Color.Transparent
        Me.bdnNavegator.BindingSource = Me.bdnSource
        Me.bdnNavegator.CountItem = Me.tsbCount
        Me.bdnNavegator.DeleteItem = Nothing
        Me.bdnNavegator.Dock = System.Windows.Forms.DockStyle.None
        Me.bdnNavegator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbMoverFirst, Me.tsbMoverPrevious, Me.tsbSeparator1, Me.tsbPosition, Me.tsbCount, Me.tsbSeparator2, Me.tsbMoverNext, Me.tsbMoverLast, Me.tsbSeparator3, Me.tsbAdd, Me.tsbEdit, Me.tsbDelete, Me.tsbSave, Me.tsbCancel})
        Me.bdnNavegator.Location = New System.Drawing.Point(15, 427)
        Me.bdnNavegator.MoveFirstItem = Me.tsbMoverFirst
        Me.bdnNavegator.MoveLastItem = Me.tsbMoverLast
        Me.bdnNavegator.MoveNextItem = Me.tsbMoverNext
        Me.bdnNavegator.MovePreviousItem = Me.tsbMoverPrevious
        Me.bdnNavegator.Name = "bdnNavegator"
        Me.bdnNavegator.PositionItem = Me.tsbPosition
        Me.bdnNavegator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.bdnNavegator.Size = New System.Drawing.Size(326, 25)
        Me.bdnNavegator.TabIndex = 181
        '
        'tsbCount
        '
        Me.tsbCount.Name = "tsbCount"
        Me.tsbCount.Size = New System.Drawing.Size(37, 22)
        Me.tsbCount.Text = "de {0}"
        Me.tsbCount.ToolTipText = "Total number of items"
        '
        'tsbMoverFirst
        '
        Me.tsbMoverFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverFirst.Image = CType(resources.GetObject("tsbMoverFirst.Image"), System.Drawing.Image)
        Me.tsbMoverFirst.Name = "tsbMoverFirst"
        Me.tsbMoverFirst.RightToLeftAutoMirrorImage = True
        Me.tsbMoverFirst.Size = New System.Drawing.Size(23, 22)
        Me.tsbMoverFirst.Text = "Move first"
        '
        'tsbMoverPrevious
        '
        Me.tsbMoverPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverPrevious.Image = CType(resources.GetObject("tsbMoverPrevious.Image"), System.Drawing.Image)
        Me.tsbMoverPrevious.Name = "tsbMoverPrevious"
        Me.tsbMoverPrevious.RightToLeftAutoMirrorImage = True
        Me.tsbMoverPrevious.Size = New System.Drawing.Size(23, 22)
        Me.tsbMoverPrevious.Text = "Move previous"
        '
        'tsbSeparator1
        '
        Me.tsbSeparator1.Name = "tsbSeparator1"
        Me.tsbSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPosition
        '
        Me.tsbPosition.AccessibleName = "Position"
        Me.tsbPosition.AutoSize = False
        Me.tsbPosition.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsbPosition.Name = "tsbPosition"
        Me.tsbPosition.Size = New System.Drawing.Size(50, 21)
        Me.tsbPosition.Text = "0"
        Me.tsbPosition.ToolTipText = "Current position"
        '
        'tsbSeparator2
        '
        Me.tsbSeparator2.Name = "tsbSeparator2"
        Me.tsbSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbMoverNext
        '
        Me.tsbMoverNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverNext.Image = CType(resources.GetObject("tsbMoverNext.Image"), System.Drawing.Image)
        Me.tsbMoverNext.Name = "tsbMoverNext"
        Me.tsbMoverNext.RightToLeftAutoMirrorImage = True
        Me.tsbMoverNext.Size = New System.Drawing.Size(23, 22)
        Me.tsbMoverNext.Text = "Move next"
        '
        'tsbMoverLast
        '
        Me.tsbMoverLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverLast.Image = CType(resources.GetObject("tsbMoverLast.Image"), System.Drawing.Image)
        Me.tsbMoverLast.Name = "tsbMoverLast"
        Me.tsbMoverLast.RightToLeftAutoMirrorImage = True
        Me.tsbMoverLast.Size = New System.Drawing.Size(23, 22)
        Me.tsbMoverLast.Text = "Move last"
        '
        'tsbSeparator3
        '
        Me.tsbSeparator3.Name = "tsbSeparator3"
        Me.tsbSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAdd
        '
        Me.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.RightToLeftAutoMirrorImage = True
        Me.tsbAdd.Size = New System.Drawing.Size(23, 22)
        Me.tsbAdd.Text = "Adicionar"
        '
        'tsbEdit
        '
        Me.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEdit.Image = CType(resources.GetObject("tsbEdit.Image"), System.Drawing.Image)
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.White
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.RightToLeftAutoMirrorImage = True
        Me.tsbEdit.Size = New System.Drawing.Size(23, 22)
        Me.tsbEdit.Text = "Editar"
        '
        'tsbDelete
        '
        Me.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.RightToLeftAutoMirrorImage = True
        Me.tsbDelete.Size = New System.Drawing.Size(23, 22)
        Me.tsbDelete.Text = "Apagar"
        '
        'tsbSave
        '
        Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSave.Image = CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image)
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.RightToLeftAutoMirrorImage = True
        Me.tsbSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbSave.Text = "Salvar"
        '
        'tsbCancel
        '
        Me.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancel.Image = CType(resources.GetObject("tsbCancel.Image"), System.Drawing.Image)
        Me.tsbCancel.ImageTransparentColor = System.Drawing.Color.White
        Me.tsbCancel.Name = "tsbCancel"
        Me.tsbCancel.RightToLeftAutoMirrorImage = True
        Me.tsbCancel.Size = New System.Drawing.Size(23, 22)
        Me.tsbCancel.Text = "Cancelar"
        '
        'tbcCP
        '
        Me.tbcCP.Controls.Add(Me.tbpCompactacao)
        Me.tbcCP.Controls.Add(Me.tbpExpansao)
        Me.tbcCP.Controls.Add(Me.tbpPenetracao)
        Me.tbcCP.Location = New System.Drawing.Point(15, 153)
        Me.tbcCP.Name = "tbcCP"
        Me.tbcCP.SelectedIndex = 0
        Me.tbcCP.Size = New System.Drawing.Size(536, 271)
        Me.tbcCP.TabIndex = 13
        '
        'tbpCompactacao
        '
        Me.tbpCompactacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpCompactacao.Controls.Add(Me.btnBuscarCilindro)
        Me.tbpCompactacao.Controls.Add(Me.txtAltura)
        Me.tbpCompactacao.Controls.Add(Me.Label12)
        Me.tbpCompactacao.Controls.Add(Me.Label13)
        Me.tbpCompactacao.Controls.Add(Me.lblUmidade)
        Me.tbpCompactacao.Controls.Add(Me.lblSoloSeco)
        Me.tbpCompactacao.Controls.Add(Me.lblAgua)
        Me.tbpCompactacao.Controls.Add(Me.lblMassaSeca)
        Me.tbpCompactacao.Controls.Add(Me.lblMassaUmida)
        Me.tbpCompactacao.Controls.Add(Me.lblSoloUmido)
        Me.tbpCompactacao.Controls.Add(Me.txtVolume)
        Me.tbpCompactacao.Controls.Add(Me.Label1)
        Me.tbpCompactacao.Controls.Add(Me.Label2)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel18)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel2)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel3)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel5)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel28)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel26)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel25)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel23)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel24)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel27)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel22)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel20)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel21)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel19)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel16)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel14)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel7)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel9)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel8)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel10)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel15)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel12)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel11)
        Me.tbpCompactacao.Controls.Add(Me.lblLabel17)
        Me.tbpCompactacao.Controls.Add(Me.txtPeso)
        Me.tbpCompactacao.Controls.Add(Me.txtCapsula)
        Me.tbpCompactacao.Controls.Add(Me.txtId)
        Me.tbpCompactacao.Controls.Add(Me.txtUmidoTara)
        Me.tbpCompactacao.Controls.Add(Me.txtSecoTara)
        Me.tbpCompactacao.Controls.Add(Me.txtTara)
        Me.tbpCompactacao.Controls.Add(Me.txtSoloCilindro)
        Me.tbpCompactacao.Controls.Add(Me.cmbCilindro)
        Me.tbpCompactacao.Controls.Add(Me.txtEnsaioRealizado)
        Me.tbpCompactacao.Location = New System.Drawing.Point(4, 22)
        Me.tbpCompactacao.Name = "tbpCompactacao"
        Me.tbpCompactacao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCompactacao.Size = New System.Drawing.Size(528, 245)
        Me.tbpCompactacao.TabIndex = 0
        Me.tbpCompactacao.Text = "ENSAIO DE COMPACTAÇÃO"
        '
        'txtAltura
        '
        Me.txtAltura.AcceptsReturn = True
        Me.txtAltura.BackColor = System.Drawing.SystemColors.Window
        Me.txtAltura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAltura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAltura.Location = New System.Drawing.Point(149, 92)
        Me.txtAltura.MaxLength = 0
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAltura.Size = New System.Drawing.Size(51, 20)
        Me.txtAltura.TabIndex = 3
        Me.txtAltura.Tag = "1"
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(202, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 308
        Me.Label12.Text = "(mm)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(24, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 307
        Me.Label13.Text = "Altura do CP:"
        '
        'lblUmidade
        '
        Me.lblUmidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUmidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUmidade.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUmidade.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUmidade.Location = New System.Drawing.Point(414, 193)
        Me.lblUmidade.Name = "lblUmidade"
        Me.lblUmidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUmidade.Size = New System.Drawing.Size(51, 19)
        Me.lblUmidade.TabIndex = 14
        Me.lblUmidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoloSeco
        '
        Me.lblSoloSeco.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSoloSeco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoloSeco.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSoloSeco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSoloSeco.Location = New System.Drawing.Point(414, 169)
        Me.lblSoloSeco.Name = "lblSoloSeco"
        Me.lblSoloSeco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSoloSeco.Size = New System.Drawing.Size(51, 19)
        Me.lblSoloSeco.TabIndex = 13
        Me.lblSoloSeco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAgua
        '
        Me.lblAgua.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAgua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAgua.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAgua.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAgua.Location = New System.Drawing.Point(414, 122)
        Me.lblAgua.Name = "lblAgua"
        Me.lblAgua.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAgua.Size = New System.Drawing.Size(51, 19)
        Me.lblAgua.TabIndex = 11
        Me.lblAgua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMassaSeca
        '
        Me.lblMassaSeca.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMassaSeca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMassaSeca.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMassaSeca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMassaSeca.Location = New System.Drawing.Point(149, 190)
        Me.lblMassaSeca.Name = "lblMassaSeca"
        Me.lblMassaSeca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMassaSeca.Size = New System.Drawing.Size(51, 19)
        Me.lblMassaSeca.TabIndex = 7
        Me.lblMassaSeca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMassaUmida
        '
        Me.lblMassaUmida.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMassaUmida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMassaUmida.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMassaUmida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMassaUmida.Location = New System.Drawing.Point(149, 166)
        Me.lblMassaUmida.Name = "lblMassaUmida"
        Me.lblMassaUmida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMassaUmida.Size = New System.Drawing.Size(51, 19)
        Me.lblMassaUmida.TabIndex = 6
        Me.lblMassaUmida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoloUmido
        '
        Me.lblSoloUmido.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSoloUmido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoloUmido.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSoloUmido.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSoloUmido.Location = New System.Drawing.Point(149, 141)
        Me.lblSoloUmido.Name = "lblSoloUmido"
        Me.lblSoloUmido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSoloUmido.Size = New System.Drawing.Size(51, 19)
        Me.lblSoloUmido.TabIndex = 5
        Me.lblSoloUmido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolume
        '
        Me.txtVolume.AcceptsReturn = True
        Me.txtVolume.BackColor = System.Drawing.SystemColors.Window
        Me.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVolume.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVolume.Location = New System.Drawing.Point(149, 68)
        Me.txtVolume.MaxLength = 0
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVolume.Size = New System.Drawing.Size(51, 20)
        Me.txtVolume.TabIndex = 2
        Me.txtVolume.Tag = "1"
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(471, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 259
        Me.Label1.Text = "(g)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(297, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 258
        Me.Label2.Text = "Água:"
        '
        'lblLabel18
        '
        Me.lblLabel18.AutoSize = True
        Me.lblLabel18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel18.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel18.Location = New System.Drawing.Point(471, 74)
        Me.lblLabel18.Name = "lblLabel18"
        Me.lblLabel18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel18.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel18.TabIndex = 249
        Me.lblLabel18.Text = "(g)"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel2.Location = New System.Drawing.Point(201, 169)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel2.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel2.TabIndex = 247
        Me.lblLabel2.Text = "(g/cm³)"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel3.Location = New System.Drawing.Point(201, 193)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel3.Size = New System.Drawing.Size(41, 13)
        Me.lblLabel3.TabIndex = 246
        Me.lblLabel3.Text = "(g/cm³)"
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel5.Location = New System.Drawing.Point(24, 193)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel5.Size = New System.Drawing.Size(97, 13)
        Me.lblLabel5.TabIndex = 244
        Me.lblLabel5.Text = "Massa Esp. Ap. S.:"
        '
        'lblLabel28
        '
        Me.lblLabel28.AutoSize = True
        Me.lblLabel28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel28.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel28.Location = New System.Drawing.Point(471, 172)
        Me.lblLabel28.Name = "lblLabel28"
        Me.lblLabel28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel28.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel28.TabIndex = 243
        Me.lblLabel28.Text = "(g)"
        '
        'lblLabel26
        '
        Me.lblLabel26.AutoSize = True
        Me.lblLabel26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel26.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel26.Location = New System.Drawing.Point(471, 100)
        Me.lblLabel26.Name = "lblLabel26"
        Me.lblLabel26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel26.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel26.TabIndex = 242
        Me.lblLabel26.Text = "(g)"
        '
        'lblLabel25
        '
        Me.lblLabel25.AutoSize = True
        Me.lblLabel25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel25.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel25.Location = New System.Drawing.Point(471, 196)
        Me.lblLabel25.Name = "lblLabel25"
        Me.lblLabel25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel25.Size = New System.Drawing.Size(21, 13)
        Me.lblLabel25.TabIndex = 241
        Me.lblLabel25.Text = "(%)"
        '
        'lblLabel23
        '
        Me.lblLabel23.AutoSize = True
        Me.lblLabel23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel23.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel23.Location = New System.Drawing.Point(297, 170)
        Me.lblLabel23.Name = "lblLabel23"
        Me.lblLabel23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel23.Size = New System.Drawing.Size(59, 13)
        Me.lblLabel23.TabIndex = 240
        Me.lblLabel23.Text = "Solo Seco:"
        '
        'lblLabel24
        '
        Me.lblLabel24.AutoSize = True
        Me.lblLabel24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel24.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel24.Location = New System.Drawing.Point(297, 196)
        Me.lblLabel24.Name = "lblLabel24"
        Me.lblLabel24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel24.Size = New System.Drawing.Size(52, 13)
        Me.lblLabel24.TabIndex = 239
        Me.lblLabel24.Text = "Umidade:"
        '
        'lblLabel27
        '
        Me.lblLabel27.AutoSize = True
        Me.lblLabel27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel27.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel27.Location = New System.Drawing.Point(471, 148)
        Me.lblLabel27.Name = "lblLabel27"
        Me.lblLabel27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel27.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel27.TabIndex = 238
        Me.lblLabel27.Text = "(g)"
        '
        'lblLabel22
        '
        Me.lblLabel22.AutoSize = True
        Me.lblLabel22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel22.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel22.Location = New System.Drawing.Point(297, 145)
        Me.lblLabel22.Name = "lblLabel22"
        Me.lblLabel22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel22.Size = New System.Drawing.Size(32, 13)
        Me.lblLabel22.TabIndex = 237
        Me.lblLabel22.Text = "Tara:"
        '
        'lblLabel20
        '
        Me.lblLabel20.AutoSize = True
        Me.lblLabel20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel20.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel20.Location = New System.Drawing.Point(297, 73)
        Me.lblLabel20.Name = "lblLabel20"
        Me.lblLabel20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel20.Size = New System.Drawing.Size(87, 13)
        Me.lblLabel20.TabIndex = 236
        Me.lblLabel20.Text = "Solo Úm. + Tara:"
        '
        'lblLabel21
        '
        Me.lblLabel21.AutoSize = True
        Me.lblLabel21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel21.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel21.Location = New System.Drawing.Point(297, 99)
        Me.lblLabel21.Name = "lblLabel21"
        Me.lblLabel21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel21.Size = New System.Drawing.Size(93, 13)
        Me.lblLabel21.TabIndex = 235
        Me.lblLabel21.Text = "Solo Seco + Tara:"
        '
        'lblLabel19
        '
        Me.lblLabel19.AutoSize = True
        Me.lblLabel19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel19.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel19.Location = New System.Drawing.Point(297, 47)
        Me.lblLabel19.Name = "lblLabel19"
        Me.lblLabel19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel19.Size = New System.Drawing.Size(48, 13)
        Me.lblLabel19.TabIndex = 234
        Me.lblLabel19.Text = "Cápsula:"
        '
        'lblLabel16
        '
        Me.lblLabel16.AutoSize = True
        Me.lblLabel16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel16.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel16.Location = New System.Drawing.Point(201, 118)
        Me.lblLabel16.Name = "lblLabel16"
        Me.lblLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel16.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel16.TabIndex = 233
        Me.lblLabel16.Text = "(g)"
        '
        'lblLabel14
        '
        Me.lblLabel14.AutoSize = True
        Me.lblLabel14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel14.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel14.Location = New System.Drawing.Point(202, 48)
        Me.lblLabel14.Name = "lblLabel14"
        Me.lblLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel14.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel14.TabIndex = 232
        Me.lblLabel14.Text = "(g)"
        '
        'lblLabel7
        '
        Me.lblLabel7.AutoSize = True
        Me.lblLabel7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel7.Location = New System.Drawing.Point(24, 21)
        Me.lblLabel7.Name = "lblLabel7"
        Me.lblLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel7.Size = New System.Drawing.Size(59, 13)
        Me.lblLabel7.TabIndex = 218
        Me.lblLabel7.Text = "Cilindro Nº:"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel9.Location = New System.Drawing.Point(24, 73)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel9.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel9.TabIndex = 230
        Me.lblLabel9.Text = "Volume:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel8.Location = New System.Drawing.Point(24, 47)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel8.Size = New System.Drawing.Size(34, 13)
        Me.lblLabel8.TabIndex = 224
        Me.lblLabel8.Text = "Peso:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel10.Location = New System.Drawing.Point(23, 120)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel10.Size = New System.Drawing.Size(96, 13)
        Me.lblLabel10.TabIndex = 229
        Me.lblLabel10.Text = "Solo Úm.+ Cilindro:"
        '
        'lblLabel15
        '
        Me.lblLabel15.AutoSize = True
        Me.lblLabel15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel15.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel15.Location = New System.Drawing.Point(202, 72)
        Me.lblLabel15.Name = "lblLabel15"
        Me.lblLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel15.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel15.TabIndex = 228
        Me.lblLabel15.Text = "(cm³)"
        '
        'lblLabel12
        '
        Me.lblLabel12.AutoSize = True
        Me.lblLabel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel12.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel12.Location = New System.Drawing.Point(23, 168)
        Me.lblLabel12.Name = "lblLabel12"
        Me.lblLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel12.Size = New System.Drawing.Size(98, 13)
        Me.lblLabel12.TabIndex = 227
        Me.lblLabel12.Text = "Massa Esp. Ap. U.:"
        '
        'lblLabel11
        '
        Me.lblLabel11.AutoSize = True
        Me.lblLabel11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel11.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel11.Location = New System.Drawing.Point(23, 144)
        Me.lblLabel11.Name = "lblLabel11"
        Me.lblLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel11.Size = New System.Drawing.Size(64, 13)
        Me.lblLabel11.TabIndex = 226
        Me.lblLabel11.Text = "Solo Úmido:"
        '
        'lblLabel17
        '
        Me.lblLabel17.AutoSize = True
        Me.lblLabel17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel17.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel17.Location = New System.Drawing.Point(201, 144)
        Me.lblLabel17.Name = "lblLabel17"
        Me.lblLabel17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel17.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel17.TabIndex = 225
        Me.lblLabel17.Text = "(g)"
        '
        'txtPeso
        '
        Me.txtPeso.AcceptsReturn = True
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPeso.Location = New System.Drawing.Point(149, 44)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(51, 20)
        Me.txtPeso.TabIndex = 1
        Me.txtPeso.Tag = "1"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCapsula
        '
        Me.txtCapsula.AcceptsReturn = True
        Me.txtCapsula.BackColor = System.Drawing.SystemColors.Window
        Me.txtCapsula.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCapsula.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCapsula.Location = New System.Drawing.Point(414, 44)
        Me.txtCapsula.MaxLength = 0
        Me.txtCapsula.Name = "txtCapsula"
        Me.txtCapsula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCapsula.Size = New System.Drawing.Size(51, 20)
        Me.txtCapsula.TabIndex = 8
        Me.txtCapsula.Tag = "1"
        Me.txtCapsula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(421, 44)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(44, 20)
        Me.txtId.TabIndex = 19
        '
        'txtUmidoTara
        '
        Me.txtUmidoTara.AcceptsReturn = True
        Me.txtUmidoTara.BackColor = System.Drawing.SystemColors.Window
        Me.txtUmidoTara.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUmidoTara.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUmidoTara.Location = New System.Drawing.Point(414, 70)
        Me.txtUmidoTara.MaxLength = 0
        Me.txtUmidoTara.Name = "txtUmidoTara"
        Me.txtUmidoTara.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUmidoTara.Size = New System.Drawing.Size(51, 20)
        Me.txtUmidoTara.TabIndex = 9
        Me.txtUmidoTara.Tag = "1"
        Me.txtUmidoTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSecoTara
        '
        Me.txtSecoTara.AcceptsReturn = True
        Me.txtSecoTara.BackColor = System.Drawing.SystemColors.Window
        Me.txtSecoTara.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecoTara.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSecoTara.Location = New System.Drawing.Point(414, 96)
        Me.txtSecoTara.MaxLength = 0
        Me.txtSecoTara.Name = "txtSecoTara"
        Me.txtSecoTara.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSecoTara.Size = New System.Drawing.Size(51, 20)
        Me.txtSecoTara.TabIndex = 10
        Me.txtSecoTara.Tag = "1"
        Me.txtSecoTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTara
        '
        Me.txtTara.AcceptsReturn = True
        Me.txtTara.BackColor = System.Drawing.SystemColors.Window
        Me.txtTara.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTara.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTara.Location = New System.Drawing.Point(414, 144)
        Me.txtTara.MaxLength = 0
        Me.txtTara.Name = "txtTara"
        Me.txtTara.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTara.Size = New System.Drawing.Size(51, 20)
        Me.txtTara.TabIndex = 12
        Me.txtTara.Tag = "1"
        Me.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSoloCilindro
        '
        Me.txtSoloCilindro.AcceptsReturn = True
        Me.txtSoloCilindro.BackColor = System.Drawing.SystemColors.Window
        Me.txtSoloCilindro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoloCilindro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSoloCilindro.Location = New System.Drawing.Point(149, 114)
        Me.txtSoloCilindro.MaxLength = 0
        Me.txtSoloCilindro.Name = "txtSoloCilindro"
        Me.txtSoloCilindro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSoloCilindro.Size = New System.Drawing.Size(51, 20)
        Me.txtSoloCilindro.TabIndex = 4
        Me.txtSoloCilindro.Tag = "1"
        Me.txtSoloCilindro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCilindro
        '
        Me.cmbCilindro.FormattingEnabled = True
        Me.cmbCilindro.Location = New System.Drawing.Point(149, 17)
        Me.cmbCilindro.Name = "cmbCilindro"
        Me.cmbCilindro.Size = New System.Drawing.Size(146, 21)
        Me.cmbCilindro.TabIndex = 0
        '
        'txtEnsaioRealizado
        '
        Me.txtEnsaioRealizado.AcceptsReturn = True
        Me.txtEnsaioRealizado.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnsaioRealizado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnsaioRealizado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnsaioRealizado.Location = New System.Drawing.Point(150, 18)
        Me.txtEnsaioRealizado.MaxLength = 0
        Me.txtEnsaioRealizado.Name = "txtEnsaioRealizado"
        Me.txtEnsaioRealizado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnsaioRealizado.Size = New System.Drawing.Size(51, 20)
        Me.txtEnsaioRealizado.TabIndex = 276
        Me.txtEnsaioRealizado.Tag = "1"
        Me.txtEnsaioRealizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbpExpansao
        '
        Me.tbpExpansao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpExpansao.Controls.Add(Me.TextBox5)
        Me.tbpExpansao.Controls.Add(Me.TextBox4)
        Me.tbpExpansao.Controls.Add(Me.TextBox3)
        Me.tbpExpansao.Controls.Add(Me.TextBox2)
        Me.tbpExpansao.Controls.Add(Me.TextBox1)
        Me.tbpExpansao.Controls.Add(Me.Label4)
        Me.tbpExpansao.Controls.Add(Me.txtLeitura4)
        Me.tbpExpansao.Controls.Add(Me.txtLeitura3)
        Me.tbpExpansao.Controls.Add(Me.txtLeitura2)
        Me.tbpExpansao.Controls.Add(Me.txtLeitura1)
        Me.tbpExpansao.Controls.Add(Me.txtLeitura0)
        Me.tbpExpansao.Controls.Add(Me.mskHora4)
        Me.tbpExpansao.Controls.Add(Me.mskHora3)
        Me.tbpExpansao.Controls.Add(Me.mskHora2)
        Me.tbpExpansao.Controls.Add(Me.mskHora1)
        Me.tbpExpansao.Controls.Add(Me.mskHora0)
        Me.tbpExpansao.Controls.Add(Me.mskData4)
        Me.tbpExpansao.Controls.Add(Me.mskData3)
        Me.tbpExpansao.Controls.Add(Me.mskData2)
        Me.tbpExpansao.Controls.Add(Me.mskData1)
        Me.tbpExpansao.Controls.Add(Me.mskData0)
        Me.tbpExpansao.Controls.Add(Me.lblLeitura)
        Me.tbpExpansao.Controls.Add(Me.lblHoraEnsaio)
        Me.tbpExpansao.Controls.Add(Me.lblDataEnsaio)
        Me.tbpExpansao.Controls.Add(Me.lblAguaAbsorvida)
        Me.tbpExpansao.Controls.Add(Me.lblAlturaCP)
        Me.tbpExpansao.Controls.Add(Me.lblMoldeInicial)
        Me.tbpExpansao.Controls.Add(Me.Label25)
        Me.tbpExpansao.Controls.Add(Me.txtMoldeFinal)
        Me.tbpExpansao.Controls.Add(Me.Label24)
        Me.tbpExpansao.Controls.Add(Me.Label16)
        Me.tbpExpansao.Controls.Add(Me.Label17)
        Me.tbpExpansao.Controls.Add(Me.Label18)
        Me.tbpExpansao.Controls.Add(Me.Label19)
        Me.tbpExpansao.Controls.Add(Me.Label20)
        Me.tbpExpansao.Controls.Add(Me.Label5)
        Me.tbpExpansao.Controls.Add(Me.Label21)
        Me.tbpExpansao.Controls.Add(Me.lblExpansao)
        Me.tbpExpansao.Controls.Add(Me.lblDiferenca)
        Me.tbpExpansao.Controls.Add(Me.Label8)
        Me.tbpExpansao.Controls.Add(Me.Label9)
        Me.tbpExpansao.Controls.Add(Me.Label10)
        Me.tbpExpansao.Controls.Add(Me.Label11)
        Me.tbpExpansao.Location = New System.Drawing.Point(4, 22)
        Me.tbpExpansao.Name = "tbpExpansao"
        Me.tbpExpansao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpExpansao.Size = New System.Drawing.Size(528, 245)
        Me.tbpExpansao.TabIndex = 1
        Me.tbpExpansao.Text = "ENSAIO DE EXPANSÃO"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(67, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(108, 20)
        Me.TextBox5.TabIndex = 307
        Me.TextBox5.Text = "4"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(67, 97)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(108, 20)
        Me.TextBox4.TabIndex = 307
        Me.TextBox4.Text = "3"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(67, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(108, 20)
        Me.TextBox3.TabIndex = 307
        Me.TextBox3.Text = "2"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(67, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(108, 20)
        Me.TextBox2.TabIndex = 307
        Me.TextBox2.Text = "1"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(67, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 20)
        Me.TextBox1.TabIndex = 307
        Me.TextBox1.Text = "Início"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(67, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(108, 34)
        Me.Label4.TabIndex = 306
        Me.Label4.Text = "Tempo Decorrido (dias)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLeitura4
        '
        Me.txtLeitura4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLeitura4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeitura4.Location = New System.Drawing.Point(364, 116)
        Me.txtLeitura4.Name = "txtLeitura4"
        Me.txtLeitura4.Size = New System.Drawing.Size(97, 20)
        Me.txtLeitura4.TabIndex = 18
        Me.txtLeitura4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLeitura3
        '
        Me.txtLeitura3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLeitura3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeitura3.Location = New System.Drawing.Point(364, 97)
        Me.txtLeitura3.Name = "txtLeitura3"
        Me.txtLeitura3.Size = New System.Drawing.Size(97, 20)
        Me.txtLeitura3.TabIndex = 14
        Me.txtLeitura3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLeitura2
        '
        Me.txtLeitura2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLeitura2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeitura2.Location = New System.Drawing.Point(364, 79)
        Me.txtLeitura2.Name = "txtLeitura2"
        Me.txtLeitura2.Size = New System.Drawing.Size(97, 20)
        Me.txtLeitura2.TabIndex = 10
        Me.txtLeitura2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLeitura1
        '
        Me.txtLeitura1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLeitura1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeitura1.Location = New System.Drawing.Point(364, 60)
        Me.txtLeitura1.Name = "txtLeitura1"
        Me.txtLeitura1.Size = New System.Drawing.Size(97, 20)
        Me.txtLeitura1.TabIndex = 6
        Me.txtLeitura1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLeitura0
        '
        Me.txtLeitura0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLeitura0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLeitura0.Location = New System.Drawing.Point(364, 41)
        Me.txtLeitura0.Name = "txtLeitura0"
        Me.txtLeitura0.Size = New System.Drawing.Size(97, 20)
        Me.txtLeitura0.TabIndex = 2
        Me.txtLeitura0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mskHora4
        '
        Me.mskHora4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskHora4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskHora4.Location = New System.Drawing.Point(268, 116)
        Me.mskHora4.Mask = "00:00"
        Me.mskHora4.Name = "mskHora4"
        Me.mskHora4.Size = New System.Drawing.Size(97, 20)
        Me.mskHora4.TabIndex = 17
        Me.mskHora4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHora4.ValidatingType = GetType(Date)
        '
        'mskHora3
        '
        Me.mskHora3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskHora3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskHora3.Location = New System.Drawing.Point(268, 97)
        Me.mskHora3.Mask = "00:00"
        Me.mskHora3.Name = "mskHora3"
        Me.mskHora3.Size = New System.Drawing.Size(97, 20)
        Me.mskHora3.TabIndex = 13
        Me.mskHora3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHora3.ValidatingType = GetType(Date)
        '
        'mskHora2
        '
        Me.mskHora2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskHora2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskHora2.Location = New System.Drawing.Point(268, 79)
        Me.mskHora2.Mask = "00:00"
        Me.mskHora2.Name = "mskHora2"
        Me.mskHora2.Size = New System.Drawing.Size(97, 20)
        Me.mskHora2.TabIndex = 9
        Me.mskHora2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHora2.ValidatingType = GetType(Date)
        '
        'mskHora1
        '
        Me.mskHora1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskHora1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskHora1.Location = New System.Drawing.Point(268, 60)
        Me.mskHora1.Mask = "00:00"
        Me.mskHora1.Name = "mskHora1"
        Me.mskHora1.Size = New System.Drawing.Size(97, 20)
        Me.mskHora1.TabIndex = 5
        Me.mskHora1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHora1.ValidatingType = GetType(Date)
        '
        'mskHora0
        '
        Me.mskHora0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskHora0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskHora0.Location = New System.Drawing.Point(268, 41)
        Me.mskHora0.Mask = "00:00"
        Me.mskHora0.Name = "mskHora0"
        Me.mskHora0.Size = New System.Drawing.Size(97, 20)
        Me.mskHora0.TabIndex = 1
        Me.mskHora0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskHora0.ValidatingType = GetType(Date)
        '
        'mskData4
        '
        Me.mskData4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskData4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskData4.Location = New System.Drawing.Point(174, 116)
        Me.mskData4.Mask = "00/00/0000"
        Me.mskData4.Name = "mskData4"
        Me.mskData4.Size = New System.Drawing.Size(97, 20)
        Me.mskData4.TabIndex = 16
        Me.mskData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskData4.ValidatingType = GetType(Date)
        '
        'mskData3
        '
        Me.mskData3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskData3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskData3.Location = New System.Drawing.Point(174, 97)
        Me.mskData3.Mask = "00/00/0000"
        Me.mskData3.Name = "mskData3"
        Me.mskData3.Size = New System.Drawing.Size(97, 20)
        Me.mskData3.TabIndex = 12
        Me.mskData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskData3.ValidatingType = GetType(Date)
        '
        'mskData2
        '
        Me.mskData2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskData2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskData2.Location = New System.Drawing.Point(174, 79)
        Me.mskData2.Mask = "00/00/0000"
        Me.mskData2.Name = "mskData2"
        Me.mskData2.Size = New System.Drawing.Size(97, 20)
        Me.mskData2.TabIndex = 8
        Me.mskData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskData2.ValidatingType = GetType(Date)
        '
        'mskData1
        '
        Me.mskData1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskData1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskData1.Location = New System.Drawing.Point(174, 60)
        Me.mskData1.Mask = "00/00/0000"
        Me.mskData1.Name = "mskData1"
        Me.mskData1.Size = New System.Drawing.Size(97, 20)
        Me.mskData1.TabIndex = 4
        Me.mskData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskData1.ValidatingType = GetType(Date)
        '
        'mskData0
        '
        Me.mskData0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mskData0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mskData0.Location = New System.Drawing.Point(174, 41)
        Me.mskData0.Mask = "00/00/0000"
        Me.mskData0.Name = "mskData0"
        Me.mskData0.Size = New System.Drawing.Size(97, 20)
        Me.mskData0.TabIndex = 0
        Me.mskData0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mskData0.ValidatingType = GetType(Date)
        '
        'lblLeitura
        '
        Me.lblLeitura.BackColor = System.Drawing.Color.Transparent
        Me.lblLeitura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLeitura.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLeitura.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLeitura.Location = New System.Drawing.Point(364, 8)
        Me.lblLeitura.Name = "lblLeitura"
        Me.lblLeitura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLeitura.Size = New System.Drawing.Size(97, 34)
        Me.lblLeitura.TabIndex = 295
        Me.lblLeitura.Text = "Leitura Deflexão (mm)"
        Me.lblLeitura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoraEnsaio
        '
        Me.lblHoraEnsaio.BackColor = System.Drawing.Color.Transparent
        Me.lblHoraEnsaio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHoraEnsaio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblHoraEnsaio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHoraEnsaio.Location = New System.Drawing.Point(268, 8)
        Me.lblHoraEnsaio.Name = "lblHoraEnsaio"
        Me.lblHoraEnsaio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblHoraEnsaio.Size = New System.Drawing.Size(97, 34)
        Me.lblHoraEnsaio.TabIndex = 294
        Me.lblHoraEnsaio.Text = "Hora"
        Me.lblHoraEnsaio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDataEnsaio
        '
        Me.lblDataEnsaio.BackColor = System.Drawing.Color.Transparent
        Me.lblDataEnsaio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDataEnsaio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDataEnsaio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDataEnsaio.Location = New System.Drawing.Point(174, 8)
        Me.lblDataEnsaio.Name = "lblDataEnsaio"
        Me.lblDataEnsaio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDataEnsaio.Size = New System.Drawing.Size(97, 34)
        Me.lblDataEnsaio.TabIndex = 293
        Me.lblDataEnsaio.Text = "Data"
        Me.lblDataEnsaio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAguaAbsorvida
        '
        Me.lblAguaAbsorvida.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAguaAbsorvida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAguaAbsorvida.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAguaAbsorvida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAguaAbsorvida.Location = New System.Drawing.Point(403, 219)
        Me.lblAguaAbsorvida.Name = "lblAguaAbsorvida"
        Me.lblAguaAbsorvida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAguaAbsorvida.Size = New System.Drawing.Size(51, 19)
        Me.lblAguaAbsorvida.TabIndex = 24
        Me.lblAguaAbsorvida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlturaCP
        '
        Me.lblAlturaCP.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAlturaCP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlturaCP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAlturaCP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAlturaCP.Location = New System.Drawing.Point(178, 168)
        Me.lblAlturaCP.Name = "lblAlturaCP"
        Me.lblAlturaCP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlturaCP.Size = New System.Drawing.Size(51, 19)
        Me.lblAlturaCP.TabIndex = 19
        Me.lblAlturaCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoldeInicial
        '
        Me.lblMoldeInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMoldeInicial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMoldeInicial.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMoldeInicial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMoldeInicial.Location = New System.Drawing.Point(178, 219)
        Me.lblMoldeInicial.Name = "lblMoldeInicial"
        Me.lblMoldeInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMoldeInicial.Size = New System.Drawing.Size(51, 19)
        Me.lblMoldeInicial.TabIndex = 21
        Me.lblMoldeInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(235, 167)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(29, 13)
        Me.Label25.TabIndex = 289
        Me.Label25.Text = "(mm)"
        '
        'txtMoldeFinal
        '
        Me.txtMoldeFinal.AcceptsReturn = True
        Me.txtMoldeFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtMoldeFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMoldeFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMoldeFinal.Location = New System.Drawing.Point(178, 192)
        Me.txtMoldeFinal.MaxLength = 0
        Me.txtMoldeFinal.Name = "txtMoldeFinal"
        Me.txtMoldeFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMoldeFinal.Size = New System.Drawing.Size(51, 20)
        Me.txtMoldeFinal.TabIndex = 20
        Me.txtMoldeFinal.Tag = "1"
        Me.txtMoldeFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(33, 167)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(69, 13)
        Me.Label24.TabIndex = 288
        Me.Label24.Text = "Altura do CP:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(235, 222)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(19, 13)
        Me.Label16.TabIndex = 289
        Me.Label16.Text = "(g)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(33, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(124, 13)
        Me.Label17.TabIndex = 288
        Me.Label17.Text = "Molde + Solo Úm. Inicial:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(459, 222)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(19, 13)
        Me.Label18.TabIndex = 287
        Me.Label18.Text = "(g)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(312, 222)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(85, 13)
        Me.Label19.TabIndex = 286
        Me.Label19.Text = "Água Absorvida:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(235, 195)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 285
        Me.Label20.Text = "(g)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(64, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 284
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(33, 193)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(119, 13)
        Me.Label21.TabIndex = 284
        Me.Label21.Text = "Molde + Solo Úm. Final:"
        '
        'lblExpansao
        '
        Me.lblExpansao.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblExpansao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExpansao.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblExpansao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblExpansao.Location = New System.Drawing.Point(403, 168)
        Me.lblExpansao.Name = "lblExpansao"
        Me.lblExpansao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExpansao.Size = New System.Drawing.Size(51, 19)
        Me.lblExpansao.TabIndex = 22
        Me.lblExpansao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiferenca
        '
        Me.lblDiferenca.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDiferenca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiferenca.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiferenca.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDiferenca.Location = New System.Drawing.Point(403, 192)
        Me.lblDiferenca.Name = "lblDiferenca"
        Me.lblDiferenca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiferenca.Size = New System.Drawing.Size(51, 19)
        Me.lblDiferenca.TabIndex = 23
        Me.lblDiferenca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(459, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 280
        Me.Label8.Text = "(mm)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(312, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 279
        Me.Label9.Text = "Diferença:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(460, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "(%)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(312, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 277
        Me.Label11.Text = "Expansão:"
        '
        'tbpPenetracao
        '
        Me.tbpPenetracao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpPenetracao.Controls.Add(Me.txtCalculada1)
        Me.tbpPenetracao.Controls.Add(Me.txtCalculada0)
        Me.tbpPenetracao.Controls.Add(Me.Panel1)
        Me.tbpPenetracao.Controls.Add(Me.txtISC2)
        Me.tbpPenetracao.Controls.Add(Me.Label23)
        Me.tbpPenetracao.Controls.Add(Me.Label22)
        Me.tbpPenetracao.Controls.Add(Me.Label3)
        Me.tbpPenetracao.Controls.Add(Me.txtISC1)
        Me.tbpPenetracao.Controls.Add(Me.txtISC0)
        Me.tbpPenetracao.Controls.Add(Me.txtPadrao1)
        Me.tbpPenetracao.Controls.Add(Me.txtPadrao0)
        Me.tbpPenetracao.Controls.Add(Me.Label15)
        Me.tbpPenetracao.Controls.Add(Me.txtCorrigida1)
        Me.tbpPenetracao.Controls.Add(Me.txtCorrigida0)
        Me.tbpPenetracao.Controls.Add(Me.txtPenetracao1)
        Me.tbpPenetracao.Controls.Add(Me.txtPenetracao0)
        Me.tbpPenetracao.Controls.Add(Me.lblLegendaPressao)
        Me.tbpPenetracao.Controls.Add(Me.Label14)
        Me.tbpPenetracao.Location = New System.Drawing.Point(4, 22)
        Me.tbpPenetracao.Name = "tbpPenetracao"
        Me.tbpPenetracao.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPenetracao.Size = New System.Drawing.Size(528, 245)
        Me.tbpPenetracao.TabIndex = 2
        Me.tbpPenetracao.Text = "ENSAIO DE PENETRAÇÃO"
        '
        'txtCalculada1
        '
        Me.txtCalculada1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCalculada1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalculada1.Location = New System.Drawing.Point(117, 119)
        Me.txtCalculada1.Name = "txtCalculada1"
        Me.txtCalculada1.Size = New System.Drawing.Size(97, 20)
        Me.txtCalculada1.TabIndex = 335
        Me.txtCalculada1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCalculada0
        '
        Me.txtCalculada0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCalculada0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalculada0.Location = New System.Drawing.Point(117, 100)
        Me.txtCalculada0.Name = "txtCalculada0"
        Me.txtCalculada0.Size = New System.Drawing.Size(97, 20)
        Me.txtCalculada0.TabIndex = 334
        Me.txtCalculada0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(23, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 10)
        Me.Panel1.TabIndex = 333
        '
        'txtISC2
        '
        Me.txtISC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtISC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISC2.Location = New System.Drawing.Point(405, 174)
        Me.txtISC2.Name = "txtISC2"
        Me.txtISC2.Size = New System.Drawing.Size(97, 20)
        Me.txtISC2.TabIndex = 332
        Me.txtISC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(309, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(97, 20)
        Me.Label23.TabIndex = 331
        Me.Label23.Text = "Padrão"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(213, 81)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(97, 20)
        Me.Label22.TabIndex = 330
        Me.Label22.Text = "Corrigida"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(117, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 329
        Me.Label3.Text = "Calculada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtISC1
        '
        Me.txtISC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtISC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISC1.Location = New System.Drawing.Point(405, 119)
        Me.txtISC1.Name = "txtISC1"
        Me.txtISC1.Size = New System.Drawing.Size(97, 20)
        Me.txtISC1.TabIndex = 328
        Me.txtISC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtISC0
        '
        Me.txtISC0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtISC0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISC0.Location = New System.Drawing.Point(405, 100)
        Me.txtISC0.Name = "txtISC0"
        Me.txtISC0.Size = New System.Drawing.Size(97, 20)
        Me.txtISC0.TabIndex = 327
        Me.txtISC0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPadrao1
        '
        Me.txtPadrao1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPadrao1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPadrao1.Location = New System.Drawing.Point(309, 119)
        Me.txtPadrao1.Name = "txtPadrao1"
        Me.txtPadrao1.Size = New System.Drawing.Size(97, 20)
        Me.txtPadrao1.TabIndex = 325
        Me.txtPadrao1.Text = "105,46"
        Me.txtPadrao1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPadrao0
        '
        Me.txtPadrao0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPadrao0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPadrao0.Location = New System.Drawing.Point(309, 100)
        Me.txtPadrao0.Name = "txtPadrao0"
        Me.txtPadrao0.Size = New System.Drawing.Size(97, 20)
        Me.txtPadrao0.TabIndex = 324
        Me.txtPadrao0.Text = "70,31"
        Me.txtPadrao0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(405, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(97, 38)
        Me.Label15.TabIndex = 322
        Me.Label15.Text = "ISC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(%)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCorrigida1
        '
        Me.txtCorrigida1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCorrigida1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorrigida1.Location = New System.Drawing.Point(213, 119)
        Me.txtCorrigida1.Name = "txtCorrigida1"
        Me.txtCorrigida1.Size = New System.Drawing.Size(97, 20)
        Me.txtCorrigida1.TabIndex = 320
        Me.txtCorrigida1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCorrigida0
        '
        Me.txtCorrigida0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCorrigida0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorrigida0.Location = New System.Drawing.Point(213, 100)
        Me.txtCorrigida0.Name = "txtCorrigida0"
        Me.txtCorrigida0.Size = New System.Drawing.Size(97, 20)
        Me.txtCorrigida0.TabIndex = 319
        Me.txtCorrigida0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPenetracao1
        '
        Me.txtPenetracao1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPenetracao1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenetracao1.Location = New System.Drawing.Point(23, 119)
        Me.txtPenetracao1.Name = "txtPenetracao1"
        Me.txtPenetracao1.Size = New System.Drawing.Size(97, 20)
        Me.txtPenetracao1.TabIndex = 314
        Me.txtPenetracao1.Text = "5,08"
        Me.txtPenetracao1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPenetracao0
        '
        Me.txtPenetracao0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPenetracao0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPenetracao0.Location = New System.Drawing.Point(23, 100)
        Me.txtPenetracao0.Name = "txtPenetracao0"
        Me.txtPenetracao0.Size = New System.Drawing.Size(97, 20)
        Me.txtPenetracao0.TabIndex = 313
        Me.txtPenetracao0.Text = "2,54"
        Me.txtPenetracao0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLegendaPressao
        '
        Me.lblLegendaPressao.BackColor = System.Drawing.Color.Transparent
        Me.lblLegendaPressao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLegendaPressao.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLegendaPressao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLegendaPressao.Location = New System.Drawing.Point(117, 63)
        Me.lblLegendaPressao.Name = "lblLegendaPressao"
        Me.lblLegendaPressao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLegendaPressao.Size = New System.Drawing.Size(289, 19)
        Me.lblLegendaPressao.TabIndex = 310
        Me.lblLegendaPressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(23, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(97, 38)
        Me.Label14.TabIndex = 309
        Me.Label14.Text = "Penetração" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(mm)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFrame1
        '
        Me.frmFrame1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.frmFrame1.Controls.Add(Me.Label26)
        Me.frmFrame1.Controls.Add(Me.lblTipoEnsaio)
        Me.frmFrame1.Controls.Add(Me.Label6)
        Me.frmFrame1.Controls.Add(Me.lblLabel4)
        Me.frmFrame1.Controls.Add(Me.lblLabel1)
        Me.frmFrame1.Controls.Add(Me.lblNome)
        Me.frmFrame1.Controls.Add(Me.lblEnergia)
        Me.frmFrame1.Controls.Add(Me.lblData)
        Me.frmFrame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmFrame1.Location = New System.Drawing.Point(15, 20)
        Me.frmFrame1.Name = "frmFrame1"
        Me.frmFrame1.Padding = New System.Windows.Forms.Padding(0)
        Me.frmFrame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmFrame1.Size = New System.Drawing.Size(536, 117)
        Me.frmFrame1.TabIndex = 0
        Me.frmFrame1.TabStop = False
        Me.frmFrame1.Text = "Dados da Amostra"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(321, 81)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(91, 13)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "Norma de Ensaio:"
        '
        'lblTipoEnsaio
        '
        Me.lblTipoEnsaio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTipoEnsaio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTipoEnsaio.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTipoEnsaio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTipoEnsaio.Location = New System.Drawing.Point(418, 79)
        Me.lblTipoEnsaio.Name = "lblTipoEnsaio"
        Me.lblTipoEnsaio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTipoEnsaio.Size = New System.Drawing.Size(104, 19)
        Me.lblTipoEnsaio.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(17, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Data do Ensaio:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel4.Location = New System.Drawing.Point(17, 53)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel4.Size = New System.Drawing.Size(130, 13)
        Me.lblLabel4.TabIndex = 7
        Me.lblLabel4.Text = "Energia de Compactação:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel1.Location = New System.Drawing.Point(17, 25)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel1.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel1.TabIndex = 5
        Me.lblLabel1.Text = "Nome da Amostra:"
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNome.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNome.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNome.Location = New System.Drawing.Point(154, 24)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNome.Size = New System.Drawing.Size(368, 19)
        Me.lblNome.TabIndex = 12
        '
        'lblEnergia
        '
        Me.lblEnergia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblEnergia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnergia.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEnergia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEnergia.Location = New System.Drawing.Point(154, 52)
        Me.lblEnergia.Name = "lblEnergia"
        Me.lblEnergia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnergia.Size = New System.Drawing.Size(233, 19)
        Me.lblEnergia.TabIndex = 13
        '
        'lblData
        '
        Me.lblData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblData.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblData.Location = New System.Drawing.Point(154, 79)
        Me.lblData.Name = "lblData"
        Me.lblData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblData.Size = New System.Drawing.Size(85, 19)
        Me.lblData.TabIndex = 16
        '
        'btnRever
        '
        Me.btnRever.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRever.Image = CType(resources.GetObject("btnRever.Image"), System.Drawing.Image)
        Me.btnRever.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRever.Location = New System.Drawing.Point(331, 3)
        Me.btnRever.Name = "btnRever"
        Me.btnRever.Padding = New System.Windows.Forms.Padding(6, 0, 8, 0)
        Me.btnRever.Size = New System.Drawing.Size(81, 26)
        Me.btnRever.TabIndex = 7
        Me.btnRever.Text = "Rever"
        Me.btnRever.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRever.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(417, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Padding = New System.Windows.Forms.Padding(6, 0, 10, 0)
        Me.btnExcel.Size = New System.Drawing.Size(81, 26)
        Me.btnExcel.TabIndex = 8
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnEnsaiar
        '
        Me.btnEnsaiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEnsaiar.Image = CType(resources.GetObject("btnEnsaiar.Image"), System.Drawing.Image)
        Me.btnEnsaiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnsaiar.Location = New System.Drawing.Point(245, 3)
        Me.btnEnsaiar.Name = "btnEnsaiar"
        Me.btnEnsaiar.Padding = New System.Windows.Forms.Padding(4, 0, 6, 0)
        Me.btnEnsaiar.Size = New System.Drawing.Size(81, 26)
        Me.btnEnsaiar.TabIndex = 6
        Me.btnEnsaiar.Tag = ""
        Me.btnEnsaiar.Text = "&Ensaiar"
        Me.btnEnsaiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnsaiar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(503, 513)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnCilindro)
        Me.pnlPanel.Controls.Add(Me.btnCalc)
        Me.pnlPanel.Controls.Add(Me.btnRever)
        Me.pnlPanel.Controls.Add(Me.btnExcel)
        Me.pnlPanel.Controls.Add(Me.btnEnsaiar)
        Me.pnlPanel.Location = New System.Drawing.Point(-1, 467)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(596, 34)
        Me.pnlPanel.TabIndex = 2
        '
        'btnCilindro
        '
        Me.btnCilindro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCilindro.Image = CType(resources.GetObject("btnCilindro.Image"), System.Drawing.Image)
        Me.btnCilindro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCilindro.Location = New System.Drawing.Point(108, 3)
        Me.btnCilindro.Name = "btnCilindro"
        Me.btnCilindro.Padding = New System.Windows.Forms.Padding(4, 0, 6, 0)
        Me.btnCilindro.Size = New System.Drawing.Size(131, 26)
        Me.btnCilindro.TabIndex = 10
        Me.btnCilindro.Tag = ""
        Me.btnCilindro.Text = "&Cadastrar Cilindro"
        Me.btnCilindro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCilindro.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalc.Image = CType(resources.GetObject("btnCalc.Image"), System.Drawing.Image)
        Me.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalc.Location = New System.Drawing.Point(503, 3)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Padding = New System.Windows.Forms.Padding(6, 0, 10, 0)
        Me.btnCalc.Size = New System.Drawing.Size(81, 26)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Calc"
        Me.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Delete"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Add new"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        '
        'btnResultado
        '
        Me.btnResultado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResultado.Image = CType(resources.GetObject("btnResultado.Image"), System.Drawing.Image)
        Me.btnResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResultado.Location = New System.Drawing.Point(417, 513)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnResultado.Size = New System.Drawing.Size(81, 26)
        Me.btnResultado.TabIndex = 10
        Me.btnResultado.Text = "&Resultado"
        Me.btnResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'btnBuscarCilindro
        '
        Me.btnBuscarCilindro.Image = CType(resources.GetObject("btnBuscarCilindro.Image"), System.Drawing.Image)
        Me.btnBuscarCilindro.Location = New System.Drawing.Point(297, 16)
        Me.btnBuscarCilindro.Name = "btnBuscarCilindro"
        Me.btnBuscarCilindro.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarCilindro.TabIndex = 310
        Me.btnBuscarCilindro.UseVisualStyleBackColor = True
        '
        'frmCadastrarCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(590, 562)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.frmFrame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarCP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corpos de prova para ensaio"
        Me.frmFrame2.ResumeLayout(False)
        Me.frmFrame2.PerformLayout()
        CType(Me.bdnNavegator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnNavegator.ResumeLayout(False)
        Me.bdnNavegator.PerformLayout()
        Me.tbcCP.ResumeLayout(False)
        Me.tbpCompactacao.ResumeLayout(False)
        Me.tbpCompactacao.PerformLayout()
        Me.tbpExpansao.ResumeLayout(False)
        Me.tbpExpansao.PerformLayout()
        Me.tbpPenetracao.ResumeLayout(False)
        Me.tbpPenetracao.PerformLayout()
        Me.frmFrame1.ResumeLayout(False)
        Me.frmFrame1.PerformLayout()
        Me.pnlPanel.ResumeLayout(False)
        CType(Me.bdnSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents btnRever As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnEnsaiar As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents bdnSource As System.Windows.Forms.BindingSource
    Friend WithEvents bdnNavegator As System.Windows.Forms.BindingNavigator
    Friend WithEvents tsbCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbMoverFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMoverPrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPosition As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbMoverNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMoverLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSave As System.Windows.Forms.ToolStripButton
    Public WithEvents frmFrame1 As System.Windows.Forms.GroupBox
    Public WithEvents lblLabel4 As System.Windows.Forms.Label
    Public WithEvents lblLabel1 As System.Windows.Forms.Label
    Public WithEvents lblEnergia As System.Windows.Forms.Label
    Public WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents btnResultado As System.Windows.Forms.Button
    Friend WithEvents tsbEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents tbcCP As System.Windows.Forms.TabControl
    Friend WithEvents tbpCompactacao As System.Windows.Forms.TabPage
    Friend WithEvents tbpExpansao As System.Windows.Forms.TabPage
    Friend WithEvents tbpPenetracao As System.Windows.Forms.TabPage
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtSoloCilindro As System.Windows.Forms.TextBox
    Public WithEvents lblLabel18 As System.Windows.Forms.Label
    Public WithEvents lblLabel2 As System.Windows.Forms.Label
    Public WithEvents lblLabel3 As System.Windows.Forms.Label
    Public WithEvents lblLabel5 As System.Windows.Forms.Label
    Public WithEvents txtPeso As System.Windows.Forms.TextBox
    Public WithEvents lblLabel28 As System.Windows.Forms.Label
    Public WithEvents lblLabel26 As System.Windows.Forms.Label
    Public WithEvents lblLabel25 As System.Windows.Forms.Label
    Public WithEvents lblLabel23 As System.Windows.Forms.Label
    Public WithEvents lblLabel24 As System.Windows.Forms.Label
    Public WithEvents lblLabel27 As System.Windows.Forms.Label
    Public WithEvents lblLabel22 As System.Windows.Forms.Label
    Public WithEvents lblLabel20 As System.Windows.Forms.Label
    Public WithEvents lblLabel21 As System.Windows.Forms.Label
    Public WithEvents lblLabel19 As System.Windows.Forms.Label
    Public WithEvents lblLabel16 As System.Windows.Forms.Label
    Public WithEvents lblLabel14 As System.Windows.Forms.Label
    Public WithEvents lblLabel7 As System.Windows.Forms.Label
    Public WithEvents lblLabel9 As System.Windows.Forms.Label
    Public WithEvents lblLabel8 As System.Windows.Forms.Label
    Public WithEvents lblLabel10 As System.Windows.Forms.Label
    Public WithEvents lblLabel15 As System.Windows.Forms.Label
    Public WithEvents lblLabel12 As System.Windows.Forms.Label
    Public WithEvents lblLabel11 As System.Windows.Forms.Label
    Public WithEvents lblLabel17 As System.Windows.Forms.Label
#End Region

    Private Sub txtMassaParafina_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents cmbCilindro As System.Windows.Forms.ComboBox
    Public WithEvents txtTara As System.Windows.Forms.TextBox
    Public WithEvents txtSecoTara As System.Windows.Forms.TextBox
    Public WithEvents txtUmidoTara As System.Windows.Forms.TextBox
    Public WithEvents txtCapsula As System.Windows.Forms.TextBox
    Public WithEvents txtVolume As System.Windows.Forms.TextBox
    Public WithEvents lblUmidade As System.Windows.Forms.Label
    Public WithEvents lblSoloSeco As System.Windows.Forms.Label
    Public WithEvents lblAgua As System.Windows.Forms.Label
    Public WithEvents lblMassaSeca As System.Windows.Forms.Label
    Public WithEvents lblMassaUmida As System.Windows.Forms.Label
    Public WithEvents lblSoloUmido As System.Windows.Forms.Label

    Public WithEvents lblAguaAbsorvida As System.Windows.Forms.Label
    Public WithEvents lblMoldeInicial As System.Windows.Forms.Label
    Public WithEvents txtMoldeFinal As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents lblExpansao As System.Windows.Forms.Label
    Public WithEvents lblDiferenca As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mskHora4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskHora3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskHora2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskHora1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskHora0 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskData0 As System.Windows.Forms.MaskedTextBox
    Public WithEvents lblLeitura As System.Windows.Forms.Label
    Public WithEvents lblHoraEnsaio As System.Windows.Forms.Label
    Public WithEvents lblDataEnsaio As System.Windows.Forms.Label
    Friend WithEvents txtLeitura4 As System.Windows.Forms.TextBox
    Friend WithEvents txtLeitura3 As System.Windows.Forms.TextBox
    Friend WithEvents txtLeitura2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLeitura1 As System.Windows.Forms.TextBox
    Friend WithEvents txtLeitura0 As System.Windows.Forms.TextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtISC1 As System.Windows.Forms.TextBox
    Friend WithEvents txtISC0 As System.Windows.Forms.TextBox
    Friend WithEvents txtPadrao1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPadrao0 As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCorrigida1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCorrigida0 As System.Windows.Forms.TextBox
    Friend WithEvents txtPenetracao1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPenetracao0 As System.Windows.Forms.MaskedTextBox
    Public WithEvents lblLegendaPressao As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtISC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtCalculada1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCalculada0 As System.Windows.Forms.TextBox
    Friend WithEvents btnCilindro As System.Windows.Forms.Button
    Public WithEvents txtEnsaioRealizado As System.Windows.Forms.TextBox
    Public WithEvents txtAltura As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents lblAlturaCP As Label
    Public WithEvents Label25 As Label
    Public WithEvents Label24 As Label
    Public WithEvents Label26 As Label
    Public WithEvents lblTipoEnsaio As Label
    Friend WithEvents btnBuscarCilindro As Button
End Class