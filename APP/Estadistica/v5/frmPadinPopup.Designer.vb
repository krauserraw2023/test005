Namespace Estadistica.v5


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPadinPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPadinPopup))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtRegion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.pnlLectura = New System.Windows.Forms.Panel()
            Me.btnPadinDetalle = New System.Windows.Forms.Button()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlTranferSede = New System.Windows.Forms.Panel()
            Me.btnTransfSedeCentral = New System.Windows.Forms.Button()
            Me.pnlTranferRegion = New System.Windows.Forms.Panel()
            Me.btnTransfRegion = New System.Windows.Forms.Button()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnGenerar = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.grbObs = New System.Windows.Forms.GroupBox()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtFechaProc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.dtpFechaCorte = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cbbMes = New Legolas.APPUIComponents.uscComboMes()
            Me.txtNumero = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.pnlLectura.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlTranferSede.SuspendLayout()
            Me.pnlTranferRegion.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.grbObs.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(619, 385)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(36, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(47, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Region :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(37, 36)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(40, 13)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Penal :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.txtRegion)
            Me.Panel1.Controls.Add(Me.txtPenal)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(619, 57)
            Me.Panel1.TabIndex = 2
            '
            'txtRegion
            '
            Me.txtRegion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRegion._BloquearPaste = False
            Me.txtRegion._SeleccionarTodo = False
            Me.txtRegion.Location = New System.Drawing.Point(134, 7)
            Me.txtRegion.Name = "txtRegion"
            Me.txtRegion.ReadOnly = True
            Me.txtRegion.Size = New System.Drawing.Size(288, 20)
            Me.txtRegion.TabIndex = 4
            Me.txtRegion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtRegion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtPenal
            '
            Me.txtPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPenal._BloquearPaste = False
            Me.txtPenal._SeleccionarTodo = False
            Me.txtPenal.Location = New System.Drawing.Point(134, 33)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(288, 20)
            Me.txtPenal.TabIndex = 5
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.pnlLectura)
            Me.PnlBotones.Controls.Add(Me.pnlEliminar)
            Me.PnlBotones.Controls.Add(Me.pnlTranferSede)
            Me.PnlBotones.Controls.Add(Me.pnlTranferRegion)
            Me.PnlBotones.Controls.Add(Me.pnlGrabar)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 335)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(619, 50)
            Me.PnlBotones.TabIndex = 3
            '
            'pnlLectura
            '
            Me.pnlLectura.Controls.Add(Me.btnPadinDetalle)
            Me.pnlLectura.Controls.Add(Me.btnSalir)
            Me.pnlLectura.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLectura.Location = New System.Drawing.Point(447, 0)
            Me.pnlLectura.Name = "pnlLectura"
            Me.pnlLectura.Size = New System.Drawing.Size(172, 50)
            Me.pnlLectura.TabIndex = 25
            '
            'btnPadinDetalle
            '
            Me.btnPadinDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnPadinDetalle.Image = CType(resources.GetObject("btnPadinDetalle.Image"), System.Drawing.Image)
            Me.btnPadinDetalle.Location = New System.Drawing.Point(4, 5)
            Me.btnPadinDetalle.Name = "btnPadinDetalle"
            Me.btnPadinDetalle.Size = New System.Drawing.Size(82, 40)
            Me.btnPadinDetalle.TabIndex = 96
            Me.btnPadinDetalle.Text = "&Ver Padin"
            Me.btnPadinDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnPadinDetalle.UseVisualStyleBackColor = True
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(89, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(75, 40)
            Me.btnSalir.TabIndex = 91
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(347, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(100, 50)
            Me.pnlEliminar.TabIndex = 27
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(0, 5)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(99, 40)
            Me.btnEliminar.TabIndex = 92
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlTranferSede
            '
            Me.pnlTranferSede.Controls.Add(Me.btnTransfSedeCentral)
            Me.pnlTranferSede.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlTranferSede.Location = New System.Drawing.Point(242, 0)
            Me.pnlTranferSede.Name = "pnlTranferSede"
            Me.pnlTranferSede.Size = New System.Drawing.Size(105, 50)
            Me.pnlTranferSede.TabIndex = 28
            '
            'btnTransfSedeCentral
            '
            Me.btnTransfSedeCentral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTransfSedeCentral.Image = Global.SIPPOPE.My.Resources.Resources.sincronizar
            Me.btnTransfSedeCentral.Location = New System.Drawing.Point(3, 5)
            Me.btnTransfSedeCentral.Name = "btnTransfSedeCentral"
            Me.btnTransfSedeCentral.Size = New System.Drawing.Size(99, 40)
            Me.btnTransfSedeCentral.TabIndex = 96
            Me.btnTransfSedeCentral.Text = "&Transferir a S.Central"
            Me.btnTransfSedeCentral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnTransfSedeCentral.UseVisualStyleBackColor = True
            '
            'pnlTranferRegion
            '
            Me.pnlTranferRegion.Controls.Add(Me.btnTransfRegion)
            Me.pnlTranferRegion.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlTranferRegion.Location = New System.Drawing.Point(143, 0)
            Me.pnlTranferRegion.Name = "pnlTranferRegion"
            Me.pnlTranferRegion.Size = New System.Drawing.Size(99, 50)
            Me.pnlTranferRegion.TabIndex = 29
            '
            'btnTransfRegion
            '
            Me.btnTransfRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTransfRegion.Image = Global.SIPPOPE.My.Resources.Resources.sincronizar
            Me.btnTransfRegion.Location = New System.Drawing.Point(4, 5)
            Me.btnTransfRegion.Name = "btnTransfRegion"
            Me.btnTransfRegion.Size = New System.Drawing.Size(91, 40)
            Me.btnTransfRegion.TabIndex = 95
            Me.btnTransfRegion.Text = "&Transferir a Región"
            Me.btnTransfRegion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnTransfRegion.UseVisualStyleBackColor = True
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnGenerar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(143, 50)
            Me.pnlGrabar.TabIndex = 26
            Me.pnlGrabar.Visible = False
            '
            'btnGenerar
            '
            Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGenerar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGenerar.Location = New System.Drawing.Point(9, 5)
            Me.btnGenerar.Name = "btnGenerar"
            Me.btnGenerar.Size = New System.Drawing.Size(132, 40)
            Me.btnGenerar.TabIndex = 93
            Me.btnGenerar.Text = "Grabar y Procesar"
            Me.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGenerar.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.grbObs)
            Me.GroupBox1.Controls.Add(Me.GroupBox2)
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.txtNumero)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(619, 278)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            '
            'grbObs
            '
            Me.grbObs.Controls.Add(Me.txtObs)
            Me.grbObs.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.grbObs.Location = New System.Drawing.Point(3, 140)
            Me.grbObs.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
            Me.grbObs.Name = "grbObs"
            Me.grbObs.Padding = New System.Windows.Forms.Padding(20, 3, 3, 3)
            Me.grbObs.Size = New System.Drawing.Size(613, 79)
            Me.grbObs.TabIndex = 23
            Me.grbObs.TabStop = False
            Me.grbObs.Text = "     Observacion"
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(20, 16)
            Me.txtObs.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(590, 60)
            Me.txtObs.TabIndex = 22
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.GroupBox2.Location = New System.Drawing.Point(3, 219)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(613, 56)
            Me.GroupBox2.TabIndex = 24
            Me.GroupBox2.TabStop = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.Red
            Me.Label5.Location = New System.Drawing.Point(10, 11)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(379, 39)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "La ""Fecha de Corte"" indica:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a) La ""Población Penal"" a la fecha indicada." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "b) Los" &
    " ""Egresos"" del 1er día del mes a la fecha de corte del mes."
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.txtFechaProc)
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Controls.Add(Me.Label4)
            Me.Panel3.Controls.Add(Me.Label9)
            Me.Panel3.Controls.Add(Me.cbbAnio)
            Me.Panel3.Controls.Add(Me.dtpFechaCorte)
            Me.Panel3.Controls.Add(Me.Label8)
            Me.Panel3.Controls.Add(Me.txtEstado)
            Me.Panel3.Controls.Add(Me.Label6)
            Me.Panel3.Controls.Add(Me.cbbMes)
            Me.Panel3.Location = New System.Drawing.Point(22, 40)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(446, 100)
            Me.Panel3.TabIndex = 20
            '
            'txtFechaProc
            '
            Me.txtFechaProc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtFechaProc._BloquearPaste = False
            Me.txtFechaProc._SeleccionarTodo = False
            Me.txtFechaProc.Location = New System.Drawing.Point(112, 77)
            Me.txtFechaProc.Name = "txtFechaProc"
            Me.txtFechaProc.ReadOnly = True
            Me.txtFechaProc.Size = New System.Drawing.Size(146, 20)
            Me.txtFechaProc.TabIndex = 26
            Me.txtFechaProc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaProc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(4, 81)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(107, 13)
            Me.Label7.TabIndex = 25
            Me.Label7.Text = "Fec. Procesamiento :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 57)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(71, 13)
            Me.Label4.TabIndex = 23
            Me.Label4.Text = "Fecha Corte :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(7, 33)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(33, 13)
            Me.Label9.TabIndex = 20
            Me.Label9.Text = "Mes :"
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 1900
            Me.cbbAnio.Location = New System.Drawing.Point(112, 3)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(84, 21)
            Me.cbbAnio.TabIndex = 17
            Me.cbbAnio.Value = -1
            '
            'dtpFechaCorte
            '
            Me.dtpFechaCorte.AutoSize = True
            Me.dtpFechaCorte.Location = New System.Drawing.Point(112, 53)
            Me.dtpFechaCorte.Name = "dtpFechaCorte"
            Me.dtpFechaCorte.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaCorte.TabIndex = 21
            Me.dtpFechaCorte.Value = "/  /"
            Me.dtpFechaCorte.ValueLong = CType(0, Long)
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(7, 8)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(32, 13)
            Me.Label8.TabIndex = 19
            Me.Label8.Text = "Año :"
            '
            'txtEstado
            '
            Me.txtEstado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstado._BloquearPaste = False
            Me.txtEstado._SeleccionarTodo = False
            Me.txtEstado.Location = New System.Drawing.Point(314, 78)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(115, 20)
            Me.txtEstado.TabIndex = 14
            Me.txtEstado.Text = "PENDIENTE"
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(264, 81)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(46, 13)
            Me.Label6.TabIndex = 13
            Me.Label6.Text = "Estado :"
            '
            'cbbMes
            '
            Me.cbbMes._Todos = False
            Me.cbbMes.Location = New System.Drawing.Point(112, 28)
            Me.cbbMes.Mes = 0
            Me.cbbMes.MesAbreviatura = False
            Me.cbbMes.Name = "cbbMes"
            Me.cbbMes.Size = New System.Drawing.Size(84, 21)
            Me.cbbMes.TabIndex = 18
            Me.cbbMes.Value = 0
            '
            'txtNumero
            '
            Me.txtNumero._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumero._BloquearPaste = False
            Me.txtNumero._SeleccionarTodo = False
            Me.txtNumero.Location = New System.Drawing.Point(134, 14)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.ReadOnly = True
            Me.txtNumero.Size = New System.Drawing.Size(84, 20)
            Me.txtNumero.TabIndex = 7
            Me.txtNumero.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumero.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(29, 17)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(103, 13)
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Numero Correlativo :"
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'Timer1
            '
            '
            'frmPadinPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(619, 385)
            Me.Name = "frmPadinPopup"
            Me.Text = "Generación de Padin"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.PnlBotones.ResumeLayout(False)
            Me.pnlLectura.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlTranferSede.ResumeLayout(False)
            Me.pnlTranferRegion.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.grbObs.ResumeLayout(False)
            Me.grbObs.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNumero As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtRegion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents btnGenerar As System.Windows.Forms.Button
        Friend WithEvents btnTransfRegion As System.Windows.Forms.Button
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents cbbMes As Legolas.APPUIComponents.uscComboMes
        Friend WithEvents grbObs As System.Windows.Forms.GroupBox
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaCorte As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnPadinDetalle As System.Windows.Forms.Button
        Friend WithEvents pnlLectura As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnTransfSedeCentral As System.Windows.Forms.Button
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtFechaProc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents pnlTranferSede As Panel
        Friend WithEvents pnlTranferRegion As Panel
    End Class
End Namespace