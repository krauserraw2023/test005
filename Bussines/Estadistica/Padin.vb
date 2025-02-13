Imports System.Data
Imports System.Data.SqlClient
Imports Entity

Namespace Estadistica
    Public Class Padin
        Private objEnt As Entity.Estadistica.Padin = Nothing
        Private objEntCol As Entity.Estadistica.PadinCol = Nothing
#Region "Validar"
        Public Function ValidarEstadoTransferencia(ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = False
            Dim intReg As Integer = 0

            intReg = Data.Estadistica.Padin.ListarOutput("val", "val_estado_transferencia", -1, RegionID, PenalID, -1)

            If intReg > 0 Then
                If intReg < 3 Then
                    Dim strMensaje As String = ""
                    strMensaje = "No se puede generar un nuevo padin. Existe un padin" + Chr(13) +
                                 "en proceso, que no ha sido enviado Transferido."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Else
                    value = True
                End If
            Else
                value = True
            End If

            Return value

        End Function
        Public Function ValidarEstadoPadin(ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = False
            Dim intEstado As Integer = 0
            Dim strMensaje As String = ""

            intEstado = Data.Estadistica.Padin.ListarOutput("val", "val_estado_transferencia", -1, RegionID, PenalID, -1)

            Select Case intEstado

                Case Type.Enumeracion.Padin.EnumPadinEstado.Procesado
                    strMensaje = "No se puede generar un nuevo padin. Existe un padin" + Chr(13) +
                                 "en proceso, que no ha sido enviado Transferido."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    Return value

                Case Type.Enumeracion.Padin.EnumPadinEstado.EnviadoRegion, Type.Enumeracion.Padin.EnumPadinEstado.RecepcionRegion

                    strMensaje = "No se puede generar un nuevo padin. Existe un padin" + Chr(13) +
                                 "en estado [Enviado a Region/Recepcionado Region], debe esperar a la region que anule o confirme el Padin."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    Return value

            End Select

            value = True

            Return value

        End Function
        Public Function ValidarMaximoPadin(ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            Dim intReg As Integer = 0

            intReg = Data.Estadistica.Padin.ListarOutput("val", "max_padin", -1, RegionID, PenalID, -1)

            Return intReg

        End Function
#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer) As Entity.Estadistica.Padin

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_mant", _
                                                                       Codigo, -1, -1, -1, -1, -1, -1, 0, 0, 0)
            objEnt = New Entity.Estadistica.Padin
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .Numero = sqlDr("pad_num_cor").ToString
                            .Anio = sqlDr("pad_anio").ToString
                            .Mes = sqlDr("pad_mes").ToString
                            .Fecha = sqlDr("pad_fec").ToString
                            .FechaProceso = sqlDr("pad_fec_pro").ToString
                            .FechaEnvio = sqlDr("pad_fec_env").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Estado = sqlDr("est_id").ToString
                            .EstadoNombre = sqlDr("est_nom").ToString
                            .Observacion = sqlDr("pad_obs").ToString
                            .VersionReporte = sqlDr("n_ver_rpt").ToString
                        End With
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
            Return objEnt
        End Function

        Public Function Listar(objEntFiltro As Entity.Estadistica.Padin) As Entity.Estadistica.Padin

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_mant", _
                                                                       objEntFiltro)
            objEnt = New Entity.Estadistica.Padin
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .Numero = sqlDr("pad_num_cor").ToString
                            .Anio = sqlDr("pad_anio").ToString
                            .Mes = sqlDr("pad_mes").ToString
                            .Fecha = sqlDr("pad_fec").ToString
                            .FechaProceso = sqlDr("pad_fec_pro").ToString
                            .FechaEnvio = sqlDr("pad_fec_env").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Estado = sqlDr("est_id").ToString
                            .EstadoNombre = sqlDr("est_nom").ToString
                            .Observacion = sqlDr("pad_obs").ToString
                            .ObservacionAnulacion = sqlDr("pad_obs_anu").ToString
                            '/*transferencia*/
                            .TransferIDRow = sqlDr("_rowid").ToString
                            .TransferIDRegion = sqlDr("_regid").ToString
                            .TransferIDPenal = sqlDr("_penid").ToString
                        End With
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
            Return objEnt
        End Function

        Public Function Listar(ByVal Codigo As Integer, ByVal RegionID As Integer, ByVal PenalID As Integer, _
                               ByVal Anio As Integer, ByVal Mes As Integer, ByVal Estado As Integer, FechaCorte As Long) As Entity.Estadistica.PadinCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_grilla", Codigo, _
            RegionID, PenalID, -1, Anio, Mes, Estado, 0, FechaCorte, 0)

            Try
                objEntCol = New Entity.Estadistica.PadinCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.Padin
                        With objEnt
                            .Codigo = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Numero = sqlDr("pad_num_cor").ToString
                            .Anio = sqlDr("pad_anio").ToString
                            .Mes = sqlDr("pad_mes").ToString
                            .MesNombre = Legolas.Components.FechaHora.MesNombre(.Mes)
                            .Fecha = sqlDr("pad_fec").ToString
                            .FechaProceso = sqlDr("pad_fec_pro").ToString
                            .FechaEnvio = sqlDr("pad_fec_env").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .Estado = sqlDr("est_id").ToString
                            .EstadoNombre = sqlDr("est_nom").ToString
                            .Observacion = sqlDr("pad_obs").ToString
                            .TieneObs = sqlDr("obs").ToString
                            .Version = sqlDr("n_pad_ver").ToString
                            .VersionReporte = sqlDr("n_ver_rpt").ToString
                            .UsuarioCreacion = sqlDr("UsuarioCreacion").ToString
                            .UsuarioModific = sqlDr("UsuarioModific").ToString
                            '/*otros*/

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
            Return objEntCol
        End Function

        Public Function ListarGrillaPadin(objEntFiltro As Entity.Estadistica.Padin) As Entity.Estadistica.PadinCol

            objEntCol = New Entity.Estadistica.PadinCol

            objEntCol = ListarGrilla(objEntFiltro)

            If ListarEstadoPadin_SedeWs(objEntCol) = True Then
                objEntCol = ListarGrilla(objEntFiltro)
            End If

            Return objEntCol
        End Function

        Public Function ListarGrilla(objEntFiltro As Entity.Estadistica.Padin) As Entity.Estadistica.PadinCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            Try
                objEntCol = New Entity.Estadistica.PadinCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.Padin
                        With objEnt
                            .Codigo = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Numero = sqlDr("pad_num_cor").ToString
                            .Anio = sqlDr("pad_anio").ToString
                            .Mes = sqlDr("pad_mes").ToString
                            .MesNombre = Legolas.Components.FechaHora.MesNombre(.Mes)
                            .Fecha = sqlDr("pad_fec").ToString
                            .FechaCorte = sqlDr("pad_fec_cor").ToString
                            .FechaProceso = sqlDr("pad_fec_pro").ToString
                            .FechaEnvio = sqlDr("pad_fec_env").ToString
                            .FechaRecepcion = sqlDr("pad_fec_rec").ToString
                            .Estado = sqlDr("est_id").ToString
                            .EstadoNombre = sqlDr("est_nom").ToString
                            .FechaRegionRpta = sqlDr("pad_reg_fec_rpt").ToString
                            .UsuarioResponsableRegion = sqlDr("pad_res_reg_usu_ape_nom").ToString
                            .Observacion = sqlDr("pad_obs").ToString
                            .TieneObs = sqlDr("obs").ToString
                            .Version = sqlDr("n_pad_ver").ToString
                            .UsuarioCreacion = sqlDr("UsuarioCreacion").ToString
                            .UsuarioModific = sqlDr("UsuarioModific").ToString
                            '/*transferencia*/
                            .TransferIDRow = sqlDr("_rowid").ToString
                            .TransferIDRegion = sqlDr("_regid").ToString
                            .TransferIDPenal = sqlDr("_penid").ToString
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

            Return objEntCol
        End Function
#End Region

#Region "Listar_Datos_Complementarios"
        Public Function ListarPoblacionIngresos_tmp(ByVal RegionID As Integer, ByVal PenalID As Integer, ByVal Estado As Integer, _
                                   ByVal FechaIni As Long, ByVal FechaFin As Long, ByVal FechaProceso As Long) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_ingresos", _
                                                                       -1, RegionID, PenalID, -1, -1, -1, Estado, FechaIni, FechaFin, FechaProceso)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle
                      
                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '.NumeroHijos = sqlDr("int_hij_men").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .TrasladoId = sqlDr("int_trs_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                        End With

                        objEntCol.Add(objEnt)
                        If objEnt.InternoID = 278661 Then
                            MsgBox(objEnt.InternoID)
                        End If

                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing

            End Try
            Return objEntCol
        End Function

        Public Function ListarPoblacionEgresos_tmp(ByVal RegionID As Integer, ByVal PenalID As Integer, ByVal Estado As Integer, _
                                      ByVal FechaIni As Long, ByVal FechaFin As Long, ByVal FechaProceso As Long) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_egresos", _
                                                                       -1, RegionID, PenalID, -1, -1, -1, Estado, FechaIni, FechaFin, FechaProceso)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '.NumeroHijos = sqlDr("int_hij_men").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .TrasladoId = sqlDr("int_trs_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .EgresoTrasladoId = sqlDr("int_trs_id_egre").ToString
                            .ExpedienteLibertarID = sqlDr("int_exp_id_egre").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
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

            End Try
            Return objEntCol
        End Function

        Public Function ListarPoblacionActivos_tmp(ByVal RegionID As Integer, ByVal PenalID As Integer, ByVal Estado As Integer, _
                                     ByVal FechaIni As Long, ByVal FechaFin As Long, ByVal FechaProceso As Long) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_activa", _
                                                                       -1, RegionID, PenalID, -1, -1, -1, Estado, FechaIni, FechaFin, FechaProceso)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '.NumeroHijos = sqlDr("int_hij_men").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            '.TrasladoId = sqlDr("int_trs_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
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

            End Try
            Return objEntCol
        End Function

        Public Function ListarPoblacionActivos_tmp_v5(objEntPadin As Entity.Estadistica.Padin) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_activa_v5", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
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

            End Try
            Return objEntCol
        End Function

        Public Function ListarPoblacionActivos_tmp_v6(objEntPadin As Entity.Estadistica.Padin) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_activa_v6", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("int_lib").ToString
                            .InternoFolio = sqlDr("int_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
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

            End Try
            Return objEntCol
        End Function

        'Public Function ListarPoblacionIngresos_tmp_v5(objEntPadin As Entity.Estadistica.Padin, TipoMov As Integer) As Entity.Estadistica.PadinDetalleCol

        '    Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
        '    Dim objEnt As Entity.Estadistica.PadinDetalle
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

        '    objEntPadin.TipoMovimiento = TipoMov

        '    Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_ingresos_v5", objEntPadin)
        '    'Dim dt As New DataTable
        '    'dt.Load(sqlDr)
        '    Try
        '        objEntCol = New Entity.Estadistica.PadinDetalleCol
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Estadistica.PadinDetalle

        '                With objEnt
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .InternoCodigo = sqlDr("int_cod_rp").ToString

        '                    .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

        '                    .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
        '                    .InternoPreNombres = sqlDr("int_nom").ToString
        '                    .InternoSexoID = sqlDr("sex_id").ToString
        '                    .InternoSexo = sqlDr("sex_nom").ToString
        '                    .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
        '                    .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
        '                    .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
        '                    .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
        '                    .InternoNacimientoPaisID = sqlDr("pai_id").ToString
        '                    .InternoNacimientoPais = sqlDr("pai_nom").ToString
        '                    .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
        '                    .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
        '                    .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
        '                    '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
        '                    '.NacionalidadID = sqlDr("nac_id").ToString
        '                    .InternoNacionalidad = sqlDr("nac_nom").ToString
        '                    .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
        '                    .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
        '                    .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
        '                    .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
        '                    '. .ProfesionNombre = sqlDr("pro_nom").ToString
        '                    .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
        '                    .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
        '                    .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
        '                    .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
        '                    .InternoComunidaNativa = sqlDr("com_and_nom").ToString
        '                    .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
        '                    .InternoDiscapacidad = sqlDr("dis_nom").ToString
        '                    '/*familia*/
        '                    .InternoPadre = sqlDr("pad_nom").ToString
        '                    .InternoMadre = sqlDr("mad_nom").ToString
        '                    ' .Conyugue = sqlDr("cyg_nom").ToString
        '                    '/*ubigeo*/
        '                    .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
        '                    .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
        '                    .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
        '                    .InternoDomicilio = sqlDr("int_dir_nom").ToString
        '                    '/*alias*/
        '                    .InternoAlias = sqlDr("ali_nom").ToString
        '                    '/*ingreso*/
        '                    '.IngresoNumero = sqlDr("num_ing").ToString                           
        '                    '/*penal*/
        '                    .RegionID = sqlDr("reg_id").ToString
        '                    .RegionNombre = sqlDr("reg_nom").ToString
        '                    .PenalID = sqlDr("pen_id").ToString
        '                    .PenalCodigo = sqlDr("pen_cod").ToString
        '                    .PenalNombre = sqlDr("pen_nom").ToString
        '                    .PabellonNombre = sqlDr("pab_str").ToString
        '                    '/*estado*/
        '                    .InternoEstadoID = sqlDr("int_est_id").ToString
        '                    .IngresoID = sqlDr("int_ing_id").ToString

        '                    .IDMovimiento = sqlDr("mov_id").ToString
        '                    .TipoDetalleMovimientoIng = sqlDr("tip_det_ing_mov").ToString
        '                    .IDDocumentoIngreso = 1

        '                    .PadinTipoMovimiento = sqlDr("tip_mov").ToString
        '                    .ExpedienteLibertarID = sqlDr("expLibID").ToString
        '                End With

        '                objEntCol.Add(objEnt)


        '            End While
        '        End If
        '    Catch ex As Exception
        '        Throw New Exception(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing

        '    End Try
        '    Return objEntCol
        'End Function

        Public Function ListarPoblacionIngresos_tmp_v6(objEntPadin As Entity.Estadistica.Padin, TipoMov As Integer) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_ingresos_v6", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("int_lib").ToString
                            .InternoFolio = sqlDr("int_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString

                            .IDMovimiento = sqlDr("mov_id").ToString
                            .TipoDetalleMovimientoIng = sqlDr("tip_det_ing_mov").ToString
                            .IDDocumentoIngreso = 1

                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            .ExpedienteLibertarID = sqlDr("expLibID").ToString
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

            End Try
            Return objEntCol
        End Function


        Public Function ListarPoblacionEgresos_tmp_v5(objEntPadin As Entity.Estadistica.Padin, TipoMov As Integer) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_egresos_v5", objEntPadin)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            '/*Datos del interno*/
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            '/*ingreso*/
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IDDocumentoIngreso = sqlDr("doc_id_ing").ToString
                            '/*Egreso*/
                            .IDMovimientoEgreso = sqlDr("mov_egr_id").ToString
                            .IDDocumentoEgreso = sqlDr("doc_jud_id").ToString

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

            End Try
            Return objEntCol
        End Function

        Public Function ListarPoblacionEgresos_tmp_v6(objEntPadin As Entity.Estadistica.Padin, TipoMov As Integer) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_egresos_v6", objEntPadin)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            '/*Datos del interno*/
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("int_lib").ToString
                            .InternoFolio = sqlDr("int_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            '/*ingreso*/
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IDDocumentoIngreso = sqlDr("doc_id_ing").ToString
                            '/*Egreso*/
                            .IDMovimientoEgreso = sqlDr("mov_egr_id").ToString
                            .IDDocumentoEgreso = sqlDr("doc_jud_id").ToString

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

            End Try
            Return objEntCol
        End Function
#End Region
#Region "Padin_PLM"
        Public Function ListarPoblacionIngresos_plm(objEntPadin As Entity.Estadistica.Padin,
                                                    TipoMov As Type.Enumeracion.Padin.EnumTipoMovimiento) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_ingresos_plm", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString

                            .IDMovimiento = sqlDr("mov_id").ToString
                            .TipoDetalleMovimientoIng = sqlDr("tip_det_ing_mov").ToString
                            .IDDocumentoIngreso = 1

                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            .ExpedienteLibertarID = sqlDr("expLibID").ToString
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

            End Try
            Return objEntCol
        End Function
        Public Function ListarPoblacionEgresos_plm(objEntPadin As Entity.Estadistica.Padin, TipoMov As Integer) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_egresos_plm", objEntPadin)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            '/*Datos del interno*/
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            '/*ingreso*/
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IDDocumentoIngreso = sqlDr("doc_id_ing").ToString
                            '/*Egreso*/
                            .IDMovimientoEgreso = sqlDr("mov_egr_id").ToString
                            .IDDocumentoEgreso = sqlDr("doc_jud_id").ToString

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

            End Try
            Return objEntCol
        End Function
        Public Function ListarPoblacionActivos_plm(objEntPadin As Entity.Estadistica.Padin) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_activa_plm", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
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

            End Try
            Return objEntCol
        End Function
        'Version 2 15/05/2021 J.E.U
        Public Function ListarPoblacionIngresos_plm_v2(objEntPadin As Entity.Estadistica.Padin,
                                                    TipoMov As Type.Enumeracion.Padin.EnumTipoMovimiento) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_ingresos_plm_v2", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("int_lib").ToString
                            .InternoFolio = sqlDr("int_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString

                            .IDMovimiento = sqlDr("mov_id").ToString
                            .TipoDetalleMovimientoIng = sqlDr("tip_det_ing_mov").ToString
                            .IDDocumentoIngreso = 1

                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            .ExpedienteLibertarID = sqlDr("expLibID").ToString
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

            End Try
            Return objEntCol
        End Function
        Public Function ListarPoblacionEgresos_plm_v2(objEntPadin As Entity.Estadistica.Padin, TipoMov As Integer) As Entity.Estadistica.PadinDetalleCol

            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEntPadin.TipoMovimiento = TipoMov

            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_egresos_plm_v2", objEntPadin)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            '/*Datos del interno*/
                            .InternoID = sqlDr("int_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString
                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString
                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("int_lib").ToString
                            .InternoFolio = sqlDr("int_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
                            '/*ingreso*/
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IDDocumentoIngreso = sqlDr("doc_id_ing").ToString
                            '/*Egreso*/
                            .IDMovimientoEgreso = sqlDr("mov_egr_id").ToString
                            .IDDocumentoEgreso = sqlDr("doc_jud_id").ToString

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

            End Try
            Return objEntCol
        End Function
        Public Function ListarPoblacionActivos_plm_v2(objEntPadin As Entity.Estadistica.Padin) As Entity.Estadistica.PadinDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntCol As New Entity.Estadistica.PadinDetalleCol
            Dim objEnt As Entity.Estadistica.PadinDetalle
            Dim sqlDr As SqlDataReader = Data.Estadistica.Padin.Listar(sqlCon, "lst", "lst_listar_poblacion_activa_plm_v2", objEntPadin)
            'Dim dt As New DataTable
            'dt.Load(sqlDr)
            Try
                objEntCol = New Entity.Estadistica.PadinDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalle

                        With objEnt
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigo = sqlDr("int_cod_rp").ToString

                            .InternoPrimerApellido = sqlDr("int_ape_pat").ToString

                            .InternoSegundoApellido = sqlDr("int_ape_mat").ToString
                            .InternoPreNombres = sqlDr("int_nom").ToString
                            .InternoSexoID = sqlDr("sex_id").ToString
                            .InternoSexo = sqlDr("sex_nom").ToString
                            .InternoTipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .InternoTipoDocumento = sqlDr("tip_doc_nom").ToString
                            .InternoNumeroDocumento = sqlDr("int_doc_num").ToString
                            .InternoFechaNacimiento = sqlDr("int_fec_nac").ToString
                            .InternoNacimientoPaisID = sqlDr("pai_id").ToString
                            .InternoNacimientoPais = sqlDr("pai_nom").ToString
                            .InternoNacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .InternoNacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .InternoNacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.Edad = .CalcularEdad(Legolas.Configuration.Aplication.FechayHora.FechaLong)
                            '.NacionalidadID = sqlDr("nac_id").ToString
                            .InternoNacionalidad = sqlDr("nac_nom").ToString
                            .InternoEstadoCivilID = sqlDr("est_civ_id").ToString
                            .InternoEstadoCivil = sqlDr("est_civ_nom").ToString
                            .InternoGradoInstruccionID = sqlDr("niv_aca_id").ToString
                            .InternoGradoInstruccion = sqlDr("niv_aca_nom").ToString
                            '. .ProfesionNombre = sqlDr("pro_nom").ToString
                            .InternoOcupacionGenericoID = sqlDr("ocu_tip_id").ToString
                            .InternoOcupacionGenerico = sqlDr("ocu_tip_nom").ToString
                            .InternoOcupacionEspecifico = sqlDr("ocu_nom").ToString
                            .InternoComunidaGenericaID = sqlDr("int_com_id").ToString
                            .InternoComunidaNativa = sqlDr("com_and_nom").ToString
                            .InternoDiscapacidadID = sqlDr("int_dis_id").ToString
                            .InternoDiscapacidad = sqlDr("dis_nom").ToString
                            '/*familia*/
                            .InternoPadre = sqlDr("pad_nom").ToString
                            .InternoMadre = sqlDr("mad_nom").ToString

                            ' .Conyugue = sqlDr("cyg_nom").ToString
                            '/*ubigeo*/
                            .InternoDomicilioDepartamento = sqlDr("ubg_dep_nom").ToString
                            .InternoDomicilioProvincia = sqlDr("ubg_prv_nom").ToString
                            .InternoDomicilioDistrito = sqlDr("ubg_dis_nom").ToString
                            .InternoDomicilio = sqlDr("int_dir_nom").ToString
                            '/*alias*/
                            .InternoAlias = sqlDr("ali_nom").ToString
                            '/*ingreso*/
                            '.IngresoNumero = sqlDr("num_ing").ToString                           
                            '/*penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '/*estado*/
                            .InternoGenero = sqlDr("pad_gen_nom").ToString
                            .InternoPerteneciaEtnica = sqlDr("pad_pert_etn").ToString
                            .InternoLenguaMaterna = sqlDr("pad_leng_mat").ToString
                            .InternoLibro = sqlDr("int_lib").ToString
                            .InternoFolio = sqlDr("int_fol").ToString
                            .InternoEstadoID = sqlDr("int_est_id").ToString
                            .IDMovimiento = sqlDr("mov_id").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            ' .EstadoNom = sqlDr("int_est_nom").ToString
                            .PadinTipoMovimiento = sqlDr("tip_mov").ToString
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

            End Try
            Return objEntCol
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(objEnt As Entity.Estadistica.Padin) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim e As Entity.Estadistica.PadinCol
            e = Listar(-1, objEnt.RegionID, objEnt.PenalID, objEnt.Anio, objEnt.Mes, -1, 0)

            Dim padAnuladosCol As Entity.Estadistica.PadinCol
            padAnuladosCol = Listar(-1, objEnt.RegionID, objEnt.PenalID, objEnt.Anio, objEnt.Mes, 5, 0) 'lista los padines anulados, Valor 5=ANULADO

            If e.Count - padAnuladosCol.Count = 2 And objEnt.Codigo = -1 Then
                If Windows.Forms.MessageBox.Show("Se recomienda generar un máximo de dos padines por mes, de todas maneras desea guardar el nuevo padin y continuar?", _
                                                     "", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Return intValue
                End If
            End If
            With objEnt

                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"

                    If ValidarEstadoTransferencia(.RegionID, .PenalID) = False Then
                        Return intValue
                    End If
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)
            End With
            Return intValue
        End Function
        Public Function Grabarv5(objEnt As Entity.Estadistica.Padin) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim e As Entity.Estadistica.PadinCol
            e = Listar(-1, objEnt.RegionID, objEnt.PenalID, objEnt.Anio, objEnt.Mes, -1, 0)

            Dim padAnuladosCol As Entity.Estadistica.PadinCol
            padAnuladosCol = Listar(-1, objEnt.RegionID, objEnt.PenalID, objEnt.Anio, objEnt.Mes, 5, 0) 'lista los padines anulados, Valor 5=ANULADO

            If e.Count - padAnuladosCol.Count = 2 And objEnt.Codigo = -1 Then
                If Windows.Forms.MessageBox.Show("Se recomienda generar un máximo de dos padines por mes, de todas maneras desea guardar el nuevo padin y continuar?", _
                                                     "", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Return intValue
                End If
            End If

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v5"

                    If ValidarEstadoTransferencia(.RegionID, .PenalID) = False Then
                        Return intValue
                    End If
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)
            End With
            Return intValue
        End Function

        Public Function GrabarProceso(objEnt As Entity.Estadistica.Padin) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_proceso"

            intValue = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function GrabarTransferencia(objEnt As Entity.Estadistica.Padin) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_transferencia"

            intValue = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function GrabarTransferenciaRegion(objEnt As Entity.Estadistica.Padin) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_transferencia"

            With objEnt
                .IDUsuarioResponsableRegion = -1
                .UsuarioResponsableRegion = ""
                .FechaRegionRpta = 0
                .FechaEnvio = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
            End With

            intValue = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function GrabarTransferenciaSede(objEnt As Entity.Estadistica.Padin) As Long

            Dim value As Long = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_transferencia"

            With objEnt
                .IDUsuarioResponsableRegion = Legolas.Configuration.Usuario.Codigo
                .UsuarioResponsableRegion = Legolas.Configuration.Usuario.ApellidosyNombre
                .FechaRegionRpta = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                .FechaEnvio = 0 'fecha de envio del penal
                .FechaRecepcion = 0 'fecha recepcion
            End With

            'recuperamos los id de transfer
            Dim objEntReg As New Entity.Estadistica.Padin
            objEntReg = Listar(objEnt)

            Dim intRow As Long, intRegion, intPenal As Integer

            intRow = objEntReg.TransferIDRow
            intRegion = objEntReg.TransferIDRegion
            intPenal = objEntReg.TransferIDPenal

            'grabamos el envio a la sede central x medio de la ws
            If EnviadoSedeWS(intRow, intRegion, intPenal, objEnt) > 0 Then
                value = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)
            End If

            Return value

        End Function

        Public Function GrabarRespuestaSede(IDPadin As Long, IDUsuarioRegion As Integer, UsuarioRegion As String,
                                           FechaRecepcion As Long, FechaRespuesta As Long, IDEstado As Integer, ObsAnulacion As String) As Long

            Dim value As Long = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_transferencia"

            Dim objEnt As New Entity.Estadistica.Padin
            With objEnt
                .Codigo = IDPadin
                .IDUsuarioResponsableRegion = IDUsuarioRegion
                .UsuarioResponsableRegion = UsuarioRegion
                .FechaRecepcion = FechaRecepcion
                .FechaRegionRpta = FechaRespuesta
                .Estado = IDEstado
                .ObservacionAnulacion = ObsAnulacion
            End With

            value = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

        Public Function Anular(Codigo As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_anular"

            intValue = Data.Estadistica.Padin.Anular(strAccion, strOpcion, Codigo)

            Return intValue
        End Function

        Public Function Anular(objEnt As Entity.Estadistica.Padin) As Long

            Dim value As Long = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_anular"

            With objEnt
                .IDUsuarioResponsableRegion = Legolas.Configuration.Usuario.Codigo
                .UsuarioResponsableRegion = Legolas.Configuration.Usuario.ApellidosyNombre
                .FechaRegionRpta = Legolas.LBusiness.Globall.DateTime.FechaHoraServerLong
                .Estado = Type.Enumeracion.Padin.EnumPadinEstado.Anulado
            End With

            'recuperamos los id de transfer
            Dim objEntReg As New Entity.Estadistica.Padin
            objEntReg = Listar(objEnt)

            Dim intRow As Long, intRegion, intPenal As Integer

            intRow = objEntReg.TransferIDRow
            intRegion = objEntReg.TransferIDRegion
            intPenal = objEntReg.TransferIDPenal

            'grabamos la anulacion en la sede central
            If AnularSedeWS(intRow, intRegion, intPenal, objEnt) > 0 Then
                value = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)
            End If

            Return value

        End Function

        Public Function GrabarPlm(objEnt As Entity.Estadistica.Padin) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim e As Entity.Estadistica.PadinCol
            e = Listar(-1, objEnt.RegionID, objEnt.PenalID, objEnt.Anio, objEnt.Mes, -1, 0)

            Dim padAnuladosCol As Entity.Estadistica.PadinCol
            padAnuladosCol = Listar(-1, objEnt.RegionID, objEnt.PenalID, objEnt.Anio, objEnt.Mes, 5, 0) 'lista los padines anulados, Valor 5=ANULADO

            If e.Count - padAnuladosCol.Count = 2 And objEnt.Codigo = -1 Then
                If Windows.Forms.MessageBox.Show("Se recomienda generar un máximo de dos padines por mes, de todas maneras desea guardar el nuevo padin y continuar?",
                                                     "", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Return intValue
                End If
            End If

            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant_v5"

                    If ValidarEstadoTransferencia(.RegionID, .PenalID) = False Then
                        Return intValue
                    End If
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Estadistica.Padin.Grabar(strAccion, strOpcion, objEnt)
            End With
            Return intValue
        End Function
#End Region

#Region "Metodos_Ws"

        Private Function ListarEstadoPadin_SedeWs(objEntCol As Entity.Estadistica.PadinCol) As Boolean

            Dim value As Boolean = False

            If objEntCol.Count < 1 Then
                Return value
            End If

            Dim blnPasa As Boolean = False
            Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
            Dim objBssLicencia As New Bussines.Sistema.Instalacion
            intTipoLicencia = objBssLicencia.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)

            Select Case intTipoLicencia

                Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia
                    blnPasa = True
                    'solo los penales podran actualizar sus estado cada vez que hagan clic en el boton buscar
            End Select

            If Legolas.Components.PC.IsOnline = True And blnPasa = True Then

                Dim objDTOColReg As APPWebService.ws_pope_sede_padin.DTO_Padin_ListarSol
                Dim objArrayDtoCol As New ArrayList

                For Each obj As Entity.Estadistica.Padin In objEntCol

                    If obj.Estado = Type.Enumeracion.Padin.EnumPadinEstado.EnviadoRegion Or
                         obj.Estado = Type.Enumeracion.Padin.EnumPadinEstado.RecepcionRegion Then

                        objDTOColReg = New APPWebService.ws_pope_sede_padin.DTO_Padin_ListarSol
                        With objDTOColReg
                            .IDPadin = obj.Codigo
                            .IDRowPadin = obj.TransferIDRow
                            .IDRegion = obj.TransferIDRegion
                            .IDPenal = obj.TransferIDPenal
                            .IDEstado = obj.Estado
                        End With
                        objArrayDtoCol.Add(objDTOColReg)

                    End If
                Next

                'si hay mas de un elemento
                If objArrayDtoCol.Count > 0 Then

                    Dim objDTOColRpta() As APPWebService.ws_pope_sede_padin.DTO_Padin_ListarRpta
                    Dim objDTOCol(objArrayDtoCol.Count - 1) As APPWebService.ws_pope_sede_padin.DTO_Padin_ListarSol
                    Dim intIndice As Integer = 0

                    For Each obj As APPWebService.ws_pope_sede_padin.DTO_Padin_ListarSol In objArrayDtoCol
                        objDTOCol(intIndice) = obj
                        intIndice = +1
                    Next

                    Dim objWs As New APPWebService.ws_pope_sede_padin.Padin
                    objWs.Url = APPWebService.PathURL.ws_sede_padin
                    Try
                        objDTOColRpta = objWs.Listar(objDTOCol)
                    Catch ex As Exception
                        objDTOColRpta = Nothing
                    End Try

                    If Not objDTOColRpta Is Nothing Then

                        Dim objBssPadin As New Bussines.Estadistica.Padin

                        For Each objRpta As APPWebService.ws_pope_sede_padin.DTO_Padin_ListarRpta In objDTOColRpta

                            With objRpta

                                If .IDEstadoSol <> .IDEstado Then
                                    GrabarRespuestaSede(.IDPadin, .IDUsuario, .UsuarioApeNom, .FechaRecepcion, .FechaRespuesta, .IDEstado, .ObsAnulacion)
                                    value = True
                                End If

                            End With

                        Next

                    End If

                End If

            End If

            Return value

        End Function

        Private Function AnularSedeWS(TransferIDRow As Long, TranferIDRegion As Integer, TransferPenal As Integer, objEnt As Entity.Estadistica.Padin) As Long

            Dim value As Long = -1
            Dim objws As New APPWebService.ws_pope_sede_padin.Padin
            Dim objDTO As New APPWebService.ws_pope_sede_padin.DTO_PadinAnulacion_Sol
            objws.Url = APPWebService.PathURL.ws_sede_padin

            With objDTO
                .IDRowPadin = TransferIDRow
                .IDRegion = TranferIDRegion
                .IDPenal = TransferPenal

                .FechaRespuesta = objEnt.FechaRegionRpta
                .IDEstado = objEnt.Estado
                .IDUsuario = objEnt.IDUsuarioResponsableRegion
                .UsuarioApeNom = objEnt.UsuarioResponsableRegion
                .ObsAnulacion = objEnt.ObservacionAnulacion
            End With

            'intentamos guardar 3 veces 
            For i As Integer = 0 To 3

                If Legolas.Components.PC.IsOnline = True Then

                    Try
                        value = objws.GrabarAnulacion(objDTO)
                    Catch ex As Exception

                    End Try

                    If value > 0 Then
                        Exit For
                    End If
                End If

            Next

            Return value

        End Function

        Private Function EnviadoSedeWS(TransferIDRow As Long, TranferIDRegion As Integer, TransferPenal As Integer, objEnt As Entity.Estadistica.Padin) As Long

            Dim value As Long = -1
            Dim objws As New APPWebService.ws_pope_sede_padin.Padin
            Dim objDTO As New APPWebService.ws_pope_sede_padin.DTO_PadinRespuesta_Sol
            objws.Url = APPWebService.PathURL.ws_sede_padin

            With objDTO
                .IDRowPadin = TransferIDRow
                .IDRegion = TranferIDRegion
                .IDPenal = TransferPenal

                .FechaRespuesta = objEnt.FechaRegionRpta
                .IDEstado = objEnt.Estado
                .IDUsuario = objEnt.IDUsuarioResponsableRegion
                .UsuarioApeNom = objEnt.UsuarioResponsableRegion
            End With

            'intentamos guardar 3 veces 
            For i As Integer = 0 To 3

                If Legolas.Components.PC.IsOnline = True Then

                    Try
                        value = objws.GrabarRespuesta(objDTO)
                    Catch ex As Exception

                    End Try

                    If value > 0 Then
                        Exit For
                    End If
                End If

            Next

            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            intValue = Data.Estadistica.Padin.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue

        End Function
        Public Function Eliminar_v2(ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant_v2"

            intValue = Data.Estadistica.Padin.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue

        End Function
#End Region

    End Class
End Namespace