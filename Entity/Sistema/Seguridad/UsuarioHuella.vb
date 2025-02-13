Namespace Sistema.Seguridad
    Public Class UsuarioHuella
        Public Property Codigo As Integer = -1
        Public Property UsuarioId As Integer = -1

        'Public Enum TipoDedo As SByte
        '    NoEspecificado = -1
        '    Ninguno = -1
        '    MeniqueIzquierdo = 1
        '    AnularIzquierdo = 2
        '    MedioIzquierdo = 3
        '    IndiceIzquierdo = 4
        '    PulgarIzquierdo = 5

        '    PulgarDerecho = 6
        '    IndiceDerecho = 7
        '    MedioDerecho = 8
        '    AnularDerecho = 9
        '    MeniqueDerecho = 10
        'End Enum

        Public Property Der_TipoDedoId As SByte = -1   'tipo de dedo, ver clase APPControlHuellaVisita.Type.Enumeracion.TipoDedo
        Public Property Der_TemplateAnsi As Byte()
        Public Property Der_Wsq As Byte()
        Public Property Der_Wsq_alto As Integer
        Public Property Der_Wsq_ancho As Integer
        Public Property Der_CalidadHuella As Short = -1
        Public Property Der_DispBiometricoId() As Integer = -1


        Public Property Izq_TipoDedoId As SByte = -1   'tipo de dedo, ver clase APPControlHuellaVisita.Type.Enumeracion.TipoDedo
        Public Property Izq_TemplateAnsi As Byte()
        Public Property Izq_Wsq As Byte()
        Public Property Izq_Wsq_alto As Integer
        Public Property Izq_Wsq_ancho As Integer
        Public Property Izq_CalidadHuella As Short = -1
        Public Property Izq_DispBiometricoId() As Integer = -1
    End Class
#Region "UsuarioHuellaCol"
    Public Class UsuarioHuellaCol
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
        Public Function Add(ByVal obj As UsuarioHuella) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Session(ByVal Index As Integer) As UsuarioHuella
            Get
                Return CType(MyBase.List(Index), UsuarioHuella)
            End Get
        End Property
    End Class
#End Region
End Namespace
