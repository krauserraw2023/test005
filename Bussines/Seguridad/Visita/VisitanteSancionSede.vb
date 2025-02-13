Namespace Visita
    Public Class VisitanteSancionSede

        Public Function SubirSancionSede(intIDSancionLocal As Integer, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objDTOEnviar As APPWebService.ws_pope_sede_sanciones.DTOResultVisitanteSancion

            Dim objDTOVis As New APPWebService.ws_pope_sede_sanciones.DTOVisitante
            Dim objDTOSan As New APPWebService.ws_pope_sede_sanciones.DTOSancion
            Dim objDTOVisSan As New APPWebService.ws_pope_sede_sanciones.DTOVisitanteSancion

            Dim objEntVisitante As New Entity.Visita.Visitante
            Dim objEntSancion As New Entity.Visita.VisitanteSancion

            Dim objBssVis As New Bussines.Visita.Visitante
            Dim objBssSan As New Bussines.Visita.VisitanteSancion

            objEntSancion = objBssSan.Listar(intIDSancionLocal)

            '/*1.-datos del visitantes*/
            objEntVisitante = objBssVis.Listar(objEntSancion.VisitanteID)

            'el id del visitante debe existir
            If objEntVisitante.Codigo > 0 Then

                With objDTOVis
                    .IDRegionOrigen = objEntVisitante.RegionID
                    .IDPenalOrigen = objEntVisitante.PenalID
                    .IDVisitanteLocal = objEntVisitante.Codigo
                    .FechaSede = 0
                    .PrimerApellido = objEntVisitante.ApellidoPaterno
                    .SegundoApellido = objEntVisitante.ApellidoMaterno
                    .Nombres = objEntVisitante.Nombres
                    .Sexo = objEntVisitante.SexoID
                    .IDTipoDocumento = objEntVisitante.TipoDocumentoID
                    .NumeroDocumento = objEntVisitante.NumeroDocumento
                    .FechaNacimiento = objEntVisitante.FechaNacimiento
                    .IDNacionalidad = objEntVisitante.NacionalidadID
                    .Observacion = objEntVisitante.Observacion
                    '/*reniec*/
                    .ValidadoReniec = objEntVisitante.VisitanteValidoReniec
                    .IDUsuarioValidaReniec = objEntVisitante.IDUsuarioValidacionReniec
                    .FechaValidaReniec = objEntVisitante.FechaValidacionReniec

                    '/*foto*/
                    .FotoNombre = objEntVisitante.FotoName
                    .IDUsuarioCapturaFoto = objEntVisitante.IDUsuarioCapturaFoto

                    '/*2.- datos de la fotografia*/
                    Dim objByteFoto As Byte()
                    objByteFoto = objBssVis.ListarImagen(1, objEntVisitante.FotoName)
                    .FotoByte = objByteFoto

                    '/*auditoria*/
                    .IDUsuarioCreacion = objEntVisitante.IDUsuarioCreacion
                    .FechaCreacion = objEntVisitante.FechaCreacion
                    .IDUsuarioModificacion = objEntVisitante.IDUsuarioModificacion
                    .FechaModificacion = objEntVisitante.FechaModificacion
                    .IDUsuarioEliminacion = objEntVisitante.IDUsuarioEliminacion
                    .FechaEliminacion = objEntVisitante.FechaEliminacion
                    .Eliminado = objEntVisitante.Eliminado
                End With

                '/*3.- datos de la sancion*/
                With objDTOSan
                    .IDRegionOrigen = objEntSancion.RegionID
                    .IDPenalOrigen = objEntSancion.PenalID
                    .IDSancionLocal = objEntSancion.Codigo
                    .IDVisitanteLocal = objEntSancion.VisitanteID
                    .ApellidosyNombres = objEntSancion.ApellidosyNombres
                    .Documento = objEntSancion.Documento
                    .FechaDoc = objEntSancion.Fecha
                    .FechaInicio = objEntSancion.FechaInicio
                    .FechaFin = objEntSancion.FechaFin
                    .Indeterminado = objEntSancion.FechaFinIndeterminado
                    .IDTipoSancion = objEntSancion.TipoSancionID
                    .Estado = objEntSancion.EstadoID
                    .Obs = objEntSancion.Observacion
                    '/*anulacion*/
                    .DocumentoAnulacion = objEntSancion.DocumentoAnulacion
                    .MotivoAnulacion = objEntSancion.MotivoAnulacion
                    .FechaAnulacion = objEntSancion.FechaAnulacion
                    .ObsAnulacion = objEntSancion.ObsAnulacion
                    .IDUsuarioAnulacion = objEntSancion.IDUsuarioAnulacion
                    '/*auditoria*/
                    .IDUsuarioCreacion = objEntSancion.IDUsuarioCreacion
                    .FechaCreacion = objEntSancion.FechaCreacion
                    .IDUsuarioModificacion = objEntSancion.IDUsuarioModificacion
                    .FechaModificacion = objEntSancion.FechaModificacion
                    .IDUsuarioEliminacion = objEntSancion.IDUsuarioEliminacion
                    .FechaEliminacion = objEntSancion.FechaEliminacion
                    .Eliminado = objEntSancion.Eliminado
                End With

                With objDTOVisSan
                    objDTOVisSan.Visitante = objDTOVis
                    objDTOVisSan.Sancion = objDTOSan
                End With

                Try

                    Dim objws As New APPWebService.ws_pope_sede_sanciones.WSSanciones
                    objws.Url = APPWebService.PathURL.ws_sede_sanciones
                    objDTOEnviar = objws.GrabarSancion(objDTOVisSan)

                    Dim intValor As Integer = -1
                    'si no hay ningun error
                    If objDTOEnviar.CodigoError = 0 Then

                        intValor = GrabarVisitanteSancion_FechaEnvio(objEntSancion.Codigo, objDTOEnviar.IDSancion, objDTOEnviar.FechaSede)

                        If intValor > 0 Then
                            value = True
                        End If
                    Else
                        'si hay error
                        strMensajeOut = objDTOEnviar.MensajeError
                        Return value
                    End If

                Catch ex As Exception
                    strMensajeOut = ex.Message
                End Try

            End If

            Return value

        End Function

        Private Function GrabarVisitanteSancion_FechaEnvio(intIDSancionLocal As Integer, intIDSancionSede As Integer, lngFechaSede As Long) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_sancion_sede_fechaenvio"

            Dim objEnt As New Entity.Visita.VisitanteSancion
            With objEnt
                .Codigo = intIDSancionLocal
                .IDVisitanteSancionSede = intIDSancionSede
                .FechaSede = lngFechaSede
            End With

            intIDSancionLocal = Data.Visita.VisitanteSancion.Grabar(strAccion, strOpcion, objEnt)

            If intIDSancionLocal > 0 Then

                value = GrabarSancionSedeEstado(intIDSancionSede)

            End If

            Return value
        End Function

        Private Function GrabarSancionSedeEstado(intIDSancionSede As Integer) As Integer

            Dim value As Integer = -1

            Dim objDTOVis As New APPWebService.ws_pope_sede_sanciones.DTOVisitanteSancionEstado

            With objDTOVis
                .IDSancion = intIDSancionSede
            End With

            Dim objws As New APPWebService.ws_pope_sede_sanciones.WSSanciones
            objws.Url = APPWebService.PathURL.ws_sede_sanciones
            value = objws.GrabarSancionEstadoEnviadoSede(objDTOVis)

            If value < 1 Then
                value = objws.GrabarSancionEstadoEnviadoSede(objDTOVis)
            End If

            Return value

        End Function

    End Class

End Namespace