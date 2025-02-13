Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Namespace Transferencia
    Public Class ArchivoInfo2
        Private objEnt As Entity.Transferencia.ArchivoInfo2 = Nothing
        Private objEntCol As Entity.Transferencia.ArchivoInfo2Col = Nothing
        'web service
        Private objWs As APPWebService.ws_pope_sede_monitoreo.Monitoreo
        Private strURLWs As String = APPWebService.PathURL.Monitoreo
#Region "WebService"

        Public Function SetearArchivoError_ws(Codigo As Integer, NomArchivo As String, ByRef strMensajeOut As String) As Integer

            Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)
            Return Data.Transferencia.ArchivoInfo2.TRA_ArchivoTransfer.Grabar(strCNBD_Monitoreo, "upd", "upd_setea_error", Codigo,
                                                                              NomArchivo, strMensajeOut)

        End Function
        Public Function DescargarArchivoZip_ws(Codigo As Integer, NomArchivo As String, ByRef sms As String) As Byte()

            objWs = New APPWebService.ws_pope_sede_monitoreo.Monitoreo
            objWs.Url = strURLWs

            Try
                objWs.FechaActual()
            Catch ex As Exception
                sms = "Ocurrio un error interno al invocar el servicio de Resumen de Transferencia" & ex.Message
                Return Nothing
            End Try
            Return objWs.DescargarZipArchivoTransfer(Codigo, NomArchivo)
        End Function

        Public Function ListarRegion_ws(blnVerSede As Boolean, ByVal objEntReg As Entity.Transferencia.ArchivoInfoRegion,
                                        ByRef strMensajeOut As String) As Entity.Transferencia.ArchivoInfoRegionCol


            Dim objEntRegCol As New Entity.Transferencia.ArchivoInfoRegionCol
            Dim dts As DataSet
            Dim dt As DataTable

            If blnVerSede = True Then

                Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)
                dts = Data.Transferencia.ArchivoInfo2.TRA_ArchivoTransfer.Listar(strCNBD_Monitoreo, "lst", "lst_region", -1, objEntReg.RegionID, -1, -1, -1, strMensajeOut)
                dt = dts.Tables(0)
            Else

                objWs = New APPWebService.ws_pope_sede_monitoreo.Monitoreo
                objWs.Url = strURLWs

                Try
                    objWs.FechaActual()
                Catch ex As Exception
                    strMensajeOut = "Ocurrio un error interno al invocar el servicio de Resumen de Transferencia" & ex.Message
                    Return Nothing
                End Try

                dt = objWs.ListaPendiente_Region(objEntReg.RegionID)
            End If

            If dt.Rows.Count > 0 Then
                For Each d As DataRow In dt.Rows
                    Dim objEntRegion As New Entity.Transferencia.ArchivoInfoRegion
                    With objEntRegion
                        '.Codigo = sqlDr("tra_arc_inf_id").ToString
                        .RegionID = d.Item("reg_id").ToString
                        .RegionNombre = d.Item("reg_nom").ToString
                        .Licencia = d.Item("lic_id").ToString
                        .CantidadTransferencias = d.Item("cant").ToString
                        .UltimaFechaDescarga = d.Item("ult_fec_desc").ToString
                        .CantErrorProcesadoSede = d.Item("cant_error_proc").ToString
                    End With
                    objEntRegCol.Add(objEntRegion)
                Next
            End If
            Return objEntRegCol
        End Function
        Public Function Listar_ws(blnVerSede As Boolean, ByVal RegionID As Integer, ByVal PenalID As Integer, TipoLicencia As Integer,
                                  ByRef strMensajeOut As String) As Entity.Transferencia.ArchivoInfo2Col

            Dim dts As DataSet
            Dim objDT As New DataTable

            If blnVerSede = True Then

                Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)
                dts = Data.Transferencia.ArchivoInfo2.TRA_ArchivoTransfer.Listar(strCNBD_Monitoreo, "lst", "lst_control", -1, RegionID, PenalID, -1, -1, strMensajeOut)
                objDT = dts.Tables(0)
            Else

                objWs = New APPWebService.ws_pope_sede_monitoreo.Monitoreo
                objWs.Timeout = -1
                objWs.Url = strURLWs

                Try
                    objWs.FechaActual()
                Catch ex As Exception
                    strMensajeOut = "Ocurrio un error interno al invocar el servicio de Resumen de Transferencia" & ex.Message
                    Return Nothing
                End Try

                objDT = objWs.ListaPendiente_Detalle(RegionID, PenalID)
            End If

            objEntCol = New Entity.Transferencia.ArchivoInfo2Col
            If objDT.Rows.Count > 0 Then
                For Each d As DataRow In objDT.Rows
                    objEnt = New Entity.Transferencia.ArchivoInfo2
                    With objEnt
                        .Region = d.Item("reg_id").ToString
                        .RegionNombre = d.Item("reg_nom").ToString
                        .Penal = d.Item("pen_id").ToString
                        .PenalNombre = d.Item("pen_nom").ToString
                        .FechaInstalacion = d.Item("pen_fec_ins").ToString
                        .PenalCapacidad = d.Item("pen_cap").ToString
                        .PenalEstadoInternet = d.Item("pen_est_int").ToString
                        .ArchivoNumero = d.Item("tra_arc_inf_num").ToString
                        .ArchivoNombre = d.Item("tra_arc_inf_nom").ToString
                        ' .ArchivoFecha = d.Item("tra_arc_inf_fec").ToString
                        .ArchivoFechaAnteriorProcSede = d.Item("tra_arc_fec_ant_proc_sed").ToString
                        .TotPendDescargaRegion = d.Item("pend_desc_reg").ToString
                        '.ArchivoHora = sqlDr("tra_arc_inf_hor").ToString'
                        .TotalInternos = d.Item("tra_arc_inf_tot_int").ToString
                        .TotalHombres = d.Item("tra_arc_inf_tot_hom").ToString
                        .TotalMujeres = d.Item("tra_arc_inf_tot_muj").ToString
                        .TotalPro = d.Item("tra_arc_inf_tot_pro").ToString
                        .TotalSen = d.Item("tra_arc_inf_tot_sen").ToString
                        .VerApp = d.Item("tra_arc_inf_ver_app").ToString
                        .VerBD = d.Item("tra_arc_inf_ver_bd").ToString
                        .Licencia = d.Item("tra_arc_inf_lic_id").ToString
                        .CantErrorProcesadoSede = d.Item("tra_arc_error_procesa_sede").ToString
                        .PenalBloqueadoTransfer = d.Item("penal_bloqueado").ToString

                        .UltimaFechaDownloadRegion = d.Item("ult_fec_down_reg").ToString
                        .UltimaFechaProcesoRegion = d.Item("ult_fec_proc_reg").ToString
                        .UltimaFechaProcesoSede = d.Item("ult_fec_proc_sed").ToString
                        .UltimaFechaUploadSede = d.Item("ult_fec_upld_sed").ToString
                    End With
                    objEntCol.Add(objEnt)
                Next
            End If

            Return objEntCol
        End Function
        Public Function ListarArchivoTransferencia_ws(blnVerSede As Boolean, intCodigo As Integer, intIDRegion As Integer, intIDPenal As Integer,
                                                      intAnioDirectorio As Integer, intMesDirectorio As Integer, ByRef strMensajeOut As String) As Entity.Transferencia.ArchivoInfo2Col

            Dim dts As DataSet
            Dim dt As DataTable

            If blnVerSede = True Then

                Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)
                dts = Data.Transferencia.ArchivoInfo2.TRA_ArchivoTransfer.Listar(strCNBD_Monitoreo, "lst", "lst_archivo_transferencia", intCodigo, intIDRegion, intIDPenal,
                                                                                intAnioDirectorio, intMesDirectorio, strMensajeOut)
                dt = dts.Tables(0)
            Else

                objWs = New APPWebService.ws_pope_sede_monitoreo.Monitoreo
                objWs.Url = strURLWs

                Try
                    objWs.FechaActual()
                Catch ex As Exception
                    strMensajeOut = "Ocurrio un error interno al invocar el servicio de Resumen de Transferencia" & ex.Message
                    Return Nothing
                End Try

                dt = objWs.ListaArchivoTransferencia(intCodigo, intIDRegion, intIDPenal, intAnioDirectorio, intMesDirectorio)

            End If

            objEntCol = New Entity.Transferencia.ArchivoInfo2Col
            If dt.Rows.Count > 0 Then
                For Each d As DataRow In dt.Rows
                    objEnt = New Entity.Transferencia.ArchivoInfo2
                    With objEnt
                        .Codigo = d.Item("tra_arc_inf_id").ToString
                        .Region = d.Item("reg_id").ToString
                        .Penal = d.Item("pen_id").ToString
                        .ArchivoFecha = d.Item("tra_arc_inf_fec").ToString
                        .ArchivoNumero = d.Item("tra_arc_inf_num").ToString
                        .ArchivoNombre = d.Item("tra_arc_inf_nom").ToString
                        .ArchivoHora = d.Item("tra_arc_inf_hor").ToString
                        .TotalInternos = d.Item("tra_arc_inf_tot_int").ToString
                        .TotalHombres = d.Item("tra_arc_inf_tot_hom").ToString
                        .TotalMujeres = d.Item("tra_arc_inf_tot_muj").ToString
                        .TotalPro = d.Item("tra_arc_inf_tot_pro").ToString
                        .TotalSen = d.Item("tra_arc_inf_tot_sen").ToString
                        .VerApp = d.Item("tra_arc_inf_ver_app").ToString
                        .VerBD = d.Item("tra_arc_inf_ver_bd").ToString
                        .Licencia = d.Item("tra_arc_inf_lic_id").ToString
                        .TotalExpedientes = d.Item("tra_rs_tot_exp").ToString
                        .TotalDelitos = d.Item("tra_rs_tot_delit").ToString
                        .TotalAgraviados = d.Item("tra_rs_tot_agrav").ToString
                        .ErrorProcesoEnSede = d.Item("error_proc_sede").ToString

                        .FechaDesde = d.Item("tra_fec_dsd").ToString
                        .FechaHasta = d.Item("tra_fec_hst").ToString
                        .TamanioXmlEnBytes = d.Item("tra_arc_xml_tam").ToString
                        .TamanioZipEnBytes = d.Item("tra_arc_zip_tam").ToString

                        .FechaSubidaSede = d.Item("tra_fec_sub_sed").ToString
                        .FechaProcesaSede = d.Item("tra_fec_proc_sed").ToString
                        .FechaDescargaRegion = d.Item("tra_fec_desc_reg").ToString
                        .FechaProcesaRegion = d.Item("tra_fec_proc_reg").ToString

                        .PathArchivoServer = d.Item("tra_arc_path").ToString
                        .TipoPaquete = d.Item("tra_grp_paq").ToString
                    End With
                    objEntCol.Add(objEnt)
                Next
            End If
            Return objEntCol
        End Function

        Public Function EliminarArchivo(intCodigo As Integer, strNomArchivo As String, intGrupoPaquete As Short, ByRef strMensajeOut As String) As Integer

            Dim blnSeElimino As Boolean = False
            objWs = New APPWebService.ws_pope_sede_monitoreo.Monitoreo
            objWs.Url = strURLWs

            Try
                objWs.FechaActual()
            Catch ex As Exception
                strMensajeOut = "Ocurrio un error interno al invocar el servicio de Resumen de Transferencia" & ex.Message
                Return Nothing
            End Try

            blnSeElimino = objWs.EliminarArchivoTransfer(intCodigo, strNomArchivo, intGrupoPaquete)

            If blnSeElimino = True Then

                Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)

                Return Data.Transferencia.ArchivoInfo2.TRA_ArchivoTransfer.Eliminar(strCNBD_Monitoreo, "del", "del_eliminar_x_tipo_paquete",
                                                                intCodigo, strNomArchivo, intGrupoPaquete, strMensajeOut)
            End If

        End Function

        Public Function EliminarArchivo(intIDRegion As Short, intIDPenal As Short, intCodigo As Integer, strNomArchivo As String, intArchivoNumero As Integer,
                                        intGrupoPaquete As Short,
                                        objQuery As Dictionary(Of Short, String), ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim blnSeElimino As Boolean = False
            Dim intRetorno As Integer = -1
            Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)

            objWs = New APPWebService.ws_pope_sede_monitoreo.Monitoreo
            objWs.Url = strURLWs

            Try
                objWs.FechaActual()
            Catch ex As Exception
                strMensajeOut = "Ocurrio un error interno al invocar el servicio de Resumen de Transferencia" & ex.Message
                Return value
            End Try

            blnSeElimino = objWs.EliminarArchivoTransfer(intCodigo, strNomArchivo, intGrupoPaquete)

            If blnSeElimino = True Then

                intRetorno = Data.Transferencia.ArchivoInfo2.TRA_ArchivoTransfer.Eliminar(strCNBD_Monitoreo, "del", "del_eliminar_x_tipo_paquete",
                                                                intCodigo, strNomArchivo, intGrupoPaquete, strMensajeOut)

                Dim objBss As New Bussines.Transferencia.BandejaQuery
                value = objBss.Grabar(strCNBD_Monitoreo, intIDRegion, intIDPenal, intCodigo, strNomArchivo, intArchivoNumero, objQuery, strMensajeOut)

            End If

            Return value

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Region As Integer, ByVal Penal As Integer, ByRef strMensaje As String) As Entity.Transferencia.ArchivoInfo2Col

            Dim bssInstall As New Bussines.Sistema.Instalacion
            Dim intTipoLicencia As Integer = -1
            objEntCol = New Entity.Transferencia.ArchivoInfo2Col

            intTipoLicencia = bssInstall.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp()).Tipo

            Select Case intTipoLicencia

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede 'si es sede
                    'Return Listar_ws(False, Region, Penal, 3, "")
                    'conectarse a la bd local de tranferencia
                    Return Nothing

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                    Type.Enumeracion.Licencia.enmTipoLicencia.RegionProvincia
                    ''si es sede o region se conecta por ws a la bd transferencia de la sede

                    objEntCol = Listar_ws(False, Region, Penal, 2, strMensaje)

                Case Else

                    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Dim sqlDr As SqlDataReader = Data.Transferencia.ArchivoInfo2.Listar(sqlCon, "lst", "lst_control", -1, Region, Penal)
                    Try
                        objEntCol = New Entity.Transferencia.ArchivoInfo2Col
                        If sqlDr.HasRows Then
                            While sqlDr.Read
                                objEnt = New Entity.Transferencia.ArchivoInfo2
                                With objEnt
                                    .Region = sqlDr("reg_id").ToString
                                    .RegionNombre = sqlDr("reg_nom").ToString
                                    .Penal = sqlDr("pen_id").ToString
                                    .PenalNombre = sqlDr("pen_nom").ToString
                                    .FechaInstalacion = sqlDr("pen_fec_ins").ToString
                                    .PenalCapacidad = sqlDr("pen_cap").ToString
                                    .PenalEstadoInternet = sqlDr("pen_est_int").ToString
                                    .ArchivoNumero = sqlDr("tra_arc_inf_num").ToString
                                    .ArchivoNombre = sqlDr("tra_arc_inf_nom").ToString
                                    .UltimaFechaUploadSede = sqlDr("ult_fec_upld_sed").ToString

                                    .TotalInternos = sqlDr("tra_arc_inf_tot_int").ToString
                                    .TotalHombres = sqlDr("tra_arc_inf_tot_hom").ToString
                                    .TotalMujeres = sqlDr("tra_arc_inf_tot_muj").ToString
                                    .TotalPro = sqlDr("tra_arc_inf_tot_pro").ToString
                                    .TotalSen = sqlDr("tra_arc_inf_tot_sen").ToString
                                    .VerApp = sqlDr("tra_arc_inf_ver_app").ToString
                                    .VerBD = sqlDr("tra_arc_inf_ver_bd").ToString
                                    .Licencia = sqlDr("tra_arc_inf_lic_id").ToString
                                End With
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    Catch ex As Exception
                        Throw New Exception(ex.ToString)
                    Finally
                        sqlDr.Dispose()
                        sqlDr.Close()
                        sqlDr = Nothing
                        sqlCon.Dispose()
                        sqlCon.Close()
                        sqlCon = Nothing
                    End Try
            End Select
            
            Return objEntCol
        End Function
#End Region
#Region "Grabar"
        Public Function GrabarBloqueoPenalTranfer(BloquearTransferencia As Short, PenalID As Integer, RegionID As Integer, ByRef strMensajeOut As String) As Boolean
            Dim value As Boolean = False

            Dim strCNBD_Monitoreo As String = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_monitoreo", -1)
            Return Data.Transferencia.Monitoreo.Grabar(strCNBD_Monitoreo, "upd", "upd_bloq_transferencia", RegionID, PenalID,
                                                                             BloquearTransferencia, strMensajeOut)

            Return value
        End Function
#End Region

    End Class
End Namespace