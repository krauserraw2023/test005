Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia
    Public Class PlanillaDetalle
        Private Shared strNameProcedure As String = "USP_tra_tal_planilla_det"
        Public Shared Function ListarOutput(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Try
                Dim Value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pla_det_id", SqlDbType.int)).Value = ObjEnt.Codigo
                            .Parameters.Add(New SqlParameter("@kf_pla_id", SqlDbType.int)).Value = ObjEnt.IDPlanilla
                            .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.int)).Value = ObjEnt.IDInterno
                            .Parameters.Add(New SqlParameter("@c_ape_nom", SqlDbType.varchar, 150)).Value = ObjEnt.ApellidosNombres
                            .Parameters.Add(New SqlParameter("@n_dia_01", SqlDbType.smallint)).Value = ObjEnt.Dia01
                            .Parameters.Add(New SqlParameter("@n_dia_02", SqlDbType.smallint)).Value = ObjEnt.Dia02
                            .Parameters.Add(New SqlParameter("@n_dia_03", SqlDbType.smallint)).Value = ObjEnt.Dia03
                            .Parameters.Add(New SqlParameter("@n_dia_04", SqlDbType.smallint)).Value = ObjEnt.Dia04
                            .Parameters.Add(New SqlParameter("@n_dia_05", SqlDbType.smallint)).Value = ObjEnt.Dia05
                            .Parameters.Add(New SqlParameter("@n_dia_06", SqlDbType.smallint)).Value = ObjEnt.Dia06
                            .Parameters.Add(New SqlParameter("@n_dia_07", SqlDbType.smallint)).Value = ObjEnt.Dia07
                            .Parameters.Add(New SqlParameter("@n_dia_08", SqlDbType.smallint)).Value = ObjEnt.Dia08
                            .Parameters.Add(New SqlParameter("@n_dia_09", SqlDbType.smallint)).Value = ObjEnt.Dia09
                            .Parameters.Add(New SqlParameter("@n_dia_10", SqlDbType.smallint)).Value = ObjEnt.Dia10
                            .Parameters.Add(New SqlParameter("@n_dia_11", SqlDbType.smallint)).Value = ObjEnt.Dia11
                            .Parameters.Add(New SqlParameter("@n_dia_12", SqlDbType.smallint)).Value = ObjEnt.Dia12
                            .Parameters.Add(New SqlParameter("@n_dia_13", SqlDbType.smallint)).Value = ObjEnt.Dia13
                            .Parameters.Add(New SqlParameter("@n_dia_14", SqlDbType.smallint)).Value = ObjEnt.Dia_14
                            .Parameters.Add(New SqlParameter("@n_dia_15", SqlDbType.smallint)).Value = ObjEnt.Dia_15
                            .Parameters.Add(New SqlParameter("@n_dia_16", SqlDbType.smallint)).Value = ObjEnt.Dia_16
                            .Parameters.Add(New SqlParameter("@n_dia_17", SqlDbType.smallint)).Value = ObjEnt.Dia_17
                            .Parameters.Add(New SqlParameter("@n_dia_18", SqlDbType.smallint)).Value = ObjEnt.Dia_18
                            .Parameters.Add(New SqlParameter("@n_dia_19", SqlDbType.smallint)).Value = ObjEnt.Dia_19
                            .Parameters.Add(New SqlParameter("@n_dia_20", SqlDbType.smallint)).Value = ObjEnt.Dia_20
                            .Parameters.Add(New SqlParameter("@n_dia_21", SqlDbType.smallint)).Value = ObjEnt.Dia_21
                            .Parameters.Add(New SqlParameter("@n_dia_22", SqlDbType.smallint)).Value = ObjEnt.Dia_22
                            .Parameters.Add(New SqlParameter("@n_dia_23", SqlDbType.smallint)).Value = ObjEnt.Dia_23
                            .Parameters.Add(New SqlParameter("@n_dia_24", SqlDbType.smallint)).Value = ObjEnt.Dia_24
                            .Parameters.Add(New SqlParameter("@n_dia_25", SqlDbType.smallint)).Value = ObjEnt.Dia_25
                            .Parameters.Add(New SqlParameter("@n_dia_26", SqlDbType.smallint)).Value = ObjEnt.Dia_26
                            .Parameters.Add(New SqlParameter("@n_dia_27", SqlDbType.smallint)).Value = ObjEnt.Dia_27
                            .Parameters.Add(New SqlParameter("@n_dia_28", SqlDbType.smallint)).Value = ObjEnt.Dia_28
                            .Parameters.Add(New SqlParameter("@n_dia_29", SqlDbType.smallint)).Value = ObjEnt.Dia_29
                            .Parameters.Add(New SqlParameter("@n_dia_30", SqlDbType.smallint)).Value = ObjEnt.Dia_30
                            .Parameters.Add(New SqlParameter("@n_dia_31", SqlDbType.smallint)).Value = ObjEnt.Dia_31
                            .Parameters.Add(New SqlParameter("@n_tot_dia", SqlDbType.smallint)).Value = ObjEnt.TotalDias
                            .Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.decimal)).Value = ObjEnt.IngresoTotal                            

                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            Value = .Parameters("@variable_out").Value
                            Return Value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Listar(ByVal sqlCon As SqlConnection, ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As SqlDataReader
            Dim sqlReader As SqlDataReader = Nothing
            Try
                sqlCon.Open()
                Dim sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                With sqlCmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                    .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                    .Parameters.Add(New SqlParameter("@pk_pla_det_id", SqlDbType.int)).Value = ObjEnt.Codigo
                    .Parameters.Add(New SqlParameter("@kf_pla_id", SqlDbType.int)).Value = ObjEnt.IDPlanilla
                    .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.int)).Value = ObjEnt.IDInterno
                    .Parameters.Add(New SqlParameter("@c_ape_nom", SqlDbType.varchar, 150)).Value = ObjEnt.ApellidosNombres
                    .Parameters.Add(New SqlParameter("@n_dia_01", SqlDbType.smallint)).Value = ObjEnt.Dia01
                    .Parameters.Add(New SqlParameter("@n_dia_02", SqlDbType.smallint)).Value = ObjEnt.Dia02
                    .Parameters.Add(New SqlParameter("@n_dia_03", SqlDbType.smallint)).Value = ObjEnt.Dia03
                    .Parameters.Add(New SqlParameter("@n_dia_04", SqlDbType.smallint)).Value = ObjEnt.Dia04
                    .Parameters.Add(New SqlParameter("@n_dia_05", SqlDbType.smallint)).Value = ObjEnt.Dia05
                    .Parameters.Add(New SqlParameter("@n_dia_06", SqlDbType.smallint)).Value = ObjEnt.Dia06
                    .Parameters.Add(New SqlParameter("@n_dia_07", SqlDbType.smallint)).Value = ObjEnt.Dia07
                    .Parameters.Add(New SqlParameter("@n_dia_08", SqlDbType.smallint)).Value = ObjEnt.Dia08
                    .Parameters.Add(New SqlParameter("@n_dia_09", SqlDbType.smallint)).Value = ObjEnt.Dia09
                    .Parameters.Add(New SqlParameter("@n_dia_10", SqlDbType.smallint)).Value = ObjEnt.Dia10
                    .Parameters.Add(New SqlParameter("@n_dia_11", SqlDbType.smallint)).Value = ObjEnt.Dia11
                    .Parameters.Add(New SqlParameter("@n_dia_12", SqlDbType.smallint)).Value = ObjEnt.Dia12
                    .Parameters.Add(New SqlParameter("@n_dia_13", SqlDbType.smallint)).Value = ObjEnt.Dia13
                    .Parameters.Add(New SqlParameter("@n_dia_14", SqlDbType.smallint)).Value = ObjEnt.Dia_14
                    .Parameters.Add(New SqlParameter("@n_dia_15", SqlDbType.smallint)).Value = ObjEnt.Dia_15
                    .Parameters.Add(New SqlParameter("@n_dia_16", SqlDbType.smallint)).Value = ObjEnt.Dia_16
                    .Parameters.Add(New SqlParameter("@n_dia_17", SqlDbType.smallint)).Value = ObjEnt.Dia_17
                    .Parameters.Add(New SqlParameter("@n_dia_18", SqlDbType.smallint)).Value = ObjEnt.Dia_18
                    .Parameters.Add(New SqlParameter("@n_dia_19", SqlDbType.smallint)).Value = ObjEnt.Dia_19
                    .Parameters.Add(New SqlParameter("@n_dia_20", SqlDbType.smallint)).Value = ObjEnt.Dia_20
                    .Parameters.Add(New SqlParameter("@n_dia_21", SqlDbType.smallint)).Value = ObjEnt.Dia_21
                    .Parameters.Add(New SqlParameter("@n_dia_22", SqlDbType.smallint)).Value = ObjEnt.Dia_22
                    .Parameters.Add(New SqlParameter("@n_dia_23", SqlDbType.smallint)).Value = ObjEnt.Dia_23
                    .Parameters.Add(New SqlParameter("@n_dia_24", SqlDbType.smallint)).Value = ObjEnt.Dia_24
                    .Parameters.Add(New SqlParameter("@n_dia_25", SqlDbType.smallint)).Value = ObjEnt.Dia_25
                    .Parameters.Add(New SqlParameter("@n_dia_26", SqlDbType.smallint)).Value = ObjEnt.Dia_26
                    .Parameters.Add(New SqlParameter("@n_dia_27", SqlDbType.smallint)).Value = ObjEnt.Dia_27
                    .Parameters.Add(New SqlParameter("@n_dia_28", SqlDbType.smallint)).Value = ObjEnt.Dia_28
                    .Parameters.Add(New SqlParameter("@n_dia_29", SqlDbType.smallint)).Value = ObjEnt.Dia_29
                    .Parameters.Add(New SqlParameter("@n_dia_30", SqlDbType.smallint)).Value = ObjEnt.Dia_30
                    .Parameters.Add(New SqlParameter("@n_dia_31", SqlDbType.smallint)).Value = ObjEnt.Dia_31
                    .Parameters.Add(New SqlParameter("@n_tot_dia", SqlDbType.smallint)).Value = ObjEnt.TotalDias
                    .Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.decimal)).Value = ObjEnt.IngresoTotal
                End With
                sqlReader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Throw New Exception(ex.Message)
            End Try
            Return sqlReader
        End Function
        Public Shared Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Try
                Dim value As Integer = -1
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pla_det_id", SqlDbType.int)).Value = ObjEnt.Codigo
                            .Parameters.Add(New SqlParameter("@kf_pla_id", SqlDbType.int)).Value = ObjEnt.IDPlanilla
                            .Parameters.Add(New SqlParameter("@kf_int_id", SqlDbType.int)).Value = ObjEnt.IDInterno
                            .Parameters.Add(New SqlParameter("@c_ape_nom", SqlDbType.varchar, 150)).Value = ObjEnt.ApellidosNombres
                            .Parameters.Add(New SqlParameter("@n_dia_01", SqlDbType.smallint)).Value = ObjEnt.Dia01
                            .Parameters.Add(New SqlParameter("@n_dia_02", SqlDbType.smallint)).Value = ObjEnt.Dia02
                            .Parameters.Add(New SqlParameter("@n_dia_03", SqlDbType.smallint)).Value = ObjEnt.Dia03
                            .Parameters.Add(New SqlParameter("@n_dia_04", SqlDbType.smallint)).Value = ObjEnt.Dia04
                            .Parameters.Add(New SqlParameter("@n_dia_05", SqlDbType.smallint)).Value = ObjEnt.Dia05
                            .Parameters.Add(New SqlParameter("@n_dia_06", SqlDbType.smallint)).Value = ObjEnt.Dia06
                            .Parameters.Add(New SqlParameter("@n_dia_07", SqlDbType.smallint)).Value = ObjEnt.Dia07
                            .Parameters.Add(New SqlParameter("@n_dia_08", SqlDbType.smallint)).Value = ObjEnt.Dia08
                            .Parameters.Add(New SqlParameter("@n_dia_09", SqlDbType.smallint)).Value = ObjEnt.Dia09
                            .Parameters.Add(New SqlParameter("@n_dia_10", SqlDbType.smallint)).Value = ObjEnt.Dia10
                            .Parameters.Add(New SqlParameter("@n_dia_11", SqlDbType.smallint)).Value = ObjEnt.Dia11
                            .Parameters.Add(New SqlParameter("@n_dia_12", SqlDbType.smallint)).Value = ObjEnt.Dia12
                            .Parameters.Add(New SqlParameter("@n_dia_13", SqlDbType.smallint)).Value = ObjEnt.Dia13
                            .Parameters.Add(New SqlParameter("@n_dia_14", SqlDbType.smallint)).Value = ObjEnt.Dia_14
                            .Parameters.Add(New SqlParameter("@n_dia_15", SqlDbType.smallint)).Value = ObjEnt.Dia_15
                            .Parameters.Add(New SqlParameter("@n_dia_16", SqlDbType.smallint)).Value = ObjEnt.Dia_16
                            .Parameters.Add(New SqlParameter("@n_dia_17", SqlDbType.smallint)).Value = ObjEnt.Dia_17
                            .Parameters.Add(New SqlParameter("@n_dia_18", SqlDbType.smallint)).Value = ObjEnt.Dia_18
                            .Parameters.Add(New SqlParameter("@n_dia_19", SqlDbType.smallint)).Value = ObjEnt.Dia_19
                            .Parameters.Add(New SqlParameter("@n_dia_20", SqlDbType.smallint)).Value = ObjEnt.Dia_20
                            .Parameters.Add(New SqlParameter("@n_dia_21", SqlDbType.smallint)).Value = ObjEnt.Dia_21
                            .Parameters.Add(New SqlParameter("@n_dia_22", SqlDbType.smallint)).Value = ObjEnt.Dia_22
                            .Parameters.Add(New SqlParameter("@n_dia_23", SqlDbType.smallint)).Value = ObjEnt.Dia_23
                            .Parameters.Add(New SqlParameter("@n_dia_24", SqlDbType.smallint)).Value = ObjEnt.Dia_24
                            .Parameters.Add(New SqlParameter("@n_dia_25", SqlDbType.smallint)).Value = ObjEnt.Dia_25
                            .Parameters.Add(New SqlParameter("@n_dia_26", SqlDbType.smallint)).Value = ObjEnt.Dia_26
                            .Parameters.Add(New SqlParameter("@n_dia_27", SqlDbType.smallint)).Value = ObjEnt.Dia_27
                            .Parameters.Add(New SqlParameter("@n_dia_28", SqlDbType.smallint)).Value = ObjEnt.Dia_28
                            .Parameters.Add(New SqlParameter("@n_dia_29", SqlDbType.smallint)).Value = ObjEnt.Dia_29
                            .Parameters.Add(New SqlParameter("@n_dia_30", SqlDbType.smallint)).Value = ObjEnt.Dia_30
                            .Parameters.Add(New SqlParameter("@n_dia_31", SqlDbType.smallint)).Value = ObjEnt.Dia_31
                            .Parameters.Add(New SqlParameter("@n_tot_dia", SqlDbType.smallint)).Value = ObjEnt.TotalDias
                            .Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.Decimal)).Value = objEnt.IngresoTotal
                            '.Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.Int)).Value = objEnt.MotivoRetiroID
                            '.Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.BigInt)).Value = objEnt.FechaIniRetiro
                            '.Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.VarChar, 100)).Value = objEnt.NumeroDocumento
                            '.Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.BigInt)).Value = objEnt.FechaFinRetiro
                            '.Parameters.Add(New SqlParameter("@n_ing_tot", SqlDbType.VarChar, 250)).Value = objEnt.Observacion
                            .Parameters.Add(New SqlParameter("@_reg_id", SqlDbType.Int)).Value = objEnt.RegionID
                            .Parameters.Add(New SqlParameter("@_penid", SqlDbType.Int)).Value = objEnt.PenalID
                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
                        End With
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception(ex.Message)
                Return -1
            End Try
        End Function
        Public Shared Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Dim value As Integer = -1
            Try
                Using sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                    Using sqlCmd As SqlCommand = New SqlCommand(strNameProcedure, sqlCon)
                        With sqlCmd
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Add(New SqlParameter("@accion", SqlDbType.VarChar, 3)).Value = accion
                            .Parameters.Add(New SqlParameter("@opcion", SqlDbType.VarChar, 120)).Value = opcion
                            .Parameters.Add(New SqlParameter("@pk_pla_det_id", SqlDbType.int)).Value = objEnt.Codigo

                            .Parameters.Add(New SqlParameter("@_usuario", SqlDbType.Int)).Value = objEnt.Audit_UsuarioID
                            .Parameters.Add(New SqlParameter("@_fecha", SqlDbType.BigInt)).Value = Now.ToFileTime
                            .Parameters.Add(New SqlParameter("@variable_out", SqlDbType.int))
                            .Parameters("@variable_out").Direction = ParameterDirection.Output
                            sqlCon.Open()
                            .ExecuteNonQuery()
                            value = .Parameters("@variable_out").Value
                            Return value
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