Imports Microsoft.Reporting.WinForms
Namespace Estadistica
    Public Class frmReporte
        'Private par1() As Microsoft.Reporting.WinForms.ReportParameter 'dependencia
        'Private par2() As Microsoft.Reporting.WinForms.ReportParameter 'modulo
        'Private par3() As Microsoft.Reporting.WinForms.ReportParameter 'version
        'Private par4() As Microsoft.Reporting.WinForms.ReportParameter 'mac
        'Private par5() As Microsoft.Reporting.WinForms.ReportParameter 'usuario
        'Private par6() As Microsoft.Reporting.WinForms.ReportParameter 'fecha y hora reporte
        'Private par7() As Microsoft.Reporting.WinForms.ReportParameter 'acta   
        'Private par8() As Microsoft.Reporting.WinForms.ReportParameter 'impresion
        'Private par9() As Microsoft.Reporting.WinForms.ReportParameter 'filtro
        'Private par10() As Microsoft.Reporting.WinForms.ReportParameter 'correlativo
        'Private par11() As Microsoft.Reporting.WinForms.ReportParameter 'fecha de corte
        'Private par12() As Microsoft.Reporting.WinForms.ReportParameter 'anulado
        '/**/
        Private blnRep As Boolean = False
        Private frmLoad As Load.frmLoad = Nothing
        Private objEntCol As Object = Nothing
        Private objEntCol2 As Object = Nothing
        Private objBssRpt As Legolas.LBusiness.Globall.Reporte
#Region "Enum"
        Public Enum EnmTipoReporte
            rpt = -1
            rptReporte1 = 1
            rptReporte2 = 2
            rptReporte3 = 3
        End Enum
        Public Enum EnmNaciolidad
            Todos = -1
            Nacional = 1
            Extranjeros = 2
        End Enum
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As EnmTipoReporte = EnmTipoReporte.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1

                intCodigoReporte = Me._pReporteTipo.GetHashCode

                Return intCodigoReporte
            End Get
        End Property
        Public Property _pReporteTipo() As EnmTipoReporte
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As EnmTipoReporte)
                intTipoReporte = value
            End Set
        End Property
        Private Property ReporteModulo() As String = ""
        Private Property ReporteModuloVersion() As String = ""
        Private Property ReporteNombre() As String = ""
        Private Property ReporteNombreFisico() As String = ""
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
        Private Property ReporteActa() As String = ""
        Private Property ReporteDependencia() As String = ""
        Private Function FechayHora() As String

            Dim strValue As String = ""
            Dim strFecha As String = Legolas.Configuration.Aplication.FechayHora.FechaString
            Dim dteHora As Date = Now.ToShortTimeString

            dteHora = Legolas.LBusiness.Globall.DateTime.HoraServer
            strValue = strFecha & " " & dteHora.ToLongTimeString
            Return strValue

        End Function
        Private Property ReporteNumero() As Integer = 0
        Private Function ReporteNumeroString(Optional ByVal VisibleTexto As Boolean = True) As String

            Dim value As String = ""

            If VisibleTexto = True Then
                value = "Nro. Impresión: " & Me.ReporteNumero.ToString("000000")
            Else
                value = Me.ReporteNumero.ToString("000000")
            End If

            Return value

        End Function
        Private Property ReporteNumeroExportacion() As Integer = 0
        Private Function ReporteNumeroExportacionString(Optional ByVal VisibleTexto As Boolean = True) As String

            Dim value As String = ""

            If VisibleTexto = True Then
                value = "Nro. Exportación: " & Me.ReporteNumeroExportacion.ToString("000000")
            Else
                value = Me.ReporteNumeroExportacion.ToString("000000")
            End If

            Return value

        End Function
        'Private ReadOnly Property ReportePath() As String
        '    Get
        '        Return Legolas.Configuration.Path.PathReporte & "Estadistica\"
        '    End Get
        'End Property

        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""
                Select Case Legolas.Components.PC.PCNombre.ToUpper

                    Case "00110-13", "00110-27"

                        If Legolas.Components.Archivo.DirectorioExiste(My.Application.Info.DirectoryPath & "\Estadistica\") = True Then
                            value = My.Application.Info.DirectoryPath & "\Estadistica\"
                        Else
                            value = Legolas.Configuration.Path.PathReporte & "Estadistica\"
                        End If

                    Case Else
                        value = Legolas.Configuration.Path.PathReporte & "Estadistica\"
                End Select
                Return value
            End Get
        End Property

#End Region
#Region "Propiedades"
        Private intPenalID As Integer = -1
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
#End Region
#Region "Propiedades_ReporteFormato1"
        Public Property _PadinID() As Integer = -1
        Public Property _Anio() As Integer = -1
        Public Property _Mes() As Integer = -1
        Public Property _FechaInicio As Long = 0
        Public Property _FechaFin As Long = 0
        Public Property _Correlativo() As Integer = 0
        Public Property _VersionReporte As Integer = -1
        Public Property _EstadoPadin() As Integer = -1
#End Region
#Region "Propiedades_Reporte2"
        Private intNacionalidad As EnmNaciolidad = EnmNaciolidad.Todos
        Public Property _Nacionalidad() As EnmNaciolidad
            Get
                Return intNacionalidad
            End Get
            Set(ByVal value As EnmNaciolidad)
                intNacionalidad = value
            End Set
        End Property
        Private ReadOnly Property NacionalidadTitulo() As String
            Get
                Dim strValue As String = ""

                Select Case Me._Nacionalidad
                    Case EnmNaciolidad.Nacional
                        strValue = "Peruanos"
                    Case EnmNaciolidad.Extranjeros
                        strValue = "Extranjeros"
                    Case EnmNaciolidad.Todos
                        strValue = "Peruanos y Extranjeros"
                End Select
                Return strValue
            End Get
        End Property
#End Region
#Region "Propiedades_Otros"
        Private strFiltro As String = ""
        Public Property Filtro() As String
            Get
                Return strFiltro
            End Get
            Set(ByVal value As String)
                strFiltro = value.ToUpper
            End Set
        End Property
#End Region
#Region "Reporte"
        Private Sub ListarPropiedadesReporte()

            Dim objEnt As New Legolas.LEntity.Globall.Reporte
            objBssRpt = New Legolas.LBusiness.Globall.Reporte

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

            Dim objBss As New Bussines.Reporte.Estadistica

            If Me._PenalID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.MensajeError("Parametro PenalID, no ingresado")
                Return False
            End If

            Select Case Me._pReporteTipo
                Case EnmTipoReporte.rptReporte1

                    Me.Filtro = Legolas.Components.FechaHora.MesNombre(Me._Mes) & " DE " & Me._Anio

                    objEntCol = New Entity.Reporte.Estadistica.Formato1Col
                    objEntCol = objBss.FormatoF1(Me._PadinID, Me._PenalID, Me._FechaInicio, Me._FechaFin, Me._VersionReporte)

                Case EnmTipoReporte.rptReporte2

                    Me.Filtro = Legolas.Components.FechaHora.MesNombre(Me._Mes) & " DE " & Me._Anio

                    objEntCol = New Entity.Reporte.Estadistica.Reporte02Col
                    objEntCol = objBss.Reporte2(Me._PadinID, Me._PenalID, Me._Nacionalidad)

                    'listar datos del penal
                    objEntCol2 = New Entity.Reporte.Estadistica.Formato1Col
                    objEntCol2 = objBss.FormatoF1_2(Me._PadinID, Me._PenalID, Me._FechaInicio, Me._FechaFin)

                Case EnmTipoReporte.rptReporte3

                    Me.Filtro = Legolas.Components.FechaHora.MesNombre(Me._Mes) & " DE " & Me._Anio

                    Dim dteFecha As Date = Now
                    dteFecha = DateAdd(DateInterval.Year, -3, Legolas.Configuration.Aplication.FechayHora.FechaDate)

                    objEntCol = New Entity.Reporte.Estadistica.Reporte03Col
                    objEntCol = objBss.Reporte3(Me._PadinID, Me._PenalID, dteFecha.ToFileTime)

                    'listar datos del penal
                    objEntCol2 = New Entity.Reporte.Estadistica.Formato1Col
                    objEntCol2 = objBss.FormatoF1_2(Me._PadinID, Me._PenalID, Me._FechaInicio, Me._FechaFin)

            End Select

            Return True

        End Function

        Private Sub ReporteFormatoF1(Optional ByVal Impresion As Boolean = False,
        Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Cuadro Estadistico"

            Dim parameters As ReportParameter() = New ReportParameter(11) {}
            parameters(0) = New ReportParameter("dependencia", Me.ReporteModulo)
            parameters(1) = New ReportParameter("modulo", Me.ReporteModulo)
            parameters(2) = New ReportParameter("version", Me.ReporteModuloVersion)
            parameters(3) = New ReportParameter("mac", Legolas.Components.PC.GetMAC)
            parameters(4) = New ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(5) = New ReportParameter("fecha", Me.FechayHora)
            parameters(6) = New ReportParameter("acta", Me.ReporteActa)
            parameters(7) = New ReportParameter("p_correlativo", Me._Correlativo)
            parameters(8) = New ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
            parameters(9) = New ReportParameter("p_estado", Me._EstadoPadin)
            parameters(10) = New ReportParameter("p_filtro", Me.Filtro)
            parameters(11) = New ReportParameter("impresion", "")

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptReporte01"
                .LocalReport.ReportPath = Me.ReportePath & "rptFormato1.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_Formato1Col", objEntCol))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro001Col", objEntCol.Formato1(0).Cuadro001))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro002ACol", objEntCol.Formato1(0).Cuadro002A))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro002BCol", objEntCol.Formato1(0).Cuadro002B))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro003Col", objEntCol.Formato1(0).Cuadro003))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro004Col", objEntCol.Formato1(0).Cuadro004))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro005Col", objEntCol.Formato1(0).Cuadro005))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro006Col", objEntCol.Formato1(0).Cuadro006))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro007Col", objEntCol.Formato1(0).Cuadro007))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro008Col", objEntCol.Formato1(0).Cuadro008))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro009Col", objEntCol.Formato1(0).Cuadro009))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro010Col", objEntCol.Formato1(0).Cuadro010))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro011Col", objEntCol.Formato1(0).Cuadro011))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro012Col", objEntCol.Formato1(0).Cuadro012))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_F1_Cuadro013Col", objEntCol.Formato1(0).Cuadro013))

                .LocalReport.SetParameters(parameters)

                ''/*datos de penales*/
                'Dim bindingsource1 As New BindingSource
                'Dim ReportDataSource1 As New Microsoft.Reporting.WinForms.ReportDataSource

                'bindingsource1.DataSource = objEntCol
                'ReportDataSource1.Name = "Entity_Reporte_Estadistica_Formato1Col"
                'ReportDataSource1.Value = bindingsource1

                ''/*cuadro 001*/                
                'Dim objBSource02 As New BindingSource
                'Dim objRDS02 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource02.DataSource = objEntCol.Formato1(0).Cuadro001
                'objRDS02.Name = "Entity_Reporte_Estadistica_F1_Cuadro001Col"
                'objRDS02.Value = objBSource02

                ''/*cuadro 002-A*/
                'Dim objBSource05 As New BindingSource
                'Dim objRDS05 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource05.DataSource = objEntCol.Formato1(0).Cuadro002A
                'objRDS05.Name = "Entity_Reporte_Estadistica_F1_Cuadro002ACol"
                'objRDS05.Value = objBSource05

                ''/*cuadro 002-B*/
                'Dim objBSource06 As New BindingSource
                'Dim objRDS06 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource06.DataSource = objEntCol.Formato1(0).Cuadro002B
                'objRDS06.Name = "Entity_Reporte_Estadistica_F1_Cuadro002BCol"
                'objRDS06.Value = objBSource06

                ''/*cuadro 003*/
                'Dim objBSource03 As New BindingSource
                'Dim objRDS03 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource03.DataSource = objEntCol.Formato1(0).Cuadro003
                'objRDS03.Name = "Entity_Reporte_Estadistica_F1_Cuadro003Col"
                'objRDS03.Value = objBSource03

                ''/*cuadro 004*/
                'Dim objBSource04 As New BindingSource
                'Dim objRDS04 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource04.DataSource = objEntCol.Formato1(0).Cuadro004
                'objRDS04.Name = "Entity_Reporte_Estadistica_F1_Cuadro004Col"
                'objRDS04.Value = objBSource04

                ''/*cuadro 005*/
                'Dim objBSource15 As New BindingSource
                'Dim objRDS15 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource15.DataSource = objEntCol.Formato1(0).Cuadro005
                'objRDS15.Name = "Entity_Reporte_Estadistica_F1_Cuadro005Col"
                'objRDS15.Value = objBSource15

                ''/*cuadro 006, estado civil*/
                'Dim objBSource07 As New BindingSource
                'Dim objRDS07 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource07.DataSource = objEntCol.Formato1(0).Cuadro006
                'objRDS07.Name = "Entity_Reporte_Estadistica_F1_Cuadro006Col"
                'objRDS07.Value = objBSource07

                ''/*cuadro 007, tiempo de reclusion*/
                'Dim objBSource08 As New BindingSource
                'Dim objRDS08 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource08.DataSource = objEntCol.Formato1(0).Cuadro007
                'objRDS08.Name = "Entity_Reporte_Estadistica_F1_Cuadro007Col"
                'objRDS08.Value = objBSource08

                ''/*cuadro 008, tiempo de sentencia*/
                'Dim objBSource09 As New BindingSource
                'Dim objRDS09 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource09.DataSource = objEntCol.Formato1(0).Cuadro008
                'objRDS09.Name = "Entity_Reporte_Estadistica_F1_Cuadro008Col"
                'objRDS09.Value = objBSource09

                ''/*cuadro 009, comunidades campesinas*/
                'Dim objBSource10 As New BindingSource
                'Dim objRDS10 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource10.DataSource = objEntCol.Formato1(0).Cuadro009
                'objRDS10.Name = "Entity_Reporte_Estadistica_F1_Cuadro009Col"
                'objRDS10.Value = objBSource10

                ''/*cuadro 010, discapacidad*/
                'Dim objBSource11 As New BindingSource
                'Dim objRDS11 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource11.DataSource = objEntCol.Formato1(0).Cuadro010
                'objRDS11.Name = "Entity_Reporte_Estadistica_F1_Cuadro010Col"
                'objRDS11.Value = objBSource11

                ''/*cuadro 011, cantidad de internos por numeros de ingresos*/
                'Dim objBSource12 As New BindingSource
                'Dim objRDS12 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource12.DataSource = objEntCol.Formato1(0).Cuadro011
                'objRDS12.Name = "Entity_Reporte_Estadistica_F1_Cuadro011Col"
                'objRDS12.Value = objBSource12

                ''/*cuadro 012, ingresos por tipo de delitos genericos*/
                'Dim objBSource13 As New BindingSource
                'Dim objRDS13 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource13.DataSource = objEntCol.Formato1(0).Cuadro012
                'objRDS13.Name = "Entity_Reporte_Estadistica_F1_Cuadro012Col"
                'objRDS13.Value = objBSource13

                ''/*cuadro 013, egresos por tipo de libertad y otros*/
                'Dim objBSource14 As New BindingSource
                'Dim objRDS14 As New Microsoft.Reporting.WinForms.ReportDataSource

                'objBSource14.DataSource = objEntCol.Formato1(0).Cuadro013
                'objRDS14.Name = "Entity_Reporte_Estadistica_F1_Cuadro013Col"
                'objRDS14.Value = objBSource14

                ''/*dependencia*/
                'par1 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par1(0) = New Microsoft.Reporting.WinForms.ReportParameter("dependencia", Me.ReporteModulo)
                '.LocalReport.SetParameters(par1)
                ''/*modulo*/
                'par2 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par2(0) = New Microsoft.Reporting.WinForms.ReportParameter("modulo", Me.ReporteModulo)
                '.LocalReport.SetParameters(par2)
                ''/*version*/
                'par3 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par3(0) = New Microsoft.Reporting.WinForms.ReportParameter("version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(par3)
                ''/*mac*/
                'par4 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par4(0) = New Microsoft.Reporting.WinForms.ReportParameter("mac", Legolas.Components.PC.GetMAC)

                '.LocalReport.SetParameters(par4)
                ''/*usuario*/
                'par5 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par5(0) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)

                '.LocalReport.SetParameters(par5)
                ''/*fecha y hora reporte*/                   
                'par6 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par6(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.FechayHora)
                '.LocalReport.SetParameters(par6)
                ''/*acta*/
                'par7 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par7(0) = New Microsoft.Reporting.WinForms.ReportParameter("acta", Me.ReporteActa)
                '.LocalReport.SetParameters(par7)

                ''/*correlativo*/
                'par10 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par10(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_correlativo", Me._Correlativo)
                '.LocalReport.SetParameters(par10)
                ''/*fecha de corte*/
                'par11 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par11(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
                '.LocalReport.SetParameters(par11)

                ''/*estado del padin*/
                'par12 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par12(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_estado", Me._EstadoPadin)
                '.LocalReport.SetParameters(par12)

                ''/*parametros otros*/
                'Dim par_Filtro() As Microsoft.Reporting.WinForms.ReportParameter
                'par_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me.Filtro)
                '.LocalReport.SetParameters(par_Filtro)

                If Impresion = False Then
                    .RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.DataSources.Add(ReportDataSource1)
                    '.LocalReport.DataSources.Add(objRDS02)
                    '.LocalReport.DataSources.Add(objRDS03)
                    '.LocalReport.DataSources.Add(objRDS04)
                    '.LocalReport.DataSources.Add(objRDS05)
                    '.LocalReport.DataSources.Add(objRDS06)
                    '.LocalReport.DataSources.Add(objRDS07)
                    '.LocalReport.DataSources.Add(objRDS08)
                    '.LocalReport.DataSources.Add(objRDS09)
                    '.LocalReport.DataSources.Add(objRDS10)
                    '.LocalReport.DataSources.Add(objRDS11)
                    '.LocalReport.DataSources.Add(objRDS12)
                    '.LocalReport.DataSources.Add(objRDS13)
                    '.LocalReport.DataSources.Add(objRDS14)
                    '.LocalReport.DataSources.Add(objRDS15)
                    '.RefreshReport()
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

                    .RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(par8)

                    '.LocalReport.DataSources.Add(ReportDataSource1)
                    '.LocalReport.DataSources.Add(objRDS02)
                    '.LocalReport.DataSources.Add(objRDS03)
                    '.LocalReport.DataSources.Add(objRDS04)
                    '.LocalReport.DataSources.Add(objRDS05)
                    '.LocalReport.DataSources.Add(objRDS06)
                    '.LocalReport.DataSources.Add(objRDS07)
                    '.LocalReport.DataSources.Add(objRDS08)
                    '.LocalReport.DataSources.Add(objRDS09)
                    '.LocalReport.DataSources.Add(objRDS10)
                    '.LocalReport.DataSources.Add(objRDS11)
                    '.LocalReport.DataSources.Add(objRDS12)
                    '.LocalReport.DataSources.Add(objRDS13)
                    '.LocalReport.DataSources.Add(objRDS14)
                    '.LocalReport.DataSources.Add(objRDS15)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With
        End Sub

        Private Sub ReporteFormatoF1_V3(Optional ByVal Impresion As Boolean = False,
        Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Cuadro Estadistico"

            With ReportViewer1
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptReporte01"
                .LocalReport.ReportPath = Me.ReportePath & "rptFormato1_v3.rdlc"

                '/*datos de penales*/
                Dim bindingsource1 As New BindingSource
                Dim ReportDataSource1 As New Microsoft.Reporting.WinForms.ReportDataSource

                bindingsource1.DataSource = objEntCol
                ReportDataSource1.Name = "Entity_Reporte_Estadistica_Formato1Col"
                ReportDataSource1.Value = bindingsource1

                '/*cuadro 001*/                
                Dim objBSource02 As New BindingSource
                Dim objRDS02 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource02.DataSource = objEntCol.Formato1(0).Cuadro001
                objRDS02.Name = "Entity_Reporte_Estadistica_F1_Cuadro001Col"
                objRDS02.Value = objBSource02

                '/*cuadro 002-A*/
                Dim objBSource05 As New BindingSource
                Dim objRDS05 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource05.DataSource = objEntCol.Formato1(0).Cuadro002A
                objRDS05.Name = "Entity_Reporte_Estadistica_F1_Cuadro002ACol"
                objRDS05.Value = objBSource05

                '/*cuadro 002-B*/
                Dim objBSource06 As New BindingSource
                Dim objRDS06 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource06.DataSource = objEntCol.Formato1(0).Cuadro002B
                objRDS06.Name = "Entity_Reporte_Estadistica_F1_Cuadro002BCol"
                objRDS06.Value = objBSource06

                '/*cuadro 003*/
                Dim objBSource03 As New BindingSource
                Dim objRDS03 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource03.DataSource = objEntCol.Formato1(0).Cuadro003
                objRDS03.Name = "Entity_Reporte_Estadistica_F1_Cuadro003Col"
                objRDS03.Value = objBSource03

                '/*cuadro 004*/
                Dim objBSource04 As New BindingSource
                Dim objRDS04 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource04.DataSource = objEntCol.Formato1(0).Cuadro004
                objRDS04.Name = "Entity_Reporte_Estadistica_F1_Cuadro004Col"
                objRDS04.Value = objBSource04

                '/*cuadro 005*/
                Dim objBSource15 As New BindingSource
                Dim objRDS15 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource15.DataSource = objEntCol.Formato1(0).Cuadro005
                objRDS15.Name = "Entity_Reporte_Estadistica_F1_Cuadro005Col"
                objRDS15.Value = objBSource15

                '/*cuadro 006, estado civil*/
                Dim objBSource07 As New BindingSource
                Dim objRDS07 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource07.DataSource = objEntCol.Formato1(0).Cuadro006
                objRDS07.Name = "Entity_Reporte_Estadistica_F1_Cuadro006Col"
                objRDS07.Value = objBSource07

                '/*cuadro 007, tiempo de reclusion*/
                Dim objBSource08 As New BindingSource
                Dim objRDS08 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource08.DataSource = objEntCol.Formato1(0).Cuadro007
                objRDS08.Name = "Entity_Reporte_Estadistica_F1_Cuadro007Col"
                objRDS08.Value = objBSource08

                '/*cuadro 008, tiempo de sentencia*/
                Dim objBSource09 As New BindingSource
                Dim objRDS09 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource09.DataSource = objEntCol.Formato1(0).Cuadro008
                objRDS09.Name = "Entity_Reporte_Estadistica_F1_Cuadro008Col"
                objRDS09.Value = objBSource09

                '/*cuadro 009, comunidades campesinas*/
                Dim objBSource10 As New BindingSource
                Dim objRDS10 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource10.DataSource = objEntCol.Formato1(0).Cuadro009
                objRDS10.Name = "Entity_Reporte_Estadistica_F1_Cuadro009Col"
                objRDS10.Value = objBSource10

                '/*cuadro 010, discapacidad*/
                Dim objBSource11 As New BindingSource
                Dim objRDS11 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource11.DataSource = objEntCol.Formato1(0).Cuadro010
                objRDS11.Name = "Entity_Reporte_Estadistica_F1_Cuadro010Col"
                objRDS11.Value = objBSource11

                '/*cuadro 011, cantidad de internos por numeros de ingresos*/
                Dim objBSource12 As New BindingSource
                Dim objRDS12 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource12.DataSource = objEntCol.Formato1(0).Cuadro011
                objRDS12.Name = "Entity_Reporte_Estadistica_F1_Cuadro011Col"
                objRDS12.Value = objBSource12

                '/*cuadro 012, ingresos por tipo de delitos genericos*/
                Dim objBSource13 As New BindingSource
                Dim objRDS13 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource13.DataSource = objEntCol.Formato1(0).Cuadro012
                objRDS13.Name = "Entity_Reporte_Estadistica_F1_Cuadro012Col"
                objRDS13.Value = objBSource13

                '/*cuadro 013, egresos por tipo de libertad y otros*/
                Dim objBSource14 As New BindingSource
                Dim objRDS14 As New Microsoft.Reporting.WinForms.ReportDataSource

                objBSource14.DataSource = objEntCol.Formato1(0).Cuadro013
                objRDS14.Name = "Entity_Reporte_Estadistica_F1_Cuadro013Col"
                objRDS14.Value = objBSource14

                ''/*dependencia*/
                'par1 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par1(0) = New Microsoft.Reporting.WinForms.ReportParameter("dependencia", Me.ReporteModulo)
                '.LocalReport.SetParameters(par1)
                ''/*modulo*/
                'par2 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par2(0) = New Microsoft.Reporting.WinForms.ReportParameter("modulo", Me.ReporteModulo)
                '.LocalReport.SetParameters(par2)
                ''/*version*/
                'par3 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par3(0) = New Microsoft.Reporting.WinForms.ReportParameter("version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(par3)
                ''/*mac*/
                'par4 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par4(0) = New Microsoft.Reporting.WinForms.ReportParameter("mac", Legolas.Components.PC.GetMAC)

                '.LocalReport.SetParameters(par4)
                ''/*usuario*/
                'par5 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par5(0) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)

                '.LocalReport.SetParameters(par5)
                ''/*fecha y hora reporte*/                   
                'par6 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par6(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.FechayHora)
                '.LocalReport.SetParameters(par6)
                ''/*acta*/
                'par7 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par7(0) = New Microsoft.Reporting.WinForms.ReportParameter("acta", Me.ReporteActa)
                '.LocalReport.SetParameters(par7)

                ''/*correlativo*/
                'par10 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par10(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_correlativo", Me._Correlativo)
                '.LocalReport.SetParameters(par10)
                ''/*fecha de corte*/
                'par11 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par11(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
                '.LocalReport.SetParameters(par11)

                ''/*estado del padin*/
                'par12 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par12(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_estado", Me._EstadoPadin)
                '.LocalReport.SetParameters(par12)

                ''/*parametros otros*/
                'Dim par_Filtro() As Microsoft.Reporting.WinForms.ReportParameter
                'par_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me.Filtro)
                '.LocalReport.SetParameters(par_Filtro)

                If Impresion = False Then
                    .RefreshReport()
                    '/*reporte*/
                    .LocalReport.DataSources.Clear()
                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.DataSources.Add(objRDS02)
                    .LocalReport.DataSources.Add(objRDS03)
                    .LocalReport.DataSources.Add(objRDS04)
                    .LocalReport.DataSources.Add(objRDS05)
                    .LocalReport.DataSources.Add(objRDS06)
                    .LocalReport.DataSources.Add(objRDS07)
                    .LocalReport.DataSources.Add(objRDS08)
                    .LocalReport.DataSources.Add(objRDS09)
                    .LocalReport.DataSources.Add(objRDS10)
                    .LocalReport.DataSources.Add(objRDS11)
                    .LocalReport.DataSources.Add(objRDS12)
                    .LocalReport.DataSources.Add(objRDS13)
                    .LocalReport.DataSources.Add(objRDS14)
                    .LocalReport.DataSources.Add(objRDS15)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    objBssRpt = New Legolas.LBusiness.Globall.Reporte

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

                    .RefreshReport()
                    '/*reporte*/
                    .LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(par8)

                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.DataSources.Add(objRDS02)
                    .LocalReport.DataSources.Add(objRDS03)
                    .LocalReport.DataSources.Add(objRDS04)
                    .LocalReport.DataSources.Add(objRDS05)
                    .LocalReport.DataSources.Add(objRDS06)
                    .LocalReport.DataSources.Add(objRDS07)
                    .LocalReport.DataSources.Add(objRDS08)
                    .LocalReport.DataSources.Add(objRDS09)
                    .LocalReport.DataSources.Add(objRDS10)
                    .LocalReport.DataSources.Add(objRDS11)
                    .LocalReport.DataSources.Add(objRDS12)
                    .LocalReport.DataSources.Add(objRDS13)
                    .LocalReport.DataSources.Add(objRDS14)
                    .LocalReport.DataSources.Add(objRDS15)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With
        End Sub

        Private Sub Reporte002(Optional ByVal Impresion As Boolean = False,
           Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Cuadro Estadistico"

            Dim parameters As ReportParameter() = New ReportParameter(11) {}
            parameters(0) = New ReportParameter("nacionalidad", NacionalidadTitulo)
            parameters(1) = New ReportParameter("dependencia", ReporteDependencia)
            parameters(2) = New ReportParameter("modulo", ReporteModulo)
            parameters(3) = New ReportParameter("version", ReporteModuloVersion)
            parameters(4) = New ReportParameter("mac", Legolas.Components.PC.GetMAC)
            parameters(5) = New ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(6) = New ReportParameter("fecha", Me.FechayHora)
            parameters(7) = New ReportParameter("acta", Me.ReporteActa)
            parameters(8) = New ReportParameter("p_correlativo", _Correlativo)
            parameters(9) = New ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
            parameters(10) = New ReportParameter("p_estado", _EstadoPadin)
            parameters(11) = New ReportParameter("p_filtro", Me.Filtro)

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptCuadro14"
                .LocalReport.ReportPath = Me.ReportePath & "rptCuadro14.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Reporte02Col", objEntCol))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_Formato1Col", objEntCol2))

                .LocalReport.SetParameters(parameters)

                ''/*datos de penales*/
                'Dim bindingsource1 As New BindingSource
                'Dim ReportDataSource1 As New Microsoft.Reporting.WinForms.ReportDataSource

                'bindingsource1.DataSource = objEntCol
                'ReportDataSource1.Name = "Entity_Reporte_Reporte02Col"
                'ReportDataSource1.Value = bindingsource1

                ''/*datos ubicacion*/
                'Dim bindingsource2 As New BindingSource
                'Dim ReportDataSource2 As New Microsoft.Reporting.WinForms.ReportDataSource

                'bindingsource2.DataSource = objEntCol2
                'ReportDataSource2.Name = "Entity_Reporte_Estadistica_Formato1Col"
                'ReportDataSource2.Value = bindingsource2

                ''/*nacionalidad*/
                'Dim p9() As Microsoft.Reporting.WinForms.ReportParameter
                'p9 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'p9(0) = New Microsoft.Reporting.WinForms.ReportParameter("nacionalidad", Me.NacionalidadTitulo)
                '.LocalReport.SetParameters(p9)

                ''/*dependencia*/
                'par1 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par1(0) = New Microsoft.Reporting.WinForms.ReportParameter("dependencia", Me.ReporteDependencia)
                '.LocalReport.SetParameters(par1)
                ''/*modulo*/
                'par2 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par2(0) = New Microsoft.Reporting.WinForms.ReportParameter("modulo", Me.ReporteModulo)
                '.LocalReport.SetParameters(par2)
                ''/*version*/
                'par3 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par3(0) = New Microsoft.Reporting.WinForms.ReportParameter("version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(par3)
                ''/*mac*/
                'par4 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par4(0) = New Microsoft.Reporting.WinForms.ReportParameter("mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(par4)
                ''/*usuario*/
                'par5 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par5(0) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(par5)
                ''/*fecha y hora reporte*/                   
                'par6 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par6(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.FechayHora)
                '.LocalReport.SetParameters(par6)
                ''/*acta*/
                'par7 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par7(0) = New Microsoft.Reporting.WinForms.ReportParameter("acta", Me.ReporteActa)
                '.LocalReport.SetParameters(par7)
                ''/*correlativo*/
                'par10 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par10(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_correlativo", Me._Correlativo)
                '.LocalReport.SetParameters(par10)
                ''/*fecha de corte*/
                'par11 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par11(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
                '.LocalReport.SetParameters(par11)

                ''/*estado del padin*/
                'par12 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par12(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_estado", Me._EstadoPadin)
                '.LocalReport.SetParameters(par12)

                ''/*parametros otros*/
                'Dim par_Filtro() As Microsoft.Reporting.WinForms.ReportParameter
                'par_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me.Filtro)
                '.LocalReport.SetParameters(par_Filtro)

                If Impresion = False Then
                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(par1)
                    '.LocalReport.SetParameters(par2)
                    '.LocalReport.SetParameters(par3)
                    '.LocalReport.SetParameters(par4)
                    '.LocalReport.SetParameters(par5)
                    '.LocalReport.SetParameters(par6)
                    '.LocalReport.SetParameters(par7)
                    '.LocalReport.SetParameters(p8)
                    '.LocalReport.SetParameters(p9)
                    '.LocalReport.DataSources.Add(ReportDataSource1)
                    '.LocalReport.DataSources.Add(ReportDataSource2)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    'Dim strFechaString As String = ""
                    'Dim strMensaje As String = ""

                    'If ExportarPDF = True Then
                    '    strCorrelativo = obj1.ObtenerCodigoExportacion(Me.CodigoReporte).ToString("000000")
                    '    strMensaje = "N° Exportación : "
                    'Else
                    '    strCorrelativo = obj1.ObtenerCodigo(Me.CodigoReporte).ToString("000000")
                    '    strMensaje = "N° Impresión : "
                    'End If

                    'strMensaje = strMensaje & strCorrelativo

                    'dteHora = Business.Globall.DateTime.HoraServer
                    'strFechaString = strFecha & " " & dteHora.ToShortTimeString

                    ''/*parametros*/
                    'Dim par1() As Microsoft.Reporting.WinForms.ReportParameter
                    'par1 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    'par1(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", strFechaString)
                    '.LocalReport.SetParameters(par1)

                    'Dim par2() As Microsoft.Reporting.WinForms.ReportParameter
                    'par2 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    'par2(0) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", Configuracion.Usuario.Nombre)
                    '.LocalReport.SetParameters(par2)

                    'Dim par3() As Microsoft.Reporting.WinForms.ReportParameter
                    'par3 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    'par3(0) = New Microsoft.Reporting.WinForms.ReportParameter("oficina", Oficina)
                    '.LocalReport.SetParameters(par3)

                    'Dim par4() As Microsoft.Reporting.WinForms.ReportParameter
                    'par4 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                    'par4(0) = New Microsoft.Reporting.WinForms.ReportParameter("impresion", strMensaje)
                    '.LocalReport.SetParameters(par4)

                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(ReportDataSource1)
                    '.LocalReport.DataSources.Add(ReportDataSource2)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With
        End Sub
        Private Sub Reporte003(Optional ByVal Impresion As Boolean = False,
            Optional ByVal ExportarPDF As Boolean = False)

            Me.Text = "Reporte - Cuadro Estadistico"

            Dim parameters As ReportParameter() = New ReportParameter(10) {}
            parameters(0) = New ReportParameter("dependencia", ReporteDependencia)
            parameters(1) = New ReportParameter("modulo", ReporteModulo)
            parameters(2) = New ReportParameter("version", ReporteModuloVersion)
            parameters(3) = New ReportParameter("mac", Legolas.Components.PC.GetMAC)
            parameters(4) = New ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            parameters(5) = New ReportParameter("fecha", Me.FechayHora)
            parameters(6) = New ReportParameter("acta", Me.ReporteActa)
            parameters(7) = New ReportParameter("p_correlativo", _Correlativo)
            parameters(8) = New ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
            parameters(9) = New ReportParameter("p_estado", _EstadoPadin)
            parameters(10) = New ReportParameter("p_filtro", Me.Filtro)

            With ReportViewer1
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "rptCuadro15"
                .LocalReport.ReportPath = Me.ReportePath & "rptCuadro15.rdlc"

                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Reporte03Col", objEntCol))
                .LocalReport.DataSources.Add(New ReportDataSource("Entity_Reporte_Estadistica_Formato1Col", objEntCol2))

                .LocalReport.SetParameters(parameters)

                ''/*datos de penales*/
                'Dim bindingsource1 As New BindingSource
                'Dim ReportDataSource1 As New Microsoft.Reporting.WinForms.ReportDataSource

                'bindingsource1.DataSource = objEntCol
                'ReportDataSource1.Name = "Entity_Reporte_Reporte03Col"
                'ReportDataSource1.Value = bindingsource1

                ''/*datos ubicacion*/
                'Dim bindingsource2 As New BindingSource
                'Dim ReportDataSource2 As New Microsoft.Reporting.WinForms.ReportDataSource

                'bindingsource2.DataSource = objEntCol2
                'ReportDataSource2.Name = "Entity_Reporte_Estadistica_Formato1Col"
                'ReportDataSource2.Value = bindingsource2

                ''/*dependencia*/
                'par1 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par1(0) = New Microsoft.Reporting.WinForms.ReportParameter("dependencia", Me.ReporteDependencia)
                '.LocalReport.SetParameters(par1)
                ''/*modulo*/
                'par2 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par2(0) = New Microsoft.Reporting.WinForms.ReportParameter("modulo", Me.ReporteModulo)
                '.LocalReport.SetParameters(par2)
                ''/*version*/
                'par3 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par3(0) = New Microsoft.Reporting.WinForms.ReportParameter("version", Me.ReporteModuloVersion)
                '.LocalReport.SetParameters(par3)
                ''/*mac*/
                'par4 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par4(0) = New Microsoft.Reporting.WinForms.ReportParameter("mac", Legolas.Components.PC.GetMAC)
                '.LocalReport.SetParameters(par4)
                ''/*usuario*/
                'par5 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par5(0) = New Microsoft.Reporting.WinForms.ReportParameter("usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
                '.LocalReport.SetParameters(par5)
                ''/*fecha y hora reporte*/                   
                'par6 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par6(0) = New Microsoft.Reporting.WinForms.ReportParameter("fecha", Me.FechayHora)
                '.LocalReport.SetParameters(par6)
                ''/*acta*/
                'par7 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par7(0) = New Microsoft.Reporting.WinForms.ReportParameter("acta", Me.ReporteActa)
                '.LocalReport.SetParameters(par7)
                ''/*correlativo*/
                'par10 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par10(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_correlativo", Me._Correlativo)
                '.LocalReport.SetParameters(par10)
                ''/*fecha de corte*/
                'par11 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par11(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_fechacorte", Legolas.Components.FechaHora.FechaString(Me._FechaFin))
                '.LocalReport.SetParameters(par11)

                ''/*estado del padin*/
                'par12 = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par12(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_estado", Me._EstadoPadin)
                '.LocalReport.SetParameters(par12)
                ''/*parametros otros*/
                'Dim par_Filtro() As Microsoft.Reporting.WinForms.ReportParameter
                'par_Filtro = New Microsoft.Reporting.WinForms.ReportParameter(0) {}
                'par_Filtro(0) = New Microsoft.Reporting.WinForms.ReportParameter("p_filtro", Me.Filtro)
                '.LocalReport.SetParameters(par_Filtro)

                If Impresion = False Then
                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.DataSources.Add(ReportDataSource1)
                    '.LocalReport.DataSources.Add(ReportDataSource2)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                Else
                    '.RefreshReport()
                    '/*reporte*/
                    '.LocalReport.DataSources.Clear()
                    '.LocalReport.SetParameters(p)
                    '.LocalReport.DataSources.Add(ReportDataSource1)
                    '.LocalReport.DataSources.Add(ReportDataSource2)
                    .RefreshReport()
                    .DocumentMapCollapsed = True
                End If

            End With
        End Sub

        Private Sub VerReporte(Optional ByVal Impresion As Boolean = False,
        Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)


            Me.SuspendLayout()
            Me.Timer1.Start()
            frmLoad = New Load.frmLoad
            frmLoad.ShowDialog()
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            Select Case Me._pReporteTipo
                Case EnmTipoReporte.rptReporte1
                    If blnRep = True Then
                        If Me._VersionReporte = 3 Then
                            'ReporteFormatoF1_V3(Impresion, ExportarPDF)
                        Else
                            ReporteFormatoF1(Impresion, ExportarPDF)
                        End If
                    End If
                Case EnmTipoReporte.rptReporte2
                    If blnRep = True Then
                        Reporte002(Impresion, ExportarPDF)
                    End If
                Case EnmTipoReporte.rptReporte3
                    If blnRep = True Then
                        Reporte003(Impresion, ExportarPDF)
                    End If

            End Select

        End Sub
#End Region
#Region "Impresion"
        Private Sub Exportar(ByVal PathFile As String)

            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim bytPDF As Byte()

            bytPDF = Me.ReportViewer1.LocalReport.Render("PDF",
            Nothing, mimeType, encoding, extension, streamids, warnings)

            Legolas.Components.Archivo.FileCreateByte(bytPDF, PathFile)

        End Sub
        Private Sub ExportarExcel(ByVal PathFile As String)

            Dim warnings As Warning() = Nothing
            Dim streamids As String() = Nothing
            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim extension As String = Nothing
            Dim bytPDF As Byte()

            bytPDF = Me.ReportViewer1.LocalReport.Render("EXCEL",
            Nothing, mimeType, encoding, extension, streamids, warnings)

            Legolas.Components.Archivo.FileCreateByte(bytPDF, PathFile)

        End Sub
        Private Function SetDefPrinter(ByVal sNombreImpresora As String) As Boolean
            'Parámetro especifica nombre de impresora para poner por defecto.
            'La pongo por defecto y la quito.

            Dim WshNetwork As Object
            Dim pd As New Printing.PrintDocument

            WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

            Try
                WshNetwork.SetDefaultPrinter(sNombreImpresora)
                pd.PrinterSettings.PrinterName = sNombreImpresora
                If pd.PrinterSettings.IsValid Then
                    Return True
                Else
                    WshNetwork.SetDefaultPrinter(sNombreImpresora)
                    Return False
                End If
            Catch exptd As Exception
                'WshNetwork.SetDefaultPrinter(sNombreImpresora)
                Return False
            Finally
                WshNetwork = Nothing
                pd = Nothing
            End Try

        End Function
        Private Sub GenerarCabecera(Optional ByVal ExportarPDF As Boolean = False, Optional ByVal Ruta As String = "")

            Dim strRuta As String = ""
            VerReporte(True, ExportarPDF)

            If ExportarPDF = True Then
                strRuta = Ruta
            Else
                strRuta = Legolas.Configuration.Path.PathTemp & Me.ReporteNombreFisico & ".pdf"
            End If

            Exportar(strRuta)

        End Sub
        Private Sub Impresion(ByVal ShowPrinter As Boolean)

            Dim blnOK As Boolean = False
            Dim objPrint As New System.Windows.Forms.PrintDialog

            If ShowPrinter = True Then
                With Me.PrintDialog1
                    .AllowSomePages = True
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        blnOK = True
                    End If
                End With

                If blnOK = True Then
                    objPrint = Me.PrintDialog1
                    SetDefPrinter(objPrint.PrinterSettings.PrinterName)

                    For i As Integer = 1 To objPrint.PrinterSettings.Copies
                        Impresion(objPrint.PrinterSettings.PrinterName)
                    Next
                End If

            Else
                blnOK = True
                Impresion(objPrint.PrinterSettings.PrinterName)
            End If

        End Sub
        Private Sub Impresion(ByVal PrinterName As String)

            Dim strRuta As String = ""
            GenerarCabecera()

            strRuta = Legolas.Configuration.Path.PathTemp & Me.ReporteNombreFisico & ".pdf"

            Dim startInfo As New ProcessStartInfo()
            startInfo.FileName = strRuta
            startInfo.Arguments = PrinterName
            startInfo.Verb = "print"
            'startInfo.Verb = "PrintTo"
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            startInfo.CreateNoWindow = True
            startInfo.UseShellExecute = True
            startInfo.ErrorDialog = True
            System.Diagnostics.Process.Start(startInfo)

        End Sub
#End Region
#Region "Otros"
        Private Sub ValoresxDefault()

            ListarPropiedadesReporte()
            Me.ReporteModuloVersion = Legolas.Configuration.Aplication.VersionString

        End Sub
#End Region

        Private Sub frmReporte_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()
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

        Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click

            'Select Case Me._pReporteTipo
            '    Case EnmTipoReporte.rptReporte1
            Me.ReportViewer1.PrintDialog()
            '    Case Else
            '        Impresion(False)
            'End Select

        End Sub

    End Class
End Namespace

