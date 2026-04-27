<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarAmostra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarAmostra))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCP = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.gpbGroup1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTipoEnsaio = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.txtIdAmostra = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtValorExtra2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTituloExtra2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtValorExtra1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTituloExtra1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOperador = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipoMaterial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButtonDnit = New System.Windows.Forms.RadioButton()
        Me.cmbCompactacao = New System.Windows.Forms.ComboBox()
        Me.RadioButtonAbnt = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlPanel.SuspendLayout()
        Me.gpbGroup1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(562, 543)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 12
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnEditar)
        Me.pnlPanel.Controls.Add(Me.btnCP)
        Me.pnlPanel.Controls.Add(Me.btnSalvar)
        Me.pnlPanel.Location = New System.Drawing.Point(-1, 503)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(660, 34)
        Me.pnlPanel.TabIndex = 88
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(475, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.btnEditar.Size = New System.Drawing.Size(81, 26)
        Me.btnEditar.TabIndex = 10
        Me.btnEditar.Text = "Editar   "
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCP
        '
        Me.btnCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCP.Image = CType(resources.GetObject("btnCP.Image"), System.Drawing.Image)
        Me.btnCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCP.Location = New System.Drawing.Point(388, 3)
        Me.btnCP.Name = "btnCP"
        Me.btnCP.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.btnCP.Size = New System.Drawing.Size(81, 26)
        Me.btnCP.TabIndex = 9
        Me.btnCP.Text = "C.P. >>"
        Me.btnCP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCP.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(562, 3)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Padding = New System.Windows.Forms.Padding(6, 0, 7, 0)
        Me.btnSalvar.Size = New System.Drawing.Size(81, 26)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'gpbGroup1
        '
        Me.gpbGroup1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gpbGroup1.Controls.Add(Me.GroupBox2)
        Me.gpbGroup1.Controls.Add(Me.GroupBox1)
        Me.gpbGroup1.Controls.Add(Me.txtOperador)
        Me.gpbGroup1.Controls.Add(Me.Label9)
        Me.gpbGroup1.Controls.Add(Me.txtTipoMaterial)
        Me.gpbGroup1.Controls.Add(Me.Label8)
        Me.gpbGroup1.Controls.Add(Me.RadioButtonDnit)
        Me.gpbGroup1.Controls.Add(Me.cmbCompactacao)
        Me.gpbGroup1.Controls.Add(Me.RadioButtonAbnt)
        Me.gpbGroup1.Controls.Add(Me.Label6)
        Me.gpbGroup1.Controls.Add(Me.Label3)
        Me.gpbGroup1.Controls.Add(Me.txtResponsavel)
        Me.gpbGroup1.Controls.Add(Me.Label5)
        Me.gpbGroup1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gpbGroup1.Location = New System.Drawing.Point(14, 12)
        Me.gpbGroup1.Name = "gpbGroup1"
        Me.gpbGroup1.Padding = New System.Windows.Forms.Padding(0)
        Me.gpbGroup1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gpbGroup1.Size = New System.Drawing.Size(629, 478)
        Me.gpbGroup1.TabIndex = 89
        Me.gpbGroup1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mskData)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLocal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtObra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtNome)
        Me.GroupBox2.Controls.Add(Me.txtTipoEnsaio)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblLabel1)
        Me.GroupBox2.Controls.Add(Me.txtIdAmostra)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 158)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(513, 18)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(88, 20)
        Me.mskData.TabIndex = 5
        Me.mskData.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(414, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Data de Moldagem:"
        '
        'txtLocal
        '
        Me.txtLocal.BackColor = System.Drawing.SystemColors.Window
        Me.txtLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocal.Location = New System.Drawing.Point(101, 118)
        Me.txtLocal.MaxLength = 90
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLocal.Size = New System.Drawing.Size(500, 20)
        Me.txtLocal.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "Local:"
        '
        'txtObra
        '
        Me.txtObra.BackColor = System.Drawing.SystemColors.Window
        Me.txtObra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObra.Location = New System.Drawing.Point(101, 87)
        Me.txtObra.MaxLength = 90
        Me.txtObra.Name = "txtObra"
        Me.txtObra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObra.Size = New System.Drawing.Size(500, 20)
        Me.txtObra.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Obra:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome.Location = New System.Drawing.Point(101, 18)
        Me.txtNome.MaxLength = 90
        Me.txtNome.Name = "txtNome"
        Me.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNome.Size = New System.Drawing.Size(307, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtTipoEnsaio
        '
        Me.txtTipoEnsaio.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoEnsaio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoEnsaio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoEnsaio.Location = New System.Drawing.Point(107, 18)
        Me.txtTipoEnsaio.MaxLength = 90
        Me.txtTipoEnsaio.Name = "txtTipoEnsaio"
        Me.txtTipoEnsaio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoEnsaio.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoEnsaio.TabIndex = 125
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCliente.Location = New System.Drawing.Point(101, 53)
        Me.txtCliente.MaxLength = 90
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCliente.Size = New System.Drawing.Size(500, 20)
        Me.txtCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Cliente:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.BackColor = System.Drawing.Color.Transparent
        Me.lblLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel1.ForeColor = System.Drawing.Color.Black
        Me.lblLabel1.Location = New System.Drawing.Point(7, 22)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel1.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel1.TabIndex = 121
        Me.lblLabel1.Text = "Nome da Amostra:"
        '
        'txtIdAmostra
        '
        Me.txtIdAmostra.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdAmostra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdAmostra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdAmostra.Location = New System.Drawing.Point(202, 53)
        Me.txtIdAmostra.MaxLength = 90
        Me.txtIdAmostra.Name = "txtIdAmostra"
        Me.txtIdAmostra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIdAmostra.Size = New System.Drawing.Size(45, 20)
        Me.txtIdAmostra.TabIndex = 124
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtValorExtra2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtTituloExtra2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtValorExtra1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTituloExtra1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 160)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Campos Extras:"
        '
        'txtValorExtra2
        '
        Me.txtValorExtra2.BackColor = System.Drawing.SystemColors.Window
        Me.txtValorExtra2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValorExtra2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtValorExtra2.Location = New System.Drawing.Point(368, 115)
        Me.txtValorExtra2.MaxLength = 90
        Me.txtValorExtra2.Name = "txtValorExtra2"
        Me.txtValorExtra2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValorExtra2.Size = New System.Drawing.Size(222, 20)
        Me.txtValorExtra2.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(280, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Valor do Campo:"
        '
        'txtTituloExtra2
        '
        Me.txtTituloExtra2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTituloExtra2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTituloExtra2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTituloExtra2.Location = New System.Drawing.Point(98, 115)
        Me.txtTituloExtra2.MaxLength = 90
        Me.txtTituloExtra2.Name = "txtTituloExtra2"
        Me.txtTituloExtra2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTituloExtra2.Size = New System.Drawing.Size(176, 20)
        Me.txtTituloExtra2.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "Nome do Campo:"
        '
        'txtValorExtra1
        '
        Me.txtValorExtra1.BackColor = System.Drawing.SystemColors.Window
        Me.txtValorExtra1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValorExtra1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtValorExtra1.Location = New System.Drawing.Point(367, 49)
        Me.txtValorExtra1.MaxLength = 90
        Me.txtValorExtra1.Name = "txtValorExtra1"
        Me.txtValorExtra1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtValorExtra1.Size = New System.Drawing.Size(222, 20)
        Me.txtValorExtra1.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(279, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Valor do Campo:"
        '
        'txtTituloExtra1
        '
        Me.txtTituloExtra1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTituloExtra1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTituloExtra1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTituloExtra1.Location = New System.Drawing.Point(97, 49)
        Me.txtTituloExtra1.MaxLength = 90
        Me.txtTituloExtra1.Name = "txtTituloExtra1"
        Me.txtTituloExtra1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTituloExtra1.Size = New System.Drawing.Size(176, 20)
        Me.txtTituloExtra1.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Nome do Campo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Campo 2:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Campo 1:"
        '
        'txtOperador
        '
        Me.txtOperador.BackColor = System.Drawing.SystemColors.Window
        Me.txtOperador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOperador.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOperador.Location = New System.Drawing.Point(419, 222)
        Me.txtOperador.MaxLength = 90
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOperador.Size = New System.Drawing.Size(194, 20)
        Me.txtOperador.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(299, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Operador:"
        '
        'txtTipoMaterial
        '
        Me.txtTipoMaterial.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoMaterial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoMaterial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoMaterial.Location = New System.Drawing.Point(115, 180)
        Me.txtTipoMaterial.MaxLength = 90
        Me.txtTipoMaterial.Name = "txtTipoMaterial"
        Me.txtTipoMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoMaterial.Size = New System.Drawing.Size(164, 20)
        Me.txtTipoMaterial.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Tipo de Material:"
        '
        'RadioButtonDnit
        '
        Me.RadioButtonDnit.AutoSize = True
        Me.RadioButtonDnit.Checked = True
        Me.RadioButtonDnit.Enabled = False
        Me.RadioButtonDnit.Location = New System.Drawing.Point(121, 265)
        Me.RadioButtonDnit.Name = "RadioButtonDnit"
        Me.RadioButtonDnit.Size = New System.Drawing.Size(97, 17)
        Me.RadioButtonDnit.TabIndex = 10
        Me.RadioButtonDnit.TabStop = True
        Me.RadioButtonDnit.Text = "DNIT 172 - ME"
        Me.RadioButtonDnit.UseVisualStyleBackColor = True
        '
        'cmbCompactacao
        '
        Me.cmbCompactacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompactacao.FormattingEnabled = True
        Me.cmbCompactacao.Items.AddRange(New Object() {"Proctor Normal", "Proctor Intermediário", "Proctor Modificado", "Outros"})
        Me.cmbCompactacao.Location = New System.Drawing.Point(419, 180)
        Me.cmbCompactacao.Name = "cmbCompactacao"
        Me.cmbCompactacao.Size = New System.Drawing.Size(194, 21)
        Me.cmbCompactacao.TabIndex = 7
        '
        'RadioButtonAbnt
        '
        Me.RadioButtonAbnt.AutoSize = True
        Me.RadioButtonAbnt.Enabled = False
        Me.RadioButtonAbnt.Location = New System.Drawing.Point(234, 265)
        Me.RadioButtonAbnt.Name = "RadioButtonAbnt"
        Me.RadioButtonAbnt.Size = New System.Drawing.Size(107, 17)
        Me.RadioButtonAbnt.TabIndex = 90
        Me.RadioButtonAbnt.Text = "ABNT NBR 9895"
        Me.RadioButtonAbnt.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Norma de Ensaio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(291, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Energia de Compactação:"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.BackColor = System.Drawing.SystemColors.Window
        Me.txtResponsavel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResponsavel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResponsavel.Location = New System.Drawing.Point(121, 222)
        Me.txtResponsavel.MaxLength = 90
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsavel.Size = New System.Drawing.Size(171, 20)
        Me.txtResponsavel.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Responsável:"
        '
        'frmCadastrarAmostra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(655, 578)
        Me.Controls.Add(Me.gpbGroup1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnlPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarAmostra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados da amostra"
        Me.pnlPanel.ResumeLayout(False)
        Me.gpbGroup1.ResumeLayout(False)
        Me.gpbGroup1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCP As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Public WithEvents gpbGroup1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mskData As MaskedTextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtLocal As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents txtObra As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents txtNome As TextBox
    Public WithEvents txtTipoEnsaio As TextBox
    Public WithEvents txtCliente As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents lblLabel1 As Label
    Public WithEvents txtIdAmostra As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents txtValorExtra2 As TextBox
    Public WithEvents Label14 As Label
    Public WithEvents txtTituloExtra2 As TextBox
    Public WithEvents Label15 As Label
    Public WithEvents txtValorExtra1 As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents txtTituloExtra1 As TextBox
    Public WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents txtOperador As TextBox
    Public WithEvents Label9 As Label
    Public WithEvents txtTipoMaterial As TextBox
    Public WithEvents Label8 As Label
    Friend WithEvents RadioButtonDnit As RadioButton
    Friend WithEvents cmbCompactacao As ComboBox
    Friend WithEvents RadioButtonAbnt As RadioButton
    Friend WithEvents Label6 As Label
    Public WithEvents Label3 As Label
    Public WithEvents txtResponsavel As TextBox
    Public WithEvents Label5 As Label
End Class
