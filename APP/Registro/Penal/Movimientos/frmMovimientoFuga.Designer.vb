Namespace Registro.Movimientos
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMovimientoFuga
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.grpMovimiento = New System.Windows.Forms.GroupBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.PnlOtraAutoridad = New System.Windows.Forms.Panel()
            Me.txtOtraAutoridadCargo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtOtraAutoridadNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.PnlAutoridadJudicial = New System.Windows.Forms.Panel()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.PnlAutJudPrin = New System.Windows.Forms.Panel()
            Me.cbbTipoAutJud = New APPControls.uscComboParametrica()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpDocJudFecRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtNumDocumento = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.gbSiNO = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnCargarDocumento = New Legolas.APPUIComponents.myButton()
            Me.rbtNo = New System.Windows.Forms.RadioButton()
            Me.rbtSi = New System.Windows.Forms.RadioButton()
            Me.uscMovDet = New APPControls.Registro.uscMovimientoDetalle()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.PnlInferior = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grpMovimiento.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.PnlOtraAutoridad.SuspendLayout()
            Me.PnlAutoridadJudicial.SuspendLayout()
            Me.PnlAutJudPrin.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.gbSiNO.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.PnlInferior.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grpMovimiento)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlInferior)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(671, 490)
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(555, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(460, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(93, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grpMovimiento
            '
            Me.grpMovimiento.Controls.Add(Me.GroupBox1)
            Me.grpMovimiento.Controls.Add(Me.gbSiNO)
            Me.grpMovimiento.Controls.Add(Me.uscMovDet)
            Me.grpMovimiento.Controls.Add(Me.PnlBotones)
            Me.grpMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpMovimiento.Location = New System.Drawing.Point(0, 0)
            Me.grpMovimiento.Name = "grpMovimiento"
            Me.grpMovimiento.Size = New System.Drawing.Size(671, 443)
            Me.grpMovimiento.TabIndex = 0
            Me.grpMovimiento.TabStop = False
            Me.grpMovimiento.Text = "Movimiento"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.PnlOtraAutoridad)
            Me.GroupBox1.Controls.Add(Me.PnlAutoridadJudicial)
            Me.GroupBox1.Controls.Add(Me.PnlAutJudPrin)
            Me.GroupBox1.Controls.Add(Me.pnlCabecera)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(3, 197)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(665, 196)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            '
            'PnlOtraAutoridad
            '
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadCargo)
            Me.PnlOtraAutoridad.Controls.Add(Me.txtOtraAutoridadNombre)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label4)
            Me.PnlOtraAutoridad.Controls.Add(Me.Label3)
            Me.PnlOtraAutoridad.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlOtraAutoridad.Location = New System.Drawing.Point(3, 149)
            Me.PnlOtraAutoridad.Name = "PnlOtraAutoridad"
            Me.PnlOtraAutoridad.Size = New System.Drawing.Size(659, 47)
            Me.PnlOtraAutoridad.TabIndex = 3
            '
            'txtOtraAutoridadCargo
            '
            Me.txtOtraAutoridadCargo._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadCargo._BloquearPaste = False
            Me.txtOtraAutoridadCargo._SeleccionarTodo = False
            Me.txtOtraAutoridadCargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadCargo.Location = New System.Drawing.Point(103, 24)
            Me.txtOtraAutoridadCargo.Name = "txtOtraAutoridadCargo"
            Me.txtOtraAutoridadCargo.Size = New System.Drawing.Size(554, 20)
            Me.txtOtraAutoridadCargo.TabIndex = 3
            Me.txtOtraAutoridadCargo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadCargo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtOtraAutoridadNombre
            '
            Me.txtOtraAutoridadNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtOtraAutoridadNombre._BloquearPaste = False
            Me.txtOtraAutoridadNombre._SeleccionarTodo = False
            Me.txtOtraAutoridadNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtOtraAutoridadNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtOtraAutoridadNombre.Location = New System.Drawing.Point(103, 2)
            Me.txtOtraAutoridadNombre.Name = "txtOtraAutoridadNombre"
            Me.txtOtraAutoridadNombre.Size = New System.Drawing.Size(554, 20)
            Me.txtOtraAutoridadNombre.TabIndex = 1
            Me.txtOtraAutoridadNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtOtraAutoridadNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(4, 6)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(98, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Nombre Autoridad :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 28)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 13)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "Cargo Aut. :"
            '
            'PnlAutoridadJudicial
            '
            Me.PnlAutoridadJudicial.Controls.Add(Me.UscComboSala1)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtSecretario)
            Me.PnlAutoridadJudicial.Controls.Add(Me.txtJuez)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblDistrito)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label2)
            Me.PnlAutoridadJudicial.Controls.Add(Me.lblSala)
            Me.PnlAutoridadJudicial.Controls.Add(Me.Label11)
            Me.PnlAutoridadJudicial.Controls.Add(Me.cbbDistritoJud)
            Me.PnlAutoridadJudicial.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutoridadJudicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PnlAutoridadJudicial.Location = New System.Drawing.Point(3, 76)
            Me.PnlAutoridadJudicial.Name = "PnlAutoridadJudicial"
            Me.PnlAutoridadJudicial.Size = New System.Drawing.Size(659, 73)
            Me.PnlAutoridadJudicial.TabIndex = 2
            Me.PnlAutoridadJudicial.Visible = False
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Location = New System.Drawing.Point(103, 26)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(553, 21)
            Me.UscComboSala1.TabIndex = 3
            '
            'txtSecretario
            '
            Me.txtSecretario._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(428, 50)
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(228, 20)
            Me.txtSecretario.TabIndex = 7
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtJuez
            '
            Me.txtJuez._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Location = New System.Drawing.Point(103, 50)
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(245, 20)
            Me.txtJuez.TabIndex = 5
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(15, 7)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(63, 51)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(35, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Juez :"
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(28, 31)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(347, 55)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(61, 13)
            Me.Label11.TabIndex = 6
            Me.Label11.Text = "Secretario :"
            '
            'cbbDistritoJud
            '
            Me.cbbDistritoJud._NoIndica = False
            Me.cbbDistritoJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDistritoJud._Todos = False
            Me.cbbDistritoJud._TodosMensaje = ""
            Me.cbbDistritoJud._Visible_Add = False
            Me.cbbDistritoJud._Visible_Buscar = False
            Me.cbbDistritoJud._Visible_Eliminar = False
            Me.cbbDistritoJud.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = CType(15, Short)
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 325
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.ListaIdsParaExcluir = Nothing
            Me.cbbDistritoJud.Location = New System.Drawing.Point(103, 2)
            Me.cbbDistritoJud.ModuloTratamiento = False
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(553, 22)
            Me.cbbDistritoJud.TabIndex = 1
            '
            'PnlAutJudPrin
            '
            Me.PnlAutJudPrin.Controls.Add(Me.cbbTipoAutJud)
            Me.PnlAutJudPrin.Controls.Add(Me.Label5)
            Me.PnlAutJudPrin.Dock = System.Windows.Forms.DockStyle.Top
            Me.PnlAutJudPrin.Location = New System.Drawing.Point(3, 46)
            Me.PnlAutJudPrin.Name = "PnlAutJudPrin"
            Me.PnlAutJudPrin.Size = New System.Drawing.Size(659, 30)
            Me.PnlAutJudPrin.TabIndex = 1
            '
            'cbbTipoAutJud
            '
            Me.cbbTipoAutJud._NoIndica = False
            Me.cbbTipoAutJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoAutJud._Todos = False
            Me.cbbTipoAutJud._TodosMensaje = ""
            Me.cbbTipoAutJud._Visible_Add = False
            Me.cbbTipoAutJud._Visible_Buscar = False
            Me.cbbTipoAutJud._Visible_Eliminar = False
            Me.cbbTipoAutJud.CodigoPadre = -1
            Me.cbbTipoAutJud.ComboTipo = CType(63, Short)
            Me.cbbTipoAutJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoAutJud.DropDownWidth = 325
            Me.cbbTipoAutJud.DropDownWidthAuto = False
            Me.cbbTipoAutJud.ListaIdsParaExcluir = Nothing
            Me.cbbTipoAutJud.Location = New System.Drawing.Point(103, 4)
            Me.cbbTipoAutJud.ModuloTratamiento = False
            Me.cbbTipoAutJud.Name = "cbbTipoAutJud"
            Me.cbbTipoAutJud.Parametro1 = -1
            Me.cbbTipoAutJud.Parametro2 = -1
            Me.cbbTipoAutJud.SelectedIndex = -1
            Me.cbbTipoAutJud.SelectedValue = 0
            Me.cbbTipoAutJud.Size = New System.Drawing.Size(245, 22)
            Me.cbbTipoAutJud.TabIndex = 1
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(3, 7)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(93, 13)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Tipo de autoridad:"
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.Label30)
            Me.pnlCabecera.Controls.Add(Me.dtpDocJudFecha)
            Me.pnlCabecera.Controls.Add(Me.Label12)
            Me.pnlCabecera.Controls.Add(Me.dtpDocJudFecRecep)
            Me.pnlCabecera.Controls.Add(Me.txtNumDocumento)
            Me.pnlCabecera.Controls.Add(Me.Label6)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(3, 16)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(659, 30)
            Me.pnlCabecera.TabIndex = 0
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Location = New System.Drawing.Point(4, 8)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(83, 13)
            Me.Label30.TabIndex = 0
            Me.Label30.Text = "N° Documento :"
            '
            'dtpDocJudFecha
            '
            Me.dtpDocJudFecha.Location = New System.Drawing.Point(419, 4)
            Me.dtpDocJudFecha.Name = "dtpDocJudFecha"
            Me.dtpDocJudFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecha.TabIndex = 3
            Me.dtpDocJudFecha.Value = "/  /"
            Me.dtpDocJudFecha.ValueLong = CType(0, Long)
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(501, 8)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(72, 13)
            Me.Label12.TabIndex = 4
            Me.Label12.Text = "Fec. Recep. :"
            '
            'dtpDocJudFecRecep
            '
            Me.dtpDocJudFecRecep.Location = New System.Drawing.Point(573, 4)
            Me.dtpDocJudFecRecep.Name = "dtpDocJudFecRecep"
            Me.dtpDocJudFecRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpDocJudFecRecep.TabIndex = 5
            Me.dtpDocJudFecRecep.Value = "/  /"
            Me.dtpDocJudFecRecep.ValueLong = CType(0, Long)
            '
            'txtNumDocumento
            '
            Me.txtNumDocumento._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDocumento._BloquearPaste = False
            Me.txtNumDocumento._SeleccionarTodo = False
            Me.txtNumDocumento.Location = New System.Drawing.Point(103, 4)
            Me.txtNumDocumento.MaxLength = 120
            Me.txtNumDocumento.Name = "txtNumDocumento"
            Me.txtNumDocumento.Size = New System.Drawing.Size(245, 20)
            Me.txtNumDocumento.TabIndex = 1
            Me.txtNumDocumento.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDocumento.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(362, 8)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(60, 13)
            Me.Label6.TabIndex = 2
            Me.Label6.Text = "Fec. Doc. :"
            '
            'gbSiNO
            '
            Me.gbSiNO.Controls.Add(Me.Label1)
            Me.gbSiNO.Controls.Add(Me.btnCargarDocumento)
            Me.gbSiNO.Controls.Add(Me.rbtNo)
            Me.gbSiNO.Controls.Add(Me.rbtSi)
            Me.gbSiNO.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbSiNO.Location = New System.Drawing.Point(3, 166)
            Me.gbSiNO.Name = "gbSiNO"
            Me.gbSiNO.Size = New System.Drawing.Size(665, 31)
            Me.gbSiNO.TabIndex = 1
            Me.gbSiNO.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(3, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(126, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Referenciar Documento :"
            '
            'btnCargarDocumento
            '
            Me.btnCargarDocumento.Image = Global.SIPPOPE.My.Resources.Resources._1345240399_search_button
            Me.btnCargarDocumento.Location = New System.Drawing.Point(211, 8)
            Me.btnCargarDocumento.Name = "btnCargarDocumento"
            Me.btnCargarDocumento.Size = New System.Drawing.Size(22, 22)
            Me.btnCargarDocumento.TabIndex = 3
            Me.btnCargarDocumento.UseVisualStyleBackColor = True
            '
            'rbtNo
            '
            Me.rbtNo.AutoSize = True
            Me.rbtNo.Checked = True
            Me.rbtNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtNo.Location = New System.Drawing.Point(134, 11)
            Me.rbtNo.Name = "rbtNo"
            Me.rbtNo.Size = New System.Drawing.Size(35, 16)
            Me.rbtNo.TabIndex = 1
            Me.rbtNo.TabStop = True
            Me.rbtNo.Text = "No"
            Me.rbtNo.UseVisualStyleBackColor = True
            '
            'rbtSi
            '
            Me.rbtSi.AutoSize = True
            Me.rbtSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtSi.Location = New System.Drawing.Point(177, 12)
            Me.rbtSi.Name = "rbtSi"
            Me.rbtSi.Size = New System.Drawing.Size(31, 16)
            Me.rbtSi.TabIndex = 0
            Me.rbtSi.Text = "Si"
            Me.rbtSi.UseVisualStyleBackColor = True
            '
            'uscMovDet
            '
            Me.uscMovDet._blnNuevo = False
            Me.uscMovDet._blnVisiblecbbMotivo = True
            Me.uscMovDet._blnVisiblelblMotivo = True
            Me.uscMovDet._blnVisibleOrigenDestino = True
            Me.uscMovDet._CargarExpedientes = -1
            Me.uscMovDet._Codigo = 0
            Me.uscMovDet._Documentos_sin_mov = False
            Me.uscMovDet._DocumJudicialD = -1
            Me.uscMovDet._FechaMovimiento = CType(0, Long)
            Me.uscMovDet._IngresoID = -1
            Me.uscMovDet._intCondicionGrupo = -1
            Me.uscMovDet._InternoID = -1
            Me.uscMovDet._InternoIngresoInpeId = -1
            Me.uscMovDet._MovimientoTipoID = -1
            Me.uscMovDet._PenalDestinoID = -1
            Me.uscMovDet._PenalID = 0
            Me.uscMovDet._PenalID1 = -1
            Me.uscMovDet._PenalID2 = -1
            Me.uscMovDet._PenalMovID = 0
            Me.uscMovDet._PenalOrigenID = -1
            Me.uscMovDet._RegionDestinoID = -1
            Me.uscMovDet._RegionID = 0
            Me.uscMovDet._RegionMovID = 0
            Me.uscMovDet._RegionOrigenID = -1
            Me.uscMovDet._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.uscMovDet.BackColor = System.Drawing.Color.Transparent
            Me.uscMovDet.Dock = System.Windows.Forms.DockStyle.Top
            Me.uscMovDet.Enabletcontrol = False
            Me.uscMovDet.EstadoAuxID = 0
            Me.uscMovDet.EstadoID = -1
            Me.uscMovDet.EstadoTramite = ""
            Me.uscMovDet.EstadoTramiteID = -1
            Me.uscMovDet.Location = New System.Drawing.Point(3, 16)
            Me.uscMovDet.MovimientoGrupo = 0
            Me.uscMovDet.MovimientoGrupoNom = ""
            Me.uscMovDet.MovimientoMotivoIngreso = 0
            Me.uscMovDet.MovimientoTipo = 0
            Me.uscMovDet.Name = "uscMovDet"
            Me.uscMovDet.Observacion = ""
            Me.uscMovDet.Size = New System.Drawing.Size(665, 150)
            Me.uscMovDet.TabIndex = 0
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnAceptar)
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(3, 393)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(665, 47)
            Me.PnlBotones.TabIndex = 3
            '
            'PnlInferior
            '
            Me.PnlInferior.Controls.Add(Me.UscAuditUser1)
            Me.PnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlInferior.Location = New System.Drawing.Point(0, 443)
            Me.PnlInferior.Name = "PnlInferior"
            Me.PnlInferior.Size = New System.Drawing.Size(671, 47)
            Me.PnlInferior.TabIndex = 1
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(671, 47)
            Me.UscAuditUser1.TabIndex = 0
            '
            'frmMovimientoFuga
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(671, 490)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMovimientoFuga"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Fuga"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grpMovimiento.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.PnlOtraAutoridad.ResumeLayout(False)
            Me.PnlOtraAutoridad.PerformLayout()
            Me.PnlAutoridadJudicial.ResumeLayout(False)
            Me.PnlAutoridadJudicial.PerformLayout()
            Me.PnlAutJudPrin.ResumeLayout(False)
            Me.PnlAutJudPrin.PerformLayout()
            Me.pnlCabecera.ResumeLayout(False)
            Me.pnlCabecera.PerformLayout()
            Me.gbSiNO.ResumeLayout(False)
            Me.gbSiNO.PerformLayout()
            Me.PnlBotones.ResumeLayout(False)
            Me.PnlInferior.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents PnlInferior As System.Windows.Forms.Panel
        Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
        Friend WithEvents uscMovDet As APPControls.Registro.uscMovimientoDetalle
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents gbSiNO As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents btnCargarDocumento As Legolas.APPUIComponents.myButton
        Friend WithEvents rbtNo As System.Windows.Forms.RadioButton
        Friend WithEvents rbtSi As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents PnlAutJudPrin As System.Windows.Forms.Panel
        Friend WithEvents cbbTipoAutJud As APPControls.uscComboParametrica
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpDocJudFecRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtNumDocumento As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents PnlAutoridadJudicial As System.Windows.Forms.Panel
        Friend WithEvents UscComboSala1 As APPControls.Busqueda.uscComboSala
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents PnlOtraAutoridad As System.Windows.Forms.Panel
        Friend WithEvents txtOtraAutoridadCargo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtOtraAutoridadNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label

    End Class
End Namespace

