Imports System.Data
Imports System.Data.SqlClient
Namespace General
    Public Class Penal
        Private Shared strNameProcedure As String = "UP_INT_Penal"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal IDPenal As Integer) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@PEN_ID", SqlDbType.Int)).Value = IDPenal
                            
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
        ByVal opcion As String, ByVal Codigo As Integer, ByVal CodigoPenal As String, _
        ByVal Nombre As String, ByVal RegionID As Integer, ByVal PenalTipo As Integer, _
        ByVal PenalTipoString As String) As SqlDataReader

            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@pen_cod", SqlDbType.VarChar, 5)).Value = CodigoPenal

                    .Parameters.Add(New SqlParameter("@pen_nom", SqlDbType.VarChar, 200)).Value = Nombre
                    '.Parameters.Add(New SqlParameter("@PEN_UBI", SqlDbType.VarChar, 8)).Value = Ubigeo
                    '.Parameters.Add(New SqlParameter("@REG_COD", SqlDbType.VarChar, 3)).Value = RegionRP
                    '.Parameters.Add(New SqlParameter("@PEN_EST", SqlDbType.Int)).Value = Estado
                    '.Parameters.Add(New SqlParameter("@PEN_NOM_COR", SqlDbType.VarChar, 100)).Value = NombreCorto
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
                    .Parameters.Add(New SqlParameter("@pen_tip", SqlDbType.Int)).Value = PenalTipo
                    .Parameters.Add(New SqlParameter("@pen_tip_str", SqlDbType.VarChar, 50)).Value = PenalTipoString
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        'Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        'ByVal CodigoString As String, ByVal Tipo As Integer, _
        'ByVal Nombre As String, _
        'ByVal NombreCorto As String, _
        'ByVal Ubigeo As String, ByVal UbigeoID As Integer, _
        'ByVal RegionCodigo As String, _
        'ByVal Estado As Integer, ByVal Domicilio As String, ByVal Telefono As String, _
        'ByVal RegionID As Integer, ByVal LicenciaNombre As String, ByVal FechaInstalacion As Long, _
        'ByVal CantidadInternos As Integer, ByVal CantidadProcesados As Integer, _
        'ByVal CantidadSentenciados As Integer, _
        'ByVal CantidadMixtos As Integer, ByVal LicenciaID As Integer, ByVal Capacidad As Integer, _
        'ByVal _Eliminado As Boolean, ByVal Usuario As Integer) As Integer

        '    Try
        '        Dim intCodigo As Integer = -1
        '        Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
        '            Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
        '                With sqlCmd
        '                    .CommandType = CommandType.StoredProcedure
        '                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
        '                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
        '                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = Codigo
        '                    .Parameters.Add(New SqlParameter("@PEN_COD", SqlDbType.VarChar, 5)).Value = CodigoString
        '                    .Parameters.Add(New SqlParameter("@PEN_tip", SqlDbType.Int)).Value = Tipo
        '                    .Parameters.Add(New SqlParameter("@PEN_NOM", SqlDbType.VarChar, 200)).Value = Nombre
        '                    .Parameters.Add(New SqlParameter("@PEN_NOM_COR", SqlDbType.VarChar, 100)).Value = NombreCorto
        '                    .Parameters.Add(New SqlParameter("@PEN_UBI", SqlDbType.VarChar, 8)).Value = Ubigeo
        '                    .Parameters.Add(New SqlParameter("@ubg_id", SqlDbType.Int)).Value = UbigeoID
        '                    .Parameters.Add(New SqlParameter("@REG_COD", SqlDbType.VarChar, 3)).Value = RegionCodigo
        '                    .Parameters.Add(New SqlParameter("@PEN_EST", SqlDbType.Int)).Value = Estado
        '                    .Parameters.Add(New SqlParameter("@pen_dom", SqlDbType.VarChar, 100)).Value = Domicilio
        '                    .Parameters.Add(New SqlParameter("@pen_tel", SqlDbType.VarChar, 10)).Value = Telefono
        '                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = RegionID
        '                    .Parameters.Add(New SqlParameter("@pen_lic_nom", SqlDbType.VarChar, 100)).Value = LicenciaNombre
        '                    .Parameters.Add(New SqlParameter("@pen_fec_ins", SqlDbType.BigInt)).Value = FechaInstalacion
        '                    .Parameters.Add(New SqlParameter("@pen_int", SqlDbType.Int)).Value = CantidadInternos
        '                    .Parameters.Add(New SqlParameter("@pen_pro", SqlDbType.Int)).Value = CantidadProcesados
        '                    .Parameters.Add(New SqlParameter("@pen_sen", SqlDbType.Int)).Value = CantidadSentenciados
        '                    .Parameters.Add(New SqlParameter("@pen_mix", SqlDbType.Int)).Value = CantidadMixtos
        '                    .Parameters.Add(New SqlParameter("@ins_id", SqlDbType.Int)).Value = LicenciaID
        '                    .Parameters.Add(New SqlParameter("@pen_cap", SqlDbType.Int)).Value = Capacidad
        '                    .Parameters.Add(New SqlParameter("@_flg_eli", SqlDbType.Bit)).Value = _Eliminado

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

        Shared Function Listar(sqlCon As SqlConnection, accion As String, opcion As String, ent As Entity.General.Penal) As SqlDataReader
            Dim sqlDr As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pen_id", SqlDbType.Int)).Value = ent.Codigo
                    .Parameters.Add(New SqlParameter("@reg_id", SqlDbType.Int)).Value = ent.RegionID
                End With
                sqlDr = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlDr
        End Function

    End Class
End Namespace



