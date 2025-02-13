Imports System.Data.SqlClient

Namespace Registro.Integracion
    Public Class IntegracionInternoDetalle
        Public Function Listar(ent As Entity.Registro.Integracion.IntegracionInternoDetalle) As Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInternoDetalle)
            Dim col As New Entity.EntityCol(Of Entity.Registro.Integracion.IntegracionInternoDetalle)
            Dim objEnt As Entity.Registro.Integracion.IntegracionInternoDetalle

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.Integracion.IntegracionInternoDetalle.Listar(sqlCon, "lst", "ins_mant", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.Integracion.IntegracionInternoDetalle
                        With objEnt
                            .Codigo = sqlDr("pk_int_reg_det_id").ToString
                            .IntegracionInternoId = sqlDr("fk_int_reg_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .InternoIdCrea = sqlDr("_usu_cre").ToString
                            .FechaCreacion = sqlDr("_fec_cre").ToString
                            .CodigoRP = sqlDr("int_cod_rp").ToString
                            .ApePaternoInterno = sqlDr("int_ape_pat").ToString
                            .ApeMaternoInterno = sqlDr("int_ape_mat").ToString
                            .NombresInterno = sqlDr("int_nom").ToString
                            .CodigoUnicoInterno = sqlDr("c_int_cod_uni").ToString
                            .InternoRegionId = sqlDr("int_regid").ToString
                            .InternoPenalId = sqlDr("int_penid").ToString
                            .IntPenalStr = sqlDr("pen_nom").ToString
                            .IntTipoNumDocIdent = sqlDr("tip_num_doc").ToString
                            .CodigoUnicoInternoId = sqlDr("fk_int_reg_id").ToString
                        End With
                        col.Add(objEnt)
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

            Return col
        End Function

        Public Function Eliminar(Codigo As Integer, ByRef outSMS As String) As Integer
            Dim intValue As Integer = -1

            If Codigo <= 0 Then Return -1

            intValue = Data.Registro.Integracion.IntegracionInternoDetalle.Eliminar("del", "del_mant", Codigo, outSMS)

            Return intValue
        End Function
    End Class

End Namespace