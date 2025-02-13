Namespace Mantenimiento.General

    Public Class Delito
        Public Property DelitoEspecificoID As Integer = -1
        Public Property DelitoEspecificoCodigo As String = ""
        Public Property DelitoEspecificoNombre As String = ""
        Public ReadOnly Property EstadoEspecificoNombre As String
            Get
                Dim value As String = ""

                Select Case Me.DelitoEspecificoEstado
                    Case 0
                        value = "Anulado"
                    Case 1
                        value = "Activo"
                    Case 2
                        value = "Derogado"
                    Case Else
                        value = "Por Regularizar"
                End Select

                Return value
            End Get
        End Property
        Public Property DelitoArticulo As String = ""
        Public Property DelitoEspObs As String = ""
        Public Property DelitoEspecificoEstado As Integer = -1
        Public Property DelitoEspMotivoBaja As String = ""

        Public Property DelitoTipoID As Integer = -1
        Public Property DelitoTipoNombre() As String = ""
        
        Public Property DelitoTitulo As String = ""
        Public Property DelitoGenericoID As Integer = -1
        Public Property DelitoGenericoCodigo As String = ""
        Public Property DelitoGenericoNombre As String = ""
        Public Property DelitoGenericoNumero As String = ""
        Public ReadOnly Property Titulo As String
            Get
                Dim value As String = Me.DelitoTitulo.Trim & " - " & Me.DelitoGenericoNombre

                Return value
            End Get
        End Property
        Public ReadOnly Property getRDelitoGenericoNombreNumero As String
            Get
                Dim value As String = ""

                value = Me.DelitoGenericoNumero.Trim & " - " & Me.DelitoGenericoNombre
                Return value
            End Get
        End Property

        Public Property IDDelitoCapitulo As Integer = -1
        Public Property DelitoCapituloNro As String = ""
        Public Property DelitoCapituloCodigo As String = ""
        Public Property DelitoCapituloNombre As String = ""
        Public ReadOnly Property Capitulo As String
            Get
                Dim value As String = Me.DelitoCapituloNro & " - " & Me.DelitoCapituloNombre

                Return value
            End Get
        End Property

        Public Property IDDelitoSeccion As Integer = -1
        Public Property DelitoSeccionCodigo As String = ""
        Public Property DelitoSeccionNumero As String = ""
        Public Property DelitoSeccionNombre As String = ""
        Public ReadOnly Property Seccion As String
            Get
                Dim value As String = Me.DelitoSeccionNumero & " - " & Me.DelitoSeccionNombre

                Return value
            End Get
        End Property

        Public Property IDDelitoEspecificoPadre As Integer = -1
        Public Property DelitoEspecificoPadreCodigo As String = ""
        Public Property DelitoCodigoSB As String = ""
#Region "Propiedades_GrupoDelito"
        Public Property DelitoCuadroGrupoId As Integer = -1
        Public Property DelitoGrupoGenericoNombre As String = ""
        Public Property DelitoGrupoEspecificoNombre As String = ""
        Public Property IDDelitoGrupoDelitoDet As Integer = -1
        Public Property DelitoGrupoEspecificoId As Integer = -1

        Public ReadOnly Property GrupoDelitoGenericoEspecifico As String
            Get
                Dim value As String = ""

                If DelitoGrupoGenericoNombre.Trim.Length > 3 Then

                    If DelitoGrupoEspecificoNombre.Trim.Length > 3 Then

                        If DelitoGrupoEspecificoNombre.ToLower = "Otrosv".ToLower Then
                            value = DelitoGrupoGenericoNombre
                        Else
                            value = DelitoGrupoGenericoNombre & "/" & DelitoGrupoEspecificoNombre
                        End If
                    Else
                        value = DelitoGrupoGenericoNombre
                    End If

                End If

                Return value
            End Get
        End Property

#End Region
    End Class

#Region "DelitoCol"
    Public Class DelitoCol
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
        Public Function Add(ByVal value As Delito) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Delito) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Delito) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Delito)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Delito
            Get
                Return DirectCast(List(index), Delito)
            End Get
            Set(ByVal value As Delito)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Delito)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Delito
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace