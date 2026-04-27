<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCilindro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCilindro))
        Me.bdnNavegator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bdnSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsbCountCilindro = New System.Windows.Forms.ToolStripLabel()
        Me.tsbMoverFirstCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbMoverPreviousCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPositionCilindro = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMoverNextCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbMoverLastCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAddCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsbSaveCilindro = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelCilindro = New System.Windows.Forms.ToolStripButton()
        Me.pnlPanel = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.grpCilindro = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblLabel16 = New System.Windows.Forms.Label()
        Me.lblLabel9 = New System.Windows.Forms.Label()
        Me.lblLabel8 = New System.Windows.Forms.Label()
        Me.lblLabel10 = New System.Windows.Forms.Label()
        Me.lblLabel15 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtIdCilindro = New System.Windows.Forms.TextBox()
        Me.btnTransferir = New System.Windows.Forms.Button()
        CType(Me.bdnNavegator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnNavegator.SuspendLayout()
        CType(Me.bdnSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPanel.SuspendLayout()
        Me.grpCilindro.SuspendLayout()
        Me.SuspendLayout()
        '
        'bdnNavegator
        '
        Me.bdnNavegator.AddNewItem = Nothing
        Me.bdnNavegator.AutoSize = False
        Me.bdnNavegator.BackColor = System.Drawing.Color.Transparent
        Me.bdnNavegator.BindingSource = Me.bdnSource
        Me.bdnNavegator.CountItem = Me.tsbCountCilindro
        Me.bdnNavegator.DeleteItem = Nothing
        Me.bdnNavegator.Dock = System.Windows.Forms.DockStyle.None
        Me.bdnNavegator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbMoverFirstCilindro, Me.tsbMoverPreviousCilindro, Me.tsbSeparator1, Me.tsbPositionCilindro, Me.tsbCountCilindro, Me.tsbSeparator2, Me.tsbMoverNextCilindro, Me.tsbMoverLastCilindro, Me.tsbSeparator3, Me.tsbAddCilindro, Me.tsbEditCilindro, Me.tsbDelete, Me.tsbSaveCilindro, Me.tsbCancelCilindro})
        Me.bdnNavegator.Location = New System.Drawing.Point(0, 3)
        Me.bdnNavegator.MoveFirstItem = Me.tsbMoverFirstCilindro
        Me.bdnNavegator.MoveLastItem = Me.tsbMoverLastCilindro
        Me.bdnNavegator.MoveNextItem = Me.tsbMoverNextCilindro
        Me.bdnNavegator.MovePreviousItem = Me.tsbMoverPreviousCilindro
        Me.bdnNavegator.Name = "bdnNavegator"
        Me.bdnNavegator.PositionItem = Me.tsbPositionCilindro
        Me.bdnNavegator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.bdnNavegator.Size = New System.Drawing.Size(345, 27)
        Me.bdnNavegator.TabIndex = 182
        '
        'tsbCountCilindro
        '
        Me.tsbCountCilindro.Name = "tsbCountCilindro"
        Me.tsbCountCilindro.Size = New System.Drawing.Size(37, 24)
        Me.tsbCountCilindro.Text = "de {0}"
        Me.tsbCountCilindro.ToolTipText = "Total number of items"
        '
        'tsbMoverFirstCilindro
        '
        Me.tsbMoverFirstCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverFirstCilindro.Image = CType(resources.GetObject("tsbMoverFirstCilindro.Image"), System.Drawing.Image)
        Me.tsbMoverFirstCilindro.Name = "tsbMoverFirstCilindro"
        Me.tsbMoverFirstCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbMoverFirstCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbMoverFirstCilindro.Text = "Move first"
        '
        'tsbMoverPreviousCilindro
        '
        Me.tsbMoverPreviousCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverPreviousCilindro.Image = CType(resources.GetObject("tsbMoverPreviousCilindro.Image"), System.Drawing.Image)
        Me.tsbMoverPreviousCilindro.Name = "tsbMoverPreviousCilindro"
        Me.tsbMoverPreviousCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbMoverPreviousCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbMoverPreviousCilindro.Text = "Move previous"
        '
        'tsbSeparator1
        '
        Me.tsbSeparator1.Name = "tsbSeparator1"
        Me.tsbSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbPositionCilindro
        '
        Me.tsbPositionCilindro.AccessibleName = "Position"
        Me.tsbPositionCilindro.AutoSize = False
        Me.tsbPositionCilindro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tsbPositionCilindro.Name = "tsbPositionCilindro"
        Me.tsbPositionCilindro.Size = New System.Drawing.Size(50, 21)
        Me.tsbPositionCilindro.Text = "0"
        Me.tsbPositionCilindro.ToolTipText = "Current position"
        '
        'tsbSeparator2
        '
        Me.tsbSeparator2.Name = "tsbSeparator2"
        Me.tsbSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbMoverNextCilindro
        '
        Me.tsbMoverNextCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverNextCilindro.Image = CType(resources.GetObject("tsbMoverNextCilindro.Image"), System.Drawing.Image)
        Me.tsbMoverNextCilindro.Name = "tsbMoverNextCilindro"
        Me.tsbMoverNextCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbMoverNextCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbMoverNextCilindro.Text = "Move next"
        '
        'tsbMoverLastCilindro
        '
        Me.tsbMoverLastCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMoverLastCilindro.Image = CType(resources.GetObject("tsbMoverLastCilindro.Image"), System.Drawing.Image)
        Me.tsbMoverLastCilindro.Name = "tsbMoverLastCilindro"
        Me.tsbMoverLastCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbMoverLastCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbMoverLastCilindro.Text = "Move last"
        '
        'tsbSeparator3
        '
        Me.tsbSeparator3.Name = "tsbSeparator3"
        Me.tsbSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsbAddCilindro
        '
        Me.tsbAddCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddCilindro.Image = CType(resources.GetObject("tsbAddCilindro.Image"), System.Drawing.Image)
        Me.tsbAddCilindro.Name = "tsbAddCilindro"
        Me.tsbAddCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbAddCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbAddCilindro.Text = "Adicionar"
        '
        'tsbEditCilindro
        '
        Me.tsbEditCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditCilindro.Image = CType(resources.GetObject("tsbEditCilindro.Image"), System.Drawing.Image)
        Me.tsbEditCilindro.ImageTransparentColor = System.Drawing.Color.White
        Me.tsbEditCilindro.Name = "tsbEditCilindro"
        Me.tsbEditCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbEditCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbEditCilindro.Text = "Editar"
        '
        'tsbDelete
        '
        Me.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.RightToLeftAutoMirrorImage = True
        Me.tsbDelete.Size = New System.Drawing.Size(23, 24)
        Me.tsbDelete.Text = "Apagar"
        '
        'tsbSaveCilindro
        '
        Me.tsbSaveCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSaveCilindro.Image = CType(resources.GetObject("tsbSaveCilindro.Image"), System.Drawing.Image)
        Me.tsbSaveCilindro.Name = "tsbSaveCilindro"
        Me.tsbSaveCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbSaveCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbSaveCilindro.Text = "Salvar"
        '
        'tsbCancelCilindro
        '
        Me.tsbCancelCilindro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelCilindro.Image = CType(resources.GetObject("tsbCancelCilindro.Image"), System.Drawing.Image)
        Me.tsbCancelCilindro.ImageTransparentColor = System.Drawing.Color.White
        Me.tsbCancelCilindro.Name = "tsbCancelCilindro"
        Me.tsbCancelCilindro.RightToLeftAutoMirrorImage = True
        Me.tsbCancelCilindro.Size = New System.Drawing.Size(23, 24)
        Me.tsbCancelCilindro.Text = "Cancelar"
        '
        'pnlPanel
        '
        Me.pnlPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPanel.Controls.Add(Me.bdnNavegator)
        Me.pnlPanel.Location = New System.Drawing.Point(-9, 193)
        Me.pnlPanel.Name = "pnlPanel"
        Me.pnlPanel.Size = New System.Drawing.Size(345, 35)
        Me.pnlPanel.TabIndex = 183
        '
        'btnOk
        '
        Me.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(237, 231)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.btnOk.Size = New System.Drawing.Size(81, 26)
        Me.btnOk.TabIndex = 184
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'grpCilindro
        '
        Me.grpCilindro.Controls.Add(Me.Label1)
        Me.grpCilindro.Controls.Add(Me.Label2)
        Me.grpCilindro.Controls.Add(Me.txtNome)
        Me.grpCilindro.Controls.Add(Me.lblLabel16)
        Me.grpCilindro.Controls.Add(Me.lblLabel9)
        Me.grpCilindro.Controls.Add(Me.lblLabel8)
        Me.grpCilindro.Controls.Add(Me.lblLabel10)
        Me.grpCilindro.Controls.Add(Me.lblLabel15)
        Me.grpCilindro.Controls.Add(Me.txtPeso)
        Me.grpCilindro.Controls.Add(Me.txtVolume)
        Me.grpCilindro.Controls.Add(Me.txtAltura)
        Me.grpCilindro.Controls.Add(Me.txtIdCilindro)
        Me.grpCilindro.Location = New System.Drawing.Point(10, 2)
        Me.grpCilindro.Name = "grpCilindro"
        Me.grpCilindro.Size = New System.Drawing.Size(305, 185)
        Me.grpCilindro.TabIndex = 185
        Me.grpCilindro.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(223, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "(mm)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(40, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 255
        Me.Label2.Text = "Altura:"
        '
        'txtNome
        '
        Me.txtNome.AcceptsReturn = True
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome.Location = New System.Drawing.Point(137, 40)
        Me.txtNome.MaxLength = 0
        Me.txtNome.Name = "txtNome"
        Me.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNome.Size = New System.Drawing.Size(116, 20)
        Me.txtNome.TabIndex = 0
        Me.txtNome.Tag = "1"
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLabel16
        '
        Me.lblLabel16.AutoSize = True
        Me.lblLabel16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel16.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel16.Location = New System.Drawing.Point(223, 95)
        Me.lblLabel16.Name = "lblLabel16"
        Me.lblLabel16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel16.Size = New System.Drawing.Size(30, 13)
        Me.lblLabel16.TabIndex = 253
        Me.lblLabel16.Text = "(cm³)"
        '
        'lblLabel9
        '
        Me.lblLabel9.AutoSize = True
        Me.lblLabel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel9.Location = New System.Drawing.Point(40, 69)
        Me.lblLabel9.Name = "lblLabel9"
        Me.lblLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel9.Size = New System.Drawing.Size(34, 13)
        Me.lblLabel9.TabIndex = 252
        Me.lblLabel9.Text = "Peso:"
        '
        'lblLabel8
        '
        Me.lblLabel8.AutoSize = True
        Me.lblLabel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel8.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel8.Location = New System.Drawing.Point(40, 43)
        Me.lblLabel8.Name = "lblLabel8"
        Me.lblLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel8.Size = New System.Drawing.Size(38, 13)
        Me.lblLabel8.TabIndex = 249
        Me.lblLabel8.Text = "Nome:"
        '
        'lblLabel10
        '
        Me.lblLabel10.AutoSize = True
        Me.lblLabel10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel10.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel10.Location = New System.Drawing.Point(40, 95)
        Me.lblLabel10.Name = "lblLabel10"
        Me.lblLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel10.Size = New System.Drawing.Size(45, 13)
        Me.lblLabel10.TabIndex = 251
        Me.lblLabel10.Text = "Volume:"
        '
        'lblLabel15
        '
        Me.lblLabel15.AutoSize = True
        Me.lblLabel15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLabel15.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLabel15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLabel15.Location = New System.Drawing.Point(223, 69)
        Me.lblLabel15.Name = "lblLabel15"
        Me.lblLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLabel15.Size = New System.Drawing.Size(19, 13)
        Me.lblLabel15.TabIndex = 250
        Me.lblLabel15.Text = "(g)"
        '
        'txtPeso
        '
        Me.txtPeso.AcceptsReturn = True
        Me.txtPeso.BackColor = System.Drawing.Color.White
        Me.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPeso.Location = New System.Drawing.Point(137, 66)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(80, 20)
        Me.txtPeso.TabIndex = 1
        Me.txtPeso.Tag = "1"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolume
        '
        Me.txtVolume.AcceptsReturn = True
        Me.txtVolume.BackColor = System.Drawing.Color.White
        Me.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVolume.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVolume.Location = New System.Drawing.Point(137, 92)
        Me.txtVolume.MaxLength = 0
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVolume.Size = New System.Drawing.Size(80, 20)
        Me.txtVolume.TabIndex = 2
        Me.txtVolume.Tag = "1"
        Me.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAltura
        '
        Me.txtAltura.AcceptsReturn = True
        Me.txtAltura.BackColor = System.Drawing.Color.White
        Me.txtAltura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAltura.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAltura.Location = New System.Drawing.Point(137, 119)
        Me.txtAltura.MaxLength = 0
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAltura.Size = New System.Drawing.Size(80, 20)
        Me.txtAltura.TabIndex = 3
        Me.txtAltura.Tag = "1"
        Me.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIdCilindro
        '
        Me.txtIdCilindro.AcceptsReturn = True
        Me.txtIdCilindro.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdCilindro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdCilindro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdCilindro.Location = New System.Drawing.Point(166, 119)
        Me.txtIdCilindro.MaxLength = 0
        Me.txtIdCilindro.Name = "txtIdCilindro"
        Me.txtIdCilindro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIdCilindro.Size = New System.Drawing.Size(51, 20)
        Me.txtIdCilindro.TabIndex = 257
        Me.txtIdCilindro.Tag = "1"
        Me.txtIdCilindro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnTransferir
        '
        Me.btnTransferir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTransferir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferir.Image = CType(resources.GetObject("btnTransferir.Image"), System.Drawing.Image)
        Me.btnTransferir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransferir.Location = New System.Drawing.Point(10, 231)
        Me.btnTransferir.Name = "btnTransferir"
        Me.btnTransferir.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.btnTransferir.Size = New System.Drawing.Size(91, 26)
        Me.btnTransferir.TabIndex = 188
        Me.btnTransferir.Text = "Transferir"
        Me.btnTransferir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTransferir.UseVisualStyleBackColor = True
        '
        'frmCilindro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(325, 262)
        Me.Controls.Add(Me.btnTransferir)
        Me.Controls.Add(Me.pnlPanel)
        Me.Controls.Add(Me.grpCilindro)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCilindro"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro dos cilindros"
        CType(Me.bdnNavegator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnNavegator.ResumeLayout(False)
        Me.bdnNavegator.PerformLayout()
        CType(Me.bdnSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPanel.ResumeLayout(False)
        Me.grpCilindro.ResumeLayout(False)
        Me.grpCilindro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bdnNavegator As System.Windows.Forms.BindingNavigator
    Friend WithEvents tsbCountCilindro As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbMoverFirstCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMoverPreviousCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPositionCilindro As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbMoverNextCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbMoverLastCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbAddCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSaveCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelCilindro As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlPanel As System.Windows.Forms.Panel
    Friend WithEvents bdnSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents grpCilindro As System.Windows.Forms.GroupBox
    Public WithEvents txtAltura As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtPeso As System.Windows.Forms.TextBox
    Public WithEvents txtVolume As System.Windows.Forms.TextBox
    Public WithEvents txtNome As System.Windows.Forms.TextBox
    Public WithEvents lblLabel16 As System.Windows.Forms.Label
    Public WithEvents lblLabel9 As System.Windows.Forms.Label
    Public WithEvents lblLabel8 As System.Windows.Forms.Label
    Public WithEvents lblLabel10 As System.Windows.Forms.Label
    Public WithEvents lblLabel15 As System.Windows.Forms.Label
    Public WithEvents txtIdCilindro As System.Windows.Forms.TextBox
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnTransferir As Button
End Class
