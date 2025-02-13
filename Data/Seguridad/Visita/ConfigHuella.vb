Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class ConfigHuella
        Private Shared strNameProcedure As String = "pa_VIS_mov_config_Huella"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.ConfigHuella) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cnf_hue_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@n_cnf_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@n_cnf_est", SqlDbType.SmallInt)).Value = objEnt.Estado
                            '.Parameters.Add(New SqlParameter("@n_fec_baj", SqlDbType.BigInt)).Value = objEnt.FechaBaja
                            '.Parameters.Add(New SqlParameter("@f_usu_id_baj", SqlDbType.Int)).Value = objEnt.IDUsuarioBaja
                            '.Parameters.Add(New SqlParameter("@c_des_mot_baj", SqlDbType.VarChar, 500)).Value = objEnt.MotivoBaja
                            '.Parameters.Add(New SqlParameter("@n_fec_alt", SqlDbType.BigInt)).Value = objEnt.FechaAlta
                            '.Parameters.Add(New SqlParameter("@f_usu_id_alt", SqlDbType.Int)).Value = objEnt.IDUsuarioAlta
                            '.Parameters.Add(New SqlParameter("@c_des_sol_alt", SqlDbType.VarChar, 500)).Value = objEnt.SolucionAlta
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.ConfigHuella) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_cnf_hue_id", SqlDbType.int)).Value = ObjEnt.Codigo
                    .Parameters.Add(New SqlParameter("@n_cnf_fec", SqlDbType.bigint)).Value = ObjEnt.Fecha
                    .Parameters.Add(New SqlParameter("@n_cnf_est", SqlDbType.smallint)).Value = ObjEnt.Estado
                    .Parameters.Add(New SqlParameter("@n_fec_baj", SqlDbType.bigint)).Value = ObjEnt.FechaBaja
                    .Parameters.Add(New SqlParameter("@f_usu_id_baj", SqlDbType.Int)).Value = objEnt.IDUsuarioBaja
                    .Parameters.Add(New SqlParameter("@c_des_mot_baj", SqlDbType.varchar, 500)).Value = ObjEnt.MotivoBaja
                    .Parameters.Add(New SqlParameter("@n_fec_alt", SqlDbType.bigint)).Value = ObjEnt.FechaAlta
                    .Parameters.Add(New SqlParameter("@f_usu_id_alt", SqlDbType.Int)).Value = objEnt.IDUsuarioAlta
                    .Parameters.Add(New SqlParameter("@c_des_sol_alt", SqlDbType.varchar, 500)).Value = ObjEnt.SolucionAlta
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.smallint)).Value = ObjEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.smallint)).Value = ObjEnt.IDPenal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.ConfigHuella) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cnf_hue_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@n_cnf_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@n_cnf_est", SqlDbType.SmallInt)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@n_fec_baj", SqlDbType.BigInt)).Value = objEnt.FechaBaja
                            .Parameters.Add(New SqlParameter("@f_usu_id_baj", SqlDbType.Int)).Value = objEnt.IDUsuarioBaja
                            .Parameters.Add(New SqlParameter("@c_des_mot_baj", SqlDbType.VarChar, 500)).Value = objEnt.MotivoBaja
                            .Parameters.Add(New SqlParameter("@n_fec_alt", SqlDbType.BigInt)).Value = objEnt.FechaAlta
                            .Parameters.Add(New SqlParameter("@f_usu_id_alt", SqlDbType.Int)).Value = objEnt.IDUsuarioAlta
                            .Parameters.Add(New SqlParameter("@c_des_sol_alt", SqlDbType.VarChar, 500)).Value = objEnt.SolucionAlta
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.ConfigHuella) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cnf_hue_id", SqlDbType.Int)).Value = objEnt.Codigo

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