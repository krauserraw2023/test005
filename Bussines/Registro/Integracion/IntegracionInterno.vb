Imports System.Data.SqlClient

Namespace Registro.Integracion
    Public Class IntegracionInterno
        Public Function Listar(Codigo As Integer) As Entity.Registro.Integracion.IntegracionInterno
            Dim ent As New Entity.Registro.Integracion.IntegracionInterno
            Dim col As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInterno)
            ent.Codigo = Codigo
            col = Listar(ent)
            If col Is Nothing OrElse col.Count = 0 Then Return Nothing

            Return col.Entity(0)
        End Function

        Public Function Listar(ent As Entity.Registro.Integracion.IntegracionInterno) As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInterno)
            With ent
                .FechaIntegracionIni = Legolas.Components.FechaHora.FechaTimeLong(.FechaIntegracionIni, "00:00:00")
                .FechaIntegracionFin = Legolas.Components.FechaHora.FechaTimeLong(.FechaIntegracionFin, "23:59:59")
            End With

            Dim col As New Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInterno)
            Dim objEnt As Entity.Registro.Integracion.IntegracionInterno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Integracion.IntegracionInterno.Listar(sqlCon, "lst", "lst_mant", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Integracion.IntegracionInterno
                        With objEnt
                            .Codigo = sqlDr("pk_int_reg_id").ToString
                            .CodigoUnicoInternoId = sqlDr("fk_int_cod_uni_id").ToString
                            .NumeroDocumentoStr = sqlDr("c_num_doc").ToString
                            .CodigoUsrUsuario = sqlDr("c_cod_usr").ToString
                            .UsuarioApellidos = sqlDr("c_usu_ape").ToString
                            .UsuarioNombres = sqlDr("c_usu_nom").ToString
                            .FechaIntegracion = sqlDr("_fec_cre").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            '.PenalId = sqlDr("_PenId").ToString
                            '.RegionId = sqlDr("_RegId").ToString
                            .CodigoUnicoSecuencial = sqlDr("cod_uni_sec").ToString
                            .TipoNacionalidadStr = sqlDr("tip_nac").ToString
                            .TotalInternos = sqlDr("total_int").ToString
                            .MotivoIntegracion = sqlDr("c_mot_int").ToString
                        End With
                        col.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return col
        End Function

        Public Function Listar_Grilla(ent As Entity.Registro.Integracion.IntegracionInterno) As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInterno)
            With ent
                .FechaIntegracionIni = Legolas.Components.FechaHora.FechaTimeLong(.FechaIntegracionIni, "00:00:00")
                .FechaIntegracionFin = Legolas.Components.FechaHora.FechaTimeLong(.FechaIntegracionFin, "23:59:59")
            End With

            Dim col As New Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInterno)
            Dim objEnt As Entity.Registro.Integracion.IntegracionInterno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Integracion.IntegracionInterno.Listar(sqlCon, "lst", "lst_grilla", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Integracion.IntegracionInterno
                        With objEnt
                            .Codigo = sqlDr("pk_int_reg_id").ToString
                            .CodigoUnicoInternoId = sqlDr("fk_int_cod_uni_id").ToString
                            .NumeroDocumentoStr = sqlDr("c_num_doc").ToString
                            .CodigoUsrUsuario = sqlDr("c_cod_usr").ToString
                            .UsuarioApellidos = sqlDr("c_usu_ape").ToString
                            .UsuarioNombres = sqlDr("c_usu_nom").ToString
                            .FechaIntegracion = sqlDr("_fec_cre").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            '.PenalId = sqlDr("_PenId").ToString
                            '.RegionId = sqlDr("_RegId").ToString
                            .CodigoUnicoSecuencial = sqlDr("cod_uni_sec").ToString
                            .TipoNacionalidadStr = sqlDr("tip_nac").ToString
                            .TotalInternos = sqlDr("total_int").ToString
                            .MotivoIntegracion = sqlDr("c_mot_int").ToString
                        End With
                        col.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return col
        End Function

        Public Function Grabar(entInt As Entity.Registro.Integracion.IntegracionInterno, _
                               entDetInt As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInternoDetalle), _
                                 ByRef outSMS As String) As Integer
            Dim intValue As Integer = -1

            If entInt.Codigo = -1 Then
                intValue = GrabarNuevo(entInt, entDetInt, outSMS)
            Else
                intValue = GrabarEditar(entInt, entDetInt, outSMS)
            End If

            Return intValue
        End Function

        Private Function GrabarEditar(entInt As Entity.Registro.Integracion.IntegracionInterno, _
                                entDetInt As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInternoDetalle), _
                                 ByRef outSMS As String) As Integer
            Dim b_error As Boolean = False
            Dim idCab As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand
            Dim trs As SqlTransaction

            Try
                sqlCon.Open()
                trs = sqlCon.BeginTransaction
                sqlCmd = sqlCon.CreateCommand
                sqlCmd.Transaction = trs


                'Dim idCodUni As Integer = -1
                'Dim entCodUni As New Entity.Registro.Integracion.CodigoUnicoInterno
                'entCodUni.TipoNacionalidad = entInt.TipoNacionalidadStr

                'idCodUni = Data.Registro.Integracion.CodigoUnicoInterno.Grabar(sqlCmd, "ins", "upd_mant", entCodUni)
                'sqlCmd.Parameters.Clear()
                'If idCodUni = -1 Then
                '    b_error = True
                'Else
                'entInt.CodigoUnicoInternoId = idCodUni

                idCab = Data.Registro.Integracion.IntegracionInterno.Grabar(sqlCmd, "upd", "upd_mant", entInt)

                If idCab = -1 Then b_error = True

                'sqlCmd.Parameters.Clear()
                'For Each ent As Entity.Registro.Integracion.IntegracionInternoDetalle In entDetInt
                '    Dim idDet As Integer = -1
                '    If ent.Codigo = -1 Then 'si es nuevo
                '        ent.IntegracionInternoId = idCab
                '        ent.CodigoUnicoInternoId = entInt.CodigoUnicoInternoId
                '        idDet = Data.Registro.Integracion.IntegracionInternoDetalle.Grabar(sqlCmd, "ins", "upd_mant", ent)
                '        sqlCmd.Parameters.Clear()

                '        If idDet = -1 Then
                '            b_error = True
                '            Exit For
                '        End If
                '    ElseIf ent.Eliminado = True Then 'si es eliminar
                '        idDet = Data.Registro.Integracion.IntegracionInterno.Eliminar(sqlCmd, "del", "del_mant", ent.Codigo, outSMS)
                '        If idDet = -1 Then
                '            b_error = True
                '            Exit For
                '        End If
                '    Else
                '        'actualizar solo obs

                '    End If
                'Next
                ''End If

                If b_error = True Then
                    idCab = -1
                    trs.Rollback()
                Else
                    trs.Commit()
                End If
            Catch ex As Exception
                Try
                    trs.Rollback()
                Catch ex2 As Exception
                End Try
                outSMS = ex.Message
            Finally
                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If
                sqlCmd = Nothing
            End Try
            Return idCab

        End Function

        Private Function GrabarNuevo(entInt As Entity.Registro.Integracion.IntegracionInterno, _
                                entDetInt As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInternoDetalle), _
                                 ByRef outSMS As String) As Integer

            Dim idCodUni As Integer = -1
            Dim c_tip_nac As String = ""
            Dim n_cod_sec As Integer = 0
            'validar


            'verificar si uno de los detalles ya tiene cod_unico, si es asi se debe tomar el codigo y asignar a los demas el mismo codUnico.
            For Each ent As Entity.Registro.Integracion.IntegracionInternoDetalle In entDetInt
                If ent.CodigoUnicoInternoId > 0 Then
                    Dim tmp_ent_cod_uni As New Entity.Registro.Integracion.CodigoUnicoInterno
                    tmp_ent_cod_uni.Codigo = ent.CodigoUnicoInternoId

                    tmp_ent_cod_uni = (New Registro.Integracion.CodigoUnicoInterno).Listar(tmp_ent_cod_uni).Item(0)

                    idCodUni = tmp_ent_cod_uni.Codigo
                    c_tip_nac = tmp_ent_cod_uni.TipoNacionalidad
                    n_cod_sec = tmp_ent_cod_uni.CodigoSecuencialUnico
                    Dim s As String
                    s = s
                End If
            Next

            Dim b_error As Boolean = False
            Dim idCab As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand
            Dim trs As SqlTransaction

            Try
                sqlCon.Open()
                trs = sqlCon.BeginTransaction
                sqlCmd = sqlCon.CreateCommand
                sqlCmd.Transaction = trs

                If idCodUni = -1 Then
                    Dim entCodUni As New Entity.Registro.Integracion.CodigoUnicoInterno
                    entCodUni.TipoNacionalidad = entInt.TipoNacionalidadStr
                    idCodUni = Data.Registro.Integracion.CodigoUnicoInterno.Grabar(sqlCmd, "ins", "ins_mant", entCodUni)
                Else
                    entInt.TipoNacionalidadStr = c_tip_nac
                End If

                sqlCmd.Parameters.Clear()
                If idCodUni = -1 Then
                    b_error = True
                Else
                    entInt.CodigoUnicoInternoId = idCodUni
                    idCab = Data.Registro.Integracion.IntegracionInterno.Grabar(sqlCmd, "ins", "ins_mant", entInt)
                    sqlCmd.Parameters.Clear()
                    For Each ent As Entity.Registro.Integracion.IntegracionInternoDetalle In entDetInt

                        If ent.IntegracionInternoId > 0 Then Continue For

                        Dim idDet As Integer = -1
                        ent.IntegracionInternoId = idCab
                        ent.CodigoUnicoInternoId = idCodUni
                        idDet = Data.Registro.Integracion.IntegracionInternoDetalle.Grabar(sqlCmd, "ins", "ins_mant", ent)
                        sqlCmd.Parameters.Clear()
                        If idDet = -1 Then
                            b_error = True
                            Exit For
                        End If
                    Next
                End If

                If b_error = True Then
                    idCab = -1
                    trs.Rollback()
                Else
                    trs.Commit()
                End If
            Catch ex As Exception
                Try
                    trs.Rollback()
                Catch ex2 As Exception
                End Try
                outSMS = ex.Message
            Finally
                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If
                sqlCmd = Nothing
            End Try
            Return idCab
        End Function



    End Class
End Namespace