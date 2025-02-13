Imports System.Data.SqlClient

Namespace Registro.Carceleta.Clasificacion.InternoClasificacion
    Public Class InternoFichaDetalle_DA
        Private Shared strNameProcedure As String = "pa_tra_asi_mov_interno_ficha_det"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, entFicha As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_det_id", SqlDbType.Int)).Value = entFicha.Codigo
                    .Parameters.Add(New SqlParameter("@fk_var_id", SqlDbType.Int)).Value = entFicha.VariableId
                    .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = entFicha.InternoFichaId

                    .Parameters.Add(New SqlParameter("@fk_ind_id", SqlDbType.Int)).Value = entFicha.IndicadorId
                    .Parameters.Add(New SqlParameter("@det_est", SqlDbType.Int)).Value = entFicha.Estado
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = entFicha.RegionId
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = entFicha.PenalId
                    '
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_cla_id", SqlDbType.Int)).Value = Codigo
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
                Return -1
            End Try
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Clasificacion.InternoClasificacion.InternoFichaDetalle) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_det_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_fic_id", SqlDbType.Int)).Value = objEnt.InternoFichaId
                            '
                            .Parameters.Add(New SqlParameter("@fk_var_id", SqlDbType.Int)).Value = objEnt.VariableId
                            .Parameters.Add(New SqlParameter("@fk_ind_id", SqlDbType.Int)).Value = objEnt.IndicadorId
                            .Parameters.Add(New SqlParameter("@det_num_pond", SqlDbType.VarChar, 400)).Value = objEnt.Ponderacion
                            .Parameters.Add(New SqlParameter("@det_no_prev", SqlDbType.Int)).Value = objEnt.PonderacionNoPrevista
                            .Parameters.Add(New SqlParameter("@det_est", SqlDbType.Int)).Value = objEnt.Estado
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId

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