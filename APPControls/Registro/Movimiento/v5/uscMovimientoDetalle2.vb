Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia
Imports Legolas.LType

Namespace Registro
    Public Class uscMovimientoDetalle2

        Private objBss As Bussines.Registro.InternoMovimiento = Nothing
        Private objEnt As Entity.Registro.InternoMovimiento = Nothing
        Public Event clicK_MostrarControlesAux(MotivoId As Integer, uscVisible As Boolean, menuVisible As Boolean)
#Region "Propiedades_Parametricas"
        'Private intCodigo As Integer
        Public Property _Codigo() As Integer = -1

        Public Property _CodigoResolucion() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _IngresoInpeID() As Integer = -1
        Public Property _IngresoID() As Integer = -1
        Public Property _DocumJudicialD() As Integer = -1


        Public Property _blnNuevo() As Boolean = False
        Public objEntExpTempoCol As New Entity.Registro.ExpedienteCol
        Public Property _CargarExpedientes() As Integer = -1
        Private Property RegionIngreso() As Integer
            Get
                Return cbbRegionIngreso.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegionIngreso.SelectedValue = value
            End Set
        End Property
        Private Property PenalIngreso() As Integer
            Get
                Return cbbPenalIngreso.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenalIngreso.SelectedValue = value
            End Set
        End Property
        Public Property DocumentoTipo As Integer = -1
        Public Property DocumentoSubTipo As Integer = -1
        Public Property _intCondicionGrupo() As Integer = -1
        Public Property _blnValor() As Boolean = False
        Public entDocJudicial As New Entity.Registro.DocumentoJudicial
        Public entExpedien As New Entity.Registro.Expediente
        Public _FechaInternamientoPenalOrigen As Long = 0
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
#Region "Propiedades"
        Public Property _MovimientoGrupo() As Integer = -1
        Public Property _MovimientoTipo2() As Integer = -1
        Public Property _MovimientoTipo() As Integer = 1

        Public Property _MovimientoMotivo() As Integer
            Get
                Return Me.cbbMovMotivo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivo.SelectedValue = value
            End Set
        End Property
        Public Property _MovimientoMotivoTraslado() As Integer
            Get
                Return Me.cbbMovMotivoTraslado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMovMotivoTraslado.SelectedValue = value
            End Set
        End Property
        Public Property _MovimientoMotivo2() As Integer = -1

        Public Property MovimientoTipo() As String
            Get
                Return Me.txtMovimiento.Text = "INTERNAMIENTO"
            End Get
            Set(ByVal value As String)
                Me.txtMovimiento.Text = "INTERNAMIENTO"
            End Set
        End Property

        Public Property _FechaMovimiento() As Long
            Get
                'Legolas.Components.FechaHora.FechaString(Me.dtpFechaMov.ValueLong)
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
        Public ReadOnly Property FechaRegistroMovimiento As Long
            Get
                Dim FechaTotal As Long
                If dtpFechaMov.ValueAnio > 0 Then
                    Dim fecha As String = dtpFechaMov.Value & " " & Me.HoraMovimiento & ":" & Me.MinutoMovimiento & ":00"
                    FechaTotal = CDate(fecha).ToFileTime
                End If
                Return FechaTotal
            End Get
        End Property
        Private Property EstadoID() As Integer = -1
        Private Property EstadoTramiteID() As Integer = -1

        Public Property _RegionID() As Integer = -1

        Public Property _PenalID() As Integer = -1
        Public Property _PenalID1() As Integer = -1
        Public Property _PenalID2() As Integer = -1

        Private Property Observacion() As String = ""
        Public Property _RegionIngreso() As Integer
            Get
                Dim v As Integer = -1
                v = Me.cbbRegionIngreso.SelectedValue

                If v = 0 Then v = -1

                Return v
            End Get
            Set(ByVal value As Integer)
                Me.cbbRegionIngreso.SelectedValue = value
            End Set
        End Property
        Public Property _PenalIngreso() As Integer
            Get
                Dim v As Integer = -1
                v = Me.cbbPenalIngreso.SelectedValue
                If v = 0 Then v = -1
                Return v
            End Get
            Set(ByVal value As Integer)
                Me.cbbPenalIngreso.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Propiedades_Retorno"
        Public ReadOnly Property _getIdMovimientoMotivo As Short
            Get
                Return Me._MovimientoMotivo
            End Get
        End Property
#End Region
#Region "Propiedades_UserControl"


        Public Property _blnVisiblecbbMotivo As Boolean
            Get
                Return Me.cbbMovMotivo.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.cbbMovMotivo.Visible = value
            End Set
        End Property
        Public Property _blnEnablecbbMotivo As Boolean
            Get
                Return Me.cbbMovMotivo.Enabled
            End Get
            Set(ByVal value As Boolean)
                Me.cbbMovMotivo.Enabled = value
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

#End Region 'ninugna
#Region "Combo"
        Private Sub CargarComboRegion()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegionIngreso
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
            cbbRegionIngreso.SelectedValue = -1
        End Sub
        Private Sub CargarComboPenal()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select

            With Me.cbbPenalIngreso
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = cbbRegionIngreso.SelectedValue
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboMovimientoMotivo()
            With Me.cbbMovMotivo
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR MOTIVO]"
                .CodigoPadre = Me._MovimientoTipo2
                ._LoadUsc(Type.Combo.ComboTipo.MovimientoMotivo, False, IIf(Me._DocumJudicialD = -1, "NEU", ""))
                Me.cbbMovMotivo.SelectedValue = -1
            End With
        End Sub
        Private Sub ComboMovimientoMotivoTraslado()
            With Me.cbbMovMotivoTraslado
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR MOTIVO TRASLADO]"
                .CodigoPadre = Type.Enumeracion.Movimiento.EnumMovTipo.Traslado
                .LoadUsc()
                Me.cbbMovMotivoTraslado.SelectedValue = -1
                '.Enabled = False
            End With
        End Sub
        'Private Sub ComboEstablecimeintomental()
        '    With Me.cbbEstablecimentomental
        '        ._Todos = True
        '        ._TodosMensaje = "[Seleccionar Establecimiento mental]"
        '        .ComboTipo = Type.Combo.ComboTipo.Establecimientomental
        '        .LoadUsc()
        '        Me.cbbEstablecimentomental.SelectedValue = -1
        '    End With
        'End Sub

#End Region
#Region "Listar"
        Dim intContador As Integer = 0
        Private Sub Listar()

            If Me._DocumJudicialD < 1 Or Me._InternoID < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Registro.InternoMovimiento
            objBss = New Bussines.Registro.InternoMovimiento
            objEnt.Codigo = -1
            objEnt.DocumJudicialID = Me._DocumJudicialD
            objEnt.InternoID = Me._InternoID
            objEnt.IngresoInpeId = Me._IngresoInpeID
            objEnt.IngresoID = Me._IngresoID
            objEnt.MovimientoTipoID = -1 ' Me._MovimientoTipo2

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_LM(objEnt)
            Else
                objEnt = objBss.Listar(objEnt)
            End If
            With objEnt
                Me._Codigo = .Codigo
                Me._MovimientoGrupo = .MovimientoGrupoID
                Me._MovimientoTipo = .MovimientoTipoID
                If .MovimientoSubMotivoID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
                    Me.cbbMovMotivo.SelectedValue = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado
                    Me.RegionIngreso = .RegionOrigenID
                    Me.PenalIngreso = .PenalOrigenID
                Else
                    Me._MovimientoMotivo = .MovimientoMotivoID '     
                    'cbbMovMotivo.SelectedValue = .MovimientoMotivoID
                    intContador = intContador + 1
                End If

                If Me._MovimientoMotivo = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
                    Me.RegionIngreso = .RegionOrigenID
                    Me.PenalIngreso = .PenalOrigenID
                    Me._MovimientoMotivo2 = .MovimientoSubMotivoID
                    Me._MovimientoMotivoTraslado = .MovimientoMotivoID
                End If

                Me._FechaMovimiento = .Fecha
                Dim f As Date
                f = Legolas.Components.FechaHora.FechaDate(.Fecha, True)
                Me.HoraMovimiento = Format(f, "HH")
                Me.MinutoMovimiento = Format(f, "mm")

                'tipo ORIGEN
                If .MovimientoGrupoID = EnumMovGrupo.Ingreso Then 'INGRESO
                    If .PenalOrigenID > 1 Then  'el ORIGEN es PENAL
                        Me._PenalID2 = Me._PenalID
                    End If
                End If

                Me.Observacion = .Observacion
                Me.EstadoID = .EstadoID
            End With

        End Sub
        Public Sub _ListarFecha(Fecha As Long)

            Dim f As Date
            f = Legolas.Components.FechaHora.FechaDate(Fecha, True)
            Me._FechaMovimiento = Fecha
            Me.HoraMovimiento = Format(f, "HH")
            Me.MinutoMovimiento = Format(f, "mm")

        End Sub
#End Region
#Region "Accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = True

            If Me._MovimientoMotivo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Motivo de Internamiento")
                blnValue = False
                Me.cbbMovMotivo.Focus()
                Return blnValue
            End If
            If Me._MovimientoMotivo = 3 And Me._MovimientoMotivoTraslado = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Motivo de Traslado")
                blnValue = False
                Me.cbbMovMotivoTraslado.Focus()
                Return blnValue
            End If
            If Me._FechaMovimiento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha del Movimiento")
                blnValue = False
                Me.dtpFechaMov.Focus()
                Return blnValue
            Else
                Dim entMovCol As New Entity.Registro.InternoMovimientoCol
                Dim entMov As New Entity.Registro.InternoMovimiento
                entMov.InternoID = Me._InternoID
                entMov.IngresoInpeId = Me._IngresoInpeID
                entMov.IngresoID = Me._IngresoID
                objBss = New Bussines.Registro.InternoMovimiento
                Select Case Me._TipoLicencia
                    Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                        entMovCol = objBss.ListarGrilla_LM(entMov)
                    Case Else
                        entMovCol = objBss.ListarGrilla(entMov)
                End Select
                If Me._Codigo < 1 And entMovCol.Count > 0 Then
                    If entMovCol.InternoMovimiento(0).Fecha > Me._FechaMovimiento Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un ingreso anterior con fecha superior")
                        blnValue = False
                        Me.dtpFechaMov.Focus()
                        Return blnValue
                    End If
                End If
            End If
            If Me._MovimientoMotivo = 3 Then
                If Me.RegionIngreso < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar region de origen")
                    blnValue = False
                    Me.cbbRegionIngreso.Focus()
                ElseIf Me.PenalIngreso < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Penal de origen")
                    blnValue = False
                    Me.cbbPenalIngreso.Focus()
                ElseIf Me._PenalID = Me.PenalIngreso Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El penal de origen no puede ser igual a la del destino.")
                    blnValue = False
                    Me.cbbPenalIngreso.Focus()
                End If
            End If

            Return blnValue
        End Function
        Public Function Validar2() As Boolean
            Dim blnValue As Boolean = True

            '/*Fecha de Movimiento*/

            If Me._FechaMovimiento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Ingrese fecha del Movimiento")
                blnValue = False
                Me.dtpFechaMov.Focus()

                Return blnValue
            End If
            If Me._MovimientoMotivo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Ingresar motivo del movimiento")
                blnValue = False
                Me.cbbMovMotivo.Focus()
                Return blnValue
            End If

            Return blnValue
        End Function
        Public Function ValidarNuevo() As Boolean
            Dim blnValue As Boolean = True

            If Me._MovimientoMotivo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar el motivo de ingreso")
                blnValue = False
                Me.cbbMovMotivo.Focus()
                Return blnValue
            End If
            'If Me._MovimientoMotivo = 3 And Me._MovimientoMotivoTraslado = -1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Motivo de Traslado")
            '    blnValue = False
            '    Me.cbbMovMotivoTraslado.Focus()
            '    Return blnValue
            'End If
            'If Me._FechaMovimiento < 1 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha del Movimiento")
            '    blnValue = False
            '    Me.dtpFechaMov.Focus()
            '    Return blnValue
            'Else
            '    Dim entMovCol As New Entity.Registro.InternoMovimientoCol
            '    Dim entMov As New Entity.Registro.InternoMovimiento
            '    entMov.InternoID = Me._InternoID
            '    entMov.IngresoInpeId = Me._IngresoInpeID
            '    entMov.IngresoID = Me._IngresoID
            '    objBss = New Bussines.Registro.InternoMovimiento
            '    Select Case Me._TipoLicencia
            '        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
            '            entMovCol = objBss.ListarGrilla_LM(entMov)
            '        Case Else
            '            entMovCol = objBss.ListarGrilla(entMov)
            '    End Select
            '    If Me._Codigo < 1 And entMovCol.Count > 0 Then
            '        If entMovCol.InternoMovimiento(0).Fecha > Me._FechaMovimiento Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Existe un ingreso anterior con fecha superior")
            '            blnValue = False
            '            Me.dtpFechaMov.Focus()
            '            Return blnValue
            '        End If
            '    End If
            'End If
            'If Me._MovimientoMotivo = 3 Then
            '    If Me.RegionIngreso < 1 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar region de origen")
            '        blnValue = False
            '        Me.cbbRegionIngreso.Focus()
            '    ElseIf Me.PenalIngreso < 1 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Penal de origen")
            '        blnValue = False
            '        Me.cbbPenalIngreso.Focus()
            '    ElseIf Me._PenalID = Me.PenalIngreso Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("El penal de origen no puede ser igual a la del destino.")
            '        blnValue = False
            '        Me.cbbPenalIngreso.Focus()
            '    End If
            'End If
            'Select Case Me._MovimientoMotivo
            '    Case 178, 179
            '        If Me.EstablecimientomentalId < 1 Then
            '            Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccionar establecimiento de salud mental.")
            '            Me.btnListaEstablecimientosmentales.Focus()
            '            Return False
            '        End If
            'End Select
            Return blnValue
        End Function

        Public Function AGrabar(Codigo As Integer, EntDocJud As Entity.Registro.DocumentoJudicial) As Integer
            objEnt = New Entity.Registro.InternoMovimiento
            objBss = New Bussines.Registro.InternoMovimiento
            With objEnt
                '.FlagTransferenciaSede = Me.FlagTransferSede
                .Codigo = Me._Codigo
                .InternoID = Me._InternoID
                .IngresoInpeId = Me._IngresoInpeID
                .IngresoID = Me._IngresoID
                .DocumJudicialID = Codigo    'debe volver de documento judicial
                .DocumJudicialNum = EntDocJud.DocumentoNumero
                If EntDocJud.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso Then
                    .DocumJudicialFecharecepcion = EntDocJud.DocumentoFechaRecepcion
                    .DocumJudicialFecha = EntDocJud.DocumentoFecha
                    .TipoAutoridadJudicialID = EntDocJud.TipoAutoridadJudicial
                    .AutoridadJudicialID = EntDocJud.DistritoJudicial
                    .SalaJudicialID = EntDocJud.SalaJuzgado
                    .DocJudJuez = EntDocJud.JuezNombre
                    .DocJudSecretario = EntDocJud.SecretarioNombre
                    .DocJudObservacion = EntDocJud.Observacion
                End If
                If .MovimientoTipoID = Type.Enumeracion.Movimiento.EnumMovTipo.Fallecimiento Then
                    .DocumJudicialFecharecepcion = EntDocJud.DocumentoFechaRecepcion
                    .DocumJudicialFecha = EntDocJud.DocumentoFecha
                    .TipoAutoridadJudicialID = EntDocJud.TipoAutoridadJudicial
                    .AutoridadJudicialID = EntDocJud.DistritoJudicial
                    .SalaJudicialID = EntDocJud.SalaJuzgado
                    .DocJudJuez = EntDocJud.JuezNombre
                    .DocJudSecretario = EntDocJud.SecretarioNombre
                    .DocJudObservacion = EntDocJud.Observacion
                End If
                '''''''''''''''''''''''
                .MovimientoGrupoID = Me._MovimientoGrupo
                .MovimientoMotivoID = Me._MovimientoMotivo
                .Fecha = Me.FechaRegistroMovimiento
                If Me._MovimientoGrupo = EnumMovGrupo.Ingreso Then
                    If EntDocJud.DocumentoTipo = EnumRegDocTipo.Internamiento Then
                        .MovimientoTipoID = EnumMovTipo.Internamiento
                        .RegionDestinoID = Me._RegionID
                        .PenalDestinoID = Me._PenalID
                    End If
                    If .MovimientoMotivoID = Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado Then
                        .MovimientoSubMotivoID = Me._MovimientoMotivo
                        .MovimientoMotivoID = Me._MovimientoMotivoTraslado
                        .RegionOrigenID = Me._RegionIngreso
                        .PenalOrigenID = Me._PenalIngreso
                    End If
                ElseIf Me._MovimientoGrupo = EnumMovGrupo.Egreso Then
                    .MovimientoTipoID = EnumMovTipo.Libertad
                    .PenalOrigenID = Me._PenalID
                    '.DestinoNombre = Me.cbbMovMotivo.Text
                End If
                Select Case Me._MovimientoTipo2
                    Case EnumMovTipo.Internamiento, EnumMovTipo.Conducciones
                        .EstadoID = Type.Enumeracion.Movimiento.EnumEstadoTramite.Terminado
                    Case Else
                        .EstadoID = EntDocJud.Estado
                End Select
                .Observacion = EntDocJud.Observacion
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.InternoMovimiento

            If Me._blnNuevo = True Then Me._Codigo = -1

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then

                If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then EntDocJud.FlagTransferenciaSede = 1
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar(objEnt)
            End If

            Return value
        End Function

#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Me.txtMovimiento.Text = "INTERNAMIENTO"

            ComboMovimientoMotivo()
            ComboMovimientoMotivoTraslado()
            CargarComboRegion()
            CargarComboPenal()
            nudHora._Value = "00"
            nudMinutos._Value = "00"
            If Me._DocumJudicialD > 0 And Me._Codigo > 0 Then
                ControlesReadOnly()
            End If
        End Sub

        Public Sub _LoadUsc()

            ValoresxDefault()

        End Sub
        Public Sub ControlesReadOnly()

            cbbMovMotivoTraslado.Enabled = True
            cbbRegionIngreso.Enabled = True
            cbbPenalIngreso.Enabled = True
            Listar()
        End Sub
        Public Sub OcultarControlesporReferencia()
            If cbbMovMotivo.SelectedValue > 0 Then
                cbbMovMotivo.Enabled = False
            End If
            dtpFechaMov.Enabled = False
            nudHora.Enabled = False
            nudMinutos.Enabled = False
        End Sub
        Public Sub CbbMovimientoMotivoFocus()
            Me.cbbMovMotivo.Focus()
        End Sub
#End Region



        Private Function formato1(num As String) As String
            If Len(num) = 0 Then
                num = "00"
            ElseIf Len(num) = 1 Then
                num = "0" & num
            End If
            Return num
        End Function
        Private Minutos As String = ""
        Private Hora As String = ""

        Private Sub txtMinutos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
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
        Public intComboMotivo As Integer = 0
        Private Sub cbbMovMotivo__SelectedIndexChanged() Handles cbbMovMotivo._SelectedIndexChanged

            Select Case cbbMovMotivo.SelectedValue
                Case Type.Enumeracion.Movimiento.EnumMovMotivo.NuevoIngreso,
                     Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReincidencia,
                     Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoReiterante
                    If intContador > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("El motivo de ingreso seleccionado no esta vigente, operación cancelada.")
                        cbbMovMotivo.SelectedValue = -1
                        Exit Sub
                    End If
                Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoPrisionPreventiva
                    RaiseEvent clicK_MostrarControlesAux(cbbMovMotivo.SelectedValue, True, False)
                    gbRegionPenal.Visible = False
                    lblMovTraslado.Visible = False
                    cbbMovMotivoTraslado.Visible = False

                Case Type.Enumeracion.Movimiento.EnumMovMotivo.IngresoTraslado
                    RaiseEvent clicK_MostrarControlesAux(cbbMovMotivo.SelectedValue, False, True)
                    gbRegionPenal.Visible = True
                    lblMovTraslado.Text = "Motivo de Traslado:"
                    lblMovTraslado.Visible = True
                    cbbMovMotivoTraslado.Visible = True

                Case Type.Enumeracion.Movimiento.EnumMovMotivo.Inimputable
                    RaiseEvent clicK_MostrarControlesAux(cbbMovMotivo.SelectedValue, False, True)
                    gbRegionPenal.Visible = False
                    cbbMovMotivoTraslado.Visible = False
                    lblMovTraslado.Visible = False

                Case Type.Enumeracion.Movimiento.EnumMovMotivo.PosibleInimputable
                    RaiseEvent clicK_MostrarControlesAux(cbbMovMotivo.SelectedValue, False, True)
                    gbRegionPenal.Visible = False
                    cbbMovMotivoTraslado.Visible = False
                    lblMovTraslado.Visible = False

                Case Else
                    gbRegionPenal.Visible = False
                    lblMovTraslado.Visible = False
                    cbbMovMotivoTraslado.Visible = False

                    RaiseEvent clicK_MostrarControlesAux(cbbMovMotivo.SelectedValue, False, False)

            End Select
            intComboMotivo = cbbMovMotivo.SelectedValue
        End Sub



        Private Sub cbbRegionIngreso__SelectedIndexChanged() Handles cbbRegionIngreso._SelectedIndexChanged
            CargarComboPenal()
        End Sub


        Private Sub uscMovimientoDetalle2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            nudHora._Maximum = 23
            nudHora._Minimum = 0
            nudHora._Formato = "00"

            nudMinutos._Maximum = 59
            nudMinutos._Minimum = 0
            nudMinutos._Formato = "00"
            'nudHora.Value = Format(2, "0")
            nudHora._Value = "00"
            nudMinutos._Value = "00"

        End Sub

        Private Sub dtpFechaMov__ValueChanged() Handles dtpFechaMov._ValueChanged
            With dtpFechaMov
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaMov_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaMov.Validated
            With dtpFechaMov
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub nudHora_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles nudHora.KeyDown
            If e.KeyCode = Keys.Enter Then
                nudMinutos.Focus()
            End If
        End Sub

        Private Sub nudHora_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nudHora.KeyPress
            MyBase.OnKeyPress(e)
            'Dim c As Char = e.KeyChar
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub nudHora_Validated(sender As Object, e As System.EventArgs) Handles nudHora.Validated
            nudMinutos.Focus()
        End Sub
        Private Sub txtMovimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMovimiento.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub cbbMovMotivo_Load(sender As Object, e As EventArgs) Handles cbbMovMotivo.Load

        End Sub
    End Class

End Namespace
