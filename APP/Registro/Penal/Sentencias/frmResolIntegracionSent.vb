Namespace Registro.Sentencias
    Public Class frmResolIntegracionSent
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
        Public Property _TipoResolucion() As Integer = -1 ' se agrego el campo
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
        Private Function AGrabar() As Integer

            Dim EntDocJud As New Entity.Registro.DocumentoJudicial
            With UscDetallResolucionIntegracionSent1
                EntDocJud.SentenciaTotalAnios = ._TotalAnhos
                EntDocJud.SentenciaTotalMeses = ._TotalMes
                EntDocJud.SentenciaTotalDias = ._TotalDias
            End With

            EntDocJud = UsrResolSentencia1.AGrabar(EntDocJud)

            UscDetallResolucionIntegracionSent1._Grabar(If(Me._Codigo < 1, True, False), EntDocJud)

            Return EntDocJud.Codigo
        End Function
#End Region
#Region "Form"
        Private Sub FRM_Grilla()

            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                ._SituacionJuridicaExpe = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                ._TipoResolucion = Me._TipoResolucion
                .objEntExpedienteTempoColCopi2 = UscDetallResolucionIntegracionSent1.objEntExpedienteTempoCol
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscDetallResolucionIntegracionSent1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With

            If blnNuevoExpediente = True Then

                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                frm2._TipoDocumento = Me._TipoResolucion
                frm2._objEntExpedienteCol = UscDetallResolucionIntegracionSent1.objEntExpedienteTempoCol
                With frm2
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoID
                        Me.UscDetallResolucionIntegracionSent1._Temporal_GrabarExpediente(._objEntExpediente)

                    End If
                    'observar
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
                ._objEntExpedienteTempoCol = UscDetallResolucionIntegracionSent1.objEntExpedienteTempoCol
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscDetallResolucionIntegracionSent1._Temporal_GrabarPeriodoNuevaCondena(._EntPeriodoCondena)
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
                    objEnt.Nuevo = True
                End If
                ._TipoDocumento = Me._TipoResolucion
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                ._objEntExpediente = objEnt
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscDetallResolucionIntegracionSent1._Temporal_GrabarExpediente(._objEntExpediente)
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
                    ._ExpedienteID = UscDetallResolucionIntegracionSent1._GrillaExpedienteID
                    ._ExpedienteItem = UscDetallResolucionIntegracionSent1._GrillaItemExpediente

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato                    
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscDetallResolucionIntegracionSent1._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelitoCol
                .UscComboDelito1._objEntDelitoCol = objEntDelitoCol
                ._DelitoItem = UscDetallResolucionIntegracionSent1._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscDetallResolucionIntegracionSent1._GrillaItemExpediente
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscDetallResolucionIntegracionSent1._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol, ._objEntAgravCol_Ind)
                End If

            End With
        End Sub
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    UsrResolSentencia1.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "Otros"

        Private Sub ValoresxDefault()
            With UsrResolSentencia1
                ._Codigo = Me._Codigo
                ._InternoID = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                .DocumentoTipo = Me._TipoResolucion
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            With UscDetallResolucionIntegracionSent1
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
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia Then
                Me.lblTitulo.Text = "RESOLUCION: INTEGRACION DE SENTENCIA"
                Me.Text = "Integracion de Sentencia"
            ElseIf Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia Then
                Me.lblTitulo.Text = "RESOLUCION: REFUNDICION DE SENTENCIA"
                Me.Text = "Refundicion de Sentencia"
            Else
                Me.lblTitulo.Text = "RESOLUCION: SUMATORIA DE SENTENCIA"
                Me.Text = "Sumatoria de Sentencia"
            End If
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

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
            If UsrResolSentencia1.Validar = True Then
                If UscDetallResolucionIntegracionSent1.Validar = True Then
                    Dim strMensaje As String
                    strMensaje = UscDetallResolucionIntegracionSent1.ValidarPeriodoCondena
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar() = DialogResult.Yes Then
                        If AGrabar() > -1 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub UscDetallResolucionIntegracionSent1__Click_Expediente_Agregar() Handles UscDetallResolucionIntegracionSent1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscDetallResolucionIntegracionSent1__Click_PeriodoCondena_Agregar() Handles UscDetallResolucionIntegracionSent1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscDetallResolucionIntegracionSent1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscDetallResolucionIntegracionSent1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub UsrResolEjecutoriaSuperior1__CargarAnhoMesDia(Anho As System.Int32, Mes As System.Int32, Dias As System.Int32)
            With UscDetallResolucionIntegracionSent1
                ._TotalAnhos = Anho
                ._TotalMes = Mes
                ._TotalDias = Dias
            End With
        End Sub

        Private Sub UscDetallResolucionIntegracionSent1__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscDetallResolucionIntegracionSent1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscDetallResolucionIntegracionSent1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionIntegracionSent1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub UscDetallResolucionIntegracionSent1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscDetallResolucionIntegracionSent1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub

        Private Sub UsrResolEjecutoriaSuperior1__ChecekHabilitarAgregarCondena(valor As System.Boolean)
            If UsrResolSentencia1._OrdenActivacion = False Then
                If valor = True Then
                    If Me._Codigo > 0 Then
                        If UscDetallResolucionIntegracionSent1.ValidarExpedienteReferenciado(6) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                            UsrResolSentencia1.blnResultado = False
                            Exit Sub
                        End If

                    End If

                    If UscDetallResolucionIntegracionSent1.GrillaNroRegistroPeriodocondena = 0 And
                       UscDetallResolucionIntegracionSent1._TotalAnhos = 0 And
                       UscDetallResolucionIntegracionSent1._TotalMes = 0 And
                       UscDetallResolucionIntegracionSent1._TotalDias = 0 Then
                        '----
                        UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                        UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor
                        'UscDetallResolucionEjecutoria1.EliminarPeriodo()
                        UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                        If valor = True Then
                            UsrResolSentencia1.blnResultado = True
                        Else
                            UsrResolSentencia1.blnResultado = False
                        End If
                    Else
                        Dim strMensaje = "Al activar esta opción." + Chr(13) +
                             "No podra registrar el tiempo y los periodos de condena." + Chr(13) +
                             "Asimismo se eliminaran los datos ingresados. Desea continuar."

                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                            UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                            UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor

                            UscDetallResolucionIntegracionSent1.EliminarPeriodo()
                            UsrResolSentencia1.blnResultado = True
                            UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                        Else
                            UsrResolSentencia1.blnResultado = False
                            UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = Not (valor)
                        End If
                    End If
                Else
                    UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                    UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor

                    UscDetallResolucionIntegracionSent1.EliminarPeriodo()
                    UsrResolSentencia1.blnResultado = False
                    UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                End If

            Else
                UsrResolSentencia1.blnResultado = False

                UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor

                'UscDetallResolucionEjecutoria1.EliminarPeriodo()
                UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                UsrResolSentencia1._OrdenActivacion = False
            End If
        End Sub

        Private Sub UsrResolEjecutoriaSuperior1__Click_VerFormulario()
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UsrResolSentencia1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UsrResolSentencia1.DistritoJudicial = ._DistritoJudicialID
                    UsrResolSentencia1.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub UsrResolSentencia1__CargarAnhoMesDia(Anho As System.Int32, Mes As System.Int32, Dias As System.Int32) Handles UsrResolSentencia1._CargarAnhoMesDia
            With UscDetallResolucionIntegracionSent1
                ._TotalAnhos = Anho
                ._TotalMes = Mes
                ._TotalDias = Dias
            End With
        End Sub

        Private Sub UsrResolSentencia1__ChecekHabilitarAgregarCondena(valor As System.Boolean) Handles UsrResolSentencia1._ChecekHabilitarAgregarCondena
            With UsrResolSentencia1
                If ._OrdenActivacion = False Then
                    If valor = True Then
                        If Me._Codigo > 0 Then
                            If UscDetallResolucionIntegracionSent1.ValidarExpedienteReferenciado(6) = False Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                                .blnResultado = False
                                Exit Sub
                            End If

                        End If
                        If UscDetallResolucionIntegracionSent1.GrillaNroRegistroPeriodocondena = 0 And
                           UscDetallResolucionIntegracionSent1._TotalAnhos = 0 And
                           UscDetallResolucionIntegracionSent1._TotalMes = 0 And
                           UscDetallResolucionIntegracionSent1._TotalDias = 0 Then
                            '----
                            UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                            UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor
                            UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                            If valor = True Then
                                .blnResultado = True
                            Else
                                .blnResultado = False
                            End If
                        Else
                            Dim strMensaje = "Al activar esta opción." + Chr(13) +
                                 "No podra registrar el tiempo y los periodos de condena." + Chr(13) +
                                 "Asimismo se eliminaran los datos ingresados. Desea continuar."

                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                                UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                                UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor

                                UscDetallResolucionIntegracionSent1.EliminarPeriodo()
                                .blnResultado = True
                                UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                            Else
                                .blnResultado = False
                                UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = Not (valor)
                            End If
                        End If
                    Else
                        UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                        UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor

                        UscDetallResolucionIntegracionSent1.EliminarPeriodo()
                        .blnResultado = False
                        UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                    End If

                Else
                    .blnResultado = False
                    UscDetallResolucionIntegracionSent1.btnAgregarPerido = Not (valor)
                    UscDetallResolucionIntegracionSent1.btnCajasPeriodo = valor
                    UscDetallResolucionIntegracionSent1._blnCadenaPerpetua = valor
                    ._OrdenActivacion = False
                End If
            End With
        End Sub

        Private Sub UsrResolSentencia1__Click_VerFormulario() Handles UsrResolSentencia1._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UsrResolSentencia1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UsrResolSentencia1.DistritoJudicial = ._DistritoJudicialID
                    UsrResolSentencia1.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub UsrResolSentencia1__Click_FrmBusquedaAutoridadJudicial() Handles UsrResolSentencia1._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class
End Namespace