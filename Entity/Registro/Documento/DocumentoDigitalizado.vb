Namespace Registro.Documento
    Public Class DocumentoDigitalizado
        Public Property Codigo() As Integer = -1
        Public Property InternoId() As Integer = -1
        Public Property IngresoId() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property NumeroIngreso As String = ""
        Public Property IngresoNroInpe As String = ""
        Public Property TituloDoc() As String = ""
        Public Property Observaciones() As String = ""
        Public Property RegionId() As Integer = -1
        Public Property PenalId() As Integer = -1
        Public Property FechaRegistro() As Long
        Public ReadOnly Property FechaRegistroDate() As String
            Get
                If Me.FechaRegistro < 1 Then
                    Return ""
                Else
                    Return Legolas.Components.FechaHora.FechaString(Me.FechaRegistro)
                End If
            End Get
        End Property
        Public Property SedeRowId As Integer = -1
    End Class
End Namespace