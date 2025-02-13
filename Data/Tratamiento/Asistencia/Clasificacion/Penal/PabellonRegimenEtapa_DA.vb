Imports System.Data.SqlClient

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class PabellonRegimenEtapa_DA
        Private Shared strNameProcedure As String = "usp_tra_asi_mov_pabellon_regimen_etapa"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                                      entFicha As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE) As SqlDataReader

            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                    .Parameters.Add(New SqlParameter("@pk_pab_reg_etp_id", SqlDbType.Int)).Value = entFicha.Codigo
                    .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = entFicha.IDPabellon
                    .Parameters.Add(New SqlParameter("@n_reg_id", SqlDbType.SmallInt)).Value = entFicha.IDRegimen
                    .Parameters.Add(New SqlParameter("@n_etp_id", SqlDbType.SmallInt)).Value = entFicha.IDEtapa

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = entFicha.IDRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = entFicha.IDPenal

                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

        Public Shared Function Grabar(ByVal strAccion As String, ByVal strOpcion As String,
                                      ByVal objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@pk_pab_reg_etp_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_pab_id", SqlDbType.Int)).Value = objEnt.IDPabellon
                            .Parameters.Add(New SqlParameter("@n_reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegimen
                            .Parameters.Add(New SqlParameter("@n_etp_id", SqlDbType.SmallInt)).Value = objEnt.IDEtapa

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.IDPenal

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, intCodigo As Integer) As Integer

            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pab_reg_etp_id", SqlDbType.Int)).Value = intCodigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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