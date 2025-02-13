Namespace Visita.Autorizacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReportePopup
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
            Me.pnlSeleccionarInterno = New System.Windows.Forms.Panel()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.grbBuscarInterno = New System.Windows.Forms.GroupBox()
            Me.rdbInternoTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbSeleccionarInterno = New Legolas.APPUIComponents.myRadioButton()
            Me.grbEstadoAut = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbInactivo = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbActivo = New Legolas.APPUIComponents.myRadioButton()
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
            Me.pnlSeleccionarInterno.SuspendLayout()
            Me.grbBuscarInterno.SuspendLayout()
            Me.grbEstadoAut.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(604, 313)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 268)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(604, 45)
            Me.Panel1.TabIndex = 102
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(402, 0)
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
            Me.GroupBox1.Size = New System.Drawing.Size(351, 268)
            Me.GroupBox1.TabIndex = 103
            Me.GroupBox1.TabStop = False
            '
            'pnlReporte
            '
            Me.pnlReporte.Controls.Add(Me.pnlSeleccionarInterno)
            Me.pnlReporte.Controls.Add(Me.grbBuscarInterno)
            Me.pnlReporte.Controls.Add(Me.grbEstadoAut)
            Me.pnlReporte.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlReporte.Location = New System.Drawing.Point(3, 16)
            Me.pnlReporte.Name = "pnlReporte"
            Me.pnlReporte.Size = New System.Drawing.Size(345, 249)
            Me.pnlReporte.TabIndex = 10
            '
            'pnlSeleccionarInterno
            '
            Me.pnlSeleccionarInterno.Controls.Add(Me.lblTitulo)
            Me.pnlSeleccionarInterno.Controls.Add(Me.UscLabelBusqueda1)
            Me.pnlSeleccionarInterno.Location = New System.Drawing.Point(19, 71)
            Me.pnlSeleccionarInterno.Name = "pnlSeleccionarInterno"
            Me.pnlSeleccionarInterno.Size = New System.Drawing.Size(304, 56)
            Me.pnlSeleccionarInterno.TabIndex = 10
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Location = New System.Drawing.Point(13, 9)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(102, 13)
            Me.lblTitulo.TabIndex = 4
            Me.lblTitulo.Text = "Seleccione Interno :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(16, 26)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(285, 21)
            Me.UscLabelBusqueda1.TabIndex = 5
            '
            'grbBuscarInterno
            '
            Me.grbBuscarInterno.Controls.Add(Me.rdbInternoTodos)
            Me.grbBuscarInterno.Controls.Add(Me.rdbSeleccionarInterno)
            Me.grbBuscarInterno.Location = New System.Drawing.Point(19, 9)
            Me.grbBuscarInterno.Name = "grbBuscarInterno"
            Me.grbBuscarInterno.Size = New System.Drawing.Size(304, 56)
            Me.grbBuscarInterno.TabIndex = 9
            Me.grbBuscarInterno.TabStop = False
            Me.grbBuscarInterno.Text = "Interno"
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
            'grbEstadoAut
            '
            Me.grbEstadoAut.Controls.Add(Me.rdbTodos)
            Me.grbEstadoAut.Controls.Add(Me.rdbInactivo)
            Me.grbEstadoAut.Controls.Add(Me.rdbActivo)
            Me.grbEstadoAut.Enabled = False
            Me.grbEstadoAut.Location = New System.Drawing.Point(19, 142)
            Me.grbEstadoAut.Name = "grbEstadoAut"
            Me.grbEstadoAut.Size = New System.Drawing.Size(304, 88)
            Me.grbEstadoAut.TabIndex = 6
            Me.grbEstadoAut.TabStop = False
            Me.grbEstadoAut.Text = "Tipo"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Location = New System.Drawing.Point(21, 65)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 2
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbInactivo
            '
            Me.rdbInactivo.AutoSize = True
            Me.rdbInactivo.Location = New System.Drawing.Point(21, 42)
            Me.rdbInactivo.Name = "rdbInactivo"
            Me.rdbInactivo.Size = New System.Drawing.Size(64, 17)
            Me.rdbInactivo.TabIndex = 1
            Me.rdbInactivo.Text = "Anulado"
            Me.rdbInactivo.UseVisualStyleBackColor = True
            '
            'rdbActivo
            '
            Me.rdbActivo.AutoSize = True
            Me.rdbActivo.Checked = True
            Me.rdbActivo.Location = New System.Drawing.Point(21, 19)
            Me.rdbActivo.Name = "rdbActivo"
            Me.rdbActivo.Size = New System.Drawing.Size(75, 17)
            Me.rdbActivo.TabIndex = 0
            Me.rdbActivo.TabStop = True
            Me.rdbActivo.Text = "Autorizado"
            Me.rdbActivo.UseVisualStyleBackColor = True
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.dgwGrilla)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(253, 268)
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
            Me.dgwGrilla.Size = New System.Drawing.Size(247, 226)
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
            'frmReportePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(604, 313)
            Me.Name = "frmReportePopup"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.pnlReporte.ResumeLayout(False)
            Me.pnlSeleccionarInterno.ResumeLayout(False)
            Me.pnlSeleccionarInterno.PerformLayout()
            Me.grbBuscarInterno.ResumeLayout(False)
            Me.grbBuscarInterno.PerformLayout()
            Me.grbEstadoAut.ResumeLayout(False)
            Me.grbEstadoAut.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents grbEstadoAut As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbInactivo As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbActivo As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents grbBuscarInterno As System.Windows.Forms.GroupBox
        Friend WithEvents rdbSeleccionarInterno As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbInternoTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents pnlReporte As System.Windows.Forms.Panel
        Friend WithEvents pnlSeleccionarInterno As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents col_id As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_reg_nom As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace