Imports System.Data.SqlClient
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoPabellon_DA
        Private Shared strNameProcedure As String = "usp_tra_asi_mov_interno_pabellon"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      ent As InternoPabellon_BE) As SqlDataReader

            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_pab_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = ent.IDInterno
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = ent.IDIngreso
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = ent.IDIngresoInpe
                    .Parameters.Add(New SqlParameter("@c_tip_proc_clasif", SqlDbType.VarChar, 2)).Value = ent.TipoProcesoClasificacion
                    .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id_etp", SqlDbType.Int)).Value = ent.IDFichaEtapa
                    .Parameters.Add(New SqlParameter("@n_est", SqlDbType.Int)).Value = ent.Estado
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = ent.IDRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = ent.IDPenal
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
        Public Shared Function Grabar(ByVal strAccion As String, ByVal strOpcion As String,
                                      ByVal ent As InternoPabellon_BE) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@pk_int_pab_id", SqlDbType.Int)).Value = ent.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = ent.IDInterno
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = ent.IDIngreso
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = ent.IDIngresoInpe
                            .Parameters.Add(New SqlParameter("@n_fec_cla_regimen", SqlDbType.BigInt)).Value = ent.FechaClasificacionRegimen
                            .Parameters.Add(New SqlParameter("@n_fec_cla_etapa", SqlDbType.BigInt)).Value = ent.FechaClasificacionEtapa
                            .Parameters.Add(New SqlParameter("@n_num_cla_regimen", SqlDbType.SmallInt)).Value = ent.NumeroClasificacionRegimen
                            .Parameters.Add(New SqlParameter("@n_num_cla_etapa", SqlDbType.BigInt)).Value = ent.NumeroClasificacionEtapa
                            .Parameters.Add(New SqlParameter("@c_tip_proc_clasif", SqlDbType.VarChar, 2)).Value = ent.TipoProcesoClasificacion
                            .Parameters.Add(New SqlParameter("@n_sit_jur_id", SqlDbType.SmallInt)).Value = ent.IDSituacionJuridica
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id_reg", SqlDbType.SmallInt)).Value = ent.IDFichaRegimen
                            .Parameters.Add(New SqlParameter("@n_reg_int_id", SqlDbType.SmallInt)).Value = ent.IDRegimen
                            .Parameters.Add(New SqlParameter("@fk_int_pen_fic_id_etp", SqlDbType.SmallInt)).Value = ent.IDFichaEtapa
                            .Parameters.Add(New SqlParameter("@n_etp_int_id", SqlDbType.SmallInt)).Value = ent.IDEtapa
                            .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = ent.IDPabellon
                            .Parameters.Add(New SqlParameter("@fk_ala_id", SqlDbType.Int)).Value = ent.AlaId

                            '.Parameters.Add(New SqlParameter("@c_pis", SqlDbType.VarChar, 20)).Value = objEnt.Piso
                            '.Parameters.Add(New SqlParameter("@c_amb", SqlDbType.VarChar, 20)).Value = objEnt.Ambiente
                            '.Parameters.Add(New SqlParameter("@c_ale", SqlDbType.VarChar, 20)).Value = objEnt.Ala

                            .Parameters.Add(New SqlParameter("@c_amb", SqlDbType.VarChar, 100)).Value = ent.Ambiente
                            .Parameters.Add(New SqlParameter("@c_cam", SqlDbType.VarChar, 100)).Value = ent.Cama
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = ent.Estado
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 1000)).Value = ent.Observacion

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = ent.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = ent.IDPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class

End Namespace
