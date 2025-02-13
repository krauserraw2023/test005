Namespace Registro.Documento
    Public Class DocumentoJudicialSubTipo
        Private objEnt As Entity.Registro.Documento.DocumentoJudicialSubTipo = Nothing
        Private objEntCol As Entity.Registro.Documento.DocumentoJudicialSubTipo = Nothing
#Region "Listar"
        Public Function Listar(ByVal Codigo As Integer, Optional TipoLicInstalacion As Integer = -1, Optional ByVal CatDoc As Integer = 99) As Entity.Registro.Documento.DocumentoJudicialSubTipoCol
            Return Data.Registro.Documento.DocumentoJudicialSubTipo.Listar(Codigo, TipoLicInstalacion, CatDoc)
        End Function
#End Region

    End Class
End Namespace