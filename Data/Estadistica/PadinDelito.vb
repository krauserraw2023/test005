Imports System.Data
Imports System.Data.SqlClient
Imports Entity

Namespace Estadistica
    Public Class PadinDelito
        Private Shared strNameProcedure As String = "UP_RPT_PadinDelito"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, accion As String, opcion As String, objEnt As Entity.Estadistica.PadinDelito) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 1800
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pad_int_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@pad_sit_jur_id", SqlDbType.Int)).Value = objEnt.TipoSituacionJuridica
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    '/*filtros*/
                End With

                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
        ByVal RegionID As Integer,
        ByVal PenalID As Integer,
        ByVal Estado As Integer
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pad_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = Estado
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

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, objEnt As Entity.Estadistica.PadinDelito) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pad_del_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID

                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoId
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@pad_sit_jur_id", SqlDbType.Int)).Value = objEnt.TipoSituacionJuridica
                            .Parameters.Add(New SqlParameter("@pad_int_del_id", SqlDbType.Int)).Value = objEnt.InternoDelitoId

                            .Parameters.Add(New SqlParameter("@pad_del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoId
                            .Parameters.Add(New SqlParameter("@pad_del_esp_nom", SqlDbType.VarChar, 100)).Value = objEnt.DelitoEspecificoNombre
                            .Parameters.Add(New SqlParameter("@pad_del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenericoId
                            .Parameters.Add(New SqlParameter("@pad_del_gen_nom", SqlDbType.VarChar, 100)).Value = objEnt.DelitoGenericoNombre
                            .Parameters.Add(New SqlParameter("@pad_exp_id", SqlDbType.Int)).Value = objEnt.ExpedienteId
                            .Parameters.Add(New SqlParameter("@pad_exp_num", SqlDbType.VarChar, 100)).Value = objEnt.ExpedienteNumero
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.DocumentoJudicialId
                            .Parameters.Add(New SqlParameter("@pad_fec_rec", SqlDbType.BigInt)).Value = objEnt.FechaRecepcion
                            .Parameters.Add(New SqlParameter("@pad_agr_nom", SqlDbType.VarChar, 2500)).Value = objEnt.Agraviados

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = objEnt.Audit_FechaLong
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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, InternoId As Integer, IngresoId As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = InternoId
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoId

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
            End Try
        End Function
    End Class
End Namespace