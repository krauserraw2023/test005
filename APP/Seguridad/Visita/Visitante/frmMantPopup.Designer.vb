Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantPopup
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
            Me.components = New System.ComponentModel.Container()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnBuscar = New System.Windows.Forms.Button()
            Me.lblEtiqueta = New System.Windows.Forms.Label()
            Me.chkMenorEdad = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtNom = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtApeMat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApePat = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtNumDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
            Me.cbbTipoDoc = New APPControls.uscComboParametrica()
            Me.cbbSexo = New APPControls.uscComboParametrica()
            Me.cbbNacionalidad = New APPControls.uscComboParametrica()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(346, 265)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 219)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(346, 46)
            Me.Panel1.TabIndex = 1
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(141, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(205, 46)
            Me.Panel2.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(106, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 11
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(6, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 10
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'GroupBox1
            '
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.btnBuscar)
            Me.GroupBox1.Controls.Add(Me.lblEtiqueta)
            Me.GroupBox1.Controls.Add(Me.chkMenorEdad)
            Me.GroupBox1.Controls.Add(Me.cbbTipoDoc)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.dtpFechaNac)
            Me.GroupBox1.Controls.Add(Me.cbbSexo)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtNom)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtApeMat)
            Me.GroupBox1.Controls.Add(Me.txtApePat)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtNumDoc)
            Me.GroupBox1.Controls.Add(Me.cbbNacionalidad)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(346, 219)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            '
            'btnBuscar
            '
            Me.btnBuscar.BackgroundImage = Global.SIPPOPE.My.Resources.Resources.view
            Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBuscar.ForeColor = System.Drawing.Color.Black
            Me.btnBuscar.Location = New System.Drawing.Point(272, 26)
            Me.btnBuscar.Name = "btnBuscar"
            Me.btnBuscar.Size = New System.Drawing.Size(25, 28)
            Me.btnBuscar.TabIndex = 3
            Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBuscar.UseVisualStyleBackColor = True
            '
            'lblEtiqueta
            '
            Me.lblEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblEtiqueta.ForeColor = System.Drawing.Color.Red
            Me.lblEtiqueta.Location = New System.Drawing.Point(181, 140)
            Me.lblEtiqueta.Name = "lblEtiqueta"
            Me.lblEtiqueta.Size = New System.Drawing.Size(146, 42)
            Me.lblEtiqueta.TabIndex = 100
            Me.lblEtiqueta.Text = "xxxxxxxxx"
            Me.lblEtiqueta.Visible = False
            '
            'chkMenorEdad
            '
            Me.chkMenorEdad.AutoSize = True
            Me.chkMenorEdad.CheckAlign = System.Drawing.ContentAlignment.TopCenter
            Me.chkMenorEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkMenorEdad.ForeColor = System.Drawing.Color.Red
            Me.chkMenorEdad.Location = New System.Drawing.Point(303, 29)
            Me.chkMenorEdad.Name = "chkMenorEdad"
            Me.chkMenorEdad.Size = New System.Drawing.Size(41, 42)
            Me.chkMenorEdad.TabIndex = 0
            Me.chkMenorEdad.Text = "Menor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de edad"
            Me.chkMenorEdad.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 195)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(66, 13)
            Me.Label1.TabIndex = 82
            Me.Label1.Text = "Fecha Nac :"
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(89, 190)
            Me.dtpFechaNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 9
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(6, 166)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(75, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Nacionalidad :"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 140)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Sexo :"
            '
            'txtNom
            '
            Me.txtNom._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNom._BloquearPaste = False
            Me.txtNom._SeleccionarTodo = True
            Me.txtNom.Location = New System.Drawing.Point(89, 113)
            Me.txtNom.Name = "txtNom"
            Me.txtNom.Size = New System.Drawing.Size(208, 20)
            Me.txtNom.TabIndex = 6
            Me.txtNom.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNom.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 117)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Nombres :"
            '
            'txtApeMat
            '
            Me.txtApeMat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApeMat._BloquearPaste = False
            Me.txtApeMat._SeleccionarTodo = True
            Me.txtApeMat.Location = New System.Drawing.Point(89, 89)
            Me.txtApeMat.Name = "txtApeMat"
            Me.txtApeMat.Size = New System.Drawing.Size(208, 20)
            Me.txtApeMat.TabIndex = 5
            Me.txtApeMat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApeMat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApePat
            '
            Me.txtApePat._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtApePat._BloquearPaste = False
            Me.txtApePat._SeleccionarTodo = True
            Me.txtApePat.Location = New System.Drawing.Point(89, 65)
            Me.txtApePat.Name = "txtApePat"
            Me.txtApePat.Size = New System.Drawing.Size(208, 20)
            Me.txtApePat.TabIndex = 4
            Me.txtApePat.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtApePat.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 93)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(77, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Ape. Materno :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(6, 60)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(75, 13)
            Me.Label9.TabIndex = 9
            Me.Label9.Text = "Ape. Paterno :"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 35)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(61, 13)
            Me.Label10.TabIndex = 3
            Me.Label10.Text = "Num Doc. :"
            '
            'txtNumDoc
            '
            Me.txtNumDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtNumDoc._BloquearPaste = False
            Me.txtNumDoc._SeleccionarTodo = True
            Me.txtNumDoc.BackColor = System.Drawing.Color.White
            Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtNumDoc.ForeColor = System.Drawing.Color.Black
            Me.txtNumDoc.Location = New System.Drawing.Point(158, 27)
            Me.txtNumDoc.MaxLength = 8
            Me.txtNumDoc.Name = "txtNumDoc"
            Me.txtNumDoc.Size = New System.Drawing.Size(114, 26)
            Me.txtNumDoc.TabIndex = 2
            Me.txtNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.txtNumDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            '
            'BackgroundWorker1
            '
            '
            'BackgroundWorker2
            '
            Me.BackgroundWorker2.WorkerSupportsCancellation = True
            '
            'cbbTipoDoc
            '
            Me.cbbTipoDoc._NoIndica = False
            Me.cbbTipoDoc._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipoDoc._Todos = False
            Me.cbbTipoDoc._TodosMensaje = ""
            Me.cbbTipoDoc._Visible_Add = False
            Me.cbbTipoDoc._Visible_Buscar = False
            Me.cbbTipoDoc._Visible_Eliminar = False
            Me.cbbTipoDoc.CodigoPadre = -1
            Me.cbbTipoDoc.ComboTipo = CType(2, Short)
            Me.cbbTipoDoc.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoDoc.DropDownWidth = 95
            Me.cbbTipoDoc.DropDownWidthAuto = True
            Me.cbbTipoDoc.ListaIdsParaExcluir = Nothing
            Me.cbbTipoDoc.Location = New System.Drawing.Point(89, 31)
            Me.cbbTipoDoc.Margin = New System.Windows.Forms.Padding(4)
            Me.cbbTipoDoc.ModuloTratamiento = False
            Me.cbbTipoDoc.Name = "cbbTipoDoc"
            Me.cbbTipoDoc.Parametro1 = -1
            Me.cbbTipoDoc.Parametro2 = -1
            Me.cbbTipoDoc.SelectedIndex = -1
            Me.cbbTipoDoc.SelectedValue = 0
            Me.cbbTipoDoc.Size = New System.Drawing.Size(67, 22)
            Me.cbbTipoDoc.TabIndex = 1
            Me.cbbTipoDoc.verToolTipItemSeleccionado = False
            '
            'cbbSexo
            '
            Me.cbbSexo._NoIndica = False
            Me.cbbSexo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbSexo._Todos = False
            Me.cbbSexo._TodosMensaje = ""
            Me.cbbSexo._Visible_Add = False
            Me.cbbSexo._Visible_Buscar = False
            Me.cbbSexo._Visible_Eliminar = False
            Me.cbbSexo.CodigoPadre = -1
            Me.cbbSexo.ComboTipo = CType(1, Short)
            Me.cbbSexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbSexo.DropDownWidth = 81
            Me.cbbSexo.DropDownWidthAuto = False
            Me.cbbSexo.ListaIdsParaExcluir = Nothing
            Me.cbbSexo.Location = New System.Drawing.Point(89, 137)
            Me.cbbSexo.Margin = New System.Windows.Forms.Padding(4)
            Me.cbbSexo.ModuloTratamiento = False
            Me.cbbSexo.Name = "cbbSexo"
            Me.cbbSexo.Parametro1 = -1
            Me.cbbSexo.Parametro2 = -1
            Me.cbbSexo.SelectedIndex = -1
            Me.cbbSexo.SelectedValue = 0
            Me.cbbSexo.Size = New System.Drawing.Size(84, 22)
            Me.cbbSexo.TabIndex = 7
            Me.cbbSexo.verToolTipItemSeleccionado = False
            '
            'cbbNacionalidad
            '
            Me.cbbNacionalidad._NoIndica = False
            Me.cbbNacionalidad._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbNacionalidad._Todos = False
            Me.cbbNacionalidad._TodosMensaje = ""
            Me.cbbNacionalidad._Visible_Add = False
            Me.cbbNacionalidad._Visible_Buscar = False
            Me.cbbNacionalidad._Visible_Eliminar = False
            Me.cbbNacionalidad.CodigoPadre = -1
            Me.cbbNacionalidad.ComboTipo = CType(4, Short)
            Me.cbbNacionalidad.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNacionalidad.DropDownWidth = 81
            Me.cbbNacionalidad.DropDownWidthAuto = True
            Me.cbbNacionalidad.ListaIdsParaExcluir = Nothing
            Me.cbbNacionalidad.Location = New System.Drawing.Point(89, 164)
            Me.cbbNacionalidad.Margin = New System.Windows.Forms.Padding(4)
            Me.cbbNacionalidad.ModuloTratamiento = False
            Me.cbbNacionalidad.Name = "cbbNacionalidad"
            Me.cbbNacionalidad.Parametro1 = -1
            Me.cbbNacionalidad.Parametro2 = -1
            Me.cbbNacionalidad.SelectedIndex = -1
            Me.cbbNacionalidad.SelectedValue = 0
            Me.cbbNacionalidad.Size = New System.Drawing.Size(84, 22)
            Me.cbbNacionalidad.TabIndex = 8
            Me.cbbNacionalidad.verToolTipItemSeleccionado = False
            '
            'frmMantPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(346, 265)
            Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.Name = "frmMantPopup"
            Me.Text = "Mantenimiento de Visitantes..."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbTipoDoc As APPControls.uscComboParametrica
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents cbbSexo As APPControls.uscComboParametrica
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
        Friend WithEvents cbbNacionalidad As APPControls.uscComboParametrica
        Friend WithEvents chkMenorEdad As System.Windows.Forms.CheckBox
        Friend WithEvents lblEtiqueta As Label
        Friend WithEvents btnBuscar As Button
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    End Class

End Namespace