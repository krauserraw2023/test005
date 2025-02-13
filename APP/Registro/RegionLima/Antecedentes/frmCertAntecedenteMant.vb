Imports Type.Enumeracion.Movimiento
Imports Type.Enumeracion.AntecedenteJudicial
Imports Type.Enumeracion.TipoTabla

Namespace Registro.Main.Antecedentes
    Public Class frmCertAntecedenteMant
        Private tmpVal As String = ""
        Dim listDetAJ As Entity.Registro.Antecedente.DetalleAntecedenteCol
#Region "propiedades"
        Public Property _Codigo As Integer = -1
        Public Property _TipoAntecedenteId As Integer = -1 '1=Negativo, 2 No reg pro pend con mand det, 2=Si reg proc pen con mand det
        Public Property _Imprimir As Boolean = False
        Public Property _Finalizado As Boolean = False

        Private Property JurisdiccionAmbito As Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud
            Get
                Dim id As enmAmbitoJurisdiccionAutJud = Type.Enumeracion.AntecedenteJudicial.enmAmbitoJurisdiccionAutJud.Ninguno
                Select Case cbbJurisDet.Text.ToUpper
                    Case "Lima".ToUpper
                        id = enmAmbitoJurisdiccionAutJud.Lima
                    Case "Callao".ToUpper
                        id = enmAmbitoJurisdiccionAutJud.Callao
                    Case "Lima y Callao".ToUpper
                        id = enmAmbitoJurisdiccionAutJud.Lima_Y_Callao
                    Case Else
                        id = enmAmbitoJurisdiccionAutJud.Ninguno
                End Select
                Return id
            End Get
            Set(value As enmAmbitoJurisdiccionAutJud)
                Select Case value
                    Case enmAmbitoJurisdiccionAutJud.Callao
                        cbbJurisDet.Text = "Callao"
                    Case enmAmbitoJurisdiccionAutJud.Lima
                        cbbJurisDet.Text = "Lima"
                    Case enmAmbitoJurisdiccionAutJud.Lima_Y_Callao
                        cbbJurisDet.Text = "Lima y Callao"
                    Case Else
                        cbbJurisDet.Text = ""
                End Select
            End Set
        End Property
        Private Property GlosaId()
            Get
                Return cboGlosa.SelectedValue
            End Get
            Set(value)
                cboGlosa.SelectedValue = value
            End Set
        End Property
        Private Property Anio As Integer = 0
        Private Property NumCorrelativo As Integer = 0
        Private Property PenalCodigo As Integer = 0
        Private Property FechaSolicitud() As Long
            Get
                Return CDate(lblFecSolicitud.Text).ToFileTime
            End Get
            Set(value As Long)
                lblFecSolicitud.Text = DateTime.FromFileTime(value).ToString("dd/MM/yyyy hh:mm tt")
            End Set
        End Property
        Private EstadoSolicitudId As Integer = -1
        Private Property EstadoSolicitud() As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud
            Get
                Return EstadoSolicitudId
            End Get
            Set(value As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud)
                EstadoSolicitudId = value.GetHashCode
                Select Case value
                    Case Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente
                        txtEstado.Text = "PENDIENTE"
                        txtEstado.BackColor = Color.FromArgb(249, 241, 151)
                    Case Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado
                        txtEstado.Text = "TERMINADO"
                        txtEstado.BackColor = Color.FromArgb(175, 184, 69)
                    Case Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Impreso
                        txtEstado.Text = "IMPRESO"
                        txtEstado.BackColor = Color.FromArgb(180, 223, 237)
                    Case Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado
                        txtEstado.Text = "ANULADO"
                        txtEstado.BackColor = Color.FromArgb(221, 68, 72)
                End Select
            End Set
        End Property
        Private Property DocumentoNumero As String
            Get
                Return txtNumDocumento.Text
            End Get
            Set(value As String)
                txtNumDocumento.Text = value
            End Set
        End Property
        Private Property DocumentoFecha As Long
            Get
                Return dtpFechaDocumento.ValueLong
            End Get
            Set(value As Long)
                dtpFechaDocumento.ValueLong = value
            End Set
        End Property
        Private Property MotivoSolicitudId As Integer
            Get
                Return cbbMotivoSolicitud.SelectedValue
            End Get
            Set(value As Integer)
                cbbMotivoSolicitud.SelectedValue = value
            End Set
        End Property
        Private Property TipoAutoridadId As Integer
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoAutJud.SelectedValue = value
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
        Private Property SalaJuzgado() As Integer
            Get
                Return cbbAutJudicial._SalaJuzgadoID
            End Get
            Set(value As Integer)
                cbbAutJudicial._SalaJuzgadoID = value
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
        Private Property EntidadSolicitante() As String
            Get
                Return txtEntidadSolicitante.Text
            End Get
            Set(value As String)
                txtEntidadSolicitante.Text = value
            End Set
        End Property
        Private Property InternoId As Integer = -1
        Private Property TipoGlosa As Type.Enumeracion.TipoGlosa
        Private Property CodigoInterno As String
            Get
                Return txtCodRPInterno.Text
            End Get
            Set(value As String)
                txtCodRPInterno.Text = value
            End Set
        End Property
        Private Property InternoApellidoPaterno
            Get
                Return txtApePatInt.Text
            End Get
            Set(value)
                txtApePatInt.Text = value
            End Set
        End Property
        Private Property InternoApellidoMaterno
            Get
                Return txtApeMatInt.Text
            End Get
            Set(value)
                txtApeMatInt.Text = value
            End Set
        End Property
        Private Property InternoNombres
            Get
                Return txtNomInt.Text
            End Get
            Set(value)
                txtNomInt.Text = value
            End Set
        End Property
        Private Property InternoNombresAsociados() As String
            Get
                Return txtNomAsociados.Text
            End Get
            Set(value As String)
                txtNomAsociados.Text = value
            End Set
        End Property

        Private Property Observacion As String
            Get
                Return txtObs.Text
            End Get
            Set(value As String)
                txtObs.Text = value
            End Set
        End Property
        Private Property SolicitanteRegionID() As Short
            Get
                Return Me.cbbRegion1.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbRegion1.SelectedValue = value
            End Set
        End Property
        Private Property SolicitantePenalID() As Short
            Get
                Return Me.cbbPenal.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
#End Region
#Region "Combo"

        Private Sub ComboTipoAutoridadJudicial()
            Dim ele As New List(Of Integer)
            If Me._Codigo = -1 Then 'solo para nuevos quitar poder judicial
                ele.Add(15) 'quitar el poder judicial
                cbbTipoAutJud.ListaIdsParaExcluir = ele
            End If

            cbbTipoAutJud.LoadUsc()
        End Sub
        Private Sub ComboDistritoJudicial()
            Me.cbbDistritoJud.LoadUsc()
        End Sub
        Private Sub ComboSalaJuzgado()
            With Me.cbbAutJudicial
                ._DistritoJudicialID = Me.DistritoJudicial
                ._Combo()
            End With
        End Sub
        Private Sub MotivoSolicitud()
            Dim ent As New Entity.Registro.Antecedente.MotivoSolicitudAntecedente
            ent.TipoAutoridadJudicialId = Me.TipoAutoridadId

            Dim list As New Entity.Registro.Antecedente.MotivoSolicitudAntecedenteCol
            list = (New Bussines.Registro.Antecedente.MotivoSolicitudAntecedente).Listar(ent)
            If list.Count = 0 Then
                cbbMotivoSolicitud.DataSource = Nothing
                Exit Sub
            End If

            Dim aux As New Entity.Registro.Antecedente.MotivoSolicitudAntecedente()
            aux.Codigo = -1
            aux.Motivo = "Seleccione....."
            list.Add(aux)
            With Me.cbbMotivoSolicitud
                .DataSource = list
                .DisplayMember = "Motivo"
                .ValueMember = "Codigo"
                '._Combo()
            End With
            cbbMotivoSolicitud.SelectedValue = -1
        End Sub
        Private Sub ComboRegion()
            With Me.cbbRegion1
                .ComboTipo = Type.Combo.ComboTipo.RegionInpe
                '.Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboRegionJurisdiccion()
            With Me.cbbRegionJurisdiccion
                ._Todos = False
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboPenal()
            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.SolicitanteRegionID
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = False
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboGlosa()
            cboGlosa.DataSource = (New Bussines.Globall.GlosaDocumento).Listar(Me._TipoGlosa)
            cboGlosa.ValueMember = "Codigo"
            cboGlosa.DisplayMember = "CodigoString"
        End Sub
#End Region
#Region "Otros"
        Private Sub listar()
            If Me._Codigo = -1 Then
                cboGlosa.SelectedIndex = 0
                cbbTipoAutJud.SelectedValue = -1
                lblFecSolicitud.Text = Now.ToString("dd/MM/yyyy hh:mm tt")
                Exit Sub
            End If



            Dim bs As New Bussines.Registro.Antecedente.SolicitudAntecedente
            Dim ent As Entity.Registro.Antecedente.SolicitudAntecedente
            ent = bs.Listar(Me._Codigo)
            With ent
                Me.CodigoInterno = ent.InternoCodigo
                Me.InternoId = ent.InternoId
                Me.InternoApellidoMaterno = ent.InternoApeMaterno
                Me.InternoApellidoPaterno = ent.InternoApePaterno
                Me.InternoNombres = ent.InternoNombres
                Me.InternoNombresAsociados = ent.InternoNombresAsociados
                Me.EstadoSolicitud = ent.EstadoSolicitudId
                Me.FechaSolicitud = ent.FechaSolicitud
                Me.TipoAutoridadId = ent.TipoAutoridadJudicial
                Me.MotivoSolicitudId = ent.MotivoSolicitudId
                Me.DocumentoNumero = ent.DocumentoNumero
                Me.DocumentoFecha = ent.DocumentoFecha
                Me.DistritoJudicial = ent.SolDistritoJudicialId
                Me.SalaJuzgado = ent.SolSalaJudicialId
                Me.SecretarioNombre = ent.SolNombreSecretario
                Me.Observacion = ent.Observacion
                Me.NumCorrelativo = ent.NumeroCorrelativo
                Me.PenalCodigo = ent.CodigoPenal
                Me._TipoAntecedenteId = ent.TipoAntecedenteId
                Me.GlosaId = ent.GlosaDocId
                Me.Anio = ent.Anio
                Me.SolicitanteRegionID = ent.SolicitanteRegionId
                Me.SolicitantePenalID = ent.SolicitantePenalId
                txtNumSolicitud.Text = ent.NumSolicitudStr
                Me.EntidadSolicitante = ent.SolNombreEntidad
                tmpVal = Me.EntidadSolicitante
                Me.JurisdiccionAmbito = ent.AmbitoJurisdiccionAut
                chkShowAnulados.CheckState = If(ent.IncluyeAnulaciones = 1, 1, 0)
                btnReporte.Enabled = True

                Select Case EstadoSolicitud
                    Case enmEstadoSolicitud.Anulado, enmEstadoSolicitud.Impreso
                        btnOk.Enabled = False
                        btnBuscarInterno.Enabled = False
                        chRegistroDirecto.Enabled = False
                        pnlShowAnulados.Enabled = False
                    Case enmEstadoSolicitud.Terminado
                        btnBuscarInterno.Enabled = False
                        chRegistroDirecto.Enabled = False
                        pnlShowAnulados.Enabled = False
                        If Me._TipoAntecedenteId = 1 And Me._Codigo > 0 Then
                            chRegistroDirecto.Checked = True
                            chRegistroDirecto.Enabled = False
                        End If

                End Select
                If EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                    'If ent.InternoId = -1 Then
                    '    btnBuscarInterno.Enabled = False
                    '    chRegistroDirecto.Checked = True
                    '    ActivarEdicionDatoPersona(False)
                    'Else
                    '    btnBuscarInterno.Enabled = True
                    '    ActivarEdicionDatoPersona(True)
                    'End If
                    'btnReporte.Enabled = False
                Else
                    'btnBuscarInterno.Enabled = False
                    'btnReporte.Enabled = True
                    'chRegistroDirecto.Enabled = False
                    'If Me._TipoAntecedenteId = 1 And Me._Codigo > 0 Then
                    '    chRegistroDirecto.Checked = True
                    '    chRegistroDirecto.Enabled = False
                    'End If
                End If
            End With

            'listar detalle

            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                litarDetalle()
            Else
                Dim detEnt As New Entity.Registro.Antecedente.DetalleAntecedente
                Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol

                detEnt.SolicitudAntecedenteId = Me._Codigo
                listDetAJ = (New Bussines.Registro.Antecedente.DetalleAntecedente).Listar(detEnt)
            End If

            Me.UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.Auditoria.EnumTipTabla.ANJ_MOV_SolicitudAntecedente)
        End Sub

        Private Sub litarDetalle()
            Dim bss As New Bussines.Registro.Antecedente.SolicitudAntecedente
            Dim list As Entity.Registro.Antecedente.DetalleAntecedenteCol

            list = bss.ListarDetalleAntecedentePositivo_LM(Me.InternoId, Me.JurisdiccionAmbito, Me.chkShowAnulados.Checked)

            If list.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno no cuenta con antecedentes.")
                txtCodRPInterno.Text = ""
                txtApePatInt.Text = ""
                txtApeMatInt.Text = ""
                txtNomInt.Text = ""
                txtNomAsociados.Text = ""
                Exit Sub
            Else
                listDetAJ = list
                Me.btnDetalleAJ.Visible = True
            End If

        End Sub

        Private Sub BuscarInterno()
            If cbbJurisDet.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione la jurisdicción.")
                Exit Sub
            End If

            Dim f As New Registro.Main.Antecedentes.frmBuscaInternoPopup()
            f._TipoAntecedenteId = _TipoAntecedenteId
            If f.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.InternoId = f._InternoId
                If Me._TipoAntecedenteId = 1 Then 'si es AJ Negativo
                    If (New Bussines.Registro.Antecedente.SolicitudAntecedente).EsAntecedenteNegativo(Me.InternoId) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Information("No es posible completar la operación, la persona seleccionada presenta antecedentes.")
                        Exit Sub
                    End If
                End If
                If Me._TipoAntecedenteId = 2 Then 'no presenta p.p.m.d.
                    If (New Bussines.Registro.Antecedente.SolicitudAntecedente).RegistraProcesoPendienteConMD(Me.InternoId, Me.JurisdiccionAmbito) = True Then
                        Legolas.Configuration.Aplication.MessageBox.Information("La persona seleccionada presenta procesos pendiente con mandatos de detención, debe generar su certificado positivo.")
                        Exit Sub
                    End If
                End If

                txtCodRPInterno.Text = f._CodRp
                txtApePatInt.Text = f._ApePat
                txtApeMatInt.Text = f._ApeMat
                txtNomInt.Text = f._Nombres

                Dim entNomAso As New Entity.Registro.NombreAsociado
                Dim entNomAsoCol As Entity.Registro.NombreAsociadoCol
                Dim s As String = ""

                entNomAso.InternoID = f._InternoId
                entNomAsoCol = (New Bussines.Registro.NombreAsociado).Listar(entNomAso)


                For Each o As Entity.Registro.NombreAsociado In entNomAsoCol
                    If o.Principal = 0 Then s = s & o.ApellidosyNombres & ","
                Next
                s = If(s.Trim.Length <= 1, "", s.Substring(0, s.Length - 1))
                txtNomAsociados.Text = If(s.Trim.Length = 0, "NO REGISTRA", s)

                Me.listDetAJ = Nothing

                If Me._TipoAntecedenteId = 3 Then ' solo si es positivo
                    litarDetalle()
                End If

            End If
        End Sub

        Private Sub ValoresxDefault()
            Select Case Me._TipoAntecedenteId
                Case 1
                    lblTitulo.Text = "CERTIFICADO NEGATIVO"
                    Me._TipoGlosa = Type.Enumeracion.TipoGlosa.AntecedenteJudicialNegativo
                    pnlJurisdiccion.Enabled = False
                    cbbRegionJurisdiccion.Enabled = True
                    cbbJurisDet.Enabled = True
                    cbbJurisDet.Text = "Lima y Callao"
                    btnBuscarInterno.Focus()
                Case 2
                    lblTitulo.Text = "CERTIFICADO NO REG. PROC. PENDIENTES CON MANDATO DE DETENCION"
                    Me._TipoGlosa = Type.Enumeracion.TipoGlosa.AntecedenteJudicialNoRPPMD
                    chRegistroDirecto.Visible = False
                    cbbJurisDet.Focus()
                Case 3
                    lblTitulo.Text = "CERTIFICADO POSITIVO"
                    Me._TipoGlosa = Type.Enumeracion.TipoGlosa.AntecedenteJudicialRPPMD
                    chRegistroDirecto.Visible = False
                    Label12.Visible = True
                    cboGlosa.Visible = True
                    btnDetalle.Visible = True
                    pnlShowAnulados.Visible = True
                    pnlShowAnulados.Enabled = True
                    cbbJurisDet.Focus()
            End Select

            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboSalaJuzgado()
            ComboRegion()
            ComboPenal()
            ComboGlosa()
            ComboRegionJurisdiccion()


            Me.TipoAutoridadId = -1
            Me.MotivoSolicitudId = -1
            Me.DistritoJudicial = -1

            cbbAutJudicial._SalaJuzgadoID = -1
            cbbAutJudicial._DistritoJudicialID = -1
            cbbAutJudicial._SalaJuzgadoID_Seleccionado = -1
            cbbRegionJurisdiccion.SelectedValue = 3
        End Sub
#End Region
#Region "Accion"
        Private Sub Finalizar()
            Dim bss As New Bussines.Registro.Antecedente.SolicitudAntecedente
            Dim id As Integer = -1
            Dim strOutMensaje As String = ""

            If Me.InternoId = -1 Then Exit Sub

            '---------- guardar detalles de AntecedentesLM ----
            Dim list As Entity.Registro.Antecedente.DetalleAntecedenteCol

            list = (New Bussines.Registro.Antecedente.SolicitudAntecedente).ListarDetalleAntecedentePositivo_LM(Me.InternoId, Me.JurisdiccionAmbito, Me.chkShowAnulados.Checked)

            For Each o As Entity.Registro.Antecedente.DetalleAntecedente In list
                Dim entDet As New Entity.Registro.Antecedente.DetalleAntecedente
                Dim idDet As Integer = -1

                With entDet
                    .Fecha = o.Fecha
                    .Detalle = o.Detalle
                    .Descripcion = o.Descripcion
                    .PenalId = -1
                    .RegionId = -1
                    .SolicitudAntecedenteId = Me._Codigo
                End With
                idDet = (New Bussines.Registro.Antecedente.DetalleAntecedente).Grabar(entDet, strOutMensaje)
                If idDet = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Error grabar detalle de antecedente, " & strOutMensaje)
                    Exit Sub
                End If
            Next

            '--------------- guardar encabezado de reporte ----------
            Dim bssRpt As New Bussines.Reporte.ReporteCabecera
            Dim entRpt As New Entity.Reporte.ReporteCabecera
            With entRpt
                Select Case Me._TipoAntecedenteId
                    Case 1
                        .CodigoReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                    Case 2
                        .CodigoReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                    Case 3
                        .CodigoReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                End Select
                .InternoId = Me.InternoId
                '.InternoIngresoId = -1 'no es necesario el ingreso para los AntecedentesLM judiciales
                .Anio = Now.Year
                .NumSerie = Me.NumCorrelativo ' 0 '(New Bussines.Reporte.ReporteCabecera).UltimoNumeroDoc(.CodigoReporteId, .Anio) + 1
                .FechaEmision = Now.ToFileTime
                .CodigoId = -1
                .MotivoAnulacion = ""
                .Estado = 1 'ACTIVO
                .RegionId = -1
                .PenalId = -1
            End With

            Dim idRpt As Integer = -1
            idRpt = bssRpt.Grabar(entRpt, True, strOutMensaje)
            If idRpt = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Error al finalizar registro, " & strOutMensaje)
                Exit Sub
            End If

            'grabar glosa en el detalle de reporte
            Dim bssDetRpt As New Bussines.Reporte.ReporteContenido
            Dim ent As Entity.Reporte.ReporteContenido
            Dim glosaStr As String = ""

            If Me._TipoAntecedenteId = 3 Then 'Diferente de AJ negativo
                Dim entGlosa As New Entity.Globall.GlosaDocumento
                entGlosa = (New Bussines.Globall.GlosaDocumento).ListarPorCodigo(Me.GlosaId)
                glosaStr = entGlosa.Texto
            End If

            glosaStr = glosaStr.Replace("{_PRM_PENAL}", cbbJurisDet.Text.ToUpper)

            ent = New Entity.Reporte.ReporteContenido
            ent.ClaveStr = "GLOSA_CERT_AJ"
            ent.ValorStr = glosaStr
            ent.RptCabeceraId = idRpt
            bssDetRpt.Grabar(ent)

            strOutMensaje = ""

            id = bss.VicularConReporte(Me._Codigo, idRpt, strOutMensaje)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Error, no se pudo vincular con el reporte de antecedente, " & strOutMensaje)
                Exit Sub
            End If

            btnBuscarInterno.Enabled = False
            btnReporte.Enabled = True
            chRegistroDirecto.Enabled = False
            Me.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado
            Me._Finalizado = True
        End Sub

        Function validar() As Boolean
            Dim v As Boolean = True
            Dim sms As String = ""

            If Me.FechaSolicitud = 0 Then sms = "●- Fecha de solicitud vacío."
            If Me.DocumentoFecha = 0 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Fecha del documento vacío."
            If txtApePatInt.Text.Length = 0 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Debe especificar los apellidos y nombres."
            If Me.DocumentoNumero = "" Then sms = "●- Ingrese el número de documento."

            If sms.Length > 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
                Return False
            End If

            If Me._TipoAntecedenteId = 1 Then 'si es negativo

                If Me.InternoId = -1 And chRegistroDirecto.Checked = False Then
                    Legolas.Configuration.Aplication.MessageBox.Information("Busque a la persona presionando el botón correspondiente o de lo contrario para el registro manual active el check de Registro manual.")
                    Return False
                End If

                ''buscar interno por apellidos.
                Dim entCol As New Entity.Registro.InternoCol
                Dim objEntFiltro As New Entity.Registro.Interno_Grilla

                With objEntFiltro
                    .PrimerApellido = txtApePatInt.Text.Trim
                    .SegundoApellido = txtApeMatInt.Text.Trim
                    .PreNombres = txtNomInt.Text.Trim
                    .IDRegion = 3 'solo lima metropolitana
                End With

                entCol = (New Bussines.Registro.Interno_Grilla.RegionLima).ListarInternoBusquedaAntecedente(objEntFiltro, True)

                If Not entCol Is Nothing AndAlso entCol.Count > 1 Then

                    For Each fila As Entity.Registro.Interno In entCol
                        If (New Bussines.Registro.Antecedente.SolicitudAntecedente).EsAntecedenteNegativo(fila.Codigo) = False Then
                            Legolas.Configuration.Aplication.MessageBox.Information("No es posible completar la operación, la persona seleccionada presenta antecedentes.")
                            Return False
                            Exit For
                        End If
                    Next

                End If

            End If
            sms = ""
            If Me.TipoAutoridadId = -1 Or cbbTipoAutJud.Text.Trim = "" Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta seleccionar el tipo de autoridad."
            If Me.FechaSolicitud > Now.ToFileTime Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Fecha de socilicitud no puede ser futuro."
            If Me.DocumentoFecha > Now.ToFileTime Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Fecha del documento no puede ser futuro."
            If Me.MotivoSolicitudId = -1 Or cbbMotivoSolicitud.Text = "" Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta seleccionar el motivo de solicitud."

            If Me.TipoAutoridadId = 1 Then
                If Me.DistritoJudicial = -1 Or cbbDistritoJud.Text = "" Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta distrito judicial."
                If Me.SalaJuzgado = -1 Or cbbAutJudicial._SalaJuzgadoID = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta sala judicial."
            End If

            If cbbJurisDet.Text = "" Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta ámbito jurisdiccional."
            End If

            If sms.Length > 1 Then
                v = False
                Legolas.Configuration.Aplication.MessageBox.MensajeError(sms)
            End If

            If Me._TipoAntecedenteId = 3 And cboGlosa.Text = "" Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione la glosa del documento."
                cboGlosa.Select()
            End If

            Return v
        End Function

        Private Function AGrabar() As Boolean
            If validar() = False Then Return False

            Dim penCod As Integer = 0
            penCod = "0000" 'artificio, sede central

            Dim v As Boolean = True
            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
            Dim id As Integer = -1
            Dim outSms As String = ""
            If Me._Codigo > 0 Then
                ent = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Listar(Me._Codigo)
            End If
            With ent
                .Codigo = Me._Codigo
                .FechaSolicitud = Me.FechaSolicitud
                If Me._Codigo = -1 Then
                    .EstadoSolicitudId = 1 'terminado
                Else
                    .EstadoSolicitudId = Me.EstadoSolicitud.GetHashCode
                End If

                .MotivoSolicitudId = Me.MotivoSolicitudId
                .TipoAutoridadJudicial = Me.TipoAutoridadId
                .SolDistritoJudicialId = Me.DistritoJudicial
                .GlosaDocId = Me.GlosaId
                .SolSalaJudicialId = Me.SalaJuzgado
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFecha = Me.DocumentoFecha
                .SolNombreJuez = ""
                .SolNombreSecretario = Me.SecretarioNombre
                .SolNombreEntidad = Me.EntidadSolicitante
                .Observacion = Me.Observacion
                .SolicitantePenalId = Me.SolicitantePenalID
                .SolicitanteRegionId = Me.SolicitanteRegionID
                .TipoAntecedenteId = Me._TipoAntecedenteId
                .InternoApePaterno = Me.InternoApellidoPaterno
                .InternoApeMaterno = Me.InternoApellidoMaterno
                .InternoNombres = Me.InternoNombres
                .InternoCodigo = Me.CodigoInterno
                .InternoNombresAsociados = Me.InternoNombresAsociados
                .InternoId = Me.InternoId
                .AmbitoJurisdiccionAut = Me.JurisdiccionAmbito
                .IncluyeAnulaciones = chkShowAnulados.CheckState
            End With
            id = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Grabar(ent, outSms)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo guardar el registro, " & outSms)
                Return False
            End If

            If Me._Codigo = -1 Then
                Me._Codigo = id
                Me.EstadoSolicitud = enmEstadoSolicitud.Terminado
                Finalizar()
                cbbJurisDet.Enabled = False
                pnlShowAnulados.Enabled = False
                btnReporte.Enabled = True
            End If
            btnDetalleAJ.Visible = False
            Me.listDetAJ = Nothing
            Legolas.Configuration.Aplication.MessageBox.Information("Datos guardados satisfactoriamente.")

            Return v
        End Function
#End Region


        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            If Me.DistritoJudicial > 0 Then ComboSalaJuzgado()
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            If AGrabar() = False Then Exit Sub
        End Sub

        Private Sub frmCertAntecedenteMant_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            listar()
        End Sub

        Private Sub UscComboSala1__Click_Buscar() Handles cbbAutJudicial._Click_Buscar
            Me.DistritoJudicial = cbbAutJudicial._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = cbbAutJudicial._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged
            Select Case cbbTipoAutJud.SelectedValue
                Case EnumTipoAutoridad.AutoridadJudicial
                    PnlAutoridadJudicial.Visible = True
                    txtEntidadSolicitante.Enabled = False
                    tmpVal = Me.EntidadSolicitante
                    Me.EntidadSolicitante = ""
                    cbbRegion1.Visible = False
                    cbbPenal.Visible = False
                    lblPenal.Visible = False
                    lblRegion.Text = "Descripción entidad:"
                Case EnumTipoAutoridad.Inpe
                    PnlAutoridadJudicial.Visible = False
                    txtEntidadSolicitante.Enabled = True
                    cbbRegion1.Visible = True
                    cbbPenal.Visible = False
                    lblPenal.Visible = False
                    lblRegion.Text = "Región:"
                    cbbRegion1.SelectedValue = 2
                Case Else
                    PnlAutoridadJudicial.Visible = False
                    txtEntidadSolicitante.Enabled = True
                    Me.EntidadSolicitante = tmpVal
                    cbbRegion1.Visible = False
                    cbbPenal.Visible = False
                    lblPenal.Visible = False
                    lblRegion.Text = "Descripción entidad:"
            End Select
            MotivoSolicitud()

            'If cbbRegion1.SelectedValue = 2 Or cbbRegion1.SelectedValue = 0
            'Me.MotivoSolicitudId = -1
        End Sub

        Private Sub cbbAutJudicial__ClicK_VerFormulario() Handles cbbAutJudicial._Click_Buscar
            Dim frm As New Mantenimiento.Busqueda.frmSalaPopup
            With frm
                ._DistritoJudicialID = Me.DistritoJudicial
                If .ShowDialog = DialogResult.OK Then
                    Me.DistritoJudicial = ._DistritoJudicialID
                    Me.SalaJuzgado = ._GrillaSalaID
                End If
            End With
        End Sub

        'Private Sub btnProcesaAnt_Click(sender As System.Object, e As System.EventArgs) Handles btnProcesaAnt.Click
        '    'lblMensaje.Visible = True
        '    litarDetalle() 
        'End Sub

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click
            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                Select Case Me._TipoAntecedenteId
                    Case 1
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNegativo_v1
                    Case 2
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudNoPPPMD_v1
                    Case 3
                        ._ReporteId = Type.Reporte.Registro.rptCertificadoAntecedenteJudSiPPPMD_v1
                End Select
                ._Filtro.Text = Me.Text
                ._Filtro.DocSolicitudAntecedenteId = Me._Codigo
                ._Filtro.Nota = ""
                .ShowDialog()
            End With
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion1._SelectedIndexChanged
            If cbbRegion1.SelectedValue = 2 Or cbbRegion1.SelectedValue = 0 Then
                lblPenal.Visible = False
                cbbPenal.Visible = False
            Else
                lblPenal.Visible = True
                cbbPenal.Visible = True
            End If

            ComboPenal()
        End Sub

        Private Sub btnDetalle_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalle.Click
            If Me.GlosaId <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una glosa.")
                Exit Sub
            End If

            Dim f As New Registro.Carceleta.Clasificacion.Documento.frmDetGlosaPopup
            f._Codigo = Me.GlosaId
            f.ShowDialog()
        End Sub

        Private Sub chInterno_Click(sender As Object, e As System.EventArgs) Handles chRegistroDirecto.Click
            If Me.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado Then
                chRegistroDirecto.Enabled = False
                Exit Sub
            End If

            btnBuscarInterno.Enabled = False

            Me.InternoId = -1
            txtApePatInt.Text = ""
            txtNomInt.Text = ""
            txtApeMatInt.Text = ""
            txtNomAsociados.Text = ""

            If chRegistroDirecto.Checked = True Then
                txtCodRPInterno.Text = ""
                btnBuscarInterno.Enabled = False
                ActivarEdicionDatoPersona(False)
            Else
                btnBuscarInterno.Enabled = True
                ActivarEdicionDatoPersona(True)
            End If
        End Sub

        Private Sub ActivarEdicionDatoPersona(soloLectura As Boolean)
            txtApePatInt.ReadOnly = soloLectura
            txtNomInt.ReadOnly = soloLectura
            txtApeMatInt.ReadOnly = soloLectura
        End Sub
        Private Sub btnBuscarInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarInterno.Click
            BuscarInterno()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub cbbJurisDet_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbJurisDet.SelectedIndexChanged
            If Me._Codigo = -1 Then
                Me.InternoId = -1
                txtApePatInt.Text = ""
                txtCodRPInterno.Text = ""
                txtNomInt.Text = ""
                txtApeMatInt.Text = ""
                txtNomAsociados.Text = ""
                listDetAJ = Nothing
            End If
        End Sub

        Private Sub btnDetalleAJ_Click(sender As Object, e As EventArgs) Handles btnDetalleAJ.Click
            Dim f As New Registro.Main.Antecedentes.frmDetalleAJPopup
            f._setDataSource = listDetAJ
            f.ShowDialog()
        End Sub

        Private Sub chkShowAnulados_Click(sender As Object, e As EventArgs) Handles chkShowAnulados.Click
            Me.InternoId = -1
            txtApePatInt.Text = ""
            txtCodRPInterno.Text = ""
            txtNomInt.Text = ""
            txtApeMatInt.Text = ""
            txtNomAsociados.Text = ""
            listDetAJ = Nothing
        End Sub
    End Class
End Namespace