Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Movimientos
    Public Class frmMovimientoTraslado
        Private objBssMov As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntMov As Entity.Registro.InternoMovimiento = Nothing

        Private bDatosCargados As Boolean = False
#Region "Propiedades_Parametricas"
        Dim [Me] As Object

        Public Property _Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        'Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

        Private Property intMovimientoID As Integer = -1
        Public Property _TipoCarga As String = ""
        Public Property _DocumJudicialID() As Integer = -1

        Public Property _DocumJudicialNumero() As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
            End Set
        End Property
        Private Property _DocumFecha() As Long
            Get
                Return Me.dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecha.ValueLong = value
            End Set
        End Property
        Private Property _DocumFechaRecepcion() As Long
            Get
                Return Me.dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Private Property TipoAutoridadJudicialID() As Integer
            Get
                Return Me.cbbTipoAutJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Private Property DistritoJudicialID() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property SalaJudicialID() As Integer
            Get
                Return Me.UscComboSala1._SalaJuzgadoID
            End Get
            Set(ByVal value As Integer)
                Me.UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
        Private Property DocJuez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                Me.txtJuez.Text = value
            End Set
        End Property
        Private Property DocSecretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                Me.txtSecretario.Text = value
            End Set
        End Property
        Private Property AutoridadOtroNombre() As String
            Get
                Return Me.txtOtraAutoridadNombre.Text
            End Get
            Set(ByVal value As String)
                Me.txtOtraAutoridadNombre.Text = value
            End Set
        End Property
        Private Property AutoridadOtroCargo() As String
            Get
                Return Me.txtOtraAutoridadCargo.Text
            End Get
            Set(ByVal value As String)
                Me.txtOtraAutoridadCargo.Text = value
            End Set
        End Property

        Public Property _MovimientoTipoID() As Integer = -1

        Private Property _MovimientoMotivoID() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoDocJudicialID As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado
        Public Property _blnBotonCargar As Integer = -1
        Public Property _ListaExpedienteTotalID As List(Of Integer)
        Public Property _TipoLicencia As Integer = -1
        Private blnCargarDocumentoJudicial As Boolean = False

        Public Property _CondicionGrupo As Integer = -1
        Public Property EstadoID() As Integer = 1
        Public Property EstadoAuxID() As Integer = -1
        Public Property EstadoNom() As String
            Get
                Return cbbMovestado.Text
            End Get
            Set(ByVal value As String)
                cbbMovestado.Text = value
            End Set
        End Property
        Public Property _RegionMovID() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Public Property _PenalMovID() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Public Property strObservacion() As String
            Get
                Return txtObservacion.Text
            End Get
            Set(ByVal value As String)
                txtObservacion.Text = value
            End Set
        End Property
        Public Property _FechaMovimiento() As Long
            Get
                Return Me.dtpFechaMov.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaMov.ValueLong = value
            End Set
        End Property
        Private Property HoraMovimiento() As String
            Get
                Return Me.nudHora._Value
            End Get
            Set(ByVal value As String)
                Me.nudHora._Value = value
            End Set
        End Property
        Private Property MinutoMovimiento() As String
            Get
                Return Me.nudMinutos._Value
            End Get
            Set(ByVal value As String)
                Me.nudMinutos._Value = value
            End Set
        End Property
        Public Property MovimientoGrupo() As Integer = -1
        Public Property MovimientoGrupoNom() As String
            Get
                Return txtMovimientoGrupo.Text
            End Get
            Set(value As String)
                If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                    value = "INGRESO"
                    lblRegion.Text = "Region Origen :"
                ElseIf Me.MovimientoGrupo = 2 Then
                    value = "EGRESO"
                    lblRegion.Text = "Region Destino :"
                Else
                    value = "Region :"
                End If
                Me.txtMovimientoGrupo.Text = value
            End Set
        End Property
#End Region
#Region "Listar"
        Private Sub ListarData()
            If Me._Codigo < 1 Then
                Me.bDatosCargados = True
                Exit Sub
            End If

            objEntMov = New Entity.Registro.InternoMovimiento
            objEntMov.Codigo = Me._Codigo

            objEntMov = (New Bussines.Registro.InternoMovimiento).Listar(objEntMov)

            With objEntMov
                Me.MovimientoGrupo = .MovimientoGrupoID
                Me.MovimientoGrupoNom = .MovimientoGrupoNombre
                If .MovimientoMotivoID = EnumMovMotivo.IngresoTraslado Then
                    txtMotivo.Visible = True
                    txtMotivo.Text = "INGRESO POR TRASLADO"
                Else
                    Me._MovimientoMotivoID = .MovimientoMotivoID
                    txtMotivo.Visible = False
                End If
                Me._FechaMovimiento = .Fecha
                Dim f As Date
                f = Legolas.Components.FechaHora.FechaDate(.Fecha, True)
                Me.HoraMovimiento = Format(f, "HH")
                Me.MinutoMovimiento = Format(f, "mm")
                Me.cbbMovestado.SelectedValue = .EstadoID
                Me.EstadoID = .EstadoID
                Me.EstadoAuxID = .EstadoID
                Me.EstadoNom = .EstadoNombre
                If Me.MovimientoGrupo = EnumMovGrupo.Ingreso Then
                    Me._RegionMovID = .RegionOrigenID
                    Me._PenalMovID = .PenalOrigenID
                    Me._RegionID = .RegionDestinoID
                    Me._PenalID = .PenalDestinoID
                Else
                    Me._RegionID = .RegionOrigenID
                    Me._PenalID = .PenalOrigenID
                    Me._RegionMovID = .RegionDestinoID
                    Me._PenalMovID = .PenalDestinoID
                End If
                Me.strObservacion = .Observacion
                'Datos del documento
                If .DocumJudicialID > 0 Then
                    Me.rbtSi.Checked = True
                    Me.rbtNo.Checked = False
                Else
                    Me.rbtSi.Checked = False
                    Me.rbtNo.Checked = True
                End If
                Me._DocumJudicialNumero = .DocumJudicialNum
                Me._DocumFecha = .DocumJudicialFecha
                Me._DocumFechaRecepcion = .DocumJudicialFecharecepcion
                Me.TipoAutoridadJudicialID = .TipoAutoridadJudicialID
                If Me.TipoAutoridadJudicialID = EnumTipoAutoridad.AutoridadJudicial Then
                    Me.DistritoJudicialID = .AutoridadJudicialID
                    Me.SalaJudicialID = .SalaJudicialID
                    Me.DocJuez = .DocJudJuez
                    Me.DocSecretario = .DocJudSecretario
                Else
                    Me.AutoridadOtroNombre = .DocJudJuez
                    Me.AutoridadOtroCargo = .DocJudSecretario
                End If
                InhabilitarControlesDoc()
                InhabilitarControles()
            End With
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)
        End Sub

        Private Sub ValoresListar()
            ListarData()
        End Sub

        Private Function InhabilitarControles() As Boolean
            If Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                rbtSi.Enabled = False
                rbtNo.Enabled = False
                btnCargarDocumento.Enabled = False
                cbbMovestado.Enabled = False
                cbbMovMotivo.Enabled = False
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False
                cbbRegion.Enabled = False
                cbbPenal.Enabled = False
                Me.txtObservacion.ReadOnly = True
                '--------Controles del documento
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
        End Function

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
            txtObservacion.Clear()
        End Sub

        Private Sub HabilitarControlesDoc(Valor As Boolean)
            'Inactivar()
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
        End Sub
#End Region
#Region "Accion"

        Private ReadOnly Property FechaRegistroMovimiento As Long
            Get
                Dim FechaTotal As String = ""
                Dim fecha As String = dtpFechaMov.Value & " " & CStr(HoraMovimiento) & ":" & CStr(MinutoMovimiento) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
            End Get
        End Property

        Private strMensaje As String = ""

        Private Function Validar() As Boolean
            If Me._Codigo < 1 Then
                If Me.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    strMensaje = "Desea guardar los datos"
                Else
                    If cbbPenal.Text = "" Then
                        If txtMovimientoGrupo.Text = "INGRESO" Then
                            If rbtSi.Checked = True Then
                                strMensaje = "Antes de cambiar el estado a terminado debe seleccionar el documento de traslado."
                            Else
                                strMensaje = "Para finalizar debe especificar el establecimiento origen."
                            End If
                        Else
                            If rbtSi.Checked = True Then
                                strMensaje = "Antes de cambiar el estado a terminado debe seleccionar el documento de traslado."
                            Else
                                strMensaje = "Para finalizar debe especificar el establecimiento destino."
                            End If
                        End If
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Return False
                    End If
                    
                    strMensaje = "El estado del movimiento 'Terminado', no permitirá realizar ninguna acción," + Chr(13) +
                                 "Desea guardar los datos?"
                    Return True
                End If
            Else
                If Me.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del movimento es [TERMINADO], no podra realizar ninguna acción.")
                    Return False
                Else
                    If Me.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                        strMensaje = "Desea guardar los cambios en movimientos?"
                    Else
                        strMensaje = "El estado del movimiento 'Terminado', no permitira realizar ninguna acción," + Chr(13) +
                                      "Desea guardar los cambios en movimientos?"
                    End If
                    Return True
                End If
            End If

            If Me._Codigo > 0 And Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del movimiento [Terminado]," + Chr(13) +
                                                                        "No permitira realizar ninguna acción.")
                btnCancel.Focus()
                Return False
            End If

            If cbbMovMotivo.SelectedValue = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar el motivo del movimiento")
                cbbMovMotivo.Focus()
                Return False
            End If

            If Me.dtpFechaMov.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha del Movimiento")
                dtpFechaMov.Focus()
                Return False
            End If

            objBssMov = New Bussines.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            EntMov.InternoID = Me._InternoID
            EntMov.IngresoID = Me._IngresoID
            EntMov.IngresoInpeId = Me._InternoIngresoInpeId
            Dim EntColec As New Entity.Registro.InternoMovimientoCol

            If Me._Codigo < 1 Then
                'If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                '    EntColec = objBssMov.ListarGrilla_LM(EntMov)
                'Else
                EntColec = objBssMov.ListarGrilla(EntMov)
                    If Len(Me._DocumJudicialNumero) < 3 Then
                        If rbtSi.Checked = True Then
                            strMensaje = "Debe referenciar un documento de traslado."
                            btnCargarDocumento.Focus()
                        Else
                            strMensaje = "Ingresar un Documento de traslado"
                            txtNumDocumento.Focus()
                        End If
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Return False
                    End If
                    'End If

                    Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(Me.FechaRegistroMovimiento, True)
                If EntColec.Count = 0 Then
                    fec_ult_mov = Legolas.Components.FechaHora.FechaDate(0, True)
                Else
                    fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                End If

                If fec_mov <= fec_ult_mov Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                    Return False
                End If
            Else
                EntMov.Codigo = Me._Codigo
                'If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                '    EntColec = objBssMov.ListarMovimiento_Diferente_LM(EntMov)
                'Else
                EntColec = objBssMov.ListarMovimiento_Diferente(EntMov)
                    If Len(Me._DocumJudicialNumero) < 3 Then
                        If rbtSi.Checked = True Then
                            strMensaje = "Debe referenciar un documento de traslado."
                            btnCargarDocumento.Focus()
                        Else
                            strMensaje = "Ingresar un Documento de traslado"
                            txtNumDocumento.Focus()
                        End If
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                        Return False
                    End If
                    'End If

                    Dim FechaLong As Long = 0
                If EntColec.Count = 0 Then
                    FechaLong = 0
                Else
                    FechaLong = EntColec.InternoMovimiento(0).Fecha
                End If
                '************************
                Dim fec_mov, fec_ult_mov As Date
                fec_mov = Legolas.Components.FechaHora.FechaDate(Me.FechaRegistroMovimiento, True)
                fec_ult_mov = Legolas.Components.FechaHora.FechaDate(FechaLong, True)
                If fec_mov <= fec_ult_mov Then

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un moviento con fecha superior")
                    Return False

                End If
            End If

            Return True
        End Function

        Private Sub AGrabar()
            If Validar() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strMensaje) = DialogResult.Yes Then

                    Dim intDocJudicialID As Integer = Me._DocumJudicialID
                    objBssMov = New Bussines.Registro.InternoMovimiento
                    Dim entMov As New Entity.Registro.InternoMovimiento
                    With entMov
                        .Codigo = Me._Codigo
                        .InternoID = Me._InternoID
                        .MovimientoTipoID = Me.MovimientoTipo
                        .MovimientoGrupoID = Me.MovimientoGrupo
                        .MovimientoGrupoNombre = Me.MovimientoGrupoNom
                        .IngresoID = Me._IngresoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        If Me.MovimientoTipo = EnumMovTipo.Traslado And txtMotivo.Visible = True Then
                            .MovimientoMotivoID = 3
                        Else
                            .MovimientoMotivoID = Me._MovimientoMotivoID
                        End If
                        .EstadoID = Me.EstadoTramiteID
                        .Fecha = Me.FechaRegistroMovimiento
                        If .MovimientoGrupoID = EnumMovGrupo.Ingreso Then
                            .RegionOrigenID = Me._RegionMovID
                            .PenalOrigenID = Me._PenalMovID
                            .RegionDestinoID = Me._RegionID
                            .PenalDestinoID = Me._PenalID
                        Else
                            .RegionOrigenID = Me._RegionID
                            .PenalOrigenID = Me._PenalID
                            .RegionDestinoID = Me._RegionMovID
                            .PenalDestinoID = Me._PenalMovID

                        End If
                        .Observacion = Me.strObservacion
                        '----------Datos del documento
                        .DocumJudicialID = Me._DocumJudicialID
                        .DocumJudicialNum = Me._DocumJudicialNumero
                        .DocumJudicialFecha = Me._DocumFecha
                        .DocumJudicialFecharecepcion = Me._DocumFechaRecepcion
                        .TipoAutoridadJudicialID = Me.TipoAutoridadJudicialID
                        If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .AutoridadJudicialID = Me.DistritoJudicialID
                            .SalaJudicialID = Me.SalaJudicialID
                            .DocJudJuez = Me.DocJuez
                            .DocJudSecretario = Me.DocSecretario
                        Else
                            .DocJudJuez = Me.AutoridadOtroNombre
                            .DocJudSecretario = Me.AutoridadOtroCargo
                        End If
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                    End With

                    Dim bssMovimiento As New Bussines.Registro.InternoMovimiento
                    Dim value As Integer = 0

                    If intDocJudicialID > 0 Then
                        value = bssMovimiento.Grabar(entMov)
                    Else ''''''''''' intDocJudicialID=-1
                        value = bssMovimiento.Grabar(entMov)
                    End If

                    If value > 0 Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End Sub
#End Region
#Region "Forms"
        Private Sub FRM_ListadoDocumentos()
            Dim frm As New frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado
                '._TipoLicencia = Me._TipoLicencia
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    With .Grilla_ObjetoSeleccionado
                        Me._DocumJudicialID = .Codigo
                        Me._DocumJudicialNumero = .DocumentoNumero
                        Me._DocumFecha = .DocumentoFecha
                        Me._DocumFechaRecepcion = .DocumentoFechaRecepcion
                        Me.TipoAutoridadJudicialID = .TipoAutoridadJudicial
                        Me.DistritoJudicialID = .DistritoJudicial
                        Me.SalaJudicialID = .SalaJuzgado
                        Me.DocJuez = .JuezNombre
                        Me.DocSecretario = .SecretarioNombre
                        Me.AutoridadOtroNombre = .AutoridadOtroNombre
                        Me.AutoridadOtroCargo = .AutoridadOtroCargo
                        Me._RegionMovID = .RegionDestinoId
                        Me._PenalMovID = .PenalDestinoid
                        'Cargar el motivo desde el documento
                        Me.cbbMovMotivo.SelectedValue = .MovimientoMotivoId
                    End With
                    InhabilitarControlesDoc()
                End If
            End With
        End Sub

        Private Function ValidarPenalLicencia() As Integer
            Dim PenalLic As Integer = -1
            PenalLic = Legolas.LBusiness.Globall.WinApp.LicenciaApp
            Select Case PenalLic
                Case 66, 67, 68, 69, 70, 71
                    PenalLic = PenalLic
                Case Else
                    PenalLic = -1
            End Select
            Return PenalLic
        End Function
#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
        End Sub

        Private Sub AutJudicialOtro()
            Select Case Me.TipoAutoridadJudicialID
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
#End Region
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub frmMovimientoTraslado_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ValoresxDefault()
            ValoresListar()
            Usuario_Permiso()
        End Sub

        Private Sub rbtSi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rbtSi.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rbtNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rbtNo.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub ValoresxDefault()
            ConfigurarDatosMovimiento()
            ConfigurarHora()
            ComboMovimientoMotivo()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboEstado()
            ComboRegion()
        End Sub

        Private Sub ConfigurarDatosMovimiento()
            Me.Size = New Size(688, 450)
            Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
            txtMovimientoTipo.Text = "TRASLADO"
            Me.MovimientoGrupo = IIf(Me._CondicionGrupo = EnumMovGrupo.Ingreso, EnumMovGrupo.Egreso, EnumMovGrupo.Ingreso)
            txtMovimientoGrupo.Text = IIf(Me._CondicionGrupo = EnumMovGrupo.Ingreso, "EGRESO", "INGRESO")
            Me.lblRegion.Text = IIf(Me.MovimientoGrupo = EnumMovGrupo.Ingreso, "Region origen:", "Region destino:")
            btnCargarDocumento.Enabled = True
            'Me._DocumFecha = 0
            'Me._DocumFechaRecepcion = 0
        End Sub

        Private Sub ConfigurarHora()
            nudHora._Maximum = 23
            nudHora._Minimum = 0
            nudHora._Formato = "00"

            nudMinutos._Maximum = 59
            nudMinutos._Minimum = 0
            nudMinutos._Formato = "00"

            nudHora._Value = "00"
            nudMinutos._Value = "00"
        End Sub
#Region "Combo"
        Private Sub ComboRegion()
            Me.cbbRegion.LoadUsc()
            Me.cbbRegion.SelectedValue = -1
        End Sub
        Private Sub ComboPenal()
            With Me.cbbPenal
                .CodigoPadre = Me._RegionMovID
                .LoadUsc()
            End With
        End Sub

        Private Sub ComboMovimientoMotivo()
            With Me.cbbMovMotivo
                .CodigoPadre = Me._MovimientoTipoID
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboEstado()
            With Me.cbbMovestado
                .Items.Add("Pendiente")
                .Items.Add("Terminado")
                .SelectedIndex = 0
            End With
        End Sub

        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            Me.cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
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

        Public Property _blnVisibleOrigenDestino() As Boolean
            Get
                Return Me.PnlOrigenDestino.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.PnlOrigenDestino.Visible = value
            End Set
        End Property
        Public Property MovimientoTipo() As Integer = -1
        Public ReadOnly Property EstadoTramiteID() As Integer
            Get
                Dim Valor As Integer = -1
                If cbbMovestado.SelectedIndex = 0 Then
                    Valor = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                ElseIf cbbMovestado.SelectedIndex = 1 Then
                    Valor = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                End If
                Return Valor
            End Get
        End Property
        Public Property EstadoTramite() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(Me.cbbMovestado.Text).ToUpper
            End Get
            Set(ByVal value As String)
                Me.cbbMovestado.Text = value
            End Set
        End Property
        Public Property _intCondicionGrupo() As Integer = -1

        Private VisiblePanel As Boolean = False

        Private Sub btnCargarDocumento_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarDocumento.Click
            FRM_ListadoDocumentos()
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            If Me._RegionID > 0 Then
                ComboPenal()
            End If
        End Sub
        Private Sub cbbMovestado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbMovestado.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            AutJudicialOtro()
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            ComboSalaJuzgado()
        End Sub

        Private Sub rbtSi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtSi.CheckedChanged, rbtNo.CheckedChanged

            Dim blnValor As Boolean = rbtSi.Checked
            Me.btnCargarDocumento.Enabled = blnValor
            HabilitarControlesDoc(Not (blnValor))
            LimpiarControlesDoc()

        End Sub

        Private Sub UscComboSala1_Click(sender As Object, e As EventArgs) Handles UscComboSala1.Click
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.DistritoJudicialID
                If .ShowDialog = DialogResult.OK Then
                    Me.DistritoJudicialID = ._DistritoJudicialID
                    Me.SalaJudicialID = ._GrillaSalaID
                End If
            End With
        End Sub


        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicialID = UscComboSala1._DistritoJudicialID
            Me.SalaJudicialID = UscComboSala1._SalaJuzgadoID_Seleccionado
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

