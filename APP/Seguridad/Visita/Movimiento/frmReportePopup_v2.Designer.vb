Namespace Visita.Movimiento


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportePopup_v2
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
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.pnlReporte = New System.Windows.Forms.Panel()
            Me.grbFecha = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpFechaInicio = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.grbInternoVisitante = New System.Windows.Forms.GroupBox()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.uscBusquedaVisitante = New APPControls.uscLabelBusqueda()
            Me.uscBusquedaInterno = New APPControls.uscLabelBusqueda()
            Me.grbSicrico = New System.Windows.Forms.GroupBox()
            Me.cbbTipoIntegranteBan = New APPControls.uscComboParametrica()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.cbbBandaTipo = New APPControls.uscComboParametrica()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.grbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_reg_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlReporte.SuspendLayout()
            Me.grbFecha.SuspendLayout()
            Me.grbInternoVisitante.SuspendLayout()
            Me.grbSicrico.SuspendLayout()
            Me.grbRegionPenal.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(596, 391)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 346)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(596, 45)
            Me.Panel1.TabIndex = 102
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(394, 0)
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
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.pnlReporte)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(253, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(343, 346)
            Me.GroupBox1.TabIndex = 103
            Me.GroupBox1.TabStop = False
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.grbFecha)
            Me.pnlReporte.Controls.Add(Me.grbInternoVisitante)
            Me.pnlReporte.Controls.Add(Me.grbSicrico)
            Me.pnlReporte.Controls.Add(Me.grbRegionPenal)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlReporte.Location = New System.Drawing.Point(3, 16)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(337, 327)
            Me.pnlReporte.TabIndex = 11
            '
            'grbFecha
            '
            Me.grbFecha.Controls.Add(Me.dtpFechaFin)
            Me.grbFecha.Controls.Add(Me.Label2)
            Me.grbFecha.Controls.Add(Me.dtpFechaInicio)
            Me.grbFecha.Controls.Add(Me.Label6)
            Me.grbFecha.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbFecha.Location = New System.Drawing.Point(0, 231)
            Me.grbFecha.Name = "grbFecha"
            Me.grbFecha.Size = New System.Drawing.Size(337, 50)
            Me.grbFecha.TabIndex = 71
            Me.grbFecha.TabStop = False
            Me.grbFecha.Text = "Fechas"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(227, 19)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 80
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(174, 25)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(27, 13)
            Me.Label2.TabIndex = 81
            Me.Label2.Text = "Fin :"
            '
            'dtpFechaInicio
            '
            Me.dtpFechaInicio.Location = New System.Drawing.Point(68, 19)
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaInicio.TabIndex = 78
            Me.dtpFechaInicio.Value = "/  /"
            Me.dtpFechaInicio.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(8, 25)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(38, 13)
            Me.Label6.TabIndex = 79
            Me.Label6.Text = "Inicio :"
            '
            'grbInternoVisitante
            '
            Me.grbInternoVisitante.Controls.Add(Me.lblTitulo)
            Me.grbInternoVisitante.Controls.Add(Me.uscBusquedaVisitante)
            Me.grbInternoVisitante.Controls.Add(Me.uscBusquedaInterno)
            Me.grbInternoVisitante.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbInternoVisitante.Location = New System.Drawing.Point(0, 190)
            Me.grbInternoVisitante.Name = "grbInternoVisitante"
            Me.grbInternoVisitante.Size = New System.Drawing.Size(337, 41)
            Me.grbInternoVisitante.TabIndex = 109
            Me.grbInternoVisitante.TabStop = False
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblTitulo.Location = New System.Drawing.Point(3, 16)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(46, 13)
            Me.lblTitulo.TabIndex = 4
            Me.lblTitulo.Text = "Interno :"
            '
            'uscBusquedaVisitante
            '
            Me.uscBusquedaVisitante._Codigo = 0
            Me.uscBusquedaVisitante._Value = "[SELECCIONE]"
            Me.uscBusquedaVisitante._Visible_Add = False
            Me.uscBusquedaVisitante._Visible_Buscar = True
            Me.uscBusquedaVisitante._Visible_Eliminar = False
            Me.uscBusquedaVisitante.Location = New System.Drawing.Point(84, 13)
            Me.uscBusquedaVisitante.Name = "uscBusquedaVisitante"
            Me.uscBusquedaVisitante.Size = New System.Drawing.Size(242, 21)
            Me.uscBusquedaVisitante.TabIndex = 6
            '
            'uscBusquedaInterno
            '
            Me.uscBusquedaInterno._Codigo = 0
            Me.uscBusquedaInterno._Value = "[SELECCIONE]"
            Me.uscBusquedaInterno._Visible_Add = False
            Me.uscBusquedaInterno._Visible_Buscar = True
            Me.uscBusquedaInterno._Visible_Eliminar = False
            Me.uscBusquedaInterno.Location = New System.Drawing.Point(84, 13)
            Me.uscBusquedaInterno.Name = "uscBusquedaInterno"
            Me.uscBusquedaInterno.Size = New System.Drawing.Size(242, 21)
            Me.uscBusquedaInterno.TabIndex = 5
            '
            'grbSicrico
            '
            Me.grbSicrico.Controls.Add(Me.cbbTipoIntegranteBan)
            Me.grbSicrico.Controls.Add(Me.Label3)
            Me.grbSicrico.Controls.Add(Me.Label5)
            Me.grbSicrico.Controls.Add(Me.cbbBandaTipo)
            Me.grbSicrico.Controls.Add(Me.Label7)
            Me.grbSicrico.Controls.Add(Me.UscLabelBusqueda1)
            Me.grbSicrico.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbSicrico.Location = New System.Drawing.Point(0, 84)
            Me.grbSicrico.Name = "grbSicrico"
            Me.grbSicrico.Size = New System.Drawing.Size(337, 106)
            Me.grbSicrico.TabIndex = 108
            Me.grbSicrico.TabStop = False
            '
            'cbbTipoIntegranteBan
            '
            Me.cbbTipoIntegranteBan._NoIndica = True
            Me.cbbTipoIntegranteBan._Todos = True
            Me.cbbTipoIntegranteBan._TodosMensaje = "[Todos]"
            Me.cbbTipoIntegranteBan._Visible_Add = False
            Me.cbbTipoIntegranteBan._Visible_Buscar = False
            Me.cbbTipoIntegranteBan._Visible_Eliminar = False
            Me.cbbTipoIntegranteBan.CodigoPadre = -1
            Me.cbbTipoIntegranteBan.ComboTipo = Type.Combo.ComboTipo.BandaMiembroTipo
            Me.cbbTipoIntegranteBan.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoIntegranteBan.DropDownWidth = 325
            Me.cbbTipoIntegranteBan.DropDownWidthAuto = True
            Me.cbbTipoIntegranteBan.Location = New System.Drawing.Point(84, 76)
            Me.cbbTipoIntegranteBan.Name = "cbbTipoIntegranteBan"
            Me.cbbTipoIntegranteBan.Parametro1 = -1
            Me.cbbTipoIntegranteBan.Parametro2 = -1
            Me.cbbTipoIntegranteBan.SelectedIndex = -1
            Me.cbbTipoIntegranteBan.SelectedValue = 0
            Me.cbbTipoIntegranteBan.Size = New System.Drawing.Size(242, 22)
            Me.cbbTipoIntegranteBan.TabIndex = 70
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(8, 21)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(28, 13)
            Me.Label3.TabIndex = 80
            Me.Label3.Text = "Tipo"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(9, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(64, 13)
            Me.Label5.TabIndex = 69
            Me.Label5.Text = "Tipo Integ. :"
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
            Me.cbbBandaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaTipo.DropDownWidth = 222
            Me.cbbBandaTipo.DropDownWidthAuto = False
            Me.cbbBandaTipo.Location = New System.Drawing.Point(84, 18)
            Me.cbbBandaTipo.Name = "cbbBandaTipo"
            Me.cbbBandaTipo.Parametro1 = -1
            Me.cbbBandaTipo.Parametro2 = -1
            Me.cbbBandaTipo.SelectedIndex = -1
            Me.cbbBandaTipo.SelectedValue = 0
            Me.cbbBandaTipo.Size = New System.Drawing.Size(242, 22)
            Me.cbbBandaTipo.TabIndex = 81
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(9, 51)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(72, 13)
            Me.Label7.TabIndex = 105
            Me.Label7.Text = "Descripcion. :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = -1
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = True
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(84, 47)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(242, 21)
            Me.UscLabelBusqueda1.TabIndex = 109
            '
            'grbRegionPenal
            '
            Me.grbRegionPenal.Controls.Add(Me.cbbPenal)
            Me.grbRegionPenal.Controls.Add(Me.cbbRegion)
            Me.grbRegionPenal.Controls.Add(Me.Label28)
            Me.grbRegionPenal.Controls.Add(Me.Label11)
            Me.grbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbRegionPenal.Location = New System.Drawing.Point(0, 0)
            Me.grbRegionPenal.Name = "grbRegionPenal"
            Me.grbRegionPenal.Size = New System.Drawing.Size(337, 84)
            Me.grbRegionPenal.TabIndex = 72
            Me.grbRegionPenal.TabStop = False
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
            Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.PenalUsuario
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 217
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.Location = New System.Drawing.Point(84, 47)
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(242, 22)
            Me.cbbPenal.TabIndex = 52
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
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.RegionUsuario
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 217
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.Location = New System.Drawing.Point(84, 19)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(242, 22)
            Me.cbbRegion.TabIndex = 53
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(8, 23)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(47, 13)
            Me.Label28.TabIndex = 44
            Me.Label28.Text = "Region :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(8, 53)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(40, 13)
            Me.Label11.TabIndex = 12
            Me.Label11.Text = "Penal :"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.dgwGrilla)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(253, 346)
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
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(247, 304)
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
            'frmReportePopup_v2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(596, 391)
            Me.Name = "frmReportePopup_v2"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.grbFecha.ResumeLayout(False)
            Me.grbFecha.PerformLayout()
            Me.grbInternoVisitante.ResumeLayout(False)
            Me.grbInternoVisitante.PerformLayout()
            Me.grbSicrico.ResumeLayout(False)
            Me.grbSicrico.PerformLayout()
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
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents grbFecha As System.Windows.Forms.GroupBox
        Friend WithEvents grbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaInicio As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cbbBandaTipo As APPControls.uscComboParametrica
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoIntegranteBan As APPControls.uscComboParametrica
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents grbSicrico As System.Windows.Forms.GroupBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents grbInternoVisitante As System.Windows.Forms.GroupBox
        Friend WithEvents uscBusquedaInterno As APPControls.uscLabelBusqueda
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents uscBusquedaVisitante As APPControls.uscLabelBusqueda

    End Class
End Namespace