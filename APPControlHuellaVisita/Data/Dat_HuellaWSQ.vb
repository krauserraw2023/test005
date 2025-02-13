Imports System.Data.SqlClient

Namespace Data
    Public Class Dat_HuellaWSQ
        'Shared cn As String = "server=DES002\SQL2K; database=inpe_bd_huella_local; uid=hrosario; pwd=123456789;"
        Private Shared strNameProcedure As String = "UP_mov_huella_wsq"

        Public Shared Function Listar(accion As String, opcion As String, cn As String, EntWSQ As Entity.Ent_HuellaWSQ, ByRef out_sms As String) As Entity.HuellaWSQCol
            Dim intCodigo As Integer = -1

            Dim listWSQ As New Entity.HuellaWSQCol

            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon = New SqlConnection(cn)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = EntWSQ.Codigo
                    .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = EntWSQ.HuellaTemplateId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntWSQ.PenalId
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntWSQ.RegionId

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    sqlDr = sqlCmd.ExecuteReader
                    intCodigo = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With

                Dim ent As Entity.Ent_HuellaWSQ
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ent = New Entity.Ent_HuellaWSQ
                        ent.Codigo = sqlDr("pk_wsq_id").ToString
                        If IsDBNull(sqlDr("wsq_file")) = True Then
                            ent.WSQFile = Nothing
                        Else
                            ent.WSQFile = sqlDr("wsq_file")
                        End If

                        ent.HuellaTemplateId = sqlDr("fk_tmp_id")
                        ent.RegionId = sqlDr("_RegId")
                        ent.PenalId = sqlDr("_PenId")

                        listWSQ.Add(ent)
                    End While
                End If

            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return listWSQ
        End Function

        'Public Shared Function Grabar(accion As String, opcion As String, ByVal EntWSQ As Entity.Biometria.HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer
        '    Dim intCodigo As Integer = -1
        '    Dim sqlCon As SqlConnection
        '    Dim sqlCmd As SqlCommand
        '    Try
        '        sqlCon = New SqlConnection(cn)
        '        sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

        '            .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = EntWSQ.Codigo
        '            .Parameters.Add(New SqlParameter("@wsq_file", SqlDbType.VarBinary, 0)).Value = EntWSQ.WSQFile
        '            .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = EntWSQ.HuellaTemplateId
        '            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntWSQ.PenalId
        '            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntWSQ.RegionId

        '            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

        '            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '            .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
        '            .Parameters("@variable_out").Direction = ParameterDirection.Output
        '            .Parameters("@str_out_sms").Direction = ParameterDirection.Output

        '            sqlCon.Open()
        '            .ExecuteNonQuery()
        '            intCodigo = .Parameters("@variable_out").Value
        '            out_sms = .Parameters("@str_out_sms").Value
        '        End With
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    Finally
        '        sqlCmd.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try
        '    Return intCodigo
        'End Function
        'EliminarPorTemplate
        'Public Shared Function EliminarPorTmplId(accion As String, opcion As String, TmplId As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
        '    Dim intCodigo As Integer = -1
        '    Dim sqlCon As SqlConnection
        '    Dim sqlCmd As SqlCommand
        '    Try
        '        sqlCon = New SqlConnection(cn)
        '        sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = TmplId


        '            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

        '            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '            .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
        '            .Parameters("@variable_out").Direction = ParameterDirection.Output
        '            .Parameters("@str_out_sms").Direction = ParameterDirection.Output

        '            sqlCon.Open()
        '            .ExecuteNonQuery()
        '            intCodigo = .Parameters("@variable_out").Value
        '            out_sms = .Parameters("@str_out_sms").Value
        '        End With
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '    Finally
        '        sqlCmd.Dispose()
        '        sqlCon.Close()
        '        sqlCon = Nothing
        '    End Try
        '    Return intCodigo
        'End Function

        Public Shared Function Eliminar(accion As String, opcion As String, cn As String, Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intCodigo As Integer = -1
            Dim sqlCon As SqlConnection
            Dim sqlCmd As SqlCommand
            Try
                sqlCon = New SqlConnection(cn)
                sqlCmd = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = Codigo



                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return intCodigo
        End Function
    End Class
End Namespace