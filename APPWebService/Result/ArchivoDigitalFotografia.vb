Namespace Result
    Public Class ArchivoDigitalFotografia

        Public Property codigo As Integer = -1
        Public Property tipoFotografia As Integer = -1
        Public Property idTablaReferencia As Integer = -1 'IdInterno, IdVisitante, IdReniec valor que depende de tipo
        Public Property anio As Integer = -1
        Public Property mes As String = ""
        Public Property mesCorrelativo As String = ""
        Public Property pcMAC As String = ""
        Public Property pcNombre As String = ""
        Public Property pcIP As String = ""
        Public Property pcDirectorioLocal As String = ""
        Public Property nombreFisico As String = ""
        Public Property extension As String = ""
        Public Property peso As Integer = -1
        Public Property fechaCreacion As Long = 0
        Public Property fechaModificacion As Long = 0
        Public Property fechaImportacion As Long = 0
        Public Property rutaServidor As String = ""
        Public Property archivoSubidoWeb As Boolean = False
        Public Property archivoByte As Byte() = Nothing
        Public Property idRegion As Integer = -1
        Public Property idPenal As Integer = -1

    End Class

End Namespace

