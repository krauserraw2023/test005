Namespace Mantenimiento.Reporte.GrupoEgreso
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMantDetPopup
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.GroupBox4_ = New System.Windows.Forms.GroupBox()
            Me.lblGrillaCount = New System.Windows.Forms.Label()
            Me.btnExportar = New System.Windows.Forms.Button()
            Me.btnAddPenal = New System.Windows.Forms.Button()
            Me.txtNombreDet = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.chkTodos = New System.Windows.Forms.CheckBox()
            Me.dgwGrilla = New System.Windows.Forms.DataGridView()
            Me.col_chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_del_esp = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnEliminar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtTipoEgreso = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNombreTabla = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox4_.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox4_
            '
            Me.GroupBox4_.Controls.Add(Me.lblGrillaCount)
            Me.GroupBox4_.Controls.Add(Me.btnExportar)
            Me.GroupBox4_.Controls.Add(Me.btnAddPenal)
            Me.GroupBox4_.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4_.Location = New System.Drawing.Point(0, 121)
            Me.GroupBox4_.Name = "GroupBox4_"
            Me.GroupBox4_.Size = New System.Drawing.Size(656, 54)
            Me.GroupBox4_.TabIndex = 54
            Me.GroupBox4_.TabStop = False
            '
            'lblGrillaCount
            '
            Me.lblGrillaCount.AutoSize = True
            Me.lblGrillaCount.Location = New System.Drawing.Point(113, 37)
            Me.lblGrillaCount.Name = "lblGrillaCount"
            Me.lblGrillaCount.Size = New System.Drawing.Size(45, 13)
            Me.lblGrillaCount.TabIndex = 92
            Me.lblGrillaCount.Text = "0 Reg. :"
            '
            'btnExportar
            '
            Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExportar.Image = Global.SIPPOPE.My.Resources.Resources.Excel_32
            Me.btnExportar.Location = New System.Drawing.Point(6, 10)
            Me.btnExportar.Name = "btnExportar"
            Me.btnExportar.Size = New System.Drawing.Size(101, 40)
            Me.btnExportar.TabIndex = 91
            Me.btnExportar.Text = "&Exportar"
            Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnExportar.UseVisualStyleBackColor = True
            '
            'btnAddPenal
            '
            Me.btnAddPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddPenal.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAddPenal.Location = New System.Drawing.Point(550, 10)
            Me.btnAddPenal.Name = "btnAddPenal"
            Me.btnAddPenal.Size = New System.Drawing.Size(94, 40)
            Me.btnAddPenal.TabIndex = 89
            Me.btnAddPenal.Text = "Agregar"
            Me.btnAddPenal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'txtNombreDet
            '
            Me.txtNombreDet._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombreDet._BloquearPaste = False
            Me.txtNombreDet._SeleccionarTodo = False
            Me.txtNombreDet.Location = New System.Drawing.Point(116, 91)
            Me.txtNombreDet.Name = "txtNombreDet"
            Me.txtNombreDet.ReadOnly = True
            Me.txtNombreDet.Size = New System.Drawing.Size(528, 20)
            Me.txtNombreDet.TabIndex = 50
            Me.txtNombreDet.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombreDet.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(116, 65)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.ReadOnly = True
            Me.txtNombre.Size = New System.Drawing.Size(528, 20)
            Me.txtNombre.TabIndex = 49
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 95)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 13)
            Me.Label1.TabIndex = 48
            Me.Label1.Text = "Nombre Detalle:"
            '
            'Label26
            '
            Me.Label26.AutoSize = True
            Me.Label26.Location = New System.Drawing.Point(12, 68)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(47, 13)
            Me.Label26.TabIndex = 47
            Me.Label26.Text = "Nombre:"
            '
            'chkTodos
            '
            Me.chkTodos.AutoSize = True
            Me.chkTodos.Location = New System.Drawing.Point(7, 6)
            Me.chkTodos.Name = "chkTodos"
            Me.chkTodos.Size = New System.Drawing.Size(15, 14)
            Me.chkTodos.TabIndex = 6
            Me.chkTodos.UseVisualStyleBackColor = True
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToOrderColumns = True
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_chk, Me.col_id, Me.col_del_esp_id, Me.Column1, Me.col_del_esp})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(0, 0)
            Me.dgwGrilla.MultiSelect = False
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.RowHeadersVisible = False
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwGrilla.RowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(656, 253)
            Me.dgwGrilla.TabIndex = 4
            '
            'col_chk
            '
            Me.col_chk.HeaderText = ""
            Me.col_chk.Name = "col_chk"
            Me.col_chk.Width = 25
            '
            'col_id
            '
            Me.col_id.DataPropertyName = "Codigo"
            Me.col_id.HeaderText = "Codigo"
            Me.col_id.Name = "col_id"
            Me.col_id.ReadOnly = True
            Me.col_id.Visible = False
            Me.col_id.Width = 25
            '
            'col_del_esp_id
            '
            Me.col_del_esp_id.DataPropertyName = "TipoMovimientoNombre"
            Me.col_del_esp_id.HeaderText = "Tipo Movimiento"
            Me.col_del_esp_id.Name = "col_del_esp_id"
            Me.col_del_esp_id.Width = 200
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "IDMovimientoMotivo"
            Me.Column1.HeaderText = "IDMovimientoMotivo"
            Me.Column1.Name = "Column1"
            Me.Column1.Visible = False
            '
            'col_del_esp
            '
            Me.col_del_esp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.col_del_esp.DataPropertyName = "MovimientoMotivoNombre"
            Me.col_del_esp.HeaderText = "Nombre"
            Me.col_del_esp.Name = "col_del_esp"
            Me.col_del_esp.ReadOnly = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnEliminar)
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 428)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(656, 45)
            Me.Panel2.TabIndex = 57
            '
            'btnEliminar
            '
            Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEliminar.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.btnEliminar.Location = New System.Drawing.Point(5, 3)
            Me.btnEliminar.Name = "btnEliminar"
            Me.btnEliminar.Size = New System.Drawing.Size(96, 40)
            Me.btnEliminar.TabIndex = 49
            Me.btnEliminar.Text = "&Eliminar"
            Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEliminar.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(555, 2)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 46
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(457, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 45
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtTipoEgreso)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Controls.Add(Me.txtNombreTabla)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.txtNombreDet)
            Me.GroupBox4.Controls.Add(Me.txtNombre)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.Label26)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(656, 121)
            Me.GroupBox4.TabIndex = 58
            Me.GroupBox4.TabStop = False
            '
            'txtTipoEgreso
            '
            Me.txtTipoEgreso._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtTipoEgreso._BloquearPaste = False
            Me.txtTipoEgreso._SeleccionarTodo = False
            Me.txtTipoEgreso.Location = New System.Drawing.Point(116, 12)
            Me.txtTipoEgreso.Name = "txtTipoEgreso"
            Me.txtTipoEgreso.ReadOnly = True
            Me.txtTipoEgreso.Size = New System.Drawing.Size(528, 20)
            Me.txtTipoEgreso.TabIndex = 54
            Me.txtTipoEgreso.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtTipoEgreso.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 15)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(82, 13)
            Me.Label3.TabIndex = 53
            Me.Label3.Text = "Tipo de Egreso:"
            '
            'txtNombreTabla
            '
            Me.txtNombreTabla._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNombreTabla._BloquearPaste = False
            Me.txtNombreTabla._SeleccionarTodo = False
            Me.txtNombreTabla.Location = New System.Drawing.Point(116, 39)
            Me.txtNombreTabla.Name = "txtNombreTabla"
            Me.txtNombreTabla.ReadOnly = True
            Me.txtNombreTabla.Size = New System.Drawing.Size(528, 20)
            Me.txtNombreTabla.TabIndex = 52
            Me.txtNombreTabla.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombreTabla.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 42)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 13)
            Me.Label2.TabIndex = 51
            Me.Label2.Text = "Nombre de Tabla:"
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.Panel1)
            Me.Panel3.Controls.Add(Me.GroupBox4_)
            Me.Panel3.Controls.Add(Me.GroupBox4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(656, 428)
            Me.Panel3.TabIndex = 59
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.chkTodos)
            Me.Panel1.Controls.Add(Me.dgwGrilla)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 175)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(656, 253)
            Me.Panel1.TabIndex = 90
            '
            'frmMantDetPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(656, 473)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmMantDetPopup"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Reporte - Cuadro 13 - Detalle"
            Me.GroupBox4_.ResumeLayout(False)
            Me.GroupBox4_.PerformLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents GroupBox4_ As System.Windows.Forms.GroupBox
        Friend WithEvents dgwGrilla As System.Windows.Forms.DataGridView
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
        Friend WithEvents txtNombreDet As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents btnAddPenal As System.Windows.Forms.Button
        Friend WithEvents btnEliminar As System.Windows.Forms.Button
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents col_chk As DataGridViewCheckBoxColumn
        Friend WithEvents col_id As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp_id As DataGridViewTextBoxColumn
        Friend WithEvents Column1 As DataGridViewTextBoxColumn
        Friend WithEvents col_del_esp As DataGridViewTextBoxColumn
        Friend WithEvents lblGrillaCount As Label
        Friend WithEvents btnExportar As Button
        Friend WithEvents txtTipoEgreso As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents txtNombreTabla As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As Label
    End Class
End Namespace

