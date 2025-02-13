Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class ArchivoDigital
        Private objEnt As Entity.Globall.ArchivoDigital = Nothing
#Region "servicios archivo digital"
        ''' <summary>
        ''' Retorna el estado del servicio, TRUE:En linea, FALSE: Servicio no disponible
        ''' </summary>
        ''' <param name="ServicioSedeCentral">True: Servicio de la sede central, False: Servicio local</param>
        ''' <returns>Retorna el estado del servicio si esta disponible o no</returns>
        ''' <history>
        ''' Creado: hrosario - 08/01/2015 14:41 
        ''' </history>

        Public Function TestServicioArchivoDigital(Optional ByVal ServicioSedeCentral As Boolean = False) As Boolean
            Dim v As Boolean = False
            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Timeout = -1
            objWS.Url = APPWebService.PathURL.WSPopeLocal
            If ServicioSedeCentral = True Then
                objWS.Url = APPWebService.PathURL.WSPopeSedeCentral
            End If

            Try
                Dim lngFecha As Long = objWS.FechaHoy()
                v = True
            Catch ex As Exception
                Try
                    Dim lngFecha As Long = objWS.FechaHoy()
                    v = True
                Catch ex2 As Exception 'segundo intento
                    v = False
                End Try
            End Try
            Return v
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
        '16/12/2014 -> hrnb
        Public Function ListarArchivoDigital(IdArchivoDigital As Integer, TipoArchivo As Integer, ByRef outErrSms As String,
                                             Optional ByVal ServicioSedeCentral As Boolean = False) As Entity.Globall.ArchivoDigital

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Timeout = 7000 'NUEVO JMR
            Dim entArchDig As New Entity.Globall.ArchivoDigital
            Dim dto As New APPWebService.ws_foto.Dto_ArchivoDigital
            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital

            objWS.Url = APPWebService.PathURL.WSPopeLocal
            If ServicioSedeCentral = True Then
                objWS.Url = APPWebService.PathURL.WSPopeSedeCentral
            End If
            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                Try
                    Dim lngFecha As Long = objWS.FechaHoy()
                Catch ex2 As Exception 'segundo intento
                    outErrSms = "Servicio no disponible"
                    Return Nothing
                End Try
            End Try

            r = objWS.ListarArchivoDigital_Nativo(IdArchivoDigital, TipoArchivo)
            If r Is Nothing Then Return Nothing
            dto = r.Resultado
            If Not dto Is Nothing Then
                '------ descargar dto a entity
                With entArchDig
                    .Anio = dto.Anio
                    .ArchivoByte = dto.ArchivoByte
                    .Codigo = dto.Codigo
                    .Descripcion = dto.Descripcion
                    .Directorio = dto.Directorio
                    .Extension = dto.Extension
                    .FechaCreacion = dto.FechaCreacion
                    .FechaImportacion = dto.FechaImportacion
                    .FechaModificacion = dto.FechaModificacion
                    .ImagenUploadWeb = dto.ImagenUploadWeb
                    .IP = dto.IP
                    .MAC = dto.MAC
                    .Mes = dto.Mes
                    .MesCorrelativo = dto.MesCorrelativo
                    .NombreFisico = dto.NombreFisico
                    .PC = dto.PC
                    .Penal = dto.Penal
                    .Peso = dto.Peso
                    .Region = dto.Region
                    .RutaServidor = .RutaServidor
                    .Tipo = dto.Tipo
                    .CodigoExt_id = dto.CodigoExt_id
                End With
            End If
            If r.Error_cod <> 0 Then
                outErrSms = ErrorMensaje(r.Error_cod)
                Return entArchDig
            End If

            Return entArchDig
        End Function

        '16/12/2014 -> hrnb
        Public Function ListarArchivoDigitalByte(IdArchivoDigital As Integer, TipoArchivo As Integer, ByRef outErrSms As String,
                                                 Optional ByVal ServicioSedeCentral As Boolean = False) As Byte()

            Dim ent As Entity.Globall.ArchivoDigital
            ent = ListarArchivoDigital(IdArchivoDigital, TipoArchivo, outErrSms, ServicioSedeCentral)
            If ent Is Nothing Then Return Nothing
            Return ent.ArchivoByte

        End Function

        Private Function Validar(objDigital As Entity.Globall.ArchivoDigital, ByRef outErrSms As String) As Integer
            Dim v As Integer = 0 'o:sin error, -1:con error
            outErrSms = ""
            If objDigital.Extension = "" Then outErrSms = "No se ha especificado extensión del archivo"
            If objDigital.Tipo <= 0 Then outErrSms = If(outErrSms.Length > 0, ", ", "") & "Debe especificar el tipo de fotografia (Interno,Visitante,Reniec,etc.)"
            If objDigital.ArchivoByte Is Nothing Then outErrSms = If(outErrSms.Length > 0, ", ", "") & "No se ha cargado ninguna imagen"
            If objDigital.CodigoExt_id < 0 Then outErrSms = If(outErrSms.Length > 0, ", ", "") & "Id de interno o visitante o reniec no válido"
            If objDigital.Region = -1 Then outErrSms = If(outErrSms.Length > 0, ", ", "") & "Id de región no válido"
            If objDigital.Penal = -1 Then outErrSms = If(outErrSms.Length > 0, ", ", "") & "Id de penal no válido"

            If outErrSms.Length > 0 Then v = -1

            Return v
        End Function

        Public Function getArchivoDigitalByte_Region(intIDArchivoDigital As Integer, intTipoImagen As Integer,
                                                    ByRef strmMensajeOut As String) As Byte()

            Dim strNombre As String = ""
            Dim strPathServer As String = ""

            Dim objEnt As New Entity.Globall.ArchivoDigital
            objEnt = Listar_ArchivoDigital_v2(intIDArchivoDigital)

            strNombre = objEnt.NombreFisico
            Dim intPos As Integer = 0
            intPos = strNombre.LastIndexOf(".")

            If intPos < 1 Then
                strNombre = strNombre & ".jpg "
            End If

            strPathServer = objEnt.RutaServidor

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Timeout = 7000 'NUEVO JMR
            objWS.Url = APPWebService.PathURL.WSPopeSedeCentral

            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                Try
                    Dim lngFecha As Long = objWS.FechaHoy()
                Catch ex2 As Exception 'segundo intento
                    strmMensajeOut = "Servicio no disponible"
                    Return Nothing
                End Try
            End Try

            Dim objValue As Byte()

            Try
                objValue = objWS.LeerArchivoByte(intTipoImagen, strNombre, strPathServer)
            Catch ex As Exception
                objValue = Nothing
            End Try

            Return objValue

        End Function
#End Region
#Region "Grabar"
        Public Function GrabarImage(ByVal Codigo As Integer, ByVal NameFile As String, _
                                    ByVal strPathArchivo As String, _
        ByVal TransferenciaInternoID As Integer, ByVal TransferenciaPenal As Integer, _
        ByVal TransferenciaRegion As Integer, ByVal Tipo As Type.Enumeracion.ArchivoDigital.TipoImagen) As Integer

            Dim intValue As Integer = -1

            If strPathArchivo.Trim = "" Then
                Return intValue
            End If

            Dim strNombrePC As String = Legolas.Components.PC.PCNombre
            Dim strPCIP As String = ""
            Dim strDirectorio As String = ""
            Dim strArchivoExtension As String = ""
            Dim lngArchivoPeso As Long = 0
            Dim lngFechaCreacion As Long = 0
            Dim lngFechaModificacion As Long = 0
            Dim bytArchivo As Byte() = Nothing
            Dim lngFechaImportacion As Long = 0

            Try
                strPCIP = Legolas.Components.PC.GetIP
            Catch ex As Exception
                strPCIP = Legolas.Components.PC.GetMAC
            End Try

            Try
                strDirectorio = Legolas.Components.Archivo.DirectorioNombre(strPathArchivo)
                strArchivoExtension = Legolas.Components.Archivo.FileExtension(strPathArchivo)
                lngArchivoPeso = Legolas.Components.Archivo.FilePeso(strPathArchivo)
                lngFechaCreacion = Legolas.Components.Archivo.FileFechaCreacion(strPathArchivo)
                lngFechaModificacion = Legolas.Components.Archivo.FileFechaModificacion(strPathArchivo)
                'Dim strNombreArchivo As String = Legolas.Components.Archivo.FileNombre(strPathArchivo)
                bytArchivo = Legolas.Components.Archivo.FileConvertByte(strPathArchivo)

            Catch ex As Exception

            End Try

            lngFechaImportacion = Legolas.Configuration.Aplication.FechayHora.FechaLong

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Grabar(strAccion, strOpcion, _
            Codigo, TransferenciaInternoID, TransferenciaPenal, TransferenciaRegion, _
            "", "", strNombrePC, strPCIP, strDirectorio, NameFile, strArchivoExtension, _
            lngArchivoPeso, lngFechaCreacion, lngFechaModificacion, lngFechaImportacion, _
            "", 0, 0, bytArchivo, Tipo, Legolas.Configuration.Usuario.Codigo)

            Return intValue

        End Function
        Private Function Grabar(ByVal _accion As String, ByVal _opcion As String, _
        ByVal Codigo As Integer, ByVal TransferenciaInternoID As Integer, _
        ByVal TransferenciaPenal As Integer, ByVal TransferenciaRegion As Integer, _
        ByVal RedNombre As String, ByVal RedDirectorio As String, _
        ByVal PCNombre As String, ByVal PCIP As String, ByVal Directorio As String, _
        ByVal NombreFisico As String, ByVal Extension As String, _
        ByVal PesoArchivo As Integer, ByVal FechaCreacion As Long, _
        ByVal FechaModificacion As Long, ByVal FechaImportacion As Long, _
        ByVal Descripcion As String, ByVal FechaVigenciaIni As Long, ByVal FechaVigenciaFin As Long, _
        ByVal Imagen As Byte(), ByVal Tipo As Integer, ByVal _usuario As Integer) As Integer

            Dim Value As Integer = -1

            Value = Data.Globall.ArchivoDigital.Grabar(_accion, _opcion, Codigo, _
            TransferenciaInternoID, TransferenciaPenal, TransferenciaRegion, _
            RedNombre, _
            RedDirectorio, PCNombre, PCIP, Directorio, NombreFisico, Extension, PesoArchivo, _
            FechaCreacion, FechaModificacion, FechaImportacion, Descripcion, FechaVigenciaIni, _
            FechaVigenciaFin, Imagen, Tipo, _usuario)

            Return Value

        End Function
        '16/12/2014 -> hrnb
        Public Function Grabar(ByVal objDigital As Entity.Globall.ArchivoDigital) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If objDigital.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Globall.ArchivoDigital.Grabar(strAccion, strOpcion, objDigital)

            Return intValue
        End Function
        Public Function Grabar_v2(ByVal objDigital As Entity.Globall.ArchivoDigital, ByRef outErrSms As String, Optional ByVal esServicioSedeCentral As Boolean = False) As Integer

            If Validar(objDigital, outErrSms) = -1 Then Return -1

            Dim objWS As New APPWebService.ws_foto.PopeLocal

            Dim dto As New APPWebService.ws_foto.Dto_ArchivoDigital
            Dim r As APPWebService.ws_foto.DTO_ResultOfInt32
            objWS.Timeout = -1
            objWS.Url = APPWebService.PathURL.WSPopeLocal
            If esServicioSedeCentral = True Then
                objWS.Url = APPWebService.PathURL.WSPopeSedeCentral
            End If

            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                'Throw New Exception("Servicio de fotografia no disponible")
                Return -1
            End Try

            With dto
                .Anio = objDigital.Anio
                .ArchivoByte = objDigital.ArchivoByte
                .Codigo = objDigital.Codigo
                .Descripcion = objDigital.Descripcion
                .Directorio = objDigital.Directorio
                .Extension = objDigital.Extension
                .FechaCreacion = objDigital.FechaCreacion
                .FechaImportacion = objDigital.FechaImportacion
                .FechaModificacion = objDigital.FechaModificacion
                .ImagenUploadWeb = objDigital.ImagenUploadWeb
                .IP = objDigital.IP
                .MAC = objDigital.MAC
                .Mes = objDigital.Mes
                .MesCorrelativo = objDigital.MesCorrelativo
                .NombreFisico = objDigital.NombreFisico
                .PC = objDigital.PC
                .Penal = objDigital.Penal
                .Peso = objDigital.Peso
                .Region = objDigital.Region
                .RutaServidor = objDigital.RutaServidor
                .Tipo = objDigital.Tipo
                .UsuarioId = Legolas.Configuration.Usuario.Codigo
                .CodigoExt_id = objDigital.CodigoExt_id
                .NumDocIdentidad = objDigital.NumDocIdentidad
                .TipoDocIdentidad = objDigital.TipoDocIdentidad
            End With

            r = objWS.SubirArchivoDigital(dto)
            If r Is Nothing Then r = objWS.SubirArchivoDigital(dto) 'segundo intento
            If r Is Nothing Then Return -1 'si retorna objeto vacio
            If r.Error_cod <> 0 Then
                outErrSms = ErrorMensaje(r.Error_cod)
                Return -1
            End If
            Return r.Resultado
        End Function
#End Region
#Region "Funcion"
        Public Function getSedeRowID(codigo As Integer, strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strQuery As String = "select isnull(_sed_rowid,-1) from GLO_ArchivoDigital where arc_dig_id=" & codigo
            Dim objDT As New DataTable

            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                objDT = Legolas.Components.SQL.Select_DataTable(sqlCon, strQuery, strMensajeOut)

                For Each objFila As DataRow In objDT.Rows
                    value = objFila.Item(0)
                Next
            End Using

            Return value

        End Function
#End Region
#Region "Listar"

        Public Function Listar_ArchivoDigital_v2(Codigo As Integer) As Entity.Globall.ArchivoDigital

            '16-12-2014 -01
            'no es posible eliminar o integrar a Listar_ArchivoDigital dado que envia y retorna campos que no estan contemplados en la version en prod.

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim entArchDig As New Entity.Globall.ArchivoDigital
            entArchDig.Codigo = Codigo

            Dim sqlDr As SqlDataReader = Data.Globall.ArchivoDigital.Listar_ArchivoDigital_v2(sqlCon, "lst", "lst_mant2", entArchDig)

            objEnt = New Entity.Globall.ArchivoDigital
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("arc_dig_id").ToString
                            .Tipo = sqlDr("arc_dig_tip").ToString
                            .CodigoExt_id = sqlDr("int_id").ToString
                            .Anio = sqlDr("arc_dig_anio").ToString
                            .Mes = sqlDr("arc_dig_mes").ToString
                            .MesCorrelativo = sqlDr("arc_dig_mes_cor").ToString
                            .MAC = sqlDr("arc_dig_pc_mac").ToString
                            .PC = sqlDr("arc_dig_pc").ToString
                            .IP = sqlDr("arc_dig_ip").ToString
                            .NombreFisico = sqlDr("arc_dig_nom_fis").ToString
                            .Extension = sqlDr("arc_dig_ext").ToString
                            .Peso = sqlDr("arc_dig_pes").ToString
                            .FechaModificacion = sqlDr("arc_dig_fec_mod").ToString
                            .FechaCreacion = sqlDr("arc_dig_fec_cre").ToString
                            .FechaImportacion = sqlDr("arc_dig_fec_imp").ToString
                            .RutaServidor = sqlDr("arc_dig_pth_ser").ToString
                            .ImagenUploadWeb = sqlDr("arc_dig_sub_web").ToString
                            .Directorio = sqlDr("arc_dig_dir").ToString
                            .Extension = sqlDr("arc_dig_ext").ToString
                            .Penal = sqlDr("_penid").ToString
                            .Region = sqlDr("_regid").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function

        Public Function Listar_ArchivoDigital(ByVal Codigo As Integer) As Entity.Globall.ArchivoDigital

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Globall.ArchivoDigital.Listar_ArchivoDigital(sqlCon, "lst", "lst_arc_dig", Codigo, "", "", _
            "", "", "", "", "", 0, 0, 0, 0, "", 0, 0)

            objEnt = New Entity.Globall.ArchivoDigital
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("arc_dig_id").ToString
                            .Anio = sqlDr("arc_dig_anio").ToString
                            .Mes = sqlDr("arc_dig_mes").ToString
                            .MesCorrelativo = sqlDr("arc_dig_mes_cor").ToString
                            .RutaServidor = sqlDr("arc_dig_pth_ser").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            Dim Usuario As Integer = Legolas.Configuration.Usuario.Codigo
            If Codigo > 0 Then
                strAccion = "del"
                strOpcion = "del_mant"
            End If
            intValue = Data.Globall.ArchivoDigital.Eliminar(strAccion, strOpcion, Codigo, Usuario)
            Return intValue
        End Function
#End Region
    End Class
End Namespace

