Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoReniecNomAsoc
        Private Shared strNombreProcedure As String = "UP_INT_InternoReniec_NomAsoc"
#Region "Listar"
        
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, _
                                     ByVal opcion As String, objEnt As Entity.Registro.InternoReniecNomAsoc) As SqlDataReader
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
                    '.Parameters.Add(New SqlParameter("@int_rnc_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@fk_int_rnc_id", SqlDbType.Int)).Value = objEnt.InternoReniecID
                    '.Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = objEnt.InternoID
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
                                      ByVal objEnt As Entity.Registro.InternoReniecNomAsoc) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd


                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_int_aso_id", SqlDbType.Int)).Value = objEnt.CodigoNomAsoc
                            ' .Parameters.Add(New SqlParameter("@rnc_nom_asoc_id", SqlDbType.Int)).Value = objEnt.TablaID

                            .Parameters.Add(New SqlParameter("@fk_int_rnc_id", SqlDbType.Int)).Value = objEnt.InternoReniecID
                            .Parameters.Add(New SqlParameter("@InternoID", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@IngresoID", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@rnc_aso_ape_pat", SqlDbType.VarChar, 120)).Value = objEnt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@rnc_aso_ape_mat", SqlDbType.VarChar, 120)).Value = objEnt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@rnc_aso_nom", SqlDbType.VarChar, 120)).Value = objEnt.Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID


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

        Public Shared Function Grabar_LM(ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEnt As Entity.Registro.InternoReniecNomAsoc) As Integer

            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNombreProcedure, sqlCon)
                        With sqlCmd


                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@fk_int_aso_id", SqlDbType.Int)).Value = objEnt.CodigoNomAsoc
                            ' .Parameters.Add(New SqlParameter("@rnc_nom_asoc_id", SqlDbType.Int)).Value = objEnt.TablaID

                            .Parameters.Add(New SqlParameter("@fk_int_rnc_id", SqlDbType.Int)).Value = objEnt.InternoReniecID
                            .Parameters.Add(New SqlParameter("@InternoID", SqlDbType.Int)).Value = objEnt.InternoID
                            .Parameters.Add(New SqlParameter("@IngresoID", SqlDbType.Int)).Value = objEnt.IngresoID
                            .Parameters.Add(New SqlParameter("@fk_ing_inp_id", SqlDbType.Int)).Value = objEnt.IngresoInpeId
                            .Parameters.Add(New SqlParameter("@rnc_aso_ape_pat", SqlDbType.VarChar, 120)).Value = objEnt.ApellidoPaterno
                            .Parameters.Add(New SqlParameter("@rnc_aso_ape_mat", SqlDbType.VarChar, 120)).Value = objEnt.ApellidoMaterno
                            .Parameters.Add(New SqlParameter("@rnc_aso_nom", SqlDbType.VarChar, 120)).Value = objEnt.Nombres
                            .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = objEnt.PenalID

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

    End Class

End Namespace
