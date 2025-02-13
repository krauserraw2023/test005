Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscFichaClasifTraslado
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBotonAcciones = New System.Windows.Forms.Panel()
            Me.pnlEscritura = New System.Windows.Forms.Panel()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.BtnEditar = New System.Windows.Forms.Button()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.dgvGrilla = New System.Windows.Forms.DataGridView()
            Me.ttp01 = New System.Windows.Forms.ToolTip(Me.components)
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_causal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_resol = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_resol = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_regimen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_etapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pabellon = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBotonAcciones.SuspendLayout()
            Me.pnlEscritura.SuspendLayout()
            CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlBotonAcciones
            '
            Me.pnlBotonAcciones.Controls.Add(Me.pnlEscritura)
            Me.pnlBotonAcciones.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBotonAcciones.Location = New System.Drawing.Point(918, 0)
            Me.pnlBotonAcciones.Name = "pnlBotonAcciones"
            Me.pnlBotonAcciones.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.pnlBotonAcciones.Size = New System.Drawing.Size(40, 436)
            Me.pnlBotonAcciones.TabIndex = 99
            '
            'pnlEscritura
            '
            Me.pnlEscritura.Controls.Add(Me.btnReporte)
            Me.pnlEscritura.Controls.Add(Me.BtnEditar)
            Me.pnlEscritura.Controls.Add(Me.btnNuevo)
            Me.pnlEscritura.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlEscritura.Location = New System.Drawing.Point(0, 20)
            Me.pnlEscritura.Name = "pnlEscritura"
            Me.pnlEscritura.Size = New System.Drawing.Size(40, 255)
            Me.pnlEscritura.TabIndex = 99
            '
            'btnReporte
            '
            Me.btnReporte.BackgroundImage = Global.APPControls.My.Resources.Resources.printer3
            Me.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnReporte.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnReporte.Location = New System.Drawing.Point(0, 80)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(40, 40)
            Me.btnReporte.TabIndex = 100
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ttp01.SetToolTip(Me.btnReporte, "Imprimir formato 04")
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'BtnEditar
            '
            Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.BtnEditar.Dock = System.Windows.Forms.DockStyle.Top
            Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnEditar.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.BtnEditar.Location = New System.Drawing.Point(0, 40)
            Me.BtnEditar.Name = "BtnEditar"
            Me.BtnEditar.Size = New System.Drawing.Size(40, 40)
            Me.BtnEditar.TabIndex = 98
            Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnNuevo
            '
            Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(40, 40)
            Me.btnNuevo.TabIndex = 89
            Me.btnNuevo.Tag = "Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'dgvGrilla
            '
            Me.dgvGrilla.AllowUserToAddRows = False
            Me.dgvGrilla.AllowUserToDeleteRows = False
            Me.dgvGrilla.AllowUserToResizeRows = False
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvGrilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Column3, Me.Column4, Me.col_causal, Me.col_resol, Me.col_fec_resol, Me.col_regimen, Me.col_etapa, Me.col_pabellon, Me.col_estado})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvGrilla.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvGrilla.GridColor = System.Drawing.Color.SkyBlue
            Me.dgvGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgvGrilla.MultiSelect = False
            Me.dgvGrilla.Name = "dgvGrilla"
            Me.dgvGrilla.ReadOnly = True
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvGrilla.RowHeadersVisible = False
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvGrilla.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvGrilla.Size = New System.Drawing.Size(918, 436)
            Me.dgvGrilla.TabIndex = 100
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "InternoPenalFichaId"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "NumeroClasificacion"
            Me.Column3.HeaderText = "N° Clasificación"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 120
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "FechaClasificacionString"
            Me.Column4.HeaderText = "Fecha Clasificación"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 150
            '
            'col_causal
            '
            Me.col_causal.DataPropertyName = "Causal"
            Me.col_causal.HeaderText = "Causal"
            Me.col_causal.Name = "col_causal"
            Me.col_causal.ReadOnly = True
            '
            'col_resol
            '
            Me.col_resol.DataPropertyName = "ResolAutorizacion"
            Me.col_resol.HeaderText = "Resolución"
            Me.col_resol.Name = "col_resol"
            Me.col_resol.ReadOnly = True
            '
            'col_fec_resol
            '
            Me.col_fec_resol.DataPropertyName = "FechaResolucionString"
            Me.col_fec_resol.HeaderText = "Fecha Resol."
            Me.col_fec_resol.Name = "col_fec_resol"
            Me.col_fec_resol.ReadOnly = True
            '
            'col_regimen
            '
            Me.col_regimen.DataPropertyName = "InternoRegimenNombre_Clasif"
            Me.col_regimen.HeaderText = "Régimen"
            Me.col_regimen.Name = "col_regimen"
            Me.col_regimen.ReadOnly = True
            '
            'col_etapa
            '
            Me.col_etapa.DataPropertyName = "InternoEtapaNombre_Clasif"
            Me.col_etapa.HeaderText = "Etapa"
            Me.col_etapa.Name = "col_etapa"
            Me.col_etapa.ReadOnly = True
            Me.col_etapa.Width = 150
            '
            'col_pabellon
            '
            Me.col_pabellon.DataPropertyName = "PabellonNombre"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.NullValue = "0"
            Me.col_pabellon.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_pabellon.HeaderText = "Pabellón"
            Me.col_pabellon.Name = "col_pabellon"
            Me.col_pabellon.ReadOnly = True
            Me.col_pabellon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_pabellon.Width = 150
            '
            'col_estado
            '
            Me.col_estado.DataPropertyName = "EstadoNombre"
            Me.col_estado.HeaderText = "Estado"
            Me.col_estado.Name = "col_estado"
            Me.col_estado.ReadOnly = True
            Me.col_estado.ToolTipText = "Estado clasificación"
            Me.col_estado.Width = 80
            '
            'uscFichaClasifTraslado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgvGrilla)
            Me.Controls.Add(Me.pnlBotonAcciones)
            Me.Name = "uscFichaClasifTraslado"
            Me.Size = New System.Drawing.Size(958, 436)
            Me.pnlBotonAcciones.ResumeLayout(False)
            Me.pnlEscritura.ResumeLayout(False)
            CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlBotonAcciones As Panel
        Friend WithEvents pnlEscritura As Panel
        Friend WithEvents btnNuevo As Button
        Friend WithEvents dgvGrilla As DataGridView
        Friend WithEvents ttp01 As ToolTip
        Friend WithEvents btnReporte As Button
        Friend WithEvents BtnEditar As Button
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column4 As DataGridViewTextBoxColumn
        Friend WithEvents col_causal As DataGridViewTextBoxColumn
        Friend WithEvents col_resol As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_resol As DataGridViewTextBoxColumn
        Friend WithEvents col_regimen As DataGridViewTextBoxColumn
        Friend WithEvents col_etapa As DataGridViewTextBoxColumn
        Friend WithEvents col_pabellon As DataGridViewTextBoxColumn
        Friend WithEvents col_estado As DataGridViewTextBoxColumn
    End Class
End Namespace