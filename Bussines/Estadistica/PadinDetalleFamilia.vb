Imports System.Data
Imports System.Data.SqlClient
Namespace Estadistica
    Public Class PadinDetalleFamilia
        Private objEnt As Entity.Estadistica.PadinDetalleFamilia = Nothing
        Private objEntCol As Entity.Estadistica.PadinDetalleFamiliaCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Estadistica.PadinDetalleFamilia

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalleFamilia.Listar(sqlCon, "lst", "", _
                                                                                     Codigo, -1, -1, -1, -1, "", "", "", 0, -1, "")
            objEnt = New Entity.Estadistica.PadinDetalleFamilia
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pad_det_fam_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .PrimerApellido = sqlDr("pad_det_fam_pre_ape").ToString
                            .SegundoApellido = sqlDr("pad_det_fam_seg_ape").ToString
                            .PreNombres = sqlDr("pad_det_fam_pre_nom").ToString
                            .FechaNacimiento = sqlDr("pad_det_fam_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .SexoNombre = sqlDr("pad_det_fam_sex_nom").ToString
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
        Public Function Listar(ByVal Codigo As Integer, _
        ByVal PadinID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal InternoID As Integer, _
        ByVal PrimerApellido As String, _
        ByVal SegundoApellido As String, _
        ByVal PreNombres As String, _
        ByVal FechaNacimiento As Long, _
        ByVal SexoID As Integer, _
        ByVal SexoNombre As String) As Entity.Estadistica.PadinDetalleFamiliaCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDetalleFamilia.Listar(sqlCon, "lst", "", Codigo, _
            PadinID, _
            RegionID, _
            PenalID, _
            InternoID, _
            PrimerApellido, _
            SegundoApellido, _
            PreNombres, _
            FechaNacimiento, _
            SexoID, _
            SexoNombre)

            Try
                objEntCol = New Entity.Estadistica.PadinDetalleFamiliaCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDetalleFamilia
                        With objEnt
                            .Codigo = sqlDr("pad_det_fam_id").ToString
                            .PadinID = sqlDr("pad_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .PrimerApellido = sqlDr("pad_det_fam_pre_ape").ToString
                            .SegundoApellido = sqlDr("pad_det_fam_seg_ape").ToString
                            .PreNombres = sqlDr("pad_det_fam_pre_nom").ToString
                            .FechaNacimiento = sqlDr("pad_det_fam_fec_nac").ToString
                            .SexoID = sqlDr("sex_id").ToString
                            .SexoNombre = sqlDr("pad_det_fam_sex_nom").ToString
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
        
        Public Function Grabar(ByVal obj As Entity.Estadistica.PadinDetalleFamilia) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With obj

                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Estadistica.PadinDetalleFamilia.Grabar(strAccion, strOpcion, _
                .Codigo, _
                .PadinID, _
                .RegionID, _
                .PenalID, _
                .InternoID, _
                .PrimerApellido, _
                .SegundoApellido, _
                .PreNombres, _
                .FechaNacimiento, _
                .SexoID, _
                .SexoNombre, _
                .Vive, _
                .Recluido, _
                Legolas.Configuration.Usuario.Codigo)

                Return intValue

            End With

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Estadistica.PadinDetalleFamilia.Eliminar(strAccion, strOpcion, Codigo, Usuario)

            Return intValue

        End Function
#End Region
    End Class
End Namespace