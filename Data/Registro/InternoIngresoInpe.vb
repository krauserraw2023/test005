Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class IngresoInpe

        Private Shared strNameProcedure As String = "pa_int_mov_interno_ingreso_inpe"
#Region "Listar"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, EntIng As Entity.Registro.IngresoInpe) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_ing_inp_id", SqlDbType.Int)).Value = EntIng.Codigo

                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = EntIng.InternoID
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.SmallInt)).Value = EntIng.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.SmallInt)).Value = EntIng.PenalID

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, obj As Entity.Registro.IngresoInpe) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_ing_inp_id", SqlDbType.Int)).Value = obj.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = obj.InternoID
                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = obj.RegionID
                    .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = obj.PenalID
                    .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = obj.SedeRowId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function


#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Registro.IngresoInpe) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_ing_inp_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@fk_mov_tip_id", SqlDbType.Int)).Value = objEnt.IDTipoMovimiento
                            .Parameters.Add(New SqlParameter("@fk_ing_mot_id", SqlDbType.Int)).Value = objEnt.MotivoIngresoID
                            .Parameters.Add(New SqlParameter("@int_fec_isp", SqlDbType.BigInt)).Value = objEnt.FechaISP
                            .Parameters.Add(New SqlParameter("@n_fec_ing_inp", SqlDbType.BigInt)).Value = objEnt.FechaIngInpe
                            .Parameters.Add(New SqlParameter("@n_fec_mov_ing", SqlDbType.BigInt)).Value = objEnt.FechaMovimientoIngreso
                            .Parameters.Add(New SqlParameter("@c_num_ing", SqlDbType.Int)).Value = objEnt.IngresoNro
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, -1)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@_crea_reg_pen_id", SqlDbType.SmallInt)).Value = objEnt.RegistroCreaPenalID
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                            .Parameters.Add(New SqlParameter("@int_ing_hist", SqlDbType.SmallInt)).Value = objEnt.Historico
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, codigo As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_ing_inp_id", SqlDbType.Int)).Value = codigo
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
#End Region

    End Class
End Namespace
