Namespace Tratamiento.Asistencia.Clasificacion.Penal

    Public Class PabellonRegimenEtapa_BE

        Public Property Codigo As Integer = -1
        Public Property IDPabellon As Integer = -1
        Public Property PabellonNombre As String = ""
        Public Property IDRegimen As Short = -1
        Public ReadOnly Property RegimenNombre As String
            Get
                Dim value As String = ""
                Select Case Me.IDRegimen
                    Case 1
                        value = "ORDINARIO"
                    Case 2
                        value = "ESPECIAL"
                End Select
                Return value
            End Get
        End Property
        Public Property IDEtapa As Short = -1
        Public ReadOnly Property EtapaNombre As String
            Get
                Dim value As String = ""

                Select Case Me.IDEtapa
                    Case 1
                        value = "MINIMA SEGURIDAD"
                    Case 2
                        value = "MEDIANA SEGURIDAD"
                    Case 3
                        value = "MAXIMA SEGURIDAD"
                    Case 4
                        value = "A"
                    Case 5
                        value = "B"
                    Case 6
                        value = "C"
                End Select

                Return value
            End Get
        End Property
        Public Property IDRegion As Short = -1
        Public Property IDPenal As Short = -1

    End Class

End Namespace