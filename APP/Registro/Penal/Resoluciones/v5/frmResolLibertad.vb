Option Explicit On
Namespace Registro.Resoluciones
    Public Class frmResolLibertad
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
#Region "propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
        Public Property _blnControles() As Boolean = False
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
        Public Property _Documento_sin_mov As Boolean = False
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
#Region "accion"
        Private Function AGrabar() As Integer

            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objDoc.MovimientoMotivoId = UscExpeDeResolucion.objEntExpedienteTempoCol.Item(0).LibertadTipoID

            '/*grabar tiempo de condena*/
            With UscExpeDeResolucion
                objDoc.SentenciaTotalAnios = If(._TotalAnhos.Length = 0, "0", ._TotalAnhos)
                objDoc.SentenciaTotalMeses = If(._TotalMes.Length = 0, "0", ._TotalMes)
                objDoc.SentenciaTotalDias = If(._TotalDias.Length = 0, "0", ._TotalDias)
                objDoc.SentenciaCadenaPerpetua = Me.UscExpeDeResolucion._CadenaPerpetua
            End With

            Me._Codigo = UscResolAclaratoriaExpe1.AGrabar(objDoc)
            UscExpeDeResolucion._FechaMovimiento = UscResolAclaratoriaExpe1.FechaInscripcion
            If Me._Codigo < 1 Then Return Me._Codigo
            'RESOLUCION NUEVO
            UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
            UscExpeDeResolucion._Grabar(Me._Codigo, _blnNuevoRegistro, -1)

            Return Me._Codigo
        End Function


        Private Function Validar() As Boolean

            If UscExpeDeResolucion._Grilla_NroRegistroExpediente < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de libertad debe tener por lo menos un expediente")
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Form"
        Private Sub FRM_Grilla()
            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Expediente.v5.frmListaExpedientePopup
            With frm

                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Me._TipoResolucion
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucion.objEntExpedienteTempoCol
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte

                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucion._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)

                        UscExpeDeResolucion._TotalAnhos = .objEntExpedienteTempoCol.Item(0).SentenciaAnio
                        UscExpeDeResolucion._TotalMes = .objEntExpedienteTempoCol.Item(0).SentenciaMes
                        UscExpeDeResolucion._TotalDias = .objEntExpedienteTempoCol.Item(0).SentenciaDia
                        UscExpeDeResolucion._CadenaPerpetua = .objEntExpedienteTempoCol.Item(0).SentenciaCadenaPerpetua
                        UscExpeDeResolucion.Listar_PeriodoCondena(.objEntExpedienteTempoCol.Item(0).SentenciaFechaInicio, .objEntExpedienteTempoCol.Item(0).SentenciaFechaFinal)

                    End If
                End If
            End With

            If blnNuevoExpediente = True Then
                Dim frm2 As New Registro.Expediente.v5.frmExpedientePopup3
                With frm2
                    ._TipoLicencia = Me._TipoLicencia
                    ._TipoDocumento = Me._TipoResolucion
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoId
                        Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If

        End Sub

        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._TemporalNuevo = True 'temporal nuevo
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = False 'temporal edidato

                End If
                ._objEntExpediente = objEnt
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente)
                End If

            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)

            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._ExpedienteID = UscExpeDeResolucion._GrillaExpedienteID
                    ._ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscExpeDeResolucion._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelCol
                .UscComboDelito1._objEntDelitoCol = objEntDelCol
                ._DelitoItem = UscExpeDeResolucion._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscExpeDeResolucion._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol, ._objEntAgravCol_Ind)
                End If

            End With
        End Sub
        Private Sub FRM_MantAgraviado(ByVal Nuevo As Boolean, objEntDelito As Entity.Registro.Delito, objEnt As Entity.Registro.Agraviado)

            Dim frm As New Registro.Expediente.v5.frmAgraviadoPopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._AgraviadoNombre = ""
                    ._Observacion = ""
                Else
                    ._objEntAgraviado = objEnt
                End If
                ._objEntAgraviadoCol = UscExpeDeResolucion.objEntAgraviadoTempoColGrilla
                ._NuevoGrabar = Nuevo
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    With ._objEntAgraviado
                        .ExpedienteID = UscExpeDeResolucion._GrillaExpedienteID
                        .DelitoID = UscExpeDeResolucion._GrillaDelitoID
                        .ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente
                        .DelitoItem = UscExpeDeResolucion._GrillaItemDelito
                    End With
                    Me.UscExpeDeResolucion._Temporal_GrabarAgraviado(._objEntAgraviado)
                End If
            End With
        End Sub
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    UscResolAclaratoriaExpe1.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub

        'Private Sub FrmAgregarInimputable(idTipoInimputable As Short, idCentroSaludMental As Short)

        '    Dim frm As New Registro.frmListaEstablecimientosInimputables
        '    With frm
        '        'frm.blnReferenciado = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, False, True)                
        '        ._idTipoDocumentoJudicial = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad
        '        ._idTipoImimputable = idTipoInimputable
        '        ._idCentroSaludMental = idCentroSaludMental
        '        If .ShowDialog = DialogResult.OK Then

        '            If ._getIdInimputable > 0 Then
        '                Me.UscExpeDeResolucion._verCamposInimputables(True)
        '            Else
        '                Me.UscExpeDeResolucion._verCamposInimputables(False)
        '            End If

        '            UscExpeDeResolucion.ActualizarDatosTipoInimputable(._getIdInimputable, ._getNombreTipoInimputable,
        '                                                               .getIdCentroSaludMental, ._getCentroSaludMentalNombre)

        '        End If
        '    End With

        'End Sub
        Private Sub FRM_MantPeriodoSentencia(ByVal Nuevo As Boolean, objEntPeriodoSentencia As Entity.Registro.Documento.PeriodoCondenaSentencia)
            Dim frm As New Sentencias.frmPeriodoCondenaSentencia
            With frm
                ._EntPeriodoCondena = objEntPeriodoSentencia
                ._RegionId = Me._RegionID
                ._PenalId = Me._PenalID
                ._TemporalNuevo = Nuevo
                ._objEntExpedienteTempoCol = UscExpeDeResolucion.objEntExpedienteTempoCol
                '._Titulo = UscExpeDeResolucion._TituloPeriodoCondena
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscExpeDeResolucion._Temporal_GrabarPeriodoCondena(._EntPeriodoCondena)
                End If
            End With
        End Sub
#End Region
#Region "otros"
        Private Sub ValoresxDefault()

            'listar datos de la cabecera del documento
            With UscResolAclaratoriaExpe1
                ._InternoID = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._DocumentoTipo = Me._TipoResolucion
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With

            'listar los datos del expediente
            With UscExpeDeResolucion
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                ._InternoID = Me._InternoId
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._DocumentoJudicialID = _Codigo
                '._TotalAnhos = UscResolAclaratoriaExpe1.TotalAnio
                '._TotalMes = UscResolAclaratoriaExpe1.TotalMes
                '._TotalDias = UscResolAclaratoriaExpe1.TotalDias
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(UscResolAclaratoriaExpe1.objEnt, False)
                Me.UscResolAclaratoriaExpe1._activarEstadoEjecucion(UscExpeDeResolucion._getEsInimputable)
            End With

        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura
        End Sub

#End Region

        Private Sub UscExpeDeResolucion1__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_AgregarExpediente() Handles UscExpeDeResolucion._Click_Expediente_Agregar

            FRM_Grilla()

            'si el proceso es inimputable, mostrar el estado de ejecucion en la libertad            
            Me.UscResolAclaratoriaExpe1._activarEstadoEjecucion(UscExpeDeResolucion._getEsInimputable)

        End Sub
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            ' /*Este codigo debe ser igual a libertad*/
            If UscResolAclaratoriaExpe1.Validar = True Then
                If UscExpeDeResolucion.Validar(-1) = True Then
                    If Me._Documento_sin_mov = False Then
                        If UscExpeDeResolucion.GenerarMovimientoLibertad() = True Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                                If AGrabar() > -1 Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                End If
                            Else
                                UscExpeDeResolucion.grabarMovimientoLibertad = False
                                UscExpeDeResolucion.Orden_ = False
                            End If
                        End If
                    Else
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                            If AGrabar() > -1 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        Else
                            UscExpeDeResolucion.grabarMovimientoLibertad = False
                            UscExpeDeResolucion.Orden_ = False
                        End If
                    End If
                End If
            End If
        End Sub
        Private Sub frmResolLibertad_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub


        Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelCol)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        End Sub
        Private Sub UscExpeDeResolucion__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscExpeDeResolucion._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub
        Public OrdenMovimiento As Boolean = False

        Private Sub UscResolAclaratoriaExpe1__Click_VerFormulario() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaSalaJuzgado
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscResolAclaratoriaExpe1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UscResolAclaratoriaExpe1.DistritoJudicial = ._DistritoJudicialID
                    UscResolAclaratoriaExpe1.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub UscExpeDeResolucion__click_VerLibertades() Handles UscExpeDeResolucion._click_VerLibertades
            Dim frm As New Registro.Expediente.v5.frmListarlibertad
            frm._LibertadTipoID = Me.UscExpeDeResolucion._GrillaLibertadTipoID
            frm._SubLibertadTipoStrID = Me.UscExpeDeResolucion._GrillaLibertadSubTipoID
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscExpeDeResolucion.ActualizarLibertad(frm._LibertadTipoID, frm._LibertadTipoNom, frm.objetoSubCol)
            End If
        End Sub

        Private Sub UscResolAclaratoriaExpe1__Click_FrmBusquedaAutoridadJudicial() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub

        Private Sub UscExpeDeResolucion__Click_PeriodoCondena_Agregar() Handles UscExpeDeResolucion._Click_PeriodoCondena_Agregar

            FRM_MantPeriodoSentencia(True, Nothing)

        End Sub

        Private Sub UscExpeDeResolucion__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscExpeDeResolucion._Click_PeriodoCondena_Editar

            FRM_MantPeriodoSentencia(False, objEnt)

        End Sub

        Private Sub UscExpeDeResolucion__Click_Inimputable(esInimputable As Boolean) Handles UscExpeDeResolucion._Click_Inimputable

            'si el proceso es inimputable, mostrar el estado de ejecucion en la libertad            

            Me.UscResolAclaratoriaExpe1._activarEstadoEjecucion(esInimputable)
        End Sub
    End Class
End Namespace