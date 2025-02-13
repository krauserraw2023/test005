Option Explicit On
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Data
Imports Bussines

Namespace Registro.ConstanciaReclusion
    Public Class ReporteCrystal
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private idTipoReporte As Type.Enumeracion.ConstanciaReclusion.enmReporte = Type.Enumeracion.ConstanciaReclusion.enmReporte.ninguno
        Private filtro As Entity.Registro.ConstanciaReclusion.ReporteFiltro = Nothing
        Private bssTramite As Bussines.Registro.ConstanciaReclusion.Tramite = Nothing
        Private idLicencia As Short = -1

        Public Sub New(idLicencia As Short, tipoReporte As Type.Enumeracion.ConstanciaReclusion.enmReporte, filtro As Entity.Registro.ConstanciaReclusion.ReporteFiltro)

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()
            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.idTipoReporte = tipoReporte
            Me.filtro = filtro
            Me.idLicencia = idLicencia

            habilitarControles()

        End Sub
#Region "Propiedades_Reporte"
        Private Property pathFileInternoFotoPC As String = ""
        Private ReadOnly Property ReportePath() As String
            Get
                Dim value As String = ""

                value = Legolas.Configuration.Path.PathReporte & "Registro\"

                value = value.Replace("\\", "\")
                Return value
            End Get
        End Property

#Region "Functions"
        Private Function fnNombreReporte() As String

            Dim value As String = ""
            Select Case Me.idTipoReporte
                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.constanciaReclusion
                    value = "Constancia de Reclusión"
            End Select

            Return value
        End Function
#End Region
#End Region
#Region "Reporte"
        Private Sub VerReporte()

            Dim strMensajeOut As String = ""

            Select Case Me.idTipoReporte

                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.constanciaReclusion
                    rptContanciaReclusion()

            End Select

        End Sub
        Private Function registrarImpresion(motivoImpresion As String) As Integer

            Dim value As Integer = -1
            Dim bssImpresion As New Bussines.Registro.ConstanciaReclusion.Impresion
            value = bssImpresion.Grabar(Me.filtro.idTramiteCR, motivoImpresion, Me.filtro.idRegion, Me.filtro.idPenal)

            Return value
        End Function
        Private Sub rptContanciaReclusion()

            rpt = New ReportDocument

            'descargar la foto temporalmente
            Dim pathDir As String = Legolas.Configuration.Path.PathTemp
            Dim nombreArchivo As String = "tmp_fot_int_pc_" + Now.ToFileTime.ToString + ".jpg"
            pathFileInternoFotoPC = pathDir + nombreArchivo
            Dim fotoBase64 As String = ""

            Dim bss As New Bussines.Registro.ConstanciaReclusion.Tramite
            fotoBase64 = bss.getPathFoto(filtro.idTramiteCR)

            If fotoBase64.Length > 0 Then
                Dim fotoByte As Byte() = Convert.FromBase64String(fotoBase64)
                IO.File.WriteAllBytes(pathFileInternoFotoPC, fotoByte)
            End If

            rpt.Load(Me.ReportePath & "rpt_ConstanciaReclusion_2022_04.rpt")

            rpt.DataSourceConnections(0).SetConnection(
            Legolas.Configuration.Data.CNServer,
            Legolas.Configuration.Data.CNDataBase,
            Legolas.Configuration.Data.CNUser,
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_interno_constancia_reclusion")
            rpt.SetParameterValue("@pk_cons_rec_tra_id", Me.filtro.idTramiteCR)
            rpt.SetParameterValue("p_ruta_imagenPC", pathFileInternoFotoPC)
            'valores x default
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@fec_ini", "01/01/2022")
            rpt.SetParameterValue("@fec_fin", "31/12/2022")
            rpt.SetParameterValue("@id_sol_tra", -1)
            rpt.SetParameterValue("@tip_tram", -1)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

#End Region

#Region "Otros"
        Private Sub imprimirCR()

            If Legolas.Configuration.Aplication.MessageBox.Question("Desea imprimir la Constancia de Reclusión, se registrará el usuario de impresión?") <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim imprimir As Boolean = False
            Dim cantidadImpresion As Integer = 0
            Dim motivoImpresion As String = ""
            Dim bssImpresion As New Bussines.Registro.ConstanciaReclusion.Impresion
            cantidadImpresion = bssImpresion.fnCantidadImpresion(Me.filtro.idTramiteCR)

            If cantidadImpresion < 1 Then
                imprimir = True
            Else

                Dim frm As New Registro.ConstanciaReclusion.frmObsPopup
                With frm
                    If .ShowDialog = DialogResult.OK Then
                        motivoImpresion = ._observacion
                        imprimir = True
                    End If
                End With

            End If

            If imprimir = True Then
                If registrarImpresion(motivoImpresion) > 0 Then
                    Me.CrystalReportViewer1.PrintReport()
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("Ocurrio un problema al imprimir el reporte, vuelva ha intentarlo.")
                End If
            End If

        End Sub
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
        Private Sub habilitarControles()

            Dim puedeImprimir As Boolean = True

            Dim tipoLicencia As Short = -1
            Dim bssLicencia As New Bussines.Sistema.Instalacion
            tipoLicencia = bssLicencia.ListarTipo(Me.idLicencia)

            If tipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia Or
                tipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Sede Then
                puedeImprimir = False
            End If

            If Me.filtro.estadoTramite = Type.Enumeracion.ConstanciaReclusion.enmEstado.pendiente Or puedeImprimir = False Then
                Me.ArchivoToolStripMenuItem.Visible = False
            End If

        End Sub
#End Region
        Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
            Me.Close()
        End Sub

        Private Sub ReporteCrystal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

            rpt.Dispose()
            CrystalReportViewer1.Dispose()

            Try
                Legolas.Components.Archivo.FileDelete(pathFileInternoFotoPC)

            Catch ex As Exception

            End Try

        End Sub

        Private Sub ReporteCrystal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
            Me.WindowState = FormWindowState.Maximized
        End Sub

        Private Sub ReporteCrystal_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.Text = Me.fnNombreReporte
            VerReporte()

        End Sub

        Private Sub ImpirmirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImpirmirToolStripMenuItem.Click


            Select Case Me.idTipoReporte
                Case Type.Enumeracion.ConstanciaReclusion.enmReporte.constanciaReclusion

                    imprimirCR

                Case Else
                    Me.CrystalReportViewer1.PrintReport()
            End Select

        End Sub

        Private Sub ExportarPDFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportarPDFToolStripMenuItem.Click
            ExportarPDF()
        End Sub

        Private Sub mnuExportarVarios_Click(sender As System.Object, e As System.EventArgs) Handles mnuExportarVarios.Click
            CrystalReportViewer1.ExportReport()
        End Sub

    End Class
End Namespace
