Namespace Entity
    Public Class Ent_HuellaTemplate

#Region "Propiedades"
        Public Property Codigo() As Integer = -1            'Id del template
        Public Property DocTipoId() As Integer = -1         'tipo de documento de identidad     
        Public Property TipoCapturaHuella As Type.Enumeracion.enmTipoCapturaHuella = Type.Enumeracion.enmTipoCapturaHuella.NO_ESPECIFICADO
        Public Property TipoDedoId() As Type.Enumeracion.TipoDedo = Type.Enumeracion.TipoDedo.NoEspecificado   'tipo de dedo
        Public Property DispBiometricoId() As Integer = -1 'tipo de dispositivo biometrico
        'Public Property TipoDocIdentidadId As Integer = -1
        Public Property NumDocumento() As String = ""       'numero de documento de identidad        
        Public Property CodigoRP() As String = ""       'codigoRP
        Public Property ApellidoPaterno() As String = ""       'apellido paterno
        Public Property ApellidoMaterno() As String = ""       'apellido materno
        Public Property Nombres() As String = ""       'nombres
        Public Property TipoCaptura() As Integer = -1
        Public Property TemplatePropietario() As Byte() = Nothing  'plantilla SUPREMA
        Public Property TemplateANSI() As Byte() = Nothing  'plantilla ANSI
        Public Property NombrePC() As String = ""
        Public Property MacPC() As String = ""
        Public Property IpPC() As String = ""
        Public Property RegSincronizadoSede As Integer = -1 'flag que indice si el registro ha sido sincronizado con el registro de la sede central (si contienen el mismo valor)
        Public Property IndiceCalidadImg() As Type.Enumeracion.IndiceCalidadHuella = Type.Enumeracion.IndiceCalidadHuella.NoEspecificado  'indice de calidad de la huella (imagen huella)
        Public Property EstadoDedo() As Type.Enumeracion.EstadoDedo = Type.Enumeracion.EstadoDedo.NoEspecificado
        Public Property Observacion() As String = ""
        Public Property RegionId() As Integer = -1
        Public Property PenalId() As Integer = -1

#End Region
    End Class

    Public Class HuellaTemplateCol
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
        Public Function Add(ByVal obj As Ent_HuellaTemplate) As Integer
            Return MyBase.List.Add(obj)
        End Function
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
        Public ReadOnly Property Item(ByVal Index As Integer) As Ent_HuellaTemplate
            Get
                Try
                    Return CType(MyBase.List(Index), Ent_HuellaTemplate)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
        Public ReadOnly Property HuellaTemplate(ByVal Index As Integer) As Ent_HuellaTemplate
            Get
                Try
                    Return CType(MyBase.List(Index), Ent_HuellaTemplate)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property
    End Class
End Namespace