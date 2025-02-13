Namespace Registro.Carceleta.Clasificacion.Documento
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantDocClasificacion
        Inherits Legolas.APPUIComponents.FormPopup

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cboGlosa = New System.Windows.Forms.ComboBox()
            Me.txtDestinatarioDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSerie = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtAnio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaEmision = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.cboEstado = New APPControls.uscComboParametrica()
            Me.btnDetalle = New System.Windows.Forms.Button()
            Me.txtObvs = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtRegionPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label28 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.dgvDetalle = New System.Windows.Forms.DataGridView()
            Me.col_id_class = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_penid_dest = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_cod_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_nom_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_n_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_fec_cla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_doc_clas_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_det_int_fic_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.dgvInternosClasificados = New System.Windows.Forms.DataGridView()
            Me.col_sel_regid_dest = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_penid_dest = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_int_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_nom_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_ing_nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel_fec_clas = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sel = New System.Windows.Forms.DataGridViewImageColumn()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            CType(Me.dgvInternosClasificados, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel5)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(937, 494)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cboGlosa)
            Me.GroupBox1.Controls.Add(Me.txtDestinatarioDoc)
            Me.GroupBox1.Controls.Add(Me.txtNumDoc)
            Me.GroupBox1.Controls.Add(Me.txtSerie)
            Me.GroupBox1.Controls.Add(Me.txtAnio)
            Me.GroupBox1.Controls.Add(Me.dtpFechaEmision)
            Me.GroupBox1.Controls.Add(Me.cboEstado)
            Me.GroupBox1.Controls.Add(Me.btnDetalle)
            Me.GroupBox1.Controls.Add(Me.txtObvs)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 36)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(937, 100)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'cboGlosa
            '
            Me.cboGlosa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGlosa.FormattingEnabled = True
            Me.cboGlosa.Location = New System.Drawing.Point(574, 10)
            Me.cboGlosa.Name = "cboGlosa"
            Me.cboGlosa.Size = New System.Drawing.Size(88, 21)
            Me.cboGlosa.TabIndex = 16
            Me.ToolTip1.SetToolTip(Me.cboGlosa, "Seleccione la glosa que se mostrará en el cuerpo del oficio.")
            '
            'txtDestinatarioDoc
            '
            Me.txtDestinatarioDoc._BloquearPaste = False
            Me.txtDestinatarioDoc._SeleccionarTodo = False
            Me.txtDestinatarioDoc.BackColor = System.Drawing.Color.White
            Me.txtDestinatarioDoc.ForeColor = System.Drawing.Color.Black
            Me.txtDestinatarioDoc.Location = New System.Drawing.Point(422, 33)
            Me.txtDestinatarioDoc.MaxLength = 150
            Me.txtDestinatarioDoc.Name = "txtDestinatarioDoc"
            Me.txtDestinatarioDoc.Size = New System.Drawing.Size(508, 20)
            Me.txtDestinatarioDoc.TabIndex = 3
            Me.txtDestinatarioDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtDestinatarioDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.BackColor = System.Drawing.Color.White
            Me.txtNumDoc.ForeColor = System.Drawing.Color.Black
            Me.txtNumDoc.Location = New System.Drawing.Point(79, 33)
            Me.txtNumDoc.MaxLength = 60
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(261, 20)
            Me.txtNumDoc.TabIndex = 2
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.ToolTip1.SetToolTip(Me.txtNumDoc, "Número de oficio." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ejm: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         149-2012-INPE/19-235-HNRB")
            '
            'txtSerie
            '
            Me.txtSerie._BloquearPaste = False
            Me.txtSerie._SeleccionarTodo = False
            Me.txtSerie.BackColor = System.Drawing.Color.White
            Me.txtSerie.ForeColor = System.Drawing.Color.Black
            Me.txtSerie.Location = New System.Drawing.Point(129, 11)
            Me.txtSerie.MaxLength = 7
            Me.txtSerie.Name = "txtSerie"
            Me.txtSerie.Size = New System.Drawing.Size(96, 20)
            Me.txtSerie.TabIndex = 1
            Me.txtSerie.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSerie.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            Me.ToolTip1.SetToolTip(Me.txtSerie, "Número del documento")
            '
            'txtAnio
            '
            Me.txtAnio._BloquearPaste = False
            Me.txtAnio._SeleccionarTodo = False
            Me.txtAnio.Location = New System.Drawing.Point(80, 11)
            Me.txtAnio.MaxLength = 4
            Me.txtAnio.Name = "txtAnio"
            Me.txtAnio.Size = New System.Drawing.Size(37, 20)
            Me.txtAnio.TabIndex = 0
            Me.txtAnio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            Me.ToolTip1.SetToolTip(Me.txtAnio, "Año en formato de cuatro digitos")
            '
            'dtpFechaEmision
            '
            Me.dtpFechaEmision.Location = New System.Drawing.Point(423, 11)
            Me.dtpFechaEmision.Name = "dtpFechaEmision"
            Me.dtpFechaEmision.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaEmision.TabIndex = 5
            Me.ToolTip1.SetToolTip(Me.dtpFechaEmision, "Fecha de emisión del oficio")
            Me.dtpFechaEmision.Value = "/  /"
            Me.dtpFechaEmision.ValueLong = CType(0, Long)
            '
            'cboEstado
            '
            Me.cboEstado._NoIndica = False
            Me.cboEstado._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cboEstado._Todos = False
            Me.cboEstado._TodosMensaje = ""
            Me.cboEstado._Visible_Add = False
            Me.cboEstado._Visible_Buscar = False
            Me.cboEstado._Visible_Eliminar = False
            Me.cboEstado.CodigoPadre = -1
            Me.cboEstado.ComboTipo = Type.Combo.ComboTipo.ClasificacionEstadoDocumento
            Me.cboEstado.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cboEstado.DropDownWidth = 143
            Me.cboEstado.DropDownWidthAuto = False
            Me.cboEstado.Enabled = False
            Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboEstado.Location = New System.Drawing.Point(784, 10)
            Me.cboEstado.Name = "cboEstado"
            Me.cboEstado.Parametro1 = -1
            Me.cboEstado.Parametro2 = -1
            Me.cboEstado.SelectedIndex = -1
            Me.cboEstado.SelectedValue = 0
            Me.cboEstado.Size = New System.Drawing.Size(148, 22)
            Me.cboEstado.TabIndex = 0
            '
            'btnDetalle
            '
            Me.btnDetalle.BackgroundImage = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDetalle.Location = New System.Drawing.Point(660, 9)
            Me.btnDetalle.Name = "btnDetalle"
            Me.btnDetalle.Size = New System.Drawing.Size(24, 23)
            Me.btnDetalle.TabIndex = 4
            Me.ToolTip1.SetToolTip(Me.btnDetalle, "Ver detalle de la glosa")
            Me.btnDetalle.UseVisualStyleBackColor = True
            '
            'txtObvs
            '
            Me.txtObvs.Location = New System.Drawing.Point(79, 56)
            Me.txtObvs.MaxLength = 900
            Me.txtObvs.Multiline = True
            Me.txtObvs.Name = "txtObvs"
            Me.txtObvs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObvs.Size = New System.Drawing.Size(851, 40)
            Me.txtObvs.TabIndex = 6
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(117, 16)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(10, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "-"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(735, 16)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(43, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Estado:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(360, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(58, 13)
            Me.Label7.TabIndex = 0
            Me.Label7.Text = "F. Emisión:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(10, 56)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(70, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "Observación:"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(354, 38)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(66, 13)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "Destinatario:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(9, 37)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(67, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "N° de Oficio:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(537, 15)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(37, 13)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Glosa:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(47, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(29, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Año:"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscAuditUser1)
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 447)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(937, 47)
            Me.Panel2.TabIndex = 5
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 5)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(742, 42)
            Me.UscAuditUser1.TabIndex = 6
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(742, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(195, 47)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(2, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(97, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(937, 19)
            Me.Label8.TabIndex = 93
            Me.Label8.Text = "Detalle de Oficio"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtRegionPenal
            '
            Me.txtRegionPenal._BloquearPaste = False
            Me.txtRegionPenal._SeleccionarTodo = False
            Me.txtRegionPenal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtRegionPenal.BackColor = System.Drawing.Color.White
            Me.txtRegionPenal.Location = New System.Drawing.Point(81, 10)
            Me.txtRegionPenal.Name = "txtRegionPenal"
            Me.txtRegionPenal.ReadOnly = True
            Me.txtRegionPenal.Size = New System.Drawing.Size(849, 20)
            Me.txtRegionPenal.TabIndex = 1
            Me.txtRegionPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegionPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(5, 13)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(72, 13)
            Me.Label28.TabIndex = 0
            Me.Label28.Text = "Región/E.T. :"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtRegionPenal)
            Me.GroupBox2.Controls.Add(Me.Label28)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(937, 36)
            Me.GroupBox2.TabIndex = 8
            Me.GroupBox2.TabStop = False
            '
            'ToolTip1
            '
            Me.ToolTip1.AutoPopDelay = 5000
            Me.ToolTip1.InitialDelay = 250
            Me.ToolTip1.ReshowDelay = 100
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.dgvDetalle)
            Me.Panel4.Controls.Add(Me.Label8)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(0, 136)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(937, 157)
            Me.Panel4.TabIndex = 94
            '
            'dgvDetalle
            '
            Me.dgvDetalle.AllowUserToAddRows = False
            Me.dgvDetalle.AllowUserToDeleteRows = False
            Me.dgvDetalle.AllowUserToResizeRows = False
            Me.dgvDetalle.BackgroundColor = System.Drawing.Color.White
            Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id_class, Me.col_penid_dest, Me.col_det_codigo, Me.col_det_cod_int, Me.col_det_nom_int, Me.col_det_n_ing, Me.col_det_fec_cla, Me.col_det_doc_clas_id, Me.col_det_int_fic_id, Me.col_del})
            Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvDetalle.Location = New System.Drawing.Point(0, 19)
            Me.dgvDetalle.MultiSelect = False
            Me.dgvDetalle.Name = "dgvDetalle"
            Me.dgvDetalle.ReadOnly = True
            Me.dgvDetalle.RowHeadersVisible = False
            Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDetalle.Size = New System.Drawing.Size(937, 138)
            Me.dgvDetalle.TabIndex = 1
            '
            'col_id_class
            '
            Me.col_id_class.DataPropertyName = "ID_CLASS"
            Me.col_id_class.HeaderText = "ID_CLASS"
            Me.col_id_class.Name = "col_id_class"
            Me.col_id_class.ReadOnly = True
            Me.col_id_class.Visible = False
            '
            'col_penid_dest
            '
            Me.col_penid_dest.DataPropertyName = "PenalDestinoNombre"
            Me.col_penid_dest.HeaderText = "Penal Destino"
            Me.col_penid_dest.Name = "col_penid_dest"
            Me.col_penid_dest.ReadOnly = True
            Me.col_penid_dest.Width = 200
            '
            'col_det_codigo
            '
            Me.col_det_codigo.DataPropertyName = "Codigo"
            Me.col_det_codigo.HeaderText = "Codigo"
            Me.col_det_codigo.Name = "col_det_codigo"
            Me.col_det_codigo.ReadOnly = True
            Me.col_det_codigo.Visible = False
            '
            'col_det_cod_int
            '
            Me.col_det_cod_int.DataPropertyName = "CodigoInterno"
            Me.col_det_cod_int.HeaderText = "Cod. Interno"
            Me.col_det_cod_int.Name = "col_det_cod_int"
            Me.col_det_cod_int.ReadOnly = True
            '
            'col_det_nom_int
            '
            Me.col_det_nom_int.DataPropertyName = "NombresInterno"
            Me.col_det_nom_int.HeaderText = "Apellidos y Nombres"
            Me.col_det_nom_int.Name = "col_det_nom_int"
            Me.col_det_nom_int.ReadOnly = True
            Me.col_det_nom_int.Width = 250
            '
            'col_det_n_ing
            '
            Me.col_det_n_ing.DataPropertyName = "NumIngreso"
            Me.col_det_n_ing.HeaderText = "N° Ingreso"
            Me.col_det_n_ing.Name = "col_det_n_ing"
            Me.col_det_n_ing.ReadOnly = True
            '
            'col_det_fec_cla
            '
            Me.col_det_fec_cla.DataPropertyName = "FechaClasificacionString"
            Me.col_det_fec_cla.HeaderText = "Fecha Clasificación"
            Me.col_det_fec_cla.Name = "col_det_fec_cla"
            Me.col_det_fec_cla.ReadOnly = True
            Me.col_det_fec_cla.Width = 150
            '
            'col_det_doc_clas_id
            '
            Me.col_det_doc_clas_id.DataPropertyName = "DocClasificacionId"
            Me.col_det_doc_clas_id.HeaderText = "DocClasificacionId"
            Me.col_det_doc_clas_id.Name = "col_det_doc_clas_id"
            Me.col_det_doc_clas_id.ReadOnly = True
            Me.col_det_doc_clas_id.Visible = False
            '
            'col_det_int_fic_id
            '
            Me.col_det_int_fic_id.DataPropertyName = "InternoFichaId"
            Me.col_det_int_fic_id.HeaderText = "InternoFichaId"
            Me.col_det_int_fic_id.Name = "col_det_int_fic_id"
            Me.col_det_int_fic_id.ReadOnly = True
            Me.col_det_int_fic_id.Visible = False
            '
            'col_del
            '
            Me.col_del.HeaderText = "..."
            Me.col_del.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.col_del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_del.Name = "col_del"
            Me.col_del.ReadOnly = True
            Me.col_del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_del.Width = 20
            '
            'Label9
            '
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label9.Location = New System.Drawing.Point(0, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(937, 18)
            Me.Label9.TabIndex = 4
            Me.Label9.Text = "Internos clasificados (Seleccione para agregar al documento)"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.dgvInternosClasificados)
            Me.Panel5.Controls.Add(Me.Label9)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 293)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(937, 154)
            Me.Panel5.TabIndex = 95
            '
            'dgvInternosClasificados
            '
            Me.dgvInternosClasificados.AllowUserToAddRows = False
            Me.dgvInternosClasificados.AllowUserToDeleteRows = False
            Me.dgvInternosClasificados.AllowUserToResizeRows = False
            Me.dgvInternosClasificados.BackgroundColor = System.Drawing.Color.White
            Me.dgvInternosClasificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvInternosClasificados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sel_regid_dest, Me.col_sel_penid_dest, Me.col_sel_codigo, Me.col_sel_int_cod, Me.col_sel_nom_int, Me.col_sel_ing_nro, Me.col_sel_fec_clas, Me.col_sel})
            Me.dgvInternosClasificados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvInternosClasificados.Location = New System.Drawing.Point(0, 18)
            Me.dgvInternosClasificados.MultiSelect = False
            Me.dgvInternosClasificados.Name = "dgvInternosClasificados"
            Me.dgvInternosClasificados.ReadOnly = True
            Me.dgvInternosClasificados.RowHeadersVisible = False
            Me.dgvInternosClasificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvInternosClasificados.Size = New System.Drawing.Size(937, 136)
            Me.dgvInternosClasificados.TabIndex = 0
            '
            'col_sel_regid_dest
            '
            Me.col_sel_regid_dest.DataPropertyName = "RegionDestinoNombre"
            Me.col_sel_regid_dest.HeaderText = "Destino Región"
            Me.col_sel_regid_dest.Name = "col_sel_regid_dest"
            Me.col_sel_regid_dest.ReadOnly = True
            Me.col_sel_regid_dest.Visible = False
            Me.col_sel_regid_dest.Width = 150
            '
            'col_sel_penid_dest
            '
            Me.col_sel_penid_dest.DataPropertyName = "PenalDestinoNombre"
            Me.col_sel_penid_dest.HeaderText = "Destino Penal"
            Me.col_sel_penid_dest.Name = "col_sel_penid_dest"
            Me.col_sel_penid_dest.ReadOnly = True
            Me.col_sel_penid_dest.Width = 200
            '
            'col_sel_codigo
            '
            Me.col_sel_codigo.DataPropertyName = "Codigo"
            Me.col_sel_codigo.HeaderText = "Codigo"
            Me.col_sel_codigo.Name = "col_sel_codigo"
            Me.col_sel_codigo.ReadOnly = True
            Me.col_sel_codigo.Visible = False
            '
            'col_sel_int_cod
            '
            Me.col_sel_int_cod.DataPropertyName = "InternoCodigo"
            Me.col_sel_int_cod.HeaderText = "Cod. Interno"
            Me.col_sel_int_cod.Name = "col_sel_int_cod"
            Me.col_sel_int_cod.ReadOnly = True
            '
            'col_sel_nom_int
            '
            Me.col_sel_nom_int.DataPropertyName = "InternoNombresCompletos"
            Me.col_sel_nom_int.HeaderText = "Apellidos y Nombres"
            Me.col_sel_nom_int.Name = "col_sel_nom_int"
            Me.col_sel_nom_int.ReadOnly = True
            Me.col_sel_nom_int.Width = 250
            '
            'col_sel_ing_nro
            '
            Me.col_sel_ing_nro.DataPropertyName = "NumeroClasificacion"
            Me.col_sel_ing_nro.HeaderText = "N° Ing."
            Me.col_sel_ing_nro.Name = "col_sel_ing_nro"
            Me.col_sel_ing_nro.ReadOnly = True
            '
            'col_sel_fec_clas
            '
            Me.col_sel_fec_clas.DataPropertyName = "FechaClasificacionDate"
            Me.col_sel_fec_clas.HeaderText = "Fecha Clasificación"
            Me.col_sel_fec_clas.Name = "col_sel_fec_clas"
            Me.col_sel_fec_clas.ReadOnly = True
            Me.col_sel_fec_clas.Width = 150
            '
            'col_sel
            '
            Me.col_sel.HeaderText = "--"
            Me.col_sel.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.col_sel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_sel.Name = "col_sel"
            Me.col_sel.ReadOnly = True
            Me.col_sel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.col_sel.Width = 20
            '
            'frmMantDocClasificacion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(937, 494)
            Me.Name = "frmMantDocClasificacion"
            Me.Text = ".::. Documento de consolidado de clasificación."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            CType(Me.dgvInternosClasificados, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtObvs As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cboEstado As APPControls.uscComboParametrica
        Friend WithEvents dtpFechaEmision As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtRegionPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents txtSerie As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cboGlosa As System.Windows.Forms.ComboBox
        Friend WithEvents txtDestinatarioDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents btnDetalle As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents dgvInternosClasificados As System.Windows.Forms.DataGridView
        Friend WithEvents col_sel_regid_dest As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel_penid_dest As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel_int_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel_nom_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel_ing_nro As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel_fec_clas As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sel As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
        Friend WithEvents col_id_class As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_penid_dest As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_cod_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_nom_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_n_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_fec_cla As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_doc_clas_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_det_int_fic_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del As System.Windows.Forms.DataGridViewImageColumn
    End Class
End Namespace