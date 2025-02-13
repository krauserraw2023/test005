Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class VisitanteSancion
        Private Shared strNameProcedure As String = "UP_VIS_VisitanteSancion"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, _
        ByVal Codigo As Integer, _
        ByVal VisitanteID As Integer, ByVal VisNumDoc As String, ByVal VisApePat As String, _
        ByVal VisApeMat As String, ByVal VisNom As String, ByVal Fecha As Long, ByVal FechaIni As Long, _
        ByVal FechaFin As Long, _
        ByVal TipoSancion As Integer, _
        ByVal REgionId As Integer, _
        ByVal PenalID As Integer) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@vis_san_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteID
                    .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = VisNumDoc
                    .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 120)).Value = VisApePat
                    .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 120)).Value = VisApeMat
                    .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 120)).Value = VisNom
                    .Parameters.Add(New SqlParameter("@vis_san_fec", SqlDbType.BigInt)).Value = Fecha
                    .Parameters.Add(New SqlParameter("@vis_san_ini", SqlDbType.BigInt)).Value = FechaIni
                    .Parameters.Add(New SqlParameter("@vis_san_fin", SqlDbType.BigInt)).Value = FechaFin
                    .Parameters.Add(New SqlParameter("@san_tip_id", SqlDbType.Int)).Value = TipoSancion
                    '.Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = EstadoId
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = REgionId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = PenalID


                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal VisitanteID As Integer, ByVal Fecha As Long) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_san_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteID
                            '.Parameters.Add(New SqlParameter("@vis_san_ini", SqlDbType.BigInt)).Value = Inicio
                            '.Parameters.Add(New SqlParameter("@vis_san_fin", SqlDbType.BigInt)).Value = Fin
                            .Parameters.Add(New SqlParameter("@vis_san_fec", SqlDbType.BigInt)).Value = Fecha
                            '.Parameters.Add(New SqlParameter("@san_tip_id", SqlDbType.Int)).Value = TipoId
                            '.Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = EstadoId
                            '.Parameters.Add(New SqlParameter("@vis_san_obs", SqlDbType.VarChar, 200)).Value = Observacion

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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal VisitanteID As Integer, ByVal Fecha As Long, _
        ByVal FechaIni As Long, _
        ByVal FechaFin As Long, _
        ByVal TipoSancionID As Integer, ByVal Documento As String, _
        ByVal EstadoID As Integer, _
        ByVal Observacion As String, _
        ByVal RegionId As Integer, ByVal PenalId As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_san_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = VisitanteID
                            .Parameters.Add(New SqlParameter("@vis_san_ini", SqlDbType.BigInt)).Value = FechaIni
                            .Parameters.Add(New SqlParameter("@vis_san_fin", SqlDbType.BigInt)).Value = FechaFin
                            .Parameters.Add(New SqlParameter("@vis_san_fec", SqlDbType.BigInt)).Value = Fecha
                            .Parameters.Add(New SqlParameter("@san_tip_id", SqlDbType.Int)).Value = TipoSancionID
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = EstadoID
                            .Parameters.Add(New SqlParameter("@vis_san_doc", SqlDbType.VarChar, 50)).Value = Documento
                            .Parameters.Add(New SqlParameter("@vis_san_obs", SqlDbType.VarChar, 200)).Value = Observacion


                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = RegionId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = PenalId




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
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String,
                                      ByVal objEnt As Entity.Visita.VisitanteSancion) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_san_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.VisitanteID
                            .Parameters.Add(New SqlParameter("@vis_ape_nom", SqlDbType.VarChar, 200)).Value = objEnt.VisitanteApeNom
                            .Parameters.Add(New SqlParameter("@vis_san_ini", SqlDbType.BigInt)).Value = objEnt.FechaInicio
                            .Parameters.Add(New SqlParameter("@vis_san_fin", SqlDbType.BigInt)).Value = objEnt.FechaFin
                            .Parameters.Add(New SqlParameter("@vis_san_fec", SqlDbType.BigInt)).Value = objEnt.Fecha
                            .Parameters.Add(New SqlParameter("@vis_san_fec_fin_ind", SqlDbType.Bit)).Value = objEnt.FechaFinIndeterminado

                            .Parameters.Add(New SqlParameter("@san_tip_id", SqlDbType.Int)).Value = objEnt.TipoSancionID
                            .Parameters.Add(New SqlParameter("@est_id", SqlDbType.Int)).Value = objEnt.EstadoID
                            .Parameters.Add(New SqlParameter("@vis_san_doc", SqlDbType.VarChar, 50)).Value = objEnt.Documento
                            .Parameters.Add(New SqlParameter("@vis_san_obs", SqlDbType.VarChar, 200)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@vis_san_doc_anu", SqlDbType.VarChar, 50)).Value = objEnt.DocumentoAnulacion
                            .Parameters.Add(New SqlParameter("@vis_san_mot_anu", SqlDbType.VarChar, 200)).Value = objEnt.MotivoAnulacion
                            .Parameters.Add(New SqlParameter("@vis_san_obs_anu", SqlDbType.VarChar, 200)).Value = objEnt.ObsAnulacion

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID

                            '/*otros*/
                            .Parameters.Add(New SqlParameter("@pk_san_id_sed ", SqlDbType.Int)).Value = objEnt.IDVisitanteSancionSede
                            .Parameters.Add(New SqlParameter("@n_vis_san_fec_sed ", SqlDbType.BigInt)).Value = objEnt.FechaSede

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
                            .Parameters.Add(New SqlParameter("@vis_san_id", SqlDbType.Int)).Value = Codigo

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