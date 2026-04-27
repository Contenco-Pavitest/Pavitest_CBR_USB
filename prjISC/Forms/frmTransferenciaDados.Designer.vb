<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferenciaDados
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferenciaDados))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBancoDestino = New System.Windows.Forms.Button()
        Me.btnBancoOrigem = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReplicarDados = New System.Windows.Forms.Button()
        Me.txtCaminhoOrigem = New System.Windows.Forms.TextBox()
        Me.txtCaminhoDestino = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 26)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Transfere todos os cilindros cadastrados do banco de origem " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para o banco de des" &
    "tino."
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(230, 240)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 188
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBancoDestino)
        Me.GroupBox1.Controls.Add(Me.btnBancoOrigem)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnReplicarDados)
        Me.GroupBox1.Controls.Add(Me.txtCaminhoOrigem)
        Me.GroupBox1.Controls.Add(Me.txtCaminhoDestino)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 189)
        Me.GroupBox1.TabIndex = 187
        Me.GroupBox1.TabStop = False
        '
        'btnBancoDestino
        '
        Me.btnBancoDestino.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBancoDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBancoDestino.Image = CType(resources.GetObject("btnBancoDestino.Image"), System.Drawing.Image)
        Me.btnBancoDestino.Location = New System.Drawing.Point(237, 35)
        Me.btnBancoDestino.Name = "btnBancoDestino"
        Me.btnBancoDestino.Size = New System.Drawing.Size(36, 23)
        Me.btnBancoDestino.TabIndex = 75
        Me.btnBancoDestino.UseVisualStyleBackColor = True
        '
        'btnBancoOrigem
        '
        Me.btnBancoOrigem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBancoOrigem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBancoOrigem.Image = CType(resources.GetObject("btnBancoOrigem.Image"), System.Drawing.Image)
        Me.btnBancoOrigem.Location = New System.Drawing.Point(237, 96)
        Me.btnBancoOrigem.Name = "btnBancoOrigem"
        Me.btnBancoOrigem.Size = New System.Drawing.Size(36, 23)
        Me.btnBancoOrigem.TabIndex = 74
        Me.btnBancoOrigem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Caminho do banco origem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Caminho do banco destino:"
        '
        'btnReplicarDados
        '
        Me.btnReplicarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReplicarDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplicarDados.Image = CType(resources.GetObject("btnReplicarDados.Image"), System.Drawing.Image)
        Me.btnReplicarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReplicarDados.Location = New System.Drawing.Point(66, 143)
        Me.btnReplicarDados.Name = "btnReplicarDados"
        Me.btnReplicarDados.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.btnReplicarDados.Size = New System.Drawing.Size(91, 26)
        Me.btnReplicarDados.TabIndex = 71
        Me.btnReplicarDados.Text = "Transferir"
        Me.btnReplicarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReplicarDados.UseVisualStyleBackColor = True
        '
        'txtCaminhoOrigem
        '
        Me.txtCaminhoOrigem.Location = New System.Drawing.Point(21, 97)
        Me.txtCaminhoOrigem.Name = "txtCaminhoOrigem"
        Me.txtCaminhoOrigem.ReadOnly = True
        Me.txtCaminhoOrigem.Size = New System.Drawing.Size(210, 20)
        Me.txtCaminhoOrigem.TabIndex = 70
        '
        'txtCaminhoDestino
        '
        Me.txtCaminhoDestino.Location = New System.Drawing.Point(21, 36)
        Me.txtCaminhoDestino.Name = "txtCaminhoDestino"
        Me.txtCaminhoDestino.ReadOnly = True
        Me.txtCaminhoDestino.Size = New System.Drawing.Size(210, 20)
        Me.txtCaminhoDestino.TabIndex = 69
        '
        'frmTransferenciaDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 280)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransferenciaDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferência  Cilindro "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBancoDestino As Button
    Friend WithEvents btnBancoOrigem As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReplicarDados As Button
    Friend WithEvents txtCaminhoOrigem As TextBox
    Friend WithEvents txtCaminhoDestino As TextBox
End Class
