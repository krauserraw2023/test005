Imports System.Data.SqlClient
Namespace Reporte
    Public Class Tratamiento

#Region "Reporte"
        Public Function FichaIdentificacion(ByVal InternoID As Integer) As Entity.Reporte.Tratamiento.FichaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Tratamiento.Listar(sqlCon, _
            "lst", "lst_ficha_interno_asi", -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol
            Try
                If sqlDr.HasRows Then

                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Tratamiento.Ficha

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .OtroDocumento = ""
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            '.SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Hononimo = "???"
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString

                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hij_men").ToString

                            If .NumeroHijos < 1 Then
                                .NumeroHijos = 0
                            End If

                            .TipoLocal = intTipoLocal
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
                            .Religion = ""
                            .Idioma = ""
                            '/*datos domicilios*/
                            .DomicilioDepartamento = sqlDr("dom_dep").ToString
                            .DomicilioProvincia = sqlDr("dom_pro").ToString
                            .DomicilioDistrito = sqlDr("dom_dis").ToString
                            .Domicilio = sqlDr("dir_nom").ToString
                            'datos complementarios
                            .GradoInstruccion = sqlDr("grd_ins_nom").ToString
                            .Profesion = sqlDr("pro_nom").ToString
                            .CentroTrabajo = sqlDr("c_tra_tal_nom").ToString
                            .Ocupacion = sqlDr("ocu_nom").ToString
                            .FuerzaArmanda = ""
                            .Rango = ""
                            '/*nombres asociados, alias, bandas*/
                            .NombresAsociados = ListarNombresAsociados(InternoID)
                            .AliasNombres = ListarAlias(InternoID)
                            .Bandas = ListarBandas(InternoID)
                            '/*datos del ultimo internamiento*/
                            .InternoIngresoID = sqlDr("int_ing_id").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString
                            .Estado = sqlDr("int_est_nom").ToString
                            .LicenciaPenalNombre = sqlDr("lic_pen_nom").ToString
                            .LicenciaRegionNombre = sqlDr("lic_reg_nom").ToString

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

        Public Function FichaIdentificacion2(ByVal InternoID As Integer) As Entity.Reporte.FichaIdentificacion.FichaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, _
            "lst", "lst_ficha_interno2", -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.FichaCol

            Try
                If sqlDr.HasRows Then

                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.FichaIdentificacion.Ficha

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .OtroDocumento = ""
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Hononimo = "???"
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString

                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hij_men").ToString
                            If .NumeroHijos < 1 Then
                                .NumeroHijos = 0
                            End If

                            .TipoLocal = intTipoLocal
                            .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                            .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                            '/*datos de localidad de nacimiento*/                            
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .NacimientoPais = sqlDr("pai_nom").ToString
                            .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                            .Religion = ""
                            .Idioma = ""
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
                            .FuerzaArmanda = ""
                            .Rango = ""
                            '/*caracteristicas notables fisicas, señas cicatrices*/                           
                            .RasgoCol = ListarRasgos(InternoID)
                            .SenasParticulares = ListarSenasParticulares(InternoID)
                            '/*nombres asociados, alias, bandas*/
                            .NombresAsociados = ListarNombresAsociados(InternoID)
                            .AliasNombres = ListarAlias(InternoID)
                            .Bandas = ListarBandas(InternoID)
                            '/*datos del ultimo internamiento*/
                            .InternoIngresoID = sqlDr("int_ing_id").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString
                            '.InternoExpedienteID = sqlDr("int_exp_id").ToString
                            '.FechaMandato = sqlDr("int_exp_fec_man").ToString
                            '.NumeroExpediente = sqlDr("int_exp_num_exp").ToString
                            '.DistritoJudicial = sqlDr("int_exp_dis_jud_nom").ToString
                            '.AutoridadJudicial = sqlDr("int_exp_aut_jud_nom").ToString
                            '.Estado = sqlDr("sit_jur_nom").ToString
                            .Delitos = ListarExpedienteDelitosInternamiento(InternoID, .InternoIngresoID)
                            '/*situacion juridica*/
                            .SituacionJuridica = ListarSituacionJuridica(InternoID)
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
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

        Public Function FichaIdentificacion_v4(ByVal InternoID As Integer) As Entity.Reporte.FichaIdentificacion.FichaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, _
            "lst", "lst_ficha_interno3", -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.FichaCol

            Try
                If sqlDr.HasRows Then

                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.FichaIdentificacion.Ficha

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .InfoDecadactilarInt = sqlDr("info_decadact_int").ToString
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Hononimo = sqlDr("int_homonimo").ToString
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString

                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hijos").ToString
                            'If .NumeroHijos < 1 Then .NumeroHijos = 0

                            .TipoLocal = intTipoLocal

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
                            .Religion = ""
                            .Idioma = ""
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
                            .FuerzaArmanda = ""
                            .Rango = ""
                            '/*caracteristicas notables fisicas, señas cicatrices*/                           
                            .RasgoCol = ListarRasgos_v2(InternoID)
                            .SenasParticulares = ListarSenasParticulares(InternoID)
                            '/*nombres asociados, alias, bandas*/
                            .NombresAsociados = ListarNombresAsociados_v2(InternoID)
                            .AliasNombres = ListarAlias(InternoID)
                            .Bandas = ListarBandas(InternoID) 'banda
                            '/*datos del ultimo internamiento*/
                            .InternoIngresoID = sqlDr("int_ing_id").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString

                            .Delitos = ListarExpedienteDelitosInternamiento(InternoID, .InternoIngresoID)

                            '/*situacion juridica*/                    
                            .SituacionJuridicaNombre = sqlDr("int_sit_jur_nom").ToString

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
#Region "FichaIdentificacion"
        Private Function ListarSenasParticulares(ByVal InternoID As Integer) As Entity.Reporte.FichaIdentificacion.SenasParticularesCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_senas_particulares", _
            -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.SenasParticularesCol
            Dim objEnt As New Entity.Reporte.FichaIdentificacion.SenasParticulares

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.FichaIdentificacion.SenasParticulares

                        With objEnt
                            .Naturaleza = sqlDr("sen_part_nat_nom").ToString
                            .Forma = sqlDr("sen_part_for_nom").ToString
                            .Ubicacion = sqlDr("sen_part_ubi_nom").ToString
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
        Private Function ListarRasgos(ByVal InternoID As Integer) As Entity.Reporte.FichaIdentificacion.RasgosCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_rasgos", _
            -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.RasgosCol
            Dim objEnt As New Entity.Reporte.FichaIdentificacion.Rasgos

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.FichaIdentificacion.Rasgos
                        With objEnt
                            .Raza = sqlDr("int_ras_raz_nom").ToString
                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .FormaCara = sqlDr("int_ras_car_for_nom").ToString
                            .Menton = sqlDr("int_ras_men_nom").ToString
                            .Frente = sqlDr("int_ras_fre_nom").ToString
                            .ColorCabello = sqlDr("int_ras_cab_col_nom").ToString
                            .FormaCabello = sqlDr("int_ras_cab_for_nom").ToString
                            .FormaOjos = sqlDr("int_ras_for_ojo_nom").ToString
                            .Iris = sqlDr("int_ras_iri_nom").ToString
                            .Ceja = sqlDr("int_ras_cej_nom").ToString
                            .Boca = sqlDr("int_ras_boc_nom").ToString
                            .Labios = sqlDr("int_ras_lab_nom").ToString
                            .TipoLabios = sqlDr("int_ras_tip_lab_nom").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar_nom").ToString
                            .FormaNariz = sqlDr("int_ras_nar_for_nom").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins_nom").ToString
                            .Oreja = sqlDr("int_ras_ore_nom").ToString
                            .Tronco = sqlDr("int_ras_tro_nom").ToString
                            .Complexion = sqlDr("int_ras_com_nom").ToString
                            .AnomaliaOjos = sqlDr("int_ras_ano_ojo_nom").ToString
                            .Calvicie = sqlDr("int_ras_cal_nom").ToString
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
        Private Function ListarAsistencia(ByVal InternoID As Integer) As Entity.Reporte.Tratamiento.AsistenciaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", "lst_asistencia", _
            -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.Tratamiento.AsistenciaCol
            Dim objEnt As New Entity.Reporte.Tratamiento.Asistencia

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Tratamiento.Asistencia
                        With objEnt
                            .InternoID = sqlDr("fk_int_id").ToString
                            .Fecha = sqlDr("n_tal_asi_fec").ToString
                            .HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            .HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
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

        '07/04/2015
        Private Function ListarRasgos_v2(ByVal InternoID As Integer) As Entity.Reporte.FichaIdentificacion.RasgosCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_rasgos_v2", _
            -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.RasgosCol
            Dim objEnt As New Entity.Reporte.FichaIdentificacion.Rasgos

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.FichaIdentificacion.Rasgos
                        With objEnt
                            .Raza = sqlDr("int_ras_raz_nom").ToString
                            .Talla = sqlDr("int_ras_tal").ToString
                            .Peso = sqlDr("int_ras_pes").ToString
                            .FormaCara = sqlDr("int_ras_car_for_nom").ToString
                            .Menton = sqlDr("int_ras_men_nom").ToString
                            .Frente = sqlDr("int_ras_fre_nom").ToString
                            .ColorCabello = sqlDr("int_ras_cab_col_nom").ToString
                            .FormaCabello = sqlDr("int_ras_cab_for_nom").ToString
                            .FormaOjos = sqlDr("int_ras_for_ojo_nom").ToString
                            .Iris = sqlDr("int_ras_iri_nom").ToString
                            .Ceja = sqlDr("int_ras_cej_nom").ToString
                            .Boca = sqlDr("int_ras_boc_nom").ToString
                            .Labios = sqlDr("int_ras_lab_nom").ToString
                            .TipoLabios = sqlDr("int_ras_tip_lab_nom").ToString
                            .TipoNariz = sqlDr("int_ras_tip_nar_nom").ToString
                            .FormaNariz = sqlDr("int_ras_nar_for_nom").ToString
                            .LineaInsercion = sqlDr("int_ras_lin_ins_nom").ToString
                            .Oreja = sqlDr("int_ras_ore_nom").ToString
                            .Tronco = sqlDr("int_ras_tro_nom").ToString
                            .Complexion = sqlDr("int_ras_com_nom").ToString
                            .AnomaliaOjos = sqlDr("int_ras_ano_ojo_nom").ToString
                            .Calvicie = sqlDr("int_ras_cal_nom").ToString
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
        Private Function ListarNombresAsociados(ByVal InternoID As Integer) As String
            Dim objEntPar As New Entity.Registro.NombreAsociado
            objEntPar.InternoID = InternoID
            objEntPar.Principal = 0

            Dim strValue As String = ""
            Dim strReturn As String = ""
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_mant", objEntPar)

            Dim objEnt As New Entity.Registro.NombreAsociado

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString

                            strValue = strValue & .ApellidosyNombres & ", "
                        End With
                    End While

                    strReturn = Legolas.Components.Cadena.Left(strValue, strValue.Length - 2)

                Else
                    strReturn = "NO PRESENTA"
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

            Return strReturn

        End Function
        Private Function ListarNombresAsociados_v2(ByVal InternoID As Integer) As String
            Dim objEntPar As New Entity.Registro.NombreAsociado
            objEntPar.InternoID = InternoID
            objEntPar.Principal = 0
            Dim strValue As String = ""
            Dim strReturn As String = ""
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.NombreAsociado.Listar(sqlCon, "lst", "lst_mant", objEntPar)

            Dim objEnt As New Entity.Registro.NombreAsociado

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.NombreAsociado
                        With objEnt
                            .ApellidoPaterno = sqlDr("int_aso_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_aso_ape_mat").ToString
                            .Nombres = sqlDr("int_aso_nom").ToString

                            strValue = strValue & .ApellidosyNombres & ", "
                        End With
                    End While

                    strReturn = Legolas.Components.Cadena.Left(strValue, strValue.Length - 2)

                Else
                    strReturn = ""
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

            Return strReturn

        End Function
        Private Function ListarAlias(ByVal InternoID As Integer) As String

            Dim strValue As String = ""
            Dim strReturn As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.InternoAlias.Listar(sqlCon, "lst", "lst_mant", _
            -1, InternoID, "")

            Dim objEnt As New Entity.Registro.InternoAlias

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.InternoAlias
                        With objEnt
                            .Nombres = sqlDr("int_ali_nom").ToString
                            strValue = strValue & .Nombres & ", "

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

            strReturn = Legolas.Components.Cadena.Left(strValue, strValue.Length - 2)

            Return strReturn

        End Function
        Private Function ListarExpedienteDelitosInternamiento(ByVal InternoID As Integer, _
                                                              ByVal IngresoID As Long) As Entity.Reporte.FichaIdentificacion.DelitosCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_delitos2", _
            -1, -1, -1, InternoID, IngresoID, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.DelitosCol
            Dim objEnt As New Entity.Reporte.FichaIdentificacion.Delitos

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.FichaIdentificacion.Delitos
                        With objEnt
                            .InternoExpedienteID = sqlDr("int_exp_id").ToString
                            .FechaMandato = sqlDr("int_ing_exp_fec").ToString
                            .NumeroExpediente = sqlDr("int_ing_exp_num").ToString
                            .DistritoJudicial = sqlDr("int_exp_dis_jud_nom").ToString
                            .AutoridadJudicial = sqlDr("int_exp_aut_jud_nom").ToString
                            .Estado = sqlDr("sit_jur_nom").ToString
                            .Nombre = sqlDr("del_esp_nom").ToString
                            .Minimo = sqlDr("del_esp_min").ToString
                            .Maximo = sqlDr("del_esp_max").ToString
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
        Private Function ListarSituacionJuridica(ByVal InternoID As Integer) As Entity.Reporte.FichaIdentificacion.SituacionJuridicaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica", _
            -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.SituacionJuridicaCol
            Dim objEnt As New Entity.Reporte.FichaIdentificacion.SituacionJuridica

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.FichaIdentificacion.SituacionJuridica
                        With objEnt
                            .TipoActo = sqlDr("tip_act").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Codigo = sqlDr("cod").ToString
                            .NumeroIngreso = sqlDr("int_ing_nro").ToString

                            .DocumentoIngreso = sqlDr("doc_ing").ToString
                            .DocumentoNumero = sqlDr("doc").ToString
                            .DocumentoFecha = sqlDr("doc_fec").ToString
                            .FechaRecepcion = sqlDr("doc_fec_rcp").ToString
                            .DocumentoSalaJuzgado = sqlDr("doc_sal").ToString
                            .DocumentoSecretario = sqlDr("doc_sal_sec").ToString
                            .DocumentoObservacion = sqlDr("doc_obs").ToString

                            .ExpedienteNumero = sqlDr("exp_doc").ToString
                            .ExpedienteSalaJuzgado = sqlDr("exp_sal").ToString
                            .ExpedienteSecretario = sqlDr("exp_sal_sec").ToString

                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString

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

            Return ListarSituacionJuridicaOrdenar(InternoID, objEntCol)

        End Function
        Private Function ListarSituacionJuridicaOrdenar(ByVal InternoID As Integer, _
                                                        ByVal ObjCol As Entity.Reporte.FichaIdentificacion.SituacionJuridicaCol) As Entity.Reporte.FichaIdentificacion.SituacionJuridicaCol

            Dim intTipoActo As Integer = 1
            Dim intNumero As Integer = 0
            Dim intNumeroArray As New ArrayList

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.SituacionJuridicaCol

            'ObjCol.Sort("NumeroIngreso", Entity.SortDirection.Asc)
            ObjCol.Sort("FechaRecepcion", Entity.SortDirection.Asc)
            For Each Obj As Entity.Reporte.FichaIdentificacion.SituacionJuridica In ObjCol
                If intNumero <> Obj.NumeroIngreso And Obj.TipoActo = 1 Then 'ingreso
                    intNumeroArray.Add(Obj.NumeroIngreso)
                    intNumero = Obj.NumeroIngreso
                End If
            Next

            ObjCol.Sort("FechaRecepcion", Entity.SortDirection.Asc)

            For Each intNum As Integer In intNumeroArray

                For Each Obj As Entity.Reporte.FichaIdentificacion.SituacionJuridica In ObjCol

                    If intNum = Obj.NumeroIngreso Then

                        Select Case Obj.TipoActo
                            Case 1 'ingreso

                                Dim intTipo As Integer = 1
                                Dim strDocIng As String = ""
                                Dim lngFechaRecep As Long = 0
                                Dim strPenal As String = ""

                                strDocIng = Obj.DocumentoIngreso
                                lngFechaRecep = Obj.FechaRecepcion

                                strPenal = ListarSituacionJuridicaPenal(InternoID, Obj.Codigo)

                                Dim objEntCol2 As Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpedienteCol = Nothing
                                Dim blnPrimero As Boolean = True
                                Dim lngIngID As Long = -1
                                Dim lngCodID As Long = -1
                                Dim intCount As Integer = 0

                                objEntCol2 = ListarSituacionJuridicaExpediente(InternoID, Obj.IngresoID)
                                objEntCol2.Sort("FechaRecepcion", Entity.SortDirection.Asc)

                                For Each ObjEnt2 As Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpediente In objEntCol2
                                    intCount = intCount + 1
                                    lngIngID = ObjEnt2.IngresoID
                                    lngCodID = ObjEnt2.Codigo
                                Next

                                If intCount < 1 Then

                                    Dim objEnt As New Entity.Reporte.FichaIdentificacion.SituacionJuridica

                                    With objEnt
                                        .TipoActo = intTipo
                                        .FechaRecepcion = lngFechaRecep
                                        .DocumentoIngreso = strDocIng & " | Destino E.P. : " & strPenal
                                        .DocumentoNumero = strDocIng & " | Destino E.P. : " & strPenal
                                        .IngresoPenal = strPenal

                                        .Observacion = "N/I"
                                    End With

                                    '/*cabecera de pagina*/
                                    objEnt.PenalID = Obj.PenalID
                                    objEnt.PenalNombre = Obj.PenalNombre
                                    objEntCol.Add(objEnt)

                                Else

                                    For Each ObjEnt2 As Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpediente In objEntCol2

                                        Dim objEnt As New Entity.Reporte.FichaIdentificacion.SituacionJuridica

                                        With objEnt

                                            If blnPrimero = True Then
                                                .TipoActo = intTipo
                                                .FechaRecepcion = lngFechaRecep
                                                .DocumentoIngreso = strDocIng & " | Destino E.P. : " & strPenal
                                                .DocumentoNumero = strDocIng & " | Destino E.P. : " & strPenal
                                                '.IngresoPenal = strPenal
                                            Else
                                                .TipoActo = -1
                                                .FechaRecepcion = 0
                                                .DocumentoIngreso = ""
                                                .DocumentoNumero = ""
                                                '.IngresoPenal = ""
                                            End If

                                            If lngIngID = ObjEnt2.IngresoID And lngCodID = ObjEnt2.Codigo Then
                                                .IngresoPenal = strPenal
                                            End If

                                            .IngresoID = ObjEnt2.IngresoID
                                            .ExpedienteID = ObjEnt2.ExpedienteID
                                            .Codigo = ObjEnt2.Codigo
                                            .NumeroIngreso = ObjEnt2.NumeroIngreso

                                            .DocumentoFecha = ObjEnt2.DocumentoFecha
                                            .DocumentoSalaJuzgado = ""
                                            .DocumentoSecretario = "No Indica"

                                            .ExpedienteNumero = ObjEnt2.ExpedienteNumero
                                            .ExpedienteSecretario = ObjEnt2.ExpedienteSecretario
                                            .ExpedienteSalaJuzgado = ObjEnt2.ExpedienteSalaJuzgado

                                            .Observacion = "N/I"
                                            .Observacion2 = ObjEnt2.Observacion2

                                            blnPrimero = False
                                        End With

                                        '/*cabecera de pagina*/
                                        objEnt.PenalID = Obj.PenalID
                                        objEnt.PenalNombre = Obj.PenalNombre
                                        objEntCol.Add(objEnt)

                                    Next

                                End If

                            Case 2 'detencion -expediente

                                Obj.DocumentoNumero = ""
                                Obj.DocumentoSecretario = "No Indica"
                                Obj.DocumentoSalaJuzgado = ""

                                Obj.Observacion = ""
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)
                            Case 3 'libertades

                                Obj.DocumentoNumero = Obj.DocumentoNumero & " Sec. : " & If(Obj.DocumentoSecretario = "", "No Indica", Obj.DocumentoSecretario)

                                Obj.Observacion = ListarSituacionJuridicaLibertad(3, intNum, InternoID, Obj.Codigo)
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)

                            Case 5, 6, 7, 8, 9, 10, 11, 13 'ejecutoria suprema, ejecutoria superior, sustitucion de pena, adecuacion de pena, refundicion de sentencia, integracion de pena, conmutacion de pena,sentencia consentida

                                Obj.DocumentoNumero = Obj.DocumentoNumero & " Sec. : " & If(Obj.DocumentoSecretario = "", "No Indica", Obj.DocumentoSecretario)

                                Dim fSentencia As String = ""
                                Obj.Observacion = ListarSituacionJuridicaSentencia(InternoID, Obj.Codigo, fSentencia)
                                Obj.Observacion = fSentencia & " " & Obj.Observacion
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)

                            Case 12 'sentencia

                                Obj.DocumentoNumero = Obj.DocumentoNumero & " Sec. : " & If(Obj.DocumentoSecretario = "", "No Indica", Obj.DocumentoSecretario)
                                Dim fSentencia As String = ""

                                Obj.Observacion = ListarSituacionJuridicaSentencia(InternoID, Obj.Codigo, fSentencia)
                                Obj.Observacion = fSentencia & " " & Obj.Observacion
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)

                            Case Else

                                Obj.DocumentoNumero = Obj.DocumentoNumero & " Sec. : " & If(Obj.DocumentoSecretario = "", "No Indica", Obj.DocumentoSecretario)

                                Obj.Observacion = ""
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)
                        End Select

                        If Obj.TipoActo <> 1 Then 'ingreso
                            objEntCol.Add(Obj)
                        End If

                    End If
                Next

            Next

            Return objEntCol

        End Function
        Private Function ListarSituacionJuridicaExpediente(ByVal InternoID As Integer, _
                                                           ByVal IngresoID As Integer) As Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_expediente", _
            -1, -1, -1, InternoID, IngresoID, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpedienteCol
            Dim objEnt As New Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpediente

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.FichaIdentificacion.SituacionJuridicaExpediente
                        With objEnt
                            .TipoActo = sqlDr("tip_act").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Codigo = sqlDr("cod").ToString
                            .NumeroIngreso = sqlDr("int_ing_nro").ToString
                            .DocumentoNumero = sqlDr("doc").ToString
                            .DocumentoFecha = sqlDr("doc_fec").ToString
                            .FechaRecepcion = sqlDr("doc_fec_rcp").ToString
                            .DocumentoSalaJuzgado = sqlDr("doc_sal").ToString
                            .DocumentoSecretario = sqlDr("doc_sal_sec").ToString
                            .ExpedienteNumero = sqlDr("exp_doc").ToString
                            .ExpedienteSalaJuzgado = sqlDr("exp_sal").ToString
                            .ExpedienteSecretario = sqlDr("exp_sal_sec").ToString

                            .Observacion = "N/I"
                            .Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, .IngresoID, .ExpedienteID)

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
        Private Function ListarSituacionJuridicaPenal(ByVal InternoID As Integer, ByVal IngresoID As Long) As String

            Dim value As String = ""
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_penal", _
            -1, -1, -1, InternoID, IngresoID, -1, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        value = sqlDr("pen_nom").ToString
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

            Return value

        End Function
        Private Function ListarSituacionJuridicaLibertad(ByVal TipoActo As Integer, ByVal NumeroIngreso As Integer, _
                                                                 ByVal InternoID As Integer, _
                                                                 ByVal Codigo As Long) As String

            Dim value As String = ""
            Dim lngFecha As Long = 0
            Dim strFecha As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_libertad", _
             -1, -1, -1, InternoID, -1, Codigo, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        lngFecha = sqlDr("fec_lib").ToString
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

            If lngFecha > 0 Then
                strFecha = Legolas.Components.FechaHora.FechaString(lngFecha)
            End If

            value = "Fecha de Libertad : " & strFecha

            Return value

        End Function
        Private Function ListarSituacionJuridicaSentencia(ByVal InternoID As Long, ByVal Codigo As Long, ByRef fecSentencia As String) As String

            Dim value As String = ""

            Dim lngFecha As Long = 0
            Dim blnCadenaPer As Boolean = 0
            Dim intAnio As Integer = 0
            Dim intMes As Integer = 0
            Dim intDia As Integer = 0
            Dim lngFechaIni As Long = 0
            Dim lngFechaFin As Long = 0

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_sentencia", _
             -1, -1, -1, InternoID, -1, -1, Codigo, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        lngFecha = sqlDr("sen_fec").ToString
                        blnCadenaPer = sqlDr("cad_per").ToString
                        intAnio = sqlDr("sen_anio").ToString
                        intMes = sqlDr("sen_mes").ToString
                        intDia = sqlDr("sen_dia").ToString
                        lngFechaIni = sqlDr("int_sen_fec_ini").ToString
                        lngFechaFin = sqlDr("int_sen_fec_fin").ToString
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

            Dim strFechaSent As String = ""
            Dim strFechaIni As String = ""
            Dim strFechaFin As String = ""
            Dim strTiempoSentencia As String = ""
            Dim strTiempoFecha As String = ""

            If lngFecha > 0 Then
                strFechaSent = Legolas.Components.FechaHora.FechaString(lngFecha)
            End If

            If blnCadenaPer = True Then
                strTiempoSentencia = " Cadena perpetua"
            Else
                strTiempoSentencia = intAnio & " Año(s) " & intMes & " Mes(es) " & intDia & " Dia(s) "
            End If

            If lngFechaIni > 0 Then
                strFechaIni = Legolas.Components.FechaHora.FechaString(lngFechaIni)
            Else
                strFechaIni = "-"
            End If

            If lngFechaFin > 0 Then
                strFechaFin = Legolas.Components.FechaHora.FechaString(lngFechaFin)
            Else
                strFechaFin = "-"
            End If

            strTiempoFecha = " DEL " & strFechaIni & " AL " & strFechaFin

            fecSentencia = "F. SENTENCIA: " & strFechaSent
            value = "CONDENA A " & strTiempoSentencia & strTiempoFecha

            Return value

        End Function
        Private Function ListarSituacionJuridicaDelitoAgraviado(ByVal InternoID As Long, ByVal IngresoID As Integer, _
                                                                ByVal ExpedienteID As Long) As String

            Dim value As String = ""
            value = ListarSJDelito(InternoID, IngresoID, ExpedienteID)
            Return value

        End Function
        Private Function ListarSJDelito(ByVal InternoID As Long, ByVal IngresoID As Integer, _
                                                                ByVal ExpedienteID As Long) As String

            Dim Value As String = ""
            Dim strDelitoGen As String = ""
            Dim strDelitoEsp As String = ""
            Dim strDelito As String = ""
            Dim strAgraviado As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_delitos", _
            -1, -1, -1, InternoID, IngresoID, ExpedienteID, -1, -1, 0, 0)

            Dim objEnt As New Entity.Reporte.Delito

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Delito

                        With objEnt
                            .Codigo = sqlDr("int_del_id").ToString
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
                        End With

                        strDelitoGen = objEnt.DelitoGenerico
                        strDelitoEsp = objEnt.DelitoEspecifico
                        strDelito = objEnt.Delito & " EN AGRAVIO DE : "

                        strAgraviado = ListarSJAgraviado(InternoID, IngresoID, ExpedienteID, objEnt.Codigo)

                        If strAgraviado.Trim = "" Then
                            strAgraviado = "NO INDICA "
                        End If

                        Value = Value & strDelito & strAgraviado & "; " & vbCrLf

                    End While
                End If

                Value = Legolas.Components.Cadena.Left(Value, Value.LastIndexOf(";")) & "."

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
            If Value.Trim = "." Then Value = ""
            Return Value

        End Function
        Private Function ListarSJAgraviado(ByVal InternoID As Long, ByVal IngresoID As Integer, _
                                                                ByVal ExpedienteID As Long, _
                                                                ByVal DelitoID As Integer) As String

            Dim Value As String = ""
            Dim strNombre As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_agraviado", _
            -1, -1, -1, InternoID, IngresoID, ExpedienteID, -1, DelitoID, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        strNombre = sqlDr("int_agr_nom").ToString

                        If strNombre.Trim <> "" Then
                            Value = Value & strNombre & ","
                        End If
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

            Value = Legolas.Components.Cadena.Left(Value, Value.Length - 1)
            Return Value
        End Function
        '16/07/2014->hnrb
        'lista organizaciones criminales con las cuales tiene vinculo el interno (solo vigente exceptuando anulados).
        'TipoOrgCrim-> -1:todos,1:banda,2:CrimenOrganizado
        Private Function ListarBandas(ByVal InternoId As Integer) As String
            Dim Value As String = ""
            Dim strAgraviado As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_bandas", _
            -1, -1, -1, InternoId, -1, -1, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Value = Value & " " & sqlDr("ban_nom").ToString & ","
                    End While
                End If

                Value = Legolas.Components.Cadena.Left(Value, Value.Length - 1)

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

            Return Value
        End Function
#End Region
#Region "CertificadoReclusion"
        Private Function ListarCertificadoReclusionExpediente(ByVal InternoID As Long, _
                                                              ByVal IngresoID As Long) As Entity.Reporte.CertificadoReclusion.ExpedienteCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, _
            "lst", "lst_rpt_certificado_reclusion_expediente", -1, -1, -1, InternoID, IngresoID, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.CertificadoReclusion.ExpedienteCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.CertificadoReclusion.Expediente

                        With objEnt
                            .NumeroExpediente = sqlDr("int_ing_exp_num").ToString
                            .DistritoJudicial = sqlDr("aut_jud_nom").ToString
                            .JuzgadoSala = sqlDr("sal_jus_nom").ToString
                            .Secretario = sqlDr("sal_jus_sec").ToString
                            .SituacionJuridica = sqlDr("sit_jur_nom").ToString
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
        Private Function ListarCertificadoReclusionDelito(ByVal InternoID As Long, _
                                                          ByVal IngresoID As Long, _
                                                          ByVal ExpedienteID As Long) As Entity.Reporte.DelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, _
            "lst", "lst_rpt_delito", -1, -1, -1, InternoID, IngresoID, ExpedienteID, _
            -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.DelitoCol

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Delito

                        With objEnt
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
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
#Region "Papeleta_Excarcelacion"
        Private Function ListarPEDelito(ByVal InternoID As Long, ByVal IngresoID As Integer, _
                                                                ByVal ExpedienteID As Long) As String

            Dim Value As String = ""
            Dim strDelito As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_rpt_delito", _
            -1, -1, -1, InternoID, IngresoID, ExpedienteID, -1, -1, 0, 0)

            Dim objEnt As New Entity.Reporte.Delito

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Delito

                        With objEnt
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
                        End With

                        strDelito = objEnt.Delito

                        Value = Value & strDelito & ";"

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

            Return Value

        End Function
#End Region
#Region "CertificadoLibertad"
        Private Function ListarCLDelito(ByVal InternoID As Long, ByVal IngresoID As Integer, _
                                                                ByVal ExpedienteID As Long) As String

            Dim Value As String = ""
            Dim strDelito As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_rpt_delito", _
            -1, -1, -1, InternoID, IngresoID, ExpedienteID, -1, -1, 0, 0)

            Dim objEnt As New Entity.Reporte.Delito

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.Delito

                        With objEnt
                            .DelitoGenerico = sqlDr("del_gen_nom").ToString
                            .DelitoEspecifico = sqlDr("del_esp_nom").ToString
                        End With

                        strDelito = objEnt.Delito

                        Value = Value & strDelito & ";"

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

            Return Value

        End Function
#End Region
#Region "HistorialAntecedentes"
        Private Function ListarHASituacionJuridica(ByVal InternoID As Long) As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica", _
            -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            'Dim dt As New DataTable
            'dt.Load(sqlDr)

            Dim objEntCol As New Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol
            Dim objEnt As Entity.Reporte.HistorialAntecedentes.SituacionJuridica

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.HistorialAntecedentes.SituacionJuridica
                        With objEnt
                            .TipoActo = sqlDr("tip_act").ToString
                            .NombreTipoDoc = sqlDr("nom_doc").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Codigo = sqlDr("cod").ToString
                            .NumeroIngreso = sqlDr("int_ing_nro").ToString
                            .DocumentoIngreso = sqlDr("doc_ing").ToString
                            .DocumentoNumero = sqlDr("doc").ToString
                            .DocumentoFecha = sqlDr("doc_fec").ToString
                            .FechaRecepcion = sqlDr("doc_fec_rcp").ToString
                            .DocumentoSalaJuzgado = sqlDr("doc_sal").ToString
                            .DocumentoSecretario = sqlDr("doc_sal_sec").ToString
                            .DocumentoObservacion = sqlDr("doc_obs").ToString
                            .ExpedienteNumero = sqlDr("exp_doc").ToString
                            .ExpedienteSalaJuzgado = sqlDr("exp_sal").ToString
                            .ExpedienteSecretario = sqlDr("exp_sal_sec").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .PenalDestinoID = sqlDr("pen_des_id").ToString
                            .PenalDestinoNombre = sqlDr("pen_des_nom").ToString
                            .TipoTrasladoNombre = sqlDr("trs_tip_nom").ToString
                            .MotivoTrasladoNombre = sqlDr("trs_mot_nom").ToString

                            'int_ing_fec_isp
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

            Return ListarHASitJurOrdenar(InternoID, objEntCol)

        End Function
        Private Function ListarHASituacionJuridicaExpediente(ByVal InternoID As Integer, _
ByVal IngresoID As Integer) As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_expediente", _
            -1, -1, -1, InternoID, IngresoID, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol
            Dim objEnt As New Entity.Reporte.HistorialAntecedentes.SituacionJuridica

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.HistorialAntecedentes.SituacionJuridica
                        With objEnt
                            .TipoActo = sqlDr("tip_act").ToString
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id").ToString
                            .Codigo = sqlDr("cod").ToString
                            .NumeroIngreso = sqlDr("int_ing_nro").ToString
                            '.DocumentoIngreso = ""
                            .DocumentoNumero = sqlDr("doc").ToString
                            .DocumentoFecha = sqlDr("doc_fec").ToString
                            .FechaRecepcion = sqlDr("doc_fec_rcp").ToString
                            .DocumentoSalaJuzgado = sqlDr("doc_sal").ToString
                            .DocumentoSecretario = sqlDr("doc_sal_sec").ToString
                            .DocumentoObservacion = sqlDr("doc_obs").ToString
                            .ExpedienteNumero = sqlDr("exp_doc").ToString
                            .ExpedienteSalaJuzgado = sqlDr("exp_sal").ToString
                            .ExpedienteSecretario = sqlDr("exp_sal_sec").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString

                            .Observacion = "N/I"
                            .Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, .IngresoID, .ExpedienteID)

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
        Private Function ListarHASitJurOrdenar(ByVal InternoID As Long, _
                                                        ByVal ObjCol As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol) As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol
            Dim strNumDoc As String = ""
            Dim intTipoActo As Integer = 1
            Dim intNumeroArray As New ArrayList

            Dim objEntCol As New Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol

            Dim int_ID As Integer = -1
            Dim pen_ori_nom As String = ""
            ' ObjCol.Sort("FechaRecepcion", Entity.SortDirection.Asc)
            For Each Obj As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In ObjCol
                If Obj.TipoActo = 0 Then 'ingreso
                    If ListarHistorialAntecendentesIngresoTipo(InternoID, Obj.IngresoID) = "INGRESO POR TRASLADO" And Obj.TipoActo = 0 Then
                        Dim bss As New Bussines.Registro.Ingreso
                        int_ID = Obj.IngresoID
                        'Obj.FechaRecepcion = bss.Listar(Obj.IngresoID).FechaISP
                    End If
                    intNumeroArray.Add(Obj.NumeroIngreso)
                    ' intNumero = Obj.NumeroIngreso
                End If
                If Obj.TipoActo = 4 Then
                    If ListarHistorialAntecendentesIngresoTipo(InternoID, Obj.IngresoID) = "INGRESO POR TRASLADO" Then
                        pen_ori_nom = If(Obj.PenalID <> -1, "E.P " & Obj.PenalDestinoNombre, Obj.PenalDestinoNombre)
                    End If
                End If
            Next

            For Each Obj As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In ObjCol
                If Obj.Codigo = int_ID Then Obj.PenalNombre = pen_ori_nom 'solo para ingresos por traslado
            Next

            For i As Integer = 0 To intNumeroArray.Count - 1
                Dim v1 As Integer = intNumeroArray(i)
                For j As Integer = i + 1 To intNumeroArray.Count - 1
                    If v1 = intNumeroArray(j) Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Se ha detectado que número de ingreso " & v1 & " está duplicado, corrija o elimine el registro")
                        Return (Nothing)
                    End If
                Next
            Next

            'ObjCol.Sort("FechaRecepcion", Entity.SortDirection.Asc)

            For Each intNum As Integer In intNumeroArray

                For Each Obj As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In ObjCol

                    If intNum = Obj.NumeroIngreso Then
                        strNumDoc = Obj.ExpedienteNumero
                        Obj.ExpedienteNumero = "EXP. " & Obj.ExpedienteNumero & ", AUT. JUDICIAL: " & Obj.ExpedienteSalaJuzgado & ", SEC. " & IIf(Obj.ExpedienteSecretario.Trim = "" Or Obj.ExpedienteSecretario = "N/I", "NO INDICA", Obj.ExpedienteSecretario)
                        Select Case Obj.TipoActo
                            Case 1, 0 'ingreso

                                Dim intTipo As Integer = 1
                                Dim strIngresoTipo As String = ""
                                Dim strDocIng As String = ""
                                Dim lngFechaRecep As Long = 0
                                Dim strPenal As String = ""
                                Dim strObs As String = ""
                                Dim strPenalNombre As String = ""

                                strDocIng = Obj.DocumentoIngreso
                                lngFechaRecep = Obj.FechaRecepcion
                                strObs = Obj.DocumentoObservacion
                                strPenalNombre = Obj.PenalNombre

                                strPenal = ListarSituacionJuridicaPenal(InternoID, Obj.Codigo)
                                strIngresoTipo = ListarHistorialAntecendentesIngresoTipo(InternoID, Obj.Codigo)

                                Dim objEntCol2 As Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol = Nothing

                                Dim blnPrimero As Boolean = True
                                Dim intCount As Integer = 0
                                Dim lngIngID As Long = -1
                                Dim lngCodID As Long = -1

                                objEntCol2 = ListarHASituacionJuridicaExpediente(InternoID, Obj.IngresoID)
                                objEntCol2.Sort("FechaRecepcion", Entity.SortDirection.Asc)

                                For Each ObjEnt2 As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In objEntCol2
                                    intCount = intCount + 1
                                    lngIngID = ObjEnt2.IngresoID
                                    lngCodID = ObjEnt2.Codigo
                                Next

                                If intCount < 1 Then

                                    Dim objEnt As New Entity.Reporte.HistorialAntecedentes.SituacionJuridica

                                    With objEnt
                                        .NumeroIngreso = Obj.NumeroIngreso
                                        .IngresoID = Obj.IngresoID
                                        .TipoActo = Obj.TipoActo
                                        .FechaRecepcion = lngFechaRecep
                                        .DocumentoIngreso = strDocIng '& " , Destino E.P. : " & strPenal
                                        .DocumentoNumero = "F. DOC: " & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & ", DOC:" & strDocIng
                                        Select Case strIngresoTipo
                                            Case "INGRESO POR TRASLADO"
                                                .DocumentoNumero = "F. DOC:" & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & _
                                                                        ", DOC: " & strDocIng
                                                objEnt.NombreTipoDoc = Obj.NombreTipoDoc
                                            Case "INGRESO POR REVOCATORIA"
                                                .DocumentoNumero = "F. DOC:" & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & ", INGRESA CON Nº DOC: " & strDocIng
                                                objEnt.NombreTipoDoc = Obj.NombreTipoDoc & vbCrLf & "(REVOCATORIA)"
                                            Case Else
                                                .DocumentoNumero = "F. DOC:" & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & ", INGRESA CON Nº DOC: " & strDocIng
                                                objEnt.NombreTipoDoc = Obj.NombreTipoDoc
                                        End Select

                                        .IngresoPenal = strPenal
                                        .PenalNombre = strPenalNombre
                                        '.Observacion = strObs 'Obj.DocumentoObservacion
                                        .DocumentoObservacion = ""
                                        .ExpedienteSalaJuzgado = .ExpedienteSalaJuzgado.Trim
                                    End With

                                    '/*cabercera*/


                                    objEnt.PenalID = Obj.PenalID
                                    objEnt.InsertarLinea = "SI"
                                    objEnt.PenalNombre = Obj.PenalNombre


                                    objEnt.DocumentoNumero = objEnt.DocumentoNumero & "." & If(strObs.Length <= 0, "", vbCrLf & strObs)


                                    If objEnt.TipoActo = 1 Then  'si es ingreso X TRASLADO
                                        objEnt.ExpedienteNumero = ""
                                        objEnt.DocumentoObservacion = ""
                                        objEnt.DocumentoNumero = objEnt.DocumentoNumero '"INGRESO POR TRASLADO, " & objEnt.DocumentoNumero
                                        objEnt.NombreTipoDoc = "TRASLADO (I)"
                                    End If
                                    objEntCol.Add(objEnt)

                                Else

                                    For Each ObjEnt2 As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In objEntCol2

                                        Dim objEnt As New Entity.Reporte.HistorialAntecedentes.SituacionJuridica

                                        With objEnt
                                            If blnPrimero = True Then 'si tiene varios expedientes anexados al ingreso y es el primero???
                                                .TipoActo = Obj.TipoActo
                                                .FechaRecepcion = lngFechaRecep
                                                .DocumentoIngreso = strDocIng
                                                If .TipoActo = 1 Then
                                                    .DocumentoNumero = "F. DOC:" & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & _
                                                                        ", DOC:" & strDocIng
                                                Else
                                                    .DocumentoNumero = "F. DOC:" & If(ObjEnt2.FechaDocumentoString = "", "NO INDICA", ObjEnt2.FechaDocumentoString) & ", DOC:" & strDocIng 'analizar con la linea anterior
                                                End If
                                                .DocumentoNumero = .DocumentoNumero & "." & If(strObs.Length <= 0, "", vbCrLf & strObs)
                                                objEnt.NombreTipoDoc = Trim(Obj.NombreTipoDoc)

                                                If strIngresoTipo = "INGRESO POR REVOCATORIA" Then
                                                    objEnt.NombreTipoDoc = Obj.NombreTipoDoc & vbCrLf & "(REVOCATORIA)"
                                                End If
                                            Else
                                                .TipoActo = -1
                                                .NombreTipoDoc = ""
                                                .FechaRecepcion = 0
                                                .DocumentoIngreso = ""
                                                .DocumentoNumero = ""
                                            End If

                                            If lngIngID = ObjEnt2.IngresoID And lngCodID = ObjEnt2.Codigo Then
                                                .IngresoPenal = strPenal
                                            End If


                                            .IngresoID = ObjEnt2.IngresoID
                                            .ExpedienteID = ObjEnt2.ExpedienteID
                                            .Codigo = ObjEnt2.Codigo
                                            .NumeroIngreso = ObjEnt2.NumeroIngreso

                                            .DocumentoFecha = ObjEnt2.DocumentoFecha
                                            .DocumentoSalaJuzgado = ""
                                            .DocumentoSecretario = "NO INDICA"
                                            .DocumentoObservacion = ObjEnt2.DocumentoObservacion.Trim
                                            .ExpedienteNumero = "REF. EXP. " & ObjEnt2.ExpedienteNumero & ", AUT. JUDICIAL:" & ObjEnt2.ExpedienteSalaJuzgado & _
                                                                ", SEC. " & IIf(ObjEnt2.ExpedienteSecretario.Trim = "", "NO INDICA", ObjEnt2.ExpedienteSecretario) & "." & vbCrLf & _
                                                                ObjEnt2.Observacion2.Trim
                                            .ExpedienteSecretario = ""
                                            .ExpedienteSalaJuzgado = ""
                                            Select Case strIngresoTipo
                                                Case "INGRESO POR TRASLADO"
                                                    .Observacion2 = strIngresoTipo
                                                Case "INGRESO POR REVOCATORIA"
                                                    .Observacion2 = strIngresoTipo
                                                    '                                                    objEnt.NombreTipoDoc = Obj.NombreTipoDoc & vbCrLf & "(REVOCATORIA)"
                                                Case Else
                                                    .Observacion2 = ""
                                            End Select
                                            '.Observacion2 = If(strIngresoTipo = "INGRESO POR TRASLADO", "INGRESO POR TRASLADO", "")
                                            '.PenalNombre = ObjEnt2.PenalNombre
                                            blnPrimero = False
                                        End With

                                        '/*cabercera*/
                                        objEnt.InsertarLinea = "SI"
                                        objEnt.PenalID = Obj.PenalID
                                        objEnt.PenalNombre = Obj.PenalNombre
                                        If Obj.TipoActo = 1 Then  'si es ingreso X TRASLADO
                                            objEnt.ExpedienteNumero = ""
                                            objEnt.DocumentoObservacion = ""
                                            objEnt.NombreTipoDoc = "TRASLADO (I)"
                                        End If

                                        objEntCol.Add(objEnt)
                                    Next

                                End If

                            Case 2 'Traslado
                                Obj.DocumentoNumero = "F. DOC:" & Obj.FechaDocumentoString & ", F. MOV.:" & Obj.FechaRecepcionString & ", ORDENA:" & If(Obj.DocumentoSalaJuzgado.Trim = "", "NO INDICA", Obj.DocumentoSalaJuzgado) & _
                                                      " CON Nº DOC:" & Obj.DocumentoNumero & " POR MOTIVO:" & Obj.MotivoTrasladoNombre
                                Obj.ExpedienteNumero = ""
                                Obj.ExpedienteSecretario = ""
                                Obj.DocumentoSalaJuzgado = ""

                                If Obj.TipoTrasladoNombre = "INGRESO POR TRASLADO" Or Obj.TipoTrasladoNombre = "RETORNO POR TRASLADO" Then
                                    Obj.Observacion = ", ORIGEN:" & If(Obj.PenalID > 0, "E.P. ", "") & Obj.PenalNombre
                                    Obj.NombreTipoDoc = "TRASLADO (I)"
                                Else
                                    Obj.Observacion = ", DESTINO:" & If(Obj.PenalDestinoID > 0, "E.P. ", "") & Obj.PenalDestinoNombre
                                    Obj.NombreTipoDoc = "TRASLADO (E)"
                                End If
                                Obj.DocumentoNumero = Obj.DocumentoNumero & Obj.Observacion & "."
                                Obj.Observacion = ""
                                Obj.Observacion2 = "REF. DOC: " & strNumDoc

                            Case 3 'detencion -expediente
                                Obj.DocumentoNumero = ""
                                Obj.DocumentoSecretario = "NO INDICA"
                                Obj.DocumentoSalaJuzgado = ""
                                Obj.ExpedienteNumero = "Nº EXP/OF:" & strNumDoc & " AUT. JUDICIAL:" & Obj.ExpedienteSalaJuzgado & " SEC:" & IIf(Obj.ExpedienteSecretario.Trim = "", "NO INDICA", Obj.ExpedienteSecretario) & "."
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)
                                Obj.ExpedienteSalaJuzgado = ""
                                Obj.Observacion = ""

                            Case 4 '5, 6, 7, 8, 9, 10, 11, 13, 14 'ejecutoria suprema, ejecutoria superior, sustitucion de pena, adecuacion de pena, refundicion de sentencia, integracion de pena, conmutacion de pena, sentencia consentida
                                Obj.DocumentoSalaJuzgado = If(Obj.DocumentoSalaJuzgado.Trim = "", "", " ORDENA:" & Obj.DocumentoSalaJuzgado)

                                Dim fecSent As String = ""
                                Obj.DocumentoNumero = Obj.DocumentoSalaJuzgado & ", SEC:" & If(Obj.DocumentoSecretario.Trim = "", "NO INDICA", Obj.DocumentoSecretario) & _
                                                      ",  N° DOC:" & Obj.DocumentoNumero & ", " & ListarSituacionJuridicaSentencia(InternoID, Obj.Codigo, fecSent) & "."

                                'Obj.DocumentoNumero = "F. DOC:" & Obj.FechaDocumentoString & ", " & fecSent & ", " & Obj.DocumentoNumero
                                Obj.DocumentoNumero = fecSent & ", " & Obj.DocumentoNumero
                                Obj.ExpedienteNumero = "REF. EXP. " & strNumDoc & ", AUT. JUDICIAL:" & Obj.ExpedienteSalaJuzgado & ", SEC:" & IIf(Obj.ExpedienteSecretario.Trim = "", "NO INDICA", Obj.ExpedienteSecretario) & "."
                                Obj.Observacion2 = Obj.ExpedienteNumero & vbCrLf & ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)
                                Obj.DocumentoSalaJuzgado = ""
                                Obj.ExpedienteSalaJuzgado = ""
                                Obj.ExpedienteNumero = ""
                                Obj.Observacion = ""

                            Case 5, 6 'fallecimiento, fuga
                                Dim strLibertadTipo As String = ""
                                strLibertadTipo = ListarHistorialAntecendentesLibertadTipo(InternoID, Obj.Codigo)

                                Obj.DocumentoNumero = "F. DOC:" & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & ", " & " CON DOC:" & Obj.DocumentoNumero & "."

                                Obj.Observacion = ""
                                Obj.Observacion2 = ""
                                Obj.ExpedienteNumero = ""
                                Obj.DocumentoSalaJuzgado = ""
                                Obj.ExpedienteSalaJuzgado = ""

                            Case 7 'libertades
                                Dim strLibertadTipo As String = ""
                                strLibertadTipo = ListarHistorialAntecendentesLibertadTipo(InternoID, Obj.Codigo)

                                Obj.DocumentoNumero = "F. DOC:" & If(Obj.FechaDocumentoString = "", "NO INDICA", Obj.FechaDocumentoString) & "  AUT. JUDICIAL:" & Obj.DocumentoSalaJuzgado & _
                                                      ", SEC:" & If(Obj.DocumentoSecretario.Trim = "", "NO INDICA", Obj.DocumentoSecretario) & ", " & " CON DOC:" & Obj.DocumentoNumero & _
                                                      ", TIPO LIBERTAD:" & strLibertadTipo & "."

                                Obj.Observacion = ""
                                Obj.Observacion2 = Obj.ExpedienteNumero & vbCrLf & ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)
                                Obj.ExpedienteNumero = ""
                                Obj.DocumentoSalaJuzgado = ""
                                Obj.ExpedienteSalaJuzgado = ""

                            Case Else

                                Obj.DocumentoNumero = "N° DOC:" & Obj.DocumentoNumero & " SEC:" & If(Obj.DocumentoSecretario.Trim = "", "NO INDICA", Obj.DocumentoSecretario) & "."

                                Obj.Observacion = ""
                                Obj.Observacion2 = ListarSituacionJuridicaDelitoAgraviado(InternoID, Obj.IngresoID, Obj.ExpedienteID)
                        End Select

                        If Obj.TipoActo <> 1 And Obj.TipoActo <> 0 Then 'ingreso
                            objEntCol.Add(Obj)
                        End If
                    Else

                    End If
                Next

            Next


            'Dim ss As String = ""

            ' Dim lis As New List(Of Entity.Reporte.HistorialAntecedentes.SituacionJuridica)

            'Dim Tmp As New Entity.Reporte.HistorialAntecedentes.SituacionJuridica
            'For Each o1 As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In objEntCol
            '    lis.Add(o1)
            'Next


            'For I As Integer = 0 To lis.Count - 1
            '    For J As Integer = 0 To lis.Count - 1
            '        If lis.Item(I).FechaRecepcion < lis.Item(J).FechaRecepcion Then
            '            Tmp = lis.Item(I)
            '            lis.Item(I) = lis.Item(J)
            '            lis.Item(J) = Tmp
            '        End If
            '    Next
            'Next

            'Tmp = New Entity.Reporte.HistorialAntecedentes.SituacionJuridica
            'For I As Integer = 0 To lis.Count - 1
            '    If I + 1 > lis.Count - 1 Then Exit For

            '    If lis.Item(I).FechaRecepcion = lis.Item(I + 1).FechaRecepcion Then
            '        For J As Integer = I + 1 To lis.Count - 1
            '            If lis.Item(I).FechaRecepcion = lis.Item(J).FechaRecepcion And lis.Item(I).DocumentoFecha > lis.Item(J).DocumentoFecha Then
            '                Tmp = lis.Item(I)
            '                lis.Item(I) = lis.Item(J)
            '                lis.Item(J) = Tmp
            '            End If
            '        Next
            '    End If
            'Next


            'Dim colTmp As New Entity.Reporte.HistorialAntecedentes.SituacionJuridicaCol
            'For Each obj As Entity.Reporte.HistorialAntecedentes.SituacionJuridica In lis
            '    colTmp.Add(obj)
            'Next

            Return objEntCol

        End Function

        Private Function ListarHASitJuridicaNombre(ByVal InternoID As Integer, _
ByVal ExpedienteID As Long) As String

            Dim value As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_nombre", _
            -1, -1, -1, InternoID, -1, ExpedienteID, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        value = sqlDr("sit_jur_nom").ToString
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

            Return value

        End Function
        Private Function ListarHATipoLibertad(ByVal TipoActo As Integer, ByVal NumeroIngreso As Integer, _
ByVal InternoID As Integer, _
ByVal Codigo As Long) As String

            Dim value As String = ""

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_situacion_juridica_tipo_libertad", _
            -1, -1, -1, InternoID, -1, Codigo, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        value = sqlDr("tip_lib_nom").ToString
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

            Return value

        End Function
        Private Function ListarHistorialAntecendentesIngresoTipo(ByVal InternoID As Integer, ByVal IngresoID As Long) As String

            Dim value As String = ""
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_historial_antecedentes_ingreso_tipo", _
            -1, -1, -1, InternoID, IngresoID, -1, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        value = sqlDr("ing_mot_nom").ToString
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

            Return value

        End Function
        Private Function ListarHistorialAntecendentesLibertadTipo(ByVal InternoID As Integer, ByVal ExpedienteID As Long) As String

            Dim value As String = ""
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, "lst", _
                                                                                    "lst_historial_antecedentes_libertad_tipo", _
            -1, -1, -1, InternoID, -1, ExpedienteID, -1, -1, 0, 0)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        value = sqlDr("tip_lib_nom").ToString
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

            Return value

        End Function
#End Region


        Public Function FichaIdentificacionAsistencia(ByVal InternoID As Integer) As Entity.Reporte.Tratamiento.FichaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, _
            "lst", "lst_ficha_interno2", -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol

            Try
                If sqlDr.HasRows Then

                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Tratamiento.Ficha

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .OtroDocumento = ""
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Hononimo = "???"
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString

                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hij_men").ToString
                            If .NumeroHijos < 1 Then
                                .NumeroHijos = 0
                            End If

                            .TipoLocal = intTipoLocal
                            .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                            .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                            '/*datos de localidad de nacimiento*/                            
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .NacimientoPais = sqlDr("pai_nom").ToString
                            .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                            .Religion = ""
                            .Idioma = ""
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
                            .FuerzaArmanda = ""
                            .Rango = ""
                            '/*caracteristicas notables fisicas, señas cicatrices*/                           
                            '.RasgoCol = ListarRasgos(InternoID)
                            .AsistenciaCol = ListarAsistencia(InternoID)
                            '/*nombres asociados, alias, bandas*/
                            .NombresAsociados = ListarNombresAsociados(InternoID)
                            .AliasNombres = ListarAlias(InternoID)
                            .Bandas = ListarBandas(InternoID)
                            '/*datos del ultimo internamiento*/
                            .InternoIngresoID = sqlDr("int_ing_id").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString
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
        Public Function FichaIdentificacionListaAsistencia(ByVal InternoID As Integer) As Entity.Reporte.Tratamiento.AsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Registro.Listar(sqlCon, _
            "lst", "lst_asistencia2", -1, -1, -1, InternoID, -1, -1, -1, -1, 0, 0)

            Dim objEntCol As New Entity.Reporte.Tratamiento.AsistenciaCol

            Try
                If sqlDr.HasRows Then

                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Tratamiento.Asistencia

                        With objEnt
                            .HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            ''.CodigoRP = sqlDr("int_cod_rp").ToString
                            ''/*datos de identificacion*/
                            '.ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            '.ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            '.Nombres = sqlDr("int_nom").ToString
                            '.TipoDocumento = sqlDr("tip_doc_nom").ToString
                            '.NumeroDocumento = sqlDr("int_doc_num").ToString
                            '.OtroDocumento = ""
                            '.FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            '.FechaNacimiento = sqlDr("int_fec_nac").ToString
                            '.SexoID = sqlDr("sex_id").ToString
                            '.EstadoCivil = sqlDr("est_nom").ToString
                            '.Hononimo = "???"
                            '.Padre = sqlDr("pad_nom").ToString
                            '.Madre = sqlDr("mad_nom").ToString
                            '.Conyugue = sqlDr("coy_nom").ToString
                            '.HijosMenores = sqlDr("int_hij_men").ToString

                            ''numeros de hijos
                            '.NumeroHijos = sqlDr("int_hij_men").ToString
                            'If .NumeroHijos < 1 Then
                            '    .NumeroHijos = 0
                            'End If

                            '.TipoLocal = intTipoLocal
                            '.FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                            '.FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                            ''/*datos de localidad de nacimiento*/                            
                            '.Nacionalidad = sqlDr("nac_nom").ToString
                            '.NacimientoPais = sqlDr("pai_nom").ToString
                            '.NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            '.NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            '.NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            '.NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                            '.Religion = ""
                            '.Idioma = ""
                            ''/*datos domicilios*/
                            '.DomicilioDepartamento = sqlDr("dom_dep").ToString
                            '.DomicilioProvincia = sqlDr("dom_pro").ToString
                            '.DomicilioDistrito = sqlDr("dom_dis").ToString
                            '.Domicilio = sqlDr("dir_nom").ToString
                            ''datos complementarios
                            '.GradoInstruccion = sqlDr("grd_ins_nom").ToString
                            '.Profesion = sqlDr("pro_nom").ToString
                            '.CentroTrabajo = ""
                            '.Ocupacion = sqlDr("ocu_nom").ToString
                            '.FuerzaArmanda = ""
                            '.Rango = ""
                            ''/*caracteristicas notables fisicas, señas cicatrices*/                           
                            ''.RasgoCol = ListarRasgos(InternoID)
                            '.AsistenciaCol = ListarAsistencia(InternoID)
                            ''/*nombres asociados, alias, bandas*/
                            '.NombresAsociados = ListarNombresAsociados(InternoID)
                            '.AliasNombres = ListarAlias(InternoID)
                            '.Bandas = ListarBandas(InternoID)
                            ''/*datos del ultimo internamiento*/
                            '.InternoIngresoID = sqlDr("int_ing_id").ToString
                            '.TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            '.FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            '.NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            '.PenalActual = sqlDr("int_ing_pen_nom").ToString
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
        '/*Asistencia*/
        Public Function FichaIdentificacion(ByVal ent As Entity.Reporte.Registro.Filtro) As Entity.Reporte.Tratamiento.FichaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Reporte.Tratamiento.Listar(sqlCon, "lst", "lst_ficha_interno_asi", ent)

            Dim objEntCol As New Entity.Reporte.Tratamiento.FichaCol

            Try
                If sqlDr.HasRows Then

                    Dim objBssLicencia As New Bussines.Sistema.Instalacion
                    Dim intTipoLocal As Integer = objBssLicencia.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo


                    While sqlDr.Read
                        Dim objEnt As New Entity.Reporte.Tratamiento.Ficha

                        With objEnt
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            '/*datos de identificacion*/
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumento = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .OtroDocumento = ""
                            .FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .EstadoCivil = sqlDr("est_nom").ToString
                            .Hononimo = "???"
                            .Padre = sqlDr("pad_nom").ToString
                            .Madre = sqlDr("mad_nom").ToString
                            .Conyugue = sqlDr("coy_nom").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString

                            'numeros de hijos
                            .NumeroHijos = sqlDr("int_hij_men").ToString
                            If .NumeroHijos < 1 Then
                                .NumeroHijos = 0
                            End If

                            .TipoLocal = intTipoLocal
                            .FotoPerfilCentral = sqlDr("pth_fot_fre").ToString
                            .FotoPerfilIzquierdo = sqlDr("pth_fot_izq").ToString
                            '/*datos de localidad de nacimiento*/                            
                            .Nacionalidad = sqlDr("nac_nom").ToString
                            .NacimientoPais = sqlDr("pai_nom").ToString
                            .NacimientoDepartamento = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvincia = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistrito = sqlDr("nac_dis_nom").ToString
                            .NacimientoLugar = sqlDr("ubg_nac_otro").ToString
                            .Religion = ""
                            .Idioma = ""
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
                            .FuerzaArmanda = ""
                            .Rango = ""
                            '/*caracteristicas notables fisicas, señas cicatrices*/                           
                            '.RasgoCol = ListarRasgos(ent.InternoID)
                            '.SenasParticulares = ListarSenasParticulares(ent.InternoID)
                            '/*nombres asociados, alias, bandas*/
                            .NombresAsociados = ListarNombresAsociados(ent.InternoID)
                            .AliasNombres = ListarAlias(ent.InternoID)
                            .Bandas = ListarBandas(ent.InternoID)
                            '/*datos del ultimo internamiento*/
                            .InternoIngresoID = sqlDr("int_ing_id").ToString
                            .TipoIngreso = sqlDr("int_ing_mot_nom").ToString
                            .FechaIngresoPenal = sqlDr("int_ing_fec_ing").ToString
                            .NumeroIngreso = sqlDr("int_ing_num_ing").ToString
                            .PenalActual = sqlDr("int_ing_pen_nom").ToString
                            .CentroTrabajo = sqlDr("c_tra_tal_nom").ToString
                            .FechaIni = sqlDr("n_fec_ini").ToString
                            .FechaFin = sqlDr("n_fec_fin").ToString
                            .Estado = sqlDr("int_est_nom").ToString
                            .Delitos = ListarExpedienteDelitosInternamiento(ent.InternoID, .InternoIngresoID)
                            '/*situacion juridica*/
                            .SituacionJuridica = ListarSituacionJuridica(ent.InternoID)
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .LicenciaPenalNombre = sqlDr("lic_pen_nom").ToString
                            .LicenciaRegionNombre = sqlDr("lic_reg_nom").ToString
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
    End Class
End Namespace