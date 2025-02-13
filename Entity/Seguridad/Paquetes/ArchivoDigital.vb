Namespace Seguridad.Paquetes
    Public Class ArchivoDigital
        Public Property codigo As Integer = -1
        Public Property anio As Short = -1
        Public Property mes As Short = -1
        Public Property mesCorrelativo As Short = -1
        Public Property pcMac As String = ""
        Public Property pcNombre As String = ""
        Public Property pcIP As String = ""
        Public Property archivoByte() As Byte() = Nothing
        Public Property nombreFisico As String = ""
        Public Property extension As String = ""
        Public Property pesoByte As Integer = 0
        Public Property idRegion As Integer = -1
        Public Property idPenal As Integer = -1
    End Class

End Namespace