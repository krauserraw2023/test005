Public Class Fotografia
    Public Enum enmDirectotioTipo
        Interno = 1
        Personal = 2
        Visitante = 3
        Reniec = 4
        ReniecSybase = 5
    End Enum

    Public Shared Function SubirFotoByte_version1(ByVal imagenByte As Byte(), ByVal nombreArchivoConExtension As String,
                                                  ByVal Directorio As enmDirectotioTipo, ByRef strMensajeOut As String) As Boolean

        Dim value As Boolean = False

        If imagenByte Is Nothing Then
            Return value
        End If

        Dim objWebService As New APPWebService.ws_foto.PopeLocal
        objWebService.Url = APPWebService.PathURL.WSPopeLocal

        Try
            value = objWebService.UploadImageJpg(imagenByte, nombreArchivoConExtension, Directorio) 'solo debe usarse para subir fotos de interno                 
        Catch ex As Exception
            strMensajeOut = ex.Message
        End Try

        Return value

    End Function

    Public Shared Function SubirFotoByte_v2(ByVal imgByte As Byte(), nomImgSinExtension As String, extensionImg As String, rutaDestino As String, ByVal Directorio As enmDirectotioTipo, ByRef outSms As String) As Boolean
        Dim blnValue As Boolean = False

        If imgByte Is Nothing Then
            Return blnValue
        End If

        If nomImgSinExtension.Length = 0 Then
            outSms = "Nombre del archivo no válido."
            Return False
        End If

        If rutaDestino.Length = 0 Then
            outSms = "Ruta destino no válido."
            Return False
        End If

        Dim objByte As Byte()

        Dim objWebService As New APPWebService.ws_foto.PopeLocal
        objWebService.Url = APPWebService.PathURL.WSPopeLocal

        objByte = imgByte

        Try
            blnValue = objWebService.SubirArchivoByteArbolDirectorio(objByte, nomImgSinExtension, extensionImg, rutaDestino, Directorio, outSms)
        Catch ex As Exception
            outSms = ex.Message
            blnValue = False
        End Try

        Return blnValue

    End Function

    Public Function ReDescargarFotografiaLocal(idArchivoDigitalSedeRowID As Integer, ByRef strMensajeOut As String) As Boolean

        Dim value As Boolean = False
        Const intTipoFotoInterno As Integer = 1
        Const blnServicioSedeCentral As Boolean = True
        Dim objWSLeerFotoSede As New APPWebService.InpeSedeInterno

        If idArchivoDigitalSedeRowID > 0 Then

            Dim objDTOResult As New Result.ArchivoDigitalFotografia

            objDTOResult = objWSLeerFotoSede.ListarArchivoDigitalFotografia(idArchivoDigitalSedeRowID, intTipoFotoInterno, strMensajeOut, blnServicioSedeCentral)
            value = SubirFotoByte_version1(objDTOResult.archivoByte, objDTOResult.nombreFisico & "." & objDTOResult.extension, intTipoFotoInterno, strMensajeOut)

        End If

        Return value

    End Function
End Class
