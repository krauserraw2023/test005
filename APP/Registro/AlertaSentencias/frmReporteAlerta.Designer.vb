Namespace Registro.AlertaSentencias

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmReporteAlerta
        Inherits Legolas.APPUIComponents.FormPopup

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.grbFiltro = New System.Windows.Forms.GroupBox()
            Me.grbFechas = New System.Windows.Forms.GroupBox()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.grbEstado = New System.Windows.Forms.GroupBox()
            Me.rdbTodos = New System.Windows.Forms.RadioButton()
            Me.rdbExtranjeros = New System.Windows.Forms.RadioButton()
            Me.rdbPeruanos = New System.Windows.Forms.RadioButton()
            Me.grbRegionPenal = New System.Windows.Forms.GroupBox()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.lblPenal = New System.Windows.Forms.Label()
            Me.lblRegion = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.grbFiltro.SuspendLayout()
            Me.grbFechas.SuspendLayout()
            Me.grbEstado.SuspendLayout()
            Me.grbRegionPenal.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbFiltro)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(408, 241)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.dtpFechaIni)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 196)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(408, 45)
            Me.Panel1.TabIndex = 102
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(206, 0)
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
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(12, 12)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 23
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            Me.dtpFechaIni.Visible = False
            '
            'grbFiltro
            '
            Me.grbFiltro.Controls.Add(Me.grbFechas)
            Me.grbFiltro.Controls.Add(Me.grbEstado)
            Me.grbFiltro.Controls.Add(Me.grbRegionPenal)
            Me.grbFiltro.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFiltro.Location = New System.Drawing.Point(0, 0)
            Me.grbFiltro.Name = "grbFiltro"
            Me.grbFiltro.Size = New System.Drawing.Size(408, 196)
            Me.grbFiltro.TabIndex = 103
            Me.grbFiltro.TabStop = False
            '
            'grbFechas
            '
            Me.grbFechas.Controls.Add(Me.dtpFechaFin)
            Me.grbFechas.Controls.Add(Me.Label6)
            Me.grbFechas.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grbFechas.Location = New System.Drawing.Point(3, 93)
            Me.grbFechas.Name = "grbFechas"
            Me.grbFechas.Size = New System.Drawing.Size(221, 100)
            Me.grbFechas.TabIndex = 60
            Me.grbFechas.TabStop = False
            Me.grbFechas.Text = "Proyección de fecha de vencimiento de condena"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(106, 45)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 24
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(46, 49)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(52, 13)
            Me.Label6.TabIndex = 58
            Me.Label6.Text = "Hasta el :"
            '
            'grbEstado
            '
            Me.grbEstado.Controls.Add(Me.rdbTodos)
            Me.grbEstado.Controls.Add(Me.rdbExtranjeros)
            Me.grbEstado.Controls.Add(Me.rdbPeruanos)
            Me.grbEstado.Dock = System.Windows.Forms.DockStyle.Right
            Me.grbEstado.Location = New System.Drawing.Point(224, 93)
            Me.grbEstado.Name = "grbEstado"
            Me.grbEstado.Size = New System.Drawing.Size(181, 100)
            Me.grbEstado.TabIndex = 59
            Me.grbEstado.TabStop = False
            Me.grbEstado.Text = "Nacionalidad"
            '
            'rdbTodos
            '
            Me.rdbTodos.AutoSize = True
            Me.rdbTodos.Checked = True
            Me.rdbTodos.Location = New System.Drawing.Point(7, 24)
            Me.rdbTodos.Name = "rdbTodos"
            Me.rdbTodos.Size = New System.Drawing.Size(61, 17)
            Me.rdbTodos.TabIndex = 8
            Me.rdbTodos.TabStop = True
            Me.rdbTodos.Text = "[Todos]"
            Me.rdbTodos.UseVisualStyleBackColor = True
            '
            'rdbExtranjeros
            '
            Me.rdbExtranjeros.AutoSize = True
            Me.rdbExtranjeros.Location = New System.Drawing.Point(6, 73)
            Me.rdbExtranjeros.Name = "rdbExtranjeros"
            Me.rdbExtranjeros.Size = New System.Drawing.Size(77, 17)
            Me.rdbExtranjeros.TabIndex = 7
            Me.rdbExtranjeros.Text = "Extranjeros"
            Me.rdbExtranjeros.UseVisualStyleBackColor = True
            '
            'rdbPeruanos
            '
            Me.rdbPeruanos.AutoSize = True
            Me.rdbPeruanos.Location = New System.Drawing.Point(6, 47)
            Me.rdbPeruanos.Name = "rdbPeruanos"
            Me.rdbPeruanos.Size = New System.Drawing.Size(70, 17)
            Me.rdbPeruanos.TabIndex = 6
            Me.rdbPeruanos.Text = "Peruanos"
            Me.rdbPeruanos.UseVisualStyleBackColor = True
            '
            'grbRegionPenal
            '
            Me.grbRegionPenal.Controls.Add(Me.cbbPenal)
            Me.grbRegionPenal.Controls.Add(Me.cbbRegion)
            Me.grbRegionPenal.Controls.Add(Me.lblPenal)
            Me.grbRegionPenal.Controls.Add(Me.lblRegion)
            Me.grbRegionPenal.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbRegionPenal.Location = New System.Drawing.Point(3, 16)
            Me.grbRegionPenal.Name = "grbRegionPenal"
            Me.grbRegionPenal.Size = New System.Drawing.Size(402, 77)
            Me.grbRegionPenal.TabIndex = 47
            Me.grbRegionPenal.TabStop = False
            '
            'cbbPenal
            '
            Me.cbbPenal._NoIndica = False
            Me.cbbPenal._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbPenal._Todos = False
            Me.cbbPenal._TodosMensaje = ""
            Me.cbbPenal._Visible_Add = False
            Me.cbbPenal._Visible_Buscar = False
            Me.cbbPenal._Visible_Eliminar = False
            Me.cbbPenal.CodigoPadre = -1
            Me.cbbPenal.ComboTipo = CType(36, Short)
            Me.cbbPenal.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPenal.DropDownWidth = 217
            Me.cbbPenal.DropDownWidthAuto = False
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(119, 44)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(247, 22)
            Me.cbbPenal.TabIndex = 55
            '
            'cbbRegion
            '
            Me.cbbRegion._NoIndica = False
            Me.cbbRegion._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbRegion._Todos = False
            Me.cbbRegion._TodosMensaje = ""
            Me.cbbRegion._Visible_Add = False
            Me.cbbRegion._Visible_Buscar = False
            Me.cbbRegion._Visible_Eliminar = False
            Me.cbbRegion.CodigoPadre = -1
            Me.cbbRegion.ComboTipo = CType(37, Short)
            Me.cbbRegion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbRegion.DropDownWidth = 217
            Me.cbbRegion.DropDownWidthAuto = False
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(119, 16)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(247, 22)
            Me.cbbRegion.TabIndex = 54
            '
            'lblPenal
            '
            Me.lblPenal.AutoSize = True
            Me.lblPenal.Location = New System.Drawing.Point(2, 47)
            Me.lblPenal.Name = "lblPenal"
            Me.lblPenal.Size = New System.Drawing.Size(114, 13)
            Me.lblPenal.TabIndex = 12
            Me.lblPenal.Text = "Establecimiento Penal:"
            '
            'lblRegion
            '
            Me.lblRegion.AutoSize = True
            Me.lblRegion.Location = New System.Drawing.Point(2, 20)
            Me.lblRegion.Name = "lblRegion"
            Me.lblRegion.Size = New System.Drawing.Size(88, 13)
            Me.lblRegion.TabIndex = 44
            Me.lblRegion.Text = "Oficina Regional:"
            '
            'frmReporteAlerta
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(408, 241)
            Me.Name = "frmReporteAlerta"
            Me.Text = "Reportes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.grbFiltro.ResumeLayout(False)
            Me.grbFechas.ResumeLayout(False)
            Me.grbFechas.PerformLayout()
            Me.grbEstado.ResumeLayout(False)
            Me.grbEstado.PerformLayout()
            Me.grbRegionPenal.ResumeLayout(False)
            Me.grbRegionPenal.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
        Friend WithEvents grbRegionPenal As System.Windows.Forms.GroupBox
        Friend WithEvents lblPenal As System.Windows.Forms.Label
        Friend WithEvents lblRegion As System.Windows.Forms.Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents grbFechas As GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents grbEstado As GroupBox
        Friend WithEvents rdbTodos As RadioButton
        Friend WithEvents rdbExtranjeros As RadioButton
        Friend WithEvents rdbPeruanos As RadioButton
    End Class
End Namespace