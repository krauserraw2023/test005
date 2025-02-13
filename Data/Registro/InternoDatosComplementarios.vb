Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoDatosComplementarios
        Private Shared strNameProcedure As String = "usp_reg_int_mov_interno_datos_complementarios"
        'Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.InternoDatosComplementarios) As Integer
        '    Try
        '        Dim Value As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@pk_int_dat_com_id", SqlDbType.Int)).Value = objEnt.Codigo
        '                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.IDInterno
        '                    .Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objEnt.IDGrupoPueblo
        '                    .Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objEnt.IDPueblo
        '                    .Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, 100)).Value = objEnt.OtroPueblo
        '                    .Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objEnt.IDGrupoLenguaMaterna
        '                    .Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objEnt.IDLenguaMaterna
        '                    .Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objEnt.IDIdioma

        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    Value = .Parameters("@variable_out").Value
        '                    Return Value
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Registro.InternoDatosComplementarios) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_int_dat_com_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.IDInterno
                    '.Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objEnt.IDGrupoPueblo
                    '.Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objEnt.IDPueblo
                    '.Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, 100)).Value = objEnt.OtroPueblo
                    '.Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objEnt.IDGrupoLenguaMaterna
                    '.Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objEnt.IDLenguaMaterna
                    '.Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objEnt.IDIdioma
                    '.Parameters.Add(New SqlParameter("@_fecha", SqlDbType.DateTime2)).Value = Now()
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Registro.InternoDatosComplementarios) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_dat_com_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@fk_int_id", SqlDbType.Int)).Value = objEnt.IDInterno
                            .Parameters.Add(New SqlParameter("@n_es_pbl_etc", SqlDbType.SmallInt)).Value = objEnt.pertenecePueblo
                            .Parameters.Add(New SqlParameter("@fk_grp_pbl_id", SqlDbType.Int)).Value = objEnt.IDGrupoPueblo
                            .Parameters.Add(New SqlParameter("@fk_pbl_id", SqlDbType.Int)).Value = objEnt.IDPueblo
                            .Parameters.Add(New SqlParameter("@n_otr_pbl", SqlDbType.VarChar, 100)).Value = objEnt.OtroPueblo
                            .Parameters.Add(New SqlParameter("@fk_grp_lga_mat_id", SqlDbType.Int)).Value = objEnt.IDGrupoLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_lga_mat_id", SqlDbType.Int)).Value = objEnt.IDLenguaMaterna
                            .Parameters.Add(New SqlParameter("@fk_idm_id", SqlDbType.Int)).Value = objEnt.IDIdioma
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.SmallInt)).Value = objEnt.idRegion
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.SmallInt)).Value = objEnt.idPenal

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_int_dat_com_id", SqlDbType.Int)).Value = Codigo

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
End Namespace