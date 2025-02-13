Imports Type.Enumeracion.Licencia

Namespace Registro.Reporte
    Public Class frmReportePopupv2
        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.PenalProvincia
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

        Public Property _BloquearComboRegion As Boolean = False
        Public Property _BloquearComboPenal As Boolean = False
        '/*/        
        Public Property _EnabledTipoInterno() As Boolean = False
        Private Property RestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol
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
        Private ReadOnly Property GrillaReporteNombre() As String
            Get
                Dim value As String = ""
                Try
                    With Me.dgwGrilla
                        value = .SelectedRows(0).Cells("col_reg_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

#End Region

#Region "Propiedades"
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
                Return Me.cbbPenal.SelectedValue
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
                .Enabled = blnTodos
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

            Dim strReporte As String = ""

            Select Case Me._TipoReporte

                Case enmListarReportes.Todos

                    strReporte = "24,32,33,34,66,70,71,"

                    Dim intTipoLocal As Short = -1
                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    intTipoLocal = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.ListarInteger("app_lic", -1)).Tipo

                    Select Case intTipoLocal
                        Case 1 'penal
                            strReporte = strReporte & "7,26,28,30,37,44,42"
                        Case 2, 3 'region y sede
                            strReporte = strReporte & "27,29,31,37"
                        Case 4 'penales de lima metropolitana
                            strReporte = strReporte & "7,26,28,30,44,42,7"
                    End Select

                Case enmListarReportes.Interno

                    strReporte = "24,32,33,66,37,44,7,42"

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
                Case 25, 32, 33, 66, 42, 44, 37, 24, 48 'contancia de reclusion

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
                    If Me.PenalID < 1 Then
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
        Private Function VerificarExistenciaResolucionIng(ByRef strFechIng_OUT As String) As Boolean
            Dim entIntIng As Entity.Registro.Ingreso

            entIntIng = (New Bussines.Registro.Ingreso).ListarUltimoIngreso(Me.InternoID)
            If entIntIng Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con ningun ingreso vigente")
                Return False
            End If

            'verificar que tenga necesariamente resolucion de ingreso
            Dim entResol As New Entity.Registro.DocumentoJudicial
            Dim entResolCol As New Entity.Registro.DocumentoJudicialCol

            entResol.DocumentoTipo = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Ingreso 'resolucion de ingreso
            entResol.InternoId = Me.InternoID
            entResol.InternoIngresoId = entIntIng.Codigo

            entResolCol = (New Bussines.Registro.DocumentoJudicial).ListarGrilla(entResol)

            Dim bolExisteResIng As Boolean = False
            Dim strFechaIng As String = ""

            If entResolCol Is Nothing Then
                bolExisteResIng = False
            ElseIf entResolCol.Count < 1 Then
                bolExisteResIng = False
            Else
                'recorrer la coleccion y verificar que no esten de baja la resolucion
                For Each obj As Entity.Registro.DocumentoJudicial In entResolCol
                    strFechaIng = obj.DocumentoFechaDate
                    bolExisteResIng = True
                    Exit For
                Next
            End If


            If bolExisteResIng = False Then 'sino tiene resolucion de ingreso
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El interno no cuenta con una Resolución de Ingreso vigente para el ingreso Nª: " & entIntIng.IngresoNro)
                Return False
            End If
            strFechIng_OUT = strFechaIng
            Return True
        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            Select Case Me.GrillaCodigo

                Case 7
                    FRM_Reporte_Papeleta_Excarcelacion()

                Case 24, 53 'ficha decadactilar 

                    FRM_ReporteInterno()

                Case 42 '25 'constanacia de reclusion

                    Dim strFechIng_OUT As String = ""
                    If VerificarExistenciaResolucionIng(strFechIng_OUT) = False Then Exit Sub
                    Me.FechaIngresoString = strFechIng_OUT
                    FRM_Reporte_Constancia_Reclusion()

                Case 33, 34

                    FRM_Reporte_Reniec()
                Case 66, 48

                    Dim strFechIng_OUT As String = ""
                    Me.FechaIngresoString = strFechIng_OUT
                    FRM_ReporteInterno()

                Case 36, 44 'certificado de libertad

                    FRM_Reporte_Certificado_Libertad()
                Case 37
                    FRM_ReporteHistorialAntecedente()
                Case 70, 71
                    FRM_ReporteInimputables()
                Case Else
                    FRM_ReporteMovimiento()
            End Select

        End Sub

#End Region
#Region "Form"
        Private Sub FRM_Reporte_Papeleta_Excarcelacion()

            '/*************************************************/
            Dim blnOK As Boolean = False
            Dim strMensaje As String = "Esta seguro de generar el reporte"

            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Dim mensajeValidacion As String = ""
            Dim objBssReporteVal As New Bussines.Registro.Reporte.Validacion
            If objBssReporteVal.validarEmisionCertificadoLibertad(False, Me.InternoID, Me.PenalID, mensajeValidacion) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(mensajeValidacion)
                Exit Sub
            End If

            Dim FechaEmision As Long = Today.Date.ToFileTime()
            Dim FechaEmisionString As String = Legolas.Components.FechaHora.FechaString(FechaEmision)
            Me.FechaEmision = FechaEmisionString

            FRM_ReporteInterno()

        End Sub
        Private Sub FRM_ReporteHistorialAntecedente()
            Dim frm As New APPReporte.Registro.ReporteCrystal_v2
            With frm
                ._ReporteId = Type.Reporte.Registro.rptListaHistorialAntecedendeJudicial
                ._Filtro.Text = Me.GrillaReporteNombre
                ._Filtro.RegionID = Me._RegionID
                ._Filtro.PenalID = Me.PenalID
                ._Filtro.InternoID = Me.InternoID
                ._Filtro.MostrarDocAnulados = Me.chkMostrarDocAnulados.Checked
                .ShowDialog()
            End With
        End Sub
        Private Sub FRM_Reporte_Certificado_Libertad()

            Dim mensajeValidacion As String = ""
            Dim objBssReporteVal As New Bussines.Registro.Reporte.Validacion

            If objBssReporteVal.validarEmisionCertificadoLibertad(False, Me.InternoID, Me.PenalID, mensajeValidacion) = False Then
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

            If blnOK = True Then
                FRM_ReporteInterno()
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
        Private Sub FRM_ReporteInterno()

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
                '/*constancia reclusion*/
                ._VersionRpt = 2
                ._Filtro.DocumentoNumero = Me.DocumentoNumero
                ._Filtro.Observacion = Me.Observacion
                ._Filtro.FechaIngreso = Me.FechaIngresoString
                ._Filtro.PenalProcedencia = Me.ProcedenciaPenal
                ._Filtro.Nota = Me.Nota
                ._pRestriccionCol = Me.RestriccionCol
                ._Filtro.FechaEmision = Me.FechaEmision
                .ShowDialog()
            End With

        End Sub

        Private Sub FRM_BuscarInterno()

            If Me.PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el penal, para buscar los internos")
                Exit Sub
            End If

            Dim frm As New Registro.Busqueda.frmInternoPopup
            With frm
                ._RegionID = Me.RegionID
                ._PenalID = Me.PenalID
                ._VisibleRegionPenal = False

                If .ShowDialog() = DialogResult.OK Then
                    Me.InternoID = ._GrillaInternoID
                    Me.Interno = ._GrillaApellidosyNombres

                    'cambio el nombre del interno
                    Me._InternoID = ._GrillaInternoID
                    Me._InternoApeNom = ._GrillaApellidosyNombres

                End If
            End With
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

            Select Case Me.GrillaCodigo


                Case 24, 25, 32, 33, 66, 36, 42, 44, 53, 7 'contancia de reclusion, Movimientos de ingresos y salidas del Interno,Ficha de validación de internos con la RENIEC

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
                    chkMostrarDocAnulados.Visible = True
                Case 48  'Ficha de identificación carceleta,

                    blnSeleccionarInternoTodos = False
                    blnFechas = False
                    blnMostrarDocAnulados = True
                    Me.TipoInterno = 1
                    HabilitarTipoInterno()
                    chkMostrarDocAnulados.Enabled = False
                Case 26, 27, 28, 29, 30, 31, 34 'Movimiento de ingresos por Penal y sede
                    Me.TipoInterno = 2
                    HabilitarTipoInterno()
                Case 70, 71
                    Me.TipoInterno = 2
                    HabilitarTipoInterno()
                    blnSeleccionarInternoTodos = True
                    blnFechas = False
                    blnMostrarDocAnulados = False
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

            cbbRegion.Enabled = Not Me._BloquearComboRegion
            cbbPenal.Enabled = Not Me._BloquearComboPenal

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
            rdbSeleccionarInterno.Click,
             rdbInternoTodos.Click

            HabilitarTipoInterno()

        End Sub


        Private Sub frmReportePopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ListarReporte()
            HabilitarReporte()
        End Sub

        Private Sub dgwGrilla_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellClick

            'HabilitarReporte()

        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged

            ComboPenal()

        End Sub

        Private Sub dgwGrilla_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellEnter
            HabilitarReporte()
        End Sub

        Private Sub dgwGrilla_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwGrilla.CellContentClick

        End Sub

        Private Sub UscLabelBusqueda1_Load(sender As System.Object, e As System.EventArgs) Handles UscLabelBusqueda1.Load

        End Sub

        Private Sub rdbInternoTodos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbInternoTodos.CheckedChanged

        End Sub
    End Class
End Namespace