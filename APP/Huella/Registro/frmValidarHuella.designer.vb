Namespace Huella.Registro


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmValidarHuella
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.pnlVerificar = New System.Windows.Forms.Panel()
            Me.btnVerifHuella = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlDatosInterno = New System.Windows.Forms.Panel()
            Me.UscVisorHuellas2 = New APPControls.Registro.Huellas.uscVisorHuellas()
            Me.gbDatosInterno = New System.Windows.Forms.GroupBox()
            Me.lblmensaje = New System.Windows.Forms.Label()
            Me.pnlFotoVis = New System.Windows.Forms.Panel()
            Me.picFoto = New System.Windows.Forms.PictureBox()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.ckbHuellas = New System.Windows.Forms.CheckBox()
            Me.txtFechaNac = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtSexo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label47 = New System.Windows.Forms.Label()
            Me.txtPrimerApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.txtPrenombres = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label51 = New System.Windows.Forms.Label()
            Me.txtSegundoApellido = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label52 = New System.Windows.Forms.Label()
            Me.txtDni = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.UscDatosInternoReniec1 = New APPControls.Registro.Huellas.uscDatosInternoReniec()
            Me.pnlLeyenda = New System.Windows.Forms.Panel()
            Me.gbLeyenda = New System.Windows.Forms.GroupBox()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.lblCabecera = New System.Windows.Forms.Label()
            Me.pnlCuerpo = New System.Windows.Forms.Panel()
            Me.lblCuerpo2 = New System.Windows.Forms.Label()
            Me.lblCuerpo1 = New System.Windows.Forms.Label()
            Me.UscVisorHuellas1 = New APPControls.Registro.Huellas.uscVisorHuellas()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.pnlVerificar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlDatosInterno.SuspendLayout()
            Me.gbDatosInterno.SuspendLayout()
            Me.pnlFotoVis.SuspendLayout()
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.pnlLeyenda.SuspendLayout()
            Me.gbLeyenda.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.pnlCuerpo.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlGrabar)
            Me.Panel2.Controls.Add(Me.pnlVerificar)
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 447)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(996, 46)
            Me.Panel2.TabIndex = 45
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(651, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(115, 46)
            Me.pnlGrabar.TabIndex = 90
            Me.pnlGrabar.Visible = False
            '
            'btnGrabar
            '
            Me.btnGrabar.BackColor = System.Drawing.Color.Transparent
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.logo_reniec
            Me.btnGrabar.Location = New System.Drawing.Point(8, 3)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(100, 40)
            Me.btnGrabar.TabIndex = 89
            Me.btnGrabar.Text = "Actualizar Huella"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = False
            '
            'pnlVerificar
            '
            Me.pnlVerificar.Controls.Add(Me.btnVerifHuella)
            Me.pnlVerificar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlVerificar.Location = New System.Drawing.Point(766, 0)
            Me.pnlVerificar.Name = "pnlVerificar"
            Me.pnlVerificar.Size = New System.Drawing.Size(115, 46)
            Me.pnlVerificar.TabIndex = 88
            '
            'btnVerifHuella
            '
            Me.btnVerifHuella.BackColor = System.Drawing.SystemColors.Control
            Me.btnVerifHuella.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(236, Byte), Integer))
            Me.btnVerifHuella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.btnVerifHuella.Image = Global.SIPPOPE.My.Resources.Resources.verificar_biometria_32x32
            Me.btnVerifHuella.Location = New System.Drawing.Point(12, 3)
            Me.btnVerifHuella.Name = "btnVerifHuella"
            Me.btnVerifHuella.Size = New System.Drawing.Size(97, 40)
            Me.btnVerifHuella.TabIndex = 73
            Me.btnVerifHuella.Text = "Verificar huella"
            Me.btnVerifHuella.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnVerifHuella.UseVisualStyleBackColor = False
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(881, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(115, 46)
            Me.Panel1.TabIndex = 87
            '
            'btnCancel
            '
            Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(12, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlDatosInterno
            '
            Me.pnlDatosInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDatosInterno.Controls.Add(Me.UscVisorHuellas2)
            Me.pnlDatosInterno.Controls.Add(Me.gbDatosInterno)
            Me.pnlDatosInterno.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlDatosInterno.Location = New System.Drawing.Point(0, 0)
            Me.pnlDatosInterno.Name = "pnlDatosInterno"
            Me.pnlDatosInterno.Size = New System.Drawing.Size(491, 447)
            Me.pnlDatosInterno.TabIndex = 50
            '
            'UscVisorHuellas2
            '
            Me.UscVisorHuellas2._ApeMat = ""
            Me.UscVisorHuellas2._ApePat = ""
            Me.UscVisorHuellas2._CodRP = ""
            Me.UscVisorHuellas2._InternoId = 0
            Me.UscVisorHuellas2._Nombres = ""
            Me.UscVisorHuellas2._NumDocIdent = ""
            Me.UscVisorHuellas2._PenId = 0
            Me.UscVisorHuellas2._RegId = 0
            Me.UscVisorHuellas2._TipDocIdentId = -1
            Me.UscVisorHuellas2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscVisorHuellas2.lblhuelladerecha = "Mano Izquierda"
            Me.UscVisorHuellas2.lblhuellaizquierda = "Mano Izquierda"
            Me.UscVisorHuellas2.Location = New System.Drawing.Point(0, 290)
            Me.UscVisorHuellas2.Name = "UscVisorHuellas2"
            Me.UscVisorHuellas2.Size = New System.Drawing.Size(489, 155)
            Me.UscVisorHuellas2.TabIndex = 0
            '
            'gbDatosInterno
            '
            Me.gbDatosInterno.Controls.Add(Me.lblmensaje)
            Me.gbDatosInterno.Controls.Add(Me.pnlFotoVis)
            Me.gbDatosInterno.Controls.Add(Me.lblTitulo)
            Me.gbDatosInterno.Controls.Add(Me.ckbHuellas)
            Me.gbDatosInterno.Controls.Add(Me.txtFechaNac)
            Me.gbDatosInterno.Controls.Add(Me.txtSexo)
            Me.gbDatosInterno.Controls.Add(Me.Label47)
            Me.gbDatosInterno.Controls.Add(Me.txtPrimerApellido)
            Me.gbDatosInterno.Controls.Add(Me.Label49)
            Me.gbDatosInterno.Controls.Add(Me.Label50)
            Me.gbDatosInterno.Controls.Add(Me.txtPrenombres)
            Me.gbDatosInterno.Controls.Add(Me.Label51)
            Me.gbDatosInterno.Controls.Add(Me.txtSegundoApellido)
            Me.gbDatosInterno.Controls.Add(Me.Label52)
            Me.gbDatosInterno.Controls.Add(Me.txtDni)
            Me.gbDatosInterno.Controls.Add(Me.Label48)
            Me.gbDatosInterno.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbDatosInterno.Location = New System.Drawing.Point(0, 0)
            Me.gbDatosInterno.Name = "gbDatosInterno"
            Me.gbDatosInterno.Size = New System.Drawing.Size(489, 445)
            Me.gbDatosInterno.TabIndex = 3
            Me.gbDatosInterno.TabStop = False
            '
            'lblmensaje
            '
            Me.lblmensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblmensaje.AutoSize = True
            Me.lblmensaje.BackColor = System.Drawing.Color.Red
            Me.lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblmensaje.ForeColor = System.Drawing.Color.White
            Me.lblmensaje.Location = New System.Drawing.Point(65, 164)
            Me.lblmensaje.Name = "lblmensaje"
            Me.lblmensaje.Size = New System.Drawing.Size(369, 24)
            Me.lblmensaje.TabIndex = 23
            Me.lblmensaje.Text = "El interno no se encuentra en el penal"
            Me.lblmensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.lblmensaje.Visible = False
            '
            'pnlFotoVis
            '
            Me.pnlFotoVis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlFotoVis.Controls.Add(Me.picFoto)
            Me.pnlFotoVis.Location = New System.Drawing.Point(3, 40)
            Me.pnlFotoVis.Name = "pnlFotoVis"
            Me.pnlFotoVis.Size = New System.Drawing.Size(207, 240)
            Me.pnlFotoVis.TabIndex = 49
            '
            'picFoto
            '
            Me.picFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.picFoto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.picFoto.Location = New System.Drawing.Point(0, 0)
            Me.picFoto.Name = "picFoto"
            Me.picFoto.Size = New System.Drawing.Size(203, 236)
            Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picFoto.TabIndex = 22
            Me.picFoto.TabStop = False
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTitulo.Location = New System.Drawing.Point(112, 11)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(265, 16)
            Me.lblTitulo.TabIndex = 48
            Me.lblTitulo.Text = "DATOS DEL INTERNO EN EL PENAL"
            '
            'ckbHuellas
            '
            Me.ckbHuellas.AutoSize = True
            Me.ckbHuellas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.ckbHuellas.Enabled = False
            Me.ckbHuellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ckbHuellas.Location = New System.Drawing.Point(213, 220)
            Me.ckbHuellas.Name = "ckbHuellas"
            Me.ckbHuellas.Size = New System.Drawing.Size(120, 19)
            Me.ckbHuellas.TabIndex = 47
            Me.ckbHuellas.Text = "Huella dactilar"
            Me.ckbHuellas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.ckbHuellas.UseVisualStyleBackColor = True
            '
            'txtFechaNac
            '
            Me.txtFechaNac._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaNac._BloquearPaste = False
            Me.txtFechaNac._SeleccionarTodo = False
            Me.txtFechaNac.Location = New System.Drawing.Point(320, 158)
            Me.txtFechaNac.Name = "txtFechaNac"
            Me.txtFechaNac.ReadOnly = True
            Me.txtFechaNac.Size = New System.Drawing.Size(165, 20)
            Me.txtFechaNac.TabIndex = 42
            Me.txtFechaNac.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaNac.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtSexo
            '
            Me.txtSexo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSexo._BloquearPaste = True
            Me.txtSexo._SeleccionarTodo = False
            Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSexo.Location = New System.Drawing.Point(320, 186)
            Me.txtSexo.Name = "txtSexo"
            Me.txtSexo.ReadOnly = True
            Me.txtSexo.Size = New System.Drawing.Size(165, 20)
            Me.txtSexo.TabIndex = 44
            Me.txtSexo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSexo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label47
            '
            Me.Label47.AutoSize = True
            Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label47.ForeColor = System.Drawing.Color.Black
            Me.Label47.Location = New System.Drawing.Point(215, 76)
            Me.Label47.Name = "Label47"
            Me.Label47.Size = New System.Drawing.Size(99, 13)
            Me.Label47.TabIndex = 35
            Me.Label47.Text = "Primer Apellido :"
            '
            'txtPrimerApellido
            '
            Me.txtPrimerApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrimerApellido._BloquearPaste = True
            Me.txtPrimerApellido._SeleccionarTodo = False
            Me.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrimerApellido.Location = New System.Drawing.Point(320, 73)
            Me.txtPrimerApellido.Name = "txtPrimerApellido"
            Me.txtPrimerApellido.ReadOnly = True
            Me.txtPrimerApellido.Size = New System.Drawing.Size(165, 20)
            Me.txtPrimerApellido.TabIndex = 36
            Me.txtPrimerApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrimerApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label49
            '
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label49.Location = New System.Drawing.Point(215, 133)
            Me.Label49.Name = "Label49"
            Me.Label49.Size = New System.Drawing.Size(87, 13)
            Me.Label49.TabIndex = 39
            Me.Label49.Text = "Pre Nombres :"
            '
            'Label50
            '
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label50.Location = New System.Drawing.Point(215, 190)
            Me.Label50.Name = "Label50"
            Me.Label50.Size = New System.Drawing.Size(43, 13)
            Me.Label50.TabIndex = 43
            Me.Label50.Text = "Sexo :"
            '
            'txtPrenombres
            '
            Me.txtPrenombres._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPrenombres._BloquearPaste = True
            Me.txtPrenombres._SeleccionarTodo = False
            Me.txtPrenombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPrenombres.Location = New System.Drawing.Point(320, 130)
            Me.txtPrenombres.Name = "txtPrenombres"
            Me.txtPrenombres.ReadOnly = True
            Me.txtPrenombres.Size = New System.Drawing.Size(165, 20)
            Me.txtPrenombres.TabIndex = 40
            Me.txtPrenombres.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPrenombres.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label51
            '
            Me.Label51.AutoSize = True
            Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label51.Location = New System.Drawing.Point(215, 162)
            Me.Label51.Name = "Label51"
            Me.Label51.Size = New System.Drawing.Size(81, 13)
            Me.Label51.TabIndex = 41
            Me.Label51.Text = "Fecha Nac. :"
            '
            'txtSegundoApellido
            '
            Me.txtSegundoApellido._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSegundoApellido._BloquearPaste = True
            Me.txtSegundoApellido._SeleccionarTodo = False
            Me.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSegundoApellido.Location = New System.Drawing.Point(320, 101)
            Me.txtSegundoApellido.Name = "txtSegundoApellido"
            Me.txtSegundoApellido.ReadOnly = True
            Me.txtSegundoApellido.Size = New System.Drawing.Size(165, 20)
            Me.txtSegundoApellido.TabIndex = 38
            Me.txtSegundoApellido.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSegundoApellido.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label52
            '
            Me.Label52.AutoSize = True
            Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label52.Location = New System.Drawing.Point(215, 46)
            Me.Label52.Name = "Label52"
            Me.Label52.Size = New System.Drawing.Size(55, 13)
            Me.Label52.TabIndex = 33
            Me.Label52.Text = "N° DNI :"
            '
            'txtDni
            '
            Me.txtDni._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDni._BloquearPaste = False
            Me.txtDni._SeleccionarTodo = False
            Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDni.Location = New System.Drawing.Point(320, 42)
            Me.txtDni.Name = "txtDni"
            Me.txtDni.ReadOnly = True
            Me.txtDni.Size = New System.Drawing.Size(165, 21)
            Me.txtDni.TabIndex = 34
            Me.txtDni.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDni.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label48
            '
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label48.Location = New System.Drawing.Point(215, 106)
            Me.Label48.Name = "Label48"
            Me.Label48.Size = New System.Drawing.Size(106, 13)
            Me.Label48.TabIndex = 37
            Me.Label48.Text = "Segundo Apellido"
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Panel6)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(491, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(505, 447)
            Me.Panel5.TabIndex = 51
            '
            'Panel6
            '
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.UscDatosInternoReniec1)
            Me.Panel6.Controls.Add(Me.pnlLeyenda)
            Me.Panel6.Controls.Add(Me.UscVisorHuellas1)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel6.Location = New System.Drawing.Point(0, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(505, 447)
            Me.Panel6.TabIndex = 51
            '
            'UscDatosInternoReniec1
            '
            Me.UscDatosInternoReniec1._CondicionBusqueda = -1
            Me.UscDatosInternoReniec1._Contador = -1
            Me.UscDatosInternoReniec1._CopiaImagen = -1
            Me.UscDatosInternoReniec1._CopiaNombreImagen = ""
            Me.UscDatosInternoReniec1._EnabledDobleClick = False
            Me.UscDatosInternoReniec1._HasImagen = False
            Me.UscDatosInternoReniec1._InternoID = -1
            Me.UscDatosInternoReniec1._SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscDatosInternoReniec1._VarHistorico = 0
            Me.UscDatosInternoReniec1._Version = False
            Me.UscDatosInternoReniec1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscDatosInternoReniec1.Fecha = CType(0, Long)
            Me.UscDatosInternoReniec1.Location = New System.Drawing.Point(0, 0)
            Me.UscDatosInternoReniec1.Name = "UscDatosInternoReniec1"
            Me.UscDatosInternoReniec1.Size = New System.Drawing.Size(503, 145)
            Me.UscDatosInternoReniec1.TabIndex = 52
            '
            'pnlLeyenda
            '
            Me.pnlLeyenda.Controls.Add(Me.gbLeyenda)
            Me.pnlLeyenda.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlLeyenda.Location = New System.Drawing.Point(0, 145)
            Me.pnlLeyenda.Name = "pnlLeyenda"
            Me.pnlLeyenda.Size = New System.Drawing.Size(503, 145)
            Me.pnlLeyenda.TabIndex = 51
            Me.pnlLeyenda.Visible = False
            '
            'gbLeyenda
            '
            Me.gbLeyenda.Controls.Add(Me.pnlCabecera)
            Me.gbLeyenda.Controls.Add(Me.pnlCuerpo)
            Me.gbLeyenda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbLeyenda.Location = New System.Drawing.Point(0, 0)
            Me.gbLeyenda.Name = "gbLeyenda"
            Me.gbLeyenda.Size = New System.Drawing.Size(503, 145)
            Me.gbLeyenda.TabIndex = 3
            Me.gbLeyenda.TabStop = False
            Me.gbLeyenda.Text = "Resultados de la validación"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.BackColor = System.Drawing.Color.MidnightBlue
            Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlCabecera.Controls.Add(Me.lblCabecera)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlCabecera.Location = New System.Drawing.Point(3, 16)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(497, 46)
            Me.pnlCabecera.TabIndex = 38
            '
            'lblCabecera
            '
            Me.lblCabecera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCabecera.AutoSize = True
            Me.lblCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCabecera.ForeColor = System.Drawing.Color.White
            Me.lblCabecera.Location = New System.Drawing.Point(135, 8)
            Me.lblCabecera.Name = "lblCabecera"
            Me.lblCabecera.Size = New System.Drawing.Size(203, 18)
            Me.lblCabecera.TabIndex = 2
            Me.lblCabecera.Text = "1 Nueva Autenticacion 1:1"
            Me.lblCabecera.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'pnlCuerpo
            '
            Me.pnlCuerpo.BackColor = System.Drawing.Color.ForestGreen
            Me.pnlCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlCuerpo.Controls.Add(Me.lblCuerpo2)
            Me.pnlCuerpo.Controls.Add(Me.lblCuerpo1)
            Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlCuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlCuerpo.Location = New System.Drawing.Point(3, 62)
            Me.pnlCuerpo.Name = "pnlCuerpo"
            Me.pnlCuerpo.Size = New System.Drawing.Size(497, 80)
            Me.pnlCuerpo.TabIndex = 37
            '
            'lblCuerpo2
            '
            Me.lblCuerpo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCuerpo2.AutoSize = True
            Me.lblCuerpo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCuerpo2.ForeColor = System.Drawing.Color.White
            Me.lblCuerpo2.Location = New System.Drawing.Point(112, 20)
            Me.lblCuerpo2.Name = "lblCuerpo2"
            Me.lblCuerpo2.Size = New System.Drawing.Size(264, 52)
            Me.lblCuerpo2.TabIndex = 2
            Me.lblCuerpo2.Text = "La primera impresion dactilar capturada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "corresponde al DNI consultadoo. La segun" &
    "da" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "impresion dactilar capturada corresponde al" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DNI consultado."
            Me.lblCuerpo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'lblCuerpo1
            '
            Me.lblCuerpo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblCuerpo1.AutoSize = True
            Me.lblCuerpo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblCuerpo1.ForeColor = System.Drawing.Color.White
            Me.lblCuerpo1.Location = New System.Drawing.Point(171, 1)
            Me.lblCuerpo1.Name = "lblCuerpo1"
            Me.lblCuerpo1.Size = New System.Drawing.Size(138, 18)
            Me.lblCuerpo1.TabIndex = 1
            Me.lblCuerpo1.Text = "CORRESPONDE"
            Me.lblCuerpo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'UscVisorHuellas1
            '
            Me.UscVisorHuellas1._ApeMat = ""
            Me.UscVisorHuellas1._ApePat = ""
            Me.UscVisorHuellas1._CodRP = ""
            Me.UscVisorHuellas1._InternoId = 0
            Me.UscVisorHuellas1._Nombres = ""
            Me.UscVisorHuellas1._NumDocIdent = ""
            Me.UscVisorHuellas1._PenId = 0
            Me.UscVisorHuellas1._RegId = 0
            Me.UscVisorHuellas1._TipDocIdentId = -1
            Me.UscVisorHuellas1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscVisorHuellas1.lblhuelladerecha = "Mano Izquierda"
            Me.UscVisorHuellas1.lblhuellaizquierda = "Mano Izquierda"
            Me.UscVisorHuellas1.Location = New System.Drawing.Point(0, 290)
            Me.UscVisorHuellas1.Name = "UscVisorHuellas1"
            Me.UscVisorHuellas1.Size = New System.Drawing.Size(503, 155)
            Me.UscVisorHuellas1.TabIndex = 49
            '
            'frmValidarHuella
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(996, 493)
            Me.Controls.Add(Me.Panel5)
            Me.Controls.Add(Me.pnlDatosInterno)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmValidarHuella"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Validacion de identidad "
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.pnlVerificar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlDatosInterno.ResumeLayout(False)
            Me.gbDatosInterno.ResumeLayout(False)
            Me.gbDatosInterno.PerformLayout()
            Me.pnlFotoVis.ResumeLayout(False)
            CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.pnlLeyenda.ResumeLayout(False)
            Me.gbLeyenda.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.pnlCuerpo.ResumeLayout(False)
            Me.pnlCuerpo.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlVerificar As Panel
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnVerifHuella As Button
        Friend WithEvents pnlDatosInterno As Panel
        Friend WithEvents Panel5 As Panel
        Friend WithEvents pnlGrabar As Panel
        Friend WithEvents btnGrabar As Button
        Friend WithEvents gbDatosInterno As GroupBox
        Friend WithEvents pnlFotoVis As Panel
        Friend WithEvents picFoto As PictureBox
        Friend WithEvents lblTitulo As Label
        Friend WithEvents ckbHuellas As CheckBox
        Friend WithEvents txtFechaNac As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtSexo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label47 As Label
        Friend WithEvents txtPrimerApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label49 As Label
        Friend WithEvents Label50 As Label
        Friend WithEvents txtPrenombres As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label51 As Label
        Friend WithEvents txtSegundoApellido As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label52 As Label
        Friend WithEvents txtDni As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label48 As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents UscVisorHuellas1 As APPControls.Registro.Huellas.uscVisorHuellas
        Friend WithEvents UscVisorHuellas2 As APPControls.Registro.Huellas.uscVisorHuellas
        Friend WithEvents UscDatosInternoReniec1 As APPControls.Registro.Huellas.uscDatosInternoReniec
        Friend WithEvents pnlLeyenda As Panel
        Friend WithEvents gbLeyenda As GroupBox
        Friend WithEvents pnlCabecera As Panel
        Friend WithEvents lblCabecera As Label
        Friend WithEvents pnlCuerpo As Panel
        Friend WithEvents lblCuerpo2 As Label
        Friend WithEvents lblCuerpo1 As Label
        Friend WithEvents lblmensaje As Label
    End Class

End Namespace