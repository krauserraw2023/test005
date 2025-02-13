Namespace Tratamiento.TallerAsistencia.Planilla

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPlanillaDetalle
        Inherits Legolas.APPUIComponents.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaDetalle))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.txtEstado = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNumero = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtMes = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtAnio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtTaller = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtPabellon = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtPenal = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtRegion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnReporte = New System.Windows.Forms.Button()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnAnular = New System.Windows.Forms.Button()
            Me.btnTerminar = New System.Windows.Forms.Button()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.dgwListar = New System.Windows.Forms.DataGridView()
            Me.col_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod_det = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_ape_pat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_ape_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_con_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_02 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_03 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_04 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_05 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_06 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_07 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_08 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_09 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_dia_31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tot_dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ing_tot = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel6.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel8.SuspendLayout()
            Me.Panel9.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.Panel7.SuspendLayout()
            CType(Me.dgwListar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.GroupBox2)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Location = New System.Drawing.Point(0, 0)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(1181, 125)
            Me.Panel6.TabIndex = 0
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Panel2)
            Me.GroupBox2.Controls.Add(Me.txtEstado)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.txtNumero)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtMes)
            Me.GroupBox2.Controls.Add(Me.txtAnio)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.txtTaller)
            Me.GroupBox2.Controls.Add(Me.txtPabellon)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.txtPenal)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.txtRegion)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label16)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(1181, 125)
            Me.GroupBox2.TabIndex = 22
            Me.GroupBox2.TabStop = False
            '
            'Panel2
            '
            Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel2.Controls.Add(Me.Panel3)
            Me.Panel2.Controls.Add(Me.Label24)
            Me.Panel2.Location = New System.Drawing.Point(665, 52)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(513, 70)
            Me.Panel2.TabIndex = 4
            '
            'Panel3
            '
            Me.Panel3.BackColor = System.Drawing.Color.White
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.Label22)
            Me.Panel3.Controls.Add(Me.Label21)
            Me.Panel3.Controls.Add(Me.Label19)
            Me.Panel3.Controls.Add(Me.Label20)
            Me.Panel3.Controls.Add(Me.Label18)
            Me.Panel3.Controls.Add(Me.Label17)
            Me.Panel3.Controls.Add(Me.Label8)
            Me.Panel3.Controls.Add(Me.Label15)
            Me.Panel3.Controls.Add(Me.Label11)
            Me.Panel3.Controls.Add(Me.Label14)
            Me.Panel3.Controls.Add(Me.Label13)
            Me.Panel3.Controls.Add(Me.Label10)
            Me.Panel3.Controls.Add(Me.Label23)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(513, 70)
            Me.Panel3.TabIndex = 0
            '
            'Label22
            '
            Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label22.Location = New System.Drawing.Point(467, 19)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(34, 17)
            Me.Label22.TabIndex = 1
            '
            'Label21
            '
            Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label21.Location = New System.Drawing.Point(85, 40)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(34, 17)
            Me.Label21.TabIndex = 1
            '
            'Label19
            '
            Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label19.Location = New System.Drawing.Point(467, 40)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(34, 17)
            Me.Label19.TabIndex = 1
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label20.Location = New System.Drawing.Point(85, 19)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(34, 17)
            Me.Label20.TabIndex = 1
            '
            'Label18
            '
            Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label18.Location = New System.Drawing.Point(276, 40)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(34, 17)
            Me.Label18.TabIndex = 1
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(81, Byte), Integer))
            Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label17.Location = New System.Drawing.Point(276, 19)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(34, 17)
            Me.Label17.TabIndex = 1
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.ForeColor = System.Drawing.Color.White
            Me.Label8.Location = New System.Drawing.Point(0, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(511, 15)
            Me.Label8.TabIndex = 1
            Me.Label8.Text = " LEYENDA"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label15
            '
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label15.ForeColor = System.Drawing.Color.Black
            Me.Label15.Location = New System.Drawing.Point(326, 41)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(135, 15)
            Me.Label15.TabIndex = 0
            Me.Label15.Text = "S: Sanción disciplianria"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.ForeColor = System.Drawing.Color.Black
            Me.Label11.Location = New System.Drawing.Point(326, 19)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(65, 15)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "L: Libertad"
            '
            'Label14
            '
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label14.ForeColor = System.Drawing.Color.Black
            Me.Label14.Location = New System.Drawing.Point(131, 41)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(141, 15)
            Me.Label14.TabIndex = 0
            Me.Label14.Text = "M: Medida de seguridad"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.ForeColor = System.Drawing.Color.Black
            Me.Label13.Location = New System.Drawing.Point(131, 19)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(125, 15)
            Me.Label13.TabIndex = 0
            Me.Label13.Text = "X: Feriado/Dia no lab."
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label10.ForeColor = System.Drawing.Color.Black
            Me.Label10.Location = New System.Drawing.Point(3, 41)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(75, 15)
            Me.Label10.TabIndex = 0
            Me.Label10.Text = "A: Asistencia"
            '
            'Label23
            '
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label23.ForeColor = System.Drawing.Color.Black
            Me.Label23.Location = New System.Drawing.Point(3, 19)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(47, 15)
            Me.Label23.TabIndex = 0
            Me.Label23.Text = "F: Falta"
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label24.Location = New System.Drawing.Point(0, 0)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(513, 70)
            Me.Label24.TabIndex = 1
            '
            'txtEstado
            '
            Me.txtEstado._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtEstado._BloquearPaste = False
            Me.txtEstado._SeleccionarTodo = True
            Me.txtEstado.Location = New System.Drawing.Point(530, 79)
            Me.txtEstado.Name = "txtEstado"
            Me.txtEstado.ReadOnly = True
            Me.txtEstado.Size = New System.Drawing.Size(115, 20)
            Me.txtEstado.TabIndex = 19
            Me.txtEstado.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtEstado.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(473, 84)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(57, 13)
            Me.Label6.TabIndex = 18
            Me.Label6.Text = "ESTADO :"
            '
            'txtNumero
            '
            Me.txtNumero._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumero._BloquearPaste = False
            Me.txtNumero._SeleccionarTodo = True
            Me.txtNumero.Location = New System.Drawing.Point(530, 102)
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.ReadOnly = True
            Me.txtNumero.Size = New System.Drawing.Size(115, 20)
            Me.txtNumero.TabIndex = 17
            Me.txtNumero.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumero.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(490, 107)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(25, 13)
            Me.Label5.TabIndex = 16
            Me.Label5.Text = "Nº :"
            '
            'txtMes
            '
            Me.txtMes._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMes._BloquearPaste = False
            Me.txtMes._SeleccionarTodo = True
            Me.txtMes.Location = New System.Drawing.Point(529, 54)
            Me.txtMes.Name = "txtMes"
            Me.txtMes.ReadOnly = True
            Me.txtMes.Size = New System.Drawing.Size(115, 20)
            Me.txtMes.TabIndex = 15
            Me.txtMes.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtMes.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtAnio
            '
            Me.txtAnio._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnio._BloquearPaste = False
            Me.txtAnio._SeleccionarTodo = True
            Me.txtAnio.Location = New System.Drawing.Point(529, 31)
            Me.txtAnio.Name = "txtAnio"
            Me.txtAnio.ReadOnly = True
            Me.txtAnio.Size = New System.Drawing.Size(116, 20)
            Me.txtAnio.TabIndex = 13
            Me.txtAnio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtAnio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(473, 59)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(36, 13)
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "MES :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(473, 35)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(36, 13)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "AÑO :"
            '
            'txtTaller
            '
            Me.txtTaller._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTaller._BloquearPaste = False
            Me.txtTaller._SeleccionarTodo = True
            Me.txtTaller.Location = New System.Drawing.Point(218, 101)
            Me.txtTaller.Name = "txtTaller"
            Me.txtTaller.ReadOnly = True
            Me.txtTaller.Size = New System.Drawing.Size(229, 20)
            Me.txtTaller.TabIndex = 11
            Me.txtTaller.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtTaller.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtPabellon
            '
            Me.txtPabellon._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPabellon._BloquearPaste = False
            Me.txtPabellon._SeleccionarTodo = True
            Me.txtPabellon.Location = New System.Drawing.Point(218, 79)
            Me.txtPabellon.Name = "txtPabellon"
            Me.txtPabellon.ReadOnly = True
            Me.txtPabellon.Size = New System.Drawing.Size(229, 20)
            Me.txtPabellon.TabIndex = 10
            Me.txtPabellon.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPabellon.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(11, 105)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 13)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "TALLER :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 83)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(69, 13)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "PABELLON :"
            '
            'txtPenal
            '
            Me.txtPenal._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtPenal._BloquearPaste = False
            Me.txtPenal._SeleccionarTodo = True
            Me.txtPenal.Location = New System.Drawing.Point(218, 57)
            Me.txtPenal.Name = "txtPenal"
            Me.txtPenal.ReadOnly = True
            Me.txtPenal.Size = New System.Drawing.Size(229, 20)
            Me.txtPenal.TabIndex = 7
            Me.txtPenal.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtPenal.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label12.Location = New System.Drawing.Point(431, 8)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(250, 16)
            Me.Label12.TabIndex = 0
            Me.Label12.Text = "PLANILLA DE CONTROL LABORAL"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'txtRegion
            '
            Me.txtRegion._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtRegion._BloquearPaste = False
            Me.txtRegion._SeleccionarTodo = True
            Me.txtRegion.Location = New System.Drawing.Point(218, 34)
            Me.txtRegion.Name = "txtRegion"
            Me.txtRegion.ReadOnly = True
            Me.txtRegion.Size = New System.Drawing.Size(230, 20)
            Me.txtRegion.TabIndex = 3
            Me.txtRegion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtRegion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(11, 62)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(199, 13)
            Me.Label9.TabIndex = 6
            Me.Label9.Text = "ESTABLECIMIENTO PENITENCIARIO :"
            '
            'Label16
            '
            Me.Label16.AutoSize = True
            Me.Label16.Location = New System.Drawing.Point(11, 38)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(113, 13)
            Me.Label16.TabIndex = 2
            Me.Label16.Text = "OFICINA REGIONAL :"
            '
            'Panel8
            '
            Me.Panel8.Controls.Add(Me.lblReg)
            Me.Panel8.Controls.Add(Me.Panel9)
            Me.Panel8.Controls.Add(Me.pnlReporte)
            Me.Panel8.Controls.Add(Me.pnlGrabar)
            Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel8.Location = New System.Drawing.Point(0, 534)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(1181, 44)
            Me.Panel8.TabIndex = 2
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Right
            Me.lblReg.Location = New System.Drawing.Point(968, 0)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(213, 44)
            Me.lblReg.TabIndex = 71
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Panel9
            '
            Me.Panel9.Controls.Add(Me.btnSalir)
            Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel9.Location = New System.Drawing.Point(398, 0)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(88, 44)
            Me.Panel9.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(3, 1)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(80, 40)
            Me.btnSalir.TabIndex = 67
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Controls.Add(Me.btnReporte)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(204, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(194, 44)
            Me.pnlReporte.TabIndex = 68
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(4, 3)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 40)
            Me.btnExportar.TabIndex = 66
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnReporte
            '
            Me.btnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
            Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReporte.Location = New System.Drawing.Point(96, 2)
            Me.btnReporte.Name = "btnReporte"
            Me.btnReporte.Size = New System.Drawing.Size(94, 40)
            Me.btnReporte.TabIndex = 1
            Me.btnReporte.Text = "&Reportes"
            Me.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnReporte.UseVisualStyleBackColor = True
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnAnular)
            Me.pnlGrabar.Controls.Add(Me.btnTerminar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGrabar.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(204, 44)
            Me.pnlGrabar.TabIndex = 70
            Me.pnlGrabar.Visible = False
            '
            'btnAnular
            '
            Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAnular.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnAnular.Location = New System.Drawing.Point(105, 2)
            Me.btnAnular.Name = "btnAnular"
            Me.btnAnular.Size = New System.Drawing.Size(96, 40)
            Me.btnAnular.TabIndex = 3
            Me.btnAnular.Text = "&Anular"
            Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAnular.UseVisualStyleBackColor = True
            '
            'btnTerminar
            '
            Me.btnTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnTerminar.Image = Global.SIPPOPE.My.Resources.Resources._1316210268_go_bottom
            Me.btnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTerminar.Location = New System.Drawing.Point(3, 2)
            Me.btnTerminar.Name = "btnTerminar"
            Me.btnTerminar.Size = New System.Drawing.Size(96, 40)
            Me.btnTerminar.TabIndex = 2
            Me.btnTerminar.Text = "&Terminar"
            Me.btnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnTerminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnTerminar.UseVisualStyleBackColor = True
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.dgwListar)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel7.Location = New System.Drawing.Point(0, 125)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(1181, 409)
            Me.Panel7.TabIndex = 3
            '
            'dgwListar
            '
            Me.dgwListar.AllowUserToAddRows = False
            Me.dgwListar.AllowUserToDeleteRows = False
            Me.dgwListar.BackgroundColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwListar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwListar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_num, Me.col_cod_det, Me.col_con_int_id, Me.col_ape_nom, Me.col_con_ape_pat, Me.col_con_ape_mat, Me.col_con_nom, Me.col_dia_01, Me.col_dia_02, Me.col_dia_03, Me.col_dia_04, Me.col_dia_05, Me.col_dia_06, Me.col_dia_07, Me.col_dia_08, Me.col_dia_09, Me.col_dia_10, Me.col_dia_11, Me.col_dia_12, Me.col_dia_13, Me.col_dia_14, Me.col_dia_15, Me.col_dia_16, Me.col_dia_17, Me.col_dia_18, Me.col_dia_19, Me.col_dia_20, Me.col_dia_21, Me.col_dia_22, Me.col_dia_23, Me.col_dia_24, Me.col_dia_25, Me.col_dia_26, Me.col_dia_27, Me.col_dia_28, Me.col_dia_29, Me.col_dia_30, Me.col_dia_31, Me.col_tot_dia, Me.col_ing_tot})
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwListar.DefaultCellStyle = DataGridViewCellStyle4
            Me.dgwListar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwListar.Location = New System.Drawing.Point(0, 0)
            Me.dgwListar.MultiSelect = False
            Me.dgwListar.Name = "dgwListar"
            Me.dgwListar.ReadOnly = True
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwListar.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
            Me.dgwListar.RowHeadersVisible = False
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwListar.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwListar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwListar.Size = New System.Drawing.Size(1181, 409)
            Me.dgwListar.TabIndex = 2
            '
            'col_num
            '
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.col_num.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_num.HeaderText = "Nº"
            Me.col_num.Name = "col_num"
            Me.col_num.ReadOnly = True
            Me.col_num.Width = 35
            '
            'col_cod_det
            '
            Me.col_cod_det.DataPropertyName = "Codigo"
            Me.col_cod_det.HeaderText = "Codigo"
            Me.col_cod_det.Name = "col_cod_det"
            Me.col_cod_det.ReadOnly = True
            Me.col_cod_det.Visible = False
            '
            'col_con_int_id
            '
            Me.col_con_int_id.DataPropertyName = "InternoID"
            Me.col_con_int_id.HeaderText = "InternoID"
            Me.col_con_int_id.Name = "col_con_int_id"
            Me.col_con_int_id.ReadOnly = True
            Me.col_con_int_id.Visible = False
            '
            'col_ape_nom
            '
            Me.col_ape_nom.DataPropertyName = "ApellidosNombres"
            Me.col_ape_nom.HeaderText = "Apellidos y Nombres del Interno"
            Me.col_ape_nom.Name = "col_ape_nom"
            Me.col_ape_nom.ReadOnly = True
            Me.col_ape_nom.Width = 220
            '
            'col_con_ape_pat
            '
            Me.col_con_ape_pat.DataPropertyName = "ApellidoPaterno"
            Me.col_con_ape_pat.HeaderText = "Primer Apellido"
            Me.col_con_ape_pat.Name = "col_con_ape_pat"
            Me.col_con_ape_pat.ReadOnly = True
            Me.col_con_ape_pat.Visible = False
            Me.col_con_ape_pat.Width = 150
            '
            'col_con_ape_mat
            '
            Me.col_con_ape_mat.DataPropertyName = "ApellidoMaterno"
            Me.col_con_ape_mat.HeaderText = "Segundo Apellido"
            Me.col_con_ape_mat.Name = "col_con_ape_mat"
            Me.col_con_ape_mat.ReadOnly = True
            Me.col_con_ape_mat.Visible = False
            Me.col_con_ape_mat.Width = 150
            '
            'col_con_nom
            '
            Me.col_con_nom.DataPropertyName = "Nombres"
            Me.col_con_nom.HeaderText = "Pre Nombres"
            Me.col_con_nom.Name = "col_con_nom"
            Me.col_con_nom.ReadOnly = True
            Me.col_con_nom.Visible = False
            Me.col_con_nom.Width = 150
            '
            'col_dia_01
            '
            Me.col_dia_01.DataPropertyName = "StrDia01"
            Me.col_dia_01.HeaderText = "1"
            Me.col_dia_01.Name = "col_dia_01"
            Me.col_dia_01.ReadOnly = True
            Me.col_dia_01.Width = 20
            '
            'col_dia_02
            '
            Me.col_dia_02.DataPropertyName = "StrDia02"
            Me.col_dia_02.HeaderText = "2"
            Me.col_dia_02.Name = "col_dia_02"
            Me.col_dia_02.ReadOnly = True
            Me.col_dia_02.Width = 20
            '
            'col_dia_03
            '
            Me.col_dia_03.DataPropertyName = "StrDia03"
            Me.col_dia_03.HeaderText = "3"
            Me.col_dia_03.Name = "col_dia_03"
            Me.col_dia_03.ReadOnly = True
            Me.col_dia_03.Width = 20
            '
            'col_dia_04
            '
            Me.col_dia_04.DataPropertyName = "StrDia04"
            Me.col_dia_04.HeaderText = "4"
            Me.col_dia_04.Name = "col_dia_04"
            Me.col_dia_04.ReadOnly = True
            Me.col_dia_04.Width = 20
            '
            'col_dia_05
            '
            Me.col_dia_05.DataPropertyName = "StrDia05"
            Me.col_dia_05.HeaderText = "5"
            Me.col_dia_05.Name = "col_dia_05"
            Me.col_dia_05.ReadOnly = True
            Me.col_dia_05.Width = 20
            '
            'col_dia_06
            '
            Me.col_dia_06.DataPropertyName = "StrDia06"
            Me.col_dia_06.HeaderText = "6"
            Me.col_dia_06.Name = "col_dia_06"
            Me.col_dia_06.ReadOnly = True
            Me.col_dia_06.Width = 20
            '
            'col_dia_07
            '
            Me.col_dia_07.DataPropertyName = "StrDia07"
            Me.col_dia_07.HeaderText = "7"
            Me.col_dia_07.Name = "col_dia_07"
            Me.col_dia_07.ReadOnly = True
            Me.col_dia_07.Width = 20
            '
            'col_dia_08
            '
            Me.col_dia_08.DataPropertyName = "StrDia08"
            Me.col_dia_08.HeaderText = "8"
            Me.col_dia_08.Name = "col_dia_08"
            Me.col_dia_08.ReadOnly = True
            Me.col_dia_08.Width = 20
            '
            'col_dia_09
            '
            Me.col_dia_09.DataPropertyName = "StrDia09"
            Me.col_dia_09.HeaderText = "9"
            Me.col_dia_09.Name = "col_dia_09"
            Me.col_dia_09.ReadOnly = True
            Me.col_dia_09.Width = 20
            '
            'col_dia_10
            '
            Me.col_dia_10.DataPropertyName = "StrDia10"
            Me.col_dia_10.HeaderText = "10"
            Me.col_dia_10.Name = "col_dia_10"
            Me.col_dia_10.ReadOnly = True
            Me.col_dia_10.Width = 25
            '
            'col_dia_11
            '
            Me.col_dia_11.DataPropertyName = "StrDia11"
            Me.col_dia_11.HeaderText = "11"
            Me.col_dia_11.Name = "col_dia_11"
            Me.col_dia_11.ReadOnly = True
            Me.col_dia_11.Width = 25
            '
            'col_dia_12
            '
            Me.col_dia_12.DataPropertyName = "StrDia12"
            Me.col_dia_12.HeaderText = "12"
            Me.col_dia_12.Name = "col_dia_12"
            Me.col_dia_12.ReadOnly = True
            Me.col_dia_12.Width = 25
            '
            'col_dia_13
            '
            Me.col_dia_13.DataPropertyName = "StrDia13"
            Me.col_dia_13.HeaderText = "13"
            Me.col_dia_13.Name = "col_dia_13"
            Me.col_dia_13.ReadOnly = True
            Me.col_dia_13.Width = 25
            '
            'col_dia_14
            '
            Me.col_dia_14.DataPropertyName = "StrDia14"
            Me.col_dia_14.HeaderText = "14"
            Me.col_dia_14.Name = "col_dia_14"
            Me.col_dia_14.ReadOnly = True
            Me.col_dia_14.Width = 25
            '
            'col_dia_15
            '
            Me.col_dia_15.DataPropertyName = "StrDia15"
            Me.col_dia_15.HeaderText = "15"
            Me.col_dia_15.Name = "col_dia_15"
            Me.col_dia_15.ReadOnly = True
            Me.col_dia_15.Width = 25
            '
            'col_dia_16
            '
            Me.col_dia_16.DataPropertyName = "StrDia16"
            Me.col_dia_16.HeaderText = "16"
            Me.col_dia_16.Name = "col_dia_16"
            Me.col_dia_16.ReadOnly = True
            Me.col_dia_16.Width = 25
            '
            'col_dia_17
            '
            Me.col_dia_17.DataPropertyName = "StrDia17"
            Me.col_dia_17.HeaderText = "17"
            Me.col_dia_17.Name = "col_dia_17"
            Me.col_dia_17.ReadOnly = True
            Me.col_dia_17.Width = 25
            '
            'col_dia_18
            '
            Me.col_dia_18.DataPropertyName = "StrDia18"
            Me.col_dia_18.HeaderText = "18"
            Me.col_dia_18.Name = "col_dia_18"
            Me.col_dia_18.ReadOnly = True
            Me.col_dia_18.Width = 25
            '
            'col_dia_19
            '
            Me.col_dia_19.DataPropertyName = "StrDia19"
            Me.col_dia_19.HeaderText = "19"
            Me.col_dia_19.Name = "col_dia_19"
            Me.col_dia_19.ReadOnly = True
            Me.col_dia_19.Width = 25
            '
            'col_dia_20
            '
            Me.col_dia_20.DataPropertyName = "StrDia20"
            Me.col_dia_20.HeaderText = "20"
            Me.col_dia_20.Name = "col_dia_20"
            Me.col_dia_20.ReadOnly = True
            Me.col_dia_20.Width = 25
            '
            'col_dia_21
            '
            Me.col_dia_21.DataPropertyName = "StrDia21"
            Me.col_dia_21.HeaderText = "21"
            Me.col_dia_21.Name = "col_dia_21"
            Me.col_dia_21.ReadOnly = True
            Me.col_dia_21.Width = 25
            '
            'col_dia_22
            '
            Me.col_dia_22.DataPropertyName = "StrDia22"
            Me.col_dia_22.HeaderText = "22"
            Me.col_dia_22.Name = "col_dia_22"
            Me.col_dia_22.ReadOnly = True
            Me.col_dia_22.Width = 25
            '
            'col_dia_23
            '
            Me.col_dia_23.DataPropertyName = "StrDia23"
            Me.col_dia_23.HeaderText = "23"
            Me.col_dia_23.Name = "col_dia_23"
            Me.col_dia_23.ReadOnly = True
            Me.col_dia_23.Width = 25
            '
            'col_dia_24
            '
            Me.col_dia_24.DataPropertyName = "StrDia24"
            Me.col_dia_24.HeaderText = "24"
            Me.col_dia_24.Name = "col_dia_24"
            Me.col_dia_24.ReadOnly = True
            Me.col_dia_24.Width = 25
            '
            'col_dia_25
            '
            Me.col_dia_25.DataPropertyName = "StrDia25"
            Me.col_dia_25.HeaderText = "25"
            Me.col_dia_25.Name = "col_dia_25"
            Me.col_dia_25.ReadOnly = True
            Me.col_dia_25.Width = 25
            '
            'col_dia_26
            '
            Me.col_dia_26.DataPropertyName = "StrDia26"
            Me.col_dia_26.HeaderText = "26"
            Me.col_dia_26.Name = "col_dia_26"
            Me.col_dia_26.ReadOnly = True
            Me.col_dia_26.Width = 25
            '
            'col_dia_27
            '
            Me.col_dia_27.DataPropertyName = "StrDia27"
            Me.col_dia_27.HeaderText = "27"
            Me.col_dia_27.Name = "col_dia_27"
            Me.col_dia_27.ReadOnly = True
            Me.col_dia_27.Width = 25
            '
            'col_dia_28
            '
            Me.col_dia_28.DataPropertyName = "StrDia28"
            Me.col_dia_28.HeaderText = "28"
            Me.col_dia_28.Name = "col_dia_28"
            Me.col_dia_28.ReadOnly = True
            Me.col_dia_28.Width = 25
            '
            'col_dia_29
            '
            Me.col_dia_29.DataPropertyName = "StrDia29"
            Me.col_dia_29.HeaderText = "29"
            Me.col_dia_29.Name = "col_dia_29"
            Me.col_dia_29.ReadOnly = True
            Me.col_dia_29.Width = 25
            '
            'col_dia_30
            '
            Me.col_dia_30.DataPropertyName = "StrDia30"
            Me.col_dia_30.HeaderText = "30"
            Me.col_dia_30.Name = "col_dia_30"
            Me.col_dia_30.ReadOnly = True
            Me.col_dia_30.Width = 25
            '
            'col_dia_31
            '
            Me.col_dia_31.DataPropertyName = "StrDia31"
            Me.col_dia_31.HeaderText = "31"
            Me.col_dia_31.Name = "col_dia_31"
            Me.col_dia_31.ReadOnly = True
            Me.col_dia_31.Width = 25
            '
            'col_tot_dia
            '
            Me.col_tot_dia.DataPropertyName = "TotalDias"
            Me.col_tot_dia.HeaderText = "Dias Lab."
            Me.col_tot_dia.Name = "col_tot_dia"
            Me.col_tot_dia.ReadOnly = True
            Me.col_tot_dia.Width = 70
            '
            'col_ing_tot
            '
            Me.col_ing_tot.DataPropertyName = "IngresoTotal"
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_ing_tot.DefaultCellStyle = DataGridViewCellStyle3
            Me.col_ing_tot.HeaderText = "Ingreso mensual"
            Me.col_ing_tot.Name = "col_ing_tot"
            Me.col_ing_tot.ReadOnly = True
            '
            'frmPlanillaDetalle
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1181, 578)
            Me.Controls.Add(Me.Panel7)
            Me.Controls.Add(Me.Panel6)
            Me.Controls.Add(Me.Panel8)
            Me.Name = "frmPlanillaDetalle"
            Me.Text = "Detalle Planilla"
            Me.Panel6.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel8.ResumeLayout(False)
            Me.Panel9.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            CType(Me.dgwListar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnReporte As System.Windows.Forms.Button
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents txtPenal As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtRegion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents txtTaller As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtPabellon As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtEstado As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNumero As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtMes As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dgwListar As System.Windows.Forms.DataGridView
        Friend WithEvents btnAnular As System.Windows.Forms.Button
        Friend WithEvents btnTerminar As System.Windows.Forms.Button
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents Panel2 As Panel
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Label22 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents Label19 As Label
        Friend WithEvents Label20 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents Label17 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents Label14 As Label
        Friend WithEvents Label13 As Label
        Friend WithEvents Label10 As Label
        Friend WithEvents Label23 As Label
        Friend WithEvents Label24 As Label
        Friend WithEvents col_num As DataGridViewTextBoxColumn
        Friend WithEvents col_cod_det As DataGridViewTextBoxColumn
        Friend WithEvents col_con_int_id As DataGridViewTextBoxColumn
        Friend WithEvents col_ape_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_con_ape_pat As DataGridViewTextBoxColumn
        Friend WithEvents col_con_ape_mat As DataGridViewTextBoxColumn
        Friend WithEvents col_con_nom As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_01 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_02 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_03 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_04 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_05 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_06 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_07 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_08 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_09 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_10 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_11 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_12 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_13 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_14 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_15 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_16 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_17 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_18 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_19 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_20 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_21 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_22 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_23 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_24 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_25 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_26 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_27 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_28 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_29 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_30 As DataGridViewTextBoxColumn
        Friend WithEvents col_dia_31 As DataGridViewTextBoxColumn
        Friend WithEvents col_tot_dia As DataGridViewTextBoxColumn
        Friend WithEvents col_ing_tot As DataGridViewTextBoxColumn
    End Class
End Namespace