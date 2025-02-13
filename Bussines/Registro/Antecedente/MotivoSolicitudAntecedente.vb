Imports System.Data.SqlClient

Namespace Registro.Antecedente
    Public Class MotivoSolicitudAntecedente

        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.Antecedente.MotivoSolicitudAntecedente
            Dim objEnt As New Entity.Registro.Antecedente.MotivoSolicitudAntecedente
            Dim list As Entity.Registro.Antecedente.MotivoSolicitudAntecedenteCol

            objEnt.Codigo = Codigo
            list = Listar(objEnt)

            Return If(list.Count > 0, list.MotivoSolicitudAntecedente(0), Nothing)
        End Function

        Public Function Listar(ByVal Ent As Entity.Registro.Antecedente.MotivoSolicitudAntecedente) As Entity.Registro.Antecedente.MotivoSolicitudAntecedenteCol
            Dim list As New Entity.Registro.Antecedente.MotivoSolicitudAntecedenteCol
            Dim objEnt As Entity.Registro.Antecedente.MotivoSolicitudAntecedente

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim dr As SqlDataReader = Data.Registro.Antecedente.MotivoSolicitudAntecedente.Listar(sqlCon, "lst", "lst_mant", Ent)

            Try
                If dr.HasRows Then
                    While dr.Read
                        objEnt = New Entity.Registro.Antecedente.MotivoSolicitudAntecedente
                        With objEnt
                            .Codigo = dr("pk_mot_sol_id").ToString
                            .Motivo = dr("c_motivo").ToString
                            .TipoAutoridadJudicialId = dr("tip_aut_jud_id").ToString
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
    End Class
End Namespace