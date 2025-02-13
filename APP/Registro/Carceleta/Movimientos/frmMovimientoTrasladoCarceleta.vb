Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.Movimientos.Carceleta
    Public Class frmMovimientoTrasladoCarceleta
        Private objBssMov As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntMov As Entity.Registro.InternoMovimiento = Nothing

        Private dataCargado As Boolean = False

#Region "Propiedades_Parametricas"
        Public Property _Codigo() As Integer = -1
        Private intDocJudicialID As Integer = -1
        Public Property _DocumJudicialID() As Integer = -1
        Public Property _DocumJudicialNumero() As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(ByVal value As String)
                txtNumDocumento.Text = value
            End Set
        End Property
        Public Property _DocumFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property
        Public Property _DocumFechaRecepcion() As Long
            Get
                Return dtpDocJudFecRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                dtpDocJudFecRecep.ValueLong = value
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

        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

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
        Public Property _Licencia As Integer = -1
        Private blnCargarDocumentoJudicial As Boolean = False

        Private Property _TipoAutoridadID() As Integer
            Get
                Return Me.cbbTipoAutJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Private Property _DistritoJudicialID() As Integer
            Get
                Return Me.cbbDistritoJud.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Public Property _CondicionGrupo As Integer = -1
        Public Property _Docjuez() As String
            Get
                Return txtJuez.Text
            End Get
            Set(ByVal value As String)
                txtJuez.Text = value
            End Set
        End Property
        Public Property _Docsecretario() As String
            Get
                Return txtSecretario.Text
            End Get
            Set(ByVal value As String)
                txtSecretario.Text = value
            End Set
        End Property
        Public Property _OtroAutoridadNombre() As String
            Get
                Return txtOtraAutoridadNombre.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadNombre.Text = value
            End Set
        End Property
        Public Property _OtraAutoridadCargo() As String
            Get
                Return txtOtraAutoridadCargo.Text
            End Get
            Set(ByVal value As String)
                txtOtraAutoridadCargo.Text = value
            End Set
        End Property


        Public Property EstadoID() As Integer = 1
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

        Public Property _Observacion() As String
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
        Public ReadOnly Property MovimientoGrupoNom() As String
            Get
                Dim Value As String = ""
                If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                    Value = "INGRESO"
                    lblRegion.Text = "Región Origen :"
                ElseIf Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                    Value = "EGRESO"
                    lblRegion.Text = "Región Destino :"
                Else
                    Value = "Región :"
                End If
                Return Value
            End Get
        End Property

        Public Property MovimientoTipo() As Integer = -1
        Public ReadOnly Property EstadoTramiteID() As Integer
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
        Private VisiblePanel As Boolean = False
#End Region
#Region "Listar"
        Private Sub ListarData()
            If Me._Codigo < 1 Then
                dataCargado = True
                Exit Sub
            End If

            objBssMov = New Bussines.Registro.InternoMovimiento
            objEntMov = New Entity.Registro.InternoMovimiento

            objEntMov = objBssMov.Listar_LM(Me._Codigo)

            With objEntMov
                Me.MovimientoGrupo = .MovimientoGrupoID
                Me.txtMovimientoGrupo.Text = Me.MovimientoGrupoNom
                If .MovimientoMotivoID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
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
                Me._Observacion = .Observacion

                Me._DocumJudicialID = .DocumJudicialID
                Me._DocumJudicialNumero = .DocumJudicialNum
                Me._DocumFecha = .DocumJudicialFecha
                Me._DocumFechaRecepcion = .DocumJudicialFecharecepcion
                Me._TipoAutoridadID = .TipoAutoridadJudicialID
                If Me._TipoAutoridadID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                    Me.DistritoJudicialID = .AutoridadJudicialID
                    Me.SalaJudicialID = .SalaJudicialID
                    Me._Docjuez = .DocJudJuez
                    Me._Docsecretario = .DocJudSecretario
                Else
                    Me._OtroAutoridadNombre = .DocJudJuez
                    Me._OtraAutoridadCargo = .DocJudSecretario
                End If
                ''''''''''''''
                If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                    If .DocumJudicialID > 0 Then
                        HabilitarControlesDoc(False)
                        btnCargarDocumento.Enabled = True
                        rdbSi.Checked = True
                    Else
                        HabilitarControlesDoc(True)
                        btnCargarDocumento.Enabled = False
                        rdbNo.Checked = True
                    End If

                    If .TipoAutoridadJudicialID = 1 Then
                        Me.Size = New Size(706, 470)
                    Else
                        Me.Size = New Size(706, 440)
                    End If
                Else
                    If Me._DocumJudicialID > 0 Then
                        rdbSi.Checked = True
                        rdbNo.Checked = False
                        Me.Size = New Size(706, 440)
                        If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                            cbbRegion.Enabled = True
                            cbbPenal.Enabled = True
                        End If
                        HabilitarControlesDoc(False)
                    Else
                        rdbSi.Checked = False
                        rdbNo.Checked = True
                        Me.btnCargarDocumento.Enabled = False
                        If Me._Codigo > 0 And rdbNo.Checked = True Then Me.Size = New Size(706, 470)
                        HabilitarControlesDoc(True)
                    End If
                    dataCargado = True

                End If
                ''''''''''''''
                If Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    InhabilitarControles()
                End If
            End With
            dataCargado = True
        End Sub
        Private Sub ValoresData()

            ListarData()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_Movimiento)

        End Sub
        Private Function InhabilitarControles() As Boolean
            If Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                btnCargarDocumento.Enabled = False
                cbbMovestado.Enabled = False
                cbbMovMotivo.Enabled = False
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False

                cbbRegion.Enabled = False
                cbbPenal.Enabled = False
                Me.txtObservacion.ReadOnly = True
                Me.txtNumDocumento.Enabled = False
                dtpDocJudFecRecep.Enabled = False
                dtpDocJudFecha.Enabled = False
                cbbTipoAutJud.Enabled = False
                cbbDistritoJud.Enabled = False
                UscComboSala1.Enabled = False
                txtJuez.Enabled = False
                txtSecretario.Enabled = False
                txtOtraAutoridadNombre.Enabled = False
                txtOtraAutoridadCargo.Enabled = False
                rdbSi.Enabled = False
                rdbNo.Enabled = False
                Return True
            End If
            Return False
        End Function
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
        Private Function Validar() As Boolean

            If cbbMovMotivo.SelectedValue < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar el motivo del movimiento")
                cbbMovMotivo.Focus()
                Return False
            End If

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

            If Me._PenalID <= 0 Or Me._RegionID <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Id del penal y región debe ser mayores a 0")
                Return False
            End If

            objBssMov = New Bussines.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            EntMov.InternoID = Me._InternoID
            EntMov.IngresoID = Me._IngresoID
            Dim EntColec As New Entity.Registro.InternoMovimientoCol

            If Me._MovimientoTipoID <> Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                If Me._Codigo < 1 Then
                    EntColec = objBssMov.ListarGrilla(EntMov)
                    '************************
                    Dim fec_mov, fec_ult_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(Me.FechaRegistroMovimiento, True)
                    If EntColec.Count = 0 Then
                        fec_ult_mov = Legolas.Components.FechaHora.FechaDate(0, True)
                    Else
                        fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                    End If
                    'If fec_mov <= fec_ult_mov Then
                    If fec_mov < fec_ult_mov Then
                        'If Me._DocumJudicialID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior.")
                        Return False
                        'End If
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
                    fec_mov = Legolas.Components.FechaHora.FechaDate(Me.FechaRegistroMovimiento, True)
                    fec_ult_mov = Legolas.Components.FechaHora.FechaDate(FechaLong, True)
                    If fec_mov <= fec_ult_mov Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior.")
                        Return False
                    End If
                End If
            End If
            If Me._DocumJudicialID < 1 And Me.btnCargarDocumento.Enabled = True Then
                If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha referenciado ningún documento.")
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha referenciado ningún documento, para referenciar el documento primero debe dirigirse a la ventana principal en el icono [Consolidado clasificación], luego generar y derivar el oficio de clasificación.")
                End If
                Return False
            Else
                If Me._DocumJudicialNumero = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar número de documento.")
                    txtNumDocumento.Focus()
                    Return False
                End If
            End If
            If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
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

            If Me._PenalID = Me._PenalMovID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Tenga en cuenta que no es posible trasladar al mismo penal.")
                Return False
            End If

            If Me.TipoAutoridadJudicialID <> Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                txtJuez.Clear()
                txtSecretario.Clear()
                cbbDistritoJud.SelectedValue = -1
                UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Else
                txtOtraAutoridadNombre.Clear()
                txtOtraAutoridadCargo.Clear()
            End If

            Return True
        End Function
        Private strmensaje As String = ""
        Private Sub AGrabar()
            If Validar() = True Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(strmensaje) = DialogResult.Yes Then

                    Dim intDocJudicialID As Integer = Me._DocumJudicialID
                    objBssMov = New Bussines.Registro.InternoMovimiento
                    Dim entMov As New Entity.Registro.InternoMovimiento

                    With entMov
                        .Codigo = Me._Codigo
                        .InternoID = Me._InternoID
                        .IngresoInpeId = Me._InternoIngresoInpeId
                        .MovimientoTipoID = Me.MovimientoTipo
                        .MovimientoGrupoID = Me.MovimientoGrupo
                        .MovimientoGrupoNombre = Me.MovimientoGrupoNom
                        .IngresoID = Me._IngresoID
                        .MovimientoMotivoID = Me._MovimientoMotivoID
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
                        .Observacion = Me._Observacion
                        ._RegionID = Me._RegionID
                        ._PenalID = Me._PenalID
                        ._Clasificacion = True
                        '''''''''''Datos del documento'''''
                        .DocumJudicialID = Me._DocumJudicialID
                        If rdbNo.Checked = True Then
                            .DocumJudicialID = -1
                        End If

                        .DocumJudicialNum = Me._DocumJudicialNumero
                        .DocumJudicialFecha = Me._DocumFecha
                        .DocumJudicialFecharecepcion = Me._DocumFechaRecepcion
                        .TipoAutoridadJudicialID = Me._TipoAutoridadID
                        If .TipoAutoridadJudicialID = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                            .DocJudJuez = Me._Docjuez
                            .DocJudSecretario = Me._Docsecretario
                            .AutoridadJudicialID = Me.DistritoJudicialID
                            .SalaJudicialID = Me.SalaJudicialID
                        Else
                            .DocJudJuez = Me._OtroAutoridadNombre
                            .DocJudSecretario = Me._OtraAutoridadCargo
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
            Dim tipDocJudId As Integer = -1
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                tipDocJudId = 5 'tralados
            End If

            Dim frm As New frmListadoDocJudicialPopup
            With frm
                ._InternoID = Me._InternoID
                ._IngresoID = Me._IngresoID
                ._InternoIngresoInpeId = Me._InternoIngresoInpeId
                ._TipoDocJudicialID = tipDocJudId 'enumTipoDocumentoJudicial.Traslado no es necesario enviar tipoDocJud
                ._GrupoID = Me.MovimientoGrupo
                ._TipoLicencia = enmTipoLicencia.Carceleta
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me._DocumJudicialID = ._DocJudicialID

                    Dim bss As New Bussines.Registro.DocumentoJudicial
                    Dim obj As New Entity.Registro.DocumentoJudicial

                    If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                        obj.Codigo = Me._DocumJudicialID
                        If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                            obj = bss.Listar_v2_LM(Me._DocumJudicialID)
                        Else
                            obj = bss.Listar_DocumentosClasificacion(obj).DocumentoJudicial(0)
                        End If
                    Else
                        obj = bss.Listar_v2_LM(Me._DocumJudicialID)
                    End If
                    Me.TipoAutoridadJudicialID = obj.TipoAutoridadJudicial
                    Me._TipoDocJudicialID = obj.DocumentoTipo
                    Me._DocumJudicialNumero = obj.DocumentoNumero
                    Me._Observacion = obj.Observacion
                    If obj.TipoAutoridadJudicial = 1 Then
                        Me.DistritoJudicialID = obj.DistritoJudicial
                        Me.SalaJudicialID = obj.SalaJuzgado
                        Me._Docjuez = obj.JuezNombre
                        Me._Docsecretario = obj.SecretarioNombre
                    Else
                        Me._OtroAutoridadNombre = obj.AutoridadOtroNombre
                        Me._OtraAutoridadCargo = obj.AutoridadOtroCargo
                    End If
                    Me._DocumFecha = obj.DocumentoFecha
                    Me._DocumFechaRecepcion = obj.DocumentoFechaRecepcion
                    If Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                        cbbRegion.SelectedValue = obj.RegionOrigenId
                        cbbPenal.SelectedValue = obj.PenalOrigenId
                    Else
                        cbbRegion.SelectedValue = obj.RegionDestinoId
                        cbbPenal.SelectedValue = obj.PenalDestinoid
                    End If
                    If Me._TipoDocJudicialID = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta And ._GrupoID = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                        If Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente Then
                            cbbRegion.Enabled = True
                            cbbPenal.Enabled = True
                        End If
                    End If
                End If
            End With

        End Sub

#End Region
#Region "Otros"
        Private Sub Usuario_Permiso()
            Me.btnAceptar.Visible = Me._FormEscritura
            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                gbReferenciar.Enabled = False
            End If
        End Sub
#End Region
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AGrabar()
        End Sub
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub rbtSi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbSi.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rbtNo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbNo.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
        Private Sub ValoresxDefault()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboEstado()
            ComboRegion()
            ConfigurarHora()
            ComboMovimientoMotivo()
            ConfigurarDatosMovimiento()
        End Sub
        Private Sub ConfigurarDatosMovimiento()
            Me.Size = New Size(706, 388)
            PnlAutoridadJudicial.Visible = False
            Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
            txtMovimientoTipo.Text = "TRASLADO"
            Me.MovimientoGrupo = IIf(Me._CondicionGrupo = EnumMovGrupo.Ingreso, EnumMovGrupo.Egreso, EnumMovGrupo.Ingreso)
            txtMovimientoGrupo.Text = Me.MovimientoGrupoNom

            If rdbSi.Checked = True And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbNo.Checked = True And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbSi.Checked = True And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = False
                cbbPenal.Enabled = False
            End If
            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                Me.Text = "TRASLADO"
                Me.rdbSi.Enabled = True
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
            cbbMovestado.Items.Clear()
            With Me.cbbMovestado
                .Items.Add("Pendiente")
                .Items.Add("Terminado")
                .SelectedIndex = 0
            End With
        End Sub
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            Me.cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.Inpe
        End Sub

        Private Sub ComboDistritoJudicial()
            Me.cbbDistritoJud.LoadUsc()
            Me.cbbDistritoJud.SelectedValue = -1
        End Sub

        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me._DistritoJudicialID
                ._Combo()
            End With
        End Sub

#End Region

        Private Sub btnCargarDocumento_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarDocumento.Click
            FRM_ListadoDocumentos()
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            If Me._RegionID > 0 Then ComboPenal()
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

        Private Sub AutJudicialOtro()
            Select Case Me.TipoAutoridadJudicialID
                Case Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
                    Me.PnlAutoridadJudicial.Visible = True
                    Me.PnlOtraAutoridad.Visible = False
                    Me.txtOtraAutoridadCargo.Text = ""
                    Me.txtOtraAutoridadNombre.Text = ""
                    Me.Size = New Size(706, 470)
                Case Else
                    Me.PnlAutoridadJudicial.Visible = False
                    Me.PnlOtraAutoridad.Visible = True
                    Me.cbbDistritoJud.SelectedIndex = -1
                    Me.UscComboSala1._SalaJuzgadoID = -1
                    Me.txtJuez.Text = ""
                    Me.txtSecretario.Text = ""
                    Me.Size = New Size(706, 440)
            End Select
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            AutJudicialOtro()
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            ComboSalaJuzgado()
        End Sub

        Private Sub LimpiarControlesDoc()
            txtNumDocumento.Clear()
            Me._DocumFecha = 0
            Me._DocumFechaRecepcion = 0
            cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad
            cbbDistritoJud.SelectedValue = -1
            UscComboSala1._SalaJuzgadoID_Seleccionado = -1
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
            UscComboSala1.Enabled = Valor
            txtJuez.Enabled = Valor
            txtSecretario.Enabled = Valor
            txtOtraAutoridadNombre.Enabled = Valor
            txtOtraAutoridadCargo.Enabled = Valor
            If rdbSi.Checked = True And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Ingreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbNo.Checked = True And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbNo.Checked = False And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            ElseIf rdbSi.Checked = True And Me.MovimientoGrupo = Type.Enumeracion.Movimiento.EnumMovGrupo.Egreso Then
                cbbRegion.Enabled = True
                cbbPenal.Enabled = True
            End If
        End Sub

        Private Sub rdbNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbNo.CheckedChanged, rdbSi.CheckedChanged
            If (dataCargado = False And Me._Codigo = -1) Or dataCargado = True Then
                Dim blnValor As Boolean = rdbSi.Checked
                If Me.TipoAutoridadJudicialID = 1 Then 'debe verse secre y juez
                    Me.Size = New Size(706, 470)
                Else
                    Me.Size = New Size(706, 440)
                End If

                Me.btnCargarDocumento.Enabled = blnValor
                HabilitarControlesDoc(Not (blnValor))
                LimpiarControlesDoc()
            End If
        End Sub

        Private Sub frmMovimientoTrasladoCarceleta_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ValoresData()
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

