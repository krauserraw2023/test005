Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoExpedientePadre
        Private Shared strNameProcedure As String = "UP_INT_InternoExpedientePadre"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ExpPad As Entity.Registro.InternoExpedientePadre) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 900
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 60 * 3 '3 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpPad.InternoExpedienteId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = ExpPad.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ExpPad.IngresoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = ExpPad.DocJudicialID
                            .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = ExpPad._PenalId
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

        Public Shared Function ListarOutput_LM(ByVal accion As String, ByVal opcion As String, ExpPad As Entity.Registro.InternoExpedientePadre) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpPad.InternoExpedienteId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ExpPad.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = ExpPad.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = ExpPad.DocJudicialID
                            .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = ExpPad._PenalId
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

        Public Shared Function Listar(sqlCon As SqlConnection, accion As String, opcion As String, objIntExp As Entity.Registro.InternoExpedientePadre) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_pad_id", SqlDbType.Int)).Value = objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteId
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@int_ex_pad_ref_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteRefPadreId
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objIntExp.DocJudicialID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        'Listar
        Public Shared Function Listar_LM(sqlCon As SqlConnection, accion As String, opcion As String, objIntExp As Entity.Registro.InternoExpedientePadre) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_exp_pad_id", SqlDbType.Int)).Value = objIntExp.Codigo
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteId
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objIntExp.SedeRowId
                    .Parameters.Add(New SqlParameter("@int_ex_pad_ref_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteRefPadreId
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objIntExp.DocJudicialID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region
        Public Shared Function Grabar(strAccion As String, strOpcion As String, objIntExp As Entity.Registro.InternoExpedientePadre) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@int_exp_pad_id", SqlDbType.Int)).Value = objIntExp.Codigo
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objIntExp.DocJudicialID
                            .Parameters.Add(New SqlParameter("@int_ex_pad_ref_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteRefPadreId
                            .Parameters.Add(New SqlParameter("@_regId", SqlDbType.Int)).Value = objIntExp._RegionId
                            .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = objIntExp._PenalId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objIntExp.FlagTransferenciaSede

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

        Public Shared Function Grabar_LM(strAccion As String, strOpcion As String, objIntExp As Entity.Registro.InternoExpedientePadre) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion

                            .Parameters.Add(New SqlParameter("@int_exp_pad_id", SqlDbType.Int)).Value = objIntExp.Codigo
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objIntExp.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objIntExp.IngresoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objIntExp.DocJudicialID
                            .Parameters.Add(New SqlParameter("@int_ex_pad_ref_id", SqlDbType.Int)).Value = objIntExp.InternoExpedienteRefPadreId
                            .Parameters.Add(New SqlParameter("@_regId", SqlDbType.Int)).Value = objIntExp._RegionId
                            .Parameters.Add(New SqlParameter("@_penId", SqlDbType.Int)).Value = objIntExp._PenalId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objIntExp.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objIntExp.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objIntExp.IngresoInpeId

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
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_pad_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, objPad As Entity.Registro.InternoExpedientePadre, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_exp_pad_id", SqlDbType.Int)).Value = objPad.Codigo
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objPad.InternoExpedienteId
                            .Parameters.Add(New SqlParameter("@int_ex_pad_ref_id", SqlDbType.Int)).Value = objPad.InternoExpedienteRefPadreId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
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
#End Region
    End Class
End Namespace

