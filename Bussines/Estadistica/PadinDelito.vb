Imports System.Data
Imports System.Data.SqlClient
Imports Entity

Namespace Estadistica
    Public Class PadinDelito
        Private objEnt As Entity.Estadistica.PadinDelito  = Nothing
        Private objEntCol As Entity.Estadistica.PadinDelitoCol = Nothing
#Region "Validar"
        Public Function ValidarEstadoTransferencia(ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = False
            Dim intReg As Integer = 0

            intReg = Data.Estadistica.Padin.ListarOutput("val", "val_estado_transferencia", -1, RegionID, PenalID, -1)

            If intReg > 0 Then
                If intReg < 3 Then
                    Dim strMensaje As String = ""
                    strMensaje = "No se puede generar un nuevo padin. Existe un padin" + Chr(13) +
                                 "en proceso, que no ha sido enviado Transferido."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                Else
                    value = True
                End If
            Else
                value = True
            End If

            Return value

        End Function
        Public Function ValidarEstadoPadin(ByVal RegionID As Integer, ByVal PenalID As Integer) As Boolean

            Dim value As Boolean = False
            Dim intEstado As Integer = 0
            Dim strMensaje As String = ""

            intEstado = Data.Estadistica.Padin.ListarOutput("val", "val_estado_transferencia", -1, RegionID, PenalID, -1)

            Select Case intEstado

                Case Type.Enumeracion.Padin.EnumPadinEstado.Procesado
                    strMensaje = "No se puede generar un nuevo padin. Existe un padin" + Chr(13) +
                                 "en proceso, que no ha sido enviado Transferido."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    Return value

                Case Type.Enumeracion.Padin.EnumPadinEstado.EnviadoRegion, Type.Enumeracion.Padin.EnumPadinEstado.RecepcionRegion

                    strMensaje = "No se puede generar un nuevo padin. Existe un padin" + Chr(13) +
                                 "en estado [Enviado a Region/Recepcionado Region], debe esperar a la region que anule o confirme el Padin."
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                    Return value

            End Select

            value = True

            Return value

        End Function
        Public Function ValidarMaximoPadin(ByVal RegionID As Integer, ByVal PenalID As Integer) As Integer

            Dim intReg As Integer = 0

            intReg = Data.Estadistica.Padin.ListarOutput("val", "max_padin", -1, RegionID, PenalID, -1)

            Return intReg

        End Function
#End Region
#Region "Listar"

        Public Function Listar(objEntFiltro As Entity.Estadistica.PadinDelito) As Entity.Estadistica.PadinDelitoCol

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim sqlDr As SqlDataReader = Data.Estadistica.PadinDelito.Listar(sqlCon, "lst", "lst_mant", objEntFiltro)

            Try
                objEntCol = New Entity.Estadistica.PadinDelitoCol
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Estadistica.PadinDelito
                        With objEnt
                            ' .Codigo = sqlDr("pad_id").ToString
                            .TipoSituacionJuridica = sqlDr("pad_sit_jur_id").ToString
                            .InternoDelitoId = sqlDr("pad_int_del_id").ToString
                            .DelitoEspecificoNombre = sqlDr("pad_del_esp_nom").ToString
                            .DelitoGenericoNombre = sqlDr("pad_del_gen_nom").ToString
                            .ExpedienteNumero = sqlDr("pad_exp_num").ToString
                            .TipoDocumento = sqlDr("pad_tip_doc").ToString
                            .FechaRecepcion = sqlDr("pad_fec_rec").ToString
                            .Agraviados = sqlDr("pad_agr_nom").ToString
                            .FechaRegistro = sqlDr("_fec_cre").ToString
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
        Public Function Grabar(objEnt As Entity.Estadistica.PadinDelito, Optional blnSW As Boolean = False) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt
                If .TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado Then
                    If blnSW = True Then
                        strAccion = "ins"
                        strOpcion = "ins_mant_vis"
                    ElseIf .DelitoMayorPena = True Then
                        strAccion = "ins"
                        strOpcion = "ins_mant"
                    Else
                        strAccion = "upd"
                        strOpcion = "upd_mant"
                    End If
                Else
                    If blnSW = True Then
                        strAccion = "ins"
                        strOpcion = "ins_mant_vis"
                    ElseIf .DelitoSentenciaMayorPena = True Then
                        strAccion = "ins"
                        strOpcion = "ins_mant"
                    Else
                        strAccion = "upd"
                        strOpcion = "upd_mant"
                    End If
                End If

                intValue = Data.Estadistica.PadinDelito.Grabar(strAccion, strOpcion, objEnt)
            End With
            Return intValue
        End Function

        Public Function GrabarPadinDelito(ObjDel As Entity.Registro.Delito, objExp As Entity.Registro.Expediente, Nuevo As Boolean, intIdDel As Integer) As Integer
            Dim intValue As Integer = -1
            If Nuevo = False Then Exit Function

            Dim bss As New Bussines.Estadistica.PadinDelito
            Dim obj As New Entity.Estadistica.PadinDelito
            With ObjDel
                obj.InternoDelitoId = ObjDel.CodigodelitoPad
                obj.InternoId = .InternoID
                obj.IngresoId = .IngresoID
                obj.DelitoEspecificoId = .DelitoEspecifico
                obj.DelitoEspecificoNombre = .DelitoEspecificoNombre
                obj.DelitoGenericoId = .DelitoGenerico
                obj.DelitoGenericoNombre = .DelitoGenericoNombre
                obj.ExpedienteId = objExp.Codigo
                obj.ExpedienteNumero = objExp.ExpedienteNumero
                obj.DocumentoJudicialId = .CreaDocJudicialId
                obj.RegionID = .RegionID
                obj.PenalID = .PenalID
            End With
            If ObjDel.DelitoMayorPena = True Then
                obj.TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado
                obj.DelitoMayorPena = True
                intValue = bss.GrabarVisible(obj)
            End If
            If ObjDel.DelitoSentenciaMayorPena = True Then
                obj.TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Sentenciado
                obj.DelitoSentenciaMayorPena = True
                intValue = bss.GrabarVisible(obj)
            End If

            Return intValue
        End Function

        Public Function GrabarVisible(objEnt As Entity.Estadistica.PadinDelito) As Long

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt
                If .TipoSituacionJuridica = Type.Enumeracion.SituacionJuridica.EnumSituacionJuridica.Procesado Then
                    If .DelitoMayorPena = True Then
                        strAccion = "upd"
                        strOpcion = "upd_mant_vis"
                    End If
                Else
                    If .DelitoSentenciaMayorPena = True Then
                        strAccion = "upd"
                        strOpcion = "upd_mant_vis"
                    End If
                End If

                intValue = Data.Estadistica.PadinDelito.Grabar(strAccion, strOpcion, objEnt)
            End With
            Return intValue
        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, Interno As Integer, IngresoId As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant"

            intValue = Data.Estadistica.PadinDelito.Eliminar(strAccion, strOpcion, Codigo, Interno, IngresoId)
            Return intValue

        End Function
        Public Function Eliminar_v2(ByVal Codigo As Integer) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            strAccion = "del"
            strOpcion = "del_mant_v2"

            intValue = Data.Estadistica.Padin.Eliminar(strAccion, strOpcion, Codigo)
            Return intValue

        End Function
#End Region

    End Class
End Namespace