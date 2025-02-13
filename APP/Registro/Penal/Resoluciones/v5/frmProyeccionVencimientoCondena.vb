Namespace Registro.Resoluciones
    Public Class frmProyeccionVencimientoCondena
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
#Region "Propiedades"
        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
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
        Public Property _TipoResolucion As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
        Public Property _Subtipo As Integer = -1
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
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
#End Region
#Region "Accion"
        Private Sub AGrabar()
            If Me._Codigo < 1 Then
                _blnNuevoRegistro = True
            Else
                _blnNuevoRegistro = False
            End If
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            If UscNotas1.Validar = True Then
                If UscExpeDeResolucionIng1.Validar(Me._Subtipo, -1) = True Then
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                        UscNotas1._TotalAnhos = IIf(UscExpeDeResolucionIng1.TotalAnios = "", 0, UscExpeDeResolucionIng1.TotalAnios)
                        UscNotas1._TotalMeses = IIf(UscExpeDeResolucionIng1.TotalMeses = "", 0, UscExpeDeResolucionIng1.TotalMeses)
                        UscNotas1._TotalDias = IIf(UscExpeDeResolucionIng1.TotalDias = "", 0, UscExpeDeResolucionIng1.TotalDias)
                        Me._Codigo = UscNotas1.AGrabar()
                        objDoc.Codigo = Me._Codigo
                        objDoc.DocumentoTipo = Me._TipoResolucion
                        If Me._Codigo > 0 Then
                            UscExpeDeResolucionIng1._Grabar(Me._Codigo, _blnNuevoRegistro)
                            Dim objPer As New Entity.Registro.Documento.PeriodoCondenaSentencia
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub
        Private Sub FRM_Grilla()

            Dim blnNuevoExpediente As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmListaExpedientePopup
            With frm
                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TemporalNuevo = True
                .DocJudicialID = Me._Codigo
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
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
                frm2._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda
                frm2._TipoLicencia = Me._TipoLicencia
                With frm2
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoId
                        ._objEntExpediente.Nuevo = True
                        Me.UscExpeDeResolucionIng1._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If
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
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._ExpedienteID = UscExpeDeResolucionIng1._GrillaExpedienteID
                    ._ExpedienteItem = UscExpeDeResolucionIng1._GrillaItemExpediente

                    ._TemporalNuevo = True 'temporal nuevo
                    .ResolucionNuevo = True
                Else
                    ._Codigo = objEnt_.Codigo
                    ._TemporalNuevo = False 'temporal edidato
                    ._objEntAgraviadoCol = objEntCol
                    'objEnt_.DelitoItem = Me.UscExpeDeResolucion._GrillaItemDelito
                End If
                ._objEntDelitoCol = objEntDelCol
                .UscComboDelito1._objEntDelitoCol = objEntDelCol
                ._DelitoItem = UscExpeDeResolucionIng1._GrillaItemDelito
                ._objEntDelito = objEnt_
                ._TipoLicencia = Me._TipoLicencia
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
                ._objEntExpedienteTempoCol = UscExpeDeResolucionIng1.objEntExpedienteTempoCol
                ._TipoDocumentoId = Me._TipoResolucion
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
#Region "Otros"
        Public Sub ValoresxDefault()
            With UscNotas1
                ._InternoID = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                .DocumentoTipo = Me._TipoResolucion
                ._SubTipo = Me._Subtipo
                ._LoadUsc()
                UscAuditUser1.LoadAudit(._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With
            With UscExpeDeResolucionIng1
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                ._SubTipo = Me._Subtipo
                ._InternoID = Me._InternoId
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._DocumentoJudicialID = _Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(_Codigo, False)
            End With
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura
        End Sub
#End Region

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

            AGrabar()

        End Sub

        Private Sub frmNota_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub

        Private Sub frmNota_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

            Me.ValoresxDefault()
            Usuario_Permiso()
            UscNotas1._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucionIng1._TipoLicencia = Me._TipoLicencia
        End Sub

        Private Sub UscNotas1__Click_VerFormulario() Handles UscNotas1._Click_VerFormulario
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = UscNotas1.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    UscNotas1.DistritoJudicial = ._DistritoJudicialID
                    UscNotas1.SalaJuzgado = ._GrillaSalaID

                End If
            End With
        End Sub



        Private Sub UscExpeDeResolucionIng1__Click_Expediente_Agregar() Handles UscExpeDeResolucionIng1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Expediente_Editar(objEntExpediente As Entity.Registro.Expediente) Handles UscExpeDeResolucionIng1._Click_Expediente_Editar
            FRM_MantExpediente(False, objEntExpediente)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol) Handles UscExpeDeResolucionIng1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoTempoColGrilla)
        End Sub
        Private Sub UscExpeDeResolucionIng1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol) Handles UscExpeDeResolucionIng1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoTempoColGrilla)
        End Sub
        Private Sub UscExpeDeResolucionIng1__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucionIng1._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucionIng1._Click_Agraviado_Editar
            FRM_MantAgraviado(True, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_PeriodoCondena_Agregar() Handles UscExpeDeResolucionIng1._Click_PeriodoCondena_Agregar
            FRM_MantPeriodoSentencia(True, Nothing)
        End Sub

        Private Sub UscExpeDeResolucionIng1__Click_PeriodoCondena_Editar(objEnt As Entity.Registro.Documento.PeriodoCondenaSentencia) Handles UscExpeDeResolucionIng1._Click_PeriodoCondena_Editar
            FRM_MantPeriodoSentencia(False, objEnt)
        End Sub
    End Class
End Namespace