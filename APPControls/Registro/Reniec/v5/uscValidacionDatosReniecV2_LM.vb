Imports System.Configuration
Imports System.Security.Policy
Imports Type.Combo.ComboTipo
Namespace Registro.Reniec.v5
    Public Class uscValidacionDatosReniecV2_LM
        Private objBssInternoRnc As Bussines.Registro.InternoReniec = Nothing
        Private objEnt As Entity.Registro.InternoReniec = Nothing
#Region "Eventos"
        Public Event _Click_CargarUltimaInformacionInterno(Busca As Integer, Cod_ultimo As Integer)
        Public Event _SelectedIndexChanged_ValidacionID(Busca As Integer, Cod_ultimo As Integer, CodInterno As Integer)
        Public Event _DoubleClick_CargarDetalle(objEntRnc As Entity.Registro.InternoReniec)
#End Region
#Region "Propiedades Interno"
        Private Property intInternoID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
                ListarInternoCondicion()
            End Set
        End Property
        Private Property PrimerApellido() As String
            Get
                Return Me.txtPrimerApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value

            End Set
        End Property
        Private Property SegundoApellido() As String
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
        Private Property PreNombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private Property NumeroDni() As String
            Get
                Return Me.txtDni.Text
            End Get
            Set(ByVal value As String)
                Me.txtDni.Text = value
            End Set
        End Property
        Private Property DigitoVeri() As String
            Get
                Return Me.txtDigitoVeri.Text
            End Get
            Set(ByVal value As String)
                Me.txtDigitoVeri.Text = value
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
        Private Property UbigeoNacimiento() As String
            Get
                Return Me.txtUbigeoNacimiento.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoNacimiento.Text = value

            End Set
        End Property
        Public Property _Version() As Boolean = False
        Private Property Sexo() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
                Me.txtSexo.Text = Mid(Me.txtSexo.Text, 1, 3)
                If Len(Me.txtSexo.Text) = 0 Then
                    txtApellidoCasada.Visible = False
                    lblApellidoCasada.Visible = False
                Else
                    If Mid(txtSexo.Text, 1, 3) = "MAS" Then
                        txtApellidoCasada.Visible = False
                        lblApellidoCasada.Visible = False
                    Else
                        txtApellidoCasada.Visible = True
                        lblApellidoCasada.Visible = True
                    End If
                End If
            End Set
        End Property
        Private Property EstadoCivil() As String
            Get
                Return Me.txtEstadoCivil.Text
            End Get
            Set(ByVal value As String)
                Me.txtEstadoCivil.Text = value

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
        Private Property GradoInstruccion() As String
            Get
                Return Me.txtGradoInstruccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtGradoInstruccion.Text = value

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
        Private Property UbigeoDepProvDis() As String
            Get
                Return Me.txtUbigeo.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeo.Text = value
            End Set
        End Property
        Private Property UbigeoDireccion() As String
            Get
                Return Me.txtUbigeoDireccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtUbigeoDireccion.Text = value
            End Set
        End Property
        Private Property NombreAsociadoValID() As Integer = -1
        Private Property NombreAsociadoValNom() As String = ""
        Private Property FechaInscripcion() As String = ""

        Private Property FechaExpedicion() As String = ""
        '    Get
        '        Return lblFechaExpedicion.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.lblFechaExpedicion.Text = value
        '    End Set
        'End Property
        Private Property Restriccion() As String = ""
        '    Get
        '        Return lblRestriccion.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.lblRestriccion.Text = value
        '    End Set
        'End Property
#End Region
#Region "Propiedades_Clase"
        Public Property _Contador As Integer = -1
        Public Property _VarHistorico As Integer = 0
        Private Property RegionID As Integer = -1
        Private Property PenalID As Integer = -1
        Private Property BusquedaID As Integer = -1
        Private Property ComparacionID As Integer = -1
        Private Property ListaInternoData As String = ""
        Private Property ListaReniecdata As String = ""
        Private Property FechaValidacion As Date
        Private Property Observaciones As String = ""
        Private Property PthServidor As String = ""
        Private Property VariableColor As String = ""
        Private Property strLista As String = ""
#End Region
#Region "Propiedades Fotografia"
        Private Property PerfilActual As Integer
        Public Property _CopiaImagen As Integer = -1
        Public Property _CopiaNombreImagen As String = ""
        Private Sub ShowFotografia()
            Dim blnVerFoto As Boolean = False
            If _InternoID < 1 Then
                _Limpiar()
                Exit Sub
            Else
                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEntVal As New Entity.Registro.InternoReniec

                Dim intCodigo As Integer = objBssFoto.ValidarFotoReniec(_InternoID, Me._VarHistorico)

                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""
                Dim strPathServerImg As String = ""

                objBssFoto = New Bussines.Registro.InternoFoto

                objEntVal = objBssFoto.ListarFotoReniec(intCodigo, 1)
                If objEntVal.Codigo > 0 Then
                    With objEntVal
                        intImagen = .PFrenteRnc
                        intNombreImagen = .PFrenteName
                        strPathServerImg = .PthServidor
                    End With
                    _ShowFotoInterno2(intImagen, IIf(Me.BusquedaID = 3, 0, intNombreImagen), Me.PthServidor)
                Else
                    _Limpiar()
                End If
            End If
        End Sub
        Private Property PerfilFotografia() As Integer
            Get
                Dim value As Integer = -1

                ' ''If Me.rdbPI.Checked = True Then
                ' ''    value = 1
                ' ''End If

                ' ''If Me.rdbPF.Checked = True Then
                value = 2
                ' ''End If

                ' ''If Me.rdbPD.Checked = True Then
                ' ''    value = 3
                ' ''End If
                Return value
            End Get
            Set(ByVal value As Integer)
            End Set
        End Property
#End Region
#Region "Propiedades_Parametricas"
        Private Property TipoImagen() As Type.Enumeracion.ArchivoDigital.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        Public Property _SizeMode() As System.Windows.Forms.PictureBoxSizeMode
            Get
                Return Me.picFoto.SizeMode
            End Get
            Set(ByVal value As System.Windows.Forms.PictureBoxSizeMode)
                Me.picFoto.SizeMode = value
            End Set
        End Property
#End Region
#Region "Propiedades Otros"
        Public Property _CondicionBusqueda As Integer = -1
        Private Property Codigo_Historial() As Integer
            Get
                Try
                    Return Me.cbbHistorial.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbHistorial.SelectedValue = value
            End Set
        End Property
        Public Property _EnabledDobleClick() As Boolean = False
        Public Property _HasImagen() As Boolean = False
#End Region
#Region "Combo"
        Private blnHistorial As Boolean = False
        Private Sub ComboHistorialValidacion()
            blnHistorial = False
            Dim blnTodos As Boolean = False
            blnTodos = False
            objBssInternoRnc = New Bussines.Registro.InternoReniec
            With Me.cbbHistorial
                If Me._InternoID > 0 Then
                    .DataSource = objBssInternoRnc.ListarHistorial(Me._InternoID)
                    .ValueMember = "Codigo"
                    .DisplayMember = "Nombre"
                End If
            End With
            blnHistorial = True
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarInternoCondicion()
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            If Me._Contador < 1 Then
                If Me._VarHistorico = -1 Then
                    'Me.CodigoHistorial = -1
                    cbbHistorial.Visible = False 'Combo no vaxx
                    LimpiarCajasTexto()
                End If
            Else
                If Me._VarHistorico = -1 Then
                    'Me.CodigoHistorial = -1
                    cbbHistorial.Visible = False 'Combo no va
                    LimpiarCajasTexto()
                ElseIf Me._VarHistorico = 0 Then
                    'Me.CodigoHistorial = 0
                    cbbHistorial.Visible = True
                    ComboHistorialValidacion()
                End If
            End If
        End Sub
        Private Sub CargarDataValidacionID(Contador As Integer, CodigoValidacion As Integer, CodigoInterno As Integer)
            If Me._InternoID < 1 Then
                Exit Sub
            End If
            dgwGrillaDetalle.RowCount = 1
            If Me._Contador > 0 Then
                Dim EntInterno As New Entity.Registro.InternoReniec
                EntInterno.InternoID = CodigoInterno
                EntInterno.Codigo = CodigoValidacion
                objBssInternoRnc = New Bussines.Registro.InternoReniec
                objEnt = New Entity.Registro.InternoReniec
                If CodigoValidacion < 1 Then
                    objEnt = objBssInternoRnc.ListarUltimaValidacion(EntInterno)
                Else 'CodigoHistorial Mayor que cero
                    If Me._Version = True Then
                        objEnt = objBssInternoRnc.Listar2(EntInterno)
                    End If
                End If
                With objEnt
                    ' /*datos generales*/
                    Me._VarHistorico = .CodigoHistorial
                    Me.RegionID = .RegionID
                    Me.PenalID = .PenalID
                    Me.BusquedaID = .TipoBusquedaID
                    Me.ComparacionID = .ComparacionID
                    If .InternoSisData <> "" Then
                        Me.ListaInternoData = .InternoSisData
                        Me.ListaReniecdata = .ReniecData  ' Datos del Interno en Reniec
                        Dim strListaRnc As String = Me.ListaReniecdata
                        Dim strRegistroRnc() As String = strListaRnc.Split("|")
                        If BusquedaID = 3 Then
                            Me.NumeroDni = ""
                            Me.DigitoVeri = ""
                            Me.PrimerApellido = ""
                            Me.SegundoApellido = ""
                            Me.ApellidoCasada = ""
                            Me.PreNombres = ""
                            Me.Sexo = ""
                            Me.FechaNacimiento = ""
                            Me.UbigeoNacimiento = ""
                            Me.EstadoCivil = ""
                            Me.UbigeoDepProvDis = ""
                            Me.UbigeoDireccion = ""
                            Me.Padre = ""
                            Me.Madre = ""
                            Me.GradoInstruccion = ""
                            Me.Talla = ""
                            Me.Restriccion = ""
                            With dgwGrillaDetalle
                                .RowCount = 1
                                Dim strComparacion As String = ""
                                Select Case Me.ComparacionID
                                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.DNI
                                        strComparacion = "DNI"
                                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.DatosPrincipales
                                        strComparacion = "NOMBRE PRINCIPAL"
                                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.NombreAsociado
                                        strComparacion = "NOMBRE ASOCIADO"
                                    Case Type.Enumeracion.Reniec.EnmTipoValidacion.Ninguna
                                        strComparacion = "NINGUNO"
                                End Select
                                .Item(0, 0).Value = strComparacion
                                Me.FechaValidacion = Legolas.Components.FechaHora.FechaDate(objEnt.FechaValidacion, True)
                                .Item(1, 0).Value = objEnt.FechaHoraPM()
                                .Item(2, 0).Value = If(Me.ComparacionID > 0, Me.FechaInscripcion, "")
                                .Item(3, 0).Value = If(Me.ComparacionID > 0, Me.FechaExpedicion, "")
                                .Item(4, 0).Value = IIf(Me.BusquedaID = Type.Enumeracion.Reniec.EnmTipoResultado.Validado, "VALIDADO", IIf(Me.BusquedaID = Type.Enumeracion.Reniec.EnmTipoResultado.Observado, "OBSERVADO", "NO ENCONTRADO"))
                                .Item(5, 0).Value = If(Me.ComparacionID > 0, Me.Restriccion, "")
                                .Item(6, 0).Value = objEnt.Observaciones
                                If objEnt.NombreAsociadoVal_ID > 0 Then
                                    Me.NombreAsociadoValID = objEnt.NombreAsociadoVal_ID
                                    Me.NombreAsociadoValNom = objEnt.NombreAsociadoVal_Nom
                                    .Item(7, 0).Value = "(" & Me.NombreAsociadoValNom & ")"
                                End If
                            End With
                        Else
                            Me.NumeroDni = strRegistroRnc(0)
                            Me.DigitoVeri = strRegistroRnc(1)
                            Me.PrimerApellido = strRegistroRnc(2)
                            Me.SegundoApellido = strRegistroRnc(3)
                            Me.ApellidoCasada = strRegistroRnc(4)
                            Me.PreNombres = strRegistroRnc(5)
                            Me.Sexo = strRegistroRnc(6)
                            Me.FechaNacimiento = strRegistroRnc(7)
                            Me.UbigeoNacimiento = strRegistroRnc(8)
                            Me.EstadoCivil = strRegistroRnc(9)
                            Me.UbigeoDepProvDis = strRegistroRnc(10)
                            Me.UbigeoDireccion = strRegistroRnc(11)
                            Me.Padre = strRegistroRnc(12)
                            Me.Madre = strRegistroRnc(13)
                            Me.GradoInstruccion = strRegistroRnc(14)
                            Me.Talla = strRegistroRnc(15)
                            Me.Restriccion = IIf(strRegistroRnc(16) = "    ", "NINGUNA", Trim(strRegistroRnc(16)))
                            If strRegistroRnc.Length = 17 Then
                                Me.FechaInscripcion = ""
                                Me.FechaExpedicion = ""
                            Else
                                Me.FechaInscripcion = Trim(strRegistroRnc(17))
                                Me.FechaExpedicion = Trim(strRegistroRnc(18))
                            End If
                            With dgwGrillaDetalle

                                .Item(0, 0).Value = IIf(Me.ComparacionID = "1", "DNI", IIf(Me.ComparacionID = 2, "NOMBRE PRINCIPAL", "NOMBRE ASOCIADO"))
                                Me.FechaValidacion = Legolas.Components.FechaHora.FechaDate(objEnt.FechaValidacion, True)
                                .Item(1, 0).Value = objEnt.FechaHoraPM()
                                .Item(2, 0).Value = Me.FechaInscripcion
                                .Item(3, 0).Value = Me.FechaExpedicion
                                .Item(4, 0).Value = IIf(Me.BusquedaID = 1, "VALIDADO", IIf(Me.BusquedaID = "2", "OBSERVADO", "NO ENCONTRADO"))
                                .Item(5, 0).Value = Me.Restriccion
                                .Item(6, 0).Value = objEnt.Observaciones
                                If objEnt.NombreAsociadoVal_ID > 0 Then
                                    .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                                    Me.NombreAsociadoValID = objEnt.NombreAsociadoVal_ID
                                    Me.NombreAsociadoValNom = objEnt.NombreAsociadoVal_Nom
                                    .Item(7, 0).Value = "(" & Me.NombreAsociadoValNom & ")"
                                End If
                            End With
                        End If '////////Fin de  la cadena///////////
                    End If
                    Me.PthServidor = .PthServidor
                End With
                ColorComparar()
                ShowFotografia()
            End If
        End Sub
        Public Property Fecha() As Long = 0

#End Region
#Region "Function"

        Private Function ListarImagen2(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, RutaWeb As String) As System.Drawing.Image
            lblError.Text = ""
            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central
            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Catch ex As Exception
                intTipoLocal = -1
            End Try

            'validar la ruta
            If NameFile.Trim = "" Then
                Return objImagen
            End If

            If ArchivoDigitalID < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
                Me._HasImagen = False
            Else

                'si hay foto
                Dim objWS As New APPWebService.ws_foto.PopeLocal
                objWS.Timeout = -1
                objWS.Url = APPWebService.PathURL.WSPopeLocal

                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim strFotoNameExtension As String = NameFile

                Try 'APPWebService.ws_foto.TipoCarpeta.Reniec
                    r = objWS.ListarArchivoDigital(ArchivoDigitalID, Type.Enumeracion.ArchivoDigital.TipoImagen.Reniec)
                    objImagenByte = r.Resultado.ArchivoByte
                    objWS.Dispose()
                    objWS = Nothing
                Catch ex As Exception
                    objImagenByte = Nothing
                End Try

                If objImagenByte Is Nothing Then

                    Select Case intTipoLocal
                        Case 3, 2
                            objImagen = My.Resources.fotografia_por_transferir
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select

                    If intTipoLocal = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        ' MODIFICADO POR JONATAN 06/01/2025
                        ' EN CASO EL ARCHIVO NO SE ENCUENTRE LOCALMENTE, SE MOSTRARA UN MENSAJE, PERO IGUAL BUSCARA USANDO EL WS PARA OBTENER LA FOTO DESDE LIMA

                        Dim objBssFoto = New Bussines.Registro.InternoFoto

                        Dim objEnt As New Entity.Registro.InternoFoto

                        objEnt = objBssFoto.ObtenerCodigoFOTO_SEDE(ArchivoDigitalID)


                        Dim ArchivoDigitalIDLocal = ArchivoDigitalID
                        ArchivoDigitalID = objEnt.SedeRowId

                        lblError.Text = "No se encontró el archivo Localmente."

                        objWS = New APPWebService.ws_foto.PopeLocal
                        objWS.Url = APPWebService.PathURL.WSPopeSedeCentral

                        Try 'APPWebService.ws_foto.TipoCarpeta.Reniec

                            r = objWS.ListarArchivoDigital(ArchivoDigitalID, Type.Enumeracion.ArchivoDigital.TipoImagen.Reniec)


                            objImagenByte = r.Resultado.ArchivoByte
                            objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                            objImagen = Image.FromStream(objImagenStream)
                            objWS.Url = APPWebService.PathURL.WSPopeLocal
                            objWS.UploadImageJpg(objImagenByte, ObtenerNombre(ArchivoDigitalIDLocal), r.Resultado.Tipo)
                            objWS.Dispose()
                            objWS = Nothing
                        Catch ex As Exception
                            objImagenByte = Nothing
                        End Try
                    End If
                    Me._EnabledDobleClick = True

                Else
                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)

                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                    Me._EnabledDobleClick = True
                End If
                Me._HasImagen = True
            End If

            Return objImagen

        End Function
        ' MODIFICADO POR JONATAN 08/01/2025 -- OBTIENE LA RUTA DONDE SE ALMACENA EL ARCHIVO DE FOTO
        Private Function ObtenerNombre(ByVal ArchivoID As Int32) As String
            Try

                Dim Bss As New Bussines.Globall.ArchivoDigital

                Dim archivoDigital2 As Entity.Globall.ArchivoDigital = Bss.Listar_ArchivoDigital_v2(ArchivoID)

                Dim flag As Boolean = False
                Dim path As String

                If String.IsNullOrWhiteSpace(archivoDigital2.RutaServidor) Then
                    flag = True
                    path = archivoDigital2.NombreFisico
                Else
                    flag = False
                    path = IO.Path.Combine(archivoDigital2.RutaServidor, archivoDigital2.NombreFisico & "." & archivoDigital2.Extension)

                    If Not IO.File.Exists(path) Then
                        path = IO.Path.Combine(archivoDigital2.RutaServidor, archivoDigital2.NombreFisico)
                    End If
                End If
                Return path
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return ""
            End Try

        End Function
        'Private Sub grabarImagen(ByVal ArchivoID As Int32, ByVal archivo As Byte())
        '    Try
        '        Dim rutaDescargaFotos As String = ConfigurationManager.AppSettings("RUTA_DESCARGA_FOTOS")
        '        Dim RutaInicial = IO.Path.Combine(rutaDescargaFotos, "Foto\")
        '        Dim FotoInterno = RutaInicial & "Interno\"
        '        Dim FotoPersonal = RutaInicial & "Personal\"
        '        Dim FotoVisitante = RutaInicial & "Visitante\"
        '        Dim FotoReniec = RutaInicial & "Reniec\"
        '        Dim FotoReniecSybase = RutaInicial & "Reniec_Sybase\"
        '        Dim FotoTemporal = RutaInicial & "Temporal\"

        '        Dim Bss As New Bussines.Globall.ArchivoDigital

        '        Dim archivoDigital2 As Entity.Globall.ArchivoDigital = Bss.Listar_ArchivoDigital_v2(ArchivoID)

        '        Dim CarpetaInterna As String
        '        Select Case archivoDigital2.Tipo
        '            Case 1
        '                CarpetaInterna = FotoInterno
        '            Case 2
        '                CarpetaInterna = FotoPersonal
        '            Case 3
        '                CarpetaInterna = FotoVisitante
        '            Case 4
        '                CarpetaInterna = FotoReniec
        '            Case 5
        '                CarpetaInterna = FotoReniecSybase
        '            Case Else
        '                CarpetaInterna = ""
        '        End Select


        '        Dim flag As Boolean = False
        '        Dim path As String


        '        If String.IsNullOrWhiteSpace(archivoDigital2.RutaServidor) Then
        '            flag = True
        '            path = CarpetaInterna & archivoDigital2.NombreFisico
        '        Else
        '            flag = False
        '            path = IO.Path.Combine(CarpetaInterna, archivoDigital2.RutaServidor, archivoDigital2.NombreFisico & "." & archivoDigital2.Extension)

        '            If Not IO.File.Exists(path) Then
        '                path = IO.Path.Combine(CarpetaInterna, archivoDigital2.RutaServidor, archivoDigital2.NombreFisico)
        '            End If
        '        End If
        '        Try
        '            IO.File.WriteAllBytes(path, archivo)
        '        Catch ex As Exception

        '        End Try
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try


        'End Sub
        'Public Sub _ShowFotoInterno(ByVal ArchivoDigitalID As Integer, ByVal FileName As String)

        '    Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        '    Me.picFoto.Image = ListarImagen(ArchivoDigitalID, FileName)

        'End Sub
        Public Sub _ShowFotoInterno2(ByVal ArchivoDigitalID As Integer, ByVal FileName As String, Ruta As String)
            'Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Reniec
            Me.picFoto.Image = ListarImagen2(ArchivoDigitalID, FileName, Ruta)

        End Sub
        Public Sub _Limpiar()
            'Me._PanelAutorizacion = False
            Me.picFoto.Image = My.Resources.sin_foto
            Me._HasImagen = False
        End Sub
        Private Sub ColorComparar()
            Dim VarColor As Integer = 0
            Dim intColor As Integer = 1
            If Me.BusquedaID <> Type.Enumeracion.Reniec.EnmTipoResultado.No_Encontrado Then
                strLista = Me.ListaInternoData
                Dim strRegistro As String() = strLista.Split("|")
                If strRegistro.Length = 0 Then
                    Exit Sub
                End If
                intColor = ComparacionCadenas(strRegistro(0), Me.NumeroDni)
                If intColor = 0 Then
                    txtDni.BackColor = Color.LemonChiffon
                    txtDigitoVeri.BackColor = Color.LemonChiffon
                Else
                    txtDni.BackColor = Color.IndianRed
                    txtDigitoVeri.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(1), Me.PrimerApellido)
                If intColor = 0 Then
                    txtPrimerApellido.BackColor = Color.LemonChiffon
                Else
                    txtPrimerApellido.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(2), Me.SegundoApellido)
                If intColor = 0 Then
                    txtSegundoApellido.BackColor = Color.LemonChiffon
                Else
                    txtSegundoApellido.BackColor = Color.IndianRed
                    VarColor = VarColor + 1

                End If
                intColor = ComparacionCadenas(strRegistro(3), Me.PreNombres)
                If intColor = 0 Then
                    txtPrenombres.BackColor = Color.LemonChiffon
                Else
                    txtPrenombres.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(4), Me.Sexo)
                If intColor = 0 Then
                    txtSexo.BackColor = Color.LemonChiffon
                Else
                    txtSexo.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(5), Me.FechaNacimiento)
                If intColor = 0 Then
                    txtFechaNac.BackColor = Color.LemonChiffon
                Else
                    txtFechaNac.BackColor = Color.IndianRed
                    VarColor = VarColor + 1

                End If
                intColor = ComparacionCadenas(strRegistro(6), Me.UbigeoNacimiento)
                If intColor = 0 Then
                    txtUbigeoNacimiento.BackColor = Color.LemonChiffon
                Else
                    txtUbigeoNacimiento.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(7), Me.EstadoCivil)
                If intColor = 0 Then
                    txtEstadoCivil.BackColor = Color.LemonChiffon
                Else
                    txtEstadoCivil.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(8), Me.UbigeoDepProvDis)
                If intColor = 0 Then
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
                intColor = ComparacionCadenas(strRegistro(9), Me.UbigeoDireccion)
                If intColor = 0 Then
                    txtUbigeoDireccion.BackColor = Color.LemonChiffon
                Else
                    txtUbigeoDireccion.BackColor = Color.IndianRed
                    VarColor = VarColor + 1

                End If
                intColor = ComparacionCadenas(strRegistro(10), Me.Padre)
                If intColor = 0 Then
                    txtPadre.BackColor = Color.LemonChiffon
                Else
                    txtPadre.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(11), Me.Madre)
                If intColor = 0 Then
                    txtMadre.BackColor = Color.LemonChiffon
                Else
                    txtMadre.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
                intColor = ComparacionCadenas(strRegistro(13), Me.GradoInstruccion)
                If intColor = 0 Then
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
                intColor = ComparacionCadenas(strRegistro(14), Me.Talla)
                If intColor = 0 Then
                    txtTalla.BackColor = Color.LemonChiffon
                Else
                    txtTalla.BackColor = Color.IndianRed
                    VarColor = VarColor + 1
                End If
            Else ' si el valor es 3 --no encontrado
                txtDni.BackColor = Color.White
                txtDigitoVeri.BackColor = Color.White
                txtPrimerApellido.BackColor = Color.White
                txtSegundoApellido.BackColor = Color.White
                txtPrenombres.BackColor = Color.White
                txtSexo.BackColor = Color.White
                txtFechaNac.BackColor = Color.White
                txtUbigeoNacimiento.BackColor = Color.White
                txtEstadoCivil.BackColor = Color.White
                txtUbigeo.BackColor = Color.White
                txtUbigeoDireccion.BackColor = Color.White
                txtPadre.BackColor = Color.White
                txtMadre.BackColor = Color.White
                txtGradoInstruccion.BackColor = Color.White
                txtTalla.BackColor = Color.White
            End If
            Me.VariableColor = VarColor
        End Sub
        Private Function ComparacionCadenas(TestStr1 As String, TestStr2 As String) As Integer
            Dim TestComp As Integer
            ' valores         -1= no se parecen,0=iguales
            TestComp = StrComp(TestStr1, TestStr2, CompareMethod.Text)
            Return TestComp
        End Function
        Public Sub _Show_FotoAutoSize()
            Form_FotoAutoSize()
        End Sub
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
#Region "Accion"
        Private Sub picFoto_DoubleClick(sender As Object, e As System.EventArgs) Handles picFoto.DoubleClick
            Form_FotoAutoSize()
        End Sub
#End Region

#Region "ValoresxDefault"
        Private Sub LimpiarCajasTexto()
            Me.NumeroDni = ""
            Me.DigitoVeri = ""
            Me.PrimerApellido = ""
            Me.SegundoApellido = ""
            Me.ApellidoCasada = ""
            Me.PreNombres = ""
            Me.Sexo = ""
            Me.FechaNacimiento = ""
            Me.UbigeoNacimiento = ""
            Me.UbigeoDepProvDis = ""
            Me.UbigeoDireccion = ""
            Me.EstadoCivil = ""
            Me.Padre = ""
            Me.Madre = ""
            Me.GradoInstruccion = ""
            Me.Talla = ""
            Me.txtDni.BackColor = Color.White
            Me.txtDigitoVeri.BackColor = Color.White
            Me.txtPrimerApellido.BackColor = Color.White
            Me.txtSegundoApellido.BackColor = Color.White
            Me.txtApellidoCasada.BackColor = Color.White
            Me.txtPrenombres.BackColor = Color.White
            Me.txtSexo.BackColor = Color.White
            Me.txtFechaNac.BackColor = Color.White
            Me.txtUbigeoNacimiento.BackColor = Color.White
            Me.txtUbigeo.BackColor = Color.White
            Me.txtUbigeoDireccion.BackColor = Color.White
            Me.txtEstadoCivil.BackColor = Color.White
            Me.txtPadre.BackColor = Color.White
            Me.txtMadre.BackColor = Color.White
            Me.txtGradoInstruccion.BackColor = Color.White
            Me.txtTalla.BackColor = Color.White
            Me.picFoto.Image = Nothing
            objEnt = New Entity.Registro.InternoReniec
            If dgwGrillaDetalle.Rows.Count > 0 Then
                For i As Integer = 0 To dgwGrillaDetalle.Columns.Count - 1
                    dgwGrillaDetalle.Item(i, 0).Value = ""
                Next
            End If
        End Sub
#End Region

        Private Sub cbbHistorial_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbHistorial.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
        Private Sub cbbHistorial_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbHistorial.SelectedIndexChanged

            Dim CodigoInterno As Integer = Me._InternoID
            Dim Historial As Integer = Me.Codigo_Historial
            RaiseEvent _SelectedIndexChanged_ValidacionID(Me._Contador, IIf(Historial = -1, "0", Historial), CodigoInterno)
            CargarDataValidacionID(Me._Contador, Historial, CodigoInterno)

        End Sub

        Private Sub dgwGrillaDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaDetalle.CellContentClick

        End Sub

        Private Sub dgwGrillaDetalle_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrillaDetalle.CellDoubleClick
            If objEnt.InternoSisData <> "" And e.RowIndex <> -1 Then
                RaiseEvent _DoubleClick_CargarDetalle(Me.objEnt)
            End If
        End Sub

        Private Sub picFoto_Click(sender As System.Object, e As System.EventArgs) Handles picFoto.Click

        End Sub

        Private Sub dgwGrillaDetalle_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dgwGrillaDetalle.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub uscValidacionDatosReniecV2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            dgwGrillaDetalle.RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
            dgwGrillaDetalle.RowCount = 1
        End Sub
    End Class
End Namespace


