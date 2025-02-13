Namespace Reporte.Tratamiento
    Public Class Filtro
        Public Property Text As String = ""
        Public Property RegionID As Integer = -1
        Public Property RegionNombre As String = ""
        Public Property PenalID As Integer = -1
        Public Property PenalNombre As String = ""
        Public Property InternoID As Integer = -1
        Public Property InternoIngresoID As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property FechaInicio As Long = 0
        Private _fechaFin As Long = 0
        Public Property FechaFin As Long
            Get
                Return If(_fechaFin <> 0, System.DateTime.FromFileTime(_fechaFin).AddDays(1).ToFileTime, 0) 'a las 00H:00M:00S del dia siguiente
            End Get
            Set(value As Long)
                _fechaFin = value
            End Set
        End Property
        Public Property FechaFinOri As Long
            Get

                Return _fechaFin 'a las 00H:00M:00S del dia siguiente
            End Get
            Set(value As Long)
                _fechaFin = value
            End Set
        End Property
        Public ReadOnly Property FechaInicioStr() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaInicio)
            End Get
        End Property
        Public ReadOnly Property FechaFinStr() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaFinOri)
            End Get
        End Property
        ''/*certificado de reclusion*/
        'Public Property FechaIngreso As String = ""
        'Public Property DocumentoNumero As String = ""
        'Public Property FechaEmision As String = ""
        'Public Property FechaEmisionLong As Long = 0
        'Public Property Observacion As String = ""
        'Public Property PenalProcedencia As String = ""
        'Public Property Nota As String = ""
        'clasificacion
        'Public Property DocConsolidadoClasificacionId As Integer = -1

        'clasifiacion
        Public Property GrupoFicha As Short = -1
        Public Property IDInternoFichaFinal As Integer = -1

        ''historialAntecedente
        'Public Property MostrarDocAnulados As Boolean = False

        ''antecedentes judiciales
        'Public Property DocSolicitudAntecedenteId As Integer = -1
        'Public Property TipoAntecedenteId As Integer = -1

        'taller trabajo
        Public Property IdAux As Integer = -1

    End Class
End Namespace