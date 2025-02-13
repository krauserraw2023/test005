Namespace Clasificacion.InternoClasificacion
    Public Class Delito
#Region "Propiedades"
        Private strDelitoGenericoNombre As String = ""
        Private strDelitoEspecificoNombre As String = ""
        Public Property Codigo() As Integer = -1
        Public Property ExpedienteID() As Integer = -1
        Public Property FichaFinalId() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property DelitoGenerico() As Integer = -1
        Public Property DelitoGenericoNombre() As String
            Get
                Return UCase(strDelitoGenericoNombre) 'Legolas.Components.Cadena.ProperCase(strDelitoGenericoNombre)
            End Get
            Set(ByVal value As String)
                strDelitoGenericoNombre = value
            End Set
        End Property
        Public Property DelitoEspecifico() As Integer = -1
        Public Property DelitoEspecificoNombre() As String
            Get
                Return UCase(strDelitoEspecificoNombre) ' Legolas.Components.Cadena.ProperCase(strDelitoEspecificoNombre)
            End Get
            Set(ByVal value As String)
                strDelitoEspecificoNombre = value
            End Set
        End Property
        Public Property DelitoEspecificoEstado() As Integer = 1
        Public Property Observacion() As String = ""
        Public Property DelitoMayorPena() As Boolean = False
        Public Property DelitoSentenciaMayorPena() As Boolean = False
        Public Property Estado() As Integer = Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.No_Determinado
        Public Property VisibleAuxiliar As Boolean = False

        Public Property AgraviadoNombre() As String = ""
        Public Property AgraviadoObservacion() As String = ""
        Public Property TipoSentenciaId As Integer = -1
        Public Property CreaDocJudicialId() As Integer = -1 'documento judicial (resolucion) con la cual se crea el exp.-> 26-06-2014 x hnrb

        Public Property DelitoTitulo As String = ""
        Public Property DelitoTipoID As Integer = -1

        Public Property DelitoTipoNombre() As String = ""

        Public Property DelitoArticulo As String = ""
        Public Property DelitoCapituloNro As String = ""
        Public Property DelitoCapituloNombre As String = ""
        Public Property DelitoSeccionNumero As String = ""
        Public Property DelitoSeccionNombre As String = ""
        Public Property DelitoItem As Integer = -1
        Public Property ExpedienteItem As Integer = -1
        Public Property DelitoAuxiliar As Boolean = True
        Public Property DocJudID As Integer = -1
        Public Property Auxiliar As Boolean = False
#End Region
#Region "Propiedades_Filtro"
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
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
        Public Function Add(ByVal obj As Delito) As Integer
            Return MyBase.List.Add(obj)
        End Function
        'Public Function Add(ByVal obj As Delito) As Integer
        '    Return MyBase.List.Add(obj)
        'End Function
        Public Function Delete(Index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(Index)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Function Remove(index As Integer) As Boolean
            Try
                MyBase.List.RemoveAt(index)
            Catch ex As Exception
                Return False
            End Try
            Return True
        End Function
        Public ReadOnly Property Item(ByVal Index As Integer) As Delito
            Get
                Try
                    Return CType(MyBase.List(Index), Delito)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property internoDelito(ByVal Index As Integer) As Delito
            Get
                Try
                    Return CType(MyBase.List(Index), Delito)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property Delito(ByVal Index As Integer) As Delito
            Get
                Try
                    Return CType(MyBase.List(Index), Delito)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
    End Class
#End Region
End Namespace
