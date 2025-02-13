Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class uscResolTraslado
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
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
#Region "Eventos"
        Public Event _Click_VerFormulario()
        Public Event _Click_FrmBusquedaAutoridadJudicial()
#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _blnNuevo() As Boolean = False

#End Region
#Region "Propiedades"
        Private Property DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Traslado
        Private Property DocumentoNumero() As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(value As String)
                txtNumDocumento.Text = value
            End Set
        End Property
        Private Property DocumentoNumeroTraslado() As String
            Get
                Return txtNroDocumento2.Text
            End Get
            Set(value As String)
                txtNroDocumento2.Text = value
            End Set
        End Property
        Private Property DocumentoFechaRecepcion() As Long
            Get
                Return dtpDocJudFecRecep.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Private Property DocumentoFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property
        Private Property TipoAutoridadJudicial() As Integer
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoAutJud.SelectedValue = value
            End Set
        End Property
        Public Property DistritoJudicial() As Integer
            Get
                Return UscComboDistritoJudicial1._selectedValue
            End Get
            Set(value As Integer)
                UscComboDistritoJudicial1._selectedValue = value
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
        Private Property JuezNombre() As String
            Get
                Return txtJuez.Text
            End Get
            Set(value As String)
                txtJuez.Text = value
            End Set
        End Property
        Private Property SecretarioNombre() As String
            Get
                Return txtSecretario.Text
            End Get
            Set(value As String)
                txtSecretario.Text = value
            End Set
        End Property
        Private Property AutoridadOtroNombre() As String
            Get
                Return txtOtraAutoridadNombre.Text
            End Get
            Set(value As String)
                txtOtraAutoridadNombre.Text = value
            End Set
        End Property
        Private Property AutoridadOtroCargo() As String
            Get
                Return txtOtraAutoridadCargo.Text
            End Get
            Set(value As String)
                txtOtraAutoridadCargo.Text = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return txtObsLib.Text
            End Get
            Set(value As String)
                txtObsLib.Text = value
            End Set
        End Property
        Private Property NumLibro As String
            Get
                Return txtLibro.Text
            End Get
            Set(value As String)
                txtLibro.Text = value
            End Set
        End Property
        Private Property NumFolio As String
            Get
                Return txtFolio.Text
            End Get
            Set(value As String)
                txtFolio.Text = value
            End Set
        End Property

        Private Property RegionOrigenId() As Integer
            Get
                Return cbbRegionOrigen.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegionOrigen.SelectedValue = value
            End Set
        End Property
        Private Property PenalOrigenId As Integer
            Get
                Return cbbPenalOrigen.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenalOrigen.SelectedValue = value
            End Set
        End Property
        Private Property RegionDestinoId() As Integer
            Get
                Return cbbRegionDest.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegionDest.SelectedValue = value
            End Set
        End Property
        Private Property PenalDestinoid As Integer
            Get
                Return cbbPenalDest.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenalDest.SelectedValue = value
            End Set
        End Property
        Private Property PenalOtroOrigenNom As String
            Get
                Return txtOtroLugarOrigen.Text
            End Get
            Set(value As String)
                txtOtroLugarOrigen.Text = value
            End Set
        End Property
        Private Property PenalDestinoOtroNom As String
            Get
                Return txtOtroLugarDest.Text
            End Get
            Set(value As String)
                txtOtroLugarDest.Text = value
            End Set
        End Property
        Private Property FechaMovimiento As Long
            Get
                Return dtpFechMov.ValueLong
            End Get
            Set(value As Long)
                dtpFechMov.ValueLong = value
            End Set
        End Property
        Private Property EstadoTramite As Integer = -1
        Private Property MotivoTrasladoId() As Integer
            Get
                Return Me.cbbMotivoTraslado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbMotivoTraslado.SelectedValue = value
            End Set
        End Property
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
#End Region
#Region "Combo"
        Private Sub ComboDistritoJudicial()

            With Me.UscComboDistritoJudicial1
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
                ._Combo()
                ._selectedValue = -1
            End With

            'Me.UscComboDistritoJudicial1._Combo()
            'If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
            '    Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
            '    Me.UscComboDistritoJudicial1._selectedValue = 2 'Region lima
            'End If

        End Sub
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
        End Sub

        Private Sub ComboMotivoTraslado()
            cbbMotivoTraslado.CodigoPadre = 2
            cbbMotivoTraslado.LoadUsc()
        End Sub

        Private Sub CargarComboRegionOrigen()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select
            With Me.cbbRegionOrigen
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboRegionDestino()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select
            With Me.cbbRegionDest
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Region
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboPenalOrigen()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select
            With Me.cbbPenalOrigen
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.RegionOrigenId
                .LoadUsc()
            End With
        End Sub
        Private Sub CargarComboPenalDestino()
            Dim blnTodos As Boolean = False
            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select
            With Me.cbbPenalDest
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.RegionDestinoId
                .LoadUsc()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()
            If Me._Codigo < 1 Then
                Exit Sub
            End If
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._Codigo
            objEnt = objBss.Listar_v2(objEnt)


            With objEnt
                Me._Codigo = .Codigo
                Me.DocumentoTipo = .DocumentoTipo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoNumeroTraslado = .DocumentoNumeroTraslado
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                Me.DistritoJudicial = .DistritoJudicial
                'lblEstadoResol.Text = "RESOLUCION " & .EstadoNombre


                If .DistritoJudicial < 1 And .SalaJuzgado < 1 And .JuezNombre = "" And .SecretarioNombre = "" Then
                    If .TipoAutoridadJudicial < 1 Then
                        Me.TipoAutoridadJudicial = 2
                    End If
                    Me.AutoridadOtroNombre = .AutoridadOtroNombre
                    Me.AutoridadOtroCargo = .AutoridadOtroCargo
                Else
                    Me.TipoAutoridadJudicial = 1
                    Me.SalaJuzgado = .SalaJuzgado
                    Me.JuezNombre = .JuezNombre
                    Me.SecretarioNombre = .SecretarioNombre
                End If
                'If .TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial Then
                '    Me.SalaJuzgado = .SalaJuzgado
                'Else
                '    Me.DistritoJudicial = -1
                '    Me.SalaJuzgado = -1
                'End If
                'Me.JuezNombre = .JuezNombre
                'Me.SecretarioNombre = .SecretarioNombre

                Me.Observacion = .Observacion
                'Me.SituacionJuridicaId = .SituacionJuridicaId
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me.FechaMovimiento = .FechaMovimiento
                Me.MotivoTrasladoId = .MovimientoMotivoId

                If .RegionOrigenId > 0 Then
                    Me.RegionOrigenId = .RegionOrigenId
                    Me.PenalOrigenId = .PenalOrigenId
                    Me.PenalOtroOrigenNom = ""
                    rdbPenalOrigen.Checked = True
                    cbbRegionOrigen.Visible = True
                    lblPenal.Visible = True
                    cbbPenalOrigen.Visible = True
                    txtOtroLugarOrigen.Visible = False
                    lblRegion.Text = "Región:"
                Else
                    Me.PenalOrigenId = -1
                    Me.RegionOrigenId = -1
                    Me.PenalOtroOrigenNom = .PenalOtroOrigenNom
                    rdbOtroLugarOrigen.Checked = True

                    cbbRegionOrigen.Visible = False
                    lblPenal.Visible = False
                    cbbPenalOrigen.Visible = False
                    txtOtroLugarOrigen.Visible = True
                    lblRegion.Text = "Lugar Origen:"
                End If

                If .PenalDestinoid > 0 Then
                    Me.RegionDestinoId = .RegionDestinoId
                    Me.PenalDestinoid = .PenalDestinoid
                    Me.PenalDestinoOtroNom = ""
                    rdbPenalDest.Checked = True

                    cbbRegionDest.Visible = True
                    lblPenalDestino.Visible = True
                    cbbPenalDest.Visible = True
                    txtOtroLugarDest.Visible = False
                    lblRegionDestino.Text = "Región:"
                Else
                    Me.RegionDestinoId = -1
                    Me.PenalDestinoid = -1
                    Me.PenalDestinoOtroNom = .PenalDestinoOtroNom
                    rdbPenalDest.Checked = False
                    rdbOtroLugarDest.Checked = True

                    cbbRegionDest.Visible = False
                    lblPenalDestino.Visible = False
                    cbbPenalDest.Visible = False
                    txtOtroLugarDest.Visible = True
                    lblRegionDestino.Text = "Lugar Origen:"
                End If
                Me.EstadoTramite = .Estado
            End With
        End Sub
#End Region
#Region "accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False
            ''par-region/penal
            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro [Region], no fueron enviados al Objeto")
                Return blnValue
            End If
            If Not (Me._TipoLicencia = enmTipoLicencia.Carceleta Or _
                Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or _
                Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) Then
                If Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro [Penal], no fueron enviados al Objeto")
                    Return blnValue
                End If
                If Me._InternoIngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro Código del interno no fueron enviados al Objeto")
                    Return blnValue
                End If
            End If
            If Me.MotivoTrasladoId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el motivo de traslado")
                cbbMotivoTraslado.Focus()
                Return blnValue
            End If

            If Me.DocumentoNumero.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Número del documento Judicial")
                blnValue = False
                Me.txtNumDocumento.Focus()
                Return blnValue
            End If
            '/*fecha de documento*/
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha del documento Judicial")
                blnValue = False
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            '/*fecha recepcion del documento*/
            If Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            If Me.FechaMovimiento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe especificar la fecha de libertad")
                dtpFechMov.Focus()
                Return blnValue
            End If
            If Me.TipoAutoridadJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la autoridad quien autoriza")
                Return blnValue
            End If
            If Me.TipoAutoridadJudicial = 1 Then
                If Me.DistritoJudicial < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito judicial")
                    blnValue = False
                    Me.UscComboDistritoJudicial1.Focus()
                    Return blnValue
                End If
                If Me.SalaJuzgado < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el sala judicial")
                    blnValue = False
                    Me.UscComboSala1.Focus()
                    Return blnValue
                End If
                If Len(Me.SecretarioNombre) < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                    Me.txtSecretario.Focus()
                    Return blnValue
                End If
            Else
                If Me.AutoridadOtroNombre.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre de la autoridad")
                    blnValue = False
                    Me.txtOtraAutoridadNombre.Focus()
                    Return blnValue
                End If
                If Me.AutoridadOtroCargo.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el cargo de la autoridad")
                    blnValue = False
                    Me.txtOtraAutoridadCargo.Focus()
                    Return blnValue
                End If
            End If
            '**************************************
            '/*validar libertad*/
            If rdbPenalOrigen.Checked = True Then
                If Me.RegionOrigenId < 1 Or Me.PenalOrigenId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la región y penal de origen")
                    cbbRegionOrigen.Focus()
                    Return blnValue
                End If

            Else
                If Me.PenalOtroOrigenNom = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la descripción del lugar origen")
                    txtOtroLugarOrigen.Focus()
                    Return blnValue
                End If
            End If
            'validar penal origen
            If rdbPenalDest.Checked = True Then
                If RegionDestinoId < 1 Or PenalDestinoid < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la región y penal de destino")
                    cbbRegionDest.Focus()
                    Return blnValue
                End If
            Else
                If Me.PenalDestinoOtroNom = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la descripción del destino")
                    txtOtroLugarDest.Focus()
                    Return blnValue
                End If
            End If
            If rdbPenalOrigen.Checked = True And rdbPenalDest.Checked = True Then
                If Me.PenalOrigenId = Me.PenalDestinoid Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El penal de origen y destino no pueden ser iguales")
                    cbbPenalOrigen.Focus()
                    Return blnValue
                End If
            ElseIf (rdbOtroLugarOrigen.Checked = True And rdbOtroLugarDest.Checked = True) And _
                (txtOtroLugarOrigen.Text = txtOtroLugarDest.Text) Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El penal de origen y destino no pueden ser iguales")
                txtOtroLugarOrigen.Focus()
                Return blnValue
            End If
            '***********************************************
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.DocumentoNumero = Me.DocumentoNumero
            objEnt.DocumentoTipo = Me._DocumentoTipo
            objEnt.InternoIngresoId = Me._InternoIngresoId
            If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
                txtNumDocumento.Focus()
                Return blnValue
            End If
            Return True
        End Function

        Public Function AGrabar() As Integer

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoNumeroTraslado = Me.DocumentoNumeroTraslado
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .TipoAutoridadJudicial = Me.TipoAutoridadJudicial
                If Me.TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial Then
                    .DistritoJudicial = Me.DistritoJudicial
                    If Me.SalaJuzgado > 1 Then
                        .SalaJuzgado = Me.SalaJuzgado
                    Else
                        .SalaJuzgado = -1
                    End If
                Else
                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                End If
                .JuezNombre = Me.JuezNombre
                .SecretarioNombre = Me.SecretarioNombre
                .AutoridadOtroNombre = Me.AutoridadOtroNombre
                .AutoridadOtroCargo = Me.AutoridadOtroCargo
                .Observacion = Me.Observacion
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoId
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .FechaMovimiento = Me.FechaMovimiento
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .Estado = 1
                .MovimientoMotivoId = Me.MotivoTrasladoId
                If rdbPenalOrigen.Checked = True Then
                    .PenalOrigenId = Me.PenalOrigenId
                    .RegionOrigenId = Me.RegionOrigenId
                    .PenalOtroOrigenNom = ""
                Else
                    .PenalOrigenId = -1
                    .RegionOrigenId = -1
                    .PenalOtroOrigenNom = Me.PenalOtroOrigenNom
                End If
                If rdbPenalDest.Checked = True Then
                    .RegionDestinoId = Me.RegionDestinoId
                    .PenalDestinoid = Me.PenalDestinoid
                    .PenalDestinoOtroNom = ""
                Else
                    .RegionDestinoId = -1
                    .PenalDestinoid = -1
                    .PenalDestinoOtroNom = Me.PenalDestinoOtroNom
                End If
                .FlagTransferenciaSede = Me.FlagTransferSede
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or _
                Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar2(objEnt)
            End If
            Return value

        End Function
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ComboMotivoTraslado()
            ComboDistritoJudicial()
            ComboSalaJuzgado()
            ComboTipoAutoridadJudicial()

            CargarComboRegionOrigen()
            CargarComboPenalOrigen()
            CargarComboRegionDestino()
            CargarComboPenalDestino()

            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or _
                Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or _
                Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                cbbRegionOrigen.SelectedValue = -1
                cbbRegionDest.SelectedValue = -1
                'Me.lblNumeroDocumento2.Visible = False
                'Me.txtNroDocumento2.Visible = False
                If Me._Codigo < 0 Then
                    If Me._InternoIngresoInpeId < 1 Or Me._RegionID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdIngresoInpe,  IdRegión")
                    End If
                End If
            Else
                cbbRegionOrigen.SelectedValue = Me._RegionID
                cbbRegionDest.SelectedValue = Me._RegionID
                If _InternoIngresoId < 1 Or _RegionID < 1 Or _PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno, IdPenal e IdRegión")
                End If
            End If
            Listar()
            Me.cbbMotivoTraslado.Focus()
        End Sub

        Public Sub _LoadUsc()
            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.ListadoExpediente
                    InhabilitarControles()
            End Select
            Me._blnNuevo = If(Me._Codigo < 1, True, False)
            ValoresxDefault()
        End Sub
        Private Sub InhabilitarControles()
            txtNumDocumento.ReadOnly = True
            txtNroDocumento2.ReadOnly = True
            dtpDocJudFecha.Enabled = False
            dtpDocJudFecRecep.Enabled = False
            dtpFechMov.Enabled = False
            txtFolio.ReadOnly = True
            txtFolio.ReadOnly = True
            txtJuez.ReadOnly = True
            txtSecretario.ReadOnly = True

            'txtOtraAutoridadCargo.ReadOnly = True
            'txtOtraAutoridadNombre.ReadOnly = True
            txtObsLib.ReadOnly = True
            UscComboDistritoJudicial1.Enabled = False
            UscComboSala1.Enabled = False
        End Sub
#End Region

        Private Sub cbbRegionOrigen__SelectedIndexChanged() Handles cbbRegionOrigen._SelectedIndexChanged
            CargarComboPenalOrigen()
        End Sub

        Private Sub cbbRegionDest__SelectedIndexChanged() Handles cbbRegionDest._SelectedIndexChanged
            CargarComboPenalDestino()
        End Sub

        Private Sub rdbPenalOrigen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPenalOrigen.CheckedChanged
            cbbRegionOrigen.Visible = True
            lblPenal.Visible = True
            cbbPenalOrigen.Visible = True
            txtOtroLugarOrigen.Visible = False
            lblRegion.Text = "Región:"
        End Sub

        Private Sub rdbOtroLugarOrigen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbOtroLugarOrigen.CheckedChanged
            cbbRegionOrigen.Visible = False
            lblPenal.Visible = False
            cbbPenalOrigen.Visible = False
            txtOtroLugarOrigen.Visible = True
            lblRegion.Text = "Lugar Origen:"
        End Sub

        Private Sub rdbPenalDest_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbPenalDest.CheckedChanged
            cbbRegionDest.Visible = True
            lblPenalDestino.Visible = True
            cbbPenalDest.Visible = True
            txtOtroLugarDest.Visible = False
            lblRegionDestino.Text = "Región:"
        End Sub

        Private Sub rdbOtroLugarDest_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbOtroLugarDest.CheckedChanged
            cbbRegionDest.Visible = False
            lblPenalDestino.Visible = False
            cbbPenalDest.Visible = False
            txtOtroLugarDest.Visible = True
            lblRegionDestino.Text = "Lugar Origen:"
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            If cbbTipoAutJud.SelectedValue = EnumTipoAutoridad.AutoridadJudicial Then
                PnlAutoridadJudicial.Visible = True
                PnlOtraAutoridad.Visible = False
                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
            Else
                PnlAutoridadJudicial.Visible = False
                PnlOtraAutoridad.Visible = True
                Me.DistritoJudicial = -1
                Me.SalaJuzgado = -1
            End If
           
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged()
            If Me.DistritoJudicial > 0 Then
                ComboSalaJuzgado()
            End If
        End Sub

        Private Sub uscResolTraslado_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            Me.cbbMotivoTraslado.Focus()
            txtOtraAutoridadNombre.CharacterCasing = CharacterCasing.Upper
            txtOtraAutoridadCargo.CharacterCasing = CharacterCasing.Upper
            PnlAutoridadJudicial.Visible = True
            PnlOtraAutoridad.Visible = False
        End Sub


        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub dtpFechMov_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechMov.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
                txtNumDocumento.Focus()
            End If
        End Sub

        Private Sub cbbMotivoTraslado__SelectedIndexChanged() Handles cbbMotivoTraslado._SelectedIndexChanged

        End Sub

        Private Sub cbbMotivoTraslado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbbMotivoTraslado.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                txtNumDocumento.Focus()
            End If
        End Sub

        Private Sub rdbPenalOrigen_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbPenalOrigen.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub rdbPenalDest_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rdbPenalDest.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            RaiseEvent _Click_VerFormulario()
        End Sub

        Private Sub dtpDocJudFecha__ValueChanged() Handles dtpDocJudFecha._ValueChanged
            With dtpDocJudFecha
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpDocJudFecha_Validated(sender As Object, e As System.EventArgs) Handles dtpDocJudFecha.Validated
            With dtpDocJudFecha
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpDocJudFecRecep__ValueChanged() Handles dtpDocJudFecRecep._ValueChanged
            With dtpDocJudFecRecep
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpDocJudFecRecep_Validated(sender As Object, e As System.EventArgs) Handles dtpDocJudFecRecep.Validated
            With dtpDocJudFecRecep
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub
        Private Sub UscComboDistritoJudicial1__Click_Buscar() Handles UscComboDistritoJudicial1._Click_Buscar
            RaiseEvent _Click_FrmBusquedaAutoridadJudicial()
        End Sub

        Private Sub UscComboDistritoJudicial1__SelectedIndexChanged() Handles UscComboDistritoJudicial1._SelectedIndexChanged
            If Me.DistritoJudicial > 0 Then
                ComboSalaJuzgado()
            End If
        End Sub

    End Class
End Namespace

