Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Documento
    Public Class NotaEgreso
        Private Shared strNameProcedure As String = "UP_REG_DOC_NotaEgreso"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal DocumentoJudicialID As Integer, _
        ByVal InternoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal ExpedienteID As Integer, _
        ByVal EgresoTipo As Integer, _
        ByVal EgresoFecha As Long, _
        ByVal Observacion As String _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@doc_not_egr_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.int)).Value = DocumentoJudicialID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.int)).Value = InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.int)).Value = IngresoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.int)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@egr_tip_id", SqlDbType.int)).Value = EgresoTipo
                    .Parameters.Add(New SqlParameter("@egr_fec", SqlDbType.bigint)).Value = EgresoFecha
                    .Parameters.Add(New SqlParameter("@doc_not_egr_obs", SqlDbType.varchar, 500)).Value = Observacion
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal DocumentoJudicialID As Integer, _
        ByVal InternoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal ExpedienteID As Integer, _
        ByVal EgresoTipo As Integer, _
        ByVal EgresoFecha As Long, _
        ByVal Observacion As String _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_not_egr_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                            .Parameters.Add(New SqlParameter("@egr_tip_id", SqlDbType.Int)).Value = EgresoTipo
                            .Parameters.Add(New SqlParameter("@egr_fec", SqlDbType.BigInt)).Value = EgresoFecha
                            .Parameters.Add(New SqlParameter("@doc_not_egr_obs", SqlDbType.VarChar, 500)).Value = Observacion

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
        ByVal DocumentoJudicialID As Integer, _
        ByVal InternoID As Integer, _
        ByVal IngresoID As Integer, _
        ByVal ExpedienteID As Integer, _
        ByVal EgresoTipo As Integer, _
        ByVal EgresoFecha As Long, _
        ByVal Observacion As String, ByVal _RegionID As Integer, ByVal _PenalID As Integer, _
        ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_not_egr_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                            .Parameters.Add(New SqlParameter("@egr_tip_id", SqlDbType.Int)).Value = EgresoTipo
                            .Parameters.Add(New SqlParameter("@egr_fec", SqlDbType.BigInt)).Value = EgresoFecha
                            .Parameters.Add(New SqlParameter("@doc_not_egr_obs", SqlDbType.VarChar, 500)).Value = Observacion

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = _RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = _PenalID
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_not_egr_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
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
    End Class
End Namespace