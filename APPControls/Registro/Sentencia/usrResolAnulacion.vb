Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia
Namespace Registro.Sentencia
    Public Class usrResolAnulacion
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
#Region "Eventos"
        Public Event _CargarAnhoMesDia(Anho As Integer, Mes As Integer, Dias As Integer)
        Public Event _ChecekHabilitarAgregarCondena(valor As Boolean)
        Public Event _FocusFechaRecep()
        Public Event _Click_VerFormulario()
        Public Event _Click_FrmBusquedaAutoridadJudicial()
#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _Anulacion As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ninguno
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

        Private Property DocumentoNumero() As String
            Get
                Return txtNumOficio.Text
            End Get
            Set(value As String)
                txtNumOficio.Text = value
            End Set
        End Property
        Public Property DocumentoFechaRecepcion() As Long
            Get
                Return dtpFechRecepDoc.ValueLong
            End Get
            Set(value As Long)
                dtpFechRecepDoc.ValueLong = value
            End Set
        End Property
        Private Property DocumentoFecha() As Long
            Get
                Return dtpFechDoc.ValueLong
            End Get
            Set(value As Long)
                dtpFechDoc.ValueLong = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return txtObservacion.Text
            End Get
            Set(value As String)
                txtObservacion.Text = value
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
        Private Property SubTipoID() As Integer
            Get
                Return cbbAnulacion.SelectedValue
            End Get
            Set(value As Integer)
                cbbAnulacion.SelectedValue = value
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
        Private Property SentenciaFecha() As Long
            Get
                Return dtpFecSentencia.ValueLong
            End Get
            Set(value As Long)
                dtpFecSentencia.ValueLong = value
            End Set
        End Property
        Private Property SentenciaConsentida() As Boolean
            Get
                Return chkConsentida.Checked
            End Get
            Set(value As Boolean)
                chkConsentida.Checked = value
            End Set
        End Property
        Private Property SentenciaCadenaPerpetua() As Boolean
            Get
                Return chkCadenaPerpetua.Checked
            End Get
            Set(value As Boolean)
                chkCadenaPerpetua.Checked = value
            End Set
        End Property

        Private _blnCadenaPerpetua As Boolean = False
        Public Property blnCadenaPerpetua() As Boolean
            Get
                Return _blnCadenaPerpetua
            End Get
            Set(ByVal value As Boolean)
                chkCadenaPerpetua.Checked = blnCadenaPerpetua
            End Set
        End Property
        Public Property blnResultado() As Boolean = True
        Private intValidar As Integer = 1
#End Region
#Region "Combo"
        Private blnCargarCombo As Boolean = False
        Private Sub ComboAnulacion()
            With Me.cbbAnulacion
                .Parametro2 = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Anulacion_Antecedentes
                .LoadUsc()
                .SelectedValue = 37
            End With
        End Sub
        Private Sub ComboDistritoJudicial()

            With Me.UscComboDistritoJudicial1
                ._Todos = True
                ._TodosMensaje = "SELECCIONAR DISTRITO JUDICIAL"
                ._Combo()
                ._selectedValue = -1
            End With

            'Me.UscComboDistritoJudicial1._Combo()

            'If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or _
            ' Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
            '    Me.UscComboDistritoJudicial1._selectedValue = 2 'Region lima
            'End If
        End Sub
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                If Me.DistritoJudicial > 0 Then
                    ._Todos = True
                    ._TodosMensaje = "[SELECCIONAR AUTORIDAD JUDICIAL]"
                    ._DistritoJudicialID = Me.DistritoJudicial
                    ._Combo()
                End If
            End With
        End Sub
        Private Sub CargarCombos()
            ComboAnulacion()
            ComboDistritoJudicial()
            ComboSalaJuzgado()

            blnCargarCombo = True
        End Sub
#End Region

#Region "Listar"
        Private Sub Listar()
            If Me._Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If
            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._Codigo
            objEnt = objBss.Listar_v2(objEnt)

            With objEnt
                Me._Codigo = .Codigo
                Me.DistritoJudicial = .DistritoJudicial
                Me.SalaJuzgado = .SalaJuzgado
                Me.JuezNombre = .JuezNombre
                Me.SecretarioNombre = .SecretarioNombre
                Me.DocumentoTipo = .DocumentoTipo
                Me.SubTipoID = .DocumentoSubTipoId
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.Observacion = .Observacion
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me.SentenciaFecha = .SentenciaFecha
                Me.SentenciaConsentida = .SentenciaConsentida
                Me.SentenciaCadenaPerpetua = .SentenciaCadenaPerpetua
                Me.ProlonDetencionValor = .ProlonDetencionValor
                Me._Anulacion = .IdDocumentoAntecedente
                _OrdenActivacion = True
                RaiseEvent _ChecekHabilitarAgregarCondena(.SentenciaCadenaPerpetua)
                RaiseEvent _CargarAnhoMesDia(.SentenciaTotalAnios, .SentenciaTotalMeses, .SentenciaTotalDias)
            End With
        End Sub
        Public _OrdenActivacion As Boolean = False
#End Region
#Region "accion"
        Public Function Validar() As Boolean

            Dim blnValue As Boolean = False
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._RegionID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros [Region], no fueron enviados al Objeto")
                    Return blnValue
                End If
            Else
                If Me._RegionID < 1 Or Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros [Region/Penal], no fueron enviados al Objeto")
                    Return blnValue
                End If
            End If
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Ingreso INPE del interno no fueron enviados al Objeto")
                    Return blnValue
                End If
            Else
                If Me._InternoIngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código de ingreso del interno no fueron enviados al Objeto")
                    Return blnValue
                End If
            End If

            If Me.DocumentoNumero = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese número del documento")
                txtNumOficio.Select()
                Return blnValue
            End If
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                Me.dtpFechDoc.Focus()
                Return blnValue
            End If
            If Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                Me.dtpFechRecepDoc.Focus()
                Return blnValue
            End If
            If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                blnValue = False
                Me.dtpFechDoc.Focus()
                Return blnValue
            End If
            'distrito judicial 
            If Me.DistritoJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito judicial")
                Me.UscComboDistritoJudicial1.Focus()
                Return blnValue
            End If
            'sala judicial 
            If Me.SalaJuzgado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el sala judicial")
                Me.UscComboSala1.Focus()
                Return blnValue
            End If

            If Me.SecretarioNombre = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                Me.txtSecretario.Focus()
                Return blnValue
            End If
            'objBss = New Bussines.Registro.DocumentoJudicial
            'objEnt = New Entity.Registro.DocumentoJudicial
            'objEnt.DocumentoNumero = Me.DocumentoNumero
            'objEnt.DocumentoTipo = Me._DocumentoTipo
            'objEnt.InternoId = Me._InternoID
            'objEnt.InternoIngresoId = Me._InternoIngresoId
            'objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            'If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
            '    If Me._Codigo < 1 And objBss.CuentaDocumentoTipo_LM(objEnt) > 0 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
            '        txtNumOficio.Focus()
            '        Return blnValue
            '    End If
            'Else
            '    If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
            '        Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
            '        txtNumOficio.Focus()
            '        Return blnValue
            '    End If
            'End If
            Return True
        End Function
        Public Function AGrabar() As Integer
            If Validar() = False Then
                Return -1
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                '.FlagTransferenciaSede = Me.FlagTransferSede
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoSubTipoId = Me.SubTipoID
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .DistritoJudicial = Me.DistritoJudicial
                .SalaJuzgado = Me.SalaJuzgado
                If Me.SalaJuzgado > 1 Then
                    .TipoAutoridadJudicial = 1
                    .SalaJuzgado = Me.SalaJuzgado
                Else
                    .SalaJuzgado = -1
                End If
                .JuezNombre = Me.JuezNombre
                .SecretarioNombre = Me.SecretarioNombre
                '.AutoridadOtroNombre =Me.
                .Observacion = Me.Observacion
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._InternoIngresoId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .SentenciaFecha = Me.SentenciaFecha
                .SentenciaConsentida = Me.SentenciaConsentida
                .SentenciaCadenaPerpetua = Me.SentenciaCadenaPerpetua

            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            value = objBss.Grabar2(objEnt)
            Return value

        End Function
        Public Function AGrabar(EntDocJud As Entity.Registro.DocumentoJudicial) As Entity.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            With objEnt
                ' .FlagTransferenciaSede = Me.FlagTransferSede
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoSubTipoId = Me.SubTipoID
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .DistritoJudicial = Me.DistritoJudicial
                .SalaJuzgado = Me.SalaJuzgado
                If Me.SalaJuzgado > 1 Then
                    .TipoAutoridadJudicial = 1
                    .SalaJuzgado = Me.SalaJuzgado
                Else
                    .SalaJuzgado = -1
                End If
                .JuezNombre = Me.JuezNombre
                .SecretarioNombre = Me.SecretarioNombre
                .Observacion = Me.Observacion
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .SentenciaFecha = Me.SentenciaFecha
                .SentenciaConsentida = Me.SentenciaConsentida
                .SentenciaCadenaPerpetua = Me.SentenciaCadenaPerpetua
                .SentenciaTotalAnios = EntDocJud.SentenciaTotalAnios
                .SentenciaTotalMeses = EntDocJud.SentenciaTotalMeses
                .SentenciaTotalDias = EntDocJud.SentenciaTotalDias
                .ProlonDetencionValor = Me.ProlonDetencionValor
                .Estado = 1
                ._TipoLicencia = Me._TipoLicencia
                .FlagTransferenciaSede = EntDocJud.FlagTransferenciaSede
            End With
            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            If (Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana) Then
                objEnt.Codigo = objBss.Grabar_LM(objEnt)
            Else
                objEnt.Codigo = objBss.Grabar2(objEnt)
            End If

            Return objEnt
        End Function
        Public Property ProlonDetencionValor As Integer
            Get
                Return Val(txtCant.Text)
            End Get
            Set(value As Integer)
                If value = 0 Then
                    txtCant.Text = ""
                Else
                    txtCant.Text = value
                End If
            End Set
        End Property
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            Panel3.Visible = False
            If Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida Then
                Me.chkConsentida.Checked = True
                Me.chkConsentida.Enabled = False
            End If

            If Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Pena_Limitativa Then
                Me.pnlJornadas.Visible = True
            End If
            Select Case DocumentoTipo
                Case enumTipoDocumentoJudicial.Sent_Adecuacion_Pena, enumTipoDocumentoJudicial.Sent_Conmutacion_Pena, enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    lblTextCondena.Visible = True
                    Panel4.Visible = True
            End Select
            CargarCombos()
            Listar()
        End Sub
        Public Sub _LoadUsc()
           
            ValoresxDefault()

        End Sub
        Public Sub ControlFocus()
            dtpFechRecepDoc.Focus()
        End Sub
#End Region

        Private Sub cbbDistritoJud__SelectedIndexChanged()
            If blnCargarCombo = True Then
                ComboSalaJuzgado()
            End If
        End Sub

        Private Sub chkConsentida_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkConsentida.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub chkCadenaPerpetua_Click(sender As Object, e As System.EventArgs) Handles chkCadenaPerpetua.Click
            intValidar = intValidar + 1
            If Me._Codigo > 0 Then
                'contaAux = contaAux + 1

                RaiseEvent _ChecekHabilitarAgregarCondena(chkCadenaPerpetua.Checked)

                If Me.blnResultado = False Then

                    Me.blnCadenaPerpetua = False
                    Exit Sub

                Else
                    chkCadenaPerpetua.Checked = True
                    'Me.blnCadenaPerpetua = True

                    Exit Sub

                    RaiseEvent _ChecekHabilitarAgregarCondena(chkCadenaPerpetua.Checked)
                End If


            ElseIf Me._Codigo < 1 Then
                RaiseEvent _ChecekHabilitarAgregarCondena(chkCadenaPerpetua.Checked)
                If Me.blnResultado = False Then
                    Me.blnCadenaPerpetua = False
                    Exit Sub
                Else
                    Exit Sub


                End If
            End If
        End Sub

        Private Sub chkCadenaPerpetua_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkCadenaPerpetua.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            RaiseEvent _Click_VerFormulario()
        End Sub

        Private Sub dtpFechDoc__ValueChanged() Handles dtpFechDoc._ValueChanged
            With dtpFechDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechDoc_Validated(sender As Object, e As System.EventArgs) Handles dtpFechDoc.Validated
            With dtpFechDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechRecepDoc__ValueChanged() Handles dtpFechRecepDoc._ValueChanged
            With dtpFechRecepDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechRecepDoc_Validated(sender As Object, e As System.EventArgs) Handles dtpFechRecepDoc.Validated
            With dtpFechRecepDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFecSentencia__ValueChanged() Handles dtpFecSentencia._ValueChanged
            With dtpFecSentencia
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFecSentencia_Validated(sender As Object, e As System.EventArgs) Handles dtpFecSentencia.Validated
            With dtpFecSentencia
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
            If blnCargarCombo = True Then
                ComboSalaJuzgado()
            End If
        End Sub

        Private Sub UscComboDistritoJudicial1_Load(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace