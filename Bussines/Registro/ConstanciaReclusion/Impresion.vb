Imports System.Data.SqlClient

Namespace Registro.ConstanciaReclusion
    Public Class Impresion

        Private objEnt As Entity.Registro.ConstanciaReclusion.Impresion = Nothing
        Private objLista As List(Of Entity.Registro.ConstanciaReclusion.Impresion) = Nothing

#Region "Listar"
        Public Function listarGrilla(objEntFiltro As Entity.Registro.ConstanciaReclusion.Impresion) As List(Of Entity.Registro.ConstanciaReclusion.Impresion)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.ConstanciaReclusion.Impresion.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objLista = New List(Of Entity.Registro.ConstanciaReclusion.Impresion)
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.ConstanciaReclusion.Impresion
                        With objEnt
                            .codigo = sqlDr("pk_cons_rec_imp_id").ToString
                            .codigoCR = sqlDr("fk_cons_rec_tra_id").ToString
                            .item = sqlDr("n_item").ToString
                            .motivoImpresion = sqlDr("c_mot_imp").ToString
                            .usuario = sqlDr("usuario").ToString
                            .fechaImpresion = sqlDr("_fec_cre").ToString
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
        Public Function fnCantidadImpresion(idTramite As Integer) As Integer

            Dim value As Integer = 0

            value = Data.Registro.ConstanciaReclusion.Impresion.ListarOutput("lst", "lst_cantidad_impresion",
                New Entity.Registro.ConstanciaReclusion.Impresion With {.codigoCR = idTramite})

            Return value

        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(idTramiteCR As Integer, motivoImpresion As String, idRegion As Short, idPenal As Short) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "ins"
            strOpcion = "ins_mant"

            value = Data.Registro.ConstanciaReclusion.Impresion.Grabar(strAccion, strOpcion,
                                                                          New Entity.Registro.ConstanciaReclusion.Impresion With {.codigoCR = idTramiteCR,
                                                                          .motivoImpresion = motivoImpresion,
                                                                          .idRegion = idRegion,
                                                                          .idPenal = idPenal})

            Return value

        End Function

#End Region
    End Class
End Namespace