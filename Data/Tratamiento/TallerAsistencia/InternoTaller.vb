Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia

    Public Class InternoTaller
        Private Shared strNameProcedure As String = "usp_tra_tal_mov_InternoTaller"

#Region "Listar"

        'Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, objInt As Entity.Registro.Interno) As Integer
        '    Try
        '        Dim intValue As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandTimeout = 300
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objInt.Codigo
        '                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 20)).Value = objInt.CodigoRP
        '                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objInt.TipoDocumentoID
        '                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumento
        '                    .Parameters.Add(New SqlParameter("@int_doc_num_aux", SqlDbType.VarChar, 50)).Value = objInt.NumeroDocumentoAux
        '                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoPaterno
        '                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objInt.ApellidoMaterno
        '                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 150)).Value = objInt.Nombres
        '                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objInt.RegionID
        '                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objInt.PenalID

        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    intValue = .Parameters("@variable_out").Value
        '                    Return intValue
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, objEnt As Entity.Tratamiento.TallerAsistencia.InternoTaller) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 10)).Value = objEnt.CodigoRP
                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.VarChar, 50)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 100)).Value = objEnt.ApellidosNombres
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@tip_doc_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.SmallInt)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.SmallInt)).Value = objEnt.NacionalidadID
                    .Parameters.Add(New SqlParameter("@pk_tra_tal_id", SqlDbType.Int)).Value = objEnt.CodigoTaller
                    .Parameters.Add(New SqlParameter("@pk_tal_int_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@pk_tra_tal_tip_act_id", SqlDbType.Int)).Value = objEnt.CodigoTipoActividad
                    .Parameters.Add(New SqlParameter("@pk_tra_tal_act_id", SqlDbType.Int)).Value = objEnt.CodigoActividad
                    .Parameters.Add(New SqlParameter("@c_tra_tal_nom", SqlDbType.VarChar, 100)).Value = objEnt.NombreTaller

                    .Parameters.Add(New SqlParameter("@n_tal_asi_fec", SqlDbType.VarChar, 100)).Value = objEnt.Fecha
                    .Parameters.Add(New SqlParameter("@tra_asi_tal_int_est", SqlDbType.Int)).Value = objEnt.EstadoLaboralID
                    .Parameters.Add(New SqlParameter("@int_est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.VarChar, 100)).Value = objEnt.PenalID
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
            Dim abc As Integer = sqlReader.FieldCount
            Return sqlReader
        End Function

        '/*Para busqueda SIS 07/09/2017 J.E.U*/
        'Public Shared Function ListarNombresAsociados(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        '                             ByVal opcion As String, ByVal objEnt As Entity.Registro.Interno_Grilla) As SqlDataReader

        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand("UP_INT_Interno_Grilla", sqlCon)
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

#End Region
#Region "Grabar"

        'Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objIntTal As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Integer
        '    Try
        '        Dim intCodigo As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@pk_tal_int_id", SqlDbType.Int)).Value = objIntTal.Codigo
        '                    .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.BigInt)).Value = objIntTal.CodigoTaller
        '                    .Parameters.Add(New SqlParameter("@tra_asi_tal_int_fec", SqlDbType.BigInt)).Value = objIntTal.Fecha
        '                    .Parameters.Add(New SqlParameter("@tra_asi_tal_int_est", SqlDbType.VarChar, 20)).Value = objIntTal.EstadoID
        '                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objIntTal.InternoID
        '                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objIntTal.RegionID
        '                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objIntTal.PenalID

        '                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
        '                    .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))

        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    intCodigo = .Parameters("@variable_out").Value
        '                    Return intCodigo
        '                End With
        '            End Using

        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function
        Public Shared Function Grabar_v2(ByVal accion As String, ByVal opcion As String, ByVal objIntTal As Entity.Tratamiento.TallerAsistencia.InternoTaller) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_tal_int_id", SqlDbType.Int)).Value = objIntTal.Codigo
                            .Parameters.Add(New SqlParameter("@kf_tal_id", SqlDbType.BigInt)).Value = objIntTal.CodigoTaller
                            .Parameters.Add(New SqlParameter("@tra_asi_tal_int_fec", SqlDbType.BigInt)).Value = objIntTal.Fecha
                            .Parameters.Add(New SqlParameter("@tra_asi_tal_int_fec_fin", SqlDbType.BigInt)).Value = objIntTal.FechaDocumento
                            .Parameters.Add(New SqlParameter("@tra_asi_tal_int_est", SqlDbType.VarChar, 20)).Value = objIntTal.EstadoID
                            .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.Int)).Value = objIntTal.InternoID
                            .Parameters.Add(New SqlParameter("@tra_asi_tal_obs", SqlDbType.VarChar, 250)).Value = objIntTal.Observacion
                            .Parameters.Add(New SqlParameter("@tra_asi_tal_mot_ret", SqlDbType.Int)).Value = objIntTal.MotivoRetiroID
                            .Parameters.Add(New SqlParameter("@tra_asi_tal_doc_ret", SqlDbType.VarChar, 50)).Value = objIntTal.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objIntTal.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objIntTal.PenalID
                            .Parameters.Add(New SqlParameter("@b_reg_vinc_bio", SqlDbType.Bit)).Value = objIntTal.BioRegistroVinculado

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
        'Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer, FlagTransferenciaSede As Integer) As Integer
        '    Try
        '        Dim intCodigo As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = Codigo
        '                    .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = FlagTransferenciaSede

        '                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    intCodigo = .Parameters("@variable_out").Value
        '                    Return intCodigo
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function
    End Class
End Namespace
