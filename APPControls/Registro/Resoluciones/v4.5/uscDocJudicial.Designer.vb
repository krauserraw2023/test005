Namespace Registro.Documento


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscDocJudicial
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Me.components = New System.ComponentModel.Container()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbAutJudicial = New System.Windows.Forms.RadioButton()
            Me.rdbOtros = New System.Windows.Forms.RadioButton()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.pnlObs = New System.Windows.Forms.Panel()
            Me.txtObservacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.txtNumero = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaDoc = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label35 = New System.Windows.Forms.Label()
            Me.dtpFechaRecep = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.pnlSalaJuzgado = New System.Windows.Forms.Panel()
            Me.txtJuez = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtSecretario = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.lblSecretario = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.cbbAutJudicial = New APPControls.uscComboParametrica()
            Me.lblDistrito = New System.Windows.Forms.Label()
            Me.cbbSalaJudicial = New APPControls.uscComboParametrica()
            Me.lblSala = New System.Windows.Forms.Label()
            Me.txtNombreAut = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtCargoAut = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.pnlObs.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.pnlSalaJuzgado.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbAutJudicial)
            Me.GroupBox1.Controls.Add(Me.rdbOtros)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(484, 32)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'rdbAutJudicial
            '
            Me.rdbAutJudicial.AutoSize = True
            Me.rdbAutJudicial.Checked = True
            Me.rdbAutJudicial.Location = New System.Drawing.Point(12, 11)
            Me.rdbAutJudicial.Name = "rdbAutJudicial"
            Me.rdbAutJudicial.Size = New System.Drawing.Size(108, 17)
            Me.rdbAutJudicial.TabIndex = 0
            Me.rdbAutJudicial.TabStop = True
            Me.rdbAutJudicial.Text = "Autoridad Judicial"
            Me.rdbAutJudicial.UseVisualStyleBackColor = True
            '
            'rdbOtros
            '
            Me.rdbOtros.AutoSize = True
            Me.rdbOtros.Location = New System.Drawing.Point(166, 11)
            Me.rdbOtros.Name = "rdbOtros"
            Me.rdbOtros.Size = New System.Drawing.Size(50, 17)
            Me.rdbOtros.TabIndex = 1
            Me.rdbOtros.Text = "Otros"
            Me.rdbOtros.UseVisualStyleBackColor = True
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.pnlObs)
            Me.Panel3.Controls.Add(Me.Panel6)
            Me.Panel3.Controls.Add(Me.pnlSalaJuzgado)
            Me.Panel3.Controls.Add(Me.Panel4)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 32)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(484, 224)
            Me.Panel3.TabIndex = 4
            '
            'pnlObs
            '
            Me.pnlObs.Controls.Add(Me.txtObservacion)
            Me.pnlObs.Controls.Add(Me.Label2)
            Me.pnlObs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlObs.Location = New System.Drawing.Point(0, 156)
            Me.pnlObs.Name = "pnlObs"
            Me.pnlObs.Size = New System.Drawing.Size(484, 68)
            Me.pnlObs.TabIndex = 16
            '
            'txtObservacion
            '
            Me.txtObservacion._BloquearPaste = False
            Me.txtObservacion._SeleccionarTodo = False
            Me.txtObservacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObservacion.Location = New System.Drawing.Point(119, 3)
            Me.txtObservacion.MaxLength = 500
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacion.Size = New System.Drawing.Size(357, 62)
            Me.txtObservacion.TabIndex = 1
            Me.txtObservacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(7, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(104, 20)
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "  Observación doc.:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel6
            '
            Me.Panel6.Controls.Add(Me.txtNumero)
            Me.Panel6.Controls.Add(Me.dtpFechaDoc)
            Me.Panel6.Controls.Add(Me.Label35)
            Me.Panel6.Controls.Add(Me.dtpFechaRecep)
            Me.Panel6.Controls.Add(Me.Label4)
            Me.Panel6.Controls.Add(Me.Label10)
            Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel6.Location = New System.Drawing.Point(0, 101)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(484, 55)
            Me.Panel6.TabIndex = 2
            '
            'txtNumero
            '
            Me.txtNumero._BloquearPaste = False
            Me.txtNumero._SeleccionarTodo = False
            Me.txtNumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNumero.Location = New System.Drawing.Point(119, 5)
            Me.txtNumero.MaxLength = 120
            Me.txtNumero.Name = "txtNumero"
            Me.txtNumero.Size = New System.Drawing.Size(358, 20)
            Me.txtNumero.TabIndex = 1
            Me.txtNumero.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNumero.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpFechaDoc
            '
            Me.dtpFechaDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpFechaDoc.Location = New System.Drawing.Point(393, 32)
            Me.dtpFechaDoc.Name = "dtpFechaDoc"
            Me.dtpFechaDoc.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaDoc.TabIndex = 5
            Me.dtpFechaDoc.Value = "/  /"
            Me.dtpFechaDoc.ValueLong = CType(0, Long)
            '
            'Label35
            '
            Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label35.AutoSize = True
            Me.Label35.Location = New System.Drawing.Point(303, 37)
            Me.Label35.Name = "Label35"
            Me.Label35.Size = New System.Drawing.Size(69, 13)
            Me.Label35.TabIndex = 4
            Me.Label35.Text = "Fecha Doc. :"
            '
            'dtpFechaRecep
            '
            Me.dtpFechaRecep.Location = New System.Drawing.Point(119, 32)
            Me.dtpFechaRecep.Name = "dtpFechaRecep"
            Me.dtpFechaRecep.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaRecep.TabIndex = 3
            Me.dtpFechaRecep.Value = "/  /"
            Me.dtpFechaRecep.ValueLong = CType(0, Long)
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(11, 8)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(76, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Número Doc. :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(11, 35)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 13)
            Me.Label10.TabIndex = 2
            Me.Label10.Text = "Fecha Recep.  Doc. :"
            '
            'pnlSalaJuzgado
            '
            Me.pnlSalaJuzgado.Controls.Add(Me.txtJuez)
            Me.pnlSalaJuzgado.Controls.Add(Me.Label1)
            Me.pnlSalaJuzgado.Controls.Add(Me.txtSecretario)
            Me.pnlSalaJuzgado.Controls.Add(Me.lblSecretario)
            Me.pnlSalaJuzgado.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSalaJuzgado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pnlSalaJuzgado.Location = New System.Drawing.Point(0, 52)
            Me.pnlSalaJuzgado.Name = "pnlSalaJuzgado"
            Me.pnlSalaJuzgado.Size = New System.Drawing.Size(484, 49)
            Me.pnlSalaJuzgado.TabIndex = 1
            '
            'txtJuez
            '
            Me.txtJuez._BloquearPaste = False
            Me.txtJuez._SeleccionarTodo = False
            Me.txtJuez.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtJuez.Location = New System.Drawing.Point(119, 3)
            Me.txtJuez.MaxLength = 120
            Me.txtJuez.Name = "txtJuez"
            Me.txtJuez.Size = New System.Drawing.Size(358, 20)
            Me.txtJuez.TabIndex = 1
            Me.txtJuez.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtJuez.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 32)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(61, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Secretario :"
            '
            'txtSecretario
            '
            Me.txtSecretario._BloquearPaste = False
            Me.txtSecretario._SeleccionarTodo = False
            Me.txtSecretario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtSecretario.Location = New System.Drawing.Point(119, 28)
            Me.txtSecretario.MaxLength = 120
            Me.txtSecretario.Name = "txtSecretario"
            Me.txtSecretario.Size = New System.Drawing.Size(358, 20)
            Me.txtSecretario.TabIndex = 3
            Me.txtSecretario.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtSecretario.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'lblSecretario
            '
            Me.lblSecretario.AutoSize = True
            Me.lblSecretario.Location = New System.Drawing.Point(11, 5)
            Me.lblSecretario.Name = "lblSecretario"
            Me.lblSecretario.Size = New System.Drawing.Size(35, 13)
            Me.lblSecretario.TabIndex = 0
            Me.lblSecretario.Text = "Juez :"
            '
            'Panel4
            '
            Me.Panel4.Controls.Add(Me.cbbAutJudicial)
            Me.Panel4.Controls.Add(Me.lblDistrito)
            Me.Panel4.Controls.Add(Me.cbbSalaJudicial)
            Me.Panel4.Controls.Add(Me.lblSala)
            Me.Panel4.Controls.Add(Me.txtNombreAut)
            Me.Panel4.Controls.Add(Me.txtCargoAut)
            Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Panel4.Location = New System.Drawing.Point(0, 0)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(484, 52)
            Me.Panel4.TabIndex = 0
            '
            'cbbAutJudicial
            '
            Me.cbbAutJudicial._NoIndica = False
            Me.cbbAutJudicial._Todos = False
            Me.cbbAutJudicial._TodosMensaje = ""
            Me.cbbAutJudicial._Visible_Add = False
            Me.cbbAutJudicial._Visible_Buscar = False
            Me.cbbAutJudicial._Visible_Eliminar = False
            Me.cbbAutJudicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbAutJudicial.CodigoPadre = -1
            Me.cbbAutJudicial.ComboTipo = Type.Combo.ComboTipo.AutorizacionJudicial
            Me.cbbAutJudicial.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbAutJudicial.DropDownWidth = 306
            Me.cbbAutJudicial.DropDownWidthAuto = False
            Me.cbbAutJudicial.Location = New System.Drawing.Point(119, 2)
            Me.cbbAutJudicial.Name = "cbbAutJudicial"
            Me.cbbAutJudicial.Parametro1 = -1
            Me.cbbAutJudicial.Parametro2 = -1
            Me.cbbAutJudicial.SelectedIndex = -1
            Me.cbbAutJudicial.SelectedValue = 0
            Me.cbbAutJudicial.Size = New System.Drawing.Size(358, 22)
            Me.cbbAutJudicial.TabIndex = 1
            '
            'lblDistrito
            '
            Me.lblDistrito.AutoSize = True
            Me.lblDistrito.Location = New System.Drawing.Point(11, 6)
            Me.lblDistrito.Name = "lblDistrito"
            Me.lblDistrito.Size = New System.Drawing.Size(83, 13)
            Me.lblDistrito.TabIndex = 0
            Me.lblDistrito.Text = "Distrito Judicial :"
            '
            'cbbSalaJudicial
            '
            Me.cbbSalaJudicial._NoIndica = False
            Me.cbbSalaJudicial._Todos = False
            Me.cbbSalaJudicial._TodosMensaje = ""
            Me.cbbSalaJudicial._Visible_Add = False
            Me.cbbSalaJudicial._Visible_Buscar = False
            Me.cbbSalaJudicial._Visible_Eliminar = False
            Me.cbbSalaJudicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cbbSalaJudicial.CodigoPadre = -1
            Me.cbbSalaJudicial.ComboTipo = Type.Combo.ComboTipo.SalaJusticial
            Me.cbbSalaJudicial.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSalaJudicial.DropDownWidth = 325
            Me.cbbSalaJudicial.DropDownWidthAuto = True
            Me.cbbSalaJudicial.Location = New System.Drawing.Point(119, 27)
            Me.cbbSalaJudicial.Name = "cbbSalaJudicial"
            Me.cbbSalaJudicial.Parametro1 = -1
            Me.cbbSalaJudicial.Parametro2 = -1
            Me.cbbSalaJudicial.SelectedIndex = -1
            Me.cbbSalaJudicial.SelectedValue = 0
            Me.cbbSalaJudicial.Size = New System.Drawing.Size(358, 22)
            Me.cbbSalaJudicial.TabIndex = 3
            '
            'lblSala
            '
            Me.lblSala.AutoSize = True
            Me.lblSala.Location = New System.Drawing.Point(11, 31)
            Me.lblSala.Name = "lblSala"
            Me.lblSala.Size = New System.Drawing.Size(79, 13)
            Me.lblSala.TabIndex = 2
            Me.lblSala.Text = "Sala/Juzgado :"
            '
            'txtNombreAut
            '
            Me.txtNombreAut._BloquearPaste = False
            Me.txtNombreAut._SeleccionarTodo = False
            Me.txtNombreAut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtNombreAut.BackColor = System.Drawing.SystemColors.Window
            Me.txtNombreAut.Location = New System.Drawing.Point(119, 5)
            Me.txtNombreAut.Name = "txtNombreAut"
            Me.txtNombreAut.Size = New System.Drawing.Size(357, 20)
            Me.txtNombreAut.TabIndex = 4
            Me.txtNombreAut.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNombreAut.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtCargoAut
            '
            Me.txtCargoAut._BloquearPaste = False
            Me.txtCargoAut._SeleccionarTodo = False
            Me.txtCargoAut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCargoAut.BackColor = System.Drawing.SystemColors.Window
            Me.txtCargoAut.Location = New System.Drawing.Point(119, 30)
            Me.txtCargoAut.Name = "txtCargoAut"
            Me.txtCargoAut.Size = New System.Drawing.Size(357, 20)
            Me.txtCargoAut.TabIndex = 5
            Me.txtCargoAut.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCargoAut.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(484, 256)
            Me.Panel1.TabIndex = 2
            '
            'uscDocJudicial
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.Panel1)
            Me.Name = "uscDocJudicial"
            Me.Size = New System.Drawing.Size(484, 256)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.pnlObs.ResumeLayout(False)
            Me.pnlObs.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.pnlSalaJuzgado.ResumeLayout(False)
            Me.pnlSalaJuzgado.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents pnlObs As System.Windows.Forms.Panel
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents txtNumero As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaDoc As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label35 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaRecep As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents pnlSalaJuzgado As System.Windows.Forms.Panel
        Friend WithEvents txtJuez As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents lblSala As System.Windows.Forms.Label
        Friend WithEvents txtSecretario As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblSecretario As System.Windows.Forms.Label
        Friend WithEvents txtCargoAut As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents lblDistrito As System.Windows.Forms.Label
        Friend WithEvents txtNombreAut As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtObservacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents cbbAutJudicial As APPControls.uscComboParametrica
        Friend WithEvents cbbSalaJudicial As APPControls.uscComboParametrica
        Friend WithEvents rdbAutJudicial As System.Windows.Forms.RadioButton
        Friend WithEvents rdbOtros As System.Windows.Forms.RadioButton

    End Class
End Namespace