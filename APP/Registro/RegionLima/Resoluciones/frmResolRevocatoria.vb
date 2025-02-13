Namespace Registro.RegionLima.Resoluciones
    Public Class frmResolRevocatoria
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
        Public Property _TipoResolucion As Integer = -1
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

            Dim expColTmp As New Entity.Registro.ExpedienteCol
            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim EntDocJud As New Entity.Registro.DocumentoJudicial
            With usrDetalleRegSent
                EntDocJud.SentenciaTotalAnios = If(._TotalAnhos.Length = 0, "0", ._TotalAnhos)
                EntDocJud.SentenciaTotalMeses = If(._TotalMes.Length = 0, "0", ._TotalMes)
                EntDocJud.SentenciaTotalDias = If(._TotalDias.Length = 0, "0", ._TotalDias)
            End With

            EntDocJud = uscResolSentencia.AGrabar(EntDocJud)
            If EntDocJud.Codigo < 1 Then Return EntDocJud.Codigo

            'Grabar periodo de sentencia 
            usrDetalleRegSent._Grabar(EntDocJud.Codigo, _blnNuevoRegistro, EntDocJud)

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
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria
                .objEntExpedienteTempoColCopi2 = usrDetalleRegSent.objEntExpedienteTempoCol
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.usrDetalleRegSent._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With
            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                frm2._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria
                frm2._objEntExpedienteCol = usrDetalleRegSent.objEntExpedienteTempoCol
                With frm2
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoID
                        ._objEntExpediente.Nuevo = False
                        Me.usrDetalleRegSent._Temporal_GrabarExpediente(._objEntExpediente)
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
                ._objEntExpedienteTempoCol = usrDetalleRegSent.objEntExpedienteTempoCol
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    usrDetalleRegSent._Temporal_GrabarPeriodoCondena(._EntPeriodoCondena)
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
                    Me.usrDetalleRegSent._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
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
                    ._ExpedienteID = usrDetalleRegSent._GrillaExpedienteID
                    ._ExpedienteItem = usrDetalleRegSent._GrillaItemExpediente 'HNRB puede ser reemplazado por objEntExpediente._ExpedienteItem
                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    .ResolucionNuevo = False
                    objEnt_.DelitoItem = Me.usrDetalleRegSent._GrillaItemDelito
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
                    '._objEntDelito.ExpedienteItem = usrDetalleRegSent._GrillaItemExpediente 'HNRB puede ser reeamplazado por objEntExpediente.ExpedienteItem
                    'If ._TemporalNuevo = False Then
                    '    ._objEntDelito.DelitoAuxiliar = False
                    '    ._objEntDelito.DelitoItem = ._DelitoItem
                    'End If
                    Me.usrDetalleRegSent._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol)
                End If
                If .EliminarFila = True Then
                    Dim ana As Integer = .AgraviadoItemCopia
                End If

            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            With uscResolSentencia
                ._InternoID = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._Codigo = Me._Codigo
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria
                ._TipoLicencia = Me._TipoLicencia
                '._Visible_CadenaPerpetua = False
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            With usrDetalleRegSent
                ._DocumentoJudicialID = Me._Codigo
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._ListarExpediente(uscResolSentencia.objEnt, 37, True, True)
            End With
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Agregar() Handles usrDetalleRegSent._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub usrDetalleRegSent__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles usrDetalleRegSent._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles usrDetalleRegSent._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub usrDetalleRegSent__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles usrDetalleRegSent._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub
        Private Sub usrDetalleRegSent__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol) Handles usrDetalleRegSent._Click_Delito_Editar
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
            If uscResolSentencia.Validar = True Then
                If usrDetalleRegSent.Validar = True Then
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar() = DialogResult.Yes Then
                        If AGrabar() > -1 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub uscResolSentencia__ChecekHabilitarAgregarCondena(valor As Boolean) Handles uscResolSentencia._ChecekHabilitarAgregarCondena

            If uscResolSentencia._OrdenActivacion = False Then
                If valor = True Then

                    If Me._Codigo > 0 Then
                        If usrDetalleRegSent.ValidarExpedienteReferenciado(6) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe por lo menos un expediente referenciado, [Operación cancelada]")
                            uscResolSentencia.blnResultado = False
                            Exit Sub
                        End If

                    End If

                    If usrDetalleRegSent.GrillaNroRegistroPeriodocondena = 0 And _
                       usrDetalleRegSent._TotalAnhos = 0 And _
                       usrDetalleRegSent._TotalMes = 0 And _
                       usrDetalleRegSent._TotalDias = 0 Then
                        '----
                        usrDetalleRegSent.btnAgregarPerido = Not (valor)
                        usrDetalleRegSent.btnCajasPeriodo = valor
                        'UscDetallResolucionEjecutoria1.EliminarPeriodo()
                        usrDetalleRegSent._blnCadenaPerpetua = valor
                        If valor = True Then
                            uscResolSentencia.blnResultado = True
                        Else
                            uscResolSentencia.blnResultado = False
                        End If
                    Else
                        Dim strMensaje = "Al activar esta opción." + Chr(13) +
                             "No podra registrar el tiempo y los periodos de condena." + Chr(13) +
                             "Asimismo se eliminaran los datos ingresados. Desea continuar."

                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                            usrDetalleRegSent.btnAgregarPerido = Not (valor)
                            usrDetalleRegSent.btnCajasPeriodo = valor

                            usrDetalleRegSent.EliminarPeriodo()
                            usrDetalleRegSent._blnCadenaPerpetua = valor
                            uscResolSentencia.blnResultado = True

                        Else
                            uscResolSentencia.blnResultado = False
                            usrDetalleRegSent._blnCadenaPerpetua = Not (valor)
                        End If
                    End If
                Else
                    usrDetalleRegSent.btnAgregarPerido = Not (valor)
                    usrDetalleRegSent.btnCajasPeriodo = valor

                    usrDetalleRegSent.EliminarPeriodo()
                    uscResolSentencia.blnResultado = False
                    usrDetalleRegSent._blnCadenaPerpetua = valor
                End If

            Else
                uscResolSentencia.blnResultado = False

                usrDetalleRegSent.btnAgregarPerido = Not (valor)
                usrDetalleRegSent.btnCajasPeriodo = valor

                'UscDetallResolucionEjecutoria1.EliminarPeriodo()
                usrDetalleRegSent._blnCadenaPerpetua = valor
                uscResolSentencia._OrdenActivacion = False
            End If

        End Sub

        Private Sub uscResolSentencia__Click_VerFormulario() Handles uscResolSentencia._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = uscResolSentencia.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    uscResolSentencia.DistritoJudicial = ._DistritoJudicialID
                    uscResolSentencia.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub
        Private Sub usrDetalleRegSent__Click_Expediente_Agregar() Handles usrDetalleRegSent._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub usrDetalleRegSent_Load(sender As Object, e As EventArgs) Handles usrDetalleRegSent.Load

        End Sub

        Private Sub usrDetalleRegSent__click_VerSubtipoDocumentoJud() Handles usrDetalleRegSent._click_VerSubtipoDocumentoJud

            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            frm._ResolucionTipoID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria
            frm._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                usrDetalleRegSent.ActualizarCombo(frm._ResolucionTipoID, frm._ResolucionTipoNom)
            End If

        End Sub


    End Class

End Namespace