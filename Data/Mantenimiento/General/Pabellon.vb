Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.General
    Public Class Pabellon
        Private Shared strNameProcedure As String = "UP_INT_Pabellon"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As Integer

            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@pab_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombre
                            .Parameters.Add(New SqlParameter("@pab_nom_cor", SqlDbType.VarChar, 50)).Value = objEnt.NombreCorto
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@pab_obs", SqlDbType.VarChar, 500)).Value = objEnt.Obs
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.Estado

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                      ByVal opcion As String, ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@pab_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombre
                    .Parameters.Add(New SqlParameter("@pab_nom_cor", SqlDbType.VarChar, 50)).Value = objEnt.NombreCorto
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@pab_obs", SqlDbType.VarChar, 500)).Value = objEnt.Obs
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.Estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As Integer

            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@pab_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombre
                            .Parameters.Add(New SqlParameter("@pab_nom_cor", SqlDbType.VarChar, 50)).Value = objEnt.NombreCorto
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@pab_obs", SqlDbType.VarChar, 500)).Value = objEnt.Obs
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.Estado

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, _
                                        ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As Integer

            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pab_id", SqlDbType.Int)).Value = objEnt.Codigo

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