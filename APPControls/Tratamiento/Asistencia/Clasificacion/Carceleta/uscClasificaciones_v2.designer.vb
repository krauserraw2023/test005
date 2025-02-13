'Namespace Registro.Carceleta.Clasificacion
Namespace Clasificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscClasificaciones_v2
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrillaFicha = New System.Windows.Forms.DataGridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tip_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_clasif = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_fic = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cat_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_fin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_estado_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_id2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sit_jur = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_regimen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlIzqAdd = New System.Windows.Forms.Panel()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.btnBloqDesbloq = New System.Windows.Forms.Button()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnImprimirF06 = New System.Windows.Forms.Button()
            Me.btnFormato06_psicologica = New System.Windows.Forms.Button()
            Me.btnFormato06_social = New System.Windows.Forms.Button()
            Me.btnFormato06_legal = New System.Windows.Forms.Button()
            Me.cmdCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.dgvFichaVariables = New System.Windows.Forms.DataGridView()
            Me.col_fic_det_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mae_var_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_val_id_sel = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje_noprev = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ptje2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_buton = New System.Windows.Forms.DataGridViewButtonColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.gbDetalle = New System.Windows.Forms.GroupBox()
            Me.dtpHoraETAPA = New System.Windows.Forms.DateTimePicker()
            Me.cboSitJuridica = New System.Windows.Forms.ComboBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtobservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCategoria = New System.Windows.Forms.TextBox()
            Me.txtNumClasificacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblPuntaje = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dtpFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtPuntTotal = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblDocIdent = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.lblNacionalidad = New System.Windows.Forms.Label()
            Me.txtNumDni = New System.Windows.Forms.Label()
            Me.lblSexo = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.gbUbicacion = New System.Windows.Forms.GroupBox()
            Me.lblModificadoPor = New System.Windows.Forms.Label()
            Me.btnCancelPenal = New System.Windows.Forms.Button()
            Me.btnEdiPenal = New System.Windows.Forms.Button()
            Me.cbbRegimenPenal = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cbbPenalDestino = New APPControls.uscComboParametrica()
            Me.cbbRegionDestino = New APPControls.uscComboParametrica()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pnlSuperior = New System.Windows.Forms.Panel()
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            CType(Me.dgwGrillaFicha, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlIzqAdd.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.gbDetalle.SuspendLayout()
            Me.gbUbicacion.SuspendLayout()
            Me.pnlSuperior.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrillaFicha
            '
            Me.dgwGrillaFicha.AllowUserToAddRows = False
            Me.dgwGrillaFicha.AllowUserToDeleteRows = False
            Me.dgwGrillaFicha.AllowUserToResizeRows = False
            Me.dgwGrillaFicha.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaFicha.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaFicha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.tip_fic_id, Me.col_num_clasif, Me.col_nom_fic, Me.col_fec_cla, Me.col_ptje, Me.col_id_cat, Me.col_cat_nom, Me.col_fic_fin, Me.col_estado, Me.col_estado_id, Me.col_fic_id2, Me.col_obs, Me.col_sit_jur, Me.col_regimen_id})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrillaFicha.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaFicha.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaFicha.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaFicha.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrillaFicha.MultiSelect = False
            Me.dgwGrillaFicha.Name = "dgwGrillaFicha"
            Me.dgwGrillaFicha.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaFicha.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillaFicha.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaFicha.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrillaFicha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaFicha.Size = New System.Drawing.Size(943, 184)
            Me.dgwGrillaFicha.TabIndex = 0
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 50
            '
            'tip_fic_id
            '
            Me.tip_fic_id.DataPropertyName = "TipoFichaId"
            Me.tip_fic_id.HeaderText = "TipoFichaId"
            Me.tip_fic_id.Name = "tip_fic_id"
            Me.tip_fic_id.ReadOnly = True
            Me.tip_fic_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.tip_fic_id.Visible = False
            Me.tip_fic_id.Width = 153
            '
            'col_num_clasif
            '
            Me.col_num_clasif.DataPropertyName = "NumeroClasificacion"
            Me.col_num_clasif.HeaderText = "N° Clasif."
            Me.col_num_clasif.Name = "col_num_clasif"
            Me.col_num_clasif.ReadOnly = True
            Me.col_num_clasif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_clasif.Width = 60
            '
            'col_nom_fic
            '
            Me.col_nom_fic.DataPropertyName = "FichaNombres"
            Me.col_nom_fic.HeaderText = "Ficha"
            Me.col_nom_fic.MinimumWidth = 250
            Me.col_nom_fic.Name = "col_nom_fic"
            Me.col_nom_fic.ReadOnly = True
            Me.col_nom_fic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_nom_fic.Width = 250
            '
            'col_fec_cla
            '
            Me.col_fec_cla.DataPropertyName = "FechaClasificacionDate"
            Me.col_fec_cla.HeaderText = "F. Clasificación"
            Me.col_fec_cla.Name = "col_fec_cla"
            Me.col_fec_cla.ReadOnly = True
            Me.col_fec_cla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'col_ptje
            '
            Me.col_ptje.DataPropertyName = "Puntaje"
            Me.col_ptje.HeaderText = "Puntaje"
            Me.col_ptje.Name = "col_ptje"
            Me.col_ptje.ReadOnly = True
            Me.col_ptje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ptje.Width = 50
            '
            'col_id_cat
            '
            Me.col_id_cat.DataPropertyName = "CategoriaFichaId"
            Me.col_id_cat.HeaderText = "CategoriaID"
            Me.col_id_cat.Name = "col_id_cat"
            Me.col_id_cat.ReadOnly = True
            Me.col_id_cat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_id_cat.Visible = False
            '
            'col_cat_nom
            '
            Me.col_cat_nom.DataPropertyName = "CategoriaFichaNombre"
            Me.col_cat_nom.HeaderText = "Categoria"
            Me.col_cat_nom.Name = "col_cat_nom"
            Me.col_cat_nom.ReadOnly = True
            Me.col_cat_nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_cat_nom.Visible = False
            Me.col_cat_nom.Width = 300
            '
            'col_fic_fin
            '
            Me.col_fic_fin.HeaderText = "Ficha Final"
            Me.col_fic_fin.Name = "col_fic_fin"
            Me.col_fic_fin.ReadOnly = True
            Me.col_fic_fin.Visible = False
            Me.col_fic_fin.Width = 70
            '
            'col_estado
            '
            Me.col_estado.DataPropertyName = "EstadoNombre"
            Me.col_estado.HeaderText = "Estado"
            Me.col_estado.Name = "col_estado"
            Me.col_estado.ReadOnly = True
            Me.col_estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_estado.Width = 120
            '
            'col_estado_id
            '
            Me.col_estado_id.DataPropertyName = "Estado"
            Me.col_estado_id.HeaderText = "EstadoId"
            Me.col_estado_id.Name = "col_estado_id"
            Me.col_estado_id.ReadOnly = True
            Me.col_estado_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_estado_id.Visible = False
            '
            'col_fic_id2
            '
            Me.col_fic_id2.DataPropertyName = "FichaId"
            Me.col_fic_id2.HeaderText = "FichaID"
            Me.col_fic_id2.Name = "col_fic_id2"
            Me.col_fic_id2.ReadOnly = True
            Me.col_fic_id2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_fic_id2.Visible = False
            '
            'col_obs
            '
            Me.col_obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_obs.DataPropertyName = "Observacion"
            Me.col_obs.HeaderText = "Observacion"
            Me.col_obs.Name = "col_obs"
            Me.col_obs.ReadOnly = True
            Me.col_obs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_obs.Visible = False
            '
            'col_sit_jur
            '
            Me.col_sit_jur.DataPropertyName = "InternoSituacionJuridicaId"
            Me.col_sit_jur.HeaderText = "SitJurId"
            Me.col_sit_jur.Name = "col_sit_jur"
            Me.col_sit_jur.ReadOnly = True
            Me.col_sit_jur.Visible = False
            '
            'col_regimen_id
            '
            Me.col_regimen_id.DataPropertyName = "RegimenPenalId"
            Me.col_regimen_id.HeaderText = "Regimen"
            Me.col_regimen_id.Name = "col_regimen_id"
            Me.col_regimen_id.ReadOnly = True
            Me.col_regimen_id.Visible = False
            '
            'pnlIzqAdd
            '
            Me.pnlIzqAdd.Controls.Add(Me.btnRefresh)
            Me.pnlIzqAdd.Controls.Add(Me.btnPrint)
            Me.pnlIzqAdd.Controls.Add(Me.btnBloqDesbloq)
            Me.pnlIzqAdd.Controls.Add(Me.btnEliminar)
            Me.pnlIzqAdd.Controls.Add(Me.btnAgregar)
            Me.pnlIzqAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlIzqAdd.Location = New System.Drawing.Point(943, 0)
            Me.pnlIzqAdd.Name = "pnlIzqAdd"
            Me.pnlIzqAdd.Size = New System.Drawing.Size(38, 184)
            Me.pnlIzqAdd.TabIndex = 89
            '
            'btnRefresh
            '
            Me.btnRefresh.BackgroundImage = Global.APPControls.My.Resources.Resources.replace2
            Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnRefresh.Location = New System.Drawing.Point(0, 136)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(38, 34)
            Me.btnRefresh.TabIndex = 96
            Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refrescar lista de fichas, permite ver las fichas de los demás.")
            Me.btnRefresh.UseVisualStyleBackColor = True
            '
            'btnPrint
            '
            Me.btnPrint.BackgroundImage = Global.APPControls.My.Resources.Resources.printer3
            Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnPrint.Location = New System.Drawing.Point(0, 102)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(38, 34)
            Me.btnPrint.TabIndex = 94
            Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnPrint, "Imprimir ficha")
            Me.btnPrint.UseVisualStyleBackColor = True
            '
            'btnBloqDesbloq
            '
            Me.btnBloqDesbloq.BackgroundImage = Global.APPControls.My.Resources.Resources.Desbloquear
            Me.btnBloqDesbloq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBloqDesbloq.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnBloqDesbloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBloqDesbloq.Location = New System.Drawing.Point(0, 68)
            Me.btnBloqDesbloq.Name = "btnBloqDesbloq"
            Me.btnBloqDesbloq.Size = New System.Drawing.Size(38, 34)
            Me.btnBloqDesbloq.TabIndex = 95
            Me.btnBloqDesbloq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnBloqDesbloq, "Finalizar/Desbloquear ficha")
            '
            'btnEliminar
            '
            Me.btnEliminar.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Location = New System.Drawing.Point(0, 34)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(38, 34)
            Me.btnEliminar.TabIndex = 90
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnEliminar, "Eliminar ficha seleccionada")
            '
            'btnAgregar
            '
            Me.btnAgregar.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Location = New System.Drawing.Point(0, 0)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(38, 34)
            Me.btnAgregar.TabIndex = 88
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnAgregar, "Agregar una nueva clasificación")
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnImprimirF06)
            Me.Panel1.Controls.Add(Me.btnFormato06_psicologica)
            Me.Panel1.Controls.Add(Me.btnFormato06_social)
            Me.Panel1.Controls.Add(Me.btnFormato06_legal)
            Me.Panel1.Controls.Add(Me.cmdCancel)
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(942, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.Panel1.Size = New System.Drawing.Size(39, 326)
            Me.Panel1.TabIndex = 96
            '
            'btnImprimirF06
            '
            Me.btnImprimirF06.BackgroundImage = Global.APPControls.My.Resources.Resources.printer3
            Me.btnImprimirF06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnImprimirF06.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnImprimirF06.Location = New System.Drawing.Point(0, 205)
            Me.btnImprimirF06.Name = "btnImprimirF06"
            Me.btnImprimirF06.Size = New System.Drawing.Size(39, 37)
            Me.btnImprimirF06.TabIndex = 97
            Me.ToolTip1.SetToolTip(Me.btnImprimirF06, "Imprimir formato 06")
            Me.btnImprimirF06.UseVisualStyleBackColor = True
            '
            'btnFormato06_psicologica
            '
            Me.btnFormato06_psicologica.BackgroundImage = Global.APPControls.My.Resources.Resources.detalle_32x32
            Me.btnFormato06_psicologica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnFormato06_psicologica.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnFormato06_psicologica.Location = New System.Drawing.Point(0, 168)
            Me.btnFormato06_psicologica.Name = "btnFormato06_psicologica"
            Me.btnFormato06_psicologica.Size = New System.Drawing.Size(39, 37)
            Me.btnFormato06_psicologica.TabIndex = 96
            Me.ToolTip1.SetToolTip(Me.btnFormato06_psicologica, "Formato06 área psicológica")
            Me.btnFormato06_psicologica.UseVisualStyleBackColor = True
            Me.btnFormato06_psicologica.Visible = False
            '
            'btnFormato06_social
            '
            Me.btnFormato06_social.BackgroundImage = Global.APPControls.My.Resources.Resources.detalle_32x32
            Me.btnFormato06_social.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnFormato06_social.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnFormato06_social.Location = New System.Drawing.Point(0, 131)
            Me.btnFormato06_social.Name = "btnFormato06_social"
            Me.btnFormato06_social.Size = New System.Drawing.Size(39, 37)
            Me.btnFormato06_social.TabIndex = 95
            Me.ToolTip1.SetToolTip(Me.btnFormato06_social, "Formato06 área social")
            Me.btnFormato06_social.UseVisualStyleBackColor = True
            Me.btnFormato06_social.Visible = False
            '
            'btnFormato06_legal
            '
            Me.btnFormato06_legal.BackgroundImage = Global.APPControls.My.Resources.Resources.detalle_32x32
            Me.btnFormato06_legal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnFormato06_legal.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnFormato06_legal.Location = New System.Drawing.Point(0, 94)
            Me.btnFormato06_legal.Name = "btnFormato06_legal"
            Me.btnFormato06_legal.Size = New System.Drawing.Size(39, 37)
            Me.btnFormato06_legal.TabIndex = 94
            Me.ToolTip1.SetToolTip(Me.btnFormato06_legal, "Formato06 área legal")
            Me.btnFormato06_legal.UseVisualStyleBackColor = True
            Me.btnFormato06_legal.Visible = False
            '
            'cmdCancel
            '
            Me.cmdCancel.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
            Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.cmdCancel.Dock = System.Windows.Forms.DockStyle.Top
            Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cmdCancel.Location = New System.Drawing.Point(0, 57)
            Me.cmdCancel.Name = "cmdCancel"
            Me.cmdCancel.Size = New System.Drawing.Size(39, 37)
            Me.cmdCancel.TabIndex = 93
            Me.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.cmdCancel, "Cancelar modificación de registro")
            '
            'btnAceptar
            '
            Me.btnAceptar.BackgroundImage = Global.APPControls.My.Resources.Resources.Diskette_32x32
            Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Location = New System.Drawing.Point(0, 20)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(39, 37)
            Me.btnAceptar.TabIndex = 91
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnAceptar, "Guardar cambios")
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dgvFichaVariables)
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(942, 326)
            Me.Panel2.TabIndex = 90
            '
            'dgvFichaVariables
            '
            Me.dgvFichaVariables.AllowUserToAddRows = False
            Me.dgvFichaVariables.AllowUserToDeleteRows = False
            Me.dgvFichaVariables.AllowUserToResizeRows = False
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvFichaVariables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvFichaVariables.BackgroundColor = System.Drawing.Color.White
            Me.dgvFichaVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFichaVariables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvFichaVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvFichaVariables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fic_det_id, Me.col_mae_var_id, Me.col_fic_id, Me.DataGridViewTextBoxColumn4, Me.col_val_nom, Me.col_val_id_sel, Me.col_valor, Me.col_ptje_noprev, Me.col_ptje2, Me.col_buton})
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvFichaVariables.DefaultCellStyle = DataGridViewCellStyle11
            Me.dgvFichaVariables.Dock = System.Windows.Forms.DockStyle.Top
            Me.dgvFichaVariables.GridColor = System.Drawing.Color.SkyBlue
            Me.dgvFichaVariables.Location = New System.Drawing.Point(0, 0)
            Me.dgvFichaVariables.MultiSelect = False
            Me.dgvFichaVariables.Name = "dgvFichaVariables"
            Me.dgvFichaVariables.ReadOnly = True
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
            DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvFichaVariables.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            Me.dgvFichaVariables.RowHeadersVisible = False
            DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvFichaVariables.RowsDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvFichaVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvFichaVariables.Size = New System.Drawing.Size(942, 177)
            Me.dgvFichaVariables.TabIndex = 18
            '
            'col_fic_det_id
            '
            Me.col_fic_det_id.HeaderText = "FicDetId"
            Me.col_fic_det_id.Name = "col_fic_det_id"
            Me.col_fic_det_id.ReadOnly = True
            Me.col_fic_det_id.Visible = False
            '
            'col_mae_var_id
            '
            Me.col_mae_var_id.DataPropertyName = "Codigo"
            Me.col_mae_var_id.HeaderText = "MaeVariableId"
            Me.col_mae_var_id.MinimumWidth = 20
            Me.col_mae_var_id.Name = "col_mae_var_id"
            Me.col_mae_var_id.ReadOnly = True
            Me.col_mae_var_id.Visible = False
            Me.col_mae_var_id.Width = 80
            '
            'col_fic_id
            '
            Me.col_fic_id.DataPropertyName = "FichaId"
            Me.col_fic_id.HeaderText = "FichaId"
            Me.col_fic_id.Name = "col_fic_id"
            Me.col_fic_id.ReadOnly = True
            Me.col_fic_id.Visible = False
            Me.col_fic_id.Width = 50
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumeroOrdenString"
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
            Me.DataGridViewTextBoxColumn4.HeaderText = "N°"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.ReadOnly = True
            Me.DataGridViewTextBoxColumn4.Width = 35
            '
            'col_val_nom
            '
            Me.col_val_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            Me.col_val_nom.DataPropertyName = "Nombre"
            Me.col_val_nom.HeaderText = "Variables"
            Me.col_val_nom.MinimumWidth = 200
            Me.col_val_nom.Name = "col_val_nom"
            Me.col_val_nom.ReadOnly = True
            Me.col_val_nom.Width = 200
            '
            'col_val_id_sel
            '
            Me.col_val_id_sel.HeaderText = "Val_id_Select"
            Me.col_val_id_sel.Name = "col_val_id_sel"
            Me.col_val_id_sel.ReadOnly = True
            Me.col_val_id_sel.Visible = False
            Me.col_val_id_sel.Width = 30
            '
            'col_valor
            '
            Me.col_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_valor.DefaultCellStyle = DataGridViewCellStyle8
            Me.col_valor.HeaderText = "Indicador seleccionado"
            Me.col_valor.Name = "col_valor"
            Me.col_valor.ReadOnly = True
            '
            'col_ptje_noprev
            '
            Me.col_ptje_noprev.DataPropertyName = "PuntajeNoPrevisto"
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.NullValue = "0"
            Me.col_ptje_noprev.DefaultCellStyle = DataGridViewCellStyle9
            Me.col_ptje_noprev.HeaderText = "NoPrevisto"
            Me.col_ptje_noprev.Name = "col_ptje_noprev"
            Me.col_ptje_noprev.ReadOnly = True
            Me.col_ptje_noprev.Width = 65
            '
            'col_ptje2
            '
            Me.col_ptje2.DataPropertyName = "Puntaje"
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.NullValue = "0"
            Me.col_ptje2.DefaultCellStyle = DataGridViewCellStyle10
            Me.col_ptje2.HeaderText = "Puntaje"
            Me.col_ptje2.Name = "col_ptje2"
            Me.col_ptje2.ReadOnly = True
            Me.col_ptje2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_ptje2.Width = 50
            '
            'col_buton
            '
            Me.col_buton.HeaderText = ""
            Me.col_buton.Name = "col_buton"
            Me.col_buton.ReadOnly = True
            Me.col_buton.Text = "---"
            Me.col_buton.UseColumnTextForButtonValue = True
            Me.col_buton.Visible = False
            Me.col_buton.Width = 60
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.gbDetalle)
            Me.Panel3.Controls.Add(Me.gbUbicacion)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel3.Location = New System.Drawing.Point(0, 183)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(942, 143)
            Me.Panel3.TabIndex = 20
            '
            'gbDetalle
            '
            Me.gbDetalle.Controls.Add(Me.dtpHoraETAPA)
            Me.gbDetalle.Controls.Add(Me.cboSitJuridica)
            Me.gbDetalle.Controls.Add(Me.Label9)
            Me.gbDetalle.Controls.Add(Me.txtobservacion)
            Me.gbDetalle.Controls.Add(Me.txtCategoria)
            Me.gbDetalle.Controls.Add(Me.txtNumClasificacion)
            Me.gbDetalle.Controls.Add(Me.lblPuntaje)
            Me.gbDetalle.Controls.Add(Me.Label5)
            Me.gbDetalle.Controls.Add(Me.dtpFecha)
            Me.gbDetalle.Controls.Add(Me.txtPuntTotal)
            Me.gbDetalle.Controls.Add(Me.Label3)
            Me.gbDetalle.Controls.Add(Me.Label1)
            Me.gbDetalle.Controls.Add(Me.lblDocIdent)
            Me.gbDetalle.Controls.Add(Me.Label8)
            Me.gbDetalle.Controls.Add(Me.lblNacionalidad)
            Me.gbDetalle.Controls.Add(Me.txtNumDni)
            Me.gbDetalle.Controls.Add(Me.lblSexo)
            Me.gbDetalle.Controls.Add(Me.Label6)
            Me.gbDetalle.Controls.Add(Me.Label2)
            Me.gbDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbDetalle.Location = New System.Drawing.Point(0, 60)
            Me.gbDetalle.Name = "gbDetalle"
            Me.gbDetalle.Size = New System.Drawing.Size(942, 83)
            Me.gbDetalle.TabIndex = 17
            Me.gbDetalle.TabStop = False
            '
            'dtpHoraETAPA
            '
            Me.dtpHoraETAPA.CustomFormat = "hh:mm tt"
            Me.dtpHoraETAPA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpHoraETAPA.Location = New System.Drawing.Point(135, 9)
            Me.dtpHoraETAPA.Name = "dtpHoraETAPA"
            Me.dtpHoraETAPA.ShowUpDown = True
            Me.dtpHoraETAPA.Size = New System.Drawing.Size(81, 20)
            Me.dtpHoraETAPA.TabIndex = 48
            Me.dtpHoraETAPA.Value = New Date(2023, 11, 16, 0, 0, 0, 0)
            '
            'cboSitJuridica
            '
            Me.cboSitJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSitJuridica.FormattingEnabled = True
            Me.cboSitJuridica.Items.AddRange(New Object() {"[--SELECCIONE--]", "PROCESADO", "SENTENCIADO"})
            Me.cboSitJuridica.Location = New System.Drawing.Point(49, 55)
            Me.cboSitJuridica.Name = "cboSitJuridica"
            Me.cboSitJuridica.Size = New System.Drawing.Size(104, 21)
            Me.cboSitJuridica.TabIndex = 27
            Me.cboSitJuridica.Visible = False
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(1, 60)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(45, 13)
            Me.Label9.TabIndex = 26
            Me.Label9.Text = "Sit. Jur.:"
            Me.Label9.Visible = False
            '
            'txtobservacion
            '
            Me.txtobservacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtobservacion._BloquearPaste = False
            Me.txtobservacion._SeleccionarTodo = False
            Me.txtobservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtobservacion.Location = New System.Drawing.Point(473, 35)
            Me.txtobservacion.MaxLength = 2000
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtobservacion.Size = New System.Drawing.Size(468, 46)
            Me.txtobservacion.TabIndex = 8
            Me.txtobservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtCategoria
            '
            Me.txtCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCategoria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCategoria.Location = New System.Drawing.Point(473, 10)
            Me.txtCategoria.Name = "txtCategoria"
            Me.txtCategoria.ReadOnly = True
            Me.txtCategoria.Size = New System.Drawing.Size(330, 20)
            Me.txtCategoria.TabIndex = 2
            Me.txtCategoria.Visible = False
            '
            'txtNumClasificacion
            '
            Me.txtNumClasificacion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumClasificacion._BloquearPaste = False
            Me.txtNumClasificacion._SeleccionarTodo = False
            Me.txtNumClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumClasificacion.Location = New System.Drawing.Point(327, 9)
            Me.txtNumClasificacion.MaxLength = 2
            Me.txtNumClasificacion.Name = "txtNumClasificacion"
            Me.txtNumClasificacion.ReadOnly = True
            Me.txtNumClasificacion.Size = New System.Drawing.Size(69, 21)
            Me.txtNumClasificacion.TabIndex = 22
            Me.txtNumClasificacion.Text = "0"
            Me.txtNumClasificacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumClasificacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblPuntaje
            '
            Me.lblPuntaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblPuntaje.AutoSize = True
            Me.lblPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPuntaje.Location = New System.Drawing.Point(802, 13)
            Me.lblPuntaje.Name = "lblPuntaje"
            Me.lblPuntaje.Size = New System.Drawing.Size(83, 13)
            Me.lblPuntaje.TabIndex = 0
            Me.lblPuntaje.Text = "Puntaje total:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(405, 12)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 13)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Categoria:"
            Me.Label5.Visible = False
            '
            'dtpFecha
            '
            Me.dtpFecha.Location = New System.Drawing.Point(49, 9)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecha.TabIndex = 3
            Me.dtpFecha.Value = "/  /"
            Me.dtpFecha.ValueLong = CType(0, Long)
            '
            'txtPuntTotal
            '
            Me.txtPuntTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPuntTotal.BackColor = System.Drawing.Color.WhiteSmoke
            Me.txtPuntTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPuntTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPuntTotal.Location = New System.Drawing.Point(887, 9)
            Me.txtPuntTotal.Name = "txtPuntTotal"
            Me.txtPuntTotal.ReadOnly = True
            Me.txtPuntTotal.Size = New System.Drawing.Size(53, 21)
            Me.txtPuntTotal.TabIndex = 2
            Me.txtPuntTotal.Text = "0"
            Me.txtPuntTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(397, 36)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(73, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Observación :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(239, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 13)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "N° Clasificación:"
            '
            'lblDocIdent
            '
            Me.lblDocIdent.Location = New System.Drawing.Point(183, 58)
            Me.lblDocIdent.Name = "lblDocIdent"
            Me.lblDocIdent.Size = New System.Drawing.Size(45, 13)
            Me.lblDocIdent.TabIndex = 2
            Me.lblDocIdent.Text = "DNI:"
            Me.lblDocIdent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(155, 35)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(72, 13)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Nacionalidad:"
            '
            'lblNacionalidad
            '
            Me.lblNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNacionalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblNacionalidad.Location = New System.Drawing.Point(230, 34)
            Me.lblNacionalidad.Name = "lblNacionalidad"
            Me.lblNacionalidad.Size = New System.Drawing.Size(166, 18)
            Me.lblNacionalidad.TabIndex = 2
            Me.lblNacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtNumDni
            '
            Me.txtNumDni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.txtNumDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.txtNumDni.Location = New System.Drawing.Point(230, 58)
            Me.txtNumDni.Name = "txtNumDni"
            Me.txtNumDni.Size = New System.Drawing.Size(166, 18)
            Me.txtNumDni.TabIndex = 2
            Me.txtNumDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblSexo
            '
            Me.lblSexo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblSexo.Location = New System.Drawing.Point(49, 34)
            Me.lblSexo.Name = "lblSexo"
            Me.lblSexo.Size = New System.Drawing.Size(104, 19)
            Me.lblSexo.TabIndex = 2
            Me.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(12, 35)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(34, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Sexo:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(6, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Fecha:"
            '
            'gbUbicacion
            '
            Me.gbUbicacion.Controls.Add(Me.lblModificadoPor)
            Me.gbUbicacion.Controls.Add(Me.btnCancelPenal)
            Me.gbUbicacion.Controls.Add(Me.btnEdiPenal)
            Me.gbUbicacion.Controls.Add(Me.cbbRegimenPenal)
            Me.gbUbicacion.Controls.Add(Me.Label4)
            Me.gbUbicacion.Controls.Add(Me.cbbPenalDestino)
            Me.gbUbicacion.Controls.Add(Me.cbbRegionDestino)
            Me.gbUbicacion.Controls.Add(Me.Label11)
            Me.gbUbicacion.Controls.Add(Me.Label7)
            Me.gbUbicacion.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbUbicacion.Location = New System.Drawing.Point(0, 0)
            Me.gbUbicacion.Name = "gbUbicacion"
            Me.gbUbicacion.Size = New System.Drawing.Size(942, 60)
            Me.gbUbicacion.TabIndex = 19
            Me.gbUbicacion.TabStop = False
            Me.gbUbicacion.Text = "UBICACION DESTINO"
            '
            'lblModificadoPor
            '
            Me.lblModificadoPor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblModificadoPor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblModificadoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblModificadoPor.Location = New System.Drawing.Point(57, 40)
            Me.lblModificadoPor.Name = "lblModificadoPor"
            Me.lblModificadoPor.Size = New System.Drawing.Size(882, 17)
            Me.lblModificadoPor.TabIndex = 16
            '
            'btnCancelPenal
            '
            Me.btnCancelPenal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancelPenal.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnCancelPenal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCancelPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelPenal.Location = New System.Drawing.Point(911, 10)
            Me.btnCancelPenal.Name = "btnCancelPenal"
            Me.btnCancelPenal.Size = New System.Drawing.Size(30, 28)
            Me.btnCancelPenal.TabIndex = 15
            Me.ToolTip1.SetToolTip(Me.btnCancelPenal, "Cancela la modificación manual del penal y régimen.")
            Me.btnCancelPenal.UseVisualStyleBackColor = True
            '
            'btnEdiPenal
            '
            Me.btnEdiPenal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEdiPenal.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEdiPenal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEdiPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEdiPenal.Location = New System.Drawing.Point(882, 10)
            Me.btnEdiPenal.Name = "btnEdiPenal"
            Me.btnEdiPenal.Size = New System.Drawing.Size(30, 28)
            Me.btnEdiPenal.TabIndex = 14
            Me.ToolTip1.SetToolTip(Me.btnEdiPenal, "Permite modificar el régimen y el penal del destino de forma manual")
            Me.btnEdiPenal.UseVisualStyleBackColor = True
            '
            'cbbRegimenPenal
            '
            Me.cbbRegimenPenal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbRegimenPenal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimenPenal.Enabled = False
            Me.cbbRegimenPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimenPenal.Location = New System.Drawing.Point(679, 13)
            Me.cbbRegimenPenal.Name = "cbbRegimenPenal"
            Me.cbbRegimenPenal.Size = New System.Drawing.Size(202, 23)
            Me.cbbRegimenPenal.TabIndex = 0
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(623, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(52, 13)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Régimen:"
            '
            'cbbPenalDestino
            '
            Me.cbbPenalDestino._NoIndica = False
            Me.cbbPenalDestino._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenalDestino._Todos = False
            Me.cbbPenalDestino._TodosMensaje = ""
            Me.cbbPenalDestino._Visible_Add = False
            Me.cbbPenalDestino._Visible_Buscar = False
            Me.cbbPenalDestino._Visible_Eliminar = False
            Me.cbbPenalDestino.CodigoPadre = -1
            Me.cbbPenalDestino.ComboTipo = CType(36, Short)
            Me.cbbPenalDestino.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenalDestino.DropDownWidth = 238
            Me.cbbPenalDestino.DropDownWidthAuto = False
            Me.cbbPenalDestino.Enabled = False
            Me.cbbPenalDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenalDestino.ForeColor = System.Drawing.Color.Black
            Me.cbbPenalDestino.ListaIdsParaExcluir = Nothing
            Me.cbbPenalDestino.Location = New System.Drawing.Point(362, 13)
            Me.cbbPenalDestino.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbPenalDestino.ModuloTratamiento = False
            Me.cbbPenalDestino.Name = "cbbPenalDestino"
            Me.cbbPenalDestino.Parametro1 = -1
            Me.cbbPenalDestino.Parametro2 = -1
            Me.cbbPenalDestino.SelectedIndex = -1
            Me.cbbPenalDestino.SelectedValue = 0
            Me.cbbPenalDestino.Size = New System.Drawing.Size(252, 22)
            Me.cbbPenalDestino.TabIndex = 11
            Me.cbbPenalDestino.verToolTipItemSeleccionado = False
            '
            'cbbRegionDestino
            '
            Me.cbbRegionDestino._NoIndica = False
            Me.cbbRegionDestino._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegionDestino._Todos = False
            Me.cbbRegionDestino._TodosMensaje = ""
            Me.cbbRegionDestino._Visible_Add = False
            Me.cbbRegionDestino._Visible_Buscar = False
            Me.cbbRegionDestino._Visible_Eliminar = False
            Me.cbbRegionDestino.CodigoPadre = -1
            Me.cbbRegionDestino.ComboTipo = CType(37, Short)
            Me.cbbRegionDestino.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegionDestino.DropDownWidth = 178
            Me.cbbRegionDestino.DropDownWidthAuto = False
            Me.cbbRegionDestino.Enabled = False
            Me.cbbRegionDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegionDestino.ForeColor = System.Drawing.Color.Black
            Me.cbbRegionDestino.ListaIdsParaExcluir = Nothing
            Me.cbbRegionDestino.Location = New System.Drawing.Point(57, 13)
            Me.cbbRegionDestino.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbRegionDestino.ModuloTratamiento = False
            Me.cbbRegionDestino.Name = "cbbRegionDestino"
            Me.cbbRegionDestino.Parametro1 = -1
            Me.cbbRegionDestino.Parametro2 = -1
            Me.cbbRegionDestino.SelectedIndex = -1
            Me.cbbRegionDestino.SelectedValue = 0
            Me.cbbRegionDestino.Size = New System.Drawing.Size(252, 22)
            Me.cbbRegionDestino.TabIndex = 10
            Me.cbbRegionDestino.verToolTipItemSeleccionado = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(320, 19)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(37, 13)
            Me.Label11.TabIndex = 7
            Me.Label11.Text = "Penal:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(9, 19)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(44, 13)
            Me.Label7.TabIndex = 7
            Me.Label7.Text = "Región:"
            '
            'pnlSuperior
            '
            Me.pnlSuperior.Controls.Add(Me.dgwGrillaFicha)
            Me.pnlSuperior.Controls.Add(Me.pnlIzqAdd)
            Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
            Me.pnlSuperior.Name = "pnlSuperior"
            Me.pnlSuperior.Size = New System.Drawing.Size(981, 184)
            Me.pnlSuperior.TabIndex = 91
            '
            'pnlDetalle
            '
            Me.pnlDetalle.Controls.Add(Me.Panel2)
            Me.pnlDetalle.Controls.Add(Me.Panel1)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 184)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(981, 326)
            Me.pnlDetalle.TabIndex = 92
            '
            'uscClasificaciones_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlSuperior)
            Me.Name = "uscClasificaciones_v2"
            Me.Size = New System.Drawing.Size(981, 510)
            CType(Me.dgwGrillaFicha, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlIzqAdd.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            CType(Me.dgvFichaVariables, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.gbDetalle.ResumeLayout(False)
            Me.gbDetalle.PerformLayout()
            Me.gbUbicacion.ResumeLayout(False)
            Me.gbUbicacion.PerformLayout()
            Me.pnlSuperior.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrillaFicha As System.Windows.Forms.DataGridView
        Friend WithEvents pnlIzqAdd As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents cmdCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents btnBloqDesbloq As System.Windows.Forms.Button
        Friend WithEvents btnPrint As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents gbUbicacion As System.Windows.Forms.GroupBox
        Friend WithEvents cbbRegimenPenal As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbPenalDestino As APPControls.uscComboParametrica
        Friend WithEvents cbbRegionDestino As APPControls.uscComboParametrica
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumClasificacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblPuntaje As System.Windows.Forms.Label
        Friend WithEvents txtobservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
        Friend WithEvents txtPuntTotal As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlSuperior As System.Windows.Forms.Panel
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
        Friend WithEvents lblSexo As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents btnCancelPenal As System.Windows.Forms.Button
        Friend WithEvents btnEdiPenal As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents lblModificadoPor As System.Windows.Forms.Label
        Friend WithEvents dgvFichaVariables As System.Windows.Forms.DataGridView
        Friend WithEvents btnRefresh As System.Windows.Forms.Button
        Friend WithEvents col_fic_det_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mae_var_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fic_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_val_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_val_id_sel As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_valor As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ptje_noprev As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ptje2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_buton As System.Windows.Forms.DataGridViewButtonColumn
        Friend WithEvents txtNumDni As Label
        Friend WithEvents lblDocIdent As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents cboSitJuridica As ComboBox
        Friend WithEvents btnFormato06_psicologica As Button
        Friend WithEvents btnFormato06_social As Button
        Friend WithEvents btnFormato06_legal As Button
        Friend WithEvents btnImprimirF06 As Button
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents tip_fic_id As DataGridViewTextBoxColumn
        Friend WithEvents col_num_clasif As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_fic As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_cla As DataGridViewTextBoxColumn
        Friend WithEvents col_ptje As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cat As DataGridViewTextBoxColumn
        Friend WithEvents col_cat_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_fic_fin As DataGridViewCheckBoxColumn
        Friend WithEvents col_estado As DataGridViewTextBoxColumn
        Friend WithEvents col_estado_id As DataGridViewTextBoxColumn
        Friend WithEvents col_fic_id2 As DataGridViewTextBoxColumn
        Friend WithEvents col_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur As DataGridViewTextBoxColumn
        Friend WithEvents col_regimen_id As DataGridViewTextBoxColumn
        Friend WithEvents dtpHoraETAPA As DateTimePicker
    End Class
End Namespace