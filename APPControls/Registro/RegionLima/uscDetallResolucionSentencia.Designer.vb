Namespace Registro.RegionLima
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscDetallResolucionSentencia))
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.dgwExpediente = New Legolas.APPUIComponents.myDatagridView()
            Me.col_sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_exp_ref = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jdu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_res_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_res_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_res_btn = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_num_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_aut_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sal_jud = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminar = New System.Windows.Forms.DataGridViewImageColumn()
            Me.col_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id_tip_imim = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id_cen_sal_men = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlExpeMant = New System.Windows.Forms.Panel()
            Me.btnInimputable = New System.Windows.Forms.Button()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.btnEditExpe = New System.Windows.Forms.Button()
            Me.lblNroExpedientes = New System.Windows.Forms.Label()
            Me.pnlExpeElim = New System.Windows.Forms.Panel()
            Me.btnEliminarExp = New System.Windows.Forms.Button()
            Me.dgwDelito = New System.Windows.Forms.DataGridView()
            Me.col_int_del_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_reso_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_reso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_sent = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.col_sent_hist = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sen_his_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agrav_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_delito_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_agr_exp_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_del_gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnAddAgrav = New System.Windows.Forms.Button()
            Me.btnEditDelito = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelAgrav = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainer1.Panel1.SuspendLayout()
            Me.SplitContainer1.Panel2.SuspendLayout()
            Me.SplitContainer1.SuspendLayout()
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.pnlExpeMant.SuspendLayout()
            Me.pnlExpeElim.SuspendLayout()
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
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
            Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
            '
            'SplitContainer1.Panel2
            '
            Me.SplitContainer1.Panel2.Controls.Add(Me.dgwDelito)
            Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
            Me.SplitContainer1.Size = New System.Drawing.Size(807, 340)
            Me.SplitContainer1.SplitterDistance = 150
            Me.SplitContainer1.TabIndex = 2
            '
            'dgwExpediente
            '
            Me.dgwExpediente.AllowUserToAddRows = False
            Me.dgwExpediente.AllowUserToDeleteRows = False
            Me.dgwExpediente.AllowUserToResizeRows = False
            Me.dgwExpediente.BackgroundColor = System.Drawing.Color.White
            Me.dgwExpediente.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwExpediente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel, Me.col_exp_ref, Me.col_item, Me.codigo, Me.col_doc_jdu_id, Me.col_exp_res_id, Me.col_exp_res_nom, Me.col_exp_res_btn, Me.col_num_exp, Me.col_aut_jud, Me.col_sal_jud, Me.col_secre, Me.col_eliminar, Me.col_flag, Me.col_id_tip_imim, Me.col_id_cen_sal_men})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwExpediente.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgwExpediente.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwExpediente.GridColor = System.Drawing.Color.LightGray
            Me.dgwExpediente.Location = New System.Drawing.Point(0, 28)
            Me.dgwExpediente.MultiSelect = False
            Me.dgwExpediente.Name = "dgwExpediente"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwExpediente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwExpediente.RowHeadersVisible = False
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwExpediente.RowsDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwExpediente.Size = New System.Drawing.Size(807, 122)
            Me.dgwExpediente.TabIndex = 2
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
            'col_num_exp
            '
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
            Me.col_aut_jud.Width = 190
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
            Me.col_flag.Width = 30
            '
            'col_id_tip_imim
            '
            Me.col_id_tip_imim.HeaderText = "MotivoIngresoID"
            Me.col_id_tip_imim.Name = "col_id_tip_imim"
            Me.col_id_tip_imim.Visible = False
            '
            'col_id_cen_sal_men
            '
            Me.col_id_cen_sal_men.HeaderText = "EstablecimientomentalId"
            Me.col_id_cen_sal_men.Name = "col_id_cen_sal_men"
            Me.col_id_cen_sal_men.Visible = False
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
            Me.Panel2.Size = New System.Drawing.Size(807, 28)
            Me.Panel2.TabIndex = 0
            '
            'pnlExpeMant
            '
            Me.pnlExpeMant.Controls.Add(Me.btnInimputable)
            Me.pnlExpeMant.Controls.Add(Me.btnAddExp)
            Me.pnlExpeMant.Controls.Add(Me.btnEditExpe)
            Me.pnlExpeMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlExpeMant.Location = New System.Drawing.Point(623, 0)
            Me.pnlExpeMant.Name = "pnlExpeMant"
            Me.pnlExpeMant.Size = New System.Drawing.Size(147, 26)
            Me.pnlExpeMant.TabIndex = 1
            '
            'btnInimputable
            '
            Me.btnInimputable.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnInimputable.Image = CType(resources.GetObject("btnInimputable.Image"), System.Drawing.Image)
            Me.btnInimputable.Location = New System.Drawing.Point(0, 0)
            Me.btnInimputable.Name = "btnInimputable"
            Me.btnInimputable.Size = New System.Drawing.Size(33, 26)
            Me.btnInimputable.TabIndex = 18
            Me.btnInimputable.UseVisualStyleBackColor = True
            Me.btnInimputable.Visible = False
            '
            'btnAddExp
            '
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAddExp.Location = New System.Drawing.Point(87, 0)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(30, 26)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'btnEditExpe
            '
            Me.btnEditExpe.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditExpe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditExpe.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditExpe.Location = New System.Drawing.Point(117, 0)
            Me.btnEditExpe.Name = "btnEditExpe"
            Me.btnEditExpe.Size = New System.Drawing.Size(30, 26)
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
            Me.pnlExpeElim.Location = New System.Drawing.Point(770, 0)
            Me.pnlExpeElim.Name = "pnlExpeElim"
            Me.pnlExpeElim.Size = New System.Drawing.Size(35, 26)
            Me.pnlExpeElim.TabIndex = 2
            '
            'btnEliminarExp
            '
            Me.btnEliminarExp.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarExp.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnEliminarExp.Location = New System.Drawing.Point(0, 0)
            Me.btnEliminarExp.Name = "btnEliminarExp"
            Me.btnEliminarExp.Size = New System.Drawing.Size(35, 26)
            Me.btnEliminarExp.TabIndex = 0
            Me.btnEliminarExp.UseVisualStyleBackColor = True
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
            Me.dgwDelito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_del_id, Me.col_exp_id, Me.col_exp_item, Me.col_del_item, Me.col_del_esp_nom, Me.col_agrav, Me.col_tip_reso_id, Me.col_tip_reso, Me.col_tip_sent, Me.col_sent_hist, Me.col_sen_his_id, Me.col_agrav_cod, Me.col_agrav_item, Me.col_agr_delito_item, Me.col_agr_exp_item, Me.col_del_obs, Me.col_nom_del_gen})
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
            Me.dgwDelito.Location = New System.Drawing.Point(0, 27)
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
            Me.dgwDelito.Size = New System.Drawing.Size(807, 159)
            Me.dgwDelito.TabIndex = 2
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
            Me.col_del_esp_nom.Width = 279
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
            Me.col_tip_reso.Width = 120
            '
            'col_tip_sent
            '
            Me.col_tip_sent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_tip_sent.HeaderText = "Nueva Sentencia"
            Me.col_tip_sent.Name = "col_tip_sent"
            Me.col_tip_sent.Visible = False
            Me.col_tip_sent.Width = 98
            '
            'col_sent_hist
            '
            Me.col_sent_hist.DataPropertyName = "TipoSentenciaHistoricoNombre"
            Me.col_sent_hist.HeaderText = "Sentencia Anterior"
            Me.col_sent_hist.Name = "col_sent_hist"
            Me.col_sent_hist.ReadOnly = True
            Me.col_sent_hist.Visible = False
            Me.col_sent_hist.Width = 90
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
            'Panel5
            '
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.pnlAgravMant)
            Me.Panel5.Controls.Add(Me.pnlEliminarAgraviado)
            Me.Panel5.Controls.Add(Me.Label5)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(807, 27)
            Me.Panel5.TabIndex = 0
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnAddAgrav)
            Me.pnlAgravMant.Controls.Add(Me.btnEditDelito)
            Me.pnlAgravMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravMant.Location = New System.Drawing.Point(716, 0)
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
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(774, 0)
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
            'Label5
            '
            Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(4, 5)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(143, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Delito(s) por Expediente"
            '
            'uscDetallResolucionSentencia
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SplitContainer1)
            Me.Name = "uscDetallResolucionSentencia"
            Me.Size = New System.Drawing.Size(807, 340)
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainer1.ResumeLayout(False)
            CType(Me.dgwExpediente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlExpeMant.ResumeLayout(False)
            Me.pnlExpeElim.ResumeLayout(False)
            CType(Me.dgwDelito, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents pnlAgravMant As System.Windows.Forms.Panel
        Friend WithEvents btnAddAgrav As System.Windows.Forms.Button
        Friend WithEvents btnEditDelito As System.Windows.Forms.Button
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents btnDelAgrav As System.Windows.Forms.Button
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlExpeElim As System.Windows.Forms.Panel
        Friend WithEvents btnAddExp As System.Windows.Forms.Button
        Friend WithEvents btnEditExpe As System.Windows.Forms.Button
        Friend WithEvents btnEliminarExp As System.Windows.Forms.Button
        Friend WithEvents lblNroExpedientes As System.Windows.Forms.Label
        Friend WithEvents pnlExpeMant As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents dgwExpediente As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents dgwDelito As System.Windows.Forms.DataGridView
        Friend WithEvents col_int_del_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agrav As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_reso_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_reso As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_sent As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents col_sent_hist As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sen_his_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agrav_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_delito_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_agr_exp_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del_obs As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_del_gen As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel As DataGridViewCheckBoxColumn
        Friend WithEvents col_exp_ref As DataGridViewImageColumn
        Friend WithEvents col_item As DataGridViewTextBoxColumn
        Friend WithEvents codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jdu_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_res_id As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_res_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_res_btn As DataGridViewImageColumn
        Friend WithEvents col_num_exp As DataGridViewTextBoxColumn
        Friend WithEvents col_aut_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_sal_jud As DataGridViewTextBoxColumn
        Friend WithEvents col_secre As DataGridViewTextBoxColumn
        Friend WithEvents col_eliminar As DataGridViewImageColumn
        Friend WithEvents col_flag As DataGridViewCheckBoxColumn
        Friend WithEvents col_id_tip_imim As DataGridViewTextBoxColumn
        Friend WithEvents col_id_cen_sal_men As DataGridViewTextBoxColumn
        Friend WithEvents btnInimputable As Button
    End Class
End Namespace