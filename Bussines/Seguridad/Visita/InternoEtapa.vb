Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class InternoEtapa
        Private objEnt As Entity.Visita.InternoEtapa = Nothing
        Private objEntCol As Entity.Visita.InternoEtapaCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.InternoEtapa

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.InternoEtapa
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Visita.InternoEtapa.Listar(sqlCon, "lst", "", objEntFiltro)
            objEnt = New Entity.Visita.InternoEtapa
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("int_etp_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .EtapaID = sqlDr("etp_id").ToString
                            .Documento = sqlDr("int_etp_doc").ToString
                            .DocumentoFecha = sqlDr("int_etp_doc_fec").ToString
                            .Obs = sqlDr("int_etp_obs").ToString
                            .Estado = sqlDr("int_etp_est").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Visita.InternoEtapa) As Entity.Visita.InternoEtapaCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.InternoEtapa.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.InternoEtapaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.InternoEtapa
                        With objEnt
                            .Codigo = sqlDr("int_etp_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoApeNom = sqlDr("int_ape_nom").ToString
                            .EtapaID = sqlDr("etp_id").ToString
                            .EtapaNombre = sqlDr("etp_nom").ToString
                            .FechaRegistro = sqlDr("int_etp_fec_reg").ToString
                            .Documento = sqlDr("int_etp_doc").ToString
                            .DocumentoFecha = sqlDr("int_etp_doc_fec").ToString
                            .Obs = sqlDr("int_etp_obs").ToString
                            .Estado = sqlDr("int_etp_est").ToString
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
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Visita.InternoEtapa) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With
            Value = Data.Visita.InternoEtapa.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function GrabarEstado(ByVal Codigo As Integer, ByVal Estado As Integer) As Integer

            Dim Value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim objEnt As New Entity.Visita.InternoEtapa
            With objEnt
                .Codigo = Codigo
                .Estado = Estado
            End With

            strAccion = "upd"
            strOpcion = "upd_estado"
            
            Value = Data.Visita.InternoEtapa.Grabar(strAccion, strOpcion, objEnt)

            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.InternoEtapa) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.InternoEtapa.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace