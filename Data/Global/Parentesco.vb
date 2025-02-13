Imports System.Data
Imports System.Data.SqlClient
Namespace Globall
    Public Class Parentesco
        Private Shared strNameProcedure As String = "UP_GLO_Parentesco"
#Region "Listar"        
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, _
                                            ByVal objEntFiltro As Entity.Globall.Parentesco) As Integer

            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                            .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.VarChar, 100)).Value = objEntFiltro.Nombre
                            .Parameters.Add(New SqlParameter("@par_pri", SqlDbType.Int)).Value = objEntFiltro.Orden
                            .Parameters.Add(New SqlParameter("@par_t01", SqlDbType.SmallInt)).Value = objEntFiltro.Opcion1
                            .Parameters.Add(New SqlParameter("@par_t02", SqlDbType.SmallInt)).Value = objEntFiltro.Opcion2
                            .Parameters.Add(New SqlParameter("@par_tip", SqlDbType.SmallInt)).Value = objEntFiltro.Tipo
                            .Parameters.Add(New SqlParameter("@par_grd", SqlDbType.SmallInt)).Value = objEntFiltro.Grado

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
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, _
                                      ByVal objEntFiltro As Entity.Globall.Parentesco) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEntFiltro.Codigo
                    .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.VarChar, 100)).Value = objEntFiltro.Nombre
                    .Parameters.Add(New SqlParameter("@par_pri", SqlDbType.Int)).Value = objEntFiltro.Orden
                    .Parameters.Add(New SqlParameter("@par_t01", SqlDbType.SmallInt)).Value = objEntFiltro.Opcion1
                    .Parameters.Add(New SqlParameter("@par_t02", SqlDbType.SmallInt)).Value = objEntFiltro.Opcion2
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
#End Region
      
    End Class
End Namespace