Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.General
    Public Class Delito
        Private Shared strNameProcedure As String = "UP_GEN_Delito"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String,
                                            ByVal objEnt As Entity.Mantenimiento.General.Delito) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = objEnt.DelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.Int)).Value = objEnt.DelitoGenericoID
                            .Parameters.Add(New SqlParameter("@del_gen_cod", SqlDbType.VarChar, 10)).Value = objEnt.DelitoGenericoCodigo
                            .Parameters.Add(New SqlParameter("@del_esp_cod", SqlDbType.VarChar, 15)).Value = objEnt.DelitoEspecificoCodigo
                            .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 255)).Value = objEnt.DelitoEspecificoNombre

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
                                          ByVal objEnt As Entity.Mantenimiento.General.Delito) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@del_tip_id", SqlDbType.SmallInt)).Value = objEnt.DelitoTipoID
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.SmallInt)).Value = objEnt.DelitoGenericoID
                    .Parameters.Add(New SqlParameter("@del_cap_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoCapitulo
                    .Parameters.Add(New SqlParameter("@del_sec_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoSeccion
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.SmallInt)).Value = objEnt.DelitoEspecificoID

                    .Parameters.Add(New SqlParameter("@del_gen_nom", SqlDbType.VarChar, 50)).Value = objEnt.DelitoGenericoNombre
                    .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 50)).Value = objEnt.DelitoEspecificoNombre
                    .Parameters.Add(New SqlParameter("@del_art_nom", SqlDbType.VarChar, 50)).Value = objEnt.DelitoArticulo
                    .Parameters.Add(New SqlParameter("@del_esp_est", SqlDbType.SmallInt)).Value = objEnt.DelitoEspecificoEstado

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Listar_v2(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                          ByVal objEnt As Entity.Mantenimiento.General.Delito) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                    .Parameters.Add(New SqlParameter("@del_tip_id", SqlDbType.SmallInt)).Value = objEnt.DelitoTipoID
                    .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.SmallInt)).Value = objEnt.DelitoGenericoID
                    .Parameters.Add(New SqlParameter("@del_cap_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoCapitulo
                    .Parameters.Add(New SqlParameter("@del_sec_id", SqlDbType.SmallInt)).Value = objEnt.IDDelitoSeccion
                    .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.SmallInt)).Value = objEnt.DelitoEspecificoID

                    .Parameters.Add(New SqlParameter("@del_gen_nom", SqlDbType.VarChar, 50)).Value = objEnt.DelitoGenericoNombre
                    .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 50)).Value = objEnt.DelitoEspecificoNombre
                    .Parameters.Add(New SqlParameter("@del_art_nom", SqlDbType.VarChar, 50)).Value = objEnt.DelitoArticulo
                    .Parameters.Add(New SqlParameter("@del_esp_est", SqlDbType.SmallInt)).Value = objEnt.DelitoEspecificoEstado
                    .Parameters.Add(New SqlParameter("@del_grp_gen_nom", SqlDbType.VarChar, 100)).Value = objEnt.DelitoGrupoGenericoNombre
                    .Parameters.Add(New SqlParameter("@del_grp_esp_nom", SqlDbType.VarChar, 100)).Value = objEnt.DelitoGrupoEspecificoNombre
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ObjEnt As Entity.Mantenimiento.General.Delito) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = ObjEnt.DelitoEspecificoID
                            .Parameters.Add(New SqlParameter("@del_esp_cod", SqlDbType.VarChar, 10)).Value = ObjEnt.DelitoEspecificoCodigo
                            .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 200)).Value = ObjEnt.DelitoEspecificoNombre
                            .Parameters.Add(New SqlParameter("@del_art_nom", SqlDbType.VarChar, 50)).Value = ObjEnt.DelitoArticulo
                            .Parameters.Add(New SqlParameter("@del_esp_obs", SqlDbType.VarChar, 500)).Value = ObjEnt.DelitoEspObs
                            .Parameters.Add(New SqlParameter("@del_esp_des_mot_baj", SqlDbType.VarChar, 500)).Value = ObjEnt.DelitoEspMotivoBaja
                            .Parameters.Add(New SqlParameter("@del_esp_est", SqlDbType.SmallInt)).Value = ObjEnt.DelitoEspecificoEstado
                            .Parameters.Add(New SqlParameter("@del_tip_id", SqlDbType.SmallInt)).Value = ObjEnt.DelitoTipoID
                            .Parameters.Add(New SqlParameter("@del_gen_id", SqlDbType.SmallInt)).Value = ObjEnt.DelitoGenericoID
                            .Parameters.Add(New SqlParameter("@del_gen_cod", SqlDbType.VarChar, 10)).Value = ObjEnt.DelitoGenericoCodigo
                            .Parameters.Add(New SqlParameter("@del_cap_id", SqlDbType.SmallInt)).Value = ObjEnt.IDDelitoCapitulo
                            .Parameters.Add(New SqlParameter("@del_esp_cap_cod", SqlDbType.VarChar, 10)).Value = ObjEnt.DelitoCapituloCodigo
                            .Parameters.Add(New SqlParameter("@del_sec_id", SqlDbType.SmallInt)).Value = ObjEnt.IDDelitoSeccion
                            .Parameters.Add(New SqlParameter("@del_esp_sec_cod", SqlDbType.VarChar, 10)).Value = ObjEnt.DelitoSeccionCodigo
                            .Parameters.Add(New SqlParameter("@del_esp_id_pdr", SqlDbType.SmallInt)).Value = ObjEnt.IDDelitoEspecificoPadre
                            .Parameters.Add(New SqlParameter("@del_esp_pdr_cod", SqlDbType.VarChar, 10)).Value = ObjEnt.DelitoEspecificoPadreCodigo

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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@del_esp_id", SqlDbType.Int)).Value = Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
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

    End Class

End Namespace