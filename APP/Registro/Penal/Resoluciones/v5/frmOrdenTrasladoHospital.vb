Option Explicit On
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class frmOrdenTrasladoHospital
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
#End Region
#Region "Accion"
        Private Function AGrabar() As Integer

            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            objDoc.MovimientoMotivoId = UscExpeDeResolucion.EntMovimiento.MovimientoMotivoID
            'objDoc.EstablecimientomentalId = UscExpeDeResolucion.EntMovimiento.EstablecimientomentalID

            '/*grabar tiempo de condena*/
            With UscExpeDeResolucion
                objDoc.SentenciaTotalAnios = If(._TotalAnhos.Length = 0, "0", ._TotalAnhos)
                objDoc.SentenciaTotalMeses = If(._TotalMes.Length = 0, "0", ._TotalMes)
                objDoc.SentenciaTotalDias = If(._TotalDias.Length = 0, "0", ._TotalDias)
                objDoc.SentenciaCadenaPerpetua = Me.UscExpeDeResolucion._CadenaPerpetua
            End With

            'centro de salud mental, origen/destino
            objDoc.PenalOtroOrigenNom = Me.UscExpeDeResolucion._getCentroSaludMentalNombre
            objDoc.PenalDestinoOtroNom = Me.UscExpeDeResolucion._getCentroSaludMentalNombre

            Me._Codigo = UscResolAclaratoriaExpe1.AGrabar(objDoc)
            UscExpeDeResolucion._FechaMovimiento = UscResolAclaratoriaExpe1.FechaMovimiento
            If Me._Codigo < 1 Then Return Me._Codigo
            'RESOLUCION NUEVO
            UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
            UscExpeDeResolucion._Grabar(Me._Codigo, _blnNuevoRegistro, -1, Me._TipoResolucion)

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
            End With
            If Me._Codigo < 1 Then
                'NUEVO
            Else
                UscQueda1.GrabarQueda(Me._Codigo)
            End If

            '******************+++++++++++++++* Eliminar Movimiento ****************************************
            If (Me._TipoLicencia <> 5) Then
                UscQueda1.eliminar_movimiento_libertad("aut", "del_mov", Me._Codigo, Me._InternoId, Me._InternoIngresoId)
            End If

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
#Region "movimientos"
        Public Sub _Listar_Movimientos()

            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then dgwGrilla.Columns("col_pen_nom").Visible = False
            If Me._InternoId < 1 Then Exit Sub

            Dim objEntColM As Entity.Registro.InternoMovimientoCol '= Nothing
            Dim objBssM As Bussines.Registro.InternoMovimiento
            Dim objEntM As New Entity.Registro.InternoMovimiento
            objEntColM = New Entity.Registro.InternoMovimientoCol
            objBssM = New Bussines.Registro.InternoMovimiento
            objEntM.InternoID = Me._InternoId
            objEntM.IngresoID = Me._InternoIngresoId

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta

                    objEntM.IngresoID = Me._InternoIngresoId
                    objEntM._PenalID = Me._PenalID
                    objEntM.IngresoInpeId = Me._InternoIngresoId

                Case enmTipoLicencia.RegionLimaMetropolitana

                    objEntM.IngresoID = -1
                    objEntM.IngresoInpeId = Me._InternoIngresoId

                Case enmTipoLicencia.PenalLimaMetropolitana
                    objEntM.IngresoID = -1
                    objEntM.IngresoInpeId = Me._InternoIngresoId
            End Select

            Dim objCol As New Entity.Registro.InternoMovimientoCol
            Dim objcondCol As New Entity.Registro.InternoMovimientoCol

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEntM.TipoAutoridadJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota
                objEntColM = objBssM.ListarGrilla_LM(objEntM)
            Else
                objEntM.TipoAutoridadJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota
                objEntColM = objBssM.ListarGrilla(objEntM)
            End If

            For Each obj As Entity.Registro.InternoMovimiento In objEntColM
                If obj.MovimientoTipoID = 6 Or obj.MovimientoTipoID = 8 Then
                    objcondCol.Add(obj)
                Else
                    objCol.Add(obj)
                End If
            Next

            With Me.dgwGrilla
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor
                .AllowUserToResizeRows = False
                .AutoGenerateColumns = False
                .DataSource = objCol
                '''''''''''''''''''' Me.GrillaCount = .RowCount
                Me.dgwGrilla.ClearSelection()
            End With

        End Sub

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
                        Me.UscResolAclaratoriaExpe1.MovimientoMotivoId = .objEntExpedienteTempoCol.Expediente(0).MotivoIngresoID

                        UscExpeDeResolucion._TotalAnhos = .objEntExpedienteTempoCol.Item(0).SentenciaAnio
                        UscExpeDeResolucion._TotalMes = .objEntExpedienteTempoCol.Item(0).SentenciaMes
                        UscExpeDeResolucion._TotalDias = .objEntExpedienteTempoCol.Item(0).SentenciaDia
                        UscExpeDeResolucion._CadenaPerpetua = .objEntExpedienteTempoCol.Item(0).SentenciaCadenaPerpetua
                        UscExpeDeResolucion.Listar_PeriodoCondena(.objEntExpedienteTempoCol.Item(0).SentenciaFechaInicio, .objEntExpedienteTempoCol.Item(0).SentenciaFechaFinal)

                    End If
                End If
            End With

            If blnNuevoExpediente = True Then
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Or
                    Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No existe procesos inimputables ó posibles inimputables")
                    Exit Sub
                End If
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
                ._TipoDocumento = Me._TipoResolucion
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
                ._TipoDocumento = Me._TipoResolucion
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
                ._TipoDocumento = Me._TipoResolucion
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
        Private Sub FRM_BusquedaSalasJuzgados()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscResolAclaratoriaExpe1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UscResolAclaratoriaExpe1.DistritoJudicial = ._DistritoJudicialID
                    UscResolAclaratoriaExpe1.SalaJuzgado = ._GrillaSalaID

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
        Private Sub FrmBuscarSalaJuzgado()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscResolAclaratoriaExpe1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UscResolAclaratoriaExpe1.DistritoJudicial = ._DistritoJudicialID
                    UscResolAclaratoriaExpe1.SalaJuzgado = ._GrillaSalaID

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

            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                Me.Text = "Retorno de Traslado"
                lblTitulo.Text = "RETORNO DE HOSPITAL DE SALUD MENTAL"
            End If

            frmLoad = New Load.frmLoad
            Application.DoEvents()
            frmLoad.Show()

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
            With UscExpeDeResolucion
                ._TipoResolucion = Me._TipoResolucion
                ._InternoID = Me._InternoId
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._DocumentoJudicialID = _Codigo
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(UscResolAclaratoriaExpe1.objEnt, False)
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
                End With
            End If
            UscQueda1._fechaejecucionMov = UscResolAclaratoriaExpe1._fechaejecucionMov


            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                ' cargar movimientos de intentos de envio a hospital mental
                _Listar_Movimientos()
            End If

            If UscResolAclaratoriaExpe1.Estado_Documento_Judicial = 3 Then
                Me.UscExpeDeResolucion.Estado_Documento_Judicial_exp = 3
            End If

            frmLoad.Refresh()
            frmLoad.Close()
        End Sub
        Private Sub Usuario_Permiso()
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                If Me._TipoLicencia = 4 Then
                    Me.PnlBotonesGrabar.Visible = True
                Else
                    Me.PnlBotonesGrabar.Visible = Me._FormEscritura
                End If
                Me.PnlBotones.Visible = True
            Else
                Me.PnlBotonesGrabar.Visible = Me._FormEscritura
                Me.PnlBotones.Visible = True
            End If
        End Sub

#End Region

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            ' /*Este codigo debe ser igual a libertad*/
            If UscResolAclaratoriaExpe1.Validar = True Then
                If UscExpeDeResolucion.Validar(-1) = True Then
                    If Me._Documento_sin_mov = False Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(UscExpeDeResolucion.strMensaje) = DialogResult.Yes Then
                            If AGrabar() > -1 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        Else
                            UscExpeDeResolucion.grabarMovimientoLibertad = False
                            UscExpeDeResolucion.Orden_ = False
                        End If
                    Else
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(UscExpeDeResolucion.strMensaje) = DialogResult.Yes Then
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

        Private Sub UscExpeDeResolucion__Click_AgregarExpediente() Handles UscExpeDeResolucion._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscExpeDeResolucion._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub
        Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelCol)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        End Sub
        Public OrdenMovimiento As Boolean = False

        Private Sub UscExpeDeResolucion1__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscResolAclaratoriaExpe1__Click_VerFormulario() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaSalaJuzgado

            FrmBuscarSalaJuzgado()

        End Sub

        Private Sub UscExpeDeResolucion__click_VerLibertades()
            Dim frm As New Registro.Expediente.v5.frmListarlibertad
            frm._LibertadTipoID = Me.UscExpeDeResolucion._GrillaLibertadTipoID
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscExpeDeResolucion.ActualizarLibertad(frm._LibertadTipoID, frm._LibertadTipoNom)
            End If
        End Sub

        'Private Sub UscExpeDeResolucion__click_VerEstablecimientoMental() Handles UscExpeDeResolucion._click_VerEstablecimientoMental

        '    Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
        '    frm._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
        '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '        UscExpeDeResolucion.ActualizarDatosTipoInimputable(-1, "", frm._ResolucionTipoID, frm._ResolucionTipoNom)
        '        UscResolAclaratoriaExpe1.EstablecimientomentalId = frm._ResolucionTipoID
        '    End If

        'End Sub

        'Private Sub UscExpeDeResolucion__click_VerInimputable() Handles UscExpeDeResolucion._click_VerInimputable
        '    Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
        '    frm._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental
        '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '        UscExpeDeResolucion.ActualizarInimputables(frm._ResolucionTipoID, frm._ResolucionTipoNom)
        '    End If
        'End Sub

        Private Sub frmOrdenTrasladoHospital_Load(sender As Object, e As EventArgs) Handles Me.Load

        End Sub

        Private Sub UscResolAclaratoriaExpe1__Click_FrmBusquedaAutoridadJudicial() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial()
        End Sub

        Private Sub UscResolAclaratoriaExpe1_Load(sender As Object, e As EventArgs) Handles UscResolAclaratoriaExpe1.Load

        End Sub

        Private Sub UscExpeDeResolucion__Click_PeriodoCondena_Agregar() Handles UscExpeDeResolucion._Click_PeriodoCondena_Agregar

            FRM_MantPeriodoSentencia(True, Nothing)

        End Sub

        Private Sub UscExpeDeResolucion__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscExpeDeResolucion._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub dgwGrilla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwGrilla.CellFormatting
            With Me.dgwGrilla
                Select Case e.ColumnIndex
                    Case .Columns("col_mov_fec").Index, .Columns("col_mov_fec_doc").Index, .Columns("col_mov_fec_rec").Index
                        If IsNumeric(e.Value) And e.Value > 1 Then
                            'e.Value = Legolas.Components.FechaHora.FechaDate(e.Value, True)
                            e.Value = Legolas.Components.FechaHora.FechaString(e.Value, True)
                        Else
                            e.Value = ""
                        End If
                End Select
            End With
        End Sub

        Private Sub UscQueda1__Click_chkQueda() Handles UscQueda1._Click_chkQueda
            With UscQueda1
                If ._chkqueda_no = True Then
                    If ._Cantidad_queda > 0 Or .OtrosProcesos > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La opción no está disponible, porque el interno " + Chr(13) +
                                                                               "cuenta con procesos pendientes.")
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
    End Class
End Namespace