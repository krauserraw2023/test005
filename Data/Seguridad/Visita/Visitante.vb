Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class Visitante
        Private Shared strNameProcedure As String = "UP_VIS_Visitante"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String,
                                            ByVal objEnt As Entity.Visita.Visitante) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID

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
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal DocumentoTipoID As Integer, _
        ByVal DocumentoNumero As String, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = DocumentoTipoID
                            .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = DocumentoNumero
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = PenalID

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
        ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, _
        ByVal DocumentoTipoID As Integer, _
        ByVal DocumentoNro As String, _
        ByVal Institucion As String, _
        ByVal Nacionalidad As Integer, _
        ByVal Sexo As Integer, _
        ByVal RegionId As Integer, _
        ByVal PenalId As Integer) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    sqlCmd.CommandTimeout = 300
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 50)).Value = ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 50)).Value = ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 50)).Value = Nombres
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = Sexo
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = DocumentoTipoID
                    .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = DocumentoNro
                    .Parameters.Add(New SqlParameter("@vis_ins_nom", SqlDbType.VarChar, 100)).Value = Institucion
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = Nacionalidad

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = RegionId
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = PenalId

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
        ByVal opcion As String, ByVal objEnt As Entity.Visita.Visitante) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    sqlCmd.CommandTimeout = 300
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                    .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                    .Parameters.Add(New SqlParameter("@vis_ape", SqlDbType.VarChar, 120)).Value = objEnt.VisitanteApellidosyNombres
                    .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                    .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                    .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                    .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                    .Parameters.Add(New SqlParameter("@vis_ins_nom", SqlDbType.VarChar, 100)).Value = objEnt.Institucion
                    .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID

                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID

                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region
       
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal CODIGO As Integer, _
        ByVal ApellidoPaterno As String, _
        ByVal ApellidoMaterno As String, _
        ByVal Nombres As String, _
        ByVal Sexo As Integer, _
        ByVal DocumentoTipoId As Integer, _
        ByVal DocumentoNro As String, _
        ByVal FechaNacimiento As Long, _
        ByVal Institucion As String, _
        ByVal Nacionalidad As Integer, _
        ByVal Observacion As String, ByVal FotoID As Integer, ByVal Foto As String, _
        ByVal HuellaCodigo As String, _
        ByVal HuellaDedo As Integer, _
        ByVal HuellaReniec As Integer, _
        ByVal REgionId As Integer, ByVal PenalID As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = CODIGO
                            .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 50)).Value = ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 50)).Value = ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 50)).Value = Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = Sexo
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = DocumentoTipoId
                            .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = DocumentoNro
                            .Parameters.Add(New SqlParameter("@vis_fec_nac", SqlDbType.BigInt)).Value = FechaNacimiento
                            .Parameters.Add(New SqlParameter("@vis_ins_nom", SqlDbType.VarChar, 100)).Value = Institucion
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = Nacionalidad

                            .Parameters.Add(New SqlParameter("@vis_fot_id", SqlDbType.Int)).Value = FotoID
                            .Parameters.Add(New SqlParameter("@vis_fot", SqlDbType.VarChar, 500)).Value = Foto
                            .Parameters.Add(New SqlParameter("@vis_obs", SqlDbType.VarChar, 200)).Value = Observacion

                            .Parameters.Add(New SqlParameter("@vis_hue_cod", SqlDbType.VarChar, 100)).Value = HuellaCodigo
                            .Parameters.Add(New SqlParameter("@vis_hue_ded", SqlDbType.Int)).Value = HuellaDedo
                            .Parameters.Add(New SqlParameter("@vis_hue_rec", SqlDbType.Int)).Value = HuellaReniec



                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = REgionId
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = PenalID


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
                                      ByVal objEnt As Entity.Visita.Visitante) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@vis_ape_pat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@vis_ape_mat", SqlDbType.VarChar, 50)).Value = objEnt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@vis_nom", SqlDbType.VarChar, 50)).Value = objEnt.Nombres
                            .Parameters.Add(New SqlParameter("@sex_id", SqlDbType.Int)).Value = objEnt.SexoID
                            .Parameters.Add(New SqlParameter("@doc_tip_id", SqlDbType.Int)).Value = objEnt.TipoDocumentoID
                            .Parameters.Add(New SqlParameter("@vis_doc_num", SqlDbType.VarChar, 20)).Value = objEnt.NumeroDocumento
                            .Parameters.Add(New SqlParameter("@vis_fec_nac", SqlDbType.BigInt)).Value = objEnt.FechaNacimiento
                            .Parameters.Add(New SqlParameter("@vis_ins_nom", SqlDbType.VarChar, 100)).Value = objEnt.Institucion
                            .Parameters.Add(New SqlParameter("@nac_id", SqlDbType.Int)).Value = objEnt.NacionalidadID                            
                            .Parameters.Add(New SqlParameter("@vis_obs", SqlDbType.VarChar, 200)).Value = objEnt.Observacion
                            '/*foto*/
                            .Parameters.Add(New SqlParameter("@vis_fot_id", SqlDbType.Int)).Value = objEnt.FotoID
                            .Parameters.Add(New SqlParameter("@vis_fot", SqlDbType.VarChar, 500)).Value = objEnt.FotoName
                            .Parameters.Add(New SqlParameter("@f_usu_id_cap_fot", SqlDbType.Int)).Value = objEnt.IDUsuarioCapturaFoto
                            '/*huella*/
                            .Parameters.Add(New SqlParameter("@f_usu_id_cap_hue", SqlDbType.Int)).Value = objEnt.IDUsuarioCapturaHuella
                            .Parameters.Add(New SqlParameter("@n_vis_has_hue", SqlDbType.Int)).Value = objEnt.VisitanteTieneHuella
                            '/*reniec*/
                            .Parameters.Add(New SqlParameter("@n_vis_val_rnc", SqlDbType.SmallInt)).Value = objEnt.VisitanteValidoReniec
                            .Parameters.Add(New SqlParameter("@f_usu_id_val_rnc", SqlDbType.Int)).Value = objEnt.IDUsuarioValidacionReniec
                            .Parameters.Add(New SqlParameter("@n_vis_fec_val_rnc", SqlDbType.BigInt)).Value = objEnt.FechaValidacionReniec

                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID

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
                            .Parameters.Add(New SqlParameter("@vis_id", SqlDbType.Int)).Value = Codigo

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