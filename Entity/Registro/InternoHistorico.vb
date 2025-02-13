Namespace Registro
    Public Class InternoHistorico
        Inherits Legolas.LEntity.Globall.Persona
#Region "Propiedades"
        Private strNacimientoOtros As String = ""
        Private strDomicilio As String = ""
        Private strEstado As String = ""
        Private strOcupacionNombre As String = ""
        Private strNivelAcademicoNombre As String = ""
        Private strProfesionNombre As String = ""
        Private strComunidadAndinaNombre As String = ""
        Private strObs As String = ""
        Private blnDMP As Boolean
        Private blnSMP As Boolean
        '--------------------------
        Public Property CentroReclusionMenorId As Integer = -1
        Public Property FlagTransferenciaSede As Integer = 0
        Public Property Codigo() As Integer = -1
        Public Property NombreClaveInterno As String = ""
        Public Property CodigoUnicoInterno As String = ""
        Public Property InternoID() As Integer = -1
        'Public Property SedeInternoId As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property ExpedienteID() As Integer = -1
        Public Property SentenciaID() As Integer = -1
        Public Property DelitoID() As Integer = -1
        Public Property CodigoRP() As String = ""
        Public Property CodigoPadre() As Integer = -1
        Public Property Libro() As String = ""
        Public Property Folio() As String = ""        
        Public Property NacimientoUbigeoID() As Integer = -1
        Public Property NacimientoOtros() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacimientoOtros)
            End Get
            Set(ByVal value As String)
                strNacimientoOtros = value
            End Set
        End Property
        Public Property DomicilioUbigeoID() As Integer = -1
        Public Property Domicilio() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDomicilio)
            End Get
            Set(ByVal value As String)
                strDomicilio = value
            End Set
        End Property
        Public Property NivelAcademicoID() As Integer = -1
        Public Property NivelAcademicoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNivelAcademicoNombre)
            End Get
            Set(ByVal value As String)
                strNivelAcademicoNombre = value
            End Set
        End Property
        Public Property NumeroHijos() As Integer = -1
        Public Property HijosMenores() As Integer = -1
        Public Property ProfesionID() As Integer = -1
        Public Property ProfesionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strProfesionNombre)
            End Get
            Set(ByVal value As String)
                strProfesionNombre = value
            End Set
        End Property
        Public Property OcupacionTipoID() As Integer = -1
        Public Property OcupacionTipoNombre() As String = ""
        Public Property OcupacionID() As Integer = -1
        Public Property OcupacionNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strOcupacionNombre)
            End Get
            Set(ByVal value As String)
                strOcupacionNombre = value
            End Set
        End Property
        Public Property Discapacidad() As Integer = -1
        Public Property DiscapacidadNombre() As String = ""
        Public Property ComunidadAndinaNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strComunidadAndinaNombre)
            End Get
            Set(ByVal value As String)
                strComunidadAndinaNombre = value
            End Set
        End Property
        Public Property ComunidadAndinaID() As Integer = -1
        Public Property ComunidadAndinaEspID() As Integer = -1
        Public Property EstadoID() As Integer = -1
        Public ReadOnly Property EstadoNombreReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoID
                    Case 0
                        value = "Inactivo"
                    Case 1
                        value = "Activo"
                End Select

                Return value.ToUpper
            End Get
        End Property
        Public Property EstadoNom() As String
            Get
                Return strEstado.ToUpper
            End Get
            Set(ByVal value As String)
                strEstado = value
            End Set
        End Property
        Public Property Obs() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strObs)
            End Get
            Set(ByVal value As String)
                strObs = value
            End Set
        End Property
        Public Property PabellonID() As Integer = -1
        Public Property PabellonNombre() As String = ""
        Public Property Decadactilar() As String = ""
        Public Property Homonimia As Boolean = False
        Public Property DMP() As Boolean
            Get
                Return blnDMP
            End Get
            Set(ByVal value As Boolean)
                blnDMP = value
            End Set
        End Property
        Public Property SMP() As Boolean
            Get
                Return blnSMP
            End Get
            Set(ByVal value As Boolean)
                blnSMP = value
            End Set
        End Property
        Public Property Obs_DNI() As String = ""
        Public Property EstadoRncID As Integer = -1

        Public ReadOnly Property EstadoRnc As String
            Get
                Dim value As String = ""

                Select Case Me.EstadoRncID
                    Case 1
                        value = "VAL" 'validado
                    Case 2
                        value = "OBS" 'onservado
                    Case 3
                        value = "IND" 'indocumentado
                End Select
                Return value
            End Get
        End Property
        Public Property IngresoSistemaPen As Long = 0
        Public Property Eliminado As Boolean = False
        Public Property _flg_eli As Boolean = False
        Public Property DocJudIDAux As Integer = -1
        'Public Property DocJudTipAux As Integer = -1
        Public Property GeneroId As Integer = -1
        Public Property IdiomaNativoId As Integer = -1

        Public Property CentroTrabajo As String = ""
        Public Property ReligionId As Integer = -1
        Public Property CodigoFuerzaArmadaId As Integer = -1
        Public Property CodigoRangoId As Integer = -1
#Region "Poblacion_Etnica"
        Public Property IDGrupoPueblo() As Integer = -1
        Public Property IDPueblo() As Integer = -1
        Public Property OtroPueblo() As String = ""
        Public Property IDGrupoLenguaMaterna() As Integer = -1
        Public Property IDLenguaMaterna() As Integer = -1
        Public Property IDIdioma() As Integer = -1
#End Region
#Region "Ubicacion"
        Private strPenalNombre As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property PenalID() As Integer = -1
        Public Property PenalCodigo() As String = ""
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
#End Region

#End Region
    End Class
#Region "InternoCol"
    Public Class InternoHisCol
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
        Public Function Add(ByVal value As InternoHistorico) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As InternoHistorico) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As InternoHistorico) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As InternoHistorico)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As InternoHistorico
            Get
                Return DirectCast(List(index), InternoHistorico)
            End Get
            Set(ByVal value As InternoHistorico)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As InternoHistorico)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As InternoHistorico
            Return MyBase.MemberwiseClone
        End Function
    End Class
#End Region
End Namespace
