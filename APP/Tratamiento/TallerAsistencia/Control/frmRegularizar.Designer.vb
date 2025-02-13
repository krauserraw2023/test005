Namespace Tratamiento.TallerAsistencia
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
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.pnlDetalle = New System.Windows.Forms.Panel()
            Me.gbrBuscarNumDoc = New System.Windows.Forms.GroupBox()
            Me.cbbHoraEntradaSalida = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFecha = New System.Windows.Forms.TextBox()
            Me.txtObservacion = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label41 = New System.Windows.Forms.Label()
            Me.lblHoraEntradaSalida = New System.Windows.Forms.Label()
            Me.pnlHoraInicio = New System.Windows.Forms.Panel()
            Me.nudInicioMinuto = New System.Windows.Forms.NumericUpDown()
            Me.nudInicioHora = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.pnlHoraFin = New System.Windows.Forms.Panel()
            Me.nudFinMinuto = New System.Windows.Forms.NumericUpDown()
            Me.nudFinHora = New System.Windows.Forms.NumericUpDown()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.txtJustificacion = New System.Windows.Forms.TextBox()
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
            Me.SuspendLayout()
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlSalir)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 230)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(422, 50)
            Me.pnlPie.TabIndex = 1
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(208, 0)
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
            Me.pnlSalir.Location = New System.Drawing.Point(316, 0)
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
            Me.pnlDetalle.Controls.Add(Me.gbrBuscarNumDoc)
            Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDetalle.Location = New System.Drawing.Point(0, 0)
            Me.pnlDetalle.Name = "pnlDetalle"
            Me.pnlDetalle.Size = New System.Drawing.Size(422, 230)
            Me.pnlDetalle.TabIndex = 0
            '
            'gbrBuscarNumDoc
            '
            Me.gbrBuscarNumDoc.BackColor = System.Drawing.Color.Transparent
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtJustificacion)
            Me.gbrBuscarNumDoc.Controls.Add(Me.cbbHoraEntradaSalida)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label2)
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtFecha)
            Me.gbrBuscarNumDoc.Controls.Add(Me.txtObservacion)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label3)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label41)
            Me.gbrBuscarNumDoc.Controls.Add(Me.lblHoraEntradaSalida)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlHoraInicio)
            Me.gbrBuscarNumDoc.Controls.Add(Me.pnlHoraFin)
            Me.gbrBuscarNumDoc.Controls.Add(Me.Label1)
            Me.gbrBuscarNumDoc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gbrBuscarNumDoc.Location = New System.Drawing.Point(0, 0)
            Me.gbrBuscarNumDoc.Name = "gbrBuscarNumDoc"
            Me.gbrBuscarNumDoc.Size = New System.Drawing.Size(422, 230)
            Me.gbrBuscarNumDoc.TabIndex = 0
            Me.gbrBuscarNumDoc.TabStop = False
            '
            'cbbHoraEntradaSalida
            '
            Me.cbbHoraEntradaSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbHoraEntradaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbHoraEntradaSalida.FormattingEnabled = True
            Me.cbbHoraEntradaSalida.Location = New System.Drawing.Point(9, 100)
            Me.cbbHoraEntradaSalida.Name = "cbbHoraEntradaSalida"
            Me.cbbHoraEntradaSalida.Size = New System.Drawing.Size(107, 24)
            Me.cbbHoraEntradaSalida.TabIndex = 5
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            Me.Label2.Location = New System.Drawing.Point(9, 70)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(87, 16)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "Justificacion :"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtFecha
            '
            Me.txtFecha.Location = New System.Drawing.Point(122, 41)
            Me.txtFecha.Name = "txtFecha"
            Me.txtFecha.ReadOnly = True
            Me.txtFecha.Size = New System.Drawing.Size(291, 20)
            Me.txtFecha.TabIndex = 2
            '
            'txtObservacion
            '
            Me.txtObservacion.Location = New System.Drawing.Point(122, 171)
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(290, 57)
            Me.txtObservacion.TabIndex = 10
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(9, 173)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(91, 21)
            Me.Label3.TabIndex = 9
            Me.Label3.Text = "Observación :"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label41
            '
            Me.Label41.AutoSize = True
            Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label41.Location = New System.Drawing.Point(119, 12)
            Me.Label41.Name = "Label41"
            Me.Label41.Size = New System.Drawing.Size(204, 16)
            Me.Label41.TabIndex = 0
            Me.Label41.Text = "Regularizar Entrada / Salida"
            '
            'lblHoraEntradaSalida
            '
            Me.lblHoraEntradaSalida.AutoSize = True
            Me.lblHoraEntradaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHoraEntradaSalida.Location = New System.Drawing.Point(9, 139)
            Me.lblHoraEntradaSalida.Name = "lblHoraEntradaSalida"
            Me.lblHoraEntradaSalida.Size = New System.Drawing.Size(69, 16)
            Me.lblHoraEntradaSalida.TabIndex = 7
            Me.lblHoraEntradaSalida.Text = "Hora E/S :"
            '
            'pnlHoraInicio
            '
            Me.pnlHoraInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlHoraInicio.Controls.Add(Me.nudInicioMinuto)
            Me.pnlHoraInicio.Controls.Add(Me.nudInicioHora)
            Me.pnlHoraInicio.Controls.Add(Me.Label5)
            Me.pnlHoraInicio.Location = New System.Drawing.Point(122, 97)
            Me.pnlHoraInicio.Name = "pnlHoraInicio"
            Me.pnlHoraInicio.Size = New System.Drawing.Size(110, 28)
            Me.pnlHoraInicio.TabIndex = 6
            '
            'nudInicioMinuto
            '
            Me.nudInicioMinuto.Location = New System.Drawing.Point(61, 3)
            Me.nudInicioMinuto.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
            Me.nudInicioMinuto.Name = "nudInicioMinuto"
            Me.nudInicioMinuto.ReadOnly = True
            Me.nudInicioMinuto.Size = New System.Drawing.Size(40, 20)
            Me.nudInicioMinuto.TabIndex = 1
            '
            'nudInicioHora
            '
            Me.nudInicioHora.Location = New System.Drawing.Point(7, 3)
            Me.nudInicioHora.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
            Me.nudInicioHora.Name = "nudInicioHora"
            Me.nudInicioHora.ReadOnly = True
            Me.nudInicioHora.Size = New System.Drawing.Size(40, 20)
            Me.nudInicioHora.TabIndex = 0
            Me.nudInicioHora.Value = New Decimal(New Integer() {8, 0, 0, 0})
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
            Me.pnlHoraFin.Location = New System.Drawing.Point(122, 134)
            Me.pnlHoraFin.Name = "pnlHoraFin"
            Me.pnlHoraFin.Size = New System.Drawing.Size(110, 28)
            Me.pnlHoraFin.TabIndex = 8
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
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(9, 40)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(54, 21)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Fecha :"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtJustificacion
            '
            Me.txtJustificacion.Location = New System.Drawing.Point(122, 70)
            Me.txtJustificacion.Name = "txtJustificacion"
            Me.txtJustificacion.ReadOnly = True
            Me.txtJustificacion.Size = New System.Drawing.Size(290, 20)
            Me.txtJustificacion.TabIndex = 4
            '
            'frmRegularizar
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(422, 280)
            Me.Controls.Add(Me.pnlDetalle)
            Me.Controls.Add(Me.pnlPie)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmRegularizar"
            Me.ShowInTaskbar = False
            Me.Text = "Regularizar Papeleta"
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
        Friend WithEvents gbrBuscarNumDoc As System.Windows.Forms.GroupBox
        Friend WithEvents lblHoraEntradaSalida As System.Windows.Forms.Label
        Friend WithEvents pnlHoraInicio As System.Windows.Forms.Panel
        Friend WithEvents nudInicioMinuto As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudInicioHora As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents pnlHoraFin As System.Windows.Forms.Panel
        Friend WithEvents nudFinMinuto As System.Windows.Forms.NumericUpDown
        Friend WithEvents nudFinHora As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtFecha As System.Windows.Forms.TextBox
        Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label2 As Label
        Friend WithEvents cbbHoraEntradaSalida As ComboBox
        Friend WithEvents txtJustificacion As TextBox
    End Class
End Namespace

