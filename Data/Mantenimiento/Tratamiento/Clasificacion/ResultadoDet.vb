Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class ResultadoDet
        Private Shared strNameProcedure As String = "pa_tra_asi_mae_ficha_resultado_det"
        'dss
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_fic_res_det_id", SqlDbType.SmallInt)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_fic_res_id", SqlDbType.SmallInt)).Value = objEnt.IDFichaResultado
                    .Parameters.Add(New SqlParameter("@n_nac_int", SqlDbType.SmallInt)).Value = objEnt.NacionalidadInterno


                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarPenal(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_fic_res_det_id", SqlDbType.SmallInt)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_fic_res_id", SqlDbType.SmallInt)).Value = objEnt.IDFichaResultado
                    .Parameters.Add(New SqlParameter("@n_nac_int", SqlDbType.SmallInt)).Value = objEnt.NacionalidadInterno
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.PenalId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(Accion As String, Opcion As String, objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.ResultadoDet_BE) As Integer
            Dim intCodigo As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = Accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = Opcion

                            .Parameters.Add(New SqlParameter("@pk_fic_res_det_id", SqlDbType.SmallInt)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_fic_res_id", SqlDbType.SmallInt)).Value = objEnt.IDFichaResultado
                            .Parameters.Add(New SqlParameter("@n_nac_int", SqlDbType.Int)).Value = objEnt.NacionalidadInterno
                            .Parameters.Add(New SqlParameter("@n_ptj_ini", SqlDbType.Decimal)).Value = objEnt.PuntajeInicial
                            .Parameters.Add(New SqlParameter("@n_ptj_fin", SqlDbType.Decimal)).Value = objEnt.PuntajeFinal
                            .Parameters.Add(New SqlParameter("@c_des", SqlDbType.VarChar, 100)).Value = objEnt.Descripcion
                            .Parameters.Add(New SqlParameter("@n_tbl_id", SqlDbType.VarChar, 100)).Value = objEnt.IDTabla

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intCodigo = .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return intCodigo
        End Function

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
                                        ByRef outErrSms As String) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_fic_res_det_id", SqlDbType.SmallInt)).Value = Codigo

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
            Catch sql As SqlException
                outErrSms = sql.Message
                Return -1
            Catch ex As Exception
                outErrSms = ex.Message
                Return -1
            End Try
        End Function


    End Class
End Namespace