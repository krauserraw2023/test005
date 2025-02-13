Namespace Registro.Sentencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDetallRegistroAnulacion
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlTituloExpediente = New System.Windows.Forms.Panel()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.chkLista = New System.Windows.Forms.CheckBox()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.pnlAnularExpediente = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_nro_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_exp_ref_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.dgvListarDocumentos = New Legolas.APPUIComponents.myDatagridView()
            Me.col_doc_tip_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_sub_tip_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.btnAgregarDocumentos = New System.Windows.Forms.Button()
            Me.btnEditDocumentos = New System.Windows.Forms.Button()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.btnElimarOtros = New System.Windows.Forms.Button()
            Me.lblDocumentos = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pnlInferior = New System.Windows.Forms.Panel()
            Me.pnlListaDocumentos = New System.Windows.Forms.Panel()
            Me.pnlDelitosAgraviados = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.tvExpe = New System.Windows.Forms.TreeView()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnAddDelito = New System.Windows.Forms.Button()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnDelDelito = New System.Windows.Forms.Button()
            Me.lblDelitosAgraviados = New System.Windows.Forms.Label()
            Me.pnlExpedienteDelitoSuperior = New System.Windows.Forms.Panel()
            Me.col_est_anu = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.col_agrav_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_delito_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlTituloExpediente.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.Panel10.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.pnlAnularExpediente.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvListarDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlInferior.SuspendLayout()
            Me.pnlListaDocumentos.SuspendLayout()
            Me.pnlDelitosAgraviados.SuspendLayout()
            Me.Panel5.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.pnlExpedienteDelitoSuperior.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlTituloExpediente
            '
            Me.pnlTituloExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTituloExpediente.Controls.Add(Me.lblNroExpedientes)
            Me.pnlTituloExpediente.Controls.Add(Me.pnlExpeMant)
            Me.pnlTituloExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloExpediente.Name = "pnlTituloExpediente"
            Me.pnlTituloExpediente.Size = New System.Drawing.Size(370, 28)
            Me.pnlTituloExpediente.TabIndex = 0
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
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.Panel10)
            Me.pnlExpeMant.Controls.Add(Me.Panel9)
            Me.pnlExpeMant.Controls.Add(Me.pnlAnularExpediente)
            Me.pnlExpeMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeMant.Location = New System.Drawing.Point(164, 0)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(204, 26)
            Me.pnlExpeMant.TabIndex = 0
            '
            'Panel10
            '
            Me.Panel10.Controls.Add(Me.chkLista)
            Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel10.Location = New System.Drawing.Point(0, 0)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(61, 26)
            Me.Panel10.TabIndex = 89
            '
            'chkLista
            '
            Me.chkLista.AutoSize = True
            Me.chkLista.Location = New System.Drawing.Point(2, 4)
            Me.chkLista.Name = "chkLista"
            Me.chkLista.Size = New System.Drawing.Size(59, 17)
            Me.chkLista.TabIndex = 90
            Me.chkLista.Text = "Detalle"
            Me.chkLista.UseVisualStyleBackColor = True
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnAddExp)
            Me.Panel9.Controls.Add(Me.btnEditExpe)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel9.Location = New System.Drawing.Point(111, 0)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(63, 26)
            Me.Panel9.TabIndex = 87
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Location = New System.Drawing.Point(2, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 26)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Location = New System.Drawing.Point(31, 0)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 26)
            Me.btnEditExpe.TabIndex = 1
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'pnlAnularExpediente
            '
            Me.pnlAnularExpediente.Controls.Add(Me.btnEliminarExp)
            Me.pnlAnularExpediente.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAnularExpediente.Location = New System.Drawing.Point(174, 0)
            Me.pnlAnularExpediente.Name = "pnlAnularExpediente"
            Me.pnlAnularExpediente.Size = New System.Drawing.Size(30, 26)
            Me.pnlAnularExpediente.TabIndex = 88
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Location = New System.Drawing.Point(1, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarExp.TabIndex = 0
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_nro_ing, Me.col_exp_ref, Me.col_exp_ref_id, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_num_exp, Me.col_sit_jur, Me.col_aut_jud, Me.col_sal_jud, Me.col_secre, Me.col_flag, Me.col_eliminar})
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
            Me.dgwExpediente.Size = New System.Drawing.Size(370, 168)
            Me.dgwExpediente.TabIndex = 1
            Me.dgwExpediente.VisibleCampos = True
            '
            'col_sel
            '
            Me.col_sel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_sel.HeaderText = "Elegir"
            Me.col_sel.Name = "col_sel"
            Me.col_sel.Visible = False
            Me.col_sel.Width = 150
            '
            'col_nro_ing
            '
            Me.col_nro_ing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_nro_ing.DataPropertyName = "IngresoNro"
            Me.col_nro_ing.HeaderText = "Nº Ing."
            Me.col_nro_ing.Name = "col_nro_ing"
            Me.col_nro_ing.Width = 25
            '
            'col_exp_ref
            '
            Me.col_exp_ref.DataPropertyName = "ExpedienteRefIcon"
            Me.col_exp_ref.HeaderText = "Ref."
            Me.col_exp_ref.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_exp_ref.Name = "col_exp_ref"
            Me.col_exp_ref.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_exp_ref.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_exp_ref.Visible = False
            Me.col_exp_ref.Width = 26
            '
            'col_exp_ref_id
            '
            Me.col_exp_ref_id.DataPropertyName = "ExpedienteReferidoID"
            Me.col_exp_ref_id.HeaderText = "RefExpID"
            Me.col_exp_ref_id.Name = "col_exp_ref_id"
            Me.col_exp_ref_id.Visible = False
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
            Me.col_num_exp.DataPropertyName = "ExpedienteNumero"
            Me.col_num_exp.HeaderText = "N° Exp."
            Me.col_num_exp.Name = "col_num_exp"
            Me.col_num_exp.ReadOnly = True
            Me.col_num_exp.Width = 70
            '
            'col_sit_jur
            '
            Me.col_sit_jur.DataPropertyName = "SituacionJuridicaNombre"
            Me.col_sit_jur.HeaderText = "Sit. Juridica"
            Me.col_sit_jur.Name = "col_sit_jur"
            Me.col_sit_jur.ReadOnly = True
            Me.col_sit_jur.Visible = False
            Me.col_sit_jur.Width = 50
            '
            'col_aut_jud
            '
            Me.col_aut_jud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_aut_jud.DataPropertyName = "AutoridadJudicialNombre"
            Me.col_aut_jud.HeaderText = "Distrito Judicial"
            Me.col_aut_jud.Name = "col_aut_jud"
            Me.col_aut_jud.ReadOnly = True
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
            Me.col_secre.DataPropertyName = "ExpedienteSecretario"
            Me.col_secre.HeaderText = "Secretario"
            Me.col_secre.Name = "col_secre"
            Me.col_secre.ReadOnly = True
            Me.col_secre.Visible = False
            '
            'col_flag
            '
            Me.col_flag.DataPropertyName = "Flagrancia"
            Me.col_flag.HeaderText = "C.F."
            Me.col_flag.Name = "col_flag"
            Me.col_flag.Visible = False
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
            'dgvListarDocumentos
            '
            Me.dgvListarDocumentos.AllowUserToAddRows = False
            Me.dgvListarDocumentos.AllowUserToDeleteRows = False
            Me.dgvListarDocumentos.AllowUserToResizeRows = False
            Me.dgvListarDocumentos.BackgroundColor = System.Drawing.Color.White
            Me.dgvListarDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvListarDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvListarDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_doc_tip_id, Me.col_tipo, Me.col_doc_sub_tip_id, Me.col_ing_id, Me.col_cod, Me.col_ini, Me.col_fin, Me.col_doc_jud_id, Me.col_eliminado, Me.col_folio})
            Me.dgvListarDocumentos.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.dgvListarDocumentos.GridColor = System.Drawing.Color.LightGray
            Me.dgvListarDocumentos.Location = New System.Drawing.Point(0, 28)
            Me.dgvListarDocumentos.MultiSelect = False
            Me.dgvListarDocumentos.Name = "dgvListarDocumentos"
            Me.dgvListarDocumentos.ReadOnly = True
            Me.dgvListarDocumentos.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvListarDocumentos.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvListarDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvListarDocumentos.Size = New System.Drawing.Size(370, 70)
            Me.dgvListarDocumentos.TabIndex = 7
            Me.dgvListarDocumentos.VisibleCampos = True
            '
            'col_doc_tip_id
            '
            Me.col_doc_tip_id.DataPropertyName = "DocumentoTipo"
            Me.col_doc_tip_id.HeaderText = "TipoID"
            Me.col_doc_tip_id.Name = "col_doc_tip_id"
            Me.col_doc_tip_id.ReadOnly = True
            Me.col_doc_tip_id.Visible = False
            '
            'col_tipo
            '
            Me.col_tipo.DataPropertyName = "DocumentoTipoNombre"
            Me.col_tipo.DividerWidth = 1
            Me.col_tipo.HeaderText = "Tipo"
            Me.col_tipo.Name = "col_tipo"
            Me.col_tipo.ReadOnly = True
            Me.col_tipo.Width = 130
            '
            'col_doc_sub_tip_id
            '
            Me.col_doc_sub_tip_id.DataPropertyName = "DocumentoSubTipoId"
            Me.col_doc_sub_tip_id.HeaderText = "SubtipoID"
            Me.col_doc_sub_tip_id.Name = "col_doc_sub_tip_id"
            Me.col_doc_sub_tip_id.ReadOnly = True
            Me.col_doc_sub_tip_id.Visible = False
            '
            'col_ing_id
            '
            Me.col_ing_id.HeaderText = "IngresoID"
            Me.col_ing_id.Name = "col_ing_id"
            Me.col_ing_id.ReadOnly = True
            Me.col_ing_id.Visible = False
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "IngresoNro"
            Me.col_cod.HeaderText = "Ingreso"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Width = 45
            '
            'col_ini
            '
            Me.col_ini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_ini.DataPropertyName = "strFechaDocumentoJudicialRecepcion"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_ini.HeaderText = "F. Recep."
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            Me.col_ini.Visible = False
            Me.col_ini.Width = 90
            '
            'col_fin
            '
            Me.col_fin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_fin.DataPropertyName = "DocumentoNumero"
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_fin.HeaderText = "Documento"
            Me.col_fin.Name = "col_fin"
            Me.col_fin.ReadOnly = True
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "Codigo"
            Me.col_doc_jud_id.DividerWidth = 1
            Me.col_doc_jud_id.HeaderText = "DocJudId"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.ReadOnly = True
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 30
            '
            'col_eliminado
            '
            Me.col_eliminado.DataPropertyName = "NumLibro"
            Me.col_eliminado.DividerWidth = 1
            Me.col_eliminado.HeaderText = "Libro"
            Me.col_eliminado.Name = "col_eliminado"
            Me.col_eliminado.ReadOnly = True
            Me.col_eliminado.ToolTipText = "Libro"
            Me.col_eliminado.Width = 50
            '
            'col_folio
            '
            Me.col_folio.DataPropertyName = "NumFolio"
            Me.col_folio.HeaderText = "Folio"
            Me.col_folio.Name = "col_folio"
            Me.col_folio.ReadOnly = True
            Me.col_folio.Width = 50
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Panel7)
            Me.Panel2.Controls.Add(Me.Panel8)
            Me.Panel2.Controls.Add(Me.lblDocumentos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(370, 28)
            Me.Panel2.TabIndex = 97
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.btnAgregarDocumentos)
            Me.Panel7.Controls.Add(Me.btnEditDocumentos)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel7.Location = New System.Drawing.Point(272, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(65, 26)
            Me.Panel7.TabIndex = 93
            '
            'btnAgregarDocumentos
            '
            Me.btnAgregarDocumentos.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregarDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregarDocumentos.Location = New System.Drawing.Point(4, -1)
            Me.btnAgregarDocumentos.Name = "btnAgregarDocumentos"
            Me.btnAgregarDocumentos.Size = New System.Drawing.Size(30, 26)
            Me.btnAgregarDocumentos.TabIndex = 0
            Me.btnAgregarDocumentos.UseVisualStyleBackColor = True
            '
            'btnEditDocumentos
            '
            Me.btnEditDocumentos.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDocumentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDocumentos.Location = New System.Drawing.Point(34, -1)
            Me.btnEditDocumentos.Name = "btnEditDocumentos"
            Me.btnEditDocumentos.Size = New System.Drawing.Size(30, 26)
            Me.btnEditDocumentos.TabIndex = 1
            Me.btnEditDocumentos.UseVisualStyleBackColor = True
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.btnElimarOtros)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel8.Location = New System.Drawing.Point(337, 0)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(31, 26)
            Me.Panel8.TabIndex = 94
            '
            'btnElimarOtros
            '
            Me.btnElimarOtros.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnElimarOtros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnElimarOtros.Location = New System.Drawing.Point(0, -1)
            Me.btnElimarOtros.Name = "btnElimarOtros"
            Me.btnElimarOtros.Size = New System.Drawing.Size(30, 26)
            Me.btnElimarOtros.TabIndex = 89
            Me.btnElimarOtros.UseVisualStyleBackColor = True
            '
            'lblDocumentos
            '
            Me.lblDocumentos.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDocumentos.Location = New System.Drawing.Point(0, 0)
            Me.lblDocumentos.Name = "lblDocumentos"
            Me.lblDocumentos.Size = New System.Drawing.Size(272, 26)
            Me.lblDocumentos.TabIndex = 0
            Me.lblDocumentos.Text = "Otros documentos a anular"
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.dgwExpediente)
            Me.Panel1.Controls.Add(Me.pnlTituloExpediente)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(372, 198)
            Me.Panel1.TabIndex = 2
            '
            'pnlInferior
            '
            Me.pnlInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInferior.Controls.Add(Me.pnlListaDocumentos)
            Me.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlInferior.Location = New System.Drawing.Point(0, 198)
            Me.pnlInferior.Name = "pnlInferior"
            Me.pnlInferior.Size = New System.Drawing.Size(372, 100)
            Me.pnlInferior.TabIndex = 6
            '
            'pnlListaDocumentos
            '
            Me.pnlListaDocumentos.Controls.Add(Me.Panel2)
            Me.pnlListaDocumentos.Controls.Add(Me.dgvListarDocumentos)
            Me.pnlListaDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlListaDocumentos.Location = New System.Drawing.Point(0, 0)
            Me.pnlListaDocumentos.Name = "pnlListaDocumentos"
            Me.pnlListaDocumentos.Size = New System.Drawing.Size(370, 98)
            Me.pnlListaDocumentos.TabIndex = 5
            '
            'pnlDelitosAgraviados
            '
            Me.pnlDelitosAgraviados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDelitosAgraviados.Controls.Add(Me.Panel5)
            Me.pnlDelitosAgraviados.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlDelitosAgraviados.Location = New System.Drawing.Point(372, 0)
            Me.pnlDelitosAgraviados.Name = "pnlDelitosAgraviados"
            Me.pnlDelitosAgraviados.Size = New System.Drawing.Size(435, 298)
            Me.pnlDelitosAgraviados.TabIndex = 4
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.tvExpe)
            Me.Panel5.Controls.Add(Me.dgwDelito)
            Me.Panel5.Controls.Add(Me.Panel3)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(433, 296)
            Me.Panel5.TabIndex = 3
            '
            'tvExpe
            '
            Me.tvExpe.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.tvExpe.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tvExpe.FullRowSelect = True
            Me.tvExpe.LineColor = System.Drawing.Color.Navy
            Me.tvExpe.Location = New System.Drawing.Point(0, 28)
            Me.tvExpe.Name = "tvExpe"
            Me.tvExpe.Size = New System.Drawing.Size(433, 268)
            Me.tvExpe.TabIndex = 2
            Me.tvExpe.Visible = False
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_est_anu, Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_agrav, Me.col_del_esp_nom, Me.col_tip_sent, Me.col_agrav_cod, Me.col_agrav_item, Me.col_agr_delito_item, Me.col_agr_exp_item, Me.col_del_obs, Me.col_nom_del_gen})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle6
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 28)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(433, 268)
            Me.dgwDelito.TabIndex = 1
            '
            'Panel3
            '
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Controls.Add(Me.Panel6)
            Me.Panel3.Controls.Add(Me.lblDelitosAgraviados)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(433, 28)
            Me.Panel3.TabIndex = 0
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnAddDelito)
            Me.Panel4.Controls.Add(Me.btnEditDelito)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(335, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(65, 26)
            Me.Panel4.TabIndex = 84
            '
            'btnAddDelito
            '
            Me.btnAddDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddDelito.Location = New System.Drawing.Point(4, -1)
            Me.btnAddDelito.Name = "btnAddDelito"
            Me.btnAddDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnAddDelito.TabIndex = 0
            Me.btnAddDelito.UseVisualStyleBackColor = True
            Me.btnAddDelito.Visible = False
            '
            'btnEditDelito
            '
            Me.btnEditDelito.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDelito.Location = New System.Drawing.Point(34, -1)
            Me.btnEditDelito.Name = "btnEditDelito"
            Me.btnEditDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnEditDelito.TabIndex = 1
            Me.btnEditDelito.UseVisualStyleBackColor = True
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnDelDelito)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(400, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(31, 26)
            Me.Panel6.TabIndex = 92
            Me.Panel6.Visible = False
            '
            'btnDelDelito
            '
            Me.btnDelDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelDelito.Location = New System.Drawing.Point(0, -1)
            Me.btnDelDelito.Name = "btnDelDelito"
            Me.btnDelDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnDelDelito.TabIndex = 89
            Me.btnDelDelito.UseVisualStyleBackColor = True
            Me.btnDelDelito.Visible = False
            '
            'lblDelitosAgraviados
            '
            Me.lblDelitosAgraviados.AutoSize = True
            Me.lblDelitosAgraviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDelitosAgraviados.Location = New System.Drawing.Point(6, 8)
            Me.lblDelitosAgraviados.Name = "lblDelitosAgraviados"
            Me.lblDelitosAgraviados.Size = New System.Drawing.Size(115, 13)
            Me.lblDelitosAgraviados.TabIndex = 0
            Me.lblDelitosAgraviados.Text = "Delitos/Agraviados"
            '
            'pnlExpedienteDelitoSuperior
            '
            Me.pnlExpedienteDelitoSuperior.Controls.Add(Me.Panel1)
            Me.pnlExpedienteDelitoSuperior.Controls.Add(Me.pnlInferior)
            Me.pnlExpedienteDelitoSuperior.Controls.Add(Me.pnlDelitosAgraviados)
            Me.pnlExpedienteDelitoSuperior.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlExpedienteDelitoSuperior.Location = New System.Drawing.Point(0, 0)
            Me.pnlExpedienteDelitoSuperior.Name = "pnlExpedienteDelitoSuperior"
            Me.pnlExpedienteDelitoSuperior.Size = New System.Drawing.Size(807, 298)
            Me.pnlExpedienteDelitoSuperior.TabIndex = 7
            '
            'col_est_anu
            '
            Me.col_est_anu.FillWeight = 150.0!
            Me.col_est_anu.Frozen = True
            Me.col_est_anu.HeaderText = "Elegir"
            Me.col_est_anu.Name = "col_est_anu"
            Me.col_est_anu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_est_anu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_est_anu.Width = 35
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
            'col_agrav
            '
            Me.col_agrav.FillWeight = 69.16167!
            Me.col_agrav.HeaderText = "Agraviado"
            Me.col_agrav.Name = "col_agrav"
            Me.col_agrav.ReadOnly = True
            Me.col_agrav.Width = 140
            '
            'col_del_esp_nom
            '
            Me.col_del_esp_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_del_esp_nom.DataPropertyName = "DelitoEspecificoNombre"
            Me.col_del_esp_nom.FillWeight = 69.16167!
            Me.col_del_esp_nom.HeaderText = "Delito Especifico"
            Me.col_del_esp_nom.Name = "col_del_esp_nom"
            Me.col_del_esp_nom.ReadOnly = True
            '
            'col_tip_sent
            '
            Me.col_tip_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_sent.FillWeight = 161.6767!
            Me.col_tip_sent.HeaderText = "Tipo de Sentencia"
            Me.col_tip_sent.Name = "col_tip_sent"
            Me.col_tip_sent.Visible = False
            Me.col_tip_sent.Width = 150
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
            Me.col_nom_del_gen.Width = 110
            '
            'uscDetallRegistroAnulacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlExpedienteDelitoSuperior)
            Me.Name = "uscDetallRegistroAnulacion"
            Me.Size = New System.Drawing.Size(807, 298)
            Me.pnlTituloExpediente.ResumeLayout(False)
            Me.pnlTituloExpediente.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.Panel10.ResumeLayout(False)
            Me.Panel10.PerformLayout()
            Me.Panel9.ResumeLayout(False)
            Me.pnlAnularExpediente.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvListarDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.Panel8.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlInferior.ResumeLayout(False)
            Me.pnlListaDocumentos.ResumeLayout(False)
            Me.pnlDelitosAgraviados.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.pnlExpedienteDelitoSuperior.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlTituloExpediente As System.Windows.Forms.Panel
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents pnlExpeMant As System.Windows.Forms.Panel
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents pnlAnularExpediente As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents dgvListarDocumentos As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents lblDocumentos As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents btnAgregarDocumentos As System.Windows.Forms.Button
        Friend WithEvents btnEditDocumentos As System.Windows.Forms.Button
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents btnElimarOtros As System.Windows.Forms.Button
        Friend WithEvents pnlInferior As System.Windows.Forms.Panel
        Friend WithEvents pnlExpedienteDelitoSuperior As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents btnAddDelito As System.Windows.Forms.Button
        Friend WithEvents btnEditDelito As System.Windows.Forms.Button
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnDelDelito As System.Windows.Forms.Button
        Friend WithEvents lblDelitosAgraviados As System.Windows.Forms.Label
        Friend WithEvents pnlDelitosAgraviados As System.Windows.Forms.Panel
        Friend WithEvents pnlListaDocumentos As System.Windows.Forms.Panel
        Friend WithEvents Panel10 As System.Windows.Forms.Panel
        Friend WithEvents tvExpe As System.Windows.Forms.TreeView
        Friend WithEvents chkLista As System.Windows.Forms.CheckBox
        Friend WithEvents col_doc_tip_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_sub_tip_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_folio As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_nro_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_ref As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_exp_ref_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_exp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sit_jur As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_secre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_flag As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents col_eliminar As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_est_anu As DataGridViewCheckBoxColumn
        Friend WithEvents col_int_del_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent As DataGridViewComboBoxColumn
        Friend WithEvents col_agrav_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_delito_item As DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As DataGridViewTextBoxColumn
        Friend WithEvents col_del_obs As DataGridViewTextBoxColumn
        Friend WithEvents col_nom_del_gen As DataGridViewTextBoxColumn
    End Class
End Namespace