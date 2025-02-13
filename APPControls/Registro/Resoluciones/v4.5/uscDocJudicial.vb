Imports Type.Enumeracion.Licencia

Namespace Registro.Documento
    Public Class uscDocJudicial
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
#Region "Propiedades_Par"
        Public Property _InternoID As Integer = -1
        Public Property _IngresoID As Integer = -1
        Public Property _IngresoInpeID As Integer = -1
        Public Property _RegionID As Short = -1
        Public Property _Penal As Short = -1

        'Public Property _PenalLM As Boolean = False
        Public Property TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
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
#Region "Propiedades_Publicas"
        Private intTipoDocumentoJudicial As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
        Public Property _TipoDocumentoJudicial() As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial
            Get
                Return intTipoDocumentoJudicial
            End Get
            Set(ByVal value As Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial)
                intTipoDocumentoJudicial = value
            End Set
        End Property
#End Region
#Region "Propiedades Varios"
        Private intDocumentoJudicialID As Integer = -1
        Public Property _DocumentoJudicialID() As Integer
            Get
                Return intDocumentoJudicialID
            End Get
            Set(ByVal value As Integer)
                intDocumentoJudicialID = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumero.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumero.Text = value
            End Set
        End Property
        Private Property FechaRecepcion() As Long
            Get
                Return Me.dtpFechaRecep.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaRecep.ValueLong = value
            End Set
        End Property
        Private Property FechaDocumento() As Long
            Get
                Return Me.dtpFechaDoc.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaDoc.ValueLong = value
            End Set
        End Property
        Public Property TipoAutJudicial() As Integer
            Get
                Dim intValue As Integer = -1

                If Me.rdbAutJudicial.Checked = True Then
                    intValue = 1
                End If

                If Me.rdbOtros.Checked = True Then
                    intValue = 2
                End If

                Return intValue
            End Get
            Set(ByVal value As Integer)
                Select Case value

                    Case 1
                        Me.rdbAutJudicial.Checked = True
                    Case 2
                        Me.rdbOtros.Checked = True
                    Case Else
                        Me.rdbAutJudicial.Checked = False
                        Me.rdbOtros.Checked = False
                End Select
            End Set
        End Property
        Private Property DistritoJudicial() As Integer
            Get
                Try
                    Return Me.cbbAutJudicial.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbAutJudicial.SelectedValue = value
            End Set
        End Property
        Private Property SalaJuzgadoID() As Integer
            Get
                Try
                    Return Me.cbbSalaJudicial.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.cbbSalaJudicial.SelectedValue = value
            End Set
        End Property
        Private Property Juez() As String
            Get
                Return Me.txtJuez.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtJuez.Text = value
            End Set
        End Property
        Private Property Secretario() As String
            Get
                Return Me.txtSecretario.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtSecretario.Text = value
            End Set
        End Property
        Private Property AutoridadOtro() As String
            Get
                Return Me.txtNombreAut.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombreAut.Text = value
            End Set
        End Property
        Private Property AutoridadCargoOtro() As String
            Get
                Return Me.txtCargoAut.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCargoAut.Text = value
            End Set
        End Property
        Private Property Obs() As String
            Get
                Return Me.txtObservacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        Public _Version As Boolean = False
#End Region
#Region "Combo"
        Private Sub ComboDistritoJudicial()
            cbbAutJudicial.LoadUsc()
        End Sub
        Private Sub ComboSalaJudicial()
            cbbSalaJudicial.CodigoPadre = Me.DistritoJudicial
            cbbSalaJudicial.LoadUsc()
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._DocumentoJudicialID < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._DocumentoJudicialID
            objEnt = objBss.Listar(objEnt)

            With objEnt
                Me._DocumentoJudicialID = .Codigo
                Me.NumeroDocumento = .DocumentoNumero
                Me.FechaRecepcion = .DocumentoFechaRecepcion
                Me.FechaDocumento = .DocumentoFecha
                Me.TipoAutJudicial = .TipoAutoridadJudicial
                If .TipoAutoridadJudicial = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                    Me.DistritoJudicial = .DistritoJudicial
                    Me.SalaJuzgadoID = .SalaJuzgado
                    Me.Juez = .JuezNombre
                    Me.Secretario = .SecretarioNombre
                    Me.AutoridadOtro = ""
                    Me.AutoridadCargoOtro = ""
                ElseIf .TipoAutoridadJudicial = Type.Enumeracion.Movimiento.EnumTipoAutoridad.OtraAutoridad Then
                    Me.DistritoJudicial = -1
                    Me.SalaJuzgadoID = -1
                    Me.Juez = ""
                    Me.Secretario = ""
                    Me.AutoridadOtro = .AutoridadOtroNombre
                    Me.AutoridadCargoOtro = .AutoridadOtroCargo
                End If


                Me.Obs = .Observacion
                Me._RegionID = ._RegionID
                Me._Penal = ._PenalID
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            ''par-region/penal
            If Me._RegionID < 1 Or Me._Penal < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Parametros [Region/Penal], no fueron enviados al Objeto")
                Return value
            End If

            'par-tipo documento
            If Me._TipoDocumentoJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Parametros [Tipo Documento], no fueron enviados al Objeto")
                Return value
            End If

            'autoridad judicial
            Select Case Me.TipoAutJudicial
                Case 1 'distrito y sala

                    'distrito judicial
                    If Me.DistritoJudicial < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Seleccione distrito judicial")
                        Me.cbbAutJudicial.Focus()
                        Return value
                    End If

                    'sala juzgado
                    If Me.SalaJuzgadoID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Seleccione sala juzgado")
                        Me.cbbSalaJudicial.Focus()
                        Return value
                    End If

                    'secretario
                    If Me.Secretario.Trim = "" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Tenga en cuenta que no ha especificando los datos del secretario")
                        Me.txtSecretario.Focus()
                    End If

                Case 2 'otros
                    'aut. jud. otros
                    If Me.AutoridadOtro.Trim = "" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese el nombre de la autoridad judicial")
                        Me.txtNombreAut.Focus()
                        Return value
                    End If
            End Select

            'validar numero documento
            If Me.NumeroDocumento.Trim = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el numero de documento")
                Me.txtNumero.Focus()
                Return value
            End If

            'fecha doc. recep.
            If Me.FechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No ha especificado la fecha de recepción del documento")
                Me.dtpFechaRecep.Focus()
                Return value
            End If

            'fecha doc
            If Me.FechaDocumento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha del documento")
                Me.dtpFechaDoc.Focus()
                Return value
            End If

            'validar anulacion
            Select Case Me._TipoDocumentoJudicial
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Rectificacion_Nombres  'rectificacion
                    If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar <> Windows.Forms.DialogResult.Yes Then
                        Return value
                    End If
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Nombres  'anular
                    If Legolas.Configuration.Aplication.MessageBox.Question("Esta seguro de anular los nombres asociados, seleccionados") <> Windows.Forms.DialogResult.Yes Then
                        Return value
                    End If
            End Select


            Return True

        End Function
        Public Function _GuardarDocJud() As Integer
            'entra para juardar doc NA v1
            If Validar() = False Then
                Return -1
            End If

            Dim value As Long = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial

            With objEnt
                .FlagTransferenciaSede = Me.FlagTransferSede
                .Codigo = Me._DocumentoJudicialID
                .DocumentoTipo = Me._TipoDocumentoJudicial
                .DocumentoNumero = Me.NumeroDocumento
                .DocumentoFechaRecepcion = Me.FechaRecepcion
                .DocumentoFecha = Me.FechaDocumento
                .TipoAutoridadJudicial = Me.TipoAutJudicial
                If rdbOtros.Checked = True Then
                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                    .JuezNombre = ""
                    .SecretarioNombre = ""
                    .AutoridadOtroNombre = Me.AutoridadOtro
                    .AutoridadOtroCargo = Me.AutoridadCargoOtro
                Else
                    .DistritoJudicial = Me.DistritoJudicial
                    .SalaJuzgado = Me.SalaJuzgadoID
                    .JuezNombre = Me.Juez
                    .SecretarioNombre = Me.Secretario
                    .AutoridadOtroNombre = ""
                    .AutoridadOtroCargo = ""
                End If

                .Observacion = Me.Obs
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._IngresoID
                .IngresoInpeId = Me._IngresoInpeID
                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                ._RegionID = Me._RegionID
                ._PenalID = Me._Penal
            End With

            If Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me.TipoLicencia = enmTipoLicencia.Carceleta Then
                objEnt.InternoIngresoId = -1
                value = objBss.Grabar_LM(objEnt)
            Else
                If Me._Version = False Then
                    value = objBss.Grabar(objEnt)
                Else
                    value = objBss.Grabar2(objEnt)
                End If
            End If

            Me._DocumentoJudicialID = value

            If value = -1 Then Legolas.Configuration.Aplication.MessageBox.Exclamation("El documento " & Me.NumeroDocumento & " ya existe, ingrese otro documento")

            Return Me._DocumentoJudicialID
        End Function
#End Region

#Region "Otros"
        Public Sub _LoadValorxDefault()
            ValoresxDefault()
        End Sub
        Private Sub ValoresxDefault()

            ComboDistritoJudicial()
            ComboSalaJudicial()

            Me.DistritoJudicial = -1
            Me.SalaJuzgadoID = -1

        End Sub
        Private Sub HAutJudicialOtro()
            Me.DistritoJudicial = -1
            Me.SalaJuzgadoID = -1
            Me.AutoridadOtro = ""
            Me.AutoridadCargoOtro = ""

            Select Case Me.TipoAutJudicial
                Case 1
                    Me.lblDistrito.Text = "Distrito Judicial :"
                    Me.lblSala.Text = "Autoridad Judicial : "
                    Me.cbbAutJudicial.Visible = True
                    cbbSalaJudicial.Visible = True
                    Me.pnlSalaJuzgado.Visible = True
                Case 2
                    Me.lblDistrito.Text = "Autoridad Nombre:"
                    Me.lblSala.Text = "Cargo : "
                    Me.cbbAutJudicial.Visible = False
                    cbbSalaJudicial.Visible = False
                    Me.pnlSalaJuzgado.Visible = False
            End Select

        End Sub
        Public Sub _ListarDocJudicial()
            Listar()
        End Sub
#End Region

        Private Sub cbbAutJudicial__SelectedIndexChanged() Handles cbbAutJudicial._SelectedIndexChanged
            ComboSalaJudicial()
        End Sub
        Private Sub rdbOtros_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbOtros.CheckedChanged, rdbAutJudicial.CheckedChanged
            HAutJudicialOtro()
        End Sub

        Private Sub dtpFechaRecep__ValueChanged() Handles dtpFechaRecep._ValueChanged
            With dtpFechaRecep
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaRecep_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaRecep.Validated
            With dtpFechaRecep
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaDoc__ValueChanged() Handles dtpFechaDoc._ValueChanged
            With dtpFechaDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub



        Private Sub dtpFechaDoc_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaDoc.Validated
            With dtpFechaDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub
    End Class
End Namespace