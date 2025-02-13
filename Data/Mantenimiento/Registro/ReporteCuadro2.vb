Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento
    Public Class Reportecuadro2
        Private Shared strNameProcedure As String = "UP_RPT_Cuadro002"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
        ByVal Generico As String, ByVal Especifico As String, ByVal Cuadro As Integer, ByVal Orden As Integer) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@rpt_cua_2_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@del_gen_nom", SqlDbType.VarChar, 255)).Value = Generico
                    .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 1000)).Value = Especifico
                    .Parameters.Add(New SqlParameter("@rpt_cua", SqlDbType.Int)).Value = Cuadro
                    .Parameters.Add(New SqlParameter("@rpt_ord", SqlDbType.Int)).Value = Orden
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Generico As String, _
        ByVal CodigoGenerico As String, _
        ByVal Especifico As String, _
        ByVal CodigoEspecifico As String, _
        ByVal DelitoString As String, _
        ByVal Cuadro As Integer, _
        ByVal Orden As Integer _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@rpt_cua_2_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@del_gen_nom", SqlDbType.VarChar, 255)).Value = Generico
                            .Parameters.Add(New SqlParameter("@del_gen_cod", SqlDbType.VarChar, 10)).Value = CodigoGenerico
                            .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 1000)).Value = Especifico
                            .Parameters.Add(New SqlParameter("@rpt_cod_str", SqlDbType.VarChar, 500)).Value = CodigoEspecifico
                            .Parameters.Add(New SqlParameter("@del_id_str", SqlDbType.VarChar, 1000)).Value = DelitoString
                            .Parameters.Add(New SqlParameter("@rpt_cua", SqlDbType.Int)).Value = Cuadro
                            .Parameters.Add(New SqlParameter("@rpt_ord", SqlDbType.Int)).Value = Orden

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
        ByVal Generico As String, _
        ByVal CodigoGenerico As String, _
        ByVal Especifico As String, _
        ByVal CodigoEspecifico As String, _
        ByVal DelitoString As String, _
        ByVal Cuadro As Integer, _
        ByVal Orden As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@rpt_cua_2_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@del_gen_nom", SqlDbType.VarChar, 255)).Value = Generico
                            .Parameters.Add(New SqlParameter("@del_gen_cod", SqlDbType.VarChar, 10)).Value = CodigoGenerico
                            .Parameters.Add(New SqlParameter("@del_esp_nom", SqlDbType.VarChar, 1000)).Value = Especifico
                            .Parameters.Add(New SqlParameter("@rpt_cod_str", SqlDbType.VarChar, 500)).Value = CodigoEspecifico
                            .Parameters.Add(New SqlParameter("@del_id_str", SqlDbType.VarChar, 1000)).Value = DelitoString
                            .Parameters.Add(New SqlParameter("@rpt_cua", SqlDbType.Int)).Value = Cuadro
                            .Parameters.Add(New SqlParameter("@rpt_ord", SqlDbType.Int)).Value = Orden

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
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@rpt_cua_2_id", SqlDbType.Int)).Value = Codigo

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