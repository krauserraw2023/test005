Namespace Registro.Captura
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDocDigitalizadoPopup
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
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtObs = New System.Windows.Forms.TextBox()
            Me.txtRuta = New System.Windows.Forms.TextBox()
            Me.btnAdjuntar = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.UscAuditUser1 = New APPControls.uscAuditUser()
            Me.pnlGrabarDatos = New System.Windows.Forms.Panel()
            Me.btnOk = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.pnlSalir = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTituloDoc = New System.Windows.Forms.TextBox()
            Me.gbxFormChildContainer.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.pnlGrabarDatos.SuspendLayout()
            Me.pnlSalir.SuspendLayout()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Controls.Add(Me.WebBrowser1)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel2)
            Me.gbxFormChildContainer.Controls.Add(Me.Panel1)
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(915, 495)
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.txtTituloDoc)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.txtObs)
            Me.Panel1.Controls.Add(Me.txtRuta)
            Me.Panel1.Controls.Add(Me.btnAdjuntar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(915, 101)
            Me.Panel1.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(20, 58)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(70, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Observación:"
            '
            'txtObs
            '
            Me.txtObs.Location = New System.Drawing.Point(94, 57)
            Me.txtObs.MaxLength = 300
            Me.txtObs.Multiline = True
            Me.txtObs.Name = "txtObs"
            Me.txtObs.Size = New System.Drawing.Size(818, 41)
            Me.txtObs.TabIndex = 2
            '
            'txtRuta
            '
            Me.txtRuta.Location = New System.Drawing.Point(94, 9)
            Me.txtRuta.Name = "txtRuta"
            Me.txtRuta.ReadOnly = True
            Me.txtRuta.Size = New System.Drawing.Size(816, 20)
            Me.txtRuta.TabIndex = 1
            '
            'btnAdjuntar
            '
            Me.btnAdjuntar.Image = Global.SIPPOPE.My.Resources.Resources.pdf_18x24
            Me.btnAdjuntar.Location = New System.Drawing.Point(3, 3)
            Me.btnAdjuntar.Name = "btnAdjuntar"
            Me.btnAdjuntar.Size = New System.Drawing.Size(88, 31)
            Me.btnAdjuntar.TabIndex = 0
            Me.btnAdjuntar.Text = "Adjuntar"
            Me.btnAdjuntar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnAdjuntar.UseVisualStyleBackColor = True
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.UscAuditUser1)
            Me.Panel2.Controls.Add(Me.pnlGrabarDatos)
            Me.Panel2.Controls.Add(Me.pnlSalir)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel2.Location = New System.Drawing.Point(0, 448)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(915, 47)
            Me.Panel2.TabIndex = 5
            '
            'UscAuditUser1
            '
            Me.UscAuditUser1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.UscAuditUser1.Location = New System.Drawing.Point(0, 5)
            Me.UscAuditUser1.Name = "UscAuditUser1"
            Me.UscAuditUser1.Size = New System.Drawing.Size(614, 42)
            Me.UscAuditUser1.TabIndex = 6
            '
            'pnlGrabarDatos
            '
            Me.pnlGrabarDatos.Controls.Add(Me.btnOk)
            Me.pnlGrabarDatos.Controls.Add(Me.btnCancel)
            Me.pnlGrabarDatos.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlGrabarDatos.Location = New System.Drawing.Point(614, 0)
            Me.pnlGrabarDatos.Name = "pnlGrabarDatos"
            Me.pnlGrabarDatos.Size = New System.Drawing.Size(198, 47)
            Me.pnlGrabarDatos.TabIndex = 0
            '
            'btnOk
            '
            Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnOk.Image = Global.SIPPOPE.My.Resources.Resources.accept_32
            Me.btnOk.Location = New System.Drawing.Point(3, 3)
            Me.btnOk.Name = "btnOk"
            Me.btnOk.Size = New System.Drawing.Size(94, 40)
            Me.btnOk.TabIndex = 0
            Me.btnOk.Text = "&Aceptar"
            Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.Delete_32_2_
            Me.btnCancel.Location = New System.Drawing.Point(99, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(97, 40)
            Me.btnCancel.TabIndex = 1
            Me.btnCancel.Text = "&Cancelar"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'pnlSalir
            '
            Me.pnlSalir.Controls.Add(Me.btnSalir)
            Me.pnlSalir.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlSalir.Location = New System.Drawing.Point(812, 0)
            Me.pnlSalir.Name = "pnlSalir"
            Me.pnlSalir.Size = New System.Drawing.Size(103, 47)
            Me.pnlSalir.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnSalir.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnSalir.Location = New System.Drawing.Point(3, 3)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(97, 40)
            Me.btnSalir.TabIndex = 0
            Me.btnSalir.Text = "&Salir"
            Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'WebBrowser1
            '
            Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WebBrowser1.Location = New System.Drawing.Point(0, 101)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.Size = New System.Drawing.Size(915, 347)
            Me.WebBrowser1.TabIndex = 6
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(29, 37)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(62, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Titulo Doc.:"
            '
            'txtTituloDoc
            '
            Me.txtTituloDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTituloDoc.Location = New System.Drawing.Point(94, 33)
            Me.txtTituloDoc.MaxLength = 90
            Me.txtTituloDoc.Name = "txtTituloDoc"
            Me.txtTituloDoc.Size = New System.Drawing.Size(817, 20)
            Me.txtTituloDoc.TabIndex = 5
            '
            'frmDocDigitalizadoPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(915, 495)
            Me.Name = "frmDocDigitalizadoPopup"
            Me.Text = "Documentos digitalizados"
            Me.gbxFormChildContainer.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.pnlGrabarDatos.ResumeLayout(False)
            Me.pnlSalir.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents UscAuditUser1 As APPControls.uscAuditUser
        Friend WithEvents pnlGrabarDatos As System.Windows.Forms.Panel
        Friend WithEvents btnOk As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents pnlSalir As System.Windows.Forms.Panel
        Friend WithEvents btnSalir As System.Windows.Forms.Button
        Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
        Friend WithEvents txtRuta As System.Windows.Forms.TextBox
        Friend WithEvents btnAdjuntar As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents txtObs As System.Windows.Forms.TextBox
        Friend WithEvents txtTituloDoc As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace