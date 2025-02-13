Imports System.Data.SqlClient

Namespace Registro.Antecedente
    Public Class SolicitudAntecedente
        Private Shared strNameProcedure As String = "pa_anj_mov_solicitud_antecedente"
        '#Region "Listar_Output"
        '        'Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, internoId As Integer, ambitoJurisdiccionAut As Integer) As Integer
        '        '    Try
        '        '        Dim intValue As Integer = -1
        '        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '        '            Using sqlCmd As SqlCommand = New SqlCommand("pa_anj_certificado_antecedentes", sqlCon)
        '        '                With sqlCmd
        '        '                    .CommandType = CommandType.StoredProcedure
        '        '                    .CommandTimeout = 240 '4 min
        '        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '        '                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = internoId
        '        '                    .Parameters.Add(New SqlParameter("@n_aut_amb", SqlDbType.SmallInt)).Value = ambitoJurisdiccionAut
        '        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '        '                    sqlCon.Open()
        '        '                    .ExecuteNonQuery()
        '        '                    intValue = .Parameters("@variable_out").Value
        '        '                    Return intValue
        '        '                End With
        '        '            End Using
        '        '        End Using
        '        '    Catch ex As Exception
        '        '        Throw New Exception(ex.Message)
        '        '        Return -1
        '        '    End Try
        '        'End Function
        '#End Region
#Region "Listar"

        'Public Shared Function ListarDetalleAntecedenteTemp(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, IdInterno As Integer, ambitoAutJud As Integer) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand("pa_anj_certificado_antecedentes", sqlCon)
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

        'Public Shared Function ListarDetalleAntecedenteTemp(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, IdInterno As Integer, ambitoAutJud As Integer, mostrarDocAnulado As Integer) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand("pa_anj_certificado_antecedentes", sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandTimeout = 240 '4 min
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = IdInterno
        '            .Parameters.Add(New SqlParameter("@n_aut_amb", SqlDbType.Int)).Value = ambitoAutJud
        '            .Parameters.Add(New SqlParameter("@mostrar_doc_anulado", SqlDbType.Int)).Value = mostrarDocAnulado
        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader

        'End Function

        'Public Shared Function ListarDetalleCertAntJud_Sybase(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, SolAntJudId As Integer) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand("pa_anj_certificado_antecedentes", sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandTimeout = 240 '4 min
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@fk_sol_ant_id", SqlDbType.Int)).Value = SolAntJudId

        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader

        'End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                              objEnt As Entity.Registro.Antecedente.SolicitudAntecedente) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 240 '4 min
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_sol_ant_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@n_num_anio", SqlDbType.Int)).Value = objEnt.Anio
                    .Parameters.Add(New SqlParameter("@n_num_corr", SqlDbType.Int)).Value = objEnt.NumeroCorrelativo
                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 200)).Value = objEnt.DocumentoNumero
                    .Parameters.Add(New SqlParameter("@n_est_id", SqlDbType.Int)).Value = objEnt.EstadoSolicitudId
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaDesde
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaHasta

                    .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.SmallInt)).Value = objEnt.RegionId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.PenalId

                    .Parameters.Add(New SqlParameter("@c_int_ape_pat", SqlDbType.VarChar, 80)).Value = objEnt.InternoApePaterno
                    .Parameters.Add(New SqlParameter("@c_int_ape_mat", SqlDbType.VarChar, 80)).Value = objEnt.InternoApeMaterno
                    .Parameters.Add(New SqlParameter("@c_int_nom", SqlDbType.VarChar, 80)).Value = objEnt.InternoNombres
                    .Parameters.Add(New SqlParameter("@fk_sol_pen_id", SqlDbType.Int)).Value = objEnt.SolicitantePenalId
                    .Parameters.Add(New SqlParameter("@fk_sol_reg_id", SqlDbType.Int)).Value = objEnt.SolicitanteRegionId
                    .Parameters.Add(New SqlParameter("@n_tip_cert_id", SqlDbType.Int)).Value = objEnt.TipoAntecedenteId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try

            Return sqlReader

        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.Antecedente.SolicitudAntecedente, ByRef outSMS As String) As Integer
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_sol_ant_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@n_num_anio", SqlDbType.Int)).Value = objEnt.Anio
                            .Parameters.Add(New SqlParameter("@n_num_corr", SqlDbType.Int)).Value = objEnt.NumeroCorrelativo
                            .Parameters.Add(New SqlParameter("@n_fec_sol", SqlDbType.BigInt)).Value = objEnt.FechaSolicitud
                            .Parameters.Add(New SqlParameter("@n_est_id", SqlDbType.Int)).Value = objEnt.EstadoSolicitudId
                            .Parameters.Add(New SqlParameter("@fk_mot_sol_aj_id", SqlDbType.Int)).Value = objEnt.MotivoSolicitudId
                            .Parameters.Add(New SqlParameter("@fk_tip_aut_jud_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicial
                            .Parameters.Add(New SqlParameter("@fk_dis_jud_id", SqlDbType.Int)).Value = objEnt.SolDistritoJudicialId
                            .Parameters.Add(New SqlParameter("@fk_sal_jud_id", SqlDbType.Int)).Value = objEnt.SolSalaJudicialId
                            .Parameters.Add(New SqlParameter("@fk_rpt_cab_id", SqlDbType.Int)).Value = objEnt.ReporteCabeceraId
                            .Parameters.Add(New SqlParameter("@fk_glo_doc_id", SqlDbType.Int)).Value = objEnt.GlosaDocId
                            .Parameters.Add(New SqlParameter("@n_amb_jur_aut_id", SqlDbType.Int)).Value = objEnt.AmbitoJurisdiccionAut
                            .Parameters.Add(New SqlParameter("@n_tip_cert_id", SqlDbType.Int)).Value = objEnt.TipoAntecedenteId
                            .Parameters.Add(New SqlParameter("@n_fec_doc", SqlDbType.BigInt)).Value = objEnt.DocumentoFecha
                            .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 200)).Value = objEnt.DocumentoNumero
                            .Parameters.Add(New SqlParameter("@c_doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.SolNombreJuez
                            .Parameters.Add(New SqlParameter("@c_doc_jud_sec", SqlDbType.VarChar, 200)).Value = objEnt.SolNombreSecretario
                            .Parameters.Add(New SqlParameter("@c_nom_ent", SqlDbType.VarChar, 200)).Value = objEnt.SolNombreEntidad
                            .Parameters.Add(New SqlParameter("@fk_sol_pen_id", SqlDbType.Int)).Value = objEnt.SolicitantePenalId
                            .Parameters.Add(New SqlParameter("@fk_sol_reg_id", SqlDbType.Int)).Value = objEnt.SolicitanteRegionId
                            .Parameters.Add(New SqlParameter("@c_int_ape_pat", SqlDbType.VarChar, 200)).Value = objEnt.InternoApePaterno
                            .Parameters.Add(New SqlParameter("@c_int_ape_mat", SqlDbType.VarChar, 200)).Value = objEnt.InternoApeMaterno
                            .Parameters.Add(New SqlParameter("@c_int_nom", SqlDbType.VarChar, 200)).Value = objEnt.InternoNombres
                            .Parameters.Add(New SqlParameter("@c_int_cod", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigo
                            .Parameters.Add(New SqlParameter("@c_int_nom_aso", SqlDbType.VarChar, 3000)).Value = objEnt.InternoNombresAsociados
                            .Parameters.Add(New SqlParameter("@c_int_num_doc", SqlDbType.VarChar, 20)).Value = objEnt.InternoNumDocIdentidad
                            .Parameters.Add(New SqlParameter("@c_int_tip_doc_id", SqlDbType.Int)).Value = objEnt.InternoTipoDocIdentidad
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 200)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoId
                            .Parameters.Add(New SqlParameter("@n_inc_anu", SqlDbType.Bit)).Value = objEnt.IncluyeAnulaciones
                            .Parameters.Add(New SqlParameter("@c_mot_anula", SqlDbType.VarChar, 300)).Value = objEnt.MotivoAnulacion
                            .Parameters.Add(New SqlParameter("@n_fec_anu", SqlDbType.BigInt)).Value = objEnt.FechaAnulacion

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.SmallInt)).Value = objEnt.RegionId
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.SmallInt)).Value = objEnt.PenalId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Return .Parameters("@variable_out").Value
                        End With
                    End Using

                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer) As Integer
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_sol_ant_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Return .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
#End Region


    End Class
End Namespace
