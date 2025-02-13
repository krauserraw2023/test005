Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class frmResolDetencionReferenciado
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private ObjDocumentoOrig As New Entity.Registro.DocumentoJudicial
        Private ObjExpedienteOrig As New Entity.Registro.Expediente
#Region "propiedades"
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoId As Integer = -1
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
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
        Public Property _TipoResolucion As Integer = -1

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
        Private Function AGrabar() As Integer
            Dim objDocJudTmp As Entity.Registro.DocumentoJudicial
            Dim obExpeNew As New Entity.Registro.Expediente
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    objDocJudTmp = uscResDetencion.AGrabar_LM()
                Case Else
                    objDocJudTmp = uscResDetencion.AGrabar() 'retorna objeto resolucion de detencion
            End Select
            If objDocJudTmp Is Nothing Then Return -1

            Me._Codigo = objDocJudTmp.Codigo
            Dim intIdExpe As Integer = -1
            Dim ExpPadreId As Integer = -1
            If Me._blnNuevoRegistro = True Then 'RESOLUCION NUEVO----->obtener datos de la resolucion hacia el nuevo mandato de detencion
                If Me.ckbExpediente.Checked = False Then

                    obExpeNew = CargarExpedienteCabecera()
                Else
                    obExpeNew = UscExpeDeResolucion1.objEntExpedienteTempoCol.Expediente(0)
                End If
                ExpPadreId = obExpeNew.Codigo
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        obExpeNew.CreaDocJudicialId = Me._Codigo
                        obExpeNew.Codigo = -1
                        obExpeNew.FlagTransferenciaSede = Me.FlagTransferSede
                        Dim bssExp As New Bussines.Registro.Expediente
                        intIdExpe = bssExp.Grabar_LM(obExpeNew)

                        If Me.ckbExpediente.Checked = True Then
                            GrabarExpedientePadre_Referenciado(ExpPadreId, intIdExpe)
                        End If
                    Case Else
                        obExpeNew.CreaDocJudicialId = Me._Codigo
                        obExpeNew.Codigo = -1
                        obExpeNew.FlagTransferenciaSede = Me.FlagTransferSede
                        Dim bssExp As New Bussines.Registro.Expediente
                        obExpeNew.IngresoID = Me._InternoIngresoId
                        intIdExpe = (New Bussines.Registro.Expediente).Grabar(obExpeNew)

                        If Me.ckbExpediente.Checked = True Then
                            GrabarExpedientePadre_Referenciado(ExpPadreId, intIdExpe)
                        End If
                End Select
            Else  '----->obtener datos de la resolucion hacia el nuevo mandato de detencion'--Evaluar el expediente 
                obExpeNew = UscExpeDeResolucion1.objEntExpedienteTempoCol.Item(0)
                ExpPadreId = obExpeNew.Codigo
                If ckbExpediente.Checked = False Then
                    With obExpeNew
                        .FlagTransferenciaSede = Me.FlagTransferSede
                        .AutoridadJudicialID = objDocJudTmp.DistritoJudicial
                        .SalaJudicialID = objDocJudTmp.SalaJuzgado
                        .ExpedienteJuez = objDocJudTmp.JuezNombre
                        .ExpedienteSecretario = objDocJudTmp.SecretarioNombre
                        .ExpedienteNumero = objDocJudTmp.DocumentoNumero
                        .ExpedienteFechaDocRecepcion = objDocJudTmp.DocumentoFechaRecepcion
                        .ExpedienteFecha = objDocJudTmp.DocumentoFecha
                        .Flagrancia = objDocJudTmp.Flagrancia
                        .Observacion = objDocJudTmp.Observacion
                    End With
                Else
                    If ObjExpedienteOrig.Codigo <> obExpeNew.Codigo Then
                        obExpeNew.Codigo = -1
                        obExpeNew.CreaDocJudicialId = Me._Codigo
                        _blnNuevoRegistro = True
                    End If
                End If
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        intIdExpe = (New Bussines.Registro.Expediente).Grabar_LM(obExpeNew) 'guardar obExpeNew en BD y retornar en intIdExpe
                    Case Else
                        intIdExpe = (New Bussines.Registro.Expediente).Grabar(obExpeNew) 'guardar obExpeNew en BD y retornar en intIdExpe
                End Select
                If _blnNuevoRegistro = True Then
                    GrabarExpedientePadre_Referenciado(ExpPadreId, intIdExpe)
                End If
            End If
            UscExpeDeResolucion1.AGrabar(Me._Codigo, intIdExpe, _blnNuevoRegistro)

            Return Me._Codigo
        End Function
        Private Function GrabarExpedientePadre_Referenciado(ExpedientePadreId As Integer, intIdExpe As Integer) As Integer
            Dim bssExp As New Bussines.Registro.Expediente
            bssExp.GrabarEstadoVisibilidad_LM(ExpedientePadreId, 0)
            Dim objExpPad As New Entity.Registro.InternoExpedientePadre
            objExpPad.InternoID = Me._InternoId
            objExpPad.IngresoID = Me._InternoIngresoId
            objExpPad.IngresoInpeId = Me._InternoIngresoInpeId
            objExpPad._PenalId = Me._PenalID
            objExpPad._RegionId = Me._RegionID
            objExpPad.DocJudicialID = Me._Codigo
            objExpPad.InternoExpedienteId = intIdExpe
            objExpPad.InternoExpedienteRefPadreId = ExpedientePadreId
            objExpPad.FlagTransferenciaSede = Me.FlagTransferSede
            Dim codigoPadre As Integer = -1
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    codigoPadre = (New Bussines.Registro.InternoExpedientePadre).Grabar_LM(objExpPad)
                Case Else
                    codigoPadre = (New Bussines.Registro.InternoExpedientePadre).Grabar(objExpPad)
            End Select
        End Function
#End Region
#Region "forms"
        Private Sub FRM_Grilla()
            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucion1.objEntExpedienteTempoCol
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionReferenciado
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                'If .objEntExpedienteTempoCol.Count = 0 Then
                '    ckbExpediente.Checked = False
                'End If
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucion1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                        ' uscResDetencion.CargarDataCabacera(.objEntExpedienteTempoCol.Item(0))

                        UscExpeDeResolucion1._VisibleControlExpediente = Me.ckbExpediente.Checked
                        UscExpeDeResolucion1.VerExpedienteControl()
                    End If
                    If .objEntExpedienteTempoCol.Count = 0 Then
                        ckbExpediente.Checked = False
                    End If
                Else
                    If ckbExpediente.Enabled = True Then
                        ckbExpediente.Checked = False
                    End If
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
                    objEnt.Nuevo = False
                End If
                ._objEntExpediente = objEnt
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.UscExpeDeResolucion1._Temporal_GrabarExpediente(._objEntExpediente)
                End If
            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)

            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._IngresoID = Me._InternoIngresoId
                    ._ExpedienteID = UscExpeDeResolucion1._GrillaExpedienteID
                    ._ExpedienteItem = UscExpeDeResolucion1._GrillaItemExpediente

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscExpeDeResolucion1._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelCol
                .UscComboDelito1._objEntDelitoCol = objEntDelCol
                ._DelitoItem = UscExpeDeResolucion1._GrillaItemDelito
                ._objEntDelito = objEnt_
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ._objEntDelito.ExpedienteItem = UscExpeDeResolucion1._GrillaItemExpediente
                    If ._TemporalNuevo = False Then
                        ._objEntDelito.DelitoAuxiliar = False
                        ._objEntDelito.DelitoItem = ._DelitoItem
                    End If
                    Me.UscExpeDeResolucion1._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol, ._objEntAgravCol_Ind)
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
                ._objEntAgraviadoCol = UscExpeDeResolucion1.objEntAgraviadoTempoColGrilla
                ._NuevoGrabar = Nuevo
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    With ._objEntAgraviado
                        .ExpedienteID = UscExpeDeResolucion1._GrillaExpedienteID
                        .DelitoID = UscExpeDeResolucion1._GrillaDelitoID
                        .ExpedienteItem = UscExpeDeResolucion1._GrillaItemExpediente
                        .DelitoItem = UscExpeDeResolucion1._GrillaItemDelito
                    End With
                    Me.UscExpeDeResolucion1._Temporal_GrabarAgraviado(._objEntAgraviado)
                End If
            End With
        End Sub
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    uscResDetencion.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "otros"
        Private Sub ValoresxDefault()
            With uscResDetencion
                ._InternoId = Me._InternoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._InternoIngresoId
                ._TipoLicencia = Me._TipoLicencia
                .DocumentoTipo = Me._TipoResolucion
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._LoadUsc()

                ObjDocumentoOrig.DocumentoNumero = .DocumentoNumero
                ObjDocumentoOrig.DocumentoFecha = .DocumentoFecha
                ObjDocumentoOrig.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                ObjDocumentoOrig.DistritoJudicial = .DistritoJudicial
                ObjDocumentoOrig.SalaJuzgado = .SalaJuzgado
                ObjDocumentoOrig.JuezNombre = .JuezNombre
                ObjDocumentoOrig.SecretarioNombre = .SecretarioNombre
                ObjDocumentoOrig.Observacion = .Observacion
            End With

            With UscExpeDeResolucion1
                ._TipoResolucion = Me._TipoResolucion
                ._InternoID = Me._InternoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoID = Me._InternoIngresoId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._DocumentoJudicialID = _Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(uscResDetencion.objEnt, False, False)
                ObjExpedienteOrig = UscExpeDeResolucion1.objEntExpedienteTempoCol.Expediente(0)
            End With
            If Me.uscResDetencion._Codigo > 0 Then
                ckbExpediente.Enabled = False
                If UscExpeDeResolucion1.CodExpedientePadre > 0 Then
                    ckbExpediente.Checked = True
                End If
                If UscExpeDeResolucion1.CodExpedienteReferenciado > 0 And ckbExpediente.Checked = False Then
                    uscResDetencion.ControlEnablet()
                End If
            End If
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta Then
                lblEtiqueta.Text = ""
                Me.Text = ".::. Registro de expediente"
            Else
                lblEtiqueta.Text = "RESOLUCION: DETENCION"
            End If
            UscAuditUser1.LoadAudit(uscResDetencion._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotones.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If ckbExpediente.Checked = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para registrar una DETENCIÓN, Debe referenciar un expediente existente.")
                ckbExpediente.Focus()
                Exit Sub
            End If
            If uscResDetencion.Validar = True Then
                CargarExpedienteCabecera()
                If UscExpeDeResolucion1.Validar(-1) = True Then
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                        If AGrabar() > -1 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub
        Private Function CargarExpedienteCabecera() As Entity.Registro.Expediente
            Dim objExp As New Entity.Registro.Expediente
            If Me.ckbExpediente.Checked = False Then
                Dim objExpCol As New Entity.Registro.ExpedienteCol
                With objExp
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .InternoID = Me._InternoId
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    .CreaDocJudicialId = Me._Codigo ' uscResDetencion._Codigo
                    .TipoAutoridadJudicialID = uscResDetencion.TipoAutoridadJudicial
                    .AutoridadJudicialID = uscResDetencion.DistritoJudicial
                    .SalaJudicialID = uscResDetencion.SalaJuzgado
                    .ExpedienteJuez = uscResDetencion.JuezNombre
                    .ExpedienteSecretario = uscResDetencion.SecretarioNombre
                    .ExpedienteNumero = uscResDetencion.DocumentoNumero
                    .ExpedienteFechaDocRecepcion = uscResDetencion.DocumentoFechaRecepcion
                    .ExpedienteFecha = uscResDetencion.DocumentoFecha
                    .SituacionJuridicaID = uscResDetencion.SituacionJuridicaId
                    .Flagrancia = uscResDetencion.Flagrancia
                    .Observacion = uscResDetencion.Observacion
                    .ExpedienteVisible = 1
                End With
                UscExpeDeResolucion1.objEntExpedienteTempoCol.Add(objExp)
            End If
            Return objExp
        End Function
        Private Sub frmResolDetencion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()
            uscResDetencion._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucion1._TipoLicencia = Me._TipoLicencia

        End Sub

        'Private Sub UscDelito__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion1._Click_Agraviado_Agregar
        '    FRM_MantAgraviado(True, objEntDelito, Nothing)
        'End Sub

        'Private Sub UscDelito__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion1._Click_Agraviado_Editar
        '    FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        'End Sub

        Private Sub uscResDetencion__Click_VerExpediente()
            UscExpeDeResolucion1._ListarExpediente(Nothing, False, False)
        End Sub
        Public Property VerExpedientes As Boolean = False

        Private Sub UscExpeDeResolucion1__Click_Expediente_Agregar() Handles UscExpeDeResolucion1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub
        Private Sub UscExpeDeResolucion1__Click_Expediente_Editar(objEntExpediente As Entity.Registro.Expediente) Handles UscExpeDeResolucion1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEntExpediente)
        End Sub
        Private Sub UscExpeDeResolucion1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelCol)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelCol)
        End Sub
        Private Sub UscExpeDeResolucion1__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion1._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion1._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub uscResDetencion__Click_VerFormulario() Handles uscResDetencion._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = uscResDetencion.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    uscResDetencion.DistritoJudicial = ._DistritoJudicialID
                    uscResDetencion.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub ckbExpediente_CheckedChanged(sender As Object, e As EventArgs) Handles ckbExpediente.CheckedChanged
            If ckbExpediente.Checked = True Then
                If ckbExpediente.Enabled = True Then
                    FRM_Grilla()
                ElseIf ckbExpediente.Checked = True Then
                    UscExpeDeResolucion1._VisibleControlExpediente = Me.ckbExpediente.Checked
                    UscExpeDeResolucion1.VerExpedienteControl()
                End If
            Else
                UscExpeDeResolucion1.LimpiarExpediendeDelitoGrilla()
                UscExpeDeResolucion1._VisibleControlExpediente = Me.ckbExpediente.Checked
                UscExpeDeResolucion1.VerExpedienteControl()
            End If
        End Sub

        Private Sub uscResDetencion__Click_FrmBusquedaAutoridadJudicial() Handles uscResDetencion._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class
End Namespace