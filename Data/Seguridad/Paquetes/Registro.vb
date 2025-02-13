Imports System.Data
Imports System.Data.SqlClient
Namespace Seguridad.Paquetes
    Public Class Registro
        Private Shared strNameProcedure As String = "usp_seg_pqt_registro_paquetes_mov"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Seguridad.Paquetes.Registro) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_reg_pqt_id", SqlDbType.Int)).Value = objEnt.codigo
                            .Parameters.Add(New SqlParameter("@fk_vis_id", SqlDbType.Int)).Value = objEnt.idVisita
                            .Parameters.Add(New SqlParameter("@c_vis_ape_nom", SqlDbType.VarChar, 150)).Value = objEnt.visitaApellidosNombres
                            .Parameters.Add(New SqlParameter("@c_vis_num_doc", SqlDbType.VarChar, 20)).Value = objEnt.visitaNumeroDocumento
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.idInterno
                            .Parameters.Add(New SqlParameter("@c_int_ape_nom", SqlDbType.VarChar, 150)).Value = objEnt.internoApellidosNombres
                            .Parameters.Add(New SqlParameter("@fk_par_id", SqlDbType.Int)).Value = objEnt.idParentesco
                            .Parameters.Add(New SqlParameter("@f_fec_reg", SqlDbType.DateTime2)).Value = objEnt.fechaRegistro
                            .Parameters.Add(New SqlParameter("@n_tip_pre", SqlDbType.SmallInt)).Value = objEnt.tipoPresentacion
                            .Parameters.Add(New SqlParameter("@fk_tip_art_id", SqlDbType.Int)).Value = objEnt.idTipoArticulo
                            .Parameters.Add(New SqlParameter("@n_pes", SqlDbType.SmallInt)).Value = objEnt.peso
                            .Parameters.Add(New SqlParameter("@n_num_ele", SqlDbType.SmallInt)).Value = objEnt.numeroElementos
                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 500)).Value = objEnt.observacion
                            .Parameters.Add(New SqlParameter("@fk_fot_pqt_id", SqlDbType.Int)).Value = objEnt.idFotoPaquete
                            .Parameters.Add(New SqlParameter("@c_nom_arc_fot", SqlDbType.VarChar, 100)).Value = objEnt.nombreFotoPaquete

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Value = .Parameters("@variable_out").Value
                            Return Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Seguridad.Paquetes.Registro) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_reg_pqt_id", SqlDbType.Int)).Value = objEnt.codigo
                    .Parameters.Add(New SqlParameter("@fk_vis_id", SqlDbType.Int)).Value = objEnt.idVisita
                    .Parameters.Add(New SqlParameter("@c_vis_ape_nom", SqlDbType.VarChar, 150)).Value = objEnt.visitaApellidosNombres
                    .Parameters.Add(New SqlParameter("@c_vis_num_doc", SqlDbType.VarChar, 20)).Value = objEnt.visitaNumeroDocumento
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.idInterno
                    .Parameters.Add(New SqlParameter("@c_int_ape_nom", SqlDbType.VarChar, 150)).Value = objEnt.internoApellidosNombres
                    .Parameters.Add(New SqlParameter("@fk_par_id", SqlDbType.Int)).Value = objEnt.idParentesco
                    .Parameters.Add(New SqlParameter("@f_fec_reg", SqlDbType.DateTime2)).Value = objEnt.fechaRegistro
                    .Parameters.Add(New SqlParameter("@n_tip_paq", SqlDbType.SmallInt)).Value = objEnt.tipoPaquete
                    .Parameters.Add(New SqlParameter("@n_tip_pre", SqlDbType.SmallInt)).Value = objEnt.tipoPresentacion
                    .Parameters.Add(New SqlParameter("@fk_tip_art_id", SqlDbType.Int)).Value = objEnt.idTipoArticulo
                    .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.Int)).Value = objEnt.idRegion
                    .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.Int)).Value = objEnt.idPenal
                    '/*filtros*/
                    .Parameters.Add(New SqlParameter("@f_fecha_ini", SqlDbType.DateTime2)).Value = objEnt.fechaInicio
                    .Parameters.Add(New SqlParameter("@f_fecha_fin", SqlDbType.DateTime2)).Value = objEnt.fechaFin
                    .Parameters.Add(New SqlParameter("@vis_tip_doc_id", SqlDbType.SmallInt)).Value = objEnt.idVisitaTipoDocumento
                    .Parameters.Add(New SqlParameter("@int_num_doc", SqlDbType.VarChar, 20)).Value = objEnt.internoNumeroDocumento

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Seguridad.Paquetes.Registro) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_reg_pqt_id", SqlDbType.Int)).Value = objEnt.codigo
                            .Parameters.Add(New SqlParameter("@fk_vis_id", SqlDbType.Int)).Value = objEnt.idVisita
                            .Parameters.Add(New SqlParameter("@c_vis_ape_nom", SqlDbType.VarChar, 150)).Value = objEnt.visitaApellidosNombres
                            .Parameters.Add(New SqlParameter("@c_vis_num_doc", SqlDbType.VarChar, 20)).Value = objEnt.visitaNumeroDocumento
                            .Parameters.Add(New SqlParameter("@n_tip_int", SqlDbType.SmallInt)).Value = objEnt.tipoInterno
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.idInterno
                            .Parameters.Add(New SqlParameter("@fk_int_id_pj", SqlDbType.Int)).Value = objEnt.idInternoPJ
                            .Parameters.Add(New SqlParameter("@c_int_ape_nom", SqlDbType.VarChar, 150)).Value = objEnt.internoApellidosNombres
                            .Parameters.Add(New SqlParameter("@fk_par_id", SqlDbType.Int)).Value = objEnt.idParentesco
                            .Parameters.Add(New SqlParameter("@f_fec_reg", SqlDbType.DateTime2)).Value = objEnt.fechaRegistro
                            .Parameters.Add(New SqlParameter("@n_tip_paq", SqlDbType.SmallInt)).Value = objEnt.tipoPaquete
                            .Parameters.Add(New SqlParameter("@n_tip_pre", SqlDbType.SmallInt)).Value = objEnt.tipoPresentacion
                            .Parameters.Add(New SqlParameter("@c_tip_pre_otr", SqlDbType.VarChar, 50)).Value = objEnt.tipoPresentacionNombre
                            .Parameters.Add(New SqlParameter("@fk_tip_art_id", SqlDbType.Int)).Value = objEnt.idTipoArticulo
                            .Parameters.Add(New SqlParameter("@n_pes", SqlDbType.SmallInt)).Value = objEnt.peso
                            .Parameters.Add(New SqlParameter("@n_num_ele", SqlDbType.SmallInt)).Value = objEnt.numeroElementos
                            .Parameters.Add(New SqlParameter("@b_env_din", SqlDbType.Bit)).Value = objEnt.entregaDinero
                            .Parameters.Add(New SqlParameter("@n_mon_din", SqlDbType.Decimal, 2)).Value = objEnt.montoDinero
                            .Parameters.Add(New SqlParameter("@b_env_med", SqlDbType.Bit)).Value = objEnt.entregaMedicamento
                            .Parameters.Add(New SqlParameter("@c_aut_num_doc", SqlDbType.VarChar, 20)).Value = objEnt.autorizacionNumDoc

                            If objEnt.autorizacionFechaDoc > 0 Then
                                .Parameters.Add(New SqlParameter("@f_fec_doc", SqlDbType.DateTime2)).Value = Date.FromFileTime(objEnt.autorizacionFechaDoc)
                            Else
                                .Parameters.Add(New SqlParameter("@f_fec_doc", SqlDbType.DateTime2)).Value = DBNull.Value
                            End If

                            .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.VarChar, 500)).Value = objEnt.observacion
                            .Parameters.Add(New SqlParameter("@fk_fot_pqt_id", SqlDbType.Int)).Value = objEnt.idFotoPaquete
                            .Parameters.Add(New SqlParameter("@c_nom_arc_fot", SqlDbType.VarChar, 100)).Value = objEnt.nombreFotoPaquete

                            .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.Int)).Value = objEnt.idRegion
                            .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.Int)).Value = objEnt.idPenal
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal codigo As Integer, idUsuario As Integer) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_reg_pqt_id", SqlDbType.Int)).Value = codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = idUsuario
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
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
End Namespace