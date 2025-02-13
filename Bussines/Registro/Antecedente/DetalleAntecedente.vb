Imports System.Data.SqlClient

Namespace Registro.Antecedente
    Public Class DetalleAntecedente
        Public Function Listar(ByVal Ent As Entity.Registro.Antecedente.DetalleAntecedente) As Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.DetalleAntecedenteCol
            Dim objEnt As Entity.Registro.Antecedente.DetalleAntecedente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Antecedente.DetalleAntecedente.Listar(sqlCon, "lst", "lst_mant", Ent)

            Try
                If dr.HasRows Then
                    While dr.Read
                        objEnt = New Entity.Registro.Antecedente.DetalleAntecedente
                        With objEnt
                            .Codigo = dr("pk_det_aj").ToString
                            .Fecha = dr("n_fec_res").ToString
                            .Detalle = dr("c_detalle").ToString
                            .Descripcion = dr("c_decripcion").ToString
                            .SolicitudAntecedenteId = dr("fk_sol_ant_id").ToString
                            .RegionId = dr("_regid").ToString
                            .PenalId = dr("_penid").ToString
                        End With
                        list.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                dr.Dispose()
                dr.Close()
                dr = Nothing
                sqlCon.Dispose()
                sqlCon.Close()
                sqlCon = Nothing
            End Try
            Return list
        End Function

        Private Function Validar(ent As Entity.Registro.Antecedente.DetalleAntecedente, ByRef outSMS As String) As Boolean
            Dim v As Boolean = True
            Dim sms As String = ""
            If ent.SolicitudAntecedenteId = -1 Then sms = If(sms.Length > 0, sms & vbCrLf, "") & "Id de la solicitud de antecedentes no válido"

            If sms.Length > 0 Then
                v = False
                outSMS = sms
            End If

            Return v
        End Function

        Public Function Grabar(ent As Entity.Registro.Antecedente.DetalleAntecedente, ByRef outSMS As String) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If Validar(ent, outSMS) = False Then Return -1

            If ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.Antecedente.DetalleAntecedente.Grabar(strAccion, strOpcion, ent, outSMS)

            Return intValue

        End Function
    End Class
End Namespace