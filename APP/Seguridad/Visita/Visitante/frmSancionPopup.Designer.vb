Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSancionPopup
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
            Me.chkEstado = New System.Windows.Forms.CheckBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.chkIndeterminado = New Legolas.APPUIComponents.myCheckBox(Me.components)
            Me.cbbTipSan = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDoc = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaIni = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.dtpFechaFin = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dtpFechaSan = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.cbbTipSan.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel3)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(352, 265)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.chkEstado)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 213)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(352, 52)
            Me.Panel1.TabIndex = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOk)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(147, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(205, 52)
            Me.Panel2.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(106, 6)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 9
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(6, 6)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 8
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'chkEstado
            '
            Me.chkEstado.AutoSize = True
            Me.chkEstado.Checked = True
            Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkEstado.Location = New System.Drawing.Point(18, 19)
            Me.chkEstado.Name = "chkEstado"
            Me.chkEstado.Size = New System.Drawing.Size(59, 17)
            Me.chkEstado.TabIndex = 7
            Me.chkEstado.Text = "Estado"
            Me.chkEstado.UseVisualStyleBackColor = True
            Me.chkEstado.Visible = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.chkIndeterminado)
            Me.Panel3.Controls.Add(Me.cbbTipSan)
            Me.Panel3.Controls.Add(Me.Label1)
            Me.Panel3.Controls.Add(Me.txtDoc)
            Me.Panel3.Controls.Add(Me.dtpFechaIni)
            Me.Panel3.Controls.Add(Me.dtpFechaFin)
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Controls.Add(Me.Label5)
            Me.Panel3.Controls.Add(Me.Label3)
            Me.Panel3.Controls.Add(Me.dtpFechaSan)
            Me.Panel3.Controls.Add(Me.txtObs)
            Me.Panel3.Controls.Add(Me.Label6)
            Me.Panel3.Controls.Add(Me.Label7)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(0, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(352, 213)
            Me.Panel3.TabIndex = 73
            '
            'chkIndeterminado
            '
            Me.chkIndeterminado.AutoSize = True
            Me.chkIndeterminado.Location = New System.Drawing.Point(254, 89)
            Me.chkIndeterminado.Name = "chkIndeterminado"
            Me.chkIndeterminado.Size = New System.Drawing.Size(93, 17)
            Me.chkIndeterminado.TabIndex = 4
            Me.chkIndeterminado.Text = "Indeterminado"
            Me.chkIndeterminado.UseVisualStyleBackColor = True
            '
            'cbbTipSan
            '
            Me.cbbTipSan._NoIndica = False
            Me.cbbTipSan._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbTipSan._Todos = False
            Me.cbbTipSan._TodosMensaje = ""
            Me.cbbTipSan._Visible_Add = False
            Me.cbbTipSan._Visible_Buscar = False
            Me.cbbTipSan._Visible_Eliminar = False
            Me.cbbTipSan.CodigoPadre = -1
            Me.cbbTipSan.ComboTipo = CType(44, Short)
            Me.cbbTipSan.Controls.Add(Me.ComboBox1)
            Me.cbbTipSan.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipSan.DropDownWidth = 176
            Me.cbbTipSan.DropDownWidthAuto = False
            Me.cbbTipSan.ListaIdsParaExcluir = Nothing
            Me.cbbTipSan.Location = New System.Drawing.Point(100, 7)
            Me.cbbTipSan.ModuloTratamiento = False
            Me.cbbTipSan.Name = "cbbTipSan"
            Me.cbbTipSan.Parametro1 = -1
            Me.cbbTipSan.Parametro2 = -1
            Me.cbbTipSan.SelectedIndex = -1
            Me.cbbTipSan.SelectedValue = 0
            Me.cbbTipSan.Size = New System.Drawing.Size(238, 22)
            Me.cbbTipSan.TabIndex = 0
            Me.cbbTipSan.verToolTipItemSeleccionado = False
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 176
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(238, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 65)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Fecha Inicio :"
            '
            'txtDoc
            '
            Me.txtDoc._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtDoc._BloquearPaste = False
            Me.txtDoc._SeleccionarTodo = False
            Me.txtDoc.Location = New System.Drawing.Point(100, 111)
            Me.txtDoc.Multiline = True
            Me.txtDoc.Name = "txtDoc"
            Me.txtDoc.Size = New System.Drawing.Size(238, 20)
            Me.txtDoc.TabIndex = 5
            Me.txtDoc.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'dtpFechaIni
            '
            Me.dtpFechaIni.Location = New System.Drawing.Point(100, 62)
            Me.dtpFechaIni.Name = "dtpFechaIni"
            Me.dtpFechaIni.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaIni.TabIndex = 2
            Me.dtpFechaIni.Value = "/  /"
            Me.dtpFechaIni.ValueLong = CType(0, Long)
            '
            'dtpFechaFin
            '
            Me.dtpFechaFin.Location = New System.Drawing.Point(254, 62)
            Me.dtpFechaFin.Name = "dtpFechaFin"
            Me.dtpFechaFin.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaFin.TabIndex = 3
            Me.dtpFechaFin.Value = "/  /"
            Me.dtpFechaFin.ValueLong = CType(0, Long)
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(190, 62)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Fecha Fin :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 114)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(68, 13)
            Me.Label5.TabIndex = 68
            Me.Label5.Text = "Documento :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 37)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 13)
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "Fecha Sancion  :"
            '
            'dtpFechaSan
            '
            Me.dtpFechaSan.Location = New System.Drawing.Point(100, 35)
            Me.dtpFechaSan.Name = "dtpFechaSan"
            Me.dtpFechaSan.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaSan.TabIndex = 1
            Me.dtpFechaSan.Value = "/  /"
            Me.dtpFechaSan.ValueLong = CType(0, Long)
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Location = New System.Drawing.Point(100, 137)
            Me.txtObs.MaxLength = 255
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(238, 65)
            Me.txtObs.TabIndex = 6
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 137)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 13)
            Me.Label6.TabIndex = 17
            Me.Label6.Text = "Observacion :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(6, 10)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(87, 13)
            Me.Label7.TabIndex = 18
            Me.Label7.Text = "Motivo Sancion :"
            '
            'frmSancionPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(352, 265)
            Me.Name = "frmSancionPopup"
            Me.Text = "Mantenimiento de Sancion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            Me.cbbTipSan.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents cbbTipSan As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtDoc As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents dtpFechaIni As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents dtpFechaFin As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpFechaSan As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents chkIndeterminado As Legolas.APPUIComponents.myCheckBox
    End Class
End Namespace