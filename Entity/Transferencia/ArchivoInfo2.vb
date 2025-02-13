Namespace Transferencia
    Public Class ArchivoInfo2
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private lngCodigo As Long = 0
        Private intRegion As Integer = -1
        Private strRegionNombre As String = ""
        Private intPenal As Integer = -1
        Private strPenalNombre As String = ""
        Private intArchivoNumero As Integer = -1
        Private strArchivoNombre As String = ""
        ' Private lngArchivoFecha As Long = 0
        Private strArchivoHora As String = ""
        Private intTotalInternos As Integer = -1
        Private intTotalHombres As Integer = -1
        Private intTotalMujeres As Integer = -1
        Private intTotalPro As Integer = -1
        Private intTotalSen As Integer = -1
        Private intVerApp As Integer = -1
        Private intVerBD As Integer = -1
        Private intLicencia As Integer = -1
        Private lngArchivoFechaAnterior As Long = 0
        Private intPenalCapacidad As Integer = 0
        Private strPenalEstadoInternet As String = ""

        Public Property Codigo() As Long 'CODIGO DE ARCHIVO
            Get
                Return lngCodigo
            End Get
            Set(ByVal value As Long)
                lngCodigo = value
            End Set
        End Property
        Public Property Region() As Integer
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
        Public Property Penal() As Integer
            Get
                Return intPenal
            End Get
            Set(ByVal value As Integer)
                intPenal = value
            End Set
        End Property
        Public Property PenalNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strPenalNombre)
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property PenalCapacidad() As Integer
            Get
                Return intPenalCapacidad
            End Get
            Set(ByVal value As Integer)
                intPenalCapacidad = value
            End Set
        End Property
        Public Property PenalEstadoInternet() As String
            Get
                Return strPenalEstadoInternet
            End Get
            Set(ByVal value As String)
                strPenalEstadoInternet = value
            End Set
        End Property
        Public Property ArchivoNumero() As Integer
            Get
                Return intArchivoNumero
            End Get
            Set(ByVal value As Integer)
                intArchivoNumero = value
            End Set
        End Property
        Public Property ArchivoNombre() As String
            Get
                Return strArchivoNombre
            End Get
            Set(ByVal value As String)
                strArchivoNombre = value
            End Set
        End Property
        Public Property ArchivoFecha() As Long = 0
        Public ReadOnly Property ArchivoFechaString() As String
            Get
                If ArchivoFecha > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(ArchivoFecha, True).ToString
                Else
                    Return ""
                End If
            End Get
        End Property
        Public ReadOnly Property ArchivoFechaHoraDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me._UltimaFechaUploadSede, True)
            End Get
        End Property

        Public Property ArchivoFechaAnterior() As Long
            Get
                Return lngArchivoFechaAnterior
            End Get
            Set(ByVal value As Long)
                lngArchivoFechaAnterior = value
            End Set
        End Property
        Public ReadOnly Property ArchivoFechaAnteriorString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.ArchivoFechaAnterior)
            End Get
        End Property
        Public Property ArchivoHora() As String
            Get
                Return strArchivoHora
            End Get
            Set(ByVal value As String)
                strArchivoHora = value
            End Set
        End Property
        Public Property TotalInternos() As Integer
            Get
                Return intTotalInternos
            End Get
            Set(ByVal value As Integer)
                intTotalInternos = value
            End Set
        End Property
        Public Property TotalHombres() As Integer
            Get
                Return intTotalHombres
            End Get
            Set(ByVal value As Integer)
                intTotalHombres = value
            End Set
        End Property
        Public Property TotalMujeres() As Integer
            Get
                Return intTotalMujeres
            End Get
            Set(ByVal value As Integer)
                intTotalMujeres = value
            End Set
        End Property
        Public Property TotalPro() As Integer
            Get
                Return intTotalPro
            End Get
            Set(ByVal value As Integer)
                intTotalPro = value
            End Set
        End Property
        Public Property TotalSen() As Integer
            Get
                Return intTotalSen
            End Get
            Set(ByVal value As Integer)
                intTotalSen = value
            End Set
        End Property
        Public Property VerApp() As Integer
            Get
                Return intVerApp
            End Get
            Set(ByVal value As Integer)
                intVerApp = value
            End Set
        End Property
        Public Property VerBD() As Integer
            Get
                Return intVerBD
            End Get
            Set(ByVal value As Integer)
                intVerBD = value
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
        Public Property CantErrorProcesadoSede() As Integer = 0 'cantidad total de errores de procesamiento en sede
        Public Property CantErrorProcesadoPorPenal() As Integer = 0 'cantidad total de errores de procesamiento en sede
        Public Property TotalExpedientes() As Integer = -1
        Public Property TotalDelitos() As Integer = -1
        Public Property TotalAgraviados() As Integer = -1
        Public Property ErrorProcesoEnSede() As Boolean = False
        Public Property FechaDesde() As Long = 0
        Public Property FechaHasta() As Long = 0
        Public Property FechaSubidaSede() As Long = 0
        Public Property TamanioXmlEnBytes() As Long = 0
        Public ReadOnly Property TamanioXmlEnMb() As Double
            Get
                Dim x As Decimal
                x = TamanioXmlEnBytes / 1048576
                Return Decimal.Round(x, 3)
            End Get
        End Property
        Public Property TamanioZipEnBytes() As Long = 0
        Public ReadOnly Property TamanioZipEnMb() As Double
            Get
                Dim x As Decimal
                x = TamanioZipEnBytes / 1048576
                Return Decimal.Round(x, 3)
            End Get
        End Property
        Public Property FechaProcesaSede() As Long = 0
        Public Property FechaDescargaRegion() As Long = 0
        Public Property FechaProcesaRegion() As Long = 0


        Public ReadOnly Property ErrorProcesoEnSedeString() As String
            Get
                If ErrorProcesoEnSede = True Then
                    Return "ERROR"
                Else
                    Return ""
                End If
            End Get
        End Property
        Public ReadOnly Property FechaDesdeString() As String
            Get
                If FechaDesde > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.FechaDesde, True)
                Else
                    Return ""
                End If
            End Get
        End Property
        Public ReadOnly Property FechaHastaString() As String
            Get
                If FechaHasta > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.FechaHasta, True)
                Else
                    Return ""
                End If
            End Get
        End Property
        Public ReadOnly Property FechaSubidaSedeString() As String
            Get
                If FechaSubidaSede > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.FechaSubidaSede, True)
                Else
                    Return "PENDIENTE"
                End If
            End Get
        End Property
        Public ReadOnly Property FechaProcesaSedeString() As String
            Get
                If FechaProcesaSede > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.FechaProcesaSede, True)
                Else
                    Return "PENDIENTE"
                End If
            End Get
        End Property
        Public ReadOnly Property FechaDescargaRegionString() As String
            Get
                If FechaDescargaRegion > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.FechaDescargaRegion, True)
                Else
                    If Region = 3 Or Penal = 22 Or Penal = 5 Then
                        Return "PROCESADO"
                    Else
                        Return "PENDIENTE"
                    End If
                End If
            End Get
        End Property
        Public ReadOnly Property FechaProcesaRegionString() As String
            Get
                Dim str As String = ""
                If FechaProcesaRegion > 0 Then
                    str = Legolas.Components.FechaHora.FechaDate(Me.FechaProcesaRegion, True)
                Else
                    If Region = 3 Or Penal = 22 Or Penal = 5 Then
                        str = "PROCESADO"
                    Else
                        str = "PENDIENTE"
                    End If
                End If
                Return str
            End Get
        End Property
        Public Property PathArchivoServer() As String = ""
        Private _TotPendDescargaRegion As Integer
        Public Property TotPendDescargaRegion() As Integer
            Get
                If Region = 3 Or Penal = 22 Or Penal = 5 Then 'la region lima y los penales indicados no descargan
                    Return 0
                End If
                Return _TotPendDescargaRegion
            End Get
            Set(ByVal value As Integer)
                _TotPendDescargaRegion = value
            End Set
        End Property
        Private lngArchivoFechaAnteriorProcSede As Long = 0
        Public Property ArchivoFechaAnteriorProcSede() As Long
            Get
                Return lngArchivoFechaAnteriorProcSede
            End Get
            Set(ByVal value As Long)
                lngArchivoFechaAnteriorProcSede = value
            End Set
        End Property
        Public Property PenalBloqueadoTransfer() As Short        
        Public ReadOnly Property PenalBloqueadoString() As String
            Get
                Dim value As String = ""
                Select Case PenalBloqueadoTransfer
                    Case 1
                        value = "Bloqueado"
                End Select

                Return value
            End Get
        End Property

        Private _UltimaFechaUploadSede As Long = 0 'ultima fecha de upload a sede
        Public Property UltimaFechaUploadSede() As Long
            Get
                Return _UltimaFechaUploadSede
            End Get
            Set(ByVal value As Long)
                _UltimaFechaUploadSede = value
            End Set
        End Property


        Public ReadOnly Property EstadoTransferencia() As String
            Get
                Dim str As String = ""
                Dim intDias As Integer = 0
                If Me._UltimaFechaUploadSede = 0 Then Return str
                Dim fechUltTransfer As Date = Legolas.Components.FechaHora.FechaDate(Me._UltimaFechaUploadSede, True)
                intDias = DateDiff(DateInterval.Day, fechUltTransfer, Now)
                If intDias > 3 And intDias <= 10 Then
                    str = "AMARILLO"
                ElseIf intDias > 10 And intDias <= 30 Then
                    str = "NARANJA"
                ElseIf intDias > 30 Then
                    str = "ROJO"
                End If
                Return str
            End Get

        End Property

        Public ReadOnly Property UltimaFechaUploadSedeString() As String
            Get
                If Me.UltimaFechaUploadSede > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.UltimaFechaUploadSede, True)
                Else
                    Return ""
                End If
            End Get
        End Property

        Private _UltimaFechaProcesoSede As Long = 0 'ultima fecha de procesamiento de archivo
        Public Property UltimaFechaProcesoSede() As Long
            Get
                Return _UltimaFechaProcesoSede
            End Get
            Set(ByVal value As Long)
                _UltimaFechaProcesoSede = value
            End Set
        End Property
        Public ReadOnly Property UltimaFechaProcesoSedeString() As String
            Get
                If Me.UltimaFechaProcesoSede > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.UltimaFechaProcesoSede, True)
                Else
                    Return ""
                End If
            End Get
        End Property

        Private _UltimaFechaDownloadRegion As Long = 0 'ultima fecha de descarga en region
        Public Property UltimaFechaDownloadRegion() As Long
            Get
                Return _UltimaFechaDownloadRegion
            End Get
            Set(ByVal value As Long)
                _UltimaFechaDownloadRegion = value
            End Set
        End Property
        Public ReadOnly Property UltimaFechaDownloadRegionString() As String
            Get
                If Me.UltimaFechaDownloadRegion > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.UltimaFechaDownloadRegion, True)
                Else
                    Return ""
                End If
            End Get
        End Property

        Private _UltimaFechaProcesoRegion As Long = 0 'ultima fecha de procesado region
        Public Property UltimaFechaProcesoRegion() As Long
            Get
                Return _UltimaFechaProcesoRegion
            End Get
            Set(ByVal value As Long)
                _UltimaFechaProcesoRegion = value
            End Set
        End Property
        Public ReadOnly Property UltimaFechaProcesoRegionString() As String
            Get
                If Me.UltimaFechaProcesoRegion > 0 Then
                    Return Legolas.Components.FechaHora.FechaDate(Me.UltimaFechaProcesoRegion, True)
                Else
                    If Region = 3 Or Penal = 22 Or Penal = 5 Then
                        Return "PROCESADO"
                    Else
                        Return ""
                    End If

                End If
            End Get
        End Property
        Public Property TipoPaquete As Integer = -1
#End Region
#Region "Otros"
        Private lngFechaInstalacion As Long = 0
        Public Property FechaInstalacion() As Long
            Get
                Return lngFechaInstalacion
            End Get
            Set(ByVal value As Long)
                lngFechaInstalacion = value
            End Set
        End Property
#End Region
    End Class

#Region "ArchivoInfoCol"
    Public Class ArchivoInfo2Col
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
        Public Function Add(ByVal obj As ArchivoInfo2) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property ArchivoInfo(ByVal Index As Integer) As ArchivoInfo2
            Get
                Return CType(MyBase.List(Index), ArchivoInfo2)
            End Get
        End Property
        Public Function CloneCol() As ArchivoInfo2
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace