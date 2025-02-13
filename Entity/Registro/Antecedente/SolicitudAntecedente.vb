Namespace Registro.Antecedente
    Public Class SolicitudAntecedente
        Public Property Codigo As Integer = -1
        Public Property Anio As Integer = 0
        Public Property NumeroCorrelativo As Integer = 0
        Public Property CodigoPenal As Integer = 0
        Public Property TipoAntecedenteId As Integer = -1 '1= NEGATIVO, 2:No registra proceso pendiente, 3=Registra proceso pendiente,4=TUPA
        Public Property GlosaDocId As Integer = -1
        Public Property DocumentoNumero As String = ""
        Public Property DocumentoFecha As Long = 0
        Public Property FechaSolicitud As Long = 0
        Public Property EstadoSolicitudId As Integer = -1  '0 : Pendiente, 1 : Terminado, 2 : Impreso, 3 : Anulado
        Public Property MotivoSolicitudId As Integer = -1
        Public Property TipoAutoridadJudicial As Integer = -1
        Public Property SolDistritoJudicialId As Integer = -1
        Public Property SolSalaJudicialId As Integer = -1
        Public Property SolNombreJuez As String = ""
        Public Property SolNombreSecretario As String = ""
        Public Property SolNombreEntidad As String = ""
        Public Property Observacion As String = ""
        Public Property SolicitantePenalId As Integer = -1
        Public Property SolicitanteRegionId As Integer = -1
        Public Property PenalId As Integer = -1
        Public Property RegionId As Integer = -1
        Public Property RegionNombre As String = ""
        Public Property PenalNom As String = ""
        Public Property ReporteCabeceraId As Integer = -1  'id del registro de reporte cabecera
        Public Property AmbitoJurisdiccionAut As Integer = -1 'Ambito jurisdicción autoridad -1=Ninguna,1=Lima, 2=Callao, 3=Lima y callao
        Public Property InternoApePaterno As String = ""
        Public Property InternoApeMaterno As String = ""
        Public Property InternoNombres As String = ""
        Public Property InternoCodigo As String = ""
        Public Property InternoNombresAsociados As String = ""
        Public Property InternoId As Integer = -1
        Public Property InternoTipoDocIdentidad As Integer = -1
        Public Property InternoNumDocIdentidad As String = ""
        Public Property NumImpresiones As Integer = 0
        Public Property MotivoAnulacion As String = ""
        Public Property FechaAnulacion As Long = 0
        Public Property DataHistoricaMigracion As Boolean = 0 'indica si la data proviene de migracion del SRP

        'propiedades auxiliares
        Public ReadOnly Property InternoNombreCompleto As String
            Get
                Dim v As String = ""
                v = Me.InternoApePaterno & " " & InternoApeMaterno & ", " & Me.InternoNombres
                Return v
            End Get
        End Property
        Public Property MotivoSolicitudStr As String = ""
        Public ReadOnly Property EstadoSolicitud As Type.Enumeracion.AntecedenteJudicial.enmEstadoSolicitud
            Get
                Return EstadoSolicitudId
            End Get
        End Property
        Public ReadOnly Property EstadoSolicitudStr As String
            Get
                Return EstadoSolicitud.ToString
            End Get
        End Property
        Public ReadOnly Property NumSolicitudStr As String
            Get
                Return Anio.ToString.Substring(2, 2) & TipoAntecedenteId & NumeroCorrelativo.ToString("00000")
            End Get
        End Property
        Public ReadOnly Property getNumeroSolicitudPenal As String
            Get
                Return Anio & "-" & TipoAntecedenteId.ToString("00") & "-" & NumeroCorrelativo.ToString("00000")
            End Get
        End Property
        Public Property PenalMultiple As String = ""
        Public Property FechaDesde As Long = 0
        Public Property FechaHasta As Long = 0
        Public Property UsuarioCrea As String = ""
        Public ReadOnly Property AmbitoNombre() As String
            Get
                Dim s As String = ""
                Select Case AmbitoJurisdiccionAut
                    Case 1
                        s = "LIMA"
                    Case 2
                        s = "CALLAO"
                    Case 3
                        s = "LIMA Y CALLAO"
                End Select
                Return s
            End Get
        End Property


        Public ReadOnly Property TipoAntecedenteStr As String
            Get
                Dim v As String = ""
                Select Case TipoAntecedenteId
                    Case 1
                        v = "NEGATIVO"
                    Case 2
                        v = "NO REG. P.P.M.D."
                    Case 3
                        v = "POSITIVO"
                    Case 4
                        v = "TUPA"
                End Select
                Return v & " " & AmbitoNombre
            End Get
        End Property
        Public ReadOnly Property FechaSolicitudStr As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaSolicitud)
            End Get
        End Property
        Public Property NombreAutoridadSolicitante As String = ""
        Public Property IncluyeAnulaciones As Short = 0
        Public ReadOnly Property AJConAnulaciones As String
            Get
                Dim v As String = ""
                If IncluyeAnulaciones = 1 Then
                    v = "X"
                End If

                Return v
            End Get
        End Property
    End Class
#Region "BandaCol"
    Public Class SolicitudAntecedenteCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As SolicitudAntecedente) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property SolicitudAntecedente(ByVal Index As Integer) As SolicitudAntecedente
            Get
                Return CType(MyBase.List(Index), SolicitudAntecedente)
            End Get
        End Property
    End Class
#End Region
End Namespace