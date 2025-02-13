Option Explicit On
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos

    Public Class frmMovimientoLibertad
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

#Region "Propiedades_Parametricas"
        Private blnCargarExpedientes As Boolean = False
        Public Property _NroPendientes As Integer = 0
        Private Property DocumentoNumero() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
                txtNumDocumento.ReadOnly = True
            End Set
        End Property

        Private Property DocumentoFechaRecepcion() As Long
            Get
                Return Me.dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecRecep.ValueLong = value
                Me.dtpDocJudFecRecep.Enabled = False
            End Set
        End Property

        Private Property DocumentoFecha() As Long
            Get
                Return Me.dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecha.ValueLong = value
                Me.dtpDocJudFecha.Enabled = False
            End Set
        End Property

        Private Property TipoAutoridadJudicialID() As Integer = -1
        Private Property TipoAutoridadJudicialNom() As String
            Get
                Return Me.txtTipoAutoridad.Text
            End Get
            Set(ByVal value As String)
                txtTipoAutoridad.Text = value
                txtTipoAutoridad.ReadOnly = True
            End Set
        End Property

        Private Property DistritoJudicial() As Integer = -1
        Private Property DistritoJudicialNom() As String
            Get
                Return Me.txtAutoridadJudicial.Text
            End Get
            Set(ByVal value As String)
                txtAutoridadJudicial.Text = value
                txtAutoridadJudicial.ReadOnly = True
            End Set
        End Property

        Private Property SalaJuzgado() As Integer = -1
        Private Property SalaJuzgadoNom() As String
            Get
                Return Me.txtSala.Text
            End Get
            Set(ByVal value As String)
                txtSala.Text = value
                txtSala.ReadOnly = True
            End Set
        End Property

        Private Property _Juez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                txtJuez.Text = value
                txtJuez.ReadOnly = True
            End Set
        End Property
        Private Property _Secretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                txtSecretario.Text = value
                txtSecretario.ReadOnly = True
            End Set
        End Property
        Private Property Observacion() As String = ""
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
#Region "Propiedades"
        Private Property idEstablecimientoMental As Integer = -1
#End Region
#Region "Listar"
        Private Sub Listar_Usc()
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
            End With
            ListarDocumentoJudicial()
            If uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then uscMovDet.ControlesReadOnly()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)
        End Sub

        Private Sub ListarDocumentoJudicial()

            Dim objEnt As New Entity.Registro.DocumentoJudicial
            Dim objBss As New Bussines.Registro.DocumentoJudicial

            If Me._DocumJudicialID < 1 Then Exit Sub
            btnCargarDocumento.Visible = False
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._DocumJudicialID
            objEnt = objBss.Listar_v2(objEnt)

            With objEnt
                Me._DocumJudicialID = .Codigo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.TipoAutoridadJudicialID = .TipoAutoridadJudicial
                Me.TipoAutoridadJudicialNom = .TipoAutoridadJudicialNom
                Me.DistritoJudicial = .DistritoJudicial
                Me.DistritoJudicialNom = .DistritoJudNombre
                Me.SalaJuzgado = .SalaJuzgado
                Me.SalaJuzgadoNom = .SalaJudNombre
                Me._Juez = .JuezNombre
                Me._Secretario = .SecretarioNombre
                Me.AutoridadOtroNombre = .AutoridadOtroNombre
                Me.AutoridadOtroCargo = .AutoridadOtroCargo
                Me.Observacion = .Observacion
                uscMovDet.FechaInscripcionLibertad = .FechaInscripcion
            End With
            UscMovExpediente1._DocumentoJudicialID = Me._DocumJudicialID
            UscMovExpediente1.ListarExpediente2()
        End Sub
        Private Sub FRM_ListadoDocumentos()

            Dim frm As New frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me._DocumJudicialID = ._DocJudicialID
                    ListarDocumentosJudicial()
                End If
            End With

        End Sub
        Dim _MovimientoMotivoAuxID As Integer = -1
        Private Sub ListarDocumentosJudicial()

            Dim bss As New Bussines.Registro.DocumentoJudicial
            Dim obj As New Entity.Registro.DocumentoJudicial
            obj.Codigo = Me._DocumJudicialID
            obj = bss.Listar(obj)

            Me.txtNumDocumento.Text = obj.DocumentoNumero
            dtpDocJudFecha.ValueLong = obj.DocumentoFecha
            dtpDocJudFecRecep.ValueLong = obj.DocumentoFechaRecepcion
            Me.TipoAutoridadJudicialNom = obj.TipoAutoridadJudicialNom
            Me.txtAutoridadJudicial.Text = obj.DistritoJudNombre
            Me.txtSala.Text = obj.SalaJudNombre
            Me.txtJuez.Text = obj.JuezNombre
            Me.txtSecretario.Text = obj.SecretarioNombre
            Dim idMovimientoMotivo As Integer = obj.MovimientoMotivoId


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

            'datos del documento
            Me.uscMovDet.MovimientoMotivo = idMovimientoMotivo

            With Me.UscMovExpediente1
                ._DocumentoJudicialID = Me._DocumJudicialID
                .LoadUsc_()

                Me.idEstablecimientoMental = ._getIdCentroSaludMental
            End With

        End Sub
#End Region
#Region "Accion"
        Private Sub AGrabar()
            If uscMovDet.Validar = True Then
                If ValidarGrabar() = True Then
                    Dim strMensajeGrabar As String = ""

                    If uscMovDet.EstadoID <> Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                        strMensajeGrabar = "Desea guardar los cambios ?"
                    Else
                        strMensajeGrabar = "Recuerde que en estado 'Terminado' no podrá realizar ninguna modificación!" + Chr(13) + "Desea guardar los cambios ?"
                    End If

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensajeGrabar) = DialogResult.Yes Then

                        Dim intMovimientoID As Integer = 0
                        Dim entMovimiento As New Entity.Registro.InternoMovimiento

                        With entMovimiento
                            .Codigo = Me._Codigo
                            .DocumJudicialID = _DocumJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero
                            .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                            .DocumJudicialFecha = Me.DocumentoFecha
                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                            .AutoridadJudicialID = Me.DistritoJudicial
                            .SalaJudicialID = Me.SalaJuzgado
                            .DocJudJuez = Me._Juez
                            .DocJudSecretario = Me._Secretario
                            .DocJudObservacion = Me._Observacion
                            If .TipoAutoridadJudicialID > 1 Then
                                .OtraAutoridadNombre = Me.AutoridadOtroNombre
                                .OtraAutoridadCargo = Me.AutoridadOtroCargo
                            End If
                            '.EstablecimientomentalID = Me.idEstablecimientoMental
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
                    If uscMovDet._FechaMovimiento <= EntColec.InternoMovimiento(0).Fecha Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha igual o superior")
                        Return False
                    End If
                    If Me._TipoLicencia = enmTipoLicencia.PenalProvincia Then
                        If Me._MovimientoTipoID = EnumMovTipo.Libertad Then
                            If Me._DocumJudicialID < 1 Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe referenciar a un documento de Libertad")
                                Return False
                            End If
                        End If
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
                Dim FechaLong As Long = 0
                If EntColec.Count > 0 Then
                    FechaLong = EntColec.InternoMovimiento(0).Fecha
                End If
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(FechaLong, True)
                If fec_mov <= fec_ult_mov Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha igual o superior")
                    Return False
                End If
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

        'Private Sub EjecutarMovimiento()
        '    If ValidarEjecutar() = True Then
        '        If Me._InternoID < 1 Then Exit Sub

        '        objBssInt = New Bussines.Registro.InternoMovimiento
        '        If Me.uscMovDet.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
        '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Este Movimiento ya tiene el estado como [Terminado]")
        '        Else
        '            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar("Esta seguro de poner en estado de Terminado, al movimiento !!!") = DialogResult.Yes Then
        '                Dim valor As Integer = 0
        '                If Me.uscMovDet.MovimientoGrupo = 1 Then
        '                    valor = 1
        '                Else
        '                    valor = 0
        '                End If
        '                Dim objEnt As New Entity.Registro.InternoMovimiento
        '                With objEnt
        '                    .Codigo = uscMovDet._Codigo
        '                    .EstadoID = valor
        '                    .InternoID = Me._InternoID
        '                    .IngresoID = Me._IngresoID
        '                    .IngresoInpeId = Me._InternoIngresoInpeId
        '                    .MovimientoTipoID = uscMovDet.MovimientoTipo
        '                End With
        '                objBssInt.ActualizarEstado(objEnt)

        '                Me.uscMovDet.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
        '                Me.uscMovDet.EstadoTramite = "Terminado"
        '            End If
        '        End If
        '        Me.DialogResult = Windows.Forms.DialogResult.OK
        '        Me.Close()
        '    End If
        'End Sub

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

        Private Sub UscMovExpediente1__Click_GrillaExpediente() Handles UscMovExpediente1._Click_GrillaExpediente
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
            End With
            Me.UscDelito1.LoadUsc()
        End Sub

        Private Sub UscMovExpediente1__CellDoubleClick_GrillaExpediente(ingreso As System.Int32, codigo As System.Int32, EntExp As Entity.Registro.InternoMovimiento) Handles UscMovExpediente1._CellDoubleClick_GrillaExpediente
            FRM_MantExpediente(False, ingreso, codigo, EntExp)
        End Sub

        'Private Sub btnEjecutar_Click(sender As System.Object, e As System.EventArgs)
        '    EjecutarMovimiento()
        'End Sub

        Private Sub frmMovimientoLibertad_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Usuario_Permiso()
        End Sub

        Private Sub UscDelito1__CellDoubleClick_GrillaDelito(IngresoID As System.Int32, ExpedienteCodigo As System.Int32, DelitoCodigo As System.Int32) Handles UscDelito1._CellDoubleClick_GrillaDelito
            FRM_MantDelito(False, -1, ExpedienteCodigo, DelitoCodigo)
        End Sub

        Private Sub btnCargarDocumento_Click(sender As Object, e As EventArgs) Handles btnCargarDocumento.Click
            FRM_ListadoDocumentos()
        End Sub
    End Class
End Namespace

