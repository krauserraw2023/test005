Namespace Busqueda

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class uscComboSala
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
            Me.UscComboParametrica1 = New APPControls.uscComboParametrica()
            Me.SuspendLayout()
            '
            'UscComboParametrica1
            '
            Me.UscComboParametrica1._NoIndica = False
            Me.UscComboParametrica1._TipoTexto = Type.Combo.enmTipoTexto.Ninguno
            Me.UscComboParametrica1._Todos = False
            Me.UscComboParametrica1._TodosMensaje = ""
            Me.UscComboParametrica1._Visible_Add = False
            Me.UscComboParametrica1._Visible_Buscar = True
            Me.UscComboParametrica1._Visible_Eliminar = False
            Me.UscComboParametrica1.CodigoPadre = -1
            Me.UscComboParametrica1.ComboTipo = CType(0, Short)
            Me.UscComboParametrica1.DisplayTipoLetra = APPControls.uscComboParametrica.LetraTipo.Ninguno
            Me.UscComboParametrica1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UscComboParametrica1.DropDownWidth = 500
            Me.UscComboParametrica1.DropDownWidthAuto = False
            Me.UscComboParametrica1.ListaIdsParaExcluir = Nothing
            Me.UscComboParametrica1.Location = New System.Drawing.Point(0, 0)
            Me.UscComboParametrica1.ModuloTratamiento = False
            Me.UscComboParametrica1.Name = "UscComboParametrica1"
            Me.UscComboParametrica1.Parametro1 = -1
            Me.UscComboParametrica1.Parametro2 = -1
            Me.UscComboParametrica1.SelectedIndex = -1
            Me.UscComboParametrica1.SelectedValue = 0
            Me.UscComboParametrica1.Size = New System.Drawing.Size(293, 22)
            Me.UscComboParametrica1.TabIndex = 2
            Me.UscComboParametrica1.verToolTipItemSeleccionado = False
            '
            'uscComboSala
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.UscComboParametrica1)
            Me.Name = "uscComboSala"
            Me.Size = New System.Drawing.Size(293, 21)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UscComboParametrica1 As APPControls.uscComboParametrica

    End Class
End Namespace