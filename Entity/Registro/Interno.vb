Imports System.Linq
Imports System.Data.Linq
Imports System.Xml.Linq
Namespace Registro
    Public Class Interno
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
        Public Property SedeRowId As Integer = -1
        Public Property RowID As Integer = -1
        '-----------------------------
        Public Property CentroReclusionMenorId As Integer = -1 '0=Ninguno  1=ninguno 2=maranga 3=juan pablo segundo 4=Hermelinda carrera
        Public Property FlagTransferenciaSede As Short = 0
        Public Property Codigo() As Integer = -1
        Public Property CodigoAfiliacion As Integer = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property IngresoID() As Integer = -1
        Public Property ExpedienteID() As Integer = -1
        Public Property NombreClaveInterno As String = ""
        Public Property CodigoUnicoInternoId As Integer = -1
        Public Property CodigoUnicoInterno As String = ""
        Public Property DocumentoTrasladoID As String = ""
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
        Public Property NumeroHijos() As Integer = 0
        Public Property HijosMenores() As Integer = 0
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
        Public Property RegimenInterno As String = ""
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

                        If EstadoBloqueoId = 1 Then
                            value = "Inactivo"
                        End If

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
        Public Property Homonimia() As Boolean = False
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
                        value = "OBS" 'observado
                    Case 3
                        value = "NEC" 'no encontrado
                End Select
                Return value
            End Get
        End Property
        Public Property EstadoEspecificoID As Integer = -1
        Public ReadOnly Property EstadoEspecificoNombre As String
            Get
                Dim value As String = ""
                If Me.CodigoRP = "" Then
                    value = ""
                Else
                    Select Case Me.EstadoEspecificoID
                        Case 1
                            value = "RECLUIDO"
                        Case 2
                            value = "FUGA"
                        Case 3
                            value = "FALLECIDO"
                        Case 4
                            value = "EN CONDUCCION"
                        Case 5
                            value = "CON LIBERTAD"
                        Case 6
                            value = "EN TRASLADO"
                        Case 7
                            value = "PENDIENTE DE EGRESO"
                        Case 8
                            value = "EN CONDUCCION X CLASIFICACION"
                        Case 0, -1
                            value = "NO REGISTRA"
                        Case Else
                            value = ""
                    End Select
                End If
                Return value
            End Get
        End Property
        Public Property DocJudIDAux As Integer = -1
        Public Property DocJudTipAux As Integer = -1

        Public Property IngresoSistemaPen As Long = 0
        Public Property IngresoPenal As Long = 0
        Public Property Eliminado As Integer = 0
        Public Property NumeroDocumentoAux As String = ""
        Public Property Idioma() As String = ""

        '------- agregados 2017
        Public Property GeneroId As Integer = -1
        Public Property IdiomaNativoId As Integer = -1

        Public Property CentroTrabajo As String = ""
        Public Property ReligionId As Integer = -1
        Public Property CodigoFuerzaArmadaId As Integer = -1
        Public Property CodigoRangoId As Integer = -1
        Public Property TrasladadoDeCarceleta As Integer = -1 '0=pendiente de traslado(se encuentra en carceleta),1=Trasladado a otro penal.
        Public Property EstadoBloqueoId As Integer = -1 '0=Sin bloqueo,1=Bloqueado

        Public Property EstadoAfiliacionID As Integer = -1
        Public ReadOnly Property EstadoAfiliacionNom As String
            Get
                Dim value As String = ""
                If Me.CodigoRP = "" Then
                    value = ""
                Else
                    Select Case Me.EstadoAfiliacionID
                        Case 0, -1
                            value = "NO AFILIADO"
                        Case Else
                            value = "AFILIADO"
                    End Select
                End If
                Return value
            End Get
        End Property
        Public Property FechaAfiliacion As Long = 0
        Public Property TipoInterno As Short = -1
        Public Property VersionRegistro As String = "" 'V45_P = ver 4.5 Prov  , V5_P  = ver 5 Provincia 
        '                                               V6_LM = Ver 6 Lima Met, V6_RLM = v6 region lima metropolitana
        '------- j.e.u 2021
        Public Property PertenenciaEtnicaId As Integer = -1
        Public Property PertenenciaEtnicaDetalleId As Integer = -1
        Public Property PertenenciaEtnicaOtros As String = ""
        Public Property LenguaMaternaId As Integer = -1
        Public Property LenguaMaternaDetalleId As Integer = -1
        Public Property IdiomaId As Integer = -1
#Region "Ubicacion"
        Private strPenalNombre As String = ""
        Public Property RegionID() As Integer = -1
        Public Property RegionNombre() As String = ""
        Public Property RegionCodigo() As String = ""
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
        Public Property PenalTipoLicencia As Short = -1
#End Region
#End Region
#Region "Propiedades_Familia"
        Private strPadre As String = ""
        Private strMadre As String = ""
        Private strConyugue As String = ""
        Public Property Padre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strPadre.Trim)
            End Get
            Set(ByVal value As String)
                strPadre = value
            End Set
        End Property
        Public Property Madre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strMadre.Trim)
            End Get
            Set(ByVal value As String)
                strMadre = value
            End Set
        End Property
        Public Property Conyugue() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strConyugue.Trim)
            End Get
            Set(ByVal value As String)
                strConyugue = value
            End Set
        End Property
        Public Property Estatura As String = ""
#End Region
#Region "Propiedades_Ubigeo"
        Public Property Departamento() As String = ""
        Public Property Provincia() As String = ""
        Public Property Distrito() As String = ""
        Public ReadOnly Property Ubigeo() As String
            Get
                Dim strValue As String = ""

                strValue = Me.Departamento & "/" & Me.Provincia & "/" & Me.Distrito
                Return Legolas.Components.Cadena.ProperCase(strValue)
            End Get
        End Property
        Public Property Nac_Departamento As String = ""
        Public Property Nac_Provincia As String = ""
        Public Property Nac_Distrito As String = ""
#End Region
#Region "Propiedades_Alias"
        Private strInternoAlias As String = ""
        Public Property InternoAlias() As String
            Get
                Return strInternoAlias.ToUpper
            End Get
            Set(ByVal value As String)
                strInternoAlias = value
            End Set
        End Property
#End Region
#Region "Propiedades_Ingreso"
        Private intIngresoNumero As Integer = -1
        Private strTipoIngreso As String = ""
        Public Property IngresoNumero() As Integer
            Get
                Return intIngresoNumero
            End Get
            Set(ByVal value As Integer)
                intIngresoNumero = value
            End Set
        End Property
        Public ReadOnly Property IngresoNumeroStr As String
            Get
                Dim v As String = ""
                If Me.IngresoNumero > 0 Then
                    v = Me.IngresoNumero
                End If
                Return v
            End Get
        End Property
        Public Property IngresoAux() As Integer = -1
        Public Property Tip_Mov() As Integer = -1
        Public Property SituacionJuridicaId() As Integer = -1
        Public Property SituacionJuridicaNom() As String = ""
        Public ReadOnly Property SituacionJuridicaReadonly() As String
            Get
                Dim value As String = ""

                Select Case Me.SituacionJuridicaId
                    Case 1
                        value = "PROC."
                    Case 2
                        value = "SENT."
                    Case 3
                        value = "SENT./PROC."
                    Case Else
                        value = ""
                End Select

                Return value

            End Get
        End Property

        Public Property MotivoIngresoID() As Integer = -1
        Public Property MotivoIngresoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoIngreso)
            End Get
            Set(ByVal value As String)
                strTipoIngreso = value
            End Set
        End Property
        Public Property MotivoTrasladoID() As Integer = -1
        Public Property MotivoTrasladoNombre() As String = ""

        Public Property FechaISP() As Long = 0
        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresoDate() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get
        End Property
      
        Public ReadOnly Property FechaISPString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaISP)
            End Get
        End Property
        Public Property NumeroDocumentoIngreso() As String = ""
        Public Property PenalOrigenNombre() As String = ""
#End Region
#Region "Propiedades_Delito"
        Private strDelitoGenerico As String = ""
        Private strDelitoEspecifico As String = ""
        Public Property DelitoGenerico() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDelitoGenerico)
            End Get
            Set(ByVal value As String)
                strDelitoGenerico = value
            End Set
        End Property
        Public Property DelitoEspecifico() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDelitoEspecifico)
            End Get
            Set(ByVal value As String)
                strDelitoEspecifico = value
            End Set
        End Property
#End Region
#Region "Propiedades_Expediente"
        Private strDistritoJudicial As String = ""
        Private strJuzgado As String = ""
        Public Property DistritoJudicial() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDistritoJudicial)
            End Get
            Set(ByVal value As String)
                strDistritoJudicial = value
            End Set
        End Property
        Public Property Juzgado() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strJuzgado)
            End Get
            Set(ByVal value As String)
                strJuzgado = value
            End Set
        End Property
#End Region
#Region "Propiedades_Sentencia"
        Private strAutoridadSentencia As String = ""
        Private blnSentenciaCadenaPerpetua As Boolean = False
        Public Property AutoridadSentencia() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strAutoridadSentencia)
            End Get
            Set(ByVal value As String)
                strAutoridadSentencia = value
            End Set
        End Property
        Public Property SalaSentencia() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strSalaSentencia)
            End Get
            Set(ByVal value As String)
                strSalaSentencia = value
            End Set
        End Property
        Public Property FechaSentencia() As Long = 0
        Public ReadOnly Property FechaSentenciaString() As String
            Get
                Dim value As String = ""
                If Me.FechaSentencia > 0 Then
                    value = Legolas.Components.FechaHora.FechaString(Me.FechaSentencia)
                End If
                Return value
            End Get
        End Property
        Public Property DocumentoSentencia() As String = ""
        Public Property SentenciaAnio() As Integer = -1
        Public Property SentenciaMes() As Integer = -1
        Public Property SentenciaDia() As Integer = -1
        Public Property SentenciaCadenaPerpetua() As Boolean = False
#End Region
#Region "Propiedades_Libertad"
        Private strDistritoJudicialNombre As String = ""
        Private strJuzgadoNombre As String = ""
        Private strDocumentoSalida As String = ""
        Private strTipoLibertad As String = ""
        Private strSalaSentencia As String = ""
        Public Property LibertadDistritoJudicialNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDistritoJudicialNombre)
            End Get
            Set(ByVal value As String)
                strDistritoJudicialNombre = value
            End Set
        End Property
        Public Property LibertadJuzgadoNombre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strJuzgadoNombre)
            End Get
            Set(ByVal value As String)
                strJuzgadoNombre = value
            End Set
        End Property
        Public Property DocumentoLibertad() As String = ""
        Public Property DocumentoExpedienteLibertad() As String = ""
        Public Property TipoLibertad() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoLibertad)
            End Get
            Set(ByVal value As String)
                strTipoLibertad = value
            End Set
        End Property
        Public Property FechaLibertad() As Long = 0
        Public ReadOnly Property FechaLibertadString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaLibertad)
            End Get
        End Property
        Public Property EgresoTipoID() As Integer = -1
        Public Property EgresoTipo() As String = ""
        Public Property EgresoTipoMotivoID As Integer = -1
        Public Property EgresoTipoMotivo As String = ""
#End Region
#Region "Propiedades_Foto"
        Private intFotoPerfilIzquierdo As Integer = 0
        Private intFotoPerfilFrente As Integer = 0
        Private intFotoPerfilDerecho As Integer = 0
        Public Property FotoPerfilIzquierdo() As Integer = -1
        Public ReadOnly Property FotoPI() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilIzquierdo > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPI() As System.Drawing.Image
            Get
                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre
                    Case 0

                        If Me.FotoPerfilIzquierdo > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If

                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
        Public Property FotoPerfilFrente() As Integer = -1
        Public ReadOnly Property FotoPF() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilFrente > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPF() As System.Drawing.Image
            Get

                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre
                    Case 0
                        If Me.FotoPerfilFrente > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If
                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
        Public Property FotoPerfilDerecho() As Integer = -1
        Public ReadOnly Property FotoPD() As Boolean
            Get
                Dim value As Boolean = False

                If Me.FotoPerfilDerecho > 0 Then
                    value = True
                End If

                Return value
            End Get
        End Property
        Public ReadOnly Property FotoIconoPD() As System.Drawing.Image
            Get
                Dim value As System.Drawing.Image = My.Resources.check_box_black

                Select Case Me.CodigoPadre

                    Case 0
                        If Me.FotoPerfilDerecho > 0 Then
                            value = My.Resources.check_box_green
                        Else
                            value = My.Resources.check_box_green2
                        End If
                    Case 1
                        value = My.Resources.check_box_black
                End Select

                Return value
            End Get
        End Property
#End Region
#Region "Propiedades_Visita"
        Public Property VisitaSancion() As Boolean = False
        Public ReadOnly Property VisitaSancionStr() As String
            Get
                Dim _str As String = ""
                If VisitaSancion = True Then
                    _str = "Sancionado"
                End If
                Return _str
            End Get
        End Property

#End Region
#Region "Propiedades_Filtro"
        Public Property NacionalidadExtranjero As Integer = -1
        Public Property DelitoGenericoID As Integer = -1
        Public Property DelitoEspecificoID As Integer = -1
        Public Property IngresoFechaDesde As Long = 0
        Public Property IngresoFechaHasta As Long = 0
        Public Property PenalMultiple As String = ""
        Public Property IDInternoString As String = ""
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
        Public Function Add(ByVal value As Interno) As Integer
            Return List.Add(value)
        End Function
        Public Function Contains(ByVal value As Interno) As Boolean
            Return List.Contains(value)
        End Function
        Public Function IndexOf(ByVal value As Interno) As Integer
            Return List.IndexOf(value)
        End Function
        Public Sub Insert(ByVal index As Integer, ByVal value As Interno)
            List.Insert(index, value)
        End Sub
        Default Public Property Item(ByVal index As Integer) As Interno
            Get
                Return DirectCast(List(index), Interno)
            End Get
            Set(ByVal value As Interno)
                List(index) = value
            End Set
        End Property
        Public Sub Remove(ByVal value As Interno)
            List.Remove(value)
        End Sub
        Public Function CloneCol() As Interno
            Return MyBase.MemberwiseClone
        End Function
        Public Function toList() As List(Of Interno)
            Dim a As New List(Of Interno)
            For Each i As Interno In InnerList
                a.Add(i)
            Next
            Return a
        End Function
    End Class
#End Region
End Namespace
