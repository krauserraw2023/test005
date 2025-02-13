Namespace Registro.ConsultaReclusion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscInternoDetalle
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idIngresoInpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_idIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_region = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_Penal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_Tram = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec_ep = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_rec_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sol = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_tram = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_recibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_solicitante = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cant_impr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.pnlImpresion = New System.Windows.Forms.Panel()
            Me.btnImpresion = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBotones.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlImpresion.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nro, Me.col_codigo, Me.col_idInterno, Me.col_idIngresoInpe, Me.col_idIngreso, Me.col_id_region, Me.col_id_Penal, Me.col_num_Tram, Me.Column1, Me.col_fec_rec_ep, Me.col_fec_rec_rp, Me.col_tip_sol, Me.col_tip_tram, Me.col_num_recibo, Me.col_tip_solicitante, Me.col_num_cr, Me.col_fec_cr, Me.col_est, Me.col_est_nom, Me.col_cant_impr})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 47)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1116, 233)
            Me.dgwGrilla.TabIndex = 5
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_nro
            '
            Me.col_nro.DataPropertyName = "nro"
            Me.col_nro.HeaderText = "N°"
            Me.col_nro.Name = "col_nro"
            Me.col_nro.ReadOnly = True
            Me.col_nro.Visible = False
            Me.col_nro.Width = 20
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "codigo"
            Me.col_codigo.HeaderText = "codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 5
            '
            'col_idInterno
            '
            Me.col_idInterno.DataPropertyName = "idInterno "
            Me.col_idInterno.HeaderText = "InternoID"
            Me.col_idInterno.Name = "col_idInterno"
            Me.col_idInterno.ReadOnly = True
            Me.col_idInterno.Visible = False
            Me.col_idInterno.Width = 5
            '
            'col_idIngresoInpe
            '
            Me.col_idIngresoInpe.DataPropertyName = "idIngresoInpe"
            Me.col_idIngresoInpe.HeaderText = "InpeIng"
            Me.col_idIngresoInpe.Name = "col_idIngresoInpe"
            Me.col_idIngresoInpe.ReadOnly = True
            Me.col_idIngresoInpe.Visible = False
            Me.col_idIngresoInpe.Width = 5
            '
            'col_idIngreso
            '
            Me.col_idIngreso.DataPropertyName = "idIngreso"
            Me.col_idIngreso.HeaderText = "IngresoID"
            Me.col_idIngreso.Name = "col_idIngreso"
            Me.col_idIngreso.ReadOnly = True
            Me.col_idIngreso.Visible = False
            Me.col_idIngreso.Width = 5
            '
            'col_id_region
            '
            Me.col_id_region.DataPropertyName = "idRegion"
            Me.col_id_region.HeaderText = "IDRegion"
            Me.col_id_region.Name = "col_id_region"
            Me.col_id_region.ReadOnly = True
            Me.col_id_region.Visible = False
            Me.col_id_region.Width = 50
            '
            'col_id_Penal
            '
            Me.col_id_Penal.DataPropertyName = "idPenal"
            Me.col_id_Penal.HeaderText = "IDPenal"
            Me.col_id_Penal.Name = "col_id_Penal"
            Me.col_id_Penal.ReadOnly = True
            Me.col_id_Penal.Visible = False
            Me.col_id_Penal.Width = 50
            '
            'col_num_Tram
            '
            Me.col_num_Tram.DataPropertyName = "numeroTramite"
            Me.col_num_Tram.HeaderText = "N°. de trámite"
            Me.col_num_Tram.Name = "col_num_Tram"
            Me.col_num_Tram.ReadOnly = True
            Me.col_num_Tram.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_num_Tram.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_Tram.Width = 90
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "tramiteFechaRegistro"
            Me.Column1.HeaderText = "Fec.  y hora Registro Tramite"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 110
            '
            'col_fec_rec_ep
            '
            Me.col_fec_rec_ep.DataPropertyName = "fechaRecepcionEP"
            Me.col_fec_rec_ep.HeaderText = "F. recep. del requerimiento en el EP"
            Me.col_fec_rec_ep.Name = "col_fec_rec_ep"
            Me.col_fec_rec_ep.ReadOnly = True
            Me.col_fec_rec_ep.ToolTipText = "F. recep. del requerimiento en el EP"
            Me.col_fec_rec_ep.Width = 80
            '
            'col_fec_rec_rp
            '
            Me.col_fec_rec_rp.DataPropertyName = "fechaRecepcionRP"
            Me.col_fec_rec_rp.DividerWidth = 1
            Me.col_fec_rec_rp.HeaderText = "F. recep. del requerimiento en el RP"
            Me.col_fec_rec_rp.Name = "col_fec_rec_rp"
            Me.col_fec_rec_rp.ReadOnly = True
            Me.col_fec_rec_rp.ToolTipText = "F. recep. del requerimiento en el RP"
            Me.col_fec_rec_rp.Width = 80
            '
            'col_tip_sol
            '
            Me.col_tip_sol.DataPropertyName = "documentoReferenciaTipoNombre"
            Me.col_tip_sol.DividerWidth = 1
            Me.col_tip_sol.HeaderText = "Ref. del documento por el cual se hace el requerimiento"
            Me.col_tip_sol.Name = "col_tip_sol"
            Me.col_tip_sol.ReadOnly = True
            Me.col_tip_sol.ToolTipText = "Ref. del documento por el cual se hace el requerimiento"
            Me.col_tip_sol.Width = 200
            '
            'col_tip_tram
            '
            Me.col_tip_tram.DataPropertyName = "tipoTramite "
            Me.col_tip_tram.HeaderText = "Tipo Tramite"
            Me.col_tip_tram.Name = "col_tip_tram"
            Me.col_tip_tram.ReadOnly = True
            Me.col_tip_tram.Visible = False
            Me.col_tip_tram.Width = 5
            '
            'col_num_recibo
            '
            Me.col_num_recibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_num_recibo.DataPropertyName = "serieNumeroRecibo"
            Me.col_num_recibo.DividerWidth = 1
            Me.col_num_recibo.HeaderText = "N° recibo de pago"
            Me.col_num_recibo.Name = "col_num_recibo"
            Me.col_num_recibo.ReadOnly = True
            Me.col_num_recibo.ToolTipText = "Número de recibo de pago del Interno"
            Me.col_num_recibo.Width = 88
            '
            'col_tip_solicitante
            '
            Me.col_tip_solicitante.DataPropertyName = "tipoSolicitanteNombre"
            Me.col_tip_solicitante.HeaderText = "Solicitante"
            Me.col_tip_solicitante.Name = "col_tip_solicitante"
            Me.col_tip_solicitante.ReadOnly = True
            Me.col_tip_solicitante.ToolTipText = "Tipo de Solicitante"
            Me.col_tip_solicitante.Width = 200
            '
            'col_num_cr
            '
            Me.col_num_cr.DataPropertyName = "numeroCR"
            Me.col_num_cr.HeaderText = "N° CR"
            Me.col_num_cr.Name = "col_num_cr"
            Me.col_num_cr.ReadOnly = True
            Me.col_num_cr.ToolTipText = "Número de Constancia de Reclusion"
            Me.col_num_cr.Width = 90
            '
            'col_fec_cr
            '
            Me.col_fec_cr.DataPropertyName = "fechaCR"
            Me.col_fec_cr.HeaderText = "F. Expedición de CR"
            Me.col_fec_cr.Name = "col_fec_cr"
            Me.col_fec_cr.ReadOnly = True
            Me.col_fec_cr.ToolTipText = "Fecha de expedición de la Constancia de Reclusión"
            Me.col_fec_cr.Width = 110
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "estado"
            Me.col_est.HeaderText = "estadoID"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            Me.col_est.Width = 5
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "estadoNombre"
            Me.col_est_nom.HeaderText = "Estado Trámite"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            '
            'col_cant_impr
            '
            Me.col_cant_impr.DataPropertyName = "contadorCR"
            Me.col_cant_impr.HeaderText = "Cant. Imp."
            Me.col_cant_impr.Name = "col_cant_impr"
            Me.col_cant_impr.ReadOnly = True
            Me.col_cant_impr.Width = 60
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.pnlGrabar)
            Me.pnlBotones.Controls.Add(Me.pnlImpresion)
            Me.pnlBotones.Controls.Add(Me.pnlEliminar)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBotones.Location = New System.Drawing.Point(0, 0)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(1116, 47)
            Me.pnlBotones.TabIndex = 39
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlGrabar.Controls.Add(Me.btnModificar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(687, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(211, 47)
            Me.pnlGrabar.TabIndex = 91
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevo.Location = New System.Drawing.Point(4, 3)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(102, 40)
            Me.btnNuevo.TabIndex = 89
            Me.btnNuevo.Text = "Registrar solicitud"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(108, 3)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(100, 40)
            Me.btnModificar.TabIndex = 88
            Me.btnModificar.Text = "Modificar"
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlImpresion
            '
            Me.pnlImpresion.Controls.Add(Me.btnImpresion)
            Me.pnlImpresion.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlImpresion.Location = New System.Drawing.Point(898, 0)
            Me.pnlImpresion.Name = "pnlImpresion"
            Me.pnlImpresion.Size = New System.Drawing.Size(111, 47)
            Me.pnlImpresion.TabIndex = 94
            '
            'btnImpresion
            '
            Me.btnImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnImpresion.Image = Global.APPControls.My.Resources.Resources.printer3
            Me.btnImpresion.Location = New System.Drawing.Point(2, 4)
            Me.btnImpresion.Name = "btnImpresion"
            Me.btnImpresion.Size = New System.Drawing.Size(105, 39)
            Me.btnImpresion.TabIndex = 67
            Me.btnImpresion.Text = "&Imprimir"
            Me.btnImpresion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminar.Location = New System.Drawing.Point(1009, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(107, 47)
            Me.pnlEliminar.TabIndex = 92
            Me.pnlEliminar.Visible = False
            '
            'btnEliminar
            '
            Me.btnEliminar.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(100, 40)
            Me.btnEliminar.TabIndex = 91
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'uscInternoDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlBotones)
            Me.Name = "uscInternoDetalle"
            Me.Size = New System.Drawing.Size(1116, 280)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlImpresion.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlBotones As Panel
        Friend WithEvents btnImpresion As Button
        Friend WithEvents pnlGrabar As Panel
        Friend WithEvents btnNuevo As Button
        Friend WithEvents btnModificar As Button
        Friend WithEvents pnlEliminar As Panel
        Friend WithEvents btnEliminar As Button
        Friend WithEvents pnlImpresion As Panel
        Friend WithEvents col_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_idInterno As DataGridViewTextBoxColumn
        Friend WithEvents col_idIngresoInpe As DataGridViewTextBoxColumn
        Friend WithEvents col_idIngreso As DataGridViewTextBoxColumn
        Friend WithEvents col_id_region As DataGridViewTextBoxColumn
        Friend WithEvents col_id_Penal As DataGridViewTextBoxColumn
        Friend WithEvents col_num_Tram As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec_ep As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_rec_rp As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sol As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_tram As DataGridViewTextBoxColumn
        Friend WithEvents col_num_recibo As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_solicitante As DataGridViewTextBoxColumn
        Friend WithEvents col_num_cr As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cr As DataGridViewTextBoxColumn
        Friend WithEvents col_est As DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_cant_impr As DataGridViewTextBoxColumn
    End Class

End Namespace