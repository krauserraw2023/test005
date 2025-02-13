Imports Data.Mantenimiento.General
Imports Entity.Mantenimiento.General
Imports System.Data.SqlClient

Namespace Mantenimiento.General
    Public Class Ambiente_BL
        Public Function ListarGrilla(objEntFiltro As Ambiente_BE) As List(Of Ambiente_BE)
            Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim objEntLista As New List(Of Ambiente_BE)
                Dim sqlDr As SqlDataReader = Ambiente_DA.Listar(sqlCon, "lst", "lst_grilla_sel", objEntFiltro)

                If sqlDr.HasRows Then
                    objEntLista = New List(Of Ambiente_BE)

                    While sqlDr.Read
                        objEntLista.Add(New Ambiente_BE With {
                    .Codigo = sqlDr("pk_ambiente_id").ToString,
                    .AleroId = sqlDr("fk_alero_id").ToString,
                    .AmbienteNombre = sqlDr("ambiente_nom").ToString,
                    .AmbienteHabilitado = sqlDr("amb_habilitado").ToString,
                    .AleroNombre = sqlDr("alero_nom").ToString,
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

        Public Function Listar(codigo As Integer) As Ambiente_BE
            Dim ls As List(Of Ambiente_BE) = Listar(New Ambiente_BE With {.Codigo = codigo})
            Return If(ls.Count > 0, ls(0), Nothing)
        End Function

        Public Function Listar(ent As Ambiente_BE) As List(Of Ambiente_BE)
            Dim ls As New List(Of Ambiente_BE)

            Using sqlCon As New SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim sqlDr As SqlDataReader = Ambiente_DA.Listar(sqlCon, "lst", "lst_mant", ent)
                Try
                    If sqlDr.HasRows Then
                        While sqlDr.Read
                            ls.Add(New Ambiente_BE With {
                            .Codigo = sqlDr("pk_ambiente_id").ToString,
                            .AleroId = sqlDr("fk_alero_id").ToString,
                            .AmbienteNombre = sqlDr("c_nombre").ToString,
                            .AmbienteHabilitado = sqlDr("amb_habilitado").ToString,
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

        Public Function Grabar(ByVal objEnt As Ambiente_BE) As Integer
            Return Ambiente_DA.Grabar(If(objEnt.Codigo > 0, "upd", "ins"), If(objEnt.Codigo > 0, "upd_mant", "ins_mant"), objEnt)
        End Function

        Public Function Eliminar(Codigo As Integer) As Integer
            Return Ambiente_DA.Eliminar("del", "del_mant", Codigo)
        End Function
    End Class

End Namespace
