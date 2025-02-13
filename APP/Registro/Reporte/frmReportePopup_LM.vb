Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.TipoDocJudicial

Namespace Registro.Reporte
    Public Class frmReportePopup_LM
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno

#Region "Enum"
        Public Enum enmListarReportes As Short
            Ninguno = 0
            Todos = 1
            Interno = 2
        End Enum
#End Region
#Region "Propiedades_Parametricas"
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1
        Public Property _InternoID As Integer = -1
        Public Property _InternoApeNom As String = ""
        Public Property _TipoReporte As enmListarReportes = enmListarReportes.Todos
        Public Property _EnabledTipoInterno() As Boolean = False
        Private Property RestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol
        Private blnCargoShow As Boolean = False
#End Region
#Region "Propiedades_UserControls"
        Public Property _VisibleBuscar As Boolean
            Get
                Return Me.UscLabelBusqueda1._Visible_Buscar
            End Get
            Set(value As Boolean)
                Me.UscLabelBusqueda1._Visible_Buscar = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaCodigo() As Integer
            Get
                Dim intValue As Integer = -1
                Try
                    With Me.dgwGrilla
                        intValue = .SelectedRows(0).Cells("col_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return intValue
            End Get
        End Property
#End Region

#Region "Propiedades"
        Private Property FechaISPString() As String = ""
        Private Property NumeroDocTrasladoStr As String = ""
        Private Property PenalNomOrigenTraslado As String = ""
        Private Property PenalNomDestinoTraslado As String = ""
        Private Property FechaIngresoString() As String = ""

        Private Property RegionID() As Short
            Get
                Return Me.cbbRegion.SelectedValue
            End Get
            Set(value As Short)
                Me.cbbRegion.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.cbbRegion.Text
            End Get
        End Property
        Private Property PenalID() As Short
            Get
                Dim v As Short = -1
                If Me.cbbPenal.SelectedValue <= 0 Then
                    v = -1
                Else
                    Return Me.cbbPenal.SelectedValue
                End If
                Return v
            End Get
            Set(value As Short)
                Me.cbbPenal.SelectedValue = value
            End Set
        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.cbbPenal.Text
            End Get
        End Property
        Private Property TipoInterno() As Short
            Get

                Dim value As Short = -1

                If Me.rdbSeleccionarInterno.Checked = True Then
                    value = 1
                End If

                Return value

            End Get
            Set(value As Short)
                Select Case value
                    Case 1
                        Me.rdbSeleccionarInterno.Checked = True
                    Case Else
                        Me.rdbInternoTodos.Checked = True
                End Select
            End Set
        End Property
        Private Property InternoID As Integer
            Get
                Return Me.UscLabelBusqueda1._Codigo
            End Get
            Set(ByVal value As Integer)
                Me.UscLabelBusqueda1._Codigo = value
            End Set
        End Property
        Private Property Interno As String
            Get
                Return Me.UscLabelBusqueda1._Value
            End Get
            Set(ByVal value As String)
                Me.UscLabelBusqueda1._Value = value.ToUpper
            End Set
        End Property
        Private Property FechaInicio() As Long
            Get

                Return Me.dtpFechaIni.ValueLong

            End Get
            Set(value As Long)
                Me.dtpFechaIni.ValueLong = value
            End Set
        End Property
        Private Property FechaFin() As Long
            Get

                Return Me.dtpFechaFin.ValueLong

            End Get
            Set(value As Long)
                Me.dtpFechaFin.ValueLong = value
            End Set
        End Property
#End Region
#Region "Propiedades_Certificado_Reclusion"
        Private Property DocumentoNumero As String = ""
        Private Property FechaEmision As String = ""
        Private Property Observacion As String = ""
#End Region
        Private Property ProcedenciaPenal As String = ""
        Private Property Nota As String = ""
#Region "Combo"
        Private Sub ComboRegion()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            End If

            With Me.cbbRegion
                .ComboTipo = Type.Combo.ComboTipo.RegionLicencia
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = blnTodos
                .LoadUsc()
                .Enabled = False
            End With

        End Sub
        Private Sub ComboPenal()

            Dim blnTodos As Boolean = False

            If Configuracion.Licencia.Codigo = 1 Then 'sede central
                blnTodos = True
            Else
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim objBssLicencia As New Bussines.Sistema.Instalacion
                intTipoLicencia = objBssLicencia.ListarTipo(Configuracion.Licencia.Codigo)

                Select Case intTipoLicencia
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                        blnTodos = True
                End Select
            End If

            With Me.cbbPenal
                .ComboTipo = Type.Combo.ComboTipo.PenalLicencia
                .CodigoPadre = Me.RegionID
                .Parametro1 = Configuracion.Licencia.Codigo
                ._Todos = blnTodos
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarReporte()

            Dim strReporte As String = "" '25,32,33,34,35,36,37," dfgdf dfgfdg

            Select Case Me._TipoReporte
                Case enmListarReportes.Todos
                    Dim intTipoLocal As Short = -1
                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    intTipoLocal = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.ListarInteger("app_lic", -1)).Tipo

                    Select Case intTipoLocal
                        Case 1 'penal
                            strReporte = "24,32,33,54,48,63,64"

                        Case 2, 3 'region y sede
                            strReporte = "24,33,50,51,52,54,48,70,71" 'strReporte & "27,29,31,54"

                            If Me._TipoLicencia = enmTipoLicencia.Carceleta Then 'si es carceleta
                                strReporte = "24,32,33,34,48,50,53,51,52"
                            End If

                        Case 4 'penales de lima metropolitana
                            strReporte = "7,24,32,34,33,48,54,63,64,70,71"
                    End Select

                Case enmListarReportes.Interno
                    If Me._TipoLicencia = enmTipoLicencia.Carceleta Then 'si es carceleta
                        strReporte = "24,32,33,48"
                    ElseIf Me._TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Then
                        strReporte = "24,33,54,48" '50,51,52
                    Else 'penal lima metropolitana
                        strReporte = "7,24,32,33,48,54,63,64"
                        '07=rpt_papeletaexcarceleacion, add x jeu
                        '24=rpt_ficha_decadactilar
                        '32=rpt_mov_interno
                        '33=rpt_rnc_ficha_validacion
                        '48=rpt_ficha_ident_carceleta_v1
                        '63=rptCertificadoReclusion_LM
                    End If
            End Select

            Dim objEntFiltro As New Legolas.LEntity.Globall.Reporte
            Dim objEntCol As New Legolas.LEntity.Globall.ReporteCol

            Dim objBss As New Legolas.LBusiness.Globall.Reporte

            With objEntFiltro
                .CodigoMultiple = strReporte
            End With

            objEntCol = objBss.Listar(objEntFiltro)
            If ValidarPenalLicencia() > -1 Then
                For i As Integer = objEntCol.Count - 1 To 0 Step -1
                    If objEntCol.Reporte(i).Codigo = 25 Then 'Or objEntCol.Reporte(i).Codigo = 36 Then'constancia de reclusion
                        objEntCol.RemoveAt(i)
                    End If
                Next
            End If
            For i As Integer = objEntCol.Count - 1 To 0 Step -1
                If objEntCol.Reporte(i).Codigo = 48 And Me._TipoLicencia = enmTipoLicencia.Carceleta Then 'Or objEntCol.Reporte(i).Codigo = 36 Then'constancia de reclusion
                    objEntCol.Reporte(i).Nombre = "Ficha de identificación carceleta"
                End If
            Next
            With Me.dgwGrilla
                .AutoGenerateColumns = False
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .RowsDefaultCellStyle.SelectionForeColor = Configuracion.Aplication.GrillaSelectionForeColor
                .DataSource = objEntCol
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            Select Case Me.GrillaCodigo
                Case 25, 32, 33, 63, 36, 37, 24, 48, 54, 64 'contancia de reclusion

                    'por Interno
                    If Me.InternoID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "Seleccione el Interno")
                        Return value
                    End If

                Case 26, 28, 30, 34 'movimientos penal

                    'por region
                    If Me.RegionID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Region")
                        Me.cbbRegion.Focus()
                        Return value
                    End If

                    'por penal
                    If Me.GrillaCodigo <> 34 And Me.PenalID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
                        Me.cbbPenal.Focus()
                        Return value
                    End If

                    'por fechas inicio
                    If Me.FechaInicio < 1 Or Me.FechaFin < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el rango de fechas")
                        Me.dtpFechaIni.Focus()
                        Return value
                    End If

                    'la fecha mayor no puede ser menor a la fecha ini
                    If Me.FechaFin < Me.FechaInicio Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser mayor a la fecha de inicio")
                        Me.dtpFechaIni.Focus()
                        Return value
                    End If

                Case 27, 29, 31 'movimientos por sede

                    'por region
                    If Me.RegionID < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Region")
                        Me.cbbPenal.Focus()
                        Return value
                    End If

                    'por fechas inicio
                    If Me.FechaInicio < 1 Or Me.FechaFin < 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el rango de fechas")
                        Me.dtpFechaIni.Focus()
                        Return value
                    End If

                    'la fecha mayor no puede ser menor a la fecha ini
                    If Me.FechaFin < Me.FechaInicio Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha fin, no puede ser mayor a la fecha de inicio")
                        Me.dtpFechaIni.Focus()
                        Return value
                    End If

            End Select

            value = True
            Return value

        End Function

        Private Function VerificarExistenciaResolucionIng(ByRef strTipResolIng As String) As Boolean
            Dim entIntIng As Entity.Registro.Ingreso
            Dim regEncontrado As Boolean = False

            If Me._TipoLicencia <> enmTipoLicencia.PenalLimaMetropolitana Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Válido solo para penales de lima metropolitana.")
                Return False
            End If

            If Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                entIntIng = (New Bussines.Registro.Ingreso).ListarUltimoIngreso_LM(Me.InternoID)
                If entIntIng Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con ningun ingreso vigente")
                    Return False
                End If
            End If

            Dim entIntInp As Entity.Registro.IngresoInpe

            entIntInp = (New Bussines.Registro.IngresoInpe).ListarUltimoIngresoInpe(Me.InternoID, Me.PenalID)
            If entIntInp Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con ningún ingreso inpe vigente")
                Return False
            End If

            Me.FechaISPString = entIntInp.FechaISPDate

            'verificar si existe resolucion de ingreso
            Dim objEntFiltroDocJud As New Entity.Registro.DocumentoJudicial
            Dim entResolCol As New Entity.Registro.DocumentoJudicialCol

            objEntFiltroDocJud.InternoId = Me.InternoID
            objEntFiltroDocJud.IngresoInpeId = entIntInp.Codigo
            objEntFiltroDocJud.DocumentoTipo = enumTipoDocumentoJudicial.Ingreso

            entResolCol = (New Bussines.Registro.DocumentoJudicial).ListarGrilla_LM(objEntFiltroDocJud, Me._TipoLicencia)

            If entResolCol.Count > 0 Then 'no existe resolucion de ingreso
                'For Each obj As Entity.Registro.DocumentoJudicial In entResolCol
                regEncontrado = True
                strTipResolIng = "RS_ING" 'resolucion de ingreso
                '    Exit For
                'Next
            Else

                objEntFiltroDocJud.InternoId = Me.InternoID
                objEntFiltroDocJud.IngresoInpeId = entIntInp.Codigo
                objEntFiltroDocJud.DocumentoTipo = enumTipoDocumentoJudicial.Traslado

                entResolCol = (New Bussines.Registro.DocumentoJudicial).ListarGrilla_LM(objEntFiltroDocJud, Me._TipoLicencia)
                If entResolCol.Count > 0 Then 'no existe resolucion de ingreso
                    entResolCol.Sort("DocumentoFechaRecepcion", Entity.SortDirection.Desc)
                    For Each obj As Entity.Registro.DocumentoJudicial In entResolCol

                        Dim p As Entity.General.Penal
                        p = (New Bussines.General.Penal).Listar_v2(obj.PenalOrigenId)

                        Dim p_dest As Entity.General.Penal
                        p_dest = (New Bussines.General.Penal).Listar_v2(obj.PenalDestinoid)

                        Select Case p.PenalTipoLicenciaId
                            Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                                 Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia,
                                 Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                                regEncontrado = True
                                strTipResolIng = "RS_TRS" 'resolucion de traslado
                                Me.NumeroDocTrasladoStr = obj.DocumentoNumero
                                Me.PenalNomOrigenTraslado = p.Nombre
                                Me.PenalNomDestinoTraslado = p_dest.Nombre
                            Case Else
                                regEncontrado = False
                        End Select
                        'If p.PenalTipoLicenciaId = 1 Or p.PenalTipoLicenciaId = 7 Then 'origen penal debe ser provincia o lima prov
                        '    regEncontrado = True
                        '    strTipResolIng = "RS_TRS" 'resolucion de traslado
                        '    Me.NumeroDocTrasladoStr = obj.DocumentoNumero
                        '    Me.PenalNomOrigenTraslado = p.Nombre
                        '    Me.PenalNomDestinoTraslado = p_dest.Nombre
                        'Else
                        '    regEncontrado = False
                        'End If
                        Exit For 'solo se debe evaluar si el primer doc de traslado es de ingreso desde EP Prov.
                    Next
                End If
            End If

            If regEncontrado = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha encontrado ningún documento de ingreso ni traslado.")
                Return False
            End If

            Return True
        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Select Case Me.GrillaCodigo

                Case 7 'papeleta de excarcelacion

                    FRM_Reporte_Papeleta_Excarcelacion()

                Case 24, 53 'ficha decadactilar 

                    FRM_ReporteInterno()

                Case 63 'constanacia de reclusion LM

                    FRM_Reporte_Constancia_Reclusion()

                Case 33, 34

                    FRM_Reporte_Reniec()
                Case 35, 48

                    Dim strFechIng_OUT As String = ""
                    'If VerificarExistenciaResolucionIng(strFechIng_OUT) = False Then Exit Sub
                    Me.FechaIngresoString = strFechIng_OUT
                    FRM_ReporteInterno()

                Case 64 'certificado de libertad

                    FRM_Reporte_Certificado_Libertad()
                Case 37
                    FRM_ReporteHistorialAntecedente()
                Case 54
                    FRM_ReporteHistorialAntecedente_LM()
                Case 50, 51, 52, 32 'listado de ficha final generada
                    FRM_ReporteMovimiento()
                Case 70, 71
                    FRM_ReporteInimputables()
            End Select

        End Sub

#End Region
#Region "Form"
        Private Sub FRM_ReporteHistorialAntecedente_LM()
            Dim frm As New APPReporte.Registro.ReporteCrystal_v2

            With frm
                ._ReporteId = Type.Reporte.Registro.rptListaHistorialAntecedendeJudicial_LM_v1
                ._Filtro.Text = Me.Text
                ._Filtro.DocSolicitudAntecedenteId = -1 ' Me._SolicitudId
                ._Filtro.RegionID = -1 'Me._RegionID
                ._Filtro.RegionNombre = "Oficina Regional de lima"
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.FechaEmisionLong = 0
                ._Filtro.DocumentoNumero = ""
                ._Filtro.Observacion = ""
                ._Filtro.FechaInicio = 0 'Me.FechaInicio
                ._Filtro.FechaFin = 0 'Me.FechaFin
                ._Filtro.MostrarDocAnulados = chkMostrarDocAnulados.Checked
                ' ._Filtro.TipoAntecedenteId = Me.TipoCertAntJudial.GetHashCode
                ._Filtro.Nota = ""
                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_ReporteHistorialAntecedente()
            Dim bss As New Bussines.Registro.DocumentoJudicial
            Dim obj As New Entity.Registro.DocumentoJudicial
            obj.InternoId = Me.InternoID
            If bss.Listar_DocumentosJudiciales(obj).Count = 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con documentos judiciales")
                Exit Sub
            End If
            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                ._ReporteId = Me.GrillaCodigo
                ' ._Filtro.Text = Me.Text
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.InternoIngresoID = -1 'PARA FILTRAR POR INGRESO
                ._Filtro.MostrarDocAnulados = chkMostrarDocAnulados.Checked
                .ShowDialog()
            End With
        End Sub
        Private Sub FRM_Reporte_Certificado_Libertad()

            Dim mensajeValidacion As String = ""
            Dim objBssReporteVal As New Bussines.Registro.Reporte.Validacion

            If objBssReporteVal.validarEmisionCertificadoLibertad(True, Me.InternoID, Me.PenalID, mensajeValidacion) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeValidacion)
                Exit Sub
            End If

            '/*************************************************/
            Dim blnOK As Boolean = False
            Dim frm As New Registro.Reporte.frmReporteDocPopup
linea:
            With frm
                ._pReporteTipo = Me.GrillaCodigo
                ._pInternoID = Me.InternoID
                ._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DocumentoNumero = ._DocumentoNumero
                    Me.FechaEmision = ._FechaEmision

                    Me.Observacion = ._Observacion
                    Me.ProcedenciaPenal = ._Observacion
                    Me.RestriccionCol = .RestriccionCol
                    Me.Nota = ._Nota
                    blnOK = True
                Else
                    blnOK = False
                End If

            End With

            If blnOK = True Then
                FRM_ReporteInterno()
                GoTo linea
            End If
        End Sub
        Private Sub FRM_Reporte_Reniec()
            If Me.GrillaCodigo = 33 Then
                Dim bssRnc As New Bussines.Registro.InternoReniec
                Dim objRnc As New Entity.Registro.InternoReniec
                objRnc.InternoID = Me.InternoID
                If bssRnc.InternoValidado(objRnc) < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Interno pendiente de validación con el RENIEC")
                    Exit Sub
                End If
            End If

            Dim frm As New APPReporte.Registro.Reniec.ReporteCrystal
            With frm
                ._TipoReporte = Me.GrillaCodigo
                ._Filtro.Text = Me.Text

                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                .ShowDialog()
            End With

        End Sub
        Private Sub FRM_Reporte_Constancia_Reclusion()
            Dim tipRes As String = "" 'constancia por RS_ING o RS_TRS
            If VerificarExistenciaResolucionIng(tipRes) = False Then Exit Sub

            Dim blnOK As Boolean = False
            Dim frm As New Registro.Reporte.frmReporteDocPopup
linea:
            With frm
                ._pReporteTipo = Me.GrillaCodigo
                ._pInternoID = Me.InternoID

                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.DocumentoNumero = ._DocumentoNumero
                    Me.FechaEmision = ._FechaEmision
                    Me.Observacion = ._Observacion
                    blnOK = True
                Else
                    blnOK = False
                End If

            End With

            If blnOK = True And tipRes.Length > 0 Then
                FRM_ReporteInterno(tipRes)
                GoTo linea
            End If

        End Sub
        Private Sub FRM_ReporteMovimiento()

            Dim frm As New APPReporte.Registro.Movimiento.ReporteCrystal
            With frm
                ._Filtro.Text = Me.Text
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                ._TipoReporte = Me.GrillaCodigo
                ._TipoLicencia = Me._TipoLicencia
                .ShowDialog()
            End With
        End Sub
        Private Sub FRM_ReporteInimputables()

            Dim frm As New APPReporte.Registro.ReporteCrystal
            With frm
                ._Filtro.Text = Me.Text
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                ._TipoReporte = Me.GrillaCodigo
                ._TipoLicencia = Me._TipoLicencia
                .ShowDialog()
            End With
        End Sub
        Private Sub FRM_ReporteInterno(Optional c_par01 As String = "")

            Dim frm As New APPReporte.Registro.ReporteCrystal
            With frm
                ._TipoReporte = Me.GrillaCodigo
                ._Filtro.Text = Me.Text
                ._TipoLicencia = Me._TipoLicencia
                ._Filtro.RegionID = Me.RegionID
                ._Filtro.RegionNombre = Me.RegionNombre
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.PenalNombre = Me.PenalNombre
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.FechaInicio = Me.FechaInicio
                ._Filtro.FechaFin = Me.FechaFin
                ._Filtro.TipResolString = c_par01
                ._Filtro.FechaISPString = Me.FechaISPString
                ._Filtro.NumeroDocTrasladoStr = Me.NumeroDocTrasladoStr
                ._Filtro.PenalNomOrigenTraslado = Me.PenalNomOrigenTraslado
                ._Filtro.PenalNomDestinoTraslado = Me.PenalNomDestinoTraslado
                ._Filtro.FechaEmision = Now.ToShortDateString
                '/*constancia reclusion*/
                ._VersionRpt = 2
                ._Filtro.DocumentoNumero = Me.DocumentoNumero
                ._Filtro.Observacion = Me.Observacion
                ._Filtro.FechaIngreso = Me.FechaIngresoString
                ._Filtro.PenalProcedencia = Me.ProcedenciaPenal
                ._Filtro.Nota = Me.Nota
                ._pRestriccionCol = Me.RestriccionCol
                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_BuscarInterno()

            If Me._TipoLicencia <> enmTipoLicencia.RegionLimaMetropolitana And Me.PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el penal, para buscar los internos")
                Exit Sub
            End If

            Dim frm As New Registro.Busqueda.frmInternoPopup
            'Dim frm As New Registro.Main.Antecedentes.frmBuscaInternoPopup ' Registro.Busqueda.frmInternoPopup
            With frm
                ._PenalID = Me.PenalID
                If .ShowDialog() = DialogResult.OK Then
                    Me.InternoID = ._GrillaInternoID '._InternoId
                    Me.Interno = ._GrillaApellidosyNombres '._ApellidosNombres

                    'cambio el nombre del interno
                    Me._InternoApeNom = ._GrillaApellidosyNombres ' ._ApellidosNombres

                End If
            End With

        End Sub
        Private Sub FRM_Reporte_Papeleta_Excarcelacion()

            Dim mensajeValidacion As String = ""
            Dim objBssReporteVal As New Bussines.Registro.Reporte.Validacion

            If objBssReporteVal.validarEmisionCertificadoLibertad(True, Me.InternoID, Me.PenalID, mensajeValidacion) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeValidacion)
                Exit Sub
            End If

            Me._TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana
            Me.FechaEmision = Legolas.Components.FechaHora.FechaString(Legolas.LBusiness.Globall.DateTime.FechaServerLong)

            FRM_ReporteInterno()

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarReporte()

            Dim blnRegionPenal As Boolean = False
            Dim blnFechas As Boolean = False
            Dim blnMostrarDocAnulados As Boolean = False
            Dim blnSeleccionarInterno As Boolean = False
            Dim blnSeleccionarInternoTodos As Boolean = False

            Select Case Me._TipoReporte
                Case enmListarReportes.Interno
                    blnRegionPenal = False
                    blnSeleccionarInternoTodos = False
                    blnSeleccionarInterno = True
                    blnFechas = False

                Case enmListarReportes.Todos
                    blnRegionPenal = True
                    blnSeleccionarInternoTodos = True
                    blnSeleccionarInterno = False
                    blnFechas = True
            End Select

            chkMostrarDocAnulados.Visible = False
            ComboPenal()
            Select Case Me.GrillaCodigo

                Case 7, 24, 63, 32, 33, 35, 36, 53, 64 'contancia de reclusion, Movimientos de ingresos y salidas del Interno,Ficha de validación de internos con la RENIEC

                Me.TipoInterno = 1
                    blnSeleccionarInternoTodos = False
                    blnFechas = False
                    HabilitarTipoInterno()

                Case 37  'historial de antecedentes,

                    blnSeleccionarInternoTodos = False
                    blnFechas = False
                    blnMostrarDocAnulados = True
                    Me.TipoInterno = 1
                    HabilitarTipoInterno()

                Case 48  'Ficha de identificación carceleta,

                    blnSeleccionarInternoTodos = False
                    blnFechas = False
                    blnMostrarDocAnulados = False
                    Me.TipoInterno = 1
                    HabilitarTipoInterno()

                Case 26, 27, 28, 29, 30, 31, 34 'Movimiento de ingresos por Penal y sede
                    Me.TipoInterno = 2
                    HabilitarTipoInterno()
                Case 54
                    blnSeleccionarInternoTodos = False
                    blnFechas = False
                    blnMostrarDocAnulados = True
                    Me.TipoInterno = 1
                    HabilitarTipoInterno()
                    chkMostrarDocAnulados.Visible = True
                Case 70, 71
                    blnSeleccionarInternoTodos = True
                    blnFechas = False
                    blnMostrarDocAnulados = True
                    Me.TipoInterno = 0
                    HabilitarTipoInterno()
            End Select

            If blnFechas = False Then
                Me.FechaInicio = 0
                Me.FechaFin = 0
            End If

            Me.grbRegionPenal.Enabled = blnRegionPenal
            Me.grbFechas.Enabled = blnFechas

            Me.grbIncluirDocAnulados.Enabled = blnMostrarDocAnulados

            Me.rdbInternoTodos.Enabled = blnSeleccionarInternoTodos
            Me.rdbSeleccionarInterno.Enabled = blnSeleccionarInterno

            If blnSeleccionarInterno = True Then
                Me.InternoID = Me._InternoID
                Me.Interno = Me._InternoApeNom
            End If

        End Sub
        Private Sub HabilitarTipoInterno()

            Select Case Me.TipoInterno
                Case 1
                    Me.pnlSeleccionarInterno.Enabled = True

                    If Me.InternoID < 1 Then
                        Me.Interno = "[SELECCIONE]"
                    End If

                Case Else

                    Me.InternoID = -1
                    Me.Interno = "[TODOS]"
                    Me.pnlSeleccionarInterno.Enabled = False
            End Select

        End Sub
        Private Sub ValoresxDefault()

            ComboRegion()
            ComboPenal()

            If Me._RegionID > 0 Then
                Me.RegionID = Me._RegionID
            End If
            If Me._PenalID > 0 Then
                Me.PenalID = Me._PenalID
            End If


            If Me._InternoID > 0 Then
                Me.InternoID = Me._InternoID
                Me.Interno = Me._InternoApeNom
            End If

        End Sub
        Private Function ValidarPenalLicencia() As Integer
            Dim PenalLic As Integer = -1
            PenalLic = Legolas.LBusiness.Globall.WinApp.LicenciaApp
            Select Case PenalLic
                Case 66, 67, 68, 69, 70, 71
                    PenalLic = PenalLic
                Case Else
                    PenalLic = -1
            End Select
            Return PenalLic
        End Function
#End Region
        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AOK()
        End Sub

        Private Sub frmReporteHistorialPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub UscBusquedaVisitante1__Buscar_Click() Handles UscLabelBusqueda1._Click_Buscar
            FRM_BuscarInterno()
        End Sub

        Private Sub rdbSeleccionarInterno_Click(sender As Object, e As System.EventArgs) Handles _
            rdbSeleccionarInterno.Click, _
             rdbInternoTodos.Click

            HabilitarTipoInterno()

        End Sub


        Private Sub frmReportePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarReporte()
            HabilitarReporte()
            Me.RegionID = 3 'region lima          
            blnCargoShow = True
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter

            If blnCargoShow = True Then
                HabilitarReporte()
            End If

        End Sub

    End Class
End Namespace