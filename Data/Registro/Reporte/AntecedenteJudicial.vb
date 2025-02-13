Imports System.Data.SqlClient

Namespace Registro.Reporte
    Public Class AntecedenteJudicial
        Private Shared strNameProcedure As String = "pa_anj_certificado_antecedentes"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, internoId As Integer, ambitoJurisdiccionAut As Integer) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand("pa_anj_certificado_antecedentes", sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandTimeout = 240 '4 min
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = internoId
                            .Parameters.Add(New SqlParameter("@n_aut_amb", SqlDbType.SmallInt)).Value = ambitoJurisdiccionAut
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

        'Public Shared Function ListarDetalleAntecedenteTemp(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
        '                                                    IdInterno As Integer, ambitoAutJud As Integer) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandTimeout = 240 '4 min
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = IdInterno
        '            .Parameters.Add(New SqlParameter("@n_aut_amb", SqlDbType.Int)).Value = ambitoAutJud
        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader

        'End Function

        Public Shared Function ListarDetalleAntecedenteTemp(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                                            IdInterno As Integer, ambitoAutJud As Integer, mostrarDocAnulado As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 660 '11 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = IdInterno
                    .Parameters.Add(New SqlParameter("@n_aut_amb", SqlDbType.Int)).Value = ambitoAutJud
                    .Parameters.Add(New SqlParameter("@mostrar_doc_anulado", SqlDbType.Int)).Value = mostrarDocAnulado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function ListarDetalleCertAntJud_Sybase(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, SolAntJudId As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_sol_ant_id", SqlDbType.Int)).Value = SolAntJudId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

    End Class

    Public Class HistorialAntecedente
        Private Shared strNameProcedure As String = "usp_reg_reporte_antecedentes"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal strAccion As String, ByVal strOpcion As String,
                                  intIDRegion As Integer, intIDPenal As Integer, intIDInterno As Integer, intMostrarDocAnulado As Short) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = strAccion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = strOpcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = intIDInterno
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = intIDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = intIDPenal
                    .Parameters.Add(New SqlParameter("@mostrar_doc_anulado", SqlDbType.SmallInt)).Value = intMostrarDocAnulado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
    End Class
End Namespace