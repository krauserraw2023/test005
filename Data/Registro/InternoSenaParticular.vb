Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoSenaParticular
        Private Shared strNameProcedure As String = "UP_INT_InternoSenaParticular"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal NaturalezaID As Integer, _
        ByVal FormaID As Integer, _
        ByVal UbicacionID As Integer, _
        ByVal PosicionID As Integer, _
        ByVal Cantidad As Integer _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = NaturalezaID
                            .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = FormaID
                            .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = UbicacionID
                            .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = PosicionID
                            .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = Cantidad

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal NaturalezaID As Integer, _
        ByVal FormaID As Integer, _
        ByVal UbicacionID As Integer, _
        ByVal PosicionID As Integer, _
        ByVal Cantidad As Integer _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = NaturalezaID
                    .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = FormaID
                    .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = UbicacionID
                    .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = PosicionID
                    .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = Cantidad
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      objEntSP As Entity.Registro.InternoSenaParticular) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = objEntSP.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntSP.InternoID
                    .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = objEntSP.NaturalezaID
                    .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = objEntSP.FormaID
                    .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = objEntSP.UbicacionID
                    .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = objEntSP.PosicionID
                    .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = objEntSP.Cantidad
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntSP.InternoIngresoId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        'se agregó sedRowId
        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      objEntSP As Entity.Registro.InternoSenaParticular) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = objEntSP.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEntSP.InternoID
                    .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = objEntSP.NaturalezaID
                    .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = objEntSP.FormaID
                    .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = objEntSP.UbicacionID
                    .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = objEntSP.PosicionID
                    .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = objEntSP.Cantidad
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEntSP.InternoIngresoId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEntSP.SedeRowId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEntSP.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@penal", SqlDbType.Int)).Value = objEntSP.PenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal InternoID As Integer, _
        ByVal NaturalezaID As Integer, _
        ByVal FormaID As Integer, _
        ByVal UbicacionID As Integer, _
        ByVal PosicionID As Integer, _
        ByVal Cantidad As Integer, ByVal Obs As String, IDRegion As Integer, IDPenal As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = NaturalezaID
                            .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = FormaID
                            .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = UbicacionID
                            .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = PosicionID
                            .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = Cantidad
                            .Parameters.Add(New SqlParameter("@int_sen_par_obs", SqlDbType.VarChar, 250)).Value = Obs

                            .Parameters.Add(New SqlParameter("@region", SqlDbType.Int)).Value = IDRegion
                            .Parameters.Add(New SqlParameter("@penal", SqlDbType.Int)).Value = IDPenal

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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, entSenPart As Entity.Registro.InternoSenaParticular) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = entSenPart.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entSenPart.InternoID
                            .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = entSenPart.NaturalezaID
                            .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = entSenPart.FormaID
                            .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = entSenPart.UbicacionID
                            .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = entSenPart.PosicionID
                            .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = entSenPart.Cantidad
                            .Parameters.Add(New SqlParameter("@int_sen_par_obs", SqlDbType.VarChar, 250)).Value = entSenPart.Obs
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = entSenPart.InternoIngresoId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, entSenPart As Entity.Registro.InternoSenaParticular) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = entSenPart.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entSenPart.InternoID
                            .Parameters.Add(New SqlParameter("@sen_part_nat_id", SqlDbType.Int)).Value = entSenPart.NaturalezaID
                            .Parameters.Add(New SqlParameter("@sen_part_for_id", SqlDbType.Int)).Value = entSenPart.FormaID
                            .Parameters.Add(New SqlParameter("@sen_part_ubi_id", SqlDbType.Int)).Value = entSenPart.UbicacionID
                            .Parameters.Add(New SqlParameter("@sen_part_pos_id", SqlDbType.Int)).Value = entSenPart.PosicionID
                            .Parameters.Add(New SqlParameter("@int_sen_par_can", SqlDbType.Int)).Value = entSenPart.Cantidad
                            .Parameters.Add(New SqlParameter("@int_sen_par_obs", SqlDbType.VarChar, 250)).Value = entSenPart.Obs
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = entSenPart.InternoIngresoId
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = entSenPart.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = entSenPart.IngresoInpeId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
                            .Parameters.Add(New SqlParameter("@int_sen_par_id", SqlDbType.Int)).Value = Codigo

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