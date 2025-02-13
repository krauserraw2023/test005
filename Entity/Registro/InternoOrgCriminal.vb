Namespace Registro
    Public Class InternoOrgCriminal
        Inherits Auditoria.Transaccion
#Region "Propiedades"
        Public Property SedeRowId As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property InternoID() As Integer = -1
        Public Property BandaID() As Integer = -1
        Private strBandNom As String = ""
        Public Property BandaNombre() As String
            Get
                Return UCase(strBandNom)
            End Get
            Set(value As String)
                strBandNom = value
            End Set
        End Property
        Public ReadOnly Property BandaTipoNom_Ini() As String
            Get
                Dim strVal As String = ""
                'If Me.BandaTipoNombre = "BANDA" Then strVal = "BANDA"
                'If Me.BandaTipoNombre = "ORGANIZACION CRIMINAL" Then strVal = "CRIM. ORG."
                strVal = "CRIM. ORG."
                Return strVal
            End Get
        End Property
        Public Property BandaTipoID() As Integer = -1
        Public Property BandaTipoNombre() As String = ""
        Public Property BandaMiembroTipoID() As Integer = -1
        Private strBandMiemTipNom As String = ""
        Public Property BandaMiembroTipoNombre() As String
            Get
                Return UCase(strBandMiemTipNom)
            End Get
            Set(value As String)
                strBandMiemTipNom = value
            End Set
        End Property
        Public Property BandaMiembroTipoNombre_Ini() As String
            Get
                Dim strVal As String = ""
                'Cabecilla-Lider
                Select Case UCase(Me.BandaMiembroTipoNombre)
                    Case "INTEGRANTE"
                        strVal = "INT."
                    Case "FINANCISTA"
                        strVal = "FNC."
                    Case "CABECILLA-LIDER"
                        strVal = "C/L"
                    Case Else
                        strVal = ""
                End Select
                Return strVal
            End Get
            Set(value As String)
                strBandMiemTipNom = value
            End Set
        End Property
        Public Property DocJudicialID_Crea() As Integer = -1
        Public Property DocJudicialID_Anula() As Integer = -1 'documento judicial se crea al anular
        Public Property Observacion() As String = ""
        Public Property Estado() As Integer = -1
        Public ReadOnly Property EstadoNombre() As String
            Get
                Dim value As String = ""

                Select Case Me.Estado
                    Case 0 'anulado
                        value = "ANULADO"
                    Case 1 'activo
                        value = "ACTIVO"
                End Select

                Return value
            End Get
        End Property
        Public Property IngresoID() As Integer = -1
        Public Property IngresoInpeID As Integer = -1
        Public Property IngresoNro() As String = ""
        Public Property IngresoInpeNro() As String = ""
        'Private _IngresoNro As String = ""
        'Public Property IngresoNro() As String
        '    Get
        '        Return _IngresoNro
        '    End Get
        '    Set(value As String)
        '        If IngresoNro = -1 Then
        '            _IngresoNro = ""
        '        End If
        '        _IngresoNro = value
        '    End Set
        'End Property
        '------------------------------------------------------->
        'creado 09.04.2014 hnrb 
#Region "Datos_Integrante_Banda"
        Public Property CodigoInterno() As String = "" 'codigo del interno        
        Public Property ApePatInterno() As String = "" 'ape paterno del interno
        Public Property ApeMatInterno() As String = "" 'ape materno del interno
        Public ReadOnly Property ApellidosInterno() As String
            Get
                Return UCase(Me.ApePatInterno & " " & Me.ApeMatInterno)
            End Get
        End Property
        Public Property NombresInterno() As String = "" 'nombres del interno
        Public ReadOnly Property NombresCompletos() As String
            Get
                Return UCase(Me.ApePatInterno & " " & Me.ApeMatInterno & ", " & Me.NombresInterno)
            End Get
        End Property
        Public Property InternoApeNombres As String = ""
        Public Property TipoDocIdent() As String = "" 'tipo de documento del interno
        Public Property NumDocIdentInt() As String = "" 'numero de documento del interno
        Public ReadOnly Property DocIdenInt() As String 'tipo doc y num doc
            Get
                Return TipoDocIdent() & " " & NumDocIdentInt()
            End Get

        End Property
        Public Property FecNacInt() As Long = 0 'fecha nacimiento del interno
        Public Property NacionalidadInt() As String = "" 'nacionalidad del interno
        Public Property RegioID As Integer = -1
        Public Property RegionNom As String = ""
        Public Property PenalID As Integer = -1
        Public Property PenalNom As String = ""

#Region "Propiedades_Documento_Judicial"
        Public Property DocJudSalaID() As Integer = -1
        Public Property DocJudDistNom() As String = ""
        Public Property DocJudSalaNom() As String = ""
        Public Property DocJudNum() As String = ""
        Private lgnFechDocJud As Long = 0
        Public Property FechDocJud() As Long
            Get
                Return lgnFechDocJud
            End Get
            Set(value As Long)
                lgnFechDocJud = value
            End Set
        End Property
        Public ReadOnly Property FechDocJudConFormato As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechDocJud())
            End Get
        End Property
        Public Property DocJudSecre() As String = ""

#End Region
#End Region
        '<--------------------------------------------------
#End Region
    End Class

#Region "BandaCol"
    Public Class InternoOrgCriminalCol
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
        Public Function Add(ByVal obj As InternoOrgCriminal) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property OrganizacionCriminal(ByVal Index As Integer) As InternoOrgCriminal
            Get
                Return CType(MyBase.List(Index), InternoOrgCriminal)
            End Get
        End Property
    End Class
#End Region
End Namespace
