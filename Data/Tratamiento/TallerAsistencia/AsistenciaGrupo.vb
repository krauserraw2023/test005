Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia

    Public Class AsistenciaGrupo
        Private Shared strNameProcedure As String = "USP_tra_tal_mov_InternoAsistencia"

#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, _
                                              ByVal opcion As String, objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEnt.PenalID
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
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objInt As Entity.Registro.Interno) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandTimeout = 300
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objInt.Codigo
                            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInt.CodigoRP
                            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@int_doc_num_aux", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumentoAux
                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInt.Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objInt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objInt.PenalID

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
        Public Shared Function ListarAfiliacion(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                              ByVal opcion As String, objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 3000
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@n_sol_num", SqlDbType.Int)).Value = objEnt.NumeroSol
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@fechabusIni", SqlDbType.BigInt)).Value = objEnt.FechaInicioBusqueda
                    .Parameters.Add(New SqlParameter("@fechabus", SqlDbType.BigInt)).Value = objEnt.FechaBusqueda
                    .Parameters.Add(New SqlParameter("@anio", SqlDbType.Int)).Value = objEnt.Anio
                    .Parameters.Add(New SqlParameter("@mes", SqlDbType.Int)).Value = objEnt.Mes
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Tratamiento.TallerAsistencia.InternoAsistencia) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.VarChar, 20)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 100)).Value = objEnt.ApellidosNombres
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 100)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 100)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.VarChar, 100)).Value = objEnt.Fecha
                    .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.VarChar, 100)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@fechabusIni", SqlDbType.BigInt)).Value = objEnt.FechaInicioBusqueda
                    .Parameters.Add(New SqlParameter("@fechabusFin", SqlDbType.BigInt)).Value = objEnt.FechaFinBusqueda
                    Try
                    Catch ex As Exception
                    End Try
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        '/*Para busqueda SIS 07/09/2017 J.E.U*/
        Public Shared Function ListarNombresAsociados(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                     ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_Interno_Grilla", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id_str", SqlDbType.VarChar)).Value = objEnt.IDInternoString
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.IDTipoDocIdentidad
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.InternoNumeroDocumento
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.IDSexo
                    '.Parameters.Add(New SqlParameter("@afi_sis", SqlDbType.Int)).Value = objEnt.Afiliacion
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.IDNacionalidad
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.IDInternoEstado
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 1000)).Value = objEnt.IDPenalString

                    '/*ingresos*/                    
                    .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin
                    '/*delitos*/
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.IDDelitoGenerico
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.IDDelitoEspecifico
                    '/*nombres asociados*/
                    .Parameters.Add(New SqlParameter("@int_aso_pri", SqlDbType.Int)).Value = objEnt.NombreAsociadoPrincipal
                    .Parameters.Add(New SqlParameter("@int_aso_est", SqlDbType.Int)).Value = objEnt.NombreAsociadoEstado
                    .Parameters.Add(New SqlParameter("@n_afi_est_id", SqlDbType.Int)).Value = objEnt.IDAfiliacion

                End With
                'sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                sqlReader = sqlCmd.ExecuteReader()
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                             ByVal opcion As String, objEnt As Entity.Registro.Interno) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objEnt.PenalID
                    '.Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = objEnt.PenalMultiple

                    '.Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                    '.Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.IngresoFechaDesde
                    '.Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.IngresoFechaHasta
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

#End Region

#Region "Grabar"

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objAsistencia As Entity.Tratamiento.TallerAsistencia.AsistenciaGrupo) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_tal_asi_id", SqlDbType.Int)).Value = objAsistencia.Codigo
                            .Parameters.Add(New SqlParameter("@pk_tal_asi_id", SqlDbType.Int)).Value = objAsistencia.CodigoTaller
                            .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.BigInt)).Value = objAsistencia.Nombre
                            .Parameters.Add(New SqlParameter("@c_tal_asi_hor_ent", SqlDbType.VarChar, 20)).Value = objAsistencia.FechaInicio
                            .Parameters.Add(New SqlParameter("@c_tal_asi_hor_sal", SqlDbType.VarChar, 20)).Value = objAsistencia.FechaFin
                            .Parameters.Add(New SqlParameter("@fk_reg_id", SqlDbType.Int)).Value = objAsistencia.RegionID
                            .Parameters.Add(New SqlParameter("@fk_pen_id", SqlDbType.Int)).Value = objAsistencia.PenalID

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
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

        Public Shared Function Eliminar_x_ingreso(ByVal accion As String, ByVal opcion As String, ByVal ingresoId As Integer, FlagTransferenciaSede As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = ingresoId
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
#Region "UP_INT_Interno_Nombres_Asociados"

        Public Shared Function ListarNombresAsociados_v2(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                      ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_Interno_Nombres_Asociados", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id_str", SqlDbType.VarChar)).Value = objEnt.IDInternoString
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                    .Parameters.Add(New SqlParameter("@int_nom_ali", SqlDbType.VarChar, 50)).Value = objEnt.InternoAlias
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.IDSexo
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.Int)).Value = objEnt.NacionalidadExtranjero
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.IDNacionalidad
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.IDInternoEstado
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 1000)).Value = objEnt.IDPenalString

                    '/*ingresos*/                    
                    .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin
                    '/*delitos*/
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.IDDelitoGenerico
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.IDDelitoEspecifico
                    '/*nombres asociados*/
                    .Parameters.Add(New SqlParameter("@int_aso_pri", SqlDbType.Int)).Value = objEnt.NombreAsociadoPrincipal
                    .Parameters.Add(New SqlParameter("@int_aso_est", SqlDbType.Int)).Value = objEnt.NombreAsociadoEstado

                End With
                'sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                sqlReader = sqlCmd.ExecuteReader()
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function


        ''/*Para busqueda SIS 07/09/2017 J.E.U*/
        'Public Shared Function ListarNombresAsociados_sis(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        '                             ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_Interno_Nombres_Asociados", sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandTimeout = 300
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_id_str", SqlDbType.VarChar)).Value = objEnt.IDInternoString
        '            .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
        '            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
        '            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
        '            .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
        '            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
        '            .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.IDTipoDocIdentidad
        '            .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.InternoNumeroDocumento
        '            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.IDSexo
        '            '.Parameters.Add(New SqlParameter("@afi_sis", SqlDbType.Int)).Value = objEnt.Afiliacion
        '            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.IDNacionalidad
        '            .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.IDInternoEstado
        '            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.IDRegion
        '            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.IDPenal
        '            .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 1000)).Value = objEnt.IDPenalString

        '            '/*ingresos*/                    
        '            .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
        '            .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin
        '            '/*delitos*/
        '            .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.IDDelitoGenerico
        '            .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.IDDelitoEspecifico
        '            '/*nombres asociados*/
        '            .Parameters.Add(New SqlParameter("@int_aso_pri", SqlDbType.Int)).Value = objEnt.NombreAsociadoPrincipal
        '            .Parameters.Add(New SqlParameter("@int_aso_est", SqlDbType.Int)).Value = objEnt.NombreAsociadoEstado

        '        End With
        '        'sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '        sqlReader = sqlCmd.ExecuteReader()
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader

        'End Function
#End Region
#Region "UP_INT_Interno_Grilla"
        Public Shared Function ListarGrilla(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal CodigoRP As String, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, ByVal PenalMultiple As String, _
        ByVal SexoID As Integer, _
        ByVal NacionalidadID As Integer, _
        ByVal EstadoID As Integer, _
        ByVal SituacionJuridicaID As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_Interno_Grilla", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = Nombres
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = PenalMultiple
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = SexoID
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = NacionalidadID
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = EstadoID
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = SituacionJuridicaID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
        Public Shared Function ListarGrilla(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_Interno_Grilla", sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.IDInterno
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.InternoCodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.PrimerApellido
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.SegundoApellido
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.PreNombres
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.SmallInt)).Value = objEnt.IDSexo
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.IDNacionalidad
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.SmallInt)).Value = objEnt.IDInternoEstado
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.SmallInt)).Value = objEnt.IDSituacionJuridica
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.IDRegion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.IDPenal
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 500)).Value = objEnt.IDPenalString
                    .Parameters.Add(New SqlParameter("@n_car_est_trs_id", SqlDbType.SmallInt)).Value = objEnt.TrasladadoDeCarceleta

                    '/*movimiento*/
                    .Parameters.Add(New SqlParameter("@mov_grp_id", SqlDbType.SmallInt)).Value = objEnt.IDGrupoMovimiento
                    .Parameters.Add(New SqlParameter("@mov_tip_id", SqlDbType.SmallInt)).Value = objEnt.IDTipoMovimiento
                    .Parameters.Add(New SqlParameter("@mov_mot_id", SqlDbType.SmallInt)).Value = objEnt.IDMotivoMovimiento
                    '/*fecha ini y fin*/
                    .Parameters.Add(New SqlParameter("@tip_fec", SqlDbType.SmallInt)).Value = objEnt.TipoFecha
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIngresoIni
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaIngresoFin

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
#End Region
    End Class
End Namespace
