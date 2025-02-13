Imports System.Data
Imports System.Data.SqlClient

Namespace Registro
    Public Class InternoMovimiento
        Private Shared strNameProcedure As String = "UP_INT_InternoMovimiento"
#Region "Listar"
        
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                     EntMov As Entity.Registro.InternoMovimiento) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.Int)).Value = EntMov.MovimientoGrupoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntMov.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntMov.IngresoID
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = EntMov.Codigo
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntMov.DocumJudicialID
                            .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = EntMov.MovimientoTipoID

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      EntMov As Entity.Registro.InternoMovimiento) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = EntMov.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntMov.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntMov.IngresoID
                    .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = EntMov.MovimientoTipoID
                    .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = EntMov.MovimientoMotivoID
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntMov.DocumJudicialID
                    .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.Int)).Value = EntMov.MovimientoGrupoID
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntMov._RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntMov._PenalID
                    '/*datos interno*/
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 250)).Value = EntMov.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 250)).Value = EntMov.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 250)).Value = EntMov.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 250)).Value = EntMov.Nombres
                    '/*ingresos*/                    
                    .Parameters.Add(New SqlParameter("@fechainicio", SqlDbType.BigInt)).Value = EntMov.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fechafin", SqlDbType.BigInt)).Value = EntMov.FechaIngresoFin
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_LM(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      EntMov As Entity.Registro.InternoMovimiento) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = EntMov.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = EntMov.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = EntMov.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = EntMov.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = EntMov.MovimientoTipoID
                    .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = EntMov.MovimientoMotivoID
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = EntMov.DocumJudicialID
                    .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.Int)).Value = EntMov.MovimientoGrupoID
                    .Parameters.Add(New SqlParameter("@mov_reg_org_id", SqlDbType.Int)).Value = EntMov.RegionOrigenID
                    .Parameters.Add(New SqlParameter("@mov_pen_org", SqlDbType.Int)).Value = EntMov.PenalOrigenID
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = EntMov._RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = EntMov._PenalID
                    '.Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = EntMov.SedeRowId
                    '/*datos interno*/
                    .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 100)).Value = EntMov.DocumJudicialNum
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 250)).Value = EntMov.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 250)).Value = EntMov.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 250)).Value = EntMov.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 250)).Value = EntMov.Nombres
                    '/*ingresos*/                    
                    .Parameters.Add(New SqlParameter("@fechainicio", SqlDbType.BigInt)).Value = EntMov.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fechafin", SqlDbType.BigInt)).Value = EntMov.FechaIngresoFin
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      objEnt As Entity.Registro.InternoMovimiento) As Integer

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.DocumJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 100)).Value = objEnt.DocumJudicialNum

                            .Parameters.Add(New SqlParameter("@doc_jud_fec_rec", SqlDbType.BigInt)).Value = objEnt.DocumJudicialFecharecepcion
                            .Parameters.Add(New SqlParameter("@doc_jud_fec", SqlDbType.BigInt)).Value = objEnt.DocumJudicialFecha
                            .Parameters.Add(New SqlParameter("@doc_jud_Tip_aut_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_id", SqlDbType.Int)).Value = objEnt.AutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_sal_id", SqlDbType.Int)).Value = objEnt.SalaJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.DocJudJuez
                            .Parameters.Add(New SqlParameter("@doc_jud_sec", SqlDbType.VarChar, 500)).Value = objEnt.DocJudSecretario
                            .Parameters.Add(New SqlParameter("@doc_jud_obs", SqlDbType.VarChar, 500)).Value = objEnt.DocJudObservacion

                            .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.Int)).Value = objEnt.MovimientoGrupoID
                            .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = objEnt.MovimientoTipoID
                            .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoMotivoID
                            .Parameters.Add(New SqlParameter("@mov_sub_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoSubMotivoID
                            .Parameters.Add(New SqlParameter("@mov_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@mov_reg_org_id", SqlDbType.Int)).Value = objEnt.RegionOrigenID
                            .Parameters.Add(New SqlParameter("@mov_pen_org", SqlDbType.Int)).Value = objEnt.PenalOrigenID

                            .Parameters.Add(New SqlParameter("@mov_reg_des_id", SqlDbType.Int)).Value = objEnt.RegionDestinoID
                            .Parameters.Add(New SqlParameter("@mov_pen_des", SqlDbType.Int)).Value = objEnt.PenalDestinoID
                            .Parameters.Add(New SqlParameter("@mov_org_otr", SqlDbType.VarChar, 250)).Value = objEnt.OrigenNombre
                            .Parameters.Add(New SqlParameter("@mov_des_otr", SqlDbType.VarChar, 250)).Value = objEnt.DestinoNombre
                            .Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@mov_obs", SqlDbType.VarChar, 2500)).Value = objEnt.DocJudObservacion

                            .Parameters.Add(New SqlParameter("@mov_fec_fall", SqlDbType.BigInt)).Value = objEnt.FechaFallecimiento

                            .Parameters.Add(New SqlParameter("@mov_per_val", SqlDbType.VarChar, 20)).Value = objEnt.PeriodoRetorno
                            .Parameters.Add(New SqlParameter("@mov_per_tip", SqlDbType.VarChar, 20)).Value = objEnt.PeriodoTipo
                            .Parameters.Add(New SqlParameter("@mov_fec_ret", SqlDbType.BigInt)).Value = objEnt.FechaRetorno

                            .Parameters.Add(New SqlParameter("@int_ing_fec_isp", SqlDbType.BigInt)).Value = objEnt.FechaInternamientoPenalOrigen
                            .Parameters.Add(New SqlParameter("@mov_cla", SqlDbType.BigInt)).Value = objEnt._Clasificacion
                            .Parameters.Add(New SqlParameter("@mov_est_des_id", SqlDbType.SmallInt)).Value = objEnt.EstadoPenalDestinoID

                            .Parameters.Add(New SqlParameter("@doc_jud_id_ref", SqlDbType.BigInt)).Value = objEnt.DocJudicialReferencia_OTHSM
                            .Parameters.Add(New SqlParameter("@mov_est_ejec", SqlDbType.BigInt)).Value = objEnt.Estado_Ejecucion_Ejecutado
                            .Parameters.Add(New SqlParameter("@mov_est_ejec_obs", SqlDbType.VarChar, 250)).Value = objEnt.Movimiento_Observacion_Estado_Ejecucion_IM

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt._RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt._PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
                Return -1
            End Try
        End Function

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Registro.InternoMovimiento) As Integer

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.DocumJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 100)).Value = objEnt.DocumJudicialNum

                            .Parameters.Add(New SqlParameter("@doc_jud_fec_rec", SqlDbType.BigInt)).Value = objEnt.DocumJudicialFecharecepcion
                            .Parameters.Add(New SqlParameter("@doc_jud_fec", SqlDbType.BigInt)).Value = objEnt.DocumJudicialFecha
                            .Parameters.Add(New SqlParameter("@doc_jud_Tip_aut_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_aut_id", SqlDbType.Int)).Value = objEnt.AutoridadJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_sal_id", SqlDbType.Int)).Value = objEnt.SalaJudicialID
                            .Parameters.Add(New SqlParameter("@doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.DocJudJuez
                            .Parameters.Add(New SqlParameter("@doc_jud_sec", SqlDbType.VarChar, 500)).Value = objEnt.DocJudSecretario
                            '.Parameters.Add(New SqlParameter("@doc_jud_obs", SqlDbType.VarChar, 500)).Value = objEnt.DocJudObservacion

                            .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.Int)).Value = objEnt.MovimientoGrupoID
                            .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = objEnt.MovimientoTipoID
                            .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoMotivoID
                            .Parameters.Add(New SqlParameter("@mov_sub_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoSubMotivoID
                            .Parameters.Add(New SqlParameter("@mov_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@mov_reg_org_id", SqlDbType.Int)).Value = objEnt.RegionOrigenID
                            .Parameters.Add(New SqlParameter("@mov_pen_org", SqlDbType.Int)).Value = objEnt.PenalOrigenID

                            .Parameters.Add(New SqlParameter("@mov_reg_des_id", SqlDbType.Int)).Value = objEnt.RegionDestinoID
                            .Parameters.Add(New SqlParameter("@mov_pen_des", SqlDbType.Int)).Value = objEnt.PenalDestinoID
                            .Parameters.Add(New SqlParameter("@mov_org_otr", SqlDbType.VarChar, 250)).Value = objEnt.OrigenNombre
                            .Parameters.Add(New SqlParameter("@mov_des_otr", SqlDbType.VarChar, 250)).Value = objEnt.DestinoNombre
                            .Parameters.Add(New SqlParameter("@mov_est_des_id", SqlDbType.Int)).Value = objEnt.EstadoPenalDestinoID
                            .Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@mov_obs", SqlDbType.VarChar, 2500)).Value = objEnt.DocJudObservacion
                            .Parameters.Add(New SqlParameter("@mov_fec_fall", SqlDbType.BigInt)).Value = objEnt.FechaFallecimiento

                            .Parameters.Add(New SqlParameter("@mov_per_val", SqlDbType.VarChar, 20)).Value = objEnt.PeriodoRetorno
                            .Parameters.Add(New SqlParameter("@mov_per_tip", SqlDbType.VarChar, 20)).Value = objEnt.PeriodoTipo
                            .Parameters.Add(New SqlParameter("@mov_fec_ret", SqlDbType.BigInt)).Value = objEnt.FechaRetorno

                            .Parameters.Add(New SqlParameter("@n_int_pen_bloq_id", SqlDbType.Int)).Value = objEnt.EstadoBloqueoId
                            .Parameters.Add(New SqlParameter("@int_ing_fec_isp", SqlDbType.BigInt)).Value = objEnt.FechaInternamientoPenalOrigen
                            .Parameters.Add(New SqlParameter("@mov_cla", SqlDbType.BigInt)).Value = objEnt._Clasificacion
                            '.Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.BigInt)).Value = objEnt.SedeRowId

                            .Parameters.Add(New SqlParameter("@doc_jud_id_ref", SqlDbType.BigInt)).Value = objEnt.DocJudicialReferencia_OTHSM
                            .Parameters.Add(New SqlParameter("@mov_est_ejec", SqlDbType.Int)).Value = objEnt.Estado_Ejecucion_Ejecutado
                            .Parameters.Add(New SqlParameter("@mov_est_ejeC_obs", SqlDbType.VarChar, 250)).Value = objEnt.Movimiento_Observacion_Estado_Ejecucion_IM

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt._RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt._PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
                Return -1
            End Try
        End Function

        Public Shared Function Insertar_MovimientosDeEgresoPorClasificacion_ETL(DocClasificacionId As Integer) As Integer
            Dim id As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", "ins"))
                            .Parameters.Add(New SqlParameter("@opcion", "ins_mant_clasif_ETL"))
                            .Parameters.Add(New SqlParameter("@doc_clasif_id", DocClasificacionId))
                            .Parameters.Add(New SqlParameter("@_usuario", Legolas.Configuration.Usuario.Codigo))

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            id = .Parameters("@variable_out").Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                id = -1
            End Try

            Return id
        End Function



        Public Shared Function Insertar_MovimientosDeEgresoPorClasificacion_Carceleta(ByVal lstMov As List(Of Entity.Registro.InternoMovimiento)) As Boolean
            Dim exito As Boolean = False
            Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Try
                    sqlCon.Open()
                Catch ex As Exception
                    Throw New Exception(ex.Message)
                End Try

                Dim trs As SqlTransaction = sqlCon.BeginTransaction

                Try

                    For Each objEnt As Entity.Registro.InternoMovimiento In lstMov

                        Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                            With sqlCmd
                                .Transaction = trs
                                .CommandType = CommandType.StoredProcedure
                                .CommandTimeout = 60 * 4  '2 minutos

                                .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = "ins"
                                .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = "ins_mant_clasif_ETL"
                                .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = objEnt.Codigo
                                .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                                .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                                .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                                .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.DocumJudicialID
                                .Parameters.Add(New SqlParameter("@doc_jud_num", SqlDbType.VarChar, 100)).Value = objEnt.DocumJudicialNum

                                .Parameters.Add(New SqlParameter("@doc_jud_fec_rec", SqlDbType.BigInt)).Value = objEnt.DocumJudicialFecharecepcion
                                .Parameters.Add(New SqlParameter("@doc_jud_fec", SqlDbType.BigInt)).Value = objEnt.DocumJudicialFecha
                                .Parameters.Add(New SqlParameter("@doc_jud_Tip_aut_id", SqlDbType.Int)).Value = objEnt.TipoAutoridadJudicialID
                                .Parameters.Add(New SqlParameter("@doc_jud_aut_id", SqlDbType.Int)).Value = objEnt.AutoridadJudicialID
                                .Parameters.Add(New SqlParameter("@doc_jud_sal_id", SqlDbType.Int)).Value = objEnt.SalaJudicialID
                                .Parameters.Add(New SqlParameter("@doc_jud_jue", SqlDbType.VarChar, 200)).Value = objEnt.DocJudJuez
                                .Parameters.Add(New SqlParameter("@doc_jud_sec", SqlDbType.VarChar, 500)).Value = objEnt.DocJudSecretario
                                .Parameters.Add(New SqlParameter("@doc_jud_obs", SqlDbType.VarChar, 500)).Value = objEnt.DocJudObservacion

                                .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.Int)).Value = objEnt.MovimientoGrupoID
                                .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.Int)).Value = objEnt.MovimientoTipoID
                                .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoMotivoID
                                .Parameters.Add(New SqlParameter("@mov_sub_mot_id", SqlDbType.Int)).Value = objEnt.MovimientoSubMotivoID
                                .Parameters.Add(New SqlParameter("@mov_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                                .Parameters.Add(New SqlParameter("@mov_reg_org_id", SqlDbType.Int)).Value = objEnt.RegionOrigenID
                                .Parameters.Add(New SqlParameter("@mov_pen_org", SqlDbType.Int)).Value = objEnt.PenalOrigenID

                                .Parameters.Add(New SqlParameter("@mov_reg_des_id", SqlDbType.Int)).Value = objEnt.RegionDestinoID
                                .Parameters.Add(New SqlParameter("@mov_pen_des", SqlDbType.Int)).Value = objEnt.PenalDestinoID
                                .Parameters.Add(New SqlParameter("@mov_org_otr", SqlDbType.VarChar, 250)).Value = objEnt.OrigenNombre
                                .Parameters.Add(New SqlParameter("@mov_des_otr", SqlDbType.VarChar, 250)).Value = objEnt.DestinoNombre
                                .Parameters.Add(New SqlParameter("@mov_est_des_id", SqlDbType.Int)).Value = objEnt.EstadoPenalDestinoID
                                .Parameters.Add(New SqlParameter("@mov_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                                .Parameters.Add(New SqlParameter("@mov_obs", SqlDbType.VarChar, 2500)).Value = objEnt.Observacion
                                .Parameters.Add(New SqlParameter("@mov_fec_fall", SqlDbType.BigInt)).Value = objEnt.FechaFallecimiento

                                .Parameters.Add(New SqlParameter("@mov_per_val", SqlDbType.VarChar, 20)).Value = objEnt.PeriodoRetorno
                                .Parameters.Add(New SqlParameter("@mov_per_tip", SqlDbType.VarChar, 20)).Value = objEnt.PeriodoTipo
                                .Parameters.Add(New SqlParameter("@mov_fec_ret", SqlDbType.BigInt)).Value = objEnt.FechaRetorno

                                .Parameters.Add(New SqlParameter("@n_int_pen_bloq_id", SqlDbType.Int)).Value = objEnt.EstadoBloqueoId
                                .Parameters.Add(New SqlParameter("@int_ing_fec_isp", SqlDbType.BigInt)).Value = objEnt.FechaInternamientoPenalOrigen
                                .Parameters.Add(New SqlParameter("@mov_cla", SqlDbType.BigInt)).Value = objEnt._Clasificacion
                                '.Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.BigInt)).Value = objEnt.SedeRowId

                                .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt._RegionID
                                .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt._PenalID
                                .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                                .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                                .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                                .Parameters("@variable_out").Direction = ParameterDirection.Output

                                .ExecuteNonQuery()
                                Dim rpt As Integer = .Parameters("@variable_out").Value

                                If (rpt <= 0) Then
                                    trs.Rollback()
                                    Return False
                                End If

                            End With
                        End Using

                    Next

                    trs.Commit()
                    exito = True

                Catch ex As Exception
                    trs.Rollback()
                    Throw New Exception(ex.Message)
                End Try

            End Using

            Return exito
        End Function

#End Region

#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, IngresoID As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
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
                Return -1
            End Try
        End Function

        Public Shared Function Eliminar_LM(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, InternoID As Integer, IngresoID As Integer, IngresoInpeId As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@mov_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede
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
                Return -1
            End Try
        End Function
#End Region
        

    End Class

End Namespace

