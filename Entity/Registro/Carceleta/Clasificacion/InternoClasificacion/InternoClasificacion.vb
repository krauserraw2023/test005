Imports Type.Enumeracion.Clasificacion

Namespace Clasificacion.InternoClasificacion
    Public Class InternoFicha
        Public Property Codigo() As Integer = -1
        Public Property TipoFichaId() As Integer = -1
        Public Property InternoId() As Integer = -1
        Public Property InternoCodigo() As String = ""
        Public Property InternoNombres() As String = ""
        Public Property InternoApePat() As String = ""
        Public Property InternoApeMat() As String = ""
        Public ReadOnly Property InternoNombresCompletos() As String
            Get
                Return InternoApePat & " " & InternoApeMat & ", " & InternoNombres
            End Get
        End Property
        Public Property InternoIngresoId() As Integer = -1
        Public Property IngresoInpeId() As Integer = -1
        Public Property InternoIngresoNro() As Integer = 0
        Public Property FichaId() As Integer = -1
        Public Property CategoriaFichaId() As Integer = -1
        Public Property CategoriaFichaNombre() As String = ""
        Public Property FichaFinalId() As Integer = -1 'referencia recursivo (lo mismo que FKCodigo))
        Public Property RegionDestinoId() As Integer = -1
        Public Property PenalDestinoId() As Integer = -1
        Public Property RegimenPenalId() As Integer = -1
        Public Property EtapaId() As Integer = -1
        Public Property NumeroClasificacion() As Integer = -1
        Public Property FechaClasificacion() As Long = 0
        Public ReadOnly Property FechaClasificacionDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaClasificacion)
            End Get
        End Property
        Public Property Observacion() As String = ""
        Public Property Puntaje() As Integer = 0
        Public Property Estado() As enmEstadoRegistroFicha = enmEstadoRegistroFicha.Ninguno
        Public ReadOnly Property EstadoId() As Integer 'artificio para no hacer referencia a la dll del proyecto type en la capa de datos se retorna un valor entero
            Get
                Return Estado
            End Get
        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim str As String = ""
                Select Case Me.Estado
                    Case enmEstadoRegistroFicha.Bloqueado
                        str = "BLOQUEADO"
                    Case enmEstadoRegistroFicha.Finalizado
                        str = "FINALIZADO"
                    Case enmEstadoRegistroFicha.Pendiente
                        str = "PENDIENTE"
                End Select
                Return str
            End Get
        End Property
        Public Property PenalId() As Integer = -1
        Public Property RegionId() As Integer = -1
        Public Property MotivoModifPenalDet As String = ""

        'propiedades auxiliares

        Public ReadOnly Property TipoFicha() As enmTipoFicha
            Get
                Dim tf As Type.Enumeracion.Clasificacion.enmTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Ninguno
                Select Case TipoFichaId
                    Case 1
                        tf = enmTipoFicha.Legal
                    Case 2
                        tf = enmTipoFicha.Social
                    Case 3
                        tf = enmTipoFicha.Psicologica
                    Case 4
                        tf = enmTipoFicha.Final
                End Select
                Return tf
            End Get
        End Property
        Public Property FichaNombres() As String = ""
        Public Property InternoClasificacionId As Integer = -1
        Public Property blnValor As Boolean = False 'declarada para ????? jescobar
        Public Property RegionDestinoNombre() As String = ""
        Public Property PenalDestinoNombre() As String = ""
        Public Property GrupoFichaId As Integer = -1 'correlativo del grupo de ficha
        Public Property InternoSituacionJuridicaId As Integer = -1
        Public Property NumOrdenTipFic As Integer = 0
        Public Property Observacion_02_rtf As String = "" 'texto en rtf
        Public Property VariableNombre As String = ""
        Public Property IndicadorNombre As String = ""
        Public Property PuntajeProcesado As Integer = 0
    End Class
    Public Class InternoFichaCol
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
        Public Function Add(ByVal obj As InternoFicha) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoClasificacion(ByVal Index As Integer) As InternoFicha
            Get
                Return CType(MyBase.List(Index), InternoFicha)
            End Get
        End Property
    End Class
End Namespace