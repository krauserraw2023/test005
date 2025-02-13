Namespace Tratamiento.TallerAsistencia.Reporte

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
            Me.pnlSeleccionarInterno = New System.Windows.Forms.Panel()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.rbtAsistencia = New System.Windows.Forms.RadioButton()
            Me.rbtPlanilla = New System.Windows.Forms.RadioButton()
            Me.grbInterno = New System.Windows.Forms.GroupBox()
            Me.gbTaller = New System.Windows.Forms.GroupBox()
            Me.cbbTalleres = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.grbFechas = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlSeleccionarInterno.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.grbInterno.SuspendLayout()
            Me.gbTaller.SuspendLayout()
            Me.grbFechas.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbFechas)
            Me.gbxFormChildContainer.Controls.Add(Me.gbTaller)
            Me.gbxFormChildContainer.Controls.Add(Me.grbInterno)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(346, 234)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 189)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(346, 45)
            Me.Panel1.TabIndex = 102
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(144, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(202, 45)
            Me.Panel2.TabIndex = 103
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(103, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Salir"
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
            'pnlSeleccionarInterno
            '
            Me.pnlSeleccionarInterno.Controls.Add(Me.lblTitulo)
            Me.pnlSeleccionarInterno.Controls.Add(Me.UscLabelBusqueda1)
            Me.pnlSeleccionarInterno.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlSeleccionarInterno.Location = New System.Drawing.Point(3, 47)
            Me.pnlSeleccionarInterno.Name = "pnlSeleccionarInterno"
            Me.pnlSeleccionarInterno.Size = New System.Drawing.Size(340, 50)
            Me.pnlSeleccionarInterno.TabIndex = 10
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Location = New System.Drawing.Point(5, 9)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(161, 13)
            Me.lblTitulo.TabIndex = 4
            Me.lblTitulo.Text = "Apellidos y Nombres del Interno :"
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.rbtPlanilla)
            Me.Panel3.Controls.Add(Me.rbtAsistencia)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel3.Location = New System.Drawing.Point(3, 16)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(340, 31)
            Me.Panel3.TabIndex = 103
            '
            'rbtAsistencia
            '
            Me.rbtAsistencia.AutoSize = True
            Me.rbtAsistencia.Checked = True
            Me.rbtAsistencia.Location = New System.Drawing.Point(27, 7)
            Me.rbtAsistencia.Name = "rbtAsistencia"
            Me.rbtAsistencia.Size = New System.Drawing.Size(73, 17)
            Me.rbtAsistencia.TabIndex = 0
            Me.rbtAsistencia.TabStop = True
            Me.rbtAsistencia.Text = "Asistencia"
            Me.rbtAsistencia.UseVisualStyleBackColor = True
            '
            'rbtPlanilla
            '
            Me.rbtPlanilla.AutoSize = True
            Me.rbtPlanilla.Location = New System.Drawing.Point(157, 7)
            Me.rbtPlanilla.Name = "rbtPlanilla"
            Me.rbtPlanilla.Size = New System.Drawing.Size(106, 17)
            Me.rbtPlanilla.TabIndex = 1
            Me.rbtPlanilla.Text = "Planilla Individual"
            Me.rbtPlanilla.UseVisualStyleBackColor = True
            '
            'grbInterno
            '
            Me.grbInterno.Controls.Add(Me.pnlSeleccionarInterno)
            Me.grbInterno.Controls.Add(Me.Panel3)
            Me.grbInterno.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbInterno.Location = New System.Drawing.Point(0, 0)
            Me.grbInterno.Name = "grbInterno"
            Me.grbInterno.Size = New System.Drawing.Size(346, 100)
            Me.grbInterno.TabIndex = 104
            Me.grbInterno.TabStop = False
            '
            'gbTaller
            '
            Me.gbTaller.Controls.Add(Me.cbbTalleres)
            Me.gbTaller.Controls.Add(Me.Label2)
            Me.gbTaller.Dock = System.Windows.Forms.DockStyle.Top
            Me.gbTaller.Location = New System.Drawing.Point(0, 100)
            Me.gbTaller.Name = "gbTaller"
            Me.gbTaller.Size = New System.Drawing.Size(346, 40)
            Me.gbTaller.TabIndex = 105
            Me.gbTaller.TabStop = False
            '
            'cbbTalleres
            '
            Me.cbbTalleres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbbTalleres.FormattingEnabled = True
            Me.cbbTalleres.Location = New System.Drawing.Point(87, 11)
            Me.cbbTalleres.Name = "cbbTalleres"
            Me.cbbTalleres.Size = New System.Drawing.Size(247, 21)
            Me.cbbTalleres.TabIndex = 10
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(13, 15)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(39, 13)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Taller :"
            '
            'grbFechas
            '
            Me.grbFechas.Controls.Add(Me.dtpFechaFin)
            Me.grbFechas.Controls.Add(Me.Label6)
            Me.grbFechas.Controls.Add(Me.dtpFechaIni)
            Me.grbFechas.Controls.Add(Me.Label5)
            Me.grbFechas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFechas.Location = New System.Drawing.Point(0, 140)
            Me.grbFechas.Name = "grbFechas"
            Me.grbFechas.Size = New System.Drawing.Size(346, 49)
            Me.grbFechas.TabIndex = 106
            Me.grbFechas.TabStop = False
            Me.grbFechas.Text = "Fecha de Ingreso"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(250, 18)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 24
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(184, 21)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(87, 18)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 23
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(8, 21)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Desde :"
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = False
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(8, 26)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(323, 21)
            Me.UscLabelBusqueda1.TabIndex = 5
            '
            'frmReportePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(346, 234)
            Me.Name = "frmReportePopup"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.pnlSeleccionarInterno.ResumeLayout(False)
            Me.pnlSeleccionarInterno.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.grbInterno.ResumeLayout(False)
            Me.gbTaller.ResumeLayout(False)
            Me.gbTaller.PerformLayout()
            Me.grbFechas.ResumeLayout(False)
            Me.grbFechas.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents pnlSeleccionarInterno As System.Windows.Forms.Panel
        Friend WithEvents grbInterno As GroupBox
        Friend WithEvents Panel3 As Panel
        Friend WithEvents rbtPlanilla As RadioButton
        Friend WithEvents rbtAsistencia As RadioButton
        Friend WithEvents gbTaller As GroupBox
        Friend WithEvents grbFechas As GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As Label
        Friend WithEvents cbbTalleres As ComboBox
        Friend WithEvents Label2 As Label
    End Class
End Namespace