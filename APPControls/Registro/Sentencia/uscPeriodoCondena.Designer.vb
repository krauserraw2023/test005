Namespace Registro.Sentencias
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class uscPeriodoCondena
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlTiempoConde = New System.Windows.Forms.Panel()
            Me.dgvPeriodoCondena = New Legolas.APPUIComponents.myDatagridView()
            Me.col_ped_cond_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_doc_jud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtDias = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtAnios = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMeses = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.pnlMantBotPeriCondena = New System.Windows.Forms.Panel()
            Me.pnlAgravMant = New System.Windows.Forms.Panel()
            Me.btnAddPerCond = New System.Windows.Forms.Button()
            Me.btnEditPerCond = New System.Windows.Forms.Button()
            Me.pnlEliminarAgraviado = New System.Windows.Forms.Panel()
            Me.btnDelPerCond = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.pnlTiempoConde.SuspendLayout()
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlMantBotPeriCondena.SuspendLayout()
            Me.pnlAgravMant.SuspendLayout()
            Me.pnlEliminarAgraviado.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlTiempoConde
            '
            Me.pnlTiempoConde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.pnlTiempoConde.Controls.Add(Me.dgvPeriodoCondena)
            Me.pnlTiempoConde.Controls.Add(Me.Panel1)
            Me.pnlTiempoConde.Controls.Add(Me.Panel2)
            Me.pnlTiempoConde.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlTiempoConde.Location = New System.Drawing.Point(0, 0)
            Me.pnlTiempoConde.Name = "pnlTiempoConde"
            Me.pnlTiempoConde.Size = New System.Drawing.Size(206, 143)
            Me.pnlTiempoConde.TabIndex = 2
            '
            'dgvPeriodoCondena
            '
            Me.dgvPeriodoCondena.AllowUserToAddRows = False
            Me.dgvPeriodoCondena.AllowUserToDeleteRows = False
            Me.dgvPeriodoCondena.AllowUserToResizeRows = False
            Me.dgvPeriodoCondena.BackgroundColor = System.Drawing.Color.White
            Me.dgvPeriodoCondena.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvPeriodoCondena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvPeriodoCondena.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_ped_cond_item, Me.col_cod, Me.col_ini, Me.col_fin, Me.col_doc_jud_id, Me.col_eliminado})
            Me.dgvPeriodoCondena.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvPeriodoCondena.GridColor = System.Drawing.Color.LightGray
            Me.dgvPeriodoCondena.Location = New System.Drawing.Point(0, 53)
            Me.dgvPeriodoCondena.MultiSelect = False
            Me.dgvPeriodoCondena.Name = "dgvPeriodoCondena"
            Me.dgvPeriodoCondena.ReadOnly = True
            Me.dgvPeriodoCondena.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgvPeriodoCondena.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvPeriodoCondena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgvPeriodoCondena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvPeriodoCondena.Size = New System.Drawing.Size(202, 86)
            Me.dgvPeriodoCondena.TabIndex = 2
            Me.dgvPeriodoCondena.VisibleCampos = True
            '
            'col_ped_cond_item
            '
            Me.col_ped_cond_item.DataPropertyName = "PeriodoCondenaItem"
            Me.col_ped_cond_item.DividerWidth = 1
            Me.col_ped_cond_item.HeaderText = "PerCondItem"
            Me.col_ped_cond_item.Name = "col_ped_cond_item"
            Me.col_ped_cond_item.ReadOnly = True
            Me.col_ped_cond_item.Visible = False
            '
            'col_cod
            '
            Me.col_cod.DataPropertyName = "Codigo"
            Me.col_cod.HeaderText = "Codigo"
            Me.col_cod.Name = "col_cod"
            Me.col_cod.ReadOnly = True
            Me.col_cod.Visible = False
            Me.col_cod.Width = 50
            '
            'col_ini
            '
            Me.col_ini.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_ini.DataPropertyName = "FechaInicioString"
            DataGridViewCellStyle1.Format = "d"
            DataGridViewCellStyle1.NullValue = "00/00/0000"
            Me.col_ini.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_ini.HeaderText = "Inicio"
            Me.col_ini.Name = "col_ini"
            Me.col_ini.ReadOnly = True
            '
            'col_fin
            '
            Me.col_fin.DataPropertyName = "FechaFinString"
            DataGridViewCellStyle2.Format = "d"
            DataGridViewCellStyle2.NullValue = "00/00/0000"
            Me.col_fin.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_fin.HeaderText = "Fin"
            Me.col_fin.Name = "col_fin"
            Me.col_fin.ReadOnly = True
            Me.col_fin.Width = 85
            '
            'col_doc_jud_id
            '
            Me.col_doc_jud_id.DataPropertyName = "DocJudicialId"
            Me.col_doc_jud_id.DividerWidth = 1
            Me.col_doc_jud_id.HeaderText = "DocJudId"
            Me.col_doc_jud_id.Name = "col_doc_jud_id"
            Me.col_doc_jud_id.ReadOnly = True
            Me.col_doc_jud_id.Visible = False
            Me.col_doc_jud_id.Width = 30
            '
            'col_eliminado
            '
            Me.col_eliminado.DataPropertyName = "FlgEliminado"
            Me.col_eliminado.DividerWidth = 1
            Me.col_eliminado.HeaderText = "Eliminado"
            Me.col_eliminado.Name = "col_eliminado"
            Me.col_eliminado.ReadOnly = True
            Me.col_eliminado.Visible = False
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.txtDias)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.txtAnios)
            Me.Panel1.Controls.Add(Me.txtMeses)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.Label8)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 28)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(202, 25)
            Me.Panel1.TabIndex = 1
            '
            'txtDias
            '
            Me.txtDias._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDias._BloquearPaste = False
            Me.txtDias._SeleccionarTodo = False
            Me.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDias.Location = New System.Drawing.Point(169, 1)
            Me.txtDias.MaxLength = 5
            Me.txtDias.Name = "txtDias"
            Me.txtDias.Size = New System.Drawing.Size(25, 20)
            Me.txtDias.TabIndex = 5
            Me.txtDias.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDias.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(2, 4)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(31, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Años"
            '
            'txtAnios
            '
            Me.txtAnios._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAnios._BloquearPaste = False
            Me.txtAnios._SeleccionarTodo = False
            Me.txtAnios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtAnios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtAnios.Location = New System.Drawing.Point(35, 1)
            Me.txtAnios.MaxLength = 2
            Me.txtAnios.Name = "txtAnios"
            Me.txtAnios.Size = New System.Drawing.Size(25, 20)
            Me.txtAnios.TabIndex = 1
            Me.txtAnios.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAnios.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'txtMeses
            '
            Me.txtMeses._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtMeses._BloquearPaste = False
            Me.txtMeses._SeleccionarTodo = False
            Me.txtMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMeses.Location = New System.Drawing.Point(104, 1)
            Me.txtMeses.MaxLength = 3
            Me.txtMeses.Name = "txtMeses"
            Me.txtMeses.Size = New System.Drawing.Size(25, 20)
            Me.txtMeses.TabIndex = 3
            Me.txtMeses.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMeses.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(65, 5)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(38, 13)
            Me.Label7.TabIndex = 2
            Me.Label7.Text = "Meses"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(135, 4)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(28, 13)
            Me.Label8.TabIndex = 4
            Me.Label8.Text = "Dias"
            '
            'Panel2
            '
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.pnlMantBotPeriCondena)
            Me.Panel2.Controls.Add(Me.Label5)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(202, 28)
            Me.Panel2.TabIndex = 0
            '
            'pnlMantBotPeriCondena
            '
            Me.pnlMantBotPeriCondena.Controls.Add(Me.pnlAgravMant)
            Me.pnlMantBotPeriCondena.Controls.Add(Me.pnlEliminarAgraviado)
            Me.pnlMantBotPeriCondena.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlMantBotPeriCondena.Location = New System.Drawing.Point(105, 0)
            Me.pnlMantBotPeriCondena.Name = "pnlMantBotPeriCondena"
            Me.pnlMantBotPeriCondena.Size = New System.Drawing.Size(95, 26)
            Me.pnlMantBotPeriCondena.TabIndex = 1
            '
            'pnlAgravMant
            '
            Me.pnlAgravMant.Controls.Add(Me.btnAddPerCond)
            Me.pnlAgravMant.Controls.Add(Me.btnEditPerCond)
            Me.pnlAgravMant.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlAgravMant.Location = New System.Drawing.Point(4, 0)
            Me.pnlAgravMant.Name = "pnlAgravMant"
            Me.pnlAgravMant.Size = New System.Drawing.Size(60, 26)
            Me.pnlAgravMant.TabIndex = 1
            '
            'btnAddPerCond
            '
            Me.btnAddPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.add_32
            Me.btnAddPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAddPerCond.Location = New System.Drawing.Point(0, 0)
            Me.btnAddPerCond.Name = "btnAddPerCond"
            Me.btnAddPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnAddPerCond.TabIndex = 0
            Me.btnAddPerCond.UseVisualStyleBackColor = True
            '
            'btnEditPerCond
            '
            Me.btnEditPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources._1277961326_folder_edit
            Me.btnEditPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnEditPerCond.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnEditPerCond.Location = New System.Drawing.Point(30, 0)
            Me.btnEditPerCond.Name = "btnEditPerCond"
            Me.btnEditPerCond.Size = New System.Drawing.Size(30, 26)
            Me.btnEditPerCond.TabIndex = 1
            Me.btnEditPerCond.UseVisualStyleBackColor = True
            '
            'pnlEliminarAgraviado
            '
            Me.pnlEliminarAgraviado.Controls.Add(Me.btnDelPerCond)
            Me.pnlEliminarAgraviado.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlEliminarAgraviado.Location = New System.Drawing.Point(64, 0)
            Me.pnlEliminarAgraviado.Name = "pnlEliminarAgraviado"
            Me.pnlEliminarAgraviado.Size = New System.Drawing.Size(31, 26)
            Me.pnlEliminarAgraviado.TabIndex = 2
            '
            'btnDelPerCond
            '
            Me.btnDelPerCond.BackgroundImage = Global.APPControls.My.Resources.Resources.delete_32
            Me.btnDelPerCond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnDelPerCond.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnDelPerCond.Location = New System.Drawing.Point(0, 0)
            Me.btnDelPerCond.Name = "btnDelPerCond"
            Me.btnDelPerCond.Size = New System.Drawing.Size(31, 26)
            Me.btnDelPerCond.TabIndex = 3
            Me.btnDelPerCond.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(0, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(200, 26)
            Me.Label5.TabIndex = 0
            Me.Label5.Text = "Periodo Condena"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel5
            '
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.pnlTiempoConde)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel5.Location = New System.Drawing.Point(0, 0)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(208, 145)
            Me.Panel5.TabIndex = 0
            '
            'DataGridViewImageColumn1
            '
            Me.DataGridViewImageColumn1.HeaderText = ""
            Me.DataGridViewImageColumn1.Image = Global.APPControls.My.Resources.Resources.flechacombo
            Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
            Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DataGridViewImageColumn1.Width = 20
            '
            'uscPeriodoCondena
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel5)
            Me.Name = "uscPeriodoCondena"
            Me.Size = New System.Drawing.Size(208, 145)
            Me.pnlTiempoConde.ResumeLayout(False)
            CType(Me.dgvPeriodoCondena, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlMantBotPeriCondena.ResumeLayout(False)
            Me.pnlAgravMant.ResumeLayout(False)
            Me.pnlEliminarAgraviado.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlTiempoConde As System.Windows.Forms.Panel
        Friend WithEvents dgvPeriodoCondena As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlAgravMant As System.Windows.Forms.Panel
        Friend WithEvents btnEditPerCond As System.Windows.Forms.Button
        Friend WithEvents btnAddPerCond As System.Windows.Forms.Button
        Friend WithEvents pnlEliminarAgraviado As System.Windows.Forms.Panel
        Friend WithEvents btnDelPerCond As System.Windows.Forms.Button
        Friend WithEvents txtDias As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtMeses As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtAnios As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents col_ped_cond_item As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_cod As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_ini As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_fin As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_doc_jud_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
        Friend WithEvents pnlMantBotPeriCondena As Panel
    End Class
End Namespace