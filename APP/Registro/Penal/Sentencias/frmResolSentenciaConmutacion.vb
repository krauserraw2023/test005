Option Explicit On
Namespace Registro.Sentencias
    Public Class frmResolSentenciaConmutacion
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
            With UscDetallResolucionConmutacion1
                EntDocJud.SentenciaTotalAnios = If(._TotalAnhos.Length = 0, "0", ._TotalAnhos)
                EntDocJud.SentenciaTotalMeses = If(._TotalMes.Length = 0, "0", ._TotalMes)
                EntDocJud.SentenciaTotalDias = If(._TotalDias.Length = 0, "0", ._TotalDias)
                EntDocJud.IngresoInpeId = Me._InternoIngresoInpeId
                EntDocJud.InternoIngresoId = Me._InternoIngresoID
            End With
            EntDocJud.Codigo = UscResolConmutacion1.AGrabar(EntDocJud)
            If EntDocJud.Codigo > 0 Then
                UscDetallResolucionConmutacion1._Grabar(EntDocJud.Codigo, _blnNuevoRegistro, EntDocJud)
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
                .objEntExpedienteTempoColCopi2 = UscDetallResolucionConmutacion1.objEntExpedienteTempoCol
                ._TipoResolucion = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscDetallResolucionConmutacion1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With
            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                With frm2
                    ._objEntExpedienteCol = UscDetallResolucionConmutacion1.objEntExpedienteTempoCol
                    ._TipoDocumento = Me._TipoResolucion
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoID
                        ._objEntExpediente.Nuevo = True
                        Me.UscDetallResolucionConmutacion1._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_MantPeriodoSentencia(ByVal Nuevo As Boolean, objEntPeriodoSentencia As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Dim frm As New Sentencia.frmPeriodoCondena
            With frm
                ._EntPeriodoCondena = objEntPeriodoSentencia
                ._RegionId = Me._RegionID
                ._PenalId = Me._PenalID
                ._TemporalNuevo = Nuevo
                ._objEntExpedienteTempoCol = UscDetallResolucionConmutacion1.objEntExpedienteTempoCol
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscDetallResolucionConmutacion1._Temporal_GrabarPeriodoNuevaCondena(._EntPeriodoCondena)
                End If
            End With
        End Sub
        Private Sub FRM_MantPeriodoHistorico(ByVal Nuevo As Boolean, objEntPeriodoSentencia As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Dim frm As New Sentencias.frmPeriodoCondenaSentencia
            With frm
                ._EntPeriodoCondena = objEntPeriodoSentencia
                ._RegionId = Me._RegionID
                ._PenalId = Me._PenalID
                ._TemporalNuevo = Nuevo
                ._objEntExpedienteTempoCol = UscDetallResolucionConmutacion1.objEntExpedienteTempoCol
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscDetallResolucionConmutacion1._Temporal_GrabarPeriodoCondena(._EntPeriodoCondena)
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
                    Me.UscDetallResolucionConmutacion1._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
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
                    ._ExpedienteID = UscDetallResolucionConmutacion1._GrillaExpedienteID
                    ._ExpedienteItem = UscDetallResolucionConmutacion1._GrillaItemExpediente 'HNRB puede ser reemplazado por objEntExpediente._ExpedienteItem

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato                    
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscDetallResolucionConmutacion1._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelitoCol
                .UscComboDelito1._objEntDelitoCol = objEntDelitoCol
                ._DelitoItem = UscDetallResolucionConmutacion1._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscDetallResolucionConmutacion1._GrillaItemExpediente 'HNRB puede ser reeamplazado por objEntExpediente.ExpedienteItem
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscDetallResolucionConmutacion1._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol)
                End If
                If .EliminarFila = True Then
                    Dim ana As Integer = .AgraviadoItemCopia
                End If

            End With
        End Sub
        Private Sub FRM_BusquedaSalasJuzgados()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscResolConmutacion1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UscResolConmutacion1.DistritoJudicial = ._DistritoJudicialID
                    UscResolConmutacion1.SalaJuzgado = ._GrillaSalaID

                End If
            End With

        End Sub
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    UscResolConmutacion1.DistritoJudicial = .getCodigo
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

            With UscResolConmutacion1
                ._InternoID = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._Codigo = Me._Codigo
                ._DocumentoTipo = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
                TituloSentencia()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            With UscDetallResolucionConmutacion1
                ._DocumentoJudicialID = Me._Codigo
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoResolucion = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._ListarExpediente(_Codigo, True, True)
            End With
            If Me._Codigo < 1 Then
                Me.Refresh()
            End If
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

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolAclaratoriaSent_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If UscResolConmutacion1.Validar = True Then
                If UscDetallResolucionConmutacion1.Validar = True Then
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

            If valor = True Then

                If Me._Codigo > 0 Then
                    If UscDetallResolucionConmutacion1.ValidarExpedienteReferenciado(6) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                        Exit Sub
                    End If

                End If

                If UscDetallResolucionConmutacion1.GrillaNroRegistroPeriodocondena = 0 And
                       UscDetallResolucionConmutacion1._TotalAnhos = 0 And
                       UscDetallResolucionConmutacion1._TotalMes = 0 And
                       UscDetallResolucionConmutacion1._TotalDias = 0 Then
                    '----
                    UscDetallResolucionConmutacion1.btnAgregarPerido = Not (valor)
                    UscDetallResolucionConmutacion1.btnCajasPeriodo = valor
                    'UscDetallResolucionConmutacion1.EliminarPeriodo()
                    UscDetallResolucionConmutacion1._blnCadenaPerpetua = valor

                Else
                    Dim strMensaje = "Al activar esta opción." + Chr(13) +
                             "No podra registrar el tiempo y los periodos de condena." + Chr(13) +
                             "Asimismo se eliminaran los datos ingresados. Desea continuar."

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                        UscDetallResolucionConmutacion1.btnAgregarPerido = Not (valor)
                        UscDetallResolucionConmutacion1.btnCajasPeriodo = valor

                        UscDetallResolucionConmutacion1.EliminarPeriodo()
                        UscDetallResolucionConmutacion1._blnCadenaPerpetua = valor
                    Else

                        UscDetallResolucionConmutacion1._blnCadenaPerpetua = Not (valor)
                    End If
                End If
            Else
                UscDetallResolucionConmutacion1.btnAgregarPerido = Not (valor)
                UscDetallResolucionConmutacion1.btnCajasPeriodo = valor

                UscDetallResolucionConmutacion1.EliminarPeriodo()
                UscDetallResolucionConmutacion1._blnCadenaPerpetua = valor
            End If

        End Sub

        Private Sub usrResolSentencia__Click_VerFormulario()
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscResolConmutacion1.DistritoJudicial

                If .ShowDialog = DialogResult.OK Then

                    UscResolConmutacion1.DistritoJudicial = ._DistritoJudicialID
                    UscResolConmutacion1.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_Expediente_Agregar() Handles UscDetallResolucionConmutacion1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscDetallResolucionConmutacion1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionConmutacion1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionConmutacion1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionConmutacion1__click_VerResoluciones()
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            frm._ResolucionTipoID = Me.UscDetallResolucionConmutacion1.GrillaResolucionID
            frm._TipoResolucion = Me._TipoResolucion
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscDetallResolucionConmutacion1.ActualizarResolucion(frm._ResolucionTipoID, frm._ResolucionTipoNom)
            End If
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_PeriodoCondena_Agregar() Handles UscDetallResolucionConmutacion1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscDetallResolucionConmutacion1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_PeriodoHistorico_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscDetallResolucionConmutacion1._Click_PeriodoHistorico_Editar
            FRM_MantPeriodoHistorico(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionConmutacion1__Click_PeriodoHistorico_Agregar(nuevo As Boolean, objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscDetallResolucionConmutacion1._Click_PeriodoHistorico_Agregar
            FRM_MantPeriodoHistorico(nuevo, objEnt)
        End Sub

        Private Sub UscResolConmutacion1__Click_FrmBusquedaAutoridadJudicial() Handles UscResolConmutacion1._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class
End Namespace