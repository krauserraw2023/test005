Namespace Registro.Documento
    Public Class NombresAsociados
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Codigo() As Long = -1
        Public Property InternoNombreAsociadoID() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property DocumentoJudicialID() As Integer = -1
        Public Property NAPrincipal() As Integer = -1
        Public Property NAPaterno() As String = ""
        Public Property NAMaterno() As String = ""
        Public Property NANombres() As String = ""
        Public Property NAPrincipal2() As Integer = -1
        Public Property NAPaterno2() As String = ""
        Public Property NAMaterno2() As String = ""
        Public Property NANombres2() As String = ""
        Public Property NAEstadoOri() As Integer = -1
        Public Property NAEstado2() As Integer = -1
        Public Property NAEstado() As Integer = -1
        Public Property NAEstadoNom() As String = ""
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property DocumentoNomAsociadoId As Integer = -1
        Public Property _InternoNAIngresoId As Integer = -1

        Public ReadOnly Property PrincipalBol() As Boolean
            Get
                Dim value As Boolean = False
                Select Case Me.NAPrincipal
                    Case 1
                        value = True
                    Case 0
                        value = False
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property PrincipalBol2() As Boolean
            Get
                Dim value As Boolean = False
                Select Case Me.NAPrincipal2
                    Case 1
                        value = True
                    Case 0
                        value = False
                    Case Else
                        value = False
                End Select
                Return value
            End Get
        End Property
        Public ReadOnly Property ApellidosyNombres() As String
            Get
                Dim value As String = ""
                If Me.NAPaterno = "" Then
                    value = Me.NAPaterno & " " & Me.NAMaterno & IIf(Me.NAPaterno = "", "", ", ") & Me.NANombres
                Else
                    value = Me.NAPaterno & " " & Me.NAMaterno & IIf(Me.NAPaterno = "", "", ", ") & Me.NANombres & " " & " (" & IIf(Me.NAPrincipal = 1, "PRIN", "ASOC") & ")"
                End If
                Return value
            End Get

        End Property
        Public ReadOnly Property ApellidosyNombres2() As String
            Get
                Dim value As String = ""
                If Me.NAPaterno2 = "" Then
                    value = Me.NAPaterno2 & " " & Me.NAMaterno2 & IIf(Me.NAPaterno2 = "", "", ", ") & Me.NANombres2
                Else
                    value = Me.NAPaterno2 & " " & Me.NAMaterno2 & IIf(Me.NAPaterno2 = "", "", ", ") & Me.NANombres2 & " " & " (" & IIf(Me.NAPrincipal2 = 1, "PRIN", "ASOC") & ")"
                End If
                Return value
            End Get

        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.NAEstado
                    Case 0 'anulado
                        value = "ANULADO"
                    Case 1 'activo
                        value = "ACLARADO"
                    Case 2
                        value = "AÑADIDO"
                    Case Else
                        value = "NINGUNO"
                End Select

                Return value
            End Get
        End Property
        Public ReadOnly Property NombreAsociadoCompleto() As String
            Get
                Dim value As String = ""
                If NAPaterno2.Length = 0 Then
                    value = Me.NAPaterno & " " & Me.NAMaterno & IIf(Me.NAPaterno = "", "", ", ") & Me.NANombres & " " & " (" & IIf(Me.NAPrincipal = 1, "PRIN", "ASOC") & ")"
                Else
                    value = Me.NAPaterno2 & " " & Me.NAMaterno2 & IIf(Me.NAPaterno2 = "", "", ", ") & Me.NANombres2 & " " & " (" & IIf(Me.NAPrincipal2 = 1, "PRIN", "ASOC") & ")"
                End If

                Return value
            End Get

        End Property



        '***** variable temporal indica que la entidad debe regularizarse con un documento judicial 
        '(update de registros relacionados, InternoNombreAsociado, DocumentoNombresAsociados, DocumentoJudicial)
        Public Property EstadoAccion As Integer = 0
        Public Property ValorRef() As Boolean = False
        Public Property Posicion As Integer = -1
#End Region
    End Class
#Region "NombresAsociadosCol"
    Public Class NombresAsociadosCol
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
        Public Function Add(ByVal obj As NombresAsociados) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property NombresAsociados(ByVal Index As Integer) As NombresAsociados
            Get
                Return CType(MyBase.List(Index), NombresAsociados)
            End Get
        End Property
        Public Function CloneCol() As NombresAsociados
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace