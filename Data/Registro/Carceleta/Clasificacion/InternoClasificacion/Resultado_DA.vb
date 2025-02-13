Imports System.Data
Imports System.Data.SqlClient
Namespace Registro.Carceleta.Clasificacion.InternoClasificacion
    Public Class Resultado_DA
        Private Shared strNameProcedure As String = "UP_INT_internoClasificacionResultado"
        'Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
        'ByVal InternoClasificacionID As Integer,
        'ByVal InternoClasificacionFichaId As Integer,
        'ByVal InternoID As Integer,
        'ByVal IngresoID As Integer,
        'ByVal FichaID As Integer,
        'ByVal VariableId As Integer,
        'ByVal Secuencia As Integer,
        'ByVal VariableNombre As String,
        'ByVal VariableDescripcion As String,
        'ByVal ValorId As Integer,
        'ByVal ValorDescripcion As String,
        'ByVal ValorNota As Decimal
        ') As Integer
        '    Try
        '        Dim intValue As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@int_cla_res_id", SqlDbType.Int)).Value = Codigo
        '                    .Parameters.Add(New SqlParameter("@int_cla_id", SqlDbType.Int)).Value = InternoClasificacionID
        '                    .Parameters.Add(New SqlParameter("@int_cla_fic_id", SqlDbType.Int)).Value = InternoClasificacionFichaId
        '                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
        '                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
        '                    .Parameters.Add(New SqlParameter("@fic_id", SqlDbType.Int)).Value = FichaID
        '                    .Parameters.Add(New SqlParameter("@var_id", SqlDbType.Int)).Value = VariableId
        '                    .Parameters.Add(New SqlParameter("@var_sec", SqlDbType.Int)).Value = Secuencia
        '                    .Parameters.Add(New SqlParameter("@var_nom", SqlDbType.VarChar, 100)).Value = VariableNombre
        '                    .Parameters.Add(New SqlParameter("@var_des", SqlDbType.VarChar, 250)).Value = VariableDescripcion
        '                    .Parameters.Add(New SqlParameter("@val_id", SqlDbType.Int)).Value = ValorId
        '                    .Parameters.Add(New SqlParameter("@val_des", SqlDbType.VarChar, 250)).Value = ValorDescripcion
        '                    .Parameters.Add(New SqlParameter("@val_not", SqlDbType.Decimal)).Value = ValorNota

        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    intValue = .Parameters("@variable_out").Value
        '                    Return intValue
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function
        'Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
        'ByVal InternoClasificacionID As Integer,
        'ByVal InternoClasificacionFichaId As Integer,
        'ByVal InternoID As Integer,
        'ByVal IngresoID As Integer,
        'ByVal FichaID As Integer,
        'ByVal VariableId As Integer,
        'ByVal Secuencia As Integer,
        'ByVal VariableNombre As String,
        'ByVal VariableDescripcion As String,
        'ByVal ValorId As Integer,
        'ByVal ValorDescripcion As String,
        'ByVal ValorNota As Decimal
        ') As SqlDataReader
        '    Dim sqlReader As SqlDataReader = Nothing
        '    Try
        '        sqlCon.Open()
        '        Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '        With sqlCmd
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandTimeout = 240 '4 min
        '            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '            .Parameters.Add(New SqlParameter("@int_cla_res_id", SqlDbType.Int)).Value = Codigo
        '            .Parameters.Add(New SqlParameter("@int_cla_id", SqlDbType.Int)).Value = InternoClasificacionID
        '            .Parameters.Add(New SqlParameter("@int_cla_fic_id", SqlDbType.Int)).Value = InternoClasificacionFichaId
        '            .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
        '            .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
        '            .Parameters.Add(New SqlParameter("@fic_id", SqlDbType.Int)).Value = FichaID
        '            .Parameters.Add(New SqlParameter("@var_id", SqlDbType.Int)).Value = VariableId
        '            .Parameters.Add(New SqlParameter("@var_sec", SqlDbType.Int)).Value = Secuencia
        '            .Parameters.Add(New SqlParameter("@var_nom", SqlDbType.VarChar, 100)).Value = VariableNombre
        '            .Parameters.Add(New SqlParameter("@var_des", SqlDbType.VarChar, 250)).Value = VariableDescripcion
        '            .Parameters.Add(New SqlParameter("@val_id", SqlDbType.Int)).Value = ValorId
        '            .Parameters.Add(New SqlParameter("@val_des", SqlDbType.VarChar, 250)).Value = ValorDescripcion
        '            .Parameters.Add(New SqlParameter("@val_not", SqlDbType.Decimal)).Value = ValorNota
        '        End With
        '        sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
        '    Catch ex As SqlException
        '        Throw New Exception(ex.Message)
        '    End Try
        '    Return sqlReader
        'End Function

        'Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer,
        'ByVal InternoClasificacionID As Integer,
        'ByVal InternoClasificacionFichaId As Integer,
        'ByVal InternoID As Integer,
        'ByVal IngresoID As Integer,
        'ByVal FichaID As Integer,
        'ByVal VariableId As Integer,
        'ByVal Secuencia As Integer,
        'ByVal VariableNombre As String,
        'ByVal VariableDescripcion As String,
        'ByVal ValorId As Integer,
        'ByVal ValorDescripcion As String,
        'ByVal ValorNota As Decimal,
        'ByVal Usuario As Integer) As Integer
        '    Try
        '        Dim intCodigo As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@int_cla_res_id", SqlDbType.Int)).Value = Codigo
        '                    .Parameters.Add(New SqlParameter("@int_cla_id", SqlDbType.Int)).Value = InternoClasificacionID
        '                    .Parameters.Add(New SqlParameter("@int_cla_fic_id", SqlDbType.Int)).Value = InternoClasificacionFichaId
        '                    .Parameters.Add(New SqlParameter("@int_id", SqlDbType.Int)).Value = InternoID
        '                    .Parameters.Add(New SqlParameter("@int_ing_id", SqlDbType.Int)).Value = IngresoID
        '                    .Parameters.Add(New SqlParameter("@fic_id", SqlDbType.Int)).Value = FichaID
        '                    .Parameters.Add(New SqlParameter("@var_id", SqlDbType.Int)).Value = VariableId
        '                    .Parameters.Add(New SqlParameter("@var_sec", SqlDbType.Int)).Value = Secuencia
        '                    .Parameters.Add(New SqlParameter("@var_nom", SqlDbType.VarChar, 100)).Value = VariableNombre
        '                    .Parameters.Add(New SqlParameter("@var_des", SqlDbType.VarChar, 250)).Value = VariableDescripcion
        '                    .Parameters.Add(New SqlParameter("@val_id", SqlDbType.Int)).Value = ValorId
        '                    .Parameters.Add(New SqlParameter("@val_des", SqlDbType.VarChar, 250)).Value = ValorDescripcion
        '                    .Parameters.Add(New SqlParameter("@val_not", SqlDbType.Decimal)).Value = ValorNota

        '                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
        '                    .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    intCodigo = .Parameters("@variable_out").Value
        '                    Return intCodigo
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function

        'Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
        '    Try
        '        Dim intCodigo As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@int_cla_res_id", SqlDbType.Int)).Value = Codigo

        '                    .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = Usuario
        '                    .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
        '                    .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.Int))
        '                    .Parameters("@variable_out").Direction = ParameterDirection.Output
        '                    sqlCon.Open()
        '                    .ExecuteNonQuery()
        '                    intCodigo = .Parameters("@variable_out").Value
        '                    Return intCodigo
        '                End With
        '            End Using
        '        End Using
        '    Catch ex As Exception
        '        Throw New Exception(ex.Message)
        '        Return -1
        '    End Try
        'End Function
    End Class
End Namespace
