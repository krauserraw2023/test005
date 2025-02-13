Imports System.IO.Pipes

Namespace Mantenimiento.General

    Public Class Piso_BE
        Public Property Codigo() As Integer = -1
        Public Property PabellonId() As Integer = -1
        Public Property Nombre() As String = ""
        Public Property PisoHabilitado As Boolean = False
        Public Property IDRegion() As Integer = -1
        Public Property IDPenal() As Integer = -1
        '--------------variable auxiliar
        Public ReadOnly Property PisoHabilitadoStr As String
            Get
                Return If(PisoHabilitado, "ACTIVO", "INACTIVO")
            End Get
        End Property



    End Class

End Namespace