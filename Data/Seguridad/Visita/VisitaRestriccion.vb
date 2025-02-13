Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class VisitanteRestriccion
        Private Shared strNameProcedure As String = "UP_VIS_VisitanteRestriccion"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.VisitanteRestriccion) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_res_id", SqlDbType.int)).Value = ObjEnt.Codigo
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitanteID
                            .Parameters.Add(New SqlParameter("@res_tip_id", SqlDbType.Int)).Value = objEnt.RestriccionTipoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID                            
                            .Parameters.Add(New SqlParameter("@vis_res_ini", SqlDbType.bigint)).Value = ObjEnt.FechaInicio
                            .Parameters.Add(New SqlParameter("@vis_res_fin", SqlDbType.bigint)).Value = ObjEnt.FechaFin
                            '.Parameters.Add(New SqlParameter("@vis_res_fec_fin_ind", SqlDbType.bit)).Value = ObjEnt.FechaFinIndeterminado

                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.int)).Value = ObjEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.int))
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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.VisitanteRestriccion) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@vis_res_id", SqlDbType.int)).Value = ObjEnt.Codigo
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.int)).Value = ObjEnt.VisitanteID
                    .Parameters.Add(New SqlParameter("@vis_res_doc", SqlDbType.varchar, 50)).Value = ObjEnt.Documento
                    .Parameters.Add(New SqlParameter("@vis_res_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                    .Parameters.Add(New SqlParameter("@vis_res_ini", SqlDbType.bigint)).Value = ObjEnt.FechaInicio
                    .Parameters.Add(New SqlParameter("@vis_res_fin", SqlDbType.bigint)).Value = ObjEnt.FechaFin
                    .Parameters.Add(New SqlParameter("@vis_res_fec_fin_ind", SqlDbType.bit)).Value = ObjEnt.FechaFinIndeterminado
                    .Parameters.Add(New SqlParameter("@res_tip_id", SqlDbType.int)).Value = ObjEnt.RestriccionTipoID
                    .Parameters.Add(New SqlParameter("@est_id", SqlDbType.int)).Value = ObjEnt.EstadoID
                    .Parameters.Add(New SqlParameter("@vis_res_obs", SqlDbType.varchar, 250)).Value = ObjEnt.Observacion
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.VisitanteRestriccion) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_res_id", SqlDbType.Int)).Value = objEnt.Codigo

                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.SmallInt)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.SmallInt)).Value = objEnt.PenalID

                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitanteID
                            .Parameters.Add(New SqlParameter("@vis_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.VisitanteApeNom
                            .Parameters.Add(New SqlParameter("@res_tip_id", SqlDbType.Int)).Value = objEnt.RestriccionTipoID

                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.InternoApeNom

                            .Parameters.Add(New SqlParameter("@vis_res_doc", SqlDbType.varchar, 50)).Value = ObjEnt.Documento
                            .Parameters.Add(New SqlParameter("@vis_res_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@vis_res_ini", SqlDbType.bigint)).Value = ObjEnt.FechaInicio
                            .Parameters.Add(New SqlParameter("@vis_res_fin", SqlDbType.bigint)).Value = ObjEnt.FechaFin
                            .Parameters.Add(New SqlParameter("@vis_res_fec_fin_ind", SqlDbType.bit)).Value = ObjEnt.FechaFinIndeterminado

                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.int)).Value = ObjEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@vis_res_obs", SqlDbType.varchar, 250)).Value = ObjEnt.Observacion

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.int))
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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Visita.VisitanteRestriccion) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_res_id", SqlDbType.int)).Value = objEnt.Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.int))
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