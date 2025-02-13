Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.ConstanciaReclusion
    Public Class Tramite
        Private Shared strNameProcedure As String = "usp_reg_cons_reclu_mov_tramite"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String,
                                                  objEntFiltro As Entity.Registro.ConstanciaReclusion.Tramite) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEntFiltro.idRegion 'se usa
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEntFiltro.idPenal 'se usa
                            .Parameters.Add(New SqlParameter("@pk_cons_rec_tra_id", SqlDbType.Int)).Value = objEntFiltro.codigo 'se usa
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEntFiltro.idInterno 'se usa
                            .Parameters.Add(New SqlParameter("@fk_int_inp_id", SqlDbType.Int)).Value = objEntFiltro.idIngresoInpe 'se usa
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEntFiltro.idIngreso 'se usa
                            .Parameters.Add(New SqlParameter("@fk_tip_sol_id", SqlDbType.SmallInt)).Value = objEntFiltro.idTipoSolicitante
                            .Parameters.Add(New SqlParameter("@n_tip_doc_ref", SqlDbType.SmallInt)).Value = objEntFiltro.documentoReferenciaTipo 'se usa
                            .Parameters.Add(New SqlParameter("@c_nro_ser", SqlDbType.VarChar, 10)).Value = objEntFiltro.serieRecibo 'se usa                            
                            .Parameters.Add(New SqlParameter("@c_nro_doc_ref", SqlDbType.VarChar, 50)).Value = objEntFiltro.documentoReferenciaNumero 'se usa
                            .Parameters.Add(New SqlParameter("@f_fec_rec_ep", SqlDbType.DateTime2)).Value = objEntFiltro.fechaRecepcionEP 'se usa

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEntFiltro As Entity.Registro.ConstanciaReclusion.Tramite) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEntFiltro.idRegion
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEntFiltro.idPenal
                    .Parameters.Add(New SqlParameter("@pk_cons_rec_tra_id", SqlDbType.Int)).Value = objEntFiltro.codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEntFiltro.idInterno
                    .Parameters.Add(New SqlParameter("@fk_int_inp_id", SqlDbType.Int)).Value = objEntFiltro.idIngresoInpe
                    .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEntFiltro.idIngreso
                    .Parameters.Add(New SqlParameter("@fk_tip_sol_id", SqlDbType.Int)).Value = objEntFiltro.idTipoSolicitante
                    .Parameters.Add(New SqlParameter("@n_tip_doc_ref", SqlDbType.Int)).Value = objEntFiltro.documentoReferenciaTipo
                    .Parameters.Add(New SqlParameter("@c_nro_doc_ref", SqlDbType.VarChar, 20)).Value = objEntFiltro.documentoReferenciaNumero
                    .Parameters.Add(New SqlParameter("@c_res_int_cod_rp", SqlDbType.VarChar, 10)).Value = objEntFiltro.internoCodigoRD
                    .Parameters.Add(New SqlParameter("@c_res_int_pri_ape", SqlDbType.VarChar, 50)).Value = objEntFiltro.internoApellidos
                    .Parameters.Add(New SqlParameter("@c_res_int_seg_ape", SqlDbType.VarChar, 50)).Value = objEntFiltro.internoApellidos
                    .Parameters.Add(New SqlParameter("@c_res_int_nom", SqlDbType.VarChar, 50)).Value = objEntFiltro.internoNombre
                    .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt)).Value = objEntFiltro.estado
                    .Parameters.Add(New SqlParameter("@tip_busq_fec", SqlDbType.SmallInt)).Value = objEntFiltro.tipoBusquedaFecha
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.DateTime2)).Value = objEntFiltro.fechaBusquedaInicio
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.DateTime2)).Value = objEntFiltro.fechaBusquedaFinal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region

#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Registro.ConstanciaReclusion.Tramite) As Integer

            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cons_rec_tra_id", SqlDbType.Int)).Value = objEnt.codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.idInterno
                            .Parameters.Add(New SqlParameter("@fk_int_inp_id", SqlDbType.Int)).Value = objEnt.idIngresoInpe
                            .Parameters.Add(New SqlParameter("@fk_int_ing_id", SqlDbType.Int)).Value = objEnt.idIngreso
                            .Parameters.Add(New SqlParameter("@c_nro_tram", SqlDbType.VarChar, 20)).Value = objEnt.numeroTramite
                            .Parameters.Add(New SqlParameter("@c_nro_cr", SqlDbType.VarChar, 20)).Value = objEnt.numeroCR
                            .Parameters.Add(New SqlParameter("@f_fec_cr", SqlDbType.DateTime2)).Value = objEnt.fechaCR
                            .Parameters.Add(New SqlParameter("@fk_tip_sol_id", SqlDbType.Int)).Value = objEnt.idTipoSolicitante
                            .Parameters.Add(New SqlParameter("@fk_dis_jud_id", SqlDbType.Int)).Value = objEnt.idDistritoJudicial
                            .Parameters.Add(New SqlParameter("@fk_aut_jud_id", SqlDbType.Int)).Value = objEnt.idAutoridadJudicial
                            .Parameters.Add(New SqlParameter("@n_tip_doc_ref", SqlDbType.Int)).Value = objEnt.documentoReferenciaTipo
                            .Parameters.Add(New SqlParameter("@c_nro_ser", SqlDbType.VarChar, 5)).Value = objEnt.serieRecibo
                            .Parameters.Add(New SqlParameter("@c_nro_doc_ref", SqlDbType.VarChar, 50)).Value = objEnt.documentoReferenciaNumero
                            .Parameters.Add(New SqlParameter("@f_fec_doc_ref", SqlDbType.DateTime2)).Value = objEnt.documentoReferenciaFecha
                            .Parameters.Add(New SqlParameter("@f_fec_rec_ep", SqlDbType.DateTime2)).Value = objEnt.fechaRecepcionEP
                            .Parameters.Add(New SqlParameter("@f_fec_rec_rp", SqlDbType.DateTime2)).Value = objEnt.fechaRecepcionRP
                            .Parameters.Add(New SqlParameter("@n_tip_tram", SqlDbType.Int)).Value = objEnt.tipoTramite
                            .Parameters.Add(New SqlParameter("@n_est", SqlDbType.SmallInt, 1)).Value = objEnt.estado
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 5000)).Value = objEnt.observacion
                            .Parameters.Add(New SqlParameter("@c_obs_anu", SqlDbType.VarChar, 500)).Value = objEnt.observacionAnulacion
                            .Parameters.Add(New SqlParameter("@c_res_int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.internoCodigoRD
                            .Parameters.Add(New SqlParameter("@c_res_int_pri_ape", SqlDbType.VarChar, 50)).Value = objEnt.internoPrimerApellido
                            .Parameters.Add(New SqlParameter("@c_res_int_seg_ape", SqlDbType.VarChar, 50)).Value = objEnt.internoSegundoApellido
                            .Parameters.Add(New SqlParameter("@c_res_int_nom", SqlDbType.VarChar, 50)).Value = objEnt.internoNombre
                            .Parameters.Add(New SqlParameter("@c_res_int_nom_aso", SqlDbType.VarChar, 5000)).Value = objEnt.internoNombreAsociado
                            .Parameters.Add(New SqlParameter("@fk_arc_dig_id_int_fot_pc", SqlDbType.Int)).Value = objEnt.internoIdFotoPerfilCentro
                            .Parameters.Add(New SqlParameter("@c_res_int_fot_bas_64", SqlDbType.VarChar, -1)).Value = objEnt.internoFotoBase64
                            .Parameters.Add(New SqlParameter("@f_res_int_fec_isp", SqlDbType.VarChar, 15)).Value = objEnt.internoFechaIngSistPen
                            .Parameters.Add(New SqlParameter("@f_res_int_fec_ing", SqlDbType.VarChar, 15)).Value = objEnt.internoFechaIngreso
                            .Parameters.Add(New SqlParameter("@fk_int_exp_id", SqlDbType.Int)).Value = objEnt.idExpediente
                            .Parameters.Add(New SqlParameter("@fk_dis_jud_id_res", SqlDbType.Int)).Value = objEnt.idDistritoJudicialResp
                            .Parameters.Add(New SqlParameter("@fk_aut_jud_id_res", SqlDbType.Int)).Value = objEnt.idSalaJudicialResp
                            .Parameters.Add(New SqlParameter("@c_res_exp_num", SqlDbType.VarChar, 50)).Value = objEnt.expedienteNumeroResp
                            .Parameters.Add(New SqlParameter("@n_res_exp_sit_jur", SqlDbType.SmallInt)).Value = objEnt.expedienteSitJur
                            .Parameters.Add(New SqlParameter("@c_res_exp_secr", SqlDbType.VarChar, 50)).Value = objEnt.expedienteSecretarioResp
                            .Parameters.Add(New SqlParameter("@c_res_exp_deli", SqlDbType.VarChar, 5000)).Value = objEnt.expedienteDelitoResp
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.idRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.idPenal
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
                Return -1
            End Try
        End Function
#End Region
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_cons_rec_tra_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function

    End Class
#End Region
End Namespace
