Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Bussines.Globall
Imports Entity

Namespace Visita.Visitante
    Public Class frmMantPopup
        Private objBss As Bussines.Visita.Visitante = Nothing
        Private objEnt As Entity.Visita.Visitante = Nothing
        Private frmLoad As Load.frmLoad02 = Nothing

        Private objBssVis As Bussines.Visita.Visitante = Nothing
        Private objVisitanteReniec As Bussines.Visita.VisitanteReniec.objDTOPersona = Nothing
        Private objVisitanteMigraciones As APPWebService.Result.ConsultarExtranjero = Nothing

        '************************************************/
        Private blnValoresxDefault As Boolean = False
#Region "Propiedades_Parametricas"
        Public Property _PenalID() As Integer = -1
        Public Property _RegionID() As Integer = -1
#End Region
#Region "Propiedades"
        Public Property _Codigo() As Integer = -1
        Private _strMensaje As String = ""
        Private _intMostrarTipoMensaje As Integer = -1
        Private Property VisTipoDocumento() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property VisNumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property VisApellidoPaterno() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property VisApellidoMaterno() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property VisNombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private ReadOnly Property VisApelidosyNombres() As String
            Get
                Dim strValue As String = ""
                strValue = Me.VisApellidoPaterno & " " & Me.VisApellidoMaterno & ", " & Me.VisNombres

                Return strValue
            End Get
        End Property
        Private Property Nacionalidad() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Return Me.cbbSexo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbSexo.SelectedValue = value
            End Set
        End Property
        Private Property VisitanteNacimiento() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property
        Private Property ValidacionReniecMigraciones() As Integer 'e.cu.cco.
        Private Property VisitanteExisteEnSistemas() As Boolean 'e.cu.cco.
#End Region
#Region "Propiedades_Otros"
        Public ReadOnly Property _ApellidosyNombres() As String
            Get
                Return Me.VisApelidosyNombres
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboDocumentoTipo()
            '/*tipo documento*/
            With Me.cbbTipoDoc
                Dim lista As New List(Of Integer)
                lista.Add(Type.Enumeracion.enmTipoDocumento.LM) 'L.M. (Libreta Militar)
                lista.Add(Type.Enumeracion.enmTipoDocumento.PN) 'P.N. (Partida de Nacimiento)
                lista.Add(8) 'P.N. (CARNE IDENTIDAD PERSONAL)
                lista.Add(11) 'INDOCUMENTADO
                lista.Add(Type.Enumeracion.enmTipoDocumento.CC) 'CREDENCIAL CONSULAR
                lista.Add(14) 'CARNET FISCALIA
                lista.Add(15) 'CEDULA DE IDENTIDAD

                .ListaIdsParaExcluir = lista

                .Parametro1 = 1
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboOtros()

            Me.cbbNacionalidad.LoadUsc()
            Me.cbbSexo.LoadUsc()

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = False

            'numero documento
            If Me.VisNumeroDocumento.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese el numero de documento del visitante")
                Me.txtNumDoc.Focus()
                Return blnValue
            End If

            'numero documento
            Select Case Me.VisTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI

                    If Me.VisNumeroDocumento.Length <> 8 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el numero de documento valido del visitante")
                        Me.txtNumDoc.Focus()
                        Return blnValue
                    End If

                Case Type.Enumeracion.enmTipoDocumento.PAS, Type.Enumeracion.enmTipoDocumento.CE

                    If Me.VisNumeroDocumento.Length < 5 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el numero de documento del visitante")
                        Me.txtNumDoc.Focus()
                        Return blnValue
                    End If

            End Select

            'apellido paterno
            If Me.VisApellidoPaterno = "" Or Me.VisApellidoPaterno.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Ingrese el apellido paterno del visitante")
                Me.txtApePat.Focus()
                Return blnValue
            End If

            'nombres
            If Me.VisNombres = "" Or Me.VisNombres.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
               "Ingrese los nombres del visitante")
                Me.txtNom.Focus()
                Return blnValue
            End If

            'Fecha nacimiento            
            If Me.VisitanteNacimiento <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese la fecha de Nacimiento")
                Me.dtpFechaNac.Focus()
                Return blnValue
            End If

            'Si ya esta validado por reniec sale           
            If Me.ValidacionReniecMigraciones = 1 Then
                If _Codigo > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Return blnValue
                End If
            End If

            'Si ya esta validado por reniec sale           
            If chkMenorEdad.Checked = True Then
                Dim intEdadMenor As Short = Legolas.Components.FechaHora.FechaCalcularAnio(
                                Me.VisitanteNacimiento,
                                Legolas.Configuration.Aplication.FechayHora.FechaLong, True)
                If intEdadMenor > 17 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El visitante registrado no es menor de edad")
                    Return blnValue
                End If

            End If


            blnValue = True

            Return blnValue

        End Function
        Private Function AGrabar() As Boolean

            Dim value As Boolean = False
            Dim intIDUsuario As Integer = Legolas.Configuration.Usuario.Codigo

            If Validar() = False Then
                Return value
            End If

            objBss = New Bussines.Visita.Visitante
            Dim objEnt As New Entity.Visita.Visitante

            Me.VisApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.VisApellidoPaterno)
            Me.VisApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.VisApellidoMaterno)
            Me.VisNombres = Legolas.Components.Cadena.LimpiarEspacios(Me.VisNombres)

            With objEnt
                .Codigo = _Codigo '-1
                .ApellidoPaterno = Me.VisApellidoPaterno
                .ApellidoMaterno = Me.VisApellidoMaterno
                .Nombres = Me.VisNombres
                .SexoID = Me.Sexo
                .TipoDocumentoID = Me.VisTipoDocumento
                .NumeroDocumento = Me.VisNumeroDocumento
                .FechaNacimiento = Me.VisitanteNacimiento
                .NacionalidadID = Me.Nacionalidad
                .FotoID = -1
                .FotoName = ""
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID

                ' validacion
                If Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado = 1 Or Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado = 11 Then
                    .VisitanteValidoReniec = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado
                    .IDUsuarioValidacionReniec = intIDUsuario 'intIDUsuarioValidacion
                    .FechaValidacionReniec = 0 'lngFechaValidacion
                End If
            End With

            If VisitanteExisteEnSistemas = True Then
                If ValidacionReniecMigraciones = 1 Then
                    Me._Codigo = objBss.GrabarAutorizacion(objEnt)
                End If

            Else
                Me._Codigo = objBss.Grabar(objEnt)
                'Actualizar valiacaion RENIEC
                If ValidacionReniecMigraciones = 1 Then
                    objEnt.Codigo = Me._Codigo
                    Me._Codigo = objBss.GrabarAutorizacion(objEnt)
                End If

            End If

            If Me._Codigo > 0 Then
                value = True
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            End If

            Return value

        End Function
#End Region
#Region "Otros"
        Private Sub ValidarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.VisTipoDocumento
                Case 1 '
                    Me.txtNumDoc.MaxLength = 8
                Case 10 '
                    Me.txtNumDoc.MaxLength = 8
                Case Else
                    Me.txtNumDoc.MaxLength = 20
            End Select

            Select Case Me.VisTipoDocumento
                Case 3, 4, 6, 13
                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
                Case Else
                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
            End Select

            Me.txtNumDoc.Text = ""
            Me.txtNumDoc.Focus()

        End Sub

        Private Sub ValoresxDefault()

            blnValoresxDefault = False
            ComboDocumentoTipo()
            ComboOtros()

            Me.VisTipoDocumento = 10 'dni
            Me.Nacionalidad = 141 'peru   
            blnValoresxDefault = True
            VisitanteEstadoEnabled(False)
        End Sub
        Private Sub VisitanteEstadoEnabled(Optional ByVal Estado As Boolean = False)

            Me.txtApePat.Enabled = Estado
            Me.txtApeMat.Enabled = Estado
            Me.txtNom.Enabled = Estado
            Me.cbbSexo.Enabled = Estado
            Me.cbbNacionalidad.Enabled = Estado
            Me.dtpFechaNac.Enabled = Estado

        End Sub

        Private Sub ALimpiarVisitante(Optional ByVal NumeroDocumento As Boolean = False)

            lblEtiqueta.Visible = True
            VisApellidoPaterno = ""
            VisApellidoMaterno = ""
            VisNombres = ""
            VisitanteNacimiento = 0
            Nacionalidad = 141
            Sexo = -1

        End Sub

#End Region
#Region "Busqueda"
        Private Function ListarVisitante(intIDTipoDocumento As Short, ByVal strNumeroDoc As String) As Boolean

            Dim value As Boolean = False
            VisitanteExisteEnSistemas = 0
            objBssVis = New Bussines.Visita.Visitante
            Dim objEntCol As New Entity.Visita.VisitanteCol

            objEntCol = objBssVis.ListarxNumeroDocumento(intIDTipoDocumento, strNumeroDoc, Me._RegionID, Me._PenalID)

            If objEntCol.Count > 0 Then

                For Each ent As Entity.Visita.Visitante In objEntCol
                    Me.ValidacionReniecMigraciones = ent.VisitanteValidoReniec
                    ListarVisitanteData(ent.Codigo)
                    value = True
                    Exit For
                Next
            End If

            Return value

        End Function

        Private Sub ListarVisitanteData(ByVal VisitanteID As Integer)

            If VisitanteID < 1 Then
                Exit Sub
            End If

            objBssVis = New Bussines.Visita.Visitante
            Dim objEnt As Entity.Visita.Visitante

            objEnt = objBssVis.Listar(VisitanteID)

            With objEnt
                Me._Codigo = .Codigo
                Me.VisApellidoPaterno = .ApellidoPaterno.Trim
                Me.VisApellidoMaterno = .ApellidoMaterno.Trim
                Me.VisNombres = .Nombres.Trim
                Me.Nacionalidad = .NacionalidadID
                If Len(.FechaNacimientoString) > 0 Then
                    Me.VisitanteNacimiento = Legolas.Components.FechaHora.FechaLong(.FechaNacimientoString.Trim)
                Else
                    Me.VisitanteNacimiento = 0
                End If

                Me.Sexo = .SexoID
            End With

        End Sub
#End Region
#Region "Reniec"
        Private Sub Buscar_Datos()
            VisitanteEstadoEnabled(False)

            'validar tipo documento y numero
            Select Case Me.VisTipoDocumento
                Case Is < 1
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Seleccione el tipo de documento")
                    Me.txtNumDoc.Focus()
                    Exit Sub
                Case 10 'dni
                    If Me.VisNumeroDocumento.Length <> 8 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingrese el numero de documento, el numero debe contener 8 digitos")
                        Me.txtNumDoc.Focus()
                        Exit Sub
                    End If
                Case 3, 16, 17 'CE, PTP,CPP
                    If Me.VisNumeroDocumento.Length <> 9 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el numero de documento, el numero debe contener 9 digitos")
                        Me.txtNumDoc.Focus()
                        Exit Sub
                    End If
            End Select

            ALimpiarVisitante()
            ValidacionReniecMigraciones = 0
            VisitanteExisteEnSistemas = ListarVisitante(Me.VisTipoDocumento, Me.VisNumeroDocumento)

            If VisitanteExisteEnSistemas = False Or ValidacionReniecMigraciones < 1 Then
                If VisitanteExisteEnSistemas = True Then
                    lblEtiqueta.Text = "Visitante SI existente"
                Else
                    lblEtiqueta.Text = "Visitante NO existente"
                End If

                If Me.VisTipoDocumento = 10 Then 'dni
                    If Me.chkMenorEdad.Checked = False Then
                        ListarVisitanteReniec()
                    Else
                        VisitanteEstadoEnabled(True)
                    End If

                ElseIf Me.VisTipoDocumento = Type.Enumeracion.enmTipoDocumento.PAS Or Me.VisTipoDocumento = Type.Enumeracion.enmTipoDocumento.CE Or Me.VisTipoDocumento = Type.Enumeracion.enmTipoDocumento.PTP Or Me.VisTipoDocumento = Type.Enumeracion.enmTipoDocumento.CPP Then
                    ListaVisitanteExtranjero()
                End If
            Else
                lblEtiqueta.Text = "Visitante existente y validado por RENIEC"
            End If

        End Sub

        Private Function ConsultarMigracionesHilo(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As APPWebService.Result.ConsultarExtranjero

            Dim value As New APPWebService.Result.ConsultarExtranjero

            If worker.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim objBssMigraciones As New APPWebService.MigracionesConsulta

                Try
                    value = objBssMigraciones.WS_ConsultarExtranjero(Legolas.Configuration.Data.ConexionIni, e.Argument(0), e.Argument(1))

                    Select Case value.ErrorCodigo
                        Case 0 'ok
                            value.HayServicio = True
                        Case -20 'el numero no existe
                            value.HayServicio = True
                        Case Else
                            value.HayServicio = False
                    End Select

                Catch ex As Exception
                    value.HayServicio = False
                    value.ErrorCodigo = -1
                    value.ErrorMensaje = ex.Message
                End Try

            End If

            Return value

        End Function

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
            End If

        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = ConsultarReniecHilo(worker, e)
            End If

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()

                objVisitanteReniec = New Bussines.Visita.VisitanteReniec.objDTOPersona
                objVisitanteReniec = e.Result

            End If

        End Sub
        Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker2.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = ConsultarMigracionesHilo(worker, e)
            End If

        End Sub

        Private Sub BackgroundWorker2_Disposed(sender As Object, e As EventArgs) Handles BackgroundWorker2.Disposed

            If Me.BackgroundWorker2.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker2 = Nothing
            End If

        End Sub

        Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted

            'frmLoad.Dispose()            
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()

                objVisitanteMigraciones = New APPWebService.Result.ConsultarExtranjero
                objVisitanteMigraciones = e.Result
            End If

        End Sub
        Private Function ConsultarReniecHilo(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Bussines.Visita.VisitanteReniec.objDTOPersona

            Dim value As New Bussines.Visita.VisitanteReniec.objDTOPersona

            If worker.CancellationPending = True Then

                e.Cancel = True

            Else

                Dim objBssMQReniec As New Bussines.Globall.Reniec
                Dim objPersonaCabecera As New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
                Dim intErrorCodigo As String = -1
                Dim strErrorMensaje As String = ""


                Try
                    objPersonaCabecera = objBssMQReniec.WS_ReniecxDNI_Resultado(e.Argument, intErrorCodigo, strErrorMensaje)

                    value.objPersona = objPersonaCabecera.Resultado
                    value.ErrorCodigo = intErrorCodigo
                    value.ErrorMensaje = strErrorMensaje

                    If intErrorCodigo = 0 Then
                        value.HayServicioReniec = True
                    End If

                Catch ex As Exception
                    value.HayServicioReniec = False
                End Try

            End If

            Return value

        End Function
        Private Async Sub ListarVisitanteReniec()
            Dim value As Boolean = False

            'Dim objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento
            Dim intErrorReniec As Integer = -1
            Dim strMensajeReniec As String = ""
            Dim blnHayReniec As Boolean = True
            Dim blnCancelarVerificacion As Boolean = False
            Dim objPersona As New List(Of ResultReniec)

            'objPersona = ConsultarReniec(Me.VisNumeroDocumento, blnHayReniec, blnCancelarVerificacion, intErrorReniec, strMensajeReniec)
            objPersona = Await ConsultarReniecApiAsync(Me.VisNumeroDocumento, blnHayReniec, blnCancelarVerificacion, intErrorReniec, strMensajeReniec)


            Dim strMensaje As String = ""
            Dim intMostrarTipoMensaje As Short = 1


            If blnCancelarVerificacion = True Then
                strMensaje = "Se canceló el proceso de verificacion con Reniec"
            Else
                If objPersona.Item(0).codigoError = "" Then
                    intErrorReniec = 0
                Else
                    intErrorReniec = objPersona.Item(0).codigoError
                    strMensajeReniec = objPersona.Item(0).mensajeError
                    strMensaje = objPersona.Item(0).mensajeError
                    _strMensaje = objPersona.Item(0).mensajeError
                End If
                If blnHayReniec = True Then


                    If intErrorReniec <> 0 Then ' si presenta algun tipo de error en el servicio de la ws 

                        strMensaje = "La verificacion con al RENIEC, ha encontrado el siguiente problema;" & Chr(13) _
                                & "Codigo Error: " & intErrorReniec & "-" & strMensajeReniec
                        intMostrarTipoMensaje = -1
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        ALimpiarVisitante()
                    Else
                        If Not objPersona Is Nothing Then
                            'If Me._Codigo < 1 Then 'cuando se extre los datos de un nuevo visitante
                            Dim lngFecNac As Long = 0
                            For Each objReniec As ResultReniec In objPersona
                                With objReniec

                                    VisApellidoPaterno = .apellidoPaterno.Trim
                                    VisApellidoMaterno = .apellidoMaterno.Trim
                                    VisNombres = .nombres.Trim
                                    VisitanteNacimiento = Legolas.Components.FechaHora.FechaLong(.fechaNacimiento.Trim)
                                    Sexo = .sexo
                                    ValidacionReniecMigraciones = 1
                                    lblEtiqueta.Text = "Visitante validado por RENIEC"
                                End With
                            Next
                        Else
                            lblEtiqueta.Text = "Visitante no existe en RENIEC"
                        End If
                    End If

                Else

                    intMostrarTipoMensaje = -1
                    value = True

                End If

            End If

        End Sub
        Private Async Function ConsultarReniecApiAsync(strNumeroDNI As String, blnHayReniec As Boolean, blnCancelarVerificacion As Boolean, intCodigoErrorReniec As Integer, strMensajeReniec As String) As Task(Of List(Of ResultReniec))
            Dim blnValor As Boolean = False
            Dim bss As New Bussines.ReniecConsulta
            Dim ListaRENIEC As New List(Of ResultReniec)()

            ListaRENIEC = Await bss.ConsultarReniec(1, strNumeroDNI, "", "", "", Me.Name)

            strMensajeReniec = ListaRENIEC.Item(0).mensajeError
            Dim abc As String = ListaRENIEC.Item(0).codigoError
            Dim ab1 As String = ListaRENIEC.Item(0).restriccion
            Dim ab2 As String = ListaRENIEC.Item(0).numeroTotalCoincidencias
            'If ListaRENIEC.Item(0).codigoError = "" Then intCodigoErrorReniec = 0
            Return ListaRENIEC
        End Function

        Private Function ConsultarReniec(strNumeroDNI As String, ByRef blnHayReniec As Boolean,
                                         ByRef blnCancelarVerificacion As Boolean, ByRef intCodigoErrorReniec As Integer, ByRef strMensajeReniec As String) As APPWebService.ws_reniec_sede.NumeroDocumento

            Dim value As New APPWebService.ws_reniec_sede.NumeroDocumento
            Me.SuspendLayout()

            If Me.BackgroundWorker1.IsBusy = True Then
                Return value
            End If

            Me.BackgroundWorker1.RunWorkerAsync(strNumeroDNI)

            blnCancelarVerificacion = False

            frmLoad = New Load.frmLoad02
            frmLoad._TipoImagen = APPControls.Load.frmLoad02.enmTipoImagen.Reniec

            If frmLoad.ShowDialog() = DialogResult.OK Then
                Me.BackgroundWorker1.CancelAsync()
                'Me.BackgroundWorker1.Dispose()
                blnCancelarVerificacion = True
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            If blnCancelarVerificacion = False Then
                value = objVisitanteReniec.objPersona
                blnHayReniec = objVisitanteReniec.HayServicioReniec
                intCodigoErrorReniec = objVisitanteReniec.ErrorCodigo
                strMensajeReniec = objVisitanteReniec.ErrorMensaje
            End If

            Return value

        End Function
        Private Function ConsultarMigraciones(intTipoDocumento As Short, strNumeroDoc As String, ByRef blnHayServicio As Boolean,
                                              ByRef blnCancelarVerificacion As Boolean) As APPWebService.Result.ConsultarExtranjero

            Dim value As New APPWebService.Result.ConsultarExtranjero
            Me.SuspendLayout()

            If Me.BackgroundWorker2.IsBusy = True Then
                Return value
            End If

            Dim objArray As New ArrayList
            objArray.Add(intTipoDocumento)
            objArray.Add(strNumeroDoc)

            Me.BackgroundWorker2.RunWorkerAsync(objArray)

            blnCancelarVerificacion = False

            frmLoad = New Load.frmLoad02
            frmLoad._TipoImagen = APPControls.Load.frmLoad02.enmTipoImagen.Migraciones

            'If frmLoad.ShowDialog() = DialogResult.OK Then
            If frmLoad.ShowDialog() = DialogResult.OK Then
                Me.BackgroundWorker2.CancelAsync()
                blnCancelarVerificacion = True
            End If

            Me.ResumeLayout(True)
            frmLoad.Refresh()

            If blnCancelarVerificacion = False Then
                value = objVisitanteMigraciones
                blnHayServicio = objVisitanteMigraciones.HayServicio
            End If

            Return value

        End Function
        Private Sub ListaVisitanteExtranjero()

            Dim objVisitanteServicio As New APPWebService.Result.ConsultarExtranjero
            Dim intErrorServicio As Integer = -1
            Dim strMensajeServicio As String = ""
            Dim blnHayServicio As Boolean = True
            Dim blnCancelarVerificacion As Boolean = False

            objVisitanteServicio = ConsultarMigraciones(Me.VisTipoDocumento, Me.VisNumeroDocumento, blnHayServicio, blnCancelarVerificacion)

            Dim strMensaje As String = ""
            Dim intMostrarTipoMensaje As Short = 1

            intErrorServicio = objVisitanteServicio.ErrorCodigo
            strMensajeServicio = objVisitanteServicio.ErrorMensaje

            If intErrorServicio <> 0 Then ' si presenta algun tipo de error en el servicio de la ws 

                strMensaje = "La verificacion con el Servicio de Migraciones, ha encontrado el siguiente problema;" & Chr(13) _
                & "Codigo Error: " & intErrorServicio & "-" & strMensajeServicio
                intMostrarTipoMensaje = -1
                Legolas.Configuration.Aplication.MessageBox.MensajeError(strMensaje)

            Else
                If Not objVisitanteServicio Is Nothing Then
                    'If Me._Codigo < 1 Then 'cuando se extre los datos de un nuevo visitante
                    Dim lngFecNac As Long = 0
                    With objVisitanteServicio
                        VisApellidoPaterno = .PrimerApellido.Trim
                        VisApellidoMaterno = .SegundoApellido.Trim
                        VisNombres = .Nombres.Trim
                        VisitanteNacimiento = .FechaNacimiento
                        Nacionalidad = .IDNacionalidad
                        Sexo = .IDSexo
                        ValidacionReniecMigraciones = 1
                        lblEtiqueta.Text = "Visitante validado por MIGRACIONES"
                    End With
                    ' End If
                Else
                    lblEtiqueta.Text = "Visitante no existe en MIGRACIONES"
                End If
            End If
        End Sub
#End Region
        Private Sub frmMantPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

            'If ValidacionReniecMigraciones = 1 Then
            If AGrabar() = True Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            'Else
            '    Me.DialogResult = Windows.Forms.DialogResult.OK
            'End If

        End Sub


        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged

            If Me.VisTipoDocumento > 0 And blnValoresxDefault = True Then
                ValidarNumeroDocumento()
            End If

        End Sub

        Private Sub txtNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDoc.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                If chkMenorEdad.Checked = False Then
                    Buscar_Datos()
                End If

            End If
        End Sub

        Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
            Buscar_Datos()
        End Sub

        Private Sub chkMenorEdad_Click(sender As Object, e As EventArgs) Handles chkMenorEdad.Click
            If chkMenorEdad.Checked = True Then
                ALimpiarVisitante()
                VisitanteEstadoEnabled(True)
                btnBuscar.Visible = False
            Else
                ALimpiarVisitante()
                VisitanteEstadoEnabled(False)
                btnBuscar.Visible = True
            End If
        End Sub

        Private Sub chkMenorEdad_CheckedChanged(sender As Object, e As EventArgs) Handles chkMenorEdad.CheckedChanged

        End Sub
    End Class
End Namespace