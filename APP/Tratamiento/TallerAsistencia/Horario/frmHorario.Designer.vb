Namespace Tratamiento.TallerAsistencia.Horario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmRegularizar
        Inherits Legolas.APPUIComponents.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.pnlHoraInicio = New System.Windows.Forms.Panel()
            Me.nudInicioMinuto = New System.Windows.Forms.NumericUpDown()
            Me.nudInicioHora = New System.Windows.Forms.NumericUpDown()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.pnlHoraFin = New System.Windows.Forms.Panel()
            Me.nudFinMinuto = New System.Windows.Forms.NumericUpDown()
            Me.nudFinHora = New System.Windows.Forms.NumericUpDown()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.cbbDia = New Legolas.APPUIComponents.uscComboDiaSemana()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel15 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnQuitar = New System.Windows.Forms.Button()
            Me.btnAgregarGH = New System.Windows.Forms.Button()
            Me.dgwHorario = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.nudGH = New System.Windows.Forms.NumericUpDown()
            Me.pnlPie.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.pnlDetalle.SuspendLayout()
            Me.gbrBuscarNumDoc.SuspendLayout()
            Me.pnlHoraInicio.SuspendLayout()
            CType(Me.nudInicioMinuto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudInicioHora, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHoraFin.SuspendLayout()
            CType(Me.nudFinMinuto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudFinHora, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel15.SuspendLayout()
            CType(Me.dgwHorario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudGH, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 325)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(442, 50)
            Me.pnlPie.TabIndex = 1
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(228, 0)
            Me.pnlOK.Name = "pnlOK"
            Me.pnlOK.Size = New System.Drawing.Size(108, 50)
            Me.pnlOK.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(336, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(106, 50)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(0, 4)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(102, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Timer1
            '
            Me.Timer1.Interval = 1000
            '
            'pnlDetalle
            '
            Me.pnlDetalle.BackColor = System.Drawing.Color.Transparent
            Me.pnlDetalle.Controls.Add(Me.dgwHorario)
            Me.pnlDetalle.Controls.Add(Me.Panel15)
            Me.pnlDetalle.Controls.Add(Me.gbrBuscarNumDoc)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(442, 325)
            Me.pnlDetalle.TabIndex = 0
            '
            'Label41
            '
            Me.Label41.AutoSize = True
            Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label41.Location = New System.Drawing.Point(99, 16)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(207, 16)
            Me.Label41.TabIndex = 0
            Me.Label41.Text = "MANTENIMIENTO HORARIO"
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.nudGH)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label13)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label41)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label8)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label2)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlHoraInicio)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlHoraFin)
            Me.gbrBuscarNumDoc.Controls.Add(Me.cbbDia)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label1)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 0)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(442, 139)
            Me.gbrBuscarNumDoc.TabIndex = 0
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'pnlHoraInicio
            '
            Me.pnlHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHoraInicio.Controls.Add(Me.nudInicioMinuto)
            Me.pnlHoraInicio.Controls.Add(Me.nudInicioHora)
            Me.pnlHoraInicio.Controls.Add(Me.Label5)
            Me.pnlHoraInicio.Location = New System.Drawing.Point(99, 74)
            Me.pnlHoraInicio.Name = "pnlHoraInicio"
            Me.pnlHoraInicio.Size = New System.Drawing.Size(110, 28)
            Me.pnlHoraInicio.TabIndex = 4
            '
            'nudInicioMinuto
            '
            Me.nudInicioMinuto.Location = New System.Drawing.Point(61, 3)
            Me.nudInicioMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
            Me.nudInicioMinuto.Name = "nudInicioMinuto"
            Me.nudInicioMinuto.Size = New System.Drawing.Size(40, 20)
            Me.nudInicioMinuto.TabIndex = 1
            '
            'nudInicioHora
            '
            Me.nudInicioHora.Location = New System.Drawing.Point(7, 3)
            Me.nudInicioHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudInicioHora.Name = "nudInicioHora"
            Me.nudInicioHora.Size = New System.Drawing.Size(40, 20)
            Me.nudInicioHora.TabIndex = 0
            Me.nudInicioHora.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'Label13
            '
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label13.Location = New System.Drawing.Point(21, 75)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(78, 24)
            Me.Label13.TabIndex = 3
            Me.Label13.Text = "Hora Inicio :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(47, 23)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(11, 13)
            Me.Label5.TabIndex = 2
            Me.Label5.Text = ":"
            '
            'pnlHoraFin
            '
            Me.pnlHoraFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHoraFin.Controls.Add(Me.nudFinMinuto)
            Me.pnlHoraFin.Controls.Add(Me.nudFinHora)
            Me.pnlHoraFin.Controls.Add(Me.Label9)
            Me.pnlHoraFin.Location = New System.Drawing.Point(99, 106)
            Me.pnlHoraFin.Name = "pnlHoraFin"
            Me.pnlHoraFin.Size = New System.Drawing.Size(110, 28)
            Me.pnlHoraFin.TabIndex = 6
            '
            'nudFinMinuto
            '
            Me.nudFinMinuto.Location = New System.Drawing.Point(61, 3)
            Me.nudFinMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
            Me.nudFinMinuto.Name = "nudFinMinuto"
            Me.nudFinMinuto.Size = New System.Drawing.Size(40, 20)
            Me.nudFinMinuto.TabIndex = 1
            '
            'nudFinHora
            '
            Me.nudFinHora.Location = New System.Drawing.Point(8, 3)
            Me.nudFinHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudFinHora.Name = "nudFinHora"
            Me.nudFinHora.Size = New System.Drawing.Size(40, 20)
            Me.nudFinHora.TabIndex = 0
            Me.nudFinHora.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'Label8
            '
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label8.Location = New System.Drawing.Point(21, 108)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(65, 24)
            Me.Label8.TabIndex = 5
            Me.Label8.Text = "Hora Fin :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(47, 23)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(11, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = ":"
            '
            'cbbDia
            '
            Me.cbbDia.Location = New System.Drawing.Point(99, 46)
            Me.cbbDia.MesAbreviatura = False
            Me.cbbDia.Name = "cbbDia"
            Me.cbbDia.Size = New System.Drawing.Size(110, 21)
            Me.cbbDia.TabIndex = 2
            Me.cbbDia.Value = 0
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(21, 46)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 21)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Dia :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(235, 108)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(46, 21)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "GH :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel15
            '
            Me.Panel15.Controls.Add(Me.Label3)
            Me.Panel15.Controls.Add(Me.btnQuitar)
            Me.Panel15.Controls.Add(Me.btnAgregarGH)
            Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel15.Location = New System.Drawing.Point(0, 139)
            Me.Panel15.Name = "Panel15"
            Me.Panel15.Size = New System.Drawing.Size(442, 37)
            Me.Panel15.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(203, 8)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(151, 21)
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Agregar Grupo Horario :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnQuitar
            '
            Me.btnQuitar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnQuitar.ForeColor = System.Drawing.Color.Black
            Me.btnQuitar.Location = New System.Drawing.Point(401, 1)
            Me.btnQuitar.Name = "btnQuitar"
            Me.btnQuitar.Size = New System.Drawing.Size(35, 35)
            Me.btnQuitar.TabIndex = 2
            Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnQuitar.UseVisualStyleBackColor = True
            '
            'btnAgregarGH
            '
            Me.btnAgregarGH.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.add_32
            Me.btnAgregarGH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnAgregarGH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAgregarGH.ForeColor = System.Drawing.Color.Black
            Me.btnAgregarGH.Location = New System.Drawing.Point(360, 1)
            Me.btnAgregarGH.Name = "btnAgregarGH"
            Me.btnAgregarGH.Size = New System.Drawing.Size(35, 35)
            Me.btnAgregarGH.TabIndex = 1
            Me.btnAgregarGH.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnAgregarGH.UseVisualStyleBackColor = True
            '
            'dgwHorario
            '
            Me.dgwHorario.AllowUserToAddRows = False
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.dgwHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgwHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Column1})
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgwHorario.DefaultCellStyle = DataGridViewCellStyle10
            Me.dgwHorario.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgwHorario.Location = New System.Drawing.Point(0, 176)
            Me.dgwHorario.Name = "dgwHorario"
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgwHorario.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            Me.dgwHorario.RowHeadersVisible = False
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
            Me.dgwHorario.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.dgwHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgwHorario.Size = New System.Drawing.Size(442, 149)
            Me.dgwHorario.TabIndex = 3
            '
            'DataGridViewTextBoxColumn1
            '
            Me.DataGridViewTextBoxColumn1.HeaderText = "Nº"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.Width = 35
            '
            'DataGridViewTextBoxColumn2
            '
            Me.DataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
            Me.DataGridViewTextBoxColumn2.HeaderText = "idDia"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.Visible = False
            '
            'DataGridViewTextBoxColumn3
            '
            Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
            Me.DataGridViewTextBoxColumn3.HeaderText = "Dia"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.Width = 150
            '
            'DataGridViewTextBoxColumn4
            '
            Me.DataGridViewTextBoxColumn4.DataPropertyName = "Descripcion"
            Me.DataGridViewTextBoxColumn4.HeaderText = "GH"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.Width = 30
            '
            'DataGridViewTextBoxColumn5
            '
            Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombres"
            Me.DataGridViewTextBoxColumn5.HeaderText = "Hora Entrada"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            '
            'Column1
            '
            Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            Me.Column1.HeaderText = "Hora Salida"
            Me.Column1.Name = "Column1"
            Me.Column1.ToolTipText = "Hora Salida"
            '
            'nudGH
            '
            Me.nudGH.Location = New System.Drawing.Point(270, 110)
            Me.nudGH.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nudGH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudGH.Name = "nudGH"
            Me.nudGH.Size = New System.Drawing.Size(40, 20)
            Me.nudGH.TabIndex = 7
            Me.nudGH.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'frmHorario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(442, 375)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmHorario"
            Me.ShowInTaskbar = False
            Me.Text = "Horario"
            Me.pnlPie.ResumeLayout(False)
            Me.pnlOK.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.pnlDetalle.ResumeLayout(False)
            Me.gbrBuscarNumDoc.ResumeLayout(False)
            Me.gbrBuscarNumDoc.PerformLayout()
            Me.pnlHoraInicio.ResumeLayout(False)
            Me.pnlHoraInicio.PerformLayout()
            CType(Me.nudInicioMinuto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudInicioHora, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHoraFin.ResumeLayout(False)
            Me.pnlHoraFin.PerformLayout()
            CType(Me.nudFinMinuto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudFinHora, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel15.ResumeLayout(False)
            CType(Me.dgwHorario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudGH, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Friend WithEvents Label41 As System.Windows.Forms.Label
        Friend WithEvents dgwHorario As System.Windows.Forms.DataGridView
        Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Panel15 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents btnQuitar As System.Windows.Forms.Button
        Friend WithEvents btnAgregarGH As System.Windows.Forms.Button
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents pnlHoraInicio As System.Windows.Forms.Panel
        Friend WithEvents nudInicioMinuto As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudInicioHora As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlHoraFin As System.Windows.Forms.Panel
        Friend WithEvents nudFinMinuto As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFinHora As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents cbbDia As Legolas.APPUIComponents.uscComboDiaSemana
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents nudGH As System.Windows.Forms.NumericUpDown

    End Class
End Namespace

