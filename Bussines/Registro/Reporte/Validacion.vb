Namespace Registro.Reporte
    Public Class Validacion
        Public Function validarEmisionCertificadoLibertad(esPLM As Boolean, idInterno As Integer, idPenal As Integer,
                                                          ByRef mensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim objEntInterno As New Entity.Registro.Interno

            If esPLM = True Then
                objEntInterno = (New Bussines.Registro.Interno).Listar_LM(idInterno)
            Else
                objEntInterno = (New Bussines.Registro.Interno).Listar_v5(idInterno)
            End If

            'validar los datos del interno
            If objEntInterno Is Nothing Then
                mensajeOut = "No existen los datos del interno."
                Return value
            End If

            ''validar el estado del interno
            'jmr, 25.01.2022, se quita la restriccion de la generacion del certificado de libertad a pendiente, siempre y cuando sea un proceso inimputable.

            If objEntInterno.EstadoID = Type.Enumeracion.Interno.EnmEstado.Activo Then

                Dim intTipoProceso As Short = -1
                Dim objBssMov As New Bussines.Registro.InternoMovimiento
                intTipoProceso = objBssMov.fnGetTipoProcesoMovimientoLibertad(idInterno)

                Select Case intTipoProceso
                    Case Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable,
                         Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.PosibleInimputable
                    Case Else
                        mensajeOut = "No es posible completar la operación, el interno se encuentra activo, finalize el movimiento del interno."
                        Return value
                End Select
            End If

            'validar los datos del documento de libertad y movimiento
            Dim objBssReporte As New Bussines.Reporte.Registro

            Dim objEntCol As New Entity.Reporte.CertificadoLibertad.CertificadoCol

            If esPLM = True Then
                objEntCol = objBssReporte.CertificadoLibertad_LM(idInterno, idPenal, "", "", Nothing)
            Else
                objEntCol = objBssReporte.CertificadoLibertad_Provincia(idInterno, "", "", Nothing)
            End If


            If objEntCol.Count < 1 Then
                mensajeOut = "El interno no cuenta con Resolución de Libertad."
                Return value
            End If

            If objEntCol.Certificado(0).FechaEgreso < 1 Then
                mensajeOut = "El interno no cuenta con el movimiento de libertad."
                Return value
            End If

            Return True
        End Function
    End Class
End Namespace

