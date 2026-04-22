<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogotipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogotipo))
        Me.pctLogotipo = New System.Windows.Forms.PictureBox
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.grbGroup2 = New System.Windows.Forms.GroupBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.pnlPanel = New System.Windows.Forms.Panel
        Me.grbGroup1 = New System.Windows.Forms.GroupBox
        Me.lblLabel2 = New System.Windows.Forms.Label
        Me.lblLabel1 = New System.Windows.Forms.Label
        Me.ofdDialogo = New System.Windows.Forms.OpenFileDialog
        CType(Me.pctLogotipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbGroup2.SuspendLayout()
        Me.pnlPanel.SuspendLayout()
        Me.grbGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctLogotipo
        '
        Me.pctLogotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pctLogotipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctLogotipo.Location = New System.Drawing.Point(10, 19)
        Me.pctLogotipo.MaximumSize = New System.Drawing.Size(295, 80)
        Me.pctLogotipo.MinimumSize = New System.Drawing.Size(88, 63)
        Me.pctLogotipo.Name = "pctLogotipo"
        Me.pctLogotipo.Size = New System.Drawing.Size(295, 80)
        Me.pctLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctLogotipo.TabIndex = 0
        Me.pctLogotipo.TabStop = False
        '
        'btnCarregar
        '
        Me.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCarregar.Image = CType(resources.GetObject("btnCarregar.Image"), System.Drawing.Image)
        Me.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarregar.Location = New System.Drawing.Point(160, 3)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCarregar.Size = New System.Drawing.Size(81, 26)
        Me.btnCarregar.TabIndex = 0
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'grbGroup2
        '
        Me.grbGroup2.Controls.Add(Me.pctLogotipo)
        Me.grbGroup2.Location = New System.Drawing.Point(10, 120)
        Me.grbGroup2.Name = "grbGroup2"
        Me.grbGroup2.Size = New System.Drawing.Size(315, 110)
        Me.grbGroup2.TabIndex = 11
        Me.grbGroup2.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(246, 278)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(246, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.btnCancelar)
        Me.pnlPanel.Controls.Add(Me.btnCarregar)
        Me.pnlPanel.Location = New System.Drawing.Point(-1, 238)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(339, 34)
        Me.pnlPanel.TabIndex = 87
        '
        'grbGroup1
        '
        Me.grbGroup1.Controls.Add(Me.lblLabel2)
        Me.grbGroup1.Controls.Add(Me.lblLabel1)
        Me.grbGroup1.Location = New System.Drawing.Point(8, 8)
        Me.grbGroup1.Name = "grbGroup1"
        Me.grbGroup1.Size = New System.Drawing.Size(316, 106)
        Me.grbGroup1.TabIndex = 88
        Me.grbGroup1.TabStop = False
        '
        'lblLabel2
        '
        Me.lblLabel2.Location = New System.Drawing.Point(12, 70)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(295, 29)
        Me.lblLabel2.TabIndex = 11
        Me.lblLabel2.Text = "- Clicar no botão ""Carregar Logotipo"" e localizar o logotipo desejado."
        Me.lblLabel2.UseCompatibleTextRendering = True
        '
        'lblLabel1
        '
        Me.lblLabel1.Location = New System.Drawing.Point(12, 16)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(296, 54)
        Me.lblLabel1.TabIndex = 10
        Me.lblLabel1.Text = "- Criar o arquivo de imagem do logotipo com as dimensões máximas de: 295 pixels d" & _
            "e largura e 80 pixels de altura. E mínimas de: 88 pixels de largura e 63 pixels " & _
            "de altura."
        Me.lblLabel1.UseCompatibleTextRendering = True
        '
        'ofdDialogo
        '
        Me.ofdDialogo.Filter = "(Jpeg Files) *.jpg | *.jpg"
        Me.ofdDialogo.Title = "Selecionar imagem"
        '
        'frmLogotipo
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(335, 307)
        Me.Controls.Add(Me.grbGroup1)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.grbGroup2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogotipo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inserir um novo logotipo no relatório"
        CType(Me.pctLogotipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbGroup2.ResumeLayout(False)
        Me.pnlPanel.ResumeLayout(False)
        Me.grbGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctLogotipo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents grbGroup2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents grbGroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabel2 As System.Windows.Forms.Label
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label
    Friend WithEvents ofdDialogo As System.Windows.Forms.OpenFileDialog
End Class
