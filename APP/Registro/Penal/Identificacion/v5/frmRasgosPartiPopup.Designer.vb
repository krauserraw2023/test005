Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRasgosPartiPopup
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlRasgos = New System.Windows.Forms.Panel()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label23 = New System.Windows.Forms.Label()
            Me.pnlTronco = New System.Windows.Forms.Panel()
            Me.txtPeso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label25 = New System.Windows.Forms.Label()
            Me.txtTalla = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbTronco = New APPControls.uscComboParametrica()
            Me.cbbComplexion = New APPControls.uscComboParametrica()
            Me.Label27 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.pnlBoca = New System.Windows.Forms.Panel()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.cbbTipoLabio = New APPControls.uscComboParametrica()
            Me.cbbBoca = New APPControls.uscComboParametrica()
            Me.cbbLabios = New APPControls.uscComboParametrica()
            Me.pnlOreja = New System.Windows.Forms.Panel()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.cbbTipoNar = New APPControls.uscComboParametrica()
            Me.cbbOrejaDer = New APPControls.uscComboParametrica()
            Me.cbbNarizFor = New APPControls.uscComboParametrica()
            Me.pnlIris = New System.Windows.Forms.Panel()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.cbbAnomaliaOjo = New APPControls.uscComboParametrica()
            Me.cbbIris = New APPControls.uscComboParametrica()
            Me.cbbCeja = New APPControls.uscComboParametrica()
            Me.pnlCara = New System.Windows.Forms.Panel()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.cbbFormaOjo = New APPControls.uscComboParametrica()
            Me.cbbCaraFor = New APPControls.uscComboParametrica()
            Me.cbbLineaIns = New APPControls.uscComboParametrica()
            Me.pnlCalvicie = New System.Windows.Forms.Panel()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.cbbFrente = New APPControls.uscComboParametrica()
            Me.cbbCalvicie = New APPControls.uscComboParametrica()
            Me.cbbMenton = New APPControls.uscComboParametrica()
            Me.pnlRaza = New System.Windows.Forms.Panel()
            Me.cbbCabelloFor = New APPControls.uscComboParametrica()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cbbCabelloColor = New APPControls.uscComboParametrica()
            Me.cbbRaza = New APPControls.uscComboParametrica()
            Me.grbRasgos = New System.Windows.Forms.GroupBox()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.lblNumIngreso = New System.Windows.Forms.Label()
            Me.grbNumIngreso = New System.Windows.Forms.GroupBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlRasgos.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.pnlTronco.SuspendLayout()
            Me.pnlBoca.SuspendLayout()
            Me.pnlOreja.SuspendLayout()
            Me.pnlIris.SuspendLayout()
            Me.pnlCara.SuspendLayout()
            Me.pnlCalvicie.SuspendLayout()
            Me.pnlRaza.SuspendLayout()
            Me.grbRasgos.SuspendLayout()
            Me.grbNumIngreso.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.grbRasgos)
            Me.gbxFormChildContainer.Controls.Add(Me.grbNumIngreso)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(618, 335)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.UscAuditUser1)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 284)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(618, 51)
            Me.Panel1.TabIndex = 88
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 0)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(406, 51)
            Me.UscAuditUser1.TabIndex = 85
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnAceptar)
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(406, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(212, 51)
            Me.Panel3.TabIndex = 106
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 4)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(101, 42)
            Me.btnAceptar.TabIndex = 2
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(107, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(101, 42)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlRasgos
            '
            Me.pnlRasgos.AutoScroll = True
            Me.pnlRasgos.Controls.Add(Me.pnlObs)
            Me.pnlRasgos.Controls.Add(Me.pnlTronco)
            Me.pnlRasgos.Controls.Add(Me.pnlBoca)
            Me.pnlRasgos.Controls.Add(Me.pnlOreja)
            Me.pnlRasgos.Controls.Add(Me.pnlIris)
            Me.pnlRasgos.Controls.Add(Me.pnlCara)
            Me.pnlRasgos.Controls.Add(Me.pnlCalvicie)
            Me.pnlRasgos.Controls.Add(Me.pnlRaza)
            Me.pnlRasgos.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRasgos.Location = New System.Drawing.Point(3, 16)
            Me.pnlRasgos.Name = "pnlRasgos"
            Me.pnlRasgos.Size = New System.Drawing.Size(612, 262)
            Me.pnlRasgos.TabIndex = 0
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.txtObs)
            Me.pnlObs.Controls.Add(Me.Label23)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(0, 185)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(612, 77)
            Me.pnlObs.TabIndex = 12
            '
            'txtObs
            '
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(0, 13)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(612, 64)
            Me.txtObs.TabIndex = 83
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label23
            '
            Me.Label23.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label23.Location = New System.Drawing.Point(0, 0)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(612, 13)
            Me.Label23.TabIndex = 84
            Me.Label23.Text = "Defecto fisico y/o observacion :"
            '
            'pnlTronco
            '
            Me.pnlTronco.Controls.Add(Me.txtPeso)
            Me.pnlTronco.Controls.Add(Me.Label24)
            Me.pnlTronco.Controls.Add(Me.Label25)
            Me.pnlTronco.Controls.Add(Me.txtTalla)
            Me.pnlTronco.Controls.Add(Me.cbbTronco)
            Me.pnlTronco.Controls.Add(Me.cbbComplexion)
            Me.pnlTronco.Controls.Add(Me.Label27)
            Me.pnlTronco.Controls.Add(Me.Label28)
            Me.pnlTronco.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTronco.Location = New System.Drawing.Point(0, 138)
            Me.pnlTronco.Name = "pnlTronco"
            Me.pnlTronco.Size = New System.Drawing.Size(612, 47)
            Me.pnlTronco.TabIndex = 10
            '
            'txtPeso
            '
            Me.txtPeso._BloquearPaste = False
            Me.txtPeso._SeleccionarTodo = False
            Me.txtPeso.Location = New System.Drawing.Point(505, 24)
            Me.txtPeso.Name = "txtPeso"
            Me.txtPeso.Size = New System.Drawing.Size(45, 20)
            Me.txtPeso.TabIndex = 83
            Me.txtPeso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPeso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label24
            '
            Me.Label24.AutoSize = True
            Me.Label24.Location = New System.Drawing.Point(204, 3)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(64, 13)
            Me.Label24.TabIndex = 81
            Me.Label24.Text = "Complexión:"
            '
            'Label25
            '
            Me.Label25.AutoSize = True
            Me.Label25.Location = New System.Drawing.Point(3, 3)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(47, 13)
            Me.Label25.TabIndex = 80
            Me.Label25.Text = "Tronco :"
            '
            'txtTalla
            '
            Me.txtTalla._BloquearPaste = False
            Me.txtTalla._SeleccionarTodo = False
            Me.txtTalla.Location = New System.Drawing.Point(505, 2)
            Me.txtTalla.Name = "txtTalla"
            Me.txtTalla.Size = New System.Drawing.Size(45, 20)
            Me.txtTalla.TabIndex = 82
            Me.txtTalla.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTalla.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbTronco
            '
            Me.cbbTronco._Todos = False
            Me.cbbTronco._TodosMensaje = ""
            Me.cbbTronco._Visible_Add = False
            Me.cbbTronco._Visible_Buscar = False
            Me.cbbTronco._Visible_Eliminar = False
            Me.cbbTronco.CodigoPadre = -1
            Me.cbbTronco.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbTronco.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTronco.DropDownWidth = 112
            Me.cbbTronco.DropDownWidthAuto = False
            Me.cbbTronco.Location = New System.Drawing.Point(71, 2)
            Me.cbbTronco.Name = "cbbTronco"
            Me.cbbTronco.Parametro1 = -1
            Me.cbbTronco.Parametro2 = -1
            Me.cbbTronco.SelectedIndex = -1
            Me.cbbTronco.SelectedValue = 0
            Me.cbbTronco.Size = New System.Drawing.Size(100, 22)
            Me.cbbTronco.TabIndex = 0
            '
            'cbbComplexion
            '
            Me.cbbComplexion._Todos = False
            Me.cbbComplexion._TodosMensaje = ""
            Me.cbbComplexion._Visible_Add = False
            Me.cbbComplexion._Visible_Buscar = False
            Me.cbbComplexion._Visible_Eliminar = False
            Me.cbbComplexion.CodigoPadre = -1
            Me.cbbComplexion.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbComplexion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbComplexion.DropDownWidth = 112
            Me.cbbComplexion.DropDownWidthAuto = False
            Me.cbbComplexion.Location = New System.Drawing.Point(280, 2)
            Me.cbbComplexion.Name = "cbbComplexion"
            Me.cbbComplexion.Parametro1 = -1
            Me.cbbComplexion.Parametro2 = -1
            Me.cbbComplexion.SelectedIndex = -1
            Me.cbbComplexion.SelectedValue = 0
            Me.cbbComplexion.Size = New System.Drawing.Size(100, 22)
            Me.cbbComplexion.TabIndex = 1
            '
            'Label27
            '
            Me.Label27.AutoSize = True
            Me.Label27.Location = New System.Drawing.Point(420, 6)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(53, 13)
            Me.Label27.TabIndex = 81
            Me.Label27.Text = "Talla (m.):"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(420, 27)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(62, 13)
            Me.Label28.TabIndex = 80
            Me.Label28.Text = "Peso (Kg.) :"
            '
            'pnlBoca
            '
            Me.pnlBoca.Controls.Add(Me.Label20)
            Me.pnlBoca.Controls.Add(Me.Label21)
            Me.pnlBoca.Controls.Add(Me.Label22)
            Me.pnlBoca.Controls.Add(Me.cbbTipoLabio)
            Me.pnlBoca.Controls.Add(Me.cbbBoca)
            Me.pnlBoca.Controls.Add(Me.cbbLabios)
            Me.pnlBoca.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBoca.Location = New System.Drawing.Point(0, 115)
            Me.pnlBoca.Name = "pnlBoca"
            Me.pnlBoca.Size = New System.Drawing.Size(612, 23)
            Me.pnlBoca.TabIndex = 9
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Location = New System.Drawing.Point(419, 3)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(64, 13)
            Me.Label20.TabIndex = 82
            Me.Label20.Text = "Tipo labios :"
            '
            'Label21
            '
            Me.Label21.AutoSize = True
            Me.Label21.Location = New System.Drawing.Point(204, 3)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(44, 13)
            Me.Label21.TabIndex = 81
            Me.Label21.Text = "Labios :"
            '
            'Label22
            '
            Me.Label22.AutoSize = True
            Me.Label22.Location = New System.Drawing.Point(3, 3)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(38, 13)
            Me.Label22.TabIndex = 80
            Me.Label22.Text = "Boca :"
            '
            'cbbTipoLabio
            '
            Me.cbbTipoLabio._Todos = False
            Me.cbbTipoLabio._TodosMensaje = ""
            Me.cbbTipoLabio._Visible_Add = False
            Me.cbbTipoLabio._Visible_Buscar = False
            Me.cbbTipoLabio._Visible_Eliminar = False
            Me.cbbTipoLabio.CodigoPadre = -1
            Me.cbbTipoLabio.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbTipoLabio.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoLabio.DropDownWidth = 112
            Me.cbbTipoLabio.DropDownWidthAuto = False
            Me.cbbTipoLabio.Location = New System.Drawing.Point(505, 2)
            Me.cbbTipoLabio.Name = "cbbTipoLabio"
            Me.cbbTipoLabio.Parametro1 = -1
            Me.cbbTipoLabio.Parametro2 = -1
            Me.cbbTipoLabio.SelectedIndex = -1
            Me.cbbTipoLabio.SelectedValue = 0
            Me.cbbTipoLabio.Size = New System.Drawing.Size(100, 22)
            Me.cbbTipoLabio.TabIndex = 2
            '
            'cbbBoca
            '
            Me.cbbBoca._Todos = False
            Me.cbbBoca._TodosMensaje = ""
            Me.cbbBoca._Visible_Add = False
            Me.cbbBoca._Visible_Buscar = False
            Me.cbbBoca._Visible_Eliminar = False
            Me.cbbBoca.CodigoPadre = -1
            Me.cbbBoca.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbBoca.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBoca.DropDownWidth = 112
            Me.cbbBoca.DropDownWidthAuto = False
            Me.cbbBoca.Location = New System.Drawing.Point(71, 2)
            Me.cbbBoca.Name = "cbbBoca"
            Me.cbbBoca.Parametro1 = -1
            Me.cbbBoca.Parametro2 = -1
            Me.cbbBoca.SelectedIndex = -1
            Me.cbbBoca.SelectedValue = 0
            Me.cbbBoca.Size = New System.Drawing.Size(100, 22)
            Me.cbbBoca.TabIndex = 0
            '
            'cbbLabios
            '
            Me.cbbLabios._Todos = False
            Me.cbbLabios._TodosMensaje = ""
            Me.cbbLabios._Visible_Add = False
            Me.cbbLabios._Visible_Buscar = False
            Me.cbbLabios._Visible_Eliminar = False
            Me.cbbLabios.CodigoPadre = -1
            Me.cbbLabios.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbLabios.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbLabios.DropDownWidth = 112
            Me.cbbLabios.DropDownWidthAuto = False
            Me.cbbLabios.Location = New System.Drawing.Point(280, 2)
            Me.cbbLabios.Name = "cbbLabios"
            Me.cbbLabios.Parametro1 = -1
            Me.cbbLabios.Parametro2 = -1
            Me.cbbLabios.SelectedIndex = -1
            Me.cbbLabios.SelectedValue = 0
            Me.cbbLabios.Size = New System.Drawing.Size(100, 22)
            Me.cbbLabios.TabIndex = 1
            '
            'pnlOreja
            '
            Me.pnlOreja.Controls.Add(Me.Label17)
            Me.pnlOreja.Controls.Add(Me.Label18)
            Me.pnlOreja.Controls.Add(Me.Label19)
            Me.pnlOreja.Controls.Add(Me.cbbTipoNar)
            Me.pnlOreja.Controls.Add(Me.cbbOrejaDer)
            Me.pnlOreja.Controls.Add(Me.cbbNarizFor)
            Me.pnlOreja.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlOreja.Location = New System.Drawing.Point(0, 92)
            Me.pnlOreja.Name = "pnlOreja"
            Me.pnlOreja.Size = New System.Drawing.Size(612, 23)
            Me.pnlOreja.TabIndex = 8
            '
            'Label17
            '
            Me.Label17.AutoSize = True
            Me.Label17.Location = New System.Drawing.Point(419, 2)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(59, 13)
            Me.Label17.TabIndex = 82
            Me.Label17.Text = "Tipo nariz :"
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.Location = New System.Drawing.Point(204, 3)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(67, 13)
            Me.Label18.TabIndex = 81
            Me.Label18.Text = "Forma nariz :"
            '
            'Label19
            '
            Me.Label19.AutoSize = True
            Me.Label19.Location = New System.Drawing.Point(3, 3)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(38, 13)
            Me.Label19.TabIndex = 80
            Me.Label19.Text = "Oreja :"
            '
            'cbbTipoNar
            '
            Me.cbbTipoNar._Todos = False
            Me.cbbTipoNar._TodosMensaje = ""
            Me.cbbTipoNar._Visible_Add = False
            Me.cbbTipoNar._Visible_Buscar = False
            Me.cbbTipoNar._Visible_Eliminar = False
            Me.cbbTipoNar.CodigoPadre = -1
            Me.cbbTipoNar.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbTipoNar.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoNar.DropDownWidth = 112
            Me.cbbTipoNar.DropDownWidthAuto = False
            Me.cbbTipoNar.Location = New System.Drawing.Point(505, 2)
            Me.cbbTipoNar.Name = "cbbTipoNar"
            Me.cbbTipoNar.Parametro1 = -1
            Me.cbbTipoNar.Parametro2 = -1
            Me.cbbTipoNar.SelectedIndex = -1
            Me.cbbTipoNar.SelectedValue = 0
            Me.cbbTipoNar.Size = New System.Drawing.Size(100, 22)
            Me.cbbTipoNar.TabIndex = 2
            '
            'cbbOrejaDer
            '
            Me.cbbOrejaDer._Todos = False
            Me.cbbOrejaDer._TodosMensaje = ""
            Me.cbbOrejaDer._Visible_Add = False
            Me.cbbOrejaDer._Visible_Buscar = False
            Me.cbbOrejaDer._Visible_Eliminar = False
            Me.cbbOrejaDer.CodigoPadre = -1
            Me.cbbOrejaDer.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbOrejaDer.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbOrejaDer.DropDownWidth = 112
            Me.cbbOrejaDer.DropDownWidthAuto = False
            Me.cbbOrejaDer.Location = New System.Drawing.Point(71, 2)
            Me.cbbOrejaDer.Name = "cbbOrejaDer"
            Me.cbbOrejaDer.Parametro1 = -1
            Me.cbbOrejaDer.Parametro2 = -1
            Me.cbbOrejaDer.SelectedIndex = -1
            Me.cbbOrejaDer.SelectedValue = 0
            Me.cbbOrejaDer.Size = New System.Drawing.Size(100, 22)
            Me.cbbOrejaDer.TabIndex = 0
            '
            'cbbNarizFor
            '
            Me.cbbNarizFor._Todos = False
            Me.cbbNarizFor._TodosMensaje = ""
            Me.cbbNarizFor._Visible_Add = False
            Me.cbbNarizFor._Visible_Buscar = False
            Me.cbbNarizFor._Visible_Eliminar = False
            Me.cbbNarizFor.CodigoPadre = -1
            Me.cbbNarizFor.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbNarizFor.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNarizFor.DropDownWidth = 112
            Me.cbbNarizFor.DropDownWidthAuto = False
            Me.cbbNarizFor.Location = New System.Drawing.Point(280, 2)
            Me.cbbNarizFor.Name = "cbbNarizFor"
            Me.cbbNarizFor.Parametro1 = -1
            Me.cbbNarizFor.Parametro2 = -1
            Me.cbbNarizFor.SelectedIndex = -1
            Me.cbbNarizFor.SelectedValue = 0
            Me.cbbNarizFor.Size = New System.Drawing.Size(100, 22)
            Me.cbbNarizFor.TabIndex = 1
            '
            'pnlIris
            '
            Me.pnlIris.Controls.Add(Me.Label14)
            Me.pnlIris.Controls.Add(Me.Label15)
            Me.pnlIris.Controls.Add(Me.Label16)
            Me.pnlIris.Controls.Add(Me.cbbAnomaliaOjo)
            Me.pnlIris.Controls.Add(Me.cbbIris)
            Me.pnlIris.Controls.Add(Me.cbbCeja)
            Me.pnlIris.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlIris.Location = New System.Drawing.Point(0, 69)
            Me.pnlIris.Name = "pnlIris"
            Me.pnlIris.Size = New System.Drawing.Size(612, 23)
            Me.pnlIris.TabIndex = 7
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Location = New System.Drawing.Point(419, 3)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(77, 13)
            Me.Label14.TabIndex = 82
            Me.Label14.Text = "Anomalia Ojos:"
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Location = New System.Drawing.Point(204, 3)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(39, 13)
            Me.Label15.TabIndex = 81
            Me.Label15.Text = "Cejas :"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(3, 3)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(26, 13)
            Me.Label16.TabIndex = 80
            Me.Label16.Text = "Iris :"
            '
            'cbbAnomaliaOjo
            '
            Me.cbbAnomaliaOjo._Todos = False
            Me.cbbAnomaliaOjo._TodosMensaje = ""
            Me.cbbAnomaliaOjo._Visible_Add = False
            Me.cbbAnomaliaOjo._Visible_Buscar = False
            Me.cbbAnomaliaOjo._Visible_Eliminar = False
            Me.cbbAnomaliaOjo.CodigoPadre = -1
            Me.cbbAnomaliaOjo.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbAnomaliaOjo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbAnomaliaOjo.DropDownWidth = 112
            Me.cbbAnomaliaOjo.DropDownWidthAuto = False
            Me.cbbAnomaliaOjo.Location = New System.Drawing.Point(505, 2)
            Me.cbbAnomaliaOjo.Name = "cbbAnomaliaOjo"
            Me.cbbAnomaliaOjo.Parametro1 = -1
            Me.cbbAnomaliaOjo.Parametro2 = -1
            Me.cbbAnomaliaOjo.SelectedIndex = -1
            Me.cbbAnomaliaOjo.SelectedValue = 0
            Me.cbbAnomaliaOjo.Size = New System.Drawing.Size(100, 22)
            Me.cbbAnomaliaOjo.TabIndex = 2
            '
            'cbbIris
            '
            Me.cbbIris._Todos = False
            Me.cbbIris._TodosMensaje = ""
            Me.cbbIris._Visible_Add = False
            Me.cbbIris._Visible_Buscar = False
            Me.cbbIris._Visible_Eliminar = False
            Me.cbbIris.CodigoPadre = -1
            Me.cbbIris.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbIris.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbIris.DropDownWidth = 112
            Me.cbbIris.DropDownWidthAuto = False
            Me.cbbIris.Location = New System.Drawing.Point(71, 2)
            Me.cbbIris.Name = "cbbIris"
            Me.cbbIris.Parametro1 = -1
            Me.cbbIris.Parametro2 = -1
            Me.cbbIris.SelectedIndex = -1
            Me.cbbIris.SelectedValue = 0
            Me.cbbIris.Size = New System.Drawing.Size(100, 22)
            Me.cbbIris.TabIndex = 0
            '
            'cbbCeja
            '
            Me.cbbCeja._Todos = False
            Me.cbbCeja._TodosMensaje = ""
            Me.cbbCeja._Visible_Add = False
            Me.cbbCeja._Visible_Buscar = False
            Me.cbbCeja._Visible_Eliminar = False
            Me.cbbCeja.CodigoPadre = -1
            Me.cbbCeja.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbCeja.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbCeja.DropDownWidth = 112
            Me.cbbCeja.DropDownWidthAuto = False
            Me.cbbCeja.Location = New System.Drawing.Point(280, 2)
            Me.cbbCeja.Name = "cbbCeja"
            Me.cbbCeja.Parametro1 = -1
            Me.cbbCeja.Parametro2 = -1
            Me.cbbCeja.SelectedIndex = -1
            Me.cbbCeja.SelectedValue = 0
            Me.cbbCeja.Size = New System.Drawing.Size(100, 22)
            Me.cbbCeja.TabIndex = 1
            '
            'pnlCara
            '
            Me.pnlCara.Controls.Add(Me.Label11)
            Me.pnlCara.Controls.Add(Me.Label12)
            Me.pnlCara.Controls.Add(Me.Label13)
            Me.pnlCara.Controls.Add(Me.cbbFormaOjo)
            Me.pnlCara.Controls.Add(Me.cbbCaraFor)
            Me.pnlCara.Controls.Add(Me.cbbLineaIns)
            Me.pnlCara.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCara.Location = New System.Drawing.Point(0, 46)
            Me.pnlCara.Name = "pnlCara"
            Me.pnlCara.Size = New System.Drawing.Size(612, 23)
            Me.pnlCara.TabIndex = 6
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(419, 3)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(63, 13)
            Me.Label11.TabIndex = 82
            Me.Label11.Text = "Forma Ojos:"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(204, 3)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(68, 13)
            Me.Label12.TabIndex = 81
            Me.Label12.Text = "Linea Inser. :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(3, 3)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(64, 13)
            Me.Label13.TabIndex = 80
            Me.Label13.Text = "Forma Cara:"
            '
            'cbbFormaOjo
            '
            Me.cbbFormaOjo._Todos = False
            Me.cbbFormaOjo._TodosMensaje = ""
            Me.cbbFormaOjo._Visible_Add = False
            Me.cbbFormaOjo._Visible_Buscar = False
            Me.cbbFormaOjo._Visible_Eliminar = False
            Me.cbbFormaOjo.CodigoPadre = -1
            Me.cbbFormaOjo.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbFormaOjo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbFormaOjo.DropDownWidth = 112
            Me.cbbFormaOjo.DropDownWidthAuto = False
            Me.cbbFormaOjo.Location = New System.Drawing.Point(505, 2)
            Me.cbbFormaOjo.Name = "cbbFormaOjo"
            Me.cbbFormaOjo.Parametro1 = -1
            Me.cbbFormaOjo.Parametro2 = -1
            Me.cbbFormaOjo.SelectedIndex = -1
            Me.cbbFormaOjo.SelectedValue = 0
            Me.cbbFormaOjo.Size = New System.Drawing.Size(100, 22)
            Me.cbbFormaOjo.TabIndex = 2
            '
            'cbbCaraFor
            '
            Me.cbbCaraFor._Todos = False
            Me.cbbCaraFor._TodosMensaje = ""
            Me.cbbCaraFor._Visible_Add = False
            Me.cbbCaraFor._Visible_Buscar = False
            Me.cbbCaraFor._Visible_Eliminar = False
            Me.cbbCaraFor.CodigoPadre = -1
            Me.cbbCaraFor.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbCaraFor.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbCaraFor.DropDownWidth = 112
            Me.cbbCaraFor.DropDownWidthAuto = False
            Me.cbbCaraFor.Location = New System.Drawing.Point(71, 2)
            Me.cbbCaraFor.Name = "cbbCaraFor"
            Me.cbbCaraFor.Parametro1 = -1
            Me.cbbCaraFor.Parametro2 = -1
            Me.cbbCaraFor.SelectedIndex = -1
            Me.cbbCaraFor.SelectedValue = 0
            Me.cbbCaraFor.Size = New System.Drawing.Size(100, 22)
            Me.cbbCaraFor.TabIndex = 0
            '
            'cbbLineaIns
            '
            Me.cbbLineaIns._Todos = False
            Me.cbbLineaIns._TodosMensaje = ""
            Me.cbbLineaIns._Visible_Add = False
            Me.cbbLineaIns._Visible_Buscar = False
            Me.cbbLineaIns._Visible_Eliminar = False
            Me.cbbLineaIns.CodigoPadre = -1
            Me.cbbLineaIns.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbLineaIns.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbLineaIns.DropDownWidth = 112
            Me.cbbLineaIns.DropDownWidthAuto = False
            Me.cbbLineaIns.Location = New System.Drawing.Point(280, 2)
            Me.cbbLineaIns.Name = "cbbLineaIns"
            Me.cbbLineaIns.Parametro1 = -1
            Me.cbbLineaIns.Parametro2 = -1
            Me.cbbLineaIns.SelectedIndex = -1
            Me.cbbLineaIns.SelectedValue = 0
            Me.cbbLineaIns.Size = New System.Drawing.Size(100, 22)
            Me.cbbLineaIns.TabIndex = 1
            '
            'pnlCalvicie
            '
            Me.pnlCalvicie.Controls.Add(Me.Label8)
            Me.pnlCalvicie.Controls.Add(Me.Label9)
            Me.pnlCalvicie.Controls.Add(Me.Label10)
            Me.pnlCalvicie.Controls.Add(Me.cbbFrente)
            Me.pnlCalvicie.Controls.Add(Me.cbbCalvicie)
            Me.pnlCalvicie.Controls.Add(Me.cbbMenton)
            Me.pnlCalvicie.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCalvicie.Location = New System.Drawing.Point(0, 23)
            Me.pnlCalvicie.Name = "pnlCalvicie"
            Me.pnlCalvicie.Size = New System.Drawing.Size(612, 23)
            Me.pnlCalvicie.TabIndex = 5
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(419, 3)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(43, 13)
            Me.Label8.TabIndex = 82
            Me.Label8.Text = "Frente :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(204, 3)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(49, 13)
            Me.Label9.TabIndex = 81
            Me.Label9.Text = "Menton :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(3, 3)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(44, 13)
            Me.Label10.TabIndex = 80
            Me.Label10.Text = "Calvicie"
            '
            'cbbFrente
            '
            Me.cbbFrente._Todos = False
            Me.cbbFrente._TodosMensaje = ""
            Me.cbbFrente._Visible_Add = False
            Me.cbbFrente._Visible_Buscar = False
            Me.cbbFrente._Visible_Eliminar = False
            Me.cbbFrente.CodigoPadre = -1
            Me.cbbFrente.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbFrente.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbFrente.DropDownWidth = 112
            Me.cbbFrente.DropDownWidthAuto = False
            Me.cbbFrente.Location = New System.Drawing.Point(505, 2)
            Me.cbbFrente.Name = "cbbFrente"
            Me.cbbFrente.Parametro1 = -1
            Me.cbbFrente.Parametro2 = -1
            Me.cbbFrente.SelectedIndex = -1
            Me.cbbFrente.SelectedValue = 0
            Me.cbbFrente.Size = New System.Drawing.Size(100, 22)
            Me.cbbFrente.TabIndex = 2
            '
            'cbbCalvicie
            '
            Me.cbbCalvicie._Todos = False
            Me.cbbCalvicie._TodosMensaje = ""
            Me.cbbCalvicie._Visible_Add = False
            Me.cbbCalvicie._Visible_Buscar = False
            Me.cbbCalvicie._Visible_Eliminar = False
            Me.cbbCalvicie.CodigoPadre = -1
            Me.cbbCalvicie.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbCalvicie.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbCalvicie.DropDownWidth = 112
            Me.cbbCalvicie.DropDownWidthAuto = False
            Me.cbbCalvicie.Location = New System.Drawing.Point(71, 2)
            Me.cbbCalvicie.Name = "cbbCalvicie"
            Me.cbbCalvicie.Parametro1 = -1
            Me.cbbCalvicie.Parametro2 = -1
            Me.cbbCalvicie.SelectedIndex = -1
            Me.cbbCalvicie.SelectedValue = 0
            Me.cbbCalvicie.Size = New System.Drawing.Size(100, 22)
            Me.cbbCalvicie.TabIndex = 0
            '
            'cbbMenton
            '
            Me.cbbMenton._Todos = False
            Me.cbbMenton._TodosMensaje = ""
            Me.cbbMenton._Visible_Add = False
            Me.cbbMenton._Visible_Buscar = False
            Me.cbbMenton._Visible_Eliminar = False
            Me.cbbMenton.CodigoPadre = -1
            Me.cbbMenton.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbMenton.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbMenton.DropDownWidth = 112
            Me.cbbMenton.DropDownWidthAuto = False
            Me.cbbMenton.Location = New System.Drawing.Point(280, 2)
            Me.cbbMenton.Name = "cbbMenton"
            Me.cbbMenton.Parametro1 = -1
            Me.cbbMenton.Parametro2 = -1
            Me.cbbMenton.SelectedIndex = -1
            Me.cbbMenton.SelectedValue = 0
            Me.cbbMenton.Size = New System.Drawing.Size(100, 22)
            Me.cbbMenton.TabIndex = 1
            '
            'pnlRaza
            '
            Me.pnlRaza.Controls.Add(Me.cbbCabelloFor)
            Me.pnlRaza.Controls.Add(Me.Label7)
            Me.pnlRaza.Controls.Add(Me.Label6)
            Me.pnlRaza.Controls.Add(Me.Label5)
            Me.pnlRaza.Controls.Add(Me.cbbCabelloColor)
            Me.pnlRaza.Controls.Add(Me.cbbRaza)
            Me.pnlRaza.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRaza.Location = New System.Drawing.Point(0, 0)
            Me.pnlRaza.Name = "pnlRaza"
            Me.pnlRaza.Size = New System.Drawing.Size(612, 23)
            Me.pnlRaza.TabIndex = 3
            '
            'cbbCabelloFor
            '
            Me.cbbCabelloFor._Todos = False
            Me.cbbCabelloFor._TodosMensaje = ""
            Me.cbbCabelloFor._Visible_Add = False
            Me.cbbCabelloFor._Visible_Buscar = False
            Me.cbbCabelloFor._Visible_Eliminar = False
            Me.cbbCabelloFor.CodigoPadre = -1
            Me.cbbCabelloFor.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbCabelloFor.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbCabelloFor.DropDownWidth = 112
            Me.cbbCabelloFor.DropDownWidthAuto = False
            Me.cbbCabelloFor.Location = New System.Drawing.Point(280, 2)
            Me.cbbCabelloFor.Name = "cbbCabelloFor"
            Me.cbbCabelloFor.Parametro1 = -1
            Me.cbbCabelloFor.Parametro2 = -1
            Me.cbbCabelloFor.SelectedIndex = -1
            Me.cbbCabelloFor.SelectedValue = 0
            Me.cbbCabelloFor.Size = New System.Drawing.Size(100, 22)
            Me.cbbCabelloFor.TabIndex = 1
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(419, 3)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 82
            Me.Label7.Text = "Cabello Color :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(204, 3)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(76, 13)
            Me.Label6.TabIndex = 81
            Me.Label6.Text = "Forma cabello:"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(3, 3)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(38, 13)
            Me.Label5.TabIndex = 80
            Me.Label5.Text = "Raza :"
            '
            'cbbCabelloColor
            '
            Me.cbbCabelloColor._Todos = False
            Me.cbbCabelloColor._TodosMensaje = ""
            Me.cbbCabelloColor._Visible_Add = False
            Me.cbbCabelloColor._Visible_Buscar = False
            Me.cbbCabelloColor._Visible_Eliminar = False
            Me.cbbCabelloColor.CodigoPadre = -1
            Me.cbbCabelloColor.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbCabelloColor.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbCabelloColor.DropDownWidth = 112
            Me.cbbCabelloColor.DropDownWidthAuto = False
            Me.cbbCabelloColor.Location = New System.Drawing.Point(505, 2)
            Me.cbbCabelloColor.Name = "cbbCabelloColor"
            Me.cbbCabelloColor.Parametro1 = -1
            Me.cbbCabelloColor.Parametro2 = -1
            Me.cbbCabelloColor.SelectedIndex = -1
            Me.cbbCabelloColor.SelectedValue = 0
            Me.cbbCabelloColor.Size = New System.Drawing.Size(100, 22)
            Me.cbbCabelloColor.TabIndex = 2
            '
            'cbbRaza
            '
            Me.cbbRaza._Todos = False
            Me.cbbRaza._TodosMensaje = ""
            Me.cbbRaza._Visible_Add = False
            Me.cbbRaza._Visible_Buscar = False
            Me.cbbRaza._Visible_Eliminar = False
            Me.cbbRaza.CodigoPadre = -1
            Me.cbbRaza.ComboTipo = Type.Combo.ComboTipo.Rasgo
            Me.cbbRaza.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRaza.DropDownWidth = 112
            Me.cbbRaza.DropDownWidthAuto = False
            Me.cbbRaza.Location = New System.Drawing.Point(71, 2)
            Me.cbbRaza.Name = "cbbRaza"
            Me.cbbRaza.Parametro1 = -1
            Me.cbbRaza.Parametro2 = -1
            Me.cbbRaza.SelectedIndex = -1
            Me.cbbRaza.SelectedValue = 0
            Me.cbbRaza.Size = New System.Drawing.Size(100, 22)
            Me.cbbRaza.TabIndex = 0
            '
            'grbRasgos
            '
            Me.grbRasgos.Controls.Add(Me.pnlRasgos)
            Me.grbRasgos.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbRasgos.Location = New System.Drawing.Point(0, 0)
            Me.grbRasgos.Name = "grbRasgos"
            Me.grbRasgos.Size = New System.Drawing.Size(618, 281)
            Me.grbRasgos.TabIndex = 89
            Me.grbRasgos.TabStop = False
            Me.grbRasgos.Text = "Rasgos"
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label37.Location = New System.Drawing.Point(7, 15)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(153, 13)
            Me.Label37.TabIndex = 9
            Me.Label37.Text = "Número de Ingreso del Interno:"
            '
            'lblNumIngreso
            '
            Me.lblNumIngreso.BackColor = System.Drawing.Color.White
            Me.lblNumIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumIngreso.Location = New System.Drawing.Point(162, 12)
            Me.lblNumIngreso.Name = "lblNumIngreso"
            Me.lblNumIngreso.Size = New System.Drawing.Size(58, 20)
            Me.lblNumIngreso.TabIndex = 10
            Me.lblNumIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'grbNumIngreso
            '
            Me.grbNumIngreso.Controls.Add(Me.lblNumIngreso)
            Me.grbNumIngreso.Controls.Add(Me.Label37)
            Me.grbNumIngreso.Location = New System.Drawing.Point(0, 0)
            Me.grbNumIngreso.Name = "grbNumIngreso"
            Me.grbNumIngreso.Size = New System.Drawing.Size(618, 40)
            Me.grbNumIngreso.TabIndex = 90
            Me.grbNumIngreso.TabStop = False
            '
            'frmRasgosPartiPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(618, 335)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmRasgosPartiPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento de Rasgos"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.pnlRasgos.ResumeLayout(False)
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.pnlTronco.ResumeLayout(False)
            Me.pnlTronco.PerformLayout()
            Me.pnlBoca.ResumeLayout(False)
            Me.pnlBoca.PerformLayout()
            Me.pnlOreja.ResumeLayout(False)
            Me.pnlOreja.PerformLayout()
            Me.pnlIris.ResumeLayout(False)
            Me.pnlIris.PerformLayout()
            Me.pnlCara.ResumeLayout(False)
            Me.pnlCara.PerformLayout()
            Me.pnlCalvicie.ResumeLayout(False)
            Me.pnlCalvicie.PerformLayout()
            Me.pnlRaza.ResumeLayout(False)
            Me.pnlRaza.PerformLayout()
            Me.grbRasgos.ResumeLayout(False)
            Me.grbNumIngreso.ResumeLayout(False)
            Me.grbNumIngreso.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlRasgos As System.Windows.Forms.Panel
        Friend WithEvents pnlObs As System.Windows.Forms.Panel
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents pnlTronco As System.Windows.Forms.Panel
        Friend WithEvents txtPeso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents txtTalla As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbTronco As APPControls.uscComboParametrica
        Friend WithEvents cbbComplexion As APPControls.uscComboParametrica
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents pnlBoca As System.Windows.Forms.Panel
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoLabio As APPControls.uscComboParametrica
        Friend WithEvents cbbBoca As APPControls.uscComboParametrica
        Friend WithEvents cbbLabios As APPControls.uscComboParametrica
        Friend WithEvents pnlOreja As System.Windows.Forms.Panel
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoNar As APPControls.uscComboParametrica
        Friend WithEvents cbbOrejaDer As APPControls.uscComboParametrica
        Friend WithEvents cbbNarizFor As APPControls.uscComboParametrica
        Friend WithEvents pnlIris As System.Windows.Forms.Panel
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents cbbAnomaliaOjo As APPControls.uscComboParametrica
        Friend WithEvents cbbIris As APPControls.uscComboParametrica
        Friend WithEvents cbbCeja As APPControls.uscComboParametrica
        Friend WithEvents pnlCara As System.Windows.Forms.Panel
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbFormaOjo As APPControls.uscComboParametrica
        Friend WithEvents cbbCaraFor As APPControls.uscComboParametrica
        Friend WithEvents cbbLineaIns As APPControls.uscComboParametrica
        Friend WithEvents pnlCalvicie As System.Windows.Forms.Panel
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents cbbFrente As APPControls.uscComboParametrica
        Friend WithEvents cbbCalvicie As APPControls.uscComboParametrica
        Friend WithEvents cbbMenton As APPControls.uscComboParametrica
        Friend WithEvents pnlRaza As System.Windows.Forms.Panel
        Friend WithEvents cbbCabelloFor As APPControls.uscComboParametrica
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbCabelloColor As APPControls.uscComboParametrica
        Friend WithEvents cbbRaza As APPControls.uscComboParametrica
        Friend WithEvents grbRasgos As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents grbNumIngreso As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumIngreso As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
    End Class
End Namespace