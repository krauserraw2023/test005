Imports Type.Enumeracion.Movimiento
Namespace Registro.Movimiento.v5
    Public Class uscDocumJudicial
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEntDoc As Entity.Registro.DocumentoJudicial = Nothing
        Private objBssMov As Bussines.Registro.InternoMovimiento = Nothing
        Private objEntMov As Entity.Registro.InternoMovimiento
#Region "Eventos"
        Public Event _Click_btnCargar()
        Public Event _Click_btnCargarDocumento()
        Public Event _ClicK_VerFormulario()
#End Region
#Region "Propiedades_Parametricas"

        Public Property _Codigo() As Long = -1

        Public Property _MovID() As Integer = -1
        Public Property _TipoDocumentoJud() As Integer = -1

        Public Property _RegionID() As Integer = -1

        Public Property _PenalID() As Integer = -1

        Public Property _blnNuevo() As Boolean = False

        Public Property _blnBotonCargar() As Boolean = False
        Public Property _blnControles() As Boolean = False
        Private intHabilitarControles As Integer = -1

        Public Property _blnVisibleLblObservacionDoc() As Boolean
            Get
                Return lblObs.Visible
            End Get
            Set(value As Boolean)
                lblObs.Visible = value
            End Set
        End Property
        Public Property _blnVisibleTxtObservacion() As Boolean
            Get
                Return txtObsLib.Visible
            End Get
            Set(value As Boolean)
                txtObsLib.Visible = value
            End Set
        End Property
        Private blnVisibleRadioButon As Boolean = False
        Public Property _Licencia As Integer = -1

        Public Property _ExpedienteID As Integer = -1
        Public Property _InternoIngresoID As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _GrupoID As Integer = -1
        Public Property _MovimientoTipoID As Integer = -1
        Public Property _MovimientoMotivoID As Integer = -1

        Public Property _DocumentoJudicialID As Integer = -1
        Public Property _TipoCarga() As String = ""
        Public Property _TipoFormMov() As Integer = -1
        Private btnCargarDocumentoJudicial As Boolean = False

        Private btnVisibleObservacion As Boolean = False
        Public Property _VisibleObservacion() As Boolean
            Get
                Return btnVisibleObservacion
            End Get
            Set(value As Boolean)
                btnVisibleObservacion = value
                If _VisibleObservacion = False Then
                    lblObs.Visible = False
                    txtObsLib.Visible = False
                End If
            End Set
        End Property
        Private Property DistritoJudicial() As Integer
            Get
                Return cbbDistritoJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbDistritoJud.SelectedValue = value
            End Set
        End Property
        Private Property SalaJuzgadoID() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
#End Region
#Region "Propiedades"
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
        Public Property _Observacion() As String
            Get
                Return Me.txtObsLib.Text
            End Get
            Set(ByVal value As String)
                Me.txtObsLib.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_UserControl"

        Public Property _blnSoloLecturaNumDoc() As Boolean
            Get
                Return Me.txtNumDocumento.ReadOnly
            End Get
            Set(ByVal value As Boolean)
                Me.txtNumDocumento.ReadOnly = value
            End Set
        End Property
        Private Property _blnVisibleCargar As Boolean = False
        Public Property _VisibleCargar() As Boolean
            Get
                Return _blnVisibleCargar
            End Get
            Set(ByVal value As Boolean)
                _blnVisibleCargar = value
                'If _VisibleCargar = True Then
                '    btnCargarDocumento.Visible = True
                'End If
            End Set
        End Property

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
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()
            If Me._MovimientoTipoID = EnumMovTipo.Traslado Then

            End If
            'If Me._DocumentoJudicialID < 1 Then
            If Me._MovID < 1 Then Exit Sub
            objEntMov = New Entity.Registro.InternoMovimiento
            objBssMov = New Bussines.Registro.InternoMovimiento
            Dim EntMov As New Entity.Registro.InternoMovimiento
            With EntMov
                .Codigo = Me._MovID
                '.InternoID = Me._InternoID
                '.IngresoID = Me._InternoIngresoID
                '.MovimientoTipoID = Me._MovimientoTipoID
            End With
            objEntMov = objBssMov.Listar(EntMov)
            If objEntMov Is Nothing Then
                Exit Sub
            Else
                With objEntMov
                    Me._Codigo = .Codigo
                    Me._TipoDocumentoJud = -1
                    Me.DocumentoNumero = .DocumJudicialNum
                    Me.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                    Me.DocumentoFecha = .DocumJudicialFecha
                    Me.TipoAutoridadJudicial = .TipoAutoridadJudicialID
                    Me.DistritoJudicialID = .AutoridadJudicialID
                    Me.SalaJuzgadoID = .SalaJudicialID
                    If .AutoridadJudicialID > 0 Then
                        .TipoAutoridadJudicialID = EnumTipoAutoridad.AutoridadJudicial
                        Me._Juez = .DocJudJuez
                        Me._Secretario = .DocJudSecretario
                    Else
                        If .TipoAutoridadJudicialID > 1 Then
                            Me.TipoAutoridadJudicial = .TipoAutoridadJudicialID
                        Else
                            Me.TipoAutoridadJudicial = 2
                        End If
                        Me.AutoridadOtroNombre = .DocJudJuez
                        Me.AutoridadOtroCargo = .DocJudSecretario
                    End If
                    Me._Observacion = .DocJudObservacion

                End With
            End If

            'End If
        End Sub
        Public Sub _Listar()
            objEntDoc = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEntDoc.Codigo = Me._DocumentoJudicialID
            objEntDoc.InternoId = Me._InternoID
            objEntDoc.InternoIngresoId = Me._InternoIngresoID
            If Me._Licencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                If Me._DocumentoJudicialID > 1 Then
                    objEntDoc.InternoIngresoId = -1
                    objEntDoc.IngresoInpeId = Me._InternoIngresoInpeId
                    objEntDoc = objBss.Listar_DocumentosClasificacion(objEntDoc).DocumentoJudicial(0)
                End If
            Else
                If Me._DocumentoJudicialID > 1 Then
                    objEntDoc = objBss.Listar_DocumentosJudiciales(objEntDoc).DocumentoJudicial(0)
                Else
                    If Me._MovID < 1 Then
                        Exit Sub
                    End If
                    objEntMov = New Entity.Registro.InternoMovimiento
                    objBssMov = New Bussines.Registro.InternoMovimiento
                    objEntMov.Codigo = Me._MovID
                    objEntMov = objBssMov.Listar(objEntMov)
                    If objEntMov.Codigo < 1 Then
                        Exit Sub
                    Else
                        With objEntMov
                            Me._Codigo = .Codigo
                            Me._TipoDocumentoJud = -1
                            objEntDoc.DocumentoNumero = .DocumJudicialNum
                            objEntDoc.DocumentoFechaRecepcion = .DocumJudicialFecharecepcion
                            objEntDoc.DocumentoFecha = .DocumJudicialFecha
                            objEntDoc.TipoAutoridadJudicial = .TipoAutoridadJudicialID
                            objEntDoc.DistritoJudicial = .AutoridadJudicialID
                            objEntDoc.SalaJuzgado = .SalaJudicialID
                            If objEntDoc.DistritoJudicial > 0 Then
                                objEntDoc.TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial
                                objEntDoc.JuezNombre = .DocJudJuez
                                objEntDoc.SecretarioNombre = .DocJudSecretario
                            Else
                                If .TipoAutoridadJudicialID > 1 Then
                                    objEntDoc.TipoAutoridadJudicial = .TipoAutoridadJudicialID
                                Else
                                    objEntDoc.TipoAutoridadJudicial = 2
                                End If
                                objEntDoc.AutoridadOtroNombre = .DocJudJuez
                                objEntDoc.AutoridadOtroCargo = .DocJudSecretario
                            End If
                            objEntDoc.Observacion = .Observacion
                        End With
                    End If
                End If
            End If
            'If objEntDoc.Codigo < 1 Then
            '    Exit Sub
            'Else
            With objEntDoc
                _Load()
                Me._Codigo = .Codigo
                Me._TipoDocumentoJud = -1
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                Me.Size = New Size(245, 60)
                If Me.TipoAutoridadJudicial = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                    PnlAutoridadJudicial.Visible = True
                    PnlOtraAutoridad.Visible = False
                Else
                    PnlAutoridadJudicial.Visible = False
                    PnlOtraAutoridad.Visible = True
                End If
                Me.DistritoJudicialID = .DistritoJudicial
                Me.SalaJuzgadoID = .SalaJuzgado
                If .DistritoJudicial > 0 Then
                    .TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial
                    Me._Juez = .JuezNombre
                    Me._Secretario = .SecretarioNombre
                Else
                    If .TipoAutoridadJudicial > 1 Then
                        Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                    Else
                        Me.TipoAutoridadJudicial = 2
                    End If
                    Me.AutoridadOtroNombre = .AutoridadOtroNombre
                    Me.AutoridadOtroCargo = .AutoridadOtroCargo
                End If
                Me._Observacion = .Observacion
            End With

        End Sub
        Public Sub CargarDocumentoJudicial()
            'JEU actualizando 21/20/2015
            If Me._DocumentoJudicialID < 1 Then
                Exit Sub
            End If

            Dim objBssDJ As New Bussines.Registro.DocumentoJudicial
            Dim objEntDJ As New Entity.Registro.DocumentoJudicial
            objEntDJ.Codigo = Me._DocumentoJudicialID
            objEntDJ = objBssDJ.Listar(objEntDJ)
            With objEntDJ
                Me.txtNumDocumento.Text = .DocumentoNumero.ToString
                Me.cbbTipoAutJud.SelectedValue = .TipoAutoridadJudicial
                If .TipoAutoridadJudicial = 1 Then
                    Me.cbbDistritoJud.SelectedValue = .DistritoJudicial
                    Me.UscComboSala1._SalaJuzgadoID_Seleccionado = .SalaJuzgado
                    Me.txtJuez.Text = .JuezNombre.ToString
                    Me.txtSecretario.Text = .SecretarioNombre.ToString
                Else
                    Me.txtOtraAutoridadNombre.Text = .AutoridadOtroNombre
                    Me.txtOtraAutoridadCargo.Text = .AutoridadOtroCargo
                End If
                Me.txtObsLib.Text = .Observacion.ToString
                Me.dtpDocJudFecRecep.Value = Legolas.Components.FechaHora.FechaDate(.DocumentoFechaRecepcion)
                Me.dtpDocJudFecha.Value = Legolas.Components.FechaHora.FechaDate(.DocumentoFecha)
            End With


        End Sub

#End Region
#Region "Accion"
        Public Function Validar() As Boolean

            Dim blnValue As Boolean = True
            ''par-region/penal
            If Me._RegionID < 1 Or Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Parametros [Region/Penal], no fueron enviados al Objeto")
                blnValue = False
            ElseIf Me.TipoAutoridadJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese Tipo de autoridad judicial")
                blnValue = False
                Me.cbbTipoAutJud.Focus()
            ElseIf Me.DocumentoNumero.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Ingrese el Numero del documento Judicial")
                blnValue = False
                Me.txtNumDocumento.Focus()
                '/*fecha recepcion del documento*/
            ElseIf Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                '/*fecha de documento*/
            ElseIf Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                blnValue = False
                Me.dtpDocJudFecha.Focus()
                '/*validar libertad*/
            ElseIf Me.TipoAutoridadJudicial = 1 Then
                'distrito judicial
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

            Return blnValue
        End Function
        Private Function AGrabar() As Integer

            objEntDoc = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEntDoc
                .Codigo = Me._Codigo
                .DocumentoTipo = Me._TipoDocumentoJud
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .TipoAutoridadJudicial = Me.TipoAutoridadJudicial

                If Me.TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial Then
                    .DistritoJudicial = Me.DistritoJudicialID
                    If Me.SalaJuzgadoID > 1 Then
                        .SalaJuzgado = Me.SalaJuzgadoID
                    Else
                        .SalaJuzgado = -1
                    End If
                    .JuezNombre = Me._Juez
                    .SecretarioNombre = Me._Secretario
                Else
                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                    .AutoridadOtroNombre = Me.AutoridadOtroNombre
                    .AutoridadOtroCargo = Me.AutoridadOtroCargo
                End If
                .Observacion = Me._Observacion
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .InternoIngresoId = Me._InternoIngresoID
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            value = objBss.Grabar(objEntDoc)

            Return value

        End Function
        Public Function GrabarDocumento() As Integer
            If Validar() = False Then
                Exit Function
            End If

            Dim value As Integer = -1
            value = AGrabar()

            Return value
        End Function

#End Region
#Region "Otros"

        Public Sub _Load()

            _CargarCombos()

        End Sub
        Public Sub _LoadUsc()

            _Listar()

        End Sub
        Public Sub _CargarControles()
            Me.txtNumDocumento.Enabled = False
            Me.txtJuez.ReadOnly = True
            Me.txtSecretario.ReadOnly = True
            Me.txtOtraAutoridadNombre.ReadOnly = True
            Me.txtOtraAutoridadCargo.ReadOnly = True
            Me.txtObsLib.ReadOnly = True
            Me.dtpDocJudFecRecep.Enabled = False
            Me.dtpDocJudFecha.Enabled = False
            Me.cbbTipoAutJud.Enabled = False
            Me.cbbDistritoJud.Enabled = False
            Me.UscComboSala1.Enabled = False

        End Sub

        Private Sub LimpiarControles()
            'If Me._HabilitarControles = 1 Then
            Me.txtNumDocumento.Text = ""
            Me.dtpDocJudFecRecep.Value = ""
            Me.dtpDocJudFecha.Value = ""
            Me.cbbTipoAutJud.SelectedValue = -1
            Me.cbbDistritoJud.SelectedValue = -1
            Me.UscComboSala1._SalaJuzgadoID = -1
            Me.txtJuez.Text = ""
            Me.txtSecretario.Text = ""
            Me.txtObsLib.Text = ""
            'ElseIf Me._HabilitarControles = 2 Then
            'If Me._blnControles = False Then
            Me._Codigo = -1
            Me.txtNumDocumento.Text = ""
            Me.dtpDocJudFecRecep.Value = ""
            Me.dtpDocJudFecha.Value = ""
            Me.cbbTipoAutJud.SelectedValue = -1
            Me.cbbDistritoJud.SelectedValue = -1
            Me.UscComboSala1._SalaJuzgadoID_Seleccionado = -1
            Me.txtJuez.Text = ""
            Me.txtSecretario.Text = ""
            Me.txtObsLib.Text = ""
            'End If
            Me.txtNumDocumento.ReadOnly = False
            Me.dtpDocJudFecRecep.Enabled = True
            Me.dtpDocJudFecha.Enabled = True
            Me.cbbTipoAutJud.Enabled = True
            Me.cbbDistritoJud.Enabled = True
            Me.UscComboSala1._SalaJuzgadoID = True
            Me.txtJuez.ReadOnly = False
            Me.txtSecretario.ReadOnly = False
            Me.txtObsLib.ReadOnly = False

        End Sub
        Private Sub Controles_ReadOnly(valor As Boolean)
            Me.txtNumDocumento.ReadOnly = Not (valor)
            Me.dtpDocJudFecRecep.Enabled = valor
            Me.dtpDocJudFecha.Enabled = valor
            Me.cbbTipoAutJud.Enabled = valor
            Me.cbbDistritoJud.Enabled = valor
            Me.UscComboSala1.Enabled = valor
            Me.txtJuez.ReadOnly = Not (valor)
            Me.txtSecretario.ReadOnly = Not (valor)
            Me.txtOtraAutoridadCargo.ReadOnly = Not (valor)
            Me.txtOtraAutoridadNombre.ReadOnly = Not (valor)
            Me.txtObsLib.ReadOnly = Not (valor)
        End Sub

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
            Me.txtObsLib.ReadOnly = True
            'Me.UscComboSala1._SalaJuzgadoID = -1

        End Sub

        Public Sub _CargarControlesNO()
            'Me.txtNumDocumento.ReadOnly = False
            Me.txtNumDocumento.Enabled = True
            Me.dtpDocJudFecRecep.Enabled = True
            Me.dtpDocJudFecha.Enabled = True
            Me.cbbTipoAutJud.Enabled = True
            Me.cbbDistritoJud.Enabled = True
            Me.UscComboSala1.Enabled = True
            Me.txtJuez.ReadOnly = False
            Me.txtSecretario.ReadOnly = False
            Me.txtOtraAutoridadNombre.ReadOnly = False
            Me.txtOtraAutoridadCargo.ReadOnly = False
            Me.txtObsLib.ReadOnly = False

            Me.txtNumDocumento.Text = ""
            Me.dtpDocJudFecRecep.Value = ""
            Me.dtpDocJudFecha.Value = ""
            Me.cbbTipoAutJud.SelectedValue = -1
            Me.cbbDistritoJud.SelectedValue = -1
            Me.UscComboSala1._SalaJuzgadoID = -1
            Me.txtJuez.Text = ""
            Me.txtSecretario.Text = ""
            Me.txtOtraAutoridadNombre.Text = ""
            Me.txtOtraAutoridadCargo.Text = ""
            Me.txtObsLib.Text = ""
            txtNumDocumento.Focus()
        End Sub
#End Region
#Region "Eventos Formulario"


        Private Sub AutJudicialOtro()
            Select Case Me.TipoAutoridadJudicial
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

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            If Me.DistritoJudicialID > 0 Then
                ComboSalaJuzgado()
            End If
        End Sub

        Private Sub btnCargarDocumento_Click(sender As System.Object, e As System.EventArgs)
            RaiseEvent _Click_btnCargarDocumento()
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            AutJudicialOtro()
        End Sub

        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            'ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub

        Public Sub _CargarCombos()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            PnlAutoridadJudicial.Visible = False
            PnlOtraAutoridad.Visible = True
            Me.Size = New Size(245, 60)
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            RaiseEvent _ClicK_VerFormulario()
        End Sub

        Private Sub cbbDistritoJud_Load(sender As System.Object, e As System.EventArgs) Handles cbbDistritoJud.Load

        End Sub

        Private Sub uscDocumJudicial_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            PnlOtraAutoridad.Visible = True
            PnlAutoridadJudicial.Visible = False
        End Sub

        Private Sub cbbTipoAutJud_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipoAutJud.Load

        End Sub

        Private Sub cbbTipoAutJud_MarginChanged(sender As Object, e As System.EventArgs) Handles cbbTipoAutJud.MarginChanged

        End Sub
    End Class

End Namespace
