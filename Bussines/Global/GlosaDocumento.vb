Imports System.Data.SqlClient

Namespace Globall
    Public Class GlosaDocumento
        Private objEnt As Entity.Globall.GlosaDocumento = Nothing
        Private objEntCol As Entity.Globall.GlosaDocumentoCol = Nothing
#Region "Listar"

        Public Function ListarPorCodigo(ByVal Codigo As Integer) As Entity.Globall.GlosaDocumento
            Dim entFich As New Entity.Globall.GlosaDocumento
            entFich.Codigo = Codigo
            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol.CategoriaFicha(0)
        End Function
        Public Function Listar(TipoGlosa As Type.Enumeracion.TipoGlosa) As Entity.Globall.GlosaDocumentoCol
            Dim entFich As New Entity.Globall.GlosaDocumento
            entFich.TipoGlosaId = TipoGlosa.GetHashCode
            objEntCol = Listar(entFich)
            If objEntCol Is Nothing Then Return Nothing

            Return objEntCol
        End Function
        Public Function Listar(entFich As Entity.Globall.GlosaDocumento) As Entity.Globall.GlosaDocumentoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Globall.GlosaDocumento.Listar(sqlCon, "lst", "lst_mant", entFich)
            Try
                objEntCol = New Entity.Globall.GlosaDocumentoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Globall.GlosaDocumento
                        With objEnt
                            .Codigo = sqlDr("pk_glo_doc_id").ToString
                            .DescripcionCorta = sqlDr("c_glo_desc").ToString
                            .Texto = sqlDr("c_glo_text").ToString
                            .EstadoId = sqlDr("n_glo_est_id").ToString
                            .TipoGlosaId = sqlDr("fk_tip_glo_doc_id").ToString
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

    End Class
End Namespace