Option Explicit On
Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia

Namespace Registro.Sentencia
    Public Class uscResolConmutacion
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing
        Public objEntNACol As New Entity.Registro.Documento.NombresAsociadosCol
        Private objEntNACol2 As New Entity.Registro.NombreAsociadoCol
        Public objEntNACol_Com As Entity.Registro.NombreAsociadoCol = Nothing
        Private objEntNACol_cop As New Entity.Registro.Documento.NombresAsociadosCol
        Private objEntNA As Entity.Registro.NombreAsociado = Nothing
        Private objBssNA As Bussines.Registro.NombreAsociado = Nothing
        Private Property blnEliminar As Boolean = False
        Private blnHabilitar As Boolean = False

#Region "Eventos"
        Public Event _Click_EnabledExpedientes(OpcionAclaratoria As Integer)
        Public Event _Click_ValidarNombreAsociado()
        Public Event _Click_VerFormulario()
        Public Event _Click_FrmBusquedaAutoridadJudicial()
#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _InternoID() As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property _CodDocJud As Integer = -1
        Public Property _Lista_NombresAsociados() As Entity.Registro.Documento.NombresAsociadosCol
            Get
                Return objEntNACol
            End Get
            Set(value As Entity.Registro.Documento.NombresAsociadosCol)
                objEntNACol = value
            End Set
        End Property
        Public Property _Lista_NombresAsociados2() As Entity.Registro.NombreAsociadoCol
            Get
                Return objEntNACol2
            End Get
            Set(value As Entity.Registro.NombreAsociadoCol)
                objEntNACol2 = value
            End Set
        End Property

        Public Property _TipoAclaratoriaSeleccionado As Integer = -1
        Public Property _TipoAclaratoria As Integer = -1
        Public Property _TipoAclaratoriaCon As Boolean = False
        Public Property _DocSubTipoID As Integer = -1
        Public Property ValorRef As Boolean = False
        Public Property _PermisoEliminar() As Boolean = False
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
#End Region
#Region "Propiedades"
        Public Property _DocumentoTipo() As Integer = -1
        Private Property DocumentoNumero() As String
            Get
                Return txtNumDocumento.Text.Trim
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
        Private Property TipoAutoridadJudicial() As SByte
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(value As SByte)
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
        Public Property AutoridadJuzgadonombre As String = ""
        Public Property SalaJuzgado() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
        Public Property SalaJuzgadonombre As String = ""
        Public Property JuezNombre() As String
            Get
                Return txtJuez.Text.Trim
            End Get
            Set(value As String)
                txtJuez.Text = value
            End Set
        End Property
        Public Property SecretarioNombre() As String
            Get
                Return txtSecretario.Text.Trim
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
                txtOtraAutoridadNombre.CharacterCasing = CharacterCasing.Upper
            End Set
        End Property
        Private Property AutoridadOtroCargo() As String
            Get
                Return txtOtraAutoridadCargo.Text
            End Get
            Set(value As String)
                txtOtraAutoridadCargo.Text = value
                txtOtraAutoridadCargo.CharacterCasing = CharacterCasing.Upper
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
        Private Property PenalOrigenId As Integer = -1
        Private Property PenalDestinoid As Integer = -1
        Private Property PenalOtroOrigenNom As String = ""
        Private Property PenalDestinoOtroNom As String
        Public Property FechaMovimiento() As Long = 0
        Private Property MovimientoMotivoId As Integer = -1

        Private Property SituacionJuridicaId As Integer = -1
        Public Property ApellidoPaternoNA As String = ""
        Public Property ApellidoMaternoNA As String = ""
        Public Property NombresNA As String = ""

#End Region
#Region "propiedades_grilla"
        Private ReadOnly Property GrillaNombresAsociadoId() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_id").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaApePaterno() As String
            Get
                Dim intValue As String = ""
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_ape_pat").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaApematerno() As String
            Get
                Dim intValue As String = ""
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_ape_mat").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaNombres() As String
            Get
                Dim intValue As String = ""
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Cells("col_nom").Value
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaRegistroNomAsoc() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .Rows.Count
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
        Public ReadOnly Property GrillaPosic() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    'With Me.dgwNomAsoc
                    '    intValue = .SelectedRows(0).Index
                    'End With
                Catch ex As Exception
                    Dim s As String = ""
                    s = ex.Message
                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Combo"
        Private Sub ComboDistritoJudicial()

            With Me.UscComboDistritoJudicial1
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
                ._Combo()
                ._selectedValue = -1
            End With

        End Sub
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub
        Dim objenmParametrica As Type.Combo.ComboTipo = Type.Combo.ComboTipo.Ninguno
        Private Sub ComboTipoAutoridadJudicial()
            cbbTipoAutJud.Combo(Me._TipoLicencia, Me._DocumentoTipo)
            cbbTipoAutJud.SelectedValue = 1
        End Sub
        Public Sub ControlFocus()
            txtJuez.Focus()
        End Sub
#End Region
#Region "Listar"
        Dim intContadorPrin As Integer = 0

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
                Me._DocumentoTipo = .DocumentoTipo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.TipoAutoridadJudicial = .TipoAutoridadJudicial
                If Me.TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial Then
                    Me.DistritoJudicial = .DistritoJudicial
                    ComboSalaJuzgado()
                    Me.SalaJuzgado = .SalaJuzgado
                Else
                    Me.DistritoJudicial = -1
                    Me.SalaJuzgado = -1
                End If
                Me.JuezNombre = .JuezNombre
                Me.SecretarioNombre = .SecretarioNombre
                Me.AutoridadOtroNombre = .AutoridadOtroNombre
                Me.AutoridadOtroCargo = .AutoridadOtroCargo
                Me.Observacion = .Observacion
                Me.SituacionJuridicaId = .SituacionJuridicaId
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro
                Me._DocSubTipoID = .DocumentoSubTipoId
                Me.FechaMovimiento = .FechaMovimiento
            End With
        End Sub

#End Region
#Region "Accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False

            '/*Nunero de la resolucion*/
            If Me.DocumentoNumero = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese número del documento")
                txtNumDocumento.Select()
                Return blnValue
            End If
            '/*fecha recepcion del documento*/
            If Me.DocumentoFechaRecepcion < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento de Recepción del documento")
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            '/*fecha de documento*/
            If Me.DocumentoFecha < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            '/*comparacion de fechas*/
            If Me.DocumentoFecha > Me.DocumentoFechaRecepcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If

            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana Then
                If Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros Penal, no fue enviado al Objeto")
                    Return blnValue
                End If
            End If

            If Me._RegionID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros RegionId, no fue enviado al Objeto")
                Return blnValue
            End If
            If (Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana) Then

                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro InternoIngresoInpeId del interno no fueron enviados al Objeto")
                    Return blnValue
                End If

                If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                    If Me._InternoIngresoId < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro InternoIngresoId del interno no fueron enviados al Objeto")
                        Return blnValue
                    End If
                End If
            Else
                If Not (Me._TipoLicencia = enmTipoLicencia.Carceleta _
               Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
               Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana) Then
                    If Me._InternoIngresoId < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro Código del interno no fueron enviados al Objeto")
                        Return blnValue
                    End If
                End If
            End If

            If Me.TipoAutoridadJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de autoridad judicial")
                Me.cbbTipoAutJud.Focus()
                Return blnValue
            ElseIf Me.TipoAutoridadJudicial = 1 Then
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
                If Me.SalaJuzgado = 148 Then 'Resolucion (Presidente de la republica)
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La opción : [Resolucion (Presidente de la republica)] " + Chr(13) +
                                                                            "solo se debe registrar, Seleccionando el TIPO DE AUTORIDAD [Presidente de la Republica].")
                    Me.UscComboSala1.Focus()
                    Return blnValue
                End If
                If Me.SecretarioNombre = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                    Me.txtSecretario.Focus()
                    Return blnValue
                End If
            End If

            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt = New Entity.Registro.DocumentoJudicial
            objEnt.DocumentoNumero = Me.DocumentoNumero
            objEnt.DocumentoTipo = Me._DocumentoTipo
            objEnt.DocumentoFecha = Me.DocumentoFecha
            objEnt.InternoId = Me._InternoID
            objEnt.InternoIngresoId = Me._InternoIngresoId
            objEnt.IngresoInpeId = Me._InternoIngresoInpeId
            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana

                Case Else
                    If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe un documento, con el mismo N° [" & Me.DocumentoNumero & "]" + Chr(13) +
                                "y fecha de documento [" & Me.dtpDocJudFecha.Value & "]")
                        txtNumDocumento.Focus()
                        Return blnValue
                    End If
            End Select

            Return True
        End Function
        Public Function AGrabar(Optional objDoc As Entity.Registro.DocumentoJudicial = Nothing) As Integer
            Dim Value As Integer
            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt

                .Codigo = Me._Codigo
                .DocumentoTipo = Me._DocumentoTipo
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .TipoAutoridadJudicial = Me.TipoAutoridadJudicial

                If Me.TipoAutoridadJudicial = EnumTipoAutoridad.AutoridadJudicial Then
                    .DistritoJudicial = Me.DistritoJudicial
                    If Me.SalaJuzgado > 0 Then
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
                    .JuezNombre = ""
                    .SecretarioNombre = ""
                    .AutoridadOtroNombre = Me.AutoridadOtroNombre
                    .AutoridadOtroCargo = Me.AutoridadOtroCargo
                End If
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .SituacionJuridicaId = Me.SituacionJuridicaId
                .FechaMovimiento = Me.FechaMovimiento
                .Observacion = Me.Observacion
                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                Select Case Me._DocumentoTipo
                    Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion,
                               Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Prision_Preventiva,
                               Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Adecuacion_Prision_Preventiva
                        .ProlonDetencionFechFin = objDoc.ProlonDetencionFechFin
                        .ProlonDetencionFechIni = objDoc.ProlonDetencionFechIni
                        .ProlonDetencionTipoUnidad = objDoc.ProlonDetencionTipoUnidad
                        .ProlonDetencionValor = objDoc.ProlonDetencionValor
                End Select
                .DocumentoSubTipoId = Me._DocSubTipoID
                .FlagTransferenciaSede = Me.FlagTransferSede
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                .SentenciaTotalAnios = objDoc.SentenciaTotalAnios
                .SentenciaTotalMeses = objDoc.SentenciaTotalMeses
                .SentenciaTotalDias = objDoc.SentenciaTotalDias
            End With

            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                    Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                    Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                Value = objBss.Grabar_LM(objEnt)
            Else
                Value = objBss.Grabar2(objEnt)
            End If

            Return Value

        End Function
        Public Function AGrabarEnt() As Entity.Registro.DocumentoJudicial

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                .Codigo = Me._Codigo
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.AcumulacionExpedientes
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
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .SituacionJuridicaId = Me.SituacionJuridicaId
                .Observacion = Me.Observacion
                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                .FlagTransferenciaSede = Me.FlagTransferSede
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar2(objEnt)
            End If

            objEnt.Codigo = value
            Return objEnt

        End Function

        Private Function CopiarPropiedades(objEntHis As Entity.Registro.InternoHistorico, ObjEntInt As Entity.Registro.Interno) As Entity.Registro.InternoHistorico
            With ObjEntInt
                '/*datos generales*/
                objEntHis.CodigoRP = .CodigoRP
                objEntHis.Libro = .Libro
                objEntHis.Folio = .Folio
                objEntHis.ApellidoPaterno = .ApellidoPaterno
                objEntHis.ApellidoMaterno = .ApellidoMaterno
                objEntHis.Nombres = .Nombres

            End With
            '/*********************/
            Return objEntHis
        End Function
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboSalaJuzgado()
            Listar()
        End Sub
        Public Sub _LoadUsc()
            If _Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Me._blnNuevo = False
            End If
            ValoresxDefault()
        End Sub
        Public Sub _UscComboSalaFocus()
            UscComboSala1.Focus()
        End Sub
#End Region
#Region "eventos_controles_formulario"
        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            If cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial Then
                PnlAutoridadJudicial.Visible = True
                PnlAutoridadJudicial.Enabled = True
                PnlOtraAutoridad.Visible = False
                txtJuez.Text = ""
                txtSecretario.Text = ""
                Me.grbAutoridad.Visible = True
                Me.lblNroDocumento.Text = "N° Documento :"
            ElseIf cbbTipoAutJud.SelectedValue = Type.Enumeracion.Movimiento.EnumTipoAutoridad.PresidenteDeLaRepublica Then
                Me.grbAutoridad.Visible = True
                txtOtraAutoridadCargo.Text = "PRESIDENTE DE LA REPUBLICA"
                Me.lblNroDocumento.Text = "Resol. Suprema :"
                PnlAutoridadJudicial.Visible = False
                PnlOtraAutoridad.Visible = True
            Else
                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
                PnlOtraAutoridad.Visible = True
                PnlOtraAutoridad.Enabled = True
                txtOtraAutoridadCargo.Visible = True
                txtOtraAutoridadNombre.Visible = True
                PnlAutoridadJudicial.Visible = False
                PnlAutoridadJudicial.Enabled = False
                Me.grbAutoridad.Visible = True
                Me.lblNroDocumento.Text = "N° Documento :"
            End If
        End Sub

        Private Sub cbbTipoAclaratoria__SelectedIndexChanged()
            Select Case Me._DocSubTipoID
                Case 1 'expediente
                    'dgwNomAsoc.Enabled = False
                    Me.blnHabilitar = False
                    RaiseEvent _Click_EnabledExpedientes(Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Expediente) 'solo expediente
                    'dgwNomAsoc.DataSource = Nothing
                Case 2 'nombres
                    'dgwNomAsoc.Enabled = True
                    Me.blnHabilitar = True
                    RaiseEvent _Click_EnabledExpedientes(Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_Nombre) 'solo nombres
                    'ListarNombreAsociadoBD(_InternoID)
                Case 3 'exp-nombres
                    'dgwNomAsoc.Enabled = True
                    Me.blnHabilitar = True
                    RaiseEvent _Click_EnabledExpedientes(Type.Enumeracion.SubTipoDocJudicial.enumSubTipo.Aclaratoria_de_ExpedienteNombres) 'todos
                    'ListarNombreAsociadoBD(_InternoID)
            End Select
        End Sub

        Public Property ValorEli As Boolean = False
        Public Property ValorVal As Boolean = False


        Private Sub cbbDistritoJud__SelectedIndexChanged()
            If Me.DistritoJudicial > 0 Then
                ComboSalaJuzgado()
            End If
        End Sub
#End Region

        Private Sub uscResolAclaratoriaExpe_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            PnlAutoridadJudicial.Visible = True
            PnlOtraAutoridad.Visible = False
            txtOtraAutoridadNombre.CharacterCasing = CharacterCasing.Upper
            txtOtraAutoridadCargo.CharacterCasing = CharacterCasing.Upper
        End Sub

        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado

        End Sub

        Private Sub cbbTipoAutJud_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipoAutJud.Load

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
        Private Sub dtpDocJudFecha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dtpDocJudFecha.Validating
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
        Private Sub UscComboDistritoJudicial1__SelectedIndexChanged() Handles UscComboDistritoJudicial1._SelectedIndexChanged
            If Me.DistritoJudicial > 0 Then
                ComboSalaJuzgado()
            End If

        End Sub
        Private Sub UscComboDistritoJudicial1__Click_Buscar() Handles UscComboDistritoJudicial1._Click_Buscar
            RaiseEvent _Click_FrmBusquedaAutoridadJudicial()
        End Sub
    End Class
End Namespace
