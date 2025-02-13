Imports System.Threading.Tasks
Imports Entity

Namespace Visita

    Public Class VisitanteReniec

        Public Class objDTOPersona

            Public Property objPersona As APPWebService.ws_reniec_sede.NumeroDocumento
            Public Property HayServicioReniec As Boolean = False
            Public Property ErrorCodigo As Integer = -1
            Public Property ErrorMensaje As String = ""
        End Class

        Public Function ValidarVisitante(objPersona As APPWebService.ws_reniec_sede.NumeroDocumento, strNumeroDocumento As String, strPrimerApellido As String,
                                         strSegundoApellido As String,
                                         strPreNombre As String, intSexo As Short, lngFechaNacimiento As Long) As Boolean

            Dim value As Boolean = False

            Dim strValorOrigen As String = ""
            Dim strValorDestino As String = ""
            Dim strFechaNacimiento As String = ""

            With objPersona
                strValorOrigen = .NumeroDNI.Trim & .ApellidoPaterno.Trim & .ApellidoMaterno.Trim & .Nombres.Trim & .Sexo.Trim & .FechaNacimiento.Trim
            End With

            strFechaNacimiento = Legolas.Components.FechaHora.FechaString(lngFechaNacimiento)
            strValorDestino = strNumeroDocumento & strPrimerApellido & strSegundoApellido & strPreNombre & intSexo & strFechaNacimiento


            If strValorOrigen = strValorDestino Then
                value = True
            End If

            Return value

        End Function
        Public Function ValidarVisitanteApi(objPersona As List(Of ResultReniec), strNumeroDocumento As String, strPrimerApellido As String,
                                         strSegundoApellido As String,
                                         strPreNombre As String, intSexo As Short, lngFechaNacimiento As Long) As Boolean

            Dim value As Boolean = False

            Dim strValorOrigen As String = ""
            Dim strValorDestino As String = ""
            Dim strFechaNacimiento As String = ""

            With objPersona.Item(0)
                strValorOrigen = .numeroDNI.Trim & .apellidoPaterno.Trim & .apellidoMaterno.Trim & .nombres.Trim & .sexo.Trim & .fechaNacimiento.Trim
            End With

            strFechaNacimiento = Legolas.Components.FechaHora.FechaString(lngFechaNacimiento)
            strValorDestino = strNumeroDocumento & strPrimerApellido & strSegundoApellido & strPreNombre & intSexo & strFechaNacimiento


            If strValorOrigen = strValorDestino Then
                value = True
            End If

            Return value

        End Function
        Public Function ValidarDatosMigraciones(objPersona As APPWebService.Result.ConsultarExtranjero, strNumeroDocumento As String, strPrimerApellido As String,
                                         strSegundoApellido As String,
                                         strPreNombre As String, intSexo As Short, lngFechaNacimiento As Long, intIDNacionalidad As Integer) As Boolean

            Dim value As Boolean = False

            Dim strValorOrigen As String = ""
            Dim strValorDestino As String = ""

            Dim origenNumeroDoc As String = ""

            If objPersona.NumeroDocumento.Length < 3 Then
                origenNumeroDoc = strNumeroDocumento
            Else
                origenNumeroDoc = objPersona.NumeroDocumento
            End If

            With objPersona
                strValorOrigen = origenNumeroDoc & .PrimerApellido.Trim & .SegundoApellido.Trim & .Nombres.Trim & .IDSexo & .FechaNacimiento & .IDNacionalidad
            End With

            strValorDestino = strNumeroDocumento & strPrimerApellido & strSegundoApellido & strPreNombre & intSexo & lngFechaNacimiento & intIDNacionalidad


            If strValorOrigen = strValorDestino Then
                value = True
            End If

            Return value

        End Function
    End Class
End Namespace