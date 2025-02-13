Namespace Business
    Public Class Bss_HuellaWSQ
        Private c_cnBD As String = ""
#Region "Listar"
        Public Function Listar(entHuellaWSQ As Entity.Ent_HuellaWSQ, ByRef out_sms As String) As Entity.HuellaWSQCol
            Dim lst As New Entity.HuellaWSQCol

            lst = Data.Dat_HuellaWSQ.Listar("lst", "lst_mant", Me.c_cnBD, entHuellaWSQ, out_sms)

            Return lst
        End Function

        Public Function Listar(Codigo As Integer, ByRef out_sms As String) As Entity.Ent_HuellaWSQ
            Dim lst As New Entity.HuellaWSQCol

            Dim entHuellaWSQ As New Entity.Ent_HuellaWSQ
            entHuellaWSQ.Codigo = Codigo

            lst = Listar(entHuellaWSQ, out_sms)

            If lst Is Nothing Then
                entHuellaWSQ = Nothing
            Else
                If lst.Count > 0 Then
                    entHuellaWSQ = lst.Item(0)
                Else
                    entHuellaWSQ = Nothing
                End If
            End If

            Return entHuellaWSQ
        End Function
#End Region
#Region "Grabar"
        'Private Function ExisteErrorValidacionGrabar(ByVal entWSQ As Entity.Biometria.HuellaWSQ, ByRef out_sms As String) As Boolean
        '    Dim blnVal As Boolean = False
        '    If entWSQ Is Nothing Then
        '        out_sms = "Objeto HuellaWSQ nulo"
        '        Return True
        '    End If
        '    If entWSQ.WSQFile Is Nothing Then
        '        out_sms = "Imagen comprimida en formato WSQ no existe"
        '        blnVal = True
        '    End If
        '    If entWSQ.HuellaTemplateId <= -1 Then
        '        out_sms = out_sms & ", No se ha especificado el Id de la plantilla(Template) de la huella"
        '        blnVal = True
        '    End If
        '    If entWSQ.RegionId <= -1 Then
        '        out_sms = out_sms & ", No se ha especificado la región"
        '        blnVal = True
        '    End If
        '    If entWSQ.PenalId <= -1 Then
        '        out_sms = out_sms & ", No se ha especificado el penal"
        '        blnVal = True
        '    End If

        '    Return blnVal
        'End Function

        'Public Function Grabar(ByVal entWSQ As Entity.Biometria.HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer
        '    Dim intId As Integer

        '    If ExisteErrorValidacionGrabar(entWSQ, out_sms) = True Then Return -1
        '    If IdUsuario = -1 Then
        '        out_sms = "Usuario no válido"
        '        Return -1
        '    End If

        '    Dim strOpcion As String = ""
        '    Dim strAccion As String = ""

        '    If entWSQ.Codigo < 0 Then
        '        strAccion = "ins"
        '        strOpcion = "ins_mant"
        '    Else
        '        strAccion = "upd"
        '        strOpcion = "upd_mant"
        '    End If

        '    intId = Data.Biometria.HuellaWSQ.Grabar("ins", strOpcion, entWSQ, IdUsuario, out_sms)

        '    Return intId
        'End Function
#End Region
#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intId As Integer = -1
            intId = Data.Dat_HuellaWSQ.Eliminar("del", "del_mant", Me.c_cnBD, Codigo, IdUsuario, out_sms)
            Return intId
        End Function

        'Public Function EliminarPorTemplate(templateId As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
        '    If IdUsuario = -1 Then
        '        out_sms = "Usuario no válido"
        '        Return -1
        '    End If
        '    Dim intId As Integer = -1
        '    intId = Data.Biometria.HuellaWSQ.EliminarPorTmplId("del", "del_mant_x_tmplid", templateId, IdUsuario, out_sms)
        '    Return intId
        'End Function
#End Region
        Public Sub New(cnBD As String)
            Me.c_cnBD = cnBD
        End Sub

    End Class
End Namespace