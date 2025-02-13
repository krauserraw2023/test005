Option Explicit On
Imports System.ComponentModel
Imports Entity.Reporte.CertificadoReclusion
Imports Legolas.Configuration
Imports SIPPOPE.Load
Imports SIPPOPE.Mantenimiento.Tratamiento.Clasificacion

Namespace Registro.Resoluciones
    Public Class frmResolLibertad_v2
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing

#Region "propiedades"

        Public Property _NuevoRegistro() As Boolean = False
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
        Public Property _Historico As Boolean = False
        Public Property _HistoricoFecha As Long = 0
#End Region
#Region "accion"
        Private Function AGrabar() As Integer
            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim objDoc As New Entity.Registro.DocumentoJudicial
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

            '*******************************************************************************

            'RESOLUCION NUEVO
            UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
            UscExpeDeResolucion.chk_Queda = UscQueda1._chkqueda_si
            UscExpeDeResolucion.grabarMovimientoLibertad = UscQueda1._chkqueda_no
            UscExpeDeResolucion._Grabar(Me._Codigo, _blnNuevoRegistro, -1)

            '************************************QUEDA***************************************
            With UscQueda1
                ._Codigo = Me._Codigo
                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._DocumentoTipo = 26
                .TipoAutoridadJudicial = 3
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._TipoLicencia = Me._TipoLicencia
                ._DocumentoTipo = Me._TipoResolucion
                ._TemporalNuevo = True
                .DocJudicialID = Me._Codigo
                '._FormEscritura = Me._FormEscritura
                '._FormEliminar = Me._FormEliminar
                '._FormReporte = Me._FormReporte
                'UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            If Me._Codigo < 1 Then
                'NUEVO
            Else
                UscQueda1.GrabarQueda(Me._Codigo)
            End If

            '*******************Eliminar Movimiento****************************************
            If (Me._TipoLicencia <> 5) Then
                UscQueda1.eliminar_movimiento_libertad("aut", "del_mov", Me._Codigo, Me._InternoId, Me._InternoIngresoId)
            End If
            '******************************************************************************

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
            Dim objExpCol As New Entity.Registro.ExpedienteCol
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
                        '**************QUEDA***************
                        With UscQueda1
                            ._InternoID = Me._InternoId
                            ._IngresoID = Me._InternoIngresoId
                            ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                            ._TipoLicencia = Me._TipoLicencia
                            ._TipoResolucion = Me._TipoResolucion
                            .objEntExpedienteTempoCol_QuedaCopi2 = UscExpeDeResolucion.objEntExpedienteTempoCol
                            ._RegionID = Me._RegionID
                            ._PenalID = Me._PenalID
                        End With
                        objExpCol = .objEntExpedienteTempoCol
                        Me.UscQueda1._ListarExpediente_Queda(.objEntExpedienteTempoCol)
                        'Me.UscQueda1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
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
                        Me.UscQueda1._ListarExpediente_Queda(objExpCol)
                    End If
                End With
            End If

        End Sub
        Private Sub UscExpeDeResolucion__Click_Expediente_Eliminar() Handles UscExpeDeResolucion._Click_Expediente_Eliminar
            UscQueda1.Temporal_EliminarExpediente_Delito_Agraviado()
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

        Dim frmLoad As Load.frmLoad = Nothing
        Private Sub ValoresxDefault()
            'listar datos de la cabecera del documento
            'Me.SuspendLayout()
            'Me.Timer1.Start()
            'frmLoad = New Load.frmLoad
            'If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    Me.Timer1.Stop()
            '    Me.BGWorker1.CancelAsync()
            '    Me.BGWorker1.Dispose()
            'End If
            'Me.ResumeLayout(True)
            frmLoad = New Load.frmLoad
            Application.DoEvents()
            frmLoad.Show()
            Application.DoEvents()
            With UscResolAclaratoriaExpe1
                ._InternoID = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._DocumentoTipo = Me._TipoResolucion
                ._Historico = Me._Historico
                ._HistoricoFecha = Me._HistoricoFecha
                Application.DoEvents()
                ._LoadUsc()
                Application.DoEvents()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
                Application.DoEvents()
            End With
            frmLoad.Refresh()
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
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                Application.DoEvents()
                ._ListarExpediente(UscResolAclaratoriaExpe1.objEnt, False)
                Application.DoEvents()
                Me.UscResolAclaratoriaExpe1._activarEstadoEjecucion(UscExpeDeResolucion._getEsInimputable)
                Application.DoEvents()
            End With
            frmLoad.Refresh()
            If _NuevoRegistro = False Then
                With UscQueda1
                    ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._TipoLicencia = Me._TipoLicencia
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._DocumentoJudicialID = _Codigo
                    ._Codigo = Me._Codigo
                    .InhabilitarRadioButon(Me.UscResolAclaratoriaExpe1.idEstadoTraslado)
                    Application.DoEvents()
                    ._LoadUsc()
                    Application.DoEvents()
                    ._ListarExpediente_Queda(_Codigo, False)
                    Application.DoEvents()
                    '._FormEscritura = Me._FormEscritura
                    '._FormEliminar = Me._FormEliminar
                    '._ListarExpediente(_Codigo, False)
                End With
            End If
            UscQueda1._fechaejecucionMov = UscResolAclaratoriaExpe1._fechaejecucionMov
            'Me.Timer1.Stop()
            frmLoad.Refresh()
            frmLoad.Close()
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

        Dim frmprocesar As frmProcesando = Nothing
        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            ' /*Este codigo debe ser igual a libertad*/
            Me.btnAceptar.Enabled = False
            frmprocesar = New Load.frmProcesando
            Me.ResumeLayout()
            'Me.Timer2.Start()
            'If frmprocesar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '    Me.Timer2.Stop()
            '    Me.BGWorker2.CancelAsync()
            '    Me.BGWorker2.Dispose()
            'End If
            Application.DoEvents()
            frmprocesar.Show()
            Application.DoEvents()
            If UscResolAclaratoriaExpe1.Validar = True Then
                If UscQueda1.Validar_Queda = True Then
                    If UscExpeDeResolucion.Validar(-1) = True Then
                        '*********ORL NO REGISTRA MOVIMIENTO*********************************
                        If Me._Documento_sin_mov = False Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                                If UscExpeDeResolucion.GenerarMovimientoLibertad() = True Then
                                    Application.DoEvents()

                                    If AGrabar() > -1 Then
                                        Me.DialogResult = Windows.Forms.DialogResult.OK
                                        Legolas.Configuration.Aplication.MessageBox.Information("Registro satisfactorio.")
                                        Me.Close()
                                    Else
                                        Legolas.Configuration.Aplication.MessageBox.MensajeError("Error registrando Libertad")
                                        Me.btnAceptar.Enabled = True
                                    End If
                                End If
                            Else
                                UscExpeDeResolucion.grabarMovimientoLibertad = False
                                UscExpeDeResolucion.Orden_ = False
                                Me.btnAceptar.Enabled = True
                            End If
                        Else

                            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                                If UscQueda1._chkqueda_si = True Then
                                Else
                                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("El interno NO CUENTA con otro de mandato de detención" + Chr(13) +
                                                                                                        "vigente / sentencia pendiente de cumplimiento. Sirvase" + Chr(13) +
                                                                                                        "validar con los archivos físicos y los registros" + Chr(13) +
                                                                                                        "íntegros en el sistema.)" + Chr(13) +
                                                                                                        "" + Chr(13) +
                                                                                                        "¿De todas maneras, desea guardar?") = DialogResult.No Then
                                        frmprocesar.Close()
                                        frmprocesar.Refresh()
                                        btnAceptar.Enabled = True
                                        Exit Sub
                                    End If
                                End If
                            End If
                            Application.DoEvents()


                            If AGrabar() > -1 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Legolas.Configuration.Aplication.MessageBox.Information("Registro satisfactorio.")
                                Me.Close()
                            Else
                                Legolas.Configuration.Aplication.MessageBox.MensajeError("Error registrando Libertad")
                                Me.btnAceptar.Enabled = True
                            End If
                            'Legolas.Configuration.Aplication.MessageBox.MensajeError("Documento Con movimiento...")
                            Me.btnAceptar.Enabled = True
                        End If
                    Else
                        Me.TabControl1.TabPages(1).Select()
                        Me.btnAceptar.Enabled = True
                    End If
                Else
                    If TabControl1.SelectedIndex = 0 Then
                        Me.TabControl1.SelectedIndex = 1
                        Me.UscQueda1.MostrarControlesButton()
                    End If
                End If
            Else
                Me.btnAceptar.Enabled = True
            End If
            Me.btnAceptar.Enabled = True
            Me.ResumeLayout(True)
            frmprocesar.Close()
            frmprocesar.Refresh()

            'If UscResolAclaratoriaExpe1.Validar = True Then
            '    If UscQueda1.Validar_Queda = True Then
            '        If UscExpeDeResolucion.Validar(-1) = True Then
            '            If Me._Documento_sin_mov = False Then
            '                If UscExpeDeResolucion.GenerarMovimientoLibertad() = True Then
            '                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
            '                        If AGrabar() > -1 Then
            '                            Me.DialogResult = Windows.Forms.DialogResult.OK
            '                            Legolas.Configuration.Aplication.MessageBox.Information("Registro satisfactorio.")
            '                            Me.Close()
            '                        End If
            '                    Else
            '                        UscExpeDeResolucion.grabarMovimientoLibertad = False
            '                        UscExpeDeResolucion.Orden_ = False
            '                        Me.btnAceptar.Enabled = True
            '                    End If
            '                End If
            '            Else
            '                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
            '                    If AGrabar() > -1 Then
            '                        Me.DialogResult = Windows.Forms.DialogResult.OK
            '                        Legolas.Configuration.Aplication.MessageBox.Information("Registro satisfactorio.")
            '                        Me.Close()
            '                    Else
            '                        Me.btnAceptar.Enabled = True
            '                    End If
            '                Else
            '                    UscExpeDeResolucion.grabarMovimientoLibertad = False
            '                    UscExpeDeResolucion.Orden_ = False
            '                    Me.btnAceptar.Enabled = True
            '                End If
            '            End If
            '        Else
            '            Me.btnAceptar.Enabled = True
            '        End If
            '    Else
            '        Me.TabControl1.TabPages(1).Select()
            '        Me.btnAceptar.Enabled = True
            '    End If
            'Else
            '    Me.btnAceptar.Enabled = True
            'End If
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
            frm._InimputableInterno = Me.UscExpeDeResolucion.grillaIdTipoInimputable

            If Me.UscExpeDeResolucion.objEntExpedienteTempoCol.Count > 0 Then
                If Me.UscExpeDeResolucion.objEntExpedienteTempoCol.Item(0).LibertadAuxiliarID > 0 Then
                    frm._InimputableInterno = -1
                End If
            End If

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscExpeDeResolucion.ActualizarLibertad(frm._LibertadTipoID, frm._LibertadTipoNom, frm.objetoSubCol)
            End If
        End Sub
        Private Sub UscResolAclaratoriaExpe1__Click_FrmBusquedaAutoridadJudicial() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial()
        End Sub
        Private Sub UscExpeDeResolucion__Click_PeriodoCondena_Agregar() Handles UscExpeDeResolucion._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub
        Private Sub UscExpeDeResolucion__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscExpeDeResolucion._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub
        Private Sub UscExpeDeResolucion__Click_Inimputable(esInimputable As Boolean) Handles UscExpeDeResolucion._Click_Inimputable
            ' Eliminar expediente temporales
            UscQueda1._Cantidad_queda = 0
            'si el proceso es inimputable, mostrar el estado de ejecucion en la libertad            
            Me.UscResolAclaratoriaExpe1._activarEstadoEjecucion(esInimputable)
        End Sub
        Private Sub UscQueda1__Click_chkQueda() Handles UscQueda1._Click_chkQueda
            With UscQueda1
                If ._chkqueda_no = True Then
                    If ._Cantidad_queda > 0 Or .OtrosProcesos > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede seleccionar esta opción, porque el interno" + Chr(13) +
                                                                               "cuenta con otro mandato de detención vigente / sentencia" + Chr(13) +
                                                                               "pendiente de cumplimiento.")


                        .MostrarControlesButton()
                    End If
                End If

                If (Me._TipoLicencia <> 5) Then
                    If ._chkqueda_si = True Then
                        Me._Documento_sin_mov = True
                    Else
                        Me._Documento_sin_mov = False
                    End If
                End If
            End With
        End Sub
        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            If Me.BGWorker1.IsBusy Then Exit Sub
            ' inicializa la validacion del ping
            Me.BGWorker1.RunWorkerAsync()
        End Sub
        'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '    If Me.BGWorker2.IsBusy Then Exit Sub
        '    Me.BGWorker2.RunWorkerAsync()
        'End Sub

        Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGWorker1.DoWork
            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
            If Me.BGWorker1.CancellationPending = True Then
                e.Cancel = True
            Else
                e.Result = Listar_BGWorker1(worker, e)
            End If
        End Sub
        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWorker1.RunWorkerCompleted
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then

                'Me.Timer1.Stop()
                'frmLoad.Close()
                result = e.Result
            End If
        End Sub
        Private Sub BackgroundWorker1_Disposed(sender As Object, e As EventArgs) Handles BGWorker1.Disposed
            If Me.BGWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                'Me.BGWorker1 = Nothing
                'Me.Close()
            End If
        End Sub
        Private Function Listar_BGWorker1(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Boolean
            If worker.CancellationPending = True Then
                e.Cancel = True
            Else
                Return True
            End If
        End Function

        Private Sub BGWorker3_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWorker3.RunWorkerCompleted
            Dim result As Boolean = False
            Try
                If e.Cancelled = False AndAlso e.Error Is Nothing Then
                    'frmLoad.Close()
                    'Timer1.Enabled = False
                    result = e.Result
                End If
            Catch ex As Exception
            Finally
            End Try
        End Sub
        Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
            If UscExpeDeResolucion.objEntExpedienteTempoCol.Count = 0 Then
                TabControl1.SelectedIndex = 0
            End If
        End Sub

        Private Sub frmResolLibertad_v2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

End Namespace