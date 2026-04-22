<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPortaSerial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPortaSerial))
        Me.grbGroup = New System.Windows.Forms.GroupBox
        Me.btnAtualizarLista = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblPortaConectada = New System.Windows.Forms.Label
        Me.pctFigura = New System.Windows.Forms.PictureBox
        Me.lblLabel2 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.grbGroup.SuspendLayout()
        CType(Me.pctFigura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbGroup
        '
        Me.grbGroup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grbGroup.Controls.Add(Me.btnAtualizarLista)
        Me.grbGroup.Controls.Add(Me.ListBox1)
        Me.grbGroup.Controls.Add(Me.Label2)
        Me.grbGroup.Controls.Add(Me.lblPortaConectada)
        Me.grbGroup.Controls.Add(Me.pctFigura)
        Me.grbGroup.Controls.Add(Me.lblLabel2)
        Me.grbGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbGroup.Location = New System.Drawing.Point(13, 7)
        Me.grbGroup.Name = "grbGroup"
        Me.grbGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.grbGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbGroup.Size = New System.Drawing.Size(412, 157)
        Me.grbGroup.TabIndex = 78
        Me.grbGroup.TabStop = False
        '
        'btnAtualizarLista
        '
        Me.btnAtualizarLista.Image = CType(resources.GetObject("btnAtualizarLista.Image"), System.Drawing.Image)
        Me.btnAtualizarLista.Location = New System.Drawing.Point(350, 44)
        Me.btnAtualizarLista.Name = "btnAtualizarLista"
        Me.btnAtualizarLista.Size = New System.Drawing.Size(28, 28)
        Me.btnAtualizarLista.TabIndex = 104
        Me.btnAtualizarLista.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(67, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(277, 49)
        Me.ListBox1.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(66, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(280, 15)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Porta selecionada para conectar ao equipamento:"
        '
        'lblPortaConectada
        '
        Me.lblPortaConectada.AutoSize = True
        Me.lblPortaConectada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortaConectada.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPortaConectada.Location = New System.Drawing.Point(186, 133)
        Me.lblPortaConectada.Name = "lblPortaConectada"
        Me.lblPortaConectada.Size = New System.Drawing.Size(41, 13)
        Me.lblPortaConectada.TabIndex = 102
        Me.lblPortaConectada.Text = "COM1"
        '
        'pctFigura
        '
        Me.pctFigura.BackColor = System.Drawing.Color.Transparent
        Me.pctFigura.Cursor = System.Windows.Forms.Cursors.Default
        Me.pctFigura.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pctFigura.Image = CType(resources.GetObject("pctFigura.Image"), System.Drawing.Image)
        Me.pctFigura.Location = New System.Drawing.Point(19, 22)
        Me.pctFigura.Name = "pctFigura"
        Me.pctFigura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pctFigura.Size = New System.Drawing.Size(35, 35)
        Me.pctFigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctFigura.TabIndex = 101
        Me.pctFigura.TabStop = False
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel2.ForeColor = System.Drawing.Color.Black
        Me.lblLabel2.Location = New System.Drawing.Point(62, 18)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel2.Size = New System.Drawing.Size(289, 15)
        Me.lblLabel2.TabIndex = 91
        Me.lblLabel2.Text = "Portas de comunicação disponíveis no computador:"
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(259, 171)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(344, 171)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmPortaSerial
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(436, 200)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grbGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPortaSerial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Porta de Comunicação"
        Me.TopMost = True
        Me.grbGroup.ResumeLayout(False)
        Me.grbGroup.PerformLayout()
        CType(Me.pctFigura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents grbGroup As System.Windows.Forms.GroupBox
    Public WithEvents pctFigura As System.Windows.Forms.PictureBox
    Public WithEvents lblLabel2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPortaConectada As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnAtualizarLista As System.Windows.Forms.Button
End Class
