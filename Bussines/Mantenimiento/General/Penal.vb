Imports System.Data
Imports System.Data.SqlClient
Namespace General
    Public Class Penal
        Private objEnt As Entity.General.Penal = Nothing
        Private objEntCol As Entity.General.PenalCol = Nothing
#Region "Functions"

        Public Shared Function Version5(IDPenal As Integer) As Boolean

            Dim value As Boolean = False
            Dim intValor As Integer = 0

            intValor = Data.General.Penal.ListarOutput("lst", "lst_version_app", IDPenal)

            If intValor = 500 Then
                value = True
            End If

            Return value
        End Function

        Public Function fnTipoLicencia(intIDPenal As Integer) As Short

            Dim value As Short = -1
            Dim objEnt As Entity.General.Penal

            objEnt = Listar_v2(intIDPenal)

            If objEnt Is Nothing Then
                'nada
            Else
                value = objEnt.PenalTipoLicenciaId
            End If

            Return value
        End Function
#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer,
        ByVal PenalCodigo As String,
        ByVal Nombre As String,
        ByVal RegionID As Integer, ByVal PenalTipo As Integer, ByVal PenalTipoString As String) As Entity.General.PenalCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.Penal.Listar(sqlCon, "lst", "lst_mant", Codigo,
            PenalCodigo, Nombre, RegionID, PenalTipo, PenalTipoString)

            Try
                objEntCol = New Entity.General.PenalCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.General.Penal
                        With objEnt
                            .Codigo = sqlDr("PEN_ID").ToString
                            .PenalCodigo = sqlDr("PEN_COD").ToString
                            .Nombre = sqlDr("PEN_NOM").ToString
                            '.Ubigeo = sqlDr("PEN_UBI").ToString
                            .RegionCodigo = sqlDr("REG_COD").ToString
                            .Estado = sqlDr("PEN_EST").ToString
                            .NombreCorto = sqlDr("PEN_NOM_COR").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
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

        Public Function Listar(IDPenal As Integer) As Entity.General.Penal
            Dim ent As New Entity.General.Penal
            ent.Codigo = IDPenal

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.Penal.Listar(sqlCon, "lst", "lst_mant_v2", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ent = New Entity.General.Penal
                        With ent
                            .Codigo = sqlDr("PEN_ID").ToString
                            .PenalCodigo = sqlDr("PEN_COD").ToString
                            .Nombre = sqlDr("PEN_NOM").ToString
                            .NombreCorto = sqlDr("PEN_NOM_COR").ToString
                            '.RegionCodigo = sqlDr("REG_COD").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .Estado = sqlDr("PEN_EST").ToString
                            'otros
                            .RegimenPenitenciarioId = sqlDr("regimen_pen_id").ToString
                            .FechaInstalacionSistemaVisitas = sqlDr("n_pen_fec_imp_sis_vis").ToString
                            .VersionAPP = sqlDr("pen_est_int").ToString
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
            Return ent
        End Function
        ''' <summary>
        ''' 08-01/2019 - hnrb - se agrego PenalTipoLicencia
        ''' </summary>
        ''' <param name="IDPenal"></param>
        ''' <returns></returns>
        Public Function Listar_v2(IDPenal As Integer) As Entity.General.Penal
            Dim ent As New Entity.General.Penal
            ent.Codigo = IDPenal

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.General.Penal.Listar(sqlCon, "lst", "lst_mant_v3", ent)

            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ent = New Entity.General.Penal
                        With ent
                            .Codigo = sqlDr("PEN_ID").ToString
                            .PenalCodigo = sqlDr("PEN_COD").ToString
                            .Nombre = sqlDr("PEN_NOM").ToString
                            .NombreCorto = sqlDr("PEN_NOM_COR").ToString
                            '.RegionCodigo = sqlDr("REG_COD").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .Estado = sqlDr("PEN_EST").ToString
                            'otros
                            .RegimenPenitenciarioId = sqlDr("regimen_pen_id").ToString
                            .FechaInstalacionSistemaVisitas = sqlDr("n_pen_fec_imp_sis_vis").ToString
                            .VersionAPP = sqlDr("pen_est_int").ToString
                            .PenalTipoLicenciaId = sqlDr("n_pen_tip_lic")
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
            Return ent
        End Function


        Public Function ListarRegimen(Regimen As Integer) As Entity.Mantenimiento.General.RegimenPenitenciarioCol
            'desgloza el regimen mixto en dos objetos independiente ordinario y cerrado
            Dim entCol As New Entity.Mantenimiento.General.RegimenPenitenciarioCol
            Dim ent As Entity.Mantenimiento.General.RegimenPenitenciario
            Select Case Regimen
                Case 1
                    ent = New Entity.Mantenimiento.General.RegimenPenitenciario
                    ent.Codigo = Regimen
                    ent.Regimen = "Ordinario"
                    entCol.Add(ent)
                Case 2
                    ent = New Entity.Mantenimiento.General.RegimenPenitenciario
                    ent.Codigo = Regimen
                    ent.Regimen = "Especial"
                    entCol.Add(ent)
                Case 3
                    ent = New Entity.Mantenimiento.General.RegimenPenitenciario
                    ent.Codigo = 1
                    ent.Regimen = "Ordinario"
                    entCol.Add(ent)

                    ent = New Entity.Mantenimiento.General.RegimenPenitenciario
                    ent.Codigo = 2
                    ent.Regimen = "Especial"
                    entCol.Add(ent)
            End Select
            Return entCol
        End Function


#End Region

    End Class
End Namespace