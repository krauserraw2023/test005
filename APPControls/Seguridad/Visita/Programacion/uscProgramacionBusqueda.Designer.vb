Namespace Visita.Programacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscProgramacionBusqueda
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox9 = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbSexoAmbos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbMujeres = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbHombres = New Legolas.APPUIComponents.myRadioButton()
            Me.grbEtapa = New System.Windows.Forms.GroupBox()
            Me.cbbEtapa = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlVisitaExtra = New System.Windows.Forms.Panel()
            Me.gbSelectInterno = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.pnlVisita = New System.Windows.Forms.Panel()
            Me.pnlAdd = New System.Windows.Forms.Panel()
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fec_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_etp_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_sex_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_int_ape_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_est = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox9.SuspendLayout()
            Me.grbEtapa.SuspendLayout()
            Me.cbbEtapa.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlVisitaExtra.SuspendLayout()
            Me.gbSelectInterno.SuspendLayout()
            Me.pnlVisita.SuspendLayout()
            Me.pnlAdd.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupBox9
            '
            Me.GroupBox9.Controls.Add(Me.rdbTodos)
            Me.GroupBox9.Controls.Add(Me.rdbSexoAmbos)
            Me.GroupBox9.Controls.Add(Me.rdbMujeres)
            Me.GroupBox9.Controls.Add(Me.rdbHombres)
            Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox9.Location = New System.Drawing.Point(181, 0)
            Me.GroupBox9.Name = "GroupBox9"
            Me.GroupBox9.Size = New System.Drawing.Size(334, 66)
            Me.GroupBox9.TabIndex = 73
            Me.GroupBox9.TabStop = False
            Me.GroupBox9.Text = "Sexo"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(251, 21)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 64
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbSexoAmbos
            '
            Me.rdbSexoAmbos.AutoSize = True
            Me.rdbSexoAmbos.Location = New System.Drawing.Point(175, 21)
            Me.rdbSexoAmbos.Name = "rdbSexoAmbos"
            Me.rdbSexoAmbos.Size = New System.Drawing.Size(57, 17)
            Me.rdbSexoAmbos.TabIndex = 63
            Me.rdbSexoAmbos.Text = "Ambos"
            Me.rdbSexoAmbos.UseVisualStyleBackColor = True
            '
            'rdbMujeres
            '
            Me.rdbMujeres.AutoSize = True
            Me.rdbMujeres.Location = New System.Drawing.Point(92, 21)
            Me.rdbMujeres.Name = "rdbMujeres"
            Me.rdbMujeres.Size = New System.Drawing.Size(62, 17)
            Me.rdbMujeres.TabIndex = 62
            Me.rdbMujeres.Text = "Mujeres"
            Me.rdbMujeres.UseVisualStyleBackColor = True
            '
            'rdbHombres
            '
            Me.rdbHombres.AutoSize = True
            Me.rdbHombres.Location = New System.Drawing.Point(9, 21)
            Me.rdbHombres.Name = "rdbHombres"
            Me.rdbHombres.Size = New System.Drawing.Size(67, 17)
            Me.rdbHombres.TabIndex = 61
            Me.rdbHombres.Text = "Hombres"
            Me.rdbHombres.UseVisualStyleBackColor = True
            '
            'grbEtapa
            '
            Me.grbEtapa.Controls.Add(Me.cbbEtapa)
            Me.grbEtapa.Dock = System.Windows.Forms.DockStyle.Left
            Me.grbEtapa.Location = New System.Drawing.Point(0, 0)
            Me.grbEtapa.Name = "grbEtapa"
            Me.grbEtapa.Size = New System.Drawing.Size(181, 66)
            Me.grbEtapa.TabIndex = 72
            Me.grbEtapa.TabStop = False
            Me.grbEtapa.Text = "Seleccione Etapa :"
            '
            'cbbEtapa
            '
            Me.cbbEtapa._NoIndica = False
            Me.cbbEtapa._Todos = False
            Me.cbbEtapa._TodosMensaje = ""
            Me.cbbEtapa._Visible_Add = False
            Me.cbbEtapa._Visible_Buscar = False
            Me.cbbEtapa._Visible_Eliminar = False
            Me.cbbEtapa.CodigoPadre = 1
            Me.cbbEtapa.ComboTipo = Type.Combo.ComboTipo.Ninguno
            Me.cbbEtapa.Controls.Add(Me.ComboBox1)
            Me.cbbEtapa.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbEtapa.DropDownWidth = 123
            Me.cbbEtapa.DropDownWidthAuto = False
            Me.cbbEtapa.Location = New System.Drawing.Point(6, 19)
            Me.cbbEtapa.Name = "cbbEtapa"
            Me.cbbEtapa.Parametro1 = -1
            Me.cbbEtapa.Parametro2 = -1
            Me.cbbEtapa.SelectedIndex = -1
            Me.cbbEtapa.SelectedValue = 0
            Me.cbbEtapa.Size = New System.Drawing.Size(160, 22)
            Me.cbbEtapa.TabIndex = 3
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 123
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(160, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.pnlVisitaExtra)
            Me.Panel2.Controls.Add(Me.pnlVisita)
            Me.Panel2.Controls.Add(Me.pnlAdd)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(927, 66)
            Me.Panel2.TabIndex = 74
            '
            'pnlVisitaExtra
            '
            Me.pnlVisitaExtra.Controls.Add(Me.gbSelectInterno)
            Me.pnlVisitaExtra.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlVisitaExtra.Location = New System.Drawing.Point(515, 0)
            Me.pnlVisitaExtra.Name = "pnlVisitaExtra"
            Me.pnlVisitaExtra.Size = New System.Drawing.Size(297, 66)
            Me.pnlVisitaExtra.TabIndex = 75
            Me.pnlVisitaExtra.Visible = False
            '
            'gbSelectInterno
            '
            Me.gbSelectInterno.Controls.Add(Me.Label1)
            Me.gbSelectInterno.Controls.Add(Me.UscLabelBusqueda1)
            Me.gbSelectInterno.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbSelectInterno.Location = New System.Drawing.Point(0, 0)
            Me.gbSelectInterno.Name = "gbSelectInterno"
            Me.gbSelectInterno.Size = New System.Drawing.Size(297, 66)
            Me.gbSelectInterno.TabIndex = 73
            Me.gbSelectInterno.TabStop = False
            Me.gbSelectInterno.Text = "Interno"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(102, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Seleccione Interno :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = True
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(9, 33)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(223, 21)
            Me.UscLabelBusqueda1.TabIndex = 8
            '
            'pnlVisita
            '
            Me.pnlVisita.Controls.Add(Me.GroupBox9)
            Me.pnlVisita.Controls.Add(Me.grbEtapa)
            Me.pnlVisita.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlVisita.Location = New System.Drawing.Point(0, 0)
            Me.pnlVisita.Name = "pnlVisita"
            Me.pnlVisita.Size = New System.Drawing.Size(515, 66)
            Me.pnlVisita.TabIndex = 74
            '
            'pnlAdd
            '
            Me.pnlAdd.Controls.Add(Me.btnAgregar)
            Me.pnlAdd.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAdd.Location = New System.Drawing.Point(818, 0)
            Me.pnlAdd.Name = "pnlAdd"
            Me.pnlAdd.Size = New System.Drawing.Size(109, 66)
            Me.pnlAdd.TabIndex = 12
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAgregar.Location = New System.Drawing.Point(5, 9)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(97, 40)
            Me.btnAgregar.TabIndex = 11
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.Column1, Me.col_fec_ini, Me.col_fec_fin, Me.Column5, Me.col_etp_nom, Me.col_sex_nom, Me.col_int_ape_nom, Me.Column3, Me.Column2, Me.Column8, Me.Column9, Me.Column10, Me.col_est})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 66)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(927, 327)
            Me.dgwGrilla.TabIndex = 75
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "CalendarioDetalleID"
            Me.col_id.HeaderText = "CalendarioDetalleID"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "CalendarioID"
            Me.Column1.HeaderText = "CalendarioID"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            '
            'col_fec_ini
            '
            Me.col_fec_ini.DataPropertyName = "FechaInicio"
            DataGridViewCellStyle1.Format = "d"
            Me.col_fec_ini.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_fec_ini.HeaderText = "Fecha Inicio"
            Me.col_fec_ini.Name = "col_fec_ini"
            Me.col_fec_ini.ReadOnly = True
            Me.col_fec_ini.Width = 85
            '
            'col_fec_fin
            '
            Me.col_fec_fin.DataPropertyName = "FechaFinSinFecha"
            DataGridViewCellStyle2.Format = "d"
            Me.col_fec_fin.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fec_fin.HeaderText = "Fecha Fin"
            Me.col_fec_fin.Name = "col_fec_fin"
            Me.col_fec_fin.ReadOnly = True
            Me.col_fec_fin.Width = 85
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "EtapaID"
            Me.Column5.HeaderText = "EtapaID"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Visible = False
            '
            'col_etp_nom
            '
            Me.col_etp_nom.DataPropertyName = "Etapa"
            Me.col_etp_nom.HeaderText = "Etapa"
            Me.col_etp_nom.Name = "col_etp_nom"
            Me.col_etp_nom.ReadOnly = True
            Me.col_etp_nom.Width = 90
            '
            'col_sex_nom
            '
            Me.col_sex_nom.DataPropertyName = "Sexo"
            Me.col_sex_nom.HeaderText = "Sexo"
            Me.col_sex_nom.Name = "col_sex_nom"
            Me.col_sex_nom.ReadOnly = True
            Me.col_sex_nom.Width = 70
            '
            'col_int_ape_nom
            '
            Me.col_int_ape_nom.DataPropertyName = "InternoApellidosyNombres"
            Me.col_int_ape_nom.HeaderText = "Interno"
            Me.col_int_ape_nom.Name = "col_int_ape_nom"
            Me.col_int_ape_nom.ReadOnly = True
            Me.col_int_ape_nom.Visible = False
            Me.col_int_ape_nom.Width = 200
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "FrecuenciaReadonly"
            Me.Column3.HeaderText = "Frecuencia"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 80
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "Programacion"
            Me.Column2.HeaderText = "Programacion"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 200
            '
            'Column8
            '
            Me.Column8.DataPropertyName = "HoraInicioReadonly"
            Me.Column8.HeaderText = "Hora Inicio"
            Me.Column8.Name = "Column8"
            Me.Column8.ReadOnly = True
            Me.Column8.Width = 70
            '
            'Column9
            '
            Me.Column9.DataPropertyName = "HoraFinReadonly"
            Me.Column9.HeaderText = "Hora Fin"
            Me.Column9.Name = "Column9"
            Me.Column9.ReadOnly = True
            Me.Column9.Width = 70
            '
            'Column10
            '
            Me.Column10.DataPropertyName = "Duracion"
            Me.Column10.HeaderText = "Duracion"
            Me.Column10.Name = "Column10"
            Me.Column10.ReadOnly = True
            Me.Column10.Width = 60
            '
            'col_est
            '
            Me.col_est.DataPropertyName = "Estado"
            Me.col_est.HeaderText = "Estado"
            Me.col_est.Name = "col_est"
            Me.col_est.ReadOnly = True
            Me.col_est.Visible = False
            '
            'uscProgramacionBusqueda
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.dgwGrilla)
            Me.Controls.Add(Me.Panel2)
            Me.Name = "uscProgramacionBusqueda"
            Me.Size = New System.Drawing.Size(927, 393)
            Me.GroupBox9.ResumeLayout(False)
            Me.GroupBox9.PerformLayout()
            Me.grbEtapa.ResumeLayout(False)
            Me.cbbEtapa.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlVisitaExtra.ResumeLayout(False)
            Me.gbSelectInterno.ResumeLayout(False)
            Me.gbSelectInterno.PerformLayout()
            Me.pnlVisita.ResumeLayout(False)
            Me.pnlAdd.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSexoAmbos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbMujeres As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbHombres As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents grbEtapa As System.Windows.Forms.GroupBox
        Friend WithEvents cbbEtapa As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents pnlAdd As System.Windows.Forms.Panel
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents rdbTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents pnlVisitaExtra As System.Windows.Forms.Panel
        Friend WithEvents pnlVisita As System.Windows.Forms.Panel
        Friend WithEvents gbSelectInterno As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fec_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_etp_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_sex_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_int_ape_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_est As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace