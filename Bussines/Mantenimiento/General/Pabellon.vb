Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.General
    Public Class Pabellon
        Private objEnt As Entity.Mantenimiento.General.Pabellon = Nothing
        Private objEntCol As Entity.Mantenimiento.General.PabellonCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Mantenimiento.General.Pabellon

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Mantenimiento.General.Pabellon
            objEntFiltro.Codigo = Codigo
            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Pabellon.Listar(sqlCon, "lst", "", objEntFiltro)
            objEnt = New Entity.Mantenimiento.General.Pabellon
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .Codigo = sqlDr("pab_id").ToString
                            .Nombre = sqlDr("pab_nom").ToString
                            .NombreCorto = sqlDr("pab_nom_cor").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .Obs = sqlDr("pab_obs").ToString
                            .Estado = sqlDr("est_id").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Mantenimiento.General.Pabellon) As Entity.Mantenimiento.General.PabellonCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Pabellon.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Mantenimiento.General.PabellonCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Pabellon
                        With objEnt
                            .Codigo = sqlDr("pab_id").ToString
                            .Nombre = sqlDr("pab_nom").ToString
                            .NombreCorto = sqlDr("pab_nom_cor").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .Obs = sqlDr("pab_obs").ToString
                            .Estado = sqlDr("est_id").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Mantenimiento.General.Pabellon, _
                               ByVal Todos As Boolean, ByVal ComboMensaje As String) As Entity.Mantenimiento.General.PabellonCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.General.Pabellon.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)

            Try
                objEntCol = New Entity.Mantenimiento.General.PabellonCol

                If Todos = True Then
                    Dim obj As New Entity.Mantenimiento.General.Pabellon
                    obj.Codigo = -1
                    obj.Nombre = ComboMensaje
                    objEntCol.Add(obj)
                End If

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.General.Pabellon
                        With objEnt
                            .Codigo = sqlDr("pab_id").ToString
                            .Nombre = sqlDr("pab_nom").ToString
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
#Region "Validar"
        Private Function ValidarPabellon(ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As Boolean

            Dim intCount As Integer = 0

            intCount = Data.Mantenimiento.General.Pabellon.ListarOutput("lst", "val_pabellon_interno", objEnt)

            Return Not (intCount > 0)

        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            With objEnt
                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else

                    If .Estado = 0 Then 'ANULADO
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El registro actual no puede ser modificado, porque ya se encuentra anulado")
                        Return Value
                    End If

                    strAccion = "upd"
                    strOpcion = "upd_mant"

                End If
            End With
            Value = Data.Mantenimiento.General.Pabellon.Grabar(strAccion, strOpcion, objEnt)
            Return Value
        End Function
        Public Function GrabarEstado(ByVal objEnt As Entity.Mantenimiento.General.Pabellon) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            Dim intEstado As Integer = 0 'anulado

            objEnt.Estado = intEstado

            strAccion = "upd"
            strOpcion = "upd_estado"
            
            Value = Data.Mantenimiento.General.Pabellon.Grabar(strAccion, strOpcion, objEnt)

            Return Value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Mantenimiento.General.Pabellon) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            If ValidarPabellon(ObjEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El registro actual no puede ser eliminado, porque ya se encuentra en uso")
                Return Value
            End If

            Value = Data.Mantenimiento.General.Pabellon.Eliminar(strAccion, strOpcion, ObjEnt)

            Return Value

        End Function
#End Region
    End Class
End Namespace
