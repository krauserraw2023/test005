Namespace Visita.Autorizacion


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAutorizacionAddPopup
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
            Me.components = New System.ComponentModel.Container()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.dgwGrilla = New Legolas.APPUIComponents.myDatagridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.col_eli = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.cbbParentesco = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.btnAgregar = New System.Windows.Forms.Button()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpFechaDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtIntApeNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel5.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel4)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(580, 466)
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 10)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(59, 15)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Visitante :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(102, 6)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(358, 21)
            Me.UscLabelBusqueda1.TabIndex = 6
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(11, 36)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(75, 15)
            Me.Label8.TabIndex = 84
            Me.Label8.Text = "Parentesco :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOK)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(380, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(200, 49)
            Me.Panel1.TabIndex = 87
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(102, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 86
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(2, 4)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 85
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 417)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(580, 49)
            Me.Panel2.TabIndex = 0
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.dgwGrilla)
            Me.GroupBox3.Controls.Add(Me.Panel5)
            Me.GroupBox3.Controls.Add(Me.Panel3)
            Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox3.Location = New System.Drawing.Point(0, 102)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(580, 315)
            Me.GroupBox3.TabIndex = 87
            Me.GroupBox3.TabStop = False
            '
            'dgwGrilla
            '
            Me.dgwGrilla.AllowUserToAddRows = False
            Me.dgwGrilla.AllowUserToDeleteRows = False
            Me.dgwGrilla.AllowUserToResizeRows = False
            Me.dgwGrilla.BackgroundColor = System.Drawing.Color.White
            Me.dgwGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgwGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwGrilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.col_eli})
            Me.dgwGrilla.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwGrilla.Location = New System.Drawing.Point(3, 80)
            Me.dgwGrilla.Name = "dgwGrilla"
            Me.dgwGrilla.ReadOnly = True
            Me.dgwGrilla.RowHeadersVisible = False
            Me.dgwGrilla.RowHeadersWidth = 51
            Me.dgwGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwGrilla.Size = New System.Drawing.Size(574, 179)
            Me.dgwGrilla.TabIndex = 86
            Me.dgwGrilla.VisibleCampos = False
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "VisitanteID"
            Me.Column1.HeaderText = "VisitanteID"
            Me.Column1.MinimumWidth = 6
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            Me.Column1.Width = 125
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "VisitanteApeNom"
            Me.Column4.HeaderText = "Visitante"
            Me.Column4.MinimumWidth = 6
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 250
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "ParentescoID"
            Me.Column2.HeaderText = "ParentescoID"
            Me.Column2.MinimumWidth = 6
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Visible = False
            Me.Column2.Width = 125
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Parentesco"
            Me.Column3.HeaderText = "Parentesco"
            Me.Column3.MinimumWidth = 6
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 150
            '
            'col_eli
            '
            Me.col_eli.HeaderText = "Eli."
            Me.col_eli.Image = Global.SIPPOPE.My.Resources.Resources.delete_32
            Me.col_eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
            Me.col_eli.MinimumWidth = 6
            Me.col_eli.Name = "col_eli"
            Me.col_eli.ReadOnly = True
            Me.col_eli.Width = 35
            '
            'Panel5
            '
            Me.Panel5.Controls.Add(Me.txtObs)
            Me.Panel5.Controls.Add(Me.Label7)
            Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel5.Location = New System.Drawing.Point(3, 259)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(574, 53)
            Me.Panel5.TabIndex = 87
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtObs.Location = New System.Drawing.Point(95, 0)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(479, 53)
            Me.txtObs.TabIndex = 84
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
            Me.Label7.Location = New System.Drawing.Point(0, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(95, 53)
            Me.Label7.TabIndex = 85
            Me.Label7.Text = "Observacion :"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.cbbParentesco)
            Me.Panel3.Controls.Add(Me.btnAgregar)
            Me.Panel3.Controls.Add(Me.UscLabelBusqueda1)
            Me.Panel3.Controls.Add(Me.Label8)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(574, 64)
            Me.Panel3.TabIndex = 85
            '
            'cbbParentesco
            '
            Me.cbbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbParentesco.FormattingEnabled = True
            Me.cbbParentesco.Location = New System.Drawing.Point(102, 33)
            Me.cbbParentesco.Name = "cbbParentesco"
            Me.cbbParentesco.Size = New System.Drawing.Size(358, 21)
            Me.cbbParentesco.TabIndex = 86
            '
            'btnAgregar
            '
            Me.btnAgregar.Image = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAgregar.Location = New System.Drawing.Point(469, 10)
            Me.btnAgregar.Name = "btnAgregar"
            Me.btnAgregar.Size = New System.Drawing.Size(100, 40)
            Me.btnAgregar.TabIndex = 85
            Me.btnAgregar.Text = "Agregar"
            Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAgregar.UseVisualStyleBackColor = True
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.dtpFechaDoc)
            Me.Panel4.Controls.Add(Me.txtDoc)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Controls.Add(Me.txtIntApeNom)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(580, 102)
            Me.Panel4.TabIndex = 88
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label3.Location = New System.Drawing.Point(12, 32)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(551, 3)
            Me.Label3.TabIndex = 89
            '
            'dtpFechaDoc
            '
            Me.dtpFechaDoc.Location = New System.Drawing.Point(153, 68)
            Me.dtpFechaDoc.Name = "dtpFechaDoc"
            Me.dtpFechaDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDoc.TabIndex = 88
            Me.dtpFechaDoc.Value = "/  /"
            Me.dtpFechaDoc.ValueLong = CType(0, Long)
            '
            'txtDoc
            '
            Me.txtDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDoc._BloquearPaste = False
            Me.txtDoc._SeleccionarTodo = False
            Me.txtDoc.Location = New System.Drawing.Point(153, 42)
            Me.txtDoc.Name = "txtDoc"
            Me.txtDoc.Size = New System.Drawing.Size(386, 20)
            Me.txtDoc.TabIndex = 87
            Me.txtDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(59, 45)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(77, 15)
            Me.Label5.TabIndex = 86
            Me.Label5.Text = "Documento :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(61, 68)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(75, 15)
            Me.Label6.TabIndex = 83
            Me.Label6.Text = "Fecha Doc. :"
            '
            'txtIntApeNom
            '
            Me.txtIntApeNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtIntApeNom._BloquearPaste = False
            Me.txtIntApeNom._SeleccionarTodo = False
            Me.txtIntApeNom.Location = New System.Drawing.Point(64, 6)
            Me.txtIntApeNom.Name = "txtIntApeNom"
            Me.txtIntApeNom.ReadOnly = True
            Me.txtIntApeNom.Size = New System.Drawing.Size(475, 20)
            Me.txtIntApeNom.TabIndex = 82
            Me.txtIntApeNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtIntApeNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 9)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(51, 15)
            Me.Label2.TabIndex = 81
            Me.Label2.Text = "Interno :"
            '
            'frmAutorizacionAddPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(580, 466)
            Me.Name = "frmAutorizacionAddPopup"
            Me.Text = "Agregar Autorizacion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            CType(Me.dgwGrilla, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents dgwGrilla As Legolas.APPUIComponents.myDatagridView
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtIntApeNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btnAgregar As System.Windows.Forms.Button
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents col_eli As System.Windows.Forms.DataGridViewImageColumn
        Friend WithEvents cbbParentesco As Legolas.APPUIComponents.MyComboBox

    End Class
End Namespace