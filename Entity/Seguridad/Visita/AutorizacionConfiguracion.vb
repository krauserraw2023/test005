Namespace Visita
    Public Class AutorizacionConfiguracion
        Inherits Entity.Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property ConfiguracionDiaMaximo() As Integer = -1
        Public Property ConfiguracionEnero As Boolean = False
        Public Property ConfiguracionFebrero As Boolean = False
        Public Property ConfiguracionMarzo As Boolean = False
        Public Property ConfiguracionAbril As Boolean = False
        Public Property ConfiguracionMayo As Boolean = False
        Public Property ConfiguracionJunio As Boolean = False
        Public Property ConfiguracionJulio As Boolean = False
        Public Property ConfiguracionAgosto As Boolean = False
        Public Property ConfiguracionSetiembre As Boolean = False
        Public Property ConfiguracionOctubre As Boolean = False
        Public Property ConfiguracionNoviembre As Boolean = False
        Public Property ConfiguracionDiciembre As Boolean = False
        Public Property EstadoID() As Integer = -1
        Public ReadOnly Property Estado() As String
            Get
                Dim value As String = ""
                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select
                Return value
            End Get
        End Property
        Public Property ConfiguracionObs As String
#End Region

#Region "Propiedades_Filtro"
        Public Property RegionID() As Short = -1
        Public Property PenalID() As Short = -1
#End Region

    End Class
End Namespace