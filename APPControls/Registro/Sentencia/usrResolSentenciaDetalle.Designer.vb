Namespace Registro.Sentencia
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class usrResolSentenciaDetalle
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnAddExp = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grbAutoridad = New System.Windows.Forms.GroupBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.dtpFechaFinal = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rbtCadenaPerpetua = New System.Windows.Forms.RadioButton()
            Me.rbtTemporal = New System.Windows.Forms.RadioButton()
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox()
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.rdbNo = New System.Windows.Forms.RadioButton()
            Me.rdbSi = New System.Windows.Forms.RadioButton()
            Me.pnlObsInimputable = New System.Windows.Forms.Panel()
            Me.txtEstablecimientomental = New Legolas.APPUIComponents.MyTextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscComboDistritoJudicial1 = New APPControls.Busqueda.uscComboDistritoJudicial()
            Me.UscComboSala1 = New APPControls.Busqueda.uscComboSala()
            Me.dtpFechRecepDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dtpFechDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtNumOficio = New Legolas.APPUIComponents.MyTextBox()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2 = New Legolas.APPUIComponents.MyComboBox()
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb = New Legolas.APPUIComponents.MyComboBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip()
            Me.grbCabecera.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbAutoridad.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlObsInimputable.SuspendLayout()
            Me.SuspendLayout()
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.Button1)
            Me.grbCabecera.Controls.Add(Me.btnAddExp)
            Me.grbCabecera.Controls.Add(Me.Panel1)
            Me.grbCabecera.Controls.Add(Me.UscComboDistritoJudicial1)
            Me.grbCabecera.Controls.Add(Me.UscComboSala1)
            Me.grbCabecera.Controls.Add(Me.dtpFechRecepDoc)
            Me.grbCabecera.Controls.Add(Me.lblDistrito)
            Me.grbCabecera.Controls.Add(Me.Label12)
            Me.grbCabecera.Controls.Add(Me.dtpFechDoc)
            Me.grbCabecera.Controls.Add(Me.lblSala)
            Me.grbCabecera.Controls.Add(Me.Label9)
            Me.grbCabecera.Controls.Add(Me.txtNumOficio)
            Me.grbCabecera.Controls.Add(Me.Label30)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(769, 148)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            Me.grbCabecera.Text = "Referencia de la Sentencia"
            '
            'Button1
            '
            Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Button1.BackgroundImage = Global.APPControls.My.Resources.Resources.view
            Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Button1.Image = Global.APPControls.My.Resources.Resources.delete_32
            Me.Button1.Location = New System.Drawing.Point(35, 21)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(29, 27)
            Me.Button1.TabIndex = 1
            Me.Button1.UseVisualStyleBackColor = True
            '
            'btnAddExp
            '
            Me.btnAddExp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnAddExp.BackgroundImage = Global.APPControls.My.Resources.Resources.view
            Me.btnAddExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddExp.Location = New System.Drawing.Point(5, 21)
            Me.btnAddExp.Name = "btnAddExp"
            Me.btnAddExp.Size = New System.Drawing.Size(29, 27)
            Me.btnAddExp.TabIndex = 0
            Me.btnAddExp.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.grbAutoridad)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.pnlObsInimputable)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(3, 72)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(763, 73)
            Me.Panel1.TabIndex = 12
            '
            'grbAutoridad
            '
            Me.grbAutoridad.Controls.Add(Me.Label10)
            Me.grbAutoridad.Controls.Add(Me.dtpFechaFinal)
            Me.grbAutoridad.Controls.Add(Me.Label6)
            Me.grbAutoridad.Controls.Add(Me.dtpFechaInicio)
            Me.grbAutoridad.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbAutoridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grbAutoridad.Location = New System.Drawing.Point(410, 0)
            Me.grbAutoridad.Name = "grbAutoridad"
            Me.grbAutoridad.Size = New System.Drawing.Size(83, 73)
            Me.grbAutoridad.TabIndex = 2
            Me.grbAutoridad.TabStop = False
            Me.grbAutoridad.Text = "Cómputo"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(12, 48)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(43, 13)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "F. vcto:"
            '
            'dtpFechaFinal
            '
            Me.dtpFechaFinal.Enabled = False
            Me.dtpFechaFinal.Location = New System.Drawing.Point(62, 42)
            Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFinal.Name = "dtpFechaFinal"
            Me.dtpFechaFinal.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFinal.TabIndex = 3
            Me.dtpFechaFinal.Value = "/  /"
            Me.dtpFechaFinal.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(9, 21)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(47, 13)
            Me.Label6.TabIndex = 0
            Me.Label6.Text = "F. Inicio:"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaInicio.Location = New System.Drawing.Point(62, 15)
            Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 1
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rbtCadenaPerpetua)
            Me.GroupBox1.Controls.Add(Me.rbtTemporal)
            Me.GroupBox1.Controls.Add(Me.txtDias)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtAnios)
            Me.GroupBox1.Controls.Add(Me.txtMeses)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(147, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(263, 73)
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Duración de la condena"
            '
            'rbtCadenaPerpetua
            '
            Me.rbtCadenaPerpetua.AutoSize = True
            Me.rbtCadenaPerpetua.Enabled = False
            Me.rbtCadenaPerpetua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtCadenaPerpetua.Location = New System.Drawing.Point(10, 42)
            Me.rbtCadenaPerpetua.Name = "rbtCadenaPerpetua"
            Me.rbtCadenaPerpetua.Size = New System.Drawing.Size(107, 17)
            Me.rbtCadenaPerpetua.TabIndex = 1
            Me.rbtCadenaPerpetua.Text = "Cadena perpetua"
            Me.rbtCadenaPerpetua.UseVisualStyleBackColor = True
            '
            'rbtTemporal
            '
            Me.rbtTemporal.AutoSize = True
            Me.rbtTemporal.Enabled = False
            Me.rbtTemporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rbtTemporal.Location = New System.Drawing.Point(10, 19)
            Me.rbtTemporal.Name = "rbtTemporal"
            Me.rbtTemporal.Size = New System.Drawing.Size(69, 17)
            Me.rbtTemporal.TabIndex = 0
            Me.rbtTemporal.Text = "Temporal"
            Me.rbtTemporal.UseVisualStyleBackColor = True
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Enabled = False
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(208, 39)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(25, 20)
            Me.txtDias.TabIndex = 7
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(132, 22)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Años"
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Enabled = False
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.Location = New System.Drawing.Point(136, 40)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(25, 20)
            Me.txtAnios.TabIndex = 3
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Enabled = False
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(173, 39)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(25, 20)
            Me.txtMeses.TabIndex = 5
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(166, 22)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(38, 13)
            Me.Label7.TabIndex = 4
            Me.Label7.Text = "Meses"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(205, 22)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(28, 13)
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Dias"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.rdbNo)
            Me.Panel2.Controls.Add(Me.rdbSi)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(147, 73)
            Me.Panel2.TabIndex = 0
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(5, 5)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(137, 26)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Inimputable con medida de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seguridad de Internación:"
            '
            'rdbNo
            '
            Me.rdbNo.AutoSize = True
            Me.rdbNo.Checked = True
            Me.rdbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbNo.Location = New System.Drawing.Point(69, 38)
            Me.rdbNo.Name = "rdbNo"
            Me.rdbNo.Size = New System.Drawing.Size(41, 17)
            Me.rdbNo.TabIndex = 2
            Me.rdbNo.TabStop = True
            Me.rdbNo.Text = "NO"
            Me.rdbNo.UseVisualStyleBackColor = True
            '
            'rdbSi
            '
            Me.rdbSi.AutoSize = True
            Me.rdbSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbSi.Location = New System.Drawing.Point(22, 39)
            Me.rdbSi.Name = "rdbSi"
            Me.rdbSi.Size = New System.Drawing.Size(35, 17)
            Me.rdbSi.TabIndex = 1
            Me.rdbSi.Text = "SI"
            Me.rdbSi.UseVisualStyleBackColor = True
            '
            'pnlObsInimputable
            '
            Me.pnlObsInimputable.Controls.Add(Me.txtEstablecimientomental)
            Me.pnlObsInimputable.Controls.Add(Me.Label1)
            Me.pnlObsInimputable.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlObsInimputable.Location = New System.Drawing.Point(493, 0)
            Me.pnlObsInimputable.Name = "pnlObsInimputable"
            Me.pnlObsInimputable.Size = New System.Drawing.Size(270, 73)
            Me.pnlObsInimputable.TabIndex = 3
            '
            'txtEstablecimientomental
            '
            Me.txtEstablecimientomental._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstablecimientomental._BloquearPaste = False
            Me.txtEstablecimientomental._SeleccionarTodo = False
            Me.txtEstablecimientomental.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtEstablecimientomental.Enabled = False
            Me.txtEstablecimientomental.Location = New System.Drawing.Point(0, 26)
            Me.txtEstablecimientomental.MaxLength = 120
            Me.txtEstablecimientomental.Multiline = True
            Me.txtEstablecimientomental.Name = "txtEstablecimientomental"
            Me.txtEstablecimientomental.Size = New System.Drawing.Size(270, 47)
            Me.txtEstablecimientomental.TabIndex = 1
            Me.txtEstablecimientomental.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstablecimientomental.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            Me.ToolTip1.SetToolTip(Me.txtEstablecimientomental, "N° de Resolución Inimputable")
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(0, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(274, 26)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Establecimineto de salud mental donde deberá cumplir la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "medida de seguridad:"
            '
            'UscComboDistritoJudicial1
            '
            Me.UscComboDistritoJudicial1._DropDownWidthAuto = False
            Me.UscComboDistritoJudicial1._selectedValue = 0
            Me.UscComboDistritoJudicial1._Todos = False
            Me.UscComboDistritoJudicial1._TodosMensaje = ""
            Me.UscComboDistritoJudicial1._visibleBuscar = True
            Me.UscComboDistritoJudicial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscComboDistritoJudicial1.Location = New System.Drawing.Point(152, 41)
            Me.UscComboDistritoJudicial1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.UscComboDistritoJudicial1.Name = "UscComboDistritoJudicial1"
            Me.UscComboDistritoJudicial1.Size = New System.Drawing.Size(261, 21)
            Me.UscComboDistritoJudicial1.TabIndex = 9
            '
            'UscComboSala1
            '
            Me.UscComboSala1._DistritoJudicialID = -1
            Me.UscComboSala1._DropDownWidthAuto = False
            Me.UscComboSala1._SalaJuzgadoID = 0
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.UscComboSala1._Todos = False
            Me.UscComboSala1._TodosMensaje = ""
            Me.UscComboSala1._visibleBuscar = True
            Me.UscComboSala1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UscComboSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UscComboSala1.Location = New System.Drawing.Point(496, 40)
            Me.UscComboSala1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.UscComboSala1.Name = "UscComboSala1"
            Me.UscComboSala1.Size = New System.Drawing.Size(270, 21)
            Me.UscComboSala1.TabIndex = 11
            '
            'dtpFechRecepDoc
            '
            Me.dtpFechRecepDoc.Enabled = False
            Me.dtpFechRecepDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechRecepDoc.Location = New System.Drawing.Point(682, 13)
            Me.dtpFechRecepDoc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.dtpFechRecepDoc.Name = "dtpFechRecepDoc"
            Me.dtpFechRecepDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechRecepDoc.TabIndex = 7
            Me.dtpFechRecepDoc.Value = "/  /"
            Me.dtpFechRecepDoc.ValueLong = CType(0, Long)
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDistrito.Location = New System.Drawing.Point(70, 46)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(80, 13)
            Me.lblDistrito.TabIndex = 8
            Me.lblDistrito.Text = "Distrito Judicial:"
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(600, 19)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(78, 13)
            Me.Label12.TabIndex = 6
            Me.Label12.Text = "Fecha Recep :"
            '
            'dtpFechDoc
            '
            Me.dtpFechDoc.Enabled = False
            Me.dtpFechDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechDoc.Location = New System.Drawing.Point(496, 15)
            Me.dtpFechDoc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
            Me.dtpFechDoc.Name = "dtpFechDoc"
            Me.dtpFechDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechDoc.TabIndex = 5
            Me.dtpFechDoc.Value = "/  /"
            Me.dtpFechDoc.ValueLong = CType(0, Long)
            '
            'lblSala
            '
            Me.lblSala.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSala.AutoSize = True
            Me.lblSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSala.Location = New System.Drawing.Point(417, 46)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(70, 13)
            Me.lblSala.TabIndex = 10
            Me.lblSala.Text = "Aut. Judicial :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(417, 20)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(69, 13)
            Me.Label9.TabIndex = 4
            Me.Label9.Text = "Fecha Doc. :"
            '
            'txtNumOficio
            '
            Me.txtNumOficio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumOficio._BloquearPaste = False
            Me.txtNumOficio._SeleccionarTodo = False
            Me.txtNumOficio.Enabled = False
            Me.txtNumOficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumOficio.Location = New System.Drawing.Point(152, 16)
            Me.txtNumOficio.MaxLength = 120
            Me.txtNumOficio.Name = "txtNumOficio"
            Me.txtNumOficio.ReadOnly = True
            Me.txtNumOficio.Size = New System.Drawing.Size(261, 20)
            Me.txtNumOficio.TabIndex = 3
            Me.txtNumOficio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumOficio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label30
            '
            Me.Label30.AutoSize = True
            Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label30.Location = New System.Drawing.Point(70, 21)
            Me.Label30.Name = "Label30"
            Me.Label30.Size = New System.Drawing.Size(80, 13)
            Me.Label30.TabIndex = 2
            Me.Label30.Text = "N° Documento:"
            '
            'object_54cb3d30_851e_467f_b037_d3de6ef8c4c2
            '
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.DropDownWidth = 325
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.FormattingEnabled = True
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Location = New System.Drawing.Point(0, 0)
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Name = "object_54cb3d30_851e_467f_b037_d3de6ef8c4c2"
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.Size = New System.Drawing.Size(388, 21)
            Me.object_54cb3d30_851e_467f_b037_d3de6ef8c4c2.TabIndex = 2
            '
            'object_a2eed2a7_9942_4461_8690_c4ded575d9fb
            '
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.DropDownWidth = 325
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.FormattingEnabled = True
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Location = New System.Drawing.Point(0, 0)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Name = "object_a2eed2a7_9942_4461_8690_c4ded575d9fb"
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.Size = New System.Drawing.Size(388, 21)
            Me.object_a2eed2a7_9942_4461_8690_c4ded575d9fb.TabIndex = 2
            '
            'usrResolSentenciaDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.grbCabecera)
            Me.Name = "usrResolSentenciaDetalle"
            Me.Size = New System.Drawing.Size(769, 148)
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.grbAutoridad.ResumeLayout(False)
            Me.grbAutoridad.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.pnlObsInimputable.ResumeLayout(False)
            Me.pnlObsInimputable.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechRecepDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents dtpFechDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtNumOficio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label30 As System.Windows.Forms.Label
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents object_54cb3d30_851e_467f_b037_d3de6ef8c4c2 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents object_a2eed2a7_9942_4461_8690_c4ded575d9fb As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents UscComboSala1 As Busqueda.uscComboSala
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents lblSala As Label
        Friend WithEvents rdbNo As RadioButton
        Friend WithEvents rdbSi As RadioButton
        Friend WithEvents Label2 As Label
        Friend WithEvents UscComboDistritoJudicial1 As Busqueda.uscComboDistritoJudicial
        Friend WithEvents Panel1 As Panel
        Friend WithEvents pnlObsInimputable As Panel
        Friend WithEvents Label1 As Label
        Friend WithEvents txtEstablecimientomental As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel2 As Panel
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents rbtCadenaPerpetua As RadioButton
        Friend WithEvents rbtTemporal As RadioButton
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents btnAddExp As Button
        Friend WithEvents Button1 As Button
        Friend WithEvents grbAutoridad As GroupBox
        Friend WithEvents Label10 As Label
        Friend WithEvents dtpFechaFinal As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
    End Class
End Namespace