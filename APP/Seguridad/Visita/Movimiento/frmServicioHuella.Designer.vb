Namespace Visita.Movimiento


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmServicioHuella
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
            Me.pnlPie = New System.Windows.Forms.Panel()
            Me.pnlOK = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.pnlCancelar = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.grbBaja = New System.Windows.Forms.GroupBox()
            Me.lblFechaReg = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtMotivo = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblUsuario = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.grbAlta = New System.Windows.Forms.GroupBox()
            Me.lblFechaRegAlta = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtSolucion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.lblUsuarioAlta = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.pnlPie.SuspendLayout()
            Me.pnlOK.SuspendLayout()
            Me.pnlCancelar.SuspendLayout()
            Me.grbBaja.SuspendLayout()
            Me.grbAlta.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.grbAlta)
            Me.gbxFormChildContainer.Controls.Add(Me.pnlPie)
            Me.gbxFormChildContainer.Controls.Add(Me.grbBaja)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(412, 199)
            '
            'pnlPie
            '
            Me.pnlPie.BackColor = System.Drawing.Color.Transparent
            Me.pnlPie.Controls.Add(Me.pnlOK)
            Me.pnlPie.Controls.Add(Me.pnlCancelar)
            Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPie.Location = New System.Drawing.Point(0, 149)
            Me.pnlPie.Name = "pnlPie"
            Me.pnlPie.Size = New System.Drawing.Size(412, 50)
            Me.pnlPie.TabIndex = 29
            '
            'pnlOK
            '
            Me.pnlOK.Controls.Add(Me.btnOk)
            Me.pnlOK.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlOK.Location = New System.Drawing.Point(198, 0)
            Me.pnlOK.Name = "pnlOK"
            Me.pnlOK.Size = New System.Drawing.Size(108, 50)
            Me.pnlOK.TabIndex = 34
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 4)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(102, 40)
            Me.btnOk.TabIndex = 35
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlCancelar
            '
            Me.pnlCancelar.Controls.Add(Me.btnCancel)
            Me.pnlCancelar.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlCancelar.Location = New System.Drawing.Point(306, 0)
            Me.pnlCancelar.Name = "pnlCancelar"
            Me.pnlCancelar.Size = New System.Drawing.Size(106, 50)
            Me.pnlCancelar.TabIndex = 36
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(1, 4)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(102, 40)
            Me.btnCancel.TabIndex = 37
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'grbBaja
            '
            Me.grbBaja.BackColor = System.Drawing.Color.Transparent
            Me.grbBaja.Controls.Add(Me.lblFechaReg)
            Me.grbBaja.Controls.Add(Me.Label3)
            Me.grbBaja.Controls.Add(Me.txtMotivo)
            Me.grbBaja.Controls.Add(Me.Label2)
            Me.grbBaja.Controls.Add(Me.lblUsuario)
            Me.grbBaja.Controls.Add(Me.Label1)
            Me.grbBaja.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbBaja.Location = New System.Drawing.Point(0, 0)
            Me.grbBaja.Name = "grbBaja"
            Me.grbBaja.Size = New System.Drawing.Size(412, 153)
            Me.grbBaja.TabIndex = 30
            Me.grbBaja.TabStop = False
            '
            'lblFechaReg
            '
            Me.lblFechaReg.BackColor = System.Drawing.SystemColors.Control
            Me.lblFechaReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFechaReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaReg.Location = New System.Drawing.Point(82, 20)
            Me.lblFechaReg.Name = "lblFechaReg"
            Me.lblFechaReg.Size = New System.Drawing.Size(138, 22)
            Me.lblFechaReg.TabIndex = 20
            Me.lblFechaReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(12, 80)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(45, 13)
            Me.Label3.TabIndex = 19
            Me.Label3.Text = "Motivo :"
            '
            'txtMotivo
            '
            Me.txtMotivo._BloquearPaste = False
            Me.txtMotivo._SeleccionarTodo = True
            Me.txtMotivo.BackColor = System.Drawing.Color.White
            Me.txtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtMotivo.Location = New System.Drawing.Point(82, 75)
            Me.txtMotivo.MaxLength = 500
            Me.txtMotivo.Multiline = True
            Me.txtMotivo.Name = "txtMotivo"
            Me.txtMotivo.Size = New System.Drawing.Size(266, 69)
            Me.txtMotivo.TabIndex = 18
            Me.txtMotivo.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMotivo.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(12, 52)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(49, 13)
            Me.Label2.TabIndex = 17
            Me.Label2.Text = "Usuario :"
            '
            'lblUsuario
            '
            Me.lblUsuario.BackColor = System.Drawing.SystemColors.Control
            Me.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUsuario.Location = New System.Drawing.Point(82, 47)
            Me.lblUsuario.Name = "lblUsuario"
            Me.lblUsuario.Size = New System.Drawing.Size(266, 22)
            Me.lblUsuario.TabIndex = 16
            Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(12, 24)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(64, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Fecha Baja:"
            '
            'grbAlta
            '
            Me.grbAlta.BackColor = System.Drawing.Color.Transparent
            Me.grbAlta.Controls.Add(Me.lblFechaRegAlta)
            Me.grbAlta.Controls.Add(Me.Label5)
            Me.grbAlta.Controls.Add(Me.txtSolucion)
            Me.grbAlta.Controls.Add(Me.Label6)
            Me.grbAlta.Controls.Add(Me.lblUsuarioAlta)
            Me.grbAlta.Controls.Add(Me.Label8)
            Me.grbAlta.Dock = System.Windows.Forms.DockStyle.Top
            Me.grbAlta.Location = New System.Drawing.Point(0, 153)
            Me.grbAlta.Name = "grbAlta"
            Me.grbAlta.Size = New System.Drawing.Size(412, 153)
            Me.grbAlta.TabIndex = 31
            Me.grbAlta.TabStop = False
            Me.grbAlta.Visible = False
            '
            'lblFechaRegAlta
            '
            Me.lblFechaRegAlta.BackColor = System.Drawing.SystemColors.Control
            Me.lblFechaRegAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblFechaRegAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblFechaRegAlta.Location = New System.Drawing.Point(82, 20)
            Me.lblFechaRegAlta.Name = "lblFechaRegAlta"
            Me.lblFechaRegAlta.Size = New System.Drawing.Size(138, 22)
            Me.lblFechaRegAlta.TabIndex = 20
            Me.lblFechaRegAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(12, 80)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(54, 13)
            Me.Label5.TabIndex = 19
            Me.Label5.Text = "Solucion :"
            '
            'txtSolucion
            '
            Me.txtSolucion._BloquearPaste = False
            Me.txtSolucion._SeleccionarTodo = True
            Me.txtSolucion.BackColor = System.Drawing.Color.White
            Me.txtSolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSolucion.Location = New System.Drawing.Point(82, 75)
            Me.txtSolucion.MaxLength = 500
            Me.txtSolucion.Multiline = True
            Me.txtSolucion.Name = "txtSolucion"
            Me.txtSolucion.Size = New System.Drawing.Size(266, 69)
            Me.txtSolucion.TabIndex = 18
            Me.txtSolucion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtSolucion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(12, 52)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(49, 13)
            Me.Label6.TabIndex = 17
            Me.Label6.Text = "Usuario :"
            '
            'lblUsuarioAlta
            '
            Me.lblUsuarioAlta.BackColor = System.Drawing.SystemColors.Control
            Me.lblUsuarioAlta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.lblUsuarioAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUsuarioAlta.Location = New System.Drawing.Point(82, 47)
            Me.lblUsuarioAlta.Name = "lblUsuarioAlta"
            Me.lblUsuarioAlta.Size = New System.Drawing.Size(266, 22)
            Me.lblUsuarioAlta.TabIndex = 16
            Me.lblUsuarioAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(12, 24)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(61, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "Fecha Alta:"
            '
            'frmServicioHuella
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(412, 199)
            Me.Name = "frmServicioHuella"
            Me.Text = "Desactivar el Servicio de Biometria (Huella Digital)"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.pnlPie.ResumeLayout(False)
            Me.pnlOK.ResumeLayout(False)
            Me.pnlCancelar.ResumeLayout(False)
            Me.grbBaja.ResumeLayout(False)
            Me.grbBaja.PerformLayout()
            Me.grbAlta.ResumeLayout(False)
            Me.grbAlta.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pnlPie As System.Windows.Forms.Panel
        Friend WithEvents pnlOK As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents pnlCancelar As System.Windows.Forms.Panel
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents grbBaja As System.Windows.Forms.GroupBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents lblUsuario As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtMotivo As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents lblFechaReg As System.Windows.Forms.Label
        Friend WithEvents grbAlta As System.Windows.Forms.GroupBox
        Friend WithEvents lblFechaRegAlta As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents txtSolucion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents lblUsuarioAlta As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
    End Class
End Namespace