Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Autorizacion
        Private Shared strNameProcedure As String = "UP_VIS_Autorizacion"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            ByVal objEnt As Entity.Visita.Autorizacion) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@aut_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitanteID 'ok
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID 'ok
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEnt.ParentescoID
                            .Parameters.Add(New SqlParameter("@aut_tip_id", SqlDbType.SmallInt)).Value = objEnt.TipoID 'ok
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID 'ok
                            .Parameters.Add(New SqlParameter("@aut_est_id", SqlDbType.SmallInt)).Value = objEnt.EstadoID

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Visita.Autorizacion) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@aut_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitanteID
                    .Parameters.Add(New SqlParameter("@aut_tip_id", SqlDbType.SmallInt)).Value = objEnt.TipoID
                    .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID
                    .Parameters.Add(New SqlParameter("@aut_doc", SqlDbType.VarChar, 50)).Value = objEnt.Documento
                    .Parameters.Add(New SqlParameter("@aut_doc_fec", SqlDbType.BigInt)).Value = objEnt.Fecha                    
                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEnt.ParentescoID
                    .Parameters.Add(New SqlParameter("@aut_est_id", SqlDbType.SmallInt)).Value = objEnt.EstadoID
                    '/*internos*/
                    .Parameters.Add(New SqlParameter("@int_cod_rp", SqlDbType.VarChar, 50)).Value = objEnt.InternoCodigo
                    .Parameters.Add(New SqlParameter("@int_doc_num", SqlDbType.VarChar, 50)).Value = objEnt.InternoNumeroDocumento
                    .Parameters.Add(New SqlParameter("@int_ape", SqlDbType.VarChar, 100)).Value = objEnt.InternoApellidos
                    .Parameters.Add(New SqlParameter("@int_nom", SqlDbType.VarChar, 100)).Value = objEnt.InternoNombres

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Visita.Autorizacion) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@aut_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.InternoApeNom
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitanteID
                            .Parameters.Add(New SqlParameter("@vis_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.VisitanteApeNom
                            .Parameters.Add(New SqlParameter("@aut_tip_id", SqlDbType.SmallInt)).Value = objEnt.TipoID
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = objEnt.CalendarioDetalleID
                            .Parameters.Add(New SqlParameter("@aut_doc", SqlDbType.VarChar, 50)).Value = objEnt.Documento
                            .Parameters.Add(New SqlParameter("@aut_doc_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            '.Parameters.Add(New SqlParameter("@aut_fec_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                            '.Parameters.Add(New SqlParameter("@aut_fec_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEnt.ParentescoID
                            .Parameters.Add(New SqlParameter("@aut_est_id", SqlDbType.SmallInt)).Value = objEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@aut_obs", SqlDbType.VarChar, 500)).Value = objEnt.Observacion

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, _
                                        ByVal objEnt As Entity.Visita.Autorizacion) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@aut_id", SqlDbType.Int)).Value = objEnt.Codigo

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
    End Class
End Namespace