Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro
    Public Class uscMovimientoDetalle
        Private objBss As Bussines.Registro.InternoMovimiento = Nothing
        Private objEnt As Entity.Registro.InternoMovimiento = Nothing
        Public Property DocumentoRetornoID As Integer = -1
        'se aumento el ancho del combo de tipo libertad
#Region "Propiedades_Parametricas"

        Public Property _Codigo() As Integer = -1
        Public Property _MovimientoTipoID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _DocumentoTipoId() As Integer = -1
        Public Property _DocumJudicialD() As Integer = -1
        Public Property _blnNuevo As Boolean = False
        Public Property _CargarExpedientes() As Integer = -1
        Public Property _intCondicionGrupo() As Integer = -1
        Public Property _Documentos_sin_mov() As Boolean = False
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Public Property _EstadoEjecucionMovimientoOriginal As Integer = -1
        Public Property Movimiento_Observacion_Estado_Ejecucion_MD As String
        Public Property DocJudicialReferencia_OTHSM As Integer = -1
        Private VisiblePanel As Boolean = False
        Public Property FechaInscripcionLibertad As Long = 0
        Public Property Estado_Ejecucion_Ejecutado As Integer = -1
        Public Event CargarDocumentos()
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
        Public Property MovimientoMotivoIngreso() As Integer
            Get
                Return Me.cbbMovTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovTipo.SelectedValue = value
            End Set
        End Property
        Public Property MovimientoMotivoId() As Integer = -1
        Public Property MovimientoMotivo() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Public Property MovimientoMotivoNombre() As String
            Get
                Return Me.txtMovMotivo.Text
            End Get
            Set(ByVal value As String)
                Me.txtMovMotivo.Text = value
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
                Return Me.cbbEstado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEstado.SelectedValue = value
            End Set
        End Property
        Private Property idMovimientoEstado As Short = -1
        Public Property EstadoTramite() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(Me.cbbEstado.Text).ToUpper
            End Get
            Set(ByVal value As String)

            End Set
        End Property
        Public Property estadoMovimientoNombre As String
            Get
                Return Me.txtEstadoNoEje.Text
            End Get
            Set(value As String)
                Me.txtEstadoNoEje.Text = value
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
        Public Property OtroLugar() As String
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
        Public Property _EstablecimientomentalId As Integer = -1
        Public Property _Establecimientomental As String = ""

#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _getIdMovimientoGrupo As Short
            Get
                Return MovimientoGrupo
            End Get
        End Property
        Public ReadOnly Property _getIdEstadoMovimiento As Short
            Get
                Return Me.EstadoID
            End Get
        End Property
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

        Public Property _blnVisiblecbbMotivo As Boolean
            Get
                Return Me.cbbMovTipo.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.cbbMovTipo.Visible = value
            End Set
        End Property

        Public Property _blnVisiblelblMotivo As Boolean
            Get
                Return Me.lblMovMotivo.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.lblMovMotivo.Visible = value
            End Set
        End Property

        Public Property _uscEscritura As Boolean = False

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

        Private Sub ComboMovimientoMotivoIngreso()
            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbMovTipo
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                .DataSource = objBss.Combo_MovimientoMotivo(Me._MovimientoTipoID, Type.Combo.enmTipoTexto.Mayuscula)
            End With

            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                lblMovMotivo.Visible = False
                cbbMovTipo.Visible = False
            End If
        End Sub
        Private Sub ComboMovimientoMotivo()
            Dim objBss As New Bussines.General.Parametrica
            If Me._TipoLicencia = enmTipoLicencia.MedioLibreLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or
                    Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                If Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                    With Me.cbbMovMotivo
                        .DataSource = (New Bussines.General.Parametrica).Listar(Type.Combo.ComboTipo.MovimientoMotivo, Me._MovimientoTipoID, Me._MovimientoTipoID, -1, False, "")
                        .DisplayMember = "nombre"
                        .ValueMember = "codigo"
                        '.DropDownWidth = 200
                    End With
                Else
                    With Me.cbbMovMotivo
                        .ValueMember = "Codigo"
                        .DisplayMember = "Nombre"
                        .DataSource = objBss.Combo_MovimientoMotivo_LM(Me._MovimientoTipoID, Type.Combo.enmTipoTexto.Mayuscula)
                    End With
                End If
            Else
                Dim MovtipId As Integer = Me._MovimientoTipoID
                If (MovtipId = 1) Then
                    MovtipId = 2
                End If
                With Me.cbbMovMotivo
                    .ValueMember = "Codigo"
                    .DisplayMember = "Nombre"
                    .DataSource = objBss.Combo_MovimientoMotivo(MovtipId, Type.Combo.enmTipoTexto.Mayuscula)
                End With
            End If
        End Sub
        Private cargoComboEstado As Boolean = False
        Private Sub ComboEstado()

            Dim objBss As New Bussines.General.Parametrica

            With Me.cbbEstado
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"

                Select Case Me._MovimientoTipoID
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental,
                         Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental
                        .DataSource = objBss.ComboMovimientoEstado 'ComboMovimientoEstadoOrdenTrasladoSaludMental
                        .SelectedIndex = 0
                    Case Else
                        .DataSource = objBss.ComboMovimientoEstado
                        .SelectedIndex = 0
                End Select
            End With
            cargoComboEstado = True
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
                    lblMovMotivo.Text = "Modalidad"
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

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
                Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_LM(EntMov)
            Else
                objEnt = objBss.Listar(EntMov)
            End If

            With objEnt
                Me.MovimientoGrupo = .MovimientoGrupoID
                Me.MovimientoGrupoNom = .MovimientoGrupoNombre
                Me.MovimientoTipo = .MovimientoTipoID

                If Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then

                    If .MovimientoSubMotivoID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then

                        Me.lblMovMotivo.Visible = True
                        Me.cbbMovTipo.Visible = True
                        Me.lblSubmotivo.Visible = True
                        Me.cbbMovMotivo.Visible = True
                        Me.MovimientoMotivoIngreso = .MovimientoSubMotivoID
                        Me.MovimientoMotivo = .MovimientoMotivoID
                    Else
                        lblMovMotivo.Visible = True
                        cbbMovTipo.Visible = True
                        lblSubmotivo.Visible = False
                        cbbMovMotivo.Visible = False
                        Me.MovimientoMotivoIngreso = .MovimientoMotivoID
                    End If

                Else

                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            Me.MovimientoMotivo = .MovimientoMotivoID
                            Me.MovimientoMotivoId = .MovimientoMotivoID
                            Me.txtMovMotivo.Text = .MovimientoMotivoNombre
                        Case enmTipoLicencia.RegionProvincia, enmTipoLicencia.PenalLimaProvincia, enmTipoLicencia.PenalProvincia
                            Me.MovimientoMotivo = .MovimientoMotivoID

                        Case Else

                            If Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                                Me.MovimientoMotivo = .MovimientoMotivoID
                                Me.txtMovMotivo.Text = .MovimientoMotivoNombre
                            ElseIf Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental Or
                                Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental Then
                                Me.MovimientoMotivo = .MovimientoMotivoID

                            ElseIf Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Conducciones Then
                                Me.MovimientoMotivo = .MovimientoMotivoID

                            Else
                                Me.MovimientoMotivo = .MovimientoSubMotivoID
                            End If

                    End Select
                End If

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
                Me.Movimiento_Observacion_Estado_Ejecucion_MD = .Movimiento_Observacion_Estado_Ejecucion_IM
                Me.idMovimientoEstado = .EstadoID
                Me.EstadoID = .EstadoID
                Me.EstadoTramiteID = .EstadoID
                Me.EstadoTramite = .EstadoNombre
                verEstadoNoEjecutado(Me.idMovimientoEstado)

                Me._DocumentoTipoId = .DocumentoTipoID
                Me._DocumJudicialD = .DocumJudicialID
                Me._RegionOrigenID = .RegionOrigenID
                Me._PenalOrigenID = .PenalOrigenID
                Me._RegionDestinoID = .RegionDestinoID
                Me._PenalDestinoID = .PenalDestinoID

                If Me.EstadoTramiteID = Type.Enumeracion.Movimiento.enmEstadoMovimiento.Terminado Or
                    Me.EstadoTramiteID = Type.Enumeracion.Movimiento.enmEstadoMovimiento.EgresoDifinitivo Then

                    Me.EstadoAuxID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        ControlesCarceletaReadOnly()
                    Else
                        ControlesReadOnly()
                    End If
                End If
                Me.DocJudicialReferencia_OTHSM = .DocJudicialReferencia_OTHSM
                Me.Estado_Ejecucion_Ejecutado = .Estado_Ejecucion_Ejecutado
                Me.Movimiento_Observacion_Estado_Ejecucion_MD = .Movimiento_Observacion_Estado_Ejecucion_IM
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

            'fecha de movimiento, futuro
            Dim dteFechaHoy As Date = Legolas.LBusiness.Globall.DateTime.FechaServer
            Dim dteFechaMov As Date = Legolas.Components.FechaHora.FechaDate(Me.dtpFechaMov.ValueLong, True)
            Dim intCant As Integer = Legolas.Components.FechaHora.FechaDateCalcularDias(dteFechaHoy, dteFechaMov, False)

            If Me._FechaMovimiento > Legolas.Components.FechaHora.FechaLong(dteFechaHoy) Then 'intCant > 3 
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de movimiento no puede ser mayor a la fecha actual. (Fecha de Actual: " & dteFechaHoy.ToShortDateString & ")")
                Me.dtpFechaMov.Focus()
                Return False
            End If

            If Me.FechaInscripcionLibertad > 0 And Me.FechaInscripcionLibertad > Me._Fecha_Movimiento Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de movimiento no puede ser menor a la fecha de inscripción " &
                                                                        "del documento la Libertad [" & Legolas.Components.FechaHora.FechaDate(Me.FechaInscripcionLibertad, True) & "].")
                Me.dtpFechaMov.Focus()
                Return False
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
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un movimiento con fecha igual o superior")
                        dtpFechaMov.Focus()
                        Return False
                    End If
                End If
            End If

            If Me.MovimientoTipo < Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese Tipo de Movimiento")
                blnValue = False
                Return blnValue
            End If

            Select Case Me.MovimientoTipo
                Case Type.Enumeracion.Movimiento.EnumMovTipo.Internamiento, Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                    If Me.MovimientoMotivo < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Motivo de Movimiento")
                        blnValue = False
                        Me.cbbMovTipo.Focus()
                        Return blnValue
                    End If
                Case Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    If Me.MovimientoMotivo < 1 And Me.MovimientoMotivoId < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Motivo de Movimiento")
                        blnValue = False
                        Me.cbbMovMotivo.Focus()
                        Return blnValue
                    End If
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
            If Me.MovimientoTipo = 10 And Me.EstadoID = 3 Then
                If Me.Estado_Ejecucion_Ejecutado < 40 Then
                    If DocumentoRetornoID <> 71 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe seleccionar un motivo.")
                        blnValue = False
                        Me.btnNoEjecutado.Focus()
                        Return blnValue
                    End If
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
                .IngresoInpeId = IIf(EntObj.IngresoInpeId = -1, Me._InternoIngresoInpeId, EntObj.IngresoInpeId)
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

                Select Case .MovimientoTipoID
                    Case EnumMovTipo.Internamiento
                        If Me.MovimientoMotivoIngreso = EnumMovMotivo.IngresoTraslado Then
                            .MovimientoSubMotivoID = Me.MovimientoMotivoIngreso
                            .MovimientoMotivoID = Me.MovimientoMotivo
                        Else
                            .MovimientoMotivoID = Me.MovimientoMotivoIngreso
                        End If

                    Case EnumMovTipo.TrasladoHospitalmental

                        .MovimientoMotivoID = Me.MovimientoMotivo
                        '.EstablecimientomentalID = EntObj.EstablecimientomentalID
                        .Establecimientomental = EntObj.Establecimientomental
                        .EstadoTramiteID = EntObj.EstadoTramiteID

                    Case EnumMovTipo.RetornodeHospitalmental

                        .MovimientoMotivoID = Me.MovimientoMotivo
                        '.EstablecimientomentalID = Me._EstablecimientomentalId
                        .Establecimientomental = Me._Establecimientomental
                    Case Else
                        '.EstablecimientomentalID = EntObj.EstablecimientomentalID
                        .Establecimientomental = EntObj.Establecimientomental
                End Select

                .Fecha = Me.FechaRegistroMovimiento

                If Me.MovimientoTipo = EnumMovTipo.Internamiento Or Me.MovimientoTipo = EnumMovTipo.Libertad Then
                    Me.TipoOrigenDestino = 3
                End If

                If Me.MovimientoTipo = EnumMovTipo.Conducciones Then
                    .PeriodoRetorno = Me.txtdias.Text
                    .PeriodoTipo = Me.cbbPeriodo.SelectedIndex
                    .FechaRetorno = Me.FechaRetorno
                    .MovimientoMotivoID = Me.MovimientoMotivo
                End If

                If Me.MovimientoGrupo = EnumMovGrupo.Ingreso Then

                    If Me.TipoOrigenDestino = 1 Then
                        .PenalOrigenID = Me._PenalMovID
                        .PenalDestinoID = Me._PenalID
                        .OrigenNombre = ""
                        .DestinoNombre = ""
                        If Me._MovimientoTipoID = 10 Then
                            .OrigenNombre = Me._Establecimientomental
                        End If

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

                    If Me.MovimientoTipo = EnumMovTipo.Internamiento Then
                        .RegionDestinoID = Me._RegionID
                        .PenalDestinoID = Me._PenalID
                    End If

                ElseIf Me.MovimientoGrupo = EnumMovGrupo.Egreso Then

                    If Me.MovimientoTipo = EnumMovTipo.Libertad Then
                        '  .MovimientoMotivoID = Me.MovimientoSubMotivo
                        Me.TipoOrigenDestino = 3
                        .MovimientoMotivoID = Me.MovimientoMotivoId

                    ElseIf Me.MovimientoTipo = EnumMovTipo.Fuga Or Me.MovimientoTipo = EnumMovTipo.Fallecimiento Then
                        Me.TipoOrigenDestino = 3
                        .MovimientoMotivoID = Me.MovimientoMotivoIngreso

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
                        .DestinoNombre = IIf(Me._MovimientoTipoID = 9, Me._Establecimientomental, "")

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
                            .MovimientoMotivoID = Me.MovimientoMotivoIngreso
                        ElseIf Me.MovimientoTipo = 3 Then
                            .RegionOrigenID = Me._RegionID
                            .PenalOrigenID = Me._PenalID
                            .PenalDestinoID = -1
                        End If

                    End If
                End If
                .DocJudicialReferencia_OTHSM = EntObj.DocJudicialReferencia_OTHSM
                .Estado_Ejecucion_Ejecutado = EntObj.Estado_Ejecucion_Ejecutado
                .Movimiento_Observacion_Estado_Ejecucion_IM = Me.Movimiento_Observacion_Estado_Ejecucion_MD
                'validar el estado no ejecutado
                If Me.idMovimientoEstado > 40 Then
                    .EstadoID = Me.idMovimientoEstado
                Else
                    .EstadoID = Me.EstadoID
                End If
                If Me.MovimientoTipo = 9 Then
                    Me.EstadoTramiteID = EntObj.EstadoTramiteID
                End If
                .DocJudObservacion = Me.Observacion
                .Observacion = EntObj.Movimiento_Observacion_Estado_Ejecucion_IM
                .PeriodoRetorno = Me.PeriodoRetorno
                .PeriodoTipo = Me.PeriodoTipo
                .FechaRetorno = Me.FechaRetorno
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.InternoMovimiento

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                               Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                Select Case Me.MovimientoTipo
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Fuga,
                         Type.Enumeracion.Movimiento.EnumMovTipo.Fallecimiento
                        objEnt.MovimientoMotivoID = Me.MovimientoMotivo
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                        objEnt.MovimientoMotivoID = Me.MovimientoMotivoId
                End Select

                value = objBss.Grabar_LM(objEnt)

            Else
                Select Case Me.MovimientoTipo
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Fuga,
                         Type.Enumeracion.Movimiento.EnumMovTipo.Fallecimiento
                        objEnt.MovimientoMotivoID = Me.MovimientoMotivo
                    Case Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                        objEnt.MovimientoMotivoID = Me.MovimientoMotivo
                End Select
                value = objBss.Grabar(objEnt)
            End If

            Return value

        End Function

        Public Sub ControlesReadOnly()
            Select Case Me._MovimientoTipoID
                Case EnumMovTipo.Libertad, EnumMovTipo.Fuga, EnumMovTipo.Fallecimiento
                    dtpFechaMov.Enabled = False
                    nudHora.Enabled = False
                    nudMinutos.Enabled = False
                    txtObservacion.ReadOnly = True
                    'If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
                    '   Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                    cbbMovMotivo.Enabled = False
                    cbbEstado.Enabled = False
                    'End If
                Case EnumMovTipo.Conducciones
                    dtpFechaMov.Enabled = False
                    nudHora.Enabled = False
                    nudMinutos.Enabled = False
                    cbbEstado.Enabled = False
                    cbbMovTipo.Enabled = False
                    cbbMovMotivo.Enabled = True
                    rdbPenal.Enabled = False
                    rdbOtroLugar.Enabled = False
                    dtpFecharetorno.Enabled = False
                    cbbPeriodo.Enabled = False
                    txtOtroLugar.ReadOnly = True
                    txtdias.ReadOnly = True
                    txtObservacion.ReadOnly = True
                Case Else
                    cbbEstado.Enabled = False
                    cbbMovTipo.Enabled = False
                    cbbMovMotivo.Enabled = False
                    rdbPenal.Enabled = False
                    rdbOtroLugar.Enabled = False
                    dtpFecharetorno.Enabled = False
                    cbbPeriodo.Enabled = False
                    txtOtroLugar.ReadOnly = True
                    txtdias.ReadOnly = True
                    If Me._MovimientoTipo = EnumMovTipo.Internamiento And Me.MovimientoMotivoIngreso = 3 Then
                        cbbMovMotivo.Enabled = True
                        cbbMovTipo.Visible = True
                        lblMovMotivo.Visible = True
                    End If
            End Select
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
                cbbMovTipo.Enabled = False
                cbbMovMotivo.Enabled = True
                rdbPenal.Enabled = False
                rdbOtroLugar.Enabled = False
                dtpFecharetorno.Enabled = False
                cbbPeriodo.Enabled = False
                txtOtroLugar.ReadOnly = True
                txtdias.ReadOnly = True
                txtObservacion.ReadOnly = True
            Else
                If Me._MovimientoTipoID = EnumMovTipo.Internamiento And Me.MovimientoMotivoIngreso = 3 Then
                    cbbMovMotivo.Enabled = True
                End If
                cbbEstado.Enabled = False
                cbbMovTipo.Enabled = False
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
#Region "Form"
        Private Sub Frm_EstadoNoEjecutado()

            Dim frm As New Registro.Resoluciones.frmEstadoNoEjecutadoPopup
            With frm
                ._setTipoLicencia = Me._TipoLicencia
                ._setEsMovimiento = True
                ._setTipoOpcion = Me.Estado_Ejecucion_Ejecutado 'Me.idMovimientoEstado
                ._SetObservacionEstado = Me.Movimiento_Observacion_Estado_Ejecucion_MD
                If .ShowDialog = DialogResult.OK Then
                    Me.Estado_Ejecucion_Ejecutado = ._getEstadoOpcion
                    Me.Movimiento_Observacion_Estado_Ejecucion_MD = ._getObservacionEstado 'e.cu.cco.
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub verBotonNoEjecutado()

            Dim idMovEstado As Short = -1

            'If idMovimientoEstado > 40 Then
            If Estado_Ejecucion_Ejecutado > 2 Then
                idMovEstado = idMovimientoEstado
            Else
                idMovEstado = Me.EstadoID
            End If

            If (idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.Pendiente Or
                    idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion1 Or
                    idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion2 Or
                    idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion3 Or
                    idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion4
                ) And Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then

                If Me._MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad Then
                    Me.btnNoEjecutado.Visible = False
                Else
                    Me.btnNoEjecutado.Visible = True
                End If


            ElseIf (idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.Terminado Or
                               idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion1 Or
                               idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion2 Or
                               idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion3 Or
                               idMovEstado = Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion4
                               ) And Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental Then

                If DocumentoRetornoID = 71 Then 'Or DocumentoRetornoID = -1 Then
                    Me.btnNoEjecutado.Visible = False
                Else
                    Me.btnNoEjecutado.Visible = True
                End If
            Else
                Me.btnNoEjecutado.Visible = False
            End If

        End Sub
        Private Sub verEstadoNoEjecutado(idMovimientoEstado As Short)

            'ocultar el combo estado
            If idMovimientoEstado > 40 Then
                Me.cbbEstado.Visible = False
                Me.txtEstadoNoEje.Visible = True

                Dim nombreEstado As String = ""
                Select Case idMovimientoEstado
                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion1
                        nombreEstado = "NO TERMINADO/Por no ser recibido en hospital mental destino"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion2
                        nombreEstado = "NO TERMINADO/Por orden judicial"

                    Case Type.Enumeracion.Movimiento.enmEstadoMovimiento.NoEjecutadoOpcion3
                        nombreEstado = "NO TERMINADO/Pendiente de ejecución, por tener otros procesos vigentes."

                End Select
                Me.txtEstadoNoEje.Text = nombreEstado
                'Me.txtEstadoNoEje.Size = New Size(243, Me.txtEstadoNoEje.Height)
            End If

        End Sub
        Public Sub _LoadUsc()

            ValoresxDefault()
            _Listar()

        End Sub

        Private Sub ValoresxDefault()

            ConfigurarHora()
            rdbSinorigen.Visible = False
            ComboEstado()
            ComboPeriodoTipo()
            ComboMovimientoMotivoIngreso()
            ComboMovimientoMotivo()
            ComboRegion()
            Me.PnlOrigenDestino.Visible = Me._blnVisibleOrigenDestino
            Me.btnNoEjecutado.Visible = Me._uscEscritura

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

                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                        Me.cbbMovTipo.Enabled = True
                    ElseIf Me._TipoLicencia <= enmTipoLicencia.RegionProvincia Then
                        lblMovMotivo.Visible = False
                        cbbMovTipo.Visible = False
                        lblSubmotivo.Visible = True
                        lblSubmotivo.Text = "Motivo Traslado"
                    Else
                        Me.cbbMovTipo.Enabled = _Documentos_sin_mov
                    End If

                    If Me._MovimientoTipoID = 3 Then

                    End If

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

                    lblMovMotivo.Visible = False
                    cbbMovTipo.Visible = False
                    lblSubmotivo.Visible = True

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
                    Me.cbbMovTipo.Enabled = True
                    txtMovimientoTipo.Text = ("LIBERTAD").ToUpper
                    Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.Libertad
                    Me.lblSubmotivo.Text = "Motivo :"
                    Me.cbbMovTipo.Visible = False
                    lblMovMotivo.Visible = False
                    lblSubmotivo.Visible = True
                    Me.cbbMovMotivo.Enabled = False
                    txtMovMotivo.Visible = True
                    Me.btnNoEjecutado.Visible = False
                Case EnumMovTipo.Fuga, EnumMovTipo.Fallecimiento

                    Me.MovimientoGrupo = EnumMovGrupo.Egreso
                    Me.MovimientoGrupoNom = "EGRESO"
                    Me.MovimientoTipo = Me._MovimientoTipoID
                    Me.txtMovimientoTipo.Text = Me.MovimientoTipoNombre
                    If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                        Me.MovimientoMotivo = IIf(Me.MovimientoTipo = EnumMovTipo.Fuga, 77, 78)
                    Else
                        Me.MovimientoMotivo = IIf(Me.MovimientoTipo = EnumMovTipo.Fuga, 77, 78)
                    End If
                    lblSubmotivo.Visible = True
                    lblSubmotivo.Text = "Motivo"
                    Me.cbbMovMotivo.Enabled = False

                Case EnumMovTipo.TrasladoHospitalmental

                    txtMovimientoGrupo.Text = "EGRESO"
                    Me.MovimientoGrupo = EnumMovGrupo.Egreso
                    Me.cbbMovTipo.Visible = False
                    txtMovimientoTipo.Text = ("Traslado a hospital de salud mental").ToUpper
                    txtMovimientoTipo.Size = New Size(333, 21)
                    Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.TrasladoHospitalmental
                    lblMovMotivo.Text = "Ref. documento: "
                    lblMovMotivo.Visible = True

                    lblSubmotivo.Visible = True
                    lblSubmotivo.Text = "Motivo :"
                    cbbMovMotivo.Visible = True
                    cbbMovMotivo.Enabled = False

                    lblEstado.Text = "Estado de egreso:"
                    btnCargarDocumento.Visible = True

                    txtMovimientoTipo.Location = New Point(420, 4)
                    cbbEstado.Location = New Point(420, 49)

                Case EnumMovTipo.RetornodeHospitalmental

                    txtMovimientoGrupo.Text = "INGRESO"
                    Me.MovimientoGrupo = EnumMovGrupo.Ingreso
                    Me.cbbMovTipo.Visible = False
                    txtMovimientoTipo.Text = ("Retorno de hospital de salud mental").ToUpper
                    txtMovimientoTipo.Size = New Size(333, 21)
                    Me.MovimientoTipo = Type.Enumeracion.Movimiento.EnumMovTipo.RetornodeHospitalmental
                    lblMovMotivo.Text = "Ref. documento: "
                    lblMovMotivo.Visible = True

                    lblSubmotivo.Visible = True
                    lblSubmotivo.Text = "Motivo :"
                    cbbMovMotivo.Visible = True
                    cbbMovMotivo.Enabled = False

                    lblEstado.Text = "Estado :"
                    btnCargarDocumento.Visible = True

                    txtMovimientoTipo.Location = New Point(420, 4)
                    cbbEstado.Location = New Point(420, 49)
            End Select

            verBotonNoEjecutado()

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
            'Dim Valor As String = dtpFechaMov.Value
            'If IsDate(Valor) Then
            '    If dtpFechaMov.Value > Now() Then
            '        dtpFechaMov.Value = Nothing
            '        dtpFechaMov.Focus()
            '    End If
            'End If
        End Sub

        Private Sub uscMovimientoDetalle_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ToolTip1.SetToolTip(txtMovMotivo, txtMovMotivo.Text)
            Me.dtpFecharetorno.Visible = False
            Me.lblFecharetorno.Visible = False
            lblTiemposalida.Visible = False
            txtdias.Visible = False
            cbbPeriodo.Visible = False
        End Sub

        Private Sub cbbMovTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbMovTipo.SelectedIndexChanged

            If Me.MovimientoTipo <> 9 Then
                ComboMovimientoMotivo()
            End If

            Select Case Me.MovimientoTipo
                Case 1, 2, 3, 6 'jonh referenciar a los types
                    Me.cbbMovTipo.Enabled = True
                Case 4, 5
                    Me.cbbMovTipo.Enabled = False
            End Select

        End Sub

        Private Sub btnCargarDocumento_Click(sender As Object, e As EventArgs) Handles btnCargarDocumento.Click
            RaiseEvent CargarDocumentos()
        End Sub

        Private Sub btnNoEjcutado_Click(sender As Object, e As EventArgs) Handles btnNoEjecutado.Click

            Frm_EstadoNoEjecutado()

        End Sub

        Private Sub cbbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEstado.SelectedIndexChanged

            If cargoComboEstado = True Then
                verBotonNoEjecutado()
            End If

        End Sub

        Private Sub uscMovimientoDetalle_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        End Sub


    End Class

End Namespace
