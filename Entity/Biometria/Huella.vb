Namespace Biometria
    Public Class Huella
        Public Property IDTemplate As Integer = -1
        Public Property IDHuella As Integer = -1
        Public Property TipoDedo As Short = -1
        Public Property EstadoDedo As Short = 0 'disponible
        Public Property HuellaByte As Byte()
        Public Property CalidadHuella As Short = -1
        Public Property TemplateAnsi As Byte()
        Public Property TemplateSuprema As Byte()
        Public Property TemplateWsq As Byte()
        Public Property HayDatos As Boolean = False
        Public Property TipoCaptura As Short = -1
        Public Property Observacion As String = ""

    End Class
End Namespace
