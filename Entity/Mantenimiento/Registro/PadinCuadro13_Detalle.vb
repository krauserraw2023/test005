Namespace Mantenimiento.Registro
    Public Class PadinCuadro13_Detalle
        Inherits Auditoria.Transaccion

#Region "Propiedades"
        Public Property Codigo As Integer = -1
        Public Property IDCuadro13 As Integer = -1
        Public Property IDMovimientoMotivo As Integer = -1
        Public Property MovimientoMotivoNombre As String = ""
        Public Property TipoMovimientoNombre As String = ""
#End Region
    End Class
#Region "PadinCuadro13_DetalleCol"
    Public Class PadinCuadro13_DetalleCol
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
        Public Function Add(ByVal obj As PadinCuadro13_Detalle) As Integer

            Return MyBase.List.Add(obj)

        End Function
        Public Function AddVal(ByVal obj As PadinCuadro13_Detalle) As Integer

            Dim value As Integer = -1
            Dim blnInsertar As Boolean = True

            For Each objRun As PadinCuadro13_Detalle In Me.List
                If obj.IDMovimientoMotivo = objRun.IDMovimientoMotivo Then
                    blnInsertar = False
                    Exit For
                End If
            Next

            If blnInsertar = True Then
                value = MyBase.List.Add(obj)
            End If

            Return value
        End Function

        Public ReadOnly Property PadinCuadro13_Detalle(ByVal Index As Integer) As PadinCuadro13_Detalle
            Get
                Return CType(MyBase.List(Index), PadinCuadro13_Detalle)
            End Get
        End Property
        Public Function CloneCol() As PadinCuadro13_Detalle
            Return MyBase.MemberwiseClone
        End Function

        Public Sub RemoveID(ByVal Codigo As Integer)

            If Codigo < 1 Then
                Exit Sub
            End If

            Dim obj As PadinCuadro13_Detalle = Nothing

            For Each objRun As PadinCuadro13_Detalle In Me.List
                If Codigo = objRun.Codigo Then
                    obj = objRun
                    Exit For
                End If
            Next

            Me.List.Remove(obj)

        End Sub
        Public Sub RemoveID_(ByVal Codigo As Integer)

            'If Codigo < 1 Then
            '    Exit Sub
            'End If

            'Dim obj As ReporteCuadro2_Detalle = Nothing

            'For Each objRun As ReporteCuadro2_Detalle In Me.List
            '    If Codigo = objRun.Codigo Then
            '        obj = objRun
            '        Exit For
            '    End If
            'Next

            Me.List.RemoveAt(Codigo)

        End Sub
    End Class
#End Region
End Namespace