Namespace Registro
    Public Class Familiar
        Inherits Auditoria.Transaccion
        Private strApellidoPaterno As String = ""
        Private strApellidoMaterno As String = ""
        Private strNombres As String = ""
#Region "Propiedades"
        Private strFamiliarTipoNombre As String = ""
        Private strSexoNombre As String = ""
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        'Public Property SedeInternoId As Integer = -1
        Public Property FamiliarTipoID() As Integer = -1
        Public Property FamiliarTipoNombre() As String
            Get
                Return strFamiliarTipoNombre
            End Get
            Set(ByVal value As String)
                strFamiliarTipoNombre = value
            End Set
        End Property
        Public Property ApellidoPaterno() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strApellidoPaterno)
            End Get
            Set(ByVal value As String)
                strApellidoPaterno = value
            End Set
        End Property
        Public Property ApellidoMaterno() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strApellidoMaterno)
            End Get
            Set(ByVal value As String)
                strApellidoMaterno = value
            End Set
        End Property
        Public Property Nombres() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNombres)
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public Property Sexo() As Integer = -1
        Public Property SexoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSexoNombre)
            End Get
            Set(ByVal value As String)
                strSexoNombre = value
            End Set
        End Property
        Public Property FechaNacimiento() As Long = 0
        Public ReadOnly Property FechaNacimientoDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
            End Get
        End Property
        Public Property Vive() As Boolean = False
        Public Property HijoReclucido() As Boolean = False
        Public Property IngresoID As Integer = -1
        Public Property IngresoInpeID As Integer = -1
        Public Property RegionID As Integer = -1
        Public Property PenalID As Integer = -1
        Public Property SedeRowId As Integer = -1
        '*********** AUXILIARES ***********
        Public Property IngresoNroInpe As String = ""
        Public Property IngresoNro As String = ""
#End Region
    End Class
#Region "FamiliarCol"
    Public Class FamiliarCol
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
        Public Function Add(ByVal obj As Familiar) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Familiar(ByVal Index As Integer) As Familiar
            Get
                Return CType(MyBase.List(Index), Familiar)
            End Get
        End Property
    End Class
#End Region
End Namespace
