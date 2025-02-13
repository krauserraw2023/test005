Namespace Registro.Resoluciones
    Public Class frmEstadoNoEjecutadoPopup
#Region "Propiedades_Publicas"
        Public Property _setTipoOpcion As Short = -1
        Public Property _setEsMovimiento As Boolean = False
        Public Property _setTipoLicencia As Short = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana

        Public Property _SetObservacionEstado As String = ""
#End Region
#Region "Propiedades_Retorno"
        Public Property _getEstadoOpcion As Short = -1
        Public Property _getEstadoNombre As String = ""
        Public Property _getObservacionEstado As String = ""

#End Region
#Region "Propiedades"
        Private Property tipoOpcion As Short
            Get
                Dim value As Short = -1

                If Me.rbOpcion1.Checked = True Then
                    value = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion1
                    Me._getEstadoNombre = "NO Ejecutado/" + Me.rbOpcion1.Text
                End If

                If Me.rbOpcion2.Checked = True Then
                    value = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion2
                    Me._getEstadoNombre = "NO Ejecutado/" + Me.rbOpcion2.Text
                End If

                If Me.rbPendienteEjec.Checked = True Then
                    value = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion3
                    Me._getEstadoNombre = "NO Ejecutado/" + Me.rbPendienteEjec.Text
                End If

                Return value
            End Get
            Set(value As Short)

                Select Case value
                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion1
                        Me.rbOpcion1.Checked = True

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion2
                        Me.rbOpcion2.Checked = True

                    Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion3
                        Me.rbPendienteEjec.Checked = True
                End Select

            End Set
        End Property
#End Region
#Region "Otros"


#End Region

        Private Sub frmListaEstablecimientosInimputables_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            If _setTipoOpcion > 0 Then
                Me.tipoOpcion = _setTipoOpcion
            End If

            If _setEsMovimiento = True Then
                Me.lblTitulo.Text = "Estado de Ejecucion: NO TERMINADO"
                Me.rbPendienteEjec.Visible = False
            Else
                Select Case Me._setTipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        Me.rbOpcion1.Enabled = False

                    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                        Me.rbPendienteEjec.Enabled = False
                End Select
            End If

        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

            If Me.tipoOpcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la opción")
                Exit Sub
            End If

            Me._getEstadoOpcion = Me.tipoOpcion
            Me._getEstadoNombre = Me._getEstadoNombre.ToUpper
            DialogResult = DialogResult.OK

        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

            DialogResult = DialogResult.Cancel

        End Sub

    End Class
End Namespace
