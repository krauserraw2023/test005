Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Registro
    Public Class Movimiento
        Private objEnt As Entity.Mantenimiento.Registro.Movimiento = Nothing
        Private objEntCol As Entity.Mantenimiento.Registro.MovimientoCol = Nothing
#Region "Listar"

        Public Function ListarMotivoxLicencia(intTipoMovimiento As Short, intIDTipoLicencia As Short) As Entity.Mantenimiento.Registro.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Mantenimiento.Registro.Movimiento
            With objEnt
                .IDTipoLicencia = intIDTipoLicencia
                .MovimientoTipoID = intTipoMovimiento
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Registro.Movimiento.Listar(sqlCon, "lst", "lst_grilla_motivo_licencia", objEnt)

            Try
                objEntCol = New Entity.Mantenimiento.Registro.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Registro.Movimiento
                        With objEnt
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoTipoDescripcion = sqlDr("mov_tip_des").ToString
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

        Public Function ListarMotivo(intTipoMovimiento As Short, strNombre As String) As Entity.Mantenimiento.Registro.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Mantenimiento.Registro.Movimiento
            With objEnt
                .MovimientoTipoID = intTipoMovimiento
                .MovimientoMotivoNombre = strNombre
            End With

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Registro.Movimiento.Listar(sqlCon, "lst", "lst_grilla_motivo", objEnt)

            Try
                objEntCol = New Entity.Mantenimiento.Registro.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Registro.Movimiento
                        With objEnt
                            .Codigo = sqlDr("mov_mot_id").ToString
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
                            .MovimientoMotivoNombre = sqlDr("mov_mot_nom").ToString
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

        Public Function ComboTipo() As Entity.Mantenimiento.Registro.MovimientoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            objEnt = New Entity.Mantenimiento.Registro.Movimiento

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Registro.Movimiento.Listar(sqlCon, "lst", "lst_combo_tipo", objEnt)

            Try
                objEntCol = New Entity.Mantenimiento.Registro.MovimientoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Mantenimiento.Registro.Movimiento
                        With objEnt
                            .MovimientoTipoID = sqlDr("mov_tip_id").ToString
                            .MovimientoTipoNombre = sqlDr("mov_tip_nom").ToString
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
        Public Function fn_ListarMotivoNombre(intCuadro As Short, strTipoTabla As String, intCodigo As Integer) As String

            Dim value As String = ""
            Dim strQuery As String = ""

            Select Case intCuadro
                Case 1
                    Select Case strTipoTabla.ToUpper
                        Case "Libertad".ToUpper
                            strQuery = "select par_nom from INT_LibertadTipo where par_id=" & intCodigo

                        Case "Traslado".ToUpper
                            strQuery = "select trs_nom from INT_Traslado where trs_id=" & intCodigo
                    End Select

                Case 2
                    strQuery = "select mov_mot_nom from INT_MovimientoMotivo where mov_mot_id=" & intCodigo
            End Select

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objDT As New DataTable

            objDT = Legolas.Components.SQL.Select_DataTable(sqlCon, strQuery)

            value = objDT.Rows.Item(0).Item(0).ToString

            Return value

        End Function
#End Region

    End Class
End Namespace