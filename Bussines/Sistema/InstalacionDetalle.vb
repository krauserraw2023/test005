Imports System.Data
Imports System.Data.SqlClient
Namespace Sistema
    Public Class InstalacionDetalle
        Private objEnt As Entity.Sistema.Instalaciondetalle = Nothing
        Private objEntCol As Entity.Sistema.InstalaciondetalleCol = Nothing
#Region "Functions"
        Public Function ListarID(ByVal Codigo As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Sistema.Instalaciondetalle.ListarOutput("lst", "lst_id", Codigo, -1, -1, -1, False, False)

            Return value

        End Function
        Public Function VerificarPermisoEscritura(ByVal Codigo As Integer, ByVal InstalacionId As Integer,
                                                  ByVal PenalId As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Sistema.Instalaciondetalle.ListarOutput("lst", "lst_validar_escritura_region", Codigo, InstalacionId, -1, PenalId, False, False)

            Return value

        End Function
        Public Function VerificarPermisoEscritura(ByVal IDLicencia As Integer,
                                                 ByVal IDPenal As Integer) As Integer

            Dim value As Integer = -1

            value = Data.Sistema.Instalaciondetalle.ListarOutput("lst", "lst_validar_escritura_region", -1, IDLicencia, -1, IDPenal, False, False)

            Return value

        End Function
        Public Shared Function Count() As Integer
            Dim value As Integer = 0

            value = Data.Sistema.Instalaciondetalle.ListarOutput("lst", "lst_count", -1, -1, -1, -1, False, False)

            Return value

        End Function
        Public Function ActualizarTabla(ByVal Tabla As System.Data.DataTable) As Boolean

            Dim blnValue As Boolean = False
            Dim intCodigo As Integer = 0

            If Not Tabla Is Nothing Then

                For Each Fila As System.Data.DataRow In Tabla.Rows

                    intCodigo = ListarID(Fila("ins_det_id").ToString)

                    If intCodigo > 0 Then
                        Grabar("upd", "upd_mant", _
                        Fila("ins_det_id").ToString, _
                        Fila("ins_id").ToString, _
                        Fila("reg_id").ToString, _
                        Fila("pen_id").ToString, _
                        Fila("ins_det_lec").ToString, _
                        Fila("ins_del_esc").ToString, _
                        Fila("_flg_eli").ToString)
                    Else
                        Grabar("ins", "ins_mant_local", _
                        Fila("ins_det_id").ToString, _
                        Fila("ins_id").ToString, _
                        Fila("reg_id").ToString, _
                        Fila("pen_id").ToString, _
                        Fila("ins_det_lec").ToString, _
                        Fila("ins_del_esc").ToString, _
                        Fila("_flg_eli").ToString)
                    End If

                Next

                blnValue = True

            End If

            Return blnValue

        End Function
#End Region
#Region "Listar"

        Public Function Listar(ByVal Codigo As Integer) As Entity.Sistema.InstalacionDetalle

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Sistema.Instalaciondetalle.Listar(sqlCon, "lst", "", _
            Codigo, -1, -1, -1, False, False)

            objEnt = New Entity.Sistema.InstalacionDetalle
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("ins_det_id").ToString
                            .InstalacionID = sqlDr("ins_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Lectura = sqlDr("ins_det_lec").ToString
                            .Escritura = sqlDr("ins_del_esc").ToString
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
        Public Function ListarRegionPenal(ByVal InstalacionID As Integer) As Entity.Sistema.InstalacionDetalle

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Sistema.Instalaciondetalle.Listar(sqlCon, "lst", "", _
            -1, InstalacionID, -1, -1, False, False)

            objEnt = New Entity.Sistema.InstalacionDetalle
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("ins_det_id").ToString
                            .InstalacionID = sqlDr("ins_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .Lectura = sqlDr("ins_det_lec").ToString
                            .Escritura = sqlDr("ins_del_esc").ToString
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
        ByVal InstalacionID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal Lectura As Boolean, _
        ByVal Escritura As Boolean) As Entity.Sistema.InstalacionDetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Sistema.Instalaciondetalle.Listar(sqlCon, "lst", "lst_grilla", _
            Codigo, _
            InstalacionID, _
            RegionID, _
            PenalID, _
            Lectura, _
            Escritura)

            Try
                objEntCol = New Entity.Sistema.InstalacionDetalleCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Sistema.InstalacionDetalle
                        With objEnt
                            .Codigo = sqlDr("ins_det_id").ToString
                            .InstalacionID = sqlDr("ins_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalCodigo = sqlDr("pen_cod").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Lectura = sqlDr("ins_det_lec").ToString
                            .Escritura = sqlDr("ins_del_esc").ToString
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
        ByVal InstalacionID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal Lectura As Boolean, _
        ByVal Escritura As Boolean, Optional ByVal _Eliminado As Boolean = False) As Integer

            Dim Value As Integer = -1

            Value = Data.Sistema.Instalaciondetalle.Grabar(accion, opcion, Codigo, _
            InstalacionID, _
            RegionID, _
            PenalID, _
            Lectura, _
            Escritura, _
            _Eliminado, _
            Legolas.Configuration.Usuario.Codigo)

            Return Value

        End Function
        Public Function Grabar(ByVal Codigo As Integer, _
        ByVal InstalacionID As Integer, _
        ByVal RegionID As Integer, _
        ByVal PenalID As Integer, _
        ByVal Lectura As Boolean, _
        ByVal Escritura As Boolean) As Integer

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
            InstalacionID, _
            RegionID, _
            PenalID, _
            Lectura, _
            Escritura)

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

            intValue = Data.Sistema.Instalaciondetalle.Eliminar(strAccion, strOpcion, Codigo, _
            Legolas.Configuration.Usuario.Codigo)

            Return intValue
        End Function
#End Region
    End Class
End Namespace