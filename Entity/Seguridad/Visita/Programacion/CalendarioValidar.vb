Namespace Visita.Programacion


    Public Class CalendarioValidar
#Region "Propeidades"
        Public Property RegionID As Integer = -1
        Public Property PenalID As Integer = -1
        Public Property RegimenVisitaID As Integer = -1
        Public ReadOnly Property RegimenVisitaNombreReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.RegimenVisitaID
                    Case 1 '
                        value = "Regimen Ordinario"
                    Case 2
                        value = "Regimen Cerrado Especial"
                    Case 4
                        value = "Administrativa"                    
                End Select
                Return value
            End Get
        End Property
        Public Property TipoVisitaID As Integer = -1
        Public ReadOnly Property VisitaTipoNombreReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.TipoVisitaID
                    Case 2 '
                        value = "Ordinario"
                    Case 5
                        value = "Intimas"
                    Case 10
                        value = "Extraordinaria"
                    Case 11
                        value = "Menor de edad"
                    Case 12
                        value = "Abogados(a)"
                    Case 13
                        value = "Etapas"
                End Select

                Return value

            End Get
        End Property
        Public Property Fecha As Long = 0
        Public Property Hora As Integer = 0
        Public Property Minuto As Integer = 0
        Public Property InternoID As Integer = -1
        Public Property EtapaID As Integer = -1
        Public Property VisitanteID As Integer = -1
        Public Property VisitanteFechaNacimiento As Long = 0
        Public Property ParentescoID As Integer = -1
        Public Property TipoParentesco As Integer = -1
        Public Property GradoParentesco As Integer = -1
        Public Property SexoID As Integer = -1
        Public Property ValidacionMenorAntes As Boolean = False
#End Region
    End Class
End Namespace