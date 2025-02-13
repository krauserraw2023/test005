Namespace Mantenimiento
    Public Class ReporteCuadro2
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property GenericoID() As Integer = -1
        Public Property Generico() As String = ""
        Public Property Especifico() As String = ""
        Public Property NombreEspecifico() As String = ""
        Public Property Cuadro() As Short = -1
        Public Property Orden() As Integer = -1
#End Region
    End Class
#Region "ReporteCuadro2Col"
    Public Class ReporteCuadro2Col
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
        Public Function Add(ByVal obj As ReporteCuadro2) As Integer

            Return MyBase.List.Add(obj)

        End Function
        Public Function AddVal(ByVal obj As ReporteCuadro2) As Integer

            Dim blnValue As Boolean = True

            For Each objRun As ReporteCuadro2 In Me.List
                If obj.Codigo = objRun.Codigo Then
                    blnValue = False
                    Exit For
                End If
            Next

            If blnValue = True Then
                Return MyBase.List.Add(obj)
            End If

        End Function

        Public ReadOnly Property Reportecuadro2(ByVal Index As Integer) As ReporteCuadro2
            Get
                Return CType(MyBase.List(Index), ReporteCuadro2)
            End Get
        End Property
        Public Function CloneCol() As ReporteCuadro2
            Return MyBase.MemberwiseClone
        End Function

        Public Sub RemoveID(ByVal Codigo As Integer)

            If Codigo < 1 Then
                Exit Sub
            End If

            Dim obj As ReporteCuadro2 = Nothing

            For Each objRun As ReporteCuadro2 In Me.List
                If Codigo = objRun.Codigo Then
                    obj = objRun
                    Exit For
                End If
            Next

            Me.List.Remove(obj)

        End Sub
    End Class
#End Region
End Namespace