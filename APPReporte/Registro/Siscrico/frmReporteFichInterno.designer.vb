Namespace Registro.Siscrico


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmReporteFichInterno
        Inherits System.Windows.Forms.Form 'Legolas.APPUIComponents.FormPopup

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
            Me.UscContentReport1 = New APPReporte.Registro.Siscrico.uscContentReport
            Me.SuspendLayout()
            '
            'UscContentReport1
            '
            Me.UscContentReport1._CambiarEstadoImpresion = True
            Me.UscContentReport1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscContentReport1.Location = New System.Drawing.Point(0, 0)
            Me.UscContentReport1.Name = "UscContentReport1"
            Me.UscContentReport1.Size = New System.Drawing.Size(845, 465)
            Me.UscContentReport1.TabIndex = 2
            '
            'frmReporteFichInterno
            '
            Me.ClientSize = New System.Drawing.Size(845, 465)
            Me.Controls.Add(Me.UscContentReport1)
            Me.Name = "frmReporteFichInterno"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UscContentReport1 As APPReporte.Registro.Siscrico.uscContentReport
    End Class

End Namespace