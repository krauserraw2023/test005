Imports System.Data
Imports System.Data.SqlClient
Namespace Visita
    Public Class InternoFoto
        Private objEnt As Entity.Visita.InternoFoto = Nothing
        Private objEntCol As Entity.Visita.InternoFotoCol = Nothing
#Region "Functions"
        Public Function ListarID(ByVal Codigo As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Visita.internoFoto.ListarOutput("lst", "lst_id", Codigo, -1, -1, -1)

            Return value

        End Function
        Public Shared Function ListarID(ByVal RegionID As Integer, ByVal PenalID As Integer, _
                                 ByVal InternoID As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Visita.internoFoto.ListarOutput("lst", "lst_id", -1, RegionID, PenalID, InternoID)

            Return value

        End Function
#End Region      
#Region "Listar"
        
        Public Function ListarPendientes(ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, ByVal FotoDescargada As Integer) As Entity.Visita.InternoFotoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.internoFoto.Listar(sqlCon, "lst", "lst_fotos_pendientes", Codigo, _
            RegionID, _
            PenalID, _
            InternoID, FotoDescargada)

            Try
                objEntCol = New Entity.Visita.InternoFotoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.InternoFoto
                        With objEnt
                            .Codigo = sqlDr("int_fot_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .InternoCodigoRP = sqlDr("int_cod_rp").ToString
                            '.PrimerApellido = sqlDr("int_pri_ape").ToString
                            '.SegundoApellido = sqlDr("int_seg_ape").ToString
                            '.PreNombres = sqlDr("int_pre_nom").ToString
                            .PathFoto = sqlDr("int_pth_fot").ToString
                            .FotoPerfil = sqlDr("int_fot_per").ToString
                            .FotoDescargada = sqlDr("fot_dwn").ToString
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
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal InternoCodigoRP As String, _
        ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, _
        ByVal PreNombres As String, _
        ByVal PathFoto As String, ByVal FotoPerfil As Integer, _
        ByVal FotoDescargada As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Visita.internoFoto.Grabar(strAccion, strOpcion, Codigo, _
            RegionID, _
            PenalID, _
            InternoID, _
            InternoCodigoRP, _
            PrimerApellido, _
            SegundoApellido, _
            PreNombres, _
            PathFoto, FotoPerfil, _
            FotoDescargada, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
        Public Function FotoDescargada(ByVal Codigo As Integer) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            Dim intFotoDescar As Integer = 1

            strAccion = "upd"
            strOpcion = "upd_foto_descargada"

            value = Data.Visita.internoFoto.Grabar(strAccion, strOpcion, Codigo, _
            -1, -1, -1, "", "", "", "", "", -1, intFotoDescar, _
            Legolas.Configuration.Usuario.Codigo)

            Return value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Visita.internoFoto.Eliminar(strAccion, strOpcion, Codigo, Usuario)
            Return intValue
        End Function
#End Region
    End Class
End Namespace