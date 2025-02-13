Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.SubTipoDocJudicial
Namespace Registro.Sentencia
    Public Class usrResolSentenciaV2
        Public objEnt As Entity.Registro.DocumentoJudicial = Nothing
        Private objBss As Bussines.Registro.DocumentoJudicial = Nothing

#Region "Eventos"
        Public Event _CargarAnhoMesDia(Anho As Integer, Mes As Integer, Dias As Integer)
        Public Event _ChecekHabilitarAgregarCondena(valor As Boolean)
        Public Event _Click_VerFormulario()
        Public Event _Click_VerNombresasociados()
        Public Event _Click_esInimputables(esInimputable As Boolean)
        Public Event _Click_FrmBusquedaAutoridadJudicial()

#End Region
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _RegionID() As Integer = -1
        Public Property _PenalID() As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoIngresoId() As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _blnNuevo() As Boolean = False
        Public Property DocumentoTipo() As Integer = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida
        Public Property _Documentos_sin_mov As Boolean = False
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
        Public Property NombreAsociado() As String
            Get
                Return ""
            End Get
            Set(ByVal value As String)
                'Me.lbletiqueta.Text = value
            End Set
        End Property
        Public Property EstablecimientomentalId As Integer = -1
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
        Private Property DocumentoFechaRecepcion() As Long
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

        Private Property SentenciaConsentida() As Boolean
            Get
                Return chkConsentida.Checked
            End Get
            Set(value As Boolean)
                chkConsentida.Checked = value
            End Set
        End Property
        Public Property SentenciaCadenaPerpetua() As Boolean
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



        Private intValidar As Integer = 1
        Public blnResultado As Boolean = False
        ''------Resolucion condsentida
        Private Property NumeroResolucion() As String
            Get
                Return txtResolucion.Text
            End Get
            Set(value As String)
                txtResolucion.Text = value
            End Set
        End Property
        Private Property ResolucionFecha() As Long
            Get
                Return dtpFechaResolucion.ValueLong
            End Get
            Set(value As Long)
                dtpFechaResolucion.ValueLong = value
            End Set
        End Property
        Private Property ResolucionFechaRecep() As Long
            Get
                Return dtpFechaRecepResolucion.ValueLong
            End Get
            Set(value As Long)
                dtpFechaRecepResolucion.ValueLong = value
            End Set
        End Property
#End Region
#Region "Propiedades_Publicas"
        Public ReadOnly Property _esInimputable As Boolean
            Get
                Return Me.rdbSi.Checked
            End Get
        End Property
        Public ReadOnly Property _Extramuro() As Integer
            Get
                Try

                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
#End Region


#Region "Combo"
        Private blnComboDistritoJud As Boolean = False
        Private Sub ComboDistritoJudicial()
            Me.UscComboDistritoJudicial1._Todos = True
            Me.UscComboDistritoJudicial1._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
            Me.UscComboDistritoJudicial1._Combo()
            If Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema Then
                Me.UscComboDistritoJudicial1._selectedValue = 8 ' Corte suprema de justicia
                Me.UscComboDistritoJudicial1.Enabled = False
            Else
                Me.UscComboDistritoJudicial1._selectedValue = -1
            End If

            blnComboDistritoJud = True
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
#End Region
#Region "Listar"
        Private Sub Listar()
            Me.UscComboSala1._SalaJuzgadoID = -1
            If Me._Codigo < 1 Then Exit Sub

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            objEnt.Codigo = Me._Codigo
            objEnt = objBss.Listar_v2(objEnt)

            With objEnt
                Me._Codigo = .Codigo
                Me.DistritoJudicial = .DistritoJudicial
                ComboSalaJuzgado()
                Me.SalaJuzgado = .SalaJuzgado
                Me.JuezNombre = .JuezNombre
                Me.SecretarioNombre = .SecretarioNombre
                Me.DocumentoTipo = .DocumentoTipo
                Me.DocumentoNumero = .DocumentoNumero
                Me.DocumentoFechaRecepcion = .DocumentoFechaRecepcion
                Me.DocumentoFecha = .DocumentoFecha
                Me.Observacion = .Observacion
                Me.NumFolio = .NumFolio
                Me.NumLibro = .NumLibro

                Me.SentenciaConsentida = .SentenciaConsentida
                Me.SentenciaCadenaPerpetua = .SentenciaCadenaPerpetua

                _OrdenActivacion = True
                RaiseEvent _ChecekHabilitarAgregarCondena(.SentenciaCadenaPerpetua)
                RaiseEvent _CargarAnhoMesDia(.SentenciaTotalAnios, .SentenciaTotalMeses, .SentenciaTotalDias)
                If .MovimientoMotivoId > 0 Then
                    Me.rdbSi.Checked = True
                    Me.NumeroResolucion = .DocumentoNumeroTraslado
                    'Me.EstablecimientomentalId = .EstablecimientomentalId
                    Me.ckbFecResolucion.Checked = IIf(Me.NumeroResolucion = "NO INDICA", True, False)
                End If
                Me.NumeroResolucion = .DocumentoNumeroTraslado
                Me.ResolucionFecha = .FechaResolucion
                Me.ResolucionFechaRecep = .FechaRecepcionResolucion
                If .DocumentoNumeroTraslado.Length = 0 Then Me.ckbResolucion.Checked = True
                If .FechaResolucion = 0 Then ckbFecResolucion.Checked = True
                If .FechaRecepcionResolucion = 0 Then ckbFecRecepcion.Checked = True
            End With

            If Me.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia Then
                If _blnNuevo = False Then
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                            ListarNombreAsociado_LM(Me._Codigo, Me._InternoID, Me._InternoIngresoId, Me._InternoIngresoInpeId)
                        Case Else
                            ListarNombreAsociado(Me._Codigo, Me._InternoID, Me._InternoIngresoId)
                    End Select
                End If
            End If

            validarExpedienteReferenciado()
        End Sub

        Private Sub ListarNombreAsociado_LM(DocJudicialId As Integer, InternoId As Integer, IngresoId As Integer, IngresoInpeId As Integer)
            ObjNombresAsociadosCol = New Entity.Registro.Documento.NombresAsociadosCol
            Dim objBss As New Bussines.Registro.Documento.NombresAsociados
            Dim objEnt As New Entity.Registro.Documento.NombresAsociados
            objEnt.InternoID = InternoId
            objEnt.IngresoID = IngresoId
            objEnt.IngresoInpeId = IngresoInpeId
            objEnt.DocumentoJudicialID = DocJudicialId
            ObjNombresAsociadosCol = objBss.ListarGrilla_LM(objEnt)
            Dim tipo As String = ""
            Dim accion As String = ""
            Dim strCadena As String = ""
            For Each ent As Entity.Registro.Documento.NombresAsociados In ObjNombresAsociadosCol
                If ent.NAPrincipal2 = Type.Enumeracion.NombreAsociado.EnmTipo.Principal Then
                    tipo = "Principal"
                Else
                    tipo = "Asociado"
                End If
                If ent.NAEstado = 1 Then
                    accion = "ACLARADO"
                Else
                    accion = "AGREGADO"
                End If
                strCadena = strCadena & ent.NAPaterno2 & " " & ent.NAMaterno2 & " " & ent.NANombres2 & " " & "[" & tipo & "]/[" & accion & "]" & vbCrLf
            Next

        End Sub
        Private Sub ListarNombreAsociado(DocJudicialId As Integer, InternoId As Integer, IngresoId As Integer)
            ObjNombresAsociadosCol = New Entity.Registro.Documento.NombresAsociadosCol
            Dim objBss As New Bussines.Registro.Documento.NombresAsociados
            Dim objEnt As New Entity.Registro.Documento.NombresAsociados
            objEnt.InternoID = InternoId
            objEnt.IngresoID = IngresoId
            objEnt.DocumentoJudicialID = DocJudicialId
            ObjNombresAsociadosCol = objBss.Listar_v2(objEnt)
            For Each ent As Entity.Registro.Documento.NombresAsociados In ObjNombresAsociadosCol
                Dim tipo As String = -1
                If ent.NAPrincipal2 = 1 Then
                    tipo = "(Principal)"
                Else
                    tipo = "(Nombre Asoc.)"
                End If
            Next
        End Sub
        Dim ObjNAEliminadosCol As New Entity.Registro.Documento.NombresAsociadosCol
        Public Sub ListarNombresAsociados(Eliminacion As Boolean, objEntDocNA As Entity.Registro.Documento.NombresAsociados)
            'paso 2
            If Eliminacion = False Then
                Dim val As Boolean = False
                Dim i As Integer = objEntDocNA.Posicion + 1
                If objEntDocNA.EstadoAccion < 2 Then
                Else
                    'obj = objEntDocNA
                    val = True
                End If

                If val = False Then
                    If objEntDocNA.NAPrincipal2 = 1 Then
                        For Each obj As Entity.Registro.Documento.NombresAsociados In ObjNombresAsociadosCol
                            obj.NAPrincipal2 = 0
                        Next
                    End If
                    objEntDocNA.Posicion = ObjNombresAsociadosCol.Count
                    ObjNombresAsociadosCol.Add(objEntDocNA)
                Else
                    ObjNombresAsociadosCol.NombresAsociados(ObjNombresAsociadosCol.Count - 1).NAPrincipal2 = objEntDocNA.NAPrincipal2
                    ObjNombresAsociadosCol.NombresAsociados(ObjNombresAsociadosCol.Count - 1).NANombres2 = objEntDocNA.NANombres2
                End If
            End If
            'Paso 3
            Dim tipo As String = ""
            Dim strCadena As String = ""
            Dim accion As String = ""
            For Each ent1 As Entity.Registro.Documento.NombresAsociados In ObjNombresAsociadosCol
                If ent1.Audit_Eliminado = True Then
                    ObjNAEliminadosCol.Add(ent1)
                Else
                    If ent1.NAPrincipal2 = Type.Enumeracion.NombreAsociado.EnmTipo.Principal Then
                        tipo = "Principal"
                    Else
                        tipo = "Asociado"
                    End If
                    If ent1.NAEstado = 1 Then
                        accion = "ACLARADO"
                    Else
                        accion = "AGREGADO"
                    End If
                    strCadena = strCadena & ent1.NAPaterno2 & " " & ent1.NAMaterno2 & " " & ent1.NANombres2 & " " & "[" & tipo & "]/[" & accion & "]" & vbCrLf

                End If
            Next
            Me.NombreAsociado = If(strCadena.Length = 0, "Ingresar Nombres asoc.", strCadena)
        End Sub



        Public _OrdenActivacion As Boolean = False
#End Region
#Region "Validacion"
        Private Sub validarExpedienteReferenciado()

            If Me._Codigo > 0 Then
                Dim bss As New Bussines.Registro.InternoExpedientePadre
                Dim obj As New Entity.Registro.InternoExpedientePadre
                obj.DocJudicialID = Me._Codigo
                obj.InternoID = Me._InternoID
                If bss.DocumentoReferenciado(obj) > 0 Then
                    rdbSi.Checked = Not (rdbNo.Checked)
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("No se puede realizar esta acción porque el proceso ha sido referenciado.")
                End If

            End If

        End Sub

#End Region

#Region "accion"
        Public Function Validar() As Boolean
            Dim blnValue As Boolean = False

            If Me._TipoLicencia = enmTipoLicencia.Carceleta Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                If _RegionID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado el valor de IdRegión")
                End If
                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro ingresoInpeId no fueron enviados al Objeto")
                    Return blnValue
                End If
            Else
                If Me._RegionID < 1 Or Me._PenalID < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametros [Region/Penal], no fueron enviados al Objeto")
                    Return blnValue
                End If
                If Me._InternoIngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Parametro IngresoInpeId no fueron enviados al Objeto")
                    Return blnValue
                End If
            End If
            If Me.DocumentoNumero = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese número del documento")
                txtNumOficio.Select()
                Return blnValue
            End If
            If Me.DocumentoFecha = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha documento Judicial")
                Me.dtpFechDoc.Focus()
                Return blnValue
            End If
            If Me.DocumentoFechaRecepcion = 0 Then
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
            'distrito judicial and sala judicial  
            If Me.DistritoJudicial < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el distrito judicial")
                Me.UscComboDistritoJudicial1.Focus()
                Return blnValue
            End If
            If Me.SalaJuzgado < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione sala judicial")
                Me.UscComboSala1.Focus()
                Return blnValue
            End If

            If Me.SecretarioNombre = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                Me.txtSecretario.Focus()
                Return blnValue
            End If
            ''Resolucion Consentida
            If Me.NumeroResolucion.Length = 0 And Me.ckbResolucion.Checked = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Nro. de Resolución que declara consentida la sentencia.")
                Me.txtResolucion.Focus()
                Return blnValue
            End If
            If Me.ResolucionFecha = 0 And ckbFecResolucion.Checked = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar la fecha de Resolución que declara consentida la sentencia.")
                blnValue = False
                Me.dtpFechaResolucion.Focus()
                Return blnValue
            End If
            'If Me.ResolucionFechaRecep = 0 Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar la fecha de recepción de la Resolución que declara consentida la sentencia.")
            '    blnValue = False
            '    Me.dtpFechaRecepResolucion.Focus()
            '    Return blnValue
            'End If
            'If Me.ResolucionFecha > ResolucionFechaRecep Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de Resolución no puede ser mayor que la fecha de recepcion que declara consentida la sentencia.")
            '    blnValue = False
            '    Me.dtpFechaResolucion.Focus()
            '    Return blnValue
            'End If
            Return True
        End Function
        Public Function AGrabar() As Integer

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial

            With objEnt
                .FlagTransferenciaSede = Me.FlagTransferSede
                .Codigo = Me._Codigo
                .DocumentoTipo = Me.DocumentoTipo
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoNumeroTraslado = Me.NumeroResolucion
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
                .IngresoInpeId = Me._InternoIngresoInpeId
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID

                .SentenciaConsentida = Me.SentenciaConsentida
                .SentenciaCadenaPerpetua = Me.SentenciaCadenaPerpetua
                '.SentenciaTotalAnios = Me.SentenciaTotalAnios
                '.SentenciaTotalMeses = Me.SentenciaTotalMeses
                '.SentenciaTotalDias = Me.SentenciaTotalDias
            End With

            Dim value As Integer = -1
            objBss = New Bussines.Registro.DocumentoJudicial

            If Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                value = objBss.Grabar_LM(objEnt)
            Else
                value = objBss.Grabar2(objEnt)
            End If

            Return value

        End Function
        Public Function AGrabar(EntDocJud As Entity.Registro.DocumentoJudicial, Optional _blnNuevoRegistro As Boolean = False) As Entity.Registro.DocumentoJudicial

            objEnt = New Entity.Registro.DocumentoJudicial
            objBss = New Bussines.Registro.DocumentoJudicial
            With objEnt
                .Codigo = Me._Codigo
                .DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionDeclaraConsentida  'Me.DocumentoTipo
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFechaRecepcion = Me.DocumentoFechaRecepcion
                .DocumentoFecha = Me.DocumentoFecha
                .DistritoJudicial = Me.DistritoJudicial
                .SalaJuzgado = Me.SalaJuzgado
                If Me.SalaJuzgado > 0 Then .TipoAutoridadJudicial = Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
                .JuezNombre = Me.JuezNombre
                .SecretarioNombre = Me.SecretarioNombre
                .Observacion = Me.Observacion
                .NumFolio = Me.NumFolio
                .NumLibro = Me.NumLibro
                .InternoId = Me._InternoID
                .InternoIngresoId = Me._InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .SentenciaConsentida = Me.SentenciaConsentida

                .SentenciaCadenaPerpetua = EntDocJud.SentenciaCadenaPerpetua
                .SentenciaTotalAnios = EntDocJud.SentenciaTotalAnios
                .SentenciaTotalMeses = EntDocJud.SentenciaTotalMeses
                .SentenciaTotalDias = EntDocJud.SentenciaTotalDias

                .Estado = Type.Enumeracion.enmEstadoDocumentoAnulado.Normal
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._TipoLicencia = Me._TipoLicencia
                .FlagTransferenciaSede = Me.FlagTransferSede

                .DocumentoNumeroTraslado = Me.NumeroResolucion
                .FechaResolucion = Me.ResolucionFecha
                .FechaRecepcionResolucion = Me.DocumentoFechaRecepcion

            End With

            objBss = New Bussines.Registro.DocumentoJudicial

            If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Then
                objEnt.Codigo = objBss.Grabar_LM(objEnt)
            Else
                objEnt.Codigo = objBss.GrabarV3(objEnt)
            End If

            Return objEnt

        End Function
        Public ObjNombresAsociadosCol As New Entity.Registro.Documento.NombresAsociadosCol
        Private objBssNA As Bussines.Registro.NombreAsociado = Nothing
        Public Property _DocumentoTipoId As Integer = -1
        Public Property _InternoNAIngresoInpeId() As Integer = -1
        Public Function AGrabarNA(DocumentoId As Integer, _blnNuevoRegistro As Boolean) As Integer
            'RESOLUCION NUEVO
            If Me._TipoLicencia = enmTipoLicencia.Carceleta _
                        Or Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                        Or Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                AgrabarNombresasociados_LM(DocumentoId, _blnNuevoRegistro)
            Else
                'AgrabarNombresasociados(Me._Codigo, _NuevoRegistro)
            End If

            Return Me._Codigo
        End Function
        Public Sub EliminarNombresasociados_LM(DocJudicialID As Integer, Nuevo As Boolean)
            objBssNA = New Bussines.Registro.NombreAsociado
            Dim objBssDocNA As New Bussines.Registro.Documento.NombresAsociados
            For Each ent As Entity.Registro.Documento.NombresAsociados In ObjNAEliminadosCol
                If ent.Audit_Eliminado = True Then
                    Select Case Me._TipoLicencia
                        Case enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.Carceleta
                            objBssDocNA.EliminarDoc_LM(ent, Me._Codigo, Me._InternoID, Me._InternoIngresoInpeId)
                        Case Else
                            objBssDocNA.Eliminar(ent.InternoNombreAsociadoID, Me._InternoID, Me._InternoIngresoId)
                    End Select
                End If
            Next
        End Sub
        Public Sub AgrabarNombresasociados_LM(DocJudicialID As Integer, Nuevo As Boolean)
            EliminarNombresasociados_LM(DocJudicialID, Nuevo)
            ' Me._InternoNAIngresoInpeId = NombresAsociadosNegativo_LM()
            Dim CodigoPrincipalNA As Integer = -1
            Dim bssInt As New Bussines.Registro.Interno
            Dim objInt As New Entity.Registro.Interno
            Dim blnCondicion As Boolean = False
            Dim intValue As Integer = -1
            Dim bssIntHist As New Bussines.Registro.InternoHistorico
            Dim IntHistorico As New Entity.Registro.InternoHistorico

            IntHistorico.InternoID = Me._InternoID
            Dim intIngresoInpeMayor As Integer = bssIntHist.Validar_IngresoInpeID(IntHistorico)
            Dim intCodigoNA As Integer = -1
            Dim bssDocNA As New Bussines.Registro.Documento.NombresAsociados
            For Each ob As Entity.Registro.Documento.NombresAsociados In ObjNombresAsociadosCol
                If ob.Audit_Eliminado = False Then
                    ob.FlagTransferenciaSede = Me.FlagTransferSede
                    '-----/* datos nombre asociado */
                    objBssNA = New Bussines.Registro.NombreAsociado
                    Dim objEnt As New Entity.Registro.NombreAsociado

                    objEnt.DocumentoNomAsociadoId = ob.Codigo 'reg_doc_IntNombreAsociado
                    objEnt.DocumentoJudicialID_NA = ob.Codigo
                    objEnt.Codigo = ob.InternoNombreAsociadoID 'nom_aso_id
                    objEnt.InternoID = Me._InternoID
                    objEnt.IngresoID = Me._InternoIngresoId
                    objEnt.IngresoInpeID = Me._InternoIngresoInpeId
                    objEnt.Principal = ob.NAPrincipal2
                    objEnt.ApellidoPaterno = ob.NAPaterno2
                    objEnt.ApellidoMaterno = ob.NAMaterno2
                    objEnt.Nombres = ob.NANombres2
                    objEnt.DocumentoJudicialID = DocJudicialID
                    objEnt.FlagTransferenciaSede = ob.FlagTransferenciaSede
                    objEnt.RegionID = Me._RegionID
                    objEnt.PenalID = Me._PenalID
                    objEnt.Estado = 1
                    Select Case ob.NAEstado
                        Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido
                            If Nuevo = True Then objEnt.Codigo = -1
                        Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Anulado
                            objEnt.Estado = 0
                        Case Type.Enumeracion.SubTipoDocJudicial.enumAccion.Ninguno
                            objEnt.Principal = ob.NAPrincipal
                            objEnt.ApellidoPaterno = ob.NAPaterno
                            objEnt.ApellidoMaterno = ob.NAMaterno
                            objEnt.Nombres = ob.NANombres
                    End Select
                    intCodigoNA = objBssNA.GrabarNA2_LM(objEnt)
                    '-----/* datos Documento nombre asociado */
                    If intCodigoNA > 0 Then
                        bssDocNA = New Bussines.Registro.Documento.NombresAsociados
                        Dim objEntDoc As New Entity.Registro.Documento.NombresAsociados
                        With objEntDoc
                            objEntDoc = ob
                        End With
                        objEntDoc.InternoID = Me._InternoID
                        objEntDoc.IngresoID = Me._InternoIngresoId
                        objEntDoc.IngresoInpeId = Me._InternoIngresoInpeId
                        objEntDoc.InternoNombreAsociadoID = intCodigoNA
                        objEntDoc.DocumentoJudicialID = DocJudicialID
                        objEntDoc.RegionID = Me._RegionID
                        objEntDoc.PenalID = Me._PenalID
                        If objEntDoc.NAEstado = Type.Enumeracion.SubTipoDocJudicial.enumAccion.Aniadido Then objEntDoc.NAPrincipal = -1
                        objEntDoc.Codigo = bssDocNA.Grabar_v2_LM(objEntDoc)
                        If objEntDoc.NAPrincipal2 = 1 Then
                            objEnt = New Entity.Registro.NombreAsociado
                            If Nuevo = True Then
                                If objEntDoc.NAEstado = enumAccion.Aclarado And objEntDoc.NAPrincipal = 1 And objEntDoc.NAPrincipal2 = 1 And blnCondicion = True Then
                                    If Me._InternoIngresoInpeId = intIngresoInpeMayor Then
                                        objEnt.ApellidoPaterno = objInt.ApellidoPaterno
                                        objEnt.ApellidoMaterno = objInt.ApellidoMaterno
                                        objEnt.Nombres = objInt.Nombres
                                        objEnt.Principal = 0
                                        objEnt.InternoID = Me._InternoID
                                        objEnt.IngresoID = Me._InternoIngresoId
                                        objEnt.IngresoInpeID = Me._InternoIngresoInpeId
                                        objEnt.Estado = ob.NAEstado
                                        objEnt.DocumentoJudicialID = DocJudicialID
                                        'objEnt2.FlagTransferenciaSede = Me.FlagTransferSede
                                        objEnt.RegionID = Me._RegionID
                                        objEnt.PenalID = Me._PenalID
                                        objBssNA.GrabarNA2_LM(objEnt)
                                    End If
                                End If
                            End If
                            CodigoPrincipalNA = intCodigoNA
                            Dim Valor As Integer = -1
                            Dim objBssInt As New Bussines.Registro.Interno
                            objEnt.Principal = 1
                            objBssNA = New Bussines.Registro.NombreAsociado
                            objEnt.NuevoNA = intCodigoNA
                            ''----------------swsws
                            If Me._InternoIngresoInpeId = intIngresoInpeMayor Then
                                bssDocNA.ActualizarNombrePrincipal_LM(objEntDoc)
                                IntHistorico.InternoID = Me._InternoID
                                IntHistorico.IngresoID = Me._InternoIngresoId
                                IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
                                IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                                IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                                IntHistorico.Nombres = objEntDoc.NANombres2
                                IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                                IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
                                bssIntHist.ActualizarInternoHistorico_LM(IntHistorico)
                            Else
                                Dim intAclaratoriaSup As Integer = bssDocNA.ValidarDocumentoAclarados_LM(Me._InternoID, Me._InternoIngresoInpeId)
                                If intAclaratoriaSup = 0 Then
                                    objInt = New Entity.Registro.Interno
                                    objInt.FlagTransferenciaSede = Me.FlagTransferSede
                                    objInt.Codigo = Me._InternoID
                                    objInt.IngresoID = Me._InternoIngresoId
                                    objInt.IngresoInpeId = Me._InternoIngresoInpeId
                                    objInt.ApellidoPaterno = objEntDoc.NAPaterno2
                                    objInt.ApellidoMaterno = objEntDoc.NAMaterno2
                                    objInt.Nombres = objEntDoc.NANombres2
                                    objInt.DocJudIDAux = objEntDoc.DocumentoJudicialID
                                    objBssInt.GrabarApellidosyNombres_LM(objInt)

                                    IntHistorico.InternoID = Me._InternoID
                                    IntHistorico.IngresoID = Me._InternoIngresoId
                                    IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
                                    IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                                    IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                                    IntHistorico.Nombres = objEntDoc.NANombres2
                                    IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                                    IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
                                    bssIntHist.ActualizarInternoHistorico_LM(IntHistorico)
                                Else
                                    IntHistorico.InternoID = Me._InternoID
                                    IntHistorico.IngresoID = Me._InternoIngresoId
                                    IntHistorico.IngresoInpeId = Me._InternoIngresoInpeId
                                    IntHistorico.ApellidoPaterno = objEntDoc.NAPaterno2
                                    IntHistorico.ApellidoMaterno = objEntDoc.NAMaterno2
                                    IntHistorico.Nombres = objEntDoc.NANombres2
                                    IntHistorico.DocJudIDAux = objEntDoc.DocumentoJudicialID
                                    IntHistorico.FlagTransferenciaSede = Me.FlagTransferSede
                                    bssIntHist.ActualizarInternoHistoricoxDocumento_LM(IntHistorico)
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            Dim DocJudicialMayor As Integer = bssDocNA.ValidarDocumento(Me._InternoID, Me._InternoIngresoInpeId, intCodigoNA)

            If DocJudicialMayor > 0 Then
                'bssDocNA.ActualizarUltimoNA_LM(-1, Me._InternoID, Me._InternoIngresoInpeId, DocJudicialMayor, Nothing, Me.FlagTransferSede)
            End If
        End Sub
        'Public Property ProlonDetencionValor As Integer
        '    Get
        '        Return Val(txtCant.Text)
        '    End Get
        '    Set(value As Integer)
        '        If value = 0 Then
        '            txtCant.Text = ""
        '        Else
        '            txtCant.Text = value
        '        End If
        '    End Set
        'End Property
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            ComboDistritoJudicial()
            ComboSalaJuzgado()

            Select Case Me.DocumentoTipo
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia


                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida
                    Me.chkConsentida.Checked = True
                    Me.chkConsentida.Enabled = False


                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD
                    Me.chkConsentida.Visible = True
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.EjecutoriaSuperiorPLD_Consentida
                    Me.chkConsentida.Visible = True
                    Me.chkConsentida.Checked = True
                    Me.chkConsentida.Enabled = False

            End Select

            Select Case Me._TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.PenalLimaMetropolitana, enmTipoLicencia.RegionLimaMetropolitana
                    If _RegionID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado el valor de IdRegión")
                    End If
                Case Else
                    If _RegionID < 1 Or _PenalID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("ERROR: Verifique que se haya pasado los valores del IdInterno, IdPenal e IdRegión")
                    End If
            End Select
            ' lblResolucion.Visible = False
            ' txtResolucion.Visible = False
            'ckbFecResolucion.Visible = False
            Me.txtNumOficio.Focus()
            If Me._Codigo = -1 Then
                Me._blnNuevo = True
            Else
                Listar()
            End If
        End Sub
        Public Sub _LoadUsc()

            ValoresxDefault()

        End Sub
        Private Sub generaEventoEsInimputable()

            RaiseEvent _Click_esInimputables(Me._esInimputable)

        End Sub
        Public Sub ActivarControlesInimputables()
            rdbSi.Checked = True
            generaEventoEsInimputable()
        End Sub
        Dim objExpedienteCol As Entity.Registro.ExpedienteCol

        Dim intContador As Integer = 0
        Private Sub AccionCheked()

        End Sub
        Public Sub ActivarControlCkbExtramuro(ObjAgraviadoCol As Entity.Registro.AgraviadoCol)
            Select Case Me.DocumentoTipo
                Case Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Sentencia,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.EjecutoriaSuprema,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.EjecutoriaSuperior,
                         Type.Enumeracion.DocumentoJudicial.enmTipoDocumento.Resolucion


            End Select
        End Sub
        Public Sub ListarControlExtramuro(Extramuro As Integer)

        End Sub
#End Region

        Private Sub cbbDistritoJud__SelectedIndexChanged()

            'jmr, 05.05.2020
            If blnComboDistritoJud = True Then
                If Me.DistritoJudicial > 0 Then
                    ComboSalaJuzgado()
                End If
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


        Private Sub UscComboSala1__Click_Buscar() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado

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

        Private Sub dtpFecSentencia__ValueChanged()

        End Sub

        Private Sub dtpFecSentencia_Load(sender As System.Object, e As System.EventArgs)

        End Sub


        Private Sub txtObservacion_TextChanged(sender As System.Object, e As System.EventArgs)

        End Sub

        Private Sub btnAddNombreasociado_Click(sender As Object, e As EventArgs)
            RaiseEvent _Click_VerNombresasociados()
        End Sub


        'Private Sub rbtSi_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSi.CheckedChanged, rdbNo.CheckedChanged
        '    generaEventoEsInimputable()
        'End Sub

        Private Sub rdbSi_Click(sender As Object, e As EventArgs) Handles rdbSi.Click, rdbNo.Click
            'validarExpedienteReferenciado()
            generaEventoEsInimputable()
            Me.txtResolucion.Focus()

        End Sub

        Private Sub ckbResolucion_CheckedChanged(sender As Object, e As EventArgs) Handles ckbResolucion.CheckedChanged
            If ckbResolucion.Checked = True Then
                Me.txtResolucion.Text = "NO INDICA"
                Me.txtResolucion.Enabled = False
            Else
                Me.txtResolucion.Text = ""
                Me.txtResolucion.Enabled = True
                Me.txtResolucion.Focus()
            End If
        End Sub

        Private Sub UscComboDistritoJudicial1__SelectedIndexChanged() Handles UscComboDistritoJudicial1._SelectedIndexChanged
            If blnComboDistritoJud = True Then
                If Me.DistritoJudicial > 0 Then
                    ComboSalaJuzgado()
                End If
            End If
        End Sub

        Private Sub UscComboDistritoJudicial1__Click_Buscar() Handles UscComboDistritoJudicial1._Click_Buscar
            RaiseEvent _Click_FrmBusquedaAutoridadJudicial()
        End Sub

        Dim Valor As Boolean = False

        Public Sub EvaluarExtramuroFalse()
            If intContador > 0 Then
                If Me._Codigo > 0 Then
                    If Valor = False Then
                        Dim blnValor As Boolean = False
                        Dim blnExtramuro As Boolean = False
                        Dim bss As New Bussines.Registro.Expediente
                        Dim objCol As New Entity.Registro.ExpedienteCol
                        Dim obj As New Entity.Registro.Expediente
                        obj.InternoID = Me._InternoID
                        obj.IngresoInpeId = Me._InternoIngresoInpeId
                        objCol = bss.ListarValidar_Extramuro(obj)
                        For Each obj1 As Entity.Registro.Expediente In objCol
                            If obj1.LibertadTipoID > 0 Then
                                blnValor = True
                            End If
                            If obj1.Extramuro = 1 Then
                                blnExtramuro = True
                            End If
                        Next
                        If blnValor = True And blnExtramuro = True Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("La acción no está permitida porque ocasionará inconsistencia," + Chr(13) +
                                                                                "dado que ha sido tomado en cuenta para generar la orden de Libertad.")

                        End If
                    End If
                End If
            End If
            intContador = intContador + 1
        End Sub

        Private Sub ckbFecResolucion_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFecResolucion.CheckedChanged
            If ckbFecResolucion.Checked = True Then
                Me.dtpFechaResolucion.Value = Nothing
                Me.dtpFechaResolucion.Enabled = False
            Else
                Me.dtpFechaResolucion.Value = Nothing
                Me.dtpFechaResolucion.Enabled = True
                Me.dtpFechaResolucion.Focus()
            End If
        End Sub

        Private Sub ckbFecRecepcion_CheckedChanged(sender As Object, e As EventArgs) Handles ckbFecRecepcion.CheckedChanged
            If ckbFecRecepcion.Checked = True Then
                Me.dtpFechaRecepResolucion.Value = Nothing
                Me.dtpFechaRecepResolucion.Enabled = False
            Else
                Me.dtpFechaRecepResolucion.Value = Nothing
                Me.dtpFechaRecepResolucion.Enabled = True
                Me.dtpFechaRecepResolucion.Focus()
            End If
        End Sub
    End Class
End Namespace