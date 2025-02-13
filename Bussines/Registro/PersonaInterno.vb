Imports System.Data.SqlClient

Namespace Registro
    Public Class PersonaInterno

#Region "listar"
        Public Function Listar(ByVal Codigo As Integer) As Entity.Registro.PersonaInterno
            Dim list As New Entity.EntityCol(Of Entity.Registro.PersonaInterno)
            Dim ent As New Entity.Registro.PersonaInterno
            ent.Codigo = Codigo
            list = Listar(ent)
            If list.Count = 0 Then
                Return Nothing
            Else
                ent = list.Item(0)
            End If
            Return ent
        End Function

        Public Function Listar(ent As Entity.Registro.PersonaInterno) As Entity.EntityCol(Of Entity.Registro.PersonaInterno)
            Dim lst As New Entity.EntityCol(Of Entity.Registro.PersonaInterno)
            Dim objEnt As Entity.Registro.PersonaInterno

            Dim sqlCon As SqlConnection = New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Data.Registro.PersonaInterno.Listar(sqlCon, "lst", "lst_mant", ent)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        objEnt = New Entity.Registro.PersonaInterno
                        With objEnt
                            .Codigo = sqlDr("pk_per_int_id").ToString
                            .PersonaId = sqlDr("fk_per_id").ToString
                            .InternoId = sqlDr("fk_int_id").ToString
                            .CodigoRP = sqlDr("c_cod_rp").ToString
                            .Nombre = sqlDr("c_nom").ToString
                            .ApePaterno = sqlDr("c_ape_pat").ToString
                            .ApeMaterno = sqlDr("c_ape_mat").ToString
                            .NombrePrincipal = sqlDr("b_reg_pri").ToString
                            .RegionId = sqlDr("_RegId").ToString
                            .PenalId = sqlDr("_PenId").ToString
                        End With
                        lst.Add(objEnt)
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Close()
                sqlDr = Nothing
                sqlCon.Close()
                sqlCon = Nothing
            End Try

            Return lst
        End Function
#End Region

        Public Function Grabar(ent As Entity.Registro.PersonaInterno) As Integer
            'validar()

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            If ent.Codigo < 1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If

            intValue = Data.Registro.PersonaInterno.Grabar(strAccion, strOpcion, ent)

            Return intValue

        End Function

        Public Function Eliminar(ByVal Codigo As Integer, ByRef outSMS As String) As Integer
            Dim intValue As Integer = -1

            intValue = Data.Registro.PersonaInterno.Eliminar("del", "del_mant", Codigo, outSMS)
            Return intValue
        End Function

    End Class
End Namespace