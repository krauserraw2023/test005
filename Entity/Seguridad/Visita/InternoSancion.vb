Namespace Visita
    Public Class InternoSancion
        Inherits Globall.Persona
#Region "Propiedades"
        Private intCODIGO As Integer = -1        
        Private lngInicio As Long = 0
        Private lngFIn As Long = 0
        Private lngFecha As Long = 0
        Private intTipoId As Integer = -1
        Private intEstadoId As Integer = -1
        Private strObservacion As String = ""
        Private strDocumento As String = ""
        Private strTipoSancionNombre As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCODIGO
            End Get
            Set(ByVal value As Integer)
                intCODIGO = value
            End Set
        End Property
        Public Property InternoID() As Integer = -1
        Public Property InternoApellidosyNombres As String = ""
        Public Property Fecha() As Long
            Get
                Return lngFecha
            End Get
            Set(ByVal value As Long)
                lngFecha = value
            End Set
        End Property
        Public ReadOnly Property FechaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property
        Public Property FechaInicio() As Long
            Get
                Return lngInicio
            End Get
            Set(ByVal value As Long)
                lngInicio = value
            End Set
        End Property
        Public ReadOnly Property FechaIniDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaInicio)
            End Get
        End Property
        Public Property FechaFin() As Long
            Get
                Return lngFIn
            End Get
            Set(ByVal value As Long)
                lngFIn = value
            End Set
        End Property
        Public ReadOnly Property FechaFinDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaFin)
            End Get
        End Property
        Public Property FechaFinIndeterminado() As Boolean = False
        Public ReadOnly Property FechaFinString
            Get
                Dim value As String = ""

                If FechaFinIndeterminado = True Then
                    value = "Indeterminado"
                Else
                    value = FechaFinDate.ToString
                End If

                Return value
            End Get
        End Property
        Public Property TipoSancion() As Integer
            Get
                Return intTipoId
            End Get
            Set(ByVal value As Integer)
                intTipoId = value
            End Set
        End Property
        Public Property TipoSancionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoSancionNombre)
            End Get
            Set(ByVal value As String)
                strTipoSancionNombre = value
            End Set
        End Property
        Public Property EstadoID() As Integer
            Get
                Return intEstadoId
            End Get
            Set(ByVal value As Integer)
                intEstadoId = value
            End Set
        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Anulado"
                    Case 1
                        value = "Activo"
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property Estado() As Boolean
            Get
                Dim value As Boolean = False

                If Me.EstadoID > 0 Then
                    value = True
                End If

                Return value

            End Get            
        End Property
        Public Property Documento() As String
            Get
                Return strDocumento
            End Get
            Set(ByVal value As String)
                strDocumento = value
            End Set
        End Property
        Public Property Obs() As String
            Get
                Return strObservacion
            End Get
            Set(ByVal value As String)
                strObservacion = value
            End Set
        End Property
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
#End Region
    End Class
#Region "InternoSancionCol"
    Public Class InternoSancionCol
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
        Public Function Add(ByVal obj As InternoSancion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Internosancion(ByVal Index As Integer) As InternoSancion
            Get
                Return CType(MyBase.List(Index), InternoSancion)
            End Get
        End Property
        Public Function CloneCol() As InternoSancion
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace