Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscDetallRegistroSentenciaGrilla
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
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_art = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_tip_sen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_agrav_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_delito_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pnlMantBotAgraviados = New System.Windows.Forms.Panel()
            Me.btnAddDelito = New System.Windows.Forms.Button()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnDelDelito = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sit_jur = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_id_tip_imim = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cen_sal_men = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlTituloExpediente = New System.Windows.Forms.Panel()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.btnInimputable = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlTiempoConde = New System.Windows.Forms.Panel()
            Me.gbComputo = New System.Windows.Forms.GroupBox()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlMantBotPeriCondena = New System.Windows.Forms.Panel()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.gbDuracioncondena = New System.Windows.Forms.GroupBox()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.txtAutoridadJudicial = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDistritoJudicial = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlAnularExpediente = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaFinal = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbtCadenaperpetua = New System.Windows.Forms.RadioButton()
            Me.rbtTemporal = New System.Windows.Forms.RadioButton()
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.pnlObsInimputable = New System.Windows.Forms.Panel()
            Me.txtEstablecimientomental = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label13 = New System.Windows.Forms.Label()
            Me.dtpFechRecepDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.dtpFechSenDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.grbCabecera.SuspendLayout()
            Me.Panel7.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.pnlMantBotAgraviados.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel5.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTituloExpediente.SuspendLayout()
            Me.pnlTiempoConde.SuspendLayout()
            Me.gbComputo.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlMantBotPeriCondena.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlAnularExpediente.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlObsInimputable.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.SuspendLayout()
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn1.Width = 20
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.Panel7)
            Me.grbCabecera.Controls.Add(Me.Panel5)
            Me.grbCabecera.Controls.Add(Me.pnlCabecera)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(807, 365)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            Me.grbCabecera.Text = "Referencia de la Sentencia"
            '
            'Panel7
            '
            Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel7.Controls.Add(Me.dgwDelito)
            Me.Panel7.Controls.Add(Me.Panel3)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel7.Location = New System.Drawing.Point(3, 232)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(801, 130)
            Me.Panel7.TabIndex = 4
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nro, Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_nom, Me.col_del_art, Me.col_agrav, Me.col_id_tip_sen, Me.col_tip_sent, Me.col_agr_btn, Me.col_agrav_cod, Me.col_agrav_item, Me.col_agr_delito_item, Me.col_agr_exp_item, Me.col_del_obs, Me.col_nom_del_gen})
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 26)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(799, 102)
            Me.dgwDelito.TabIndex = 2
            '
            'col_nro
            '
            Me.col_nro.FillWeight = 150.0!
            Me.col_nro.Frozen = True
            Me.col_nro.HeaderText = "N°"
            Me.col_nro.Name = "col_nro"
            Me.col_nro.Width = 30
            '
            'col_int_del_id
            '
            Me.col_int_del_id.DataPropertyName = "Codigo"
            Me.col_int_del_id.HeaderText = "InternoDelitoId"
            Me.col_int_del_id.Name = "col_int_del_id"
            Me.col_int_del_id.ReadOnly = True
            Me.col_int_del_id.Visible = False
            Me.col_int_del_id.Width = 10
            '
            'col_exp_id
            '
            Me.col_exp_id.DataPropertyName = "ExpedienteId"
            Me.col_exp_id.HeaderText = "ExpeId"
            Me.col_exp_id.Name = "col_exp_id"
            Me.col_exp_id.ReadOnly = True
            Me.col_exp_id.Visible = False
            Me.col_exp_id.Width = 20
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
            Me.col_del_esp_nom.FillWeight = 69.16167!
            Me.col_del_esp_nom.HeaderText = "Delito Especifico / Delito genérico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            '
            'col_del_art
            '
            Me.col_del_art.DataPropertyName = "DelitoArticulo"
            Me.col_del_art.HeaderText = "Nº Artº"
            Me.col_del_art.Name = "col_del_art"
            Me.col_del_art.Width = 65
            '
            'col_agrav
            '
            Me.col_agrav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_agrav.FillWeight = 69.16167!
            Me.col_agrav.HeaderText = "Agraviado"
            Me.col_agrav.Name = "col_agrav"
            Me.col_agrav.ReadOnly = True
            '
            'col_id_tip_sen
            '
            Me.col_id_tip_sen.DataPropertyName = "TipoResolucionId"
            Me.col_id_tip_sen.HeaderText = "IDTipoSentencia"
            Me.col_id_tip_sen.Name = "col_id_tip_sen"
            Me.col_id_tip_sen.Visible = False
            '
            'col_tip_sent
            '
            Me.col_tip_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_sent.DataPropertyName = "TipoResolucionNom"
            Me.col_tip_sent.FillWeight = 161.6767!
            Me.col_tip_sent.HeaderText = "Tipo de Sentencia"
            Me.col_tip_sent.Name = "col_tip_sent"
            Me.col_tip_sent.ReadOnly = True
            Me.col_tip_sent.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_tip_sent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_tip_sent.Width = 150
            '
            'col_agr_btn
            '
            Me.col_agr_btn.HeaderText = ""
            Me.col_agr_btn.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.col_agr_btn.Name = "col_agr_btn"
            Me.col_agr_btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_agr_btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_agr_btn.Width = 20
            '
            'col_agrav_cod
            '
            Me.col_agrav_cod.HeaderText = "AgraviadoCodigo"
            Me.col_agrav_cod.Name = "col_agrav_cod"
            Me.col_agrav_cod.Visible = False
            Me.col_agrav_cod.Width = 25
            '
            'col_agrav_item
            '
            Me.col_agrav_item.HeaderText = "AgraviadoItem"
            Me.col_agrav_item.Name = "col_agrav_item"
            Me.col_agrav_item.ReadOnly = True
            Me.col_agrav_item.Visible = False
            Me.col_agrav_item.Width = 25
            '
            'col_agr_delito_item
            '
            Me.col_agr_delito_item.HeaderText = "AgraviadoDelitoItem"
            Me.col_agr_delito_item.Name = "col_agr_delito_item"
            Me.col_agr_delito_item.Visible = False
            Me.col_agr_delito_item.Width = 25
            '
            'col_agr_exp_item
            '
            Me.col_agr_exp_item.HeaderText = "AgraviadoExpItem"
            Me.col_agr_exp_item.Name = "col_agr_exp_item"
            Me.col_agr_exp_item.Visible = False
            Me.col_agr_exp_item.Width = 25
            '
            'col_del_obs
            '
            Me.col_del_obs.DataPropertyName = "Observacion"
            Me.col_del_obs.HeaderText = "Observacion"
            Me.col_del_obs.Name = "col_del_obs"
            Me.col_del_obs.ReadOnly = True
            Me.col_del_obs.Visible = False
            Me.col_del_obs.Width = 90
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
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.pnlMantBotAgraviados)
            Me.Panel3.Controls.Add(Me.Panel6)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(799, 26)
            Me.Panel3.TabIndex = 0
            '
            'pnlMantBotAgraviados
            '
            Me.pnlMantBotAgraviados.Controls.Add(Me.btnAddDelito)
            Me.pnlMantBotAgraviados.Controls.Add(Me.btnEditDelito)
            Me.pnlMantBotAgraviados.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlMantBotAgraviados.Location = New System.Drawing.Point(695, 0)
            Me.pnlMantBotAgraviados.Name = "pnlMantBotAgraviados"
            Me.pnlMantBotAgraviados.Size = New System.Drawing.Size(65, 24)
            Me.pnlMantBotAgraviados.TabIndex = 1
            Me.pnlMantBotAgraviados.Visible = False
            '
            'btnAddDelito
            '
            Me.btnAddDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddDelito.Location = New System.Drawing.Point(2, 3)
            Me.btnAddDelito.Name = "btnAddDelito"
            Me.btnAddDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnAddDelito.TabIndex = 0
            Me.btnAddDelito.UseVisualStyleBackColor = True
            '
            'btnEditDelito
            '
            Me.btnEditDelito.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDelito.Location = New System.Drawing.Point(34, 3)
            Me.btnEditDelito.Name = "btnEditDelito"
            Me.btnEditDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnEditDelito.TabIndex = 1
            Me.btnEditDelito.UseVisualStyleBackColor = True
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnDelDelito)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(760, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(37, 24)
            Me.Panel6.TabIndex = 2
            Me.Panel6.Visible = False
            '
            'btnDelDelito
            '
            Me.btnDelDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelDelito.Location = New System.Drawing.Point(3, 3)
            Me.btnDelDelito.Name = "btnDelDelito"
            Me.btnDelDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnDelDelito.TabIndex = 0
            Me.btnDelDelito.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(115, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Delitos/Agraviados"
            '
            'Panel5
            '
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.dgwExpediente)
            Me.Panel5.Controls.Add(Me.pnlTituloExpediente)
            Me.Panel5.Controls.Add(Me.pnlTiempoConde)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel5.Location = New System.Drawing.Point(3, 142)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(801, 90)
            Me.Panel5.TabIndex = 3
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_exp_ref, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_num_exp, Me.col_sit_jur, Me.col_aut_jud, Me.col_sal_jud, Me.col_secre, Me.col_flag, Me.col_eliminar, Me.col_id_tip_imim, Me.col_id_cen_sal_men})
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 26)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(570, 62)
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
            Me.col_exp_ref.Width = 26
            '
            'col_item
            '
            Me.col_item.DataPropertyName = "ExpedienteItem"
            Me.col_item.HeaderText = "ExpeItem"
            Me.col_item.Name = "col_item"
            Me.col_item.Visible = False
            Me.col_item.Width = 25
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
            'col_sit_jur
            '
            Me.col_sit_jur.DataPropertyName = "SituacionJuridicaNombre"
            Me.col_sit_jur.HeaderText = "Sit. Juridica"
            Me.col_sit_jur.Name = "col_sit_jur"
            Me.col_sit_jur.ReadOnly = True
            Me.col_sit_jur.Width = 50
            '
            'col_aut_jud
            '
            Me.col_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_aut_jud.HeaderText = "Distrito Judicial"
            Me.col_aut_jud.Name = "col_aut_jud"
            Me.col_aut_jud.ReadOnly = True
            Me.col_aut_jud.Width = 230
            '
            'col_sal_jud
            '
            Me.col_sal_jud.DataPropertyName = "SalaJudicialNombre"
            Me.col_sal_jud.HeaderText = "Aut. Judicial"
            Me.col_sal_jud.Name = "col_sal_jud"
            Me.col_sal_jud.ReadOnly = True
            Me.col_sal_jud.Width = 230
            '
            'col_secre
            '
            Me.col_secre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_secre.DataPropertyName = "ExpedienteSecretario"
            Me.col_secre.HeaderText = "Secretario"
            Me.col_secre.Name = "col_secre"
            Me.col_secre.ReadOnly = True
            '
            'col_flag
            '
            Me.col_flag.DataPropertyName = "Flagrancia"
            Me.col_flag.HeaderText = "C.F."
            Me.col_flag.Name = "col_flag"
            Me.col_flag.Width = 30
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
            'pnlTituloExpediente
            '
            Me.pnlTituloExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTituloExpediente.Controls.Add(Me.btnEditExpe)
            Me.pnlTituloExpediente.Controls.Add(Me.btnInimputable)
            Me.pnlTituloExpediente.Controls.Add(Me.lblNroExpedientes)
            Me.pnlTituloExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlTituloExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloExpediente.Name = "pnlTituloExpediente"
            Me.pnlTituloExpediente.Size = New System.Drawing.Size(570, 26)
            Me.pnlTituloExpediente.TabIndex = 0
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Location = New System.Drawing.Point(492, 1)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 24)
            Me.btnEditExpe.TabIndex = 1
            Me.btnEditExpe.UseVisualStyleBackColor = True
            Me.btnEditExpe.Visible = False
            '
            'btnInimputable
            '
            Me.btnInimputable.BackgroundImage = Global.APPControls.My.Resources.Resources.centro_salud
            Me.btnInimputable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnInimputable.Location = New System.Drawing.Point(528, 0)
            Me.btnInimputable.Name = "btnInimputable"
            Me.btnInimputable.Size = New System.Drawing.Size(33, 24)
            Me.btnInimputable.TabIndex = 17
            Me.btnInimputable.UseVisualStyleBackColor = True
            Me.btnInimputable.Visible = False
            '
            'lblNroExpedientes
            '
            Me.lblNroExpedientes.AutoSize = True
            Me.lblNroExpedientes.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblNroExpedientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroExpedientes.Location = New System.Drawing.Point(0, 0)
            Me.lblNroExpedientes.Name = "lblNroExpedientes"
            Me.lblNroExpedientes.Size = New System.Drawing.Size(134, 13)
            Me.lblNroExpedientes.TabIndex = 0
            Me.lblNroExpedientes.Text = "Datos del Expedientes"
            '
            'pnlTiempoConde
            '
            Me.pnlTiempoConde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlTiempoConde.Controls.Add(Me.gbComputo)
            Me.pnlTiempoConde.Controls.Add(Me.pnlMantBotPeriCondena)
            Me.pnlTiempoConde.Controls.Add(Me.gbDuracioncondena)
            Me.pnlTiempoConde.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlTiempoConde.Location = New System.Drawing.Point(570, 0)
            Me.pnlTiempoConde.Name = "pnlTiempoConde"
            Me.pnlTiempoConde.Size = New System.Drawing.Size(229, 88)
            Me.pnlTiempoConde.TabIndex = 2
            Me.pnlTiempoConde.Visible = False
            '
            'gbComputo
            '
            Me.gbComputo.Controls.Add(Me.dgvPeriodoCondena)
            Me.gbComputo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbComputo.Location = New System.Drawing.Point(0, 60)
            Me.gbComputo.Name = "gbComputo"
            Me.gbComputo.Size = New System.Drawing.Size(191, 24)
            Me.gbComputo.TabIndex = 8
            Me.gbComputo.TabStop = False
            Me.gbComputo.Text = "Cómputo"
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
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(3, 16)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgvPeriodoCondena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(185, 5)
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
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_ini.HeaderText = "F. Inicio"
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            '
            'col_fin
            '
            Me.col_fin.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle4.Format = "d"
            DataGridViewCellStyle4.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_fin.HeaderText = "F. vcto."
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
            Me.col_doc_jud_id.Width = 30
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
            'pnlMantBotPeriCondena
            '
            Me.pnlMantBotPeriCondena.Controls.Add(Me.pnlAgravMant)
            Me.pnlMantBotPeriCondena.Controls.Add(Me.pnlEliminarAgraviado)
            Me.pnlMantBotPeriCondena.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlMantBotPeriCondena.Location = New System.Drawing.Point(191, 60)
            Me.pnlMantBotPeriCondena.Name = "pnlMantBotPeriCondena"
            Me.pnlMantBotPeriCondena.Size = New System.Drawing.Size(34, 24)
            Me.pnlMantBotPeriCondena.TabIndex = 7
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnEditPerCond)
            Me.pnlAgravMant.Controls.Add(Me.btnAddPerCond)
            Me.pnlAgravMant.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAgravMant.Location = New System.Drawing.Point(0, 0)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(34, 0)
            Me.pnlAgravMant.TabIndex = 3
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Location = New System.Drawing.Point(2, 25)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnEditPerCond.TabIndex = 1
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Location = New System.Drawing.Point(2, 0)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            '
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelPerCond)
            Me.pnlEliminarAgraviado.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(0, -2)
            Me.pnlEliminarAgraviado.Name = "pnlEliminarAgraviado"
            Me.pnlEliminarAgraviado.Size = New System.Drawing.Size(34, 26)
            Me.pnlEliminarAgraviado.TabIndex = 2
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Location = New System.Drawing.Point(2, 0)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(31, 26)
            Me.btnDelPerCond.TabIndex = 3
            Me.btnDelPerCond.UseVisualStyleBackColor = True
            '
            'gbDuracioncondena
            '
            Me.gbDuracioncondena.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbDuracioncondena.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gbDuracioncondena.Location = New System.Drawing.Point(0, 0)
            Me.gbDuracioncondena.Name = "gbDuracioncondena"
            Me.gbDuracioncondena.Size = New System.Drawing.Size(225, 60)
            Me.gbDuracioncondena.TabIndex = 6
            Me.gbDuracioncondena.TabStop = False
            Me.gbDuracioncondena.Text = "Duración de la condena"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.txtAutoridadJudicial)
            Me.pnlCabecera.Controls.Add(Me.txtDistritoJudicial)
            Me.pnlCabecera.Controls.Add(Me.pnlAnularExpediente)
            Me.pnlCabecera.Controls.Add(Me.Panel1)
            Me.pnlCabecera.Controls.Add(Me.pnlExpeMant)
            Me.pnlCabecera.Controls.Add(Me.Label30)
            Me.pnlCabecera.Controls.Add(Me.txtNumOficio)
            Me.pnlCabecera.Controls.Add(Me.Label13)
            Me.pnlCabecera.Controls.Add(Me.dtpFechRecepDoc)
            Me.pnlCabecera.Controls.Add(Me.lblSala)
            Me.pnlCabecera.Controls.Add(Me.lblDistrito)
            Me.pnlCabecera.Controls.Add(Me.dtpFechSenDoc)
            Me.pnlCabecera.Controls.Add(Me.Label12)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(3, 16)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(801, 126)
            Me.pnlCabecera.TabIndex = 2
            '
            'txtAutoridadJudicial
            '
            Me.txtAutoridadJudicial._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAutoridadJudicial._BloquearPaste = False
            Me.txtAutoridadJudicial._SeleccionarTodo = False
            Me.txtAutoridadJudicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtAutoridadJudicial.Enabled = False
            Me.txtAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAutoridadJudicial.Location = New System.Drawing.Point(514, 31)
            Me.txtAutoridadJudicial.MaxLength = 120
            Me.txtAutoridadJudicial.Name = "txtAutoridadJudicial"
            Me.txtAutoridadJudicial.ReadOnly = True
            Me.txtAutoridadJudicial.Size = New System.Drawing.Size(287, 20)
            Me.txtAutoridadJudicial.TabIndex = 11
            Me.txtAutoridadJudicial.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtAutoridadJudicial.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDistritoJudicial
            '
            Me.txtDistritoJudicial._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDistritoJudicial._BloquearPaste = False
            Me.txtDistritoJudicial._SeleccionarTodo = False
            Me.txtDistritoJudicial.Enabled = False
            Me.txtDistritoJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDistritoJudicial.Location = New System.Drawing.Point(153, 31)
            Me.txtDistritoJudicial.MaxLength = 120
            Me.txtDistritoJudicial.Name = "txtDistritoJudicial"
            Me.txtDistritoJudicial.ReadOnly = True
            Me.txtDistritoJudicial.Size = New System.Drawing.Size(261, 20)
            Me.txtDistritoJudicial.TabIndex = 9
            Me.txtDistritoJudicial.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDistritoJudicial.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlAnularExpediente
            '
            Me.pnlAnularExpediente.Controls.Add(Me.btnEliminarExp)
            Me.pnlAnularExpediente.Location = New System.Drawing.Point(35, 6)
            Me.pnlAnularExpediente.Name = "pnlAnularExpediente"
            Me.pnlAnularExpediente.Size = New System.Drawing.Size(34, 24)
            Me.pnlAnularExpediente.TabIndex = 2
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Location = New System.Drawing.Point(1, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(30, 24)
            Me.btnEliminarExp.TabIndex = 0
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.grbAutoridad)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.pnlObsInimputable)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 62)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(801, 64)
            Me.Panel1.TabIndex = 12
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.Label10)
            Me.grbAutoridad.Controls.Add(Me.dtpFechaFinal)
            Me.grbAutoridad.Controls.Add(Me.Label6)
            Me.grbAutoridad.Controls.Add(Me.dtpFechaInicio)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(410, 0)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(121, 64)
            Me.grbAutoridad.TabIndex = 2
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Cómputo"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(12, 48)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(43, 13)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "F. vcto:"
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Enabled = False
            Me.dtpFechaFinal.Location = New System.Drawing.Point(62, 42)
            Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinal.TabIndex = 3
            Me.dtpFechaFinal.Value = "/  /"
            Me.dtpFechaFinal.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(9, 21)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(47, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "F. Inicio:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaInicio.Location = New System.Drawing.Point(62, 15)
            Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 1
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbtCadenaperpetua)
            Me.GroupBox1.Controls.Add(Me.rbtTemporal)
            Me.GroupBox1.Controls.Add(Me.txtDias)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtAnios)
            Me.GroupBox1.Controls.Add(Me.txtMeses)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(147, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(263, 64)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Duración de la condena"
            '
            'rbtCadenaperpetua
            '
            Me.rbtCadenaperpetua.AutoSize = True
            Me.rbtCadenaperpetua.Enabled = False
            Me.rbtCadenaperpetua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtCadenaperpetua.Location = New System.Drawing.Point(10, 42)
            Me.rbtCadenaperpetua.Name = "rbtCadenaperpetua"
            Me.rbtCadenaperpetua.Size = New System.Drawing.Size(107, 17)
            Me.rbtCadenaperpetua.TabIndex = 1
            Me.rbtCadenaperpetua.Text = "Cadena perpetua"
            Me.rbtCadenaperpetua.UseVisualStyleBackColor = True
            '
            'rbtTemporal
            '
            Me.rbtTemporal.AutoSize = True
            Me.rbtTemporal.Enabled = False
            Me.rbtTemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtTemporal.Location = New System.Drawing.Point(10, 19)
            Me.rbtTemporal.Name = "rbtTemporal"
            Me.rbtTemporal.Size = New System.Drawing.Size(69, 17)
            Me.rbtTemporal.TabIndex = 0
            Me.rbtTemporal.Text = "Temporal"
            Me.rbtTemporal.UseVisualStyleBackColor = True
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Enabled = False
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(208, 39)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(25, 20)
            Me.txtDias.TabIndex = 7
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(132, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Años"
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Enabled = False
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.Location = New System.Drawing.Point(136, 39)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(25, 20)
            Me.txtAnios.TabIndex = 3
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Enabled = False
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(173, 39)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(25, 20)
            Me.txtMeses.TabIndex = 5
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(166, 22)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(38, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Meses"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(205, 22)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(28, 13)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Dias"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label9)
            Me.Panel2.Controls.Add(Me.rdbNo)
            Me.Panel2.Controls.Add(Me.rdbSi)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Enabled = False
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(147, 64)
            Me.Panel2.TabIndex = 0
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(5, 5)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(137, 26)
            Me.Label9.TabIndex = 0
            Me.Label9.Text = "Inimputable con medida de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seguridad de Internación:"
            '
            'rdbNo
            '
            Me.rdbNo.AutoSize = True
            Me.rdbNo.Checked = True
            Me.rdbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNo.Location = New System.Drawing.Point(69, 38)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(41, 17)
            Me.rdbNo.TabIndex = 2
            Me.rdbNo.TabStop = True
            Me.rdbNo.Text = "NO"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'rdbSi
            '
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSi.Location = New System.Drawing.Point(22, 39)
            Me.rdbSi.Name = "rdbSi"
            Me.rdbSi.Size = New System.Drawing.Size(35, 17)
            Me.rdbSi.TabIndex = 1
            Me.rdbSi.Text = "SI"
            Me.rdbSi.UseVisualStyleBackColor = True
            '
            'pnlObsInimputable
            '
            Me.pnlObsInimputable.Controls.Add(Me.txtEstablecimientomental)
            Me.pnlObsInimputable.Controls.Add(Me.Label11)
            Me.pnlObsInimputable.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlObsInimputable.Location = New System.Drawing.Point(531, 0)
            Me.pnlObsInimputable.Name = "pnlObsInimputable"
            Me.pnlObsInimputable.Size = New System.Drawing.Size(270, 64)
            Me.pnlObsInimputable.TabIndex = 3
            '
            'txtEstablecimientomental
            '
            Me.txtEstablecimientomental._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstablecimientomental._BloquearPaste = False
            Me.txtEstablecimientomental._SeleccionarTodo = False
            Me.txtEstablecimientomental.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtEstablecimientomental.Enabled = False
            Me.txtEstablecimientomental.Location = New System.Drawing.Point(0, 26)
            Me.txtEstablecimientomental.MaxLength = 120
            Me.txtEstablecimientomental.Multiline = True
            Me.txtEstablecimientomental.Name = "txtEstablecimientomental"
            Me.txtEstablecimientomental.Size = New System.Drawing.Size(270, 38)
            Me.txtEstablecimientomental.TabIndex = 1
            Me.txtEstablecimientomental.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstablecimientomental.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.txtEstablecimientomental.Visible = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(0, 0)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(274, 26)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Establecimineto de salud mental donde deberá cumplir la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "medida de seguridad:"
            Me.Label11.Visible = False
            '
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.btnAddExp)
            Me.pnlExpeMant.Location = New System.Drawing.Point(1, 6)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(34, 24)
            Me.pnlExpeMant.TabIndex = 1
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.view
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Location = New System.Drawing.Point(2, 1)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 24)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(72, 10)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(78, 13)
            Me.Label30.TabIndex = 2
            Me.Label30.Text = "N° documento:"
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Enabled = False
            Me.txtNumOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumOficio.Location = New System.Drawing.Point(153, 6)
            Me.txtNumOficio.MaxLength = 120
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.ReadOnly = True
            Me.txtNumOficio.Size = New System.Drawing.Size(261, 20)
            Me.txtNumOficio.TabIndex = 3
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(420, 10)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(93, 13)
            Me.Label13.TabIndex = 4
            Me.Label13.Text = "Fecha recepción :"
            '
            'dtpFechRecepDoc
            '
            Me.dtpFechRecepDoc.Enabled = False
            Me.dtpFechRecepDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechRecepDoc.Location = New System.Drawing.Point(515, 6)
            Me.dtpFechRecepDoc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.dtpFechRecepDoc.Name = "dtpFechRecepDoc"
            Me.dtpFechRecepDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechRecepDoc.TabIndex = 7
            Me.dtpFechRecepDoc.Value = "/  /"
            Me.dtpFechRecepDoc.ValueLong = CType(0, Long)
            '
            'lblSala
            '
            Me.lblSala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSala.AutoSize = True
            Me.lblSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSala.Location = New System.Drawing.Point(420, 37)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(93, 13)
            Me.lblSala.TabIndex = 10
            Me.lblSala.Text = "Autoridad Judicial:"
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDistrito.Location = New System.Drawing.Point(72, 37)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(80, 13)
            Me.lblDistrito.TabIndex = 8
            Me.lblDistrito.Text = "Distrito Judicial:"
            '
            'dtpFechSenDoc
            '
            Me.dtpFechSenDoc.Enabled = False
            Me.dtpFechSenDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechSenDoc.Location = New System.Drawing.Point(691, 6)
            Me.dtpFechSenDoc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.dtpFechSenDoc.Name = "dtpFechSenDoc"
            Me.dtpFechSenDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechSenDoc.TabIndex = 5
            Me.dtpFechSenDoc.Value = "/  /"
            Me.dtpFechSenDoc.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(601, 10)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(92, 13)
            Me.Label12.TabIndex = 6
            Me.Label12.Text = "Fecha sentencia :"
            '
            'uscDetallRegistroSentenciaGrilla
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.grbCabecera)
            Me.Name = "uscDetallRegistroSentenciaGrilla"
            Me.Size = New System.Drawing.Size(807, 365)
            Me.grbCabecera.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlMantBotAgraviados.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTituloExpediente.ResumeLayout(False)
            Me.pnlTituloExpediente.PerformLayout()
            Me.pnlTiempoConde.ResumeLayout(False)
            Me.gbComputo.ResumeLayout(False)
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlMantBotPeriCondena.ResumeLayout(False)
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.pnlAnularExpediente.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbAutoridad.ResumeLayout(False)
            Me.grbAutoridad.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlObsInimputable.ResumeLayout(False)
            Me.pnlObsInimputable.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
        Friend WithEvents grbCabecera As GroupBox
        Friend WithEvents Panel7 As Panel
        Friend WithEvents dgwDelito As DataGridView
        Friend WithEvents Panel3 As Panel
        Friend WithEvents pnlMantBotAgraviados As Panel
        Friend WithEvents btnAddDelito As Button
        Friend WithEvents btnEditDelito As Button
        Friend WithEvents Panel6 As Panel
        Friend WithEvents btnDelDelito As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlTituloExpediente As Panel
        Friend WithEvents btnEditExpe As Button
        Friend WithEvents btnInimputable As Button
        Friend WithEvents lblNroExpedientes As Label
        Friend WithEvents pnlTiempoConde As Panel
        Friend WithEvents gbComputo As GroupBox
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_ped_cond_item As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_ini As DataGridViewTextBoxColumn
        Friend WithEvents col_fin As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As DataGridViewTextBoxColumn
        Friend WithEvents pnlMantBotPeriCondena As Panel
        Friend WithEvents pnlAgravMant As Panel
        Friend WithEvents btnEditPerCond As Button
        Friend WithEvents btnAddPerCond As Button
        Friend WithEvents pnlEliminarAgraviado As Panel
        Friend WithEvents btnDelPerCond As Button
        Friend WithEvents gbDuracioncondena As GroupBox
        Friend WithEvents pnlCabecera As Panel
        Friend WithEvents pnlAnularExpediente As Panel
        Friend WithEvents btnEliminarExp As Button
        Friend WithEvents Panel1 As Panel
        Friend WithEvents grbAutoridad As GroupBox
        Friend WithEvents Label10 As Label
        Friend WithEvents dtpFechaFinal As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents rbtCadenaperpetua As RadioButton
        Friend WithEvents rbtTemporal As RadioButton
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Label9 As Label
        Friend WithEvents rdbNo As RadioButton
        Friend WithEvents rdbSi As RadioButton
        Friend WithEvents pnlObsInimputable As Panel
        Friend WithEvents txtEstablecimientomental As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents pnlExpeMant As Panel
        Friend WithEvents btnAddExp As Button
        Friend WithEvents Label30 As Label
        Friend WithEvents txtNumOficio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label13 As Label
        Friend WithEvents dtpFechRecepDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblSala As Label
        Friend WithEvents lblDistrito As Label
        Friend WithEvents dtpFechSenDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As Label
        Friend WithEvents txtAutoridadJudicial As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDistritoJudicial As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents col_sel As DataGridViewCheckBoxColumn
        Friend WithEvents col_exp_ref As DataGridViewImageColumn
        Friend WithEvents col_item As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_num_exp As DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_secre As DataGridViewTextBoxColumn
        Friend WithEvents col_flag As DataGridViewCheckBoxColumn
        Friend WithEvents col_eliminar As DataGridViewImageColumn
        Friend WithEvents col_id_tip_imim As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cen_sal_men As DataGridViewTextBoxColumn
        Friend WithEvents col_nro As DataGridViewTextBoxColumn
        Friend WithEvents col_int_del_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_del_art As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav As DataGridViewTextBoxColumn
        Friend WithEvents col_id_tip_sen As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_btn As DataGridViewImageColumn
        Friend WithEvents col_agrav_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_delito_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_del_gen As DataGridViewTextBoxColumn
    End Class
End Namespace