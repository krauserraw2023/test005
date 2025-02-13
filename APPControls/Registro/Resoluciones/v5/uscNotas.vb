Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia
Namespace Registro.Resoluciones
    Public Class uscNotas
        Private objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing


#Region "Eventos"
        Public Event _Click_VerFormulario()
        Public Event _Click_FrmBusquedaAutoridadJudicial()

#End Region

#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _SubTipo() As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia
        Private ReadOnly Property FlagTransferSede As Integer
            Get
                Dim v As Integer = 0
                If _TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Then
                    v = 1
                End If
                Return v
            End Get
        End Property
        Public Property _TotalAnhos As Integer = 0
        Public Property _TotalMeses As Integer = 0
        Public Property _TotalDias As Integer = 0



#End Region

#Region "Propiedades"
        Public Property DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas

        Private Property DocumentoNumero() As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(value As String)
                txtNumDocumento.Text = value
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

        Private Property RegionOrigenId() As Integer = -1

        Private Property PenalOrigenId As Integer = -1

        Private Property TipoNota() As Integer
            Get
                Return cbbTipoNota.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoNota.SelectedValue = value
            End Set
        End Property



#End Region

#Region "Combo"
        Private Sub ComboTipoNota()
            cbbTipoNota.CodigoPadre = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Notas
            cbbTipoNota.LoadUsc()
            cbbTipoNota.SelectedValue = Me._SubTipo
        End Sub
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.LoadUsc()

            Me.TipoAutoridadJudicial = 2
            Me.PenalOrigenId = -1
            Me.RegionOrigenId = -1
        End Sub
        Private Sub ComboDistritoJudicial()

            Me.UscComboDistritoJudicial1._Combo()
            Me.UscComboDistritoJudicial1._selectedValue = -1

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or
              Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                Me.UscComboDistritoJudicial1._selectedValue = 2 'Region lima
            End If
        End Sub
        Public Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub





#End Region

#Region "Listar "
        Private Sub Listar()
            If Me._Codigo < 1 Then Exit Sub

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then

                If Me._InternoID < 1 Or _InternoIngresoInpeId < 1 Or _RegionID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno, _InternoIngresoInpeId e IdRegión")
                    Exit Sub
                End If
            Else
                If Me._InternoID < 1 Or _InternoIngresoId < 1 Or _RegionID < 1 Or _PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno, _InternoIngresoId, IdPenal e IdRegión")
                    Exit Sub
                End If
            End If
            'If Me._Codigo < 1 Or Me._InternoID < 1 Or _InternoIngresoId < 1 Or _RegionID < 1 Or _PenalID < 1 Then
            '    'Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno, IdPenal e IdRegión")
            '    Exit Sub
            'End If

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._Codigo

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
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
                Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                If .TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial Then
                    Me.DistritoJudicial = .DistritoJudicial
                    Me.SalaJuzgado = .SalaJuzgado
                    'cbbRegion.Enabled = False
                    'cbbPenal.Enabled = False
                Else
                    Me.DistritoJudicial = -1
                    Me.SalaJuzgado = -1

                End If
                Me.JuezNombre = .JuezNombre
                Me.SecretarioNombre = .SecretarioNombre
                Me.AutoridadOtroNombre = .AutoridadOtroNombre
                Me.AutoridadOtroCargo = .AutoridadOtroCargo
                Me.Observacion = .Observacion
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me.TipoNota = .DocumentoSubTipoId
                Me.RegionOrigenId = .RegionOrigenId
                Me.PenalOrigenId = .PenalOrigenId
                Me._TotalAnhos = .SentenciaTotalAnios
                Me._TotalMeses = .SentenciaTotalMeses
                Me._TotalDias = .SentenciaTotalDias
            End With
        End Sub



#End Region

#Region "Accion"
        Public Function Validar() As Boolean

            Dim blnValue As Boolean = False


            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                If Me._RegionID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro [Region/Penal], no fueron enviados al Objeto")
                    Return blnValue
                End If
                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro Código del interno no fueron enviados al Objeto")
                    Return blnValue
                End If
            Else
                If Me._RegionID < 1 Or Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro [Region/Penal], no fueron enviados al Objeto")
                    Return blnValue
                End If
                If Me._InternoIngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro Código del interno no fueron enviados al Objeto")
                    Return blnValue
                End If

            End If

            If Me.TipoNota < 1 And Me.DocumentoTipo Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de nota")
                Return blnValue
            End If
            If Me.DocumentoNumero.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Número del documento Judicial")
                Me.txtNumDocumento.Focus()
                Return blnValue
            End If


            '/*fecha de documento*/
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese la fecha del documento Judicial")
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            '/*fecha recepcion del documento*/
            If Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If

            '/*validar libertad*/
            If Me.TipoAutoridadJudicial = 1 Then
                'distrito judicial
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

                If Len(Me.SecretarioNombre) < 4 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                    Me.txtSecretario.Focus()
                    Return blnValue
                End If

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
                .InternoId = Me._InternoID
                .IngresoInpeId = Me._InternoIngresoInpeId
                .InternoIngresoId = Me._InternoIngresoId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .Estado = 1
                .DocumentoSubTipoId = Me.TipoNota
                .RegionOrigenId = Me.RegionOrigenId
                .PenalOrigenId = Me.PenalOrigenId
                .FlagTransferenciaSede = Me.FlagTransferSede
                .SentenciaTotalAnios = Me._TotalAnhos
                .SentenciaTotalMeses = Me._TotalMeses
                .SentenciaTotalDias = Me._TotalDias
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana _
                   Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                objEnt.InternoIngresoId = -1
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar2(objEnt)
            End If

            Return value

        End Function



#End Region

#Region "Otros"
        Private Sub ValoresxDefault()
            cbbTipoNota.Enabled = False
            ComboTipoNota()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            txtOtraAutoridadNombre.CharacterCasing = CharacterCasing.Upper
            txtOtraAutoridadCargo.CharacterCasing = CharacterCasing.Upper
            Me.txtNumDocumento.Focus()
            If _SubTipo = Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.ProyeccionVencimientoCondena Then
                Me.Panel2.Visible = False
            End If
        End Sub
        Public Sub _LoadUsc()
            ValoresxDefault()
            Listar()
        End Sub
        Private Sub EstadoControles()
            If cbbTipoAutJud.SelectedValue = EnumTipoAutoridad.AutoridadJudicial Then
                PnlAutoridadJudicial.Visible = True
                PnlAutoridadJudicial.Enabled = True
                PnlOtraAutoridad.Visible = False
                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
                Me.RegionOrigenId = -1
                Me.PenalOrigenId = -1
            Else
                PnlAutoridadJudicial.Visible = False
                PnlOtraAutoridad.Visible = True
                Me.DistritoJudicial = -1
                Me.SalaJuzgado = -1
            End If
        End Sub

#End Region

#Region "Evento_Controles_Formulario"
        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            EstadoControles()
        End Sub


#End Region

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


        Private Sub UscComboDistritoJudicial1__SelectedIndexChanged() Handles UscComboDistritoJudicial1._SelectedIndexChanged
            ComboSalaJuzgado()
        End Sub

        Private Sub UscComboDistritoJudicial1__Click_Buscar() Handles UscComboDistritoJudicial1._Click_Buscar
            RaiseEvent _Click_FrmBusquedaAutoridadJudicial()
        End Sub
    End Class
End Namespace
