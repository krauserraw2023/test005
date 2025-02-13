Imports System.Data.SqlClient

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFicha_DA
        Private Shared strNameProcedure As String = "usp_tra_asi_mov_interno_penal_ficha"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                                      objEntFiltro As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion
                    .Parameters.Add(New SqlParameter("@pk_int_pen_fic_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = objEntFiltro.CodigoPadre
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEntFiltro.IDInterno
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEntFiltro.IDInternoIngreso
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntFiltro.IDInternoIngresoInpe
                    .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = objEntFiltro.IDFichaTipo
                    .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = objEntFiltro.IDFicha
                    .Parameters.Add(New SqlParameter("@n_num_cla", SqlDbType.Int)).Value = objEntFiltro.NumeroClasificacion
                    .Parameters.Add(New SqlParameter("@n_fec_cla", SqlDbType.Int)).Value = objEntFiltro.FechaClasificacion
                    .Parameters.Add(New SqlParameter("@n_est", SqlDbType.Int)).Value = objEntFiltro.Estado
                    .Parameters.Add(New SqlParameter("@n_grp_sec", SqlDbType.SmallInt)).Value = objEntFiltro.FichaGrupo

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEntFiltro.IDRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEntFiltro.IDPenal
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Grabar(ByVal strAccion As String, ByVal strOpcion As String,
                                     ByVal objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.InternoFicha_BE) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@pk_int_pen_fic_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.IDInterno
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.IDInternoIngreso
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IDInternoIngresoInpe
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id", SqlDbType.Int)).Value = objEnt.CodigoPadre
                            .Parameters.Add(New SqlParameter("@fk_tip_fic_id", SqlDbType.Int)).Value = objEnt.IDFichaTipo
                            .Parameters.Add(New SqlParameter("@fk_fic_id", SqlDbType.Int)).Value = objEnt.IDFicha

                            .Parameters.Add(New SqlParameter("@n_sit_jur_id", SqlDbType.SmallInt)).Value = objEnt.InternoIDSituacionJuridica
                            .Parameters.Add(New SqlParameter("@n_reg_id", SqlDbType.Int)).Value = objEnt.InternoIDRegimen
                            .Parameters.Add(New SqlParameter("@n_etp_id", SqlDbType.Int)).Value = objEnt.InternoIDEtapa
                            .Parameters.Add(New SqlParameter("@n_num_cla", SqlDbType.Int)).Value = objEnt.NumeroClasificacion
                            .Parameters.Add(New SqlParameter("@n_fec_cla", SqlDbType.BigInt)).Value = objEnt.FechaClasificacion
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 2000)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@n_pun", SqlDbType.VarChar, 400)).Value = objEnt.Puntaje
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@c_mot_cam_res", SqlDbType.VarChar, 500)).Value = objEnt.MotivoCambio
                            .Parameters.Add(New SqlParameter("@c_pert_org_crim", SqlDbType.VarChar, 1)).Value = objEnt.PerteneceOrgCriminal

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                            '.Parameters.Add(New SqlParameter("@cla_obvs_2", SqlDbType.Text, 0)).Value = objEnt.Observacion_02_rtf

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                            Return intCodigo
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function

    End Class

End Namespace
