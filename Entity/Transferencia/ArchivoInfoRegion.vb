Namespace Transferencia
    Public Class ArchivoInfoRegion
#Region "Propiedades"
        'Private lngCodigo As Long = 0
        Private intRegion As Integer = -1
        Private strRegionNombre As String = ""
        Private intLicencia As Integer = -1
        Private intCantidad As Integer = -1
        Private intUltimaFechDescarga As Long = 0
        Private intCantErrorProcesadoSede As Integer = 0
        Public Property CantErrorProcesadoSede() As Integer
            Get
                Return intCantErrorProcesadoSede
            End Get
            Set(value As Integer)
                intCantErrorProcesadoSede = value
            End Set
        End Property
        Public Property UltimaFechaDescarga() As Long
            Get
                Return intUltimaFechDescarga
            End Get
            Set(value As Long)
                intUltimaFechDescarga = value
            End Set
        End Property
        Public ReadOnly Property UltimaFechaDescargaString() As String
            Get
                If intUltimaFechDescarga = 0 Then
                    Return ""
                Else
                    Return Legolas.Components.FechaHora.FechaDate(Me.intUltimaFechDescarga, True)
                End If
            End Get
        End Property


        Public ReadOnly Property EstadoTransferencia() As String
            Get
                Dim str As String = ""
                Dim intDias As Integer = 0
                If Me.UltimaFechaDescarga = 0 Then Return str
                Dim fechUltTransfer As DateTime = DateTime.FromFileTime(Me.UltimaFechaDescarga)
                intDias = DateDiff(DateInterval.Day, fechUltTransfer, Now)

                If CantidadTransferencias > 3 And CantidadTransferencias <= 10 And intDias <> 0 Then
                    str = "AMARILLO"
                ElseIf (Me.CantidadTransferencias > 10 And Me.CantidadTransferencias <= 30 And intDias <> 0) Then
                    str = "NARANJA"
                ElseIf Me.CantidadTransferencias > 30 And intDias <> 0 Then
                    str = "ROJO"
                End If

                If str <> "" Then Return str

                If intDias > 3 And intDias <= 10 Then
                    str = "AMARILLO"
                ElseIf (intDias > 10 And intDias <= 30) Then
                    str = "NARANJA"
                ElseIf intDias > 30 Then
                    str = "ROJO"
                End If
                Return str
            End Get
        End Property



        'Public Property Codigo() As Long
        '    Get
        '        Return lngCodigo
        '    End Get
        '    Set(ByVal value As Long)
        '        lngCodigo = value
        '    End Set
        'End Property
        Public Property RegionID() As Integer
            Get
                Return intRegion
            End Get
            Set(ByVal value As Integer)
                intRegion = value
            End Set
        End Property
        Public Property RegionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strRegionNombre)
            End Get
            Set(ByVal value As String)
                strRegionNombre = value
            End Set
        End Property
        Public Property Licencia() As Integer
            Get
                Return intLicencia
            End Get
            Set(ByVal value As Integer)
                intLicencia = value
            End Set
        End Property
        Public Property CantidadTransferencias() As Integer
            Get
                If RegionID = 3 Then
                    Return 0
                End If
                Return intCantidad
            End Get
            Set(ByVal value As Integer)
                intCantidad = value
            End Set
        End Property
#End Region

    End Class

#Region "ArchivoInfoRegionCol"
    Public Class ArchivoInfoRegionCol
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
        Public Function Add(ByVal obj As ArchivoInfoRegion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property ArchivoInfo(ByVal Index As Integer) As ArchivoInfoRegion
            Get
                Return CType(MyBase.List(Index), ArchivoInfoRegion)
            End Get
        End Property
        Public Function CloneCol() As ArchivoInfoRegion
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace
