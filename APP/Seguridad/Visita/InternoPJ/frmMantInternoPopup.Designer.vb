Namespace Visita.InternoPJ
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantInternoPopup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantInternoPopup))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.gbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.UscRegionPenalLabel1 = New APPControls.uscRegionPenalLabel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.pnlGrabar = New System.Windows.Forms.Panel()
            Me.btnGrabar = New System.Windows.Forms.Button()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.dtpFechaIng = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.chkOmitirFecha = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.chk_estado = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.lblPabellon = New System.Windows.Forms.Label()
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.cbbSexo = New APPControls.uscComboParametrica()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.cbbPabellon = New APPControls.uscComboPabellon()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtobservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.gbxFormChildContainer.SuspendLayout()
            Me.gbRegionPenal.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.pnlGrabar.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.cbbPabellon.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Controls.Add(Me.gbRegionPenal)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(544, 342)
            '
            'BackgroundWorker1
            '
            '
            'gbRegionPenal
            '
            Me.gbRegionPenal.Controls.Add(Me.UscRegionPenalLabel1)
            Me.gbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbRegionPenal.Location = New System.Drawing.Point(0, 0)
            Me.gbRegionPenal.Name = "gbRegionPenal"
            Me.gbRegionPenal.Size = New System.Drawing.Size(544, 40)
            Me.gbRegionPenal.TabIndex = 65
            Me.gbRegionPenal.TabStop = False
            '
            'UscRegionPenalLabel1
            '
            Me.UscRegionPenalLabel1._Penalid = -1
            Me.UscRegionPenalLabel1._PenalNombre = "************"
            Me.UscRegionPenalLabel1._RegionId = -1
            Me.UscRegionPenalLabel1._RegionNombre = "************"
            Me.UscRegionPenalLabel1._WidthRegion = 250
            Me.UscRegionPenalLabel1.BackColor = System.Drawing.Color.Transparent
            Me.UscRegionPenalLabel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscRegionPenalLabel1.Location = New System.Drawing.Point(3, 16)
            Me.UscRegionPenalLabel1.Margin = New System.Windows.Forms.Padding(1)
            Me.UscRegionPenalLabel1.Name = "UscRegionPenalLabel1"
            Me.UscRegionPenalLabel1.Size = New System.Drawing.Size(538, 21)
            Me.UscRegionPenalLabel1.TabIndex = 63
            Me.UscRegionPenalLabel1.UsuarioID = -1
            Me.UscRegionPenalLabel1.VersionInstalacionFile = 0
            '
            'GroupBox4
            '
            Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox4.Controls.Add(Me.Panel1)
            Me.GroupBox4.Controls.Add(Me.dtpFechaIng)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.chkOmitirFecha)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.chk_estado)
            Me.GroupBox4.Controls.Add(Me.lblPabellon)
            Me.GroupBox4.Controls.Add(Me.dtpFechaNac)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.Label11)
            Me.GroupBox4.Controls.Add(Me.txtApePat)
            Me.GroupBox4.Controls.Add(Me.txtNumDoc)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.txtNom)
            Me.GroupBox4.Controls.Add(Me.Label5)
            Me.GroupBox4.Controls.Add(Me.txtApeMat)
            Me.GroupBox4.Controls.Add(Me.Label12)
            Me.GroupBox4.Controls.Add(Me.Label13)
            Me.GroupBox4.Controls.Add(Me.cbbSexo)
            Me.GroupBox4.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox4.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox4.Controls.Add(Me.cbbPabellon)
            Me.GroupBox4.Controls.Add(Me.txtobservacion)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 40)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(544, 302)
            Me.GroupBox4.TabIndex = 66
            Me.GroupBox4.TabStop = False
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.pnlGrabar)
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(3, 254)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(538, 45)
            Me.Panel1.TabIndex = 27
            '
            'pnlGrabar
            '
            Me.pnlGrabar.Controls.Add(Me.btnGrabar)
            Me.pnlGrabar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabar.Location = New System.Drawing.Point(328, 0)
            Me.pnlGrabar.Name = "pnlGrabar"
            Me.pnlGrabar.Size = New System.Drawing.Size(100, 45)
            Me.pnlGrabar.TabIndex = 1
            '
            'btnGrabar
            '
            Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabar.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabar.Location = New System.Drawing.Point(3, 3)
            Me.btnGrabar.Name = "btnGrabar"
            Me.btnGrabar.Size = New System.Drawing.Size(97, 40)
            Me.btnGrabar.TabIndex = 15
            Me.btnGrabar.Text = "&Grabar"
            Me.btnGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnGrabar.UseVisualStyleBackColor = True
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.btnSalir)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel5.Location = New System.Drawing.Point(428, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(110, 45)
            Me.Panel5.TabIndex = 2
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 44
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'dtpFechaIng
            '
            Me.dtpFechaIng.Location = New System.Drawing.Point(390, 146)
            Me.dtpFechaIng.Name = "dtpFechaIng"
            Me.dtpFechaIng.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIng.TabIndex = 21
            Me.dtpFechaIng.Value = "/  /"
            Me.dtpFechaIng.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(292, 150)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(72, 13)
            Me.Label6.TabIndex = 20
            Me.Label6.Text = "Fec. Ingreso :"
            '
            'chkOmitirFecha
            '
            Me.chkOmitirFecha.Location = New System.Drawing.Point(197, 147)
            Me.chkOmitirFecha.Name = "chkOmitirFecha"
            Me.chkOmitirFecha.Size = New System.Drawing.Size(84, 21)
            Me.chkOmitirFecha.TabIndex = 11
            Me.chkOmitirFecha.Text = "Omitir fecha"
            Me.chkOmitirFecha.UseVisualStyleBackColor = True
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(9, 185)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(73, 13)
            Me.Label7.TabIndex = 24
            Me.Label7.Text = "Observacion :"
            '
            'chk_estado
            '
            Me.chk_estado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chk_estado.Checked = True
            Me.chk_estado.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chk_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chk_estado.Location = New System.Drawing.Point(9, 12)
            Me.chk_estado.Name = "chk_estado"
            Me.chk_estado.Size = New System.Drawing.Size(150, 21)
            Me.chk_estado.TabIndex = 0
            Me.chk_estado.Text = "Estado (Activo)  :"
            Me.chk_estado.UseVisualStyleBackColor = True
            '
            'lblPabellon
            '
            Me.lblPabellon.AutoSize = True
            Me.lblPabellon.Location = New System.Drawing.Point(292, 123)
            Me.lblPabellon.Name = "lblPabellon"
            Me.lblPabellon.Size = New System.Drawing.Size(54, 13)
            Me.lblPabellon.TabIndex = 18
            Me.lblPabellon.Text = "Pabellon :"
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(107, 146)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 10
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(9, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(90, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Primer Apellido :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(292, 95)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(75, 13)
            Me.Label11.TabIndex = 16
            Me.Label11.Text = "Nacionalidad :"
            '
            'txtApePat
            '
            Me.txtApePat._BloquearPaste = True
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.BackColor = System.Drawing.SystemColors.Info
            Me.txtApePat.ForeColor = System.Drawing.SystemColors.InfoText
            Me.txtApePat.Location = New System.Drawing.Point(107, 40)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(169, 20)
            Me.txtApePat.TabIndex = 2
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Location = New System.Drawing.Point(390, 66)
            Me.txtNumDoc.MaxLength = 8
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(143, 20)
            Me.txtNumDoc.TabIndex = 15
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 70)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 13)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Segundo Apellido:"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(9, 95)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Nombres :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(9, 123)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(37, 13)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Sexo :"
            '
            'txtNom
            '
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(107, 92)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(169, 20)
            Me.txtNom.TabIndex = 6
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(9, 150)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(69, 13)
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "Fecha Nac. :"
            '
            'txtApeMat
            '
            Me.txtApeMat._BloquearPaste = True
            Me.txtApeMat._SeleccionarTodo = False
            Me.txtApeMat.Location = New System.Drawing.Point(107, 66)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(169, 20)
            Me.txtApeMat.TabIndex = 4
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label12
            '
            Me.Label12.AutoSize = True
            Me.Label12.Location = New System.Drawing.Point(292, 43)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(60, 13)
            Me.Label12.TabIndex = 12
            Me.Label12.Text = "Tipo Doc. :"
            '
            'Label13
            '
            Me.Label13.AutoSize = True
            Me.Label13.Location = New System.Drawing.Point(292, 70)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(76, 13)
            Me.Label13.TabIndex = 14
            Me.Label13.Text = "Numero Doc. :"
            '
            'cbbSexo
            '
            Me.cbbSexo._NoIndica = False
            Me.cbbSexo._Todos = False
            Me.cbbSexo._TodosMensaje = ""
            Me.cbbSexo._Visible_Add = False
            Me.cbbSexo._Visible_Buscar = False
            Me.cbbSexo._Visible_Eliminar = False
            Me.cbbSexo.CodigoPadre = -1
            Me.cbbSexo.ComboTipo = Type.Combo.ComboTipo.Sexo
            Me.cbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSexo.DropDownWidth = 143
            Me.cbbSexo.DropDownWidthAuto = False
            Me.cbbSexo.Location = New System.Drawing.Point(107, 120)
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(169, 22)
            Me.cbbSexo.TabIndex = 8
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = Type.Combo.ComboTipo.Nacionalidad
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 143
            Me.cbbNacionalidad.DropDownWidthAuto = False
            Me.cbbNacionalidad.Location = New System.Drawing.Point(390, 92)
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(143, 22)
            Me.cbbNacionalidad.TabIndex = 17
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = Type.Combo.ComboTipo.TipoDoc
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 143
            Me.cbbTipoDoc.DropDownWidthAuto = False
            Me.cbbTipoDoc.Location = New System.Drawing.Point(390, 40)
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(143, 22)
            Me.cbbTipoDoc.TabIndex = 13
            '
            'cbbPabellon
            '
            Me.cbbPabellon._Ninguno = False
            Me.cbbPabellon._PenalID = -1
            Me.cbbPabellon._RegionID = -1
            Me.cbbPabellon._SelectedValue = 0
            Me.cbbPabellon._Todos = False
            Me.cbbPabellon.Controls.Add(Me.ComboBox1)
            Me.cbbPabellon.Location = New System.Drawing.Point(390, 120)
            Me.cbbPabellon.Name = "cbbPabellon"
            Me.cbbPabellon.Size = New System.Drawing.Size(143, 22)
            Me.cbbPabellon.TabIndex = 19
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
            Me.ComboBox1.TabIndex = 3
            '
            'txtobservacion
            '
            Me.txtobservacion._BloquearPaste = False
            Me.txtobservacion._SeleccionarTodo = False
            Me.txtobservacion.Location = New System.Drawing.Point(107, 182)
            Me.txtobservacion.Multiline = True
            Me.txtobservacion.Name = "txtobservacion"
            Me.txtobservacion.Size = New System.Drawing.Size(426, 66)
            Me.txtobservacion.TabIndex = 25
            Me.txtobservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtobservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'frmMantInternoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(544, 342)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMantInternoPopup"
            Me.Text = "Agregar Poblacion del Poder Judicial"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbRegionPenal.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.pnlGrabar.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.cbbPabellon.ResumeLayout(False)
            Me.ResumeLayout(False)

End Sub
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents UscRegionPenalLabel1 As APPControls.uscRegionPenalLabel
        Friend WithEvents gbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaIng As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents chkOmitirFecha As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents chk_estado As Legolas.APPUIComponents.myCheckBox
        Friend WithEvents lblPabellon As System.Windows.Forms.Label
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents cbbPabellon As APPControls.uscComboPabellon
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents txtobservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabar As System.Windows.Forms.Panel
        Friend WithEvents btnGrabar As System.Windows.Forms.Button
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button

    End Class
End Namespace

