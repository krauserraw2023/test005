Namespace Visita
    Public Class Autorizacion
        Inherits Entity.Auditoria.Transaccion
#Region "Propiedades"
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property InternoApeNom As String = ""
        Public Property VisitanteID() As Integer = -1       
        Public Property TipoID() As Integer = -1
        Public ReadOnly Property TipoNombre() As String
            Get
                Dim value As String = ""
                Select Case Me.TipoID
                    Case Type.Enumeracion.Visita.AutorizacionTipo.Autorizado
                        value = "Autorizado"
                    Case Type.Enumeracion.Visita.AutorizacionTipo.Anulacion
                        value = "Anulado"
                    Case Type.Enumeracion.Visita.AutorizacionTipo.Extraordinario
                        value = "Extraordinario"
                End Select
                Return value
            End Get
        End Property
        Public Property CalendarioDetalleID As Integer = -1
        Public Property Documento() As String = ""
        Public Property Fecha() As Long = 0
        'Public Property FechaInicio() As Long = 0
        'Public Property FechaFin() As Long = 0
        Public Property ParentescoID() As Integer = -1
        Public Property Parentesco As String = ""
        Public Property EstadoID() As Integer = -1
        Public ReadOnly Property Estado() As String
            Get
                Dim value As String = ""
                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select
                Return value
            End Get            
        End Property
        Public Property Observacion As String = ""
        Public Property Usuario_Registro As String = ""
        Public Property Fecha_Registro As String = ""
        Public ReadOnly Property HasObservacion() As Boolean
            Get
                Return (Me.Observacion.Trim.Length > 0)
            End Get
            
        End Property        
#End Region
#Region "Propiedades_Filtro"
        Public Property RegionID() As Short = -1
        Public Property PenalID() As Short = -1        
#End Region
#Region "Propiedades_Interno"

        Public Property InternoCodigoPadre As Short = -1
        Public Property InternoCodigo As String = ""
        Public Property InternoNumeroDocumento As String = ""
        Public Property InternoApePaterno As String = ""
        Public Property InternoApeMaterno As String = ""
        Public Property InternoApellidos As String = ""

        Public ReadOnly Property InternoApellidosReadonly() As String
            Get
                Dim strValue As String = ""
                strValue = Me.InternoApePaterno & " " & Me.InternoApeMaterno
                Return strValue.ToUpper
            End Get
        End Property
        Public Property InternoNombres As String = ""
        Public ReadOnly Property InternoApellidosyNombresReadonly() As String
            Get
                Dim value As String = ""

                If Me.InternoID > 0 Then
                    value = Me.InternoApePaterno & " " & Me.InternoApeMaterno & ", " & Me.InternoNombres
                End If

                Return value.ToUpper
            End Get
        End Property
        Public Property InternoSitJuridica As String = ""
        Public Property InternoEstado As Short = -1
        Public ReadOnly Property InternoEstadoNom() As String
            Get
                Dim value As String = ""
                Select Case Me.InternoEstado
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get

        End Property

#End Region
#Region "Visitante"
        Public Property VisitantePrimerApe As String = ""
        Public Property VisitanteSegundoApe As String = ""
        Public ReadOnly Property VisitanteApellidosyNombres As String
            Get
                Dim value As String = ""
                value = VisitantePrimerApe & " " & Me.VisitanteSegundoApe & ", " & Me.VisitanteNombres
                Return value
            End Get
        End Property

        Public Property VisitanteNombres As String = ""
        Public Property VisitanteApeNom As String = ""
        Public Property IDTipoDocumentoVisitante As Integer = -1
        Public Property VisitanteTipoDocumentoNombre As String = ""
        Public Property VisitanteNumeroDocumento As String = ""
        Public ReadOnly Property VisitanteTipoDoc_Numero As String
            Get
                Dim value As String = ""
                value = Me.VisitanteTipoDocumentoNombre & " " & VisitanteNumeroDocumento
                Return value
            End Get
        End Property
        Public Property VisitanteFechaNacimiento As Long = 0
        Public ReadOnly Property VisitanteEdad As Integer
            Get
                Dim value As Integer = 0

                If Me.VisitanteFechaNacimiento > 0 Then
                    value = Legolas.Components.FechaHora.FechaCalcularAnio(Me.VisitanteFechaNacimiento, Legolas.LBusiness.Globall.DateTime.FechaServerLong, True)
                End If

                Return value

            End Get
        End Property
#End Region
#Region "Grilla"
        Public Property SeleccionarCheck() As Boolean = False
#End Region
    End Class
#Region "AutorizacionCol"
    Public Class AutorizacionCol
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
        Public Function Add(ByVal value As Autorizacion) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Autorizacion) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Autorizacion) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Autorizacion)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Autorizacion
            Get
                Return DirectCast(List(index), Autorizacion)
            End Get
            Set(ByVal value As Autorizacion)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Autorizacion)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Autorizacion
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace