<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurarEnsaio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigurarEnsaio))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnParametrizacaoFabricante = New System.Windows.Forms.Button()
        Me.btnModoSimulacao = New System.Windows.Forms.Button()
        Me.tbpPagina1 = New System.Windows.Forms.TabPage()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.pctFigura1 = New System.Windows.Forms.PictureBox()
        Me.grpGrupo1 = New System.Windows.Forms.GroupBox()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.txtIntervalo = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbcControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.tbpPagina1.SuspendLayout()
        CType(Me.pctFigura1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGrupo1.SuspendLayout()
        Me.tbcControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(278, 258)
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
        Me.btnCancelar.Location = New System.Drawing.Point(365, 258)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.btnModoSimulacao)
        Me.TabPage1.Controls.Add(Me.btnParametrizacaoFabricante)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(456, 214)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Fabricante"
        '
        'btnParametrizacaoFabricante
        '
        Me.btnParametrizacaoFabricante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParametrizacaoFabricante.Location = New System.Drawing.Point(230, 82)
        Me.btnParametrizacaoFabricante.Name = "btnParametrizacaoFabricante"
        Me.btnParametrizacaoFabricante.Size = New System.Drawing.Size(146, 51)
        Me.btnParametrizacaoFabricante.TabIndex = 3
        Me.btnParametrizacaoFabricante.Text = "Parametrização Fabricante"
        Me.btnParametrizacaoFabricante.UseVisualStyleBackColor = True
        Me.btnParametrizacaoFabricante.Visible = False
        '
        'btnModoSimulacao
        '
        Me.btnModoSimulacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModoSimulacao.Location = New System.Drawing.Point(81, 82)
        Me.btnModoSimulacao.Name = "btnModoSimulacao"
        Me.btnModoSimulacao.Size = New System.Drawing.Size(146, 51)
        Me.btnModoSimulacao.TabIndex = 4
        Me.btnModoSimulacao.Text = "Ativar Modo Simulação"
        Me.btnModoSimulacao.UseVisualStyleBackColor = True
        '
        'tbpPagina1
        '
        Me.tbpPagina1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpPagina1.Controls.Add(Me.grpGrupo1)
        Me.tbpPagina1.Controls.Add(Me.pctFigura1)
        Me.tbpPagina1.Controls.Add(Me.lblLabel1)
        Me.tbpPagina1.Location = New System.Drawing.Point(4, 22)
        Me.tbpPagina1.Name = "tbpPagina1"
        Me.tbpPagina1.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPagina1.Size = New System.Drawing.Size(456, 214)
        Me.tbpPagina1.TabIndex = 0
        Me.tbpPagina1.Text = "Intervalo e Área Pistão"
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel1.Location = New System.Drawing.Point(60, 15)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(311, 13)
        Me.lblLabel1.TabIndex = 99
        Me.lblLabel1.Text = "Configurações de intervalo de tempo e área do pistão"
        '
        'pctFigura1
        '
        Me.pctFigura1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pctFigura1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctFigura1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctFigura1.Image = CType(resources.GetObject("pctFigura1.Image"), System.Drawing.Image)
        Me.pctFigura1.Location = New System.Drawing.Point(6, 6)
        Me.pctFigura1.Name = "pctFigura1"
        Me.pctFigura1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctFigura1.Size = New System.Drawing.Size(32, 32)
        Me.pctFigura1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctFigura1.TabIndex = 97
        Me.pctFigura1.TabStop = False
        '
        'grpGrupo1
        '
        Me.grpGrupo1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpGrupo1.Controls.Add(Me.Label11)
        Me.grpGrupo1.Controls.Add(Me.Label10)
        Me.grpGrupo1.Controls.Add(Me.Label9)
        Me.grpGrupo1.Controls.Add(Me.Label8)
        Me.grpGrupo1.Controls.Add(Me.txtArea)
        Me.grpGrupo1.Controls.Add(Me.txtIntervalo)
        Me.grpGrupo1.Controls.Add(Me.lblLabel3)
        Me.grpGrupo1.Controls.Add(Me.lblLabel2)
        Me.grpGrupo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpGrupo1.Location = New System.Drawing.Point(6, 44)
        Me.grpGrupo1.Name = "grpGrupo1"
        Me.grpGrupo1.Padding = New System.Windows.Forms.Padding(0)
        Me.grpGrupo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpGrupo1.Size = New System.Drawing.Size(444, 154)
        Me.grpGrupo1.TabIndex = 109
        Me.grpGrupo1.TabStop = False
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel2.Location = New System.Drawing.Point(40, 19)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel2.Size = New System.Drawing.Size(338, 13)
        Me.lblLabel2.TabIndex = 95
        Me.lblLabel2.Text = "Intervalo de tempo para aquisição de dados do ensaio de penetração:"
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel3.Location = New System.Drawing.Point(3, 95)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel3.Size = New System.Drawing.Size(414, 13)
        Me.lblLabel3.TabIndex = 96
        Me.lblLabel3.Text = "Determinar a área do pistão para realizar o cálculo da pressão sobre o corpo de p" &
    "rova."
        '
        'txtIntervalo
        '
        Me.txtIntervalo.AcceptsReturn = True
        Me.txtIntervalo.BackColor = System.Drawing.SystemColors.Window
        Me.txtIntervalo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIntervalo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIntervalo.Location = New System.Drawing.Point(187, 39)
        Me.txtIntervalo.MaxLength = 7
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIntervalo.Size = New System.Drawing.Size(51, 20)
        Me.txtIntervalo.TabIndex = 0
        Me.txtIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtArea
        '
        Me.txtArea.AcceptsReturn = True
        Me.txtArea.BackColor = System.Drawing.Color.White
        Me.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtArea.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtArea.Location = New System.Drawing.Point(187, 116)
        Me.txtArea.MaxLength = 5
        Me.txtArea.Name = "txtArea"
        Me.txtArea.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtArea.Size = New System.Drawing.Size(51, 20)
        Me.txtArea.TabIndex = 1
        Me.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(151, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Valor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(241, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "(ms)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(151, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Valor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(241, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "(cm²)"
        '
        'tbcControl1
        '
        Me.tbcControl1.Controls.Add(Me.tbpPagina1)
        Me.tbcControl1.Controls.Add(Me.TabPage1)
        Me.tbcControl1.Location = New System.Drawing.Point(10, 12)
        Me.tbcControl1.Name = "tbcControl1"
        Me.tbcControl1.SelectedIndex = 0
        Me.tbcControl1.Size = New System.Drawing.Size(464, 240)
        Me.tbcControl1.TabIndex = 110
        '
        'frmConfigurarEnsaio
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(486, 293)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.tbcControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigurarEnsaio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração do Ensaio"
        Me.TabPage1.ResumeLayout(False)
        Me.tbpPagina1.ResumeLayout(False)
        Me.tbpPagina1.PerformLayout()
        CType(Me.pctFigura1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGrupo1.ResumeLayout(False)
        Me.grpGrupo1.PerformLayout()
        Me.tbcControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnModoSimulacao As Button
    Friend WithEvents btnParametrizacaoFabricante As Button
    Friend WithEvents tbpPagina1 As TabPage
    Public WithEvents grpGrupo1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents txtArea As TextBox
    Public WithEvents txtIntervalo As TextBox
    Public WithEvents lblLabel3 As Label
    Public WithEvents lblLabel2 As Label
    Public WithEvents pctFigura1 As PictureBox
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents tbcControl1 As TabControl
End Class
