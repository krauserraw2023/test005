Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos
    Public Class frmMovimientoFuga
        Private objBssInt As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntInt As Entity.Registro.InternoMovimiento = Nothing

#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoMovimiento As Integer = -1
        Public Property _SubTipoID() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades"
        Public Property _ListaExpedienteTotalID As List(Of Integer)
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _TipoAutoridadJudicial() As Integer
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Public Property _DistritoJudicialID() As Integer
            Get
                Return cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Public Property _SalaJudicial() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID_Seleccionado
            End Get
            Set(ByVal value As Integer)
                UscComboSala1._SalaJuzgadoID_Seleccionado = value
            End Set
        End Property


        Public Property DocumentoNumero() As String
            Get
                Return Me.txtNumDocumento.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDocumento.Text = value
            End Set
        End Property
        Public Property DocumentoFechaRecepcion() As Long
            Get
                Return Me.dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Public Property DocumentoFecha() As Long
            Get
                Return Me.dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecha.ValueLong = value
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
        Public Property DistritoJudicialID() As Integer
            Get
                Try
                    Return Me.cbbDistritoJud.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Public Property DistritoJudicialNum() As String
            Get
                Try
                    Return Me.txtNumDocumento.Text
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As String)
                Me.txtNumDocumento.Text = value
            End Set
        End Property

        Public Property SalaJuzgado() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property

        Public Property _Juez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                Me.txtJuez.Text = value
            End Set
        End Property
        Public Property _Secretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                Me.txtSecretario.Text = value
            End Set
        End Property
        Public Property AutoridadOtroCargo() As String
            Get
                Return Me.txtOtraAutoridadCargo.Text
            End Get
            Set(ByVal value As String)
                Me.txtOtraAutoridadCargo.Text = value
            End Set
        End Property
        Public Property AutoridadOtroNombre() As String
            Get
                Return Me.txtOtraAutoridadNombre.Text
            End Get
            Set(ByVal value As String)
                Me.txtOtraAutoridadNombre.Text = value
            End Set
        End Property
        Public Property _Observacion() As String = ""
        '    Get
        '        Return Me.txtObsLib.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtObsLib.Text = value
        '    End Set
        'End Property
#End Region
#Region "Combo"
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            Me.cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
        End Sub
        Private Sub ComboDistritoJudicial()
            Me.cbbDistritoJud.LoadUsc()
            Me.cbbDistritoJud.SelectedValue = -1
        End Sub
        Public Property SalaJudicialID() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me._DistritoJudicialID
                ._Combo()
            End With
        End Sub
#End Region
#Region "Listar"

        Private Sub ListarUsc()
            btnCargarDocumento.Enabled = False
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            'Me.Size = New Size(687, 455)
            Me.Size = New Size(687, 485)
            Me._SubTipoID = IIf(Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Fuga, 7, 6)
            Me.Text = IIf(Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Fuga, "Fuga", "Fallecimiento")
            With uscMovDet
                ._Codigo = Me._Codigo
                ._MovimientoTipoID = Me._MovimientoTipoID
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoLicencia = Me._TipoLicencia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._blnNuevo = Me._blnNuevo
                ._blnVisibleOrigenDestino = False
                ._blnVisiblecbbMotivo = False
                ._blnVisiblelblMotivo = False
                ._TipoLicencia = Me._TipoLicencia
                ._LoadUsc()
            End With
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                Me.rbtSi.Enabled = True
            End If
            If Me._Codigo > 0 Then
                objEntInt = New Entity.Registro.InternoMovimiento
                objBssInt = New Bussines.Registro.InternoMovimiento
                objEntInt.Codigo = Me._Codigo

                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    objEntInt = objBssInt.Listar_LM(objEntInt)
                Else
                    objEntInt = objBssInt.Listar(objEntInt)
                End If

                With objEntInt
                    Me._DocumJudicialID = .DocumJudicialID
                    If Me._DocumJudicialID > 0 Then
                        rbtSi.Checked = True
                    End If
                    Me.DocumentoNumero = .DocumJudicialNum
                    Me.DocumentoFecha = .DocumJudicialFecha
                    Me.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                    Me._TipoAutoridadJudicial = .TipoAutoridadJudicialID
                    If Me._TipoAutoridadJudicial = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                        Me._DistritoJudicialID = .AutoridadJudicialID
                        Me.SalaJuzgado = .SalaJudicialID
                        Me._Juez = .DocJudJuez
                        Me._Secretario = .DocJudSecretario
                    Else
                        Me.AutoridadOtroCargo = .DocJudJuez
                        Me.AutoridadOtroNombre = .DocJudSecretario
                    End If
                End With
                InhabilitarControlesDoc()
                InhabilitarControles()
                UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)
            End If
        End Sub
#Region "Accion"
        Private strMensaje As String = ""
        Private Sub AGrabar()
            objBssInt = New Bussines.Registro.InternoMovimiento

            If uscMovDet.Validar = True Then

                If Validar() = True Then

                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                        If Me._Codigo < 1 Then
                            objBssInt = New Bussines.Registro.InternoMovimiento
                            Dim EntMov As New Entity.Registro.InternoMovimiento
                            EntMov.InternoID = Me._InternoID
                            EntMov.IngresoID = Me._IngresoID
                            Dim EntColec As New Entity.Registro.InternoMovimientoCol
                            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                                Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                                EntColec = objBssInt.ListarGrilla_LM(EntMov)
                            Else
                                EntColec = objBssInt.ListarGrilla(EntMov)
                            End If

                            '**********************
                            Dim fec_mov, fec_ult_mov As Date
                            fec_mov = Legolas.Components.FechaHora.FechaDate(uscMovDet._Fecha_Movimiento, True)
                            fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, False)
                            If fec_mov < fec_ult_mov Then
                                Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                                Exit Sub
                            End If
                        End If
                        Dim value As Integer = 0
                        Dim entobj As New Entity.Registro.InternoMovimiento
                        With entobj
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .DocumJudicialID = Me._DocumJudicialID
                            .DocumJudicialNum = Me.DocumentoNumero
                            .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                            .DocumJudicialFecha = Me.DocumentoFecha
                            .TipoAutoridadJudicialID = Me.TipoAutoridadJudicial
                            .AutoridadJudicialID = Me.DistritoJudicialID
                            .SalaJudicialID = Me.SalaJuzgado
                            .DocJudJuez = Me._Juez
                            .DocJudSecretario = Me._Secretario
                            .OtraAutoridadNombre = Me.AutoridadOtroNombre
                            .OtraAutoridadCargo = Me.AutoridadOtroCargo
                            .DocJudObservacion = Me._Observacion
                        End With
                        value = Me.uscMovDet.AGrabar(entobj)
                        If value > 0 Then
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End Sub

        Private Function Validar() As Boolean
            Dim blnValue As Boolean = False
            If Me._Codigo < 1 Then
                If uscMovDet.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                    strMensaje = "Desea guardar los datos"
                Else
                    strMensaje = "El estado del movimiento [Terminado], no permitira realizar ninguna acción," + Chr(13) +
                                 "Desea guardar los datos"
                End If
                blnValue = True
            Else
                If Me.uscMovDet.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del movimento es [TERMINADO], no podra realizar ninguna acción.")
                    Return False
                End If
                If uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                    strMensaje = "Desea guardar los cambios en movimientos"
                Else
                    strMensaje = "El estado del movimiento [Terminado], no permitira realizar ninguna acción," + Chr(13) +
                                  "Desea guardar los cambios en movimientos."
                End If
                blnValue = True
            End If
            If Me._RegionID < 1 Or Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Parametros [Region/Penal], no fueron enviados al Objeto")
                blnValue = False
            ElseIf Me.TipoAutoridadJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese Tipo de autoridad judicial")
                blnValue = False
                Me.cbbTipoAutJud.Focus()
            ElseIf Me.DocumentoNumero.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese el Numero del documento Judicial")
                blnValue = False
                Me.txtNumDocumento.Focus()
            ElseIf Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
            ElseIf Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                blnValue = False
                Me.dtpDocJudFecha.Focus()
                '/*validar libertad*/
            ElseIf Me.TipoAutoridadJudicial = 1 Then
                If Me.DistritoJudicialID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito judicial")
                    blnValue = False
                    Me.cbbDistritoJud.Focus()
                End If
            Else
                'nombre autoridad - otro
                If Me.AutoridadOtroNombre.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre de la autoridad")
                    blnValue = False
                    Me.txtOtraAutoridadNombre.Focus()
                    'cargo autoridad - otro
                ElseIf Me.AutoridadOtroCargo.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el cargo de la autoridad")
                    blnValue = False
                    Me.txtOtraAutoridadCargo.Focus()
                End If
            End If
            objBssInt = New Bussines.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            EntMov.InternoID = Me._InternoID
            EntMov.IngresoID = Me._IngresoID
            Dim EntColec As New Entity.Registro.InternoMovimientoCol
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
            Return blnValue
        End Function

        Private Function InhabilitarControles() As Boolean
            If Me.uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                HabilitarControlesDoc(False)
                Return True
            End If
            Return False
        End Function

        Public Sub ControlesReadOnly()

            Me.txtNumDocumento.ReadOnly = True
            Me.txtNumDocumento.Enabled = False
            Me.dtpDocJudFecRecep.Enabled = False
            Me.dtpDocJudFecha.Enabled = False
            Me.cbbTipoAutJud.Enabled = False
            Me.cbbDistritoJud.Enabled = False
            Me.UscComboSala1.Enabled = False
            Me.txtJuez.ReadOnly = True
            Me.txtSecretario.ReadOnly = False
            Me.txtOtraAutoridadCargo.ReadOnly = True
            Me.txtOtraAutoridadNombre.ReadOnly = True
        End Sub

        Private Function ValidarEjecutar() As Boolean
            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Registrar primero el movimiento, operacion suspendida")
                Return False
            End If
            Return True
        End Function
#End Region

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub
#End Region
#Region "Form"
        Private Sub FRM_ListadoDocumentos()
            Dim frm As New frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
                ._SubTipoDocJudicialID = Me._SubTipoID
                ._TipoLicencia = Me._TipoLicencia
                ' ._Load()
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    With .Grilla_ObjetoSeleccionado
                        Me._DocumJudicialID = .Codigo
                        Me.DocumentoNumero = .DocumentoNumero
                        Me.DocumentoFecha = .DocumentoFecha
                        Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                        Me._TipoAutoridadJudicial = .TipoAutoridadJudicial
                        Me.DistritoJudicialID = .DistritoJudicial
                        Me.SalaJuzgado = .SalaJuzgado
                        Me._Juez = .JuezNombre
                        Me._Secretario = .SecretarioNombre
                        Me.AutoridadOtroNombre = .AutoridadOtroNombre
                        Me.AutoridadOtroCargo = .AutoridadOtroCargo
                    End With
                    InhabilitarControlesDoc()
                End If
            End With
        End Sub

        Private Sub AutJudicialOtro()
            Select Case Me._TipoAutoridadJudicial
                Case Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
                    Me.PnlAutoridadJudicial.Visible = True
                    Me.PnlOtraAutoridad.Visible = False
                    Me.txtOtraAutoridadCargo.Text = ""
                    Me.txtOtraAutoridadNombre.Text = ""
                Case Else
                    Me.PnlAutoridadJudicial.Visible = False
                    Me.PnlOtraAutoridad.Visible = True
                    Me.cbbDistritoJud.SelectedIndex = -1
                    Me.UscComboSala1._SalaJuzgadoID = -1
                    Me.txtJuez.Text = ""
                    Me.txtSecretario.Text = ""
            End Select

        End Sub

        Private Sub InhabilitarControlesDoc()
            If Me._DocumJudicialID > 0 Then
                txtNumDocumento.ReadOnly = True
                dtpDocJudFecha.Enabled = False
                dtpDocJudFecRecep.Enabled = False
                cbbTipoAutJud.Enabled = False
                cbbDistritoJud.Enabled = False
                UscComboSala1.Enabled = False
                txtJuez.ReadOnly = True
                txtSecretario.ReadOnly = True
                txtOtraAutoridadNombre.ReadOnly = True
                txtOtraAutoridadCargo.ReadOnly = True
            End If
        End Sub

        Private Sub HabilitarControlesDoc(Valor As Boolean)
            txtNumDocumento.ReadOnly = Not (Valor)
            dtpDocJudFecha.Enabled = Valor
            dtpDocJudFecRecep.Enabled = Valor
            cbbTipoAutJud.Enabled = Valor
            cbbDistritoJud.Enabled = Valor
            UscComboSala1.Enabled = Valor
            txtJuez.ReadOnly = Not (Valor)
            txtSecretario.ReadOnly = True
            txtOtraAutoridadNombre.ReadOnly = Not (Valor)
            txtOtraAutoridadCargo.ReadOnly = Not (Valor)
            If uscMovDet.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                rbtSi.Enabled = Valor
                rbtNo.Enabled = Valor
            End If
            btnCargarDocumento.Enabled = Valor
        End Sub

        Private Sub LimpiarControlesDoc()
            txtNumDocumento.Clear()
            dtpDocJudFecha.ValueLong = 0
            dtpDocJudFecRecep.ValueLong = 0
            cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
            cbbDistritoJud.SelectedValue = -1
            UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            txtJuez.Clear()
            txtSecretario.Clear()
            txtOtraAutoridadNombre.Clear()
            txtOtraAutoridadCargo.Clear()
        End Sub
#End Region

        Private Sub frmMovimientoFuga_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarUsc()
            Usuario_Permiso()
        End Sub

        Private Sub btnCargarDocumento_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarDocumento.Click
            FRM_ListadoDocumentos()
        End Sub

        Private Sub rbtSi_Click(sender As Object, e As System.EventArgs) Handles rbtSi.Click
            btnCargarDocumento.Enabled = True
        End Sub

        Private Sub rbtNo_Click(sender As Object, e As System.EventArgs) Handles rbtNo.Click
            btnCargarDocumento.Enabled = False
        End Sub

        Private Sub UscDocumJudicial1__ClicK_VerFormulario()
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me._DistritoJudicialID
                If .ShowDialog = DialogResult.OK Then
                    Me._DistritoJudicialID = ._DistritoJudicialID
                    Me._SalaJudicial = ._GrillaSalaID
                End If
            End With
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            AutJudicialOtro()
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            If Me._DistritoJudicialID > 0 Then ComboSalaJuzgado()
        End Sub

        Private Sub rbtSi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSi.CheckedChanged
            If rbtSi.Checked = True Then
                Me.btnCargarDocumento.Enabled = True
                HabilitarControlesDoc(False)
            Else
                Me.btnCargarDocumento.Enabled = False
                HabilitarControlesDoc(True)
                txtNumDocumento.Focus()
            End If
            LimpiarControlesDoc()
        End Sub

        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicialID = UscComboSala1._DistritoJudicialID
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado
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

