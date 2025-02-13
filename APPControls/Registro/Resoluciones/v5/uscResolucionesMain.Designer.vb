Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscResolucionesMain
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscResolucionesMain))
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.gbRadioButon = New System.Windows.Forms.GroupBox()
            Me.rdbAclarados = New System.Windows.Forms.RadioButton()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbIngreso = New System.Windows.Forms.RadioButton()
            Me.rdbSentencia = New System.Windows.Forms.RadioButton()
            Me.rdbEgreso = New System.Windows.Forms.RadioButton()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnVerDetalleExp = New System.Windows.Forms.Button()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.pnlAnular = New System.Windows.Forms.Panel()
            Me.btnInactivar = New System.Windows.Forms.Button()
            Me.pnlEli = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_doc_recep = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_sub_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_doc_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_exp_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sala = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dist_aut = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_secre_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_vers = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_anu_id = New System.Windows.Forms.DataGridViewImageColumn()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PnlBotones.SuspendLayout()
            Me.gbRadioButon.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlAnular.SuspendLayout()
            Me.pnlEli.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_codigo, Me.col_fec_doc_recep, Me.col_doc_tip, Me.col_doc_sub_tip, Me.col_tip_doc_nom, Me.col_num_doc, Me.col_exp_num, Me.col_sala, Me.col_dist_aut, Me.col_secre_nom, Me.col_observacion, Me.col_estado, Me.col_doc_vers, Me.col_anu_id})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwGrilla.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 45)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwGrilla.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(797, 249)
            Me.dgwGrilla.TabIndex = 8
            Me.ttMensaje.SetToolTip(Me.dgwGrilla, "Estado de anulación")
            Me.dgwGrilla.VisibleCampos = False
            '
            'PnlBotones
            '
            Me.PnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PnlBotones.Controls.Add(Me.gbRadioButon)
            Me.PnlBotones.Controls.Add(Me.Panel3)
            Me.PnlBotones.Controls.Add(Me.pnlGrabar)
            Me.PnlBotones.Controls.Add(Me.pnlAnular)
            Me.PnlBotones.Controls.Add(Me.pnlEli)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlBotones.Location = New System.Drawing.Point(0, 0)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(797, 45)
            Me.PnlBotones.TabIndex = 9
            '
            'gbRadioButon
            '
            Me.gbRadioButon.Controls.Add(Me.rdbAclarados)
            Me.gbRadioButon.Controls.Add(Me.rdbTodos)
            Me.gbRadioButon.Controls.Add(Me.rdbIngreso)
            Me.gbRadioButon.Controls.Add(Me.rdbSentencia)
            Me.gbRadioButon.Controls.Add(Me.rdbEgreso)
            Me.gbRadioButon.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbRadioButon.Location = New System.Drawing.Point(41, 0)
            Me.gbRadioButon.Name = "gbRadioButon"
            Me.gbRadioButon.Size = New System.Drawing.Size(338, 43)
            Me.gbRadioButon.TabIndex = 94
            Me.gbRadioButon.TabStop = False
            '
            'rdbAclarados
            '
            Me.rdbAclarados.AutoSize = True
            Me.rdbAclarados.Location = New System.Drawing.Point(213, 14)
            Me.rdbAclarados.Name = "rdbAclarados"
            Me.rdbAclarados.Size = New System.Drawing.Size(72, 17)
            Me.rdbAclarados.TabIndex = 5
            Me.rdbAclarados.Text = "Aclarados"
            Me.rdbAclarados.UseVisualStyleBackColor = True
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(290, 14)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 4
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbIngreso
            '
            Me.rdbIngreso.AutoSize = True
            Me.rdbIngreso.Location = New System.Drawing.Point(6, 14)
            Me.rdbIngreso.Name = "rdbIngreso"
            Me.rdbIngreso.Size = New System.Drawing.Size(60, 17)
            Me.rdbIngreso.TabIndex = 1
            Me.rdbIngreso.Text = "Ingreso"
            Me.rdbIngreso.UseVisualStyleBackColor = True
            '
            'rdbSentencia
            '
            Me.rdbSentencia.AutoSize = True
            Me.rdbSentencia.Location = New System.Drawing.Point(132, 14)
            Me.rdbSentencia.Name = "rdbSentencia"
            Me.rdbSentencia.Size = New System.Drawing.Size(78, 17)
            Me.rdbSentencia.TabIndex = 3
            Me.rdbSentencia.Text = "Sentencias"
            Me.rdbSentencia.UseVisualStyleBackColor = True
            '
            'rdbEgreso
            '
            Me.rdbEgreso.AutoSize = True
            Me.rdbEgreso.Location = New System.Drawing.Point(70, 14)
            Me.rdbEgreso.Name = "rdbEgreso"
            Me.rdbEgreso.Size = New System.Drawing.Size(58, 17)
            Me.rdbEgreso.TabIndex = 2
            Me.rdbEgreso.Text = "Egreso"
            Me.rdbEgreso.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnVerDetalleExp)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(41, 43)
            Me.Panel3.TabIndex = 95
            '
            'btnVerDetalleExp
            '
            Me.btnVerDetalleExp.Image = Global.APPControls.My.Resources.Resources.detalle_32x32
            Me.btnVerDetalleExp.Location = New System.Drawing.Point(1, 2)
            Me.btnVerDetalleExp.Name = "btnVerDetalleExp"
            Me.btnVerDetalleExp.Size = New System.Drawing.Size(38, 40)
            Me.btnVerDetalleExp.TabIndex = 91
            Me.ttMensaje.SetToolTip(Me.btnVerDetalleExp, "Ver lista de expedientes")
            Me.btnVerDetalleExp.UseVisualStyleBackColor = True
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnNuevo)
            Me.pnlGrabar.Controls.Add(Me.btnModificar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(379, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(210, 43)
            Me.pnlGrabar.TabIndex = 89
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnNuevo.Location = New System.Drawing.Point(3, 1)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(102, 40)
            Me.btnNuevo.TabIndex = 89
            Me.btnNuevo.Text = "Agregar Documento"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificar.Location = New System.Drawing.Point(107, 1)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(100, 40)
            Me.btnModificar.TabIndex = 88
            Me.btnModificar.Text = "Modificar"
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlAnular
            '
            Me.pnlAnular.Controls.Add(Me.btnInactivar)
            Me.pnlAnular.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAnular.Location = New System.Drawing.Point(589, 0)
            Me.pnlAnular.Name = "pnlAnular"
            Me.pnlAnular.Size = New System.Drawing.Size(101, 43)
            Me.pnlAnular.TabIndex = 92
            Me.pnlAnular.Visible = False
            '
            'btnInactivar
            '
            Me.btnInactivar.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnInactivar.Location = New System.Drawing.Point(1, 1)
            Me.btnInactivar.Name = "btnInactivar"
            Me.btnInactivar.Size = New System.Drawing.Size(100, 40)
            Me.btnInactivar.TabIndex = 90
            Me.btnInactivar.Text = "Anular"
            Me.btnInactivar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnInactivar.UseVisualStyleBackColor = True
            '
            'pnlEli
            '
            Me.pnlEli.Controls.Add(Me.btnEliminar)
            Me.pnlEli.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEli.Location = New System.Drawing.Point(690, 0)
            Me.pnlEli.Name = "pnlEli"
            Me.pnlEli.Size = New System.Drawing.Size(105, 43)
            Me.pnlEli.TabIndex = 90
            '
            'btnEliminar
            '
            Me.btnEliminar.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(1, 1)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(100, 40)
            Me.btnEliminar.TabIndex = 91
            Me.btnEliminar.Text = "Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.PictureBox3)
            Me.Panel1.Controls.Add(Me.PictureBox2)
            Me.Panel1.Controls.Add(Me.PictureBox1)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.lblReg)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 294)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(797, 22)
            Me.Panel1.TabIndex = 10
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(714, 5)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(53, 13)
            Me.Label3.TabIndex = 66
            Me.Label3.Text = "Anulado"
            '
            'PictureBox3
            '
            Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(569, 1)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox3.TabIndex = 70
            Me.PictureBox3.TabStop = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(690, 0)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox2.TabIndex = 69
            Me.PictureBox2.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(771, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 68
            Me.PictureBox1.TabStop = False
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(591, 4)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 13)
            Me.Label4.TabIndex = 67
            Me.Label4.Text = "Anulado Parcial"
            '
            'Label2
            '
            Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(519, 4)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 13)
            Me.Label2.TabIndex = 63
            Me.Label2.Text = "Normal"
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(426, 4)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(63, 13)
            Me.Label1.TabIndex = 61
            Me.Label1.Text = "Leyenda :"
            '
            'lblReg
            '
            Me.lblReg.AutoSize = True
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(6, 5)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(45, 13)
            Me.lblReg.TabIndex = 60
            Me.lblReg.Text = "0 Reg."
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.DividerWidth = 1
            Me.col_codigo.HeaderText = "DocJudId"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            Me.col_codigo.Width = 70
            '
            'col_fec_doc_recep
            '
            Me.col_fec_doc_recep.DataPropertyName = "DocumentoFechaRecepcion"
            DataGridViewCellStyle2.Format = "d"
            Me.col_fec_doc_recep.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fec_doc_recep.HeaderText = "Fecha"
            Me.col_fec_doc_recep.Name = "col_fec_doc_recep"
            Me.col_fec_doc_recep.ReadOnly = True
            Me.col_fec_doc_recep.Width = 66
            '
            'col_doc_tip
            '
            Me.col_doc_tip.DataPropertyName = "DocumentoTipo"
            Me.col_doc_tip.DividerWidth = 1
            Me.col_doc_tip.HeaderText = "DocJudTipo"
            Me.col_doc_tip.Name = "col_doc_tip"
            Me.col_doc_tip.ReadOnly = True
            Me.col_doc_tip.Visible = False
            '
            'col_doc_sub_tip
            '
            Me.col_doc_sub_tip.DataPropertyName = "DocumentoSubTipoId"
            Me.col_doc_sub_tip.DividerWidth = 1
            Me.col_doc_sub_tip.HeaderText = "DocSubTipo"
            Me.col_doc_sub_tip.Name = "col_doc_sub_tip"
            Me.col_doc_sub_tip.ReadOnly = True
            Me.col_doc_sub_tip.Visible = False
            '
            'col_tip_doc_nom
            '
            Me.col_tip_doc_nom.DataPropertyName = "DocumentoTipoNombre2"
            Me.col_tip_doc_nom.HeaderText = "Tipo Documento"
            Me.col_tip_doc_nom.Name = "col_tip_doc_nom"
            Me.col_tip_doc_nom.ReadOnly = True
            Me.col_tip_doc_nom.Width = 150
            '
            'col_num_doc
            '
            Me.col_num_doc.DataPropertyName = "DocumentoNumeroReadOnly"
            Me.col_num_doc.HeaderText = "N° Doc."
            Me.col_num_doc.Name = "col_num_doc"
            Me.col_num_doc.ReadOnly = True
            Me.col_num_doc.Width = 140
            '
            'col_exp_num
            '
            Me.col_exp_num.DataPropertyName = "NumeroExpediente"
            Me.col_exp_num.HeaderText = "N° Exp."
            Me.col_exp_num.Name = "col_exp_num"
            Me.col_exp_num.ReadOnly = True
            Me.col_exp_num.Width = 120
            '
            'col_sala
            '
            Me.col_sala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_sala.DataPropertyName = "SalaJudNombre"
            Me.col_sala.HeaderText = "Aut. Judicial"
            Me.col_sala.MinimumWidth = 40
            Me.col_sala.Name = "col_sala"
            Me.col_sala.ReadOnly = True
            Me.col_sala.Width = 170
            '
            'col_dist_aut
            '
            Me.col_dist_aut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.col_dist_aut.DataPropertyName = "DistritoJudNombre"
            Me.col_dist_aut.HeaderText = "Distrito Judicial"
            Me.col_dist_aut.Name = "col_dist_aut"
            Me.col_dist_aut.ReadOnly = True
            Me.col_dist_aut.Width = 120
            '
            'col_secre_nom
            '
            Me.col_secre_nom.DataPropertyName = "SecretarioNombre"
            Me.col_secre_nom.HeaderText = "Secretario"
            Me.col_secre_nom.MinimumWidth = 40
            Me.col_secre_nom.Name = "col_secre_nom"
            Me.col_secre_nom.ReadOnly = True
            '
            'col_observacion
            '
            Me.col_observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_observacion.DataPropertyName = "Detalle"
            Me.col_observacion.HeaderText = "Detalle"
            Me.col_observacion.Name = "col_observacion"
            Me.col_observacion.ReadOnly = True
            '
            'col_estado
            '
            Me.col_estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_estado.DataPropertyName = "EstadoNombre"
            Me.col_estado.HeaderText = "Estado"
            Me.col_estado.MinimumWidth = 40
            Me.col_estado.Name = "col_estado"
            Me.col_estado.ReadOnly = True
            Me.col_estado.Visible = False
            '
            'col_doc_vers
            '
            Me.col_doc_vers.DataPropertyName = "_Version"
            Me.col_doc_vers.HeaderText = "Version"
            Me.col_doc_vers.Name = "col_doc_vers"
            Me.col_doc_vers.ReadOnly = True
            Me.col_doc_vers.Visible = False
            '
            'col_anu_id
            '
            Me.col_anu_id.DataPropertyName = "EstadoImage"
            Me.col_anu_id.HeaderText = "Anul."
            Me.col_anu_id.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_anu_id.Name = "col_anu_id"
            Me.col_anu_id.ReadOnly = True
            Me.col_anu_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.col_anu_id.Width = 30
            '
            'uscResolucionesMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.PnlBotones)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "uscResolucionesMain"
            Me.Size = New System.Drawing.Size(797, 316)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PnlBotones.ResumeLayout(False)
            Me.gbRadioButon.ResumeLayout(False)
            Me.gbRadioButon.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlAnular.ResumeLayout(False)
            Me.pnlEli.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        'Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnInactivar As System.Windows.Forms.Button
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents pnlEli As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents btnVerDetalleExp As System.Windows.Forms.Button
        Friend WithEvents ttMensaje As System.Windows.Forms.ToolTip
        Friend WithEvents gbRadioButon As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIngreso As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSentencia As System.Windows.Forms.RadioButton
        Friend WithEvents rdbEgreso As System.Windows.Forms.RadioButton
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlAnular As System.Windows.Forms.Panel
        Friend WithEvents rdbAclarados As System.Windows.Forms.RadioButton
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents col_codigo As DataGridViewTextBoxColumn
        Friend WithEvents col_fec_doc_recep As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_tip As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_sub_tip As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_doc_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_num_doc As DataGridViewTextBoxColumn
        Friend WithEvents col_exp_num As DataGridViewTextBoxColumn
        Friend WithEvents col_sala As DataGridViewTextBoxColumn
        Friend WithEvents col_dist_aut As DataGridViewTextBoxColumn
        Friend WithEvents col_secre_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_observacion As DataGridViewTextBoxColumn
        Friend WithEvents col_estado As DataGridViewTextBoxColumn
        Friend WithEvents col_doc_vers As DataGridViewTextBoxColumn
        Friend WithEvents col_anu_id As DataGridViewImageColumn
    End Class
End Namespace