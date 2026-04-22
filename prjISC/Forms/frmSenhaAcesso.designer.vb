<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSenhaAcesso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSenhaAcesso))
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.grbGroup = New System.Windows.Forms.GroupBox()
        Me.pctFigura = New System.Windows.Forms.PictureBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grbGroup.SuspendLayout()
        CType(Me.pctFigura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel.Location = New System.Drawing.Point(31, 38)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel.Size = New System.Drawing.Size(141, 13)
        Me.lblLabel.TabIndex = 2
        Me.lblLabel.Text = "Senha para trabalhar dados:"
        '
        'grbGroup
        '
        Me.grbGroup.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grbGroup.Controls.Add(Me.pctFigura)
        Me.grbGroup.Controls.Add(Me.txtSenha)
        Me.grbGroup.Controls.Add(Me.lblLabel)
        Me.grbGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbGroup.Location = New System.Drawing.Point(11, 11)
        Me.grbGroup.Name = "grbGroup"
        Me.grbGroup.Padding = New System.Windows.Forms.Padding(0)
        Me.grbGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grbGroup.Size = New System.Drawing.Size(276, 87)
        Me.grbGroup.TabIndex = 5
        Me.grbGroup.TabStop = False
        '
        'pctFigura
        '
        Me.pctFigura.Image = CType(resources.GetObject("pctFigura.Image"), System.Drawing.Image)
        Me.pctFigura.Location = New System.Drawing.Point(7, 16)
        Me.pctFigura.Name = "pctFigura"
        Me.pctFigura.Size = New System.Drawing.Size(24, 25)
        Me.pctFigura.TabIndex = 6
        Me.pctFigura.TabStop = False
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(178, 35)
        Me.txtSenha.MaxLength = 10
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(88, 21)
        Me.txtSenha.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(120, 109)
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
        Me.btnCancelar.Location = New System.Drawing.Point(207, 109)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Padding = New System.Windows.Forms.Padding(4, 0, 2, 0)
        Me.btnCancelar.Size = New System.Drawing.Size(81, 26)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmSenhaAcesso
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(298, 142)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grbGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(314, 181)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(314, 181)
        Me.Name = "frmSenhaAcesso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Senha"
        Me.grbGroup.ResumeLayout(False)
        Me.grbGroup.PerformLayout()
        CType(Me.pctFigura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblLabel As System.Windows.Forms.Label
    Public WithEvents grbGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents pctFigura As System.Windows.Forms.PictureBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
