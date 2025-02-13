Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento
    Public Class SalaJuzgado
        Private Shared strNameProcedure As String = "UP_INT_SalaJuzgado"
#Region "Listar"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
     ByVal DistritoJudID As Integer,
     ByVal DistritoJudCodigo As String,
     ByVal SalaCodigo As String,
     ByVal Nombre As String
     ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@par_prn_id", SqlDbType.Int)).Value = DistritoJudID
                            .Parameters.Add(New SqlParameter("@par_cod_prn", SqlDbType.VarChar, 10)).Value = DistritoJudCodigo
                            .Parameters.Add(New SqlParameter("@par_cod", SqlDbType.VarChar, 15)).Value = SalaCodigo
                            .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.VarChar, 255)).Value = Nombre

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

        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String,
                                      objEnt As Entity.Mantenimiento.SalaJuzgado) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = objEnt.Codigo
                    .Parameters.Add(New SqlParameter("@par_prn_id", SqlDbType.Int)).Value = objEnt.DistritoJudID
                    .Parameters.Add(New SqlParameter("@par_cod_prn", SqlDbType.VarChar, 10)).Value = objEnt.DistritoJudCodigo
                    .Parameters.Add(New SqlParameter("@par_cod", SqlDbType.VarChar, 15)).Value = objEnt.SalaCodigo
                    .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.VarChar, 255)).Value = objEnt.Nombre
                    .Parameters.Add(New SqlParameter("@par_nom_cor", SqlDbType.VarChar, 255)).Value = objEnt.NombreCorto
                    .Parameters.Add(New SqlParameter("@sal_juz_est", SqlDbType.SmallInt)).Value = objEnt.Estado
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function

#End Region

#Region "Grabar"

        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ObjEnt As Entity.Mantenimiento.SalaJuzgado) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = ObjEnt.Codigo
                            .Parameters.Add(New SqlParameter("@par_prn_id", SqlDbType.Int)).Value = ObjEnt.DistritoJudID
                            .Parameters.Add(New SqlParameter("@par_cod_prn", SqlDbType.VarChar, 10)).Value = ObjEnt.DistritoJudCodigo
                            .Parameters.Add(New SqlParameter("@par_cod", SqlDbType.VarChar, 15)).Value = ObjEnt.SalaCodigo
                            .Parameters.Add(New SqlParameter("@par_nom", SqlDbType.VarChar, 255)).Value = ObjEnt.Nombre
                            .Parameters.Add(New SqlParameter("@par_nom_cor", SqlDbType.VarChar, 255)).Value = ObjEnt.NombreCorto
                            .Parameters.Add(New SqlParameter("@sal_juz_est", SqlDbType.SmallInt)).Value = ObjEnt.Estado
                            .Parameters.Add(New SqlParameter("@fk_aut_jud_jur_id", SqlDbType.SmallInt)).Value = ObjEnt.JurisdiccionId


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
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@par_id", SqlDbType.Int)).Value = Codigo

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