Namespace Registro.Resoluciones
    Public Class frmResolAvocamiento
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing

#Region "propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
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
          
            Me._blnNuevoRegistro = If(Me._Codigo < 1, True, False)
            UscResolAclaratoriaExpe1._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento

            'jmr, correcion del avocamiento
            Dim objDocVacio As New Entity.Registro.DocumentoJudicial
            Me._Codigo = UscResolAclaratoriaExpe1.AGrabar(objDocVacio)

            If Me._Codigo > 0 Then
                With UscExpeDeResolucion
                    ._EntExpAvocat.AutoridadJudicialID = UscResolAclaratoriaExpe1.DistritoJudicial
                    ._EntExpAvocat.AutoridadJudicialNombre = UscResolAclaratoriaExpe1.AutoridadJuzgadonombre
                    ._EntExpAvocat.SalaJudicialID = UscResolAclaratoriaExpe1.SalaJuzgado
                    ._EntExpAvocat.SalaJudicialNombre = UscResolAclaratoriaExpe1.SalaJuzgadonombre
                    ._EntExpAvocat.ExpedienteJuez = UscResolAclaratoriaExpe1.JuezNombre
                    ._EntExpAvocat.ExpedienteSecretario = UscResolAclaratoriaExpe1.SecretarioNombre

                    ._Grabar(Me._Codigo, Me._blnNuevoRegistro, -1, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento)
                End With
            Else
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo realizar la operación")
            End If
            Return Me._Codigo
        End Function
#End Region
#Region "forms"        
        Private Sub FRM_Grilla()
            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                ._GrillaSeleccionMultiple = False
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucion.objEntExpedienteTempoCol
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente

                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucion._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With
            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                With frm2
                    frm2._TipoFormu = True
                    frm2._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    frm2._objEntExpedienteCol = UscExpeDeResolucion.objEntExpedienteTempoCol
                    frm2._Contador = Me.UscExpeDeResolucion.objEntExpedienteTempoCol.Count
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        If Me.UscExpeDeResolucion.objEntExpedienteTempoCol.Count = 0 Then
                            ._objEntExpediente.InternoID = Me._InternoId
                            Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente)
                        End If
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_MantenimientoExpediente(ByVal Nuevo As Boolean, objEnt As Entity.Registro.Expediente)
            Dim Item As Integer = -1
            Dim Codigo As Integer = -1
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                  
                Else
                    ._Codigo = objEnt.Codigo
                    Codigo = objEnt.Codigo
                    Item = objEnt.ExpedienteItem
                    ._TemporalNuevo = False 'temporal edidato
                    ._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    ._ExpedienteIDAux = UscExpeDeResolucion.ExpedienteCodAux
                End If
                ._objEntExpediente = objEnt

                If UscExpeDeResolucion.EntExpedienteAux Is Nothing Then
                    ._objEntExpedienteAux = objEnt
                Else
                    ._objEntExpedienteAux = UscExpeDeResolucion.EntExpedienteAux
                End If
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Nuevo = False Then
                        ._objEntExpediente.Codigo = ._objEntExpedienteAux.Codigo
                        If ._objEntExpediente.Codigo > 0 Then
                            ._objEntExpediente.ExpedienteItem = 1
                        Else
                            ._objEntExpediente.ExpedienteItem = Item
                        End If
                    End If
                    Dim abc As Integer = Expediente.v5.frmExpedientePopup3._Codigo
                    Me.UscExpeDeResolucion.ValorOK = True
                    Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente)
                End If

            End With
        End Sub

        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)
            Dim frm As New Registro.expediente.v5.frmDelitoPopup4
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
                    ._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    ._ExpedienteIDAux = UscExpeDeResolucion.ExpedienteCodAux
                    ._objEntAgraviadoCol = objEntCol
                    objEnt_.DelitoItem = Me.UscExpeDeResolucion._GrillaItemDelito

                End If
                ._objEntDelitoCol = objEntDelCol
                ._DelitoItem = UscExpeDeResolucion._GrillaItemDelito
                .UscComboDelito1._objEntDelitoCol = objEntDelCol
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
                    ._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    ._ExpedienteIDAux = UscExpeDeResolucion.ExpedienteCodAux
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
#End Region
#Region "otros"
        Private Sub ValoresxDefault()
            With UscResolAclaratoriaExpe1
                ._Codigo = Me._Codigo
                ._InternoID = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With

            With UscExpeDeResolucion
                ._InternoID = Me._InternoId
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._DocumentoJudicialID = _Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                '._VisiblePanelMantExpediente = True
                '._VisiblePanelMantDelito = True
                '._VisiblePanelMantAgraviado = True
                '._VisibleBotonEliminarExpediente = True
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                If Me._Codigo > 0 Then
                    ._DocumentoJudicialID = Me._Codigo
                    ._ListarExpedientePadre(_Codigo, True, True)
                End If
            End With

        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub

#End Region

        Private Sub UscExpeDeResolucion__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion__Click_AgregarExpediente() Handles UscExpeDeResolucion._Click_Expediente_Agregar            
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion__Click_EditarAgraviado(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub frmResolAvocamiento_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()
            UscResolAclaratoriaExpe1._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucion._TipoLicencia = Me._TipoLicencia
        End Sub
        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            If UscResolAclaratoriaExpe1.Validar = True Then
                If UscExpeDeResolucion.Validar(-1) = True Then
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                        If AGrabar() > -1 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub UscExpeDeResolucion__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente) Handles UscExpeDeResolucion._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelCol)
        End Sub

        Private Function objEntExpediente() As Entity.Registro.Expediente
            Throw New NotImplementedException
        End Function

        Private Sub UscExpeDeResolucion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        End Sub
        Private Sub UscExpeDeResolucion1__Click_Expediente_Agregar()
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Expediente_Editar(objEntExpediente As Entity.Registro.Expediente)
            FRM_MantenimientoExpediente(False, objEntExpediente)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelCol)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelCol)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito)
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado)
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscResolAclaratoriaExpe1__Click_VerFormulario() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaSalaJuzgado
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscResolAclaratoriaExpe1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then
                    UscResolAclaratoriaExpe1.DistritoJudicial = ._DistritoJudicialID
                    UscResolAclaratoriaExpe1.SalaJuzgado = ._GrillaSalaID
                    UscResolAclaratoriaExpe1.ControlFocus()
                End If
            End With
        End Sub

        Private Sub UscResolAclaratoriaExpe1__Click_FrmBusquedaAutoridadJudicial() Handles UscResolAclaratoriaExpe1._Click_FrmBusquedaAutoridadJudicial
            FRM_BusquedaAutoridadJudicial
        End Sub
    End Class
End Namespace