Namespace Sistema.Seguridad
    Public Class UsuarioHuella
        Private objEnt As Entity.Sistema.Seguridad.UsuarioHuella = Nothing
        Private objEntCol As Entity.Sistema.Seguridad.UsuarioHuellaCol = Nothing

        Public Function ListarPorUsuario(UsuarioId As Integer) As Entity.Sistema.Seguridad.UsuarioHuella

            Dim ent As New Entity.Sistema.Seguridad.UsuarioHuella
            ent.UsuarioId = UsuarioId

            Dim col As Entity.Sistema.Seguridad.UsuarioHuellaCol = Data.Sistema.Seguridad.UsuarioHuella.Listar(ent)

            If col.Count = 0 Then
                Return Nothing
            Else
                Return col.Session(0)
            End If

        End Function

        Public Function Grabar(objEnt As Entity.Sistema.Seguridad.UsuarioHuella) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt

                If .Codigo < 1 Then
                    strAccion = "ins"
                    strOpcion = "ins_mant"
                Else
                    strAccion = "upd"
                    strOpcion = "upd_mant"
                End If

                intValue = Data.Sistema.Seguridad.UsuarioHuella.Grabar(strAccion, strOpcion, objEnt)

            End With

            Return intValue

        End Function
        Public Function ActualizarHuellaDer(objEnt As Entity.Sistema.Seguridad.UsuarioHuella) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt

                If .Codigo > 0 Then
                    strAccion = "upd"
                    strOpcion = "upd_mant_hue_der"
                End If

                intValue = Data.Sistema.Seguridad.UsuarioHuella.Grabar(strAccion, strOpcion, objEnt)

            End With

            Return intValue

        End Function
        Public Function ActualizarHuellaIzq(objEnt As Entity.Sistema.Seguridad.UsuarioHuella) As Integer

            Dim intValue As Integer = -1
            Dim strAccion As String = ""
            Dim strOpcion As String = ""

            With objEnt

                If .Codigo > 0 Then
                    strAccion = "upd"
                    strOpcion = "upd_mant_hue_izq"
                End If

                intValue = Data.Sistema.Seguridad.UsuarioHuella.Grabar(strAccion, strOpcion, objEnt)

            End With

            Return intValue

        End Function
    End Class
End Namespace
