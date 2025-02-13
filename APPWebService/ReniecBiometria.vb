Public Class ReniecBiometria

    Private strWSURL As String = "http://localhost:56244/VerificacionBiometrica.asmx"
    'Private strWSURL As String = "http://srvdesappall:8080/SedeCentral/SedeBiometria/VerificacionBiometrica.asmx"

    Public Function GrabarHuellaUsuario(strNumeroDNI As String, strPrimerApellido As String, strSegundoApellido As String, strNombres As String,
                                        intTipoDedoIzquierda As Short, bytHuellaIzquierdaWSQ As Byte(), bytHuellaIzquierdaAnsi As Byte(),
                                        intTipoDedoDerecha As Short, byteHuellaDerechaWSQ As Byte(), bytHuellaDerechaAnsi As Byte(),
                                        intIDUsuario As Integer, strLoginUsuario As String,
                                        ByRef strMensajeOut As String) As Integer


        Dim value As Integer = -1
        Dim objDTO As New ws_reniec_biometria.DTO_HuellaUsuario
        Dim objResul As New ws_reniec_biometria.DTO_ResultOfInt32
        Dim objWS As New ws_reniec_biometria.VerificacionBiometrica
        objWS.Url = strWSURL

        With objDTO
            .NumeroDNI = strNumeroDNI
            .PrimerApellido = strPrimerApellido
            .SegundoApellido = strSegundoApellido
            .Nombres = strNombres
            'izquierdo
            .TipoDedoIzquierdo = intTipoDedoIzquierda
            .HuellaIzquierdoWSQ = bytHuellaIzquierdaWSQ
            .HuellaIzquierdoANSI = bytHuellaIzquierdaAnsi
            'derecho
            .TipoDedoDerecho = intTipoDedoDerecha
            .HuellaDerechoWSQ = byteHuellaDerechaWSQ
            .HuellaDerechoANSI = bytHuellaDerechaAnsi
            .UsuarioLogin = strLoginUsuario
            .IDUsuario = intIDUsuario
        End With

        Try

            objResul = objWS.GrabarHuellaUsuario(objDTO)

            If objResul.Error_Cod = 0 Then
                value = objResul.Resultado
            Else
                strMensajeOut = objResul.Error_Mensaje
            End If

        Catch ex As Exception
            strMensajeOut = ex.Message
        End Try

        Return value
    End Function

    Public Function CalidadHuellaUsuario(strNumeroDNI As String, strIP As String, strMac As String) As Result.CalidadHuella

        Return CalidadHuella("43476118", strNumeroDNI, strIP, strMac)

    End Function
    Public Function CalidadHuella(strDNIUsuario As String, strNumeroDNI As String, strIP As String, strMac As String) As Result.CalidadHuella


        Dim value As Result.CalidadHuella
        Dim objDTO As New ws_reniec_biometria.DTO_CalidadHuella
        Dim objDTOResul As New ws_reniec_biometria.DTO_ResultOfDTO_Result_CalidadHuella
        Dim objResul As New ws_reniec_biometria.DTO_Result_CalidadHuella

        Dim objWS As New ws_reniec_biometria.VerificacionBiometrica
        objWS.Url = strWSURL

        With objDTO
            .NumeroDNI_Ciudadano = strDNIUsuario
            .NumeroDNI_Usuario = strNumeroDNI
            .IP_Cliente = strIP
            .Mac_Cliente = strMac
        End With

        Try

            objDTOResul = objWS.ConsultarCalidadHuella(objDTO)
            value = New Result.CalidadHuella

            If objDTOResul.Error_Cod = 0 Then

                objResul = objDTOResul.Resultado

                With objResul
                    value.ErrorCodigo = .Respuesta
                    value.ErrorMensaje = .Descripcion
                    value.CodigoHuellaDerecha = .CodigoHuellaDerecha
                    value.DescripcionHuellaDerecha = .DescripcionHuellaDerecha
                    value.CodigoHuellaIzquierda = .CodigoHuellaIzquierda
                    value.DescripcionHuellaIzquierda = .DescripcionHuellaIzquierda
                End With
            Else
                value.ErrorCodigo = objDTOResul.Error_Cod
                value.ErrorMensaje = objDTOResul.Error_Mensaje
            End If

        Catch ex As Exception
            value = New Result.CalidadHuella
            value.ErrorCodigo = -1
            value.ErrorMensaje = ex.Message
        End Try

        Return value
    End Function

    Public Function VerificarHuella(strDNIUsuario As String, strNumeroDNI As String,
                                    bytHuellaIzquierda As Byte(), byteHuellaDerecha As Byte(),
                                    strIP As String, strMac As String) As Result.VerificarHuella

        Dim value As Result.VerificarHuella
        Dim objDTO As New ws_reniec_biometria.DTO_VerificarHuellaWSQ
        Dim objBodyResul As New ws_reniec_biometria.DTO_ResultOfDTO_ResultVerificarHuellaWSQ
        Dim objResul As New ws_reniec_biometria.DTO_ResultVerificarHuellaWSQ

        Dim objWS As New ws_reniec_biometria.VerificacionBiometrica
        objWS.Url = strWSURL

        With objDTO
            .NumeroDNI_Usuario = strDNIUsuario
            .NumeroDNI_Ciudadano = strNumeroDNI
            .HuellaWSQIzquierda = bytHuellaIzquierda
            .HuellaWSQDerecha = byteHuellaDerecha
            .IP_Cliente = strIP
            .Mac_Cliente = strMac
        End With

        objBodyResul = objWS.VerificarHuellaWSQ(objDTO)

        value = New Result.VerificarHuella

        If objBodyResul.Error_Cod = 0 Then

            objResul = objBodyResul.Resultado

            With objResul
                value.ErrorCodigo = .CodigoResultado
                value.ErrorMensaje = .Corresponde
                value.NumeroDNI = .NumeroDNI_Ciudadano
                value.PrimerApellido = .PrimerApellido
                value.SegundoApellido = .SegundoApellido
                value.Nombres = .Nombres
                value.FechaCaducidadDNI = .FechaCaducidadDNI
            End With

        Else
            value.ErrorCodigo = objBodyResul.Error_Cod
            value.ErrorMensaje = objBodyResul.Error_Mensaje
        End If

        Return value
    End Function
End Class
