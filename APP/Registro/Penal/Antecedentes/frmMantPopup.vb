'Imports Type.Enumeracion.Movimiento
'Imports Type.Enumeracion.AntecedenteJudicial
'Imports Type.Enumeracion.TipoTabla

Namespace Registro.Penal.Antecedentes
    Public Class frmMantPopup

        Private EntidadSolicitanteNombre As String = ""
        Private objListaDetAJ As Entity.Registro.Antecedente.DetalleAntecedenteCol
        Private blnRegistroManual As Boolean = False

#Region "Propiedades"
        Public Property _Codigo As Integer = -1
        Public Property _TipoAntecedenteId As Integer = -1 '1=Negativo, 2 No reg pro pend con mand det, 2=Si reg proc pen con mand det
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
        Public Property _RegionNombre As String = ""
        Public Property _PenalNombre As String = ""

        Private Property Anio As Integer = 0
        Private Property NumCorrelativo As Integer = 0
        Private Property PenalCodigo As Integer = 0
        Private intIDEstadoSolicitud As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente
        Private Property IDEstadoSolicitud As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud
            Get
                Return intIDEstadoSolicitud
            End Get
            Set(value As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud)
                intIDEstadoSolicitud = value
                ColorEstado
            End Set
        End Property

        Private Property IDRegionJurisdiccion As Short
            Get
                Return Me.cbbRegionJurisdiccion.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbRegionJurisdiccion.SelectedValue = value
            End Set
        End Property
        Private Property IDJurisdiccionAmbito As Short
            Get
                Return Me.cbbJurisTipoAmbito.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbJurisTipoAmbito.SelectedValue = value
            End Set
        End Property


        Private Property IDInterno As Integer = -1
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

        Private Property NumeroSolicitud As String
            Get
                Return Me.txtNumSolicitud.Text
            End Get
            Set(value As String)
                Me.txtNumSolicitud.Text = value
            End Set
        End Property
        Private Property FechaSolicitud() As Long
            Get
                Return CDate(lblFecSolicitud.Text).ToFileTime
            End Get
            Set(value As Long)
                lblFecSolicitud.Text = DateTime.FromFileTime(value).ToString("dd/MM/yyyy hh:mm tt")
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
        Private Property TipoAutoridadId As Integer 'entidad solicitante
            Get
                Return cbbTipoAutJud.SelectedValue
            End Get
            Set(value As Integer)
                cbbTipoAutJud.SelectedValue = value
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
        Private Property IDRegionSolicitud() As Short 'descripcion entidad
            Get
                Dim value As Short = -1

                If Me.cbbRegion1.Visible = True Then
                    value = Me.cbbRegion1.SelectedValue
                End If

                Return value
            End Get
            Set(value As Short)
                Me.cbbRegion1.SelectedValue = value
            End Set
        End Property
        Private Property IDPenalSolicitud() As Integer
            Get
                Dim value As Integer = -1

                If Me.cbbPenal.Visible = True Then
                    value = Me.cbbPenal.SelectedValue
                End If

                Return value
            End Get
            Set(value As Integer)
                Me.cbbPenal.SelectedValue = value
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

        Private Property IDGlosa()
            Get
                Return cboGlosa.SelectedValue
            End Get
            Set(value)
                cboGlosa.SelectedValue = value
            End Set
        End Property
        Private Property TipoGlosa As Type.Enumeracion.TipoGlosa
        Private Property IDMotivoSolicitud As Integer
            Get
                Return cbbMotivoSolicitud.SelectedValue
            End Get
            Set(value As Integer)
                cbbMotivoSolicitud.SelectedValue = value
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
#End Region
#Region "Propiedades_Otros"
        Private Property FechaHoy As Date = Now
        Public Property _Finalizado As Boolean = False
#End Region
#Region "Combo"
        Private Sub ComboRegionJurisdiccion()
            With Me.cbbRegionJurisdiccion
                ._Todos = False
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With
        End Sub

        Private Sub Combo_JurisdiccionAmbito()

            Dim objBssCombo As New Bussines.Registro.Antecedente.Jurisdiccion

            With Me.cbbJurisTipoAmbito
                .DataSource = objBssCombo.ComboAmbitoJurisdiccion(True)
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
            End With

        End Sub

        Private Sub ComboTipoAutoridadJudicial()

            Dim ele As New List(Of Integer)
            If Me._Codigo = -1 Then 'solo para nuevos quitar poder judicial
                ele.Add(15) 'quitar el poder judicial
                cbbTipoAutJud.ListaIdsParaExcluir = ele
            End If
            cbbTipoAutJud.LoadUsc()

        End Sub

        Private Sub ComboGlosa()
            cboGlosa.DataSource = (New Bussines.Globall.GlosaDocumento).Listar(Me._TipoGlosa)
            cboGlosa.ValueMember = "Codigo"
            cboGlosa.DisplayMember = "CodigoString"
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

        Private Sub ComboMotivoSolicitud()
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
                .LoadUsc()
            End With
        End Sub
        Private Sub ComboPenal()
            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.Penal
                .CodigoPadre = Me.IDRegionSolicitud
                ._Todos = False
                .LoadUsc()
            End With
        End Sub

#End Region

#Region "Listar"
        Private Sub Listar()

            If Me._Codigo = -1 Then
                cboGlosa.SelectedIndex = 0
                cbbTipoAutJud.SelectedValue = -1
                lblFecSolicitud.Text = FechaHoy.ToString("dd/MM/yyyy hh:mm tt")
                Exit Sub
            End If

            Dim bs As New Bussines.Registro.Antecedente.SolicitudAntecedente
            Dim ent As Entity.Registro.Antecedente.SolicitudAntecedente
            ent = bs.Listar(Me._Codigo)
            With ent
                Me._TipoAntecedenteId = ent.TipoAntecedenteId
                Me.IDEstadoSolicitud = ent.EstadoSolicitudId
                Me.NumCorrelativo = ent.NumeroCorrelativo
                Me.Anio = ent.Anio
                Me.PenalCodigo = ent.CodigoPenal
                Me.IDJurisdiccionAmbito = ent.AmbitoJurisdiccionAut
                'datos del interno
                Me.CodigoInterno = ent.InternoCodigo
                Me.IDInterno = ent.InternoId
                Me.InternoApellidoMaterno = ent.InternoApeMaterno
                Me.InternoApellidoPaterno = ent.InternoApePaterno
                Me.InternoNombres = ent.InternoNombres
                Me.InternoNombresAsociados = ent.InternoNombresAsociados
                'datos de solicitud          
                Me.NumeroSolicitud = ent.getNumeroSolicitudPenal
                Me.FechaSolicitud = ent.FechaSolicitud
                Me.DocumentoNumero = ent.DocumentoNumero
                Me.DocumentoFecha = ent.DocumentoFecha
                Me.EntidadSolicitante = ent.SolNombreEntidad
                EntidadSolicitanteNombre = Me.EntidadSolicitante
                Me.TipoAutoridadId = ent.TipoAutoridadJudicial
                Me.IDRegionSolicitud = ent.SolicitanteRegionId
                Me.IDPenalSolicitud = ent.SolicitantePenalId
                Me.DistritoJudicial = ent.SolDistritoJudicialId
                Me.SalaJuzgado = ent.SolSalaJudicialId
                Me.SecretarioNombre = ent.SolNombreSecretario
                Me.Observacion = ent.Observacion
                'glosa
                Me.IDGlosa = ent.GlosaDocId
                Me.IDMotivoSolicitud = ent.MotivoSolicitudId
            End With

            'permisos 
            Me.chkShowAnulados.CheckState = If(ent.IncluyeAnulaciones = 1, 1, 0)
            Me.btnReporte.Enabled = True

            Select Case Me.IDEstadoSolicitud
                Case Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Anulado, Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Impreso

                    Me.btnOk.Enabled = False
                    Me.btnBuscarInterno.Enabled = False
                    Me.btnRegManual.Enabled = False
                    Me.chkShowAnulados.Enabled = False
                    Me.btnOk.Enabled = False

                Case Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado

                    Me.btnBuscarInterno.Enabled = False
                    Me.btnRegManual.Enabled = False
                    Me.chkShowAnulados.Enabled = False
                    Me.btnOk.Enabled = False

                    If Me._TipoAntecedenteId = 1 And Me._Codigo > 0 Then
                        btnRegManual.Enabled = False
                    End If

            End Select

            'listar detalle
            If ent.EstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                ListarDetalle()
            Else
                Dim detEnt As New Entity.Registro.Antecedente.DetalleAntecedente
                Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol

                detEnt.SolicitudAntecedenteId = Me._Codigo
                objListaDetAJ = (New Bussines.Registro.Antecedente.DetalleAntecedente).Listar(detEnt)
            End If

            'auditoria
            Me.UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.Auditoria.EnumTipTabla.ANJ_MOV_SolicitudAntecedente)

        End Sub

        Private Sub ListarDetalle()

            Dim objBss As New Bussines.Registro.Antecedente.SolicitudAntecedente
            Dim objLista As New Entity.Registro.Antecedente.DetalleAntecedenteCol

            objLista = objBss.ListarDocumentoJudiciales_Penal(Me._IDRegion, Me._IDPenal, Me.IDInterno, Me.chkShowAnulados.Checked)

            If objLista.Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Information("El interno no cuenta con antecedentes.")
                txtCodRPInterno.Text = ""
                txtApePatInt.Text = ""
                txtApeMatInt.Text = ""
                txtNomInt.Text = ""
                txtNomAsociados.Text = ""
                Exit Sub
            Else
                objListaDetAJ = objLista
                Me.btnDetalleAJ.Visible = True
            End If

        End Sub
#End Region

#Region "Accion"
        Function Validar() As Boolean

            Dim value As Boolean = True
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

                If Me.IDInterno = -1 And blnRegistroManual = False Then
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
            If Me.FechaSolicitud > Me.FechaHoy.ToFileTime Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Fecha de socilicitud no puede ser futuro."
            If Me.DocumentoFecha > Me.FechaHoy.ToFileTime Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Fecha del documento no puede ser futuro."
            If Me.IDMotivoSolicitud = -1 Or cbbMotivoSolicitud.Text = "" Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta seleccionar el motivo de solicitud."

            If Me.TipoAutoridadId = 1 Then
                If Me.DistritoJudicial = -1 Or cbbDistritoJud.Text = "" Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta distrito judicial."
                If Me.SalaJuzgado = -1 Or cbbAutJudicial._SalaJuzgadoID = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta sala judicial."
            End If

            If cbbJurisTipoAmbito.Text = "" Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Falta ámbito jurisdiccional."
            End If

            If sms.Length > 1 Then
                value = False
                Legolas.Configuration.Aplication.MessageBox.MensajeError(sms)
            End If

            If Me._TipoAntecedenteId = 3 And cboGlosa.Text = "" Then
                sms = If(sms.Length > 0, sms & vbCrLf, "") & "●- Seleccione la glosa del documento."
                cboGlosa.Select()
            End If

            Return value
        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Boolean = True
            Dim ent As New Entity.Registro.Antecedente.SolicitudAntecedente
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
                    .EstadoSolicitudId = Me.IDEstadoSolicitud
                End If

                .MotivoSolicitudId = Me.IDMotivoSolicitud
                .TipoAutoridadJudicial = Me.TipoAutoridadId
                .SolDistritoJudicialId = Me.DistritoJudicial
                .GlosaDocId = Me.IDGlosa
                .SolSalaJudicialId = Me.SalaJuzgado
                .DocumentoNumero = Me.DocumentoNumero
                .DocumentoFecha = Me.DocumentoFecha
                .SolNombreJuez = ""
                .SolNombreSecretario = Me.SecretarioNombre
                .SolNombreEntidad = Me.EntidadSolicitante
                .Observacion = Me.Observacion
                .SolicitantePenalId = Me.IDPenalSolicitud
                .SolicitanteRegionId = Me.IDRegionSolicitud
                .TipoAntecedenteId = Me._TipoAntecedenteId
                .InternoApePaterno = Me.InternoApellidoPaterno
                .InternoApeMaterno = Me.InternoApellidoMaterno
                .InternoNombres = Me.InternoNombres
                .InternoCodigo = Me.CodigoInterno
                .InternoNombresAsociados = Me.InternoNombresAsociados
                .InternoId = Me.IDInterno
                .AmbitoJurisdiccionAut = Me.IDJurisdiccionAmbito
                .IncluyeAnulaciones = chkShowAnulados.CheckState
                .RegionId = Me._IDRegion
                .PenalId = Me._IDPenal
            End With

            Dim intValue As Integer = -1
            intValue = (New Bussines.Registro.Antecedente.SolicitudAntecedente).Grabar(ent, outSms)

            If intValue > 0 Then
                Me._Codigo = intValue
                GrabarDetalle()
                Listar()
                Legolas.Configuration.Aplication.MessageBox.Information("Datos guardados satisfactoriamente.")
                Me.cbbJurisTipoAmbito.Enabled = False
                Me.chkShowAnulados.Enabled = False
                Me.btnReporte.Enabled = True
            Else
                Legolas.Configuration.Aplication.MessageBox.MensajeError("No se pudo guardar el registro, " & outSms)
            End If

            Me.btnDetalleAJ.Visible = False
            Me.objListaDetAJ = Nothing
            Me.btnOk.Enabled = False

        End Sub
        Private Sub GrabarDetalle()

            If Me.IDEstadoSolicitud <> Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Pendiente Then
                Exit Sub
            End If

            Dim bss As New Bussines.Registro.Antecedente.SolicitudAntecedente
            Dim id As Integer = -1
            Dim strOutMensaje As String = ""

            'si el id, es mayor a 1, buscar el detalle de antecedentes
            If Me.IDInterno > 1 Then

                '1.- guardar detalles de Antecedentes
                Dim list As Entity.Registro.Antecedente.DetalleAntecedenteCol
                Dim objBss As New Bussines.Registro.Antecedente.SolicitudAntecedente

                list = objBss.ListarDocumentoJudiciales_Penal(Me._IDRegion, Me._IDPenal, Me.IDInterno, Me.chkShowAnulados.Checked)

                For Each o As Entity.Registro.Antecedente.DetalleAntecedente In list
                    Dim entDet As New Entity.Registro.Antecedente.DetalleAntecedente
                    Dim idDet As Integer = -1

                    With entDet
                        .Fecha = o.Fecha
                        .Detalle = o.Detalle
                        .Descripcion = o.Descripcion
                        .RegionId = Me._IDRegion
                        .PenalId = Me._IDPenal
                        .SolicitudAntecedenteId = Me._Codigo
                    End With

                    idDet = (New Bussines.Registro.Antecedente.DetalleAntecedente).Grabar(entDet, strOutMensaje)

                    If idDet = -1 Then
                        Legolas.Configuration.Aplication.MessageBox.Information("Error grabar detalle de antecedente, " & strOutMensaje)
                        Exit Sub
                    End If

                Next

            End If

            '2.-guardar encabezado de reporte
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
                .InternoId = Me.IDInterno
                .Anio = Me.FechaHoy.Year
                .NumSerie = Me.NumCorrelativo
                .FechaEmision = Me.FechaHoy.ToFileTime
                .CodigoId = 0 'registro padre                                 
                .RegionId = Me._IDRegion
                .PenalId = Me._IDPenal
            End With

            Dim idRpt As Integer = -1
            idRpt = bssRpt.Grabar(entRpt, True, strOutMensaje)
            If idRpt = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Error al finalizar registro, " & strOutMensaje)
                Exit Sub
            End If

            '3.- grabar glosa en el detalle de reporte
            If Me._TipoAntecedenteId = 3 Then 'Diferente de AJ negativo

                Dim bssDetRpt As New Bussines.Reporte.ReporteContenido
                Dim ent As Entity.Reporte.ReporteContenido
                Dim glosaStr As String = ""

                Dim entGlosa As New Entity.Globall.GlosaDocumento
                entGlosa = (New Bussines.Globall.GlosaDocumento).ListarPorCodigo(Me.IDGlosa)
                glosaStr = entGlosa.Texto

                glosaStr = glosaStr.Replace("{_PRM_PENAL}", cbbJurisTipoAmbito.Text.ToUpper)

                ent = New Entity.Reporte.ReporteContenido
                ent.ClaveStr = "GLOSA_CERT_AJ"
                ent.ValorStr = glosaStr
                ent.RptCabeceraId = idRpt
                ent.RegionId = Me._IDRegion
                ent.PenalId = Me._IDPenal
                bssDetRpt.Grabar(ent)
            End If

            strOutMensaje = ""
            id = bss.VicularConReporte(Me._Codigo, idRpt, strOutMensaje)
            If id = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Error, no se pudo vincular con el reporte de antecedente, " & strOutMensaje)
                Exit Sub
            End If

            btnBuscarInterno.Enabled = False
            btnReporte.Enabled = True
            btnRegManual.Enabled = False
            Me.IDEstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado
            Me._Finalizado = True

        End Sub
#End Region

#Region "FRM"
        Private Sub FRM_VistaPrevia()

            Dim f As New Registro.Main.Antecedentes.frmDetalleAJPopup
            f._setDataSource = objListaDetAJ
            f.ShowDialog()

        End Sub
        Private Sub FRM_BuscarInterno()

            If cbbJurisTipoAmbito.Text = "" Then
                Legolas.Configuration.Aplication.MessageBox.Information("Seleccione la jurisdicción.")
                Exit Sub
            End If

            Dim frm As New Registro.Busqueda.frmInternoPopup()
            frm._RegionID = Me._IDRegion
            frm._PenalID = Me._IDPenal
            frm._RegionNombre = Me._RegionNombre
            frm._PenalNombre = Me._PenalNombre

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.IDInterno = frm._GrillaInternoID

                If Me._TipoAntecedenteId = 1 Then 'si es AJ Negativo
                    If (New Bussines.Registro.Antecedente.SolicitudAntecedente).EsAntecedenteNegativo(Me.IDInterno) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Information("No es posible completar la operación, la persona seleccionada presenta antecedentes.")
                        Exit Sub
                    End If
                End If

                If Me._TipoAntecedenteId = 2 Then 'no presenta p.p.m.d.
                    If (New Bussines.Registro.Antecedente.SolicitudAntecedente).RegistraProcesoPendienteConMD(Me.IDInterno, Me.IDJurisdiccionAmbito) = True Then
                        Legolas.Configuration.Aplication.MessageBox.Information("La persona seleccionada presenta procesos pendiente con mandatos de detención, debe generar su certificado positivo.")
                        Exit Sub
                    End If
                End If

                Me.txtCodRPInterno.Text = frm._GrillaCodigoRP
                Me.txtApePatInt.Text = frm._GrillaPrimerApellido
                Me.txtApeMatInt.Text = frm._GrillaSegundoApellido
                Me.txtNomInt.Text = frm._GrillaNombres

                'listar nombres asociados del interno
                Dim entNomAso As New Entity.Registro.NombreAsociado
                Dim entNomAsoCol As Entity.Registro.NombreAsociadoCol
                Dim s As String = ""

                entNomAso.InternoID = frm._GrillaInternoID
                entNomAsoCol = (New Bussines.Registro.NombreAsociado).Listar(entNomAso)

                For Each o As Entity.Registro.NombreAsociado In entNomAsoCol
                    If o.Principal = 0 Then s = s & o.ApellidosyNombres & ","
                Next
                s = If(s.Trim.Length <= 1, "", s.Substring(0, s.Length - 1))
                Me.txtNomAsociados.Text = If(s.Trim.Length = 0, "NO REGISTRA", s)

                Me.objListaDetAJ = Nothing

                If Me._TipoAntecedenteId = 3 Then ' solo si es positivo
                    ListarDetalle()
                End If

            End If
        End Sub
        Private Sub FRM_Reporte()

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
                ._Filtro.RegionID = Me._IDRegion
                ._Filtro.RegionNombre = Me._RegionNombre
                ._Filtro.PenalID = Me._IDPenal
                ._Filtro.Text = Me.Text
                ._Filtro.DocSolicitudAntecedenteId = Me._Codigo
                ._Filtro.Nota = ""
                .ShowDialog()
            End With

        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            Me.FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServer
            Me.chkShowAnulados.Visible = False

            Select Case Me._TipoAntecedenteId
                Case 1
                    lblTitulo.Text = "CERTIFICADO NEGATIVO"
                    Me._TipoGlosa = Type.Enumeracion.TipoGlosa.AntecedenteJudicialNegativo
                    pnlJurisdiccion.Enabled = False
                    cbbRegionJurisdiccion.Enabled = True
                    cbbJurisTipoAmbito.Enabled = True
                    cbbJurisTipoAmbito.Text = "Lima y Callao"
                    btnBuscarInterno.Focus()
                Case 2
                    lblTitulo.Text = "CERTIFICADO NO REG. PROC. PENDIENTES CON MANDATO DE DETENCION"
                    Me._TipoGlosa = Type.Enumeracion.TipoGlosa.AntecedenteJudicialNoRPPMD
                    btnRegManual.Visible = False
                    cbbJurisTipoAmbito.Focus()
                Case 3
                    lblTitulo.Text = "CERTIFICADO POSITIVO"
                    Me._TipoGlosa = Type.Enumeracion.TipoGlosa.AntecedenteJudicialRPPMD
                    btnRegManual.Visible = False
                    Label12.Visible = True
                    cboGlosa.Visible = True
                    btnDetalle.Visible = True
                    Me.chkShowAnulados.Visible = True
                    Me.chkShowAnulados.Enabled = True
                    cbbJurisTipoAmbito.Focus()
            End Select

            ComboRegionJurisdiccion()
            Combo_JurisdiccionAmbito()

            ComboTipoAutoridadJudicial()
            ComboDistritoJudicial()
            ComboSalaJuzgado()
            ComboRegion()
            ComboPenal()
            ComboGlosa()

            Me.TipoAutoridadId = -1
            Me.IDMotivoSolicitud = -1
            Me.DistritoJudicial = -1

            cbbAutJudicial._SalaJuzgadoID = -1
            cbbAutJudicial._DistritoJudicialID = -1
            cbbAutJudicial._SalaJuzgadoID_Seleccionado = -1

        End Sub
        Private Sub ActivarEdicionDatoPersona(soloLectura As Boolean)
            txtApePatInt.ReadOnly = soloLectura
            txtNomInt.ReadOnly = soloLectura
            txtApeMatInt.ReadOnly = soloLectura
        End Sub
        Private Sub ColorEstado()

            Select Case Me.IDEstadoSolicitud
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
        End Sub
#End Region

        Private Sub cbbDistritoJud__SelectedIndexChanged() Handles cbbDistritoJud._SelectedIndexChanged
            If Me.DistritoJudicial > 0 Then ComboSalaJuzgado()
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmCertAntecedenteMant_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            ValoresxDefault()
            Listar()

        End Sub

        Private Sub UscComboSala1__Click_Buscar() Handles cbbAutJudicial._Click_Buscar
            Me.DistritoJudicial = cbbAutJudicial._DistritoJudicialID
            ComboSalaJuzgado()
            Me.SalaJuzgado = cbbAutJudicial._SalaJuzgadoID_Seleccionado
        End Sub

        Private Sub cbbTipoAutJud__SelectedIndexChanged() Handles cbbTipoAutJud._SelectedIndexChanged

            Select Case cbbTipoAutJud.SelectedValue
                Case Type.Enumeracion.Movimiento.EnumTipoAutoridad.AutoridadJudicial
                    PnlAutoridadJudicial.Visible = True
                    txtEntidadSolicitante.Enabled = False
                    EntidadSolicitanteNombre = Me.EntidadSolicitante
                    Me.EntidadSolicitante = ""
                    cbbRegion1.Visible = False
                    cbbPenal.Visible = False
                    lblPenal.Visible = False
                    lblRegion.Text = "Descripción entidad:"

                Case Type.Enumeracion.Movimiento.EnumTipoAutoridad.Inpe
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
                    Me.EntidadSolicitante = EntidadSolicitanteNombre
                    cbbRegion1.Visible = False
                    cbbPenal.Visible = False
                    lblPenal.Visible = False
                    lblRegion.Text = "Descripción entidad:"
            End Select
            ComboMotivoSolicitud()

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

        Private Sub btnReporte_Click(sender As System.Object, e As System.EventArgs) Handles btnReporte.Click

            FRM_Reporte()

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
            If Me.IDGlosa <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una glosa.")
                Exit Sub
            End If

            Dim f As New Registro.Carceleta.Clasificacion.Documento.frmDetGlosaPopup
            f._Codigo = Me.IDGlosa
            f.ShowDialog()
        End Sub

        Private Sub btnBuscarInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarInterno.Click
            FRM_BuscarInterno()
        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub cbbJurisDet_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbJurisTipoAmbito.SelectedIndexChanged
            If Me._Codigo = -1 Then
                Me.IDInterno = -1
                txtApePatInt.Text = ""
                txtCodRPInterno.Text = ""
                txtNomInt.Text = ""
                txtApeMatInt.Text = ""
                txtNomAsociados.Text = ""
                objListaDetAJ = Nothing
            End If
        End Sub

        Private Sub btnDetalleAJ_Click(sender As Object, e As EventArgs) Handles btnDetalleAJ.Click

            FRM_VistaPrevia

        End Sub

        Private Sub chkShowAnulados_Click(sender As Object, e As EventArgs) Handles chkShowAnulados.Click
            Me.IDInterno = -1
            txtApePatInt.Text = ""
            txtCodRPInterno.Text = ""
            txtNomInt.Text = ""
            txtApeMatInt.Text = ""
            txtNomAsociados.Text = ""
            objListaDetAJ = Nothing
        End Sub

        Private Sub btnRegManual_Click(sender As Object, e As EventArgs) Handles btnRegManual.Click

            If Me.IDEstadoSolicitud = Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud.Terminado Then
                btnRegManual.Enabled = False
                Exit Sub
            End If

            btnBuscarInterno.Enabled = False

            Me.IDInterno = -1
            txtApePatInt.Text = ""
            txtNomInt.Text = ""
            txtApeMatInt.Text = ""
            txtNomAsociados.Text = ""

            txtCodRPInterno.Text = ""
            btnBuscarInterno.Enabled = False
            ActivarEdicionDatoPersona(False)
            Me.txtApePatInt.Focus()
            blnRegistroManual = True

        End Sub
    End Class
End Namespace