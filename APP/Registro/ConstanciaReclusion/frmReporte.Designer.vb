Namespace Registro.ConstanciaReclusion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmReporte
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.grpPanel = New System.Windows.Forms.GroupBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.grbTipTramite = New System.Windows.Forms.GroupBox()
            Me.rdbAmbos = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbconCosto = New Legolas.APPUIComponents.myRadioButton()
            Me.rdbsinCosto = New Legolas.APPUIComponents.myRadioButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cbbTipSolicitante = New APPControls.uscComboParametrica()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cbbPenal = New APPControls.uscComboParametrica()
            Me.cbbRegion = New APPControls.uscComboParametrica()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label28 = New System.Windows.Forms.Label()
            Me.PnlBotones = New System.Windows.Forms.Panel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.grpPanel.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.grbTipTramite.SuspendLayout()
            Me.PnlBotones.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grpPanel)
            Me.gbxFormChildContainer.Controls.Add(Me.PnlBotones)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(430, 250)
            '
            'grpPanel
            '
            Me.grpPanel.BackColor = System.Drawing.Color.Transparent
            Me.grpPanel.Controls.Add(Me.Label3)
            Me.grpPanel.Controls.Add(Me.GroupBox1)
            Me.grpPanel.Controls.Add(Me.grbTipTramite)
            Me.grpPanel.Controls.Add(Me.Label2)
            Me.grpPanel.Controls.Add(Me.cbbTipSolicitante)
            Me.grpPanel.Controls.Add(Me.Label1)
            Me.grpPanel.Controls.Add(Me.cbbPenal)
            Me.grpPanel.Controls.Add(Me.cbbRegion)
            Me.grpPanel.Controls.Add(Me.Label11)
            Me.grpPanel.Controls.Add(Me.Label28)
            Me.grpPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.grpPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpPanel.Location = New System.Drawing.Point(0, 0)
            Me.grpPanel.Name = "grpPanel"
            Me.grpPanel.Size = New System.Drawing.Size(430, 205)
            Me.grpPanel.TabIndex = 1
            Me.grpPanel.TabStop = False
            Me.grpPanel.Text = "Ingrese los datos por el cual quiere consultar"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(18, 99)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(107, 15)
            Me.Label3.TabIndex = 79
            Me.Label3.Text = "Fecha expedición:"
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
            Me.GroupBox1.Location = New System.Drawing.Point(129, 84)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(288, 39)
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaIni.Location = New System.Drawing.Point(56, 12)
            Me.dtpFechaIni.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 5
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(4, 14)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(49, 15)
            Me.Label5.TabIndex = 74
            Me.Label5.Text = "Desde :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(142, 14)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(45, 15)
            Me.Label6.TabIndex = 75
            Me.Label6.Text = "Hasta :"
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dtpFechaFin.Location = New System.Drawing.Point(198, 12)
            Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 6
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'grbTipTramite
            '
            Me.grbTipTramite.BackColor = System.Drawing.Color.Transparent
            Me.grbTipTramite.Controls.Add(Me.rdbAmbos)
            Me.grbTipTramite.Controls.Add(Me.rdbconCosto)
            Me.grbTipTramite.Controls.Add(Me.rdbsinCosto)
            Me.grbTipTramite.Location = New System.Drawing.Point(129, 153)
            Me.grbTipTramite.Name = "grbTipTramite"
            Me.grbTipTramite.Size = New System.Drawing.Size(288, 39)
            Me.grbTipTramite.TabIndex = 8
            Me.grbTipTramite.TabStop = False
            '
            'rdbAmbos
            '
            Me.rdbAmbos.AutoSize = True
            Me.rdbAmbos.Checked = True
            Me.rdbAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbAmbos.Location = New System.Drawing.Point(190, 14)
            Me.rdbAmbos.Name = "rdbAmbos"
            Me.rdbAmbos.Size = New System.Drawing.Size(57, 17)
            Me.rdbAmbos.TabIndex = 11
            Me.rdbAmbos.TabStop = True
            Me.rdbAmbos.Text = "Ambos"
            Me.rdbAmbos.UseVisualStyleBackColor = True
            '
            'rdbconCosto
            '
            Me.rdbconCosto.AutoSize = True
            Me.rdbconCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbconCosto.Location = New System.Drawing.Point(12, 14)
            Me.rdbconCosto.Name = "rdbconCosto"
            Me.rdbconCosto.Size = New System.Drawing.Size(74, 17)
            Me.rdbconCosto.TabIndex = 9
            Me.rdbconCosto.Text = "Con Costo"
            Me.rdbconCosto.UseVisualStyleBackColor = True
            '
            'rdbsinCosto
            '
            Me.rdbsinCosto.AutoSize = True
            Me.rdbsinCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbsinCosto.Location = New System.Drawing.Point(105, 14)
            Me.rdbsinCosto.Name = "rdbsinCosto"
            Me.rdbsinCosto.Size = New System.Drawing.Size(70, 17)
            Me.rdbsinCosto.TabIndex = 10
            Me.rdbsinCosto.Text = "Sin Costo"
            Me.rdbsinCosto.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(18, 166)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 15)
            Me.Label2.TabIndex = 76
            Me.Label2.Text = "Trámite:"
            '
            'cbbTipSolicitante
            '
            Me.cbbTipSolicitante._NoIndica = False
            Me.cbbTipSolicitante._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipSolicitante._Todos = False
            Me.cbbTipSolicitante._TodosMensaje = ""
            Me.cbbTipSolicitante._Visible_Add = False
            Me.cbbTipSolicitante._Visible_Buscar = False
            Me.cbbTipSolicitante._Visible_Eliminar = False
            Me.cbbTipSolicitante.CodigoPadre = -1
            Me.cbbTipSolicitante.ComboTipo = CType(17, Short)
            Me.cbbTipSolicitante.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipSolicitante.DropDownWidth = 325
            Me.cbbTipSolicitante.DropDownWidthAuto = False
            Me.cbbTipSolicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbTipSolicitante.ListaIdsParaExcluir = Nothing
            Me.cbbTipSolicitante.Location = New System.Drawing.Point(129, 130)
            Me.cbbTipSolicitante.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbTipSolicitante.ModuloTratamiento = False
            Me.cbbTipSolicitante.Name = "cbbTipSolicitante"
            Me.cbbTipSolicitante.Parametro1 = -1
            Me.cbbTipSolicitante.Parametro2 = -1
            Me.cbbTipSolicitante.SelectedIndex = -1
            Me.cbbTipSolicitante.SelectedValue = 0
            Me.cbbTipSolicitante.Size = New System.Drawing.Size(288, 22)
            Me.cbbTipSolicitante.TabIndex = 7
            Me.cbbTipSolicitante.verToolTipItemSeleccionado = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(18, 133)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 15)
            Me.Label1.TabIndex = 70
            Me.Label1.Text = "Solicitante:"
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
            Me.cbbPenal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbPenal.ListaIdsParaExcluir = Nothing
            Me.cbbPenal.Location = New System.Drawing.Point(129, 60)
            Me.cbbPenal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbPenal.ModuloTratamiento = False
            Me.cbbPenal.Name = "cbbPenal"
            Me.cbbPenal.Parametro1 = -1
            Me.cbbPenal.Parametro2 = -1
            Me.cbbPenal.SelectedIndex = -1
            Me.cbbPenal.SelectedValue = 0
            Me.cbbPenal.Size = New System.Drawing.Size(288, 22)
            Me.cbbPenal.TabIndex = 3
            Me.cbbPenal.verToolTipItemSeleccionado = False
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
            Me.cbbRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbRegion.ListaIdsParaExcluir = Nothing
            Me.cbbRegion.Location = New System.Drawing.Point(129, 32)
            Me.cbbRegion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.cbbRegion.ModuloTratamiento = False
            Me.cbbRegion.Name = "cbbRegion"
            Me.cbbRegion.Parametro1 = -1
            Me.cbbRegion.Parametro2 = -1
            Me.cbbRegion.SelectedIndex = -1
            Me.cbbRegion.SelectedValue = 0
            Me.cbbRegion.Size = New System.Drawing.Size(288, 22)
            Me.cbbRegion.TabIndex = 2
            Me.cbbRegion.verToolTipItemSeleccionado = False
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label11.Location = New System.Drawing.Point(18, 64)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(105, 15)
            Me.Label11.TabIndex = 68
            Me.Label11.Text = "Est. Penitenciario:"
            '
            'Label28
            '
            Me.Label28.AutoSize = True
            Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label28.Location = New System.Drawing.Point(18, 35)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(101, 15)
            Me.Label28.TabIndex = 69
            Me.Label28.Text = "Oficina Regional:"
            '
            'PnlBotones
            '
            Me.PnlBotones.Controls.Add(Me.Panel1)
            Me.PnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PnlBotones.Location = New System.Drawing.Point(0, 205)
            Me.PnlBotones.Name = "PnlBotones"
            Me.PnlBotones.Size = New System.Drawing.Size(430, 45)
            Me.PnlBotones.TabIndex = 12
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(222, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(208, 45)
            Me.Panel1.TabIndex = 15
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(4, 2)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(94, 40)
            Me.btnAceptar.TabIndex = 13
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(104, 2)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 14
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'frmReporte
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(430, 250)
            Me.Name = "frmReporte"
            Me.Text = "Reporte de Expedición de Constancia de Reclusión"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.grpPanel.ResumeLayout(False)
            Me.grpPanel.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.grbTipTramite.ResumeLayout(False)
            Me.grbTipTramite.PerformLayout()
            Me.PnlBotones.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents grpPanel As GroupBox
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label6 As Label
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label5 As Label
        Friend WithEvents cbbTipSolicitante As APPControls.uscComboParametrica
        Friend WithEvents Label1 As Label
        Friend WithEvents cbbPenal As APPControls.uscComboParametrica
        Friend WithEvents cbbRegion As APPControls.uscComboParametrica
        Friend WithEvents Label11 As Label
        Friend WithEvents Label28 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents grbTipTramite As GroupBox
        Friend WithEvents rdbAmbos As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbconCosto As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents rdbsinCosto As Legolas.APPUIComponents.myRadioButton
        Friend WithEvents PnlBotones As Panel
        Friend WithEvents btnAceptar As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Panel1 As Panel
    End Class

End Namespace