Imports System.Data.SqlClient

Namespace Registro.ConstanciaReclusion
    Public Class Reporte
        Private objLista As List(Of Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion) = Nothing
        Private objEnt As Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion = Nothing

        Public Function listarReporteExpedicion(filtro As Entity.Registro.ConstanciaReclusion.ReporteFiltro) As List(Of Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion)

            filtro.fechaFin = filtro.fechaFin.AddHours(24).AddSeconds(-1)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Reporte.Listar(sqlCon, "lst", "lst_rpt_reporte_expedicion", filtro)

            Try
                objLista = New List(Of Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion)
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.ReporteConstanciaReclusion
                        With objEnt
                            .item = sqlDr("item").ToString
                            .fechaRecepcionEP = sqlDr("fec_rec_ep").ToString
                            .fechaRecepcionRP = sqlDr("fec_rec_rp").ToString
                            .idTipoSolicitante = sqlDr("fk_tip_sol_id").ToString
                            .solicitanteNombre = sqlDr("tip_aut_jud_nom").ToString
                            .distritoJudicialNombre = sqlDr("dis_jud_nom").ToString
                            .salaJudicialNombre = sqlDr("sal_juz_nom").ToString
                            .internoApeNom = sqlDr("int_ape_nom").ToString
                            .tipoTramite = sqlDr("n_tip_tra").ToString
                            .idTipoDocumento = sqlDr("n_tip_doc_ref").ToString
                            .tipoDocumentoNombre = sqlDr("tip_doc_nom").ToString
                            .documentoSerie = sqlDr("doc_serie").ToString
                            .documentoNumero = sqlDr("doc_num").ToString
                            .numeroCR = sqlDr("num_cr").ToString
                            .fechaExpedicion = sqlDr("fec_exp_cr").ToString
                            .regionNombre = sqlDr("reg_nom").ToString.ToUpper
                            .penalNombre = sqlDr("pen_nom").ToString.ToUpper
                        End With
                        objLista.Add(objEnt)
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
            Return objLista
        End Function
    End Class
End Namespace