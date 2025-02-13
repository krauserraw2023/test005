Imports System.Data
Imports System.Data.SqlClient
Namespace Mantenimiento.Registro
    Public Class PadinCuadro13_Detalle
        Private objEnt As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle = Nothing
        Private objEntCol As Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol = Nothing
#Region "Listar"
        Public Function Listar(objEnt As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle) As Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Mantenimiento.Registro.PadinCuadro13_Detalle.Listar(sqlCon, "lst", "lst_grilla", objEnt)

            Try
                objEntCol = New Entity.Mantenimiento.Registro.PadinCuadro13_DetalleCol

                If sqlDr.HasRows Then
                    While sqlDr.Read
                        Me.objEnt = New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
                        With Me.objEnt
                            .Codigo = sqlDr("pk_cua_13_det_id").ToString
                            .IDCuadro13 = sqlDr("fk_cua_13_id").ToString
                            .TipoMovimientoNombre = sqlDr("mov_tip_nom").ToString
                            .IDMovimientoMotivo = sqlDr("fk_mov_mot_id").ToString
                            .MovimientoMotivoNombre = sqlDr("c_tip_egr_nom").ToString
                        End With
                        objEntCol.Add(Me.objEnt)
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
        Public Function ValidarSiExistDelitoEspeEnOtroCuadro(intIDMovimientoMotivo As Integer, strMovimientoMotivo As String, ByRef strMensajeOut As String) As Boolean

            Dim value As Boolean = False
            Dim intIDCuadro As Integer = -1

            objEnt = New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
            With objEnt
                .IDMovimientoMotivo = intIDMovimientoMotivo
            End With

            intIDCuadro = Data.Mantenimiento.Registro.PadinCuadro13_Detalle.ListarOutput("lst", "lst_get_cuadro_movimiento_motivo", objEnt)

            If intIDCuadro < 1 Then
                strMensajeOut = ""
                value = True
            Else

                Dim objBssCuadro As New Bussines.Mantenimiento.Registro.PadinCuadro13
                Dim objEntCuadro As New Entity.Mantenimiento.Registro.PadinCuadro13

                objEntCuadro = objBssCuadro.Listar(intIDCuadro)
                strMensajeOut = "El Motivo del movimiento: " & strMovimientoMotivo & ", existe en el grupo: " & objEntCuadro.Nombre & "/" & objEntCuadro.NombreDetalle

            End If

            Return value

        End Function
#End Region
#Region "Grabar"

        Public Function Grabar(objEntDet As Entity.Mantenimiento.Registro.PadinCuadro13_Detalle, ByRef strMensajeout As String) As Integer

            Dim value As Integer = -1

            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEntDet.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"

                'validar si el delito especifico esta asignado a otro cuadro, no debe permitir grabar
                If ValidarSiExistDelitoEspeEnOtroCuadro(objEntDet.IDMovimientoMotivo, objEntDet.MovimientoMotivoNombre, strMensajeout) = False Then
                    Return value
                End If

            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            value = Data.Mantenimiento.Registro.PadinCuadro13_Detalle.Grabar(strAccion, strOpcion, objEntDet)

            Return value
        End Function

        Public Function Grabar(intIDCuadroDetalle As Integer, intIDCuadro As Integer, intIDMovimientoMotivo As Integer, strMovimientoMotivo As String,
                               ByRef strMensajeout As String) As Integer

            Dim value As Integer = -1
            objEnt = New Entity.Mantenimiento.Registro.PadinCuadro13_Detalle
            With objEnt
                .Codigo = -1
                .IDCuadro13 = intIDCuadro
                .IDMovimientoMotivo = intIDMovimientoMotivo
                .MovimientoMotivoNombre = strMovimientoMotivo
            End With

            If intIDCuadroDetalle > 0 Then
                Eliminar(intIDCuadroDetalle)
                value = Grabar(objEnt, strMensajeout)
            Else
                value = Grabar(objEnt, strMensajeout)
            End If

            Return value

        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Mantenimiento.Registro.PadinCuadro13_Detalle.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue
        End Function
#End Region
    End Class
End Namespace