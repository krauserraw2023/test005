Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos
    Public Class frmMovimientoConducciones
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntInt As Entity.Registro.InternoMovimiento = Nothing

        Public Property _Codigo() As Integer = -1
        Public Property _MovID() As Integer = -1
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _blnBotonCargar() As Boolean = True
        Public Property _CondicionGrupo As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

#Region "Propiedades_Parametricas"
        Public Property _CargarDocumento() As Boolean = False
        Private Property DistritoJudicialID() As Integer
            Get
                Return cbbDistritoJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Public Property SalaJudicialID As Integer = -1

#End Region
#Region "Propiedades"
        Private Property DocumentoNumero() As String
            Get
                Return Me.txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
                'txtNumDocumento.ReadOnly = True
            End Set
        End Property
        Private Property DocumentoFechaRecepcion() As Long
            Get
                Return Me.dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecRecep.ValueLong = value
                'Me.dtpDocJudFecRecep.Enabled = False
            End Set
        End Property
        Private Property DocumentoFecha() As Long
            Get
                Return Me.dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecha.ValueLong = value
                'Me.dtpDocJudFecha.Enabled = False
            End Set
        End Property
        Public Property TipoAutoridadJudicial() As Integer
            Get
                Try
                    Return Me.cbbTipoAutJud.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Private Property SalaJuzgado() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property

        Private Property Juez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                txtJuez.Text = value
                'txtJuez.ReadOnly = True
            End Set
        End Property
        Private Property Secretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                txtSecretario.Text = value
                'txtSecretario.ReadOnly = True
            End Set
        End Property
        Private Property AutoridadOtroCargo() As String
            Get
                Return Me.txtOtraAutoridadCargo.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadCargo.Text = value
                'txtSecretario.ReadOnly = True
            End Set
        End Property
        Private Property AutoridadOtroNombre() As String
            Get
                Return Me.txtOtraAutoridadNombre.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadNombre.Text = value
                'txtSecretario.ReadOnly = True
            End Set
        End Property
        Private Property Observacion() As String = ""

#End Region
#Region "Combo"
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
        End Sub
        Private Sub ComboDistritoJudicial()
            Me.cbbDistritoJud.LoadUsc()
            Me.cbbDistritoJud.SelectedValue = -1
        End Sub
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicialID
                ._Combo()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarDocumentoJudicial()
            Dim objEnt As Entity.Registro.InternoMovimiento
            Dim objBss As Bussines.Registro.InternoMovimiento

            If Me._Codigo < 1 Then Exit Sub

            objEnt = New Entity.Registro.InternoMovimiento
            objBss = New Bussines.Registro.InternoMovimiento
            objEnt.Codigo = Me._Codigo
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
               Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
               Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                objEnt = objBss.Listar_LM(objEnt)
            Else
                objEnt = objBss.Listar(objEnt)
            End If

            With objEnt
                Me._Codigo = .Codigo
                'Me._TipoDocumentoJud = .DocumentoTipo
                Me.DocumentoNumero = .DocumJudicialNum
                Me.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                Me.DocumentoFecha = .DocumJudicialFecha
                Me.TipoAutoridadJudicial = .TipoAutoridadJudicialID
                If Me.TipoAutoridadJudicial = 1 Then
                    PnlAutoridadJudicial.Visible = True
                    PnlOtraAutoridad.Visible = False

                    Me.Juez = .DocJudJuez
                    Me.Secretario = .DocJudSecretario
                Else
                    PnlAutoridadJudicial.Visible = False
                    PnlOtraAutoridad.Visible = True
                End If
                Me.DistritoJudicialID = .AutoridadJudicialID
                Me.SalaJuzgado = .SalaJudicialID
                Me.AutoridadOtroNombre = .DocJudSecretario
                Me.AutoridadOtroCargo = .DocJudJuez
                Me.Observacion = .Observacion
            End With
            InhabilitarControles()
        End Sub
        Private Sub Listar_Usc()
            With uscMovDet
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._Codigo = Me._Codigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._MovimientoTipoID = Me._MovimientoTipoID
                ._intCondicionGrupo = Me._CondicionGrupo
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
            End With

            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            Me.DocumentoFecha = 0
            Me.DocumentoFechaRecepcion = 0
            ListarDocumentoJudicial()

            If Me._Codigo > 0 Then UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)

        End Sub
#End Region
#Region "Accion"
        Dim strmensaje As String = ""
        Private Sub AGrabar()
            If uscMovDet.Validar = True Then
                If Validar() = True Then

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strmensaje) = DialogResult.Yes Then

                        Dim intDocJudicialID As Integer = Me._DocumJudicialID
                        objBssInt = New Bussines.Registro.InternoMovimiento
                        Dim objEntInt As New Entity.Registro.InternoMovimiento
                        objEntInt.MovimientoGrupoID = uscMovDet.MovimientoGrupo
                        objEntInt.IngresoID = uscMovDet._IngresoID
                        objEntInt.IngresoInpeId = uscMovDet._InternoIngresoInpeId
                        objEntInt.Codigo = uscMovDet._Codigo
                        objEntInt.InternoID = uscMovDet._InternoID
                        Dim value As Integer = 0

                        If Me._Codigo < 1 Then

                            If Me._MovimientoTipoID <> Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                                objBssInt = New Bussines.Registro.InternoMovimiento
                                Dim EntMov As New Entity.Registro.InternoMovimiento
                                EntMov.InternoID = Me._InternoID
                                EntMov.IngresoID = Me._IngresoID
                                EntMov.IngresoInpeId = Me._InternoIngresoInpeId
                                Dim EntColec As New Entity.Registro.InternoMovimientoCol
                                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                                    Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                                    EntColec = objBssInt.ListarGrilla_LM(EntMov)
                                Else
                                    EntColec = objBssInt.ListarGrilla(EntMov)
                                End If

                                '************************
                                Dim fec_mov, fec_ult_mov As Date
                                fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                                If fec_mov < fec_ult_mov Then

                                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                                    Exit Sub

                                End If
                            End If
                        End If

                        Dim entObj As New Entity.Registro.InternoMovimiento
                        With entObj
                            .DocumJudicialID = intDocJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero
                            .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                            .DocumJudicialFecha = Me.DocumentoFecha
                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicial
                            .AutoridadJudicialID = Me.DistritoJudicialID
                            .SalaJudicialID = Me.SalaJuzgado
                            .DocJudJuez = Me.Juez
                            .DocJudSecretario = Me.Secretario
                            If Me.TipoAutoridadJudicial > Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                                .OtraAutoridadNombre = Me.AutoridadOtroNombre
                                .OtraAutoridadCargo = Me.AutoridadOtroCargo
                            End If
                            .DocJudObservacion = Me.Observacion
                        End With

                        value = Me.uscMovDet.AGrabar(entObj)

                        If Me._Codigo < 1 Then
                            If value > 0 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        Else
                            If value > 0 Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If
        End Sub
        Private Function Validar() As Boolean
            If Me._Codigo < 1 Then
                If uscMovDet.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    strmensaje = "Desea guardar los datos"
                Else
                    strmensaje = "El estado del movimiento 'Terminado', no permitira realizar ninguna acción," + Chr(13) +
                                 "Desea guardar los datos"
                    Return True
                End If
            Else
                If uscMovDet.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del movimento es [TERMINADO], no podra realizar ninguna acción.")
                    Return False
                Else
                    If uscMovDet.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                        strmensaje = "Desea guardar los cambios en movimientos"
                        Return True
                    Else
                        strmensaje = "El estado del movimiento 'Terminado', no permitira realizar ninguna acción," + Chr(13) +
                                      "Desea guardar los cambios en movimientos."
                        Return True
                    End If
                End If
            End If
            objBssInt = New Bussines.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            EntMov.InternoID = Me._InternoID
            EntMov.IngresoID = Me._IngresoID
            EntMov.IngresoInpeId = Me._InternoIngresoInpeId
            Dim EntColec As New Entity.Registro.InternoMovimientoCol
            If Me.DocumentoNumero = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar el N° del documento")
                txtNumDocumento.Focus()
                Return False
            End If
            If Me._Codigo < 1 Then
                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    EntColec = objBssInt.ListarGrilla_LM(EntMov)
                Else
                    EntColec = objBssInt.ListarGrilla(EntMov)
                End If

                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                If fec_mov <= fec_ult_mov Then

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                    Return False

                End If
            Else
                EntMov.Codigo = Me._Codigo
                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    EntColec = objBssInt.ListarMovimiento_Diferente_LM(EntMov)
                Else
                    EntColec = objBssInt.ListarMovimiento_Diferente(EntMov)
                End If

                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)

                If fec_mov <= fec_ult_mov Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                    Return False
                End If
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
        '            Dim strMensaje As String = ""
        '            strMensaje = "Esta seguro de poner en estado de Terminado, al movimiento !!!"
        '            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar(strMensaje) = DialogResult.Yes Then
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
#Region "Otros"

        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub

        Private Function InhabilitarControles() As Boolean
            If Me.uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                txtNumDocumento.ReadOnly = True
                txtSecretario.ReadOnly = True
                txtJuez.ReadOnly = True
                txtOtraAutoridadCargo.ReadOnly = True
                txtOtraAutoridadNombre.ReadOnly = True
                dtpDocJudFecha.Enabled = False
                dtpDocJudFecRecep.Enabled = False
                cbbTipoAutJud.Enabled = False
                Return True
            End If
            Return False
        End Function
#End Region
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            If cbbTipoAutJud.SelectedValue = 1 Then
                PnlAutoridadJudicial.Visible = True
                PnlOtraAutoridad.Visible = False
            Else
                PnlAutoridadJudicial.Visible = False
                PnlOtraAutoridad.Visible = True
            End If
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            If Me.DistritoJudicialID > 0 Then ComboSalaJuzgado()
        End Sub


        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicialID = UscComboSala1._DistritoJudicialID
            Me.SalaJudicialID = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub frmMovimientoConducciones_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Listar_Usc()
            Usuario_Permiso()
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.DistritoJudicialID
                If .ShowDialog = DialogResult.OK Then
                    Me.DistritoJudicialID = ._DistritoJudicialID
                    Me.SalaJudicialID = ._GrillaSalaID
                End If
            End With
        End Sub

    End Class
End Namespace

