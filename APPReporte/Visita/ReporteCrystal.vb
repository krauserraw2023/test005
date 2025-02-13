Imports CrystalDecisions.CrystalReports 'borrar
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows 'borrar
Imports System.Data.SqlClient
Imports System.Data

Namespace Visita
    Public Class ReporteCrystal
        'Private rpt As ReportDocument = Nothing
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Visita.Filtro
#End Region
#Region "Propiedades_Reporte"
        Private intTipoReporte As Type.Reporte.Visita = Type.Reporte.Visita.rpt
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

                value = Legolas.Configuration.Path.PathReporte & "Visita\"

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
        Private Sub VerReporte()

            Select Case Me._TipoReporte

                Case Type.Reporte.Visita.rptAutorizacion
                    Reporte_Autorizacion()

                Case Type.Reporte.Visita.rpt_autorizacion_anexo
                    Reporte_AutorizacionAnexo()

                Case Type.Reporte.Visita.rpt_autorizacion_grupo
                    Reporte_AutorizacionGrupo()

                Case Type.Reporte.Visita.rpt_autorizacion_estadistico
                    Reporte_AutorizacionEstadistico()

                Case Type.Reporte.Visita.rpt_siscrico_visita
                    Reporte_SicricoVisita()

                Case Type.Reporte.Visita.rpt_visita_interno_historial

                    Reporte_InternoHistorial()

                Case Type.Reporte.Visita.rpt_visita_visitante_historial

                    Reporte_VisitanteHistorial()

                Case Type.Reporte.Visita.rpt_visita_movimientos_x_fechas

                    Reporte_Movimientos_X_Fechas()

                Case Type.Reporte.Visita.rpt_visita_resumen_movimientos_x_fechas

                    Reporte_Movimientos_Resumen_X_Fechas()

            End Select

        End Sub
        Private Sub Reporte_Autorizacion()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_autorizacion.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
             Legolas.Configuration.Data.CNServer, _
             Legolas.Configuration.Data.CNDataBase, _
             Legolas.Configuration.Data.CNUser, _
             Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_autorizacion")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@pab_id", Me._Filtro.PabellonID)
            rpt.SetParameterValue("@est_id", Me._Filtro.EstadoID)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            '/*no se usa*/
            rpt.SetParameterValue("@vis_id", Me._Filtro.VisitanteID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            CrystalReportViewer1.ReportSource = rpt


        End Sub
        Private Sub Reporte_AutorizacionAnexo()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_autorizacion_anexo.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_autorizacion")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@pab_id", Me._Filtro.PabellonID)
            rpt.SetParameterValue("@est_id", Me._Filtro.EstadoID)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            '/*no se usa*/
            rpt.SetParameterValue("@vis_id", Me._Filtro.VisitanteID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub Reporte_AutorizacionGrupo()

            rpt = New ReportDocument
            Dim CNCrystal As ConnectionInfo = New ConnectionInfo

            With CNCrystal
                .ServerName = Legolas.Configuration.Data.CNServer
                .DatabaseName = Legolas.Configuration.Data.CNDataBase
                .UserID = Legolas.Configuration.Data.CNUser
                .Password = Legolas.Configuration.Data.CNPass
                .Type = ConnectionInfoType.SQL
            End With

            rpt.Load(Me.ReportePath & "rpt_autorizacion_grupo.rpt")

            'rpt.DataSourceConnections(0).SetConnection( _
            'Legolas.Configuration.Data.CNServer, _
            'Legolas.Configuration.Data.CNDataBase, _
            'Legolas.Configuration.Data.CNUser, _
            'Legolas.Configuration.Data.CNPass)

            'rpt.SetDatabaseLogon(Legolas.Configuration.Data.CNUser, Legolas.Configuration.Data.CNPass, _
            '                     Legolas.Configuration.Data.CNServer, Legolas.Configuration.Data.CNDataBase)

            SetDBLogonForReport(CNCrystal, rpt)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_autorizacion")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@pab_id", Me._Filtro.PabellonID)
            rpt.SetParameterValue("@est_id", Me._Filtro.EstadoID)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            '/*no se usa*/
            rpt.SetParameterValue("@vis_id", Me._Filtro.VisitanteID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)

            CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)

            Dim myTables As Tables = myReportDocument.Database.Tables
            For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables

                Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
                myTableLogonInfo.ConnectionInfo = myConnectionInfo
                myTable.ApplyLogOnInfo(myTableLogonInfo)
            Next

        End Sub
        Private Sub Reporte_AutorizacionEstadistico()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_autorizacion_estadistico.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_autorizacion")
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@pab_id", Me._Filtro.PabellonID)
            rpt.SetParameterValue("@est_id", Me._Filtro.EstadoID)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            '/*no se usa*/
            rpt.SetParameterValue("@vis_id", Me._Filtro.VisitanteID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub Reporte_SicricoVisita()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_siscrico_visita.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
             Legolas.Configuration.Data.CNServer, _
             Legolas.Configuration.Data.CNDataBase, _
             Legolas.Configuration.Data.CNUser, _
             Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_visita_x_Organizacion")
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@ban_tip_id", Me._Filtro.BandaTipoID)
            rpt.SetParameterValue("@ban_id", Me._Filtro.BandaID)
            rpt.SetParameterValue("@ban_mie_tip_id", Me._Filtro.BandaMiembroTipoID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)

            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            '/*no se usa*/
            rpt.SetParameterValue("@vis_id", Me._Filtro.VisitanteID)
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            rpt.SetParameterValue("@pab_id", Me._Filtro.PabellonID)
            rpt.SetParameterValue("@est_id", Me._Filtro.EstadoID)

            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_VisitanteHistorial()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_visita_visitante_historial.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
             Legolas.Configuration.Data.CNServer, _
             Legolas.Configuration.Data.CNDataBase, _
             Legolas.Configuration.Data.CNUser, _
             Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_visita_movimiento")
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@vis_id", Me._Filtro.VisitanteID)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_filtro_fecha", Me._Filtro.FechaFiltroText)
            '/*no se usa*/            
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@mov_id", -1)
            rpt.SetParameterValue("@id_regimen", -1)

            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_InternoHistorial()

            'codigo de prueba para ver si el objecto procedure esta lento, alter el procedure

            ' ''Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            ' ''Dim Cmd As SqlCommand
            ' ''Dim sqlReader As SqlDataReader

            ' ''Cmd = New SqlCommand("up_vis_reporte_crystal")
            ' ''Cmd.Connection = sqlCon
            ' ''Cmd.CommandType = CommandType.StoredProcedure

            ' ''Cmd.Parameters.Add("@accion", SqlDbType.VarChar, 3).Value = "lst"
            ' ''Cmd.Parameters.Add("@opcion", SqlDbType.VarChar, 120).Value = "lst_visita_movimiento"
            ' ''Cmd.Parameters.Add("@reg_id", SqlDbType.Int).Value = 3
            ' ''Cmd.Parameters.Add("@pen_id", SqlDbType.Int).Value = 41
            ' ''Cmd.Parameters.Add("@fec_ini", SqlDbType.BigInt).Value = 131593174820000000
            ' ''Cmd.Parameters.Add("@fec_fin", SqlDbType.BigInt).Value = 131661430820000000
            ' ''Cmd.Parameters.Add("@int_id", SqlDbType.Int).Value = 400668
            ' ''Cmd.CommandTimeout = 180
            ' ''sqlCon.Open()
            ' ''sqlReader = Cmd.ExecuteReader()

            ' ''Dim dt As New DataTable
            ' ''dt.Load(sqlReader)
            ' ''MessageBox.Show(dt.Rows.Count)


            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_visita_interno_historial.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
             Legolas.Configuration.Data.CNServer, _
             Legolas.Configuration.Data.CNDataBase, _
             Legolas.Configuration.Data.CNUser, _
             Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_visita_movimiento")
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@int_id", Me._Filtro.InternoID)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_filtro_fecha", Me._Filtro.FechaFiltroText)
            '/*no se usa*/
            rpt.SetParameterValue("@mov_id", -1)
            rpt.SetParameterValue("@vis_id", -1)
            rpt.SetParameterValue("@id_regimen", -1)

            CrystalReportViewer1.ReportSource = rpt
            'rpt.SetDataSource (

        End Sub

        Private Sub Reporte_Movimientos_X_Fechas()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_visita_movimientos_x_fechas.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
             Legolas.Configuration.Data.CNServer, _
             Legolas.Configuration.Data.CNDataBase, _
             Legolas.Configuration.Data.CNUser, _
             Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_visita_movimiento")
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_filtro_fecha", Me._Filtro.FechaFiltroText)
            '/*no se usa*/
            rpt.SetParameterValue("@mov_id", -1)
            rpt.SetParameterValue("@vis_id", -1)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@id_regimen", -1)

            CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Sub Reporte_Movimientos_Resumen_X_Fechas()

            rpt = New ReportDocument

            rpt.Load(Me.ReportePath & "rpt_visita_resumen_movimientos_x_fechas.rpt")
            rpt.DataSourceConnections(0).SetConnection( _
             Legolas.Configuration.Data.CNServer, _
             Legolas.Configuration.Data.CNDataBase, _
             Legolas.Configuration.Data.CNUser, _
             Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_tipo_visita ")
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@id_regimen", Me._Filtro.IDRegimenPenal)
            '/*paramateros*/
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_filtro_fecha", Me._Filtro.FechaFiltroText)
            '/*no se usa*/            
            rpt.SetParameterValue("@mov_id", -1)
            rpt.SetParameterValue("@vis_id", -1)
            rpt.SetParameterValue("@int_id", -1)

            CrystalReportViewer1.ReportSource = rpt

        End Sub
#End Region

#Region "Otros"
        Private Sub ValoresxDefault()

            With Me.CrystalReportViewer1
                .ShowExportButton = False
                .ShowGroupTreeButton = False
                .ShowCloseButton = False
                .ShowParameterPanelButton = False
                .ShowRefreshButton = False
                .ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            End With

        End Sub
        Private Sub ExportarPDF()

            With Me.SaveFileDialog1
                .FileName = ""
                .Filter = "Solo PDF (*.pdf)|*.pdf"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExportToPDF(Me.rpt, .FileName, "")
                End If

            End With

        End Sub
        Private Sub ExportarExcel()

            With Me.SaveFileDialog1
                .FileName = ""
                .Filter = "Solo PDF (*.xls)|*.xls"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    ExportToExcel(Me.rpt, .FileName, "")
                End If

            End With

        End Sub
        Private Sub ExportToPDF(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

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
        Private Sub ExportToExcel(ByVal Reporte As ReportDocument, ByVal Path As String, ByVal NombreArchivo As String)

            Dim vFileName As String
            Dim diskOpts As New DiskFileDestinationOptions

            Try
                With rpt.ExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.Excel
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

        Private Sub PermisosUsuario()

            Me.ExportarAExcelToolStripMenuItem.Visible = False

            If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                Me.ExportarAExcelToolStripMenuItem.Visible = True
            End If

        End Sub
#End Region

        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

            Me.Close()

        End Sub

        Private Sub ReporteCrystal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

            rpt.Dispose()
            CrystalReportViewer1.Dispose()

        End Sub

        Private Sub ReporteCrystal_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()
            Me.WindowState = FormWindowState.Maximized

        End Sub

        Private Sub ReporteCrystal_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ListarPropiedadesReporte()
            Me.Text = Me.ReporteNombre
            VerReporte()

        End Sub

        Private Sub ImpirmirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpirmirToolStripMenuItem.Click

            Me.CrystalReportViewer1.PrintReport()

        End Sub

        Private Sub ExportarPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarPDFToolStripMenuItem.Click

            ExportarPDF()

        End Sub

        Private Sub ExportarAExcelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
            ExportarExcel()
        End Sub
    End Class
End Namespace
