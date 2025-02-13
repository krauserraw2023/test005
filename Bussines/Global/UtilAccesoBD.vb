Imports System.Data.SqlClient
Namespace Globall
    Public Class UtilAccesoBD
#Region "Transferencia"
        Public Shared Function EjecutarSqlToTable_PopeBD(sql As String, ByRef outSms As String) As DataTable
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCmd = New SqlCommand(sql, sqlCon)
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader()
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                outSms = ex.ToString
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

        Public Shared Function LeerTablaBD_PopeBD(NombreTabla As String, ByRef estadoError As Integer, ByRef outSms As String) As DataTable
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As SqlDataReader = Nothing
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCmd = New SqlCommand("select top 1 * from " & NombreTabla, sqlCon)
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader()
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                outSms = ex.ToString
                estadoError = -1
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

        Public Shared Function LeerTablaBD_PopeHuellaInternoBD(strCNBD As String, NombreTabla As String, ByRef estadoError As Integer, ByRef outSms As String) As DataTable
            Dim dtTabla As DataTable = Nothing
            Dim sqlReader As SqlDataReader = Nothing

            Dim sqlCon As SqlConnection = New SqlConnection(strCNBD)
            Dim sqlCmd As SqlCommand = Nothing
            Try
                sqlCmd = New SqlCommand("select top 1 * from " & NombreTabla, sqlCon)
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader()
                dtTabla = Nothing
                dtTabla = New DataTable
                dtTabla.Load(sqlReader)
            Catch ex As Exception
                outSms = ex.Message.ToString
                estadoError = -1
                dtTabla = Nothing
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
                'sqlReader.Dispose()
                'sqlReader.Close()
                sqlReader = Nothing
            End Try
            Return dtTabla
        End Function

        Public Shared Function ObtenerIDRegistroXSedRowId_PopeBD(NombreTabla As String, nomColPK As String, _sed_rowid As Integer, ByRef estadoError As Integer, ByRef outSMS As String) As Integer
            '*******************************************************************************************************************************************
            ' Verifica la existencia de registros por el _sed_rowid en la base de datos local, para determinar la accion de Insert o Update a ejecutarse.
            '*******************************************************************************************************************************************
            estadoError = 0
            Dim sqlReader As SqlDataReader = Nothing
            Dim Id As Integer = -1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing

            Try
                Dim sql As String = ""
                sql = "select  " & nomColPK & " from " & NombreTabla & " where _sed_rowid=" & _sed_rowid
                sqlCmd = New SqlCommand(sql, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader
                If sqlReader.HasRows Then
                    Dim cantReg As Integer = 0
                    While sqlReader.Read
                        cantReg = cantReg + 1
                        Id = sqlReader(nomColPK)
                    End While
                    If cantReg > 1 Then
                        outSMS = "Al ejecutar la siguiente consulta (" & sql & ") ha devuelto mas de un registro en la base de datos local."
                        Id = -100
                        estadoError = -1
                    End If
                End If
            Catch ex As Exception
                outSMS = ex.ToString
                Id = -100
                estadoError = -1
            Finally
                Try
                    sqlReader.Close()
                    sqlCon.Close()
                    sqlCmd.Dispose()
                Catch ex As Exception
                End Try
            End Try
            Return Id
        End Function

        Public Shared Function ObtenerIDRegistroXSedRowId_PopeHuellaInternoBD(strCNBD As String, NombreTabla As String, nomColPK As String, _sed_rowid As Integer,
                                                                              ByRef estadoError As Integer, ByRef outSMS As String) As Integer
            '*******************************************************************************************************************************************
            ' Verifica la existencia de registros por el _sed_rowid en la base de datos local, para determinar la accion de Insert o Update a ejecutarse.
            '*******************************************************************************************************************************************
            estadoError = 0
            Dim sqlReader As SqlDataReader = Nothing
            Dim Id As Integer = -1

            Dim sqlCon As SqlConnection = New SqlConnection(strCNBD)
            Dim sqlCmd As SqlCommand = Nothing

            Try
                Dim sql As String = ""
                sql = "select  " & nomColPK & " from " & NombreTabla & " where _sed_rowid=" & _sed_rowid
                sqlCmd = New SqlCommand(sql, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                sqlReader = sqlCmd.ExecuteReader
                If sqlReader.HasRows Then
                    Dim cantReg As Integer = 0
                    While sqlReader.Read
                        cantReg = cantReg + 1
                        Id = sqlReader(nomColPK)
                    End While
                    If cantReg > 1 Then
                        outSMS = "Al ejecutar la siguiente consulta (" & sql & ") ha devuelto mas de un registro en la base de datos local."
                        Id = -100
                        estadoError = -1
                    End If
                End If
            Catch ex As Exception
                outSMS = ex.ToString
                Id = -100
                estadoError = -1
            Finally
                Try
                    sqlReader.Close()
                    sqlCon.Close()
                    sqlCmd.Dispose()
                Catch ex As Exception
                End Try
            End Try
            Return Id
        End Function

        Public Shared Function EjecutarSentencia_PopeBD(SQL As String, ByRef estadoError As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "Business/UtilAccesoBD/EjecutarSentencia_PopeBD"
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlCmd As SqlCommand = Nothing
            Dim id As Integer = -1
            estadoError = 0
            Try
                sqlCmd = New SqlCommand(SQL, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = sqlCmd.ExecuteScalar()
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, ex.ToString)
                estadoError = -1
                outSMS = "Error al ejecutar funcion UscBajar/EjecutarSentencia: " & ex.Message & ", SQL:" & SQL
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
            End Try
            Return id
        End Function

        Public Shared Function EjecutarSentencia_PopeBD_v2(SQL As String, cmd As IDbCommand, ByRef estadoError As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "Business/UtilAccesoBD/EjecutarSentencia_PopeBD"
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            'Dim sqlCmd As SqlCommand = Nothinggh
            Dim id As Integer = -1
            estadoError = 0
            Try
                'cmd = New SqlCommand(SQL, sqlCon)
                cmd.CommandText = SQL
                cmd.Connection = sqlCon
                cmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, ex.ToString)
                estadoError = -1
                outSMS = "Error al ejecutar funcion UscBajar/EjecutarSentencia: " & ex.Message & ", SQL:" & SQL
            Finally
                sqlCon.Close()
                cmd.Dispose()
            End Try
            Return id
        End Function

        Public Shared Function EjecutarSentencia_PopeHuellaInternoBD(strCNBD As String, SQL As String, ByRef estadoError As Integer, ByRef outSMS As String) As Integer

            Dim sqlCon As SqlConnection = New SqlConnection(strCNBD)
            Dim sqlCmd As SqlCommand = Nothing
            Dim id As Integer = -1
            estadoError = 0
            Try
                sqlCmd = New SqlCommand(SQL, sqlCon)
                sqlCmd.CommandTimeout = 60 * 3 '3 minutos
                sqlCon.Open()
                id = sqlCmd.ExecuteScalar()
            Catch ex As Exception
                estadoError = -1
                outSMS = "Error al ejecutar funcion UscBajar/EjecutarSentencia: " & ex.Message & ", SQL:" & SQL
            Finally
                sqlCon.Close()
                sqlCmd.Dispose()
            End Try
            Return id
        End Function

        Public Shared Function Isnulll(strvalue As Object, strdefaultValue As Object) As Object

            Try
                If String.IsNullOrEmpty(strvalue) Then
                    Return strdefaultValue
                Else
                    Return strvalue
                End If
            Catch ex As Exception
                Return strdefaultValue
            End Try

        End Function

        Public Shared Function EjecutarProcedimientoAlmacenado(SQL As String, cmd As IDbCommand, ByRef estadoError As Integer, ByRef outSMS As String) As Integer
            Dim strLog As String = "Business/UtilAccesoBD/EjecutarProcedimientoAlmacenado"
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim id As Integer = -1
            estadoError = 0

            Try
                cmd.CommandText = SQL
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = sqlCon
                cmd.CommandTimeout = 60 * 3 ' 3 minutos
                sqlCon.Open()
                id = cmd.ExecuteScalar()
            Catch ex As Exception
                Type.LogSIP.getLog.Debug(strLog, ex.ToString)
                estadoError = -1
                outSMS = "Error al ejecutar procedimiento almacenado: " & ex.Message & ", SQL:" & SQL
            Finally
                sqlCon.Close()
                cmd.Dispose()
            End Try

            Return id
        End Function
#End Region
    End Class
End Namespace
