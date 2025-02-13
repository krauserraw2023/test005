Public Class Config
    Public Shared Sub AbrirFormulario(ByVal FormularioChild As Legolas.APPUIComponents.Form, ByVal MDI As Form)

        Dim frmLlamado As Legolas.APPUIComponents.Form

        Dim blnFormExiste As Boolean = False

        Try

            'Chequea si el formulario ha sido cargado

            For Each frmLlamado In MDI.MdiChildren

                'Compara si es igual y retorna verdadero si lo es.

                If frmLlamado.Name = FormularioChild.Name Then

                    blnFormExiste = True   'Marca la bandera

                    Exit For      'Sale del loop si es verdadero

                End If

            Next

            If Not blnFormExiste Then
                'Carga el formulario si no esta llamado
                FormularioChild.MdiParent = MDI
                FormularioChild.Show()
            ElseIf blnFormExiste Then
                'frmLlamado.Focus()   'Enfoca el objeto
                frmLlamado.BringToFront()
            End If

        Catch ex As Exception
            Legolas.Configuration.Aplication.MessageBox.MensajeError(ex.Message)
        End Try

        FormularioChild = Nothing  'Limpiar todo
        frmLlamado = Nothing

    End Sub

    Public Class Singleton_Forms
#Region "Singleton Forms"
        Public Shared ChildInstance_Seguridad_frmBuscar As Sistema.Seguridad.Usuario.frmBuscar
        Public Shared ChildInstance_Seguridad_Modulo_frmBuscar As Seguridad.Modulo.frmBuscar
        Public Shared Function Instance_frmSeguridad_frmBuscar() As Sistema.Seguridad.Usuario.frmBuscar
            If ChildInstance_Seguridad_frmBuscar Is Nothing OrElse ChildInstance_Seguridad_frmBuscar.IsDisposed = True Then
                ChildInstance_Seguridad_frmBuscar = New Sistema.Seguridad.Usuario.frmBuscar
            End If
            ChildInstance_Seguridad_frmBuscar.BringToFront()
            Return ChildInstance_Seguridad_frmBuscar
        End Function
        Public Shared Function Instance_Seguridad_Modulo_frmBuscar() As Seguridad.Modulo.frmBuscar
            If ChildInstance_Seguridad_Modulo_frmBuscar Is Nothing OrElse ChildInstance_Seguridad_Modulo_frmBuscar.IsDisposed = True Then
                ChildInstance_Seguridad_Modulo_frmBuscar = New Seguridad.Modulo.frmBuscar
            End If
            ChildInstance_Seguridad_Modulo_frmBuscar.BringToFront()
            Return ChildInstance_Seguridad_Modulo_frmBuscar
        End Function
#End Region
    End Class

End Class
