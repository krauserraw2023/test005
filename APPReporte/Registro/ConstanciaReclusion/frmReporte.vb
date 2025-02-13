Imports System.Linq
Imports Microsoft.Reporting.WinForms
Namespace Registro.ConstanciaReclusion
    Public Class frmReporte
        Private frmLoad As Load.frmLoad = Nothing
        Private idTipoReporte As Type.Enumeracion.ConstanciaReclusion.enmReporte = Type.Enumeracion.ConstanciaReclusion.enmReporte.ninguno
        Private filtro As Entity.Registro.ConstanciaReclusion.ReporteFiltro = Nothing

        Public Sub New(tipoReporte As Type.Enumeracion.ConstanciaReclusion.enmReporte, filtro As Entity.Registro.ConstanciaReclusion.ReporteFiltro)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.idTipoReporte = tipoReporte
            Me.filtro = filtro

            'habilitarControles
        End Sub

#Region "Propiedades_Reporte"
        Private ReadOnly Property ReportePath() As String
            Get
                ''produccion
                Dim valor As String = Legolas.Configuration.Path.PathReporte
                valor = valor.Replace("\\", "\")
                'Legolas.Configuration.Path.PathReporte
                Return valor & "Registro\"

                ''pc casa
                'Return "D:\Jmondalgo\INPE\DEV_INPE\Codigo_Fuente\Azure_2022\repo_azure_sol_sip_desktop\sol_sip_desktop_2022\APPReporte\Registro\ConstanciaReclusion\"

                'pc inpe
                'return "D:\Desarrollo\DEV\Azure\sol_sip_desktop\APPReporte\Registro\ConstanciaReclusion\"
            End Get
        End Property
#End Region
#Region "Functions"
        Private Function fnNombreReporte() As String

            Dim value As String = ""
            Select Case Me.idTipoReporte
                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.expedicionConstancias
                    value = "Reporte de expedición de constancias de reclusión"

                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.expedicionConstanciaGrupo
                    value = "Reporte de expedición de constancias de reclusión Agrupado por Region y Penal"

            End Select

            Return value
        End Function
#End Region
#Region "Reporte"

        Private Sub rptExpedicionConstancia()

            'se generas las clases como listas
            Dim bssReporte As New Bussines.Registro.ConstanciaReclusion.Reporte
            Dim listadetalle As New List(Of Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion)()

            listadetalle = bssReporte.listarReporteExpedicion(Me.filtro)

            'obtener las cantidades
            Dim total As Integer = listadetalle.Count
            Dim cantSinCosto As Integer = 0
            Dim cantConCosto As Integer = 0

            'consulta linq
            Dim query = From tabla As Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion In listadetalle
                        Where tabla.tipoTramite = 1
                        Select tabla

            cantConCosto = query.Count
            cantSinCosto = total - cantConCosto

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(12) {}
            parameters(0) = New ReportParameter("p_filtro_region_nom", filtro.regionNombre.ToUpper)
            parameters(1) = New ReportParameter("p_filtro_penal_nom", filtro.penalNombre.ToUpper)
            parameters(2) = New ReportParameter("p_filtro_fec_ini", filtro.fechaInicio.ToShortDateString)
            parameters(3) = New ReportParameter("p_filtro_fec_fin", filtro.fechaFin.ToShortDateString)
            parameters(4) = New ReportParameter("p_filtro_tipo_tramite", filtro.tipoTramiteNombre)
            parameters(5) = New ReportParameter("p_resumen_costo", cantConCosto)
            parameters(6) = New ReportParameter("p_resumen_sincosto", cantSinCosto)
            parameters(7) = New ReportParameter("p_resumen_total", total)
            'parametros del pie de pagina
            parameters(8) = New ReportParameter("p_rpt_num_imp", "")
            parameters(9) = New ReportParameter("p_rpt_pc_mac", Legolas.Components.PC.GetMAC)
            parameters(10) = New ReportParameter("p_rpt_acta", "")
            parameters(11) = New ReportParameter("p_rpt_usuario", Legolas.Configuration.Usuario.ApellidosyNombre.ToUpper)
            parameters(12) = New ReportParameter("p_rpt_fec_imp", Now.ToString)

            With Me.ReportViewer1

                'Limpiemos el DataSource del informe
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "Reporte de Expedición de Constancias de Reclusión"
                .LocalReport.ReportPath = ReportePath & "rpt_expedicion_cr_2022_04.rdlc"

                .LocalReport.EnableExternalImages = True

                .LocalReport.DataSources.Add(New ReportDataSource("detalle", listadetalle))
                'Enviemos la lista de parametros
                .LocalReport.SetParameters(parameters)
                .SetDisplayMode(DisplayMode.PrintLayout)
                'Hagamos un refresh al reportViewer
                .RefreshReport()
            End With

        End Sub

        Private Sub rptExpedicionConstanciaGrupo()

            'se generas las clases como listas
            Dim bssReporte As New Bussines.Registro.ConstanciaReclusion.Reporte
            Dim listadetalle As New List(Of Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion)()

            listadetalle = bssReporte.listarReporteExpedicion(Me.filtro)

            'obtener las cantidades
            Dim total As Integer = listadetalle.Count
            Dim cantSinCosto As Integer = 0
            Dim cantConCosto As Integer = 0

            'consulta linq
            Dim query = From tabla As Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion In listadetalle
                        Where tabla.tipoTramite = 1
                        Select tabla

            cantConCosto = query.Count
            cantSinCosto = total - cantConCosto

            'parametros del reporte
            Dim parameters As ReportParameter() = New ReportParameter(12) {}
            parameters(0) = New ReportParameter("p_filtro_region_nom", filtro.regionNombre.ToUpper)
            parameters(1) = New ReportParameter("p_filtro_penal_nom", filtro.penalNombre.ToUpper)
            parameters(2) = New ReportParameter("p_filtro_fec_ini", filtro.fechaInicio.ToShortDateString)
            parameters(3) = New ReportParameter("p_filtro_fec_fin", filtro.fechaFin.ToShortDateString)
            parameters(4) = New ReportParameter("p_filtro_tipo_tramite", filtro.tipoTramiteNombre)
            parameters(5) = New ReportParameter("p_resumen_costo", cantConCosto)
            parameters(6) = New ReportParameter("p_resumen_sincosto", cantSinCosto)
            parameters(7) = New ReportParameter("p_resumen_total", total)
            'parametros del pie de pagina
            parameters(8) = New ReportParameter("p_rpt_num_imp", "")
            parameters(9) = New ReportParameter("p_rpt_pc_mac", Legolas.Components.PC.GetMAC)
            parameters(10) = New ReportParameter("p_rpt_acta", "")
            parameters(11) = New ReportParameter("p_rpt_usuario", Legolas.Configuration.Usuario.ApellidosyNombre.ToUpper)
            parameters(12) = New ReportParameter("p_rpt_fec_imp", Now.ToString)

            With Me.ReportViewer1

                'Limpiemos el DataSource del informe
                .LocalReport.DataSources.Clear()
                .ZoomPercent = 100
                .LocalReport.DisplayName = "Reporte de Expedición de Constancias de Reclusión"
                .LocalReport.ReportPath = ReportePath & "rpt_expedicion_cr_grupo_2022_04.rdlc"

                .LocalReport.EnableExternalImages = True

                .LocalReport.DataSources.Add(New ReportDataSource("detalle", listadetalle))
                'Enviemos la lista de parametros
                .LocalReport.SetParameters(parameters)
                .SetDisplayMode(DisplayMode.PrintLayout)
                'Hagamos un refresh al reportViewer
                .RefreshReport()
            End With

        End Sub
        Private Sub VerReporte()

            Select Case Me.idTipoReporte
                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.expedicionConstancias
                    rptExpedicionConstancia()

                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.expedicionConstanciaGrupo
                    rptExpedicionConstanciaGrupo()

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
        'Private Sub Impresion(ByVal PrinterName As String)

        '    Dim strRuta As String = ""
        '    GenerarCabecera()

        '    strRuta = Legolas.Configuration.Path.PathTemp & Me.ReporteNombreFisico & ".pdf"

        '    Dim startInfo As New ProcessStartInfo()
        '    startInfo.FileName = strRuta
        '    startInfo.Arguments = PrinterName
        '    startInfo.Verb = "print"
        '    'startInfo.Verb = "PrintTo"
        '    startInfo.WindowStyle = ProcessWindowStyle.Hidden
        '    startInfo.CreateNoWindow = True
        '    startInfo.UseShellExecute = True
        '    startInfo.ErrorDialog = True
        '    System.Diagnostics.Process.Start(startInfo)

        'End Sub
#End Region
#Region "Otros"

#End Region

        Private Sub frmReporte_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.Text = fnNombreReporte()
            VerReporte()

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

        'Private Sub ReportViewer1_Print(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.Print

        '    'Select Case Me._pReporteTipo
        '    '    Case EnmTipoReporte.rptReporte1

        '    '    Case Else
        '    '        e.Cancel = True
        '    'Impresion(False)
        '    'End Select

        'End Sub

        Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace

