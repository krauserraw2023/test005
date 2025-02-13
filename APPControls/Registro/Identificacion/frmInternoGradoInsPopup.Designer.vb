Namespace Registro.Identificacion
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInternoGradoInsPopup
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
            Me.btnOK = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtObs = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.cbbGradoInst = New APPControls.uscComboParametrica()
            Me.lblNroIngreso = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.lblNroIngreso)
            Me.gbxFormChildContainer.Controls.Add(Me.Label3)
            Me.gbxFormChildContainer.Controls.Add(Me.txtObs)
            Me.gbxFormChildContainer.Controls.Add(Me.cbbGradoInst)
            Me.gbxFormChildContainer.Controls.Add(Me.Label2)
            Me.gbxFormChildContainer.Controls.Add(Me.Label1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(473, 199)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 153)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(473, 46)
            Me.Panel1.TabIndex = 1
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Controls.Add(Me.btnOK)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(269, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(204, 46)
            Me.Panel2.TabIndex = 7
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.APPControls.My.Resources.Resources.anular2
            Me.btnCancel.Location = New System.Drawing.Point(104, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 97
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnOK
            '
            Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOK.Image = Global.APPControls.My.Resources.Resources.accept_32
            Me.btnOK.Location = New System.Drawing.Point(4, 3)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(94, 40)
            Me.btnOK.TabIndex = 96
            Me.btnOK.Text = "&Aceptar"
            Me.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 36)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(94, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Grado Instrucción:"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(33, 69)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(70, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Observación:"
            '
            'txtObs
            '
            Me.txtObs._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtObs._BloquearPaste = False
            Me.txtObs._SeleccionarTodo = False
            Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtObs.Location = New System.Drawing.Point(108, 60)
            Me.txtObs.MaxLength = 500
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObs.Size = New System.Drawing.Size(358, 89)
            Me.txtObs.TabIndex = 6
            Me.txtObs.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObs.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'cbbGradoInst
            '
            Me.cbbGradoInst._NoIndica = False
            Me.cbbGradoInst._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.cbbGradoInst._Todos = False
            Me.cbbGradoInst._TodosMensaje = ""
            Me.cbbGradoInst._Visible_Add = False
            Me.cbbGradoInst._Visible_Buscar = False
            Me.cbbGradoInst._Visible_Eliminar = False
            Me.cbbGradoInst.CodigoPadre = -1
            Me.cbbGradoInst.ComboTipo = CType(9, Short)
            Me.cbbGradoInst.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.cbbGradoInst.DropDownWidth = 143
            Me.cbbGradoInst.DropDownWidthAuto = False
            Me.cbbGradoInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbGradoInst.ListaIdsParaExcluir = Nothing
            Me.cbbGradoInst.Location = New System.Drawing.Point(108, 32)
            Me.cbbGradoInst.ModuloTratamiento = False
            Me.cbbGradoInst.Name = "cbbGradoInst"
            Me.cbbGradoInst.Parametro1 = -1
            Me.cbbGradoInst.Parametro2 = -1
            Me.cbbGradoInst.SelectedIndex = -1
            Me.cbbGradoInst.SelectedValue = 0
            Me.cbbGradoInst.Size = New System.Drawing.Size(358, 22)
            Me.cbbGradoInst.TabIndex = 3
            '
            'lblNroIngreso
            '
            Me.lblNroIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblNroIngreso.Location = New System.Drawing.Point(108, 9)
            Me.lblNroIngreso.Name = "lblNroIngreso"
            Me.lblNroIngreso.Size = New System.Drawing.Size(212, 20)
            Me.lblNroIngreso.TabIndex = 8
            Me.lblNroIngreso.Text = "01"
            Me.lblNroIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(43, 10)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 13)
            Me.Label3.TabIndex = 7
            Me.Label3.Text = "N° Ingreso:"
            '
            'frmInternoGradoInsPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(473, 199)
            Me.Name = "frmInternoGradoInsPopup"
            Me.Text = "Mantenimiento de grado de instrucción."
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.gbxFormChildContainer.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents btnOK As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents cbbGradoInst As APPControls.uscComboParametrica
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents txtObs As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblNroIngreso As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
    End Class
End Namespace