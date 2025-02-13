Imports System.Data.SqlClient

Namespace Reporte
    Public Class Clasificacion
#Region "Reporte"
        'Public Function DatosInterno(ByVal InternoID As Integer) As Entity.Reporte.Clasificacion.DatosInternoCol

        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

        '    Dim sqlDr As SqlDataReader = Data.Reporte.Clasificacion.Listar(sqlCon, "lst", "lst_ficha_interno3", InternoID, -1)

        '    Dim objEntCol As New Entity.Reporte.Clasificacion.DatosInternoCol

        '    Try
        '        If sqlDr.HasRows Then

        '            Dim objBssLicencia As New Bussines.Sistema.Instalacion
        '            Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


        '            While sqlDr.Read
        '                Dim objEnt As New Entity.Reporte.Clasificacion.DatosInterno

        '                With objEnt
        '                    .CodigoRP = sqlDr("int_cod_rp").ToString
        '                    '/*datos de identificacion*/
        '                    .ApellidoPaterno = sqlDr("int_ape_pat").ToString
        '                    .ApellidoMaterno = sqlDr("int_ape_mat").ToString
        '                    .Nombres = sqlDr("int_nom").ToString
        '                    .TipoDocumento = sqlDr("tip_doc_nom").ToString
        '                    .NumeroDocumento = sqlDr("int_doc_num").ToString
        '                    .OtroDocumento = ""
        '                    .InfoDecadactilarInt = sqlDr("info_decadact_int").ToString
        '                    .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
        '                    .FechaNacimiento = sqlDr("int_fec_nac").ToString
        '                    .SexoID = sqlDr("sex_id").ToString
        '                    .EstadoCivil = sqlDr("est_nom").ToString
        '                    .Padre = sqlDr("pad_nom").ToString
        '                    .Madre = sqlDr("mad_nom").ToString
        '                    .Conyugue = sqlDr("coy_nom").ToString
        '                    '.HijosMenores = sqlDr("int_hij_men").ToString

        '                    'numeros de hijos
        '                    .NumeroHijos = sqlDr("int_hijos").ToString
        '                    'If .NumeroHijos < 1 Then .NumeroHijos = 0

        '                    .TipoLocal = intTipoLocal

        '                    .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
        '                    .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
        '                    .FotoPerfilCentralId = sqlDr("pth_fot_fre_id").ToString
        '                    .FotoPerfilIzquierdoId = sqlDr("pth_fot_izq_id").ToString
        '                    .PathServerImg = sqlDr("arc_dig_dir").ToString
        '                    .FotoVersionAntigua = sqlDr("FotVersionAntigua")

        '                    '/*datos de localidad de nacimiento*/                            
        '                    .Nacionalidad = sqlDr("nac_nom").ToString
        '                    .NacimientoPais = sqlDr("pai_nom").ToString
        '                    .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
        '                    .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
        '                    .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
        '                    .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
        '                    .Religion = sqlDr("int_religion").ToString
        '                    .Idioma = sqlDr("int_idioma").ToString
        '                    '/*datos domicilios*/
        '                    .DomicilioDepartamento = sqlDr("dom_dep").ToString
        '                    .DomicilioProvincia = sqlDr("dom_pro").ToString
        '                    .DomicilioDistrito = sqlDr("dom_dis").ToString
        '                    .Domicilio = sqlDr("dir_nom").ToString
        '                    'datos complementarios
        '                    .GradoInstruccion = sqlDr("grd_ins_nom").ToString
        '                    .Profesion = sqlDr("pro_nom").ToString
        '                    .CentroTrabajo = ""
        '                    .Ocupacion = sqlDr("ocu_nom").ToString
        '                    .FuerzaArmanda = sqlDr("int_fza_arm").ToString
        '                    .Rango = sqlDr("int_rgo_fza_arm").ToString
        '                    .Hononimo = sqlDr("int_homonimo").ToString
        '                    '/*caracteristicas notables fisicas, señas cicatrices*/                           
        '                    '.RasgoCol = ListarRasgos_v2(InternoID)
        '                    '.SenasParticulares = ListarSenasParticulares(InternoID)
        '                    ''/*nombres asociados, alias, bandas*/
        '                    .NombresAsociados = ListarNombresAsociados(InternoID)
        '                    '.AliasNombres = ListarAlias(InternoID)
        '                    '.Bandas = ListarOrganizacionCriminal(InternoID, 1) 'banda
        '                    ''/*datos del ultimo internamiento*/
        '                    .InternoIngresoID = sqlDr("int_ing_id").ToString
        '                    .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
        '                    .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
        '                    .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
        '                    .PenalActual = sqlDr("int_ing_pen_nom").ToString

        '                    ''.InternoExpedienteID = sqlDr("int_exp_id").ToString
        '                    ''.FechaMandato = sqlDr("int_exp_fec_man").ToString
        '                    ''.NumeroExpediente = sqlDr("int_exp_num_exp").ToString
        '                    ''.DistritoJudicial = sqlDr("int_exp_dis_jud_nom").ToString
        '                    ''.AutoridadJudicial = sqlDr("int_exp_aut_jud_nom").ToString
        '                    ''.Estado = sqlDr("sit_jur_nom").ToString

        '                    '.Delitos = ListarExpedienteDelitosInternamiento(InternoID, .InternoIngresoID)
        '                    ''/*situacion juridica*/
        '                    ''.SituacionJuridica = ListarSituacionJuridica(InternoID)
        '                    .SituacionJuridicaNombre = sqlDr("int_sit_jur_nom").ToString

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
        '        sqlCon.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try

        '    Return objEntCol

        'End Function

        ''' <summary>
        ''' 05/07/2018-> se agrego para filtrar por ingresoInpe para obtener informacion de cada ingreso.
        ''' </summary>
        ''' <param name="InternoID"></param>
        ''' <param name="IngresoInpeId"></param>
        ''' <returns></returns>
        Public Function DatosInterno_v2(ByVal InternoID As Integer, ByVal IngresoInpeId As Integer) As Entity.Reporte.Clasificacion.DatosInternoCol
            Dim objEntCol As New Entity.Reporte.Clasificacion.DatosInternoCol

            Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlDr As SqlDataReader = Data.Reporte.Clasificacion.Listar(sqlCon, "lst", "lst_ficha_interno_clasif", InternoID, IngresoInpeId)
                    Try
                        If sqlDr.HasRows Then
                            Dim intTipoLocal As Integer = New Bussines.Sistema.Instalacion().Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo

                            While sqlDr.Read
                                Dim objEnt As New Entity.Reporte.Clasificacion.DatosInterno
                                With objEnt
                                    .CodigoRP = sqlDr("int_cod_rp").ToString
                                    .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                                    .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                                    .Nombres = sqlDr("int_nom").ToString
                                    .TipoDocumento = sqlDr("tip_doc_nom").ToString
                                    .NumeroDocumento = sqlDr("int_doc_num").ToString
                                    .OtroDocumento = ""
                                    .InfoDecadactilarInt = sqlDr("info_decadact_int").ToString
                                    .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                                    .FechaNacimiento = sqlDr("int_fec_nac").ToString
                                    .SexoID = sqlDr("sex_id").ToString
                                    .EstadoCivil = sqlDr("est_nom").ToString
                                    .Padre = sqlDr("pad_nom").ToString
                                    .Madre = sqlDr("mad_nom").ToString
                                    .Conyugue = sqlDr("coy_nom").ToString
                                    .NumeroHijos = sqlDr("int_hijos").ToString
                                    .TipoLocal = intTipoLocal
                                    .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                                    .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                                    .FotoPerfilCentralId = sqlDr("pth_fot_fre_id").ToString
                                    .FotoPerfilIzquierdoId = sqlDr("pth_fot_izq_id").ToString
                                    .PathServerImg = sqlDr("arc_dig_dir").ToString
                                    .FotoVersionAntigua = sqlDr("FotVersionAntigua")
                                    .Nacionalidad = sqlDr("nac_nom").ToString
                                    .NacimientoPais = sqlDr("pai_nom").ToString
                                    .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                                    .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                                    .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                                    .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                                    .Religion = sqlDr("int_religion").ToString
                                    .Idioma = sqlDr("int_idioma").ToString
                                    .DomicilioDepartamento = sqlDr("dom_dep").ToString
                                    .DomicilioProvincia = sqlDr("dom_pro").ToString
                                    .DomicilioDistrito = sqlDr("dom_dis").ToString
                                    .Domicilio = sqlDr("dir_nom").ToString
                                    .GradoInstruccion = sqlDr("grd_ins_nom").ToString
                                    .Profesion = sqlDr("pro_nom").ToString
                                    .CentroTrabajo = ""
                                    .Ocupacion = sqlDr("ocu_nom").ToString
                                    .FuerzaArmanda = sqlDr("int_fza_arm").ToString
                                    .Rango = sqlDr("int_rgo_fza_arm").ToString
                                    .Hononimo = sqlDr("int_homonimo").ToString
                                    .NombresAsociados = ListarNombresAsociados(InternoID)
                                    .InternoIngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                                    .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                                    .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                                    .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                                    .PenalActual = sqlDr("int_ing_pen_nom").ToString
                                    .SituacionJuridicaNombre = sqlDr("int_sit_jur_nom").ToString
                                End With
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    Catch
                        Throw
                    End Try
                End Using
            End Using

            Return objEntCol
        End Function


        ''' <summary>
        ''' hnrb 05/12/2024 copia de DatosInterno_v2 valido para reporte ficha final ETL
        ''' </summary>
        ''' <param name="InternoID"></param>
        ''' <param name="IngresoInpeId"></param>
        ''' <returns></returns>
        Public Function DatosInterno_rpt_ETL(ByVal InternoID As Integer, ByVal IngresoInpeId As Integer) As Entity.Reporte.Clasificacion.DatosInternoCol
            Dim objEntCol As New Entity.Reporte.Clasificacion.DatosInternoCol

            Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Using sqlDr As SqlDataReader = Data.Reporte.Clasificacion.Listar(sqlCon, "lst", "lst_ficha_interno_clasif_ETL", InternoID, IngresoInpeId)
                    Try
                        If sqlDr.HasRows Then
                            Dim intTipoLocal As Integer = New Bussines.Sistema.Instalacion().Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo

                            While sqlDr.Read
                                Dim objEnt As New Entity.Reporte.Clasificacion.DatosInterno
                                With objEnt
                                    .CodigoRP = sqlDr("int_cod_rp").ToString
                                    .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                                    .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                                    .Nombres = sqlDr("int_nom").ToString
                                    .TipoDocumento = sqlDr("tip_doc_nom").ToString
                                    .NumeroDocumento = sqlDr("int_doc_num").ToString
                                    .OtroDocumento = ""
                                    .InfoDecadactilarInt = sqlDr("info_decadact_int").ToString
                                    .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                                    .FechaNacimiento = sqlDr("int_fec_nac").ToString
                                    .SexoID = sqlDr("sex_id").ToString
                                    .EstadoCivil = sqlDr("est_nom").ToString
                                    .Padre = sqlDr("pad_nom").ToString
                                    .Madre = sqlDr("mad_nom").ToString
                                    .Conyugue = sqlDr("coy_nom").ToString
                                    .NumeroHijos = sqlDr("int_hijos").ToString
                                    .TipoLocal = intTipoLocal
                                    .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                                    .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                                    .FotoPerfilCentralId = sqlDr("pth_fot_fre_id").ToString
                                    .FotoPerfilIzquierdoId = sqlDr("pth_fot_izq_id").ToString
                                    .PathServerImg = sqlDr("arc_dig_dir").ToString
                                    .FotoVersionAntigua = sqlDr("FotVersionAntigua")
                                    .Nacionalidad = sqlDr("nac_nom").ToString
                                    .NacimientoPais = sqlDr("pai_nom").ToString
                                    .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                                    .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                                    .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                                    .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                                    .Religion = sqlDr("int_religion").ToString
                                    .Idioma = sqlDr("int_idioma").ToString
                                    .DomicilioDepartamento = sqlDr("dom_dep").ToString
                                    .DomicilioProvincia = sqlDr("dom_pro").ToString
                                    .DomicilioDistrito = sqlDr("dom_dis").ToString
                                    .Domicilio = sqlDr("dir_nom").ToString
                                    .GradoInstruccion = sqlDr("grd_ins_nom").ToString
                                    .Profesion = sqlDr("pro_nom").ToString
                                    .CentroTrabajo = ""
                                    .Ocupacion = sqlDr("ocu_nom").ToString
                                    .FuerzaArmanda = sqlDr("int_fza_arm").ToString
                                    .Rango = sqlDr("int_rgo_fza_arm").ToString
                                    .Hononimo = sqlDr("int_homonimo").ToString
                                    .NombresAsociados = ListarNombresAsociados_rpt(InternoID)
                                    .InternoIngresoInpeID = sqlDr("fk_ing_inp_id").ToString
                                    .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                                    .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                                    .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                                    .PenalActual = sqlDr("int_ing_pen_nom").ToString
                                    .SituacionJuridicaNombre = sqlDr("int_sit_jur_nom").ToString
                                End With
                                objEntCol.Add(objEnt)
                            End While
                        End If
                    Catch ex As Exception
                        Throw
                    End Try
                End Using
            End Using

            Return objEntCol
        End Function


        Public Function FichaDatosInternoPenalProvincia(ByVal intIDInterno As Integer, intIDIngreso As Integer) As Entity.Reporte.Clasificacion.DatosInternoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Clasificacion.Listar("usp_tra_reporte", sqlCon, "lst", "lst_ficha_datos_interno_penal_provincia",
                                                                           intIDInterno, intIDIngreso)

            Dim objEntCol As New Entity.Reporte.Clasificacion.DatosInternoCol

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Clasificacion.DatosInterno

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .OtroDocumento = ""
                            .InfoDecadactilarInt = sqlDr("info_decadact_int").ToString
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hijos").ToString
                            'fotos
                            .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                            .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                            .FotoPerfilCentralId = sqlDr("pth_fot_fre_id").ToString
                            .FotoPerfilIzquierdoId = sqlDr("pth_fot_izq_id").ToString
                            .PathServerImg = sqlDr("arc_dig_dir").ToString
                            .FotoVersionAntigua = sqlDr("FotVersionAntigua")
                            '/*datos de localidad de nacimiento*/                            
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .NacimientoPais = sqlDr("pai_nom").ToString
                            .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                            'religion/idioma
                            .Religion = sqlDr("int_religion").ToString
                            .Idioma = sqlDr("int_idioma").ToString
                            '/*datos domicilios*/
                            .DomicilioDepartamento = sqlDr("dom_dep").ToString
                            .DomicilioProvincia = sqlDr("dom_pro").ToString
                            .DomicilioDistrito = sqlDr("dom_dis").ToString
                            .Domicilio = sqlDr("dir_nom").ToString
                            'datos complementarios
                            .GradoInstruccion = sqlDr("grd_ins_nom").ToString
                            .Profesion = sqlDr("pro_nom").ToString
                            .CentroTrabajo = ""
                            .Ocupacion = sqlDr("ocu_nom").ToString
                            .FuerzaArmanda = sqlDr("int_fza_arm").ToString
                            .Rango = sqlDr("int_rgo_fza_arm").ToString
                            .Hononimo = sqlDr("int_homonimo").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString
                            .SituacionJuridicaNombre = sqlDr("int_sit_jur_nom").ToString
                            'nombres asociados
                            .NombresAsociados = ListarNombresAsociados(intIDInterno)
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = s
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
        Public Function FichaDatosInterno_LM(ByVal intIDInterno As Integer, IngresoInpeId As Integer) As Entity.Reporte.Clasificacion.DatosInternoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Clasificacion.Listar_LM("usp_tra_reporte", sqlCon, "lst", "lst_ficha_datos_interno_LM",
                                                                           intIDInterno, IngresoInpeId)

            Dim objEntCol As New Entity.Reporte.Clasificacion.DatosInternoCol

            Try
                If sqlDr.HasRows Then

                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Clasificacion.DatosInterno

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .OtroDocumento = ""
                            .InfoDecadactilarInt = sqlDr("info_decadact_int").ToString
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hijos").ToString
                            'fotos
                            .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                            .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                            .FotoPerfilCentralId = sqlDr("pth_fot_fre_id").ToString
                            .FotoPerfilIzquierdoId = sqlDr("pth_fot_izq_id").ToString
                            .PathServerImg = sqlDr("arc_dig_dir").ToString
                            .FotoVersionAntigua = sqlDr("FotVersionAntigua")
                            '/*datos de localidad de nacimiento*/                            
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .NacimientoPais = sqlDr("pai_nom").ToString
                            .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                            'religion/idioma
                            .Religion = sqlDr("int_religion").ToString
                            .Idioma = sqlDr("int_idioma").ToString
                            '/*datos domicilios*/
                            .DomicilioDepartamento = sqlDr("dom_dep").ToString
                            .DomicilioProvincia = sqlDr("dom_pro").ToString
                            .DomicilioDistrito = sqlDr("dom_dis").ToString
                            .Domicilio = sqlDr("dir_nom").ToString
                            'datos complementarios
                            .GradoInstruccion = sqlDr("grd_ins_nom").ToString
                            .Profesion = sqlDr("pro_nom").ToString
                            .CentroTrabajo = ""
                            .Ocupacion = sqlDr("ocu_nom").ToString
                            .FuerzaArmanda = sqlDr("int_fza_arm").ToString
                            .Rango = sqlDr("int_rgo_fza_arm").ToString
                            .Hononimo = sqlDr("int_homonimo").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString
                            .SituacionJuridicaNombre = sqlDr("int_sit_jur_nom").ToString
                            'nombres asociados
                            .NombresAsociados = ListarNombresAsociados(intIDInterno)
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Dim s As String = ""
                s = s
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
        Private Function ListarNombresAsociados(ByVal InternoID As Integer) As String
            Dim strValue As String = ""
            Dim strReturn As String = ""

            Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim objEntPar As New Entity.Registro.NombreAsociado With {
                    .InternoID = InternoID,
                    .Principal = 0
                }

                Using sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_mant", objEntPar)
                    Try
                        If sqlDr.HasRows Then
                            While sqlDr.Read
                                strValue &= $"{sqlDr("int_aso_ape_pat").ToString} {sqlDr("int_aso_ape_mat").ToString} {sqlDr("int_aso_nom").ToString}, "
                            End While
                            If strValue.Length > 2 Then
                                strReturn = strValue.Substring(0, strValue.Length - 2) ' Elimina la última coma y espacio
                            End If
                        End If
                    Catch
                        Throw
                    End Try
                End Using
            End Using

            Return strReturn
        End Function

        ''' <summary>
        ''' hnrb 05/12/2024 para ficha de carceleta, validar si se puede usar en penal LM y demas penales
        ''' </summary>
        ''' <param name="InternoID"></param>
        ''' <returns></returns>
        Private Function ListarNombresAsociados_rpt(ByVal InternoID As Integer) As String
            Dim strValue As String = ""
            Dim strReturn As String = ""

            Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim objEntPar As New Entity.Registro.NombreAsociado With {
                    .InternoID = InternoID,
                    .Principal = 0
                }

                Using sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_mant_rpt", objEntPar)
                    Try
                        If sqlDr.HasRows Then
                            While sqlDr.Read
                                strValue &= $"{sqlDr("int_aso_ape_pat").ToString} {sqlDr("int_aso_ape_mat").ToString} {sqlDr("int_aso_nom").ToString}, "
                            End While
                            If strValue.Length > 2 Then
                                strReturn = strValue.Substring(0, strValue.Length - 2) ' Elimina la última coma y espacio
                            End If
                        End If
                    Catch
                        Throw
                    End Try
                End Using
            End Using

            Return strReturn
        End Function
    End Class
End Namespace
