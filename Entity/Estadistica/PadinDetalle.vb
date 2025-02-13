Namespace Estadistica

    Public Class PadinDetalle
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intSentenciaDelitoEspecificoID As Integer = -1

        Public Property GruposDelictivosOtros() As String = "" 'para grupos delictivos no incluidos en la ley 30077(siscrico), ejm.:Sendero luminuso, cartel de tijuana
        Public Property OrgCriminalFormaParte() As Boolean = False 'PERTENECE A ORG. CRIMINAL (LEY 30077)
        Public ReadOnly Property OrgCriminalFormaParteString() As String
            Get
                Return If(Me.OrgCriminalFormaParte = True, "SI", "")
            End Get
        End Property
        Public Property OrgCriminalNombre() As String = "" 'NOMBRE, CASO O EXPDIENTE DE LA ORG. CRIMINAL
        Public Property OrgCriminalCondicion() As String = ""

        Public Property DelitoFlagrante() As Boolean = False 'causal aplicado al interno, en caso tenga n expedientes y 1 con flagrancia el interno se considera flagrante.
        Public Property TrasladoId As Integer = -1
        Public Property IngresoTrasladoId As Integer = -1
        Public Property IDDocumentoIngreso As Integer = -1
        Public Property EgresoTrasladoId As Integer = -1
        Public Property IDDocumentoEgreso As Integer = -1
        Public Property IDExpedienteEgreso As Integer = -1
        Public Property IDMovimientoIngreso As Integer = -1
        Public Property IDMovimientoEgreso As Integer = -1
        Public Property IDMovimiento As Integer = -1

        Public ReadOnly Property DelitoFlagranteString() As String
            Get
                Return If(Me.DelitoFlagrante = True, "SI", "NO")
            End Get
        End Property
#End Region
#Region "Datos_Generales"
        Public Property Codigo() As Long = -1
        Public Property PadinID() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property RegionCodigo() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalCodigo() As String = ""
        Public Property FechaCorte() As Long = 0

        Public ReadOnly Property FechaCorteString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(FechaCorte, True)
            End Get
        End Property
        Public Property PadinCorrela() As Integer = 0
        Public Property InternoID() As Integer = -1
        Public Property InternoCodigo() As String = ""
        Public Property InternoTipoDocumentoID() As Integer = -1
        Public Property InternoTipoDocumento() As String = ""
        Public Property InternoNumeroDocumento() As String = ""
        Public Property InternoPrimerApellido() As String = ""
        Public Property InternoSegundoApellido() As String = ""
        Public Property InternoPreNombres() As String = ""        
        Public Property InternoLeido() As Integer = -1
        Public Property InternoCondicionColor() As Integer = -1
        Public Property InternoCondicionNroInternos() As Integer = -1
        Public ReadOnly Property InternoApellidosyNombres() As String
            Get
                Dim value As String = ""

                value = Me.InternoPrimerApellido & " " & Me.InternoSegundoApellido & ", " & Me.InternoPreNombres
                Return value.ToUpper

            End Get
        End Property
        Public Property InternoNombresAsociados() As String = ""
        Public ReadOnly Property InternoApellidosyNombresAsociados() As String
            Get
                Dim value As String = ""
                value = InternoApellidosyNombres

                If Me.InternoNombresAsociados.Trim.Length > 2 Then
                    value = value & " o " & Me.InternoNombresAsociados
                End If

                Return value.ToUpper
            End Get
        End Property
        Public Property InternoAlias() As String = ""
        Public Property InternoClasificacion() As String = ""
        Public Property InternoPabellon() As String = ""
        Public Property InternoFechaNacimiento() As Long = 0
        Public ReadOnly Property InternoFechaNacimientoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.InternoFechaNacimiento, True)
            End Get
        End Property
        Public ReadOnly Property InternoEdad() As Integer
            Get
                Dim value As Integer = 0
                value = Legolas.Components.FechaHora.FechaCalcularAnio(Me.InternoFechaNacimiento, Me.FechaHoy, True)
                Return value
            End Get
        End Property
        Public Property InternoSexoID() As Integer = -1
        Public Property InternoSexo() As String = ""
        Public Property InternoNacimientoPaisID() As Integer = -1
        Public Property InternoNacimientoPais() As String = ""
        Public Property InternoNacimientoDepartamento() As String = ""
        Public Property InternoNacimientoProvincia() As String = ""
        Public Property InternoNacimientoDistrito() As String = ""
        Public Property InternoNacionalidad() As String = ""
        Public Property InternoNumeroHijo() As Integer = 0
        Public Property InternoEstadoCivilID() As Integer = -1
        Public Property InternoEstadoCivil() As String = ""
        Public Property InternoGradoInstruccionID() As Integer = -1
        Public Property strInternoGradoInstruccion() As String = ""
        Public Property InternoGradoInstruccion() As String
            Get
                Return strInternoGradoInstruccion.ToUpper
            End Get
            Set(ByVal value As String)
                strInternoGradoInstruccion = value
            End Set
        End Property


        Public Property InternoOcupacionGenericoID() As Integer = -1
        Private strInternoOcupacionGenerico As String = ""
        Public Property InternoOcupacionGenerico() As String
            Get
                Return strInternoOcupacionGenerico.ToUpper
            End Get
            Set(value As String)
                strInternoOcupacionGenerico = value
            End Set
        End Property

        Private _InternoOcupacionEspecifico As String
        Public Property InternoOcupacionEspecifico As String
            Get
                Return UCase(_InternoOcupacionEspecifico)
            End Get
            Set(ByVal value As String)
                _InternoOcupacionEspecifico = value
            End Set
        End Property

        Public Property InternoComunidaGenericaID() As Integer = -1

        Private _InternoComunidaNativa As String
        Public Property InternoComunidaNativa() As String
            Get
                Return UCase(_InternoComunidaNativa)
            End Get
            Set(ByVal value As String)
                _InternoComunidaNativa = value
            End Set
        End Property

        Public Property InternoDiscapacidadID() As Integer = -1
        Public Property InternoDiscapacidad() As String = ""
        Public Property InternoPadre() As String = ""
        Public Property InternoMadre() As String = ""
        Public ReadOnly Property InternoPadreyMadre() As String
            Get
                Dim value As String = ""
                Dim x As String = ""
                If Me.InternoPadre.Trim <> "" And Me.InternoMadre.Trim <> "" Then x = ","
                value = InternoPadre & x & " " & InternoMadre
                Return UCase(value).Trim
            End Get
        End Property

        Private _InternoDomicilio As String
        Public Property InternoDomicilio() As String
            Get
                Return UCase(_InternoDomicilio)
            End Get
            Set(ByVal value As String)
                _InternoDomicilio = value
            End Set
        End Property


        Public Property InternoDomicilioDepartamento() As String = ""
        Public Property InternoDomicilioProvincia() As String = ""
        Public Property InternoDomicilioDistrito() As String = ""
        Public Property InternoFiliacionPolitica() As String = ""
        Public Property InternoEstadoID() As Integer = -1
        Public Property InternoIdioma() As String = ""
        Public Property InternoGenero() As String = ""
        Public Property InternoPerteneciaEtnica() As String = ""
        Public Property InternoLenguaMaterna() As String = ""
        Public Property InternoFolio() As String = ""
        Public Property InternoLibro() As String = ""
        Public ReadOnly Property InternoEstado() As String
            Get
                Dim value As String = ""

                Select Case InternoEstadoID
                    Case 1 'activo
                        value = "Activo"
                    Case 0 'inactivo
                        value = "Inactivo"
                End Select

                Return value
            End Get
        End Property
        Public Property RegionNombre() As String = ""

        Private _PenalNombre As String
        Public Property PenalNombre() As String
            Get
                Return UCase(_PenalNombre)
            End Get
            Set(ByVal value As String)
                _PenalNombre = value
            End Set
        End Property
        Public Property PabellonNombre As String = ""


        Public Property Anio() As Integer = -1

        Private _MesNombre As String
        Public Property MesNombre() As String
            Get
                Return UCase(_MesNombre)
            End Get
            Set(ByVal value As String)
                _MesNombre = value
            End Set
        End Property


        Public Property InternoRegimen() As String = ""

#End Region
#Region "Ingreso"
        Public Property IngresoID() As Integer = -1
        Public Property IngresoEgresoID() As Integer = -1
        Public Property FechaISP() As Long = 0
        Public ReadOnly Property FechaISPString() As String
            Get
                Dim value As String = ""
                If Me.FechaISP > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(Me.FechaISP, True)
                End If
                Return value
            End Get
        End Property
        Public ReadOnly Property MesesReclusion() As Integer
            Get
                Return Legolas.Components.FechaHora.FechaCalcularMes(Me.FechaISP, Me.FechaHoy, True)
            End Get
        End Property
        Public Property FechaIngresoPenal() As Long = 0
        Public Property IngresoNumero() As Integer = 0

        Private _IngresoMotivo As String
        Public Property IngresoSubMotivoId() As Integer = -1
        Public Property IngresoMotivo() As String
            Get
                Return UCase(_IngresoMotivo)
            End Get
            Set(ByVal value As String)
                _IngresoMotivo = value
            End Set
        End Property

        Public Property IngresoOrigen() As String = ""

        Private _IngresoDocumento As String
        Public Property IngresoDocumento() As String
            Get
                Return UCase(_IngresoDocumento)
            End Get
            Set(ByVal value As String)
                _IngresoDocumento = value
            End Set
        End Property

        Private _IngresoMotivoTraslado As String
        Public Property IngresoMotivoTraslado() As String
            Get
                Return UCase(_IngresoMotivoTraslado)
            End Get
            Set(ByVal value As String)
                _IngresoMotivoTraslado = value
            End Set
        End Property
        Public Property IngresoTipoMovimientoID() As Integer = -1
        Public Property IngresoDelitosSegunMandatoDet() As String = ""
        Public Property IngresoSituacionJuridicaID() As Integer = -1
        Public Property IngresoSituacionJuridica() As String = ""
#End Region

#Region "Expediente"
        Public Property ExpedienteID() As Integer = -1
        Public Property ExpedienteHijosID() As String = ""
        Public Property ExpedienteLibertarID() As Integer = -1
        Public Property ExpedienteTipoAutoridadID() As Integer = -1
        Public Property ExpedienteDistritoJudicial() As String = ""
        Public Property ExpedienteSalaJuzgado() As String = ""
        Public Property ExpedienteJuez As String = ""
        Public Property ExpedienteSecretario As String = ""
        Public ReadOnly Property ExpedienteSecretarioyJuez As String
            Get
                Dim value As String = ""
                If Me.ExpedienteSecretario.Length > 0 And Me.ExpedienteJuez.Length > 0 Then
                    value = "/"
                End If
                value = Me.ExpedienteSecretario.Trim & value & Me.ExpedienteJuez.Trim

                Return value.ToUpper
            End Get
        End Property
        Public Property ExpedienteSituacionJuridicaID() As Integer = -1
        Public Property ExpedienteProcesoSituacionJuridicaID() As Integer = -1
        Public Property ExpedienteSituacionJuridica() = ""
        Public ReadOnly Property ExpedienteSituacionJuridicaNombreCorto()
            Get
                Dim value As String = ""

                Select Case Me.ExpedienteSituacionJuridicaID
                    Case 1
                        value = "PROC."
                    Case 2
                        value = "SENT."
                End Select

                Return value
            End Get
        End Property
        Public Property ExpedienteNumero() As String = ""
        Public ReadOnly Property ExpedienteNumeroySituacionJuridica() As String
            Get
                Dim value As String = ""
                If ExpedienteNumero.Length > 0 Then
                    value = UCase(ExpedienteNumero) & IIf(ExpedienteSituacionJuridicaNombreCorto = "", "", " | " & ExpedienteSituacionJuridicaNombreCorto) '
                End If
                Return value
            End Get
        End Property

        Public Property ExpedienteNumeroOtros() As String = ""
        Public Property ExpedienteFlagrancia As Boolean = False
        Public Property FechaRecepcion As Long = 0

        Public Property Inimputable() As String = ""
        Public Property EstablecimientoMental() As String = ""
#End Region
#Region "Delito"
        Public Property DelitoID() As Integer = -1
        Public Property DelitoGenericoID() As Integer = -1
        Public Property DelitoGenerico() As String = ""
        Public Property DelitoEspecificoID() As Integer = -1
        Public Property DelitoEspecifico() As String = ""
        Public Property DelitoArticulo() As String = ""
        Public Property DelitoTipo() As String = ""
        Public Property DelitoEspecificoGrupo() As String = ""
        Public Property DelitoOtros() As String = ""
        Public Property DelitoAgraviados() As String = ""
#End Region
#Region "Sentencia"
        Public Property SentenciaID() As Integer = -1
        Public Property SentenciaExpedienteID() As Integer = -1
        Public Property SentenciaFecha() As Long = 0
        Public Property SentenciaDistritoJudicial() As String = ""
        Public Property SentenciaSalaJuzgado() As String = ""
        Public Property SentenciaDocumento() As String = ""
        Public Property SentenciaDelitoID() As Integer = -1
        Public Property SentenciaDelitoGenerico() As String = ""
        Public Property SentenciaDelitoEspecificoID() As Integer
            Get
                Return intSentenciaDelitoEspecificoID
            End Get
            Set(ByVal value As Integer)
                intSentenciaDelitoEspecificoID = value
            End Set
        End Property
        Public Property SentenciaDelitoEspecifico() As String = ""
        Public Property SentenciaDelitoEspecificoGrupo() As String = ""
        Public Property SentenciaDelitosSegunResolSent As String = ""
        Public Property SentenciaCadenaPerpetua As Boolean = False
        Public Property SentenciaPenaImpuestaAnio() As Integer = 0
        Public ReadOnly Property SentenciaPenaImpuestaAnioString() As String
            Get

                Dim value As String = ""
                If Me.SentenciaPenaImpuestaAnio = 500 Then 'años, caderna perpetua
                    value = "Cadena Perpetua"
                Else
                    value = Me.SentenciaPenaImpuestaAnio.ToString
                End If

                Return value
            End Get

        End Property
        Public Property SentenciaPenaImpuestaMes() As Integer = 0
        Public Property SentenciaPenaImpuestaDia() As Integer = 0
        Public ReadOnly Property SentenciaPenaTotalMeses() As Integer
            Get
                Return Legolas.Components.FechaHora.FechaCalcularMes(Me.SentenciaFecha, Me.FechaHoy, True)
            End Get
        End Property
        Public Property SentenciaFechaIni() As Long = 0
        Public Property SentenciaFechaFin() As Long = 0
        Public Property SentenciaObs() As String = ""
        Public ReadOnly Property SentenciaFechaIniString() As String
            Get
                Dim value As String = ""
                If Me.SentenciaFechaIni > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(Me.SentenciaFechaIni, True)
                End If
                Return value
            End Get
        End Property
        Public ReadOnly Property SentenciaFechaFinString() As String
            Get
                Dim value As String = ""
                If Me.SentenciaFechaFin > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(Me.SentenciaFechaFin, True)
                End If
                Return value
            End Get
        End Property
#End Region
#Region "Sentencia otra instancia"
        'Primera instancia
        Public Property SentenciaPIFecha() As Long = 0
        Public Property SentenciaPIDistritoJudicial() As String = ""
        Public Property SentenciaPISalaJuzgado() As String = ""
        Public Property SentenciaPIExpedienteNumero() As String = ""
        'Instancia superior
        Public Property SentenciaSIDistritoJudicial() As String = ""
        Public Property SentenciaSISalaJuzgado() As String = ""
        Public Property SentenciaSIExpedienteNumero() As String = ""
        Public Property SentenciaSIDocumentoNumero() As String = ""
        Public ReadOnly Property SentenciaPIFechaString() As String
            Get
                Dim value As String = ""
                If Me.SentenciaPIFecha > 0 Then
                    value = Legolas.Components.FechaHora.FechaDate(Me.SentenciaPIFecha, True)
                End If
                Return value
            End Get
        End Property
#End Region

#Region "Egreso"
        Public Property EgresoFecha() As Long = 0
        Public Property EgresoTipoID() As Integer = -1
        Public Property EgresoTipo() As String = ""
        Public Property EgresoTipoMotivoID() As Integer = -1
        Public Property EgresoTipoMotivo() As String = ""
        Public Property LibertadSubtipoNom() As String = ""
        Public Property EgresoDestino() As String = ""
        Public Property EgresoTipoAutoridadID() As String = ""
        Public Property EgresoDistritoJudicial() As String = ""
        Public Property EgresoSalaJuzgado() As String = ""
        Public Property EgresoDocumentoLibertad() As String = ""
        Public Property EgresoDocumento() As String = ""
        Public Property EgresoDocumentoRD() As String = ""
        Public Property EgresoJuez() As String = ""
        Public Property EgresoSecretario() As String = ""
        Public Property EgresoOtroNombre() As String = ""
        Public Property EgresoOtraAutoridad() As String = ""
        Public Property EgresoObservacion() As String = ""
        Public Property PadinDetalleVisible As Integer = 0
        Public Property PadinTipoMovimiento() As Integer = -1
        Public Property TipoDetalleMovimientoIng() As Integer = -1
        Public Property TipoDetalleMovimientoSal() As Integer = -1
        Public Property TipoMovimientoID() As Integer = -1
        Public ReadOnly Property EgresoSecretarioJuez() As String
            Get
                Dim strValue As String = ""

                If Me.EgresoSecretario.Length > 0 And Me.EgresoJuez.Length > 0 Then
                    strValue = " / "
                End If

                Return Me.EgresoSecretario & strValue & Me.EgresoJuez

            End Get
        End Property
        Public ReadOnly Property EgresoEjecutado() As String
            Get
                Dim value As String = ""

                If EgresoTipoMotivoID > 0 Then

                    If Me.EgresoFecha > 1 Then
                        value = "SI"
                    Else
                        value = "NO"
                    End If
                End If

                Return value

            End Get
        End Property
#End Region
#Region "Otros"
        Public Property FechaHoy As Long = 0
        Public Property FechaCreaRegistro As Long = 0
        Public ReadOnly Property FechaCreaRegistroString() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(FechaCreaRegistro, True)
            End Get
        End Property
        Public Property FechaModificaRegistro As Long = 0
        Public ReadOnly Property FechaIngresoPenalString() As String
            Get
                Dim valor As String = ""
                If FechaIngresoPenal > 0 Then
                    valor = Legolas.Components.FechaHora.FechaDate(FechaIngresoPenal, True)
                End If
                Return valor
            End Get
        End Property
        Public ReadOnly Property FechaModificaRegistroString() As String
            Get

                Return Legolas.Components.FechaHora.FechaDate(FechaModificaRegistro, True)
            End Get
        End Property
        Public ReadOnly Property SentenciaFechaString() As String
            Get
                Dim Valor As String = ""
                If Me.SentenciaFecha > 0 Then
                    Valor = Legolas.Components.FechaHora.FechaDate(Me.SentenciaFecha, True)
                End If
                Return Valor
            End Get
        End Property
        Public Property ObservacionRegistro() As String = ""
        Public Property ObservacionExcel() As String = ""
        Public ReadOnly Property ObservacionRegistroImg() As System.Drawing.Bitmap
            Get
                If ObservacionRegistro.Trim = "" Then
                    Return My.Resources.check_box_black
                Else
                    Return My.Resources.warning_32x32
                End If
            End Get
        End Property
        Public ReadOnly Property EgresoFechaString() As String
            Get
                Dim Valor As String = ""
                If EgresoFecha > 0 Then
                    Valor = Legolas.Components.FechaHora.FechaDate(EgresoFecha, True)
                End If
                Return Valor
            End Get
        End Property
        Public Property InternoColor() As System.Drawing.Color = Drawing.Color.White
        Public Property InternoColorActivo() As System.Drawing.Color = Drawing.Color.White
        Public Property InternoColorPadin() As System.Drawing.Color = Drawing.Color.White
        Public Property InternoColorEgreso() As System.Drawing.Color = Drawing.Color.White
        Public ReadOnly Property InternoIngresoNuevo() As String
            Get
                Dim value As String = ""
                If InternoColorActivo <> Drawing.Color.White Then
                    value = "SI"
                End If
                Return value
            End Get
        End Property
        Public Function CloneCol() As PadinDetalle
            Return MyBase.MemberwiseClone
        End Function
#End Region
    End Class



#Region "PadinDetalleCol"
    Public Class PadinDetalleCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As PadinDetalle) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property PadinDetalle(ByVal Index As Integer) As PadinDetalle
            Get
                Return CType(MyBase.List(Index), PadinDetalle)
            End Get
        End Property
        Public Function CloneCol() As PadinDetalle
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace

