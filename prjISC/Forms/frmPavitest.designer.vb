<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPavitest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPavitest))
        Me.grpGroup = New System.Windows.Forms.GroupBox()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.lblLabel5 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpGroup.SuspendLayout()
        Me.pnlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpGroup
        '
        Me.grpGroup.Controls.Add(Me.pnlPanel)
        Me.grpGroup.Controls.Add(Me.lblLabel5)
        Me.grpGroup.Location = New System.Drawing.Point(12, 7)
        Me.grpGroup.Name = "grpGroup"
        Me.grpGroup.Size = New System.Drawing.Size(344, 229)
        Me.grpGroup.TabIndex = 17
        Me.grpGroup.TabStop = False
        '
        'pnlPanel
        '
        Me.pnlPanel.BackColor = System.Drawing.Color.White
        Me.pnlPanel.BackgroundImage = CType(resources.GetObject("pnlPanel.BackgroundImage"), System.Drawing.Image)
        Me.pnlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPanel.Controls.Add(Me.lblVersao)
        Me.pnlPanel.Controls.Add(Me.lblLabel4)
        Me.pnlPanel.Controls.Add(Me.lblLabel3)
        Me.pnlPanel.Location = New System.Drawing.Point(10, 19)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(315, 91)
        Me.pnlPanel.TabIndex = 18
        '
        'lblVersao
        '
        Me.lblVersao.AutoSize = True
        Me.lblVersao.BackColor = System.Drawing.Color.White
        Me.lblVersao.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersao.Location = New System.Drawing.Point(76, 18)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(191, 14)
        Me.lblVersao.TabIndex = 1
        Me.lblVersao.Text = "Pavitest CBR (ISC) - 3.8B.BK.EF-00.04"
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.BackColor = System.Drawing.Color.White
        Me.lblLabel4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel4.Location = New System.Drawing.Point(2, 69)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(151, 14)
        Me.lblLabel4.TabIndex = 3
        Me.lblLabel4.Text = "Todos os direitos reservados."
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.BackColor = System.Drawing.Color.White
        Me.lblLabel3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel3.Location = New System.Drawing.Point(2, 56)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(228, 14)
        Me.lblLabel3.TabIndex = 2
        Me.lblLabel3.Text = "Copyright® 2026 - Contenco Ind. && Com. Ltda."
        '
        'lblLabel5
        '
        Me.lblLabel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel5.Location = New System.Drawing.Point(11, 118)
        Me.lblLabel5.Name = "lblLabel5"
        Me.lblLabel5.Size = New System.Drawing.Size(302, 99)
        Me.lblLabel5.TabIndex = 10
        Me.lblLabel5.Text = resources.GetString("lblLabel5.Text")
        Me.lblLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(256, 242)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmPavitest
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(368, 276)
        Me.Controls.Add(Me.grpGroup)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPavitest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informações Pavitest"
        Me.grpGroup.ResumeLayout(False)
        Me.pnlPanel.ResumeLayout(False)
        Me.pnlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpGroup As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabel5 As System.Windows.Forms.Label
    Friend WithEvents pnlPanel As Panel
    Friend WithEvents lblVersao As Label
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents lblLabel3 As Label
End Class
