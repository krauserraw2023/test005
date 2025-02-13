Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia

    Public Class PlanillaCabecera
        Private Shared strNameProcedure As String = "USP_tra_tal_planilla_cab"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pla_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@kf_reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@kf_pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                            .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.Int)).Value = objEnt.IDTaller
                            .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.SmallInt)).Value = objEnt.Anio
                            .Parameters.Add(New SqlParameter("@n_mes", SqlDbType.SmallInt)).Value = objEnt.Mes
                            .Parameters.Add(New SqlParameter("@n_cor", SqlDbType.SmallInt)).Value = objEnt.Correlativo
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = objEnt.Estado

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Value = .Parameters("@variable_out").Value
                            Return Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_pla_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@kf_pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.Int)).Value = objEnt.IDTaller
                    .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.SmallInt)).Value = objEnt.Anio
                    .Parameters.Add(New SqlParameter("@n_mes", SqlDbType.SmallInt)).Value = objEnt.Mes
                    .Parameters.Add(New SqlParameter("@n_cor", SqlDbType.SmallInt)).Value = objEnt.Correlativo
                    .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = objEnt.Estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pla_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@kf_reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@kf_pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                            .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.Int)).Value = objEnt.IDTaller
                            .Parameters.Add(New SqlParameter("@n_anio", SqlDbType.SmallInt)).Value = objEnt.Anio
                            .Parameters.Add(New SqlParameter("@n_mes", SqlDbType.SmallInt)).Value = objEnt.Mes
                            .Parameters.Add(New SqlParameter("@n_cor", SqlDbType.SmallInt)).Value = objEnt.Correlativo

                            .Parameters.Add(New SqlParameter("@n_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                            .Parameters.Add(New SqlParameter("@n_fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                            .Parameters.Add(New SqlParameter("@n_fec_pro", SqlDbType.BigInt)).Value = objEnt.FechaProceso

                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = objEnt.Estado

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
                Return -1
            End Try
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaCabecera) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pla_id", SqlDbType.Int)).Value = objEnt.Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
                Return -1
            End Try
        End Function
    End Class
End Namespace