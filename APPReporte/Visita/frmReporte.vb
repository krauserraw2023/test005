Imports Microsoft.Reporting.WinForms
Namespace Visita
    Public Class frmReporte
        'Private p_Version() As Microsoft.Reporting.WinForms.ReportParameter 'version
        'Private p_Mac() As Microsoft.Reporting.WinForms.ReportParameter 'mac
        'Private p_Usuario() As Microsoft.Reporting.WinForms.ReportParameter 'usuario
        'Private p_FechayHoraReporte() As Microsoft.Reporting.WinForms.ReportParameter 'fecha y hora reporte
        'Private p_Acta() As Microsoft.Reporting.WinForms.ReportParameter 'acta           
        'Private p_Filtro() As Microsoft.Reporting.WinForms.ReportParameter 'filtro
        'Private p_Region() As Microsoft.Reporting.WinForms.ReportParameter
        'Private p_Penal() As Microsoft.Reporting.WinForms.ReportParameter
        '/**/
        Private blnRep As Boolean = False
        Private frmLoad As Load.frmLoad = Nothing
        Private objEntCol As Object = Nothing
        Private objBss As Bussines.Reporte.Visita = Nothing
#Region "Propiedades_Reporte"
        Private intTipoReporte As Type.Reporte.Visita = Type.Reporte.Visita.rpt
        Private strReporteModulo As String = ""
        Private strReporteModuloVersion As String = ""
        Private strReporteNombre As String = ""
        Private strReporteNombreFisico As String = ""
        Private strReporteActa As String = ""
        Private strReporteDependencia As String = ""
        Private intReporteNumero As Integer = 0
        Private intReporteNumeroExportacion As Integer = 0
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._TipoReporte.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _TipoReporte() As Type.Reporte.Visita
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As Type.Reporte.Visita)
                intTipoReporte = value
            End Set
        End Property
        Private Property ReporteNombre() As String
            Get
                Return strReporteNombre
            End Get
            Set(ByVal value As String)
                strReporteNombre = value
            End Set
        End Property
        Private Property ReporteNombreFisico() As String
            Get
                Return strReporteNombreFisico
            End Get
            Set(ByVal value As String)
                strReporteNombreFisico = value
            End Set
        End Property
        Private ReadOnly Property ReporteNombreFisicoPath() As String
            Get
                Dim strValue As String = ""
                Dim strNumero As String = ""

                If Me.ReporteNumero > 0 Then
                    strNumero = Me.ReporteNumeroString(False)
                Else
                    strNumero = Me.ReporteNumeroExportacionString(False)
                End If
                strValue = Legolas.Configuration.Path.PathTemp & Me.ReporteNombreFisico
                strValue = strValue & "."
                strValue = strValue & strNumero
                strValue = strValue & ".pdf"
                Return strValue
            End Get

        End Property
        Private Property ReporteDependencia() As String
            Get
                Return strReporteDependencia
            End Get
            Set(ByVal value As String)
                strReporteDependencia = value
            End Set
        End Property
        Private Property ReporteModulo() As String
            Get
                Return strReporteModulo
            End Get
            Set(ByVal value As String)
                strReporteModulo = value
            End Set
        End Property
        Private Property ReporteModuloVersion() As String
            Get
                Return strReporteModuloVersion
            End Get
            Set(ByVal value As String)
                strReporteModuloVersion = value
            End Set
        End Property
        Private Property ReporteActa() As String
            Get
                Return strReporteActa
            End Get
            Set(ByVal value As String)
                strReporteActa = value
            End Set
        End Property

        Private Property ReporteNumero() As Integer
            Get
                Return intReporteNumero
            End Get
            Set(ByVal value As Integer)
                intReporteNumero = value
            End Set
        End Property
        Private Property ReporteNumeroExportacion() As Integer
            Get
                Return intReporteNumeroExportacion
            End Get
            Set(ByVal value As Integer)
                intReporteNumeroExportacion = value
            End Set
        End Property
        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""
                Select Case Legolas.Components.PC.PCNombre.ToUpper

                    Case "00110-13", "00110-27"

                        If Legolas.Components.Archivo.DirectorioExiste(My.Application.Info.DirectoryPath & "\Visita\") = True Then
                            value = My.Application.Info.DirectoryPath & "\Visita\"
                        Else
                            value = Legolas.Configuration.Path.PathReporte & "Visita\"
                        End If

                    Case Else
                        value = Legolas.Configuration.Path.PathReporte & "Visita\"
                End Select
                Return value
            End Get
        End Property
#Region "Functions"

        Private Function FechayHora() As String

            Dim strValue As String = ""
            Dim strFecha As String = Legolas.Configuration.Aplication.FechayHora.FechaString
            Dim dteHora As Date = Now.ToShortTimeString

            dteHora = Legolas.LBusiness.Globall.DateTime.HoraServer
            strValue = strFecha & " " & dteHora.ToLongTimeString
            Return strValue

        End Function
        Private Function ReporteNumeroString(Optional ByVal VisibleTexto As Boolean = True) As String

            Dim value As String = ""

            If VisibleTexto = True Then
                value = "Nro. Impresión: " & Me.ReporteNumero.ToString("000000")
            Else
                value = Me.ReporteNumero.ToString("000000")
            End If

            Return value

        End Function
        Private Function ReporteNumeroExportacionString(Optional ByVal VisibleTexto As Boolean = True) As String

            Dim value As String = ""

            If VisibleTexto = True Then
                value = "Nro. Exportación: " & Me.ReporteNumeroExportacion.ToString("000000")
            Else
                value = Me.ReporteNumeroExportacion.ToString("000000")
            End If

            Return value

        End Function
#End Region

#End Region
#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Visita.Filtro
#End Region
#Region "Reporte"
        Private Sub ListarPropiedadesReporte()

            Dim objEnt As New Legolas.LEntity.Globall.Reporte
            Dim objBssRpt As New Legolas.LBusiness.Globall.Reporte

            objEnt = objBssRpt.Listar(Me.ReporteID)

            With objEnt
                Me.ReporteNombre = .Nombre
                Me.ReporteNombreFisico = .NombreFisico
                Me.ReporteDependencia = .DependenciaNombre
                Me.ReporteModulo = .Modulo
                Me.ReporteModuloVersion = .Version
                Me.ReporteActa = .Acta
            End With

        End Sub
        Private Function Listar() As Boolean

            Dim objBss As New Bussines.Reporte.Visita

            ListarPropiedadesReporte()

            Select Case Me._TipoReporte

                Case Type.Reporte.Visita.rptVisitaMovimiento

                    Me._Filtro.Text = "Del " & Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio) & _
                    " Hasta " & Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFin)

                    objBss = New Bussines.Reporte.Visita
                    objEntCol = New Entity.Reporte.Visita.MovimientoCol

                    objEntCol = objBss.VisitaMovimiento(Me._Filtro)

                Case Type.Reporte.Visita.rptSancionInterno

                    objBss = New Bussines.Reporte.Visita
                    objEntCol = New Entity.Reporte.Visita.SancionInternoCol

                    objEntCol = objBss.SancionInternos(Me._Filtro)

                Case Type.Reporte.Visita.rptSancionVisitante

                    objBss = New Bussines.Reporte.Visita
                    objEntCol = New Entity.Reporte.Visita.SancionVisitaCol

                    objEntCol = objBss.SancionVisitantes(Me._Filtro)

                Case Type.Reporte.Visita.rptHistorialVisitante

                    Me._Filtro.Text = "Del " & Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio) & _
                    " Hasta " & Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFin)

                    objBss = New Bussines.Reporte.Visita
                    objEntCol = New Entity.Reporte.Visita.SancionVisitaCol

                    objEntCol = objBss.HistorialVisitante(Me._Filtro)

                Case Type.Reporte.Visita.rptHistorialInterno

                    Me._Filtro.Text = "Del " & Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio) & _
                    " Hasta " & Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFin)

                    objBss = New Bussines.Reporte.Visita
                    objEntCol = New Entity.Reporte.Visita.SancionInternoCol

                    objEntCol = objBss.HistorialInterno(Me._Filtro)

                Case Type.Reporte.Visita.rptAutorizacion

                    Me._Filtro.Text = "Autorizados"

                    objBss = New Bussines.Reporte.Visita
                    objEntCol = New Entity.Reporte.Visita.SancionInternoCol

                    objEntCol = objBss.Autorizacion(Me._Filtro)

            End Select

            Return True

        End Function

        Private Sub VisitaMovimiento(Optional ByVal Impresion As Boolean = False, _
            Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Movimiento de Visitas"

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(5) {}
            parameters(0) = New ReportParameter("p_version", ReporteModuloVersion)
            parameters(1) = New ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
            parameters(2) = New ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(3) = New ReportParameter("p_fecha", FechayHora)
            parameters(4) = New ReportParameter("p_acta", ReporteActa)
            parameters(5) = New ReportParameter("p_filtro", Me._Filtro.Text)

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptVisita"
                .LocalReport.ReportPath = Me.ReportePath & "rptVisita.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Visita_MovimientoCol", objEntCol))
                .LocalReport.SetParameters(parameters)

                ''/*datos de penales*/
                'Dim objBSource As New BindingSource
                'Dim objRDS As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource.DataSource = objEntCol
                'objRDS.Name = "Entity_Reporte_Visita_MovimientoCol"
                'objRDS.Value = objBSource

                ''/*parametros*/                            
                ''/*version*/
                'p_Version = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Version(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(p_Version)
                ''/*mac*/
                'p_Mac = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Mac(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(p_Mac)
                ''/*usuario*/
                'p_Usuario = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Usuario(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(p_Usuario)
                ''/*fecha y hora reporte*/                   
                'p_FechayHoraReporte = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_FechayHoraReporte(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fecha", Me.FechayHora)
                '.LocalReport.SetParameters(p_FechayHoraReporte)
                ''/*acta*/
                'p_Acta = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Acta(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_acta", Me.ReporteActa)
                '.LocalReport.SetParameters(p_Acta)
                ''/*filtro*/
                'p_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me._Filtro.Text)
                '.LocalReport.SetParameters(p_Filtro)


                If Impresion = False Then
                    '.RefreshReport()
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    'objBssRpt = New Legolas.LBusiness.Globall.Reporte

                    'If ExportarPDF = True Then
                    '    '/*exportacion*/
                    '    Me.ReporteNumeroExportacion = objBssRpt.ObtenerCodigoExportacion(Me.ReporteID)
                    '    par8 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    '    par8(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", Me.ReporteNumeroExportacionString)
                    'Else
                    '    '/*impresion*/
                    '    Me.ReporteNumero = objBssRpt.ObtenerCodigo(Me.ReporteID)
                    '    par8 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    '    par8(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", Me.ReporteNumeroString)
                    'End If

                    '.RefreshReport()
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With

        End Sub
        Private Sub SancionInterno(Optional ByVal Impresion As Boolean = False, _
            Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Sancion de Internos"

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(5) {}
            parameters(0) = New ReportParameter("p_version", ReporteModuloVersion)
            parameters(1) = New ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
            parameters(2) = New ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(3) = New ReportParameter("p_fecha", FechayHora)
            parameters(4) = New ReportParameter("p_acta", ReporteActa)
            parameters(5) = New ReportParameter("p_filtro", Me._Filtro.Text)

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptSancionInterno"
                .LocalReport.ReportPath = Me.ReportePath & "rptSancionInterno.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Visita_SancionInternoCol", objEntCol))
                .LocalReport.SetParameters(parameters)

                ''/*datos de penales*/
                'Dim objBSource As New BindingSource
                'Dim objRDS As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource.DataSource = objEntCol
                'objRDS.Name = "Entity_Reporte_Visita_SancionInternoCol"
                'objRDS.Value = objBSource

                ''/*parametros*/            
                ''/*version*/
                'p_Version = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Version(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(p_Version)
                ''/*mac*/
                'p_Mac = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Mac(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(p_Mac)
                ''/*usuario*/
                'p_Usuario = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Usuario(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(p_Usuario)
                ''/*fecha y hora reporte*/                   
                'p_FechayHoraReporte = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_FechayHoraReporte(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fecha", Me.FechayHora)
                '.LocalReport.SetParameters(p_FechayHoraReporte)
                ''/*acta*/
                'p_Acta = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Acta(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_acta", Me.ReporteActa)
                '.LocalReport.SetParameters(p_Acta)
                ''/*filtro*/
                'p_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me._Filtro.Text)
                '.LocalReport.SetParameters(p_Filtro)

                If Impresion = False Then
                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    'objBssRpt = New Legolas.LBusiness.Globall.Reporte

                    'If ExportarPDF = True Then
                    '    '/*exportacion*/
                    '    Me.ReporteNumeroExportacion = objBssRpt.ObtenerCodigoExportacion(Me.ReporteID)
                    '    par8 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    '    par8(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", Me.ReporteNumeroExportacionString)
                    'Else
                    '    '/*impresion*/
                    '    Me.ReporteNumero = objBssRpt.ObtenerCodigo(Me.ReporteID)
                    '    par8 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    '    par8(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", Me.ReporteNumeroString)
                    'End If

                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With

        End Sub
        Private Sub SancionVisitante(Optional ByVal Impresion As Boolean = False, _
            Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Sancion de Visitas"

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(5) {}
            parameters(0) = New ReportParameter("p_version", ReporteModuloVersion)
            parameters(1) = New ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
            parameters(2) = New ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(3) = New ReportParameter("p_fecha", FechayHora)
            parameters(4) = New ReportParameter("p_acta", ReporteActa)
            parameters(5) = New ReportParameter("p_filtro", Me._Filtro.Text)

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptSancionVisita"
                .LocalReport.ReportPath = Me.ReportePath & "rptSancionVisita.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Visita_SancionVisitaCol", objEntCol))

                ''/*datos de penales*/
                'Dim objBSource As New BindingSource
                'Dim objRDS As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource.DataSource = objEntCol
                'objRDS.Name = "Entity_Reporte_Visita_SancionVisitaCol"
                'objRDS.Value = objBSource

                ''/*parametros*/            
                ''/*version*/
                'p_Version = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Version(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(p_Version)
                ''/*mac*/
                'p_Mac = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Mac(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(p_Mac)
                ''/*usuario*/
                'p_Usuario = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Usuario(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(p_Usuario)
                ''/*fecha y hora reporte*/                   
                'p_FechayHoraReporte = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_FechayHoraReporte(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fecha", Me.FechayHora)
                '.LocalReport.SetParameters(p_FechayHoraReporte)
                ''/*acta*/
                'p_Acta = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Acta(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_acta", Me.ReporteActa)
                '.LocalReport.SetParameters(p_Acta)
                ''/*filtro*/
                'p_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me._Filtro.Text)
                '.LocalReport.SetParameters(p_Filtro)

                If Impresion = False Then
                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    'objBssRpt = New Legolas.LBusiness.Globall.Reporte

                    'If ExportarPDF = True Then
                    '    '/*exportacion*/
                    '    Me.ReporteNumeroExportacion = objBssRpt.ObtenerCodigoExportacion(Me.ReporteID)
                    '    par8 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    '    par8(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", Me.ReporteNumeroExportacionString)
                    'Else
                    '    '/*impresion*/
                    '    Me.ReporteNumero = objBssRpt.ObtenerCodigo(Me.ReporteID)
                    '    par8 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    '    par8(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", Me.ReporteNumeroString)
                    'End If

                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With

        End Sub
        Private Sub HistorialVisitante(Optional ByVal Impresion As Boolean = False, _
            Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Historial del Visitante"

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(7) {}
            parameters(0) = New ReportParameter("p_version", ReporteModuloVersion)
            parameters(1) = New ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
            parameters(2) = New ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(3) = New ReportParameter("p_fecha", FechayHora)
            parameters(4) = New ReportParameter("p_acta", ReporteActa)
            parameters(5) = New ReportParameter("p_filtro", Me._Filtro.Text)
            parameters(6) = New ReportParameter("p_region", "")
            parameters(7) = New ReportParameter("p_penal", "")

            If objEntCol.Count > 0 Then
                parameters(6) = New ReportParameter("p_region", objEntCol(0).Par_Region.ToString)
                parameters(7) = New ReportParameter("p_penal", objEntCol(0).Par_Penal.ToString)
            End If

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptHistorialVisitante"
                .LocalReport.ReportPath = Me.ReportePath & "rptHistorialVisitante.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Visita_HistorialVisitanteCol", objEntCol))
                .LocalReport.SetParameters(parameters)

                'Dim objBSource As New BindingSource
                'Dim objRDS As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource.DataSource = objEntCol
                'objRDS.Name = "Entity_Reporte_Visita_HistorialVisitanteCol"
                'objRDS.Value = objBSource

                ''/*parametros*/                            
                ''/*version*/
                'p_Version = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Version(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(p_Version)
                ''/*mac*/
                'p_Mac = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Mac(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(p_Mac)
                ''/*usuario*/
                'p_Usuario = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Usuario(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(p_Usuario)
                ''/*fecha y hora reporte*/                   
                'p_FechayHoraReporte = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_FechayHoraReporte(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fecha", Me.FechayHora)
                '.LocalReport.SetParameters(p_FechayHoraReporte)
                ''/*acta*/
                'p_Acta = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Acta(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_acta", Me.ReporteActa)
                '.LocalReport.SetParameters(p_Acta)
                ''/*filtro*/
                'p_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me._Filtro.Text)
                '.LocalReport.SetParameters(p_Filtro)

                'If objEntCol.Count > 0 Then
                '    '/*region*/
                '    p_Region = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                '    p_Region(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_region", objEntCol(0).Par_Region.ToString)
                '    .LocalReport.SetParameters(p_Region)
                '    '/*penal*/
                '    p_Penal = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                '    p_Penal(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_penal", objEntCol(0).Par_Penal.ToString)
                '    .LocalReport.SetParameters(p_Penal)
                'End If

                If Impresion = False Then
                    '.RefreshReport()
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    '.RefreshReport()
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(objRDS)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With

        End Sub
        Private Sub HistorialInterno()

            Me.Text = "Reporte - Historial del Interno"

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(7) {}
            parameters(0) = New ReportParameter("p_version", ReporteModuloVersion)
            parameters(1) = New ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
            parameters(2) = New ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(3) = New ReportParameter("p_fecha", FechayHora)
            parameters(4) = New ReportParameter("p_acta", ReporteActa)
            parameters(5) = New ReportParameter("p_filtro", Me._Filtro.Text)
            parameters(6) = New ReportParameter("p_region", "")
            parameters(7) = New ReportParameter("p_penal", "")

            If objEntCol.Count > 0 Then
                parameters(6) = New ReportParameter("p_region", objEntCol(0).Par_Region.ToString)
                parameters(7) = New ReportParameter("p_penal", objEntCol(0).Par_Penal.ToString)
            End If

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptHistorialInterno"
                .LocalReport.ReportPath = Me.ReportePath & "rptHistorialInterno.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Visita_HistorialInternoCol", objEntCol))

                .LocalReport.SetParameters(parameters)

                'Dim objBSource As New BindingSource
                'Dim objRDS As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource.DataSource = objEntCol
                'objRDS.Name = "Entity_Reporte_Visita_HistorialInternoCol"
                'objRDS.Value = objBSource

                ''/*parametros*/                            
                ''/*version*/
                'p_Version = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Version(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(p_Version)
                ''/*mac*/
                'p_Mac = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Mac(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(p_Mac)
                ''/*usuario*/
                'p_Usuario = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Usuario(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(p_Usuario)
                ''/*fecha y hora reporte*/                   
                'p_FechayHoraReporte = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_FechayHoraReporte(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fecha", Me.FechayHora)
                '.LocalReport.SetParameters(p_FechayHoraReporte)
                ''/*acta*/
                'p_Acta = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Acta(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_acta", Me.ReporteActa)
                '.LocalReport.SetParameters(p_Acta)
                ''/*filtro*/
                'p_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me._Filtro.Text)
                '.LocalReport.SetParameters(p_Filtro)

                'If objEntCol.Count > 0 Then
                '    '/*region*/
                '    p_Region = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                '    p_Region(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_region", objEntCol(0).LicenciaRegion.ToString)
                '    .LocalReport.SetParameters(p_Region)
                '    '/*penal*/
                '    p_Penal = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                '    p_Penal(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_penal", objEntCol(0).LicenciaPenal.ToString)
                '    .LocalReport.SetParameters(p_Penal)
                'End If

                '.RefreshReport()
                '.LocalReport.DataSources.Clear()
                '.LocalReport.SetParameters(p)
                '.LocalReport.DataSources.Add(objRDS)
                .RefreshReport()
                .DocumentMapCollapsed = True
            End With

        End Sub
        Private Sub VerReporte(Optional ByVal Impresion As Boolean = False, _
        Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)

            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            frmLoad.ShowDialog()
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            Select Case Me._TipoReporte

                Case Type.Reporte.Visita.rptVisitaMovimiento

                    If blnRep = True Then
                        VisitaMovimiento(Impresion, Oficina, ExportarPDF)
                    End If

                Case Type.Reporte.Visita.rptSancionInterno

                    If blnRep = True Then
                        SancionInterno(Impresion, Oficina, ExportarPDF)
                    End If

                Case Type.Reporte.Visita.rptSancionVisitante

                    If blnRep = True Then
                        SancionVisitante(Impresion, Oficina, ExportarPDF)
                    End If

                Case Type.Reporte.Visita.rptHistorialVisitante

                    If blnRep = True Then
                        HistorialVisitante(Impresion, Oficina, ExportarPDF)
                    End If

                Case Type.Reporte.Visita.rptHistorialInterno

                    If blnRep = True Then
                        HistorialInterno()
                    End If

            End Select

        End Sub
#End Region
#Region "Accion"
        Private Sub Exportar(ByVal PathFile As String, ByVal Formato As String)

            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim bytPDF As Byte()

            bytPDF = Me.ReportViewer1.LocalReport.Render(Formato, _
            Nothing, mimeType, encoding, extension, streamids, warnings)

            Legolas.Components.Archivo.FileCreateByte(bytPDF, PathFile)

        End Sub
#End Region

        Private Sub frmReporte_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            VerReporte()

        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

            If Me.BackgroundWorker1.IsBusy Then Exit Sub
            ' inicializa la validacion del ping
            Me.BackgroundWorker1.RunWorkerAsync()

        End Sub

        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            e.Result = Listar()

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()
            Dim result As Boolean = False
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                Me.Timer1.Stop()
                frmLoad.Close()
                result = e.Result
                blnRep = result
                ' procesa el resultado del metodo ping              
            End If

        End Sub

        Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

            Me.Close()

        End Sub

        Private Sub frmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.ReportViewer1.RefreshReport()
        End Sub
    End Class
End Namespace
