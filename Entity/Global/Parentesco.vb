Namespace Globall
    Public Class Parentesco
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private strNombre As String = ""
        Private intOrden As Integer = -1        
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return strNombre
            End Get
            Set(ByVal value As String)
                strNombre = value
            End Set
        End Property
        Public Property Orden() As Integer
            Get
                Return intOrden
            End Get
            Set(ByVal value As Integer)
                intOrden = value
            End Set
        End Property
        Public Property Opcion1() As Integer = -1
        Public Property Opcion2() As Integer = -1
        Public Property Tipo As Integer = -1
        Public ReadOnly Property TipoNombre As String
            Get
                Dim value As String = ""
                Select Case Me.Tipo
                    Case 1
                        value = "Consanguidad"
                    Case 2
                        value = "Afinidad"
                    Case Else
                        value = "Ninguno"
                End Select
                Return value
            End Get
        End Property
        Public Property Grado As Integer = -1
        Public ReadOnly Property GradoNombre As String
            Get

                Dim value As String = ""

                Select Case Me.Grado
                    Case 0
                        value = "Ninguno"
                    Case Else
                        value = Me.Grado & " Grado"
                End Select

                Return value

            End Get
        End Property
        Public ReadOnly Property GradoyTipoParentesco As String
            Get
                Dim value As String = ""
                Dim strTipo As String = ""
                Dim strGrado As String = ""

                Select Case Tipo
                    Case 1
                        strTipo = "Consanguinidad"
                    Case 2
                        strTipo = "Afinidad"
                    Case Else
                        strTipo = ""
                End Select

                Select Case Me.Grado
                    Case 0
                        strGrado = "Ninguno"
                    Case Else
                        strGrado = Me.Grado & " Grado "
                End Select

                value = strGrado & strTipo
                Return value

            End Get
        End Property

#End Region
    End Class
#Region "ParentescoCol"
    Public Class ParentescoCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, SortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As Parentesco) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Parentesco(ByVal Index As Integer) As Parentesco
            Get
                Return CType(MyBase.List(Index), Parentesco)
            End Get
        End Property
        Public Function CloneCol() As Parentesco
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace