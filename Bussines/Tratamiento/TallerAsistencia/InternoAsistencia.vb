Imports System.Data
Imports System.Data.SqlClient
Imports Bussines.Globall.UtilAccesoBD
Namespace Tratamiento.TallerAsistencia
    Public Class InternoAsistencia
        Private objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia = Nothing
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol = Nothing
        Private obj_Ent As Entity.Registro.Interno = Nothing

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
        Public Function Listar(objEntInterno As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistencia

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant", objEntInterno)

            objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = Isnulll(sqlDr("int_id"), -1).ToString
                            '.Codi = Isnulll(sqlDr("int_id"), -1).ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
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
                            .InternoHuellaID = Isnulll(sqlDr("pk_int_hue_id"), -1).ToString
                            .TipoCapturaDerID = Isnulll(sqlDr("n_int_hue_tip_cap_Der"), -1).ToString
                            .TipoCapturaIzqID = Isnulll(sqlDr("n_int_hue_tip_cap_Izq"), -1).ToString
                            '/*Actividad laboral*/
                            .FechaInscripcion = Isnulll(sqlDr("tra_asi_tal_int_fec"), 0).ToString
                            .TallerNombre = Isnulll(sqlDr("c_tra_tal_nom"), "").ToString
                            .ActividadNombre = Isnulll(sqlDr("c_tra_tal_act_nom"), "").ToString
                            .TipoActividadNombre = Isnulll(sqlDr("c_tra_tal_tip_act_nom"), "").ToString
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
        Public Function ListarIngreso(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_ing", objEnt)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read

                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia

                        With objEnt
                            .Codigo = sqlDr("pk_tal_asi_id").ToString
                            .InternoID = sqlDr("kf_int_id").ToString
                            .Fecha = sqlDr("n_tal_asi_fec").ToString
                            .HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            .HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
                            .CodigoTaller = sqlDr("kf_tal_id").ToString
                            .RegionID = sqlDr("_regid").ToString
                            .PenalID = sqlDr("_penid").ToString
                            .Observacion = sqlDr("c_tal_asi_obs").ToString
                            .EstadoID = sqlDr("n_tal_asi_est_id").ToString
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
        Public Function ListarAsistenciaInterno(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_int_asi", objEnt)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .Codigo = sqlDr("pk_tal_asi_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .ApellidosNombres = sqlDr("int_ape_nom").ToString.ToUpper
                            .TallerNombre = (sqlDr("c_tra_tal_nom")).ToString.ToUpper
                            .Fecha = sqlDr("n_tal_asi_fec").ToString
                            .HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            .HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
                            .MotivoRetiroID = sqlDr("tra_asi_tal_mot_ret").ToString
                            .FechaInicialRetiro = sqlDr("tra_asi_tal_fec_ret").ToString
                            .FechaFinalRetiro = sqlDr("tra_asi_tal_fec_fin").ToString
                            .MotivoJustificacionID = sqlDr("kf_asi_jus_id").ToString
                            .MotivoJustificacionNombre = sqlDr("asi_jus_nom").ToString
                            .EstadoJustificacion = sqlDr("n_tal_asi_jus_est").ToString
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
        Public Function ListarAsistencia(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_asi", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .Codigo = Isnulll(sqlDr("pk_tal_asi_id"), -1).ToString
                            .InternoID = Isnulll(sqlDr("int_id"), -1).ToString
                            .ApellidoPaterno = Isnulll(sqlDr("int_ape_pat"), "").ToString
                            .ApellidoMaterno = Isnulll(sqlDr("int_ape_mat"), "").ToString
                            .Nombres = Isnulll(sqlDr("int_nom"), "").ToString
                            .TipoDocumentoID = Isnulll(sqlDr("tip_doc_id"), -1).ToString
                            .TipoDocumentoNombre = Isnulll(sqlDr("doc_tip_nom"), "").ToString
                            .NumeroDocumento = Isnulll(sqlDr("int_doc_num"), "").ToString
                            .FechaNacimiento = Isnulll(sqlDr("int_fec_nac"), 0).ToString
                            .Fecha = Isnulll(sqlDr("n_tal_asi_fec"), 0).ToString
                            .HoraEntrada = Isnulll(sqlDr("c_tal_asi_hor_ent"), "").ToString
                            .HoraSalida = Isnulll(sqlDr("c_tal_asi_hor_sal"), "").ToString()
                            .Observacion = Isnulll(sqlDr("c_tal_asi_obs"), "").ToString()
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
        Public Function ListarAsistencia_v2(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_asi_v2", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        Contador += 1
                        With objEnt
                            .Contador = Contador
                            .Codigo = Isnulll(sqlDr("pk_tal_asi_id"), -1).ToString
                            .InternoID = Isnulll(sqlDr("int_id"), -1).ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = Isnulll(sqlDr("int_ape_pat"), "").ToString
                            .ApellidoMaterno = Isnulll(sqlDr("int_ape_mat"), "").ToString
                            .Nombres = Isnulll(sqlDr("int_nom"), "").ToString
                            .TipoDocumentoID = Isnulll(sqlDr("tip_doc_id"), -1).ToString
                            .TipoDocumentoNombre = Isnulll(sqlDr("doc_tip_nom"), "").ToString
                            .NumeroDocumento = Isnulll(sqlDr("int_doc_num"), "").ToString
                            .FechaNacimiento = Isnulll(sqlDr("int_fec_nac"), 0).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("int_nac_nom"), "").ToString
                            .Fecha = Isnulll(sqlDr("n_tal_asi_fec"), 0).ToString
                            .TallerNombre = Isnulll(sqlDr("c_tra_tal_nom"), "").ToString
                            .HoraEntrada = Isnulll(sqlDr("c_tal_asi_hor_ent"), "").ToString
                            .HoraSalida = Isnulll(sqlDr("c_tal_asi_hor_sal"), "").ToString()
                            '/*Datos de Justificacion*/
                            .MotivoJustificacionID = Isnulll(sqlDr("kf_asi_jus_id"), "").ToString()
                            .MotivoJustificacionNombre = Isnulll(sqlDr("c_jus_nom"), "").ToString()
                            .Documento = Isnulll(sqlDr("c_tal_asi_doc"), "").ToString()
                            .FechaDocumento = Isnulll(sqlDr("n_tal_asi_fec_doc"), 0).ToString()
                            .FechaInicialRetiro = Isnulll(sqlDr("n_tal_asi_fec_ini"), 0).ToString()
                            .FechaFinalRetiro = Isnulll(sqlDr("n_tal_asi_fec_fin"), 0).ToString()
                            .EstadoJustificacion = Isnulll(sqlDr("n_tal_asi_jus_est"), -1).ToString()
                            .Observacion = Isnulll(sqlDr("c_tal_asi_obs"), "").ToString()
                            .RegionID = Isnulll(sqlDr("reg_id"), -1).ToString()
                            .PenalID = Isnulll(sqlDr("pen_id"), -1).ToString()
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
        Public Function ListarTaller(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            objEntCol = New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim Contador As Integer = 0
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Listar(sqlCon, "lst", "lst_mant_tal", objEnt)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.InternoAsistencia
                        Contador += 1
                        With objEnt
                            .Contador = Contador

                            .InternoID = Isnulll(sqlDr("int_id"), -1).ToString
                            .CodigoPadre = Isnulll(sqlDr("int_pdr"), "").ToString
                            .CodigoRP = Isnulll(sqlDr("int_cod_rp"), "").ToString
                            .ApellidoPaterno = Isnulll(sqlDr("int_ape_pat"), "").ToString
                            .ApellidoMaterno = Isnulll(sqlDr("int_ape_mat"), "").ToString
                            .Nombres = Isnulll(sqlDr("int_nom"), "").ToString
                            .TipoDocumentoID = Isnulll(sqlDr("tip_doc_id"), -1).ToString
                            .TipoDocumentoNombre = Isnulll(sqlDr("tip_doc_nom"), "").ToString
                            .NumeroDocumento = Isnulll(sqlDr("int_doc_num"), "").ToString
                            .FechaNacimiento = Isnulll(sqlDr("int_fec_nac"), 0).ToString
                            .EstadoCivilID = Isnulll(sqlDr("est_civ_id"), -1).ToString
                            .EstadoCivilNombre = Isnulll(sqlDr("est_civ_nom"), -1).ToString
                            .EstadoID = Isnulll(sqlDr("int_est_id"), -1).ToString
                            .EstadoRncID = Isnulll(sqlDr("int_est_rnc"), -1).ToString
                            .NacionalidadNombre = Isnulll(sqlDr("nac_nom"), "").ToString
                            .NombrePadre = Isnulll(sqlDr("aut_fam_pad"), "").ToString
                            .NombreMadre = Isnulll(sqlDr("aut_fam_mad"), "").ToString
                            '/*fotos*/
                            .FotoPerfilIzquierdo = sqlDr("int_fot_per_izq").ToString
                            .FotoPerfilFrente = sqlDr("int_fot_per_fre").ToString
                            .FotoPerfilDerecho = sqlDr("int_fot_per_der").ToString
                            '.Fecha = sqlDr("n_tal_asi_fec").ToString
                            '.HoraEntrada = sqlDr("c_tal_asi_hor_ent").ToString
                            '.HoraSalida = sqlDr("c_tal_asi_hor_sal").ToString
                        End With
                        'objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
            End Try

            Dim objEntNA As Entity.Registro.InternoCol = Nothing
            Dim objEntColReturn As New Entity.Tratamiento.TallerAsistencia.InternoAsistenciaCol
            'llenar nombres asociados
            'objEntColReturn = LlenarNombresAsociados(objEntCol, objEnt.RegionID, objEnt.PenalID)

            ''filtrar por fecha de ingreso del interno, del ultimo internamiento
            'If objEntFiltro.FechaIngresoIni > 0 Or objEntFiltro.FechaIngresoFin > 0 Then

            '    objEntNA = New Entity.Registro.InternoCol
            '    objEntNA = objEntColReturn

            '    objEntColReturn = FiltrarPorFechaIngreso(objEntNA, objEntFiltro.FechaIngresoIni, _
            '                                            objEntFiltro.FechaIngresoFin, _
            '                                            objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            'End If

            ''filtrar por delito generico y especifico
            'If objEntFiltro.IDDelitoGenerico > 0 Or objEntFiltro.IDDelitoEspecifico > 0 Then

            '    objEntNA = New Entity.Registro.InternoCol
            '    objEntNA = objEntColReturn

            '    objEntColReturn = FiltrarPorDelitos(objEntNA, objEntFiltro.IDDelitoGenerico, _
            '                                            objEntFiltro.IDDelitoEspecifico, _
            '                                            objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            'End If

            ''filtrar por situacion juridica del ultimo internamiento
            'If objEntFiltro.IDSituacionJuridica > 0 Then

            '    objEntNA = New Entity.Registro.InternoCol
            '    objEntNA = objEntColReturn

            '    objEntColReturn = FiltrarPorSituacionJuridica_v5(objEntNA, _
            '                                            objEntFiltro.IDSituacionJuridica, _
            '                                            objEntFiltro.IDRegion, objEntFiltro.IDPenal)
            'End If




            Return objEntCol
        End Function
        
#End Region
#Region "Listar_Huella"
        Public Function BuscarHuella(IDTemplate As Integer, IDRegion As Short, IDPenal As Short) As Integer

            Dim value As Integer = -1

            If IDTemplate < 1 Then
                Return value
            End If

            Dim strMensajeError As String = ""
            Dim intIDHuella As Integer = -1

            '1.- buscar en la tabla huella digital
            'Dim objBssHueDig As New Bussines.Biometria.HuellaDigital
            'Dim objEntFiltroHueDig As New Entity.Biometria.HuellaDigital

            'With objEntFiltroHueDig
            '    .IDTemplateHuella = IDTemplate
            '    .IDRegion = IDRegion
            '    .IDPenal = IDPenal
            'End With

            'intIDHuella = objBssHueDig.BuscarIDHuella(objEntFiltroHueDig, strMensajeError)

            '2.- buscar en la tabla visitante huella
            'If intIDHuella > 0 Then

            Dim objBssHueVis As New Bussines.Biometria.InternoHuellaTratamiento
            Dim objEntFiltroHueVis As New Entity.Biometria.InternoHuellaTratamiento

            With objEntFiltroHueVis
                .IDIndiceIzquierdo = intIDHuella
                .IDIndiceDerecho = intIDHuella
                .IDPulgarIzquierdo = intIDHuella
                .IDPulgarDerecho = intIDHuella
                .IDRegion = IDRegion
                .IDPenal = IDPenal
            End With

            value = objBssHueVis.BuscarIDInterno(objEntFiltroHueVis, strMensajeError)

            'End If

            Return value

        End Function
#End Region
#Region "Grabar"
        Private Function ValidarInternoTieneFechaAsistencia(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia,
                                                            ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim intCount As Short = 0

            intCount = Data.Tratamiento.TallerAsistencia.InternoAsistencia.ListarOutput("lst", "lst_val_asistencia_x_interno_fecha", objEnt)

            If intCount > 0 Then
                value = True
                strMensajeOut = "El interno ya cuenta con un registro de asistencia de la fecha: " & objEnt.FechaDate.ToString
            End If

            Return value

        End Function
        Public Function Grabar(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia,
                               ByRef strMensajeOut As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                If ValidarInternoTieneFechaAsistencia(objEnt, strMensajeOut) = True Then
                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Grabar(strAccion, strOpcion, objEnt)

            Return intValue
        End Function
        Public Function Grabar_v2(objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia,
                               ByRef strMensajeOut As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant_v2"

                If ValidarInternoTieneFechaAsistencia(objEnt, strMensajeOut) = True Then
                    Return intValue
                End If
            Else
                strAccion = "upd"
                strOpcion = "upd_mant_v2"
            End If

            intValue = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Grabar_v2(strAccion, strOpcion, objEnt)

            Return intValue
        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1

            intValue = Data.Tratamiento.TallerAsistencia.InternoAsistencia.Eliminar("del", "del_mant", Codigo)

            Return intValue

        End Function
       
#End Region
    End Class
End Namespace
