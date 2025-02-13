Namespace Mantenimiento.General
    Public Class Alero_BE
        Public Property Codigo As Integer = -1
        Public Property Nombre As String = ""
        Public Property AleroHabilitado As Boolean = False
        Public Property IDRegion As Integer = -1
        Public Property IDPenal As Integer = -1
        '--------------variable auxiliar
        Public ReadOnly Property AleroHabilitadoStr As String
            Get
                Return If(AleroHabilitado, "ACTIVO", "INACTIVO")
            End Get
        End Property
        Public Property PisoId As Integer = -1
        Public Property PisoNombre As String = ""
        Public Property PisoHabilitado As Boolean = False
        Public Property PabellonId As Integer = -1
    End Class
End Namespace