Imports System.Data
Imports System.Data.SqlClient

Namespace Registro
    Public Class MovimientoExpediente
        Private objEnt As Entity.Registro.MovimientoExpediente = Nothing
        Private objEntCol As Entity.Registro.MovimientoExpedienteCol = Nothing
#Region "Validar"
        Public Function ValidarExpediente(ByVal MovimientoID As Integer, ByVal ExpedienteID As Integer) As Boolean

            Dim blnValue As Boolean = False
            Dim intValue As Integer = 0

            intValue = Data.Registro.MovimientoExpediente.ListarOutput("lst", "lst_expid", -1, MovimientoID, -1, ExpedienteID)

            If intValue > 0 Then
                blnValue = True
            End If
            Return blnValue

        End Function
#End Region
#Region "Listar"

        Public Function Listar(EntMov As Entity.Registro.MovimientoExpediente) As Entity.Registro.MovimientoExpedienteCol
            Dim Ind As Integer = 1
            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.MovimientoExpediente.Listar(sqlCon, "lst", "lst_grilla_mov", EntMov)
            Try
                objEntCol = New Entity.Registro.MovimientoExpedienteCol
                If sqlDr.HasRows Then

                    While sqlDr.Read

                        objEnt = New Entity.Registro.MovimientoExpediente
                        With objEnt
                            Ind = Ind + 1
                            '.Indice = .Indice + 1
                            .Codigo = sqlDr("mov_exp_id").ToString
                            .MovimientoID = sqlDr("mov_id").ToString
                            .ExpedienteID = sqlDr("int_exp_id")
                            .IngresoID = sqlDr("int_ing_id").ToString
                            .InternoID = sqlDr("int_id").ToString
                            .AutoridadJudicialID = sqlDr("aut_jud_id").ToString
                            .AutoridadJudicialNombre = sqlDr("aut_jud_nom").ToString
                            .SalaJudicialID = sqlDr("sal_jus_id").ToString
                            .SalaJudicialNombre = sqlDr("sal_jus_nom").ToString
                            .ExpedienteNumero = sqlDr("int_ing_exp_num").ToString
                            .ExpedienteFecha = sqlDr("int_ing_exp_fec").ToString
                            .ExpedienteFechaDocRecepcion = sqlDr("int_ing_exp_fec_rec").ToString
                            .SituacionJuridicaID = sqlDr("sit_jur_id").ToString
                            .SituacionJuridicaNombre = sqlDr("sit_jur_nom").ToString
                            .Principal = sqlDr("int_exp_pri").ToString
                            .SentenciaPrincipal = sqlDr("int_exp_pri_sen").ToString
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

        Public Function Grabar(ByVal objEnt As Entity.Registro.MovimientoExpediente) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If objEnt.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.MovimientoExpediente.Grabar(strAccion, strOpcion, objEnt)

            Return intValue

        End Function

#End Region
#Region "Eliminar"
        Public Function Eliminar(ByVal Codigo As Integer, ByVal Usuario As Integer, Optional FlagTransferenciaSede As Integer = 0) As Integer
            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""
            strAccion = "del"
            strOpcion = "del_mant"
            intValue = Data.Registro.MovimientoExpediente.Eliminar(strAccion, strOpcion, Codigo, Usuario, FlagTransferenciaSede)
            Return intValue
        End Function
#End Region
    End Class
End Namespace

