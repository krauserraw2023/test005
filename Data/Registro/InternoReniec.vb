Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoReniec        
        Private Shared strNombreProcedure As String = "UP_INT_InternoReniec"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, _
                                          ByVal opcion As String, ByVal objEnt As Entity.Registro.InternoReniec) As Integer            
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@fot_int", SqlDbType.Int)).Value = objEnt.FotoInterno
                            .Parameters.Add(New SqlParameter("@int_rnc_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observaciones
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
                                     ByVal opcion As String, objEnt As Entity.Registro.InternoReniec) As SqlDataReader
            'usar entity
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                'Dim intValue As Integer = -1
                Dim sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandTimeout = 300
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@int_rnc_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                    .Parameters.Add(New SqlParameter("@int_rnc_nom_aso_val_id", SqlDbType.Int)).Value = objEnt.NombreAsociadoVal_ID
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader

        End Function
#End Region
#Region "Grabar"
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Registro.InternoReniec) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_rnc_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@int_rnc_tip_bus_id", SqlDbType.Int)).Value = objEnt.TipoBusquedaID
                            .Parameters.Add(New SqlParameter("@int_rnc_com_id", SqlDbType.Int)).Value = objEnt.ComparacionID
                            .Parameters.Add(New SqlParameter("@fot_rnc", SqlDbType.Int)).Value = objEnt.FotoReniec
                            .Parameters.Add(New SqlParameter("@fot_int", SqlDbType.Int)).Value = objEnt.FotoInterno
                            .Parameters.Add(New SqlParameter("@int_rnc_sis_med", SqlDbType.VarChar, 1000)).Value = objEnt.InternoSisMetadata
                            .Parameters.Add(New SqlParameter("@int_rnc_sis_dat", SqlDbType.VarChar, 5000)).Value = objEnt.InternoSisData
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.VarChar, 1000)).Value = objEnt.NombresAsociadosID
                            .Parameters.Add(New SqlParameter("@int_nom_aso", SqlDbType.VarChar, 1000)).Value = objEnt.NombresAsociadosNom
                            .Parameters.Add(New SqlParameter("@int_rnc_med", SqlDbType.VarChar, 1000)).Value = objEnt.ReniecMetadata
                            .Parameters.Add(New SqlParameter("@int_rnc_dat", SqlDbType.VarChar, 5000)).Value = objEnt.ReniecData
                            .Parameters.Add(New SqlParameter("@int_rnc_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observaciones
                            .Parameters.Add(New SqlParameter("@int_rnc_nom_aso_val_id", SqlDbType.Int)).Value = objEnt.NombreAsociadoVal_ID
                            '.Parameters.Add(New SqlParameter("@int_rnc_fec_ver", SqlDbType.BigInt)).Value = Now.ToFileTime

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

        Public Shared Function Grabar2(ByVal accion As String, ByVal opcion As String, _
                                     ByVal objEnt As Entity.Registro.InternoReniec) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_rnc_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@int_rnc_tip_bus_id", SqlDbType.Int)).Value = objEnt.TipoBusquedaID
                            .Parameters.Add(New SqlParameter("@int_rnc_com_id", SqlDbType.Int)).Value = objEnt.ComparacionID
                            .Parameters.Add(New SqlParameter("@fot_rnc", SqlDbType.Int)).Value = objEnt.FotoReniec
                            .Parameters.Add(New SqlParameter("@fot_int", SqlDbType.Int)).Value = objEnt.FotoInterno
                            .Parameters.Add(New SqlParameter("@int_rnc_sis_med", SqlDbType.VarChar, 1000)).Value = objEnt.InternoSisMetadata
                            .Parameters.Add(New SqlParameter("@int_rnc_sis_dat", SqlDbType.VarChar, 5000)).Value = objEnt.InternoSisData
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.VarChar, 1000)).Value = objEnt.NombresAsociadosID
                            .Parameters.Add(New SqlParameter("@int_nom_aso", SqlDbType.VarChar, 1000)).Value = objEnt.NombresAsociadosNom
                            .Parameters.Add(New SqlParameter("@int_rnc_med", SqlDbType.VarChar, 1000)).Value = objEnt.ReniecMetadata
                            .Parameters.Add(New SqlParameter("@int_rnc_dat", SqlDbType.VarChar, 5000)).Value = objEnt.ReniecData
                            .Parameters.Add(New SqlParameter("@int_rnc_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observaciones
                            .Parameters.Add(New SqlParameter("@int_rnc_nom_aso_val_id", SqlDbType.Int)).Value = objEnt.NombreAsociadoVal_ID
                            .Parameters.Add(New SqlParameter("@int_rnc_fec_ver", SqlDbType.BigInt)).Value = Now.ToFileTime

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

        Public Shared Function Grabar2_LM(ByVal accion As String, ByVal opcion As String, _
                                     ByVal objEnt As Entity.Registro.InternoReniec) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_rnc_id", SqlDbType.Int)).Value = objEnt.Codigo
                            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@_RegId", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_PenId", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@int_rnc_tip_bus_id", SqlDbType.Int)).Value = objEnt.TipoBusquedaID
                            .Parameters.Add(New SqlParameter("@int_rnc_com_id", SqlDbType.Int)).Value = objEnt.ComparacionID
                            .Parameters.Add(New SqlParameter("@fot_rnc", SqlDbType.Int)).Value = objEnt.FotoReniec
                            .Parameters.Add(New SqlParameter("@fot_int", SqlDbType.Int)).Value = objEnt.FotoInterno
                            .Parameters.Add(New SqlParameter("@int_rnc_sis_med", SqlDbType.VarChar, 1000)).Value = objEnt.InternoSisMetadata
                            .Parameters.Add(New SqlParameter("@int_rnc_sis_dat", SqlDbType.VarChar, 5000)).Value = objEnt.InternoSisData
                            .Parameters.Add(New SqlParameter("@int_nom_aso_id", SqlDbType.VarChar, 1000)).Value = objEnt.NombresAsociadosID
                            .Parameters.Add(New SqlParameter("@int_nom_aso", SqlDbType.VarChar, 1000)).Value = objEnt.NombresAsociadosNom
                            .Parameters.Add(New SqlParameter("@int_rnc_med", SqlDbType.VarChar, 1000)).Value = objEnt.ReniecMetadata
                            .Parameters.Add(New SqlParameter("@int_rnc_dat", SqlDbType.VarChar, 5000)).Value = objEnt.ReniecData
                            .Parameters.Add(New SqlParameter("@int_rnc_obs", SqlDbType.VarChar, 1000)).Value = objEnt.Observaciones
                            .Parameters.Add(New SqlParameter("@int_rnc_nom_aso_val_id", SqlDbType.Int)).Value = objEnt.NombreAsociadoVal_ID
                            .Parameters.Add(New SqlParameter("@int_rnc_fec_ver", SqlDbType.BigInt)).Value = Now.ToFileTime

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

#End Region
#Region "Eliminar"
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@int_rnc_id", SqlDbType.Int)).Value = Codigo

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
#End Region
    End Class

End Namespace
