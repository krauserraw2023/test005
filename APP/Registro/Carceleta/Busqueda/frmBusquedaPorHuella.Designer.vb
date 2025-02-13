Namespace Registro.Busqueda
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBusquedaPorHuella
        Inherits Legolas.APPUIComponents.Form
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
            Me.UscHuellaVerificaInterno1 = New APPControls.uscHuellaVerificaInterno()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'UscHuellaVerificaInterno1
            '
            Me.UscHuellaVerificaInterno1._NombrePenal = ""
            Me.UscHuellaVerificaInterno1._PenalId = -1
            Me.UscHuellaVerificaInterno1._RegionId = -1
            Me.UscHuellaVerificaInterno1._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Me.UscHuellaVerificaInterno1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscHuellaVerificaInterno1.Location = New System.Drawing.Point(0, 0)
            Me.UscHuellaVerificaInterno1.Name = "UscHuellaVerificaInterno1"
            Me.UscHuellaVerificaInterno1.Size = New System.Drawing.Size(940, 622)
            Me.UscHuellaVerificaInterno1.TabIndex = 1
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCancel.Image = Global.SIPPOPE.My.Resources.Resources.system_log_out
            Me.btnCancel.Location = New System.Drawing.Point(3, 3)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 43)
            Me.btnCancel.TabIndex = 105
            Me.btnCancel.Text = "&Salir"
            Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 622)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(940, 50)
            Me.Panel1.TabIndex = 106
            '
            'Panel2
            '
            Me.Panel2.Controls.Add(Me.btnCancel)
            Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel2.Location = New System.Drawing.Point(828, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(112, 50)
            Me.Panel2.TabIndex = 106
            '
            'frmBusquedaPorHuella
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(940, 672)
            Me.Controls.Add(Me.UscHuellaVerificaInterno1)
            Me.Controls.Add(Me.Panel1)
            Me.Name = "frmBusquedaPorHuella"
            Me.Text = "Verificación biométrica"
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UscHuellaVerificaInterno1 As APPControls.uscHuellaVerificaInterno
        Friend WithEvents btnCancel As System.Windows.Forms.Button
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
    End Class
End Namespace