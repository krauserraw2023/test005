
Namespace Mantenimiento.Registro.Sala
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmSalaPopup
        Inherits Legolas.APPUIComponents.FormPopup

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCodDisJud = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtCodSala = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.rbInactivo = New System.Windows.Forms.RadioButton()
            Me.rbHistorico = New System.Windows.Forms.RadioButton()
            Me.rbVigente = New System.Windows.Forms.RadioButton()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.rdbCallao = New System.Windows.Forms.RadioButton()
            Me.rdbLima = New System.Windows.Forms.RadioButton()
            Me.rdbOtros = New System.Windows.Forms.RadioButton()
            Me.txtNomCorto = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.cbbDistritoJud = New APPControls.uscComboParametrica()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.Button1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(617, 253)
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(13, 51)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(119, 13)
            Me.Label2.TabIndex = 92
            Me.Label2.Text = "Código Distrito Judicial :"
            '
            'txtCodDisJud
            '
            Me.txtCodDisJud._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtCodDisJud._BloquearPaste = False
            Me.txtCodDisJud._SeleccionarTodo = False
            Me.txtCodDisJud.Location = New System.Drawing.Point(212, 48)
            Me.txtCodDisJud.Name = "txtCodDisJud"
            Me.txtCodDisJud.ReadOnly = True
            Me.txtCodDisJud.Size = New System.Drawing.Size(86, 20)
            Me.txtCodDisJud.TabIndex = 93
            Me.txtCodDisJud.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodDisJud.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(378, 47)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(126, 13)
            Me.Label1.TabIndex = 90
            Me.Label1.Text = "Código del Juzgado/Sala"
            '
            'txtCodSala
            '
            Me.txtCodSala._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtCodSala._BloquearPaste = False
            Me.txtCodSala._SeleccionarTodo = False
            Me.txtCodSala.Location = New System.Drawing.Point(514, 44)
            Me.txtCodSala.Name = "txtCodSala"
            Me.txtCodSala.Size = New System.Drawing.Size(86, 20)
            Me.txtCodSala.TabIndex = 91
            Me.txtCodSala.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCodSala.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(13, 76)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(167, 13)
            Me.Label3.TabIndex = 86
            Me.Label3.Text = "Denominación del Juzgado/Sala :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(13, 24)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(83, 13)
            Me.Label11.TabIndex = 87
            Me.Label11.Text = "Distrito Judicial :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(212, 74)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(388, 20)
            Me.txtNom.TabIndex = 89
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(504, 8)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 95
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(404, 8)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 94
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOK)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 196)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(617, 57)
            Me.Panel1.TabIndex = 96
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.GroupBox4)
            Me.GroupBox1.Controls.Add(Me.GroupBox3)
            Me.GroupBox1.Controls.Add(Me.cbbDistritoJud)
            Me.GroupBox1.Controls.Add(Me.txtNomCorto)
            Me.GroupBox1.Controls.Add(Me.txtNom)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtCodDisJud)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.txtCodSala)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(617, 196)
            Me.GroupBox1.TabIndex = 97
            Me.GroupBox1.TabStop = False
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.rbInactivo)
            Me.GroupBox4.Controls.Add(Me.rbHistorico)
            Me.GroupBox4.Controls.Add(Me.rbVigente)
            Me.GroupBox4.Location = New System.Drawing.Point(16, 136)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(312, 40)
            Me.GroupBox4.TabIndex = 101
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Estado"
            '
            'rbInactivo
            '
            Me.rbInactivo.AutoSize = True
            Me.rbInactivo.Location = New System.Drawing.Point(228, 15)
            Me.rbInactivo.Name = "rbInactivo"
            Me.rbInactivo.Size = New System.Drawing.Size(63, 17)
            Me.rbInactivo.TabIndex = 83
            Me.rbInactivo.Text = "Inactivo"
            Me.rbInactivo.UseVisualStyleBackColor = True
            '
            'rbHistorico
            '
            Me.rbHistorico.AutoSize = True
            Me.rbHistorico.Location = New System.Drawing.Point(136, 15)
            Me.rbHistorico.Name = "rbHistorico"
            Me.rbHistorico.Size = New System.Drawing.Size(66, 17)
            Me.rbHistorico.TabIndex = 82
            Me.rbHistorico.Text = "Historico"
            Me.rbHistorico.UseVisualStyleBackColor = True
            '
            'rbVigente
            '
            Me.rbVigente.AutoSize = True
            Me.rbVigente.Checked = True
            Me.rbVigente.Location = New System.Drawing.Point(51, 15)
            Me.rbVigente.Name = "rbVigente"
            Me.rbVigente.Size = New System.Drawing.Size(61, 17)
            Me.rbVigente.TabIndex = 0
            Me.rbVigente.TabStop = True
            Me.rbVigente.Text = "Vigente"
            Me.rbVigente.UseVisualStyleBackColor = True
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.rdbCallao)
            Me.GroupBox3.Controls.Add(Me.rdbLima)
            Me.GroupBox3.Controls.Add(Me.rdbOtros)
            Me.GroupBox3.Location = New System.Drawing.Point(334, 136)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(266, 40)
            Me.GroupBox3.TabIndex = 100
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Jurisdicción"
            '
            'rdbCallao
            '
            Me.rdbCallao.AutoSize = True
            Me.rdbCallao.Location = New System.Drawing.Point(188, 16)
            Me.rdbCallao.Name = "rdbCallao"
            Me.rdbCallao.Size = New System.Drawing.Size(54, 17)
            Me.rdbCallao.TabIndex = 2
            Me.rdbCallao.Text = "Callao"
            Me.rdbCallao.UseVisualStyleBackColor = True
            '
            'rdbLima
            '
            Me.rdbLima.AutoSize = True
            Me.rdbLima.Location = New System.Drawing.Point(100, 17)
            Me.rdbLima.Name = "rdbLima"
            Me.rdbLima.Size = New System.Drawing.Size(47, 17)
            Me.rdbLima.TabIndex = 1
            Me.rdbLima.Text = "Lima"
            Me.rdbLima.UseVisualStyleBackColor = True
            '
            'rdbOtros
            '
            Me.rdbOtros.AutoSize = True
            Me.rdbOtros.Checked = True
            Me.rdbOtros.Location = New System.Drawing.Point(13, 17)
            Me.rdbOtros.Name = "rdbOtros"
            Me.rdbOtros.Size = New System.Drawing.Size(50, 17)
            Me.rdbOtros.TabIndex = 0
            Me.rdbOtros.TabStop = True
            Me.rdbOtros.Text = "Otros"
            Me.rdbOtros.UseVisualStyleBackColor = True
            '
            'txtNomCorto
            '
            Me.txtNomCorto._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtNomCorto._BloquearPaste = False
            Me.txtNomCorto._SeleccionarTodo = False
            Me.txtNomCorto.Location = New System.Drawing.Point(212, 101)
            Me.txtNomCorto.MaxLength = 20
            Me.txtNomCorto.Name = "txtNomCorto"
            Me.txtNomCorto.Size = New System.Drawing.Size(388, 20)
            Me.txtNomCorto.TabIndex = 89
            Me.txtNomCorto.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNomCorto.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(13, 105)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(194, 13)
            Me.Label4.TabIndex = 86
            Me.Label4.Text = "Denominación corta del Juzgado/Sala :"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(148, 56)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(201, 74)
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'cbbDistritoJud
            '
            Me.cbbDistritoJud._NoIndica = False
            Me.cbbDistritoJud._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbDistritoJud._Todos = False
            Me.cbbDistritoJud._TodosMensaje = ""
            Me.cbbDistritoJud._Visible_Add = False
            Me.cbbDistritoJud._Visible_Buscar = False
            Me.cbbDistritoJud._Visible_Eliminar = False
            Me.cbbDistritoJud.CodigoPadre = -1
            Me.cbbDistritoJud.ComboTipo = CType(15, Short)
            Me.cbbDistritoJud.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbDistritoJud.DropDownWidth = 222
            Me.cbbDistritoJud.DropDownWidthAuto = False
            Me.cbbDistritoJud.ListaIdsParaExcluir = Nothing
            Me.cbbDistritoJud.Location = New System.Drawing.Point(212, 19)
            Me.cbbDistritoJud.ModuloTratamiento = False
            Me.cbbDistritoJud.Name = "cbbDistritoJud"
            Me.cbbDistritoJud.Parametro1 = -1
            Me.cbbDistritoJud.Parametro2 = -1
            Me.cbbDistritoJud.SelectedIndex = -1
            Me.cbbDistritoJud.SelectedValue = 0
            Me.cbbDistritoJud.Size = New System.Drawing.Size(388, 22)
            Me.cbbDistritoJud.TabIndex = 88
            '
            'frmSalaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(617, 253)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmSalaPopup"
            Me.Text = "Mantenimiento de Juzgados/Salas "
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtCodDisJud As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtCodSala As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents cbbDistritoJud As APPControls.uscComboParametrica
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtNomCorto As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents GroupBox3 As GroupBox
        Friend WithEvents rdbCallao As RadioButton
        Friend WithEvents rdbLima As RadioButton
        Friend WithEvents rdbOtros As RadioButton
        Friend WithEvents GroupBox4 As GroupBox
        Friend WithEvents rbInactivo As RadioButton
        Friend WithEvents rbHistorico As RadioButton
        Friend WithEvents rbVigente As RadioButton
    End Class
End Namespace

