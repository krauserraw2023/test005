Imports Entity
Imports Newtonsoft.Json
Imports System.Configuration
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class ReniecConsulta
    Public ListaPersonas As New List(Of ResultReniec)()

    Public Async Function ConsultarReniec(ByVal TipoBusqueda As Int16, ByVal NumeroDocumento As String, ByVal nombre As String, ByVal apepat As String, ByVal apemat As String, ByVal Modulo As String) As Task(Of List(Of ResultReniec))
        Try
            Dim API_RENIEC As String = ConfigurationManager.AppSettings("API_RENIEC")
            ' Crear el objeto de solicitud
            Dim solicitud As New RequestReniec With {
                .TipoConsulta = TipoBusqueda,
                .ConsultaNumeroDNI = NumeroDocumento,
                .ConsultaPrimerApellido = apepat,
                .ConsultaSegundoApellido = apemat,
                .ConsultaPreNombres = nombre,
                .Login = Legolas.Configuration.Usuario.Login,
                .MAC = Legolas.Components.PC.GetMAC,
                .IP = Legolas.Components.PC.GetIP,
                .KeySistema = "0BE81EDAC59E48DB",
                .ClaveSistema = "AU2-m0*7MP9+l",
                .IDModulo = 1,
                .Modulo = Modulo
            }
            '.Login = Legolas.Configuration.Usuario.Login,
            Dim username As String = "0BE81EDAC59E48DB"
            Dim password As String = "b6855d39f1df444a7b7a80f80511d5c9b11e35d95a1ed620f5f3e8abf5838d8a6a491e9c2e3e1565a5ddee1c8cb862bb05c491c2eb30e50b66113c607b78ba5e"
            Dim codigoSistema As String = "5"

            ' Codificar las credenciales en Base64
            Dim credenciales As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"))

            ' Configurar HttpClient
            Dim httpClient As New HttpClient()
            httpClient.DefaultRequestHeaders.Clear()
            httpClient.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", credenciales)
            httpClient.DefaultRequestHeaders.Add("codigoSistema", codigoSistema)

            ' Convertir el objeto a JSON
            Dim jsonContent As String = JsonConvert.SerializeObject(solicitud)
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

            ' URL del endpoint
            Dim URL As String = API_RENIEC

            ' Enviar la solicitud POST
            Dim response As HttpResponseMessage = Await httpClient.PostAsync(URL, content)

            If response.IsSuccessStatusCode Then
                ' Leer el contenido de la respuesta como string
                Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                Dim ListaRENIEC As New List(Of ResultReniec)
                Dim UnicoRegistro As Boolean = False

                If jsonString.TrimStart().StartsWith("[") Then
                    ' Deserializar como lista
                    ListaRENIEC = JsonConvert.DeserializeObject(Of List(Of ResultReniec))(jsonString)

                ElseIf jsonString.TrimStart().StartsWith("{") Then
                    ' Deserializar como objeto
                    Dim objetoReniec As ResultReniec = JsonConvert.DeserializeObject(Of ResultReniec)(jsonString)

                    If objetoReniec.coincidencia Is Nothing Then
                        UnicoRegistro = True
                    End If

                    If String.IsNullOrEmpty(objetoReniec.mensajeError) Then
                        objetoReniec.Datos = "S"
                        ListaRENIEC.Add(objetoReniec)
                    Else
                        ' En caso de error, agregar el objeto de error a la lista
                        ListaRENIEC.Add(New ResultReniec() With {
                            .codigoError = "-1000",
                            .mensajeError = objetoReniec.mensajeError
                        })
                    End If
                Else
                    ' Manejar excepciones: agregar un objeto con el mensaje de error
                    ListaRENIEC.Add(New ResultReniec() With {
                         .codigoError = "-1000",
                        .mensajeError = $"Formato de respuesta no reconocido."
                    })
                End If

                ' Procesar resultados
                If TipoBusqueda = 1 Then
                    Return ListaRENIEC
                Else
                    If UnicoRegistro Then
                        Return ListaRENIEC
                    End If
                    For Each registroReniec As ResultReniec In ListaRENIEC
                        If registroReniec.coincidencia IsNot Nothing Then
                            For Each RN As Coincidencia In registroReniec.coincidencia
                                Dim persona As New ResultReniec With {
                                    .numeroDNI = RN.numeroDNI,
                                    .Datos = RN.datos,
                                    .digitoVerificacion = RN.caracterVerificacion,
                                    .apellidoPaterno = RN.apellidoPaterno.Trim(),
                                    .apellidoMaterno = RN.apellidoMaterno.Trim(),
                                    .nombres = RN.preNombres.Trim()
                                }
                                ListaPersonas.Add(persona)
                            Next
                            Return ListaPersonas

                        End If
                    Next
                End If
            Else
                Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                ' Manejar excepciones: agregar un objeto con el mensaje de error
                ListaPersonas.Add(New ResultReniec() With {
                         .codigoError = "-1001",
                        .mensajeError = errorContent
                    })
                Return ListaPersonas
            End If
        Catch ex As Exception
            ListaPersonas.Add(New ResultReniec() With {
                        .codigoError = "-1002",
                        .mensajeError = ex.Message
                    })
            Return ListaPersonas
        End Try
        Return Nothing
    End Function


End Class
