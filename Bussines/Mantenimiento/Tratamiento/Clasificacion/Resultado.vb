Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Tratamiento.Clasificacion
    Public Class Resultado

        Private objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE = Nothing
        Private objEntCol As Entity.EntityCol(Of Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE) = Nothing

#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim objEntFiltro As New Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE
            With objEntFiltro
                .Codigo = Codigo
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Tratamiento.Clasificacion.Resultado.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            objEnt = New Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_fic_res_id").ToString
                            .IDFicha = sqlDr("fk_fic_id").ToString
                            '.NumeroOrden = sqlDr("n_num_ord").ToString
                            '.Nombre = sqlDr("c_nom").ToString
                            .Descripcion = sqlDr("c_des").ToString
                            .TieneValorTabla = sqlDr("b_tbl_int").ToString
                            .NombreTabla = sqlDr("c_nom_tbl").ToString
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

#Region "Grabar"

        Public Function Grabar(objEnt As Entity.Mantenimiento.Tratamiento.Clasificacion.Resultado_BE, ByRef outSMS As String) As Short

            Dim value As Short
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Mantenimiento.Tratamiento.Clasificacion.Resultado.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, ByRef strMensaje As String) As Short

            Dim value As Integer = -1

            value = Data.Mantenimiento.Tratamiento.Clasificacion.Resultado.Eliminar(accion, opcion, Codigo, strMensaje)

            Return value

        End Function
#End Region

    End Class

End Namespace
