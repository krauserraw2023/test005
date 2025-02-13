Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class InternoEtapa
        Private Shared strNameProcedure As String = "UP_VIS_InternoEtapa"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.InternoEtapa) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_etp_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.Int)).Value = objEnt.EtapaID
                            .Parameters.Add(New SqlParameter("@int_etp_doc", SqlDbType.VarChar, 200)).Value = objEnt.Documento
                            .Parameters.Add(New SqlParameter("@int_etp_doc_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoFecha
                            .Parameters.Add(New SqlParameter("@int_etp_obs", SqlDbType.VarChar, 200)).Value = objEnt.Obs
                            .Parameters.Add(New SqlParameter("@int_etp_est", SqlDbType.SmallInt)).Value = objEnt.Estado

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.InternoEtapa) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_etp_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.InternoApellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.InternoApeNom
                    .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.int)).Value = ObjEnt.EtapaID
                    .Parameters.Add(New SqlParameter("@int_etp_doc", SqlDbType.varchar, 200)).Value = ObjEnt.Documento
                    .Parameters.Add(New SqlParameter("@int_etp_doc_fec", SqlDbType.bigint)).Value = ObjEnt.DocumentoFecha                    
                    .Parameters.Add(New SqlParameter("@int_etp_est", SqlDbType.smallint)).Value = ObjEnt.Estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.InternoEtapa) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_etp_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID

                            .Parameters.Add(New SqlParameter("@int_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.InternoApePaterno
                            .Parameters.Add(New SqlParameter("@int_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.InternoApeMaterno
                            .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 50)).Value = objEnt.InternoNombres

                            .Parameters.Add(New SqlParameter("@etp_id", SqlDbType.Int)).Value = objEnt.EtapaID
                            .Parameters.Add(New SqlParameter("@int_etp_fec_reg", SqlDbType.BigInt)).Value = objEnt.FechaRegistro
                            .Parameters.Add(New SqlParameter("@int_etp_doc", SqlDbType.VarChar, 200)).Value = objEnt.Documento
                            .Parameters.Add(New SqlParameter("@int_etp_doc_fec", SqlDbType.BigInt)).Value = objEnt.DocumentoFecha
                            .Parameters.Add(New SqlParameter("@int_etp_obs", SqlDbType.VarChar, 200)).Value = objEnt.Obs
                            .Parameters.Add(New SqlParameter("@int_etp_est", SqlDbType.SmallInt)).Value = objEnt.Estado

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.InternoEtapa) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_etp_id", SqlDbType.Int)).Value = objEnt.Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
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
