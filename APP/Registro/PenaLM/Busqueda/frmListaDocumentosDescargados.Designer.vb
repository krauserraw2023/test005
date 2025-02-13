Namespace Registro

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmListaDocumentosDescargados
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblRegistros = New System.Windows.Forms.Label()
            Me.btnDetalleInterno = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.grbFiltro = New System.Windows.Forms.GroupBox()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.dgwDocumentosDescargados = New System.Windows.Forms.DataGridView()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.dgwDocumentosFallidos = New System.Windows.Forms.DataGridView()
            Me.tbpFichaTotal = New System.Windows.Forms.TabPage()
            Me.dgwArchivosTotales = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_des_cod_arc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mar_lei_arc = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_des_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mar_lei = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbFiltro.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            CType(Me.dgwDocumentosDescargados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TabPage2.SuspendLayout()
            CType(Me.dgwDocumentosFallidos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tbpFichaTotal.SuspendLayout()
            CType(Me.dgwArchivosTotales, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbFiltro)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(916, 396)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblRegistros)
            Me.Panel1.Controls.Add(Me.btnDetalleInterno)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 351)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(916, 45)
            Me.Panel1.TabIndex = 102
            '
            'lblRegistros
            '
            Me.lblRegistros.AutoSize = True
            Me.lblRegistros.Location = New System.Drawing.Point(5, 18)
            Me.lblRegistros.Name = "lblRegistros"
            Me.lblRegistros.Size = New System.Drawing.Size(66, 13)
            Me.lblRegistros.TabIndex = 101
            Me.lblRegistros.Text = "N° Registros"
            '
            'btnDetalleInterno
            '
            Me.btnDetalleInterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnDetalleInterno.Image = Global.SIPPOPE.My.Resources.Resources._1277961326_folder_edit
            Me.btnDetalleInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDetalleInterno.Location = New System.Drawing.Point(702, 3)
            Me.btnDetalleInterno.Name = "btnDetalleInterno"
            Me.btnDetalleInterno.Size = New System.Drawing.Size(81, 39)
            Me.btnDetalleInterno.TabIndex = 100
            Me.btnDetalleInterno.Text = "Ver Interno"
            Me.btnDetalleInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnDetalleInterno.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(816, 2)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbFiltro
            '
            Me.grbFiltro.Controls.Add(Me.TabControl1)
            Me.grbFiltro.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFiltro.Location = New System.Drawing.Point(0, 0)
            Me.grbFiltro.Name = "grbFiltro"
            Me.grbFiltro.Size = New System.Drawing.Size(916, 351)
            Me.grbFiltro.TabIndex = 103
            Me.grbFiltro.TabStop = False
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Controls.Add(Me.tbpFichaTotal)
            Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabControl1.Location = New System.Drawing.Point(3, 16)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(910, 332)
            Me.TabControl1.TabIndex = 9
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.dgwDocumentosDescargados)
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(902, 306)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "Listado de Documentos por la ORL"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'dgwDocumentosDescargados
            '
            Me.dgwDocumentosDescargados.AllowUserToAddRows = False
            Me.dgwDocumentosDescargados.BackgroundColor = System.Drawing.Color.White
            Me.dgwDocumentosDescargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDocumentosDescargados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_des_cod, Me.col_int_id, Me.col_int_cod, Me.col_int_nom, Me.Column3, Me.Column14, Me.col_agr_nom, Me.DataGridViewTextBoxColumn6, Me.col_mar_lei})
            Me.dgwDocumentosDescargados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDocumentosDescargados.GridColor = System.Drawing.Color.LightGray
            Me.dgwDocumentosDescargados.Location = New System.Drawing.Point(3, 3)
            Me.dgwDocumentosDescargados.MultiSelect = False
            Me.dgwDocumentosDescargados.Name = "dgwDocumentosDescargados"
            Me.dgwDocumentosDescargados.ReadOnly = True
            Me.dgwDocumentosDescargados.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDocumentosDescargados.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwDocumentosDescargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDocumentosDescargados.Size = New System.Drawing.Size(896, 300)
            Me.dgwDocumentosDescargados.TabIndex = 8
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.dgwDocumentosFallidos)
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(902, 306)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "Listado de internos con informacion no descargada"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'dgwDocumentosFallidos
            '
            Me.dgwDocumentosFallidos.AllowUserToAddRows = False
            Me.dgwDocumentosFallidos.BackgroundColor = System.Drawing.Color.White
            Me.dgwDocumentosFallidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDocumentosFallidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8})
            Me.dgwDocumentosFallidos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDocumentosFallidos.GridColor = System.Drawing.Color.LightGray
            Me.dgwDocumentosFallidos.Location = New System.Drawing.Point(3, 3)
            Me.dgwDocumentosFallidos.MultiSelect = False
            Me.dgwDocumentosFallidos.Name = "dgwDocumentosFallidos"
            Me.dgwDocumentosFallidos.ReadOnly = True
            Me.dgwDocumentosFallidos.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDocumentosFallidos.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwDocumentosFallidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDocumentosFallidos.Size = New System.Drawing.Size(896, 300)
            Me.dgwDocumentosFallidos.TabIndex = 9
            '
            'tbpFichaTotal
            '
            Me.tbpFichaTotal.Controls.Add(Me.dgwArchivosTotales)
            Me.tbpFichaTotal.Location = New System.Drawing.Point(4, 22)
            Me.tbpFichaTotal.Name = "tbpFichaTotal"
            Me.tbpFichaTotal.Padding = New System.Windows.Forms.Padding(3)
            Me.tbpFichaTotal.Size = New System.Drawing.Size(902, 306)
            Me.tbpFichaTotal.TabIndex = 2
            Me.tbpFichaTotal.Text = "Listado de archivos no descargada"
            Me.tbpFichaTotal.UseVisualStyleBackColor = True
            '
            'dgwArchivosTotales
            '
            Me.dgwArchivosTotales.AllowUserToAddRows = False
            Me.dgwArchivosTotales.BackgroundColor = System.Drawing.Color.White
            Me.dgwArchivosTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwArchivosTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_des_cod_arc, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.col_mar_lei_arc})
            Me.dgwArchivosTotales.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwArchivosTotales.GridColor = System.Drawing.Color.LightGray
            Me.dgwArchivosTotales.Location = New System.Drawing.Point(3, 3)
            Me.dgwArchivosTotales.MultiSelect = False
            Me.dgwArchivosTotales.Name = "dgwArchivosTotales"
            Me.dgwArchivosTotales.ReadOnly = True
            Me.dgwArchivosTotales.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwArchivosTotales.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwArchivosTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwArchivosTotales.Size = New System.Drawing.Size(896, 300)
            Me.dgwArchivosTotales.TabIndex = 10
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "InternoId"
            Me.DataGridViewTextBoxColumn1.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Visible = False
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "Observacion"
            Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "ApellidosNombres"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Nombres del Interno"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 290
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "DocumentoTipoNombre"
            Me.DataGridViewTextBoxColumn4.HeaderText = "Proceso"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 260
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaMovimientoString"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Descarga en Penal"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.Width = 170
            '
            'col_des_cod_arc
            '
            Me.col_des_cod_arc.DataPropertyName = "Codigo"
            Me.col_des_cod_arc.HeaderText = "CodigoDescarga"
            Me.col_des_cod_arc.Name = "col_des_cod_arc"
            Me.col_des_cod_arc.ReadOnly = True
            Me.col_des_cod_arc.Visible = False
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "InternoId"
            Me.DataGridViewTextBoxColumn5.HeaderText = "InternoID"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.ReadOnly = True
            Me.DataGridViewTextBoxColumn5.Visible = False
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "Observacion"
            Me.DataGridViewTextBoxColumn7.HeaderText = "Codigo"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "ApellidosNombres"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Nombres del Interno"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            Me.DataGridViewTextBoxColumn9.Width = 290
            '
            'DataGridViewTextBoxColumn10
            '
            Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.DataGridViewTextBoxColumn10.DataPropertyName = "DocumentoTipoNombre"
            Me.DataGridViewTextBoxColumn10.HeaderText = "Proceso"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.ReadOnly = True
            Me.DataGridViewTextBoxColumn10.Width = 260
            '
            'DataGridViewTextBoxColumn11
            '
            Me.DataGridViewTextBoxColumn11.DataPropertyName = "FechaMovimientoString"
            Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha Descarga en Penal"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.ReadOnly = True
            Me.DataGridViewTextBoxColumn11.Width = 170
            '
            'col_mar_lei_arc
            '
            Me.col_mar_lei_arc.HeaderText = "Verificado"
            Me.col_mar_lei_arc.Name = "col_mar_lei_arc"
            Me.col_mar_lei_arc.ReadOnly = True
            Me.col_mar_lei_arc.Width = 80
            '
            'col_des_cod
            '
            Me.col_des_cod.DataPropertyName = "Codigo"
            Me.col_des_cod.HeaderText = "CodigoDescarga"
            Me.col_des_cod.Name = "col_des_cod"
            Me.col_des_cod.ReadOnly = True
            Me.col_des_cod.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoId"
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_int_cod
            '
            Me.col_int_cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_int_cod.DataPropertyName = "Observacion"
            Me.col_int_cod.HeaderText = "Codigo"
            Me.col_int_cod.Name = "col_int_cod"
            Me.col_int_cod.ReadOnly = True
            Me.col_int_cod.Width = 75
            '
            'col_int_nom
            '
            Me.col_int_nom.DataPropertyName = "ApellidosNombres"
            Me.col_int_nom.HeaderText = "Nombres del Interno"
            Me.col_int_nom.Name = "col_int_nom"
            Me.col_int_nom.ReadOnly = True
            Me.col_int_nom.Width = 185
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column3.DataPropertyName = "DocumentoTipoNombre"
            Me.Column3.HeaderText = "Tipo Documento"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 115
            '
            'Column14
            '
            Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column14.DataPropertyName = "DocumentoNumero"
            Me.Column14.HeaderText = "Número Doc."
            Me.Column14.Name = "Column14"
            Me.Column14.ReadOnly = True
            Me.Column14.Width = 120
            '
            'col_agr_nom
            '
            Me.col_agr_nom.DataPropertyName = "DocumentoFechaDate"
            Me.col_agr_nom.HeaderText = "Fecha de Registro en ORL"
            Me.col_agr_nom.Name = "col_agr_nom"
            Me.col_agr_nom.ReadOnly = True
            Me.col_agr_nom.Width = 140
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaMovimientoString"
            Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha de Descarga en Penal"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            Me.DataGridViewTextBoxColumn6.Width = 150
            '
            'col_mar_lei
            '
            Me.col_mar_lei.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_mar_lei.DataPropertyName = "Estado"
            Me.col_mar_lei.HeaderText = "Verificado"
            Me.col_mar_lei.Name = "col_mar_lei"
            Me.col_mar_lei.ReadOnly = True
            Me.col_mar_lei.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_mar_lei.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'frmListaDocumentosDescargados
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(916, 396)
            Me.Name = "frmListaDocumentosDescargados"
            Me.Text = "DOCUMENTOS DESCARGADOS DE SEDE"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.grbFiltro.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            CType(Me.dgwDocumentosDescargados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TabPage2.ResumeLayout(False)
            CType(Me.dgwDocumentosFallidos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tbpFichaTotal.ResumeLayout(False)
            CType(Me.dgwArchivosTotales, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
        Friend WithEvents dgwDocumentosDescargados As DataGridView
        Friend WithEvents btnDetalleInterno As Button
        Friend WithEvents lblRegistros As Label
        Friend WithEvents TabControl1 As TabControl
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents dgwDocumentosFallidos As DataGridView
        Friend WithEvents tbpFichaTotal As TabPage
        Friend WithEvents dgwArchivosTotales As DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents col_des_cod_arc As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
        Friend WithEvents col_mar_lei_arc As DataGridViewCheckBoxColumn
        Friend WithEvents col_des_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_int_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_int_nom As DataGridViewTextBoxColumn
        Friend WithEvents Column3 As DataGridViewTextBoxColumn
        Friend WithEvents Column14 As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_nom As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents col_mar_lei As DataGridViewCheckBoxColumn
    End Class
End Namespace