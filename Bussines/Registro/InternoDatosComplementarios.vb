Imports System.Data
Imports System.Data.SqlClient
Namespace Registro
    Public Class InternoDatosComplementarios
        Private objEnt As Entity.Registro.InternoDatosComplementarios = Nothing
        Private objEntCol As Entity.Registro.InternoDatosComplementariosCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer, InternoId As Integer) As Entity.Registro.InternoDatosComplementarios

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Registro.InternoDatosComplementarios
            objEntFiltro.Codigo = Codigo
            objEntFiltro.IDInterno = InternoId
            Dim sqlDr As SqlDataReader = Data.Registro.InternoDatosComplementarios.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            objEnt = New Entity.Registro.InternoDatosComplementarios
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pk_int_dat_com_id").ToString
                            .IDInterno = sqlDr("fk_int_id").ToString
                            .pertenecePueblo = sqlDr("n_es_pbl_etc").ToString
                            .IDGrupoPueblo = sqlDr("fk_grp_pbl_id").ToString
                            .IDPueblo = sqlDr("fk_pbl_id").ToString
                            .OtroPueblo = sqlDr("n_otr_pbl").ToString
                            .IDGrupoLenguaMaterna = sqlDr("fk_grp_lga_mat_id").ToString
                            .IDLenguaMaterna = sqlDr("fk_lga_mat_id").ToString
                            .IDIdioma = sqlDr("fk_idm_id").ToString
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
        Public Function Grabar(ByVal objEnt As Entity.Registro.InternoDatosComplementarios) As Integer
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
            Value = Data.Registro.InternoDatosComplementarios.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Registro.InternoDatosComplementarios.Eliminar(strAccion, strOpcion, Codigo, Legolas.Configuration.Usuario.Codigo)
            Return Value
        End Function
#End Region
    End Class
End Namespace