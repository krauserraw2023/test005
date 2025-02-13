Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Namespace Registro.Siscrico
    Public Class frmReporte
        Private rpt As ReportDocument = Nothing
        Private strAnioTexto As String = """ AÑO DE LA PROMOCIÓN DE LA INDUSTRIA RESPONSABLE Y DEL COMPROMISO CLIMÁTICO """
        Public Property _FormImpresion() As Boolean = False
#Region "Propiedades_Parametricas"
        Public Property RegionID As Integer = -1
        Public Property PenalID As Integer = -1
        Public Property TipoBandaId As Integer = -1
        Public Property BandaId As Integer = -1
        Public Property TipoIntegranteOrgCrim As Integer = -1
        Public Property NombreOrgCriminal As String = ""
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As Type.Reporte.Registro = Type.Reporte.Registro.rpt
        Private ReadOnly Property ReporteID() As Integer
            Get
                Dim intCodigoReporte As Integer = -1
                intCodigoReporte = Me._TipoReporte.GetHashCode
                Return intCodigoReporte
            End Get
        End Property
        Public Property _TipoReporte() As Type.Reporte.Registro
            Get
                Return intTipoReporte
            End Get
            Set(ByVal value As Type.Reporte.Registro)
                intTipoReporte = value
            End Set
        End Property
        Private Property ReporteNombre() As String = ""
        Private Property ReporteNombreFisico() As String = ""
        Private Property ReporteDependencia() As String = ""
        Private Property ReporteModulo() As String = ""
        Private Property ReporteModuloVersion() As String = ""
        Private Property ReporteActa() As String = ""
        Private Property ReporteNumero() As Integer = 0
        Private Property ReporteNumeroExportacion() As Integer = 0
        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""

                value = Legolas.Configuration.Path.PathReporte & "Registro\Siscrico\"

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
#End Region
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
        Private Sub VerReporte(Optional ByVal Impresion As Boolean = False, _
        Optional ByVal Oficina As String = "", Optional ByVal ExportarPDF As Boolean = False)
            Select Case Me._TipoReporte
                Case Type.Reporte.Registro.rptGruposCrimenOrganizado
                    Reporte_GruposCrimenOrganizado()
                Case Type.Reporte.Registro.rptIntPorGrupCrimOrg_X_Penal
                    Reporte_IntegrantesPorGrupCrimOrg_x_penal()
                Case Type.Reporte.Registro.rptIntPorGrupCrimOrg_X_Sede
                    Reporte_IntegrantesPorGrupCrimOrg_x_Sede()
                Case Type.Reporte.Registro.rptCabecillasGrupCrim
                    Reporte_CabecillaPorGrupCrim()
                Case Type.Reporte.Registro.rptIntPorGrupCrimOrg_Resumen
                    Reporte_IntegrantesPorGrupCrimOrg_Resumen()
            End Select
        End Sub
        Private Sub Reporte_IntegrantesPorGrupCrimOrg_Resumen()
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_int_org_crim_resumen.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_integrantes_resumen")
            rpt.SetParameterValue("@reg_id", Me.RegionID)
            rpt.SetParameterValue("@pen_id", Me.PenalID)
            rpt.SetParameterValue("@tip_band_id", Me.TipoBandaId)
            'rpt.SetParameterValue("@ban_id", Me.BandaId)
            rpt.SetParameterValue("@ban_mie_tip_id", Me.BandaId)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            crvVisor.ReportSource = rpt
        End Sub
        Private Sub Reporte_CabecillaPorGrupCrim()
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_cabecilla_band.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)
            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_integrantes_banda")
            rpt.SetParameterValue("@reg_id", Me.RegionID)
            rpt.SetParameterValue("@pen_id", Me.PenalID)
            rpt.SetParameterValue("@tip_band_id", Me.TipoBandaId)
            rpt.SetParameterValue("@ban_id", Me.BandaId)
            rpt.SetParameterValue("@ban_mie_tip_id", Me._TipoIntegranteOrgCrim)
            'rpt.SetParameterValue("@int_id", -1)
            'rpt.SetParameterValue("@ban_mie_tip_id", -1)
            'rpt.SetParameterValue("@int_ban_est", -1)
            'rpt.SetParameterValue("@doc_jud_id", -1)
            'rpt.SetParameterValue("@int_ban_obs", -1)
            'rpt.SetParameterValue("@_usuario", -1)
            'rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            crvVisor.ReportSource = rpt
        End Sub
        Private Sub Reporte_IntegrantesPorGrupCrimOrg_x_penal()
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_int_org_crim_penal.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_integrantes_banda")
            rpt.SetParameterValue("@reg_id", Me.RegionID)
            rpt.SetParameterValue("@pen_id", Me.PenalID)
            rpt.SetParameterValue("@tip_band_id", Me.TipoBandaId)
            rpt.SetParameterValue("@ban_id", Me.BandaId)
            'rpt.SetParameterValue("@int_ban_id", Me.TipoBandaId)
            'rpt.SetParameterValue("@int_id", -1)
            'rpt.SetParameterValue("@ban_mie_tip_id", -1)
            'rpt.SetParameterValue("@int_ban_est", -1)
            'rpt.SetParameterValue("@doc_jud_id", -1)
            'rpt.SetParameterValue("@int_ban_obs", -1)
            'rpt.SetParameterValue("@_usuario", -1)
            'rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("p_org_crim_nombre", Me.NombreOrgCriminal)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            crvVisor.ReportSource = rpt
        End Sub
        Private Sub Reporte_IntegrantesPorGrupCrimOrg_x_Sede()
            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_int_org_crim_x_sede.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_integrantes_banda")
            rpt.SetParameterValue("@reg_id", Me.RegionID)
            rpt.SetParameterValue("@pen_id", Me.PenalID)
            rpt.SetParameterValue("@tip_band_id", Me.TipoBandaId)
            rpt.SetParameterValue("@ban_id", Me.BandaId)
            'rpt.SetParameterValue("@int_ban_id", Me.TipoBandaId)
            'rpt.SetParameterValue("@int_id", -1)
            'rpt.SetParameterValue("@ban_mie_tip_id", -1)
            'rpt.SetParameterValue("@int_ban_est", -1)
            'rpt.SetParameterValue("@doc_jud_id", -1)
            'rpt.SetParameterValue("@int_ban_obs", -1)
            'rpt.SetParameterValue("@_usuario", -1)
            rpt.SetParameterValue("p_org_crim_nombre", Me.NombreOrgCriminal)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            crvVisor.ReportSource = rpt
        End Sub
        Private Sub Reporte_GruposCrimenOrganizado()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_org_criminal.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_bandas")
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@tip_band_id", Me.TipoBandaId)
            rpt.SetParameterValue("@tip_band_id", Me.TipoBandaId)



            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            crvVisor.ReportSource = rpt

        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            With Me.crvVisor
                .ShowExportButton = False
                .ShowGroupTreeButton = False
                .ShowCloseButton = False
                .ShowParameterPanelButton = False
                .ShowRefreshButton = False
                .ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            End With

            mnuImprimir.Enabled = Me._FormImpresion
            mnuExportPdf.Enabled = Me._FormImpresion

            crvVisor.ShowExportButton = False
            crvVisor.ShowPrintButton = Me._FormImpresion
            crvVisor.ShowCopyButton = False
            crvVisor.ShowRefreshButton = False

        End Sub
        Private Sub ExportarPDF()

            With Me.SaveFileDialog2
                .FileName = ""
                .Filter = "Solo PDF (*.pdf)|*.pdf"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExportToPDF(Me.rpt, .FileName, "")
                End If

            End With

        End Sub
        Public Sub ExportToPDF(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

            Dim vFileName As String
            Dim diskOpts As New DiskFileDestinationOptions

            Try
                With rpt.ExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                End With

                vFileName = Path & NombreArchivo

                If Legolas.Components.Archivo.FileExiste(vFileName) Then
                    Legolas.Components.Archivo.FileDelete(vFileName)
                End If

                diskOpts.DiskFileName = vFileName
                Reporte.ExportOptions.DestinationOptions = diskOpts
                Reporte.Export()

                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
        '
        Private Sub mnuImprimir_Click(sender As System.Object, e As System.EventArgs) Handles mnuImprimir.Click
            Me.crvVisor.PrintReport()
        End Sub

        Private Sub mnuExportPdf_Click(sender As System.Object, e As System.EventArgs) Handles mnuExportPdf.Click
            ExportarPDF()
        End Sub

        Private Sub mnuSalir_Click(sender As System.Object, e As System.EventArgs) Handles mnuSalir.Click
            Me.Close()
        End Sub

        Private Sub frmReporte_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            rpt.Dispose()
            crvVisor.Dispose()
        End Sub

        Private Sub frmReporte_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub frmReporte_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            ListarPropiedadesReporte()
            Me.Text = Me.ReporteNombre
            VerReporte()
        End Sub
    End Class
End Namespace
