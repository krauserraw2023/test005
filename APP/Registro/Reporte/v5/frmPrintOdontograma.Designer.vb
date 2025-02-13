<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintOdontograma
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintOdontograma))
        Me.AxCtlOdon1 = New AxCTLODONLib.AxCtlOdon()
        CType(Me.AxCtlOdon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxCtlOdon1
        '
        Me.AxCtlOdon1.Enabled = True
        Me.AxCtlOdon1.Location = New System.Drawing.Point(0, 0)
        Me.AxCtlOdon1.Name = "AxCtlOdon1"
        Me.AxCtlOdon1.OcxState = CType(resources.GetObject("AxCtlOdon1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCtlOdon1.Size = New System.Drawing.Size(597, 504)
        Me.AxCtlOdon1.TabIndex = 1
        '
        'frmPrintOdontograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 504)
        Me.Controls.Add(Me.AxCtlOdon1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrintOdontograma"
        Me.Text = "frmPrintOdontograma"
        CType(Me.AxCtlOdon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxCtlOdon1 As AxCTLODONLib.AxCtlOdon
End Class
