Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Namespace Registro
    Public Class Interno
        Private objEnt As Entity.Registro.Interno = Nothing
        Private objEntCol As Entity.Registro.InternoCol = Nothing
#Region "Functions"
        Public Shared Function ResetInternoCodigo(ByVal InternoCodigo As String, ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = False
            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_reset_InternoCodigo", -1,
                                                          InternoCodigo, -1, "", "", "", "",
                                                      RegionID, PenalID)
            If intvalue > 0 Then
                value = True
            End If

            Return value

        End Function
        Public Shared Function EstadoNombre(ByVal InternoID As Integer) As String

            Dim value As String = ""
            Dim intEstado As Integer = -1
            Dim strEstado As String = ""

            intEstado = Data.Registro.Interno.ListarOutput("lst", "lst_interno_estado", InternoID,
                                                           "", -1, "", "", "", "", -1, -1)

            Select Case intEstado
                Case 0
                    strEstado = "Inactivo"
                Case 1
                    strEstado = "Activo"
                Case Else
                    strEstado = ""
            End Select

            value = strEstado.ToUpper

            Return value

        End Function
        Public Function getRowID(intIDInterno As Integer) As Integer

            Dim value As Integer = -1

            Try
                value = Listar_LM(intIDInterno).RowID
            Catch ex As Exception

            End Try

            Return value

        End Function
        Public Function fnSedeRowID(intIDInterno As Integer) As Integer

            Dim value As Integer = -1

            Try
                value = Listar_LM(intIDInterno).SedeRowId
            Catch ex As Exception

            End Try

            Return value

        End Function

#End Region
#Region "Validar"
        'Private Function ValidarNombreClaveInterno(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Boolean
        '    If objEntInterno.NombreClaveInterno.Trim.Length <= 2 Then Return True

        '    Dim list As New Entity.Registro.InternoCol
        '    Dim ent As New Entity.Registro.Interno
        '    ent.NombreClaveInterno = objEntInterno.NombreClaveInterno
        '    ent.PenalID = objEntInterno.PenalID
        '    ent.RegionID = objEntInterno.RegionID
        '    list = Listar_LM(ent)

        '    If list Is Nothing Then Return True

        '    If list.Count > 0 Then
        '        If objEntInterno.Codigo > -1 AndAlso objEntInterno.Codigo = list.Item(0).Codigo Then 'si es modificar
        '            Return True
        '        End If

        '        outSms = "La clave " & objEntInterno.NombreClaveInterno & " ya se encuentra registrada." & vbCrLf & _
        '        "Cod. Unico:" & objEntInterno.CodigoUnicoInterno & vbCrLf & _
        '        "CodRp:" & objEntInterno.CodigoRP & vbCrLf & _
        '        "Nombre Clave:" & objEntInterno.NombreClaveInterno & vbCrLf & _
        '        "Nombres:" & objEntInterno.Nombres & ", " & objEntInterno.ApellidoPaterno & " " & objEntInterno.ApellidoMaterno & vbCrLf & _
        '        "NúmDoc:" & objEntInterno.NumeroDocumento & vbCrLf & _
        '        "Fecha Nac.:" & objEntInterno.FechaNacimientoString
        '        Return False
        '    End If
        '    Return True
        'End Function

        'Private Function ValidarCodigoUnico(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Boolean

        '    If objEntInterno.CodigoUnicoInterno.Trim.Length <= 2 Then Return True

        '    Dim list As New Entity.Registro.InternoCol
        '    Dim ent As New Entity.Registro.Interno
        '    ent.CodigoUnicoInterno = objEntInterno.CodigoUnicoInterno
        '    ent.PenalID = objEntInterno.PenalID
        '    ent.RegionID = objEntInterno.RegionID

        '    list = Listar_LM(ent)

        '    If list Is Nothing Then Return True

        '    If list.Count > 0 Then
        '        If objEntInterno.Codigo > -1 AndAlso objEntInterno.Codigo = list.Item(0).Codigo Then 'si es modificar
        '            Return True
        '        End If

        '        outSms = "El código único " & objEntInterno.CodigoUnicoInterno & " ya se encuentra registrada." & vbCrLf & _
        '        "CodRp:" & objEntInterno.CodigoRP & vbCrLf & _
        '        "Nombre Clave:" & objEntInterno.NombreClaveInterno & vbCrLf & _
        '        "Nombres:" & objEntInterno.Nombres & ", " & objEntInterno.ApellidoPaterno & " " & objEntInterno.ApellidoMaterno & vbCrLf & _
        '        "NúmDoc:" & objEntInterno.NumeroDocumento & vbCrLf & _
        '        "Fecha Nac.:" & objEntInterno.FechaNacimientoString
        '        Return False
        '    End If
        '    Return True
        'End Function
        Public Function Validar(ByVal InternoCodigo As String, ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0


            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_validar_codigo", -1, InternoCodigo,
                                                          -1, "", "", "", "",
                                                      RegionID, PenalID)

            If intvalue > 1 Then
                value = False
            End If

            Return value

        End Function
        Public Function ValidarCodigoRP(ByVal strCodigoRP As String, ByVal RegionID As Integer, ByVal PenalID As Integer,
                                        ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0


            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_validar_codigo", -1, strCodigoRP,
                                                          -1, "", "", "", "",
                                                      RegionID, PenalID)

            If intvalue > 1 Then
                value = False
                strMensajeOut = "Se ha detectado que existe (" & intvalue & " registros), con el mismo Codigo RP del Interno. No se puede continuar con la Operacion. " _
                & Chr(13) & Chr(13) & "Codigo Mensaje: Codigo RP duplicado en Penal Lima Metropolitana." _
                & Chr(13) & "Contactese con el administrador del sistema."

            End If

            Return value

        End Function
        Private Function ValidarCaracteresDNI(strNumero As String) As Boolean

            Dim value As Boolean = True

            For Each c As Char In strNumero
                If IsNumeric(c) = False Then
                    value = False
                    Exit For
                End If
            Next

            Return value
        End Function
        Public Function ValidarNumeroDocumento(ByVal TipoDocumentoID As Integer, ByVal NumeroDocumento As String,
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0
            Dim blnValidarenBD As Boolean = False

            Select Case TipoDocumentoID
                Case 10 'dni

                    If NumeroDocumento.Length = 8 Then
                        blnValidarenBD = True
                    Else
                        blnValidarenBD = ValidarCaracteresDNI(NumeroDocumento)
                    End If

                Case Else
                    blnValidarenBD = True
            End Select

            If blnValidarenBD = True Then
                intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_numero_documento", -1, "",
                                                          TipoDocumentoID, NumeroDocumento, "", "", "",
                                                      RegionID, PenalID)
            End If

            If intvalue > 0 Then
                value = False
            End If

            Return value

        End Function
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
        Public Function ValidarApellidosyNombres(ByVal PrimerApellido As String,
        ByVal SegundoApellido As String, ByVal Nombres As String,
        ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = True
            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_apellidos_nombres", -1, "",
                                                          -1, "", PrimerApellido, SegundoApellido, Nombres,
                                                      RegionID, PenalID)

            If intvalue > 0 Then
                value = False
            End If

            Return value

        End Function
        Public Function ValidarApellidosyNombres(objEnt As Entity.Registro.Interno) As Integer

            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_apellidos_nombres", objEnt)



            Return intvalue

        End Function
        Public Function ValidarApellidosyNombresUpd(objEnt As Entity.Registro.Interno) As Integer

            Dim intvalue As Integer = 0

            intvalue = Data.Registro.Interno.ListarOutput("lst", "lst_val_apellidos_nombresUpd", objEnt)

            Return intvalue

        End Function
        Public Function ValidarApellidosyNombres(strPrimerApellido As String, strSegundoApellido As String, strNombres As String,
                                                 ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            '/*primer apellido*/
            If strPrimerApellido.Trim.Length < 1 Then
                strMensajeOut = "Ingrese el Primer Apellido del Interno"
                Return value
            End If

            'segundo apellido 
            If strSegundoApellido.Trim.Length < 1 Then
                strMensajeOut = "Ingrese el Segundo Apellido del Interno"
                Return value
            End If

            'apellidos 
            If strPrimerApellido.Trim.Substring(0, 1) = "." And strSegundoApellido.Trim.Substring(0, 1) = "." Then
                strMensajeOut = "Apellidos no validos, debe ingresar por lo menos un apellido!"
                Return value
            End If

            'validar puntos del primer apellido
            Dim intContarPriApe As Integer = (From c In strPrimerApellido Where c = "." Select c).Count()
            If intContarPriApe > 3 Then
                strMensajeOut = "El Primer Apellido tiene mas un caracter especial permitido"
                Return value
            End If

            'validar puntos del segundo apellido
            Dim intContarSegApe As Integer = (From c In strSegundoApellido Where c = "." Select c).Count()
            If intContarSegApe > 3 Then
                strMensajeOut = "El Segundo Apellido tiene mas un caracter especial permitido"
                Return value
            End If

            '/*nombres*/
            If strNombres.Trim.Length < 2 Then
                strMensajeOut = "Ingrese los nombres del Interno"
                Return value
            End If

            value = True
            Return value

        End Function
#End Region

#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Interno

            'VERSION 4.5
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar(sqlCon, "lst", "lst_mant", Codigo, -1, "",
            "", "", "", "", -1, -1, "", -1, 0, -1, -1, -1, -1, "", -1, -1, -1, -1, 0, 0)

            objEnt = New Entity.Registro.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .NumeroHijos = sqlDr("int_num_hij").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            '  .VisitaSancion = sqlDr("int_vis_san").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            '.Decadactilar = sqlDr("c_int_dec").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            '.FechaIngresoPenal = sqlDr("fec_ing_pen").ToString
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
        Public Function Listar_v5(intIDInterno As Integer) As Entity.Registro.Interno

            'VERSION 5.0
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Registro.Interno
            objEntFiltro.Codigo = intIDInterno

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar(sqlCon, "lst", "lst_mant_v5", objEntFiltro)

            objEnt = New Entity.Registro.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .NumeroHijos = sqlDr("int_num_hij").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString

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

        Public Function Listar_v6(intIDInterno As Integer) As Entity.Registro.Interno

            'VERSION 6.0, jmr-06/08/2019
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Registro.Interno
            objEntFiltro.Codigo = intIDInterno

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar(sqlCon, "lst", "lst_mant_v6", objEntFiltro)

            objEnt = New Entity.Registro.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .NumeroHijos = sqlDr("int_num_hij").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString
                            .NacionalidadNombre = sqlDr("nac_nom").ToString
                            Try
                                .IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                                .GeneroId = sqlDr("fk_gnro_id").ToString
                                .CentroTrabajo = sqlDr("c_cen_trab").ToString
                                .ReligionId = sqlDr("fk_rel_id").ToString
                                .CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                                .CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                                .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                                .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                                .VersionRegistro = sqlDr("c_ver_reg").ToString
                                .CentroReclusionMenorId = sqlDr("n_cen_men").ToString
                            Catch ex As Exception

                            End Try
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

        Public Function Listar_LM(ByVal intIDInterno As Integer) As Entity.Registro.Interno

            If intIDInterno < 1 Then
                Return Nothing
            End If

            Dim objEntFiltro As New Entity.Registro.Interno
            With objEntFiltro
                .Codigo = intIDInterno
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar_LM(sqlCon, "lst", "lst_mant_carceleta_regionlima_plm", objEntFiltro)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .CentroReclusionMenorId = sqlDr("n_cen_men").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .NumeroHijos = sqlDr("int_num_hij").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FechaISP = sqlDr("int_fec_isp").ToString
                            '.InternoAlias = sqlDr("aut_ali_nom").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString

                            .IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                            .GeneroId = sqlDr("fk_gnro_id").ToString
                            .CentroTrabajo = sqlDr("c_cen_trab").ToString
                            .ReligionId = sqlDr("fk_rel_id").ToString
                            .CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                            .CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            .RowID = sqlDr("_rowid").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString
                            .EstadoBloqueoId = sqlDr("n_int_pen_bloq_id").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
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


        ''' <summary>
        ''' Retorna la lista de los internos x tipo de documento y numero, buscar los internos dentro de los EP lima metropolitana
        ''' considerando solo los registros de la version V6_LM
        ''' </summary>
        ''' <param name="tipoIdent"></param>
        ''' <param name="numDocIdent"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ListarDuplicadosXNumDoc_LM(tipoIdent As Integer, numDocIdent As String) As Entity.Registro.InternoCol
            Dim list As New Entity.Registro.InternoCol

            If tipoIdent = -1 Or numDocIdent = "" Then Return Nothing

            Dim objEntInterno As New Entity.Registro.Interno
            objEntInterno.TipoDocumentoID = tipoIdent
            objEntInterno.NumeroDocumento = numDocIdent
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar_LM(sqlCon, "lst", "lst_internos_x_numdoc_lm", objEntInterno)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            '.SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            '.RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                            '.PenalNombre = sqlDr("pen_nom").ToString


                            '.IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                            '.GeneroId = sqlDr("fk_gnro_id").ToString
                            '.CentroTrabajo = sqlDr("c_cen_trab").ToString
                            '.ReligionId = sqlDr("fk_rel_id").ToString
                            '.CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                            '.CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                            '.CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            '.NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            '.SedeRowId = sqlDr("_sed_rowid").ToString
                            '.TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString
                            '.EstadoBloqueoId = sqlDr("n_int_pen_bloq_id").ToString
                        End With
                        list.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return list
        End Function
        Public Function ListarDuplicadosXNumDoc(tipoIdent As Integer, numDocIdent As String) As Entity.Registro.InternoCol
            Dim list As New Entity.Registro.InternoCol

            If tipoIdent = -1 Or numDocIdent = "" Then Return Nothing

            Dim objEntInterno As New Entity.Registro.Interno
            objEntInterno.TipoDocumentoID = tipoIdent
            objEntInterno.NumeroDocumento = numDocIdent
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar_LM(sqlCon, "lst", "lst_internos_x_numdoc", objEntInterno)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            '.SexoID = sqlDr("sex_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .RegionID = sqlDr("_RegId").ToString
                            '.RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("_PenId").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                            '.PenalNombre = sqlDr("pen_nom").ToString


                            '.IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                            '.GeneroId = sqlDr("fk_gnro_id").ToString
                            '.CentroTrabajo = sqlDr("c_cen_trab").ToString
                            '.ReligionId = sqlDr("fk_rel_id").ToString
                            '.CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                            '.CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                            '.CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            '.NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            '.SedeRowId = sqlDr("_sed_rowid").ToString
                            '.TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString
                            '.EstadoBloqueoId = sqlDr("n_int_pen_bloq_id").ToString
                        End With
                        list.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return list
        End Function

        Public Function Listar_LM(objEntInterno As Entity.Registro.Interno) As Entity.Registro.InternoCol

            Dim list As New Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar_LM(sqlCon, "lst", "lst_mant_lima_metropolitana", objEntInterno)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .NumeroHijos = sqlDr("int_num_hij").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FechaISP = sqlDr("int_fec_isp").ToString
                            '.InternoAlias = sqlDr("aut_ali_nom").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString

                            .IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                            .GeneroId = sqlDr("fk_gnro_id").ToString
                            .CentroTrabajo = sqlDr("c_cen_trab").ToString
                            .ReligionId = sqlDr("fk_rel_id").ToString
                            .CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                            .CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString
                            .EstadoBloqueoId = sqlDr("n_int_pen_bloq_id").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                        End With
                        list.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return list
        End Function

        Public Function Listar_Penal_Ori(objEntInterno As Entity.Registro.Interno) As Entity.Registro.InternoCol

            Dim list As New Entity.Registro.InternoCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar_LM(sqlCon, "lst", "lst_interno_penal_original", objEntInterno)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Interno
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .Libro = sqlDr("int_lib").ToString
                            .Folio = sqlDr("int_fol").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            .NacimientoPaisID = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .ProfesionID = sqlDr("pro_id").ToString
                            .OcupacionID = sqlDr("ocu_id").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .Discapacidad = sqlDr("int_dis_id").ToString
                            .ComunidadAndinaID = sqlDr("int_com_id").ToString
                            .ComunidadAndinaEspID = sqlDr("int_com_esp_id").ToString
                            .NumeroHijos = sqlDr("int_num_hij").ToString
                            .HijosMenores = sqlDr("int_hij_men").ToString
                            .EstadoID = sqlDr("int_est_id").ToString
                            .FechaISP = sqlDr("int_fec_isp").ToString
                            '.InternoAlias = sqlDr("aut_ali_nom").ToString
                            '/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            '/*otros*/
                            .SituacionJuridicaNom = sqlDr("sit_jur_nom").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .Obs = sqlDr("int_obs").ToString
                            .Obs_DNI = sqlDr("int_obs_dni").ToString
                            .PabellonID = sqlDr("pab_id").ToString
                            .PabellonNombre = sqlDr("pab_str").ToString
                            .Decadactilar = sqlDr("c_int_dec").ToString
                            .Homonimia = sqlDr("b_int_hom").ToString
                            .IngresoSistemaPen = sqlDr("int_fec_isp").ToString
                            .EstadoRncID = sqlDr("int_est_rnc").ToString

                            .IdiomaNativoId = sqlDr("fk_idm_nat_id").ToString
                            .GeneroId = sqlDr("fk_gnro_id").ToString
                            .CentroTrabajo = sqlDr("c_cen_trab").ToString
                            .ReligionId = sqlDr("fk_rel_id").ToString
                            .CodigoFuerzaArmadaId = sqlDr("fk_cod_fza_arm_id").ToString
                            .CodigoRangoId = sqlDr("fk_cod_ran_id").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .NombreClaveInterno = sqlDr("c_int_nom_clav").ToString
                            .SedeRowId = sqlDr("_sed_rowid").ToString
                            .TrasladadoDeCarceleta = sqlDr("n_car_est_trs_id").ToString
                            .EstadoBloqueoId = sqlDr("n_int_pen_bloq_id").ToString
                            .VersionRegistro = sqlDr("c_ver_reg").ToString
                        End With
                        list.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try
            Return list
        End Function
        Public Function ListarInternoReniec(ByVal objEntInterno As Entity.Registro.Interno) As Entity.Registro.Interno

            'OJO: DEBE debe estra estar en bussines del interno
            'JONH HACER EL CAMBIO

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Interno.Listar(sqlCon, "lst", "lst_interno_reniec", objEntInterno)

            objEnt = New Entity.Registro.Interno
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_id").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApellidoPaterno = sqlDr("int_ape_pat").ToString
                            .ApellidoMaterno = sqlDr("int_ape_mat").ToString
                            .Nombres = sqlDr("int_nom").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            '.SexoNombre = sqlDr("sex_nom").ToString
                            .FechaNacimiento = sqlDr("int_fec_nac").ToString
                            '.NacimientoUbigeoPais = sqlDr("ubg_pai_id").ToString
                            .NacimientoUbigeoID = sqlDr("ubg_id_nac").ToString
                            .NacimientoOtros = sqlDr("ubg_nac_otro").ToString
                            .NacionalidadID = sqlDr("nac_id").ToString
                            .TipoDocumentoID = sqlDr("tip_doc_id").ToString
                            .TipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .NumeroDocumento = sqlDr("int_doc_num").ToString
                            .DomicilioUbigeoID = sqlDr("ubg_id_dir").ToString
                            .Domicilio = sqlDr("int_dir_nom").ToString
                            .EstadoCivilID = sqlDr("est_civ_id").ToString
                            .EstadoCivilNombre = sqlDr("est_civ_nom").ToString
                            .NivelAcademicoID = sqlDr("niv_aca_id").ToString
                            .NivelAcademicoNombre = sqlDr("niv_aca_nom").ToString
                            '.EstadoID = sqlDr("int_est_id").ToString
                            ''/*region y penal*/
                            .RegionID = sqlDr("reg_id").ToString
                            ''.RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            ''.PenalNombre = sqlDr("pen_nom").ToString
                            ''/*otros*/
                            .Nac_Departamento = sqlDr("nac_nomdep").ToString
                            .Nac_Provincia = sqlDr("nac_nompro").ToString
                            .Nac_Distrito = sqlDr("nac_nomdis").ToString

                            .Padre = sqlDr("aut_fam_pad").ToString
                            .Madre = sqlDr("aut_fam_mad").ToString
                            .Conyugue = sqlDr("aut_fam_coy").ToString
                            .Estatura = sqlDr("int_ras_tal").ToString
                            '--------Ubigeo--------------------
                            .Departamento = sqlDr("aut_ubg_dep").ToString
                            .Provincia = sqlDr("aut_ubg_pro").ToString
                            .Distrito = sqlDr("aut_ubg_dis").ToString


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
#End Region
#Region "Grabar"
        Public Function ActivarEstado(ByVal InternoID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_activa_estado"

            objEnt = New Entity.Registro.Interno

            With objEnt
                .Codigo = InternoID
            End With

            intValue = Data.Registro.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
        Public Function ActivarEstado_LM(ByVal intIDInterno As Integer, intIDEstado As Short) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado_LM"

            objEnt = New Entity.Registro.Interno

            With objEnt
                .Codigo = intIDInterno
                .EstadoBloqueoId = 0
                .EstadoID = intIDEstado '1=activo,0=baja
            End With

            intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function ActualizarEstadoBaja(ByVal InternoID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_estado"

            objEnt = New Entity.Registro.Interno

            With objEnt
                .Codigo = InternoID
            End With

            intValue = Data.Registro.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function ActualizarInternoDMP(ByVal InternoID As Integer, IngresoID As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_internodmp"

            objEnt = New Entity.Registro.Interno

            With objEnt
                '.FlagTransferenciaSede = FlagTransferenciaSede
                .Codigo = InternoID
                .IngresoID = IngresoID
            End With

            intValue = Data.Registro.Interno.Grabar2(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function ActualizarInternoDMP_LM(ByVal InternoID As Integer, IngresoInpeID As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_internodmp_LM"

            objEnt = New Entity.Registro.Interno

            With objEnt
                .FlagTransferenciaSede = 0
                .Codigo = InternoID
                '.IngresoID = IngresoInpeID
                .IngresoInpeId = IngresoInpeID
            End With

            intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEnt)

            Return intValue

        End Function
        Public Function ActualizarInternoSMP(ByVal InternoID As Integer, IngresoID As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_internosmp"


            objEnt = New Entity.Registro.Interno

            With objEnt
                .Codigo = InternoID
                .IngresoID = IngresoID
            End With

            intValue = Data.Registro.Interno.Grabar2(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function Grabar(objEntInterno As Entity.Registro.Interno) As Integer
            'VERSION 4.5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
                If objEntInterno.RegionID = 3 Then
                    objEntInterno.VersionRegistro = "V45_LP" 'version 4.5 lima provincia
                Else
                    objEntInterno.VersionRegistro = "V45_P" 'version 4.5 provincia
                End If
                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El número de documento que esta ingresando, ya existe en la base de datos")
                    Return intValue
                End If
                If objEntInterno.RegionID = -1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha especificado RegionId.")
                    Return intValue
                End If
                If ValidarApellidosyNombres(objEntInterno.ApellidoPaterno, objEntInterno.ApellidoMaterno, objEntInterno.Nombres, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    'Legolas.Configuration.Aplication.MessageBox.Exclamation("Los apellidos y nombres que esta ingresando, ya existe en la base de datos")
                    If Windows.Forms.MessageBox.Show("Los apellidos y nombres que esta ingresando ya existe en la base de datos, desea registrar de todas maneras con los nombres duplicados?",
                                                     "", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        Return intValue
                    End If
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Interno.Grabar(strAccion, strOpcion, objEntInterno)

            Return intValue
        End Function

        Public Function Grabar_DatoBasic_PLM(objEntInterno As Entity.Registro.Interno) As Integer

            Dim intValue As Integer = -1

            Try
                intValue = Data.Registro.Interno.Grabar_LM("ins", "ins_mant_basic_plm", objEntInterno)
            Catch ex As Exception
                intValue = -1
            End Try

            Return intValue

        End Function

        Public Function Grabar2(objEntInterno As Entity.Registro.Interno) As Integer
            'VERSION 5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
                If objEntInterno.RegionID = 3 Then
                    objEntInterno.VersionRegistro = "V5_LP" 'version 5 lima provincia
                Else
                    objEntInterno.VersionRegistro = "V5_P" 'version 5 provincia
                End If
                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El numero de documento que esta ingresando, ya existe en la base de datos")
                    Return intValue
                End If


            Else
                strAccion = "upd2"
                strOpcion = "upd_mant2"

            End If
            intValue = Data.Registro.Interno.Grabar2(strAccion, strOpcion, objEntInterno)


            Return intValue
        End Function
        ''' <summary>
        ''' Autor:Hnrb - 13/12/2016
        ''' Guarda los datos del interno
        ''' obs:Se agrego campo idiomaNativoId, generoId
        ''' </summary>
        ''' <param name="objEntInterno"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function Grabar_PLM(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Integer
            If objEntInterno.Codigo = -1 And objEntInterno.VersionRegistro.Trim.Length = 0 Then
                outSms = "No se ha especificado la versión del módulo con la cual se crea el registro"
                'Return -1
            End If

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            'limpiar los apellidos y nombres
            With objEntInterno
                .ApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(.ApellidoPaterno)
                .ApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(.ApellidoMaterno)
                .Nombres = Legolas.Components.Cadena.LimpiarEspacios(.Nombres)
            End With

            'If ValidarNombreClaveInterno(objEntInterno, outSms) = False Then Return -1
            'If ValidarCodigoUnico(objEntInterno, outSms) = False Then Return -1

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant_plm"

                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    outSms = "El número de documento que esta ingresando, ya existe en la base de datos"
                    Return intValue
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant_plm"
            End If

            Try
                intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEntInterno)
            Catch ex As Exception
                outSms = ex.Message
                intValue = -1
            End Try

            Return intValue

        End Function

        ''' <summary>
        ''' Autor:Hnrb - 13/12/2016
        ''' Guarda los datos del interno
        ''' obs:Se agrego campo idiomaNativoId, generoId
        ''' </summary>
        ''' <param name="objEntInterno"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function Grabar_Carceleta(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Integer
            If objEntInterno.Codigo = -1 And objEntInterno.VersionRegistro.Trim.Length = 0 Then
                outSms = "No se ha especificado la versión del módulo con la cual se crea el registro"
                Return -1
            End If

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            'limpiar los apellidos y nombres
            With objEntInterno
                .ApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(.ApellidoPaterno)
                .ApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(.ApellidoMaterno)
                .Nombres = Legolas.Components.Cadena.LimpiarEspacios(.Nombres)
            End With

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant_carceleta"

                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    outSms = "El número de documento que esta ingresando, ya existe en la base de datos"
                    Return intValue
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant_carceleta"
            End If

            Try
                intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEntInterno)

                If intValue > 0 And strAccion = "ins" Then
                    Dim objBssInternoPenal As New Bussines.Registro.InternoPenal
                    objBssInternoPenal.Grabar(intValue, intValue, 3, 35, objEntInterno.EstadoID) 'baja se activa con movimiento
                End If
            Catch ex As Exception
                outSms = ex.Message
                intValue = -1
            End Try

            Return intValue

        End Function
        Public Function GrabarProvincia(objEntInterno As Entity.Registro.Interno) As Integer
            'VERSION 6
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntInterno.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant2"
                If objEntInterno.RegionID = 3 Then
                    objEntInterno.VersionRegistro = "V6_LP" 'version 5 lima provincia
                Else
                    objEntInterno.VersionRegistro = "V6_P" 'version 5 provincia
                End If
                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "El numero de documento que esta ingresando, ya existe en la base de datos")
                    Return intValue
                End If
            Else
                strAccion = "upd2"
                strOpcion = "upd_mant2"
            End If

            intValue = Data.Registro.Interno.Grabar2(strAccion, strOpcion, objEntInterno)

            Return intValue
        End Function

        ''' <summary>
        ''' Permite grabar los datos del interno con penId=-1 a 35 para poder ser visualizado en carceleta
        ''' </summary>
        ''' <param name="objEntInterno"></param>
        ''' <param name="outSms"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function Grabar_RegionLima(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Integer
            If objEntInterno.Codigo = -1 And objEntInterno.VersionRegistro.Trim.Length = 0 Then
                outSms = "No se ha especificado la versión del módulo con la cual se crea el registro"
                Return -1
            End If

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            'limpiar los apellidos y nombres
            With objEntInterno
                .ApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(.ApellidoPaterno)
                .ApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(.ApellidoMaterno)
                .Nombres = Legolas.Components.Cadena.LimpiarEspacios(.Nombres)
            End With

            'If ValidarNombreClaveInterno(objEntInterno, outSms) = False Then Return -1
            'If ValidarCodigoUnico(objEntInterno, outSms) = False Then Return -1

            If objEntInterno.Codigo < 1 Then

                strAccion = "ins"
                strOpcion = "ins_mant_regionlima"

                If ValidarNumeroDocumento(objEntInterno.TipoDocumentoID, objEntInterno.NumeroDocumento, objEntInterno.RegionID, objEntInterno.PenalID) = False Then
                    outSms = "El número de documento que esta ingresando, ya existe en la base de datos"
                    Return intValue
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant_regionlima"
            End If

            Try
                intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEntInterno)
            Catch ex As Exception
                outSms = ex.Message
                intValue = -1
            End Try

            Return intValue

        End Function

        Public Function GrabarApellidosyNombres(ByVal InternoID As Integer,
        ByVal ApellidoPaterno As String,
        ByVal ApellidoMaterno As String,
        ByVal Nombres As String) As Integer

            'VERSION 4.5
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom"

            objEnt = New Entity.Registro.Interno

            With objEnt
                .Codigo = InternoID
                .ApellidoPaterno = ApellidoPaterno
                .ApellidoMaterno = ApellidoMaterno
                .Nombres = Nombres
            End With

            intValue = Data.Registro.Interno.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

        Public Function GrabarApellidosyNombres(objInterno As Entity.Registro.Interno) As Integer

            'VERSION 5, NOMBRES ASOCIADOS
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom2"

            intValue = Data.Registro.Interno.Grabar2(strAccion, strOpcion, objInterno)

            Return intValue

        End Function

        Public Function GrabarApellidosyNombres_LM(objInterno As Entity.Registro.Interno) As Integer

            'VERSION ORL, NOMBRES ASOCIADOS ORL
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_ape_nom2_LM"

            intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objInterno)

            Return intValue

        End Function

        ''' <summary>
        ''' Permite actualizar todos los datos de interno que fue registrado en la ORL para que pueda ser visualizado en carceleta.
        ''' </summary>
        ''' <param name="objEntInterno"></param>
        ''' <param name="outSms"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ActualizarInternoORL_ParaCarceleta(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_trs_int_orl_a_carceleta"

            Try
                intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEntInterno)
            Catch ex As Exception
                outSms = ex.Message
                intValue = -1
            End Try


            Return intValue

        End Function

        Public Function ActualizarInternoEP_LM_ParaCarceleta(objEntInterno As Entity.Registro.Interno, ByRef outSms As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_trs_int_eplm_a_carceleta"

            Try
                intValue = Data.Registro.Interno.Grabar_LM(strAccion, strOpcion, objEntInterno)
            Catch ex As Exception
                outSms = ex.Message
                intValue = -1
            End Try

            Return intValue

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar_v45(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo,
            Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)
            Return intValue

        End Function
        Public Function EliminarPLM(ByVal Codigo As Integer, ByRef strMensajeOut As String, Optional FlagTransferenciaSede As Integer = 0) As Integer

            Dim value As Integer = -1

            Dim intIDTipoLicencia As Short = -1
            Dim objBssPenal As New General.Penal

            Dim intIDInternoNuevo As Integer = -1
            Dim intIDPenal As Short = -1
            Dim intIDInternoSede As Integer = -1
            Dim intPriApe As String = ""
            Dim intSegApe As String = ""
            Dim intPreNom As String = ""

            objEnt = New Entity.Registro.Interno
            objEnt = Listar_LM(Codigo)

            intIDPenal = objEnt.PenalID
            intPriApe = objEnt.ApellidoPaterno.Trim
            intSegApe = objEnt.ApellidoMaterno.Trim
            intPreNom = objEnt.Nombres.Trim
            intIDInternoSede = objEnt.SedeRowId

            intIDTipoLicencia = objBssPenal.fnTipoLicencia(intIDPenal)

            If intIDTipoLicencia = 4 Then  'penales de lima metropolitana

                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim dt As New DataTable
                dt = Legolas.Components.SQL.Select_DataTable(sqlCon, "select int_id from int_interno where _penid =" & intIDPenal &
                                                             " and ltrim(rtrim(int_ape_pat))='" & intPriApe & "'" &
                                                             " and ltrim(rtrim(int_ape_mat))='" & intSegApe & "'" &
                                                             " and ltrim(rtrim(int_nom))='" & intPreNom & "'" &
                                                             " and isnull(int_id,-1)<>" & Codigo)

                If dt Is Nothing Then
                    'nada
                Else
                    For Each fila As DataRow In dt.Rows
                        intIDInternoNuevo = fila(0).ToString
                    Next

                    'regularizar las tablas de visitas
                    Dim strSqlMasivo As New System.Text.StringBuilder
                    With strSqlMasivo
                        .AppendLine("update VIS_Autorizacion set _flg_trf =1,int_id=" & intIDInternoNuevo & " where _penid =" & intIDPenal & " and int_id=" & Codigo)
                        .AppendLine("update VIS_CalendarioDetalle set _flg_trf =1,int_id=" & intIDInternoNuevo & " where _penid =" & intIDPenal & " and int_id=" & Codigo)
                        .AppendLine("update VIS_InternoEtapa set _flg_trf =1,int_id=" & intIDInternoNuevo & " where _penid =" & intIDPenal & " and int_id=" & Codigo)
                        .AppendLine("update VIS_InternoSancion set _flg_trf =1,int_id=" & intIDInternoNuevo & " where _penid =" & intIDPenal & " and int_id=" & Codigo)
                        .AppendLine("update VIS_Movimiento set _flg_trf =1,int_id=" & intIDInternoNuevo & " where _penid =" & intIDPenal & " and int_id=" & Codigo)
                        .AppendLine("update VIS_VisitanteRestriccion set _flg_trf =1,int_id=" & intIDInternoNuevo & " where _penid =" & intIDPenal & " and int_id=" & Codigo)
                        .AppendLine("update reg_mov_internopenal set _flg_trf =1,_flg_eli=1,_usu_eli=" & Legolas.Configuration.Usuario.Codigo & ", _fec_eli = " & Now.ToFileTime & " where fk_int_id_pen=" & Codigo)
                    End With

                    Dim intResul As Integer = -1
                    intResul = UpdateQuery(strSqlMasivo.ToString(), strMensajeOut)

                    If strMensajeOut.Trim.Length > 0 Then
                        Return value
                    End If
                End If
            End If

            'eliminar el interno
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant_v2"

            value = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo, Legolas.Configuration.Usuario.Codigo, FlagTransferenciaSede)

            Return value

        End Function
        Public Function Eliminar(ByVal Codigo As Integer, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant_v2"

            value = Data.Registro.Interno.Eliminar(strAccion, strOpcion, Codigo, Legolas.Configuration.Usuario.Codigo, 1)

            Return value

        End Function
        Public Shared Function UpdateQuery(strSql As String, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Try

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strSql, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.Text
                            .CommandTimeout = 60 * 3

                            sqlCon.Open()
                            value = .ExecuteNonQuery()

                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                strMensajeOut = "UpdateQuery/GrabarInternoPenal; " & ex.Message
                Return -1
            End Try

        End Function
#End Region
    End Class
End Namespace
