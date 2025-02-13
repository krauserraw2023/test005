Namespace Reporte
    Public Class ReporteCabecera
        Public Property Codigo As Integer = -1
        Public Property CodigoReporteId As Integer = -1
        Public Property InternoId As Integer = -1
        Public Property InternoIngresoId As Integer = -1
        Public Property CodigoPenal As String = ""
        Public Property Anio As Integer = 0
        Public Property NumSerie As Integer = 0
        Public Property NumeroImpresion As Short = 0
        Public Property FechaEmision As Long = 0
        Public Property CodigoId As Integer = -1 'recursivo, referencia a codigo
        Public Property MotivoAnulacion As String = ""
        Public Property Estado As Integer = -1 '1:Activo,0:anulado
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1

        '------- auxiliares
        Public Property NombreReporte As String = ""
        Public Property TipoReporteId As Integer = -1
        Public ReadOnly Property FechaEmisionStr As String
            Get
                Return Date.FromFileTime(Me.FechaEmision).ToString("dd/MM/yyyy HH:mm:ss")
            End Get
        End Property
        Public ReadOnly Property NumDoc() As String
            Get
                Return Me.Anio.ToString.Substring(2, 2) & CodigoPenal & Format(Me.NumSerie, "00000")
            End Get
        End Property
        Public ReadOnly Property EstadoStr As String
            Get
                Dim str As String = ""
                Select Case Me.Estado
                    Case 0
                        str = "ANULADO"
                    Case 1
                        str = "ACTIVO"
                End Select
                Return str
            End Get
        End Property
        Public Property TotalImpresiones As Integer = 0
        Public ReadOnly Property TotalImpresionesStr() As String
            Get
                Return TotalImpresiones.ToString("00")
            End Get
        End Property
        Public Property LoginUsuario As String = ""
        Public Property NumOrden As Integer = 0
    End Class
    Public Class ReporteCabeceraCol
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
        Public Function Add(ByVal obj As ReporteCabecera) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property ReporteCabecera(ByVal Index As Integer) As ReporteCabecera
            Get
                Return CType(MyBase.List(Index), ReporteCabecera)
            End Get
        End Property
    End Class
End Namespace