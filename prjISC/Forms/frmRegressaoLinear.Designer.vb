<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegressaoLinear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegressaoLinear))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpRegressao = New System.Windows.Forms.GroupBox()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblISC1_legenda = New System.Windows.Forms.Label()
        Me.lblISC1 = New System.Windows.Forms.Label()
        Me.lblISC2_legenda = New System.Windows.Forms.Label()
        Me.lblISC2 = New System.Windows.Forms.Label()
        Me.grpRegressao.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.Enabled = False
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(195, 172)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 186
        Me.btnOk.Text = "   &Sair"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpRegressao
        '
        Me.grpRegressao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpRegressao.Controls.Add(Me.txtY2)
        Me.grpRegressao.Controls.Add(Me.Label3)
        Me.grpRegressao.Controls.Add(Me.txtY1)
        Me.grpRegressao.Controls.Add(Me.Label2)
        Me.grpRegressao.Location = New System.Drawing.Point(12, 14)
        Me.grpRegressao.Name = "grpRegressao"
        Me.grpRegressao.Size = New System.Drawing.Size(174, 122)
        Me.grpRegressao.TabIndex = 152
        Me.grpRegressao.TabStop = False
        Me.grpRegressao.Text = "Regressão Linear"
        '
        'txtY2
        '
        Me.txtY2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtY2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY2.ForeColor = System.Drawing.Color.Black
        Me.txtY2.Location = New System.Drawing.Point(51, 75)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(87, 26)
        Me.txtY2.TabIndex = 8
        Me.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Y2:"
        '
        'txtY1
        '
        Me.txtY1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtY1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY1.ForeColor = System.Drawing.Color.Black
        Me.txtY1.Location = New System.Drawing.Point(51, 28)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(87, 26)
        Me.txtY1.TabIndex = 5
        Me.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Y1:"
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(192, 89)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 27)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Re&set"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(192, 45)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(84, 27)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblISC1_legenda
        '
        Me.lblISC1_legenda.AutoSize = True
        Me.lblISC1_legenda.Location = New System.Drawing.Point(12, 139)
        Me.lblISC1_legenda.Name = "lblISC1_legenda"
        Me.lblISC1_legenda.Size = New System.Drawing.Size(50, 13)
        Me.lblISC1_legenda.TabIndex = 189
        Me.lblISC1_legenda.Text = "ISC 1(%):"
        '
        'lblISC1
        '
        Me.lblISC1.AutoSize = True
        Me.lblISC1.Location = New System.Drawing.Point(62, 139)
        Me.lblISC1.Name = "lblISC1"
        Me.lblISC1.Size = New System.Drawing.Size(19, 13)
        Me.lblISC1.TabIndex = 189
        Me.lblISC1.Text = "----"
        '
        'lblISC2_legenda
        '
        Me.lblISC2_legenda.AutoSize = True
        Me.lblISC2_legenda.Location = New System.Drawing.Point(111, 139)
        Me.lblISC2_legenda.Name = "lblISC2_legenda"
        Me.lblISC2_legenda.Size = New System.Drawing.Size(50, 13)
        Me.lblISC2_legenda.TabIndex = 189
        Me.lblISC2_legenda.Text = "ISC 2(%):"
        '
        'lblISC2
        '
        Me.lblISC2.AutoSize = True
        Me.lblISC2.Location = New System.Drawing.Point(163, 139)
        Me.lblISC2.Name = "lblISC2"
        Me.lblISC2.Size = New System.Drawing.Size(19, 13)
        Me.lblISC2.TabIndex = 189
        Me.lblISC2.Text = "----"
        '
        'frmRegressaoLinear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 203)
        Me.Controls.Add(Me.lblISC2)
        Me.Controls.Add(Me.lblISC2_legenda)
        Me.Controls.Add(Me.lblISC1)
        Me.Controls.Add(Me.lblISC1_legenda)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grpRegressao)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegressaoLinear"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regressão Linear - Correção de Inflexão"
        Me.grpRegressao.ResumeLayout(False)
        Me.grpRegressao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpRegressao As System.Windows.Forms.GroupBox
    Friend WithEvents txtY2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtY1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents lblISC1_legenda As Label
    Friend WithEvents lblISC1 As Label
    Friend WithEvents lblISC2_legenda As Label
    Friend WithEvents lblISC2 As Label
End Class
