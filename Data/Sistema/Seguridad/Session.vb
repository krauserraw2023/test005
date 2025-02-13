Imports System.Data.SqlClient

Namespace Sistema.Seguridad
    Public Class Session
        Private Shared strNameProcedure As String = "UP_SEC_SesionUsuario"

        Public Shared Function Listar(objEnt As Entity.Sistema.Seguridad.Session) As Entity.Sistema.Seguridad.SessionCol
            Dim col As New Entity.Sistema.Seguridad.SessionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                sqlCmd.CommandType = CommandType.StoredProcedure

                sqlCmd.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "lst"
                sqlCmd.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = "lst_mant"
                sqlCmd.Parameters.Add(New SqlParameter("@pk_sesion_id", SqlDbType.Int)).Value = objEnt.Codigo

                sqlCmd.Parameters.Add(New SqlParameter("@usu_login", SqlDbType.VarChar, 50)).Value = objEnt.Login
                sqlCmd.Parameters.Add(New SqlParameter("@fk_usuario_id", SqlDbType.Int)).Value = objEnt.UsuarioId
                sqlCmd.Parameters.Add(New SqlParameter("@pc_mac", SqlDbType.VarChar, 50)).Value = objEnt.MacPC

                sqlCmd.Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionId
                sqlCmd.Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalId

                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException
                Throw New Exception(ex.Message)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                'sqlCon.Dispose()
            End Try

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Sistema.Seguridad.Session

                        With objEnt
                            .Codigo = Integer.Parse(sqlDr("pk_sesion_id").ToString)
                            .UsuarioId = sqlDr("fk_usuario_id").ToString
                            .Login = sqlDr("usu_login").ToString
                            .MacPC = sqlDr("pc_mac").ToString
                            .FechaHora = sqlDr("fecha_hora").ToString
                            .SesionActivo = sqlDr("sesion_activo").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString

                        End With
                        col.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return col

        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Sistema.Seguridad.Session) As Integer

            Dim value As Integer = -1

            Try
                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_sesion_id", SqlDbType.Int)).Value = objEnt.Codigo

                    .Parameters.Add(New SqlParameter("@usu_login", SqlDbType.VarChar, 50)).Value = objEnt.Login
                    .Parameters.Add(New SqlParameter("@fk_usuario_id", SqlDbType.Int)).Value = objEnt.UsuarioId
                    .Parameters.Add(New SqlParameter("@sesion_activo", SqlDbType.Int)).Value = objEnt.SesionActivo
                    .Parameters.Add(New SqlParameter("@pc_mac", SqlDbType.VarChar, 50)).Value = objEnt.MacPC

                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionId
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalId

                    Dim PrmINSERTO As SqlParameter = sqlCmd.Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    PrmINSERTO.Direction = ParameterDirection.Output

                    sqlCon.Open()
                    value = .ExecuteNonQuery()

                    sqlCon.Close()
                End With
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

            Return value
        End Function
    End Class

End Namespace
