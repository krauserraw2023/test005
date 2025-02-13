Namespace Mantenimiento.Registro
    Public Class PadinCuadro13
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo As Integer = -1
        Public Property TipoEgresoNombre As String = ""
        Public Property TipoEgresoTabla As String = ""
        Public Property Nombre As String = ""
        Public Property NombreDetalle As String = ""
        Public Property Cuadro As Short = -1
        Public Property Orden As Short = -1
#End Region
#Region "Propeidades_Detalle"
        Public Property MovimientoMotivoCodigo01String As String = ""
        Public Property MovimientoMotivoCodigo02String As String = ""
#End Region
    End Class
#Region "PadinCuadro13Col"
    Public Class PadinCuadro13Col
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
        Public Function Add(ByVal obj As PadinCuadro13) As Integer

            Return MyBase.List.Add(obj)

        End Function
        Public Function AddVal(ByVal obj As PadinCuadro13) As Integer

            Dim blnValue As Boolean = True

            For Each objRun As PadinCuadro13 In Me.List
                If obj.Codigo = objRun.Codigo Then
                    blnValue = False
                    Exit For
                End If
            Next

            If blnValue = True Then
                Return MyBase.List.Add(obj)
            End If

        End Function

        Public ReadOnly Property PadinCuadro13(ByVal Index As Integer) As PadinCuadro13
            Get
                Return CType(MyBase.List(Index), PadinCuadro13)
            End Get
        End Property
        Public Function CloneCol() As PadinCuadro13
            Return MyBase.MemberwiseClone
        End Function

        Public Sub RemoveID(ByVal Codigo As Integer)

            If Codigo < 1 Then
                Exit Sub
            End If

            Dim obj As PadinCuadro13 = Nothing

            For Each objRun As PadinCuadro13 In Me.List
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