
Namespace Mantenimiento.Banda
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmMantBandaPopup
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
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbbBandaTipo = New APPControls.uscComboParametrica()
            Me.ComboBox1 = New Legolas.APPUIComponents.MyComboBox(Me.components)
            Me.txtDescripcion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtNombre = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.cbbBandaTipo.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(604, 192)
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(506, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(410, 3)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(94, 40)
            Me.btnAceptar.TabIndex = 0
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnCancel)
            Me.Panel1.Controls.Add(Me.btnAceptar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 146)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(604, 46)
            Me.Panel1.TabIndex = 96
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.cbbBandaTipo)
            Me.GroupBox1.Controls.Add(Me.txtDescripcion)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtNombre)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(604, 146)
            Me.GroupBox1.TabIndex = 98
            Me.GroupBox1.TabStop = False
            '
            'cbbBandaTipo
            '
            Me.cbbBandaTipo._NoIndica = False
            Me.cbbBandaTipo._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbBandaTipo._Todos = False
            Me.cbbBandaTipo._TodosMensaje = ""
            Me.cbbBandaTipo._Visible_Add = False
            Me.cbbBandaTipo._Visible_Buscar = False
            Me.cbbBandaTipo._Visible_Eliminar = False
            Me.cbbBandaTipo.CodigoPadre = -1
            Me.cbbBandaTipo.ComboTipo = Type.Combo.ComboTipo.BandaTipo
            Me.cbbBandaTipo.Controls.Add(Me.ComboBox1)
            Me.cbbBandaTipo.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbBandaTipo.DropDownWidth = 222
            Me.cbbBandaTipo.DropDownWidthAuto = False
            Me.cbbBandaTipo.Location = New System.Drawing.Point(120, 19)
            Me.cbbBandaTipo.Name = "cbbBandaTipo"
            Me.cbbBandaTipo.Parametro1 = -1
            Me.cbbBandaTipo.Parametro2 = -1
            Me.cbbBandaTipo.SelectedIndex = -1
            Me.cbbBandaTipo.SelectedValue = 0
            Me.cbbBandaTipo.Size = New System.Drawing.Size(472, 22)
            Me.cbbBandaTipo.TabIndex = 1
            '
            'ComboBox1
            '
            Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.DropDownWidth = 222
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(472, 21)
            Me.ComboBox1.TabIndex = 2
            '
            'txtDescripcion
            '
            Me.txtDescripcion._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtDescripcion._BloquearPaste = False
            Me.txtDescripcion._SeleccionarTodo = False
            Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDescripcion.Location = New System.Drawing.Point(120, 73)
            Me.txtDescripcion.Multiline = True
            Me.txtDescripcion.Name = "txtDescripcion"
            Me.txtDescripcion.Size = New System.Drawing.Size(472, 67)
            Me.txtDescripcion.TabIndex = 5
            Me.txtDescripcion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDescripcion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(10, 50)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(99, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Nombre de Banda :"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(10, 22)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(31, 13)
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Tipo:"
            '
            'txtNombre
            '
            Me.txtNombre._BackColor_Focus = System.Drawing.SystemColors.Info
            Me.txtNombre._BloquearPaste = False
            Me.txtNombre._SeleccionarTodo = False
            Me.txtNombre.Location = New System.Drawing.Point(120, 47)
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New System.Drawing.Size(472, 20)
            Me.txtNombre.TabIndex = 3
            Me.txtNombre.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Mayusculas
            Me.txtNombre.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(10, 76)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(66, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Descripción:"
            '
            'frmMantBandaPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(604, 192)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "frmMantBandaPopup"
            Me.Text = "Mantenimiento de Bandas y/o Organ. Criminales"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.cbbBandaTipo.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cbbBandaTipo As APPControls.uscComboParametrica
        Friend WithEvents ComboBox1 As Legolas.APPUIComponents.MyComboBox
        Friend WithEvents txtDescripcion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtNombre As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace

