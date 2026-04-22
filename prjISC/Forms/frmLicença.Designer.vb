<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicença
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicença))
        Me.mtxtChave = New System.Windows.Forms.MaskedTextBox
        Me.mtxtContraChave = New System.Windows.Forms.MaskedTextBox
        Me.lblChave = New System.Windows.Forms.Label
        Me.lblContraChave = New System.Windows.Forms.Label
        Me.btnAtivarLicença = New System.Windows.Forms.Button
        Me.lblStatusAtivação = New System.Windows.Forms.Label
        Me.btnCriarChave = New System.Windows.Forms.Button
        Me.svfd1 = New System.Windows.Forms.SaveFileDialog
        Me.pnlPanel = New System.Windows.Forms.Panel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mtxtChave
        '
        Me.mtxtChave.AsciiOnly = True
        Me.mtxtChave.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mtxtChave.Location = New System.Drawing.Point(20, 31)
        Me.mtxtChave.Mask = "CCC-CCCC-CCCCCCCCCC-CCCCCCCCCC-CCCCC-CCC-CCCC-CCCCCCCCCC-CCCCCCCCCC-CCCCC"
        Me.mtxtChave.Name = "mtxtChave"
        Me.mtxtChave.ReadOnly = True
        Me.mtxtChave.Size = New System.Drawing.Size(597, 20)
        Me.mtxtChave.TabIndex = 0
        '
        'mtxtContraChave
        '
        Me.mtxtContraChave.AsciiOnly = True
        Me.mtxtContraChave.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mtxtContraChave.Location = New System.Drawing.Point(20, 90)
        Me.mtxtContraChave.Mask = "CCCCCCCC-CCCCCCCC-CCCCCCCC-CCCCCCCC-CCCCCCCC-CCCCCCCC-CCCCCCCC-CCCCCCCC"
        Me.mtxtContraChave.Name = "mtxtContraChave"
        Me.mtxtContraChave.Size = New System.Drawing.Size(596, 20)
        Me.mtxtContraChave.TabIndex = 1
        '
        'lblChave
        '
        Me.lblChave.AutoSize = True
        Me.lblChave.Location = New System.Drawing.Point(17, 15)
        Me.lblChave.Name = "lblChave"
        Me.lblChave.Size = New System.Drawing.Size(41, 13)
        Me.lblChave.TabIndex = 2
        Me.lblChave.Text = "Chave:"
        '
        'lblContraChave
        '
        Me.lblContraChave.AutoSize = True
        Me.lblContraChave.Location = New System.Drawing.Point(17, 74)
        Me.lblContraChave.Name = "lblContraChave"
        Me.lblContraChave.Size = New System.Drawing.Size(75, 13)
        Me.lblContraChave.TabIndex = 3
        Me.lblContraChave.Text = "Contra-Chave:"
        '
        'btnAtivarLicença
        '
        Me.btnAtivarLicença.Image = CType(resources.GetObject("btnAtivarLicença.Image"), System.Drawing.Image)
        Me.btnAtivarLicença.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtivarLicença.Location = New System.Drawing.Point(516, 153)
        Me.btnAtivarLicença.Name = "btnAtivarLicença"
        Me.btnAtivarLicença.Size = New System.Drawing.Size(101, 32)
        Me.btnAtivarLicença.TabIndex = 4
        Me.btnAtivarLicença.Text = "Ativar Licença"
        Me.btnAtivarLicença.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAtivarLicença.UseVisualStyleBackColor = True
        '
        'lblStatusAtivação
        '
        Me.lblStatusAtivação.AutoSize = True
        Me.lblStatusAtivação.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusAtivação.Location = New System.Drawing.Point(269, 123)
        Me.lblStatusAtivação.Name = "lblStatusAtivação"
        Me.lblStatusAtivação.Size = New System.Drawing.Size(97, 13)
        Me.lblStatusAtivação.TabIndex = 5
        Me.lblStatusAtivação.Text = "Status Ativação"
        '
        'btnCriarChave
        '
        Me.btnCriarChave.Image = CType(resources.GetObject("btnCriarChave.Image"), System.Drawing.Image)
        Me.btnCriarChave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCriarChave.Location = New System.Drawing.Point(409, 153)
        Me.btnCriarChave.Name = "btnCriarChave"
        Me.btnCriarChave.Size = New System.Drawing.Size(101, 32)
        Me.btnCriarChave.TabIndex = 6
        Me.btnCriarChave.Text = "    Criar Chave"
        Me.btnCriarChave.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Location = New System.Drawing.Point(-5, 191)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(645, 10)
        Me.pnlPanel.TabIndex = 91
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(234, 251)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(222, 17)
        Me.LinkLabel1.TabIndex = 92
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "assistencia.tecnica@contenco.com.br"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 39)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Clique no botão ""Criar Chave"", selecione um local para salvar o arquivo (Chave.dl" & _
            "l) que contém a chave de solicitação para a ativação do software. "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 17)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Redija um e-mail para o endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(19, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 17)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "- Nome da empresa/instituição;"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(19, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "- CNPJ;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(391, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 17)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "- Número da nota fiscal;"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(391, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 17)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "- Modelo do equipamento;"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(19, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "- Localidade;"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(391, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 17)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "- Número de série do equipamento;"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(452, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 17)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = ", anexando esse arquivo, "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(241, 17)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "e fornecendo as seguintes informações:"
        '
        'frmLicença
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(634, 376)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.btnCriarChave)
        Me.Controls.Add(Me.lblStatusAtivação)
        Me.Controls.Add(Me.btnAtivarLicença)
        Me.Controls.Add(Me.lblContraChave)
        Me.Controls.Add(Me.lblChave)
        Me.Controls.Add(Me.mtxtContraChave)
        Me.Controls.Add(Me.mtxtChave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLicença"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Licença Pavitest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtxtChave As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtContraChave As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblChave As System.Windows.Forms.Label
    Friend WithEvents lblContraChave As System.Windows.Forms.Label
    Friend WithEvents btnAtivarLicença As System.Windows.Forms.Button
    Friend WithEvents lblStatusAtivação As System.Windows.Forms.Label
    Friend WithEvents btnCriarChave As System.Windows.Forms.Button
    Friend WithEvents svfd1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
