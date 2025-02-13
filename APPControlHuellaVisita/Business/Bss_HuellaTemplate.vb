Namespace Business
    Public Class Bss_HuellaTemplate
        Private c_cnBD As String = ""
#Region "Listar"
        Public Function Listar(entTmpl As Entity.Ent_HuellaTemplate, ByRef out_sms As String) As Entity.HuellaTemplateCol
            Dim lst As New Entity.HuellaTemplateCol

            lst = Data.Dat_HuellaTemplate.Listar("lst", "lst_mant", c_cnBD, entTmpl, out_sms)

            Return lst
        End Function

        Public Function Listar(Codigo As Integer, ByRef out_sms As String) As Entity.Ent_HuellaTemplate
            Dim lst As New Entity.HuellaTemplateCol

            Dim entTmpl As New Entity.Ent_HuellaTemplate
            entTmpl.Codigo = Codigo

            lst = Listar(entTmpl, out_sms)

            If lst Is Nothing Then
                entTmpl = Nothing
            Else
                If lst.Count > 0 Then
                    entTmpl = lst.Item(0)
                Else
                    entTmpl = Nothing
                End If
            End If
            Return entTmpl
        End Function
#End Region

#Region "Validar"

        Private Function ValidarGrabarWSQ(ByVal entWSQ As Entity.Ent_HuellaWSQ, ByRef out_sms As String) As Boolean
            Dim blnVal As Boolean = False
            If entWSQ Is Nothing Then
                out_sms = "Objeto HuellaWSQ nulo"
                Return True
            End If
            If entWSQ.WSQFile Is Nothing Then
                out_sms = "Imagen comprimida en formato WSQ no existe"
                blnVal = True
            End If
            If entWSQ.HuellaTemplateId <= -1 And entWSQ.Codigo > 0 Then
                out_sms = out_sms & ", No se ha especificado el Id de la plantilla(Template) de la huella"
                blnVal = True
            End If
            If entWSQ.RegionId <= -1 Then
                out_sms = out_sms & ", No se ha especificado la región"
                blnVal = True
            End If
            If entWSQ.PenalId <= -1 Then
                out_sms = out_sms & ", No se ha especificado el penal"
                blnVal = True
            End If

            Return blnVal
        End Function

        Private Function ValidarGrabarPlantilla(ByVal entTmpl As Entity.Ent_HuellaTemplate, ByRef out_sms As String) As Boolean
            Dim blnVal As Boolean = False
            'If entTmpl.DocTipoId = -1 Or entTmpl.NumDocumento = "" Then
            '    out_sms = "Especificar tipo y número de documento"
            '    Return True
            'End If
            If entTmpl.EstadoDedo = Type.Enumeracion.EstadoDedo.NoEspecificado Then
                out_sms = "Debe especificar el estado del dedo"
                Return True
            End If
            If entTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.Amputado And entTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.NoDisponible Then
                If entTmpl.IndiceCalidadImg = -1 Or entTmpl.IndiceCalidadImg = Type.Enumeracion.IndiceCalidadHuella.NoEspecificado Then
                    out_sms = "Indice de calidad de huella inválido"
                    Return True
                End If
                If entTmpl.TemplateANSI Is Nothing Then
                    out_sms = "Plantilla en formado ANSI inválido"
                    Return True
                End If
                'template suprema
                If entTmpl.DispBiometricoId = Type.Enumeracion.enumTipoDispositivo.RealScanG1 Then
                    If entTmpl.TemplatePropietario Is Nothing Then
                        out_sms = "Plantilla en formato propietario inválido"
                        Return True
                    End If
                End If
            End If
            If entTmpl.EstadoDedo = Type.Enumeracion.EstadoDedo.Amputado Or entTmpl.EstadoDedo = Type.Enumeracion.EstadoDedo.NoDisponible Then
                entTmpl.TemplateANSI = Nothing
                entTmpl.TemplatePropietario = Nothing
            End If

            If entTmpl.PenalId = -1 Or entTmpl.RegionId = -1 Then
                out_sms = "Especificar penal y región"
                Return True
            End If

                        
            If entTmpl.TipoDedoId = Type.Enumeracion.TipoDedo.NoEspecificado Then
                out_sms = "Tipo de dedo no especificado"
                Return True
            End If
            'para otros campos obligatorios verificar. pendientehnrb
            Return blnVal
        End Function

        Private Function ValidarGrabarPlantillaTrat(ByVal entTmpl As Entity.Ent_HuellaTemplate, ByRef out_sms As String) As Boolean
            Dim blnVal As Boolean = False
            If entTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.NoDisponible And entTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.Amputado Then
                If entTmpl.EstadoDedo = Type.Enumeracion.EstadoDedo.NoEspecificado Then
                    out_sms = "Debe especificar el estado del dedo"
                    Return True
                End If
                If entTmpl.IndiceCalidadImg = -1 Or entTmpl.IndiceCalidadImg = Type.Enumeracion.IndiceCalidadHuella.NoEspecificado Then
                    out_sms = "Indice de calidad de huella inválido"
                    Return True
                End If
                If entTmpl.TemplateANSI Is Nothing Then
                    out_sms = "Plantilla en formado ANSI inválido"
                    Return True
                End If
                If entTmpl.TemplatePropietario Is Nothing Then
                    out_sms = "Plantilla en formato propietario inválido"
                    Return True
                End If
                If entTmpl.TipoDedoId = Type.Enumeracion.TipoDedo.NoEspecificado Then
                    out_sms = "Tipo de dedo no especificado"
                    Return True
                End If
            End If
            If entTmpl.PenalId = -1 Or entTmpl.RegionId = -1 Then
                out_sms = "Especificar penal y región"
                Return True
            End If

            'para otros campos obligatorios verificar. pendientehnrb
            Return blnVal
        End Function


#End Region

#Region "Grabar"
        
        Public Function Grabar(ByVal EntTmpl As Entity.Ent_HuellaTemplate, EntWSQ As Entity.Ent_HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intId As Integer
            
            If ValidarGrabarPlantilla(EntTmpl, out_sms) = True Then Return -1

            If EntTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.Amputado And EntTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.NoDisponible Then
                If Not EntWSQ Is Nothing Then 'es posible insertar un registro tmpl sin wsq
                    If ValidarGrabarWSQ(EntWSQ, out_sms) = True Then Return -1
                End If
            Else
                EntWSQ.WSQFile = Nothing
                EntTmpl.TemplateANSI = Nothing
                EntTmpl.TemplatePropietario = Nothing
            End If

            Dim strOpcion As String
            Dim strAccion As String

            If EntTmpl.Codigo = -1 Then
                strAccion = "ins"
                strOpcion = "ins_mant"
            Else
                strAccion = "upd"
                strOpcion = "upd_mant"
            End If
            intId = Data.Dat_HuellaTemplate.Grabar(strAccion, strOpcion, c_cnBD, EntTmpl, EntWSQ, IdUsuario, out_sms)
            Return intId
        End Function

        Public Function GrabarTratamiento(ByVal EntTmpl As Entity.Ent_HuellaTemplate, EntWSQ As Entity.Ent_HuellaWSQ, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intId As Integer

            If ValidarGrabarPlantillaTrat(EntTmpl, out_sms) = True Then Return -1

            If EntTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.NoDisponible And EntTmpl.EstadoDedo <> Type.Enumeracion.EstadoDedo.Amputado Then
                If Not EntWSQ Is Nothing Then 'es posible insertar un registro tmpl sin wsq
                    If ValidarGrabarWSQ(EntWSQ, out_sms) = True Then Return -1
                End If
            End If
            intId = Data.Dat_HuellaTemplate.GrabarTratamiento("ins", "ins_mant", c_cnBD, EntTmpl, EntWSQ, IdUsuario, out_sms)

            Return intId
        End Function
#End Region

#Region "Eliminar"
        Public Function Eliminar(Codigo As Integer, IdUsuario As Integer, ByRef out_sms As String) As Integer
            Dim intId As Integer = -1
            intId = Data.Dat_HuellaTemplate.Eliminar("del", "del_mant", c_cnBD, Codigo, IdUsuario, out_sms)
            Return intId
        End Function
#End Region

        Public Sub New(cnBD As String)
            Me.c_cnBD = cnBD
        End Sub
    End Class
End Namespace