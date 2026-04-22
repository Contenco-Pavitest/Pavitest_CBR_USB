<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPainel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPainel))
        Me.grpPainel = New System.Windows.Forms.GroupBox()
        Me.pctZerarDeformacao = New System.Windows.Forms.PictureBox()
        Me.pctZerarCarga = New System.Windows.Forms.PictureBox()
        Me.lblCarga = New System.Windows.Forms.Label()
        Me.lblLVDT = New System.Windows.Forms.Label()
        Me.chkSelecaoDeformacao = New System.Windows.Forms.CheckBox()
        Me.chkSelecaoCarga = New System.Windows.Forms.CheckBox()
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctLeituraNao = New System.Windows.Forms.PictureBox()
        Me.pctLeituraSim = New System.Windows.Forms.PictureBox()
        Me.barStatus = New System.Windows.Forms.ProgressBar()
        Me.tmrComunicacao = New System.Windows.Forms.Timer(Me.components)
        Me.btnSair = New System.Windows.Forms.Button()
        Me.spPortaSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.grpPainel.SuspendLayout()
        CType(Me.pctZerarDeformacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctZerarCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLeituraNao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLeituraSim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPainel
        '
        Me.grpPainel.Controls.Add(Me.pctZerarDeformacao)
        Me.grpPainel.Controls.Add(Me.pctZerarCarga)
        Me.grpPainel.Controls.Add(Me.lblCarga)
        Me.grpPainel.Controls.Add(Me.lblLVDT)
        Me.grpPainel.Controls.Add(Me.chkSelecaoDeformacao)
        Me.grpPainel.Controls.Add(Me.chkSelecaoCarga)
        Me.grpPainel.Controls.Add(Me.lblMsgErro)
        Me.grpPainel.Controls.Add(Me.Label1)
        Me.grpPainel.Controls.Add(Me.pctLeituraNao)
        Me.grpPainel.Controls.Add(Me.pctLeituraSim)
        Me.grpPainel.Enabled = False
        Me.grpPainel.Location = New System.Drawing.Point(16, 7)
        Me.grpPainel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPainel.Name = "grpPainel"
        Me.grpPainel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpPainel.Size = New System.Drawing.Size(347, 287)
        Me.grpPainel.TabIndex = 0
        Me.grpPainel.TabStop = False
        '
        'pctZerarDeformacao
        '
        Me.pctZerarDeformacao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pctZerarDeformacao.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctZerarDeformacao.Enabled = False
        Me.pctZerarDeformacao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctZerarDeformacao.Image = CType(resources.GetObject("pctZerarDeformacao.Image"), System.Drawing.Image)
        Me.pctZerarDeformacao.Location = New System.Drawing.Point(227, 192)
        Me.pctZerarDeformacao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctZerarDeformacao.Name = "pctZerarDeformacao"
        Me.pctZerarDeformacao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctZerarDeformacao.Size = New System.Drawing.Size(16, 16)
        Me.pctZerarDeformacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctZerarDeformacao.TabIndex = 227
        Me.pctZerarDeformacao.TabStop = False
        '
        'pctZerarCarga
        '
        Me.pctZerarCarga.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pctZerarCarga.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctZerarCarga.Enabled = False
        Me.pctZerarCarga.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctZerarCarga.Image = CType(resources.GetObject("pctZerarCarga.Image"), System.Drawing.Image)
        Me.pctZerarCarga.Location = New System.Drawing.Point(227, 111)
        Me.pctZerarCarga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctZerarCarga.Name = "pctZerarCarga"
        Me.pctZerarCarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctZerarCarga.Size = New System.Drawing.Size(16, 16)
        Me.pctZerarCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctZerarCarga.TabIndex = 226
        Me.pctZerarCarga.TabStop = False
        '
        'lblCarga
        '
        Me.lblCarga.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarga.ForeColor = System.Drawing.Color.Lime
        Me.lblCarga.Location = New System.Drawing.Point(104, 102)
        Me.lblCarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.Size = New System.Drawing.Size(114, 36)
        Me.lblCarga.TabIndex = 5
        Me.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLVDT
        '
        Me.lblLVDT.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblLVDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLVDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLVDT.ForeColor = System.Drawing.Color.Lime
        Me.lblLVDT.Location = New System.Drawing.Point(104, 182)
        Me.lblLVDT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLVDT.Name = "lblLVDT"
        Me.lblLVDT.Size = New System.Drawing.Size(114, 36)
        Me.lblLVDT.TabIndex = 4
        Me.lblLVDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkSelecaoDeformacao
        '
        Me.chkSelecaoDeformacao.AutoSize = True
        Me.chkSelecaoDeformacao.Location = New System.Drawing.Point(104, 158)
        Me.chkSelecaoDeformacao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSelecaoDeformacao.Name = "chkSelecaoDeformacao"
        Me.chkSelecaoDeformacao.Size = New System.Drawing.Size(139, 21)
        Me.chkSelecaoDeformacao.TabIndex = 3
        Me.chkSelecaoDeformacao.Text = "Penetração (mm)"
        Me.chkSelecaoDeformacao.UseVisualStyleBackColor = True
        '
        'chkSelecaoCarga
        '
        Me.chkSelecaoCarga.AutoSize = True
        Me.chkSelecaoCarga.Location = New System.Drawing.Point(104, 78)
        Me.chkSelecaoCarga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSelecaoCarga.Name = "chkSelecaoCarga"
        Me.chkSelecaoCarga.Size = New System.Drawing.Size(101, 21)
        Me.chkSelecaoCarga.TabIndex = 2
        Me.chkSelecaoCarga.Text = "Carga (kgf)"
        Me.chkSelecaoCarga.UseVisualStyleBackColor = True
        '
        'lblMsgErro
        '
        Me.lblMsgErro.BackColor = System.Drawing.Color.Red
        Me.lblMsgErro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMsgErro.ForeColor = System.Drawing.Color.White
        Me.lblMsgErro.Location = New System.Drawing.Point(8, 226)
        Me.lblMsgErro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.Size = New System.Drawing.Size(330, 52)
        Me.lblMsgErro.TabIndex = 1
        Me.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsgErro.Visible = False
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Leituras dos Instrumentos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctLeituraNao
        '
        Me.pctLeituraNao.BackColor = System.Drawing.Color.Transparent
        Me.pctLeituraNao.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctLeituraNao.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctLeituraNao.Image = CType(resources.GetObject("pctLeituraNao.Image"), System.Drawing.Image)
        Me.pctLeituraNao.Location = New System.Drawing.Point(29, 69)
        Me.pctLeituraNao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctLeituraNao.Name = "pctLeituraNao"
        Me.pctLeituraNao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctLeituraNao.Size = New System.Drawing.Size(24, 24)
        Me.pctLeituraNao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctLeituraNao.TabIndex = 76
        Me.pctLeituraNao.TabStop = False
        '
        'pctLeituraSim
        '
        Me.pctLeituraSim.BackColor = System.Drawing.Color.Transparent
        Me.pctLeituraSim.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctLeituraSim.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctLeituraSim.Image = CType(resources.GetObject("pctLeituraSim.Image"), System.Drawing.Image)
        Me.pctLeituraSim.Location = New System.Drawing.Point(29, 69)
        Me.pctLeituraSim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctLeituraSim.Name = "pctLeituraSim"
        Me.pctLeituraSim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctLeituraSim.Size = New System.Drawing.Size(24, 24)
        Me.pctLeituraSim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctLeituraSim.TabIndex = 75
        Me.pctLeituraSim.TabStop = False
        '
        'barStatus
        '
        Me.barStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.barStatus.Location = New System.Drawing.Point(15, 298)
        Me.barStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(347, 28)
        Me.barStatus.TabIndex = 1
        '
        'tmrComunicacao
        '
        Me.tmrComunicacao.Interval = 500
        '
        'btnSair
        '
        Me.btnSair.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(231, 331)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(129, 37)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'spPortaSerial
        '
        Me.spPortaSerial.BaudRate = 115200
        Me.spPortaSerial.ReadTimeout = 200
        Me.spPortaSerial.RtsEnable = True
        Me.spPortaSerial.WriteTimeout = 200
        '
        'frmPainel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 372)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.barStatus)
        Me.Controls.Add(Me.grpPainel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPainel"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizador de Leituras"
        Me.grpPainel.ResumeLayout(False)
        Me.grpPainel.PerformLayout()
        CType(Me.pctZerarDeformacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctZerarCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLeituraNao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLeituraSim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPainel As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents barStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrComunicacao As System.Windows.Forms.Timer
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents lblMsgErro As System.Windows.Forms.Label
    Friend WithEvents chkSelecaoDeformacao As System.Windows.Forms.CheckBox
    Friend WithEvents chkSelecaoCarga As System.Windows.Forms.CheckBox
    Friend WithEvents lblCarga As System.Windows.Forms.Label
    Friend WithEvents lblLVDT As System.Windows.Forms.Label
    Friend WithEvents spPortaSerial As System.IO.Ports.SerialPort
    Public WithEvents pctLeituraNao As System.Windows.Forms.PictureBox
    Public WithEvents pctLeituraSim As System.Windows.Forms.PictureBox
    Public WithEvents pctZerarDeformacao As System.Windows.Forms.PictureBox
    Public WithEvents pctZerarCarga As System.Windows.Forms.PictureBox
End Class
