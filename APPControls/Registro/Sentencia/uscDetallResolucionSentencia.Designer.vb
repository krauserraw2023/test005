Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDetallResolucionSentencia
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
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnInimputable2 = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlExpeElim = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.dgvPeriodoCondNueva = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.pnlMantPer = New System.Windows.Forms.Panel()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.rbCadenaperpetua = New System.Windows.Forms.RadioButton()
            Me.rbTemporal = New System.Windows.Forms.RadioButton()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbResolucion = New System.Windows.Forms.ComboBox()
            Me.lblCondenaAnterior = New System.Windows.Forms.Label()
            Me.pnlInmpMant = New System.Windows.Forms.Panel()
            Me.lblEstablecimientomental = New System.Windows.Forms.Label()
            Me.btnInimputable = New System.Windows.Forms.Button()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaFinal = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.pnlSuperior = New System.Windows.Forms.Panel()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_res_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_res_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_res_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id_tip_imim = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cen_sal_men = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlCondena = New System.Windows.Forms.Panel()
            Me.gbComputo = New System.Windows.Forms.GroupBox()
            Me.gbDuracioncondena = New System.Windows.Forms.GroupBox()
            Me.pnlInferior = New System.Windows.Forms.Panel()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_reso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_reso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_sent_hist = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sen_his_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_delito_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.lblResolucion = New System.Windows.Forms.Label()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnAddAgrav = New System.Windows.Forms.Button()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelAgrav = New System.Windows.Forms.Button()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlCondenahistorica = New System.Windows.Forms.Panel()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtDias2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMeses2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtAnios2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Panel2.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.pnlExpeElim.SuspendLayout()
            CType(Me.dgvPeriodoCondNueva, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlMantPer.SuspendLayout()
            Me.pnlInmpMant.SuspendLayout()
            Me.pnlSuperior.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlCondena.SuspendLayout()
            Me.gbComputo.SuspendLayout()
            Me.gbDuracioncondena.SuspendLayout()
            Me.pnlInferior.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel6.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            Me.pnlCondenahistorica.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlExpeMant)
            Me.Panel2.Controls.Add(Me.lblNroExpedientes)
            Me.Panel2.Controls.Add(Me.pnlExpeElim)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(598, 27)
            Me.Panel2.TabIndex = 0
            '
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.btnAddExp)
            Me.pnlExpeMant.Controls.Add(Me.btnInimputable2)
            Me.pnlExpeMant.Controls.Add(Me.btnEditExpe)
            Me.pnlExpeMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeMant.Location = New System.Drawing.Point(433, 0)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(128, 25)
            Me.pnlExpeMant.TabIndex = 1
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAddExp.Location = New System.Drawing.Point(68, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 25)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'btnInimputable2
            '
            Me.btnInimputable2.BackgroundImage = Global.APPControls.My.Resources.Resources.centro_salud
            Me.btnInimputable2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable2.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnInimputable2.Location = New System.Drawing.Point(0, 0)
            Me.btnInimputable2.Name = "btnInimputable2"
            Me.btnInimputable2.Size = New System.Drawing.Size(33, 25)
            Me.btnInimputable2.TabIndex = 18
            Me.btnInimputable2.UseVisualStyleBackColor = True
            Me.btnInimputable2.Visible = False
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditExpe.Location = New System.Drawing.Point(98, 0)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 25)
            Me.btnEditExpe.TabIndex = 1
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(4, 7)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(126, 13)
            Me.lblNroExpedientes.TabIndex = 0
            Me.lblNroExpedientes.Text = "Expedientes : 0 Reg."
            '
            'pnlExpeElim
            '
            Me.pnlExpeElim.Controls.Add(Me.btnEliminarExp)
            Me.pnlExpeElim.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeElim.Location = New System.Drawing.Point(561, 0)
            Me.pnlExpeElim.Name = "pnlExpeElim"
            Me.pnlExpeElim.Size = New System.Drawing.Size(35, 25)
            Me.pnlExpeElim.TabIndex = 2
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnEliminarExp.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(35, 25)
            Me.btnEliminarExp.TabIndex = 0
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'dgvPeriodoCondNueva
            '
            Me.dgvPeriodoCondNueva.AllowUserToAddRows = False
            Me.dgvPeriodoCondNueva.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondNueva.AllowUserToResizeRows = False
            Me.dgvPeriodoCondNueva.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondNueva.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPeriodoCondNueva.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvPeriodoCondNueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondNueva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item_, Me.col_cod_ant, Me.col_ini_ant, Me.col_fin_ant, Me.col_eliminado_})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPeriodoCondNueva.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPeriodoCondNueva.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondNueva.Location = New System.Drawing.Point(187, 51)
            Me.dgvPeriodoCondNueva.MultiSelect = False
            Me.dgvPeriodoCondNueva.Name = "dgvPeriodoCondNueva"
            Me.dgvPeriodoCondNueva.ReadOnly = True
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPeriodoCondNueva.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPeriodoCondNueva.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondNueva.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvPeriodoCondNueva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondNueva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondNueva.Size = New System.Drawing.Size(21, 26)
            Me.dgvPeriodoCondNueva.TabIndex = 1
            Me.dgvPeriodoCondNueva.Visible = False
            Me.dgvPeriodoCondNueva.VisibleCampos = True
            '
            'col_ped_cond_item_
            '
            Me.col_ped_cond_item_.DataPropertyName = "PeriodoCondenaItem"
            Me.col_ped_cond_item_.HeaderText = "PerCondItem"
            Me.col_ped_cond_item_.Name = "col_ped_cond_item_"
            Me.col_ped_cond_item_.ReadOnly = True
            Me.col_ped_cond_item_.Visible = False
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
            'col_eliminado_
            '
            Me.col_eliminado_.DataPropertyName = "FlgEliminado"
            Me.col_eliminado_.HeaderText = "Eliminado"
            Me.col_eliminado_.Name = "col_eliminado_"
            Me.col_eliminado_.ReadOnly = True
            Me.col_eliminado_.Visible = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.pnlMantPer)
            Me.Panel1.Location = New System.Drawing.Point(88, 47)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(95, 35)
            Me.Panel1.TabIndex = 96
            Me.Panel1.Visible = False
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnDelPerCond)
            Me.Panel4.Location = New System.Drawing.Point(64, 3)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(30, 26)
            Me.Panel4.TabIndex = 96
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Location = New System.Drawing.Point(2, 3)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(26, 24)
            Me.btnDelPerCond.TabIndex = 89
            Me.btnDelPerCond.UseVisualStyleBackColor = True
            '
            'pnlMantPer
            '
            Me.pnlMantPer.Controls.Add(Me.btnEditPerCond)
            Me.pnlMantPer.Controls.Add(Me.btnAddPerCond)
            Me.pnlMantPer.Location = New System.Drawing.Point(3, 3)
            Me.pnlMantPer.Name = "pnlMantPer"
            Me.pnlMantPer.Size = New System.Drawing.Size(62, 28)
            Me.pnlMantPer.TabIndex = 95
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Location = New System.Drawing.Point(30, 4)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(28, 24)
            Me.btnEditPerCond.TabIndex = 91
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Location = New System.Drawing.Point(2, 4)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(26, 24)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            '
            'rbCadenaperpetua
            '
            Me.rbCadenaperpetua.AutoSize = True
            Me.rbCadenaperpetua.Location = New System.Drawing.Point(10, 33)
            Me.rbCadenaperpetua.Name = "rbCadenaperpetua"
            Me.rbCadenaperpetua.Size = New System.Drawing.Size(107, 17)
            Me.rbCadenaperpetua.TabIndex = 8
            Me.rbCadenaperpetua.Text = "Cadena perpetua"
            Me.rbCadenaperpetua.UseVisualStyleBackColor = True
            '
            'rbTemporal
            '
            Me.rbTemporal.AutoSize = True
            Me.rbTemporal.Checked = True
            Me.rbTemporal.Location = New System.Drawing.Point(10, 15)
            Me.rbTemporal.Name = "rbTemporal"
            Me.rbTemporal.Size = New System.Drawing.Size(69, 17)
            Me.rbTemporal.TabIndex = 7
            Me.rbTemporal.TabStop = True
            Me.rbTemporal.Text = "Temporal"
            Me.rbTemporal.UseVisualStyleBackColor = True
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(179, 17)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(28, 13)
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Dias"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(143, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(38, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Meses"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(115, 15)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
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
            Me.txtAnios.Location = New System.Drawing.Point(117, 31)
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
            Me.txtDias.Location = New System.Drawing.Point(179, 31)
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
            Me.txtMeses.Location = New System.Drawing.Point(148, 31)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(28, 20)
            Me.txtMeses.TabIndex = 2
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'cbbResolucion
            '
            Me.cbbResolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbResolucion.DropDownWidth = 250
            Me.cbbResolucion.FormattingEnabled = True
            Me.cbbResolucion.Location = New System.Drawing.Point(309, 2)
            Me.cbbResolucion.Name = "cbbResolucion"
            Me.cbbResolucion.Size = New System.Drawing.Size(121, 21)
            Me.cbbResolucion.TabIndex = 2
            Me.cbbResolucion.Visible = False
            '
            'lblCondenaAnterior
            '
            Me.lblCondenaAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblCondenaAnterior.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblCondenaAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCondenaAnterior.Location = New System.Drawing.Point(0, 0)
            Me.lblCondenaAnterior.Name = "lblCondenaAnterior"
            Me.lblCondenaAnterior.Size = New System.Drawing.Size(212, 27)
            Me.lblCondenaAnterior.TabIndex = 86
            Me.lblCondenaAnterior.Text = "Duración de la condena anterior"
            Me.lblCondenaAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlInmpMant
            '
            Me.pnlInmpMant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInmpMant.Controls.Add(Me.lblEstablecimientomental)
            Me.pnlInmpMant.Controls.Add(Me.btnInimputable)
            Me.pnlInmpMant.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlInmpMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlInmpMant.Name = "pnlInmpMant"
            Me.pnlInmpMant.Size = New System.Drawing.Size(212, 27)
            Me.pnlInmpMant.TabIndex = 98
            Me.pnlInmpMant.Visible = False
            '
            'lblEstablecimientomental
            '
            Me.lblEstablecimientomental.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblEstablecimientomental.AutoSize = True
            Me.lblEstablecimientomental.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEstablecimientomental.Location = New System.Drawing.Point(11, 6)
            Me.lblEstablecimientomental.Name = "lblEstablecimientomental"
            Me.lblEstablecimientomental.Size = New System.Drawing.Size(164, 13)
            Me.lblEstablecimientomental.TabIndex = 19
            Me.lblEstablecimientomental.Text = "Establecimiento de salud mental: "
            Me.lblEstablecimientomental.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'btnInimputable
            '
            Me.btnInimputable.BackgroundImage = Global.APPControls.My.Resources.Resources.hospital
            Me.btnInimputable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnInimputable.Location = New System.Drawing.Point(177, 0)
            Me.btnInimputable.Name = "btnInimputable"
            Me.btnInimputable.Size = New System.Drawing.Size(33, 25)
            Me.btnInimputable.TabIndex = 18
            Me.btnInimputable.UseVisualStyleBackColor = True
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(50, 41)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(43, 13)
            Me.Label10.TabIndex = 99
            Me.Label10.Text = "F. vcto:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicio.Location = New System.Drawing.Point(117, 14)
            Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 98
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFinal.Location = New System.Drawing.Point(117, 39)
            Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinal.TabIndex = 100
            Me.dtpFechaFinal.Value = "/  /"
            Me.dtpFechaFinal.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(50, 18)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(47, 13)
            Me.Label6.TabIndex = 97
            Me.Label6.Text = "F. Inicio:"
            '
            'pnlSuperior
            '
            Me.pnlSuperior.Controls.Add(Me.dgwExpediente)
            Me.pnlSuperior.Controls.Add(Me.Panel2)
            Me.pnlSuperior.Controls.Add(Me.pnlCondena)
            Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
            Me.pnlSuperior.Name = "pnlSuperior"
            Me.pnlSuperior.Size = New System.Drawing.Size(810, 150)
            Me.pnlSuperior.TabIndex = 146
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.col_exp_ref, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_exp_res_id, Me.col_exp_res_nom, Me.col_exp_res_btn, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewImageColumn3, Me.col_flag, Me.col_id_tip_imim, Me.col_id_cen_sal_men})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwExpediente.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 27)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(598, 123)
            Me.dgwExpediente.TabIndex = 148
            Me.dgwExpediente.VisibleCampos = True
            '
            'DataGridViewCheckBoxColumn1
            '
            Me.DataGridViewCheckBoxColumn1.HeaderText = "Elegir"
            Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
            Me.DataGridViewCheckBoxColumn1.Visible = False
            Me.DataGridViewCheckBoxColumn1.Width = 40
            '
            'col_exp_ref
            '
            Me.col_exp_ref.DataPropertyName = "ExpedienteRefIcon"
            Me.col_exp_ref.HeaderText = "Ref."
            Me.col_exp_ref.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_exp_ref.Name = "col_exp_ref"
            Me.col_exp_ref.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_ref.Width = 27
            '
            'col_item
            '
            Me.col_item.DataPropertyName = "ExpedienteItem"
            Me.col_item.HeaderText = "ExpItem"
            Me.col_item.Name = "col_item"
            Me.col_item.Visible = False
            Me.col_item.Width = 20
            '
            'codigo
            '
            Me.codigo.DataPropertyName = "Codigo"
            Me.codigo.DividerWidth = 1
            Me.codigo.HeaderText = "Codigo"
            Me.codigo.Name = "codigo"
            Me.codigo.ReadOnly = True
            Me.codigo.Visible = False
            '
            'col_doc_jdu_id
            '
            Me.col_doc_jdu_id.DataPropertyName = "CreaDocJudicialId"
            Me.col_doc_jdu_id.DividerWidth = 1
            Me.col_doc_jdu_id.HeaderText = "DocJudicialId"
            Me.col_doc_jdu_id.Name = "col_doc_jdu_id"
            Me.col_doc_jdu_id.ReadOnly = True
            Me.col_doc_jdu_id.Visible = False
            '
            'col_exp_res_id
            '
            Me.col_exp_res_id.DataPropertyName = "ResolucionID"
            Me.col_exp_res_id.HeaderText = "Resolucion ID"
            Me.col_exp_res_id.Name = "col_exp_res_id"
            Me.col_exp_res_id.Visible = False
            '
            'col_exp_res_nom
            '
            Me.col_exp_res_nom.DataPropertyName = "ResolucionNom"
            Me.col_exp_res_nom.HeaderText = "Resolucion"
            Me.col_exp_res_nom.Name = "col_exp_res_nom"
            Me.col_exp_res_nom.ToolTipText = "Nombre de la Resolucion"
            Me.col_exp_res_nom.Visible = False
            '
            'col_exp_res_btn
            '
            Me.col_exp_res_btn.HeaderText = ""
            Me.col_exp_res_btn.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.col_exp_res_btn.Name = "col_exp_res_btn"
            Me.col_exp_res_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_res_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_res_btn.Visible = False
            Me.col_exp_res_btn.Width = 20
            '
            'DataGridViewTextBoxColumn6
            '
            Me.DataGridViewTextBoxColumn6.DataPropertyName = "ExpedienteNumero"
            Me.DataGridViewTextBoxColumn6.HeaderText = "N° Exp."
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.ReadOnly = True
            '
            'DataGridViewTextBoxColumn7
            '
            Me.DataGridViewTextBoxColumn7.DataPropertyName = "AutoridadJudicialNombre"
            Me.DataGridViewTextBoxColumn7.HeaderText = "Distrito Judicial"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.ReadOnly = True
            Me.DataGridViewTextBoxColumn7.Width = 190
            '
            'DataGridViewTextBoxColumn8
            '
            Me.DataGridViewTextBoxColumn8.DataPropertyName = "SalaJudicialNombre"
            Me.DataGridViewTextBoxColumn8.HeaderText = "Aut. Judicial"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.ReadOnly = True
            Me.DataGridViewTextBoxColumn8.Width = 190
            '
            'DataGridViewTextBoxColumn9
            '
            Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn9.DataPropertyName = "ExpedienteSecretario"
            Me.DataGridViewTextBoxColumn9.HeaderText = "Secretario"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.ReadOnly = True
            '
            'DataGridViewImageColumn3
            '
            Me.DataGridViewImageColumn3.DataPropertyName = "Eliminar"
            Me.DataGridViewImageColumn3.HeaderText = ""
            Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
            Me.DataGridViewImageColumn3.ReadOnly = True
            Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn3.Visible = False
            Me.DataGridViewImageColumn3.Width = 35
            '
            'col_flag
            '
            Me.col_flag.DataPropertyName = "Flagrancia"
            Me.col_flag.HeaderText = "C.F."
            Me.col_flag.Name = "col_flag"
            Me.col_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_flag.Width = 30
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
            'pnlCondena
            '
            Me.pnlCondena.Controls.Add(Me.gbComputo)
            Me.pnlCondena.Controls.Add(Me.gbDuracioncondena)
            Me.pnlCondena.Controls.Add(Me.pnlInmpMant)
            Me.pnlCondena.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlCondena.Location = New System.Drawing.Point(598, 0)
            Me.pnlCondena.Name = "pnlCondena"
            Me.pnlCondena.Size = New System.Drawing.Size(212, 150)
            Me.pnlCondena.TabIndex = 147
            '
            'gbComputo
            '
            Me.gbComputo.Controls.Add(Me.Label10)
            Me.gbComputo.Controls.Add(Me.dtpFechaFinal)
            Me.gbComputo.Controls.Add(Me.Label6)
            Me.gbComputo.Controls.Add(Me.dtpFechaInicio)
            Me.gbComputo.Controls.Add(Me.Panel1)
            Me.gbComputo.Controls.Add(Me.dgvPeriodoCondNueva)
            Me.gbComputo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbComputo.Location = New System.Drawing.Point(0, 85)
            Me.gbComputo.Name = "gbComputo"
            Me.gbComputo.Size = New System.Drawing.Size(212, 65)
            Me.gbComputo.TabIndex = 102
            Me.gbComputo.TabStop = False
            Me.gbComputo.Text = "Cómputo"
            '
            'gbDuracioncondena
            '
            Me.gbDuracioncondena.Controls.Add(Me.rbCadenaperpetua)
            Me.gbDuracioncondena.Controls.Add(Me.rbTemporal)
            Me.gbDuracioncondena.Controls.Add(Me.Label4)
            Me.gbDuracioncondena.Controls.Add(Me.txtMeses)
            Me.gbDuracioncondena.Controls.Add(Me.txtAnios)
            Me.gbDuracioncondena.Controls.Add(Me.Label8)
            Me.gbDuracioncondena.Controls.Add(Me.Label7)
            Me.gbDuracioncondena.Controls.Add(Me.txtDias)
            Me.gbDuracioncondena.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbDuracioncondena.Location = New System.Drawing.Point(0, 27)
            Me.gbDuracioncondena.Name = "gbDuracioncondena"
            Me.gbDuracioncondena.Size = New System.Drawing.Size(212, 58)
            Me.gbDuracioncondena.TabIndex = 101
            Me.gbDuracioncondena.TabStop = False
            Me.gbDuracioncondena.Text = "Duración de la condena"
            '
            'pnlInferior
            '
            Me.pnlInferior.Controls.Add(Me.dgwDelito)
            Me.pnlInferior.Controls.Add(Me.Panel6)
            Me.pnlInferior.Controls.Add(Me.pnlCondenahistorica)
            Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlInferior.Location = New System.Drawing.Point(0, 150)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(810, 176)
            Me.pnlInferior.TabIndex = 148
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_nom, Me.col_agrav, Me.col_tip_reso_id, Me.col_tip_reso, Me.col_tip_sent_id, Me.col_tip_sent, Me.col_agr_btn, Me.col_sent_hist, Me.col_sen_his_id, Me.col_agrav_cod, Me.col_agrav_item, Me.col_agr_delito_item, Me.col_agr_exp_item, Me.col_del_obs, Me.col_nom_del_gen})
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 27)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(598, 149)
            Me.dgwDelito.TabIndex = 148
            '
            'col_int_del_id
            '
            Me.col_int_del_id.DataPropertyName = "Codigo"
            Me.col_int_del_id.HeaderText = "InternoDelitoId"
            Me.col_int_del_id.Name = "col_int_del_id"
            Me.col_int_del_id.ReadOnly = True
            Me.col_int_del_id.Visible = False
            Me.col_int_del_id.Width = 40
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
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.HeaderText = "Delito Especifico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            Me.col_del_esp_nom.Width = 250
            '
            'col_agrav
            '
            Me.col_agrav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_agrav.HeaderText = "Agraviado"
            Me.col_agrav.Name = "col_agrav"
            Me.col_agrav.ReadOnly = True
            '
            'col_tip_reso_id
            '
            Me.col_tip_reso_id.DataPropertyName = "ResolucionID"
            Me.col_tip_reso_id.HeaderText = "Resolucion ID"
            Me.col_tip_reso_id.Name = "col_tip_reso_id"
            Me.col_tip_reso_id.Visible = False
            Me.col_tip_reso_id.Width = 30
            '
            'col_tip_reso
            '
            Me.col_tip_reso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_reso.DataPropertyName = "ResolucionNom"
            Me.col_tip_reso.HeaderText = "Resolucion"
            Me.col_tip_reso.Name = "col_tip_reso"
            Me.col_tip_reso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_tip_reso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_tip_reso.Width = 98
            '
            'col_tip_sent_id
            '
            Me.col_tip_sent_id.HeaderText = "Sentencia ID"
            Me.col_tip_sent_id.Name = "col_tip_sent_id"
            Me.col_tip_sent_id.Visible = False
            '
            'col_tip_sent
            '
            Me.col_tip_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_sent.HeaderText = "Nueva Sentencia"
            Me.col_tip_sent.Name = "col_tip_sent"
            Me.col_tip_sent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_tip_sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_tip_sent.Width = 130
            '
            'col_agr_btn
            '
            Me.col_agr_btn.HeaderText = ""
            Me.col_agr_btn.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.col_agr_btn.Name = "col_agr_btn"
            Me.col_agr_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_agr_btn.Width = 15
            '
            'col_sent_hist
            '
            Me.col_sent_hist.DataPropertyName = "TipoSentenciaHistoricoNombre"
            Me.col_sent_hist.HeaderText = "Sentencia anterior"
            Me.col_sent_hist.Name = "col_sent_hist"
            Me.col_sent_hist.ReadOnly = True
            Me.col_sent_hist.Width = 116
            '
            'col_sen_his_id
            '
            Me.col_sen_his_id.DataPropertyName = "TipoSentenciaHistoricoId"
            Me.col_sen_his_id.HeaderText = "SentenciaAntID"
            Me.col_sen_his_id.Name = "col_sen_his_id"
            Me.col_sen_his_id.Visible = False
            Me.col_sen_his_id.Width = 40
            '
            'col_agrav_cod
            '
            Me.col_agrav_cod.HeaderText = "AgraviadoCodigo"
            Me.col_agrav_cod.Name = "col_agrav_cod"
            Me.col_agrav_cod.Visible = False
            Me.col_agrav_cod.Width = 40
            '
            'col_agrav_item
            '
            Me.col_agrav_item.HeaderText = "AgraviadoItem"
            Me.col_agrav_item.Name = "col_agrav_item"
            Me.col_agrav_item.ReadOnly = True
            Me.col_agrav_item.Visible = False
            Me.col_agrav_item.Width = 20
            '
            'col_agr_delito_item
            '
            Me.col_agr_delito_item.HeaderText = "AgraviadoDelitoItem"
            Me.col_agr_delito_item.Name = "col_agr_delito_item"
            Me.col_agr_delito_item.Visible = False
            Me.col_agr_delito_item.Width = 40
            '
            'col_agr_exp_item
            '
            Me.col_agr_exp_item.HeaderText = "AgraviadoExpItem"
            Me.col_agr_exp_item.Name = "col_agr_exp_item"
            Me.col_agr_exp_item.Visible = False
            Me.col_agr_exp_item.Width = 40
            '
            'col_del_obs
            '
            Me.col_del_obs.DataPropertyName = "Observacion"
            Me.col_del_obs.HeaderText = "Observacion"
            Me.col_del_obs.Name = "col_del_obs"
            Me.col_del_obs.ReadOnly = True
            Me.col_del_obs.Visible = False
            Me.col_del_obs.Width = 70
            '
            'col_nom_del_gen
            '
            Me.col_nom_del_gen.DataPropertyName = "DelitoGenericoNombre"
            Me.col_nom_del_gen.DividerWidth = 1
            Me.col_nom_del_gen.HeaderText = "Delito Generico"
            Me.col_nom_del_gen.Name = "col_nom_del_gen"
            Me.col_nom_del_gen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.col_nom_del_gen.Visible = False
            Me.col_nom_del_gen.Width = 300
            '
            'Panel6
            '
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.lblResolucion)
            Me.Panel6.Controls.Add(Me.cbbResolucion)
            Me.Panel6.Controls.Add(Me.pnlAgravMant)
            Me.Panel6.Controls.Add(Me.pnlEliminarAgraviado)
            Me.Panel6.Controls.Add(Me.Label11)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(598, 27)
            Me.Panel6.TabIndex = 147
            '
            'lblResolucion
            '
            Me.lblResolucion.AutoSize = True
            Me.lblResolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblResolucion.Location = New System.Drawing.Point(231, 5)
            Me.lblResolucion.Name = "lblResolucion"
            Me.lblResolucion.Size = New System.Drawing.Size(74, 13)
            Me.lblResolucion.TabIndex = 1
            Me.lblResolucion.Text = "Resolución:"
            Me.lblResolucion.Visible = False
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnAddAgrav)
            Me.pnlAgravMant.Controls.Add(Me.btnEditDelito)
            Me.pnlAgravMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravMant.Location = New System.Drawing.Point(507, 0)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(58, 25)
            Me.pnlAgravMant.TabIndex = 3
            '
            'btnAddAgrav
            '
            Me.btnAddAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddAgrav.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAddAgrav.Location = New System.Drawing.Point(0, 0)
            Me.btnAddAgrav.Name = "btnAddAgrav"
            Me.btnAddAgrav.Size = New System.Drawing.Size(28, 25)
            Me.btnAddAgrav.TabIndex = 0
            Me.btnAddAgrav.UseVisualStyleBackColor = True
            '
            'btnEditDelito
            '
            Me.btnEditDelito.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDelito.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditDelito.Location = New System.Drawing.Point(30, 0)
            Me.btnEditDelito.Name = "btnEditDelito"
            Me.btnEditDelito.Size = New System.Drawing.Size(28, 25)
            Me.btnEditDelito.TabIndex = 1
            Me.btnEditDelito.UseVisualStyleBackColor = True
            '
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelAgrav)
            Me.pnlEliminarAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(565, 0)
            Me.pnlEliminarAgraviado.Name = "pnlEliminarAgraviado"
            Me.pnlEliminarAgraviado.Size = New System.Drawing.Size(31, 25)
            Me.pnlEliminarAgraviado.TabIndex = 3
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
            Me.btnDelAgrav.UseVisualStyleBackColor = True
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(4, 5)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(143, 13)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Delito(s) por Expediente"
            '
            'pnlCondenahistorica
            '
            Me.pnlCondenahistorica.Controls.Add(Me.dgvPeriodoCondena)
            Me.pnlCondenahistorica.Controls.Add(Me.Panel3)
            Me.pnlCondenahistorica.Controls.Add(Me.lblCondenaAnterior)
            Me.pnlCondenahistorica.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlCondenahistorica.Location = New System.Drawing.Point(598, 0)
            Me.pnlCondenahistorica.Name = "pnlCondenahistorica"
            Me.pnlCondenahistorica.Size = New System.Drawing.Size(212, 176)
            Me.pnlCondenahistorica.TabIndex = 146
            '
            'dgvPeriodoCondena
            '
            Me.dgvPeriodoCondena.AllowUserToAddRows = False
            Me.dgvPeriodoCondena.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondena.AllowUserToResizeRows = False
            Me.dgvPeriodoCondena.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPeriodoCondena.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.dgvPeriodoCondena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item, Me.col_cod, Me.col_ini, Me.col_fin, Me.col_doc_jud_id, Me.col_eliminado})
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvPeriodoCondena.DefaultCellStyle = DataGridViewCellStyle16
            Me.dgvPeriodoCondena.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPeriodoCondena.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(0, 50)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvPeriodoCondena.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle18
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(212, 126)
            Me.dgvPeriodoCondena.TabIndex = 147
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
            DataGridViewCellStyle14.Format = "d"
            DataGridViewCellStyle14.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle14
            Me.col_ini.HeaderText = "Inicio"
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            '
            'col_fin
            '
            Me.col_fin.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle15.Format = "d"
            DataGridViewCellStyle15.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle15
            Me.col_fin.HeaderText = "Fin"
            Me.col_fin.Name = "col_fin"
            Me.col_fin.ReadOnly = True
            Me.col_fin.Width = 85
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "DocJudicialId"
            Me.col_doc_jud_id.DividerWidth = 1
            Me.col_doc_jud_id.HeaderText = "DocJudId"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.ReadOnly = True
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 40
            '
            'col_eliminado
            '
            Me.col_eliminado.DataPropertyName = "FlgEliminado"
            Me.col_eliminado.DividerWidth = 1
            Me.col_eliminado.HeaderText = "Eliminado"
            Me.col_eliminado.Name = "col_eliminado"
            Me.col_eliminado.ReadOnly = True
            Me.col_eliminado.Visible = False
            Me.col_eliminado.Width = 90
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.txtDias2)
            Me.Panel3.Controls.Add(Me.txtMeses2)
            Me.Panel3.Controls.Add(Me.txtAnios2)
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Controls.Add(Me.Label3)
            Me.Panel3.Controls.Add(Me.Label9)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 27)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(212, 23)
            Me.Panel3.TabIndex = 146
            '
            'txtDias2
            '
            Me.txtDias2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias2._BloquearPaste = False
            Me.txtDias2._SeleccionarTodo = False
            Me.txtDias2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias2.Location = New System.Drawing.Point(160, 1)
            Me.txtDias2.MaxLength = 3
            Me.txtDias2.Name = "txtDias2"
            Me.txtDias2.ReadOnly = True
            Me.txtDias2.Size = New System.Drawing.Size(30, 20)
            Me.txtDias2.TabIndex = 3
            Me.txtDias2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtMeses2
            '
            Me.txtMeses2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses2._BloquearPaste = False
            Me.txtMeses2._SeleccionarTodo = False
            Me.txtMeses2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses2.Location = New System.Drawing.Point(101, 1)
            Me.txtMeses2.MaxLength = 3
            Me.txtMeses2.Name = "txtMeses2"
            Me.txtMeses2.ReadOnly = True
            Me.txtMeses2.Size = New System.Drawing.Size(30, 20)
            Me.txtMeses2.TabIndex = 2
            Me.txtMeses2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtAnios2
            '
            Me.txtAnios2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios2._BloquearPaste = False
            Me.txtAnios2._SeleccionarTodo = False
            Me.txtAnios2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios2.Location = New System.Drawing.Point(32, 1)
            Me.txtAnios2.MaxLength = 3
            Me.txtAnios2.Name = "txtAnios2"
            Me.txtAnios2.ReadOnly = True
            Me.txtAnios2.Size = New System.Drawing.Size(30, 20)
            Me.txtAnios2.TabIndex = 1
            Me.txtAnios2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(1, 3)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 13)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Años"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(62, 4)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(38, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Meses"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(131, 5)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(28, 13)
            Me.Label9.TabIndex = 6
            Me.Label9.Text = "Dias"
            '
            'uscDetallResolucionSentencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlInferior)
            Me.Controls.Add(Me.pnlSuperior)
            Me.Name = "uscDetallResolucionSentencia"
            Me.Size = New System.Drawing.Size(810, 326)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.pnlExpeElim.ResumeLayout(False)
            CType(Me.dgvPeriodoCondNueva, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.pnlMantPer.ResumeLayout(False)
            Me.pnlInmpMant.ResumeLayout(False)
            Me.pnlInmpMant.PerformLayout()
            Me.pnlSuperior.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlCondena.ResumeLayout(False)
            Me.gbComputo.ResumeLayout(False)
            Me.gbComputo.PerformLayout()
            Me.gbDuracioncondena.ResumeLayout(False)
            Me.gbDuracioncondena.PerformLayout()
            Me.pnlInferior.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.pnlCondenahistorica.ResumeLayout(False)
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlExpeElim As System.Windows.Forms.Panel
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents lblCondenaAnterior As System.Windows.Forms.Label
        Friend WithEvents dgvPeriodoCondNueva As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents btnDelPerCond As System.Windows.Forms.Button
        Friend WithEvents cbbResolucion As System.Windows.Forms.ComboBox
        Friend WithEvents pnlExpeMant As System.Windows.Forms.Panel
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents btnAddPerCond As System.Windows.Forms.Button
        Friend WithEvents btnEditPerCond As System.Windows.Forms.Button
        Friend WithEvents col_ped_cond_item_ As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_ant As DataGridViewTextBoxColumn
        Friend WithEvents col_ini_ant As DataGridViewTextBoxColumn
        Friend WithEvents col_fin_ant As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado_ As DataGridViewTextBoxColumn
        Friend WithEvents pnlMantPer As Panel
        Friend WithEvents rbCadenaperpetua As RadioButton
        Friend WithEvents rbTemporal As RadioButton
        Friend WithEvents Panel4 As Panel
        Friend WithEvents btnInimputable2 As Button
        Friend WithEvents pnlInmpMant As Panel
        Friend WithEvents lblEstablecimientomental As Label
        Friend WithEvents btnInimputable As Button
        Friend WithEvents Label10 As Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFechaFinal As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents pnlSuperior As Panel
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlCondena As Panel
        Friend WithEvents gbComputo As GroupBox
        Friend WithEvents gbDuracioncondena As GroupBox
        Friend WithEvents pnlInferior As Panel
        Friend WithEvents dgwDelito As DataGridView
        Friend WithEvents Panel6 As Panel
        Friend WithEvents lblResolucion As Label
        Friend WithEvents pnlAgravMant As Panel
        Friend WithEvents btnAddAgrav As Button
        Friend WithEvents btnEditDelito As Button
        Friend WithEvents pnlEliminarAgraviado As Panel
        Friend WithEvents btnDelAgrav As Button
        Friend WithEvents Label11 As Label
        Friend WithEvents pnlCondenahistorica As Panel
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_ped_cond_item As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_ini As DataGridViewTextBoxColumn
        Friend WithEvents col_fin As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As DataGridViewTextBoxColumn
        Friend WithEvents Panel3 As Panel
        Friend WithEvents txtDias2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnios2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents col_int_del_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_reso_id As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_reso As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent_id As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_btn As DataGridViewImageColumn
        Friend WithEvents col_sent_hist As DataGridViewTextBoxColumn
        Friend WithEvents col_sen_his_id As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_delito_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_del_gen As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
        Friend WithEvents col_exp_ref As DataGridViewImageColumn
        Friend WithEvents col_item As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_res_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_res_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_res_btn As DataGridViewImageColumn
        Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
        Friend WithEvents col_flag As DataGridViewCheckBoxColumn
        Friend WithEvents col_id_tip_imim As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cen_sal_men As DataGridViewTextBoxColumn
    End Class
End Namespace