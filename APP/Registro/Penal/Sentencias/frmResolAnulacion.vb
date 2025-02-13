Imports Type.Enumeracion.Licencia
Namespace Registro.Sentencias
    Public Class frmResolAnulacion
#Region "Propiedades"
        'vgv
        Private bssExp As Bussines.Registro.Expediente = Nothing
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
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
#Region "Accion"
        Private Function AGrabar() As Integer
            Me.Cursor = Cursors.WaitCursor
            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim EntDocJud As New Entity.Registro.DocumentoJudicial
            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then EntDocJud.FlagTransferenciaSede = 1

            EntDocJud = uscResolAnulacion.AGrabar(EntDocJud)

            usrDetallRegistroAnulacion._TipoLicencia = Me._TipoLicencia
            If EntDocJud.Codigo > 0 Then usrDetallRegistroAnulacion._Grabar(EntDocJud.Codigo, Me._blnNuevoRegistro, EntDocJud)

            Me.Cursor = Cursors.Default
            Return EntDocJud.Codigo
        End Function
#End Region
#Region "Forms"
        Private Sub FRM_Grilla()
            If uscResolAnulacion.DocumentoFechaRecepcion = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar la fecha de recepcion en el documento para poder listar los documentos.")
                uscResolAnulacion.ControlFocus()
                Exit Sub
            End If
            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._FechaRecep = uscResolAnulacion.DocumentoFechaRecepcion
                ._TemporalNuevo = True
                ._SituacionJuridicaExpe = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes
                .objEntExpedienteTempoColCopi2 = usrDetallRegistroAnulacion.objEntExpedienteTempoCol
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.usrDetallRegistroAnulacion._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With

        End Sub
        Private Sub FRM_GrillaDocumentos()
            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmListaDocumentosPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._InternoIngresoID
                ._IngresoInpeID = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes
                .objEntDocumentoCol = usrDetallRegistroAnulacion.objEntcolT
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    Me.usrDetallRegistroAnulacion._Temporal_Grabar_Documentos(.objDocumJudicialCol)

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
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    objEnt.Nuevo = True
                End If
                ._objEntExpediente = objEnt
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.usrDetallRegistroAnulacion._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
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
                    ._ExpedienteID = usrDetallRegistroAnulacion._GrillaExpedienteID
                    ._ExpedienteItem = usrDetallRegistroAnulacion._GrillaItemExpediente 'HNRB puede ser reemplazado por objEntExpediente._ExpedienteItem
                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    .ResolucionNuevo = False
                    ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    objEnt_.DelitoItem = Me.usrDetallRegistroAnulacion._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelitoCol
                .UscComboDelito1._objEntDelitoCol = objEntDelitoCol
                '._DelitoItem = usrDetallRegistroAnulacion._GrillaItemDelito
                ._objEntDelito = objEnt_
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    Me.usrDetallRegistroAnulacion._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol)

                End If
                If .EliminarFila = True Then
                    Dim ana As Integer = .AgraviadoItemCopia
                End If

            End With
        End Sub
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    uscResolAnulacion.DistritoJudicial = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            With uscResolAnulacion
                ._InternoID = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With

            With usrDetallRegistroAnulacion
                ._InternoId = Me._InternoID
                ._InternoIngresoId = Me._InternoIngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._DocumentoJudicialID = _Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes
                ._ListarExpediente(_Codigo, True, True)
            End With

        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
#End Region

        Private Sub usrDetallRegistroAnulacion__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles usrDetallRegistroAnulacion._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub
        Private Sub usrDetallRegistroAnulacion__Click_Expediente_Agregar() Handles usrDetallRegistroAnulacion._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub
        Private Sub usrDetallRegistroAnulacion__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoCol As Entity.Registro.DelitoCol) Handles usrDetallRegistroAnulacion._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub
        Private Sub usrDetallRegistroAnulacion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoCol As Entity.Registro.DelitoCol) Handles usrDetallRegistroAnulacion._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoCol)
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolSentencia_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Usuario_Permiso()
            ValoresxDefault()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If uscResolAnulacion.Validar = True Then
                If usrDetallRegistroAnulacion.Validar = True Then
                    Dim strMensaje As String = ""
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then
                        If AGrabar() > 0 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub


        Private Sub usrDetallRegistroAnulacion__Click_Documentos_Agregar() Handles usrDetallRegistroAnulacion._Click_Documentos_Agregar
            FRM_GrillaDocumentos()
        End Sub

        Private Sub usrDetallRegistroAnulacion_VerDocumentoJudicial(TipForm As System.Int32, SubTipForm As Integer, Codigo As System.Int32) Handles usrDetallRegistroAnulacion.VerDocumentoJudicial
            Select Case TipForm
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                    Dim frm As New Registro.Resoluciones.frmNota
                    frm._InternoId = Me._InternoID
                    frm._InternoIngresoId = Me._InternoIngresoID
                    frm._Codigo = Codigo
                    frm._Subtipo = SubTipForm
                    frm._RegionID = Me._RegionID
                    frm._PenalID = Me._PenalID
                    frm._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    frm.ShowDialog()
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado
                    Dim frm As New Registro.Resoluciones.frmResolTraslado
                    frm._InternoId = Me._InternoID
                    frm._InternoIngresoId = Me._InternoIngresoID
                    frm._Codigo = Codigo
                    frm._RegionID = Me._RegionID
                    frm._PenalID = Me._PenalID
                    frm._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                    frm.ShowDialog()
            End Select
        End Sub

        Private Sub uscResolAnulacion__Click_VerFormulario() Handles uscResolAnulacion._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = uscResolAnulacion.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    uscResolAnulacion.DistritoJudicial = ._DistritoJudicialID
                    uscResolAnulacion.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub

        Private Sub uscResolAnulacion__Click_FrmBusquedaAutoridadJudicial() Handles uscResolAnulacion._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class

End Namespace