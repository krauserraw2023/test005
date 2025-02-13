Imports System.Web.Services.Protocols

Namespace Globall
    Public Class Reniec
        Private Function EscribirCola(TipoConsulta As Integer, NumeroDNI As String, PrimerApellido As String,
                                         SegundoApellido As String, PreNombres As String,
                                         ByRef intErrorCodigo As Integer, ByRef strErrorMensaje As String) As APPWebService.ws_reniec_sede.Respuesta

            Dim objWs As New APPWebService.ws_reniec_sede.Identificacion
            objWs.Timeout = (1000 * 7)
            objWs.Url = APPWebService.PathURL.ws_reniec_mq_sede

            Dim objEntEscribirCola As New APPWebService.ws_reniec_sede.EscribirCola
            Dim objEntDTO As New APPWebService.ws_reniec_sede.DTO_ResultOfRespuesta
            Dim ObjEntRespuesta As New APPWebService.ws_reniec_sede.Respuesta

            Try
                objWs.FechaLong()
            Catch ex As Exception
                intErrorCodigo = -1
                strErrorMensaje = ex.ToString
                Return ObjEntRespuesta
            End Try

            If TipoConsulta = 2 Then
                NumeroDNI = ""
            End If

            With objEntEscribirCola
                .TipoConsulta = TipoConsulta
                .ConsultaNumeroDNI = NumeroDNI
                .ConsultaPrimerApellido = PrimerApellido
                .ConsultaSegundoApellido = SegundoApellido
                .ConsultaPreNombres = PreNombres
                .IP = Legolas.Components.PC.GetIP
                .Login = Legolas.Configuration.Usuario.Login
                .MAC = Legolas.Components.PC.GetMAC
                .KeySistema = "0BE81EDAC59E48DB"
                .ClaveSistema = "AU2-m0*7MP9+l"
            End With

            objEntDTO = objWs.Solicitud(objEntEscribirCola)

            'leer los ids de las colas       
            If objEntDTO.Error_Cod = 0 And objEntDTO.Error_Mensaje = "" Then
                ObjEntRespuesta = objEntDTO.Resultado
                strErrorMensaje = objEntDTO.Error_Mensaje
                intErrorCodigo = 0
            Else
                intErrorCodigo = objEntDTO.Error_Cod
                intErrorCodigo = -1
                strErrorMensaje = objEntDTO.Error_Mensaje
            End If

            Return ObjEntRespuesta

        End Function

        Private Function LeerCola_NumeroDNI_Resultado(objCola As APPWebService.ws_reniec_sede.Respuesta, _
                                                       ByRef intErrorCodigo As Integer, ByRef strErrorMensaje As String) As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento

            Threading.Thread.Sleep(1000 * 3)

            Dim objWs As New APPWebService.ws_reniec_sede.Identificacion
            objWs.Timeout = (1000 * 7)
            objWs.Url = APPWebService.PathURL.ws_reniec_mq_sede '"http://ws.inpe.gob.pe/Reniec/ReniecTest/Identificacion.asmx" '

            Dim objEntLeerCola As New APPWebService.ws_reniec_sede.LeerCola
            Dim objEntDTO As New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento

            Try
                objWs.FechaLong()
            Catch ex As Exception

                intErrorCodigo = -1
                strErrorMensaje = ex.ToString

                objEntDTO.Error_Cod = -1
                objEntDTO.Error_Mensaje = ex.ToString
                objEntDTO.Resultado = Nothing
                Return objEntDTO
            End Try

            If objCola.IDCola > 0 Then

                With objEntLeerCola
                    .IDSolicitud = objCola.IDSolicitud
                    .IDCola = objCola.IDCola
                    .IP = Legolas.Components.PC.GetIP
                    .Login = Legolas.Configuration.Usuario.Login
                    .MAC = Legolas.Components.PC.GetMAC
                End With

                objEntDTO = objWs.Solicitud_LeerDNI(objEntLeerCola)

                If objEntDTO.Error_Cod = 0 Then
                    intErrorCodigo = 0
                    Return objEntDTO
                Else
                    intErrorCodigo = objEntDTO.Error_Cod
                    strErrorMensaje = objEntDTO.Error_Mensaje
                End If

            End If

            Return objEntDTO

        End Function

        Private Function LeerCola_ApellidosNombres_Resultado(objCola As APPWebService.ws_reniec_sede.Respuesta, _
                                                       ByRef intErrorCodigo As Integer, ByRef strErrorMensaje As String) As APPWebService.ws_reniec_sede.DTO_ResultOfApellidosyNombres

            Threading.Thread.Sleep(1000 * 3)

            Dim objWs As New APPWebService.ws_reniec_sede.Identificacion
            objWs.Url = APPWebService.PathURL.ws_reniec_mq_sede

            Dim objEntLeerCola As New APPWebService.ws_reniec_sede.LeerCola
            Dim objEntDTO As New APPWebService.ws_reniec_sede.DTO_ResultOfApellidosyNombres

            Try
                objWs.FechaLong()
            Catch ex As Exception
                intErrorCodigo = -1
                strErrorMensaje = ex.ToString

                objEntDTO.Error_Cod = -1
                objEntDTO.Error_Mensaje = ex.ToString
                objEntDTO.Resultado = Nothing
                Return objEntDTO
            End Try

            If objCola.IDCola > 0 Then

                With objEntLeerCola
                    .IDSolicitud = objCola.IDSolicitud
                    .IDCola = objCola.IDCola
                    .IP = Legolas.Components.PC.GetIP
                    .Login = Legolas.Configuration.Usuario.Login
                    .MAC = Legolas.Components.PC.GetMAC
                End With

                objWs.Timeout = (60000 * 5)

                Try

                    objEntDTO = objWs.Solicitud_LeerApellidosyNombres(objEntLeerCola)

                    If objEntDTO.Error_Cod = 0 Then
                        intErrorCodigo = 0
                        Return objEntDTO
                    Else
                        intErrorCodigo = objEntDTO.Error_Cod.ToString
                        strErrorMensaje = objEntDTO.Error_Mensaje
                    End If

                Catch ex As SoapException

                    If ex.Message.Trim.Contains("Nombre del parámetro: length") = True Then
                        intErrorCodigo = -1
                        strErrorMensaje = "No existen los datos solicitados"
                    End If

                Catch ex As Exception

                End Try

            End If

            Return objEntDTO

        End Function

        Public Function WS_ReniecxDNI_Resultado(NumeroDNI As String) As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento

            Dim objCola As New APPWebService.ws_reniec_sede.Respuesta
            Dim objRespuesta As New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
            Dim intCodigoError As Integer = -1
            Dim strErrorMensaje As String = ""

            objCola = EscribirCola(1, NumeroDNI, "", "", "", intCodigoError, strErrorMensaje)

            If intCodigoError = 0 Then
                objRespuesta = LeerCola_NumeroDNI_Resultado(objCola, intCodigoError, strErrorMensaje)
            Else
                objRespuesta.Error_Cod = intCodigoError
                objRespuesta.Error_Mensaje = strErrorMensaje
                objRespuesta.Resultado = Nothing
            End If

            Return objRespuesta

        End Function
        Public Function WS_ReniecxDNI_Resultado(NumeroDNI As String,
                                                        ByRef intErrorCodigo As Integer, ByRef strErrorMensaje As String) As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento

            Dim objCola As New APPWebService.ws_reniec_sede.Respuesta
            Dim objRespuesta As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento = Nothing

            If Legolas.Components.PC.IsOnline = True Then

                objRespuesta = New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento

                objCola = EscribirCola(1, NumeroDNI, "", "", "", intErrorCodigo, strErrorMensaje)

                If intErrorCodigo = 0 Then
                    objRespuesta = LeerCola_NumeroDNI_Resultado(objCola, intErrorCodigo, strErrorMensaje)
                Else
                    objRespuesta.Error_Cod = intErrorCodigo
                    objRespuesta.Error_Mensaje = strErrorMensaje
                    objRespuesta.Resultado = Nothing
                End If

            End If        

            Return objRespuesta

        End Function

        Public Function WS_ReniecxApellidos_Resultado(ApePat As String, ApeMat As String, Nombres As String) As APPWebService.ws_reniec_sede.DTO_ResultOfApellidosyNombres

            Dim objCola As New APPWebService.ws_reniec_sede.Respuesta
            Dim objRespuesta As New APPWebService.ws_reniec_sede.DTO_ResultOfApellidosyNombres
            Dim intCodigoError As Integer = -1
            Dim strErrorMensaje As String = ""

            objCola = EscribirCola(2, "", ApePat, ApeMat, Nombres, intCodigoError, strErrorMensaje)

            If intCodigoError = 0 Then 'si no hay ningun error 
                objRespuesta = LeerCola_ApellidosNombres_Resultado(objCola, intCodigoError, strErrorMensaje)
                objRespuesta.Error_Cod = intCodigoError
                objRespuesta.Error_Mensaje = strErrorMensaje
            Else
                objRespuesta.Error_Cod = intCodigoError
                objRespuesta.Error_Mensaje = strErrorMensaje
                objRespuesta.Resultado = Nothing
            End If

            Return objRespuesta
        End Function
    End Class
End Namespace