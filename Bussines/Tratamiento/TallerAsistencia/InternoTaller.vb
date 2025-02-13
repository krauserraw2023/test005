Imports System.Data
Imports System.Data.SqlClient
Imports Bussines.Globall.UtilAccesoBD
Namespace Tratamiento.TallerAsistencia
    Public Class InternoTaller
        'Private objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller  = Nothing
        'Private objEntCol As Entity.Tratamiento.TallerAsistencia.InternoTallerCol = Nothing
#Region "ws_biometrico_facial"
        ''' <summary>
        ''' Inicia sesion en el servicio biometrico de BIOSTAR.
        ''' </summary>
        ''' <param name="ws">Servicio web ya instanciado</param>
        ''' <param name="out_SMS"></param>
        ''' <returns></returns>
        Public Function WS_IniciarLoggin(ws As APPWebService.ws_pope_ep_trat_asist_tall.ApiBiostarClient, out_SMS As String) As Boolean
            Dim v As Boolean = True
            Dim out_Error As String = ""

            Dim ApiIP As String = ""
            Dim SubDominio As String = ""
            Dim pass As String = ""
            Dim userId As String = ""

            Try 'loguearse
                ApiIP = Legolas.LBusiness.Globall.WinApp.ListarString("tra_tall_ip_api_bio", -1)
                userId = Legolas.LBusiness.Globall.WinApp.ListarString("tra_tall_user_id_bio", -1)
                pass = Legolas.LBusiness.Globall.WinApp.ListarString("tra_tall_pass_bio", -1)
                SubDominio = Legolas.LBusiness.Globall.WinApp.ListarString("tra_tall_sub_dom_bio", -1)

                ws.Login_API(out_Error, "", ApiIP, SubDominio, pass, userId)

                If out_Error.Length > 0 Then 'segundo intento
                    out_Error = ""
                    ws.Login_API(out_Error, "", ApiIP, SubDominio, pass, userId)

                    If out_Error.Length > 0 Then
                        out_SMS = out_Error
                        v = False
                    End If
                End If

            Catch ex As Exception 'segundo intento tras una excepcion
                Try
                    ws.Login_API(out_Error, "", ApiIP, SubDominio, pass, userId)

                    If out_Error.Length > 0 Then
                        out_SMS = out_Error
                        v = False
                    End If

                Catch ex2 As Exception
                    out_SMS = ex2.ToString
                    v = False
                End Try
            End Try

            Return v
        End Function
#End Region
#Region "Validar"

        Public Function ValidarNumeroDocumento(objInt As Entity.Registro.Interno) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0

            If objInt.Codigo < 1 Then
                intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_numero_documento", objInt)
                If intvalue > 0 Then
                    value = False
                End If
            Else
                intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_numero_documento_his", objInt)
                If intvalue > 0 Then
                    value = False
                End If
            End If
            Return value

        End Function

#End Region

#Region "Listar"
        Public Function Listar(Codigo As Integer) As Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller = Nothing
            Dim ent As New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            ent.Codigo = Codigo

            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant", ent)

            objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = Isnulll(sqlDr("pk_tal_int_id"), -1).ToString
                            .InternoID = sqlDr("kf_int_id")
                            .CodigoMarcacionID = Isnulll(sqlDr("tra_asi_tal_cod_mar"), -1).ToString
                            .BioRegistroVinculado = sqlDr("b_reg_vinc_bio")
                            'los demas agregar en funcion a necesidad
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return objEnt
        End Function
        Public Function Listar(objEntInterno As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTaller
            Dim objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_tal_v2", objEntInterno)

            objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = Isnulll(sqlDr("pk_tal_int_id"), -1).ToString
                            .InternoID = Isnulll(sqlDr("int_id"), -1).ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .CodigoMarcacionID = Isnulll(sqlDr("tra_asi_tal_cod_mar"), -1).ToString
                            .ApellidoPaterno = Isnulll(sqlDr("int_ape_pat"), "").ToString
                            .ApellidoMaterno = Isnulll(sqlDr("int_ape_mat"), "").ToString
                            .Nombres = Isnulll(sqlDr("int_nom"), "").ToString
                            .SexoID = Isnulll(sqlDr("sex_id"), -1).ToString
                            .FechaNacimiento = Isnulll(sqlDr("int_fec_nac"), -1).ToString
                            .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .TipoDocumentoID = Isnulll(sqlDr("tip_doc_id"), -1).ToString
                            .TipoDocumentoNombre = Isnulll(sqlDr("tip_doc_nom"), "").ToString
                            .NumeroDocumento = Isnulll(sqlDr("int_doc_num"), "").ToString
                            .EstadoCivilID = Isnulll(sqlDr("est_civ_id"), -1).ToString
                            .EstadoCivilNombre = Isnulll(sqlDr("est_civ_nom"), "").ToString
                            .NombrePadre = Isnulll(sqlDr("aut_fam_pad"), "").ToString
                            .NombreMadre = Isnulll(sqlDr("aut_fam_mad"), "").ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            '/*Datos del taller*/
                            .NombreTaller = Isnulll(sqlDr("c_tra_tal_nom"), "").ToString
                            .PabellonNombre = Isnulll(sqlDr("c_tra_tal_pab"), "").ToString
                            .FechaInscripcion = Isnulll(sqlDr("n_tal_asi_fec"), 0).ToString
                            .FechaRetiro = Isnulll(sqlDr("tra_asi_tal_fec_ret"), 0).ToString
                            .ResponsableLaboral = Isnulll(sqlDr("c_tra_tal_res"), "").ToString
                            .GestorProduccion = Isnulll(sqlDr("c_tra_tal_ges"), "").ToString
                            '/*Ubigeo nac - region y penal*/
                            .NacimientoPaisNombre = sqlDr("nac_pai_nom").ToString
                            .NacimientoDepartamentoNombre = sqlDr("nac_dep_nom").ToString
                            .NacimientoProvinciaNombre = sqlDr("nac_pro_nom").ToString
                            .NacimientoDistritoNombre = sqlDr("nac_dis_nom").ToString
                            .RegionID = Isnulll(sqlDr("reg_id"), -1).ToString
                            .RegionNombre = Isnulll(sqlDr("reg_nom"), "").ToString
                            .PenalID = Isnulll(sqlDr("pen_id"), -1).ToString
                            .PenalNombre = Isnulll(sqlDr("pen_nom"), "").ToString
                            '/*Otros*/
                            .FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
                            .GrupoAcceso = sqlDr("c_grup_acces").ToString
                            .GrupoUsuario = sqlDr("c_grup_usu").ToString
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return objEnt
        End Function
        Public Function ListarBus(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_bus", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
                        Contador += 1
                        With objEnt
                            .CodigoTaller = sqlDr("pk_tra_tal_id").ToString
                            .Contador = Contador
                            .InternoID = sqlDr("int_id").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            '.TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
                            '.NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            .Fecha = sqlDr("n_tal_fec").ToString
                            '/*fotos*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            .NombreTaller = sqlDr("c_tra_tal_nom").ToString.ToUpper
                            'Taller
                            '.CodigoTaller = sqlDr("int_tal_id").ToString
                            '.NombreTaller = sqlDr("c_tra_tal_nom").ToString
                            '.NombreActividad = sqlDr("c_tra_tal_act_nom").ToString
                            '.NombreTipoActividad = sqlDr("c_tra_tal_tip_act_nom").ToString
                            '.FechaPrimera = sqlDr("n_tal_asi_fec").ToString
                            '.FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
                            '.InternoHuellaID = Isnulll(sqlDr("pk_int_hue_id"), -1).ToString
                            '.TipoCapturaDerID = Isnulll(sqlDr("n_int_hue_tip_cap_Der"), -1).ToString
                            '.TipoCapturaIzqID = Isnulll(sqlDr("n_int_hue_tip_cap_Izq"), -1).ToString
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

        Public Function ListarInt(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_int", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .InternoID = sqlDr("int_id").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            .Fecha = sqlDr("n_tal_fec").ToString
                            '/*fotos*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            'Taller
                            .CodigoTaller = sqlDr("int_tal_id").ToString
                            .NombreTaller = sqlDr("c_tra_tal_nom").ToString
                            .NombreActividad = sqlDr("c_tra_tal_act_nom").ToString
                            .NombreTipoActividad = sqlDr("c_tra_tal_tip_act_nom").ToString
                            '.FechaPrimera = sqlDr("n_tal_asi_fec").ToString
                            '.FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
                            .InternoHuellaID = Isnulll(sqlDr("pk_int_hue_id"), -1).ToString
                            .TipoCapturaDerID = Isnulll(sqlDr("n_int_hue_tip_cap_Der"), -1).ToString
                            .TipoCapturaIzqID = Isnulll(sqlDr("n_int_hue_tip_cap_Izq"), -1).ToString
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

        Public Function ListarInt_v2(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_int_v2", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .InternoID = sqlDr("int_id").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            .Fecha = sqlDr("n_tal_fec").ToString
                            '/*fotos*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            'Taller
                            .CodigoTaller = sqlDr("int_tal_id").ToString
                            .NombreTaller = sqlDr("c_tra_tal_nom").ToString
                            .NombreActividad = sqlDr("c_tra_tal_act_nom").ToString
                            .NombreTipoActividad = sqlDr("c_tra_tal_tip_act_nom").ToString
                            '.FechaPrimera = sqlDr("n_tal_asi_fec").ToString
                            '.FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
                            '.InternoHuellaID = Isnulll(sqlDr("pk_int_hue_id"), -1).ToString
                            '.TipoCapturaDerID = Isnulll(sqlDr("n_int_hue_tip_cap_Der"), -1).ToString
                            '.TipoCapturaIzqID = Isnulll(sqlDr("n_int_hue_tip_cap_Izq"), -1).ToString
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

        'Public Function ListarCol(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
        '    objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
        '    Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '    Dim Contador As Integer = 0
        '    Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_tal", objEnt)
        '    Try
        '        If sqlDr.HasRows Then
        '            While sqlDr.Read
        '                objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
        '                Contador += 1
        '                With objEnt
        '                    .Contador = Contador
        '                    .InternoID = sqlDr("int_id").ToString
        '                    .CodigoPadre = sqlDr("int_pdr").ToString
        '                    .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
        '                    .ApellidoPaterno = sqlDr("int_ape_pat").ToString
        '                    .ApellidoMaterno = sqlDr("int_ape_mat").ToString
        '                    .Nombres = sqlDr("int_nom").ToString
        '                    .TipoDocumentoID = sqlDr("tip_doc_id").ToString
        '                    .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
        '                    .NumeroDocumento = sqlDr("int_doc_num").ToString
        '                    .SexoID = sqlDr("sex_id").ToString
        '                    .FechaNacimiento = sqlDr("int_fec_nac").ToString
        '                    .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
        '                    .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
        '                    .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
        '                    .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
        '                    .Fecha = sqlDr("n_tal_fec").ToString
        '                    '/*fotos*/
        '                    .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
        '                    .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
        '                    .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
        '                    'Taller
        '                    .CodigoTaller = sqlDr("int_tal_id").ToString
        '                    .NombreTaller = sqlDr("c_tra_tal_nom").ToString
        '                    .NombreActividad = sqlDr("c_tra_tal_act_nom").ToString
        '                    .NombreTipoActividad = sqlDr("c_tra_tal_tip_act_nom").ToString
        '                    .FechaInscripcion = sqlDr("n_tal_asi_fec").ToString
        '                    '.FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
        '                    .InternoHuellaID = Isnulll(sqlDr("pk_int_hue_id"), -1).ToString
        '                    .TipoCapturaDerID = Isnulll(sqlDr("n_int_hue_tip_cap_Der"), -1).ToString
        '                    .TipoCapturaIzqID = Isnulll(sqlDr("n_int_hue_tip_cap_Izq"), -1).ToString
        '                End With
        '                objEntCol.Add(objEnt)
        '                ' Legolas.Configuration.Aplication.MessageBox.Exclamation(objEnt.Codigo)
        '            End While
        '        End If
        '    Catch ex As Exception
        '        'Throw New Exception(ex.ToString)
        '        Legolas.Configuration.Aplication.MessageBox.Exclamation(ex.ToString)
        '    Finally
        '        sqlDr.Dispose()
        '        sqlDr.Close()
        '        sqlDr = Nothing
        '    End Try
        '    Return objEntCol
        'End Function
        Public Function ListarCol_v2(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_tal_v2", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
                        Contador += 1
                        With objEnt
                            .Codigo = sqlDr("pk_tal_int_id").ToString
                            .Contador = Contador
                            .InternoID = sqlDr("int_id").ToString
                            .CodigoPadre = sqlDr("int_pdr").ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacionalidadID = Isnulll(sqlDr("nac_id"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .EstadoLaboralID = Isnulll(sqlDr("int_est_lab_id"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            .Fecha = sqlDr("n_tal_fec").ToString
                            '/*fotos*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            'Taller
                            .CodigoTaller = sqlDr("int_tal_id").ToString
                            .NombreTaller = sqlDr("c_tra_tal_nom").ToString
                            .NombreActividad = sqlDr("c_tra_tal_act_nom").ToString
                            .NombreTipoActividad = sqlDr("c_tra_tal_tip_act_nom").ToString
                            .FechaInscripcion = sqlDr("n_tal_asi_fec").ToString
                            '.FechaIngreso = Isnulll(sqlDr("int_ing_fec"), 0).ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .BioRegistroVinculado = sqlDr("b_reg_vinc_bio").ToString
                        End With
                        objEntCol.Add(objEnt)
                        ' Legolas.Configuration.Aplication.MessageBox.Exclamation(objEnt.Codigo)
                    End While
                End If
            Catch ex As Exception
                'Throw New Exception(ex.ToString)
                Legolas.Configuration.Aplication.MessageBox.Exclamation(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return objEntCol
        End Function

        Public Function ListarTaller_v2(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim objEntCol As New Entity.Tratamiento.TallerAsistencia.InternoTallerCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoTaller.Listar(sqlCon, "lst", "lst_mant_v2", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .Codigo = Isnulll(sqlDr("pk_tra_tal_id"), -1).ToString
                            .CodigoTaller = Isnulll(sqlDr("int_tal_id"), -1).ToString
                            .NombreTaller = Isnulll(sqlDr("c_tra_tal_nom"), "").ToString
                            .NombreActividad = Isnulll(sqlDr("c_tra_tal_act_nom"), "").ToString
                            .NombreTipoActividad = Isnulll(sqlDr("c_tra_tal_tip_act_nom"), "").ToString
                            .Fecha = Isnulll(sqlDr("n_tal_asi_fec"), "").ToString
                            .EstadoID = Isnulll(sqlDr("tra_asi_tal_int_est"), "").ToString
                            'Datos retiro
                            .MotivoRetiroID = Isnulll(sqlDr("tra_asi_tal_mot_ret"), -1).ToString
                            .MotivoRetiroNombre = Isnulll(sqlDr("tra_asi_tal_mot_nom"), "").ToString
                            .FechaRetiro = Isnulll(sqlDr("tra_asi_tal_fec_ret"), 0).ToString
                            .DocumentoRetiro = Isnulll(sqlDr("tra_asi_tal_doc_ret"), "").ToString
                            .FechaDocumento = Isnulll(sqlDr("tra_asi_tal_fec_fin"), 0).ToString
                            .ObservacionRetiro = Isnulll(sqlDr("tra_asi_tal_obs_ret"), "").ToString
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
#Region "Listar_Huella"
        'Public Function BuscarHuella(IDTemplate As Integer, IDRegion As Short, IDPenal As Short) As Integer

        '    Dim value As Integer = -1

        '    If IDTemplate < 1 Then
        '        Return value
        '    End If

        '    Dim strMensajeError As String = ""
        '    Dim intIDHuella As Integer = -1

        '    '1.- buscar en la tabla huella digital
        '    'Dim objBssHueDig As New Bussines.Biometria.HuellaDigital
        '    'Dim objEntFiltroHueDig As New Entity.Biometria.HuellaDigital

        '    'With objEntFiltroHueDig
        '    '    .IDTemplateHuella = IDTemplate
        '    '    .IDRegion = IDRegion
        '    '    .IDPenal = IDPenal
        '    'End With

        '    'intIDHuella = objBssHueDig.BuscarIDHuella(objEntFiltroHueDig, strMensajeError)

        '    '2.- buscar en la tabla visitante huella
        '    'If intIDHuella > 0 Then

        '    Dim objBssHueVis As New Bussines.Biometria.InternoHuellaTratamiento
        '    Dim objEntFiltroHueVis As New Entity.Biometria.InternoHuellaTratamiento

        '    With objEntFiltroHueVis
        '        .IDIndiceIzquierdo = intIDHuella
        '        .IDIndiceDerecho = intIDHuella
        '        .IDPulgarIzquierdo = intIDHuella
        '        .IDPulgarDerecho = intIDHuella
        '        .IDRegion = IDRegion
        '        .IDPenal = IDPenal
        '    End With

        '    value = objBssHueVis.BuscarIDInterno(objEntFiltroHueVis, strMensajeError)

        '    'End If

        '    Return value

        'End Function
#End Region

#Region "Grabar"

        'Public Function Grabar(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Integer

        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""

        '    If objEnt.Codigo < 1 Then
        '        strAccion = "ins"
        '        strOpcion = "ins_mant"
        '    Else
        '        strAccion = "upd"
        '        strOpcion = "upd_mant"
        '    End If

        '    intValue = Data.Tratamiento.TallerAsistencia.InternoTaller.Grabar(strAccion, strOpcion, objEnt)

        '    Return intValue
        'End Function
        Public Function Grabar_v2(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v2"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Tratamiento.TallerAsistencia.InternoTaller.Grabar_v2(strAccion, strOpcion, objEnt)

            Return intValue
        End Function
        Public Function GrabarEstado(objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_est"

            intValue = Data.Tratamiento.TallerAsistencia.InternoTaller.Grabar_v2(strAccion, strOpcion, objEnt)

            Return intValue
        End Function

        Public Function GrabarEstadoRegVinculacion(Codigo As Integer, RegistroVinculado As Boolean) As Integer
            Dim objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller = Nothing
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_est_bio_vinculado"
            objEnt = New Entity.Tratamiento.TallerAsistencia.InternoTaller
            objEnt.Codigo = Codigo
            objEnt.BioRegistroVinculado = RegistroVinculado
            intValue = Data.Tratamiento.TallerAsistencia.InternoTaller.Grabar_v2(strAccion, strOpcion, objEnt)

            Return intValue
        End Function
#End Region

#Region "Eliminar"
        'Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

        '    Dim intValue As Integer = -1
        '    Dim strAccion As String = ""
        '    Dim strOpcion As String = ""
        '    strAccion = "del"
        '    strOpcion = "del_mant"
        '    intValue = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo, _
        '    Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
        '    Return intValue

        'End Function

#End Region
    End Class
End Namespace
