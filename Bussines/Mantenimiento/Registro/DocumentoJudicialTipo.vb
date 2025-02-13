
Namespace Registro.Documento
    Public Class DocumentoJudicialTipo
        Private objEnt As Entity.Registro.Documento.DocumentoJudicialTipo = Nothing
        Private objEntCol As Entity.Registro.Documento.DocumentoJudicialTipo = Nothing
#Region "Listar"
        Public Function Listar(ByVal intTipoLicencia As Short, intTipoTabla As Short, intPerfilUsuario As Short,
                               Optional ByVal CatDoc As Integer = 99) As Entity.Registro.Documento.DocumentoJudicialTipoCol


            Select Case intPerfilUsuario

                Case Type.Enumeracion.Usuario.EnumDependencia.RegistroIgresoDetenciones,
                    Type.Enumeracion.Usuario.EnumDependencia.RegistroSentenciasLibertades

                Case Else
                    intPerfilUsuario = -1
            End Select

            Return Data.Registro.Documento.DocumentoJudicialTipo.Listar(intTipoLicencia, intTipoTabla, intPerfilUsuario, CatDoc)

        End Function

#End Region

    End Class
End Namespace