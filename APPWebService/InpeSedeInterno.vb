Public Class InpeSedeInterno
    Public Function ValidarSiTieneRegistros(intIDInternoSede As Integer, ByRef MensajeOut As String) As Boolean

        Dim value As Boolean = True

        If Legolas.Components.PC.IsOnline = False Then
            MensajeOut = "Actualmente no hay conexion hacia la Sede Central. No se puede completar la operacion, intentelo mas tarde."
            Return value
        End If

        Dim objResul As New ws_pope_sede_plm_Interno.DTO_ResultOfBoolean
        Dim objws As New ws_pope_sede_plm_Interno.InternoSede
        ''objws.Url = "http://localhost/INPE/ws_sip_sede_plm/InternoSede.asmx"
        objws.Url = APPWebService.PathURL.ws_sede_plm_Interno

        Try
            objResul = objws.ValidarSihayDatosInternoPLM(intIDInternoSede)

            If objResul.Resultado = True Then
                MensajeOut = objResul.Error_Mensaje
                Return value
            End If

        Catch ex As Exception
            MensajeOut = ex.Message & ". URL: " & objws.Url
            Return value
        End Try

        value = False
        Return value
    End Function

    Public Function ListarArchivoDigitalFotografia(idArchivoDigital As Integer, tipoArchivo As Integer, ByRef mensajeOut As String,
                                             Optional ByVal servicioSedeCentral As Boolean = False) As Result.ArchivoDigitalFotografia

        Dim objWS As New APPWebService.ws_foto.PopeLocal
        objWS.Timeout = 7000 'NUEVO JMR
        Dim objDtoRetorno As New Result.ArchivoDigitalFotografia

        Dim objDTOContenedorResult As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
        Dim objDTOArchivoDigital As New APPWebService.ws_foto.Dto_ArchivoDigital

        objWS.Url = APPWebService.PathURL.WSPopeLocal
        If servicioSedeCentral = True Then
            objWS.Url = APPWebService.PathURL.WSPopeSedeCentral
        End If

        Try
            Dim lngFecha As Long = objWS.FechaHoy()
        Catch ex As Exception
            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex2 As Exception 'segundo intento
                mensajeOut = "Servicio no disponible"
                Return Nothing
            End Try
        End Try

        objDTOContenedorResult = objWS.ListarArchivoDigital_Nativo(idArchivoDigital, tipoArchivo)
        If objDTOContenedorResult Is Nothing Then Return Nothing

        objDTOArchivoDigital = objDTOContenedorResult.Resultado
        If Not objDTOArchivoDigital Is Nothing Then
            '------ descargar dto a entity
            With objDtoRetorno
                .codigo = objDTOArchivoDigital.Codigo
                .tipoFotografia = objDTOArchivoDigital.Tipo
                .idTablaReferencia = objDTOArchivoDigital.CodigoExt_id
                .anio = objDTOArchivoDigital.Anio
                .mes = objDTOArchivoDigital.Mes
                .mesCorrelativo = objDTOArchivoDigital.MesCorrelativo
                .pcMAC = objDTOArchivoDigital.MAC
                .pcNombre = objDTOArchivoDigital.PC
                .pcIP = objDTOArchivoDigital.IP
                .pcDirectorioLocal = objDTOArchivoDigital.Directorio
                .nombreFisico = objDTOArchivoDigital.NombreFisico
                .extension = objDTOArchivoDigital.Extension
                .peso = objDTOArchivoDigital.Peso
                .fechaCreacion = objDTOArchivoDigital.FechaCreacion
                .fechaImportacion = objDTOArchivoDigital.FechaImportacion
                .fechaModificacion = objDTOArchivoDigital.FechaModificacion
                .rutaServidor = .rutaServidor
                .archivoSubidoWeb = objDTOArchivoDigital.ImagenUploadWeb
                .archivoByte = objDTOArchivoDigital.ArchivoByte
                .idRegion = objDTOArchivoDigital.Region
                .idPenal = objDTOArchivoDigital.Penal
            End With
        End If

        If objDTOContenedorResult.Error_cod <> 0 Then
            mensajeOut = ErrorMensaje(objDTOContenedorResult.Error_cod)
            Return objDtoRetorno
        End If

        Return objDtoRetorno
    End Function

    Private Function ErrorMensaje(CodError As Integer) As String
        Dim smsErr As String = ""
        Select Case CodError
            Case 0
                smsErr = ""
            Case -1 'error general (si
                smsErr = "Error desconocido"
            Case -2 'exte
                smsErr = "Extensión de archivo no válido"
            Case -3 'AD_ARCH_TIP_INVALID = -3 'tipo d
                smsErr = "Tipo de archivo no válido"
            Case -4 'AD_USUARIO_INVALID = -4
                smsErr = "Usuario no válido"
            Case -5 'AD_REGION_INVALID = -5
                smsErr = "Id de región no válido"
            Case -6 'AD_PENAL_INVALID = -6
                smsErr = "Id de penal no válido"
            Case -7 'AD_ERR_IDEXTERNO = -7 'error en 
                smsErr = "Error en ID foraneo en funcion al tipo interno/visitante/reniec"
            Case -8 'AD_ERR_CREA_DIR_SERVER = -8 'err
                smsErr = "Error al crear directorio en el servidor"
            Case -9 'AD_ERR_ESCRITURA_ARCH_DISCO = -9
                smsErr = "Error de escritura en disco de servidor"
            Case -10 'AD_OBJETO_ARH_DIG_NULO = -10
                smsErr = "Archivo digital no cargado"
            Case -11 'AD_ERR_ARCH_ID_INVALID = -11
                smsErr = "Id del archivo digital no válido"
            Case -12 'AD_REGISTRO_NO_EXISTE = -12
                smsErr = "Registro no existe"
            Case -13 'AD_ERR_LECTURA_ARCH_FISICO = 13
                smsErr = "Error de lectura de archivo digital en el servidor, posiblemente el archivo fisico de la imagen no existe"
            Case -14 'AD_ERR_ARCH_FISICO_NO_EXIS = -14
                smsErr = "Archivo digital de la imagen no existe"
            Case Else
                smsErr = "Código de error " & CodError
        End Select
        Return smsErr
    End Function

    Public Function listarArchivoDigitalFotografiaByte(idArchivoDigital As Integer, tipoArchivo As Integer, ByRef mensajeOut As String,
                                                 Optional ByVal ServicioSedeCentral As Boolean = False) As Byte()

        Dim objDTO As Result.ArchivoDigitalFotografia
        objDTO = ListarArchivoDigitalFotografia(idArchivoDigital, tipoArchivo, mensajeOut, ServicioSedeCentral)
        If objDTO Is Nothing Then Return Nothing
        Return objDTO.archivoByte

    End Function

    'Private Function aaa()

    '    Dim by_Foto As Byte() = Nothing
    '    Try
    '        by_Foto = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(f.Item("_sed_rowid"), 1, outSMS, True)
    '        If by_Foto Is Nothing Then
    '            outSMS = ""
    '        Else
    '            If f.Item("arc_dig_pth_ser").ToString.Length > 0 Then
    '                APPWebService.Fotografia.SubirFotoByte_v2(by_Foto,
    '                                                          f.Item("arc_dig_nom_fis"),
    '                                                          f.Item("arc_dig_ext"),
    '                                                          f.Item("arc_dig_pth_ser"),
    '                                                          APPWebService.Fotografia.enmDirectotioTipo.Interno,
    '                                                          outSMS)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Dim s As String
    '        s = ""
    '    End Try

    'End Function
End Class
