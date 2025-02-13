<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscAutenticacionDactilar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.UscValidarHuellaModelOTRO = New APPControlHuellaVisita.Huellero.FS10.uscValidarHuellaBasic()
        Me.SuspendLayout()
        '
        'UscValidarHuellaModelOTRO
        '
        Me.UscValidarHuellaModelOTRO.Location = New System.Drawing.Point(2, 2)
        Me.UscValidarHuellaModelOTRO.Name = "UscValidarHuellaModelOTRO"
        Me.UscValidarHuellaModelOTRO.Size = New System.Drawing.Size(472, 197)
        Me.UscValidarHuellaModelOTRO.TabIndex = 1
        '
        'uscAutenticacionDactilar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.UscValidarHuellaModelOTRO)
        Me.Name = "uscAutenticacionDactilar"
        Me.Size = New System.Drawing.Size(476, 203)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UscValidarHuellaModelOTRO As APPControlHuellaVisita.Huellero.FS10.uscValidarHuellaBasic
End Class
