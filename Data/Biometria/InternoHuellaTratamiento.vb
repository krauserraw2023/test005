Imports System.Data.SqlClient

Namespace Biometria
    Public Class InternoHuellaTratamiento
        Private Shared strNameProcedure As String = "usp_mov_interno_huella_tratamiento"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, accion As String, opcion As String, objEnt As Entity.Biometria.InternoHuellaTratamiento,
                                      ByRef out_sms As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 1800
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_hue_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objEnt.IDInterno
                    .Parameters.Add(New SqlParameter("@fk_hue_ind_izq_id", SqlDbType.Int)).Value = objEnt.IDIndiceIzquierdo
                    .Parameters.Add(New SqlParameter("@fk_hue_pul_izq_id", SqlDbType.Int)).Value = objEnt.IDPulgarIzquierdo
                    .Parameters.Add(New SqlParameter("@fk_hue_ind_der_id", SqlDbType.Int)).Value = objEnt.IDIndiceDerecho
                    .Parameters.Add(New SqlParameter("@fk_hue_pul_der_id", SqlDbType.Int)).Value = objEnt.IDPulgarDerecho

                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion

                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output
                End With

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Grabar(accion As String, opcion As String, ByVal objEnt As Entity.Biometria.InternoHuellaTratamiento, ByRef out_sms As String) As Integer
            Dim intCodigo As Integer = -1
            Dim sqlCon As SqlConnection
            Dim sqlCmd As SqlCommand
            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_hue_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objEnt.IDInterno

                    .Parameters.Add(New SqlParameter("@n_vis_hue_rec", SqlDbType.SmallInt)).Value = objEnt.NumeroRecaptura
                    .Parameters.Add(New SqlParameter("@n_vis_hue_fec_cap", SqlDbType.BigInt)).Value = objEnt.FechaCaptura
                    .Parameters.Add(New SqlParameter("@n_vis_hue_est", SqlDbType.SmallInt)).Value = objEnt.EstadoHuella
                    .Parameters.Add(New SqlParameter("@kf_usu_id_ina_hue", SqlDbType.Int)).Value = objEnt.IDUsuarioInactivaHuella
                    .Parameters.Add(New SqlParameter("@n_vis_hue_fec_ina_hue", SqlDbType.BigInt)).Value = objEnt.FechaInactivaHuella

                    .Parameters.Add(New SqlParameter("@n_int_hue_tip_cap_izq", SqlDbType.SmallInt)).Value = objEnt.TipoCapturaIzquierdo
                    .Parameters.Add(New SqlParameter("@fk_hue_ind_izq_id", SqlDbType.Int)).Value = objEnt.IDIndiceIzquierdo
                    .Parameters.Add(New SqlParameter("@n_vis_hue_cal_ind_izq", SqlDbType.SmallInt)).Value = objEnt.CalidadIndiceIzquierdo
                    .Parameters.Add(New SqlParameter("@fk_hue_pul_izq_id", SqlDbType.Int)).Value = objEnt.IDPulgarIzquierdo
                    .Parameters.Add(New SqlParameter("@n_vis_hue_cal_pul_izq", SqlDbType.SmallInt)).Value = objEnt.CalidadPulgarIzquierdo
                    .Parameters.Add(New SqlParameter("@c_vis_hue_obs_izq", SqlDbType.VarChar, 500)).Value = objEnt.ObservacionIzquierdo

                    .Parameters.Add(New SqlParameter("@n_int_hue_tip_cap_der", SqlDbType.SmallInt)).Value = objEnt.TipoCapturaDerecho
                    .Parameters.Add(New SqlParameter("@fk_hue_ind_der_id", SqlDbType.Int)).Value = objEnt.IDIndiceDerecho
                    .Parameters.Add(New SqlParameter("@n_vis_hue_cal_ind_der", SqlDbType.SmallInt)).Value = objEnt.CalidadIndiceDerecho
                    .Parameters.Add(New SqlParameter("@fk_hue_pul_der_id", SqlDbType.Int)).Value = objEnt.IDPulgarDerecho
                    .Parameters.Add(New SqlParameter("@n_vis_hue_cal_pul_der", SqlDbType.SmallInt)).Value = objEnt.CalidadPulgarDerecho
                    .Parameters.Add(New SqlParameter("@c_vis_hue_obs_der", SqlDbType.VarChar, 500)).Value = objEnt.ObservacionDerecho

                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return intCodigo
        End Function

        Public Shared Function Eliminar(accion As String, opcion As String, Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intCodigo As Integer = -1
            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_vis_hue_id", SqlDbType.Int)).Value = Codigo

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return intCodigo
        End Function
    End Class
End Namespace