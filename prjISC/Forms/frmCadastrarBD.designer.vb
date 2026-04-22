<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarBD))
        Me.lblLabel1 = New System.Windows.Forms.Label
        Me.lblLabel2 = New System.Windows.Forms.Label
        Me.grbGroup2 = New System.Windows.Forms.GroupBox
        Me.dtpCriar = New System.Windows.Forms.DateTimePicker
        Me.lblLabel5 = New System.Windows.Forms.Label
        Me.lblLabel4 = New System.Windows.Forms.Label
        Me.lblLabel3 = New System.Windows.Forms.Label
        Me.txtCoordenador = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.grbGroup1 = New System.Windows.Forms.GroupBox
        Me.lstFile = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.lstDrive = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.lstDiretorio = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.pctFigura = New System.Windows.Forms.PictureBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.pnlPanel = New System.Windows.Forms.Panel
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.grbGroup2.SuspendLayout()
        Me.grbGroup1.SuspendLayout()
        CType(Me.pctFigura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel1.Location = New System.Drawing.Point(45, 32)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(319, 13)
        Me.lblLabel1.TabIndex = 1
        Me.lblLabel1.Text = "Determinar o caminho para criar e/ou selecionar a base de dados:"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel2.Location = New System.Drawing.Point(45, 173)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(83, 13)
        Me.lblLabel2.TabIndex = 2
        Me.lblLabel2.Text = "Base de Dados:"
        '
        'grbGroup2
        '
        Me.grbGroup2.Controls.Add(Me.dtpCriar)
        Me.grbGroup2.Controls.Add(Me.lblLabel5)
        Me.grbGroup2.Controls.Add(Me.lblLabel4)
        Me.grbGroup2.Controls.Add(Me.lblLabel3)
        Me.grbGroup2.Controls.Add(Me.txtCoordenador)
        Me.grbGroup2.Controls.Add(Me.txtNome)
        Me.grbGroup2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbGroup2.Location = New System.Drawing.Point(48, 277)
        Me.grbGroup2.Name = "grbGroup2"
        Me.grbGroup2.Size = New System.Drawing.Size(305, 113)
        Me.grbGroup2.TabIndex = 7
        Me.grbGroup2.TabStop = False
        Me.grbGroup2.Text = "Cadastro do  Base de Dados"
        '
        'dtpCriar
        '
        Me.dtpCriar.Enabled = False
        Me.dtpCriar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCriar.Location = New System.Drawing.Point(86, 23)
        Me.dtpCriar.Name = "dtpCriar"
        Me.dtpCriar.Size = New System.Drawing.Size(85, 20)
        Me.dtpCriar.TabIndex = 3
        '
        'lblLabel5
        '
        Me.lblLabel5.AutoSize = True
        Me.lblLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel5.Location = New System.Drawing.Point(12, 79)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(65, 13)
        Me.lblLabel5.TabIndex = 5
        Me.lblLabel5.Text = "Cordenador:"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel4.Location = New System.Drawing.Point(12, 53)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel4.TabIndex = 4
        Me.lblLabel4.Text = "Nome:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel3.Location = New System.Drawing.Point(12, 27)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(71, 13)
        Me.lblLabel3.TabIndex = 3
        Me.lblLabel3.Text = "Data criação:"
        '
        'txtCoordenador
        '
        Me.txtCoordenador.BackColor = System.Drawing.SystemColors.Window
        Me.txtCoordenador.Location = New System.Drawing.Point(86, 76)
        Me.txtCoordenador.Name = "txtCoordenador"
        Me.txtCoordenador.Size = New System.Drawing.Size(185, 20)
        Me.txtCoordenador.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Location = New System.Drawing.Point(86, 50)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(185, 20)
        Me.txtNome.TabIndex = 4
        '
        'grbGroup1
        '
        Me.grbGroup1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grbGroup1.Controls.Add(Me.lstFile)
        Me.grbGroup1.Controls.Add(Me.lstDrive)
        Me.grbGroup1.Controls.Add(Me.lstDiretorio)
        Me.grbGroup1.Controls.Add(Me.pctFigura)
        Me.grbGroup1.Controls.Add(Me.grbGroup2)
        Me.grbGroup1.Controls.Add(Me.lblLabel2)
        Me.grbGroup1.Controls.Add(Me.lblLabel1)
        Me.grbGroup1.Location = New System.Drawing.Point(10, 8)
        Me.grbGroup1.Name = "grbGroup1"
        Me.grbGroup1.Size = New System.Drawing.Size(407, 407)
        Me.grbGroup1.TabIndex = 13
        Me.grbGroup1.TabStop = False
        '
        'lstFile
        '
        Me.lstFile.FormattingEnabled = True
        Me.lstFile.Location = New System.Drawing.Point(48, 188)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.Pattern = "*.mdb"
        Me.lstFile.Size = New System.Drawing.Size(305, 82)
        Me.lstFile.TabIndex = 2
        '
        'lstDrive
        '
        Me.lstDrive.FormattingEnabled = True
        Me.lstDrive.Location = New System.Drawing.Point(48, 51)
        Me.lstDrive.Name = "lstDrive"
        Me.lstDrive.Size = New System.Drawing.Size(88, 21)
        Me.lstDrive.TabIndex = 0
        '
        'lstDiretorio
        '
        Me.lstDiretorio.FormattingEnabled = True
        Me.lstDiretorio.IntegralHeight = False
        Me.lstDiretorio.Location = New System.Drawing.Point(48, 78)
        Me.lstDiretorio.Name = "lstDiretorio"
        Me.lstDiretorio.Size = New System.Drawing.Size(305, 92)
        Me.lstDiretorio.TabIndex = 1
        '
        'pctFigura
        '
        Me.pctFigura.Image = CType(resources.GetObject("pctFigura.Image"), System.Drawing.Image)
        Me.pctFigura.Location = New System.Drawing.Point(9, 19)
        Me.pctFigura.Name = "pctFigura"
        Me.pctFigura.Size = New System.Drawing.Size(33, 36)
        Me.pctFigura.TabIndex = 8
        Me.pctFigura.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(334, 469)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnSalvar)
        Me.pnlPanel.Controls.Add(Me.btnCancelar)
        Me.pnlPanel.Controls.Add(Me.btnEditar)
        Me.pnlPanel.Controls.Add(Me.btnNovo)
        Me.pnlPanel.Location = New System.Drawing.Point(-1, 428)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(429, 34)
        Me.pnlPanel.TabIndex = 86
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(247, 3)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Padding = New System.Windows.Forms.Padding(6, 0, 7, 0)
        Me.btnSalvar.Size = New System.Drawing.Size(81, 26)
        Me.btnSalvar.TabIndex = 8
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(334, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(160, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Padding = New System.Windows.Forms.Padding(8, 0, 12, 0)
        Me.btnEditar.Size = New System.Drawing.Size(81, 26)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(73, 3)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Padding = New System.Windows.Forms.Padding(8, 0, 12, 0)
        Me.btnNovo.Size = New System.Drawing.Size(81, 26)
        Me.btnNovo.TabIndex = 6
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'frmCadastrarBD
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(427, 501)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.grbGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarBD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar e selecionar Base de Dados"
        Me.TopMost = True
        Me.grbGroup2.ResumeLayout(False)
        Me.grbGroup2.PerformLayout()
        Me.grbGroup1.ResumeLayout(False)
        Me.grbGroup1.PerformLayout()
        CType(Me.pctFigura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblLabel2 As System.Windows.Forms.Label
    Friend WithEvents grbGroup2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabel5 As System.Windows.Forms.Label
    Friend WithEvents lblLabel4 As System.Windows.Forms.Label
    Friend WithEvents lblLabel3 As System.Windows.Forms.Label
    Friend WithEvents txtCoordenador As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents grbGroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents pctFigura As System.Windows.Forms.PictureBox
    Friend WithEvents lstDrive As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents lstDiretorio As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents lstFile As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents dtpCriar As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
End Class
