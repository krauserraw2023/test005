
Namespace Mantenimiento.Registro.Delito
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMant_v2
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtDelGenCod = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtMotivoBaja = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbEstado = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtCodDelEsp = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtArticulo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.lblAgregar = New System.Windows.Forms.Label()
            Me.txtGrupoEspecifico = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.txtGrupoGenerico = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cbbTipo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.chkEspecificoPadre = New System.Windows.Forms.CheckBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbbDelGenerico = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cbbDelCapitulo = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtDelEspPadreCod = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbDelSeccion = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtDelGenSecc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbDelEspPadre = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtDelGenCap = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(633, 432)
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 63)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(51, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Capitulo :"
            '
            'txtDelGenCod
            '
            Me.txtDelGenCod._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelGenCod._BloquearPaste = False
            Me.txtDelGenCod._SeleccionarTodo = False
            Me.txtDelGenCod.Location = New System.Drawing.Point(529, 34)
            Me.txtDelGenCod.Name = "txtDelGenCod"
            Me.txtDelGenCod.ReadOnly = True
            Me.txtDelGenCod.Size = New System.Drawing.Size(86, 20)
            Me.txtDelGenCod.TabIndex = 11
            Me.txtDelGenCod.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelGenCod.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 91)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(52, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Seccion :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(9, 37)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(91, 13)
            Me.Label11.TabIndex = 2
            Me.Label11.Text = "Generico (Titulo) :"
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(103, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(3, 3)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 0
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 432)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(633, 47)
            Me.Panel1.TabIndex = 1
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(429, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(204, 47)
            Me.Panel2.TabIndex = 0
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.Panel5)
            Me.GroupBox1.Controls.Add(Me.Panel4)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(633, 432)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.txtNombre)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Controls.Add(Me.Label10)
            Me.Panel3.Controls.Add(Me.Label9)
            Me.Panel3.Controls.Add(Me.Label15)
            Me.Panel3.Controls.Add(Me.Label12)
            Me.Panel3.Controls.Add(Me.txtMotivoBaja)
            Me.Panel3.Controls.Add(Me.txtObs)
            Me.Panel3.Controls.Add(Me.cbbEstado)
            Me.Panel3.Controls.Add(Me.txtCodDelEsp)
            Me.Panel3.Controls.Add(Me.txtArticulo)
            Me.Panel3.Controls.Add(Me.Label14)
            Me.Panel3.Controls.Add(Me.Label13)
            Me.Panel3.Location = New System.Drawing.Point(3, 156)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(627, 177)
            Me.Panel3.TabIndex = 1
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(130, 11)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(342, 20)
            Me.txtNombre.TabIndex = 2
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 66)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 13)
            Me.Label1.TabIndex = 7
            Me.Label1.Text = "Observacion :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 13)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(62, 13)
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Especifico :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(478, 13)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(43, 13)
            Me.Label9.TabIndex = 3
            Me.Label9.Text = "Codigo:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(6, 153)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(69, 13)
            Me.Label15.TabIndex = 11
            Me.Label15.Text = "Motivo Baja :"
            '
            'Label12
            '
            Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label12.Location = New System.Drawing.Point(8, 2)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(608, 4)
            Me.Label12.TabIndex = 0
            '
            'txtMotivoBaja
            '
            Me.txtMotivoBaja._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMotivoBaja._BloquearPaste = False
            Me.txtMotivoBaja._SeleccionarTodo = False
            Me.txtMotivoBaja.Enabled = False
            Me.txtMotivoBaja.Location = New System.Drawing.Point(130, 151)
            Me.txtMotivoBaja.Name = "txtMotivoBaja"
            Me.txtMotivoBaja.Size = New System.Drawing.Size(479, 20)
            Me.txtMotivoBaja.TabIndex = 12
            Me.txtMotivoBaja.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMotivoBaja.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Location = New System.Drawing.Point(130, 63)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(479, 55)
            Me.txtObs.TabIndex = 8
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbEstado
            '
            Me.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbEstado.FormattingEnabled = True
            Me.cbbEstado.Location = New System.Drawing.Point(130, 124)
            Me.cbbEstado.Name = "cbbEstado"
            Me.cbbEstado.Size = New System.Drawing.Size(127, 21)
            Me.cbbEstado.TabIndex = 10
            '
            'txtCodDelEsp
            '
            Me.txtCodDelEsp._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCodDelEsp._BloquearPaste = False
            Me.txtCodDelEsp._SeleccionarTodo = False
            Me.txtCodDelEsp.Location = New System.Drawing.Point(523, 11)
            Me.txtCodDelEsp.Name = "txtCodDelEsp"
            Me.txtCodDelEsp.Size = New System.Drawing.Size(86, 20)
            Me.txtCodDelEsp.TabIndex = 4
            Me.txtCodDelEsp.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodDelEsp.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtArticulo
            '
            Me.txtArticulo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtArticulo._BloquearPaste = False
            Me.txtArticulo._SeleccionarTodo = False
            Me.txtArticulo.Location = New System.Drawing.Point(130, 37)
            Me.txtArticulo.MaxLength = 20
            Me.txtArticulo.Name = "txtArticulo"
            Me.txtArticulo.Size = New System.Drawing.Size(127, 20)
            Me.txtArticulo.TabIndex = 6
            Me.txtArticulo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtArticulo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(6, 128)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(49, 13)
            Me.Label14.TabIndex = 9
            Me.Label14.Text = "Estado : "
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(6, 40)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(48, 13)
            Me.Label13.TabIndex = 5
            Me.Label13.Text = "Articulo :"
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.GroupBox2)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(3, 333)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(627, 96)
            Me.Panel5.TabIndex = 1
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.lblAgregar)
            Me.GroupBox2.Controls.Add(Me.txtGrupoEspecifico)
            Me.GroupBox2.Controls.Add(Me.btnAgregar)
            Me.GroupBox2.Controls.Add(Me.txtGrupoGenerico)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(627, 96)
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos de Estadistica"
            '
            'lblAgregar
            '
            Me.lblAgregar.AutoSize = True
            Me.lblAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblAgregar.Location = New System.Drawing.Point(158, 15)
            Me.lblAgregar.Name = "lblAgregar"
            Me.lblAgregar.Size = New System.Drawing.Size(280, 13)
            Me.lblAgregar.TabIndex = 1
            Me.lblAgregar.Text = "Asignar Grupo del Cuadro 002-Padin Formato 01"
            '
            'txtGrupoEspecifico
            '
            Me.txtGrupoEspecifico._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGrupoEspecifico._BloquearPaste = False
            Me.txtGrupoEspecifico._SeleccionarTodo = False
            Me.txtGrupoEspecifico.Location = New System.Drawing.Point(130, 61)
            Me.txtGrupoEspecifico.Name = "txtGrupoEspecifico"
            Me.txtGrupoEspecifico.ReadOnly = True
            Me.txtGrupoEspecifico.Size = New System.Drawing.Size(342, 20)
            Me.txtGrupoEspecifico.TabIndex = 5
            Me.txtGrupoEspecifico.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGrupoEspecifico.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'btnAgregar
            '
            Me.btnAgregar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregar.Location = New System.Drawing.Point(130, 9)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(26, 23)
            Me.btnAgregar.TabIndex = 0
            '
            'txtGrupoGenerico
            '
            Me.txtGrupoGenerico._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtGrupoGenerico._BloquearPaste = False
            Me.txtGrupoGenerico._SeleccionarTodo = False
            Me.txtGrupoGenerico.Location = New System.Drawing.Point(130, 36)
            Me.txtGrupoGenerico.Name = "txtGrupoGenerico"
            Me.txtGrupoGenerico.ReadOnly = True
            Me.txtGrupoGenerico.Size = New System.Drawing.Size(342, 20)
            Me.txtGrupoGenerico.TabIndex = 3
            Me.txtGrupoGenerico.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtGrupoGenerico.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 42)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(88, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Grupo Generico :"
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(7, 64)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(94, 13)
            Me.Label17.TabIndex = 4
            Me.Label17.Text = "Grupo Especifico :"
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.cbbTipo)
            Me.Panel4.Controls.Add(Me.chkEspecificoPadre)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.Label11)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.Label16)
            Me.Panel4.Controls.Add(Me.cbbDelGenerico)
            Me.Panel4.Controls.Add(Me.Label8)
            Me.Panel4.Controls.Add(Me.cbbDelCapitulo)
            Me.Panel4.Controls.Add(Me.txtDelEspPadreCod)
            Me.Panel4.Controls.Add(Me.cbbDelSeccion)
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Controls.Add(Me.txtDelGenCod)
            Me.Panel4.Controls.Add(Me.txtDelGenSecc)
            Me.Panel4.Controls.Add(Me.cbbDelEspPadre)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.txtDelGenCap)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(3, 16)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(627, 140)
            Me.Panel4.TabIndex = 0
            '
            'cbbTipo
            '
            Me.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipo.FormattingEnabled = True
            Me.cbbTipo.Location = New System.Drawing.Point(130, 7)
            Me.cbbTipo.Name = "cbbTipo"
            Me.cbbTipo.Size = New System.Drawing.Size(342, 21)
            Me.cbbTipo.TabIndex = 1
            '
            'chkEspecificoPadre
            '
            Me.chkEspecificoPadre.AutoSize = True
            Me.chkEspecificoPadre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkEspecificoPadre.Location = New System.Drawing.Point(8, 116)
            Me.chkEspecificoPadre.Name = "chkEspecificoPadre"
            Me.chkEspecificoPadre.Size = New System.Drawing.Size(112, 17)
            Me.chkEspecificoPadre.TabIndex = 8
            Me.chkEspecificoPadre.Text = "Especifico Padre :"
            Me.chkEspecificoPadre.UseVisualStyleBackColor = True
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(9, 10)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(34, 13)
            Me.Label16.TabIndex = 0
            Me.Label16.Text = "Tipo :"
            '
            'cbbDelGenerico
            '
            Me.cbbDelGenerico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDelGenerico.FormattingEnabled = True
            Me.cbbDelGenerico.Location = New System.Drawing.Point(130, 34)
            Me.cbbDelGenerico.Name = "cbbDelGenerico"
            Me.cbbDelGenerico.Size = New System.Drawing.Size(342, 21)
            Me.cbbDelGenerico.TabIndex = 3
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(478, 115)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(43, 13)
            Me.Label8.TabIndex = 16
            Me.Label8.Text = "Codigo:"
            '
            'cbbDelCapitulo
            '
            Me.cbbDelCapitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDelCapitulo.FormattingEnabled = True
            Me.cbbDelCapitulo.Location = New System.Drawing.Point(130, 59)
            Me.cbbDelCapitulo.Name = "cbbDelCapitulo"
            Me.cbbDelCapitulo.Size = New System.Drawing.Size(342, 21)
            Me.cbbDelCapitulo.TabIndex = 5
            '
            'txtDelEspPadreCod
            '
            Me.txtDelEspPadreCod._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelEspPadreCod._BloquearPaste = False
            Me.txtDelEspPadreCod._SeleccionarTodo = False
            Me.txtDelEspPadreCod.Location = New System.Drawing.Point(529, 113)
            Me.txtDelEspPadreCod.Name = "txtDelEspPadreCod"
            Me.txtDelEspPadreCod.ReadOnly = True
            Me.txtDelEspPadreCod.Size = New System.Drawing.Size(86, 20)
            Me.txtDelEspPadreCod.TabIndex = 17
            Me.txtDelEspPadreCod.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelEspPadreCod.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'cbbDelSeccion
            '
            Me.cbbDelSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDelSeccion.FormattingEnabled = True
            Me.cbbDelSeccion.Location = New System.Drawing.Point(130, 86)
            Me.cbbDelSeccion.Name = "cbbDelSeccion"
            Me.cbbDelSeccion.Size = New System.Drawing.Size(342, 21)
            Me.cbbDelSeccion.TabIndex = 7
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(478, 89)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(43, 13)
            Me.Label7.TabIndex = 14
            Me.Label7.Text = "Codigo:"
            '
            'txtDelGenSecc
            '
            Me.txtDelGenSecc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelGenSecc._BloquearPaste = False
            Me.txtDelGenSecc._SeleccionarTodo = False
            Me.txtDelGenSecc.Location = New System.Drawing.Point(529, 86)
            Me.txtDelGenSecc.Name = "txtDelGenSecc"
            Me.txtDelGenSecc.ReadOnly = True
            Me.txtDelGenSecc.Size = New System.Drawing.Size(86, 20)
            Me.txtDelGenSecc.TabIndex = 15
            Me.txtDelGenSecc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelGenSecc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'cbbDelEspPadre
            '
            Me.cbbDelEspPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbDelEspPadre.Enabled = False
            Me.cbbDelEspPadre.FormattingEnabled = True
            Me.cbbDelEspPadre.Location = New System.Drawing.Point(130, 113)
            Me.cbbDelEspPadre.Name = "cbbDelEspPadre"
            Me.cbbDelEspPadre.Size = New System.Drawing.Size(342, 21)
            Me.cbbDelEspPadre.TabIndex = 9
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(478, 63)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(43, 13)
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Codigo:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(478, 37)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(43, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "Codigo:"
            '
            'txtDelGenCap
            '
            Me.txtDelGenCap._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDelGenCap._BloquearPaste = False
            Me.txtDelGenCap._SeleccionarTodo = False
            Me.txtDelGenCap.Location = New System.Drawing.Point(529, 59)
            Me.txtDelGenCap.Name = "txtDelGenCap"
            Me.txtDelGenCap.ReadOnly = True
            Me.txtDelGenCap.Size = New System.Drawing.Size(86, 20)
            Me.txtDelGenCap.TabIndex = 13
            Me.txtDelGenCap.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDelGenCap.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'frmMant_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(633, 479)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMant_v2"
            Me.Text = "Mantenimiento de Delitos"
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtDelGenCod As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbDelGenerico As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtDelEspPadreCod As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtDelGenSecc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtDelGenCap As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbDelEspPadre As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbDelSeccion As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbDelCapitulo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents cbbTipo As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents chkEspecificoPadre As System.Windows.Forms.CheckBox
        Friend WithEvents Panel3 As Panel
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents txtMotivoBaja As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbEstado As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents txtCodDelEsp As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtArticulo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label14 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Panel5 As Panel
        Friend WithEvents lblAgregar As Label
        Friend WithEvents btnAgregar As Button
        Friend WithEvents Label17 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Panel4 As Panel
        Friend WithEvents txtGrupoEspecifico As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtGrupoGenerico As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox2 As GroupBox
    End Class
End Namespace

