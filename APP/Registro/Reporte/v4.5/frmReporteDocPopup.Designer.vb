Namespace Registro.Reporte


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReporteDocPopup
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtNumero = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.dtpFechaEmision = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtTipoDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.pnlPapeletaExcarcelacion = New System.Windows.Forms.Panel()
            Me.pnlProcedencia = New System.Windows.Forms.Panel()
            Me.txtProcedencia = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.pnlDireccion = New System.Windows.Forms.Panel()
            Me.txtDireccion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.pnlLibertad = New System.Windows.Forms.Panel()
            Me.pnlRestriccion = New System.Windows.Forms.Panel()
            Me.dgwRestriccion = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ite = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.btnAdd = New Legolas.APPUIComponents.myButton()
            Me.pnlProcedencia2 = New System.Windows.Forms.Panel()
            Me.txtProcedencia2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.pnlNota = New System.Windows.Forms.Panel()
            Me.txtNota = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.pnlPapeletaExcarcelacion.SuspendLayout()
            Me.pnlProcedencia.SuspendLayout()
            Me.pnlDireccion.SuspendLayout()
            Me.pnlLibertad.SuspendLayout()
            Me.pnlRestriccion.SuspendLayout()
            CType(Me.dgwRestriccion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.pnlProcedencia2.SuspendLayout()
            Me.pnlNota.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel5)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(514, 414)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(14, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(60, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Tipo Doc. :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtNumero)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.cbbAnio)
            Me.GroupBox1.Location = New System.Drawing.Point(17, 32)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(187, 40)
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Número Documento"
            '
            'txtNumero
            '
            Me.txtNumero._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumero._BloquearPaste = False
            Me.txtNumero._SeleccionarTodo = False
            Me.txtNumero.Location = New System.Drawing.Point(125, 16)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(50, 20)
            Me.txtNumero.TabIndex = 5
            Me.txtNumero.Text = "000001"
            Me.txtNumero.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumero.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 20)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(32, 13)
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Año :"
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 1900
            Me.cbbAnio.Location = New System.Drawing.Point(57, 16)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(62, 21)
            Me.cbbAnio.TabIndex = 4
            Me.cbbAnio.Value = -1
            '
            'dtpFechaEmision
            '
            Me.dtpFechaEmision.Location = New System.Drawing.Point(287, 44)
            Me.dtpFechaEmision.Name = "dtpFechaEmision"
            Me.dtpFechaEmision.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaEmision.TabIndex = 6
            Me.dtpFechaEmision.Value = "12/12/1985"
            Me.dtpFechaEmision.ValueLong = CType(121476852000000000, Long)
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(221, 48)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 13)
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "F. Emision :"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtTipoDoc)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.GroupBox1)
            Me.GroupBox2.Controls.Add(Me.dtpFechaEmision)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(514, 75)
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            '
            'txtTipoDoc
            '
            Me.txtTipoDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoDoc._BloquearPaste = False
            Me.txtTipoDoc._SeleccionarTodo = False
            Me.txtTipoDoc.Location = New System.Drawing.Point(78, 9)
            Me.txtTipoDoc.Name = "txtTipoDoc"
            Me.txtTipoDoc.ReadOnly = True
            Me.txtTipoDoc.Size = New System.Drawing.Size(424, 20)
            Me.txtTipoDoc.TabIndex = 2
            Me.txtTipoDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.Panel1)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(0, 369)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(514, 45)
            Me.Panel5.TabIndex = 100
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(313, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(201, 45)
            Me.Panel1.TabIndex = 99
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 15
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(101, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 16
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlObs
            '
            Me.pnlObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlObs.Controls.Add(Me.txtObs)
            Me.pnlObs.Controls.Add(Me.Label8)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(3, 16)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(508, 275)
            Me.pnlObs.TabIndex = 12
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(0, 22)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(506, 251)
            Me.txtObs.TabIndex = 4
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(506, 22)
            Me.Label8.TabIndex = 7
            Me.Label8.Text = "Observaciones :"
            '
            'pnlPapeletaExcarcelacion
            '
            Me.pnlPapeletaExcarcelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlPapeletaExcarcelacion.Controls.Add(Me.pnlProcedencia)
            Me.pnlPapeletaExcarcelacion.Controls.Add(Me.pnlDireccion)
            Me.pnlPapeletaExcarcelacion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlPapeletaExcarcelacion.Location = New System.Drawing.Point(3, 16)
            Me.pnlPapeletaExcarcelacion.Name = "pnlPapeletaExcarcelacion"
            Me.pnlPapeletaExcarcelacion.Size = New System.Drawing.Size(508, 275)
            Me.pnlPapeletaExcarcelacion.TabIndex = 102
            '
            'pnlProcedencia
            '
            Me.pnlProcedencia.Controls.Add(Me.txtProcedencia)
            Me.pnlProcedencia.Controls.Add(Me.Label7)
            Me.pnlProcedencia.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlProcedencia.Location = New System.Drawing.Point(0, 0)
            Me.pnlProcedencia.Name = "pnlProcedencia"
            Me.pnlProcedencia.Size = New System.Drawing.Size(506, 97)
            Me.pnlProcedencia.TabIndex = 11
            '
            'txtProcedencia
            '
            Me.txtProcedencia._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtProcedencia._BloquearPaste = False
            Me.txtProcedencia._SeleccionarTodo = False
            Me.txtProcedencia.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtProcedencia.Location = New System.Drawing.Point(0, 22)
            Me.txtProcedencia.Multiline = True
            Me.txtProcedencia.Name = "txtProcedencia"
            Me.txtProcedencia.Size = New System.Drawing.Size(506, 75)
            Me.txtProcedencia.TabIndex = 4
            Me.txtProcedencia.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtProcedencia.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label7.Location = New System.Drawing.Point(0, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(506, 22)
            Me.Label7.TabIndex = 7
            Me.Label7.Text = "Procedencia :"
            '
            'pnlDireccion
            '
            Me.pnlDireccion.Controls.Add(Me.txtDireccion)
            Me.pnlDireccion.Controls.Add(Me.Label9)
            Me.pnlDireccion.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlDireccion.Location = New System.Drawing.Point(0, 97)
            Me.pnlDireccion.Name = "pnlDireccion"
            Me.pnlDireccion.Size = New System.Drawing.Size(506, 176)
            Me.pnlDireccion.TabIndex = 101
            '
            'txtDireccion
            '
            Me.txtDireccion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDireccion._BloquearPaste = False
            Me.txtDireccion._SeleccionarTodo = False
            Me.txtDireccion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtDireccion.Location = New System.Drawing.Point(0, 22)
            Me.txtDireccion.Multiline = True
            Me.txtDireccion.Name = "txtDireccion"
            Me.txtDireccion.Size = New System.Drawing.Size(506, 154)
            Me.txtDireccion.TabIndex = 4
            Me.txtDireccion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDireccion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label9
            '
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label9.Location = New System.Drawing.Point(0, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(506, 22)
            Me.Label9.TabIndex = 7
            Me.Label9.Text = "Direccion :"
            '
            'pnlLibertad
            '
            Me.pnlLibertad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlLibertad.Controls.Add(Me.pnlRestriccion)
            Me.pnlLibertad.Controls.Add(Me.pnlProcedencia2)
            Me.pnlLibertad.Controls.Add(Me.pnlNota)
            Me.pnlLibertad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLibertad.Location = New System.Drawing.Point(3, 16)
            Me.pnlLibertad.Name = "pnlLibertad"
            Me.pnlLibertad.Size = New System.Drawing.Size(508, 275)
            Me.pnlLibertad.TabIndex = 10
            '
            'pnlRestriccion
            '
            Me.pnlRestriccion.Controls.Add(Me.dgwRestriccion)
            Me.pnlRestriccion.Controls.Add(Me.Panel2)
            Me.pnlRestriccion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRestriccion.Location = New System.Drawing.Point(0, 70)
            Me.pnlRestriccion.Name = "pnlRestriccion"
            Me.pnlRestriccion.Size = New System.Drawing.Size(506, 133)
            Me.pnlRestriccion.TabIndex = 14
            '
            'dgwRestriccion
            '
            Me.dgwRestriccion.AllowUserToAddRows = False
            Me.dgwRestriccion.AllowUserToDeleteRows = False
            Me.dgwRestriccion.AllowUserToResizeRows = False
            Me.dgwRestriccion.BackgroundColor = System.Drawing.Color.White
            Me.dgwRestriccion.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwRestriccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwRestriccion.ColumnHeadersVisible = False
            Me.dgwRestriccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ite, Me.Nombre})
            Me.dgwRestriccion.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwRestriccion.Location = New System.Drawing.Point(0, 35)
            Me.dgwRestriccion.Name = "dgwRestriccion"
            Me.dgwRestriccion.ReadOnly = True
            Me.dgwRestriccion.RowHeadersVisible = False
            Me.dgwRestriccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwRestriccion.Size = New System.Drawing.Size(506, 98)
            Me.dgwRestriccion.TabIndex = 13
            Me.dgwRestriccion.VisibleCampos = False
            '
            'col_ite
            '
            Me.col_ite.DataPropertyName = "Item"
            Me.col_ite.HeaderText = "Item"
            Me.col_ite.Name = "col_ite"
            Me.col_ite.ReadOnly = True
            Me.col_ite.Visible = False
            '
            'Nombre
            '
            Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Nombre.DataPropertyName = "Descripcion"
            Me.Nombre.HeaderText = "Nombre"
            Me.Nombre.Name = "Nombre"
            Me.Nombre.ReadOnly = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.Panel6)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(506, 35)
            Me.Panel2.TabIndex = 10
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Location = New System.Drawing.Point(0, 20)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(418, 15)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Restricciones:"
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.btnAdd)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel6.Location = New System.Drawing.Point(418, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(88, 35)
            Me.Panel6.TabIndex = 12
            '
            'btnAdd
            '
            Me.btnAdd.Location = New System.Drawing.Point(3, 3)
            Me.btnAdd.Name = "btnAdd"
            Me.btnAdd.Size = New System.Drawing.Size(82, 27)
            Me.btnAdd.TabIndex = 12
            Me.btnAdd.Text = "Agregar"
            Me.btnAdd.UseVisualStyleBackColor = True
            '
            'pnlProcedencia2
            '
            Me.pnlProcedencia2.Controls.Add(Me.txtProcedencia2)
            Me.pnlProcedencia2.Controls.Add(Me.Label10)
            Me.pnlProcedencia2.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlProcedencia2.Location = New System.Drawing.Point(0, 0)
            Me.pnlProcedencia2.Name = "pnlProcedencia2"
            Me.pnlProcedencia2.Size = New System.Drawing.Size(506, 70)
            Me.pnlProcedencia2.TabIndex = 13
            Me.pnlProcedencia2.Visible = False
            '
            'txtProcedencia2
            '
            Me.txtProcedencia2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtProcedencia2._BloquearPaste = False
            Me.txtProcedencia2._SeleccionarTodo = False
            Me.txtProcedencia2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtProcedencia2.Location = New System.Drawing.Point(0, 15)
            Me.txtProcedencia2.MaxLength = 150
            Me.txtProcedencia2.Multiline = True
            Me.txtProcedencia2.Name = "txtProcedencia2"
            Me.txtProcedencia2.Size = New System.Drawing.Size(506, 55)
            Me.txtProcedencia2.TabIndex = 9
            Me.txtProcedencia2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtProcedencia2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label10
            '
            Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label10.Location = New System.Drawing.Point(0, 0)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(506, 15)
            Me.Label10.TabIndex = 7
            Me.Label10.Text = "Procedencia :"
            '
            'pnlNota
            '
            Me.pnlNota.Controls.Add(Me.txtNota)
            Me.pnlNota.Controls.Add(Me.Label6)
            Me.pnlNota.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlNota.Location = New System.Drawing.Point(0, 203)
            Me.pnlNota.Name = "pnlNota"
            Me.pnlNota.Size = New System.Drawing.Size(506, 70)
            Me.pnlNota.TabIndex = 9
            '
            'txtNota
            '
            Me.txtNota._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNota._BloquearPaste = False
            Me.txtNota._SeleccionarTodo = False
            Me.txtNota.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtNota.Location = New System.Drawing.Point(0, 15)
            Me.txtNota.MaxLength = 300
            Me.txtNota.Multiline = True
            Me.txtNota.Name = "txtNota"
            Me.txtNota.Size = New System.Drawing.Size(506, 55)
            Me.txtNota.TabIndex = 14
            Me.txtNota.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNota.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label6.Location = New System.Drawing.Point(0, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(506, 15)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "Nota :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.pnlLibertad)
            Me.GroupBox3.Controls.Add(Me.pnlPapeletaExcarcelacion)
            Me.GroupBox3.Controls.Add(Me.pnlObs)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox3.Location = New System.Drawing.Point(0, 75)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(514, 294)
            Me.GroupBox3.TabIndex = 8
            Me.GroupBox3.TabStop = False
            '
            'frmReporteDocPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(514, 414)
            Me.Name = "frmReporteDocPopup"
            Me.Text = "Reporte de Documentos..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.pnlPapeletaExcarcelacion.ResumeLayout(False)
            Me.pnlProcedencia.ResumeLayout(False)
            Me.pnlProcedencia.PerformLayout()
            Me.pnlDireccion.ResumeLayout(False)
            Me.pnlDireccion.PerformLayout()
            Me.pnlLibertad.ResumeLayout(False)
            Me.pnlRestriccion.ResumeLayout(False)
            CType(Me.dgwRestriccion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            Me.pnlProcedencia2.ResumeLayout(False)
            Me.pnlProcedencia2.PerformLayout()
            Me.pnlNota.ResumeLayout(False)
            Me.pnlNota.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaEmision As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNumero As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlLibertad As System.Windows.Forms.Panel
        Friend WithEvents pnlRestriccion As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnAdd As Legolas.APPUIComponents.myButton
        Friend WithEvents pnlProcedencia2 As System.Windows.Forms.Panel
        Friend WithEvents txtProcedencia2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents pnlNota As System.Windows.Forms.Panel
        Friend WithEvents txtNota As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents pnlPapeletaExcarcelacion As System.Windows.Forms.Panel
        Friend WithEvents pnlProcedencia As System.Windows.Forms.Panel
        Friend WithEvents txtProcedencia As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents pnlDireccion As System.Windows.Forms.Panel
        Friend WithEvents txtDireccion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents pnlObs As System.Windows.Forms.Panel
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtTipoDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dgwRestriccion As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents col_ite As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Label2 As System.Windows.Forms.Label

    End Class
End Namespace