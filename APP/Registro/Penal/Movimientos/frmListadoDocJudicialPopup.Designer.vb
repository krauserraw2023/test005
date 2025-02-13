Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmListadoDocJudicialPopup
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.dgwExpediente = New System.Windows.Forms.DataGridView()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_dest_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dis_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_aut_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_mot_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_org = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_des_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_des_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PnlInferior.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.PnlBotones)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 151)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(828, 45)
            Me.PnlInferior.TabIndex = 1
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Right
            Me.PnlBotones.Location = New System.Drawing.Point(628, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(200, 45)
            Me.PnlBotones.TabIndex = 0
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(4, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(91, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(98, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.col_sel, Me.col_id, Me.col_reg_dest_id, Me.col_exp_numero, Me.col_ing_id, Me.col_dis_jud_id, Me.col_tip_aut_id, Me.col_sal_jud, Me.Column7, Me.Column5, Me.col_doc_mot_id, Me.col_org, Me.col_reg_des_id, Me.col_pen_des_id, Me.col_des, Me.col_fec_doc, Me.col_fec_rec_doc, Me.col_obs})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwExpediente.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(3, 16)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            Me.dgwExpediente.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(822, 132)
            Me.dgwExpediente.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.dgwExpediente)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(828, 151)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "DocumentoTipoNombre"
            Me.Column3.HeaderText = "Tipo documento"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 120
            '
            'col_sel
            '
            Me.col_sel.HeaderText = "Sel."
            Me.col_sel.Name = "col_sel"
            Me.col_sel.ReadOnly = True
            Me.col_sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_sel.Visible = False
            Me.col_sel.Width = 27
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Doc.Judic.ID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 85
            '
            'col_reg_dest_id
            '
            Me.col_reg_dest_id.DataPropertyName = "RegionDestinoId"
            Me.col_reg_dest_id.HeaderText = "RegionDestinoId"
            Me.col_reg_dest_id.Name = "col_reg_dest_id"
            Me.col_reg_dest_id.ReadOnly = True
            Me.col_reg_dest_id.Visible = False
            '
            'col_exp_numero
            '
            Me.col_exp_numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_exp_numero.DataPropertyName = "DocumentoNumero"
            Me.col_exp_numero.HeaderText = "Doc. Judicial"
            Me.col_exp_numero.Name = "col_exp_numero"
            Me.col_exp_numero.ReadOnly = True
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoID"
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_dis_jud_id
            '
            Me.col_dis_jud_id.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_dis_jud_id.HeaderText = "Distrito Judicial"
            Me.col_dis_jud_id.Name = "col_dis_jud_id"
            Me.col_dis_jud_id.ReadOnly = True
            Me.col_dis_jud_id.Visible = False
            Me.col_dis_jud_id.Width = 140
            '
            'col_tip_aut_id
            '
            Me.col_tip_aut_id.DataPropertyName = "TipoAutoridadJudicial"
            Me.col_tip_aut_id.HeaderText = "TipoAutoridadID"
            Me.col_tip_aut_id.Name = "col_tip_aut_id"
            Me.col_tip_aut_id.ReadOnly = True
            Me.col_tip_aut_id.Visible = False
            '
            'col_sal_jud
            '
            Me.col_sal_jud.DataPropertyName = "SalaJudicialNombre"
            Me.col_sal_jud.HeaderText = "Juzgado/Sala"
            Me.col_sal_jud.Name = "col_sal_jud"
            Me.col_sal_jud.ReadOnly = True
            Me.col_sal_jud.Visible = False
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "SitJuridicaNombre"
            Me.Column7.HeaderText = "Sit. Juridica"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Visible = False
            Me.Column7.Width = 70
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "NroIngreso"
            Me.Column5.HeaderText = "Nro Ingreso"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Visible = False
            Me.Column5.Width = 45
            '
            'col_doc_mot_id
            '
            Me.col_doc_mot_id.DataPropertyName = "MovimientoMotivoNom"
            Me.col_doc_mot_id.HeaderText = "Motivo"
            Me.col_doc_mot_id.Name = "col_doc_mot_id"
            Me.col_doc_mot_id.ReadOnly = True
            Me.col_doc_mot_id.Width = 120
            '
            'col_org
            '
            Me.col_org.DataPropertyName = "PenalOrigenNom"
            Me.col_org.HeaderText = "Origen"
            Me.col_org.Name = "col_org"
            Me.col_org.ReadOnly = True
            Me.col_org.Width = 250
            '
            'col_reg_des_id
            '
            Me.col_reg_des_id.DataPropertyName = "RegionDestinoId"
            Me.col_reg_des_id.HeaderText = "RegionDestinoID"
            Me.col_reg_des_id.Name = "col_reg_des_id"
            Me.col_reg_des_id.ReadOnly = True
            Me.col_reg_des_id.Visible = False
            '
            'col_pen_des_id
            '
            Me.col_pen_des_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_pen_des_id.DataPropertyName = "PenalDestinoID"
            Me.col_pen_des_id.HeaderText = "PenalDestinoID"
            Me.col_pen_des_id.Name = "col_pen_des_id"
            Me.col_pen_des_id.ReadOnly = True
            Me.col_pen_des_id.Visible = False
            '
            'col_des
            '
            Me.col_des.DataPropertyName = "PenalDestinoNom"
            Me.col_des.HeaderText = "Destino"
            Me.col_des.Name = "col_des"
            Me.col_des.ReadOnly = True
            Me.col_des.Width = 250
            '
            'col_fec_doc
            '
            Me.col_fec_doc.DataPropertyName = "DocumentoFechaDate"
            Me.col_fec_doc.HeaderText = "Fec. Doc."
            Me.col_fec_doc.Name = "col_fec_doc"
            Me.col_fec_doc.ReadOnly = True
            Me.col_fec_doc.Width = 90
            '
            'col_fec_rec_doc
            '
            Me.col_fec_rec_doc.DataPropertyName = "DocumentoFechaRecepDate2"
            Me.col_fec_rec_doc.HeaderText = "Fec. Recep."
            Me.col_fec_rec_doc.Name = "col_fec_rec_doc"
            Me.col_fec_rec_doc.ReadOnly = True
            Me.col_fec_rec_doc.Width = 90
            '
            'col_obs
            '
            Me.col_obs.DataPropertyName = "Observacion"
            Me.col_obs.HeaderText = "Observacion"
            Me.col_obs.Name = "col_obs"
            Me.col_obs.ReadOnly = True
            Me.col_obs.Visible = False
            '
            'frmListadoDocJudicialPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(828, 196)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.PnlInferior)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmListadoDocJudicialPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Seleccione Documento..."
            Me.PnlInferior.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents dgwExpediente As System.Windows.Forms.DataGridView
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents col_sel As DataGridViewCheckBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_dest_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_numero As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As DataGridViewTextBoxColumn
        Friend WithEvents col_dis_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_aut_id As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As DataGridViewTextBoxColumn
        Friend WithEvents Column7 As DataGridViewTextBoxColumn
        Friend WithEvents Column5 As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_mot_id As DataGridViewTextBoxColumn
        Friend WithEvents col_org As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_des_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_des_id As DataGridViewTextBoxColumn
        Friend WithEvents col_des As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_obs As DataGridViewTextBoxColumn
    End Class
End Namespace

