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
        Me.gpbGroup1 = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtTipoEnsaio = New System.Windows.Forms.TextBox()
        Me.RadioButtonDnit = New System.Windows.Forms.RadioButton()
        Me.cmbCompactacao = New System.Windows.Forms.ComboBox()
        Me.RadioButtonAbnt = New System.Windows.Forms.RadioButton()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrograma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.txtIdAmostra = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCP = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.gpbGroup1.SuspendLayout()
        Me.pnlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbGroup1
        '
        Me.gpbGroup1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gpbGroup1.Controls.Add(Me.txtNome)
        Me.gpbGroup1.Controls.Add(Me.txtTipoEnsaio)
        Me.gpbGroup1.Controls.Add(Me.RadioButtonDnit)
        Me.gpbGroup1.Controls.Add(Me.cmbCompactacao)
        Me.gpbGroup1.Controls.Add(Me.RadioButtonAbnt)
        Me.gpbGroup1.Controls.Add(Me.mskData)
        Me.gpbGroup1.Controls.Add(Me.Label6)
        Me.gpbGroup1.Controls.Add(Me.Label3)
        Me.gpbGroup1.Controls.Add(Me.Label4)
        Me.gpbGroup1.Controls.Add(Me.txtResponsavel)
        Me.gpbGroup1.Controls.Add(Me.Label5)
        Me.gpbGroup1.Controls.Add(Me.txtNumero)
        Me.gpbGroup1.Controls.Add(Me.Label2)
        Me.gpbGroup1.Controls.Add(Me.txtPrograma)
        Me.gpbGroup1.Controls.Add(Me.Label1)
        Me.gpbGroup1.Controls.Add(Me.lblLabel1)
        Me.gpbGroup1.Controls.Add(Me.txtIdAmostra)
        Me.gpbGroup1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gpbGroup1.Location = New System.Drawing.Point(14, 12)
        Me.gpbGroup1.Name = "gpbGroup1"
        Me.gpbGroup1.Padding = New System.Windows.Forms.Padding(0)
        Me.gpbGroup1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gpbGroup1.Size = New System.Drawing.Size(531, 208)
        Me.gpbGroup1.TabIndex = 41
        Me.gpbGroup1.TabStop = False
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome.Location = New System.Drawing.Point(121, 24)
        Me.txtNome.MaxLength = 90
        Me.txtNome.Name = "txtNome"
        Me.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNome.Size = New System.Drawing.Size(396, 20)
        Me.txtNome.TabIndex = 0
        '
        'txtTipoEnsaio
        '
        Me.txtTipoEnsaio.BackColor = System.Drawing.SystemColors.Window
        Me.txtTipoEnsaio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTipoEnsaio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTipoEnsaio.Location = New System.Drawing.Point(121, 24)
        Me.txtTipoEnsaio.MaxLength = 90
        Me.txtTipoEnsaio.Name = "txtTipoEnsaio"
        Me.txtTipoEnsaio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTipoEnsaio.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoEnsaio.TabIndex = 92
        '
        'RadioButtonDnit
        '
        Me.RadioButtonDnit.AutoSize = True
        Me.RadioButtonDnit.Checked = True
        Me.RadioButtonDnit.Enabled = False
        Me.RadioButtonDnit.Location = New System.Drawing.Point(121, 167)
        Me.RadioButtonDnit.Name = "RadioButtonDnit"
        Me.RadioButtonDnit.Size = New System.Drawing.Size(97, 17)
        Me.RadioButtonDnit.TabIndex = 91
        Me.RadioButtonDnit.TabStop = True
        Me.RadioButtonDnit.Text = "DNIT 172 - ME"
        Me.RadioButtonDnit.UseVisualStyleBackColor = True
        '
        'cmbCompactacao
        '
        Me.cmbCompactacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompactacao.FormattingEnabled = True
        Me.cmbCompactacao.Items.AddRange(New Object() {"Proctor Normal", "Proctor Intermediário", "Proctor Modificado", "Outros"})
        Me.cmbCompactacao.Location = New System.Drawing.Point(356, 126)
        Me.cmbCompactacao.Name = "cmbCompactacao"
        Me.cmbCompactacao.Size = New System.Drawing.Size(161, 21)
        Me.cmbCompactacao.TabIndex = 54
        '
        'RadioButtonAbnt
        '
        Me.RadioButtonAbnt.AutoSize = True
        Me.RadioButtonAbnt.Enabled = False
        Me.RadioButtonAbnt.Location = New System.Drawing.Point(234, 167)
        Me.RadioButtonAbnt.Name = "RadioButtonAbnt"
        Me.RadioButtonAbnt.Size = New System.Drawing.Size(107, 17)
        Me.RadioButtonAbnt.TabIndex = 90
        Me.RadioButtonAbnt.Text = "ABNT NBR 9895"
        Me.RadioButtonAbnt.UseVisualStyleBackColor = True
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(121, 126)
        Me.mskData.Mask = "00/00/0000"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(88, 20)
        Me.mskData.TabIndex = 53
        Me.mskData.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 169)
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
        Me.Label3.Location = New System.Drawing.Point(220, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Energia de Compactação:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Data do Ensaio:"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.BackColor = System.Drawing.SystemColors.Window
        Me.txtResponsavel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtResponsavel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtResponsavel.Location = New System.Drawing.Point(121, 91)
        Me.txtResponsavel.MaxLength = 90
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtResponsavel.Size = New System.Drawing.Size(396, 20)
        Me.txtResponsavel.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Responsável:"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumero.Location = New System.Drawing.Point(356, 59)
        Me.txtNumero.MaxLength = 90
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumero.Size = New System.Drawing.Size(161, 20)
        Me.txtNumero.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(287, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nº Amostra:"
        '
        'txtPrograma
        '
        Me.txtPrograma.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrograma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrograma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrograma.Location = New System.Drawing.Point(121, 59)
        Me.txtPrograma.MaxLength = 90
        Me.txtPrograma.Name = "txtPrograma"
        Me.txtPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrograma.Size = New System.Drawing.Size(140, 20)
        Me.txtPrograma.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Programa Nº:"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.BackColor = System.Drawing.Color.Transparent
        Me.lblLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel1.ForeColor = System.Drawing.Color.Black
        Me.lblLabel1.Location = New System.Drawing.Point(21, 27)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel1.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel1.TabIndex = 42
        Me.lblLabel1.Text = "Nome da Amostra:"
        '
        'txtIdAmostra
        '
        Me.txtIdAmostra.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdAmostra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdAmostra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdAmostra.Location = New System.Drawing.Point(216, 59)
        Me.txtIdAmostra.MaxLength = 90
        Me.txtIdAmostra.Name = "txtIdAmostra"
        Me.txtIdAmostra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIdAmostra.Size = New System.Drawing.Size(45, 20)
        Me.txtIdAmostra.TabIndex = 55
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(464, 283)
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
        Me.pnlPanel.Location = New System.Drawing.Point(-4, 230)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(565, 34)
        Me.pnlPanel.TabIndex = 88
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(380, 3)
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
        Me.btnCP.Location = New System.Drawing.Point(293, 3)
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
        Me.btnSalvar.Location = New System.Drawing.Point(467, 3)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Padding = New System.Windows.Forms.Padding(6, 0, 7, 0)
        Me.btnSalvar.Size = New System.Drawing.Size(81, 26)
        Me.btnSalvar.TabIndex = 11
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'frmCadastrarAmostra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(559, 316)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.gpbGroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastrarAmostra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados da amostra"
        Me.gpbGroup1.ResumeLayout(False)
        Me.gpbGroup1.PerformLayout()
        Me.pnlPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents gpbGroup1 As System.Windows.Forms.GroupBox
    Public WithEvents txtNome As System.Windows.Forms.TextBox
    Public WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnCP As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtResponsavel As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtNumero As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtPrograma As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCompactacao As System.Windows.Forms.ComboBox
    Friend WithEvents mskData As System.Windows.Forms.MaskedTextBox
    Public WithEvents txtIdAmostra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButtonDnit As RadioButton
    Friend WithEvents RadioButtonAbnt As RadioButton
    Public WithEvents txtTipoEnsaio As TextBox
End Class
