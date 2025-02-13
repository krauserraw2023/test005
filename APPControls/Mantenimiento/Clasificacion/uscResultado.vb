Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class uscResultado
        Private objBss As Bussines.Mantenimiento.Tratamiento.Clasificacion.Resultado = Nothing
#Region "Eventos"
        Public Event _Click_Nuevo()
        Public Event _Click_Modificar(intIDCodigo As Short)
        Public Event _Grilla_CellEnter()
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo As Short
            Get
                Dim value As Short = -1
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Buscar"
        Private Property IDFicha As Short = -1
#End Region
#Region "Propiedades_Permiso"
        Public Property _PermisoEscritura As Boolean = False
        Public Property _PermisoEliminar As Boolean = False
#End Region
#Region "Listar"
        Private Sub Listar()

            objBss = New Bussines.Mantenimiento.Tratamiento.Clasificacion.Resultado

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objBss.Listar(Me.IDFicha)
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AEliminar()

            If Me._PermisoEliminar = True Then

                If Me.dgwGrilla.RowCount < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el registro a eliminar")
                    Exit Sub
                End If

                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then

                    objBss = New Bussines.Mantenimiento.Tratamiento.Clasificacion.Resultado
                    Dim value As Integer = -1
                    Dim strMensaje As String = ""

                    value = objBss.Eliminar("del", "del_mant", Me.GrillaCodigo, strMensaje)

                    If value > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                        Listar()
                    Else

                        If strMensaje.Trim.Length > 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Else
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("La operacion no se realizo correctamente, Intentelo nuevamente")
                        End If
                    End If

                End If

            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Usted no tiene permiso para realizar esta operacion")
            End If

        End Sub
#End Region
#Region "Funciones_Publicas"

        Public Sub _ListarGrilla(intIDFicha As Short)

            Me.IDFicha = intIDFicha
            Listar()

        End Sub
        Public Function _getCodigo() As Short

            Return Me.GrillaCodigo

        End Function
#End Region

        Private Sub btnNuevoVariable_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoVariable.Click

            RaiseEvent _Click_Nuevo()

        End Sub

        Private Sub btnEditarVariable_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarVariable.Click

            If Me.GrillaCodigo > 0 Then
                RaiseEvent _Click_Modificar(Me.GrillaCodigo)
            Else
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione el registro a modificar")
            End If

        End Sub

        Private Sub btnEliminarVariable_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarVariable.Click

            AEliminar()

        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick


        End Sub

    
        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub dgwGrilla_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellDoubleClick

            With dgwGrilla
                If dgwGrilla.RowCount > 0 And e.RowIndex >= 0 Then

                    RaiseEvent _Click_Modificar(Me.GrillaCodigo)

                End If
            End With

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            With dgwGrilla
                If dgwGrilla.RowCount > 0 And e.RowIndex >= 0 Then

                    RaiseEvent _Grilla_CellEnter()

                End If
            End With


        End Sub
    End Class

End Namespace
