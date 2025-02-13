Option Explicit On
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos

    Public Class frmMovimientoTrasladoHospitalmental
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntInt As Entity.Registro.InternoMovimiento = Nothing
        Private objExp As Bussines.Registro.Expediente = Nothing
        Private objBssDel As Bussines.Registro.Delito = Nothing
        Private objBssAgr As Bussines.Registro.InternoAgraviado = Nothing

        Public Property _Codigo() As Integer = -1
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _MovimientoMotivoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoDocJudicialID As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Public Property _estadoEjecucionDocumentoJudicial As Integer = -1
        Public Property DocJudicialReferencia_OTHSM_frm As Integer = -1
#Region "Propiedades_Parametricas"
        Private blnCargarExpedientes As Boolean = False
        Public Property _NroPendientes As Integer = 0
        Private Property Movimiento_Observacion_Estado_Ejecucion_frm() As String
            Get
                Return Me.txtObservacionEjecucion.Text
            End Get
            Set(value As String)
                txtObservacionEjecucion.Text = value
            End Set
        End Property
        Private Property DocumentoNumero() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
                txtNumDocumento.ReadOnly = True
            End Set
        End Property

        Private Property TipoAutoridadJudicialID() As Integer = -1


        Private Property DistritoJudicial() As Integer = -1


        Private Property SalaJuzgado() As Integer = -1

        Private Property Observacion() As String = ""
        Private Property Estado_Ejecucion_Ejecutado_frm As Integer
        Public Property _CargarExpedientes() As Boolean
            Get
                Return blnCargarExpedientes
            End Get
            Set(ByVal value As Boolean)
                blnCargarExpedientes = value
                If _CargarExpedientes = True Then
                    Me.uscMovDet._Codigo = Me._Codigo
                    Me.UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
                    Me.UscMovExpediente1._CargarExpedientes = True
                    'Me.UscMovExpediente1.ListarExpediente2()
                End If

            End Set
        End Property
        Private Property AutoridadOtroNombre() As String = ""
        Private Property AutoridadOtroCargo() As String = ""
#End Region
#Region "Listar"
        Private Sub Listar_Usc()
            If Me._MovimientoTipoID = 10 Then
                Me.Text = "Retorno de Hospital de salud mental"
            End If
            With uscMovDet
                ._Codigo = Me._Codigo
                ._MovimientoTipoID = Me._MovimientoTipoID
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._blnNuevo
                ._blnVisibleOrigenDestino = False
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
                If ._Codigo > 0 And .EstadoID = 3 And .MovimientoGrupo = 2 Then
                    grpEstadoEjecucion.Visible = True
                    Dim abc As Integer = ._DocumentoTipoId
                    Select Case ._DocumentoTipoId
                        Case 6, 70
                            ChkEgresoTemporal.Visible = False
                    End Select
                End If
            End With
            Me.DocJudicialReferencia_OTHSM_frm = uscMovDet.DocJudicialReferencia_OTHSM
            Me.Estado_Ejecucion_Ejecutado_frm = uscMovDet.Estado_Ejecucion_Ejecutado
            'Me.Fecha_Seleccionada_Movimiento = uscMovDet._FechaMovimiento

            'estado de ejecucion
            If Me.Estado_Ejecucion_Ejecutado_frm = 1 Then
                Me.chkEstadoEjecucion.Checked = True
            Else
                Me.chkEstadoEjecucion.Checked = False
            End If

            'egreso temporal
            If Me.Estado_Ejecucion_Ejecutado_frm = 2 Then
                Me.ChkEgresoTemporal.Checked = True
            Else
                Me.ChkEgresoTemporal.Checked = False
            End If

            If ChkEgresoTemporal.Checked = True Or chkEstadoEjecucion.Checked = True Then
                Me.Movimiento_Observacion_Estado_Ejecucion_frm = uscMovDet.Movimiento_Observacion_Estado_Ejecucion_MD
            End If

            ListarDocumentoJudicial()
            If Me._TipoDocJudicialID = 74 Then Me.ChkEgresoTemporal.Visible = False
            If uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then uscMovDet.ControlesReadOnly()
            If Me._MovimientoTipoID = 9 And uscMovDet.EstadoID = 3 And Me.Estado_Ejecucion_Ejecutado_frm = 1 Then
                txtObservacionEjecucion.ReadOnly = True
                chkEstadoEjecucion.Enabled = False
                ChkEgresoTemporal.Enabled = False
            End If
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)
        End Sub

        Private Sub ListarDocumentoJudicial()

            Dim objEnt As New Entity.Registro.DocumentoJudicial
            Dim objBss As New Bussines.Registro.DocumentoJudicial
            UscMovExpediente1.DocumentoTipoId = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
            UscMovExpediente1.CamposGrillaVisible()
            If Me._DocumJudicialID < 1 Then Exit Sub
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._DocumJudicialID
            objEnt = objBss.Listar_v2(objEnt)

            With objEnt
                Me._DocumJudicialID = .Codigo
                Me.DocumentoNumero = .DocumentoNumero
                Me._TipoDocJudicialID = .DocumentoTipo
                Me.TipoAutoridadJudicialID = .TipoAutoridadJudicial
                Me.DistritoJudicial = .DistritoJudicial
                Me.SalaJuzgado = .SalaJuzgado
                Me.AutoridadOtroNombre = .AutoridadOtroNombre
                Me.AutoridadOtroCargo = .AutoridadOtroCargo
                Me.Observacion = .Observacion
                Me.FechaRecepcion = .DocumentoFechaRecepcion
                Me.txtFechaDocumento.Text = .DocumentoFechaDate
                Me.txtFechaProgramadaTraslado.Text = .FechaInscripcionDate
                Me.txtObservacionEjecucion.Text = uscMovDet.Movimiento_Observacion_Estado_Ejecucion_MD
            End With

            UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
            UscMovExpediente1._TipoLicencia = Me._TipoLicencia
            UscMovExpediente1.ListarExpediente2()
            If UscMovExpediente1.objEntCol.Count > 0 And Me._MovimientoTipoID = 9 Then
                Me.uscMovDet.OtroLugar = UscMovExpediente1.objEntCol.Item(0).Establecimientomental
            End If
        End Sub
        Private Sub FRM_ListadoDocumentos()

            Dim frm As New frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
                'If _MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental Then
                '    ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                'End If
                ._GrupoID = Me.uscMovDet._getIdMovimientoGrupo
                '._TIpoMovimientoHospitalMental = Me.uscMovDet.MovimientoTipo

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me._DocumJudicialID = ._DocJudicialID
                    Me._TipoDocJudicialID = ._TipoDocJudicialID
                    If ._TipoDocJudicialID = 70 Or ._TipoDocJudicialID = 74 Then
                        Dim bssM As New Bussines.Registro.InternoMovimiento
                        Dim objm As New Entity.Registro.InternoMovimiento
                        Dim EntMov As New Entity.Registro.InternoMovimiento
                        With EntMov
                            EntMov.DocumJudicialID = Me._DocumJudicialID
                        End With

                        ' en PL sale -1 en doc_jud_id_ref
                        If objm.DocJudicialReferencia_OTHSM > 1 Then
                            Me.DocJudicialReferencia_OTHSM_frm = objm.DocJudicialReferencia_OTHSM
                        Else
                            Me.DocJudicialReferencia_OTHSM_frm = Me._DocumJudicialID
                        End If
                    Else
                        Me.DocJudicialReferencia_OTHSM_frm = -1
                    End If
                    ListarDocumentosJudicial()
                End If
            End With

        End Sub
        Dim _MovimientoMotivoAuxID As Integer = -1
        Dim FechaRecepcion As Long = 0
        Private Sub ListarDocumentosJudicial()
            Dim bss As New Bussines.Registro.DocumentoJudicial
            Dim obj As New Entity.Registro.DocumentoJudicial
            obj.Codigo = Me._DocumJudicialID
            obj = bss.Listar(obj)
            Me.txtNumDocumento.Text = obj.DocumentoNumero
            Me.txtFechaDocumento.Text = obj.DocumentoFechaDate
            Me.txtFechaProgramadaTraslado.Text = obj.FechaInscripcionDate
            Me.FechaRecepcion = obj.DocumentoFechaRecepcion

            ' pasar codigo documento inimputable a movimientos
            Select Case Me._MovimientoTipoID
                Case Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental
                    If obj.MovimientoMotivoId = Type.Enumeracion.Movimiento.EnumMovMotivo.Inimputable Then
                        Me.uscMovDet.MovimientoMotivo = 180
                    End If

                    If obj.MovimientoMotivoId = Type.Enumeracion.Movimiento.EnumMovMotivo.PosibleInimputable Then
                        Me.uscMovDet.MovimientoMotivo = 181
                    End If

                Case Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental

                    If obj.MovimientoMotivoId = Type.Enumeracion.Movimiento.EnumMovMotivo.Inimputable Then
                        Me.uscMovDet.MovimientoMotivo = 182
                    End If

                    If obj.MovimientoMotivoId = Type.Enumeracion.Movimiento.EnumMovMotivo.PosibleInimputable Then
                        Me.uscMovDet.MovimientoMotivo = 183
                    End If

            End Select

            Select Case obj.DocumentoSubTipoId
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.NuevoIngreso
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.NuevoIngreso
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoRevocatoria
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoRevocatoria
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva
                Case Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoReincidencia
                    Me._MovimientoMotivoAuxID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReincidencia
            End Select

            UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
            UscMovExpediente1._TipoLicencia = Me._TipoLicencia
            UscMovExpediente1.LoadUsc_()
        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()

            If uscMovDet.Validar = True Then

                If ValidarGrabar() = True Then
                    Dim strMensajeGrabar As String = ""

                    Select Case uscMovDet._getIdEstadoMovimiento
                        Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.Terminado,
                                 Type.Enumeracion.Movimiento.enmEstadoMovimiento.EgresoDifinitivo

                            strMensajeGrabar = "Desea guardar los datos ?"
                        Case Else

                            strMensajeGrabar = "Desea guardar los datos?"
                    End Select


                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) = DialogResult.Yes Then
                        Dim intMovimientoID As Integer = 0
                        Dim entMovimiento As New Entity.Registro.InternoMovimiento

                        With entMovimiento
                            .Codigo = Me._Codigo
                            .DocumJudicialID = _DocumJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero

                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                            .AutoridadJudicialID = Me.DistritoJudicial
                            .SalaJudicialID = Me.SalaJuzgado
                            .DocJudObservacion = Me.Observacion
                            If .TipoAutoridadJudicialID > 1 Then
                                .OtraAutoridadNombre = Me.AutoridadOtroNombre
                                .OtraAutoridadCargo = Me.AutoridadOtroCargo
                            End If

                            uscMovDet._EstadoEjecucionMovimientoOriginal = Me._estadoEjecucionDocumentoJudicial
                            .Establecimientomental = Me.UscMovExpediente1._getCentroSaludMental
                            .DocJudicialReferencia_OTHSM = Me.DocJudicialReferencia_OTHSM_frm

                            .Estado_Ejecucion_Ejecutado = Me.Estado_Ejecucion_Ejecutado_frm

                            If uscMovDet.Estado_Ejecucion_Ejecutado > 40 Then
                                .Estado_Ejecucion_Ejecutado = uscMovDet.Estado_Ejecucion_Ejecutado
                            End If
                            If ChkEgresoTemporal.Checked = True Or chkEstadoEjecucion.Checked = True Then
                                .Movimiento_Observacion_Estado_Ejecucion_IM = Me.Movimiento_Observacion_Estado_Ejecucion_frm
                                uscMovDet.Movimiento_Observacion_Estado_Ejecucion_MD = Me.Movimiento_Observacion_Estado_Ejecucion_frm
                            End If
                        End With

                        intMovimientoID = uscMovDet.AGrabar(entMovimiento)

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End Sub

        Private Function ValidarGrabar() As Boolean
            Dim EntMov As New Entity.Registro.InternoMovimiento
            Dim EntColec As New Entity.Registro.InternoMovimientoCol
            objBssInt = New Bussines.Registro.InternoMovimiento

            If Me._Codigo < 1 Then

                If Me._MovimientoTipoID <> Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then

                    objBssInt = New Bussines.Registro.InternoMovimiento

                    EntMov.InternoID = Me._InternoID
                    EntMov.IngresoID = Me._IngresoID
                    EntMov.IngresoInpeId = Me._InternoIngresoInpeId

                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        EntColec = objBssInt.ListarGrilla_LM(EntMov)
                    Else
                        EntColec = objBssInt.ListarGrilla(EntMov)
                    End If

                    If uscMovDet._Fecha_Movimiento <= EntColec.InternoMovimiento(0).Fecha Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha igual o superior")
                        Return False
                    End If

                    If Me._TipoLicencia = enmTipoLicencia.PenalProvincia Then

                        Select Case Me._MovimientoTipoID
                            Case EnumMovTipo.Libertad,
                                 EnumMovTipo.TrasladoHospitalmental,
                                 EnumMovTipo.RetornodeHospitalmental

                                If Me._DocumJudicialID < 1 Then
                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El movimiento seleccionado debe referenciar un documento judicial.")
                                    Return False
                                End If

                        End Select

                    End If

                End If
            Else
                EntMov.Codigo = Me._Codigo
                EntMov.InternoID = Me._InternoID
                EntMov.IngresoID = Me._IngresoID
                EntMov.IngresoInpeId = Me._InternoIngresoInpeId
                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    EntColec = objBssInt.ListarMovimiento_Diferente_LM(EntMov)
                Else
                    EntColec = objBssInt.ListarMovimiento_Diferente(EntMov)
                End If

                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                If fec_mov <= fec_ult_mov Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha igual o superior")
                    Return False
                End If
            End If
            If uscMovDet._Fecha_Movimiento < Me.FechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha del movimiento que va registrar, es menor" + Chr(13) +
                                                                        "a la fecha de inscripción del documento referenciado [" & Legolas.Components.FechaHora.FechaDate(Me.FechaRecepcion, True) & "]" + Chr(13) +
                                                                        "con N° " & Me.DocumentoNumero) ' )
                Return False
            End If
            If uscMovDet.Enabletcontrol = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del Movimiento es 'Terminado', accion cancelada.")
                Return False
            End If
            If Me._NroPendientes > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe Movimientos anteriores con estado pendiente, acción cancelada")
                Return False
            End If
            Return True
        End Function

        Private Sub EjecutarMovimiento()
            ''''''''''If ValidarEjecutar() = True Then
            If Me._InternoID < 1 Then Exit Sub

            'VALIDAR SI ES NECSARIO O NO?
            'SI ESTA EJECUTADO Y MOVIMIENTO ES TERMINADO
            Dim objMovCol As New Entity.Registro.InternoMovimientoCol
            Dim objMov As New Entity.Registro.InternoMovimiento
            Dim objBss As New Bussines.Registro.InternoMovimiento
            objMov.InternoID = Me._InternoID
            objMov.IngresoID = Me._IngresoID
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                objMovCol = objBss.ListarGrilla_LM(objMov)
            Else
                objMovCol = objBss.ListarGrilla(objMov)
            End If

            ChkEgresoTemporal.Enabled = False
            chkEstadoEjecucion.Enabled = False
            txtObservacionEjecucion.ReadOnly = True

            ''If Legolas.Components.FechaHora.FechaDate(Me.Fecha_Seleccionada_Movimiento) >= Legolas.Components.FechaHora.FechaDate(objMovCol.InternoMovimiento(0).Fecha) Then
            ''    If _estadoEjecucionDocumentoJudicial = 3 And uscMovDet._getIdEstadoMovimiento = 3 Then
            ''        'traslado
            ''        If _MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental Then
            ''            If Estado_Ejecucion_Ejecutado_frm > 0 Then
            ''                If Estado_Ejecucion_Ejecutado_frm = 1 Then
            ''                    chkEstadoEjecucion.Checked = True
            ''                Else
            ''                    ChkEgresoTemporal.Checked = True
            ''                End If
            ''            Else
            ''                chkEstadoEjecucion.Enabled = True
            ''                ChkEgresoTemporal.Enabled = True
            ''            End If
            ''        Else
            ''            'retorno
            ''            chkEstadoEjecucion.Checked = False
            ''            ChkEgresoTemporal.Checked = False
            ''            txtObservacionEjecucion.ReadOnly = True
            ''        End If

            ''        'SI ESTA PENDIENTE DE EJECUCION Y MOVIMIENTO ES TERMINADO
            ''    ElseIf _estadoEjecucionDocumentoJudicial = 2 And uscMovDet._getIdEstadoMovimiento = 3 Then
            ''        If _MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental Then
            ''            If Estado_Ejecucion_Ejecutado_frm > 0 Then
            ''                If Estado_Ejecucion_Ejecutado_frm = 1 Then
            ''                    chkEstadoEjecucion.Checked = True
            ''                Else
            ''                    ChkEgresoTemporal.Checked = True
            ''                End If
            ''            Else
            ''                chkEstadoEjecucion.Enabled = True
            ''                ChkEgresoTemporal.Enabled = True
            ''                txtObservacionEjecucion.ReadOnly = False
            ''            End If
            ''        Else
            ''            grpEstadoEjecucion.Visible = False
            ''        End If
            ''    Else
            ''        grpEstadoEjecucion.Visible = False
            ''    End If
            ''Else
            ''    If Estado_Ejecucion_Ejecutado_frm > 0 And Estado_Ejecucion_Ejecutado_frm < 40 Then
            ''        grpEstadoEjecucion.Visible = True
            ''    Else
            ''        grpEstadoEjecucion.Visible = False
            ''    End If
            ''End If

        End Sub


        Private Function ValidarEjecutar() As Boolean
            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Registrar primero el movimiento, operacion suspendida")
                Return False
            End If
            Return True
        End Function
#End Region
#Region "Forms"
        Private Sub FRM_MantExpediente(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, EntExp As Entity.Registro.InternoMovimiento)

            Dim blnListarDelito As Boolean = False
            Dim frm As New Registro.Expediente.v5.frmExpedientePopup3
            With frm
                If Nuevo = True Then
                    ._Codigo = -1
                Else
                    ._Codigo = ExpedienteCodigo
                    objExp = New Bussines.Registro.Expediente

                    Dim entExpobj As New Entity.Registro.Expediente
                    entExpobj.Codigo = ExpedienteCodigo
                    Dim objExpCol As New Entity.Registro.ExpedienteCol

                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                       Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                       Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        objExpCol = objExp.Listar_v2_LM(entExpobj)
                    Else
                        objExpCol = objExp.Listar_v2(entExpobj)
                    End If

                    ._objEntExpediente = objExpCol.Expediente(0)
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If

            End With
        End Sub

        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, ByVal IngresoCodigo As Integer, ByVal ExpedienteCodigo As Integer, ByVal DelitoCodigo As Integer)

            'listar 4-4
            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm
                If Nuevo = False Then
                    objBssDel = New Bussines.Registro.Delito
                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        Dim ent As New Entity.Registro.Delito
                        ent.Codigo = DelitoCodigo
                        Try
                            ent = objBssDel.Listar2_LM(ent).Item(0)
                        Catch ex As Exception
                        End Try
                        ._objEntDelito = ent
                    Else
                        ._objEntDelito = objBssDel.Listar(DelitoCodigo)
                    End If

                    Dim entExp As New Entity.Registro.Expediente
                    entExp.InternoID = ._objEntDelito.InternoID
                    entExp.IngresoID = ._objEntDelito.IngresoID
                    entExp.IngresoInpeId = ._objEntDelito.IngresoInpeId
                    entExp.InternoDelitoID = ._objEntDelito.Codigo
                    entExp.DelitoEspecificoID = ._objEntDelito.DelitoEspecifico

                    objBssAgr = New Bussines.Registro.InternoAgraviado
                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        ._objEntAgraviadoCol = objBssAgr.Listar_LM_v2(entExp)
                    Else
                        ._objEntAgraviadoCol = objBssAgr.Listar2(entExp)
                    End If
                End If
                ._TipoFormulario = Type.Formulario.Registro.UserControl.ListadoExpediente
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                End If
            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub ComboEstablecimientomental()
            'With Me.cbbEstablecimentomental
            '    ._Todos = True
            '    ._TodosMensaje = "[Seleccionar Establecimiento mental]"
            '    .ComboTipo = Type.Combo.ComboTipo.Establecimientomental
            '    .LoadUsc()
            '    Me.cbbEstablecimentomental.SelectedValue = -1
            'End With
        End Sub
        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub
#End Region
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmMovimientoLibertad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Listar_Usc()
        End Sub

        Private Sub UscMovExpediente1__Click_GrillaExpediente()
            If Me.UscMovExpediente1._GrillaExpId > 0 Then
                With UscDelito1
                    ._InternoID = Me._InternoID
                    ._IngresoID = Me._IngresoID
                    ._IngresoInpeId = Me._InternoIngresoInpeId
                    ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
                End With
                Me.UscDelito1.LoadUsc()
            End If
        End Sub

        Private Sub UscMovExpediente1__Click_ListarDelito() Handles UscMovExpediente1._Click_ListarDelito
            With UscDelito1
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._IngresoInpeId = Me._InternoIngresoInpeId
                ._ExpedienteID = Me.UscMovExpediente1._GrillaExpId
                ._TipoLicencia = Me._TipoLicencia
            End With
            Me.UscDelito1.LoadUsc()
        End Sub

        Private Sub UscMovExpediente1__CellDoubleClick_GrillaExpediente(ingreso As System.Int32, codigo As System.Int32, EntExp As Entity.Registro.InternoMovimiento)
            FRM_MantExpediente(False, ingreso, codigo, EntExp)
        End Sub

        'Private Sub btnEjecutar_Click(sender As System.Object, e As System.EventArgs)
        '    EjecutarMovimiento()
        'End Sub

        Private Sub frmMovimientoLibertad_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Usuario_Permiso()
        End Sub

        Private Sub UscDelito1__CellDoubleClick_GrillaDelito(IngresoID As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32)
            FRM_MantDelito(False, -1, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub UscMovExpediente1__MostrarEstablecimientoMental() Handles UscMovExpediente1._MostrarEstablecimientoMental
            Dim frm As New Registro.Penal.Sentencias.frmListarResolucion
            frm._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                UscMovExpediente1._actualizarEstablecimientoMental(frm._ResolucionTipoID, frm._ResolucionTipoNom)
            End If
        End Sub

        Private Sub uscMovDet_CargarDocumentos() Handles uscMovDet.CargarDocumentos
            FRM_ListadoDocumentos()
        End Sub

        Private Sub chkEstadoEjecucion_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstadoEjecucion.CheckedChanged
            If chkEstadoEjecucion.Checked = True Then
                ChkEgresoTemporal.Checked = False
                Estado_Ejecucion_Ejecutado_frm = 1
            Else
                Estado_Ejecucion_Ejecutado_frm = -1
            End If
        End Sub

        Private Sub ChkEgresoTemporal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEgresoTemporal.CheckedChanged
            If ChkEgresoTemporal.Checked = True Then
                chkEstadoEjecucion.Checked = False
                Me.Estado_Ejecucion_Ejecutado_frm = 2
            Else
                Me.Estado_Ejecucion_Ejecutado_frm = -1
            End If
        End Sub
    End Class
End Namespace

