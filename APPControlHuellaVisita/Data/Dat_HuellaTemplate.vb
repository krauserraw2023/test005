
Imports System.Data.SqlClient
Namespace Data
    Public Class Dat_HuellaTemplate

        Private Shared strNameProcedureTmpl As String = "UP_mov_template_huella"
        Private Shared strNameProcedureWsq As String = "UP_mov_huella_wsq"

#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, cn As String, EntTemplate As Entity.Ent_HuellaTemplate) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(CN)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedureTmpl, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@pk_tmp_id", SqlDbType.Int)).Value = EntTemplate.Codigo
                            .Parameters.Add(New SqlParameter("@fk_doc_tip_id", SqlDbType.Int)).Value = EntTemplate.DocTipoId
                            .Parameters.Add(New SqlParameter("@fk_ded_tip_id", SqlDbType.Int)).Value = EntTemplate.TipoDedoId
                            .Parameters.Add(New SqlParameter("@fk_dsp_id", SqlDbType.Int)).Value = EntTemplate.DispBiometricoId

                            .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 40)).Value = EntTemplate.NumDocumento

                            .Parameters.Add(New SqlParameter("@n_snc_sede", SqlDbType.Int)).Value = EntTemplate.RegSincronizadoSede
                            .Parameters.Add(New SqlParameter("@n_ind_cal", SqlDbType.Int)).Value = EntTemplate.IndiceCalidadImg
                            .Parameters.Add(New SqlParameter("@n_est_dedo", SqlDbType.Int)).Value = EntTemplate.EstadoDedo

                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntTemplate.PenalId
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntTemplate.RegionId

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))

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

        Public Shared Function Identificar(ByVal accion As String, ByVal opcion As String, cn As String, EntTemplate As Entity.Ent_HuellaTemplate,
                                           strIdsTemplate As String, ByRef outSms As String) As DataTable

            Dim t As New DataTable
            Dim intCodigo As Integer = -1

            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCon = New SqlConnection(cn)
                sqlCmd = New SqlCommand(strNameProcedureTmpl, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion


                    .Parameters.Add(New SqlParameter("@pk_tmp_id", SqlDbType.Int)).Value = EntTemplate.Codigo
                    .Parameters.Add(New SqlParameter("@fk_doc_tip_id", SqlDbType.Int)).Value = EntTemplate.DocTipoId
                    .Parameters.Add(New SqlParameter("@fk_ded_tip_id", SqlDbType.Int)).Value = EntTemplate.TipoDedoId
                    .Parameters.Add(New SqlParameter("@fk_dsp_id", SqlDbType.Int)).Value = EntTemplate.DispBiometricoId

                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 40)).Value = EntTemplate.NumDocumento
                    .Parameters.Add(New SqlParameter("@strTemplateId", SqlDbType.VarChar, -1)).Value = strIdsTemplate

                    .Parameters.Add(New SqlParameter("@n_snc_sede", SqlDbType.Int)).Value = EntTemplate.RegSincronizadoSede
                    .Parameters.Add(New SqlParameter("@n_ind_cal", SqlDbType.Int)).Value = EntTemplate.IndiceCalidadImg
                    .Parameters.Add(New SqlParameter("@n_est_dedo", SqlDbType.Int)).Value = EntTemplate.EstadoDedo


                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntTemplate.PenalId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntTemplate.RegionId

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))

                    sqlCon.Open()
                    t.Load(sqlCmd.ExecuteReader)
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return t
        End Function

        Public Shared Function Listar(accion As String, opcion As String, cn As String, EntTemplate As Entity.Ent_HuellaTemplate, ByRef out_sms As String) As Entity.HuellaTemplateCol
            Dim intCodigo As Integer = -1

            Dim listWSQ As New Entity.HuellaTemplateCol

            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon = New SqlConnection(CN)
                sqlCmd = New SqlCommand(strNameProcedureTmpl, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion


                    .Parameters.Add(New SqlParameter("@pk_tmp_id", SqlDbType.Int)).Value = EntTemplate.Codigo
                    .Parameters.Add(New SqlParameter("@fk_doc_tip_id", SqlDbType.Int)).Value = EntTemplate.DocTipoId
                    .Parameters.Add(New SqlParameter("@fk_ded_tip_id", SqlDbType.Int)).Value = EntTemplate.TipoDedoId
                    .Parameters.Add(New SqlParameter("@fk_dsp_id", SqlDbType.Int)).Value = EntTemplate.DispBiometricoId

                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 40)).Value = EntTemplate.NumDocumento

                    .Parameters.Add(New SqlParameter("@n_snc_sede", SqlDbType.Int)).Value = EntTemplate.RegSincronizadoSede
                    .Parameters.Add(New SqlParameter("@n_ind_cal", SqlDbType.Int)).Value = EntTemplate.IndiceCalidadImg
                    .Parameters.Add(New SqlParameter("@n_est_dedo", SqlDbType.Int)).Value = EntTemplate.EstadoDedo

                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntTemplate.PenalId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntTemplate.RegionId

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    sqlDr = sqlCmd.ExecuteReader
                    intCodigo = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With


                Dim ent As Entity.Ent_HuellaTemplate = Nothing
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ent = New Entity.Ent_HuellaTemplate
                        ent.Codigo = sqlDr("pk_tmp_id").ToString
                        ent.DocTipoId = sqlDr("fk_doc_tip_id").ToString
                        ent.TipoDedoId = sqlDr("fk_ded_tip_id").ToString
                        ent.DispBiometricoId = sqlDr("fk_dsp_id").ToString
                        ent.NumDocumento = sqlDr("c_num_doc").ToString

                        If IsDBNull(sqlDr("tmp_prop")) = True Then
                            ent.TemplatePropietario = Nothing
                        Else
                            ent.TemplatePropietario = sqlDr("tmp_prop")
                        End If
                        If IsDBNull(sqlDr("tmp_ansi")) = True Then
                            ent.TemplateANSI = Nothing
                        Else
                            ent.TemplateANSI = sqlDr("tmp_ansi")
                        End If
                        ent.NombrePC = sqlDr("c_hos_pc").ToString
                        ent.MacPC = sqlDr("c_hos_mac").ToString
                        ent.IpPC = sqlDr("c_hos_ip").ToString
                        'ent.RegSincronizadoSede = sqlDr("n_snc_sede").ToString
                        ent.IndiceCalidadImg = sqlDr("n_ind_cal").ToString
                        ent.EstadoDedo = sqlDr("n_est_dedo").ToString
                        ent.Observacion = sqlDr("c_obs").ToString
                        ent.RegionId = sqlDr("_RegId").ToString
                        ent.PenalId = sqlDr("_PenId").ToString

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

        Public Shared Function Listar_simple(accion As String, opcion As String, cn As String, EntTemplate As Entity.Ent_HuellaTemplate, pagina As Integer, filas_x_pagina As Integer, ByRef out_sms As String) As Entity.HuellaTemplateCol
            Dim intCodigo As Integer = -1

            Dim listWSQ As New Entity.HuellaTemplateCol

            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon = New SqlConnection(CN)
                sqlCmd = New SqlCommand(strNameProcedureTmpl, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pagina", SqlDbType.Int)).Value = pagina
                    .Parameters.Add(New SqlParameter("@filas_x_page", SqlDbType.Int)).Value = filas_x_pagina

                    .Parameters.Add(New SqlParameter("@pk_tmp_id", SqlDbType.Int)).Value = EntTemplate.Codigo
                    .Parameters.Add(New SqlParameter("@fk_doc_tip_id", SqlDbType.Int)).Value = EntTemplate.DocTipoId
                    .Parameters.Add(New SqlParameter("@fk_ded_tip_id", SqlDbType.Int)).Value = EntTemplate.TipoDedoId
                    .Parameters.Add(New SqlParameter("@fk_dsp_id", SqlDbType.Int)).Value = EntTemplate.DispBiometricoId

                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 40)).Value = EntTemplate.NumDocumento

                    .Parameters.Add(New SqlParameter("@n_snc_sede", SqlDbType.Int)).Value = EntTemplate.RegSincronizadoSede
                    .Parameters.Add(New SqlParameter("@n_ind_cal", SqlDbType.Int)).Value = EntTemplate.IndiceCalidadImg
                    .Parameters.Add(New SqlParameter("@n_est_dedo", SqlDbType.Int)).Value = EntTemplate.EstadoDedo

                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntTemplate.PenalId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntTemplate.RegionId

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    sqlCon.Open()
                    sqlDr = sqlCmd.ExecuteReader
                    intCodigo = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With


                Dim ent As Entity.Ent_HuellaTemplate = Nothing
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ent = New Entity.Ent_HuellaTemplate
                        ent.Codigo = sqlDr("pk_tmp_id").ToString
                        If opcion = "lst_mant_suprema" Then
                            ent.TemplatePropietario = sqlDr("tmp_prop")
                        End If
                        If opcion = "lst_mant_ansi" Then
                            ent.TemplateANSI = sqlDr("tmp_ansi")
                        End If
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

#End Region

#Region "Grabar"
        Public Shared Function Grabar(accion As String, opcion As String, cn As String, ByVal EntTemplate As Entity.Ent_HuellaTemplate, EntWSQ As Entity.Ent_HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intIdTmpl As Integer = -1
            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim sqlTransTmpl As SqlTransaction = Nothing

            Try
                sqlCon = New SqlConnection(CN)
                sqlCon.Open()
                sqlTransTmpl = sqlCon.BeginTransaction()
                sqlCmd = New SqlCommand(strNameProcedureTmpl, sqlCon)
                sqlCmd.Transaction = sqlTransTmpl
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_tmp_id", SqlDbType.Int)).Value = EntTemplate.Codigo
                    .Parameters.Add(New SqlParameter("@fk_doc_tip_id", SqlDbType.Int)).Value = EntTemplate.DocTipoId
                    .Parameters.Add(New SqlParameter("@fk_ded_tip_id", SqlDbType.Int)).Value = EntTemplate.TipoDedoId

                    .Parameters.Add(New SqlParameter("@fk_dsp_id", SqlDbType.Int)).Value = EntTemplate.DispBiometricoId
                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 40)).Value = EntTemplate.NumDocumento
                    .Parameters.Add(New SqlParameter("@c_int_cod_rp", SqlDbType.VarChar, 10)).Value = EntTemplate.CodigoRP
                    .Parameters.Add(New SqlParameter("@tmp_prop", SqlDbType.VarBinary, 1500)).Value = EntTemplate.TemplatePropietario
                    .Parameters.Add(New SqlParameter("@tmp_ansi", SqlDbType.VarBinary, 1500)).Value = EntTemplate.TemplateANSI
                    .Parameters.Add(New SqlParameter("@c_hos_pc", SqlDbType.VarChar, 20)).Value = EntTemplate.NombrePC
                    .Parameters.Add(New SqlParameter("@c_hos_mac", SqlDbType.VarChar, 20)).Value = EntTemplate.MacPC
                    .Parameters.Add(New SqlParameter("@c_hos_ip", SqlDbType.VarChar, 50)).Value = EntTemplate.IpPC
                    .Parameters.Add(New SqlParameter("@c_int_ape_pat", SqlDbType.VarChar, 100)).Value = EntTemplate.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@c_int_ape_mat", SqlDbType.VarChar, 100)).Value = EntTemplate.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@c_int_nom", SqlDbType.VarChar, 150)).Value = EntTemplate.Nombres

                    .Parameters.Add(New SqlParameter("@n_snc_sede", SqlDbType.Int)).Value = EntTemplate.RegSincronizadoSede
                    .Parameters.Add(New SqlParameter("@n_ind_cal", SqlDbType.Int)).Value = EntTemplate.IndiceCalidadImg
                    .Parameters.Add(New SqlParameter("@n_est_dedo", SqlDbType.Int)).Value = EntTemplate.EstadoDedo
                    .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 500)).Value = EntTemplate.Observacion

                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntTemplate.PenalId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntTemplate.RegionId

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output


                    .ExecuteNonQuery()
                    intIdTmpl = .Parameters("@variable_out").Value
                    out_sms = If(IsDBNull(.Parameters("@str_out_sms").Value), "", .Parameters("@str_out_sms").Value)
                End With

                If Not EntWSQ.WSQFile Is Nothing Then
                    Dim sqlCon2 As SqlConnection = Nothing
                    Dim sqlCmd2 As SqlCommand = Nothing
                    Try
                        sqlCon2 = New SqlConnection(cn)
                        sqlCmd2 = New SqlCommand(strNameProcedureWsq, sqlCon2)
                        With sqlCmd2
                            .CommandType = CommandType.StoredProcedure
                            If EntWSQ.Codigo = -1 Then
                                .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "ins"
                                .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "ins_mant"
                            Else
                                .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "upd"
                                .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "upd_mant"
                            End If
                            

                            .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = EntWSQ.Codigo
                            .Parameters.Add(New SqlParameter("@wsq_file", SqlDbType.VarBinary, 0)).Value = EntWSQ.WSQFile
                            .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = If(EntWSQ.HuellaTemplateId > 0, EntWSQ.HuellaTemplateId, intIdTmpl) 'EntWSQ.HuellaTemplateId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntWSQ.PenalId
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntWSQ.RegionId

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                            sqlCon2.Open()
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        sqlTransTmpl.Rollback()
                        Throw New Exception(ex.Message)
                    Finally
                        sqlTransTmpl.Commit()
                        sqlCmd2.Dispose()
                        sqlCon2.Close()
                        sqlCon2 = Nothing
                    End Try
                Else
                    If EntWSQ.Codigo > 0 Then 'si ya setear a nulo wsq
                        Dim sqlCon2 As SqlConnection = Nothing
                        Dim sqlCmd2 As SqlCommand = Nothing
                        Try
                            sqlCon2 = New SqlConnection(cn)
                            sqlCmd2 = New SqlCommand(strNameProcedureWsq, sqlCon2)
                            With sqlCmd2
                                .CommandType = CommandType.StoredProcedure
                                .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                                .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                                .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = EntWSQ.Codigo
                                .Parameters.Add(New SqlParameter("@wsq_file", SqlDbType.VarBinary, 0)).Value = Nothing
                                .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = intIdTmpl 'EntWSQ.HuellaTemplateId
                                .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntWSQ.PenalId
                                .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntWSQ.RegionId

                                .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                                .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                                .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                                .Parameters("@variable_out").Direction = ParameterDirection.Output
                                .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                                sqlCon2.Open()
                                .ExecuteNonQuery()
                            End With
                        Catch ex As Exception
                            sqlTransTmpl.Rollback()
                            Throw New Exception(ex.Message)
                        Finally
                            sqlTransTmpl.Commit()
                            sqlCmd2.Dispose()
                            sqlCon2.Close()
                            sqlCon2 = Nothing
                        End Try
                    Else
                        sqlTransTmpl.Commit()
                    End If
                End If

            Catch ex As Exception
                sqlTransTmpl.Rollback()
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try


            Return intIdTmpl
        End Function

        Public Shared Function GrabarTratamiento(accion As String, opcion As String, cn As String, ByVal EntTemplate As Entity.Ent_HuellaTemplate,
                                                 EntWSQ As Entity.Ent_HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer

            Dim intIdTmpl As Integer = -1
            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim sqlTransTmpl As SqlTransaction = Nothing

            Try
                sqlCon = New SqlConnection(cn)
                sqlCon.Open()
                sqlTransTmpl = sqlCon.BeginTransaction()
                sqlCmd = New SqlCommand(strNameProcedureTmpl, sqlCon)
                sqlCmd.Transaction = sqlTransTmpl
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_tmp_id", SqlDbType.Int)).Value = EntTemplate.Codigo
                    .Parameters.Add(New SqlParameter("@fk_doc_tip_id", SqlDbType.Int)).Value = EntTemplate.DocTipoId
                    .Parameters.Add(New SqlParameter("@fk_ded_tip_id", SqlDbType.Int)).Value = EntTemplate.TipoDedoId

                    .Parameters.Add(New SqlParameter("@fk_dsp_id", SqlDbType.Int)).Value = EntTemplate.DispBiometricoId
                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 40)).Value = EntTemplate.NumDocumento

                    .Parameters.Add(New SqlParameter("@c_int_cod_rp", SqlDbType.VarChar, 40)).Value = EntTemplate.CodigoRP
                    .Parameters.Add(New SqlParameter("@c_int_ape_pat", SqlDbType.VarChar, 40)).Value = EntTemplate.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@c_int_ape_mat", SqlDbType.VarChar, 40)).Value = EntTemplate.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@c_int_nom", SqlDbType.VarChar, 40)).Value = EntTemplate.Nombres

                    .Parameters.Add(New SqlParameter("@n_tip_cap_hue", SqlDbType.Int)).Value = EntTemplate.TipoCaptura
                    .Parameters.Add(New SqlParameter("@tmp_prop", SqlDbType.VarBinary, 1500)).Value = EntTemplate.TemplatePropietario
                    .Parameters.Add(New SqlParameter("@tmp_ansi", SqlDbType.VarBinary, 1500)).Value = EntTemplate.TemplateANSI
                    .Parameters.Add(New SqlParameter("@c_hos_pc", SqlDbType.VarChar, 20)).Value = EntTemplate.NombrePC
                    .Parameters.Add(New SqlParameter("@c_hos_mac", SqlDbType.VarChar, 20)).Value = EntTemplate.MacPC
                    .Parameters.Add(New SqlParameter("@c_hos_ip", SqlDbType.VarChar, 50)).Value = EntTemplate.IpPC

                    .Parameters.Add(New SqlParameter("@n_snc_sede", SqlDbType.Int)).Value = EntTemplate.RegSincronizadoSede
                    .Parameters.Add(New SqlParameter("@n_ind_cal", SqlDbType.Int)).Value = EntTemplate.IndiceCalidadImg
                    .Parameters.Add(New SqlParameter("@n_est_dedo", SqlDbType.Int)).Value = EntTemplate.EstadoDedo
                    .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 500)).Value = EntTemplate.Observacion

                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = EntTemplate.PenalId
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = EntTemplate.RegionId

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                    .ExecuteNonQuery()
                    intIdTmpl = .Parameters("@variable_out").Value
                    out_sms = .Parameters("@str_out_sms").Value
                End With

                If EntTemplate.EstadoDedo = Type.Enumeracion.EstadoDedo.NoDisponible And EntTemplate.EstadoDedo = Type.Enumeracion.EstadoDedo.Amputado Then
                    Return intIdTmpl
                End If

                Dim sqlCon2 As SqlConnection = Nothing
                Dim sqlCmd2 As SqlCommand = Nothing
                Try
                    sqlCon2 = New SqlConnection(cn)
                    sqlCmd2 = New SqlCommand(strNameProcedureWsq, sqlCon2)
                    With sqlCmd2
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                        .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = EntWSQ.Codigo
                        .Parameters.Add(New SqlParameter("@wsq_file", SqlDbType.VarBinary, 0)).Value = EntWSQ.WSQFile
                        .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = intIdTmpl 'EntWSQ.HuellaTemplateId
                        .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntWSQ.PenalId
                        .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntWSQ.RegionId

                        .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                        .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                        .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                        .Parameters("@variable_out").Direction = ParameterDirection.Output
                        .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                        sqlCon2.Open()
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    sqlTransTmpl.Rollback()
                    Throw New Exception(ex.Message)
                Finally
                    sqlTransTmpl.Commit()
                    sqlCmd2.Dispose()
                    sqlCon2.Close()
                    sqlCon2 = Nothing
                End Try

            Catch ex As Exception
                sqlTransTmpl.Rollback()
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return intIdTmpl
        End Function

#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(accion As String, opcion As String, cn As String, Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intTmplId As Integer = -1

            Dim sqlCon As SqlConnection = Nothing
            Dim sqlCmd As SqlCommand = Nothing
            Dim trs As SqlTransaction = Nothing
            Try

                sqlCon = New SqlConnection(CN)
                sqlCon.Open()
                trs = sqlCon.BeginTransaction()
                sqlCmd = New SqlCommand(strNameProcedureWsq, sqlCon)
                sqlCmd.Transaction = trs
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_tmp_id", SqlDbType.Int)).Value = Codigo

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .Parameters("@str_out_sms").Direction = ParameterDirection.Output
                    .ExecuteNonQuery()
                End With



                Dim sqlCon1 As SqlConnection = Nothing
                Dim sqlCmd1 As SqlCommand = Nothing
                Try
                    sqlCon1 = New SqlConnection(CN)
                    sqlCmd1 = New SqlCommand(strNameProcedureTmpl, sqlCon1)
                    With sqlCmd1
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                        .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                        .Parameters.Add(New SqlParameter("@pk_wsq_id", SqlDbType.Int)).Value = Codigo

                        .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = IdUsuario

                        .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                        .Parameters.Add(New SqlParameter("@str_out_sms", SqlDbType.VarChar, 300))
                        .Parameters("@variable_out").Direction = ParameterDirection.Output
                        .Parameters("@str_out_sms").Direction = ParameterDirection.Output

                        sqlCon1.Open()
                        .ExecuteNonQuery()
                        intTmplId = .Parameters("@variable_out").Value
                        out_sms = .Parameters("@str_out_sms").Value
                    End With
                Catch ex As Exception
                    trs.Rollback()
                    Throw New Exception(ex.Message)
                Finally
                    trs.Commit()
                    sqlCmd1.Dispose()
                    sqlCon1.Close()
                    sqlCon1 = Nothing
                End Try

            Catch ex As Exception
                trs.Rollback()
                Throw New Exception(ex.Message)
            Finally
                sqlCmd.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return intTmplId
        End Function
#End Region

    End Class
End Namespace