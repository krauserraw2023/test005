Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSeñasPartiPopup
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
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnAceptar = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.cbbNaturaleza = New APPControls.uscComboParametrica()
            Me.cbbForma = New APPControls.uscComboParametrica()
            Me.cbbUbicacion = New APPControls.uscComboParametrica()
            Me.cbbPosicion = New APPControls.uscComboParametrica()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblNumIngreso = New System.Windows.Forms.Label()
            Me.Label37 = New System.Windows.Forms.Label()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.gbxFormChildContainer.SuspendLayout()
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Controls.Add(Me.UscAuditUser1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(378, 318)
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(7, 147)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 13)
            Me.Label6.TabIndex = 106
            Me.Label6.Text = "Observación :"
            '
            'txtObs
            '
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Location = New System.Drawing.Point(10, 163)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(356, 63)
            Me.txtObs.TabIndex = 105
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'NumericUpDown1
            '
            Me.NumericUpDown1.Location = New System.Drawing.Point(88, 119)
            Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
            Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.NumericUpDown1.Name = "NumericUpDown1"
            Me.NumericUpDown1.Size = New System.Drawing.Size(56, 20)
            Me.NumericUpDown1.TabIndex = 104
            Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(7, 123)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 13)
            Me.Label5.TabIndex = 103
            Me.Label5.Text = "Cantidad :"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 226)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(378, 50)
            Me.Panel1.TabIndex = 102
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.btnAceptar)
            Me.Panel3.Controls.Add(Me.btnCancel)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel3.Location = New System.Drawing.Point(166, 0)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(212, 50)
            Me.Panel3.TabIndex = 107
            '
            'btnAceptar
            '
            Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAceptar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnAceptar.Location = New System.Drawing.Point(3, 4)
            Me.btnAceptar.Name = "btnAceptar"
            Me.btnAceptar.Size = New System.Drawing.Size(101, 42)
            Me.btnAceptar.TabIndex = 2
            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(107, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(101, 42)
            Me.btnCancel.TabIndex = 3
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 15)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 13)
            Me.Label1.TabIndex = 93
            Me.Label1.Text = "Naturaleza :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(7, 96)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(53, 13)
            Me.Label3.TabIndex = 98
            Me.Label3.Text = "Posicion :"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 69)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(61, 13)
            Me.Label4.TabIndex = 97
            Me.Label4.Text = "Ubicacion :"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(7, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(42, 13)
            Me.Label2.TabIndex = 96
            Me.Label2.Text = "Forma :"
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.cbbNaturaleza)
            Me.Panel2.Controls.Add(Me.Label2)
            Me.Panel2.Controls.Add(Me.Label6)
            Me.Panel2.Controls.Add(Me.Label4)
            Me.Panel2.Controls.Add(Me.txtObs)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Controls.Add(Me.NumericUpDown1)
            Me.Panel2.Controls.Add(Me.cbbForma)
            Me.Panel2.Controls.Add(Me.Label5)
            Me.Panel2.Controls.Add(Me.cbbUbicacion)
            Me.Panel2.Controls.Add(Me.cbbPosicion)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel2.Location = New System.Drawing.Point(0, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(378, 318)
            Me.Panel2.TabIndex = 109
            '
            'cbbNaturaleza
            '
            Me.cbbNaturaleza._NoIndica = False
            Me.cbbNaturaleza._Todos = False
            Me.cbbNaturaleza._TodosMensaje = ""
            Me.cbbNaturaleza._Visible_Add = False
            Me.cbbNaturaleza._Visible_Buscar = False
            Me.cbbNaturaleza._Visible_Eliminar = False
            Me.cbbNaturaleza.CodigoPadre = -1
            Me.cbbNaturaleza.ComboTipo = Type.Combo.ComboTipo.SenaParticular
            Me.cbbNaturaleza.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbNaturaleza.DropDownWidth = 123
            Me.cbbNaturaleza.DropDownWidthAuto = True
            Me.cbbNaturaleza.Location = New System.Drawing.Point(88, 12)
            Me.cbbNaturaleza.Name = "cbbNaturaleza"
            Me.cbbNaturaleza.Parametro1 = -1
            Me.cbbNaturaleza.Parametro2 = -1
            Me.cbbNaturaleza.SelectedIndex = -1
            Me.cbbNaturaleza.SelectedValue = 0
            Me.cbbNaturaleza.Size = New System.Drawing.Size(278, 22)
            Me.cbbNaturaleza.TabIndex = 95
            '
            'cbbForma
            '
            Me.cbbForma._NoIndica = False
            Me.cbbForma._Todos = False
            Me.cbbForma._TodosMensaje = ""
            Me.cbbForma._Visible_Add = False
            Me.cbbForma._Visible_Buscar = False
            Me.cbbForma._Visible_Eliminar = False
            Me.cbbForma.CodigoPadre = -1
            Me.cbbForma.ComboTipo = Type.Combo.ComboTipo.SenaParticular
            Me.cbbForma.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbForma.DropDownWidth = 123
            Me.cbbForma.DropDownWidthAuto = True
            Me.cbbForma.Location = New System.Drawing.Point(88, 39)
            Me.cbbForma.Name = "cbbForma"
            Me.cbbForma.Parametro1 = -1
            Me.cbbForma.Parametro2 = -1
            Me.cbbForma.SelectedIndex = -1
            Me.cbbForma.SelectedValue = 0
            Me.cbbForma.Size = New System.Drawing.Size(278, 22)
            Me.cbbForma.TabIndex = 99
            '
            'cbbUbicacion
            '
            Me.cbbUbicacion._NoIndica = False
            Me.cbbUbicacion._Todos = False
            Me.cbbUbicacion._TodosMensaje = ""
            Me.cbbUbicacion._Visible_Add = False
            Me.cbbUbicacion._Visible_Buscar = False
            Me.cbbUbicacion._Visible_Eliminar = False
            Me.cbbUbicacion.CodigoPadre = -1
            Me.cbbUbicacion.ComboTipo = Type.Combo.ComboTipo.SenaParticular
            Me.cbbUbicacion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbUbicacion.DropDownWidth = 123
            Me.cbbUbicacion.DropDownWidthAuto = True
            Me.cbbUbicacion.Location = New System.Drawing.Point(88, 65)
            Me.cbbUbicacion.Name = "cbbUbicacion"
            Me.cbbUbicacion.Parametro1 = -1
            Me.cbbUbicacion.Parametro2 = -1
            Me.cbbUbicacion.SelectedIndex = -1
            Me.cbbUbicacion.SelectedValue = 0
            Me.cbbUbicacion.Size = New System.Drawing.Size(278, 22)
            Me.cbbUbicacion.TabIndex = 100
            '
            'cbbPosicion
            '
            Me.cbbPosicion._NoIndica = False
            Me.cbbPosicion._Todos = False
            Me.cbbPosicion._TodosMensaje = ""
            Me.cbbPosicion._Visible_Add = False
            Me.cbbPosicion._Visible_Buscar = False
            Me.cbbPosicion._Visible_Eliminar = False
            Me.cbbPosicion.CodigoPadre = -1
            Me.cbbPosicion.ComboTipo = Type.Combo.ComboTipo.SenaParticular
            Me.cbbPosicion.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbPosicion.DropDownWidth = 123
            Me.cbbPosicion.DropDownWidthAuto = True
            Me.cbbPosicion.Location = New System.Drawing.Point(88, 92)
            Me.cbbPosicion.Name = "cbbPosicion"
            Me.cbbPosicion.Parametro1 = -1
            Me.cbbPosicion.Parametro2 = -1
            Me.cbbPosicion.SelectedIndex = -1
            Me.cbbPosicion.SelectedValue = 0
            Me.cbbPosicion.Size = New System.Drawing.Size(278, 22)
            Me.cbbPosicion.TabIndex = 101
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.lblNumIngreso)
            Me.GroupBox1.Controls.Add(Me.Label37)
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(378, 39)
            Me.GroupBox1.TabIndex = 108
            Me.GroupBox1.TabStop = False
            '
            'lblNumIngreso
            '
            Me.lblNumIngreso.BackColor = System.Drawing.Color.White
            Me.lblNumIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNumIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblNumIngreso.Location = New System.Drawing.Point(167, 12)
            Me.lblNumIngreso.Name = "lblNumIngreso"
            Me.lblNumIngreso.Size = New System.Drawing.Size(58, 20)
            Me.lblNumIngreso.TabIndex = 8
            Me.lblNumIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label37
            '
            Me.Label37.AutoSize = True
            Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label37.Location = New System.Drawing.Point(12, 15)
            Me.Label37.Name = "Label37"
            Me.Label37.Size = New System.Drawing.Size(153, 13)
            Me.Label37.TabIndex = 7
            Me.Label37.Text = "Número de Ingreso del Interno:"
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 276)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(378, 42)
            Me.UscAuditUser1.TabIndex = 107
            '
            'frmSeñasPartiPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(378, 318)
            Me.Name = "frmSeñasPartiPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Mantenimiento de Señas Particulares"
            Me.gbxFormChildContainer.ResumeLayout(False)
            CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbPosicion As APPControls.uscComboParametrica
        Friend WithEvents cbbUbicacion As APPControls.uscComboParametrica
        Friend WithEvents cbbForma As APPControls.uscComboParametrica
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents cbbNaturaleza As APPControls.uscComboParametrica
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents btnAceptar As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents lblNumIngreso As System.Windows.Forms.Label
        Friend WithEvents Label37 As System.Windows.Forms.Label
    End Class
End Namespace