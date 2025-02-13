Namespace Registro.Carceleta.Clasificacion
    Public Class MaestroFicha_BE

        Public Property TipoFichaId() As Type.Enumeracion.Clasificacion.enmTipoFicha = Type.Enumeracion.Clasificacion.enmTipoFicha.Ninguno
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property AmbitoClasificacionId() As Integer = -1
        Public Property Nombre() As String = ""
        Public Property GrupoSecuencialStr As String = "" 'correlativo del grupo concatenados y separados por coma.
        Public Property GrupoSecuencial As Integer = -1 'correlativo del grupo
        Public Property Secuencia() As Integer = -1
        Public Property Descripcion() As String = ""
        Public Property DocAprobacion() As String = ""
        Public Property DocAprobacionFecha() As Long = 0
        Public ReadOnly Property DocAprobacionFechaDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.DocAprobacionFecha)
            End Get
        End Property
        Public Property EstadoId() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim v As String = ""
                Select Case EstadoId
                    Case 0
                        v = "INACTIVO"
                    Case 1
                        v = "ACTIVO"
                    Case Else
                        v = ""
                End Select
                Return v
            End Get
        End Property
        Private _AmbitoClasificacionNombre As String = ""
        Public Property AmbitoClasificacionNombre()
            Get
                Return _AmbitoClasificacionNombre.ToUpper
            End Get
            Set(value)
                Me._AmbitoClasificacionNombre = value
            End Set
        End Property
        Public Property TipoFichaNombre() As String = ""
        Public ReadOnly Property TipoFicha() As Integer
            Get
                Return TipoFichaId
            End Get
        End Property
        Public Property NumeroClasificacion As Short = 0
#End Region
    End Class
#Region "FichaCol"
    Public Class MaestroFichaCol_BE
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
        Public Function Add(ByVal obj As MaestroFicha_BE) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Ficha(ByVal Index As Integer) As MaestroFicha_BE
            Get
                Return CType(MyBase.List(Index), MaestroFicha_BE)
            End Get
        End Property
    End Class
#End Region
End Namespace
