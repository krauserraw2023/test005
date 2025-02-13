Namespace Registro.Captura
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscFotografia_LM
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.pbIzquierdo = New System.Windows.Forms.PictureBox()
            Me.pbDerecho = New System.Windows.Forms.PictureBox()
            Me.pbFrente = New System.Windows.Forms.PictureBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgwFotos = New Legolas.APPUIComponents.myDatagridView()
            Me.col_fec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing_img = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_fot_per_fre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_fot_per_der = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.int_fot_per_izq = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAccionFotografia = New System.Windows.Forms.Panel()
            Me.pnlFotografiaEli = New System.Windows.Forms.Panel()
            Me.btnEliminarFoto = New System.Windows.Forms.Button()
            Me.pnlFotografiaAdd = New System.Windows.Forms.Panel()
            Me.btnModificarFoto = New System.Windows.Forms.Button()
            Me.btnAgregarFot = New System.Windows.Forms.Button()
            Me.dgwGrillaRasgo = New System.Windows.Forms.DataGridView()
            Me.col_num_ingre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ras_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_raza = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cabell_forma = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cabell_color = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_calvicie = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_menton = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_frente = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cara_form = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_linea_inser = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_form_ojos = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_iris = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cejas = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_anomal_ojos = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_orej = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_nariz_form = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.tip_nariz = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_boca = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_labio = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tip_lab = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tronco = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_complex = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_talla = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_rasgo_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.grbSenhasparticulares = New System.Windows.Forms.GroupBox()
            Me.dgwGrillaSeniaPart = New System.Windows.Forms.DataGridView()
            Me.col_pen_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_nro_inpe = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlAccionSenaParti = New System.Windows.Forms.Panel()
            Me.pnlSenaPartiEli = New System.Windows.Forms.Panel()
            Me.btnEliSenaParti = New System.Windows.Forms.Button()
            Me.pnlSenaPartiAdd = New System.Windows.Forms.Panel()
            Me.btnModSeñas = New System.Windows.Forms.Button()
            Me.btnAddSeñas = New System.Windows.Forms.Button()
            Me.grbRasgos = New System.Windows.Forms.GroupBox()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.pnlAccionRasgo = New System.Windows.Forms.Panel()
            Me.pnlRasgosEli = New System.Windows.Forms.Panel()
            Me.btnEliminarRasgo = New System.Windows.Forms.Button()
            Me.pnlRagosAdd = New System.Windows.Forms.Panel()
            Me.btnModRasgo = New System.Windows.Forms.Button()
            Me.btnAddRasgo = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.lblError1 = New System.Windows.Forms.Label()
            Me.lblError2 = New System.Windows.Forms.Label()
            Me.lblError3 = New System.Windows.Forms.Label()
            Me.Panel2.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.pbIzquierdo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbDerecho, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pbFrente, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwFotos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAccionFotografia.SuspendLayout()
            Me.pnlFotografiaEli.SuspendLayout()
            Me.pnlFotografiaAdd.SuspendLayout()
            CType(Me.dgwGrillaRasgo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grbSenhasparticulares.SuspendLayout()
            CType(Me.dgwGrillaSeniaPart, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlAccionSenaParti.SuspendLayout()
            Me.pnlSenaPartiEli.SuspendLayout()
            Me.pnlSenaPartiAdd.SuspendLayout()
            Me.grbRasgos.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.pnlAccionRasgo.SuspendLayout()
            Me.pnlRasgosEli.SuspendLayout()
            Me.pnlRagosAdd.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.GroupBox2)
            Me.Panel2.Controls.Add(Me.GroupBox1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(930, 272)
            Me.Panel2.TabIndex = 7
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblError3)
            Me.GroupBox2.Controls.Add(Me.lblError2)
            Me.GroupBox2.Controls.Add(Me.lblError1)
            Me.GroupBox2.Controls.Add(Me.pbIzquierdo)
            Me.GroupBox2.Controls.Add(Me.pbDerecho)
            Me.GroupBox2.Controls.Add(Me.pbFrente)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(685, 272)
            Me.GroupBox2.TabIndex = 95
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Fotografia"
            '
            'pbIzquierdo
            '
            Me.pbIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.pbIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbIzquierdo.Image = Global.APPControls.My.Resources.Resources.sin_fotografia
            Me.pbIzquierdo.Location = New System.Drawing.Point(6, 21)
            Me.pbIzquierdo.Name = "pbIzquierdo"
            Me.pbIzquierdo.Size = New System.Drawing.Size(203, 250)
            Me.pbIzquierdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbIzquierdo.TabIndex = 3
            Me.pbIzquierdo.TabStop = False
            Me.ToolTip1.SetToolTip(Me.pbIzquierdo, "Presione doble click sobre la imagen para ver a mayor detalle")
            '
            'pbDerecho
            '
            Me.pbDerecho.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.pbDerecho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbDerecho.Image = Global.APPControls.My.Resources.Resources.sin_fotografia
            Me.pbDerecho.Location = New System.Drawing.Point(476, 21)
            Me.pbDerecho.Name = "pbDerecho"
            Me.pbDerecho.Size = New System.Drawing.Size(203, 250)
            Me.pbDerecho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbDerecho.TabIndex = 5
            Me.pbDerecho.TabStop = False
            Me.ToolTip1.SetToolTip(Me.pbDerecho, "Presione doble click sobre la imagen para ver a mayor detalle")
            '
            'pbFrente
            '
            Me.pbFrente.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.pbFrente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pbFrente.Image = Global.APPControls.My.Resources.Resources.sin_fotografia
            Me.pbFrente.Location = New System.Drawing.Point(239, 21)
            Me.pbFrente.Name = "pbFrente"
            Me.pbFrente.Size = New System.Drawing.Size(203, 250)
            Me.pbFrente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbFrente.TabIndex = 4
            Me.pbFrente.TabStop = False
            Me.ToolTip1.SetToolTip(Me.pbFrente, "Presione doble click sobre la imagen para ver a mayor detalle")
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(6, 5)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(203, 17)
            Me.Label1.TabIndex = 92
            Me.Label1.Text = "Perfil Izquierdo"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(239, 5)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(203, 17)
            Me.Label2.TabIndex = 93
            Me.Label2.Text = "Perfil Frontal"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(476, 5)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(203, 17)
            Me.Label3.TabIndex = 94
            Me.Label3.Text = "Perfil Derecho"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgwFotos)
            Me.GroupBox1.Controls.Add(Me.pnlAccionFotografia)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.GroupBox1.Location = New System.Drawing.Point(685, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(245, 272)
            Me.GroupBox1.TabIndex = 8
            Me.GroupBox1.TabStop = False
            '
            'dgwFotos
            '
            Me.dgwFotos.AllowUserToAddRows = False
            Me.dgwFotos.AllowUserToDeleteRows = False
            Me.dgwFotos.AllowUserToResizeRows = False
            Me.dgwFotos.BackgroundColor = System.Drawing.Color.White
            Me.dgwFotos.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwFotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwFotos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fec, Me.col_codigo, Me.col_num_ing_img, Me.col_fec_reg, Me.int_fot_per_fre, Me.int_fot_per_der, Me.int_fot_per_izq})
            Me.dgwFotos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwFotos.Location = New System.Drawing.Point(3, 16)
            Me.dgwFotos.MultiSelect = False
            Me.dgwFotos.Name = "dgwFotos"
            Me.dgwFotos.ReadOnly = True
            Me.dgwFotos.RowHeadersVisible = False
            Me.dgwFotos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwFotos.Size = New System.Drawing.Size(239, 219)
            Me.dgwFotos.TabIndex = 1
            Me.dgwFotos.VisibleCampos = False
            '
            'col_fec
            '
            Me.col_fec.DataPropertyName = "Fecha"
            Me.col_fec.HeaderText = "Fecha"
            Me.col_fec.Name = "col_fec"
            Me.col_fec.ReadOnly = True
            Me.col_fec.Visible = False
            '
            'col_codigo
            '
            Me.col_codigo.DataPropertyName = "Codigo"
            Me.col_codigo.HeaderText = "Codigo"
            Me.col_codigo.Name = "col_codigo"
            Me.col_codigo.ReadOnly = True
            Me.col_codigo.Visible = False
            '
            'col_num_ing_img
            '
            Me.col_num_ing_img.DataPropertyName = "NumIngreso"
            Me.col_num_ing_img.HeaderText = "Nº Ing."
            Me.col_num_ing_img.Name = "col_num_ing_img"
            Me.col_num_ing_img.ReadOnly = True
            Me.col_num_ing_img.Visible = False
            Me.col_num_ing_img.Width = 65
            '
            'col_fec_reg
            '
            Me.col_fec_reg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_fec_reg.DataPropertyName = "FechaHoraString"
            Me.col_fec_reg.HeaderText = "Fecha Reg."
            Me.col_fec_reg.Name = "col_fec_reg"
            Me.col_fec_reg.ReadOnly = True
            '
            'int_fot_per_fre
            '
            Me.int_fot_per_fre.DataPropertyName = "PFrenteID"
            Me.int_fot_per_fre.HeaderText = "PFrenteID"
            Me.int_fot_per_fre.Name = "int_fot_per_fre"
            Me.int_fot_per_fre.ReadOnly = True
            Me.int_fot_per_fre.Visible = False
            '
            'int_fot_per_der
            '
            Me.int_fot_per_der.DataPropertyName = "PDerechoID"
            Me.int_fot_per_der.HeaderText = "pDerechoID"
            Me.int_fot_per_der.Name = "int_fot_per_der"
            Me.int_fot_per_der.ReadOnly = True
            Me.int_fot_per_der.Visible = False
            '
            'int_fot_per_izq
            '
            Me.int_fot_per_izq.DataPropertyName = "PIzquierdoID"
            Me.int_fot_per_izq.HeaderText = "PIzquierodoID"
            Me.int_fot_per_izq.Name = "int_fot_per_izq"
            Me.int_fot_per_izq.ReadOnly = True
            Me.int_fot_per_izq.Visible = False
            '
            'pnlAccionFotografia
            '
            Me.pnlAccionFotografia.Controls.Add(Me.pnlFotografiaEli)
            Me.pnlAccionFotografia.Controls.Add(Me.pnlFotografiaAdd)
            Me.pnlAccionFotografia.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlAccionFotografia.Location = New System.Drawing.Point(3, 235)
            Me.pnlAccionFotografia.Name = "pnlAccionFotografia"
            Me.pnlAccionFotografia.Size = New System.Drawing.Size(239, 34)
            Me.pnlAccionFotografia.TabIndex = 0
            '
            'pnlFotografiaEli
            '
            Me.pnlFotografiaEli.Controls.Add(Me.btnEliminarFoto)
            Me.pnlFotografiaEli.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotografiaEli.Location = New System.Drawing.Point(64, 0)
            Me.pnlFotografiaEli.Name = "pnlFotografiaEli"
            Me.pnlFotografiaEli.Size = New System.Drawing.Size(35, 34)
            Me.pnlFotografiaEli.TabIndex = 1
            Me.pnlFotografiaEli.Visible = False
            '
            'btnEliminarFoto
            '
            Me.btnEliminarFoto.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminarFoto.Location = New System.Drawing.Point(1, 5)
            Me.btnEliminarFoto.Name = "btnEliminarFoto"
            Me.btnEliminarFoto.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarFoto.TabIndex = 2
            Me.btnEliminarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnEliminarFoto, "Eliminar fotos")
            Me.btnEliminarFoto.UseVisualStyleBackColor = True
            '
            'pnlFotografiaAdd
            '
            Me.pnlFotografiaAdd.Controls.Add(Me.btnModificarFoto)
            Me.pnlFotografiaAdd.Controls.Add(Me.btnAgregarFot)
            Me.pnlFotografiaAdd.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotografiaAdd.Location = New System.Drawing.Point(0, 0)
            Me.pnlFotografiaAdd.Name = "pnlFotografiaAdd"
            Me.pnlFotografiaAdd.Size = New System.Drawing.Size(64, 34)
            Me.pnlFotografiaAdd.TabIndex = 1
            Me.pnlFotografiaAdd.Visible = False
            '
            'btnModificarFoto
            '
            Me.btnModificarFoto.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModificarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModificarFoto.Location = New System.Drawing.Point(33, 5)
            Me.btnModificarFoto.Name = "btnModificarFoto"
            Me.btnModificarFoto.Size = New System.Drawing.Size(30, 26)
            Me.btnModificarFoto.TabIndex = 11
            Me.ToolTip1.SetToolTip(Me.btnModificarFoto, "Modifica agraviado seleccionado.")
            Me.btnModificarFoto.UseVisualStyleBackColor = True
            '
            'btnAgregarFot
            '
            Me.btnAgregarFot.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregarFot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregarFot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAgregarFot.Location = New System.Drawing.Point(3, 5)
            Me.btnAgregarFot.Name = "btnAgregarFot"
            Me.btnAgregarFot.Size = New System.Drawing.Size(30, 26)
            Me.btnAgregarFot.TabIndex = 0
            Me.btnAgregarFot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnAgregarFot, "Agregar Fotos")
            Me.btnAgregarFot.UseVisualStyleBackColor = True
            '
            'dgwGrillaRasgo
            '
            Me.dgwGrillaRasgo.AllowUserToAddRows = False
            Me.dgwGrillaRasgo.AllowUserToDeleteRows = False
            Me.dgwGrillaRasgo.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaRasgo.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaRasgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaRasgo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num_ingre, Me.col_ras_ing_nro_inpe, Me.col_cod, Me.col_raza, Me.col_cabell_forma, Me.col_cabell_color, Me.col_calvicie, Me.col_menton, Me.col_frente, Me.col_cara_form, Me.col_linea_inser, Me.col_form_ojos, Me.col_iris, Me.col_cejas, Me.col_anomal_ojos, Me.col_orej, Me.col_nariz_form, Me.tip_nariz, Me.col_boca, Me.col_labio, Me.col_tip_lab, Me.col_tronco, Me.col_complex, Me.col_talla, Me.col_peso, Me.col_rasgo_pen_id})
            Me.dgwGrillaRasgo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaRasgo.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaRasgo.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrillaRasgo.MultiSelect = False
            Me.dgwGrillaRasgo.Name = "dgwGrillaRasgo"
            Me.dgwGrillaRasgo.ReadOnly = True
            Me.dgwGrillaRasgo.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaRasgo.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaRasgo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaRasgo.Size = New System.Drawing.Size(418, 227)
            Me.dgwGrillaRasgo.TabIndex = 89
            '
            'col_num_ingre
            '
            Me.col_num_ingre.DataPropertyName = "NumIngreso"
            Me.col_num_ingre.HeaderText = "Nº Ing."
            Me.col_num_ingre.Name = "col_num_ingre"
            Me.col_num_ingre.ReadOnly = True
            Me.col_num_ingre.Width = 35
            '
            'col_ras_ing_nro_inpe
            '
            Me.col_ras_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ras_ing_nro_inpe.HeaderText = "N° Ing."
            Me.col_ras_ing_nro_inpe.Name = "col_ras_ing_nro_inpe"
            Me.col_ras_ing_nro_inpe.ReadOnly = True
            Me.col_ras_ing_nro_inpe.Width = 50
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "IdRas"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            '
            'col_raza
            '
            Me.col_raza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_raza.DataPropertyName = "Raza_Nom"
            Me.col_raza.HeaderText = "Raza"
            Me.col_raza.MinimumWidth = 40
            Me.col_raza.Name = "col_raza"
            Me.col_raza.ReadOnly = True
            Me.col_raza.Width = 40
            '
            'col_cabell_forma
            '
            Me.col_cabell_forma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_cabell_forma.DataPropertyName = "CabelloForma_Nom"
            Me.col_cabell_forma.HeaderText = "Cabello Forma"
            Me.col_cabell_forma.MinimumWidth = 50
            Me.col_cabell_forma.Name = "col_cabell_forma"
            Me.col_cabell_forma.ReadOnly = True
            Me.col_cabell_forma.Width = 50
            '
            'col_cabell_color
            '
            Me.col_cabell_color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_cabell_color.DataPropertyName = "CabelloColor_Nom"
            Me.col_cabell_color.HeaderText = "Cabello color"
            Me.col_cabell_color.MinimumWidth = 50
            Me.col_cabell_color.Name = "col_cabell_color"
            Me.col_cabell_color.ReadOnly = True
            Me.col_cabell_color.Width = 50
            '
            'col_calvicie
            '
            Me.col_calvicie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_calvicie.DataPropertyName = "Calvicie_Nom"
            Me.col_calvicie.HeaderText = "Calvicie"
            Me.col_calvicie.MinimumWidth = 50
            Me.col_calvicie.Name = "col_calvicie"
            Me.col_calvicie.ReadOnly = True
            Me.col_calvicie.Width = 50
            '
            'col_menton
            '
            Me.col_menton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_menton.DataPropertyName = "Menton_Nom"
            Me.col_menton.HeaderText = "Mentón"
            Me.col_menton.MinimumWidth = 50
            Me.col_menton.Name = "col_menton"
            Me.col_menton.ReadOnly = True
            Me.col_menton.Width = 50
            '
            'col_frente
            '
            Me.col_frente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_frente.DataPropertyName = "Frente_Nom"
            Me.col_frente.HeaderText = "Frente"
            Me.col_frente.MinimumWidth = 50
            Me.col_frente.Name = "col_frente"
            Me.col_frente.ReadOnly = True
            Me.col_frente.Width = 50
            '
            'col_cara_form
            '
            Me.col_cara_form.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_cara_form.DataPropertyName = "CaraForma_Nom"
            Me.col_cara_form.HeaderText = "Cara For."
            Me.col_cara_form.MinimumWidth = 40
            Me.col_cara_form.Name = "col_cara_form"
            Me.col_cara_form.ReadOnly = True
            Me.col_cara_form.Width = 40
            '
            'col_linea_inser
            '
            Me.col_linea_inser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_linea_inser.DataPropertyName = "LineaInsercion_Nom"
            Me.col_linea_inser.HeaderText = "Linea Inser."
            Me.col_linea_inser.MinimumWidth = 40
            Me.col_linea_inser.Name = "col_linea_inser"
            Me.col_linea_inser.ReadOnly = True
            Me.col_linea_inser.Width = 40
            '
            'col_form_ojos
            '
            Me.col_form_ojos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_form_ojos.DataPropertyName = "FormaOjo_Nom"
            Me.col_form_ojos.HeaderText = "Forma Ojos"
            Me.col_form_ojos.MinimumWidth = 50
            Me.col_form_ojos.Name = "col_form_ojos"
            Me.col_form_ojos.ReadOnly = True
            Me.col_form_ojos.Width = 50
            '
            'col_iris
            '
            Me.col_iris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_iris.DataPropertyName = "Iris_Nom"
            Me.col_iris.HeaderText = "Iris"
            Me.col_iris.MinimumWidth = 40
            Me.col_iris.Name = "col_iris"
            Me.col_iris.ReadOnly = True
            Me.col_iris.Width = 40
            '
            'col_cejas
            '
            Me.col_cejas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_cejas.DataPropertyName = "Cejas_Nom"
            Me.col_cejas.HeaderText = "Cejas"
            Me.col_cejas.MinimumWidth = 40
            Me.col_cejas.Name = "col_cejas"
            Me.col_cejas.ReadOnly = True
            Me.col_cejas.Width = 40
            '
            'col_anomal_ojos
            '
            Me.col_anomal_ojos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_anomal_ojos.DataPropertyName = "AnomaliaOjo_Nom"
            Me.col_anomal_ojos.HeaderText = "Anomalia Ojos"
            Me.col_anomal_ojos.MinimumWidth = 50
            Me.col_anomal_ojos.Name = "col_anomal_ojos"
            Me.col_anomal_ojos.ReadOnly = True
            Me.col_anomal_ojos.Width = 50
            '
            'col_orej
            '
            Me.col_orej.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_orej.DataPropertyName = "Oreja_Nom"
            Me.col_orej.HeaderText = "Oreja"
            Me.col_orej.MinimumWidth = 40
            Me.col_orej.Name = "col_orej"
            Me.col_orej.ReadOnly = True
            Me.col_orej.Width = 40
            '
            'col_nariz_form
            '
            Me.col_nariz_form.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_nariz_form.DataPropertyName = "NarizForma_Nom"
            Me.col_nariz_form.HeaderText = "Nariz forma"
            Me.col_nariz_form.MinimumWidth = 40
            Me.col_nariz_form.Name = "col_nariz_form"
            Me.col_nariz_form.ReadOnly = True
            Me.col_nariz_form.Width = 40
            '
            'tip_nariz
            '
            Me.tip_nariz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.tip_nariz.DataPropertyName = "TipoNariz_Nom"
            Me.tip_nariz.HeaderText = "Tipo nariz"
            Me.tip_nariz.MinimumWidth = 40
            Me.tip_nariz.Name = "tip_nariz"
            Me.tip_nariz.ReadOnly = True
            Me.tip_nariz.Width = 40
            '
            'col_boca
            '
            Me.col_boca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_boca.DataPropertyName = "Boca_Nom"
            Me.col_boca.HeaderText = "Boca"
            Me.col_boca.MinimumWidth = 40
            Me.col_boca.Name = "col_boca"
            Me.col_boca.ReadOnly = True
            Me.col_boca.Width = 40
            '
            'col_labio
            '
            Me.col_labio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_labio.DataPropertyName = "Labio_Nom"
            Me.col_labio.HeaderText = "Labios"
            Me.col_labio.MinimumWidth = 40
            Me.col_labio.Name = "col_labio"
            Me.col_labio.ReadOnly = True
            Me.col_labio.Width = 40
            '
            'col_tip_lab
            '
            Me.col_tip_lab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_tip_lab.DataPropertyName = "TipoLabio_Nom"
            Me.col_tip_lab.HeaderText = "Tipo labios"
            Me.col_tip_lab.MinimumWidth = 40
            Me.col_tip_lab.Name = "col_tip_lab"
            Me.col_tip_lab.ReadOnly = True
            Me.col_tip_lab.Width = 40
            '
            'col_tronco
            '
            Me.col_tronco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_tronco.DataPropertyName = "Tronco_Nom"
            Me.col_tronco.HeaderText = "Tronco"
            Me.col_tronco.MinimumWidth = 40
            Me.col_tronco.Name = "col_tronco"
            Me.col_tronco.ReadOnly = True
            Me.col_tronco.Width = 40
            '
            'col_complex
            '
            Me.col_complex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            Me.col_complex.DataPropertyName = "Complexion_Nom"
            Me.col_complex.HeaderText = "Complexión"
            Me.col_complex.MinimumWidth = 40
            Me.col_complex.Name = "col_complex"
            Me.col_complex.ReadOnly = True
            Me.col_complex.Width = 40
            '
            'col_talla
            '
            Me.col_talla.DataPropertyName = "Talla"
            Me.col_talla.HeaderText = "Talla (m.)"
            Me.col_talla.Name = "col_talla"
            Me.col_talla.ReadOnly = True
            Me.col_talla.Width = 35
            '
            'col_peso
            '
            Me.col_peso.DataPropertyName = "Peso"
            Me.col_peso.HeaderText = "Peso (Kg.)"
            Me.col_peso.Name = "col_peso"
            Me.col_peso.ReadOnly = True
            Me.col_peso.Width = 35
            '
            'col_rasgo_pen_id
            '
            Me.col_rasgo_pen_id.DataPropertyName = "PenalId"
            Me.col_rasgo_pen_id.DividerWidth = 1
            Me.col_rasgo_pen_id.HeaderText = "PenalId"
            Me.col_rasgo_pen_id.Name = "col_rasgo_pen_id"
            Me.col_rasgo_pen_id.ReadOnly = True
            Me.col_rasgo_pen_id.Visible = False
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'grbSenhasparticulares
            '
            Me.grbSenhasparticulares.Controls.Add(Me.dgwGrillaSeniaPart)
            Me.grbSenhasparticulares.Controls.Add(Me.pnlAccionSenaParti)
            Me.grbSenhasparticulares.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbSenhasparticulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbSenhasparticulares.Location = New System.Drawing.Point(468, 3)
            Me.grbSenhasparticulares.Name = "grbSenhasparticulares"
            Me.grbSenhasparticulares.Size = New System.Drawing.Size(459, 246)
            Me.grbSenhasparticulares.TabIndex = 1
            Me.grbSenhasparticulares.TabStop = False
            Me.grbSenhasparticulares.Text = "Señas Particulares"
            '
            'dgwGrillaSeniaPart
            '
            Me.dgwGrillaSeniaPart.AllowUserToAddRows = False
            Me.dgwGrillaSeniaPart.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaSeniaPart.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaSeniaPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaSeniaPart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pen_id, Me.col_num_ing, Me.col_ing_nro_inpe, Me.col_id, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column7})
            Me.dgwGrillaSeniaPart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaSeniaPart.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaSeniaPart.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrillaSeniaPart.MultiSelect = False
            Me.dgwGrillaSeniaPart.Name = "dgwGrillaSeniaPart"
            Me.dgwGrillaSeniaPart.ReadOnly = True
            Me.dgwGrillaSeniaPart.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaSeniaPart.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrillaSeniaPart.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dgwGrillaSeniaPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaSeniaPart.Size = New System.Drawing.Size(418, 227)
            Me.dgwGrillaSeniaPart.TabIndex = 4
            '
            'col_pen_id
            '
            Me.col_pen_id.DataPropertyName = "PenalId"
            Me.col_pen_id.HeaderText = "PenalId"
            Me.col_pen_id.Name = "col_pen_id"
            Me.col_pen_id.ReadOnly = True
            Me.col_pen_id.Visible = False
            '
            'col_num_ing
            '
            Me.col_num_ing.DataPropertyName = "NumIngreso"
            Me.col_num_ing.HeaderText = "Nº Ing."
            Me.col_num_ing.Name = "col_num_ing"
            Me.col_num_ing.ReadOnly = True
            Me.col_num_ing.Width = 45
            '
            'col_ing_nro_inpe
            '
            Me.col_ing_nro_inpe.DataPropertyName = "IngresoNroInpe"
            Me.col_ing_nro_inpe.HeaderText = "N° Ing."
            Me.col_ing_nro_inpe.Name = "col_ing_nro_inpe"
            Me.col_ing_nro_inpe.ReadOnly = True
            Me.col_ing_nro_inpe.Width = 50
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "CodigoID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "NaturalezaNombre"
            Me.Column1.HeaderText = "Por Naturaleza"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 80
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "FormaNombre"
            Me.Column2.HeaderText = "Forma"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 80
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "UbicacionNombre"
            Me.Column3.HeaderText = "Ubicacion"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 80
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "PosicionNombre"
            Me.Column6.HeaderText = "Posicion"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 80
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "Cantidad"
            Me.Column7.HeaderText = "Cant."
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.ToolTipText = "Cantidad"
            Me.Column7.Width = 35
            '
            'pnlAccionSenaParti
            '
            Me.pnlAccionSenaParti.Controls.Add(Me.pnlSenaPartiEli)
            Me.pnlAccionSenaParti.Controls.Add(Me.pnlSenaPartiAdd)
            Me.pnlAccionSenaParti.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAccionSenaParti.Location = New System.Drawing.Point(421, 16)
            Me.pnlAccionSenaParti.Name = "pnlAccionSenaParti"
            Me.pnlAccionSenaParti.Size = New System.Drawing.Size(35, 227)
            Me.pnlAccionSenaParti.TabIndex = 88
            '
            'pnlSenaPartiEli
            '
            Me.pnlSenaPartiEli.Controls.Add(Me.btnEliSenaParti)
            Me.pnlSenaPartiEli.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSenaPartiEli.Location = New System.Drawing.Point(0, 54)
            Me.pnlSenaPartiEli.Name = "pnlSenaPartiEli"
            Me.pnlSenaPartiEli.Size = New System.Drawing.Size(35, 27)
            Me.pnlSenaPartiEli.TabIndex = 93
            '
            'btnEliSenaParti
            '
            Me.btnEliSenaParti.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliSenaParti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliSenaParti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliSenaParti.Location = New System.Drawing.Point(1, 1)
            Me.btnEliSenaParti.Name = "btnEliSenaParti"
            Me.btnEliSenaParti.Size = New System.Drawing.Size(30, 26)
            Me.btnEliSenaParti.TabIndex = 90
            Me.btnEliSenaParti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSenaPartiAdd
            '
            Me.pnlSenaPartiAdd.Controls.Add(Me.btnModSeñas)
            Me.pnlSenaPartiAdd.Controls.Add(Me.btnAddSeñas)
            Me.pnlSenaPartiAdd.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSenaPartiAdd.Location = New System.Drawing.Point(0, 0)
            Me.pnlSenaPartiAdd.Name = "pnlSenaPartiAdd"
            Me.pnlSenaPartiAdd.Size = New System.Drawing.Size(35, 54)
            Me.pnlSenaPartiAdd.TabIndex = 92
            '
            'btnModSeñas
            '
            Me.btnModSeñas.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModSeñas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModSeñas.Location = New System.Drawing.Point(0, 27)
            Me.btnModSeñas.Name = "btnModSeñas"
            Me.btnModSeñas.Size = New System.Drawing.Size(30, 26)
            Me.btnModSeñas.TabIndex = 11
            Me.ToolTip1.SetToolTip(Me.btnModSeñas, "Modifica agraviado seleccionado.")
            Me.btnModSeñas.UseVisualStyleBackColor = True
            '
            'btnAddSeñas
            '
            Me.btnAddSeñas.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddSeñas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddSeñas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddSeñas.Location = New System.Drawing.Point(0, 1)
            Me.btnAddSeñas.Name = "btnAddSeñas"
            Me.btnAddSeñas.Size = New System.Drawing.Size(30, 26)
            Me.btnAddSeñas.TabIndex = 87
            Me.btnAddSeñas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbRasgos
            '
            Me.grbRasgos.Controls.Add(Me.Panel4)
            Me.grbRasgos.Controls.Add(Me.pnlAccionRasgo)
            Me.grbRasgos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbRasgos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbRasgos.Location = New System.Drawing.Point(3, 3)
            Me.grbRasgos.Name = "grbRasgos"
            Me.grbRasgos.Size = New System.Drawing.Size(459, 246)
            Me.grbRasgos.TabIndex = 0
            Me.grbRasgos.TabStop = False
            Me.grbRasgos.Text = "Rasgos"
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.dgwGrillaRasgo)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel4.Location = New System.Drawing.Point(3, 16)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(418, 227)
            Me.Panel4.TabIndex = 90
            '
            'pnlAccionRasgo
            '
            Me.pnlAccionRasgo.Controls.Add(Me.pnlRasgosEli)
            Me.pnlAccionRasgo.Controls.Add(Me.pnlRagosAdd)
            Me.pnlAccionRasgo.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAccionRasgo.Location = New System.Drawing.Point(421, 16)
            Me.pnlAccionRasgo.Name = "pnlAccionRasgo"
            Me.pnlAccionRasgo.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
            Me.pnlAccionRasgo.Size = New System.Drawing.Size(35, 227)
            Me.pnlAccionRasgo.TabIndex = 91
            '
            'pnlRasgosEli
            '
            Me.pnlRasgosEli.Controls.Add(Me.btnEliminarRasgo)
            Me.pnlRasgosEli.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRasgosEli.Location = New System.Drawing.Point(3, 55)
            Me.pnlRasgosEli.Name = "pnlRasgosEli"
            Me.pnlRasgosEli.Size = New System.Drawing.Size(32, 37)
            Me.pnlRasgosEli.TabIndex = 91
            '
            'btnEliminarRasgo
            '
            Me.btnEliminarRasgo.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnEliminarRasgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEliminarRasgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminarRasgo.Location = New System.Drawing.Point(0, 2)
            Me.btnEliminarRasgo.Name = "btnEliminarRasgo"
            Me.btnEliminarRasgo.Size = New System.Drawing.Size(30, 26)
            Me.btnEliminarRasgo.TabIndex = 89
            Me.btnEliminarRasgo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlRagosAdd
            '
            Me.pnlRagosAdd.Controls.Add(Me.btnModRasgo)
            Me.pnlRagosAdd.Controls.Add(Me.btnAddRasgo)
            Me.pnlRagosAdd.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRagosAdd.Location = New System.Drawing.Point(3, 0)
            Me.pnlRagosAdd.Name = "pnlRagosAdd"
            Me.pnlRagosAdd.Size = New System.Drawing.Size(32, 55)
            Me.pnlRagosAdd.TabIndex = 90
            '
            'btnModRasgo
            '
            Me.btnModRasgo.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnModRasgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnModRasgo.Location = New System.Drawing.Point(0, 28)
            Me.btnModRasgo.Name = "btnModRasgo"
            Me.btnModRasgo.Size = New System.Drawing.Size(30, 26)
            Me.btnModRasgo.TabIndex = 11
            Me.ToolTip1.SetToolTip(Me.btnModRasgo, "Modifica agraviado seleccionado.")
            Me.btnModRasgo.UseVisualStyleBackColor = True
            '
            'btnAddRasgo
            '
            Me.btnAddRasgo.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddRasgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddRasgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddRasgo.Location = New System.Drawing.Point(0, 1)
            Me.btnAddRasgo.Name = "btnAddRasgo"
            Me.btnAddRasgo.Size = New System.Drawing.Size(30, 26)
            Me.btnAddRasgo.TabIndex = 88
            Me.btnAddRasgo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.grbRasgos, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.grbSenhasparticulares, 1, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 272)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(930, 252)
            Me.TableLayoutPanel1.TabIndex = 10
            '
            'lblError1
            '
            Me.lblError1.AutoSize = True
            Me.lblError1.Location = New System.Drawing.Point(6, 256)
            Me.lblError1.Name = "lblError1"
            Me.lblError1.Size = New System.Drawing.Size(0, 13)
            Me.lblError1.TabIndex = 95
            '
            'lblError2
            '
            Me.lblError2.AutoSize = True
            Me.lblError2.Location = New System.Drawing.Point(239, 255)
            Me.lblError2.Name = "lblError2"
            Me.lblError2.Size = New System.Drawing.Size(0, 13)
            Me.lblError2.TabIndex = 96
            '
            'lblError3
            '
            Me.lblError3.AutoSize = True
            Me.lblError3.Location = New System.Drawing.Point(479, 256)
            Me.lblError3.Name = "lblError3"
            Me.lblError3.Size = New System.Drawing.Size(0, 13)
            Me.lblError3.TabIndex = 97
            '
            'uscFotografia_LM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "uscFotografia_LM"
            Me.Size = New System.Drawing.Size(930, 524)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.pbIzquierdo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbDerecho, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pbFrente, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwFotos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAccionFotografia.ResumeLayout(False)
            Me.pnlFotografiaEli.ResumeLayout(False)
            Me.pnlFotografiaAdd.ResumeLayout(False)
            CType(Me.dgwGrillaRasgo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grbSenhasparticulares.ResumeLayout(False)
            CType(Me.dgwGrillaSeniaPart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlAccionSenaParti.ResumeLayout(False)
            Me.pnlSenaPartiEli.ResumeLayout(False)
            Me.pnlSenaPartiAdd.ResumeLayout(False)
            Me.grbRasgos.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.pnlAccionRasgo.ResumeLayout(False)
            Me.pnlRasgosEli.ResumeLayout(False)
            Me.pnlRagosAdd.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pbDerecho As System.Windows.Forms.PictureBox
        Friend WithEvents pbFrente As System.Windows.Forms.PictureBox
        Friend WithEvents pbIzquierdo As System.Windows.Forms.PictureBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents grbRasgos As System.Windows.Forms.GroupBox
        Friend WithEvents grbSenhasparticulares As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrillaSeniaPart As System.Windows.Forms.DataGridView
        Friend WithEvents btnAddSeñas As System.Windows.Forms.Button
        Friend WithEvents pnlAccionSenaParti As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents dgwGrillaRasgo As System.Windows.Forms.DataGridView
        Friend WithEvents btnAddRasgo As System.Windows.Forms.Button
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents pnlAccionRasgo As System.Windows.Forms.Panel
        Friend WithEvents pnlAccionFotografia As System.Windows.Forms.Panel
        Friend WithEvents btnEliminarFoto As System.Windows.Forms.Button
        Friend WithEvents btnAgregarFot As System.Windows.Forms.Button
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnEliSenaParti As System.Windows.Forms.Button
        Friend WithEvents btnEliminarRasgo As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlFotografiaAdd As System.Windows.Forms.Panel
        Friend WithEvents pnlRasgosEli As System.Windows.Forms.Panel
        Friend WithEvents pnlRagosAdd As System.Windows.Forms.Panel
        Friend WithEvents pnlSenaPartiEli As System.Windows.Forms.Panel
        Friend WithEvents pnlSenaPartiAdd As System.Windows.Forms.Panel
        Friend WithEvents dgwFotos As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents pnlFotografiaEli As System.Windows.Forms.Panel
        Friend WithEvents btnModificarFoto As System.Windows.Forms.Button
        Friend WithEvents btnModRasgo As System.Windows.Forms.Button
        Friend WithEvents btnModSeñas As System.Windows.Forms.Button
        Friend WithEvents col_fec As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_codigo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing_img As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_reg As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_fot_per_fre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_fot_per_der As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents int_fot_per_izq As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ing_nro_inpe As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_ingre As DataGridViewTextBoxColumn
        Friend WithEvents col_ras_ing_nro_inpe As DataGridViewTextBoxColumn
        Friend WithEvents col_cod As DataGridViewTextBoxColumn
        Friend WithEvents col_raza As DataGridViewTextBoxColumn
        Friend WithEvents col_cabell_forma As DataGridViewTextBoxColumn
        Friend WithEvents col_cabell_color As DataGridViewTextBoxColumn
        Friend WithEvents col_calvicie As DataGridViewTextBoxColumn
        Friend WithEvents col_menton As DataGridViewTextBoxColumn
        Friend WithEvents col_frente As DataGridViewTextBoxColumn
        Friend WithEvents col_cara_form As DataGridViewTextBoxColumn
        Friend WithEvents col_linea_inser As DataGridViewTextBoxColumn
        Friend WithEvents col_form_ojos As DataGridViewTextBoxColumn
        Friend WithEvents col_iris As DataGridViewTextBoxColumn
        Friend WithEvents col_cejas As DataGridViewTextBoxColumn
        Friend WithEvents col_anomal_ojos As DataGridViewTextBoxColumn
        Friend WithEvents col_orej As DataGridViewTextBoxColumn
        Friend WithEvents col_nariz_form As DataGridViewTextBoxColumn
        Friend WithEvents tip_nariz As DataGridViewTextBoxColumn
        Friend WithEvents col_boca As DataGridViewTextBoxColumn
        Friend WithEvents col_labio As DataGridViewTextBoxColumn
        Friend WithEvents col_tip_lab As DataGridViewTextBoxColumn
        Friend WithEvents col_tronco As DataGridViewTextBoxColumn
        Friend WithEvents col_complex As DataGridViewTextBoxColumn
        Friend WithEvents col_talla As DataGridViewTextBoxColumn
        Friend WithEvents col_peso As DataGridViewTextBoxColumn
        Friend WithEvents col_rasgo_pen_id As DataGridViewTextBoxColumn
        Friend WithEvents lblError1 As Label
        Friend WithEvents lblError3 As Label
        Friend WithEvents lblError2 As Label
    End Class
End Namespace

