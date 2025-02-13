
Imports Newtonsoft.Json
Imports System.Text
Imports Type.Enumeracion.Licencia

Imports System.Collections.Generic
Imports System.Reflection
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Entity

Namespace Registro.Reniec
    Public Class usrInternoReniecLineaV2
        Private objBssInt As Bussines.Registro.InternoReniec = Nothing
        Private bssGloArch As Bussines.Globall.ArchivoDigital = Nothing
        Public objBssGradoInstru As New Bussines.Globall.GradoInstruccion

        Private objEntArchivoDig As Entity.Globall.ArchivoDigital = Nothing
        Private objPersMemoCol As New List(Of Entity.Registro.InternoPersona)

        Public strMensaje As String = ""
        Public strCodigo As String = ""
        Public strCabecera As String = ""
#Region "Eventos"
        Public Event _Clik_CargarUltimaValidacionCerrar(Codigo As Integer)
        Public Event _Clik_CerrarFormulario()
#End Region
#Region "Propiedades"
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _IngresoInpeID As Integer = -1
        Public Property _NombreAsociadoValID As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno


        Private Property IDInternoReniec As Integer = -1
        Private Property Memoria As Integer = 0

        Public Property _NumeroDniAux() As String = ""
        Public Property _NumeroDni() As String
            Get
                Return Me.txtDni.Text
            End Get
            Set(ByVal value As String)
                Me.txtDni.Text = value
            End Set
        End Property
        Private Property DigitoVerificacion() As String
            Get
                Return Me.txtDigitoVeri.Text
            End Get
            Set(ByVal value As String)
                Me.txtDigitoVeri.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtPrimerApellido.Text()
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property ApellidoCasada() As String
            Get
                Return Me.txtApellidoCasada.Text
            End Get
            Set(ByVal value As String)
                Me.txtApellidoCasada.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private Property SexoID() As Integer = -1
        Private Property SexoNom() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
            End Set
        End Property

        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNac.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNac.Text = value
            End Set
        End Property
        Public Property EstadoCivilId As Integer = -1
        Private Property EstadoCivilNom() As String
            Get
                Return Me.txtEstadoCivil.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstadoCivil.Text = value
            End Set
        End Property
        Private Property NacimientoUbigeo() As String
            Get
                Return Me.txtUbigeoNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoNacimiento.Text = value
            End Set
        End Property
        Private Property NacimientoUbigeoMemo() As String
            Get
                txtUbigeoNacimiento.Clear()
                Return Me.txtUbigeoNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoNacimiento.Text = value
            End Set
        End Property
        Private Property Padre() As String
            Get
                Return Me.txtPadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtPadre.Text = value
            End Set
        End Property
        Private Property Madre() As String
            Get
                Return Me.txtMadre.Text
            End Get
            Set(ByVal value As String)
                Me.txtMadre.Text = value
            End Set
        End Property
        Private Property DepartamentoDomicilio As String = ""
        Private Property ProvinciaDomicilio As String = ""
        Private Property DistritoDomicilioDomicilio As String = ""
        Private Property Ubigeo() As String
            Get
                Return Me.txtUbigeo.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeo.Text = value
            End Set
        End Property
        Private Property Direccion() As String
            Get
                Return Me.txtUbigeoDireccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoDireccion.Text = value
            End Set
        End Property

        Private Property UbigeoMem() As String
            Get
                txtUbigeo.Clear()
                Return Me.txtUbigeo.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeo.Text = value
            End Set
        End Property

        Private Property DireccionMemo() As String
            Get
                Return Me.txtUbigeoDireccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoDireccion.Text = value
            End Set
        End Property
        Private Property Talla() As String
            Get
                Return Me.txtTalla.Text
            End Get
            Set(ByVal value As String)
                Me.txtTalla.Text = value
            End Set
        End Property
        Private Property GradoInstruccionID As Integer = -1
        Private Property GradoInstruccionNom() As String
            Get
                Return Me.txtGradoInstruccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtGradoInstruccion.Text = value
            End Set
        End Property
        Private Property Observaciones() As String
            Get
                Return Me.txtObservaciones.Text
            End Get
            Set(ByVal value As String)
                Me.txtObservaciones.Text = value
            End Set
        End Property
        Private Property Restriccion() As String
            Get
                Return Me.txtRestriccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRestriccion.Text = value
            End Set
        End Property
        Private Property FechaInscripcion() As String
            Get
                Return Me.lblFechaInscripcion.Text
            End Get
            Set(ByVal value As String)
                Me.lblFechaInscripcion.Text = value
            End Set
        End Property
        Private Property FechaEmision() As String
            Get
                Return Me.lblFechaemision.Text
            End Get
            Set(ByVal value As String)
                Me.lblFechaemision.Text = value
            End Set
        End Property

        Private Property TipoVeriResultado() As Integer
            Get
                Return Me.cbbTipoVerificacion.SelectedIndex
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoVerificacion.SelectedIndex = value
            End Set
        End Property

        Public Property FotoByte() As Byte() = Nothing

#End Region
#Region "Propiedades Auxiliares"
        Public objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento

        Public intTipoComparacion As Integer = -1
        Public Property _TipoComparacion() As Integer
            Get
                Return intTipoComparacion
            End Get
            Set(ByVal value As Integer)
                intTipoComparacion = value
            End Set
        End Property
        Public Property _ListaInternoSisCabecera() As String = ""
        Public Property _ListaInternoSisData() As String = ""
        Public Property _NombresAsociados As String = ""
        Public Property _ReniecData As String = ""
        Private Property VariableColor As Integer = 0
        Private Property strLista As String = ""
#End Region
#Region "Propiedades_Imagen"
        Private strImagenNamePF As String = ""
        Private strImagenPathLocal As String = ""

        Private Property ImagenReniec() As Integer = -1
        Public Property _ImagenSis() As Integer = -1

        Private Property ImagenNamePF() As String
            Get
                Return strImagenNamePF.Trim
            End Get
            Set(ByVal value As String)
                strImagenNamePF = value
            End Set
        End Property
        Private Property ImagenPathLocal() As String
            Get
                Return strImagenPathLocal.Trim
            End Get
            Set(ByVal value As String)
                strImagenPathLocal = value
            End Set
        End Property
        Private Property ImagenTipo() As Integer
            Get
                Return 4
            End Get
            Set(ByVal value As Integer)
                'intvalue = value
            End Set
        End Property
#End Region

#Region "Propiedades_ImagenConfig"
        Public Property _EnabledDobleClick() As Boolean = True
        Private Sub Form_FotoAutoSize()
            If Me._EnabledDobleClick = False Then
                Exit Sub
            End If
            If Me.picFoto.Image Is Nothing = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se puede hacer zoom a la foto")
                Exit Sub
            End If
            Dim frm As New Foto.frmFotoZoomPopup
            With frm
                ._pImagen = Me.picFoto.Image
                ._pSizeMode = PictureBoxSizeMode.Zoom
                .ShowDialog()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Function Listar() As Boolean

            If Me._NumeroDni = "" Then
                Exit Function
            End If

            Dim Valor As Boolean
            If Me._TipoComparacion = 1 Then

            Else
                If Me.Memoria > 0 Then
                    cbbTipoVerificacion.SelectedIndex = 0
                    Dim intValor As Integer = 0
                    Dim indice As Integer = -1

                    For Each entIntPers As Entity.Registro.InternoPersona In objPersMemoCol
                        indice = indice + 1
                        If entIntPers.NumeroDocumento = Me._NumeroDni Then
                            intValor = intValor + 1
                            Exit For
                        End If
                    Next
                    If intValor = 0 Then
                        Valor = ListarReniecLinea()
                        Return Valor
                    Else
                        With objPersMemoCol
                            Me._NumeroDni = .Item(indice).NumeroDocumento
                            Me.DigitoVerificacion = .Item(indice).DigitoVerificacion
                            Me.ApellidoPaterno = .Item(indice).ApellidoPaterno
                            Me.ApellidoMaterno = .Item(indice).ApellidoMaterno
                            Me.ApellidoCasada = .Item(indice).ApellidoCasada
                            Me.Nombres = .Item(indice).Nombres
                            Me.SexoID = .Item(indice).SexoID
                            Me.FechaNacimiento = .Item(indice).FechaNacimiento2

                            Me.UbigeoMem = .Item(indice).UbigeoDepProvDist

                            Me.GradoInstruccionNom = .Item(indice).GradoInstruccionNombre
                            Me.Talla = .Item(indice).Estatura

                            Me.NacimientoUbigeoMemo = .Item(indice).NacimientoDepProvDist

                            Me.EstadoCivilId = .Item(indice).EstadoCivilID
                            Me.Padre = .Item(indice).NombrePadre
                            Me.Madre = .Item(indice).NombreMadre
                            Me.DireccionMemo = .Item(indice).DomicilioDireccion
                            Me.Restriccion = .Item(indice).Restriccion
                            Me.FechaInscripcion = .Item(indice).FechaInscripcion
                            Me.FechaEmision = .Item(indice).FechaExpedicion
                        End With
                        Valor = True

                    End If
                Else
                    Valor = ListarReniecLinea()

                End If
            End If
            If Valor = True Then
                ColorComparar()
            End If
            Return Valor
        End Function
        Private Function EstadoCivil(EstadoID) As String
            Dim strNombre As String = ""
            Select Case EstadoID
                Case 1
                    strNombre = "SOLTERO"
                Case 2
                    strNombre = "CASASO"

                Case 3
                    strNombre = "VIUDO"

                Case 4
                    strNombre = "DIVORCIADO"

            End Select
            Return strNombre
        End Function
        Private Function ListarReniecLinea() As Boolean
            Dim value As Boolean = False
            strCabecera = "Validación de Verificacion con RENIEC"
            Try
                If Legolas.Components.PC.IsOnline = True Then

                    Dim objBssRnc As New Bussines.Globall.Reniec
                    objPersona = New APPWebService.ws_reniec_sede.NumeroDocumento
                    Dim objPersonaCabecera As New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
                    objPersonaCabecera = objBssRnc.WS_ReniecxDNI_Resultado(Me._NumeroDni)
                    objPersona = objPersonaCabecera.Resultado

                    If objPersonaCabecera.Error_Cod <> 0 Then '///Cuando no se puede conectar con el servidor
                        Select Case objPersonaCabecera.Error_Mensaje
                            Case "No se puede conectar al servidor MQ-Reniec"
                                strMensaje = "En estos momentos no se puede conectar al Servidor Reniec por favor intentelo mas tarde"
                            Case Else
                                strMensaje = objPersonaCabecera.Error_Mensaje
                        End Select
                        strCodigo = "INACTIVO"
                        Me.Cursor = Cursors.Default
                        value = False
                    Else
                        With objPersona
                            Me._NumeroDni = Trim(.NumeroDNI)
                            Me.DigitoVerificacion = Trim(.DigitoVerificacion)
                            Me.ApellidoPaterno = Trim(.ApellidoPaterno)
                            Me.ApellidoMaterno = Trim(.ApellidoMaterno)
                            Me.ApellidoCasada = Trim(.ApellidoCasada)
                            Me.Nombres = Trim(.Nombres)
                            Me.SexoID = IIf(Trim(.Sexo) = "", -1, Trim(.Sexo))
                            Me.SexoNom = IIf(Me.SexoID = "1", "MAS", "FEM")
                            Me.FechaNacimiento = Trim(.FechaNacimiento)
                            Me.Ubigeo = Trim(.DepartamentoDomicilio) & "/" & Trim(.ProvinciaDomicilio) & "/" & Trim(.DistritoDomicilio)
                            Me.EstadoCivilId = Trim(.EstadoCivil)
                            Me.EstadoCivilNom = NombreEstadoCivil(Me.EstadoCivilId)
                            Me.GradoInstruccionNom = Me.NombreGradoInstruccionReniec(Trim(.CodigoGradoInstruccion))
                            Me.Talla = Trim(.Estatura)
                            Me.NacimientoUbigeo = Trim(.DepartamentoNacimiento) & "/" & Trim(.ProvinciaNacimiento) & "/" & Trim(.DistritoNacimiento)
                            Me.Padre = Trim(.NombrePadre)
                            Me.Madre = Trim(.NombreMadre)
                            Me.Direccion = Trim(.PrefijoDireccion) & " " & Trim(.Direccion) & " " & Trim(.NumeroDireccion) _
                              & " " & Trim(.BlockChalet) & " " & Trim(.Interior) & " " & Trim(.Urbanizacion) _
                             & " " & Trim(.Etapa) & " " & Trim(.Manzana) & " " & Trim(.Lote) _
                             & " " & Trim(.PrefijoBlockChalet) & " " & Trim(.PrefijoDepartamentoInterior) & " " & Trim(.PrefijoUrbanizacion)
                            Me.Restriccion = IIf(.Restriccion = "  ", "NINGUNA", Trim(.Restriccion))
                            Me.FechaInscripcion = .FechaInscripcion
                            Me.FechaEmision = .FechaExpedicion
                            Me.FotoByte = .FotoByte
                            ListarFoto()
                            ColorComparar()
                            value = True
                        End With
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    strCodigo = "-1"
                    strMensaje = "No se ha podido realizar la conexion, porque se ha dectectado una baja o nula conexión a internet con la Sede Central"
                    value = False
                End If
                Return value
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                strCodigo = "-1"
                strMensaje = "Se ha detectado problemas con el servicio de verificacion RENIEC"
                strMensaje = strMensaje & Chr(13) & ex.Message.ToString
            End Try
        End Function
        Private Async Function ConsultarReniecLinea() As Task
            Try
                ' Crear el objeto de solicitud
                Dim solicitud As New Entity.Registro.InternoReniecModel With {
                    .TipoConsulta = Me._TipoComparacion,
                     .ConsultaNumeroDNI = Me._NumeroDni,
                      .Login = "USR1690",
                        .MAC = "10E7C6AC5B69",
                        .IP = "192.168.10.10",
                        .KeySistema = "0BE81EDAC59E48DB",
                        .ClaveSistema = "AU2-m0*7MP9+l",
                        .IDModulo = 3,
                        .Modulo = "BUSCAR PERSONAL"
                }

                Dim username As String = "D34F6D12A1FE4310"
                Dim password As String = "76ea06053e145dd40256644d4c5f2b8600e0be46b546da69929d3ae6b69683c71ad4edd8178b1c7665927d3806ac7f378f1a99558fa6a8d51f6f6800a46dae3d"
                Dim codigoSistema As String = "3"
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
                Dim URL As String = "https://ws.inpe.gob.pe/Reniec/ConsultaMQ_Core/Reniec/Solicitud_Respuesta_DNI"

                ' Enviar la solicitud POST
                Dim response As HttpResponseMessage = Await httpClient.PostAsync(URL, content)

                If response.IsSuccessStatusCode Then
                    ' Leer el contenido de la respuesta como string
                    Dim jsonString As String = Await response.Content.ReadAsStringAsync()

                    Dim ListaRENIEC As New List(Of Entity.Registro.InternoReniecModel)
                    Dim UnicoRegistro As Boolean = False

                    If jsonString.TrimStart().StartsWith("[") Then
                        ' Deserializar como lista
                        ListaRENIEC = JsonConvert.DeserializeObject(Of List(Of Entity.Registro.InternoReniecModel))(jsonString)

                    ElseIf jsonString.TrimStart().StartsWith("{") Then
                        ' Deserializar como objeto
                        Dim objetoReniec As Entity.Registro.InternoReniecModel = JsonConvert.DeserializeObject(Of Entity.Registro.InternoReniecModel)(jsonString)
                        '------------------Revisar la funcion--------
                        'If objetoReniec.coincidencia Is Nothing Then
                        '    UnicoRegistro = True
                        'End If

                        If String.IsNullOrEmpty(objetoReniec.mensajeError) Then
                            ListaRENIEC.Add(objetoReniec)
                        Else
                            MessageBox.Show("Error: " & objetoReniec.mensajeError)
                            Return
                        End If
                    Else
                        MessageBox.Show("Formato de respuesta no reconocido.")
                        Return
                    End If

                    ' Procesar resultados
                    If Me._TipoComparacion = 1 Then ' Por DNI
                        For Each registroReniec As Entity.Registro.InternoReniecModel In ListaRENIEC
                            ' Crear y añadir un nuevo objeto AutoridadModel
                            Dim persona As New Entity.Registro.InternoReniecModel With {
                            .numeroDNI = registroReniec.numeroDNI,
                            .apellidoPaterno = registroReniec.apellidoPaterno.Trim(),
                            .apellidoMaterno = registroReniec.apellidoMaterno.Trim(),
                            .nombres = registroReniec.nombres.Trim(),
                            .fechaNacimiento = registroReniec.fechaNacimiento,
                            .sexo = registroReniec.sexo.Trim(),
                            .fotoByte = registroReniec.fotoByte,
                            .firmaByte = registroReniec.firmaByte
                        }
                            CargarDataReniec(persona)
                            'txtNombre.Text = persona.nombres
                            'txtApellido.Text = persona.apellidoPaterno
                            'txtSegundoApe.Text = persona.apellidoMaterno
                        Next
                    Else
                        'For Each registroReniec As ResultReniecModel In ListaRENIEC
                        '    If UnicoRegistro Then
                        '        ' Crear y añadir un nuevo objeto AutoridadModel
                        '        ' Crear y añadir un nuevo objeto AutoridadModel
                        '        Dim persona As New ResultReniecModel With {
                        '    .numeroDNI = registroReniec.numeroDNI,
                        '    .ApellidoPaterno = registroReniec.apellidoPaterno.Trim(),
                        '    .ApellidoMaterno = registroReniec.apellidoMaterno.Trim(),
                        '    .Nombres = registroReniec.nombres.Trim(),
                        '    .FechaNacimiento = registroReniec.fechaNacimiento,
                        '    .sexo = registroReniec.sexo.Trim(),
                        '    .FotoByte = registroReniec.fotoByte,
                        '    .firmaByte = registroReniec.firmaByte
                        '    }
                        '        txtNombre.Text = persona.nombres
                        '        txtApellido.Text = persona.apellidoPaterno
                        '        txtSegundoApe.Text = persona.apellidoMaterno

                        '    ElseIf registroReniec.coincidencia IsNot Nothing Then
                        '        For Each Registro In registroReniec.coincidencia
                        '            Dim persona As New ResultReniecModel With {
                        '            .numeroDNI = Registro.numeroDNI,
                        '            .ApellidoPaterno = Registro.apellidoPaterno.Trim(),
                        '            .ApellidoMaterno = Registro.apellidoMaterno.Trim(),
                        '            .Nombres = Registro.preNombres.Trim()
                        '        }
                        '            ListaPersonas.Add(persona)
                        '        Next
                        '        DataGridView1.DataSource = ListaPersonas

                        '    End If
                        'Next
                    End If
                Else
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show("Error: " & errorContent)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al realizar la consulta: " & ex.Message)
            End Try

        End Function
        Private Sub CargarDataReniec(persona As Entity.Registro.InternoReniecModel)
            txtPrenombres.Text = persona.nombres
            txtPrimerApellido.Text = persona.apellidoPaterno
            txtSegundoApellido.Text = persona.apellidoMaterno
        End Sub

        Public Async Function _Load() As Task(Of Boolean)
            ' Dim Valor As Boolean = ListarReniecLinea()
            Dim Valor As Boolean = Await ListarReniecLineaAPIAsync()
            Return Valor
        End Function

        Private Async Function ListarReniecLineaAPIAsync() As Task(Of Boolean)
            Dim value As Boolean = False
            strCabecera = "Validación de Verificacion con RENIEC"
            Try
                If Legolas.Components.PC.IsOnline = True Then

                    Dim bss As New Bussines.ReniecConsulta
                    Dim ListaRENIEC As New List(Of ResultReniec)

                    ListaRENIEC = Await bss.ConsultarReniec(1, Me._NumeroDni, "", "", "", Me.Name)

                    If ListaRENIEC IsNot Nothing Then
                        For Each registroReniec As ResultReniec In ListaRENIEC
                            If (registroReniec.codigoError <> "") Then
                                If (registroReniec.codigoError < 0) Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ocurrió un error interno al conectarse con el servicio de la RENIEC. " + registroReniec.mensajeError)
                                    Me.Cursor = Cursors.Default
                                    strCodigo = registroReniec.mensajeError
                                    value = False
                                    Return value
                                    Exit Function
                                End If
                            End If
                            With objPersona
                                Me._NumeroDni = Trim(registroReniec.numeroDNI)
                                Me.DigitoVerificacion = Trim(registroReniec.digitoVerificacion)
                                Me.ApellidoPaterno = Trim(registroReniec.apellidoPaterno)
                                Me.ApellidoMaterno = Trim(registroReniec.apellidoMaterno)
                                Me.ApellidoCasada = Trim(registroReniec.apellidoCasada)
                                Me.Nombres = Trim(registroReniec.nombres)
                                Me.SexoID = IIf(Trim(registroReniec.sexo) = "", -1, Trim(registroReniec.sexo))
                                Me.SexoNom = IIf(Me.SexoID = "1", "MAS", "FEM")
                                Me.FechaNacimiento = Trim(registroReniec.fechaNacimiento)
                                Me.Ubigeo = Trim(registroReniec.departamentoDomicilio) & "/" & Trim(registroReniec.provinciaDomicilio) & "/" & Trim(registroReniec.distritoDomicilio)
                                Me.EstadoCivilId = Trim(registroReniec.estadoCivil)
                                Me.EstadoCivilNom = NombreEstadoCivil(Me.EstadoCivilId)
                                Me.GradoInstruccionNom = Me.NombreGradoInstruccionReniec(Trim(registroReniec.codigoGradoInstruccion))
                                Me.Talla = Trim(registroReniec.estatura)
                                Me.NacimientoUbigeo = Trim(registroReniec.departamentoNacimiento) & "/" & Trim(registroReniec.provinciaNacimiento) & "/" & Trim(registroReniec.distritoNacimiento)

                                Me.Padre = Trim(registroReniec.nombrePadre)
                                Me.Madre = Trim(registroReniec.nombreMadre)
                                Me.Direccion = Trim(registroReniec.prefijoDireccion) & " " & Trim(registroReniec.direccion) & " " & Trim(registroReniec.numeroDireccion) _
                              & " " & Trim(registroReniec.blockChalet) & " " & Trim(registroReniec.interior) & " " & Trim(registroReniec.urbanizacion) _
                             & " " & Trim(registroReniec.etapa) & " " & Trim(registroReniec.manzana) & " " & Trim(registroReniec.lote) _
                             & " " & Trim(registroReniec.prefijoBlockChalet) & " " & Trim(registroReniec.prefijoDepartamentoInterior) & " " & Trim(registroReniec.prefijoUrbanizacion)
                                Me.Restriccion = IIf(registroReniec.restriccion = "  ", "NINGUNA", Trim(registroReniec.restriccion))
                                Me.FechaInscripcion = registroReniec.fechaInscripcion
                                Me.FechaEmision = registroReniec.fechaExpedicion
                                Try
                                    ' Decodificar la cadena base64 a un arreglo de bytes
                                    Dim imageBytes As Byte() = Convert.FromBase64String(registroReniec.fotoByte)

                                    Me.FotoByte = imageBytes
                                Catch ex As Exception

                                    Me.FotoByte = Nothing
                                End Try

                                ListarFoto()
                                ColorComparar()
                                value = True

                            End With
                        Next
                        Me.Cursor = Cursors.Default
                    Else
                        Me.Cursor = Cursors.Default
                        strCodigo = "-1"
                        strMensaje = "No se ha podido realizar la conexion, porque se ha dectectado una baja o nula conexión a internet con la Sede Central"
                        value = False
                    End If

                    Return value
                Else
                    Return value
                End If
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                strCodigo = "-1"
                strMensaje = "Se ha detectado problemas con el servicio de verificacion RENIEC"
                strMensaje = strMensaje & Chr(13) & ex.Message.ToString
                Return value
            End Try
        End Function
#End Region
#Region "Validar"

        Private Function ValidarEntrada() As Boolean

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha cargado ningun Interno")
                Return False

            ElseIf cbbTipoVerificacion.SelectedIndex < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar el Tipo de Verificacion")
                cbbTipoVerificacion.Focus()
                Return False

            ElseIf VariableColor > 0 And txtObservaciones.Text = "" Then

                If cbbTipoVerificacion.SelectedIndex = 3 Then
                    Return True
                Else
                    If Legolas.Configuration.Aplication.MessageBox.Question( _
                                       "Existen datos del interno que no coinciden con la RENIEC," + Chr(13) +
                                       "Desea agregar una Observacion.", "ADVERTENCIA") _
                                   = Windows.Forms.DialogResult.Yes Then
                        txtObservaciones.Focus()
                        Return False
                    Else
                        Return True
                    End If
                End If
            Else
                Return True
            End If
        End Function
#End Region
#Region "Funciones"

        Private Function NombreGradoInstruccionReniec(ByVal varInstruccion As String)
            Dim EntRnc As New Entity.Globall.GradoInstruccion
            If varInstruccion = "" Then
                varInstruccion = "0"
            End If
            EntRnc.Codigo = 0
            EntRnc.CodigoRnc = varInstruccion
            objBssGradoInstru = New Bussines.Globall.GradoInstruccion
            varInstruccion = objBssGradoInstru.Listar(EntRnc).Nombre
            Return varInstruccion
        End Function

        Private Sub ListarEntity_ArchivoDigital()

            objEntArchivoDig = New Entity.Globall.ArchivoDigital

            With objEntArchivoDig
                .Codigo = -1
                .MAC = Legolas.Components.PC.GetMAC
                .PC = Legolas.Components.PC.PCNombre
                .IP = Legolas.Components.PC.GetIP
                .CodigoExt_id = Me.IDInternoReniec
                .Region = Me._RegionID
                .Penal = Me._PenalID
                .Tipo = Me.ImagenTipo
                .NombreFisico = Me._RegionID & "_" & Me._PenalID & "_" & Me.IDInternoReniec
                .ArchivoByte = Me.FotoByte
                .Extension = "jpg"
            End With

        End Sub

        Private Sub ColorComparar()
            Dim VarColor As Integer = 0
            Dim intColor As Boolean = False
            strLista = Me._ListaInternoSisData
            If strLista <> "" Then
                Dim strRegistro As String() = strLista.Split("|")
                intColor = ComparacionCadenas(strRegistro(0), Me._NumeroDni)
                If intColor = True Then
                    txtDni.BackColor = Color.LemonChiffon
                    txtDigitoVeri.BackColor = Color.LemonChiffon
                Else
                    txtDni.BackColor = Color.IndianRed
                    txtDigitoVeri.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(1), Me.ApellidoPaterno)
                If intColor = True Then
                    txtPrimerApellido.BackColor = Color.LemonChiffon
                Else
                    txtPrimerApellido.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(2), Me.ApellidoMaterno)
                If intColor = True Then
                    txtSegundoApellido.BackColor = Color.LemonChiffon
                Else
                    txtSegundoApellido.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(Trim(strRegistro(3)), Me.Nombres)
                If intColor = True Then
                    txtPrenombres.BackColor = Color.LemonChiffon
                Else '-1
                    txtPrenombres.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(4), Me.SexoNom)
                If intColor = True Then
                    txtSexo.BackColor = Color.LemonChiffon
                Else
                    txtSexo.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(5), Me.FechaNacimiento)
                If intColor = True Then
                    txtFechaNac.BackColor = Color.LemonChiffon
                Else
                    txtFechaNac.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(6), Me.NacimientoUbigeo)
                If intColor = True Then
                    txtUbigeoNacimiento.BackColor = Color.LemonChiffon
                Else
                    txtUbigeoNacimiento.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(7), Me.EstadoCivilNom)
                If intColor = True Then
                    txtEstadoCivil.BackColor = Color.LemonChiffon
                ElseIf intColor = 0 Then
                    txtEstadoCivil.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(8), Me.Ubigeo)
                If intColor = True Then
                    txtUbigeo.BackColor = Color.LemonChiffon
                Else
                    txtUbigeo.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                If strRegistro.Length > 15 Then
                    For i As Integer = 9 To strRegistro.Length - 6
                        If i > 9 Then
                            strRegistro(9) = strRegistro(9) & "|" & strRegistro(i)
                        End If
                    Next
                    strRegistro(10) = strRegistro(strRegistro.Length - 5)
                    strRegistro(11) = strRegistro(strRegistro.Length - 4)
                    strRegistro(12) = strRegistro(strRegistro.Length - 3)
                    strRegistro(13) = strRegistro(strRegistro.Length - 2)
                    strRegistro(14) = strRegistro(strRegistro.Length - 1)
                End If
                intColor = ComparacionCadenas(strRegistro(9), Me.Direccion)
                If intColor = True Then
                    txtUbigeoDireccion.BackColor = Color.LemonChiffon
                Else
                    txtUbigeoDireccion.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(10), Me.Padre)
                If intColor = True Then
                    txtPadre.BackColor = Color.LemonChiffon
                Else
                    txtPadre.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(11), Me.Madre)
                If intColor = True Then
                    txtMadre.BackColor = Color.LemonChiffon
                Else
                    txtMadre.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(13), Me.GradoInstruccionNom)
                If intColor = True Then
                    txtGradoInstruccion.BackColor = Color.LemonChiffon
                Else
                    txtGradoInstruccion.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                If Trim(strRegistro(14)) = "" Then
                Else
                    If strRegistro(14) < 2 Then
                        strRegistro(14) = strRegistro(14) * 100
                    End If
                End If
                intColor = ComparacionCadenas(CStr(Trim(strRegistro(14))), CStr(Trim(Me.Talla)))
                If intColor = True Then
                    txtTalla.BackColor = Color.LemonChiffon
                Else
                    txtTalla.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                Me.VariableColor = VarColor

            End If
        End Sub

        Private Function ComparacionCadenas(TestStr1 As String, TestStr2 As String) As Boolean
            Dim TestComp As Boolean
            ' valores         -1= no se parecen,0=iguales
            'TestComp = StrComp(TestStr1, TestStr2, CompareMethod.Text)
            If TestStr1 = TestStr2 Then
                TestComp = True
            Else
                TestComp = False
            End If
            Return TestComp
        End Function

        Private Function NombreEstadoCivil(EstadoCivID As Integer) As String
            Dim strNombre As String = ""
            ' valores         -1= no se parecen,0=iguales
            Select Case EstadoCivID
                Case 1
                    strNombre = "SOLTERO"
                Case 2
                    strNombre = "CASADO"

                Case 3
                    strNombre = "VIUDO"

                Case 4
                    strNombre = "DIVORCIADO"
            End Select
            Return strNombre
        End Function

        Private FotoReniecLinea As Byte()
        Private Sub ListarFoto()
            Try

                picFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(Me.FotoByte)
                FotoReniecLinea = Me.FotoByte
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            End Try
        End Sub

#End Region
#Region "Accion"

        Public Function Grabar() As Boolean

            If ValidarEntrada() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Desea grabar la validación") = DialogResult.Yes Then
                    AGrabar()
                    Return True
                End If
            End If

            Return False

        End Function

        Private Function AGrabar() As Boolean

            Dim blnValue As Boolean = False

            blnValue = AGrabarValidar()

            If blnValue = True Then
                RaiseEvent _Clik_CargarUltimaValidacionCerrar(Me.IDInternoReniec)
            Else
                RaiseEvent _Clik_CerrarFormulario()
            End If
            Return blnValue

        End Function

        Private Function AGrabarValidar() As Boolean

            Dim blnValue As Boolean = False

            If GrabarReniec() > 0 Then

                If Me.TipoVeriResultado = Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado Then
                    blnValue = True
                Else
                    If GrabarArchivoDigital() = True Then
                        blnValue = True
                    Else
                        blnValue = False
                    End If
                End If

            End If

            Return blnValue
        End Function

        Private Function GrabarReniec() As Integer

            Dim CabeceraReniec As String = ""
            Dim DatosReniec As String = ""

            objBssInt = New Bussines.Registro.InternoReniec
            Dim objEnt As Entity.Registro.InternoReniec = Nothing
            objEnt = New Entity.Registro.InternoReniec

            If Me.IDInternoReniec < 1 Then

                'objEnt.TablaID = -1
                objEnt.Codigo = -1
                objEnt.InternoID = Me._InternoID
                objEnt.IngresoID = Me._IngresoID
                objEnt.IngresoInpeId = Me._IngresoInpeID
                objEnt.RegionID = Me._RegionID
                objEnt.PenalID = Me._PenalID
                objEnt.TipoBusquedaID = cbbTipoVerificacion.SelectedIndex
                objEnt.ComparacionID = Me._TipoComparacion
                objEnt.FotoInterno = Me._ImagenSis
                objEnt.InternoSisMetadata = Me._ListaInternoSisCabecera
                objEnt.InternoSisData = Me._ListaInternoSisData

                If Me.TipoVeriResultado = Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado Then
                    objEnt.FotoReniec = -1
                    objEnt.ReniecMetadata = ""
                    Me._ReniecData = ""
                    objEnt.ReniecData = ""
                Else
                    objEnt.FotoReniec = Me.ImagenReniec

                    CabeceraReniec = (Me.txtDni.Name & "|" & Me.txtDigitoVeri.Name & "|" & Me.txtPrimerApellido.Name & "|" & _
                    Me.txtSegundoApellido.Name & "|" & Me.txtApellidoCasada.Name & "|" & txtPrenombres.Name & "|" & txtSexo.Name & "|" & _
                    txtFechaNac.Name & "|" & Me.txtUbigeoNacimiento.Name & "|" & Me.txtEstadoCivil.Name & "|" & txtUbigeo.Name & "|" & Me.txtUbigeoDireccion.Name & "|" & _
                    txtPadre.Name & "|" & txtMadre.Name & "|" & txtGradoInstruccion.Name & "|" & Me.txtTalla.Name & "|" & Me.txtRestriccion.Name & "|" & Me.lblFechaInscripcion.Name & "|" & Me.lblFechaemision.Name)
                    objEnt.ReniecMetadata = CabeceraReniec

                    DatosReniec = Me._NumeroDni & "|" & Me.DigitoVerificacion & "|" & Me.ApellidoPaterno & "|" & _
                        Me.ApellidoMaterno & "|" & Me.ApellidoCasada & "|" & Me.Nombres & "|" & Me.SexoNom & "|" & Me.FechaNacimiento _
                        & "|" & Me.NacimientoUbigeo & "|" & Me.EstadoCivilNom & "|" & Me.Ubigeo & "|" & Me.Direccion & "|" & _
                        Me.Padre & "|" & Me.Madre & "|" & Me.GradoInstruccionNom & "|" & Me.Talla & "|" & Me.Restriccion & "|" & Me.FechaInscripcion & "|" & Me.FechaEmision
                    Me._ReniecData = DatosReniec
                    objEnt.ReniecData = DatosReniec
                End If

                objEnt.NombreAsociadoVal_ID = Me._NombreAsociadoValID
                objEnt.Observaciones = Me.Observaciones
                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    objEnt.IngresoID = -1
                    IDInternoReniec = objBssInt.Grabar2_LM(objEnt)
                Else
                    IDInternoReniec = objBssInt.Grabar2(objEnt)
                End If


                If IDInternoReniec < 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha podido Registrar en la tabla")
                    Return IDInternoReniec

                Else
                    Dim ListaNomAsoc As String = Me._NombresAsociados
                    If ListaNomAsoc.Length > 0 Then
                        Dim bssNomAsoc As New Bussines.Registro.InternoReniecNomAsoc
                        Dim intNomAso As New Entity.Registro.InternoReniecNomAsoc
                        Dim NomAsoFila() As String = ListaNomAsoc.Split("|")
                        For i As Integer = 0 To NomAsoFila.Length - 1
                            Dim Campos() As String = NomAsoFila(i).Split(",")
                            With intNomAso
                                .CodigoNomAsoc = Campos(0)
                                .InternoID = Me._InternoID
                                .IngresoID = Me._IngresoID
                                .IngresoInpeId = Me._IngresoInpeID
                                .InternoReniecID = IDInternoReniec
                                .ApellidoPaterno = Campos(1)
                                .ApellidoMaterno = Campos(2)
                                .Nombres = Campos(3)
                                .RegionID = Me._RegionID
                                .PenalID = Me._PenalID
                            End With
                            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                                intNomAso.IngresoID = -1
                                bssNomAsoc.Grabar_LM(intNomAso)
                            Else
                                bssNomAsoc.Grabar(intNomAso)
                            End If

                        Next
                    End If
                End If
            Else
                objEnt.Codigo = Me.IDInternoReniec
                objEnt.FotoReniec = IIf(Me.TipoVeriResultado = Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado, -1, Me.ImagenReniec)
                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    IDInternoReniec = objBssInt.Grabar2_LM(objEnt)
                Else
                    IDInternoReniec = objBssInt.Grabar(objEnt)
                End If
            End If
            Return IDInternoReniec
        End Function

        Private Function GrabarArchivoDigital() As Boolean
            Dim blnValueAux As Boolean = False

            If Me.TipoVeriResultado <> Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado Then

                bssGloArch = New Bussines.Globall.ArchivoDigital

                If Me.IDInternoReniec > 0 Then
                    If Me.FotoReniecLinea Is Nothing Then
                        blnValueAux = False
                    Else
                        If Me.ImagenReniec < 1 Then  '/*me.ImagenInterno es el codigo principal de la tabla archivo digital*/
                            ListarEntity_ArchivoDigital()
                            Me.ImagenReniec = bssGloArch.Grabar_v2(objEntArchivoDig, "")

                            GrabarReniec()
                            blnValueAux = True

                        End If
                    End If
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "La foto del perfil, no se ha podido grabar en la tabla")
                    blnValueAux = False
                End If
            End If
            Return blnValueAux
        End Function

#End Region

#Region "Otros"
        Private Sub ValoresDefault()
            Me.cbbTipoVerificacion.SelectedIndex = 0
            Me.Refresh()
        End Sub

        Private Sub MemoriaCachet()

            Dim entPersInt As New Entity.Registro.InternoPersona
            If objPersMemoCol.Count = 0 Then
                With objPersona
                    entPersInt.NumeroDocumento = .NumeroDNI
                    entPersInt.DigitoVerificacion = .DigitoVerificacion
                    entPersInt.ApellidoPaterno = .ApellidoPaterno
                    entPersInt.ApellidoMaterno = .ApellidoMaterno
                    entPersInt.ApellidoCasada = .ApellidoCasada
                    entPersInt.Nombres = .Nombres
                    entPersInt.UbigeoDepProvDist = Me.Ubigeo
                    entPersInt.EstadoCivilNombre = .EstadoCivil
                    entPersInt.GradoInstruccionNombre = Me.GradoInstruccionNom
                    entPersInt.Estatura = .Estatura
                    entPersInt.SexoID = .Sexo
                    entPersInt.NacimientoDepProvDist = Me.NacimientoUbigeo
                    entPersInt.FechaNacimiento2 = .FechaNacimiento
                    entPersInt.NombrePadre = .NombrePadre
                    entPersInt.NombreMadre = .NombreMadre
                    entPersInt.DomicilioDireccion = Me.Direccion
                    entPersInt.Restriccion = .Restriccion
                    entPersInt.FechaInscripcion = .FechaInscripcion
                    entPersInt.FechaExpedicion = .FechaExpedicion

                End With
                objPersMemoCol.Add(entPersInt)
            Else
                Dim indice As Integer = -1
                Dim intValor As Integer = 0
                For Each entIntPers As Entity.Registro.InternoPersona In objPersMemoCol
                    If entIntPers.NumeroDocumento = Me._NumeroDniAux Then
                        indice = indice + 1
                        intValor = intValor + 1
                        Exit For
                    End If
                Next
                If intValor = 0 Then
                    With objPersona
                        entPersInt.NumeroDocumento = .NumeroDNI
                        entPersInt.DigitoVerificacion = .DigitoVerificacion
                        entPersInt.ApellidoPaterno = .ApellidoPaterno
                        entPersInt.ApellidoMaterno = .ApellidoMaterno
                        entPersInt.ApellidoCasada = .ApellidoCasada
                        entPersInt.Nombres = .Nombres
                        entPersInt.UbigeoDepProvDist = Me.Ubigeo
                        entPersInt.EstadoCivilNombre = .EstadoCivil
                        entPersInt.GradoInstruccionNombre = Me.GradoInstruccionNom
                        entPersInt.Estatura = .Estatura
                        entPersInt.SexoID = .Sexo
                        entPersInt.NacimientoDepProvDist = Me.NacimientoUbigeo
                        entPersInt.FechaNacimiento2 = .FechaNacimiento
                        entPersInt.NombrePadre = .NombrePadre
                        entPersInt.NombreMadre = .NombreMadre
                        entPersInt.DomicilioDireccion = Me.Direccion
                        entPersInt.Restriccion = .Restriccion
                        entPersInt.FechaInscripcion = .FechaInscripcion
                        entPersInt.FechaExpedicion = .FechaExpedicion
                    End With
                    objPersMemoCol.Add(entPersInt)

                End If


            End If
        End Sub

        Public Sub RegresarFormulario()
            Me.Memoria = +1
            MemoriaCachet()
        End Sub

#End Region

        Private Sub picFoto_DoubleClick(sender As Object, e As System.EventArgs) Handles picFoto.DoubleClick
            Form_FotoAutoSize()
        End Sub

        Private Sub cbbTipoVerificacion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbTipoVerificacion.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        End Sub

    End Class
End Namespace

