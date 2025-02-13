Imports System.Data
Imports System.Data.SqlClient
Namespace Seguridad.Penal
    Public Class Region
        Private objEnt As Entity.Seguridad.Penal.Region = Nothing
        Private objEntCol As Entity.Seguridad.Penal.RegionCol = Nothing
#Region "Functions"
        Public Function ListarID(ByVal Codigo As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Seguridad.Penal.Region.ListarOutput("lst", "lst_id", Codigo, -1, -1, -1)

            Return value

        End Function
        Public Shared Function Count() As Integer
            Dim value As Integer = 0

            value = Data.Seguridad.Penal.Region.ListarOutput("lst", "lst_count", _
            -1, -1, -1, -1)

            Return value
        End Function
        Public Function ActualizarTabla(ByVal Tabla As System.Data.DataTable) As Boolean

            Dim blnValue As Boolean = False
            Dim intCodigo As Integer = 0

            If Not Tabla Is Nothing Then

                EliminarTabla(-1)

                For Each Fila As System.Data.DataRow In Tabla.Rows

                    intCodigo = ListarID(Fila("reg_usu_id").ToString)

                    If intCodigo > 0 Then
                        Grabar("upd", "upd_mant", _
                        Fila("reg_usu_id").ToString, _
                        Fila("usu_id").ToString, _
                        Fila("reg_id").ToString, _
                        Fila("pen_id").ToString, _
                        Fila("_flg_eli").ToString)
                    Else
                        Grabar("ins", "ins_mant_local", _
                        Fila("reg_usu_id").ToString, _
                        Fila("usu_id").ToString, _
                        Fila("reg_id").ToString, _
                        Fila("pen_id").ToString, _
                        Fila("_flg_eli").ToString)
                    End If

                Next
                blnValue = True

            End If

            Return blnValue

        End Function
#End Region
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Seguridad.Penal.Region

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Seguridad.Penal.Region.Listar(sqlCon, "lst", "", Codigo, -1, -1, -1)
            objEnt = New Entity.Seguridad.Penal.Region
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("reg_usu_id").ToString
                            .UsuarioID = sqlDr("usu_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
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
        ByVal UsuarioID As Integer, ByVal Login As String, ByVal UsuarioApePaterno As String, _
        ByVal UsuarioApeMat As String, ByVal UsuarioNom As String, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer) As Entity.Seguridad.Penal.RegionCol


            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Seguridad.Penal.Region.Listar(sqlCon, "lst", "", Codigo, _
            UsuarioID, _
            RegionID, _
            PenalID _
            )
            Try
                objEntCol = New Entity.Seguridad.Penal.RegionCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Seguridad.Penal.Region
                        With objEnt
                            .Codigo = sqlDr("reg_usu_id").ToString
                            .UsuarioID = sqlDr("usu_id").ToString
                            '.UsuarioLogin = sqlDr("").ToString
                            '.UsuarioApePat = sqlDr("").ToString
                            '.UsuarioApeMat = sqlDr("").ToString
                            '.UsuarioNom = sqlDr("").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
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
        Private Function Grabar(ByVal accion As String, ByVal opcion As String, _
                                ByVal Codigo As Integer, _
        ByVal UsuarioID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, Optional ByVal _Eliminado As Boolean = False) As Integer

            Dim intValue As Integer = -1

            intValue = Data.Seguridad.Penal.Region.Grabar(accion, opcion, Codigo, _
            UsuarioID, _
            RegionID, _
            PenalID, _
            _Eliminado, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue

        End Function
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal UsuarioID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer) As Integer

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
            UsuarioID, _
            RegionID, _
            PenalID)

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

            intValue = Data.Seguridad.Penal.Region.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
        Public Function EliminarTabla(ByVal LicenciaID As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Seguridad.Penal.Region.Eliminar("del", "del_all_provincia", -1, Legolas.Configuration.Usuario.Codigo)

            Return value

        End Function
#End Region
    End Class
End Namespace