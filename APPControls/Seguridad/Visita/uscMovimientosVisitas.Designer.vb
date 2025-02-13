Namespace Visita

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscMovimientosVisitas
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlBuscar = New System.Windows.Forms.Panel()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_vis_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hor_ing = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_hor_sal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_men_cnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBusqueda = New System.Windows.Forms.Panel()
            Me.dtpDesde = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpHasta = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.pnlFiltroAnio = New System.Windows.Forms.Panel()
            Me.cbbAnio = New Legolas.APPUIComponents.uscComboAnio()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.pnlCountRegistros = New System.Windows.Forms.Panel()
            Me.lblRegInternos = New System.Windows.Forms.Label()
            Me.lblRegVisitantes = New System.Windows.Forms.Label()
            Me.lblRegistros = New System.Windows.Forms.Label()
            Me.pnlCabecera = New System.Windows.Forms.Panel()
            Me.pnlBuscar.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBusqueda.SuspendLayout()
            Me.pnlFiltroAnio.SuspendLayout()
            Me.pnlCountRegistros.SuspendLayout()
            Me.pnlCabecera.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBuscar
            '
            Me.pnlBuscar.Controls.Add(Me.btnBuscar)
            Me.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlBuscar.Location = New System.Drawing.Point(721, 0)
            Me.pnlBuscar.Name = "pnlBuscar"
            Me.pnlBuscar.Size = New System.Drawing.Size(107, 46)
            Me.pnlBuscar.TabIndex = 10
            '
            'btnBuscar
            '
            Me.btnBuscar.Image = Global.APPControls.My.Resources.Resources.view
            Me.btnBuscar.Location = New System.Drawing.Point(2, 3)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(97, 40)
            Me.btnBuscar.TabIndex = 9
            Me.btnBuscar.Text = "Buscar"
            Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(173, 15)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(41, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Hasta :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 15)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "Desde :"
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.col_vis_id, Me.col_vis_ape_nom, Me.Column4, Me.col_int_id, Me.Column5, Me.col_int_ape_nom, Me.Column1, Me.col_fec_ing, Me.col_hor_ing, Me.col_fec_sal, Me.col_hor_sal, Me.col_men_cnt, Me.Column2})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 46)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle9
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(828, 274)
            Me.dgwGrilla.TabIndex = 10
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Codigo"
            Me.Column3.HeaderText = "Codigo"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Visible = False
            Me.Column3.Width = 80
            '
            'col_vis_id
            '
            Me.col_vis_id.DataPropertyName = "VisitaID"
            Me.col_vis_id.HeaderText = "VisitanteID"
            Me.col_vis_id.Name = "col_vis_id"
            Me.col_vis_id.ReadOnly = True
            Me.col_vis_id.Visible = False
            '
            'col_vis_ape_nom
            '
            Me.col_vis_ape_nom.DataPropertyName = "VisitanteApellidosyNombres"
            Me.col_vis_ape_nom.HeaderText = "Visitante"
            Me.col_vis_ape_nom.Name = "col_vis_ape_nom"
            Me.col_vis_ape_nom.ReadOnly = True
            Me.col_vis_ape_nom.Visible = False
            Me.col_vis_ape_nom.Width = 220
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "TipoInterno"
            Me.Column4.HeaderText = "TipoInterno"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Visible = False
            '
            'col_int_id
            '
            Me.col_int_id.DataPropertyName = "InternoID"
            Me.col_int_id.HeaderText = "InternoID"
            Me.col_int_id.Name = "col_int_id"
            Me.col_int_id.ReadOnly = True
            Me.col_int_id.Visible = False
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "IDInternoPJ"
            Me.Column5.HeaderText = "IDInternoPJ"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Visible = False
            '
            'col_int_ape_nom
            '
            Me.col_int_ape_nom.DataPropertyName = "InternoApellidosyNombres"
            Me.col_int_ape_nom.HeaderText = "Interno"
            Me.col_int_ape_nom.Name = "col_int_ape_nom"
            Me.col_int_ape_nom.ReadOnly = True
            Me.col_int_ape_nom.Visible = False
            Me.col_int_ape_nom.Width = 220
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "ParentescoNombre"
            Me.Column1.HeaderText = "Parentesco"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            '
            'col_fec_ing
            '
            Me.col_fec_ing.DataPropertyName = "FechaIngresoDate"
            DataGridViewCellStyle7.Format = "d"
            DataGridViewCellStyle7.NullValue = Nothing
            Me.col_fec_ing.DefaultCellStyle = DataGridViewCellStyle7
            Me.col_fec_ing.HeaderText = "Fecha Ingreso"
            Me.col_fec_ing.Name = "col_fec_ing"
            Me.col_fec_ing.ReadOnly = True
            Me.col_fec_ing.Width = 75
            '
            'col_hor_ing
            '
            Me.col_hor_ing.DataPropertyName = "HoraIngreso"
            Me.col_hor_ing.HeaderText = "Hora Ingreso"
            Me.col_hor_ing.Name = "col_hor_ing"
            Me.col_hor_ing.ReadOnly = True
            Me.col_hor_ing.Width = 65
            '
            'col_fec_sal
            '
            Me.col_fec_sal.DataPropertyName = "FechaSalida"
            DataGridViewCellStyle8.Format = "d"
            Me.col_fec_sal.DefaultCellStyle = DataGridViewCellStyle8
            Me.col_fec_sal.HeaderText = "Fecha Salida"
            Me.col_fec_sal.Name = "col_fec_sal"
            Me.col_fec_sal.ReadOnly = True
            Me.col_fec_sal.Width = 75
            '
            'col_hor_sal
            '
            Me.col_hor_sal.DataPropertyName = "HoraSalida"
            Me.col_hor_sal.HeaderText = "Hora Salida"
            Me.col_hor_sal.Name = "col_hor_sal"
            Me.col_hor_sal.ReadOnly = True
            Me.col_hor_sal.Width = 65
            '
            'col_men_cnt
            '
            Me.col_men_cnt.DataPropertyName = "MenoresCantidad"
            Me.col_men_cnt.HeaderText = "Cant. Men."
            Me.col_men_cnt.Name = "col_men_cnt"
            Me.col_men_cnt.ReadOnly = True
            Me.col_men_cnt.ToolTipText = "Cantidad de menores"
            Me.col_men_cnt.Width = 50
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "Permanencia"
            Me.Column2.HeaderText = "Perman."
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 70
            '
            'pnlBusqueda
            '
            Me.pnlBusqueda.Controls.Add(Me.dtpDesde)
            Me.pnlBusqueda.Controls.Add(Me.Label3)
            Me.pnlBusqueda.Controls.Add(Me.Label2)
            Me.pnlBusqueda.Controls.Add(Me.dtpHasta)
            Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlBusqueda.Location = New System.Drawing.Point(211, 0)
            Me.pnlBusqueda.Name = "pnlBusqueda"
            Me.pnlBusqueda.Size = New System.Drawing.Size(510, 46)
            Me.pnlBusqueda.TabIndex = 11
            '
            'dtpDesde
            '
            Me.dtpDesde.Location = New System.Drawing.Point(64, 13)
            Me.dtpDesde.Name = "dtpDesde"
            Me.dtpDesde.Size = New System.Drawing.Size(84, 21)
            Me.dtpDesde.TabIndex = 5
            Me.dtpDesde.Value = "/  /"
            Me.dtpDesde.ValueLong = CType(0, Long)
            '
            'dtpHasta
            '
            Me.dtpHasta.Location = New System.Drawing.Point(234, 13)
            Me.dtpHasta.Name = "dtpHasta"
            Me.dtpHasta.Size = New System.Drawing.Size(84, 21)
            Me.dtpHasta.TabIndex = 7
            Me.dtpHasta.Value = "/  /"
            Me.dtpHasta.ValueLong = CType(0, Long)
            '
            'pnlFiltroAnio
            '
            Me.pnlFiltroAnio.Controls.Add(Me.cbbAnio)
            Me.pnlFiltroAnio.Controls.Add(Me.Label1)
            Me.pnlFiltroAnio.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlFiltroAnio.Location = New System.Drawing.Point(0, 0)
            Me.pnlFiltroAnio.Name = "pnlFiltroAnio"
            Me.pnlFiltroAnio.Size = New System.Drawing.Size(211, 46)
            Me.pnlFiltroAnio.TabIndex = 12
            '
            'cbbAnio
            '
            Me.cbbAnio._Todos = False
            Me.cbbAnio.AnioFin = 2010
            Me.cbbAnio.AnioInicio = 2014
            Me.cbbAnio.Location = New System.Drawing.Point(99, 12)
            Me.cbbAnio.Name = "cbbAnio"
            Me.cbbAnio.Size = New System.Drawing.Size(93, 21)
            Me.cbbAnio.TabIndex = 12
            Me.cbbAnio.Value = -1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(88, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Seleccione Año :"
            '
            'pnlCountRegistros
            '
            Me.pnlCountRegistros.Controls.Add(Me.lblRegInternos)
            Me.pnlCountRegistros.Controls.Add(Me.lblRegVisitantes)
            Me.pnlCountRegistros.Controls.Add(Me.lblRegistros)
            Me.pnlCountRegistros.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlCountRegistros.Location = New System.Drawing.Point(0, 320)
            Me.pnlCountRegistros.Name = "pnlCountRegistros"
            Me.pnlCountRegistros.Size = New System.Drawing.Size(828, 25)
            Me.pnlCountRegistros.TabIndex = 12
            '
            'lblRegInternos
            '
            Me.lblRegInternos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblRegInternos.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblRegInternos.Location = New System.Drawing.Point(170, 0)
            Me.lblRegInternos.Name = "lblRegInternos"
            Me.lblRegInternos.Size = New System.Drawing.Size(85, 25)
            Me.lblRegInternos.TabIndex = 1
            Me.lblRegInternos.Text = "0 Internos"
            Me.lblRegInternos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblRegInternos.Visible = False
            '
            'lblRegVisitantes
            '
            Me.lblRegVisitantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblRegVisitantes.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblRegVisitantes.Location = New System.Drawing.Point(85, 0)
            Me.lblRegVisitantes.Name = "lblRegVisitantes"
            Me.lblRegVisitantes.Size = New System.Drawing.Size(85, 25)
            Me.lblRegVisitantes.TabIndex = 2
            Me.lblRegVisitantes.Text = "0 Visitantes"
            Me.lblRegVisitantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblRegVisitantes.Visible = False
            '
            'lblRegistros
            '
            Me.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lblRegistros.Dock = System.Windows.Forms.DockStyle.Left
            Me.lblRegistros.Location = New System.Drawing.Point(0, 0)
            Me.lblRegistros.Name = "lblRegistros"
            Me.lblRegistros.Size = New System.Drawing.Size(85, 25)
            Me.lblRegistros.TabIndex = 0
            Me.lblRegistros.Text = "0 Reg."
            Me.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pnlCabecera
            '
            Me.pnlCabecera.Controls.Add(Me.pnlBusqueda)
            Me.pnlCabecera.Controls.Add(Me.pnlBuscar)
            Me.pnlCabecera.Controls.Add(Me.pnlFiltroAnio)
            Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
            Me.pnlCabecera.Name = "pnlCabecera"
            Me.pnlCabecera.Size = New System.Drawing.Size(828, 46)
            Me.pnlCabecera.TabIndex = 13
            '
            'uscMovimientosVisitas
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.pnlCabecera)
            Me.Controls.Add(Me.pnlCountRegistros)
            Me.Name = "uscMovimientosVisitas"
            Me.Size = New System.Drawing.Size(828, 345)
            Me.pnlBuscar.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBusqueda.ResumeLayout(False)
            Me.pnlBusqueda.PerformLayout()
            Me.pnlFiltroAnio.ResumeLayout(False)
            Me.pnlFiltroAnio.PerformLayout()
            Me.pnlCountRegistros.ResumeLayout(False)
            Me.pnlCabecera.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpHasta As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpDesde As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents pnlBuscar As System.Windows.Forms.Panel
        Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
        Friend WithEvents pnlCountRegistros As System.Windows.Forms.Panel
        Friend WithEvents lblRegVisitantes As System.Windows.Forms.Label
        Friend WithEvents lblRegInternos As System.Windows.Forms.Label
        Friend WithEvents lblRegistros As System.Windows.Forms.Label
        Friend WithEvents pnlFiltroAnio As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbAnio As Legolas.APPUIComponents.uscComboAnio
        Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_vis_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hor_ing As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_sal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_hor_sal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_men_cnt As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace