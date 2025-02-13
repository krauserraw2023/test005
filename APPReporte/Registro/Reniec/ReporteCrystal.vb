Imports CrystalDecisions.CrystalReports 'borrar
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows 'borrar
Namespace Registro.Reniec
    Public Class ReporteCrystal
        Private rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
        Private strFotoPC As String = ""
        Private strFotoRncPC As String = ""
#Region "Propiedades_Parametricas"
        Public Property _Filtro() As New Entity.Reporte.Registro.Filtro
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

                value = Legolas.Configuration.Path.PathReporte & "Registro\Reniec\"

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

                Case Type.Reporte.Registro.rptFichaValidIntReniec
                    Reporte_FichaValidacionReniec()
                Case Type.Reporte.Registro.rptListaIntValidReniec
                    Reporte_ListaInternosValidadosReniec()
            End Select

        End Sub

        Private Sub Reporte_FichaValidacionReniec() 'ficha RENIEC
            rpt = New ReportDocument

            Dim objEnt As New Entity.Registro.InternoReniec
            Dim objBssInternoReniec As New Bussines.Registro.InternoReniec
            Dim objEntInterno As New Entity.Registro.InternoReniec

            objEntInterno.InternoID = Me._Filtro.InternoID

            objEnt = objBssInternoReniec.ListarUltimaValidacion(objEntInterno)

            If objEnt Is Nothing OrElse objEnt.InternoID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Interno pendiente de validación con la reniec")
                Me.Close()
                Exit Sub
            End If

            rpt.Load(Me.ReportePath & "rpt_rnc_ficha_validacion.rpt")

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_nom_asoc_rnc")
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@pen_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", 0)
            rpt.SetParameterValue("@fec_fin", 0)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", -1)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@nac_id", -1)

            rpt.SetParameterValue("@int_rnc_id", objEnt.Codigo)

            Dim strRegistro() As String = objEnt.InternoSisData.Split("|")

            rpt.SetParameterValue("p_pop_dni", strRegistro(0))
            rpt.SetParameterValue("p_pop_ape_pat", strRegistro(1))
            rpt.SetParameterValue("p_pop_ape_mat", strRegistro(2))
            rpt.SetParameterValue("p_pop_nom", strRegistro(3))
            rpt.SetParameterValue("p_pop_fec_nac", strRegistro(5))
            rpt.SetParameterValue("p_pop_sexo", If(UCase(strRegistro(4)) = "MAS", "M", "F"))
            rpt.SetParameterValue("p_pop_padre", If(Trim(strRegistro(10)) = "", "NR", strRegistro(10)))
            rpt.SetParameterValue("p_pop_madre", If(Trim(strRegistro(11)) = "", "NR", strRegistro(11)))
            rpt.SetParameterValue("p_pop_talla", strRegistro(14))
            rpt.SetParameterValue("p_pop_conyuge", If(Trim(strRegistro(12)) = "", "NR", strRegistro(12)))
            rpt.SetParameterValue("p_pop_gradoins", If(Trim(strRegistro(13)) = "", "NR", strRegistro(13)))
            rpt.SetParameterValue("p_pop_est_civil", If(Trim(strRegistro(7)) = "", "NR", strRegistro(7)))
            rpt.SetParameterValue("p_pop_ubi_nac", If(Trim(strRegistro(6)) = "", "NR", strRegistro(6)))
            rpt.SetParameterValue("p_pop_ubi", If(strRegistro(8) = "", "NR", strRegistro(8)))
            rpt.SetParameterValue("p_pop_dir", If(Trim(strRegistro(9)) = "", "NR", strRegistro(9)))
            rpt.SetParameterValue("p_penal", If(objEnt.PenalNombre = "", "NR", UCase(objEnt.PenalNombre)))
            rpt.SetParameterValue("p_region", If(objEnt.RegionNombre = "", "NR", UCase(objEnt.RegionNombre)))
            rpt.SetParameterValue("p_pop_cod_rp", objEnt.InternoCodRP)

            Dim objBssRnc As New Bussines.Registro.InternoReniec

            Dim entRnc As New Entity.Registro.InternoReniec
            entRnc.InternoID = objEntInterno.InternoID
            entRnc = objBssRnc.ListarUltimaValidacion(entRnc)

            'identificar la licencia de la bd
            Dim objBss As New Bussines.Sistema.Instalacion
            Dim intIDTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Try
                strFotoPC = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "intPC.tmp"

                Select Case intIDTipoLocal
                    Case 2 'region
                        Legolas.Components.Archivo.FileCreateByte((New Bussines.Globall.ArchivoDigital).getArchivoDigitalByte_Region(entRnc.FotoInterno, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, ""), strFotoPC)
                    Case Else
                        'sede y penal
                        Legolas.Components.Archivo.FileCreateByte((New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(entRnc.FotoInterno, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, ""), strFotoPC)
                End Select

            Catch ex As Exception
            End Try

            rpt.SetParameterValue("p_ruta_img_pope", strFotoPC)

            Dim strRegistroReniec() As String = objEnt.ReniecData.Split("|")
            If strRegistroReniec.Length = 1 Then
                rpt.SetParameterValue("p_rnc_dni", "")
                rpt.SetParameterValue("p_rnc_ape_pat", "")
                rpt.SetParameterValue("p_rnc_ape_mat", "")
                rpt.SetParameterValue("p_rnc_nom", "")
                rpt.SetParameterValue("p_rnc_fec_nac", "")
                rpt.SetParameterValue("p_rnc_sexo", "")
                rpt.SetParameterValue("p_rnc_est_civil", "")
                rpt.SetParameterValue("p_rnc_padre", "")
                rpt.SetParameterValue("p_rnc_madre", "")
                rpt.SetParameterValue("p_rnc_grad_ins", "")
                rpt.SetParameterValue("p_rnc_talla", "")
                rpt.SetParameterValue("p_rnc_ubi_nac", "")
                rpt.SetParameterValue("p_rnc_resticc", "")
                rpt.SetParameterValue("p_rnc_fech_valid", Legolas.Components.FechaHora.FechaDate(objEnt.FechaValidacion, True))
                rpt.SetParameterValue("p_rnc_ubi", "")
                rpt.SetParameterValue("p_rnc_dir", "")
                rpt.SetParameterValue("p_rnc_tip_bus", If(objEnt.ComparacionID = 1, "DNI", If(objEnt.ComparacionID = 1, "NOMBRE PRINCIPAL", "")))
                rpt.SetParameterValue("p_rnc_obvs", objEnt.Observaciones)
                rpt.SetParameterValue("p_rnc_estado", "NO ENCONTRADO")
            Else
                rpt.SetParameterValue("p_rnc_dni", strRegistroReniec(0) & " - " & strRegistroReniec(1))
                rpt.SetParameterValue("p_rnc_ape_pat", strRegistroReniec(2))
                rpt.SetParameterValue("p_rnc_ape_mat", strRegistroReniec(3))
                rpt.SetParameterValue("p_rnc_nom", strRegistroReniec(5))
                rpt.SetParameterValue("p_rnc_fec_nac", If(strRegistroReniec(7) = "", "NR", strRegistroReniec(7)))
                rpt.SetParameterValue("p_rnc_sexo", If(UCase(strRegistroReniec(6)) = "MAS", "M", "F"))
                rpt.SetParameterValue("p_rnc_est_civil", If(strRegistroReniec(9) = "", "NR", strRegistroReniec(9)))
                rpt.SetParameterValue("p_rnc_padre", If(strRegistroReniec(12) = "", "NR", strRegistroReniec(12)))
                rpt.SetParameterValue("p_rnc_madre", If(strRegistroReniec(13) = "", "NR", strRegistroReniec(13)))
                rpt.SetParameterValue("p_rnc_grad_ins", If(strRegistroReniec(14) = "", "NR", strRegistroReniec(14)))
                rpt.SetParameterValue("p_rnc_talla", If(strRegistroReniec(15) = "", "NR", strRegistroReniec(15)))
                rpt.SetParameterValue("p_rnc_ubi_nac", If(strRegistroReniec(8) = "", "NR", strRegistroReniec(8)))
                rpt.SetParameterValue("p_rnc_resticc", If(Trim(strRegistroReniec(16)) = "", "NR", Trim(strRegistroReniec(16))))
                rpt.SetParameterValue("p_rnc_fech_valid", Legolas.Components.FechaHora.FechaDate(objEnt.FechaValidacion, True))
                rpt.SetParameterValue("p_rnc_ubi", If(strRegistroReniec(10) = "", "NR", strRegistroReniec(10)))
                rpt.SetParameterValue("p_rnc_dir", If(strRegistroReniec(11) = "", "NR", strRegistroReniec(11)))
                rpt.SetParameterValue("p_rnc_tip_bus", If(objEnt.ComparacionID = 1, "DNI", "NOMBRE PRINCIPAL"))
                rpt.SetParameterValue("p_rnc_obvs", objEnt.Observaciones)
                rpt.SetParameterValue("p_rnc_estado", If(objEnt.TipoBusquedaID = 1, "VALIDADO", If(objEnt.TipoBusquedaID = 2, "OBSERVADO", "NO ENCONTRADO")))
            End If

            Try
                strFotoRncPC = Legolas.Configuration.Path.PathTemp & Now.Millisecond & "rncPC.tmp"

                Select Case intIDTipoLocal
                    Case 2 'region
                        Legolas.Components.Archivo.FileCreateByte((New Bussines.Globall.ArchivoDigital).getArchivoDigitalByte_Region(entRnc.FotoReniec, Type.Enumeracion.ArchivoDigital.TipoImagen.Reniec, ""), strFotoRncPC)
                    Case Else
                        'sede, penal 
                        Legolas.Components.Archivo.FileCreateByte((New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(entRnc.FotoReniec, Type.Enumeracion.ArchivoDigital.TipoImagen.Reniec, ""), strFotoRncPC)
                End Select

            Catch ex As Exception

            End Try

            rpt.SetParameterValue("p_ruta_img_reniec", strFotoRncPC)
            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)

            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub
        Private Sub Reporte_ListaInternosValidadosReniec()

            Dim objBss As New Bussines.Reporte.Registro
            rpt = New ReportDocument
            rpt.Load(Me.ReportePath & "rpt_rnc_lista_validacion.rpt")

            rpt.DataSourceConnections(0).SetConnection( _
            Legolas.Configuration.Data.CNServer, _
            Legolas.Configuration.Data.CNDataBase, _
            Legolas.Configuration.Data.CNUser, _
            Legolas.Configuration.Data.CNPass)

            rpt.SetParameterValue("@accion", "lst")
            rpt.SetParameterValue("@opcion", "lst_rpt_int_validados_rnc")
            rpt.SetParameterValue("@int_id", -1)
            rpt.SetParameterValue("@int_ing_id", -1)
            rpt.SetParameterValue("@pen_id", Me._Filtro.PenalID)
            rpt.SetParameterValue("@int_exp_id", -1)
            rpt.SetParameterValue("@int_sen_id", -1)
            rpt.SetParameterValue("@int_del_id", -1)
            rpt.SetParameterValue("@nac_id", -1)
            rpt.SetParameterValue("@cuadro", -1)
            rpt.SetParameterValue("@fec_ini", Me._Filtro.FechaInicio)
            rpt.SetParameterValue("@fec_fin", Me._Filtro.FechaFin)
            rpt.SetParameterValue("@_fecha", 0)
            rpt.SetParameterValue("@reg_id", Me._Filtro.RegionID)
            rpt.SetParameterValue("@tip_band_id", -1)
            rpt.SetParameterValue("@ban_id", -1)
            rpt.SetParameterValue("@int_rnc_id", -1)
            'rpt.SetParameterValue("@strNomAsoc", "")

            rpt.SetParameterValue("p_fec_ini", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaInicio))
            rpt.SetParameterValue("p_fec_fin", Legolas.Components.FechaHora.FechaString(Me._Filtro.FechaFinOri))

            rpt.SetParameterValue("p_version", Legolas.Configuration.Aplication.VersionString)
            rpt.SetParameterValue("p_mac", Legolas.Components.PC.GetMAC)
            rpt.SetParameterValue("p_acta", Me.ReporteActa)
            rpt.SetParameterValue("p_usuario", Legolas.Configuration.Usuario.ApellidosyNombre)
            rpt.SetParameterValue("p_fecha_hora", Me.FechayHora)
            Me.CrystalReportViewer1.ReportSource = rpt

        End Sub

        Private Function ListarImagen(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String) As System.Drawing.Image

            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central

            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            'validar la ruta
            If NameFile.Trim = "" Then
                Return objImagen
            End If

            If ArchivoDigitalID < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
            Else
                'si hay foto
                Dim objWS As New APPWebService.ws_foto.PopeLocal
                objWS.Url = APPWebService.PathURL.WSPopeLocal

                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim strFotoNameExtension As String = NameFile

                Try
                    objImagenByte = objWS.LeerImageJpg(strFotoNameExtension, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)
                Catch ex As Exception
                    objImagenByte = Nothing
                End Try

                If objImagenByte Is Nothing Then
                    Select Case intTipoLocal
                        Case 3, 2
                            objImagen = My.Resources.fotografia_por_transferir
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select
                Else
                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                End If
            End If
            Return objImagen
        End Function
        'Private Function ListarImagen_v2(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, PathServerFotoInt As String) As System.Drawing.Image
        '    Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
        '    Dim intTipoLocal As Integer = 3 'sede central
        '    'If Me._CheckImagen = False Then
        '    '    Return objImagen
        '    'End If
        '    Try
        '        Dim objBss As New Bussines.Sistema.Instalacion
        '        intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
        '    Catch ex As Exception
        '        intTipoLocal = -1
        '    End Try
        '    'validar la ruta
        '    If NameFile.Trim = "" Then
        '        Return objImagen
        '    End If
        '    If ArchivoDigitalID < 1 Then
        '        'no hay foto
        '        objImagen = My.Resources.sin_fotografia

        '    Else
        '        'si hay foto
        '        Dim objWS As New APPWebService.ws_foto.PopeLocal
        '        objWS.Url = APPWebService.PathURL.WSPopeLocal


        '        Dim objImagenByte As Byte()
        '        Dim objImagenStream As New IO.MemoryStream

        '        Dim strFotoNameExtension As String = NameFile

        '        Try
        '            objImagenByte = objWS.LeerArchivoByte(1, NameFile & ".JPG", PathServerFotoInt)
        '            objWS.Dispose()
        '            objWS = Nothing

        '        Catch ex As Exception
        '            objImagenByte = Nothing
        '        End Try

        '        If objImagenByte Is Nothing Then
        '            Select Case intTipoLocal
        '                Case 3, 2
        '                    objImagen = My.Resources.fotografia_por_transferir
        '                Case Else
        '                    objImagen = My.Resources.fotografia_eliminada
        '            End Select
        '        Else
        '            objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
        '            Try
        '                objImagen = Image.FromStream(objImagenStream)
        '            Catch ex As Exception
        '                objImagen = My.Resources.nspm_fotografia
        '            End Try

        '        End If

        '    End If

        '    Return objImagen
        'End Function

        'Private Function ListarImagen2(ByVal ArchivoDigitalID As Integer) As System.Drawing.Image
        '    Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
        '    Dim intTipoLocal As Integer = 3 'sede central

        '    Try
        '        Dim objBss As New Bussines.Sistema.Instalacion
        '        intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
        '    Catch ex As Exception
        '        intTipoLocal = -1
        '    End Try

        '    If ArchivoDigitalID < 1 Then
        '        objImagen = My.Resources.sin_fotografia
        '    Else
        '        Dim objWS As New APPWebService.ws_foto.PopeLocal
        '        objWS.Timeout = -1
        '        objWS.Url = APPWebService.PathURL.WSPopeLocal

        '        Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital

        '        Dim objImagenByte As Byte()
        '        Dim objImagenStream As New IO.MemoryStream

        '        Try
        '            r = objWS.ListarArchivoDigital(ArchivoDigitalID)
        '            objImagenByte = r.Resultado.ArchivoByte
        '        Catch ex As Exception
        '            objImagenByte = Nothing
        '        End Try

        '        If objImagenByte Is Nothing Then

        '            Select Case intTipoLocal
        '                Case 3, 2
        '                    objImagen = My.Resources.fotografia_por_transferir
        '                Case Else
        '                    objImagen = My.Resources.fotografia_eliminada
        '            End Select
        '        Else
        '            objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)

        '            Try
        '                objImagen = Image.FromStream(objImagenStream)
        '            Catch ex As Exception
        '                objImagen = My.Resources.nspm_fotografia
        '            End Try
        '        End If
        '    End If

        '    Return objImagen

        'End Function
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

        Private Sub ReporteCrystal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

            rpt.Dispose()
            CrystalReportViewer1.Dispose()

            Try
                Legolas.Components.Archivo.FileDelete(strFotoPC)
                Legolas.Components.Archivo.FileDelete(strFotoRncPC)
            Catch ex As Exception

            End Try

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
