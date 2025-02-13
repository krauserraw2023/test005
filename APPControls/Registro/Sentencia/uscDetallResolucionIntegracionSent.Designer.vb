Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscDetallResolucionIntegracionSent
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
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_man = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.pnlTituloExpediente = New System.Windows.Forms.Panel()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.pnlAnularExpediente = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlTiempoCondena = New System.Windows.Forms.Panel()
            Me.dgvPeriodoCondNueva = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin_ant = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlTituloNuevaCon = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.lblTituloFecha = New System.Windows.Forms.Label()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.col_agrav_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_delito_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_gen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlTituloDelitos = New System.Windows.Forms.Panel()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.btnAddAgrav = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelAgrav = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.pnlAgraviado = New System.Windows.Forms.Panel()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel12 = New System.Windows.Forms.Panel()
            Me.txtDias2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtAnios2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMeses2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblTiempoCondena = New System.Windows.Forms.Label()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTituloExpediente.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.pnlAnularExpediente.SuspendLayout()
            Me.pnlTiempoCondena.SuspendLayout()
            CType(Me.dgvPeriodoCondNueva, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel6.SuspendLayout()
            Me.pnlTituloNuevaCon.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTituloDelitos.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            Me.pnlAgraviado.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel12.SuspendLayout()
            Me.SuspendLayout()
            '
            'SplitContainer1
            '
            Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainer1.Name = "SplitContainer1"
            Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SplitContainer1.Panel1
            '
            Me.SplitContainer1.Panel1.Controls.Add(Me.dgwExpediente)
            Me.SplitContainer1.Panel1.Controls.Add(Me.pnlTituloExpediente)
            Me.SplitContainer1.Panel1.Controls.Add(Me.pnlTiempoCondena)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.dgwDelito)
            Me.SplitContainer1.Panel2.Controls.Add(Me.pnlTituloDelitos)
            Me.SplitContainer1.Panel2.Controls.Add(Me.pnlAgraviado)
            Me.SplitContainer1.Size = New System.Drawing.Size(807, 320)
            Me.SplitContainer1.SplitterDistance = 144
            Me.SplitContainer1.TabIndex = 2
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_exp_ref, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_num_exp, Me.col_aut_jud, Me.col_sal_jud, Me.col_secre, Me.col_fec_man, Me.col_eliminar, Me.col_flag})
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 28)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(593, 116)
            Me.dgwExpediente.TabIndex = 1
            Me.dgwExpediente.VisibleCampos = True
            '
            'col_sel
            '
            Me.col_sel.HeaderText = "Elegir"
            Me.col_sel.Name = "col_sel"
            Me.col_sel.Visible = False
            Me.col_sel.Width = 40
            '
            'col_exp_ref
            '
            Me.col_exp_ref.DataPropertyName = "ExpedienteRefIcon"
            Me.col_exp_ref.HeaderText = "Ref."
            Me.col_exp_ref.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_exp_ref.Name = "col_exp_ref"
            Me.col_exp_ref.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_ref.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
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
            'col_num_exp
            '
            Me.col_num_exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_num_exp.DataPropertyName = "ExpedienteNumero"
            Me.col_num_exp.HeaderText = "N° Exp."
            Me.col_num_exp.Name = "col_num_exp"
            Me.col_num_exp.ReadOnly = True
            '
            'col_aut_jud
            '
            Me.col_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_aut_jud.HeaderText = "Distrito Judicial"
            Me.col_aut_jud.Name = "col_aut_jud"
            Me.col_aut_jud.ReadOnly = True
            Me.col_aut_jud.Width = 180
            '
            'col_sal_jud
            '
            Me.col_sal_jud.DataPropertyName = "SalaJudicialNombre"
            Me.col_sal_jud.HeaderText = "Aut. Judicial"
            Me.col_sal_jud.Name = "col_sal_jud"
            Me.col_sal_jud.ReadOnly = True
            Me.col_sal_jud.Width = 190
            '
            'col_secre
            '
            Me.col_secre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_secre.DataPropertyName = "ExpedienteSecretario"
            Me.col_secre.HeaderText = "Secretario"
            Me.col_secre.Name = "col_secre"
            Me.col_secre.ReadOnly = True
            '
            'col_fec_man
            '
            Me.col_fec_man.DataPropertyName = "ExpedienteFechaDate"
            Me.col_fec_man.HeaderText = "Fec. Mandato"
            Me.col_fec_man.Name = "col_fec_man"
            Me.col_fec_man.Width = 98
            '
            'col_eliminar
            '
            Me.col_eliminar.DataPropertyName = "Eliminar"
            Me.col_eliminar.HeaderText = ""
            Me.col_eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_eliminar.Name = "col_eliminar"
            Me.col_eliminar.ReadOnly = True
            Me.col_eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_eliminar.Visible = False
            Me.col_eliminar.Width = 35
            '
            'col_flag
            '
            Me.col_flag.DataPropertyName = "Flagrancia"
            Me.col_flag.HeaderText = "C.F."
            Me.col_flag.Name = "col_flag"
            Me.col_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_flag.Width = 27
            '
            'pnlTituloExpediente
            '
            Me.pnlTituloExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTituloExpediente.Controls.Add(Me.pnlExpeMant)
            Me.pnlTituloExpediente.Controls.Add(Me.pnlAnularExpediente)
            Me.pnlTituloExpediente.Controls.Add(Me.lblNroExpedientes)
            Me.pnlTituloExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloExpediente.Name = "pnlTituloExpediente"
            Me.pnlTituloExpediente.Size = New System.Drawing.Size(593, 28)
            Me.pnlTituloExpediente.TabIndex = 0
            '
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.btnEditExpe)
            Me.pnlExpeMant.Controls.Add(Me.btnAddExp)
            Me.pnlExpeMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeMant.Location = New System.Drawing.Point(501, 0)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(60, 26)
            Me.pnlExpeMant.TabIndex = 1
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditExpe.Location = New System.Drawing.Point(30, 0)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 26)
            Me.btnEditExpe.TabIndex = 1
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAddExp.Location = New System.Drawing.Point(0, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 26)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'pnlAnularExpediente
            '
            Me.pnlAnularExpediente.Controls.Add(Me.btnEliminarExp)
            Me.pnlAnularExpediente.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAnularExpediente.Location = New System.Drawing.Point(561, 0)
            Me.pnlAnularExpediente.Name = "pnlAnularExpediente"
            Me.pnlAnularExpediente.Size = New System.Drawing.Size(30, 26)
            Me.pnlAnularExpediente.TabIndex = 2
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnEliminarExp.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarExp.TabIndex = 0
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(3, 6)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(126, 13)
            Me.lblNroExpedientes.TabIndex = 0
            Me.lblNroExpedientes.Text = "Expedientes : 0 Reg."
            '
            'pnlTiempoCondena
            '
            Me.pnlTiempoCondena.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlTiempoCondena.Controls.Add(Me.dgvPeriodoCondNueva)
            Me.pnlTiempoCondena.Controls.Add(Me.Panel6)
            Me.pnlTiempoCondena.Controls.Add(Me.pnlTituloNuevaCon)
            Me.pnlTiempoCondena.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlTiempoCondena.Location = New System.Drawing.Point(593, 0)
            Me.pnlTiempoCondena.Name = "pnlTiempoCondena"
            Me.pnlTiempoCondena.Size = New System.Drawing.Size(214, 144)
            Me.pnlTiempoCondena.TabIndex = 2
            '
            'dgvPeriodoCondNueva
            '
            Me.dgvPeriodoCondNueva.AllowUserToAddRows = False
            Me.dgvPeriodoCondNueva.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondNueva.AllowUserToResizeRows = False
            Me.dgvPeriodoCondNueva.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondNueva.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPeriodoCondNueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondNueva.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item_, Me.col_cod_ant, Me.col_ini_ant, Me.col_fin_ant, Me.col_eliminado_})
            Me.dgvPeriodoCondNueva.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPeriodoCondNueva.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondNueva.Location = New System.Drawing.Point(0, 52)
            Me.dgvPeriodoCondNueva.MultiSelect = False
            Me.dgvPeriodoCondNueva.Name = "dgvPeriodoCondNueva"
            Me.dgvPeriodoCondNueva.ReadOnly = True
            Me.dgvPeriodoCondNueva.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondNueva.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvPeriodoCondNueva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondNueva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondNueva.Size = New System.Drawing.Size(210, 88)
            Me.dgvPeriodoCondNueva.TabIndex = 2
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
            Me.col_ini_ant.HeaderText = "Inicio"
            Me.col_ini_ant.Name = "col_ini_ant"
            Me.col_ini_ant.ReadOnly = True
            '
            'col_fin_ant
            '
            Me.col_fin_ant.DataPropertyName = "FechaFinString"
            Me.col_fin_ant.HeaderText = "Fin"
            Me.col_fin_ant.Name = "col_fin_ant"
            Me.col_fin_ant.ReadOnly = True
            Me.col_fin_ant.Width = 95
            '
            'col_eliminado_
            '
            Me.col_eliminado_.DataPropertyName = "FlgEliminado"
            Me.col_eliminado_.HeaderText = "Eliminado"
            Me.col_eliminado_.Name = "col_eliminado_"
            Me.col_eliminado_.ReadOnly = True
            Me.col_eliminado_.Visible = False
            '
            'Panel6
            '
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.txtDias)
            Me.Panel6.Controls.Add(Me.Label10)
            Me.Panel6.Controls.Add(Me.txtAnios)
            Me.Panel6.Controls.Add(Me.Label13)
            Me.Panel6.Controls.Add(Me.Label14)
            Me.Panel6.Controls.Add(Me.txtMeses)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 26)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(210, 26)
            Me.Panel6.TabIndex = 1
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(176, 2)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(30, 20)
            Me.txtDias.TabIndex = 142
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(3, 4)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(31, 13)
            Me.Label10.TabIndex = 6
            Me.Label10.Text = "Años"
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.Location = New System.Drawing.Point(35, 2)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(30, 20)
            Me.txtAnios.TabIndex = 140
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(70, 5)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(38, 13)
            Me.Label13.TabIndex = 6
            Me.Label13.Text = "Meses"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.Location = New System.Drawing.Point(147, 6)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(28, 13)
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "Dias"
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(109, 2)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(30, 20)
            Me.txtMeses.TabIndex = 141
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'pnlTituloNuevaCon
            '
            Me.pnlTituloNuevaCon.Controls.Add(Me.Panel3)
            Me.pnlTituloNuevaCon.Controls.Add(Me.lblTituloFecha)
            Me.pnlTituloNuevaCon.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloNuevaCon.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloNuevaCon.Name = "pnlTituloNuevaCon"
            Me.pnlTituloNuevaCon.Size = New System.Drawing.Size(210, 26)
            Me.pnlTituloNuevaCon.TabIndex = 0
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnDelPerCond)
            Me.Panel3.Controls.Add(Me.btnEditPerCond)
            Me.Panel3.Controls.Add(Me.btnAddPerCond)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(122, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(88, 26)
            Me.Panel3.TabIndex = 1
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnDelPerCond.Location = New System.Drawing.Point(60, 0)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(28, 26)
            Me.btnDelPerCond.TabIndex = 2
            Me.btnDelPerCond.UseVisualStyleBackColor = True
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Location = New System.Drawing.Point(30, 1)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(28, 24)
            Me.btnEditPerCond.TabIndex = 1
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAddPerCond.Location = New System.Drawing.Point(0, 0)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(28, 26)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            '
            'lblTituloFecha
            '
            Me.lblTituloFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTituloFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTituloFecha.Location = New System.Drawing.Point(2, 4)
            Me.lblTituloFecha.Name = "lblTituloFecha"
            Me.lblTituloFecha.Size = New System.Drawing.Size(121, 17)
            Me.lblTituloFecha.TabIndex = 0
            Me.lblTituloFecha.Text = "Nueva Condena"
            Me.lblTituloFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_id, Me.col_del_esp_nom, Me.col_del_obs, Me.col_agrav, Me.col_tip_sent, Me.col_agrav_cod, Me.col_agrav_item, Me.col_agr_delito_item, Me.col_agr_exp_item, Me.col_agr_obs, Me.col_del_gen_id, Me.col_nom_del_gen})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 27)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(592, 145)
            Me.dgwDelito.TabIndex = 1
            '
            'col_int_del_id
            '
            Me.col_int_del_id.DataPropertyName = "Codigo"
            Me.col_int_del_id.HeaderText = "InternoDelitoId"
            Me.col_int_del_id.Name = "col_int_del_id"
            Me.col_int_del_id.ReadOnly = True
            Me.col_int_del_id.Visible = False
            Me.col_int_del_id.Width = 30
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
            'col_del_esp_id
            '
            Me.col_del_esp_id.DataPropertyName = "DelitoEspecifico"
            Me.col_del_esp_id.HeaderText = "DelidoEspecificoID"
            Me.col_del_esp_id.Name = "col_del_esp_id"
            Me.col_del_esp_id.Visible = False
            Me.col_del_esp_id.Width = 30
            '
            'col_del_esp_nom
            '
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.HeaderText = "Delito Especifico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            Me.col_del_esp_nom.Width = 290
            '
            'col_del_obs
            '
            Me.col_del_obs.DataPropertyName = "AgraviadoObservacion"
            Me.col_del_obs.HeaderText = "Observacion"
            Me.col_del_obs.Name = "col_del_obs"
            Me.col_del_obs.ReadOnly = True
            Me.col_del_obs.Visible = False
            Me.col_del_obs.Width = 130
            '
            'col_agrav
            '
            Me.col_agrav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_agrav.DataPropertyName = "AgraviadoNombre"
            Me.col_agrav.HeaderText = "Agraviado"
            Me.col_agrav.Name = "col_agrav"
            Me.col_agrav.ReadOnly = True
            '
            'col_tip_sent
            '
            Me.col_tip_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_sent.DataPropertyName = "TipoSentenciaId"
            Me.col_tip_sent.FillWeight = 300.0!
            Me.col_tip_sent.HeaderText = "Tipo de Sentencia"
            Me.col_tip_sent.Name = "col_tip_sent"
            Me.col_tip_sent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_tip_sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_tip_sent.Width = 150
            '
            'col_agrav_cod
            '
            Me.col_agrav_cod.HeaderText = "AgraviadoCodigo"
            Me.col_agrav_cod.Name = "col_agrav_cod"
            Me.col_agrav_cod.Visible = False
            Me.col_agrav_cod.Width = 30
            '
            'col_agrav_item
            '
            Me.col_agrav_item.HeaderText = "AgraviadoItem"
            Me.col_agrav_item.Name = "col_agrav_item"
            Me.col_agrav_item.ReadOnly = True
            Me.col_agrav_item.Visible = False
            Me.col_agrav_item.Width = 40
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
            'col_agr_obs
            '
            Me.col_agr_obs.DataPropertyName = "AgraviadoObservacion"
            Me.col_agr_obs.HeaderText = "Observacion"
            Me.col_agr_obs.Name = "col_agr_obs"
            Me.col_agr_obs.Visible = False
            Me.col_agr_obs.Width = 120
            '
            'col_del_gen_id
            '
            Me.col_del_gen_id.DataPropertyName = "DelitoGenerico"
            Me.col_del_gen_id.HeaderText = "DelitoGenericoID"
            Me.col_del_gen_id.Name = "col_del_gen_id"
            Me.col_del_gen_id.Visible = False
            Me.col_del_gen_id.Width = 80
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
            'pnlTituloDelitos
            '
            Me.pnlTituloDelitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTituloDelitos.Controls.Add(Me.pnlAgravMant)
            Me.pnlTituloDelitos.Controls.Add(Me.pnlEliminarAgraviado)
            Me.pnlTituloDelitos.Controls.Add(Me.Label5)
            Me.pnlTituloDelitos.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloDelitos.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloDelitos.Name = "pnlTituloDelitos"
            Me.pnlTituloDelitos.Size = New System.Drawing.Size(592, 27)
            Me.pnlTituloDelitos.TabIndex = 0
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnEditDelito)
            Me.pnlAgravMant.Controls.Add(Me.btnAddAgrav)
            Me.pnlAgravMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravMant.Location = New System.Drawing.Point(501, 0)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(58, 25)
            Me.pnlAgravMant.TabIndex = 1
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
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelAgrav)
            Me.pnlEliminarAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(559, 0)
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
            Me.btnDelAgrav.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(3, 6)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(143, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Delito(s) por Expediente"
            '
            'pnlAgraviado
            '
            Me.pnlAgraviado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlAgraviado.Controls.Add(Me.dgvPeriodoCondena)
            Me.pnlAgraviado.Controls.Add(Me.Panel12)
            Me.pnlAgraviado.Controls.Add(Me.lblTiempoCondena)
            Me.pnlAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgraviado.Location = New System.Drawing.Point(592, 0)
            Me.pnlAgraviado.Name = "pnlAgraviado"
            Me.pnlAgraviado.Size = New System.Drawing.Size(215, 172)
            Me.pnlAgraviado.TabIndex = 2
            '
            'dgvPeriodoCondena
            '
            Me.dgvPeriodoCondena.AllowUserToAddRows = False
            Me.dgvPeriodoCondena.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondena.AllowUserToResizeRows = False
            Me.dgvPeriodoCondena.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPeriodoCondena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item, Me.col_cod, Me.col_ini, Me.col_fin, Me.col_doc_jud_id, Me.col_eliminado})
            Me.dgvPeriodoCondena.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPeriodoCondena.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(0, 53)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(211, 115)
            Me.dgvPeriodoCondena.TabIndex = 2
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
            Me.col_ped_cond_item.Width = 10
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            Me.col_cod.Width = 30
            '
            'col_ini
            '
            Me.col_ini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ini.DataPropertyName = "FechaInicioString"
            DataGridViewCellStyle7.Format = "d"
            DataGridViewCellStyle7.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle7
            Me.col_ini.HeaderText = "Inicio"
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            '
            'col_fin
            '
            Me.col_fin.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle8.Format = "d"
            DataGridViewCellStyle8.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle8
            Me.col_fin.HeaderText = "Fin"
            Me.col_fin.Name = "col_fin"
            Me.col_fin.ReadOnly = True
            Me.col_fin.Width = 90
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
            'Panel12
            '
            Me.Panel12.Controls.Add(Me.txtDias2)
            Me.Panel12.Controls.Add(Me.txtAnios2)
            Me.Panel12.Controls.Add(Me.Label1)
            Me.Panel12.Controls.Add(Me.Label2)
            Me.Panel12.Controls.Add(Me.Label3)
            Me.Panel12.Controls.Add(Me.txtMeses2)
            Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel12.Location = New System.Drawing.Point(0, 27)
            Me.Panel12.Name = "Panel12"
            Me.Panel12.Size = New System.Drawing.Size(211, 26)
            Me.Panel12.TabIndex = 1
            '
            'txtDias2
            '
            Me.txtDias2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias2._BloquearPaste = False
            Me.txtDias2._SeleccionarTodo = False
            Me.txtDias2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias2.Location = New System.Drawing.Point(178, 3)
            Me.txtDias2.MaxLength = 3
            Me.txtDias2.Name = "txtDias2"
            Me.txtDias2.ReadOnly = True
            Me.txtDias2.Size = New System.Drawing.Size(30, 20)
            Me.txtDias2.TabIndex = 5
            Me.txtDias2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtAnios2
            '
            Me.txtAnios2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios2._BloquearPaste = False
            Me.txtAnios2._SeleccionarTodo = False
            Me.txtAnios2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios2.Location = New System.Drawing.Point(41, 3)
            Me.txtAnios2.MaxLength = 3
            Me.txtAnios2.Name = "txtAnios2"
            Me.txtAnios2.ReadOnly = True
            Me.txtAnios2.Size = New System.Drawing.Size(30, 20)
            Me.txtAnios2.TabIndex = 1
            Me.txtAnios2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(4, 6)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(31, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Años"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(72, 6)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(38, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Meses"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(149, 7)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(28, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Dias"
            '
            'txtMeses2
            '
            Me.txtMeses2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses2._BloquearPaste = False
            Me.txtMeses2._SeleccionarTodo = False
            Me.txtMeses2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses2.Location = New System.Drawing.Point(111, 3)
            Me.txtMeses2.MaxLength = 3
            Me.txtMeses2.Name = "txtMeses2"
            Me.txtMeses2.ReadOnly = True
            Me.txtMeses2.Size = New System.Drawing.Size(30, 20)
            Me.txtMeses2.TabIndex = 3
            Me.txtMeses2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblTiempoCondena
            '
            Me.lblTiempoCondena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblTiempoCondena.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblTiempoCondena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTiempoCondena.Location = New System.Drawing.Point(0, 0)
            Me.lblTiempoCondena.Name = "lblTiempoCondena"
            Me.lblTiempoCondena.Size = New System.Drawing.Size(211, 27)
            Me.lblTiempoCondena.TabIndex = 0
            Me.lblTiempoCondena.Text = "Tiempo de condena actual"
            Me.lblTiempoCondena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'uscDetallResolucionIntegracionSent
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer1)
            Me.Name = "uscDetallResolucionIntegracionSent"
            Me.Size = New System.Drawing.Size(807, 320)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTituloExpediente.ResumeLayout(False)
            Me.pnlTituloExpediente.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.pnlAnularExpediente.ResumeLayout(False)
            Me.pnlTiempoCondena.ResumeLayout(False)
            CType(Me.dgvPeriodoCondNueva, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.pnlTituloNuevaCon.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTituloDelitos.ResumeLayout(False)
            Me.pnlTituloDelitos.PerformLayout()
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.pnlAgraviado.ResumeLayout(False)
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel12.ResumeLayout(False)
            Me.Panel12.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents pnlTituloDelitos As System.Windows.Forms.Panel
        Friend WithEvents pnlAgravMant As System.Windows.Forms.Panel
        Friend WithEvents btnAddAgrav As System.Windows.Forms.Button
        Friend WithEvents btnEditDelito As System.Windows.Forms.Button
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents btnDelAgrav As System.Windows.Forms.Button
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlAgraviado As System.Windows.Forms.Panel
        Friend WithEvents lblTituloFecha As System.Windows.Forms.Label
        Friend WithEvents pnlTituloExpediente As System.Windows.Forms.Panel
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents pnlAnularExpediente As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlTiempoCondena As System.Windows.Forms.Panel
        Friend WithEvents lblTiempoCondena As System.Windows.Forms.Label
        Friend WithEvents dgvPeriodoCondNueva As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnEditPerCond As System.Windows.Forms.Button
        Friend WithEvents btnAddPerCond As System.Windows.Forms.Button
        Friend WithEvents pnlTituloNuevaCon As System.Windows.Forms.Panel
        Friend WithEvents btnDelPerCond As System.Windows.Forms.Button
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents col_ped_cond_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents txtDias2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnios2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents col_int_del_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agrav As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents col_agrav_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_delito_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_gen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_del_gen As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel12 As System.Windows.Forms.Panel
        Friend WithEvents col_ped_cond_item_ As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod_ant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ini_ant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fin_ant As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado_ As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlExpeMant As System.Windows.Forms.Panel
        Friend WithEvents col_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_exp_ref As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_exp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_secre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_man As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eliminar As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_flag As System.Windows.Forms.DataGridViewCheckBoxColumn
    End Class
End Namespace