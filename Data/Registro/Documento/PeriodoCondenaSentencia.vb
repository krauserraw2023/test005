Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Documento
    Public Class PeriodoCondenaSentencia
        Private Shared strNameProcedure As String = "UP_INT_PeriodoCondenaSent"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = EntPeriodoCondena.Codigo
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntPeriodoCondena.DocJudicialId
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntPeriodoCondena.RegionId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntPeriodoCondena.PenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar_V2(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = EntPeriodoCondena.Codigo
                    .Parameters.Add(New SqlParameter("@per_tip", SqlDbType.Int)).Value = EntPeriodoCondena.Tipo
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntPeriodoCondena.DocJudicialId
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntPeriodoCondena.RegionId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntPeriodoCondena.PenalId
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = EntPeriodoCondena.Codigo
                            .Parameters.Add(New SqlParameter("@per_anio", SqlDbType.Int)).Value = EntPeriodoCondena.Anio
                            .Parameters.Add(New SqlParameter("@per_mes", SqlDbType.Int)).Value = EntPeriodoCondena.Mes
                            .Parameters.Add(New SqlParameter("@per_dia", SqlDbType.Int)).Value = EntPeriodoCondena.Dia
                            .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaInicio
                            .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaFin
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntPeriodoCondena.DocJudicialId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntPeriodoCondena.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntPeriodoCondena.IngresoId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntPeriodoCondena.RegionId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntPeriodoCondena.PenalId
                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = EntPeriodoCondena.FlagTransferenciaSede

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
        Public Shared Function Grabar_V2(ByVal accion As String, ByVal opcion As String, EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = EntPeriodoCondena.Codigo
                            .Parameters.Add(New SqlParameter("@per_tip", SqlDbType.Int)).Value = EntPeriodoCondena.Tipo
                            .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaInicio
                            .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaFin
                            .Parameters.Add(New SqlParameter("@per_anio", SqlDbType.Int)).Value = EntPeriodoCondena.Anio
                            .Parameters.Add(New SqlParameter("@per_mes", SqlDbType.Int)).Value = EntPeriodoCondena.Mes
                            .Parameters.Add(New SqlParameter("@per_dia", SqlDbType.Int)).Value = EntPeriodoCondena.Dia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntPeriodoCondena.DocJudicialId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntPeriodoCondena.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntPeriodoCondena.IngresoId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntPeriodoCondena.RegionId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntPeriodoCondena.PenalId
                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = EntPeriodoCondena.FlagTransferenciaSede

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
        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = EntPeriodoCondena.Codigo
                            .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaInicio
                            .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaFin
                            .Parameters.Add(New SqlParameter("@per_anio", SqlDbType.Int)).Value = EntPeriodoCondena.Anio
                            .Parameters.Add(New SqlParameter("@per_mes", SqlDbType.Int)).Value = EntPeriodoCondena.Mes
                            .Parameters.Add(New SqlParameter("@per_dia", SqlDbType.Int)).Value = EntPeriodoCondena.Dia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntPeriodoCondena.DocJudicialId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntPeriodoCondena.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntPeriodoCondena.IngresoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntPeriodoCondena.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntPeriodoCondena.RegionId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntPeriodoCondena.PenalId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = EntPeriodoCondena.FlagTransferenciaSede
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
        Public Shared Function Grabar_LM_V2(ByVal accion As String, ByVal opcion As String, EntPeriodoCondena As Entity.Registro.Documento.PeriodoCondenaSentencia) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = EntPeriodoCondena.Codigo
                            .Parameters.Add(New SqlParameter("@per_tip", SqlDbType.Int)).Value = EntPeriodoCondena.Tipo
                            .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaInicio
                            .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = EntPeriodoCondena.FechaFin
                            .Parameters.Add(New SqlParameter("@per_anio", SqlDbType.Int)).Value = EntPeriodoCondena.Anio
                            .Parameters.Add(New SqlParameter("@per_mes", SqlDbType.Int)).Value = EntPeriodoCondena.Mes
                            .Parameters.Add(New SqlParameter("@per_dia", SqlDbType.Int)).Value = EntPeriodoCondena.Dia
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntPeriodoCondena.DocJudicialId
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntPeriodoCondena.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntPeriodoCondena.IngresoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntPeriodoCondena.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntPeriodoCondena.RegionId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntPeriodoCondena.PenalId
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = EntPeriodoCondena.FlagTransferenciaSede
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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal DocumentoId As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@per_cond_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = DocumentoId
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