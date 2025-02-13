Namespace Visita.Movimiento

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVisitanteReniec
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisitanteReniec))
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.txtApellidoCasada = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTipoDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNacionalidad = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.txtRestriccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtDigitoVeri = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.UscFotografia1 = New APPControls.Foto.uscFotografia()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.txtBuscarNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.lblFechaHoy = New System.Windows.Forms.Label()
            Me.UsrRegionPenal1 = New APPControls.usrRegionPenal()
            Me.pnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox9.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBusqueda.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.Panel1)
            Me.pnlBotones.Controls.Add(Me.txtApellidoCasada)
            Me.pnlBotones.Controls.Add(Me.Label1)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(0, 680)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(1072, 54)
            Me.pnlBotones.TabIndex = 0
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnNuevo)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(855, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(217, 54)
            Me.Panel1.TabIndex = 0
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = Global.SIPPOPE.My.Resources.Resources._1277961158_folder_new
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(4, 6)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(98, 41)
            Me.btnNuevo.TabIndex = 1
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(111, 6)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(98, 41)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'txtApellidoCasada
            '
            Me.txtApellidoCasada._BloquearPaste = True
            Me.txtApellidoCasada._SeleccionarTodo = False
            Me.txtApellidoCasada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtApellidoCasada.Location = New System.Drawing.Point(103, 15)
            Me.txtApellidoCasada.Name = "txtApellidoCasada"
            Me.txtApellidoCasada.ReadOnly = True
            Me.txtApellidoCasada.Size = New System.Drawing.Size(150, 20)
            Me.txtApellidoCasada.TabIndex = 13
            Me.txtApellidoCasada.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApellidoCasada.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            Me.txtApellidoCasada.Visible = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(86, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Apellido Casada:"
            Me.Label1.Visible = False
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.Label4)
            Me.GroupBox9.Controls.Add(Me.txtTipoDoc)
            Me.GroupBox9.Controls.Add(Me.txtNacionalidad)
            Me.GroupBox9.Controls.Add(Me.Label7)
            Me.GroupBox9.Controls.Add(Me.picFoto)
            Me.GroupBox9.Controls.Add(Me.txtRestriccion)
            Me.GroupBox9.Controls.Add(Me.Label5)
            Me.GroupBox9.Controls.Add(Me.Label2)
            Me.GroupBox9.Controls.Add(Me.txtFechaNac)
            Me.GroupBox9.Controls.Add(Me.txtSexo)
            Me.GroupBox9.Controls.Add(Me.Label47)
            Me.GroupBox9.Controls.Add(Me.txtPrimerApellido)
            Me.GroupBox9.Controls.Add(Me.Label48)
            Me.GroupBox9.Controls.Add(Me.Label49)
            Me.GroupBox9.Controls.Add(Me.Label50)
            Me.GroupBox9.Controls.Add(Me.txtPrenombres)
            Me.GroupBox9.Controls.Add(Me.Label51)
            Me.GroupBox9.Controls.Add(Me.txtSegundoApellido)
            Me.GroupBox9.Controls.Add(Me.Label52)
            Me.GroupBox9.Controls.Add(Me.txtDigitoVeri)
            Me.GroupBox9.Controls.Add(Me.txtNumDoc)
            Me.GroupBox9.Controls.Add(Me.UscFotografia1)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox9.Location = New System.Drawing.Point(0, 90)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(1072, 290)
            Me.GroupBox9.TabIndex = 17
            Me.GroupBox9.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Location = New System.Drawing.Point(239, 61)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(84, 20)
            Me.Label4.TabIndex = 33
            Me.Label4.Text = "Tipo Doc. :"
            '
            'txtTipoDoc
            '
            Me.txtTipoDoc._BloquearPaste = True
            Me.txtTipoDoc._SeleccionarTodo = False
            Me.txtTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTipoDoc.Location = New System.Drawing.Point(398, 61)
            Me.txtTipoDoc.Name = "txtTipoDoc"
            Me.txtTipoDoc.ReadOnly = True
            Me.txtTipoDoc.Size = New System.Drawing.Size(207, 26)
            Me.txtTipoDoc.TabIndex = 34
            Me.txtTipoDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNacionalidad
            '
            Me.txtNacionalidad._BloquearPaste = False
            Me.txtNacionalidad._SeleccionarTodo = False
            Me.txtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNacionalidad.Location = New System.Drawing.Point(398, 223)
            Me.txtNacionalidad.Name = "txtNacionalidad"
            Me.txtNacionalidad.ReadOnly = True
            Me.txtNacionalidad.Size = New System.Drawing.Size(301, 26)
            Me.txtNacionalidad.TabIndex = 32
            Me.txtNacionalidad.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNacionalidad.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(240, 226)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(108, 20)
            Me.Label7.TabIndex = 31
            Me.Label7.Text = "Nacionalidad :"
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.PaleGoldenrod
            Me.picFoto.BackgroundImage = CType(resources.GetObject("picFoto.BackgroundImage"), System.Drawing.Image)
            Me.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picFoto.Location = New System.Drawing.Point(12, 19)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(208, 265)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'txtRestriccion
            '
            Me.txtRestriccion._BloquearPaste = False
            Me.txtRestriccion._SeleccionarTodo = False
            Me.txtRestriccion.BackColor = System.Drawing.SystemColors.Control
            Me.txtRestriccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtRestriccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtRestriccion.Location = New System.Drawing.Point(645, 256)
            Me.txtRestriccion.Name = "txtRestriccion"
            Me.txtRestriccion.ReadOnly = True
            Me.txtRestriccion.Size = New System.Drawing.Size(54, 26)
            Me.txtRestriccion.TabIndex = 29
            Me.txtRestriccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRestriccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(536, 259)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(96, 20)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Restriccion :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(558, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(14, 20)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "-"
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtFechaNac.Location = New System.Drawing.Point(398, 191)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(301, 26)
            Me.txtFechaNac.TabIndex = 17
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(398, 256)
            Me.txtSexo.MaxLength = 3
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(130, 26)
            Me.txtSexo.TabIndex = 19
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(239, 94)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(122, 20)
            Me.Label47.TabIndex = 8
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrimerApellido.Location = New System.Drawing.Point(398, 92)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(301, 26)
            Me.txtPrimerApellido.TabIndex = 9
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(239, 129)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(142, 20)
            Me.Label48.TabIndex = 10
            Me.Label48.Text = "Segundo Apellido :"
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(239, 161)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(109, 20)
            Me.Label49.TabIndex = 14
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(239, 259)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(53, 20)
            Me.Label50.TabIndex = 18
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPrenombres.Location = New System.Drawing.Point(398, 159)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(301, 26)
            Me.txtPrenombres.TabIndex = 15
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(239, 194)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(98, 20)
            Me.Label51.TabIndex = 16
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSegundoApellido.Location = New System.Drawing.Point(398, 127)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(301, 26)
            Me.txtSegundoApellido.TabIndex = 11
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(239, 29)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(73, 20)
            Me.Label52.TabIndex = 2
            Me.Label52.Text = "Numero :"
            '
            'txtDigitoVeri
            '
            Me.txtDigitoVeri._BloquearPaste = False
            Me.txtDigitoVeri._SeleccionarTodo = False
            Me.txtDigitoVeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDigitoVeri.Location = New System.Drawing.Point(578, 29)
            Me.txtDigitoVeri.Name = "txtDigitoVeri"
            Me.txtDigitoVeri.ReadOnly = True
            Me.txtDigitoVeri.Size = New System.Drawing.Size(27, 26)
            Me.txtDigitoVeri.TabIndex = 5
            Me.txtDigitoVeri.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDigitoVeri.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDoc.Location = New System.Drawing.Point(398, 29)
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.ReadOnly = True
            Me.txtNumDoc.Size = New System.Drawing.Size(154, 26)
            Me.txtNumDoc.TabIndex = 3
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'UscFotografia1
            '
            Me.UscFotografia1._CheckImagen = True
            Me.UscFotografia1._EnabledDobleClick = True
            Me.UscFotografia1._HasImagen = False
            Me.UscFotografia1._PanelAutorizacion = False
            Me.UscFotografia1._PanelCheck = False
            Me.UscFotografia1.Location = New System.Drawing.Point(12, 19)
            Me.UscFotografia1.Name = "UscFotografia1"
            Me.UscFotografia1.Size = New System.Drawing.Size(208, 265)
            Me.UscFotografia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
            Me.UscFotografia1.TabIndex = 79
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Location = New System.Drawing.Point(611, 5)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(35, 35)
            Me.btnBuscar.TabIndex = 100
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'txtBuscarNumDoc
            '
            Me.txtBuscarNumDoc._BloquearPaste = False
            Me.txtBuscarNumDoc._SeleccionarTodo = True
            Me.txtBuscarNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBuscarNumDoc.Location = New System.Drawing.Point(475, 5)
            Me.txtBuscarNumDoc.MaxLength = 8
            Me.txtBuscarNumDoc.Name = "txtBuscarNumDoc"
            Me.txtBuscarNumDoc.Size = New System.Drawing.Size(135, 35)
            Me.txtBuscarNumDoc.TabIndex = 99
            Me.txtBuscarNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtBuscarNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.Location = New System.Drawing.Point(239, 12)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(187, 24)
            Me.Label10.TabIndex = 98
            Me.Label10.Text = "Numero Documento:"
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.cbbTipoDoc)
            Me.pnlBusqueda.Controls.Add(Me.Label3)
            Me.pnlBusqueda.Controls.Add(Me.txtBuscarNumDoc)
            Me.pnlBusqueda.Controls.Add(Me.btnBuscar)
            Me.pnlBusqueda.Controls.Add(Me.Label10)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBusqueda.Location = New System.Drawing.Point(0, 45)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(1072, 45)
            Me.pnlBusqueda.TabIndex = 101
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = Type.Combo.ComboTipo.Ninguno
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 200
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.Location = New System.Drawing.Point(114, 14)
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(105, 22)
            Me.cbbTipoDoc.TabIndex = 95
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(10, 12)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(102, 24)
            Me.Label3.TabIndex = 101
            Me.Label3.Text = "Tipo Doc. :"
            '
            'BackgroundWorker1
            '
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgwGrilla)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 380)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(1072, 300)
            Me.GroupBox1.TabIndex = 102
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Listado de Sanciones"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Column2, Me.Column3, Me.Column5, Me.Column1, Me.col_hasta, Me.Column4, Me.Column6})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 16)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle2
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(1066, 281)
            Me.dgwGrilla.TabIndex = 76
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "VisitanteSancionID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "EstadoNombre"
            Me.Column2.HeaderText = "Estado"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 50
            '
            'Column3
            '
            Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column3.DataPropertyName = "TipoSancionNombre"
            Me.Column3.HeaderText = "Motivo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 250
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "FechaString"
            Me.Column5.HeaderText = "Fecha"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 70
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "FechaIniDate"
            Me.Column1.HeaderText = "Desde"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Width = 70
            '
            'col_hasta
            '
            Me.col_hasta.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle1.NullValue = Nothing
            Me.col_hasta.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_hasta.HeaderText = "Hasta"
            Me.col_hasta.Name = "col_hasta"
            Me.col_hasta.ReadOnly = True
            Me.col_hasta.Width = 70
            '
            'Column4
            '
            Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
            Me.Column4.DataPropertyName = "Documento"
            Me.Column4.HeaderText = "Doc. Sancion"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 200
            '
            'Column6
            '
            Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column6.DataPropertyName = "Observacion"
            Me.Column6.HeaderText = "Observacion"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            '
            'GroupBox2
            '
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.Label25)
            Me.GroupBox2.Controls.Add(Me.Label27)
            Me.GroupBox2.Controls.Add(Me.lblFechaHoy)
            Me.GroupBox2.Controls.Add(Me.UsrRegionPenal1)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1072, 45)
            Me.GroupBox2.TabIndex = 103
            Me.GroupBox2.TabStop = False
            '
            'Label25
            '
            Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label25.Location = New System.Drawing.Point(509, 14)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(3, 25)
            Me.Label25.TabIndex = 8
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(515, 20)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(43, 13)
            Me.Label27.TabIndex = 10
            Me.Label27.Text = "Fecha :"
            '
            'lblFechaHoy
            '
            Me.lblFechaHoy.BackColor = System.Drawing.SystemColors.Control
            Me.lblFechaHoy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFechaHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaHoy.Location = New System.Drawing.Point(583, 16)
            Me.lblFechaHoy.Name = "lblFechaHoy"
            Me.lblFechaHoy.Size = New System.Drawing.Size(250, 22)
            Me.lblFechaHoy.TabIndex = 9
            Me.lblFechaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'UsrRegionPenal1
            '
            Me.UsrRegionPenal1._LicenciaID = -1
            Me.UsrRegionPenal1._PenalID = 0
            Me.UsrRegionPenal1._PenalTodos = True
            Me.UsrRegionPenal1._RegionID = 0
            Me.UsrRegionPenal1._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Usuario
            Me.UsrRegionPenal1._UsuarioID = -1
            Me.UsrRegionPenal1._WidthLabelRegion = 47
            Me.UsrRegionPenal1.BackColor = System.Drawing.Color.Transparent
            Me.UsrRegionPenal1.Location = New System.Drawing.Point(3, 16)
            Me.UsrRegionPenal1.Name = "UsrRegionPenal1"
            Me.UsrRegionPenal1.Size = New System.Drawing.Size(492, 22)
            Me.UsrRegionPenal1.TabIndex = 1
            Me.UsrRegionPenal1.WidthRegion = 224
            '
            'frmVisitanteReniec
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1072, 734)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox9)
            Me.Controls.Add(Me.pnlBusqueda)
            Me.Controls.Add(Me.pnlBotones)
            Me.Controls.Add(Me.GroupBox2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmVisitanteReniec"
            Me.ShowInTaskbar = False
            Me.Text = "Validacion de Visitantes..."
            Me.pnlBotones.ResumeLayout(False)
            Me.pnlBotones.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.pnlBusqueda.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents txtRestriccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents picFoto As System.Windows.Forms.PictureBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtApellidoCasada As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label47 As System.Windows.Forms.Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As System.Windows.Forms.Label
        Friend WithEvents Label49 As System.Windows.Forms.Label
        Friend WithEvents Label50 As System.Windows.Forms.Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As System.Windows.Forms.Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As System.Windows.Forms.Label
        Friend WithEvents txtDigitoVeri As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents txtBuscarNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents UsrRegionPenal1 As APPControls.usrRegionPenal
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents lblFechaHoy As System.Windows.Forms.Label
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hasta As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNacionalidad As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtTipoDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents UscFotografia1 As APPControls.Foto.uscFotografia

    End Class
End Namespace