Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Registro
    Public Class PadinCuadro13
        Private objEnt As Entity.Mantenimiento.Registro.PadinCuadro13 = Nothing
        Private objEntCol As Entity.Mantenimiento.Registro.PadinCuadro13Col = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Mantenimiento.Registro.PadinCuadro13

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objFiltro As New Entity.Mantenimiento.Registro.PadinCuadro13
            objFiltro.Codigo = Codigo

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Registro.PadinCuadro13.Listar(sqlCon, "lst", "lst_mant", objFiltro)

            objEnt = New Entity.Mantenimiento.Registro.PadinCuadro13
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("rpt_cua_13_id").ToString
                            .Nombre = sqlDr("rpt_cua_13_nom").ToString
                            .NombreDetalle = sqlDr("c_nom_det").ToString
                            .Cuadro = sqlDr("n_ver_rpt").ToString
                            .Orden = sqlDr("n_reg_ord").ToString
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
        Public Function Listar(objFiltro As Entity.Mantenimiento.Registro.PadinCuadro13) As Entity.Mantenimiento.Registro.PadinCuadro13Col

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Registro.PadinCuadro13.Listar(sqlCon, "lst", "lst_grilla", objFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.Registro.PadinCuadro13Col
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Registro.PadinCuadro13
                        With objEnt
                            .Codigo = sqlDr("rpt_cua_13_id").ToString
                            .TipoEgresoNombre = sqlDr("c_egr_tip_nom").ToString
                            .TipoEgresoTabla = sqlDr("c_egr_tip_tbl").ToString
                            .Nombre = sqlDr("rpt_cua_13_nom").ToString
                            .NombreDetalle = sqlDr("c_nom_det").ToString
                            .Cuadro = sqlDr("n_ver_rpt").ToString
                            .Orden = sqlDr("n_reg_ord").ToString
                            .MovimientoMotivoCodigo01String = sqlDr("egr_tip_mot_id").ToString
                            .MovimientoMotivoCodigo02String = sqlDr("n_egr_tip_mot_id").ToString
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