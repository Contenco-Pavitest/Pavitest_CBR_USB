<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFabricante_Configuracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFabricante_Configuracoes))
        Me.chk_Canal3 = New System.Windows.Forms.CheckBox()
        Me.chk_Canal4 = New System.Windows.Forms.CheckBox()
        Me.chk_Canal2 = New System.Windows.Forms.CheckBox()
        Me.chk_Canal0 = New System.Windows.Forms.CheckBox()
        Me.chk_Canal1 = New System.Windows.Forms.CheckBox()
        Me.grpAjustesFabricante = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboNumeroPlaca = New System.Windows.Forms.ComboBox()
        Me.chk_Canal7 = New System.Windows.Forms.CheckBox()
        Me.pctCH7cz = New System.Windows.Forms.PictureBox()
        Me.chk_Canal6 = New System.Windows.Forms.CheckBox()
        Me.pctCH6cz = New System.Windows.Forms.PictureBox()
        Me.chk_Canal5 = New System.Windows.Forms.CheckBox()
        Me.pctCH5cz = New System.Windows.Forms.PictureBox()
        Me.pctCH4cz = New System.Windows.Forms.PictureBox()
        Me.pctCH3cz = New System.Windows.Forms.PictureBox()
        Me.pctCH2cz = New System.Windows.Forms.PictureBox()
        Me.pctCH1cz = New System.Windows.Forms.PictureBox()
        Me.pctCH0cz = New System.Windows.Forms.PictureBox()
        Me.pctCH6vd = New System.Windows.Forms.PictureBox()
        Me.pctCH0vd = New System.Windows.Forms.PictureBox()
        Me.pctCH7vd = New System.Windows.Forms.PictureBox()
        Me.pctCH5vd = New System.Windows.Forms.PictureBox()
        Me.pctCH2vd = New System.Windows.Forms.PictureBox()
        Me.pctCH3vd = New System.Windows.Forms.PictureBox()
        Me.pctCH4vd = New System.Windows.Forms.PictureBox()
        Me.pctCH1vd = New System.Windows.Forms.PictureBox()
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkHabilitaDeslocamento = New System.Windows.Forms.CheckBox()
        Me.chkHabilitaCarga = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboCanalDeformacao = New System.Windows.Forms.ComboBox()
        Me.cboPlacaDeformacao = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboCanalCelulaCarga = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboPlacaCelulaCarga = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.tmrComunicacao = New System.Windows.Forms.Timer(Me.components)
        Me.barStatus = New System.Windows.Forms.ProgressBar()
        Me.spPortaSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrLimparErros = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkHabilitacaoLeiturasPID = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpAjustesFabricante.SuspendLayout()
        CType(Me.pctCH7cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH6cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH5cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH4cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH3cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH2cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH1cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH0cz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH6vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH0vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH7vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH5vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH2vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH3vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH4vd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCH1vd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_Canal3
        '
        Me.chk_Canal3.AutoSize = True
        Me.chk_Canal3.Enabled = False
        Me.chk_Canal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal3.Location = New System.Drawing.Point(29, 363)
        Me.chk_Canal3.Name = "chk_Canal3"
        Me.chk_Canal3.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal3.TabIndex = 7
        Me.chk_Canal3.Tag = "3"
        Me.chk_Canal3.Text = "CH 3"
        Me.chk_Canal3.UseVisualStyleBackColor = True
        '
        'chk_Canal4
        '
        Me.chk_Canal4.AutoSize = True
        Me.chk_Canal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal4.Location = New System.Drawing.Point(123, 120)
        Me.chk_Canal4.Name = "chk_Canal4"
        Me.chk_Canal4.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal4.TabIndex = 2
        Me.chk_Canal4.Tag = "4"
        Me.chk_Canal4.Text = "CH 4"
        Me.chk_Canal4.UseVisualStyleBackColor = True
        '
        'chk_Canal2
        '
        Me.chk_Canal2.AutoSize = True
        Me.chk_Canal2.Enabled = False
        Me.chk_Canal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal2.Location = New System.Drawing.Point(29, 279)
        Me.chk_Canal2.Name = "chk_Canal2"
        Me.chk_Canal2.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal2.TabIndex = 5
        Me.chk_Canal2.Tag = "2"
        Me.chk_Canal2.Text = "CH 2"
        Me.chk_Canal2.UseVisualStyleBackColor = True
        '
        'chk_Canal0
        '
        Me.chk_Canal0.AutoSize = True
        Me.chk_Canal0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal0.Location = New System.Drawing.Point(32, 120)
        Me.chk_Canal0.Name = "chk_Canal0"
        Me.chk_Canal0.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal0.TabIndex = 1
        Me.chk_Canal0.Tag = "0"
        Me.chk_Canal0.Text = "CH 0"
        Me.chk_Canal0.UseVisualStyleBackColor = True
        '
        'chk_Canal1
        '
        Me.chk_Canal1.AutoSize = True
        Me.chk_Canal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal1.Location = New System.Drawing.Point(28, 199)
        Me.chk_Canal1.Name = "chk_Canal1"
        Me.chk_Canal1.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal1.TabIndex = 3
        Me.chk_Canal1.Tag = "1"
        Me.chk_Canal1.Text = "CH 1"
        Me.chk_Canal1.UseVisualStyleBackColor = True
        '
        'grpAjustesFabricante
        '
        Me.grpAjustesFabricante.Controls.Add(Me.Label12)
        Me.grpAjustesFabricante.Controls.Add(Me.Label11)
        Me.grpAjustesFabricante.Controls.Add(Me.Label10)
        Me.grpAjustesFabricante.Controls.Add(Me.Label9)
        Me.grpAjustesFabricante.Controls.Add(Me.Label8)
        Me.grpAjustesFabricante.Controls.Add(Me.Label7)
        Me.grpAjustesFabricante.Controls.Add(Me.Label5)
        Me.grpAjustesFabricante.Controls.Add(Me.Label13)
        Me.grpAjustesFabricante.Controls.Add(Me.Label4)
        Me.grpAjustesFabricante.Controls.Add(Me.cboNumeroPlaca)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal7)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH7cz)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal6)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH6cz)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal5)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH5cz)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH4cz)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal4)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal3)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal1)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal2)
        Me.grpAjustesFabricante.Controls.Add(Me.chk_Canal0)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH3cz)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH2cz)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH1cz)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH0cz)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH6vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH0vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH7vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH5vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH2vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH3vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH4vd)
        Me.grpAjustesFabricante.Controls.Add(Me.pctCH1vd)
        Me.grpAjustesFabricante.Enabled = False
        Me.grpAjustesFabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAjustesFabricante.Location = New System.Drawing.Point(11, 6)
        Me.grpAjustesFabricante.Name = "grpAjustesFabricante"
        Me.grpAjustesFabricante.Size = New System.Drawing.Size(201, 407)
        Me.grpAjustesFabricante.TabIndex = 121
        Me.grpAjustesFabricante.TabStop = False
        Me.grpAjustesFabricante.Text = "Habilitação de Canais AD-7192"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(115, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "AIN4 p/ COM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "AIN3 p/ COM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(113, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "AIN2 p/ COM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(112, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "AIN1 p/ COM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "AIN2 p/ AIN2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Temp (ºC)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "AIN3 p/ AIN4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Número da Placa AD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "AIN1 p/ AIN2"
        '
        'cboNumeroPlaca
        '
        Me.cboNumeroPlaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumeroPlaca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNumeroPlaca.FormattingEnabled = True
        Me.cboNumeroPlaca.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboNumeroPlaca.Location = New System.Drawing.Point(57, 42)
        Me.cboNumeroPlaca.Name = "cboNumeroPlaca"
        Me.cboNumeroPlaca.Size = New System.Drawing.Size(86, 25)
        Me.cboNumeroPlaca.TabIndex = 0
        '
        'chk_Canal7
        '
        Me.chk_Canal7.AutoSize = True
        Me.chk_Canal7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal7.Location = New System.Drawing.Point(123, 363)
        Me.chk_Canal7.Name = "chk_Canal7"
        Me.chk_Canal7.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal7.TabIndex = 8
        Me.chk_Canal7.Tag = "7"
        Me.chk_Canal7.Text = "CH 7"
        Me.chk_Canal7.UseVisualStyleBackColor = True
        '
        'pctCH7cz
        '
        Me.pctCH7cz.Image = CType(resources.GetObject("pctCH7cz.Image"), System.Drawing.Image)
        Me.pctCH7cz.Location = New System.Drawing.Point(131, 325)
        Me.pctCH7cz.Name = "pctCH7cz"
        Me.pctCH7cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH7cz.TabIndex = 27
        Me.pctCH7cz.TabStop = False
        '
        'chk_Canal6
        '
        Me.chk_Canal6.AutoSize = True
        Me.chk_Canal6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal6.Location = New System.Drawing.Point(123, 279)
        Me.chk_Canal6.Name = "chk_Canal6"
        Me.chk_Canal6.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal6.TabIndex = 6
        Me.chk_Canal6.Tag = "6"
        Me.chk_Canal6.Text = "CH 6"
        Me.chk_Canal6.UseVisualStyleBackColor = True
        '
        'pctCH6cz
        '
        Me.pctCH6cz.Image = CType(resources.GetObject("pctCH6cz.Image"), System.Drawing.Image)
        Me.pctCH6cz.Location = New System.Drawing.Point(131, 241)
        Me.pctCH6cz.Name = "pctCH6cz"
        Me.pctCH6cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH6cz.TabIndex = 28
        Me.pctCH6cz.TabStop = False
        '
        'chk_Canal5
        '
        Me.chk_Canal5.AutoSize = True
        Me.chk_Canal5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Canal5.Location = New System.Drawing.Point(124, 199)
        Me.chk_Canal5.Name = "chk_Canal5"
        Me.chk_Canal5.Size = New System.Drawing.Size(50, 17)
        Me.chk_Canal5.TabIndex = 4
        Me.chk_Canal5.Tag = "5"
        Me.chk_Canal5.Text = "CH 5"
        Me.chk_Canal5.UseVisualStyleBackColor = True
        '
        'pctCH5cz
        '
        Me.pctCH5cz.Image = CType(resources.GetObject("pctCH5cz.Image"), System.Drawing.Image)
        Me.pctCH5cz.Location = New System.Drawing.Point(131, 161)
        Me.pctCH5cz.Name = "pctCH5cz"
        Me.pctCH5cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH5cz.TabIndex = 26
        Me.pctCH5cz.TabStop = False
        '
        'pctCH4cz
        '
        Me.pctCH4cz.Image = CType(resources.GetObject("pctCH4cz.Image"), System.Drawing.Image)
        Me.pctCH4cz.Location = New System.Drawing.Point(131, 82)
        Me.pctCH4cz.Name = "pctCH4cz"
        Me.pctCH4cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH4cz.TabIndex = 23
        Me.pctCH4cz.TabStop = False
        '
        'pctCH3cz
        '
        Me.pctCH3cz.Enabled = False
        Me.pctCH3cz.Image = CType(resources.GetObject("pctCH3cz.Image"), System.Drawing.Image)
        Me.pctCH3cz.Location = New System.Drawing.Point(37, 325)
        Me.pctCH3cz.Name = "pctCH3cz"
        Me.pctCH3cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH3cz.TabIndex = 24
        Me.pctCH3cz.TabStop = False
        '
        'pctCH2cz
        '
        Me.pctCH2cz.Enabled = False
        Me.pctCH2cz.Image = CType(resources.GetObject("pctCH2cz.Image"), System.Drawing.Image)
        Me.pctCH2cz.Location = New System.Drawing.Point(37, 241)
        Me.pctCH2cz.Name = "pctCH2cz"
        Me.pctCH2cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH2cz.TabIndex = 25
        Me.pctCH2cz.TabStop = False
        '
        'pctCH1cz
        '
        Me.pctCH1cz.Image = CType(resources.GetObject("pctCH1cz.Image"), System.Drawing.Image)
        Me.pctCH1cz.Location = New System.Drawing.Point(37, 161)
        Me.pctCH1cz.Name = "pctCH1cz"
        Me.pctCH1cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH1cz.TabIndex = 22
        Me.pctCH1cz.TabStop = False
        '
        'pctCH0cz
        '
        Me.pctCH0cz.Image = CType(resources.GetObject("pctCH0cz.Image"), System.Drawing.Image)
        Me.pctCH0cz.Location = New System.Drawing.Point(37, 82)
        Me.pctCH0cz.Name = "pctCH0cz"
        Me.pctCH0cz.Size = New System.Drawing.Size(34, 32)
        Me.pctCH0cz.TabIndex = 29
        Me.pctCH0cz.TabStop = False
        '
        'pctCH6vd
        '
        Me.pctCH6vd.Image = CType(resources.GetObject("pctCH6vd.Image"), System.Drawing.Image)
        Me.pctCH6vd.Location = New System.Drawing.Point(131, 241)
        Me.pctCH6vd.Name = "pctCH6vd"
        Me.pctCH6vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH6vd.TabIndex = 21
        Me.pctCH6vd.TabStop = False
        '
        'pctCH0vd
        '
        Me.pctCH0vd.Image = CType(resources.GetObject("pctCH0vd.Image"), System.Drawing.Image)
        Me.pctCH0vd.Location = New System.Drawing.Point(37, 82)
        Me.pctCH0vd.Name = "pctCH0vd"
        Me.pctCH0vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH0vd.TabIndex = 20
        Me.pctCH0vd.TabStop = False
        '
        'pctCH7vd
        '
        Me.pctCH7vd.Image = CType(resources.GetObject("pctCH7vd.Image"), System.Drawing.Image)
        Me.pctCH7vd.Location = New System.Drawing.Point(131, 325)
        Me.pctCH7vd.Name = "pctCH7vd"
        Me.pctCH7vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH7vd.TabIndex = 19
        Me.pctCH7vd.TabStop = False
        '
        'pctCH5vd
        '
        Me.pctCH5vd.Image = CType(resources.GetObject("pctCH5vd.Image"), System.Drawing.Image)
        Me.pctCH5vd.Location = New System.Drawing.Point(131, 161)
        Me.pctCH5vd.Name = "pctCH5vd"
        Me.pctCH5vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH5vd.TabIndex = 18
        Me.pctCH5vd.TabStop = False
        '
        'pctCH2vd
        '
        Me.pctCH2vd.Enabled = False
        Me.pctCH2vd.Image = CType(resources.GetObject("pctCH2vd.Image"), System.Drawing.Image)
        Me.pctCH2vd.Location = New System.Drawing.Point(37, 241)
        Me.pctCH2vd.Name = "pctCH2vd"
        Me.pctCH2vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH2vd.TabIndex = 17
        Me.pctCH2vd.TabStop = False
        '
        'pctCH3vd
        '
        Me.pctCH3vd.Enabled = False
        Me.pctCH3vd.Image = CType(resources.GetObject("pctCH3vd.Image"), System.Drawing.Image)
        Me.pctCH3vd.Location = New System.Drawing.Point(37, 325)
        Me.pctCH3vd.Name = "pctCH3vd"
        Me.pctCH3vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH3vd.TabIndex = 16
        Me.pctCH3vd.TabStop = False
        '
        'pctCH4vd
        '
        Me.pctCH4vd.Image = CType(resources.GetObject("pctCH4vd.Image"), System.Drawing.Image)
        Me.pctCH4vd.Location = New System.Drawing.Point(131, 82)
        Me.pctCH4vd.Name = "pctCH4vd"
        Me.pctCH4vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH4vd.TabIndex = 15
        Me.pctCH4vd.TabStop = False
        '
        'pctCH1vd
        '
        Me.pctCH1vd.Image = CType(resources.GetObject("pctCH1vd.Image"), System.Drawing.Image)
        Me.pctCH1vd.Location = New System.Drawing.Point(36, 161)
        Me.pctCH1vd.Name = "pctCH1vd"
        Me.pctCH1vd.Size = New System.Drawing.Size(34, 32)
        Me.pctCH1vd.TabIndex = 14
        Me.pctCH1vd.TabStop = False
        '
        'lblMsgErro
        '
        Me.lblMsgErro.BackColor = System.Drawing.Color.Red
        Me.lblMsgErro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMsgErro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgErro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMsgErro.Location = New System.Drawing.Point(11, 475)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMsgErro.Size = New System.Drawing.Size(201, 22)
        Me.lblMsgErro.TabIndex = 127
        Me.lblMsgErro.Text = "Erro"
        Me.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsgErro.Visible = False
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(399, 473)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 23
        Me.btnOk.Text = "  &Aplicar"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkHabilitaDeslocamento)
        Me.GroupBox1.Controls.Add(Me.chkHabilitaCarga)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cboCanalDeformacao)
        Me.GroupBox1.Controls.Add(Me.cboPlacaDeformacao)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboCanalCelulaCarga)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cboPlacaCelulaCarga)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(218, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 137)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuração do Equipamento"
        '
        'chkHabilitaDeslocamento
        '
        Me.chkHabilitaDeslocamento.AutoSize = True
        Me.chkHabilitaDeslocamento.Location = New System.Drawing.Point(23, 89)
        Me.chkHabilitaDeslocamento.Name = "chkHabilitaDeslocamento"
        Me.chkHabilitaDeslocamento.Size = New System.Drawing.Size(15, 14)
        Me.chkHabilitaDeslocamento.TabIndex = 147
        Me.chkHabilitaDeslocamento.UseVisualStyleBackColor = True
        '
        'chkHabilitaCarga
        '
        Me.chkHabilitaCarga.AutoSize = True
        Me.chkHabilitaCarga.Location = New System.Drawing.Point(23, 58)
        Me.chkHabilitaCarga.Name = "chkHabilitaCarga"
        Me.chkHabilitaCarga.Size = New System.Drawing.Size(15, 14)
        Me.chkHabilitaCarga.TabIndex = 147
        Me.chkHabilitaCarga.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(168, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 13)
        Me.Label18.TabIndex = 146
        Me.Label18.Text = "Deslocamento"
        '
        'cboCanalDeformacao
        '
        Me.cboCanalDeformacao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanalDeformacao.FormattingEnabled = True
        Me.cboCanalDeformacao.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cboCanalDeformacao.Location = New System.Drawing.Point(117, 84)
        Me.cboCanalDeformacao.Name = "cboCanalDeformacao"
        Me.cboCanalDeformacao.Size = New System.Drawing.Size(45, 25)
        Me.cboCanalDeformacao.TabIndex = 145
        '
        'cboPlacaDeformacao
        '
        Me.cboPlacaDeformacao.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlacaDeformacao.FormattingEnabled = True
        Me.cboPlacaDeformacao.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboPlacaDeformacao.Location = New System.Drawing.Point(59, 84)
        Me.cboPlacaDeformacao.Name = "cboPlacaDeformacao"
        Me.cboPlacaDeformacao.Size = New System.Drawing.Size(45, 25)
        Me.cboPlacaDeformacao.TabIndex = 144
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(168, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Célula de Carga"
        '
        'cboCanalCelulaCarga
        '
        Me.cboCanalCelulaCarga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCanalCelulaCarga.FormattingEnabled = True
        Me.cboCanalCelulaCarga.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7"})
        Me.cboCanalCelulaCarga.Location = New System.Drawing.Point(117, 53)
        Me.cboCanalCelulaCarga.Name = "cboCanalCelulaCarga"
        Me.cboCanalCelulaCarga.Size = New System.Drawing.Size(45, 25)
        Me.cboCanalCelulaCarga.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(116, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Canal"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPlacaCelulaCarga
        '
        Me.cboPlacaCelulaCarga.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlacaCelulaCarga.FormattingEnabled = True
        Me.cboPlacaCelulaCarga.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cboPlacaCelulaCarga.Location = New System.Drawing.Point(59, 53)
        Me.cboPlacaCelulaCarga.Name = "cboPlacaCelulaCarga"
        Me.cboPlacaCelulaCarga.Size = New System.Drawing.Size(45, 25)
        Me.cboPlacaCelulaCarga.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hab."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(62, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Placa"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(312, 473)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 22
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(59, 419)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(82, 25)
        Me.btnConectar.TabIndex = 136
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'tmrComunicacao
        '
        Me.tmrComunicacao.Interval = 250
        '
        'barStatus
        '
        Me.barStatus.Location = New System.Drawing.Point(11, 473)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(295, 26)
        Me.barStatus.Step = 1
        Me.barStatus.TabIndex = 137
        Me.barStatus.Visible = False
        '
        'spPortaSerial
        '
        Me.spPortaSerial.BaudRate = 115200
        Me.spPortaSerial.DtrEnable = True
        Me.spPortaSerial.ReadTimeout = 200
        Me.spPortaSerial.WriteTimeout = 200
        '
        'tmrLimparErros
        '
        Me.tmrLimparErros.Interval = 3000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkHabilitacaoLeiturasPID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(218, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 137)
        Me.GroupBox2.TabIndex = 134
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Habilitação Leituras do PID"
        '
        'chkHabilitacaoLeiturasPID
        '
        Me.chkHabilitacaoLeiturasPID.AutoSize = True
        Me.chkHabilitacaoLeiturasPID.Location = New System.Drawing.Point(23, 58)
        Me.chkHabilitacaoLeiturasPID.Name = "chkHabilitacaoLeiturasPID"
        Me.chkHabilitacaoLeiturasPID.Size = New System.Drawing.Size(15, 14)
        Me.chkHabilitacaoLeiturasPID.TabIndex = 147
        Me.chkHabilitacaoLeiturasPID.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 40)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Habilitação das leituras de acompanhamento do controle PID na tela de ensaio"
        '
        'frmFabricante_Configuracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(486, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.barStatus)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblMsgErro)
        Me.Controls.Add(Me.grpAjustesFabricante)
        Me.Name = "frmFabricante_Configuracoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela de Ajustes do Fabricante"
        Me.grpAjustesFabricante.ResumeLayout(False)
        Me.grpAjustesFabricante.PerformLayout()
        CType(Me.pctCH7cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH6cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH5cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH4cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH3cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH2cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH1cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH0cz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH6vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH0vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH7vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH5vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH2vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH3vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH4vd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCH1vd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_Canal3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Canal4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Canal2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Canal0 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Canal1 As System.Windows.Forms.CheckBox
    Friend WithEvents grpAjustesFabricante As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Canal6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Canal5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Canal7 As System.Windows.Forms.CheckBox
    Friend WithEvents pctCH4vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH1vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH0cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH6cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH7cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH5cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH2cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH3cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH4cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH1cz As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH6vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH0vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH7vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH5vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH2vd As System.Windows.Forms.PictureBox
    Friend WithEvents pctCH3vd As System.Windows.Forms.PictureBox
    Public WithEvents lblMsgErro As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboNumeroPlaca As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cboCanalCelulaCarga As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlacaCelulaCarga As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConectar As Button
    Friend WithEvents tmrComunicacao As System.Windows.Forms.Timer
    Friend WithEvents Label18 As Label
    Friend WithEvents cboCanalDeformacao As ComboBox
    Friend WithEvents cboPlacaDeformacao As ComboBox
    Friend WithEvents chkHabilitaDeslocamento As CheckBox
    Friend WithEvents chkHabilitaCarga As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents barStatus As ProgressBar
    Friend WithEvents spPortaSerial As IO.Ports.SerialPort
    Friend WithEvents tmrLimparErros As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkHabilitacaoLeiturasPID As CheckBox
    Friend WithEvents Label3 As Label
End Class
