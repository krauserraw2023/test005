Namespace Registro.Captura
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmOdontogramaPopup
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOdontogramaPopup))
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtEspecific = New System.Windows.Forms.TextBox()
            Me.txtObs = New System.Windows.Forms.TextBox()
            Me.TabControl1 = New System.Windows.Forms.TabControl()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbTamDentomax = New APPControls.uscComboParametrica()
            Me.cbbTamanioDiente = New APPControls.uscComboParametrica()
            Me.cbbTipoDiente = New APPControls.uscComboParametrica()
            Me.cbbTipoOclus = New APPControls.uscComboParametrica()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.rbdNoRegistra = New System.Windows.Forms.RadioButton()
            Me.rdbIV = New System.Windows.Forms.RadioButton()
            Me.rdbIII = New System.Windows.Forms.RadioButton()
            Me.rdbII = New System.Windows.Forms.RadioButton()
            Me.rdbI = New System.Windows.Forms.RadioButton()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.Panel11 = New System.Windows.Forms.Panel()
            Me.rdbInfNoRegistra = New System.Windows.Forms.RadioButton()
            Me.rdbInfOvoide = New System.Windows.Forms.RadioButton()
            Me.rdbInfTriang = New System.Windows.Forms.RadioButton()
            Me.rdbInfCuadrado = New System.Windows.Forms.RadioButton()
            Me.Panel10 = New System.Windows.Forms.Panel()
            Me.rdbSupNoRegistra = New System.Windows.Forms.RadioButton()
            Me.rdbSupOvoide = New System.Windows.Forms.RadioButton()
            Me.rdbSupTriang = New System.Windows.Forms.RadioButton()
            Me.rdbSupCuadrado = New System.Windows.Forms.RadioButton()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel9 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.Panel8 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.uscOdontograma = New AxCTLODONLib.AxCtlOdon()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.TabPage1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.TabPage2.SuspendLayout()
            Me.Panel11.SuspendLayout()
            Me.Panel10.SuspendLayout()
            CType(Me.uscOdontograma, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.uscOdontograma)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(949, 549)
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscAuditUser1)
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 502)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(949, 47)
            Me.Panel2.TabIndex = 4
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 5)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(648, 42)
            Me.UscAuditUser1.TabIndex = 6
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(648, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(198, 47)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(99, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(846, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(103, 47)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.LightGray
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.TabControl1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(573, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(376, 502)
            Me.Panel1.TabIndex = 7
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.Label8)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.txtEspecific)
            Me.GroupBox4.Controls.Add(Me.txtObs)
            Me.GroupBox4.Location = New System.Drawing.Point(3, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(371, 167)
            Me.GroupBox4.TabIndex = 9
            Me.GroupBox4.TabStop = False
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(6, 10)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(81, 13)
            Me.Label8.TabIndex = 14
            Me.Label8.Text = "Observaciones:"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(8, 90)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(90, 13)
            Me.Label7.TabIndex = 15
            Me.Label7.Text = "Especificaciones:"
            '
            'txtEspecific
            '
            Me.txtEspecific.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtEspecific.Location = New System.Drawing.Point(5, 108)
            Me.txtEspecific.MaxLength = 1000
            Me.txtEspecific.Multiline = True
            Me.txtEspecific.Name = "txtEspecific"
            Me.txtEspecific.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtEspecific.Size = New System.Drawing.Size(360, 53)
            Me.txtEspecific.TabIndex = 1
            '
            'txtObs
            '
            Me.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtObs.Location = New System.Drawing.Point(5, 27)
            Me.txtObs.MaxLength = 1000
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(360, 53)
            Me.txtObs.TabIndex = 0
            '
            'TabControl1
            '
            Me.TabControl1.Controls.Add(Me.TabPage1)
            Me.TabControl1.Controls.Add(Me.TabPage2)
            Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabControl1.Location = New System.Drawing.Point(3, 172)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New System.Drawing.Size(367, 327)
            Me.TabControl1.TabIndex = 8
            '
            'TabPage1
            '
            Me.TabPage1.Controls.Add(Me.GroupBox1)
            Me.TabPage1.Controls.Add(Me.GroupBox2)
            Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(359, 301)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "DATO DIENTES / RUGA PALATINA"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbTamDentomax)
            Me.GroupBox1.Controls.Add(Me.cbbTamanioDiente)
            Me.GroupBox1.Controls.Add(Me.cbbTipoDiente)
            Me.GroupBox1.Controls.Add(Me.cbbTipoOclus)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(5, 9)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(349, 126)
            Me.GroupBox1.TabIndex = 5
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Dato dentario"
            '
            'cbbTamDentomax
            '
            Me.cbbTamDentomax._NoIndica = False
            Me.cbbTamDentomax._Todos = False
            Me.cbbTamDentomax._TodosMensaje = ""
            Me.cbbTamDentomax._Visible_Add = False
            Me.cbbTamDentomax._Visible_Buscar = False
            Me.cbbTamDentomax._Visible_Eliminar = False
            Me.cbbTamDentomax.CodigoPadre = -1
            Me.cbbTamDentomax.ComboTipo = Type.Combo.ComboTipo.OdontogramaTamanioDentomaxilar
            Me.cbbTamDentomax.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTamDentomax.DropDownWidth = 224
            Me.cbbTamDentomax.DropDownWidthAuto = False
            Me.cbbTamDentomax.Location = New System.Drawing.Point(119, 93)
            Me.cbbTamDentomax.Name = "cbbTamDentomax"
            Me.cbbTamDentomax.Parametro1 = -1
            Me.cbbTamDentomax.Parametro2 = -1
            Me.cbbTamDentomax.SelectedIndex = -1
            Me.cbbTamDentomax.SelectedValue = 0
            Me.cbbTamDentomax.Size = New System.Drawing.Size(224, 22)
            Me.cbbTamDentomax.TabIndex = 8
            '
            'cbbTamanioDiente
            '
            Me.cbbTamanioDiente._NoIndica = False
            Me.cbbTamanioDiente._Todos = False
            Me.cbbTamanioDiente._TodosMensaje = ""
            Me.cbbTamanioDiente._Visible_Add = False
            Me.cbbTamanioDiente._Visible_Buscar = False
            Me.cbbTamanioDiente._Visible_Eliminar = False
            Me.cbbTamanioDiente.CodigoPadre = -1
            Me.cbbTamanioDiente.ComboTipo = Type.Combo.ComboTipo.OdontogramaTamanioDiente
            Me.cbbTamanioDiente.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTamanioDiente.DropDownWidth = 224
            Me.cbbTamanioDiente.DropDownWidthAuto = False
            Me.cbbTamanioDiente.Location = New System.Drawing.Point(119, 68)
            Me.cbbTamanioDiente.Name = "cbbTamanioDiente"
            Me.cbbTamanioDiente.Parametro1 = -1
            Me.cbbTamanioDiente.Parametro2 = -1
            Me.cbbTamanioDiente.SelectedIndex = -1
            Me.cbbTamanioDiente.SelectedValue = 0
            Me.cbbTamanioDiente.Size = New System.Drawing.Size(224, 22)
            Me.cbbTamanioDiente.TabIndex = 7
            '
            'cbbTipoDiente
            '
            Me.cbbTipoDiente._NoIndica = False
            Me.cbbTipoDiente._Todos = False
            Me.cbbTipoDiente._TodosMensaje = ""
            Me.cbbTipoDiente._Visible_Add = False
            Me.cbbTipoDiente._Visible_Buscar = False
            Me.cbbTipoDiente._Visible_Eliminar = False
            Me.cbbTipoDiente.CodigoPadre = -1
            Me.cbbTipoDiente.ComboTipo = Type.Combo.ComboTipo.OdontogramaDienteTipo
            Me.cbbTipoDiente.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDiente.DropDownWidth = 224
            Me.cbbTipoDiente.DropDownWidthAuto = False
            Me.cbbTipoDiente.Location = New System.Drawing.Point(119, 43)
            Me.cbbTipoDiente.Name = "cbbTipoDiente"
            Me.cbbTipoDiente.Parametro1 = -1
            Me.cbbTipoDiente.Parametro2 = -1
            Me.cbbTipoDiente.SelectedIndex = -1
            Me.cbbTipoDiente.SelectedValue = 0
            Me.cbbTipoDiente.Size = New System.Drawing.Size(224, 22)
            Me.cbbTipoDiente.TabIndex = 6
            '
            'cbbTipoOclus
            '
            Me.cbbTipoOclus._NoIndica = False
            Me.cbbTipoOclus._Todos = False
            Me.cbbTipoOclus._TodosMensaje = ""
            Me.cbbTipoOclus._Visible_Add = False
            Me.cbbTipoOclus._Visible_Buscar = False
            Me.cbbTipoOclus._Visible_Eliminar = False
            Me.cbbTipoOclus.CodigoPadre = -1
            Me.cbbTipoOclus.ComboTipo = Type.Combo.ComboTipo.OdontogramaOclusionTipo
            Me.cbbTipoOclus.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoOclus.DropDownWidth = 224
            Me.cbbTipoOclus.DropDownWidthAuto = False
            Me.cbbTipoOclus.Location = New System.Drawing.Point(119, 18)
            Me.cbbTipoOclus.Name = "cbbTipoOclus"
            Me.cbbTipoOclus.Parametro1 = -1
            Me.cbbTipoOclus.Parametro2 = -1
            Me.cbbTipoOclus.SelectedIndex = -1
            Me.cbbTipoOclus.SelectedValue = 0
            Me.cbbTipoOclus.Size = New System.Drawing.Size(224, 22)
            Me.cbbTipoOclus.TabIndex = 2
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(4, 99)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Tamaño Dentomaxilar"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(19, 73)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(95, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Tamaño de Diente"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(37, 49)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(77, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Tipo de Diente"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(27, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(87, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Tipo de Oclusión"
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rbdNoRegistra)
            Me.GroupBox2.Controls.Add(Me.rdbIV)
            Me.GroupBox2.Controls.Add(Me.rdbIII)
            Me.GroupBox2.Controls.Add(Me.rdbII)
            Me.GroupBox2.Controls.Add(Me.rdbI)
            Me.GroupBox2.Controls.Add(Me.Panel3)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(5, 145)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(349, 144)
            Me.GroupBox2.TabIndex = 6
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Ruga palatina"
            '
            'rbdNoRegistra
            '
            Me.rbdNoRegistra.AutoSize = True
            Me.rbdNoRegistra.Checked = True
            Me.rbdNoRegistra.Location = New System.Drawing.Point(63, 122)
            Me.rbdNoRegistra.Name = "rbdNoRegistra"
            Me.rbdNoRegistra.Size = New System.Drawing.Size(76, 17)
            Me.rbdNoRegistra.TabIndex = 5
            Me.rbdNoRegistra.TabStop = True
            Me.rbdNoRegistra.Text = "No registra"
            Me.rbdNoRegistra.UseVisualStyleBackColor = True
            '
            'rdbIV
            '
            Me.rdbIV.AutoSize = True
            Me.rdbIV.Location = New System.Drawing.Point(268, 100)
            Me.rdbIV.Name = "rdbIV"
            Me.rdbIV.Size = New System.Drawing.Size(35, 17)
            Me.rdbIV.TabIndex = 4
            Me.rdbIV.Text = "IV"
            Me.rdbIV.UseVisualStyleBackColor = True
            '
            'rdbIII
            '
            Me.rdbIII.AutoSize = True
            Me.rdbIII.Location = New System.Drawing.Point(205, 100)
            Me.rdbIII.Name = "rdbIII"
            Me.rdbIII.Size = New System.Drawing.Size(34, 17)
            Me.rdbIII.TabIndex = 3
            Me.rdbIII.Text = "III"
            Me.rdbIII.UseVisualStyleBackColor = True
            '
            'rdbII
            '
            Me.rdbII.AutoSize = True
            Me.rdbII.Location = New System.Drawing.Point(128, 100)
            Me.rdbII.Name = "rdbII"
            Me.rdbII.Size = New System.Drawing.Size(31, 17)
            Me.rdbII.TabIndex = 2
            Me.rdbII.Text = "II"
            Me.rdbII.UseVisualStyleBackColor = True
            '
            'rdbI
            '
            Me.rdbI.AutoSize = True
            Me.rdbI.Location = New System.Drawing.Point(63, 100)
            Me.rdbI.Name = "rdbI"
            Me.rdbI.Size = New System.Drawing.Size(28, 17)
            Me.rdbI.TabIndex = 1
            Me.rdbI.Text = "I"
            Me.rdbI.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.ruga_palatina
            Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel3.Location = New System.Drawing.Point(7, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(336, 79)
            Me.Panel3.TabIndex = 0
            '
            'TabPage2
            '
            Me.TabPage2.Controls.Add(Me.Panel11)
            Me.TabPage2.Controls.Add(Me.Panel10)
            Me.TabPage2.Controls.Add(Me.Label6)
            Me.TabPage2.Controls.Add(Me.Label5)
            Me.TabPage2.Controls.Add(Me.Panel9)
            Me.TabPage2.Controls.Add(Me.Panel6)
            Me.TabPage2.Controls.Add(Me.Panel8)
            Me.TabPage2.Controls.Add(Me.Panel5)
            Me.TabPage2.Controls.Add(Me.Panel7)
            Me.TabPage2.Controls.Add(Me.Panel4)
            Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(359, 301)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "ARCO DENTARIO"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'Panel11
            '
            Me.Panel11.Controls.Add(Me.rdbInfNoRegistra)
            Me.Panel11.Controls.Add(Me.rdbInfOvoide)
            Me.Panel11.Controls.Add(Me.rdbInfTriang)
            Me.Panel11.Controls.Add(Me.rdbInfCuadrado)
            Me.Panel11.Location = New System.Drawing.Point(17, 260)
            Me.Panel11.Name = "Panel11"
            Me.Panel11.Size = New System.Drawing.Size(328, 38)
            Me.Panel11.TabIndex = 25
            '
            'rdbInfNoRegistra
            '
            Me.rdbInfNoRegistra.AutoSize = True
            Me.rdbInfNoRegistra.Checked = True
            Me.rdbInfNoRegistra.Location = New System.Drawing.Point(13, 19)
            Me.rdbInfNoRegistra.Name = "rdbInfNoRegistra"
            Me.rdbInfNoRegistra.Size = New System.Drawing.Size(76, 17)
            Me.rdbInfNoRegistra.TabIndex = 22
            Me.rdbInfNoRegistra.TabStop = True
            Me.rdbInfNoRegistra.Text = "No registra"
            Me.rdbInfNoRegistra.UseVisualStyleBackColor = True
            '
            'rdbInfOvoide
            '
            Me.rdbInfOvoide.AutoSize = True
            Me.rdbInfOvoide.Location = New System.Drawing.Point(13, 1)
            Me.rdbInfOvoide.Name = "rdbInfOvoide"
            Me.rdbInfOvoide.Size = New System.Drawing.Size(59, 17)
            Me.rdbInfOvoide.TabIndex = 19
            Me.rdbInfOvoide.TabStop = True
            Me.rdbInfOvoide.Text = "Ovoide"
            Me.rdbInfOvoide.UseVisualStyleBackColor = True
            '
            'rdbInfTriang
            '
            Me.rdbInfTriang.AutoSize = True
            Me.rdbInfTriang.Location = New System.Drawing.Point(125, 1)
            Me.rdbInfTriang.Name = "rdbInfTriang"
            Me.rdbInfTriang.Size = New System.Drawing.Size(72, 17)
            Me.rdbInfTriang.TabIndex = 20
            Me.rdbInfTriang.TabStop = True
            Me.rdbInfTriang.Text = "Triangular"
            Me.rdbInfTriang.UseVisualStyleBackColor = True
            '
            'rdbInfCuadrado
            '
            Me.rdbInfCuadrado.AutoSize = True
            Me.rdbInfCuadrado.Location = New System.Drawing.Point(239, 1)
            Me.rdbInfCuadrado.Name = "rdbInfCuadrado"
            Me.rdbInfCuadrado.Size = New System.Drawing.Size(71, 17)
            Me.rdbInfCuadrado.TabIndex = 21
            Me.rdbInfCuadrado.TabStop = True
            Me.rdbInfCuadrado.Text = "Cuadrado"
            Me.rdbInfCuadrado.UseVisualStyleBackColor = True
            '
            'Panel10
            '
            Me.Panel10.Controls.Add(Me.rdbSupNoRegistra)
            Me.Panel10.Controls.Add(Me.rdbSupOvoide)
            Me.Panel10.Controls.Add(Me.rdbSupTriang)
            Me.Panel10.Controls.Add(Me.rdbSupCuadrado)
            Me.Panel10.Location = New System.Drawing.Point(17, 107)
            Me.Panel10.Name = "Panel10"
            Me.Panel10.Size = New System.Drawing.Size(328, 38)
            Me.Panel10.TabIndex = 24
            '
            'rdbSupNoRegistra
            '
            Me.rdbSupNoRegistra.AutoSize = True
            Me.rdbSupNoRegistra.Checked = True
            Me.rdbSupNoRegistra.Location = New System.Drawing.Point(13, 20)
            Me.rdbSupNoRegistra.Name = "rdbSupNoRegistra"
            Me.rdbSupNoRegistra.Size = New System.Drawing.Size(76, 17)
            Me.rdbSupNoRegistra.TabIndex = 19
            Me.rdbSupNoRegistra.TabStop = True
            Me.rdbSupNoRegistra.Text = "No registra"
            Me.rdbSupNoRegistra.UseVisualStyleBackColor = True
            '
            'rdbSupOvoide
            '
            Me.rdbSupOvoide.AutoSize = True
            Me.rdbSupOvoide.Location = New System.Drawing.Point(13, 3)
            Me.rdbSupOvoide.Name = "rdbSupOvoide"
            Me.rdbSupOvoide.Size = New System.Drawing.Size(59, 17)
            Me.rdbSupOvoide.TabIndex = 16
            Me.rdbSupOvoide.TabStop = True
            Me.rdbSupOvoide.Text = "Ovoide"
            Me.rdbSupOvoide.UseVisualStyleBackColor = True
            '
            'rdbSupTriang
            '
            Me.rdbSupTriang.AutoSize = True
            Me.rdbSupTriang.Location = New System.Drawing.Point(125, 3)
            Me.rdbSupTriang.Name = "rdbSupTriang"
            Me.rdbSupTriang.Size = New System.Drawing.Size(72, 17)
            Me.rdbSupTriang.TabIndex = 17
            Me.rdbSupTriang.TabStop = True
            Me.rdbSupTriang.Text = "Triangular"
            Me.rdbSupTriang.UseVisualStyleBackColor = True
            '
            'rdbSupCuadrado
            '
            Me.rdbSupCuadrado.AutoSize = True
            Me.rdbSupCuadrado.Location = New System.Drawing.Point(239, 3)
            Me.rdbSupCuadrado.Name = "rdbSupCuadrado"
            Me.rdbSupCuadrado.Size = New System.Drawing.Size(71, 17)
            Me.rdbSupCuadrado.TabIndex = 18
            Me.rdbSupCuadrado.TabStop = True
            Me.rdbSupCuadrado.Text = "Cuadrado"
            Me.rdbSupCuadrado.UseVisualStyleBackColor = True
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.White
            Me.Label6.Location = New System.Drawing.Point(14, 161)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(329, 14)
            Me.Label6.TabIndex = 22
            Me.Label6.Text = "INFERIOR"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.Location = New System.Drawing.Point(14, 12)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(329, 14)
            Me.Label5.TabIndex = 23
            Me.Label5.Text = "SUPERIOR"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel9
            '
            Me.Panel9.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.cuad_inf
            Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel9.Location = New System.Drawing.Point(236, 177)
            Me.Panel9.Name = "Panel9"
            Me.Panel9.Size = New System.Drawing.Size(108, 80)
            Me.Panel9.TabIndex = 14
            '
            'Panel6
            '
            Me.Panel6.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.cuadr_sup
            Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel6.Location = New System.Drawing.Point(236, 26)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(108, 80)
            Me.Panel6.TabIndex = 15
            '
            'Panel8
            '
            Me.Panel8.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.tri_inf
            Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel8.Location = New System.Drawing.Point(125, 177)
            Me.Panel8.Name = "Panel8"
            Me.Panel8.Size = New System.Drawing.Size(108, 80)
            Me.Panel8.TabIndex = 12
            '
            'Panel5
            '
            Me.Panel5.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.trian_sup
            Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel5.Location = New System.Drawing.Point(125, 26)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(108, 80)
            Me.Panel5.TabIndex = 13
            '
            'Panel7
            '
            Me.Panel7.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.ovoid_inf
            Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel7.Location = New System.Drawing.Point(13, 177)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(108, 80)
            Me.Panel7.TabIndex = 10
            '
            'Panel4
            '
            Me.Panel4.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.ovoide_sup
            Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.Panel4.Location = New System.Drawing.Point(13, 26)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(108, 80)
            Me.Panel4.TabIndex = 11
            '
            'uscOdontograma
            '
            Me.uscOdontograma.Enabled = True
            Me.uscOdontograma.Location = New System.Drawing.Point(0, 3)
            Me.uscOdontograma.Name = "uscOdontograma"
            Me.uscOdontograma.OcxState = CType(resources.GetObject("uscOdontograma.OcxState"), System.Windows.Forms.AxHost.State)
            Me.uscOdontograma.Size = New System.Drawing.Size(583, 499)
            Me.uscOdontograma.TabIndex = 6
            '
            'frmOdontogramaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(949, 549)
            Me.Name = "frmOdontogramaPopup"
            Me.Text = "Odontograma del Interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.TabControl1.ResumeLayout(False)
            Me.TabPage1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.TabPage2.ResumeLayout(False)
            Me.Panel11.ResumeLayout(False)
            Me.Panel11.PerformLayout()
            Me.Panel10.ResumeLayout(False)
            Me.Panel10.PerformLayout()
            CType(Me.uscOdontograma, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents rdbIV As System.Windows.Forms.RadioButton
        Friend WithEvents rdbIII As System.Windows.Forms.RadioButton
        Friend WithEvents rdbII As System.Windows.Forms.RadioButton
        Friend WithEvents rdbI As System.Windows.Forms.RadioButton
        Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents rdbInfCuadrado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInfTriang As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInfOvoide As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSupCuadrado As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSupTriang As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSupOvoide As System.Windows.Forms.RadioButton
        Friend WithEvents Panel9 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents Panel8 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Panel11 As System.Windows.Forms.Panel
        Friend WithEvents Panel10 As System.Windows.Forms.Panel
        Friend WithEvents rbdNoRegistra As System.Windows.Forms.RadioButton
        Friend WithEvents rdbInfNoRegistra As System.Windows.Forms.RadioButton
        Friend WithEvents rdbSupNoRegistra As System.Windows.Forms.RadioButton
        Friend WithEvents cbbTipoOclus As APPControls.uscComboParametrica
        Friend WithEvents cbbTamDentomax As APPControls.uscComboParametrica
        Friend WithEvents cbbTamanioDiente As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDiente As APPControls.uscComboParametrica
        Friend WithEvents uscOdontograma As AxCTLODONLib.AxCtlOdon
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtEspecific As System.Windows.Forms.TextBox
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
    End Class
End Namespace