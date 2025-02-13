Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoAlias
        Private Shared strNameProcedure As String = "UP_INT_InternoAlias"
        Private Shared sqlPar_accion As SqlParameter = Nothing
        Private Shared sqlPar_opcion As SqlParameter = Nothing
        Private Shared sqlPar_aliasid As SqlParameter = Nothing
        Private Shared sqlPar_internoid As SqlParameter = Nothing
        Private Shared sqlPar_aliasnombre As SqlParameter = Nothing
        Private Shared sqlPar_IngresoID As SqlParameter = Nothing
        Private Shared sqlPar_RegionID As SqlParameter = Nothing
        Private Shared sqlPar_PenalID As SqlParameter = Nothing
        Private Shared sqlPar_usuario As SqlParameter = Nothing        
        Private Shared sqlPar_fecha As SqlParameter = Nothing
        Private Shared sqlPar_variable_out As SqlParameter = Nothing
        Private Shared _listar2 As SqlDataReader

        Private Shared Sub LoadParameter(Optional ByVal Output As Boolean = True)

            sqlPar_accion = New SqlParameter("@accion", SqlDbType.VarChar, 3)
            sqlPar_opcion = New SqlParameter("@opcion", SqlDbType.VarChar, 120)
            sqlPar_aliasid = New SqlParameter("@int_ali_id", SqlDbType.Int)
            sqlPar_internoid = New SqlParameter("@int_id", SqlDbType.Int)
            sqlPar_aliasnombre = New SqlParameter("@int_ali_nom", SqlDbType.VarChar, 100)
            sqlPar_IngresoID = New SqlParameter("@int_ing_id", SqlDbType.Int)
            sqlPar_RegionID = New SqlParameter("@_regid", SqlDbType.Int)
            sqlPar_PenalID = New SqlParameter("@_penid", SqlDbType.Int)
            sqlPar_usuario = New SqlParameter("@_usuario", SqlDbType.Int)
            sqlPar_fecha = New SqlParameter("@_fecha", SqlDbType.BigInt)

            'salida
            If Output = True Then
                sqlPar_variable_out = New SqlParameter("@variable_out", SqlDbType.Int)
                sqlPar_variable_out.Direction = ParameterDirection.Output
            End If

        End Sub

#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
    ByVal InternoID As Integer, _
    ByVal Nombres As String) As Integer

            Try

                Dim intValue As Integer = -1
                LoadParameter()

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(sqlPar_accion).Value = accion
                            .Parameters.Add(sqlPar_opcion).Value = opcion
                            .Parameters.Add(sqlPar_aliasid).Value = Codigo
                            .Parameters.Add(sqlPar_internoid).Value = InternoID
                            .Parameters.Add(sqlPar_aliasnombre).Value = Nombres

                            'auditoria
                            .Parameters.Add(sqlPar_variable_out)

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                      ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal Nombres As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            LoadParameter(False)

            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(sqlPar_accion).Value = accion
                    .Parameters.Add(sqlPar_opcion).Value = opcion
                    .Parameters.Add(sqlPar_aliasid).Value = Codigo
                    .Parameters.Add(sqlPar_internoid).Value = InternoID
                    .Parameters.Add(sqlPar_aliasnombre).Value = Nombres
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                   ByVal opcion As String, objEntAlias As Entity.Registro.InternoAlias) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            LoadParameter(False)

            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(sqlPar_accion).Value = accion
                    .Parameters.Add(sqlPar_opcion).Value = opcion
                    .Parameters.Add(sqlPar_aliasid).Value = objEntAlias.Codigo
                    .Parameters.Add(sqlPar_internoid).Value = objEntAlias.InternoID
                    .Parameters.Add(sqlPar_IngresoID).Value = objEntAlias.IngresoID
                    .Parameters.Add(sqlPar_aliasnombre).Value = objEntAlias.Nombres
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                   ByVal opcion As String, objEntAlias As Entity.Registro.InternoAlias) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            LoadParameter(False)

            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(sqlPar_accion).Value = accion
                    .Parameters.Add(sqlPar_opcion).Value = opcion
                    .Parameters.Add(sqlPar_aliasid).Value = objEntAlias.Codigo
                    .Parameters.Add(sqlPar_internoid).Value = objEntAlias.InternoID
                    .Parameters.Add(sqlPar_IngresoID).Value = objEntAlias.IngresoID
                    .Parameters.Add(sqlPar_aliasnombre).Value = objEntAlias.Nombres
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEntAlias.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntAlias.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEntAlias.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal Nombres As String, IDRegion As Integer, IDPenal As Integer, _
        ByVal Usuario As Integer) As Integer
            Try

                Dim intCodigo As Integer = -1
                LoadParameter()

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(sqlPar_accion).Value = accion
                            .Parameters.Add(sqlPar_opcion).Value = opcion
                            .Parameters.Add(sqlPar_aliasid).Value = Codigo
                            .Parameters.Add(sqlPar_internoid).Value = InternoID
                            .Parameters.Add(sqlPar_aliasnombre).Value = Nombres
                            '/**/
                            .Parameters.Add(sqlPar_RegionID).Value = IDRegion
                            .Parameters.Add(sqlPar_PenalID).Value = IDPenal

                            .Parameters.Add(sqlPar_usuario).Value = Usuario
                            .Parameters.Add(sqlPar_fecha).Value = Now.ToFileTime
                            .Parameters.Add(sqlPar_variable_out)

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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, EntAlias As Entity.Registro.InternoAlias) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ali_id", SqlDbType.Int)).Value = EntAlias.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntAlias.InternoID
                            .Parameters.Add(New SqlParameter("@int_ali_nom", SqlDbType.VarChar, 100)).Value = EntAlias.Nombres
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntAlias.IngresoID
                            .Parameters.Add(New SqlParameter("@_Regid", SqlDbType.Int)).Value = EntAlias.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntAlias.PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            '/**/
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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, EntAlias As Entity.Registro.InternoAlias) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ali_id", SqlDbType.Int)).Value = EntAlias.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntAlias.InternoID
                            .Parameters.Add(New SqlParameter("@int_ali_nom", SqlDbType.VarChar, 100)).Value = EntAlias.Nombres
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntAlias.IngresoID
                            .Parameters.Add(New SqlParameter("@_Regid", SqlDbType.Int)).Value = EntAlias.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntAlias.PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = EntAlias.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntAlias.IngresoInpeId

                            '/**/
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
#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try

                Dim intCodigo As Integer = -1
                LoadParameter()

                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(sqlPar_accion).Value = accion
                            .Parameters.Add(sqlPar_opcion).Value = opcion
                            .Parameters.Add(sqlPar_aliasid).Value = Codigo
                            '/**/
                            .Parameters.Add(sqlPar_usuario).Value = Usuario
                            .Parameters.Add(sqlPar_fecha).Value = Now.ToFileTime
                            .Parameters.Add(sqlPar_variable_out)

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
#End Region

    End Class
End Namespace
