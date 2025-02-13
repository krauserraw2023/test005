Namespace Registro.RegionLima.Resoluciones
    Public Class frmResolIngreso
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
#Region "Propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoID() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
        Public Property _TipoFormulario As Integer = -1
        Public Property _DocumentoSubtipo As Integer = -1
        Public Property _Subtipo As Integer = -1

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
        Public Property _FechaMovimiento() As Long = 0
        Public Property _MovimientoMov As Integer = -1
        Public Property _RegionDestino As Integer = -1
        Public Property _PenalDestino As Integer = -1
        Public Property _Documento_sin_mov As Boolean = False
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
#Region "accion"
        Private Function Validar() As Boolean
            If UscExpeDeResolucionIng1._Grilla_NroRegistroExpediente < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de ingreso debe tener por lo menos un expediente")
                Return False
            End If
            If UscExpeDeResolucionIng1._Grilla_NroRegistroDelito < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente debe tener por lo menos un delito")
                Return False
            End If
            Return True
        End Function
        Private Function AGrabar() As Integer

            Dim obDocJud As New Entity.Registro.DocumentoJudicial

            Me._blnNuevoRegistro = IIf(Me._Codigo < 1, True, False)
            Me._MovimientoMov = UscResolucionesDetalle1._MovimientoMotivo
            Me._RegionDestino = UscResolucionesDetalle1._RegionDestino
            Me._PenalDestino = UscResolucionesDetalle1._PenalDestino
            With obDocJud
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                .DocumentoSubTipoId = Me._DocumentoSubtipo
                .MovimientoMotivoId = Me._MovimientoMov
                .RegionDestinoId = Me._RegionDestino
                .PenalDestinoid = Me._PenalDestino
                .FlagTransferenciaSede = Me.FlagTransferSede
                .SentenciaTotalAnios = If(UscExpeDeResolucionIng1.TotalAnios = "", 0, UscExpeDeResolucionIng1.TotalAnios)
                .SentenciaTotalMeses = IIf(UscExpeDeResolucionIng1.TotalMeses = "", 0, UscExpeDeResolucionIng1.TotalMeses)
                .SentenciaTotalDias = IIf(UscExpeDeResolucionIng1.TotalDias = "", 0, UscExpeDeResolucionIng1.TotalDias)
                '.EstablecimientomentalId = Me.UscResolucionesDetalle1._EstablecimientomentalId
            End With
            Me._Codigo = uscResolIngreso.AGrabar(obDocJud)

            If Me._Codigo < 1 Then
                Return Me._Codigo
            End If
            'RESOLUCION NUEVO
            UscExpeDeResolucionIng1._Grabar(Me._Codigo, Me._blnNuevoRegistro, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, Me._MovimientoMov)
            UscResolucionesDetalle1.AGrabar()
            Return Me._Codigo
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
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucionIng1.objEntExpedienteTempoCol
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucionIng1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With

            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                With frm2
                    ._objEntExpedienteCol = UscExpeDeResolucionIng1.objEntExpedienteTempoCol
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoID
                        ._objEntExpediente.Nuevo = True
                        Me.UscExpeDeResolucionIng1._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)

            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    objEnt.Nuevo = False
                End If
                ._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._objEntExpediente = objEnt
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscExpeDeResolucionIng1._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
                End If
            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._InternoIngresoID
                    ._ExpedienteID = UscExpeDeResolucionIng1._GrillaExpedienteID
                    ._ExpedienteItem = UscExpeDeResolucionIng1._GrillaItemExpediente
                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscExpeDeResolucionIng1._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelCol
                .UscComboDelito1._objEntDelitoCol = objEntDelCol
                ._DelitoItem = UscExpeDeResolucionIng1._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscExpeDeResolucionIng1._GrillaItemExpediente
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscExpeDeResolucionIng1._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol, ._objEntAgravCol_Ind)
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
                ._objEntAgraviadoCol = UscExpeDeResolucionIng1.objEntAgraviadoTempoColGrilla
                ._NuevoGrabar = Nuevo
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    With ._objEntAgraviado
                        .ExpedienteID = UscExpeDeResolucionIng1._GrillaExpedienteID
                        .DelitoID = UscExpeDeResolucionIng1._GrillaDelitoID
                        .ExpedienteItem = UscExpeDeResolucionIng1._GrillaItemExpediente
                        .DelitoItem = UscExpeDeResolucionIng1._GrillaItemDelito
                    End With
                    Me.UscExpeDeResolucionIng1._Temporal_GrabarAgraviado(._objEntAgraviado)
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
                ._Titulo = UscExpeDeResolucionIng1._TituloPeriodo
                ' ._objEntExpedienteTempoCol = UscExpeDeResolucion1.objEntExpedienteTempoCol
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    UscExpeDeResolucionIng1._Temporal_GrabarPeriodoCondena(._EntPeriodoCondena)
                End If
            End With
        End Sub
#End Region
#Region "otros"
        Public blnValor As Boolean = False
        Private Sub ValoresxDefault()
            With uscResolIngreso
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                .DocumentoSubTipo = Me._DocumentoSubtipo
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With

            With UscResolucionesDetalle1
                ._TipoLicencia = Me._TipoLicencia
                ._blnNuevo = True
                ._InternoID = Me._InternoID
                ._IngresoInpeID = Me._InternoIngresoInpeId

                If Me._Codigo = -1 Then 'cuando es nuevo para el penal destino cargar del documento de clasificacion
                    Dim ficFinal As Entity.Clasificacion.InternoClasificacion.InternoFicha
                    ficFinal = (New Bussines.Clasificacion.InternoClasificacion.InternoFicha_BL).UltimaFichaFinalClasificadoConOficio(Me._InternoIngresoInpeId)
                    If Not ficFinal Is Nothing Then
                        .PenalDestinoID = ficFinal.PenalDestinoId
                    Else
                        .PenalDestinoID = uscResolIngreso.PenalDestino
                    End If
                Else
                    .PenalDestinoID = uscResolIngreso.PenalDestino
                End If

                ._MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                ._MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                ._MovimientoMotivoId = uscResolIngreso._MovimientoMotivo  '- 1 ' Type.Enumeracion.Movimiento.EnumMovMotivo.NuevoIngreso
                ._DocumJudicialD = Me._Codigo
                ._LoadUsc()
                ._EstablecimientomentalId = uscResolIngreso.EstablecimentomentalId
            End With

            With UscExpeDeResolucionIng1
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._InternoID = Me._InternoID
                ._InternoIngresoID = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._TipoLicencia = Me._TipoLicencia
                ._DocumentoJudicialID = _Codigo
                ._SubTipo = Me._DocumentoSubtipo
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                .PeriodoCondenaVisible(Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, UscResolucionesDetalle1._MovimientoMotivo)
                ._ListarExpediente(_Codigo, False)
            End With

        End Sub
        Private Sub MostrarExpediente(ByVal Nuevo As Boolean)
            Dim EntExpe As Entity.Registro.Expediente
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            frm.btnOk.Visible = False
            If _blnNuevoRegistro = True Then 'resolucion nuevo
                If Nuevo = True Then
                    EntExpe = New Entity.Registro.Expediente
                    EntExpe.InternoID = Me._InternoID
                    EntExpe.IngresoID = Me._InternoIngresoID
                    EntExpe._RegionId = Me._RegionID
                    EntExpe._PenalId = Me._PenalID
                Else
                    'EntExpe = UscExpeDeResolucion._EntExpediente
                End If
            Else
                'EntExpe = UscExpeDeResolucion._EntExpediente
                'frm.Expediente = EntExpe
                'frm.ResolucionNuevo = False
                'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                'End If
            End If

        End Sub
        Private Sub PeriodoCondena_visible(MotivoId As Integer)

            Me._DocumentoSubtipo = -1

            If MotivoId = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoSentencia Then

                If Me._blnNuevoRegistro = True Then
                    Me._DocumentoSubtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoSentencia
                End If

                UscExpeDeResolucionIng1.PeriodoCondenaVisible(Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, MotivoId)
            Else

                UscExpeDeResolucionIng1.PeriodoCondenaVisible(Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, MotivoId)
            End If

            UscExpeDeResolucionIng1._mostrarBotonInimputables(MotivoId)

        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlGrabar.Visible = Me._FormEscritura
        End Sub
#End Region

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolIngreso_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If uscResolIngreso.Validar = True Then
                If UscResolucionesDetalle1.Validar = True Then
                    If UscExpeDeResolucionIng1.Validar(Me._DocumentoSubtipo, -1) = True Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(UscExpeDeResolucionIng1.strMensaje) = DialogResult.Yes Then
                            If AGrabar() > -1 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub uscResolIngreso__Click_btnDatos() Handles uscResolIngreso._Click_btnDatos

            With UscExpeDeResolucionIng1
                If ._Grilla_NroRegistroExpediente > 0 Then
                    If .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID = 1 Then
                        Me.uscResolIngreso._TipoAutoridadJudicialID = .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID
                        Me.uscResolIngreso._DistritoJudicialID = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialID
                        Me.uscResolIngreso._DistritoJudicialNombre = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialNombre
                        Me.uscResolIngreso._SalaJuzgado = .objEntExpedienteTempoCol.Item(0).SalaJudicialID
                        Me.uscResolIngreso._Juez = .objEntExpedienteTempoCol.Item(0).ExpedienteJuez
                        Me.uscResolIngreso._Secretario = .objEntExpedienteTempoCol.Item(0).ExpedienteSecretario
                        Me.uscResolIngreso._OtraAutoridadNombre = .objEntExpedienteTempoCol.Item(0).AutoridadOtro
                        Me.uscResolIngreso._OtraAutoridadCargo = .objEntExpedienteTempoCol.Item(0).AutoridadOtroCargo
                    Else
                        If .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID = -1 Then
                            If .objEntExpedienteTempoCol.Item(0).SalaJudicialID > 0 Then
                                Me.uscResolIngreso._TipoAutoridadJudicialID = 1
                                Me.uscResolIngreso._DistritoJudicialID = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialID
                                Me.uscResolIngreso._DistritoJudicialNombre = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialNombre
                                Me.uscResolIngreso._SalaJuzgado = .objEntExpedienteTempoCol.Item(0).SalaJudicialID
                                Me.uscResolIngreso._Juez = .objEntExpedienteTempoCol.Item(0).ExpedienteJuez
                                Me.uscResolIngreso._Secretario = .objEntExpedienteTempoCol.Item(0).ExpedienteSecretario
                            Else
                                Me.uscResolIngreso._DistritoJudicialID = 2
                                Me.uscResolIngreso._DistritoJudicialNombre = ""
                                Me.uscResolIngreso._SalaJuzgado = -1
                                Me.uscResolIngreso._SalaJuzgadoNombre = ""
                                Me.uscResolIngreso._Juez = ""
                                Me.uscResolIngreso._Secretario = ""
                                Me.uscResolIngreso._OtraAutoridadNombre = .objEntExpedienteTempoCol.Item(0).AutoridadOtro
                                Me.uscResolIngreso._OtraAutoridadCargo = .objEntExpedienteTempoCol.Item(0).AutoridadOtroCargo
                            End If
                        Else
                            Me.uscResolIngreso._TipoAutoridadJudicialID = .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID
                            Me.uscResolIngreso._DistritoJudicialID = -1
                            Me.uscResolIngreso._DistritoJudicialNombre = ""
                            Me.uscResolIngreso._SalaJuzgado = -1
                            Me.uscResolIngreso._SalaJuzgadoNombre = ""
                            Me.uscResolIngreso._Juez = ""
                            Me.uscResolIngreso._Secretario = ""
                            Me.uscResolIngreso._OtraAutoridadNombre = .objEntExpedienteTempoCol.Item(0).AutoridadOtro
                            Me.uscResolIngreso._OtraAutoridadCargo = .objEntExpedienteTempoCol.Item(0).AutoridadOtroCargo
                        End If

                    End If

                End If

            End With
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Expediente_Agregar() Handles UscExpeDeResolucionIng1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscExpeDeResolucionIng1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol) Handles UscExpeDeResolucionIng1._Click_Delito_Agregar
            For i As Integer = 0 To objEntDelitoTempoColGrilla.Count - 1
                objEntDelitoTempoColGrilla.internoDelito(i).Auxiliar = False
            Next
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoTempoColGrilla)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucionIng1._Click_Delito_Editar

            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)

        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucionIng1._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucionIng1._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscResolucionesDetalle1__Click_Seleccionar_Motivo(MotivoId As Integer) Handles UscResolucionesDetalle1._Click_Seleccionar_Motivo
            PeriodoCondena_visible(MotivoId)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_PeriodoCondena_Agregar() Handles UscExpeDeResolucionIng1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscExpeDeResolucionIng1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub



        'Private Sub UscResolucionesDetalle1_clicK_MostrarInimputables(blnValor As Boolean) Handles UscResolucionesDetalle1.clicK_MostrarInimputables

        '    'Dim frm As New Registro.frmListaEstablecimientosInimputables
        '    'frm._idCentroSaludMental = UscResolucionesDetalle1._EstablecimientomentalId
        '    'frm._idTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
        '    'frm._blnReferenciado = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, False, True)
        '    'frm._idTipoLicencia = Me._TipoLicencia

        '    'If frm.ShowDialog = DialogResult.OK Then
        '    '    UscResolucionesDetalle1._EstablecimientomentalId = frm.cbbEstablecimientomental.SelectedValue
        '    'End If

        'End Sub
    End Class

End Namespace