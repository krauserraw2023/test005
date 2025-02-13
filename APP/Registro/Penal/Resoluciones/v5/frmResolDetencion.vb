Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class frmResolDetencion
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing

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
            Dim intIdExpePadId As Integer = -1
            Dim obExpeNew As New Entity.Registro.Expediente
            'obExpeNew.FlagTransferenciaSede = Me.FlagTransferSede


            Dim objDocJudTmp As Entity.Registro.DocumentoJudicial
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objDocJudTmp = uscResDetencion.AGrabar_LM()
            Else
                objDocJudTmp = uscResDetencion.AGrabar() 'retorna objeto resolucion de detencion
            End If

            If objDocJudTmp Is Nothing Then
                Return -3
            End If
            Select Case objDocJudTmp.Codigo
                Case 0, -1
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe este numero y tipo de documento")
                    Return -1
                Case -2
                    Return -2
            End Select
           
            Me._Codigo = objDocJudTmp.Codigo
            Dim intIdExpe As Integer = -1

            If Me._blnNuevoRegistro = True Then 'RESOLUCION NUEVO
                '----->obtener datos de la resolucion hacia el nuevo mandato de detencion
                With obExpeNew
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .InternoID = Me._InternoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .IngresoID = Me._InternoIngresoId
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    .TipoAutoridadJudicialID = uscResDetencion.TipoAutoridadJudicial
                    If uscResDetencion.TipoAutoridadJudicial = 1 Then
                        .AutoridadJudicialID = objDocJudTmp.DistritoJudicial
                        .SalaJudicialID = objDocJudTmp.SalaJuzgado
                        .ExpedienteJuez = objDocJudTmp.JuezNombre
                        .ExpedienteSecretario = objDocJudTmp.SecretarioNombre
                    Else
                        .AutoridadOtroCargo = objDocJudTmp.AutoridadOtroCargo
                        .AutoridadOtro = objDocJudTmp.AutoridadOtroNombre
                    End If
                    .ExpedienteNumero = objDocJudTmp.DocumentoNumero
                    .ExpedienteFechaDocRecepcion = objDocJudTmp.DocumentoFechaRecepcion
                    .ExpedienteFecha = objDocJudTmp.DocumentoFecha
                    .SituacionJuridicaID = objDocJudTmp.SituacionJuridicaId
                    .Flagrancia = objDocJudTmp.Flagrancia
                    .Observacion = objDocJudTmp.Observacion
                    .ExpedienteVisible = 1
                    .CreaDocJudicialId = Me._Codigo
                End With

                '------------
                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    intIdExpe = (New Bussines.Registro.Expediente).Grabar_LM(obExpeNew)
                Else
                    intIdExpe = (New Bussines.Registro.Expediente).Grabar(obExpeNew) 'guardar obExpeNew en BD y retornar en intIdExpe
                End If

            Else
                'obExpeNew = UscExpeDeResolucion1._EntidadEx
                '----->obtener datos de la resolucion hacia el nuevo mandato de detencion
                With obExpeNew
                    .FlagTransferenciaSede = Me.FlagTransferSede
                    .IngresoID = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    .InternoID = Me._InternoId
                    ._RegionId = Me._RegionID
                    ._PenalId = Me._PenalID
                    'obExpeNew.Codigo = objDocJudTmp .
                    If uscResDetencion.TipoAutoridadJudicial = 1 Then
                        .AutoridadJudicialID = objDocJudTmp.DistritoJudicial
                        .SalaJudicialID = objDocJudTmp.SalaJuzgado
                        .ExpedienteJuez = objDocJudTmp.JuezNombre
                        .ExpedienteSecretario = objDocJudTmp.SecretarioNombre
                    Else
                        .AutoridadOtroCargo = objDocJudTmp.AutoridadOtroCargo
                        .AutoridadOtro = objDocJudTmp.AutoridadOtroNombre
                    End If
                    .TipoAutoridadJudicialID = 1
                    .ExpedienteNumero = objDocJudTmp.DocumentoNumero
                    .ExpedienteFechaDocRecepcion = objDocJudTmp.DocumentoFechaRecepcion
                    .ExpedienteFecha = objDocJudTmp.DocumentoFecha
                    .SituacionJuridicaID = objDocJudTmp.SituacionJuridicaId
                    .Flagrancia = objDocJudTmp.Flagrancia
                    .Observacion = objDocJudTmp.Observacion
                    .ExpedienteVisible = 1
                    .CreaDocJudicialId = Me._Codigo

                    '<-------------
                    .Codigo = UscExpeDeResolucion1.objEntExpedienteTempoCol.Item(0).Codigo
                End With

                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    intIdExpe = (New Bussines.Registro.Expediente).Grabar_LM(obExpeNew) 'guardar obExpeNew en BD y retornar en intIdExpe
                Else
                    intIdExpe = (New Bussines.Registro.Expediente).Grabar(obExpeNew) 'guardar obExpeNew en BD y retornar en intIdExpe
                End If

            End If

            UscExpeDeResolucion1.AGrabar(Me._Codigo, intIdExpe, _blnNuevoRegistro)

            Return Me._Codigo
        End Function
#End Region
#Region "forms"
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
            End With

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
            If uscResDetencion.Validar = True Then
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
        Private Sub frmResolDetencion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()
            uscResDetencion._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucion1._TipoLicencia = Me._TipoLicencia

        End Sub

        Private Sub UscDelito__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito)
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscDelito__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado)
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
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
        Private Sub uscResDetencion__Click_VerExpediente() Handles uscResDetencion._Click_VerExpediente
            UscExpeDeResolucion1._ListarExpediente(Nothing, False, False)
        End Sub
    End Class
End Namespace