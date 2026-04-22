<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApresentacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApresentacao))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-20, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 35)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Pavitest CBR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVersao
        '
        Me.lblVersao.BackColor = System.Drawing.Color.Transparent
        Me.lblVersao.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblVersao.Location = New System.Drawing.Point(8, 193)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(265, 35)
        Me.lblVersao.TabIndex = 74
        Me.lblVersao.Text = "Índice de Suporte Califórnia (ISC)"
        Me.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmApresentacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(581, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmApresentacao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bem Vindo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVersao As System.Windows.Forms.Label
End Class
