Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmSancionAnuladoPopup
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtDocumentoSancion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtObservacionSancion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtMotivoAnulacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtObservacionAnulacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtDocumentoAnulacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtFechaFin = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaInicio = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtFechaSancion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.txtMotivoSancion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtFechaAnulacion = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label10 = New System.Windows.Forms.Label()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox2)
            Me.gbxFormChildContainer.Controls.Add(Me.GroupBox1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(389, 385)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 337)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(389, 48)
            Me.Panel1.TabIndex = 0
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(284, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(105, 48)
            Me.Panel2.TabIndex = 0
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(4, 5)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(94, 40)
            Me.btnCancel.TabIndex = 9
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(6, 75)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(71, 13)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Fecha Inicio :"
            '
            'txtDocumentoSancion
            '
            Me.txtDocumentoSancion._BloquearPaste = False
            Me.txtDocumentoSancion._SeleccionarTodo = False
            Me.txtDocumentoSancion.Location = New System.Drawing.Point(135, 100)
            Me.txtDocumentoSancion.Multiline = True
            Me.txtDocumentoSancion.Name = "txtDocumentoSancion"
            Me.txtDocumentoSancion.Size = New System.Drawing.Size(238, 20)
            Me.txtDocumentoSancion.TabIndex = 5
            Me.txtDocumentoSancion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDocumentoSancion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(225, 75)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(60, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Fecha Fin :"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(6, 103)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(68, 13)
            Me.Label5.TabIndex = 68
            Me.Label5.Text = "Documento :"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(6, 47)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(88, 13)
            Me.Label3.TabIndex = 13
            Me.Label3.Text = "Fecha Sancion  :"
            '
            'txtObservacionSancion
            '
            Me.txtObservacionSancion._BloquearPaste = False
            Me.txtObservacionSancion._SeleccionarTodo = False
            Me.txtObservacionSancion.Location = New System.Drawing.Point(135, 126)
            Me.txtObservacionSancion.MaxLength = 255
            Me.txtObservacionSancion.Multiline = True
            Me.txtObservacionSancion.Name = "txtObservacionSancion"
            Me.txtObservacionSancion.Size = New System.Drawing.Size(238, 65)
            Me.txtObservacionSancion.TabIndex = 6
            Me.txtObservacionSancion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacionSancion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(6, 126)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(73, 13)
            Me.Label6.TabIndex = 17
            Me.Label6.Text = "Observacion :"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(6, 20)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(87, 13)
            Me.Label7.TabIndex = 18
            Me.Label7.Text = "Motivo Sancion :"
            '
            'txtMotivoAnulacion
            '
            Me.txtMotivoAnulacion._BloquearPaste = False
            Me.txtMotivoAnulacion._SeleccionarTodo = False
            Me.txtMotivoAnulacion.Location = New System.Drawing.Point(135, 43)
            Me.txtMotivoAnulacion.Multiline = True
            Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
            Me.txtMotivoAnulacion.Size = New System.Drawing.Size(238, 20)
            Me.txtMotivoAnulacion.TabIndex = 5
            Me.txtMotivoAnulacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMotivoAnulacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(6, 47)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(95, 13)
            Me.Label4.TabIndex = 4
            Me.Label4.Text = "Motivo Anulacion :"
            '
            'txtObservacionAnulacion
            '
            Me.txtObservacionAnulacion._BloquearPaste = False
            Me.txtObservacionAnulacion._SeleccionarTodo = False
            Me.txtObservacionAnulacion.Location = New System.Drawing.Point(135, 69)
            Me.txtObservacionAnulacion.Multiline = True
            Me.txtObservacionAnulacion.Name = "txtObservacionAnulacion"
            Me.txtObservacionAnulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtObservacionAnulacion.Size = New System.Drawing.Size(237, 37)
            Me.txtObservacionAnulacion.TabIndex = 3
            Me.txtObservacionAnulacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtObservacionAnulacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtDocumentoAnulacion
            '
            Me.txtDocumentoAnulacion._BloquearPaste = False
            Me.txtDocumentoAnulacion._SeleccionarTodo = False
            Me.txtDocumentoAnulacion.Location = New System.Drawing.Point(135, 17)
            Me.txtDocumentoAnulacion.Multiline = True
            Me.txtDocumentoAnulacion.Name = "txtDocumentoAnulacion"
            Me.txtDocumentoAnulacion.Size = New System.Drawing.Size(237, 20)
            Me.txtDocumentoAnulacion.TabIndex = 1
            Me.txtDocumentoAnulacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtDocumentoAnulacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(6, 21)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(118, 13)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "Documento Anulacion :"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(6, 74)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(123, 13)
            Me.Label9.TabIndex = 2
            Me.Label9.Text = "Observacion Anulacion :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.txtFechaFin)
            Me.GroupBox1.Controls.Add(Me.txtFechaInicio)
            Me.GroupBox1.Controls.Add(Me.txtFechaSancion)
            Me.GroupBox1.Controls.Add(Me.txtMotivoSancion)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.txtDocumentoSancion)
            Me.GroupBox1.Controls.Add(Me.txtObservacionSancion)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(389, 196)
            Me.GroupBox1.TabIndex = 75
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Sancion"
            '
            'txtFechaFin
            '
            Me.txtFechaFin._BloquearPaste = False
            Me.txtFechaFin._SeleccionarTodo = False
            Me.txtFechaFin.Location = New System.Drawing.Point(288, 73)
            Me.txtFechaFin.Multiline = True
            Me.txtFechaFin.Name = "txtFechaFin"
            Me.txtFechaFin.Size = New System.Drawing.Size(84, 20)
            Me.txtFechaFin.TabIndex = 72
            Me.txtFechaFin.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaFin.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtFechaInicio
            '
            Me.txtFechaInicio._BloquearPaste = False
            Me.txtFechaInicio._SeleccionarTodo = False
            Me.txtFechaInicio.Location = New System.Drawing.Point(135, 73)
            Me.txtFechaInicio.Multiline = True
            Me.txtFechaInicio.Name = "txtFechaInicio"
            Me.txtFechaInicio.Size = New System.Drawing.Size(84, 20)
            Me.txtFechaInicio.TabIndex = 71
            Me.txtFechaInicio.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaInicio.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtFechaSancion
            '
            Me.txtFechaSancion._BloquearPaste = False
            Me.txtFechaSancion._SeleccionarTodo = False
            Me.txtFechaSancion.Location = New System.Drawing.Point(135, 46)
            Me.txtFechaSancion.Multiline = True
            Me.txtFechaSancion.Name = "txtFechaSancion"
            Me.txtFechaSancion.Size = New System.Drawing.Size(85, 20)
            Me.txtFechaSancion.TabIndex = 70
            Me.txtFechaSancion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaSancion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'txtMotivoSancion
            '
            Me.txtMotivoSancion._BloquearPaste = False
            Me.txtMotivoSancion._SeleccionarTodo = False
            Me.txtMotivoSancion.Location = New System.Drawing.Point(135, 19)
            Me.txtMotivoSancion.Multiline = True
            Me.txtMotivoSancion.Name = "txtMotivoSancion"
            Me.txtMotivoSancion.Size = New System.Drawing.Size(238, 20)
            Me.txtMotivoSancion.TabIndex = 69
            Me.txtMotivoSancion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtMotivoSancion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.txtFechaAnulacion)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.txtMotivoAnulacion)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.txtObservacionAnulacion)
            Me.GroupBox2.Controls.Add(Me.txtDocumentoAnulacion)
            Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox2.Location = New System.Drawing.Point(0, 196)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(389, 141)
            Me.GroupBox2.TabIndex = 76
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Datos de Anulacion"
            '
            'txtFechaAnulacion
            '
            Me.txtFechaAnulacion._BloquearPaste = False
            Me.txtFechaAnulacion._SeleccionarTodo = False
            Me.txtFechaAnulacion.Location = New System.Drawing.Point(135, 112)
            Me.txtFechaAnulacion.Multiline = True
            Me.txtFechaAnulacion.Name = "txtFechaAnulacion"
            Me.txtFechaAnulacion.Size = New System.Drawing.Size(85, 20)
            Me.txtFechaAnulacion.TabIndex = 7
            Me.txtFechaAnulacion.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtFechaAnulacion.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(6, 116)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(108, 13)
            Me.Label10.TabIndex = 6
            Me.Label10.Text = "Fecha de Anulacion :"
            '
            'frmSancionAnuladoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(389, 385)
            Me.Name = "frmSancionAnuladoPopup"
            Me.Text = "Mantenimiento de Sancion"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtDocumentoSancion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtObservacionSancion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents txtFechaAnulacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents txtMotivoAnulacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtObservacionAnulacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtDocumentoAnulacion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents txtMotivoSancion As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaFin As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaInicio As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents txtFechaSancion As Legolas.APPUIComponents.MyTextBox
    End Class
End Namespace