Imports System.Data.SqlClient
Imports Data.Mantenimiento.General
Imports Entity.Mantenimiento.General

Public Class Alero_BL
    Public Function ListarGrilla(objEntFiltro As Alero_BE) As List(Of Alero_BE)
        Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim objEntLista As New List(Of Alero_BE)
            Dim sqlDr As SqlDataReader = Alero_DA.Listar(sqlCon, "lst", "lst_grilla_sel", objEntFiltro)
            'artificio modificado 10/11/2023
            If sqlDr.HasRows Then
                objEntLista = New List(Of Alero_BE)

                While sqlDr.Read
                    objEntLista.Add(New Alero_BE With {
                    .Codigo = sqlDr("pk_alero_id").ToString,
                    .Nombre = sqlDr("c_nombre").ToString,
                    .AleroHabilitado = sqlDr("ala_habilitado").ToString,
                    .PisoId = sqlDr("pk_piso_id").ToString,
                    .PisoNombre = sqlDr("piso_nom").ToString,
                    .PisoHabilitado = sqlDr("piso_habilitado").ToString,
                    .PabellonId = sqlDr("fk_pab_id").ToString
                })
                End While
            End If

            Return objEntLista
        End Using
    End Function
    Public Function Listar(codigo As Integer) As Alero_BE
        Dim ls As List(Of Alero_BE) = Listar(New Alero_BE With {.Codigo = codigo})
        Return If(ls.Count > 0, ls(0), Nothing)
    End Function

    Public Function Listar(ent As Alero_BE) As List(Of Alero_BE)
        Dim ls As New List(Of Alero_BE)
        'as
        Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
            Dim sqlDr As SqlDataReader = Alero_DA.Listar(sqlCon, "lst", "lst_mant", ent)
            Try
                If sqlDr.HasRows Then
                    While sqlDr.Read
                        ls.Add(New Alero_BE With {
                        .Codigo = sqlDr("pk_alero_id").ToString,
                        .PisoId = sqlDr("fk_piso_id").ToString,
                        .Nombre = sqlDr("c_nombre").ToString,
                        .AleroHabilitado = sqlDr("ala_habilitado").ToString,
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

    Public Function Grabar(ByVal objEnt As Alero_BE) As Integer
        Return Alero_DA.Grabar(If(objEnt.Codigo > 0, "upd", "ins"), If(objEnt.Codigo > 0, "upd_mant", "ins_mant"), objEnt)
    End Function

    Public Function Eliminar(Codigo As Integer) As Integer
        Return Alero_DA.Eliminar("del", "del_mant", Codigo)
    End Function
End Class
