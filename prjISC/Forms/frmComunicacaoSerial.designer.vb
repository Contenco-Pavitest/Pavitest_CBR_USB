<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmComunicacaoSerial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComunicacaoSerial))
        Me.tmrComunicacao = New System.Windows.Forms.Timer(Me.components)
        Me.grbGroup = New System.Windows.Forms.GroupBox()
        Me.lblLabel0 = New System.Windows.Forms.Label()
        Me.lblControlador = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLVDT = New System.Windows.Forms.Label()
        Me.lblCarga = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.barStatus = New System.Windows.Forms.ProgressBar()
        Me.btnTestar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.lblMsgErro = New System.Windows.Forms.Label()
        Me.spPortaSerial = New System.IO.Ports.SerialPort(Me.components)
        Me.grbGroup.SuspendLayout()
        Me.pnlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrComunicacao
        '
        Me.tmrComunicacao.Interval = 500
        '
        'grbGroup
        '
        Me.grbGroup.Controls.Add(Me.lblLabel0)
        Me.grbGroup.Controls.Add(Me.lblControlador)
        Me.grbGroup.Controls.Add(Me.lblLabel1)
        Me.grbGroup.Controls.Add(Me.lblLabel2)
        Me.grbGroup.Controls.Add(Me.lblLVDT)
        Me.grbGroup.Controls.Add(Me.lblCarga)
        Me.grbGroup.Location = New System.Drawing.Point(41, 28)
        Me.grbGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbGroup.Name = "grbGroup"
        Me.grbGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbGroup.Size = New System.Drawing.Size(648, 201)
        Me.grbGroup.TabIndex = 62
        Me.grbGroup.TabStop = False
        '
        'lblLabel0
        '
        Me.lblLabel0.AutoSize = True
        Me.lblLabel0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel0.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel0.Location = New System.Drawing.Point(43, 47)
        Me.lblLabel0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel0.Name = "lblLabel0"
        Me.lblLabel0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel0.Size = New System.Drawing.Size(93, 17)
        Me.lblLabel0.TabIndex = 76
        Me.lblLabel0.Text = "Controlador"
        '
        'lblControlador
        '
        Me.lblControlador.AutoSize = True
        Me.lblControlador.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblControlador.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblControlador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblControlador.Location = New System.Drawing.Point(184, 47)
        Me.lblControlador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblControlador.Name = "lblControlador"
        Me.lblControlador.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblControlador.Size = New System.Drawing.Size(171, 17)
        Me.lblControlador.TabIndex = 75
        Me.lblControlador.Text = "Teste de comunicação ...."
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel1.Location = New System.Drawing.Point(43, 91)
        Me.lblLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel1.Size = New System.Drawing.Size(51, 17)
        Me.lblLabel1.TabIndex = 74
        Me.lblLabel1.Text = "Carga"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel2.Location = New System.Drawing.Point(43, 135)
        Me.lblLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel2.Size = New System.Drawing.Size(91, 17)
        Me.lblLabel2.TabIndex = 69
        Me.lblLabel2.Text = "Penetração"
        '
        'lblLVDT
        '
        Me.lblLVDT.AutoSize = True
        Me.lblLVDT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLVDT.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLVDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLVDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLVDT.Location = New System.Drawing.Point(184, 135)
        Me.lblLVDT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLVDT.Name = "lblLVDT"
        Me.lblLVDT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLVDT.Size = New System.Drawing.Size(171, 17)
        Me.lblLVDT.TabIndex = 72
        Me.lblLVDT.Text = "Teste de comunicação ...."
        '
        'lblCarga
        '
        Me.lblCarga.AutoSize = True
        Me.lblCarga.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCarga.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCarga.Location = New System.Drawing.Point(184, 91)
        Me.lblCarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCarga.Name = "lblCarga"
        Me.lblCarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCarga.Size = New System.Drawing.Size(171, 17)
        Me.lblCarga.TabIndex = 71
        Me.lblCarga.Text = "Teste de comunicação ...."
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(613, 311)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(108, 32)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.barStatus)
        Me.pnlPanel.Controls.Add(Me.btnTestar)
        Me.pnlPanel.Controls.Add(Me.btnParar)
        Me.pnlPanel.Location = New System.Drawing.Point(-3, 266)
        Me.pnlPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(750, 41)
        Me.pnlPanel.TabIndex = 90
        '
        'barStatus
        '
        Me.barStatus.Location = New System.Drawing.Point(13, 4)
        Me.barStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(477, 32)
        Me.barStatus.Step = 1
        Me.barStatus.TabIndex = 34
        Me.barStatus.Visible = False
        '
        'btnTestar
        '
        Me.btnTestar.Location = New System.Drawing.Point(499, 4)
        Me.btnTestar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTestar.Name = "btnTestar"
        Me.btnTestar.Size = New System.Drawing.Size(108, 32)
        Me.btnTestar.TabIndex = 0
        Me.btnTestar.Text = "Testar >>"
        Me.btnTestar.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Enabled = False
        Me.btnParar.Location = New System.Drawing.Point(613, 4)
        Me.btnParar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(108, 32)
        Me.btnParar.TabIndex = 1
        Me.btnParar.Text = "Parar"
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'lblMsgErro
        '
        Me.lblMsgErro.BackColor = System.Drawing.Color.Red
        Me.lblMsgErro.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMsgErro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgErro.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMsgErro.Location = New System.Drawing.Point(12, 315)
        Me.lblMsgErro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsgErro.Name = "lblMsgErro"
        Me.lblMsgErro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMsgErro.Size = New System.Drawing.Size(588, 27)
        Me.lblMsgErro.TabIndex = 92
        Me.lblMsgErro.Text = "Erro"
        Me.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsgErro.Visible = False
        '
        'spPortaSerial
        '
        Me.spPortaSerial.BaudRate = 115200
        Me.spPortaSerial.ReadTimeout = 200
        Me.spPortaSerial.RtsEnable = True
        Me.spPortaSerial.WriteTimeout = 200
        '
        'frmComunicacao
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(731, 356)
        Me.Controls.Add(Me.lblMsgErro)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.grbGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComunicacao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testar a comunição"
        Me.TopMost = True
        Me.grbGroup.ResumeLayout(False)
        Me.grbGroup.PerformLayout()
        Me.pnlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents tmrComunicacao As System.Windows.Forms.Timer
    Friend WithEvents grbGroup As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents btnTestar As System.Windows.Forms.Button
    Friend WithEvents btnParar As System.Windows.Forms.Button
    Public WithEvents lblMsgErro As System.Windows.Forms.Label
    Friend WithEvents spPortaSerial As System.IO.Ports.SerialPort
    Friend WithEvents barStatus As System.Windows.Forms.ProgressBar
    Public WithEvents lblLabel0 As System.Windows.Forms.Label
    Public WithEvents lblControlador As System.Windows.Forms.Label
    Public WithEvents lblLabel1 As System.Windows.Forms.Label
    Public WithEvents lblLabel2 As System.Windows.Forms.Label
    Public WithEvents lblLVDT As System.Windows.Forms.Label
    Public WithEvents lblCarga As System.Windows.Forms.Label
End Class
