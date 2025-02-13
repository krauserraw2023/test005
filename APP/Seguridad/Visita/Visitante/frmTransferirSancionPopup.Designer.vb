Namespace Visita.Visitante


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmTransferirSancionPopup
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
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.SuspendLayout()
            '
            'gbxFormChildContainer
            '
            Me.gbxFormChildContainer.Size = New System.Drawing.Size(413, 163)
            '
            'BackgroundWorker1
            '
            Me.BackgroundWorker1.WorkerReportsProgress = True
            Me.BackgroundWorker1.WorkerSupportsCancellation = True
            '
            'frmTransferirSancionPopup
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(413, 163)
            Me.Name = "frmTransferirSancionPopup"
            Me.Opacity = 0.0R
            Me.Text = "Enviando Informacion"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    End Class
End Namespace