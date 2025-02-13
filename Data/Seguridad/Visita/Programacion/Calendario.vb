Imports System.Data
Imports System.Data.SqlClient
Namespace Visita.Programacion
    Public Class Calendario
        Private Shared strNameProcedure As String = "UP_VIS_Calendario"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.Calendario) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEnt.RegimenVisitaID
                            .Parameters.Add(New SqlParameter("@vis_tip_id", SqlDbType.SmallInt)).Value = objEnt.VisitaTipoID

                            .Parameters.Add(New SqlParameter("@cal_est", SqlDbType.SmallInt)).Value = objEnt.Estado

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.Calendario) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.int)).Value = ObjEnt.RegionID
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.int)).Value = ObjEnt.PenalID
                    .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.smallint)).Value = ObjEnt.RegimenVisitaID
                    .Parameters.Add(New SqlParameter("@vis_tip_id", SqlDbType.smallint)).Value = ObjEnt.VisitaTipoID                    
                    .Parameters.Add(New SqlParameter("@cal_fec_reg", SqlDbType.BigInt)).Value = objEnt.FechaRegistro
                    .Parameters.Add(New SqlParameter("@cal_est", SqlDbType.smallint)).Value = ObjEnt.Estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.Calendario) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@reg_vis_id", SqlDbType.SmallInt)).Value = objEnt.RegimenVisitaID
                            .Parameters.Add(New SqlParameter("@vis_tip_id", SqlDbType.SmallInt)).Value = objEnt.VisitaTipoID
                            .Parameters.Add(New SqlParameter("@cal_fec_reg", SqlDbType.BigInt)).Value = objEnt.FechaRegistro
                            .Parameters.Add(New SqlParameter("@cal_est", SqlDbType.SmallInt)).Value = objEnt.Estado
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.Programacion.Calendario) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_id", SqlDbType.Int)).Value = objEnt.CalendarioID

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