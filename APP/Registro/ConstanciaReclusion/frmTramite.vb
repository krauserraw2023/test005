Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports APPControlHuellaVisita.Business
Imports APPControls

Namespace Registro.ConstanciaReclusion
    Public Class frmTramite
        Private objBss As Bussines.Registro.ConstanciaReclusion.Tramite = Nothing
        Private codigo As Integer = -1
        Private idRegion As Short = -1
        Private idPenal As Short = -1
        Private idInterno As Integer = -1
        Private idIngresoInpe As Integer = -1
        Private idIngreso As Integer = -1
        Private expedienteManual As Boolean = False
        Private formLicencia As Short
        Private Const tituloMensaje As String = "Registro de Solicitud de Constancia de Reclusión"
        'prueba
#Region "propiedades"
        Private Property codigoInterno As String
            Get
                Return Me.txtCodigoRP.Text
            End Get
            Set(value As String)
                Me.txtCodigoRP.Text = value
            End Set
        End Property
        Private Property InternoApeNombres As String
            Get
                Return Me.txtInterno.Text
            End Get
            Set(value As String)
                Me.txtInterno.Text = value
            End Set
        End Property
        Private Property RegionalPenalNombre As String
            Get
                Return Me.txtRegionPenal.Text
            End Get
            Set(value As String)
                Me.txtRegionPenal.Text = value
            End Set
        End Property

        Private Property numeroTramite As String
            Get
                Return Me.txtNumeroTramite.Text
            End Get
            Set(value As String)
                Me.txtNumeroTramite.Text = value
            End Set
        End Property
        Private Property idEstado As Short = 1

        Private Property estadoNombre As String
            Get
                Return txtEstado.Text
            End Get
            Set(value As String)
                txtEstado.Text = value.ToString()
            End Set
        End Property

        Private Property numeroCR As String
            Get
                Return txtNumeroCR.Text
            End Get
            Set(value As String)
                txtNumeroCR.Text = value
            End Set
        End Property

        Private Property fechaExpedicion As String
            Get
                Return Me.txtFechaExp.Text
            End Get
            Set(value As String)
                Me.txtFechaExp.Text = value
            End Set
        End Property
        Private Property usuarioCR As String
            Get
                Return txtUsuario.Text
            End Get
            Set(value As String)
                txtUsuario.Text = value
            End Set
        End Property
        Private Property fechaRecepcionEP As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaRecepEP.ValueLong > 0 Then
                    value = Me.dtpFechaRecepEP.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaRecepEP.Value = value
            End Set
        End Property

        Private Property fechaRecepcionRP As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaRecepRP.ValueLong > 0 Then
                    value = Me.dtpFechaRecepRP.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaRecepRP.Value = value
            End Set
        End Property

        Private Property idTipoSolicitante As Integer
            Get
                Return cbbTipSolicitante.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipSolicitante.SelectedValue = value
            End Set
        End Property

        Private Property idTipoDocumentoRef As Integer
            Get
                Return cbbTipoDocumentoRef.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoDocumentoRef.SelectedValue = value
            End Set
        End Property

        Private Property tipoTramite As Short = 1
        Private Property tipoTramiteNombre As String
            Get
                Return Me.txtTipoTramite.Text.ToUpper
            End Get
            Set(value As String)
                Me.txtTipoTramite.Text = value
            End Set
        End Property


        Private Property serieRecibo As String
            Get
                Return Me.txtSerRecibo.Text
            End Get
            Set(value As String)
                Me.txtSerRecibo.Text = value
            End Set
        End Property
        Private Property numeroRecibo As String
            Get
                Return txtNumDocRef.Text
            End Get
            Set(value As String)
                txtNumDocRef.Text = value
            End Set
        End Property
        Private Property numeroReferencia As String
            Get
                Return txtNumDocRef.Text
            End Get
            Set(value As String)
                txtNumDocRef.Text = value
            End Set
        End Property

        Private Property fechaDocumentoReferencia As DateTime
            Get
                Dim value As DateTime
                If Me.dtpFechaRef.ValueLong > 0 Then
                    value = Me.dtpFechaRef.Value
                Else
                    value = Nothing
                End If
                Return value
            End Get
            Set(value As DateTime)
                Me.dtpFechaRef.Value = value
            End Set
        End Property
        Public Property idDistritoJudicial() As Integer
            Get
                Dim value As Integer = -1
                value = UscComboDistritoJudicial1._selectedValue
                If value < 1 Then
                    value = -1
                End If
                Return value
            End Get
            Set(value As Integer)
                UscComboDistritoJudicial1._selectedValue = value
            End Set
        End Property
        Public Property idSalaJuzgado() As Integer
            Get
                Dim value As Integer = -1
                value = UscComboSala1._SalaJuzgadoID
                If value < 1 Then
                    value = -1
                End If
                Return value
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
        Private Property observacion As String
            Get
                Return txtobs.Text
            End Get
            Set(value As String)
                txtobs.Text = value
            End Set
        End Property

        Private Property obsAnulacion As String
            Get
                Return txtobs_anulacion.Text
            End Get
            Set(value As String)
                txtobs_anulacion.Text = value
            End Set
        End Property
        Private Property penalTipoLicencia As Short = -1
#End Region
#Region "Propiedades_Resultado"
        Public Property resultFechaISP As String
            Get
                Return Me.txtFechaISP.Text
            End Get
            Set(value As String)
                Me.txtFechaISP.Text = value
            End Set
        End Property
        Public Property resultFechaIEP As String
            Get
                Return Me.txtFechaIEP.Text
            End Get
            Set(value As String)
                Me.txtFechaIEP.Text = value
            End Set
        End Property
        Public Property resultIdDistritoJudicial() As Integer
            Get
                Dim value As Integer = -1
                value = UscComboDistritoJudicial2._selectedValue
                If value < 1 Then
                    value = -1
                End If
                Return value
            End Get
            Set(value As Integer)
                UscComboDistritoJudicial2._selectedValue = value
            End Set
        End Property

        Public Property resultIdSalaJuzgado() As Integer
            Get
                Return Me.UscComboSala2._SalaJuzgadoID
            End Get
            Set(value As Integer)
                Me.UscComboSala2._SalaJuzgadoID = value
            End Set
        End Property
        'Public Property resultSalaJudicialNombre As String
        '    Get
        '        Return UscLabelBusqueda1._Value
        '    End Get
        '    Set(value As String)
        '        UscLabelBusqueda1._Value = value
        '    End Set
        'End Property
        Public Property resultIdExpediente As Integer
        Public Property resultExpediente As String
            Get
                Return Me.txtNumExp.Text
            End Get
            Set(value As String)
                Me.txtNumExp.Text = value
            End Set
        End Property
        Public Property resultSecretario As String
            Get
                Return Me.txtExpSecretario.Text
            End Get
            Set(value As String)
                Me.txtExpSecretario.Text = value
            End Set
        End Property
        Public Property resultDelitos As String
            Get
                Return Me.txtDelitoNombre.Text
            End Get
            Set(value As String)
                Me.txtDelitoNombre.Text = value
            End Set
        End Property

#End Region
#Region "Propiedades_Publicas"
        Public Property _getActualizoDatos As Boolean = False
        Public Property _getIdInternoVerDetalle As Integer = -1
        Public Property _getIdPenal As Short = -1
        Public Property _verDetalleInterno As Boolean = False
#End Region
        Public Sub New(codigo As Integer, idInterno As Integer,
                       idRegion As Short, idPenal As Short, internoCodigoRP As String, internoApeNombres As String,
                       regionNombre As String, penalNombre As String, ByRef abrirForm As Boolean, formLicencia As Short)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.codigo = codigo
            Me.idRegion = idRegion
            Me.idPenal = idPenal
            Me.idInterno = idInterno
            Me.codigoInterno = internoCodigoRP
            Me.InternoApeNombres = internoApeNombres
            Me.RegionalPenalNombre = regionNombre + " - " + penalNombre
            Me.formLicencia = formLicencia

            abrirForm = False
            'listar los ids de ingreso del interno
            If codigo < 1 Then
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                Dim entTramite As New Entity.Registro.ConstanciaReclusion.Tramite
                Dim mensaje As String = ""

                entTramite = objBss.listarInternoIngreso(idInterno)

                Me.idIngresoInpe = entTramite.idIngresoInpe
                Me.idIngreso = entTramite.idIngreso

                If objBss.validarInternoUltimoIngreso(idInterno, idIngresoInpe, idIngreso, mensaje) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
                    Exit Sub
                End If

                'solo si es provincia
                If Me.idIngresoInpe > 0 Then

                    'validar, la cantidad de expedientes
                    Dim cantidadExpe As Integer = 0
                    objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                    cantidadExpe = objBss.fnCantidadExpedientes(Me.idInterno, Me.idIngresoInpe)

                    If cantidadExpe > 0 Then
                        objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                        If objBss.validarExpedienteDmpSmp(Me.idInterno, Me.idIngresoInpe, Me.idIngreso, mensaje) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
                            Exit Sub
                        End If
                    End If

                Else
                    If objBss.validarExpedienteDmpSmp(idInterno, idIngresoInpe, idIngreso, mensaje) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
                        Exit Sub
                    End If
                End If

            End If

            abrirForm = True
        End Sub

        Public Sub New(codigo As Integer, formLicencia As Short)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.codigo = codigo
            Me.formLicencia = formLicencia

        End Sub
#Region "Combo"
        Private cargoComboSolicitante As Boolean = False
        Private Sub comboSolicitante()
            With cbbTipSolicitante
                .ComboTipo = Type.Combo.ComboTipo.TipoAutoridadJudicialSolicitante
                .LoadUsc()
                ._Todos = True
                .SelectedValue = Type.Enumeracion.enmTipoAutoridadJudicial.propioInterno
            End With
            cargoComboSolicitante = True
        End Sub

        Private cargoComboTipoDocumento As Boolean = False
        Private Sub comboTipoDocumentoRef()

            Dim bssCombo As New Bussines.General.Parametrica.ConstanciaReclusion
            Dim verSolicitud As Boolean = False
            Dim verMemo As Boolean = False
            Dim verOficio As Boolean = False

            Select Case Me.idTipoSolicitante
                Case Type.Enumeracion.enmTipoAutoridadJudicial.poderJudicial,
                     Type.Enumeracion.enmTipoAutoridadJudicial.ministerioPublico,
                     Type.Enumeracion.enmTipoAutoridadJudicial.minjus

                    verOficio = True

                Case Type.Enumeracion.enmTipoAutoridadJudicial.directorEP,
                     Type.Enumeracion.enmTipoAutoridadJudicial.presidenteCTP

                    verOficio = True
                    verMemo = True

                Case Type.Enumeracion.enmTipoAutoridadJudicial.propioInterno
                    verSolicitud = True
            End Select

            With cbbTipoDocumentoRef
                .DataSource = bssCombo.comboDocumento(verSolicitud, verMemo, verOficio)
                .DisplayMember = "Nombre"
                .ValueMember = "Codigo"
                .SelectedIndex = 0
            End With
            cargoComboTipoDocumento = True
        End Sub

        Private cargoComboDistritoJudicial As Boolean = False
        Private Sub ComboDistritoJudicial()
            With UscComboDistritoJudicial1
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
                ._Combo()
                ._selectedValue = -1
            End With
            cargoComboDistritoJudicial = True
        End Sub
        Private Sub ComboAutoridadJudicial()
            With Me.UscComboSala1
                ._ComboConfiguracion()
                If Me.idDistritoJudicial > 0 Then
                    ._Todos = True
                    ._TodosMensaje = "[SELECCIONAR AUTORIDAD JUDICIAL]"
                    ._DistritoJudicialID = Me.idDistritoJudicial
                    ._Combo()
                End If
            End With
        End Sub

        Private cargoComboDistritoJudExpe As Boolean = False

        Private Sub ComboResulDistritoJudicial()
            With UscComboDistritoJudicial2
                ._ComboConfiguracion()
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
                ._Combo()
                ._selectedValue = -1
            End With
            cargoComboDistritoJudExpe = True
            UscComboSala2._ComboConfiguracion()
        End Sub
        Private Sub ComboResultSalaJudicial()

            With Me.UscComboSala2
                If Me.resultIdDistritoJudicial > 0 Then
                    ._Todos = True
                    ._TodosMensaje = "[SELECCIONAR AUTORIDAD JUDICIAL]"
                    ._DistritoJudicialID = Me.resultIdDistritoJudicial
                    ._Combo()
                End If
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub listar()

            If Me.codigo < 1 Then
                Me.txtSerRecibo.Focus()
                Exit Sub
            End If

            ErrorProvider1.Clear()

            objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
            Dim objEnt As New Entity.Registro.ConstanciaReclusion.Tramite

            objEnt = objBss.listar(Me.codigo)
            With objEnt
                Me.idInterno = .idInterno
                Me.codigoInterno = .internoCodigoRD
                Me.InternoApeNombres = .internoApellidosyNombres
                Me.idIngreso = .idIngreso
                Me.idIngresoInpe = .idIngresoInpe
                Me.numeroTramite = .numeroTramite
                Me.idEstado = .estado
                Me.estadoNombre = .estadoNombre

                If Me.idEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.atendido Or
                     Me.idEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.anulado Then
                    Me.numeroCR = .numeroCR
                    Me.fechaExpedicion = .fechaCR
                    Me.usuarioCR = .usuarioCR
                End If

                Me.idTipoSolicitante = .idTipoSolicitante
                Me.tipoTramite = .tipoTramite
                Me.tipoTramiteNombre = fnTipoTramiteNombre(Me.tipoTramite)

                Me.idDistritoJudicial = .idDistritoJudicial
                Me.idSalaJuzgado = .idAutoridadJudicial
                Me.idTipoDocumentoRef = .documentoReferenciaTipo
                Me.serieRecibo = .serieRecibo
                Me.numeroReferencia = .documentoReferenciaNumero
                Me.fechaDocumentoReferencia = .documentoReferenciaFecha
                Me.fechaRecepcionEP = .fechaRecepcionEP
                Me.fechaRecepcionRP = .fechaRecepcionRP
                Me.observacion = .observacion
                Me.obsAnulacion = .observacionAnulacion
                Me.idRegion = .idRegion
                Me.idPenal = .idPenal
                Me.penalTipoLicencia = .penalTipoLicencia
                Me.RegionalPenalNombre = .getRegionPenalNombre
            End With

            Dim blnValor As Boolean = listarResultado()
            habilitarExpediente(blnValor, False)
            validarControles()

            UscAuditUser1.LoadAudit(Me.codigo, Type.Enumeracion.Auditoria.EnumTipTabla.reg_cons_reclu_mov_tramite)

        End Sub
        Private Function listarResultado() As Boolean
            Dim valor As Boolean = False
            If Me.codigo < 1 Then
                ' Exit Sub
                Return valor
            End If

            objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
            Dim objEnt As New Entity.Registro.ConstanciaReclusion.Tramite

            objEnt = objBss.listarResultado(Me.codigo)
            With objEnt
                resultFechaISP = .internoFechaIngSistPen
                resultFechaIEP = .internoFechaIngreso
                resultIdDistritoJudicial = .idDistritoJudicialResp
                resultIdSalaJuzgado = .idSalaJudicialResp
                resultIdExpediente = .idExpediente
                resultExpediente = .expedienteNumeroResp
                resultSecretario = .expedienteSecretarioResp
                resultDelitos = .expedienteDelitoResp
                If penalTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                    If Me.idEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Then
                        If resultIdExpediente = -1 And resultExpediente.Length > 0 Then
                            valor = True
                        End If
                    End If
                End If
            End With
            Return valor
        End Function
#End Region
#Region "validar"
        Private Function Validar() As Boolean
            Dim value As Boolean = False

            If Me.idEstado <> Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede modificar el registro de tramite, cuando se encuentra en el estado [Atendido].",
                    tituloMensaje)
                Return value
            End If

            If Me.idTipoSolicitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione solicitante", tituloMensaje)
                Me.cbbTipSolicitante.Focus()
                Return value
            End If

            'distrito judicial and sala judicial  
            If idTipoSolicitante = Type.Enumeracion.enmTipoAutoridadJudicial.poderJudicial Then

                If Me.idDistritoJudicial < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito judicial",
                        tituloMensaje)
                    Me.UscComboDistritoJudicial1.Focus()
                    Return value
                End If

                If Me.idSalaJuzgado < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione sala judicial",
                        tituloMensaje)
                    Me.UscComboSala1.Focus()
                    Return value
                End If
            End If

            'documento de referencia
            If Me.idTipoDocumentoRef < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione tipo de documento de referencia",
                                    tituloMensaje)
                Me.cbbTipoDocumentoRef.Focus()
                Return value
            End If

            If numeroRecibo.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el número del documento/recibo",
                                                                        tituloMensaje)
                Me.txtNumDocRef.Focus()
                Return value
            End If

            If Me.dtpFechaRef.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha del documento de referencia",
                                                                        tituloMensaje)
                dtpFechaRef.Focus()
                Return value
            End If

            If Me.dtpFechaRecepEP.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha de Recepción de la solicitud en el EP",
                    tituloMensaje)
                dtpFechaRecepEP.Focus()
                Return value
            End If

            If Me.dtpFechaRecepRP.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha de Recepción de la solicitud en RP",
                    tituloMensaje)
                dtpFechaRecepRP.Focus()
                Return value
            End If

            If Me.fechaRecepcionRP < Me.fechaRecepcionEP Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de Recepción de la solicitud en RP, no puede ser menor a la fecha de recepcion en el E.P.",
                    tituloMensaje)
                dtpFechaRecepRP.Focus()
                Return value
            End If

            'recibo del interno
            If Me.idTipoDocumentoRef = Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.solicitud Then

                If Me.fechaDocumentoReferencia > Me.fechaRecepcionEP Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de pago debe ser menor o igual a la fecha de recepción en el E.P.",
                        tituloMensaje)
                    dtpFechaRef.Focus()
                    Return value
                End If

            End If

            Dim mensaje As String = ""
            'si es plm
            If Me.idIngresoInpe > 0 Then

                If expedienteManual = True Then

                    If validarExpediente() = False Then
                        Return value
                    End If

                Else
                    ''****J.E.U 27032023*******************
                    Dim mensajeOut As String = ""
                    Dim objEnt As New Entity.Registro.ConstanciaReclusion.Tramite
                    objEnt.idInterno = Me.idInterno
                    objEnt.fechaRecepcionEP = Me.fechaRecepcionEP
                    objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                    If objBss.validarFechaMovimientoEgreso(objEnt, mensajeOut) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeOut, tituloMensaje)
                        value = False
                        Return value
                    End If
                    ''***********************

                    Dim cantidadExpe As Integer = 0
                    objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                    cantidadExpe = objBss.fnCantidadExpedientes(Me.idInterno, Me.idIngresoInpe)

                    If cantidadExpe > 0 Then

                        objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                        If objBss.validarExpedienteDmpSmp(Me.idInterno, Me.idIngresoInpe, Me.idIngreso, mensaje) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
                            Return False
                        End If

                    Else
                        If Me.codigo > 0 Then
                            expedienteManual = True
                            habilitarExpediente(True, False)
                            Return True
                        End If
                        mensaje = "Interno(a) no cuenta con procesos registrados." + Chr(13) +
                            "¿Desea registrar la solicitud y agregar los datos del proceso por el cual se encuentra recluido?"

                        If Legolas.Configuration.Aplication.MessageBox.Question(mensaje, tituloMensaje) <> DialogResult.Yes Then
                            Return False
                        End If

                        expedienteManual = True
                        habilitarExpediente(True, False)
                        Me.UscComboDistritoJudicial2.Focus()

                        Return False
                    End If
                End If
            Else

                'validar dmp o smp en provincias
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                If objBss.validarExpedienteDmpSmp(Me.idInterno, Me.idIngresoInpe, Me.idIngreso, mensaje) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
                    Return False
                End If
                'Validar con interno en egreso
                Dim mensajeOut As String = ""
                Dim objEnt As New Entity.Registro.ConstanciaReclusion.Tramite
                objEnt.idInterno = Me.idInterno
                objEnt.fechaRecepcionEP = Me.fechaRecepcionEP
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                If objBss.validarFechaMovimientoEgreso(objEnt, mensajeOut) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeOut, tituloMensaje)
                    value = False
                    Return value
                End If
            End If

            Return True
        End Function
        Private Function validarExpediente() As Boolean

            Dim value As Boolean = False

            If Me.resultIdDistritoJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione distrito Judicial", tituloMensaje)
                Me.UscComboDistritoJudicial2.Focus()
                Return value
            End If

            If Me.resultIdSalaJuzgado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione autoridad judicial", tituloMensaje)
                Me.UscComboSala2.Focus()
                Return value
            End If

            If Me.resultExpediente.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese numero de expediente", tituloMensaje)
                Me.txtNumExp.Focus()
                Return value
            End If

            If Me.resultSecretario.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese secretario", tituloMensaje)
                Me.txtExpSecretario.Focus()
                Return value
            End If

            If Me.resultDelitos.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese delitos del expediente", tituloMensaje)
                Me.btnAddDelito.Focus()
                Return value
            End If

            Return True

        End Function
        Private Function validarEmisionCR() As Boolean

            Dim value As Boolean = False

            If Me.codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Antes de expedir el registro, debe grabar el registro.",
                                                                        tituloMensaje)
                Return False
            End If

            If Me.idEstado <> Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede Expedir si está en estado [PENDIENTE]",
                                                                        tituloMensaje)
                Return False
            End If

            Return True

        End Function
#End Region
#Region "acciones"
        Private Sub eliminar()

            If Me.codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Debe grabar el registro para proceder a realizar la operación",
                                                                        tituloMensaje)
                Exit Sub
            End If

            If Me.idEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                    objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                    Dim value As Integer = -1
                    value = objBss.Eliminar(Me.codigo)

                    If value > 0 Then
                        _getActualizoDatos = True
                        Me.Close()
                    End If
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede eliminar si el registro se encuentra en estado [PENDIENTE]",
                        tituloMensaje)
            End If

        End Sub
        Private Sub grabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim strMensajeGrabar As String = ""
            strMensajeGrabar = "Desea guardar los cambios?"

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) <> DialogResult.Yes Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim objEnt As New Entity.Registro.ConstanciaReclusion.Tramite
            With objEnt
                .codigo = Me.codigo
                .idRegion = Me.idRegion
                .idPenal = Me.idPenal
                .codigo = Me.codigo
                .idInterno = Me.idInterno
                .idIngreso = Me.idIngreso
                .idIngresoInpe = Me.idIngresoInpe
                .numeroTramite = Me.numeroTramite
                .numeroCR = Me.numeroCR
                .idTipoSolicitante = Me.idTipoSolicitante
                .idDistritoJudicial = Me.idDistritoJudicial
                .idAutoridadJudicial = Me.idSalaJuzgado
                .documentoReferenciaTipo = Me.idTipoDocumentoRef
                .serieRecibo = Me.serieRecibo
                .documentoReferenciaNumero = Me.numeroReferencia
                .documentoReferenciaFecha = Me.fechaDocumentoReferencia
                .fechaRecepcionEP = Me.fechaRecepcionEP
                .fechaRecepcionRP = Me.fechaRecepcionRP
                .tipoTramite = Me.tipoTramite
                .estado = Me.idEstado
                .observacion = Me.observacion
            End With
            'agregar al entity, los datos ingresados manualemnte por el usuario
            If expedienteManual = True Then
                With objEnt
                    .idDistritoJudicialResp = Me.resultIdDistritoJudicial
                    .idSalaJudicialResp = Me.resultIdSalaJuzgado
                    .expedienteNumeroResp = Me.resultExpediente
                    .expedienteSecretarioResp = Me.resultSecretario
                    .expedienteDelitoResp = Me.resultDelitos
                End With
            End If

            Dim mensaje As String = ""
            objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
            Me.codigo = objBss.grabar(objEnt, expedienteManual, mensaje)

            If Me.codigo > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                _getActualizoDatos = True
                expedienteManual = False
                listar()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
            End If

            Me.Cursor = Cursors.Default

        End Sub
        Private Sub anular()

            If Me.codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Grabe el registro antes de efectuar la operación", tituloMensaje)
                Exit Sub
            End If

            If Me.idEstado <> Type.Enumeracion.ConstanciaReclusion.enmEstado.atendido Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede anular el registro de tramite, cuando se encuentra en estado [ATENDIDO]",
                                                                        tituloMensaje)
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea anular el registro seleccionado", tituloMensaje) <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim agregoDatos As Boolean = False
            Dim obsAnulacion As String = ""
            Dim frm As New Registro.ConstanciaReclusion.frmObsPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    obsAnulacion = ._ObsAnulacion
                    agregoDatos = True
                End If
            End With

            If agregoDatos = True Then
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                Dim value As Integer = -1

                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                value = objBss.grabarAnular(Me.codigo, obsAnulacion)

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    listar()
                    _getActualizoDatos = True
                End If

            End If

        End Sub
        Private Sub emitirCR()

            If validarEmisionCR() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("Desea Expedir la Constancia de Reclusión") = DialogResult.Yes Then
                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite

                Dim value As Integer = -1
                Dim mensaje As String = ""

                objBss = New Bussines.Registro.ConstanciaReclusion.Tramite
                value = objBss.grabarExpedirConstancia(Me.codigo, Me.idInterno, Me.idIngresoInpe, Me.idIngreso, Me.idRegion, Me.idPenal, mensaje)

                If value > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me._getActualizoDatos = True
                    listar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(mensaje, tituloMensaje)
                End If

            End If

        End Sub
#End Region
#Region "Formulario"
        Private Sub frmDelitoAgregar()

            Dim nuevoDelito As String = ""
            Dim frm As New Mantenimiento.Busqueda.frmDelitoPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    nuevoDelito = .GrillaDelitoEspecificoNombre
                End If
            End With

            If resultDelitos.Length < 1 Or resultDelitos = "[SELECCIONE]" Then
                Me.resultDelitos = nuevoDelito
            Else

                Me.resultDelitos = Me.resultDelitos + ", " + nuevoDelito
            End If

        End Sub
        Private Sub frmVerSalaJuzgado()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.idDistritoJudicial
                If .ShowDialog = DialogResult.OK Then
                    idDistritoJudicial = ._DistritoJudicialID
                    idSalaJuzgado = ._GrillaSalaID
                End If
            End With

        End Sub
        Private Sub frmVerSalaJuzgadoResult()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.resultIdDistritoJudicial
                If .ShowDialog = DialogResult.OK Then
                    resultIdDistritoJudicial = ._DistritoJudicialID
                    resultIdSalaJuzgado = ._SalaJudicialID
                End If
            End With

        End Sub
        Private Sub frmContanciaRecluImpresion()

            Dim filtro As New Entity.Registro.ConstanciaReclusion.ReporteFiltro
            With filtro
                .idTramiteCR = Me.codigo
                .estadoTramite = Me.idEstado
                .idRegion = Me.idRegion
                .idPenal = Me.idPenal
            End With

            Dim frm As New APPReporte.Registro.ConstanciaReclusion.ReporteCrystal(Configuracion.Licencia.Codigo,
                                                                                  Type.Enumeracion.ConstanciaReclusion.enmReporte.constanciaReclusion,
                                                                                  filtro)
            With frm
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub validarControles()

            Select Case Me.formLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    If Me.penalTipoLicencia <> Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        Me.pnlVerInterno.Visible = False
                    End If

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    If Me.penalTipoLicencia <> Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        Me.pnlVerInterno.Visible = False
                    Else
                        Me.pnlVerInterno.Visible = (Me._verDetalleInterno And Me.codigo > 0)
                    End If

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia

                    If Me.penalTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia Or
                        Me.penalTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia Then

                        Me.pnlVerInterno.Visible = (Me._verDetalleInterno And Me.codigo > 0)
                    Else
                        Me.pnlVerInterno.Visible = False
                    End If

            End Select

            If Me.obsAnulacion.Length > 0 Then
                Me.grbAnulacion.Visible = True
            End If

            Dim habilitarExpediente As Boolean = True
            Dim habilitarEliminar As Boolean = True
            Dim habilitarExpedir As Boolean = True
            Dim habilitarGrabar As Boolean = True
            Dim habilitarDocReferencia As Boolean = True

            Select Case Me.idEstado
                Case Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente
                    habilitarExpediente = False
                Case Type.Enumeracion.ConstanciaReclusion.enmEstado.anulado
                    habilitarExpediente = False
                    habilitarEliminar = False
                    habilitarExpedir = False
                    habilitarGrabar = False

                Case Type.Enumeracion.ConstanciaReclusion.enmEstado.atendido
                    habilitarExpedir = False
                    habilitarEliminar = False
                    habilitarGrabar = False
                    habilitarDocReferencia = False
            End Select

            Me.btnAnular.Enabled = habilitarExpediente
            Me.btnExpedir.Enabled = habilitarExpedir
            Me.btnEliminar.Enabled = habilitarEliminar
            Me.btnAceptar.Enabled = habilitarGrabar
            Me.btnImpresion.Enabled = True

            Me.txtSerRecibo.Enabled = habilitarDocReferencia
            Me.txtNumDocRef.Enabled = habilitarDocReferencia
            Me.dtpFechaRef.Enabled = habilitarDocReferencia
            Me.dtpFechaRecepEP.Enabled = habilitarDocReferencia
            Me.dtpFechaRecepRP.Enabled = habilitarDocReferencia
            'Me.txtobs.Enabled = habilitarDocReferencia
            If Me.idEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.atendido Then
                Me.txtobs.ReadOnly = Not habilitarDocReferencia
                Me.txtobs.BackColor = System.Drawing.SystemColors.Control
            End If
        End Sub
        Private Sub permisos()

            Select Case Me.formLicencia
                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    Me._FormEscritura = False
                    Me._FormEliminar = False
            End Select

            Me.pnlModificar.Visible = Me._FormEscritura
            Me.btnAceptar.Visible = Me._FormEscritura

            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlImprimir.Visible = Me._FormReporte

            Me.pnlVerInterno.Visible = (Me._verDetalleInterno And Me.codigo > 0)

        End Sub
        Private Function fnTipoTramiteNombre(tipoTramite As Short) As String

            Dim value As String = ""

            If tipoTramite = 1 Then
                value = "CON COSTO"
            Else
                value = "SIN COSTO"
            End If

            Return value

        End Function
        Private Sub habilitarExpediente(habilitar As Boolean, limpiarDatos As Boolean)

            Me.UscComboDistritoJudicial2.Enabled = habilitar
            Me.UscComboDistritoJudicial2._ComboConfiguracion()
            Me.UscComboSala2.Enabled = habilitar
            Me.UscComboSala2._ComboConfiguracion()

            Me.txtNumExp.ReadOnly = Not habilitar
            Me.txtExpSecretario.ReadOnly = Not habilitar

            If Not habilitar = False Then

                Me.txtNumExp.BackColor = Color.White
                Me.txtExpSecretario.BackColor = Color.White
                Me.txtDelitoNombre.BackColor = Color.White

            Else
                If Me.penalTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana And Me.idEstado = Type.Enumeracion.ConstanciaReclusion.enmEstado.atendido Then
                    Me.txtNumExp.BackColor = System.Drawing.SystemColors.Control
                    Me.txtExpSecretario.BackColor = System.Drawing.SystemColors.Control
                    Me.txtDelitoNombre.BackColor = System.Drawing.SystemColors.Control
                End If
            End If
            If habilitar = True Then
                Me.UscComboDistritoJudicial2.BackColor = Color.White
                Me.UscComboSala2.BackColor = Color.White
            End If

            Me.pnlBotonesDelitos.Visible = habilitar

            If limpiarDatos = True Then
                Me.resultExpediente = ""
                Me.resultSecretario = ""
                Me.resultDelitos = ""
            End If

        End Sub
        Private Sub camposObligatorios()

            ErrorProvider1.SetError(cbbTipSolicitante, "Obligatorio")
            ErrorProvider1.SetError(UscComboDistritoJudicial1, "Obligatorio")
            ErrorProvider1.SetError(UscComboSala1, "Obligatorio")
            ErrorProvider1.SetError(cbbTipoDocumentoRef, "Obligatorio")
            ErrorProvider1.SetError(Panel4, "Obligatorio")
            ErrorProvider1.SetError(dtpFechaRef, "Obligatorio")
            ErrorProvider1.SetError(dtpFechaRecepEP, "Obligatorio")
            ErrorProvider1.SetError(dtpFechaRecepRP, "Obligatorio")

        End Sub
        Private Sub valoresDefault()

            Me.UscComboSala2.Enabled = False
            Me.resultDelitos = ""
            Me.UscComboDistritoJudicial2.Enabled = False
            camposObligatorios()
            Me.tipoTramiteNombre = fnTipoTramiteNombre(Me.tipoTramite)

            Me.btnAnular.Enabled = False
            Me.btnExpedir.Enabled = False
            Me.btnEliminar.Enabled = False
            Me.btnImpresion.Enabled = False
            Me.pnlBotonesDelitos.Visible = False

        End Sub
        Private Sub mostrarDatosSolicitante()

            comboTipoDocumentoRef()

            Dim verAutoridadJudicial As Boolean = False
            Dim verSerie As Boolean = False
            Dim texto As String = "Numero Doc.: "
            Dim textoFecha As String = "Fecha de Doc.: "
            Dim formAlto As Short = 620

            Me.tipoTramite = 0 'sin costo

            Select Case Me.idTipoSolicitante
                Case Type.Enumeracion.enmTipoAutoridadJudicial.propioInterno
                    tipoTramite = 1 'con costo
                    verSerie = True

                    texto = "N° Serie-Recibo: "
                    textoFecha = "Fecha de pago: "

                Case Type.Enumeracion.enmTipoAutoridadJudicial.poderJudicial
                    ComboDistritoJudicial()
                    ComboAutoridadJudicial()
                    verAutoridadJudicial = True
                    formAlto = 690
            End Select

            Me.gbPoderJudicial.Visible = verAutoridadJudicial
            Me.pnlSerie.Visible = verSerie

            Me.serieRecibo = ""
            Me.numeroRecibo = ""

            Me.lblNumero.Text = texto
            Me.lblFecha.Text = textoFecha

            Me.tipoTramiteNombre = Me.fnTipoTramiteNombre(Me.tipoTramite)

            If Me.Height <> formAlto Then
                Me.Size = New Size(Me.Width, formAlto)
                Me.Refresh()
            End If

        End Sub
#End Region

        Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles Me.Load

            comboSolicitante()
            comboTipoDocumentoRef()
            ComboResulDistritoJudicial()

        End Sub

        Private Sub frmRegistro_Shown(sender As Object, e As EventArgs) Handles Me.Shown

            Me.gbPoderJudicial.Visible = False
            Me.grbAnulacion.Visible = False

            valoresDefault()
            permisos()
            listar()

        End Sub
        Private Sub cbbTipSolicitante__SelectedIndexChanged() Handles cbbTipSolicitante._SelectedIndexChanged

            If cargoComboSolicitante = True Then
                mostrarDatosSolicitante()
            End If

        End Sub
        Private Sub UscComboDistritoJudicial1__SelectedIndexChanged() Handles UscComboDistritoJudicial1._SelectedIndexChanged

            If Me.cargoComboDistritoJudicial = True Then
                ComboAutoridadJudicial()
            End If

        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

            grabar()

        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnExpedir_Click(sender As Object, e As EventArgs) Handles btnExpedir.Click

            emitirCR()

        End Sub
        Private Sub txtSerRecibo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSerRecibo.LostFocus

            If Me.idTipoSolicitante = Type.Enumeracion.enmTipoAutoridadJudicial.propioInterno And Me.serieRecibo.Trim.Length > 0 Then
                Me.serieRecibo = serieRecibo.PadLeft(3, "0").ToString
            End If

        End Sub

        Private Sub txtNumRecibo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumDocRef.LostFocus

            If Me.idTipoSolicitante = Type.Enumeracion.enmTipoAutoridadJudicial.propioInterno And Me.numeroRecibo.Length > 0 Then
                Me.numeroRecibo = numeroRecibo.PadLeft(6, "0")
            End If

        End Sub

        Private Sub btnImpresion_Click(sender As Object, e As EventArgs) Handles btnImpresion.Click

            If Me.codigo > 0 Then
                frmContanciaRecluImpresion()
                _getActualizoDatos = True
            Else
                Legolas.Configuration.Aplication.MessageBox.Information("Debe grabar el registro de tramite para visualizar la impresión.", tituloMensaje)
            End If

        End Sub

        Private Sub cbbTipoDocumentoRef_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTipoDocumentoRef.SelectedIndexChanged

            If cargoComboTipoDocumento = True Then
                Me.serieRecibo = ""
                Me.numeroReferencia = ""

                If Me.idTipoDocumentoRef = Type.Enumeracion.ConstanciaReclusion.enmTipoDocumento.solicitud Then
                    Me.txtNumDocRef.MaxLength = 20
                    Me.txtNumDocRef.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Else
                    Me.txtNumDocRef.MaxLength = 50
                    Me.txtNumDocRef.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal
                End If

            End If

        End Sub

        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar

            frmVerSalaJuzgado()

        End Sub

        Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click

            anular()

        End Sub

        Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

            eliminar()

        End Sub

        Private Sub btnDetalleInterno_Click(sender As Object, e As EventArgs) Handles btnDetalleInterno.Click

            _getIdInternoVerDetalle = Me.idInterno
            _getIdPenal = Me.idPenal

            Me.DialogResult = DialogResult.OK

        End Sub

        Private Sub UscComboDistritoJudicial2__SelectedIndexChanged() Handles UscComboDistritoJudicial2._SelectedIndexChanged

            If cargoComboDistritoJudExpe = True Then
                ComboResultSalaJudicial()
            End If

        End Sub

        Private Sub btnAddDelito_Click(sender As Object, e As EventArgs) Handles btnAddDelito.Click

            frmDelitoAgregar()

        End Sub

        Private Sub btnEliminarDelito_Click(sender As Object, e As EventArgs) Handles btnEliminarDelito.Click

            Me.resultDelitos = ""

        End Sub

        Private Sub cbbTipSolicitante_Load(sender As Object, e As EventArgs) Handles cbbTipSolicitante.Load

        End Sub

        Private Sub UscComboSala2__Click_Buscar() Handles UscComboSala2._Click_Buscar

            frmVerSalaJuzgadoResult()

        End Sub

    End Class
End Namespace
