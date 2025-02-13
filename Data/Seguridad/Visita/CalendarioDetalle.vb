Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class CalendarioDetalle
        Private Shared strNameProcedure As String = "UP_VIS_CalendarioDetalle"
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal CalendarioId As Integer, _
        ByVal Tipo As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaDesdeDia As Integer, _
        ByVal FechaDesdeMes As Integer, _
        ByVal FechaDesdeAnio As Integer, _
        ByVal FechaHasta As Long, _
        ByVal FechaHastaDia As Integer, _
        ByVal FechaHastaMes As Integer, _
        ByVal FechaHastaAnio As Integer, _
        ByVal HoraDesde As Integer, _
        ByVal HoraHasta As Integer, _
        ByVal Sexo As Integer, _
        ByVal Menores As Boolean, _
        ByVal Lunes As Boolean, _
        ByVal Martes As Boolean, _
        ByVal Miercoles As Boolean, _
        ByVal Jueves As Boolean, _
        ByVal Viernes As Boolean, _
        ByVal Sabado As Boolean, _
        ByVal Domingo As Boolean _
        ) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = Codigo
                    .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = Tipo
                    .Parameters.Add(New SqlParameter("@cal_det_fec_dsd", SqlDbType.BigInt)).Value = FechaDesde
                    .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_dia", SqlDbType.Int)).Value = FechaDesdeDia
                    .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_mes", SqlDbType.Int)).Value = FechaDesdeMes
                    .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_anio", SqlDbType.Int)).Value = FechaDesdeAnio
                    .Parameters.Add(New SqlParameter("@cal_det_fec_hst", SqlDbType.BigInt)).Value = FechaHasta
                    .Parameters.Add(New SqlParameter("@cal_det_fec_hst_dia", SqlDbType.Int)).Value = FechaHastaDia
                    .Parameters.Add(New SqlParameter("@cal_det_fec_hst_mes", SqlDbType.Int)).Value = FechaHastaMes
                    .Parameters.Add(New SqlParameter("@cal_det_fec_jst_anio", SqlDbType.Int)).Value = FechaHastaAnio
                    .Parameters.Add(New SqlParameter("@cal_det_hor_dsd", SqlDbType.Int)).Value = HoraDesde
                    .Parameters.Add(New SqlParameter("@cal_det_hor_hst", SqlDbType.Int)).Value = HoraHasta
                    .Parameters.Add(New SqlParameter("@cal_det_sex", SqlDbType.Int)).Value = Sexo
                    .Parameters.Add(New SqlParameter("@cal_det_men", SqlDbType.Bit)).Value = Menores
                    .Parameters.Add(New SqlParameter("@cal_det_lun", SqlDbType.Bit)).Value = Lunes
                    .Parameters.Add(New SqlParameter("@cal_det_mar", SqlDbType.Bit)).Value = Martes
                    .Parameters.Add(New SqlParameter("@cal_det_mir", SqlDbType.Bit)).Value = Miercoles
                    .Parameters.Add(New SqlParameter("@cal_det_jue", SqlDbType.Bit)).Value = Jueves
                    .Parameters.Add(New SqlParameter("@cal_det_vie", SqlDbType.Bit)).Value = Viernes
                    .Parameters.Add(New SqlParameter("@cal_det_sab", SqlDbType.Bit)).Value = Sabado
                    .Parameters.Add(New SqlParameter("@cal_det_dom", SqlDbType.Bit)).Value = Domingo
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal CalendarioId As Integer, _
        ByVal Tipo As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaDesdeDia As Integer, _
        ByVal FechaDesdeMes As Integer, _
        ByVal FechaDesdeAnio As Integer, _
        ByVal FechaHasta As Long, _
        ByVal FechaHastaDia As Integer, _
        ByVal FechaHastaMes As Integer, _
        ByVal FechaHastaAnio As Integer, _
        ByVal HoraDesde As Integer, _
        ByVal HoraHasta As Integer, _
        ByVal Sexo As Integer, _
        ByVal Menores As Boolean, _
        ByVal Lunes As Boolean, _
        ByVal Martes As Boolean, _
        ByVal Miercoles As Boolean, _
        ByVal Jueves As Boolean, _
        ByVal Viernes As Boolean, _
        ByVal Sabado As Boolean, _
        ByVal Domingo As Boolean, _
        ByVal Penal As Integer, ByVal region As Integer _
        ) As Integer
            Try
                Dim intValue As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = Tipo
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd", SqlDbType.BigInt)).Value = FechaDesde
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_dia", SqlDbType.Int)).Value = FechaDesdeDia
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_mes", SqlDbType.Int)).Value = FechaDesdeMes
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_anio", SqlDbType.Int)).Value = FechaDesdeAnio
                            .Parameters.Add(New SqlParameter("@cal_det_fec_hst", SqlDbType.BigInt)).Value = FechaHasta
                            .Parameters.Add(New SqlParameter("@cal_det_fec_hst_dia", SqlDbType.Int)).Value = FechaHastaDia
                            .Parameters.Add(New SqlParameter("@cal_det_fec_hst_mes", SqlDbType.Int)).Value = FechaHastaMes
                            .Parameters.Add(New SqlParameter("@cal_det_fec_jst_anio", SqlDbType.Int)).Value = FechaHastaAnio
                            .Parameters.Add(New SqlParameter("@cal_det_hor_dsd", SqlDbType.Int)).Value = HoraDesde
                            .Parameters.Add(New SqlParameter("@cal_det_hor_hst", SqlDbType.Int)).Value = HoraHasta
                            .Parameters.Add(New SqlParameter("@cal_det_sex", SqlDbType.Int)).Value = Sexo
                            .Parameters.Add(New SqlParameter("@cal_det_men", SqlDbType.Bit)).Value = Menores
                            .Parameters.Add(New SqlParameter("@cal_det_lun", SqlDbType.Bit)).Value = Lunes
                            .Parameters.Add(New SqlParameter("@cal_det_mar", SqlDbType.Bit)).Value = Martes
                            .Parameters.Add(New SqlParameter("@cal_det_mir", SqlDbType.Bit)).Value = Miercoles
                            .Parameters.Add(New SqlParameter("@cal_det_jue", SqlDbType.Bit)).Value = Jueves
                            .Parameters.Add(New SqlParameter("@cal_det_vie", SqlDbType.Bit)).Value = Viernes
                            .Parameters.Add(New SqlParameter("@cal_det_sab", SqlDbType.Bit)).Value = Sabado
                            .Parameters.Add(New SqlParameter("@cal_det_dom", SqlDbType.Bit)).Value = Domingo

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
        ByVal CalendarioId As Integer, _
        ByVal Tipo As Integer, _
        ByVal FechaDesde As Long, _
        ByVal FechaDesdeDia As Integer, _
        ByVal FechaDesdeMes As Integer, _
        ByVal FechaDesdeAnio As Integer, _
        ByVal FechaHasta As Long, _
        ByVal FechaHastaDia As Integer, _
        ByVal FechaHastaMes As Integer, _
        ByVal FechaHastaAnio As Integer, _
        ByVal HoraDesde As Integer, _
        ByVal HoraHasta As Integer, _
        ByVal Sexo As Integer, _
        ByVal Menores As Boolean, _
        ByVal Lunes As Boolean, _
        ByVal Martes As Boolean, _
        ByVal Miercoles As Boolean, _
        ByVal Jueves As Boolean, _
        ByVal Viernes As Boolean, _
        ByVal Sabado As Boolean, _
        ByVal Domingo As Boolean, _
        ByVal Estado As Integer, _
      ByVal Regionid As Integer, ByVal Penalid As Integer, _
        ByVal Usuario As Integer) As Integer
            Try
                Dim intCodigo As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = Codigo
                            .Parameters.Add(New SqlParameter("@tip_id", SqlDbType.Int)).Value = Tipo
                            .Parameters.Add(New SqlParameter("@cal_tip_id", SqlDbType.BigInt)).Value = CalendarioId
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd", SqlDbType.BigInt)).Value = FechaDesde
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_dia", SqlDbType.Int)).Value = FechaDesdeDia
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_mes", SqlDbType.Int)).Value = FechaDesdeMes
                            .Parameters.Add(New SqlParameter("@cal_det_fec_dsd_anio", SqlDbType.Int)).Value = FechaDesdeAnio
                            .Parameters.Add(New SqlParameter("@cal_det_fec_hst", SqlDbType.BigInt)).Value = FechaHasta
                            .Parameters.Add(New SqlParameter("@cal_det_fec_hst_dia", SqlDbType.Int)).Value = FechaHastaDia
                            .Parameters.Add(New SqlParameter("@cal_det_fec_hst_mes", SqlDbType.Int)).Value = FechaHastaMes
                            .Parameters.Add(New SqlParameter("@cal_det_fec_jst_anio", SqlDbType.Int)).Value = FechaHastaAnio
                            .Parameters.Add(New SqlParameter("@cal_det_hor_dsd", SqlDbType.Int)).Value = HoraDesde
                            .Parameters.Add(New SqlParameter("@cal_det_hor_hst", SqlDbType.Int)).Value = HoraHasta
                            .Parameters.Add(New SqlParameter("@cal_det_sex", SqlDbType.Int)).Value = Sexo
                            .Parameters.Add(New SqlParameter("@cal_det_men", SqlDbType.Bit)).Value = Menores
                            .Parameters.Add(New SqlParameter("@cal_det_lun", SqlDbType.Bit)).Value = Lunes
                            .Parameters.Add(New SqlParameter("@cal_det_mar", SqlDbType.Bit)).Value = Martes
                            .Parameters.Add(New SqlParameter("@cal_det_mir", SqlDbType.Bit)).Value = Miercoles
                            .Parameters.Add(New SqlParameter("@cal_det_jue", SqlDbType.Bit)).Value = Jueves
                            .Parameters.Add(New SqlParameter("@cal_det_vie", SqlDbType.Bit)).Value = Viernes
                            .Parameters.Add(New SqlParameter("@cal_det_sab", SqlDbType.Bit)).Value = Sabado
                            .Parameters.Add(New SqlParameter("@cal_det_dom", SqlDbType.Bit)).Value = Domingo

                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = Penalid
                            .Parameters.Add(New SqlParameter("@_regid", SqlDbType.Int)).Value = Regionid


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
                            .Parameters.Add(New SqlParameter("@cal_det_id", SqlDbType.Int)).Value = Codigo

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