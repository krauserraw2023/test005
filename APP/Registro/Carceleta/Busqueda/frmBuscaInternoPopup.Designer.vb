Namespace Registro.Main.Carceleta
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmBuscaInternoPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaInternoPopup))
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnRegNuevo = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnSiguiente = New System.Windows.Forms.Button()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.rdbPD = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPF = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbPI = New Legolas.APPUIComponents.myRadioButton()
            Me.UscFotografia_2v1 = New APPControls.Foto.uscFotografia_2v()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ult_ing_pen = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ult_n_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_ver_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.lblTotReg01 = New System.Windows.Forms.Label()
            Me.rdbApellidos = New System.Windows.Forms.RadioButton()
            Me.rdbPorDni = New System.Windows.Forms.RadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gbApe = New System.Windows.Forms.GroupBox()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel9.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.gbApe.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(977, 467)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(7, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(84, 13)
            Me.Label1.TabIndex = 44
            Me.Label1.Text = "Tipo doc. ident.:"
            '
            'ImageList1
            '
            Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.ImageList1.Images.SetKeyName(0, "database_icon.png")
            Me.ImageList1.Images.SetKeyName(1, "bd_remote.jpg")
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnRegNuevo)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Controls.Add(Me.btnSiguiente)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 419)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(977, 48)
            Me.Panel1.TabIndex = 52
            '
            'btnRegNuevo
            '
            Me.btnRegNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRegNuevo.Image = Global.SIPPOPE.My.Resources.Resources.id_card_view
            Me.btnRegNuevo.Location = New System.Drawing.Point(4, 1)
            Me.btnRegNuevo.Name = "btnRegNuevo"
            Me.btnRegNuevo.Size = New System.Drawing.Size(128, 47)
            Me.btnRegNuevo.TabIndex = 107
            Me.btnRegNuevo.Text = "Registrar manualmente"
            Me.btnRegNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(867, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 43)
            Me.btnCancel.TabIndex = 105
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(760, 1)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(105, 43)
            Me.btnAceptar.TabIndex = 104
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnSiguiente
            '
            Me.btnSiguiente.BackColor = System.Drawing.Color.Transparent
            Me.btnSiguiente.Image = Global.SIPPOPE.My.Resources.Resources.logo_reniec
            Me.btnSiguiente.Location = New System.Drawing.Point(138, 1)
            Me.btnSiguiente.Name = "btnSiguiente"
            Me.btnSiguiente.Size = New System.Drawing.Size(128, 47)
            Me.btnSiguiente.TabIndex = 1
            Me.btnSiguiente.Text = "Buscar en reniec"
            Me.btnSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSiguiente.UseVisualStyleBackColor = False
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.Location = New System.Drawing.Point(3, 32)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(60, 58)
            Me.btnBuscar.TabIndex = 54
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Panel5)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(977, 419)
            Me.Panel2.TabIndex = 55
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Panel6)
            Me.Panel5.Controls.Add(Me.dgwGrilla)
            Me.Panel5.Controls.Add(Me.Panel3)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(0, 24)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(975, 393)
            Me.Panel5.TabIndex = 53
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.Panel8)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(768, 120)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(207, 273)
            Me.Panel6.TabIndex = 59
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.Panel9)
            Me.Panel8.Controls.Add(Me.UscFotografia_2v1)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel8.Location = New System.Drawing.Point(0, 0)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(207, 254)
            Me.Panel8.TabIndex = 0
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.rdbPD)
            Me.Panel9.Controls.Add(Me.rdbPF)
            Me.Panel9.Controls.Add(Me.rdbPI)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel9.Location = New System.Drawing.Point(0, 231)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(207, 23)
            Me.Panel9.TabIndex = 0
            '
            'rdbPD
            '
            Me.rdbPD.AutoSize = True
            Me.rdbPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPD.Location = New System.Drawing.Point(118, 3)
            Me.rdbPD.Name = "rdbPD"
            Me.rdbPD.Size = New System.Drawing.Size(42, 17)
            Me.rdbPD.TabIndex = 2
            Me.rdbPD.Text = "PD"
            Me.rdbPD.UseVisualStyleBackColor = True
            '
            'rdbPF
            '
            Me.rdbPF.AutoSize = True
            Me.rdbPF.Checked = True
            Me.rdbPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPF.Location = New System.Drawing.Point(67, 3)
            Me.rdbPF.Name = "rdbPF"
            Me.rdbPF.Size = New System.Drawing.Size(40, 17)
            Me.rdbPF.TabIndex = 1
            Me.rdbPF.TabStop = True
            Me.rdbPF.Text = "PF"
            Me.rdbPF.UseVisualStyleBackColor = True
            '
            'rdbPI
            '
            Me.rdbPI.AutoSize = True
            Me.rdbPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPI.Location = New System.Drawing.Point(9, 3)
            Me.rdbPI.Name = "rdbPI"
            Me.rdbPI.Size = New System.Drawing.Size(37, 17)
            Me.rdbPI.TabIndex = 0
            Me.rdbPI.Text = "PI"
            Me.rdbPI.UseVisualStyleBackColor = True
            '
            'UscFotografia_2v1
            '
            Me.UscFotografia_2v1._CheckImagen = True
            Me.UscFotografia_2v1._EnabledDobleClick = True
            Me.UscFotografia_2v1._HasImagen = False
            Me.UscFotografia_2v1._PanelAutorizacion = False
            Me.UscFotografia_2v1._PanelCheck = False
            Me.UscFotografia_2v1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscFotografia_2v1.Location = New System.Drawing.Point(0, 0)
            Me.UscFotografia_2v1.Name = "UscFotografia_2v1"
            Me.UscFotografia_2v1.Size = New System.Drawing.Size(207, 254)
            Me.UscFotografia_2v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFotografia_2v1.TabIndex = 0
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_int_id, Me.col_tip_doc, Me.col_num_doc, Me.col_cod_uni, Me.col_pdr, Me.col_cod_rp, Me.col_nom_cla, Me.col_ape_pat, Me.col_ape_mat, Me.col_ape, Me.col_nom, Me.Column1, Me.col_pen_nom, Me.col_ult_ing_pen, Me.col_ult_n_ing, Me.col_reg_id, Me.col_pen_id, Me.col_est_nom, Me.col_est_id, Me.col_reg_ver_int})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 120)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(975, 273)
            Me.dgwGrilla.TabIndex = 56
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "Codigo"
            Me.col_int_id.DividerWidth = 1
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'col_tip_doc
            '
            Me.col_tip_doc.DataPropertyName = "TipoDocumentoID"
            Me.col_tip_doc.HeaderText = "TipoDocIdentidad"
            Me.col_tip_doc.Name = "col_tip_doc"
            Me.col_tip_doc.ReadOnly = True
            Me.col_tip_doc.Visible = False
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "NumeroDocumento"
            Me.col_num_doc.HeaderText = "N. Doc. Ident."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            '
            'col_cod_uni
            '
            Me.col_cod_uni.DataPropertyName = "CodigoUnicoInterno"
            Me.col_cod_uni.HeaderText = "Código Unico"
            Me.col_cod_uni.Name = "col_cod_uni"
            Me.col_cod_uni.ReadOnly = True
            Me.col_cod_uni.Visible = False
            '
            'col_pdr
            '
            Me.col_pdr.DataPropertyName = "CodigoPadre"
            Me.col_pdr.HeaderText = "CodigoPadre"
            Me.col_pdr.Name = "col_pdr"
            Me.col_pdr.ReadOnly = True
            Me.col_pdr.Visible = False
            '
            'col_cod_rp
            '
            Me.col_cod_rp.DataPropertyName = "CodigoRP"
            Me.col_cod_rp.DividerWidth = 1
            Me.col_cod_rp.HeaderText = "Código"
            Me.col_cod_rp.Name = "col_cod_rp"
            Me.col_cod_rp.ReadOnly = True
            Me.col_cod_rp.Width = 75
            '
            'col_nom_cla
            '
            Me.col_nom_cla.DataPropertyName = "NombreClaveInterno"
            Me.col_nom_cla.HeaderText = "Nombre Clave"
            Me.col_nom_cla.Name = "col_nom_cla"
            Me.col_nom_cla.ReadOnly = True
            Me.col_nom_cla.Visible = False
            '
            'col_ape_pat
            '
            Me.col_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_ape_pat.HeaderText = "ApellidoPaterno"
            Me.col_ape_pat.Name = "col_ape_pat"
            Me.col_ape_pat.ReadOnly = True
            Me.col_ape_pat.Visible = False
            '
            'col_ape_mat
            '
            Me.col_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_ape_mat.HeaderText = "ApellidoMaterno"
            Me.col_ape_mat.Name = "col_ape_mat"
            Me.col_ape_mat.ReadOnly = True
            Me.col_ape_mat.Visible = False
            '
            'col_ape
            '
            Me.col_ape.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_ape.DataPropertyName = "Apellidos"
            Me.col_ape.HeaderText = "Apellidos"
            Me.col_ape.Name = "col_ape"
            Me.col_ape.ReadOnly = True
            Me.col_ape.Width = 150
            '
            'col_nom
            '
            Me.col_nom.DataPropertyName = "Nombres"
            Me.col_nom.HeaderText = "Nombres"
            Me.col_nom.Name = "col_nom"
            Me.col_nom.ReadOnly = True
            Me.col_nom.Width = 150
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "RegionNombre"
            Me.Column1.HeaderText = "Región"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            '
            'col_ult_ing_pen
            '
            Me.col_ult_ing_pen.DataPropertyName = "FechaIngresoDate"
            Me.col_ult_ing_pen.HeaderText = "F. Ult. Ing."
            Me.col_ult_ing_pen.Name = "col_ult_ing_pen"
            Me.col_ult_ing_pen.ReadOnly = True
            Me.col_ult_ing_pen.ToolTipText = "Ultima de fecha de ingreso"
            '
            'col_ult_n_ing
            '
            Me.col_ult_n_ing.DataPropertyName = "IngresoNumeroStr"
            Me.col_ult_n_ing.HeaderText = "Ult. N° Ing"
            Me.col_ult_n_ing.Name = "col_ult_n_ing"
            Me.col_ult_n_ing.ReadOnly = True
            Me.col_ult_n_ing.ToolTipText = "Ultimo número de ingreso"
            Me.col_ult_n_ing.Width = 70
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.HeaderText = "IDRegion"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalID"
            Me.col_pen_id.HeaderText = "IDPenal"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_est_nom
            '
            Me.col_est_nom.DataPropertyName = "EstadoNombre"
            Me.col_est_nom.HeaderText = "Estado"
            Me.col_est_nom.Name = "col_est_nom"
            Me.col_est_nom.ReadOnly = True
            Me.col_est_nom.Width = 65
            '
            'col_est_id
            '
            Me.col_est_id.DataPropertyName = "EstadoID"
            Me.col_est_id.HeaderText = "EstadoId"
            Me.col_est_id.Name = "col_est_id"
            Me.col_est_id.ReadOnly = True
            Me.col_est_id.Visible = False
            '
            'col_reg_ver_int
            '
            Me.col_reg_ver_int.DataPropertyName = "VersionRegistro"
            Me.col_reg_ver_int.HeaderText = "VersionRegistroInterno"
            Me.col_reg_ver_int.Name = "col_reg_ver_int"
            Me.col_reg_ver_int.ReadOnly = True
            Me.col_reg_ver_int.Visible = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Panel7)
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(975, 120)
            Me.Panel3.TabIndex = 55
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.lblTotReg01)
            Me.Panel7.Controls.Add(Me.rdbApellidos)
            Me.Panel7.Controls.Add(Me.rdbPorDni)
            Me.Panel7.Controls.Add(Me.GroupBox1)
            Me.Panel7.Controls.Add(Me.gbApe)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(850, 120)
            Me.Panel7.TabIndex = 52
            '
            'lblTotReg01
            '
            Me.lblTotReg01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblTotReg01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotReg01.Location = New System.Drawing.Point(186, 98)
            Me.lblTotReg01.Name = "lblTotReg01"
            Me.lblTotReg01.Size = New System.Drawing.Size(607, 19)
            Me.lblTotReg01.TabIndex = 55
            Me.lblTotReg01.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'rdbApellidos
            '
            Me.rdbApellidos.BackColor = System.Drawing.Color.WhiteSmoke
            Me.rdbApellidos.Checked = True
            Me.rdbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbApellidos.Location = New System.Drawing.Point(15, 50)
            Me.rdbApellidos.Name = "rdbApellidos"
            Me.rdbApellidos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.rdbApellidos.Size = New System.Drawing.Size(161, 24)
            Me.rdbApellidos.TabIndex = 54
            Me.rdbApellidos.TabStop = True
            Me.rdbApellidos.Text = "Por apellidos"
            Me.rdbApellidos.UseVisualStyleBackColor = False
            '
            'rdbPorDni
            '
            Me.rdbPorDni.BackColor = System.Drawing.Color.WhiteSmoke
            Me.rdbPorDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbPorDni.Location = New System.Drawing.Point(15, 17)
            Me.rdbPorDni.Name = "rdbPorDni"
            Me.rdbPorDni.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
            Me.rdbPorDni.Size = New System.Drawing.Size(161, 24)
            Me.rdbPorDni.TabIndex = 53
            Me.rdbPorDni.Text = "Por Doc. Identidad"
            Me.rdbPorDni.UseVisualStyleBackColor = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtNumDoc)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Enabled = False
            Me.GroupBox1.Location = New System.Drawing.Point(186, -4)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(607, 49)
            Me.GroupBox1.TabIndex = 51
            Me.GroupBox1.TabStop = False
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = CType(2, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 150
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(90, 19)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(208, 22)
            Me.cbbTipoDoc.TabIndex = 46
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(315, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(89, 13)
            Me.Label2.TabIndex = 44
            Me.Label2.Text = "Número de doc. :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(410, 21)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(190, 20)
            Me.txtNumDoc.TabIndex = 47
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'gbApe
            '
            Me.gbApe.Controls.Add(Me.txtNom)
            Me.gbApe.Controls.Add(Me.Label29)
            Me.gbApe.Controls.Add(Me.Label27)
            Me.gbApe.Controls.Add(Me.txtApePat)
            Me.gbApe.Controls.Add(Me.txtApeMat)
            Me.gbApe.Controls.Add(Me.Label28)
            Me.gbApe.Location = New System.Drawing.Point(186, 37)
            Me.gbApe.Name = "gbApe"
            Me.gbApe.Size = New System.Drawing.Size(607, 60)
            Me.gbApe.TabIndex = 52
            Me.gbApe.TabStop = False
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(90, 36)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(510, 20)
            Me.txtNom.TabIndex = 33
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(6, 18)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(82, 13)
            Me.Label29.TabIndex = 28
            Me.Label29.Text = "Primer Apellido :"
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(33, 40)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(55, 13)
            Me.Label27.TabIndex = 30
            Me.Label27.Text = "Nombres :"
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.BackColor = System.Drawing.SystemColors.Info
            Me.txtApePat.ForeColor = System.Drawing.SystemColors.InfoText
            Me.txtApePat.Location = New System.Drawing.Point(90, 13)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(208, 20)
            Me.txtApePat.TabIndex = 31
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer))
            Me.txtApeMat.Location = New System.Drawing.Point(412, 12)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(188, 20)
            Me.txtApeMat.TabIndex = 32
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(312, 16)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(93, 13)
            Me.Label28.TabIndex = 29
            Me.Label28.Text = "Segundo Apellido:"
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.btnBuscar)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel4.Location = New System.Drawing.Point(850, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(125, 120)
            Me.Panel4.TabIndex = 0
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(0, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(975, 24)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "BUSQUEDA EN LA BASE DE DATOS A NIVEL NACIONAL"
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'frmBuscaInternoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(977, 467)
            Me.Name = "frmBuscaInternoPopup"
            Me.Text = ".::. Búsqueda de interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.Panel8.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.Panel9.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.gbApe.ResumeLayout(False)
            Me.gbApe.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnSiguiente As System.Windows.Forms.Button
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents gbApe As System.Windows.Forms.GroupBox
        Friend WithEvents rdbPorDni As System.Windows.Forms.RadioButton
        Friend WithEvents rdbApellidos As System.Windows.Forms.RadioButton
        Friend WithEvents btnRegNuevo As System.Windows.Forms.Button
        Friend WithEvents lblTotReg01 As System.Windows.Forms.Label
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tip_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod_uni As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pdr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod_rp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom_cla As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ape As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ult_ing_pen As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ult_n_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_ver_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel6 As Panel
        Friend WithEvents Panel8 As Panel
        Friend WithEvents Panel9 As Panel
        Friend WithEvents rdbPD As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPF As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbPI As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents UscFotografia_2v1 As APPControls.Foto.uscFotografia_2v
    End Class
End Namespace