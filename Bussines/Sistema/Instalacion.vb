Imports System.Data
Imports System.Data.SqlClient
Namespace Sistema
    Public Class Instalacion
        Private objEnt As Entity.Sistema.Instalacion = Nothing
        Private objEntCol As Entity.Sistema.InstalacionCol = Nothing
#Region "Functions"
        
        Public Function LicenciaNombre(ByVal IDLicencia As Integer) As String

            Dim strValue As String = ""

            strValue = Listar(IDLicencia).Nombre

            Return strValue

        End Function
        Public Function ListarTipo(ByVal Codigo As Integer) As Short

            Dim value As Short = -1

            value = Listar(Codigo).Tipo

            Return value

        End Function
        Public Shared Function listarTipoLicencia(codigo As Short) As Short
            Dim value As Short = -1

            value = listarMant(codigo).Tipo

            Return value
        End Function
        Public Function LicenciaIDPenal(ByVal IDLicencia As Integer) As Short

            Dim value As Short = -1

            value = Listar(IDLicencia).IDPenal

            Return value

        End Function
        Public Function LicenciaIDRegion(ByVal IDLicencia As Integer) As Short

            Dim value As Short = -1

            value = Listar(IDLicencia).RegionID

            Return value

        End Function
#End Region
#Region "Listar"
        Public Function ValidarInstalacion(ByVal InstalacionID As Integer, ByVal Usuario As Integer) As Boolean

            Dim intValue As Integer = -1
            Dim blnValue As Boolean = False

            intValue = Data.Sistema.Instalacion.ListarOutput("lst", "lst_validar_instalacion", _
            InstalacionID, Usuario, "", "")

            If intValue > 0 Then
                blnValue = True
            End If

            Return blnValue
        End Function
        Public Function listarRegionPenal(ByVal codigo As Short) As Entity.Sistema.Instalacion
            Return Listar(New Entity.Sistema.Instalacion With {.Codigo = codigo}).Instalacion(0)

        End Function
        Public Function Listar(ByVal Codigo As Integer) As Entity.Sistema.Instalacion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Sistema.Instalacion.Listar(sqlCon, "lst", "lst_mant", Codigo,
            "", "", 0, -1, False, False, "", "")

            objEnt = New Entity.Sistema.Instalacion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("ins_id").ToString
                            .Nombre = sqlDr("ins_nom").ToString
                            .Tipo = sqlDr("ins_tip_id").ToString
                            .Descripcion = sqlDr("ins_des").ToString
                            .Fecha = sqlDr("ins_fec").ToString
                            .NombreCorto = sqlDr("ins_nom_cor").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .Logmein = sqlDr("ins_log").ToString
                            .Internet = sqlDr("ins_int").ToString
                            .VersionApp = sqlDr("ins_ver_app").ToString
                            .VersionBD = sqlDr("ins_ver_db").ToString
                            .Obs = sqlDr("ins_obs").ToString
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
        Private Shared Function listarMant(ByVal Codigo As Integer) As Entity.Sistema.Instalacion

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Sistema.Instalacion.Listar(sqlCon, "lst", "lst_mant", Codigo,
            "", "", 0, -1, False, False, "", "")

            Dim objEnt As New Entity.Sistema.Instalacion
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("ins_id").ToString
                            .Nombre = sqlDr("ins_nom").ToString
                            .Tipo = sqlDr("ins_tip_id").ToString
                            .Descripcion = sqlDr("ins_des").ToString
                            .Fecha = sqlDr("ins_fec").ToString
                            .NombreCorto = sqlDr("ins_nom_cor").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .Logmein = sqlDr("ins_log").ToString
                            .Internet = sqlDr("ins_int").ToString
                            .VersionApp = sqlDr("ins_ver_app").ToString
                            .VersionBD = sqlDr("ins_ver_db").ToString
                            .Obs = sqlDr("ins_obs").ToString
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

        Public Function Listar(ent As Entity.Sistema.Instalacion) As Entity.Sistema.InstalacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Sistema.Instalacion.Listar(sqlCon, "lst", "lst_grilla", ent)

            Try
                objEntCol = New Entity.Sistema.InstalacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Sistema.Instalacion
                        With objEnt
                            .Codigo = sqlDr("ins_id").ToString
                            .Nombre = sqlDr("ins_nom").ToString
                            .Descripcion = sqlDr("ins_des").ToString
                            .Fecha = sqlDr("ins_fec").ToString
                            .NombreCorto = sqlDr("ins_nom_cor").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Logmein = sqlDr("ins_log").ToString
                            .Internet = sqlDr("ins_int").ToString
                            .VersionApp = sqlDr("ins_ver_app").ToString
                            .VersionBD = sqlDr("ins_ver_db").ToString
                            .Obs = sqlDr("ins_obs").ToString
                            .Tipo = sqlDr("ins_tip_id").ToString
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

        Public Function Listar(ByVal Codigo As Integer, _
        ByVal Nombre As String, _
        ByVal NombreCorto As String, _
        ByVal Fecha As Long, _
        ByVal RegionID As Integer, _
        ByVal Logmein As Boolean, _
        ByVal Internet As Boolean, _
        ByVal VersionApp As String, _
        ByVal VersionBD As String) As Entity.Sistema.InstalacionCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Sistema.Instalacion.Listar(sqlCon, "lst", "lst_grilla", Codigo, _
            Nombre, _
            NombreCorto, _
            Fecha, _
            RegionID, _
            Logmein, _
            Internet, _
            VersionApp, _
            VersionBD)

            Try
                objEntCol = New Entity.Sistema.InstalacionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Sistema.Instalacion
                        With objEnt
                            .Codigo = sqlDr("ins_id").ToString
                            .Nombre = sqlDr("ins_nom").ToString
                            .Descripcion = sqlDr("ins_des").ToString
                            .Fecha = sqlDr("ins_fec").ToString
                            .NombreCorto = sqlDr("ins_nom_cor").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Logmein = sqlDr("ins_log").ToString
                            .Internet = sqlDr("ins_int").ToString
                            .VersionApp = sqlDr("ins_ver_app").ToString
                            .VersionBD = sqlDr("ins_ver_db").ToString
                            .Obs = sqlDr("ins_obs").ToString
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
        Private Function Grabar(ByVal accion As String, ByVal opcion As String, ByVal Codigo As Integer, _
        ByVal Tipo As Integer, ByVal Nombre As String, _
        ByVal Descripcion As String, _
        ByVal Fecha As Long, _
        ByVal NombreCorto As String, _
        ByVal RegionID As Short, IDPenal As Short, _
        ByVal Logmein As Boolean, _
        ByVal Internet As Boolean, _
        ByVal VersionApp As String, _
        ByVal VersionBD As String, _
        ByVal Obs As String, Optional ByVal _Eliminado As Boolean = False) As Integer

            Dim Value As Integer = -1

            Value = Data.Sistema.Instalacion.Grabar(accion, opcion, Codigo, _
            Tipo, _
            Nombre, _
            Descripcion, _
            Fecha, _
            NombreCorto, _
            RegionID, IDPenal, _
            Logmein, _
            Internet, _
            VersionApp, _
            VersionBD, _
            Obs, _
            _Eliminado, _
            Legolas.Configuration.Usuario.Codigo)

            Return Value

        End Function
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal Tipo As Integer, ByVal Nombre As String, _
        ByVal Descripcion As String, _
        ByVal Fecha As Long, _
        ByVal NombreCorto As String, _
        ByVal RegionID As Short, IDPenal As Short, _
        ByVal Logmein As Boolean, _
        ByVal Internet As Boolean, _
        ByVal VersionApp As String, _
        ByVal VersionBD As String, _
        ByVal Obs As String) As Integer

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

            intValue = Grabar(strAccion, strOpcion, Codigo, _
            Tipo, Nombre, _
            Descripcion, _
            Fecha, _
            NombreCorto, _
            RegionID, IDPenal, _
            Logmein, _
            Internet, _
            VersionApp, _
            VersionBD, _
            Obs)

            Return intValue
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Sistema.Instalacion.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
#End Region
    End Class
End Namespace