Namespace Registro.RegionLima.Resoluciones
    Public Class frmQueda
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
#Region "Propiedades_Publicas"
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Ninguno
        Public Property _TipoResolucion As Integer = -1
#End Region
#Region "Propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _NuevoRegistro() As Boolean = False
        Public Property _TipoAclaratoria As Integer = -1 'Permite dejar por defecto el tipo de aclaratoria
        Public Property _TipoAclaratoriaCon As Boolean = False  'Permite dejar por defecto el tipo de aclaratoria
        Public Property _Condicion As Boolean = False 'Permite seleccionar el tipo de documento en nombres asociados

        Public Property _CodigoInterno() As String
            Get
                Return lblCodInterno.Text
            End Get
            Set(ByVal value As String)
                lblCodInterno.Text = value
            End Set
        End Property
        Public Property _NombresInterno() As String
            Get
                Return lblInterno.Text
            End Get
            Set(ByVal value As String)
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
#Region "Validar"
        Private Function Validar() As Boolean

            'If UscResolAmpliaAutoapert1._Tip = 1 Then
            If UscExpeDeResolucion.Validar(-1) = False Then
                Return False
            End If
            'ElseIf uscResolAclaratoria._TipoAclaratoriaSeleccionado = 2 Then 'nombres
            '    If Me._Codigo < 1 Then
            '        If uscResolAclaratoria.GrillaRegistroNomAsoc = 0 Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista de nombres asociados, debe tener por lo menos un registro")
            '            Return False
            '        End If
            '    End If
            'Else
            '    If Me._Codigo < 1 Then
            '        If uscResolAclaratoria.GrillaRegistroNomAsoc = 0 Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("La lista de nombres asociados, debe tener por lo menos un registro")
            '            Return False
            '        End If
            '    End If
            '    If UscExpeDeResolucion.Validar(-1) = False Then
            '        Return False
            '    End If
            'End If
            Return True
        End Function
#End Region
#Region "Accion"
        Private Function AGrabar() As Integer
            If Me._Codigo < 1 Then
                Me._NuevoRegistro = True
            Else
                Me._NuevoRegistro = False
            End If
            Me._Codigo = UscResolQueda1.AGrabar()
            Me.UscExpeDeResolucion._Grabar(Me._Codigo, Me._NuevoRegistro, -1, UscResolQueda1._DocumentoTipo)
            Return Me._Codigo
        End Function
#End Region
#Region "Form"
        Private Sub FRM_Grilla()

            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucion.objEntExpedienteTempoCol
                .DocJudicialID = Me._Codigo
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
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
                frm2._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                frm2._objEntExpedienteCol = UscExpeDeResolucion.objEntExpedienteTempoCol
                frm2._TipoLicencia = Me._TipoLicencia
                With frm2
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
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal objEntExpediente As Entity.Registro.Expediente, ByVal objEnt_ As Entity.Registro.Delito, ByVal objEntCol As Entity.Registro.AgraviadoCol, ByVal objEntDelCol As Entity.Registro.DelitoCol)
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
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
                ._TipoLicencia = Me._TipoLicencia
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
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal objEnt As Entity.Registro.Expediente)
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
                    ._IngresoID = Me._InternoIngresoId
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._TemporalNuevo = Nuevo 'temporal nuevo
                    objEnt.Nuevo = Nuevo
                Else
                    ._Codigo = objEnt.Codigo
                    ._TemporalNuevo = Nuevo 'temporal edidato
                    objEnt.Nuevo = Nuevo
                End If
                ._TipoLicencia = Me._TipoLicencia
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
        Private Sub FRM_MantAgraviado(ByVal Nuevo As Boolean, ByVal objEntDelito As Entity.Registro.Delito, ByVal objEnt As Entity.Registro.Agraviado)

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

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            With Me.UscResolQueda1
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoID = Me._InternoId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
            End With
            '-------------------
            With UscExpeDeResolucion
                '._VisiblePanelMantExpediente = True
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                If _Codigo = -1 Then
                    '._EnabledBotonAgregarExpediente = True
                Else 'edicion
                    Me._NuevoRegistro = False
                End If
                '._EnabledBotonEliminarExpediente = True
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoId
                ._DocumentoJudicialID = _Codigo
                'UscExpeDeResolucion.LoadUsc(_Codigo)
                ._TipoLicencia = Me._TipoLicencia
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(UscResolQueda1.objEnt, False)
            End With
            UscAuditUser1.LoadAudit(UscResolQueda1._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura
            Dim blnEliminar As Boolean = False
            'Dim blnGrabar As Boolean = False

            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.AclaratoriaNombre
                    blnEliminar = True
                Case Type.Formulario.Registro.UserControl.Ninguno
                    blnEliminar = False
            End Select
            'PnlEliminar.Visible = blnEliminar
        End Sub

#End Region

        Private Sub UscExpeDeResolucion1__Click_AgregarAgraviado(ByVal objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Expediente_Agregar() Handles UscExpeDeResolucion._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(ByVal objEntDelito As Entity.Registro.Delito, ByVal objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolAclaratoriaExpe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub
        Private Sub frmResolAclaratoriaExpe_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()
           
        End Sub
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            ' /*Este codigo debe ser igual a libertad*/
            If UscResolQueda1.Validar = True Then
                If UscExpeDeResolucion.Validar(-1) = True Then
                    UscExpeDeResolucion.ValidarRevocatoriaLibertad()
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

        End Sub

        Private Sub uscResolAclaratoria__Click_EnabledExpedientes(ByVal TipoAclaratoria As Integer)

            With UscExpeDeResolucion

                Select Case TipoAclaratoria
                    Case 1 'solo expedientes
                        'RedimensionarFormulario(1)
                    Case 2 'solo nombres      

                        '._EnabledBotonAgregarExpediente = False
                        '._EnabledBotonAgregarAgraviado = False
                        '._EnabledBotonAgregarDelito = False
                        '._EnabledBotonEditarAgraviado = False
                        '._EnabledBotonEditarDelito = False
                        '._EnabledBotonEditarExpediente = False
                        '._EnabledBotonEliminarAgraviado = False
                        '._EnabledBotonEliminarDelito = False
                        '._EnabledBotonEliminarExpediente = False
                        'ListarNombreAsociadoBD(_InternoId)
                        'UscResolAclaratoriaNombresAsoc1.ListarNombreAsociadoBD(Me._Codigo, Me._InternoId)
                    Case Else

                        '._EnabledBotonAgregarExpediente = True
                        '._EnabledBotonAgregarAgraviado = True
                        '._EnabledBotonAgregarDelito = True
                        '._EnabledBotonEditarAgraviado = True
                        '._EnabledBotonEditarDelito = True
                        '._EnabledBotonEditarExpediente = True
                        '._EnabledBotonEliminarAgraviado = True
                        '._EnabledBotonEliminarDelito = True
                        '._VisiblePanelMantAgraviado = True
                        '._VisiblePanelMantDelito = True
                        '._EnabledBotonEliminarExpediente = True
                        'UscResolAclaratoriaNombresAsoc1.ListarNombreAsociadoBD(Me._Codigo, Me._InternoId)
                End Select
                'RedimensionarFormulario(TipoAclaratoria)
            End With
        End Sub

        Private Sub UscExpeDeResolucion__Click_Expediente_Editar(ByVal objEnt As Entity.Registro.Expediente) Handles UscExpeDeResolucion._Click_Expediente_Editar
            FRM_MantExpediente(False, objEnt)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(ByVal objEntExpediente As Entity.Registro.Expediente, ByVal objEntDelitoCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoCol)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Editar(ByVal objEntExpediente As Entity.Registro.Expediente, ByVal objEnt As Entity.Registro.Delito, ByVal objEntCol As Entity.Registro.AgraviadoCol, ByVal objEntDelCol As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        End Sub

        Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Para eliminar el registro primero debe guardar los datos...")
            Else
                If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar = DialogResult.Yes Then
                    objBss = New Bussines.Registro.DocumentoJudicial
                    objBss.Eliminar(Me._Codigo, Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria, Me._InternoId, Me._InternoIngresoId, "")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End Sub
        Private Sub UscExpeDeResolucion__click_VerMotivoQueda() Handles UscExpeDeResolucion._click_VerMotivoQueda
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            'frm._ResolucionTipoID = Me.UscExpeDeResolucion._GrillaMotivoQuedaID
            frm._TipoResolucion = Me._TipoResolucion
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscExpeDeResolucion.ActualizarResolucion(frm._ResolucionTipoID, frm._ResolucionTipoNom)
            End If
        End Sub

    End Class
End Namespace