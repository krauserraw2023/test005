Namespace Mantenimiento.General
    Public Class Ambiente_BE
        Public Property Codigo As Integer = -1
        Public Property AleroId As Integer = -1
        Public Property AmbienteNombre As String = ""
        Public Property AmbienteHabilitado As Boolean = False
        Public Property IDRegion As Short = -1
        Public Property IDPenal As Short = -1

        '*************** auxiliares ---------------
        Public ReadOnly Property AmbienteHabilitadoStr As String
            Get
                Return If(AmbienteHabilitado, "ACTIVO", "INACTIVO")
            End Get
        End Property
        Public Property AleroNombre As String = ""
        Public Property AleroHabilitado As Boolean = False
        Public Property PisoId As Integer = -1
        Public Property PisoNombre As String = ""
        Public Property PisoHabilitado As Boolean = False
        Public Property PabellonId As Integer = -1
    End Class
End Namespace