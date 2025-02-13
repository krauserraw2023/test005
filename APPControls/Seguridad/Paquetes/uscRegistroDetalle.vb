Imports System.IO

Namespace Seguridad.Paquetes
    Public Class uscRegistroDetalle
        Private objBssRegistro As Bussines.Seguridad.Paquetes.Registro = Nothing
        Private objEntRegistro As Entity.Seguridad.Paquetes.Registro = Nothing

        Private objBssInterno As Bussines.Visita.Interno = Nothing

        Private ParentescoIDArray As List(Of Integer) = Nothing
        Private ParentescoNombreArray As List(Of String) = Nothing
        Private Const MONTO_PERMITIDO As Decimal = 300.0
#Region "Eventos"
        Public Event _Click_Form_Internos(VisitanteID As Integer)
        Public Event _Click_Form_InternosPJ(intIDVisitante As Integer)
        Public Event _Click_Form_InternosHistoricos(VisitanteID As Integer)
        Public Event _Click_BuscarVisitante()
#End Region
#Region "Propiedades_Parametricas_Publicas"
        Public Property _idRegion() As Short = -1
        Public Property _regionNombre() As String = ""
        Public Property _idPenal() As Short = -1
        Public Property _penalNombre() As String = ""
#End Region
#Region "Propiedades_Privadas_Configuracion"
        Private Property SolicitarAutoRegOrdinario As Boolean = False
        '/*parametros configuracion del modulo de visita*/        
        Private Property HabilitarHuellaDigital As Boolean = False
        Private Property HabilitarCapHuellaValReniec As Boolean = False
        Private Property HabilitarInternoPJ As Boolean = False
        'reniec
        Private Property ValidarModuloVisConReniec As Boolean = False
        Private Property ValidarVisitanteConReniec As Boolean = False
        'migraciones
        Private Property ValidarVisitanteConMigraciones As Boolean = False
        Private Property ValidarModuloVisConMigraciones As Boolean = False
#End Region
#Region "Propiedades"
        Private Property FechaRegistro As Long
            Get
                Return Me.dtpFecha.ValueLong
            End Get
            Set(value As Long)
                Me.dtpFecha.ValueLong = value
            End Set
        End Property
        Private Property tipoPaquete As Short
            Get
                Dim value As Short = -1

                If Me.rdbInterno.Checked = True Then
                    value = 1
                End If

                If Me.rdbEconomato.Checked = True Then
                    value = 2
                End If

                If Me.rdbTalleres.Checked = True Then
                    value = 3
                End If
                Return value
            End Get
            Set(value As Short)

                Select Case value
                    Case 1
                        Me.rdbInterno.Checked = True

                    Case 2
                        Me.rdbEconomato.Checked = True

                    Case 3
                        Me.rdbTalleres.Checked = True

                    Case Else
                        Me.rdbInterno.Checked = False
                        Me.rdbEconomato.Checked = False
                        Me.rdbTalleres.Checked = False
                End Select
            End Set
        End Property
        Private Property idParentesco() As Integer = -1
        Private Property parentescoNombre() As String
            Get
                Return Me.txtParentesco.Text
            End Get
            Set(value As String)
                Me.txtParentesco.Text = value.ToUpper
            End Set
        End Property
        Private Property tipoPresentacion As Short
            Get
                Dim value As Short = -1

                If Me.rdbSobre.Checked = True Then
                    value = 1
                End If

                If Me.rdbBolsa.Checked = True Then
                    value = 2
                End If

                If Me.rdbSobreBolsa.Checked = True Then
                    value = 3
                End If

                If Me.rdbOtro.Checked = True Then
                    value = 4
                End If

                Return value
            End Get
            Set(value As Short)

                Select Case value
                    Case 1
                        Me.rdbSobre.Checked = True

                    Case 2
                        Me.rdbBolsa.Checked = True

                    Case 3
                        Me.rdbSobreBolsa.Checked = True

                    Case 4
                        Me.rdbOtro.Checked = True

                    Case Else
                        Me.rdbSobre.Checked = False
                        Me.rdbBolsa.Checked = False
                        Me.rdbSobreBolsa.Checked = False
                        Me.rdbOtro.Checked = False
                End Select

            End Set
        End Property
        Private Property tipoPresentacionNombre As String
            Get
                Return Me.txtPresentacionOtro.Text
            End Get
            Set(value As String)
                Me.txtPresentacionOtro.Text = value
            End Set
        End Property

        Private Property idTipoArticulo As Integer
            Get
                Return Me.cbbTipoArticulo.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTipoArticulo.SelectedValue = value
            End Set
        End Property
        Private Property Peso As Short
            Get
                Try
                    Return Decimal.Parse(Me.nupPeso.Text)
                Catch ex As Exception
                    Return 0
                End Try
            End Get
            Set(value As Short)
                Me.nupPeso.Text = value.ToString
            End Set
        End Property
        Private Property cantidad As Short
            Get
                Try
                    Return Integer.Parse(Me.nupElementos.Text)
                Catch ex As Exception
                    Return 0
                End Try
            End Get
            Set(value As Short)
                Me.nupElementos.Text = value.ToString
            End Set
        End Property
        Private Property entregaDinero As Boolean
            Get
                Return Me.rbDineroSi.Checked
            End Get
            Set(value As Boolean)

                If value = True Then
                    Me.rbDineroSi.Checked = True
                Else
                    Me.rbDineroNo.Checked = True
                End If
            End Set
        End Property
        Private Property montoDinero As Decimal
            Get
                Try
                    Return Decimal.Parse(Me.txtMonto.Text)
                Catch ex As Exception
                    Return 0
                End Try

            End Get
            Set(value As Decimal)
                Me.txtMonto.Text = value.ToString
            End Set
        End Property
        Private Property entregaMedicamento As Boolean
            Get
                Return Me.rbMedicamentoSi.Checked
            End Get
            Set(value As Boolean)

                If value = True Then
                    Me.rbMedicamentoSi.Checked = True
                Else
                    Me.rbMedicamentoNo.Checked = True
                End If
            End Set
        End Property
        Private Property autorizacionDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property autorizacionFechaDocumento() As Long
            Get
                Return Me.dtpFechaDoc.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaDoc.ValueLong = value
            End Set
        End Property
        Private Property observacion() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Private Property idFotoPaquete As Integer = -1
        Private Property archivoFotoByte As Byte()
        Private Property DatosVisitante1 As String = ""
        Private Property DatosVisitante2 As String = ""
        Private Property esInternoPJ As Boolean = False
#End Region
#Region "Propiedades_Visitante"
        Private ReadOnly Property idVisitante() As Integer
            Get
                Return Me.UscVisitante1._VisitanteIDReturn
            End Get
        End Property
        Private ReadOnly Property VisitanteApeNom() As String
            Get
                Return Me.UscVisitante1._ApellidosyNombres
            End Get
        End Property
        Private ReadOnly Property VisitanteNumeroDoc() As String
            Get
                Return Me.UscVisitante1._NumeroDocumento
            End Get
        End Property
#End Region
#Region "Propiedades_Interno"
        Private Property idInterno As Integer = -1
        Private Property idInternoPJ As Integer = -1
        Private Property IntTipoDocumento() As String
            Get
                Return Me.txtIntTipoDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntTipoDoc.Text = value
            End Set
        End Property
        Private Property IntNumeroDocumento() As String
            Get
                Return Me.txtIntNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntNumDoc.Text = value
            End Set
        End Property
        Private Property IntApellidoPaterno() As String
            Get
                Return Me.txtIntApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApePat.Text = value
            End Set
        End Property
        Private Property IntApellidoMaterno() As String
            Get
                Return Me.txtIntApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntApeMat.Text = value
            End Set
        End Property
        Private Property IntNombres() As String
            Get
                Return Me.txtIntNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtIntNom.Text = value.ToUpper
            End Set
        End Property
        Private ReadOnly Property InternoApellidosyNombres() As String
            Get
                Dim value As String = ""
                value = Me.IntApellidoPaterno & " " & Me.IntApellidoMaterno & ", " & Me.IntNombres
                Return value
            End Get
        End Property
        Private Property Edad() As String
            Get
                Return Me.txtEdad.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtEdad.Text = value.ToString
            End Set
        End Property
        Private Property SituacionJuridica() As String
            Get
                Return Me.txtSitJur.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSitJur.Text = value
            End Set
        End Property
        Private Property PabellonID() As Integer = -1
        Private Property PabellonNombre() As String
            Get
                Return Me.txtIntPab.Text.Trim.ToUpper
            End Get
            Set(ByVal value As String)
                Me.txtIntPab.Text = value.ToString.ToUpper
            End Set
        End Property
        Private Property EtapaID() As Integer = -1
        Private Property Etapa() As String
            Get
                Return Me.txtEtapa.Text.Trim.ToUpper
            End Get
            Set(ByVal value As String)
                Me.txtEtapa.Text = value.ToString.ToUpper
            End Set
        End Property
        Private Property InternoSancion() As Boolean
            Get
                Return Me.UscFotografia_2v1._PanelAutorizacion
            End Get
            Set(ByVal value As Boolean)
                Me.UscFotografia_2v1._PanelAutorizacion = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboTipoArticulo()

            With Me.cbbTipoArticulo
                .ComboTipo = Type.Combo.ComboTipo.seg_pqt_tipoarticulo_mae 'tipo articulo de paqueteria
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarSancionInterno(ByVal InternoID As Integer, ByVal FechaVisita As Long)

            Dim objBss As New Bussines.Visita.InternoSancion
            Me.InternoSancion = objBss.Sancion(InternoID, FechaVisita)

        End Sub

        Private Sub ListarInterno(ByVal objEntDatos As Entity.Visita.Interno)

            If objEntDatos Is Nothing Then
                Exit Sub
            End If

            If objEntDatos.Codigo < 1 Then
                Exit Sub
            End If

            With objEntDatos
                Me.idInterno = .Codigo
                Me.IntTipoDocumento = .TipoDocumentoNombre
                Me.IntNumeroDocumento = .NumeroDocumento
                Me.IntApellidoPaterno = .ApellidoPaterno
                Me.IntApellidoMaterno = .ApellidoMaterno
                Me.IntNombres = .Nombres
                Me.Edad = .Edad
                Me.SituacionJuridica = .SituacionJuridica
                Me.PabellonID = .PabellonID
                Me.PabellonNombre = .PabellonNombre
                Me.EtapaID = .EtapaID
                Me.Etapa = .EtapaNombre

                If Me.EtapaID < 1 Then
                    Me.Etapa = "S/E"
                End If

            End With

            ListarInternoFotoVersion(Me.idInterno)
            ListarSancionInterno(Me.idInterno, Me.FechaRegistro)
            HabilitarDatosVisitante()

        End Sub

        Private Sub ListarInternoPJ(objEntDatos As Entity.Visita.InternoPJ)

            If objEntDatos Is Nothing Then
                Exit Sub
            End If

            If objEntDatos.Codigo < 1 Then
                Exit Sub
            End If

            With objEntDatos
                Me.IntTipoDocumento = .TipoDocumento
                Me.IntNumeroDocumento = .NumeroDocumento
                Me.IntApellidoPaterno = .PrimerApellido
                Me.IntApellidoMaterno = .SegundoApellido
                Me.IntNombres = .PreNombres
                Me.Edad = .Edad
                Me.SituacionJuridica = "S/I"
                Me.PabellonID = .IDPabellon
                Me.PabellonNombre = .Pabellon
                Me.EtapaID = -1
                Me.Etapa = ""

                If Me.EtapaID < 1 Then
                    Me.Etapa = "S/E"
                End If

            End With

            'foto de los internos pj
            Me.UscFotografia_2v1._cargarImagen(My.Resources.logo_pj02)

            HabilitarDatosVisitante()

        End Sub

        Private Sub LoadUscVisitante()

            With Me.UscVisitante1
                ._RegionID = Me._idRegion
                ._RegionNombre = Me._regionNombre
                ._PenalID = Me._idPenal
                ._PenalNombre = Me._penalNombre
                ._FechaVisita = Me.FechaRegistro
                ._ValidarFechaNacimiento = True
                ._TipoVisita = Type.Enumeracion.Visita.EnumTipo.RegistroPaquetes
                ._mostrarTipoDocumentosValidos = True
                ._visibleCampoPase(False)
                'tabla de configuracion
                ._HabilitarHuellaDigital = Me._HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me._HabilitarCapHuellaValReniec
                'reniec
                ._ValidarModuloVisConReniec = Me._ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me._ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me._ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me._ValidarVisitanteConMigraciones
                ._LoadUsc()
            End With

        End Sub

        Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, 2)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub

        Public Sub _listarInterno(idInterno As Integer, esInternoPJ As Boolean)

            Dim objEnt As New Entity.Visita.Interno
            Dim idInternoSelect As Integer = -1
            Me.idInternoPJ = -1

            If esInternoPJ = False Then

                'internos inpe                                
                objBssInterno = New Bussines.Visita.Interno
                objEnt = objBssInterno.Listar2(idInterno)
                idInternoSelect = idInterno

                With objEnt
                    .Codigo = .Codigo
                    .ApellidoPaterno = .ApellidoPaterno
                    .ApellidoMaterno = .ApellidoMaterno
                    .Nombres = .Nombres
                    .PabellonID = .PabellonID
                    .PabellonNombre = .PabellonNombre
                    .EtapaID = .EtapaID
                    .EtapaNombre = .EtapaNombre
                    Me.PabellonNombre = objEnt.PabellonNombre
                End With

                'validar interno
                If objEnt.Codigo < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha podido cargar los datos del interno. Intentelo nuevamente")
                    Exit Sub
                End If

                'listar los datos del interno asociados a los controles
                ListarInterno(objEnt)

            Else

                'internos pj
                Dim objBssInternoPJ As New Bussines.Visita.InternoPJ
                Dim objEntInternoPj As New Entity.Visita.InternoPJ

                objEntInternoPj = objBssInternoPJ.Listar(idInterno)
                idInternoSelect = idInterno

                With objEntInternoPj
                    .PrimerApellido = .PrimerApellido
                    .SegundoApellido = .SegundoApellido
                    .PreNombres = .PreNombres
                    .IDPabellon = .IDPabellon
                    .Pabellon = .Pabellon

                    Me.PabellonNombre = .Pabellon
                End With

                'listar los datos del interno asociados a los controles
                ListarInternoPJ(objEntInternoPj)
                Me.idInternoPJ = idInterno
                Me.esInternoPJ = esInternoPJ
            End If

            Form_Parentesco(esInternoPJ, Type.Enumeracion.Parentesco.TipoVisita.Familiares, Me.EtapaID, idInternoSelect, Me.idVisitante, Me.InternoApellidosyNombres)

        End Sub
#End Region

#Region "Validar"
        Public Function Validar() As Boolean

            Dim value As Boolean = False

            'codigo de visitante
            If Me.idVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Registre el visitante")
                Me.UscVisitante1._Focus()
                Return value
            End If

            'validar datos del visitante
            If Me.UscVisitante1._ValidarVisitante = False Then
                Return value
            End If

            'validar interno
            If Me.idInterno < 1 And Me.idInternoPJ < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Seleccione interno")
                Return value
            End If

            'parentesco
            If Me.idParentesco < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Seleccione parentesco")
                Return value
            End If

            'entrega de paquete 
            If Me.tipoPaquete < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Seleccione tipo de entrega de paquete")
                Return value
            End If

            'tipo presentacion 
            If Me.tipoPresentacion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Seleccione tipo de presentacion del paquete")
                Return value
            End If

            'tipo articulo
            If Me.idTipoArticulo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Seleccione tipo articulo")
                Me.cbbTipoArticulo.Focus()
                Return value
            End If

            'peso
            If Me.Peso < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese un valor correcto para el peso del paquete")
                Me.nupPeso.Focus()
                Return value
            End If

            'entrega de dinero
            If Me.entregaDinero = True Then
                If Me.montoDinero < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el monto del dinero a entregar")
                    Me.txtMonto.Focus()
                    Return value
                End If

                If Me.montoDinero > MONTO_PERMITIDO Then

                    'autorizacion documento
                    If Me.autorizacionDocumento.Trim.Length < 3 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "Ingrese el numero de documento que autoriza el ingreso de dinero (monto supera a lo permitido)")
                        Me.txtNumDoc.Focus()
                        Return value
                    End If

                    'autorizacion fecha documento
                    If Me.autorizacionFechaDocumento < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                          "Ingrese la fecha del documento que autoriza el ingreso de dinero (monto supera a lo permitido)")
                        Me.dtpFechaDoc.Focus()
                        Return value
                    End If

                End If

            End If

            'autorizacion
            If Me.entregaMedicamento = True Then
                'autorizacion documento
                If Me.autorizacionDocumento.Trim.Length < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Ingrese el numero de documento que autoriza el ingreso de medicamentos(s)")
                    Me.txtNumDoc.Focus()
                    Return value
                End If

                'autorizacion fecha documento
                If Me.autorizacionFechaDocumento < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                      "Ingrese la fecha del documento que autoriza el ingreso de medicamento(s)")
                    Me.dtpFechaDoc.Focus()
                    Return value
                End If
            End If

            'validar la declaracion 
            If Me.autorizacionDocumento.Trim.Length > 0 Or Me.autorizacionFechaDocumento > 0 Then
                If Me.cbAutorizacion.Checked = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Active la opcion: [Se deja copia fisico del documento de autorización]")
                    Me.cbAutorizacion.Focus()
                    Return value
                End If
            End If

            If Me.archivoFotoByte Is Nothing OrElse Me.archivoFotoByte.Length < 1 Then
                If Legolas.Configuration.Aplication.MessageBox.Question(
                "No ha tomado fotografia del paquete, aún asi desea continuar?") = DialogResult.No Then
                    Return value
                End If
            End If

            value = True
            Return value
        End Function

#End Region
#Region "Accion"

        Public Function _AGrabar() As Boolean

            Dim value As Boolean = False
            Dim blnGraboDatosVisitante As Boolean = True

            If Validar() = True Then

                'falta validar si el visitante ha cambiado algo, para actualizarso sino pasa sin update
                Me.DatosVisitante2 = Me.UscVisitante1._ConcatenarPropiedadesVisitante

                If Me.DatosVisitante1 <> Me.DatosVisitante2 Then
                    blnGraboDatosVisitante = Me.UscVisitante1._GrabarVisitante()
                End If

                If blnGraboDatosVisitante = True Then
                    aGrabarMovimiento()
                    value = True
                End If

            End If

            Return value

        End Function

        Private Sub aGrabarMovimiento()

            Dim intValue As Integer = 0

            objBssRegistro = New Bussines.Seguridad.Paquetes.Registro
            objEntRegistro = New Entity.Seguridad.Paquetes.Registro
            Dim dteFecha As DateTime = Legolas.LBusiness.Globall.DateTime.FechaServer(True)

            If Not Me.archivoFotoByte Is Nothing Then
                Dim nombreArchivo As String = Me._idRegion.ToString + "_" + Me._idPenal.ToString + "_"
                Me.idFotoPaquete = aGrabarFotoPaquete(Me.archivoFotoByte, nombreArchivo)
            End If

            'aqui  me quede
            With objEntRegistro

                'grabar movimiento
                Me.objEntRegistro = New Entity.Seguridad.Paquetes.Registro
                With Me.objEntRegistro
                    .codigo = -1
                    '/*visita*/
                    .idVisita = Me.idVisitante
                    .visitaApellidosNombres = Me.VisitanteApeNom
                    .visitaNumeroDocumento = Me.VisitanteNumeroDoc
                    '/*interno*/
                    If Me.esInternoPJ = True Then
                        .tipoInterno = 2
                        .idInternoPJ = Me.idInternoPJ
                    Else
                        .tipoInterno = 1
                        .idInterno = Me.idInterno
                    End If
                    .internoApellidosNombres = Me.InternoApellidosyNombres
                    '/*otros*/
                    .idParentesco = Me.idParentesco
                    .fechaRegistro = dteFecha
                    .tipoPaquete = Me.tipoPaquete
                    .tipoPresentacion = Me.tipoPresentacion
                    .tipoPresentacionNombre = Me.tipoPresentacionNombre
                    .idTipoArticulo = Me.idTipoArticulo
                    .peso = Me.Peso
                    .numeroElementos = Me.cantidad
                    .entregaDinero = Me.entregaDinero
                    .montoDinero = Me.montoDinero
                    .entregaMedicamento = Me.entregaMedicamento
                    .autorizacionNumDoc = Me.autorizacionDocumento
                    .autorizacionFechaDoc = Me.autorizacionFechaDocumento
                    .observacion = Me.observacion
                    .idFotoPaquete = Me.idFotoPaquete
                    .idRegion = Me._idRegion
                    .idPenal = Me._idPenal
                End With

                intValue = objBssRegistro.Grabar(Me.objEntRegistro)

            End With

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                Me.UscVisitante1._ALimpiarVisitante(True)
                ALimpiarInterno()
                aLimpiarRegistro()

                Me.UscVisitante1._Focus()
            End If

        End Sub
        Private Function aGrabarFotoPaquete(archivoByte() As Byte, nombreArhivo As String) As Integer

            Dim mensajeOut As String = ""
            Dim objEnt As New Entity.Seguridad.Paquetes.ArchivoDigital
            Dim objBss As New Bussines.Seguridad.Paquetes.ArchivoDigital
            Dim dteFecha As Date = Legolas.LBusiness.Globall.DateTime.FechaServer()

            With objEnt
                .codigo = -1
                .anio = dteFecha.Year
                .mes = dteFecha.Month
                .pcMac = Legolas.Components.PC.GetMAC
                .pcNombre = Legolas.Components.PC.PCNombre
                .pcIP = Legolas.Components.PC.GetIP
                .archivoByte = archivoByte
                .nombreFisico = nombreArhivo
                .extension = "jpg"
                .pesoByte = archivoByte.Length
                .idRegion = Me._idRegion
                .idPenal = Me._idPenal
            End With

            Dim value As Integer = -1
            value = objBss.Grabar(objEnt, mensajeOut)

            If value < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeOut)
            End If

            Return value

        End Function
#End Region
#Region "Formulario"
        Private Sub FRM_Foto()

            If Me.idVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Antes de capturar la foto del paquete, seleccione el visitante")
                Exit Sub
            End If

            If Me.idInterno < 1 And Me.idInternoPJ < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Antes de capturar la foto del paquete, seleccione el interno")
                Exit Sub
            End If

            Dim pathFotoPaquete As String = ""
            Dim strRutaW As String = Legolas.Configuration.Path.Directorio & "windows81.ini".ToUpper.ToString

            '/*si el equipo dectecta el archivo windows8.1, sadlra la webcam para ese so*/
            If Legolas.Components.Archivo.FileExiste(strRutaW) = True Then

                Dim frm As New APPCamaraWeb.frmFotov3
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        pathFotoPaquete = ._PathImagenTemporal
                    End If
                End With
            Else

                Dim frm As New APPCamaraWeb.frmFoto
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        pathFotoPaquete = ._PathImagenTemporal
                    End If
                End With
            End If

            Me.archivoFotoByte = Legolas.Components.Archivo.FileConvertByte(pathFotoPaquete)

            If archivoFotoByte.Length > 0 Then
                Legolas.Components.Archivo.FileDelete(pathFotoPaquete)
                verFoto(archivoFotoByte)
            End If

        End Sub
        Private Sub Form_InternoPJ()

            'validar
            If Me.idVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Para buscar internos(as) del PJ, primero debe ingresar los datos del visitante")
                Exit Sub
            End If

            RaiseEvent _Click_Form_InternosPJ(Me.idVisitante)

        End Sub
        Private Sub Form_Interno()

            'validar
            If Me.idVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Para buscar internos(as), primero debe ingresar los datos del visitante")
                Exit Sub
            End If

            RaiseEvent _Click_Form_Internos(Me.idVisitante)

        End Sub
        Private Sub Form_InternosHistoricos()

            Dim strApellidos As String = ""
            Dim strNombres As String = ""

            'validar
            If Me.idVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Para buscar internos(as) visitados anteriormente, debe ingresar los datos del visitante")
                Exit Sub
            End If

            RaiseEvent _Click_Form_InternosHistoricos(Me.idVisitante)

        End Sub

        Private Function Form_Parentesco(blnEsInternPJ As Boolean, TipoParentesco As Type.Enumeracion.Parentesco.TipoVisita,
                                         ByVal EtapaID As Integer, ByVal InternoID As Integer, ByVal VisitanteID As Integer,
                                         ByVal InternoApellidosyNombres As String) As Boolean

            Dim value As Boolean = False

            ParentescoIDArray = New List(Of Integer)
            ParentescoNombreArray = New List(Of String)

            'primeros buscamos el parentesco del visitante con el interno en la tabla autorizacion
            Dim objBss As Bussines.Visita.Autorizacion = Nothing
            Dim objEntCol As Entity.Visita.AutorizacionCol = Nothing
            Dim objEntFiltro As New Entity.Visita.Autorizacion

            'si el interno tiene etapa, hay q buscarlo en autorizacion
            If EtapaID > 0 Then

                objEntFiltro = New Entity.Visita.Autorizacion
                With objEntFiltro
                    .VisitanteID = VisitanteID
                    .InternoID = InternoID
                    .TipoID = 1 ' autorizado
                End With

                objBss = New Bussines.Visita.Autorizacion
                objEntCol = New Entity.Visita.AutorizacionCol

                objEntCol = objBss.ListarVisitante(objEntFiltro)

                For Each obj As Entity.Visita.Autorizacion In objEntCol
                    Me.idParentesco = obj.ParentescoID
                    Me.parentescoNombre = obj.Parentesco

                    'add a la colecion de parentesco
                    Me.ParentescoIDArray.Add(Me.idParentesco)
                    Me.ParentescoNombreArray.Add(Me.parentescoNombre)
                Next

                'si no hay ningun parentesco, lo ubicamos en la visita extraordinario
                If Me.idParentesco < 1 Then

                    objBss = New Bussines.Visita.Autorizacion
                    objEntCol = New Entity.Visita.AutorizacionCol

                    objEntFiltro = New Entity.Visita.Autorizacion
                    With objEntFiltro
                        .VisitanteID = VisitanteID
                        .InternoID = InternoID
                        .TipoID = 99 'extraordinario
                        .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                    End With

                    objEntCol = objBss.ListarVisitante_Extraordinario(objEntFiltro)

                    For Each obj As Entity.Visita.Autorizacion In objEntCol
                        Me.idParentesco = obj.ParentescoID
                        Me.parentescoNombre = obj.Parentesco
                        'add a la colecion de parentesco
                        Me.ParentescoIDArray.Add(Me.idParentesco)
                        Me.ParentescoNombreArray.Add(Me.parentescoNombre)
                    Next

                End If

            Else

                'si el interno no es interno pj 
                If blnEsInternPJ = False Then

                    '/*ORDINARIO*/
                    If Me._SolicitarAutoRegOrdinario = True Then

                        'primeros buscamos el parentesco del visitante con el interno en la tabla autorizacion                
                        objEntFiltro = New Entity.Visita.Autorizacion
                        With objEntFiltro
                            .VisitanteID = VisitanteID
                            .InternoID = InternoID
                            .TipoID = 1 ' autorizado
                        End With

                        objBss = New Bussines.Visita.Autorizacion
                        objEntCol = New Entity.Visita.AutorizacionCol

                        objEntCol = objBss.ListarVisitante(objEntFiltro)

                        ParentescoIDArray = New List(Of Integer)
                        ParentescoNombreArray = New List(Of String)

                        For Each obj As Entity.Visita.Autorizacion In objEntCol
                            Me.idParentesco = obj.ParentescoID
                            Me.parentescoNombre = obj.Parentesco
                            'add a la colecion de parentesco
                            Me.ParentescoIDArray.Add(Me.idParentesco)
                            Me.ParentescoNombreArray.Add(Me.parentescoNombre)
                        Next

                        'si no hay ningun parentesco, lo ubicamos en la visita extraordinario-ordinario
                        If Me.idParentesco < 1 Then

                            objEntFiltro = New Entity.Visita.Autorizacion
                            With objEntFiltro
                                .VisitanteID = VisitanteID
                                .InternoID = InternoID
                                .TipoID = 99 'extraordinario
                                .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            End With

                            objBss = New Bussines.Visita.Autorizacion
                            objEntCol = New Entity.Visita.AutorizacionCol

                            objEntCol = objBss.ListarVisitante_Extraordinario(objEntFiltro)

                            For Each obj As Entity.Visita.Autorizacion In objEntCol
                                Me.idParentesco = obj.ParentescoID
                                Me.parentescoNombre = obj.Parentesco
                                'add a la colecion de parentesco
                                Me.ParentescoIDArray.Add(Me.idParentesco)
                                Me.ParentescoNombreArray.Add(Me.parentescoNombre)
                            Next

                        End If

                    Else

                        'si no hay ningun parentesco, lo ubicamos en la visita extraordinario-ordinario
                        If Me.idParentesco < 1 Then

                            objEntFiltro = New Entity.Visita.Autorizacion
                            With objEntFiltro
                                .VisitanteID = VisitanteID
                                .InternoID = InternoID
                                .TipoID = 99 'extraordinario
                                .Fecha = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            End With

                            objBss = New Bussines.Visita.Autorizacion
                            objEntCol = New Entity.Visita.AutorizacionCol

                            objEntCol = objBss.ListarVisitante_Extraordinario(objEntFiltro)

                            For Each obj As Entity.Visita.Autorizacion In objEntCol
                                Me.idParentesco = obj.ParentescoID
                                Me.parentescoNombre = obj.Parentesco
                                'add a la colecion de parentesco
                                Me.ParentescoIDArray.Add(Me.idParentesco)
                                Me.ParentescoNombreArray.Add(Me.parentescoNombre)
                            Next

                        End If

                    End If

                Else

                    'si es interno pj
                    Me.idParentesco = -1

                End If

            End If

            'formulario parentesco
            If Me.idParentesco < 1 Then
                Dim frm As New Visita.frmParentesco
                With frm
                    ._TipoParentesco = TipoParentesco
                    ._InternoNombre = InternoApellidosyNombres.ToUpper
                    If .ShowDialog = DialogResult.OK Then
                        Me.idParentesco = ._GrillaParentescoID
                        Me.parentescoNombre = ._GrillaParentescoNombre
                        'add a la colecion de parentesco
                        Me.ParentescoIDArray.Add(Me.idParentesco)
                        Me.ParentescoNombreArray.Add(Me.parentescoNombre)
                    End If
                End With
            End If

            If Me.idParentesco > 0 Then
                value = True
            End If

            Return value
        End Function

#End Region
#Region "Permisos/Accesos"
        Private Sub RegimenTipo_Permisos()

            Dim blnMostrarColumnas As Boolean = False

            Me.lblEtapa.Visible = blnMostrarColumnas
            Me.txtEtapa.Visible = blnMostrarColumnas

            '/*columnas*/            
            Me.btnBuscarInternosPJ.Visible = Me._HabilitarInternoPJ

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarDatosVisitante()

            Dim blnEnabledVisitante As Boolean = True

            If Me._SolicitarAutoRegOrdinario = True Then
                blnEnabledVisitante = False
            Else
                If Me.EtapaID < 1 Then
                    blnEnabledVisitante = True
                Else
                    blnEnabledVisitante = False
                End If
            End If

            Me.UscVisitante1._HabilitarDatosVisitante(blnEnabledVisitante)

        End Sub
        Private Sub ListarConfigVisitas()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._idRegion
                .PenalID = Me._idPenal
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then

                With objEnt
                    Me.SolicitarAutoRegOrdinario = .SolicitaAutoRegOrdinario
                    Me.HabilitarInternoPJ = .HabilitarInternosPJ
                    '/*huella*/
                    Me.HabilitarHuellaDigital = False ' .HabilitaHuellaDigital'xxx
                    Me.HabilitarCapHuellaValReniec = False ' .CapturarHuellaValReniec'xxx
                    '/*reniec*/
                    Me.ValidarModuloVisConReniec = .ValidarModVisitaConReniec
                    Me.ValidarVisitanteConReniec = .ValidarVisitanteConReniec
                    'migraciones                    
                    Me.ValidarModuloVisConMigraciones = .ValidarModVisitaConMigraciones
                    Me.ValidarVisitanteConMigraciones = .ValidarVisitanteConMigraciones
                End With

            Else
                Me.SolicitarAutoRegOrdinario = False
                Me.HabilitarInternoPJ = False
                '/*huella*/
                Me.HabilitarHuellaDigital = False
                Me.HabilitarCapHuellaValReniec = False
                '/*reniec*/
                Me.ValidarModuloVisConReniec = False
                Me.ValidarVisitanteConReniec = False
                '/*migraciones*/
                Me.ValidarModuloVisConMigraciones = False
                Me.ValidarVisitanteConMigraciones = False
            End If

        End Sub
        Public Sub _ActualizarParametricasRegionPenal()

            ListarConfigVisitas()

            With Me.UscVisitante1
                ._RegionID = Me._idRegion
                ._PenalID = Me._idPenal
                ._RegionNombre = Me._regionNombre
                ._PenalNombre = Me._penalNombre
                '/*tabla de configuracion del modulo de visita*/                
                ._HabilitarHuellaDigital = Me._HabilitarHuellaDigital
                ._HabilitarCapHuellaValReniec = Me._HabilitarCapHuellaValReniec
                'reniec
                ._ValidarModuloVisConReniec = Me._ValidarModuloVisConReniec
                ._ValidarVisitanteConReniec = Me._ValidarVisitanteConReniec
                'migraciones
                ._ValidarModuloVisConMigraciones = Me._ValidarModuloVisConMigraciones
                ._ValidarVisitanteConMigraciones = Me._ValidarVisitanteConMigraciones
            End With

            RegimenTipo_Permisos()

        End Sub

        Private Function ValidarPropiedadesParemetricas() As Boolean

            Dim value As Boolean = False

            If Me._idRegion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_RegionID], no esta inicializado")
                Return value
            End If

            If Me._idPenal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError(
                "El parametro [_PenalID], no esta inicializado")
                Return value
            End If

            value = True
            Return value

        End Function

        Public Sub _Focus()
            Me.UscVisitante1._Focus()
        End Sub

        Private Sub ALimpiarInterno()

            Me.idInterno = -1
            Me.idInternoPJ = -1

            Me.IntTipoDocumento = ""
            Me.IntNumeroDocumento = ""
            Me.IntApellidoPaterno = ""
            Me.IntApellidoMaterno = ""
            Me.IntNombres = ""
            Me.Edad = ""
            Me.SituacionJuridica = ""
            Me.PabellonID = -1
            Me.PabellonNombre = ""
            Me.Etapa = ""
            Me.UscFotografia_2v1._Limpiar()

            aLimpiarParentesco()

        End Sub

        Private Sub aLimpiarParentesco()
            Me.idParentesco = -1
            Me.parentescoNombre = ""
        End Sub
        Private Sub aLimpiarRegistro()

            Me.tipoPaquete = -1
            Me.tipoPresentacion = -1
            Me.tipoPresentacionNombre = ""
            Me.idTipoArticulo = -1
            Me.nupPeso.Text = "1"
            Me.nupElementos.Text = "1"
            Me.entregaDinero = False
            Me.montoDinero = 0
            Me.entregaMedicamento = False
            Me.autorizacionDocumento = ""
            Me.autorizacionFechaDocumento = 0
            Me.observacion = ""
            Me.cbAutorizacion.Checked = False
            Me.gbAutorizacion.Enabled = False
            Me.UscFotografia1._Limpiar()
            Me.idFotoPaquete = -1
            Me.archivoFotoByte = Nothing

        End Sub

        Public Sub _ValoresxDefault()
            ValoresxDefault()
        End Sub

        Private Sub ValoresxDefault()

            RegimenTipo_Permisos()

        End Sub

        Public Sub _LoadUsc()

            If ValidarPropiedadesParemetricas() = False Then
                Exit Sub
            End If

            Me.FechaRegistro = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong

            LoadToolTipText()
            LoadUscVisitante()
            ComboTipoArticulo()

        End Sub

        Private Sub LoadToolTipText()

            With Me.ToolTip1
                .SetToolTip(Me.btnLimpiar, "Limpiar datos del interno")
                .SetToolTip(Me.btnOtros, "Buscar Internos(as) en la Poblacion del Penal")
                .SetToolTip(Me.bntHist, "Buscar Internos(as) visitados anteriormente o Autorizados")
                .SetToolTip(Me.btnBuscarInternosPJ, "Buscar Poblacion del Poder Judicial")
            End With

        End Sub

        Public Sub _LimpiarMovimiento()

            'caso contrario solo limpio
            Me.UscVisitante1._ALimpiarVisitante(True)
            ALimpiarInterno()
            aLimpiarRegistro()
            Me.UscVisitante1._Focus()
            Me.FechaRegistro = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong

        End Sub

        Private Sub VerImagenTipoDocumento(intIDTipoDocumento As Short)

            Select Case intIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    pbTipoDocumento.Image = My.Resources.dni

                Case Type.Enumeracion.enmTipoDocumento.CE
                    pbTipoDocumento.Image = My.Resources.ce

                Case Type.Enumeracion.enmTipoDocumento.PTP
                    pbTipoDocumento.Image = My.Resources.ptp

                Case Type.Enumeracion.enmTipoDocumento.PAS
                    pbTipoDocumento.Image = My.Resources.pas

                Case Else
                    Me.pbTipoDocumento.Image = Nothing
            End Select

        End Sub

        Private Sub habilitarOtroPresentacion()

            If Me.tipoPresentacion = 4 Then 'otro
                Me.txtPresentacionOtro.Visible = True
                Me.txtPresentacionOtro.Focus()
            Else
                Me.txtPresentacionOtro.Visible = False
                Me.txtPresentacionOtro.Text = ""
            End If

        End Sub
        Private Sub verFoto(ByVal fotoByte As Byte())

            With Me.UscFotografia1
                .SizeMode = PictureBoxSizeMode.Zoom
                ._mostrarFotoByte(fotoByte)
            End With

        End Sub
        Private Sub habilitarMontoDinero()

            If Me.entregaDinero = True Then
                Me.txtMonto.Enabled = True
                Me.txtMonto.Focus()
            Else
                Me.montoDinero = 0
                Me.txtMonto.Enabled = False
            End If

            habilitarAutorizacion()
        End Sub
        Private Sub habilitarAutorizacion()

            If Me.entregaMedicamento = True Or (Me.entregaDinero = True And montoDinero > MONTO_PERMITIDO) Then
                Me.gbAutorizacion.Enabled = True
                Me.txtNumDoc.Focus()
            Else
                Me.gbAutorizacion.Enabled = False
                Me.autorizacionDocumento = ""
                Me.autorizacionFechaDocumento = 0
                Me.cbAutorizacion.Checked = False
            End If

        End Sub
#End Region

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

            ALimpiarInterno()

        End Sub

        Private Sub bntHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntHist.Click

            Me.esInternoPJ = False
            aLimpiarParentesco()
            Form_InternosHistoricos()

        End Sub

        Private Sub btnOtros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtros.Click

            Me.esInternoPJ = False
            aLimpiarParentesco()
            Form_Interno()

        End Sub

        Private Sub UscVisitante1__Click_BuscarVisita() Handles UscVisitante1._Click_BuscarVisita

            RaiseEvent _Click_BuscarVisitante()

        End Sub

        Private Sub UscVisitante1__ListarData() Handles UscVisitante1._Click_ListarData

            Me.DatosVisitante1 = Me.UscVisitante1._ConcatenarPropiedadesVisitante
            Form_InternosHistoricos()

        End Sub

        Private Sub btnBuscarInternosPJ_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarInternosPJ.Click

            Me.esInternoPJ = True
            Form_InternoPJ()

        End Sub

        Private Sub UscVisitante1__SelectedIndexChanged_TipoDocumento(intIDTipoDocumento As Short) Handles UscVisitante1._SelectedIndexChanged_TipoDocumento

            VerImagenTipoDocumento(intIDTipoDocumento)

        End Sub

        Private Sub rdbSobre_Click(sender As Object, e As EventArgs) Handles rdbSobre.Click,
            rdbSobreBolsa.Click, rdbBolsa.Click, rdbOtro.Click

            habilitarOtroPresentacion()

        End Sub

        Private Sub btnCapurar_Click(sender As Object, e As EventArgs) Handles btnCapurar.Click
            FRM_Foto()
        End Sub

        Private Sub rbDineroNo_Click(sender As Object, e As EventArgs) Handles rbDineroNo.Click, rbDineroSi.Click

            habilitarMontoDinero

        End Sub

        Private Sub rbMedicamentoNo_Click(sender As Object, e As EventArgs) Handles rbMedicamentoNo.Click, rbMedicamentoSi.Click

            habilitarAutorizacion

        End Sub

        Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged

            habilitarAutorizacion()

        End Sub
    End Class

End Namespace