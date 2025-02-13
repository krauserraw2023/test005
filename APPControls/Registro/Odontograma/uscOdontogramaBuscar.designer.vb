Namespace Registro.Odontograma
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscOdontogramaBuscar
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscOdontogramaBuscar))
            Me.pnlGrilla = New System.Windows.Forms.Panel()
            Me.dgwOdontograma = New Legolas.APPUIComponents.myDatagridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg_odt = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ver = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_arc_odo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_espe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAccionFotografia = New System.Windows.Forms.Panel()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminarOdont = New System.Windows.Forms.Button()
            Me.pnlAdd = New System.Windows.Forms.Panel()
            Me.btnModificarOdont = New System.Windows.Forms.Button()
            Me.btnAgregarOdont = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.AxCtlOdon1 = New AxCTLODONLib.AxCtlOdon()
            Me.UscOdontograma1 = New uscOdontogramaBuscar()
            Me.pnlGrilla.SuspendLayout()
            CType(Me.dgwOdontograma, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAccionFotografia.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlAdd.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            CType(Me.AxCtlOdon1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlGrilla
            '
            Me.pnlGrilla.Controls.Add(Me.dgwOdontograma)
            Me.pnlGrilla.Controls.Add(Me.pnlAccionFotografia)
            Me.pnlGrilla.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGrilla.Location = New System.Drawing.Point(699, 0)
            Me.pnlGrilla.Name = "pnlGrilla"
            Me.pnlGrilla.Size = New System.Drawing.Size(256, 601)
            Me.pnlGrilla.TabIndex = 4
            '
            'dgwOdontograma
            '
            Me.dgwOdontograma.AllowUserToAddRows = False
            Me.dgwOdontograma.AllowUserToDeleteRows = False
            Me.dgwOdontograma.AllowUserToResizeRows = False
            Me.dgwOdontograma.BackgroundColor = System.Drawing.Color.White
            Me.dgwOdontograma.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwOdontograma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwOdontograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwOdontograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_ing_nro_inpe, Me.col_num_ing, Me.col_fec_reg_odt, Me.col_int_id, Me.Column1, Me.col_ing_id, Me.col_pen_id, Me.col_reg_id, Me.col_ver, Me.col_nom_arc_odo, Me.col_obs, Me.col_espe})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwOdontograma.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwOdontograma.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgwOdontograma.Location = New System.Drawing.Point(0, 29)
            Me.dgwOdontograma.MultiSelect = False
            Me.dgwOdontograma.Name = "dgwOdontograma"
            Me.dgwOdontograma.ReadOnly = True
            Me.dgwOdontograma.RowHeadersVisible = False
            Me.dgwOdontograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwOdontograma.Size = New System.Drawing.Size(256, 468)
            Me.dgwOdontograma.TabIndex = 0
            Me.dgwOdontograma.VisibleCampos = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "N° Ing."
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_num_ing
            '
            Me.col_num_ing.DataPropertyName = "NumeroIngreso"
            Me.col_num_ing.HeaderText = "N° Ing."
            Me.col_num_ing.Name = "col_num_ing"
            Me.col_num_ing.ReadOnly = True
            Me.col_num_ing.Width = 45
            '
            'col_fec_reg_odt
            '
            Me.col_fec_reg_odt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_fec_reg_odt.DataPropertyName = "FechaRegistroDate"
            Me.col_fec_reg_odt.HeaderText = "Fecha Registro"
            Me.col_fec_reg_odt.Name = "col_fec_reg_odt"
            Me.col_fec_reg_odt.ReadOnly = True
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoId"
            Me.col_int_id.HeaderText = "InternoId"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "IngresoInpeId"
            Me.Column1.HeaderText = "IngresoInpeId"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            '
            'col_ing_id
            '
            Me.col_ing_id.DataPropertyName = "IngresoId"
            Me.col_ing_id.HeaderText = "IngresoId"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalId"
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionId"
            Me.col_reg_id.HeaderText = "RegionId"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_ver
            '
            Me.col_ver.DataPropertyName = "version"
            Me.col_ver.HeaderText = "version"
            Me.col_ver.Name = "col_ver"
            Me.col_ver.ReadOnly = True
            Me.col_ver.Visible = False
            '
            'col_nom_arc_odo
            '
            Me.col_nom_arc_odo.DataPropertyName = "nombreArchivo"
            Me.col_nom_arc_odo.HeaderText = "nombreArchivo"
            Me.col_nom_arc_odo.Name = "col_nom_arc_odo"
            Me.col_nom_arc_odo.ReadOnly = True
            Me.col_nom_arc_odo.Visible = False
            '
            'col_obs
            '
            Me.col_obs.DataPropertyName = "Observaciones"
            Me.col_obs.HeaderText = "Observaciones"
            Me.col_obs.Name = "col_obs"
            Me.col_obs.ReadOnly = True
            Me.col_obs.Visible = False
            '
            'col_espe
            '
            Me.col_espe.DataPropertyName = "Especificaciones"
            Me.col_espe.HeaderText = "Especificaciones"
            Me.col_espe.Name = "col_espe"
            Me.col_espe.ReadOnly = True
            Me.col_espe.Visible = False
            '
            'pnlAccionFotografia
            '
            Me.pnlAccionFotografia.Controls.Add(Me.pnlEliminar)
            Me.pnlAccionFotografia.Controls.Add(Me.pnlAdd)
            Me.pnlAccionFotografia.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccionFotografia.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccionFotografia.Name = "pnlAccionFotografia"
            Me.pnlAccionFotografia.Size = New System.Drawing.Size(256, 29)
            Me.pnlAccionFotografia.TabIndex = 1
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminarOdont)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(63, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(32, 29)
            Me.pnlEliminar.TabIndex = 1
            '
            'btnEliminarOdont
            '
            Me.btnEliminarOdont.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarOdont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarOdont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminarOdont.Location = New System.Drawing.Point(1, 1)
            Me.btnEliminarOdont.Name = "btnEliminarOdont"
            Me.btnEliminarOdont.Size = New System.Drawing.Size(29, 26)
            Me.btnEliminarOdont.TabIndex = 2
            Me.btnEliminarOdont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminarOdont.UseVisualStyleBackColor = True
            '
            'pnlAdd
            '
            Me.pnlAdd.Controls.Add(Me.btnModificarOdont)
            Me.pnlAdd.Controls.Add(Me.btnAgregarOdont)
            Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlAdd.Location = New System.Drawing.Point(0, 0)
            Me.pnlAdd.Name = "pnlAdd"
            Me.pnlAdd.Size = New System.Drawing.Size(63, 29)
            Me.pnlAdd.TabIndex = 1
            '
            'btnModificarOdont
            '
            Me.btnModificarOdont.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificarOdont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModificarOdont.Location = New System.Drawing.Point(33, 1)
            Me.btnModificarOdont.Name = "btnModificarOdont"
            Me.btnModificarOdont.Size = New System.Drawing.Size(29, 26)
            Me.btnModificarOdont.TabIndex = 11
            Me.btnModificarOdont.UseVisualStyleBackColor = True
            '
            'btnAgregarOdont
            '
            Me.btnAgregarOdont.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregarOdont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregarOdont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAgregarOdont.Location = New System.Drawing.Point(3, 1)
            Me.btnAgregarOdont.Name = "btnAgregarOdont"
            Me.btnAgregarOdont.Size = New System.Drawing.Size(29, 26)
            Me.btnAgregarOdont.TabIndex = 0
            Me.btnAgregarOdont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregarOdont.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.Controls.Add(Me.AxCtlOdon1)
            Me.pnlMain.Controls.Add(Me.UscOdontograma1)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlMain.Location = New System.Drawing.Point(0, 0)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New System.Drawing.Size(699, 601)
            Me.pnlMain.TabIndex = 1
            '
            'AxCtlOdon1
            '
            Me.AxCtlOdon1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AxCtlOdon1.Enabled = True
            Me.AxCtlOdon1.Location = New System.Drawing.Point(0, 0)
            Me.AxCtlOdon1.Name = "AxCtlOdon1"
            Me.AxCtlOdon1.OcxState = CType(resources.GetObject("AxCtlOdon1.OcxState"), System.Windows.Forms.AxHost.State)
            Me.AxCtlOdon1.Size = New System.Drawing.Size(699, 601)
            Me.AxCtlOdon1.TabIndex = 0
            '
            'UscOdontograma1
            '
            ' Me.UscOdontograma1._visiblePanelBotones = False
            Me.UscOdontograma1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscOdontograma1.Location = New System.Drawing.Point(0, 0)
            Me.UscOdontograma1.Name = "UscOdontograma1"
            Me.UscOdontograma1.Size = New System.Drawing.Size(699, 650)
            Me.UscOdontograma1.TabIndex = 1
            '
            'uscOdontogramaBuscar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrilla)
            Me.Controls.Add(Me.pnlMain)
            Me.Name = "uscOdontogramaBuscar"
            Me.Size = New System.Drawing.Size(1039, 601)
            Me.pnlGrilla.ResumeLayout(False)
            CType(Me.dgwOdontograma, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAccionFotografia.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlAdd.ResumeLayout(False)
            Me.pnlMain.ResumeLayout(False)
            CType(Me.AxCtlOdon1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlGrilla As System.Windows.Forms.Panel
        Friend WithEvents dgwOdontograma As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlAccionFotografia As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarOdont As System.Windows.Forms.Button
        Friend WithEvents pnlAdd As System.Windows.Forms.Panel
        Friend WithEvents btnModificarOdont As System.Windows.Forms.Button
        Friend WithEvents btnAgregarOdont As System.Windows.Forms.Button
        Friend WithEvents AxCtlOdon1 As AxCTLODONLib.AxCtlOdon
        Friend WithEvents pnlMain As Panel
        Friend WithEvents UscOdontograma1 As uscOdontogramaBuscar
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg_odt As DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As DataGridViewTextBoxColumn
        Friend WithEvents col_ver As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_arc_odo As DataGridViewTextBoxColumn
        Friend WithEvents col_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_espe As DataGridViewTextBoxColumn
    End Class
End Namespace