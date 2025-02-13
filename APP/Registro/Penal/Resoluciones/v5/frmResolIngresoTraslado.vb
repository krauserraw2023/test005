Imports Type.Enumeracion.SubTipoDocJudicial
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class frmResolIngresoTraslado
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
#Region "Propiedades"

        Public Property _Codigo As Integer = -1 'DocJudicialId
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _InternoIngresoID() As Integer = -1
        Public Property _blnNuevoRegistro() As Boolean = False
        Public Property _TipoFormulario As Integer = -1
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
        'Public Property _FechaMovimiento() As Long = 0
        'Public Property _MovimientoMov() As Integer = -1
        'Public Property _RegionIngreso() As Integer = -1
        'Public Property _PenalIngreso() As Integer = -1
        'Public Property _DocumentoSubTipo() As Integer = -1
        Public Property DocumentoNumero() As String
            Get
                Return txtNumOficio.Text
            End Get
            Set(value As String)
                txtNumOficio.Text = value
            End Set
        End Property
        Public Property DocumentoFechaRecepcion() As Long
            Get
                Return dtpDocJudFecRecep.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Public Property DocumentoFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property


        Public Property Observacion() As String
            Get
                Return txtObservacion.Text
            End Get
            Set(value As String)
                txtObservacion.Text = value
            End Set
        End Property
        Public Property _FechaMovimiento() As Long = 0
        Public Property _MovimientoMov() As Integer = -1
        Public Property _RegionIngreso() As Integer = -1
        Public Property _PenalIngreso() As Integer = -1
        Public Property _DocumentoSubTipo() As Integer = -1
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
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False

            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                '/*fecha de documento*/
                If Me.DocumentoNumero.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Numero del documento Judicial" + Chr(13) +
                                                                            "de internamiento del penal de origen.")
                    Me.txtNumOficio.Focus()
                    Return blnValue
                End If
                If Me.DocumentoFecha < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha de [Internamiento] al penal de origen.")
                    Me.dtpDocJudFecha.Focus()
                    Return blnValue
                End If
                If Me.DocumentoFechaRecepcion < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha de [Ingreso] al penal de origen.")
                    Me.dtpDocJudFecRecep.Focus()
                    Return blnValue
                End If
                '/*comparacion de fechas*/
                If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de [Internamiento] no puede ser mayor que la fecha de [Ingreso al penal]")
                    blnValue = False
                    Me.dtpDocJudFecha.Focus()
                    Return blnValue
                End If
            End If

            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.DocumentoNumero = Me.DocumentoNumero
            objEnt.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
            objEnt.InternoIngresoId = Me._InternoIngresoID
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y número de documento ya existe")
                txtNumOficio.Focus()
                Return blnValue
            End If
            If UscExpeDeResolucion1._Grilla_NroRegistroExpediente > 0 Then
                If UscExpeDeResolucion1.Validar(-1) = False Then
                    Return blnValue
                End If
            End If
            Return True
        End Function
        Private Function AGrabar() As Integer

            Dim objDocJud As New Entity.Registro.DocumentoJudicial

            Me._blnNuevoRegistro = IIf(Me._Codigo < 1, True, False)
            With UscMovimientoDetalle21
                Me._FechaMovimiento = .FechaRegistroMovimiento
                Me._MovimientoMov = ._MovimientoMotivo
                Me._RegionIngreso = ._RegionIngreso
                Me._PenalIngreso = ._PenalIngreso
            End With
            With objDocJud
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                .DocumentoSubTipoId = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado
                .MovimientoMotivoId = Me._MovimientoMov
                .FechaMovimiento = Me._FechaMovimiento
                .RegionOrigenId = Me._RegionIngreso
                .PenalOrigenId = Me._PenalIngreso
            End With

            Me._Codigo = uscResolIngreso.AGrabar(objDocJud)

            If Me._Codigo = -2 Then Return -2

            UscExpeDeResolucion1._Grabar(Me._Codigo, Me._blnNuevoRegistro)
            If Me._Documento_sin_mov = False Then
                UscMovimientoDetalle21.AGrabar(Me._Codigo, uscResolIngreso.objEnt)
            End If

            Return Me._Codigo
        End Function

        Private Function AGrabarMovimiento() As Integer
            Dim variable As Integer = -1
            If UscMovimientoDetalle21.Validar = True Then
                If btnAceptar.Text = "&Aceptar" Then
                    objBssInt = New Bussines.Registro.InternoMovimiento
                    Dim entMov As New Entity.Registro.InternoMovimiento
                    entMov.InternoID = Me._InternoID
                    entMov.MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento
                    entMov.MovimientoGrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso
                    entMov.IngresoID = Me._InternoIngresoID
                    entMov.IngresoInpeId = Me._InternoIngresoInpeId
                    Dim ContaVal As Integer = objBssInt.ValidaMovimientoInterno(entMov)
                    If ContaVal = -2 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación el interno se reporta como fallecido")
                        Me.Close()
                        Exit Function
                    ElseIf Me._Codigo = -1 Then
                        If ContaVal = -1 Then
                            Dim strMensaje As String = IIf(entMov.MovimientoGrupoID = 1, "INGRESO", "EGRESO")
                            Legolas.Configuration.Aplication.MessageBox.MensajeError("No es posible completar la operación el interno tiene un " & strMensaje & " vigente")
                            Me.Close()
                            Exit Function
                        End If
                    End If
                    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Else
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
                variable = 1
            End If
            Return variable
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
                .objEntExpedienteTempoColCopi2 = UscExpeDeResolucion1.objEntExpedienteTempoCol
                ._TipoResolucion = enumTipoDocumentoJudicial.Ingreso
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
                        ._objEntExpediente.InternoID = Me._InternoID
                        ._objEntExpediente.Nuevo = True
                        Me.UscExpeDeResolucion1._Temporal_GrabarExpediente(._objEntExpediente)
                    End If

                End With
            End If
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
                    'Me.UscExpeDeResolucion._Temporal_GrabarExpediente(._objEntExpediente) '.objEntExpedienteTempoCol)
                End If
            End With
        End Sub
        Private Sub FRM_MantDelito(ByVal Nuevo As Boolean, objEntExpediente As Entity.Registro.Expediente, objEnt_ As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)

            Dim frm As New Registro.Expediente.v5.frmDelitoPopup4
            With frm

                If Nuevo = True Then
                    ._Codigo = -1
                    ._InternoID = Me._InternoID
                    ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                    ._IngresoID = Me._InternoIngresoID
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
                    '._objEntDelito.ExpedienteItem = UscExpeDeResolucion._GrillaItemExpediente
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

#End Region
#Region "otros"
        Public blnValor As Boolean = False
        Private Sub ValoresxDefault()

            With uscResolIngreso
                ._InternoId = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoId = Me._InternoIngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._Codigo = Me._Codigo
                ._TipoLicencia = Me._TipoLicencia
                .DocumentoSubTipo = enumSubTipo.IngresoTraslado
                ._Load(enumSubTipo.IngresoTraslado)
                Me.DocumentoNumero = uscResolIngreso.DocumentoJudicialPenalOrigen
                Dim bssIngreso As New Bussines.Registro.Ingreso
                If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    Me.DocumentoFecha = uscResolIngreso.FechaInternamientoPenalOrigen
                Else
                    Dim objIngres As New Entity.Registro.Ingreso
                    objIngres = bssIngreso.Listar(Me._InternoIngresoID)
                    Me.DocumentoFecha = IIf(Me._Codigo < 1, objIngres.FechaISP, uscResolIngreso.FechaInternamientoPenalOrigen)
                End If
                Me.DocumentoFechaRecepcion = uscResolIngreso.FechadeIngresoPenalOrigen
                Me.Observacion = uscResolIngreso.ObservacionPenalOrigen
                UscAuditUser1.LoadAudit(uscResolIngreso._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.REG_DOC_Judicial)
            End With

            With UscExpeDeResolucion1
                '._VisibleBotonEliminarExpediente = True
                '._VisiblePanelMantExpediente = True
                '._VisiblePanelMantDelito = True
                '._VisiblePanelMantAgraviado = True
                ._TipoResolucion = enumTipoDocumentoJudicial.Ingreso
                ._SubTipo = enumSubTipo.IngresoTraslado
                ._InternoID = Me._InternoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._InternoIngresoID = Me._InternoIngresoID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._TipoLicencia = Me._TipoLicencia
                ._DocumentoJudicialID = _Codigo
                ._FormEscritura = Me._FormEscritura
                ._FormEliminar = Me._FormEliminar
                ._ListarExpediente(uscResolIngreso.objEnt, False)
            End With

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                'nada
                UscMovimientoDetalle21.Visible = Not (Me._Documento_sin_mov)
            Else
                With UscMovimientoDetalle21
                    ._blnNuevo = True
                    ._InternoID = Me._InternoID
                    ._IngresoInpeID = Me._InternoIngresoInpeId
                    ._IngresoID = Me._InternoIngresoID
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                    ._MovimientoGrupo = EnumMovGrupo.Ingreso
                    ._MovimientoTipo2 = EnumMovTipo.Internamiento
                    ._DocumJudicialD = Me._Codigo
                    ._TipoLicencia = Me._TipoLicencia
                    .DocumentoSubTipo = enumSubTipo.IngresoTraslado
                    .Visible = Not (Me._Documento_sin_mov)
                    If Me._Codigo < 1 Then
                        Dim objBssIng As New Bussines.Registro.Ingreso
                        Dim EntMov As New Entity.Registro.Ingreso
                        EntMov = objBssIng.Listar(Me._InternoIngresoID)
                        ._FechaMovimiento = EntMov.FechaIngreso
                        ._LoadUsc()
                        Me.blnValor = True
                        ._blnValor = True
                    Else
                        objBssInt = New Bussines.Registro.InternoMovimiento
                        Dim EntMov As New Entity.Registro.InternoMovimiento
                        EntMov.Codigo = -1
                        EntMov.InternoID = Me._InternoID
                        EntMov.IngresoID = Me._InternoIngresoID
                        EntMov.DocumJudicialID = uscResolIngreso._Codigo
                        .DocumentoSubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.IngresoTraslado
                        ._LoadUsc()
                    
                    End If
                End With
            End If

        End Sub
        
        Private Sub Usuario_Permiso()

            Me.btnAceptar.Visible = Me._FormEscritura
            Me.PnlBotonesGrabar.Visible = Me._FormEscritura

        End Sub
#End Region

        Private Sub UscExpeDeResolucion__Click_AgregarAgraviado(objEntDelito As Entity.Registro.Delito)
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmResolIngreso_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Usuario_Permiso()
            uscResolIngreso._TipoLicencia = Me._TipoLicencia
            UscMovimientoDetalle21._TipoLicencia = Me._TipoLicencia
            UscExpeDeResolucion1._TipoLicencia = Me._TipoLicencia
        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
            If uscResolIngreso.Validar = True Then
                If Me._Documento_sin_mov = False Then
                    If UscMovimientoDetalle21.Validar = True Then
                        If Validar() = True Then
                            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                                If AGrabar() > -1 Then
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                End If
                            End If
                        End If
                    End If
                Else

                    If Validar() = True Then
                        If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar = DialogResult.Yes Then
                            If AGrabar() > -1 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        End If
                    End If
                End If

            End If
        End Sub

        Private Sub uscResolIngreso__Click_btnDatos() Handles uscResolIngreso._Click_btnDatos

            With UscExpeDeResolucion1
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

            With Me.uscResolIngreso
                .DocumentoJudicialPenalOrigen = Me.DocumentoNumero
                .FechaInternamientoPenalOrigen = Me.DocumentoFecha
                .FechadeIngresoPenalOrigen = Me.DocumentoFechaRecepcion
                .ObservacionPenalOrigen = Me.Observacion
            End With

        End Sub

        Private Sub UscExpeDeResolucion__Click_Expediente_Agregar()
            FRM_Grilla()
        End Sub
        Private Sub UscExpeDeResolucion__Click_Expediente_Editar(objEnt As Entity.Registro.Expediente)
            FRM_MantenimientoExpediente(False, objEnt)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEnt As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelCol As Entity.Registro.DelitoCol)
            FRM_MantDelito(False, objEntExpediente, objEnt, objEntCol, objEntDelCol)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado)
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscExpeDeResolucion__Click_Delito_Agregar_(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol)
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoTempoColGrilla)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Agregar(objEntDelito As Entity.Registro.Delito) Handles UscExpeDeResolucion1._Click_Agraviado_Agregar
            FRM_MantAgraviado(True, objEntDelito, Nothing)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Agraviado_Editar(objEntDelito As Entity.Registro.Delito, objEntAgraviado As Entity.Registro.Agraviado) Handles UscExpeDeResolucion1._Click_Agraviado_Editar
            FRM_MantAgraviado(False, objEntDelito, objEntAgraviado)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Delito_Agregar(objEntExpediente As Entity.Registro.Expediente, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion1._Click_Delito_Agregar
            FRM_MantDelito(True, objEntExpediente, Nothing, Nothing, objEntDelitoTempoColGrilla)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Delito_Editar(objEntExpediente As Entity.Registro.Expediente, objEntDelito As Entity.Registro.Delito, objEntCol As Entity.Registro.AgraviadoCol, objEntDelitoTempoColGrilla As Entity.Registro.DelitoCol) Handles UscExpeDeResolucion1._Click_Delito_Editar
            FRM_MantDelito(False, objEntExpediente, objEntDelito, objEntCol, objEntDelitoTempoColGrilla)
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Expediente_Agregar() Handles UscExpeDeResolucion1._Click_Expediente_Agregar
            FRM_Grilla()
        End Sub

        Private Sub UscExpeDeResolucion1__Click_Expediente_Editar(objEntExpediente As Entity.Registro.Expediente) Handles UscExpeDeResolucion1._Click_Expediente_Editar
            FRM_MantenimientoExpediente(False, objEntExpediente)
        End Sub
    End Class

End Namespace