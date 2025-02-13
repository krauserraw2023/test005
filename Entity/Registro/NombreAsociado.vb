Namespace Registro
    Public Class NombreAsociado
        Inherits Auditoria.Transaccion

        Private strApellidoPaterno As String = ""
        Private strApellidoMaterno As String = ""
        Private strNombres As String = ""
        Private strApellidoPaterno2 As String = ""
        Private strApellidoMaterno2 As String = ""
        Private strNombres2 As String = ""
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Numero() As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeID As Integer = -1
        Public Property IngresoNro() As String = ""
        Public Property IngresoNroInpe As String = ""
        Public Property DocumentoJudicialID() As Integer = -1
        Public Property DocumentoJudicialID_NA() As Integer = -1
        Public Property Principal() As Integer = -1
        Public Property DocumentoExiste As Boolean = False
        Public ReadOnly Property PrincipalNombre() As String
            Get
                Dim value As String = ""
                Select Case Me.Principal
                    Case 1
                        value = "Principal"
                    Case 0
                        value = "Asociado"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property PrincipalBol() As Boolean
            Get
                Dim value As Boolean = False
                Select Case Me.Principal
                    Case 1
                        value = True
                    Case 0
                        value = False
                End Select
                Return value
            End Get
        End Property
        Public Property ApellidoPaterno() As String
            Get
                Return strApellidoPaterno.ToUpper
            End Get
            Set(ByVal value As String)
                strApellidoPaterno = value
            End Set
        End Property
        Public Property ApellidoMaterno() As String
            Get
                Return strApellidoMaterno.ToUpper
            End Get
            Set(ByVal value As String)
                strApellidoMaterno = value
            End Set
        End Property
        Public ReadOnly Property Apellidos() As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPaterno & " " & Me.ApellidoMaterno

                Return value
            End Get

        End Property
        Public ReadOnly Property ApellidosyNombres() As String
            Get
                Dim value As String = ""
                value = Me.Apellidos & " " & Me.Nombres
                Return value
            End Get

        End Property
        Public Property Nombres() As String
            Get
                Return strNombres.ToUpper
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public Property ApellidoPaterno2() As String
            Get
                Return strApellidoPaterno2.ToUpper
            End Get
            Set(ByVal value As String)
                strApellidoPaterno2 = value
            End Set
        End Property
        Public Property ApellidoMaterno2() As String
            Get
                Return strApellidoMaterno2.ToUpper
            End Get
            Set(ByVal value As String)
                strApellidoMaterno2 = value
            End Set
        End Property
        Public ReadOnly Property Apellidos2() As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPaterno2 & " " & Me.ApellidoMaterno2

                Return value
            End Get

        End Property
        Public ReadOnly Property ApellidosyNombres2() As String
            Get
                Dim value As String = ""
                value = Me.Apellidos2 & " " & Me.Nombres2
                Return value
            End Get

        End Property
        Public Property Nombres2() As String
            Get
                Return strNombres.ToUpper
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public Property Estado() As Integer = -1
        Public Property EstadoRegDoc() As Integer = -1
        Public Property NuevoNA() As Integer = -1
        Public Property DocumentoNombreAsociadoID As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.Estado
                    Case Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.Anulado  'anulado
                        value = "Anulado"
                    Case Type.Enumeracion.EstadoNulidadRegistro.EnumEstadoNulidadRegistro.Activo  'activo
                        value = "Activo"
                End Select

                Return value
            End Get
        End Property
        Public Property DocumentoTipoId() As Integer = -1
        Public Property DocumentoNomAsociadoId() As Integer = -1
        Public Property DocumentoReferencia As String = ""
        Public Property Observacion As String = ""
#End Region
#Region "Propeidades_Filtro"
        Public Property RegionID As Integer = -1
        Public Property PenalID As Integer = -1
        Public Property InternoIDString As String = ""
#End Region
    End Class
#Region "NombreAsociadoCol"
    Public Class NombreAsociadoCol
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
        Public Function Add(ByVal obj As NombreAsociado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property NombreAsociado(ByVal Index As Integer) As NombreAsociado
            Get
                Return CType(MyBase.List(Index), NombreAsociado)
            End Get
        End Property
    End Class
#End Region
End Namespace
