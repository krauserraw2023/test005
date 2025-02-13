Namespace Sistema
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMant
        Inherits System.Windows.Forms.Form

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
            Me.txtNombre = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDes = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombreCor = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.chkLogMein = New System.Windows.Forms.CheckBox()
            Me.chkInternet = New System.Windows.Forms.CheckBox()
            Me.txtVerApp = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtVerBD = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtObs = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.dtpFecha = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ins_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_pen_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAddPenal = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.pnlPenal = New System.Windows.Forms.Panel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.cbbTipoLicencia = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.pnlPenal.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'txtNombre
            '
            Me.txtNombre.Location = New System.Drawing.Point(103, 14)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(199, 20)
            Me.txtNombre.TabIndex = 44
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(10, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 13)
            Me.Label1.TabIndex = 43
            Me.Label1.Text = "Nombre :"
            '
            'txtDes
            '
            Me.txtDes.Location = New System.Drawing.Point(103, 180)
            Me.txtDes.Multiline = True
            Me.txtDes.Name = "txtDes"
            Me.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDes.Size = New System.Drawing.Size(199, 56)
            Me.txtDes.TabIndex = 46
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 183)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(69, 13)
            Me.Label2.TabIndex = 45
            Me.Label2.Text = "Descripcion :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 245)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(43, 13)
            Me.Label3.TabIndex = 48
            Me.Label3.Text = "Fecha :"
            '
            'txtNombreCor
            '
            Me.txtNombreCor.Location = New System.Drawing.Point(103, 154)
            Me.txtNombreCor.Name = "txtNombreCor"
            Me.txtNombreCor.Size = New System.Drawing.Size(199, 20)
            Me.txtNombreCor.TabIndex = 50
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(10, 157)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(78, 13)
            Me.Label4.TabIndex = 49
            Me.Label4.Text = "Nombre Corto :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(7, 48)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(47, 13)
            Me.Label5.TabIndex = 54
            Me.Label5.Text = "Region :"
            '
            'chkLogMein
            '
            Me.chkLogMein.AutoSize = True
            Me.chkLogMein.Location = New System.Drawing.Point(207, 273)
            Me.chkLogMein.Name = "chkLogMein"
            Me.chkLogMein.Size = New System.Drawing.Size(67, 17)
            Me.chkLogMein.TabIndex = 55
            Me.chkLogMein.Text = "LogMein"
            Me.chkLogMein.UseVisualStyleBackColor = True
            '
            'chkInternet
            '
            Me.chkInternet.AutoSize = True
            Me.chkInternet.Location = New System.Drawing.Point(207, 300)
            Me.chkInternet.Name = "chkInternet"
            Me.chkInternet.Size = New System.Drawing.Size(62, 17)
            Me.chkInternet.TabIndex = 56
            Me.chkInternet.Text = "Internet"
            Me.chkInternet.UseVisualStyleBackColor = True
            '
            'txtVerApp
            '
            Me.txtVerApp.Location = New System.Drawing.Point(103, 271)
            Me.txtVerApp.Name = "txtVerApp"
            Me.txtVerApp.Size = New System.Drawing.Size(84, 20)
            Me.txtVerApp.TabIndex = 60
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(10, 274)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(70, 13)
            Me.Label7.TabIndex = 59
            Me.Label7.Text = "Version App :"
            '
            'txtVerBD
            '
            Me.txtVerBD.Location = New System.Drawing.Point(103, 297)
            Me.txtVerBD.Name = "txtVerBD"
            Me.txtVerBD.Size = New System.Drawing.Size(84, 20)
            Me.txtVerBD.TabIndex = 62
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(10, 300)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(75, 13)
            Me.Label8.TabIndex = 61
            Me.Label8.Text = "Version B.D.  :"
            '
            'txtObs
            '
            Me.txtObs.Location = New System.Drawing.Point(13, 342)
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(289, 72)
            Me.txtObs.TabIndex = 64
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(10, 326)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(73, 13)
            Me.Label9.TabIndex = 63
            Me.Label9.Text = "Observacion :"
            '
            'dtpFecha
            '
            Me.dtpFecha.Location = New System.Drawing.Point(103, 242)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(84, 21)
            Me.dtpFecha.TabIndex = 47
            Me.dtpFecha.Value = "/  /"
            Me.dtpFecha.ValueLong = CType(0, Long)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.dgwGrilla)
            Me.GroupBox1.Controls.Add(Me.Panel1)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(316, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(300, 469)
            Me.GroupBox1.TabIndex = 67
            Me.GroupBox1.TabStop = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToOrderColumns = True
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_ins_id, Me.col_reg_id, Me.col_pen_nom, Me.Column4, Me.Column5})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 61)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(294, 405)
            Me.dgwGrilla.TabIndex = 46
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_ins_id
            '
            Me.col_ins_id.DataPropertyName = "InstalacionID"
            Me.col_ins_id.HeaderText = "InstalacionID"
            Me.col_ins_id.Name = "col_ins_id"
            Me.col_ins_id.ReadOnly = True
            Me.col_ins_id.Visible = False
            '
            'col_reg_id
            '
            Me.col_reg_id.DataPropertyName = "RegionID"
            Me.col_reg_id.HeaderText = "RegionID"
            Me.col_reg_id.Name = "col_reg_id"
            Me.col_reg_id.ReadOnly = True
            Me.col_reg_id.Visible = False
            '
            'col_pen_nom
            '
            Me.col_pen_nom.DataPropertyName = "PenalNombre"
            Me.col_pen_nom.HeaderText = "Penal"
            Me.col_pen_nom.Name = "col_pen_nom"
            Me.col_pen_nom.ReadOnly = True
            Me.col_pen_nom.Width = 170
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "Lectura"
            Me.Column4.HeaderText = "Lectura"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 55
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "Escritura"
            Me.Column5.HeaderText = "Escritura"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 55
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnAddPenal)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(3, 16)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(294, 45)
            Me.Panel1.TabIndex = 47
            '
            'btnAddPenal
            '
            Me.btnAddPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddPenal.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddPenal.Location = New System.Drawing.Point(196, 3)
            Me.btnAddPenal.Name = "btnAddPenal"
            Me.btnAddPenal.Size = New System.Drawing.Size(99, 40)
            Me.btnAddPenal.TabIndex = 89
            Me.btnAddPenal.Text = "&Penal"
            Me.btnAddPenal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.GroupBox3)
            Me.GroupBox2.Controls.Add(Me.Panel2)
            Me.GroupBox2.Controls.Add(Me.txtDes)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.txtNombre)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.txtObs)
            Me.GroupBox2.Controls.Add(Me.dtpFecha)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.txtVerBD)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.txtNombreCor)
            Me.GroupBox2.Controls.Add(Me.txtVerApp)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.chkInternet)
            Me.GroupBox2.Controls.Add(Me.chkLogMein)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(316, 469)
            Me.GroupBox2.TabIndex = 68
            Me.GroupBox2.TabStop = False
            '
            'pnlPenal
            '
            Me.pnlPenal.Controls.Add(Me.cbbPenal)
            Me.pnlPenal.Controls.Add(Me.Label6)
            Me.pnlPenal.Location = New System.Drawing.Point(3, 67)
            Me.pnlPenal.Name = "pnlPenal"
            Me.pnlPenal.Size = New System.Drawing.Size(288, 30)
            Me.pnlPenal.TabIndex = 77
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(4, 9)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(40, 13)
            Me.Label6.TabIndex = 76
            Me.Label6.Text = "Penal :"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label10)
            Me.GroupBox3.Controls.Add(Me.pnlPenal)
            Me.GroupBox3.Controls.Add(Me.cbbTipoLicencia)
            Me.GroupBox3.Controls.Add(Me.Label5)
            Me.GroupBox3.Controls.Add(Me.cbbRegion)
            Me.GroupBox3.Location = New System.Drawing.Point(13, 36)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(297, 108)
            Me.GroupBox3.TabIndex = 74
            Me.GroupBox3.TabStop = False
            '
            'cbbTipoLicencia
            '
            Me.cbbTipoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTipoLicencia.FormattingEnabled = True
            Me.cbbTipoLicencia.Location = New System.Drawing.Point(90, 15)
            Me.cbbTipoLicencia.Name = "cbbTipoLicencia"
            Me.cbbTipoLicencia.Size = New System.Drawing.Size(199, 21)
            Me.cbbTipoLicencia.TabIndex = 3
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(3, 421)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(310, 45)
            Me.Panel2.TabIndex = 73
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(209, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 72
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(111, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 71
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.Penal
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 178
            Me.cbbPenal.DropDownWidthAuto = True
            Me.cbbPenal.Location = New System.Drawing.Point(87, 5)
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(199, 22)
            Me.cbbPenal.TabIndex = 75
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.Region
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 178
            Me.cbbRegion.DropDownWidthAuto = True
            Me.cbbRegion.Location = New System.Drawing.Point(90, 43)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(199, 22)
            Me.cbbRegion.TabIndex = 53
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(7, 19)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(77, 13)
            Me.Label10.TabIndex = 78
            Me.Label10.Text = "Tipo Licencia :"
            '
            'frmMant
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(616, 469)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.GroupBox2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMant"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Detalle de Instalacion"
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.pnlPenal.ResumeLayout(False)
            Me.pnlPenal.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtNombre As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtDes As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFecha As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNombreCor As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents chkLogMein As System.Windows.Forms.CheckBox
        Friend WithEvents chkInternet As System.Windows.Forms.CheckBox
        Friend WithEvents txtVerApp As System.Windows.Forms.TextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtVerBD As System.Windows.Forms.TextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnAddPenal As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Protected WithEvents cbbTipoLicencia As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ins_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_pen_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents pnlPenal As System.Windows.Forms.Panel
        Friend WithEvents Label10 As System.Windows.Forms.Label

    End Class
End Namespace

