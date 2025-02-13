Namespace Registro.Main.Carceleta
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscaReniecPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaReniecPopup))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnRegNuevo = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtNumDoc = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.rbNombres = New System.Windows.Forms.RadioButton()
            Me.rbDNI = New System.Windows.Forms.RadioButton()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.txtNom = New System.Windows.Forms.TextBox()
            Me.txtApeMat = New System.Windows.Forms.TextBox()
            Me.txtApePat = New System.Windows.Forms.TextBox()
            Me.Label29 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.lblFechaemision = New System.Windows.Forms.Label()
            Me.lblFechaInscripcion = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtTalla = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtRestriccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtPadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label43 = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.txtMadre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtEstadoCivil = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.Label44 = New System.Windows.Forms.Label()
            Me.txtGradoInstruccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label38 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtApellidoCasada = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox12 = New System.Windows.Forms.GroupBox()
            Me.txtUbigeo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtUbigeoDireccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.grpNacimientoReniec = New System.Windows.Forms.GroupBox()
            Me.txtUbigeoNacimiento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label46 = New System.Windows.Forms.Label()
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.Label53 = New System.Windows.Forms.Label()
            Me.txtDigitoVeri = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gradInsRNCId = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.dgwGrillaListaReniec = New Legolas.APPUIComponents.myDatagridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_num_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dig_ver = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_mostrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnDetalleRnc = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox12.SuspendLayout()
            Me.grpNacimientoReniec.SuspendLayout()
            Me.Panel4.SuspendLayout()
            CType(Me.dgwGrillaListaReniec, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel6.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(1000, 532)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnRegNuevo)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 484)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1000, 48)
            Me.Panel1.TabIndex = 53
            '
            'btnRegNuevo
            '
            Me.btnRegNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnRegNuevo.Image = Global.SIPPOPE.My.Resources.Resources.id_card_view
            Me.btnRegNuevo.Location = New System.Drawing.Point(662, 0)
            Me.btnRegNuevo.Name = "btnRegNuevo"
            Me.btnRegNuevo.Size = New System.Drawing.Size(128, 47)
            Me.btnRegNuevo.TabIndex = 106
            Me.btnRegNuevo.Text = "Registrar manualmente"
            Me.btnRegNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnRegNuevo, "Permite registrar manualmente un nuevo interno sin tomar datos de la reniec.")
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(895, 0)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 47)
            Me.btnCancel.TabIndex = 105
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(790, 0)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(105, 47)
            Me.btnAceptar.TabIndex = 104
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.ToolTip1.SetToolTip(Me.btnAceptar, "Registrar interno a partir de los datos obtenidos por la reniec.")
            '
            'PictureBox1
            '
            Me.PictureBox1.Image = Global.SIPPOPE.My.Resources.Resources.reniec_peru
            Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(229, 111)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 54
            Me.PictureBox1.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.btnLimpiar)
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.rbNombres)
            Me.GroupBox1.Controls.Add(Me.rbDNI)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(233, 1)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(765, 114)
            Me.GroupBox1.TabIndex = 55
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Validar por ..."
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtNumDoc)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(94, 6)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(527, 34)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            '
            'txtNumDoc
            '
            Me.txtNumDoc.Location = New System.Drawing.Point(94, 11)
            Me.txtNumDoc.MaxLength = 8
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(184, 20)
            Me.txtNumDoc.TabIndex = 49
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(6, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(89, 13)
            Me.Label2.TabIndex = 48
            Me.Label2.Text = "Número de doc. :"
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.SIPPOPE.My.Resources.Resources.replace2
            Me.btnLimpiar.Location = New System.Drawing.Point(699, 37)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(60, 55)
            Me.btnLimpiar.TabIndex = 56
            Me.btnLimpiar.Text = "Limpiar"
            Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.Image = Global.SIPPOPE.My.Resources.Resources.logo_reniec
            Me.btnBuscar.Location = New System.Drawing.Point(637, 37)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(60, 55)
            Me.btnBuscar.TabIndex = 55
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'rbNombres
            '
            Me.rbNombres.BackColor = System.Drawing.Color.WhiteSmoke
            Me.rbNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbNombres.Location = New System.Drawing.Point(7, 43)
            Me.rbNombres.Name = "rbNombres"
            Me.rbNombres.Size = New System.Drawing.Size(83, 21)
            Me.rbNombres.TabIndex = 3
            Me.rbNombres.Text = "Nombres"
            Me.rbNombres.UseVisualStyleBackColor = False
            '
            'rbDNI
            '
            Me.rbDNI.BackColor = System.Drawing.Color.WhiteSmoke
            Me.rbDNI.Checked = True
            Me.rbDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbDNI.Location = New System.Drawing.Point(7, 18)
            Me.rbDNI.Name = "rbDNI"
            Me.rbDNI.Size = New System.Drawing.Size(83, 21)
            Me.rbDNI.TabIndex = 2
            Me.rbDNI.TabStop = True
            Me.rbDNI.Text = "DNI"
            Me.rbDNI.UseVisualStyleBackColor = False
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.txtNom)
            Me.GroupBox3.Controls.Add(Me.txtApeMat)
            Me.GroupBox3.Controls.Add(Me.txtApePat)
            Me.GroupBox3.Controls.Add(Me.Label29)
            Me.GroupBox3.Controls.Add(Me.Label27)
            Me.GroupBox3.Controls.Add(Me.Label28)
            Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(94, 30)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(527, 81)
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            '
            'txtNom
            '
            Me.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNom.Enabled = False
            Me.txtNom.Location = New System.Drawing.Point(93, 57)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(427, 20)
            Me.txtNom.TabIndex = 36
            '
            'txtApeMat
            '
            Me.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApeMat.Enabled = False
            Me.txtApeMat.Location = New System.Drawing.Point(93, 34)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(427, 20)
            Me.txtApeMat.TabIndex = 35
            '
            'txtApePat
            '
            Me.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApePat.Enabled = False
            Me.txtApePat.Location = New System.Drawing.Point(93, 12)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(427, 20)
            Me.txtApePat.TabIndex = 34
            '
            'Label29
            '
            Me.Label29.AutoSize = True
            Me.Label29.Location = New System.Drawing.Point(10, 18)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(72, 13)
            Me.Label29.TabIndex = 28
            Me.Label29.Text = "Primer Apellido:"
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(27, 61)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(55, 13)
            Me.Label27.TabIndex = 30
            Me.Label27.Text = "Nombres :"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(8, 39)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(74, 13)
            Me.Label28.TabIndex = 29
            Me.Label28.Text = "Segundo Ape.:"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.PictureBox1)
            Me.Panel2.Controls.Add(Me.GroupBox1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1000, 117)
            Me.Panel2.TabIndex = 56
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Panel5)
            Me.Panel3.Controls.Add(Me.Label3)
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 117)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(1000, 367)
            Me.Panel3.TabIndex = 57
            '
            'Panel5
            '
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel5.Controls.Add(Me.GroupBox9)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(488, 20)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(512, 347)
            Me.Panel5.TabIndex = 5
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.lblFechaemision)
            Me.GroupBox9.Controls.Add(Me.lblFechaInscripcion)
            Me.GroupBox9.Controls.Add(Me.Label8)
            Me.GroupBox9.Controls.Add(Me.Label7)
            Me.GroupBox9.Controls.Add(Me.txtTalla)
            Me.GroupBox9.Controls.Add(Me.Label6)
            Me.GroupBox9.Controls.Add(Me.txtRestriccion)
            Me.GroupBox9.Controls.Add(Me.Label5)
            Me.GroupBox9.Controls.Add(Me.txtPadre)
            Me.GroupBox9.Controls.Add(Me.Label43)
            Me.GroupBox9.Controls.Add(Me.Label37)
            Me.GroupBox9.Controls.Add(Me.txtMadre)
            Me.GroupBox9.Controls.Add(Me.txtEstadoCivil)
            Me.GroupBox9.Controls.Add(Me.pnlFotoVis)
            Me.GroupBox9.Controls.Add(Me.Label44)
            Me.GroupBox9.Controls.Add(Me.txtGradoInstruccion)
            Me.GroupBox9.Controls.Add(Me.Label4)
            Me.GroupBox9.Controls.Add(Me.Label38)
            Me.GroupBox9.Controls.Add(Me.Label9)
            Me.GroupBox9.Controls.Add(Me.txtApellidoCasada)
            Me.GroupBox9.Controls.Add(Me.txtFechaNac)
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.GroupBox12)
            Me.GroupBox9.Controls.Add(Me.grpNacimientoReniec)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtPrimerApellido)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.Label50)
            Me.GroupBox9.Controls.Add(Me.txtPrenombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtSegundoApellido)
            Me.GroupBox9.Controls.Add(Me.Label52)
            Me.GroupBox9.Controls.Add(Me.Label53)
            Me.GroupBox9.Controls.Add(Me.txtDigitoVeri)
            Me.GroupBox9.Controls.Add(Me.txtDni)
            Me.GroupBox9.Controls.Add(Me.gradInsRNCId)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox9.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(508, 343)
            Me.GroupBox9.TabIndex = 1
            Me.GroupBox9.TabStop = False
            '
            'lblFechaemision
            '
            Me.lblFechaemision.AutoSize = True
            Me.lblFechaemision.Location = New System.Drawing.Point(105, 32)
            Me.lblFechaemision.Name = "lblFechaemision"
            Me.lblFechaemision.Size = New System.Drawing.Size(10, 13)
            Me.lblFechaemision.TabIndex = 7
            Me.lblFechaemision.Text = "-"
            '
            'lblFechaInscripcion
            '
            Me.lblFechaInscripcion.AutoSize = True
            Me.lblFechaInscripcion.Location = New System.Drawing.Point(105, 16)
            Me.lblFechaInscripcion.Name = "lblFechaInscripcion"
            Me.lblFechaInscripcion.Size = New System.Drawing.Size(10, 13)
            Me.lblFechaInscripcion.TabIndex = 1
            Me.lblFechaInscripcion.Text = "-"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(7, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(96, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "Fecha inscripción :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(7, 32)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(82, 13)
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "Fecha Emisión :"
            '
            'txtTalla
            '
            Me.txtTalla._BloquearPaste = False
            Me.txtTalla._SeleccionarTodo = False
            Me.txtTalla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTalla.Location = New System.Drawing.Point(191, 320)
            Me.txtTalla.Name = "txtTalla"
            Me.txtTalla.ReadOnly = True
            Me.txtTalla.Size = New System.Drawing.Size(28, 20)
            Me.txtTalla.TabIndex = 31
            Me.txtTalla.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTalla.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(219, 323)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(18, 12)
            Me.Label6.TabIndex = 32
            Me.Label6.Text = "cm"
            '
            'txtRestriccion
            '
            Me.txtRestriccion._BloquearPaste = False
            Me.txtRestriccion._SeleccionarTodo = False
            Me.txtRestriccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRestriccion.Location = New System.Drawing.Point(62, 318)
            Me.txtRestriccion.Name = "txtRestriccion"
            Me.txtRestriccion.ReadOnly = True
            Me.txtRestriccion.Size = New System.Drawing.Size(91, 20)
            Me.txtRestriccion.TabIndex = 29
            Me.txtRestriccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRestriccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(4, 323)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(60, 13)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Restricción"
            '
            'txtPadre
            '
            Me.txtPadre._BloquearPaste = False
            Me.txtPadre._SeleccionarTodo = False
            Me.txtPadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPadre.Location = New System.Drawing.Point(317, 277)
            Me.txtPadre.Name = "txtPadre"
            Me.txtPadre.ReadOnly = True
            Me.txtPadre.Size = New System.Drawing.Size(433, 20)
            Me.txtPadre.TabIndex = 25
            Me.txtPadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label43
            '
            Me.Label43.AutoSize = True
            Me.Label43.Location = New System.Drawing.Point(244, 282)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(41, 13)
            Me.Label43.TabIndex = 24
            Me.Label43.Text = "Padre :"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Location = New System.Drawing.Point(154, 324)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(36, 13)
            Me.Label37.TabIndex = 30
            Me.Label37.Text = "Talla :"
            '
            'txtMadre
            '
            Me.txtMadre._BloquearPaste = False
            Me.txtMadre._SeleccionarTodo = False
            Me.txtMadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtMadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtMadre.Location = New System.Drawing.Point(317, 299)
            Me.txtMadre.Name = "txtMadre"
            Me.txtMadre.ReadOnly = True
            Me.txtMadre.Size = New System.Drawing.Size(433, 20)
            Me.txtMadre.TabIndex = 27
            Me.txtMadre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMadre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtEstadoCivil
            '
            Me.txtEstadoCivil._BloquearPaste = True
            Me.txtEstadoCivil._SeleccionarTodo = False
            Me.txtEstadoCivil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtEstadoCivil.Location = New System.Drawing.Point(317, 255)
            Me.txtEstadoCivil.Name = "txtEstadoCivil"
            Me.txtEstadoCivil.ReadOnly = True
            Me.txtEstadoCivil.Size = New System.Drawing.Size(433, 20)
            Me.txtEstadoCivil.TabIndex = 23
            Me.txtEstadoCivil.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstadoCivil.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlFotoVis.Controls.Add(Me.picFoto)
            Me.pnlFotoVis.Location = New System.Drawing.Point(4, 47)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(212, 269)
            Me.pnlFotoVis.TabIndex = 35
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.PaleGoldenrod
            Me.picFoto.BackgroundImage = CType(resources.GetObject("picFoto.BackgroundImage"), System.Drawing.Image)
            Me.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picFoto.Location = New System.Drawing.Point(0, 0)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(210, 267)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'Label44
            '
            Me.Label44.AutoSize = True
            Me.Label44.Location = New System.Drawing.Point(244, 304)
            Me.Label44.Name = "Label44"
            Me.Label44.Size = New System.Drawing.Size(43, 13)
            Me.Label44.TabIndex = 26
            Me.Label44.Text = "Madre :"
            '
            'txtGradoInstruccion
            '
            Me.txtGradoInstruccion._BloquearPaste = False
            Me.txtGradoInstruccion._SeleccionarTodo = False
            Me.txtGradoInstruccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtGradoInstruccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtGradoInstruccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtGradoInstruccion.Location = New System.Drawing.Point(317, 321)
            Me.txtGradoInstruccion.Name = "txtGradoInstruccion"
            Me.txtGradoInstruccion.ReadOnly = True
            Me.txtGradoInstruccion.Size = New System.Drawing.Size(433, 18)
            Me.txtGradoInstruccion.TabIndex = 34
            Me.txtGradoInstruccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGradoInstruccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(461, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(14, 18)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "-"
            '
            'Label38
            '
            Me.Label38.AutoSize = True
            Me.Label38.Location = New System.Drawing.Point(244, 324)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(59, 13)
            Me.Label38.TabIndex = 33
            Me.Label38.Text = "Grado Inst."
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(218, 86)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(98, 13)
            Me.Label9.TabIndex = 12
            Me.Label9.Text = "Apellido Casado(a):"
            '
            'txtApellidoCasada
            '
            Me.txtApellidoCasada._BloquearPaste = True
            Me.txtApellidoCasada._SeleccionarTodo = False
            Me.txtApellidoCasada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtApellidoCasada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApellidoCasada.Location = New System.Drawing.Point(317, 83)
            Me.txtApellidoCasada.Name = "txtApellidoCasada"
            Me.txtApellidoCasada.ReadOnly = True
            Me.txtApellidoCasada.Size = New System.Drawing.Size(433, 20)
            Me.txtApellidoCasada.TabIndex = 13
            Me.txtApellidoCasada.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApellidoCasada.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtFechaNac.Location = New System.Drawing.Point(317, 128)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(433, 20)
            Me.txtFechaNac.TabIndex = 17
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(464, 129)
            Me.txtSexo.MaxLength = 3
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(39, 20)
            Me.txtSexo.TabIndex = 19
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'GroupBox12
            '
            Me.GroupBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GroupBox12.Controls.Add(Me.txtUbigeo)
            Me.GroupBox12.Controls.Add(Me.txtUbigeoDireccion)
            Me.GroupBox12.Location = New System.Drawing.Point(219, 189)
            Me.GroupBox12.Name = "GroupBox12"
            Me.GroupBox12.Size = New System.Drawing.Size(433, 63)
            Me.GroupBox12.TabIndex = 21
            Me.GroupBox12.TabStop = False
            Me.GroupBox12.Text = "Ubigeo Departamento/Provincia/Distrito :"
            '
            'txtUbigeo
            '
            Me.txtUbigeo._BloquearPaste = False
            Me.txtUbigeo._SeleccionarTodo = False
            Me.txtUbigeo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUbigeo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeo.Location = New System.Drawing.Point(11, 15)
            Me.txtUbigeo.Name = "txtUbigeo"
            Me.txtUbigeo.ReadOnly = True
            Me.txtUbigeo.Size = New System.Drawing.Size(427, 20)
            Me.txtUbigeo.TabIndex = 0
            Me.txtUbigeo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtUbigeoDireccion
            '
            Me.txtUbigeoDireccion._BloquearPaste = False
            Me.txtUbigeoDireccion._SeleccionarTodo = False
            Me.txtUbigeoDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUbigeoDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeoDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUbigeoDireccion.Location = New System.Drawing.Point(11, 41)
            Me.txtUbigeoDireccion.Name = "txtUbigeoDireccion"
            Me.txtUbigeoDireccion.ReadOnly = True
            Me.txtUbigeoDireccion.Size = New System.Drawing.Size(427, 18)
            Me.txtUbigeoDireccion.TabIndex = 1
            Me.txtUbigeoDireccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeoDireccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'grpNacimientoReniec
            '
            Me.grpNacimientoReniec.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grpNacimientoReniec.Controls.Add(Me.txtUbigeoNacimiento)
            Me.grpNacimientoReniec.Controls.Add(Me.Label46)
            Me.grpNacimientoReniec.Location = New System.Drawing.Point(220, 150)
            Me.grpNacimientoReniec.Name = "grpNacimientoReniec"
            Me.grpNacimientoReniec.Size = New System.Drawing.Size(433, 40)
            Me.grpNacimientoReniec.TabIndex = 20
            Me.grpNacimientoReniec.TabStop = False
            Me.grpNacimientoReniec.Text = "Lugar de Nacimiento :"
            '
            'txtUbigeoNacimiento
            '
            Me.txtUbigeoNacimiento._BloquearPaste = False
            Me.txtUbigeoNacimiento._SeleccionarTodo = False
            Me.txtUbigeoNacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtUbigeoNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUbigeoNacimiento.Location = New System.Drawing.Point(10, 15)
            Me.txtUbigeoNacimiento.Name = "txtUbigeoNacimiento"
            Me.txtUbigeoNacimiento.ReadOnly = True
            Me.txtUbigeoNacimiento.Size = New System.Drawing.Size(427, 20)
            Me.txtUbigeoNacimiento.TabIndex = 0
            Me.txtUbigeoNacimiento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtUbigeoNacimiento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label46
            '
            Me.Label46.AutoSize = True
            Me.Label46.Location = New System.Drawing.Point(15, 17)
            Me.Label46.Name = "Label46"
            Me.Label46.Size = New System.Drawing.Size(0, 13)
            Me.Label46.TabIndex = 1
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(222, 42)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(82, 13)
            Me.Label47.TabIndex = 8
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Location = New System.Drawing.Point(317, 39)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(433, 20)
            Me.txtPrimerApellido.TabIndex = 9
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Location = New System.Drawing.Point(222, 66)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(96, 13)
            Me.Label48.TabIndex = 10
            Me.Label48.Text = "Segundo Apellido :"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Location = New System.Drawing.Point(222, 108)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(74, 13)
            Me.Label49.TabIndex = 14
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label50.AutoSize = True
            Me.Label50.Location = New System.Drawing.Point(424, 132)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(37, 13)
            Me.Label50.TabIndex = 18
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Location = New System.Drawing.Point(317, 105)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(433, 20)
            Me.txtPrenombres.TabIndex = 15
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Location = New System.Drawing.Point(224, 132)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(69, 13)
            Me.Label51.TabIndex = 16
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Location = New System.Drawing.Point(317, 61)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(433, 20)
            Me.txtSegundoApellido.TabIndex = 11
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Location = New System.Drawing.Point(222, 19)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(72, 13)
            Me.Label52.TabIndex = 2
            Me.Label52.Text = "Número DNI :"
            '
            'Label53
            '
            Me.Label53.AutoSize = True
            Me.Label53.Location = New System.Drawing.Point(244, 258)
            Me.Label53.Name = "Label53"
            Me.Label53.Size = New System.Drawing.Size(67, 13)
            Me.Label53.TabIndex = 22
            Me.Label53.Text = "Estado civil :"
            '
            'txtDigitoVeri
            '
            Me.txtDigitoVeri._BloquearPaste = False
            Me.txtDigitoVeri._SeleccionarTodo = False
            Me.txtDigitoVeri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDigitoVeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDigitoVeri.Location = New System.Drawing.Point(476, 10)
            Me.txtDigitoVeri.Name = "txtDigitoVeri"
            Me.txtDigitoVeri.ReadOnly = True
            Me.txtDigitoVeri.Size = New System.Drawing.Size(27, 22)
            Me.txtDigitoVeri.TabIndex = 5
            Me.txtDigitoVeri.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDigitoVeri.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDni
            '
            Me.txtDni._BloquearPaste = False
            Me.txtDni._SeleccionarTodo = False
            Me.txtDni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDni.Location = New System.Drawing.Point(317, 10)
            Me.txtDni.Name = "txtDni"
            Me.txtDni.ReadOnly = True
            Me.txtDni.Size = New System.Drawing.Size(433, 22)
            Me.txtDni.TabIndex = 3
            Me.txtDni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'gradInsRNCId
            '
            Me.gradInsRNCId.AutoSize = True
            Me.gradInsRNCId.ForeColor = System.Drawing.Color.Red
            Me.gradInsRNCId.Location = New System.Drawing.Point(227, 239)
            Me.gradInsRNCId.Name = "gradInsRNCId"
            Me.gradInsRNCId.Size = New System.Drawing.Size(74, 13)
            Me.gradInsRNCId.TabIndex = 36
            Me.gradInsRNCId.Text = "gradInsRNCId"
            Me.gradInsRNCId.Visible = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.DimGray
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.White
            Me.Label3.Location = New System.Drawing.Point(488, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(512, 20)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "DETALLE DE REGISTRO..."
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.dgwGrillaListaReniec)
            Me.Panel4.Controls.Add(Me.Panel6)
            Me.Panel4.Controls.Add(Me.Label1)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(488, 367)
            Me.Panel4.TabIndex = 0
            Me.Panel4.Visible = False
            '
            'dgwGrillaListaReniec
            '
            Me.dgwGrillaListaReniec.AllowUserToAddRows = False
            Me.dgwGrillaListaReniec.AllowUserToDeleteRows = False
            Me.dgwGrillaListaReniec.AllowUserToResizeRows = False
            Me.dgwGrillaListaReniec.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaListaReniec.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrillaListaReniec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaListaReniec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_num_dni, Me.col_dig_ver, Me.Column3, Me.Column4, Me.Column5, Me.col_mostrar})
            Me.dgwGrillaListaReniec.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrillaListaReniec.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaListaReniec.Location = New System.Drawing.Point(0, 20)
            Me.dgwGrillaListaReniec.MultiSelect = False
            Me.dgwGrillaListaReniec.Name = "dgwGrillaListaReniec"
            Me.dgwGrillaListaReniec.ReadOnly = True
            Me.dgwGrillaListaReniec.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaListaReniec.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrillaListaReniec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaListaReniec.Size = New System.Drawing.Size(488, 307)
            Me.dgwGrillaListaReniec.TabIndex = 2
            Me.dgwGrillaListaReniec.VisibleCampos = False
            '
            'col_num
            '
            Me.col_num.HeaderText = "N°"
            Me.col_num.Name = "col_num"
            Me.col_num.ReadOnly = True
            Me.col_num.Width = 25
            '
            'col_num_dni
            '
            Me.col_num_dni.HeaderText = "Nro DNI "
            Me.col_num_dni.Name = "col_num_dni"
            Me.col_num_dni.ReadOnly = True
            Me.col_num_dni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_num_dni.Width = 57
            '
            'col_dig_ver
            '
            Me.col_dig_ver.HeaderText = "Dig"
            Me.col_dig_ver.Name = "col_dig_ver"
            Me.col_dig_ver.ReadOnly = True
            Me.col_dig_ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_dig_ver.ToolTipText = "Digito de Verificación"
            Me.col_dig_ver.Width = 25
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column3.HeaderText = "Primer Apellido"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            '
            'Column4
            '
            Me.Column4.HeaderText = "Segundo Apellido"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column4.Width = 103
            '
            'Column5
            '
            Me.Column5.HeaderText = "Nombres"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.Column5.Width = 108
            '
            'col_mostrar
            '
            Me.col_mostrar.HeaderText = "Mostrar Datos"
            Me.col_mostrar.Name = "col_mostrar"
            Me.col_mostrar.ReadOnly = True
            Me.col_mostrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.col_mostrar.Width = 50
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnDetalleRnc)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel6.Location = New System.Drawing.Point(0, 327)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(488, 40)
            Me.Panel6.TabIndex = 5
            '
            'btnDetalleRnc
            '
            Me.btnDetalleRnc.BackColor = System.Drawing.SystemColors.Info
            Me.btnDetalleRnc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDetalleRnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDetalleRnc.ForeColor = System.Drawing.Color.Black
            Me.btnDetalleRnc.Image = Global.SIPPOPE.My.Resources.Resources._1_next
            Me.btnDetalleRnc.Location = New System.Drawing.Point(2, -1)
            Me.btnDetalleRnc.Name = "btnDetalleRnc"
            Me.btnDetalleRnc.Size = New System.Drawing.Size(129, 40)
            Me.btnDetalleRnc.TabIndex = 4
            Me.btnDetalleRnc.Text = "Ver detalle"
            Me.btnDetalleRnc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.btnDetalleRnc.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.DimGray
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.ForeColor = System.Drawing.Color.White
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(488, 20)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "REGISTROS ENCONTRADOS ..."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmBuscaReniecPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1000, 532)
            Me.Name = "frmBuscaReniecPopup"
            Me.Text = ".::. Buscar en la RENIEC"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox12.ResumeLayout(False)
            Me.GroupBox12.PerformLayout()
            Me.grpNacimientoReniec.ResumeLayout(False)
            Me.grpNacimientoReniec.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            CType(Me.dgwGrillaListaReniec, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel6.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
        Friend WithEvents rbDNI As System.Windows.Forms.RadioButton
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
        Friend WithEvents txtApePat As System.Windows.Forms.TextBox
        Friend WithEvents txtNom As System.Windows.Forms.TextBox
        Friend WithEvents txtNumDoc As System.Windows.Forms.TextBox
        Friend WithEvents btnRegNuevo As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents gradInsRNCId As System.Windows.Forms.Label
        Friend WithEvents lblFechaemision As System.Windows.Forms.Label
        Friend WithEvents lblFechaInscripcion As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtTalla As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtRestriccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtPadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
        Friend WithEvents txtMadre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtEstadoCivil As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlFotoVis As System.Windows.Forms.Panel
        Friend WithEvents picFoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label44 As System.Windows.Forms.Label
        Friend WithEvents txtGradoInstruccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoCasada As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtUbigeoDireccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grpNacimientoReniec As System.Windows.Forms.GroupBox
        Friend WithEvents txtUbigeoNacimiento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label46 As System.Windows.Forms.Label
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents Label53 As System.Windows.Forms.Label
        Friend WithEvents txtDigitoVeri As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents dgwGrillaListaReniec As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_num As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_num_dni As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_dig_ver As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_mostrar As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnDetalleRnc As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace