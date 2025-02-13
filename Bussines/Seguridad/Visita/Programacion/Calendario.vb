Imports System.Data
Imports System.Data.SqlClient
Namespace Visita.Programacion
    Public Class Calendario
        Private objEnt As Entity.Visita.Programacion.Calendario = Nothing
        Private objEntCol As Entity.Visita.Programacion.CalendarioCol = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Visita.Programacion.Calendario

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntFiltro As New Entity.Visita.Programacion.Calendario
            objEntFiltro.CalendarioID = Codigo
            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.Calendario.Listar(sqlCon, "lst", "", objEntFiltro)
            objEnt = New Entity.Visita.Programacion.Calendario
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        With objEnt
                            .CalendarioID = sqlDr("cal_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString()
                            .RegimenVisitaID = sqlDr("reg_vis_id").ToString
                            .VisitaTipoID = sqlDr("vis_tip_id").ToString                            
                            .FechaRegistro = sqlDr("cal_fec_reg").ToString                            
                            .Estado = sqlDr("cal_est").ToString
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
        Public Function Listar(ByVal objEntFiltro As Entity.Visita.Programacion.Calendario) As Entity.Visita.Programacion.CalendarioCol
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Visita.Programacion.Calendario.Listar(sqlCon, "lst", "lst_grilla", objEntFiltro)
            Try
                objEntCol = New Entity.Visita.Programacion.CalendarioCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Visita.Programacion.Calendario
                        With objEnt
                            .CalendarioID = sqlDr("cal_id").ToString
                            .RegionID = sqlDr("reg_id").ToString
                            .RegionNombre = sqlDr("reg_nom").ToString
                            .PenalID = sqlDr("pen_id").ToString
                            .PenalNombre = sqlDr("pen_nom").ToString
                            .RegimenVisitaID = sqlDr("reg_vis_id").ToString
                            .RegimenVisita = sqlDr("reg_vis_nom").ToString
                            .VisitaTipoID = sqlDr("vis_tip_id").ToString
                            .VisitaTipo = sqlDr("vis_tip_nom").ToString                            
                            .FechaRegistro = sqlDr("cal_fec_reg").ToString
                            .Estado = sqlDr("cal_est").ToString
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
        Private Function Validar(ByVal objEnt As Entity.Visita.Programacion.Calendario) As Boolean

            'Dim value As Boolean = False
            Dim intValue As Integer = 0

            intValue = Data.Visita.Programacion.Calendario.ListarOutput("lst", "val_calendario", objEnt)

            Return Not (intValue > 0)

        End Function
        Public Function ValidarCalendario(ByVal objEnt As Entity.Visita.Programacion.Calendario) As Boolean
            Return Validar(objEnt)
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(ByVal objEnt As Entity.Visita.Programacion.Calendario) As Integer

            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(objEnt) = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El tipo de visita que desea agregar ya existe")
                Return Value
            End If

            With objEnt
                If .CalendarioID < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If
            End With

            Value = Data.Visita.Programacion.Calendario.Grabar(strAccion, strOpcion, objEnt)

            Return Value

        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal ObjEnt As Entity.Visita.Programacion.Calendario) As Integer
            Dim Value As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            Value = Data.Visita.Programacion.Calendario.Eliminar(strAccion, strOpcion, ObjEnt)
            Return Value
        End Function
#End Region
    End Class
End Namespace