Namespace Registro.Expediente.v5
    Public Class frmExpedientePopup3
        Private objBss As Bussines.Registro.Expediente = Nothing
        Private objBssPad As Bussines.Registro.InternoExpedientePadre = Nothing
        Private objEnt As Entity.Registro.Expediente = Nothing
        Private objEntExpediente As Entity.Registro.Expediente
#Region "Propiedades_Parametricas"
        Public Property _Codigo As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property _IngresoID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _ExpedienteItem As Integer = -1
        Public Property _ExpedienteIDAux As Integer = -1
        Public Property _objEntExpediente() As Entity.Registro.Expediente = Nothing
        Public Property _objEntExpedienteAux() As Entity.Registro.Expediente = Nothing
        Public Property _objEntExpedienteCol() As New Entity.Registro.ExpedienteCol
        Public Property _TemporalNuevo As Boolean = False
        Public Property _TipoFormu As Boolean = False
        Public Property _Contador As Integer = -1
        Public Property _TipoDocumento As Integer = -1
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
#End Region
#Region "Propiedades_Publicas"
        Public Property _TipoFormulario() As Type.Formulario.Registro.UserControl = Type.Formulario.Registro.UserControl.Resoluciones
        Private blnSwitch As Boolean = False
#End Region
#Region "Propiedades_Expediente"
        Public Property _TipoAutJudicialID() As Integer =Type.Enumeracion .Movimiento .EnumTipoAutoridad .AutoridadJudicial 

        Public Property DistritoJudicialID() As Integer
            Get
                Try
                    Return Me.UscComboDistritoJudicial1._selectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
            Set(ByVal value As Integer)
                Me.UscComboDistritoJudicial1._selectedValue = value
            End Set
        End Property
        Private ReadOnly Property DistritoJudicialNombre() As String
            Get
                Try
                    Return Me.UscComboDistritoJudicial1._selectedText
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public Property SalaJudicialID() As Integer
            Get
                Try
                    Return UscComboSala1._SalaJuzgadoID
                Catch ex As Exception
                    Return -1
                End Try

            End Get
            Set(ByVal value As Integer)
                Me.UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property
        Private strSalaJudicialNombre As String = ""
        Private Property SalaJudicialNombre As String
            Get
                strSalaJudicialNombre = Me.UscComboSala1._SalaNombre
                Return strSalaJudicialNombre
            End Get
            Set(value As String)
                strSalaJudicialNombre = value
            End Set
        End Property
        Private Property ExpedienteJuez() As String
            Get
                Return Me.txtJuez.Text
            End Get
            Set(ByVal value As String)
                Me.txtJuez.Text = value
            End Set
        End Property
        Public Property ExpedienteSecretario() As String
            Get
                Return Me.txtSecretario.Text
            End Get
            Set(ByVal value As String)
                Me.txtSecretario.Text = value
            End Set
        End Property
        Private Property NumeroExp() As String
            Get
                Return Me.txtNumExp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumExp.Text = value
            End Set
        End Property
        Private Property ExpedienteFechaDocRecep() As Long
            Get
                Return Me.dteExpFechaRecepDoc.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dteExpFechaRecepDoc.ValueLong = value
            End Set
        End Property
        Private Property FechaExp() As Long
            Get
                Return Me.dtpFechaExp.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaExp.ValueLong = value
            End Set
        End Property
        Private Property SituacionJuridica() As Integer
            Get
                Return Me.cbbSitJuridica.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbSitJuridica.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property SituacionJuridicaNombre() As String
            Get
                Return Me.cbbSitJuridica.Text
            End Get
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtObservacion.Text = value
            End Set
        End Property
        'Private Property AutoridadOtroCargo() As String
        '    Get
        '        Return Me.txtOtraAutoridadCargo.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtOtraAutoridadCargo.Text = value
        '    End Set
        'End Property
        'Private Property AutoridadOtroNombre() As String
        '    Get
        '        Return Me.txtOtraAutoridadNombre.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.txtOtraAutoridadNombre.Text = value
        '    End Set
        'End Property
        Private ReadOnly Property Flagrancia() As Boolean
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
        Private Property intValor As Integer = 0
#End Region
#Region "Combo"
        Private Sub ComboSalaJuzgado()
            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub
        Private Sub ComboVarios()
            'Me.cbbTipoAutJud.SelectedValue = 1

            ComboDistritoJudicial()
            If Me.DistritoJudicialID > 0 Then
                ComboSala()
            End If

            Me.cbbSitJuridica.LoadUsc()
            Me.cbbSitJuridica.SelectedValue = -1
        End Sub
        Private Sub ComboDistritoJudicial()
            'Me.UscComboDistritoJudicial1._Combo()
            'If Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta Or Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana Or _
            '    Me._TipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
            '    Me.UscComboDistritoJudicial1._selectedValue = 2  'Region de Lima
            'End If
            With Me.UscComboDistritoJudicial1
                ._Todos = True
                ._TodosMensaje = "[SELECCIONAR DISTRITO JUDICIAL]"
                ._Combo()
                ._selectedValue = -1
            End With
        End Sub
        Private Sub ComboSala()

            With Me.UscComboSala1
                ._DistritoJudicialID = Me.DistritoJudicialID
                ._Combo()
            End With
        End Sub
#End Region
#Region "Listar"
        Private Sub ListarTemporal()
            Dim intSitJur As Integer = fn_TipoDocumento(Me._TipoDocumento)
            If intSitJur > 0 Then
                cbbSitJuridica.Enabled = False
                Me.SituacionJuridica = intSitJur
            End If
            If _TemporalNuevo = True Then
                Exit Sub
            Else
                Dim CodigoExpAuxiliar As Integer = -1
                If _objEntExpediente Is Nothing Then

                    Exit Sub
                Else
                    If Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Then
                        CodigoExpAuxiliar = _objEntExpediente.Codigo
                        With _objEntExpedienteAux
                            Me._Codigo = .Codigo
                            Me._InternoID = .InternoID
                            Me._IngresoID = .IngresoID
                            Me._InternoIngresoInpeId = .IngresoInpeId
                            Me._ExpedienteItem = .ExpedienteItem
                            'campos
                            Me._TipoAutJudicialID = .TipoAutoridadJudicialID
                            Me.DistritoJudicialID = .AutoridadJudicialID
                            Me.SalaJudicialID = .SalaJudicialID
                            If Me._TipoAutJudicialID = 1 Then
                                Me.SalaJudicialID = .SalaJudicialID
                                Me.SalaJudicialNombre = .SalaJudicialNombre
                                Me.ExpedienteJuez = .ExpedienteJuez
                                Me.ExpedienteSecretario = .ExpedienteSecretario
                            Else
                                If .SalaJudicialID > 0 Then
                                    Me._TipoAutJudicialID = 1
                                    Me.SalaJudicialID = .SalaJudicialID
                                    Me.SalaJudicialNombre = .SalaJudicialNombre
                                    Me.ExpedienteJuez = .ExpedienteJuez
                                    Me.ExpedienteSecretario = .ExpedienteSecretario
                                Else
                                    If .TipoAutoridadJudicialID < 1 Then
                                        Me._TipoAutJudicialID = 2
                                    End If
                                End If
                            End If
                            Me.NumeroExp = .ExpedienteNumero
                            Me.ExpedienteFechaDocRecep = .ExpedienteFechaDocRecepcion
                            Me.FechaExp = .ExpedienteFecha
                            Me.SituacionJuridica = .SituacionJuridicaID
                            Me.ckbFlagrancia.Checked = .Flagrancia
                            Me.Observacion = .Observacion
                            If .Codigo > 0 Then
                                objBssPad = New Bussines.Registro.InternoExpedientePadre
                                Dim EntExp As New Entity.Registro.InternoExpedientePadre
                                EntExp.Codigo = IIf(Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento, CodigoExpAuxiliar, .Codigo)
                                EntExp.InternoID = Me._InternoID
                                Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol

                                EntColPad = objBssPad.ListarGrilla(EntExp)

                                For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                                    If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                                        blnSwitch = True
                                        Exit For
                                    End If
                                Next
                                If blnSwitch = True Then
                                    Me.lblMensaje.Text = "El expediente ha sido referenciado"
                                    Me.lblMensaje.Visible = True
                                    InhabilitarControles()
                                End If
                            End If
                        End With
                    Else
                        With _objEntExpediente
                            Me._Codigo = .Codigo
                            Me._InternoID = .InternoID
                            Me._IngresoID = .IngresoID
                            Me._InternoIngresoInpeId = .IngresoInpeId
                            Me._ExpedienteItem = .ExpedienteItem
                            'campos
                            Me._TipoAutJudicialID = .TipoAutoridadJudicialID
                            Me.DistritoJudicialID = .AutoridadJudicialID
                            Me.SalaJudicialID = .SalaJudicialID
                            If Me._TipoAutJudicialID = 1 Then
                                Me.SalaJudicialID = .SalaJudicialID
                                Me.SalaJudicialNombre = .SalaJudicialNombre
                                Me.ExpedienteJuez = .ExpedienteJuez
                                Me.ExpedienteSecretario = .ExpedienteSecretario
                            Else
                                If .SalaJudicialID > 0 Then
                                    Me._TipoAutJudicialID = 1
                                    Me.SalaJudicialID = .SalaJudicialID
                                    Me.SalaJudicialNombre = .SalaJudicialNombre
                                    Me.ExpedienteJuez = .ExpedienteJuez
                                    Me.ExpedienteSecretario = .ExpedienteSecretario
                                Else
                                    If .TipoAutoridadJudicialID < 1 Then
                                        Me._TipoAutJudicialID = 2
                                    End If
                                End If
                            End If
                            Me.NumeroExp = .ExpedienteNumero
                            Me.ExpedienteFechaDocRecep = .ExpedienteFechaDocRecepcion
                            Me.FechaExp = .ExpedienteFecha
                            Me.SituacionJuridica = .SituacionJuridicaID
                            If Me._TipoDocumento = 14 And Me.SituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado Then
                                cbbSitJuridica.Enabled = True
                            End If
                            Me.ckbFlagrancia.Checked = .Flagrancia
                            Me.Observacion = .Observacion
                            If .Codigo > 0 Then
                                objBssPad = New Bussines.Registro.InternoExpedientePadre
                                Dim EntExp As New Entity.Registro.InternoExpedientePadre
                                EntExp.Codigo = IIf(Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento, CodigoExpAuxiliar, .Codigo)
                                EntExp.InternoID = Me._InternoID
                                Dim EntColPad As New Entity.Registro.InternoExpedientePadreCol
                                EntColPad = objBssPad.ListarGrilla(EntExp)

                                For Each EntCodi As Entity.Registro.InternoExpedientePadre In EntColPad
                                    If EntExp.Codigo = EntCodi.InternoExpedienteRefPadreId Then
                                        blnSwitch = True
                                        Exit For
                                    End If
                                Next

                                If blnSwitch = True Then
                                    Me.lblMensaje.Text = "El expediente ha sido referenciado"
                                    Me.lblMensaje.Visible = True
                                    InhabilitarControles()
                                End If
                            End If
                        End With

                    End If

                End If
            End If
        End Sub
#End Region
#Region "Accion"
        Private Function fn_TipoDocumento(TipoID As Integer)
            Dim intValor As Integer = -1
            Select Case TipoID
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Queda, _
                    Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Revocatoria_de_Libertad, _
                    Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Libertad
                    intValor = -1
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia,
                     17, 18, 19, 20, 21, 22, 23, 24, 25, 27, 29, 36, 69
                    intValor = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                Case Else
                    intValor = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
            End Select
            Return intValor
        End Function
        Private Sub InhabilitarControles()
            txtNumExp.ReadOnly = True
            txtJuez.ReadOnly = True
            txtSecretario.ReadOnly = True
            txtObservacion.ReadOnly = True
            UscComboDistritoJudicial1.Enabled = False
            cbbSitJuridica.Enabled = False
            UscComboSala1.Enabled = False
            dteExpFechaRecepDoc.Enabled = False
            dtpFechaExp.Enabled = False
            ckbFlagrancia.Enabled = False
            btnOk.Enabled = False
        End Sub
        Private Function Validar() As Boolean
            Dim blnValue As Boolean = True
            '/*numero exp
            If Me.NumeroExp.Length < 1 Or Me.NumeroExp = "" Then
                MessageBox.Show("Ingrese numero de expediente, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.txtNumExp.Focus()
                Return blnValue
            End If
            '/*fecha exp
            If Me.FechaExp < 1 Then
                MessageBox.Show("Ingrese fecha de expediente, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.dtpFechaExp.Focus()
                Return blnValue
            End If
            '/*fecha validacion
            If Me.ExpedienteFechaDocRecep < 1 Then
                MessageBox.Show("Ingrese fecha de recepcion del expediente, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.dteExpFechaRecepDoc.Focus()
                Return blnValue
            End If
            '/*comparacion de fechas*/
            If Me.FechaExp > Me.ExpedienteFechaDocRecep Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de documento no puede ser mayor que la fecha de recepcion")
                blnValue = False
                Me.dtpFechaExp.Focus()
                Return blnValue
            End If
            '/*autoridad judicial
            If Me._TipoAutJudicialID = 1 Then
                If Me.DistritoJudicialID < 1 Then
                    MessageBox.Show("Seleccione la Autoridad Judicial, de la ficha Expediente", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    blnValue = False
                    Me.UscComboDistritoJudicial1.Focus()
                    Return blnValue
                End If
                '*sala judicial
                If Me.SalaJudicialID < 1 Then
                    MessageBox.Show("Seleccione la Sala Judicial, de la ficha Expediente", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    blnValue = False
                    Me.UscComboSala1.Focus()
                    Return blnValue
                End If
                If Me.ExpedienteSecretario = "" Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los datos del secretario")
                    blnValue = False
                    Me.txtSecretario.Focus()
                    Return blnValue
                End If
            End If

            '*sit juridica
            If Me.SituacionJuridica < 1 Then
                MessageBox.Show("Seleccione la Situacion Juridica, de la ficha Expediente", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.cbbSitJuridica.Focus()
                Return blnValue
            Else
                Dim strMensaje As String = ResolucionNombre(Me._TipoDocumento)
                Select Case Me._TipoDocumento
                    Case 17, 18, 19, 20, 21, 22, 23, 24, 25, 27, 29
                        If Me.SituacionJuridica <> 2 Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & " solo puede tener situacion juridica [Sentenciado]")
                            blnValue = False
                            Return blnValue
                        End If
                End Select
            End If
            '/Solo ejecuta para Aclaratorias y avocamientos
            Dim blnValor As Boolean = False
            For Each objEnt As Entity.Registro.Expediente In _objEntExpedienteCol
                If Me.NumeroExp = objEnt.ExpedienteNumero Then
                    blnValor = True
                End If
            Next
            If blnValor = True Then
                MessageBox.Show("El expediente [" & Me.NumeroExp & "] ya existe en la lista, cambie los datos", _
                    Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                blnValue = False
                Me.txtNumExp.Focus()
                Return blnValue
            End If
            Return blnValue
        End Function
        Private Function ValidarResolucion() As Boolean
            If Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria Or _
               Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio Or _
               Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento Or _
               Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion Or _
                Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia Or _
                Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria Or _
              Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Adecuacion_Pena Or _
              Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Conmutacion_Pena Or _
              Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Sustitucion_Pena Or _
              Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior Or _
              Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema Then
                Dim strMensaje As String = ResolucionNombre(Me._TipoDocumento)
                If _objEntExpedienteCol.Count = 0 Then
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La resolucion de " & strMensaje & " solo puede tener un expediente, operacion cancelada")
                    Return False
                End If
            End If
            Return True
        End Function
        Private Function ResolucionNombre(intResID As Integer) As String
            Dim strNombre As String = ""
            Select Case intResID
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Aclaratoria
                    strNombre = "Aclaratoria"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ampliacion_Autoapertorio
                    strNombre = "Ampliacion_Autoapertorio"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Avocamiento
                    strNombre = "Avocamiento"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Prolongacion_Detencion
                    strNombre = "Prolongacion_Detencion"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia
                    strNombre = "Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sentencia_Aclaratoria
                    strNombre = "Aclaratoria de Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Conmutacion_Pena
                    strNombre = "Sent_Conmutacion_Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Adecuacion_Pena
                    strNombre = "Sent_Adecuacion_Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sent_Sustitucion_Pena
                    strNombre = "Sent_Sustitucion_Pena"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Superior
                    strNombre = "Ejecutoria_Superior"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ejecutoria_Suprema
                    strNombre = "Ejecutoria_Suprema"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.ResolucionConsentida
                    strNombre = "Sentencia Consentida"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Sumatoria_de_Sentencia
                    strNombre = "Sumatoria de Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Integracion_Sentencia
                    strNombre = "Integracion de Sentencia"
                Case Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Refundicion_de_Sentencia
                    strNombre = "Refundicion de Sentencia"
            End Select
            Return strNombre
        End Function
        Private Sub AGrabar()
            If blnSwitch = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El expediente ha sido referenciado, operacion cancelada")
            Else
                If Validar() = True Then
                    If ValidarResolucion() = True Then
                        If _objEntExpediente Is Nothing Then
                            _objEntExpediente = New Entity.Registro.Expediente
                        End If

                        With Me._objEntExpediente
                            .Codigo = Me._Codigo
                            .InternoID = Me._InternoID
                            .IngresoInpeId = Me._InternoIngresoInpeId
                            .IngresoID = Me._IngresoID
                            .ExpedienteItem = Me._ExpedienteItem
                            'campos
                            .TipoAutoridadJudicialID = Me._TipoAutJudicialID
                            If .TipoAutoridadJudicialID = 1 Then
                                .AutoridadJudicialID = Me.DistritoJudicialID
                                .AutoridadJudicialNombre = Me.DistritoJudicialNombre
                                .SalaJudicialID = Me.SalaJudicialID
                                .SalaJudicialNombre = Me.SalaJudicialNombre
                                .ExpedienteJuez = Me.ExpedienteJuez
                                .ExpedienteSecretario = Me.ExpedienteSecretario

                                .AutoridadOtro = ""
                                .AutoridadOtroCargo = ""
                            Else
                                .AutoridadJudicialID = -1
                                '.AutoridadJudicialNombre = Me.AutoridadOtroNombre
                                .SalaJudicialID = -1
                                '.SalaJudicialNombre = Me.AutoridadOtroCargo
                                .ExpedienteJuez = ""
                                .ExpedienteSecretario = ""

                                '.AutoridadOtro = Me.AutoridadOtroNombre
                                '.AutoridadOtroCargo = Me.AutoridadOtroCargo
                            End If
                            .ExpedienteNumero = Me.NumeroExp
                            .ExpedienteFechaDocRecepcion = Me.ExpedienteFechaDocRecep
                            .ExpedienteFecha = Me.FechaExp
                            .SituacionJuridicaNombre = Me.SituacionJuridicaNombre
                            .SituacionJuridicaID = Me.SituacionJuridica
                            .Flagrancia = Me.Flagrancia
                            .Observacion = Me.Observacion
                        End With
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End Sub
#End Region
#Region "Permisos"
        Private Sub Usuario_Permiso()

            Dim blnSalir As Boolean = False
            Dim blnGrabar As Boolean = False

            Select Case Me._TipoFormulario
                Case Type.Formulario.Registro.UserControl.ListadoExpediente
                    InhabilitarControles()
                    blnSalir = True
                Case Type.Formulario.Registro.UserControl.Resoluciones
                    blnGrabar = True
            End Select

            Me.pnlSalir.Visible = blnSalir
            Me.pnlGrabarDatos.Visible = blnGrabar
            Me.btnOk.Visible = Me._FormEscritura
            If Me._TipoDocumento = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.OrdenTraslado_HospitalMental Then
                ' Me.btnOk.Enabled = False
            End If
        End Sub
#End Region
#Region "FRM"
        Private Sub FRM_BusquedaAutoridadJudicial()

            Dim frm As New Mantenimiento.Busqueda.frmDistritoJudicialPopup
            With frm
                If .ShowDialog = DialogResult.OK Then
                    Me.DistritoJudicialID = .getCodigo
                End If
            End With

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()
         
            ComboVarios()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoExpediente)
            Me.btnOk.Enabled = Me._TipoFormulario
        End Sub
#End Region


        Private Sub frmExpedientePopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()
            ListarTemporal()
            Usuario_Permiso()

            Me.txtNumExp.Focus()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AGrabar()
        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub txtNumExp_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumExp.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        'Private Sub cbbTipoAutJud__SelectedIndexChanged()
        '    If Me._TipoAutJudicialID = 1 Then

        '        PnlAutoridadJudicial.Visible = True
        '    Else
        '        'PnlOtraAutoridad.Visible = True
        '        'PnlOtraAutoridad.Enabled = True
        '        PnlAutoridadJudicial.Visible = False
        '        Me.DistritoJudicialID = -1
        '        Me.SalaJudicialID = -1
        '        txtJuez.Text = ""
        '        txtSecretario.Text = ""
        '    End If
        'End Sub

        Private Sub UscComboSala1__Click_Buscar()

            Me.DistritoJudicialID = Me.UscComboSala1._DistritoJudicialID
            Me.SalaJudicialID = Me.UscComboSala1._SalaJuzgadoID

        End Sub

        Private Sub UscComboSala1__Click_Buscar_1() Handles UscComboSala1._Click_Buscar
            Me.DistritoJudicial = UscComboSala1._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = UscComboSala1._SalaJuzgadoID_Seleccionado
        End Sub
        Private Property DistritoJudicial() As Integer
            Get
                Return UscComboDistritoJudicial1._selectedValue
            End Get
            Set(value As Integer)
                UscComboDistritoJudicial1._selectedValue = value
            End Set
        End Property

        Private Property SalaJuzgado() As Integer
            Get
                Return UscComboSala1._SalaJuzgadoID
            End Get
            Set(value As Integer)
                UscComboSala1._SalaJuzgadoID = value
            End Set
        End Property

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub ckbFlagrancia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ckbFlagrancia.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub UscComboSala1__ClicK_VerFormulario() Handles UscComboSala1._Click_Buscar
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.DistritoJudicialID
                If .ShowDialog = DialogResult.OK Then
                    Me.DistritoJudicialID = ._DistritoJudicialID
                    Me.SalaJudicialID = ._GrillaSalaID
                    Me.txtJuez.Focus()
                End If
            End With
        End Sub

        Private Sub dtpFechaExp__ValueChanged() Handles dtpFechaExp._ValueChanged
            With dtpFechaExp
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dtpFechaExp_Validated(sender As Object, e As System.EventArgs) Handles dtpFechaExp.Validated
            With dtpFechaExp
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dteExpFechaRecepDoc__ValueChanged() Handles dteExpFechaRecepDoc._ValueChanged
            With dteExpFechaRecepDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub dteExpFechaRecepDoc_Validated(sender As Object, e As System.EventArgs) Handles dteExpFechaRecepDoc.Validated
            With dteExpFechaRecepDoc
                Dim Valor As String = .Value
                If IsDate(Valor) Then
                    If .Value > Now() Then
                        .Value = Nothing
                        .Focus()
                    End If
                End If
            End With
        End Sub

        Private Sub frmExpedientePopup3_RightToLeftLayoutChanged(sender As Object, e As EventArgs) Handles Me.RightToLeftLayoutChanged

        End Sub

        Private Sub txtJuez_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJuez.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        End Sub

        Private Sub txtSecretario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSecretario.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If

        End Sub

        Private Sub UscComboDistritoJudicial1__SelectedIndexChanged() Handles UscComboDistritoJudicial1._SelectedIndexChanged

            If Me.DistritoJudicialID > 0 Then
                ComboSala()
            End If

        End Sub

        Private Sub UscComboDistritoJudicial1__Click_Buscar() Handles UscComboDistritoJudicial1._Click_Buscar
            FRM_BusquedaAutoridadJudicial()
        End Sub
    End Class
End Namespace
