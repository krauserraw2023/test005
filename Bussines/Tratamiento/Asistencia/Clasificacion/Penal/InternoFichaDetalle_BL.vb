Imports System.Data.SqlClient
Imports Data.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Tratamiento.Asistencia.Clasificacion.Penal

Namespace Tratamiento.Asistencia.Clasificacion.Penal
    Public Class InternoFichaDetalle_BL
        Private objEnt As InternoFichaDetalle_BE = Nothing
        Private objEntCol As List(Of InternoFichaDetalle_BE) = Nothing
        Public Function Listar(objEntFiltro As InternoFichaDetalle_BE) As List(Of InternoFichaDetalle_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = InternoFichaDetalle_DA.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try
                objEntCol = New List(Of InternoFichaDetalle_BE)
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New InternoFichaDetalle_BE
                        With objEnt
                            .Codigo = sqlDr("pk_det_id").ToString
                            .IDInternoFicha = sqlDr("fk_int_fic_id").ToString
                            .IDVariable = sqlDr("fk_var_id").ToString
                            .IDIndicador = sqlDr("fk_ind_id").ToString
                            .Ponderacion = sqlDr("n_val_pon").ToString
                            .PonderacionNoPrevista = sqlDr("n_val_pon_no_pre").ToString
                            .IDegion = sqlDr("_RegId").ToString
                            .IDPenal = sqlDr("_PenId").ToString
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

        Public Function Grabar(objEnt As InternoFichaDetalle_BE, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strOpcion As String
            Dim strAccion As String

            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = InternoFichaDetalle_DA.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

        Public Function Eliminar(intCodigo As Integer) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            Value = InternoFichaDetalle_DA.Eliminar(strAccion, strOpcion, intCodigo)

            Return Value

        End Function
    End Class

End Namespace
