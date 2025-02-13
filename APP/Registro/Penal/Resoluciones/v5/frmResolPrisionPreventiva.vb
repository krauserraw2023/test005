Namespace Registro.Resoluciones
    Public Class frmResolPrisionPreventiva

        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objEntCol As Entity.Registro.DocumentoJudicialCol = Nothing
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing

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
        Public Property _FechaMovimiento() As Long = 0
        Public Property _MovimientoMov() As Integer = -1
        Public Property _RegionIngreso() As Integer = -1
        Public Property _PenalIngreso() As Integer = -1
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
        Private Function AGrabar() As Integer

            Dim objDocJudTmp As New Entity.Registro.DocumentoJudicial

            Me._blnNuevoRegistro = IIf(Me._Codigo < 1, True, False)
            Me._FechaMovimiento = UscMovimientoDetalle21.FechaRegistroMovimiento
            Me._MovimientoMov = UscMovimientoDetalle21._MovimientoMotivo
            '''''''''''''''''''''''''''''''
            With objDocJudTmp
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                .DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva
                .MovimientoMotivoId = Me._MovimientoMov
                .FechaMovimiento = Me._FechaMovimiento
                .RegionOrigenId = Me._RegionIngreso
                .PenalOrigenId = Me._PenalIngreso
                .ProlonDetencionFechIni = UscResolProlongDetencion1.ProlonDetencionFechIni
                .ProlonDetencionFechFin = UscResolProlongDetencion1.ProlonDetencionFechFin
                .ProlonDetencionTipoUnidad = UscResolProlongDetencion1.ProlonDetencionTipoUnidad
                .ProlonDetencionValor = UscResolProlongDetencion1.ProlonDetencionValor
            End With
            '''''''''''''''''''''''''''''''

            objDocJudTmp.Codigo = UscResolIngreso1.AGrabar(objDocJudTmp)

            If objDocJudTmp.Codigo < 0 Then
                Return objDocJudTmp.Codigo
            End If

            UscExpeDeResolucion1._Grabar(objDocJudTmp.Codigo, Me._blnNuevoRegistro)

            If Me._Codigo < 1 And Me._Documento_sin_mov = False Then

                UscMovimientoDetalle21.AGrabar(objDocJudTmp.Codigo, UscResolIngreso1.objEnt)

            End If
            Return objDocJudTmp.Codigo
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
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._TipoLicencia = Me._TipoLicencia
                'permisos
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._FormReporte = Me._FormReporte
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    blnNuevoExpediente = ._NuevoExpediente
                    If blnNuevoExpediente = False Then
                        Me.UscExpeDeResolucion1._Temporal_Grabar_Expediente_Delito_Agraviado(.objEntExpedienteTempoCol, .objEntDelitoTempoCol, .objEntAgraviadoTempoCol)
                    End If
                End If
            End With

            If blnNuevoExpediente = True Then
                Dim frm2 As New Expediente.v5.frmExpedientePopup3
                With frm2
                    ._objEntExpedienteCol = UscExpeDeResolucion1.objEntExpedienteTempoCol
                    ._TipoLicencia = Me._TipoLicencia
                    'permisos
                    ._FormEscritura = Me._FormEscritura
                    ._FormEliminar = Me._FormEliminar
                    ._FormReporte = Me._FormReporte
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        ._objEntExpediente.InternoID = Me._InternoId
                        ._objEntExpediente.Nuevo = True
                        Me.UscExpeDeResolucion1._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)

            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoId
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
                    Me.UscExpeDeResolucion1._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
                End If
            End With
        End Sub
#End Region
#Region "otros"
        Public blnValor As Boolean = False
        Private Sub ValoresxDefault()
            Dim objDoc As New Entity.Registro.DocumentoJudicial
            With UscResolIngreso1
                ._InternoId = Me._InternoId
                ._InternoIngresoId = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                .DocumentoSubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva
                ._LoadUsc()
                UscResolProlongDetencion1._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Prision_Preventiva
                UscResolProlongDetencion1._LoadUsc()
                If Me._Codigo > 0 Then
                    UscResolProlongDetencion1.ProlonDetencionFechIni = .objEnt.ProlonDetencionFechIni
                    UscResolProlongDetencion1.ProlonDetencionFechFin = .objEnt.ProlonDetencionFechFin
                    UscResolProlongDetencion1.ProlonDetencionTipoUnidad = .objEnt.ProlonDetencionTipoUnidad
                    UscResolProlongDetencion1.ProlonDetencionValor = .objEnt.ProlonDetencionValor
                End If
            End With

            With UscExpeDeResolucion1
                ._TipoResolucion = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._InternoID = Me._InternoId
                ._InternoIngresoID = Me._InternoIngresoId
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._DocumentoJudicialID = _Codigo
                ._TipoLicencia = Me._TipoLicencia
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(UscResolIngreso1.objEnt, False, False)
            End With

            With UscMovimientoDetalle21
                ._blnNuevo = True
                ._InternoID = Me._InternoId
                ._IngresoID = Me._InternoIngresoId
                ._IngresoInpeID = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                ._MovimientoTipo2 = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                ._DocumJudicialD = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                .Visible = Not (Me._Documento_sin_mov)
                If .Visible = True Then
                    If Me._Codigo < 1 Then
                        Dim objBssIng As New Bussines.Registro.Ingreso
                        Dim EntMov As New Entity.Registro.Ingreso
                        EntMov = objBssIng.Listar(Me._InternoIngresoId)
                        ._FechaMovimiento = EntMov.FechaIngreso
                        .DocumentoSubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoPrisionPreventiva
                        ._LoadUsc()
                        ._MovimientoMotivo = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva
                        Me.blnValor = True
                        ._blnValor = True
                    Else
                        objBssInt = New Bussines.Registro.InternoMovimiento
                        Dim EntMov As New Entity.Registro.InternoMovimiento
                        EntMov.Codigo = -1
                        EntMov.InternoID = Me._InternoId
                        EntMov.IngresoID = Me._InternoIngresoId
                        EntMov.DocumJudicialID = Me._Codigo
                        Dim Contador As Integer = objBssInt.CuentaMovimientoxIngreso(EntMov)
                        If Contador = 0 Then
                            ._DocumJudicialD = -1
                            UscResolIngreso1.Enabled = True
                            ._LoadUsc()
                            Me.blnValor = True
                            ._blnValor = True
                            ._MovimientoMotivo = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva
                            ._RegionIngreso = objDoc.RegionOrigenId
                            ._PenalIngreso = objDoc.PenalOrigenId
                            ._ListarFecha(objDoc.FechaMovimiento)
                            ._blnEnablecbbMotivo = False
                        Else
                            ._LoadUsc()
                            .ControlesReadOnly()
                            Me.blnValor = False
                            ._blnValor = False
                        End If

                    End If
                End If
            End With
            UscAuditUser1.LoadAudit(UscResolIngreso1._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
        End Sub
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If UscResolIngreso1.Validar = True Then
                If Me._Documento_sin_mov = True Then
                    If UscResolProlongDetencion1.Validar = True Then
                        If UscExpeDeResolucion1.Validar(-1) = True Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                                If AGrabar() > -1 Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                Else
                    If UscResolProlongDetencion1.Validar = True Then
                        If UscMovimientoDetalle21.Validar = True Then
                            If UscExpeDeResolucion1.Validar(-1) = True Then
                                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                                    If AGrabar() > -1 Then
                                        Me.DialogResult = Windows.Forms.DialogResult.OK
                                        Me.Close()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End Sub
        Private Sub frmResolDetencion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()
            UscResolIngreso1._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucion1._TipoLicencia = Me._TipoLicencia
            UscMovimientoDetalle21._TipoLicencia = Me._TipoLicencia
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

        Private Sub UscExpeDeResolucion1__Click_Expediente_Agregar() Handles UscExpeDeResolucion1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Expediente_Editar(objEntExpediente As Entity.Registro.Expediente) Handles UscExpeDeResolucion1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEntExpediente)
        End Sub


        Private Sub UscResolIngreso1__Click_btnDatos() Handles UscResolIngreso1._Click_btnDatos
            With UscExpeDeResolucion1
                If ._Grilla_NroRegistroExpediente > 0 Then
                    If .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID = 1 Then

                        UscResolIngreso1._TipoAutoridadJudicialID = .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID
                        UscResolIngreso1._DistritoJudicialID = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialID
                        UscResolIngreso1._DistritoJudicialNombre = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialNombre
                        UscResolIngreso1._SalaJuzgado = .objEntExpedienteTempoCol.Item(0).SalaJudicialID
                        UscResolIngreso1._Juez = .objEntExpedienteTempoCol.Item(0).ExpedienteJuez
                        UscResolIngreso1._Secretario = .objEntExpedienteTempoCol.Item(0).ExpedienteSecretario
                        UscResolIngreso1._OtraAutoridadNombre = .objEntExpedienteTempoCol.Item(0).AutoridadOtro
                        UscResolIngreso1._OtraAutoridadCargo = .objEntExpedienteTempoCol.Item(0).AutoridadOtroCargo


                    Else
                        If .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID = -1 Then
                            If .objEntExpedienteTempoCol.Item(0).SalaJudicialID > 0 Then
                                Me.UscResolIngreso1._TipoAutoridadJudicialID = 1
                                Me.UscResolIngreso1._DistritoJudicialID = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialID
                                Me.UscResolIngreso1._DistritoJudicialNombre = .objEntExpedienteTempoCol.Item(0).AutoridadJudicialNombre
                                Me.UscResolIngreso1._SalaJuzgado = .objEntExpedienteTempoCol.Item(0).SalaJudicialID
                                Me.UscResolIngreso1._Juez = .objEntExpedienteTempoCol.Item(0).ExpedienteJuez
                                Me.UscResolIngreso1._Secretario = .objEntExpedienteTempoCol.Item(0).ExpedienteSecretario
                            Else
                                Me.UscResolIngreso1._DistritoJudicialID = 2
                                Me.UscResolIngreso1._DistritoJudicialNombre = ""
                                Me.UscResolIngreso1._SalaJuzgado = -1
                                Me.UscResolIngreso1._SalaJuzgadoNombre = ""
                                Me.UscResolIngreso1._Juez = ""
                                Me.UscResolIngreso1._Secretario = ""
                                Me.UscResolIngreso1._OtraAutoridadNombre = .objEntExpedienteTempoCol.Item(0).AutoridadOtro
                                Me.UscResolIngreso1._OtraAutoridadCargo = .objEntExpedienteTempoCol.Item(0).AutoridadOtroCargo
                            End If
                        Else
                            Me.UscResolIngreso1._TipoAutoridadJudicialID = .objEntExpedienteTempoCol.Item(0).TipoAutoridadJudicialID
                            Me.UscResolIngreso1._DistritoJudicialID = -1
                            Me.UscResolIngreso1._DistritoJudicialNombre = ""
                            Me.UscResolIngreso1._SalaJuzgado = -1
                            Me.UscResolIngreso1._SalaJuzgadoNombre = ""
                            Me.UscResolIngreso1._Juez = ""
                            Me.UscResolIngreso1._Secretario = ""
                            Me.UscResolIngreso1._OtraAutoridadNombre = .objEntExpedienteTempoCol.Item(0).AutoridadOtro
                            Me.UscResolIngreso1._OtraAutoridadCargo = .objEntExpedienteTempoCol.Item(0).AutoridadOtroCargo
                        End If

                    End If

                End If
            End With
        End Sub
    End Class
End Namespace