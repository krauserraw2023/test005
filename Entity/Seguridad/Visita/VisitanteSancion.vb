Namespace Visita
    Public Class VisitanteSancion
        Inherits Globall.Persona
#Region "Propiedades"
        Private intCodigo As Integer = -1
        Private lngInicio As Long = 0
        Private lngFin As Long = 0
        Private lngFecha As Long = 0
        Private intTipoId As Integer = -1
        Private intEstadoId As Integer = -1
        Private strObservacion As String = ""
        Private strDocumento As String = ""
        Private strTipoSancionNombre As String = ""
        Public Property Codigo() As Integer
            Get
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
        Public Property VisitanteID() As Integer = -1
        Public Property VisitanteApeNom As String = ""
        Public Property Fecha() As Long
            Get
                Return lngFecha
            End Get
            Set(ByVal value As Long)
                lngFecha = value
            End Set
        End Property
        Public ReadOnly Property FechaString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.Fecha)
            End Get
        End Property
        Public Property FechaInicio() As Long
            Get
                Return lngInicio
            End Get
            Set(ByVal value As Long)
                lngInicio = value
            End Set
        End Property
        Public ReadOnly Property FechaIniDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaInicio)
            End Get
        End Property
        Public Property FechaFin() As Long
            Get
                Return lngFin
            End Get
            Set(ByVal value As Long)
                lngFin = value
            End Set
        End Property
        Public Property FechaFinIndeterminado() As Boolean = False
        Public ReadOnly Property FechaFinDate() As Date
            Get
                Return Legolas.Components.FechaHora.FechaDate(Me.FechaFin)
            End Get
        End Property
        Public ReadOnly Property FechaFinString() As String
            Get
                Dim value As String = ""

                If Me.FechaFinIndeterminado = True Then
                    value = "Indeterminado"
                Else
                    value = FechaFinDate.ToShortDateString
                End If
                Return value
            End Get
        End Property
        Public Property TipoSancionID() As Integer
            Get
                Return intTipoId
            End Get
            Set(ByVal value As Integer)
                intTipoId = value
            End Set
        End Property
        Public Property TipoSancionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoSancionNombre)
            End Get
            Set(ByVal value As String)
                strTipoSancionNombre = value
            End Set
        End Property
        Public Property EstadoID() As Integer
            Get
                Return intEstadoId
            End Get
            Set(ByVal value As Integer)
                intEstadoId = value
            End Set
        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Anulado"
                    Case 1
                        value = "Activo"
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property Estado() As Boolean
            Get
                Dim value As Boolean = False

                If Me.EstadoID > 0 Then
                    value = True
                End If

                Return value

            End Get
        End Property
        Public Property Documento() As String
            Get
                Return strDocumento
            End Get
            Set(ByVal value As String)
                strDocumento = value
            End Set
        End Property
        Public Property Observacion() As String
            Get
                Return strObservacion
            End Get
            Set(ByVal value As String)
                strObservacion = value
            End Set
        End Property
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
#End Region
#Region "Otros"
        Public Property IDVisitanteSancionSede As Integer = -1
        Public Property IDRegionOrigen() As Integer = -1
        Public Property IDPenalOrigen() As Integer = -1
        Public Property strRegionOrigen() As String = ""
        Public Property strPenalOrigen() As String = ""
        Public Property FechaSede() As Long = 0

        Private lFechaDestino As Long
        Public Property FechaDestino() As Long
            Get
                Return lFechaDestino
            End Get
            Set(ByVal value As Long)
                If Me.PenalID = IDPenalOrigen Then
                    value = Me.FechaSede
                End If
                lFechaDestino = value
            End Set
        End Property
        Public ReadOnly Property RegionPenalOrigen() As String
            Get
                Dim value As String = ""
                If IDRegionOrigen > 0 And IDPenalOrigen Then
                    Dim Reg As String = Legolas.Components.Cadena.ProperCase(strRegionOrigen)
                    Dim Pen As String = Legolas.Components.Cadena.ProperCase(strPenalOrigen)
                    value = Reg & "/" & Pen
                End If
                Return (value)
            End Get
        End Property

        Public ReadOnly Property FechaModificacionAnu() As Long
            Get
                Dim value As Long = Me.FechaModificacion

                If Me.EstadoID <> 0 Then
                    value = 0
                End If
                Return value
            End Get
        End Property

#End Region
#Region "Anulacion"
        Public Property DocumentoAnulacion As String = ""
        Public Property MotivoAnulacion As String = ""
        Public Property FechaAnulacion As Long = 0
        Public Property ObsAnulacion As String = ""
        Public Property IDUsuarioAnulacion As Integer = -1
#End Region
#Region "Auditoria"
        Public Property UsuarioCreacionNombres As String = ""
        Public Property UsuarioAnulacionNombres As String = ""
        Public Property IDUsuarioCreacion As Integer = -1
        Public Property FechaCreacion As Long = 0
        Public Property IDUsuarioModificacion As Integer = -1
        Public Property FechaModificacion As Long = 0
        Public Property IDUsuarioEliminacion As Integer = -1
        Public Property FechaEliminacion As Long = 0
        Public Property Eliminado As Boolean = 0
#End Region
    End Class
#Region "VisitanteSancionCol"
    Public Class VisitanteSancionCol
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
        Public Function Add(ByVal obj As VisitanteSancion) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Visitasancion(ByVal Index As Integer) As VisitanteSancion
            Get
                Return CType(MyBase.List(Index), VisitanteSancion)
            End Get
        End Property
        Public Function CloneCol() As VisitanteSancion
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace