Namespace Visita.Calendario


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCalendario
        Inherits Legolas.APPUIComponents.FormPopup

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
            Me.components = New System.ComponentModel.Container
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.GroupBox4 = New System.Windows.Forms.GroupBox
            Me.rb_mujer = New System.Windows.Forms.RadioButton
            Me.rb_hombre = New System.Windows.Forms.RadioButton
            Me.rb_ambos = New System.Windows.Forms.RadioButton
            Me.GroupBox5 = New System.Windows.Forms.GroupBox
            Me.rb_menoresNO = New System.Windows.Forms.RadioButton
            Me.rb_menoresSI = New System.Windows.Forms.RadioButton
            Me.rb_menores = New System.Windows.Forms.RadioButton
            Me.btnBuscar = New System.Windows.Forms.Button
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.cbbVisitaTipo = New APPControls.uscComboParametrica
            Me.UsrCalendario1 = New APPControls.usrCalendario
            Me.btnSalir = New System.Windows.Forms.Button
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.UsrCalendario1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(874, 519)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox5)
            Me.Panel1.Controls.Add(Me.btnBuscar)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 470)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(874, 49)
            Me.Panel1.TabIndex = 1
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.rb_mujer)
            Me.GroupBox4.Controls.Add(Me.rb_hombre)
            Me.GroupBox4.Controls.Add(Me.rb_ambos)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox4.Location = New System.Drawing.Point(476, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(244, 49)
            Me.GroupBox4.TabIndex = 57
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Sexo"
            '
            'rb_mujer
            '
            Me.rb_mujer.AutoSize = True
            Me.rb_mujer.Location = New System.Drawing.Point(176, 18)
            Me.rb_mujer.Name = "rb_mujer"
            Me.rb_mujer.Size = New System.Drawing.Size(62, 17)
            Me.rb_mujer.TabIndex = 2
            Me.rb_mujer.Tag = "1"
            Me.rb_mujer.Text = "Mujeres"
            Me.rb_mujer.UseVisualStyleBackColor = True
            '
            'rb_hombre
            '
            Me.rb_hombre.AutoSize = True
            Me.rb_hombre.Location = New System.Drawing.Point(94, 19)
            Me.rb_hombre.Name = "rb_hombre"
            Me.rb_hombre.Size = New System.Drawing.Size(67, 17)
            Me.rb_hombre.TabIndex = 1
            Me.rb_hombre.Tag = "1"
            Me.rb_hombre.Text = "Hombres"
            Me.rb_hombre.UseVisualStyleBackColor = True
            '
            'rb_ambos
            '
            Me.rb_ambos.AutoSize = True
            Me.rb_ambos.Checked = True
            Me.rb_ambos.Location = New System.Drawing.Point(10, 18)
            Me.rb_ambos.Name = "rb_ambos"
            Me.rb_ambos.Size = New System.Drawing.Size(67, 17)
            Me.rb_ambos.TabIndex = 0
            Me.rb_ambos.TabStop = True
            Me.rb_ambos.Tag = "-1"
            Me.rb_ambos.Text = "[ Todos ]"
            Me.rb_ambos.UseVisualStyleBackColor = True
            '
            'GroupBox5
            '
            Me.GroupBox5.Controls.Add(Me.rb_menoresNO)
            Me.GroupBox5.Controls.Add(Me.rb_menoresSI)
            Me.GroupBox5.Controls.Add(Me.rb_menores)
            Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox5.Location = New System.Drawing.Point(282, 0)
            Me.GroupBox5.Name = "GroupBox5"
            Me.GroupBox5.Size = New System.Drawing.Size(194, 49)
            Me.GroupBox5.TabIndex = 56
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Menores"
            '
            'rb_menoresNO
            '
            Me.rb_menoresNO.AutoSize = True
            Me.rb_menoresNO.Location = New System.Drawing.Point(140, 18)
            Me.rb_menoresNO.Name = "rb_menoresNO"
            Me.rb_menoresNO.Size = New System.Drawing.Size(39, 17)
            Me.rb_menoresNO.TabIndex = 2
            Me.rb_menoresNO.Tag = "0"
            Me.rb_menoresNO.Text = "No"
            Me.rb_menoresNO.UseVisualStyleBackColor = True
            '
            'rb_menoresSI
            '
            Me.rb_menoresSI.AutoSize = True
            Me.rb_menoresSI.Location = New System.Drawing.Point(81, 18)
            Me.rb_menoresSI.Name = "rb_menoresSI"
            Me.rb_menoresSI.Size = New System.Drawing.Size(34, 17)
            Me.rb_menoresSI.TabIndex = 1
            Me.rb_menoresSI.Tag = "1"
            Me.rb_menoresSI.Text = "Si"
            Me.rb_menoresSI.UseVisualStyleBackColor = True
            '
            'rb_menores
            '
            Me.rb_menores.AutoSize = True
            Me.rb_menores.Checked = True
            Me.rb_menores.Location = New System.Drawing.Point(10, 18)
            Me.rb_menores.Name = "rb_menores"
            Me.rb_menores.Size = New System.Drawing.Size(55, 17)
            Me.rb_menores.TabIndex = 0
            Me.rb_menores.TabStop = True
            Me.rb_menores.Tag = "-1"
            Me.rb_menores.Text = "Todos"
            Me.rb_menores.UseVisualStyleBackColor = True
            '
            'btnBuscar
            '
            Me.btnBuscar.Location = New System.Drawing.Point(724, 14)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(72, 25)
            Me.btnBuscar.TabIndex = 0
            Me.btnBuscar.Text = "Actualizar"
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbVisitaTipo)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(282, 49)
            Me.GroupBox1.TabIndex = 58
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Tipo Visita"
            '
            'cbbVisitaTipo
            '
            Me.cbbVisitaTipo._Todos = False
            Me.cbbVisitaTipo._TodosMensaje = ""
            Me.cbbVisitaTipo.CodigoPadre = -1
            Me.cbbVisitaTipo.ComboTipo = Type.Combo.ComboTipo.Ninguno
            Me.cbbVisitaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbVisitaTipo.DropDownWidth = 123
            Me.cbbVisitaTipo.DropDownWidthAuto = False
            Me.cbbVisitaTipo.Location = New System.Drawing.Point(6, 19)
            Me.cbbVisitaTipo.Name = "cbbVisitaTipo"
            Me.cbbVisitaTipo.Parametro1 = -1
            Me.cbbVisitaTipo.Parametro2 = -1
            Me.cbbVisitaTipo.SelectedIndex = -1
            Me.cbbVisitaTipo.SelectedValue = 0
            Me.cbbVisitaTipo.Size = New System.Drawing.Size(269, 22)
            Me.cbbVisitaTipo.TabIndex = 1
            '
            'UsrCalendario1
            '
            Me.UsrCalendario1._Anio = 2010
            Me.UsrCalendario1._Menores = -1
            Me.UsrCalendario1._mes = 10
            Me.UsrCalendario1._PenalId = -1
            Me.UsrCalendario1._RegionId = -1
            Me.UsrCalendario1._Sexo = -1
            Me.UsrCalendario1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UsrCalendario1.Location = New System.Drawing.Point(0, 0)
            Me.UsrCalendario1.Name = "UsrCalendario1"
            Me.UsrCalendario1.Size = New System.Drawing.Size(874, 470)
            Me.UsrCalendario1.TabIndex = 0
            '
            'btnSalir
            '
            Me.btnSalir.Location = New System.Drawing.Point(799, 14)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(72, 25)
            Me.btnSalir.TabIndex = 59
            Me.btnSalir.Text = "Salir"
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'frmCalendario
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(874, 519)
            Me.Name = "frmCalendario"
            Me.Text = "Calendario"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UsrCalendario1 As APPControls.usrCalendario
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cbbVisitaTipo As APPControls.uscComboParametrica
        Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents rb_menoresNO As System.Windows.Forms.RadioButton
        Friend WithEvents rb_menoresSI As System.Windows.Forms.RadioButton
        Friend WithEvents rb_menores As System.Windows.Forms.RadioButton
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents rb_mujer As System.Windows.Forms.RadioButton
        Friend WithEvents rb_hombre As System.Windows.Forms.RadioButton
        Friend WithEvents rb_ambos As System.Windows.Forms.RadioButton
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents btnSalir As System.Windows.Forms.Button
    End Class
End Namespace