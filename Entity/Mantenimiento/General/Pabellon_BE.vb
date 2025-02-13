Namespace Mantenimiento.General
    Public Class Pabellon_BE
        'Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property Nombre() As String = ""
        Public Property NombreCorto() As String = ""
        Public Property Observacion() As String = ""
        Public Property Estado() As Short = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""
                Select Case Me.Estado
                    Case 1
                        value = "Activo"
                    Case Else
                        value = "Inactivo"
                End Select

                Return value

            End Get
        End Property
        Public Property IDRegion() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property IDPenal() As Integer = -1
        Public Property PenalNombre As String = ""
#End Region
    End Class
End Namespace