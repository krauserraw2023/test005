Imports APPControls.Registro.Sentencia
Imports APPControls.Registro.Sentencias

Namespace Registro.Sentencias
    Public Class frmResolSentenciaNueva
#Region "Propiedades"
        Private bssExp As Bussines.Registro.Expediente = Nothing
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoID() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
        Private objBssExpedientePad As Bussines.Registro.InternoExpedientePadre
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
        Public _TipoResolucion As Integer = -1
#End Region
#Region "Accion"
        Private Function AGrabar() As Integer

            Dim expColTmp As New Entity.Registro.ExpedienteCol
            Dim EntDocJud As New Entity.Registro.DocumentoJudicial
            With UscDetallRegistroSentenciaGrilla1
                EntDocJud.SentenciaCadenaPerpetua = ._CadenaPerpetua
                EntDocJud.SentenciaTotalAnios = If(._TotalAnhos.Length = 0, "0", ._TotalAnhos)
                EntDocJud.SentenciaTotalMeses = If(._TotalMes.Length = 0, "0", ._TotalMes)
                EntDocJud.SentenciaTotalDias = If(._TotalDias.Length = 0, "0", ._TotalDias)
            End With

            EntDocJud = UsrResolSentenciaV21.AGrabar(EntDocJud, _blnNuevoRegistro)

            If EntDocJud.Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se pudo realizar el proceso de registro.")
                Return EntDocJud.Codigo
            End If
            'Grabar periodo de sentencia 
            UscDetallRegistroSentenciaGrilla1._Grabar(_blnNuevoRegistro, EntDocJud)

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
                ._SituacionJuridicaExpe = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida
                '.objEntExpedienteTempoColCopi2 = usrDetalleRegSent.objEntExpedienteTempoCol
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    'If blnNuevoExpediente = False Then
                    If .objEntExpedienteTempoCol.Count = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con Sentencias no Consentidas.")
                        Exit Sub
                    End If

                    Me.UscDetallRegistroSentenciaGrilla1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)

                    Dim idMotivoIngreso As Short = .objEntExpedienteTempoCol.Item(0).MotivoIngresoID
                    'uscResolSentencia.ActivarControlCkbExtramuro(.objEntAgraviadoTempoCol)
                    If idMotivoIngreso = Type.Enumeracion.Movimiento.EnumMovMotivo.Inimputable Or
                            idMotivoIngreso = Type.Enumeracion.Movimiento.EnumMovMotivo.PosibleInimputable Then

                        '    uscResolSentencia.ActivarControlesInimputables()
                        '    uscResolSentencia.EstablecimientomentalId = .objEntExpedienteTempoCol.Item(0).EstablecimientomentalId
                        '    uscResolSentencia.blnCadenaPerpetua = .objEntExpedienteTempoCol.Item(0).SentenciaCadenaPerpetua

                        '    usrDetalleRegSent._blnCadenaPerpetua = .objEntExpedienteTempoCol.Item(0).SentenciaCadenaPerpetua
                        '    usrDetalleRegSent.Listar_PeriodoCondena(.objEntExpedienteTempoCol.Item(0).SentenciaFechaInicio, .objEntExpedienteTempoCol.Item(0).SentenciaFechaFinal)

                        '    'actualizar el tipo inimputable de la sentencia
                        '    With usrDetalleRegSent
                        '        ._actualizarDatosInimputablesDesdeSentencia(._getIdCentroSaludMental)
                        '    End With
                    Else
                        UscDetallRegistroSentenciaGrilla1._actualizarDatosInimputable(Me.UsrResolSentenciaV21._esInimputable)
                    End If

                End If
            End With
        End Sub
        Private Sub FRM_MantPeriodoSentencia(ByVal Nuevo As Boolean, objEntPeriodoSentencia As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Dim frm As New Sentencias.frmPeriodoCondenaSentencia
            With frm
                ._EntPeriodoCondena = objEntPeriodoSentencia
                ._RegionId = Me._RegionID
                ._PenalId = Me._PenalID
                ._TemporalNuevo = Nuevo
                '._objEntExpedienteTempoCol = usrDetalleRegSent.objEntExpedienteTempoCol
                '._Titulo = usrDetalleRegSent._TituloPeriodoCondena
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'usrDetalleRegSent._Temporal_GrabarPeriodoCondena(._EntPeriodoCondena)
                End If
            End With
        End Sub
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)

            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._TemporalNuevo = True 'temporal nuevo
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    objEnt.Nuevo = True
                End If
                ._objEntExpediente = objEnt
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    'Me.usrDetalleRegSent._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
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
                    '._ExpedienteID = usrDetalleRegSent._GrillaExpedienteID
                    '._ExpedienteItem = usrDetalleRegSent._GrillaItemExpediente 'HNRB puede ser reemplazado por objEntExpediente._ExpedienteItem
                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    .ResolucionNuevo = False
                    'objEnt_.DelitoItem = Me.usrDetalleRegSent._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelitoCol
                .UscComboDelito1._objEntDelitoCol = objEntDelitoCol
                '._DelitoItem = usrDetalleRegSent._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    'Me.usrDetalleRegSent._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol)

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
                    'uscResolSentencia.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            With UsrResolSentenciaV21
                ._InternoID = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            'With UsrResolSentenciaDetalle1
            '    ._LoadUsc()
            'End With
            With UscDetallRegistroSentenciaGrilla1
                ._DocumentoJudicialID = Me._Codigo
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._ListarExpediente(UsrResolSentenciaV21.objEnt, 17, True, True)
                '    .CargarCadenaPerpetua(uscResolSentencia.SentenciaCadenaPerpetua)

                '    If usrDetalleRegSent._getIdTipoInimputable > 0 Then
                '        uscResolSentencia.ActivarControlesInimputables()
                '    End If
                '    Select Case Me.uscResolSentencia.DocumentoTipo
                '        Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa,
                '             Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia
                '            uscResolSentencia.ListarControlExtramuro(._Extramuro)
                '    End Select
                '    Me.uscResolSentencia.ActivarControlCkbExtramuro(.objEntAgraviadoTempoColGrilla)
                '    'If Me._Codigo > 0 Then
                '    '    uscResolSentencia.ActivarControlCkbExtramuro(.objEntAgraviadoTempoColGrilla)
                '    '    uscResolSentencia.ListarControlExtramuro(._Extramuro)
                '    'End If
            End With

        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Agregar()
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub
        Private Sub usrDetalleRegSent__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolSentencia_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If UsrResolSentenciaV21.Validar = True Then
                If UscDetallRegistroSentenciaGrilla1.Validar = True Then
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("") = DialogResult.Yes Then
                        If AGrabar() > 0 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub uscResolSentencia__ChecekHabilitarAgregarCondena(valor As Boolean)

            'If uscResolSentencia._OrdenActivacion = False Then
            '    If valor = True Then

            '        If Me._Codigo > 0 Then
            '            If usrDetalleRegSent.ValidarExpedienteReferenciado(6) = False Then
            '                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
            '                uscResolSentencia.blnResultado = False
            '                Exit Sub
            '            End If
            '        End If

            '        If usrDetalleRegSent.GrillaNroRegistroPeriodocondena = 0 And
            '           (usrDetalleRegSent._TotalAnhos = "" Or usrDetalleRegSent._TotalAnhos = "0") And
            '           (usrDetalleRegSent._TotalMes = "" Or usrDetalleRegSent._TotalMes = "0") And
            '           (usrDetalleRegSent._TotalDias = "" Or usrDetalleRegSent._TotalDias = "0") Then
            '            '----
            '            usrDetalleRegSent.btnAgregarPerido = Not (valor)
            '            usrDetalleRegSent.btnCajasPeriodo = valor
            '            'UscDetallResolucionEjecutoria1.EliminarPeriodo()
            '            usrDetalleRegSent._blnCadenaPerpetua = valor
            '            If valor = True Then
            '                uscResolSentencia.blnResultado = True
            '            Else
            '                uscResolSentencia.blnResultado = False
            '            End If

            '            usrDetalleRegSent._TotalAnhos = ""
            '            usrDetalleRegSent._TotalMes = ""
            '            usrDetalleRegSent._TotalDias = ""
            '        Else
            '            Dim strMensaje = "Al activar esta opción." + Chr(13) +
            '                 "No podra registrar el tiempo y los periodos de condena." + Chr(13) +
            '                 "Asimismo se eliminaran los datos ingresados. Desea continuar."

            '            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

            '                usrDetalleRegSent.btnAgregarPerido = Not (valor)
            '                usrDetalleRegSent.btnCajasPeriodo = valor

            '                usrDetalleRegSent.EliminarPeriodo()
            '                usrDetalleRegSent._blnCadenaPerpetua = valor
            '                uscResolSentencia.blnResultado = True

            '                usrDetalleRegSent._TotalAnhos = ""
            '                usrDetalleRegSent._TotalMes = ""
            '                usrDetalleRegSent._TotalDias = ""
            '            Else
            '                uscResolSentencia.blnResultado = False
            '                usrDetalleRegSent._blnCadenaPerpetua = Not (valor)
            '            End If
            '        End If
            '    Else
            '        usrDetalleRegSent.btnAgregarPerido = Not (valor)
            '        usrDetalleRegSent.btnCajasPeriodo = valor

            '        usrDetalleRegSent.EliminarPeriodo()
            '        uscResolSentencia.blnResultado = False
            '        usrDetalleRegSent._blnCadenaPerpetua = valor
            '    End If

            'Else
            '    uscResolSentencia.blnResultado = False

            '    usrDetalleRegSent.btnAgregarPerido = Not (valor)
            '    usrDetalleRegSent.btnCajasPeriodo = valor

            '    'UscDetallResolucionEjecutoria1.EliminarPeriodo()
            '    usrDetalleRegSent._blnCadenaPerpetua = valor
            '    uscResolSentencia._OrdenActivacion = False
            'End If

        End Sub

        Private Sub uscResolSentencia__Click_VerFormulario()
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                '._DistritoJudicialID = uscResolSentencia.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    'uscResolSentencia.DistritoJudicial = ._DistritoJudicialID
                    'uscResolSentencia.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub
        Private Sub usrDetalleRegSent__click_VerSubtipoDocumentoJud()
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            frm._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'usrDetalleRegSent.ActualizarCombo(frm._ResolucionTipoID, frm._ResolucionTipoNom)
                'uscResolSentencia.ActivarControlCkbExtramuro(usrDetalleRegSent.objEntAgraviadoTempoColGrilla)
            End If
        End Sub

        Private Sub uscResolSentencia__Click_VerNombresasociados()
            Dim frm As New Registro.Penal.Identificacion.v5.frmNombreAsociadoPopup_v2(Nothing)
            frm.InternoID = Me._InternoID
            frm.IngresoID = Me._InternoIngresoID
            frm._IngresoInpeID = Me._InternoIngresoInpeId
            frm.DocumentoJudicialID = Me._Codigo
            'frm.objEntNombreAsociadoCol = uscResolSentencia.ObjNombresAsociadosCol
            frm._Nuevobln = Me._blnNuevoRegistro
            frm._FormEscritura = Me._FormEscritura
            If frm.ShowDialog() = DialogResult.OK Then
                'uscResolSentencia.ListarNombresAsociados(frm.Eliminacion, frm.objEntDoc)
            End If
        End Sub

        Private Sub uscResolSentencia__Click_FrmBusquedaAutoridadJudicial()
            FRM_BusquedaAutoridadJudicial()
        End Sub

        Private Sub uscResolSentencia__Click_esInimputables(esInimputable As Boolean)

            'usrDetalleRegSent._actualizarDatosInimputable(esInimputable)

        End Sub

        Private Sub UsrResolSentenciaV21_Load(sender As Object, e As EventArgs) Handles UsrResolSentenciaV21.Load

        End Sub

        Private Sub UscDetallRegistroSentenciaGrilla1__Click_Expediente_Agregar() Handles UscDetallRegistroSentenciaGrilla1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub frmResolSentenciaNueva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

End Namespace