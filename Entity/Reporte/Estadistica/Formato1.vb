Namespace Reporte.Estadistica
    Public Class Formato1
#Region "Penal"
        Private strPenalNombre As String = ""
        Private strDepartamento As String = ""
        Private strProvincia As String = ""
        Private strDistrito As String = ""
        Private strDomicilio As String = ""
        Private strTelefono As String = ""
        Private strObs As String = ""
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property Departamento() As String
            Get
                Return strDepartamento
            End Get
            Set(ByVal value As String)
                strDepartamento = value
            End Set
        End Property
        Public Property Provincia() As String
            Get
                Return strProvincia
            End Get
            Set(ByVal value As String)
                strProvincia = value
            End Set
        End Property
        Public Property Distrito() As String
            Get
                Return strDistrito
            End Get
            Set(ByVal value As String)
                strDistrito = value
            End Set
        End Property
        Public ReadOnly Property UbicacionGeografica() As String
            Get
                Dim strValue As String = ""
                strValue = "Departamento: " & Me.Departamento & " / Provincia : " & Me.Provincia & " / Distrito : " & Me.Distrito
                Return strValue.ToUpper
            End Get
        End Property
        Public Property Domicilio() As String
            Get
                Return strDomicilio
            End Get
            Set(ByVal value As String)
                strDomicilio = value
            End Set
        End Property
        Public Property Telefono() As String
            Get
                Return strTelefono
            End Get
            Set(ByVal value As String)
                strTelefono = value
            End Set
        End Property
        Public Property Obs() As String
            Get
                Return strObs
            End Get
            Set(ByVal value As String)
                strObs = value
            End Set
        End Property
#End Region
#Region "Cuadros"
        Private objCuadro001 As Entity.Reporte.Estadistica.F1.Cuadro001Col = Nothing
        Private objCuadro002A As Entity.Reporte.Estadistica.F1.Cuadro002ACol = Nothing
        Private objCuadro002B As Entity.Reporte.Estadistica.F1.Cuadro002BCol = Nothing
        Private objCuadro003 As Entity.Reporte.Estadistica.F1.Cuadro003Col = Nothing
        Private objCuadro004 As Entity.Reporte.Estadistica.F1.Cuadro004Col = Nothing
        Private objCuadro005 As Entity.Reporte.Estadistica.F1.Cuadro005Col = Nothing
        Private objCuadro006 As Entity.Reporte.Estadistica.F1.Cuadro006Col = Nothing
        Private objCuadro007 As Entity.Reporte.Estadistica.F1.Cuadro007Col = Nothing
        Private objCuadro008 As Entity.Reporte.Estadistica.F1.Cuadro008Col = Nothing
        Private objCuadro009 As Entity.Reporte.Estadistica.F1.Cuadro009Col = Nothing
        Private objCuadro010 As Entity.Reporte.Estadistica.F1.Cuadro010Col = Nothing
        Private objCuadro011 As Entity.Reporte.Estadistica.F1.Cuadro011Col = Nothing
        Private objCuadro012 As Entity.Reporte.Estadistica.F1.Cuadro012Col = Nothing
        Private objCuadro013 As Entity.Reporte.Estadistica.F1.Cuadro013Col = Nothing
        Public Property Cuadro001() As Entity.Reporte.Estadistica.F1.Cuadro001Col
            Get
                Return objCuadro001
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro001Col)
                objCuadro001 = value
            End Set
        End Property
        Public Property Cuadro002A() As Entity.Reporte.Estadistica.F1.Cuadro002ACol
            Get
                Return objCuadro002A
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro002ACol)
                objCuadro002A = value
            End Set
        End Property
        Public Property Cuadro002B() As Entity.Reporte.Estadistica.F1.Cuadro002BCol
            Get
                Return objCuadro002B
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro002BCol)
                objCuadro002B = value
            End Set
        End Property
        Public Property Cuadro003() As Entity.Reporte.Estadistica.F1.Cuadro003Col
            Get
                Return objCuadro003
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro003Col)
                objCuadro003 = value
            End Set
        End Property
        Public Property Cuadro004() As Entity.Reporte.Estadistica.F1.Cuadro004Col
            Get
                Return objCuadro004
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro004Col)
                objCuadro004 = value
            End Set
        End Property
        Public Property Cuadro005() As Entity.Reporte.Estadistica.F1.Cuadro005Col
            Get
                Return objCuadro005
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro005Col)
                objCuadro005 = value
            End Set
        End Property
        Public Property Cuadro006() As Entity.Reporte.Estadistica.F1.Cuadro006Col
            Get
                Return objCuadro006
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro006Col)
                objCuadro006 = value
            End Set
        End Property
        Public Property Cuadro007() As Entity.Reporte.Estadistica.F1.Cuadro007Col
            Get
                Return objCuadro007
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro007Col)
                objCuadro007 = value
            End Set
        End Property
        Public Property Cuadro008() As Entity.Reporte.Estadistica.F1.Cuadro008Col
            Get
                Return objCuadro008
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro008Col)
                objCuadro008 = value
            End Set
        End Property
        Public Property Cuadro009() As Entity.Reporte.Estadistica.F1.Cuadro009Col
            Get
                Return objCuadro009
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro009Col)
                objCuadro009 = value
            End Set
        End Property
        Public Property Cuadro010() As Entity.Reporte.Estadistica.F1.Cuadro010Col
            Get
                Return objCuadro010
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro010Col)
                objCuadro010 = value
            End Set
        End Property
        Public Property Cuadro011() As Entity.Reporte.Estadistica.F1.Cuadro011Col
            Get
                Return objCuadro011
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro011Col)
                objCuadro011 = value
            End Set
        End Property
        Public Property Cuadro012() As Entity.Reporte.Estadistica.F1.Cuadro012Col
            Get
                Return objCuadro012
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro012Col)
                objCuadro012 = value
            End Set
        End Property
        Public Property Cuadro013() As Entity.Reporte.Estadistica.F1.Cuadro013Col
            Get
                Return objCuadro013
            End Get
            Set(ByVal value As Entity.Reporte.Estadistica.F1.Cuadro013Col)
                objCuadro013 = value
            End Set
        End Property
#End Region

    End Class
#Region "FormatoCol"
    Public Class Formato1Col
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
        Public Function Add(ByVal obj As Formato1) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Formato1(ByVal Index As Integer) As Formato1
            Get
                Return CType(MyBase.List(Index), Formato1)
            End Get
        End Property
    End Class
#End Region
End Namespace
