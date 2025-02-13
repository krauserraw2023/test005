Namespace Registro.DocumentoDigital
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscVisorArchDigital
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscVisorArchDigital))
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.GroupBox10 = New System.Windows.Forms.GroupBox()
            Me.rdbPenologica = New System.Windows.Forms.RadioButton()
            Me.rdbKardex = New System.Windows.Forms.RadioButton()
            Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
            Me.txtUrl = New System.Windows.Forms.TextBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.dgvDocDigitalizado = New System.Windows.Forms.DataGridView()
            Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nom_arch = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tip_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_archivador = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_gaveta = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_fic = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Panel8.SuspendLayout()
            Me.GroupBox10.SuspendLayout()
            CType(Me.dgvDocDigitalizado, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel8
            '
            Me.Panel8.BackColor = System.Drawing.SystemColors.Control
            Me.Panel8.Controls.Add(Me.GroupBox10)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel8.Location = New System.Drawing.Point(0, 0)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(966, 43)
            Me.Panel8.TabIndex = 2
            '
            'GroupBox10
            '
            Me.GroupBox10.Controls.Add(Me.rdbPenologica)
            Me.GroupBox10.Controls.Add(Me.rdbKardex)
            Me.GroupBox10.Location = New System.Drawing.Point(3, 1)
            Me.GroupBox10.Name = "GroupBox10"
            Me.GroupBox10.Size = New System.Drawing.Size(267, 38)
            Me.GroupBox10.TabIndex = 6
            Me.GroupBox10.TabStop = False
            Me.GroupBox10.Text = "Referencia búsqueda"
            '
            'rdbPenologica
            '
            Me.rdbPenologica.AutoSize = True
            Me.rdbPenologica.Location = New System.Drawing.Point(143, 15)
            Me.rdbPenologica.Name = "rdbPenologica"
            Me.rdbPenologica.Size = New System.Drawing.Size(106, 17)
            Me.rdbPenologica.TabIndex = 1
            Me.rdbPenologica.Text = "Ficha penológica"
            Me.rdbPenologica.UseVisualStyleBackColor = True
            '
            'rdbKardex
            '
            Me.rdbKardex.AutoSize = True
            Me.rdbKardex.Checked = True
            Me.rdbKardex.Location = New System.Drawing.Point(36, 15)
            Me.rdbKardex.Name = "rdbKardex"
            Me.rdbKardex.Size = New System.Drawing.Size(86, 17)
            Me.rdbKardex.TabIndex = 0
            Me.rdbKardex.TabStop = True
            Me.rdbKardex.Text = "Ficha kardex"
            Me.rdbKardex.UseVisualStyleBackColor = True
            '
            'ProgressBar1
            '
            Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.ProgressBar1.Location = New System.Drawing.Point(0, 565)
            Me.ProgressBar1.Name = "ProgressBar1"
            Me.ProgressBar1.Size = New System.Drawing.Size(966, 16)
            Me.ProgressBar1.TabIndex = 8
            '
            'txtUrl
            '
            Me.txtUrl.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.txtUrl.Location = New System.Drawing.Point(0, 581)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(966, 20)
            Me.txtUrl.TabIndex = 10
            Me.txtUrl.Visible = False
            '
            'dgvDocDigitalizado
            '
            Me.dgvDocDigitalizado.AllowUserToAddRows = False
            Me.dgvDocDigitalizado.AllowUserToDeleteRows = False
            Me.dgvDocDigitalizado.BackgroundColor = System.Drawing.Color.White
            Me.dgvDocDigitalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDocDigitalizado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nom_arch, Me.tip_reg, Me.ape, Me.nom, Me.col_archivador, Me.col_gaveta, Me.col_num_fic, Me.col_btn})
            Me.dgvDocDigitalizado.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDocDigitalizado.Location = New System.Drawing.Point(0, 43)
            Me.dgvDocDigitalizado.MultiSelect = False
            Me.dgvDocDigitalizado.Name = "dgvDocDigitalizado"
            Me.dgvDocDigitalizado.ReadOnly = True
            Me.dgvDocDigitalizado.RowTemplate.Height = 32
            Me.dgvDocDigitalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDocDigitalizado.Size = New System.Drawing.Size(966, 522)
            Me.dgvDocDigitalizado.TabIndex = 11
            '
            'id
            '
            Me.id.DataPropertyName = "id"
            Me.id.HeaderText = "id"
            Me.id.Name = "id"
            Me.id.ReadOnly = True
            Me.id.Visible = False
            '
            'nom_arch
            '
            Me.nom_arch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.nom_arch.DataPropertyName = "NomArchivo"
            Me.nom_arch.HeaderText = "Nombre de Archivo"
            Me.nom_arch.Name = "nom_arch"
            Me.nom_arch.ReadOnly = True
            '
            'tip_reg
            '
            Me.tip_reg.DataPropertyName = "TipoRegistro"
            Me.tip_reg.HeaderText = "Tipo de Registro"
            Me.tip_reg.Name = "tip_reg"
            Me.tip_reg.ReadOnly = True
            Me.tip_reg.Width = 250
            '
            'ape
            '
            Me.ape.DataPropertyName = "Apellido"
            Me.ape.HeaderText = "Apellidos"
            Me.ape.Name = "ape"
            Me.ape.ReadOnly = True
            Me.ape.Width = 230
            '
            'nom
            '
            Me.nom.DataPropertyName = "Nombre"
            Me.nom.HeaderText = "Nombres"
            Me.nom.Name = "nom"
            Me.nom.ReadOnly = True
            Me.nom.Width = 230
            '
            'col_archivador
            '
            Me.col_archivador.DataPropertyName = "NumArchivador"
            Me.col_archivador.HeaderText = "Archivador / Libro"
            Me.col_archivador.Name = "col_archivador"
            Me.col_archivador.ReadOnly = True
            '
            'col_gaveta
            '
            Me.col_gaveta.DataPropertyName = "NumGaveta"
            Me.col_gaveta.HeaderText = "Gaveta / Folio"
            Me.col_gaveta.Name = "col_gaveta"
            Me.col_gaveta.ReadOnly = True
            '
            'col_num_fic
            '
            Me.col_num_fic.DataPropertyName = "NumFicha"
            Me.col_num_fic.HeaderText = "Nro. Ficha / Expediente"
            Me.col_num_fic.Name = "col_num_fic"
            Me.col_num_fic.ReadOnly = True
            '
            'col_btn
            '
            Me.col_btn.HeaderText = "---"
            Me.col_btn.Image = CType(resources.GetObject("col_btn.Image"), System.Drawing.Image)
            Me.col_btn.Name = "col_btn"
            Me.col_btn.ReadOnly = True
            Me.col_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_btn.Width = 50
            '
            'uscVisorArchDigital
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgvDocDigitalizado)
            Me.Controls.Add(Me.ProgressBar1)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.Panel8)
            Me.Name = "uscVisorArchDigital"
            Me.Size = New System.Drawing.Size(966, 601)
            Me.Panel8.ResumeLayout(False)
            Me.GroupBox10.ResumeLayout(False)
            Me.GroupBox10.PerformLayout()
            CType(Me.dgvDocDigitalizado, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbPenologica As System.Windows.Forms.RadioButton
        Friend WithEvents rdbKardex As System.Windows.Forms.RadioButton
        Friend WithEvents txtUrl As System.Windows.Forms.TextBox
        Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents dgvDocDigitalizado As DataGridView
        Friend WithEvents id As DataGridViewTextBoxColumn
        Friend WithEvents nom_arch As DataGridViewTextBoxColumn
        Friend WithEvents tip_reg As DataGridViewTextBoxColumn
        Friend WithEvents ape As DataGridViewTextBoxColumn
        Friend WithEvents nom As DataGridViewTextBoxColumn
        Friend WithEvents col_archivador As DataGridViewTextBoxColumn
        Friend WithEvents col_gaveta As DataGridViewTextBoxColumn
        Friend WithEvents col_num_fic As DataGridViewTextBoxColumn
        Friend WithEvents col_btn As DataGridViewImageColumn
    End Class
End Namespace