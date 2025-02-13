Imports System.Data
Imports System.Data.SqlClient
Namespace Sistema
    Public Class Instalacion
        Private Shared strNameProcedure As String = "UP_SYS_Instalacion"


        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ent As Entity.Sistema.Instalacion) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@ins_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@ins_nom", SqlDbType.VarChar, 50)).Value = ent.Nombre
                    '.Parameters.Add(New SqlParameter("@ins_des", SqlDbType.VarChar, 500)).Value = Descripcion
                    .Parameters.Add(New SqlParameter("@ins_fec", SqlDbType.BigInt)).Value = ent.Fecha
                    .Parameters.Add(New SqlParameter("@ins_nom_cor", SqlDbType.VarChar, 150)).Value = ent.NombreCorto
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = ent.RegionID
                    .Parameters.Add(New SqlParameter("@ins_log", SqlDbType.Bit)).Value = ent.Logmein
                    .Parameters.Add(New SqlParameter("@ins_int", SqlDbType.Bit)).Value = ent.Internet
                    .Parameters.Add(New SqlParameter("@ins_ver_app", SqlDbType.VarChar, 10)).Value = ent.VersionApp
                    .Parameters.Add(New SqlParameter("@ins_ver_db", SqlDbType.VarChar, 10)).Value = ent.VersionBD
                    .Parameters.Add(New SqlParameter("@ins_tip_id", SqlDbType.Int)).Value = ent.Tipo
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = ent.IDPenal
                    '.Parameters.Add(New SqlParameter("@ins_obs", SqlDbType.VarChar, 500)).Value = Obs
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Nombre As String, _
        ByVal NombreCorto As String, _
        ByVal Fecha As Long, _
        ByVal RegionID As Integer, _
        ByVal Logmein As Boolean, _
        ByVal Internet As Boolean, _
        ByVal VersionApp As String, _
        ByVal VersionBD As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@ins_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@ins_nom", SqlDbType.VarChar, 50)).Value = Nombre
                    '.Parameters.Add(New SqlParameter("@ins_des", SqlDbType.VarChar, 500)).Value = Descripcion
                    .Parameters.Add(New SqlParameter("@ins_fec", SqlDbType.BigInt)).Value = Fecha
                    .Parameters.Add(New SqlParameter("@ins_nom_cor", SqlDbType.VarChar, 150)).Value = NombreCorto
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@ins_log", SqlDbType.Bit)).Value = Logmein
                    .Parameters.Add(New SqlParameter("@ins_int", SqlDbType.Bit)).Value = Internet
                    .Parameters.Add(New SqlParameter("@ins_ver_app", SqlDbType.VarChar, 10)).Value = VersionApp
                    .Parameters.Add(New SqlParameter("@ins_ver_db", SqlDbType.VarChar, 10)).Value = VersionBD
                    '.Parameters.Add(New SqlParameter("@ins_obs", SqlDbType.VarChar, 500)).Value = Obs
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
        ByVal Codigo As Integer, _
        ByVal Usuario As Integer, _
        ByVal VersionApp As String, _
        ByVal VersionBD As String) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@ins_id", SqlDbType.Int)).Value = Codigo
                            '.Parameters.Add(New SqlParameter("@ins_nom", SqlDbType.VarChar, 50)).Value = Nombre
                            '.Parameters.Add(New SqlParameter("@ins_des", SqlDbType.VarChar, 500)).Value = Descripcion
                            '.Parameters.Add(New SqlParameter("@ins_fec", SqlDbType.BigInt)).Value = Fecha
                            '.Parameters.Add(New SqlParameter("@ins_nom_cor", SqlDbType.VarChar, 150)).Value = NombreCorto
                            '.Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            '.Parameters.Add(New SqlParameter("@ins_log", SqlDbType.Bit)).Value = Logmein
                            '.Parameters.Add(New SqlParameter("@ins_int", SqlDbType.Bit)).Value = Internet
                            .Parameters.Add(New SqlParameter("@ins_ver_app", SqlDbType.VarChar, 10)).Value = VersionApp
                            .Parameters.Add(New SqlParameter("@ins_ver_db", SqlDbType.VarChar, 10)).Value = VersionBD
                            '.Parameters.Add(New SqlParameter("@ins_obs", SqlDbType.VarChar, 500)).Value = Obs
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            intValue = .Parameters("@variable_out").Value
                            Return intValue
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Tipo As Short, ByVal Nombre As String, _
        ByVal Descripcion As String, _
        ByVal Fecha As Long, _
        ByVal NombreCorto As String, _
        ByVal RegionID As Short, IDPenal As Short, _
        ByVal Logmein As Boolean, _
        ByVal Internet As Boolean, _
        ByVal VersionApp As String, _
        ByVal VersionBD As String, _
        ByVal Obs As String, _
        ByVal _eliminado As Boolean, ByVal Usuario As Integer) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@ins_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@ins_tip_id", SqlDbType.Int)).Value = Tipo
                            .Parameters.Add(New SqlParameter("@ins_nom", SqlDbType.VarChar, 50)).Value = Nombre
                            .Parameters.Add(New SqlParameter("@ins_des", SqlDbType.VarChar, 500)).Value = Descripcion
                            .Parameters.Add(New SqlParameter("@ins_fec", SqlDbType.BigInt)).Value = Fecha
                            .Parameters.Add(New SqlParameter("@ins_nom_cor", SqlDbType.VarChar, 150)).Value = NombreCorto

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = IDPenal

                            .Parameters.Add(New SqlParameter("@ins_log", SqlDbType.Bit)).Value = Logmein
                            .Parameters.Add(New SqlParameter("@ins_int", SqlDbType.Bit)).Value = Internet
                            .Parameters.Add(New SqlParameter("@ins_ver_app", SqlDbType.VarChar, 10)).Value = VersionApp
                            .Parameters.Add(New SqlParameter("@ins_ver_db", SqlDbType.VarChar, 10)).Value = VersionBD
                            .Parameters.Add(New SqlParameter("@ins_obs", SqlDbType.VarChar, 500)).Value = Obs
                            .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = _eliminado

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@ins_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
    End Class
End Namespace