Namespace Registro.Resoluciones
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmResolucionTipoPopup
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
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.lblReg = New System.Windows.Forms.Label()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_tipo_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.rdbIngreso = New System.Windows.Forms.RadioButton()
            Me.rdbEgreso = New System.Windows.Forms.RadioButton()
            Me.rdbSentencia = New System.Windows.Forms.RadioButton()
            Me.grbCabecera = New System.Windows.Forms.GroupBox()
            Me.rdbAclarados = New System.Windows.Forms.RadioButton()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.dgwGrillaSubtipo = New System.Windows.Forms.DataGridView()
            Me.col_sub_tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grbCabecera.SuspendLayout()
            CType(Me.dgwGrillaSubtipo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.grbCabecera)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(444, 334)
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.btnCancel)
            Me.PnlBotones.Controls.Add(Me.btnOk)
            Me.PnlBotones.Controls.Add(Me.lblReg)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 288)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(444, 46)
            Me.PnlBotones.TabIndex = 3
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(350, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(89, 40)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(258, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(89, 40)
            Me.btnOk.TabIndex = 1
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'lblReg
            '
            Me.lblReg.AutoSize = True
            Me.lblReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblReg.Location = New System.Drawing.Point(3, 19)
            Me.lblReg.Name = "lblReg"
            Me.lblReg.Size = New System.Drawing.Size(45, 13)
            Me.lblReg.TabIndex = 0
            Me.lblReg.Text = "0 Reg."
            Me.lblReg.Visible = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.ColumnHeadersVisible = False
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_id, Me.col_tipo_nom})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgwGrilla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(206, 246)
            Me.dgwGrilla.TabIndex = 1
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_id.DefaultCellStyle = DataGridViewCellStyle1
            Me.col_id.HeaderText = "ID Tipo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 50
            '
            'col_tipo_nom
            '
            Me.col_tipo_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_tipo_nom.DataPropertyName = "DocJudTipo"
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.col_tipo_nom.DefaultCellStyle = DataGridViewCellStyle2
            Me.col_tipo_nom.HeaderText = "Nombre del Documento"
            Me.col_tipo_nom.Name = "col_tipo_nom"
            Me.col_tipo_nom.ReadOnly = True
            '
            'rdbIngreso
            '
            Me.rdbIngreso.AutoSize = True
            Me.rdbIngreso.Checked = True
            Me.rdbIngreso.Location = New System.Drawing.Point(8, 10)
            Me.rdbIngreso.Name = "rdbIngreso"
            Me.rdbIngreso.Size = New System.Drawing.Size(85, 30)
            Me.rdbIngreso.TabIndex = 1
            Me.rdbIngreso.TabStop = True
            Me.rdbIngreso.Text = "Ingreso y/o " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detenciones"
            Me.rdbIngreso.UseVisualStyleBackColor = True
            '
            'rdbEgreso
            '
            Me.rdbEgreso.AutoSize = True
            Me.rdbEgreso.Location = New System.Drawing.Point(207, 17)
            Me.rdbEgreso.Name = "rdbEgreso"
            Me.rdbEgreso.Size = New System.Drawing.Size(74, 17)
            Me.rdbEgreso.TabIndex = 3
            Me.rdbEgreso.Text = "Libertades"
            Me.rdbEgreso.UseVisualStyleBackColor = True
            '
            'rdbSentencia
            '
            Me.rdbSentencia.AutoSize = True
            Me.rdbSentencia.Location = New System.Drawing.Point(112, 17)
            Me.rdbSentencia.Name = "rdbSentencia"
            Me.rdbSentencia.Size = New System.Drawing.Size(78, 17)
            Me.rdbSentencia.TabIndex = 2
            Me.rdbSentencia.Text = "Sentencias"
            Me.rdbSentencia.UseVisualStyleBackColor = True
            '
            'grbCabecera
            '
            Me.grbCabecera.Controls.Add(Me.rdbAclarados)
            Me.grbCabecera.Controls.Add(Me.rdbTodos)
            Me.grbCabecera.Controls.Add(Me.rdbIngreso)
            Me.grbCabecera.Controls.Add(Me.rdbSentencia)
            Me.grbCabecera.Controls.Add(Me.rdbEgreso)
            Me.grbCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbCabecera.Location = New System.Drawing.Point(0, 0)
            Me.grbCabecera.Name = "grbCabecera"
            Me.grbCabecera.Size = New System.Drawing.Size(444, 42)
            Me.grbCabecera.TabIndex = 0
            Me.grbCabecera.TabStop = False
            '
            'rdbAclarados
            '
            Me.rdbAclarados.AutoSize = True
            Me.rdbAclarados.Location = New System.Drawing.Point(364, 17)
            Me.rdbAclarados.Name = "rdbAclarados"
            Me.rdbAclarados.Size = New System.Drawing.Size(72, 17)
            Me.rdbAclarados.TabIndex = 5
            Me.rdbAclarados.Text = "Aclarados"
            Me.rdbAclarados.UseVisualStyleBackColor = True
            Me.rdbAclarados.Visible = False
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(295, 17)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 4
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'dgwGrillaSubtipo
            '
            Me.dgwGrillaSubtipo.AllowUserToAddRows = False
            Me.dgwGrillaSubtipo.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrillaSubtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrillaSubtipo.ColumnHeadersVisible = False
            Me.dgwGrillaSubtipo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sub_tip, Me.DataGridViewTextBoxColumn2})
            Me.dgwGrillaSubtipo.Dock = System.Windows.Forms.DockStyle.Right
            Me.dgwGrillaSubtipo.GridColor = System.Drawing.Color.LightGray
            Me.dgwGrillaSubtipo.Location = New System.Drawing.Point(206, 0)
            Me.dgwGrillaSubtipo.MultiSelect = False
            Me.dgwGrillaSubtipo.Name = "dgwGrillaSubtipo"
            Me.dgwGrillaSubtipo.ReadOnly = True
            Me.dgwGrillaSubtipo.RowHeadersVisible = False
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrillaSubtipo.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgwGrillaSubtipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrillaSubtipo.Size = New System.Drawing.Size(238, 246)
            Me.dgwGrillaSubtipo.TabIndex = 2
            '
            'col_sub_tip
            '
            Me.col_sub_tip.DataPropertyName = "Codigo"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.col_sub_tip.DefaultCellStyle = DataGridViewCellStyle4
            Me.col_sub_tip.HeaderText = "ID Tipo"
            Me.col_sub_tip.Name = "col_sub_tip"
            Me.col_sub_tip.ReadOnly = True
            Me.col_sub_tip.Visible = False
            Me.col_sub_tip.Width = 50
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreSubTipo"
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
            Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre del Documento"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.ReadOnly = True
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.dgwGrilla)
            Me.Panel1.Controls.Add(Me.dgwGrillaSubtipo)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 42)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(444, 246)
            Me.Panel1.TabIndex = 4
            '
            'frmResolucionTipoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(444, 334)
            Me.Name = "frmResolucionTipoPopup"
            Me.Text = "Seleccione el Tipo de Documento"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.PnlBotones.ResumeLayout(False)
            Me.PnlBotones.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grbCabecera.ResumeLayout(False)
            Me.grbCabecera.PerformLayout()
            CType(Me.dgwGrillaSubtipo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PnlBotones As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents lblReg As System.Windows.Forms.Label
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_tipo_nom As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents rdbIngreso As System.Windows.Forms.RadioButton
        Friend WithEvents grbCabecera As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSentencia As System.Windows.Forms.RadioButton
        Friend WithEvents rdbEgreso As System.Windows.Forms.RadioButton
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents dgwGrillaSubtipo As System.Windows.Forms.DataGridView
        Friend WithEvents col_sub_tip As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents rdbAclarados As System.Windows.Forms.RadioButton
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
    End Class
End Namespace