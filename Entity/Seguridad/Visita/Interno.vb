Namespace Visita
    Public Class Interno
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Private strNombres As String = ""
        Private strApellidoPaterno As String = ""
        Private strApellidoMaterno As String = ""
        Public Property Codigo As Long = -1
        Public Property RowID As Long = -1
        Public Property SedeRowId As Long = -1
        Public Property VersionRegistro As String = ""
        Public Property CodigoPadre As Integer = -1
        Public Property TipoDocumentoID As Integer = -1
        Public Property TipoDocumentoCodigo As String = ""
        Public Property TipoDocumentoNombre As String = ""
        Public Property NumeroDocumento As String = ""
        Public Property CodigoRP As String = ""
        Public Property ApellidoPaterno As String
            Get
                Return strApellidoPaterno.ToUpper
            End Get
            Set(ByVal value As String)
                strApellidoPaterno = value
            End Set
        End Property
        Public Property ApellidoMaterno As String
            Get
                Return strApellidoMaterno.ToUpper
            End Get
            Set(ByVal value As String)
                strApellidoMaterno = value
            End Set
        End Property
        Public Property Apellidos As String = ""
        Public ReadOnly Property getRApellidos As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPaterno & " " & Me.ApellidoMaterno
                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property ApellidosReadonly As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPaterno & " " & Me.ApellidoMaterno
                Return value.ToUpper
            End Get
        End Property
        Public Property Nombres As String
            Get
                Return strNombres.ToUpper
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public ReadOnly Property ApellidosyNombres As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPaterno & " " & Me.ApellidoMaterno & " " & Me.Nombres
                Return value
            End Get
        End Property
        Public Property SexoID As Integer = -1
        Public ReadOnly Property SexoNombre() As String
            Get
                Dim strValue As String = ""

                Select Case Me.SexoID
                    Case 1
                        strValue = "Masculino"
                    Case 2
                        strValue = "Femenino"
                End Select
                Return strValue.ToUpper
            End Get

        End Property
        Public ReadOnly Property SexoNombreCorto() As String
            Get
                Dim strValue As String = ""

                Select Case Me.SexoID
                    Case 1
                        strValue = "M"
                    Case 2
                        strValue = "F"
                End Select
                Return strValue.ToUpper
            End Get

        End Property
        Public Property FechaNacimiento As Long = -1
        Public ReadOnly Property FechaNacimientoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
            End Get
        End Property
        Public ReadOnly Property Edad() As Integer
            Get
                Dim value As Integer = 0

                If Me.FechaNacimiento > 0 And (Me.FechaNacimiento < Legolas.LEntity.Config.FechaHoy) Then
                    value = Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimiento, Legolas.LEntity.Config.FechaHoy, True)
                End If

                Return value
            End Get
        End Property
        Public Property NacionalidadID() As Integer = -1
        Public Property NacionalidadCodigo() As String = ""
        Public Property Nacionalidad() As String = ""
        Public Property EstadoID As Integer = -1
        Public ReadOnly Property getEstadoNombre As String
            Get
                Dim strEstado As String = ""
                Select Case EstadoID
                    Case -1
                        strEstado = ""
                    Case 1 'activo
                        strEstado = "Activo"
                    Case Else
                        strEstado = "Inactivo"
                End Select
                Return strEstado
            End Get
        End Property


        Public Property Obs As String = ""
        Public Property IDRegion() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property IDPenal As Integer = -1
        Public Property PenalIDMultiple() As String = ""        
        Public Property PenalNombre As String = ""
#End Region
#Region "Propiedades_Otros"
        Private strSituacionJuridica As String = ""
        Public Property IngresoID As Integer = -1
        Public Property PabellonID() As Integer = -1
        Public Property PabellonNombre() As String = ""
        Public Property VisitaSancion() As Boolean = False
        Public Property SituacionJuridicaID() As Short = -1
        Public Property SituacionJuridica() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSituacionJuridica)
            End Get
            Set(ByVal value As String)
                strSituacionJuridica = value
            End Set
        End Property
        Public Property EtapaID() As Integer = -1
        Public Property EtapaNombre() As String = ""
#End Region

    End Class
#Region "InternoCol"
    Public Class InternoCol
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
        Public Function Add(ByVal obj As Interno) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Interno(ByVal Index As Integer) As Interno
            Get
                Return CType(MyBase.List(Index), Interno)
            End Get
        End Property
        Public Function CloneCol() As Interno
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
