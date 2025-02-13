Namespace Registro.Reporte

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportePopup_LM
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.grbFiltro = New System.Windows.Forms.GroupBox()
            Me.grbIncluirDocAnulados = New System.Windows.Forms.GroupBox()
            Me.chkMostrarDocAnulados = New System.Windows.Forms.CheckBox()
            Me.grbFechas = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.grbInterno = New System.Windows.Forms.GroupBox()
            Me.rdbInternoTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.pnlSeleccionarInterno = New System.Windows.Forms.Panel()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.rdbSeleccionarInterno = New Legolas.APPUIComponents.myRadioButton()
            Me.grbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.grbFiltro.SuspendLayout()
            Me.grbIncluirDocAnulados.SuspendLayout()
            Me.grbFechas.SuspendLayout()
            Me.grbInterno.SuspendLayout()
            Me.pnlSeleccionarInterno.SuspendLayout()
            Me.grbRegionPenal.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbFiltro)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(592, 396)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 351)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(592, 45)
            Me.Panel1.TabIndex = 102
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(390, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(202, 45)
            Me.Panel2.TabIndex = 103
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(103, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 97
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbFiltro
            '
            Me.grbFiltro.Controls.Add(Me.grbIncluirDocAnulados)
            Me.grbFiltro.Controls.Add(Me.grbFechas)
            Me.grbFiltro.Controls.Add(Me.grbInterno)
            Me.grbFiltro.Controls.Add(Me.grbRegionPenal)
            Me.grbFiltro.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFiltro.Location = New System.Drawing.Point(253, 0)
            Me.grbFiltro.Name = "grbFiltro"
            Me.grbFiltro.Size = New System.Drawing.Size(339, 351)
            Me.grbFiltro.TabIndex = 103
            Me.grbFiltro.TabStop = False
            '
            'grbIncluirDocAnulados
            '
            Me.grbIncluirDocAnulados.Controls.Add(Me.chkMostrarDocAnulados)
            Me.grbIncluirDocAnulados.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbIncluirDocAnulados.Location = New System.Drawing.Point(3, 264)
            Me.grbIncluirDocAnulados.Name = "grbIncluirDocAnulados"
            Me.grbIncluirDocAnulados.Size = New System.Drawing.Size(333, 46)
            Me.grbIncluirDocAnulados.TabIndex = 49
            Me.grbIncluirDocAnulados.TabStop = False
            '
            'chkMostrarDocAnulados
            '
            Me.chkMostrarDocAnulados.AutoSize = True
            Me.chkMostrarDocAnulados.Location = New System.Drawing.Point(10, 19)
            Me.chkMostrarDocAnulados.Name = "chkMostrarDocAnulados"
            Me.chkMostrarDocAnulados.Size = New System.Drawing.Size(164, 17)
            Me.chkMostrarDocAnulados.TabIndex = 0
            Me.chkMostrarDocAnulados.Text = "Incluir documentos anulados."
            Me.chkMostrarDocAnulados.UseVisualStyleBackColor = True
            '
            'grbFechas
            '
            Me.grbFechas.Controls.Add(Me.dtpFechaFin)
            Me.grbFechas.Controls.Add(Me.Label6)
            Me.grbFechas.Controls.Add(Me.dtpFechaIni)
            Me.grbFechas.Controls.Add(Me.Label5)
            Me.grbFechas.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbFechas.Location = New System.Drawing.Point(3, 202)
            Me.grbFechas.Name = "grbFechas"
            Me.grbFechas.Size = New System.Drawing.Size(333, 62)
            Me.grbFechas.TabIndex = 48
            Me.grbFechas.TabStop = False
            Me.grbFechas.Text = "Fecha de Ingreso"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(202, 24)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 24
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(157, 28)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(65, 24)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 23
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(16, 28)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Desde :"
            '
            'grbInterno
            '
            Me.grbInterno.Controls.Add(Me.rdbInternoTodos)
            Me.grbInterno.Controls.Add(Me.pnlSeleccionarInterno)
            Me.grbInterno.Controls.Add(Me.rdbSeleccionarInterno)
            Me.grbInterno.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbInterno.Location = New System.Drawing.Point(3, 93)
            Me.grbInterno.Name = "grbInterno"
            Me.grbInterno.Size = New System.Drawing.Size(333, 109)
            Me.grbInterno.TabIndex = 9
            Me.grbInterno.TabStop = False
            '
            'rdbInternoTodos
            '
            Me.rdbInternoTodos.AutoSize = True
            Me.rdbInternoTodos.Location = New System.Drawing.Point(188, 19)
            Me.rdbInternoTodos.Name = "rdbInternoTodos"
            Me.rdbInternoTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbInternoTodos.TabIndex = 7
            Me.rdbInternoTodos.Text = "Todos"
            Me.rdbInternoTodos.UseVisualStyleBackColor = True
            '
            'pnlSeleccionarInterno
            '
            Me.pnlSeleccionarInterno.Controls.Add(Me.lblTitulo)
            Me.pnlSeleccionarInterno.Controls.Add(Me.UscLabelBusqueda1)
            Me.pnlSeleccionarInterno.Location = New System.Drawing.Point(15, 41)
            Me.pnlSeleccionarInterno.Name = "pnlSeleccionarInterno"
            Me.pnlSeleccionarInterno.Size = New System.Drawing.Size(304, 56)
            Me.pnlSeleccionarInterno.TabIndex = 10
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(161, 13)
            Me.lblTitulo.TabIndex = 4
            Me.lblTitulo.Text = "Apellidos y Nombres del Interno :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(8, 26)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(285, 21)
            Me.UscLabelBusqueda1.TabIndex = 5
            '
            'rdbSeleccionarInterno
            '
            Me.rdbSeleccionarInterno.AutoSize = True
            Me.rdbSeleccionarInterno.Checked = True
            Me.rdbSeleccionarInterno.Location = New System.Drawing.Point(19, 19)
            Me.rdbSeleccionarInterno.Name = "rdbSeleccionarInterno"
            Me.rdbSeleccionarInterno.Size = New System.Drawing.Size(114, 17)
            Me.rdbSeleccionarInterno.TabIndex = 8
            Me.rdbSeleccionarInterno.TabStop = True
            Me.rdbSeleccionarInterno.Text = "Seleccione Interno"
            Me.rdbSeleccionarInterno.UseVisualStyleBackColor = True
            '
            'grbRegionPenal
            '
            Me.grbRegionPenal.Controls.Add(Me.cbbPenal)
            Me.grbRegionPenal.Controls.Add(Me.cbbRegion)
            Me.grbRegionPenal.Controls.Add(Me.Label11)
            Me.grbRegionPenal.Controls.Add(Me.Label28)
            Me.grbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbRegionPenal.Location = New System.Drawing.Point(3, 16)
            Me.grbRegionPenal.Name = "grbRegionPenal"
            Me.grbRegionPenal.Size = New System.Drawing.Size(333, 77)
            Me.grbRegionPenal.TabIndex = 47
            Me.grbRegionPenal.TabStop = False
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = CType(36, Short)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 217
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(72, 44)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(247, 22)
            Me.cbbPenal.TabIndex = 55
            Me.cbbPenal.verToolTipItemSeleccionado = False
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 217
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(72, 16)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(247, 22)
            Me.cbbRegion.TabIndex = 54
            Me.cbbRegion.verToolTipItemSeleccionado = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(12, 50)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(40, 13)
            Me.Label11.TabIndex = 12
            Me.Label11.Text = "Penal :"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(12, 20)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(47, 13)
            Me.Label28.TabIndex = 44
            Me.Label28.Text = "Region :"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.dgwGrilla)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(253, 351)
            Me.GroupBox4.TabIndex = 104
            Me.GroupBox4.TabStop = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.ColumnHeadersVisible = False
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_reg_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 39)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(247, 309)
            Me.dgwGrilla.TabIndex = 4
            Me.dgwGrilla.VisibleCampos = False
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'col_reg_nom
            '
            Me.col_reg_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_reg_nom.DataPropertyName = "Nombre"
            Me.col_reg_nom.HeaderText = "Nombre"
            Me.col_reg_nom.Name = "col_reg_nom"
            Me.col_reg_nom.ReadOnly = True
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label1.Location = New System.Drawing.Point(3, 16)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(247, 23)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Seleccione el tipo de Reporte..."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmReportePopup_LM
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(592, 396)
            Me.Name = "frmReportePopup_LM"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.grbFiltro.ResumeLayout(False)
            Me.grbIncluirDocAnulados.ResumeLayout(False)
            Me.grbIncluirDocAnulados.PerformLayout()
            Me.grbFechas.ResumeLayout(False)
            Me.grbFechas.PerformLayout()
            Me.grbInterno.ResumeLayout(False)
            Me.grbInterno.PerformLayout()
            Me.pnlSeleccionarInterno.ResumeLayout(False)
            Me.pnlSeleccionarInterno.PerformLayout()
            Me.grbRegionPenal.ResumeLayout(False)
            Me.grbRegionPenal.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents grbInterno As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSeleccionarInterno As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbInternoTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlSeleccionarInterno As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents grbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents grbFechas As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents grbIncluirDocAnulados As System.Windows.Forms.GroupBox
        Friend WithEvents chkMostrarDocAnulados As System.Windows.Forms.CheckBox

    End Class
End Namespace