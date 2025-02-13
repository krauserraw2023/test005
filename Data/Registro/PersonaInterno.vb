Imports System.Data.SqlClient

Namespace Registro
    Public Class PersonaInterno
        Private Shared strNameProcedure As String = "pa_reg_mae_persona_interno"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.PersonaInterno) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_per_int_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_per_id", SqlDbType.Int)).Value = objEnt.PersonaId
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@c_cod_rp", SqlDbType.VarChar, 50)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@c_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApePaterno
                    .Parameters.Add(New SqlParameter("@c_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApeMaterno
                    .Parameters.Add(New SqlParameter("@c_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombre
                    .Parameters.Add(New SqlParameter("@b_reg_pri", SqlDbType.Bit)).Value = objEnt.NombrePrincipal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                       ByVal objEnt As Entity.Registro.PersonaInterno) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_per_int_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_per_id", SqlDbType.Int)).Value = objEnt.PersonaId
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@c_cod_rp", SqlDbType.VarChar, 50)).Value = objEnt.CodigoRP
                            .Parameters.Add(New SqlParameter("@c_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApePaterno
                            .Parameters.Add(New SqlParameter("@c_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApeMaterno
                            .Parameters.Add(New SqlParameter("@c_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombre
                            .Parameters.Add(New SqlParameter("@b_reg_pri", SqlDbType.Bit)).Value = objEnt.NombrePrincipal
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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef outSms As String) As Integer
            Dim intCodigo As Integer = -1

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_per_int_id", SqlDbType.Int)).Value = Codigo
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
    End Class
End Namespace