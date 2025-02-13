Namespace Registro.RegionLima.Resoluciones
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
#End Region
#Region "Accion"

        Private Function Agrabar_() As Integer

            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim EntDocJud As New Entity.Registro.DocumentoJudicial
            EntDocJud = usrResolSentencia.AGrabar(EntDocJud)
            If EntDocJud.Codigo < 1 Then Return EntDocJud.Codigo
            'grabar periodo de sentencia
            UscDetallResolucionEjecutoria1._Grabar(EntDocJud.Codigo, _blnNuevoRegistro, EntDocJud)

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
                ._TipoDelito = Type.Enumeracion.enmTipoDelito.Faltas
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
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
        Private Sub TituloSentencia()

            Dim strTitulo As String = ""

            Select Case Me._TipoResolucion
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa
                    strTitulo = "SENTENCIA DE PENA LIMITATIVA"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD
                    strTitulo = "EJECUTORIA SUPERIOR PLD"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida
                    strTitulo = "EJECUTORIA SUPERIOR PLD CONSENTIDA"
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
                ' ._Visible_CadenaPerpetua = False
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
                ._ListarExpediente(_Codigo, True, True)
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa Then
                    usrResolSentencia.ListarControlExtramuro(._Extramuro)
                End If
            End With

        End Sub
#End Region

        Private Sub usrDetalleRegSent__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub usrDetalleRegSent__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub
        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Agregar()
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub
        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia)
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Expediente_Agregar()
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
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar() = DialogResult.Yes Then
                        If Agrabar_() > -1 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
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

        Private Sub UscDetallResolucionEjecutoria1__Click_Expediente_Agregar() Handles UscDetallResolucionEjecutoria1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscDetallResolucionEjecutoria1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionEjecutoria1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionEjecutoria1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_PeriodoCondena_Agregar() Handles UscDetallResolucionEjecutoria1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscDetallResolucionEjecutoria1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionEjecutoria1__click_VerResoluciones() Handles UscDetallResolucionEjecutoria1._click_VerResoluciones
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            frm._ResolucionTipoID = Me.UscDetallResolucionEjecutoria1.GrillaResolucionID
            frm._TipoResolucion = Me._TipoResolucion
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscDetallResolucionEjecutoria1.ActualizarResolucion(frm._ResolucionTipoID, frm._ResolucionTipoNom)
            End If
        End Sub

        Private Sub usrResolSentencia__Click_VerInimputables(blnValor As Boolean)
            UscDetallResolucionEjecutoria1.ValidarExpedienteReferenciado(blnValor)
        End Sub

        Private Sub usrResolSentencia__Click_esInimputables(blnValor As Boolean) Handles usrResolSentencia._Click_esInimputables
            UscDetallResolucionEjecutoria1.actualizarDatosInimputable(blnValor)
        End Sub

    End Class
End Namespace