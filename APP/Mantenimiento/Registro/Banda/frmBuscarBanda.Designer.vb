Namespace Mantenimiento.Registro.Banda
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBuscarBanda
        Inherits Legolas.APPUIComponents.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarBanda))
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.pnlEliminar = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.pnlEditar = New System.Windows.Forms.Panel()
            Me.btnNuevo = New System.Windows.Forms.Button()
            Me.btnModificar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.grbBuscar = New System.Windows.Forms.GroupBox()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
            Me.grbBusqueda = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cbbBandaTipo = New APPControls.uscComboParametrica()
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2.SuspendLayout()
            Me.Panel7.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.pnlEliminar.SuspendLayout()
            Me.pnlEditar.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.grbBuscar.SuspendLayout()
            Me.ToolStrip1.SuspendLayout()
            Me.grbBusqueda.SuspendLayout()
            Me.cbbBandaTipo.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'Panel2
            '
            Me.Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Panel2.Controls.Add(Me.Panel7)
            Me.Panel2.Controls.Add(Me.pnlReporte)
            Me.Panel2.Controls.Add(Me.pnlEliminar)
            Me.Panel2.Controls.Add(Me.pnlEditar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 509)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(911, 51)
            Me.Panel2.TabIndex = 81
            '
            'Panel7
            '
            Me.Panel7.Controls.Add(Me.btnSalir)
            Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
            Me.Panel7.Location = New System.Drawing.Point(367, 0)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(88, 51)
            Me.Panel7.TabIndex = 72
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
            Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.Location = New System.Drawing.Point(2, 5)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(81, 41)
            Me.btnSalir.TabIndex = 66
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.btnExportar)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlReporte.Location = New System.Drawing.Point(276, 0)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(91, 51)
            Me.pnlReporte.TabIndex = 71
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.Location = New System.Drawing.Point(1, 5)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(88, 41)
            Me.btnExportar.TabIndex = 65
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'pnlEliminar
            '
            Me.pnlEliminar.Controls.Add(Me.btnEliminar)
            Me.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEliminar.Location = New System.Drawing.Point(187, 0)
            Me.pnlEliminar.Name = "pnlEliminar"
            Me.pnlEliminar.Size = New System.Drawing.Size(89, 51)
            Me.pnlEliminar.TabIndex = 70
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminar.Location = New System.Drawing.Point(2, 5)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(84, 41)
            Me.btnEliminar.TabIndex = 68
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'pnlEditar
            '
            Me.pnlEditar.Controls.Add(Me.btnNuevo)
            Me.pnlEditar.Controls.Add(Me.btnModificar)
            Me.pnlEditar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlEditar.Location = New System.Drawing.Point(0, 0)
            Me.pnlEditar.Name = "pnlEditar"
            Me.pnlEditar.Size = New System.Drawing.Size(187, 51)
            Me.pnlEditar.TabIndex = 69
            '
            'btnNuevo
            '
            Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
            Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.Location = New System.Drawing.Point(3, 5)
            Me.btnNuevo.Name = "btnNuevo"
            Me.btnNuevo.Size = New System.Drawing.Size(88, 41)
            Me.btnNuevo.TabIndex = 63
            Me.btnNuevo.Text = "&Nuevo"
            Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnNuevo.UseVisualStyleBackColor = True
            '
            'btnModificar
            '
            Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
            Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.Location = New System.Drawing.Point(94, 5)
            Me.btnModificar.Name = "btnModificar"
            Me.btnModificar.Size = New System.Drawing.Size(90, 41)
            Me.btnModificar.TabIndex = 64
            Me.btnModificar.Text = "&Modificar"
            Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnModificar.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.grbBuscar)
            Me.Panel1.Controls.Add(Me.grbBusqueda)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(911, 103)
            Me.Panel1.TabIndex = 84
            '
            'grbBuscar
            '
            Me.grbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.grbBuscar.Controls.Add(Me.lblReg)
            Me.grbBuscar.Controls.Add(Me.ToolStrip1)
            Me.grbBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbBuscar.Location = New System.Drawing.Point(821, 0)
            Me.grbBuscar.Name = "grbBuscar"
            Me.grbBuscar.Size = New System.Drawing.Size(90, 103)
            Me.grbBuscar.TabIndex = 80
            Me.grbBuscar.TabStop = False
            '
            'lblReg
            '
            Me.lblReg.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lblReg.Location = New System.Drawing.Point(3, 81)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(84, 19)
            Me.lblReg.TabIndex = 34
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ToolStrip1
            '
            Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
            Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbBuscar})
            Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(84, 84)
            Me.ToolStrip1.TabIndex = 90
            Me.ToolStrip1.Text = "ToolStrip2"
            '
            'tsbBuscar
            '
            Me.tsbBuscar.BackColor = System.Drawing.Color.Transparent
            Me.tsbBuscar.Image = CType(resources.GetObject("tsbBuscar.Image"), System.Drawing.Image)
            Me.tsbBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.tsbBuscar.Name = "tsbBuscar"
            Me.tsbBuscar.Size = New System.Drawing.Size(82, 43)
            Me.tsbBuscar.Text = "&Buscar"
            Me.tsbBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.tsbBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'grbBusqueda
            '
            Me.grbBusqueda.BackColor = System.Drawing.Color.Transparent
            Me.grbBusqueda.Controls.Add(Me.Label3)
            Me.grbBusqueda.Controls.Add(Me.cbbBandaTipo)
            Me.grbBusqueda.Controls.Add(Me.Label11)
            Me.grbBusqueda.Controls.Add(Me.txtNom)
            Me.grbBusqueda.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbBusqueda.Location = New System.Drawing.Point(0, 0)
            Me.grbBusqueda.Name = "grbBusqueda"
            Me.grbBusqueda.Size = New System.Drawing.Size(570, 103)
            Me.grbBusqueda.TabIndex = 38
            Me.grbBusqueda.TabStop = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 58)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Nombre :"
            '
            'cbbBandaTipo
            '
            Me.cbbBandaTipo._NoIndica = False
            Me.cbbBandaTipo._Todos = False
            Me.cbbBandaTipo._TodosMensaje = ""
            Me.cbbBandaTipo._Visible_Add = False
            Me.cbbBandaTipo._Visible_Buscar = False
            Me.cbbBandaTipo._Visible_Eliminar = False
            Me.cbbBandaTipo.CodigoPadre = -1
            Me.cbbBandaTipo.ComboTipo = Type.Combo.ComboTipo.BandaTipo
            Me.cbbBandaTipo.Controls.Add(Me.object_ec9230cf_3586_407a_93d2_6d65901e7650)
            Me.cbbBandaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaTipo.DropDownWidth = 222
            Me.cbbBandaTipo.DropDownWidthAuto = False
            Me.cbbBandaTipo.Location = New System.Drawing.Point(69, 27)
            Me.cbbBandaTipo.Name = "cbbBandaTipo"
            Me.cbbBandaTipo.Parametro1 = -1
            Me.cbbBandaTipo.Parametro2 = -1
            Me.cbbBandaTipo.SelectedIndex = -1
            Me.cbbBandaTipo.SelectedValue = 0
            Me.cbbBandaTipo.Size = New System.Drawing.Size(481, 22)
            Me.cbbBandaTipo.TabIndex = 77
            '
            'object_ec9230cf_3586_407a_93d2_6d65901e7650
            '
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Dock = System.Windows.Forms.DockStyle.Fill
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.DropDownWidth = 222
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.FormattingEnabled = True
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Location = New System.Drawing.Point(0, 0)
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Name = "object_ec9230cf_3586_407a_93d2_6d65901e7650"
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.Size = New System.Drawing.Size(481, 21)
            Me.object_ec9230cf_3586_407a_93d2_6d65901e7650.TabIndex = 2
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(10, 30)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(28, 13)
            Me.Label11.TabIndex = 76
            Me.Label11.Text = "Tipo"
            '
            'txtNom
            '
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(70, 55)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(480, 20)
            Me.txtNom.TabIndex = 80
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.colTipo, Me.colNombre})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 103)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(911, 406)
            Me.dgwGrilla.TabIndex = 87
            Me.dgwGrilla.VisibleCampos = True
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'colTipo
            '
            Me.colTipo.DataPropertyName = "BandaTipoNombre"
            Me.colTipo.HeaderText = "Tipo Organización"
            Me.colTipo.Name = "colTipo"
            Me.colTipo.ReadOnly = True
            Me.colTipo.Width = 150
            '
            'colNombre
            '
            Me.colNombre.DataPropertyName = "BandaNombre"
            Me.colNombre.HeaderText = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.ReadOnly = True
            Me.colNombre.Width = 400
            '
            'frmBuscarBanda
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(911, 560)
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "frmBuscarBanda"
            Me.Text = "Búsqueda de Organizaciones Criminales"
            Me.Panel2.ResumeLayout(False)
            Me.Panel7.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlEliminar.ResumeLayout(False)
            Me.pnlEditar.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.grbBuscar.ResumeLayout(False)
            Me.grbBuscar.PerformLayout()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.grbBusqueda.ResumeLayout(False)
            Me.grbBusqueda.PerformLayout()
            Me.cbbBandaTipo.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents btnExportar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents pnlEliminar As System.Windows.Forms.Panel
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents pnlEditar As System.Windows.Forms.Panel
        Friend WithEvents btnNuevo As System.Windows.Forms.Button
        Friend WithEvents btnModificar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents grbBusqueda As System.Windows.Forms.GroupBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbBandaTipo As APPControls.uscComboParametrica
        Friend WithEvents object_ec9230cf_3586_407a_93d2_6d65901e7650 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents grbBuscar As System.Windows.Forms.GroupBox
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Public WithEvents tsbBuscar As System.Windows.Forms.ToolStripButton
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace

