<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cryViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'cryViewer
        '
        Me.cryViewer.ActiveViewIndex = -1
        Me.cryViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cryViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.cryViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cryViewer.Location = New System.Drawing.Point(0, 0)
        Me.cryViewer.Name = "cryViewer"
        Me.cryViewer.SelectionFormula = ""
        Me.cryViewer.Size = New System.Drawing.Size(1362, 694)
        Me.cryViewer.TabIndex = 0
        Me.cryViewer.ViewTimeSelectionFormula = ""
        '
        'frmRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 694)
        Me.Controls.Add(Me.cryViewer)
        Me.Name = "frmRelatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Relatório"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cryViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
