Imports System.Data.SqlClient
Imports Data.Registro.Carceleta.Clasificacion.Documento

Namespace Clasificacion.Documento
    'tabla tra_asi_mov_det_documento
    Public Class DetDocClasificacion_BL
        Private objEnt As Entity.Clasificacion.Documento.DetDocClasificacion = Nothing
        Private objEntCol As Entity.Clasificacion.Documento.DetDocClasificacionCol = Nothing

#Region "Listar"

        Public Function Listar(entFich As Entity.Clasificacion.Documento.DetDocClasificacion) As Entity.Clasificacion.Documento.DetDocClasificacionCol

            Dim sqlCon = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr = DetDocClasificacion_DA.Listar(sqlCon, "lst", "lst_mant", entFich)
            Try
                objEntCol = New Entity.Clasificacion.Documento.DetDocClasificacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Clasificacion.Documento.DetDocClasificacion
                        With objEnt
                            .Codigo = sqlDr("pk_det_doc_id").ToString
                            .DocClasificacionId = sqlDr("fk_doc_id").ToString
                            .InternoFichaId = sqlDr("fk_int_fic_id").ToString
                            .PenalId = sqlDr("_PenId").ToString
                            .RegionId = sqlDr("_RegId").ToString

                            .CodigoInterno = sqlDr("int_cod_rp").ToString
                            .ApePatInterno = sqlDr("int_ape_pat").ToString
                            .ApeMatInterno = sqlDr("int_ape_mat").ToString
                            .NomInterno = sqlDr("int_nom").ToString
                            .NumIngreso = sqlDr("numIngreso").ToString
                            .FechaClasificacion = sqlDr("fec_clasif").ToString
                            .PenalDestinoNombre = sqlDr("pen_dest_nom").ToString
                            .InternoId = sqlDr("int_id").ToString
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

        Public Function Grabar(objEnt As Entity.Clasificacion.Documento.DetDocClasificacion, ByRef outErr As String) As Integer
            ' If Validar(objEnt, outErr) = False Then Return -1
            Dim strOpcion As String
            Dim strAccion As String
            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            Return DetDocClasificacion_DA.Grabar(strAccion, strOpcion, objEnt)
        End Function

        Public Function Eliminar(ByVal Codigo As Integer, ByRef outErr As String) As Integer
            Return DetDocClasificacion_DA.Eliminar("del", "del_mant", Codigo)
        End Function
    End Class
End Namespace