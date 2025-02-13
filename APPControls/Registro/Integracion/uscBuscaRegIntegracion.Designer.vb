Namespace Registro.Integracion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscBuscaRegIntegracion
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
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usr = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_usu_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_uni_int = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cant_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New System.Windows.Forms.TextBox()
            Me.txtCodUSR = New System.Windows.Forms.TextBox()
            Me.txtCodigoUnicoInterno = New System.Windows.Forms.TextBox()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtNom = New System.Windows.Forms.TextBox()
            Me.txtCodRp = New System.Windows.Forms.TextBox()
            Me.txtApeMat = New System.Windows.Forms.TextBox()
            Me.txtApePat = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.dgwGrillaIntegracion = New System.Windows.Forms.DataGridView()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.int_col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_cod_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_cod_rp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_doc_ide = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.int_col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.dgwGrillaIntegracion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_fec_int, Me.col_num_doc, Me.col_usr, Me.col_usu_nom, Me.col_cod_uni_int, Me.col_cant_det})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 106)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(961, 193)
            Me.dgwGrilla.TabIndex = 1
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_fec_int
            '
            Me.col_fec_int.DataPropertyName = "FechaIntegracionStr"
            Me.col_fec_int.HeaderText = "Fecha Integración"
            Me.col_fec_int.Name = "col_fec_int"
            Me.col_fec_int.ReadOnly = True
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "NumeroDocumentoStr"
            Me.col_num_doc.HeaderText = "Núm. Doc"
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            '
            'col_usr
            '
            Me.col_usr.DataPropertyName = "CodigoUsrUsuario"
            Me.col_usr.HeaderText = "Cód. Usuario"
            Me.col_usr.Name = "col_usr"
            Me.col_usr.ReadOnly = True
            '
            'col_usu_nom
            '
            Me.col_usu_nom.DataPropertyName = "NombresUsuarioCompleto"
            Me.col_usu_nom.HeaderText = "Usuario"
            Me.col_usu_nom.Name = "col_usu_nom"
            Me.col_usu_nom.ReadOnly = True
            Me.col_usu_nom.Width = 200
            '
            'col_cod_uni_int
            '
            Me.col_cod_uni_int.DataPropertyName = "CodigoUnicoInternoStr"
            Me.col_cod_uni_int.HeaderText = "Cód. único interno"
            Me.col_cod_uni_int.Name = "col_cod_uni_int"
            Me.col_cod_uni_int.ReadOnly = True
            '
            'col_cant_det
            '
            Me.col_cant_det.DataPropertyName = "TotalInternos"
            Me.col_cant_det.HeaderText = "Cant. Interno"
            Me.col_cant_det.Name = "col_cant_det"
            Me.col_cant_det.ReadOnly = True
            Me.col_cant_det.ToolTipText = "Cantidad de internos integrados"
            Me.col_cant_det.Width = 80
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
            Me.GroupBox2.Controls.Add(Me.Label18)
            Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Location = New System.Drawing.Point(591, 1)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(241, 44)
            Me.GroupBox2.TabIndex = 2
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Por fecha de integración:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaInicio.Location = New System.Drawing.Point(50, 20)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 1
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label18.Location = New System.Drawing.Point(15, 24)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(29, 13)
            Me.Label18.TabIndex = 4
            Me.Label18.Text = "Del :"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(152, 20)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 0
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.Location = New System.Drawing.Point(135, 24)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(15, 13)
            Me.Label17.TabIndex = 6
            Me.Label17.Text = "al"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(16, 18)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(93, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Núm. Documento:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(296, 18)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(112, 13)
            Me.Label2.TabIndex = 8
            Me.Label2.Text = "Código usuario (USR):"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Código Unico Interno:"
            '
            'txtNumDoc
            '
            Me.txtNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumDoc.Location = New System.Drawing.Point(123, 15)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(146, 20)
            Me.txtNumDoc.TabIndex = 0
            '
            'txtCodUSR
            '
            Me.txtCodUSR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodUSR.Location = New System.Drawing.Point(412, 15)
            Me.txtCodUSR.Name = "txtCodUSR"
            Me.txtCodUSR.Size = New System.Drawing.Size(167, 20)
            Me.txtCodUSR.TabIndex = 1
            '
            'txtCodigoUnicoInterno
            '
            Me.txtCodigoUnicoInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigoUnicoInterno.Location = New System.Drawing.Point(123, 13)
            Me.txtCodigoUnicoInterno.MaxLength = 9
            Me.txtCodigoUnicoInterno.Name = "txtCodigoUnicoInterno"
            Me.txtCodigoUnicoInterno.Size = New System.Drawing.Size(146, 20)
            Me.txtCodigoUnicoInterno.TabIndex = 2
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.txtNom)
            Me.GroupBox3.Controls.Add(Me.txtCodRp)
            Me.GroupBox3.Controls.Add(Me.txtApeMat)
            Me.GroupBox3.Controls.Add(Me.txtApePat)
            Me.GroupBox3.Controls.Add(Me.txtCodigoUnicoInterno)
            Me.GroupBox3.Controls.Add(Me.Label7)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.Label4)
            Me.GroupBox3.Controls.Add(Me.Label1)
            Me.GroupBox3.Location = New System.Drawing.Point(3, 43)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(829, 58)
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Interno"
            '
            'txtNom
            '
            Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNom.Location = New System.Drawing.Point(585, 35)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(236, 20)
            Me.txtNom.TabIndex = 6
            '
            'txtCodRp
            '
            Me.txtCodRp.Location = New System.Drawing.Point(373, 13)
            Me.txtCodRp.Name = "txtCodRp"
            Me.txtCodRp.Size = New System.Drawing.Size(145, 20)
            Me.txtCodRp.TabIndex = 3
            '
            'txtApeMat
            '
            Me.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApeMat.Location = New System.Drawing.Point(373, 35)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(145, 20)
            Me.txtApeMat.TabIndex = 5
            '
            'txtApePat
            '
            Me.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApePat.Location = New System.Drawing.Point(123, 35)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(145, 20)
            Me.txtApePat.TabIndex = 4
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(283, 16)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(86, 13)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "Cod. Interno RP:"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(530, 40)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(52, 13)
            Me.Label6.TabIndex = 8
            Me.Label6.Text = "Nombres:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(280, 39)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(88, 13)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Apellido materno:"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 38)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(86, 13)
            Me.Label4.TabIndex = 8
            Me.Label4.Text = "Apellido paterno:"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtNumDoc)
            Me.GroupBox4.Controls.Add(Me.txtCodUSR)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Location = New System.Drawing.Point(3, 1)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(585, 43)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(961, 106)
            Me.Panel1.TabIndex = 2
            '
            'dgwGrillaIntegracion
            '
            Me.dgwGrillaIntegracion.AllowUserToAddRows = False
            Me.dgwGrillaIntegracion.AllowUserToDeleteRows = False
            Me.dgwGrillaIntegracion.AllowUserToResizeRows = False
            Me.dgwGrillaIntegracion.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaIntegracion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaIntegracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaIntegracion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.int_col_cod, Me.int_col_int_id, Me.int_col_cod_uni, Me.int_col_cod_rp, Me.int_col_doc_ide, Me.int_col_ape_pat, Me.int_col_ape_mat, Me.int_col_nom, Me.int_col_pen_nom, Me.col_del, Me.int_col_pen_id, Me.int_col_reg_id})
            Me.dgwGrillaIntegracion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaIntegracion.GridColor = System.Drawing.Color.White
            Me.dgwGrillaIntegracion.Location = New System.Drawing.Point(0, 23)
            Me.dgwGrillaIntegracion.MultiSelect = False
            Me.dgwGrillaIntegracion.Name = "dgwGrillaIntegracion"
            Me.dgwGrillaIntegracion.ReadOnly = True
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrillaIntegracion.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaIntegracion.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaIntegracion.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrillaIntegracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaIntegracion.Size = New System.Drawing.Size(961, 130)
            Me.dgwGrillaIntegracion.TabIndex = 3
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Gainsboro
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(961, 23)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Detalle de integración de registro de internos."
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.dgwGrillaIntegracion)
            Me.Panel2.Controls.Add(Me.Label8)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 299)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(961, 153)
            Me.Panel2.TabIndex = 5
            '
            'int_col_cod
            '
            Me.int_col_cod.DataPropertyName = "Codigo"
            Me.int_col_cod.HeaderText = "Codigo"
            Me.int_col_cod.Name = "int_col_cod"
            Me.int_col_cod.ReadOnly = True
            Me.int_col_cod.Visible = False
            Me.int_col_cod.Width = 30
            '
            'int_col_int_id
            '
            Me.int_col_int_id.DataPropertyName = "InternoId"
            Me.int_col_int_id.HeaderText = "InternoId"
            Me.int_col_int_id.Name = "int_col_int_id"
            Me.int_col_int_id.ReadOnly = True
            Me.int_col_int_id.Visible = False
            Me.int_col_int_id.Width = 30
            '
            'int_col_cod_uni
            '
            Me.int_col_cod_uni.DataPropertyName = "CodigoUnicoInterno"
            Me.int_col_cod_uni.HeaderText = "Cód. único"
            Me.int_col_cod_uni.Name = "int_col_cod_uni"
            Me.int_col_cod_uni.ReadOnly = True
            Me.int_col_cod_uni.ToolTipText = "Código unico de identificación del interno"
            Me.int_col_cod_uni.Width = 70
            '
            'int_col_cod_rp
            '
            Me.int_col_cod_rp.DataPropertyName = "CodigoRP"
            Me.int_col_cod_rp.HeaderText = "Cod. RP."
            Me.int_col_cod_rp.Name = "int_col_cod_rp"
            Me.int_col_cod_rp.ReadOnly = True
            '
            'int_col_doc_ide
            '
            Me.int_col_doc_ide.DataPropertyName = "IntTipoNumDocIdent"
            Me.int_col_doc_ide.HeaderText = "Doc. Identidad"
            Me.int_col_doc_ide.Name = "int_col_doc_ide"
            Me.int_col_doc_ide.ReadOnly = True
            Me.int_col_doc_ide.Width = 150
            '
            'int_col_ape_pat
            '
            Me.int_col_ape_pat.DataPropertyName = "ApePaternoInterno"
            Me.int_col_ape_pat.HeaderText = "Ape. Paterno"
            Me.int_col_ape_pat.Name = "int_col_ape_pat"
            Me.int_col_ape_pat.ReadOnly = True
            Me.int_col_ape_pat.Width = 120
            '
            'int_col_ape_mat
            '
            Me.int_col_ape_mat.DataPropertyName = "ApeMaternoInterno"
            Me.int_col_ape_mat.HeaderText = "Ape. Materno"
            Me.int_col_ape_mat.Name = "int_col_ape_mat"
            Me.int_col_ape_mat.ReadOnly = True
            Me.int_col_ape_mat.Width = 120
            '
            'int_col_nom
            '
            Me.int_col_nom.DataPropertyName = "NombresInterno"
            Me.int_col_nom.HeaderText = "Nombres"
            Me.int_col_nom.Name = "int_col_nom"
            Me.int_col_nom.ReadOnly = True
            Me.int_col_nom.Width = 130
            '
            'int_col_pen_nom
            '
            Me.int_col_pen_nom.DataPropertyName = "IntPenalStr"
            Me.int_col_pen_nom.HeaderText = "Penal"
            Me.int_col_pen_nom.Name = "int_col_pen_nom"
            Me.int_col_pen_nom.ReadOnly = True
            Me.int_col_pen_nom.Width = 180
            '
            'col_del
            '
            Me.col_del.DataPropertyName = "Eliminado"
            Me.col_del.HeaderText = "Eliminado"
            Me.col_del.Name = "col_del"
            Me.col_del.ReadOnly = True
            Me.col_del.Visible = False
            '
            'int_col_pen_id
            '
            Me.int_col_pen_id.DataPropertyName = "InternoPenalId"
            Me.int_col_pen_id.HeaderText = "InternoPenalId"
            Me.int_col_pen_id.Name = "int_col_pen_id"
            Me.int_col_pen_id.ReadOnly = True
            Me.int_col_pen_id.Visible = False
            '
            'int_col_reg_id
            '
            Me.int_col_reg_id.DataPropertyName = "InternoRegionId"
            Me.int_col_reg_id.HeaderText = "InternoRegionId"
            Me.int_col_reg_id.Name = "int_col_reg_id"
            Me.int_col_reg_id.ReadOnly = True
            Me.int_col_reg_id.Visible = False
            '
            'uscBuscaRegIntegracion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "uscBuscaRegIntegracion"
            Me.Size = New System.Drawing.Size(961, 452)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            CType(Me.dgwGrillaIntegracion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents txtCodigoUnicoInterno As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
        Friend WithEvents txtCodUSR As System.Windows.Forms.TextBox
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_usr As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_usu_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod_uni_int As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cant_det As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNom As System.Windows.Forms.TextBox
        Friend WithEvents txtCodRp As System.Windows.Forms.TextBox
        Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
        Friend WithEvents txtApePat As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents dgwGrillaIntegracion As System.Windows.Forms.DataGridView
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents int_col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_cod_uni As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_cod_rp As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_doc_ide As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_ape_pat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_ape_mat As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_del As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents int_col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace