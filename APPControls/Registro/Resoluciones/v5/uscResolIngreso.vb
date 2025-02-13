Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class uscResolIngreso
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Public Event _Click_btnDatos()
        Public Event _MostrarControles(MotivoId As Integer, uscVisible As Boolean, menuVisible As Boolean)
        Public Event _LimpiarGrillaExpediente()
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
#End Region
#Region "Propiedades"
        Public Property DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
        Public Property DocumentoSubTipo() As Integer = -1

        Public Property DocumentoNumero() As String
            Get
                Return txtNumOficio.Text.Trim

            End Get
            Set(value As String)
                txtNumOficio.Text = value
            End Set
        End Property
        Public Property DocumentoFechaRecepcion() As Long
            Get
                Return dtpDocJudFecRecep.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Public Property DocumentoFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property


        Public Property Observacion() As String
            Get
                Return txtObservacion.Text
            End Get
            Set(value As String)
                txtObservacion.Text = value
            End Set
        End Property
        Private Property NumLibro As String
            Get
                Return txtLibro.Text
            End Get
            Set(value As String)
                txtLibro.Text = value
            End Set
        End Property
        Private Property NumFolio As String
            Get
                Return txtFolio.Text
            End Get
            Set(value As String)
                txtFolio.Text = value
            End Set
        End Property
        Public Property FechaMovimiento As Long = 0
        'Private Property MovimientoMotivoId As Integer = -1
        Public Property _TipoAutoridadJudicialID As Integer = -1
        Public Property _DistritoJudicialID As Integer = -1
        Public Property _DistritoJudicialNombre As String = ""
        Public Property _SalaJuzgado As Integer = -1
        Public Property _SalaJuzgadoNombre As String = ""
        Public Property _Juez As String = ""
        Public Property _Secretario As String = ""
        Public Property _OtraAutoridadNombre As String = ""
        Public Property _OtraAutoridadCargo As String = ""
        Public Property _SituacionJuridicaId As Integer = -1
        Public Property _Motivo As Integer = -1
        '  Public Property _MovimientoMotivo As Integer = -1
        Private Property RegionIngreso() As Integer = -1
        Private Property PenalIngreso() As Integer = -1
        Public Property RegionDestino() As Integer = -1
        Public Property PenalDestino() As Integer = -1
        Public Property DocumentoJudicialPenalOrigen() As String = ""
        Public Property FechaInternamientoPenalOrigen As Long = 0
        Public Property FechadeIngresoPenalOrigen() As Long = 0
        Public Property ObservacionPenalOrigen As String = ""
        Public Property ProlonDetencionCantidad As String = ""
        Public Property ProlonDetencionUnidad As String = ""
        Public Property ProlonDetencionFechIni As Long = 0
        Public Property ProlonDetencionFechFin As Long = 0
        Public Property Cadenaperpetua As Boolean = False
        Public Property TotalAnios As Integer = 0
        Public Property TotalMeses As Integer = 0
        Public Property TotalDias As Integer = 0
        Public Property EstablecimentomentalId As Integer = -1
#End Region
#Region "Listar"
        Public Sub _Load(TipoIngreso As Integer)

            Listar2(TipoIngreso)

        End Sub
        Private Sub Listar()
            If Me._Codigo < 1 Then
                Me.RegionIngreso = Me._RegionID
                Me.PenalIngreso = Me._PenalID
                Exit Sub
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            objEnt.Codigo = Me._Codigo

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    objEnt = objBss.Listar_v2_LM(objEnt)
                Case Else
                    objEnt = objBss.Listar_v2(objEnt)
            End Select
            With objEnt
                Me._Codigo = .Codigo
                Me.DocumentoTipo = .DocumentoTipo
                Me.DocumentoSubTipo = .DocumentoSubTipoId
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.Observacion = .Observacion
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me.RegionIngreso = Me._RegionID ' .RegionDestinoId
                Me.PenalIngreso = Me._PenalID '.PenalDestinoid
                Me.RegionDestino = .RegionDestinoId
                Me.PenalDestino = .PenalDestinoid
                Me._MovimientoMotivo = .MovimientoMotivoId
                Me.ProlonDetencionUnidad = .ProlonDetencionTipoUnidad
                Me.ProlonDetencionCantidad = .ProlonDetencionValor
                Me.ProlonDetencionFechIni = .ProlonDetencionFechIni
                Me.ProlonDetencionFechFin = .ProlonDetencionFechFin
                'Datos del Traslado
                Me.DocumentoJudicialPenalOrigen = .DocumentoJudicialPenalOrigen
                Me.FechaInternamientoPenalOrigen = .FechaInternamientoPenalOrigen
                Me.FechadeIngresoPenalOrigen = .FechaIngresoPenalOrigen
                Me.ObservacionPenalOrigen = .ObservacionPenalOrigen
                Me.Cadenaperpetua = .SentenciaCadenaPerpetua
                Me.TotalAnios = .SentenciaTotalAnios
                Me.TotalMeses = .SentenciaTotalMeses
                Me.TotalDias = .SentenciaTotalDias
                'Me.EstablecimentomentalId = .EstablecimientomentalId
            End With
        End Sub
        Public Sub Listar2(Subtipo As Integer)
            If Me._Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If

            If Me._Codigo < 1 Then
                Me.RegionIngreso = Me._RegionID
                Me.PenalIngreso = Me._PenalID
                Exit Sub
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.InternoId = Me._InternoId
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            objEnt.InternoIngresoId = Me._InternoIngresoId
            objEnt.DocumentoTipo = Me.DocumentoTipo
            objEnt.DocumentoSubTipoId = Subtipo
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_v2_LM(objEnt)
            Else
                objEnt = objBss.Listar_v2(objEnt)
            End If


            With objEnt
                Me._Codigo = .Codigo
                Me.DocumentoTipo = .DocumentoTipo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.Observacion = .Observacion
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me.RegionIngreso = Me._RegionID ' .RegionDestinoId
                Me.PenalIngreso = Me._PenalID '.PenalDestinoid
                Me._MovimientoMotivo = .MovimientoMotivoId
                Me.DocumentoJudicialPenalOrigen = .DocumentoJudicialPenalOrigen
                Me.FechaInternamientoPenalOrigen = .FechaInternamientoPenalOrigen
                Me.FechadeIngresoPenalOrigen = .FechaIngresoPenalOrigen
                Me.ObservacionPenalOrigen = .ObservacionPenalOrigen
            End With
        End Sub
#End Region
#Region "accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False
            ''par-region/penal
            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros [Region/Penal], no fueron enviados al Objeto")
                Return blnValue
            End If

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código del ingreso inpe no fueron enviados al Objeto")
                    Return blnValue
                End If
            Else
                If Me._InternoIngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código del ingreso no fueron enviados al Objeto")
                    Return blnValue
                End If
            End If

            '/*fecha de documento*/
            If Me.DocumentoNumero.Length < 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Numero del documento Judicial")
                Me.txtNumOficio.Focus()
                Return blnValue
            End If
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            If Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            '/*comparacion de fechas*/
            If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                blnValue = False
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.DocumentoNumero = Me.DocumentoNumero
            objEnt.DocumentoTipo = Me._DocumentoTipo
            objEnt.InternoIngresoId = Me._InternoIngresoId
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            objEnt.InternoId = Me._InternoId

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt.InternoIngresoId = -1
                If Me._Codigo < 1 And objBss.CuentaDocumentoTipo_LM(objEnt) > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
                    txtNumOficio.Focus()
                    Return blnValue
                End If
            Else
                If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
                    txtNumOficio.Focus()
                    Return blnValue
                End If
            End If

            Return True
        End Function
        Public Function AGrabar(objDocumento As Entity.Registro.DocumentoJudicial) As Integer
            'Nuevo ingreso
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoSubTipoId = objDocumento.DocumentoSubTipoId
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .Observacion = Me.Observacion
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoId
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                RaiseEvent _Click_btnDatos()
                .TipoAutoridadJudicial = Me._TipoAutoridadJudicialID
                .DistritoJudicial = Me._DistritoJudicialID
                .DistritoJudNombre = Me._DistritoJudicialNombre
                .SalaJuzgado = Me._SalaJuzgado
                .JuezNombre = Me._Juez
                .SecretarioNombre = Me._Secretario
                .AutoridadOtroNombre = Me._OtraAutoridadNombre
                .AutoridadOtroCargo = Me._OtraAutoridadCargo
                .SituacionJuridicaId = Me._SituacionJuridicaId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .MovimientoMotivoId = objDocumento.MovimientoMotivoId
                If Me.DocumentoTipo = 73 Then .MovimientoMotivoId = cbbMotivo.SelectedValue
                .FechaMovimiento = objDocumento.FechaMovimiento ' FechaMovimiento
                .Estado = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                .ProlonDetencionFechIni = objDocumento.ProlonDetencionFechIni
                .ProlonDetencionFechFin = objDocumento.ProlonDetencionFechFin
                .ProlonDetencionTipoUnidad = objDocumento.ProlonDetencionTipoUnidad
                .ProlonDetencionValor = objDocumento.ProlonDetencionValor

                If .DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                    .RegionOrigenId = objDocumento.RegionOrigenId
                    .PenalOrigenId = objDocumento.PenalOrigenId
                    .RegionDestinoId = Me._RegionID
                    .PenalDestinoid = Me._PenalID
                    .DocumentoJudicialPenalOrigen = objDocumento.DocumentoJudicialPenalOrigen ' Me.DocumentoJudicialPenalOrigen
                    .FechaInternamientoPenalOrigen = objDocumento.FechaInternamientoPenalOrigen  ' Me.FechaInternamientoPenalOrigen
                    .FechaIngresoPenalOrigen = objDocumento.FechaIngresoPenalOrigen ' Me.FechadeIngresoPenalOrigen
                    .ObservacionPenalOrigen = objDocumento.ObservacionPenalOrigen ' Me.ObservacionPenalOrigen
                End If
                .SentenciaCadenaPerpetua = objDocumento.SentenciaCadenaPerpetua
                .SentenciaTotalAnios = objDocumento.SentenciaTotalAnios
                .SentenciaTotalMeses = objDocumento.SentenciaTotalMeses
                .SentenciaTotalDias = objDocumento.SentenciaTotalDias
                .RegionDestinoId = Me._RegionID
                .PenalDestinoid = Me._PenalID
                If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    .RegionDestinoId = objDocumento.RegionDestinoId
                    .PenalDestinoid = objDocumento.PenalDestinoid
                End If
                '.EstablecimientomentalId = objDocumento.EstablecimientomentalId
            End With
            Dim value As Integer = 0
            If value = 0 Then
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        objEnt.FlagTransferenciaSede = Me.FlagTransferSede
                        value = objBss.Grabar_LM(objEnt)
                    Case Else
                        value = objBss.Grabar2(objEnt)
                End Select
                Return value
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe una resolucion de ingreso vigente")
            End If
            Return -1
        End Function

#End Region
#Region "Combo"
        Private Sub ComboMotivo()
            With Me.cbbMotivo
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR MOTIVO]"
                .CodigoPadre = 1
                Dim msj As String = ""
                If Me.DocumentoTipo = 73 Then
                    msj = "OTR"
                Else
                    If Me._Codigo = -1 Then msj = "NEU"
                End If
                ._LoadUsc(Type.Combo.ComboTipo.MovimientoMotivo, False, msj)
                Me.cbbMotivo.SelectedValue = -1
            End With
        End Sub
        Public Property _MovimientoMotivo() As Integer
            Get
                Return Me.cbbMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMotivo.SelectedValue = value
            End Set
        End Property
#End Region


#Region "Otros"
        Private Sub ValoresxDefault()

            Listar()
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If _RegionID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(
                    "ERROR: Verifique que se haya pasado el valor de IdRegión")
                End If
            Else
                If _RegionID < 1 Or _PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError(
                    "ERROR: Verifique que se haya pasado los valores del IdInterno, IdPenal e IdRegión")
                End If
            End If

            txtNumOficio.Focus()
        End Sub
        Public Sub _LoadUsc()
            If Me._Codigo < 1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If
            If Me.DocumentoTipo = 73 Then
                Me.pnlMotivo.Visible = True
                ComboMotivo()
            End If
            Listar()
            If Me.DocumentoTipo = 73 Then
                lblDocumento.Text = "Nº de oficio : "
                lblFecharecepcion.Text = "Fecha de recepción"
            End If
        End Sub
        Public Function _LoadUsc2(SubTipo As Integer) As Entity.Registro.DocumentoJudicial
            If Me._Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If
            Listar2(SubTipo)
            Return objEnt
        End Function
        Public Sub CargarEiquetasTraslado(TipoDocumento As Integer)
            If TipoDocumento = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                lblDocumento.Text = "N° RD :"
                lblFechadocumento.Text = "Fecha de RD:"
            Else
                lblDocumento.Text = "N° Documento :"
                lblFechadocumento.Text = "Fecha Doc.:"
            End If

        End Sub
#End Region
        Private Sub cbbRegion__SelectedIndexChanged()
            txtLibro.Focus()
        End Sub

        Private Sub dtpDocJudFecha__ValueChanged() Handles dtpDocJudFecha._ValueChanged
            With dtpDocJudFecha
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpDocJudFecha_Validated(sender As Object, e As System.EventArgs) Handles dtpDocJudFecha.Validated
            With dtpDocJudFecha
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpDocJudFecRecep__ValueChanged() Handles dtpDocJudFecRecep._ValueChanged
            With dtpDocJudFecRecep
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpDocJudFecRecep_Validated(sender As Object, e As System.EventArgs) Handles dtpDocJudFecRecep.Validated
            With dtpDocJudFecRecep
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub
        Dim intCombo As Integer = -1
        Dim intContador As Integer = 0
        Private Sub cbbMotivo__SelectedIndexChanged() Handles cbbMotivo._SelectedIndexChanged
            Select Case cbbMotivo.SelectedValue
                Case Type.Enumeracion.Movimiento.EnumMovMotivo.NuevoIngreso,
                     Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReincidencia,
                     Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReiterante
                    If intContador > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El motivo de ingreso seleccionado no esta vigente, operación cancelada.")
                        cbbMotivo.SelectedValue = -1
                        Exit Sub
                    End If
                Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva
                    RaiseEvent _MostrarControles(cbbMotivo.SelectedValue, True, False)

                Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado
                    RaiseEvent _MostrarControles(cbbMotivo.SelectedValue, False, True)

                    lblMovTraslado.Text = "Motivo de Traslado:"
                    lblMovTraslado.Visible = True
                    cbbMotivo.Visible = True

                Case Type.Enumeracion.Movimiento.EnumMovMotivo.Inimputable
                    RaiseEvent _MostrarControles(cbbMotivo.SelectedValue, False, True)


                Case Type.Enumeracion.Movimiento.EnumMovMotivo.PosibleInimputable
                    RaiseEvent _MostrarControles(cbbMotivo.SelectedValue, False, True)



                Case Else
                    RaiseEvent _MostrarControles(cbbMotivo.SelectedValue, False, False)
            End Select
            intCombo = cbbMotivo.SelectedValue

        End Sub

    End Class
End Namespace