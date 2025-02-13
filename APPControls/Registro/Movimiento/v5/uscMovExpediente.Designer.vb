Namespace Registro
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscMovExpediente
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwExpediente = New System.Windows.Forms.DataGridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_DMP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_SMP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mov_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sit_jur_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.sentencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_anulacion = New System.Windows.Forms.DataGridViewImageColumn()
            Me.colEliminarExpediente = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_est_men_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_men_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_exp_inmp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_inmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblRegExp = New System.Windows.Forms.Label()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.Column9, Me.col_sel, Me.col_DMP, Me.col_SMP, Me.col_id, Me.col_mov_id, Me.col_int_id, Me.col_exp_id, Me.col_ing_id, Me.col_exp_numero, Me.Column5, Me.Column8, Me.col_sit_jur_id, Me.Column7, Me.col_exp_fec, Me.col_fec_rec, Me.sentencia, Me.col_exp_anulacion, Me.colEliminarExpediente, Me.col_est_men_id, Me.col_est_men_nom, Me.col_exp_btn, Me.col_exp_inmp_id, Me.col_exp_inmp})
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 15)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(655, 136)
            Me.dgwExpediente.TabIndex = 0
            '
            'col_num
            '
            Me.col_num.DataPropertyName = "Indice"
            Me.col_num.HeaderText = "N°"
            Me.col_num.Name = "col_num"
            Me.col_num.Visible = False
            Me.col_num.Width = 22
            '
            'Column9
            '
            Me.Column9.DataPropertyName = "LibertadIcon"
            Me.Column9.HeaderText = ""
            Me.Column9.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Visible = False
            Me.Column9.Width = 25
            '
            'col_sel
            '
            Me.col_sel.HeaderText = "Sel."
            Me.col_sel.Name = "col_sel"
            Me.col_sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_sel.Visible = False
            Me.col_sel.Width = 32
            '
            'col_DMP
            '
            Me.col_DMP.DataPropertyName = "Principal"
            Me.col_DMP.HeaderText = "DMP"
            Me.col_DMP.Name = "col_DMP"
            Me.col_DMP.ReadOnly = True
            Me.col_DMP.ToolTipText = "Delito de Mayor Pena"
            Me.col_DMP.Width = 33
            '
            'col_SMP
            '
            Me.col_SMP.DataPropertyName = "SentenciaPrincipal"
            Me.col_SMP.HeaderText = "SMP"
            Me.col_SMP.Name = "col_SMP"
            Me.col_SMP.ReadOnly = True
            Me.col_SMP.ToolTipText = "Sentencia de Mayor Pena"
            Me.col_SMP.Width = 33
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "ExpedienteID"
            Me.col_id.HeaderText = "MovExpID"
            Me.col_id.Name = "col_id"
            Me.col_id.Visible = False
            Me.col_id.Width = 35
            '
            'col_mov_id
            '
            Me.col_mov_id.DataPropertyName = "MovimientoID"
            Me.col_mov_id.HeaderText = "MovId"
            Me.col_mov_id.Name = "col_mov_id"
            Me.col_mov_id.Visible = False
            Me.col_mov_id.Width = 35
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.Visible = False
            '
            'col_exp_id
            '
            Me.col_exp_id.DataPropertyName = "Codigo"
            Me.col_exp_id.HeaderText = "ExpedienteID"
            Me.col_exp_id.Name = "col_exp_id"
            Me.col_exp_id.ReadOnly = True
            Me.col_exp_id.Visible = False
            Me.col_exp_id.Width = 60
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_exp_numero
            '
            Me.col_exp_numero.DataPropertyName = "ExpedienteNumero"
            Me.col_exp_numero.HeaderText = "N° Exp."
            Me.col_exp_numero.Name = "col_exp_numero"
            Me.col_exp_numero.ReadOnly = True
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "AutoridadJudicialNombre"
            Me.Column5.HeaderText = "Distrito Judicial"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 120
            '
            'Column8
            '
            Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column8.DataPropertyName = "SalaJudicialNombre"
            Me.Column8.HeaderText = "Juzgado / Sala"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            '
            'col_sit_jur_id
            '
            Me.col_sit_jur_id.DataPropertyName = "SalaJudicialID"
            Me.col_sit_jur_id.HeaderText = "SituacioJuridicaID"
            Me.col_sit_jur_id.Name = "col_sit_jur_id"
            Me.col_sit_jur_id.Visible = False
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "SituacionJuridicaNombre"
            Me.Column7.HeaderText = "Sit. Juridica"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Width = 85
            '
            'col_exp_fec
            '
            Me.col_exp_fec.DataPropertyName = "ExpedienteFechaDate"
            Me.col_exp_fec.HeaderText = "Fecha"
            Me.col_exp_fec.Name = "col_exp_fec"
            Me.col_exp_fec.ReadOnly = True
            Me.col_exp_fec.Width = 70
            '
            'col_fec_rec
            '
            Me.col_fec_rec.DataPropertyName = "ExpedienteFechaDocRecepcion"
            Me.col_fec_rec.HeaderText = "FechaRecepcion"
            Me.col_fec_rec.Name = "col_fec_rec"
            Me.col_fec_rec.Visible = False
            '
            'sentencia
            '
            Me.sentencia.DataPropertyName = "SentenciaConcatenado"
            Me.sentencia.HeaderText = "Sentencia"
            Me.sentencia.Name = "sentencia"
            Me.sentencia.ReadOnly = True
            Me.sentencia.Visible = False
            Me.sentencia.Width = 250
            '
            'col_exp_anulacion
            '
            Me.col_exp_anulacion.DataPropertyName = "EstadoImage"
            Me.col_exp_anulacion.HeaderText = "Anul."
            Me.col_exp_anulacion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_exp_anulacion.Name = "col_exp_anulacion"
            Me.col_exp_anulacion.ReadOnly = True
            Me.col_exp_anulacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_anulacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_anulacion.Visible = False
            Me.col_exp_anulacion.Width = 30
            '
            'colEliminarExpediente
            '
            Me.colEliminarExpediente.DataPropertyName = "Eliminar"
            Me.colEliminarExpediente.HeaderText = ""
            Me.colEliminarExpediente.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.colEliminarExpediente.Name = "colEliminarExpediente"
            Me.colEliminarExpediente.ReadOnly = True
            Me.colEliminarExpediente.ToolTipText = "Eliminar Expediente"
            Me.colEliminarExpediente.Width = 35
            '
            'col_est_men_id
            '
            Me.col_est_men_id.DataPropertyName = "EstablecimientomentalId"
            Me.col_est_men_id.HeaderText = "idEstablecimientoMental"
            Me.col_est_men_id.Name = "col_est_men_id"
            Me.col_est_men_id.Visible = False
            '
            'col_est_men_nom
            '
            Me.col_est_men_nom.DataPropertyName = "Establecimientomental"
            Me.col_est_men_nom.HeaderText = "Destino"
            Me.col_est_men_nom.Name = "col_est_men_nom"
            Me.col_est_men_nom.Visible = False
            '
            'col_exp_btn
            '
            Me.col_exp_btn.HeaderText = ""
            Me.col_exp_btn.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.col_exp_btn.Name = "col_exp_btn"
            Me.col_exp_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_btn.Visible = False
            Me.col_exp_btn.Width = 25
            '
            'col_exp_inmp_id
            '
            Me.col_exp_inmp_id.DataPropertyName = "InimputableId"
            Me.col_exp_inmp_id.HeaderText = "InimputableId"
            Me.col_exp_inmp_id.Name = "col_exp_inmp_id"
            Me.col_exp_inmp_id.Visible = False
            '
            'col_exp_inmp
            '
            Me.col_exp_inmp.DataPropertyName = "Inimputable"
            Me.col_exp_inmp.HeaderText = "Inimputable/Posible inimputable"
            Me.col_exp_inmp.Name = "col_exp_inmp"
            Me.col_exp_inmp.Visible = False
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(655, 15)
            Me.Label1.TabIndex = 50
            Me.Label1.Text = "Expedientes"
            '
            'lblRegExp
            '
            Me.lblRegExp.AutoSize = True
            Me.lblRegExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegExp.Location = New System.Drawing.Point(74, 0)
            Me.lblRegExp.Name = "lblRegExp"
            Me.lblRegExp.Size = New System.Drawing.Size(39, 13)
            Me.lblRegExp.TabIndex = 52
            Me.lblRegExp.Text = "0 Reg."
            '
            'uscMovExpediente
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.Controls.Add(Me.lblRegExp)
            Me.Controls.Add(Me.dgwExpediente)
            Me.Controls.Add(Me.Label1)
            Me.Name = "uscMovExpediente"
            Me.Size = New System.Drawing.Size(655, 151)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dgwExpediente As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblRegExp As System.Windows.Forms.Label
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents Column9 As DataGridViewImageColumn
        Friend WithEvents col_sel As DataGridViewCheckBoxColumn
        Friend WithEvents col_DMP As DataGridViewCheckBoxColumn
        Friend WithEvents col_SMP As DataGridViewCheckBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_mov_id As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_numero As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents Column8 As DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur_id As DataGridViewTextBoxColumn
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_fec As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec As DataGridViewTextBoxColumn
        Friend WithEvents sentencia As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_anulacion As DataGridViewImageColumn
        Friend WithEvents colEliminarExpediente As DataGridViewImageColumn
        Friend WithEvents col_est_men_id As DataGridViewTextBoxColumn
        Friend WithEvents col_est_men_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_btn As DataGridViewImageColumn
        Friend WithEvents col_exp_inmp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_inmp As DataGridViewTextBoxColumn
    End Class
End Namespace

