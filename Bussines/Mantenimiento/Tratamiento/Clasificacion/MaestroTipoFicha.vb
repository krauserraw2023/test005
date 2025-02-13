Imports System.Data
Imports System.Data.SqlClient
Namespace Clasificacion
    Public Class MaestroTipoFicha
        Private objEnt As Entity.Registro.Carceleta.Clasificacion.MaestroTipoFicha_BE = Nothing
        Private objEntCol As Entity.Registro.Carceleta.Clasificacion.MaestroTipoFichaCol_BE = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Carceleta.Clasificacion.MaestroTipoFicha_BE
            objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroTipoFicha_BE
            objEnt.Codigo = Codigo

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Clasificacion.MaestroTipoFicha.Listar(sqlCon, "lst", "lst_mant", objEnt)
            objEnt = New Entity.Registro.Carceleta.Clasificacion.MaestroTipoFicha_BE
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_tip_fic_id").ToString
                            .TipoFichaNombre = sqlDr("tip_fic_nom").ToString
                            .NumOrden = sqlDr("n_num_ord").ToString
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

#End Region
 
    End Class
End Namespace