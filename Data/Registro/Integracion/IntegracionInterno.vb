Imports System.Data.SqlClient

Namespace Registro.Integracion
    Public Class IntegracionInterno
        Private Shared strNameProcedure As String = "pa_int_mov_integracion_interno"

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      objEnt As Entity.Registro.Integracion.IntegracionInterno) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_reg_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_cod_uni_id", SqlDbType.Int)).Value = objEnt.CodigoUnicoInternoId
                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 50)).Value = objEnt.NumeroDocumentoStr
                    .Parameters.Add(New SqlParameter("@c_cod_usr", SqlDbType.VarChar, 100)).Value = objEnt.CodigoUsrUsuario
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaIntegracionIni
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaIntegracionFin
                    .Parameters.Add(New SqlParameter("@c_tip_nac", SqlDbType.VarChar, 1)).Value = objEnt.TipoNacionalidadStr
                    .Parameters.Add(New SqlParameter("@n_cod_sec_uni", SqlDbType.Int)).Value = objEnt.CodigoUnicoSecuencial

                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 50)).Value = objEnt.InternoCodigoRP
                    .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 100)).Value = objEnt.InternoApePaterno
                    .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 100)).Value = objEnt.InternoApeMaterno
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.InternoNombres
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(sqlCmd As SqlCommand, ByVal accion As String, ByVal opcion As String,
                                       ByVal objEnt As Entity.Registro.Integracion.IntegracionInterno) As Integer
            Dim intCodigo As Integer = -1
            Try
                sqlCmd.CommandText = strNameProcedure
                sqlCmd.CommandType = CommandType.StoredProcedure
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@pk_int_reg_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_cod_uni_id", SqlDbType.Int)).Value = objEnt.CodigoUnicoInternoId
                    .Parameters.Add(New SqlParameter("@c_num_doc", SqlDbType.VarChar, 50)).Value = objEnt.NumeroDocumentoStr
                    .Parameters.Add(New SqlParameter("@c_cod_usr", SqlDbType.VarChar, 100)).Value = objEnt.CodigoUsrUsuario
                    .Parameters.Add(New SqlParameter("@c_usu_ape", SqlDbType.VarChar, 100)).Value = objEnt.UsuarioApellidos
                    .Parameters.Add(New SqlParameter("@c_usu_nom", SqlDbType.VarChar, 100)).Value = objEnt.UsuarioNombres
                    .Parameters.Add(New SqlParameter("c_mot_int", SqlDbType.VarChar, 250)).Value = objEnt.MotivoIntegracion
                    .Parameters.Add(New SqlParameter("@c_obs", SqlDbType.Text)).Value = objEnt.Observacion
                    .Parameters.Add(New SqlParameter("@fec_ini", SqlDbType.Int)).Value = objEnt.FechaIntegracionIni
                    .Parameters.Add(New SqlParameter("@fec_fin", SqlDbType.Int)).Value = objEnt.FechaIntegracionFin
                    '.Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionId
                    '.Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalId

                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                    Return intCodigo
                End With

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return -1
        End Function

        Public Shared Function Eliminar(sqlCmd As SqlCommand, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef outSms As String) As Integer
            Dim intCodigo As Integer = -1

            Try
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_reg_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                    .ExecuteNonQuery()
                    intCodigo = .Parameters("@variable_out").Value
                End With
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return intCodigo
        End Function
    End Class
End Namespace