Namespace Registro.Documento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscExpeDeResolucion
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
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
            Me.pnlExpediente = New System.Windows.Forms.Panel()
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
            Me.col_subtip_lib_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_subtip_lib = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_aut = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_juez_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_exp_inim = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_men_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_men_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_inmp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_conclu = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_conclu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_men_nue_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_men_nue_des_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.pnlCabExpediente = New System.Windows.Forms.Panel()
            Me.pnlExpePermisos = New System.Windows.Forms.Panel()
            Me.btnInimputable2 = New System.Windows.Forms.Button()
            Me.pnlEscrituraExpe = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.pnlEliminarExpe = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlDuracionCondena = New System.Windows.Forms.Panel()
            Me.gbDuracioncondena = New System.Windows.Forms.GroupBox()
            Me.rbCadenaperpetua = New System.Windows.Forms.RadioButton()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.rbTemporal = New System.Windows.Forms.RadioButton()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gbExentoInimputable = New System.Windows.Forms.GroupBox()
            Me.rbInternacion = New System.Windows.Forms.RadioButton()
            Me.rbTratamientoAmbulatorio = New System.Windows.Forms.RadioButton()
            Me.btnInimputable = New System.Windows.Forms.Button()
            Me.gbComputo = New System.Windows.Forms.GroupBox()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaFinal = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.pnlMantPer = New System.Windows.Forms.Panel()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.Panel5.SuspendLayout()
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer2.Panel1.SuspendLayout()
            Me.SplitContainer2.Panel2.SuspendLayout()
            Me.SplitContainer2.SuspendLayout()
            Me.pnlExpediente.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCabExpediente.SuspendLayout()
            Me.pnlExpePermisos.SuspendLayout()
            Me.pnlEscrituraExpe.SuspendLayout()
            Me.pnlEliminarExpe.SuspendLayout()
            Me.pnlDuracionCondena.SuspendLayout()
            Me.gbDuracioncondena.SuspendLayout()
            Me.gbExentoInimputable.SuspendLayout()
            Me.gbComputo.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlMantPer.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.SplitContainer1.Size = New System.Drawing.Size(807, 134)
            Me.SplitContainer1.SplitterDistance = 429
            Me.SplitContainer1.TabIndex = 0
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_nom, Me.col_del_esp_id, Me.DataGridViewTextBoxColumn3, Me.col_del_anulacion, Me.colEliminarDelito, Me.col_del_obs, Me.col_doc_jud_id})
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle18
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 27)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            Me.dgwDelito.ReadOnly = True
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle20
            Me.dgwDelito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(429, 107)
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
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "DelitoGenericoNombre"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Delito Generico"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 280
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
            Me.Panel2.Size = New System.Drawing.Size(429, 27)
            Me.Panel2.TabIndex = 0
            '
            'pnlDelitoPermisos
            '
            Me.pnlDelitoPermisos.Controls.Add(Me.pnlEscrituraDelito)
            Me.pnlDelitoPermisos.Controls.Add(Me.pnlEliminarDelito)
            Me.pnlDelitoPermisos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlDelitoPermisos.Location = New System.Drawing.Point(310, 0)
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
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAgraviados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
            Me.dgwAgraviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwAgraviados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_agr_id, Me.col_agr_exp_item, Me.col_agr_del_item, Me.col_agr_item, Me.nom_agrav, Me.col_obs, Me.col_delito_id})
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwAgraviados.DefaultCellStyle = DataGridViewCellStyle22
            Me.dgwAgraviados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwAgraviados.GridColor = System.Drawing.Color.LightGray
            Me.dgwAgraviados.Location = New System.Drawing.Point(0, 27)
            Me.dgwAgraviados.MultiSelect = False
            Me.dgwAgraviados.Name = "dgwAgraviados"
            Me.dgwAgraviados.ReadOnly = True
            DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAgraviados.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
            Me.dgwAgraviados.RowHeadersVisible = False
            DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwAgraviados.RowsDefaultCellStyle = DataGridViewCellStyle24
            Me.dgwAgraviados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwAgraviados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwAgraviados.Size = New System.Drawing.Size(374, 107)
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
            Me.Panel3.Size = New System.Drawing.Size(374, 27)
            Me.Panel3.TabIndex = 0
            '
            'pnlAgravPermisos
            '
            Me.pnlAgravPermisos.Controls.Add(Me.pnlEscrituraAgrav)
            Me.pnlAgravPermisos.Controls.Add(Me.pnlEliminarAgraviado)
            Me.pnlAgravPermisos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravPermisos.Location = New System.Drawing.Point(255, 0)
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
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.btnDelPerCond)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel5.Location = New System.Drawing.Point(187, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(30, 22)
            Me.Panel5.TabIndex = 96
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Location = New System.Drawing.Point(1, 1)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(26, 24)
            Me.btnDelPerCond.TabIndex = 89
            Me.btnDelPerCond.UseVisualStyleBackColor = True
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
            Me.SplitContainer2.Panel1.Controls.Add(Me.pnlExpediente)
            Me.SplitContainer2.Panel1.Controls.Add(Me.pnlDuracionCondena)
            '
            'SplitContainer2.Panel2
            '
            Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
            Me.SplitContainer2.Size = New System.Drawing.Size(807, 335)
            Me.SplitContainer2.SplitterDistance = 197
            Me.SplitContainer2.TabIndex = 0
            '
            'pnlExpediente
            '
            Me.pnlExpediente.Controls.Add(Me.dgwExpediente)
            Me.pnlExpediente.Controls.Add(Me.pnlCabExpediente)
            Me.pnlExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlExpediente.Name = "pnlExpediente"
            Me.pnlExpediente.Size = New System.Drawing.Size(584, 197)
            Me.pnlExpediente.TabIndex = 3
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_exp_ref, Me.col_exp_ref_val, Me.codigo, Me.col_doc_jdu_id, Me.col_item, Me.col_num_exp, Me.col_sit_jur, Me.col_mot_que_id, Me.col_mot_que, Me.col_tip_lib_id, Me.col_tip_lib, Me.col_exp_btn, Me.col_subtip_lib_id, Me.col_subtip_lib, Me.col_tip_aut, Me.col_aut_jud_id, Me.col_sal_jud, Me.col_aut_jud, Me.col_sal_jud_id, Me.col_juez_nom, Me.col_tip_exp_inim, Me.col_est_men_id, Me.col_est_men_des, Me.col_exp_inmp, Me.col_exp_conclu, Me.col_conclu_id, Me.col_est_men_nue_des, Me.col_est_men_nue_des_id, Me.col_secre, Me.col_flag})
            DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwExpediente.DefaultCellStyle = DataGridViewCellStyle26
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 33)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.RowHeadersDefaultCellStyle = DataGridViewCellStyle27
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle28
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(584, 164)
            Me.dgwExpediente.TabIndex = 1
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
            'col_subtip_lib_id
            '
            Me.col_subtip_lib_id.DataPropertyName = "LibertadSubTipoStrID"
            Me.col_subtip_lib_id.HeaderText = "LibertadSubtipoId"
            Me.col_subtip_lib_id.Name = "col_subtip_lib_id"
            Me.col_subtip_lib_id.Visible = False
            '
            'col_subtip_lib
            '
            Me.col_subtip_lib.HeaderText = "LibertadSubtipo"
            Me.col_subtip_lib.Name = "col_subtip_lib"
            Me.col_subtip_lib.Visible = False
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
            Me.col_sal_jud.Width = 250
            '
            'col_aut_jud
            '
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
            'col_tip_exp_inim
            '
            Me.col_tip_exp_inim.DataPropertyName = "MotivoIngresoID"
            Me.col_tip_exp_inim.HeaderText = "MotivoIngresoID"
            Me.col_tip_exp_inim.Name = "col_tip_exp_inim"
            Me.col_tip_exp_inim.Visible = False
            '
            'col_est_men_id
            '
            Me.col_est_men_id.DataPropertyName = "EstablecimientomentalId"
            Me.col_est_men_id.HeaderText = "HospitalDestinoId"
            Me.col_est_men_id.Name = "col_est_men_id"
            Me.col_est_men_id.Visible = False
            '
            'col_est_men_des
            '
            Me.col_est_men_des.DataPropertyName = "Establecimientomental"
            Me.col_est_men_des.HeaderText = "Destino"
            Me.col_est_men_des.Name = "col_est_men_des"
            Me.col_est_men_des.Visible = False
            Me.col_est_men_des.Width = 160
            '
            'col_exp_inmp
            '
            Me.col_exp_inmp.DataPropertyName = "Inimputable"
            Me.col_exp_inmp.HeaderText = "Inimputable/Posible inimputable"
            Me.col_exp_inmp.Name = "col_exp_inmp"
            Me.col_exp_inmp.Visible = False
            Me.col_exp_inmp.Width = 160
            '
            'col_exp_conclu
            '
            Me.col_exp_conclu.DataPropertyName = "NuevoMotivoInimputable"
            Me.col_exp_conclu.HeaderText = "Conclusión"
            Me.col_exp_conclu.Name = "col_exp_conclu"
            Me.col_exp_conclu.Visible = False
            '
            'col_conclu_id
            '
            Me.col_conclu_id.DataPropertyName = "NuevoMotivoInimputableId"
            Me.col_conclu_id.HeaderText = "ConclusionId"
            Me.col_conclu_id.Name = "col_conclu_id"
            Me.col_conclu_id.Visible = False
            '
            'col_est_men_nue_des
            '
            Me.col_est_men_nue_des.DataPropertyName = "NuevoEstablecimientomental"
            Me.col_est_men_nue_des.HeaderText = "Nuevo destino"
            Me.col_est_men_nue_des.Name = "col_est_men_nue_des"
            Me.col_est_men_nue_des.Visible = False
            Me.col_est_men_nue_des.Width = 150
            '
            'col_est_men_nue_des_id
            '
            Me.col_est_men_nue_des_id.DataPropertyName = "NuevoEstablecimientomentalId"
            Me.col_est_men_nue_des_id.HeaderText = "NuevoDestinoId"
            Me.col_est_men_nue_des_id.Name = "col_est_men_nue_des_id"
            Me.col_est_men_nue_des_id.Visible = False
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
            Me.col_flag.Width = 26
            '
            'pnlCabExpediente
            '
            Me.pnlCabExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCabExpediente.Controls.Add(Me.pnlExpePermisos)
            Me.pnlCabExpediente.Controls.Add(Me.lblNroExpedientes)
            Me.pnlCabExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabExpediente.Name = "pnlCabExpediente"
            Me.pnlCabExpediente.Size = New System.Drawing.Size(584, 33)
            Me.pnlCabExpediente.TabIndex = 0
            '
            'pnlExpePermisos
            '
            Me.pnlExpePermisos.Controls.Add(Me.btnInimputable2)
            Me.pnlExpePermisos.Controls.Add(Me.pnlEscrituraExpe)
            Me.pnlExpePermisos.Controls.Add(Me.pnlEliminarExpe)
            Me.pnlExpePermisos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpePermisos.Location = New System.Drawing.Point(411, 0)
            Me.pnlExpePermisos.Name = "pnlExpePermisos"
            Me.pnlExpePermisos.Size = New System.Drawing.Size(171, 31)
            Me.pnlExpePermisos.TabIndex = 1
            '
            'btnInimputable2
            '
            Me.btnInimputable2.BackgroundImage = Global.APPControls.My.Resources.Resources.centro_salud
            Me.btnInimputable2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable2.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnInimputable2.Location = New System.Drawing.Point(0, 0)
            Me.btnInimputable2.Name = "btnInimputable2"
            Me.btnInimputable2.Size = New System.Drawing.Size(33, 31)
            Me.btnInimputable2.TabIndex = 16
            Me.ToolTip1.SetToolTip(Me.btnInimputable2, "Agregar información sobre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el lugar donde deberia cumplir la medida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de seguridad" &
        ".")
            Me.btnInimputable2.UseVisualStyleBackColor = True
            Me.btnInimputable2.Visible = False
            '
            'pnlEscrituraExpe
            '
            Me.pnlEscrituraExpe.Controls.Add(Me.btnAddExp)
            Me.pnlEscrituraExpe.Controls.Add(Me.btnEditExpe)
            Me.pnlEscrituraExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEscrituraExpe.Location = New System.Drawing.Point(79, 0)
            Me.pnlEscrituraExpe.Name = "pnlEscrituraExpe"
            Me.pnlEscrituraExpe.Size = New System.Drawing.Size(61, 31)
            Me.pnlEscrituraExpe.TabIndex = 0
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAddExp.Location = New System.Drawing.Point(1, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 31)
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
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 31)
            Me.btnEditExpe.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnEditExpe, "Permite modificar los datos del expediente seleccionado.")
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'pnlEliminarExpe
            '
            Me.pnlEliminarExpe.Controls.Add(Me.btnEliminarExp)
            Me.pnlEliminarExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarExpe.Location = New System.Drawing.Point(140, 0)
            Me.pnlEliminarExpe.Name = "pnlEliminarExpe"
            Me.pnlEliminarExpe.Size = New System.Drawing.Size(31, 31)
            Me.pnlEliminarExpe.TabIndex = 1
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEliminarExp.Location = New System.Drawing.Point(1, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(30, 31)
            Me.btnEliminarExp.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnEliminarExp, "Eliminar expediente seleccionado")
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(4, 6)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(126, 13)
            Me.lblNroExpedientes.TabIndex = 0
            Me.lblNroExpedientes.Text = "Expedientes : 0 Reg."
            '
            'pnlDuracionCondena
            '
            Me.pnlDuracionCondena.Controls.Add(Me.gbDuracioncondena)
            Me.pnlDuracionCondena.Controls.Add(Me.gbExentoInimputable)
            Me.pnlDuracionCondena.Controls.Add(Me.gbComputo)
            Me.pnlDuracionCondena.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlDuracionCondena.Location = New System.Drawing.Point(584, 0)
            Me.pnlDuracionCondena.Name = "pnlDuracionCondena"
            Me.pnlDuracionCondena.Size = New System.Drawing.Size(223, 197)
            Me.pnlDuracionCondena.TabIndex = 2
            Me.pnlDuracionCondena.Visible = False
            '
            'gbDuracioncondena
            '
            Me.gbDuracioncondena.Controls.Add(Me.rbCadenaperpetua)
            Me.gbDuracioncondena.Controls.Add(Me.Label8)
            Me.gbDuracioncondena.Controls.Add(Me.Label7)
            Me.gbDuracioncondena.Controls.Add(Me.rbTemporal)
            Me.gbDuracioncondena.Controls.Add(Me.Label4)
            Me.gbDuracioncondena.Controls.Add(Me.txtAnios)
            Me.gbDuracioncondena.Controls.Add(Me.txtDias)
            Me.gbDuracioncondena.Controls.Add(Me.txtMeses)
            Me.gbDuracioncondena.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbDuracioncondena.Location = New System.Drawing.Point(0, 52)
            Me.gbDuracioncondena.Name = "gbDuracioncondena"
            Me.gbDuracioncondena.Size = New System.Drawing.Size(223, 77)
            Me.gbDuracioncondena.TabIndex = 102
            Me.gbDuracioncondena.TabStop = False
            Me.gbDuracioncondena.Text = "Duración de la condena"
            '
            'rbCadenaperpetua
            '
            Me.rbCadenaperpetua.AutoSize = True
            Me.rbCadenaperpetua.Location = New System.Drawing.Point(10, 36)
            Me.rbCadenaperpetua.Name = "rbCadenaperpetua"
            Me.rbCadenaperpetua.Size = New System.Drawing.Size(107, 17)
            Me.rbCadenaperpetua.TabIndex = 8
            Me.rbCadenaperpetua.Text = "Cadena perpetua"
            Me.rbCadenaperpetua.UseVisualStyleBackColor = True
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(186, 20)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(24, 12)
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Dias"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(149, 19)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(34, 12)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Meses"
            '
            'rbTemporal
            '
            Me.rbTemporal.AutoSize = True
            Me.rbTemporal.Checked = True
            Me.rbTemporal.Location = New System.Drawing.Point(10, 19)
            Me.rbTemporal.Name = "rbTemporal"
            Me.rbTemporal.Size = New System.Drawing.Size(69, 17)
            Me.rbTemporal.TabIndex = 7
            Me.rbTemporal.TabStop = True
            Me.rbTemporal.Text = "Temporal"
            Me.rbTemporal.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(118, 18)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(27, 12)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Años"
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BackColor = System.Drawing.Color.White
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.ForeColor = System.Drawing.Color.Black
            Me.txtAnios.Location = New System.Drawing.Point(119, 32)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(28, 20)
            Me.txtAnios.TabIndex = 1
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(184, 32)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(28, 20)
            Me.txtDias.TabIndex = 3
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(152, 32)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(28, 20)
            Me.txtMeses.TabIndex = 2
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'gbExentoInimputable
            '
            Me.gbExentoInimputable.Controls.Add(Me.rbInternacion)
            Me.gbExentoInimputable.Controls.Add(Me.rbTratamientoAmbulatorio)
            Me.gbExentoInimputable.Controls.Add(Me.btnInimputable)
            Me.gbExentoInimputable.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbExentoInimputable.Location = New System.Drawing.Point(0, 0)
            Me.gbExentoInimputable.Name = "gbExentoInimputable"
            Me.gbExentoInimputable.Size = New System.Drawing.Size(223, 52)
            Me.gbExentoInimputable.TabIndex = 101
            Me.gbExentoInimputable.TabStop = False
            Me.gbExentoInimputable.Text = "Clases de medida de seguridad"
            '
            'rbInternacion
            '
            Me.rbInternacion.AutoSize = True
            Me.rbInternacion.Checked = True
            Me.rbInternacion.Location = New System.Drawing.Point(26, 15)
            Me.rbInternacion.Name = "rbInternacion"
            Me.rbInternacion.Size = New System.Drawing.Size(78, 17)
            Me.rbInternacion.TabIndex = 8
            Me.rbInternacion.TabStop = True
            Me.rbInternacion.Text = "Internación"
            Me.rbInternacion.UseVisualStyleBackColor = True
            '
            'rbTratamientoAmbulatorio
            '
            Me.rbTratamientoAmbulatorio.AutoSize = True
            Me.rbTratamientoAmbulatorio.Location = New System.Drawing.Point(26, 33)
            Me.rbTratamientoAmbulatorio.Name = "rbTratamientoAmbulatorio"
            Me.rbTratamientoAmbulatorio.Size = New System.Drawing.Size(138, 17)
            Me.rbTratamientoAmbulatorio.TabIndex = 7
            Me.rbTratamientoAmbulatorio.Text = "Tratamiento ambulatorio"
            Me.rbTratamientoAmbulatorio.UseVisualStyleBackColor = True
            '
            'btnInimputable
            '
            Me.btnInimputable.BackgroundImage = Global.APPControls.My.Resources.Resources.centro_salud
            Me.btnInimputable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable.Location = New System.Drawing.Point(191, 16)
            Me.btnInimputable.Name = "btnInimputable"
            Me.btnInimputable.Size = New System.Drawing.Size(33, 33)
            Me.btnInimputable.TabIndex = 18
            Me.ToolTip1.SetToolTip(Me.btnInimputable, "Agregar información sobre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el lugar donde deberia cumplir la medida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de seguridad" &
        ".")
            Me.btnInimputable.UseVisualStyleBackColor = True
            '
            'gbComputo
            '
            Me.gbComputo.Controls.Add(Me.dtpFechaInicio)
            Me.gbComputo.Controls.Add(Me.Label6)
            Me.gbComputo.Controls.Add(Me.Label10)
            Me.gbComputo.Controls.Add(Me.dtpFechaFinal)
            Me.gbComputo.Controls.Add(Me.Panel4)
            Me.gbComputo.Controls.Add(Me.dgvPeriodoCondena)
            Me.gbComputo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gbComputo.Location = New System.Drawing.Point(0, 129)
            Me.gbComputo.Name = "gbComputo"
            Me.gbComputo.Size = New System.Drawing.Size(223, 68)
            Me.gbComputo.TabIndex = 100
            Me.gbComputo.TabStop = False
            Me.gbComputo.Text = "Cómputo"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Location = New System.Drawing.Point(133, 19)
            Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 101
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(80, 25)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(47, 13)
            Me.Label6.TabIndex = 100
            Me.Label6.Text = "F. Inicio:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(83, 48)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(43, 13)
            Me.Label10.TabIndex = 102
            Me.Label10.Text = "F. vcto:"
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Location = New System.Drawing.Point(133, 42)
            Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinal.TabIndex = 103
            Me.dtpFechaFinal.Value = "/  /"
            Me.dtpFechaFinal.ValueLong = CType(0, Long)
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.pnlMantPer)
            Me.Panel4.Controls.Add(Me.Panel5)
            Me.Panel4.Location = New System.Drawing.Point(3, 50)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(217, 22)
            Me.Panel4.TabIndex = 99
            Me.Panel4.Visible = False
            '
            'pnlMantPer
            '
            Me.pnlMantPer.Controls.Add(Me.btnEditPerCond)
            Me.pnlMantPer.Controls.Add(Me.btnAddPerCond)
            Me.pnlMantPer.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlMantPer.Location = New System.Drawing.Point(113, 0)
            Me.pnlMantPer.Name = "pnlMantPer"
            Me.pnlMantPer.Size = New System.Drawing.Size(74, 22)
            Me.pnlMantPer.TabIndex = 97
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Location = New System.Drawing.Point(45, 1)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(28, 24)
            Me.btnEditPerCond.TabIndex = 91
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Location = New System.Drawing.Point(17, 1)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(26, 24)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            '
            'dgvPeriodoCondena
            '
            Me.dgvPeriodoCondena.AllowUserToAddRows = False
            Me.dgvPeriodoCondena.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondena.AllowUserToResizeRows = False
            Me.dgvPeriodoCondena.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPeriodoCondena.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
            Me.dgvPeriodoCondena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item, Me.col_cod_ant, Me.col_ini_ant, Me.col_fin_ant, Me.col_eliminado})
            DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPeriodoCondena.DefaultCellStyle = DataGridViewCellStyle30
            Me.dgvPeriodoCondena.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(3, 30)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPeriodoCondena.RowHeadersDefaultCellStyle = DataGridViewCellStyle31
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle32
            Me.dgvPeriodoCondena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(217, 42)
            Me.dgvPeriodoCondena.TabIndex = 1
            Me.dgvPeriodoCondena.Visible = False
            Me.dgvPeriodoCondena.VisibleCampos = False
            '
            'col_ped_cond_item
            '
            Me.col_ped_cond_item.DataPropertyName = "PeriodoCondenaItem"
            Me.col_ped_cond_item.HeaderText = "PerCondItem"
            Me.col_ped_cond_item.Name = "col_ped_cond_item"
            Me.col_ped_cond_item.ReadOnly = True
            Me.col_ped_cond_item.Visible = False
            '
            'col_cod_ant
            '
            Me.col_cod_ant.HeaderText = "Codigo"
            Me.col_cod_ant.Name = "col_cod_ant"
            Me.col_cod_ant.ReadOnly = True
            Me.col_cod_ant.Visible = False
            Me.col_cod_ant.Width = 20
            '
            'col_ini_ant
            '
            Me.col_ini_ant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ini_ant.DataPropertyName = "FechaInicioString"
            Me.col_ini_ant.HeaderText = "F. inicio"
            Me.col_ini_ant.Name = "col_ini_ant"
            Me.col_ini_ant.ReadOnly = True
            '
            'col_fin_ant
            '
            Me.col_fin_ant.DataPropertyName = "FechaFinString"
            Me.col_fin_ant.HeaderText = "F. vcto."
            Me.col_fin_ant.Name = "col_fin_ant"
            Me.col_fin_ant.ReadOnly = True
            Me.col_fin_ant.Width = 85
            '
            'col_eliminado
            '
            Me.col_eliminado.DataPropertyName = "FlgEliminado"
            Me.col_eliminado.HeaderText = "Eliminado"
            Me.col_eliminado.Name = "col_eliminado"
            Me.col_eliminado.ReadOnly = True
            Me.col_eliminado.Visible = False
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
            'uscExpeDeResolucion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer2)
            Me.Name = "uscExpeDeResolucion"
            Me.Size = New System.Drawing.Size(807, 335)
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
            Me.Panel5.ResumeLayout(False)
            Me.SplitContainer2.Panel1.ResumeLayout(False)
            Me.SplitContainer2.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer2.ResumeLayout(False)
            Me.pnlExpediente.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCabExpediente.ResumeLayout(False)
            Me.pnlCabExpediente.PerformLayout()
            Me.pnlExpePermisos.ResumeLayout(False)
            Me.pnlEscrituraExpe.ResumeLayout(False)
            Me.pnlEliminarExpe.ResumeLayout(False)
            Me.pnlDuracionCondena.ResumeLayout(False)
            Me.gbDuracioncondena.ResumeLayout(False)
            Me.gbDuracioncondena.PerformLayout()
            Me.gbExentoInimputable.ResumeLayout(False)
            Me.gbExentoInimputable.PerformLayout()
            Me.gbComputo.ResumeLayout(False)
            Me.gbComputo.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.pnlMantPer.ResumeLayout(False)
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents pnlCabExpediente As System.Windows.Forms.Panel
        Friend WithEvents pnlExpePermisos As System.Windows.Forms.Panel
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents pnlEliminarDelito As System.Windows.Forms.Panel
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents lblExpedienteReferenciado As System.Windows.Forms.Label
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents dgwAgraviados As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_int_del_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_anulacion As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents colEliminarDelito As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_del_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nom_agrav As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_delito_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlEscrituraExpe As Panel
        Friend WithEvents pnlEliminarExpe As Panel
        Friend WithEvents pnlDelitoPermisos As Panel
        Friend WithEvents pnlAgravPermisos As Panel
        Friend WithEvents btnInimputable2 As Button
        Friend WithEvents pnlDuracionCondena As Panel
        Friend WithEvents gbComputo As GroupBox
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel4 As Panel
        Friend WithEvents Panel5 As Panel
        Friend WithEvents btnDelPerCond As Button
        Friend WithEvents btnEditPerCond As Button
        Friend WithEvents btnAddPerCond As Button
        Friend WithEvents rbCadenaperpetua As RadioButton
        Friend WithEvents rbTemporal As RadioButton
        Friend WithEvents col_ped_cond_item As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_ant As DataGridViewTextBoxColumn
        Friend WithEvents col_ini_ant As DataGridViewTextBoxColumn
        Friend WithEvents col_fin_ant As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As DataGridViewTextBoxColumn
        Friend WithEvents pnlExpediente As Panel
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
        Friend WithEvents col_subtip_lib_id As DataGridViewTextBoxColumn
        Friend WithEvents col_subtip_lib As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_aut As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_juez_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_exp_inim As DataGridViewTextBoxColumn
        Friend WithEvents col_est_men_id As DataGridViewTextBoxColumn
        Friend WithEvents col_est_men_des As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_inmp As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_conclu As DataGridViewTextBoxColumn
        Friend WithEvents col_conclu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_est_men_nue_des As DataGridViewTextBoxColumn
        Friend WithEvents col_est_men_nue_des_id As DataGridViewTextBoxColumn
        Friend WithEvents col_secre As DataGridViewTextBoxColumn
        Friend WithEvents col_flag As DataGridViewCheckBoxColumn
        Friend WithEvents gbExentoInimputable As GroupBox
        Friend WithEvents rbInternacion As RadioButton
        Friend WithEvents rbTratamientoAmbulatorio As RadioButton
        Friend WithEvents btnInimputable As Button
        Friend WithEvents pnlMantPer As Panel
        Friend WithEvents gbDuracioncondena As GroupBox
        Friend WithEvents Label8 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents dtpFechaFinal As Legolas.APPUIComponents.uscDateTimePicker
    End Class
End Namespace