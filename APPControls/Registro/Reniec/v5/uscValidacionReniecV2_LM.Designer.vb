Namespace Registro.Reniec.v5
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscValidacionReniecV2_LM
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
            Me.UscValidacionDatosInternoV21 = New APPControls.Registro.Reniec.uscValidacionDatosInternoV2()
            Me.UscValidacionDatosReniecV21 = New APPControls.Registro.Reniec.v5.uscValidacionDatosReniecV2_LM
            Me.SuspendLayout()
            '
            'UscValidacionDatosInternoV21
            '
            Me.UscValidacionDatosInternoV21._CondicionBusqueda = 0
            Me.UscValidacionDatosInternoV21._Contador = -1
            Me.UscValidacionDatosInternoV21._InternoID = -1
            Me.UscValidacionDatosInternoV21._ListaInternoCabecera = ""
            Me.UscValidacionDatosInternoV21._ListaInternoData = ""
            Me.UscValidacionDatosInternoV21._NombresAsociados = ""
            Me.UscValidacionDatosInternoV21._NombresAsociadosID = ""
            Me.UscValidacionDatosInternoV21._NombresAsociadosLista = ""
            Me.UscValidacionDatosInternoV21._VarHistorico = 0
            Me.UscValidacionDatosInternoV21._Version = False
            Me.UscValidacionDatosInternoV21.AutoScroll = True
            Me.UscValidacionDatosInternoV21.Fecha = CType(0, Long)
            Me.UscValidacionDatosInternoV21.Location = New System.Drawing.Point(4, 5)
            Me.UscValidacionDatosInternoV21.Name = "UscValidacionDatosInternoV21"
            Me.UscValidacionDatosInternoV21.Size = New System.Drawing.Size(464, 398)
            Me.UscValidacionDatosInternoV21.TabIndex = 0
            '
            'UscValidacionDatosReniecV21
            '
            Me.UscValidacionDatosReniecV21._CondicionBusqueda = -1
            Me.UscValidacionDatosReniecV21._Contador = -1
            Me.UscValidacionDatosReniecV21._CopiaImagen = -1
            Me.UscValidacionDatosReniecV21._CopiaNombreImagen = ""
            Me.UscValidacionDatosReniecV21._EnabledDobleClick = False
            Me.UscValidacionDatosReniecV21._HasImagen = False
            Me.UscValidacionDatosReniecV21._InternoID = -1
            Me.UscValidacionDatosReniecV21._SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.UscValidacionDatosReniecV21._VarHistorico = 0
            Me.UscValidacionDatosReniecV21._Version = False
            Me.UscValidacionDatosReniecV21.Fecha = CType(0, Long)
            Me.UscValidacionDatosReniecV21.Location = New System.Drawing.Point(470, 7)
            Me.UscValidacionDatosReniecV21.Name = "UscValidacionDatosReniecV21"
            Me.UscValidacionDatosReniecV21.Size = New System.Drawing.Size(469, 396)
            Me.UscValidacionDatosReniecV21.TabIndex = 1
            '
            'uscValidacionReniecV2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.Controls.Add(Me.UscValidacionDatosInternoV21)
            Me.Controls.Add(Me.UscValidacionDatosReniecV21)
            Me.Name = "uscValidacionReniecV2"
            Me.Size = New System.Drawing.Size(939, 403)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UscValidacionDatosReniecV21 As APPControls.Registro.Reniec.v5.uscValidacionDatosReniecV2_LM
        Friend WithEvents UscValidacionDatosInternoV21 As APPControls.Registro.Reniec.uscValidacionDatosInternoV2

    End Class
End Namespace
