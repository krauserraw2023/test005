Option Explicit On

Namespace Registro.Resoluciones

    Public Class frmOrdenTrasladoHospital_Nota
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
        Public Property DocJudicialReferencia_OTHSM_Original As Integer = -1
        Public Property _Motivo_Tipo_ID As Integer = -1
        Private Property DocumentoNumero_Referencia() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
                txtNumDocumento.ReadOnly = True
            End Set
        End Property

        Private Property FechaProgramada_Referencia() As String
            Get
                Return Me.txtFechaProgramadaTraslado.Text
            End Get
            Set(ByVal value As String)
                txtFechaProgramadaTraslado.Text = value
                txtFechaProgramadaTraslado.ReadOnly = True
            End Set
        End Property

        Private Property FechaDocumento_Referencia() As String
            Get
                Return Me.txtFechaDocumento.Text
            End Get
            Set(ByVal value As String)
                txtFechaDocumento.Text = value
                txtFechaDocumento.ReadOnly = True
            End Set
        End Property
#End Region
#Region "Accion"
        Private Function AGrabar() As Integer

            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            If UscExpeDeResolucion.EntMovimiento.MovimientoMotivoID < 1 Then
                objDoc.MovimientoMotivoId = Me.UscResolAclaratoriaExpe1.MovimientoMotivoId '
            Else
                objDoc.MovimientoMotivoId = Me.UscExpeDeResolucion.EntMovimiento.MovimientoMotivoID
            End If


            ' REG_DOC_JUDICIAL
            Me._Codigo = UscResolAclaratoriaExpe1.AGrabar(objDoc)
            UscExpeDeResolucion._FechaMovimiento = UscResolAclaratoriaExpe1.FechaMovimiento
            If Me._Codigo < 1 Then Return Me._Codigo
            'RESOLUCION NUEVO
            UscExpeDeResolucion._Documentos_sin_mov = Me._Documento_sin_mov
            UscExpeDeResolucion._Grabar(Me._Codigo, _blnNuevoRegistro, -1, Me._TipoResolucion) ' 

            If Me._blnNuevoRegistro = True Then
                'Me._Codigo = -1
                'genear movimiento de traslado a hospital mental
                Dim objBssMov As New Bussines.Registro.InternoMovimiento
                Dim IdTipoInimputable As Integer = -1

                IdTipoInimputable = UscExpeDeResolucion.objEntExpedienteTempoCol.Item(0).MotivoIngresoID
                'If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                'Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                'Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then

                'Else

                'End If
                If IdTipoInimputable = 178 Then
                    IdTipoInimputable = Type.Enumeracion.Movimiento.EnumMovMotivo.Por_Medida_De_Seguridad_De_Internación
                Else
                    IdTipoInimputable = Type.Enumeracion.Movimiento.EnumMovMotivo.Internación_Preventiva_Posible_Inimputable
                End If

                objBssMov.generarMovimientoOrdenTrasladoHospital(-1,
                                                                 Me._InternoId,
                                                                 Me._InternoIngresoId,
                                                                 UscExpeDeResolucion._InternoIngresoInpeId,
                                                                UscResolAclaratoriaExpe1.FechaInscripcion,
                                                                Me._Codigo,
                                                                Me._RegionID,
                                                                Me._PenalID,
                                                                Me.DocJudicialReferencia_OTHSM_Original,
                                                                IdTipoInimputable)

                Return Me._Codigo
            End If
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
                    'Me.DocJudicialReferencia_OTHSM_Original = .
                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucion._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                        Me.UscResolAclaratoriaExpe1.MovimientoMotivoId = .objEntExpedienteTempoCol.Expediente(0).MotivoIngresoID
                        Me.DocJudicialReferencia_OTHSM_Original = .objEntExpedienteTempoCol.Expediente(0).CreaDocJudicialId
                        If Me.DocJudicialReferencia_OTHSM_Original > 0 Then
                            Dim bss As New Bussines.Registro.DocumentoJudicial
                            Dim obj As New Entity.Registro.DocumentoJudicial
                            obj.Codigo = Me.DocJudicialReferencia_OTHSM_Original
                            obj = bss.Listar_v3(obj)
                            Me.DocumentoNumero_Referencia = obj.DocumentoNumero
                            Me.FechaDocumento_Referencia = obj.DocumentoFechaDate
                            Me.FechaProgramada_Referencia = Legolas.Components.FechaHora.FechaDate(obj.FechaInscripcion, True)

                        End If
                    End If
                End If
            End With

            If blnNuevoExpediente = True Then
                'If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Or
                '    Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                ''se saco ORden Traslado y Retorno de hospital mental  e.cu.cco.
                If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No hay ningún Documento de Orden de Traslado a Hospital Mental pendiente a referenciar.")
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
        'Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)

        '    Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
        '    With frm

        '        If Nuevo = True Then
        '            ._Codigo = -1
        '            ._InternoID = Me._InternoId
        '            ._IngresoID = Me._InternoIngresoId
        '            ._ExpedienteID = UscExpeDeResolucion._GrillaExpedienteID
        '            ._ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente

        '            ._TemporalNuevo = True 'temporal nuevo
        '            .ResolucionNuevo = True
        '        Else
        '            ._Codigo = objEnt_.Codigo
        '            ._TemporalNuevo = False 'temporal edidato
        '            ._objEntAgraviadoCol = objEntCol
        '            objEnt_.DelitoItem = Me.UscExpeDeResolucion._GrillaItemDelito
        '        End If
        '        ._TipoDocumento = Me._TipoResolucion
        '        ._objEntDelitoCol = objEntDelCol
        '        .UscComboDelito1._objEntDelitoCol = objEntDelCol
        '        ._DelitoItem = UscExpeDeResolucion._GrillaItemDelito
        '        ._objEntDelito = objEnt_
        '        'permisos
        '        ._FormEscritura = Me._FormEscritura
        '        ._FormEliminar = Me._FormEliminar
        '        ._FormReporte = Me._FormReporte
        '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '            ._objEntDelito.ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente
        '            If ._TemporalNuevo = False Then
        '                ._objEntDelito.DelitoAuxiliar = False
        '                ._objEntDelito.DelitoItem = ._DelitoItem
        '            End If
        '            Me.UscExpeDeResolucion._Temporal_GrabarDelito(objEntExpediente, ._objEntDelito, ._objEntAgraviadoCol, ._objEntAgravCol_Ind)
        '        End If

        '    End With
        'End Sub
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
#End Region
#Region "otros"
        Dim frmLoad As Load.frmLoad = Nothing
        Private Sub ValoresxDefault()

            Me.SuspendLayout()
            frmLoad = New Load.frmLoad

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

            If Me._Codigo > 0 Then
                Dim bssM As New Bussines.Registro.InternoMovimiento
                Dim objm As New Entity.Registro.InternoMovimiento
                Dim EntMov As New Entity.Registro.InternoMovimiento
                With EntMov
                    EntMov.DocumJudicialID = Me._Codigo
                    EntMov.InternoID = Me._InternoId
                    EntMov.IngresoID = Me._InternoIngresoId
                End With
                objm = bssM.Listar(EntMov)
                DocJudicialReferencia_OTHSM_Original = objm.DocJudicialReferencia_OTHSM

                Dim bss As New Bussines.Registro.DocumentoJudicial
                Dim obj As New Entity.Registro.DocumentoJudicial
                obj.Codigo = Me.DocJudicialReferencia_OTHSM_Original
                obj = bss.Listar_v3(obj)
                Me.DocumentoNumero_Referencia = obj.DocumentoNumero
                Me.FechaDocumento_Referencia = obj.DocumentoFechaDate
                Me.FechaProgramada_Referencia = Legolas.Components.FechaHora.FechaDate(obj.FechaInscripcion, True)
                Me._Motivo_Tipo_ID = "178"
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()
        End Sub
        Private Sub Usuario_Permiso()
            If Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Or
                Me._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                Me.btnAceptar.Visible = True ' Me._FormEscritura
                Me.PnlBotonesGrabar.Visible = True ' Me._FormEscritura
            Else
                Me.btnAceptar.Visible = Me._FormEscritura
                Me.PnlBotonesGrabar.Visible = Me._FormEscritura

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
        'Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Agregar
        '    FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelCol)
        'End Sub

        'Private Sub UscExpeDeResolucion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Editar
        '    FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        'End Sub
        Public OrdenMovimiento As Boolean = False

        Private Sub UscExpeDeResolucion1__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscExpeDeResolucion_Load(sender As Object, e As EventArgs) Handles UscExpeDeResolucion.Load

        End Sub

        Private Sub UscExpeDeResolucion_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles UscExpeDeResolucion.MouseDoubleClick

        End Sub
    End Class

End Namespace