Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Documento
    Public Class NombresAsociados
        Private Shared strNameProcedure As String = "UP_REG_DOC_InternoNombresAsociados"
#Region "Listar"

        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
        ByVal InternoID As Integer, _
        ByVal IngresoID As Integer) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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

        Public Shared Function ListarOutput_LM(ByVal accion As String, ByVal opcion As String,
        ByVal InternoID As Integer,
        ByVal IngresoInpeID As Integer, Optional NombreAsociadoId As Integer = -1) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion

                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = IngresoInpeID
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.Int)).Value = NombreAsociadoId

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                   objEnt As Entity.Registro.Documento.NombresAsociados) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@doc_int_nom_aso_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                    .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                    .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objEnt.DocumentoJudicialID
                    .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = objEnt.RegionID
                    .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID
                    .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.Int)).Value = objEnt.InternoNombreAsociadoID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        
#End Region
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, entObj As Entity.Registro.Documento.NombresAsociados) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_id", SqlDbType.BigInt)).Value = entObj.Codigo
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.Int)).Value = entObj.InternoNombreAsociadoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = entObj.InternoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.BigInt)).Value = entObj.DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri", SqlDbType.Int)).Value = entObj.NAPrincipal
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat", SqlDbType.VarChar, 100)).Value = entObj.NAPaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat", SqlDbType.VarChar, 100)).Value = entObj.NAMaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom", SqlDbType.VarChar, 100)).Value = entObj.NANombres
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_est", SqlDbType.Int)).Value = entObj.NAEstado

                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = entObj.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = entObj.PenalID
                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = entObj.FlagTransferenciaSede

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = entObj.Audit_UsuarioCreacion
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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
        Public Shared Function Grabar_v2(ByVal accion As String, ByVal opcion As String, objent As Entity.Registro.Documento.NombresAsociados) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_id", SqlDbType.BigInt)).Value = objent.Codigo
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.Int)).Value = objent.InternoNombreAsociadoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objent.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objent.IngresoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objent.DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri", SqlDbType.Int)).Value = objent.NAPrincipal
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat", SqlDbType.VarChar, 100)).Value = objent.NAPaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat", SqlDbType.VarChar, 100)).Value = objent.NAMaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom", SqlDbType.VarChar, 100)).Value = objent.NANombres
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri2", SqlDbType.Int)).Value = objent.NAPrincipal2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat2", SqlDbType.VarChar, 100)).Value = objent.NAPaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat2", SqlDbType.VarChar, 100)).Value = objent.NAMaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom2", SqlDbType.VarChar, 100)).Value = objent.NANombres2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_est", SqlDbType.Int)).Value = objent.NAEstado
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objent.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objent.PenalID
                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objent.FlagTransferenciaSede

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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

        'Grabar_v2
        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, objent As Entity.Registro.Documento.NombresAsociados) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_id", SqlDbType.BigInt)).Value = objent.Codigo
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.Int)).Value = objent.InternoNombreAsociadoID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objent.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objent.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objent.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = objent.DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri", SqlDbType.Int)).Value = objent.NAPrincipal
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat", SqlDbType.VarChar, 100)).Value = objent.NAPaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat", SqlDbType.VarChar, 100)).Value = objent.NAMaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom", SqlDbType.VarChar, 100)).Value = objent.NANombres
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri2", SqlDbType.Int)).Value = objent.NAPrincipal2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat2", SqlDbType.VarChar, 100)).Value = objent.NAPaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat2", SqlDbType.VarChar, 100)).Value = objent.NAMaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom2", SqlDbType.VarChar, 100)).Value = objent.NANombres2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_est", SqlDbType.Int)).Value = objent.NAEstado
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objent.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objent.PenalID
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = objent.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_sed_rowid", SqlDbType.Int)).Value = objent.SedeRowId
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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
#Region "Eliminar"
        Public Shared Function Eliminar_LM(ByVal accion As String, ByVal opcion As String, _
                                         obj As Entity.Registro.Documento.NombresAsociados) As Long

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_id", SqlDbType.BigInt)).Value = obj.Codigo
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.BigInt)).Value = obj.InternoNombreAsociadoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = obj.DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = obj.InternoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = obj.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri", SqlDbType.Int)).Value = obj.NAPrincipal
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat", SqlDbType.VarChar, 100)).Value = obj.NAPaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat", SqlDbType.VarChar, 100)).Value = obj.NAMaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom", SqlDbType.VarChar, 100)).Value = obj.NANombres
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri2", SqlDbType.Int)).Value = obj.NAPrincipal2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat2", SqlDbType.VarChar, 100)).Value = obj.NAPaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat2", SqlDbType.VarChar, 100)).Value = obj.NAMaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom2", SqlDbType.VarChar, 100)).Value = obj.NANombres2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_est", SqlDbType.Int)).Value = obj.NAEstado
                            .Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = obj.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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

        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, _
                                         obj As Entity.Registro.Documento.NombresAsociados) As Long

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_id", SqlDbType.BigInt)).Value = obj.Codigo
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.BigInt)).Value = obj.InternoNombreAsociadoID
                            .Parameters.Add(New SqlParameter("@doc_jud_id", SqlDbType.Int)).Value = obj.DocumentoJudicialID
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = obj.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = obj.IngresoID
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri", SqlDbType.Int)).Value = obj.NAPrincipal
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat", SqlDbType.VarChar, 100)).Value = obj.NAPaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat", SqlDbType.VarChar, 100)).Value = obj.NAMaterno
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom", SqlDbType.VarChar, 100)).Value = obj.NANombres
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_pri2", SqlDbType.Int)).Value = obj.NAPrincipal2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_pat2", SqlDbType.VarChar, 100)).Value = obj.NAPaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_ape_mat2", SqlDbType.VarChar, 100)).Value = obj.NAMaterno2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_nom2", SqlDbType.VarChar, 100)).Value = obj.NANombres2
                            .Parameters.Add(New SqlParameter("@doc_int_nom_aso_est", SqlDbType.Int)).Value = obj.NAEstado
                            '.Parameters.Add(New SqlParameter("@_sed_flg_trf", SqlDbType.SmallInt)).Value = obj.FlagTransferenciaSede
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Legolas.Configuration.Usuario.Codigo
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.BigInt))
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

    End Class
End Namespace