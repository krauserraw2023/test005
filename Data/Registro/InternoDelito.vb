Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoDelito
        Private Shared strNameProcedure As String = "UP_INT_InternoDelito"
#Region "Listar"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal int_del_id As Integer, _
       ByVal int_ing_id As Integer, _
       ByVal int_id As Integer, ByVal ExpedienteID As Integer, _
       ByVal int_del_gen_id As Integer, _
       ByVal int_del_esp_id As Integer _
       ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = int_del_id
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = int_ing_id
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = int_id
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = int_del_gen_id
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = int_del_esp_id
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal int_del_id As Integer, _
        ByVal int_ing_id As Integer, _
        ByVal int_ing_inpe_id As Integer, _
        ByVal int_id As Integer, ByVal ExpedienteID As Integer, _
        ByVal int_del_gen_id As Integer, _
        ByVal int_del_esp_id As Integer _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = int_del_id
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = int_ing_id
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = int_ing_inpe_id
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = int_id
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = int_del_gen_id
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = int_del_esp_id

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Registro.Delito) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenerico
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecifico
                    .Parameters.Add(New SqlParameter("@int_del_dmp", SqlDbType.Int)).Value = objEnt.DelitoMayorPena
                    .Parameters.Add(New SqlParameter("@n_int_del_est_anu", SqlDbType.Int)).Value = objEnt.Anulacion
                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEnt.CreaDocJudicialId
                    .Parameters.Add(New SqlParameter("@int_del_est", SqlDbType.Int)).Value = objEnt.Estado
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Registro.Delito) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                    .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenerico
                    .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecifico
                    .Parameters.Add(New SqlParameter("@int_del_dmp", SqlDbType.Int)).Value = objEnt.DelitoMayorPena
                    .Parameters.Add(New SqlParameter("@n_int_del_est_anu", SqlDbType.Int)).Value = objEnt.Anulacion
                    .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEnt.CreaDocJudicialId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.Delito) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenerico
                            .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecifico

                            .Parameters.Add(New SqlParameter("@int_del_dmp", SqlDbType.Bit)).Value = objEnt.DelitoMayorPena
                            .Parameters.Add(New SqlParameter("@int_del_sen_dmp", SqlDbType.Bit)).Value = objEnt.DelitoSentenciaMayorPena

                            .Parameters.Add(New SqlParameter("@int_del_obs", SqlDbType.VarChar, 2500)).Value = objEnt.Observacion

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede

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
        Public Shared Function Grabar_V2(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.Delito) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenerico
                            .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecifico

                            .Parameters.Add(New SqlParameter("@int_del_dmp", SqlDbType.Bit)).Value = objEnt.DelitoMayorPena
                            .Parameters.Add(New SqlParameter("@int_del_sen_dmp", SqlDbType.Bit)).Value = objEnt.DelitoSentenciaMayorPena

                            .Parameters.Add(New SqlParameter("@int_del_obs", SqlDbType.VarChar, 2500)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEnt.CreaDocJudicialId
                            .Parameters.Add(New SqlParameter("@n_int_del_est_anu", SqlDbType.Int)).Value = objEnt.Anulacion
                            .Parameters.Add(New SqlParameter("@fk_int_del_pad_ref_id", SqlDbType.Int)).Value = objEnt.CodigodelitoPad
                            .Parameters.Add(New SqlParameter("@int_del_est", SqlDbType.SmallInt)).Value = objEnt.Estado

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID

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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.Delito) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@int_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteID
                            .Parameters.Add(New SqlParameter("@int_del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenerico
                            .Parameters.Add(New SqlParameter("@int_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecifico
                            .Parameters.Add(New SqlParameter("@int_del_dmp", SqlDbType.Bit)).Value = objEnt.DelitoMayorPena
                            .Parameters.Add(New SqlParameter("@int_del_sen_dmp", SqlDbType.Bit)).Value = objEnt.DelitoSentenciaMayorPena
                            .Parameters.Add(New SqlParameter("@int_del_obs", SqlDbType.VarChar, 2500)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@crea_doc_jud_id", SqlDbType.Int)).Value = objEnt.CreaDocJudicialId
                            .Parameters.Add(New SqlParameter("@n_int_del_est_anu", SqlDbType.Int)).Value = objEnt.Anulacion
                            .Parameters.Add(New SqlParameter("@fk_int_del_pad_ref_id", SqlDbType.Int)).Value = objEnt.CodigodelitoPad
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objEnt.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objEnt.SedeRowId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID

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
#End Region

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
                            .Parameters.Add(New SqlParameter("@int_del_id", SqlDbType.Int)).Value = Codigo
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
