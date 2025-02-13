Imports System.Data
Imports System.Data.SqlClient
Namespace Tratamiento.TallerAsistencia
    Public Class PlanillaDetalle
        Private objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle = Nothing
        Private objEntCol As Entity.Tratamiento.TallerAsistencia.PlanillaDetalleCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.PlanillaDetalle.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_pla_det_id").ToString
                            .IDPlanilla = sqlDr("kf_pla_id").ToString
                            .IDInterno = sqlDr("kf_int_id").ToString
                            .ApellidosNombres = sqlDr("c_ape_nom").ToString
                            .Dia01 = sqlDr("n_dia_01").ToString
                            .Dia02 = sqlDr("n_dia_02").ToString
                            .Dia03 = sqlDr("n_dia_03").ToString
                            .Dia04 = sqlDr("n_dia_04").ToString
                            .Dia05 = sqlDr("n_dia_05").ToString
                            .Dia06 = sqlDr("n_dia_06").ToString
                            .Dia07 = sqlDr("n_dia_07").ToString
                            .Dia08 = sqlDr("n_dia_08").ToString
                            .Dia09 = sqlDr("n_dia_09").ToString
                            .Dia10 = sqlDr("n_dia_10").ToString
                            .Dia11 = sqlDr("n_dia_11").ToString
                            .Dia12 = sqlDr("n_dia_12").ToString
                            .Dia13 = sqlDr("n_dia_13").ToString
                            .Dia_14 = sqlDr("n_dia_14").ToString
                            .Dia_15 = sqlDr("n_dia_15").ToString
                            .Dia_16 = sqlDr("n_dia_16").ToString
                            .Dia_17 = sqlDr("n_dia_17").ToString
                            .Dia_18 = sqlDr("n_dia_18").ToString
                            .Dia_19 = sqlDr("n_dia_19").ToString
                            .Dia_20 = sqlDr("n_dia_20").ToString
                            .Dia_21 = sqlDr("n_dia_21").ToString
                            .Dia_22 = sqlDr("n_dia_22").ToString
                            .Dia_23 = sqlDr("n_dia_23").ToString
                            .Dia_24 = sqlDr("n_dia_24").ToString
                            .Dia_25 = sqlDr("n_dia_25").ToString
                            .Dia_26 = sqlDr("n_dia_26").ToString
                            .Dia_27 = sqlDr("n_dia_27").ToString
                            .Dia_28 = sqlDr("n_dia_28").ToString
                            .Dia_29 = sqlDr("n_dia_29").ToString
                            .Dia_30 = sqlDr("n_dia_30").ToString
                            .Dia_31 = sqlDr("n_dia_31").ToString
                            .TotalDias = sqlDr("n_tot_dia").ToString
                            .IngresoTotal = sqlDr("n_ing_tot").ToString                         
                        End With
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEnt
        End Function
        Public Function Listar(ByVal objEntFiltro As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Entity.Tratamiento.TallerAsistencia.PlanillaDetalleCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.TallerAsistencia.PlanillaDetalle.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try
                objEntCol = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.TallerAsistencia.PlanillaDetalle
                        With objEnt
                            .Codigo = sqlDr("pk_pla_det_id").ToString
                            .IDPlanilla = sqlDr("kf_pla_id").ToString
                            .IDInterno = sqlDr("kf_int_id").ToString
                            .ApellidosNombres = sqlDr("c_ape_nom").ToString
                            .Dia01 = sqlDr("n_dia_01").ToString
                            .Dia02 = sqlDr("n_dia_02").ToString
                            .Dia03 = sqlDr("n_dia_03").ToString
                            .Dia04 = sqlDr("n_dia_04").ToString
                            .Dia05 = sqlDr("n_dia_05").ToString
                            .Dia06 = sqlDr("n_dia_06").ToString
                            .Dia07 = sqlDr("n_dia_07").ToString
                            .Dia08 = sqlDr("n_dia_08").ToString
                            .Dia09 = sqlDr("n_dia_09").ToString
                            .Dia10 = sqlDr("n_dia_10").ToString
                            .Dia11 = sqlDr("n_dia_11").ToString
                            .Dia12 = sqlDr("n_dia_12").ToString
                            .Dia13 = sqlDr("n_dia_13").ToString
                            .Dia_14 = sqlDr("n_dia_14").ToString
                            .Dia_15 = sqlDr("n_dia_15").ToString
                            .Dia_16 = sqlDr("n_dia_16").ToString
                            .Dia_17 = sqlDr("n_dia_17").ToString
                            .Dia_18 = sqlDr("n_dia_18").ToString
                            .Dia_19 = sqlDr("n_dia_19").ToString
                            .Dia_20 = sqlDr("n_dia_20").ToString
                            .Dia_21 = sqlDr("n_dia_21").ToString
                            .Dia_22 = sqlDr("n_dia_22").ToString
                            .Dia_23 = sqlDr("n_dia_23").ToString
                            .Dia_24 = sqlDr("n_dia_24").ToString
                            .Dia_25 = sqlDr("n_dia_25").ToString
                            .Dia_26 = sqlDr("n_dia_26").ToString
                            .Dia_27 = sqlDr("n_dia_27").ToString
                            .Dia_28 = sqlDr("n_dia_28").ToString
                            .Dia_29 = sqlDr("n_dia_29").ToString
                            .Dia_30 = sqlDr("n_dia_30").ToString
                            .Dia_31 = sqlDr("n_dia_31").ToString
                            .TotalDias = sqlDr("n_tot_dia").ToString
                            .IngresoTotal = sqlDr("n_ing_tot").ToString
                      
                        End With
                        objEntCol.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Dispose()
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return objEntCol
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With
            Value = Data.Tratamiento.TallerAsistencia.PlanillaDetalle.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function Grabar_Monto(ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_monto"

            Value = Data.Tratamiento.TallerAsistencia.PlanillaDetalle.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function

        Public Function Grabar_Estado(ByVal objEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "upd"
            strOpcion = "upd_mant_estado"

            Value = Data.Tratamiento.TallerAsistencia.PlanillaDetalle.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Tratamiento.TallerAsistencia.PlanillaDetalle) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Tratamiento.TallerAsistencia.PlanillaDetalle.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace
