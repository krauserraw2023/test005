Imports System.Data.SqlClient

Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class PabellonRegimenEtapa_BL
        Private objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE = Nothing
        Private objEntLista As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE) = Nothing
        Public Function ListarGrilla(objEntFiltro As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE) As List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE)

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_DA.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try

                If sqlDr.HasRows Then

                    objEntLista = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE)

                    While sqlDr.Read
                        objEnt = New Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE
                        With objEnt
                            .Codigo = sqlDr("pk_pab_reg_etp_id").ToString
                            .IDPabellon = sqlDr("fk_pab_id").ToString
                            .PabellonNombre = sqlDr("pab_nom").ToString
                            .IDRegimen = sqlDr("n_reg_id").ToString
                            .IDEtapa = sqlDr("n_etp_id").ToString
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

        Private Function ValidarExisteRegimenEtapa(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False

            Dim objEntFiltro As New Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE
            objEntLista = New List(Of Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE)

            With objEntFiltro
                .IDRegion = objEnt.IDRegion
                .IDPenal = objEnt.IDPenal
                .IDPabellon = objEnt.IDPabellon
            End With

            objEntLista = ListarGrilla(objEntFiltro)

            For Each objFila As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE In objEntLista

                If objEnt.IDRegimen = objFila.IDRegimen And objEnt.IDEtapa = objFila.IDEtapa Then
                    strMensajeOut = "El regimen/etapa que desea agregar ya existe para el pabellon"
                    value = True
                    Exit For
                End If
            Next

            Return value
        End Function

        Public Function Grabar(objEnt As Entity.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_BE, ByRef strMensajeOut As String) As Integer

            Dim value As Integer = -1
            Dim strAccion As String
            Dim strOpcion As String

            If objEnt.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                If ValidarExisteRegimenEtapa(objEnt, strMensajeOut) = True Then
                    Return value
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_DA.Grabar(strAccion, strOpcion, objEnt)

            Return value

        End Function
        Public Function Eliminar(intCodigo As Integer) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            Value = Data.Tratamiento.Asistencia.Clasificacion.Penal.PabellonRegimenEtapa_DA.Eliminar(strAccion, strOpcion, intCodigo)

            Return Value

        End Function
    End Class
End Namespace