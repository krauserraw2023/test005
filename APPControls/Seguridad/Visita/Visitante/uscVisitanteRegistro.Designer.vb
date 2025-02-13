Namespace Visita.Visitante

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscVisitanteRegistro
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
            Me.pnlVisitante = New System.Windows.Forms.Panel()
            Me.pnlDatos = New System.Windows.Forms.Panel()
            Me.pbHuellaObs = New System.Windows.Forms.PictureBox()
            Me.pnlDatosVisitante = New System.Windows.Forms.Panel()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.CbbSexo = New APPControls.uscComboParametrica()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.lblCampoPase = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblMensaje = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtPaseNumero = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.pnlFotografia = New System.Windows.Forms.Panel()
            Me.pnlBotones = New System.Windows.Forms.Panel()
            Me.btnGrabarVisitante = New System.Windows.Forms.Button()
            Me.btnCapurar = New System.Windows.Forms.Button()
            Me.btnMenores = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.UscFotografia1 = New APPControls.Foto.uscFotografia()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
            Me.pnlVisitante.SuspendLayout()
            Me.pnlDatos.SuspendLayout()
            CType(Me.pbHuellaObs, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlDatosVisitante.SuspendLayout()
            Me.pnlFotografia.SuspendLayout()
            Me.pnlBotones.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlVisitante
            '
            Me.pnlVisitante.Controls.Add(Me.pnlDatos)
            Me.pnlVisitante.Controls.Add(Me.pnlFotografia)
            Me.pnlVisitante.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlVisitante.Location = New System.Drawing.Point(0, 0)
            Me.pnlVisitante.Name = "pnlVisitante"
            Me.pnlVisitante.Size = New System.Drawing.Size(492, 262)
            Me.pnlVisitante.TabIndex = 0
            '
            'pnlDatos
            '
            Me.pnlDatos.Controls.Add(Me.pbHuellaObs)
            Me.pnlDatos.Controls.Add(Me.pnlDatosVisitante)
            Me.pnlDatos.Controls.Add(Me.btnBuscar)
            Me.pnlDatos.Controls.Add(Me.cbbTipoDoc)
            Me.pnlDatos.Controls.Add(Me.lblCampoPase)
            Me.pnlDatos.Controls.Add(Me.txtNumDoc)
            Me.pnlDatos.Controls.Add(Me.lblMensaje)
            Me.pnlDatos.Controls.Add(Me.Label10)
            Me.pnlDatos.Controls.Add(Me.txtPaseNumero)
            Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDatos.Location = New System.Drawing.Point(158, 0)
            Me.pnlDatos.Name = "pnlDatos"
            Me.pnlDatos.Size = New System.Drawing.Size(334, 262)
            Me.pnlDatos.TabIndex = 0
            '
            'pbHuellaObs
            '
            Me.pbHuellaObs.BackColor = System.Drawing.Color.White
            Me.pbHuellaObs.Image = Global.APPControls.My.Resources.Resources.huella_x
            Me.pbHuellaObs.Location = New System.Drawing.Point(281, 42)
            Me.pbHuellaObs.Name = "pbHuellaObs"
            Me.pbHuellaObs.Size = New System.Drawing.Size(48, 35)
            Me.pbHuellaObs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pbHuellaObs.TabIndex = 99
            Me.pbHuellaObs.TabStop = False
            Me.pbHuellaObs.Visible = False
            '
            'pnlDatosVisitante
            '
            Me.pnlDatosVisitante.Controls.Add(Me.txtApePat)
            Me.pnlDatosVisitante.Controls.Add(Me.Label7)
            Me.pnlDatosVisitante.Controls.Add(Me.CbbSexo)
            Me.pnlDatosVisitante.Controls.Add(Me.Label6)
            Me.pnlDatosVisitante.Controls.Add(Me.cbbNacionalidad)
            Me.pnlDatosVisitante.Controls.Add(Me.txtNom)
            Me.pnlDatosVisitante.Controls.Add(Me.Label5)
            Me.pnlDatosVisitante.Controls.Add(Me.txtApeMat)
            Me.pnlDatosVisitante.Controls.Add(Me.Label12)
            Me.pnlDatosVisitante.Controls.Add(Me.dtpFechaNac)
            Me.pnlDatosVisitante.Controls.Add(Me.Label4)
            Me.pnlDatosVisitante.Controls.Add(Me.Label9)
            Me.pnlDatosVisitante.Enabled = False
            Me.pnlDatosVisitante.Location = New System.Drawing.Point(4, 81)
            Me.pnlDatosVisitante.Name = "pnlDatosVisitante"
            Me.pnlDatosVisitante.Size = New System.Drawing.Size(323, 128)
            Me.pnlDatosVisitante.TabIndex = 98
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(105, 2)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(208, 20)
            Me.txtApePat.TabIndex = 7
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(3, 79)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Nacionalidad :"
            '
            'CbbSexo
            '
            Me.CbbSexo._NoIndica = False
            Me.CbbSexo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.CbbSexo._Todos = False
            Me.CbbSexo._TodosMensaje = ""
            Me.CbbSexo._Visible_Add = False
            Me.CbbSexo._Visible_Buscar = False
            Me.CbbSexo._Visible_Eliminar = False
            Me.CbbSexo.CodigoPadre = -1
            Me.CbbSexo.ComboTipo = CType(0, Short)
            Me.CbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.CbbSexo.DropDownWidth = 69
            Me.CbbSexo.DropDownWidthAuto = False
            Me.CbbSexo.ListaIdsParaExcluir = Nothing
            Me.CbbSexo.Location = New System.Drawing.Point(253, 76)
            Me.CbbSexo.ModuloTratamiento = False
            Me.CbbSexo.Name = "CbbSexo"
            Me.CbbSexo.Parametro1 = -1
            Me.CbbSexo.Parametro2 = -1
            Me.CbbSexo.SelectedIndex = -1
            Me.CbbSexo.SelectedValue = 0
            Me.CbbSexo.Size = New System.Drawing.Size(60, 22)
            Me.CbbSexo.TabIndex = 11
            Me.CbbSexo.verToolTipItemSeleccionado = False
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(217, 79)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Sexo :"
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = CType(0, Short)
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 210
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(105, 76)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(106, 22)
            Me.cbbNacionalidad.TabIndex = 10
            Me.cbbNacionalidad.verToolTipItemSeleccionado = False
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(105, 50)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(208, 20)
            Me.txtNom.TabIndex = 9
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(3, 54)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Nombres :"
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.Location = New System.Drawing.Point(105, 26)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(208, 20)
            Me.txtApeMat.TabIndex = 8
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(3, 108)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(99, 13)
            Me.Label12.TabIndex = 88
            Me.Label12.Text = "Fecha Nacimiento :"
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(105, 104)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 12
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(3, 30)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(96, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Segundo Apellido :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(3, 5)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(82, 13)
            Me.Label9.TabIndex = 9
            Me.Label9.Text = "Primer Apellido :"
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImage = Global.APPControls.My.Resources.Resources.view
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Location = New System.Drawing.Point(245, 42)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(35, 35)
            Me.btnBuscar.TabIndex = 97
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
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
            Me.cbbTipoDoc.ComboTipo = CType(0, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 200
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(212, 9)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(115, 22)
            Me.cbbTipoDoc.TabIndex = 94
            Me.cbbTipoDoc.verToolTipItemSeleccionado = False
            '
            'lblCampoPase
            '
            Me.lblCampoPase.AutoSize = True
            Me.lblCampoPase.Location = New System.Drawing.Point(6, 13)
            Me.lblCampoPase.Name = "lblCampoPase"
            Me.lblCampoPase.Size = New System.Drawing.Size(37, 13)
            Me.lblCampoPase.TabIndex = 80
            Me.lblCampoPase.Text = "Pase :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = True
            Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDoc.Location = New System.Drawing.Point(109, 42)
            Me.txtNumDoc.MaxLength = 8
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(135, 35)
            Me.txtNumDoc.TabIndex = 6
            Me.txtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'lblMensaje
            '
            Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblMensaje.ForeColor = System.Drawing.Color.Red
            Me.lblMensaje.Location = New System.Drawing.Point(5, 209)
            Me.lblMensaje.Name = "lblMensaje"
            Me.lblMensaje.Size = New System.Drawing.Size(324, 53)
            Me.lblMensaje.TabIndex = 92
            Me.lblMensaje.Text = "Seleccion el tipo de documento e ingrese el numero de documento, luego presione l" &
    "a tecla [Enter]"
            Me.lblMensaje.Visible = False
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 54)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 13)
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Num Doc. :"
            '
            'txtPaseNumero
            '
            Me.txtPaseNumero._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPaseNumero._BloquearPaste = False
            Me.txtPaseNumero._SeleccionarTodo = True
            Me.txtPaseNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPaseNumero.ForeColor = System.Drawing.Color.Red
            Me.txtPaseNumero.Location = New System.Drawing.Point(109, 5)
            Me.txtPaseNumero.MaxLength = 5
            Me.txtPaseNumero.Name = "txtPaseNumero"
            Me.txtPaseNumero.Size = New System.Drawing.Size(97, 32)
            Me.txtPaseNumero.TabIndex = 5
            Me.txtPaseNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtPaseNumero.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPaseNumero.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'pnlFotografia
            '
            Me.pnlFotografia.BackColor = System.Drawing.Color.White
            Me.pnlFotografia.Controls.Add(Me.pnlBotones)
            Me.pnlFotografia.Controls.Add(Me.UscFotografia1)
            Me.pnlFotografia.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFotografia.Location = New System.Drawing.Point(0, 0)
            Me.pnlFotografia.Name = "pnlFotografia"
            Me.pnlFotografia.Size = New System.Drawing.Size(158, 262)
            Me.pnlFotografia.TabIndex = 6
            '
            'pnlBotones
            '
            Me.pnlBotones.Controls.Add(Me.btnGrabarVisitante)
            Me.pnlBotones.Controls.Add(Me.btnCapurar)
            Me.pnlBotones.Controls.Add(Me.btnMenores)
            Me.pnlBotones.Controls.Add(Me.btnLimpiar)
            Me.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBotones.Location = New System.Drawing.Point(0, 215)
            Me.pnlBotones.Name = "pnlBotones"
            Me.pnlBotones.Size = New System.Drawing.Size(158, 47)
            Me.pnlBotones.TabIndex = 13
            '
            'btnGrabarVisitante
            '
            Me.btnGrabarVisitante.Enabled = False
            Me.btnGrabarVisitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarVisitante.ForeColor = System.Drawing.Color.Black
            Me.btnGrabarVisitante.Image = Global.APPControls.My.Resources.Resources.Drive___USB_32
            Me.btnGrabarVisitante.Location = New System.Drawing.Point(4, 3)
            Me.btnGrabarVisitante.Name = "btnGrabarVisitante"
            Me.btnGrabarVisitante.Size = New System.Drawing.Size(50, 38)
            Me.btnGrabarVisitante.TabIndex = 14
            Me.btnGrabarVisitante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGrabarVisitante.UseVisualStyleBackColor = True
            '
            'btnCapurar
            '
            Me.btnCapurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnCapurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapurar.ForeColor = System.Drawing.Color.Black
            Me.btnCapurar.Image = Global.APPControls.My.Resources.Resources._1337706653_webcam
            Me.btnCapurar.Location = New System.Drawing.Point(54, 3)
            Me.btnCapurar.Name = "btnCapurar"
            Me.btnCapurar.Size = New System.Drawing.Size(50, 38)
            Me.btnCapurar.TabIndex = 76
            Me.btnCapurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCapurar.UseVisualStyleBackColor = True
            '
            'btnMenores
            '
            Me.btnMenores.BackgroundImage = Global.APPControls.My.Resources.Resources.boy
            Me.btnMenores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnMenores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnMenores.ForeColor = System.Drawing.Color.Black
            Me.btnMenores.Location = New System.Drawing.Point(104, 3)
            Me.btnMenores.Name = "btnMenores"
            Me.btnMenores.Size = New System.Drawing.Size(50, 38)
            Me.btnMenores.TabIndex = 81
            Me.btnMenores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnMenores.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.BackgroundImage = Global.APPControls.My.Resources.Resources.replace2
            Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
            Me.btnLimpiar.Location = New System.Drawing.Point(104, 3)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(50, 38)
            Me.btnLimpiar.TabIndex = 96
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'UscFotografia1
            '
            Me.UscFotografia1._CheckImagen = True
            Me.UscFotografia1._EnabledDobleClick = True
            Me.UscFotografia1._HasImagen = False
            Me.UscFotografia1._PanelAutorizacion = False
            Me.UscFotografia1._PanelCheck = False
            Me.UscFotografia1.Location = New System.Drawing.Point(3, 5)
            Me.UscFotografia1.Name = "UscFotografia1"
            Me.UscFotografia1.Size = New System.Drawing.Size(150, 190)
            Me.UscFotografia1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
            Me.UscFotografia1.TabIndex = 78
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'BackgroundWorker2
            '
            Me.BackgroundWorker2.WorkerSupportsCancellation = True
            '
            'uscVisitanteRegistro
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlVisitante)
            Me.Name = "uscVisitanteRegistro"
            Me.Size = New System.Drawing.Size(492, 262)
            Me.pnlVisitante.ResumeLayout(False)
            Me.pnlDatos.ResumeLayout(False)
            Me.pnlDatos.PerformLayout()
            CType(Me.pbHuellaObs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlDatosVisitante.ResumeLayout(False)
            Me.pnlDatosVisitante.PerformLayout()
            Me.pnlFotografia.ResumeLayout(False)
            Me.pnlBotones.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlVisitante As System.Windows.Forms.Panel
        Friend WithEvents lblMensaje As System.Windows.Forms.Label
        Friend WithEvents btnMenores As System.Windows.Forms.Button
        Friend WithEvents UscFotografia1 As APPControls.Foto.uscFotografia
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtPaseNumero As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblCampoPase As System.Windows.Forms.Label
        Friend WithEvents btnGrabarVisitante As System.Windows.Forms.Button
        Friend WithEvents btnCapurar As System.Windows.Forms.Button
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents pnlDatos As System.Windows.Forms.Panel
        Friend WithEvents pnlFotografia As System.Windows.Forms.Panel
        Friend WithEvents pnlBotones As System.Windows.Forms.Panel
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents CbbSexo As APPControls.uscComboParametrica
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents pnlDatosVisitante As System.Windows.Forms.Panel
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents pbHuellaObs As System.Windows.Forms.PictureBox
        Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    End Class
End Namespace