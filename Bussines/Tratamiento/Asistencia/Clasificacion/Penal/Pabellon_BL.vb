Imports System.Data.SqlClient
Imports Data.Mantenimiento.General
Imports Data.Tratamiento.Asistencia.Clasificacion.Penal
Imports Entity.Mantenimiento.General
Imports Entity.Registro

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class Pabellon_BL
        Private objEnt As Pabellon_BE = Nothing
        Private objEntLista As List(Of Pabellon_BE) = Nothing

#Region "Listar"
        Public Function Listar(intCodigo As Integer) As Pabellon_BE

            Dim objEntFiltro As New Pabellon_BE
            With objEntFiltro
                .Codigo = intCodigo
            End With

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Pabellon_DA.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)
            Try

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Pabellon_BE
                        With objEnt
                            .Codigo = sqlDr("pk_pab_id").ToString
                            .Nombre = sqlDr("c_nom").ToString
                            .NombreCorto = sqlDr("c_nom_cor").ToString
                            .Observacion = sqlDr("c_obs").ToString
                            .Estado = sqlDr("n_est").ToString
                            .IDRegion = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("_penid").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
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
        Public Function ListarGrilla(objEntFiltro As Pabellon_BE) As List(Of Pabellon_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Pabellon_DA.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try

                If sqlDr.HasRows Then

                    objEntLista = New List(Of Pabellon_BE)

                    While sqlDr.Read
                        objEnt = New Pabellon_BE
                        With objEnt
                            .Codigo = sqlDr("pk_pab_id").ToString
                            .Nombre = sqlDr("c_nom").ToString
                            .NombreCorto = sqlDr("c_nom_cor").ToString
                            .Estado = sqlDr("n_est").ToString
                            .IDRegion = sqlDr("_regid").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .IDPenal = sqlDr("_penid").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                        End With
                        objEntLista.Add(objEnt)
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
            Return objEntLista
        End Function
#End Region
#Region "Validar"
        Private Function ValidarUsoIDPabellon(intCodigo As Integer) As Boolean

            Dim intCount As Integer = 0

            objEnt = New Pabellon_BE
            With objEnt
                .Codigo = intCodigo
            End With

            intCount = Pabellon_DA.ListarOutput("lst", "val_pabellon_interno", objEnt)

            Return Not (intCount > 0)

        End Function

        Public Function ValidarExisteNombrePabellon(IDPenal As Integer, intCodigo As Integer, strNombre As String) As Boolean

            Dim value As Boolean = False
            Dim intCount As Integer = 0

            objEnt = New Pabellon_BE
            With objEnt
                .Codigo = intCodigo
                .Nombre = strNombre
                .IDPenal = IDPenal
            End With

            intCount = Pabellon_DA.ListarOutput("lst", "val_pabellon_nombre", objEnt)

            If intCount > 0 Then
                value = True
            End If

            Return value

        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(objEnt As Pabellon_BE, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String
            Dim strOpcion As String

            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Pabellon_DA.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function

        Public Function GrabarEstado(intCodigo As Integer, intEstado As Short, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String = "upd"
            Dim strOpcion As String = "upd_estado"

            objEnt = New Pabellon_BE
            With objEnt
                .Codigo = intCodigo
                .Estado = intEstado
            End With

            value = Pabellon_DA.Grabar(strAccion, strOpcion, objEnt)

            Return value
        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(intCodigo As Integer, ByRef strMensajeOut As String) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            If ValidarUsoIDPabellon(intCodigo) = False Then
                strMensajeOut = "El registro actual no puede ser eliminado, porque ya se encuentra en uso"
                Return Value
            End If

            Value = Pabellon_DA.Eliminar(strAccion, strOpcion, intCodigo)

            Return Value

        End Function
#End Region

    End Class

End Namespace
