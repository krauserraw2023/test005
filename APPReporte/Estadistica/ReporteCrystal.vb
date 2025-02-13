Imports CrystalDecisions.CrystalReports 'borrar
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows 'borrar
Namespace Estadistica
    Public Class ReporteCrystal
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private strFotoPC As String = ""
        Private strFotoPI As String = ""
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
#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Registro.Filtro
        Public Property _PadinID() As Integer = -1
        Public Property _Anio() As Integer = -1
        Public Property _Mes() As Integer = -1
        Public Property _FechaInicio As Long = 0
        Public Property _FechaFin As Long = 0
        Public Property _Correlativo() As Integer = 0
        Public Property _EstadoPadin() As Integer = -1
        Public Property _Nacionalidad() As EnmNaciolidad = EnmNaciolidad.Todos
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
        Public Property _PenalID() As Integer = -1
        Public Property _pReporteTipo() As EnmTipoReporte = EnmTipoReporte.rpt
#End Region
#Region "Propiedades_Reporte"
        Private intRpt As Integer = 0
        Public Property _VersionRpt As Integer
            Get
                Return intRpt
            End Get
            Set(value As Integer)
                intRpt = value
            End Set
        End Property

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

                value = Legolas.Configuration.Path.PathReporte & "Estadistica\"

                Return value
            End Get
        End Property
        Public Property _pRestriccionCol() As Entity.Reporte.CertificadoLibertad.RestriccionCol = Nothing

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
            Select Case Me._pReporteTipo
                'Case EnmTipoReporte.rptReporte1


                Case EnmTipoReporte.rptReporte2

                    'Me.Filtro = Legolas.Components.FechaHora.MesNombre(Me._Mes) & " DE " & Me._Anio

                    'objEntCol = New Entity.Reporte.Estadistica.Reporte02Col
                    'objEntCol = objBss.Reporte2(Me._PadinID, Me._PenalID, Me._Nacionalidad)

                    'objEntCol2 = New Entity.Reporte.Estadistica.Formato1Col
                    'objEntCol2 = objBss.FormatoF1_2(Me._PadinID, Me._PenalID, Me._FechaInicio, Me._FechaFin)
                    Reporte_Padin_F14()
                    'Case EnmTipoReporte.rptReporte3



            End Select

        End Sub


        Private Sub Reporte_Padin_F14()

            Dim objBss As New Bussines.Reporte.Estadistica
            rpt = New ReportDocument

            Dim objEntCol As New Entity.Reporte.Estadistica.Formato1Col
            objEntCol = objBss.FormatoF1_2(Me._PadinID, Me._PenalID, Me._FechaInicio, Me._FechaFin)
            rpt.Load(Me.ReportePath & "rpt_cuadro14.rpt")

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            For Each obj As Entity.Reporte.Estadistica.Formato1 In objEntCol
                rpt.SetParameterValue("p_penal", obj.PenalNombre.ToUpper)
                rpt.SetParameterValue("p_ubicacion_geo", obj.UbicacionGeografica.ToUpper)
                rpt.SetParameterValue("p_direccion", obj.Domicilio.ToUpper)
                rpt.SetParameterValue("p_telefono", obj.Telefono)
                rpt.SetParameterValue("p_info_padin", Legolas.Components.FechaHora.MesNombre(Me._Mes).ToUpper & " DE " & Me._Anio & " | FECHA DE CORTE : " & Legolas.Components.FechaHora.FechaString(Me._FechaFin) & " | N° PADIN : " & Me._Correlativo)
                rpt.SetParameterValue("p_nac_filtro", NacionalidadTitulo.ToUpper)
            Next obj

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_reporte_nominal")
            rpt.SetParameterValue("@pen_id", Me._PenalID)
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", Me._Nacionalidad)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@pad_id", Me._PadinID)

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            rpt.SetParameterValue("p_estado", Me._EstadoPadin)

            Me.CrystalReportViewer1.ReportSource = rpt



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
        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

            Me.Close()

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
    End Class
End Namespace
