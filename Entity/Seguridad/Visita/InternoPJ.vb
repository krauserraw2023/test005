Namespace Visita
    Public Class InternoPJ
        Inherits Auditoria.Transaccion

        Public Property Codigo As Integer = -1
        Public Property PrimerApellido As String = ""
        Public Property SegundoApellido As String = ""
        Public Property Apellidos As String = ""
        Public ReadOnly Property ApellidosReadonly As String
            Get
                Dim value As String = ""

                value = PrimerApellido & " " & SegundoApellido

                Return value

            End Get
        End Property

        Public Property PreNombres As String = ""
        Public Property Sexo As Short = -1
        Public ReadOnly Property SexoNombreReadonly As String
            Get
                Dim value As String = ""
                Select Case Me.Sexo
                    Case 1
                        value = "Masculino"
                    Case 2
                        value = "Femenino"
                End Select

                Return value

            End Get
        End Property
        Public Property FechaNacimiento As Long = 0
        Public ReadOnly Property Edad() As Integer
            Get
                Dim value As Integer = 0

                If Me.FechaNacimiento > 0 And (Me.FechaNacimiento < Legolas.LEntity.Config.FechaHoy) Then
                    value = Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimiento, Legolas.LEntity.Config.FechaHoy, True)
                End If

                Return value
            End Get
        End Property
        Public Property IDTipoDocumento As Short = -1
        Public Property TipoDocumento As String = ""
        Public Property NumeroDocumento As String = ""
        Public ReadOnly Property TipoDocyNumDocReadonly As String
            Get
                Dim value As String = ""

                value = Me.TipoDocumento & " " & NumeroDocumento

                Return value
            End Get
        End Property

        Public Property IDNacionalidad As Integer = -1
        Public Property Nacionalidad As String = ""
        Public Property IDPabellon As Integer = -1
        Public Property Pabellon As String = ""
        Public Property FechaIngreso As Long = 0
        Public Property FechaEgreso As Long = 0
        Public Property Estado As Short = -1
      
        Public ReadOnly Property EstadoNombreReadonly As String
            Get
                Dim value As String = ""
                Select Case Me.Estado
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value

            End Get
        End Property
        Public Property Observacion As String = ""

        Public Property IDRegion As Short = -1
        Public Property RegionNombre As String = ""
        Public Property IDPenal As Short = -1
        Public Property PenalNombre As String = ""

    End Class

#Region "VisitanteCol"
    Public Class InternoPJCol
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
        Public Function Add(ByVal obj As InternoPJ) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property InternoPJ(ByVal Index As Integer) As InternoPJ
            Get
                Return CType(MyBase.List(Index), InternoPJ)
            End Get
        End Property
        Public Function CloneCol() As InternoPJ
            Return MyBase.MemberwiseClone
        End Function
        Public Sub Remove(ByVal index As Integer)
            If index <= Count - 1 OrElse index >= 0 Then
                Me.List.RemoveAt(index)
                'Me.List.Remove(index)
            End If
        End Sub

    End Class
#End Region
End Namespace