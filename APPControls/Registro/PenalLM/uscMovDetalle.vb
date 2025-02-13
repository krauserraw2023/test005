Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.PenalLM
    Public Class uscMovDetalle
        Private objBss As Bussines.Registro.InternoMovimiento = Nothing
        Private objEnt As Entity.Registro.InternoMovimiento = Nothing

#Region "Propiedades_Parametricas"

        Public Property _Codigo() As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _DocumJudicialD() As Integer = -1
        Public Property _blnNuevo As Boolean = False
        Public Property _CargarExpedientes() As Integer = -1
        Public Property _intCondicionGrupo() As Integer = -1
        Public Property _Documentos_sin_mov() As Boolean = False
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

        Private VisiblePanel As Boolean = False
#End Region
#Region "Propiedades"

        Public Property MovimientoGrupo() As Integer = -1
        Public Property MovimientoGrupoNom() As String
            Get
                Return txtMovimientoGrupo.Text
            End Get
            Set(value As String)
                If MovimientoGrupo = 1 Then
                    value = "INGRESO"
                    Me.MovimientoGrupo = 1
                ElseIf MovimientoGrupo = 2 Then
                    value = "EGRESO"
                    Me.MovimientoGrupo = 2
                    If Me._MovimientoTipoID = 6 Then
                        Me.dtpFecharetorno.Visible = True
                        Me.lblFecharetorno.Visible = True
                        lblTiemposalida.Visible = True
                        txtdias.Visible = True
                        cbbPeriodo.Visible = True
                    End If
                Else
                    value = ""
                End If
                Me.txtMovimientoGrupo.Text = value
            End Set
        End Property
        Public Property MovimientoTipo() As Integer = -1

        Private Property MovimientoTipoNombre() As String
            Get
                Dim strValor As String = ""
                Select Case MovimientoTipo
                    Case EnumMovTipo.Internamiento
                        strValor = "INTERNAMIENTO"
                    Case EnumMovTipo.Traslado
                        strValor = "TRASLADO"
                    Case EnumMovTipo.Libertad
                        strValor = "LIBERTAD"
                    Case EnumMovTipo.Fuga
                        strValor = "FUGA"
                    Case EnumMovTipo.Fallecimiento
                        strValor = "FALLECIMIENTO"
                    Case EnumMovTipo.Conducciones
                        strValor = "CONDUCCIONES"
                End Select
                Return strValor
            End Get
            Set(ByVal value As String)
                Me.txtMovimientoTipo.Text = value
            End Set
        End Property
       
        Private Property MovimientoMotivo() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
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
        Private ReadOnly Property FechaRegistroMovimiento As Long
            Get
                Dim FechaTotal As String
                Dim Hora As String = "00"
                Dim Minutos As String = "00"

                Dim fecha As String = dtpFechaMov.Value & " " & CStr(HoraMovimiento) & ":" & CStr(MinutoMovimiento) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
            End Get
        End Property
        Public ReadOnly Property _Fecha_Movimiento() As Long
            Get
                Dim FechaTotal As String

                Dim fecha As String = dtpFechaMov.Value & " " & CStr(Me.HoraMovimiento) & ":" & CStr(Me.MinutoMovimiento) & ":00"
                FechaTotal = CDate(fecha).ToFileTime
                Return FechaTotal
            End Get
        End Property

        Private Property TipoOrigenDestino() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbPenal.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbOtroLugar.Checked = True Then
                    intValue = 2
                End If

                If Me.rdbSinorigen.Checked = True Then
                    intValue = 3
                End If
                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        Me.rdbPenal.Checked = True
                    Case 2
                        Me.rdbOtroLugar.Checked = True
                    Case 3
                        Me.rdbSinorigen.Checked = True
                End Select
            End Set
        End Property
        Public Property EstadoTramiteID() As Integer = -1
        Public Property EstadoID() As Integer
            Get
                If cbbEstado.Items.Count = 0 Then
                    Me.EstadoTramiteID = -1
                    Return -1
                Else
                    If cbbEstado.SelectedIndex = 0 Then
                        Me.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente
                    ElseIf cbbEstado.SelectedIndex = 1 Then
                        Me.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                    End If
                    Return Me.EstadoTramiteID
                End If
            End Get
            Set(ByVal value As Integer)
                If cbbEstado.Items.Count = 0 Then
                    value = -1
                    Me.EstadoTramiteID = -1
                End If
                cbbEstado.SelectedIndex = value
            End Set
        End Property
        Public Property EstadoTramite() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(Me.cbbEstado.Text).ToUpper
            End Get
            Set(ByVal value As String)

            End Set
        End Property
        Public Property EstadoAuxID() As Integer
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _PenalID1() As Integer = -1
        Public Property _PenalID2() As Integer = -1
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
        Private Property OtroLugar() As String
            Get
                Return Me.txtOtroLugar.Text
            End Get
            Set(ByVal value As String)
                Me.txtOtroLugar.Text = value
            End Set
        End Property

        Public Property Observacion() As String
            Get
                Return Me.txtObservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Private Property PeriodoRetorno() As String
            Get
                Return Me.txtdias.Text
            End Get
            Set(ByVal value As String)
                Me.txtdias.Text = value
            End Set
        End Property
        Private Property PeriodoTipo() As String
            Get
                Return Me.cbbPeriodo.SelectedIndex
            End Get
            Set(ByVal value As String)
                Me.cbbPeriodo.SelectedIndex = value
            End Set
        End Property
        Private Property FechaRetorno() As Long
            Get
                Return Me.dtpFecharetorno.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFecharetorno.ValueLong = value
            End Set
        End Property
        Public Property Enabletcontrol() As Boolean = False

        Public Property _RegionOrigenID() As Integer = -1
        Public Property _PenalOrigenID() As Integer = -1
        Public Property _RegionDestinoID() As Integer = -1
        Public Property _PenalDestinoID() As Integer = -1
#End Region
#Region "Propiedades_UserControl"
        Public Property _blnVisibleOrigenDestino() As Boolean
            Get
                Return Me.PnlOrigenDestino.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.PnlOrigenDestino.Visible = value
            End Set
        End Property

        'Public Property _blnVisiblecbbMotivo As Boolean
        '    Get
        '        Return Me.cbbMovTipo.Visible
        '    End Get
        '    Set(ByVal value As Boolean)
        '        Me.cbbMovTipo.Visible = value
        '    End Set
        'End Property

        'Public Property _blnVisiblelblMotivo As Boolean
        '    Get
        '        Return Me.lblMovMotivo.Visible
        '    End Get
        '    Set(ByVal value As Boolean)
        '        Me.lblMovMotivo.Visible = value
        '    End Set
        'End Property


#End Region
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

            Dim objBss As New Bussines.General.Parametrica
            With Me.cbbMovMotivo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoMotivo_LM(Me._MovimientoTipoID, Type.Combo.enmTipoTexto.Mayuscula)
            End With

        End Sub
    
        Private Sub ComboEstado()
            cbbEstado.Items.Clear()
            cbbEstado.Items.Insert(0, "PENDIENTE")
            cbbEstado.Items.Insert(1, "TERMINADO")
            cbbEstado.SelectedIndex = 0
        End Sub
        Private Sub ComboPeriodoTipo()
            cbbPeriodo.Items.Clear()
            cbbPeriodo.Items.Insert(0, "dias")
            cbbPeriodo.Items.Insert(1, "horas")
            cbbPeriodo.Items.Insert(2, "mn")
            cbbPeriodo.SelectedIndex = 0
        End Sub
#End Region
#Region "Listar"

        Private Sub _Listar()
            If Me._Codigo < 1 Then
                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                    lblSubmotivo.Visible = True
                    cbbMovMotivo.Visible = True
                ElseIf Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    'lblMovMotivo.Text = "Modalidad"
                    lblSubmotivo.Visible = False
                    cbbMovMotivo.Visible = False
                End If
                Exit Sub
            End If

            objEnt = New Entity.Registro.InternoMovimiento
            objBss = New Bussines.Registro.InternoMovimiento

            Dim EntMov As New Entity.Registro.InternoMovimiento
            With EntMov
                .Codigo = Me._Codigo
            End With

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_LM(EntMov)
            Else
                objEnt = objBss.Listar(EntMov)
            End If

            With objEnt
                Me.MovimientoGrupo = .MovimientoGrupoID
                Me.MovimientoGrupoNom = .MovimientoGrupoNombre
                Me.MovimientoTipo = .MovimientoTipoID
                Me.MovimientoMotivo = .MovimientoMotivoID
                Me._FechaMovimiento = .Fecha
                Dim f As Date
                f = Legolas.Components.FechaHora.FechaDate(.Fecha, True)
                Me.HoraMovimiento = Format(f, "HH")
                Me.MinutoMovimiento = Format(f, "mm")
                If .MovimientoGrupoID = EnumMovGrupo.Ingreso Then 'INGRESO
                    If .PenalOrigenID > 1 Then  'el ORIGEN es PENAL
                        Me.TipoOrigenDestino = 1
                        Me._RegionMovID = .RegionOrigenID
                        Me._PenalMovID = .PenalOrigenID

                    ElseIf .PenalOrigenID < 1 Then 'el ORIGEN es OTRO
                        If .OrigenNombre = "" Then
                            Me.TipoOrigenDestino = 3
                        Else
                            Me.TipoOrigenDestino = 2
                            Me.OtroLugar = .OrigenNombre
                        End If
                    End If
                    Me.lblOrigenDestino.Text = "Origen"
                ElseIf .MovimientoGrupoID = EnumMovGrupo.Egreso Then
                    If .PenalDestinoID > 1 Then
                        Me.TipoOrigenDestino = 1
                        Me._RegionMovID = .RegionDestinoID
                        Me._PenalMovID = .PenalDestinoID
                    ElseIf .PenalDestinoID < 1 Then
                        Me.TipoOrigenDestino = 2
                        Me.OtroLugar = .DestinoNombre
                    End If
                    lblRegion.Text = "Destino :"
                End If
                Me.txtdias.Text = .PeriodoRetorno
                Me.cbbPeriodo.SelectedIndex = .PeriodoTipo
                Me.FechaRetorno = .FechaRetorno
                Me.Observacion = .Observacion
                Me.EstadoID = IIf(.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Pendiente, 0, 1)
                Me.EstadoTramiteID = .EstadoID
                Me.EstadoTramite = .EstadoNombre
                Me._DocumJudicialD = .DocumJudicialID
                Me._RegionOrigenID = .RegionOrigenID
                Me._PenalOrigenID = .PenalOrigenID
                Me._RegionDestinoID = .RegionDestinoID
                Me._PenalDestinoID = .PenalDestinoID

                If Me.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado Then
                    Me.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                        ControlesCarceletaReadOnly()
                    Else
                        ControlesReadOnly()
                    End If
                End If
            End With
        End Sub
#End Region
#Region "Accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = True
            '/*Fecha de Movimiento*/
            If Me._FechaMovimiento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha del Movimiento")
                blnValue = False
                Me.dtpFechaMov.Focus()
                Return blnValue
            End If
            If Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                objBss = New Bussines.Registro.InternoMovimiento
                objEnt = New Entity.Registro.InternoMovimiento
                objEnt.InternoID = Me._InternoID
                objEnt.IngresoID = Me._IngresoID
                objEnt.IngresoInpeId = Me._InternoIngresoInpeId
                Dim EntColec As New Entity.Registro.InternoMovimientoCol
                If Me._Codigo < 1 Then
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        EntColec = objBss.ListarGrilla_LM(objEnt)
                    Else
                        EntColec = objBss.ListarGrilla(objEnt)
                    End If

                    '************************
                    Dim fec_mov, fec_ult_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(_Fecha_Movimiento, True)
                    If EntColec.Count = 0 Then

                    Else
                        fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(0).Fecha, True)
                        If fec_mov <= fec_ult_mov Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                            Return False
                        End If
                    End If
                Else
                    objEnt.Codigo = Me._Codigo
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        EntColec = objBss.ListarMovimiento_Diferente_LM(objEnt)
                    Else
                        EntColec = objBss.ListarMovimiento_Diferente(objEnt)
                    End If

                    Dim valor As Boolean = False
                    '************************
                    Dim fec_mov, fec_ult_mov As Date
                    fec_mov = Legolas.Components.FechaHora.FechaDate(_Fecha_Movimiento, True)

                    For i As Integer = 0 To EntColec.Count - 1
                        If Me._Codigo <> EntColec.InternoMovimiento(i).Codigo Then
                            fec_ult_mov = Legolas.Components.FechaHora.FechaDate(EntColec.InternoMovimiento(i).Fecha, True)
                            If fec_mov >= fec_ult_mov Then
                                valor = True
                                Exit For
                            End If
                        End If
                    Next
                    If valor = True Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha superior")
                        Return False
                    End If
                End If
            End If

            If Me.MovimientoTipo < Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese Tipo de Movimiento")
                blnValue = False
                Return blnValue
            End If
            'If Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento And Me.MovimientoMotivo = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
            '    If Me.MovimientoSubMotivo < 1 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese Submotivo del movimiento")
            '        blnValue = False
            '        Return blnValue
            '    End If
            'End If
            Select Case Me.MovimientoTipo
                Case Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento, Type.Enumeracion.Movimiento.EnumMovTipo.Traslado, _
                     Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    'If Me.MovimientoMotivo < 1 Then
                    '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Motivo de Movimiento")
                    '    blnValue = False
                    '    Me.cbbMovTipo.Focus()
                    '    Return blnValue
                    'End If
                Case Else

            End Select
            If Me.PnlOrigenDestino.Visible = True Then
                If Me.TipoOrigenDestino = 1 Then
                    'Region
                    If Me._RegionID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una Región")
                        blnValue = False
                        Me.cbbRegion.Focus()
                        Return blnValue
                    End If

                    'Penal
                    If Me._PenalID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un Penal")
                        blnValue = False
                        Me.cbbPenal.Focus()
                        Return blnValue
                    End If

                ElseIf Me.TipoOrigenDestino = 2 Then
                    'otro lugar
                    If Me.OtroLugar.Length < 4 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre del Origen/Destino del Movimiento")
                        blnValue = False
                        Me.txtOtroLugar.Focus()
                        Return blnValue
                    End If
                Else
                    Return blnValue
                End If
            End If
            If Me.MovimientoGrupo = EnumMovGrupo.Ingreso Then
                If Me._PenalOrigenID = Me._PenalID Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El proceso de ingreso no se puede realizar, El origen no puede ser el mismo penal")
                    blnValue = False
                    Me.cbbPenal.Focus()
                    Return blnValue
                End If
            Else
                If Me._PenalMovID = Me._PenalID Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El proceso de egreso no se puede realizar, El destino no puede ser el mismo penal")
                    blnValue = False
                    Me.cbbPenal.Focus()
                    Return blnValue
                End If
            End If
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                If Me._Codigo > 0 And Me.EstadoTramiteID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado And Me.MovimientoTipo = EnumMovTipo.Internamiento Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado de este movimiento es [Terminado], no se puede realizar ninguna accion")
                    Return False
                End If

            Else
                If Me._Codigo > 0 And Me.EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado And (Me.MovimientoTipo <> EnumMovTipo.Internamiento And Me.MovimientoTipo <> EnumMovTipo.Conducciones) Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El estado de este movimiento es [Terminado], no se puede realizar ninguna accion")
                    Return False
                End If

            End If
            Return blnValue
        End Function

        Public Function AGrabar(EntObj As Entity.Registro.InternoMovimiento) As Integer

            objEnt = New Entity.Registro.InternoMovimiento
            With objEnt
                .Codigo = Me._Codigo
                .InternoID = Me._InternoID
                .IngresoID = Me._IngresoID
                .IngresoInpeId = EntObj.IngresoInpeId
                .DocumJudicialID = EntObj.DocumJudicialID
                .DocumJudicialNum = EntObj.DocumJudicialNum
                .DocumJudicialFecharecepcion = EntObj.DocumJudicialFecharecepcion
                .DocumJudicialFecha = EntObj.DocumJudicialFecha
                .TipoAutoridadJudicialID = EntObj.TipoAutoridadJudicialID
                If .TipoAutoridadJudicialID = EnumTipoAutoridad.AutoridadJudicial Then
                    .AutoridadJudicialID = EntObj.AutoridadJudicialID
                    .SalaJudicialID = EntObj.SalaJudicialID
                    .DocJudJuez = EntObj.DocJudJuez
                    .DocJudSecretario = EntObj.DocJudSecretario
                Else
                    .DocJudJuez = EntObj.OtraAutoridadNombre
                    .DocJudSecretario = EntObj.OtraAutoridadCargo
                End If
                '''''''''''Usc Movimiento detalle''''''''''''
                .MovimientoGrupoID = Me.MovimientoGrupo
                .MovimientoTipoID = Me.MovimientoTipo
                .MovimientoMotivoID = Me.MovimientoMotivo
                .Fecha = Me.FechaRegistroMovimiento
                .DocJudObservacion = Me.Observacion
                If Me.MovimientoTipo = EnumMovTipo.Internamiento Or Me.MovimientoTipo = EnumMovTipo.Libertad Then
                    Me.TipoOrigenDestino = 3
                End If
                If Me.MovimientoTipo = EnumMovTipo.Conducciones Then
                    .PeriodoRetorno = Me.txtdias.Text
                    .PeriodoTipo = Me.cbbPeriodo.SelectedIndex
                    .FechaRetorno = Me.FechaRetorno
                End If

                If Me.MovimientoGrupo = EnumMovGrupo.Ingreso Then
                    If Me.TipoOrigenDestino = 1 Then
                        .PenalOrigenID = Me._PenalMovID
                        .PenalDestinoID = Me._PenalID
                        .OrigenNombre = ""
                        .DestinoNombre = ""
                    ElseIf Me.TipoOrigenDestino = 2 Then
                        .RegionOrigenID = -1
                        .PenalOrigenID = -1
                        .RegionDestinoID = Me._RegionID
                        .PenalDestinoID = Me._PenalID
                        .OrigenNombre = Me.OtroLugar
                        .DestinoNombre = ""
                    ElseIf Me.TipoOrigenDestino = 3 Then
                        .RegionOrigenID = Me._RegionOrigenID
                        .PenalOrigenID = Me._PenalOrigenID
                        .RegionDestinoID = Me._RegionDestinoID
                        .PenalDestinoID = Me._PenalDestinoID
                        .DestinoNombre = ""

                    End If
                ElseIf Me.MovimientoGrupo = EnumMovGrupo.Egreso Then

                    If Me.MovimientoTipo = EnumMovTipo.Libertad _
                        Or Me.MovimientoTipo = EnumMovTipo.Fuga _
                        Or Me.MovimientoTipo = EnumMovTipo.Fallecimiento Then

                        Me.TipoOrigenDestino = 3

                    ElseIf Me.MovimientoTipo = EnumMovTipo.Conducciones Then
                        .RegionOrigenID = Me._RegionID
                        .PenalOrigenID = Me._PenalID
                    End If
                    If Me.TipoOrigenDestino = 1 Then
                        .RegionOrigenID = Me._RegionID
                        .PenalOrigenID = Me._PenalID
                        .RegionDestinoID = Me._RegionMovID
                        .PenalDestinoID = Me._PenalMovID
                        .OrigenNombre = ""
                        .DestinoNombre = ""
                    ElseIf Me.TipoOrigenDestino = 2 Then
                        .PenalOrigenID = Me._PenalID
                        .PenalDestinoID = -1
                        .OrigenNombre = ""
                        .DestinoNombre = Me.OtroLugar
                    Else
                        If Me.MovimientoTipo = EnumMovTipo.Fuga Or Me.MovimientoTipo = EnumMovTipo.Fallecimiento Then
                            .RegionOrigenID = Me._RegionID
                            .PenalOrigenID = Me._PenalID
                            .PenalDestinoID = -1
                            .OrigenNombre = ""
                        ElseIf Me.MovimientoTipo = 3 Then
                            .RegionOrigenID = Me._RegionID
                            .PenalOrigenID = Me._PenalID
                            .PenalDestinoID = -1
                        End If
                    End If
                End If
                .EstadoID = Me.EstadoID
                .Observacion = Me.Observacion
                .PeriodoRetorno = Me.PeriodoRetorno
                .PeriodoTipo = Me.PeriodoTipo
                .FechaRetorno = Me.FechaRetorno
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.InternoMovimiento
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar(objEnt)
            End If

            Return value

        End Function

        Public Sub ControlesReadOnly()
            If Me._MovimientoTipoID = EnumMovTipo.Libertad Or Me._MovimientoTipoID = EnumMovTipo.Fuga Or Me._MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False
                txtObservacion.ReadOnly = True
            End If
            If Me._MovimientoTipoID = EnumMovTipo.Conducciones Then
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False
                cbbEstado.Enabled = False
                'cbbMovTipo.Enabled = False
                cbbMovMotivo.Enabled = True
                rdbPenal.Enabled = False
                rdbOtroLugar.Enabled = False
                dtpFecharetorno.Enabled = False
                cbbPeriodo.Enabled = False
                txtOtroLugar.ReadOnly = True
                txtdias.ReadOnly = True
                txtObservacion.ReadOnly = True
            Else
                'If Me._MovimientoTipoID = EnumMovTipo.Internamiento And Me.MovimientoSubMotivo = 3 Then
                '    cbbMovMotivo.Enabled = True
                'End If
                cbbEstado.Enabled = False
                'cbbMovTipo.Enabled = False
                rdbPenal.Enabled = False
                rdbOtroLugar.Enabled = False
                dtpFecharetorno.Enabled = False
                cbbPeriodo.Enabled = False
                txtOtroLugar.ReadOnly = True
                txtdias.ReadOnly = True
            End If
        End Sub
        Public Sub ControlesCarceletaReadOnly()
            If Me._MovimientoTipoID = EnumMovTipo.Libertad Or Me._MovimientoTipoID = EnumMovTipo.Fuga Or Me._MovimientoTipoID = EnumMovTipo.Fallecimiento Then
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False
                txtObservacion.ReadOnly = True
            End If
            If Me._MovimientoTipoID = EnumMovTipo.Conducciones Then
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False
                cbbEstado.Enabled = False
                'cbbMovTipo.Enabled = False
                cbbMovMotivo.Enabled = False
                rdbPenal.Enabled = False
                rdbOtroLugar.Enabled = False
                dtpFecharetorno.Enabled = False
                cbbPeriodo.Enabled = False
                txtOtroLugar.ReadOnly = True
                txtdias.ReadOnly = True
                txtObservacion.ReadOnly = True
            Else
                cbbEstado.Enabled = False
                rdbPenal.Enabled = False
                rdbOtroLugar.Enabled = False
                dtpFecharetorno.Enabled = False
                cbbPeriodo.Enabled = False
                txtOtroLugar.ReadOnly = True
                txtdias.ReadOnly = True
                dtpFechaMov.Enabled = False
                nudHora.Enabled = False
                nudMinutos.Enabled = False
                txtObservacion.ReadOnly = True
            End If
        End Sub
#End Region
#Region "Otros"
        Public Sub _LoadUsc()
            ValoresxDefault()
            _Listar()
        End Sub

        Private Sub ValoresxDefault()
            ConfigurarHora()
            rdbSinorigen.Visible = False
            ComboEstado()
            ComboPeriodoTipo()
            ComboMovimientoMotivo()
            ComboRegion()
            Me.PnlOrigenDestino.Visible = Me._blnVisibleOrigenDestino

            Me.dtpFecharetorno.Visible = False
            Me.lblFecharetorno.Visible = False
            lblTiemposalida.Visible = False
            txtdias.Visible = False
            cbbPeriodo.Visible = False

            Select Case _MovimientoTipoID
                Case EnumMovTipo.Internamiento
                    Me.MovimientoGrupo = EnumMovGrupo.Ingreso
                    Me.MovimientoTipo = EnumMovTipo.Internamiento
                    Me.lblOrigenDestino.Text = "Origen"
                    Me.PnlOrigenDestino.Visible = False
                    txtMovimientoGrupo.Text = "INGRESO"
                    txtMovimientoTipo.Text = "INTERNAMIENTO"
                Case EnumMovTipo.Conducciones
                    pnlCaborigendestino.Visible = True
                    Me.MovimientoGrupo = IIf(Me._intCondicionGrupo = EnumMovGrupo.Ingreso, EnumMovGrupo.Egreso, EnumMovGrupo.Ingreso)
                    txtMovimientoGrupo.Text = IIf(Me._intCondicionGrupo = 1, "EGRESO", "INGRESO")
                    rdbOtroLugar.Checked = True
                    Me.cbbEstado.Enabled = True
                    txtMovimientoTipo.Text = "CONDUCCIONES"
                    Me.MovimientoTipo = EnumMovTipo.Conducciones
                    If Me.MovimientoGrupo = EnumMovGrupo.Egreso Then
                        Me.dtpFecharetorno.Visible = True
                        Me.lblFecharetorno.Visible = True
                        lblTiemposalida.Visible = True
                        txtdias.Visible = True
                        cbbPeriodo.Visible = True
                    End If
                Case EnumMovTipo.Traslado
                    Me.MovimientoGrupo = IIf(Me._intCondicionGrupo = EnumMovGrupo.Ingreso, EnumMovGrupo.Egreso, EnumMovGrupo.Ingreso)
                    txtMovimientoGrupo.Text = IIf(Me._intCondicionGrupo = 1, "EGRESO", "INGRESO")
                    txtMovimientoTipo.Text = "TRASLADO"
                    Me.MovimientoTipo = 2
                    If Me.MovimientoGrupo = EnumMovGrupo.Ingreso Then
                        Me.MovimientoTipo = _MovimientoTipoID
                        Me.lblOrigenDestino.Text = "Origen"
                        Me.lblRegion.Text = "Region origen:"
                    Else
                        Me.MovimientoTipo = _MovimientoTipoID
                        Me.lblOrigenDestino.Text = "Destino"
                        rdbSinorigen.Visible = False
                        If Me.MovimientoTipo = EnumMovTipo.Traslado Then
                            If Me.MovimientoGrupo = EnumMovGrupo.Ingreso Then
                                Me.lblOrigenDestino.Text = "Origen"
                            Else
                                Me.lblOrigenDestino.Text = "Destino"
                            End If
                        End If
                        Me.lblRegion.Text = "Region destino:"
                    End If
                    pnlCaborigendestino.Visible = False
                    rdbPenal.Checked = True
                Case EnumMovTipo.Libertad
                    txtMovimientoGrupo.Text = "EGRESO"
                    Me.MovimientoGrupo = EnumMovGrupo.Egreso
                    Me.MovimientoTipo = _MovimientoTipoID
                    txtMovimientoTipo.Text = ("LIBERTAD").ToUpper
                    Me.MovimientoTipo = 3
                Case EnumMovTipo.Fuga, EnumMovTipo.Fallecimiento
                    Me.MovimientoGrupo = EnumMovGrupo.Egreso
                    txtMovimientoGrupo.Text = "EGRESO"
                    Me.MovimientoTipo = Me._MovimientoTipoID
                    Me.txtMovimientoTipo.Text = Me.MovimientoTipoNombre
            End Select
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

        Private Sub HabilitarPenal()

            Select Case Me.TipoOrigenDestino
                Case 1  'Origen/Destino Penal
                    Me.cbbRegion.Visible = True
                    Me.cbbPenal.Visible = True
                    Me.lblRegion.Visible = True
                    Me.lblRegion.Text = "Región:"
                    Me.lblPenal.Visible = True
                    Me.txtOtroLugar.Visible = False
                Case 2  'Otro Origen/Destino
                    If Me.MovimientoGrupo = 1 Then
                        Me.lblRegion.Text = "Lugar Origen:"
                    ElseIf Me.MovimientoGrupo = 2 Then
                        Me.lblRegion.Text = "Lugar Destino:"
                    End If
                    Me.txtOtroLugar.Visible = True

                    'Me.txtOtroLugar.Width = 300
                    Me.lblPenal.Visible = False
                    'Me.cbbRegion.SelectedValue = -1
                    Me.cbbRegion.Visible = False
                    'Me.cbbPenal.SelectedValue = -1
                    Me.cbbPenal.Visible = False
                Case 3
                    If Me.MovimientoGrupo = 1 Then
                        Me.lblRegion.Text = ""
                    ElseIf Me.MovimientoGrupo = 2 Then
                        Me.lblRegion.Text = ""
                    End If
                    Me.txtOtroLugar.Visible = False
                    ' Me.txtOtroLugar.Text = ""
                    Me.txtOtroLugar.Width = 300
                    Me.lblPenal.Visible = False
                    Me.cbbRegion.SelectedValue = -1
                    Me.cbbRegion.Visible = False
                    Me.cbbPenal.SelectedValue = -1
                    Me.cbbPenal.Visible = False

            End Select

        End Sub
#End Region

        Private Sub rdbPenal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPenal.CheckedChanged, rdbOtroLugar.Click
            HabilitarPenal()
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            If Me._RegionID > 0 Then
                ComboPenal()
            End If
        End Sub

        Private Sub rdbOtroLugar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbOtroLugar.CheckedChanged
            HabilitarPenal()
        End Sub

        Private Sub txtMinutos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nudHora.KeyPress
            MyBase.OnKeyPress(e)
            Dim c As Char = e.KeyChar
            If Not (Char.IsDigit(c) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
                Select Case c
                    Case " "c
                        ' Sin implementación
                    Case Chr(8)
                        ' Tecla retroceso
                    Case Else
                        e.Handled = True

                End Select
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rdbSinorigen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbSinorigen.CheckedChanged
            HabilitarPenal()
        End Sub

        Private Sub dtpFechaMov_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaMov.Validated
            Dim Valor As String = dtpFechaMov.Value
            If IsDate(Valor) Then
                If dtpFechaMov.Value > Now() Then
                    dtpFechaMov.Value = Nothing
                    dtpFechaMov.Focus()
                End If
            End If
        End Sub

        Private Sub uscMovimientoDetalle_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Me.dtpFecharetorno.Visible = False
            Me.lblFecharetorno.Visible = False
            lblTiemposalida.Visible = False
            txtdias.Visible = False
            cbbPeriodo.Visible = False
        End Sub

        Private Sub cbbMovTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

            ComboMovimientoMotivo()
            Select Case Me.MovimientoTipo
                Case 1, 2, 3, 6 'jonh referenciar a los types
                    'Me.cbbMovTipo.Enabled = True
                Case 4, 5
                    'Me.cbbMovTipo.Enabled = False
            End Select

        End Sub

        Private Sub dtpFechaMov__ValueChanged_1() Handles dtpFechaMov._ValueChanged

            If dtpFechaMov.Value > Now() Then
                dtpFechaMov.Value = Nothing
                dtpFechaMov.Focus()
            End If

        End Sub
    End Class

End Namespace
