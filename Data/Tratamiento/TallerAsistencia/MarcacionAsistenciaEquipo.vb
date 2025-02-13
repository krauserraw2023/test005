Imports System.Data.SqlClient

Namespace Tratamiento.TallerAsistencia
    Public Class MarcacionAsistenciaEquipo
        Public Shared Function ListarDataTable(sql As String, ByRef outSms As String) As DataTable
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim accion As String = "lst"
            Dim opcion As String = "lst_mant"
            sqlCon.Open()
            Dim sqlCmd As SqlCommand = New SqlCommand(sql, sqlCon)
            Try
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                dtTabla = Nothing
                outSms = ex.Message
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()
                sqlReader.Close()
                sqlReader = Nothing
            End Try

            Return dtTabla

        End Function

        Public Shared Function EjecutarSentenciaSQL(SQL As String) As Integer
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Dim id As Integer = -1
            Try
                sqlCmd = New SqlCommand(SQL, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = sqlCmd.ExecuteScalar()
            Catch ex As Exception

            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
            End Try
            Return id
        End Function

        Public Shared Function Listar(RegionId As Integer, PenalId As Integer) As DataTable
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            'Dim sqlCmd As SqlCommand = Nothing
            Dim sql As String = ""
            Dim accion As String = "lst"
            Dim opcion As String = "lst_mant"
            sqlCon.Open()
            Dim sqlCmd As SqlCommand = New SqlCommand("usp_tra_tal_marcacionasistencia_mov", sqlCon)
            Try
                With sqlCmd
                    .CommandTimeout = 300
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@kf_reg_id", SqlDbType.Int)).Value = RegionId
                    .Parameters.Add(New SqlParameter("@kf_pen_id", SqlDbType.Int)).Value = PenalId

                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
                    .Parameters("@variable_out").Direction = ParameterDirection.Output
                End With
                ' sqlReader = sqlCmd.ExecuteReader()
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
                'sqlCmd = New SqlCommand(sql, sqlCon)
                'sqlCon.Open()
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                dtTabla = Nothing
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
                sqlReader.Dispose()
                sqlReader.Close()
                sqlReader = Nothing
            End Try

            Return dtTabla

        End Function

    End Class
End Namespace