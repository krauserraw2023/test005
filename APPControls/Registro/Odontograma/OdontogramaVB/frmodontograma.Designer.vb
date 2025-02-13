<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmodontograma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmodontograma))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbnuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbmodificar = New System.Windows.Forms.ToolStripButton()
        Me.tsbborrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbsgrabar = New System.Windows.Forms.ToolStripButton()
        Me.tsbeliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbsimprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tstxtinterno = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txttxtcodinterno = New System.Windows.Forms.ToolStripTextBox()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumodonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboestado = New System.Windows.Forms.ComboBox()
        Me.cbohallazgos = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslusucrea = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslfeccrea = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslusumodi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelOdonto = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtnumcobs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnumcespe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtespecificaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tslfecmodi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbnuevo, Me.tsbmodificar, Me.tsbborrar, Me.ToolStripSeparator3, Me.tbsgrabar, Me.tsbeliminar, Me.ToolStripSeparator1, Me.tbsimprimir, Me.ToolStripSeparator2, Me.tsbsalir, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.tstxtinterno, Me.ToolStripLabel2, Me.txttxtcodinterno})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1116, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbnuevo
        '
        Me.tsbnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbnuevo.Image = CType(resources.GetObject("tsbnuevo.Image"), System.Drawing.Image)
        Me.tsbnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbnuevo.Name = "tsbnuevo"
        Me.tsbnuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsbnuevo.Text = "Nuevo"
        '
        'tsbmodificar
        '
        Me.tsbmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbmodificar.Image = CType(resources.GetObject("tsbmodificar.Image"), System.Drawing.Image)
        Me.tsbmodificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbmodificar.Name = "tsbmodificar"
        Me.tsbmodificar.Size = New System.Drawing.Size(23, 22)
        Me.tsbmodificar.Text = "ToolStripButton1"
        Me.tsbmodificar.ToolTipText = "Modificar"
        '
        'tsbborrar
        '
        Me.tsbborrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbborrar.Image = CType(resources.GetObject("tsbborrar.Image"), System.Drawing.Image)
        Me.tsbborrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbborrar.Name = "tsbborrar"
        Me.tsbborrar.Size = New System.Drawing.Size(23, 22)
        Me.tsbborrar.Text = "ToolStripButton1"
        Me.tsbborrar.ToolTipText = "Quitar hallazgos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tbsgrabar
        '
        Me.tbsgrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbsgrabar.Image = CType(resources.GetObject("tbsgrabar.Image"), System.Drawing.Image)
        Me.tbsgrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbsgrabar.Name = "tbsgrabar"
        Me.tbsgrabar.Size = New System.Drawing.Size(23, 22)
        Me.tbsgrabar.Text = "ToolStripButton2"
        Me.tbsgrabar.ToolTipText = "Grabar"
        '
        'tsbeliminar
        '
        Me.tsbeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbeliminar.Image = CType(resources.GetObject("tsbeliminar.Image"), System.Drawing.Image)
        Me.tsbeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbeliminar.Name = "tsbeliminar"
        Me.tsbeliminar.Size = New System.Drawing.Size(23, 22)
        Me.tsbeliminar.Text = "Eliminar"
        Me.tsbeliminar.ToolTipText = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbsimprimir
        '
        Me.tbsimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbsimprimir.Image = CType(resources.GetObject("tbsimprimir.Image"), System.Drawing.Image)
        Me.tbsimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbsimprimir.Name = "tbsimprimir"
        Me.tbsimprimir.Size = New System.Drawing.Size(23, 22)
        Me.tbsimprimir.Text = "ToolStripButton1"
        Me.tbsimprimir.ToolTipText = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbsalir
        '
        Me.tsbsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbsalir.Image = CType(resources.GetObject("tsbsalir.Image"), System.Drawing.Image)
        Me.tsbsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbsalir.Name = "tsbsalir"
        Me.tsbsalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbsalir.Text = "Salir"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "Interno:"
        '
        'tstxtinterno
        '
        Me.tstxtinterno.AutoSize = False
        Me.tstxtinterno.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tstxtinterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstxtinterno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstxtinterno.Name = "tstxtinterno"
        Me.tstxtinterno.ReadOnly = True
        Me.tstxtinterno.Size = New System.Drawing.Size(250, 23)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel2.Text = "Código:"
        '
        'txttxtcodinterno
        '
        Me.txttxtcodinterno.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txttxtcodinterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttxtcodinterno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttxtcodinterno.Name = "txttxtcodinterno"
        Me.txttxtcodinterno.ReadOnly = True
        Me.txttxtcodinterno.Size = New System.Drawing.Size(100, 25)
        '
        'imagenes
        '
        Me.imagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagenes.ImageSize = New System.Drawing.Size(16, 16)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.btnfind)
        Me.Panel1.Controls.Add(Me.dtpfecha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtnumodonto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboestado)
        Me.Panel1.Controls.Add(Me.cbohallazgos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 56)
        Me.Panel1.TabIndex = 1
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(223, 1)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(27, 27)
        Me.btnfind.TabIndex = 74
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(522, 4)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(99, 20)
        Me.dtpfecha.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(480, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Fecha:"
        '
        'txtnumodonto
        '
        Me.txtnumodonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtnumodonto.Location = New System.Drawing.Point(122, 4)
        Me.txtnumodonto.Name = "txtnumodonto"
        Me.txtnumodonto.ReadOnly = True
        Me.txtnumodonto.Size = New System.Drawing.Size(100, 20)
        Me.txtnumodonto.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "ODONTOGRAMA N° :"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(627, 28)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(108, 23)
        Me.btnadd.TabIndex = 68
        Me.btnadd.Text = "Agregar/Quitar"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(709, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Estado"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Hallazgos"
        '
        'cboestado
        '
        Me.cboestado.FormattingEnabled = True
        Me.cboestado.Location = New System.Drawing.Point(755, 3)
        Me.cboestado.Name = "cboestado"
        Me.cboestado.Size = New System.Drawing.Size(101, 21)
        Me.cboestado.TabIndex = 65
        Me.cboestado.Visible = False
        '
        'cbohallazgos
        '
        Me.cbohallazgos.BackColor = System.Drawing.SystemColors.Window
        Me.cbohallazgos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohallazgos.FormattingEnabled = True
        Me.cbohallazgos.Location = New System.Drawing.Point(67, 30)
        Me.cbohallazgos.Name = "cbohallazgos"
        Me.cbohallazgos.Size = New System.Drawing.Size(554, 21)
        Me.cbohallazgos.TabIndex = 64
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslusucrea, Me.tslfeccrea, Me.tslusumodi, Me.tslfecmodi})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 679)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1116, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslusucrea
        '
        Me.tslusucrea.Name = "tslusucrea"
        Me.tslusucrea.Size = New System.Drawing.Size(0, 17)
        '
        'tslfeccrea
        '
        Me.tslfeccrea.Name = "tslfeccrea"
        Me.tslfeccrea.Size = New System.Drawing.Size(0, 17)
        '
        'tslusumodi
        '
        Me.tslusumodi.Name = "tslusumodi"
        Me.tslusumodi.Size = New System.Drawing.Size(0, 17)
        '
        'PanelOdonto
        '
        Me.PanelOdonto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelOdonto.Location = New System.Drawing.Point(0, 81)
        Me.PanelOdonto.Name = "PanelOdonto"
        Me.PanelOdonto.Size = New System.Drawing.Size(1116, 598)
        Me.PanelOdonto.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtnumcobs)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtnumcespe)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtobservaciones)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtespecificaciones)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(763, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(353, 598)
        Me.Panel2.TabIndex = 4
        '
        'txtnumcobs
        '
        Me.txtnumcobs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtnumcobs.Location = New System.Drawing.Point(94, 448)
        Me.txtnumcobs.Name = "txtnumcobs"
        Me.txtnumcobs.ReadOnly = True
        Me.txtnumcobs.Size = New System.Drawing.Size(43, 20)
        Me.txtnumcobs.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "N° Caracteres:"
        '
        'txtnumcespe
        '
        Me.txtnumcespe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtnumcespe.Location = New System.Drawing.Point(94, 206)
        Me.txtnumcespe.Name = "txtnumcespe"
        Me.txtnumcespe.ReadOnly = True
        Me.txtnumcespe.Size = New System.Drawing.Size(43, 20)
        Me.txtnumcespe.TabIndex = 75
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "N° Caracteres:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(12, 271)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(329, 171)
        Me.txtobservaciones.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Observaciones"
        '
        'txtespecificaciones
        '
        Me.txtespecificaciones.Location = New System.Drawing.Point(12, 28)
        Me.txtespecificaciones.Multiline = True
        Me.txtespecificaciones.Name = "txtespecificaciones"
        Me.txtespecificaciones.Size = New System.Drawing.Size(329, 174)
        Me.txtespecificaciones.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Especificaciones:"
        '
        'tslfecmodi
        '
        Me.tslfecmodi.Name = "tslfecmodi"
        Me.tslfecmodi.Size = New System.Drawing.Size(0, 17)
        '
        'frmodontograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 701)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelOdonto)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1087, 726)
        Me.Name = "frmodontograma"
        Me.Text = "Odontograma"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbnuevo As ToolStripButton
    Friend WithEvents tsbmodificar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tbsgrabar As ToolStripButton
    Friend WithEvents tsbeliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbsimprimir As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tstxtinterno As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txttxtcodinterno As ToolStripTextBox
    Friend WithEvents imagenes As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslusucrea As ToolStripStatusLabel
    Friend WithEvents tslfeccrea As ToolStripStatusLabel
    Friend WithEvents tslusumodi As ToolStripStatusLabel
    Friend WithEvents btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboestado As ComboBox
    Friend WithEvents cbohallazgos As ComboBox
    Friend WithEvents txtnumodonto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelOdonto As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtobservaciones As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtespecificaciones As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tsbborrar As ToolStripButton
    Friend WithEvents btnfind As Button
    Friend WithEvents txtnumcobs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnumcespe As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tslfecmodi As ToolStripStatusLabel
End Class
