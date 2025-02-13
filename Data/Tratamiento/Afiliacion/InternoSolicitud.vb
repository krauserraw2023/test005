Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.Afiliacion

    Public Class InternoSolicitud
        Private Shared strNameProcedure As String = "pa_tra_sis_cab_solicitud"

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
                            .Parameters.Add(New SqlParameter("@anio", SqlDbType.Int)).Value = objEnt.Anio
                            .Parameters.Add(New SqlParameter("@mes", SqlDbType.Int)).Value = objEnt.Mes
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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
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
                    .Parameters.Add(New SqlParameter("@fechabusIni", SqlDbType.BigInt)).Value = objEnt.FechaInicioBusqueda
                    .Parameters.Add(New SqlParameter("@fechabusFin", SqlDbType.BigInt)).Value = objEnt.FechaBusqueda
                    .Parameters.Add(New SqlParameter("@anio", SqlDbType.Int)).Value = objEnt.Anio
                    .Parameters.Add(New SqlParameter("@mes", SqlDbType.Int)).Value = objEnt.Mes

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

        Public Shared Function ListarRes(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      objEnt As Entity.Tratamiento.Afiliacion.InternoSolicitud) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_n_sol_id", SqlDbType.Int)).Value = objEnt.CodigoSolicitud
                    .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objEnt.RegionID

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

        ''/*Para busqueda SIS 07/09/2017 J.E.U*/
        'Public Shared Function ListarNombresAsociadosSIS(ByVal sqlCon As SqlConnection, ByVal accion As String, _
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
        '            .Parameters.Add(New SqlParameter("@n_afi_est_id", SqlDbType.Int)).Value = objEnt.IDAfiliacion

        '        End With
        '        'sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '        sqlReader = sqlCmd.ExecuteReader()
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader

        'End Function
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
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.Apellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@pen_id_str", SqlDbType.VarChar, 250)).Value = objEnt.PenalMultiple
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@int_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                    .Parameters.Add(New SqlParameter("@ubg_id_nac", SqlDbType.Int)).Value = objEnt.NacimientoUbigeoID
                    .Parameters.Add(New SqlParameter("@nac_ext", SqlDbType.Int)).Value = objEnt.NacionalidadExtranjero
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenericoID
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoID
                    .Parameters.Add(New SqlParameter("@sit_jur_id", SqlDbType.Int)).Value = objEnt.SituacionJuridicaId
                    .Parameters.Add(New SqlParameter("@fec_ing_dsd", SqlDbType.BigInt)).Value = objEnt.IngresoFechaDesde
                    .Parameters.Add(New SqlParameter("@fec_ing_hst", SqlDbType.BigInt)).Value = objEnt.IngresoFechaHasta
                  
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function

#End Region

#Region "Grabar"

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objInterno As Entity.Tratamiento.Afiliacion.InternoSolicitud) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_n_sol_id", SqlDbType.Int)).Value = objInterno.CodigoSolicitud
                            '.Parameters.Add(New SqlParameter("@pk_afi_id", SqlDbType.Int)).Value = objInterno.CodigoAfiliacion
                            .Parameters.Add(New SqlParameter("@n_sol_est_id", SqlDbType.Int)).Value = objInterno.EstadoID
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objInterno.InternoID
                            .Parameters.Add(New SqlParameter("@RegionId", SqlDbType.Int)).Value = objInterno.RegionID
                            .Parameters.Add(New SqlParameter("@PenalId", SqlDbType.Int)).Value = objInterno.PenalID
                            .Parameters.Add(New SqlParameter("@RegionRegId", SqlDbType.Int)).Value = objInterno.RegionRegistroID
                            .Parameters.Add(New SqlParameter("@PenalRegId", SqlDbType.Int)).Value = objInterno.PenalRegistroID
                            .Parameters.Add(New SqlParameter("@n_sol_fec_reg", SqlDbType.BigInt)).Value = objInterno.FechaRegistro
                            .Parameters.Add(New SqlParameter("@n_sol_fec_env", SqlDbType.BigInt)).Value = objInterno.FechaEnvio
                            .Parameters.Add(New SqlParameter("@anio", SqlDbType.Int)).Value = objInterno.Anio
                            .Parameters.Add(New SqlParameter("@mes", SqlDbType.Int)).Value = objInterno.Mes
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            '.Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = objInterno.Eliminado
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


    End Class
End Namespace
