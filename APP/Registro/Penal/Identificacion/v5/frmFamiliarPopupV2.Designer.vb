Namespace Registro.Identificacion.v5

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmFamiliarPopupV2
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
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApeMaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtApePaterno = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.dtpFechaNac = New Legolas.APPUIComponents.uscDateTimePicker()
            Me.gbAlbergado = New System.Windows.Forms.GroupBox()
            Me.rbtNo = New System.Windows.Forms.RadioButton()
            Me.rbtSi = New System.Windows.Forms.RadioButton()
            Me.lblAlbergado = New System.Windows.Forms.Label()
            Me.chkOmitirFecha = New System.Windows.Forms.CheckBox()
            Me.cbbsexo = New APPControls.uscComboParametrica()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.chkHijoRec = New System.Windows.Forms.CheckBox()
            Me.lblFechanac = New System.Windows.Forms.Label()
            Me.cbbTipoFamilia = New APPControls.uscComboParametrica()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chkVive = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.gbAlbergado.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox4)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(362, 285)
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.txtNombre)
            Me.GroupBox4.Controls.Add(Me.txtApeMaterno)
            Me.GroupBox4.Controls.Add(Me.txtApePaterno)
            Me.GroupBox4.Controls.Add(Me.dtpFechaNac)
            Me.GroupBox4.Controls.Add(Me.gbAlbergado)
            Me.GroupBox4.Controls.Add(Me.lblAlbergado)
            Me.GroupBox4.Controls.Add(Me.chkOmitirFecha)
            Me.GroupBox4.Controls.Add(Me.cbbsexo)
            Me.GroupBox4.Controls.Add(Me.Label6)
            Me.GroupBox4.Controls.Add(Me.chkHijoRec)
            Me.GroupBox4.Controls.Add(Me.lblFechanac)
            Me.GroupBox4.Controls.Add(Me.cbbTipoFamilia)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.chkVive)
            Me.GroupBox4.Controls.Add(Me.Label1)
            Me.GroupBox4.Controls.Add(Me.Label2)
            Me.GroupBox4.Controls.Add(Me.Label3)
            Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(362, 285)
            Me.GroupBox4.TabIndex = 0
            Me.GroupBox4.TabStop = False
            '
            'txtNombre
            '
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(102, 96)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(226, 20)
            Me.txtNombre.TabIndex = 8
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApeMaterno
            '
            Me.txtApeMaterno._BloquearPaste = False
            Me.txtApeMaterno._SeleccionarTodo = False
            Me.txtApeMaterno.Location = New System.Drawing.Point(102, 70)
            Me.txtApeMaterno.Name = "txtApeMaterno"
            Me.txtApeMaterno.Size = New System.Drawing.Size(226, 20)
            Me.txtApeMaterno.TabIndex = 6
            Me.txtApeMaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApeMaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'txtApePaterno
            '
            Me.txtApePaterno._BloquearPaste = False
            Me.txtApePaterno._SeleccionarTodo = False
            Me.txtApePaterno.Location = New System.Drawing.Point(102, 44)
            Me.txtApePaterno.Name = "txtApePaterno"
            Me.txtApePaterno.Size = New System.Drawing.Size(226, 20)
            Me.txtApePaterno.TabIndex = 4
            Me.txtApePaterno.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtApePaterno.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Letras
            '
            'dtpFechaNac
            '
            Me.dtpFechaNac.Location = New System.Drawing.Point(102, 147)
            Me.dtpFechaNac.Name = "dtpFechaNac"
            Me.dtpFechaNac.Size = New System.Drawing.Size(84, 21)
            Me.dtpFechaNac.TabIndex = 12
            Me.dtpFechaNac.Value = "/  /"
            Me.dtpFechaNac.ValueLong = CType(0, Long)
            '
            'gbAlbergado
            '
            Me.gbAlbergado.Controls.Add(Me.rbtNo)
            Me.gbAlbergado.Controls.Add(Me.rbtSi)
            Me.gbAlbergado.Location = New System.Drawing.Point(102, 166)
            Me.gbAlbergado.Name = "gbAlbergado"
            Me.gbAlbergado.Size = New System.Drawing.Size(84, 29)
            Me.gbAlbergado.TabIndex = 16
            Me.gbAlbergado.TabStop = False
            '
            'rbtNo
            '
            Me.rbtNo.AutoSize = True
            Me.rbtNo.Checked = True
            Me.rbtNo.Location = New System.Drawing.Point(45, 8)
            Me.rbtNo.Name = "rbtNo"
            Me.rbtNo.Size = New System.Drawing.Size(39, 17)
            Me.rbtNo.TabIndex = 1
            Me.rbtNo.TabStop = True
            Me.rbtNo.Text = "No"
            Me.rbtNo.UseVisualStyleBackColor = True
            '
            'rbtSi
            '
            Me.rbtSi.AutoSize = True
            Me.rbtSi.Location = New System.Drawing.Point(5, 8)
            Me.rbtSi.Name = "rbtSi"
            Me.rbtSi.Size = New System.Drawing.Size(34, 17)
            Me.rbtSi.TabIndex = 0
            Me.rbtSi.Text = "Si"
            Me.rbtSi.UseVisualStyleBackColor = True
            '
            'lblAlbergado
            '
            Me.lblAlbergado.AutoSize = True
            Me.lblAlbergado.Location = New System.Drawing.Point(4, 178)
            Me.lblAlbergado.Name = "lblAlbergado"
            Me.lblAlbergado.Size = New System.Drawing.Size(84, 13)
            Me.lblAlbergado.TabIndex = 15
            Me.lblAlbergado.Text = "Albergado E.P. :"
            '
            'chkOmitirFecha
            '
            Me.chkOmitirFecha.AutoSize = True
            Me.chkOmitirFecha.Location = New System.Drawing.Point(193, 151)
            Me.chkOmitirFecha.Name = "chkOmitirFecha"
            Me.chkOmitirFecha.Size = New System.Drawing.Size(136, 17)
            Me.chkOmitirFecha.TabIndex = 13
            Me.chkOmitirFecha.Text = "Omitir fecha nacimiento"
            Me.chkOmitirFecha.UseVisualStyleBackColor = True
            '
            'cbbsexo
            '
            Me.cbbsexo._NoIndica = False
            Me.cbbsexo._Todos = False
            Me.cbbsexo._TodosMensaje = ""
            Me.cbbsexo._Visible_Add = False
            Me.cbbsexo._Visible_Buscar = False
            Me.cbbsexo._Visible_Eliminar = False
            Me.cbbsexo.CodigoPadre = -1
            Me.cbbsexo.ComboTipo = Type.Combo.ComboTipo.Sexo
            Me.cbbsexo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbsexo.DropDownWidth = 84
            Me.cbbsexo.DropDownWidthAuto = False
            Me.cbbsexo.Location = New System.Drawing.Point(102, 122)
            Me.cbbsexo.Name = "cbbsexo"
            Me.cbbsexo.Parametro1 = -1
            Me.cbbsexo.Parametro2 = -1
            Me.cbbsexo.SelectedIndex = -1
            Me.cbbsexo.SelectedValue = 0
            Me.cbbsexo.Size = New System.Drawing.Size(84, 22)
            Me.cbbsexo.TabIndex = 10
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(4, 126)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(37, 13)
            Me.Label6.TabIndex = 9
            Me.Label6.Text = "Sexo :"
            '
            'chkHijoRec
            '
            Me.chkHijoRec.AutoSize = True
            Me.chkHijoRec.Location = New System.Drawing.Point(193, 174)
            Me.chkHijoRec.Name = "chkHijoRec"
            Me.chkHijoRec.Size = New System.Drawing.Size(156, 17)
            Me.chkHijoRec.TabIndex = 14
            Me.chkHijoRec.Text = "Hijo(a) Albergado en el E.P."
            Me.chkHijoRec.UseVisualStyleBackColor = True
            Me.chkHijoRec.Visible = False
            '
            'lblFechanac
            '
            Me.lblFechanac.AutoSize = True
            Me.lblFechanac.Location = New System.Drawing.Point(4, 150)
            Me.lblFechanac.Name = "lblFechanac"
            Me.lblFechanac.Size = New System.Drawing.Size(69, 13)
            Me.lblFechanac.TabIndex = 11
            Me.lblFechanac.Text = "Fecha Nac. :"
            '
            'cbbTipoFamilia
            '
            Me.cbbTipoFamilia._NoIndica = False
            Me.cbbTipoFamilia._Todos = False
            Me.cbbTipoFamilia._TodosMensaje = ""
            Me.cbbTipoFamilia._Visible_Add = False
            Me.cbbTipoFamilia._Visible_Buscar = False
            Me.cbbTipoFamilia._Visible_Eliminar = False
            Me.cbbTipoFamilia.CodigoPadre = -1
            Me.cbbTipoFamilia.ComboTipo = Type.Combo.ComboTipo.TipoFamilia
            Me.cbbTipoFamilia.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbTipoFamilia.DropDownWidth = 300
            Me.cbbTipoFamilia.DropDownWidthAuto = False
            Me.cbbTipoFamilia.Location = New System.Drawing.Point(102, 17)
            Me.cbbTipoFamilia.Name = "cbbTipoFamilia"
            Me.cbbTipoFamilia.Parametro1 = -1
            Me.cbbTipoFamilia.Parametro2 = -1
            Me.cbbTipoFamilia.SelectedIndex = -1
            Me.cbbTipoFamilia.SelectedValue = 0
            Me.cbbTipoFamilia.Size = New System.Drawing.Size(173, 22)
            Me.cbbTipoFamilia.TabIndex = 1
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(4, 21)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(67, 13)
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Parentesco :"
            '
            'chkVive
            '
            Me.chkVive.AutoSize = True
            Me.chkVive.Location = New System.Drawing.Point(281, 20)
            Me.chkVive.Name = "chkVive"
            Me.chkVive.Size = New System.Drawing.Size(68, 17)
            Me.chkVive.TabIndex = 2
            Me.chkVive.Text = "Fallecido"
            Me.chkVive.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(4, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(90, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Primer Apellido :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(4, 74)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(92, 13)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Segundo Apellido :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(4, 100)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(55, 13)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "Nombres :"
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(100, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 5)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnOk)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(159, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(203, 48)
            Me.Panel1.TabIndex = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.Panel1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 195)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(362, 48)
            Me.Panel2.TabIndex = 1
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 243)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(362, 42)
            Me.UscAuditUser1.TabIndex = 2
            '
            'frmFamiliarPopupV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(362, 285)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmFamiliarPopupV2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Familiares del Interno"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.gbAlbergado.ResumeLayout(False)
            Me.gbAlbergado.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents chkVive As System.Windows.Forms.CheckBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents cbbTipoFamilia As APPControls.uscComboParametrica
        Friend WithEvents dtpFechaNac As Legolas.APPUIComponents.uscDateTimePicker
        Friend WithEvents lblFechanac As System.Windows.Forms.Label
        Friend WithEvents chkHijoRec As System.Windows.Forms.CheckBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents cbbsexo As APPControls.uscComboParametrica
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents chkOmitirFecha As System.Windows.Forms.CheckBox
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents gbAlbergado As System.Windows.Forms.GroupBox
        Friend WithEvents rbtNo As System.Windows.Forms.RadioButton
        Friend WithEvents rbtSi As System.Windows.Forms.RadioButton
        Friend WithEvents lblAlbergado As System.Windows.Forms.Label
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApeMaterno As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtApePaterno As Legolas.APPUIComponents.MyTextBox

    End Class

End Namespace