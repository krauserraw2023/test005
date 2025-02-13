Namespace Tratamiento.Asistencia.Clasificacion.Penal
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmAddClasifEtapaPopupProv
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.components = New System.ComponentModel.Container()
            Me.PnlBotonesPrincipal = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnGrabarClasificacion = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.nudMinutos = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.TextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.nudHora = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbSitJuridica = New System.Windows.Forms.ComboBox()
            Me.lblRegimen = New System.Windows.Forms.Label()
            Me.cbbRegimen = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.rdbRegimenETL = New System.Windows.Forms.RadioButton()
            Me.rdbClasifRegimenPenal = New System.Windows.Forms.RadioButton()
            Me.grupProv = New System.Windows.Forms.GroupBox()
            Me.grupoETL = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaETL = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.cbbSitJuridicaETL = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.nudMinutosETL = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.MyTextBox2 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbRegimenETL = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.nudHoraETL = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.MyTextBox1 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dtpFechaETAPA = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.nudMinutosETAPA = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox4 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.nudHoraETAPA = New Legolas.APPUIComponents.uscNumericUpDown()
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.MyTextBox3 = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.PnlBotonesPrincipal.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.nudMinutos.SuspendLayout()
            Me.nudHora.SuspendLayout()
            Me.grupProv.SuspendLayout()
            Me.grupoETL.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.nudMinutosETL.SuspendLayout()
            Me.nudHoraETL.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.nudMinutosETAPA.SuspendLayout()
            Me.nudHoraETAPA.SuspendLayout()
            Me.SuspendLayout()
            '
            'PnlBotonesPrincipal
            '
            Me.PnlBotonesPrincipal.Controls.Add(Me.Panel2)
            Me.PnlBotonesPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotonesPrincipal.Location = New System.Drawing.Point(0, 239)
            Me.PnlBotonesPrincipal.Name = "PnlBotonesPrincipal"
            Me.PnlBotonesPrincipal.Size = New System.Drawing.Size(582, 43)
            Me.PnlBotonesPrincipal.TabIndex = 5
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnGrabarClasificacion)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(396, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(186, 43)
            Me.Panel2.TabIndex = 3
            '
            'btnGrabarClasificacion
            '
            Me.btnGrabarClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarClasificacion.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnGrabarClasificacion.Location = New System.Drawing.Point(4, 1)
            Me.btnGrabarClasificacion.Name = "btnGrabarClasificacion"
            Me.btnGrabarClasificacion.Size = New System.Drawing.Size(89, 40)
            Me.btnGrabarClasificacion.TabIndex = 1
            Me.btnGrabarClasificacion.Text = "&Grabar"
            Me.btnGrabarClasificacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(94, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'nudMinutos
            '
            Me.nudMinutos._Formato = "00"
            Me.nudMinutos._Increment = 1
            Me.nudMinutos._Maximum = 59
            Me.nudMinutos._Minimum = 0
            Me.nudMinutos._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutos._Value = 0
            Me.nudMinutos.Controls.Add(Me.TextBox1)
            Me.nudMinutos.Enabled = False
            Me.nudMinutos.Location = New System.Drawing.Point(251, 15)
            Me.nudMinutos.Name = "nudMinutos"
            Me.nudMinutos.Size = New System.Drawing.Size(35, 20)
            Me.nudMinutos.TabIndex = 36
            '
            'TextBox1
            '
            Me.TextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.TextBox1._BloquearPaste = False
            Me.TextBox1._SeleccionarTodo = False
            Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TextBox1.Location = New System.Drawing.Point(2, 3)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(15, 13)
            Me.TextBox1.TabIndex = 0
            Me.TextBox1.Text = "00"
            Me.TextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.TextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'nudHora
            '
            Me.nudHora._Formato = "00"
            Me.nudHora._Increment = 1
            Me.nudHora._Maximum = 23
            Me.nudHora._Minimum = 0
            Me.nudHora._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHora._Value = 0
            Me.nudHora.Controls.Add(Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388)
            Me.nudHora.Enabled = False
            Me.nudHora.Location = New System.Drawing.Point(208, 15)
            Me.nudHora.Name = "nudHora"
            Me.nudHora.Size = New System.Drawing.Size(35, 20)
            Me.nudHora.TabIndex = 35
            '
            'object_620640d6_ba6a_4f6f_821d_5ca36eea9388
            '
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388._BloquearPaste = False
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388._SeleccionarTodo = False
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.Location = New System.Drawing.Point(2, 3)
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.Name = "object_620640d6_ba6a_4f6f_821d_5ca36eea9388"
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.Size = New System.Drawing.Size(15, 13)
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.TabIndex = 0
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.Text = "00"
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_620640d6_ba6a_4f6f_821d_5ca36eea9388.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'dtpFecha
            '
            Me.dtpFecha.Enabled = False
            Me.dtpFecha.Location = New System.Drawing.Point(122, 15)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecha.TabIndex = 34
            Me.dtpFecha.Value = "/  /"
            Me.dtpFecha.ValueLong = CType(0, Long)
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Enabled = False
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(240, 19)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(11, 13)
            Me.Label8.TabIndex = 32
            Me.Label8.Text = ":"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(20, 19)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(102, 13)
            Me.Label11.TabIndex = 33
            Me.Label11.Text = "Fecha Clasificación:"
            '
            'Label9
            '
            Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(300, 19)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(95, 13)
            Me.Label9.TabIndex = 37
            Me.Label9.Text = "Situación Jurídica:"
            '
            'cbbSitJuridica
            '
            Me.cbbSitJuridica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbbSitJuridica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbSitJuridica.Enabled = False
            Me.cbbSitJuridica.FormattingEnabled = True
            Me.cbbSitJuridica.Items.AddRange(New Object() {"[--SELECCIONE--]", "PROCESADO", "SENTENCIADO"})
            Me.cbbSitJuridica.Location = New System.Drawing.Point(399, 14)
            Me.cbbSitJuridica.Name = "cbbSitJuridica"
            Me.cbbSitJuridica.Size = New System.Drawing.Size(124, 21)
            Me.cbbSitJuridica.TabIndex = 38
            '
            'lblRegimen
            '
            Me.lblRegimen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblRegimen.AutoSize = True
            Me.lblRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblRegimen.Location = New System.Drawing.Point(52, 43)
            Me.lblRegimen.Name = "lblRegimen"
            Me.lblRegimen.Size = New System.Drawing.Size(63, 13)
            Me.lblRegimen.TabIndex = 39
            Me.lblRegimen.Text = "REGIMEN :"
            Me.lblRegimen.Visible = False
            '
            'cbbRegimen
            '
            Me.cbbRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimen.Enabled = False
            Me.cbbRegimen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimen.Location = New System.Drawing.Point(122, 38)
            Me.cbbRegimen.Name = "cbbRegimen"
            Me.cbbRegimen.Size = New System.Drawing.Size(401, 23)
            Me.cbbRegimen.TabIndex = 40
            Me.cbbRegimen.Visible = False
            '
            'rdbRegimenETL
            '
            Me.rdbRegimenETL.AutoSize = True
            Me.rdbRegimenETL.Checked = True
            Me.rdbRegimenETL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbRegimenETL.Location = New System.Drawing.Point(23, 10)
            Me.rdbRegimenETL.Name = "rdbRegimenETL"
            Me.rdbRegimenETL.Size = New System.Drawing.Size(430, 17)
            Me.rdbRegimenETL.TabIndex = 41
            Me.rdbRegimenETL.TabStop = True
            Me.rdbRegimenETL.Text = "Clasificación de régimen en carceleta (Interno clasificado en carceleta)"
            Me.rdbRegimenETL.UseVisualStyleBackColor = True
            '
            'rdbClasifRegimenPenal
            '
            Me.rdbClasifRegimenPenal.AutoSize = True
            Me.rdbClasifRegimenPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbClasifRegimenPenal.Location = New System.Drawing.Point(23, 172)
            Me.rdbClasifRegimenPenal.Name = "rdbClasifRegimenPenal"
            Me.rdbClasifRegimenPenal.Size = New System.Drawing.Size(414, 17)
            Me.rdbClasifRegimenPenal.TabIndex = 42
            Me.rdbClasifRegimenPenal.Text = "Clasificación de régimen en el penal (Interno clasificado en el penal)"
            Me.rdbClasifRegimenPenal.UseVisualStyleBackColor = True
            '
            'grupProv
            '
            Me.grupProv.Controls.Add(Me.dtpFecha)
            Me.grupProv.Controls.Add(Me.Label11)
            Me.grupProv.Controls.Add(Me.Label8)
            Me.grupProv.Controls.Add(Me.lblRegimen)
            Me.grupProv.Controls.Add(Me.nudHora)
            Me.grupProv.Controls.Add(Me.cbbRegimen)
            Me.grupProv.Controls.Add(Me.nudMinutos)
            Me.grupProv.Controls.Add(Me.Label9)
            Me.grupProv.Controls.Add(Me.cbbSitJuridica)
            Me.grupProv.Enabled = False
            Me.grupProv.Location = New System.Drawing.Point(45, 185)
            Me.grupProv.Name = "grupProv"
            Me.grupProv.Size = New System.Drawing.Size(526, 50)
            Me.grupProv.TabIndex = 43
            Me.grupProv.TabStop = False
            '
            'grupoETL
            '
            Me.grupoETL.Controls.Add(Me.GroupBox2)
            Me.grupoETL.Controls.Add(Me.GroupBox1)
            Me.grupoETL.Location = New System.Drawing.Point(45, 22)
            Me.grupoETL.Name = "grupoETL"
            Me.grupoETL.Size = New System.Drawing.Size(528, 140)
            Me.grupoETL.TabIndex = 44
            Me.grupoETL.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.dtpFechaETL)
            Me.GroupBox2.Controls.Add(Me.cbbSitJuridicaETL)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.nudMinutosETL)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.cbbRegimenETL)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.nudHoraETL)
            Me.GroupBox2.Location = New System.Drawing.Point(11, 11)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(513, 74)
            Me.GroupBox2.TabIndex = 46
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Clasificación Régimen"
            '
            'dtpFechaETL
            '
            Me.dtpFechaETL.Location = New System.Drawing.Point(109, 19)
            Me.dtpFechaETL.Name = "dtpFechaETL"
            Me.dtpFechaETL.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaETL.TabIndex = 34
            Me.dtpFechaETL.Value = "/  /"
            Me.dtpFechaETL.ValueLong = CType(0, Long)
            '
            'cbbSitJuridicaETL
            '
            Me.cbbSitJuridicaETL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbbSitJuridicaETL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbSitJuridicaETL.FormattingEnabled = True
            Me.cbbSitJuridicaETL.Items.AddRange(New Object() {"[--SELECCIONE--]", "PROCESADO", "SENTENCIADO"})
            Me.cbbSitJuridicaETL.Location = New System.Drawing.Point(386, 18)
            Me.cbbSitJuridicaETL.Name = "cbbSitJuridicaETL"
            Me.cbbSitJuridicaETL.Size = New System.Drawing.Size(124, 21)
            Me.cbbSitJuridicaETL.TabIndex = 38
            '
            'Label4
            '
            Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(287, 23)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 37
            Me.Label4.Text = "Situación Jurídica:"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(102, 13)
            Me.Label1.TabIndex = 33
            Me.Label1.Text = "Fecha Clasificación:"
            '
            'nudMinutosETL
            '
            Me.nudMinutosETL._Formato = "00"
            Me.nudMinutosETL._Increment = 1
            Me.nudMinutosETL._Maximum = 59
            Me.nudMinutosETL._Minimum = 0
            Me.nudMinutosETL._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutosETL._Value = 0
            Me.nudMinutosETL.Controls.Add(Me.MyTextBox2)
            Me.nudMinutosETL.Location = New System.Drawing.Point(238, 19)
            Me.nudMinutosETL.Name = "nudMinutosETL"
            Me.nudMinutosETL.Size = New System.Drawing.Size(35, 20)
            Me.nudMinutosETL.TabIndex = 36
            '
            'MyTextBox2
            '
            Me.MyTextBox2._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox2._BloquearPaste = False
            Me.MyTextBox2._SeleccionarTodo = False
            Me.MyTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox2.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox2.Name = "MyTextBox2"
            Me.MyTextBox2.Size = New System.Drawing.Size(15, 13)
            Me.MyTextBox2.TabIndex = 0
            Me.MyTextBox2.Text = "00"
            Me.MyTextBox2.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox2.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(227, 23)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(11, 13)
            Me.Label2.TabIndex = 32
            Me.Label2.Text = ":"
            '
            'cbbRegimenETL
            '
            Me.cbbRegimenETL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbRegimenETL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegimenETL.Location = New System.Drawing.Point(109, 46)
            Me.cbbRegimenETL.Name = "cbbRegimenETL"
            Me.cbbRegimenETL.Size = New System.Drawing.Size(401, 23)
            Me.cbbRegimenETL.TabIndex = 40
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(39, 51)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(63, 13)
            Me.Label3.TabIndex = 39
            Me.Label3.Text = "REGIMEN :"
            '
            'nudHoraETL
            '
            Me.nudHoraETL._Formato = "00"
            Me.nudHoraETL._Increment = 1
            Me.nudHoraETL._Maximum = 23
            Me.nudHoraETL._Minimum = 0
            Me.nudHoraETL._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHoraETL._Value = 0
            Me.nudHoraETL.Controls.Add(Me.MyTextBox1)
            Me.nudHoraETL.Location = New System.Drawing.Point(195, 19)
            Me.nudHoraETL.Name = "nudHoraETL"
            Me.nudHoraETL.Size = New System.Drawing.Size(35, 20)
            Me.nudHoraETL.TabIndex = 35
            '
            'MyTextBox1
            '
            Me.MyTextBox1._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox1._BloquearPaste = False
            Me.MyTextBox1._SeleccionarTodo = False
            Me.MyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox1.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox1.Name = "MyTextBox1"
            Me.MyTextBox1.Size = New System.Drawing.Size(15, 13)
            Me.MyTextBox1.TabIndex = 0
            Me.MyTextBox1.Text = "00"
            Me.MyTextBox1.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox1.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.dtpFechaETAPA)
            Me.GroupBox1.Controls.Add(Me.nudMinutosETAPA)
            Me.GroupBox1.Controls.Add(Me.nudHoraETAPA)
            Me.GroupBox1.Location = New System.Drawing.Point(11, 89)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(513, 45)
            Me.GroupBox1.TabIndex = 45
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Clasificación etapa"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(17, 21)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(102, 13)
            Me.Label5.TabIndex = 41
            Me.Label5.Text = "Fecha Clasificación:"
            '
            'dtpFechaETAPA
            '
            Me.dtpFechaETAPA.Location = New System.Drawing.Point(119, 17)
            Me.dtpFechaETAPA.Name = "dtpFechaETAPA"
            Me.dtpFechaETAPA.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaETAPA.TabIndex = 42
            Me.dtpFechaETAPA.Value = "/  /"
            Me.dtpFechaETAPA.ValueLong = CType(0, Long)
            '
            'nudMinutosETAPA
            '
            Me.nudMinutosETAPA._Formato = "00"
            Me.nudMinutosETAPA._Increment = 1
            Me.nudMinutosETAPA._Maximum = 59
            Me.nudMinutosETAPA._Minimum = 0
            Me.nudMinutosETAPA._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudMinutosETAPA._Value = 0
            Me.nudMinutosETAPA.Controls.Add(Me.object_22f1459f_f9c3_476a_b2cd_972256d82864)
            Me.nudMinutosETAPA.Controls.Add(Me.MyTextBox4)
            Me.nudMinutosETAPA.Location = New System.Drawing.Point(248, 17)
            Me.nudMinutosETAPA.Name = "nudMinutosETAPA"
            Me.nudMinutosETAPA.Size = New System.Drawing.Size(35, 20)
            Me.nudMinutosETAPA.TabIndex = 44
            '
            'object_22f1459f_f9c3_476a_b2cd_972256d82864
            '
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864._BloquearPaste = False
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864._SeleccionarTodo = False
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.Location = New System.Drawing.Point(2, 3)
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.Name = "object_22f1459f_f9c3_476a_b2cd_972256d82864"
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.Size = New System.Drawing.Size(15, 13)
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.TabIndex = 0
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.Text = "00"
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_22f1459f_f9c3_476a_b2cd_972256d82864.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox4
            '
            Me.MyTextBox4._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox4._BloquearPaste = False
            Me.MyTextBox4._SeleccionarTodo = False
            Me.MyTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox4.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox4.Name = "MyTextBox4"
            Me.MyTextBox4.Size = New System.Drawing.Size(15, 13)
            Me.MyTextBox4.TabIndex = 0
            Me.MyTextBox4.Text = "00"
            Me.MyTextBox4.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox4.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'nudHoraETAPA
            '
            Me.nudHoraETAPA._Formato = "00"
            Me.nudHoraETAPA._Increment = 1
            Me.nudHoraETAPA._Maximum = 23
            Me.nudHoraETAPA._Minimum = 0
            Me.nudHoraETAPA._TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.nudHoraETAPA._Value = 0
            Me.nudHoraETAPA.Controls.Add(Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a)
            Me.nudHoraETAPA.Controls.Add(Me.MyTextBox3)
            Me.nudHoraETAPA.Location = New System.Drawing.Point(205, 17)
            Me.nudHoraETAPA.Name = "nudHoraETAPA"
            Me.nudHoraETAPA.Size = New System.Drawing.Size(35, 20)
            Me.nudHoraETAPA.TabIndex = 43
            '
            'object_f9eb587d_7147_4116_9d9d_8f172a7bba9a
            '
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a._BloquearPaste = False
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a._SeleccionarTodo = False
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.Location = New System.Drawing.Point(2, 3)
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.Name = "object_f9eb587d_7147_4116_9d9d_8f172a7bba9a"
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.Size = New System.Drawing.Size(15, 13)
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.TabIndex = 0
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.Text = "00"
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.object_f9eb587d_7147_4116_9d9d_8f172a7bba9a.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'MyTextBox3
            '
            Me.MyTextBox3._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.MyTextBox3._BloquearPaste = False
            Me.MyTextBox3._SeleccionarTodo = False
            Me.MyTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MyTextBox3.Location = New System.Drawing.Point(2, 3)
            Me.MyTextBox3.Name = "MyTextBox3"
            Me.MyTextBox3.Size = New System.Drawing.Size(15, 13)
            Me.MyTextBox3.TabIndex = 0
            Me.MyTextBox3.Text = "00"
            Me.MyTextBox3.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.MyTextBox3.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'frmAddClasifEtapaPopupProv
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(582, 282)
            Me.Controls.Add(Me.rdbClasifRegimenPenal)
            Me.Controls.Add(Me.rdbRegimenETL)
            Me.Controls.Add(Me.grupoETL)
            Me.Controls.Add(Me.grupProv)
            Me.Controls.Add(Me.PnlBotonesPrincipal)
            Me.Name = "frmAddClasifEtapaPopupProv"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = ".::. "
            Me.PnlBotonesPrincipal.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.nudMinutos.ResumeLayout(False)
            Me.nudMinutos.PerformLayout()
            Me.nudHora.ResumeLayout(False)
            Me.nudHora.PerformLayout()
            Me.grupProv.ResumeLayout(False)
            Me.grupProv.PerformLayout()
            Me.grupoETL.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.nudMinutosETL.ResumeLayout(False)
            Me.nudMinutosETL.PerformLayout()
            Me.nudHoraETL.ResumeLayout(False)
            Me.nudHoraETL.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.nudMinutosETAPA.ResumeLayout(False)
            Me.nudMinutosETAPA.PerformLayout()
            Me.nudHoraETAPA.ResumeLayout(False)
            Me.nudHoraETAPA.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents PnlBotonesPrincipal As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnGrabarClasificacion As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents nudMinutos As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents TextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents nudHora As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents object_620640d6_ba6a_4f6f_821d_5ca36eea9388 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label8 As Label
        Friend WithEvents Label11 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents cbbSitJuridica As ComboBox
        Friend WithEvents lblRegimen As Label
        Friend WithEvents cbbRegimen As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents rdbRegimenETL As RadioButton
        Friend WithEvents rdbClasifRegimenPenal As RadioButton
        Friend WithEvents grupProv As GroupBox
        Friend WithEvents grupoETL As GroupBox
        Friend WithEvents dtpFechaETL As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents nudHoraETL As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents MyTextBox1 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents cbbRegimenETL As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents nudMinutosETL As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents MyTextBox2 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents cbbSitJuridicaETL As ComboBox
        Friend WithEvents dtpFechaETAPA As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As Label
        Friend WithEvents nudHoraETAPA As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents object_f9eb587d_7147_4116_9d9d_8f172a7bba9a As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox3 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents nudMinutosETAPA As Legolas.APPUIComponents.uscNumericUpDown
        Friend WithEvents object_22f1459f_f9c3_476a_b2cd_972256d82864 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents MyTextBox4 As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents GroupBox2 As GroupBox
    End Class
End Namespace