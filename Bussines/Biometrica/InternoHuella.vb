Namespace Biometria
    Public Class InternoHuella
#Region "Listar"
        Public Function Listar(entIntHuell As Entity.Biometria.InternoHuella, ByRef out_sms As String) As Entity.Biometria.InternoHuellaCol
            Dim lst As New Entity.Biometria.InternoHuellaCol

            lst = Data.Biometria.InternoHuella.Listar("lst", "lst_mant", entIntHuell, out_sms)

            Return lst
        End Function

        Public Function Listar(Codigo As Integer, ByRef out_sms As String) As Entity.Biometria.InternoHuella
            Dim lst As New Entity.Biometria.InternoHuellaCol

            Dim entIntHuell As New Entity.Biometria.InternoHuella
            entIntHuell.Codigo = Codigo

            lst = Listar(entIntHuell, out_sms)

            If lst Is Nothing Then
                entIntHuell = Nothing
            Else
                If lst.Count > 0 Then
                    entIntHuell = lst.Item(0)
                Else
                    entIntHuell = Nothing
                End If
            End If

            Return entIntHuell
        End Function
#End Region
#Region "Grabar"
        Public Function Grabar(EntIntHuell As Entity.Biometria.InternoHuella, ByRef out_sms As String) As Integer
            Dim err As Boolean = False
            Dim opcion As String = ""
            Dim accion As String = ""

            If EntIntHuell Is Nothing Then
                out_sms = "El registro de huella del interno no puede ser nulo"
                err = True
            End If
         
            If err Then Return -1

            If EntIntHuell.Codigo < 0 Then
                accion = "ins"
                opcion = "ins_mant"
            Else
                accion = "upd"
                opcion = "upd_mant"
            End If

            Return Data.Biometria.InternoHuella.Grabar(accion, opcion, EntIntHuell, out_sms)
        End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim err As Boolean = False
            If Codigo <= 0 Then
                out_sms = "Id del registro no válido"
                err = True
            End If
            If IdUsuario <= 0 Then
                out_sms = out_sms & " Id de usuario no válido"
                err = True
            End If

            If err Then Return -1

            Return Data.Biometria.InternoHuella.Eliminar("del", "del_mant", Codigo, out_sms)
        End Function
#End Region
    End Class
End Namespace