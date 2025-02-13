Imports System.Data
Imports System.Data.SqlClient
Imports Type.Enumeracion.TipoDocJudicial
Imports Type.Enumeracion.Licencia
Imports Type.Enumeracion.SubTipoDocJudicial
Namespace Registro
    Public Class DocumentosDescarga

        Public Function ListarDocumentosDescargados(objEntFiltro As Entity.Registro.DocumentoDescarga) As Entity.Registro.DocumentoDescargaCol
            Dim objEntCol As New Entity.Registro.DocumentoDescargaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Registro.DocumentoDescargado.Listar(sqlCon, "lst", "lst_doc_descargados", objEntFiltro)

            Try

                Dim objEnt As Entity.Registro.DocumentoDescarga
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.DocumentoDescarga
                        With objEnt
                            .Codigo = sqlDr("doc_desc_id").ToString
                            '. = sqlDr("doc_desc_tip").ToString
                            ' .SedeRowId = sqlDr("sed_int_id").ToString
                            .InternoId = sqlDr("int_id").ToString
                            .Observacion = sqlDr("int_cod_rp").ToString
                            .ApellidosNombres = sqlDr("int_ape_nom").ToString
                            .DocumentoTipoNombre = sqlDr("doc_tip_nom").ToString
                            .DocumentoNumero = sqlDr("doc_jud_num").ToString
                            .DocumentoFecha = sqlDr("doc_jud_fec").ToString
                            .FechaMovimiento = sqlDr("doc_des_fec").ToString
                            .Estado = 0
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

        Public Function Grabar_Descarga(ObjEnt As Entity.Registro.DocumentoDescarga) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            If ObjEnt.Codigo > 0 Then
                strAccion = "upd"
                strOpcion = "upd_mant_descarga"
            Else
                strAccion = "ins"
                strOpcion = "int_mant_descarga"
            End If

            intValue = Data.Registro.DocumentoDescargado.Grabar(strAccion, strOpcion, ObjEnt)
            Return intValue
        End Function

    End Class
End Namespace
