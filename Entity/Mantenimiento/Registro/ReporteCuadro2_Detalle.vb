Namespace Mantenimiento.General
    Public Class ReporteCuadro2_Detalle
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Public Property Codigo As Integer = -1
        Public Property IDCuadroDelito As Integer = -1
        Public Property GenericoID As Integer = -1
        Public Property Generico As String = ""
        Public Property IDDelitoEspecifico As Integer = -1
        Public Property NombreEspecifico As String = ""
        Public Property Capitulo As String = ""
        Public Property Articulo As String = ""
        Public Property Seccion As String = ""
        Public Property EstadoNombre As String = ""
        Public Property CuadroVersion As Short = -1
#End Region
    End Class
#Region "ReporteCuadro2_DetalleCol"
    Public Class ReporteCuadro2_DetalleCol
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
        Public Function Add(ByVal obj As ReporteCuadro2_Detalle) As Integer

            Return MyBase.List.Add(obj)

        End Function
        Public Function AddVal(ByVal obj As ReporteCuadro2_Detalle) As Integer

            Dim value As Integer = -1
            Dim blnInsertar As Boolean = True

            For Each objFila As ReporteCuadro2_Detalle In Me.List
                If obj.IDDelitoEspecifico = objFila.IDDelitoEspecifico Then
                    blnInsertar = False
                    Exit For
                End If
            Next

            If blnInsertar = True Then
                value = MyBase.List.Add(obj)
            End If

            Return value
        End Function

        Public ReadOnly Property Reportecuadro2_Detalle(ByVal Index As Integer) As ReporteCuadro2_Detalle
            Get
                Return CType(MyBase.List(Index), ReporteCuadro2_Detalle)
            End Get
        End Property
        Public Function CloneCol() As ReporteCuadro2_Detalle
            Return MyBase.MemberwiseClone
        End Function

        'Public Sub RemoveID(ByVal Codigo As Integer)

        '    If Codigo < 1 Then
        '        Exit Sub
        '    End If

        '    Dim obj As New ReporteCuadro2_Detalle

        '    For Each objRun As ReporteCuadro2_Detalle In Me.List
        '        If Codigo = objRun.Codigo Then
        '            obj = objRun
        '            Exit For
        '        End If
        '    Next

        '    Me.List.RemoveAt(obj)

        'End Sub
        Public Sub RemoveID_(ByVal Codigo As Integer)

            Me.List.RemoveAt(Codigo)

        End Sub
    End Class
#End Region
End Namespace