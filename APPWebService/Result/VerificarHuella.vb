Namespace Result
    Public Class VerificarHuella
        Public Property ErrorCodigo As String = ""
        Public ReadOnly Property Corresponde() As String
            Get
                Dim value As String = "NO"

                Select Case Me.ErrorCodigo
                    Case "70006"
                        value = "SI"
                End Select
                Return value
            End Get
        End Property
        Public Property ErrorMensaje As String = ""
        Public ReadOnly Property HayError As Boolean
            Get
                Dim value As Boolean = True

                If Me.ErrorCodigo < 1 Then
                    Return value
                End If

                value = False
                Return value
            End Get
        End Property
        Public Property NumeroDNI As String = ""
        Public Property PrimerApellido As String = ""
        Public Property SegundoApellido As String = ""
        Public Property Nombres As String = ""
        Public Property FechaCaducidadDNI As String = ""
        Public Property Restriccion As String = ""
    End Class
End Namespace