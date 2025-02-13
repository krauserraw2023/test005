Namespace Visita.Visitante

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVisitanteMenorPopup
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
            Me.components = New System.ComponentModel.Container()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.pnlDatosVisitante = New System.Windows.Forms.Panel()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cbbSexo = New APPControls.uscComboParametrica()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.UscFoto1 = New APPControls.Foto.uscFotografia()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCapurar = New System.Windows.Forms.Button()
            Me.btnCancelar = New System.Windows.Forms.Button()
            Me.btnLimpiar = New System.Windows.Forms.Button()
            Me.btnGrabarVisitante = New System.Windows.Forms.Button()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.pnlDatosVisitante.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(510, 316)
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.pnlDatosVisitante)
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox1.Controls.Add(Me.UscFoto1)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtNumDoc)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(510, 257)
            Me.GroupBox1.TabIndex = 5
            Me.GroupBox1.TabStop = False
            '
            'pnlDatosVisitante
            '
            Me.pnlDatosVisitante.Controls.Add(Me.Label9)
            Me.pnlDatosVisitante.Controls.Add(Me.Label4)
            Me.pnlDatosVisitante.Controls.Add(Me.txtApePat)
            Me.pnlDatosVisitante.Controls.Add(Me.txtApeMat)
            Me.pnlDatosVisitante.Controls.Add(Me.Label5)
            Me.pnlDatosVisitante.Controls.Add(Me.Label1)
            Me.pnlDatosVisitante.Controls.Add(Me.txtNom)
            Me.pnlDatosVisitante.Controls.Add(Me.dtpFechaNac)
            Me.pnlDatosVisitante.Controls.Add(Me.Label6)
            Me.pnlDatosVisitante.Controls.Add(Me.Label7)
            Me.pnlDatosVisitante.Controls.Add(Me.cbbSexo)
            Me.pnlDatosVisitante.Controls.Add(Me.cbbNacionalidad)
            Me.pnlDatosVisitante.Enabled = False
            Me.pnlDatosVisitante.Location = New System.Drawing.Point(4, 95)
            Me.pnlDatosVisitante.Name = "pnlDatosVisitante"
            Me.pnlDatosVisitante.Size = New System.Drawing.Size(314, 153)
            Me.pnlDatosVisitante.TabIndex = 99
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(2, 6)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(75, 13)
            Me.Label9.TabIndex = 9
            Me.Label9.Text = "Ape. Paterno :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(2, 31)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(77, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Ape. Materno :"
            '
            'txtApePat
            '
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = False
            Me.txtApePat.Location = New System.Drawing.Point(85, 3)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(208, 20)
            Me.txtApePat.TabIndex = 2
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMat
            '
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = False
            Me.txtApeMat.Location = New System.Drawing.Point(85, 27)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(208, 20)
            Me.txtApeMat.TabIndex = 3
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(2, 55)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Nombres :"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(2, 130)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 82
            Me.Label1.Text = "Fecha Nac :"
            '
            'txtNom
            '
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = False
            Me.txtNom.Location = New System.Drawing.Point(85, 51)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(208, 20)
            Me.txtNom.TabIndex = 4
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(85, 126)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 7
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(2, 78)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Sexo :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(2, 104)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Nacionalidad :"
            '
            'cbbSexo
            '
            Me.cbbSexo._NoIndica = False
            Me.cbbSexo._Todos = False
            Me.cbbSexo._TodosMensaje = ""
            Me.cbbSexo._Visible_Add = False
            Me.cbbSexo._Visible_Buscar = False
            Me.cbbSexo._Visible_Eliminar = False
            Me.cbbSexo.CodigoPadre = -1
            Me.cbbSexo.ComboTipo = Type.Combo.ComboTipo.Sexo
            Me.cbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSexo.DropDownWidth = 81
            Me.cbbSexo.DropDownWidthAuto = False
            Me.cbbSexo.Location = New System.Drawing.Point(85, 75)
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(84, 22)
            Me.cbbSexo.TabIndex = 5
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = Type.Combo.ComboTipo.Nacionalidad
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 81
            Me.cbbNacionalidad.DropDownWidthAuto = True
            Me.cbbNacionalidad.Location = New System.Drawing.Point(85, 101)
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(84, 22)
            Me.cbbNacionalidad.TabIndex = 6
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Location = New System.Drawing.Point(225, 57)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(35, 35)
            Me.btnBuscar.TabIndex = 98
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = Type.Combo.ComboTipo.TipoDoc
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 95
            Me.cbbTipoDoc.DropDownWidthAuto = True
            Me.cbbTipoDoc.Location = New System.Drawing.Point(88, 30)
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(208, 22)
            Me.cbbTipoDoc.TabIndex = 0
            '
            'UscFoto1
            '
            Me.UscFoto1._CheckImagen = True
            Me.UscFoto1._EnabledDobleClick = True
            Me.UscFoto1._HasImagen = False
            Me.UscFoto1._PanelAutorizacion = False
            Me.UscFoto1._PanelCheck = False
            Me.UscFoto1.Location = New System.Drawing.Point(329, 14)
            Me.UscFoto1.Name = "UscFoto1"
            Me.UscFoto1.Size = New System.Drawing.Size(169, 229)
            Me.UscFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscFoto1.TabIndex = 78
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 69)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 13)
            Me.Label10.TabIndex = 1
            Me.Label10.Text = "Num Doc. :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BloquearPaste = True
            Me.txtNumDoc._SeleccionarTodo = False
            Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDoc.Location = New System.Drawing.Point(89, 58)
            Me.txtNumDoc.MaxLength = 8
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(135, 35)
            Me.txtNumDoc.TabIndex = 1
            Me.txtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.btnCancelar)
            Me.Panel1.Controls.Add(Me.btnLimpiar)
            Me.Panel1.Controls.Add(Me.btnGrabarVisitante)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 257)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(510, 59)
            Me.Panel1.TabIndex = 6
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCapurar)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(439, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(71, 59)
            Me.Panel2.TabIndex = 88
            '
            'btnCapurar
            '
            Me.btnCapurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCapurar.ForeColor = System.Drawing.Color.Black
            Me.btnCapurar.Image = Global.SIPPOPE.My.Resources.Resources._1337706653_webcam
            Me.btnCapurar.Location = New System.Drawing.Point(3, 3)
            Me.btnCapurar.Name = "btnCapurar"
            Me.btnCapurar.Size = New System.Drawing.Size(66, 51)
            Me.btnCapurar.TabIndex = 76
            Me.btnCapurar.Text = "Capturar"
            Me.btnCapurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCapurar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancelar.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancelar.Location = New System.Drawing.Point(75, 3)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Size = New System.Drawing.Size(66, 51)
            Me.btnCancelar.TabIndex = 87
            Me.btnCancelar.Text = "&Cancelar"
            Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'btnLimpiar
            '
            Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLimpiar.Image = Global.SIPPOPE.My.Resources.Resources.replace2
            Me.btnLimpiar.Location = New System.Drawing.Point(147, 3)
            Me.btnLimpiar.Name = "btnLimpiar"
            Me.btnLimpiar.Size = New System.Drawing.Size(66, 51)
            Me.btnLimpiar.TabIndex = 86
            Me.btnLimpiar.Text = "&Limpiar"
            Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLimpiar.UseVisualStyleBackColor = True
            '
            'btnGrabarVisitante
            '
            Me.btnGrabarVisitante.Enabled = False
            Me.btnGrabarVisitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnGrabarVisitante.ForeColor = System.Drawing.Color.Black
            Me.btnGrabarVisitante.Image = Global.SIPPOPE.My.Resources.Resources.Drive___USB_32
            Me.btnGrabarVisitante.Location = New System.Drawing.Point(3, 3)
            Me.btnGrabarVisitante.Name = "btnGrabarVisitante"
            Me.btnGrabarVisitante.Size = New System.Drawing.Size(66, 51)
            Me.btnGrabarVisitante.TabIndex = 77
            Me.btnGrabarVisitante.Text = "Grabar"
            Me.btnGrabarVisitante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnGrabarVisitante.UseVisualStyleBackColor = True
            '
            'frmVisitanteMenorPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(510, 316)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmVisitanteMenorPopup"
            Me.Text = "Menores de edad..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.pnlDatosVisitante.ResumeLayout(False)
            Me.pnlDatosVisitante.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents UscFoto1 As APPControls.Foto.uscFotografia
        Friend WithEvents btnGrabarVisitante As System.Windows.Forms.Button
        Friend WithEvents btnCapurar As System.Windows.Forms.Button
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtNom As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtApeMat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePat As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtNumDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents btnLimpiar As System.Windows.Forms.Button
        Friend WithEvents btnCancelar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnBuscar As System.Windows.Forms.Button
        Friend WithEvents pnlDatosVisitante As System.Windows.Forms.Panel
    End Class
End Namespace