Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDetallAcumulacionExp
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
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.pnlExpediente = New System.Windows.Forms.Panel()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.pnlTituloExpediente = New System.Windows.Forms.Panel()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.pnlAnularExpediente = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.pnlAgraviados = New System.Windows.Forms.Panel()
            Me.dgwAgraviados = New Legolas.APPUIComponents.myDatagridView()
            Me.col_agr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nom_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_delito_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAnularAgrav = New System.Windows.Forms.Button()
            Me.lblNroAgraviados = New System.Windows.Forms.Label()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnAddAgrav = New System.Windows.Forms.Button()
            Me.btnEditAgrav = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelAgrav = New System.Windows.Forms.Button()
            Me.pnlDelitos = New System.Windows.Forms.Panel()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_anulacion = New System.Windows.Forms.DataGridViewImageColumn()
            Me.colEliminarDelito = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlDelitoMant = New System.Windows.Forms.Panel()
            Me.btnAddDelito = New System.Windows.Forms.Button()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.pnlEliminarDelito = New System.Windows.Forms.Panel()
            Me.btnDelDelito = New System.Windows.Forms.Button()
            Me.btnAnularDelito = New System.Windows.Forms.Button()
            Me.lblNrodelitos = New System.Windows.Forms.Label()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            Me.pnlExpediente.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTituloExpediente.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.pnlAnularExpediente.SuspendLayout()
            Me.pnlAgraviados.SuspendLayout()
            CType(Me.dgwAgraviados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            Me.pnlDelitos.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.pnlDelitoMant.SuspendLayout()
            Me.pnlEliminarDelito.SuspendLayout()
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
            Me.SplitContainer1.Panel1.Controls.Add(Me.pnlExpediente)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.pnlAgraviados)
            Me.SplitContainer1.Panel2.Controls.Add(Me.pnlDelitos)
            Me.SplitContainer1.Size = New System.Drawing.Size(807, 320)
            Me.SplitContainer1.SplitterDistance = 145
            Me.SplitContainer1.TabIndex = 2
            '
            'pnlExpediente
            '
            Me.pnlExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlExpediente.Controls.Add(Me.dgwExpediente)
            Me.pnlExpediente.Controls.Add(Me.pnlTituloExpediente)
            Me.pnlExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlExpediente.Name = "pnlExpediente"
            Me.pnlExpediente.Size = New System.Drawing.Size(807, 145)
            Me.pnlExpediente.TabIndex = 0
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_sel, Me.col_exp_ref, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_num_exp, Me.col_aut_jud, Me.col_sal_jud, Me.col_secre, Me.col_fec_man, Me.col_eliminar})
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
            Me.dgwExpediente.Size = New System.Drawing.Size(805, 115)
            Me.dgwExpediente.TabIndex = 1
            Me.dgwExpediente.VisibleCampos = True
            '
            'col_num
            '
            Me.col_num.HeaderText = "N°"
            Me.col_num.Name = "col_num"
            Me.col_num.Width = 25
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
            'pnlTituloExpediente
            '
            Me.pnlTituloExpediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTituloExpediente.Controls.Add(Me.lblNroExpedientes)
            Me.pnlTituloExpediente.Controls.Add(Me.pnlExpeMant)
            Me.pnlTituloExpediente.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTituloExpediente.Location = New System.Drawing.Point(0, 0)
            Me.pnlTituloExpediente.Name = "pnlTituloExpediente"
            Me.pnlTituloExpediente.Size = New System.Drawing.Size(805, 28)
            Me.pnlTituloExpediente.TabIndex = 0
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
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.Panel7)
            Me.pnlExpeMant.Controls.Add(Me.pnlAnularExpediente)
            Me.pnlExpeMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeMant.Location = New System.Drawing.Point(686, 0)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(117, 26)
            Me.pnlExpeMant.TabIndex = 1
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.btnAddExp)
            Me.Panel7.Controls.Add(Me.btnEditExpe)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel7.Location = New System.Drawing.Point(25, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(62, 26)
            Me.Panel7.TabIndex = 87
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Location = New System.Drawing.Point(3, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 26)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Location = New System.Drawing.Point(32, 0)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 26)
            Me.btnEditExpe.TabIndex = 84
            Me.btnEditExpe.UseVisualStyleBackColor = True
            '
            'pnlAnularExpediente
            '
            Me.pnlAnularExpediente.Controls.Add(Me.btnEliminarExp)
            Me.pnlAnularExpediente.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAnularExpediente.Location = New System.Drawing.Point(87, 0)
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
            Me.btnEliminarExp.TabIndex = 90
            Me.btnEliminarExp.UseVisualStyleBackColor = True
            '
            'pnlAgraviados
            '
            Me.pnlAgraviados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlAgraviados.Controls.Add(Me.dgwAgraviados)
            Me.pnlAgraviados.Controls.Add(Me.Panel3)
            Me.pnlAgraviados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAgraviados.Location = New System.Drawing.Point(533, 0)
            Me.pnlAgraviados.Name = "pnlAgraviados"
            Me.pnlAgraviados.Size = New System.Drawing.Size(274, 171)
            Me.pnlAgraviados.TabIndex = 1
            '
            'dgwAgraviados
            '
            Me.dgwAgraviados.AllowUserToAddRows = False
            Me.dgwAgraviados.AllowUserToDeleteRows = False
            Me.dgwAgraviados.AllowUserToResizeRows = False
            Me.dgwAgraviados.BackgroundColor = System.Drawing.Color.White
            Me.dgwAgraviados.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAgraviados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwAgraviados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwAgraviados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_agr_id, Me.col_agr_exp_item, Me.col_agr_del_item, Me.col_agrav_item, Me.nom_agrav, Me.col_obs, Me.col_delito_id})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwAgraviados.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwAgraviados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwAgraviados.GridColor = System.Drawing.Color.LightGray
            Me.dgwAgraviados.Location = New System.Drawing.Point(0, 30)
            Me.dgwAgraviados.MultiSelect = False
            Me.dgwAgraviados.Name = "dgwAgraviados"
            Me.dgwAgraviados.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwAgraviados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwAgraviados.RowHeadersVisible = False
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwAgraviados.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwAgraviados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwAgraviados.Size = New System.Drawing.Size(272, 139)
            Me.dgwAgraviados.TabIndex = 4
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
            'col_agrav_item
            '
            Me.col_agrav_item.DataPropertyName = "AgraviadoItem"
            Me.col_agrav_item.HeaderText = "AgraviadoItem"
            Me.col_agrav_item.Name = "col_agrav_item"
            Me.col_agrav_item.ReadOnly = True
            Me.col_agrav_item.Visible = False
            Me.col_agrav_item.Width = 40
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
            Me.Panel3.Controls.Add(Me.btnAnularAgrav)
            Me.Panel3.Controls.Add(Me.lblNroAgraviados)
            Me.Panel3.Controls.Add(Me.pnlAgravMant)
            Me.Panel3.Controls.Add(Me.pnlEliminarAgraviado)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(272, 30)
            Me.Panel3.TabIndex = 2
            '
            'btnAnularAgrav
            '
            Me.btnAnularAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
            Me.btnAnularAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAnularAgrav.Location = New System.Drawing.Point(126, -1)
            Me.btnAnularAgrav.Name = "btnAnularAgrav"
            Me.btnAnularAgrav.Size = New System.Drawing.Size(30, 26)
            Me.btnAnularAgrav.TabIndex = 1
            Me.btnAnularAgrav.UseVisualStyleBackColor = True
            Me.btnAnularAgrav.Visible = False
            '
            'lblNroAgraviados
            '
            Me.lblNroAgraviados.AutoSize = True
            Me.lblNroAgraviados.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblNroAgraviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNroAgraviados.Location = New System.Drawing.Point(0, 0)
            Me.lblNroAgraviados.Name = "lblNroAgraviados"
            Me.lblNroAgraviados.Size = New System.Drawing.Size(120, 13)
            Me.lblNroAgraviados.TabIndex = 0
            Me.lblNroAgraviados.Text = "Agraviado(s) 0 Reg."
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnAddAgrav)
            Me.pnlAgravMant.Controls.Add(Me.btnEditAgrav)
            Me.pnlAgravMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravMant.Location = New System.Drawing.Point(174, 0)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(65, 28)
            Me.pnlAgravMant.TabIndex = 84
            '
            'btnAddAgrav
            '
            Me.btnAddAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddAgrav.Location = New System.Drawing.Point(4, 0)
            Me.btnAddAgrav.Name = "btnAddAgrav"
            Me.btnAddAgrav.Size = New System.Drawing.Size(30, 26)
            Me.btnAddAgrav.TabIndex = 9
            Me.btnAddAgrav.UseVisualStyleBackColor = True
            '
            'btnEditAgrav
            '
            Me.btnEditAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditAgrav.Location = New System.Drawing.Point(34, 0)
            Me.btnEditAgrav.Name = "btnEditAgrav"
            Me.btnEditAgrav.Size = New System.Drawing.Size(30, 26)
            Me.btnEditAgrav.TabIndex = 10
            Me.btnEditAgrav.UseVisualStyleBackColor = True
            '
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelAgrav)
            Me.pnlEliminarAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(239, 0)
            Me.pnlEliminarAgraviado.Name = "pnlEliminarAgraviado"
            Me.pnlEliminarAgraviado.Size = New System.Drawing.Size(31, 28)
            Me.pnlEliminarAgraviado.TabIndex = 92
            '
            'btnDelAgrav
            '
            Me.btnDelAgrav.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelAgrav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelAgrav.Location = New System.Drawing.Point(0, 0)
            Me.btnDelAgrav.Name = "btnDelAgrav"
            Me.btnDelAgrav.Size = New System.Drawing.Size(30, 26)
            Me.btnDelAgrav.TabIndex = 11
            Me.btnDelAgrav.UseVisualStyleBackColor = True
            '
            'pnlDelitos
            '
            Me.pnlDelitos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDelitos.Controls.Add(Me.dgwDelito)
            Me.pnlDelitos.Controls.Add(Me.Panel2)
            Me.pnlDelitos.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlDelitos.Location = New System.Drawing.Point(0, 0)
            Me.pnlDelitos.Name = "pnlDelitos"
            Me.pnlDelitos.Size = New System.Drawing.Size(533, 171)
            Me.pnlDelitos.TabIndex = 0
            '
            'dgwDelito
            '
            Me.dgwDelito.AllowUserToAddRows = False
            Me.dgwDelito.AllowUserToDeleteRows = False
            Me.dgwDelito.AllowUserToResizeRows = False
            Me.dgwDelito.BackgroundColor = System.Drawing.Color.White
            Me.dgwDelito.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwDelito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.DataGridViewTextBoxColumn3, Me.col_del_esp_nom, Me.col_del_esp_id, Me.col_del_anulacion, Me.colEliminarDelito, Me.col_del_obs, Me.col_doc_jud_id})
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwDelito.DefaultCellStyle = DataGridViewCellStyle7
            Me.dgwDelito.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwDelito.GridColor = System.Drawing.Color.LightGray
            Me.dgwDelito.Location = New System.Drawing.Point(0, 31)
            Me.dgwDelito.MultiSelect = False
            Me.dgwDelito.Name = "dgwDelito"
            Me.dgwDelito.ReadOnly = True
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwDelito.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            Me.dgwDelito.RowHeadersVisible = False
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwDelito.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgwDelito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwDelito.Size = New System.Drawing.Size(531, 138)
            Me.dgwDelito.TabIndex = 5
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
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "DelitoGenericoNombre"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Delito Generico"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.ReadOnly = True
            Me.DataGridViewTextBoxColumn3.Width = 280
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
            Me.Panel2.Controls.Add(Me.pnlDelitoMant)
            Me.Panel2.Controls.Add(Me.pnlEliminarDelito)
            Me.Panel2.Controls.Add(Me.btnAnularDelito)
            Me.Panel2.Controls.Add(Me.lblNrodelitos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(531, 31)
            Me.Panel2.TabIndex = 3
            '
            'pnlDelitoMant
            '
            Me.pnlDelitoMant.Controls.Add(Me.btnAddDelito)
            Me.pnlDelitoMant.Controls.Add(Me.btnEditDelito)
            Me.pnlDelitoMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlDelitoMant.Location = New System.Drawing.Point(433, 0)
            Me.pnlDelitoMant.Name = "pnlDelitoMant"
            Me.pnlDelitoMant.Size = New System.Drawing.Size(64, 29)
            Me.pnlDelitoMant.TabIndex = 85
            '
            'btnAddDelito
            '
            Me.btnAddDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddDelito.Location = New System.Drawing.Point(3, -1)
            Me.btnAddDelito.Name = "btnAddDelito"
            Me.btnAddDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnAddDelito.TabIndex = 5
            Me.btnAddDelito.UseVisualStyleBackColor = True
            '
            'btnEditDelito
            '
            Me.btnEditDelito.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditDelito.Location = New System.Drawing.Point(33, -1)
            Me.btnEditDelito.Name = "btnEditDelito"
            Me.btnEditDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnEditDelito.TabIndex = 6
            Me.btnEditDelito.UseVisualStyleBackColor = True
            '
            'pnlEliminarDelito
            '
            Me.pnlEliminarDelito.Controls.Add(Me.btnDelDelito)
            Me.pnlEliminarDelito.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarDelito.Location = New System.Drawing.Point(497, 0)
            Me.pnlEliminarDelito.Name = "pnlEliminarDelito"
            Me.pnlEliminarDelito.Size = New System.Drawing.Size(32, 29)
            Me.pnlEliminarDelito.TabIndex = 93
            '
            'btnDelDelito
            '
            Me.btnDelDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelDelito.Location = New System.Drawing.Point(0, -1)
            Me.btnDelDelito.Name = "btnDelDelito"
            Me.btnDelDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnDelDelito.TabIndex = 7
            Me.btnDelDelito.UseVisualStyleBackColor = True
            '
            'btnAnularDelito
            '
            Me.btnAnularDelito.BackgroundImage = Global.APPControls.My.Resources.Resources.anular2
            Me.btnAnularDelito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAnularDelito.Location = New System.Drawing.Point(124, 2)
            Me.btnAnularDelito.Name = "btnAnularDelito"
            Me.btnAnularDelito.Size = New System.Drawing.Size(30, 26)
            Me.btnAnularDelito.TabIndex = 1
            Me.btnAnularDelito.UseVisualStyleBackColor = True
            Me.btnAnularDelito.Visible = False
            '
            'lblNrodelitos
            '
            Me.lblNrodelitos.AutoSize = True
            Me.lblNrodelitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNrodelitos.Location = New System.Drawing.Point(5, 5)
            Me.lblNrodelitos.Name = "lblNrodelitos"
            Me.lblNrodelitos.Size = New System.Drawing.Size(104, 13)
            Me.lblNrodelitos.TabIndex = 0
            Me.lblNrodelitos.Text = "Delito(s) : 0 Reg."
            '
            'uscDetallAcumulacionExp
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer1)
            Me.Name = "uscDetallAcumulacionExp"
            Me.Size = New System.Drawing.Size(807, 320)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            Me.pnlExpediente.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTituloExpediente.ResumeLayout(False)
            Me.pnlTituloExpediente.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.pnlAnularExpediente.ResumeLayout(False)
            Me.pnlAgraviados.ResumeLayout(False)
            CType(Me.dgwAgraviados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.pnlDelitos.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlDelitoMant.ResumeLayout(False)
            Me.pnlEliminarDelito.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents pnlDelitos As System.Windows.Forms.Panel
        Friend WithEvents pnlExpediente As System.Windows.Forms.Panel
        Friend WithEvents pnlTituloExpediente As System.Windows.Forms.Panel
        Friend WithEvents pnlExpeMant As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents pnlAnularExpediente As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents dgwAgraviados As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlAgravMant As System.Windows.Forms.Panel
        Friend WithEvents btnAddAgrav As System.Windows.Forms.Button
        Friend WithEvents btnEditAgrav As System.Windows.Forms.Button
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents btnDelAgrav As System.Windows.Forms.Button
        Friend WithEvents btnAnularAgrav As System.Windows.Forms.Button
        Friend WithEvents lblNroAgraviados As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlDelitoMant As System.Windows.Forms.Panel
        Friend WithEvents btnAddDelito As System.Windows.Forms.Button
        Friend WithEvents btnEditDelito As System.Windows.Forms.Button
        Friend WithEvents pnlEliminarDelito As System.Windows.Forms.Panel
        Friend WithEvents btnDelDelito As System.Windows.Forms.Button
        Friend WithEvents btnAnularDelito As System.Windows.Forms.Button
        Friend WithEvents lblNrodelitos As System.Windows.Forms.Label
        Friend WithEvents col_num As System.Windows.Forms.DataGridViewTextBoxColumn
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
        Friend WithEvents col_agr_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents nom_agrav As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_delito_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_del_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_anulacion As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents colEliminarDelito As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents col_del_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlAgraviados As System.Windows.Forms.Panel

    End Class
End Namespace