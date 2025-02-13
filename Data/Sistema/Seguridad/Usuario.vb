Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Namespace Seguridad
    Public Class Usuario
        Private Shared strNameProcedure As String = "UP_SEC_Usuario"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal _accion As String, ByVal _opcion As String, _
        ByVal Codigo As Integer, ByVal Login As String, _
        ByVal TrabajadorID As Integer, ByVal TrabajadorApePaterno As String, _
        ByVal TrabajadorApeMaterno As String, ByVal TrabajadorNombres As String, ByVal NumDoc As String) As Integer

            Dim intValue As Integer = -1

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = _accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = _opcion
                            .Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@usu_log", SqlDbType.VarChar, 50)).Value = Login
                            .Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = TrabajadorID
                            .Parameters.Add(New SqlParameter("@usu_ape_pat", SqlDbType.VarChar, 50)).Value = TrabajadorApePaterno
                            .Parameters.Add(New SqlParameter("@usu_ape_mat", SqlDbType.VarChar, 50)).Value = TrabajadorApeMaterno
                            .Parameters.Add(New SqlParameter("@usu_nom", SqlDbType.VarChar, 50)).Value = TrabajadorNombres
                            .Parameters.Add(New SqlParameter("@usu_num_doc", SqlDbType.VarChar, 50)).Value = NumDoc

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value

                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return 0
            End Try

            Return intValue

        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal _accion As String, ByVal _opcion As String, _
        ByVal Codigo As Integer, ByVal Login As String, _
        ByVal TrabajadorID As Integer, ByVal TrabajadorApePaterno As String, _
        ByVal TrabajadorApeMaterno As String, ByVal TrabajadorNombres As String, ByVal NumDoc As String, _
        ByVal TipoUsuario As Integer, ByVal RegionID As Integer, ByVal PenalID As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                sqlCmd.CommandType = CommandType.StoredProcedure

                sqlCmd.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = _accion
                sqlCmd.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = _opcion
                sqlCmd.Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = Codigo

                sqlCmd.Parameters.Add(New SqlParameter("@usu_log", SqlDbType.VarChar, 50)).Value = Login
                sqlCmd.Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = TrabajadorID
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape_pat", SqlDbType.VarChar, 50)).Value = TrabajadorApePaterno
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape_mat", SqlDbType.VarChar, 50)).Value = TrabajadorApeMaterno
                sqlCmd.Parameters.Add(New SqlParameter("@usu_nom", SqlDbType.VarChar, 50)).Value = TrabajadorNombres
                sqlCmd.Parameters.Add(New SqlParameter("@usu_num_doc", SqlDbType.VarChar, 50)).Value = NumDoc
                sqlCmd.Parameters.Add(New SqlParameter("@usu_niv", SqlDbType.Int)).Value = TipoUsuario

                sqlCmd.Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                sqlCmd.Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException

                Throw New Exception(ex.Message)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            Finally
                'sqlCon.Dispose()
            End Try

            Return sqlReader
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                    objEnt As Legolas.LEntity.Seguridad.Usuario) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                sqlCmd.CommandType = CommandType.StoredProcedure

                sqlCmd.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                sqlCmd.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = strOpcion
                sqlCmd.Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = objEnt.Codigo

                sqlCmd.Parameters.Add(New SqlParameter("@usu_log", SqlDbType.VarChar, 50)).Value = objEnt.Login
                sqlCmd.Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = objEnt.TrabajadorID
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape", SqlDbType.VarChar, 50)).Value = objEnt.Apellidos
                sqlCmd.Parameters.Add(New SqlParameter("@usu_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                sqlCmd.Parameters.Add(New SqlParameter("@usu_num_doc", SqlDbType.VarChar, 50)).Value = objEnt.NumeroDocumento
                sqlCmd.Parameters.Add(New SqlParameter("@usu_niv", SqlDbType.Int)).Value = objEnt.Tipo
                sqlCmd.Parameters.Add(New SqlParameter("@dep_id", SqlDbType.Int)).Value = objEnt.Dependencia

                sqlCmd.Parameters.Add(New SqlParameter("@usu_est", SqlDbType.Int)).Value = objEnt.Estado
                sqlCmd.Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
                sqlCmd.Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.IDPenal

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException

                Throw New Exception(ex.Message)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            Finally
                'sqlCon.Dispose()
            End Try

            Return sqlReader
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String, objEnt As Entity.Sistema.Seguridad.Usuario) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                sqlCmd.CommandType = CommandType.StoredProcedure

                sqlCmd.Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                sqlCmd.Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 255)).Value = strOpcion
                sqlCmd.Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = objEnt.Codigo

                sqlCmd.Parameters.Add(New SqlParameter("@mod_id", SqlDbType.Int)).Value = objEnt.ModuloId
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                sqlCmd.Parameters.Add(New SqlParameter("@usu_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                sqlCmd.Parameters.Add(New SqlParameter("@usu_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                sqlCmd.Parameters.Add(New SqlParameter("@usu_num_doc", SqlDbType.VarChar, 50)).Value = objEnt.NumeroDocumento

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)

            Catch ex As SqlException

                Throw New Exception(ex.Message)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            Finally
                'sqlCon.Dispose()
            End Try

            Return sqlReader
        End Function
#End Region
#Region "Grabar"
        Public Shared Function Grabar_v2(ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Sistema.Seguridad.Usuario, ClaveCifrada As String) As Integer

            Dim value As Integer = -1

            Try
                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 250)).Value = opcion
                    .Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@usu_niv", SqlDbType.Int)).Value = objEnt.Tipo 'tipo usuario

                    Dim sqlPrmNombre As SqlParameter = sqlCmd.Parameters.Add("@usu_log", SqlDbType.VarChar, 50)
                    sqlPrmNombre.Direction = ParameterDirection.InputOutput
                    sqlPrmNombre.Value = objEnt.Login

                    .Parameters.Add(New SqlParameter("@cue_usu", SqlDbType.Int)).Value = objEnt.CueUsuario
                    .Parameters.Add(New SqlParameter("@cue_tra", SqlDbType.Int)).Value = objEnt.CueTrabajador
                    .Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = objEnt.TrabajadorID
                    .Parameters.Add(New SqlParameter("@cue_log", SqlDbType.VarChar, 50)).Value = objEnt.CueLogin

                    .Parameters.Add(New SqlParameter("@usu_psw", SqlDbType.VarChar, 256)).Value = ClaveCifrada
                    .Parameters.Add(New SqlParameter("@usu_psw_new", SqlDbType.Bit)).Value = objEnt.ClaveNueva

                    .Parameters.Add(New SqlParameter("@usu_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@usu_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@usu_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@usu_num_doc", SqlDbType.VarChar, 10)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@dep_id", SqlDbType.Int)).Value = objEnt.Dependencia
                    .Parameters.Add(New SqlParameter("@usu_cgo_nom", SqlDbType.VarChar, 120)).Value = objEnt.CargoNombre 'cargo
                    .Parameters.Add(New SqlParameter("@c_cor_ins", SqlDbType.VarChar, 100)).Value = objEnt.Correo  'cargo
                    .Parameters.Add(New SqlParameter("@usu_validar_x_huella", SqlDbType.Bit)).Value = objEnt.ValidarPorHUella

                    '/*permisos*/               
                    .Parameters.Add(New SqlParameter("@adm_val_pc", SqlDbType.Bit)).Value = objEnt.AdminValidarPC
                    .Parameters.Add(New SqlParameter("@adm_mod_usu", SqlDbType.Bit)).Value = objEnt.AdminModuloUsuario

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                    Dim PrmINSERTO As SqlParameter = sqlCmd.Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    PrmINSERTO.Direction = ParameterDirection.Output


                    sqlCon.Open()
                    .ExecuteNonQuery()

                    value = PrmINSERTO.Value
                    objEnt.CueLogin = sqlPrmNombre.Value

                    sqlCon.Close()
                End With
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

            Return value
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      objEnt As Legolas.LEntity.Seguridad.Usuario, ClaveCifrada As String) As Integer

            Dim value As Integer = -1

            Try
                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 250)).Value = opcion
                    .Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@usu_niv", SqlDbType.Int)).Value = objEnt.Tipo 'tipo usuario

                    Dim sqlPrmNombre As SqlParameter = sqlCmd.Parameters.Add("@usu_log", SqlDbType.VarChar, 50)
                    sqlPrmNombre.Direction = ParameterDirection.InputOutput
                    sqlPrmNombre.Value = objEnt.Login

                    .Parameters.Add(New SqlParameter("@cue_usu", SqlDbType.Int)).Value = objEnt.CueUsuario
                    .Parameters.Add(New SqlParameter("@cue_tra", SqlDbType.Int)).Value = objEnt.CueTrabajador
                    .Parameters.Add(New SqlParameter("@tra_id", SqlDbType.Int)).Value = objEnt.TrabajadorID
                    .Parameters.Add(New SqlParameter("@cue_log", SqlDbType.VarChar, 50)).Value = objEnt.CueLogin

                    .Parameters.Add(New SqlParameter("@usu_psw", SqlDbType.VarChar, 256)).Value = ClaveCifrada
                    .Parameters.Add(New SqlParameter("@usu_psw_new", SqlDbType.Bit)).Value = objEnt.ClaveNueva

                    .Parameters.Add(New SqlParameter("@usu_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@usu_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@usu_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@usu_num_doc", SqlDbType.VarChar, 10)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@dep_id", SqlDbType.Int)).Value = objEnt.Dependencia
                    .Parameters.Add(New SqlParameter("@usu_cgo_nom", SqlDbType.VarChar, 120)).Value = objEnt.CargoNombre 'cargo
                    .Parameters.Add(New SqlParameter("@c_cor_ins", SqlDbType.VarChar, 100)).Value = objEnt.Correo  'cargo

                    '/*permisos*/               
                    .Parameters.Add(New SqlParameter("@adm_val_pc", SqlDbType.Bit)).Value = objEnt.AdminValidarPC
                    .Parameters.Add(New SqlParameter("@adm_mod_usu", SqlDbType.Bit)).Value = objEnt.AdminModuloUsuario

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

                    Dim PrmINSERTO As SqlParameter = sqlCmd.Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    PrmINSERTO.Direction = ParameterDirection.Output


                    sqlCon.Open()
                    .ExecuteNonQuery()

                    value = PrmINSERTO.Value
                    objEnt.CueLogin = sqlPrmNombre.Value

                    sqlCon.Close()
                End With
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

            Return value
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      intIDUsuario As Integer, blnReseteoClave As Boolean, ClaveCifrada As String) As Integer

            Dim value As Integer = -1

            Try
                Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)

                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 250)).Value = opcion

                    .Parameters.Add(New SqlParameter("@usu_id", SqlDbType.Int)).Value = intIDUsuario
                    .Parameters.Add(New SqlParameter("@usu_psw_new", SqlDbType.Bit)).Value = blnReseteoClave
                    .Parameters.Add(New SqlParameter("@usu_psw", SqlDbType.VarChar, 256)).Value = ClaveCifrada
                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo

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


#End Region
    End Class
End Namespace