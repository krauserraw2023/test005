Imports System.Data.SqlClient

Namespace Reporte
    Public Class ReporteCabecera
        Public Function ListarGrilla(TipoReporteId As Integer, InternoId As Integer, IngresoId As Integer) As Entity.Reporte.ReporteCabeceraCol
            Dim list As New Entity.Reporte.ReporteCabeceraCol
            Dim objEnt As New Entity.Reporte.ReporteCabecera
            Dim cont As Integer = 0

            objEnt.TipoReporteId = TipoReporteId
            objEnt.InternoId = InternoId
            objEnt.InternoIngresoId = IngresoId

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.ReporteCabecera.Listar(sqlCon, "lst", "lst_grilla", objEnt)
            'd
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.ReporteCabecera
                        With objEnt
                            .Codigo = sqlDr("pk_rpt_cab_id").ToString
                            .InternoId = sqlDr("int_id").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .CodigoReporteId = sqlDr("fk_rpt_id").ToString
                            .CodigoPenal = sqlDr("cod_pen").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .NumSerie = sqlDr("n_num").ToString
                            .NumeroImpresion = sqlDr("n_num_print")
                            .FechaEmision = sqlDr("n_fec_emi").ToString
                            .CodigoId = sqlDr("fk_rpt_cab_id").ToString
                            .MotivoAnulacion = sqlDr("c_mot_anu").ToString
                            .Estado = sqlDr("n_est_id").ToString
                            .RegionId = sqlDr("_regId").ToString
                            .PenalId = sqlDr("_penId").ToString
                            .NombreReporte = sqlDr("rpt_nom").ToString
                            .TotalImpresiones = sqlDr("tot_print").ToString
                            cont = cont + 1
                            .NumOrden = cont
                        End With
                        list.Add(objEnt)
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

            Return list
        End Function

        Public Function ListarGrillaImpresiones(CabeceraReporteId As Integer) As Entity.Reporte.ReporteCabeceraCol
            Dim list As New Entity.Reporte.ReporteCabeceraCol
            Dim objEnt As New Entity.Reporte.ReporteCabecera
            objEnt.CodigoId = CabeceraReporteId
            
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.ReporteCabecera.Listar(sqlCon, "lst", "lst_grilla_impresiones", objEnt)

            Dim cont As Integer = 0
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.ReporteCabecera
                        With objEnt
                            .Codigo = sqlDr("pk_rpt_cab_id").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .NumSerie = sqlDr("n_num").ToString
                            .NumeroImpresion = sqlDr("n_num_print").ToString
                            .FechaEmision = sqlDr("n_fec_emi").ToString
                            .RegionId = sqlDr("_regId").ToString
                            .PenalId = sqlDr("_penId").ToString
                            .LoginUsuario = sqlDr("usu_log").ToString
                            cont = cont + 1
                            .NumOrden = cont
                        End With
                        list.Add(objEnt)
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

            Return list
        End Function

        Public Function Listar(Codigo As Integer) As Entity.Reporte.ReporteCabecera
            Dim ent As New Entity.Reporte.ReporteCabecera
            Dim list As New Entity.Reporte.ReporteCabeceraCol

            ent.Codigo = Codigo
            list = Listar(ent)

            If list.Count = 0 Then Return Nothing

            Return list.ReporteCabecera(0)
        End Function
        ''' <summary>
        ''' Retorna el último número de serie de las impresiones hijas excluyendo la cabecera principal de reporte.
        ''' </summary>
        ''' <param name="ReporteCabeceraId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function UltimoNumImpresion(ReporteCabeceraId As Integer) As Integer
            Dim n As Integer = 0
            n = Data.Reporte.ReporteCabecera.ListarOutput("lst", "lst_max_num_print", ReporteCabeceraId)
            Return n
        End Function

        Public Function UltimoNumeroDoc(ReporteId As Integer, AnioDoc As Integer) As Integer
            Dim n As Integer = 0
            n = Data.Reporte.ReporteCabecera.ListarOutput("lst", "ult_num_doc_x_anio", ReporteId, AnioDoc)
            Return n
        End Function

        Public Function Listar(Ent As Entity.Reporte.ReporteCabecera) As Entity.Reporte.ReporteCabeceraCol
            Dim list As New Entity.Reporte.ReporteCabeceraCol
            Dim objEnt As Entity.Reporte.ReporteCabecera
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Reporte.ReporteCabecera.Listar(sqlCon, "lst", "lst_mant", Ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Reporte.ReporteCabecera
                        With objEnt
                            .Codigo = sqlDr("pk_rpt_cab_id").ToString
                            .InternoId = sqlDr("int_id").ToString
                            .InternoIngresoId = sqlDr("int_ing_id").ToString
                            .CodigoReporteId = sqlDr("fk_rpt_id").ToString
                            .CodigoPenal = sqlDr("cod_pen").ToString
                            .Anio = sqlDr("n_anio").ToString
                            .NumSerie = sqlDr("n_num").ToString
                            .NumeroImpresion = sqlDr("n_num_print")
                            .FechaEmision = sqlDr("n_fec_emi").ToString
                            .CodigoId = sqlDr("fk_rpt_cab_id").ToString
                            .MotivoAnulacion = sqlDr("c_mot_anu").ToString
                            .Estado = sqlDr("n_est_id").ToString
                            .RegionId = sqlDr("_regId").ToString
                            .PenalId = sqlDr("_penId").ToString
                        End With
                        list.Add(objEnt)
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

            Return list
        End Function

        'Private Function Validar(Ent As Entity.Reporte.ReporteCabecera, IdIngresoOpcional As Boolean, ByRef outSms As String) As Boolean
        '    'If Ent.PenalId <= 0 Then
        '    '    outSms = "PenalId incorrecto"
        '    '    Return False
        '    'End If
        '    'If Ent.RegionId <= 0 Then
        '    '    outSms = "RegionId incorrecto"
        '    '    Return False
        '    'End If
        '    'If Ent.InternoIngresoId <= 0 And IdIngresoOpcional = False Then
        '    '    outSms = "El valor del Id del ingreso incorrecto InternoIngresoId=" & Ent.InternoIngresoId
        '    '    Return False
        '    'End If

        '    'If Ent.CodigoId < 0 AndAlso (New Bussines.Reporte.ReporteCabecera).UltimoNumeroDoc(Ent.CodigoReporteId, Ent.Anio) = Ent.NumSerie And Ent.NumSerie <> 0 Then
        '    '    outSms = "Ya existe número de documento " & Ent.NumDoc & ", cambie a otro"
        '    '    Return False
        '    'End If

        '    Return True
        'End Function

        Public Function Grabar(Ent As Entity.Reporte.ReporteCabecera, IdIngresoOpcional As Boolean, ByRef outSms As String) As Integer
            'If Validar(Ent, IdIngresoOpcional, outSms) = False Then Return -1

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                If Ent.NumSerie = 0 Then
                    Ent.NumSerie = 1
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Reporte.ReporteCabecera.Grabar(strAccion, strOpcion, Ent)

            Return intValue
        End Function
        Public Function Anular(Codigo As Integer, MotivoAnula As String) As Integer
            Dim Ent As New Entity.Reporte.ReporteCabecera
            Dim intValue As Integer = -1

            Ent.Codigo = Codigo
            Ent.MotivoAnulacion = MotivoAnula
            intValue = Data.Reporte.ReporteCabecera.Grabar("upd", "upd_anular", Ent)
            Return intValue
        End Function
    End Class
End Namespace
