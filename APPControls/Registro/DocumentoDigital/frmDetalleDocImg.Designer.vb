﻿Namespace Registro.DocumentoDigital

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmDetalleDocImg
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
            Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.SuspendLayout()
            '
            'WebBrowser1
            '
            Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
            Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser1.Name = "WebBrowser1"
            Me.WebBrowser1.Size = New System.Drawing.Size(1075, 660)
            Me.WebBrowser1.TabIndex = 10
            '
            'frmDetalleDocImg
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1075, 660)
            Me.Controls.Add(Me.WebBrowser1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MinimizeBox = False
            Me.Name = "frmDetalleDocImg"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Visor Documento digitalizado"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents WebBrowser1 As WebBrowser
    End Class
End Namespace