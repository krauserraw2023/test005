Imports APPControls.Registro.Sentencia

Namespace Registro.Sentencias
    Public Class frmResolSentenciaMultiple
#Region "Propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
        Public Property _CodigoInterno() As String
            Get
                Return lblCodInterno.Text
            End Get
            Set(value As String)
                lblCodInterno.Text = value
            End Set
        End Property

        Public Property _NombresInterno() As String
            Get
                Return lblInterno.Text
            End Get
            Set(value As String)
                lblInterno.Text = value
            End Set
        End Property
        Public Property _TipoResolucion() As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Public IdEstablecimientomental As Integer = -1
#End Region
#Region "Accion"

        Private Function Agrabar_() As Integer

            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim EntDocJud As New Entity.Registro.DocumentoJudicial

            With UscDetallResolucionEjecutoria1
                EntDocJud.SentenciaTotalAnios = If(._TotalAnhos.Length = 0, "0", ._TotalAnhos)
                EntDocJud.SentenciaTotalMeses = If(._TotalMes.Length = 0, "0", ._TotalMes)
                EntDocJud.SentenciaTotalDias = If(._TotalDias.Length = 0, "0", ._TotalDias)
                EntDocJud.SentenciaCadenaPerpetua = ._getCadenaperpetua
                EntDocJud.MovimientoMotivoId = UscDetallResolucionEjecutoria1.objEntExpedienteTempoCol.Item(0).MotivoIngresoID
            End With

            EntDocJud = usrResolSentencia.AGrabar(EntDocJud)
            If EntDocJud.Codigo > 0 Then

                UscDetallResolucionEjecutoria1._Grabar(EntDocJud.Codigo, _blnNuevoRegistro, EntDocJud)
            End If
            Return EntDocJud.Codigo
        End Function
#End Region
#Region "Forms"
        Private Sub FRM_Grilla()
            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                ._SituacionJuridicaExpe = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                .objEntExpedienteTempoColCopi2 = UscDetallResolucionEjecutoria1.objEntExpedienteTempoCol
                ._TipoResolucion = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscDetallResolucionEjecutoria1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                        If .objEntExpedienteTempoCol.Item(0).MotivoIngresoID = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoExpediente.Inimputable Then

                            usrResolSentencia.ActivarControlesInimputables()
                            usrResolSentencia.EstablecimientomentalId = .objEntExpedienteTempoCol.Item(0).EstablecimientomentalId
                            usrResolSentencia.blnCadenaPerpetua = .objEntExpedienteTempoCol.Item(0).SentenciaCadenaPerpetua

                            'UscDetallResolucionEjecutoria1._TotalAnhos = .objEntExpedienteTempoCol.Item(0).SentenciaAnio
                            'UscDetallResolucionEjecutoria1._TotalMes = .objEntExpedienteTempoCol.Item(0).SentenciaMes
                            'UscDetallResolucionEjecutoria1._TotalDias = .objEntExpedienteTempoCol.Item(0).SentenciaDia
                            UscDetallResolucionEjecutoria1._blnCadenaPerpetua = .objEntExpedienteTempoCol.Item(0).SentenciaCadenaPerpetua
                            UscDetallResolucionEjecutoria1._listarGrillaPeriodoCondenaNuevo(.objEntExpedienteTempoCol.Item(0).SentenciaFechaInicio, .objEntExpedienteTempoCol.Item(0).SentenciaFechaFinal)
                        End If
                    End If
                End If
            End With
            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                With frm2
                    ._objEntExpedienteCol = UscDetallResolucionEjecutoria1.objEntExpedienteTempoCol
                    ._TipoDocumento = Me._TipoResolucion
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoID
                        ._objEntExpediente.Nuevo = True
                        Me.UscDetallResolucionEjecutoria1._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_MantPeriodoSentencia(ByVal Nuevo As Boolean, objEntPeriodoSentencia As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Dim frm As New Sentencias.frmPeriodoCondenaSentencia
            With frm
                ._EntPeriodoCondena = objEntPeriodoSentencia
                ._RegionId = Me._RegionID
                ._PenalId = Me._PenalID
                ._TemporalNuevo = Nuevo
                ._objEntExpedienteTempoCol = UscDetallResolucionEjecutoria1.objEntExpedienteTempoCol
                ._Titulo = UscDetallResolucionEjecutoria1._TituloPeriodocondena
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscDetallResolucionEjecutoria1._Temporal_GrabarPeriodoNuevaCondena(._EntPeriodoCondena)
                End If
            End With
        End Sub
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                End If
                ._objEntExpediente = objEnt
                ._TipoDocumento = Me._TipoResolucion
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscDetallResolucionEjecutoria1._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
                End If
            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._InternoIngresoID
                    ._ExpedienteID = UscDetallResolucionEjecutoria1._GrillaExpedienteID
                    ._ExpedienteItem = UscDetallResolucionEjecutoria1._GrillaItemExpediente 'HNRB puede ser reemplazado por objEntExpediente._ExpedienteItem

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato                    
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscDetallResolucionEjecutoria1._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelitoCol
                .UscComboDelito1._objEntDelitoCol = objEntDelitoCol
                ._DelitoItem = UscDetallResolucionEjecutoria1._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscDetallResolucionEjecutoria1._GrillaItemExpediente 'HNRB puede ser reeamplazado por objEntExpediente.ExpedienteItem
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscDetallResolucionEjecutoria1._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol)
                End If
                If .EliminarFila = True Then
                    Dim ana As Integer = .AgraviadoItemCopia
                End If

            End With
        End Sub

        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    usrResolSentencia.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
        Private Sub TituloSentencia()

            Dim strTitulo As String = ""

            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                    strTitulo = "Aclaratoria de Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Adecuacion_Pena
                    strTitulo = "Adecuacion de Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
                    strTitulo = "Commutacion de Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    strTitulo = "Sustitucion de Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida
                    strTitulo = "Sentencia Consentida"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Resolucion_Superior
                    strTitulo = "Superior"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa
                    strTitulo = "Sentencia Pena Limitativa"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior
                    strTitulo = "Ejecutoria Superior"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema
                    strTitulo = "Ejecutoria Suprema"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia
                    strTitulo = "Integracion de Sentencia"
            End Select

            Me.lblTitulo.Text = "RESOLUCION:" & strTitulo.ToUpper
            Me.Text = strTitulo

        End Sub
        Private Sub ValoresxDefault()

            With usrResolSentencia
                ._InternoID = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._Codigo = Me._Codigo
                .DocumentoTipo = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
                TituloSentencia()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With

            With UscDetallResolucionEjecutoria1
                ._DocumentoJudicialID = Me._Codigo
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoResolucion = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._ListarExpediente(usrResolSentencia.objEnt, True, True)
                '._actualizarDatosInimputable(Me.usrResolSentencia._esInimputable)

                If UscDetallResolucionEjecutoria1._getIdTipoInimputable > 0 Then
                    usrResolSentencia.ActivarControlesInimputables()
                End If
                If Me._Codigo > 0 Then
                    usrResolSentencia.ActivarControlCkbExtramuro(.objEntAgraviadoTempoCol)
                    usrResolSentencia.ListarControlExtramuro(._Extramuro)
                End If
            End With

            If Me._Codigo < 1 Then
                Me.Refresh()
            End If

        End Sub
#End Region

        Private Sub usrDetalleRegSent__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionEjecutoria1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub usrDetalleRegSent__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionEjecutoria1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub
        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Agregar() Handles UscDetallResolucionEjecutoria1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub
        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscDetallResolucionEjecutoria1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscDetallResolucionEjecutoria1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Expediente_Agregar() Handles UscDetallResolucionEjecutoria1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolAclaratoriaSent_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If usrResolSentencia.Validar = True Then
                If UscDetallResolucionEjecutoria1.Validar = True Then

                    Dim strMensaje As String = UscDetallResolucionEjecutoria1.ValidarPeriodoCondena
                    If strMensaje.Trim.Length > 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Exit Sub
                    End If

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar() = DialogResult.Yes Then
                        If Agrabar_() > -1 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub usrResolSentencia__ChecekHabilitarAgregarCondena(valor As System.Boolean)

            If usrResolSentencia._OrdenActivacion = False Then
                If valor = True Then

                    If Me._Codigo > 0 Then
                        If UscDetallResolucionEjecutoria1.ValidarExpedienteReferenciado(6) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                            usrResolSentencia.blnResultado = False
                            Exit Sub
                        End If

                    End If

                    If UscDetallResolucionEjecutoria1.GrillaNroRegistroPeriodocondena = 0 And
                       UscDetallResolucionEjecutoria1._TotalAnhos = 0 And
                       UscDetallResolucionEjecutoria1._TotalMes = 0 And
                       UscDetallResolucionEjecutoria1._TotalDias = 0 Then
                        '----
                        UscDetallResolucionEjecutoria1.btnAgregarPerido = Not (valor)
                        UscDetallResolucionEjecutoria1.btnCajasPeriodo = valor
                        'UscDetallResolucionEjecutoria1.EliminarPeriodo()
                        UscDetallResolucionEjecutoria1._blnCadenaPerpetua = valor
                        If valor = True Then
                            usrResolSentencia.blnResultado = True
                        Else
                            usrResolSentencia.blnResultado = False
                        End If
                    Else
                        Dim strMensaje = "Al activar esta opción." + Chr(13) +
                             "No podra registrar el tiempo y los periodos de condena." + Chr(13) +
                             "Asimismo se eliminaran los datos ingresados. Desea continuar."

                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                            UscDetallResolucionEjecutoria1.btnAgregarPerido = Not (valor)
                            UscDetallResolucionEjecutoria1.btnCajasPeriodo = valor

                            UscDetallResolucionEjecutoria1.EliminarPeriodo()
                            usrResolSentencia.blnResultado = True
                            UscDetallResolucionEjecutoria1._blnCadenaPerpetua = valor
                        Else
                            usrResolSentencia.blnResultado = False

                            UscDetallResolucionEjecutoria1._blnCadenaPerpetua = Not (valor)
                        End If
                    End If
                Else
                    UscDetallResolucionEjecutoria1.btnAgregarPerido = Not (valor)
                    UscDetallResolucionEjecutoria1.btnCajasPeriodo = valor

                    UscDetallResolucionEjecutoria1.EliminarPeriodo()
                    usrResolSentencia.blnResultado = False
                    UscDetallResolucionEjecutoria1._blnCadenaPerpetua = valor
                End If

            Else
                usrResolSentencia.blnResultado = False

                UscDetallResolucionEjecutoria1.btnAgregarPerido = Not (valor)
                UscDetallResolucionEjecutoria1.btnCajasPeriodo = valor

                'UscDetallResolucionEjecutoria1.EliminarPeriodo()
                UscDetallResolucionEjecutoria1._blnCadenaPerpetua = valor
                usrResolSentencia._OrdenActivacion = False
            End If
        End Sub

        Private Sub usrResolSentencia__Click_VerFormulario() Handles usrResolSentencia._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = usrResolSentencia.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    usrResolSentencia.DistritoJudicial = ._DistritoJudicialID
                    usrResolSentencia.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Expediente_Agregar()
            FRM_Grilla()
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_PeriodoCondena_Agregar()
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__click_VerResoluciones(Tipo As String) Handles UscDetallResolucionEjecutoria1._click_VerResoluciones
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            frm._ResolucionTipoID = Me.UscDetallResolucionEjecutoria1.GrillaResolucionID
            frm._TipoResolucion = IIf(Tipo = "EXP", Me._TipoResolucion, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If Tipo = "EXP" Then
                    UscDetallResolucionEjecutoria1.ActualizarResolucion(frm._ResolucionTipoID, frm._ResolucionTipoNom)
                Else
                    UscDetallResolucionEjecutoria1.ActualizarTipoSentencia(frm._ResolucionTipoID, frm._ResolucionTipoNom)
                    usrResolSentencia.ActivarControlCkbExtramuro(UscDetallResolucionEjecutoria1.objEntAgraviadoTempoColGrilla)
                End If
            End If
        End Sub

        Private Sub usrResolSentencia__Click_VerInimputables(blnValor As Boolean) Handles usrResolSentencia._Click_esInimputables
            UscDetallResolucionEjecutoria1._actualizarDatosInimputable(blnValor)
        End Sub

        Private Sub usrResolSentencia__Click_FrmBusquedaAutoridadJudicial() Handles usrResolSentencia._Click_FrmBusquedaAutoridadJudicial

            FRM_BusquedaAutoridadJudicial()

        End Sub

        Private Sub UscDetallResolucionEjecutoria1__click_ActivarContolExtramuro() Handles UscDetallResolucionEjecutoria1._click_ActivarContolExtramuro
            usrResolSentencia.ActivarControlCkbExtramuro(UscDetallResolucionEjecutoria1.objEntAgraviadoTempoColGrilla)
        End Sub

    End Class
End Namespace