Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.Carceleta.Movimientos
    Public Class frmMovimientoConduccionClasificacion
        Private objBssMov As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntMov As Entity.Registro.InternoMovimiento = Nothing
        Private blnDataCargado As Boolean = False
        Private strmensaje As String = ""
#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _CondicionGrupo As Integer = -1
#End Region
#Region "Propiedades"
        Private Property IDMovimientoGrupo() As Integer = -1
        Private Property MovimientoGrupoNombre As String
            Get
                Return Me.txtMovimientoGrupo.Text
            End Get
            Set(value As String)
                Me.txtMovimientoGrupo.Text = value
            End Set
        End Property
        Private Property IDMovimientoTipo() As Integer = -1
        Private Property MovimientoTipoNombre As String
            Get
                Return Me.txtMovimientoTipo.Text
            End Get
            Set(value As String)
                Me.txtMovimientoTipo.Text = value
            End Set
        End Property
        Private Property FechaMovimiento() As Long
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
        Private Property IDEstado() As Integer = 1
        Private Property EstadoNombre() As String
            Get
                Return cbbMovestado.Text
            End Get
            Set(ByVal value As String)
                cbbMovestado.Text = value
            End Set
        End Property
        Private ReadOnly Property EstadoTramiteID() As Integer
            Get
                Dim valor As Integer
                If Me.cbbMovestado.SelectedIndex = 0 Then
                    valor = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                ElseIf cbbMovestado.SelectedIndex = 1 Then
                    valor = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                Else
                    valor = -1
                End If
                Return valor
            End Get
        End Property
        Private Property ReferenciarDocumento As Boolean
            Get
                Dim value As Boolean = False
                If Me.rdbSi.Checked = True Then
                    value = True
                End If
                Return value
            End Get
            Set(value As Boolean)

                If value = True Then
                    Me.rdbSi.Checked = True
                Else
                    Me.rdbNo.Checked = True
                End If
            End Set
        End Property
        Private Property IDDocumentoJudicial() As Integer = -1
        Private Property IDTipoDocJudicial As Integer = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Ingreso
        Private Property DocumentoJudicialNumero() As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
            End Set
        End Property
        Private Property DocumentoFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property
        Private Property DocumentoFechaRecepcion() As Long
            Get
                Return dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Private Property IDTipoAutoridadJudicial() As Integer
            Get
                Return Me.cbbTipoAutJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Private Property IDDistritoJudicial() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property IDSalaJudicial() As Integer
            Get
                Return Me.cbbSala._SalaJuzgadoID
            End Get
            Set(ByVal value As Integer)
                Me.cbbSala._SalaJuzgadoID = value
            End Set
        End Property
        Private Property DocumentoJuez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                Me.txtJuez.Text = value
            End Set
        End Property
        Private Property DocumentoSecretario() As String
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
        Private Property IDRegion() As Integer
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property IDPenal() As Integer
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property

        Private Property Observacion() As String
            Get
                Return txtObservacion.Text
            End Get
            Set(ByVal value As String)
                txtObservacion.Text = value
            End Set
        End Property
#End Region
#Region "Funciones"
        Private Function fn_MovimientoGrupoNombre() As String

            Dim Value As String = ""
            If Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                Value = "INGRESO"
                lblRegion.Text = "Región Origen :"
            ElseIf Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                Value = "EGRESO"
                lblRegion.Text = "Región Destino :"
            Else
                Value = "Región :"
            End If

            Return Value

        End Function
        Private Function fn_FechaRegistroMovimiento() As Long

            Dim FechaTotal As String = ""
            Dim fecha As String = dtpFechaMov.Value & " " & CStr(HoraMovimiento) & ":" & CStr(MinutoMovimiento) & ":00"
            FechaTotal = CDate(fecha).ToFileTime
            Return FechaTotal

        End Function
#End Region
#Region "Combo"
        Private Sub ComboTipoAutoridadJudicial()

            With Me.cbbTipoAutJud
                .ComboTipo = Type.Combo.ComboTipo.TipoAutoridadJudicial
                .LoadUsc()
                .SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.Inpe
            End With

        End Sub
        Private Sub ComboDistritoJudicial()

            With Me.cbbDistritoJud
                .ComboTipo = Type.Combo.ComboTipo.AutorizacionJudicial
                .LoadUsc()
                .SelectedValue = -1
            End With

        End Sub

        Private Sub ComboSalaJuzgado()

            With Me.cbbSala
                ._DistritoJudicialID = Me.IDDistritoJudicial
                ._Combo()
            End With
        End Sub
        Private Sub ComboRegion()

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
                .SelectedValue = -1
            End With

        End Sub
        Private Sub ComboPenal()

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.IDRegion
                .LoadUsc()
            End With

        End Sub

        Private Sub ComboEstado()
            cbbMovestado.Items.Clear()
            With Me.cbbMovestado
                .Items.Add("Pendiente")
                .Items.Add("Terminado")
                .SelectedIndex = 0
            End With
        End Sub

#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBssMov = New Bussines.Registro.InternoMovimiento
            objEntMov = New Entity.Registro.InternoMovimiento

            objEntMov.Codigo = Me._Codigo
            objEntMov = objBssMov.Listar_LM(objEntMov)

            With objEntMov
                Me.IDMovimientoGrupo = .MovimientoGrupoID
                Me.MovimientoGrupoNombre = Me.fn_MovimientoGrupoNombre

                Me.FechaMovimiento = .Fecha
                Dim f As Date
                f = Legolas.Components.FechaHora.FechaDate(.Fecha, True)
                Me.HoraMovimiento = Format(f, "HH")
                Me.MinutoMovimiento = Format(f, "mm")
                Me.cbbMovestado.SelectedValue = .EstadoID
                Me.IDEstado = .EstadoID
                Me.EstadoNombre = .EstadoNombre

                If Me.IDMovimientoGrupo = EnumMovGrupo.Ingreso Then
                    Me.IDRegion = .RegionOrigenID
                    Me.IDPenal = .PenalOrigenID
                    Me._RegionID = .RegionDestinoID
                    Me._PenalID = .PenalDestinoID
                Else
                    Me._RegionID = .RegionOrigenID
                    Me._PenalID = .PenalOrigenID
                    Me.IDRegion = .RegionDestinoID
                    Me.IDPenal = .PenalDestinoID
                End If

                Me.Observacion = .Observacion
                Me._InternoIngresoInpeId = .IngresoInpeId
                Me.IDDocumentoJudicial = .DocumJudicialID
                Me.DocumentoJudicialNumero = .DocumJudicialNum
                Me.DocumentoFecha = .DocumJudicialFecha
                Me.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                Me.IDTipoAutoridadJudicial = .TipoAutoridadJudicialID

                If Me.IDTipoAutoridadJudicial = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                    Me.IDDistritoJudicial = .AutoridadJudicialID
                    Me.IDSalaJudicial = .SalaJudicialID
                    Me.DocumentoJuez = .DocJudJuez
                    Me.DocumentoSecretario = .DocJudSecretario
                Else
                    Me.AutoridadOtroNombre = .DocJudJuez
                    Me.AutoridadOtroCargo = .DocJudSecretario
                End If

                If Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then

                    If .DocumJudicialID > 0 Then
                        HabilitarControlesDoc(False)
                        btnCargarDocumento.Enabled = True
                        Me.ReferenciarDocumento = True
                    Else
                        HabilitarControlesDoc(True)
                        btnCargarDocumento.Enabled = False
                        Me.ReferenciarDocumento = False
                    End If

                Else
                    If Me.IDDocumentoJudicial > 0 Then

                        Me.ReferenciarDocumento = True
                        If Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                            Me.cbbRegion.Enabled = True
                            Me.cbbPenal.Enabled = True
                        End If
                        HabilitarControlesDoc(False)
                    Else
                        Me.ReferenciarDocumento = False
                        Me.btnCargarDocumento.Enabled = False
                        HabilitarControlesDoc(True)
                    End If
                    blnDataCargado = True

                End If

                If Me.IDEstado = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    InhabilitarControles()
                End If
            End With
            blnDataCargado = True
        End Sub
        Private Sub ValoresData()

            ListarData()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)

        End Sub
        Private Function InhabilitarControles() As Boolean

            If Me.IDEstado = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then

                Me.btnCargarDocumento.Enabled = False
                Me.cbbMovestado.Enabled = False
                Me.dtpFechaMov.Enabled = False
                Me.nudHora.Enabled = False
                Me.nudMinutos.Enabled = False

                Me.cbbRegion.Enabled = False
                Me.cbbPenal.Enabled = False
                Me.txtObservacion.ReadOnly = True
                Me.txtNumDocumento.Enabled = False
                Me.dtpDocJudFecRecep.Enabled = False
                Me.dtpDocJudFecha.Enabled = False
                Me.cbbTipoAutJud.Enabled = False
                Me.txtOtraAutoridadNombre.Enabled = False
                Me.txtOtraAutoridadCargo.Enabled = False
                Me.rdbSi.Enabled = False
                Me.rdbNo.Enabled = False
                Me.cbbDistritoJud.Enabled = False
                Me.cbbSala.Enabled = False
                Me.txtJuez.Enabled = False
                Me.txtSecretario.Enabled = False
                Return True
            End If

            Return False

        End Function
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            If Me.dtpFechaMov.ValueLong < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha del Movimiento")
                dtpFechaMov.Focus()
                Return False
            End If

            'fecha de movimiento, futuro
            Dim dteFechaHoy As Date = Legolas.LBusiness.Globall.DateTime.FechaServer
            Dim dteFechaMov As Date = Legolas.Components.FechaHora.FechaDate(Me.dtpFechaMov.ValueLong, True)
            Dim intCant As Integer = Legolas.Components.FechaHora.FechaDateCalcularDias(dteFechaHoy, dteFechaMov, False)

            If intCant > 3 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de movimiento no puede ser mayor a la fecha actual. (Fecha de Actual: " & dteFechaHoy.ToShortDateString & ")")
                Me.dtpFechaMov.Focus()
                Return False
            End If

            'validacion penal
            If Me._PenalID <= 0 Or Me._RegionID <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Id del penal y región debe ser mayores a 0")
                Return False
            End If

            objBssMov = New Bussines.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            EntMov.InternoID = Me._InternoID
            EntMov.IngresoID = Me._IngresoID
            Dim EntColec As New Entity.Registro.InternoMovimientoCol

            If Me.IDMovimientoTipo <> Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then

                If Me._Codigo < 1 Then
                    EntColec = objBssMov.ListarGrilla(EntMov)
                    '************************
                    Dim fec_mov, fec_ult_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(Me.fn_FechaRegistroMovimiento, True)

                    If EntColec.Count = 0 Then
                        fec_ult_mov = Legolas.Components.FechaHora.FechaDate(0, True)
                    Else
                        fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                    End If

                    If fec_mov < fec_ult_mov Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior.")
                        Return False
                    End If

                Else
                    EntMov.Codigo = Me._Codigo
                    EntColec = objBssMov.ListarMovimiento_Diferente(EntMov)
                    Dim FechaLong As Long = 0

                    If EntColec.Count = 0 Then
                        FechaLong = 0
                    Else
                        FechaLong = EntColec.InternoMovimiento(0).Fecha
                    End If

                    '************************
                    Dim fec_mov, fec_ult_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(Me.fn_FechaRegistroMovimiento, True)
                    fec_ult_mov = Legolas.Components.FechaHora.FechaDate(FechaLong, True)

                    If fec_mov <= fec_ult_mov Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior.")
                        Return False
                    End If

                End If

            End If

            If Me.IDDocumentoJudicial < 1 And Me.btnCargarDocumento.Enabled = True Then
                If Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha referenciado ningún documento.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha referenciado ningún documento, para referenciar el documento primero debe dirigirse a la ventana principal en el icono [Consolidado clasificación], luego generar y derivar el oficio de clasificación.")
                End If
                Return False
            Else
                If Me.DocumentoJudicialNumero = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar número de documento.")
                    txtNumDocumento.Focus()
                    Return False
                End If
            End If

            If Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                If cbbRegion.SelectedValue < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Region.")
                    cbbRegion.Focus()
                    Return False
                End If

                If Me.cbbPenal.SelectedValue < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Penal.")
                    cbbPenal.Focus()
                    Return False
                End If
            End If

            If Me.InhabilitarControles = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado del movimento es [TERMINADO], no podra realizar ninguna acción.")
                Return False
            End If

            If Me._Codigo < 1 Then
                If Me.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    strmensaje = "Tenga en cuenta que el estado del movimento es [PENDIENTE] por lo tanto se encuentra incompleta el movimiento fisico del interno. Desea guardar los datos?"
                Else
                    strmensaje = "El estado del movimiento 'Terminado', no permitira realizar ninguna acción," + Chr(13) +
                                 "Desea guardar los datos"
                End If
            Else
                If Me.EstadoTramiteID < Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    strmensaje = "Tenga en cuenta que el estado del movimento es [PENDIENTE] por lo tanto se encuentra incompleta el movimiento fisico del interno. Desea guardar los cambios en movimientos?"
                Else
                    strmensaje = "El estado del movimiento 'Terminado', no permitira realizar ninguna acción," + Chr(13) +
                                  "Desea guardar los cambios en movimientos."
                End If
            End If

            If Me.IDTipoAutoridadJudicial <> Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                txtJuez.Clear()
                txtSecretario.Clear()
                cbbDistritoJud.SelectedValue = -1
                cbbSala._SalaJuzgadoID_Seleccionado = -1
            Else
                txtOtraAutoridadNombre.Clear()
                txtOtraAutoridadCargo.Clear()
            End If

            Return True
        End Function

        Private Sub AGrabar()

            If Validar() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strmensaje) = DialogResult.Yes Then

                    Dim intDocJudicialID As Integer = Me.IDDocumentoJudicial
                    objBssMov = New Bussines.Registro.InternoMovimiento
                    Dim entMov As New Entity.Registro.InternoMovimiento

                    With entMov
                        .Codigo = Me._Codigo
                        .InternoID = Me._InternoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .MovimientoTipoID = Me.IDMovimientoTipo
                        .MovimientoGrupoID = Me.IDMovimientoGrupo
                        .MovimientoGrupoNombre = Me.fn_MovimientoGrupoNombre
                        .MovimientoMotivoID = 148 'conduccion por clasificacion
                        .IngresoID = Me._IngresoID
                        .EstadoID = Me.EstadoTramiteID
                        .Fecha = Me.fn_FechaRegistroMovimiento
                        If .MovimientoGrupoID = EnumMovGrupo.Ingreso Then
                            .RegionOrigenID = Me.IDRegion
                            .PenalOrigenID = Me.IDPenal
                            .RegionDestinoID = Me._RegionID
                            .PenalDestinoID = Me._PenalID
                        Else
                            .RegionOrigenID = Me._RegionID
                            .PenalOrigenID = Me._PenalID
                            .RegionDestinoID = Me.IDRegion
                            .PenalDestinoID = Me.IDPenal
                        End If
                        .Observacion = Me.Observacion
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        ._Clasificacion = True
                        '''''''''''Datos del documento'''''
                        .DocumJudicialID = Me.IDDocumentoJudicial
                        .DocumJudicialNum = Me.DocumentoJudicialNumero
                        .DocumJudicialFecha = Me.DocumentoFecha
                        .DocumJudicialFecharecepcion = Me.DocumentoFechaRecepcion
                        .TipoAutoridadJudicialID = Me.IDTipoAutoridadJudicial

                        If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .DocJudJuez = Me.DocumentoJuez
                            .DocJudSecretario = Me.DocumentoSecretario
                            .AutoridadJudicialID = Me.IDDistritoJudicial
                            .SalaJudicialID = Me.IDSalaJudicial
                        Else
                            .DocJudJuez = Me.AutoridadOtroNombre
                            .DocJudSecretario = Me.AutoridadOtroCargo
                        End If
                    End With

                    Dim bssMovimiento As New Bussines.Registro.InternoMovimiento
                    Dim value As Integer = 0
                    value = bssMovimiento.Grabar_LM(entMov)

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

            Dim frm As New Registro.Movimientos.frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso
                ._GrupoID = Me.IDMovimientoGrupo
                ._TipoLicencia = Me._TipoLicencia

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    'llenar el formulario con los datos del documento
                    Me.IDDocumentoJudicial = ._DocJudicialID

                    Dim objBssDocJud As New Bussines.Registro.DocumentoJudicial
                    Dim objEntDocJud As New Entity.Registro.DocumentoJudicial

                    If Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                        objEntDocJud.Codigo = Me.IDDocumentoJudicial
                        objEntDocJud.IngresoInpeId = Me._InternoIngresoInpeId
                        objEntDocJud = objBssDocJud.Listar_DocumentosClasificacion(objEntDocJud).DocumentoJudicial(0)
                    Else
                        objEntDocJud = objBssDocJud.Listar_v2_LM(Me.IDDocumentoJudicial)
                    End If

                    With objEntDocJud
                        Me.IDDocumentoJudicial = .Codigo
                        Me.DocumentoJudicialNumero = .DocumentoNumero
                        Me.DocumentoFecha = .DocumentoFecha
                        Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                        Me.IDTipoAutoridadJudicial = Type.Enumeracion.DocumentoJudicial.Expediente.enmTipoAutoridadJudicial.AutoridadJudicial

                        'sacar los datos del 1er expediente del ingreso
                        Dim objBssExpediente As New Bussines.Registro.Expediente
                        Dim objEntExpediente As New Entity.Registro.Expediente
                        objEntExpediente = objBssExpediente.ListarExpedientexResolucion_LM(Me.IDDocumentoJudicial).Item(0)

                        With objEntExpediente
                            Me.IDDistritoJudicial = .AutoridadJudicialID
                            ComboSalaJuzgado()
                            Me.IDSalaJudicial = .SalaJudicialID
                            Me.DocumentoJuez = .ExpedienteJuez
                            Me.DocumentoSecretario = .ExpedienteSecretario
                            Me.AutoridadOtroNombre = .AutoridadOtro
                            Me.AutoridadOtroCargo = .AutoridadOtroCargo
                        End With
                        '*****************************************
                        Me.IDRegion = .RegionOrigenId
                        Me.IDPenal = .PenalOrigenId
                        Me.Observacion = .Observacion
                    End With
                    '*****************************************************

                    If ._GrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                        If Me.IDEstado = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                            Me.cbbRegion.Enabled = True
                            Me.cbbPenal.Enabled = True
                        End If
                    End If
                End If
            End With

        End Sub

        Private Sub FRM_BuscarSala()

            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.IDDistritoJudicial
                If .ShowDialog = DialogResult.OK Then

                    Me.IDDistritoJudicial = ._DistritoJudicialID
                    Me.IDSalaJudicial = ._GrillaSalaID

                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub AutJudicialOtro()
            Select Case Me.IDTipoAutoridadJudicial
                Case Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
                    Me.PnlAutoridadJudicial.Visible = True
                    Me.PnlOtraAutoridad.Visible = False
                    Me.txtOtraAutoridadCargo.Text = ""
                    Me.txtOtraAutoridadNombre.Text = ""
                Case Else
                    Me.PnlAutoridadJudicial.Visible = False
                    Me.PnlOtraAutoridad.Visible = True
                    Me.cbbDistritoJud.SelectedIndex = -1
                    Me.cbbSala._SalaJuzgadoID = -1
                    Me.txtJuez.Text = ""
                    Me.txtSecretario.Text = ""
            End Select
        End Sub
        Private Sub ValoresxDefault()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboEstado()
            ComboRegion()
            ConfigurarHora()
            ConfigurarDatosMovimiento()
        End Sub
        Private Sub ConfigurarDatosMovimiento()

            PnlAutoridadJudicial.Visible = False
            Me.IDMovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.ConduccionClasificacion
            Me.MovimientoTipoNombre = "Conducción por Clasificación"

            Me.IDMovimientoGrupo = IIf(Me._CondicionGrupo = EnumMovGrupo.Ingreso, EnumMovGrupo.Egreso, EnumMovGrupo.Ingreso)
            Me.MovimientoGrupoNombre = Me.fn_MovimientoGrupoNombre

            If rdbSi.Checked = True And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbNo.Checked = True And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbSi.Checked = True And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = False
                cbbPenal.Enabled = False
            End If

            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
               Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                'Me.rdbSi.Enabled = False
                Me.rdbNo.Checked = True
            End If

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
        Private Sub LimpiarControlesDoc()
            txtNumDocumento.Clear()
            Me.DocumentoFecha = 0
            Me.DocumentoFechaRecepcion = 0
            cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
            cbbDistritoJud.SelectedValue = -1
            cbbSala._SalaJuzgadoID_Seleccionado = -1
            txtJuez.Clear()
            txtSecretario.Clear()
            txtOtraAutoridadNombre.Clear()
            txtOtraAutoridadCargo.Clear()
            cbbRegion.SelectedIndex = -1
            cbbPenal.SelectedIndex = -1
            txtObservacion.Clear()
        End Sub

        Private Sub HabilitarControlesDoc(Valor As Boolean)
            'Inactivar()
            txtNumDocumento.Enabled = Valor
            txtObservacion.Enabled = Valor
            dtpDocJudFecha.Enabled = Valor
            dtpDocJudFecRecep.Enabled = Valor
            cbbTipoAutJud.Enabled = Valor
            cbbDistritoJud.Enabled = Valor
            cbbSala.Enabled = Valor
            txtJuez.Enabled = Valor
            txtSecretario.Enabled = Valor
            txtOtraAutoridadNombre.Enabled = Valor
            txtOtraAutoridadCargo.Enabled = Valor

            If rdbSi.Checked = True And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbNo.Checked = True And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbNo.Checked = False And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbSi.Checked = True And Me.IDMovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            End If

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

        Private Sub rbtSi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rbtNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

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

        Private Sub frmMovimientoTrasladoCarceleta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
            Usuario_Permiso()
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            AutJudicialOtro()
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            ComboSalaJuzgado()
        End Sub

        Private Sub rdbNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbNo.CheckedChanged, rdbSi.CheckedChanged

            If (blnDataCargado = False And Me._Codigo = -1) Or blnDataCargado = True Then

                Dim blnValor As Boolean = rdbSi.Checked

                Me.btnCargarDocumento.Enabled = blnValor
                HabilitarControlesDoc(Not (blnValor))
                LimpiarControlesDoc()
            End If

        End Sub

        Private Sub frmMovimientoTrasladoCarceleta_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ValoresData()
        End Sub

        Private Sub cbbSala__Click_Buscar() Handles cbbSala._Click_Buscar

            FRM_BuscarSala()

        End Sub

        Private Sub cbbSala_Load(sender As Object, e As EventArgs) Handles cbbSala.Load

        End Sub
    End Class
End Namespace

