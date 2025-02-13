Namespace Registro.Resoluciones
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
        Public Property _TrasladoMov As Integer = -1
        Public Property _RegionIngreso As Integer = -1
        Public Property _PenalIngreso As Integer = -1
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
            Me._FechaMovimiento = UscMovimientoDetalle21.FechaRegistroMovimiento
            Me._MovimientoMov = UscMovimientoDetalle21._MovimientoMotivo
            Me._TrasladoMov = UscMovimientoDetalle21._MovimientoMotivoTraslado

            Me._RegionIngreso = UscMovimientoDetalle21._RegionIngreso
            Me._PenalIngreso = UscMovimientoDetalle21._PenalIngreso
            With obDocJud
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                .DocumentoSubTipoId = Me._DocumentoSubtipo
                .MovimientoMotivoId = Me._MovimientoMov
                .FechaMovimiento = Me._FechaMovimiento
                .RegionOrigenId = Me._RegionIngreso
                .PenalOrigenId = Me._PenalIngreso
                .FlagTransferenciaSede = Me.FlagTransferSede

                Select Case Me.UscMovimientoDetalle21._getIdMovimientoMotivo

                    Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado

                        .DocumentoSubTipoId = Me._DocumentoSubtipo
                        .MovimientoMotivoId = Me._TrasladoMov

                    Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva

                        .ProlonDetencionFechIni = UscPeriodoDetencion1.ProlonDetencionFechIni
                        .ProlonDetencionFechFin = UscPeriodoDetencion1.ProlonDetencionFechFin
                        .ProlonDetencionTipoUnidad = UscPeriodoDetencion1.ProlonDetencionTipoUnidad
                        .ProlonDetencionValor = UscPeriodoDetencion1.ProlonDetencionValor

                    Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoSentencia,
                         Type.Enumeracion.Movimiento.EnumMovMotivo.Inimputable,
                         Type.Enumeracion.Movimiento.EnumMovMotivo.PosibleInimputable

                        .SentenciaTotalAnios = IIf(UscExpeDeResolucionIng1.TotalAnios.Length = 0, 0, UscExpeDeResolucionIng1.TotalAnios)
                        .SentenciaTotalMeses = IIf(UscExpeDeResolucionIng1.TotalMeses.Length = 0, 0, UscExpeDeResolucionIng1.TotalMeses)
                        .SentenciaTotalDias = IIf(UscExpeDeResolucionIng1.TotalDias.Length = 0, 0, UscExpeDeResolucionIng1.TotalDias)
                End Select
            End With

            Me._Codigo = uscResolIngreso.AGrabar(obDocJud)
            If Me._Codigo = -2 Then
                Return -2
            End If
            UscExpeDeResolucionIng1._Grabar(Me._Codigo, Me._blnNuevoRegistro, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, UscMovimientoDetalle21._MovimientoMotivo)

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia Then
                UscMovimientoDetalle21.AGrabar(Me._Codigo, uscResolIngreso.objEnt)
            End If
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
                ._MotivoIngreso = UscMovimientoDetalle21._MovimientoMotivo
                If ._MotivoIngreso < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar un motivo de ingreso.")
                    UscMovimientoDetalle21.CbbMovimientoMotivoFocus()
                    Exit Sub
                End If
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
                UscExpeDeResolucionIng1.ActualizarDatosTipoInimputable(UscMovimientoDetalle21._MovimientoMotivo, -1)

            End If

        End Sub
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)

            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then

                Else
                    ._Codigo = objEnt.Codigo
                    ._TipoDocumento = objEnt.DocumentoTipoID
                    ._TemporalNuevo = False 'temporal edidato
                    objEnt.Nuevo = False
                End If
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
                .btnAceptar.Enabled = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, True, False)
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
            With UscMovimientoDetalle21
                ._TipoLicencia = Me._TipoLicencia
                ._blnNuevo = True
                ._InternoID = Me._InternoID
                ._IngresoID = Me._InternoIngresoID
                ._IngresoInpeID = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                ._MovimientoTipo2 = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                ._MovimientoMotivoTraslado = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                ._DocumJudicialD = Me._Codigo
                .Visible = Not (Me._Documento_sin_mov)
                If .Visible = True Then
                    Dim objBssMov As New Bussines.Registro.InternoMovimiento
                    Dim objMov As New Entity.Registro.InternoMovimiento
                    objMov.InternoID = Me._InternoID
                    objMov.IngresoID = Me._InternoIngresoID
                    objMov.MovimientoMotivoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                    objMov.DocumJudicialID = Me._Codigo
                    objMov = objBssMov.Listar(objMov)
                    If Me._Codigo < 1 Or (_Codigo > 0 And objMov.Codigo < 1) Then
                        ._FechaMovimiento = objMov.Fecha
                        ._LoadUsc()
                        Me.blnValor = True
                        ._blnValor = True
                    Else
                        Me._Documento_sin_mov = True
                        ._Codigo = Me._Codigo
                        ._LoadUsc()
                    End If
                End If
            End With
            With UscPeriodoDetencion1
                ._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._LoadUsc()
                If Me._Codigo > 0 Then
                    .ProlonDetencionFechIni = uscResolIngreso.ProlonDetencionFechIni
                    .ProlonDetencionFechFin = uscResolIngreso.ProlonDetencionFechFin
                    .ProlonDetencionTipoUnidad = uscResolIngreso.ProlonDetencionUnidad
                    .ProlonDetencionValor = uscResolIngreso.ProlonDetencionCantidad
                End If
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
                ._SubTipo = Me._Subtipo
                .TotalAnios = uscResolIngreso.TotalAnios
                .TotalMeses = uscResolIngreso.TotalMeses
                .TotalDias = uscResolIngreso.TotalDias
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                .PeriodoCondenaVisible(Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, UscMovimientoDetalle21._MovimientoMotivo)
                ._ListarExpediente(_Codigo, False)
            End With
            With UscMovimientoDetalle21
                If Me.UscExpeDeResolucionIng1.intReferenciado > 0 Then
                    .OcultarControlesporReferencia()
                End If
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
            UscMovimientoDetalle21._TipoLicencia = Me._TipoLicencia
            uscResolIngreso._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucionIng1._TipoLicencia = Me._TipoLicencia

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If uscResolIngreso.Validar = True Then
                If Me._Documento_sin_mov = True Then
                    If UscMovimientoDetalle21.ValidarNuevo = True Then
                        If UscExpeDeResolucionIng1.Validar(Me._DocumentoSubtipo, Me.UscMovimientoDetalle21._getIdMovimientoMotivo) = True Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(UscExpeDeResolucionIng1.strMensaje) = DialogResult.Yes Then
                                If AGrabar() > -1 Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                Else
                    If UscMovimientoDetalle21.Validar = True Then
                        If UscExpeDeResolucionIng1.Validar(Me._DocumentoSubtipo, Me.UscMovimientoDetalle21._getIdMovimientoMotivo) = True Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(UscExpeDeResolucionIng1.strMensaje) = DialogResult.Yes Then
                                If AGrabar() > -1 Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
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

        Private Sub UscExpeDeResolucion__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucionIng1._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucionIng1._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub


        Private Sub InformaciónReferencialToolStripMenuItem_Click(sender As Object, e As EventArgs)
            UscExpeDeResolucionIng1.Visible = False
        End Sub
        Private Sub ExpedientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
            UscExpeDeResolucionIng1.Visible = True
        End Sub

        Private Sub UscMovimientoDetalle21_clicK_MostrarControlesAux(MotivoId As Integer, uscVisible As Boolean, menuVisible As Boolean) Handles UscMovimientoDetalle21.clicK_MostrarControlesAux

            Select Case MotivoId
                Case 1
                    Me._Subtipo = 26
                    Me._DocumentoSubtipo = 26

                Case 2
                    Me._Subtipo = 27
                    Me._DocumentoSubtipo = 27

                Case 3
                    Me._Subtipo = 28
                    Me._DocumentoSubtipo = 28
                    ExpedientesToolStripMenuItem_Click(Nothing, Nothing)
                Case 113
                    Me._Subtipo = 29
                    Me._DocumentoSubtipo = 29

                Case 115
                    Me._Subtipo = 38
                    Me._DocumentoSubtipo = 38

                Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoSentencia
                    Me._DocumentoSubtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoSentencia

                Case Else
                    Me._DocumentoSubtipo = -1
                    Me._Subtipo = -1
            End Select

            UscExpeDeResolucionIng1._mostrarBotonInimputables(MotivoId)
            UscPeriodoDetencion1.Visible = uscVisible

            If Me._DocumentoSubtipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado Then
                UscExpeDeResolucionIng1.PeriodoCondenaVisible(Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, MotivoId)
            Else
                UscExpeDeResolucionIng1.PeriodoCondenaVisible(Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso, MotivoId)
            End If

            uscResolIngreso.CargarEiquetasTraslado(Me._DocumentoSubtipo)
            UscExpeDeResolucionIng1.Visible = True

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

        Private Sub UscExpeDeResolucionIng1__Click_PeriodoCondena_Agregar() Handles UscExpeDeResolucionIng1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscExpeDeResolucionIng1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub

        Private Sub uscResolIngreso_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub UscInimputables1__click_MostrarPeriodocondena(blnValor As Boolean)
            If UscMovimientoDetalle21._MovimientoMotivo <> Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoSentencia Then
                UscExpeDeResolucionIng1.PeriodoCondenaVisible(blnValor)
            End If
        End Sub

        ' _Click_btnDatos_

        'Private Sub UscMovimientoDetalle21_clicK_MostrarInimputables(blnValor As Boolean) Handles UscMovimientoDetalle21.clicK_MostrarInimputables

        '    Dim frm As New Registro.frmListaEstablecimientosInimputables
        '    frm._idCentroSaludMental = UscMovimientoDetalle21.EstablecimientomentalId
        '    frm._idTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
        '    frm._blnReferenciado = IIf(UscExpeDeResolucionIng1.intReferenciado = 0, False, True)
        '    If frm.ShowDialog = DialogResult.OK Then
        '        UscMovimientoDetalle21.EstablecimientomentalId = frm.getIdCentroSaludMental
        '    End If

        'End Sub
    End Class

End Namespace