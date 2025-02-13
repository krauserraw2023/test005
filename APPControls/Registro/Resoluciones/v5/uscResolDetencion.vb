Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Resoluciones
    Public Class uscResolDetencion
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing

        Private blnDataCargada As Boolean = False

#Region "Eventos"

        Public Event _Click_VerFormulario()
        Public Event _Click_VerExpediente()
        Public Event _Click_FrmBusquedaAutoridadJudicial()
#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoId() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1

        Public Property _blnNuevo() As Boolean = False
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                    v = 1
                End If
                Return v
            End Get
        End Property

        Public Property _InternoIngresoInpeId() As Integer = -1
        'Public Property _PenalLM As Boolean = False
#End Region
#Region "Propiedades"
        Public Property DocumentoTipo() As Integer = -1
        Public Property DocumentoNumero() As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(value As String)
                txtNumDocumento.Text = value
            End Set
        End Property
        Public Property DocumentoFechaRecepcion() As Long
            Get
                Return dtpDocJudFecRecep.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecRecep.ValueLong = value
            End Set
        End Property
        Public Property DocumentoFecha() As Long
            Get
                Return dtpDocJudFecha.ValueLong
            End Get
            Set(value As Long)
                dtpDocJudFecha.ValueLong = value
            End Set
        End Property
        Public Property TipoAutoridadJudicial() As Integer
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
        Public Property JuezNombre() As String
            Get
                Return txtJuez.Text
            End Get
            Set(value As String)
                txtJuez.Text = value
            End Set
        End Property
        Public Property SecretarioNombre() As String
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
        Public Property Observacion() As String
            Get
                Return txtObsLib.Text
            End Get
            Set(value As String)
                txtObsLib.Text = value
            End Set
        End Property
        Public Property NumLibro As String
            Get
                Return txtLibro.Text
            End Get
            Set(value As String)
                txtLibro.Text = value
            End Set
        End Property
        Public Property NumFolio As String
            Get
                Return txtFolio.Text
            End Get
            Set(value As String)
                txtFolio.Text = value
            End Set
        End Property
        Public Property SituacionJuridicaId As Integer
            Get
                Return cbbSitJuridica.SelectedValue
            End Get
            Set(value As Integer)
                cbbSitJuridica.SelectedValue = value
            End Set
        End Property
        Public ReadOnly Property Flagrancia As Boolean
            Get
                Dim Valor As Boolean = False
                If ckbFlagrancia.Checked = True Then
                    Valor = True
                Else
                    Valor = False
                End If
                Return Valor
            End Get
        End Property
#End Region
#Region "Combo"
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()
            Me.cbbTipoAutJud.SelectedValue = 1
            Me.cbbTipoAutJud.Enabled = False
        End Sub
        Private Sub ComboDistritoJudicial()
            Me.UscComboDistritoJudicial1._Todos = True
            Me.UscComboDistritoJudicial1._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
            Me.UscComboDistritoJudicial1._Combo()
            Me.UscComboDistritoJudicial1._selectedValue = -1 'Todos
        End Sub
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub
        Private Sub ComboSituacionJuridica()
            cbbSitJuridica.LoadUsc()
            cbbSitJuridica.SelectedValue = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
            cbbSitJuridica.Enabled = False
        End Sub
#End Region
#Region "Listar"
        Private Sub Listar()
            Me.SalaJuzgado = -1
            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            'Dim EntExp As Entity.Registro.Expediente = objBss.ListarDocJudExp(Me._Codigo)
            'Dim CodigoExpediente As Integer = EntExp.Codigo
            objEnt.Codigo = Me._Codigo
            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt = objBss.Listar_v2_LM(objEnt)
            Else
                objEnt = objBss.Listar_v2(objEnt)
            End If


            With objEnt
                Me._Codigo = .Codigo
                Me.DocumentoTipo = .DocumentoTipo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.DistritoJudicial = .DistritoJudicial
                If .DistritoJudicial > 0 Then
                    .TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial
                    Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                Else
                    If .TipoAutoridadJudicial = -1 Then
                        .TipoAutoridadJudicial = EnumTipoAutoridad.OtraAutoridad
                        Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                    Else
                        Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                    End If
                End If
                Me.SalaJuzgado = .SalaJuzgado
                Me.JuezNombre = .JuezNombre
                Me.SecretarioNombre = .SecretarioNombre
                Me.AutoridadOtroNombre = .AutoridadOtroNombre
                Me.AutoridadOtroCargo = .AutoridadOtroCargo
                Me.Observacion = .Observacion
                Me.SituacionJuridicaId = .SituacionJuridicaId
                ckbFlagrancia.Checked = .Flagrancia
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
            End With
        End Sub
#End Region
#Region "accion"
        Public Function Validar() As Boolean

            Dim blnValue As Boolean = False

            ''par-region/penal
            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros Región, no fue enviado al Objeto")
                Return blnValue
            End If

            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros [Region/Penal], no fueron enviados al Objeto")
                    Return blnValue
                End If
            End If

            If Not (Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) And Me._InternoIngresoId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código del interno no fueron enviados al Objeto")
                Return blnValue
            End If

            If (Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) And Me._InternoIngresoInpeId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código del interno no fueron enviados al Objeto")
                Return blnValue
            End If
            'nombre autoridad - otro
            If Me.DocumentoNumero.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Numero del documento Judicial")
                Me.txtNumDocumento.Focus()
                Return blnValue
            End If
            '/*fecha de documento*/
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If

            '/*fecha recepcion del documento*/
            If Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If


            '/*comparacion de fechas*/
            If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            If Me.SituacionJuridicaId < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione situacion juridica")
                cbbSitJuridica.Focus()
                Return blnValue
            End If
            '/*validar libertad*/
            If Me.TipoAutoridadJudicial = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de autoridad")
                Me.cbbTipoAutJud.Focus()
                Return blnValue
            ElseIf Me.TipoAutoridadJudicial = 1 Then
                If Me.DistritoJudicial < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito judicial")
                    Me.UscComboDistritoJudicial1.Focus()
                    Return blnValue
                End If
                If Me.SalaJuzgado < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la sala judicial")
                    Me.UscComboSala1.Focus()
                    Return blnValue
                End If
                'If Len(Me.JuezNombre) < 4 Then
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del juez")
                '    Me.txtJuez.Focus()
                '    Return blnValue
                'End If
                If Len(Me.SecretarioNombre) < 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                    Me.txtSecretario.Focus()
                    Return blnValue
                End If
            Else
                'nombre autoridad - otro
                If Me.AutoridadOtroNombre.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre de la autoridad")
                    Me.txtOtraAutoridadNombre.Focus()
                    Return blnValue
                End If
                'cargo autoridad - otro
                If Me.AutoridadOtroCargo.Length < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el cargo de la autoridad")
                    Me.txtOtraAutoridadCargo.Focus()
                    Return blnValue
                End If
            End If
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.DocumentoNumero = Me.DocumentoNumero
            objEnt.DocumentoTipo = Me._DocumentoTipo
            objEnt.InternoId = Me._InternoId
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                objEnt.InternoIngresoId = -1
                objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            Else
                objEnt.InternoIngresoId = Me._InternoIngresoId
            End If

            Dim id As Integer = -1
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                id = objBss.CuentaDocumentoTipo_LM(objEnt)
            Else
                id = objBss.CuentaDocumentoTipo(objEnt)
            End If

            If Me._Codigo < 1 And id > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El tipo y numero de documento ya existe")
                txtNumDocumento.Focus()
                Return blnValue
            End If
            Return True
        End Function

        Public Function AGrabar_LM() As Entity.Registro.DocumentoJudicial
            If Validar() = False Then
                Return Nothing
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial


            If Me._Codigo > 0 Then
                objEnt = (New Bussines.Registro.DocumentoJudicial).Listar_v2_LM(Me._Codigo)
            End If

            With objEnt
                If Me._Codigo = -1 And Me._TipoLicencia = enmTipoLicencia.Carceleta And Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.DetencionCarceleta Then
                    .MandatoDeInternamiento = 1 'es un mandato de detencion de internamiento
                End If
                .FlagTransferenciaSede = Me.FlagTransferSede
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoNumero = Me.DocumentoNumero
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
                    .JuezNombre = Me.JuezNombre
                    .SecretarioNombre = Me.SecretarioNombre
                    .AutoridadOtroNombre = ""
                    .AutoridadOtroCargo = ""
                Else
                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                    .AutoridadOtroNombre = Me.AutoridadOtroNombre
                    .AutoridadOtroCargo = Me.AutoridadOtroCargo
                    .JuezNombre = ""
                    .SecretarioNombre = ""
                End If
                .Estado = 1
                .Observacion = Me.Observacion
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .SituacionJuridicaId = Me.SituacionJuridicaId
                .Flagrancia = Me.Flagrancia
                If Me._Codigo = -1 Then 'si es modificar no deben cambiar
                    .InternoId = Me._InternoId
                    .InternoIngresoId = Me._InternoIngresoId
                    .IngresoInpeId = Me._InternoIngresoInpeId
                    ._RegionID = Me._RegionID
                    ._PenalID = Me._PenalID
                End If
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial

            value = objBss.Grabar_LM(objEnt)
            objEnt.Codigo = value
            Return objEnt

        End Function

        Public Function AGrabar() As Entity.Registro.DocumentoJudicial
            If Validar() = False Then
                Return Nothing
            End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoNumero = Me.DocumentoNumero
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
                    .JuezNombre = Me.JuezNombre
                    .SecretarioNombre = Me.SecretarioNombre
                    .AutoridadOtroNombre = ""
                    .AutoridadOtroCargo = ""
                Else
                    .DistritoJudicial = -1
                    .SalaJuzgado = -1
                    .AutoridadOtroNombre = Me.AutoridadOtroNombre
                    .AutoridadOtroCargo = Me.AutoridadOtroCargo
                    .JuezNombre = ""
                    .SecretarioNombre = ""
                End If
                .Observacion = Me.Observacion
                .InternoId = Me._InternoId
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .SituacionJuridicaId = Me.SituacionJuridicaId
                .Flagrancia = Me.Flagrancia
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .Estado = 1
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial

            value = objBss.Grabar2(objEnt)

            objEnt.Codigo = value
            Return objEnt
            'hola
        End Function
        Public Sub CargarDataCabacera(obj As Entity.Registro.Expediente)
            Me.DocumentoNumero = obj.ExpedienteNumero
            Me.DocumentoFecha = obj.ExpedienteFecha
            Me.DocumentoFechaRecepcion = obj.ExpedienteFechaDocRecepcion
            Me.DistritoJudicial = obj.AutoridadJudicialID
            Me.SalaJuzgado = obj.SalaJudicialID
            Me.JuezNombre = obj.ExpedienteJuez
            Me.SecretarioNombre = obj.ExpedienteSecretario
            Me.Observacion = obj.Observacion
            Me.ckbFlagrancia.Checked = obj.Flagrancia
        End Sub
        Public Sub ControlEnablet()
            txtNumDocumento.ReadOnly = True
            dtpDocJudFecha.Enabled = False
            dtpDocJudFecRecep.Enabled = False
            UscComboDistritoJudicial1.Enabled = False
            UscComboSala1.Enabled = False
            txtJuez.ReadOnly = True
            txtSecretario.ReadOnly = True
            txtObsLib.ReadOnly = True
            ckbFlagrancia.Enabled = False
        End Sub
        Public Sub ControlClear()
            Me.DocumentoNumero = ""
            dtpDocJudFecha.ValueLong = 0
            dtpDocJudFecRecep.ValueLong = 0
            UscComboDistritoJudicial1._selectedValue = 2
            'UscComboSala1._SalaJuzgadoID_Seleccionado 
            txtJuez.Text = ""
            txtSecretario.Text = ""
            txtObsLib.Text = ""
            ckbFlagrancia.Checked = False
        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboSalaJuzgado()
            ComboSituacionJuridica()
          
            Listar()
            If Me._TipoLicencia = enmTipoLicencia.Carceleta Then
                lblFolio.Visible = False
                lblLibro.Visible = False
                txtFolio.Visible = False
                txtLibro.Visible = False
            End If
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                If Me._InternoIngresoInpeId < 1 Or _RegionID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno y IdRegión")
                End If
            Else
                If Me._InternoIngresoId < 1 Or _RegionID < 1 Or _PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno, IdPenal e IdRegión")
                End If
            End If
            Me.blnDataCargada = True
            txtNumDocumento.Focus()
        End Sub
        Public Sub _LoadUsc()
            If _Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If
            ValoresxDefault()
        End Sub
#End Region
        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            If cbbTipoAutJud.SelectedValue = EnumTipoAutoridad.AutoridadJudicial Then
                PnlAutoridadJudicial.Visible = True
                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
            Else
                PnlAutoridadJudicial.Visible = False
                Me.DistritoJudicial = -1
                Me.SalaJuzgado = -1
            End If
        End Sub

        Private Sub cbbDistritoJud__SelectedIndexChanged()
            If Me.DistritoJudicial > 0 Then
                ComboSalaJuzgado()
            End If
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

        Private Sub dtpDocJudFecha_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dtpDocJudFecha.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
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


        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            RaiseEvent _Click_VerFormulario()
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

        Private Sub uscResolDetencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub ckbExpediente_CheckedChanged(sender As Object, e As EventArgs)

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