Namespace Sistema.Seguridad
    Public Class UsuarioNotificacion
        Inherits Legolas.LEntity.Auditoria.Transaccion

        Public Property Codigo As Integer = -1
        Public Property CodUsuario As Integer = -1
        Public Property AccionId As Integer = -1
        Public Property Accion As String = ""
        Public Property FechaRegistro As Long = 0
        Public Property FechaInhabilitacion As Long = 0

        ReadOnly Property FechaRegistrostr() As String
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaRegistro, True)

            End Get
        End Property
        ReadOnly Property FechaInhabilitacionstr() As String
            Get
                Dim valorstr As String
                If Me.AccionId = 1 Then
                    valorstr = ""
                Else
                    valorstr = Legolas.Components.FechaHora.FechaDate(Me.FechaInhabilitacion, True)
                End If
                Return valorstr
            End Get
        End Property

        Public Property MotivoNombre As String = ""
        Public Property EstadoId As Integer = -1
        Public Property EstadoNombre As String = -1
        Public Property Correo As String = ""
        Public Property RegionId As Integer = -1
        Public Property PenalId As Integer = -1
        Public Property RegionNombre As String = ""
        Public Property PenalNombre As String = ""
        Public ReadOnly Property RegionPenalNombre() As String
            Get
                Dim strValor = RegionNombre
                If PenalNombre.Length > 0 Then
                    strValor = strValor & " - " & PenalNombre
                End If
                Return strValor
            End Get
        End Property
        Public Property UsuarioAuditoriaNombres As String = ""
    End Class
    Public Class UsuarioNotificacionCol
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
        Public Function Add(ByVal obj As UsuarioNotificacion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property UsuarioNotificacion(ByVal Index As Integer) As UsuarioNotificacion
            Get
                Return CType(MyBase.List(Index), UsuarioNotificacion)
            End Get
        End Property
        Public Function CloneCol() As UsuarioNotificacion
            Return MyBase.MemberwiseClone
        End Function
        Public Sub Remove(ByVal index As Integer)
            If index <= Count - 1 OrElse index >= 0 Then
                Me.List.RemoveAt(index)
                'Me.List.Remove(index)
            End If
        End Sub

    End Class
End Namespace
