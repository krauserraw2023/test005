Namespace Registro.Documento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscExpeDeResolucionIng
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_anulacion = New System.Windows.Forms.DataGridViewImageColumn()
            Me.colEliminarDelito = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlDelitoPermisos = New System.Windows.Forms.Panel()
            Me.pnlEscrituraDelito = New System.Windows.Forms.Panel()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.btnAddDelito = New System.Windows.Forms.Button()
            Me.pnlEliminarDelito = New System.Windows.Forms.Panel()
            Me.btnDelDelito = New System.Windows.Forms.Button()
            Me.lblExpedienteReferenciado = New System.Windows.Forms.Label()
            Me.lblNrodelitos = New System.Windows.Forms.Label()
            Me.dgwAgraviados = New Legolas.APPUIComponents.myDatagridView()
            Me.col_agr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nom_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_delito_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pnlAgravPermisos = New System.Windows.Forms.Panel()
            Me.pnlEscrituraAgrav = New System.Windows.Forms.Panel()
            Me.btnEditAgrav = New System.Windows.Forms.Button()
            Me.btnAddAgrav = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelAgrav = New System.Windows.Forms.Button()
            Me.lblNroAgraviados = New System.Windows.Forms.Label()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.pnlCabExpediente = New System.Windows.Forms.Panel()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_exp_ref_val = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sit_jur = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mot_que_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mot_que = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_lib_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_lib = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_tip_aut = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_juez_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_id_tip_imim = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cen_sal_men = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlExpePermisos = New System.Windows.Forms.Panel()
            Me.pnlEscrituraExpe = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.pnlEliminarExpe = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.lblEstablecimientomental2 = New System.Windows.Forms.Label()
            Me.btnInimputable2 = New System.Windows.Forms.Button()
            Me.pnlPeriodoCondena = New System.Windows.Forms.Panel()
            Me.pnlTiempoConde = New System.Windows.Forms.Panel()
            Me.gbComputo = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaFinal = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.pnlMantBotPeriCondena = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.gbDuracioncondena = New System.Windows.Forms.GroupBox()
            Me.rbCadenaperpetua = New System.Windows.Forms.RadioButton()
            Me.rbTemporal = New System.Windows.Forms.RadioButton()
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.pnlInimputable = New System.Windows.Forms.Panel()
            Me.lblEstablecimientomental = New System.Windows.Forms.Label()
            Me.btnInimputable = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.pnlDelitoPermisos.SuspendLayout()
            Me.pnlEscrituraDelito.SuspendLayout()
            Me.pnlEliminarDelito.SuspendLayout()
            CType(Me.dgwAgraviados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.pnlAgravPermisos.SuspendLayout()
            Me.pnlEscrituraAgrav.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel1.SuspendLayout()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            Me.pnlCabExpediente.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.pnlExpePermisos.SuspendLayout()
            Me.pnlEscrituraExpe.SuspendLayout()
            Me.pnlEliminarExpe.SuspendLayout()
            Me.pnlPeriodoCondena.SuspendLayout()
            Me.pnlTiempoConde.SuspendLayout()
            Me.gbComputo.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel4.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlMantBotPeriCondena.SuspendLayout()
            Me.gbDuracioncondena.SuspendLayout()
            Me.pnlInimputable.SuspendLayout()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.dgwDelito)
            Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.dgwAgraviados)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
            Me.SplitContainer1.Size = New System.Drawing.Size(876, 146)
            Me.SplitContainer1.SplitterDistance = 465
            Me.SplitContainer1.TabIndex = 0
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_nom, Me.col_del_esp_id, Me.col_del_gen_nom, Me.col_del_anulacion, Me.colEliminarDelito, Me.col_del_obs, Me.col_doc_jud_id})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 27)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            Me.dgwDelito.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwDelito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(465, 119)
            Me.dgwDelito.TabIndex = 1
            '
            'col_int_del_id
            '
            Me.col_int_del_id.DataPropertyName = "Codigo"
            Me.col_int_del_id.DividerWidth = 1
            Me.col_int_del_id.HeaderText = "InternoDelitoId"
            Me.col_int_del_id.Name = "col_int_del_id"
            Me.col_int_del_id.ReadOnly = True
            Me.col_int_del_id.Visible = False
            Me.col_int_del_id.Width = 50
            '
            'col_exp_id
            '
            Me.col_exp_id.DataPropertyName = "ExpedienteId"
            Me.col_exp_id.HeaderText = "ExpeId"
            Me.col_exp_id.Name = "col_exp_id"
            Me.col_exp_id.ReadOnly = True
            Me.col_exp_id.Visible = False
            Me.col_exp_id.Width = 40
            '
            'col_exp_item
            '
            Me.col_exp_item.DataPropertyName = "ExpedienteItem"
            Me.col_exp_item.HeaderText = "ExpedienteItem"
            Me.col_exp_item.Name = "col_exp_item"
            Me.col_exp_item.ReadOnly = True
            Me.col_exp_item.Visible = False
            Me.col_exp_item.Width = 20
            '
            'col_del_item
            '
            Me.col_del_item.DataPropertyName = "DelitoItem"
            Me.col_del_item.HeaderText = "DelitoItem"
            Me.col_del_item.Name = "col_del_item"
            Me.col_del_item.ReadOnly = True
            Me.col_del_item.Visible = False
            Me.col_del_item.Width = 20
            '
            'col_del_esp_nom
            '
            Me.col_del_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.HeaderText = "Delito Especifico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            '
            'col_del_esp_id
            '
            Me.col_del_esp_id.DataPropertyName = "DelitoEspecifico"
            Me.col_del_esp_id.HeaderText = "DelitoEspecificoID"
            Me.col_del_esp_id.Name = "col_del_esp_id"
            Me.col_del_esp_id.ReadOnly = True
            Me.col_del_esp_id.Visible = False
            Me.col_del_esp_id.Width = 40
            '
            'col_del_gen_nom
            '
            Me.col_del_gen_nom.DataPropertyName = "DelitoGenericoNombre"
            Me.col_del_gen_nom.HeaderText = "Delito Generico"
            Me.col_del_gen_nom.Name = "col_del_gen_nom"
            Me.col_del_gen_nom.ReadOnly = True
            Me.col_del_gen_nom.Width = 280
            '
            'col_del_anulacion
            '
            Me.col_del_anulacion.DataPropertyName = "EstadoImage"
            Me.col_del_anulacion.HeaderText = "Anul."
            Me.col_del_anulacion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_del_anulacion.Name = "col_del_anulacion"
            Me.col_del_anulacion.ReadOnly = True
            Me.col_del_anulacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_del_anulacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_del_anulacion.Visible = False
            Me.col_del_anulacion.Width = 30
            '
            'colEliminarDelito
            '
            Me.colEliminarDelito.DataPropertyName = "Eliminar"
            Me.colEliminarDelito.HeaderText = ""
            Me.colEliminarDelito.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.colEliminarDelito.Name = "colEliminarDelito"
            Me.colEliminarDelito.ReadOnly = True
            Me.colEliminarDelito.ToolTipText = "Eliminar Delito"
            Me.colEliminarDelito.Visible = False
            Me.colEliminarDelito.Width = 35
            '
            'col_del_obs
            '
            Me.col_del_obs.DataPropertyName = "Observacion"
            Me.col_del_obs.HeaderText = "Observacion"
            Me.col_del_obs.Name = "col_del_obs"
            Me.col_del_obs.ReadOnly = True
            Me.col_del_obs.Visible = False
            Me.col_del_obs.Width = 50
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "CreaDocJudicialId"
            Me.col_doc_jud_id.HeaderText = "DocJudID"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.ReadOnly = True
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 30
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlDelitoPermisos)
            Me.Panel2.Controls.Add(Me.lblExpedienteReferenciado)
            Me.Panel2.Controls.Add(Me.lblNrodelitos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(465, 27)
            Me.Panel2.TabIndex = 0
            '
            'pnlDelitoPermisos
            '
            Me.pnlDelitoPermisos.Controls.Add(Me.pnlEscrituraDelito)
            Me.pnlDelitoPermisos.Controls.Add(Me.pnlEliminarDelito)
            Me.pnlDelitoPermisos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlDelitoPermisos.Location = New System.Drawing.Point(346, 0)
            Me.pnlDelitoPermisos.Name = "pnlDelitoPermisos"
            Me.pnlDelitoPermisos.Size = New System.Drawing.Size(117, 25)
            Me.pnlDelitoPermisos.TabIndex = 2
            '
            'pnlEscrituraDelito
            '
            Me.pnlEscrituraDelito.Controls.Add(Me.btnEditDelito)
            Me.pnlEscrituraDelito.Controls.Add(Me.btnAddDelito)
            Me.pnlEscrituraDelito.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEscrituraDelito.Location = New System.Drawing.Point(23, 0)
            Me.pnlEscrituraDelito.Name = "pnlEscrituraDelito"
            Me.pnlEscrituraDelito.Size = New System.Drawing.Size(62, 25)
            Me.pnlEscrituraDelito.TabIndex = 2
            '
            'btnEditDelito
            '
            Me.btnEditDelito.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDelito.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditDelito.Location = New System.Drawing.Point(32, 0)
            Me.btnEditDelito.Name = "btnEditDelito"
            Me.btnEditDelito.Size = New System.Drawing.Size(30, 25)
            Me.btnEditDelito.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnEditDelito, "Modifica delitos y agraviados")
            Me.btnEditDelito.UseVisualStyleBackColor = True
            '
            'btnAddDelito
            '
            Me.btnAddDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddDelito.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAddDelito.Location = New System.Drawing.Point(0, 0)
            Me.btnAddDelito.Name = "btnAddDelito"
            Me.btnAddDelito.Size = New System.Drawing.Size(30, 25)
            Me.btnAddDelito.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnAddDelito, "Agrega delitos")
            Me.btnAddDelito.UseVisualStyleBackColor = True
            '
            'pnlEliminarDelito
            '
            Me.pnlEliminarDelito.Controls.Add(Me.btnDelDelito)
            Me.pnlEliminarDelito.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarDelito.Location = New System.Drawing.Point(85, 0)
            Me.pnlEliminarDelito.Name = "pnlEliminarDelito"
            Me.pnlEliminarDelito.Size = New System.Drawing.Size(32, 25)
            Me.pnlEliminarDelito.TabIndex = 3
            '
            'btnDelDelito
            '
            Me.btnDelDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnDelDelito.Location = New System.Drawing.Point(0, 0)
            Me.btnDelDelito.Name = "btnDelDelito"
            Me.btnDelDelito.Size = New System.Drawing.Size(32, 25)
            Me.btnDelDelito.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnDelDelito, "Eliminar delito seleccionado")
            Me.btnDelDelito.UseVisualStyleBackColor = True
            '
            'lblExpedienteReferenciado
            '
            Me.lblExpedienteReferenciado.AutoSize = True
            Me.lblExpedienteReferenciado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblExpedienteReferenciado.ForeColor = System.Drawing.Color.Red
            Me.lblExpedienteReferenciado.Location = New System.Drawing.Point(152, 6)
            Me.lblExpedienteReferenciado.Name = "lblExpedienteReferenciado"
            Me.lblExpedienteReferenciado.Size = New System.Drawing.Size(11, 13)
            Me.lblExpedienteReferenciado.TabIndex = 1
            Me.lblExpedienteReferenciado.Text = "-"
            Me.lblExpedienteReferenciado.Visible = False
            '
            'lblNrodelitos
            '
            Me.lblNrodelitos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblNrodelitos.AutoSize = True
            Me.lblNrodelitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNrodelitos.Location = New System.Drawing.Point(4, 6)
            Me.lblNrodelitos.Name = "lblNrodelitos"
            Me.lblNrodelitos.Size = New System.Drawing.Size(104, 13)
            Me.lblNrodelitos.TabIndex = 0
            Me.lblNrodelitos.Text = "Delito(s) : 0 Reg."
            '
            'dgwAgraviados
            '
            Me.dgwAgraviados.AllowUserToAddRows = False
            Me.dgwAgraviados.AllowUserToDeleteRows = False
            Me.dgwAgraviados.AllowUserToResizeRows = False
            Me.dgwAgraviados.BackgroundColor = System.Drawing.Color.White
            Me.dgwAgraviados.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAgraviados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwAgraviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwAgraviados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_agr_id, Me.col_agr_exp_item, Me.col_agr_del_item, Me.col_agr_item, Me.nom_agrav, Me.col_obs, Me.col_delito_id})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwAgraviados.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwAgraviados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwAgraviados.GridColor = System.Drawing.Color.LightGray
            Me.dgwAgraviados.Location = New System.Drawing.Point(0, 27)
            Me.dgwAgraviados.MultiSelect = False
            Me.dgwAgraviados.Name = "dgwAgraviados"
            Me.dgwAgraviados.ReadOnly = True
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAgraviados.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwAgraviados.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwAgraviados.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwAgraviados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwAgraviados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwAgraviados.Size = New System.Drawing.Size(407, 119)
            Me.dgwAgraviados.TabIndex = 1
            Me.dgwAgraviados.VisibleCampos = True
            '
            'col_agr_id
            '
            Me.col_agr_id.DataPropertyName = "Codigo"
            Me.col_agr_id.HeaderText = "AgraviadoId"
            Me.col_agr_id.Name = "col_agr_id"
            Me.col_agr_id.ReadOnly = True
            Me.col_agr_id.Visible = False
            Me.col_agr_id.Width = 40
            '
            'col_agr_exp_item
            '
            Me.col_agr_exp_item.DataPropertyName = "ExpedienteItem"
            Me.col_agr_exp_item.HeaderText = "ExpItem"
            Me.col_agr_exp_item.Name = "col_agr_exp_item"
            Me.col_agr_exp_item.ReadOnly = True
            Me.col_agr_exp_item.Visible = False
            Me.col_agr_exp_item.Width = 40
            '
            'col_agr_del_item
            '
            Me.col_agr_del_item.DataPropertyName = "DelitoItem"
            Me.col_agr_del_item.HeaderText = "DelitoItem"
            Me.col_agr_del_item.Name = "col_agr_del_item"
            Me.col_agr_del_item.ReadOnly = True
            Me.col_agr_del_item.Visible = False
            Me.col_agr_del_item.Width = 40
            '
            'col_agr_item
            '
            Me.col_agr_item.DataPropertyName = "AgraviadoItem"
            Me.col_agr_item.HeaderText = "AgraviadoItem"
            Me.col_agr_item.Name = "col_agr_item"
            Me.col_agr_item.ReadOnly = True
            Me.col_agr_item.Visible = False
            Me.col_agr_item.Width = 40
            '
            'nom_agrav
            '
            Me.nom_agrav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.nom_agrav.DataPropertyName = "AgraviadoNombre"
            Me.nom_agrav.HeaderText = "Nombre(s)"
            Me.nom_agrav.Name = "nom_agrav"
            Me.nom_agrav.ReadOnly = True
            '
            'col_obs
            '
            Me.col_obs.DataPropertyName = "Observacion"
            Me.col_obs.HeaderText = "Observación"
            Me.col_obs.Name = "col_obs"
            Me.col_obs.ReadOnly = True
            Me.col_obs.Visible = False
            '
            'col_delito_id
            '
            Me.col_delito_id.DataPropertyName = "DelitoID"
            Me.col_delito_id.HeaderText = "DelitoId"
            Me.col_delito_id.Name = "col_delito_id"
            Me.col_delito_id.ReadOnly = True
            Me.col_delito_id.Visible = False
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.pnlAgravPermisos)
            Me.Panel3.Controls.Add(Me.lblNroAgraviados)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(407, 27)
            Me.Panel3.TabIndex = 0
            '
            'pnlAgravPermisos
            '
            Me.pnlAgravPermisos.Controls.Add(Me.pnlEscrituraAgrav)
            Me.pnlAgravPermisos.Controls.Add(Me.pnlEliminarAgraviado)
            Me.pnlAgravPermisos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravPermisos.Location = New System.Drawing.Point(288, 0)
            Me.pnlAgravPermisos.Name = "pnlAgravPermisos"
            Me.pnlAgravPermisos.Size = New System.Drawing.Size(117, 25)
            Me.pnlAgravPermisos.TabIndex = 3
            '
            'pnlEscrituraAgrav
            '
            Me.pnlEscrituraAgrav.Controls.Add(Me.btnEditAgrav)
            Me.pnlEscrituraAgrav.Controls.Add(Me.btnAddAgrav)
            Me.pnlEscrituraAgrav.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEscrituraAgrav.Location = New System.Drawing.Point(25, 0)
            Me.pnlEscrituraAgrav.Name = "pnlEscrituraAgrav"
            Me.pnlEscrituraAgrav.Size = New System.Drawing.Size(61, 25)
            Me.pnlEscrituraAgrav.TabIndex = 1
            '
            'btnEditAgrav
            '
            Me.btnEditAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditAgrav.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditAgrav.Location = New System.Drawing.Point(31, 0)
            Me.btnEditAgrav.Name = "btnEditAgrav"
            Me.btnEditAgrav.Size = New System.Drawing.Size(30, 25)
            Me.btnEditAgrav.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnEditAgrav, "Modifica agraviado seleccionado.")
            Me.btnEditAgrav.UseVisualStyleBackColor = True
            '
            'btnAddAgrav
            '
            Me.btnAddAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddAgrav.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAddAgrav.Location = New System.Drawing.Point(0, 0)
            Me.btnAddAgrav.Name = "btnAddAgrav"
            Me.btnAddAgrav.Size = New System.Drawing.Size(30, 25)
            Me.btnAddAgrav.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnAddAgrav, "Agrega agraviados")
            Me.btnAddAgrav.UseVisualStyleBackColor = True
            '
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelAgrav)
            Me.pnlEliminarAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(86, 0)
            Me.pnlEliminarAgraviado.Name = "pnlEliminarAgraviado"
            Me.pnlEliminarAgraviado.Size = New System.Drawing.Size(31, 25)
            Me.pnlEliminarAgraviado.TabIndex = 2
            '
            'btnDelAgrav
            '
            Me.btnDelAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelAgrav.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnDelAgrav.Location = New System.Drawing.Point(0, 0)
            Me.btnDelAgrav.Name = "btnDelAgrav"
            Me.btnDelAgrav.Size = New System.Drawing.Size(31, 25)
            Me.btnDelAgrav.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnDelAgrav, "Eliminar agraviado seleccionado, completada la operación no podrá recuperarse")
            Me.btnDelAgrav.UseVisualStyleBackColor = True
            '
            'lblNroAgraviados
            '
            Me.lblNroAgraviados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblNroAgraviados.AutoSize = True
            Me.lblNroAgraviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroAgraviados.Location = New System.Drawing.Point(9, 6)
            Me.lblNroAgraviados.Name = "lblNroAgraviados"
            Me.lblNroAgraviados.Size = New System.Drawing.Size(120, 13)
            Me.lblNroAgraviados.TabIndex = 0
            Me.lblNroAgraviados.Text = "Agraviado(s) 0 Reg."
            '
            'SplitContainer2
            '
            Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer2.Name = "SplitContainer2"
            Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer2.Panel1
            '
            Me.SplitContainer2.Panel1.Controls.Add(Me.pnlCabExpediente)
            Me.SplitContainer2.Panel1.Controls.Add(Me.pnlPeriodoCondena)
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
            Me.SplitContainer2.Size = New System.Drawing.Size(876, 316)
            Me.SplitContainer2.SplitterDistance = 166
            Me.SplitContainer2.TabIndex = 0
            '
            'pnlCabExpediente
            '
            Me.pnlCabExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCabExpediente.Controls.Add(Me.dgwExpediente)
            Me.pnlCabExpediente.Controls.Add(Me.Panel5)
            Me.pnlCabExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCabExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabExpediente.Name = "pnlCabExpediente"
            Me.pnlCabExpediente.Size = New System.Drawing.Size(641, 166)
            Me.pnlCabExpediente.TabIndex = 2
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_exp_ref, Me.col_exp_ref_val, Me.codigo, Me.col_doc_jdu_id, Me.col_item, Me.col_num_exp, Me.col_sit_jur, Me.col_mot_que_id, Me.col_mot_que, Me.col_tip_lib_id, Me.col_tip_lib, Me.col_exp_btn, Me.col_tip_aut, Me.col_aut_jud_id, Me.col_sal_jud, Me.col_aut_jud, Me.col_sal_jud_id, Me.col_juez_nom, Me.col_secre, Me.col_flag, Me.col_eliminar, Me.col_id_tip_imim, Me.col_id_cen_sal_men})
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwExpediente.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 33)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgwExpediente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(639, 131)
            Me.dgwExpediente.TabIndex = 3
            Me.dgwExpediente.VisibleCampos = True
            '
            'col_num
            '
            Me.col_num.HeaderText = "N°"
            Me.col_num.Name = "col_num"
            Me.col_num.Width = 22
            '
            'col_exp_ref
            '
            Me.col_exp_ref.DataPropertyName = "ExpedienteRefIcon"
            Me.col_exp_ref.HeaderText = "Ref."
            Me.col_exp_ref.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_exp_ref.Name = "col_exp_ref"
            Me.col_exp_ref.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_ref.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_ref.ToolTipText = "Expediente Referenciado"
            Me.col_exp_ref.Width = 26
            '
            'col_exp_ref_val
            '
            Me.col_exp_ref_val.DataPropertyName = "ExpedienteReferido2"
            Me.col_exp_ref_val.HeaderText = "ExpRef"
            Me.col_exp_ref_val.Name = "col_exp_ref_val"
            Me.col_exp_ref_val.Visible = False
            '
            'codigo
            '
            Me.codigo.DataPropertyName = "Codigo"
            Me.codigo.DividerWidth = 1
            Me.codigo.HeaderText = "Codigo"
            Me.codigo.Name = "codigo"
            Me.codigo.Visible = False
            Me.codigo.Width = 25
            '
            'col_doc_jdu_id
            '
            Me.col_doc_jdu_id.DataPropertyName = "CreaDocJudicialId"
            Me.col_doc_jdu_id.DividerWidth = 1
            Me.col_doc_jdu_id.HeaderText = "DocJudicialId"
            Me.col_doc_jdu_id.Name = "col_doc_jdu_id"
            Me.col_doc_jdu_id.Visible = False
            Me.col_doc_jdu_id.Width = 70
            '
            'col_item
            '
            Me.col_item.DataPropertyName = "ExpedienteItem"
            Me.col_item.HeaderText = "Item"
            Me.col_item.Name = "col_item"
            Me.col_item.Visible = False
            Me.col_item.Width = 25
            '
            'col_num_exp
            '
            Me.col_num_exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_num_exp.DataPropertyName = "ExpedienteNumero"
            Me.col_num_exp.HeaderText = "N° Exp."
            Me.col_num_exp.Name = "col_num_exp"
            Me.col_num_exp.Width = 80
            '
            'col_sit_jur
            '
            Me.col_sit_jur.DataPropertyName = "SituacionJuridicaNombre"
            Me.col_sit_jur.HeaderText = "Sit. Juridica"
            Me.col_sit_jur.Name = "col_sit_jur"
            Me.col_sit_jur.Width = 45
            '
            'col_mot_que_id
            '
            Me.col_mot_que_id.DataPropertyName = "MotivoQuedaID"
            Me.col_mot_que_id.HeaderText = "MotivoQuedaID"
            Me.col_mot_que_id.Name = "col_mot_que_id"
            Me.col_mot_que_id.Visible = False
            '
            'col_mot_que
            '
            Me.col_mot_que.DataPropertyName = "MotivoQuedaNom"
            Me.col_mot_que.HeaderText = "Motivo Queda"
            Me.col_mot_que.Name = "col_mot_que"
            Me.col_mot_que.Visible = False
            '
            'col_tip_lib_id
            '
            Me.col_tip_lib_id.DataPropertyName = "LibertadTipoID"
            Me.col_tip_lib_id.HeaderText = "Tipo Libertad ID"
            Me.col_tip_lib_id.Name = "col_tip_lib_id"
            Me.col_tip_lib_id.Visible = False
            '
            'col_tip_lib
            '
            Me.col_tip_lib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_lib.DataPropertyName = "LibertadTipoNom"
            Me.col_tip_lib.FillWeight = 250.0!
            Me.col_tip_lib.HeaderText = "Tipo Libertad"
            Me.col_tip_lib.Name = "col_tip_lib"
            Me.col_tip_lib.ReadOnly = True
            Me.col_tip_lib.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_tip_lib.Visible = False
            Me.col_tip_lib.Width = 120
            '
            'col_exp_btn
            '
            Me.col_exp_btn.HeaderText = ""
            Me.col_exp_btn.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.col_exp_btn.Name = "col_exp_btn"
            Me.col_exp_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_btn.Visible = False
            Me.col_exp_btn.Width = 20
            '
            'col_tip_aut
            '
            Me.col_tip_aut.DataPropertyName = "TipoAutoridadJudicialID"
            Me.col_tip_aut.HeaderText = "Tipo Aut."
            Me.col_tip_aut.Name = "col_tip_aut"
            Me.col_tip_aut.Visible = False
            Me.col_tip_aut.Width = 25
            '
            'col_aut_jud_id
            '
            Me.col_aut_jud_id.DataPropertyName = "AutoridadJudicialID"
            Me.col_aut_jud_id.HeaderText = "Aut. JudicialID"
            Me.col_aut_jud_id.Name = "col_aut_jud_id"
            Me.col_aut_jud_id.Visible = False
            Me.col_aut_jud_id.Width = 50
            '
            'col_sal_jud
            '
            Me.col_sal_jud.DataPropertyName = "SalaJudicialNombre"
            Me.col_sal_jud.HeaderText = "Autoridad Judicial"
            Me.col_sal_jud.Name = "col_sal_jud"
            Me.col_sal_jud.Width = 230
            '
            'col_aut_jud
            '
            Me.col_aut_jud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_aut_jud.HeaderText = "Distrito Judicial"
            Me.col_aut_jud.Name = "col_aut_jud"
            '
            'col_sal_jud_id
            '
            Me.col_sal_jud_id.DataPropertyName = "SalaJudicialID"
            Me.col_sal_jud_id.HeaderText = "SalaJudID"
            Me.col_sal_jud_id.Name = "col_sal_jud_id"
            Me.col_sal_jud_id.Visible = False
            Me.col_sal_jud_id.Width = 50
            '
            'col_juez_nom
            '
            Me.col_juez_nom.DataPropertyName = "ExpedienteJuez"
            Me.col_juez_nom.HeaderText = "Juez"
            Me.col_juez_nom.Name = "col_juez_nom"
            Me.col_juez_nom.Visible = False
            Me.col_juez_nom.Width = 90
            '
            'col_secre
            '
            Me.col_secre.DataPropertyName = "ExpedienteSecretario"
            Me.col_secre.HeaderText = "Secretario"
            Me.col_secre.Name = "col_secre"
            Me.col_secre.Width = 140
            '
            'col_flag
            '
            Me.col_flag.DataPropertyName = "Flagrancia"
            Me.col_flag.HeaderText = "C.F."
            Me.col_flag.Name = "col_flag"
            Me.col_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_flag.ToolTipText = "Caso de flagrancia"
            Me.col_flag.Width = 40
            '
            'col_eliminar
            '
            Me.col_eliminar.DataPropertyName = "Eliminar"
            Me.col_eliminar.HeaderText = ""
            Me.col_eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_eliminar.Name = "col_eliminar"
            Me.col_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_eliminar.Visible = False
            Me.col_eliminar.Width = 35
            '
            'col_id_tip_imim
            '
            Me.col_id_tip_imim.DataPropertyName = "MotivoIngresoID"
            Me.col_id_tip_imim.HeaderText = "MotivoIngresoID"
            Me.col_id_tip_imim.Name = "col_id_tip_imim"
            Me.col_id_tip_imim.Visible = False
            '
            'col_id_cen_sal_men
            '
            Me.col_id_cen_sal_men.DataPropertyName = "EstablecimientomentalId"
            Me.col_id_cen_sal_men.HeaderText = "EstablecimientomentalId"
            Me.col_id_cen_sal_men.Name = "col_id_cen_sal_men"
            Me.col_id_cen_sal_men.Visible = False
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.lblNroExpedientes)
            Me.Panel5.Controls.Add(Me.pnlExpePermisos)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(639, 33)
            Me.Panel5.TabIndex = 2
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(3, 9)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(126, 13)
            Me.lblNroExpedientes.TabIndex = 1
            Me.lblNroExpedientes.Text = "Expedientes : 0 Reg."
            '
            'pnlExpePermisos
            '
            Me.pnlExpePermisos.Controls.Add(Me.pnlEscrituraExpe)
            Me.pnlExpePermisos.Controls.Add(Me.pnlEliminarExpe)
            Me.pnlExpePermisos.Controls.Add(Me.lblEstablecimientomental2)
            Me.pnlExpePermisos.Controls.Add(Me.btnInimputable2)
            Me.pnlExpePermisos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpePermisos.Location = New System.Drawing.Point(363, 0)
            Me.pnlExpePermisos.Name = "pnlExpePermisos"
            Me.pnlExpePermisos.Size = New System.Drawing.Size(276, 33)
            Me.pnlExpePermisos.TabIndex = 1
            '
            'pnlEscrituraExpe
            '
            Me.pnlEscrituraExpe.Controls.Add(Me.btnAddExp)
            Me.pnlEscrituraExpe.Controls.Add(Me.btnEditExpe)
            Me.pnlEscrituraExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEscrituraExpe.Location = New System.Drawing.Point(5, 0)
            Me.pnlEscrituraExpe.Name = "pnlEscrituraExpe"
            Me.pnlEscrituraExpe.Size = New System.Drawing.Size(61, 33)
            Me.pnlEscrituraExpe.TabIndex = 24
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAddExp.Location = New System.Drawing.Point(1, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 33)
            Me.btnAddExp.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnAddExp, "Permite crea un expediente completamente nuevo y anexa de forma automatica al doc" &
        "umento actual.")
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditExpe.Location = New System.Drawing.Point(31, 0)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 33)
            Me.btnEditExpe.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnEditExpe, "Permite modificar los datos del expediente seleccionado.")
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'pnlEliminarExpe
            '
            Me.pnlEliminarExpe.Controls.Add(Me.btnEliminarExp)
            Me.pnlEliminarExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarExpe.Location = New System.Drawing.Point(66, 0)
            Me.pnlEliminarExpe.Name = "pnlEliminarExpe"
            Me.pnlEliminarExpe.Size = New System.Drawing.Size(31, 33)
            Me.pnlEliminarExpe.TabIndex = 23
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEliminarExp.Location = New System.Drawing.Point(1, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(30, 33)
            Me.btnEliminarExp.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnEliminarExp, "Eliminar expediente seleccionado")
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'lblEstablecimientomental2
            '
            Me.lblEstablecimientomental2.AutoSize = True
            Me.lblEstablecimientomental2.Dock = System.Windows.Forms.DockStyle.Right
            Me.lblEstablecimientomental2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstablecimientomental2.Location = New System.Drawing.Point(97, 0)
            Me.lblEstablecimientomental2.Name = "lblEstablecimientomental2"
            Me.lblEstablecimientomental2.Size = New System.Drawing.Size(146, 24)
            Me.lblEstablecimientomental2.TabIndex = 22
            Me.lblEstablecimientomental2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Establecimiento de salud mental: "
            Me.lblEstablecimientomental2.Visible = False
            '
            'btnInimputable2
            '
            Me.btnInimputable2.BackgroundImage = Global.APPControls.My.Resources.Resources.hospital
            Me.btnInimputable2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable2.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnInimputable2.Location = New System.Drawing.Point(243, 0)
            Me.btnInimputable2.Name = "btnInimputable2"
            Me.btnInimputable2.Size = New System.Drawing.Size(33, 33)
            Me.btnInimputable2.TabIndex = 21
            Me.ToolTip1.SetToolTip(Me.btnInimputable2, "Agregar información sobre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el lugar donde deberia cumplir la medida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de seguridad" &
        ".")
            Me.btnInimputable2.UseVisualStyleBackColor = True
            Me.btnInimputable2.Visible = False
            '
            'pnlPeriodoCondena
            '
            Me.pnlPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlPeriodoCondena.Controls.Add(Me.pnlTiempoConde)
            Me.pnlPeriodoCondena.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlPeriodoCondena.Location = New System.Drawing.Point(641, 0)
            Me.pnlPeriodoCondena.Name = "pnlPeriodoCondena"
            Me.pnlPeriodoCondena.Size = New System.Drawing.Size(235, 166)
            Me.pnlPeriodoCondena.TabIndex = 1
            Me.pnlPeriodoCondena.Visible = False
            '
            'pnlTiempoConde
            '
            Me.pnlTiempoConde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlTiempoConde.Controls.Add(Me.gbComputo)
            Me.pnlTiempoConde.Controls.Add(Me.gbDuracioncondena)
            Me.pnlTiempoConde.Controls.Add(Me.pnlInimputable)
            Me.pnlTiempoConde.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlTiempoConde.Location = New System.Drawing.Point(0, 0)
            Me.pnlTiempoConde.Name = "pnlTiempoConde"
            Me.pnlTiempoConde.Size = New System.Drawing.Size(233, 164)
            Me.pnlTiempoConde.TabIndex = 2
            '
            'gbComputo
            '
            Me.gbComputo.Controls.Add(Me.Label10)
            Me.gbComputo.Controls.Add(Me.dtpFechaFinal)
            Me.gbComputo.Controls.Add(Me.Label6)
            Me.gbComputo.Controls.Add(Me.dtpFechaInicio)
            Me.gbComputo.Controls.Add(Me.dgvPeriodoCondena)
            Me.gbComputo.Controls.Add(Me.Panel4)
            Me.gbComputo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbComputo.Location = New System.Drawing.Point(0, 96)
            Me.gbComputo.Name = "gbComputo"
            Me.gbComputo.Size = New System.Drawing.Size(229, 64)
            Me.gbComputo.TabIndex = 7
            Me.gbComputo.TabStop = False
            Me.gbComputo.Text = "Cómputo"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(79, 43)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(43, 13)
            Me.Label10.TabIndex = 6
            Me.Label10.Text = "F. vcto:"
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Location = New System.Drawing.Point(129, 37)
            Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinal.TabIndex = 7
            Me.dtpFechaFinal.Value = "/  /"
            Me.dtpFechaFinal.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(76, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(47, 13)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "F. Inicio:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Location = New System.Drawing.Point(129, 14)
            Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 5
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'dgvPeriodoCondena
            '
            Me.dgvPeriodoCondena.AllowUserToAddRows = False
            Me.dgvPeriodoCondena.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondena.AllowUserToResizeRows = False
            Me.dgvPeriodoCondena.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPeriodoCondena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item, Me.col_cod, Me.col_ini, Me.col_fin, Me.DataGridViewTextBoxColumn1, Me.col_eliminado})
            Me.dgvPeriodoCondena.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(207, 63)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle15
            Me.dgvPeriodoCondena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(22, 26)
            Me.dgvPeriodoCondena.TabIndex = 2
            Me.dgvPeriodoCondena.Visible = False
            Me.dgvPeriodoCondena.VisibleCampos = True
            '
            'col_ped_cond_item
            '
            Me.col_ped_cond_item.DataPropertyName = "PeriodoCondenaItem"
            Me.col_ped_cond_item.DividerWidth = 1
            Me.col_ped_cond_item.HeaderText = "PerCondItem"
            Me.col_ped_cond_item.Name = "col_ped_cond_item"
            Me.col_ped_cond_item.ReadOnly = True
            Me.col_ped_cond_item.Visible = False
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            Me.col_cod.Width = 50
            '
            'col_ini
            '
            Me.col_ini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ini.DataPropertyName = "FechaInicioString"
            DataGridViewCellStyle13.Format = "d"
            DataGridViewCellStyle13.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle13
            Me.col_ini.HeaderText = "F. inicio"
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            '
            'col_fin
            '
            Me.col_fin.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle14.Format = "d"
            DataGridViewCellStyle14.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle14
            Me.col_fin.HeaderText = "F. vcto."
            Me.col_fin.Name = "col_fin"
            Me.col_fin.ReadOnly = True
            Me.col_fin.Width = 95
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.DataPropertyName = "DocJudicialId"
            Me.DataGridViewTextBoxColumn1.DividerWidth = 1
            Me.DataGridViewTextBoxColumn1.HeaderText = "DocJudId"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.ReadOnly = True
            Me.DataGridViewTextBoxColumn1.Visible = False
            Me.DataGridViewTextBoxColumn1.Width = 30
            '
            'col_eliminado
            '
            Me.col_eliminado.DataPropertyName = "FlgEliminado"
            Me.col_eliminado.DividerWidth = 1
            Me.col_eliminado.HeaderText = "Eliminado"
            Me.col_eliminado.Name = "col_eliminado"
            Me.col_eliminado.ReadOnly = True
            Me.col_eliminado.Visible = False
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.pnlAgravMant)
            Me.Panel4.Location = New System.Drawing.Point(205, 19)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(26, 40)
            Me.Panel4.TabIndex = 0
            Me.Panel4.Visible = False
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnEditPerCond)
            Me.pnlAgravMant.Controls.Add(Me.pnlMantBotPeriCondena)
            Me.pnlAgravMant.Controls.Add(Me.btnAddPerCond)
            Me.pnlAgravMant.Location = New System.Drawing.Point(0, 41)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(26, 54)
            Me.pnlAgravMant.TabIndex = 1
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Location = New System.Drawing.Point(2, 37)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnEditPerCond.TabIndex = 1
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'pnlMantBotPeriCondena
            '
            Me.pnlMantBotPeriCondena.Controls.Add(Me.btnDelPerCond)
            Me.pnlMantBotPeriCondena.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlMantBotPeriCondena.Location = New System.Drawing.Point(0, 28)
            Me.pnlMantBotPeriCondena.Name = "pnlMantBotPeriCondena"
            Me.pnlMantBotPeriCondena.Size = New System.Drawing.Size(26, 26)
            Me.pnlMantBotPeriCondena.TabIndex = 1
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Location = New System.Drawing.Point(2, 1)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(31, 25)
            Me.btnDelPerCond.TabIndex = 3
            Me.btnDelPerCond.UseVisualStyleBackColor = True
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Location = New System.Drawing.Point(2, 7)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            '
            'gbDuracioncondena
            '
            Me.gbDuracioncondena.Controls.Add(Me.rbCadenaperpetua)
            Me.gbDuracioncondena.Controls.Add(Me.rbTemporal)
            Me.gbDuracioncondena.Controls.Add(Me.txtDias)
            Me.gbDuracioncondena.Controls.Add(Me.Label4)
            Me.gbDuracioncondena.Controls.Add(Me.Label8)
            Me.gbDuracioncondena.Controls.Add(Me.txtMeses)
            Me.gbDuracioncondena.Controls.Add(Me.txtAnios)
            Me.gbDuracioncondena.Controls.Add(Me.Label7)
            Me.gbDuracioncondena.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbDuracioncondena.Location = New System.Drawing.Point(0, 31)
            Me.gbDuracioncondena.Name = "gbDuracioncondena"
            Me.gbDuracioncondena.Size = New System.Drawing.Size(229, 65)
            Me.gbDuracioncondena.TabIndex = 6
            Me.gbDuracioncondena.TabStop = False
            Me.gbDuracioncondena.Text = "Duración de la condena"
            '
            'rbCadenaperpetua
            '
            Me.rbCadenaperpetua.AutoSize = True
            Me.rbCadenaperpetua.Location = New System.Drawing.Point(4, 40)
            Me.rbCadenaperpetua.Name = "rbCadenaperpetua"
            Me.rbCadenaperpetua.Size = New System.Drawing.Size(107, 17)
            Me.rbCadenaperpetua.TabIndex = 7
            Me.rbCadenaperpetua.Text = "Cadena perpetua"
            Me.rbCadenaperpetua.UseVisualStyleBackColor = True
            '
            'rbTemporal
            '
            Me.rbTemporal.AutoSize = True
            Me.rbTemporal.Checked = True
            Me.rbTemporal.Location = New System.Drawing.Point(4, 21)
            Me.rbTemporal.Name = "rbTemporal"
            Me.rbTemporal.Size = New System.Drawing.Size(69, 17)
            Me.rbTemporal.TabIndex = 6
            Me.rbTemporal.TabStop = True
            Me.rbTemporal.Text = "Temporal"
            Me.rbTemporal.UseVisualStyleBackColor = True
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(201, 38)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(25, 20)
            Me.txtDias.TabIndex = 5
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(125, 21)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Años"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(199, 21)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(30, 13)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Días"
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(165, 38)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(25, 20)
            Me.txtMeses.TabIndex = 3
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.Location = New System.Drawing.Point(129, 39)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(25, 20)
            Me.txtAnios.TabIndex = 1
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(158, 21)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(38, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Meses"
            '
            'pnlInimputable
            '
            Me.pnlInimputable.Controls.Add(Me.lblEstablecimientomental)
            Me.pnlInimputable.Controls.Add(Me.btnInimputable)
            Me.pnlInimputable.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlInimputable.Location = New System.Drawing.Point(0, 0)
            Me.pnlInimputable.Name = "pnlInimputable"
            Me.pnlInimputable.Size = New System.Drawing.Size(229, 31)
            Me.pnlInimputable.TabIndex = 5
            '
            'lblEstablecimientomental
            '
            Me.lblEstablecimientomental.AutoSize = True
            Me.lblEstablecimientomental.Dock = System.Windows.Forms.DockStyle.Right
            Me.lblEstablecimientomental.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstablecimientomental.Location = New System.Drawing.Point(50, 0)
            Me.lblEstablecimientomental.Name = "lblEstablecimientomental"
            Me.lblEstablecimientomental.Size = New System.Drawing.Size(146, 24)
            Me.lblEstablecimientomental.TabIndex = 20
            Me.lblEstablecimientomental.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Establecimiento de salud mental: "
            '
            'btnInimputable
            '
            Me.btnInimputable.BackgroundImage = Global.APPControls.My.Resources.Resources.hospital
            Me.btnInimputable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnInimputable.Location = New System.Drawing.Point(196, 0)
            Me.btnInimputable.Name = "btnInimputable"
            Me.btnInimputable.Size = New System.Drawing.Size(33, 31)
            Me.btnInimputable.TabIndex = 19
            Me.ToolTip1.SetToolTip(Me.btnInimputable, "Agregar información sobre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el lugar donde deberia cumplir la medida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de seguridad" &
        ".")
            Me.btnInimputable.UseVisualStyleBackColor = True
            '
            'ToolTip1
            '
            Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn1.Visible = False
            Me.DataGridViewImageColumn1.Width = 20
            '
            'uscExpeDeResolucionIng
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer2)
            Me.Name = "uscExpeDeResolucionIng"
            Me.Size = New System.Drawing.Size(876, 316)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlDelitoPermisos.ResumeLayout(False)
            Me.pnlEscrituraDelito.ResumeLayout(False)
            Me.pnlEliminarDelito.ResumeLayout(False)
            CType(Me.dgwAgraviados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlAgravPermisos.ResumeLayout(False)
            Me.pnlEscrituraAgrav.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.SplitContainer2.Panel1.ResumeLayout(False)
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.ResumeLayout(False)
            Me.pnlCabExpediente.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlExpePermisos.ResumeLayout(False)
            Me.pnlExpePermisos.PerformLayout()
            Me.pnlEscrituraExpe.ResumeLayout(False)
            Me.pnlEliminarExpe.ResumeLayout(False)
            Me.pnlPeriodoCondena.ResumeLayout(False)
            Me.pnlTiempoConde.ResumeLayout(False)
            Me.gbComputo.ResumeLayout(False)
            Me.gbComputo.PerformLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel4.ResumeLayout(False)
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlMantBotPeriCondena.ResumeLayout(False)
            Me.gbDuracioncondena.ResumeLayout(False)
            Me.gbDuracioncondena.PerformLayout()
            Me.pnlInimputable.ResumeLayout(False)
            Me.pnlInimputable.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents lblNrodelitos As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents lblNroAgraviados As System.Windows.Forms.Label
        Friend WithEvents pnlEscrituraDelito As System.Windows.Forms.Panel
        Friend WithEvents pnlEscrituraAgrav As System.Windows.Forms.Panel
        Friend WithEvents btnAddDelito As System.Windows.Forms.Button
        Friend WithEvents btnDelDelito As System.Windows.Forms.Button
        Friend WithEvents btnEditDelito As System.Windows.Forms.Button
        Friend WithEvents btnAddAgrav As System.Windows.Forms.Button
        Friend WithEvents btnDelAgrav As System.Windows.Forms.Button
        Friend WithEvents btnEditAgrav As System.Windows.Forms.Button
        Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents pnlEliminarDelito As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents lblExpedienteReferenciado As System.Windows.Forms.Label
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents dgwAgraviados As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_agr_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nom_agrav As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_delito_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlDelitoPermisos As Panel
        Friend WithEvents pnlAgravPermisos As Panel
        Friend WithEvents col_int_del_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_del_anulacion As DataGridViewImageColumn
        Friend WithEvents colEliminarDelito As DataGridViewImageColumn
        Friend WithEvents col_del_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents pnlCabExpediente As Panel
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel5 As Panel
        Friend WithEvents lblNroExpedientes As Label
        Friend WithEvents pnlExpePermisos As Panel
        Friend WithEvents btnAddExp As Button
        Friend WithEvents btnEditExpe As Button
        Friend WithEvents btnEliminarExp As Button
        Friend WithEvents pnlPeriodoCondena As Panel
        Friend WithEvents pnlTiempoConde As Panel
        Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
        Friend WithEvents gbComputo As GroupBox
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_ped_cond_item As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_ini As DataGridViewTextBoxColumn
        Friend WithEvents col_fin As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As DataGridViewTextBoxColumn
        Friend WithEvents Panel4 As Panel
        Friend WithEvents pnlAgravMant As Panel
        Friend WithEvents btnEditPerCond As Button
        Friend WithEvents pnlMantBotPeriCondena As Panel
        Friend WithEvents btnDelPerCond As Button
        Friend WithEvents btnAddPerCond As Button
        Friend WithEvents gbDuracioncondena As GroupBox
        Friend WithEvents rbCadenaperpetua As RadioButton
        Friend WithEvents rbTemporal As RadioButton
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents pnlInimputable As Panel
        Friend WithEvents lblEstablecimientomental As Label
        Friend WithEvents btnInimputable As Button
        Friend WithEvents Label10 As Label
        Friend WithEvents dtpFechaFinal As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents pnlEscrituraExpe As Panel
        Friend WithEvents pnlEliminarExpe As Panel
        Friend WithEvents lblEstablecimientomental2 As Label
        Friend WithEvents btnInimputable2 As Button
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_ref As DataGridViewImageColumn
        Friend WithEvents col_exp_ref_val As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_item As DataGridViewTextBoxColumn
        Friend WithEvents col_num_exp As DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur As DataGridViewTextBoxColumn
        Friend WithEvents col_mot_que_id As DataGridViewTextBoxColumn
        Friend WithEvents col_mot_que As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_lib_id As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_lib As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_btn As DataGridViewImageColumn
        Friend WithEvents col_tip_aut As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_juez_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_secre As DataGridViewTextBoxColumn
        Friend WithEvents col_flag As DataGridViewCheckBoxColumn
        Friend WithEvents col_eliminar As DataGridViewImageColumn
        Friend WithEvents col_id_tip_imim As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cen_sal_men As DataGridViewTextBoxColumn
    End Class

End Namespace