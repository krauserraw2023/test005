Imports Data.Mantenimiento.General
Imports Entity.Mantenimiento.General
Imports System.Data.SqlClient
Public Class Piso_BL
    Public Function Listar(codigo As Integer) As Piso_BE
        Dim ls As List(Of Piso_BE) = Listar(New Piso_BE With {.Codigo = codigo})
        Return If(ls.Count > 0, ls(0), Nothing)
    End Function

    Public Function Listar(ent As Piso_BE) As List(Of Piso_BE)
        Dim ls As New List(Of Piso_BE)

        Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Piso_DA.Listar(sqlCon, "lst", "lst_mant", ent)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ls.Add(New Piso_BE With {
                        .Codigo = sqlDr("pk_piso_id").ToString,
                        .PabellonId = sqlDr("fk_pab_id").ToString,
                        .Nombre = sqlDr("c_nombre").ToString,
                        .PisoHabilitado = sqlDr("piso_habilitado").ToString,
                        .IDRegion = sqlDr("_regid").ToString,
                        .IDPenal = sqlDr("_penid").ToString
                    })
                    End While
                End If
            Catch ex As Exception
                Throw New Exception(ex.ToString)
            Finally
                sqlDr.Close()
            End Try
        End Using

        Return ls
    End Function

    Public Function Grabar(ByVal objEnt As Piso_BE) As Integer
        Return Piso_DA.Grabar(If(objEnt.Codigo > 0, "upd", "ins"), If(objEnt.Codigo > 0, "upd_mant", "ins_mant"), objEnt)
    End Function

    Public Function Eliminar(Codigo As Integer) As Integer
        Return Piso_DA.Eliminar("del", "del_mant", Codigo)
    End Function
End Class
