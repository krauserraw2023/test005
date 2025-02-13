Namespace Transferencia.Control
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmShowSqlPopup
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnEnviar = New System.Windows.Forms.Button()
            Me.txtAsunto = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtCorreoPara = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtCC = New Legolas.APPUIComponents.MyTextBox(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.btnEnviar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 409)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(938, 47)
            Me.Panel1.TabIndex = 3
            '
            'btnEnviar
            '
            Me.btnEnviar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnEnviar.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnEnviar.Location = New System.Drawing.Point(812, 3)
            Me.btnEnviar.Name = "btnEnviar"
            Me.btnEnviar.Size = New System.Drawing.Size(124, 41)
            Me.btnEnviar.TabIndex = 99
            Me.btnEnviar.Text = "&Enviar"
            Me.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnEnviar.UseVisualStyleBackColor = True
            '
            'txtAsunto
            '
            Me.txtAsunto._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtAsunto._BloquearPaste = False
            Me.txtAsunto._SeleccionarTodo = False
            Me.txtAsunto.Location = New System.Drawing.Point(60, 6)
            Me.txtAsunto.Name = "txtAsunto"
            Me.txtAsunto.Size = New System.Drawing.Size(373, 20)
            Me.txtAsunto.TabIndex = 206
            Me.txtAsunto.Text = "Registros para activar transferencia en el penal origen"
            Me.txtAsunto.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtAsunto.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(7, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(46, 13)
            Me.Label1.TabIndex = 205
            Me.Label1.Text = "Asunto :"
            '
            'txtCorreoPara
            '
            Me.txtCorreoPara._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCorreoPara._BloquearPaste = False
            Me.txtCorreoPara._SeleccionarTodo = False
            Me.txtCorreoPara.Location = New System.Drawing.Point(60, 32)
            Me.txtCorreoPara.Name = "txtCorreoPara"
            Me.txtCorreoPara.Size = New System.Drawing.Size(373, 20)
            Me.txtCorreoPara.TabIndex = 204
            Me.txtCorreoPara.Text = "helpdesk.registro@inpe.gob.pe"
            Me.txtCorreoPara.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCorreoPara.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(7, 35)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(35, 13)
            Me.Label4.TabIndex = 203
            Me.Label4.Text = "Para :"
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Panel3)
            Me.GroupBox1.Controls.Add(Me.Panel2)
            Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(938, 409)
            Me.GroupBox1.TabIndex = 207
            Me.GroupBox1.TabStop = False
            '
            'Panel3
            '
            Me.Panel3.Controls.Add(Me.RichTextBox1)
            Me.Panel3.Controls.Add(Me.Label2)
            Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel3.Location = New System.Drawing.Point(3, 100)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(932, 306)
            Me.Panel3.TabIndex = 209
            '
            'RichTextBox1
            '
            Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RichTextBox1.Location = New System.Drawing.Point(0, 23)
            Me.RichTextBox1.Name = "RichTextBox1"
            Me.RichTextBox1.Size = New System.Drawing.Size(932, 283)
            Me.RichTextBox1.TabIndex = 208
            Me.RichTextBox1.Text = ""
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Label2.Location = New System.Drawing.Point(0, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(932, 23)
            Me.Label2.TabIndex = 207
            Me.Label2.Text = "Mensaje:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.txtCC)
            Me.Panel2.Controls.Add(Me.Label3)
            Me.Panel2.Controls.Add(Me.txtAsunto)
            Me.Panel2.Controls.Add(Me.txtCorreoPara)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.Label4)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel2.Location = New System.Drawing.Point(3, 16)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(932, 84)
            Me.Panel2.TabIndex = 208
            '
            'txtCC
            '
            Me.txtCC._BackColor_Focus = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(153, Byte), Integer))
            Me.txtCC._BloquearPaste = False
            Me.txtCC._SeleccionarTodo = False
            Me.txtCC.Location = New System.Drawing.Point(60, 58)
            Me.txtCC.Name = "txtCC"
            Me.txtCC.Size = New System.Drawing.Size(373, 20)
            Me.txtCC.TabIndex = 208
            Me.txtCC.Text = "jmondalgo@inpe.gob.pe,hrosario@inpe.gob.pe"
            Me.txtCC.TipoPropercase = Legolas.APPUIComponents.MyTextBox.enmTipoPropercase.Normal
            Me.txtCC.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(7, 61)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(24, 13)
            Me.Label3.TabIndex = 207
            Me.Label3.Text = "CC:"
            '
            'frmShowSqlPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(938, 456)
            Me.ControlBox = False
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "frmShowSqlPopup"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = ".::. Registros para activar tranferencia en el penal origen."
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As Panel
        Friend WithEvents btnEnviar As Button
        Friend WithEvents txtAsunto As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label1 As Label
        Friend WithEvents txtCorreoPara As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Panel3 As Panel
        Friend WithEvents Panel2 As Panel
        Friend WithEvents txtCC As Legolas.APPUIComponents.MyTextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents RichTextBox1 As RichTextBox
    End Class
End Namespace