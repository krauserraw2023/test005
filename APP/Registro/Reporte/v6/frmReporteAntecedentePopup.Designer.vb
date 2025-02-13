Namespace Registro.Reporte.V6
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReporteAntecedentePopup
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
            Me.rdbListaAntJud = New System.Windows.Forms.RadioButton()
            Me.rdbAntJudPos = New System.Windows.Forms.RadioButton()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.grbTipoCertAnt = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbNegativo = New System.Windows.Forms.RadioButton()
            Me.rdbPositivo = New System.Windows.Forms.RadioButton()
            Me.grbFechas = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.grbInterno = New System.Windows.Forms.GroupBox()
            Me.lblTitulo = New System.Windows.Forms.Label()
            Me.rdbInternoTodos = New Legolas.APPUIComponents.myRadioButton()
            Me.UscLabelBusqueda1 = New APPControls.uscLabelBusqueda()
            Me.rdbSeleccionarInterno = New Legolas.APPUIComponents.myRadioButton()
            Me.grbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbHisAntJud = New System.Windows.Forms.RadioButton()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.grbTipoCertAnt.SuspendLayout()
            Me.grbFechas.SuspendLayout()
            Me.grbInterno.SuspendLayout()
            Me.grbRegionPenal.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(553, 234)
            '
            'rdbListaAntJud
            '
            Me.rdbListaAntJud.AutoSize = True
            Me.rdbListaAntJud.Location = New System.Drawing.Point(7, 59)
            Me.rdbListaAntJud.Name = "rdbListaAntJud"
            Me.rdbListaAntJud.Size = New System.Drawing.Size(162, 17)
            Me.rdbListaAntJud.TabIndex = 2
            Me.rdbListaAntJud.Text = "Lista Antecedentes judiciales"
            Me.rdbListaAntJud.UseVisualStyleBackColor = True
            '
            'rdbAntJudPos
            '
            Me.rdbAntJudPos.AutoSize = True
            Me.rdbAntJudPos.Checked = True
            Me.rdbAntJudPos.Location = New System.Drawing.Point(9, 25)
            Me.rdbAntJudPos.Name = "rdbAntJudPos"
            Me.rdbAntJudPos.Size = New System.Drawing.Size(121, 17)
            Me.rdbAntJudPos.TabIndex = 0
            Me.rdbAntJudPos.TabStop = True
            Me.rdbAntJudPos.Text = "Antecedente judicial"
            Me.rdbAntJudPos.UseVisualStyleBackColor = True
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(360, 1)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 97
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(454, 1)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 98
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 234)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(553, 42)
            Me.Panel1.TabIndex = 100
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.grbTipoCertAnt)
            Me.Panel3.Controls.Add(Me.grbFechas)
            Me.Panel3.Controls.Add(Me.grbInterno)
            Me.Panel3.Controls.Add(Me.grbRegionPenal)
            Me.Panel3.Controls.Add(Me.GroupBox1)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(553, 234)
            Me.Panel3.TabIndex = 102
            '
            'grbTipoCertAnt
            '
            Me.grbTipoCertAnt.Controls.Add(Me.rdbTodos)
            Me.grbTipoCertAnt.Controls.Add(Me.rdbNegativo)
            Me.grbTipoCertAnt.Controls.Add(Me.rdbPositivo)
            Me.grbTipoCertAnt.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbTipoCertAnt.Enabled = False
            Me.grbTipoCertAnt.Location = New System.Drawing.Point(186, 185)
            Me.grbTipoCertAnt.Name = "grbTipoCertAnt"
            Me.grbTipoCertAnt.Size = New System.Drawing.Size(367, 45)
            Me.grbTipoCertAnt.TabIndex = 51
            Me.grbTipoCertAnt.TabStop = False
            Me.grbTipoCertAnt.Text = "Tipo de certificado antecedente"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(243, 21)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbTodos.TabIndex = 2
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "Todos"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbNegativo
            '
            Me.rdbNegativo.AutoSize = True
            Me.rdbNegativo.Location = New System.Drawing.Point(139, 21)
            Me.rdbNegativo.Name = "rdbNegativo"
            Me.rdbNegativo.Size = New System.Drawing.Size(68, 17)
            Me.rdbNegativo.TabIndex = 1
            Me.rdbNegativo.Text = "Negativo"
            Me.rdbNegativo.UseVisualStyleBackColor = True
            '
            'rdbPositivo
            '
            Me.rdbPositivo.AutoSize = True
            Me.rdbPositivo.Location = New System.Drawing.Point(36, 21)
            Me.rdbPositivo.Name = "rdbPositivo"
            Me.rdbPositivo.Size = New System.Drawing.Size(62, 17)
            Me.rdbPositivo.TabIndex = 0
            Me.rdbPositivo.Text = "Positivo"
            Me.rdbPositivo.UseVisualStyleBackColor = True
            '
            'grbFechas
            '
            Me.grbFechas.Controls.Add(Me.dtpFechaFin)
            Me.grbFechas.Controls.Add(Me.Label6)
            Me.grbFechas.Controls.Add(Me.dtpFechaIni)
            Me.grbFechas.Controls.Add(Me.Label5)
            Me.grbFechas.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbFechas.Location = New System.Drawing.Point(186, 141)
            Me.grbFechas.Name = "grbFechas"
            Me.grbFechas.Size = New System.Drawing.Size(367, 44)
            Me.grbFechas.TabIndex = 50
            Me.grbFechas.TabStop = False
            Me.grbFechas.Text = "Fecha de solicitud"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(219, 18)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 24
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(174, 22)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 13)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(78, 18)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 23
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(29, 22)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 57
            Me.Label5.Text = "Desde :"
            '
            'grbInterno
            '
            Me.grbInterno.Controls.Add(Me.lblTitulo)
            Me.grbInterno.Controls.Add(Me.rdbInternoTodos)
            Me.grbInterno.Controls.Add(Me.UscLabelBusqueda1)
            Me.grbInterno.Controls.Add(Me.rdbSeleccionarInterno)
            Me.grbInterno.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbInterno.Location = New System.Drawing.Point(186, 60)
            Me.grbInterno.Name = "grbInterno"
            Me.grbInterno.Size = New System.Drawing.Size(367, 81)
            Me.grbInterno.TabIndex = 49
            Me.grbInterno.TabStop = False
            '
            'lblTitulo
            '
            Me.lblTitulo.AutoSize = True
            Me.lblTitulo.Location = New System.Drawing.Point(17, 38)
            Me.lblTitulo.Name = "lblTitulo"
            Me.lblTitulo.Size = New System.Drawing.Size(161, 13)
            Me.lblTitulo.TabIndex = 4
            Me.lblTitulo.Text = "Apellidos y Nombres del Interno :"
            '
            'rdbInternoTodos
            '
            Me.rdbInternoTodos.AutoSize = True
            Me.rdbInternoTodos.Location = New System.Drawing.Point(188, 13)
            Me.rdbInternoTodos.Name = "rdbInternoTodos"
            Me.rdbInternoTodos.Size = New System.Drawing.Size(55, 17)
            Me.rdbInternoTodos.TabIndex = 7
            Me.rdbInternoTodos.Text = "Todos"
            Me.rdbInternoTodos.UseVisualStyleBackColor = True
            '
            'UscLabelBusqueda1
            '
            Me.UscLabelBusqueda1._Codigo = 0
            Me.UscLabelBusqueda1._Value = "[SELECCIONE]"
            Me.UscLabelBusqueda1._Visible_Add = False
            Me.UscLabelBusqueda1._Visible_Buscar = True
            Me.UscLabelBusqueda1._Visible_Eliminar = False
            Me.UscLabelBusqueda1.Location = New System.Drawing.Point(20, 55)
            Me.UscLabelBusqueda1.Name = "UscLabelBusqueda1"
            Me.UscLabelBusqueda1.Size = New System.Drawing.Size(343, 21)
            Me.UscLabelBusqueda1.TabIndex = 5
            '
            'rdbSeleccionarInterno
            '
            Me.rdbSeleccionarInterno.AutoSize = True
            Me.rdbSeleccionarInterno.Checked = True
            Me.rdbSeleccionarInterno.Location = New System.Drawing.Point(19, 13)
            Me.rdbSeleccionarInterno.Name = "rdbSeleccionarInterno"
            Me.rdbSeleccionarInterno.Size = New System.Drawing.Size(114, 17)
            Me.rdbSeleccionarInterno.TabIndex = 8
            Me.rdbSeleccionarInterno.TabStop = True
            Me.rdbSeleccionarInterno.Text = "Seleccione Interno"
            Me.rdbSeleccionarInterno.UseVisualStyleBackColor = True
            '
            'grbRegionPenal
            '
            Me.grbRegionPenal.Controls.Add(Me.cbbPenal)
            Me.grbRegionPenal.Controls.Add(Me.cbbRegion)
            Me.grbRegionPenal.Controls.Add(Me.Label11)
            Me.grbRegionPenal.Controls.Add(Me.Label28)
            Me.grbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbRegionPenal.Location = New System.Drawing.Point(186, 0)
            Me.grbRegionPenal.Name = "grbRegionPenal"
            Me.grbRegionPenal.Size = New System.Drawing.Size(367, 60)
            Me.grbRegionPenal.TabIndex = 48
            Me.grbRegionPenal.TabStop = False
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = Type.Combo.ComboTipo.PenalUsuario
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 217
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.Location = New System.Drawing.Point(52, 34)
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(309, 22)
            Me.cbbPenal.TabIndex = 55
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = Type.Combo.ComboTipo.RegionUsuario
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 217
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.Location = New System.Drawing.Point(52, 11)
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(309, 22)
            Me.cbbRegion.TabIndex = 54
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(2, 40)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(40, 13)
            Me.Label11.TabIndex = 12
            Me.Label11.Text = "Penal :"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Location = New System.Drawing.Point(2, 15)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(47, 13)
            Me.Label28.TabIndex = 44
            Me.Label28.Text = "Región :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbHisAntJud)
            Me.GroupBox1.Controls.Add(Me.rdbListaAntJud)
            Me.GroupBox1.Controls.Add(Me.rdbAntJudPos)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(186, 234)
            Me.GroupBox1.TabIndex = 52
            Me.GroupBox1.TabStop = False
            '
            'rdbHisAntJud
            '
            Me.rdbHisAntJud.AutoSize = True
            Me.rdbHisAntJud.Location = New System.Drawing.Point(6, 93)
            Me.rdbHisAntJud.Name = "rdbHisAntJud"
            Me.rdbHisAntJud.Size = New System.Drawing.Size(177, 17)
            Me.rdbHisAntJud.TabIndex = 3
            Me.rdbHisAntJud.Text = "Historial Antecedentes judiciales"
            Me.rdbHisAntJud.UseVisualStyleBackColor = True
            '
            'frmReporteAntecedentePopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(553, 276)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frmReporteAntecedentePopup"
            Me.Text = "Reporte de antecedentes"
            Me.Controls.SetChildIndex(Me.Panel1, 0)
            Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.grbTipoCertAnt.ResumeLayout(False)
            Me.grbTipoCertAnt.PerformLayout()
            Me.grbFechas.ResumeLayout(False)
            Me.grbFechas.PerformLayout()
            Me.grbInterno.ResumeLayout(False)
            Me.grbInterno.PerformLayout()
            Me.grbRegionPenal.ResumeLayout(False)
            Me.grbRegionPenal.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents rdbListaAntJud As System.Windows.Forms.RadioButton
        Friend WithEvents rdbAntJudPos As System.Windows.Forms.RadioButton
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents grbInterno As System.Windows.Forms.GroupBox
        Friend WithEvents rdbInternoTodos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents lblTitulo As System.Windows.Forms.Label
        Friend WithEvents UscLabelBusqueda1 As APPControls.uscLabelBusqueda
        Friend WithEvents rdbSeleccionarInterno As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents grbFechas As System.Windows.Forms.GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents grbTipoCertAnt As System.Windows.Forms.GroupBox
        Friend WithEvents rdbTodos As System.Windows.Forms.RadioButton
        Friend WithEvents rdbNegativo As System.Windows.Forms.RadioButton
        Friend WithEvents rdbPositivo As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents grbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents rdbHisAntJud As System.Windows.Forms.RadioButton
    End Class
End Namespace