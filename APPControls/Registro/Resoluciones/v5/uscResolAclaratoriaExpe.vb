Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.Licencia
Imports System.ComponentModel

Namespace Registro.Resoluciones
    Public Class uscResolAclaratoriaExpe
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
        Public Event _Click_FrmBusquedaSalaJuzgado()
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
        Public Property FechaMovimiento() As Long
        Public Property FechaInscripcion() As Long
            Get
                Return dtpFechaInscripcion.ValueLong
            End Get
            Set(value As Long)
                dtpFechaInscripcion.ValueLong = value
            End Set
        End Property
        Public Property MovimientoMotivoId As Integer = -1

        Private Property SituacionJuridicaId As Integer = -1
        Public Property ApellidoPaternoNA As String = ""
        Public Property ApellidoMaternoNA As String = ""
        Public Property NombresNA As String = ""
        Public FechaCreacion As String = ""
        Public Property idEstadoTraslado As Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion = Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo
        Private Property estadoTrasladoNombre As String
            Get
                Return Me.txtEstadoTraslado.Text
            End Get
            Set(value As String)
                Me.txtEstadoTraslado.Text = value
            End Set
        End Property

        Public Property _Proceso_Pendiente_queda As Integer = -1

        Public Property _FechaEjecucionMov() As String
            Get
                Return txtFechaejecucionMov.Text.Trim
            End Get
            Set(value As String)
                txtFechaejecucionMov.Text = value
            End Set
        End Property
        Public Property Estado_Documento_Judicial As Integer = -1
        Public Property observacionEstEjecucion As String 'e.c.ccc.
        Public Property _Historico As Integer = 0
        Public Property _HistoricoFecha As Long = 0
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
            Me.UscComboDistritoJudicial1._Todos = True
            Me.UscComboDistritoJudicial1._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
            Me.UscComboDistritoJudicial1._Combo()
            Me.UscComboDistritoJudicial1._selectedValue = -1
        End Sub
        Private Sub ComboSalaJuzgado()
            If Me.DistritoJudicial > 0 Then
                With Me.UscComboSala1
                    ._Todos = True
                    ._TodosMensaje = "[SELECCIONAR AUTORIDAD JUDICIAL]"
                    ._DistritoJudicialID = Me.DistritoJudicial
                    ._Combo()
                End With
            End If
        End Sub
        Dim objenmParametrica As Type.Combo.ComboTipo = Type.Combo.ComboTipo.Ninguno
        Private Sub ComboTipoAutoridadJudicial()
            If (Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana) _
                And Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                cbbTipoAutJud.Combo(Me._TipoLicencia)
            Else
                cbbTipoAutJud.LoadUsc()
            End If
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
                Me.MovimientoMotivoId = .MovimientoMotivoId
                Me.idEstadoTraslado = .EstadoEjecucionId
                Me.estadoTrasladoNombre = .estadoEjecucionNombre
                Me.FechaInscripcion = .FechaInscripcion
                Me.FechaMovimiento = .FechaMovimiento
                Me._FechaEjecucionMov = .FechaMovimientoString
                Me._Historico = ._Historico
                Me._HistoricoFecha = ._FechaHistorico

                Select Case Me._DocumentoTipo
                    Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital_Nota
                        If idEstadoTraslado = 3 Then
                            Me._fechaejecucionMov = .fechaMovimientoEjecucionLongString
                        End If
                    Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad

                End Select
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
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser posterior a la fecha de recepcion")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            If Me.FechaInscripcion > 0 And Me.DocumentoFecha > Me.FechaInscripcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser posterior a la fecha de inscripción")
                blnValue = False
                Me.dtpDocJudFecha.Focus()
                Return blnValue
            End If
            If Me.FechaInscripcion > 0 And Me.DocumentoFechaRecepcion > Me.FechaInscripcion Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de recepción no puede ser posterior a la fecha de inscripción")
                blnValue = False
                Me.dtpDocJudFecRecep.Focus()
                Return blnValue
            End If
            If Me.FechaMovimiento > 0 And Me.FechaInscripcion > Me.FechaMovimiento Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de inscripción no puede ser posterior que la fecha de ejecución")
                blnValue = False
                Me.dtpFechaInscripcion.Focus()
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
                        'Legolas.Configuration.Aplication.MessageBox.Exclamation("Parámetro InternoIngresoId del interno no fueron enviados al Objeto")
                        'Return blnValue
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

            If Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad Then
                If Me.FechaInscripcion < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de inscripción")
                    dtpFechaInscripcion.Focus()
                    Return blnValue
                End If
            End If

            If Me.TipoAutoridadJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de autoridad judicial")
                Me.cbbTipoAutJud.Focus()
                Return blnValue
            End If
            '/*validar libertad*/
            If Me.TipoAutoridadJudicial = 1 Then
                'distrito judicial
                If Me._DocumentoTipo <> 74 Then
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
                End If

                If Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                    If Me.dtpFechaInscripcion.ValueLong = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar fecha de inscripción del documento.")
                        Me.dtpFechaInscripcion.Focus()
                        Return blnValue
                    End If
                    If Me.dtpFechaInscripcion.ValueLong < Me.dtpDocJudFecRecep.ValueLong Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de inscripción no puede ser mayor a la fecha de recepción del documento.")
                        Return blnValue
                    End If
                ElseIf Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Or
                   Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota Then
                    If Me.dtpFechaInscripcion.ValueLong = 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar fecha de inscripción del documento.")
                        Me.dtpFechaInscripcion.Focus()
                        Return blnValue
                    End If
                    If Me.dtpFechaInscripcion.ValueLong < Me.dtpDocJudFecRecep.ValueLong Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de inscripción no puede ser posterior a la fecha de recepción del documento.")
                        Return blnValue
                    End If

                Else
                    If Me.SecretarioNombre = "" Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                        Me.txtSecretario.Focus()
                        Return blnValue
                    End If
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
            If Me._DocumentoTipo <> Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental_Nota Then
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
                    If Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                        If Me.dtpFechaInscripcion.ValueLong = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Fecha de inscripción del Traslado.")
                            Me.dtpFechaInscripcion.Focus()
                            Return blnValue
                        End If
                        If Me.dtpFechaInscripcion.ValueLong < Me.dtpDocJudFecRecep.ValueLong Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("La Fecha de inscripción del Traslado no puede ser mayor a la fecha de recepción del documento.")
                            Return blnValue
                        End If
                    ElseIf Me._DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental Then
                        If Me.dtpFechaInscripcion.ValueLong = 0 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Fecha de inscripción del Traslado del documento.")
                            Me.dtpFechaInscripcion.Focus()
                            Return blnValue
                        End If
                        If Me.dtpFechaInscripcion.ValueLong < Me.dtpDocJudFecRecep.ValueLong Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("La Fecha de inscripción del Traslado no puede ser posterior a la fecha de recepción del documento.")
                            Return blnValue
                        End If

                    Else
                        If Me.SecretarioNombre = "" Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                            Me.txtSecretario.Focus()
                            Return blnValue
                        End If
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
            End If
            If Me._DocSubTipoID > 1 Then
                Dim Conta As Integer = 0
                For Each ob As Entity.Registro.Documento.NombresAsociados In _Lista_NombresAsociados
                    If ob.NAPrincipal = 1 Then
                        Conta = Conta + 1
                    End If
                Next
                If Conta > 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno solo puede tener un nombre principal")
                    'Me.btnEditarNomAsoc.Focus()
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
                'Obtener numero tipo documento, historico y fecha historica
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                Case Else
                    If Me._Codigo < 1 And objBss.CuentaDocumentoTipo(objEnt) > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya existe un documento, con el mismo N° [" & Me.DocumentoNumero & "]" + Chr(13) +
                                "y fecha de documento [" & Me.dtpDocJudFecha.Value & "]")
                        txtNumDocumento.Focus()
                        Return blnValue
                    End If
            End Select
            If Me._Historico = 1 And Me.DocumentoFechaRecepcion > Me._HistoricoFecha Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El documento de libertad pertenece a un Interno Historico," + Chr(13) +
                                                                        "por lo tanto la fecha de recepción no puede ser mayor al [" &
                                                                 Legolas.Components.FechaHora.FechaDate(Me._HistoricoFecha, True) & "]")
                dtpDocJudFecRecep.Focus()
                Return blnValue
            End If

            Return True
        End Function
        Public Function AGrabar(objDoc As Entity.Registro.DocumentoJudicial) As Integer

            Dim Value As Integer = -1
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
                        'Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                        '    .FechaMovimiento = Me.FechaMovimiento
                        'Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental,
                        '      Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Retorno_de_HospitalMental
                        '    .FechaInscipcion = Me.FechaMovimiento
                End Select
                .FechaMovimiento = Me.FechaMovimiento
                .FechaInscripcion = Me.FechaInscripcion
                .DocumentoSubTipoId = Me._DocSubTipoID
                .FlagTransferenciaSede = Me.FlagTransferSede
                .MovimientoMotivoId = objDoc.MovimientoMotivoId
                .EstadoEjecucionId = Me.idEstadoTraslado
                .SentenciaTotalAnios = objDoc.SentenciaTotalAnios
                .SentenciaTotalMeses = objDoc.SentenciaTotalMeses
                .SentenciaTotalDias = objDoc.SentenciaTotalDias
                .SentenciaCadenaPerpetua = objDoc.SentenciaCadenaPerpetua
                .PenalDestinoOtroNom = objDoc.PenalDestinoOtroNom
                .PenalOtroOrigenNom = objDoc.PenalOtroOrigenNom
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
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

            Select Case Me._DocumentoTipo
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad
                    Me.lblFechaInscripcion.Text = "Fecha de inscripción de Libertad:"
                    Me.lblFechaInscripcion.Visible = True
                    Me.dtpFechaInscripcion.Visible = True

                    Me.lblLibertad.Text = "Fecha de ejecución de Libertad:"
                    Me.txtFechaejecucionMov.Visible = True

                    Me.pnlEstadoTraslado.Visible = True
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital
                    lblNroDocumento.Text = "N° de oficio :"
                    lblFechaInscripcion.Visible = True
                    dtpFechaInscripcion.Visible = True
                    PnlTipoAutoridad.Visible = False

                    lblLibertad.Visible = True
                    lblLibertad.Text = "Fecha de ejecución de traslado:"
                    txtFechaejecucionMov.Visible = True
                    dtpFechaInscripcion.Visible = True
                    Me.pnlEstadoTraslado.Visible = True
                    Me.pnlObservacion.Size = New Size(760, 70)
                    Me.txtObsLib.Dock = DockStyle.Left

                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.RetornoTrasladoHospital
                    lblNroDocumento.Text = "N° de oficio :"
                    lblFechaInscripcion.Visible = True
                    lblFechaInscripcion.Text = "Fecha de inscripción de retorno:"
                    'txtFechaInscripcion.Visible = True
                    dtpFechaInscripcion.Visible = True
                    PnlTipoAutoridad.Visible = False

                    lblLibertad.Visible = True
                    lblLibertad.Text = "Fecha de ejecución de retorno:"
                    txtFechaejecucionMov.Visible = True
                    Me.pnlEstadoTraslado.Visible = True
                    Me.pnlObservacion.Size = New Size(760, 70)
                    Me.txtObsLib.Dock = DockStyle.Left
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.OrdenTrasladoHospital_Nota
                    lblNroDocumento.Text = "N° oficio/ Memo:"
                    lblFechaInscripcion.Visible = True
                    dtpFechaInscripcion.Visible = True
                    dtpFechaInscripcion.Value = Legolas.Components.FechaHora.FechaDate(Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong)
                    PnlTipoAutoridad.Visible = False

                    pnlAutoridad.Visible = False
                    'pnlObservacion.Dock = DockStyle.Fill

                    lblLibertad.Visible = True
                    lblLibertad.Text = "Fecha de ejecución de traslado:"
                    txtFechaejecucionMov.Visible = True
                    dtpFechaInscripcion.Visible = True

                    Me.pnlEstadoTraslado.Visible = True
                    Me.pnlObservacion.Size = New Size(760, 70)
                    Me.txtObsLib.Dock = DockStyle.Left
                Case Else

                    lblLibertad.Visible = False
                    dtpFechaInscripcion.Visible = False
            End Select

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
        Public Sub _activarEstadoEjecucion(esInimputable As Boolean)

            'Me.pnlEstadoTraslado.Visible = False

            Select Case Me._DocumentoTipo
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad
                    Me.pnlEstadoTraslado.Visible = True ' esInimputable
            End Select

        End Sub

#End Region
#Region "Formulario"
        Private Sub Frm_EstadoNoEjecutado()

            'validar que el documento haya sido grabado
            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de aplicar el estado de ejecución [NO EJECUTADO], debe grabar los datos del documento.")
                Exit Sub
            End If

            'validar si el documento de libertadt tiene un movimiento refrenciado, para no permitir modificar el estado de modificacion
            If Me._DocumentoTipo = Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Libertad Then
                Dim objBss As New Bussines.Registro.InternoMovimiento

                If objBss.movimientoReferenciadoConDocumentoJud(Me._InternoID, Me._InternoIngresoInpeId, Me._InternoIngresoId, Me._Codigo) = True Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede cambiar el estado de ejecución, el documento se encuentra referenciado con un movimiento de libertad.")
                    Exit Sub
                End If
            End If

            'validar, solo se puede cambiar el estado de ejecucion en los estados siguientes;
            Select Case Me.idEstadoTraslado
                Case Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.EnDesarrollo,
                     Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutado,
                     Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion1,
                     Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion2,
                    Type.Enumeracion.DocumentoJudicial.enmEstadoEjecucion.NoEjecutadoOpcion3
                    'pasa

                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se puede usar el estado de ejecución [NO EJECUTADO], cuando el estado de ejecución del documento se encuentre con el estado [EN DESARROLLO].")
                    Exit Sub
            End Select

            Dim frm As New Registro.Resoluciones.frmEstadoNoEjecutadoPopup
            With frm
                ._setTipoLicencia = Me._TipoLicencia
                ._setTipoOpcion = Me.idEstadoTraslado
                If .ShowDialog = DialogResult.OK Then
                    Me.idEstadoTraslado = ._getEstadoOpcion
                    Me.estadoTrasladoNombre = ._getEstadoNombre
                End If
            End With

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
                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
                txtOtraAutoridadCargo.Visible = False
                txtOtraAutoridadNombre.Visible = False
            Else


                txtOtraAutoridadCargo.Text = ""
                txtOtraAutoridadNombre.Text = ""
                PnlOtraAutoridad.Visible = True
                PnlOtraAutoridad.Enabled = True

                txtOtraAutoridadCargo.Visible = True
                txtOtraAutoridadNombre.Visible = True

                PnlAutoridadJudicial.Visible = False
                PnlAutoridadJudicial.Enabled = False
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
            txtOtraAutoridadCargo.Visible = False
            txtOtraAutoridadNombre.Visible = False
        End Sub


        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado

        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar

            RaiseEvent _Click_FrmBusquedaSalaJuzgado()

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

        Private Sub btnNoEjcutado_Click(sender As Object, e As EventArgs) Handles btnNoEjcutado.Click

            Frm_EstadoNoEjecutado()

        End Sub

        Private Sub dtpFechaInscripcion__ValueChanged() Handles dtpFechaInscripcion._ValueChanged
            'With dtpFechaInscripcion
            '    Dim Valor As String = .Value
            '    If IsDate(Valor) Then
            '        If .Value > Now() Then
            '            .Value = Nothing
            '            .Focus()
            '        End If
            '    End If
            'End With
        End Sub

        Private Sub dtpDocJudFecRecep_Validating(sender As Object, e As CancelEventArgs) Handles dtpDocJudFecRecep.Validating
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

        Private Sub dtpFechaInscripcion_Validating(sender As Object, e As CancelEventArgs) Handles dtpFechaInscripcion.Validating
            'With dtpFechaInscripcion
            '    Dim Valor As String = .Value
            '    If IsDate(Valor) Then
            '        If .Value > Now() Then
            '            .Value = Nothing
            '            .Focus()
            '        End If
            '    End If
            'End With
        End Sub

    End Class
End Namespace
